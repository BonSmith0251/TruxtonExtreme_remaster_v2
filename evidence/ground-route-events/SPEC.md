# Native ground-enemy route events (EnemyMover event stack)

Read-only study of `GameAssembly.dll` (IL2CPP x64). The RVAs are from `code/methods.jsonl`. The annotated disassembly is in `dis/`, and the tools are in `tools/`:

- `rdis.py`: annotated disassembly. It reuses `bosses/Bos08/tools/il2.py` and `fields.py`.
- `callers.py`: finds direct callers of a function.
- `script_fileid.py`: maps a prefab `m_Script` fileID to its class.
- `stack_sim.py`: a frame-stepped model of everything below.

`[I]` marks an inference and `[?]` marks an unknown. Everything else is read from the code.

## 0. Who runs what

| Piece | RVA | Behaviour |
|---|---|---|
| `EnemyMover.CreateRouteData` | 0x1D6C750 | `attribute & 16` (EventStack) turns on `_isEventStackPlay` (0x294). `attribute & 512` (InAreaStart) sets `_inAreaStart` (0x293). All the example programs (attribute 16 or 528) run in **stack mode**. |
| `SplineMover.SetEventData` | 0x1D44240 | In stack mode it copies the events into `_eventDatas` in their original order, so the indices match `EnemyData.eventDatas`. |
| `SplineMover.UpdateObjectData` | 0x1D44890 | `_currentSpeed = clamp(placement.moveSpeed + Random.Range(_moveSpeedRange) + speedStep, 0.0001, 999)`. `_lookAtType = placement.lookAt`. The root `localRotation` is set to `Euler(placement.rotate)`. Stage JSON `speed` = moveSpeed and clip `rotate` = placement rotate [I]. |
| `EnemyMover.InStartArea` | 0x1D6C860 | Only caller is `PawnEnemyGround.LocalLateUpdate` (0x1D17CD0, call at 0x1D17EBC), after `IsGroundDisplay(pos, rect, 500)` and `IsInGameRange(pos, _cameraRangeDistance)`. With InAreaStart (528), **the program starts only when the enemy comes into the ground display or range**. Traced 2026-11-04: while `_isInGamePlayArea` (0x1ED) is clear, LocalLateUpdate tests `InGameManager.IsInGameRange(pos, _cameraRangeDistance)` (0x1CE7EF0: `dx²+dz² < range²` from `_inGameRoot`, InGameManager+0x88) when the range is > 0, else `HybridCollisionManager.IsGroundDisplay(pos, rect, 500)`; on success it sets the flag and calls `InStartArea`, which acts only while `_inAreaStart` is set (clears it, then StartRouteWithDelay with `_inAreaDelay` 0x298 and `_startDelay` 0x29C). Once the flag is set, `IsGroundOut(pos, -2)` (viewport z ≤ 0 or y ≤ −2) removes the enemy (virtual 0x308), otherwise base `PawnEnemy.LocalLateUpdate` runs. `_isInGamePlayArea` is read only by IsPlayingState, LocalLateUpdate and ReStart: it hides nothing. Attribute 16 programs (the BG07 `TSa01_run*` tanks) start at spawn. |
| `EnemyMover.Progress(dt)` | 0x1D6CB50 | `if (dt>0 && IsPlaying()) { if stack: _execStackEvent(dt); if IsSplineRoute() or !stack: SplineMover.Progress(dt) }`. A stack enemy with no spline **never runs SplineMover.Progress**. All motion comes from async tasks. |
| `EnemyMover._isExecStackEvent` | 0x1D6D3D0 | `_eventStackDelay -= dt`. Returns true (and clamps the delay to 0) only when `dt>0`, the delay is ≤ 0 and `_isFinishDelay` is false. While waiting with a Drift look type it applies `_AddDriftAngle(0, 0.2, dt)`. Each wait is therefore a whole number of frames, and leftover time is not carried over. |
| `EnemyMover._execStackEvent` | 0x1D6CED0 | Runs events in the same frame until one blocks, with a guard of 1000 per frame. Pseudo-code is in §1. |
| `InGameEnemyMoveBase.ExecEvent` | 0x1CD9D50 | Stack default case, virtual slot 0x2C8. It requires `Application.isPlaying`, `_reveToken` not cancelled and `!_isDeletedReve`. Type 1 → `_delayPlayPause`. Types 5 and 80 do nothing. 16 Easing → `_nextEasingType = intValue1`. 19 LookAt → `_nextLookAtType`/`_nextLookAtRotate`. 20 → `_delaySecond(...).Forget()` (only meaningful outside stack mode). 21 Parts. 82 → `CancelTaskToken(intValue1)`. **Every other type** → `_execEventWithRepeat(ev, RouteToken)`, an async UniTaskVoid that runs synchronously to its first await. |
| `_execEventWithRepeat` | 0x1CDC370, MoveNext 0x1CF6410 | Repeat wrapper plus a per-type body (jump table 0x1CF96E0 for types 2..18, RotateR 84 at 0x1CF903E). |
| `_moveTypeUpdateAsync` | 0x1CDCD60, MoveNext 0x1CF9730 | Per-frame mover for ForwardMove, Horming and Direction (§3). |

