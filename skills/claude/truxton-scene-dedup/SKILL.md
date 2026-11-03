---
name: truxton-scene-dedup
description: "Find GameObjects in a Unity scene or prefab that are really copies of one another (same components, values, meshes, materials and child layout, but separate objects with different names or placements, as happens when a build is ripped and nested prefabs are flattened), make one prefab per group, and replace every copy with an instance of it, proving the flattened result and the rendered frames are unchanged. Built for the TATSUJIN EXTREME (Truxton Extreme) Unity 2023 remaster (BG03 stage background), works on any scene or prefab. Use whenever the user asks to optimize, deduplicate, clean up, slim down or prefab-ize scene objects, says objects are duplicated or 'treated as different ones', a scene or prefab is too big or slow to load, or wants repeated rocks, lights, effects, props or UI turned into prefabs — even if they only say 'dedup the stage' or 'make prefabs of the copies'."
---

# Scene dedup: copies → prefabs

A rip flattens every nested prefab into plain GameObjects. `BG03.prefab` had 1,207 objects, but most were copies: 142 `pf_eff_bg03_volume_light1`, 96 `pf_bg03_rock_pillar_600`, two different 44× and 33× `pf_bg03_rock_200_b` variants, and so on. Unity treats each copy as its own object, so the file repeats the same data hundreds of times. This skill detects the copies by content, not by name, makes a prefab per group, and swaps the copies for instances.

The tool is one editor script, [scripts/SceneDedup.cs](scripts/SceneDedup.cs). Install it into the project at `Assets/Scripts/Editor/SceneDedup.cs` (it is already in the staging project). Staging project: `D:/games/Truxton Extreme/extractor/UnityProject`, Unity **2023.2.22f1**. The user's `C:/Users/Administrator/Documents/TruxtonRemaster` is theirs and is often open; never batch against it. Batch rules from `truxton-unity-checker` apply: no editor may hold the project (`Temp/UnityLockfile` absent).

## What counts as a copy

Two subtrees match when they hash equal. The hash covers every serialized value of every GameObject and component, all descendants in order, child names, and asset references (GUID + local id). References between objects inside the subtree are written relative to its root. Floats are compared exactly unless you pass `-dedupTolerance`. Only the root's name, active flag and placement (TRS, RectTransform anchors) may differ; those become instance overrides. An existing prefab instance counts as one unit: its source prefab plus its overrides.

A copy is **left alone** (the report gives the reason) when:
- another file points into it by fileID. Example: `Stage01.unity` / `Round1.unity` override `m_IsActive` on BG03's `bsa_*`/`bg_area*` areas and hold stripped references to `Camera`, `item_area3` and others. Replacing such a copy would orphan those overrides.
- a component outside it references something inside it. Example: every HUD `Glyph`/`Lamp`/`Bomb` in the scenes is wired to `Round1Hud`/`Round1HudText`.
- it references a scene object outside itself, which a prefab asset can't hold.

With `-dedupRemap 1` a copy referenced from elsewhere in the same target is still replaced and those references are
re-pointed to the matching object of the new instance (same hierarchy position, same component index); the digest then
proves it. Use it for stage prefabs, whose root PlayableDirector binds the timeline to rings, meteors and other copies.
Copies referenced from inside another copy stay blocked.

Groups that only ever appear once inside every copy of a bigger kept group are marked `redundant`: the bigger prefab already carries them. Smaller groups are processed first, so bigger prefabs nest them (`pf_bg03_bridge_set1` → 3 × `pf_bg03_bridge_a`).

## Workflow

Run each step in a separate batch, in order. Every command uses `$U='C:\Program Files\Unity 2023.2.22f1\Editor\Unity.exe'` and `$P='D:\games\Truxton Extreme\extractor\UnityProject'`. Write outputs under `extractor/scene-dedup/`.

1. **Report** (changes nothing, ~40 s for a dozen targets):
   ```powershell
   & $U -batchmode -projectPath $P -executeMethod SceneDedup.RunBatch -dedupMode report `
     -dedupTargets 'Assets/Prefabs/BG03.prefab;Assets/Scenes/Round1/Stage01.unity' `
     -dedupReport '<out>\report.json' -logFile '<out>\report.log'
   C:\Python311\python.exe <skill-dir>\scripts\summarize.py '<out>\report.json'
   ```
   Targets are `;`-separated `.prefab` or `.unity` paths. Survey the biggest files first (`ls -S Assets/Prefabs/*.prefab`) and both scenes.
