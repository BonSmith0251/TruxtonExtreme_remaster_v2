# Ene_Mp02 — spline routes chosen by indexValue, played in ROUTE mode beside a firing-only stack (BG01, BG08)

Read-only study of `GameAssembly.dll`. Shared machinery is in `../../air-route-events/SPEC.md` and `../../ground-route-events/SPEC.md`. `[I]` = inference, `[?]` = unknown.
Tools: `../tools/m7_sim.py mp02a|mp02b` (route-mode model `RouteMover`), `../tools/lut_routes.py`, `../tools/prefab_mb.py`.

## 1. Identity

| Item | Value |
|---|---|
| Prefab | `Assets/OriginalRecovered/Samples/Prefabs/Reference/Enemy/Pf_Ene_Mp02.prefab`: `EnemyMover` (defaults), `Ene_Mp02`, 3× `EnemyCollisionModel` (3 parts), `PhysicsEnemy` (visual) |
| `Ene_Mp02` serialized | `_HitPoint 100`, lock-on, `_deadExplosion pf_eff_explposion02`, `_item 4`, **`_routeNames`** = [0] {common_D150, common_L300}, [1] {common_D150, common_R300}, [2] {common_R150, common_U200}, [3] {common_L150, common_U200} |
| Class | `Ene_Mp02 : PawnEnemy`. `CreateRouteData` 0x1CFD8C0, `GetRouteNames` 0x1CFDAD0, `_callDeadEffect` 0x1CFDBD0 (item drop, see `../../death-bullets/SPEC.md`). **No per-frame code.** |
| Definitions | `ene_mp02a` (BG01) and `ene_mp02b` (BG01, BG08). Both: attribute 16, routes [], duration 60, position (0,0,0), speed 30, rotate 0, **easeType 7**, lookAt 0. |
| Events `ene_mp02a` | Delay(dotime 3.5, value0 0) then 4× Bullet `mp01_fire3` (repeatCount 999, repeatDelay 1.5, rpidf) at battery muzzles, then FinishWait |
| Events `ene_mp02b` | the same without the Delay |
| Spawns | BG01: mp02a at 210/215/220/225 s, clip (−220,0,0), **index 2**; mp02b at 212.5/217.5/222.5/227.5 s, clip (40,0,150), **index 1**. BG08: mp02b at 395/400/405/410 s, clip (35,0,150), index 1; mp02b at 397.5/402.5/407.5/412.5 s, clip (−35,0,150), index 0. |

## 2. CreateRouteData 0x1CFD8C0

```
_enemyData (0x1B8) = sourceData.ShallowCopy()
src = _routeNames[_indexValue].arrays                      // bounds-checked: index must be 0..3
_enemyData.routeNames (0x28) = new string[src.Length];  copy element by element
_enemyData.Coordinate();  _mover->CreateRouteData(_enemyData, startPosition)    // vslot 0x288
```

- The events are untouched. attribute 16 stays, so the mover runs **stack mode with routes**.
- `EnemyMover.Progress` 0x1D6CB50 runs `_execStackEvent` and then, because `IsSplineRoute()` (`_routes.Length > 0`), **also `SplineMover.Progress`**. That is the route-mode mover below.
- In stack mode `EnemyMover.UpdateEvent` 0x1D6CDB0 returns at once, so the events are not fired by awakeRate. They stay with the stack.
- The stack only fires (Delay → 4 repeating Bullets → FinishWait, which freezes the stack). It never moves the enemy.

`GetRouteNames` 0x1CFDAD0 returns the route names for preloading.

## 3. Route mode (`SplineMover._ProgressSpline` 0x1D44AE0, `Progress` 0x1D43DF0, `updateRouteData` 0x1D452D0)

Mp02, Mx02 and X01 share this. It is not in the earlier specs, and `Round1EventStack` explicitly excludes it.

```
per LateUpdate (after the stack):
  _durationPassTime += dt
  if IsSplineMove() (moverState != 4 && splineLength > 0):  _currentRate += dt * _currentSpeed / splineLength
  else:                                                      _currentRate = duration > 0 ? pass/duration : 1
  if _currentRate >= 1: done; _currentRate = 1; offset = 1
  else:                 offset = Easing01(_currentRate, _easingType)          // 7 = InOutSine01 0x1DE86F0 (0.1 deg Cosf table)
  UpdateEvent(prevOffset, offset − prevOffset)           // vslot 0x348; route-mode events only (§ in ../Ene_Mx02/SPEC.md)
  _currentOffset = offset
  _splineCurrentPosition = LUT(offset) − LUT(0)          // EvalCachedPosition 0x1CD9880, RouteLUT piecewise-linear [I]
  rotation: every _lookAtUpdateSec (0): _splineRotate = _getRotate(spline, offset, ...)   // lookAt 0 -> identity [I]
  if done:
     if _routesIndex + 1 < _routesIndexMax:
        _easingType = _nextEasingType if != −1;  _routesIndex++
        _startPosition = transform.localPosition          // NOTE: still LAST frame's position
        updateRouteData(dt): SetSpline(next) -> _splineStartPosition = knot0, _splineCurrentPosition = 0,
                             _currentRate = dt*speed/len_next, _durationPassTime = dt, _currentOffset = 0
     else if !_isEndRouteKeep: EndRoute()   (vslot 0x278: removed, not a kill)
     else _moverState = 4
SplineMover.Progress then (unless taskFlag & 0x700 == 0x700):
  localPosition = _startPosition + _routeRotate.MultiplyVector(_splineCurrentPosition)   // _routeRotate identity [I]
  localRotation = _firstRotate * _splineRotate
```

