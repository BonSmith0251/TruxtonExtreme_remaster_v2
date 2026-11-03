"""Self-tests for the manager scripts. Run: python -m unittest test_scripts -v (from scripts/)."""
import copy
import json
import os
import subprocess
import sys
import tempfile
import unittest
from pathlib import Path

HERE = Path(__file__).resolve().parent
sys.path.insert(0, str(HERE))

import compare_tracks  # noqa: E402


def track(side, shift=0.0, spawn_delay=0.0, fire_delay=0.0, frame="source-xz", drop_last=False):
    instances = []
    for n, cue in enumerate((60.0, 61.0)):
        spawn = cue + 0.017 + spawn_delay
        samples = [{"t": spawn + i / 30, "x": -70 + 3 * i + shift, "z": 80 - i, "yaw": 180.0} for i in range(90)]
        instances.append({"key": f"cue{cue}#0", "cue": cue, "spawn": spawn, "despawn": samples[-1]["t"],
                          "despawnReason": "exit", "samples": samples,
                          "events": [{"t": spawn + 1.0 + fire_delay, "type": "fire", "muzzle": "muzzle01"}]})
    if drop_last:
        instances.pop()
    return {"schema": "truxton-track/1", "side": side, "frame": frame, "timeBase": "stage-seconds",
            "subject": {"id": "BG03/Md01/index1"}, "instances": instances}


def run_compare(a, b):
    tol = dict(compare_tracks.DEFAULT_TOLERANCES)
    for t in (a, b):
        for i in t["instances"]:
            i["samples"].sort(key=lambda s: s["t"])
    return compare_tracks.compare(copy.deepcopy(a), copy.deepcopy(b), tol, "spawn")


class CompareTests(unittest.TestCase):
    def test_identical_tracks_pass(self):
        self.assertEqual(run_compare(track("original"), track("remaster"))["verdict"], "pass")

    def test_path_offset_fails(self):
        report = run_compare(track("original"), track("remaster", shift=5.0))
        self.assertEqual(report["verdict"], "fail")
        self.assertTrue(any("path" in r for r in report["reasons"]))

    def test_late_spawn_and_fire_fail(self):
        report = run_compare(track("original"), track("remaster", spawn_delay=0.2, fire_delay=0.3))
        self.assertEqual(report["verdict"], "fail")
        self.assertTrue(any("spawn off" in r for r in report["reasons"]))
        self.assertTrue(any("fire" in r for r in report["reasons"]))

    def test_missing_instance_fails(self):
        report = run_compare(track("original"), track("remaster", drop_last=True))
        self.assertEqual(report["summary"]["missing"], 1)
        self.assertEqual(report["verdict"], "fail")

    def test_frame_mismatch_is_inconclusive(self):
        self.assertEqual(run_compare(track("original"), track("remaster", frame="unity-xy"))["verdict"], "inconclusive")

    def test_early_kill_compares_common_lifetime_only(self):
        b = track("remaster")
        for i in b["instances"]:
            i["samples"] = i["samples"][:40]
            i["despawn"] = i["samples"][-1]["t"]
            i["despawnReason"] = "killed"
            i["events"] = [e for e in i["events"] if e["t"] <= i["despawn"]] + [{"t": i["despawn"], "type": "killed"}]
        report = run_compare(track("original"), b)
        self.assertEqual(report["verdict"], "pass", report["reasons"])

    def test_unkeyed_instances_match_by_spawn(self):
        b = track("remaster")
        for i in b["instances"]:
            i["key"] = None
        report = run_compare(track("original"), b)
        self.assertEqual(report["verdict"], "pass")
        self.assertTrue(all(i["matchedBy"] == "spawn" for i in report["instances"]))

    def test_same_frame_spawns_match_by_position(self):
        # A formation: two instances born on one frame at different places, listed in opposite orders.
        def formation(side, order):
            t = track(side)
            first = copy.deepcopy(t["instances"][0])
            second = copy.deepcopy(first)
            for s in second["samples"]:
                s["x"] += 60
            for i in (first, second):
                i["key"] = None
                i["spawn"] = first["spawn"]
            t["instances"] = [first, second] if order else [second, first]
            return t
        report = run_compare(formation("original", True), formation("remaster", False))
        self.assertEqual(report["verdict"], "pass")


