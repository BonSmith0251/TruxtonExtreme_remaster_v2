# Ene_Bos05 (BG05 boss) - behaviour spec from the native code

Classes: `InGame.Kernel.Enemy.Ene_Bos05 : Ene_BosBase : PawnEnemy` and its summoned arm
`InGame.Kernel.Enemy.Ene_Bos05_Arm : PawnEnemy`. Every value below comes from `GameAssembly.dll`
(addresses in section 8). `[I]` = inference, `[?]` = unknown. Constants: `bos05-constants.json`.
Disassembly: `bos05-and-arm.asm.txt` (all methods of both classes, annotated), `base-helpers.asm.txt`
(Ene_BosBase / EasingUtility / RandomUtility / KernelUtility / ShortCutEffect helpers). Tools: `dis.py`
(annotated disassembler: call names, .rdata floats, metadata usages decoded through metareg 0x183DB4460,
field names per class), `jt.py` (switch tables), `prefab_dump.py` (prefab paths; output in `prefab_*_dump.txt`).

## 1. Identity

| item | value |
|---|---|
| prefab | `Samples/Prefabs/Reference/Enemy/Pf_Ene_Bos05.prefab` (model root `pf_bs05` = `_modelTop`; mesh under `pf_bs05/RotX-65_Scal0.85` = X -65 deg, scale 0.85) |
| EnemyData | `ene_boss05` in `Resources/StageEnemies/BG05.json`: position (0,0,37), moveSpeed 20, lookAt 1, attribute 1072; events: Animation(9) `anc_bs05_start`, TaskWait(80) `Start` (int 16), FinishWait(1001) `Start` |
| schedule | BG05 group `main/tt_boss05`, event start **450 s** (end 540) |
| battle time | `GetBattileTime` = `UIBossGauge.defaultBossTimeMax` = **180 s** (not overridden) |
| arm enemy | clip `bos05_arm` (EnemyData `Samples/EnemyData/boss/bos05_arm.asset`: object `Pf_EneObj_Bos05_Arm`, moveSpeed **35**, attribute 512); pool `EnemyChildData("Pf_EneObj_Bos05_Arm", null, 20)` |
| dead explosion | `pf_eff_explposion_boss`, `_explosionOffset` (0,20,0), `_overplayDeadSound` 41 (`exp_st3_boss_b02`) |

Parts (prefab `PartsList` index = part number used by the code; HP from `enemy-database.json` rows 52-57):

| # | PartsKind | parts name | HP | lock-on | laser | collision (prefab) | break effect | renderers |
|---|---|---|---|---|---|---|---|---|
| 0 | MainBody | (body) | **1,000,000** | yes | blocks | `pf_bs05/bodyout` capsule r27 len20, `pf_bs05/bodyside` capsule r39 len30 | - (damage obj `RotX-65_Scal0.85/damage`) | `me_bs05/body`, `laser_neck/laser_body` |
| 1 | Arm40 | `arm40` | 10,000 | no | blocks; collision attribute LaserBlock(4) | `RotX-65_Scal0.85/arm40/arm40` capsule r10 len30 yaw -90 | `pf_eff_explposion03` | `arm40/arm40_scale/arm40_mesh` |
| 2 | Arm60 | `arm60` | 10,000 | no | blocks; LaserBlock | `.../arm60/arm60` capsule r10 len30 yaw +90 | `pf_eff_explposion03` | `arm60_mesh` |
| 3 | Leg40 | `leg40` | 10,000 | yes | blocks | `pf_bs05/leg40` capsule r10 len30 (x -35) | `pf_eff_explposion02` at `pf_bs05_leg40` | upper/under of legs 10, 40, 70 |
| 4 | Leg60 | `leg60` | 10,000 | yes | blocks | `pf_bs05/leg60` (x +35) | `pf_eff_explposion02` at `pf_bs05_leg60` | upper/under of legs 30, 60, 90 |
| arm enemy | - | `Bos05_Arm` row 57 | **50,000** | yes | collision LaserBlock | `Pf_EneObj_Bos05_Arm/collision` capsule r10 len32 | dead `pf_eff_explposion02` | `scaleNode/pf_bs05_arm` |

Hit circles (enemy-local X/Z) are in `enemy-hitshapes.json` model `Pf_Ene_Bos05`.

Serialized references (`Ene_Bos05` MonoBehaviour):
`_Turret` = `me_bs05/laser_neck/laser_body`; `_Arm40` / `_Arm60` = `RotX-65_Scal0.85/arm40`, `/arm60`;
`_Arm40Mesh` = `arm40/arm40_scale/arm40_mesh`; `_Arm40Scale` = `arm40/arm40_scale` (same for 60).
`_BreakableLegs[LegId]` (`_muzzle` / `_upper` / `_lower`):

