# Ene_Sq01 — route program chosen by the clip's indexValue (BG06)

Read-only study of `GameAssembly.dll`. Shared machinery (event stack, SplineMove, frame order, end rules) is in
`../../air-route-events/SPEC.md`; this file only adds what `Ene_Sq01` does. `[I]` = inference, `[?]` = unknown.
Tools: `../tools/cctor_programs.py` (decodes the static programs), `../tools/lut_routes.py` (route LUTs), `../tools/m7_sim.py` (sim), `../tools/dump_defs.py`.

## 1. Identity

| Item | Value |
|---|---|
| Prefab | `Assets/OriginalRecovered/Pf_Ene_Sq01.prefab`: `EnemyMover` (all serialized defaults: `_lookAtType 0`, `_muzzlePacks []`, `_lookAtUpdateSec 0`), `Ene_Sq01` (`_HitPoint 20`, lock-on, `_deadExplosion pf_eff_explposion01`), one `EnemyCollisionModel` |
| Class | `InGame.Kernel.Enemy.Ene_Sq01 : PawnEnemy`. Own code: `.cctor` 0x1D043A0, `CreateRouteData` 0x1D03B70, `GetRouteNames` 0x1D04090, `GetBulletTemplates` 0x1D03CD0. No Progress / LocalLateUpdate override: **no per-frame code of its own**. |
| Definition | BG06 `ene_sq01`: attribute 16 (EventStack), **events [] and routes []**, duration 60, position (0,0,100); placement speed 30, range 0, rotate y 180, **easeType 7** (EaseInOutSine), **lookAt 30** (DriftS) |
| Spawns (BG06) | 17 clips, all `indexValue` 2 or 3: 328.0 (+20,0,0) i2, 329.5 (0) i2, 331.0 (−20) i2, 332.6 (−40) i2, 334.0 (−60) i2; 339.0 (−20) i3, 340.5 (0) i3, 342.0 (+20) i3, 343.6 (+40) i3, 345.0 (+60) i3; 350–356 = the 328 group again (i2); 370.0 (−20) i3; 388.0 (+20) i2; 403.0 (−20) i3. Spawn point = (0,0,100) + clip offset. |

## 2. What the class code does

`CreateRouteData(sourceData, startPosition)` 0x1D03B70 (virtual, replaces `PawnEnemy.CreateRouteData` 0x1D0D170):

```
_enemyData (this+0x1B0) = sourceData.ShallowCopy()                       // EnemyData::ShallowCopy 0x1D32EC0
_enemyData.eventDatas (0x58) = _routeEventLists[this._indexValue (0x94)].ToArray()   // List.get_Item: throws if index > 3
_enemyData.Coordinate()                                                   // 0x1D321E0: label table (LP1)
this._mover (0xB8)->CreateRouteData(_enemyData, startPosition)            // vslot 0x288 = EnemyMover.CreateRouteData 0x1D6C750
```

- The clip's `indexValue` reaches `_indexValue` through `InGameCollisionBase.SetIndexValue` 0xE26C10.
- The event objects are **shared static instances** (ToArray copies references). The stack never writes them, so sharing is harmless.
- attribute 16 is kept, so `EnemyMover.CreateRouteData` runs the program in **stack mode**. routes stay empty, so `SplineMover.Progress` never runs and the 60 s duration is not used (air spec §3.5).
- After that the enemy is an ordinary stack mover: every motion below comes from the shared events (air spec §1 SplineMove/Speed/Idle/TaskWait/Loop).

`GetRouteNames` 0x1D04090 walks all four lists and returns the distinct `stringValue`s of the type-15 events. It is used for preloading only.

## 3. The four programs (`.cctor` 0x1D043A0, decoded by `cctor_programs.py 1D043A0 1446`)

Static events:
- `laser1` = `BSelector("sq01_fire1_sel", 0, 0, 0, 0, "pf_ene_sq01/ene_sq/muzzle", isSelfDir=true)` (type 83, @0x1D044C5);
- `laser2` = the same with `"sq01_fire2_sel"` (@0x1D0451C);
- `stop1` = `Idle(0.1)` (type 20, @0x1D04557);
- `stop2` = `Idle(2.0)` (@0x1D04592).

