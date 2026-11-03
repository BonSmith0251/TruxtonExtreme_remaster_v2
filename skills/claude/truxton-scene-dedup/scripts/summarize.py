"""Print a SceneDedup report: per target, the groups found, how many copies can be replaced and why others can't.

  python summarize.py report.json [--all]
"""
import json
import sys
from collections import Counter


def main():
    report = json.load(open(sys.argv[1], encoding="utf-8"))
    show_all = "--all" in sys.argv
    for r in report["reports"]:
        before, after = r.get("before") or {}, r.get("after") or {}
        line = f"\n{r['target']} [{r['mode']}] {'PASS' if r['passed'] else 'FAIL'}"
        line += f"  objects {before.get('gameObjects')}  bytes {before.get('fileBytes')}"
        if r["mode"] == "apply" and after:
            line += f" -> {after.get('fileBytes')}  instances {after.get('prefabInstances')}  digest {'match' if r['digestMatch'] else 'MISMATCH'}"
        print(line)
        print(f"  groups found {r['groupsFound']}, planned {r['groupsPlanned']} ({r['copiesPlanned']} copies), applied {r['groupsApplied']} ({r['copiesReplaced']} copies)")
        if r.get("error"):
            print("  error:", r["error"])
        for m in r.get("digestMismatches", [])[:10]:
            print("  mismatch:", m)
        for g in r["groups"] if show_all else r["groups"][:25]:
            state = "planned" if g["planned"] else "redundant" if g["redundant"] else "skipped"
            reasons = Counter(o["blocked"] for o in g["occurrences"] if o["blocked"])
            print(f"  {g['name'][:40]:40} x{g['count']:<4} replaceable {g['replaceable']:<4} objects {g['objectsEach']:<3} {state:9} {dict(reasons) if reasons else ''}")


if __name__ == "__main__":
    main()
