---
name: truxton-recon-project
description: "Since 2026-11-01 the only Truxton project is Codex's D:\\games\\TruxtonExRecon\\Reconstructed; old extractor/ and Documents\\TruxtonRemaster were deleted on purpose"
metadata:
  node_type: memory
  type: project
  originSessionId: 2b8ca490-dda9-4211-a370-09a54cc12c16
  modified: 2026-11-02T22:15:44.466Z
---

On 2026-10-31 Codex ran its `unity-project-reconstruction` coordinator suite (~/.codex/skills: unity-reconstruction-extraction,
-code, -scenes, -migration, -verification) and produced `D:\games\TruxtonExRecon\Reconstructed` (Unity 2023.2.22f1):
all 2,150 original prefabs, Boot/BootTXE scenes, 8 derived StageInspection scenes, 91 recovered simple native methods,
plus the old Round1/Stage01 remaster code (Assets/Truxton, snapshot of the user project on Oct 31). Reports:
TruxtonExRecon/RECONSTRUCTION_REPORT.md and ENGINE_SYSTEMS.md. Comic content is excluded by the user (one blank image).

The user then deleted `D:\games\Truxton Extreme\extractor` (staging project, Frida autoplayer, recordings, manager ledger,
Round1*Check harnesses, unfinished Stage02/BG05 Sf01/So01/Mm01 work), `Documents\TruxtonRemaster`, and the standalone
Build folder, on purpose, with no backup (confirmed 2026-11-01). The game folder is pristine (275 files, no git).
Disk: see the latest note at the end.

**Why:** the user wants the Codex reconstruction to be the one project going forward.
**How to apply:** paths in truxton-remaster-manager / pioneer / checker skills point at deleted folders; work in
TruxtonExRecon instead and don't look for extractor/. Related: [[truxton-remaster-manager]], [[unity-game-to-project-skill]].

