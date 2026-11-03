# Ene_Bos01 (BG01 boss, "Gashim") — behaviour spec from native code

Source: `D:\games\Truxton Extreme\GameAssembly.dll` (IL2CPP x64). Every Ene_Bos01 method was disassembled
(`dis_all.txt`, made by `dis.py`; base class in `dis_base.txt`). Constants: `bos01_constants.json`; wing attack tables:
`wing_patterns.json` (`parse_cctor_patterns.py`); reference timeline derived from the decoded logic: `sim_timeline.txt`
(`sim.py`, not original code). Tags: **[I]** inferred, **[?]** unknown. Addresses are RVAs.

Summary: the boss has **no HP phases**. Ene_Bos01 never reads `_hpState` or the HP rate. It runs one fixed loop:
`EntryWait → PT1 (dive) → PT2 (wing+body laser sweep, return home) → PT6 (home hover: 3 wing patterns + core rings) → PT1 …`
until it is killed, then `Destruction`. Only the 8 shoulder cannons can be broken. The wings cannot take damage.

## 1. Identity

| item | value | source |
|---|---|---|
| class | `InGame.Kernel.Enemy.Ene_Bos01 : Ene_BosBase : PawnEnemy` | types.jsonl |
| prefab | `Reconstructed/Assets/OriginalRecovered/Samples/Prefabs/Reference/Enemy/Pf_Ene_Bos01.prefab` (model root `pf_bs01`, no Animator) | prefab |
| EnemyData | `ene_boss01`: model Pf_Ene_Bos01, attribute 1072, duration 100, position (0,0,200), placement rotate (0,180,0), moveSpeed 20, lookAt 1, no routes, one event type 1001 at t=0 | `Resources/StageEnemies/BG01.json` |
| spawn | timeline clip `main/tt_boss01`, EnemyEntryClip start **362.0 s**, end 480.0 s | BG01.json events |
| HP (database row 27 `Bos01`) | 500000, score 100000, pipil 100, jewel 100, lockOn, rateTarget, blocksLaser, size BOSS, galleryNo 10007 | enemy-database.json |
| bullet templates | `_btNames` = Boss01/bos01laser01, bos01laser02, bos01bullet01, bos01bullet10, bos01bullet11 (enum Boss01BT 0..4). `Ene_BosBase.InitializeToPlay` also calls `ChangeSE(B004, 106 enemybullet013_01)` on each one | .cctor 0x1d7bf30, 0x1db9a90 |
| summons | `_asteroidEnemyClipNames` = ene_asteroid_bs_l_l, m_l, s_l, l_r, m_r, s_r (GetBossCD → CallEnemyClip index 0..5) | .cctor |
| death FX | prefab `_deadExplosion` pf_eff_explposion_boss, `_overplayDeadSound` 41 exp_st3_boss_b02, `_explosionOffset` (0,0,0) | prefab |
| trophy | `ToDestroid`: if IsTrophy → `TXEResident.SetTrophy(9 Gashim)` | 0x1d7b6b0 |

### Parts (PartsList order = PartsKind enum = `GetParts(i)` index)

| # | part | DB row (HP) | prefab root / collision | BreakEffect | notes |
|---|---|---|---|---|---|
| 0 | core (MasterBody) | uses the Bos01 row, 500000 | pf_bs01/body, collision bodyout (circles (0,−15) r19, (0,7) r19) | — | damage object body/damage |
| 1 | wingR | 36 (200000) | body/wing40, collision shoulder_rwing (12 circles r9.375 at z −12.5) | — | **NoDamage**: `ReStart` calls `GetParts(1).ChangeCollisionsAttribute(NoDamage=16, true)` |
| 2 | wingL | 37 (200000) | body/wing60, collision shoulder_lwing | — | NoDamage (same call) |
| 3–6 | shoulder_r1..r4 | 32–35 (50000 each, pipil 50, jewel 10) | wing40/cannon 41, 42, 43, cannon44 | pf_eff_explposion03 | breakable |
| 7–10 | shoulder_l1..l4 | 28–31 (50000 each) | wing60/cannon 61..64 | pf_eff_explposion03 | breakable |