| LegId | muzzle (under `me_bs05/body`) | renderers | part | `_LegAngle` (deg) |
|---|---|---|---|---|
| 0 leg10 | `muzzle_body10` (-49.3,-13.1,5.5) | `pf_bs05_leg10/leg_upper`, `.../leg_under` | Leg40 | +30 |
| 1 leg40 | `muzzle_body40` (-45.4,13.9,10.6) | `pf_bs05_leg40` | Leg40 | +45 |
| 2 leg70 | `muzzle_body70` (-30.8,33.1,16.7) | `pf_bs05_leg70` | Leg40 | +60 |
| 3 leg30 | `muzzle_body30` (49.3,-13.1,5.5) | `pf_bs05_leg30` | Leg60 | -30 |
| 4 leg60 | `muzzle_body60` (45.4,13.9,10.6) | `pf_bs05_leg60` | Leg60 | -45 |
| 5 leg90 | `muzzle_body90` (30.8,33.1,16.7) | `pf_bs05_leg90` | Leg60 | -60 |

`_muzzles[Boss05MZ]` are found by name (`FindAlls(_modelTop, enumName)`, Initialize 0x1D95BD0):
0 `muzzle_body20` (front gun, `me_bs05/body`, (0,-19.09,49.32)), 1 `muzzle_body21` (belly gun, (0,-33.39,18.37)),
2 `muzzle_turret_laser` (`laser_body`, (0,7.35,24.23)), 3 `turret_edge` (child of 2, (0,0,1)).
Muzzle pack `turret` (EnemyMover `_muzzlePacks`): `laser_body/muzzle_turret70, 10, 90, 30`.

Invulnerable / no-lock windows (InGameObjectFlag): GetStart sets `OffCollision`. EntryWait: at 2.5 s clear
`OffCollision`, set `OffLockon|NoDamaged` (0x22); when the entrance route reports finished, clear 0x22 (fully
hittable). PT6Belly sets `NoHitSubject`(64) on the collisions of unbroken arm parts 1/2 for the whole belly
attack. A growing arm enemy has `NoHitSubject` until it is fully grown.

## 2. Frame and units

Source sky plane, enemy-layer local units: x right, z up the screen, y toward the camera (camera (0,400,0)
looking down, 20 deg vertical FOV). The boss root's `transform.localPosition` is what the code moves.
Turret angles are `laser_body.localRotation = Euler(0, turretRY, 0)` inside the tilted model; turretRY 0 is
straight ahead (down the screen, the model has Euler y 180 after the entrance).

## 3. State machine (`_bos05state`, `_patternMode`)

`Ene_BosBase.LocalLateUpdate` (0x1DB9FF0) each frame: update player-side flags, `ProgressBossTimer(dt)`
(boss alive time and 10 s act steps once the timer is started), then `StateExec(dt)` (vslot 85).
`SetState(s)` = state s, mode 0.

`StateExec` (0x1D98EC0):
- EntryWait (0): inline entry (below), then `CheckNextState`.
- PT1Shot (1), PT4Laser (2), PT6Belly (3): first `if (_hpState > _lastHPState) { _lastHPState = _hpState;
  if (_hpState == 3 /*HalfHP*/) HalfInterruptEvent(); }`, then `CheckTimeEvent()`, then the pattern.
- GrowArm (4): pattern only (no HP / time check).
- Destruction (100): `PatternMoveDestruction`.

`CheckNextState` (0x1D95520): EntryWait -> PT1Shot; PT1Shot -> PT4Laser; PT4Laser -> GrowArm;
PT6Belly -> (`_isArmPurged` ? GrowArm : PT1Shot); GrowArm -> PT1Shot; Destruction stays; other -> EntryWait.
Normal loop: **PT1Shot -> PT4Laser -> GrowArm -> PT1Shot ...**

`CheckTimeEvent` (0x1D955C0): while `_attackPhase == First`, if bossAliveTime >= 90 s or
`_currentActStep >= Passed90` -> `HalfInterruptEvent()`.

HP state: `_hpState` = first i with hpRate > {.9,.75,.51,.4,.3,.2,.1,0}[i] (Ene_BosBase.UpdateHPState
0x1DBAD20); 3 = HalfHP (hpRate <= 0.51). The interrupt fires only when the recorded state jumps exactly to 3.

`HalfInterruptEvent` (0x1D95990) - phase change:
1. `SkyExplosionEffect(ExplosionCodeLarge = pf_eff_explposion03, GetSmallBombPosition(), EnemySkyLayer, no SE)`.
2. If state != PT6Belly: `mover._laserCancelFlag = true` (interrupt request; cancels the laser [I]), stop the
   tentacle SE channel `_armSEId`.
3. `_legHitPoint40 = _legHitPoint60 = 0`; `BreakAllLegs()` (every leg with visible upper renderer: hide upper
   and lower; for all 6 legs `SkyExplosionEffect(Middle = pf_eff_explposion02, leg._muzzle.position)`).
