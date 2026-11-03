---
name: unity-project-layout
description: "Reorganise a Unity project's Assets folder into the standard game project layout (Scenes, Scripts/Runtime + Scripts/Editor, Prefabs, Materials, Textures, Models, Animations, Audio, Shaders, Settings, Data, with third-party or extracted libraries kept whole) without breaking anything: survey what is there, agree the target tree, move every asset inside Unity so GUIDs and references survive, rewrite hard-coded paths in scripts, shader #includes, tools and docs, verify against pre-move baselines, and leave an undo manifest. Use whenever the user wants to restructure, reorganise, tidy, clean up, standardise or 'make default' a Unity project's folders, sort assets by type, rename or move asset folders safely, fix a messy Assets folder after an import, rip or merge, or asks what the standard Unity folder layout is and wants it applied - even if they only say 'make this a normal unity layout' or 'move the scripts into Scripts'."
---

# Unity project layout

Moving assets in a Unity project looks like file shuffling but has three ways to go wrong: Unity loses track of assets that move behind its back (it sees a delete plus a new file, reimports everything and may break references), code and shaders hold path *strings* that no move updates, and a few folder names have meaning to Unity and must not move at all. This skill does the move inside Unity, keeps a manifest of every old and new path, rewrites the strings from that manifest, and proves the project still behaves the same.

Bundled tools (copy them in; they are project-agnostic):

| File | Job |
| --- | --- |
| `scripts/survey_layout.py` | Read-only survey: top-level folders, file counts by type, special folders, asmdefs, hard-coded `Assets/...` strings, whether an editor has the project open |
| `scripts/LayoutMover.cs` | Editor script: runs a JSON move plan with `AssetDatabase.MoveAsset`, writes the manifest, fixes Build Settings, removes emptied folders; `Undo` reverses it |
| `scripts/rewrite_paths.py` | Rewrites old paths to new ones from the manifest in code, shaders, tools and docs; dry run, backups, leftover report |

