# Unity 2023 reconstruction

The user project is `C:\Users\Administrator\Documents\TruxtonRemaster`. The isolated staging project is `D:\games\Truxton Extreme\extractor\UnityProject`. The installed editor is `C:\Program Files\Unity 2023.2.22f1\Editor\Unity.exe`. Read current project versions and tool entry points before running; do not reinstall Unity 6 as a remedy for source-format differences.

Use portable manifests to reconstruct native Unity 2023 assets. Do not copy Unity 6 serialized files over the destination project or merely rewrite its version string. Existing importer entry points are `TruxtonImporter.ImportBatch`, `ImportWeaponAssetsBatch`, and `RenderRound1Batch`; input is `-truxtonInput <export-directory>`. `ImportBatch` may rewrite generated scenes. The assets-only weapon entry point preserves the scene but writes `weapon-import-validation.json` for any selected content: preserve the actual weapon report and retain the new report under a descriptive name.

Original runtime type trees omit serializedVersion fields. `unity2023-native-versions.json` supplies templates captured from native destination components, including nested particle curves. Incorrect versions can trigger legacy migrations and distort particles. Preserve external reference remapping, particle renderer materials/meshes, and missing-reference warnings.

Preserve source local transforms, sibling order, active states, layers and material slots. Retain established Unity `.meta` GUIDs and generated asset paths; modify reusable assets in place. Source shaders such as `TATSUJIN/TXE_Lit`, custom laser shaders, stage Shader Graphs and particle shaders require deliberate mappings and visual checks. URP approximations are not equivalent to original rendering.

Launch Unity batch processes hidden with `Start-Process -WindowStyle Hidden`. Use only the isolated staging project; do not close the user's editor. Wait for the batch process to exit before editing staging scripts or launching another process. A play-mode harness that calls `EditorApplication.Exit` must not use `-quit`; rendered validation must not use `-nographics`.

Choose checks proportional to the requested change. Existing Python geometry/curve tests are `extractor/test_export.py` and `test_round1.py`. Editor harnesses include `Round1FeatureCheck`, `Round1BossCheck`, `Round1SpawnCheck`, `Round1IntroCheck`, `Round1MotionCheck`, `Round1Md01Check`, `Round1AttackCheck`, and, since 2026-10-28, `Round1GroundItemCheck`, `Round1MeteorCheck`, `Round1HitShapeCheck` and `Round1OverlapCheck` (the truxton-unity-checker skill says what each asserts); inspect current methods and chaining before running. Confirm fresh passing reports and an error-free compilation, and inspect relevant rendered output. A passing structural report alone does not establish visual fidelity.

Install only the validated task files into the user's project, and only when the user asks for that install; approval of an earlier install does not cover the next one. The user's editor is usually open on it, so never run batch jobs there. The routine that has worked:

1. List what differs between staging and the user project for the touched areas (`Assets/Truxton`, `Assets/Editor`, `Assets/Resources/Truxton`, plus the specific imported assets). Leave out staging-only tools (probes, builders that read staging folders such as `Round1PickupDroneBuilder`).
2. Prove the user hasn't edited what you will replace: compare each file with `extractor/user-clone` (the copy of the user project kept in step with every install) or with the pre-change staging copy.
3. For added assets, check that their `.meta` GUIDs don't already exist in the user project.
4. Back up the replaced files and write `added-files.txt` under `Documents/TruxtonRemaster-backups/<topic>-<yyyymmdd>/`.
5. Copy the same files into the user project and into `extractor/user-clone`, and compare the hashes.
6. Run the builders and checks in `user-clone` (it has the user's scene and settings, which staging doesn't). Keep their logs in the backup folder. A check can pass in staging and fail there: player-dependent enemies such as Sa01 move differently.

The open editor recompiles when the user switches back to it. Preserve destination-only edits and established GUID differences. Do not copy the entire staging Assets directory simply because assets differ.

`ImportWeaponAssetsBatch` re-imports every asset in the export's closure, so shared meshes, materials and textures that other prefabs use get rewritten. Before importing a new selection into staging, copy `Assets/TruxtonImported` aside. After the import, restore every pre-existing file that changed, keep only the new files, and record the list (see the 2026-10-28 ground-item import: 18 shared assets restored, 36 new files kept).

