# Ene_St01 — class-driven air mover (Pf_Ene_St01)

Read-only study of `GameAssembly.dll` (IL2CPP x64). `[I]` = inference, `[?]` = unknown, everything else read from code.
Frame, units and stack rules are those of `../../air-route-events/SPEC.md` (sky plane x right, z up, y toward the camera;
yaw about +Y, 0 = up the screen, 90 = right). Disassembly: `dis/all_methods.txt`, vtable: `dis/vtables_6classes.txt`.
Tools (copies, also in `../tools/`): `tools/mdis.py` (annotated disassembly), `tools/movers_sim.py` (frame model of this
spec), `tools/vt.py`, `tools/dispscan.py`, `tools/pfnode.py`, `tools/mlist.py`. Sims: `sims/`.

## 0. Where it is used

| Stage | Definition | Spawns | Program (attribute 16, stack mode) | Placement |
|---|---|---|---|---|
| BG01 | `default_St01` | 192 | `[1001 FinishWait]` (dotime 2, value1 100, intValue1 1 — **not read** by FinishWait) | speed 30, rotate y 180, lookAt 0, no repeats, position (0,0,0) |
| BG07 | `default_St01` | 28 | same | same |
| BG08 | `default_St01` | 6 | same | same |

Every spawn event has **indexValue 1** (226/226), y = 0 and clip yaw 0. Offsets: BG01 x −145..145, z 100 (above the
top edge, t 5–203.5 s); BG07 x −200..200, z 70..100 (t 137–176.5 s); BG08 x 50..200, z 70..100 (t 322–324.5 s).
The placement speed 30 / yaw 180 / lookAt are **never used**: the class does all motion. `EnemyData.duration` (30) is not
applied (stack mover without spline, air spec §3.5).

## 1. Fields

Statics (`.cctor` 0x1D085B0):

| Static | Value | Use |
|---|---|---|
| `_InvincibleTime` | 1.0 | `_nohitTime` at ReStart |
| `_StartSpeed` | 150 | blow-back speed |
| `_LifeTime` | 8.0 | time in Move/Wait before Leave |
| `_MoveSpeed` | 100 | cruise speed cap (Move) |
| `_DeceleSpeed` | 300 (= 2·_StartSpeed) | blow-back deceleration, u/s² |
| `_AcceleSpeed` | 100 (= _MoveSpeed) | acceleration toward waypoint / away when leaving, u/s² |
| `_DecelerationDistance` | 50 | below this distance to the waypoint: brake |
| `_KeepDistance` | 50 | waypoint x offset from the player |
| `_WaitTime` | 0 | Wait state length (so Wait lasts one frame) |
| `_BulletName` | `"st01_fire1"` | added to `GetBulletTemplates()` (0x1D08080) |
| `_ShotInterval` | 1.5 | shot period |
| `StartAngle` | `Quaternion.Euler(Vector3.forward)` = Euler(0,0,1°) | initial `_selfAngle` (overwritten in Start) |

Instance (offsets in the object): `_Muzzle` 0x1B0, `_state` 0x1B8, `_moveSpeed` 0x1BC, `_nohitTime` 0x1C0,
`_lifeTime` 0x1C4, `_waitTime` 0x1C8, `_targetPlayerIndex` 0x1CC, `_moveVector` 0x1D0, `_selfAngle` 0x1DC,
`_wayPoint` 0x1EC, `_bulletTemplates` 0x1F8, `_shotTime` 0x200. Base: `_indexValue` 0x94 (= spawn event indexValue,
written by `InGameEnemyManager._localCallEnemy` 0x1CD6E9B), `_mover` 0xB8, `_token` 0x178.

Prefab (`Assets/OriginalRecovered/Pf_Ene_St01.prefab`): `_Muzzle` = `pf_ene_st01/ene_st01/muzzle` local (0, 0, 3.64);
`_modelTop` = `pf_ene_st01`; `_HitPoint` 100; `_isLockonTarget` 1; `_deadExplosion` `pf_eff_explposion04`;
`_isSimpleCalc` 1. Mover: `_lookAtType` 0.

## 2. Lifecycle hooks

- `ReStart` (0x1D08450): base; `SetObjectFlag(OffCollision 1)`; `_nohitTime = 1`; `_lifeTime = 8`; `_moveSpeed = 1.0`
  (used only in Leave); `_moveVector = Vector3.forward`; `_selfAngle = StartAngle`; `_state = Start`;
  `_token = mover.CreateLinkedToken()` (vslot 0x268); `_shotTime = 1.5`.
- `InitializeToPlay` (0x1D08160): `_bulletTemplates` = `InGameBulletManager.GetTemplate(name)` for every name of
  `GetBulletTemplates()` (base list + `"st01_fire1"`), then base.
- `LocalLateUpdate(dt)` (0x1D08410): **`ActionMove(dt)` first, then `PawnEnemy.LocalLateUpdate(dt)`** (which sets
  `mover._isInGamePlayArea` and runs the stack through `ProgressEvent`).

