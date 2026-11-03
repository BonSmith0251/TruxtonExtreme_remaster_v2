# Ene_Bos02 (BG02 boss): behaviour spec from native code

Source: `D:\games\Truxton Extreme\GameAssembly.dll` (IL2CPP x64), disassembled read-only with `dis.py` in this folder
(full listing `dis_all.txt`, base class `dis_base.txt`, EnemyMover `dis_mover.txt`, static ctor `d_cctor.txt`).
Every number is from code, metadata or serialized data. `[I]` means inferred, `[?]` means unknown.
Constants are also in `bos02-constants.json` (made by `make_constants.py`). The real vtable (from metadata) is in
`vtable_bos02_meta.txt`.

## 1. Identity

| Item | Value | Source |
|---|---|---|
| Class | `InGame.Kernel.Enemy.Ene_Bos02 : Ene_BosBase : PawnEnemy` | types.jsonl |
| Nested types | `PatrolMovementController` (+`Phase`), `Fire5Controller`, `Fire6Controller`, `Fire7Controller`, `Fire6Table`, `Fire7Table`, enums `Boss02State`, `Boss02MZ`, `Boss02BT`, `PartsKind` | types.jsonl |
| Prefab | `Reconstructed/Assets/OriginalRecovered/Samples/Prefabs/Reference/Enemy/Pf_Ene_Bos02.prefab` (model root `pf_bs02` = `_modelTop`) | prefab |
| EnemyData | `ene_boss02` (definition id `ed62508ddedc57d4087d1cc0bcff293f`): position (0,0,50), moveSpeed 20, lookAt 1, duration 100, no routes | StageEnemies/BG02.json |
| Spawn | timeline group `main/tt_boss02`, event start **432.0 s**, end 540.0 s | BG02.json events |
| Route events | `Animation "anc_bs02_start"` (vector (0,0,-250) [?]), `TaskWait "Start"` intValue1 16 = `TaskFlags.AnimationTask`, `FinishWait "Start"` | BG02.json; RouteEventType 9/80/1001 |
| Body HP | 1,000,000 (DB row 38 `Bos02`), lock-on yes, blocks laser yes, score 100000, BOSS size | enemy-database.json |
| Parts (PartsList order = PartsKind) | 0 `core` flags MasterBody (no DB row); 1 `upper06` HP 200000 (row 40); 2 `upper04` HP 200000 (row 39); 3 `under04` flags MasterBody+SleepStart (no row); 4 `under06` MasterBody+SleepStart (no row). Upper parts: lock-on, block laser, score 10000 | prefab PartsList, DB |
| PartsKind enum | MainBody 0, Upper06 1, Upper04 2, Under06 3, Under04 4. NOTE: the enum names 3/4 are swapped versus the prefab list (index 3 is `under04`, 4 is `under06`); the code only uses indices, so use the prefab list. | types.jsonl vs prefab |
| Hit shapes | core capsule on `pf_bs02/coreBody` (30,40), lock-on offset (0,15,0); upper06/upper04 capsules (20,35) lock-on (0,0,15); under06/under04 circles r30 | prefab, enemy-hitshapes.json (circles already resolved there) |
| Dead effect | `_deadExplosion pf_eff_explposion_boss`, `_explosionOffset (0,20,0)`, `_overplayDeadSound 41 (exp_st3_boss_b02)`; part BreakEffect `pf_eff_explposion03` (upper/under) | prefab |
| HP states | Ene_BosBase.hpRateRanges .9/.75/.51/.4/.3/.2/.1/0 (verified in metadata blob); `_hpState` = first i with rate > ranges[i] | .cctor 0x1DBAFF0, UpdateHPState 0x1DBAD20 |
| Boss timer | starts at entry end (`ResetBossTimer(true)`); `_currentActStep` +1 every 10 s; TimeOver(18) at GetBattileTime() = **180 s** (`UIBossGauge.defaultBossTimeMax`); `TimeupAction` is empty for Bos02 | ProgressBossTimer 0x1DBA1D0, UIBossGauge..cctor 0x1DD5170 |

Invulnerable windows: spawn → +3.5 s `OffCollision`; +3.5 s → entry end `OffLockon|NoDamaged`; back-wing opening
(~4 s) `OffLockon|NoDamaged`; destruction (all parts disabled by StopBossTimer→DisabledAllParts).
Under wings are asleep (no hits) until `Wakeup()` in the back-wing opening.

Summons: **none from native code.** `GetBossCD()` returns `["bos02_00_sa01"]` and `Ene_BosBase.InitializeToPlay` loads it
into `_enemyDatas` (and `SubEnemys` lists it for pooling), but no Ene_Bos02 method calls `CallEnemyClip`, and the statics
`_callLSide (-100,20,0)`, `_callRSide (100,20,0)`, `lastHomePosition (0,0,20)` are never read. (`bos02_00_sa01` =
Pf_Ene_Sa01, startPosition (0,0,100), 2 placements offsets (-20,0,0)/(20,10,0) speed 60, repeat 1 step (0,0,10)/0.5 s,
fires `shot01` every 1.5 s - only relevant if another system calls it [?].)

