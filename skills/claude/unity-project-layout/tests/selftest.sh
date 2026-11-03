#!/bin/bash
# Self-test for the unity-project-layout tools: makes a throwaway Unity project from tests/fixture, then
# setup -> survey -> LayoutMover.Run -> rewrite_paths.py -> verify -> LayoutMover.Undo -> GUID check.
# Usage: selftest.sh [UNITY_EXE] [WORK_DIR]
#   UNITY_EXE defaults to the Unity 2023.2.22f1 Windows editor; WORK_DIR to a new temp folder (deleted on success).
# Needs Git Bash/MSYS or any POSIX shell, Python 3, and a licensed Unity editor. About 5 minutes.
set -u
HERE="$(cd "$(dirname "$0")" && pwd)"
SK="$HERE/../scripts"
UNITY="${1:-/c/Program Files/Unity 2023.2.22f1/Editor/Unity.exe}"
WORK="${2:-$(mktemp -d)}"
# Long path form: Unity given an 8.3 short path (C:/Users/ADMINI~1/...) compiles the scripts but cannot bind them to
# their classes, so prefabs save with an empty m_Script.
command -v cygpath >/dev/null && WORK="$(cygpath -m -l "$WORK")"
P="$WORK/LayoutTest"
fail(){ echo "SELFTEST FAIL: $*"; echo "work dir kept: $WORK"; exit 1; }
crash(){ grep -q "Crash!!!" "$1" && fail "Unity crashed, see $1"; }
run(){ local log="$WORK/$1.log"; shift; timeout 1200 "$UNITY" -batchmode -projectPath "$P" -logFile "$log" "$@" >/dev/null 2>&1; local c=$?; crash "$log"; return $c; }

echo "work dir: $WORK"
timeout 1200 "$UNITY" -batchmode -quit -createProject "$P" -logFile "$WORK/create.log" >/dev/null 2>&1 || fail "createProject"
cp -r "$HERE/fixture/Assets/." "$P/Assets/"; mkdir -p "$WORK/tools"; cp "$HERE/fixture/tools/build_data.py" "$WORK/tools/"
cp "$SK/LayoutMover.cs" "$P/Assets/Game/Code/Editor/"; cp "$HERE/layout-plan.json" "$WORK/"

run import -quit   # import and compile the fixture first: a prefab saved during the first import can lose its script
run setup -quit -executeMethod LayoutTestBuilder.Setup || fail "fixture setup"
python -I "$SK/survey_layout.py" "$P" --extra "$WORK/tools" --depth 3 > "$WORK/survey.txt" || fail "survey"
grep -q "editor open: no" "$WORK/survey.txt" || fail "survey thinks an editor is open"
run move -quit -executeMethod LayoutMover.Run -layoutPlan "$WORK/layout-plan.json" -layoutManifest "$WORK/moves.json" || fail "move"
grep -q "\[Layout\] steps=9 assets=12 removed=2 errors=0" "$WORK/move.log" || fail "move counts: $(grep '\[Layout\]' "$WORK/move.log")"
python -I "$SK/rewrite_paths.py" --project "$P" --manifest "$WORK/moves.json" --extra "$WORK/tools" --backup "$WORK/backup" > "$WORK/rewrite.txt" || fail "rewrite"
grep -q "made 15 replacements in 5 files" "$WORK/rewrite.txt" || fail "rewrite counts: $(grep made "$WORK/rewrite.txt")"
grep -q "build_data.py:2" "$WORK/rewrite.txt" || fail "joined path pieces not reported as a leftover"
# Open once to compile: the first compile after a move can still see the old script paths (CS2001), and a check run in
# that pass sees prefabs whose scripts are missing.
run compile -quit
run verify -executeMethod LayoutTestBuilder.Verify; V=$?
cat "$WORK/verify.txt" 2>/dev/null
[ $V -eq 0 ] || fail "verify"
run undo -quit -executeMethod LayoutMover.Undo -layoutManifest "$WORK/moves.json" || fail "undo"
tr -d '\r' < "$WORK/guids-before.txt" | while IFS='=' read p g; do
  m=$(grep -o "guid: [0-9a-f]*" "$P/$p.meta" 2>/dev/null | cut -d' ' -f2)
  [ "$m" = "$g" ] || { echo "undo lost $p"; exit 1; }
done || fail "undo did not restore every path and GUID"
echo "SELFTEST PASS (survey, move, rewrite, 14 verify checks, undo)"
[ -z "${2:-}" ] && rm -rf "$WORK"
exit 0
