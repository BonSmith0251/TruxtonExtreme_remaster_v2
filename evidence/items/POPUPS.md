# Score popups and the 5000 bonus (native study)

Read-only study of GameAssembly.dll (IL2CPP) and the serialized assets under
`Reconstructed/Assets/OriginalGame`. RVAs are GameAssembly RVAs. `[I]` = inference, `[unconfirmed]` = not proven.

## 1. Popup kinds (complete list)

Only three numeric popups exist. Their effect codes are built in `InGameManager..cctor` 0x1CF04E0 from the names
`"Score5000"` -> `Sc5000cd` (static +0xB8), `"Score1000"` -> `Sc1000cd` (+0xBC), `"RushBonus"` -> `ScRushBcd` (+0xC0)
(`ItemGetCode` +0xC4 = `"ItemGet01"` is the pickup sparkle, no number). No other asset or prefab references these names.

| Popup | Prefab | Trigger (only users of the code) | Index shown | Score |
|---|---|---|---|---|
| Score5000 | `Samples/Prefabs/Reference/Effect/SignBoard/Prefabs/Score5000.prefab` | `InGameManager.Get5000` 0x1CE3F10 -> `InGameEffectManager.RequestMustQue` 0x1CD1140 | bonus multiplier `mul` (1..12) | `AddScore(5000 x mul)` |
| Score1000 (jewel) | `.../SignBoard/Prefabs/Score1000.prefab` | `InGameBulletItem.LateUpdater` 0x1CCA020 (jewel captured by the player: `PlayCaptureSE`, `AddJewel(1)`) -> `RequestQue` 0x1CD11E0 at 0x1CCA516 | `NumBonusMul` (not incremented) | `AddScore(100 x NumBonusMul)` |
| RushBonus | `.../SignBoard/Prefabs/RushBonus.prefab` | `InGameManager.GetRushBonus(pos, n)` 0x1CE6180, only when `_isRushMode`; callers `<CheckRushBouns>d__318.MoveNext` 0x1D26061, `EnemyEntryBehaviour.ProcessFrame` 0x1D33F96 | `n` | `AddScore(NumBonusMul x n x 5000)` |

**No popup for ordinary enemy kills, bosses, part breaks or damage scores.** Those scores go through
`WeaponCollisionBase._damageToEnemy` -> `InGameManager.AddScore` 0x1CE2500 (and `PawnEnemy.AddDamageParts` for parts) with no
effect request. `RequestMustQue` has only the two callers above, and `Sc1000cd` is read only by `InGameBulletItem.LateUpdater`.
The ground score item (`Pf_item_bonus01`, AddScore 5000 through ItemEffectResult) shows a popup only because the "useless item"
path also calls Get5000 (SPEC §7).

## 2. Effect system

- `InGameManager.Get5000(pos, pno, isGround)`: if pno >= 0: `mul = PlayerCommonData.AddBonusMul()` 0x26DCD30;
  `p = GetSkyRootPosition(pos, isGround)` 0x1CE6750; `_effectManager.RequestMustQue(_inGameEnemyRoot, Sc5000cd, mul, p, withSE=true)`;
  then `AddScore(5000*mul)` unless `_playPhase` is 4, 5, 7, 9 or 10.
- `EffectQue.SetMustEffect` 0x1CC6C00 (kind 0, int value = index) -> `PlayJobQue` 0x1CD07A0 -> `SetupEffect(que, eff, i)` 0x1CD1C50:
  kind 0 calls vslot 0x288 = `EffectScore5000.SetIntEffect(index)` 0x1D13D70. If `withSE` is false, `_callSoundID` is set to -1.
  The position is written by the transform job with `isWorld = (kind == 2)`, so false: **local position under `_inGameEnemyRoot`**.
- `GetSkyRootPosition`: `GetGameCamera(isGround).WorldToViewportPoint(pos)` -> `ViewportToPlanePos` 0x1CEE670 (the sky play plane);
  y (height) clamped to [-3, 3] for sky, [-10, 10] for ground. **No offset**: the popup sits at the same screen point as the
  source. It does not move afterwards (startSpeed 0, no velocity module, local simulation) [I: stays screen-fixed because the
  root is the sky enemy root].
