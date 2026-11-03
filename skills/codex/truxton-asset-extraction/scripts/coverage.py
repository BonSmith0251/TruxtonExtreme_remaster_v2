"""Reconcile selected Truxton exports with inventory; this is not a payload validator."""
import argparse
import json
import re
from collections import Counter
from pathlib import Path


def read_json(path):
    return json.loads(path.read_text(encoding="utf-8-sig"))


def identity(row):
    source = row["source"].replace("\\", "/").casefold()
    cab = row.get("cab", row.get("serialized_file"))
    pid = row.get("pathId", row.get("path_id"))
    if not cab or pid is None or isinstance(pid, float):
        raise ValueError("Missing identity or floating-point PathID")
    return source, cab.casefold(), str(int(pid))


def coverage(inventory_path, objects_path, export_dirs):
    inventory = read_json(inventory_path)
    listed, raw, represented = set(), set(), set()
    issues, export_summaries = [], []
    for directory in sorted({p.resolve() for p in export_dirs}):
        graph_path = directory / "dependency_graph.json"
        graph = read_json(graph_path)
        manifest_path = directory / "manifest.json"
        manifest = read_json(manifest_path) if manifest_path.is_file() else {}
        manifest_ids = {str(r["id"]) for k in ("prefabs", "meshes", "textures", "materials", "animations")
                        for r in manifest.get(k, [])}
        valid_raw = 0
        local_issues = []
        graph_ids = {str(r["id"]) for r in graph["objects"]}
        for row in graph["objects"]:
            key = identity(row)
            listed.add(key)
            object_id = str(row["id"])
            if object_id in manifest_ids:
                represented.add(key)
            try:
                if not re.fullmatch(r"[0-9a-f]{24}", object_id):
                    raise ValueError("Invalid exporter ID")
                # IDs are checked before joining paths; files must stay inside the export.
                raw_path = (directory / "raw" / (object_id + ".json")).resolve()
                if not raw_path.is_relative_to(directory):
                    raise ValueError("Raw path escapes export directory")
                tree = read_json(raw_path)
                if not isinstance(tree, dict):
                    raise ValueError("Raw tree is not a JSON object")
                raw.add(key)
                valid_raw += 1
            except (OSError, ValueError) as error:
                local_issues.append({"id": object_id, "error": str(error)})
        missing_manifest_ids = sorted(manifest_ids - graph_ids)
        for object_id in missing_manifest_ids:
            local_issues.append({"id": object_id, "error": "Manifest ID absent from dependency graph"})
        issues.extend({"export": str(directory), **issue} for issue in local_issues)
        export_summaries.append({"directory": str(directory), "listed_records": len(graph["objects"]),
                                 "parseable_raw_records": valid_raw, "missing_manifest": not manifest_path.is_file(),
                                 "graph_errors": graph.get("errors", []),
                                 "manifest_warnings": manifest.get("warnings", []),
                                 "output_issue_count": len(local_issues)})

    counts = {}
    unmatched_exports = set(listed)
    remaining_examples = []
    seen = set()
    duplicate_records = 0
    with objects_path.open(encoding="utf-8-sig") as stream:
        for line_number, line in enumerate(stream, 1):
            if not line.strip():
                continue
            row = json.loads(line)
            key = identity(row)
            if key in seen:
                duplicate_records += 1
                continue
            seen.add(key)
            unmatched_exports.discard(key)
            count = counts.setdefault(row["type"], Counter())
            count["inventoried"] += 1
            count["listed_in_selection"] += int(key in listed)
            count["parseable_raw_json"] += int(key in raw)
            count["manifest_representation"] += int(key in represented)
            if key not in raw:
                count["without_selection_raw_json"] += 1
                if len(remaining_examples) < 30:
                    remaining_examples.append({"source": row["source"], "cab": key[1], "pathId": key[2],
                                               "type": row["type"], "name": row.get("name", "")})
    totals = Counter()
    for count in counts.values():
        totals.update(count)
    scan_counts = inventory["counts"]
    disagreements = {kind: {"inventory": scan_counts.get(kind, 0), "jsonl": counts.get(kind, {}).get("inventoried", 0)}
                     for kind in set(scan_counts) | set(counts)
                     if scan_counts.get(kind, 0) != counts.get(kind, {}).get("inventoried", 0)}
    source_failures = [{"source": r["source"], "error": r["error"]}
                       for r in inventory["sources"] if r.get("error")]
    source_read_errors = [{"source": r["source"], "count": len(r.get("read_errors", []))}
                          for r in inventory["sources"] if r.get("read_errors")]
    return {
        "schema": 1,
        "scope": "Existing selection graphs, raw JSON and manifest entries only; not whole-game extraction certification",
        "not_measured": ["Native movies", "Standalone HUD exports", "Opaque Comic contents", "Raw binary archives",
                         "Decoded payload validity", "Unity import or visual fidelity", "Unscanned installation files"],
        "totals": dict(totals), "by_type": {k: dict(v) for k, v in sorted(counts.items())},
        "scanned_sources": len(inventory["sources"]), "source_failures": source_failures,
        "source_read_errors": source_read_errors, "inventory_count_disagreements": disagreements,
        "duplicate_inventory_records": duplicate_records, "exports": export_summaries,
        "output_issues": issues, "export_identities_absent_from_inventory": [list(k) for k in sorted(unmatched_exports)],
        "remaining_examples": remaining_examples,
    }


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--inventory", required=True, type=Path)
    parser.add_argument("--objects", required=True, type=Path)
    parser.add_argument("--export-dir", action="append", default=[], type=Path,
                        help="Explicit selection export; repeatable")
    parser.add_argument("--exports-root", type=Path,
                        help="Discover graph files directly here and one directory below; excludes nested backups")
    parser.add_argument("--out", required=True, type=Path)
    args = parser.parse_args()
    directories = list(args.export_dir)
    if args.exports_root:
        directories.extend(p.parent for p in args.exports_root.glob("*/dependency_graph.json"))
        if (args.exports_root / "dependency_graph.json").is_file():
            directories.append(args.exports_root)
    protected = {args.inventory.resolve(), args.objects.resolve()}
    for directory in directories:
        protected.update((directory / name).resolve() for name in ("dependency_graph.json", "manifest.json"))
    if args.out.resolve() in protected or any(args.out.resolve().is_relative_to(p.resolve()) for p in directories):
        parser.error("Report output must be separate from inventory inputs and selection export directories")
    report = coverage(args.inventory, args.objects, directories)
    args.out.parent.mkdir(parents=True, exist_ok=True)
    args.out.write_text(json.dumps(report, indent=2, ensure_ascii=True) + "\n", encoding="utf-8")
    print(json.dumps({"report": str(args.out.resolve()), "selection_exports": len(report["exports"]),
                      "totals": report["totals"], "source_failures": len(report["source_failures"]),
                      "output_issues": len(report["output_issues"])}))


if __name__ == "__main__":
    main()
