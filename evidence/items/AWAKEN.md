# TATSUJIN EXTREME (original, IL2CPP): awakened power levels 4 and 5

This is a read-only native study written on 2026-11-04. It adds to `SPEC.md` §3, §7 and §11.
Anything marked [unconfirmed] was not proven from code or assets.

## 1. What levels 4 and 5 change

### 1.1 The weapon clamps the level to 3

- `WeaponBaseShot.SetPower(n)` (0x1D578B0) runs `Enum.IsDefined(PowerLevels, n)`. If n is defined, it sets
  `_powerLevel` (offset 0x38) = n, **without clamping**. `PowerLevels` covers 0..6, so 4 and 5 are stored as they are.
  It returns `_powerLevel != old`, so the steps 3→4 and 4→5 still count as a real level-up. On a real level-up,
  PowerUpWeapon plays the PowerUp effect and sound 0x0E and refreshes the options.
- `WeaponBaseShot.PowerLevel()` (0x1D578A0) returns **`min(_powerLevel, 3)`**. Only SetPower reads `_powerLevel`
  directly. Every fire path uses this virtual call (vtable 0x198, IWeapons slot 12):
  - `WeaponNormalShot.Fire` (0x1D76F00). WeaponGrowShot and WeaponWallShot inherit this Fire.
  - `WeaponNormalShot.IsFire` (0x1D779B0) and `OptionLevel` (0x1D752B0).
  - `WeaponLaserShot.Fire` (0x1D74B70), `OnUpdate` (0x1D75190) and `OptionLevel`.
- These per-level tables are all indexed with the clamped level: `ShotDirectionData` mask test, `_weaponLevelBits[lv]`,
  `_requestSounds[lv]` and the laser's `_requestLptSounds[lv]`.
- Result: at levels 4 and 5, **shot count, directions, sprites, laser beams, fire sounds and options are exactly those
  of level 3**.
- Fire rate (`_RapidDelay`) and bullet speed (`BulletSpeed`) do not depend on the level. Only ex-boost changes them:
  rapid delay ×0.5 and bullet speed ×1.75.
- Option pods: `OptionLevel()` gives 0 at L0/L1, 1 at L2 and 2 at L3. Levels 4 and 5 therefore give 2, the same as L3.

### 1.2 The shot mask test

`ShotDirectionData.IsFire(lv, isExboost)` (0x1D513F0) checks `(mask & req) == req`, where
`req = (1 << lv) | ((isExboost + 1) << 29)`.

The `ShotLevelFlags` enum names the bits:

| Bits | Name |
|---|---|
| 0..3 | lv0..lv3 |
| 29 (0x20000000) | `Usually` (fires in normal mode) |
| 30 (0x40000000) | `Special` (fires only while ex-boost is on) |

No shot ever needs bits 4 or 5.

**Remaster gap.** The original `superFighter/shots*.asset` files hold a second, `Special` set of every table:

| Mask | Normal (`Usually`) shots | Ex-boost (`Special`) shots |
|---|---|---|
| 0x…08 | 26 | 28 |
| 0x…0C | 26 | 28 |
| 0x…0E | 24 | 26 |
| 0x…0F | 15 | 15 |

`gameplay-parameters.json` has only the 91 `Usually` entries, so the ex-boost shot patterns are missing.
For example, the Normal table has 21 Usually shots and 21 Special shots.

### 1.3 Damage

`WeaponCollisionBase._damageToEnemy` (0x1D58D60) computes damage × `InGameParameter.GetDamageRate(toleType)` ×
`InGameManager._damageMag` (offset 0x60). It has no power-level or awaken term. **Awakening does not change damage.**

### 1.4 What awakening does change: `_awakenBody`

`SetArmLevel` (0x26DEA30) sets `_awakenBody` to 0 below level 4, 1 at level 4 and 2 at level 5 or above.
`_awakenBody` is used in three places:

- **Ship upgrade parts.** `PlayerControll._playerOptionDisplay` (0x1D4D710, read at 0x1D4D8D8) runs
  `_upgradeParts[i].SetActive(i < awakenBody)` for i = 0 and 1. In player01 these parts are `pf_player01_upgrade_a` and
  `pf_player01_upgrade_b`. Level 4 shows part a; level 5 shows parts a and b.
  `ChangeWeaponByIndex` sets the weapon's Mats.UPGrade material on `player01_upgrade_a`, `_bl` and `_br`.
