"""Track every remaster subject through pioneer -> extractor -> checker -> verified.

  ledger.py init
  ledger.py add BG03/Md01/index1 [--skill truxton-md01-manoeuvres] [--note ...]
  ledger.py set BG03/Md01/index1 observed --role pioneer [--artifact observation=handoffs/...] [--note ...]
  ledger.py status [--stage BG03] [--json]
  ledger.py next [--stage BG03]
  ledger.py remove BG03/Sa01/1a --note "duplicate of BG03/Sa01/top-entry"   (kept under 'removed')

Artifact paths are relative to extractor/manager/. A subject only becomes
'verified' when its comparison artifact exists and says "pass".
"""
import argparse
import json
import sys
from pathlib import Path

sys.path.insert(0, str(Path(__file__).resolve().parent))  # also under python -I
from common import manager_dir, now, read_json, root_dir, write_json

STATES = ["todo", "observed", "extracted", "checked", "verified", "mismatch", "blocked"]
ROLES = ["pioneer", "extractor", "checker", "manager", "user"]

NEXT = {
    "todo": ("pioneer", "record observation.original.json (truxton-track/1) for every instance"),
    "observed": ("extractor", "update the remaster from the observation; write change.json"),
    "extracted": ("checker", "capture the remaster and run compare_tracks.py; write comparison.json"),
    "checked": ("manager", "re-run compare_tracks.py yourself; mark verified only on your own pass"),
    "mismatch": ("manager", "read comparison.json and route: extractor if the remaster is wrong, pioneer if the observation is"),
    "blocked": ("user", "needs a decision; see the last note"),
    "verified": (None, "done"),
}


def ledger_path(root):
    return manager_dir(root) / "ledger.json"


def load(root):
    return read_json(ledger_path(root), {"schema": "truxton-ledger/1", "updated": None, "subjects": {}})


def save(root, ledger):
    ledger["updated"] = now()
    write_json(ledger_path(root), ledger)


def parse_subject(subject):
    parts = subject.split("/")
    if len(parts) not in (2, 3) or not all(parts):
        sys.exit(f"Subject {subject!r} should look like <stage>/<family>[/<variant>], e.g. BG03/Md01/index1.")
    return {"stage": parts[0], "family": parts[1], "variant": parts[2] if len(parts) == 3 else None}


def require_pass(root, entry):
    comparison = entry.get("artifacts", {}).get("comparison")
    if not comparison:
        sys.exit("Set a comparison artifact (--artifact comparison=...) before marking verified.")
    path = manager_dir(root) / comparison
    report = read_json(path)
    if report is None:
        sys.exit(f"Comparison file {path} does not exist.")
    if report.get("verdict") != "pass":
        sys.exit(f"Comparison verdict is {report.get('verdict')!r}, not 'pass'.")


def main():
    parser = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    parser.add_argument("--root")
    commands = parser.add_subparsers(dest="command", required=True)
    commands.add_parser("init")
    add = commands.add_parser("add")
    add.add_argument("subject")
    add.add_argument("--skill")
    add.add_argument("--state", choices=STATES, default="todo")
    add.add_argument("--note", default="")
    change = commands.add_parser("set")
    change.add_argument("subject")
    change.add_argument("state", choices=STATES)
    change.add_argument("--role", choices=ROLES, required=True)
    change.add_argument("--artifact", action="append", default=[], help="kind=relative/path")
    change.add_argument("--skill")
    change.add_argument("--note", default="")
    drop = commands.add_parser("remove")
    drop.add_argument("subject")
    drop.add_argument("--note", required=True)
    for name in ("status", "next"):
        view = commands.add_parser(name)
        view.add_argument("--stage")
        view.add_argument("--json", action="store_true")
    args = parser.parse_args()
    root = root_dir(args.root)
    ledger = load(root)
    subjects = ledger["subjects"]

    if args.command == "init":
        save(root, ledger)
        print(f"Ledger at {ledger_path(root)} with {len(subjects)} subjects.")
    elif args.command == "add":
        if args.subject in subjects:
            sys.exit(f"{args.subject} already exists; use 'set'.")
        entry = parse_subject(args.subject)
        entry.update(state=args.state, skill=args.skill, artifacts={},
                     history=[{"time": now(), "role": "manager", "state": args.state, "note": args.note}])
        subjects[args.subject] = entry
        save(root, ledger)
        print(f"Added {args.subject} ({args.state}).")
    elif args.command == "remove":
        entry = subjects.pop(args.subject, None)
        if entry is None:
            sys.exit(f"Unknown subject {args.subject}.")
        entry["history"].append({"time": now(), "role": "manager", "state": "removed", "note": args.note})
        ledger.setdefault("removed", {})[args.subject] = entry
        save(root, ledger)
        print(f"Removed {args.subject}.")
    elif args.command == "set":
        entry = subjects.get(args.subject)
        if entry is None:
            sys.exit(f"Unknown subject {args.subject}; add it first.")
        for item in args.artifact:
            if "=" not in item:
                sys.exit(f"Artifact {item!r} should be kind=path.")
            kind, path = item.split("=", 1)
            entry.setdefault("artifacts", {})[kind] = path.replace("\\", "/")
        if args.skill:
            entry["skill"] = args.skill
        if args.state == "verified":
            if args.role != "manager":
                sys.exit("Only the manager marks a subject verified, after reproducing the comparison.")
            require_pass(root, entry)
        entry["state"] = args.state
        entry["history"].append({"time": now(), "role": args.role, "state": args.state, "note": args.note,
                                 "artifacts": args.artifact or None})
        save(root, ledger)
        print(f"{args.subject}: {args.state}.")
    else:
        rows = {k: v for k, v in sorted(subjects.items()) if not args.stage or v["stage"] == args.stage}
        if args.json:
            print(json.dumps(rows, indent=2))
            return
        if not rows:
            print("No subjects yet. Add them with 'ledger.py add <stage>/<family>/<variant>'.")
            return
        if args.command == "status":
            counts = {}
            for entry in rows.values():
                counts[entry["state"]] = counts.get(entry["state"], 0) + 1
            print("  ".join(f"{state}={counts[state]}" for state in STATES if state in counts))
            for subject, entry in rows.items():
                last = entry["history"][-1]
                print(f"  {subject:<28} {entry['state']:<10} {last['time'][:16]}  {last['role']}: {last['note']}")
        else:
            for subject, entry in rows.items():
                role, action = NEXT[entry["state"]]
                if role:
                    print(f"  {subject:<28} -> {role}: {action}")


if __name__ == "__main__":
    main()
