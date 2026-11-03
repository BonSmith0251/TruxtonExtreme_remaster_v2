# Ene_Sf01 / Ene_Sr01 — stack mode WITH definition routes: the route moves, the stack only times events (BG05, BG06)

Read-only study of `GameAssembly.dll`. Shared machinery: `../../air-route-events/SPEC.md` (stack, task flags, end rules 1–6), `../../ground-route-events/SPEC.md` §1–3 (interpreter, repeat wrapper, Rotate/Idle/TaskWait/Bullet), `../Ene_Mp02/SPEC.md` §3 and `../Ene_Mc01/SPEC.md` §3 (route mode). `[I]` = inference, `[?]` = unknown; everything else is read from the disassembly in `dis/` (`../tools/pdis.py <Class> "<method>"`).
Sim: `sf01_sim.py` (this folder; imports `air_sim.py` and `m7_sim.py`, changes neither). Tracks: `sims/`. Definition dump: `defs_dump.txt` (`../tools/dump_defs.py Pf_Ene_Sf01 Pf_Ene_Sr01`). `../Ene_Sr01/SPEC.md` points here.

## 0. Answer in one paragraph

`EnemyMover.Progress` runs **both** in the same LateUpdate, **stack first, route second**. Only the route (`SplineMover.Progress`) writes the root position. The definition events are **stack events** (executed in list order by `_execStackEvent`); route events by awakeRate are switched off. The route sets **no task flag**: it is not MovingTask 256 and not in EndCheck 0x214, so `TaskWait 256` passes at once. The enemy is removed by whichever comes first: (a) the stack end rule (index past the end, no 0x214 task, root outside its play area), checked every frame before the route step; or (b) `EndRoute` when the last route finishes, which ignores the stack. There is no `Ene_Sf01` or `Ene_Sr01` class. Attribute bit 1 (`RotateSmooth`) only sets `_isSmooth`, which is read only for tangent look types; it does nothing for these lookAt 0 / 30 definitions.

## 1. Identity

| Item | Sf01 | Sr01 |
|---|---|---|
| Prefab (`extraction/pristine-export/ExportedProject/Assets/`) | `Pf_Ene_Sf01.prefab`: `PawnEnemy` (`_HitPoint 1`, not lock-on, laser block, `pf_eff_explposion01`, dead sound 221), `EnemyMover` (defaults: `_lookAtType 0`, `_lookAtUpdateSec 0`, no muzzle packs), `PositionShift` (`_baseY 0, _targetY 0`: inert, as `../Ene_Mb01/SPEC.md` §6), 3× `EnemyCollisionModel` | `Pf_Ene_Sr01.prefab`: `PawnEnemy` (`_HitPoint 20`, lock-on, `pf_eff_explposion01`), `EnemyMover` (defaults), 1× `EnemyCollisionModel` |
| Class | **none of its own**: plain `PawnEnemy`. `code/methods.jsonl` has no type matching `Sf01`/`Sr01`. | same |
| Database (`Resources/StageCombat/enemy-database.json`) | row 157: HP 300, **Small** | row 170: HP 2500, **Small** → `gameScreenArea` (−.15..1.15) for `_isInGamePlayArea` |
| Hierarchy | root `Pf_Ene_Sf01` → child **`pf_ene_sf01`** (identity) → `ene_sf_body` → `muzzle01` (0, 7.93, −2.31) | root → `pf_ene_sr01` → `ene_sr` → `muzzle` (0, 0, 6) |

Definitions with attribute 16 **and** routes (all other Sf01 definitions, `ene_sf01a/b/4a/4b`, have routes [] and are plain stack movers, air spec):

