#!/bin/bash
# Prints "CRASH" with the top of the native stack when a Unity log has one (shared by the run wrappers).
# Usage: crash_report.sh LOGFILE EXITCODE
LOG="$1"; CODE="$2"
if grep -q "Crash!!!" "$LOG" 2>/dev/null || [ "$CODE" = "139" ]; then
  echo "CRASH in $(basename "$LOG") (exit $CODE):"
  sed -n '/OUTPUTTING STACK TRACE/,/END OF STACKTRACE/p' "$LOG" | grep "(Unity)\|Mono JIT" | sed 's/^0x[0-9A-F]* //' | head -12
else
  echo "no crash ($(basename "$LOG"), exit $CODE)"
fi