4. Parts 3 and 4 if not broken: `BreakParts(isGround=false, withEffect=false, withSound=true)`.
5. `_attackPhase = Second` (switches every template to the `...2` set).
It can run again later (time event first, HP event later): the effects repeat, phase stays Second.

Interrupt consumption: PT1Shot (after its per-frame move/aim) and PT4Laser (at entry of every frame) check
`mover._laserCancelFlag` -> `SetState(PT6Belly)`. GrowArm does not check; the next PT1Shot does.

### EntryWait (inline in StateExec; same code as PatternEntry 0x1D96490)
| mode | action |
|---|---|
| 0 | localTime = 0 -> 1 |
| 1 | localTime += dt; at >= 2.5 s: clear OffCollision, set OffLockon|NoDamaged -> 2 |
| 2 | wait `mover._isFinishDelay` (entrance route/animation done [I]); then `_centerPosition = localPosition`, clear OffLockon|NoDamaged, `ResetBossTimer(true)` (alive time 0, act step 0, timer running), `CheckNextState` -> PT1Shot |
Entrance motion = Animator `anm_bs05` state `anc_bs05_start` on `pf_bs05` (5 s, 60 fps): local position
(0,-210,220) t0 -> (0,-120,10) 2.33 -> (0,50,-5) 4.0 -> (0,0,0) 5.0; Euler (45,180,0) -> (20,180,0) 1.67 ->
(-15,180,0) 2.33 -> (10,180,0) 4.0 -> (0,180,0) 5.0 (tangents in `TXE_GraphicData/Boss/Bs05/Animation/anc_bs05_start.anim`).
The root sits at the EnemyData position (0,0,37). GetStart (0x1D95910): PlayQue 74 `bg5_boss_app_01`;
`_armSEId = Play(183 bg5_boss_tentacle_01)` (kept until HalfInterrupt / ToDestroid).

### PT1Shot (PatternMove1 0x1D965F0)
Every frame first: `MoveAround(dt, x:on, z:on)`; `TurretLookAt(dt, EaseOut, toFront:false)`; if laserCancel -> PT6Belly.
| mode | action |
|---|---|
| 0 | `SetLoopCount(3)` = random **1..3** loops -> 10 |
| 10 | turret volley: `BulletFireByMuzzlePack(table[phase][Eyes], "turret")` (`bos05eyes1/2`); localTime = 0 -> 11 |
| 11 | wait **1.5 s** -> 20 |
| 20 | `BreakLegFire()`; if any leg fired: localTime = 0 -> 21 (wait **0.5 s** -> 30) else -> 30 the same frame |
| 30 | `_fireCount++`; front shot `BulletFireAsync(table[phase][(~fireCount)&1], muzzle_body20)` (A on odd, B on even count); localTime = 0 -> 31 |
| 31 | wait **1.5 s**; `ConsumeAttackLoop(1)`; loops left -> 10, else `CheckNextState` (-> PT4Laser) |
Loop length 3.0 s (+0.5 s when a broken leg fires).

