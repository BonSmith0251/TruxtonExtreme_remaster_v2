"""List, adopt and install Truxton skills with drift checks and backups.

  skills.py roster [--json]
  skills.py adopt <name>
  skills.py install <name> --target codex [--target claude] [--dry-run] [--force-drifted]
"""
import argparse
import json
import shutil
import sys
from pathlib import Path

sys.path.insert(0, str(Path(__file__).resolve().parent))  # also under python -I
from common import (DEFAULT_ROLES, frontmatter, manager_dir, now, read_json,
                    root_dir, skill_targets, tree_hash)


def load_roles(root):
    return read_json(manager_dir(root) / "roles.json", DEFAULT_ROLES)


def install_log(root):
    path = manager_dir(root) / "skill-installs.jsonl"
    if not path.exists():
        return []
    return [json.loads(line) for line in path.read_text(encoding="utf-8").splitlines() if line.strip()]


def append_log(root, record):
    path = manager_dir(root) / "skill-installs.jsonl"
    path.parent.mkdir(parents=True, exist_ok=True)
    with path.open("a", encoding="utf-8") as handle:
        handle.write(json.dumps(record, ensure_ascii=False) + "\n")


def last_known_hash(log, name, target):
    """The hash the installed copy should have, from the most recent managed event."""
    for record in reversed(log):
        if record.get("skill") == name and record.get("target") == target:
            return record.get("hash")
    return None


def staged_copies(root):
    """Skill folders staged anywhere under extractor/, keyed by skill name."""
    extractor = Path(root) / "extractor"
    found = {}
    patterns = ["skills/*/SKILL.md", "*/skills/*/SKILL.md"]
    for pattern in patterns:
        for skill_md in extractor.glob(pattern):
            if any(part in ("Backups", "UnityProject") for part in skill_md.parts):
                continue
            found.setdefault(skill_md.parent.name, []).append(skill_md.parent)
    return found


def file_sources(installed, staged_folders):
    """Older installers copied single files; find the staged copy each installed file came from."""
    sources = []
    for file in sorted(p for p in installed.rglob("*") if p.is_file() and "__pycache__" not in p.parts):
        relative = file.relative_to(installed)
        content = file.read_bytes()
        match = next((str(folder) for folder in staged_folders
                      if (folder / relative).is_file() and (folder / relative).read_bytes() == content), None)
        if match is None:
            return []
        if match not in sources:
            sources.append(match)
    return sources


def role_skill_names(roles):
    names = set()
    for role in roles.values():
        if role.get("skill"):
            names.add(role["skill"])
        names.update(role.get("specialists", []))
    return names


def roster(root):
    roles = load_roles(root)
    targets = skill_targets()
    log = install_log(root)
    staged = staged_copies(root)
    managed_root = manager_dir(root) / "skills"

    names = set(role_skill_names(roles)) | set(staged)
    for directory in targets.values():
        if directory.exists():
            names.update(p.name for p in directory.iterdir() if p.name.startswith("truxton-") and (p / "SKILL.md").exists())

    skills = []
    for name in sorted(names):
        entry = {"skill": name, "installed": {}, "staged": [], "managed": (managed_root / name / "SKILL.md").exists()}
        staged_hashes = {}
        for folder in staged.get(name, []):
            digest = tree_hash(folder)
            staged_hashes[digest] = folder
            entry["staged"].append({"path": str(folder), "hash": digest})
        for target, directory in targets.items():
            folder = directory / name
            if not (folder / "SKILL.md").exists():
                continue
            digest = tree_hash(folder)
            expected = last_known_hash(log, name, target)
            if expected:
                state = "in sync" if digest == expected else "DRIFT: changed since last managed install"
            elif digest in staged_hashes:
                state = "unmanaged, matches " + str(staged_hashes[digest])
            else:
                sources = file_sources(folder, staged.get(name, []))
                if sources:
                    state = "unmanaged, assembled file-by-file from " + " + ".join(sources)
                else:
                    state = "unmanaged, no staged copy matches"
            entry["installed"][target] = {"path": str(folder), "hash": digest, "state": state}
        if entry["managed"]:
            managed_hash = tree_hash(managed_root / name)
            pending = [t for t, info in entry["installed"].items() if info["hash"] != managed_hash]
            entry["pendingInstall"] = pending if entry["installed"] else ["not installed anywhere"]
        skills.append(entry)

    missing = []
    for role, info in roles.items():
        skill = info.get("skill")
        if skill and not any(s["skill"] == skill and (s["installed"] or s["managed"]) for s in skills):
            missing.append({"role": role, "skill": skill})
    return {"root": str(root), "targets": {k: str(v) for k, v in targets.items()}, "roles": roles,
            "missingRoleSkills": missing, "skills": skills}


