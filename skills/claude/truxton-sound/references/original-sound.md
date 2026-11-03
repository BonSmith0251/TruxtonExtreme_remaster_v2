# Original sound: what plays when, and how we know

Recovered 2026-10-29 from TATSUJIN EXTREME (Unity 6000.3.7f1, IL2CPP metadata v39). Tags: **[D]** serialized data, **[N]** native code (disassembly of `GameAssembly.dll`), **[I]** inferred.

## Clips

560 AudioClips, all FSB5 Vorbis, 48 kHz stereo, no AudioSource components anywhere (`scripts/scan_sound_refs.py` scans all 23,580 MonoBehaviours: none references an AudioClip). Clips are loaded by name (`SoundUtility.GetSEPath/GetBGMPath`, Addressables).

| Where | Count | Content |
|---|---:|---|
| `defaultlocalgroup_assets_all` | 449 | all SE: weapons, explosions, items, bosses, UI, result, pipiru; 173 `txe_se_c*` comic sounds |
| `bgmf_assets_*` | 45 | stage music `txe_bgm_f000..f047`, boss `b000`, result `d000`, game over `i000`, menus `o000..o004`, arena |
| `bgms_assets_all` | 22 | comic/story music `txe_bgm_c*` |
| `dlc01..03` | 39 | Tatsujin Oh, Tatsujin (classic), Batsugun soundtracks |
| `pville_assets_all` | 5 | Pipiru village music `txe_bgm_p*` |

`laser_1st` and `looptest` have no SoundDatabase row (unused test clips). 21 database rows name clips that are not shipped (`txe_bgm_f016..f031`, `bg1_boss_app_01`, …).

## Ids and the SoundDatabase

- `ID` enum (454 values, global namespace) = SE id → clip name, e.g. 0 `exp_fighter`, 18 `enemy_hit_01`, 194 `exp_S5`, 1000+ comic `txe_se_c*`, 2000+ system UI (`2005 se_pause_001`). `BGM` enum = BGM id → clip. `ExpSound`, `InGameBGM`, `BossBGM` are subsets. Constants are compressed ints (metadata v29+) zig-zag encoded. [D]
- `SoundDatabase` (`TXEKernel.Sound.SoundDataBaseRecords`, outgame bundle), 579 rows: `_targetKey` / `_displayname` XOR 0x3c, `_volume` 0–100, `_priority`, `_polyphony`, `_guarantee` (s), `_isLoop`, `_isOverwrite`, `_flags`, `_kind` (0 BGM, 2 SE, 3 system). Display names are the music titles (`txe_bgm_f000` "BRAVEMAN - FAR AWAY", `txe_bgm_b000` "CRISIS"). [D]
- `SoundUtility.Play`: looks up the row; if `_polyphony > 0` and that many channels already play this clip, it overwrites the first such channel when `_isOverwrite`, otherwise drops the request (`SoundSystem.GetPlayingForOverwrite`, `IsSame`). The channel group comes from `_kind`. [N]
- `PlayQue` queues requests (max 128) and plays them in the manager's update; `_guarantee` is used there with `_lastPlayTime`. [I: treated as the minimum gap before the same clip restarts]

## Gameplay sounds

