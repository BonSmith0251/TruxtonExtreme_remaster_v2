"""Stage 5: assemble the Unity project and run the editor-side rebuild.

  - Packages/manifest.json from the game's ScriptingAssemblies.json (modules + known
    packages, versions taken from the chosen editor's own package manifest)
  - copies exported assets, RebuildData, StreamingAssets (verbatim), recovered scripts
    and the GameRebuild editor tooling into the project
  - runs Unity in batch mode: GameRebuild.Rebuilder.RunBatch

usage: python make_project.py <work_dir> <project_dir> [--unity Unity.exe] [--no-run]
"""
from __future__ import annotations

import argparse
import json
import re
import shutil
import subprocess
import sys
from pathlib import Path

sys.path.insert(0, str(Path(__file__).parent))
from ugp_common import log, make_typetree_generator, read_json, write_json  # noqa: E402

SKILL_DIR = Path(__file__).resolve().parent.parent
ASSEMBLY_PACKAGES = {
    "UnityEngine.UI": "com.unity.ugui",
    "Unity.TextMeshPro": "com.unity.textmeshpro",
    "Unity.InputSystem": "com.unity.inputsystem",
    "Unity.Timeline": "com.unity.timeline",
    "Cinemachine": "com.unity.cinemachine",
    "Unity.Cinemachine": "com.unity.cinemachine",
    "Unity.RenderPipelines.Universal.Runtime": "com.unity.render-pipelines.universal",
    "Unity.RenderPipelines.HighDefinition.Runtime": "com.unity.render-pipelines.high-definition",
    "Unity.Postprocessing.Runtime": "com.unity.postprocessing",
    "Unity.Addressables": "com.unity.addressables",
    "Unity.Burst": "com.unity.burst",
    "Unity.Mathematics": "com.unity.mathematics",
    "Unity.Collections": "com.unity.collections",
    "Unity.2D.Animation.Runtime": "com.unity.2d.animation",
    "Unity.2D.SpriteShape.Runtime": "com.unity.2d.spriteshape",
    "Unity.2D.Tilemap.Extras": "com.unity.2d.tilemap.extras",
    "Unity.2D.PixelPerfect": "com.unity.2d.pixel-perfect",
    "Unity.Localization": "com.unity.localization",
    "Unity.Splines": "com.unity.splines",
    "Unity.VisualEffectGraph.Runtime": "com.unity.visualeffectgraph",
    "Unity.AI.Navigation": "com.unity.ai.navigation",
    "Newtonsoft.Json": "com.unity.nuget.newtonsoft-json",
}


def find_unity(wanted: str | None, explicit: str | None) -> Path:
    if explicit:
        return Path(explicit)
    cands = []
    for pattern in ("C:/Program Files/Unity/Hub/Editor/*/Editor/Unity.exe", "C:/Program Files/Unity*/Editor/Unity.exe",
                    "D:/Program Files/Unity/Hub/Editor/*/Editor/Unity.exe", "/Applications/Unity/Hub/Editor/*/Unity.app/Contents/MacOS/Unity"):
        root = Path(pattern.split("*")[0]).parent if "*" in pattern else Path(pattern)
        rest = pattern[len(str(root)) + 1:] if "*" in pattern else ""
        if root.exists():
            cands += list(root.glob(rest))
    if not cands:
        sys.exit("No Unity editor found; pass --unity <path to Unity.exe>")

    def ver(p: Path) -> str:
        m = re.search(r"(\d{4}\.\d+\.\d+[abfp]\d+|\d\.\d+\.\d+[abfp]\d+|\d{4}\.\d+\.\d+)", str(p))
        return m.group(1) if m else "0"

    def key(p):
        v = ver(p)
        exact = v == wanted
        same_minor = wanted and v.split(".")[:2] == wanted.split(".")[:2]
        return (exact, bool(same_minor), [int(x) for x in re.findall(r"\d+", v)[:3]])

    best = max(cands, key=key)
    if ver(best) != wanted:
        log(f"WARNING: game was built with Unity {wanted}, using editor {ver(best)} ({best})")
    return best


