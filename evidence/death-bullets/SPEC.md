# Death bullets and damage bullets: native rules (TATSUJIN EXTREME, GameAssembly.dll IL2CPP x64)

This is a read-only study. The RVAs come from `code/methods.jsonl`. The annotated disassembly is in `dis/`, and the tools are in `tools/`:

- `ddis.py` wraps `bosses/Bos08/tools/bdis.py`, with field maps for bullets, ground enemies and the tree.
- `callers.py` finds direct callers.
- `vslot.py` gives vtable slots and scans for virtual callers.
- `xref.py` finds methods that reference a TypeInfo or MethodRef slot.
- `immscan.py` finds `mov r8d, imm` instructions.
- `templates.py` dumps the templates and selectors from `enemy-attacks.json`.

Run them with `C:\Python311\python.exe -I tools\<x>.py`. Markers: [I] means inference, [?] means unknown. Everything else is read directly from the code.

Enums used below:

- `attackType`: none -1, blue..pink 0..6 (player weapons), bomb 100, stageClear 110, friendlyFire 111.
- `InGameManager.Phase`: Initialize 0, StartDemo 1, PlayStart 2, Playing 3, Dead 4, CheckRetry 5, SetRetry 6, GameOver 7, StageClear 8, StageExit 9, Terminate 10, DebugMode 11.
- `PlayMode`: STORY 1, ARCADE 2, ARCADE2 3, TEAM 10, RUSH 11, TUTORIAL 100.

## 1. Enemy death bullet: `PawnEnemy._deadBullet` / `_deadBulletSelecter`

**Fields.** `PawnEnemy` +0xF0 `_deadBullet` (string), +0xF8 `_deadBulletSelecter` (string), +0x100 `_deadBulletCache` (BulletTemplate), +0x130 `_causeOfDeath`, +0x134 `_deathByPno`, +0x15C `_explosionOffset`. All of these are declared on `PawnEnemy` itself, so every `PawnEnemy`, `PawnEnemyGround`, `ObstacleEnemy` and boss shares one rule.

### 1a. Choosing the template: `UpdateDeadBulletCache` 0x1D10BA0

```
name = _deadBullet
if (!IsNullOrEmpty(_deadBulletSelecter)):
    sel = InGameResident.GetBltSelecter(_deadBulletSelecter)      // 0x1D219C0, dict _bltSelecters
    if (sel) name = sel.GetBT(RandomUtility.Make01())              // 0x1D61030
_deadBulletCache = IsNullOrEmpty(name) ? null : InGameManager._bulletManager.GetTemplate(name)   // 0x1CCB7B0
```

- **When it runs.** It is called only from `PawnEnemy.InitializeToPlay` 0x1D0DE30 (reached from `InGameStage.SetupEnemy` → `InGameEnemyManager.InitializeToPlay` 0x1CD5C30) and from `ResetParameters` 0x1D0F620 (reached from `InGameManager.RefreshStage` → `InGameEnemyManager.ResetEnemyParameter` 0x1CD6570). The roll is therefore made once for each pooled instance when the stage is set up or refreshed, not on each spawn or at death [I: a pooled instance that is reused keeps its roll].
- **Selector mode.** It is the same mechanism as the normal bullet selectors. `InGameResident.SetPlayMode` 0x1D220E0 calls `SetCurrentMode` 0x1D61390 with the raw `PlayMode` on every selector, and `SetCurrentMode` keeps the sheets whose `pmode` equals that mode. If there are none, it falls back to `pmode` 0.
- **`GetBT(t)` rule.** For each sheet in order: `t -= _rate`; if `t <= 0`, return that sheet's `_btName`. If no sheet is chosen and the list has exactly one sheet, return it. Otherwise return "" (no bullet). Because of the one-sheet rule, a single sheet with `_rate` 0 is always chosen.

### 1b. Firing: `PawnEnemy._callDeadEffect` 0x1D10E20 (vtable slot +0x588)

Call paths:

