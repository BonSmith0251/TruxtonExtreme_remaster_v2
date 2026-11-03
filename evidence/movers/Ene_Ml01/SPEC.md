# Ene_Ml01 (Pf_Ene_Ml01) — the fish-eater ("ギョグ") that hunts the Sj01 school

Read-only study of `GameAssembly.dll`. Frame/units as `../../air-route-events/SPEC.md` §0 (sky plane x right, z up the screen, y toward the camera; yaw about +Y, 0 = +Z). `[I]` = inference, `[?]` = unknown.

- Disassembly: `dis/all_methods.txt` (all methods), `dis/moveState.txt` (full `_moveState`, 0x1DCB0B0–0x1DCC5BC; the metadata length 0x164 is wrong, the switch body runs to the jump table at 0x1DCC5BC), `dis/helpers.txt` (`_localForward`, `_rotateTowards`, `_calcAngleDiff`, `_checkPosition(Area)`), `dis/food1.txt` (`_setNearFood`, `_foodEatCheck`). Wrapper `pd.py` (= `../tools/pdis.py` without mover-field noise, plus jump-table decoding).
- Model: `ml01_sim.py`; outputs in `sims/`.

## 1. Class, fields, constants

`Ene_Ml01 : PawnEnemy` (not Rook/Knight: no child objects of its own). Its "children" (`_childList`) are **other enemies it eats**.

| Field | Off | Value | Source |
|---|---|---|---|
| `targetName` (static) | S+0 | `"Pf_Ene_Sj01"` | .cctor 0x1DCA650 |
| `_biteRange` | 0x1D4 | 20 | .ctor 0x1DCA830, prefab 20 |
| `_searchLimitX` / `_searchLimitY` (readonly) | 0x220/0x224 | 90 / 70 | .ctor |
| `_eatInterval` | 0x228 | 1.8 s | prefab (.ctor default 1.8) |
| `_getAway` | 0x22C | 10 s | prefab |
| `_turnSpeed` | 0x230 | 20 (deg/s per unit of `_turn`) | prefab |
| `_biteAttack` | 0x1D8 | AnimationCurve (0→1 at 0.1, 1 until 0.70, 0 at 1.0) | prefab — **never read** by the motion code |
| `_leftJaw` / `_rightJaw` | 0x1E0/0x1E8 | `mouth_L` / `mouth_R` | prefab |
| `_HitPoint` | | 100 | prefab |
| mover | | EnemyMover, `_lookAtType 0` | prefab |
| runtime | | `_state` 0x1B0, `_stateTime` 0x1B4, `_target` 0x1C0 (index in `_childList`), `_speed` 0x1C4, `_speedMax` 0x1C8, `_turn` 0x1CC, `_turnMax` 0x1D0, `_leftAngle`/`_rightAngle` 0x1F0/0x1FC (jaw local Euler), `_lastTarget` 0x208, `_jaw` 0x214 (0 Normal, 1 Open, 2 Close), `_eatEnd` 0x218, `_totalTime` 0x21C | |

Unnamed literals in `_moveState`: PreWait 0.1 s; Search accel +16/s to `_speedMax`, `_turn` +32/s to `_turnMax`; brake −100/s; slow-down radius 100; aim tolerance 2°; attack range 80; lunge 200 (100 near the edge); Attack/PlayerAttack brake −400/s after 0.1 s; PostWait 0.4 s; PlayerSearch `_turn` +10/s, speed floor 100 (+10/s); Release accel +100/s. Jaw: Open → ±15° at 360°/s, Close → ∓10° at 180°/s, Normal → 0 at 180°/s (y Euler of `mouth_L` / `mouth_R`). SE `0x94` on the bite.

## 2. What drives the transform

