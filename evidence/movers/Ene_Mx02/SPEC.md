# Ene_Mx02 — no motion code; a route-mode enemy with awakeRate events (BG08 opening, 15,000 HP)

Read-only study of `GameAssembly.dll`. Route mode is specified in `../Ene_Mp02/SPEC.md` §3; the awakeRate event dispatch is specified here (§3). `[I]` = inference, `[?]` = unknown.
Sim: `../tools/m7_sim.py mx02` (`RouteMover`).

## 1. Identity

| Item | Value |
|---|---|
| Prefab | `Assets/OriginalRecovered/Samples/Prefabs/Reference/Enemy/Pf_Ene_Mx02.prefab`: `EnemyMover` (defaults), `Ene_Mx02` (`_HitPoint 100` in the prefab, `_overplayDeadSound 206`, `_deadExplosion pf_eff_explposion02`, **`_item 2`**), one `EnemyCollisionModel`. Hierarchy `pf_ene_mx01_sky/ene_mx01_sky`, `ene_mx01_canon`, muzzles `muzlle01..03`, burner `pf_eff_burner_e04`. |
| Database | `Resources/StageCombat/enemy-database.json` row 150 "Mx02": **hitpoint 15000**, score 20000, size **Medium**, lock-on, priority 1000. The database overrides the prefab's 100. |
| Class | `Ene_Mx02 : PawnEnemy`. Its only own method is `_callDeadEffect` 0x1CFDE10 (death item `_item`; see `../../death-bullets/SPEC.md`). **No CreateRouteData, no Progress, no LocalLateUpdate: the class does not move the enemy.** |
| Definitions (BG08) | `ene_mx02_1a` (route `move_sn01_1a`) and `ene_mx02_1b` (route `move_sn01_1b`, the x-mirror). Both: **attribute 0 (route mode, not stack)**, duration 0, position (0,0,105); placement speed 80, rotate 0, easeType 0 (Linear), **lookAt 1** (Forward). |
| Events | `Speed(30, 0.5)` awake 0; `Speed(80, 0.5)` awake 0.2; `Bullet mx02_fire1` awake 0.2, randomWait 0.5, at `pf_ene_mx01_sky/muzlle03` |
| Spawns (spawn = (0,0,105)+offset) | 1a: 5.0 (0,0,0), 5.8 (−25,0,10), 6.0 (25,0,10), 22.0 (0), 22.8 (−25,10), 23.0 (25,10), 23.6 (50,20), 23.8 (−50,20). 1b: 10.0 (0), 10.8 (25,10), 11.0 (−25,10), 27.0 (0), 27.8 (25,10), 28.0 (−25,10), 28.6 (−50,20), 28.8 (50,20). |

Route `move_sn01_1a` (BG08 JSON, 44 points):

- (0,0) → (18.2,−21.8) → (29.2,−40.1) → (29.8,−50.5) → (21.2,−60.1) → (−2,−71.8) → (−88.6,−96.8) → (−162.6,−113.6) → (−200,−120).
- So it swings right, hooks back left under its spawn and leaves to the lower left. `1b` mirrors this in x.

## 2. Motion (all from SplineMover route mode)

`EnemyMover.CreateRouteData` 0x1D6C750 with attribute 0 means `_isEventStackPlay` is false, so `EnemyMover.Progress` runs only `SplineMover.Progress` each LateUpdate.

