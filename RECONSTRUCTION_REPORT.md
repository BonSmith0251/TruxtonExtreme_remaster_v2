# Truxton Extreme reconstruction

Project: `D:\Games\TruxtonExRecon\Reconstructed`. Required editor: **Unity 2023.2.22f1**. This is an editable asset and scene reconstruction with a supplemental Round 1 implementation. **The complete original game is not reconstructed or verified playable.**

The installed game at `D:\games\Truxton Extreme` is preserved. All 275 original file SHA256 values match the initial inventory, with no added files. See [preservation check](evidence/source-preservation.json).

The source player is Unity 6000.3.7f1 with IL2CPP metadata 39. The pristine export targets the source format and was not validated in a source-version editor. Migration to 2023.2.22f1 is enabled and implemented as a compatibility port. The installed target supports a Windows x64 Mono build; original IL2CPP runtime parity is not established.

Comic content is intentionally excluded at the user's request. The target uses one transparent 1x1 image. The exclusion includes 81 encoded Comic bundles and 173 Comic audio clips, plus their 173 duplicate remaster copies. Original files and diagnostic source evidence remain intact.

| Recovery evidence | Result |
| --- | --- |
| Serialized source inventory | 270,371 objects across 75 types; this readable-container population includes the subsequently excluded Comic audio |
| Strict source data decoding | 270,368 objects; three remaining schema failures |
| Decoded source references | 945,368 non-null references resolve; 305,027 original nulls |
| Stream ranges | All 2,968 inventoried ranges fit their source streams |
| Original GameObjects | 77,558 retained in the native export |
| Native export | 2,150 prefabs, 318 animation clips, 315 controllers, 554 material files, two source boot scenes |
| Metadata models | 118 assemblies, 18,705 types, 83,764 fields, 136,680 original method definitions |
| Executable code recovery | Three BootTXE coroutine methods, plus 91 separately verified simple native methods; most original methods remain stubs |
| Automatic IL recovery | Zero recovered bodies in the inspected Cpp2IL revision; output-mode implementation and method census retained |

Source decoding, imported attachment and gameplay fidelity are separate outcomes. Per-type counts are in [coverage-by-type.json](evidence/coverage-by-type.json). [Standard JSON type trees](extraction/typetrees.standard.jsonl.gz) represent original infinite float values with explicit tags; raw serialized bytes are also retained.

The target contains recovered original assets under `Assets/OriginalRecovered`. Original Boot and BootTXE scenes retain their source graph structure. Derived StageInspection scenes expose the eight stage prefabs for editor inspection; they are reconstructed entry scenes, not original authoring scenes or working stage logic. The supplemental Round 1 scene is `Assets/TruxtonImported/Scenes/Round1.unity`. Its gameplay, camera, effects and some rules are documented reimplementations and approximations.

The migration preserves source GUIDs and local IDs where available, translates PluginImporter metadata into the actual target schema, repairs package-script references, maps known standard shader identities to target package shaders, and retains explicit custom-shader limitations. The original game assembly models are not equivalent to recovered C# gameplay. BootTXE recovery still depends on unrecovered systems, including original startup/menu, streaming, saving and stage orchestration.

The final editor import and compilation passed in Unity 2023.2.22f1. All 14 project scenes open with zero missing scripts/references. All 2,150 original prefabs load with zero missing scripts; their audited graph contains 77,535 GameObjects and 168,720 components, including the added Comic placeholder. All 11,578 recovered asset files have recognized main types. These checks do not establish complete source-to-target field or behavior equivalence.

The Windows x64 Mono build succeeded with zero reported build errors and eight warnings. Two earlier attempts failed in Bee's movie copier, producing zero-byte destination files. The successful process temporarily stages target StreamingAssets outside Assets, restores it in a finally block, then independently copies and hash-checks all 99 player payloads (98 original movies plus one supplemental movie). All 98 original project movie hashes still matched after the failed attempts. The root cause of Bee's copy failure is not established. See [build result](evidence/scene-integration/build-result.json) and [player payload checks](evidence/scene-integration/player-streaming-hashes.json).

Runtime validation exposed and repaired three compatibility defects: the mixed implementation now explicitly enables both input backends; non-Legacy manual animation sampling receives its required Animator; and one unused private UniTask callback with an invalid Unity signature has a documented compatibility rename. That rename changes no public API or recovered method behavior. A real player run now reports the animated camera moving from (0,315,80) at stage time 0 to (0,315,115.024994) at stage time 1.099803, with no prior callback or sampling errors. Its 12-second image was captured during the intro and is explicitly insufficient gameplay visual evidence.

Independent validation passed two ordinary Round 1 Play/Stop cycles in a fresh graphics editor, with zero test errors. Actual screenshots show gameplay after the intro at stage times 8.50 and 9.88 seconds. The normal standalone launch also passed: a visible Hub, its actual Play button, and post-intro gameplay were checked without the capture flag. The earlier hidden-window presentation failure is retained separately; visible-from-start validation had no callback, sampling or presentation errors. Original video timestamp/color warnings remain.

The recovered TXE pipeline completed an additional temporary BG01/BG03 rendering probe with zero probe errors and restored global assignments. In that probe, it honored the original camera renderer indices and avoided the fallback caused by the supplemental Round 1 pipeline. The project default remains the supplemental pipeline; inspecting original cameras under that default can still select a fallback renderer. The static images show textured rocks in BG01 and a distant object against a mostly empty background in BG03. They establish limited geometry/texture rendering, not complete original-stage presentation, timeline execution or visual fidelity.

| Validation scope | Verdict |
| --- | --- |
| Original installation preservation | PASS: all 275 initial SHA256 values unchanged; no added files |
| Target editor import, compilation and scene/prefab attachment | PASS for the audited target scope |
| Ordinary supplemental Round 1 editor Play twice | PASS, zero test errors, actual gameplay frames inspected |
| Windows x64 Mono Development build and normal Hub-to-Round1 entry | PASS; player frames inspected; build has eight warnings |
| Original boot graph | All 24 paths/parents/child order/activation/layers/component order match; tested local references match |
| Original-stage static rendering | Limited geometry evidence; complete presentation and fidelity INCONCLUSIVE |
| Complete original game, original menus/save/stage logic | NOT RECOVERED or verified playable |

To use the project, open `Reconstructed` in Unity 2023.2.22f1 and open `Assets/Reconstruction/Hub.unity`. The playable entry is the supplemental Round 1 button. Original Boot/BootTXE and StageInspection scenes are for reconstruction inspection. Controls: WASD/arrows move, Space/Z fire, X bomb, C weapon, Esc/P pause, F4 toggles autopilot.

Standalone: [TruxtonExRecon.exe](Build/TruxtonExRecon.exe). Keep its adjacent data/DLL folders. Evidence: [editor Play completion](verification/editor-play-twice/completion.json), [first editor gameplay frame](verification/editor-play-twice/play-1.png), [normal standalone entry](evidence/scene-integration/normal-entry-final.json), [standalone gameplay frame](evidence/scene-integration/normal-round1-gameplay.png), and [recovered-pipeline probe](verification/stage-preview-native-pipeline/probe-result.json).

Useful evidence and reproduction files:

- [Extraction coverage](extraction/coverage.json), [destination mapping](extraction/destination-map.json), and [native export summary](extraction/native-export-summary.json).
- [Code handoff](code/HANDOFF.txt), [code recovery report](code/code-recovery-report.json), and [simple native method evidence](code/simple-native-recovery/summary.json).
- [Migration contract](evidence/migration/compatibility-handoff.md), [managed-layout recovery](evidence/managed-layouts/outcomes.json), and [independent source review](verification/independent-extraction-review.json).
- [Reproducible build helper](tools/build_reconstruction.py): close the target editor and run `C:\Python311\python.exe D:\Games\TruxtonExRecon\tools\build_reconstruction.py`. The helper restores project StreamingAssets even on build failure and verifies every player payload.
- [Source verification helper](tools/verify_source.py), [managed-layout recovery helper](tools/recover_managed_layouts.py), and the extraction/integration scripts under `extraction` and `scene-work`.
- [Engine-system coverage and actionable recovery gaps](ENGINE_SYSTEMS.md).
- [Installed skill improvements and backups](evidence/skill-maintenance/installed-updates.json). Ten verified improvements were installed in the coordinator's extraction, code, migration and validation references, which were updated with verified findings and passed skill-creator structural validation.

Remaining limitations include most original executable behavior, original custom shaders and render features, complete source-to-target mapping of nested objects, and three source schemas: PlayerSettings, the URP global-settings object, and one built-in managed object. Exact hierarchy/value/reference equivalence for every prefab and full original-game visual or behavioral parity are not established by successful compilation or a supplemental player test.

Large immutable exported media may share NTFS hardlinks between the target and reconstruction baseline to conserve disk space. No target file is hardlinked to the installed original game. Metadata, scripts and editable serialized documents are independent copies; the baseline's media hashes should be rechecked if those payloads are edited.