- `LocalLateUpdate` (0x1DCA380): `if dt > 0 { _moveState(dt); base.LocalLateUpdate(dt) }`. The pawn moves **before** the PawnEnemy area flag and the mover updaters run.
- The mover never moves it. The BG04 definition has `attribute 0` (no `EnemyAttribute.EventStack` = 16) and no routes:
  - `EnemyMover.CreateRouteData` (0x1D6C80F) sets `_isEventStackPlay = (attribute >> 4) & 1`. **With attribute 0 the event stack (`TaskWait 256`) is never executed** and air-SPEC end rule 2 does not apply.
  - `EnemyMover.Progress` (0x1D6CB50) then calls `SplineMover.Progress` → `_ProgressSpline` (0x1D44AE0): no spline, so no position change, but `_durationPassTime += dt` and `rate = pass / _durationTime`; at rate ≥ 1 with no next route → **EndRoute (vslot 0x278) at `duration` = 60 s** after the mover starts, unless `_isEndRouteKeep` [I: `_durationTime` = definition `duration`].
- All motion is `transform.localPosition += _localForward · _speed · dt` with `_localForward = localRotation · (0,0,1)` (0x1DCCA20), i.e. along the nose. Turning is `_rotateTowards` only.
- Start pose: placement + clip rotation → yaw 0 (nose **up the screen**, away from the player). Spawn (0, 0, 150).

## 3. Helpers

```
_rotateTowards(q, d, delta) (0x1DCC5E0):            // = Quaternion.RotateTowards(q, LookRotation(d, up), delta*_turnSpeed)
    look = LookRotation(d, Vector3.up); maxDeg = delta * _turnSpeed (20)
    ang = 2*acos(min(|dot(q, look)|, 1)) * 57.29578
    if |dot| > 0.999999 or ang == 0: return look
    return SlerpUnclamped(q, look, min(1, maxDeg / ang))
  -> turn rate (deg/s) = 20 * _turn.  d.y is non-zero only if altitudes differ (Search aims at y = 0).
_calcAngleDiff(yaw, d) / inline: |atan2(d.x, d.z)*57.29578 - wrap180(yaw)|   // NOT re-wrapped: fails near the ±180 seam [I]
_setNearFood(bool) (0x1DCC770): target = LAST index i with food[i] alive, |food.lp.x| < 90 and |food.lp.y| < 70; -1 if none.
    // It computes the distance but compares it with FLT_MAX and never updates the minimum: not the nearest, the last in list.
    // The limit tests use x and y (y is altitude here, ~0), so in practice only |x| < 90 matters [I: z was meant].
_checkPosition(t, r) (0x1DCA700): !( |t.lp.x + fwd.x*r| < 90 && |t.lp.y + fwd.y*r| < 70 )   // point r ahead is outside
_foodListup (0x1DCAE50): _childList = IGM._enemyManager._enemyLineups.Where(e => e.name == "Pf_Ene_Sj01").ToArray();
    each gets AddDieCallback(_foodDelete).   _foodDelete (0x1DCA8C0): its slot := null, DelDieCallback.
_foodEatCheck(r=_biteRange 20) (0x1DCAA20): every alive food with |food.lp - this.lp|^2 <= r^2 -> food.CommonEvent(0).
    Ene_Sj01.CommonEvent(0) (0x1D01430): causeOfDeath 0x6F (no player credit), AddDead -> the fish dies (eaten).
```

## 4. State machine (`_moveState`, 0x1DCB0B0; jump table 0x1DCC5BC)

Per frame, after the state body (tail 0x1DCC1CE): jaw update; `if _jaw == Open: _foodEatCheck(20)`; `if _totalTime >= _getAway(10) && !_eatEnd: _eatEnd = true; every alive food.CommonEvent(1)` (Sj01 state 1 = flee); then `_stateTime += dt; _totalTime += dt`. `ReStart` (0x1DCA3C0) zeroes `_state`, `_stateTime`, the jaw angles, `_eatEnd`, `_totalTime`.