class ToolTests(unittest.TestCase):
    """Run ledger.py and skills.py against a throwaway workspace and skill directories."""

    def setUp(self):
        self.temp = tempfile.TemporaryDirectory()
        base = Path(self.temp.name)
        self.root = base / "game"
        (self.root / "extractor" / "manager").mkdir(parents=True)
        self.env = dict(os.environ, TRUXTON_ROOT=str(self.root), CODEX_HOME=str(base / "codex"),
                        CLAUDE_CONFIG_DIR=str(base / "claude"))

    def tearDown(self):
        self.temp.cleanup()

    def run_tool(self, *args, ok=True):
        result = subprocess.run([sys.executable, str(HERE / args[0]), *args[1:]], env=self.env,
                                capture_output=True, text=True)
        if ok:
            self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
        else:
            self.assertNotEqual(result.returncode, 0, result.stdout)
        return result.stdout + result.stderr

    def test_ledger_requires_passing_comparison(self):
        self.run_tool("ledger.py", "add", "BG03/Md01/index1")
        self.run_tool("ledger.py", "set", "BG03/Md01/index1", "verified", "--role", "manager", ok=False)
        folder = self.root / "extractor" / "manager" / "handoffs"
        folder.mkdir()
        (folder / "c.json").write_text(json.dumps({"verdict": "fail"}))
        self.run_tool("ledger.py", "set", "BG03/Md01/index1", "verified", "--role", "manager",
                      "--artifact", "comparison=handoffs/c.json", ok=False)
        (folder / "c.json").write_text(json.dumps({"verdict": "pass"}))
        self.run_tool("ledger.py", "set", "BG03/Md01/index1", "verified", "--role", "checker",
                      "--artifact", "comparison=handoffs/c.json", ok=False)
        self.run_tool("ledger.py", "set", "BG03/Md01/index1", "verified", "--role", "manager",
                      "--artifact", "comparison=handoffs/c.json")
        self.assertIn("verified=1", self.run_tool("ledger.py", "status"))

    def test_install_backs_up_and_refuses_drift(self):
        skill = self.root / "extractor" / "manager" / "skills" / "truxton-demo"
        skill.mkdir(parents=True)
        (skill / "SKILL.md").write_text('---\nname: truxton-demo\ndescription: "Demo skill used by the manager self-test to check installs."\n---\nv1\n')
        self.run_tool("skills.py", "install", "truxton-demo", "--target", "codex")
        installed = Path(self.env["CODEX_HOME"]) / "skills" / "truxton-demo" / "SKILL.md"
        self.assertIn("v1", installed.read_text())

        (skill / "SKILL.md").write_text((skill / "SKILL.md").read_text().replace("v1", "v2"))
        self.run_tool("skills.py", "install", "truxton-demo", "--target", "codex")
        self.assertIn("v2", installed.read_text())
        backups = list((self.root / "extractor" / "Backups").glob("before-skill-truxton-demo-*/codex/truxton-demo/SKILL.md"))
        self.assertEqual(len(backups), 1)

        installed.write_text(installed.read_text() + "hand edit\n")
        (skill / "SKILL.md").write_text((skill / "SKILL.md").read_text().replace("v2", "v3"))
        self.assertIn("changed outside the manager", self.run_tool("skills.py", "install", "truxton-demo", "--target", "codex", ok=False))
        self.assertIn("DRIFT", self.run_tool("skills.py", "roster"))

    def test_roster_reports_missing_role_skills(self):
        output = self.run_tool("skills.py", "roster")
        self.assertIn("pioneer: truxton-original-pioneer", output)


if __name__ == "__main__":
    unittest.main()
