# TruxtonRemaster — Round 1

Open with Unity **2023.2.22f1** (URP 16.0.6), then open `Assets/TruxtonImported/Scenes/Round1.unity`, press Play and focus the Game view.

The HUD matches the supplied `TATSUJIN EXTREME 2026-10-26 00-27-40.mp4` gameplay recording (55–125 seconds): full-screen playfield, compact transparent player status at the upper left, high score at the upper right, and skull bomb stock at the lower left. It uses the original score labels, bitmap font, ship/skull icons and gauges. Scores are right aligned without leading zeroes; the ship count shows reserves (total lives minus the current ship). High score persists between sessions. The reference EX gauge is present but remains empty: the original EX/Pi gameplay system is not implemented, and the gauge does not substitute score or change charges.

Press P/Esc for resume/restart/help buttons and F1 for instructions, weapon name, bomb level and change charges. The skull stock is clickable to use a bomb; C and X/right mouse remain available during play. Ten skull positions reproduce the reference artwork; the existing remaster inventory cap remains nine. The corner layout scales to 16:9, 4:3 and ultrawide screens without reducing the camera viewport.

## Controls

- WASD / arrows: move. Shift: precision movement.
- Space / Z / left mouse: fire.
- X / right mouse: use a bomb.
- C: spend one change charge to cycle weapons.
- P / Esc: pause or resume. Home: restart. Enter: restart after game over.
- F1: help and pickup labels. F2: respawn all pickup types.
- F3: jump to the Round 1 boss warning at 6:58.
- R: reset ship position. Page Up / Page Down: seek the background timeline (debug).

## Pickups and weapons

All 19 pickup types are present at the start, with three P capsules; 99 later drops cycle through every type at six-second intervals. F2 restores the opening set. Pickups cannot be collected twice or while paused/dead.

| Pickup | Implemented effect |
| --- | --- |
| P | Raises weapon power through four levels and activates ship upgrade parts; excess power adds 1,000 points. |
| B | Upgrades bomb strength separately from stock (serialized item value +2, capped at level 3). |
| Skull | Adds two bombs, capped at nine. X/right mouse consumes a bomb, damages enemies, clears hostile bullets and protects the player. |
| C | Adds a change charge; C/button consumes a charge to cycle all seven weapons. |
| 1UP / 2UP / 3UP | Adds the corresponding lives, up to 99. Lives are consumed by enemy collisions and bullets. |
| S up / down | Changes actual movement speed, bounded to the six extracted multipliers: 1.0, 1.4, 1.8, 2.2, 2.6, 3.0. |
| 5000 bonus | Adds 5,000 points, matching the original item value and artwork. |
| Gold / purple score gems | Add 1,000 / 5,000 points. |
| Colored weapon item | Selects the matching weapon below, preserving power level. |

| Color | Weapon | Working behavior | Source shot counts, levels 1–4 |
| --- | --- | --- | --- |
| Red | Normal shot | Forward spread, projectile damage | 3 / 9 / 15 / 21 |
| Green | Tatsujin beam | Fast piercing projectiles | 1 / 3 / 5 / 7 |
| Blue | Thunder laser | Lightning locks onto an enemy while held | 1 / 3 / 5 / 7 |
| Purple | Gold laser | Sustained lasers split between targets | 1 / 3 / 5 / 7 |
| Silver | Homing shot | Projectiles steer toward enemies | 5 / 13 / 21 / 29 |
| Gold | Grow shot | Projectiles enlarge in flight, increasing hit area, and pierce | 3 / 5 / 7 / 9 |
| Black | Black laser | Sustained directional beams pierce multiple enemies | 1 / 3 / 7 / 11 |

Bomb duration, area damage and visual size scale with bomb level. A dead ship respawns after a short delay, loses one power level and receives three seconds of protection; running out of lives opens the game-over UI. Restart restores the initial state while retaining high score. Pausing freezes combat timers and blocks firing/collection; rewinding the stage resets the run.

The source shot-angle/muzzle tables, projectile speeds, color-to-weapon mapping, item amounts and six movement multipliers are retained in `Assets/TruxtonGameplay/gameplay-parameters.json`. Normal projectiles use their original two-frame textures. The skull bomb combines an original HUD skull with the extracted shockwave texture.

## Scene and scope

The original Round 1 environment is BG03, with 1,207 hierarchy objects, 653 mesh renderers, 22 lights, 82 native particle systems, the 600-second camera sequence and 15 activation tracks. Play begins with the original carrier launch movie, then enters the BG03 route in space at time zero.