Final integrity: the independent verifier checked all 27,737 frozen Assets/Packages/ProjectSettings files. Revision v4 matches manifest SHA256 `a4addaf382b3296745a1da8c15d8aa8d5fd230af1d50d080508df91b36730c7a`; it differs from gameplay-tested v3 only in the Editor diagnostic helper. The temporary pipeline probe caused Unity to persist two settings changes despite successful live-reference restoration. Their changed bytes/diffs were retained, then GraphicsSettings and QualitySettings were restored to the exact frozen hashes after the editor exited. See [restoration evidence](verification/native-pipeline-settings-side-effect/restoration.json) and [final independent verification](verification/FINAL_VERIFICATION.txt).

For future source-pipeline diagnostics, use [verify_native_pipeline_safe.py](tools/verify_native_pipeline_safe.py) with the target editor closed. It backs up the two graphics/quality settings files and restores their exact bytes after its owned editor exits. This new guard was syntax/cleanup checked; the underlying probe and manual hash-verified restoration were executed. Calling the raw Editor probe directly does not guarantee unchanged serialized settings.
Follow-up autoplayer audit (2026-10-31): all 264 local GOG manifest files match; no persistent patch found. Isolated code recovery retry reproduced the same placeholder-only output. See [audit and retry](evidence/autoplayer-patch-audit/REPORT.md).

## Follow-up 2026-11-01: original stage timelines play

The eight StageInspection scenes now play the original BG01-BG08 stage timelines instead of showing a frozen first pose. Open `Assets/Reconstruction/Hub.unity` and use the BG01-BG08 buttons, or open a StageInspection scene directly and press Play. Controls: P/Space pause, PgUp/PgDn seek 10 s, +/- speed, Home restart, Esc back to the Hub.

| Finding | Result |
| --- | --- |
| Why the stages were frozen | Every stage director uses Manual update mode with no play-on-awake. The original stage kernel ticks it, and that code is a stub. |
| Migration defect found and repaired | Player-format `PropertyName` ids (`exposedName: {id: N}`) load as id 0 in the 2023 editor, so no ControlTrack clip resolved its GameObject. 60 references in 20 timelines were rewritten as `exposedName: N` to match the directors' exported keys ([tool](tools/repair_exposed_names.py), [log](evidence/stage-presentation/exposed-name-repair.json); originals in `backups/before-stage-presentation-20261101-113420`). |
| New runtime driver | [StagePresentation.cs](Reconstructed/Assets/Reconstruction/StagePresentation.cs) ticks the original root stage director through the real Timeline 1.8.7 package. For that run only, it disables child timelines whose tracks need unrecovered InGame.Kernel code (EnemyEntry, TLEntry, EventEntry, BGMEntry, AreaEntry, BGSlideRange). BG05's root BGSlideRangeTrack is left out through a runtime ControlTrack-only copy. Original assets are not modified by the driver. |
| What now runs | Each stage's `BGxx_bg` timeline: camera rail, background objects, activation windows and controlled particles (BG01 also its empty `BG01_ge`). |
| What does not run | Enemies, waves, items, stage music cues, area and slide events (`mainTL` and `BGxx_ge`). Their classes, including constructors and `clipCaps`, are throw-null stubs. |
| Renderer warning | The original cameras request renderer 1 of TXE_PipelineAsset, which the default Round1 pipeline lacks. URP warned every frame (41k warnings in 50 s of Play) and then used its default renderer anyway. The driver now selects that default explicitly at runtime, with the same pixels and no warnings. |

Verification ([report](verification/stage-presentation/report.json), contact sheets `verification/stage-presentation/BG0x.png`):

| Check | Verdict |
| --- | --- |
| Edit-mode evaluation, 7 times across each full timeline, 8 stages | PASS: zero exceptions, errors or warnings. Source cameras travel 8,000-30,000 units (BG01 541 s, BG02 600 s, BG03 540 s, BG04-BG08 1,800 s). |
| Ordinary editor Play, 6 s per stage, 8 stages ([log](verification/stage-presentation/play-mode.jsonl)) | PASS 8/8: stage clock advanced about 6 s, camera moved, zero errors. The visible editor segfaulted during native shutdown after the results were written, in both runs. |
| Visual fidelity | INCONCLUSIVE. Geometry streams past correctly, but skies are flat grey and many clouds, rocks and effects render solid white, because 258 custom shaders are still dummies. |
| Integrity | Revision v5 ([manifest](evidence/stage-presentation/freeze-manifest-v5.json), [diff from v4](evidence/stage-presentation/freeze-diff-v4-v5.json)): 6 files added, 29 changed (20 timelines, 8 stage scenes, Hub script). ProjectSettings unchanged. The original installation was not touched. No standalone build was made: D: has about 4 GB free and the earlier Build folder was deleted. |

Skill improvements installed in `unity-project-reconstruction` (ledger `evidence/skill-maintenance/installed-updates.json`, before-copies alongside it): a PropertyName exposed-reference migration check (version-migration.md), and a method for presenting Manual-update timelines whose ticking code is stubbed (scenes-and-engine-features.md). Frontmatter was untouched. skill-creator quick_validate did not run because PyYAML is not installed.

## Follow-up 2026-11-01: custom shaders recovered

All 43 of the game's own shaders are recovered from their original D3D11 bytecode and installed: 21 Shader Graphs, 12 TATSUJIN/*, 8 TXE/AE/*, KANAI/SpriteAdd and UI/Trasition. Engine and package shaders were already mapped to real target shaders. Each recovered shader replaces the exporter's white dummy in place, in all 79 stub files, keeping every GUID and .meta, so no material binding had to change.

| Step | What was done |
| --- | --- |
| Evidence | [dump_shaders.py](tools/shader_recovery/dump_shaders.py) reads the game (read-only). It unpacks each shader blob, including multi-chunk LZ4 blobs, maps variants to keywords, and disassembles the DXBC with the system d3dcompiler. It also annotates registers with property names taken from the per-variant parameter blobs. Output: `evidence/shader-recovery/<shader>/`, 5 MB. |
| Translation | Each shader's math is in `Assets/Reconstruction/Shaders/Recovered/<name>.hlsl`. Shader Graph Lit/Unlit graphs share [TruxtonRecoveredSG.hlsl](Reconstructed/Assets/Reconstruction/Shaders/TruxtonRecoveredSG.hlsl) for the URP Forward/GBuffer/ShadowCaster/DepthOnly/DepthNormals passes. Hand-written CG shaders are self-contained. Five parallel workers translated the bodies. |
| Install | [build_shaders.py](tools/shader_recovery/build_shaders.py) + `specs.json`/`specs.d` write each shader with the original Properties, SubShader tags and per-pass render states (blend, ZWrite, ZTest, Cull, stencil with masks, including property references). Originals are in `backups/before-shader-recovery`. |
| TXE_Lit materials | 180 materials that Codex had moved to stock URP Lit now use the recovered TATSUJIN/TXE_Lit again. Its shader link, keywords and disabled passes were restored from the pristine export; values were never changed ([log](evidence/shader-recovery/txe-lit-material-restore.json)). TXE_Lit is URP Lit plus a `_FogUSE` switch, rim light (`_RimColor`, `_RimFactor`) and the `_FadeColor` damage fade. |
| Sky | Stages originally load additively into BootTXE, whose RenderSettings use the 6-sided space skybox `mt_skybox_space01a`. All 8 stage scenes now use BootTXE's skybox, ambient, fog and reflection settings instead of Unity's default grey sky. |
| Pipeline | Round1URP now has Opaque and Depth textures on. The original TXE renderer produced `_CameraOpaqueTexture` (TXERendererFeatureCopyColor), which distortion samples; the shield samples depth. `_Tx_SpeedRate`, a game-global time scale read by 10 effect shaders, is set to 1 at startup (the game kernel that set it is a stub). |

Verification:

| Check | Verdict |
| --- | --- |
| Compile every pass of all 79 stub files ([report](verification/shader-recovery/compile-check.json)) | PASS: 0 errors, 0 warnings. A deliberate-error negative control was caught, then removed. |
| Compile every pass with each of the 322 real materials' keywords | PASS: 0 failures |
| Workers' offline fxc checks of extra keyword combinations (fog, soft particles, UI clip, instancing) | Reported clean. Not rerun in Unity beyond the material variants above. |
| 8 stage presentations, edit-mode evaluation | PASS: zero errors and warnings. Contact sheets in `verification/stage-presentation/BG0x.png` show textured rock and grass, BG03 lava, BG05 moss and trees, BG08 planet, and the space sky; previously these were white masses and flat grey. |
| Editor Play: 8 stages, and supplemental Round 1 twice | PASS 8/8; Round 1 completed twice with 0 errors ([frame](verification/editor-play-twice/play-2.png)). The visible editor still segfaults during native shutdown after the stage run. |
| Visual fidelity against the original game | NOT MEASURED. No original-game captures exist since the autoplayer was deleted. The translations follow the bytecode, but nothing is pixel-compared. |
| Integrity | v6 ([manifest](evidence/shader-recovery/freeze-manifest-v6.json), [diff from v5](evidence/shader-recovery/freeze-diff-v5-v6.json)): 92 added, 270 changed, 0 removed. ProjectSettings unchanged; original installation untouched. |