## 2. Coordinates and units

Source sky plane: x right, z up the screen, y toward the camera (camera (0,400,0) looking down, 20° vertical FOV).
Distances in source units, time in seconds, angles in degrees unless marked rad.

* Boss root (`_transformCache`, Pf_Ene_Bos02) moves in its parent's local space (enemy layer). Spawn localPosition
  (0,0,50). All movement below writes `localPosition` of the root.
* `_modelTop` (pf_bs02) carries the entrance clip; at rest it is localPosition 0, localRotation Euler(0,180,0)
  (`_modelTopRotateStart`). So model +z (nose, `body_front`) points down-screen at the player, and model +x is
  screen-left (hence `_backWingL` = `wing_under06` at model x +26.9, `_backWingR` = `wing_under04`).
* Root roll: after every StateExec, if IsAlive, root `localRotation = Euler(0,0,clamp(_rotateZ,-4,4))`
  (StateExec 0x1D80D90). `_rotateZ` is 0 at ReStart and only `UpdateRollAngle(0,…)` (back-wing opening) writes it,
  so the root rotation is identity in practice. (The roll constants RollTargetScale 1.5 / RollResponse 20 /
  RollDamping 3 / MaxRollAngle 4 are implemented but only ever drive toward 0.)
* `dt` = `InGameManager.DeltaTime`; `ptf` = `InGameManager.PlayTimeFactor` [? value, presumably 1].

## 3. State machine

`_bos02state` (Boss02State): EntryWait 0, PT1 1, PT2 2, PT3 3, PT5 4, BackWingOpen 50, Destruction 100.
`SetState(s)`: if s differs, store it and set `_patternMode = 0`; always `mover._laserCancelFlag = false`.
Each frame (Ene_BosBase.LocalLateUpdate 0x1DB9FF0): if dt > 0 and IsPlayingState: update player-side flags,
ProgressBossTimer(dt), StateExec(dt) → dispatch on state.

```
spawn ─► EntryWait ─(clip done)─► PT1 ─► PT2 ─► PT3 ─(turnCount++)─► PT1 …      (front mode)
                        every front transition: if both upper wings broken ─► BackWingOpen ─► PT5 (forever)
                        (forced break of both wings if bossTime ≥ 90 s or HP ≤ 40 %)
HP reaches 0 (any state) ─► ToDestroid ─► Destruction ─(5.5 s)─► removed
```

### Front-mode transition — HandleFrontModeNextState (0x1D7E530), called by CheckNextState when `_backWingMode` is false
1. `up04 = PartsList[2]`, `up06 = PartsList[1]`.
2. If `IsOverStep(Passed90)` (`_currentActStep ≥ 9`, i.e. boss time ≥ 90 s) **or** `IsOverHP(LowHP)` (`_hpState ≥ 4`,
   HP rate ≤ 0.40): `up04.BreakParts(isGround=false, withEffect=true, withSound=true, Vector3.zero)`, same for up06.
3. If `up04._isPartsBroken && up06._isPartsBroken` → SetState(BackWingOpen).
4. Else: EntryWait→PT1, PT1→PT2, PT2→PT3, PT3→ `_turnCount++` (saturating) → PT1; any other value → EntryWait.

CheckNextState (0x1D7D2D0): no-op in Destruction; front mode → HandleFrontModeNextState; back-wing mode: state 50 → PT5.
The check runs only at the end of an attack (after its cooldown) and at entry end, so breaking both wings mid-attack
finishes the current attack first.

### EntryWait — PatternEntry (0x1D7F1B0)
Spawn: `GetStart` sets `OffCollision`. EnemyMover `_isForceFire = true` (Initialize).