- `PawnEnemy.ToDestroid` 0x1D108C0 calls `_callDeadEffect`, then `CallDisabled`.
- `ToDestroid` is called by `HybridCollisions.AddDamageOwner` 0x1DDF0D0 when the accumulated damage reaches HP.
- `PawnEnemyDD.ToDestroid` calls it at the moment of the kill, before its delayed explosion sequence.
- Bosses call it from `PatternMoveDestruction`, at the end of the destruction sequence. `Ene_BosBase._callDeadEffect` 0x1DBAEB0 runs it once (`_isDeadEffectCalled`), with a camera shake of (1, 3, 1).
- The overrides `PawnEnemyGround` 0x1D17FE0 (drop item and ruin), `Mp01`, `Mp02`, `Mx02`, `X01`, `Mf01`, `Mi01`, `Ml01` and `RookEnemy` all add their own work and then call the base unconditionally. No subclass changes the bullet rule.

```
pos = transform.TransformPoint(_explosionOffset)                       // world
if (_deadExplosionHash != -1) ExplosionQue(...)                         // explosion is independent of the bullet
if (_causeOfDeath == stageClear(110) && _deathByPno < 0) return         // stage-clear sweep: no bullet, no pipil
sky = InGameManager.GetSkyRootPosition(pos, IsGround())                 // 0x1CE6750
if (!InGameManager.IsGameArea(sky)) return                              // 0x1CE7580
if (IsCauseOfDeathNormal(_causeOfDeath) && _deadBulletCache)           // 0x1D0E5A0: (uint)c <= 99 || c == 111
    InGameManager.DirectBulletFire(_deadBulletCache, sky)               // 0x1CE34C0
if (_deathByPno >= 0 && !_isResultDone) { pipil count / PipilDrop }     // unrelated to the bullet
CollisionFinish()
```

**Position.**

- `GetSkyRootPosition` projects the point with the game camera (the ground camera for ground enemies) into the viewport, then onto the sky plane (`ViewportToPlanePos`). It then clamps plane y to [-3, 3] in the air and [-10, 10] on the ground.
- `IsGameArea` tests the viewport against `gameScreenArea`, which is (-0.15, -0.15, 1.3, 1.3) per `Round1EnemyWaves.cs`. A death within 15 % outside the screen still fires.

**Which deaths fire.** `_causeOfDeath` is written only on the first lethal hit, by `SetCauseOfDeath` 0x1D0F680 (first write wins):

| Cause | Origin | Death bullet |
|---|---|---|
| player shot or laser (0..6) | `WeaponCollisionBase._damageToEnemy` 0x1D58D60. When `IDamagedObject.IsAliveDamaged` (interface slot 2) is false, it calls `SetCauseOfDeath(pno, weapon._attackType, exboost)` (slot 7); otherwise `HitBlink` (slot 6) | **yes** |
| friendlyFire 111 | `Ene_Bos04.OnHitProgress` (guardians) | **yes** |
| bomb | `WeaponBombCollision.OnMultiProgress` uses 100 only for `GetTolerance` and never calls `SetCauseOfDeath`, so the cause stays -1 | **no** |
| stage clear | `InGameEnemyManager.DeadEnemys` 0x1CD3810: `SetCauseOfDeath(-1, 110)` then `ToDestroid` | **no** (early return) |
| ship body | `PawnEnemy.OnHitProgress` 0x1D0EB10: an air enemy touching the player layer only calls the player's damage; the enemy takes no damage | **no** (enemy does not die) [I] |
| leaves the screen / route ends | `ProgressDisable` / `CallDisabled` without `ToDestroid` | **no** |
| killed but `sky` outside `gameScreenArea` | | **no** |

**What does not gate it.** There is no gate on difficulty, rank, loop, distance to the player, minimum alive time or `IsFireDistance`/`gameBulletArea`. The only mode dependence is the selector's `pmode`. The fire volume is 1.0.

### 1c. `InGameManager.DirectBulletFire(bt, cpos)` 0x1CE34C0

```
if (!_bulletManager || phase in {1,2,4,6,7,8,9,10}) return              // fires in Initialize 0, Playing 3, CheckRetry 5, DebugMode 11
arc = 0
if (bt.isTarget(+0x7C) && phase in {Playing 3, DebugMode 11}):
    i = clamp(GetNearestPlayerIndex(LocalToScreen(cpos)), 0, PlayerMax)  // nearest by screen distance
    arc = bt.GetLimitArc(InGameBulletManager.GetTargetBulletArc(cpos, _playerSkyPosition[i]))
_bulletManager.BulletFire(gm, rlist=null, bt, cpos, nlap=0, selfT=null, dirT=null, selfM=null,
                          startArc = bt.nStartArc - arc, speedRate = 1, sevol = 1, callback = null)
```