### PT4Laser (PatternMove4 0x1D96A20; mode table at 0x1D977F4)
Frame entry: if laserCancel -> PT6Belly (nothing else that frame). `isLeft` = `_isLeftMove`.
| mode | action |
|---|---|
| 0 | `SetLoopCount(1)` (= 1) -> 10 |
| 10 | `_isLeftMove = !_isLeftMove` (first PT4 goes left); `_isLaserMove = true`; `_overridePosition = _startVector = localPosition`; `_targetVector = (isLeft ? -80 : +80, start.y, start.z)`; laserMoveRate = 0; localTime = 0 -> 11 (same frame) |
| 11 | `TurretToFront(dt*80)`; localTime += dt; `laserMoveRate = OutSine(clamp01(localTime/2.7))`; at >= 2.7 s: `_isLaserMove = false` -> 20 |
| 20 | turret target = isLeft ? -90 : +90, turretStartY = RY, move time 1.5 s, passed 0 (rotation runs in mode 22); `_laserWaitTime = 3 + Random.Range(0,3)`; `_armFireInterval = 0`; `_armCount = phase First ? 3 : 2`; `_isFired = false`; localTime = 0; turret volley `BulletFireByMuzzlePack(table[phase][Eyes], "turret")` -> 21 (same frame) |
| 21 | localTime += dt; `_callArmClips(dt)`; at >= laserWaitTime: PlayQue 79 `bg5_boss_cannon_01`, `BreakLegFire()` -> 22 |
| 22 | `TurretRotate(dt, EaseInOut)` (90 deg in 1.5 s); while turning: `_callArmClips`. Done: **laser** `BulletDirFireAsync(table[phase][Laser] = bos05laser01, mzt muzzle_turret_laser, dir turret_edge, callback)`; `_laserTime = bt.nIrradiation` (6.5 s); localTime = 0 -> 23 |
| 23 | localTime += dt, `_callArmClips`; at >= **1.0 s** (charge): turret start = target, target = isLeft ? +30 : -30, move time = (laserTime - 0) * 0.5 = **3.25 s** -> 24 |
| 24 | `TurretRotate(dt, EaseOutSine)`, `_callArmClips`; done: target back to isLeft ? -90 : +90, move time 3.25 s -> 25 |
| 25 | same rotation back; done: localTime = 0 -> 27 |
| 27 | localTime += dt; at >= **0.5 s**: PlayQue 79, `_isLaserMove = true`, localTime = 0 -> 28. (`_callArmClips` only if loopCount > 1: never) |
| 28 | if `_isLaserMove`: localTime += dt, `laserMoveRate = 1 - InOutCubic(clamp01(localTime/1.5))`, at >= 1.5 s `_isLaserMove = false`. `atFront = TurretToFront(dt*80)`; once: front shot (`_fireCount++`, A/B as PT1, muzzle_body20), `_isFired = true`. When atFront and !_isLaserMove: `ConsumeAttackLoop(1)` -> 0 -> `CheckNextState` (-> GrowArm) |
Tail every frame (all modes): `_startVector = localPosition`; `v = Lerp(_startVector, _targetVector, laserMoveRate)`;
`_overridePosition.x = v.x`; `_overridePositionRate = laserMoveRate`;
`r = MoveAround(dt, x: laserMoveRate < 1, z: on)`; `_overridePosition.z = r.z`; if laserMoveRate == 1:
`_floatTimerX = isLeft ? 15 : 5` (so the sine float resumes from the side: x = center -/+ 60).
Laser callback (`<>c__DisplayClass123_0.<_callLaser>g___generateCallback|0` 0x1D9F830): on the
`EnemyLaserCollision`: `SetSoundId(80 bg5_boss_charge_01, isLeftSide ? 81 bg5_boss_beam_01 : 82 bg5_boss_beam_02)`,
`SetCancelDissolveTime(0.2)`; `isLeftSide = turretTargetY > 0` (= !isLeft). Laser sweep: isLeft: turret -90 -> +30
-> -90; right: +90 -> -30 -> +90. PT4 total about 16.7-19.7 s.

### PT6Belly (PatternMove6 0x1D97840) - the phase-change attack
Every frame: `MoveAround(dt, on, on)`; `TurretToFront(dt*80)`.
| mode | action |
|---|---|
| 0 | localTime = 0; `SetLoopCount(1)`; arm parts 1, 2 not broken -> `SetAttribute(NoHitSubject)`; PlayQue 75 `bg5_boss_turning_01`; `mover._laserCancelFlag = false` -> 10 (same frame) |
| 10 | localTime += dt; root `localRotation = Euler(75 * InOutCubic(clamp01(lt/1.5)), 0, 0)`; at >= 1.5 s: localTime = 0 -> 20 |
| 20 | if !laserCancel and state != 100: belly shot `BulletFireAsync(table[phase][Berry], muzzle_body21)` (`bos05berry1/2`); localTime = 0 -> 21 |
| 21 | localTime += dt; at >= **3 s**: `IsAttackLoop()` (pre-decrement, count 1 -> false) -> localTime = 0, PlayQue 75 -> 30 |
| 30 | localTime += dt; `localRotation = Euler(75 * (1 - InOutQuad(clamp01(lt/1.5))), 0, 0)`; at >= 1.5 s: clear NoHitSubject on unbroken arm parts, `CheckNextState` |

### GrowArm (PatternMoveGrowArm 0x1D98450) - body arms regrow
Every frame `MoveAround(dt, on, on)`.
| mode | action |
|---|---|
| 0 | for Arm40: if `_arm40DestroyCount < 10`: `GetParts(1).RepairParts(true)`, `_Arm40.localPosition = (60,0,0)`, `_isArmPurged = true`; same for Arm60 with (-60,0,0); localTime = 0 -> 10 |
| 10 | localTime += dt; at >= 0.5 s and purged: PlayQue 78 `bg5_boss_parts_return_01`, `_isArmPurged = false`. `TurretLookAt(dt, EaseInOut, false)`. t = clamp01(lt/1.2): `_Arm40.localPosition = Lerp((60,0,0), 0, OutQuart(t))`, `_Arm60.localPosition = Lerp((-60,0,0), 0, OutQuart(t))`; `_Arm40Scale`/`_Arm60Scale` localScale = Lerp(0.4, 1, InOutQuad(t)); at lt >= 1.2: `CheckNextState` (-> PT1Shot) |
(Arm nodes are always animated, even for a side with 10 destroyed arms that is not repaired.)

