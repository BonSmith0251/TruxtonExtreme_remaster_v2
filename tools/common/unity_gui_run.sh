#!/bin/bash
# Runs a GUI (non-batch) Unity editor and waits for it to exit, with tools/common/unity_admin_dialog_dismiss.ps1
# watching for Unity's "running as administrator" startup dialog and pressing "I wish to continue at my own risk".
# (This session is the built-in Administrator account: runas /trustlevel did not stop Unity detecting admin rights,
# and Unity has no switch to suppress the dialog.)
# Usage: unity_gui_run.sh LOGFILE EXECUTE_METHOD [VAR=VALUE ...]
#   e.g. unity_gui_run.sh C:/tmp/check.log ReconstructionStagePlayCheck.Run STAGE_PLAY_ONLY=BG08 STAGE_PLAY_BOSS=1
LOG="$1"; METHOD="$2"; shift 2
for kv in "$@"; do export "$kv"; done
HERE="$(cd "$(dirname "$0")" && pwd)"
STOP="$(cygpath -w "${TMPDIR:-/tmp}")\\unity-gui-stop-$$.txt"
powershell.exe -NoProfile -ExecutionPolicy Bypass -File "$(cygpath -w "$HERE/unity_admin_dialog_dismiss.ps1")" -Seconds 3600 -StopFile "$STOP" &
WATCH=$!
timeout 3000 "/c/Program Files/Unity 2023.2.22f1/Editor/Unity.exe" -projectPath "D:/games/TruxtonExRecon/Reconstructed" -executeMethod "$METHOD" -logFile "$LOG" >/dev/null 2>&1
CODE=$?
echo stop > "$(cygpath -u "$STOP")"; wait $WATCH 2>/dev/null; rm -f "$(cygpath -u "$STOP")"
echo "unity exit $CODE"
bash "$HERE/crash_report.sh" "$LOG" "$CODE"