def build_manifest(survey: dict, editor: Path) -> dict:
    data_dir = Path(survey["data_dir"])
    names = []
    sa = data_dir / "ScriptingAssemblies.json"
    if sa.exists():
        names = [n[:-4] for n in read_json(sa).get("names", [])]
    elif survey.get("scripting", {}).get("all_assemblies"):
        names = [n[:-4] for n in survey["scripting"]["all_assemblies"]]
    else:
        # IL2CPP players without ScriptingAssemblies.json (e.g. Android): read the metadata
        gen = make_typetree_generator(Path(survey["game_dir"]), survey.get("unity_version") or "2020.3.0f1")
        if gen:
            names = [n[:-4] if n.endswith(".dll") else n for n in gen.get_loaded_dll_names()]
    pm = editor.parent / "Data" / "Resources" / "PackageManager"
    builtin = {p.name for p in (pm / "BuiltInPackages").glob("com.unity.modules.*")}
    editor_manifest = {}
    em = pm / "Editor" / "manifest.json"
    if em.exists():
        editor_manifest = json.loads(em.read_text(encoding="utf-8")).get("packages", {})
    deps, missing = {}, []
    for n in names:
        m = re.match(r"UnityEngine\.(\w+)Module$", n)
        if m:
            mod = "com.unity.modules." + m.group(1).lower()
            if mod in builtin:
                deps[mod] = "1.0.0"
            continue
        pkg = ASSEMBLY_PACKAGES.get(n)
        if not pkg:
            continue
        if pkg == "com.unity.textmeshpro" and "com.unity.ugui" in editor_manifest and editor_manifest["com.unity.ugui"].get("version", "1").startswith("2"):
            pkg = "com.unity.ugui"  # TMP ships inside uGUI 2.x (Unity 2023.2+)
        info = editor_manifest.get(pkg, {})
        v = info.get("version") or info.get("minimumVersion")
        if v:
            deps[pkg] = v
        else:
            missing.append(pkg)
    for core in ("com.unity.modules.imgui", "com.unity.modules.jsonserialize", "com.unity.modules.assetbundle"):
        if core in builtin:
            deps.setdefault(core, "1.0.0")
    return {"dependencies": dict(sorted(deps.items()))}, missing


def finalize_repack(work: Path, proj: Path, survey: dict) -> dict:
    """Re-obfuscate bundles rebuilt by the editor and replace the originals in StreamingAssets."""
    from decrypt import encode

    manifest = proj / "RebuildData" / "repack" / "repack.json"
    result = {"replaced": [], "kept_original": []}
    if not manifest.exists():
        return result
    bundles = {b["source"]: b for b in read_json(proj / "RebuildData" / "rebuild.json").get("bundles", [])}
    sa_orig = Path(survey["data_dir"]) / "StreamingAssets"
    for e in read_json(manifest):
        b = bundles.get(e["source"], {})
        raw = (proj / e["file"]).read_bytes()
        original = (sa_orig / e["source"]).read_bytes()
        enc = encode(raw, b.get("transform"), original, sa_orig / e["source"]) if b.get("decrypted") else raw
        if enc is None:
            result["kept_original"].append(f"{e['source']} (no encoder for {b.get('transform')})")
            continue
        (proj / "Assets" / "StreamingAssets" / e["source"]).write_bytes(enc)
        result["replaced"].append(e["source"])
    write_json(proj / "RebuildData" / "repack_report.json", result)
    log(f"repacked bundles: {len(result['replaced'])} replaced, {len(result['kept_original'])} kept original")
    return result


def copy_tree(src: Path, dst: Path):
    if src.exists():
        shutil.copytree(src, dst, dirs_exist_ok=True)