What this means:
- Each route is played **separately**, with the eased **rate** (`speed·t / length`) per route. Mp02's easeType 7 makes it stop at every route junction: it eases into the junction and out again.
- At a junction the end point of the previous route is not reached. The position holds the previous frame's value for one frame, and the next route starts one step in, because `_currentRate = dt·v/len` is set and then advanced again the next frame. With easeType 7 the missed step is about 0 (ease-out).
- **Correction (2026-11-02):** `_ProgressSpline` zeroes its dt register on the done frame (0x1D44BF7) and calls `updateRouteData(0)` (0x1D44E22), so the next route starts at rate 0, not one step in (as `../Ene_Mc01/SPEC.md` §3 and `../Ene_Sf01/SPEC.md` §7 say). `../tools/m7_sim.py` and `Round1EventStack.RouteStep` now do this; the Mp02, X01 and Mx02 tracks were regenerated (Mp02 and X01 end one frame per junction later).
- There is **no area-exit rule** in route mode. The enemy is removed when the **last route ends**, wherever it is. `EnemyData.duration` is not used while `splineLength > 0`.
- `_currentSpeed` is the placement speed (30) unless a Speed event changes it.

## 4. Paths

| spawn | routes | motion |
|---|---|---|
| BG01 mp02a, (−220,0,0), i2 | R150, U200 | right 150 in 5.00 s (eased), stop at (−70,0); up 200 in 6.67 s; EndRoute at 11.667 s at (−70, 200) — leaves the top (z 91.7) at 8.17 s |
| BG01 mp02b, (40,0,150), i1 | D150, R300 | down from z 150 to 0 in 5.00 s; right 300 in 10 s; EndRoute at 15.0 s at (340, 0) — on screen from 2.15 s, leaves the right edge (x 163) at 9.43 s |
| BG08 mp02b, (35,0,150), i1 | D150, R300 | same, x 35 |
| BG08 mp02b, (−35,0,150), i0 | D150, L300 | down, then left to (−335, 0) |

The yaw stays at 0 throughout (nose up the screen): lookAt 0, and `_firstRotate` is the placement rotate 0.

Simulated (`m7_sim.py mp02b`, BG01 212.5 s):

| t | x | z |
|---|---|---|
| 0 | 40 | 150.00 |
| 0.5 | 40 | 146.37 |
| 1.0 | 40 | 135.75 |
| 1.5 | 40 | 119.19 |
| 2.0 | 40 | 98.30 |
| 2.5 | 40 | 75.13 |
| 3.0 | 40 | 51.82 |
| 4.0 | 40 | 14.32 |
| 5.0 | 40 | 0.00 (junction) |
| 6.0 | 47.07 | 0 |
| 8.0 | 101.52 | 0 |
| 10.0 | 189.74 | 0 |
| 15.0 | 340.00 | 0 (EndRoute) |

`mp02a` (`sims/mp02a_BG01_idx2.txt`) runs −220 → −219.08 (0.25 s) → −205.75 (1 s) → −168.30 (2 s; enters at 2.13 s) → −121.82 (3 s) → −84.32 (4 s) → −70 (5 s), then rises z 0.68 (5.25), 10.72 (6.0) … 200 (11.67).

Stack in parallel (mp02a): Delay 3.5 s, then from 3.5 s the four Bullets fire every 1.5 s (`rpidf`, so the rate is scaled by the rapid factor), until FinishWait. mp02b fires from 0 s.

## 5. Reconstruction notes

- `Round1EventStack.Applies` excludes it, because after CreateRouteData the definition has routes. The generic `Round1EnemyWaves.Position` chains routes linearly by distance and then **continues along the last tangent**. Natively:
  - each route is eased InOutSine by its own rate;
  - the enemy is removed at the last route's end (no tangent extension and no viewport cull).
- Hook: when `model == Pf_Ene_Mp02`, set `routes = _routeNames[indexValue]` (table in §1) and play them in route mode (§3). The events go to the stack, where they only fire.
- Route data is missing from the stage JSON for these names (BG01 has none of them; BG08 has only common_U200). Read the RouteLUT assets (`routes.json` here).

## 6. Open questions

- `[?]` `_isEndRouteKeep` (0x1F8) is assumed false (not serialized; set only by code not traced).
- `[?]` Spline length is the Unity Spline length natively; the sim uses the LUT polyline (exactly 150/300/200 for these straight and LUT-sampled routes).
- `[?]` The first-frame `_startPosition` (assumed = spawn, from StartRoute / SetRouteData) was not traced instruction by instruction.
