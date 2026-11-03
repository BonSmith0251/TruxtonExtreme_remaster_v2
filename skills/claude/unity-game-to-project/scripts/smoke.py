"""Stage 6: smoke-test a rebuilt project.

  1. validate  - Unity batch: open every build scene and prefab, count missing scripts and
                 broken references, check script compilation (RebuildData/smoke_validate.json)
  2. build     - Unity batch: build a player into <project>/Builds/
  3. run       - launch the rebuilt player (and optionally the original game) for N seconds
                 with the same arguments, collect Player.log, and diff errors/exceptions

usage: python smoke.py <work_dir> <project_dir> [--unity Unity.exe] [--seconds 20]
                       [--compare-original] [--player-args "..."] [--skip-build]
Exit code 0 = no blocking problems. Report: <project>/RebuildData/smoke_report.{json,md}
"""
from __future__ import annotations

import argparse
import json
import re
import shlex
import subprocess
import sys
import time
from pathlib import Path

sys.path.insert(0, str(Path(__file__).parent))
from make_project import find_unity  # noqa: E402
from ugp_common import log, read_json, safe_name, write_json  # noqa: E402

ERROR_RE = re.compile(r"^(?:.*Exception: .*|.*Error: .*|NullReferenceException.*|MissingReferenceException.*|"
                      r"The referenced script .* is missing.*|.*could not be loaded.*|.*Missing script.*)$", re.M)
NOISE_RE = re.compile(r"(Curl error|Licensing|d3d12|Shader warning|PlayerConnection|Input System module state|"
                      r"Unable to find player assembly|Fallback handler could not load library)", re.I)


def unity_batch(editor: Path, proj: Path, method: str, logf: Path, extra=(), timeout=3600) -> int:
    cmd = [str(editor), "-batchmode", "-nographics", "-projectPath", str(proj), "-executeMethod", method,
           "-logFile", str(logf), *extra]
    return subprocess.call(cmd, timeout=timeout)


def run_player(exe: Path, seconds: int, args: list[str], logf: Path) -> dict:
    cmd = [str(exe), "-screen-fullscreen", "0", "-logFile", str(logf), *args]
    t0 = time.time()
    p = subprocess.Popen(cmd)
    try:
        rc = p.wait(timeout=seconds)
        exited = True
    except subprocess.TimeoutExpired:
        p.kill()
        p.wait()
        rc, exited = None, False
    text = logf.read_text(encoding="utf-8", errors="replace") if logf.exists() else ""
    errors = [l for l in ERROR_RE.findall(text) if not NOISE_RE.search(l)]
    return {
        "exe": str(exe), "seconds": round(time.time() - t0, 1), "exitCode": rc, "exitedByItself": exited,
        "crashed": "Crash!!!" in text or (exited and rc not in (0, None)),
        "errors": len(errors), "errorLines": sorted(set(errors))[:40], "log": str(logf),
        "scenesLoaded": sorted(set(re.findall(r"(?:Loading|UnloadTime).*?([\w/]+\.unity)", text))),
    }


def main():
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("work_dir", type=Path)
    ap.add_argument("project_dir", type=Path)
    ap.add_argument("--unity")
    ap.add_argument("--seconds", type=int, default=20, help="how long to run each player")
    ap.add_argument("--player-args", default="", help="extra args for both players (e.g. a game's own test flags)")
    ap.add_argument("--compare-original", action="store_true", help="also run the original game and diff errors")
    ap.add_argument("--skip-build", action="store_true")
    a = ap.parse_args()

    work, proj = a.work_dir.resolve(), a.project_dir.resolve()
    survey = read_json(work / "survey.json")
    editor = find_unity(survey.get("unity_version"), a.unity)
    rd = proj / "RebuildData"
    report: dict = {"project": str(proj)}

    log("validate ...")
    rc = unity_batch(editor, proj, "GameRebuild.Smoke.Validate", rd / "smoke_validate.log")
    v = read_json(rd / "smoke_validate.json") if (rd / "smoke_validate.json").exists() else {"problems": -1}
    report["validate"] = {"exitCode": rc, **v}
    log(f"validate: {v.get('problems')} problem(s), compileFailed={v.get('compileFailed')}")

    product = safe_name(survey.get("product") or survey.get("product_name") or "Game")
    exe = proj / "Builds" / f"{product}.exe"
    if not a.skip_build:
        log("build player ...")
        rc = unity_batch(editor, proj, "GameRebuild.Smoke.BuildPlayer", rd / "smoke_build.log", ["-buildPath", str(exe)])
        report["build"] = {"exitCode": rc, "exe": str(exe), "exists": exe.exists()}
        log(f"build exit {rc}, exe exists: {exe.exists()}")

    pargs = shlex.split(a.player_args, posix=False)
    if exe.exists():
        log(f"run rebuilt player for {a.seconds}s ...")
        report["rebuilt"] = run_player(exe, a.seconds, pargs, rd / "smoke_player_rebuilt.log")
        log(f"rebuilt: errors={report['rebuilt']['errors']} crashed={report['rebuilt']['crashed']}")
    if a.compare_original:
        game_dir = Path(survey["game_dir"])
        orig = next((p for p in game_dir.glob("*.exe") if p.stem == Path(survey["data_dir"]).name[:-5]), None)
        if orig:
            log(f"run original game for {a.seconds}s ...")
            report["original"] = run_player(orig, a.seconds, pargs, rd / "smoke_player_original.log")
            new = sorted(set(report.get("rebuilt", {}).get("errorLines", [])) - set(report["original"]["errorLines"]))
            report["newErrorsVsOriginal"] = new
            log(f"original: errors={report['original']['errors']}; errors only in rebuilt: {len(new)}")

    blocking = []
    if v.get("compileFailed"):
        blocking.append("script compilation failed")
    if v.get("problems", 0) != 0:
        blocking.append(f"{v.get('problems')} validation problem(s) (missing scripts / broken refs)")
    if not a.skip_build and not exe.exists():
        blocking.append("player build failed")
    r = report.get("rebuilt")
    if r and r["crashed"]:
        blocking.append("rebuilt player crashed")
    if a.compare_original and report.get("newErrorsVsOriginal"):
        blocking.append(f"{len(report['newErrorsVsOriginal'])} error line(s) not present in the original")
    elif r and not a.compare_original and r["errors"]:
        blocking.append(f"rebuilt player logged {r['errors']} error line(s)")
    report["blocking"] = blocking
    write_json(rd / "smoke_report.json", report)
    md = ["# Smoke report", "", f"- Validation problems: {v.get('problems')}", f"- Compile failed: {v.get('compileFailed')}"]
    for sc in v.get("scenes", []):
        md.append(f"  - `{sc['path']}`: {sc['gameObjects']} objects, {sc['components']} components, "
                  f"{sc['missingScripts']} missing scripts, {sc['brokenRefs']} broken refs, {sc['liveRefs']} live refs")
    if "build" in report:
        md.append(f"- Player build: {'ok' if report['build']['exists'] else 'FAILED'} (`{exe}`)")
    for k in ("rebuilt", "original"):
        if k in report:
            x = report[k]
            md.append(f"- {k} run: {x['seconds']}s, exit={x['exitCode']}, crashed={x['crashed']}, error lines={x['errors']}")
    md.append("")
    md.append("**Blocking:** " + ("; ".join(blocking) if blocking else "none"))
    (rd / "smoke_report.md").write_text("\n".join(md) + "\n", encoding="utf-8")
    log("blocking:", "; ".join(blocking) if blocking else "none")
    sys.exit(1 if blocking else 0)


if __name__ == "__main__":
    main()