All rows have isLockOn = true. GetStart (0x1d79470) sets object flags **OffLockon|NoDamaged (0x22)**. PT1 clears them
5 s into the first dive (§3). `IsHitEnable` (0x1d799c0) = `IsAlive() && InGameCollisionBase.IsHitEnable()`. Homing
(`GetHormingTarget` 0x1d79310) checks parts `(targetIndex+k) % 11` for k = 0..10 and returns the world position of the
first unbroken part's `_collisions[0]`. If every part is broken it falls back to the base method.

`OnHitProgress` (0x1d79a10): if the other collider is on a neutral layer (`LayerUtility.IsNeutral`) and its root owner is
of class TypeInfo#41901 (**[I]** MeteoEnemy: the meteors are MeteoEnemy on layer 14), the boss calls that owner's
vslot 28 `AddDead()`. In other words, **the boss destroys meteors it touches**. Any other hit goes to `PawnEnemy.OnHitProgress`.

## 2. Frame and units

The source sky plane has x right, z up the screen and y toward the camera. The camera is at (0,400,0) and looks down
with a 20° vertical FOV, so the visible half-height is ±70.5. Every position below is the boss transform's
`localPosition` (`_transformCache`, +0x50) in its parent enemy layer. The spawn placement yaws the root by 180°
**[I]**, so model +z points down the screen at the player and model x is mirrored on screen. Code side "L"
(bits L*, BodyL, WL*) = the `*40` transforms = model −x = **screen right**. Database parts named `_r` are on that same
side. Code "R" = the `*60` transforms = screen left **[I]**.

Prefab-space points (before the yaw; `prefab_tree.py`):

| transform | pos | forward |
|---|---|---|
| body/body_laser_muzzle40 (BodyL) | (−10.85, 0, 23.25) | +z |
| body/body_laser_muzzle60 (BodyR) | (10.85, 0, 23.25) | +z |
| body/body_muzzle50 (Core) | (0, 12.5, −3.5) | +z |
| wing40 / wing60 pivots | (∓11.06, 0, −15) | — |
| shoulder cannons 41..44 / 61..64 (pivot) | x = ∓38.35, ∓63.68, ∓89.01, ∓114.17; z ≈ −5.3 | see §5 |
| cannon aim targets cannonNNt | same x, z = +10 | — |
| wing muzzles psrts 41..45 / 61..65 `/muzzle` | x = ∓25.68, ∓51.01, ∓76.35, ∓101.68, ∓127.01; z = 7.97; child `target` 1 unit further along +z | +z |

## 3. State machine (`Boss01State`: EntryWait 0, PT1 1, PT2 2, PT6 3, Destruction 4)

`Ene_BosBase.LocalLateUpdate` (0x1db9ff0): while `IsPlayingState()` and dt > 0, it runs `ProgressBossTimer(dt)`
(boss clock, direction clock, `UpdateHPState`) and then `StateExec(dt)` (0x1d7b330). Each StateExec frame runs these
steps in order:

1. **Wings** (`_isWingMove` is always true): if `_isWingOpen`, `_wingArc += 0.5·dt`; otherwise `_wingArc −= 1·dt`.
   The value is clamped to [0,1]. While it changes, `SetWingAngle(EaseInOut(90, 0, arc))` is applied.
   `isWingMoving` = the arc changed this frame.
2. **Body**: `isBodyMoving = UpdateVelocityMovement(dt)` (§4).
3. **Shoulder cannon rolls**: `isCannonRotating = (_cannonBits != _orderBits)`, captured before the loop. For each
   i < 8 whose bit differs, `CannonData.Roll(dt, orderBit)`. When Roll reports it is finished (or the cannon is dead),
   copy the order bit into `_cannonBits`.
4. `isHomeLooping`: `_isHomeMove` is never set true (only ReStart writes it, with 0), so this is always true.
   `UpdateHomePositionInInfinityLoop` (figure-eight 10×1 over 8 s) never runs. It is dead code.
5. `_stateWaitTime −= dt` while it is > 0.
6. Dispatch on `_state`.