- Class `InGame.Kernel.Effect.EffectScore5000` (script used by all three prefabs). Statics (.cctor 0x1D13ED0):
  `NumDisplaySeconds = 3.0`, `NumFadeintSeconds = 2.8`, `NumFadeinTime = 0.2`.
  - `Initialize` 0x1D13820: `_numRender = _sprites.Length` (3, or 2 for RushBonus); alpha 0; digits hidden.
  - `SetIntEffect(n)`: `_numMul = n`, `_numDisplayTime = 3.0`.
  - `PlayStartEffect` 0x1D13870: plays `_callSoundID`; **if n < 2 the multiplier is hidden** (`SetNumDisable`). Else
    n = min(n, 99), tens = n/10, ones = n%10: `_sprites[0]` (sprite10) shows `_nums[tens > 0 ? tens : ones]`;
    `_sprites[1]` (sprite00) shown only if tens > 0, with `_nums[ones]`; `_sprites[2]` ("x") shown.
  - `ProgressEffect(dt)` 0x1D13B10 (overrides the base, so `_isTimelimit` is ignored): `t -= dt`;
    digit alpha = `t >= 2.8 ? 1 - (t - 2.8)/0.2 : clamp01(t)`, i.e. fade in over 0.2 s, full until 2.0 s, linear fade out
    from 2.0 s to 3.0 s; done (pooled) when t <= 0, so **lifetime is 3.0 s** for all three popups.
  - `SetAlphaMaterial` 0x1D13C70 sets `InGameResident.GetBillboardMaterial(alpha)` 0x1D21910 on every digit renderer.

So the display is **"5000" plate + "x" + multiplier** ("5000 x2" ... "5000 x12"). There is no "10000"/"60000" texture.

## 3. Assets and numbers

Plate = one billboard particle (render mode 0), lifetime 3, burst 1 at t=0, startSpeed 0, colour white, looping off.
Size over lifetime (curve x 2): key 1.0 at 0, 0.26153842 at 0.043255553 (0.130 s), 0.26153842 at 0.9450187, then flat.
Alpha over lifetime: 0 at 0, 1 at 0.0353 (0.106 s), 1 at 0.8235 (2.47 s), 0 at 1.0 (3.0 s). Same curves in all three prefabs.

| Prefab | Plate material / texture | startSize | Pop -> rest size | Digits (local x, scale) | Sound |
|---|---|---|---|---|---|
| Score5000 | `TXE_GraphicData/Effect/Materials/mt_eff_5000pts01.mat` (shader `TXEKernel/Shaders/ParticleAlphablend.shader`), `TXE_GraphicData/Effect/Sprite/sp_eff_5000pts01.png` 256x256 (red "5000" in a blue frame) | 52 | 104 -> 27.2 | x at 10 (scale 5); sprite10 at 13, sprite00 at 16.5 (scale 6) | 31 `item_5000p` |
| Score1000 | `mt_eff_jewel_pts01.mat`, `sp_eff_jewel_pts01.png` 128x128 ("100") | 21, under `lroot` scale 0.6 | 25.2 -> 6.6 (x0.6 applied) | x at 6.3 (5); 9.3, 12.8 (6); all x0.6 | -1 (none) |
| RushBonus | `mt_eff_bonus01.mat`, `sp_eff_bonus01.png` 256x256 ("BONUS") | 50 | 100 -> 26.2 | no x; 11.5, 15 (6) | 270 `item_1000p` |

Digit sprites (material `Samples/Prefabs/Reference/Enemy/bullet/Shaders/TATSUJIN_SpriteBillboardScore5000.mat`,
shader `SpriteBillboard.shader`), atlas `Texture2D/sactx-0-4096x4096-BC7-ResidentSpriteAtlas-644a45be_0.png`, every glyph
80x80 px, 100 ppu, pivot centre (0.8 units, x6 = 4.8 units):
`_nums[0..9]` = `TXE_GraphicData/UI/ui_font_result01_15..24` = digits 0..9, rects (x,y): 0 (868,1462), 1 (83,3144),
2 (1596,2194), 3 (1236,2272), 4 (83,3310), 5 (1320,2356), 6 (1844,2151), 7 (1238,2438), 8 (942,2691), 9 (166,3228);
"x" = `ui_font_result01_9` (1156,2519). Prefab layer 17, `_sortlayerID` 1134729403.

