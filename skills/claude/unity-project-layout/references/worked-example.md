# Worked example: TATSUJIN EXTREME reconstruction (2026-11-02)

Project `D:/games/TruxtonExRecon/Reconstructed`, Unity 2023.2.22f1, about 7 GB of Assets. The user asked to "make this project layout as a default unity game project layout" and chose: the remaster's own content by type, the extracted original game (11,605 files, 4.3 GB) kept whole as one folder.

## Before

```
Assets/
  OriginalRecovered/   11,605 files: the ripped game, its own layout (Plugins/, Resources/, Scenes/, TXE_GraphicData/ ...)
  Reconstruction/      scenes (Hub, StagePlay/, StageInspection/, Arcade/ArcadeBoot), runtime C#, Shaders/Recovered/*.hlsl
  Truxton/             43 runtime C# files + one .shader
  TruxtonImported/     Scenes/, Prefabs/, Materials/, Textures/, Meshes/, Animations/, Settings/ (URP assets)
  TruxtonGameplay/     3 prefabs, 4 materials, 2 anims, 3 json, UI/ (173 font pngs)
  Editor/              26 editor C# files
  Resources/ StreamingAssets/ Plugins/ AddressableAssetsData/
  ReconstructionHub.cs, DebugUIHandlerRenderingLayerField.cs, URP global settings, DefaultVolumeProfile.asset
```

## Plan (40 steps, in this order)

OriginalRecovered → OriginalGame; TruxtonImported/Scenes → Scenes/Round1; Reconstruction/StagePlay, StageInspection, Hub.unity, Arcade/ArcadeBoot.unity → Scenes/; Editor → Scripts/Editor; Truxton → Scripts/Runtime/Gameplay; Reconstruction/Arcade, Bosses, Stage*.cs → Scripts/Runtime/{Arcade, Stage/Bosses, Stage}; root .cs → Scripts/Runtime(/Compatibility); Reconstruction/Shaders → Shaders, then Scripts/Runtime/Gameplay/Round1Terrain.shader → Shaders/; TruxtonImported/Textures → Textures, then ComicBlank.png and TruxtonGameplay/UI into it; TruxtonImported/Materials, Prefabs, Meshes, Animations → Materials, Prefabs, Models, Animations, then the TruxtonGameplay files into `*/Gameplay`; TruxtonImported/Settings + root URP assets → Settings; TruxtonGameplay json → Data. Emptied: Reconstruction, TruxtonImported, TruxtonGameplay. Resources, StreamingAssets, Plugins, AddressableAssetsData unchanged (audio stayed in Resources/TruxtonAudio because the game loads it by name).

## Result

- Move: 40 steps, 13,189 assets, 0 errors, seconds; no reimport. Build Settings rewritten by GUID.
- Rewrite: 450 replacements in 122 files, including **79 recovered shaders inside the kept-whole library** whose `#include "Assets/Reconstruction/Shaders/Recovered/x.hlsl"` pointed into a folder that moved. Moving one folder broke files in a folder that did not move — survey shader includes across the whole project, not just the moved part.
- Hand fixes: `os.path.join(ASSETS, 'OriginalRecovered')` in 7 Python tools (bare name, not a path), `p.StartsWith("Assets/TruxtonImported/")` meaning "prefer the remaster's converted prefab" → `Assets/Prefabs/`, `path.Contains("TruxtonImported")` in a check, a generator's `Directory.CreateDirectory("Assets/Reconstruction")`.
- Missed at first, found by the survey afterwards: about 180 old paths in **JSON data inside Resources** (provenance `prefab` fields) and two dedup manifests whose tool reuses entries only if `File.Exists(entry.prefab)`. Scan data files too (rewrite_paths.py does by default).

## What went wrong, and the lesson

- The user's editor was open. Moving under it would have made Unity delete and reimport everything. Asked the user to close it; waited.
- `AssetDatabase.StartAssetEditing` around the moves: folders created with `CreateFolder` inside it were not visible to the next step's `IsValidFolder`, risking duplicate "Scripts 1" folders. The mover does not batch.
- First compile after the move: `CS0006 Metadata file 'Assets/OriginalRecovered/Plugins/DOTween.dll' could not be found` — the build graph still had the old plugin path; the immediate recompile was clean. Judge compile errors after the last `CopyFiles Library/ScriptAssemblies/...`.
- A hit-flash render check went from 12/12 to 10/12 (two meteors rendered a yellow additive glow). The move changed no content, but gameplay scripts had also been edited since that check's last run, so the cause could not be attributed. **Run the project's checks right before the move** so any difference afterwards is the move's.
- A play-mode check failed once at the attract demo and passed on two reruns; reported as flaky with the evidence, not as a pass.
- The project's own play check had been pacing presses by editor update ticks; once the game capped its frame rate the editor ticked faster than the game and presses piled up. Unrelated to layout, but a reminder that checks driven from `EditorApplication.update` should wait on `Time.frameCount`.