`tests/selftest.sh` builds a throwaway Unity project full of the usual traps (path strings in C#, an absolute shader `#include`, a Resources load, prefab→material and scene→prefab links, a vendor folder kept whole, a tool joining path pieces), runs survey → move → rewrite → verify → undo and prints PASS/FAIL per check. Run it after changing the tools, or once on a new machine or Unity version (needs a Unity editor path; about 5 minutes).

Read `references/standard-layout.md` when choosing the target tree (folder conventions, which folders Unity treats specially, how to sort by extension). `references/worked-example.md` is a real 13,000-asset run with its plan and what went wrong, worth a skim before the first move on a big project.

## Workflow

### 1. Survey

```bash
python -I scripts/survey_layout.py <ProjectRoot> [--extra <tools dir> ...]
```

It prints the tree with counts and sizes, the special folders found, asmdef files, every hard-coded asset path by file, and whether Unity is running on this project (`Temp/UnityLockfile` plus the process list). Also check: version control (`git status` — an uncommitted tree makes undo harder), free disk space, and whether other tools, skills or docs outside the project reference its paths (pass them as `--extra`).

### 2. Agree the target with the user

Show the current top level and a proposed tree. The decision that matters most is **scope**: the project's own content sorted by type is the usual answer; large third-party packages, asset-store content or extracted/ripped libraries are normally kept as one folder with their inner layout unchanged (their internal structure is how their own tools and docs find things, and splitting 10,000 files by type buys little). Offer that as the recommended option and let the user pick; also ask about renames of folders whose names carry history. If the request is a question ("what's the standard layout?"), answer it from the reference and stop.

### 3. Capture baselines before touching anything

Whatever checks the project has — compile, play-mode checks, test runner, render captures, shader compile checks — run them now and keep the results. After the move you compare against these. Without a pre-move baseline, a difference afterwards cannot be attributed to the move or to someone's earlier edit (this happened in the worked example and left a question open). Also copy `ProjectSettings/` to a backup folder.

### 4. Write the plan

`layout-plan.json`, ordered steps; a step moves a folder (with everything in it) or one file:

```json
{
  "steps": [
    {"from": "Assets/ThirdPartyRip", "to": "Assets/OriginalGame"},
    {"from": "Assets/Game/Scenes", "to": "Assets/Scenes"},
    {"from": "Assets/Game/Code", "to": "Assets/Scripts/Runtime"},
    {"from": "Assets/Scripts/Runtime/Terrain.shader", "to": "Assets/Shaders/Terrain.shader"}
  ],
  "emptied": ["Assets/Game"]
}
```

Rules that keep it safe:
- Each `to` must not exist yet (MoveAsset will not merge into an existing folder). Move whole folders first, then pull single files out of their new home (as the shader above).
- Leave Unity's special folders where they are or keep them special: `Resources` (code loads by the path *inside* it), `StreamingAssets` (only one, at `Assets/StreamingAssets`), `Plugins` (compiled first), `Editor` folders (an `Editor` folder anywhere is editor-only), `Editor Default Resources`, `Gizmos`, `AddressableAssetsData`, `WebGLTemplates`, `Packages/` (not under Assets). Full table in the reference.
- `emptied` lists source folders the steps should leave empty; the mover deletes them only if nothing but folders remains.

### 5. Move inside Unity, with the editor closed

The user's editor must be closed: Unity watching the folder turns every disk change into delete + reimport, and a batch run cannot open a project that is already open. If the survey says it is open, ask the user to close it (save first) and wait — do not kill their editor.

Copy `scripts/LayoutMover.cs` into any `Editor` folder of the project, then:

```bash
Unity.exe -batchmode -quit -projectPath <ProjectRoot> -executeMethod LayoutMover.Run \
  -layoutPlan <abs path>/layout-plan.json -layoutManifest <abs path>/moves.json -logFile <abs path>/move.log
```

Check the log for `[Layout] steps=N assets=M removed=K errors=0`, look for crashes (`Crash!!!`, exit 139), and inspect the new top level and `ProjectSettings/EditorBuildSettings.asset` (the mover rewrites scene paths by GUID). `moves.json` records every step and every asset's old and new path with its GUID; `LayoutMover.Undo` (same arguments) puts everything back. Check that new folders have the spelling the plan asked for: the asset database can remember a deleted folder's case, so `CreateFolder("Assets/Prefabs","Player")` once gave `player`. The mover now corrects that itself (a `[Layout] folder case` line); for a move made with an older copy, `LayoutMover.FixCase` (same manifest argument) fixes every destination folder. MoveAsset keeps each asset's `.meta`, so GUIDs and every serialized reference survive and nothing reimports — on a 13,000-asset, 7 GB project the move took seconds.

### 6. Rewrite path strings

```bash
python -I scripts/rewrite_paths.py --project <ProjectRoot> --manifest moves.json \
  --extra <tools dir> --extra <docs or skills dir> --backup <backup dir> --dry-run
```

Review the per-file counts, then run without `--dry-run`. Add `--exclude <text>` for any file that must keep old paths (a project's own earlier mover or undo map). It replaces every old path (longest first, whole names only, `/` and escaped `\\` forms) in `.cs`, shaders (`.shader/.hlsl/.cginc/.compute`), `.asmdef`-free text, Python/shell/PowerShell tools and Markdown, keeps line endings and BOMs, and backs up each file it changes. It skips the plan, manifest and mover (their old paths are the undo map). It then lists **leftovers**: full paths into folders the plan dissolved that it could not map, and those folders' names standing alone as quoted strings (`'Imported'`, `"Imported"`). A quoted name can be a false positive (a product or company name that happens to match), so read each one. Fix those by hand — they are the interesting ones:
- Path pieces joined in code: `os.path.join(ASSETS, 'Game', 'Prefabs')`, `Path.Combine("Assets", folder)`.
- Bare folder names used as tests: `path.Contains("Imported")`, `StartsWith("Assets/Game/")` — work out what the test *means* (e.g. "prefer the remaster's converted prefab") and point it at the new folder.
- Generators that create folders (`Directory.CreateDirectory("Assets/Game")`).
- Absolute `#include "Assets/..."` in shaders — rewritten automatically, but any shader that failed to import before the move will now reimport, so check shader errors.
Historical reports and evidence files are better left alone with an old→new table added than rewritten.

### 7. Verify

- **Compile.** Open/batch-run the project and read the log *after the last* `CopyFiles Library/ScriptAssemblies/Assembly-CSharp*.dll`. The first compile pass after a move often fails with `CS2001 Source file 'Assets/<old path>/X.cs' could not be found`, `CS0006 Metadata file 'Assets/<old path>/X.dll' could not be found` or `CS0103` for newly added files, because the build graph or the asset database still has the old state; the recompile right after is the one that counts. Give Unity the project's long path: with an 8.3 short path (`C:/Users/ADMINI~1/...`, which is what `TMP` holds on some Windows accounts) it compiles the scripts but cannot bind them to their classes, so every MonoBehaviour shows as a missing script — this looks exactly like a broken move, but it is the path (`cygpath -m -l` gives the long form).
- **References.** Build Settings scenes, any `Missing (Script)` / missing prefab warnings in the log, Addressables groups (they hold GUIDs, so they survive; addresses that were set to the old path stay as strings — fine unless code builds them).
- **Behaviour.** Re-run the step 3 baselines and compare. Run play-mode checks more than once if they are timing-sensitive; report a check that fails once and passes on reruns as flaky, with what you saw, rather than as passing.
- **Crashes.** Check every Unity run's log and exit code.

### 8. Report

Tell the user the new top-level tree, the counts (steps, assets, errors, replacements, files), what was verified and how, anything that differs from the baseline and whether the move can be the cause, where the manifest and backups are and how to undo. Add an old→new table to the project's main docs so older notes stay readable.

## Undo

First copy the rewritten text files back from the `--backup` folder — it mirrors the files' paths *after* the move, so restore them while the new layout is still in place. Then run `LayoutMover.Undo` with the same `-layoutManifest`; it replays the steps backwards and restores Build Settings. Undo only cleanly reverses a move that has not been followed by further moves of the same assets.