## 3. Per-frame state machine — `ActionMove(dt)` 0x1D066C0 (jump table 0x1D08060)

`pl` = `InGameManager.GetPlayerSkyPosition(_targetPlayerIndex)` (3D), `lp` = `transform.localPosition` (sky coords [I]).
`RotTo(q, t, deg)` is Unity's `Quaternion.RotateTowards` (inlined: angle = 2·acos(min(|dot|,1))·57.29578, 0 if
dot > 0.999999; `SlerpUnclamped(q, t, min(1, deg/angle))`). `Look(v)` = `Quaternion.LookRotation(v, up)`.

```
// top of every call
if _nohitTime > 0: _nohitTime -= dt; if _nohitTime <= 0: ResetObjectFlag(OffCollision)      // 0x1D067CC

switch _state:
Start (0x1D06824):
    if !mover._isFinishDelay: break                     // waits for the stack's FinishWait (mover+0x2B8)
    _targetPlayerIndex = GetNearestPlayerIndex(GetScreenPosition(position))
    d = lp - pl
    _moveVector = (|d| > 1e-5 ? d/|d| : 0) * 150       // AWAY from the player
    _selfAngle  = Look(_moveVector)
    _wayPoint   = pl;  _wayPoint.x += (pl.x - lp.x < 0) ? +50 : -50                       // beside the player, enemy's side
    _state = Blow                                       // no transform write this frame
Blow (0x1D06B67):
    sp = (_indexValue > 0) ? 0 : |_moveVector|           // indexValue > 0 skips the blow-back
    _moveVector = normalize(_moveVector) * max(0.01, sp - 300*dt)
    if sp <= 0.02: _nohitTime = 0; ResetObjectFlag(OffCollision); _state = Move
    _selfAngle = RotTo(_selfAngle, Look(pl - lp), 720*dt)
    SetLocalPositionAndRotation(lp + _moveVector*dt, _selfAngle)
Move (0x1D06EC1):
    d = _wayPoint - lp; dist = |d|; n = dist > 1e-5 ? d/dist : 0
    if dist >= 50:                                       // accelerate toward the waypoint
        _moveVector += n * 100 * dt
        if |_moveVector| > 100: _moveVector = normalize(_moveVector) * 100
    else:                                                // brake (exponential)
        s = |_moveVector| * exp(-2*dt);  _moveVector = normalize(_moveVector) * s
        if s < 5: _waitTime = 0; _state = Wait
    _selfAngle = RotTo(_selfAngle, Look(pl - lp), 720*dt)        // nose on the player, not on travel
    SetLocalPositionAndRotation(lp + _moveVector*dt, _selfAngle)
    SHOOT(); _lifeTime -= dt; if _lifeTime <= 0: LEAVE()
Wait (0x1D0762A):
    s = |_moveVector| * exp(-2*dt);  _moveVector = normalize(_moveVector) * s;  p = lp + _moveVector*dt
    _selfAngle = RotTo(_selfAngle, Look(pl - p), 720*dt);  SetLocalPositionAndRotation(p, _selfAngle)
    SHOOT()
    _waitTime -= dt
    if _waitTime <= 0:                                   // _WaitTime = 0: always on the first Wait frame
        _wayPoint = pl; _wayPoint.x += (pl.x - p.x < 0) ? +50 : -50;  _state = Move
    _lifeTime -= dt; if _lifeTime <= 0: LEAVE()
Leave (0x1D07C01):
    _moveVector += normalize(lp - pl) * 100 * dt          // accelerate straight away from the player, no cap
    p = lp + _moveVector * dt * _moveSpeed(=1)
    _selfAngle = RotTo(_selfAngle, Look(_moveVector), 720*dt)    // nose turns to travel
    SetLocalPositionAndRotation(p, _selfAngle)
    if !IsGamePlayArea(): _state = Exit                  // HybridCollisions.IsGamePlayArea 0x1DDF760
Exit (0x1D07FD7):
    CallDisabled()                                       // vslot 0x308: removed (not a kill)

SHOOT (0x1D0742F / 0x1D0791D):
    _shotTime -= dt
    if _shotTime <= 0 and _token alive:
        _shotTime += 1.5
        for bt in _bulletTemplates: mover.BulletFireAsync(token, bt, isSelfDir=false, isNested=false,
                                                          muzzle=_Muzzle, base=null, offsetAngle=0, loop=0).Forget()
LEAVE (0x1D07BE2): _state = Leave; SetObjectFlag(NoBullet 256)
```

Notes:
- Timers `_shotTime` and `_lifeTime` only run in Move/Wait. First shot 1.5 s after the first Move frame.
- `IsGamePlayArea()` = any hit collider has `_isInBetweenArea`, set by `HybridCollisions.UpdateCollisions` from the
  collider bounds vs the collision manager's screen bounds (`IsInScreen`/`Bounds.Contains/Intersects`, 0x1DE0846..)
  [I: ≈ "collider still overlaps the visible screen"; exact bounds and update timing not traced].