RouteEvent factory semantics: `SplineMove(r)` → type 15 `stringValue=r`; `TaskWait(f)` → 80 `intValue1=f`; `Label(n)` → 5; `Loop(n,c)` → 101 `stringValue=n, intValue1=c`; `Speed(v,t)` → 14 `value0=v, dotime=t`; `Idle(t)` → 20 `dotime=t`. Every other field is 0.

| index | events |
|---|---|
| 0 | `SplineMove common_D50, TaskWait 256, Label LP1, stop1, laser1, SplineMove move_sq01_r, TaskWait 256, stop1, laser1, SplineMove move_sq01_l, TaskWait 256, Loop(LP1, 2), Speed(60, 0), stop1, SplineMove common_D150, TaskWait 256` |
| 1 | same with `move_sq01_l` first and `move_sq01_r` second |
| **2** | `SplineMove move_sq01_dl, Speed(20, 3), TaskWait 32, laser2, stop2, Speed(60, 0.5), TaskWait 256` |
| **3** | same with `move_sq01_dr` |

**Only indices 2 and 3 are used in BG06.** Indices 0/1 loop the r/l pair 3× (Loop count 2 → body 3×), firing `sq01_fire1_sel` before each.

Routes. The stage JSON does not contain them; read them from `Assets/OriginalRecovered/InGame/RouteLUT/<name>.asset`. They are copied in stage-JSON route format to `routes.json`:

| route | LUT points | polyline length | end point |
|---|---|---|---|
| common_D50 | 2 | 50 | (0,0,−50) |
| move_sq01_r / _l | 2 | 100.125 | (±100,0,−5) |
| **move_sq01_dl / _dr** | 72 | **388.614** | (∓300,0,−200); first bends to x ±4.78 at z −30, then sweeps out |
| common_D150 | 2 | 150 | (0,0,−150) |

## 4. Per-frame behaviour (index 2; index 3 is the mirror image in x)

Native frame order (air spec header): Speed tasks (EarlyUpdate), then the SplineMove step (LastUpdate), then the stack (LateUpdate). Everything starts in frame 0.

```
frame 0:  SplineMove(move_sq01_dl) starts: _splineRootPosition = spawn; distance d = 0; MovingTask 256 set
          Speed(20,3): ramp _currentSpeed 30 -> 20 linearly over 3.0 s (SpeedTask 32), first step this frame
          TaskWait 32: stack waits
per frame: d += dt * _currentSpeed;  u = clamp01(d / 388.614)
          pos = spawn + LUT(Easing01(u, 7))        // EaseInOutSine of the DISTANCE fraction, route not rotated
          localRotation = _firstRotate(yaw 180) * Euler(0,0, roll)        // DriftS, §5
t = 3.017: speed ramp ends (20) -> TaskWait 32 clears -> laser2 (BSelector sq01_fire2_sel, self-direction) -> stop2 Idle 2 s
t = 5.033: Speed(60, 0.5): 20 -> 60 over 0.5 s;  TaskWait 256: waits for the spline
t = 9.733: u reaches 1 at (spawn.x − 300, spawn.z − 200); MovingTask clears; idx = count
          rule 2 (events exhausted, no 0x214 task, outside gameScreenAreas[Small]) -> EndRoute that frame
```

- Speed is not constant along the path: 30→20 over the first 3 s, then 20 until 5.03 s, then 60.
- The ease is applied to the whole route's distance fraction, so the enemy also accelerates and decelerates within the route.
- No player-relative logic and no randomness: `moveSpeedRange` 0, and BSelector only aims the shot (`isSelfDir`).
- There is no area-exit while on the spline (moveType 6). Removal is by rule 2 at the route end, (−280, −100) for the 328 s spawn, which is well outside the screen.

## 5. Facing: lookAt 30 (DriftS)

The yaw stays 180, the placement value: `_firstRotate` is captured at SplineMove start.

