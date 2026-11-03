#!/bin/bash
# Self-test for unity-prefab-organizer: throwaway Unity project from tests/fixture (flat Prefabs: player with a nested
# turret, enemy + variant, bullet, explosion, Canvas HUD, coin, rock, light, manager, an unused prefab, one in
# Resources, a scene, code naming a prefab), then: PrefabCheck before -> survey -> plan (with renames) -> expected
# destinations -> LayoutMover -> rewrite -> PrefabCheck after -> diff -> undo -> diff.
# Usage: selftest.sh [UNITY_EXE] [WORK_DIR]    (needs the sibling unity-project-layout skill; about 5 minutes)
set -u
HERE="$(cd "$(dirname "$0")" && pwd)"
SK="$HERE/../scripts"
LAYOUT="$HERE/../../unity-project-layout/scripts"
UNITY="${1:-/c/Program Files/Unity 2023.2.22f1/Editor/Unity.exe}"
WORK="${2:-$(mktemp -d)}"
# Long path form: Unity given an 8.3 short path (C:/Users/ADMINI~1/...) compiles the scripts but cannot bind them to
# their classes, so prefabs save with an empty m_Script.
command -v cygpath >/dev/null && WORK="$(cygpath -m -l "$WORK")"
P="$WORK/PrefabTest"
fail(){ echo "SELFTEST FAIL: $*"; echo "work dir kept: $WORK"; exit 1; }
run(){ local log="$WORK/$1.log"; shift; timeout 1200 "$UNITY" -batchmode -projectPath "$P" -logFile "$log" "$@" >/dev/null 2>&1; local c=$?
       grep -q "Crash!!!" "$log" && fail "Unity crashed, see $log"; return $c; }
[ -f "$LAYOUT/LayoutMover.cs" ] || fail "unity-project-layout skill not found next to this one"

echo "work dir: $WORK"
timeout 1200 "$UNITY" -batchmode -quit -createProject "$P" -logFile "$WORK/create.log" >/dev/null 2>&1 || fail "createProject"
cp -r "$HERE/fixture/Assets/." "$P/Assets/"; cp "$SK/PrefabCheck.cs" "$LAYOUT/LayoutMover.cs" "$P/Assets/Editor/"
run import -quit   # import and compile the fixture first: a prefab saved during the first import can lose its script
run setup -quit -executeMethod PrefabFixture.Setup || fail "fixture setup"
run before -executeMethod PrefabCheck.Run -prefabCheckOut "$WORK/before.json" || fail "PrefabCheck before"

python -I "$SK/prefab_survey.py" "$P" --scope Assets/Prefabs --scope Assets/Resources --exclude PrefabFixture.cs --out "$WORK/prefabs.json" > "$WORK/survey.txt" 2>&1 || fail "survey"
grep -q "variants 1   with nested prefabs 1   used only by other prefabs 2   unused 4" "$WORK/survey.txt" || fail "survey counts: $(grep variants "$WORK/survey.txt")"
python -I "$SK/prefab_plan.py" "$WORK/prefabs.json" --renames "$HERE/renames.json" --plan "$WORK/plan.json" --review "$WORK/plan.md" > "$WORK/plan.txt" || fail "plan"
grep -q "renames refused: 1" "$WORK/plan.txt" || fail "the rename of a name-referenced prefab was not refused"
python -I - "$WORK/plan.json" "$HERE/expected.json" <<'EOF' || fail "plan destinations"
import json, sys
plan = {s['from']: s['to'] for s in json.load(open(sys.argv[1]))['steps']}
expected = json.load(open(sys.argv[2]))
bad = ['%s -> %s (expected %s)' % (k, plan.get(k), v) for k, v in expected.items() if plan.get(k) != v]
bad += ['unexpected move %s' % k for k in plan if k not in expected]
print('\n'.join(bad) or 'plan destinations as expected (%d moves)' % len(plan)); sys.exit(1 if bad else 0)
EOF

run move -quit -executeMethod LayoutMover.Run -layoutPlan "$WORK/plan.json" -layoutManifest "$WORK/moves.json" || fail "move"
python -I "$LAYOUT/rewrite_paths.py" --project "$P" --manifest "$WORK/moves.json" --backup "$WORK/backup" > "$WORK/rewrite.txt" || fail "rewrite"
run after -executeMethod PrefabCheck.Run -prefabCheckOut "$WORK/after.json" || fail "PrefabCheck after"
python -I "$SK/prefab_check_diff.py" "$WORK/before.json" "$WORK/after.json" | tee "$WORK/diff.txt"; [ "${PIPESTATUS[0]}" -eq 0 ] || fail "prefab health changed by the move"
grep -q "12 moved; 0 problems" "$WORK/diff.txt" || fail "expected 12 moved prefabs"
run undo -quit -executeMethod LayoutMover.Undo -layoutManifest "$WORK/moves.json" || fail "undo"
run undone -executeMethod PrefabCheck.Run -prefabCheckOut "$WORK/undone.json" || fail "PrefabCheck after undo"
python -I "$SK/prefab_check_diff.py" "$WORK/before.json" "$WORK/undone.json" | tee "$WORK/diff-undo.txt" | grep -q "0 moved; 0 problems" || fail "undo: $(cat "$WORK/diff-undo.txt")"
echo "SELFTEST PASS (survey counts, plan destinations, refused rename, move, health diff, undo)"
[ -z "${2:-}" ] && rm -rf "$WORK"
exit 0
