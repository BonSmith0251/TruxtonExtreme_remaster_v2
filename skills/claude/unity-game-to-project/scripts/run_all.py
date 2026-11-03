"""Run the whole pipeline: survey -> decrypt -> extract -> scripts -> project -> smoke [-> publish].

usage: python run_all.py <game_dir> <work_dir> <project_dir>
         [--unity Unity.exe] [--scripts auto|plugin|stubs] [--plugin my_decrypt.py]
         [--player-args "..."] [--seconds 20] [--compare-original] [--publish] [--force]
Stops at the first stage that fails; every stage can also be run on its own.
"""
from __future__ import annotations

import argparse
import shutil
import subprocess
import sys
import zipfile
from pathlib import Path

HERE = Path(__file__).resolve().parent
sys.path.insert(0, str(HERE))
from ugp_common import log, read_json, safe_name  # noqa: E402


def stage(name: str, *args) -> int:
    log(f"===== {name} =====")
    rc = subprocess.call([sys.executable, str(HERE / f"{name}.py"), *map(str, args)])
    if rc != 0:
        log(f"stage {name} failed with exit code {rc}")
    return rc


def publish(work: Path, proj: Path) -> Path:
    """Zip the smoke-tested player build plus a manifest into <project>/Dist/."""
    survey = read_json(work / "survey.json")
    product = safe_name(survey.get("product") or survey.get("product_name") or "Game")
    build = proj / "Builds"
    dist = proj / "Dist"
    dist.mkdir(exist_ok=True)
    out = dist / f"{product}-rebuilt-win64.zip"
    with zipfile.ZipFile(out, "w", zipfile.ZIP_DEFLATED) as z:
        for p in build.rglob("*"):
            if p.is_file() and "_BurstDebugInformation_DoNotShip" not in str(p) and "_BackUpThisFolder" not in str(p):
                z.write(p, Path(product) / p.relative_to(build))
        for extra in ("smoke_report.md", "rebuild_report.json"):
            f = proj / "RebuildData" / extra
            if f.exists():
                z.write(f, Path(product) / "RebuildInfo" / extra)
    log(f"published {out} ({out.stat().st_size / 1e6:.1f} MB)")
    return out


def main():
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("game_dir", type=Path)
    ap.add_argument("work_dir", type=Path)
    ap.add_argument("project_dir", type=Path)
    ap.add_argument("--unity")
    ap.add_argument("--scripts", default="auto", choices=["auto", "plugin", "stubs"])
    ap.add_argument("--plugin", action="append", default=[], help="custom decrypt plugin(s)")
    ap.add_argument("--player-args", default="")
    ap.add_argument("--seconds", type=int, default=20)
    ap.add_argument("--compare-original", action="store_true")
    ap.add_argument("--publish", action="store_true", help="zip the tested build into <project>/Dist")
    ap.add_argument("--force", action="store_true", help="reuse an existing project folder")
    a = ap.parse_args()

    unity = ["--unity", a.unity] if a.unity else []
    if stage("survey", a.game_dir, a.work_dir):
        sys.exit(1)
    if read_json(a.work_dir / "survey.json")["engine"] != "Unity":
        sys.exit("not a Unity game - see survey.md; only the file inventory is available")
    plugins = [x for p in a.plugin for x in ("--plugin", p)]
    if stage("decrypt", a.work_dir, *plugins):
        sys.exit(1)
    shutil.rmtree(a.work_dir / "extract", ignore_errors=True)
    if stage("extract", a.work_dir):
        sys.exit(1)
    if stage("scripts_recover", a.work_dir, "--mode", a.scripts):
        sys.exit(1)
    if stage("make_project", a.work_dir, a.project_dir, *unity, *(["--force"] if a.force else [])):
        sys.exit(1)
    smoke = ["--seconds", a.seconds, *unity]
    if a.player_args:
        smoke += ["--player-args", a.player_args]
    if a.compare_original:
        smoke.append("--compare-original")
    smoke_rc = stage("smoke", a.work_dir, a.project_dir, *smoke)
    if a.publish:
        if smoke_rc:
            sys.exit("smoke test has blocking problems - fix them before publishing (see RebuildData/smoke_report.md)")
        publish(a.work_dir.resolve(), a.project_dir.resolve())
    sys.exit(smoke_rc)


if __name__ == "__main__":
    main()