Frame clock: `InGameManager.Instance+0x28` → `+0x18` is the game dt and `+0x1C` must be > 0 (running) [I: pause/scale gate]. Movers yield on `PlayerLoopTiming.LastUpdate` (9). Flag waits yield on `Update` (8). DOTween tweens use `UpdateType.Manual` (3), driven by the game.

TaskFlags (`InGameObjectWithEvent._taskFlag`, offset 0xC8):

| Bit | Task |
|---|---|
| 1 | RotateTask |
| 2 | RotateTTask |
| 4 | TranslateTask |
| 8 | ScaleTask |
| 16 | AnimationTask |
| 32 | SpeedTask |
| 256 | MovingTask (ForwardMove, Direction, Horming) |
| 512 | HormingTask |
| 1024 | DirectionTask |
| 532 = 0x214 | EndCheck (4 + 16 + 512) |

The static `_eventToTaskflag` (set in .cctor 0x1CDBD00) maps event type to task: 13→4, 2→1, 3→2, 4→8, 9→16.

## 1. Stack interpreter (`_execStackEvent`, 0x1D6CED0)

```
if !_isExecStackEvent(dt) or _baseEnemyData == null: return
for guard in 0..1000:
  if idx >= count: break
  e = _eventDatas[idx]
  switch e.eventType:
   101 Loop:   if !_loopCounters.ContainsKey(idx): _loopCounters.Add(idx, e.intValue1)
               n = --_loopCounters[idx]
               if n >= 0: idx = baseEnemyData.GetLabelIndex(e.stringValue); continue   // jump to the Label event itself
               _loopCounters.Remove(idx); idx++                                      // counter re-arms on the next visit
   100 Goto:   if intValue1 >= 100 or intValue1 > (int)(Rand01*100): idx++ else idx = label(stringValue)
   1000 FinishDestroy: if _taskFlag & 0x214: idx = count; break           // wait (see end check)
                       else EndRoute(); break                             // value0 and intValue1 are NOT read
   1001 FinishWait:    _isFinishDelay = true; break                       // stack stops for good; tasks keep running
   81 TaskClear:  ClearTaskFlag(intValue1); idx++
   80 TaskWait:   mask = intValue1 != 0 ? intValue1 : 0x7FFFFFFF
                  if _taskFlag & mask: break (recheck every frame)  else { _eventStackDelay = 0; idx++ }
   20 Idle:       delay = dotime; if flag0 && (value0 - _wakeAfterSecond) < 0: delay += value0 - _wakeAfterSecond
                  idx++; if delay > 0: break (stack waits)
   1 Delay:       same delay as Idle; then if delay > 0 && value0 > 0: _delayPlayPause(RouteToken, delay, value0'); delay = 0
                  idx++; if delay > 0: break
                  // value0 == 0: the stack waits dotime.
                  // value0 > 0: no stack wait; after value0 s the mover is paused for dotime s.
   5 Label:       idx++
   default:       ExecEvent(e, RouteToken); idx++                         // 2,8,10,11,12,13,... start async tasks
end: if idx >= count && !(_taskFlag & 0x214) && !_isInGamePlayArea(0x291): EndRoute()   // runs every frame
```

