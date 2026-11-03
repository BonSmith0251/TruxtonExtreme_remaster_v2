---
name: truxton-shot-effects
description: "Make TATSUJIN EXTREME (Truxton Extreme) weapon visuals in the Unity 2023 remaster match the original: the player ship's look per power level and weapon (option pods, colour variants, upgrade parts), the player's shot sprites, muzzle flashes and lasers (thunder, gold, black) with their tip effects, enemy bullet sprites (size, glow, two-frame animation), enemy muzzle flashes, enemy lasers with their charge and muzzle glow, and the player ship's destruction explosion. Use whenever the user says shots, bullets, lasers, beams, muzzle flashes or the ship look wrong or plain ('the plane stays the same when upgraded', 'update the bullet effects', 'the laser is a flat line', 'enemy laser is pink', 'no explosion when I die'), asks to study or wire weapon or bullet effects of the player or the enemies, or a pickup gives the wrong weapon colour — even if they only paste a screenshot of shots."
---

# Truxton shot effects

How the original draws everything that is fired, and where the remaster does the same. Workspace `D:/games/Truxton Extreme` (game read-only), staging `extractor/UnityProject`, user project `C:/Users/Administrator/Documents/TruxtonRemaster` (install only when asked, through truxton-asset-extraction's install routine).

## Compare first

Put the original and the remaster side by side at the same pixel scale before changing anything; most mismatches here are size, blend or frame, which only a crop shows.
- Original: `extractor/original-autoplayer/recordings/ash-r1-colliders-20261029-shots` has 1280x720 shots with `samples.jsonl` (`player.level/arm`, `bullets[].kind/boxes/position/previous`, `lasers[]`). Crop around `boxes[0].center` (y from the bottom: `H - center.y * W/_client.x`).
- Remaster: render from the camera straight to a texture (`Round1ShotEffectCheck.Render`), not `Round1HudBuilder.RenderPreview`, which turns additive effects into black boxes. To compare an enemy bullet, spawn the same kind at the recorded stage time and viewport position (`Round1EnemyShotEffectCheck.Samples`).

## Weapon kinds and colours

`Round1Arms` is the native `TXEKernel.ArmsKind` order: Red normalShot, Green tatsujinBeam, Blue thunderLaser, Gold goldLaser, Silver homingShot, Purple starmineShot (Grow), Black blackLaser. The player prefab's `WeaponNormalShot/LaserShot/GrowShot._weaponMaterials` give the ship, pod and upgrade colour variant per kind (kind 3 gold, kind 5 purple). The purple pickup gives kind 5 (recording frame 00563). Every table indexed by `Round1Arms` must follow that order.

## Player ship (Round1Weapon.ApplyShipUpgrades)

- `PlayerControll._playerOptionDisplay` (0x1d4d710): `_leftSideOptions`/`_rightSideOptions` (`proot/opt/option01L1,L2,R1,R2`) are shown by power: none at levels 1-2, one per side at 3, two at 4. Their particle burners must be played when shown.
- `_upgradeParts` (`pf_player01_upgrade_a`, `_b`) follow `PlayerInformation.AwakenBody` (+0x64, 0..2), not the power level: `Round1Weapon.awakenBody`, default 0.
- Colour: `Resources/Truxton/ShipSkins.asset` (`Round1ShipSkinBuilder`, material ids from the variant export) swaps `Player01`, `Player01_Op` and `player01_upgrade*` materials by weapon.
- Open: pod spin/sway (`PlayerDefinedFighterOptions`) is not reconstructed; the ship silhouette differs from the original (camera or pose).

## Player shots (Round1WeaponLook)

- Sprites (`sp_eff_pshot_10/20/50/60`, SpriteAnime, two frames side by side): each material shows an inner region of its frame: normal (1,1,0,0), beam (.9,1,.05,0), homing (.7,.7,.15,.15), grow (.6,1,.2,0). The quad mesh is built at run time (`WeaponNormalCollision.SetShotMesh`), so `ShotSizes` are calibrated to the recording. The original blend One/OneMinusSrcColor doesn't exist in URP; `PlayerBullet.mat` stays additive.
- Muzzle flash: `PlayerMuzzle.Fire(i)` plays `_fireEffects[i]` at most every 0.05 s. The remaster plays `pf_eff_p_muzzle<(kind+1)*10>` at each firing emitter.
- Lasers (`sp_eff_plaser_10/40/70`): the beams are VFX Graph strips, so the remaster draws textured scrolling LineRenderers from `Resources/Truxton/ShotLook.asset` (`Round1ShotLookBuilder`): thunder `sp_eff_p_shot32/33` on a jagged path, gold `42/43`, black `72/73` plus the dark `74` underlay. A looping laser muzzle (`muzzle30/40/70`) sits at the start and `pf_eff_p_hit30/40/70_tip` at the end; both stop when firing stops (`PlaceShotEffects`). The gold laser's lock-on child beams are `childLaserL/R` of `sp_eff_plaser_40`.

## Enemy shots (Round1Combat, Round1EnemyAttacks)

- `enemybullet001-006` use `sp_eff_e_shot01-06` (two frames side by side). 001-003 and 005 are `TATSUJIN/SpriteBillbordAnime` and glow additively; 004 and 006 are alpha-blended `SpriteAnime` and turn to their direction. `Round1AttackBuilder` sets the blends. The remaster flips frames every 0.1 s (`EnemyBulletFrameSeconds`, inferred) and draws them at the plane scale (0.8 along the camera ray already enlarges them 1.25x, which matches the recording).
- Muzzle flash: patterns with `isMuzzleEffect` play `pf_eff_e_muzzle0<colour>` by `InGameBullet._colorType` (1 orange for 001-003/006, 2 purple for 004/005; 03 is blue). The colour-to-effect table (`ShortCutEffect._MuzzleEffects`) is stored as hashes; the mapping was matched by colour.
- Lasers (`enemylaser000`, `TATSUJIN/DissolveLaser`, One/One): `sp_eff_e_laser01` in its own orange colours, so tint white. `pf_eff_e_laser_energy01` plays once as the charge starts; the looping `pf_eff_e_laser_muzzle01` burns only while the beam is hot (`PlaceGlow`/`ReleaseGlow`). Not reproduced: the noise dissolve and the edge (hit/move) effects.

## Player destruction

`PlayerControll._playerDead` -> `StartDeadEffect(DeadEffectCode)` -> `InGameEffectManager.ExplosionQue` at the ship. The code is a hashed name, taken as `pf_eff_explposion_p` (no recording shows a player death). `Round1Effects.PlayerDestroyed` from `Round1Weapon.TakeDamage`.

## Adding effects

Import with truxton-asset-extraction's routine (snapshot `Assets/TruxtonImported`, `ImportWeaponAssetsBatch`, restore changed pre-existing files; pass full container paths when a prefab name exists twice). Add every runtime effect name to `Round1MeteorEffectCheck.Effects` so `EffectLibrary.asset` holds it; `Round1MeteorEffectCheck` asserts only `meteor` and `*_ingame` effects were played.

## Verify

- `Round1ShipUpgradeCheck`: pods per level, colour per weapon, upgrade parts by awaken; renders `round1-ship-upgrades.png`.
- `Round1ShotEffectCheck`: player sprites, muzzle flashes, laser strips and their effects starting and stopping; renders `round1-shot-effects.png`.
- `Round1EnemyShotEffectCheck`: bullet blends, frame flip, size, enemy muzzle flashes and laser charge/glow in play to 60 s; renders `round1-enemy-shots.png`.
- `Round1PlayerDeathCheck`: explosion, hidden ship, respawn; renders `round1-player-death.png`.
- Then `Round1FeatureCheck`, `Round1ProjectileCheck`, `Round1HealthCheck`, `Round1AttackCheck`, `Round1SoundCheck`, `Round1MeteorEffectCheck`, `Round1BossCheck`. `Round1PlayerCheck` already fails ("Stage not advancing") without these changes.