- The aim uses the same `GetTargetBulletArc` and `GetLimitArc` as normal aimed fire. Normal fire computes `nStartArc - targetArc + selfArc + base`; a death bullet has no self or muzzle rotation. The normal-fire target is `GetPlayerBulletPosition`; here it is `_playerSkyPosition` [I: the same point, or close to it].
- `nlap = 0` means `GetWay` and `GetWayArc` use `bulletType`/`nArc`, not the `nRapidWaySwitch` values.
- Because `selfT` is null, `isSelfDir` templates (mi01, mo01) fire at their fixed `nStartArc` [I].
- Bullet speed is the usual `_aSecondPass` × `_bulletSpeedScale` × `nSpeed`.

### 1d. Data (OriginalRecovered prefabs, `enemy-attacks.json`)

| Prefab | Field | Template: bullet, ways, nArc, nStartArc, aim | HP | `_explosionOffset` |
|---|---|---|---|---|
| Sg01 | `sg01_fired` | 008, 1, 0, 270, aimed | 20 | 0 |
| Mg01 | `mg01_fired` | 008, 3, 45, 270, aimed | 20 | 0 |
| Mi01 | `mi01_fired` | 008, 8, 360, 270, fixed ring | 100 | 0 |
| Mo01 | `mo01_fired` | 009, 4, 360, 45, fixed X | 100 | 0 |
| Bg04_Grass | `bg04_grass_fired` | 008, 3, 45, 270, aimed | 100 | (20, 0, 0) |
| Sj01, Su01 | `sj01_fired_sel` | `sj01_fire` = 001, 1-way, aimed | 20 | 0 |
| Sh01 | `sh01_fired_sel` | `sh01_fired` = 009, 1-way, aimed | 20 | 0 |
| BSc01 | `bsc01_fired_sel` | `bsc01_fired` = 009, 1-way, aimed, nLimitArc 3 (_div16) | 50 | (0, 10, 0) |
| BMa01 | `bma01_fired_sel` | `bma01_fired` = 009, 1-way, aimed, nLimitArc 3 | 200 | (0, 20, 0) |

Chance of a bullet by mode:

| Selector | pmode 0 fallback (Story, Team, Tutorial) | Arcade 2 | Arcade2 3 | Rush 11 |
|---|---|---|---|---|
| `sj01_fired_sel` | 30 % | 60 % | 100 % | 30 % (fallback) |
| `sh01_fired_sel` | 50 % | 100 % | 100 % | 100 % |
| `bsc01_fired_sel` / `bma01_fired_sel` | 0 % (one "" sheet) | 0 % (fallback) | 100 % (one sheet with rate 0) | 0 % |

## 2. Damage bullet: `Ene_bg05tree._damageBullet` (Pf_BGObj_tree01b_upper)

**Class.** `Ene_bg05tree` derives from `PawnEnemyGround`. Fields:

| Offset | Field | Prefab value |
|---|---|---|
| +0x200 | `_damageBullet` | `bg05Tree` |
| +0x208 | `_bt` | |
| +0x210 | `_damageExpOffsetY` | 15 |
| +0x214 | `_damageShotWays` | 8 |
| +0x218 | `_damageShotCount` | 5 |
| +0x21C | `_damageCounter` | |
| +0x220 | `_nextLevel` | |
| +0x228 | `_muz` | |
| +0x230 / +0x234 | `_shotRangeL` / `_shotRangeH` | 5 / 35 |

The prefab also has HP 100 and `_explosionOffset` (0, 20, 0). Its `_deadBullet` is empty, so the tree has no death bullet.

**Methods.**

- `InitializeToPlay` 0x1D860B0: `_bt = bulletManager.GetTemplate(_damageBullet)`.
- `ReStart` 0x1D861A0: `_damageCounter = 1`; `_nextLevel = HP / _damageShotCount` (= 20).
- `AddDamageOwner(n)` 0x1D85D20 overrides the owner damage, so it runs for every damage source, the bomb included [I: the bomb uses the same `model.AddDamage` slot +0x258].