| Event | Sound | Evidence |
|---|---|---|
| Player shot volley | `_requestSounds[level-1]`: arm 0 `powershot_lv1-4` (Red), 1 `tatsujin_beam_*` (Green), 4 `homingshot_*` (Silver), 5 `starmine_*` (Gold) | [D] `WeaponNormalShot/WeaponGrowShot` on `player01`; [N] `PlayFireSound` |
| Player laser (held) | `_requestLptSounds[level-1]`: 2 `thunder_laser_*` (Blue), 3 `gold_laser_*` (Purple), 6 `black_laser_*` (Black); loop rows | [D] `WeaponLaserShot`; [N] `WeaponLaserShot.Fire` Play on a channel / `NoFire` StopCh |
| Shot hits an enemy | `enemy_hit_01` (polyphony 2, guarantee 0.2, overwrite) | [N] `WeaponNormalCollision..cctor` static = 18, `CallHitEffect` PlayQue; [D] laser `_lockOnSE` = 18 |
| Enemy dies | explosion effect's sound **and** `_overplayDeadSound` if ≠ −1 | [N] `PawnEnemy._callDeadEffect`: `ExplosionQue(..., playSound=true)` then `PlayQue(_overplayDeadSound)` |
| Explosion effect sound | `EffectPalette00`: weighted pick by `callRate` (rand % 100); else `InGameEffect._callSoundID` | [D]; [N] `InGameEffectManager.GetEffectSound`, assigned per pooled effect in `_entryEffect` |
| | `pf_eff_explposion01` → `exp_S5`; `02` → `exp_S4` 70 % / `exp_S8` 30 %; `03` → `exp_L3`; `04` → `exp_S1`; `05` → `exp_L4`; meteors `meteor_exp_s1/s2/m1`; `explposion_bos2` → `ene_x3_exp_01` | [D] |
| Overplays (Round 1) | `Pf_Ene_Md01` `exp_pf_ene_md01_01`; `BSa01/BSb01/BSc01` `exp_pf_ene_bsa_bsb_bsc01_01`; `BMa01` `exp_pf_ene_bma01_bsd01_01`; item boxes `exp_pf_item_box_all_01`; colour boxes `exp_bg_obj_colorbox_all_01`; all bosses `exp_st3_boss_b02`. `Pf_Ene_Sa01` has none (only `exp_S5`). | [D] |
| Player dies | `exp_fighter` | [N] `PlayerControll.StartDeadEffect` |
| Bomb | `bomb_def_01`, `bomb_lv2_01`, `bomb_lv3_01` by bomb level | [N] `WeaponNormalBomb.Bomb` PlayQue(table[level]); [I] table contents from names |
| Power item | `shot_powerup` on level up, `item_def` on the other branch | [N] `PlayerControll.PowerUpWeapon` (ids 14, 30); [I] which branch is "max" |
| Weapon change (colour item or change key) | `weapon_change_on` | [N] `ChangeWeaponByIndex` |
| Speed item / bomb-stock item | `item_speedup` / `item_bomb` when the capacity rises | [N] `ItemEffects.ItemEffectResult` |
| Extends | kind 9 `item_2up_01`, kind 10 `item_3up_01`, else `item_1up_01` | [N] `ItemEffectResult`; [D] `ItemCollision._getSound` |
| Speed button | `speed_up` if delta > 0 else `speed_down` | [N] `PlayerControll.ChangeSpeed` |
| Enemy bullet fired | `BulletSounds00`: `enemybullet0NN` → `enemybullet0NN_01` (ids 115–128) | [D]; [N] `InGameBulletManager.BulletFire` PlayQue(template SE) |
| | `nSoundLap` (0 or 1 per BulletTemplate) | [I] 0 = first rapid shot only, 1 = every rapid shot |
| Enemy laser | `_firstSound` at start, `_loopSound` while firing: `enemylaser000/001` `enemy_beam_charge_01`/`enemy_beam_loop_01`; `boss03laser000` `bg3_boss_beam_charge_01`/`bg3_boss_beam_01` | [D] `EnemyLaserCollision`; [N] `LaserSoundRequestData` |
| Bos03 cover breaks | `boss_parts_destruction_g_01` | [N] `Ene_Bos03.CheckCoverBreak` |
| Boss defeated | `boss_defeat01_01` + overplay `exp_st3_boss_b02` | [N] `Ene_BosBase.StopBossTimer`; [D] |
| Pause | `se_pause_001` | [N] `InGameManager.OnPauseRequested` |
| Score popups | `Score5000` `item_5000p`, `RushBonus` `item_1000p` | [D] |

Other stages: boss and gimmick sounds are hard-coded per method (`Ene_Bos01.PatternMove1` `bg1_boss_wing_close_01`, `Ene_Lc01.PlayTankSE` `bg6_tank_start_loop_01`, …) — all listed in `native-sound-calls.json`.

## Music

- A stage timeline has a `楽曲` (music) track of `BGMEntryClip`s: `_stageKind` (playlist stage) and `_sectionKind` = `TXEKernel.PlaySection` {0 Outset, 1 OnTheWay1, 2 OnTheWay2, 3 Boss, 10 Epilogue, 20 Finale}. [D]
- `StagePlayList` maps each stage's sections to BGM ids: `DefaultBGMPlaylist` (the TXE soundtrack) and the DLC alternatives `BGMList_Tatsujin`, `BGMList_TatsujinOh`, `BGMList_Batsugun`; each also names a game-over and a result BGM. [D]
- `BGMEntryBehaviour` drives the volume from the clip weight (`UpdateClipVolumeDB`, `get_FVolume`), so the clip's ease-out is a fade. [N]
- **Round 1 (BG03, stage 1):** 0–193 s OnTheWay1 `txe_bgm_f000` "BRAVEMAN - FAR AWAY" (3 s ease-out), 195–416 s OnTheWay2 `txe_bgm_f004` (3 s ease-out), 418–540 s Boss `txe_bgm_b000` "CRISIS". Game over `txe_bgm_i000`, result `txe_bgm_d000`. [D]
- BGM rows are `_isLoop` 1; the `*_intro_loop` DLC tracks pair with `SoundUtility._IntroLoops` (not yet recovered; the remaster loops each clip whole). [I]