| mode | action |
|---|---|
| 0 | `_localTime = 0`, mode 1, play SE 61 `bg2_boss_app_01` |
| 1 | `_localTime += dt`; when ≥ `_EntryNoHitTime` **3.5**: clear `OffCollision`, set `OffLockon|NoDamaged` (0x22), mode 2 |
| 2 | wait for `mover._isFinishDelay` (set by the route's FinishWait after the 5 s `anc_bs02_start` clip, via TaskWait AnimationTask). Then clear `OffLockon|NoDamaged`, `ResetBossTimer(true)` (alive time 0, act step 0, hp state 0, `_startInGamePosition` = localPosition), `mover.StopAnime(true)`, `_modelTop.localPosition = 0`, `_modelTop.localRotation = Euler(0,180,0)`, CheckNextState (→ PT1) |

Entrance clip `TXE_GraphicData/Boss/Bs02/Animation/anc_bs02_start.anim` (5.0 s, 60 fps, no events, root path, Hermite
keys): position (104.40,220,-190.92) @0 → (-10,150,-50) @2 → (0,-25,0) @4.1667 → (0,0,0) @5;
Euler (10,-50,0) → (5,10,-15) → (0,180,-5) → (0,180,0). Use the clip's tangents as stored.

### PT1 / PT2 / PT3 — PatternMove1/2/3 (0x1D7F410 / 0x1D7F620 / 0x1D7F830), identical shape
| mode | action |
|---|---|
| 0 | `_attackDuration = max(5 − _turnCount, 1)`; `_cooldownTimer = _fireTimer = 0`; PT1 only: `_fire1NextAimPlayer = true`; mode 10 |
| 10 | `_attackDuration −= dt`; `_fireTimer += dt`; while `_fireTimer ≥ I`: `_fireTimer −= I`, fire; if `_attackDuration ≤ 0`: `_cooldownTimer = 0.5`, mode 20 |
| 20 | `_cooldownTimer −= dt`; when ≤ 0 → CheckNextState (no tracking that frame) |

`I` = 0.2 (PT1), 0.1 (PT2), 0.05 (PT3). Every frame of modes 0/10/20 (not the frame that calls CheckNextState) runs
`TrackPlayerHorizontally(dt, ptf, chase=true)`.
Attack length per state by cycle: 5, 4, 3, 2, then 1 s (each + 0.5 s cooldown); a full PT1-PT3 cycle is 16.5, 13.5,
10.5, 7.5, then 4.5 s. Shots per state (cycle 0): 25 / 50 / 100.

### BackWingOpen — OpenBackWing (0x1D7EC30)
| mode | action |
|---|---|
| 0 | set `OffLockon|NoDamaged`; mode 1 (same frame) |
| 1 | if `_rotateZ ≠ 0`: `UpdateRollAngle(0, ptf)` and wait. Else play SE 70 `bg2_boss_mainwing_operating`, `_localTime = 2.0`, mode 10 |
| 10 | `e = InOutQuad01(clamp01(1 − _localTime·0.5))`; `_backWingL.localRotation = Euler(0,0, 90e)`, `_backWingR.localRotation = Euler(0,0,−90e)`, `_bodyFront.localRotation = Euler(−60e,0,0)`; then if `_localTime > 0`: `_localTime −= dt`, else mode 11, `_localTime = 0.5` |
| 11 | `_localTime −= dt`; when ≤ 0: `PartsList[4].Wakeup()` (under06), `PartsList[3].Wakeup()` (under04), `_backWingMode = true`, mode 19 |
| 19 | play SE 71 `bg2_boss_cannon_move_01`, `_localTime = 0.5`, mode 20 |
| 20,21,22 | `_localTime = max(_localTime − dt, 0)`; pair `p = 2·mode − 40` (0,2,4): `_backCores[p]` and `_backCores[p+1]` `localRotation = Euler(180·clamp01(2·_localTime), 0, 0)` (180° → 0°); when `_localTime ≤ 0`: mode++; if mode ≤ 22 play SE 71 and `_localTime = 0.5` |
| 23 | `_fire1NextAimPlayer = true`, `_fire1Count = 0`, clear `OffLockon|NoDamaged`; if not Destruction → PT5 (back-wing branch of CheckNextState) |

No movement during this state (no tracking). Total ≈ 4.0 s. `_backCores` start at `_coreRot` Euler(180,0,0) (set in ReStart; prefab rest value is the same).

### PT5 — PatternMove5 (0x1D7FA40), runs until death
Per frame:
1. `wasStraight = patrol._phase == Straight` (before update). `patrol.EnsureInitialized()`; if dt > 0: Straight →
   `UpdateStraightPhase(dt, ptf)`, Orbit → `UpdateOrbitPhase(dt, ptf)`.
2. `enteredStraight = (phase == Straight) && !wasStraight` (true on the first PT5 frame and on every orbit exit).
3. `_patternMode`: 0 → 10. 10: if `patrol._hasReachedContact` → `_localTime = 5` (PatrolPostArrivalDelay), mode 20.
   20: if not `_hasReachedContact` → mode 10; else `_localTime −= dt`, when ≤ 0 set `patrol._orbitAdvanceRequested = true`.
4. `Fire5Controller.Update(dt, trigger = enteredStraight, Fire5)`; `Fire6Controller.Update(dt, Fire6)`;
   `Fire7Controller.Update(dt, trigger = enteredStraight, Fire7)` (all inlined; section 5).

### Destruction — ToDestroid (0x1D80EC0) then PatternMoveDestruction (0x1D80030)
ToDestroid (called when the boss dies [I: by the damage system]): `SetTrophy(8)` if IsTrophy; `StopBossTimer`
(`DisabledAllParts`, `AddDiPoint_BossDestroy`, `SetBossTime(GetBonusTimeKind()=0)`, SE 177 `boss_defeat01_01`,
timer off, `DeadResultUpdate`); `mover.DeleteRouteToken()`; `ReleaseToken()` (cancels pending delayed shots [I]);
SetState(Destruction).

| mode | action |
|---|---|
| 0 | `_startVector = _targetVector = localPosition`; `_targetVector.y −= 150`; `_startAngle = localRotation`; `_targetAngle = Euler(120, 0, 45)`; 4× `SkyExplosionEffect(ShortCutEffect.ExplosionCodeMiddle, GetSmallBombPosition(), layer, no sound)`; `AddShake(0.5, 1, 2)`; `SetSmallBombSecond(0.2)`; `SetDirectionTime(5.5, 1)`; `_localTime = 3.5`; mode 10 |
| 10 | root `localPosition = Lerp(start, target, EaseIn(rate))`, `localRotation = Quaternion.Lerp(startAngle, targetAngle, rate)` with `rate = clamp01(directionPassed/5.5)`; `_localTime −= dt`; when ≤ 0: `PartsList[4]` and `[3]` `BreakParts(false,true,true,0)`, `_callDeadEffect()`, `AddShake(0.5,1,5)`, mode 11, `_localTime = 2`. Small bombs: if `IsCallSmallBomb(dt)`: `SkyExplosionEffect(ExplosionCodeSmall, GetSmallBombPosition(), layer, SE 40 exp_st3_boss_a01)` + `AddShake(0.5,1,5)` |
| 11 | same position/rotation easing; `_localTime −= dt`; small bombs as above but without the shake; when `_localTime ≤ 0` → mode 30 |
| 30 | SE 42 `exp_st3_boss_c03`; `Ene_BosBase.ToDestroid()` (vibration 0.8/1/2, `_isBossDead`, PawnEnemy.ToDestroid → removal [I]) |

Total 5.5 s after death. `IsCallSmallBomb(dt)`: `current −= dt`; if `current > 0` false; else `current = base + 0.1·rand01`,
`base *= 0.9`, vibrate (0.4, 0.1, base) unless the dead effect was called, true. First call fires at once.
`_callDeadEffect` (Ene_BosBase 0x1DBAEB0): camera shake (1,3,1), vibration (0.5,0.8,2), then PawnEnemy._callDeadEffect
(dead explosion `pf_eff_explposion_boss` at `_explosionOffset` (0,20,0) [I]).
`GetSmallBombPosition` (0x1D7E3C0) world position of: r<0.5 random `_muzzles[0..2]`; r<0.75 random `_backCores[0..5]`;
r<0.9 `_backWingL`; else `_backWingR` (r = RandomUtility.Make01; Range(1,n) is inclusive, minus 1).
`layer` = a static int of class TypeInfo idx41050 at +0x20 [? name].

## 4. Movement

### Front mode — TrackPlayerHorizontally(dt, ptf, chase) (0x1D80F80)
Substeps: `rem = dt`; loop `step = min(rem, 1/60)`, `f = step/dt·ptf`; `ExecuteHorizontalChaseStep(step, f)`;
`localPosition.x += step·_moveSpeed`; `rem −= step` while `rem > 0`. Only x changes (z stays at 50).
ExecuteHorizontalChaseStep (0x1D7D450):
* `px = clamp(player0 sky x, −80, 80)` (`GetPlayerSkyPosition(0)`), `bx` = boss sky x (`GetSkyRootPosition(transform.position)`), `d = px − bx`.
* `|d| > 1.5`: `target = sign(d)·(10 + 10·clamp01((|d| − 1.5)/58.5))` (10..20).
* `|d| ≤ 1.5` (dead zone): `dir = sign(_moveSpeed)` if `|_moveSpeed| > 0.01`, else `_moveDirHold` if ≠ 0, else `d ≥ 0 ? 1 : −1`;
  `target = dir·max(10, |_moveSpeed|)` - the boss never stops; it sweeps past the player and turns back.
* `a = 6` if `_moveSpeed ≈ 0` or same sign as target, else 4. `_moveSpeed = MoveTowards(_moveSpeed, target, a·f·step)`,
  clamp ±20; if `|_moveSpeed| > 0.01`: `_moveDirHold = sign(_moveSpeed)`.
(`DampHorizontalVelocity`, `ResolveTargetVelocity` exist but are unused / outlined copies.)

### PT5 — PatrolMovementController (positions are root localPosition)
PatrolPoints: 0 (−70,0,50), 1 (−35,0,50), 2 (0,0,50), 3 (35,0,50), 4 (70,0,50), 5 (−70,0,30), 6 (−35,0,30), 7 (0,0,30),
8 (35,0,30), 9 (70,0,30). PatrolOrder (11, wraps): **2, 6, 2, 8, 4, 7, 0, 7, 5, 2, 9**. Target = `PatrolPoints[PatrolOrder[seq % 11]]`.
Orbit radius r = 5. Each target is orbited; each segment alternates the orbit direction.

* **EnsureInitialized** (first PT5 frame): `pos` = current localPosition, `seq = 0`, velocity 0, orbit dir +1, speed 0,
  `_constantSpeed 10`, cruise false, speed transition 0 → 20 over 3 s (timer 0), then
  `PrepareStraightSegment(pos, ContactPoint(pos, target, 5, +1))`.
* **ContactPoint(from, c, r, dir)** (0x1D872F0): `dx,dz = from − c`, `d = |(dx,0,dz)|`; `a = atan2(dz, dx)`; if
  `d > r + 0.001`: `a += s·acos(clamp(r/d,−1,1))`, `s = dir<0 ? −1 : 1`; contact = `c + (r·cos a, 0, r·sin a)`, out angle a (rad).
* **PrepareStraightSegment(from, contact, angle, dir)**: phase Straight, `contact.y = target.y`, store contact/angle,
  `_orbitDirection = dir<0?−1:1`, orbit timer 0, `_hasReachedContact = _orbitAdvanceRequested = false`,
  speed clamp [cruise?10:0, 20], velocity = normalize(contact − pos)·speed, write localPosition.
* **UpdateStraightPhase(dt, ptf)**: `dist = |contact − pos|` (xz); `vt = dist ≤ 40 ? 10 : 20`; if `!cruise && speed < 10` → `vt = 20`;
  `BeginSpeedTransition(vt, vt > speed ? 3 : 2)`; `AdvanceSpeed(dt, ptf)`; `vel = normalize(contact − pos)·speed`;
  `pos += vel·dt` (no ptf), clamped to contact on overshoot; write localPosition; if `|contact − pos| ≤ 0.001`:
  `_hasReachedContact = true`, StartOrbitPhase.
* **StartOrbitPhase**: phase Orbit, orbit timer 0, `angle = contactAngle`, speed = clamp(clamp(speed,0,8), cruise?10:0, 8)
  (= 10 once cruise was reached, see quirk), `pos = c + r(cos a, 0, sin a)`, write localPosition, velocity = tangent·speed.
* **UpdateOrbitPhase(dt, ptf)**: orbit timer += dt; `BeginSpeedTransition(8, 3)`; `AdvanceSpeed(dt, ptf)`;
  `angle += speed / max(r,0.001) · dir · ptf · dt` (rad); `pos = c + r(cos a, 0, sin a)`; tangent = dir ≥ 0 ? (−sin a, 0, cos a) : (sin a, 0, −cos a).
  If `_orbitAdvanceRequested && orbitTimer ≥ 3`: `n = (seq+1) % 11`, `dir' = −dir`, `k = ContactPoint(pos, Points[Order[n]], 5, dir')`;
  if `|k − pos|² ≤ 1e−6` or `dot(normalize(k − pos), tangent) ≥ 0.95`: `seq = n`, `PrepareStraightSegment(pos, k, angle', dir')` (tangential exit).
  Effective orbit time ≥ 5 s (post-arrival delay) plus waiting for alignment.
* **BeginSpeedTransition(t, dur)**: `t` clamped: `t < 10 → 10`, else `t > max → max` (max = Orbit ? 8 : 20);
  `dur = max(dur, 1e−4)`; if `Approximately(t, _speedTarget) && Approximately(dur, _speedTransitionDuration)` keep the running
  transition; else start = current speed, timer 0.
* **AdvanceSpeed(dt, ptf)**: if dur > 0: `timer = min(timer + max(dt·ptf, 0), dur)`, `speed = lerp(start, target, timer/dur)`; else target.
  `speed ≥ 9.999` → cruise = true. Clamp: `speed < (cruise?10:0) → that`, else `speed > max → max` (max Orbit 8 / else 20).
* Quirk (as coded): in Orbit the clamp has min 10 > max 8, so the orbit speed is 8 once the lerp reaches 10 (10 below that).
  In practice: straight 20 u/s when far (> 40), easing down to 10 u/s near the contact; orbit 8 u/s on r 5 (1.6 rad/s).

## 5. Attacks

Templates (`btemplates` from `GetBossBT`, index = Boss02BT): 0 `bos02laser01`, 1 `bos02laser10`, 2 `bos02way8` (loaded,
never fired), 3 `bos02b04x3`, 4 `bos02way16_1`, 5 `bos02way16_2`, 6 `bos02way5`, 7 `bos02way6_1`, 8 `bos02way6_2`
(all under `Boss02/`, parameters in Resources/StageCombat/enemy-attacks.json). InitializeToPlay calls
`ChangeSE(BulletKind.B004, enemybullet013_01)` on every boss template.
Muzzles `_muzzles[Boss02MZ]` found by name under `_modelTop`: 0 `body_front/muzzle_body_front_laser`,
1 `body_front/muzzle_body_front_core`, 2 `body/muzzle_body_core`. Muzzle packs on the EnemyMover (order matters):
`upperl` [upper04_01, upper04_02 (`muzzle_winguppre04_02`), upper06_01, upper06_02]; `underl` [under06 laser04, 03, 02, 01,
under04 laser01, 02, 03, 04]; `undercore` [under06 battery, battery (1), battery (2), under04 battery (3), (4), (5)] (`…/wing02_battery_core`).

| Fire | Used in | Call | Notes |
|---|---|---|---|
| Fire1(aim) 0x1D7DA60 | PT1 every 0.2 s; PT5 via Fire7 | `BulletFireAsyncDelayed(0.5 s, aim ? way16_1 : way16_2, isSelfDir=false, isNested=false, muzzle_body_core, null, 0)` | the caller toggles `_fire1NextAimPlayer` after each shot; PT1 starts with true (way16_1 first) |
| Fire2 0x1D7DB30 | PT2 every 0.1 s | `BulletFireByMuzzlePack(b04x3, isSelfDir=false, isNest=false, "upperl", delay 0)` | 4 upper-wing muzzles [? whether broken wings still fire] |
| Fire3 0x1D7DBE0 | PT3 every 0.05 s | `BulletFireAsyncDelayed(0.5, way5, false, false, muzzle_body_front_core, null, 0)` | |
| Fire5 0x1D7DCB0 | PT5 | `BulletFireAsync(laser01, false, false, muzzle_body_front_laser, null, 0, 0, null)` | `enemylaser003`: charge 1.0, width 30, collision 4, dissolve 0.5, irradiation 5 s, template isSelfDir 1 |
| Fire6(b) 0x1D7DD70 | PT5 | `BulletFireAsync(laser10, false, false, underl[b], null, offsetAngle = _underLaserMuzzleDir[b], 0, null)` | dirs [135, 90, 45, 0, 0, −45, −90, −135]; `enemylaser000`: charge 1, width 10, collision 2, dissolve 0.3, irradiation 1 s |
| Fire7(rate) 0x1D7DF10 | PT5 | for each `undercore[i]`: `angle = T7[i].start + rate·T7[i].move`; `BulletFireAsync(way6_1, …, undercore[i], null, angle)` and same with `way6_2`. Then if `rate ≥ 1`: `_fire1Count++`, on odd counts `Fire1(_fire1NextAimPlayer)` + toggle | T7 (start, move): (180,−25), (−90,−25), (0,−25), (−180,+25), (90,+25), (0,+25) |

PT5 controllers (inlined in PatternMove5; standalone copies at 0x1D86C50 / 0x1D86D30 / 0x1D86F10):
* **Fire5Controller** (laser01): `_trigger |= trigger`. mode 0: if `_trigger` → clear, mode 10 (wait 0). 10: `wait += dt`;
  when ≥ 0 (Pattern5StartDelay) fire Fire5, mode 20 (fire timer 0). 20: `fireTimer += dt`; ≥ 5 (Pattern5PostFireDelay) → mode 30.
  30: `wait += dt` ≥ 0 → mode 0. So laser01 fires the frame after each straight-segment start, at most once per ~5 s; a
  trigger during the lockout is latched.
* **Fire6Controller** (under lasers, no trigger): mode 0 → 10 (wait 0). 10: wait ≥ 5 (Pattern6StartDelay) → timeline = −0.0001,
  mode 20. 20: `prev = timeline; timeline += dt`; every table entry with `prev < time ≤ timeline` → Fire6(battery); when no entry
  has `time > timeline` → mode 30. 30: wait ≥ 10 (Pattern6Interval) → mode 0. Cycle ≈ 5 + 15 + 10 s.
  Table (time: batteries): 0: 0,7 · 1.5: 1,6 · 3: 2,5 · 4.5: 3,4 · 8: 1,2,5,6 · 9.5: 0,3,4,7 · 12: all · 13.5: all · 15: all.
* **Fire7Controller** (cannon sweep): mode 0: if trigger → mode 10 (wait 0). 10: wait ≥ 1 (Pattern7StartDelay) → roll/fire timers 0,
  mode 20. 20: `roll += dt`, `fire += dt`; if `roll ≥ 5` → mode 0; else if `fire ≥ 0.1`: `fire −= 0.1`,
  `rate = roll < 2 ? 0 : roll < 4 ? (roll − 2)·0.5 : 1`, Fire7(rate). Triggers outside mode 0 are ignored (no latch).
  Per burst ≈ 49 volleys: 2 s fixed, 2 s sweep of ±25°, 1 s at the end angle with Fire1 every 0.2 s.

Lasers are cancelled on a part break: `OnPartsBreak` sets `mover._laserCancelFlag = true` [I: consumer is the laser code];
every SetState clears it.

## 6. Parts

* Front mode targets: core (main HP) and upper06 / upper04 (200000 each, independent HP, lock-on). Under wings asleep.
* `OnPartsBreak(int)` (0x1D7EBE0, any part): `AddShake(nsec 1, npow 3, nspeed 4)`, `_laserCancelFlag = true`. No attack change
  directly; the effect of the upper wings is only via HandleFrontModeNextState (both broken → BackWingOpen). Breaking one wing
  changes nothing.
* Forced break: at a front transition with boss time ≥ 90 s or HP ≤ 40 %, both upper wings `BreakParts(false, true, true, 0)`.
* Back-wing opening wakes `under04`/`under06` (MasterBody+SleepStart: they become hittable and, as MasterBody, damage the main
  HP [I]). They are broken (effects only) 3.5 s into the destruction.
* Visual changes: wings unfold (z ±90°), body_front tilts −60° about x, six cores flip from 180° to 0° about x, in pairs.

## 7. Animator usage

No Animator parameters or triggers are set by Ene_Bos02. The entrance is the mover's route `Animation` event playing
`anc_bs02_start` (5 s) on the model; `PatternEntry` waits for the route's FinishWait and calls `mover.StopAnime(true)`.
`anm_bs02.controller` has one empty `Idle` state. Every other motion is code-driven transforms (section 3/4).

## 8. Address table

| Method | RVA | Constants taken |
|---|---|---|
| Ene_Bos02..cctor | 0x1D812B0 | statics (bos02-constants.json), PatrolOrder/_underLaserMuzzleDir via InitializeArray (metadata blob offsets 543544 / 543616), _EntryNoHitTime 3.5 |
| Initialize | 0x1D7E760 | `_isForceFire`, muzzles by Boss02MZ names, creates controllers |
| ReStart | 0x1D80710 | state 0, roll/speed zero, turn 0, aim true, patrol reset (r 5, dir 1, target speed 10, phase Stop), cores = Euler(180,0,0), `_isDirtyTransform` |
| GetStart | 0x1D7E4B0 | OffCollision |
| StateExec | 0x1D80D90 | dispatch; roll clamp ±4 |
| SetState / CheckNextState | 0x1D80D50 / 0x1D7D2D0 | |
| HandleFrontModeNextState / HandleBackWingNextState | 0x1D7E530 / 0x1D7E4E0 | Passed90, LowHP, parts 1/2 |
| PatternEntry | 0x1D7F1B0 | SE 61, 3.5 s, flags 1 / 0x22 |
| PatternMove1/2/3 | 0x1D7F410 / 0x1D7F620 / 0x1D7F830 | 5, 1, 0.5, 0.2/0.1/0.05 |
| <PatternMove1>b__110_0 | 0x1D81110 | Fire1 + toggle |
| PatternMove5 | 0x1D7FA40 | 5 s post-arrival, controllers inlined |
| PatternMove6 / 7 | 0x5BCDB0 | empty |
| OpenBackWing | 0x1D7EC30 | SE 70/71, 2.0, 0.5, ±90, −60, 180 |
| PatternMoveDestruction | 0x1D80030 | −150 y, Euler(120,0,45), 3.5 + 2 s, 5.5, 0.2, shakes, SE 40/42 |
| ToDestroid | 0x1D80EC0 | trophy 8 |
| OnPartsBreak | 0x1D7EBE0 | shake 1/3/4 |
| GetSmallBombPosition | 0x1D7E3C0 | 0.5/0.75/0.9 |
| GetBossBT / GetBossCD / GetMuzzle | 0x1D7E2C0 / 0x1D7E310 / 0x1D7E390 | |
| Fire1/2/3/5/6/7 | 0x1D7DA60 / 0x1D7DB30 / 0x1D7DBE0 / 0x1D7DCB0 / 0x1D7DD70 / 0x1D7DF10 | 0.5 s delay, pack names |
| TrackPlayerHorizontally | 0x1D80F80 | 1/60 substep |
| ExecuteHorizontalChaseStep | 0x1D7D450 | ±80, 1.5, 58.5, 10, 20, accel 6/4 |
| DampHorizontalVelocity / ResolveTargetVelocity (unused) | 0x1D7D340 / 0x1D80AE0 | |
| UpdateRollAngle | 0x1D81140 | 1.5, ±4, 20, 3 |
| RotateBackCorePair / ResetBackCoresRotation / ActivateUnderWingCores / InitializePatternState / AdvanceTurnCounter / ExecutePatternFireLoop / ProcessCooldown / ExecutePatrolPattern / GetCurrentTurnDuration | 0x1D80C50 / 0x1D80A10 / 0x1D7D250 / 0x1D7E720 / 0x1D7D2B0 / 0x1D7D9B0 / 0x1D806D0 / 0x1D7D840 / 0x1D7E360 | outlined copies of inlined code |
| Fire5Controller.Update / Fire6Controller.Update / Fire7Controller.Update | 0x1D86C50 / 0x1D86D30 / 0x1D86F10 | 0/5/0; 5/10; 1/0.1/2/4/5 |
| Patrol: EnsureInitialized / UpdateStraightPhase / UpdateOrbitPhase / StartOrbitPhase | 0x1D874E0 / 0x1D88870 / 0x1D882C0 / 0x1D87FB0 | 5, 40, 10/20, 3/2, 8, 3, 0.95, 0.001 |
| Patrol: PrepareStraightSegment(4) / (1) / TransitionToNextStraightSegment / ComputeOrbitContactPoint | 0x1D87A70 / 0x1D87C90 / 0x1D88230 / 0x1D872F0 | 1e−6, 1e−5 |
| Patrol: BeginSpeedTransition / AdvanceSpeed / ClampMoveSpeed / get_CurrentMaxSpeed | 0x1D87110 / 0x1D87010 / 0x1D87290 / 0x1D88BF0 | 10, 8/20, 9.999, 1e−4 |
| Patrol: RefreshCurrentTarget / GetNextSequenceIndex / GetOrbitPosition / GetOrbitTangent / FindNearestPatrolPointIndex (unused) / Reset | 0x1D87D60 / 0x1D87850 / 0x1D878C0 / 0x1D87980 / 0x1D87710 / 0x1D87E20 | |
| Ene_BosBase: LocalLateUpdate / ProgressBossTimer / UpdateHPState / ResetBossTimer / StopBossTimer / ToDestroid / _callDeadEffect / IsCallSmallBomb / CurrentTargetVector / CurrentTargetAngle / GetDirectionRate / SetDirectionTime / SkyExplosionEffect / GetBT / IsOverHP / IsOverStep / ReStart / InitializeToPlay / .cctor | 0x1DB9FF0 / 0x1DBA1D0 / 0x1DBAD20 / 0x1DBA430 / 0x1DBA790 / 0x1DBAC60 / 0x1DBAEB0 / 0x1DB9E90 / 0x1DB9630 / 0x1DB95C0 / 0x1DB9A20 / 0x1DBA4D0 / 0x1DBA5C0 / 0x1DB9840 / 0x1DB9FD0 / 0x1DB9FE0 / 0x1DBA390 / 0x1DB9A90 / 0x1DBAFF0 | 10 s steps, 180 s, hp ranges, SE 177, shakes, 0.1/0.9 bomb timing |
| EnemyMover._execStackEvent | 0x1D6CED0 | FinishWait (1001) sets `_isFinishDelay` |
| UIBossGauge..cctor | 0x1DD5170 | 180 |
| RandomUtility.Range(int,int) | 0x1DF1780 | inclusive |

Field offsets used (instance): `_bos02state` 0x270, `_localTime` 0x280, `_moveSpeed` 0x284, `_moveDirHold` 0x288,
`_rotateZ` 0x28C, `_backWingMode` 0x290, `_turnCount` 0x2C8, `_attackDuration` 0x2CC, `_cooldownTimer` 0x2D0,
`_fireTimer` 0x2D4, `_fire1NextAimPlayer` 0x2D8, `_fire1Count` 0x2DC; base `_patternMode` 0x1EC; mover `_laserCancelFlag`
0x1D4, `_isForceFire` 0x292, `_isFinishDelay` 0x2B8 (FieldOffsetAttribute in types.jsonl).
Unresolved helper calls identified by use: 0x5D2DF0 Vector3.magnitude, 0x578890 atan2f, 0x578460 acosf, 0x576BF0 cosf,
0x578040 sinf, 0x578740 floorf.

## 9. Open questions

* `PlayTimeFactor` value and when it differs from 1 [?].
* What consumes `_laserCancelFlag` (assumed: active lasers of this boss are cancelled on a part break) [I].
* Whether `BreakParts` from HandleFrontModeNextState also triggers `OnPartsBreak` (shake/laser cancel) [?], and whether
  `upperl` muzzles keep firing PT2 after their wing is broken (the code does not check) [?].
* How MasterBody parts (core, under wings) route damage into the body HP and how the death call reaches `ToDestroid` [I].
* Meaning of the route Animation event's vector (0,0,−250) and the boss event end time 540 s (108 s after spawn) for an
  undefeated boss; TimeupAction at 180 s does nothing in Ene_Bos02 [?].
* `bos02_00_sa01` is preloaded but never spawned by Ene_Bos02 code; if the original shows Sa01 drones during the fight they
  come from another system (check with the pioneer) [?].
* `SkyExplosionEffect` layer argument is a static int (TypeInfo idx41050 +0x20), class not resolved [?].
* The PartsKind enum labels Under06/Under04 disagree with the prefab PartsList order (index 3 = under04); behaviour does not
  depend on it.