| Definition | attr | position | route (len) | placement | events |
|---|---|---|---|---|---|
| BG05 `ene_sf01_5b3` | 17 | (100,0,120) | `move_sf01_hc_r3` (188.25: U-dip, −60 deep, ends (−120,0)) | speed 40, rotate 0, **easeType 7**, lookAt 0 | Idle 2 · Rotate child `pf_ene_sf01` (0,−180,0) 0.5 s InOutSine · TaskWait 1 · Bullet `sf01_fire1` (value1 0.2, repeat 999 × 1 s, muzzle01) |
| `ene_sf01_5b2` / `_5b` | 17 | (100,0,110) / (100,0,100) | `hc_r2` (251.0) / `hc_r` (313.75) | same | same |
| `ene_sf01_5a3` / `_5a2` / `_5a` | 17 | (−100,0,120/110/100) | `hc_l3` / `hc_l2` / `hc_l` (x-mirrors) | same | same, Rotate (0,+180,0) |
| BG06 `ene_sr01_1b` | 16 | (−50,0,98) | `move_sr01_1b` (369.68: small S, then down-right to (300,−150)) | speed 60, rotate y 180, easeType 0, **lookAt 30** (DriftS); **3 placements**: offset 0 / −50 / +50, delayTime 0 / .25 / .25 | Idle 0.2 · Speed→20 0.5 s · TaskWait 32 · Speed→100 0.5 s · Idle 0.2 · Bullet `sr01_fire1` (flag0 = isSelfDir, muzzle) · TaskWait 256 |
| `ene_sr01_1a` | 16 | (50,0,98) | `move_sr01_1a` (351.83, mirror-ish, to (−300,−150)) | same, offsets 0 / +50 / −50 | same |

Unused fields: the Idle `intValue1`/`vectorValue`/`nameValue`/`stringValue`, TaskWait `dotime`/`vectorValue`, Speed `stringValue` are not read (ground spec §1/§3).

## 2. Setup (read from code)

`EnemyMover.CreateRouteData` 0x1D6C750 (`dis/EnemyMover_CreateRouteData.txt`):
```
_baseEnemyData = data
_smoothRotateValue (0x1D8) = data+0x30
_inAreaStart   = (data.attribute >> 9) & 1
_isEventStackPlay (0x294) = (data.attribute >> 4) & 1          // bit 16
SplineMover.CreateRouteData(data, startPosition)
```
`SplineMover.CreateRouteData` 0x1D43970 (`dis/SplineMover_CreateRouteData.txt`), data non-null branch:
```
_routes = data.routeNames; _routesIndexMax = routes.Length; _routesIndex = 0
_startPosition = startPosition; transform.localPosition = startPosition
updateRouteData(0)                         // SetSpline(route 0); _currentRate = 0*speed/len = 0; _durationPassTime = 0; _currentOffset = 0
SetEventData(data.events, stack = attr & 16, boss = attr & 32)
_isSmooth (0x190) = attr & 1               // EnemyAttribute.RotateSmooth = 1
_durationTime = data.duration              // 60, never read while _splineLength > 0
```
`SplineMover.SetEventData` 0x1D44240 (`dis/SplineMover_SetEventData.txt`): with `stack` true every event is `List.Add`ed **in definition order** (the immediate-exec branch for Rotate/Scale/Translate with dotime 0 and awake 0, and `InsertEventSorted` by awakeRate, are taken only when `stack` is false; type 9 with boss&&stack executes at once). So the four Sf01 events and seven Sr01 events are stack events. `EnemyMover.UpdateEvent` 0x1D6CDB0 returns immediately when `_isEventStackPlay` (`dis/EnemyMover_UpdateEvent.txt`), so `_ProgressSpline`'s awakeRate dispatch (vslot 0x348) does nothing.

`SplineMover.StartRoute` 0x1D44600: `_currentOffset = _currentRate = 0` (one qword store), `_splineRotate = identity`, `localRotation = _firstRotate`, `_moverState = 2` (Playing), `_nextEasingType = −1`, `_nextLookAtType = 0`. `_firstRotate` = placement rotate (·clip rotate, 0 here): Sf01 yaw 0, Sr01 yaw 180 (air spec §2).

## 3. Per-frame order (read from code)