### Destruction (ToDestroid 0x1D991B0 -> PatternMoveDestruction 0x1D97E60)
`ToDestroid` (called by the damage system at body HP 0): trophy mode -> `SetTrophy(4)`; stop `_armSEId`;
`StopBossTimer()` (disable all parts, boss-destroy DI points, SetBossTime, PlayQue 177 `boss_defeat01_01`);
`mover.DeleteRouteToken()`, `ReleaseToken()` (cancels pending async fires); `SetState(Destruction)`.
| mode | action |
|---|---|
| 0 | start = target = localPosition, target.y -= 150; startAngle = localRotation, targetAngle = Euler(20,45,0); 4 x `SkyExplosionEffect(Middle, GetSmallBombPosition(), no SE)`; `AddShake(0.5,1,2)`; `SetSmallBombSecond(0.2)`; `SetDirectionTime(5.5)`; localTime = 3.5 -> 10 |
| 10 | pos = Lerp(start, target, EaseIn(directionRate)); rot = Lerp(startAngle, targetAngle, directionRate); localTime -= dt; at <= 0: `AddShake(0.5,1,5)`, `_callDeadEffect()` (vslot 69: camera shake (1,3,1), vibration, `PawnEnemy._callDeadEffect` = dead explosion `pf_eff_explposion_boss` +20 up, SE 41), localTime = 2 -> 11. Small bombs: `IsCallSmallBomb(dt)` -> `SkyExplosionEffect(Small = pf_eff_explposion01, GetSmallBombPosition(), SE 40 exp_st3_boss_a01)` + `AddShake(0.5,1,5)` |
| 11 | same movement and small bombs (no shake); localTime -= dt; at <= 0 -> 30 |
| 30 | PlayQue 42 `exp_st3_boss_c03`; `Ene_BosBase.ToDestroid()` (boss dead flag, vibration, PawnEnemy removal) |
Small bomb timer (`IsCallSmallBomb` 0x1DB9E90): current -= dt; when <= 0: current = base + U[0,1)*0.1, base *= 0.9,
returns true (first bomb on the first mode-10 frame). `GetSmallBombPosition` (0x1D957B0) = Lerp(
`_muzzles[Range(0,3)]`.position, `_BreakableLegs[Range(0,5)]._muzzle`.position, U[0,1)) (Range is inclusive).
Time-out (180 s, act step TimeOver): `TimeupAction` is the empty base [?: handled outside the boss].

## 4. Movement

`MoveAround(dt, x, z)` (0x1D96160), used in every attack state:
```
_floatSpeed = min(1, _floatSpeed + dt); s = _floatSpeed * dt        // 1 s ramp, never reset after ReStart
p = localPosition
if x: _floatTimerX = fmod(_floatTimerX + s, 20); p.x = _centerPosition.x + 60 * sin(2pi * _floatTimerX / 20)
if z: _floatTimerZ = fmod(_floatTimerZ + s, 5);  p.z = _centerPosition.z + 8 * sin(2pi * _floatTimerZ / 5)
r = clamp01(_overridePositionRate)
localPosition = p + (_overridePosition - p) * r
_overridePositionRate = max(0, _overridePositionRate - dt / 3)
return p
```
`_centerPosition` = root localPosition when the entrance ends (EnemyData (0,0,37) [I]). y is never changed by it.
PT4 side move: x target +/-80 (see tail above). PT6: root rotates about X up to 75 deg and back.
Destruction: sink 150 along -y (away from camera) in 5.5 s EaseIn while turning to Euler(20,45,0).

Turret (`laser_body`, `_turretRY`):
- `TurretRotate(dt, ease)` (0x1D99470): if moveWait > 0: passed += dt; e = Easing(clamp01(passed/moveWait));
  RY = start + (target-start)*e; e >= 1 -> moveWait = 0. Returns "was moving". Sets `Euler(0,RY,0)`.
- `TurretLookAt(dt, ease, toFront)` (0x1D992A0): when TurretRotate is idle, retarget: target =
  toFront ? 0 : `GetPlaneEuler((bossSky.x - player.x, 0, bossSky.z - player.z)).y` (yaw of LookRotation,
  wrapped to [-180,180)); start = RY; passed = 0; moveWait = |target - RY| * 0.025 (40 deg/s average).
  Boss sky position = `GetSkyRootPosition(transform.position)`, player = `GetPlayerSkyPosition(0)`.
- `TurretToFront(step)` (0x1D99590): move RY toward 0 by step (80 deg/s * dt), clears moveWait; true at 0.
Easing01 types used: 2 EaseOut 1-(1-t)^2, 3 EaseInOut (quadratic), 6 EaseOutSine.

## 5. Attacks

Template table `_bulletTemplateTable[phase][AttackId]` (Initialize 0x1D95BD0, unique names in
`btemplates`; Ene_BosBase.InitializeToPlay loads them and calls `ChangeSE(BulletKind.B004, 106)` on each):