- All spawns have y = 0, so `Look()` is a pure yaw and `RotTo` = clamp the yaw change to 12°/frame at 60 fps
  (720°/s). [?] At exactly 180° the Slerp side is undefined (first Blow frame for a spawn straight above the player).
- With indexValue 1 the blow-back never happens: Start (frame 2) → Blow (frame 3, immediately Move, collision on) →
  Move from frame 4. With indexValue 0 the enemy is pushed 36.25 units straight away from the player over 31 frames
  (150 → 5 u/s at −300 u/s², then 0.01) while turning to face the player, then Move.
- **Dead zone:** in Move the enemy only accelerates while the waypoint is ≥ 50 units away. While it hovers, Move and
  Wait alternate every frame, so the waypoint is re-sampled every 2 frames (player position ±50 in x on the
  enemy's current side), but the enemy stays put until the player has moved the waypoint ≥ 50 units away; then it
  accelerates again (100 u/s², cap 100 u/s) and brakes with ×e^(−2·dt) per frame inside 50 units.

## 4. Interaction with the EnemyData stack (for `Round1EventStack.cs`)

| Frame part | What runs |
|---|---|
| EarlyUpdate / LastUpdate | nothing of St01 (no stack tasks are ever started) |
| LateUpdate, **before** the stack | `ActionMove(dt)`: the whole motion, rotation and firing (**instead of** any stack motion) |
| LateUpdate, stack | frame 1 only: `1001 FinishWait` → `_isFinishDelay = true`; afterwards the stack returns at once and the end-of-program rule 2 never runs |

Port hook: `PreStack(dt)` = ActionMove; the stack step is kept (it must run once to set `_isFinishDelay`, which gates
Start). Start therefore runs on frame 2 [I: assumes LocalLateUpdate already runs on the spawn frame]. Removal only by
`Exit → CallDisabled` (or a kill). No area-exit rule 1 (no move task).

## 5. Simulated path — BG01 first spawn (t = 5.0 s, clip offset (0,0,100), indexValue 1), player fixed at (0,−49)

`tools/movers_sim.py st01` → `sims/st01_BG01_t5_spawn_0_100.txt` (60 fps, float32 timers; t = time since spawn).

| t (s) | frame | state | pos (x, z) | yaw | speed | event |
|---|---|---|---|---|---|---|
| 0.017 | 1 | Start (waits) | (0, 100) | 0 | – | stack runs FinishWait |
| 0.033 | 2 | Start→Blow | (0, 100) | 0 | 150 (vector only) | waypoint (−50, −49) |
| 0.050 | 3 | Blow→Move | (0, 100) | 12 | 0.01 | collision on |
| 0.25 | 15 | Move | (−0.7, 98.0) | 156 | 20 | |
| 1.00 | 60 | Move | (−14.6, 56.5) | 172.5 | 95 | |
| 1.25 | 75 | Move | (−22.5, 32.9) | 165 | 100 (cap) | |
| 1.55 | | Move | (−32.6, 2.8) | 149 | | shot 1 |
| 1.75 | 105 | Move (braking) | (−37.9, −12.8) | 135 | 76.6 | |
| 2.50 | 150 | Move | (−47.2, −40.6) | 100.5 | 17.1 | |
| 3.05 | | Move/Wait | (−49.0, −46.0) | 93.7 | ~6 | shot 2; from ~3.1 s Move/Wait alternate |
| 4.55, 6.05, 7.55 | | hover | (−49.8, −48.5) | 90.6 | → 0 | shots 3–5 |
| 8.033 | | Leave | (−49.8, −48.5) | 90.6 | 0 | lifetime over, NoBullet |
| 8.50 | 510 | Leave | (−60.3, −48.4) | 270.6 | 45 | |
| 9.00 | 540 | Leave | (−95.8, −48.1) | 270.6 | 95 | |
| 9.267 | | →Exit | (−126.9, −47.8) | 270.6 | 123 | centre off screen (stand-in for IsGamePlayArea) |
| 9.283 | | Exit | | | | CallDisabled |

`--index 0` (`sims/st01_index0_blowback.txt`): blow-back to (0, 136.25) by 0.517 s, then the same approach; leaves
at 8.53 s, removed at 9.78 s.

## 6. Open points

- [?] Whether `LocalLateUpdate` runs on the spawn frame (Start on frame 2 vs 3).
- [?] Exact `IsGamePlayArea` bounds (collider size of St01 and the manager's screen bounds) → exit frame ±1–3.
- [?] `BulletFireAsync` internals for `st01_fire1` (aim, spread) — see the bullet/firing specs.
- [I] `localPosition` = sky coordinates (enemy parented to the in-game sky root).