- **Labels.** `EnemyData.Coordinate` (0x1D321E0) maps the `stringValue` of each type-5 event to its index (`GetLabelIndex` 0x1D32C90, which returns 0 if the label is missing).
- **Loop count.** A Loop with `intValue1 = N` jumps back N times, so the body runs **N+1** times. The Loop in `run04_r90` (`intValue1 = 9`) runs its body 10× (10 × 9° = 90°).
- **EndRoute.** `SplineMover.EndRoute` (0x1D43B30) runs `StopAll`, `RemoveInGame` and `_endCallback`, then a virtual call. The enemy is removed; this is not a kill.

## 2. Repeat wrapper (`_execEventWithRepeat` MoveNext 0x1CF6410)

```
rate = e.rpidf ? InGameManager.Instance.<+0x64> : 1            // rapid factor [I]
repeatDelayBase = e.repeatDelay * rate; repeatDelay = repeatDelayBase
repeatWait = e.value0;  firstTimeWait = rate*e.value1 (+ Rand01*randomWait*rate)
isNoEntry = true; isOnceForceFire = (repeatCount <= 0 && firstTimeWait <= 0)
if repeatCount > 0: await Yield
loop while isLoop && !ct.cancel:
   if frameRunning <= 0: await Yield; continue
   <type body>                          // may await (Rotate, Translate, Set/ResetObjFlag, Bullet)
   tail (0x1CF7C66): if repeatCount > 0 && !cancel:
         while repeatDelay > 0: repeatDelay -= dt; await Yield
         repeatDelay += repeatDelayBase; repeatCount--          // overshoot is carried over
      else isLoop = false
```

`repeatCount = 0` runs the body once. `repeatCount = R` runs it R+1 times, separated by `repeatDelay`. For a single event the wrapper's `repeatDelay` value (for example 0.01) is irrelevant.

## 3. Per-event semantics

### 12 ForwardMove (case 0x1CF803B)

```
await WaitTaskFlag(MovingTask 256)                // serialises ForwardMoves; does not block the stack
_moveType = DirectionMove(2)
_moveValue = Matrix4x4.Rotate(root.localRotation).MultiplyVector(_lookAtVector())   // snapshot once
_localDuration = dotime
_moveTypeUpdateAsync(TranslateToken, 256).Forget()
```

`_lookAtVector` (0x1CDCCC0) is `Vector3.back` when `_lookAtType == Back(2)`, and `Vector3.forward` otherwise.

`_moveTypeUpdateAsync` (Direction case 0x1CF9A56):

```
SetTaskFlag(256)
loop: if running && IsPlaying():
        lp = root.localPosition; step = dt*_currentSpeed (read each frame)
        lp += _moveValue*step; _localDuration -= dt; done = _localDuration <= 0
        area: if isEntryedArea && !IsGameWideArea(p) && isAreaoutEnd()(moveType 2/3/4) → EndRoute()
              else isEntryedArea = IsGameWideArea(p)
        root.localPosition = lp                    // 0x1CFA22E
      if done: break;  await Yield(LastUpdate)
_moveType = Done(999); ClearTaskFlag(256)
```

- **Axis:** root local **+Z** rotated by the root's local rotation **at the start**. Later Rotate events do **not** steer a move that is already running.
- **Units:** parent (ground root) units per second.
- **Speed:** `_currentSpeed`, the placement moveSpeed, not an event value.
- **Easing:** none.
- **Timing:** the first step is taken in the start frame. The last frame moves a full step, so the travel is `ceil(dotime/dt)·dt·speed`.
- **Unused fields:** `value0` and `intValue1` are not read; 256 is only an editor marker [I].
- **Area exit:** a DirectionMove enemy that has entered the wide area and then leaves it is ended at once.

### 2 Rotate (case 0x1CF6DB6)

```
_isDirtyTransform = true; t = _getTransform(nameValue)       // "" or missing key → root (_transformCache)
if dotime > _dotimeMin(0.001):
   _delayRotate(t, ease = intValue1 != 0 ? InOutSine(4) : Linear(1), RotateMode.FastBeyond360(1), RotateToken,
                preWait = value0, postWait = value1, dotime, rot = vectorValue, isLocal = true,
                isAbsolute = flag0, setflag = RotateTask 1)     // awaited by this wrapper, not by the stack
else t.localRotation = Euler(vectorValue)                    // instant and ABSOLUTE
```

`_delayRotate` (MoveNext 0x1D2CAA0):

