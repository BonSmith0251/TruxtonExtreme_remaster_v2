# Ene_Mc01 (Pf_Ene_Mc01): native movement spec

This is a read-only study of `GameAssembly.dll`.

| Where | What |
|---|---|
| `dis/all_methods.txt` | the class |
| `dis/SplineMover_*.txt`, `dis/EnemyMover_*.txt` | the route-mode mover it relies on |
| `mc01_sim.py` | the model |
| `sims/` | model output |

Coordinates are on the sky plane: x right, z up, y toward the camera. `[I]` marks an inference and `[?]` an unknown.

## 0. Summary

**Ene_Mc01 does not move itself.** No method writes a position or rotation. It changes three things:
- **fire:** it adds its own continuous fire timer;
- **animation:** it plays an "open"/"close" Animator cycle;
- **Bullet events:** it replaces the mover's bullet-fire delegate.

All motion comes from the `SplineMover` **route-chain mode**:
- All Mc01 definitions have `attribute` 0. Bit 16 is clear, so `_isEventStackPlay` is false (`EnemyMover.CreateRouteData` 0x1D6C750).
- They have a list of `routes` (common_D200, common_L50, …).
- `EnemyMover.Progress` (0x1D6CB50) then runs only `SplineMover.Progress` (0x1D43DF0).
- The definition `events` are **route events**, keyed by `awakeRate` = route index + offset. They are not stack events.

## 1. Fields

### Statics (`.cctor` 0x1DC1960)

| Static | Value |
|---|---|
| FireTime | 0.4 |
| AnimationTime | 0.75 |
| AnimationLoopTime | 0.75 (copied from AnimationTime) |
| NoDamageTime | 1.2 |
| NoDamageDuration | 0.4 |

### Prefab

- `_bulletData`:
  - `mc01_fire1`, Time 0, `_muzzle` muzzle01 (local (0, 3.552, 7.171) under the model top);
  - `mc01_fire2`, Time 0.04, `_muzzle` muzzle02 (local (0, 8.092, −2.431)).
- `_HitPoint` 200, `_deadExplosion` pf_eff_explposion02, `_overplayDeadSound` 202.
- Mover `_lookAtUpdateSec` 0.

### Placement (all 10 definitions, BG07 ×8 and BG08 ×2)

- moveSpeed 50, range 0;
- rotate y 180, which becomes `_firstRotate`;
- `easeType` 7 (EaseInOutSine);
- `lookAt` 30 (DriftS);
- duration 0.

## 2. Class code

### Initialize (0x1DC12B0)

```
PawnEnemy.Initialize()
mover._bulletFire = _onBulletFire        // replaces the default FireByRouteEvent delegate (+0x1E0)
```

`InitializeToPlay` (0x1DC1160) caches the BulletTemplate for each `_bulletData`, then calls `PawnEnemy.InitializeToPlay()`. `Terminate` calls `mover.ResetBulletFire()`.

### ReStart (0x1DC1830)

```
PawnEnemy.ReStart(withPlay); CreateToken()
_timer = 0
_openAnimationHash = Animator.StringToHash("open"); _closeAnimationHash = StringToHash("close")
mover.DelayAnimationTask(open, CToken, delay 0).Forget()
```

### `_onBulletFire(ct, ev)` (0x1DC1A50)

This is called by the mover for a Bullet event. The event's own fields are **ignored**.

```
if !IsGameStop:
    for each bd in _bulletData:
        mover.BulletFireAsyncDelayed(bd.Time, ct, bd._bt, false, false, bd._muzzle, null, 0).Forget()
```

None of the Mc01 definitions has a Bullet (5) event, so in practice this path is not used.

### LocalLateUpdate (0x1DC1350)

```
PawnEnemy.LocalLateUpdate(dt)                          // FIRST: in-area flag + mover (route progress)
if IsGameStop: return
prev = _timer; _timer += InGameManager.DeltaTime
if prev <= 0.4 < _timer:  fire every _bulletData (mc01_fire1 at +0 s, mc01_fire2 at +0.04 s), CToken
if prev <= 1.2 < _timer:  _nodamagedTime = 0.4
if prev <= 0.75 < _timer: DelayAnimationTask("close", 0)
if prev <= 0.75 < _timer: _timer = clamp(_timer − floor(_timer/0.75)·0.75, 0, 0.75)   // Mathf.Repeat; 0x578740 = floorf [I]
                          DelayAnimationTask("open", 0)
```

Consequences:
- The cycle is 0.75 s. The model opens at 0, fires at 0.4, and closes at 0.75; the "open" call follows in the same frame.
- **The pair of shots repeats every 0.75 s for the whole life**, with no area or player test in this class. Any gating would be inside `BulletFireAsync` `[?]`.
- `NoDamageTime 1.2` can never be reached, because `_timer` wraps at 0.75. The `_nodamagedTime` write is dead code with these constants [I].
- The timer runs while the mover is paused.

## 3. The mover in route mode (what actually moves Mc01)

### `SplineMover._ProgressSpline(dt)` (0x1D44AE0)

This runs every LateUpdate inside `PawnEnemy.LocalLateUpdate`.