Known limits, all documented in the bodies:
- Particle shaders with `_USEFOG_ON`: the game build compiled no such variant, so that branch is inferred (fog to black, or to fog colour for AlphaBlended).
- `SOFTPARTICLES_ON` is never enabled by URP, so the soft-particle branches stay off.
- TXE_Lit omits parallax, specular setup and clear coat; the game build has no variants for them.
- sg_emission_FlickerDepth reproduces the original clip-space depth shift through an equivalent object-space move, which also applies in GBuffer and DepthNormals.
- The lava graph reads no time value; its noise only moves if game code animates `_EmissionNoizeScloll`.
- sg_volume_light is invisible while `_FarAlpha` = 0, as in the original.
- The UnityPy export lists `_USEFOG`/fog keyword toggles that only switch URP's standard fog.

Skill maintenance: the Unity 6 shader blob and parameter format, the Shader Graph surface-recovery method, the material-keyword compile check with a negative control, and the boot-scene RenderSettings lesson were added to `unity-project-reconstruction/references/scenes-and-engine-features.md` (ledger entry 13).

## Follow-up 2026-11-01: original enemy schedules run in the stages

The eight stage presentations now spawn and move the original enemies, from each stage's own timelines: mainTL wave entries and BGxx_ge ground entries.

| Step | What was done |
| --- | --- |
| Export | [ReconstructionStageEnemyExport.cs](Reconstructed/Assets/Editor/ReconstructionStageEnemyExport.cs) reads the stage timelines, the 243 wave timelines they instantiate, 378 EnemyData assets and 335 route tables. It uses Unity serialization only, so no stub code runs. Output: `extraction/stage-enemies/raw-stage-timelines.json`. |
| Schedule rules | [build_stage_enemies.py](tools/stage_enemies/build_stage_enemies.py) writes `Assets/Resources/StageEnemies/BGxx.json` in the Round 1 data schema. It handles TLEntry waves at their start and time scale, nested waves within waves, EnemyEntry clips (offset, rotate, loops, delays), EnemyWave bonus spawns named by `_enemyDataName` (wipe-out-gated), game-mode masks, condition flags and muted tracks. Ground entries resolve EnemyData by name and are placed in stage-world coordinates. |
| Validation of the rules | Exporting BG03 reproduces the earlier, recording-validated Round 1 BG03 schedule exactly: 301 of 301 events, with matching definitions and routes. The only extra is the stage boss, which Round 1 handled separately. |
| Runtime | [StageEnemies.cs](Reconstructed/Assets/Reconstruction/StageEnemies.cs) adds the native game camera as a URP overlay on the stage's rail camera: (0,400,0) looking down, 20 degree FOV, from InGameManager.SetupCameraPosition. Its game layer sits far below the stage. It reuses Round 1's matched movers: route tables walked by distance, placements, repeats and loops, Md01 programs, multi-route programs, Sa01 steering and rotation/look-at events. Original prefabs are instantiated inactive with their stub behaviours stripped. `durationTime` 0 means no time limit (BG07 Sc01/Sn01). |
| Shader fix | Rim and fresnel `pow(0,0)` produced NaN pixels that the stage cameras' HDR post-processing spread across whole frames. The eight affected recovered shaders now use a guarded `TxPow`. |

Verification (Story A, full schedule per stage in 0.1 s steps, one editor process per stage; [reports](verification/stage-enemies/), contact sheets `verification/stage-enemies/BG0x.png`):

| Stage | Scheduled events | Spawned | Came on screen | Never on screen | Peak live | Main never-on-screen models |
| --- | --- | --- | --- | --- | --- | --- |
| BG01 | 636 | 1673 | 1106 | 521 | 146 | Pf_EneObj_Meteo_Sa01=253, Pf_Ene_St01=120, Pf_EneObj_Meteo_Ma01=58 |
| BG02 | 467 | 503 | 356 | 89 | 56 | Pf_Ene_Sv01=24, Pf_Ene_Sb01=24, Pf_Ene_Sg01=22 |
| BG03 | 449 | 1122 | 845 | 130 | 152 | Pf_EneObj_Meteo_Sa02=87, Pf_EneObj_Meteo_Ma02=12, Pf_EneObj_Meteo_La02=12 |
| BG04 | 719 | 1917 | 1370 | 408 | 160 | Pf_Ene_Sb01=168, Pf_Ene_Sm01=80, Pf_Ene_Su01=74 |
| BG05 | 573 | 648 | 341 | 51 | 150 | Pf_Ene_Sf01=43, Pf_Ene_So01=8 |
| BG06 | 379 | 745 | 471 | 36 | 210 | Pf_Ene_Sq01=18, Pf_Ene_Mn01c2=17, Pf_Ene_Mn01c=1 |
| BG07 | 696 | 821 | 305 | 192 | 132 | Pf_Ene_Sc01=152, Pf_Ene_St01=22, Pf_Ene_Sp01=18 |
| BG08 | 425 | 272 | 249 | 18 | 50 | Pf_Ene_Sv01=16, Pf_Ene_Mo01=2 |

All 8 stages: zero exceptions, zero errors, no missing models. Editor Play (8 stages, 6 s each) passes 8/8 with zero errors.

Not reproduced, because it is still native code:
- firing, damage and scoring;
- wipe-out bonus waves, since nothing is shot down;
- bosses (`Pf_Ene_Bos*` is skipped);
- meteor physics, which Round 1 had for BG03 only;
- Mj01 chain bodies and ground movement;
- player pursuit: Sa01 steers toward a fixed virtual player at (0,0,-45).

Enemies with specialised native movers fall back to Round 1's straight entry from their spawn edge. That is why some families never reach the screen (meteors, St01, Sb01, Sc01, Sf01). BG04 reaches the 160-actor cap during its Sb01 swarm. One BG03 enemy renders as a black silhouette, not yet investigated. Nothing is compared against original-game footage, because the recorder was deleted.

Integrity: v7 ([manifest](evidence/stage-enemies/freeze-manifest-v7.json), [diff from v6](evidence/stage-enemies/freeze-diff-v6-v7.json)): 23 added, 21 changed, 0 removed. The changes are the scripts, schedules, 8 scene components, 8 guarded shader bodies, the shared include, and the Hub and presentation texts. Two of Codex's URP-mapped materials (mt_bg05_debris01, mt_item_box02) were re-serialized by the editor; their shader links are unchanged. Scene backups are in `backups/before-stage-enemies`. D: has 2.4 GB free.

## Follow-up 2026-11-01: playable stages with combat

All eight stages are now playable from the Hub ("Play 1" to "Play 8", scenes `Assets/Reconstruction/StagePlay/StagePlay_BGxx.unity`). Each uses the Round 1 ship, weapons, bombs, HUD, intro and sound. The original stage timeline plays the background, the original schedule drives the waves, and enemy HP, scores, lock-on, laser blocking, hit shapes and fire come from the original data.

| Part | What was done |
| --- | --- |
| Data for every model | Three extractors, run offline on the exported YAML, each validated exactly against the Round 1 BG03 tables before generalising. [enemy_database.py](tools/stage_combat/enemy_database.py) decodes EnemyDatabase.asset: key characters XOR 0x3C, HP float bits XOR 0x00CF7A89, score XOR 0x00136ACF, all read from the native accessors. It matches 173 of 173 reference fields and resolves all 95 models. [enemy_hitshapes.py](tools/stage_combat/enemy_hitshapes.py) reads the PawnEnemy `_collisions` EnemyCollisionModel shapes for 87 of 95 models; 21 of 21 references match, and the 8 unresolved are BG08 wall zones. [enemy_attacks.py](tools/stage_combat/enemy_attacks.py) covers 189 bullet templates, 17 selectors, 68 models, 5 lasers and the speed tables; all 39/10/11/1/23 BG03 items match. Outputs are in `Assets/Resources/StageCombat/`, validation in `evidence/stage-combat/`. |
| Runtime | The Round 1 code is generalised, and BG03 still uses its own tables first. Round1Playback drives the original stage timeline. Round1EnemyWaves accepts any stage, takes its spawn cut-off from the scene and its slide range from the stage's BGSlideRange clips (BG03's derived windows reproduce the old constants). Health, target rules and hit shapes fall back to the new data. Original prefabs spawn with their stub behaviours stripped. Lasers are recognised by the laser bullet prefab, and muzzle colours come from each bullet's `_colorType`. The attack library points at the all-stage data and has 9 more bullet prefabs. The test autopilot sizes enemy-body hazards from real hit shapes. |
| Scenes | [ReconstructionStagePlay.cs](Reconstructed/Assets/Editor/ReconstructionStagePlay.cs) builds each scene from the Stage01 template: it swaps in the original stage prefab and rail camera, re-points the serialized camera references, sets the schedule and visuals, and applies BootTXE's RenderSettings. BG03 keeps its reconstructed boss. Other stages clear at their boss time, because their bosses are not reconstructed. |