```
0 Init:        _foodListup(); state = PreWait; speed = 50                                    (no move)
2 PreWait:     if stateTime >= 0.1: state = Find;  move                                      (stateTime counts from spawn)
1 Find:        jaw = Normal; if _setNearFood() != -1:
                   state = Search; speed = 20; speedMax = 50; lastTarget = food.lp; turn = 1; turnMax = 12; stateTime = 0
               else: state = PlayerSearch; speed = 50; stateTime = 0                         (no move)
3 Search:      speed = min(speedMax, speed + 16dt); turn = min(turnMax, turn + 32dt)
               if stateTime >= eatInterval - 0.2 (1.6):
                   if |lastTarget - lp| > 100: stateTime *= 0.5; END FRAME (no move)          // postpones the bite
                   speed = max(0, speed - 100dt); jaw = Open
               if stateTime >= eatInterval (1.8):
                   if food[target] dead: jaw = Normal; state = Find; END FRAME
                   state = Attack; stateTime = 0; speed = _checkPosition(this, 60) ? 100 : 200; END FRAME
               if target == -1 or food dead or food inside limits: if _setNearFood() == -1:
                   state = PlayerSearch; stateTime = 0; speed = 50; turn = 4; END FRAME
               tgt = food alive ? food.lp : lastTarget; lastTarget = tgt
               d = (tgt.x - lp.x, 0 - lp.y, tgt.z - lp.z)
               rot = _rotateTowards(rot, d, dt*turn); lp += fwd*speed*dt
               if |bearing(d) - wrap180(yaw)| < 2 and |d| < 80:
                   jaw = Open; state = Attack; stateTime = 0; speed = 200; turn = 4; if _checkPosition(this, 60): speed = 100
4 Attack:      lp += fwd*speed*dt; if stateTime >= 0.1: { if jaw != Close: SE 0x94; jaw = Close }; speed -= 400dt
               if speed <= 20: state = PostWait; stateTime = 0; speed = 20
5 PostWait:    lp += fwd*speed*dt; if stateTime >= 0.4: state = Find
6 PlayerSearch: if !IsGameWideArea(GameRootPos): state = Release; jaw = Normal; END FRAME
               d = player0.gamePos - lp; turn += 10dt; rot = _rotateTowards(rot, d, dt*turn)
               speed = max(100, speed + 10dt)
               if |bearing(d) - wrap180(yaw)| < 2 and |d| < 80: state = PlayerAttack; stateTime = 0; speed = 200; jaw = Open
               lp += fwd*speed*dt
7 PlayerAttack: lp += fwd*speed*dt; if stateTime >= 0.1: { SE+Close once }; speed -= 400dt
               if speed <= 0: state = Release; speed = 50; jaw = Normal
8 Release:     if !IsGameWideArea(GameRootPos): state = 9;  lp += fwd*speed*dt; speed += 100dt   (straight, no turning)
>8 (default):  CallDisabled (vslot 0x308)  -> removed (not a kill)
```

- The player target is always player index 0 (`GetPlayerPosition(0)`).
- `IsGameWideArea` = viewport ±0.5 (x ∈ [−0.5, 1.5), z likewise).
- Turn rate: in Search 20·turn = 20 → 240°/s, reaching the cap after 0.34 s. In PlayerSearch it starts at 80°/s (turn 4, or whatever was left) and grows by +200°/s each second, without limit.
- Eating needs `jaw == Open`. That is set in Search when within 100 of the target after 1.6 s, or at the aimed lunge. It stays Open only through the first 0.1 s of Attack. A fish dies when it is within 20 of the **Ml01 centre**, not of the mouth.
- Food is only the Sj01 enemies that were in the line-up on the Ml01's first frame. Later Sj01 are never added.
- Ml01 death (`_callDeadEffect` 0x1DCA530): every alive food gets `CommonEvent(2)` (Sj01: `_timeLimit = 2`, `_parentDie`, so the fish leave within 2 s). Then the base dead effect runs.

## 5. Ends