| AttackId | First (phase 1) | Second (after HalfInterrupt) | muzzle | call |
|---|---|---|---|---|
| FrontA | `Boss05/bos05front1A` (enemybullet001, type 2, arc 360, 9 rapid, rot +20/shot, 0.12 s, isTarget) | `bos05front2A` (14 rapid, +15, 0.10 s) | `muzzle_body20` | BulletFireAsync(selfDir false, offset 0) |
| FrontB | `bos05front1B` (9 rapid, rot -20) | `bos05front2B` (14 rapid, rot -15) | `muzzle_body20` | same |
| Berry | `bos05berry1` (enemybullet002, type 8, arc 360, 24 rapid, rot +15/shot, 0.10 s, isTarget) | `bos05berry2` (rot -15) | `muzzle_body21` | BulletFireAsync |
| Eyes | `bos05eyes1` (enemybullet005, type 3, arc 45, 3 rapid 0.6 s, isTarget + isRapidTarget, waySwitch 4) | `bos05eyes2` (type 5, arc 90, 5 rapid 0.35 s, waySwitch 6) | pack `turret` (4 turret muzzles) | BulletFireByMuzzlePack |
| Legs | `bos05legs1` (enemybullet006, type 1, arc 20, selfDir, 4 rapid 0.2 s) | `bos05legs2` (8 rapid 0.1 s) | each broken leg's muzzle | BulletFireAsync(offset `_LegAngle[leg]`) |
| Laser | `bos05laser01` (`enemylaser003`, selfDir, nIrradiation 6.5 s) | same | `muzzle_turret_laser` toward `turret_edge` | BulletDirFireAsync + callback |
(Template details: `enemy-attacks.json` patterns.)

`BreakLegFire()` (0x1D94C60): for each of the 6 legs whose `_upper` renderer is disabled (broken), fire
Legs from its muzzle with offset angle `_LegAngle[i]`; returns true if any fired. Called in PT1 mode 20 and when
the PT4 laser starts. Before the phase change only shot-off legs fire; after it all 6 do.

Arms (`_callArmClips(dt)` 0x1D99690, PT4 modes 21-25): if `_armCount > 0`: `_armFireInterval -= dt`; at <= 0:
interval = **2.5 s**, then for Arm40 then Arm60, if `destroyCount < 10 || !part.isPartsBroken`:
`GetParts(n).BreakParts(false,false,false)` (hide the body arm), `CallEnemyClip(0)` (spawn `bos05_arm`), and per
spawned `Ene_Bos05_Arm`:
`Setup(parent=this, root=this.transform, born, launch, rot=ArmMesh.rotation, scale=ArmMesh.lossyScale,
turnInner, leftArm)` with launch = `_inGameEnemyRoot.InverseTransformPoint(ArmMesh.position)`; born = launch
when the part was intact and `_isArmPurged` false, otherwise `InverseTransformPoint(ArmMesh.TransformPoint(0,0,-60))`;
Arm40: turnInner = (boss localPosition.x < 0), leftArm = true; Arm60: turnInner = !(x < 0), leftArm = false.
If either side launched: `_isArmPurged = true`, `_armCount--`. Counts per PT4: 3 launches (phase 1) or 2 (phase 2),
the first at mode-21 entry; each launch is up to 2 arms.

### Ene_Bos05_Arm (LocalLateUpdate 0x1D92FF0)
Setup (0x1D93920): `_targetSpeed` = mover current speed (ReStart 0x1D938C0; EnemyData moveSpeed 35),
`_speed = 0`, `_direction` = normalize((rot*forward) with y = 0), `_baseRotation = Inverse(LookRotation(dir,up))*rot`,
`_turnClockwise = dir.x > 0`, `_parentOffset = root.localPosition`, mode = born==launch ? Fire : Grow;
localPosition = born, scales 1; Grow -> collision `NoHitSubject`; `_upTimer = 50`.
Each frame: if parent is null or `!parent.IsAlive()` (vslot 8) -> `ToDestroid()`.
| mode | action |
|---|---|
| Grow 0 | timer += dt; t = clamp01(timer/1.2); localPosition = launch + (born-launch)*clamp01((1-t)^4) + (root.localPosition - _parentOffset); `scaleNode.localScale = Lerp(0.4, 1, InOutQuad(t))`; at timer >= 0.6 s: SE 78 once; at timer >= 1.2: clear NoHitSubject, speed 0, timer 0 -> Fire |
| Fire 1 | SE 77 `bg5_boss_parts_firing_01` once; speed += targetSpeed * dt / 1 (1 s to full); at full: turnInner ? (timer += dt, after 1 s -> Turn) : -> Turn; `_UpdateTransform` |
| Turn 2 | turnAngle += (targetSpeed/50) * (turnInner ? 120 : 72) * (turnClockwise ? 1 : -1) * dt; clamp at +/-180 -> Move; `_UpdateTransform`; while `_upTimer > 0`: localPosition.y += dt*16.667, upTimer -= same (rises 50 toward the camera over 3 s) |
| Move 3 | `_UpdateTransform`; heading = AngleAxis(turnAngle, up) * direction; despawn (vslot 29, no kill) when heading.x > 0 and position.x > 200, or heading.x < 0 and position.x < -200 (world position) |
`_UpdateTransform(dt)` (0x1D94180): heading as above; twist = fmod(twist + 360*dt, 360);
localPosition += heading * speed * dt; localRotation = LookRotation(heading, up) * _baseRotation * AngleAxis(twist, forward) [I order of the last product].
Arm death (`Ene_Bos05_Arm.ToDestroid` 0x1D94090): if parent alive: leftArm ? `_arm40DestroyCount++` : `_arm60DestroyCount++`.