def main():
    ap = argparse.ArgumentParser(description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("work_dir", type=Path)
    ap.add_argument("project_dir", type=Path)
    ap.add_argument("--unity")
    ap.add_argument("--no-run", action="store_true", help="only lay out files; don't launch Unity")
    ap.add_argument("--timeout", type=int, default=3600)
    ap.add_argument("--force", action="store_true", help="wipe Assets/Packages/ProjectSettings of an existing project first")
    a = ap.parse_args()

    work, proj = a.work_dir.resolve(), a.project_dir.resolve()
    survey = read_json(work / "survey.json")
    editor = find_unity(survey.get("unity_version"), a.unity)
    if (proj / "Assets").exists() and any((proj / "Assets").iterdir()):
        if not a.force:
            sys.exit(f"{proj} already has Assets/; choose an empty folder or pass --force (rebuilds are not incremental)")
        # keep Library/ (import cache) so a re-run doesn't re-import everything from scratch
        for sub in ("Assets", "RebuildData", "ProjectSettings", "Packages"):
            shutil.rmtree(proj / sub, ignore_errors=True)
    (proj / "Assets").mkdir(parents=True, exist_ok=True)
    (proj / "Packages").mkdir(exist_ok=True)

    # Without ProjectSettings/ Unity treats the folder as a new project and replaces
    # Packages/manifest.json with its template, so pin the editor version first.
    (proj / "ProjectSettings").mkdir(exist_ok=True)
    m = re.search(r"(\d+\.\d+\.\d+[abfp]\d+)", str(editor))
    (proj / "ProjectSettings" / "ProjectVersion.txt").write_text(f"m_EditorVersion: {m.group(1) if m else ''}\n", encoding="utf-8")

    manifest, missing = build_manifest(survey, editor)
    write_json(proj / "Packages" / "manifest.json", manifest)
    log("packages:", ", ".join(manifest["dependencies"]))
    if missing:
        log("packages without a known version for this editor (add manually):", ", ".join(missing))

    copy_tree(work / "extract" / "project", proj)
    sa = Path(survey["data_dir"]) / "StreamingAssets"
    copy_tree(sa, proj / "Assets" / "StreamingAssets")
    copy_tree(work / "scripts" / "plugins", proj / "Assets" / "Plugins" / "Recovered")
    copy_tree(work / "scripts" / "stubs", proj / "Assets" / "Scripts" / "Recovered")
    copy_tree(SKILL_DIR / "unity" / "GameRebuild", proj / "Assets" / "GameRebuild")
    (proj / ".gitignore").write_text("Library/\nTemp/\nLogs/\nobj/\nBuilds/\nUserSettings/\n*.csproj\n*.sln\n", encoding="utf-8")

    if a.no_run:
        log("project laid out; open it in Unity and run Tools/Game Rebuild/Rebuild From RebuildData")
        return
    logf = proj / "RebuildData" / "rebuild.log"
    cmd = [str(editor), "-batchmode", "-nographics", "-ignoreCompilerErrors", "-projectPath", str(proj),
           "-executeMethod", "GameRebuild.Rebuilder.RunBatch", "-logFile", str(logf)]
    log("running Unity rebuild (first import can take a while) ...")
    rc = subprocess.call(cmd, timeout=a.timeout)
    text = logf.read_text(encoding="utf-8", errors="replace") if logf.exists() else ""
    compile_errors = sorted(set(re.findall(r"^.*error CS\d+.*$", text, re.M)))
    rep_path = proj / "RebuildData" / "rebuild_report.json"
    log(f"Unity exit code {rc}; compile errors: {len(compile_errors)}")
    for e in compile_errors[:20]:
        log("  ", e)
    if rep_path.exists():
        rep = json.loads(rep_path.read_text(encoding="utf-8"))
        log("missing scripts:", len(rep["missingScripts"]), "| unresolved refs:", len(rep["unresolvedReferences"]),
            "| unknown types:", rep["unknownComponentTypes"], "| console errors:", rep["consoleErrors"])
    else:
        log("no rebuild_report.json - see", logf)
    if rc == 0:
        finalize_repack(work, proj, survey)
    sys.exit(rc)


if __name__ == "__main__":
    main()
