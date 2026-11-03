#!/usr/bin/env python3
"""Read-only file inventory and conservative Unity hints; not an asset parser."""

import argparse
import hashlib
import json
import os
from pathlib import Path
import re
import stat
import sys
from datetime import datetime, timezone


VERSION = re.compile(rb"(?<![0-9A-Za-z])(?:[3-6]\.[0-9]+|20[0-9]{2}\.[0-9]+|6000\.[0-9]+)\.[0-9]+[abfp][0-9]+(?![0-9A-Za-z])")
BUNDLE_MAGIC = (b"UnityFS\x00", b"UnityWeb\x00", b"UnityRaw\x00", b"UnityArchive\x00")


def within(path, parent):
    return path == parent or parent in path.parents


def inspect_file(path, relative, info, hash_files):
    name = path.name.lower()
    parts = [part.lower() for part in Path(relative).parts]
    categories = []
    if name in {"globalgamemanagers", "globalgamemanagers.assets", "maindata", "resources.assets"} or name.endswith(".assets") or re.fullmatch(r"level\d+(?:\.resS)?", path.name, re.I):
        categories.append("serialized-file-candidate")
    if name.endswith((".ress", ".resource")):
        categories.append("resource-stream")
    if "streamingassets" in parts:
        categories.append("streaming-assets")
    if "managed" in parts and name.endswith(".dll"):
        categories.append("managed-assembly-candidate")
    if name == "global-metadata.dat":
        categories.append("il2cpp-metadata-candidate")
    if name in {"gameassembly.dll", "libil2cpp.so"}:
        categories.append("il2cpp-native-candidate")
    if any("monobleedingedge" == p or p == "monoruntime" for p in parts) or name in {"mono-2.0-bdwgc.dll", "libmonobdwgc-2.0.so"}:
        categories.append("mono-runtime-candidate")
    if "catalog" in name or ("aa" in parts and name in {"settings.json", "settings.bin"}):
        categories.append("addressables-candidate")
    if name.endswith((".bundle", ".unity3d", ".assetbundle")):
        categories.append("bundle-candidate")
    if name.endswith((".apk", ".aab", ".obb", ".ipa", ".zip")):
        categories.append("archive-candidate")
    if name.endswith((".wasm", ".wasm.br", ".wasm.gz", ".data", ".data.br", ".data.gz", ".unityweb")):
        categories.append("webgl-or-data-candidate")
    if name.endswith((".bank", ".bnk", ".wem", ".wav", ".ogg", ".mp3", ".mp4", ".webm")):
        categories.append("audio-video-candidate")
    row = {"path": relative, "size": info.st_size, "mtime_ns": str(info.st_mtime_ns), "categories": categories}
    with path.open("rb") as stream:
        head = stream.read(4096)
        if head.startswith(BUNDLE_MAGIC):
            categories.append("unity-bundle-signature")
        if head.startswith(b"\x00asm"):
            categories.append("wasm-signature")
        if head.startswith(b"PK\x03\x04"):
            categories.append("zip-signature")
        if name in {"globalgamemanagers", "maindata", "data.unity3d"} or "serialized-file-candidate" in categories or "unity-bundle-signature" in categories:
            versions = sorted({m.decode("ascii") for m in VERSION.findall(head)})
            if versions:
                row["unity_version_hints"] = versions
        if hash_files:
            digest = hashlib.sha256(head)
            for chunk in iter(lambda: stream.read(1024 * 1024), b""):
                digest.update(chunk)
            row["sha256"] = digest.hexdigest()
    after = path.stat()
    if (after.st_size, after.st_mtime_ns) != (info.st_size, info.st_mtime_ns):
        raise OSError("File changed while being inventoried; retry from a stable input")
    if not categories:
        categories.append("unclassified")
    return row


def inventory(root, excluded, hash_files):
    files, skipped, errors = [], [], []
    pending = [root]
    while pending:
        directory = pending.pop()
        try:
            with os.scandir(directory) as entries:
                children = sorted(entries, key=lambda entry: entry.name.casefold())
        except OSError as exc:
            errors.append({"path": directory.relative_to(root).as_posix(), "error": str(exc)})
            continue
        for entry in children:
            path = Path(entry.path)
            relative = path.relative_to(root).as_posix()
            if any(within(path, target) for target in excluded):
                skipped.append({"path": relative, "reason": "excluded"})
                continue
            try:
                info = entry.stat(follow_symlinks=False)
                if entry.is_symlink() or getattr(info, "st_file_attributes", 0) & getattr(stat, "FILE_ATTRIBUTE_REPARSE_POINT", 1024):
                    skipped.append({"path": relative, "reason": "symlink-or-reparse-point"})
                elif stat.S_ISDIR(info.st_mode):
                    pending.append(path)
                elif stat.S_ISREG(info.st_mode):
                    files.append(inspect_file(path, relative, info, hash_files))
                else:
                    skipped.append({"path": relative, "reason": "non-regular-file"})
            except OSError as exc:
                errors.append({"path": relative, "error": str(exc)})
    files.sort(key=lambda row: row["path"])
    counts = {}
    backend = {"mono_evidence": [], "il2cpp_evidence": []}
    versions = []
    for row in files:
        for category in row["categories"]:
            counts[category] = counts.get(category, 0) + 1
            if category == "mono-runtime-candidate":
                backend["mono_evidence"].append(row["path"])
            if category.startswith("il2cpp-"):
                backend["il2cpp_evidence"].append(row["path"])
        for version in row.get("unity_version_hints", []):
            versions.append({"version": version, "path": row["path"], "evidence": "unparsed-header-string"})
    return {
        "schema": "unity-build-file-inventory/1",
        "created_utc": datetime.now(timezone.utc).isoformat(),
        "root": str(root),
        "sha256_enabled": hash_files,
        "exclusions": [str(p) for p in excluded],
        "scope": "Regular files only; no archive unpacking, object parsing, or payload extraction. Categories and backend/version evidence require confirmation.",
        "backend_hints": backend,
        "unity_version_hints": versions,
        "summary": {"files": len(files), "bytes": sum(f["size"] for f in files), "errors": len(errors), "skipped": len(skipped), "category_counts": counts},
        "files": files,
        "skipped": skipped,
        "errors": errors,
    }


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--root", required=True, type=Path)
    parser.add_argument("--out", required=True, type=Path, help="New JSON report path; existing files are never overwritten")
    parser.add_argument("--exclude", action="append", default=[], type=Path, help="Absolute or root-relative file/directory, repeatable")
    parser.add_argument("--sha256", action="store_true", help="Hash complete files, including large payloads")
    args = parser.parse_args()
    root = args.root.resolve()
    out = args.out.absolute()
    if not root.is_dir():
        parser.error("--root must be an existing directory")
    if out.exists() or out.is_symlink():
        parser.error("--out already exists; choose a new report path")
    out = out.resolve()
    excluded = [(p if p.is_absolute() else root / p).resolve() for p in args.exclude]
    if any(within(root, p) for p in excluded):
        parser.error("An exclusion covers the entire input root")
    excluded.append(out)
    report = inventory(root, excluded, args.sha256)
    try:
        out.parent.mkdir(parents=True, exist_ok=True)
        with out.open("x", encoding="utf-8") as stream:
            json.dump(report, stream, indent=2, ensure_ascii=False)
            stream.write("\n")
    except OSError as exc:
        print(f"Cannot write report: {exc}", file=sys.stderr)
        return 1
    print(json.dumps({"report": str(out), **report["summary"]}))
    return 2 if report["errors"] else 0


if __name__ == "__main__":
    sys.exit(main())