`SetBossState(s)` (0x1d7b200): if s differs from the current state, set `_state = s`, `_patternMode = 0` and
`_movementSpringScale = 1`.

### ReStart (0x1d7ace0)
`SetWingAngle(90)` (closed), `_isWingMove = 1`, `_isWingOpen = 0`, `_wingArc = 0`, `_homeStaySecond = 0`,
`_cannonBits = _orderBits = 0xFF` (all shoulder cannons in laser pose), `_wingLaserBits = 0x1FF800` (every wing muzzle
fires lasers), `_isPhysicsMove = 0`, `_velocity = 0`, `_movementTarget = localPosition`, `_pt1StartTime = 0`,
`_pt1WaitTime = 5`, `_state = EntryWait`, `CreateToken()`, `_mover+0x191 = 1`. Each CannonData gets a linked
cancellation source, `_isAlive = 1` and `_openRate = 1`, and its base transform is set to `localRotation = Euler(−90,0,0)`.
Wing logic gets `_state = Executing`, `_currentPatternIndex = 0`, `_timeline = 0`, `_lastCommandIndex = −1`, the
active list is cleared, `_cycleCompleted = 0` and `_isLeftAsteroidTurn = 1`. Core logic gets mode 0 and wait 10.
Wings 1 and 2 get NoDamage. `_isEntry = 1`. `Initialize` (0x1d794c0) also sets `_mover._isForceFire = true`.

### EntryWait (inlined in StateExec, the same code as PatternMoveEntry 0x1d7ac40)
Wait until `_mover._isFinishDelay` (+0x2B8). Then `PlayQue(101 bg1_boss_mothership_02)`, `SetBossState(PT1)` and
`_orderBits = 0xFF`.

### PT1 — dive to the rush point (PatternMove1 0x1d79c70)
- mode 0: `_localTime = 0`, `_pt1StartTime = 0`, `_hoverTimeOffset = 3π/2 − fmod(3, 2π) = 1.712389`. If the wings are
  open, `PlayQue(107 bg1_boss_wing_close_01)`. Then `_isWingOpen = 0` and mode 1.
- mode 1, each frame: `_localTime += dt`, `_pt1StartTime += dt`, `blend = clamp01(_localTime/1.5)`,
  `_movementTarget = (0, 0, −30 + 5·sin(2·_pt1StartTime + 1.712389)·blend)`, `_isPhysicsMove = 1`.
  When `_localTime ≥ _pt1WaitTime`: on the first visit only (`_isEntry`), clear `_isEntry`, call
  **ResetObjectFlag(OffLockon|NoDamaged)** and `ResetBossTimer(true)`, which starts the boss clock `_bossAliveTime`.
  Then `SetBossState(PT2)`.
- `_pt1WaitTime` is 5 s on the first dive and 2 s on every later dive (set by PT6).

### PT2 — laser sweep, then return home (PatternMove2 0x1d79ef0)
- While mode < 11, the hover continues with the same clock and phase:
  `_movementTarget = (0,0,−30 + 5·sin(2·_pt1StartTime + _hoverTimeOffset))`.
- mode 0: `_isWingOpen = 0`, `_orderBits = 0xFF`. If `!isWingMoving`, go to mode 10.
- mode 10: once `!isCannonRotating`, force `_wingLaserBits |= WingAll` and call
  **`FireCannons(Wing|Body = 0x1FFB00, 0, laser02)`**: every one of the 10 wing muzzles plus BodyL and BodyR fires
  bos01laser02. The shoulder cannons and the core do not fire. Then restore `_wingLaserBits`, set
  `_stateWaitTime = 1.0` and go to mode 11.
- mode 11: when the wait is over: if the wings are closed, `PlayQue(105 bg1_boss_wing_open_01)`. Set
  `_stateWaitTime = 0.1`, `_movementTarget = _homePosition (0,0,40)` and `_movementSpringScale = 0.4`, then mode 12.
  The hover stops from this mode on.
- mode 12: when the wait is over, `_isWingOpen = 1` (the wings open over 2 s), then mode 13.
- mode 13: when `|localPosition − (0,0,40)| < 0.5` (checked only, the boss can overshoot), `_localTime = 0`, mode 14.
- mode 14: `_localTime += dt`. At ≥ 1.5 s, `SetBossState(PT6)`.

