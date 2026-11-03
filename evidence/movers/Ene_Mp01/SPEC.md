# Ene_Mp01 — stack-moved drifter with a turret laser (Pf_Ene_Mp01)

Read-only study of `GameAssembly.dll`. `[I]` = inference, `[?]` = unknown. Frame/units: `../../air-route-events/SPEC.md`.
Disassembly `dis/all_methods.txt`, `dis/EnemyTurret.txt`; model `../Ene_St01/tools/movers_sim.py mp01` (stack via
`air_sim.Mover`).

## 0. Where it is used

BG01 `ene_mp01l` (12 spawns) / `ene_mp01r` (7), first pair at 145 s with clip offsets (∓90, 0, 95), then (∓60,0,95),
(∓30,0,95)… up to 165 s; from 170 s single side entries (see §5); indexValue 0. Attribute 16 (stack), speed 15, rotate y 180, lookAt 0. Program:

| # | Event | Effect (air spec) |
|---|---|---|
| 0 | 12 ForwardMove dotime 60 | 15 u/s along yaw 180 (down), snapshot at start; area-exit rule 1 applies |
| 1 | 2 Rotate y −7200 (l) / +7200 (r), dotime 60, intValue1 256 | local yaw spin, relative, **InOutSine** over 60 s (≈5° at 1 s, 123° at 5 s, peak 188°/s at 30 s) |
| 2 | 1 Delay 1.0 | stack waits 1 s |
| 3 | 8 Bullet `mp01_fire2`, value1 2, repeatDelay 10, nameValue `pf_ene_mp01/muzzle02b` | one shot (first wait 2 s) |
| 4 | 1001 FinishWait | stack stops; rule 2 off |

## 1. Fields

Statics (`.cctor` 0x1CFD790): `gameScreenAreaMP01` Rect(−2.5, −1.5, 5, 3) (only used by `Mp01IsStayPlayArea`
0x1CFD4D0, which has **no callers**), `LaserFirstTime` 3.0, `LaserRapidTime` 0.5, `PreLaserTime` 0.5,
`AfterLaserTime` 1.0, `RollSpeedHi` 90, `RollSpeedLow` 30.
Instance: `laserSeq` 0x1B0 (NONE −1, START 0, AIM 1, FIRE 2, WAIT 3), `_item` 0x1B4, `_turret` 0x1B8, `_muzzle` 0x1C0,
`_muzzleTop` 0x1C8, `_bulletName` 0x1D0, `_bt` 0x1D8, `_isStartArea` 0x1E0, `_localTime` 0x1E4.
Prefab (`extraction/pristine-export/.../Reference/Enemy/Pf_Ene_Mp01.prefab`; not in OriginalRecovered): `_item` 2
(PowerUp, dropped by `_callDeadEffect` 0x1CFD680 via `ItemDrop`), `_turret` = EnemyTurret on `ene_mp01_battery`
(`_RollSpeed` 15, `_delayWait` 0, `_MinAngle/_MaxAngle` ±180, `_isRotY` 1, `_isParent` 0 → world rotation),
`_muzzle` = `ene_mp01_battery/muzzle01` (0, 2.12, 10.944), `_muzzleTop` = `muzzle01/mzzle01t` (0, 0, 1),
`_bulletName` **mp01_fire1**, `_HitPoint` 100, `_deadExplosion` pf_eff_explposion02.

## 2. Code

```
Init (0x1CFD340) [from ReStart 0x1CFD660 and InitializeToPlay 0x1CFD3F0, which also sets _bt = GetTemplate(_bulletName)]:
    _token = mover.CreateLinkedToken(); _isStartArea = false; _localTime = 3.0; laserSeq = START
LocalLateUpdate(dt) (0x1CFD4B0): PawnEnemy.LocalLateUpdate(dt); ActionMove()       // class AFTER the stack
ActionMove() (0x1CFCEF0):
    if InGameManager null or IsGameStop: return
    dt = InGameManager.DeltaTime; inArea = mover._isInGamePlayArea              // set this frame, pre-hook
    if inArea: _localTime -= dt
    switch laserSeq:
    START: if inArea: _isStartArea = true; _turret.SetRollSpeed(90); laserSeq = AIM; return
    AIM:   if _localTime <= 0:
               if token alive: mover.BulletDirFireAsync(token, _bt, mzt=_muzzle, dirt=_muzzleTop, 0).Forget()
                               _localTime = 0.5; laserSeq = FIRE
               else laserSeq = NONE
    FIRE:  if _localTime <= 0: _turret.SetRollSpeed(30); _localTime = 1.0; laserSeq = WAIT
    WAIT:  if _localTime <= 0: _localTime = 0.5; laserSeq = START
    if !inArea and _isStartArea: _token.Cancel(); _isStartArea = false; laserSeq = NONE   // no lasers after leaving
```