Verification ([results](verification/stage-play/), GUI editor Play, Round 1 autopilot flying):

| Check | Result |
| --- | --- |
| All 8 stages, 45 s at normal speed ([log](verification/stage-play/play-all-1x-final.jsonl)) | Zero errors, zero lives lost, zero body contacts. Enemies fire in 7 of 8 stages (up to 384 projectiles; lasers in BG02 and BG03). The autopilot shot down 29-316 enemies in 7 stages and 0 in BG08, whose opening Mx02 have 15,000 HP against a fresh level-1 ship. BG01 fires nothing in its opening asteroid section. |
| BG05 played through to its clear point at 3x ([log](verification/stage-play/play-BG05-to-clear.jsonl)) | Reached 450 s and cleared: 878 spawned, 578 shot down, no lives lost, zero errors. |
| Round 1 regression (Codex play-twice harness) | PASS, 0 errors. |
| Stage presentation regression (BG03) | Unchanged: 1,122 spawned, 845 on screen, 130 never on screen. |

Not reconstructed yet:
- every boss except BG03's;
- ground-enemy combat outside BG03 (the other stages' ground schedules are not wired into combat);
- death and damage bullets (`_deadBullet`, `_damageBullet`);
- curved-bullet and fire-radius template fields;
- specialised native movers and their firing cadences (Mb01, Lc01, Mf01, Mg01, Mk01, Si01, Sq01, St01, X01-X03), which use straight-line fallbacks;
- per-stage music: the Round 1 sound player still plays its BG03 setup;
- pickup drops for other stages.

Nothing is compared against original-game footage.

Integrity: v8 ([manifest](evidence/stage-combat/freeze-manifest-v8.json), [diff from v7](evidence/stage-combat/freeze-diff-v7-v8.json)): 30 added, 23 changed, 0 removed. Backups of the changed Round 1 scripts, the attack library and the build settings are in `backups/before-stage-combat`. The editor segfaults natively when reopening the template scene in the same process, so scenes are built one per process. **D: has about 500 MB free; further Unity work needs space.**

## Follow-up 2026-11-01: every stage boss reconstructed from native code

Every stage now ends with its own boss fight instead of clearing at the boss time. Seven bosses were specified from the IL2CPP native code (one read-only spec per boss, every constant traced to an RVA; guides: [BOSS_SPEC_GUIDE.md](tools/bosses/BOSS_SPEC_GUIDE.md), [BOSS_IMPL_GUIDE.md](tools/bosses/BOSS_IMPL_GUIDE.md); specs, constants and annotated disassembly in `evidence/bosses/BosNN/`) and then implemented as subclasses of one shared boss layer.

| Stage | Boss | Implementation | Native behaviour reconstructed |
| --- | --- | --- | --- |
| BG01 | Ene_Bos01 | [Bos01Boss.cs](Reconstructed/Assets/Reconstruction/Bosses/Bos01Boss.cs) | Spring dive / laser sweep / home hover loop with no HP phases, 3 wing patterns, core rings, 8 shoulder-cannon parts |
| BG02 | Ene_Bos02 | [Bos02Boss.cs](Reconstructed/Assets/Reconstruction/Bosses/Bos02Boss.cs) | Front mode PT1-PT3 chasing the player's x, back-wing opening, 10-point patrol with three fire controllers |
| BG03 | Ene_Bos03 | Round1Boss.cs (earlier work) | unchanged |
| BG04 | Ene_Bos04 | [Bos04Boss.cs](Reconstructed/Assets/Reconstruction/Bosses/Bos04Boss.cs) | Closed form with bits and Sg01 fighters, open-wing form with figure-8 lasers |
| BG05 | Ene_Bos05 | [Bos05Boss.cs](Reconstructed/Assets/Reconstruction/Bosses/Bos05Boss.cs) | Shots / side laser / belly ring / arm regrowth, launched arms, staged leg breaks, half-HP interrupt |
| BG06 | Ene_Bos07 | [Bos07Boss.cs](Reconstructed/Assets/Reconstruction/Bosses/Bos07Boss.cs) | Leg ellipse and lunges, arm figure loop, part-down transitions, turret laser |
| BG07 | Ene_Bos06 | [Bos06Boss.cs](Reconstructed/Assets/Reconstruction/Bosses/Bos06Boss.cs) | Circle laps, cover break, side-body pinch, core circuit with battery lasers |
| BG08 | Ene_Bos08A/B/C | [Bos08Boss.cs](Reconstructed/Assets/Reconstruction/Bosses/Bos08Boss.cs) | Ground fortress (arms, covers, 180-degree turn), spinning top (dash, bow wave and circle), core (beams, homing, bow rings); the full A-B-C path of the Chria / unknown story actor |

Shared layer ([StageBoss.cs](Reconstructed/Assets/Reconstruction/StageBoss.cs), base [RoundBoss.cs](Reconstructed/Assets/Truxton/RoundBoss.cs) that Round1Boss now also implements):
- encounter frame from the original data: warning at the stage's `BGxx_BOSSST` area, spawn at the boss EnemyData time and position, the `BOSSLP` background section looped while the boss lives;
- parts from the prefab's PartsList collision models (`enemy-hitshapes.json` parts) with live hit circles that follow the animated part transforms; part targets take their EnemyDatabase part-row HP, lock-on and laser blocking;
- Ene_BosBase pieces: HP state from hpRateRanges, boss clock, entrance vulnerability windows, the shared 5.5 s destruction (sink 150 while turning, small bombs from 0.2 s shrinking x0.9 plus up to 0.1 s random, dead effect at 3.5 s);
- helpers for muzzle fire with the original bullet templates, summons (database HP, original prefabs), effects and the F3 jump to the boss.

Combat changes: boss body contact and the autopilot's boss hazards now use the live hit circles (a single outer-reach radius had been killing the ship far below Bos07). `touchesWhileInvulnerable` makes a part solid but undamageable (Bos06 pinch); database ground bosses (Bos08A) never touch the ship. Stub stripping removes dependent components first (`[RequireComponent]`, e.g. Bos01's EnemyGauge).

Verification ([results](verification/stage-play/play-bosses-native.jsonl): GUI editor Play at 3x, Round 1 autopilot, `STAGE_PLAY_BOSS=1` seeks to each boss warning):

| Stage | Result |
| --- | --- |
| BG01, BG02, BG04, BG05, BG06 | Boss defeated, stage cleared; 0 errors, 0 body contacts; BG05 and BG06 lost one life each to boss fire |
| BG07 | Boss defeated and stage cleared after 101 s of real time ([log](verification/stage-play/play-BG07-boss-long.jsonl)); 0 errors, no lives lost |
| BG08 | Forms A and B defeated, form C reached; the autopilot then lost its last life to C's fire (12,156 projectiles in the fight); 0 errors, 0 body contacts |
| BG03 | Round1Boss unchanged; Round 1 play-twice regression PASS, 0 errors |

All boss code compiles in Unity with no errors. Approximations and inferred values are listed in each boss file and its spec. The main ones:
- no camera shake;
- looping sounds play once;
- template rapid counts cannot be overridden per call (Bos04 PT1/PT5);
- Bos08A, which in the original stands 500 units below the sky plane, is held on the plane at perspective scale;
- entrance end times are taken as the 5 s entrance clip.

Nothing is checked against a recording of the original game yet. The specs list what a pioneer recording should confirm: entrance end, rest positions and yaw, aim sign conventions.

GUI-mode Unity runs are started by [unity_gui_run.sh](tools/common/unity_gui_run.sh). This session is the built-in Administrator account, so the GUI editor shows Unity's "running as administrator" dialog at startup. Unity has no switch to suppress it, and a `runas /trustlevel` standard-user launch cannot reach the elevated licensing client. At the user's request, [unity_admin_dialog_dismiss.ps1](tools/common/unity_admin_dialog_dismiss.ps1) presses "I wish to continue at my own risk" on that dialog: it finds the Win32 dialog by its title and sends BM_CLICK to that button, which UI Automation does not expose.

Integrity: v9 ([manifest](evidence/bosses/freeze-manifest-v9.json), [diff from v8](evidence/bosses/freeze-diff-v8-v9.json)): 19 added, 23 changed, 0 removed. Backups of the changed scripts are in `backups/before-stage-bosses` (taken mid-change) and `backups/before-stage-combat` (pre-boss originals of the Round 1 scripts). Disk: D: has 16 GB free; C: has 2.4 GB.

## Follow-up 2026-11-01: ground combat in every stage, and the editor crashes fixed

