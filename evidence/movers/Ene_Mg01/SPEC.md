# Ene_Mg01 — native movement (CustomMove fire cycle on top of the stack spline)

Read-only study of `GameAssembly.dll`. Builds on `../../air-route-events/SPEC.md` (stack, SplineMove, frame order, end rules).
Disassembly: `dis/all_methods.txt` (every Ene_Mg01 method, annotated by `../tools/pdis.py`), `dis/EasingUtility_EaseIn_Out_InOut.txt`.
Model: `mg01_sim.py` → `sims/mg01_1a_BG04.txt`. `[I]` = inference, `[?]` = unknown.

## 1. Class, fields, constants

`Ene_Mg01 : RookEnemy : PawnEnemyDD : PawnEnemy`. Pawn and EnemyMover sit on the same root GameObject (`Pf_Ene_Mg01`), so the transform the pawn turns is the mover root.

| Field (offset) | Prefab / init | Use |
|---|---|---|
| `_Muzzle` 0x1F8 | `muzzle01`, local (0, 0, 14.5) under the model (nose, +Z) | bullet origin |
| `_fireMode` 0x200 | 1 (Move) at ReStart if `_indexValue ≠ 0` | state |
| `_timer` 0x204 | 0 (cleared by every 8-byte state write) | state clock |
| `_fireTimer` 0x208 | 0 (cleared on Homing→Shot) | shot repeat clock |
| `_baseSpeed` 0x20C | `mover._currentSpeed` at ReStart = placement speed (50 in BG04) | speed scale |
| `_targetPlayer` 0x210 | −1 (ctor, ReStart, Brake→Homing, Shot→Turn) | lazily chosen player |
| `_baseRotate` 0x214 / `_targetRotate` 0x224 | — | turn endpoints |
| `_bulletTemplates` 0x238 | `[GetTemplate("mg01sp1_1way")]` | fired in Shot |
| RookEnemy/PawnEnemy | `_HitPoint 20`, `_deadExplosion pf_eff_explposion02`, `_deadBullet mg01_fired`, `_overplayDeadSound 205`, `_children []`, `_isChildrenSolidarity 1` | |
| EnemyMover | `_lookAtType 0`, `_lookAtUpdateSec 0` (placement lookAt 1 overrides) | |

Statics (`.cctor` 0x1DC69B0): `_FireMoveTime 3.5`, `_FireBrakeTime 0.5`, `_FireHomingTime 0.5`, `_FireShotTime 0`, `_FireTurnTime 0.5`, `_FireReturnTime 0.5`, `_FireRapidTime 1.0`, `_BulletName "mg01sp1_1way"`.

Easing (KANAI `EasingUtility`, (a, b, t)): `EaseIn = a+(b−a)t²` (0x1DE8000); `EaseOut = a−(b−a)t(t−2)` (0x1DE80D0); `EaseInOut`: `t2=2t; t2<1 ? a+(b−a)/2·t2² : a−(b−a)/2·((t2−1)(t2−3)−1)` (0x1DE7FA0).

## 2. Hook point and stack interaction

```
Ene_Mg01.LocalLateUpdate(dt)  0x1DC6780
    PawnEnemy.LocalLateUpdate(dt)        // sets mover._isInGamePlayArea, runs the EnemyMover stack (LateUpdate)
    if _indexValue != 0: CustomMove()    // AFTER the stack step; nothing at all when the spawn index is 0
ReStart(withPlay) 0x1DC67B0: RookEnemy.ReStart; if _indexValue != 0 { _fireMode=Move; _timer=0; _baseSpeed=mover._currentSpeed;
                              _targetPlayer=-1; CreateToken(); _bulletTemplates=[mg01sp1_1way] }
```
- ReStart runs from `PawnEnemy.StartKickWithDelayTime` (vslot 0x198), after `_enemyEntry` → `UpdateObjectData`, so `_baseSpeed` is the placement speed (50).
- All BG04 spawns have `indexValue 1`, so CustomMove is active. With index 0 the enemy is a plain stack spline mover.
- The stack program (both definitions): `15 SplineMove move_mg01_1a|1b`, `80 TaskWait 256`. CustomMove does not touch the stack. It only writes:
  - `mover._currentSpeed` (Brake, Return). The SplineMove task (LastUpdate) reads it in the NEXT frame. At speed 0 the spline takes no step, so neither position nor the lookAt rotation changes.
  - `root.localRotation` (Homing, Shot, Turn). This is written after the spline task, so it wins for that frame. The spline is stopped in these states, so there is no conflict. In Move/Brake/Return the spline's lookAt 1 rotation (nose along the tangent) applies.