def print_roster(report):
    print("Skill directories:", ", ".join(f"{k}={v}" for k, v in report["targets"].items()))
    print("\nRoles:")
    for role, info in report["roles"].items():
        extra = f" (+{len(info.get('specialists', []))} specialists)" if info.get("specialists") else ""
        print(f"  {role:<9} -> {info.get('skill')}{extra}")
    if report["missingRoleSkills"]:
        print("\nMissing role skills (create these first):")
        for item in report["missingRoleSkills"]:
            print(f"  {item['role']}: {item['skill']}")
    print("\nSkills:")
    for entry in report["skills"]:
        flags = []
        if entry["managed"]:
            flags.append("managed")
        if entry.get("pendingInstall"):
            flags.append("pending install: " + ", ".join(entry["pendingInstall"]))
        print(f"  {entry['skill']}" + (f"  [{'; '.join(flags)}]" if flags else ""))
        for target, info in entry["installed"].items():
            print(f"    {target}: {info['state']}")
        if not entry["installed"]:
            print("    not installed")
        if len(entry["staged"]) > 1:
            print(f"    {len(entry['staged'])} staged copies:")
            for copy in entry["staged"]:
                print(f"      {copy['hash'][:12]}  {copy['path']}")


def adopt(root, name):
    destination = manager_dir(root) / "skills" / name
    if destination.exists():
        sys.exit(f"{destination} already exists; edit it there.")
    targets = skill_targets()
    source_target = next((t for t in ("codex", "claude") if (targets[t] / name / "SKILL.md").exists()), None)
    if not source_target:
        sys.exit(f"{name} is not installed in {', '.join(map(str, targets.values()))}.")
    source = targets[source_target] / name
    digest = tree_hash(source)
    matched = [str(folder) for folder in staged_copies(root).get(name, []) if tree_hash(folder) == digest]
    shutil.copytree(source, destination, ignore=shutil.ignore_patterns("__pycache__"))
    for target, directory in targets.items():
        if (directory / name / "SKILL.md").exists():
            append_log(root, {"time": now(), "event": "adopt", "skill": name, "target": target,
                              "hash": tree_hash(directory / name), "source": str(source), "matchedStaged": matched})
    print(f"Adopted {name} from {source} into {destination}" + (f"; matched {matched[0]}" if matched else "; no older staged copy matched"))


def validate_skill(folder, name):
    skill_md = folder / "SKILL.md"
    if not skill_md.exists():
        sys.exit(f"{skill_md} is missing.")
    fields = frontmatter(skill_md)
    if fields.get("name") != name:
        sys.exit(f"Frontmatter name {fields.get('name')!r} does not match folder {name!r}.")
    if len(fields.get("description", "")) < 40:
        sys.exit("Frontmatter description is missing or too short to trigger reliably.")


def install(root, name, target_names, dry_run=False, force_drifted=False):
    source = manager_dir(root) / "skills" / name
    validate_skill(source, name)
    source_hash = tree_hash(source)
    targets = skill_targets()
    log = install_log(root)
    staged = {tree_hash(folder) for folder in staged_copies(root).get(name, [])}
    stamp = now().replace(":", "").replace("-", "")[:15]
    backup_root = Path(root) / "extractor" / "Backups" / f"before-skill-{name}-{stamp}"

    plan = []
    for target in target_names:
        destination = targets[target] / name
        current = tree_hash(destination)
        expected = last_known_hash(log, name, target)
        if current == source_hash:
            plan.append((target, destination, current, "already installed"))
        elif current is None or current == expected or (expected is None and current in staged):
            plan.append((target, destination, current, "install"))
        elif force_drifted:
            plan.append((target, destination, current, "install over drifted copy"))
        else:
            sys.exit(f"{destination} changed outside the manager (hash {current[:12]}). "
                     "Compare it with the staged copy, merge what's worth keeping, then rerun "
                     "with --force-drifted once the user agrees.")

    for target, destination, current, action in plan:
        print(f"{target}: {action} -> {destination}")
    if dry_run:
        return

    for target, destination, current, action in plan:
        if action == "already installed":
            continue
        backup = None
        if current is not None:
            backup = backup_root / target / name
            shutil.copytree(destination, backup)
            if tree_hash(backup) != current:
                sys.exit(f"Backup of {destination} did not verify; nothing was replaced.")
            shutil.rmtree(destination)
        destination.parent.mkdir(parents=True, exist_ok=True)
        shutil.copytree(source, destination, ignore=shutil.ignore_patterns("__pycache__"))
        if tree_hash(destination) != source_hash:
            sys.exit(f"Installed copy at {destination} does not match the staged hash.")
        append_log(root, {"time": now(), "event": "install", "skill": name, "target": target, "hash": source_hash,
                          "previous": current, "backup": str(backup) if backup else None, "action": action})
        print(f"{target}: installed, hash {source_hash[:12]}" + (f", backup {backup}" if backup else ""))


def main():
    parser = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    parser.add_argument("--root", help="Truxton workspace (default TRUXTON_ROOT or D:\\games\\Truxton Extreme)")
    commands = parser.add_subparsers(dest="command", required=True)
    show = commands.add_parser("roster")
    show.add_argument("--json", action="store_true")
    take = commands.add_parser("adopt")
    take.add_argument("name")
    put = commands.add_parser("install")
    put.add_argument("name")
    put.add_argument("--target", action="append", choices=["codex", "claude"], required=True)
    put.add_argument("--dry-run", action="store_true")
    put.add_argument("--force-drifted", action="store_true")
    args = parser.parse_args()
    root = root_dir(args.root)

    if args.command == "roster":
        report = roster(root)
        print(json.dumps(report, indent=2)) if args.json else print_roster(report)
    elif args.command == "adopt":
        adopt(root, args.name)
    else:
        install(root, args.name, args.target, args.dry_run, args.force_drifted)


if __name__ == "__main__":
    main()