1. Release → leaves the wide area → state 9 → `CallDisabled` the next frame.
2. Mover duration: EndRoute after 60 s (`duration`), see §2 [I].
3. Killed (HP 100).

There is no other area or lifetime rule (no stack). Note that PlayerSearch goes straight to Release when the fish is outside the wide area. So **an Ml01 that finds no food at spawn (z ≈ 155) is removed after about 0.13 s** (`sims/ml01_BG04_nofood.txt`).

## 6. BG04 spawn and simulated path

- Definition `ene_ml01`: spawn (0, 0, 150), yaw 0, `attribute 0`, `duration 60`, events `[TaskWait 256]` (inert, see §2). Clip t = 111 s (group ML01).
- The food: `ene_sj01_02`, 200 × Pf_Ene_Sj01 (repeat 199, delayStep 0.01 s from t = 109 s), spawned at (−50, 0, 100) + U[0,100) × U[0,60) and moving along `move_sj01_*` routes. They are the Ml01's `_childList`.

`sims/ml01_BG04_static5.txt` uses five **static** stand-in fish at (−40,40), (−20,50), (0,40), (20,50), (40,40), player at (0, −49), 60 fps. The real fish move, so this only illustrates the timing:

| t (s) | Event | Position (x, z), yaw |
|---|---|---|
| 0.000 | Init → PreWait | (0, 150), 0 |
| 0.100 | PreWait → Find (moved +5 up at 50 u/s) | (0, 154.2) |
| 0.117 | Find → Search, target = last in list (40, 40) | (0, 155) |
| 0.3 / 0.6 / 0.9 / 1.2 | U-turn while accelerating 20 → 50; turn 1 → 12 | (0.4, 158.6) 13° · (5.4, 163.7) 76° · (13.0, 160.1) 148° · (15.6, 150.0) 167.5° |
| 1.6 | Within 100 of the target: brake (−84/s net), jaw opens | ≈ (19, 134) |
| 1.933 | Bite timer 1.8 s → Attack at 200 | (22.0, 121.3) |
| 2.033 | Jaw closes (SE 0x94), brake −400/s | (26.3, 101.8) |
| 2.467 | Speed 20 → PostWait | (36.6, 55.2) |
| 2.867 | Find → Search (40, 40); aimed at once (7.6 away) → Attack; eats two fish | (38.4, 47.1) |
| 3.85 … 9.6 | Search / aimed Attack cycles, about 1.9 s each, eat the rest | |
| 10.0 | getAway: remaining fish told to flee | |
| 10.55 | No food → PlayerSearch: speed 100+, turn grows, hunts the player | (−90, 74.1) |

## 7. For the port (Round1EventStack per-model hook)

- Replace the whole mover for this model:
  - no stack step (attribute 0);
  - run `_moveState` first each LateUpdate, then the in-area flag;
  - the 60 s duration EndRoute from `_ProgressSpline` [I].
- It needs the live Sj01 list (spawned before it, name `Pf_Ene_Sj01`), their positions, and a kill hook. Sj01 has `CommonEvent(0)` eaten, `(1)` flee, `(2)` parent dead → 2 s.
- The target pick is "last alive in-limit Sj01 in spawn order", re-evaluated every Search frame while the current one is inside |x| < 90.

## 8. Open questions

- `[?]` Order of `_enemyLineups` (the spawn order is assumed). It decides which fish is chased first.
- `[?]` What `SplineMover` vslot 0x348 does each frame in `_ProgressSpline` without a spline, and whether `_durationTime` is the definition's 60 s for this pooled pawn.
- `[I]` The `|y| < 70` tests were probably meant for z. Natively they always pass (y ≈ 0), so the hunt area is |x| < 90 only, any z.
- `[?]` Whether Sj01 fleeing (CommonEvent 1) or leaving the screen triggers the die callback that nulls the slot. If it does not, Ml01 keeps chasing the fish's last position (`lastTarget`).
