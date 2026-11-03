---
name: unity-game-to-project
description: Turn a built Unity game (Windows player folder with *_Data, Mono or IL2CPP) back into an editable Unity project - survey the files, decrypt obfuscated bundles, parse and export every asset (textures, sprites, audio, meshes, materials, text, fonts, video, ScriptableObjects, prefabs, scenes, settings), recover scripts, rebuild scenes/prefabs in the editor, repack runtime bundles, smoke-test a player build and package it. Use when the user asks to convert/port/rebuild/recover/decompile a Unity game or build into a Unity project, extract or rip its assets, write parsers/decoders/decryptors/exporters for a Unity game's files, or recover a lost project from its build. Only for builds the user owns or has permission to work with.
---

# Unity game -> Unity project

Pipeline of independent stages (each a script in `scripts/`, each writes a report you
must read before moving on). `scripts/run_all.py` chains them; run stages one at a time
when something needs fixing.

```
survey -> decrypt -> extract -> scripts_recover -> make_project -> smoke -> (publish)
```

## 0. Scope and rights check (do this first)

- Ask what the user is allowed to do with the build if it is not obviously theirs
  (their own game, a lost project, a client's game, modding with permission). Signs of a
  cracked copy (repack installers such as `fitgirl*.md5`, emulator configs that unlock
  DLC) mean: stop and raise it with the user before extracting anything.
- "Publishing" here means producing a tested release build of the rebuilt project. Never
  upload or redistribute third-party game content. If the user wants to share the
  result, remind them that it contains the original game's assets and code.
- Never modify the game's install folder. All output goes to a work dir and a project dir.

## 1. Setup (once per machine)

```bash
python -m venv <lab>/.venv
<lab>/.venv/Scripts/python -m pip install -r <skill>/scripts/requirements.txt
```
Needs a Unity editor (Hub installs under `C:/Program Files/Unity/Hub/Editor/<ver>` or
`C:/Program Files/Unity <ver>` are auto-detected; otherwise pass `--unity`). Prefer the
game's exact version (from the survey); the same `major.minor` is usually fine. Batch mode
needs an activated license. Run every script with the venv's python.

## 2. Stages

| stage | command | output to check |
|---|---|---|
| survey | `survey.py <game> <work>` | `survey.md`: engine, Unity version, Mono/IL2CPP, file kinds, files needing decryption |
| decrypt | `decrypt.py <work> [--plugin p.py]` | `decrypt_report.json`: method + recorded transform per file |
| extract | `extract.py <work>` | `extract/extract_report.json`, staged project in `extract/project/`, extras in `extract/reference/` |
| scripts | `scripts_recover.py <work> [--mode plugin\|stubs]` | `scripts_report.json` |
| project | `make_project.py <work> <project> [--force]` | `RebuildData/rebuild_report.json`, `rebuild.log`, `repack_report.json` |
| smoke | `smoke.py <work> <project> [--compare-original] [--player-args ".."]` | `RebuildData/smoke_report.md` (exit 0 = no blocking problems) |
| publish | `run_all.py ... --publish` | `<project>/Dist/<Product>-rebuilt-win64.zip` |

One-shot: `run_all.py <game> <work> <project> --compare-original --publish`.

What each stage does and why is in the script docstrings. Key design points:

- **Object keys** are `<serialized file name lower>:<pathID>`; every PPtr in dumped data is
  rewritten to `{"$ref": key}`. `rebuild.json` is the whole graph (assets, gameObjects,
  components, prefabs, scenes, settings, scripts, bundles).
- **Editor-side rebuild** (`unity/GameRebuild/Editor/Rebuilder.cs`, copied into the project):
  Unity creates every asset itself; dumped type-tree fields are written through
  `SerializedObject` by property name, which covers built-in components, script fields,
  materials and ProjectSettings generically. Order: settings -> texture importers / sprites
  -> meshes -> materials -> asset shells -> prefab structure -> asset data -> prefab data
  (two passes so prefabs and ScriptableObjects can reference each other) -> scenes -> bundles.
- **Scripts**: Mono builds reuse the original compiled assemblies as plugins, renamed from
  `Assembly-CSharp` to `Original-CSharp` (Unity won't attach scripts from a precompiled DLL
  with a reserved name). IL2CPP builds get generated stubs with the exact serialized fields:
  data and references survive, method bodies do not. See `reference/scripts.md`.
- **Runtime bundles** (StreamingAssets) are rebuilt from the recovered assets under the same
  bundle and asset names, then re-obfuscated with the transform `decrypt.py` recorded, so
  the game's own loader keeps working with the renamed or stubbed scripts.

## 3. Fix loop

After `make_project` and `smoke`, read the reports and fix in this order. Re-run only the
affected stage (`make_project.py --force` keeps `Library/`, so it's fast).

1. `compile errors` in `rebuild.log` -> stub generation or missing package (see
   `reference/troubleshooting.md`).
2. `missingScripts` -> script type not found: wrong assembly, class not recovered,
   reserved-name assembly.
3. `unresolvedReferences` -> an asset type the extractor doesn't export yet; look the key up
   in `extract/reference/dumps/<file>.jsonl` and add an exporter in `extract.py`.
4. `unsupportedProperties` / `consoleErrorMessages` -> fix the value conversion in
   `PropertyApplier.cs`.
5. Smoke `newErrorsVsOriginal` -> runtime differences; read `smoke_player_rebuilt.log`.
6. Decrypt `FAIL` -> follow `reference/decryption.md` and write a `--plugin` with both
   `decrypt()` and `encrypt()`.

When you fix the skill itself (not just this game), run the self-test (section 5).

## 4. Known limits (tell the user up front)

- IL2CPP: game logic must be re-implemented. Stubs give the data model plus all wiring.
- Shaders: only names survive; built-in and package shaders re-bind via `Shader.Find`,
  while custom shaders fall back (decompiled text for reference in `reference/shaders/`).
- Not rebuilt automatically yet: AnimationClip / AnimatorController (dumped only),
  Addressables catalogs (bundles are repacked; the catalog must be rebuilt with the
  Addressables package), Terrain, lightmaps, Timeline assets, SerializeReference fields.
  `extract_report.json -> unsupported` lists what a given game uses.
- Editor version drift: fields that don't exist in the target editor are silently skipped.

## 5. Self-test

`testdata/StarDrift` is a small generated game covering sprites, sprite sheets, audio,
mesh, material, text, ScriptableObjects, prefabs, two scenes, a Resources asset and an
XOR-obfuscated runtime bundle with a junk header. `scripts/selftest.py --unity <Unity.exe>`
builds it (plain and LZ4 `data.unity3d` players), runs the pipeline in plugin and stub
modes, and asserts the rebuilt player reproduces the original's smoke counters with no
new errors.