- **Bomb.** `FireBomber` (0x1D491C0, read at 0x1D492CD) calls `WeaponNormalBomb.Bomb(awakenBody)` (0x1D75850).
  This selects `_bombBanks[awakenBody]` and `_requestSounds[awakenBody]`. The bomb prefab is `sp_eff_bomb_01`, `_02`
  or `_03` (the `_bombBases` entries in player01).
- **5000 bonus cap.** The cap is 10 + min(2, max `_awakenBody`), so 50000, 55000 or 60000 (SPEC §7).

**Dead code:** `PlayerControll.IsAwakenLv1` (0x1D49DD0) and `IsAwakenLv2` (0x1D49E30) test `PowerLevel() == 4` and
`== 5`. Because PowerLevel() is clamped, both are always false. `TLEntryBehaviour.IsCheckStartTL` would set timeline
weapon-flag bits 20 and 21 from them. No serialized `_weaponFlag` uses those bits (the only values are 0, 16, 51, 76
and 111), so this has no effect.

## 2. How the awaken levels are unlocked

`PlayedRecords.General.EvaluateRecords` (0x26F2400) compares `r12 = Statistics.PlayerLevel()` (0x26F9B50). Record i
(i = 0..8) unlocks at PlayerLevel ≥ (i+1)×100:

| PlayerLevel | Unlock |
|---|---|
| 100 | Lives 10 |
| 200 | Auto Bomb |
| 300 | Gold Thunder Laser |
| 400 | Bombs 10 |
| **500** | **WokeUpUnlocked (label 4)**, message "Evolution unlocked." |
| 600 | Black Thunder Laser |
| 700 | Lives 100 |
| 800 | Shot Power |
| **900** | **MoreAwakeUnlocked (label 8)**, message "Evolution unlocked again." |

`PlayerLevel` = Σ (statistic ÷ LevelRate) over the statistics that have a rate (`Statistics..ctor` 0x26FA0A0).
Each term is an integer division:

| Statistic | Divided by |
|---|---|
| TotalScore | 1,000,000 |
| Play time (ms) | 3,600,000 (one level per hour) |
| Enemies destroyed | 10,000 |
| Bosses destroyed | 100 |
| PlayerDeathsBonus count | 1 |
| DestructionRateBonus count | 1 |
| RemainingTime | 3,600,000 |
| Pipirus | 100,000 |
| AmberJewel | 10,000 |
| 5000P items | 100 |
| 1UP items | 100 |

The other statistics have rate 0 and do not count. The unlock is not an achievement and not a stage clear. It comes
from this lifetime "player level" in the save data.

**Mode check.** `_InitializeParameters` (0x1CEED10) has **no play-mode branch**. It needs only a TXEDataStore instance:
awakenLv = 2 if MoreAwake is unlocked, else 1 if WokeUp is unlocked, else 0. It then calls
`PlayerCommonData.Initialize(awakenLv)` (0x26DD6A0), which sets `_awakenValue` = 3 + awakenLv.
All presenters reach it through `InGameManager.Initialize`, Arcade included (ArcadePlayPresenter 0x222198D).
**So Arcade does apply awakenLv** from the save's unlocks.
`UpdateParamsByPlayMode` (0x1CED730) changes only the bullet area and distance.
Story and Arena call SetArmLevel with a chosen start level. Arcade does not, so it starts at level 0 [the default level
0 is unconfirmed].

## 3. HUD

`InGameViewUI.PlayerUI.SetValue` (0x1D3DAE0) calls
`uiArmLevel.SetValue(nlamp = _armSubLevel, nlevel = _armLevel + 1, isLevelup = _isArmLevelUp)`.
That is `InGameValueLevel.SetValue` (0x1DD2640).

- The `PowerLevel.prefab` HUD part has 3 lamps (`LampA`×3) and a 2-digit `armNumber` TXESpriteValue.
- Levels 4 and 5 just show the number **5** or **6**, with the same icon and lamps. No special awaken icon or lamp
  exists in this path.
- On a level-up all lamps light for 2 frames. Otherwise the lamps show the sub-level.
- The view prefabs might override this [unconfirmed]; they were not checked.