EnemyTurret (IEnemyUpdater, `Progress` 0x1D6E870, `_updateTarget` 0x1D6EBB0, `SetRollSpeed` 0x1D6E9A0): aims the
battery (yaw only) at the nearest player's sky position; each retarget sets `_targetSec = |angle| / _RollSpeed` and
lerps `_startQuaternion → _targetQuaternion` over `_targetSec`, retargeting when `_localSec ≥ _targetSec + _delayWait`.
`SetRollSpeed(v)` (if changed) restarts from the current rotation and retargets at once. So the turret tracks at
90°/s from START to the shot + 0.5 s, then at 30°/s while the laser plays [I: laser follows the barrel].

## 3. Interaction with the stack (for `Round1EventStack.cs`)

- **No motion code.** Position = stack ForwardMove (15 u/s down for up to 60 s), body yaw = the stack Rotate spin.
  The turret (world-space) is independent of the body spin.
- The class runs **after** the stack (`PostStack`) and only drives the laser and the turret roll speed.
- End: stack area-exit rule 1 (ForwardMove running, entered, pre-step position outside gameScreenArea) — at
  ≈ 12.45 s for z = 95 → −92 if Mp01 is Small/Medium [?: `_sizeType`]. Laser token cancelled when it leaves.
- Laser timeline: first shot 3.0 s **of in-area time** after entering, then every ≈ 2.0 s
  (AIM 0.5 + FIRE 0.5 + WAIT 1.0, ±1 frame for the START frame), until it leaves.

## 4. Simulated run — BG01 `ene_mp01l`, t = 145 s, clip (−90, 0, 95), player (0,−49)

`sims/mp01l_BG01_t145_clip-90_95.txt`:

| t | pos (x, z) | body yaw | event |
|---|---|---|---|
| 0.000 | (−90, 95) | 180 | FM 60 s + Rotate −7200/60 s InOutSine + Delay 1 |
| 0.217 | (−90, 91.5) | 179.8 | enters gameScreenArea → laser START, turret 90°/s |
| 1.017 | (−90, 79.5) | 174.9 | Bullet event, FinishWait |
| 3.167 | (−90, 47.3) | 130.6 | stack shot `mp01_fire2` (muzzle02b) |
| 3.217 | (−90, 46.5) | 129.1 | **laser 1** `mp01_fire1` (muzzle01 → mzzle01t) |
| 3.717 | (−90, 39.0) | 112.1 | turret 30°/s |
| 4.750 | (−90, 23.5) | 69.2 | START (turret 90°/s) |
| 5.233 / 7.250 / 9.267 / 11.283 | (−90, 16.3 / −14.0 / −44.3 / −74.5) | | lasers 2–5 |
| 12.433 | (−90, −91.75) | 163.7 | left play area: token cancelled |
| 12.450 | (−90, −92.0) | | EndRoute (area exit) |

## 5. Open points

- [?] `_sizeType` of Mp01 (Small/Medium → ±0.15 area; Large+ → ±0.5) changes the laser start, the exit and the
  last laser.
- [?] `mp01_fire1` laser duration/shape (BulletDirFireAsync + template) — see the shot-effects work.
- The stack bullet uses node `muzzle02b` (present in the prefab), the class laser `muzzle01`/`mzzle01t`.
- Later BG01 spawns enter from the sides: clip (200, 0, 60…−40) with clip yaw +90 (`ene_mp01l`) or (−200, 0, 50/−40)
  with clip yaw −90 (`ene_mp01r`); heading = 180 + clip yaw (air spec §2) → they drift inward horizontally at 15 u/s.