- dt = `InGameManager.get_DeltaTime()`.

## 3. State machine (CustomMove 0x1DC5D70, jump table 0x1DC667C)

Each frame: `_timer += dt` first. "→X" writes 8 bytes `{_fireMode=X, _timer=0}`.

| Mode | Per frame | Exit |
|---|---|---|
| 1 Move | nothing (spline at full speed) | `_timer ≥ 3.5` → 2 |
| 2 Brake | `speed = base · EaseOut(0,1, clamp01(1 − _timer/0.5)) = base·(1 − r²)`, r = clamp01(_timer/0.5) | `_timer ≥ 0.5` → 3, `_targetPlayer = −1` (speed is now exactly 0) |
| 3 Homing | `e = EaseInOut(0,1, clamp01(_timer/0.5))`. First frame (`_targetPlayer < 0`): `_targetPlayer = GetNearestPlayerIndex(GetScreenPosition(pos))`, `_baseRotate = localRotation`. Every frame: `d = GetPlayerSkyPosition(tp) − localPosition`, `_targetRotate = LookRotation(d, up)` (tracks the player live), `localRotation = Slerp(_baseRotate, _targetRotate, e)` | `_timer ≥ 0.5` → 4, `_timer = _fireTimer = 0` |
| 4 Shot | if `!IsCancelToken`: `localRotation = _targetRotate`; `_fireTimer −= dt`; if `_fireTimer ≤ 0`: `_fireTimer += 1.0`, and for each template `BulletFireAsync(token, bt, false, false, _Muzzle, …).Forget()` | `_timer ≥ 0` → 5 (always after 1 frame), `_targetPlayer = −1`. So exactly **one** `mg01sp1_1way` volley per cycle; `_FireRapidTime` never repeats it. |
| 5 Turn | `localRotation = Slerp(_targetRotate, _baseRotate, EaseInOut(0,1, clamp01(_timer/_FireHomingTime 0.5)))` | `_timer ≥ _FireTurnTime 0.5` → 6 (back on `_baseRotate` exactly) |
| 6 Return | `speed = base · EaseIn(0,1, clamp01(_timer/0.5)) = base·r²` | `_timer ≥ 0.5` → 1 (speed = base) |

- Cycle: 3.5 + 0.5 + 0.5 + 1 frame + 0.5 + 0.5 ≈ 5.517 s (331 frames with float32 timers).
- Distance per cycle ≈ base·(3.5 + 1/3 + 1/6) = 4·base = 200 units at 50.
- The stop is 1.0 s + 1 frame at speed 0. The nose swings to the player over 0.5 s (EaseInOut), fires, then swings back over 0.5 s to the pre-stop heading.
- Yaw-only reading: Slerp of two yaw quaternions = shortest-arc linear yaw blend.
  - `[I]` The player's sky position and the enemy have y = 0, so there is no pitch. LookRotation uses the full 3-D difference: a non-zero y difference would tilt the model `[?]`.
- The timer starts at spawn. It counts off-screen time, so the first stop is 3.5 s after spawn wherever that is on the route.

## 4. End

There is no pawn-side end. The stack ends the enemy:
- the SplineMove task ends exactly on the last knot;
- TaskWait 256 passes;
- events are exhausted, and the enemy is outside its play area → `EndRoute` (air spec §3 rule 2), in the same frame.