```
_taskFlag |= 1
await _delaySecondWithPause(preWait)
t.DOLocalRotate(rot, dotime, rm).SetEase(ease).SetRelative(!isAbsolute).SetUpdate(Manual)
await the tween
await _delaySecond(postWait)
_taskFlag &= ~1
```

- **flag0 = false:** additive (relative) rotation over `dotime`.
- **flag0 = true:** absolute target.
- **intValue1:** any non-zero value (256 or 1) selects InOutSine easing. It is not a mode switch.
- **Overlap:** Rotate does not wait for an earlier RotateTask, so rotations can overlap.

Cache keys (`Initialize` 0x1D1DD60): for each child transform, `GetParentPath(child, root)` with the root name excluded, for example `pf_ene_tsa01/eme_tsa01_body/...`. Names that contain "damage", "collision" or "burner" are skipped.

### 13 Translate (case 0x1CF83CC)

```
await WaitTaskFlag(4); t = _getTransform(nameValue)
if IsZero(_currentSpeed): t.localPosition = vectorValue
else
  dist = flag0 ? |vectorValue| : |t.localPosition - vectorValue|
  T = dist/_currentSpeed
  await _delayTranslate(t, TranslateToken, preWait = value0, postWait = value1, T, vectorValue, isRelative = flag0)
```

`_delayTranslate` (0x1D2DCB0) sets `_taskFlag |= 4`, runs the preWait, then `DOLocalMove(v, T).SetRelative(flag0).SetEase(Linear).SetUpdate(Manual)` (paused while the mover is paused), then the postWait, then clears bit 4.

- **Frame:** local to the parent of `t`. It does **not** follow the rotation.
- **Duration:** `dotime` is ignored; the time comes from speed. For `boxLR`, 300/20 = 15 s.

### 20 Idle and 1 Delay

Stack waits only (§1). `ExecEvent` runs `_delayPlayPause` (MoveNext 0x1D2C7A0): it waits `startSec` (pause-aware), calls `PlayPasue(true)` (virtual), runs `InGameManager.DelaySecond(sec)`, then calls `PlayPasue(false)`.

### 1000 FinishDestroy and 1001 FinishWait

See §1.

- **FinishDestroy:** EndRoute when `_taskFlag & 0x214 == 0`. Otherwise it waits until those tasks are done and `!_isInGamePlayArea`. **value0 and intValue1 are not read.** MovingTask (256) and RotateTask are not part of EndCheck.
- **FinishWait:** the stack halts and Bullet repeats keep going. The enemy then leaves by its other end rules (area exit, camera).

### 10 SetObjFlag and 11 ResetObjFlag (case 0x1CF7ED1)

```
if value0 > 0: await _delaySecond(value0)
(eventType == 10 ? SetFlag : ResetFlag)(intValue1)      // 0x1D1ECA0 / 0x1D1EC70
```

`intValue1` is `InGameObjectFlag`:

| Value | Flag |
|---|---|
| 1 | OffCollision |
| 2 | OffLockon |
| 4 | Offthrough |
| 32 | NoDamaged |
| 64 | BomberRange |
| 256 | NoBullet |
| 512 | ForceFire |

- **intValue1 1 means OffCollision.** The enemy cannot be hit (and cannot block) until ResetObjFlag 1. It does **not** gate bullets; that would be 256.
- `stringValue`, `nameValue` and `flag0` are not read.
- The flag change is async, so the stack does not wait for `value0`.

### 80 TaskWait

See §1. `dotime` is not read.

| intValue1 | Waits for |
|---|---|
| 1 | Rotate tween + postWait |
| 4 | Translate (incl. pre/post wait) |
| 16 | Animation |
| 256 | ForwardMove, Direction or Horming move |
| 0 | any task |

### 101 Loop and 5 Label

See §1. The target label is chosen by `stringValue`. A Loop's `intValue1` is the number of jumps back.

### 8 Bullet (case 0x1CF8D3F)

```
if isNoEntry && !isOnceForceFire:
   until IsForceFire() || IsEntryFireArea(e): await Yield     // muzzle position in IsGameBulletAreaWorld
   isNoEntry = false
if firstTimeWait > 0: await WaitSeconds(firstTimeWait); firstTimeWait = 0     // value1 (+randomWait)
elif !isOnceForceFire: await WaitSeconds(value0)
if isOnceForceFire || IsCheckFire(e): _bulletFire(ct, e)       // the default is FireByRouteEvent → _bulletFireAsync
→ repeat tail (repeatDelay)
```

