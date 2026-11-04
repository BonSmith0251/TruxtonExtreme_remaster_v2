# Ene_Lb01 + EnemyMoverSnake — the snake (Pf_Ene_Lb01), and the BG02 one-route movers (Mh01, Sk01, La01)

Read-only study of `GameAssembly.dll` (IL2CPP x64), 2026-11-04. `[I]` = inference. Frame and units as `../../air-route-events/SPEC.md`
(sky plane x right, z up, y toward the camera). Tools: `../tools/mdis.py`, `../tools/mlist.py`. Model: `sims/native_movers_sim.py`
(offline, same rules as the C# port) with `sims/*.png`.

## 1. Route: `Ene_Lb01.CreateRouteData` 0x1DBCC90

`EnemyData.ShallowCopy()`, then `copy.routes = new string[1] { _routeNames[_indexValue] }` (pawn field 0x1D8, bounds-checked), then
`PawnEnemy.CreateRouteData(copy, pos)`. `GetRouteNames` 0x1DBCDC0 appends the whole `_routeNames` list for preloading. The prefab
lists 15 routes, `move_lb01_00` .. `move_lb01_14` (RouteLUTs, all planar, 531–877 units long). Stage use: BG03 ×8
(indexValue 1, 4, 5, 6, 7, 7, 8, 10), BG08 ×2 (7, 8).

The definition `ene_lb01` has attribute 0 (no stack), speed 40, easeType 0, lookAt 1, duration 60. So it is a SplineMover in
route mode (`../Ene_Mc01/SPEC.md` §3): one relative leg from the spawn point at 40 u/s, events by awakeRate (all 0: SetObjFlag 512
"side", three BSelectors every 2 s), nose along the tangent, **EndRoute when the route ends** (no area exit, no duration).
The stage builder now exports these routes (`tools/stage_enemies/build_stage_enemies.py`, prefab `_routeNames`).

Model (`sims/lb01_routes.png`): every spawn crosses the screen on a curve and ends with the head 244–344 units beyond the
visible edge and no bone on screen. The Round 1 recording notes (recordings/ash-r1-stage01-nofire-20261027, not on this machine
any more) had the head 165–320 beyond the edge at all 8 exits, about one body length.

## 2. Bones: `EnemyMoverSnake` (EnemyMover subclass)

Fields: `_head` 0x2C0 (`ene_lb01_body01`), `_bones` 0x2C8 (`ene_lb01_body021`..`027`, `ene_lb01_body03`, each the child of the
previous), `_headDistance` 0x2D0 = 14.5, `_boneDistance` 0x2D4 = 26, `_boneDirections` 0x2D8, `_headRate` 0x2E0, `_boneRate` 0x2E4.

- `SetSpline` 0x1D6B230: `SplineMover.SetSpline`, then `_headRate = _headDistance / length`, `_boneRate = _boneDistance / length`.
- `Progress` 0x1D6B210: `EnemyMover.Progress(dt)`, then `_updateBones()`.
- `_updateBones` 0x1D6B460 (skipped when the game is stopped, `_lookAtType` 0x1AC is 0, or there are no bones):

```
off = SplineMover._currentOffset (0x208)                 // the eased offset of this frame
expected = routeRotate·(Eval(clamp01(off)) − splineStart) + _startPosition   (through root.parent when local)
delta = (_head ?? root).position − expected              // the head's real position minus its path point
u = off − _headRate
for each bone i:  (parent = bone.parent ?? root)
    t = clamp01(u)
    dir = skyRoot.TransformDirection(routeRotate·EvalCachedTangent(t))
    if |dir|² < ε: dir = |_boneDirections[i]|² > ε ? _boneDirections[i] : head.forward
    dir = |dir| > 1e-5 ? dir/|dir| : 0;  _boneDirections[i] = dir
    bone.localRotation = Inverse(parent.rotation) · LookRotation(dir, parent.up)
    bone.localPosition = parent.InverseTransformPoint(head.position + skyRoot.TransformVector(routeRotate·(Eval(t) − Eval(off))))
    u −= _boneRate
```

So bone i lies on the route 14.5 + 26·i **sky units** behind the head and points along the route there. Before the head has
travelled that far the bones pile up on the route's first point (the spawn point, off screen for every Lb01 spawn). The rest
pose is longer: `body01` is scaled 1.15 and `body021` 1.05, so the prefab bones sit at 16.7 + 27.8·i; the bent snake is about
6% shorter. The body hit circles (pairs 15.1 behind each bone, the tail pair on `body03`) ride on their bones.

Port: `Round1EventStack.ClassRoutes` (Lb01, like Mp02), `Round1EnemyWaves.SnakeBones` (root-local, every frame after the yaw).

## 3. The BG02 one-route programs

| Definition | Mode | What runs natively | Was |
|---|---|---|---|
| `ene_mh01_2a/2b` (Mh01 ×18), BG08 `ene_ma01_3` (×5) | stack (attr 16): SplineMove, SetObjFlag, Bullets, TaskWait 256 | `Round1EventStack` (stack SplineMove); lookAt 32/30 = drift bank | generic spline player |
| `ene_sk01a/b` (Sk01 ×11), `ene_la01_*` (La01 ×15) | attr 0, no routes, SplineMove at awakeRate 0 | see below | generic spline player |

**Event spline (attr 0, no routes).** `SplineMover.Progress` runs every frame. On frame 0 `_ProgressSpline` has no spline: rate =
`_durationPassTime / duration` (1/3600), and `UpdateEvent` fires the awake-0 SplineMove, whose `SetSpline` (vslot 0x2F8 →
`SplineMover.SetSpline` 0x1D44540) sets `_splineLength`. From then on `IsSplineMove` is true: rate += dt·speed/length, the
position is written by `SplineMover.Progress` (after the move task's write, which it overrides), the other events fire by that
rate (Speed ramps, Bullets), and **EndRoute when the rate reaches 1**. Sk01 (`sims/sk01_routes.png`): dives from (±50, 150) at
100, Speed → 50 over 0.5 s at 30% (0.95 s), fires `sk01_fire1` and Speed → 200 over 1 s at 46% (1.47 s), U-turn at mid-screen,
removed back above the top at 3.10 s. La01: 16.3–16.6 s legs from z 250 with 100 → zm100 speed changes at 20% and 75%.

**Banking (`_rollAngle` 0x16C).**
- Drift types 30–32 (`_getRotate` 0x1CDC830 → `_AddDriftAngle(x, 0.2, dt)` 0x1CDB930): `../Ene_Sq01/SPEC.md` §5, tables
  `_DriftArcs {45, 30, 20}`, `_DriftSpeed {3, 2, 1}`, `_DriftBackSpeed {180, 90, 45}`; also `_AddDriftAngle(0, …)` while a stack
  Delay/Idle is pending (`_isExecStackEvent`). The yaw stays `_firstRotate`.
- RollForward 20 (`_rollForwardMove` 0x1CDCE50): step = speed·0.02/length; ahead = mean of the tangents at off + step·1..4;
  diff = `GetQuaternionDiff` (0x1DF7240: yaw(ahead) − yaw(current), wrapped); |diff| ≥ 1 → roll += diff·(roll·diff < 0 ? 2 : 0.25),
  else roll returns by 6 a frame (to 0 when |roll| ≤ 6); clamp ±100. If roll ≠ 0, up = Lerp(up, roll > 0 ? right : left, |roll|/160)
  of the current look rotation; `LookRotation(tangent, up)`. A bank of atan(t/(1−t)), up to 59°. Not dt-scaled.
- Attacks of route-mode movers are cued when their awakeRate is reached (`Round1EventStack.TimesBullets`), not pre-scheduled
  from route-length estimates (which ignored the Speed ramps).

## 4. Checked in the remaster (2026-11-04, `verification/native-movers-20261104/`)

- EventStackCheck 8/8, ClassMoverCheck 16/16, GroupMoverCheck 7/7 pass; no crash in any run.
- Stage play BG03 (no fire, to 283 s): 6 Lb01, lifetimes 17.27/13.27/17.92/14.11/14.07/13.29 s (model 17.25/13.27/17.90/14.07/
  14.07/13.27), all ending at the route end 259–328 beyond the edge; bodies bend along the curves (`stage-play/BG03-at230.png`).
- BG02 (no fire, to 90 s): Mh01 6/6 end at the route end after 5.91 s (model 5.93), drift bank ±9.8°, both wing lasers fire.
  Its `mh01_shot2a_2` (3 s after the muzzle enters) never fires: by then the battery muzzle is at viewport x 0.00/−0.06, outside
  the story bullet area (0.05..0.95), which the original skips too (IsCheckFire). Sk01 lives 2.9–3.0 s, banks to 59° in the U-turn,
  fires at 1.7 s; La01 lives 16.7–17.0 s.
- BG08's Lb01 and Ma01_3 are wipe-out bonus waves; the autopilot run did not unlock them, so they were not seen in play.

## 5. Open

- `[I]` `EvalCachedTangent` is taken as the RouteLUT `_tangents` interpolated like the positions; the RollForward average uses
  normalised tangents.
- `[?]` The exact Lb01 path, bone and exit timings are not yet compared with a recording of the original.