The routes end at spawn + (±452, 0), off screen, so the enemy is removed at the route end. A SplineMove never triggers the area-exit rule. A kill ends it earlier: `_deadBullet mg01_fired`.

## 5. Route placement (needed by the port)

`_splineRootPosition = localPosition − _splineStartPosition`, where `_splineStartPosition = spline[0]` (InGameEnemyMoveBase.SetSpline 0x1CDB5C0 → +0x110).
- `move_mg01_1a` starts at knot (−100, 0, 0), so the enemy starts **at its spawn point** and follows `spawn + route(u) − knot0`.
- **`air_sim.py` `spline()` uses `root = pos` without subtracting knot 0.** That is harmless for the Sb01ent routes (knot 0 = 0), but it would put Mg01 100 units left of its spawn: subtract knot 0 in the C# port.

Spawn:
- = definition position (∓226, 0, −15) + placement offset 0 + `U[0,1)·_offsetRange`;
- `_offsetRange` = (20, 0, −5) for 1a and (−20, 0, −5) for 1b (EnemyPlacementData.get_Offset 0x1D35760 → RandomUtility.Range(Vector3) 0x1DF14F0, which is per-axis U[0,1)·v).

Route length 544.68, easeType 0 (linear in distance), lookAt 1.

## 6. Simulated path — BG04 `ene_mg01_1a` (clip offset 0, random offset 0, speed 50, player (0, −49))

`sims/mg01_1a_BG04.txt`:

| t (s) | event | pos (x, z) | yaw | speed |
|---|---|---|---|---|
| 0 | spawn, Move | (−226, −15) | 96 | 50 |
| 1.25 | enters (x −163.7) | (−163.7, −20.2) | 91 | 50 |
| 2.0–2.5 | route loop | (−126.9, −15.6) → (−119.4, 7.2) | 53 → 5 | 50 |
| 3.50 | → Brake (dist 175.8) | (−90.8, 47.4) | 53 | 50 |
| 4.00 | → Homing, stopped (dist 192.9) | (−76.4, 56.6) | 62 | 0 |
| 4.50 | → Shot | | 144.1 (at player) | 0 |
| 4.517 | **FIRE mg01sp1_1way**, → Turn | | 144.1 | 0 |
| 5.017 | → Return | | 62.0 | 0 |
| 5.517 | → Move (dist 200.8) | (−69.4, 60.1) | 65.5 | 50 |
| 7.0 | top of the arc | (1.8, 75.0) | 91 | 50 |
| 9.033 | → Brake | (96.9, 42.4) | 131 | 50 |
| 9.533 | stopped | (108.9, 30.3) | 140 | 0 |
| 10.05 | **FIRE**, yaw 233.9 | | | |
| 11.05 | → Move | (113.6, 23.9) | 146 | 50 |
| 13.917 | route end (226, −15), outside → EndRoute | | 84 | 50 |

1b is the mirror image: x → −x, yaw → 360 − yaw.

## 7. Versus the reconstruction

Per air spec §6.2, a one-SplineMove program falls back to the generic route follower:
- constant 50 u/s, extended by the tangent after the end;
- no brakes, no 1-s stops, no turn toward the player.

Missing in the port:
- the speed law `base·(1−r²)` / `base·r²`;
- the yaw blend;
- the single shot at the end of Homing;
- the end at the route end;
- the knot-0 subtraction.

## 8. Open

- `[?]` `GetPlayerSkyPosition` (IGM `_playerSkyPosition[]` 0x160) vs `localPosition` frames: same in-game-root frame `[I]`. The y of the sky position is assumed 0.
- `[?]` BulletFireAsync's direction source (muzzle forward = nose `[I]`) and the `mg01sp1_1way` template contents (not traced; they do not gate motion).
- `[?]` LastUpdate vs LateUpdate ordering is from the air spec (±1 frame on the speed hand-off).