- `SplineMover.SetEventData` 0x1D44240, route branch: Rotate/Scale/Translate events with dotime 0 and awakeRate 0 run at once. Everything else is inserted with `InsertEventSorted` 0x1D43BE0 by ascending awakeRate. For Mx02 the order is Speed@0, Speed@0.2, Bullet@0.2.
- Per frame: `_currentRate += dt·_currentSpeed/len`, offset = Easing01(rate, 0) = rate. Position = spawn + LUT(offset) − LUT(0), with no rotation of the route.
- Speed: frame 0 starts the 80 → 30 ramp over 0.5 s (EarlyUpdate task, first step at once). At 20% of the route the 30 → 80 ramp starts, and the shot fires `U[0,0.5)` s later (randomWait).
- Facing (lookAt 1): `localRotation = _firstRotate · _splineRotate`, where `_splineRotate` comes from `_getRotate` 0x1CDC830 lookAt-1 branch: `EvalCachedTangent`, smoothed with `Vector3.SmoothDamp(_beforeDirection, tangent, _currentDirection, _smoothRotateValue, ∞, Time.deltaTime)` when `_isSmooth`. The nose follows the path tangent. The sim uses the raw eased tangent [I].
- End: when the single route finishes, `EndRoute`. There is no area exit in route mode and duration 0 is never consulted (`splineLength > 0`).

## 3. Route-mode event dispatch (`SplineMover.UpdateEvent` 0x1D44720, via `EnemyMover.UpdateEvent` 0x1D6CDB0)

```
UpdateEvent(prevOffset, delta):                // called from _ProgressSpline with the EASED offsets
  if events empty or delta <= 0: return
  r0 = _routesIndex + prevOffset;  r1 = r0 + delta
  if _eventLastRate >= r1: return;  _eventLastRate = r1
  for i from _eventIndex:
     a = events[i].awakeRate
     if r0 > a: i++ (skipped for good)        // an event whose rate was jumped over is lost
     elif r1 > a: ExecEvent(events[i]); i++   // vslot 0x2C8 -> _execEventWithRepeat (repeat wrapper as in the stack)
     else: break
  _eventIndex = i
```

- `awakeRate` is in "route index + eased offset" units: 1.0 = start of the second route.
- An event at 0 fires on the first frame, because r0 = 0 is not > 0 and r1 > 0.
- An event at exactly n.0 fires on the first frame of route n, not on the junction frame.

## 4. Simulated path (`m7_sim.py mx02`): BG08 t = 5 s, `ene_mx02_1a`, clip (0,0,0)

| t | x | z | yaw | speed | note |
|---|---|---|---|---|---|
| 0 | 0 | 105.00 | 0→139 | 80 | spawn above the top edge (91.7); Speed → 30 |
| 0.25 | 10.80 | 92.28 | 139.3 | 55 | enters at 0.27 s |
| 0.5 | 17.41 | 84.23 | 142.3 | 30 | |
| 1.0 | 25.87 | 71.85 | 150.2 | 30 | |
| 1.5 | 30.50 | 57.78 | 183.4 | 30 | |
| 1.617 | 29.77 | 54.39 | 201.2 | 31.7 | awake 0.2: Speed → 80, Bullet `mx02_fire1` (+U[0,0.5) s) |
| 2.0 | 16.00 | 41.58 | 240.0 | 68.3 | |
| 2.5 | −20.49 | 26.80 | 252.3 | 80 | |
| 3.0 | −58.98 | 15.90 | 255.4 | 80 | |
| 4.0 | −136.52 | −3.69 | 258.6 | 80 | leaves the left edge at 4.35 s |
| 4.8 | −199.53 | −14.92 | 260.3 | 80 | route end → EndRoute |

## 5. Reconstruction notes

- No class hook is needed. The reconstruction must play **route mode** with:
  - per-route linear (here) easing by rate;
  - **Speed events** at awakeRate, which change `_currentSpeed` and therefore the rate;
  - removal at the route end.
- The generic `Round1EnemyWaves.Position` uses a constant speed and continues along the tangent, so it gets the timing wrong: 80→30→80 is not modelled, and the enemy would finish the route in 3.80 s (303.6 / 80) instead of 4.80 s.
- 15,000 HP and Medium size come from the enemy database. The Medium size only matters for stack-mode area tests and is irrelevant here.

## 6. Open questions

- `[?]` `_smoothRotateValue` (EnemyData +0x30) and `_isSmooth` for this definition (not in the stage JSON). They decide how much the nose lags the tangent.
- `[?]` The `Speed` ramp started inside UpdateEvent (LateUpdate) takes its first step synchronously; the next steps run in EarlyUpdate. The sim does the same (±1 frame).