### PT6 — home hover with the wing patterns and the core rings (PatternMove6 0x1d7a2c0)
- mode 0: `WingAttackPatternLogic.Initialize()`, core logic set to mode 0 with wait 10 and 0 shots,
  `_pt1StartTime = 0`, `_hoverTimeOffset = 0`, `_movementTarget = home`, `_velocity = 0`, `_isPhysicsMove = 1`, mode 1.
- Each frame: `_pt1StartTime += dt`, `_movementTarget = (0,0,40 + 5·sin(2·_pt1StartTime))`, then
  `WingAttackPatternLogic.Update(dt)` (§5.2; its three bool arguments are ignored). If `_cycleCompleted`, clear it, set
  `_pt1WaitTime = 2` and `SetBossState(PT1)`, then return. Otherwise run the core logic (§5.3).

### Destruction (ToDestroid 0x1d7b6b0 → PatternMoveDestruction 0x1d7a5f0)
Death starts when HP reaches 0 and the base calls the `ToDestroid` override. The override sets the trophy, then calls
`StopBossTimer()` (`DisabledAllParts`, boss-destroy points, `SetBossTime`), `_mover.DeleteRouteToken()` and
`ReleaseToken()` (**[I]** this cancels the token-owned fire tasks and lasers in flight), then `SetBossState(Destruction)`.

| mode | action |
|---|---|
| 0 (one frame) | `_isPhysicsMove = 0`. `_startVector = localPos`; `_targetVector = localPos + (0, −150, 0)` (falls away from the camera). `_startAngle = localRotation`; `_targetAngle = Euler(20,135,0)`. 4 × `SkyExplosionEffect(ExplosionCodeMiddle, GetSmallBombPosition(), EnemySkyLayer, seID −1)` (silent). `AddShake(0.5, 1, 2)`. `SetSmallBombSecond(0.2)`. `SetDirectionTime(5.5, 1)`. `_localTime = 3.5`. mode 10. |
| 10 | `localPosition = Lerp(start, target, Easing01(rate, EaseIn))` (**[I]** EaseIn = rate²). `localRotation = Quaternion.Lerp(startAngle, targetAngle, rate)`, with `rate = clamp01(directionPassed/5.5)`. `_localTime −= dt`. At ≤ 0: `AddShake(0.5, 1, 5)`, **`_callDeadEffect()`** (vslot 69: pf_eff_explposion_boss + sound 41, camera shake (1,3,1), vibration), `_localTime = 2`, mode 11. Each frame, if `IsCallSmallBomb(dt)`: `SkyExplosionEffect(ExplosionCodeSmall, GetSmallBombPosition(), EnemySkyLayer, 40 exp_st3_boss_a01)` and `AddShake(0.5, 1, 5)`. |
| 11 | Same fall, rotation and small bombs. `_localTime −= dt`. At ≤ 0: mode 30. |
| 30 | `PlayQue(42 exp_st3_boss_c03)`, then `Ene_BosBase.ToDestroid()` (vibration if no longer alive, then `PawnEnemy.ToDestroid`, which ends the boss). Total time is about 5.5 s, the length of the fall. |

`GetSmallBombPosition` (0x1d793f0) = world position of `_cannons[RandomUtility.Range(1,8) − 1]` (inclusive range, so any
of the 8 cannon pivots, broken or not). Base `IsCallSmallBomb` (0x1db9e90): `cur −= dt`. At ≤ 0:
`cur = base + rand01·0.1`, `base *= 0.9`, plus a player vibration (0.4, 0.1, base) unless the dead effect has already
played. `AddShake(nsec, npow, nspeed)` only stores the three values into `_burnShake`, `_burnShakePow` and
`_burnShakeSpeed`. Raw values are given in argument order. The names of the Destruction_* constants suggest the
order (amount, speed, time).

## 4. Movement (UpdateVelocityMovement 0x1d7ba80)

