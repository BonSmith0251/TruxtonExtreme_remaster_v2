#!/bin/bash
# Runs a batch-mode Unity method on the reconstruction and reports whether Unity crashed.
# Usage: unity_batch_run.sh LOGFILE EXECUTE_METHOD [VAR=VALUE ...]
LOG="$1"; METHOD="$2"; shift 2
for kv in "$@"; do export "$kv"; done
timeout 1800 "/c/Program Files/Unity 2023.2.22f1/Editor/Unity.exe" -batchmode -quit -projectPath "D:/games/TruxtonExRecon/Reconstructed" -executeMethod "$METHOD" -logFile "$LOG" >/dev/null 2>&1
CODE=$?
bash "$(dirname "$0")/crash_report.sh" "$LOG" "$CODE"
grep "error CS" "$LOG" | sort -u | tail -3
exit $CODE