```
died = base.AddDamageOwner(n)                         // _Damage += n, clamped to [0, HP]
if (_Damage > _nextLevel && !died):
    c = _damageCounter++
    if (c > _damageShotCount) return false
    _nextLevel = (c + 1) * HP / _damageShotCount
    _fire()
    ExplosionQue(at TransformPoint(_explosionOffset + (0, _damageExpOffsetY, 0)), ShortCutEffect code[+8], ground layer)
    AddShake(0.5, 1, 8)
```

**When it fires.**

- It fires when accumulated damage passes HP·k/5 for k = 1..4, so at 20, 40, 60 and 80 damage on HP 100. That is at most 4 volleys.
- The fifth threshold equals HP, which is the kill, and the kill does not fire (no damage bullet on the killing hit).
- One hit advances at most one threshold.
- There is no timer or cooldown.

**`_fire` 0x1D867C0.**

```
m   = _muz.position (world)
sky = GetSkyRootPosition(m, ground=true)
p   = GetPlayerSkyPosition(GetNearestPlayerIndexInWorld(m, true))
arc = -(GetTargetBulletArc(sky, p) + 90)               // one aim for the whole volley; no GetLimitArc
for i in 0.._damageShotWays-1 (8):
    r = Random.Range(5, 35)
    a = i * 360 / 8                                     // degrees (VectorUtility.Cosf/Sinf)
    q = (m.x + cos(a)·r, m.y, m.z + sin(a)·r)           // ring around the muzzle in the ground (xz) plane
    InGameManager.BulletFire(_bt, GetSkyRootPosition(q, true), nlap=1, startArc=arc, rate=1,
                             emitModel=_mover, emitSelf=transform, emitDir=null, cb=null, seVol=1)
```

