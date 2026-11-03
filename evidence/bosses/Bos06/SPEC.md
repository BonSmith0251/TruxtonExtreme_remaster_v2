# Ene_Bos06 (BG07 boss): behaviour spec from native code

Source: `D:\games\Truxton Extreme\GameAssembly.dll` (IL2CPP x64). Every number below comes from the disassembly in
`dis/` (capstone, with call targets and .rdata floats annotated by `disasm.py`) or from the Cpp2IL ISIL dump in `isil/`
(the ISIL gives string literals and `typeof` names). Branch senses were checked against the raw x86, because the ISIL
gets `test`/bit conditions wrong (for example the PT1 circuit parity). Constants: `bos06-constants.json`.
`[I]` = inference, `[?]` = unknown. Offsets: `+0xNNN` = Ene_Bos06 instance field. `S+0xNN` = Ene_Bos06 static.

## 1. Identity

| item | value | source |
|---|---|---|
| class | `InGame.Kernel.Enemy.Ene_Bos06 : Ene_BosBase : PawnEnemy`, nested `CoreMovement`, `BatteryMovement`, `<>c__DisplayClass6_0` | types.jsonl |
| prefab | `Reconstructed/Assets/OriginalRecovered/Samples/Prefabs/Reference/Enemy/Pf_Ene_Bos06.prefab` (model root `pf_bs06` = `_modelTop`) | prefab |
| EnemyData | `ene_boss06` (id 1b306aff…), position (0,0,30), placement moveSpeed 20 lookAt 1, duration 100. Stack events: type 9 `anc_bs06_start` (animation), type 80 "Start" int 16, type 1001 "Start" int 1 | StageEnemies/BG07.json |
| schedule | timeline clip `boss06` (tt_boss06) runs from **397.0 s** to 480 s. Boss BGM section (sectionKind 3) starts at 395 s. Areas: BG07_BOSSST 395–420, BG07_BOSSLP 420–480 | BG07.json, raw-stage-timelines.json |
| main HP | 1,000,000 (row 58, key Bos06), score 100000, lockOn true, blocksLaser true | enemy-database.json |
| parts (PartsList index = `PartsKind`) | 0 MainBody: flags 1 (MasterBody), collisions bodyMain (NoLockOn), laserL, laserR. 1 TopBody: flags 1, `bs06_body01_top01`, collision bodyTop (OnlyBullet), BreakEffect pf_eff_explposion02. 2 "LeftBody" = **body40** `bs06_body01_40`: flags 18 (Independent, SleepStart), HP 250,000, collisions body40 [idx0] and body40c [idx1], BreakEffect pf_eff_explposion05. 3 "RightBody" = **body60** `bs06_body01_60`: same, HP 250,000. 4 CoreBody `pf_bs06_core01`: flags 17 (MasterBody, SleepStart), collision bodyCore, damage object `core01/damage`, BreakEffect pf_eff_explposion03 | prefab, enemy-hitshapes.json |
| naming trap | PartsKind.LeftBody (2) is body40, which is the same object as `_bodyR`. `_bodyL`/`_laserL` are the **60** side. Muzzle enum `muzzle_batteryL` is body40's battery muzzle. Keep these exact pairings; do not rename by side. | ReStart 0x1D9DAE0 |
| Initialize | `_mover._isForceFire = true` (fires even outside the play area) | 0x1D9B590 |
| GetStart | wakes parts 0 and 1; `SetObjectFlag(OffCollision)` | 0x1D9B530 |
| bomb | `IsBomberRange()` is false in PT3Break and PT6Bind: the player bomb does not reach the boss there | 0x1D9B5C0 |
| time-out | `TimeupAction` is the empty Ene_BosBase override. Time-out only matters through ActStep (see cover break) | 0x5BCDB0 |

Muzzles (`_muzzles[Boss06MZ]`, the paths are under `Pf_Ene_Bos06/pf_bs06/`):