`Round1 Combat` now follows the extracted BG03 enemy schedule, starting at five seconds in arcade mode. `Round1EnemyWaves` drives the authored arrivals, formations, repeat waves and conditional reinforcements using 11 original enemy models. Its **Automatic Waves** option can be disabled in the Inspector. See the original enemy waves section below for source coverage and remaining AI adaptations.

The gameplay and UI are reconstructed for this project. Original compiled gameplay scripts, VFX Graph shaders and exact timing/damage rules are not recovered. Fire cadence, normalized muzzle spacing, targeting, damage, bomb timing, death penalties, score-gem rewards and inventory caps are explicit remaster tuning. UI artwork and component roles are original; the responsive widescreen layout is rebuilt. Custom environment/particle shaders remain approximations. Other bosses, music progression and the rest of the original game are outside this scene.

## Original player spawn animation

`Assets/TruxtonGameplay/Animations/anc_player_start1.anim` and `anc_player_start2.anim` retain the original 1.1667-second player entrance animations. Both have three translation curves and three Euler rotation curves, rebuilt from the exact original cubic keys; the spin directions are opposite (+420 to 0 degrees and -420 to 0 degrees). The source travel and rotation are sampled directly on the player model under its existing camera-relative parent.

The launch cinematic hands off to start2 for a new run. Respawn selects start1 after right movement, or start2 after left/no movement, matching the original IsRightMove flag. Home replays the cinematic. Movement, shooting, pickups, bombs and changes are locked during entrance, and the ship is protected from damage. Pause freezes the animation; completion restores the neutral model pose and player control. Timeline seeks cancel the entrance cleanly. The clip choice and playback duration are recovered from the native entry state machine; camera framing remains an adaptation.

`SourceAssets/PlayerSpawn` contains both raw source clips, their dependency/provenance records and the sampled manifest. Re-export with `python extractor/export_player_spawn.py`; rebuild and test with `Round1SpawnBuilder.BuildAndCheckBatch`. `round1-player-spawn-validation.json` checks every source curve sample and the actual animated player transforms, then the existing boss and gameplay suites run. `PlayerSpawnPreviews` contains rendered animation frames.

## Round 1 boss

The source BG03 timeline enters `tt_boss03` at **420 seconds (7:00)**, following the boss-section warning at **418 seconds**. `Round1 Boss Encounter` spawns the extracted `pf_bs03` model once, clears ordinary enemies, and plays its five-second entrance rotation with camera-relative placement. It becomes vulnerable when the entrance finishes.

The encounter uses a live health gauge with the original boss UI artwork. All seven player weapons and bombs damage it. At 66% and 33% health it escalates from aimed seven-way fans and rings to denser fans and side shots. Defeating it awards 50,000 points once, clears hostile bullets, plays an explosion, and opens ROUND CLEAR. Restart/Home/Enter resets the encounter. F3 jumps directly to its warning for testing.

The camera and activation tracks loop the original 480–540-second arena while the boss survives, including beyond the background timeline's 600-second endpoint. This loops presentation without rewinding health, pickups or combat. Pause, game over, manual seeks and restart preserve their expected behavior; rewinding removes the boss and resets its encounter.

The model, materials, source timing and entrance curves are extracted. Its 1,800 HP, three attack phases, damage handling and defeat flow are new remaster logic, not recovered original boss AI. Damage/steam particle objects remain disabled where their original shaders are unavailable.

`Assets/Truxton/Round1Boss.cs` controls the encounter. `SourceAssets/Boss/boss-source.json` records source timing and enemy/bullet templates. `round1-boss-validation.json` checks the full encounter and all weapon types; `round1-boss-preview.png` shows the rendered encounter. Run `Round1BossBuilder.BuildAndCheckBatch` to rebuild, render, test the boss and then run the existing gameplay regression checks.

## Files and validation

- `Assets/Truxton/Round1Weapon.cs`: original shot tables, projectiles/lasers, pickup inventory, bombs, damage/death and restart.
- `Assets/Truxton/Round1Combat.cs`: bounded enemy/bullet pools, authored wave integration, targeting, damage and scoring.
- `Assets/Truxton/Round1Hud.cs`, `Round1HudText.cs`: live HUD binding and original bitmap glyphs.
- `Assets/Truxton/Round1Rules.cs`: portable extracted weapon data.
- `Assets/TruxtonGameplay/UI`: 173 decoded original HUD sprites.
- `SourceAssets/Hud`: sprite provenance, original HUD hierarchies, serialized gameplay components and parameter tables.
- `SourceAssets/Powerups`: all pickup models and dependencies. `SourceAssets/Weapons`: earlier shot/power export.
- `round1-features-validation.json`: current Play-mode integration report (all 19 types, seven weapons/four levels, real damage, bombs, death, respawn, HUD controls and pools).
- `round1-hud-preview.png`, `round1-bomb-preview.png`: rendered previews.
- `round1-hud-4x3-preview.png`, `round1-hud-ultrawide-preview.png`: alternate-aspect HUD previews.
- `SourceAssets/Hud/video-reference.json`: recording timestamps, observed layout and implementation limits.