```
EarlyUpdate:  Speed ramp tasks (air spec §1 14)                                    // a ramp started by the stack took its first step there
LastUpdate:   async tasks: Rotate tween on the child (DOTween Manual [?: exact point]), Bullet waits/shots
LateUpdate:   PawnEnemy.LocalLateUpdate 0x1D0E790 (dis/PawnEnemy_LocalLateUpdate.txt)
  mover._isInGamePlayArea = IsInGameAreaWorld(root.position, gameScreenAreas[_sizeType = Small])   // position BEFORE this frame's step
  ... -> EnemyMover.Progress(dt) 0x1D6CB50 (dis/EnemyMover_Progress.txt):
     if dt <= 0 or !IsPlaying() (vslot 0x258 = SplineMover.IsPlaying: moverState 2 or 4): return
     if _isEventStackPlay: _execStackEvent(dt)                                    // 1st
     if IsSplineRoute() (_routes != null && _routesIndexMax > 0) or !_isEventStackPlay:
         SplineMover.Progress(dt)                                                  // 2nd
```
`EnemyMover.Progress` disassembly (0x1D6CB50, 0x76 bytes): `cmp [rbx+0x294],0 / je → call 0x1d6ced0 (_execStackEvent)`, then `call 0x1d43d60 (IsSplineRoute)`, `jne → call 0x1d43df0 (SplineMover.Progress)`. Both are guarded by the same `IsPlaying` check at the top.

`_execStackEvent` 0x1D6CED0 is unchanged from the ground spec §1 (`dis/EnemyMover__execStackEvent.txt`): the end check at 0x1D6D34D–0x1D6D37F is `idx >= count && !(taskFlag & 0x214) && !_isInGamePlayArea → EndRoute (vslot 0x278)`, reached only when `_isExecStackEvent` returned true (no Idle/Delay wait pending, no FinishWait).

`_isExecStackEvent` 0x1D6D3D0: `_eventStackDelay -= dt`; while it is still > 0 and `_lookAtType` is a drift type (30–32), it calls `_AddDriftAngle(0, 0.2, dt)` and writes `localRotation = _firstRotate · drift` (Sr01 during its two Idles). SplineMover.Progress overwrites that rotation later in the frame, but the drift state `_rollAngle` has been advanced twice in that frame [I: the shared state].

`SplineMover.Progress` 0x1D43DF0 (`dis/SplineMover_Progress.txt`):
```
_ProgressSpline(dt)
if (taskFlag & 0x700) == 0x700: return               // all of Moving|Horming|Direction set: never for these programs
if !IsSplineMove() (moverState == 4 or _splineLength <= 0): return
SetLocalPositionAndRotation(_startPosition + _routeRotate·_splineCurrentPosition, _firstRotate · _splineRotate)
```
`_ProgressSpline` 0x1D44AE0 (`dis/SplineMover__ProgressSpline.txt`):
```
if IsPausing (moverState 4): drift types only: _AddDriftAngle + localRotation; return
if dt <= 0 or !IsPlaying(): return                  // after EndRoute moverState = 3: no step
_durationPassTime += dt
_currentRate = IsSplineMove ? _currentRate + dt·_currentSpeed/_splineLength : (duration > 0 ? pass/duration : 1)
if rate < 1: off = Easing01(rate, _easingType)       // Sf01: 7 = InOutSine01 (0.1° Cosf table); Sr01: 0 = linear
else: rate = 1; off = 1; done; dt' = 0               // xorps xmm7,xmm7 at 0x1D44BF7
UpdateEvent(prevOff, off − prevOff)                  // vslot 0x348 -> EnemyMover.UpdateEvent: returns (stack mode)
_currentOffset = off
_splineCurrentPosition = EvalCachedPosition(spline, off) − _splineStartPosition
_lookAtUpdatePas += dt'
if off < 1 and pas >= _lookAtUpdateSec (0): _splineRotate = _getRotate(spline, off, off − prevOff, dt')
if done:
   if _routesIndex + 1 < max: _easingType = _nextEasingType if != −1; _routesIndex++; _startPosition = localPosition;
                              updateRouteData(dt' = 0)                // rate 0, pass 0, offset 0 for the next route
   elif !_isEndRouteKeep: EndRoute()                                  // vslot 0x278; moverState = 3
   else: moverState = 4
```
`_getRotate` 0x1CDC830 (`dis/InGameEnemyMoveBase__getRotate.txt`): lookAt 30–32 → `_AddDriftAngle(EvalPos(off+Δ).x − EvalPos(off).x, 0.2, dt)` (Δ = the eased step); **lookAt 0 → `Quaternion.identity`**; other types → tangent, `Vector3.SmoothDamp` only when `_isSmooth`.

