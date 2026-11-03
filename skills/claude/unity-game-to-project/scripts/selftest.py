"""End-to-end self-test on the bundled StarDrift sample.

Builds testdata/StarDrift with the given editor (plain and LZ4 players), records the
original's smoke counters, then runs the full pipeline:
  - Mono build, plugin scripts   -> rebuilt player must match the original's behaviour
  - LZ4 build,  plugin scripts   -> same
  - Mono build, stub scripts     -> project must validate, build and run with no errors
Run it after changing any part of the skill.

usage: python selftest.py --unity <Unity.exe> [--lab <dir>]
"""
from __future__ import annotations

import argparse
import json
import re
import shutil
import subprocess
import sys
import tempfile
from pathlib import Path

HERE = Path(__file__).resolve().parent
SKILL = HERE.parent
sys.path.insert(0, str(HERE))
from make_project import find_unity  # noqa: E402
from ugp_common import log  # noqa: E402


def run_player(exe: Path, out: Path, seconds: int = 8) -> dict:
    out.unlink(missing_ok=True)
    subprocess.call([str(exe), "-screen-fullscreen", "0", "-smoketest", str(seconds), "-smokeout", str(out),
                     "-logFile", str(out.with_suffix(".log"))], timeout=120)
    return json.loads(out.read_text(encoding="utf-8")) if out.exists() else {}


def main():
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("--unity")
    ap.add_argument("--lab", type=Path, default=Path(tempfile.gettempdir()) / "ugp_selftest")
    a = ap.parse_args()
    unity = find_unity(None, a.unity)
    lab = a.lab.resolve()
    lab.mkdir(parents=True, exist_ok=True)

    sample = lab / "SampleGame"
    if not (sample / "Assets").exists():
        shutil.copytree(SKILL / "testdata" / "StarDrift", sample)
        (sample / "ProjectSettings").mkdir(exist_ok=True)
        m = re.search(r"(\d+\.\d+\.\d+[abfp]\d+)", str(unity))
        (sample / "ProjectSettings" / "ProjectVersion.txt").write_text(f"m_EditorVersion: {m.group(1) if m else ''}\n")
    builds = lab / "builds"
    log("building sample players ...")
    rc = subprocess.call([str(unity), "-batchmode", "-nographics", "-quit", "-projectPath", str(sample),
                          "-executeMethod", "SampleBuilder.BuildAll", "-outRoot", str(builds),
                          "-logFile", str(lab / "sample_build.log")], timeout=1800)
    if rc != 0:
        sys.exit(f"sample build failed, see {lab / 'sample_build.log'}")

    original = run_player(builds / "StarDrift_Mono" / "StarDrift.exe", lab / "original.json")
    log("original:", original.get("counters"))
    results = []
    for name, build, mode in (("mono-plugin", "StarDrift_Mono", "plugin"),
                              ("lz4-plugin", "StarDrift_MonoLZ4", "plugin"),
                              ("mono-stubs", "StarDrift_Mono", "stubs")):
        work, proj = lab / "work" / name, lab / "projects" / name
        rc = subprocess.call([sys.executable, str(HERE / "run_all.py"), str(builds / build), str(work), str(proj),
                              "--unity", str(unity), "--scripts", mode, "--seconds", "15", "--force", "--publish"])
        ok = rc == 0
        detail = f"run_all exit {rc}"
        if ok and mode == "plugin":
            got = run_player(proj / "Builds" / "StarDrift.exe", lab / f"{name}.json")
            c, oc = got.get("counters", {}), original.get("counters", {})
            checks = {
                "same scene": got.get("scene") == original.get("scene"),
                "no errors": got.get("errors") == 0,
                "bundle loaded": c.get("bundleLoaded") == oc.get("bundleLoaded") == 1,
                "enemies spawned": c.get("spawned", 0) >= max(1, oc.get("spawned", 0) - 2),
                "kills": c.get("kills", 0) > 0,
                "bonus spawned": c.get("bonusSpawned", 0) > 0,
            }
            ok = all(checks.values())
            detail = ", ".join(f"{k}={'ok' if v else 'FAIL'}" for k, v in checks.items()) + f" | {c}"
        results.append((name, ok, detail))
    print()
    for name, ok, detail in results:
        print(f"{'PASS' if ok else 'FAIL'}  {name:12s} {detail}")
    sys.exit(0 if all(ok for _, ok, _ in results) else 1)


if __name__ == "__main__":
    main()
