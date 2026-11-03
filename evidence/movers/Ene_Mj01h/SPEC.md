# Ene_Mj01h (+ Ene_Mj01b) — native centipede: head, summoned bodies, stop-and-sink end

Read-only study of `GameAssembly.dll`. Builds on `../../air-route-events/SPEC.md`.

Disassembly:
- `dis/all_methods.txt` (Ene_Mj01h);
- `dis/Ene_Mj01b_all.txt` (body);
- `dis/SplineMover_ProgressSpline.txt`;
- `dis/end_and_start_helpers.txt` (SplineMover.EndRoute/SetEndCallback, PawnEnemy.EndRoute/StartRoute, KnightEnemy.CallDisabled).

Model: `mj01h_sim.py` → `sims/mj01h_1a_BG01.txt`, `sims/mj01h_1a_BG01_kill4.txt`. `[I]` = inference, `[?]` = unknown.

## 1. Classes, fields, constants

`Ene_Mj01h : KnightEnemy : RookEnemy : PawnEnemyDD : PawnEnemy`; body `Ene_Mj01b : PawnEnemy`.

| Item | Value |
|---|---|
| Pf_Ene_Mj01h | `_HitPoint 100`, `_deadExplosion pf_eff_explposion02`, `_isChildrenSolidarity 0`, `_children []`, **`_summonNameStr Pf_Ene_Mj01b`, `_summonEnemyCount 9`**, mover `_lookAtType 0`, `_lookAtUpdateSec 0` |
| Pf_Ene_Mj01b | `_HitPoint 100`, `_deadExplosion pf_eff_explposion01` |
| Statics (.cctor 0x1DC7FD0) | `gravityVector = (0, 0, −16)` (sky: 16 u/s **down the screen**), `_unitDistance = 22.5` |
| Head runtime | `_startPosition` 0x210, `_passed` 0x21C, `_callCount` 0x220, `_killCount` 0x224, `_moveEnd` 0x228, `_breakChildren` 0x229 |
| Body runtime | `_state` 0x1B0 (READY −1, SPLINE_MOVE 0, WAIT 1, AWAY 2, EXIT 3), `_stopPos` 0x1B4, `_callback` 0x1C0 (= head.ReceiveKill) |
| Definitions | BG01–BG05, BG07 `ene_mj01_1a`/`1b`: **attribute 1 (spline route, no event stack)**, `routes [move_mj01_1a]` / `[move_mj01_1b]`, speed 88, range 0, easeType 0, lookAt 1, duration 60 |
| Routes | straight lines: `1a` (0,0,0) → (280,0,0), `1b` → (−280,0,0); length 280; knots at arc-length times |
| Spawns | clip offsets (∓200, 0, 50) (BG01–04, BG07), (∓230, 0, 50) (BG05); indexValue 0 |

## 2. Route motion (head and bodies)

Head and bodies are not stack movers. Each runs `SplineMover._ProgressSpline` (0x1D44AE0) every LateUpdate:

```
_durationPassTime += dt
if splineLength > 0 and moverState != 4:  rate += dt·_currentSpeed / splineLength      // IsSplineMove 0x1CDABD0: by distance
else: rate = durationTime > 0 ? passTime/durationTime : 1
offset = rate >= 1 ? (rate=1, done) : Easing01(rate, easingType 0)
UpdateEvent(prev, delta); position = start + Eval(offset) − knot0                         [I: knot0 = 0 here]
lookAt 1: rotation from the route tangent (yaw 90 for 1a, 270 for 1b)
if done: next route, else (unless _isEndRouteKeep) EndRoute()                             // vslot 0x278
```
- `duration` (60) is not used, because the length is > 0.
- The head moves at a constant 88 u/s and reaches the route end after 280/88 = 3.18 s.

`SplineMover.EndRoute` (0x1D43B30) does: StopAll, RemoveInGame, invoke and clear `_endCallback`, clear the spline, `Clear()`, moverState 3. It **does not disable the pawn**: removal only happens through `_endCallback`.
- Normal enemies get the default `CallDisabled` lambda from `StartKickWithDelayTime`.
- The head replaces it.
- Bodies get none: `StartRoute(null)`, and `SetEndCallback(null)` is ignored.

## 3. Head code