| # | enum | transform |
|---|---|---|
| 0 | muzzle_core_core | pf_bs06_core01/muzzle_core_core |
| 1 | muzzle_core_battery | pf_bs06_core01/muzzle_core_battery |
| 2 | muzzle_top_core | bs06_body01_top01/muzzle_top_core |
| 3 | muzzle_body_core_40 | bs06_body01_40/muzzle_body_core_40 |
| 4 | muzzle_body_core_60 | bs06_body01_60/muzzle_body_core_60 |
| 5 | muzzle_batteryL | bs06_body01_40/pf_bs06_body01_battery01_40/muzzle_battery |
| 6 | muzzle_batteryR | bs06_body01_60/pf_bs06_body01_battery01_60/muzzle_battery |
| 7 | targetL | …battery01_40/muzzle_battery/target40 |
| 8 | targetR | …battery01_60/muzzle_battery/target60 |
| 9,10 | bindD, bindU | bs06_body01_40/muzzle_body_attack_10, _20 (no code uses them) |

Serialized transforms: `_laserL` = bs06_body01_60/pf_bs06_body01_battery01_60. `_laserR` = bs06_body01_40/…battery01_40.
`_bodyL` = bs06_body01_60. `_bodyR` = bs06_body01_40. `_bodyCore` = pf_bs06_core01. `_bindEffect` = ParticleSystem on
bs06_body01_60/pf_eff_e_attack01. `_easingCurve` keys (t,v): (0,0) (0.2,0.15) (0.5,0.5) (0.8,0.85) (1,1), an S-curve. The slopes are in the JSON.

Bullet templates are `GetBT(i)` = `btemplates[i]`, built from `btNames` (`Boss06/<name>`). The code uses only
laser01 (0), core1–core4 (3–6), core1short (8), side1 (9) and side2 (10). **sideway (1), core0 (2) and bind0 (7) are
loaded but never fired.** The template parameters are in `Resources/StageCombat/enemy-attacks.json` (`patterns`, e.g. core1short:
10 rapid, isTarget, arc 180, wayswitch 6; laser01: enemylaser001, isSelfDir, irradiation 1).

## 2. Frames and units

* Source sky plane: x right, z up the screen, y toward the camera (camera (0,400,0), 20° vertical FOV).
* **root-local** = the Pf_Ene_Bos06 transform's `localPosition`. It starts at EnemyData (0,0,30). Its normal rotation is identity, because
  PT3Break slerps it back to `Quaternion.identity`. [I] It is in sky units.
* **model-local** = children of `pf_bs06`. After entry, `pf_bs06.localRotation = Euler(0,180,0)`, so model x = −sky x
  and model z = −sky z [I]. This makes `_bodyL` (+110 model x) sit on screen left.
* Ene_BosBase per frame (`LocalLateUpdate` 0x1DB9FF0, only when dt>0): the nearest player's sky position P goes to
  `_baseTargetPlayer` (+0x1F0). Flags: Left = P.x<0, Down = P.z<0, **Bottom = P.z < −20**, **Center = −100 < P.x < 100**.
  Then `ProgressBossTimer` runs, then `StateExec`.
* Boss timer (`ProgressBossTimer` 0x1DBA1D0, `ResetBossTimer` 0x1DBA430): BossTime advances once the timer is started, and
  **ActStep goes +1 every 10 s** (step 18 = TimeOver, reached when BossTime ≥ `UIBossGauge` static [?]). `_hpState` is the first
  i with hpRate > {.9,.75,.51,.4,.3,.2,.1,0}[i]. `IsOverAorB(h,s)` = `_hpState ≥ h || ActStep ≥ s`.
  Direction timer: `SetDirectionTime(T,scale)` resets it; `GetDirectionRate()` = clamp01(passed/T).
* Easing helpers (checked in the disassembly): OutQuad = 1−(1−t)². OutQuart = 1−(1−t)⁴. InOutQuad is standard. InSine01 = 1−cos(90t°).
  `CurrentTargetVector(r,Linear)` = Lerp(_startVector,_targetVector,r). `CurrentTargetAngleSlerp` = Slerp. `CurrentTargetAngle` = Lerp.
* `VectorUtility.CircleSymbol(t,w,h)` (0x1DF6AF0): a = 90 + 360·clamp01(t) (degrees). It returns **(w·cos a, 0, h·(1−sin a))**:
  a loop from the origin through (−w,h), (0,2h), (w,h) and back to the origin.