**Template `bg05Tree`.** enemybullet002, 1-way, nArc 6, nStartArc 270, isTarget 0, nRapidWaySwitch 0, so `nlap = 1` has no effect. Each volley is 8 single bullets spawned on a random-radius ring around `_muz`. Each bullet flies at `startArc` = −(aim + 90) [I: `InGameManager.BulletFire` adds the template's `nStartArc`/`isTarget` handling; aim convention as in `Round1EnemyAttacks.AimAngle`].

## 3. Bullet-side death bullet: `InGameDestuctible._deadBullet` (enemybullet011 / 011s)

**Class.** `InGame.Kernel.InGameDestuctible` (sic) derives from `InGameBullet`. Fields: +0xF0 `_deadBullet`, +0xF8 `_bt`.

| Prefab | HP | `_kindType` | `_colorType` | lock-on | `_deadBullet` |
|---|---|---|---|---|---|
| enemybullet011 | 1 | 11 | 3 | no | `Regident/Sepper0_3way` |
| enemybullet011s | 1 | 11 | 3 | no | `Regident/Seppers_3way` |

**Initialize** 0x1CCF730: `_bt = bulletManager._bulletTemplate[_deadBullet]`, or a `BulletTemplate.SetDefault()` instance if the name is missing.

**Hits.**

- `IsHitEnable` 0x1CCF8B0: the bullet can be hit when it is alive, `_invincibleTime <= 0`, and object flag 1 is not set.
- `IsBomberRange` is true, so the bomb hits it, and `IsBombered` is false.

**Firing: `SetCauseOfDeath(pno, atk, ex)` 0x1CCF930.** The player's lethal shot calls it through `_damageToEnemy` (the bullet has HP 1, so any player hit is lethal).

```
if (_causeOfDeath == -1):
    if (atk != bomb 100 && atk != none -1 && atk != stageClear 110):          // same as IsDividedCause 0x1CCF890
        InGameManager.BulletFireAsync(_bt, transform.localPosition, cpost=null, ctoken=null,
                                      generateCallback = b => if (b is InGameDestuctible) b._invincibleTime = 0.5,
                                      sevol = 1)                                // 0x1CE2600
    _causeOfDeath = atk; _deathByPno = pno
```

**When it fires.**

- It fires only when the bullet is shot down by a player weapon (0..6, or 111).
- It does not fire on a bomb, on a stage clear, when the bullet's lifetime ends or it leaves the screen, or when it hits the player. `InGameBullet.OnHitProgress` 0x1CCE460 only damages the player and calls `AddDead`.

**Position and aim.**

- It fires from the bullet's own `localPosition`, which is already sky-plane coordinates.
- `BulletFireAsync` (d__303 0x1D25750) is gated by `IsEnemyBulletPhase`.
- When `bt.isTarget` is set and `IsPlayerShooting`, it aims at `GetPlayerSkyPosition(GetNearestPlayerIndexInLocal(pos))` through `GetTargetBulletArc` and `GetLimitArc`, with `startArc = nStartArc - arc`.

**Templates.**

- `Sepper0_3way`: enemybullet001, 3-way, nArc 60, nStartArc 270, aimed.
- `Seppers_3way`: enemybullet011, 3-way, nArc 60, nStartArc 270, aimed, nFirePosRadius 3.
- So an 011s shot down becomes 3 × 011, which cannot be hit for 0.5 s. Each 011 shot down becomes 3 × 001.

**The `Regident/` prefix.** It is a misspelling of "Resident". These templates are not per stage:

- `InGameResident._regidentBullet` (BulletPalette `InGameReference/Resident/BulletPallet.asset`, names `Regident/Sepper0_3way` and `Regident/Seppers_3way`) is returned by `GetRegidentBulletNames` 0x1D21ED0.
- `InGameStage.SetupEnemy` (d__3) adds these names to every stage's template load list. The assets are at `InGameReference/BulletTemplate/Regident/`.
- They are keyed with the prefix included. Enemy data also refers to `Regident/Sepper2_1way` (ene_mg01_2) and `Regident/Seppa3_0` (ene_mg02) [?: not in the recovered palette].

## 4. What the reconstruction lacks

`Round1Combat.Damage`/`Deactivate`/`Bomb`, `Round1EnemyAttacks`, `Round1GroundEnemies`.

1. **No cause of death.**
   - `Round1Combat.Damage` has no cause, and `Bomb()` calls the same `Damage`.
   - Add `Damage(target, dmg, cause)`, recording the cause on the lethal hit only (first write wins).
   - The bomb and `ClearRegularEnemies`/stage clear must not fire death bullets; route ends and escapes already deactivate without a kill.
2. **No death bullet.**
   - On a kill caused by a player weapon: `name = deadBullet`, or `Select(selector, mode, roll)`, with the roll made once per enemy instance at stage set-up (one roll per spawn is acceptable [I]).
   - Fire point: TransformPoint(`_explosionOffset`), projected to the sky plane, and only if the viewport is inside (-0.15..1.15). The air y clamp is ±3 and the ground ±10.
   - Fire once with `nlap` 0, no muzzle, no `selfDir`, no range or bullet-area gate. Aim at the nearest player only when `isTarget` is set, using `AimAngle` (including `nLimitArc`). Not in the player Dead/Retry/Clear phases.
   - The same rule covers air, ground and boss enemies.
   - **Wrong mode:** `ArcadeSelectorMode = 0` gives the pmode-0 rows (sj01 30 %, sh01 50 %, bsc01/bma01 0 %). Native Arcade passes PlayMode 2 (60 % / 100 % / 0 %) and Arcade2 passes 3 (100 % for all four). The selector mode must be the real PlayMode value.
3. **Tree damage bullets (bg05).**
   - Port the volleys at HP·k/5, k = 1..4, from any damage source (bombs included).
   - Each volley: 8 `bg05Tree` bullets from a ring of radius U(5, 35) around `_muz`, all at `startArc = −(aim + 90)`.
   - Each volley also plays an explosion at `_explosionOffset` + (0, 15, 0) and a shake of (0.5, 1, 8).
4. **Destructible bullets (011 / 011s).**
   - Hostile bullets need HP 1, must be hittable by player shots (not lock-on targets), and must be bomb-cleared without splitting.
   - On a player kill they fire the resident 3-way from their own position, aimed. The children of 011s are invulnerable for 0.5 s.
   - The resident templates `Sepper0_3way` and `Seppers_3way` need to be added to the attack library (they are already in `enemy-attacks.json`, without the prefix).