Earlier `round1-weapon-validation.json` and player/environment reports describe previous milestones. The current gameplay check is `Round1FeatureCheck.RunBatch`. `Round1HudBuilder.RebuildLayoutAndCheckBatch` rebuilds just the HUD layout, renders the HUD and boss previews, and runs boss plus gameplay checks. Batch commands should use the isolated staging project under `D:\games\Truxton Extreme\extractor\UnityProject`, not the project open in your editor.

## Original launch cinematic and impact entrance

`Assets/StreamingAssets/Truxton/demo_takeoff_10.mp4` is copied byte-for-byte from the original game: 15.034 seconds, 2560x1440, 60 fps, with its original audio. The carrier approach, hangar takeoff, flyby and orange boost match the 00-52-54 recording (the requested 00-52-34 clip only contains a pause menu). `Round1Intro` presents the movie in a fitted, letterboxed overlay, holds the stage clock and combat, then transitions into the live ship. Enter/Space skips, P/Esc pauses both video and game, and Home replays the intro. Missing/failed video playback falls back to the live entrance instead of locking the game.

The player uses the original red material variants to match the movie. The showcase powerups appear after the entrance settles. The player now sweeps up from below frame, passes close to the camera, overshoots high, and settles to its normal size and control position. The source animation values and duration are preserved, including their exact cubic derivatives. A fixed camera-space conversion of source Y/Z drives framing; the earlier independent waypoint path has been removed. Original `pf_eff_burner_p01` and `pf_eff_demo_boost01` particles provide engine ignition and flame. Their clock follows the animation, including pauses; their custom additive shader is approximated in URP. The boost's source light reference is unavailable and is not required for particle playback. Initial entry and death respawn both use this presentation; only initial entry/restart plays the movie.

The current BG03 round is retained, with a brief ROUND 1 / VOLCANO title. The capture's space-stage title is not used to relabel the existing volcano round. `SourceAssets/Intro/intro-source.json` records provenance and the movie SHA-256. `round1-intro-validation.json` checks actual video decoding, natural completion, pause, skip, seek, restart, live fly-in framing and return to shooting; spawn, boss and gameplay suites follow. `IntroPreviews` contains decoded movie frames and live entrance renders. Re-export with `python extractor/export_intro.py`; import effects with `TruxtonImporter.ImportWeaponAssetsBatch -truxtonInput <intro-effects-output>`, then run `Round1IntroBuilder.BuildAndCheckBatch`.

## Original player steering and motion correction

`SourceAssets/Motion/player-motion-analysis.txt` explains the recovered methods, field names, RVAs and formulas. The local read-only parser resolves IL2CPP metadata v39 and disassembles the relevant methods in `GameAssembly.dll`; it does not modify or execute game code. `motion-audit.json` includes the source binary hash and distinguishes recovered behavior from camera adaptation.

The original left/right pose is procedural: `PlayerControll._moveYaw` uses a 45-degree maximum, a 500-millisecond timing value, six speed factors, and a sine table with 0.1-degree steps. Full horizontal input produces about 37.8255 degrees of roll on `proot/modelTop/pf_player01`, preserving its 2.5-unit pivot offset. Steering eases and reverses using the native timing formula and freezes on pause. The former 15-degree exponential tilt on the entrance root has been removed.

`Assets/TruxtonGameplay/player-motion.json` stores the extracted settings and exact curve keys. The fly-in uses those original cubic curves instead of the sampled linear segments and the added stop-at-every-waypoint curve. Exhaust retains simulation history and advances with frame delta rather than restarting at fixed physics intervals. `MotionPreviews` shows the updated entrance and left/neutral/right poses. `round1-motion-validation.json` checks recovered steering fixtures at every speed, pause, direction-dependent respawn, curve continuity, particles and 30/60/144 FPS trajectory agreement, followed by the cinematic, source spawn, boss and gameplay suites.

Reproduce the analysis with `python extractor/analyze_player_native.py` and `python extractor/export_player_motion.py`; rebuild via `Round1MotionBuilder.BuildAndCheckBatch`. The fixed source-to-camera framing conversion is explicit remaster tuning, not a recovered original camera transform.