- **IsCheckFire** (0x1CDA6C0): returns true when force-fire is on. Otherwise a shot is skipped when `randomFire > Rand01·99.9`, and the muzzle must still be in the bullet area.
- **First shot:** `value1` (+ randomWait) after the muzzle first enters the area, or `value0` if `value1 = 0`.
- **Later shots:** every `repeatDelay + value0`, for `repeatCount + 1` shots in total.
- **Fields:**
  - `stringValue`: the bullet template or selector.
  - `nameValue`: the muzzle, a muzzle pack or the root.
  - `subnameValue`: the base transform.
  - **`flag0`: isSelfDir**, passed to `BulletFireAsync` (`_bulletFireAsync` 0x1CF5A10).
- **Gating in BulletFireAsync (0x1CF4500):** it holds while `IsTurning(muzzle)`, calls `SetNoTrun(true)` while firing, and requires `IsPossibleFire` and `IsBulletFire` (range limit). Plain `EnemyMover` (which the TSa01 uses) has `IsTurning = false`. `EnemyMoverTurrets` asks its `EnemyTurret` [I].

## 4. Models: which local axis is "forward"

`tools/script_fileid.py` identifies the components:

| Prefab | Components |
|---|---|
| `Pf_Ene_TSa01` and `Pf_Ene_TSa01a` | **EnemyMover** (not EnemyMoverGround or EnemyMoverTurrets), PawnEnemyGround, EnemyTurret on `eme_tsa01_battery`, EnemyCollisionModel |
| `Pf_EneObj_Bg07_Enebox` | EnemyMover and **Ene_EneBox01** (a PawnEnemyGround) |

The two TSa01 prefabs differ only in `_cameraRangeDistance` (0 vs 350).

**TSa01 / TSa01a:**
- Every node has identity rotation.
- The body mesh AABB extents are x ±7.29 and z ±8.72, so the hull's long axis is Z.
- The battery pivot sits at body z −2.66. Its muzzle is at local (0, 3.35, **+7.86**), so the barrel's rest pose points +Z.
- Model forward is therefore **local +Z**, the same axis ForwardMove uses.
- Clip `rotate` y=90 points the tank to world +X. `r90` then turns it +90° (clockwise seen from above) to −Z. `l90` clips start at y=270 (heading −X).

**Enebox:**
- Every node has identity rotation (mesh scaled 0.8) and every clip rotate is 0.
- `boxLR` moves by Translate local +X (300 at speed 20, so 15 s), so its facing does not matter.

## 5. Differences from `Round1GroundEnemies.UpdateActor`

1. **Program start.** UpdateActor starts at spawn. Natively, attribute 528 (InAreaStart) waits for `PawnEnemyGround` to bring the enemy into display or range. Affects `hid_m_2stp` and `boxLR`.
2. **ForwardMove:**
   - It waits `value0` (native ignores `value0`).
   - A new move overwrites a running one, where native waits for MovingTask.
   - Its direction is `visual.forward` with y flattened (equal only with an identity parent).
   - It lerps exactly `dotime·speed`; native adds a last-frame overshoot and takes its first step in the start frame.
   - It has no area-exit EndRoute.
3. **Rotate:**
   - Additive only when `intValue1 & 256`; otherwise it sets the angles instantly and absolutely. Native: when dotime > 0.001 it tweens, **relative unless flag0**, with InOutSine when intValue1 ≠ 0. Only when dotime ≤ 0.001 does it set absolute angles instantly.
   - It blocks the program for `value0`; native waits for `value0` inside the task while the stack continues.
   - It has no postWait (`value1`) and no easing (linear Euler lerp).
4. **Translate:**
   - It blocks the program for `value0`; native's preWait runs inside the task.
   - It ignores `flag0` (absolute target when 0) and `nameValue` (it always moves the root).
   - It has no postWait `value1`, and it does not wait for an earlier Translate.
   - It shares `a.moving` with ForwardMove, so one cancels the other.