```
if IsPausing (moverState 4): (drift lookAt only: _AddDriftAngle + rotation) return
if dt <= 0 or !IsPlaying: return
_durationPassTime += dt
if IsSplineMove (state != 4 and _splineLength > 0): _currentRate += dt·_currentSpeed/_splineLength
else: _currentRate = duration > 0 ? pass/duration : 1
if _currentRate < 1: off = Easing01(_currentRate, _easingType)       // EaseInOutSine for EVERY route of the chain
else: _currentRate = 1; off = 1; done
UpdateEvent(prevOff, off − prevOff)                                   // route events, below
_splineCurrentPosition = EvalCachedPosition(spline, off) − _splineStartPosition
(lookAt rotation every _lookAtUpdateSec)
if done:
    if routes and _routesIndex + 1 < max:
        if _nextEasingType != −1: _easingType = it
        _routesIndex++; _startPosition = transform.localPosition (the position from the previous frame)
        updateRouteData(0): SetSpline(next) resets _splineCurrentPosition = 0 and _splineStartPosition = knot0;
                            _currentRate = 0; _durationPassTime = 0; _currentOffset = 0
    else: _isEndRouteKeep ? moverState = 4 : EndRoute()
```

`SplineMover.Progress` then sets:
- `localPosition = _routeRotate · _splineCurrentPosition + _startPosition` (`_routeRotate` is a Matrix4x4 from the ctor; identity [I]);
- `localRotation = _firstRotate · _splineRotate`.

So each route is a relative leg that starts where the last one ended. Its duration is `length/speed` and it is eased InOutSine. The leftover distance is dropped, and the transition frame holds position for one frame.

### Route events (`SplineMover.UpdateEvent` 0x1D44720; `EnemyMover.UpdateEvent` forwards only when not in stack mode)

```
lo = prevOff + _routesIndex; hi = lo + delta (delta > 0 only); if _eventLastRate >= hi: skip
for events from _eventIndex (sorted by awakeRate):
    awakeRate < lo → skip; awakeRate < hi → ExecEvent(ev, RouteToken); else stop
```

Mc01 events are type 1 Delay, with `value0` 0, `dotime` 2 at awakeRate 8 and `dotime` 0.35 at awakeRate 3. Following the ground spec §1 `_delayPlayPause`, each one:
- **pauses the mover for `dotime`** (moverState 4);
- fires on the first frame of route 3 or route 8.

The `stringValue` `mc01_fire1` and `nameValue` muzzle are not used by type 1 [I].

### End

The last route finishes, and `EndRoute` is called because `_isEndRouteKeep` is false. The air stack end rules do not apply. Any camera/area cull outside the mover is `[?]`.

## 4. Simulated path

BG07 `ene_mc01_1aA`, spawned at (0, 0, 165), speed 50. Routes: D200, L50, U10, U100, R100, D100, L100, U100, U200. Output in `sims/mc01_1aA_BG07.txt`.

| Time (s) | What happens |
|---|---|
| 0 | spawn at (0, 165); eased InOutSine D200 (4 s) |
| 0.5 / 1.0 / 1.5 / 2.0 / 2.5 / 3.0 | z 157.5 / 135.8 / 103.3 / 65.0 / 26.7 / −5.8 (enters the top edge z = 91.7 at about 1.65 s) |
| 4.00 | at (0, −35); L50 to x −50 (1 s), then U10 (0.2 s) |
| 5.20 | U100 starts at (−50, −25.2); the awake 3 event pauses 0.35 s |
| 7.57 | at z 74.8; R100 (2 s) |
| 9.58 | D100 |
| 11.60 | L100 |
| 13.62 | U100 |
| 15.63 | at (−50, 74.8); U200 starts; the awake 8 event pauses 2.0 s (hovering at the top) |
| 17.6 → 21.67 | leaves up; EndRoute at z 274.8 |

Shots: `mc01_fire1` + `mc01_fire2` at 0.400, 1.133, 1.883 … s, then every 0.75 s: 29 pairs before removal. The first gap is 0.733 s because the Repeat wrap keeps the remainder of the frame that overshot.

Facing: `_firstRotate` is yaw 180 (nose down) times `_splineRotate` from lookAt DriftS (30), which is a drift sway, not path-following `[?]`: `_getRotate`/`_AddDriftAngle` were not traced.

## 5. For the C# host

- Mc01 needs a route-chain mover, not an event-stack hook:
  - one leg per route name, InOutSine per leg, at moveSpeed;
  - route Delay events (awakeRate = leg index + eased offset) pause motion for `dotime`;
  - EndRoute after the last leg.
- The per-model hook only adds the 0.75 s fire/animation cycle after the mover step.
- No position code is needed in the hook.

## 6. Open questions

- `[?]` Whether `BulletFireAsync` gates the every-0.75 s pair (screen position, rank, game stop). The class itself fires from spawn, off screen too.
- `[?]` `EvalCachedPosition` LUT vs knot `times`. The sim interpolates linearly over the knot times; D200/U200 have dense non-uniform knots, so expect an error under 1 unit [I].
- `[?]` The DriftS (lookAt 30) rotation law (`InGameEnemyMoveBase._AddDriftAngle`, `_getRotate`).
- `[?]` The `_routeRotate` matrix: assumed identity (ctor). `SetRouteMatrix` has no direct callers.
- `[?]` The `_delayPlayPause` start: `value0` 0 is taken as a pause from the event frame (±1 frame).