## Original Round 1 enemy waves

`Round1EnemyWaves` replaces the temporary eight-second wave timer with the extracted BG03 nested timelines. The runtime data contains 301 authored entries (six end-boundary entries are excluded), 30 enemy definitions, 25 original route lookup tables and 11 original enemy models. It includes staggered arrivals, delayed formations, cyclic offsets, 12 clear-dependent loop entries and 106 wipeout-gated reinforcement entries. The default is Arcade1; the first enemies arrive at five seconds. Pausing, restarting, seeking and the 418-second boss warning cleanly manage enemies and queued formations.

`Assets/TruxtonGameplay/round1-enemy-waves.json` is the runtime schedule. `SourceAssets/EnemyWaves` contains the full serialized evidence, selected native disassembly, binary hashes and `enemy-spawn-analysis.txt`; `SourceAssets/Enemies` contains the portable visual export. `round1-waves-validation.json` records source checks, conditions, 30/60/144 FPS comparisons and complete kill-driven/no-shooting sweeps. `EnemyPreviews` shows several wave compositions. Rebuild through `Round1WaveBuilder.BuildAndCheckBatch` in the isolated staging project.

Spawn data and route points come from the original game. Camera-plane conversion, scaled health and aimed-bullet combat are remaster adaptations. Enemy-specific native AI, speed easing, advanced attack scripts, segmented movement and route-event state changes remain incomplete; the detailed analysis lists the fallbacks. This update does not claim to reproduce every original attack pattern.


## Original enemy attacks and procedural animation

Round 1 now uses 21 extracted attack templates, 9 selectors, six original bullet visuals, original muzzle paths and charged lasers. Enemy bodies/turrets play 45 recovered rotation events, with corrected facing and pooled-pose reset. The setup loads automatically when Play starts.

The full-round attack test fired 1,357 projectiles and eight lasers with no pool misses. See `round1-attacks-validation.json` and `round1-enemy-motion-validation.json`. `SourceAssets/EnemyAttacks/enemy-attacks-analysis.txt` documents native evidence and remaining remaster adaptations (complex task timing, specialized AI, drift, bullet speed, and shaders).


## Original combat damage and HP

Round 1 uses decoded EnemyDatabase HP for all 11 enemy types and the boss, with extracted damage profiles for all seven weapons. The player has 100 HP per life; one normal hit costs a life. Respawns restore HP and retain protection. Lasers and growing shots apply first/stay contact damage at fixed 60 Hz. Bombs use the recovered 1.25-second duration and original level damage multipliers.

The shared placeholder shot damage, enemy 0.05 health multiplier, and 80 HP cap are removed. Existing scenes receive the new values automatically when Play begins. See `round1-health-validation.json` and `SourceAssets/CombatBalance/combat-balance-analysis.txt` for validation, native evidence, and remaining remaster adaptations, including the fixed collision cadence and single-body boss.


## Player projectile behavior corrections

Player weapons now use original rapid intervals and ammo caps, authored muzzle positions and offsets, source-space bullet speed, ordered hit resolution, conditional green breakthrough, priority-based timed silver homing, and stopping/decaying gold napalm. Lasers extend before making contact, retain acquired locks, respect database blocking flags, and release cleanly. Purple GOLD LASER creates its two secondary branches at a contacted target.

Seven validation suites pass, including a new 30/60/144 FPS projectile check. See `round1-projectiles-validation.json`, `round1-projectiles-preview.png`, and `SourceAssets/PlayerWeapons/player-weapon-analysis.txt` for native evidence and remaining visual/edge-behavior adaptations. Existing scenes load the corrections automatically on entering Play.


## Enemy attack corrections

Enemy attacks now use the original per-type bullet speeds, corrected self-directed muzzle angles, Me01 shared aiming and 45-degree angle steps, original first-delay/recurring-wait semantics, muzzle-entry gating, suppression probabilities and weighted selectors. The laser glow also uses the original width with additive blending.

All seven regression suites pass; enemy timing is checked at 30/60/144 FPS, with a complete ordinary-enemy Round 1 simulation. See `round1-attacks-validation.json` and `SourceAssets/EnemyAttacksReview/enemy-attack-review.txt`. This review supersedes the earlier generic-speed and repeat-timing assumptions. Md01 movement-dependent attack programs, boss AI, dynamic difficulty progression and some special effects remain adaptations. Stop Play, allow Unity to compile, then Play again to load the corrections.