The model is a damped spring toward `_movementTarget`. It runs only while `_isPhysicsMove`, with sub-steps
h = min(remaining, 0.05):

```
k = 8.0 * _movementSpringScale ; c = 5.6 * _movementSpringScale
d = target - pos ; v += (k*d - c*v) * h ; pos += v * h          (localPosition)
moving |= |v|^2 > 0.01 || |d|^2 > 0.01    (tested before and after each step)
```

With scale 1 the spring is about critically damped (ω 2.83, ζ 0.99). With scale 0.4 it overshoots (ω 1.79, ζ 0.63).
Derived trace (sim.py, spawn at z = 200): z = 105 at 0.5 s, 22 at 1.0 s, −14 at 1.5 s, −28 at 2.0 s, then a hover around
−30 ± 5. On the way home the boss overshoots to about z 45 at 8 s. EnemyData moveSpeed 20 is not used by this code
**[?]** whether the mover itself translates a route-less boss.

Wings: `SetWingAngle(a)` sets wing60 `localRotation = Euler(0, +a, 0)` and wing40 `Euler(0, −a, 0)`, with
`a = EaseInOut(90, 0, arc)`. EaseInOut (0x1de7fa0) is the quadratic in-out: v' = 2v; v' < 1 → s + (e−s)/2·v'²;
otherwise s − (e−s)/2·((v'−1)(v'−3) − 1). Closed (a = 90°) means the wings are swung back along the body. Opening
takes 2 s and closing takes 1 s. The cannons, wing muzzles and wing hit circles are wing children and move with them.

Shoulder cannon pose (`CannonData.Roll` 0x1d78760): toward laser, `_openRate += dt`; toward bullet, `_openRate −= dt`.
The value is clamped to [0,1], and each change sets `base.localRotation = Euler(EaseInOut(0, −90, openRate), 0, 0)`.
A full roll takes 1 s. Roll returns true while it is moving and false when the cannon is dead. The `cannon NN` parents
are rotated +90° about x, so openRate 1 (−90°) points the cannon along model +z with `laser_cannon_muzzle` (local z +12)
in front. openRate 0 points it into the screen with `cannon_muzzle` on top. `GetMuzzle()` returns
`openRate < 1 ? cannon_muzzle : laser_cannon_muzzle`.

## 5. Attacks

### 5.1 Fire primitives
`FireCannons(bits, param, laserTemplate)` (0x1d78a40):

| bits | condition | call |
|---|---|---|
| shoulder i (bits 0–7) | alive and openRate < 1 | `InGameManager.BulletFireForget(bos01bullet01, cannon_muzzle, _token, sevol = _ShortLaserSEVolume 0.7)` |
| shoulder i | alive and openRate ≥ 1 | `_mover.BulletDirFireAsync(cannon laser token, GetBT(laserTemplate), laser_cannon_muzzle, dirt = cannonNNt, 0)` |
| Wing bits | any | `FireWingCannons` (below) |
| BodyL / BodyR | — | `_mover.BulletFireAsync(CToken, GetBT(laserTemplate), isSelfDir=true, isNested=true, body_laser_muzzle40/60, null, 0, 0)` |
| Core | — | `_mover.BulletFireAsync(CToken, param ? bos01bullet11 : bos01bullet10, false, false, body_muzzle50, null, 0, 0)` |

`FireWingCannons` (0x1d78eb0): muzzle i (0..9) maps to bit `1 << (i+11)`. If `_wingLaserBits` has that bit and the
target exists: `BulletDirFireAsync(CToken, GetBT(laserTemplate), muzzle, muzzle/target, 0)`. With the bit but no
target: `BulletFireAsync(..., true, true, muzzle, ...)`. Without the bit: `BulletFireForget(bos01bullet01, muzzle, _token, 0.7)`.

Templates (OriginalRecovered/InGame/InGameReference/BulletTemplate/Boss01):