Consequences:
- **Position:** only `SplineMover.Progress` writes it, every frame, as an absolute `_startPosition + LUT(off) − LUT(0)`. The route is not rotated by the clip or the placement (`_routeRotate` identity [I], as Mp02/Mc01).
- **Root rotation:** rewritten every frame to `_firstRotate · _splineRotate`. A stack Rotate on the **root** would be overwritten each frame [I: unless the DOTween Manual update runs after LateUpdate]. Sf01's Rotate targets the **child** `pf_ene_sf01` (cache key = path without the root name, ground spec §3), so it survives: root yaw stays 0 and the model turns under it.
- **Speed:** the route reads `_currentSpeed` each frame, so stack Speed events change the route's rate (Sr01: 60 → 20 → 100).
- A stack move event (ForwardMove, Horming, …) in such a definition would also write `localPosition` in LastUpdate and be overwritten by the route in LateUpdate [I]; none of these 8 definitions has one.

## 4. Task flags and end rules

- Route mode writes **no** `_taskFlag` bit: `SplineMover.Progress`, `_ProgressSpline`, `updateRouteData`, `StartRoute`, `CreateRouteData` and `SetEventData` contain no `_taskFlag` access (`grep _taskFlag dis/*.txt`: only `_execStackEvent` and the read-only 0x700 test in `Progress`). MovingTask 256 is set only by the stack's own move tasks (`_moveTypeUpdateAsync`, air spec §1 12/7/6/15).
  - Sf01 `TaskWait 1` waits only for the child Rotate tween (RotateTask 1).
  - Sr01 `TaskWait 32` waits for the first Speed ramp; its last `TaskWait 256` passes on the frame it is reached, so the program is exhausted at that frame.
  - Bullet sets no task bit (`_eventToTaskflag`: only 13→4, 2→1, 3→2, 4→8, 9→16; ground spec §0), so a Bullet still repeating does not hold the enemy.