## 3. State machine (`_bos06state` +0x2B0, `_patternMode` +0x1EC)

`StateExec` (0x1D9E370, jump table 0x1D9E510) dispatches: −1 nothing, 0 EntryWait, 1 PT1, 2 PT3Break, 3 PT6Bind,
4 PT7Change, 5 PT8 (inline code, identical to `PatternMovePT8`), 100 Destruction. `SetState`/`CheckNextState` set
`_patternMode = 0` and clear `mover._laserCancelFlag`. `CheckNextState` order: EntryWait→PT1→PT3Break→PT6Bind→PT7Change→PT8.
PT8 is final. **Only one transition depends on HP or time: PT1→PT3Break.** All the others fire when an animation finishes.

```
EntryWait --(entry stack done)--> PT1 --(HP<=51% or BossTime>=90s, cover breaks)--> PT3Break (~6.5 s)
  --> PT6Bind (2 pinches, ~13 s) --> PT7Change (~2 s) --> PT8 (until HP 0)
any state --(HP 0: ToDestroid)--> Destruction (~5.5 s) --> removed
```

### 3.1 EntryWait (0x1D9BC90)
| mode | action |
|---|---|
| 0 | `_bindEffect` Stop and Clear. Sound 85 `bg7_boss_app_01`. `_localTime = 0`, go to 1 |
| 1 | `_localTime += dt`. At ≥ **3.2 s** (`_EntryNoHitTime`): clear OffCollision, set OffLockon\|NoDamaged, go to 2 |
| 2 | when `mover._isFinishDelay` (the mover's stack events have finished, i.e. after the 5 s `anc_bs06_start` clip [I]): `StopAnime(true)`. `pf_bs06.localPosition = 0`, `localRotation = Euler(0,180,0)`. Clear OffLockon\|NoDamaged. `ResetBossTimer(true)` (BossTime 0, ActStep 0, `_startInGamePosition` = root localPosition). Go to PT1 |

Entry clip `TXE_GraphicData/Boss/Bs06/Animateion/anc_bs06_start.anim` (5 s, on `pf_bs06` via anm_bs06.controller), in root-local space:
position (0,−210,220) at 0 s, (0,−120,10) at 2.33 s, (0,50,−5) at 4 s, (0,0,0) at 5 s. Euler (0,180,180) at 0 s, hold to 1.5 s,
(−45,180,180) at 2.33 s, (10,180,0) at 4 s, (0,180,0) at 5 s.

### 3.2 PT1 (0x1D9BEE0): two alternating patterns, repeated until the cover breaks
Every frame, first: if `!_isCoverOpen && IsOverAorB(HalfHP=3, Passed90=9)` and TopBody is not broken, run the cover break:
SetState(PT3Break). TopBody `BreakParts(ground=false, effect=true, sound=false)` (pf_eff_explposion02 at muzzle_top_core).
`_isCoverOpen = true`. Sound 129 `bg7_boss_parts_destruction_01`. Cancel `_bulletToken`, which **kills the pending core1short and laser01 tasks**. Return.
So the cover breaks at **HP ≤ 51%** or **90 s** of boss time. (`CheckCoverBreak` 0x1D9AF30 and `CoverBreak` 0x1D9B130 are
the same code without the PT1 token cancel. No direct caller was found.)

The lap counter `_circuitCount` is never reset inside PT1. On **even** laps the circle runs backwards: e = 1 − curve(rate). On odd laps e = curve(rate).
Root position every frame of a lap (`_moveCircle` 0x1D9F4C0):
`root = _startInGamePosition + Lerp((−60,0,0),(60,0,0),slider) + CircleSymbol(e, W, H)`.
If the player is not Center, `slider += ±0.02·dt` (minus when the player is Left), clamped 0..1. The slider starts at 0.5.

| mode | pattern | lap length | per lap |
|---|---|---|---|
| 0 | init | – | circuit 0, side attack off, go to 10 |
| 10/11/12 | **P1**: 2 laps | `SetDirectionTime(7)` (`_Pattern1FireInterval` = 2+5) | lap start: sample the side attack (below), `_localTime = 0`. Circle W=20, H=10. When `_localTime` crosses **1.0 s**: `bos06_core1short` from muzzle_top_core, angle 0. At rate ≥ 1: next lap. After 2 laps go to 20 |
| 20/21/22 | **P2**: 3 laps | `SetDirectionTime(4)` | lap start: sample the side attack, `_callLaserBT()` = `bos06laser01` from muzzle_batteryL toward targetL **and** from muzzle_batteryR toward targetR (BulletDirFireAsync, `_bulletToken`). Circle W=30, H=5. Battery yaw: `BatteryMove(a += (A[k]−a)·InSine01(clamp01(t)))` with A = {90,45,0}[lap%3] and t = time in the lap, so it reaches A after 1 s. After 3 laps go to 10 (P1 again) |

Side attack (`SideAttack` 0x1D9E0B0). At each lap start: `_enableSideAttack = !Bottom` and `_isSideAttackLeft = Left`, both sampled then;
`_sideAttackTime = 0`. Each frame where `enable && rate < 0.8`: t += dt. Crossing 0.5 fires `bos06_side1`, crossing 1.0 fires `bos06_side2`,
then t = frac(t). So both fire **once per second during the first 80% of a lap**. Muzzle: Left → muzzle_body_core_60 at
angle **−90**, else muzzle_body_core_40 at **+90**. Both use `BulletFireAsync(CToken, bt, selfDir=false, nested=false, muzzle, null, angle)`.

`BatteryMove(a)` (0x1D9AD50): `_batteryAngle = a`. `_laserL.localRotation = Euler(0,a,0)` and `_laserR.localRotation = Euler(0,−a,0)`.

### 3.3 PT3Break (0x1D9C690, jump table 0x1D9CF34): the cover-break transition
| mode | time | action |
|---|---|---|
| 0 | 1 frame | `mover._laserCancelFlag = 1`. start = root pos/rot. Target position = start + **(0,−150,+50)**, target rotation = **Euler(−60,0,0)**. Direction time 1 s. **ToSleep every unbroken part** (no collisions) |
| 1 | 1.0 s | position Lerp with OutQuad(r), rotation Slerp with OutQuart(r) |
| 2 | 0.5 s | hold. Then sound 130 `bg7_boss_move_the_bow_01`, target rotation identity, direction time 1 s |
| 3 | 1.0 s | rotation Slerp with InOutQuad(r). Then sound 131 `bg7_boss_rise_01`, target position = `_startInGamePosition`, direction time 1.5 s |
| 10 | 1.5 s | position Lerp with InOutQuad(r). Then `_localTime = 0.5` |
| 11 | 0.5 s | then sound 132 `bg7_boss_separation_01`. Direction time 2 s. `CoverPartsHitType(false)`. Core Wakeup and noDamage. `_laserL`/`_laserR` rotation identity. slider 0.5. `CoreMovement.Evacuate()` (core ToSleep, noDamage off, mode ToEvacuate1) |
| 12 | 2.0 s | `_bodyL.localPosition = (110,0,0)·clamp01(OutQuad r)`, `_bodyR` = (−110,0,0)·same (the halves split). `CoreMovement.Progress`. At r ≥ 1 **and** core mode == Evacuated: go to PT6Bind |

### 3.4 PT6Bind (0x1D9CF70): pinch ("gattai") attack. Every frame `CoreMovement.Progress` (the core idles at Safe)
| mode | time | action |
|---|---|---|
| 0 | – | `_attackLoopCount = 2`, sound 133 `bg7_boss_move_01` |
| 10 | 1 frame | home z = `_bodyL.localPosition.z`. target z = home + (player sky z > bodyL sky z ? **−40** : **+40**) (model z, so the bodies move toward the player's row [I]). Direction time 0.8 s |
| 11 | 0.8 s | both bodies z = Lerp(home, target, InOutQuad r). Then direction time 2 s |
| 20 | 2.0 s | close: `_bodyL.x = 110·(1−InCubic r)`, `_bodyR.x = −110·(1−InCubic r)`. At r ≥ 1: sound 134 `bg7_boss_gattai_01`, `_bindEffect.Play()`, direction time 1 s |
| 21 | 1.0 s | hold closed. Then direction time 2 s |
| 22 | 2.0 s | open: x = ±110·InOutCubic(r). Then `if (--_attackLoopCount > 0)`: sound 132, go to 10. Else direction time 1 s, go to 30 |
| 30 | 1 frame | `_pinchTargetPositionZ = _bodyL.z`, sound 131, direction time 1.5 s |
| 31 | 1.5 s | both z = InOutCubic(1−r)·that z, ending at 0. Then go to PT7Change |

Two pinches of about 5.8 s each, then 1.5 s. The pinch has no bullet: the hit is the closing side bodies. While closed, their collision 0
(body40/body60) is enabled with `_noDamageFlag` set, so they are solid but take no damage [I].

### 3.5 PT7Change (0x1D9D5F0). Every frame `CoreMovement.Progress`
| mode | action |
|---|---|
| 0 | `CoreMovement.Combat()`: `mover.DelayAnimationTask(animator 1, delay 0, hash "anc_bs06_core01_cover_op")` (core covers open, 0.25 s clip). Core `ChangeColorTask(PawnEnemy.DarkColor (0.5,0.5,0.5,1), 0.5 s, reverse=true)`. Core Wakeup. Core mode ToCombat, core rotation −= 180. Then `CoverPartsHitType(true)`, sound 86 `bg7_boss_open_arm_01`, direction time 2 s |
| 1 | 2 s: `_bodyL.localRotation = Slerp(id, Euler(0,−45,90), OutQuad r)`, `_bodyR = Slerp(id, Euler(0,45,−90), OutQuad r)`. At r ≥ 1 **and** core mode == Combat: go to PT8 |

### 3.6 PT8 (0x1D9D9F0 and the inline copy in StateExec): final phase
First frame: `leftBattery.Attack(0)`, `rightBattery.Attack(1.5)`. That sets timer = −delay and starts the battery.
Every frame: `CoreMovement.Progress(dt)`, then both `BatteryMovement.Progress(dt, _baseTargetPlayer)`.

### 3.7 Destruction (0x1D9B650), entered via `Ene_Bos06.ToDestroid` (0x1D9E530) at HP 0
`ToDestroid`: trophy 7 if IsTrophy. StopBossTimer. `mover.DeleteRouteToken`. Cancel `_bulletToken`. ReleaseToken.
`CoreMovement.Terminate` and both `BatteryMovement.Terminate`. state 100, mode 0. Base ToDestroid is deferred to mode 30.

| mode | time | action |
|---|---|---|
| 0 | – | each unbroken side body (parts 2, 3): `BreakParts(effect=true, sound=false)` (pf_eff_explposion05). `_localTime = 0.5` if any broke, else 0 |
| 1 | 0.5/0 s | wait |
| 2 | – | core start = core localPosition, target = start + **(0,−150,0)** (model-local). Rotation to **Euler(−80,60,0)**. `_localTime = 3`. Direction time **5 s**. `SetSmallBombSecond(0.2)`. `AddShake(0.5 s, pow 1, speed 2)` |
| 10 | 3 s | core position Lerp with EaseIn(r) and rotation Quaternion.Lerp(r). Small bombs (below). At the end: `AddShake(0.5,1,5)`, vtable 0x588 = `_callDeadEffect` [I] (once: `CinemachineMan.ShakeCamera(1,3,1)`, vibration (0.5,0.8,2), then PawnEnemy dead effect `pf_eff_explposion_boss`). `_localTime = 2` |
| 11 | 2 s | same motion and bombs |
| 30 | – | sound 42 `exp_st3_boss_c03`. `Ene_BosBase.ToDestroid()` (vibration 0.8/1/2, `_isBossDead`, PawnEnemy.ToDestroid) |

Small bombs (`IsCallSmallBomb` 0x1DB9E90): when the countdown reaches ≤0, it resets to base + rand·0.1 and base ×= 0.9.
Base starts at 0.2 s. Each bomb is `SkyExplosionEffect(ShortCutEffect.ExplosionCodeSmall, pos, LayerUtility.EnemySkyLayer, se 40 exp_st3_boss_a01)`,
with pos = `GetSmallBombPosition()` = world position of `_muzzles[Range(1,2)−1]` (inclusive range, so muzzle_core_core or muzzle_core_battery).

## 4. Sub-movers

### CoreMovement (`_coreMovement`, controls `_bodyCore` model-local; `_mode` +0x10)
Statics: EvacuateDelay 0.5, EvacuateTime 1, RotatePerSecond 180, FloatingCycleTime 3, FloatingCycleDistance 20,
CombatTime 1.5, CircuitTime 5, CircuitRadius 10, CircuitFireTiming 0.8. `_firePatternCount` starts at 2 (ReStart), maximum 4.
Float: `f = Repeat(f + dt/3, 1)` and offset z = 20·sin(2πf). Spin: local **Euler(0,0,rot)**.

| mode | Progress (0x1D8A2E0, jump table 0x1D8AD08) |
|---|---|
| 0 Home | nothing. At ReStart the position is Home (0,0,−5) |
| 1 ToEvacuate1 | timer += dt. At > 0.5 s: core `ChangeColorTask(DarkColor, 1 s, reverse=false)` (darkens), timer = rot = f = 0, go to 2 |
| 2 ToEvacuate2 | t = clamp01(timer/1). pos = Lerp(Home, Safe(0,−50,−20) + (0,0,float), OutQuad t). rot = Repeat(rot + t·dt·180, 360). At t ≥ 1 go to 3 |
| 3 Evacuated | pos = Safe + (0,0,float). rot += 180·dt |
| 4 ToCombat | t = clamp01(timer/1.5). pos = Lerp(Safe + float, Attack(0,0,−30), OutQuad t). Shown rotation = rot + OutCubic(t)·d, where d = the shortest signed angle from rot to 0. When t ≥ 1 and the mover AnimationTask flag (16) is clear: timer = rot = accel = fireCount = 0, go to 5 |
| 5 Combat | accel = clamp01(accel + dt). timer = Repeat(timer + accel·dt, 5). pos = Attack + CircleSymbol(timer/5, 10, 10). When timer crosses **0.8**: k = fireCount % firePatternCount. k 0: `bos06_core1` from muzzle_core_battery. k 1: `bos06_core2`, k 2: `bos06_core3`, k 3: `bos06_core4`, all from muzzle_core_core, angle 0, via `_callBT` (`_bulletToken`). Then fireCount = (fireCount+1) % count. That is **one core volley per 5 s circuit**, rotating through the patterns |

`OnPartsBreak(2 or 3)` (0x1D9B5E0): marks that side body broken (once) and `_firePatternCount++` up to 4. So breaking one side
body adds core3 and breaking both adds core4. The base OnPartsBreak is empty.

### BatteryMovement (`_leftBattery`: cover=_bodyL(body60), battery=_laserL, muzzle=muzzle_batteryR, target=targetR; `_rightBattery`: body40, _laserR, muzzle_batteryL, targetL)
Statics: LaserInterval 3, FollowStart 0, FollowStop 1, LaserCallTime 0.2, FollowTime 1, FloatingCycleTime 5, FloatingCycleDistance 10.
`Progress(dt,P)` (0x1D9FCE0) runs only once enabled (`Attack`). It advances the timer (old → new = old+dt):
* At a crossing of 0 or 3: startYaw = battery world eulerY. targetYaw = `InGameBulletManager.GetTargetBulletArc(SkyRoot(battery.position), P)`.
* While 0 ≤ new < 1: `battery.rotation = Euler(0, LerpAngle(startYaw, targetYaw, InOutQuad(new)), 0)` (world rotation). The battery turns to the player over 1 s.
* At a crossing of 0.2 or 3.2: `CallLaser(muzzle, target)` = `bos06laser01` via BulletDirFireAsync with **CToken**. That token is not cancelled by cover break.
* timer = Repeat(timer, 3). Body bob: `cover.localPosition.z = 10·sin(2π·f)` with f advancing dt/5 (5 s period).
So each side fires a laser every 3 s, 0.2 s after it starts turning, and the laser follows the turn [I: laser parented to the muzzle].
The right side runs 1.5 s behind the left.

## 5. Parts and damage windows

| phase | hittable | notes |
|---|---|---|
| Entry 0–3.2 s | none (OffCollision) | then collision on with OffLockon\|NoDamaged until the entry ends |
| PT1 | MainBody (bodyMain, laserL, laserR) and TopBody (bodyTop, OnlyBullet), both MasterBody, so damage goes to the main HP | cover (TopBody) breaks by rule, not by its own HP |
| PT3Break | none: all unbroken parts ToSleep, and no bomb | at the end `CoverPartsHitType(false)` enables side collision 0 (body40/body60) with `_noDamageFlag` (shield) and disables collision 1 |
| PT6Bind | core asleep, sides are solid shields, no bomb | MainBody stays asleep from here on |
| PT7Change/PT8 | core (MasterBody, so the main HP) after `Combat()` Wakeup. Side bodies via collision 1 (body40c/body60c), damageable, 250k each | `CoverPartsHitType(true)` |
| Homing target (`GetHormingTarget` 0x1D9B340) | cover closed: root `_basePosition`. Cover open: part k = (state PT6Bind ? (i even ? 3 : 2) : [3,2,4][i%3]); the part's first collision position, or root if that part is broken | lambda 0x1DB8DE0 |

Sleep and Wakeup set and clear bits 0x60 on every collision of the part. `CollisionsChageEnable(i,b)` sets or clears the same bits on collision i.

## 6. Animator usage
* `anm_bs06.controller` on pf_bs06: `anc_bs06_start` starts from the EnemyData type-9 event. `StopAnime(true)` runs at the end of entry.
* `anm_bs06_core01.controller` on pf_bs06_core01: `anc_bs06_core01_cover_op` (0.25 s, moves cover_02/04/06/07/09 local z from 1.38 to −1.1).
  It is played by `CoreMovement.Combat` through `DelayAnimationTask(1, …, CoreAnimeHash)`. ToCombat waits until the animation task flag clears.
* Everything else (body slide and pinch, tilt, battery yaw, core path, root path) is script-driven transforms, as above.

## 7. Sounds (SoundUtility.ID)
85 bg7_boss_app_01 (entry). 129 bg7_boss_parts_destruction_01 (cover). 130 move_the_bow. 131 rise. 132 separation.
133 bg7_boss_move_01. 134 gattai. 86 open_arm. 40 exp_st3_boss_a01 (small bombs). 42 exp_st3_boss_c03 (final). Prefab `_overplayDeadSound` 41.

## 8. Address table (RVA, see `dis/<name>_<rva>.txt` and `isil/`)
| method | RVA | constants taken |
|---|---|---|
| Ene_Bos06..cctor | 0x1D9EC90 | all `S+` statics (JSON) |
| ReStart | 0x1D9DAE0 | slider 0.5, body/core resets, sub-mover wiring, firePatternCount 2 |
| Initialize / GetStart / IsBomberRange / CallDisabled | 0x1D9B590 / 0x1D9B530 / 0x1D9B5C0 / 0x1D9AE40 | flags |
| StateExec (+ table 0x1D9E510) | 0x1D9E370 | dispatch, inline PT8, 1.5 delay |
| SetState / CheckNextState | 0x1D9E070 / 0x1D9B050 | order |
| PatternMoveEntryWait | 0x1D9BC90 | 3.2 |
| PatternMovePT1 | 0x1D9BEE0 | 0.8, parity bit test 0x1D9C147 |
| _moveCircle / VectorUtility.CircleSymbol | 0x1D9F4C0 / 0x1DF6AF0 | 0.02, 90+360t |
| SideAttack / CheckSideAttack | 0x1D9E0B0 / 0x1D9B100 | 0.5, 1.0, ±90 |
| BatteryMove / _callBT / _callLaserBT / CallLaser | 0x1D9AD50 / 0x1D9E8F0 / 0x1D9EA80 / 0x1D9AE80 | muzzle indices |
| CheckCoverBreak / CoverBreak | 0x1D9AF30 / 0x1D9B130 | IsOverAorB(3,9) |
| PatternMovePT3Break (+ table 0x1D9CF34) | 0x1D9C690 | (0,−150,50), 1/0.5/1/1.5/0.5/2 s |
| CoverPartsHitType | 0x1D9B220 | collision 0/1 swap |
| PatternMovePT6Bind / coverMoveX | 0x1D9CF70 / 0x1D9E6C0 | 0.8/2/1/2/1.5, ±40, 110 |
| PatternMovePT7Change / PT8 | 0x1D9D5F0 / 0x1D9D9F0 | 2 s tilt |
| PatternMoveDestruction / ToDestroid / GetSmallBombPosition | 0x1D9B650 / 0x1D9E530 / 0x1D9B4B0 | 0.5, 150, (−80,60,0), 5, 3, 2, 0.2 |
| OnPartsBreak / GetHormingTarget / lambda | 0x1D9B5E0 / 0x1D9B340 / 0x1DB8DE0 | |
| CoreMovement .cctor / Progress (+ table 0x1D8AD08) / Combat / Evacuate / AddAdditionalPattern | 0x1D8ADA0 / 0x1D8A2E0 / 0x1D89FE0 / 0x1D8A160 / 0x1D89FD0 | core statics |
| BatteryMovement .cctor / Initialize / Attack / Progress / GetTargetDegAngle / Terminate | 0x1DA03C0 / 0x1D9FB20 / 0x1D9F990 / 0x1D9FCE0 / 0x1D9F9B0 / 0x1DA0350 | battery statics |
| Ene_BosBase LocalLateUpdate / ProgressBossTimer / UpdateHPState / IsOverAorB / ResetBossTimer | 0x1DB9FF0 / 0x1DBA1D0 / 0x1DBAD20 / 0x1DB9FB0 / 0x1DBA430 | −20, ±100, 10 s steps |
| Ene_BosBase SetDirectionTime / GetDirectionRate / CurrentTargetVector / CurrentTargetAngle(Slerp) | 0x1DBA4D0 / 0x1DB9A20 / 0x1DB9630 / 0x1DB95C0 (0x1DB9550) | |
| Ene_BosBase IsCallSmallBomb / SetSmallBombSecond / _callDeadEffect / ToDestroid / GetBT / IsAttackLoop | 0x1DB9E90 / 0x1DBA5A0 / 0x1DBAEB0 / 0x1DBAC60 / 0x1DB9840 / 0x1DB9E60 | 0.1, 0.9 |
| EasingUtility OutQuad01 / OutQuart01 / InOutQuad01 / InSine01 | 0x1DE8B70 / 0x1DE8B90 / 0x1DE8650 / 0x1DE8840 | |

## 9. Open questions
1. **Center rule versus field width.** The slide only runs when |player x| ≥ 100 sky units. If the play field half-width is ≤ 100
   (100·aspect in the remaster's mapping), the boss never slides and stays at start + circle. Check this in the original with the pioneer.
2. **Entry end.** EntryWait mode 2 waits for `mover._isFinishDelay`, which `EnemyMover._execStackEvent` sets when the EnemyData stack events
   (type 9 anim, type 80 wait-for-task 16, type 1001) are done. The exact time (about 5 s) is [I]. Event 1001's meaning is [?].
3. Boss time limit `UIBossGauge` static [0] is unknown. It does not change Bos06 behaviour (empty TimeupAction).
4. `GetTargetBulletArc` angle convention versus the battery's Unity yaw is [?]. The intent is that the battery's muzzle→target axis aims at the player.
5. Whether a slept part (side bodies keep `_sleepFlag`) still takes damage when `CollisionsChageEnable` re-enables its collision.
   Assumed yes in PT7/PT8 [I].
6. vtable slot 0x588 assumed to be `_callDeadEffect` [I]. PawnEnemy.ToDestroid calls the same slot first.
7. Direct callers of `CheckCoverBreak`, `CoverBreak` and `AddAdditionalPattern` were not found. PT1 and OnPartsBreak inline the same logic.
8. Sky-frame signs of model-local motions (pinch ±40, core Attack z −30 → sky +30) rest on the 180° yaw of pf_bs06 [I].