Done 2026-11-01 (user picked "stage presentation"): StageInspection_BG01-08 now play the original BGxxStage timelines via
Assets/Reconstruction/StagePresentation.cs (ticks the Manual-mode root director, disables child directors with InGame.Kernel
custom tracks, whose ctors/clipCaps are throw-null stubs). Hub has BG01-BG08 buttons. Non-obvious root cause: player-format
`exposedName: {id: N}` loads as id 0 in the 2023 editor; fixed by tools/repair_exposed_names.py (60 refs, 20 .playable).
Checks: Editor/ReconstructionStagePresentation.Verify (batch) and ReconstructionStagePresentationPlay.Run (GUI editor;
Unity segfaults on exit after writing results, harmless). Write report: RECONSTRUCTION_REPORT.md follow-up, revision v5.
Also done 2026-11-01 ("Recover the shaders"): all 43 custom shaders recovered from DXBC (tools/shader_recovery: dump_shaders.py,
build_shaders.py + specs.json/specs.d, GUIDE.md for translators; bodies in Assets/Reconstruction/Shaders/Recovered, shared
TruxtonRecoveredSG.hlsl), written over the dummy stubs (GUIDs kept). 180 TXE_Lit materials restored from URP Lit; stage scenes use
BootTXE skybox; Round1URP opaque+depth textures on; _Tx_SpeedRate set to 1. Check: Editor/ReconstructionShaderRecoveryCheck.Run.
Project is Gamma colour space (matches original). Revision v6.
Also done 2026-11-01 ("enemy code"): stage enemy schedules. Editor/ReconstructionStageEnemyExport -> extraction/stage-enemies/raw-stage-timelines.json
-> tools/stage_enemies/build_stage_enemies.py -> Resources/StageEnemies/BGxx.json (Round1 schema; BG03 reproduces the old validated
round1-enemy-waves.json 301/301). Runtime Assets/Reconstruction/StageEnemies.cs: native game camera overlay (0,400,0, FOV 20) on the
rail camera, game layer at y=-50000, reuses Round1 movers, strips stub MonoBehaviours from original prefabs. Non-obvious: nested TLEntry
in waves, EnemyWaveClip _enemyDataName = wipe-out bonus spawn, muted tracks, durationTime 0 = unlimited, pow(0,0) NaN + HDR post blacks
frames, run captures one Unity process per stage (STAGE_ENEMIES_ONLY). Revision v7.
Also done 2026-11-01 ("add combat"): playable Assets/Reconstruction/StagePlay/StagePlay_BG01-08.unity (Hub "Play n"), built by
Editor/ReconstructionStagePlay.Build from the Stage01 template (one stage per process: STAGE_PLAY_ONLY; reopening the template
crashes Unity natively). Round1 code generalised (Round1Playback drives StagePresentation, Round1EnemyWaves any stage + data slides +
spawnCutoff, Round1Combat bg03Schedules/clearAt + stub-stripping InstantiateClean, fallbacks to Resources/StageCombat/*.json:
enemy-database (decoded EnemyDatabase: key^0x3C, hp bits^0x00CF7A89, score^0x00136ACF), enemy-hitshapes, enemy-attacks; all match
the BG03 tables). Check: Editor/ReconstructionStagePlayCheck.Run (GUI editor, STAGE_PLAY_SPEED/SECONDS). (ground combat outside BG03 added later, see below);
specialised native movers still approximate.
Also done 2026-11-01 ("go ahead", bosses): every stage boss from native code. Specs evidence/bosses/BosNN/SPEC.md (tools/bosses/
BOSS_SPEC_GUIDE.md), shared Assets/Reconstruction/StageBoss.cs (RoundBoss base; live per-part hit circles, Ene_BosBase destruction,
summons) + Bosses/BosNNBoss.cs subclasses (BOSS_IMPL_GUIDE.md; builder picks class by name; BG08 plays A->B->C). STAGE_PLAY_BOSS=1 / F3
jumps to the boss. All 7 defeated by autopilot except BG08 form C. Revision v9 (evidence/bosses).
The user is on the built-in Administrator account: GUI Unity shows a "running as administrator" dialog the user asked me to skip;
run GUI editors via tools/common/unity_gui_run.sh (Win32 BM_CLICK watcher presses continue - UIAutomation cannot see the buttons; runas /trustlevel breaks licensing).
Also done 2026-11-01 ("Ground combat"): every stage's BGxx_ge ground enemies fight (tools/stage_enemies/build_ground_enemies.py ->
Resources/StageEnemies/Ground/BGxx.json, Editor/ReconstructionGroundExport.cs -> ground-animations.json, native route-event semantics in
evidence/ground-route-events/SPEC.md applied in Round1GroundEnemies). Editor exit crashes fixed (Remap skipped ownership fields;
Editor/ReconstructionExit.Quit). Revision v10. Also done 2026-11-01 ("Pickups outside BG03"): item carriers in every stage (tools/stage_enemies/build_pickups.py ->
Resources/StageEnemies/Pickups/BGxx.json; BG03 23/23 vs validated table; Main timelines and tl_start_ppp are nested waves,
muted clips skipped). Revision v11.
Also done 2026-11-01 ("Per-stage music"): tools/stage_enemies/build_music.py writes every stage's BGMEntry windows into
truxton-sound.json stages (BG03 identical); Round1Sound picks the stage from the presented stage director. Revision v12.
Also done 2026-11-01 ("Death/damage bullets"): evidence/death-bullets/SPEC.md rules; enemy-death-bullets.json; Round1Combat
DamageCause (only player-weapon kills fire), detached death shooters, shootable enemybullet011/011s, BG05 tree volleys. Revision v13.
Also done 2026-11-02 ("Special enemy movers"): Assets/Truxton/Round1EventStack.cs = native air event stack (port of
evidence/air-route-events/tools/air_sim.py) + class movers St01/Ss01/So01/Mg01/Mk01/Mp01 + SplineMover route mode
(attribute&16 == 0 with routes, or Mp02's prefab routes from Resources/StageEnemies/class-routes.json); Sh01/Mn01c node spins in
Round1EnemyWaves.ClassNodes. Specs evidence/movers/Ene_*/SPEC.md. Checks: Editor/ReconstructionEventStackCheck (8 sims) and
ReconstructionClassMoverCheck (11 sims) replay the Python tracks. BG03 excluded (keeps recording-validated movers).
Non-obvious: JsonUtility reads JSON true/false as 0 in int fields (flag0 was 0 in every schedule; builder now writes ints).
Not ported yet: Mn01h shield bits, Mm01 halves, Ml01 eating Sj01, Mj01h stop-and-sink, Mc01 fire cycle, Si01 swarm, Sq01/Mb01
injected programs, Lc01 ground tank, Sf01/Sr01 (stack + routes together). Revision v14.
2026-11-02 (in progress, not yet written into RECONSTRUCTION_REPORT/freeze manifest v15): the remaining movers are ported -
Round1EventStackGroups.cs (Si01 swarm, Mn01h + Mn01c bits, Mm01 halves + laser bridge, Ml01/Sj01, Mc01, Sq01/Mb01 programs),
Sf01/Sr01 stack+route mode (StackRoute, child Rotate -> ChildYaw), Lc01 drive in Round1GroundEnemies (death/covers not ported).
Route junctions now restart at rate 0 (updateRouteData(0)); m7_sim.py + mc01_sim.py fixed, Mp02/X01 tracks regenerated.
Checks: ClassMoverCheck 16/16, new Editor/ReconstructionGroupMoverCheck 7/7, EventStackCheck 8/8 (ease-7 tolerance 0.12).
Play: all stages 0 errors; BG05 had an Mm01 nodes bug + spawn-on-player contact (fixed, survives 450 s) but spawns 461 vs 827 in
v14 - unexplained, under investigation. StagePlay scenes had NO AudioListener (silent); Round1Sound now adds a fallback one.
Batch/GUI runs exit at once if the user has the project open in Unity. Backups: backups/before-group-movers.
2026-11-02 ("no effects for enemy destructions", BG01): Round1Effects.DeadExplosions only listed BG03 models, so other stages'
kills had no blast. tools/stage_enemies/build_dead_explosions.py reads PawnEnemy._deadExplosion/_explosionOffset from all
OriginalRecovered prefabs -> Resources/StageCombat/enemy-dead-explosions.json (101 models; BG03 hand table 20/20 identical);
Round1Effects falls back to it, spawns effects stub-stripped; EffectLibrary got pf_eff_explposion06 (X01-X03; no sound palette).
Mm01/Lc01/BG08 zones have empty _deadExplosion. Compiled standalone with Unity's csc (editor was open); user to test in play.
Backups: backups/before-dead-explosions. Music in StagePlay_BG01 confirmed audible by the user.
2026-11-02 ("make duplications prefabs", then "meteor prefabs shared"): all 8 BGxxStage.prefab deduped v2 with SceneDedup
library mode (-dedupLibrary TXE_GraphicData: copies become instances of the game's own prefabs via ConvertToPrefabInstance,
values restored as overrides; rest in Stage/Dedup/Shared): 65.1 -> 9.6 MB, digest + frames identical (evidence/scene-dedup/
SUMMARY.md, tools/scene_dedup/run_stage.sh). Non-obvious: ConvertToPrefabInstance drops GameObject fields (layer 30), null
refs (Animator controllers) and can mis-pair children - SceneDedup re-copies all values from a duplicate; saving a new prefab
then re-saving crashed Unity (WriteCachedMetaData). Enemy meteors OriginalRecovered/Pf_EneObj_Meteo_* nest pf_ene_obj_meteo_*;
StagePlay_BG03 meteors switched from TruxtonImported to them (tools/stage_enemies/share_meteor_visuals.py).
Hit flash for all (2026-11-02): Round1Effects blinks every model with a TXE_Lit material (Resources/StageCombat/
enemy-blink-models.json from build_blink_models.py, 386), drives _FadeColor (flash peak FadeFlashStrength .75), StageBoss
parts via effects.bossRenderers. Check Editor/ReconstructionHitFlashCheck (12/12); play BG01/BG03/BG01 boss 0 errors.
Death explosions for all: enemy-dead-explosions.json (build_dead_explosions.py). Backups in TruxtonExRecon/Backups.
2026-11-02 ("win/fail banner, any button flies away"): Assets/Truxton/Round1StageEnd.cs (auto-added to Round1Weapon): SUCCEEDED
(+"STAGE CLEAR" glyphs) / GAME OVER logo + FAILED (Resources/Truxton/StageEndArt.asset, original sprites), any button -> ship
flies off (player.SetBoost = entrance burner/boost, speedUp SE) -> next button restarts; fail: any button restarts. HUD pause
panel and Enter/Home restart step aside (Round1StageEnd.Handles). Compiled clean, NOT yet run in Unity: user testing it;
ReconstructionStagePlayCheck has STAGE_PLAY_END=win|lose (with STAGE_PLAY_BOSS=1) -> verification/stage-play/end.jsonl.
Standalone compile note: reference only plugin DLLs with isExplicitlyReferenced: 0 (others cause a Debug-type clash).
2026-11-02 ("bg_area look more correct", BG08): every StagePlay scene kept the BG03 template's RenderSettings (fog dark teal
linear 100-1000, trilight ambient), so BG08's far battleship rendered as a flat fog silhouette. The original applies per-stage
settings from InGame.Kernel.BG.InGameBGObject (on the BGxx child, not the BGxxStage root) via UpdateSkyBox (native 0x1D15260,
disassembled: fog params only if _useFog; skybox/ambient/reflection/subtractive + DynamicGI.UpdateEnvironment only if skybox set).
Ported as Assets/Reconstruction/StageRenderSettings.cs, installed by Editor/ReconstructionStageRenderSettings.Run (also called
from ReconstructionStagePlay.Build); Stages list = {"BG08"} only so far. BG08: fog off, skybox ambient. BG01-07 differ from BG03
too (fog colours/ends 800-4000) but are not switched yet. Backup backups/before-stage-render-settings.
Then user asked "make stage08 a little foggy" + "a little more": Looks override in the installer (deviation, original stays in
source): BG08 linear fog (0.11,0.40,0.58) 1000-28000 (camera depths: battleship 8-16k, mid ~4k, interior ~400). Non-obvious: URP
Particles/Unlit MixFog lerps ADDITIVE particles to fog colour too -> BG08 nebula/stars (beyond fog end) became flat cyan sheets;
fixed with Shaders/ParticlesUnlitNoFog.shader (URP copy w/o multi_compile_fog) swapped in at runtime as per-renderer material
copies under the stage root only. Renderer dumps now include camera depth (z column).
Disk 2026-11-01: D: 16 GB free, C: 2.4 GB.
2026-11-02 ("update this game as an arcade game", user chose original ARCADE mode + coin-op cabinet): ArcadeBoot is build
scene 0 (Assets/Reconstruction/Arcade: ArcadeCore/ArcadeMachine/ArcadeArt; Truxton/Round1WeaponArcade.cs carry/extend/continue).
Arcade stage order from BGMEntry stageKind: BG03,BG05,BG04,BG06,BG07,BG02,BG01,BG08; schedules mask 32 (BG01 has 97 arcade-only
events); ExtendsArcade 5M/+10M is unreachable with remaster scoring (~100k/stage) so operator menu offers 500K/1M/off.
Check Editor/ReconstructionArcadeCheck.Run (GUI, TRUXTON_ARCADE_DATA=verification/arcade/data) 17/17. Non-obvious: a public
[Serializable] class field on a MonoBehaviour is auto-created by Unity (never null) - mark run state [NonSerialized].
Round1Sound now re-selects stage music on scene load. Not exercised: 8-stage run, round loop/ending, extends, pad, player build.
2026-11-02 ("i need arcade game machine settings"): F2 = cabinet test switch -> service mode (Arcade/ArcadeService.cs): Game
(difficulty EASY=Story rules/NORMAL=Arcade, ships, extend, continue, round loop, start stage, demo time), Coin (2 chutes, key 6 =
coin B, coinage presets, max credits), Sound (master/music/effects, sound test), Display (player-only mode/res/vsync, frame
limit), input test, screen test, bookkeeping, factory reset (asks twice). Check 37/37. Non-obvious: once the cabinet sets
targetFrameRate, editor-update-driven checks must wait for Time.frameCount, not editor ticks (presses piled up).
2026-11-02 LAYOUT CHANGE (user: "default unity game project layout"): paths above are OLD. OriginalRecovered -> Assets/OriginalGame;
Reconstruction scenes -> Assets/Scenes (StagePlay/, StageInspection/, Round1/, Hub, ArcadeBoot); Assets/Truxton -> Scripts/Runtime/Gameplay;
Reconstruction/*.cs -> Scripts/Runtime/{Arcade,Stage,Stage/Bosses}; Assets/Editor -> Scripts/Editor; Reconstruction/Shaders -> Assets/Shaders;
TruxtonImported/{Textures,Materials,Prefabs,Meshes,Animations,Settings} -> Assets/{Textures,Materials,Prefabs,Models,Animations,Settings};
TruxtonGameplay -> */Gameplay + Assets/Data. Resources/StreamingAssets/Plugins unchanged. Full map: verification/layout/moves.json
(ReconstructionLayout.Undo reverses). tools/layout/rewrite_paths.py rewrote code/tools/skills. The hit-flash Sa01/Sa02 10/12 seen
after the move did not recur (12/12 twice later: intermittent); arcade check flaked once at the demo.
2026-11-02 PREFABS SORTED (user: "Organise"): Assets/Prefabs/{Effects,Pickups,Enemies,Projectiles,Environment,Player}, Dedup/BG03
kept, Prefabs/Gameplay gone, names unchanged. Map + undo: verification/prefabs/moves.json. See [[unity-prefab-organizer-skill]].
Non-obvious: move assets only with the user's Unity editor closed (it was open; asked them to close it).