5. **TaskWait:** any mask waits on `a.moving` (translate or forward). Bit 1 waits on `a.rotating`, bit 16 on the animation, and bit 4 or 256 is not told apart. Native tests `_taskFlag & mask`, and 0 means all.
6. **FinishDestroy:** waits `value0` and then removes the enemy. Native never reads `value0`; it ends only when EndCheck tasks are done (and, after waiting, `!_isInGamePlayArea`). `boxLR` ends about 1 s late (`value0 = 1`).
7. **End of program:** UpdateActor never ends an enemy because its events ran out. Native calls EndRoute when the index passes the end and there are no EndCheck tasks. For example, `run04_r90` ends after its final 30 s move or when it leaves the area.
8. **FinishWait:** UpdateActor treats it as an unknown event and moves past it, with the same result as native (the enemy persists).
9. **SetObjFlag and ResetObjFlag:** ignored. Native toggles OffCollision, so `hid_*` tanks can't be hit until ResetObjFlag, and `boxLR` can't be hit from start until 1 s after its Idle.
10. **Loop:**
    - The label is the last Label it ran, not the `stringValue` name.
    - The counter is never removed, so the loop does not re-arm on a later visit.
    - The pass count matches (N+1).
11. **Idle and Delay:**
    - Delay always waits `dotime`. Native, when `value0 > 0`, does not wait and pauses the mover instead.
    - The `flag0` wake adjustment is missing.
12. **Bullet:** times are left to `Round1EnemyAttacks.Register`. Its cursor counts Delay, Idle and Rotate, but **not ForwardMove or Translate time before TaskWait 256 or 4**. So `hid_m_2stp` starts its Bullet about 1.0 s early (native ≈ 3.5 + 1.0 + area entry, then the 0.5 s `value1` wait). Loops are not modelled. The first-delay and interval formulas match native.

## 6. Model output (`tools/stack_sim.py`, 60 fps, entry wait not modelled)

| Program | Placement and speed | Output |
|---|---|---|
| `run04_r90` (BG07) | yaw 90, speed 25 | +X for 4 s (≈100 u); then 10 × (9°/0.1 s InOutSine + a 0.1 s / 2.5 u segment taken at the pre-turn heading); then −Z for 30 s. Turn ends at about (120.4, −3.4) heading 180°. Shots at 0.5 s + 1 s·k. |
| `hid_m_2stp` (BG07) | yaw 90, speed 25 | OffCollision on at 0. Moves 25 u from 3.5 to 4.5 s. Collision back on at 4.5 s. Moves 50 u more from 4.5 to 6.5 s. Bullet first shot at 5.0 s, then every 1 s. FinishWait at 4.5 s. |
| `boxLR` (BG07) | yaw 0, speed 20 | Translate +300 X over 15 s. OffCollision 0 → 2.0 s, then on again from 11 s. EndRoute at 15.0 s (FinishDestroy waits on TranslateTask). |

Open questions `[?]`:
- The exact game dt source (`InGameManager+0x28`, offsets 0x18 and 0x1C).
- The exact InAreaStart condition.
- Whether the JSON `speed` includes `_moveSpeedRange` or `speedStep`.
- The update order between DOTween Manual and LastUpdate inside one frame (±1 frame on the ends of turns and moves).

## 7. Buildings (BG07 area 4)

Nothing in EnemyMover, PawnEnemyGround or the BG07 data keeps a ground enemy out of a building: there is no ground
collision with the background, `durationTime` does not limit a stack program, and `_isInGamePlayArea` hides nothing.
The BG07 TSa01 rows (165 s, attribute 16) each turn into their own street and drive 750 units down −Z. The lanes near
x 10 (row z 5525) and x 20/40 (rows z 5725/5750) run into the front right tower (`pf_bg07_tower02`, x 10..170,
z 5190..5310) at about 190–200 s, with the remaster camera sampled from the original rail. So the original data also
puts these tanks inside that tower; no recording of the original exists to show the screen there.
`Round1GroundEnemies.Reach` (remaster rule, 2026-11-04) stops a ground enemy at the edge of a `bg07_tower*` mesh and
queues the ones behind at the held one; boxes shrink 3 units across the motion so grazing lanes pass. An enemy
queues only behind a held one heading the same way (crossing traffic passes through, as natively), and enemy-to-enemy
tests use a square of the spawn length, since the box around a half-turned tank is ~27 units wide. Checked with
`STAGE_PLAY_ONLY=BG07 STAGE_PLAY_SPEED=5 STAGE_PLAY_SECONDS=44 STAGE_PLAY_PEACE=1 STAGE_PLAY_SHOTS=190,...,211`.