- **Stack end (rule 2 of the air spec):** each LateUpdate, before the route step: `idx ≥ count && !(flags & 0x214) && !_isInGamePlayArea` → `EndRoute`. Entering is not required. `_isInGamePlayArea` uses the root position at the start of the frame. After this EndRoute, `moverState = 3`, so the route step of the same frame does nothing (`_ProgressSpline` IsPlaying gate) and `Progress` rewrites the unchanged position.
- **Route end:** when the last route's rate reaches 1, `EndRoute` regardless of the stack (pending Idle, TaskWait, Bullet repeats); the position written that frame is the route's last point. `_isEndRouteKeep` assumed false [?] (Mp02 §6).
- **Area exit (rule 1)** does not exist in route mode; it lives only in `_moveTypeUpdateAsync`.
- **FinishDestroy (1000) / FinishWait (1001):** not in these definitions. If present they behave as in the stack spec (FinishWait would freeze the stack and disable rule 2, leaving only the route end — that is Mp02's case).
- **duration (60):** not used (`_splineLength > 0`).

So for these programs: stack exhausted while on screen → removed the first frame the start-of-frame position is outside `gameScreenArea`; if the route ends first → removed at the route end.

## 5. Simulated tracks (`sf01_sim.py`, 60 fps, float32 counters, player at sky (0,0,−49))

Row i of `track` = state after i+1 steps: `[t, x, y, z, yaw, speed]`, Sr01 adds a 7th column `bank` (drift roll °, as `../Ene_Sq01/sims`). `yaw` = root yaw + the child Rotate (the visible model heading). The last row is the removal frame (position unchanged by a stack EndRoute). Times in the tables below are frame-start times: an event at t happens in the frame that starts from the row whose time is t; its effect shows in the next row. Commands: `python -I sf01_sim.py sf01_5b3 --json sims/sf01_5b3_BG05.json --txt sims/sf01_5b3_BG05.txt` and the same for `sr01_1b`.

### BG05 `ene_sf01_5b3`, first clip 344.0 s, offset (−80,0,0) → spawn (20, 0, 120)

| t (s) | x | z | yaw | note |
|---|---|---|---|---|
| 0 | 20.00 | 120.00 | 0 | above the top (area edge z 91.7); route r3 eased InOutSine, 188.25/40 = 4.71 s |
| 0.5 | 19.26 | 114.87 | 0 | |
| 1.0 | 16.50 | 100.17 | 0 | |
| 1.233 | 12.55 | 91.12 | 0 | first frame inside gameScreenArea |
| 1.5 | 4.97 | 80.32 | 0 | |
| 2.0 | −18.37 | 64.06 | 0 | Idle 2 ends at 2.017 s: child Rotate −180° over 0.5 s InOutSine |
| 2.5 | −49.31 | 60.77 | 182 | bottom of the dip (visible top edge is z 70.5) |
| 2.517 | | | 180 | TaskWait 1 passes; Bullet started → **stack exhausted** (enemy on screen, so it stays) |
| 2.733 | −63.12 | 64.64 | 180 | Bullet `sf01_fire1` shot 0 (value1 0.2 after the muzzle is in the bullet area); next would be 3.75 s |
| 3.0 | −76.68 | 72.57 | 180 | |
| 3.517 | −93.13 | 92.17 | 180 | **removed** (`events-exhausted`): start-of-frame z 92.17 ≥ 91.7. Frame 211. |

Without rule 2 the route would end at 4.717 s at (−100, 120). `5a3` is the exact x-mirror. `5b` (route `hc_r`, spawn (60,0,100) at 343.0 s) dips to z ≈ 0, fires 5 shots (2.73, 3.75, 4.77, 5.78, 6.80 s) and is removed at 7.05 s at (−138.9, 92.0) (route end would be 7.85 s).

### BG06 `ene_sr01_1b`, first clip 341.0 s, offset (0,0,0), placement 0 → spawn (−50, 0, 98)

| t (s) | x | z | speed | bank | note |
|---|---|---|---|---|---|
| 0 | −50.00 | 98.00 | 60 | 0 | Idle 0.2; route 1b linear, starts down-left |
| 0.217 | −61.02 | 91.46 | 60 | | first frame inside; Idle ends: Speed 60→20 over 0.5 s (first step this frame), TaskWait 32 |
| 0.5 | −65.23 | 80.14 | 37.3 | 0.5 | |
| 0.717 | −61.44 | 75.44 | 22.7 | | ramp done → Speed 20→100 over 0.5 s, Idle 0.2 |
| 0.933 | −54.86 | 70.31 | 57.3 | | Idle ends: Bullet `sr01_fire1` (isSelfDir, once, at once); TaskWait 256 passes → **stack exhausted** |
| 1.0 | −51.40 | 68.13 | 65.3 | 1.4 | |
| 1.217 | | | 100 | | ramp done |
| 1.5 | −9.34 | 48.40 | 100 | 15.7 | |
| 2.0 | 37.01 | 29.55 | 100 | 31.3 | |
| 2.5 | 83.61 | 11.31 | 100 | 45.0 | roll saturates at DriftS 45° [I: `_AddDriftAngle` law from `../tools/m7_sim.py`] |
| 3.0 | 130.32 | −6.63 | 100 | 45.0 | |
| 3.367 | 163.06 | −19.08 | 100 | 45.0 | **removed** (`events-exhausted`): start-of-frame x 163.06 ≥ 163.0. Frame 202. |

Yaw stays 180 (nose down; lookAt 30 has no yaw term). Without rule 2 the route would end at 4.283 s at (250, −52). `1a` (330.0 s, spawn (50,0,98)) mirrors it and is removed at 3.217 s at (−164.4, −23.8).

Placements 1 and 2 (offset ±50, delayTime 0.25) are the same program from a shifted spawn [I: delayTime handled by the wave spawner; not traced here].

## 6. For the C# port

1. **Detect the mode:** `attribute & 16` and `routes.Length > 0` (after any class `CreateRouteData`; none for Sf01/Sr01) → "stack + route". Do **not** exclude it (as `Round1EventStack.Applies` does for Mp02) and do not use the generic route chaining with tangent extension.
2. **Each frame, in this order:** Speed ramps (EarlyUpdate) → tweens and bullet waits (LastUpdate) → `inPlayArea = viewport(position at frame start) ∈ gameScreenArea (Small)` → **stack interpreter** (definition events in list order; may EndRoute) → **if not ended, the route step** with the current `_currentSpeed` → write position `start + LUT(eased off) − LUT(0)` and root rotation `_firstRotate · (lookAt 0 ? identity : drift/tangent)`.
3. **Position comes only from the route.** Easing per route = `placement.easeType` (Sf01 InOutSine, Sr01 linear), by rate `speed·dt/length`, not by distance. No clip/placement rotation of the route.
4. **Events are stack events**, not awakeRate events. Ignore `awakeRate` for these definitions.
5. **The route holds no task bit.** `TaskWait 256` does not wait for the route; `TaskWait 1` waits for the child Rotate; `TaskWait 32` for a Speed ramp. Bullets hold nothing.
6. **Rotate with `nameValue` = child path** turns the child model (Sf01 `pf_ene_sf01`: −180° / +180° over 0.5 s InOutSine, relative). The root heading stays `_firstRotate`.
7. **End:** remove when (a) the stack index is past the end, no 4/16/512 task is set and the start-of-frame position is outside gameScreenArea — checked every frame from the frame the program runs out; or (b) the last route reaches rate 1 (remove that frame, at the route's last point), whatever the stack is doing. No area-exit rule 1, no `duration` limit. Both 5b3 and 1b end by (a) in the sims.
8. **Attribute bit 1** (`RotateSmooth`): only enables `SmoothDamp` of the tangent look direction (`_isSmooth`, read only in `_getRotate`'s tangent branch). No effect for lookAt 0 (Sf01 route definitions) or drift 30 (Sr01). It can be ignored for these 8 definitions.
9. Sr01 drift roll (visual): advance the DriftS roll from the route's eased x step each frame, plus a decay-only call `_AddDriftAngle(0, …)` on frames where the stack is waiting on an Idle.

## 7. Cross-check notes

- **Junction in route chains:** `_ProgressSpline` zeroes its dt register on the done frame (0x1D44BF7) and calls `updateRouteData(0)` (0x1D44E22), so the next route starts at rate 0 / pass 0. `../Ene_Mc01/SPEC.md` §3 states this; `../Ene_Mp02/SPEC.md` §3 and `../tools/m7_sim.py` `RouteMover` use `dt·speed/len` (one extra step after each junction). Irrelevant for the single-route Sf01/Sr01 definitions; worth fixing in those multi-route models (not edited here).
- `../tools/m7_sim.py` `RouteMover` stops without writing the final route point and does not run the stack. `sf01_sim.py` runs the air_sim stack and writes the last point on a route end.

## 8. Open questions

- `[?]` `_isEndRouteKeep` (0x1F8) assumed false (not serialized).
- `[?]` The exact DOTween Manual update point (±1 frame on the end of the child Rotate and so on the Bullet start).
- `[?]` `EvalCachedPosition` LUT vs the stage JSON knot `times`; the sim interpolates linearly between knots (as Mc01/Mp02).
- `[?]` Whether all three Sr01 placements spawn per clip and how `delayTime 0.25` is applied (wave spawner, not traced).
- `[I]` The drift roll state is shared, so Idle frames advance it twice (stack wait + route).