Multiplier (SPEC §7): `mul = clamp(mul+1, 1, _numBonusMax)`, `_numBonusMax = 10 + min(2, awaken)`, reset on death.

## 4. Get5000 callers and when they fire

| Caller | Condition | Position / pno / isGround |
|---|---|---|
| `Ene_Mj01b.ToDestroid` 0x1DC6F70 (call 0x1DC7020) | body killed and `head.ReceiveKill(body)` 0x1DC78B0 returns `++_killCount > _summonEnemyCount (9)`, i.e. this body is the 10th and last of head + 9 bodies | body `transform.position`, body `_deathByPno`, false |
| `Ene_Mj01h._callDeadEffect` 0x1DC7D70 (call 0x1DC7F32) | head killed with `_killCount == 9` (all 9 bodies already killed); then `_killCount++` and `ItemDrop(7)` | head `transform.position`, head `_deathByPno`, false |
| `Ene_La01.ProgressEnd` 0x1DBC6D0 (updater, run from ToDestroid / ToProgressEnd) | root not alive (vslot 0x1B8 IsAlive false); body1 (+b1muzzle) and body2 parts still unbroken are broken now; **Get5000 only if both body1 and body2 were still intact** when the core died | `GetPartsPosition()` of part body3, root `_deathByPno`, true |
| `Ene_Lc01.CheckDestroyTurret` 0x1DBCE60, same code inlined in `_moveState` 0x1DBE730 (call 0x1DBF13B) | while `!_isCoreDead`, each newly broken cover counts down `_turrets` (= `_partsData.Length - 1` = 11 in `Pf_Ene_Lc01.prefab`); at 0 (**all 11 covers destroyed while the core lives**) | that last cover's transform position, **pno 0 (hard-coded)**, true |
| `Ene_Mm01.OnPartsBreak(part)` 0x1DCCFA0 (call 0x1DCD0AE) | the other half is already broken and `_state` is 3 (HORIZON_2) or 10 (VERTICAL_2), the joined states. If the other half is still alive it is instead damaged down to 1 HP (`SendDamage(LeftHp-1)`, damage smoke) | Mm01 `transform.position`, `_deathByPno`, false |
| `InGameBonusManager._setCompleteBonus` 0x1CC8F50 (from `UpdateDeadEnemy`) | wave bonus `Score5000` (100) when the wave is complete | last dead enemy position, its `_deathByPno`, false |
| items (SPEC §7-9) | useless floating or ground item, ScoreUp carrier (kind 8), ground enemy kind 8 drop | item or enemy position |

## 5. Mj01 details and database score

- **Bodies and the head still pay their normal kill score.** Mj01b/h, La01, Lc01 and Mm01 do not override
  `GetDeathScore` 0x1D0D820 / `GetDamageScore` 0x1D0D770. The shot path (0x1D5907F..0x1D590D0) adds
  `IDamagedObject` slot 8 (damage score) plus, if not alive, slot 9 (death score) [slot mapping I]. Death score =
  `_scorePoint x GetScoreRate(tole)` 0x1D1ED30 (x2 for tole `low`, x3 for `verylow`, else x1). The Get5000 bonus comes on top.
- EnemyDatabase scores (`InGame/InGameReference/Database/EnemyDatabase.asset`, keys XOR 0x3C, `_score` XOR 0x136ACF
  [I: empty rows decode to 0 and Bos04 to 100000, matching Bos04/SPEC]): Mj01b 5000, Mj01h 20000; La01 50000
  (body1/body2 20000, b1/b3muzzle 5000); Lc01 50000 (C1-C3 5000, L1-L4/R1-R4 1000); Mm01 20000 (left/right 20000).
- Mj01 order: `_killCount` counts every body kill (ReceiveKill) and the head death, so the bonus goes to whichever of the 10
  dies last. Killing a body stops further releases and disables unreleased bodies, so if a body dies before all 9 are
  released the count cannot reach 10 [I]. Whether ReceiveKill still works after the head is pooled [unconfirmed].

## 6. Unconfirmed

- `ItemEnemy._displayScoreUp` 0x1D71210 caller not found.
- The meaning of the RushBonus count `n` and Rush mode itself (it is a separate mode).
- Sorting layer name for id 1134729403. The world size of the popup relative to the screen is not measured.