## 6. Parts and consequences

| event | consequence |
|---|---|
| any damage to a part (`AddDamageParts` 0x1D92FA0) and `OnPartsBreak` (0x1D96440) | `BreakParts(partNo)` (0x1D95070): Leg40 (3): HpRate <= 2/3 -> BreakLeg(leg10), <= 1/3 -> leg40, <= 0 -> leg70; Leg60 (4): leg30, leg60, leg90; each once (`_legHitPoint40/60` hold the last threshold) |
| `BreakLeg(id)` (0x1D94E80) | hide `_upper`/`_lower` renderers (if visible); `SkyExplosionEffect(Middle, leg muzzle)` (always); the leg then fires Legs shots |
| Arm part 1 / 2 destroyed (`OnPartsBreak`) | `_arm40DestroyCount++` / `_arm60DestroyCount++`; base break effect `pf_eff_explposion03` |
| launched arm destroyed | same counter on its side |
| destroy count reaches 10 on a side | that side no longer regrows in GrowArm and launches only while its body part is intact |
| HalfInterrupt (HP <= 51 %, or 90 s alive in phase 1) | all legs broken, leg parts broken (no effect), phase 2 templates, belly attack next |
| body damage object | `PartsList[0]._damageObject` = `RotX-65_Scal0.85/damage` (7 `pf_eff_damage01`) shown by the base parts logic [I: below 50 % like Bos03] |

## 7. Animator usage

- `pf_bs05` Animator `anm_bs05.controller`: states `Idle` (default, no motion) and `anc_bs05_start` (entrance,
  played by the EnemyData Animation event; returns to Idle). The code sets no triggers or parameters.
- Each `pf_bs05_legNN` has `anm_bs05_leg.controller` = `amc_bs05_leg01` (1 s loop: `leg_upper` Euler x 0 -> 30 -> 0;
  `leg_upper/leg_under` x 38.6 -> -17.5 -> 60.4 -> 38.6). Not driven by code.
- Code-driven transforms: root position/rotation, `laser_body` yaw, `arm40`/`arm60` local position,
  `arm40_scale`/`arm60_scale` scale.

## 8. Address table