Ground enemies (each stage's `BGxx_ge` timeline: turrets, tanks, ships, fortresses, colour and item boxes) now fight in every stage, not only BG03.

| Part | What was done |
| --- | --- |
| Data | [build_ground_enemies.py](tools/stage_enemies/build_ground_enemies.py) turns each stage schedule's ground entries into `Resources/StageEnemies/Ground/BGxx.json` (BG02 58, BG04 139, BG05 256, BG06 238, BG07 324, BG08 4 clips). HP, score, lock-on, laser blocking and drops come from the decoded EnemyDatabase. On BG03 it reproduces the validated table: 147/147 clips, 13/13 definitions with 0 field differences, identical programs. 30 clip end times differ only because the schedule ends them with the BG03_ge timeline at 400 s, as the old table's own recording note says. [Validation](evidence/stage-enemies/ground-validation.json). |
| Animations | [ReconstructionGroundExport.cs](Reconstructed/Assets/Editor/ReconstructionGroundExport.cs) exports the Animator states (curves sampled at 60 Hz) and `EnemyTurret` settings of all 24 ground models, read through Unity serialization. BG03's three models match the old table: turrets identical, curves within 0.0035 degrees. |
| Native semantics | A read-only spec of the route-event stack ([SPEC.md](evidence/ground-route-events/SPEC.md), RVAs and a frame simulator) drove the interpreter changes in `Round1GroundEnemies`: ForwardMove (12; root +Z at the placement speed for dotime, queued behind a running move), Rotate (tweened over dotime, relative unless flag0, InOutSine when intValue1 is set), Idle, FinishDestroy, FinishWait, Set/ResetObjFlag 1 = no collision, named Loop labels, on-display start for attribute 512, and an EventStack enemy ending when its events run out. BG03's programs behave as before. |
| Runtime and scenes | `Round1GroundEnemies` takes scene-provided data, prefabs and animations (BG03 keeps its library), uses an on-screen-then-gone exit rule on rails that do not run straight along +Z, and counts ground enemies that come on screen. `Round1EnemyWaves` no longer spawns ground entries as invisible air enemies. The stage builder adds the ground layer to every stage with ground data. |

Verification ([log](verification/stage-play/play-ground-all.jsonl), GUI editor Play at 3x for 90 s of real time, about 230-270 s of stage time, autopilot): zero errors, zero body contacts and no lives lost in all 8 stages.

| Stage | Ground enemies spawned / came on screen / left wrecks |
| --- | --- |
| BG02 | 28 / 12 / 4 (ships at sea level, y -1610) |
| BG03 | 112 / 43 / 35 (unchanged rules) |
| BG04 | 36 / 19 / 0 (grass objects leave no wreck) |
| BG05 | 128 / 124 / 71 |
| BG06 | 222 / 194 / 42 |
| BG07 | 212 / 212 / 61 |
| BG08 | 2 / 2 / 0 (colour boxes; the fortress belongs to the boss) |

The Round 1 play-twice regression passes. Approximations, listed in the spec:
- object-flag and Delay `value0` delays apply at once instead of asynchronously;
- Translate and ForwardMove share one move slot;
- bullet timing stays in the attack scheduler.

### Editor crashes

The user reported Unity crashing. Every crash was in shutdown or scene unload, from two causes, both now fixed:
- **Batch builds:** `ReconstructionStagePlay.Remap` re-pointed every serialized reference to the old camera, including the old camera's own components' `m_GameObject` owner links. That left a corrupted scene in memory, which crashed natively (`GameObject::Deactivate` -> `ActivateAwakeRecursively`) when the scene was unloaded at exit. This was also the old "reopening the template crashes" note. Remap now skips ownership and prefab-link fields and the old camera's own components (4 remapped references became 1).
- **GUI play checks:** `EditorApplication.Exit` ran inside the play-mode-changed callback while the frame's geometry jobs were in flight (`DestroyGfxDevice` -> `CompleteFenceInternal`). Every script now exits through [ReconstructionExit.Quit](Reconstructed/Assets/Editor/ReconstructionExit.cs): leave play mode, destroy leftover hidden helper objects, unload into an empty scene, wait 15 editor frames, then exit.

After the fix, 8 stage builds, the full 8-stage play check and the Round 1 regression all exit with code 0 and no crash. One crash occurred in `Round1Combat.Initialize` -> `Instantiate` on the first Play straight after eight back-to-back rebuilds. It did not reproduce: the same stage alone and the full rerun were both clean. It is noted here. [crash_report.sh](tools/common/crash_report.sh), used by [unity_batch_run.sh](tools/common/unity_batch_run.sh) and [unity_gui_run.sh](tools/common/unity_gui_run.sh), checks every Unity run and prints "CRASH" with the native stack.

Integrity: v10 ([manifest](evidence/stage-enemies/freeze-manifest-v10.json), [diff from v9](evidence/stage-enemies/freeze-diff-v9-v10.json)): 23 added, 21 changed, 0 removed. Backups are in `backups/before-ground-combat` and `backups/before-exit-fix`.

## Follow-up 2026-11-01: item carriers in every stage

Every stage now has its original item carriers (the `Pf_Item_Box01` pickup drones), not only BG03. Ground boxes already dropped items everywhere through the ground layer.

- Data: [build_pickups.py](tools/stage_enemies/build_pickups.py) reads every EventEntryClip with `_eventType` 1 (EventEntryBehaviour._eventFire) on each stage's Main timeline and in the waves it places. Every stage opens with `tl_start_ppp` at 0 s (BG08 with `tl_start_p`); three of `tl_start_ppp`'s five carriers are muted clips, so only the two at ±120 fly. The reward is the first `_drops` entry (a local table) when there is one. Otherwise `_itemValue`: 1000 draws the shared ItemReferenceTable at run time, other values are item ids. Muted clips are skipped, and TLEntry times, time scales, offsets and game-mode masks (StoryA) are applied. On BG03 it reproduces the validated `round1-pickup-drones.json` exactly: 23 of 23 carriers ([validation](evidence/stage-enemies/pickups-validation.json)). Carriers per stage: BG01 26, BG02 29, BG04 59, BG05 32, BG06 19, BG07 42, BG08 72; the first pass missed them because the Main timelines and start waves are nested timelines.
- Runtime: `Round1PickupDrones` takes a scene-provided schedule (BG03 keeps its library), and the stage builder adds it to every other stage.

Verification ([log](verification/stage-play/play-pickups-all.jsonl), GUI Play at 3x, about 265 s of stage time, autopilot):

| Stage | Carriers flown | Items from carriers | Items from ground boxes | Ship level at the end |
| --- | --- | --- | --- | --- |
| BG01 | 19 | 19 | 0 | 4 |
| BG02 | 19 | 19 | 5 | 4 |
| BG03 | 11 | 11 | 8 | 3 |
| BG04 | 54 | 53 | 4 | 4 |
| BG05 | 14 | 14 | 16 | 4 |
| BG06 | 9 | 9 | 25 | 4 |
| BG07 | 20 | 20 | 12 | 4 |
| BG08 | 43 | 43 | 2 | 4 |

No crash in the 7 builds, the 8-stage play or the Round 1 regression (PASS), and zero errors. One body contact: BG03's Lb01 snake brushed the autopilot at 264 s, with no life lost. BG03's data and code were not changed in this step.

Not reconstructed: carrier depth and the native MoveTo easing (the BG03 adaptation is reused); which `_drops` entry a multi-entry local table gives, taken as the first, as BG03's validated table shows; the player-dependent extend substitution.

Integrity: v11 ([manifest](evidence/stage-enemies/freeze-manifest-v11.json), [diff from v10](evidence/stage-enemies/freeze-diff-v10-v11.json)): 17 added, 12 changed, 0 removed. Backups are in `backups/before-pickups`.

## Follow-up 2026-11-01: per-stage music

Every stage now plays its own original music instead of BG03's setup.

- Data: [build_music.py](tools/stage_enemies/build_music.py) reads each stage's BGMEntryClips. `_stageKind` selects the DefaultBGMPlaylist stage and `_sectionKind` is TXEKernel.PlaySection (1 OnTheWay1, 2 OnTheWay2, 3 Boss, 10 Epilogue). It writes the `stages` list of `Resources/Truxton/truxton-sound.json`. BG03's rebuilt entries are identical to the ones the sound skill recovered, and the rest of the file is unchanged ([validation](evidence/stage-enemies/music-validation.json)). The playlist already held every stage's tracks. Two details come from the data: BG06's boss window plays stage kind 5's boss section, and BG08 is silent until 40 s and has an Epilogue section at 503 s.
- Runtime: `Round1Sound` takes its stage from the scene's presented stage director (`BG05Stage` -> `bg05stage`) and keeps `bg03stage` for the Round 1 scene.

Verification (GUI Play at 3x, autopilot; music change logs in [road](verification/stage-play/play-music-road.jsonl) and [boss](verification/stage-play/play-music-boss.jsonl)): no crash, zero errors.

| Stage | Road 1 | Road 2 (from) | Boss (from) | After the boss |
| --- | --- | --- | --- | --- |
| BG01 | f045 | f040 (145 s) | b000 (360 s) | d000 result |
| BG02 | f042 | f041 (216 s) | b000 (430 s) | d000 result |
| BG03 | f000 | f004 (195 s) | b000 (418 s) | (fight still running) |
| BG04 | f008 | f036 (190 s) | b000 (420 s) | d000 result |
| BG05 | f012 | f014 (250 s) | b000 (448 s) | d000 result |
| BG06 | f006 | f003 (270 s) | b000 (425 s) | (fight still running) |
| BG07 | f002 | f044 (180 s) | b000 (395 s) | (fight still running) |
| BG08 | f038 (from 40 s) | f032 (240 s) | b000 (486 s) | f034 epilogue (503 s) |

Each road section ends with its 3 s fade and a 2 s gap, as the clips specify. Backups are in `backups/before-music`.

Integrity: v12 ([manifest](evidence/stage-enemies/freeze-manifest-v12.json), [diff from v11](evidence/stage-enemies/freeze-diff-v11-v12.json)): 3 changed (Round1Sound.cs, truxton-sound.json, the play harness).

## Follow-up 2026-11-01: death and damage bullets

Enemies now fire their original death bullets, the BG05 trees fire their damage volleys, and shootable enemy bullets split when shot down. The rules come from a read-only native spec ([SPEC.md](evidence/death-bullets/SPEC.md); `_callDeadEffect` 0x1D10E20, `DirectBulletFire` 0x1CE34C0, `Ene_bg05tree.AddDamageOwner` 0x1D85D20, `InGameDestuctible.SetCauseOfDeath` 0x1CCF930).

| Kind | Data | Rule as reconstructed |
| --- | --- | --- |
| Death bullets (10 models: Sg01, Mg01, Mi01, Mo01, BG04 grass direct; Sh01, Sj01, Su01, BSc01, BMa01 by selector) | [enemy_death_bullets.py](tools/stage_combat/enemy_death_bullets.py) -> `Resources/StageCombat/enemy-death-bullets.json`, every template and selector resolved | Only on a player-weapon kill: `Round1Combat` now records the cause of the lethal hit, and bombs and ship-body contact do not fire. Fired from `TransformPoint(_explosionOffset)` if that is within the game screen area (viewport -0.15..1.15), aimed only when the template's isTarget is set. Selectors use the Story rows (falling back to pmode 0): BSc01/BMa01 never, Sh01 50 %, Sj01/Su01 30 %, rolled once per enemy instance. |
| Damage volleys (Pf_BGObj_tree01b_upper) | `_damageBullet` bg05Tree, 8 ways, count 5, muzzle `pf_bg05_tree01b_upper/muzzle01` | A volley each time the damage taken passes HP·k/5 (k = 1..4), at most one per hit and never on the killing hit. 8 shots from a ring of radius U(5,35) around the muzzle, aimed at the player. |
| Shootable bullets (enemybullet011, 011s) | `_deadBullet` Regident/Sepper0_3way, Regident/Seppers_3way ("Regident" = the resident bullet palette) | A player shot crossing one downs it and fires its resident 3-way where it was. Not lock-on targets; bombs just clear them. |

Death bullets keep firing after their enemy is gone, from a detached shooter at a pooled stand-in muzzle.

Verification (GUI Play at 3x, about 250-270 s of stage time; [all stages](verification/stage-play/play-death-bullets-all.jsonl), [BG04 through its boss](verification/stage-play/play-death-bullets-BG04-full.jsonl), [shootable bullet test](verification/stage-play/play-resident-bullet-test.jsonl)): no crash, zero errors, Round 1 regression PASS.

| Stage | Death/damage volleys | Lives left (of 3, extends counted) |
| --- | --- | --- |
| BG02 | 56 | 1 |
| BG03 | 0 (Story mode: BSc01/BMa01 have no death bullet) | 4 |
| BG04 | 586 (749 through the boss, stage cleared) | 1 (4 in the full run) |
| BG05 | 184 (including the trees' volleys) | 2 |
| BG01, BG06, BG07, BG08 | 0 (no death-bullet enemies in the first 270 s) | 3-4 |

Shootable bullets: with three `enemybullet011s` parked ahead of the ship every 2 s (`STAGE_PLAY_RESIDENT_TEST=1`), player shots downed 96 and each fired its 3-way. In the stage data only Bos04's open-wing attack fires these bullets; Mg01's template is unused.

Approximations:
- the 0.5 s no-hit window of 011s's split bullets is applied to every shootable bullet;
- selector rolls are per enemy instance, not per pooled object at stage setup;
- the tree volley's explosion and shake are not drawn;
- Arcade-mode selector rows (pmode 2, 3, 11) need the real PlayMode, but the reconstruction plays Story.

Backups are in `backups/before-death-bullets`.

Integrity: v13 ([manifest](evidence/stage-combat/freeze-manifest-v13.json), [diff from v12](evidence/stage-combat/freeze-diff-v12-v13.json)): 2 added, 5 changed, 0 removed.

## Follow-up 2026-11-02: special enemy movers

Enemies outside BG03 now move as their native movers do, instead of by the generic "enter from the edge" or constant-speed route fallbacks. Three layers were reconstructed from read-only native specs, each checked in the editor by replaying the spec writer's Python frame model:

| Layer | Spec | Port | Check |
| --- | --- | --- | --- |
| EnemyMover event stack (attribute 16): homing, forward moves, turns, speed ramps, loops, task waits, the native end rules | [air-route-events/SPEC.md](evidence/air-route-events/SPEC.md) | `Round1EventStack` (60 Hz, same frame order and float32 counters as `air_sim.py`) | `ReconstructionEventStackCheck`: 8/8 programs, max position error 0.0005 ([check.json](verification/air-route-events/check.json)) |
| Class movers whose own code moves the enemy | [evidence/movers](evidence/movers) `Ene_<Class>/SPEC.md` | hooks in `Round1EventStack`, before or after the stack as natively | `ReconstructionClassMoverCheck` ([class-check.json](verification/movers/class-check.json)) |
| SplineMover route mode (attribute 0 with routes, and Mp02's prefab routes): each route eased by its own rate, events by route progress, removed at the last route's end | `Ene_Mp02/SPEC.md` §3, `Ene_Mx02/SPEC.md` §3 | `Round1EventStack.RouteStep` | same check |

Class movers ported:

| Class | Stages | Native behaviour |
| --- | --- | --- |
| St01 | BG01, BG07, BG08 | Waits for FinishWait, cruises to a waypoint beside the player (100 u/s, brakes inside 50), hovers nose-on, `st01_fire1` every 1.5 s, leaves straight away from the player after 8 s |
| Ss01 | BG06 | Closes from 300 to 50 units around the live player, two clockwise turns nose-on, flips and fires `shot06` once, backs out to 300; the 9 repeats overlap (not RookEnemy children) |
| So01 | BG01 | 60 u/s along its heading, brakes once on screen 0.35 s while turning to the player, charges 1 s, dashes to 240 u/s with NoHitBullet |
| Mg01 | BG04 | On its spline: every 3.5 s brakes to a stop, swings its nose to the player, one `mg01sp1_1way` volley, swings back |
| Mk01 | BG05 | Nine eased RouteLUT legs (b mirrored), 1 s stops, nose locked on the player, `mk01_fire1` along the muzzle every 2 s; back at its spawn point after 31.8 s |
| Mp01 | BG01 | `mp01_fire1` laser from muzzle01 toward mzzle01t 3 s of in-area time after entering, then every ~2 s; the battery yaws to the player |
| Sh01, Mn01c/c2 | BG04/08, BG01/06/08 | Cosmetic: the mesh spin `RotateSpeedTable[indexValue]`, the random-axis tumble |

Replay results (position error in source units, end frames Python/Unity):

| Sim | Max position error | Yaw error | End |
| --- | --- | --- | --- |
| St01 BG01 (index 1, index 0) | 0.0066, 0.0069 | 0 | 558/558, 588/588 |
| Ss01 BG06 | 0.0045 | 0 | 676/676 |
| So01 BG01 | 0.0105 | 0 | 239/239 |
| Mg01 BG04 | 0.0066 | 3.05 deg (model's tangent sampling) | 835/836 |
| Mk01 a, b | 0.079 (one 0.1-deg table step) | 0.04 | 1908/1908 |
| Mx02 BG08 (route mode) | 0.0001 | 0 | 289/289 |
| X01 BG01 (route mode) | 0.104 (one table step) | 0 | 985/985 |
| Mp02 a, b (route mode, prefab routes) | 0.016, 0.0001 | 0 | 701/701, 901/901 |

The two loosened tolerances are model-versus-native differences: `mg01_sim.py` takes the route tangent as a forward difference, and the Python models index the 0.1-degree cosine table in double precision where the native code (and the port) use float32.

Fixes found along the way:
- `JsonUtility` reads a JSON `true`/`false` as 0 in an `int` field. Every stage schedule stored `ActionData.flag0` as a boolean, so it was 0 everywhere (self-direction fire, absolute turns). [build_stage_enemies.py](tools/stage_enemies/build_stage_enemies.py) now writes integers; BG03 still reproduces its validated schedule 301/301.
- Route positions are relative to the route's first knot (`_splineStartPosition`): BG04's Mg01 routes start at x -+100 and were drawn 100 units off.
- Class-selected routes that are not in the stage timelines (Mp02's `common_D150` etc., Sq01, Mb01) come from the RouteLUT assets: `Resources/StageEnemies/class-routes.json`.

BG03 keeps the movers validated against recordings of the original (Round 1).

Verification (GUI Play at 3x, about 450 s of stage time per stage; [results](verification/stage-play/play-movers-route.jsonl), baseline before this work [play-movers-baseline.jsonl](verification/stage-play/play-movers-baseline.jsonl)):

| Stage | Spawned | Kills | Lives left (of 3, extends counted) | Boss | Never on screen (model=unseen/spawned), before -> after |
| --- | --- | --- | --- | --- | --- |
| BG01 | 1673 | 1606 | 3 | Cleared | Meteo_Sa01=68/828 Meteo_Ma01=11/144 Meteo_La01=8/72 -> Sl01=16/102 Meteo_Sa01=8/828 Meteo_Ma01=3/144 Meteo_La01=1/72 |
| BG02 | 448 | 454 | 2 | Fighting | Sa01=10/179 Sv01=5/42 -> Sa01=10/179 Sv01=6/42 Mo01=4/12 |
| BG03 | 1077 | 1118 | 4 | Fighting | Meteo_Sa02=5/722 Md01=1/15 -> Meteo_Sa02=6/722 Md01=1/15 |
| BG04 | 1926 | 1979 | 3 | Fighting | Sg01=11/113 -> Su01=17/348 Sg01=4/113 |
| BG05 | 827 | 1094 | 3 | Warning | none -> none |
| BG06 | 1093 | 1248 | 3 | Fighting | none -> Se01=3/608 (BG06 rerun after the Ss01 overlap fix) |
| BG07 | 497 | 731 | 3 | Fighting | Sc01=84/264 Sp01=6/30 -> none |
| BG08 | 267 | 317 | 2 | Waiting | none -> Sl01=1/24 |

No crash in any run, zero errors, no missing muzzles or class bullet templates, Round 1 regression PASS.

Enemies that leave without ever having their centre on screen: BG07's Sc01 went from 84 of 264 to 0. The remaining ones match the native model: BG02 Sv01 spawns at x -+196..236 fly off below the screen (Python model: never visible), and the Sl01 laser turrets are mounted on the side edges (centres at viewport x -0.05..0 and 1..1.05) for their native 5 s (checked with the new per-removal `unseenLog` of the play check). Su01 (BG04, 17 of 348) and Mo01 (BG02, 4 of 12) are not yet checked against the model.

Not ported yet (specs written, under evidence/movers): Mn01h and its shield bits, Mm01's paired halves and laser, Ml01 eating the Sj01 line-up (and Sj01's flight), Mj01h's stop-and-sink at its route end, Mc01's fire cycle, the Si01 swarm around Mk01, Sq01/Mb01's injected programs, the Lc01 ground tank, Mf01's bullet choice, X01's bullet patterns, and Sf01/Sr01 (stack and routes running together). Ss01's Forward sound 186 is not wired.

The first full run lost BG06's ship to three Ss01 body contacts: the remaster's air-separation nudge spread each spawn's 9 overlapping repeats into a cluster that reached the ship. The repeats of one Ss01 spawn now share a chain id, the exemption multi-part enemies already use; BG06 then had no contacts and reached its boss.

Backups are in `backups/before-movers` and `backups/before-class-movers`.

Integrity: v14 ([manifest](evidence/movers/freeze-manifest-v14.json), [diff from v13](evidence/movers/freeze-diff-v13-v14.json)): 8 added, 16 changed, 0 removed.

## Follow-up: arcade cabinet (2026-11-02)

Requested: "update this game as an arcade game"; scope chosen by the user: the original game's own ARCADE mode inside a coin-op cabinet loop.
`ArcadeBoot` (`Assets/Reconstruction/Arcade/ArcadeBoot.unity`) is now the first scene of the build; the Hub also has an Arcade button.

From the original data:

- Stage order: the BGMEntry `stageKind` of each BGxxStage timeline: 1 BG03, 2 BG05, 3 BG04, 4 BG06, 5 BG07, 6 BG02, 7 BG01, 8 BG08 (the ArcadePlayPresenter's `StageDatas` table has 8 entries; its addressable GUIDs were not decoded from the binary catalog).
- Schedule mode TLGameModeFlag Arcade1 (32): BG01 has 97 arcade-only events, BG03 8, BG05 5, BG07 24, all skipped by the Story scenes. Arcade bullet selectors and bullet area.
- Extends: `ExtendsArcade` (first at 5,000,000, then every 10,000,000, none past 1,000,000,000).
- Carried from stage to stage, as `ArcadePlayPresenter.CarriedData` does: score, ships, bombs, bomb level, power level, weapon, change stock, speed; round loop after stage 8 (`ArcadeStageInformation._isRoundLoop`).

Authored (the original is a console/PC game, so there is no original cabinet behaviour): coins and credits (1 coin 1 credit, max 9), 3 ships, continue in place with a 10 s countdown (fire speeds it up), round 2 then ending, top-10 table with 3 initials, attract loop (title 12 s, table 10 s, 40 s autopilot demo of stages 1-3), F2 operator menu with bookkeeping, F9 service credit. The extend table can be switched to 500K/1M or off in the operator menu, because the remaster lacks the original's score multiplier system (a stage scores about 50,000-110,000, so 5,000,000 is out of reach). The rank (`ArcadeAddPoints` Di point) system is not implemented; round 2 plays with round 1's rules.

Keys: 5 / pad View = coin, 1 / Enter / pad Menu = start, Space/Z / pad A = fire, X / pad B = back, F2 operator, F9 service. While the cabinet runs, the stage scenes' desktop keys (pause, Home restart, seek, F1, F3, F4) are off and the retry banner is replaced by the continue screen.

Data: `%USERPROFILE%/AppData/LocalLow/<company>/<product>/arcade/{settings,ledger,rankings}.json` (or `TRUXTON_ARCADE_DATA`), written to a temporary file and swapped in.

Code: `Arcade/ArcadeCore.cs` (rules, settings, ledger, rankings, storage), `Arcade/ArcadeMachine.cs` (cabinet), `Arcade/ArcadeArt.cs` + `Resources/Truxton/ArcadeArt.asset` (HUD glyph font, original title logo and backdrop, txe_bgm_o000, name-entry music), `Truxton/Round1WeaponArcade.cs` (carry, extend, continue). Small hooks in Round1StageEnd, Round1Playback, Round1Weapon, Round1Hud, Round1Autopilot, Round1Boss, StageBoss, Round1Intro. Round1Sound now picks the stage's music on every scene load (it outlives scenes, so a second stage kept the first one's sections). Builder `Editor/ReconstructionArcadeBuild.Run`.

Verification: `Editor/ReconstructionArcadeCheck.Run` (GUI editor) plays the whole loop through the cabinet's logical buttons: [arcade-check.json](verification/arcade/arcade-check.json), screenshots in `verification/arcade`. 17/17 checks pass, 0 errors, no crash: no start without credit, coin -> credit, stage 1 is BG03 in Arcade mode with arcade bullets, autopilot clears the BG03 boss, the ship flies off into BG05 with score and power carried, game over -> continue refused without credit, coin + start continues in place, countdown runs out -> initials "CAT" ranked 3rd and saved, title -> table -> demo, operator menu turns free play on and saves it, free-play start, ledger on disk. The first run found two bugs, both fixed: the public `session` field was created by Unity's serializer (the cabinet thought a game was on at boot), and a ledger save collided with a file lock when two saves fell in one frame (saves now retry). Not exercised: a full 8-stage run, the round loop and ending, extends, a pad, and a Windows player build.

Backup: `backups/before-arcade`.

### Arcade machine settings: service mode (2026-11-02)

Requested: "i need arcade game machine settings". The single F2 list became a coin-op style service mode (`Arcade/ArcadeService.cs`, partial of ArcadeMachine). F2 is the test switch: it opens the service menu from any screen and, as on a cabinet, ends a game in progress. Up/down select, left/right change, fire/start set or enter, back or F2 return; resets ask twice ("PRESS AGAIN"). Settings save when a page is left.

| Page | Settings |
| --- | --- |
| Game | difficulty EASY (the original Story A schedule and bullet rules) / NORMAL (ARCADE), ships 1-5, extend (original 5M/10M, 500K/1M, off), continue on/off, continue time 5-30 s, round loop, start stage 1-8, demo time 10-120 s |
| Coin | free play, coin A and coin B coinage (1C1C ... 1C6C, 2C1C, 2C3C, 3C1C, 3C2C, 4C1C, 5C1C, 6C1C), max credits 1-99, clear credits |
| Sound | master, music and effects volume 0-10 (listener, cabinet music, Round1Sound BGM/SE), demo sound, attract music, sound test (title music, name-entry music, coin, start, extend, explosion, power up) |
| Display | screen mode (full-screen window, exclusive, window), resolution (monitor, 720p-2160p), vsync, frame limit (none/60/120/144), credit display. Applied in the built player; the editor only takes the frame limit. |
| Input test | every cabinet button live with its keys (coin A 5/pad View, coin B 6, service F9, test F2, start 1/Enter/pad Menu, fire Space/Z/pad A, bomb/back X/pad B, directions), pad names; coins are not counted here; leave with F2 or hold START 2 s |
| Screen test | colour bars with grey scale, crosshatch with centre dot, white, red, green, blue, black |
| Bookkeeping | coin A, coin B, service credits, credits in machine, games, continues, extends, all clears, play time, average game; reset counters |
| Menu | also clear rankings, factory settings, exit, exit to workspace |

Old settings files still load (chute A keeps the `coinsPerCredit` field). Coin B is a new key (6).

Verification: ReconstructionArcadeCheck now also walks every page through the cabinet buttons: 37/37 checks, 0 errors, no crash ([arcade-check.json](verification/arcade/arcade-check.json), screenshots 13-23). It sets coin A 1C2C and coin B 2C1C and inserts coins (A +2, B needs two), EASY from stage 2 (BG05 loads with Story mask 2 and Story selectors), master volume 5 (listener 0.5), the sound test, frame limit 120, the input test (shows FIRE, does not count a coin), screen patterns, bookkeeping, the test switch ending a game, and factory settings needing a second press. The check's presses now wait for game frames (the cabinet's 60 fps limit made the editor tick faster than the game). Not exercised: display mode/resolution/vsync (player build only) and a real pad.

## Project layout (2026-11-02)

Requested: "make this project layout as a default unity game project layout"; scope chosen by the user: the remaster's own content sorted by type, the extracted original game library kept whole. Moved inside Unity (`Scripts/Editor/ReconstructionLayout.Run`, AssetDatabase.MoveAsset), so every GUID and reference is kept and nothing reimported: 40 moves, 13,189 assets, 0 errors. `ReconstructionLayout.Undo` replays [moves.json](verification/layout/moves.json) backwards. Paths in this report above this section are the old ones; map them with this table.

| Old | New |
| --- | --- |
| `Assets/OriginalRecovered` | `Assets/OriginalGame` (inside unchanged) |
| `Assets/Reconstruction/Hub.unity`, `Arcade/ArcadeBoot.unity` | `Assets/Scenes/` |
| `Assets/Reconstruction/StagePlay`, `StageInspection` | `Assets/Scenes/StagePlay`, `Assets/Scenes/StageInspection` |
| `Assets/TruxtonImported/Scenes` (Round1, Stage01, ExtractionPreview) | `Assets/Scenes/Round1` |
| `Assets/Truxton` (Round1* gameplay code) | `Assets/Scripts/Runtime/Gameplay` (Round1Terrain.shader -> `Assets/Shaders`) |
| `Assets/Reconstruction/Arcade`, `Bosses`, `Stage*.cs` | `Assets/Scripts/Runtime/Arcade`, `Scripts/Runtime/Stage/Bosses`, `Scripts/Runtime/Stage` |
| `Assets/ReconstructionHub.cs`, `DebugUIHandlerRenderingLayerField.cs` | `Assets/Scripts/Runtime/`, `Scripts/Runtime/Compatibility/` |
| `Assets/Editor` | `Assets/Scripts/Editor` |
| `Assets/Reconstruction/Shaders` (incl. Recovered) | `Assets/Shaders` |
| `Assets/TruxtonImported/Textures`, `TruxtonGameplay/UI`, `Reconstruction/ComicBlank.png` | `Assets/Textures`, `Assets/Textures/UI` |
| `Assets/TruxtonImported/Materials`, `Prefabs`, `Meshes`, `Animations` | `Assets/Materials`, `Assets/Prefabs`, `Assets/Models`, `Assets/Animations` |
| `Assets/TruxtonGameplay` materials, prefabs, animations, json | `Assets/Materials/Gameplay`, `Assets/Prefabs/Gameplay`, `Assets/Animations/Gameplay`, `Assets/Data` |
| `Assets/TruxtonImported/Settings`, URP global settings, DefaultVolumeProfile | `Assets/Settings` |
| `Assets/Resources`, `StreamingAssets`, `Plugins`, `AddressableAssetsData` | unchanged (Unity needs them there; game audio stays in `Resources/TruxtonAudio` because it loads at runtime) |

Old paths were rewritten by `tools/layout/rewrite_paths.py` (450 replacements in 122 files: editor scripts, the 79 recovered shaders' absolute `#include`s inside OriginalGame, tools, the Truxton skills), plus bare `OriginalRecovered` names in 12 files and two code spots (StagePlay builder's prefab preference now `Assets/Prefabs/`, Hub builder folder). Changed files were copied to `backups/before-layout` first. Two Truxton skills still mention `Assets/TruxtonImported` for the deleted TruxtonRemaster project's import routine; left as is.

Verification: compile clean; arcade builder; [shader recovery check](verification/shader-recovery/compile-check.json) 79/79 shaders, 322 materials, 0 failures (as before); arcade play check 37/37, 0 errors, no crash, in 2 of 3 runs. The first run failed at the attract demo (the demo ended within 6 s and the service menu then closed at once); the same check passed twice after adding diagnostics, so the cause was not found. Hit-flash check 10/12: the two small meteors (Pf_EneObj_Meteo_Sa01/Sa02) render with a yellow additive glow (mt_eff_common01, ParticleAdd) and their "restored" frame differs from the plain one by 1.5% and 4.9%; on the 12:24 baseline they were 0. The move changed no prefab, material or shader content (shader text differs only in include paths, checked against the backups), but gameplay scripts such as Round1Effects.cs were also changed after that baseline, so the cause is open.

Follow-up (same day): the first rewrite scanned only code and shaders inside Assets. A survey with the new `unity-project-layout` skill found 179 old paths left in data files: `Resources/StageCombat/enemy-hitshapes.json` (97), `Resources/StageEnemies/ground-animations.json` (24), `class-routes.json` (1), and the two SceneDedup manifests (`Prefabs/Dedup/BG03` 37, `OriginalGame/.../Stage/Dedup/Shared` 20). SceneDedup reuses a manifest entry only if `File.Exists(entry.prefab)`, so a rerun would have made new prefabs instead of reusing the existing ones. Rewritten from moves.json (backups in `backups/before-layout-data`); all five files are valid JSON and all 178 asset paths in them exist. The only old paths left in the project are in `Scripts/Editor/ReconstructionLayout.cs`, on purpose (undo map). Not re-run in Unity (the editor was open); the JSON path fields are provenance for the runtime, so play is unaffected.

### Prefabs sorted by kind (2026-11-02)

Requested: "Organise", using the new `unity-prefab-organizer` skill. Work files in [verification/prefabs](verification/prefabs): survey `prefabs.json`, rules `rules.json` (the skill's defaults plus one rule: `pf_eff_`/`sp_eff_` names are effects, so the enemy laser charge and muzzle glows are not filed as projectiles), review table `prefab-plan.md`, plan, manifest `moves.json`.

| Folder | Prefabs |
| --- | --- |
| `Assets/Prefabs/Effects` | 38 (explosions, hit sparks, muzzles, laser energy, BombBurst, burner, `pf_Point Light_explosion`) |
| `Assets/Prefabs/Pickups` | 34 (`pf_item0*`, `Pf_item_*`, item boxes) |
| `Assets/Prefabs/Enemies` | 20 (`Pf_Ene_*`, meteors, burnt ground) |
| `Assets/Prefabs/Projectiles` | 9 (`enemybullet00*`, `enemylaser000`, PlayerBullet, EnemyBullet) |
| `Assets/Prefabs/Environment` | 3 (`BG03`, `Pf_BGObj_ColorBox*`) |
| `Assets/Prefabs/Player` | 1 (`player01`) |
| `Assets/Prefabs/Dedup/BG03` | 37, kept: SceneDedup's output, tracked by its `dedup-manifest.json` |

105 moves inside Unity (LayoutMover, AssetDatabase.MoveAsset; GUIDs kept), `Prefabs/Gameplay` removed when empty, 0 errors. No prefab was renamed: 78 of the 142 are looked up by name in code or data (enemy and model tables use the original names). Unity's asset database remembered an old lowercase `player` folder and created `Player` with that spelling; fixed with a rename through a temporary name, and the mover now does this itself. Path strings: one in `ReconstructionHitFlashCheck.cs`, one joined path in `tools/stage_enemies/share_meteor_visuals.py` (by hand); backups in `verification/prefabs/backup`. The skill's tools stay in `Assets/Scripts/Editor/PrefabTools` (PrefabCheck, LayoutMover) for re-checks and undo.

Verification: PrefabCheck before/after over all 2,341 prefabs and 23 scenes: 105 moved, 0 problems (variant bases, nested prefabs, missing scripts, 8,668 scene instances all unchanged); compile clean; hit-flash check 12/12 before and after (the Sa01/Sa02 10/12 after the layout change did not recur, so that was not caused by the move); arcade play check 37/37, 0 errors; no Unity crash in any run. Survey notes: no variants, no missing scripts; 2 prefabs unused by any scene or prefab (`enemylaser000`, `sp_eff_pshot_10`), both still named in data tables, so kept.

Undo: copy `verification/prefabs/backup` over the project (both files), then `LayoutMover.Undo` with `LAYOUT_MANIFEST=verification/prefabs/moves.json`.