2. **Render the before state** of a scene that uses the target. This must run before apply. If you forgot, copy the backup in temporarily.
   ```powershell
   & $U -batchmode -projectPath $P -executeMethod SceneDedup.RenderBatch `
     -dedupRenderScene Assets/Scenes/Round1/Stage01.unity -dedupRenderOut '<out>\render-before' -logFile '<out>\render-before.log'
   ```
   It calls every public `Seek(float)` in the scene (`Round1Playback.Seek` moves the stage) at `-dedupRenderTimes` (default `0;30;90;180`). It simulates particles from a fixed seed and renders every enabled camera at 1280×720.
3. **Apply** with the same command as step 1 and `-dedupMode apply`. Per target it:
   - backs up the file to `extractor/Backups/before-scene-dedup-<timestamp>/` (override with `-dedupBackup`);
   - writes the prefabs to `<target folder>/Dedup/<target name>/` (override with `-dedupOutRoot`), plus a `dedup-manifest.json` that maps each signature to its prefab;
   - swaps the copies and saves;
   - reloads the target and compares every GameObject and component with the original, keyed by hierarchy position. `digestMatch` must be true. On any difference it restores the backup and reports `restored`.

   Pass one shared `-dedupOutRoot` across targets, and the manifest lets their common groups (e.g. `pf_eff_damage01`) reuse one prefab. A rerun on an already-deduped target only finds what is left, because existing instances are never regrouped.
4. **Render after and compare**: step 2 with `-dedupRenderOut '<out>\render-after' -dedupCompareWith '<out>\render-before'`. A frame fails if more than 0.1 % of pixels differ by more than 8/255. Look at one frame to be sure it shows the stage and isn't blank.
5. Check that every `fileID …, guid: <target guid>` in other files still exists as `&<id>` in the new target. `100100000` is the prefab asset itself and is fine.

The scene's own harnesses can run on top of this. `Round1PlayCheck` has failed (`elapsed 0`) on the untouched original since the intro/Story changes, so its failure says nothing about dedup.

## Reconstruction project (since 2026-11-01)

The staging project and `extractor/` are gone; the one project is `D:/games/TruxtonExRecon/Reconstructed` (tool at
`Assets/Scripts/Editor/SceneDedup.cs`). Stage prefabs are `Assets/OriginalGame/Samples/Prefabs/Reference/Stage/BGxxStage.prefab`;
render with `StagePlay/StagePlay_BGxx.unity`. Pass `-dedupBackup D:/games/TruxtonExRecon/Backups`; evidence in
`TruxtonExRecon/evidence/scene-dedup/BGxx/`. Check crashes with `tools/common/crash_report.sh <log> <exit>`.
Library mode (v2, 2026-11-02): `-dedupLibrary Assets/OriginalGame/TXE_GraphicData -dedupLibraryCache <json>` makes
copies of the game's own prefabs (exact content, or same structure: child names, component types, renderer meshes/materials,
root components free) instances of those prefabs, even single copies, via PrefabUtility.ConvertToPrefabInstance; a duplicate
taken first sets every value back as overrides (the conversion skips GameObject fields like layer 30, null references, and
can pair same-named children differently). A component pre-check (same types in order; the copy's root may add some) keeps
misfits flat. `-dedupOutRoot Stage/Dedup/Shared` shares new prefabs across stages. `SCENE_DEDUP_DEBUG=1` makes a digest
mismatch name the differing property. v2 result: 65.1 -> 9.6 MB, 191 original prefabs used, 20 shared new ones.
First pass (v1, superseded):  with `scripts/run_stage.sh BGxx` (copy to TruxtonExRecon/tools/scene_dedup):
13,825 copies, 65.1 -> 10.5 MB, digest and frames identical (TruxtonExRecon/evidence/scene-dedup/SUMMARY.md). The tool saves each
new prefab once: save-then-renormalize crashed Unity natively in WriteCachedMetaData on the big stages.

## Results so far (staging, 2026-10-27)

| Target | Result |
|---|---|
| `BG03.prefab` | applied: 37 prefabs replaced 756 copies (324 top-level instances); 6.63 MB → 1.30 MB, plus 1.2 MB of new prefabs in `Prefabs/Dedup/BG03/`. Digest match; frames at 0/30/90/180 s byte-identical. 3 `pf_eff_bg03_fire2` copies are kept because the scenes reference them. |
| `Stage01.unity`, `Round1.unity` | not applied: all repeats are HUD glyphs/lamps wired to HUD scripts (blocked) except 10 `Empty bomb` and 12 `Lamp frame`, too small to matter. The HUD builder regenerates them anyway. |
| enemy/boss/player prefabs | small repeats only (`pf_eff_damage01` ×12 in `pf_bs03`, burners ×2–4); player options are blocked by scene references. |

The user's TruxtonRemaster had the same BG03 as staging (md5 `f39d4aa5…`). Installing there means copying `BG03.prefab`, the `Dedup/BG03` folder **with its .meta files** and `SceneDedup.cs`, and only with the user's go-ahead, since the project is theirs and usually open.

## Limits

- Savings are in asset size, import and load time, editor memory, and in having one place to edit a rock or a light. **Runtime** GameObject and draw counts don't change: a player build flattens instances into the scene again, and copies already shared their meshes and materials. Cutting runtime cost is a separate job: GPU instancing / SRP Batcher checks for the repeated meshes, merging static rocks, culling particle emitters off-screen.
- `TruxtonRound1Importer` regenerates `BG03.prefab` flat. Rerun this skill after any re-import of the stage.
- Copies that differ in one tiny value (a child moved by 1e-6) group separately. `-dedupTolerance 1e-4` merges them, and the digest then compares at that tolerance too. Report how many groups this added before keeping it.
- Restore by copying the backup file over the target and deleting the `Dedup/<target>` folder.