Lessons from the 2026-10-29/30 effect imports:
- `export_selection.py --prefab <name>` fails with "expected one root, found 2" when a name exists twice (most effects exist under both `Assets/Samples/Prefabs/Reference/Effect/VFX/Prefabs/...` and `Assets/TXE_GraphicData/Effect/Prefabs/`). Pass the full container path. The in-game explosion set (`pf_eff_explposion01..05`, `_boss`, `_p`) is the Samples `Explosions` folder.
- A runtime effect is only found by name if `Round1MeteorEffectCheck.Effects` lists it: `Build()` writes `Resources/Truxton/EffectLibrary.asset` from that list. Rebuild it (any check that calls `Build()`) after adding a prefab, and install the asset with the change.
- URP re-derives `_SrcBlend`/`_DstBlend` from `_Blend` (0 alpha, 2 additive) when a material asset is validated, so write `_Blend` together with them. URP has no One/OneMinusSrcColor (the original `sp_eff_pshot_*` blend); additive is the closest.
- `Round1HudBuilder.RenderPreview` composites the scene render texture by its alpha, so additive effects and lasers show as black boxes in previews. Render effect checks from the camera straight to a texture (see `Round1ShotEffectCheck.Render`).
- A `MaterialPropertyBlock` created in a MonoBehaviour field initializer is null at runtime; create it lazily.
- `Round1Arms` follows the native `TXEKernel.ArmsKind` order: Red normalShot, Green tatsujinBeam, Blue thunderLaser, Gold goldLaser, Silver homingShot, Purple starmineShot (Grow), Black blackLaser. Tables indexed by it (tints, ship skins, shot frames) follow that order.

Materials on `Shader Graphs/sg_emission_flicker_fogswitch` (the item boxes `mt_item_box01`/`mt_item_box02`) keep their maps in `_Tx_Albedo`, `_Tx_Normal`, `_Tx_Metsllic` and `_Tx_Emission`. The URP fallback has no such slots, so they import plain white. `Assets/Editor/TruxtonFlickerMaterial.ToLit(material, albedo, normal, metallic, emission)` rebuilds one as URP Lit with its maps. Look the texture ids up in the export manifest and call it from the builder that owns the asset. Other `_Tx_*` shader graphs need the same treatment: scan manifests for `_Tx_` texture properties after each export.

Known semantic traps: Round 1 is BG03 (`_stageOrder == 1`); BG01 is Round 7. Source boss warning/entry are 418/420 seconds on BG03. Existing combat, enemy AI, health tuning and camera-plane adaptation include remaster code, even where source visual assets and timings are used. Do not describe those systems as extracted original gameplay.

Enemy hit shapes come from the original, not from guesses. `extractor/extract_enemy_colliders.py` resolves each prefab's `PawnEnemy._collisions` (EnemyCollisionModel):
- Shape enum: 1 Circle, 2 Box, 3 Polygon, 4 Edge, 5 Capsule, 6 CircleNR, 7 BoxNR.
- Circle radius is `points[0].x`; Box and Capsule `points` are half-sizes (`CreateCollisionObject` 0x181ddde70 sets size = 2·points). A capsule is vertical when y > x.
- Sizes in source units: an air enemy's point is one unit at the stage plane (`HybridCollisions.UpdateCollisions` scales by `_scaleFactorZ`, measured at the origin, so radii don't grow with height). A `_isSimpleCalc` enemy (meteors, Se01) uses a fixed 7 px per point, which is 0.914 units at the 1080p reference. A ground enemy's point is one world unit at its own depth.
- It writes `Assets/Resources/Truxton/round1-enemy-hitshapes.json`, with capsules and boxes covered by rows of circles; `Round1HitShapes` loads it.
- The original screen is 2·400·tan 10° = 141.06 units tall at y = 0 (camera at 400, 20° FOV, `Round1Sa01Motion.ViewHeight`). Most wave enemies are still placed in an older 200-unit frame (`sourceHeight`), so scale radii by the frame each model is drawn in.