| template | bullet | type | key fields |
|---|---|---|---|
| bos01laser01 | enemylaser000 | 1 (laser) | nStartArc 270, nIrradiation 1, isSelfDir 1 |
| bos01laser02 | enemylaser000 | 1 | nIrradiation 2, otherwise the same as laser01 |
| bos01bullet01 | enemybullet004 | 6 | nArc 360, nStartArc 270, nRapidCount 8, nRapidDistance 0.2, isTarget 1, isRapidTarget 1, muzzle FX |
| bos01bullet10 | enemybullet002 | 8 | nArc 360, nStartArc 270, nRapidCount 1, isTarget 1 |
| bos01bullet11 | enemybullet002 | 8 | the same, nStartArc 292.5 (rotated half a step from bullet10) |

### 5.2 Wing pattern cycle (WingAttackPatternLogic; Update 0x1d89c80, ScheduleAttack 0x1d89970, ProcessActiveAttacks 0x1d895f0)
`_allPatterns = [_pattern1, _pattern2, _pattern3]`. `_pattern4` and `_pattern5` are built in .cctor but never used.
Commands are `(Time s, CannonBit, IsLaser)`. A command with `none` only marks the end time.

| pattern | commands (t: bits) | mode |
|---|---|---|
| 1 | 0 L1, 1 R1, 2 L2, 3 R2, 4 L3, 5 R3, 6 L4, 7 R4, 8 BodyL, 9 BodyR, 10 none | bullets |
| 2 | 0 L1+R1, 0.5 L2+R2, 1 L3+R3, 1.5 L4+R4, 2.5 BodyL+BodyR, 3 L1–L4, 4 R1–R4, 6 all 8 shoulders + both body, 8 none | lasers |
| 3 | 0 L4, 0.1 L3, 0.2 L2, 0.3 L1, 0.4 BodyL, 0.5 BodyR, 0.6 R1, 0.7 R2, 0.8 R3, 0.9 R4, 1.0 none | bullets |

- **Executing**: `_timeline += dt`. Every command with `Time ≤ _timeline` after `_lastCommandIndex` is scheduled.
  On the first command of a pattern (`_lastCommandIndex == −1`) with `_bossAliveTime < 60`, `CallAsteroids()` runs
  (below). Each set bit becomes its own ActiveAttack `{bit, IsLaser, WaitTimer = 1.0, RollTriggered = false}`, in
  ascending bit order. When every command is scheduled and no attack is active: patterns 0–1 go to Waiting for 5 s;
  the last pattern goes to Resetting for 3 s.
- **Waiting**: when the timer runs out, `_currentPatternIndex = (i+1) % 3`, then Executing with `_timeline = 0` and
  `_lastCommandIndex = −1`.
- **Resetting**: when the timer runs out, `_orderBits = 0xFF` (cannons roll back to laser), `_wingLaserBits |= WingAll`,
  `_cycleCompleted = true`, then Waiting with 10 s (this is reset again on the next PT6 entry).
- **ProcessActiveAttacks** walks the list from the back. On the first visit it requests the pose: a shoulder bit whose
  pose differs from IsLaser gets its `_orderBits` bit set or cleared (that roll takes 1 s); a wing bit gets its
  `_wingLaserBits` bit set or cleared; a body bit does nothing. Then `WaitTimer −= dt`. At ≤ 0, a shoulder attack waits
  until `_cannonBits` matches IsLaser. Then it fires: non-body bits use `FireCannons(bit, 0, laser01)`; a body bit uses
  `BulletFireForget(bos01bullet01, body muzzle, _token, 0.7)` when IsLaser is false, or
  `_mover.BulletFireAsync(CToken, bos01laser01, false, false, body muzzle, null, 0, 0)` when it is true. The attack is
  then removed.
- `CallAsteroids` (0x1d89290) alternates sides, starting with the left: `CallEnemyClip(0,1,2)` (`*_l`) or `(3,4,5)`
  (`*_r`), each with offset 0. The clips spawn through `InGameManager.EntryEnemyNoRate(data, manager+0x98, 0, Division 2)`.
  The clips hold Pf_EneObj_Meteo_La01 ×1 (speed 10 ± 10), Ma01 ×10 (2 s apart, speed 15 ± 15) and Sa01 ×50
  (0.2 s apart, speed 20 ± 20). Each starts at offset x = ∓200 with yaw ±112.5°, offset range (5,0,100), PlaneBaseY −30
  and a 20 s duration.

