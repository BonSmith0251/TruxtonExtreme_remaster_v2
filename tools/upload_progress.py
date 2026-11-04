#!/usr/bin/env python
"""Progress monitor for tools/lfs_uploader.sh.  Run: python tools/upload_progress.py [--once] [--interval 10] [--state DIR]
Reads the uploader's state folder (chunks, done, claims), so it works while the uploader runs in any terminal.
Chunks that GitHub already had finish in seconds, so speed/ETA use only the last few minutes of real progress."""
import argparse, os, re, subprocess, sys, time

REPO = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
DEFAULT_STATE = r"C:\Users\Administrator\git-stores\uploader-state"
UNITS = {"B": 1e-6, "KB": 1e-3, "MB": 1.0, "GB": 1e3}

def chunk_sizes(state):
    out = subprocess.run(["git", "lfs", "ls-files", "-l", "-s"], cwd=REPO, capture_output=True, text=True).stdout
    size = {}
    for line in out.splitlines():
        m = re.match(r"(\w+) . .*\(([\d.]+) (B|KB|MB|GB)\)\s*$", line.strip())
        if m:
            size[m.group(1)] = float(m.group(2)) * UNITS[m.group(3)]
    chunks = {}
    for name in sorted(os.listdir(os.path.join(state, "chunks"))):
        ids = [x.strip() for x in open(os.path.join(state, "chunks", name)) if x.strip()]
        chunks[name[:-4]] = sum(size.get(i, 0.0) for i in ids)
    return chunks

def fmt_eta(sec):
    return "--:--:--" if sec is None else "%02d:%02d:%02d" % (sec // 3600, sec % 3600 // 60, sec % 60)

def route_status():
    try:
        r = subprocess.run(["powershell", "-NoProfile", "-Command",
            "if (Get-NetRoute -DestinationPrefix 0.0.0.0/1 -ErrorAction SilentlyContinue | Where-Object InterfaceAlias -eq 'Astrill VPN') {'up'} else {'down'}"],
            capture_output=True, text=True, timeout=20)
        return r.stdout.strip() or "?"
    except Exception:
        return "?"

def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--state", default=DEFAULT_STATE)
    ap.add_argument("--interval", type=int, default=10)
    ap.add_argument("--window", type=int, default=300, help="seconds of history for speed/ETA")
    ap.add_argument("--once", action="store_true")
    a = ap.parse_args()
    if not os.path.isdir(os.path.join(a.state, "chunks")):
        sys.exit("no uploader state at %s - start tools/lfs_uploader.sh first" % a.state)
    chunks = chunk_sizes(a.state)
    total_mb = sum(chunks.values()); total_n = len(chunks)
    print("%d chunks, %.0f MB total" % (total_n, total_mb))
    while True:
        done = {n: os.path.getmtime(os.path.join(a.state, "done", n)) for n in os.listdir(os.path.join(a.state, "done"))}
        busy = sorted(os.listdir(os.path.join(a.state, "claims")))
        done_mb = sum(chunks.get(n, 0.0) for n in done)
        now = time.time()
        recent = [(t, chunks.get(n, 0.0)) for n, t in done.items() if now - t <= a.window]
        speed = None
        # skip-fast chunks (already on GitHub) take ~3 s; only count the window if it spans real uploading
        if len(recent) >= 2:
            span = max(now - min(t for t, _ in recent), a.interval)
            speed = sum(mb for _, mb in recent) / span
        left = total_mb - done_mb
        eta = fmt_eta(int(left / speed)) if speed and speed > 0.05 else None
        pct = 100.0 * done_mb / total_mb if total_mb else 100.0
        bar = ("#" * int(pct / 2.5)).ljust(40, ".")
        print("%s [%s] %5.1f%%  chunks %d/%d  %6.0f/%.0f MB  %5.2f MB/s  ETA %s  busy:%s  astrill:%s" % (
            time.strftime("%H:%M:%S"), bar, pct, len(done), total_n, done_mb, total_mb,
            speed or 0.0, eta or "--:--:--", ",".join(busy) or "-", route_status()), flush=True)
        if a.once or len(done) >= total_n:
            break
        time.sleep(a.interval)

if __name__ == "__main__":
    main()