| method | RVA | constants / notes |
|---|---|---|
| Ene_Bos05..cctor | 0x1D9A300 | all statics (JSON) |
| Ene_Bos05..ctor | 0x1D9AC60 | _armSEId -1, legHitPoint 1 |
| Initialize | 0x1D95BD0 | template table, muzzles by enum name, mover._isForceFire = true |
| GetStart | 0x1D95910 | OffCollision, SE 74, Play 183 |
| ReStart | 0x1D98A60 | resets state/phase/float/override/fireCount/legs/turret/destroy counts |
| StateExec | 0x1D98EC0 | dispatch, EntryWait inline (2.5 s) |
| PatternEntry | 0x1D96490 | duplicate of the inline entry (not called) |
| CheckNextState | 0x1D95520 | transitions |
| CheckHPEvent / CheckTimeEvent | 0x1D954F0 / 0x1D955C0 | ==3, 90 s / Passed90 |
| HalfInterruptEvent | 0x1D95990 | Large explosion, phase 2 |
| CancelLaser | 0x1D95460 | laserCancel + stop SE (not called directly) |
| SetState | 0x1D98E10 | |
| MoveAround / ResetMoveAround | 0x1D96160 / 0x1D98CE0 | 20 s/60, 5 s/8, recover 3 s |
| PatternMove1 | 0x1D965F0 | 1.5 / 0.5 / 1.5 s, loops 1-3 |
| PatternMove4 | 0x1D96A20 (switch 0x1D977F4) | 80, 2.7, 3+U(0,3), 1.5, 1.0, 6.5/2, 0.5, 1.5, 90/-30 |
| _callLaser | 0x1D9A140 | inlined into PatternMove4 mode 22; returns nIrradiation |
| laser callback | 0x1D9F830 | SE 80/81/82, dissolve 0.2 |
| _callArmClips | 0x1D99690 | 2.5 s, limit 10, inner (0,0,-60) |
| PatternMove6 | 0x1D97840 | 1.5 s, 75 deg, 3 s |
| PatternMoveGrowArm | 0x1D98450 | (+/-60,0,0), 1.2 s, 0.4->1, 0.5 s SE |
| PatternMoveDestruction | 0x1D97E60 | -150 y, Euler(20,45,0), 5.5 s, 3.5 + 2 s, bombs 0.2*0.9^n |
| ToDestroid | 0x1D991B0 | trophy 4, state 100 |
| TurretLookAt / TurretRotate / TurretToFront | 0x1D992A0 / 0x1D99470 / 0x1D99590 | 0.025 s/deg |
| BreakParts / BreakLeg / BreakAllLegs / BreakLegFire / ResetBreakLegs | 0x1D95070 / 0x1D94E80 / 0x1D94A30 / 0x1D94C60 / 0x1D98C40 | 2/3, 1/3, 0 |
| OnPartsBreak / AddDamageParts / BreakArm | 0x1D96440 / 0x1D92FA0 / 0x1D94C40 | destroy counts |
| SetPartAttribute / ShowArms | 0x1D98D60 / 0x1D98E30 | ShowArms not called |
| GetBulletTemplate / GetBossBT / GetBossCD / GetMuzzle / SubEnemys | 0x1D95730 / 0x1D95680 / 0x1D956E0 / 0x1D95780 / 0x1D99160 | |
| GetSmallBombPosition | 0x1D957B0 | muzzle x leg lerp |
| IsFireOK / IsPoseRecord | 0x1D96120 / 0x7AA370 | not called / false |
| Ene_Bos05_Arm..cctor / .ctor | 0x1D94770 / 0x1D948A0 | 1.2, 360, 1, 1, 50, 120, 72, 0.4 |
| Ene_Bos05_Arm.Setup | 0x1D93920 | |
| Ene_Bos05_Arm.LocalLateUpdate | 0x1D92FF0 | 0.6 s SE, (1-t)^4, +/-180, 200 |
| Ene_Bos05_Arm._UpdateTransform / _UpdateTurn / ToDestroid / ReStart | 0x1D94180 / 0x1D94640 / 0x1D94090 / 0x1D938C0 | |
| Ene_BosBase: LocalLateUpdate, ProgressBossTimer, UpdateHPState, .cctor | 0x1DB9FF0, 0x1DBA1D0, 0x1DBAD20, 0x1DBAFF0 | hpRateRanges |
| Ene_BosBase: SetLoopCount(int), IsAttackLoop, ConsumeAttackLoop | 0x1DBA500, 0x1DB9E60, 0x1DB93F0 | Make()%n+1; pre-decrement |
| Ene_BosBase: CurrentTargetVector/Angle, GetDirectionRate, SetDirectionTime | 0x1DB9630, 0x1DB95C0, 0x1DB9A20, 0x1DBA4D0 | |
| Ene_BosBase: IsCallSmallBomb, SetSmallBombSecond, StopBossTimer, ToDestroid, _callDeadEffect, ResetBossTimer, ReStart | 0x1DB9E90, 0x1DBA5A0, 0x1DBA790, 0x1DBAC60, 0x1DBAEB0, 0x1DBA430, 0x1DBA390 | |
| UIBossGauge..cctor | 0x1DD5170 | 180 s |
| ShortCutEffect..cctor | 0x1D40830 | explosion codes |
| EasingUtility.Easing01, RandomUtility.Range/Make/Make01, KernelUtility.GetPlaneEuler | 0x1DE8100, 0x1DF1780/0x1DF1830/0x1DF1350/0x1DF1220, 0x1DD70A0 | Range(int) inclusive |

## 9. Open questions

- [?] How `EnemyMover` sets `_isFinishDelay` from the EnemyData route events (Animation `anc_bs05_start`, TaskWait 16,
  FinishWait); assumed true when the 5 s entrance clip ends. The event `vectorValue` z = -250 is unexplained.
- [?] What exactly consumes `EnemyMover._laserCancelFlag` besides the boss (assumed: the live laser dissolves in
  0.2 s via `SetCancelDissolveTime`). Pending async fires are not cancelled by the flag.
- [?] `EnePartsGroup.BreakParts` / `RepairParts` internals (hiding, collisions, `_isPartsBroken`) and whether the base
  shows the body `damage` object below 50 % - taken from the Bos03 behaviour, not re-read.
- [?] `BulletFireAsync` / `BulletDirFireAsync` / `BulletFireByMuzzlePack` aiming internals (isTarget, rapid aim,
  `offsetAngle` sign convention relative to the muzzle) - shared bullet system, see enemy-attacks.json.
- [?] Order of the last quaternion product in `Ene_Bos05_Arm._UpdateTransform` (look * base * twist assumed).
- [?] Time-out at 180 s: Ene_Bos05 has no TimeupAction override (base is empty); the escape/ending is handled
  elsewhere.
- [?] Exact world placement of `_inGameEnemyRoot` (arms are placed in that root's local space); the 200-unit
  despawn test uses world `position.x`.
- Unused private code: `ShowArms`, `CancelLaser`, `ResetMoveAround`, `ResetBreakLegs`, `PatternEntry`, `IsFireOK`,
  `BreakArm`, `GetMuzzle`, `_callLaser` (inlined) have no direct callers in these classes.