Every SplineMove frame, `_getRotate` 0x1CDC830 calls `_AddDriftAngle(xsub, 0.2, dt)` 0x1CDB930, with `xsub = LUT(spRate + (r1−r0)).x − LUT(spRate).x` (raw-progress step ahead) [I: as the Md01 skill]. The function:

```
k = lookAt − 30 = 0;  g = xsub * _DriftSpeed[k]                 // _DriftSpeed = {3, 2, 1}  (.cctor 0x1CDBD00)
if |g| < 0.2: back = dt * _DriftBackSpeed[k]                    // {180, 90, 45}
              roll = (back >= |roll|) ? 0 : roll − sign(roll)*back
else:         roll += (g*roll < 0) ? 2g : 0.25g
roll = clamp(roll, −100, 100)
return Euler(0, 0, roll/100 * _DriftArcs[k])                     // {45, 30, 20}: DriftS banks up to 45 deg
```

In the sim the roll stays near 0 for the first 3.5 s. It then banks to −7° by 5 s and reaches the −45° limit at 7.4 s (`sims/sq01_BG06_idx2.txt`, last column).

## 6. Simulated path (`m7_sim.py sq01`): BG06 t = 328 s spawn, clip (+20,0,0), index 2

| t | x | z | speed | bank° | note |
|---|---|---|---|---|---|
| 0 | 20.00 | 100.00 | 30 | 0 | spawn (above the screen, top edge z 91.7) |
| 0.5 | 20.15 | 98.67 | 28.33 | 0 | |
| 1.0 | 20.92 | 95.04 | 26.67 | 1.0 | |
| 1.5 | 22.18 | 89.55 | 25.00 | 2.0 | on screen |
| 2.0 | 23.56 | 82.63 | 23.33 | 2.8 | |
| 2.5 | 24.57 | 74.61 | 21.67 | 0 | |
| 3.0 | 24.63 | 65.89 | 20.00 | 0 | 3.017: fire2 selector, Idle 2 |
| 4.0 | 18.26 | 47.50 | 20 | −2.0 | |
| 5.0 | 0.93 | 31.66 | 20 | −6.9 | 5.033: speed → 60 over 0.5 s |
| 6.0 | −58.69 | −3.16 | 60 | −21.2 | |
| 7.0 | −143.37 | −42.48 | 60 | −39.6 | leaves left edge (x −163) at about 7.25 s |
| 9.733 | −280.00 | −100.00 | 60 | −39.6 | spline done → EndRoute (rule 2) |

The index-3 run (`sims/sq01_BG06_idx3.txt`, clip −20) is the exact x-mirror: it ends at (+280, −100).

## 7. Reconstruction notes (per-model hook)

- In `Round1EventStack`, `Pf_Ene_Sq01` needs a **program hook before construction**: if `model == Pf_Ene_Sq01`, replace `d.events` with `program[indexValue]` from §3 and add the five LUT routes (`routes.json`). Nothing per frame.
- `Applies()` currently rejects empty-event definitions and only accepts programs with some non-RouteProgram event. Sq01's program types {15,80,5,20,83,101,14} include 5/20/101, so it would apply once the events are injected.
- `Ease(7)`: native InOutSine01 0x1DE86F0 uses the 0.1° `Cosf` table, `(1 − Cosf(180·t)) / 2` evaluated per half [I: within 4e-4 of the exact formula].
- The drift roll (§5) is visual only. It is optional for paths and needed for appearance.

## 8. Open questions

- `[?]` The spline length natively comes from the Unity Spline (`InGameRouteManager` data +0x18). The sims use the LUT polyline length (388.614 for dl/dr); the true Bezier length may differ by a fraction of a unit.
- `[?]` `_isExecStackEvent` also calls `_AddDriftAngle(0, 0.2, dt)` while the stack waits (Idle/TaskWait), in the same frame as the spline's own call, so the roll may decay faster during waits. Not modelled.
- `[?]` The `indexValue` 0/1 programs are unused in the shipped BG06 timeline; checked only by decoding.