```
GetStart() 0x1DC7240:
    PawnEnemy.GetStart()
    _startPosition = localPosition                              // spawn point (clip + definition + offset)
    mover.SetEndCallback(moveEndCallback)                       // replaces the default CallDisabled
    _passed = 0; _moveEnd = _breakChildren = false
    KnightEnemy.CreateAllChildren()                             // 9 × GetEnemy("Pf_Ene_Mj01b") from the pool -> _childEnemies
    for each child (Ene_Mj01b):
        child.UpdateObjectData(headData.placements[0], 0)       // own speed: 88 + U[0,range) (range 0)
        child._targetY = −headData[+0x48]
        child.CreateRouteData(headData, _startPosition)         // SAME route, SAME start point as the head
        child.SetDisableAction(...); child._callback = ReceiveKill
ReStart() 0x1DC7890: KnightEnemy.ReStart; _callCount = _killCount = 0   (bodies: ReStart → _state = READY)

LocalLateUpdate(dt) 0x1DC7590:
    PawnEnemy.LocalLateUpdate(dt)                               // in-area flag, then the head's route step (may fire moveEndCallback)
    if _moveEnd:
        if mover._isInGamePlayArea: localPosition += (0,0,−16)·dt      // sink, yaw frozen
        else: CallDisabled()                                           // KnightEnemy: only clears _childEnemies
        return
    if !_breakChildren and _callCount < 9:                      // CallMJ01Body 0x1DC7090 (inlined)
        _passed += dt·mover._currentSpeed                       // speed integral, not measured displacement
        if _passed >= 22.5 and _childEnemies[_callCount] is Ene_Mj01b b:
            b.StartRoute(null)                                  // vslot 0x5D8 → mover.StartRoute + b.GetStart (_state = SPLINE_MOVE)
            _passed −= 22.5; _callCount++                       // remainder carried

moveEndCallback() 0x1DC8050 (head route ended):
    if !_moveEnd:
        SendMessage()
        if IsAlive: PlayQue(viewport.x >= 0.5 ? 185 bg2_ene_mj01_head_stop_r_01 : 184 bg2_ene_mj01_head_stop_l_01)
    _moveEnd = true

SendMessage() 0x1DC7AE0: for each Ene_Mj01b in _childEnemies: b.SetParentKilled()

ReceiveKill(pe) 0x1DC78B0 (a body was destroyed; called from Ene_Mj01b.ToDestroid):
    _killCount++
    i = index of pe; _childEnemies[i] = null
    for j > i: b = _childEnemies[j]; if b: (b._state == READY ? b.CallDisabled() : b.SetParentKilled()); _childEnemies[j] = null
    _breakChildren = true                                       // no more releases
    return _killCount > 9                                       // → body gets Get5000 (head and all 9 bodies destroyed)

_callDeadEffect() 0x1DC7D70 (head destroyed):
    SendMessage(); RookEnemy._callDeadEffect()
    for j >= _callCount: _childEnemies[j]?.CallDisabled()       // unreleased bodies vanish
    if _killCount == 9: Get5000(position)                       // all bodies were killed first
    _killCount++; ItemDrop(kind 7, GetSkyRootPosition(pos))
```

## 4. Body code (Ene_Mj01b)

```
LocalLateUpdate(dt) 0x1DC6CD0 (own code BEFORE base):
    switch _state:
      READY(−1), SPLINE_MOVE(0): nothing          → base (route step while SPLINE_MOVE; READY: mover never started)
      WAIT(1):  _state = AWAY                      → base               (one frame without motion)
      AWAY(2):  _stopPos += (0,0,−16)·dt; localPosition = _stopPos
                if !mover._isInGamePlayArea (last frame's flag): ProgressDisable(); _state = EXIT
                → base
      EXIT(3):  CallDisabled(); return             (no base)
SetParentKilled() 0x1DC6F00: if _state == SPLINE_MOVE: _stopPos = localPosition; EndRoute(); _state = WAIT
                             (READY bodies ignore it)
ToDestroid() 0x1DC6F70: _state = READY; if _callback(this): Get5000(pos); PawnEnemy.ToDestroid()
```

There is no "entered first" condition: a detached body that is outside its play area is removed two frames later.

## 5. Behaviour summary (numbers at 88 u/s, 60 fps)

- **Releases:** `_passed` grows 1.4667 per frame. Bodies are released 15 or 16 frames apart: t = 0.250, 0.500, 0.767, 1.017, 1.267, 1.533, 1.783, 2.033, 2.300 s (all 9 by 202.5 units).
  - Each body runs its own copy of the route from the head's spawn point, so body k trails by about 22.5·k along the path.
  - Gaps alternate 21.9 / 23.5 units because of frame quantization.
- **Route end:** the head reaches knot 280 at 3.167 s:
  - BG01 1a: spawn (−200, 50) → stop at (80, 50), on screen;
  - BG05: spawn (−230, 50) → stop at (50, 50).
- **Stop and sink:** the head plays the "head stop" cue and sinks at 16 u/s. All bodies stop where they are, wait one frame and sink at 16 u/s. The line keeps its shape and leaves the bottom (z < −91.7) about 8.9 s later; each part is removed as it leaves.
  - The bodies never complete the route: the head always finishes first.
