# Native air-enemy route events (EnemyMover event stack, sky plane)

Read-only study of `GameAssembly.dll` (IL2CPP x64), continuing `../ground-route-events/SPEC.md` (read that first: §1 stack interpreter, §2 repeat wrapper, 1/2/5/10/11/12/13/20/80/101/1000/1001 are not repeated here unless air differs).

- Tools: `../ground-route-events/tools/{rdis.py,callers.py}` for disassembly, `tools/air_sim.py` (new, frame-stepped model of everything below). Disassembly excerpts: `dis/`. The event case bodies are in `../ground-route-events/dis/execEventWithRepeat_MoveNext.txt` and `moveTypeUpdateAsync_MoveNext.txt`.
- Simulator outputs: `sims/*.txt` and machine-readable `sims/*.json` (60 fps, float32 counters, XorShift32 RNG shared with the C# port, player fixed at sky (0, −49) = `SinglePlayStartPosition (0,0,−50)` + `PlayerTargetOffset (0,0,1)`).
- C# port: `Reconstructed/Assets/Truxton/Round1EventStack.cs`, checked against `sims/*.json` by `Assets/Editor/ReconstructionEventStackCheck.cs` (output `verification/air-route-events/check.json`).
- `[I]` = inference, `[?]` = unknown. Everything else is read from code.

## 0. Frame, units, areas

| Item | Value | Source |
|---|---|---|
| Sky plane | x right, z up the screen, y toward the camera. Camera `(0,400,0)`, Euler(90,0,0), `_cameraTall = 400`, 20° vertical FOV, 16:9 [I: FOV/aspect from `Round1Sa01Motion`] | InGameManager .cctor 0x1CF04E0 |
| Visible size at altitude y | height `H(y) = 2·(400−y)·tan10° = 141.06` at y=0, width `H·16/9 = 250.8` | |
| Yaw | rotation about +Y; 0° = +Z (up), 90° = +X (right), 180° = down. Clip `rotate.y` = heading (e.g. Sb01 from x=−170 has yaw 90) | `GetPlaneQuaternion` 0x1DD7270 = `LookRotation(ProjectOnPlane(v, up), up)` |
| Game dt | `InGameManager._playTimeFactor` (0x28): `+0x18 _deltaTime`, `+0x1C _deltaTimeScale = dt / (1/60)` (frames per frame, 1.0 at 60 fps) | TimeFactor.Update 0x1DF2770, ApplicationUtility.targetFrameRate = 0.016666668 |
| Position used by targeting | `_inGameRoot.InverseTransformPoint(root.position)` (`GetGameRootPosition` 0x1CE4580); player = `_playerGamePosition[i]` (0x170, `GetPlayerPosition` 0x1CE5B70). Both projected on the XZ plane (y ignored). |
| Viewport rects (x, y, w, h), test `x ≤ v < x+w` | `gameScreenBulletArea (−.15,−.05,1.3,1.1)`, `gameScreenArea (−.15,−.15,1.3,1.3)`, `AreaM (−.2,−.2,1.4,1.4)`, `AreaL (−.3,−.3,1.6,1.6)`, `AreaW (−.5,−.5,2,2)`; `gameScreenAreas[] = {Area, M, L, W, W}` indexed by `EnemySize` (Small 0 … BOSS 4) | IGM .cctor |
| gameScreenArea in units (y=0) | x ∈ [−163.0, 163.0), z ∈ [−91.7, 91.7). Altitude scales it by `(400−y)/400`. | |
| Viewport of a point | `(.5 + x/(H(y)·16/9), .5 + z/H(y))` (perspective, so y matters) | Camera.WorldToViewportPoint |

Per-frame order [I: from the PlayerLoop timings the tasks yield on]: EarlyUpdate → Speed tasks; LastUpdate → move tasks (`_moveTypeUpdateAsync`), DOTween Manual rotate tweens [?: exact point]; LateUpdate → `PawnEnemy.LocalLateUpdate` (0x1D0E790): sets `mover._isInGamePlayArea`, then runs the mover (`EnemyMover.Progress` → `_execStackEvent`). A task started by the stack runs synchronously up to its first `await`, so ForwardMove/Direction/Horming/SplineMove/Speed take their first step in the start frame. Air enemies start their program at spawn: `InStartArea` (attribute 512) is only called from `PawnEnemyGround`.

## 1. Events not in the ground spec

Jump table of `_execEventWithRepeat` (0x1CF96E0, types 2..18): 3→0x1CF7029, 6→0x1CF7288, 7→0x1CF7ADA, 14→0x1CF87C4, 15→0x1CF8947; **4, 16, 17, 18 → 0x1CF7C66 (repeat tail = no body)**; 84 at 0x1CF903E. `ExecEvent` (0x1CD9D50) table 0x1CDA1EC handles 16/19/20/21 itself; 17/18 fall to the wrapper (no-op).

### Summary table

| Type | Blocks stack? | Task bit held | Fields read | Effect |
|---|---|---|---|---|
| 3 RotateT | no (use TaskWait 2) | 2 RotateT (tween only) | value0 preWait, value1 rate °/s, dotime, vectorValue (added), intValue1 snap step°, flag0 long-way, nameValue | turn (world yaw) to face the player; instant / timed / rate |
| 84 RotateR | no, instant | none | vectorValue (±range per axis), nameValue | `localEuler += U(−v, v)` per axis, once |
| 6 Horming | no (use TaskWait 512) | 512 HormingTask (waits for 256 \| 512 first) | value0 turn °/frame, randomFire (adds U·randomFire to value0), value1 homing seconds, dotime total seconds, intValue1 near radius, vectorValue start dir, flag0 target = strongest enemy | steer toward player, then straight |
| 7 Direction | no | 1024 DirectionTask | vectorValue (raw, not normalised), dotime | translate by `vectorValue·speed·dt` per frame |
| 14 Speed | no (use TaskWait 32) | 32 SpeedTask (dotime > 0 only) | value0 target speed, dotime ramp time (clamped 0..100). **intValue1 not read** | linear ramp of `_currentSpeed` (or set instantly) |
| 15 SplineMove | no (use TaskWait 256) | 256 MovingTask | stringValue route name. **dotime not read** | follow route by distance at `_currentSpeed`, eased by `_easingType` |
| 16 Easing | no | – | intValue1 (must be a defined `EasingType`) | `_nextEasingType`; consumed by the next SplineMove |
| 19 LookAt | no | – | intValue1 (defined `LookAtType`), vectorValue | `_nextLookAtType/_nextLookAtRotate`; consumed by the next SplineMove |
| 4 Scale, 17 CustomEvent, 18 GravityForwardMove | no | – | – | **nothing** in EnemyMover (wrapper body is the tail; `MoveType.GravityMove` 7 only does the area check) |
| 100 Goto | stack | – | intValue1, stringValue | `intValue1 ≥ 100` → next; else jump to label unless `intValue1 > (int)(Rand01·100)` (jump chance `(100−intValue1)%`) (stack 0x1D6D1B5) |
| 81 TaskClear | stack | – | intValue1 | `ClearTaskFlag(intValue1)` (0 clears all) — only the bits, tasks keep running (0x1D6D194, 0x1D1D970) |
| 82 TaskCancel | no | – | intValue1 | `CancelTaskToken(mask)` 0x1D1D820: **always** cancels Translate and Rotate tokens; also Animation (16), Scale (8), Horming (512), Speed (32) when the bit is set |

### 3 RotateT (wrapper 0x1CF7029 → `InGameObjectWithEvent.DelayRotate(ev, player)` 0x1D1DC60, MoveNext 0x1D26710)

```
await WaitTaskFlag(RotateTTask 2)                     // serialises RotateTs
_isDirtyTransform = true
if _targetPlayerIndex == -1: _targetPlayerIndex = GetNearestPlayerIndex(screen pos)   // chosen once per enemy
t = nameValue ? _transformCaches[nameValue] : root
d = player.gamePos − GetGameRootPosition(t.position)              // XZ
yawT = GetPlaneEuler(d).y        (0..360, 0 = +Z)                 // x,z Euler = 0 on the plane
if intValue1 > 0: yawT = MultipleRound(yawT, intValue1)           // round half away from 0
if dotime <= 0.001 and value1 <= 0:
    t.rotation = Euler(0, yawT, 0); return                        // instant, WORLD, vectorValue ignored
cur = GetPlaneEuler(t.rotation).y (rounded the same way)
rot = vectorValue + (0, Normalized(yawT − cur, −180, 180), 0)
dur = dotime
if value1 > 0:                                                    // rate mode (overrides dotime)
    ang = |rot|
    if ang < 180 and flag0: rot.y += (rot.y <= 0 ? +360 : −360); ang = 360 − ang   // go the LONG way
    dur = ang / value1
if dur <= 0: return
await _delayRotate(t, Linear, flag0 ? FastBeyond360 : Fast, RotateToken, preWait=value0, postWait=0,
                   dur, rot, isLocal=false, isAbsolute=false, setflag=RotateTTask 2)
                   // = DORotate(rot, dur).SetRelative(true).SetUpdate(Manual): world, relative, linear
```

- Target = the player's sky position at the event start, not tracked during the turn.
- Sb01 (`value1 360, flag0`): always spins the long way at 360°/s, so a turn of δ takes `(360−|δ|)/360` s; when already facing the player it does a full 360° in 1 s.
- Mn01c2 (`dotime 0, value1 0, intValue1 1, vectorValue y 360`): instant snap to the player, rounded to 1°.

### 84 RotateR (0x1CF903E)

```
_isDirtyTransform = true; t = _getTransform(nameValue); if t == null: skip
e = t.localRotation.eulerAngles
e += (Range(−v.x, v.x), Range(−v.y, v.y), Range(−v.z, v.z))       // RandomUtility.Range(min,max)
t.localRotation = Euler(e)                                        // synchronous, no task, no wait
```

Mn01c2 then has heading `yawToPlayer ± U(−5, 5)°`.

### 6 Horming (setup 0x1CF7288; per frame `_moveTypeUpdateAsync` cases 3/5 at 0x1CF9BBA)

Setup:
```
await WaitTaskFlag(MovingTask 256 | HormingTask 512)
pick _targetPlayerIndex as RotateT
_moveType = flag0 ? HormingMoveEnemy(5) : HormingMove(3)
v = GameCamera.WorldToViewportPoint(root.position)
_moveValue = v in gameScreenAreas[0] ? localRotation·lookAtVector()   // already on screen: keep current facing
                                    : vectorValue.normalized            // off screen: authored direction
updateHormingDirection()                                               // face _moveValue (below)
_moveValue0 = value0 + Rand01·randomFire        // turn step in degrees (0.1° trig table)
_homingDuration = value1;  _intValue1 = intValue1²;  _localDuration = dotime
_moveValue1 = dotime < 1 ? _moveValue0 : 0      // turn accumulator; dotime<1 gives a double turn on frame 1
_moveTypeUpdateAsync(HormingToken, HormingTask 512).Forget()
```

Per frame (moveType 3/5):
```
gp = position before this frame's step;  step = dt·_currentSpeed
_moveValue1 += _moveValue0 · _deltaTimeScale            // one step per 60 Hz frame
target = moveType 3 ? player.gamePos : (strongestCount > 1 ? player : GetStrongestMostNear(gp))
aim = (target − gp) with y = 0
if |aim|² >= _intValue1:                                 // farther than intValue1 units
    while _moveValue1 >= _moveValue0 > 0:
        _moveValue1 −= _moveValue0
        _moveValue = HomingDirection(_moveValue, aim, Sinf(_moveValue0), Cosf(_moveValue0)); updateHormingDirection()
else: _moveValue1 = 0                                    // inside the radius: no turn
pos += _moveValue·step;  _localDuration −= dt;  _homingDuration −= dt
if _homingDuration <= 0 or _moveValue0 <= 0:
    final HomingDirection with the leftover angle (≈0 at 60 fps); updateHormingDirection()
    done = _localDuration <= 0;  _moveType = HormingMoveEnd(4)
```
- `HomingDirection` (0x1DF73B0): with `a`/`b` = current turned ±step, return `normalize(aim)` if it is within one step, else whichever of `a`/`b` is closer to `aim` (`>=` favours `a`). This is exactly `Round1Sa01Motion.Turn`. When the target is straight behind (an enemy that flew through the player), `a` and `b` tie and native float noise decides. The model and the C# port treat a 1e-4 relative near-tie as a tie and pick `a`. RotateT likewise treats \|δ\| < 1e-3° as 0, so a long-way spin when already facing is always +360°.
- `Sinf/Cosf` (0x1DF8A70/0x1DF6FA0) use a 3600-entry table: angle is truncated to 0.1°.
- **Time:** it turns for `value1` s (Sg01: 0.5°/frame → 30°/s for 5 s; Sc01: 8°/frame for 0.25 s). Then it flies straight (moveType 4: `pos += _moveValue·step`, no turning) until the remaining `dotime` runs out. If `dotime < value1` the move only ends when homing ends.
- **Speed:** `_currentSpeed`, the placement speed (Sg01: modified by `Ene_Sg01`, §4).
- **Facing:** `updateHormingDirection` (0x1CDD620). lookAt 0 → `localRotation = _firstRotate`; lookAt 1 → `localRotation = GetPlaneQuaternion(_moveValue)` (nose along travel); other → `_firstRotate · GetPlaneQuaternion(−_moveValue)`.

### 7 Direction (0x1CF7ADA)

```
await WaitTaskFlag(DirectionTask 1024)
_moveType = DirectionMove(2); _moveValue = vectorValue (RAW: |(−1,0,−1)| = 1.414); _localDuration = dotime
_moveTypeUpdateAsync(TranslateToken, 1024)                // same per-frame code as ForwardMove
```
- No facing change.
- `dotime 0` (Sm01) means one frame: the first step is taken, then `_localDuration = −dt ≤ 0` ends it. Sm01 is then moved by `Ene_Sm01` (§4).

### 14 Speed (0x1CF87C4; `_changeSpeedAsync` 0x1CDC060, MoveNext 0x1CF6090)

```
await WaitTaskFlag(SpeedTask 32)
if dotime <= 0: _currentSpeed = value0; return
SetTaskFlag(32); T = clamp(dotime, 0, 100); tp = 0; b = _currentSpeed; r = value0
while !IsCleared() and !cancel and T > tp:
    if running: tp += dt; _currentSpeed = b + (r − b)·clamp01(tp/T)       // first step in the start frame
    await Yield(EarlyUpdate)
ClearTaskFlag(32)
```
Every mover reads `_currentSpeed` each frame, so a ramp also slows a ForwardMove that is already running (Sp01, Sv01).

### 15 SplineMove (0x1CF8947; per frame case 6 at 0x1CF9F29)

```
data = InGameRouteManager.GetData(stringValue); if null: skip
await WaitTaskFlag(256)
SetSpline(data)                                   // virtual 0x2F8
_moveType = SplineMove(6)
if _nextLookAtType == 0: SetRotate(localRotation, 0)
else { if drift or RollForward: _rollAngle = 0; _lookAtType = _nextLookAtType; SetRotate(Euler(_nextLookAtRotate)); _nextLookAtType = 0 }
if _nextEasingType != −1: _easingType = _nextEasingType; _nextEasingType = −1
_localDuration = 0 (distance); _spRate = 0
_splineRootPosition = localPosition − _splineStartPosition
_moveTypeUpdateAsync(TranslateToken, 256)
per frame (if step > 0):
  r0 = clamp01(dist/len); dist += step; r1 = clamp01(dist/len)
  _spRate = Easing01(r1, _easingType)                        // placement easeType (Sb01ent: 7 EaseInOutSine)
  lp = _splineRootPosition + EvalCachedPosition(spline, _spRate)   // route NOT rotated by the clip
  if r1 >= 1: done                                           // ends exactly on the last point
  else localRotation = _firstRotate · _getRotate(spline, _spRate, r1−r0, dt)   // lookAt 0 → identity
```
- The area-exit rule is not applied (moveType 6). `isEntryedArea` is still updated.
- `Round1RouteProgram` already does this, except for the easing.

### 16 Easing, 19 LookAt

These are set in `ExecEvent` and do nothing until the next SplineMove. A value that is not a defined enum is ignored (`Enum.IsDefined`).

## 2. Events 1, 2, 12, 13 for air enemies — what differs from ground

The code is the same (`EnemyMover`, no air subclass); only the environment differs.

| Topic | Air | Source |
|---|---|---|
| Model forward | **local +Z** for every air prefab checked: identity node rotations; nose and muzzle at +Z, burner at −Z (Sb01 muzzle z +8.05 / burner −6.6, Sp01 +4.9, Sv01 +6.12, Sc01 +5.55, Sg01 burner −6.7) | prefabs |
| ForwardMove axis | `Matrix4x4.Rotate(root.localRotation) · (lookAt==Back ? −Z : +Z)`, snapshot at start, yaw about +Y, as on the ground | 0x1CF803B |
| Rotate (2) | local (`DOLocalRotate`), relative unless flag0, InOutSine if intValue1≠0; instant absolute if dotime ≤ 0.001; preWait value0, postWait value1 | ground §3 |
| RotateT | **world** (`DORotate`), always relative, linear | §1 |
| Placement rotate | `UpdateObjectData` (0x1D44890) → `SetRotate(Euler(placement.rotate))` sets `_firstRotate` (0x170) only. Wave spawn (`EnemyWaveBehaviour._callEnmey` 0x1D35C30) with a non-zero clip rotate: `_firstRotate = clipQ · _firstRotate` [I: order; yaw-only commutes]. `SplineMover.StartRoute` (0x1D44600) sets `root.localRotation = _firstRotate`. Heading = placement.rotate.y + clip.rotate.y. |
| `_currentSpeed` | `clamp(moveSpeed + Rand01·_moveSpeedRange + speedStep, 0.0001, 999)`. `RandomUtility.Range(r)` (0x1DF1700) is **U[0, r)**, not ±r. | 0x1D44890 |
| `_lookAtType` / `_easingType` | `placement.lookAt` / `placement.easeType`. lookAt Forward does **not** re-aim the nose every frame for stack movers: only Horming, SplineMove and the rotate events change rotation. With ForwardMove the nose already points along travel, except during a concurrent Rotate (Sv01 turns lead travel by one step) and for lookAt 0 enemies turned by RotateT (Sb01 spins). |
| Altitude | Clip/definition y is kept (Sb01ent y 101 → 1 along its spline, Mn01 25, Sp01 −20/+30). Targeting ignores y; area tests use perspective (y matters). |
| Area tests | `_masterEnemy` (set by `SetDivision`) `_sizeType ≤ Medium` → `IsGameArea` (gameScreenArea); else `IsGameWideArea` (±0.5). `_sizeType` is not serialized in the prefabs [I: Small for these fighters, matching the Sa01 recording]. |

## 3. How an air enemy ends

1. **Area exit while moving.** In `_moveTypeUpdateAsync`, each frame, using the position before the step (`gp`):
   - if `isEntryedArea` and `!IsGameArea(gp)` and moveType ∈ {2 Direction/ForwardMove, 3 Horming, 4 HormingEnd} → `EndRoute` (vslot 0x278).
   - otherwise `isEntryedArea = IsGameArea(gp)`.

   `isEntryedArea` (0xD0) is per mover and kept across moves. SplineMove (6) and standing still never trigger this.
2. **Events run out.** At the end of every `_execStackEvent`: `idx ≥ count && !(taskFlag & 0x214) && !_isInGamePlayArea` → EndRoute. `_isInGamePlayArea` (0x291) is set each LateUpdate by `IsInGameAreaWorld(pos, gameScreenAreas[_sizeType])` (0x1CE7D40).
   - Entering is **not** required. An enemy whose last event is a ForwardMove (no TaskWait after it) is removed the frame its program runs out if it is outside its area (Sb01, Sc01: they end on this rule at the area edge, one frame before rule 1).
   - MovingTask 256 is not in 0x214, so a running ForwardMove does not keep it alive.
3. **FinishDestroy (1000).** EndRoute at once when no EndCheck task (4 \| 16 \| 512) is set, else idx = count and rule 2. value0/intValue1 are not read (Mn01c2 has intValue1 256: ignored).
4. **FinishWait (1001).** `_isFinishDelay` makes `_isExecStackEvent` false, so neither the stack nor rule 2 runs again. Only rule 1 for a move still running, or pawn code (Ene_Sm01), ends it.
5. **`EnemyData.duration` is not a limit for stack-only movers.** `_durationTime` is read only in `SplineMover._ProgressSpline`, which runs only when `IsSplineRoute()` (`_routes.Length > 0`, 0x1D43D60). The routes of these definitions are empty.
6. Kill / pawn-specific removal (§4).

## 4. Pawn classes on these prefabs (they change motion)

| Prefab | Pawn class | Effect |
|---|---|---|
| Sb01, Sc01, Sp01 | PawnEnemy | none |
| **Sg01** | PawnEnemy + **Ene_Sg01** (`Progress` 0x1CFEBD0, consts 0x1CFEE20) | Every frame [I]: while Horming (moveType 3/5), `_currentSpeed = 10 + 60·clamp((int)screenDist, 50, 600)/600`, where `screenDist` = distance to the nearest player in screen pixels (`viewport × _ScreenSize`, x aspect-corrected) [?: `_ScreenSize` is runtime; with 1080 px height, 1 unit = 7.66 px at y=0]. In a later DirectionMove (ForwardMove) after homing, `speed = max(speed, 20)`. Placement speed 40 is replaced from the first homing frame. |
| **Sm01** | **Ene_Sm01** (`_progressMove` 0x1D02B30; `_LifeTime 10`, `_relectRandom 15`) | First frame: `dir = (cos a, 0, sin a)·_currentSpeed`, `a = ±135° + 90° + U(−15, 15)°` (down-left or down-right). Each frame `pos += dir·dt` and the model spins. Not entered within 5 s → removed. After entering (`_isInGamePlayArea`), for 10 s it reflects off viewport 0/1 edges, then leaves; once outside its play area it is removed (vslot 0x308). Sm01 overlap reflection (`Reflect`) was not traced [?]. |
| Sv01 | **Ene_Sj01** (0x1D015A0) | Inert normally: `ReStart` sets `_timeLimit = 999`. `CommonEvent(2)` (parent died) → 2 s, `CommonEvent(1)` → at once: pause the mover and fly away waving until outside IsGameArea. |
| Mn01c2 | **Ene_Mn01c** (ReStart 0x1CFA6B0) | `_state = FREE` (no motion code) when the pawn's spawn index (+0x94) is 0. Otherwise `FALL` with `_spinRate = 2·index`, where `_shieldModeState` writes local position/rotation each frame [?: whether this overrides the program for BG06/BG08 bits with indexValue 2]. |

## 5. Model output (`tools/air_sim.py`, 60 fps; full tracks in `sims/`)

Player at (0, −49). Timing is ±1 frame (float32 counters, Manual-tween order). Positions are sky (x, y, z).

| Program (clip) | Speed | Result |
|---|---|---|
| **Sb01** BG02 (−170,0,−60), yaw 90 | 80 | FM 0.75 s: x −170 → −108.7 (46 steps). RotateT spins +354.2° over 0.984 s to 84.2° (Bullet `sb01_fire` at 1.15 s). FM 0.75 s toward the player → (−47.7, −53.8) at 2.50 s. RotateT +360° over 1.00 s (Bullet at 2.90 s). FM 20 s from 3.52 s along 84.2°. Removed at 6.15 s at (163.3, −32.5) by rule 2. |
| **Sb01ent_ur** BG04 (35,1,35), yaw 225 | 80, easeType 7 | Spline (105,101,105) → (35,1,35): length 141.4, 1.75 s, EaseInOutSine (t 0.5 → (91.9, 82.4, 91.9); 1.0 → (62.5, 40.3, 62.5)). Bullet at 2.15 s. RotateT +337.6° over 0.94 s → 202.6°. FM 0.75 → (11.4, −21.6) at 3.45 s. RotateT +360° over 1 s. FM 0.75 → (−12.2, −78.2) at 5.22 s. FM 20 s. Removed at 5.38 s at z −91.8. |
| **Sc01** BG07 (−40,0,100), yaw 180 | 125 | FM 0.5 s → (−40, 37.5) at 0.483 s. Horming #1 (8°/frame, 0.25 s, near 5): snaps to the player bearing 155.0° within one frame, then straight → (0.2, −49.5) at 1.233 s. Horming #2: passes within 5 units (no turn); with the player straight behind, the a/b turns tie and the model picks `a` (turn left, see note) → 51.0°, (74.7, −19.4) at 1.983 s. Horming #3 → 275.0°. FM 10 s from 2.733 s, leaves the left edge at 4.05 s at (−165.0, 24.7). |
| **Sg01** BG02 (−120,0,0), placement yaw 180 | 40, Ene_Sg01 | Off screen at spawn, so start direction is (0,0,−1). Turns 0.5°/frame: yaw 172.5 at 0.25 s, 165 at 0.5, 150 at 1.0, 135 at 1.5, then holds on the player (122.7°). Speed 70 while the player is ≥ 600 px away, then falls (59.6 at 2.0 s, 27.6 at 3.0, 15 at 4.0). Homing ends at 4.98 s at (10.5, −55.8). FM at ≥ 20 u/s, leaves the bottom at 8.32 s at (66.9, −92.0). |
| **Sp01** BG07 (0,0,0), yaw 180 | 100 | FM 1.5 s z 230 → 78.3 (91 steps). Speed → 0 over 0.25 s while FM 0.25 → z 66.7 at 1.75 s (y −20, on screen). Bullet `sp01_fire1` at 1.75 s. Idle 2 s. Speed → 250 over 0.25 s + FM 30 s from 3.77 s (z 37.5 at 4.0 s, −62.5 at 4.4 s). Area exit at 4.55 s, z −104 (the y=−20 area is larger). |
| **Sv01** BG02 (−76,0,180), yaw 135 | 120 | FM 1 s → (10.3, 93.7). Speed → 0 over 0.5 s + FM 0.5 → (30.8, 73.2) at 1.5 s. Bullet at 1.50 and 3.52 s (Loop ×1, Idle 2). At 5.53 s: Speed → 240 over 0.5 s, then 10 × (Rotate +18° over 0.01 s InOutSine, FM 0.01 = one step at the pre-turn heading), one iteration per frame. U-turn 135° → 315° by 5.70 s at (25.8, 71.0), speed 88. FM 10 s. Area exit at 5.92 s at (2.7, 94.1). |
| **Mn01c2** BG06 (80,0,0) → spawn (40,25,120) | 240 | RotateT instant 193° (rounded to 1°), RotateR (XorShift32 seed 1) → 196.9°. FM 10 s: (33.0, 97.0) at 0.1 s, (5.1, 5.2) at 0.5 s. Area exit at 0.90 s at (−24.0, −90.5). TaskWait/FinishDestroy are never reached. |
| **Sm01_1a** BG04 (0,0,0), seed 3 | 30 + U[0,10) = 33.17 | Direction (−1,0,−1) for one frame, FinishWait at frame 0. Ene_Sm01 drifts down-left, bounces (floor at 5.72 s, z −70.8; left wall at 7.05 s, x −125.6) until 10 s after entering, then leaves the top (z 91.8 at 11.53 s). |

## 6. Differences from the reconstruction (`Round1EnemyWaves`, `Round1RouteProgram`, `Round1Sa01Motion`, `Round1EnemyAnimation`)

1. **Generic fallback** (`Position()` with no routes): straight `origin + direction·speed·age`, where `direction` = the first Horming `vectorValue` or the placement+clip yaw. It ignores:
   - every stop and Speed ramp (Sp01 and Sv01 hover for 2–4 s natively);
   - the RotateT turns toward the player (Sb01 aims twice) and Loops;
   - Horming steering for everything except Sa01;
   - the Sv01 U-turn, Mn01c2 aiming and Sm01 bouncing.
2. **Round1RouteProgram** applies only to programs with more than one SplineMove made only of {1,2,8,10,11,14,15,80,83}. Sb01ent (one SplineMove, plus 3/5/12/101) falls back to case 1: its spline is followed with no easing, then extended by the route tangent instead of RotateT and ForwardMove toward the player. The program also omits `Easing01(_easingType)`.
3. **Round1Sa01Motion** matches HomingDirection, the 0.1° table and the near radius. Missing:
   - the start rule (on screen → keep current facing; only off screen does it use `vectorValue`);
   - the double first-frame turn when `dotime < 1`;
   - `randomFire` added to the turn rate;
   - Ene_Sg01's distance-driven speed;
   - Loops of Horming (Sc01 homes 3×).
4. **Facing** (`Round1EnemyAnimation.Sample`): lookAt 1..6 follows the path tangent every frame, and lookAt 0 keeps the entry yaw. Natively, Sb01 (lookAt 0) turns its nose with RotateT (a 1 s long-way spin, then points at the player). Horming enemies face `_moveValue` exactly. lookAt Back etc. use `_firstRotate · Plane(−v)` only inside Horming.
5. **Lifetime:** reconstruction culls at `definition.duration` (Sb01 60 s). Native: no duration limit for stack movers (§3.5).
6. **Exit:**
   - Reconstruction: `entered && outside ±0.25` viewport (±0.15 + 2 frames for Sa01/programs).
   - Native: ±0.15 (gameScreenArea, Small) on the pre-step position, only while ForwardMove/Direction/Horming runs.
   - Plus rule 2: remove when events are exhausted and the enemy is outside, entered or not.
   - Altitude changes the area (perspective).
7. **Speed:** reconstruction `max(1, moveSpeed + speedDelta + U·range)`; native clamps to [0.0001, 999] (a Speed 0 stop is legal).

## 7. What the interpreter must do (checklist)

1. **Per-enemy state:**
   - `pos` (sky x, y, z) and `yaw`; `_firstRotate` = placement.rotate.y + clip.rotate.y;
   - `speed = clamp(moveSpeed + U[0,range) + speedStep, 1e-4, 999)`;
   - `lookAt` and `easeType` from the placement;
   - `taskFlag` and `objFlag`;
   - one shared `moveType` / `moveValue` / `localDuration` (a later move overwrites them);
   - `isEntryedArea`, `targetPlayer = −1`, `nextEasing = −1`, `nextLookAt = 0`, and the loop counters.
2. **Frame order:**
   - speed ramps (EarlyUpdate);
   - pawn hooks (Ene_Sg01 speed, Ene_Sm01 drift);
   - moves and rotate tweens (LastUpdate);
   - `inPlayArea = viewport(pos) ∈ gameScreenAreas[size]`;
   - stack (`_execStackEvent`, ground spec §1, plus Goto/TaskClear above).

   Every task started by the stack runs its first iteration at once. Durations are float32, `dt` comes from the game clock, and the homing turn steps scale by `dt·60`.
3. **Per event:** implement §1 exactly. RotateT: world, relative, long way with flag0, rate `value1`, snap `intValue1`, target frozen at the start. RotateR: instant ±range. Horming: the full §1 loop. Direction: raw vector. Speed: linear ramp holding bit 32. SplineMove: distance/len eased by `_easingType`, then 16/19 are consumed. 4/17/18: no-ops. 82 always cancels moves and rotations.
4. **WaitTaskFlag gates** (inside the task, not the stack):
   - ForwardMove and SplineMove wait 256;
   - Horming waits 256 | 512;
   - Direction waits 1024;
   - Speed waits 32;
   - RotateT waits 2.

   Rotate (2) does not wait.
5. **Area exit:** during moveType 2/3/4, after the enemy has entered, a pre-step position outside gameScreenArea (Small/Medium) or ±0.5 (others) → remove.
6. **End of program:** idx past the end, no 4/16/512 tasks, and outside the play area → remove (entering not required). FinishDestroy as ground. FinishWait freezes the stack. Never use `duration`.
7. **Pawn hooks:** Ene_Sg01 speed law; Ene_Sm01 drift/bounce/lifetime; Ene_Sj01 inert unless a CommonEvent arrives; Mn01c FALL state [?].
8. Check against `sims/*.txt`: same program, clip and player → same frames ±1.

## 8. Open questions

- `[?]` The pixel scale for Ene_Sg01 (`ApplicationUtility._ScreenSize` is runtime). The sims assume 1080 px height.
- `[?]` Whether `_sizeType` is Small for all of these (not serialized; the Sa01 recording behaves Small).
- `[?]` The exact update point of DOTween Manual tweens relative to LastUpdate/LateUpdate (±1 frame on RotateT/Rotate ends).
- `[?]` Whether a ForwardMove released from a busy `WaitTaskFlag` (Update timing) takes two steps in its first frame.
- `[?]` What the Ene_Mn01c FALL state (`indexValue ≠ 0`) does to the root, and Ene_Sm01 `Reflect` between bodies.
- `[I]` The wave clip rotation is composed as `clipQ · placementQ` (only yaw is used here, where the order does not matter).
- `[?]` Whether a cancelled `_delayRotate` (TaskCancel) clears RotateTask bits. It probably goes through the tween Kill path; not traced.
