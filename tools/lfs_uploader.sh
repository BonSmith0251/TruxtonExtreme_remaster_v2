#!/bin/bash
# Resumable GitHub uploader for the repo's Git LFS files and main branch.
# Two workers share one queue of small chunks: "astrill" (direct, needs the Astrill VPN route) and
# "tunnel" (HTTP proxy 127.0.0.1:3128). A failed chunk goes back in the queue; there is no try limit.
# Usage: bash tools/lfs_uploader.sh [state-dir]      Stop with Ctrl+C. Re-running resumes (done chunks are skipped fast).
#   CHUNK_MB=40 CHUNK_FILES=30 PROXY=http://127.0.0.1:3128 ASTRILL_IF="Astrill VPN"
REPO="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
STATE="${1:-/c/Users/Administrator/git-stores/uploader-state}"
CHUNK_MB="${CHUNK_MB:-40}"; CHUNK_FILES="${CHUNK_FILES:-30}"
PROXY="${PROXY:-http://127.0.0.1:3128}"; ASTRILL_IF="${ASTRILL_IF:-Astrill VPN}"
cd "$REPO" || exit 1
mkdir -p "$STATE/chunks" "$STATE/claims" "$STATE/done" "$STATE/out"
log() { echo "$(date +%T) $*"; }

# 1. Build the chunk list once (sorted by path, so a re-run gives the same chunks).
if [ ! -f "$STATE/chunks.ready" ]; then
  git lfs ls-files -l -s | python -I -c '
import re, sys, os
state, mb, nf = sys.argv[1], float(sys.argv[2]), int(sys.argv[3])
items = []
for l in sys.stdin:
    m = re.match(r"(\w+) . .*\(([\d.]+) (B|KB|MB|GB)\)\s*$", l.strip())
    if m: items.append((m.group(1), float(m.group(2)) * {"B":1e-6,"KB":1e-3,"MB":1,"GB":1e3}[m.group(3)]))
chunks, cur, sz = [], [], 0.0
for o, s in items:
    if cur and (sz + s > mb or len(cur) >= nf): chunks.append(cur); cur, sz = [], 0.0
    cur.append(o); sz += s
if cur: chunks.append(cur)
for i, c in enumerate(chunks, 1):
    with open(os.path.join(state, "chunks", "%04d.txt" % i), "w", newline="\n") as f: f.write("\n".join(c) + "\n")
print(len(items), "objects ->", len(chunks), "chunks")
' "$STATE" "$CHUNK_MB" "$CHUNK_FILES" && touch "$STATE/chunks.ready"
fi
TOTAL=$(ls "$STATE/chunks" | wc -l)

astrill_up() { powershell -NoProfile -Command "if (Get-NetRoute -DestinationPrefix 0.0.0.0/1 -ErrorAction SilentlyContinue | Where-Object InterfaceAlias -eq '$ASTRILL_IF') {exit 0} else {exit 1}"; }
tunnel_up() { curl -s -x "$PROXY" -m 15 -o /dev/null https://github.com; }
route_ok() { if [ "$1" = astrill ]; then astrill_up; else tunnel_up; fi; }
run_lfs() {   # $1 = route, $2 = oid file
  local ids; ids=$(tr -d '\r' < "$2" | tr '\n' ' ')
  if [ "$1" = astrill ]; then
    env -u HTTPS_PROXY -u HTTP_PROXY -u https_proxy -u http_proxy git lfs push origin --object-id $ids
  else
    HTTPS_PROXY="$PROXY" HTTP_PROXY="$PROXY" git lfs push origin --object-id $ids
  fi
}

# 2. Worker: claim a chunk (mkdir is atomic), upload it, mark done; on failure release it and try another.
worker() {
  local route="$1" f id fails=0
  while :; do
    local remaining=0 did=0
    for f in "$STATE"/chunks/*.txt; do
      id=$(basename "$f" .txt)
      [ -e "$STATE/done/$id" ] && continue
      remaining=1
      # chunks listed in $STATE/astrill-only (single files too big for the tunnel, which drops uploads after ~65 MB)
      [ "$route" = tunnel ] && grep -qx "$id" "$STATE/astrill-only" 2>/dev/null && continue
      mkdir "$STATE/claims/$id" 2>/dev/null || continue          # another worker has it
      until route_ok "$route"; do log "[$route] route down, waiting..."; sleep 30; done
      if run_lfs "$route" "$f" > "$STATE/out/$route.out" 2>&1; then
        touch "$STATE/done/$id"; fails=0; did=1
        log "[$route] chunk $id/$TOTAL ok  (done: $(ls "$STATE/done" | wc -l)/$TOTAL)"
      else
        fails=$((fails+1))
        log "[$route] chunk $id failed (#$fails in a row): $(grep -ioE 'Service Unavailable|forcibly closed|timeout|EOF|503' "$STATE/out/$route.out" | sort | uniq -c | head -2 | tr '\n' ' ')"
        sleep $(( fails < 6 ? 10 * fails : 60 ))
      fi
      rmdir "$STATE/claims/$id" 2>/dev/null
    done
    [ $remaining = 0 ] && break
    [ $did = 0 ] && sleep 20            # nothing claimable right now (the other worker holds the rest)
  done
  log "[$route] no chunks left"
}

log "uploading $TOTAL chunks from $REPO with workers: astrill + tunnel (no retry limit)"
rm -rf "$STATE/claims"/* 2>/dev/null
git config lfs.concurrenttransfers 2
worker astrill & WA=$!
worker tunnel & WT=$!
trap 'kill $WA $WT 2>/dev/null; exit 130' INT TERM
wait $WA $WT
log "all LFS chunks uploaded"

# 3. Push the branch, alternating routes, until it works.
n=0
while :; do
  for route in astrill tunnel; do
    n=$((n+1)); route_ok "$route" || continue
    if [ "$route" = astrill ]; then
      env -u HTTPS_PROXY -u HTTP_PROXY -u https_proxy -u http_proxy git push -u origin main > "$STATE/out/push.out" 2>&1; rc=$?
    else
      HTTPS_PROXY="$PROXY" HTTP_PROXY="$PROXY" git push -u origin main > "$STATE/out/push.out" 2>&1; rc=$?
    fi
    if [ $rc = 0 ]; then log "PUSH OK via $route"; git ls-remote origin; git rev-parse HEAD; exit 0; fi
    log "push try $n via $route failed: $(tr '\r' '\n' < "$STATE/out/push.out" | grep -vE '^Uploading LFS' | tail -1 | cut -c1-160)"
    sleep 30
  done
done