- **Body killed:** the bodies behind it stop and sink (unreleased ones vanish). No more releases. The bodies ahead keep following until the head's route end.
- **Head killed:** every released body stops and sinks; unreleased ones vanish; item kind 7 drops. A 5000 bonus is given when the head and all 9 bodies are destroyed.
- **Facing:** lookAt 1 gives the route tangent (yaw 90 for 1a, 270 for 1b). Yaw is frozen while sinking.

## 6. Simulated path — BG01 `ene_mj01_1a`, clip (−200, 0, 50) (`sims/mj01h_1a_BG01.txt`)

| t (s) | head | bodies |
|---|---|---|
| 0.25 | x −176.6 | body1 released at (−200, 50) |
| 1.00 | x −112.1 | 1–3 at −134.0, −156.1, −179.6 |
| 2.30 | x 3.95 | body9 released (all 9 out) |
| 3.00 | x 64.2 | 1–9 at 42.1 … −138.5 |
| 3.167 | **route end at (80, 50)**, sound `…head_stop_r_01`, sink starts | all stop at x = 56.7, 34.8, 11.3, −10.7, −32.8, −56.3, −78.3, −100.3, −123.8 (z 50) |
| 4.00 | (80, 36.7) | z 36.9 |
| 8.00 | (80, −27.3) | z −27.1 |
| 12.03 | leaves at z −91.9 → CallDisabled | removed at 12.05 (z −92.1) |

Kill variant (`--kill 4@1.5`):
- body 4 dies at 1.5 s;
- body 5 (released at 1.267, still at x −179.6, off screen) is removed at 1.517;
- bodies 6–9 are never released;
- bodies 1–3 and the head stop at 3.167 and sink.

## 7. How this differs from the reconstruction's Mj01 model (`Round1EnemyWaves.cs` SpawnChain / UpdateChains)

| Topic | Reconstruction | Native |
|---|---|---|
| Head at route end | `Position()` keeps going along the last tangent at 88 u/s and leaves the screen | **stops on the last knot** (on screen for every placement), plays head_stop_l/r, then sinks at 16 u/s until outside its play area |
| Bodies at the head's route end | keep following `PathAt(head, age − lag)` (the tangent extension); detach only if the head was **killed** | `SendMessage` → **every released body stops and sinks** at 16 u/s, whether the head was killed or not |
| Release timing | continuous `lag = (i+1)·22.5/speed` | per-frame accumulator `_passed += dt·speed`, remainder carried. Bodies start their own mover (own speed from the placement, own route clock) from the head's spawn point. Same result within ±1 frame at constant speed and range 0. |
| Detached-body removal | needs `entered` + outside the ±margin for `NativeExitDelay`; a body that never entered is kept (until `duration`) | removed as soon as `_isInGamePlayArea` is false (WAIT 1 frame, then AWAY → ProgressDisable → next frame CallDisabled); no entered test |
| Unreleased bodies | "stranded" → removed when the chain breaks or the head is gone | removed (CallDisabled) on head death or on a body kill ahead of them. On a normal head route end they stay READY in the pool, invisible at the spawn point `[?]` (cannot happen with these 280-unit routes) |
| Kill rules | ReceiveKill and head death as native | same; plus `Get5000` only on the last of head + 9 bodies, and `ItemDrop(7)` on head death |
| `duration` cull | `headAge − lag > 60` | not used (spline length > 0) |
| HP | bodies 2000 (database row) | prefab `_HitPoint 100` for head and body; the database scaling was not traced `[?]` |

**Port:** give Mj01h a hook that:
1. on route completion fires the stop cue, sets `moveEnd` and stops the route;
2. moves the head by (0, 0, −16)·dt while in its play area, otherwise removes it;
3. switches every started body to WAIT → AWAY sink with the play-area removal rule.

## 8. Open

- `[?]` LateUpdate order of head vs bodies (pool order). The model assumes bodies update after the head: a released body steps in its release frame, and a body detached at the route end keeps last frame's position. ±1 frame (±1.47 units).
- `[?]` What `RemoveInGame` (in SplineMover.EndRoute) changes for the still-alive, sinking head and bodies: whether they stay hittable and drawn `[I: yes, the pawn keeps running]`.
- `[?]` `_sizeType` of Mj01h/Mj01b (play-area rect for the sink removal). Small (±0.15) is assumed.
- `[?]` `child._targetY = −EnemyData[+0x48]` (EnemyData field 0x48) is not resolved. It is an altitude/plane offset, with no effect at y = 0.