### 5.3 Core rings (CoreAttackPatternLogic inlined in PT6; the same as 0x1d78850)
Wait 10 s after PT6 starts. Then fire 8 shots 0.5 s apart from body_muzzle50, alternating bos01bullet10 (even shots)
and bos01bullet11 (odd shots). After the 8th shot add 10 s and repeat. The core logic restarts on every PT6 entry.

### 5.4 Derived first-cycle timeline (sim_timeline.txt; s since PT1 start, 60 fps, no damage)
0 PT1 · 5.02 entry over, PT2 · 5.05 PT2 laser02 sweep (10 wing + 2 body) · 6.05 wing-open sound, return home ·
9.15 PT6 · 9.17 pattern 1 + left asteroids · 10.2–19.2 pattern-1 shots (1 s apart) · 19.2–22.7 core rings ·
24.2 pattern 2 + right asteroids · 25.2–31.2 pattern-2 lasers · 33.2–36.7 core rings · 37.2 pattern 3 + left asteroids ·
38.3–39.1 sweep · 42.15 PT1 (2 s) · 44.2 PT2 · 48.3 PT6 (pattern 1 + right asteroids) · 63.3 pattern 2 (the last
asteroid call, alive time 58.3 < 60). Each later loop takes about 39 s.

## 6. Part breaks
`OnPartsBreak(parts)` (0x1d79b70; the base call is the empty stub 0x5bcdb0): for parts 3–10, destroy the CannonData
whose `_partsDamage._partsNumber == parts` (`_isAlive = 0`, its laser token is cancelled), then `AddShake(1, 1, 10)`.
Destroyed cannons are skipped by FireCannons and their rolls finish at once, so patterns never stall. Mapping
(`Initialize` takes the EnemyCollisionModel under each cannon's parent):

| cannon i / bit | L4 0 | L3 1 | L2 2 | L1 3 | R4 4 | R3 5 | R2 6 | R1 7 |
|---|---|---|---|---|---|---|---|---|
| transform | wing40/cannon44 | cannon 43 | cannon 42 | cannon 41 | wing60/cannon 64 | 63 | 62 | 61 |
| part (index) | shoulder_r4 (6) | r3 (5) | r2 (4) | r1 (3) | shoulder_l4 (10) | l3 (9) | l2 (8) | l1 (7) |

Breaking cannons does not change the state machine, the patterns or the model, beyond what the base EnePartsGroup break
does (BreakEffect pf_eff_explposion03, `_partsRoot` / `_damageObject` handling **[I]** shared PawnEnemy logic).
`ApplyDestroyedCannonColor` (grey blend 0.5) and `DisableShoulderCannon` are never called; a scan of every E8/E9 call
site in the binary (`find_callers.py`) found none. The wings cannot break (NoDamage).

## 7. Animator
None. Pf_Ene_Bos01 has no Animator, and Ene_Bos01 sets no triggers. The wing swing, cannon roll, hover, fall and roll
are all transform writes made by this code.

## 8. Address table

| method | RVA | constants used |
|---|---|---|
| .cctor | 0x1d7bf30 | home (0,0,40), rush (0,0,−30), stay 8, cannonMax 8, spring 8, damping 5.6, asteroid time 60, Destruction_Rotation (20,135,0), patterns |
| .ctor | 0x1d7d0e0 | PartsCount 11, SE vol 0.5, springScale 1, wingLaserBits 0x1FF800 |
| Initialize | 0x1d794c0 | cannon_muzzle / laser_cannon_muzzle lookups, body muzzle paths, `_mover._isForceFire` |
| ReStart | 0x1d7ace0 | wing 90, bits 0xFF, pt1Wait 5, roll −90, core wait 10, NoDamage on parts 1 and 2 |
| GetStart | 0x1d79470 | object flags 0x22 |
| StateExec | 0x1d7b330 | wing speeds 0.5 / 1, angle 90, SE 101 |
| SetBossState / SetWingAngle | 0x1d7b200 / 0x1d7b230 | — |
| PatternMove1 / 2 / 6 | 0x1d79c70 / 0x1d79ef0 / 0x1d7a2c0 | 2, 5, 1.5, 3π/2 − 3; 1, 0.1, 0.4, 0.5, 1.5, SE 105/107; core 10, 8, 0.5 |
| PatternMoveDestruction / ToDestroid | 0x1d7a5f0 / 0x1d7b6b0 | 150, 4, 0.2, 5.5, 3.5, 2, shakes, SE 40/42, trophy 9 |
| UpdateVelocityMovement | 0x1d7ba80 | step 0.05, threshold 0.01 |
| UpdateHomePositionInInfinityLoop | 0x1d7b8c0 | 8, 10, 1, 0.99 (unreachable) |
| FireCannons / FireWingCannons | 0x1d78a40 / 0x1d78eb0 | BT indices 0–4, bit 11+i |
| OnPartsBreak / OnHitProgress / IsHitEnable / GetHormingTarget / GetSmallBombPosition | 0x1d79b70 / 0x1d79a10 / 0x1d799c0 / 0x1d79310 / 0x1d793f0 | shake (1,1,10) |
| GetBossBT / GetBossCD | 0x1d79260 / 0x1d792b0 | static +0x28 / +0x30 |
| WingAttackPatternLogic Update / ScheduleAttack / ProcessActiveAttacks / CallAsteroids / Initialize / .ctor | 0x1d89c80 / 0x1d89970 / 0x1d895f0 / 0x1d89290 / 0x1d89560 / 0x1d89f20 | 5, 3, 10, WaitTimer 1.0, 60 |
| EnumerateCannonBits + MoveNext | 0x1d894f0 / 0x1d89110 | lowest set bit first |
| CannonData Roll / ReStart / Initialize / Destroy / GetMuzzle | 0x1d78760 / 0x1d785d0 / 0x1d78470 / 0x1d782c0 / 0x1d78450 | −90°, rate 1/s |
| Ene_BosBase LocalLateUpdate / ProgressBossTimer / ResetBossTimer / ToDestroid / _callDeadEffect / IsCallSmallBomb / CurrentTargetVector / CurrentTargetAngle / CallEnemyClip / InitializeToPlay | 0x1db9ff0 / 0x1dba1d0 / 0x1dba430 / 0x1dbac60 / 0x1dbaeb0 / 0x1db9e90 / 0x1db9630 / 0x1db95c0 / 0x1db8f70 / 0x1db9a90 | 0.9, 0.1, (0.4,·,·), shake (1,3,1), vibration (0.5,0.8,2) |
| EasingUtility.EaseInOut / Easing01 | 0x1de7fa0 / 0x1de8100 | quadratic |

Vtable slots (vtable at klass+0x138, 16 bytes per slot; checked against StateExec 85, GetBossBT 87, GetSmallBombPosition 92):
0x1b8 = 8 IsAlive, 0x2f8 = 28 AddDead, 0x588 = 69 `_callDeadEffect`, 0x6f8 = 92 GetSmallBombPosition.

## 9. Open questions
- [?] Whether EnemyMover moves a route-less boss (moveSpeed 20, lookAt 1) before `_isFinishDelay`, and how many frames EntryWait lasts. The sim assumes PT1 starts at once from (0,0,200).
- [?] The 180° spawn yaw (so that code "L" / `*40` is screen right) is inferred from the placement rotate and the laser muzzles pointing +z. A recording should confirm it.
- [?] TypeInfo#41901 in OnHitProgress is not resolved; MeteoEnemy is inferred.
- [?] Ring count and spacing of bulletType 6 and 8, and the laser duration from nIrradiation: these depend on the shared bullet system, not on this class.
- [?] EaseIn in Easing01 is assumed to be t², the first jump-table case; the table order was not decoded.
- [?] `GetBattileTime` reads a static float (TypeInfo#47822) whose value was not found. The base `TimeupAction` is empty, so a time-out does nothing in this class. What the timeline does at clip end (480 s) is unknown.
- [?] How the base EnePartsGroup breaks a part (hide or keep the model, smoke) and whether part damage also lowers the core HP: shared PawnEnemy logic that was not read here.
