# Ene_Mk01 (Pf_Ene_Mk01): carrier that steps through 9 straight LUT legs, always facing the player

This is a read-only study of `GameAssembly.dll`. The frame and units are those of `../../air-route-events/SPEC.md` §0:
- sky plane: x right, z up the screen;
- yaw about +Y, 0 = +Z.

`[I]` marks inference and `[?]` marks an unknown.

Files:
- Disassembly: `dis/all_methods.txt`, `dis/move.txt` (`_move`), `dis/ReStart.txt`, `dis/rotate_target.txt` (`RotatePlayer`, `SetTargetPlayer`), `dis/child_fire.txt` (`SetChildTarget`, `_fire`), `dis/repulsion.txt` (`_childRepulsion`, `GetLocalPosition`).
- Wrapper: `pd.py`.
- Model: `mk01_sim.py`, with outputs in `sims/`.

## 1. Class, fields, constants

`Ene_Mk01 : RookEnemy : PawnEnemyDD : PawnEnemy`. Its child objects (`RookEnemy._childObjects`) are the **Ene_Si01** pawns created from the extra placements (`objectName Pf_Ene_Si01`).

| Item | Value | Source |
|---|---|---|
| `_MoveInterval` (static) | 1.0 s (wait between legs) | .cctor 0x1DC8F30 |
| `_TargetTurnTime` (static) | 1.0 s | .cctor |
| `FireTime` (const) / `BulletName` | 2 s / `"mk01_fire1"` | const, ReStart |
| `_routeNamesA` | `move_mk01a_01 … 09` | .cctor |
| `_routeNamesB` | `move_mk01b_01 … 09` | .cctor |
| `_routeNames` | `[A, B]`, indexed by the pawn's spawn index `_indexValue` (+0x94) | .cctor, ReStart |
| `_muzzle` | prefab muzzle node | prefab |
| `_HitPoint` | 100 | prefab |
| `_children` | `[]` | prefab |
| `_isChildrenSolidarity` | 1 | prefab |
| mover `_lookAtType` | 0 | prefab |
| Runtime fields | `_fireTimer` 0x200, `_targetPlayer` 0x210, `_moveState` 0x214 (0 Entering, 1 Forward, 2 Wait, 3 Leaving), `_initialSpeed`/`_moveSpeed` 0x218/0x21C, `_waitTime` 0x220, `_rotateTime` 0x224, `_rotateAngle` 0x228, `_routeList` 0x230, `_routeData` 0x238 (enumerator), `_spawnPosition` 0x240, `_routeOffset` 0x24C, `_splineStartPosition` 0x250, `_routeLutAsset` 0x260 | |

### Route LUTs

Source: `Assets\OriginalRecovered\InGame\RouteLUT\move_mk01?_0n.asset`. Every route has two points, `_t = [0, 1]`, and starts at (0, 0, 0). The table gives the end point of each leg.

| Leg | a end | b end | Length |
|---|---|---|---|
| 01 | (0, −120) | (0, −120) | 120 |
| 02 | (−35, 40) | (35, 40) | 53.15 |
| 03 | (70, −20) | (−70, −20) | 72.80 |
| 04 | (−70, −20) | (70, −20) | 72.80 |
| 05 | (70, 0) | (−70, 0) | 70 |
| 06 | (−70, 20) | (70, 20) | 72.80 |
| 07 | (70, 20) | (−70, 20) | 72.80 |
| 08 | (−35, −40) | (35, −40) | 53.15 |
| 09 | (0, 120) | (0, 120) | 120 |

Route b mirrors route a in x. The legs sum to zero, so the carrier ends where it spawned.

## 2. Frame order and the mover

`LocalLateUpdate` (0x1DC8400):

```
base.LocalLateUpdate(dt)    // in-area flag, then the mover updaters (EnemyMover.Progress)
_move(dt)
_childRepulsion()
```

The pawn code runs **after** the mover in the same frame.

The mover never moves the transform. Mk01 has no move events, and `_move` writes `transform.localPosition` and `localRotation` directly every frame of Forward. The BG05 definitions have `attribute 16` (EventStack) and **no events**, so the stack is on but empty. That raises the question in §7.

## 3. ReStart (0x1DC8440)

```
RookEnemy.ReStart(withPlay)
_initialSpeed = _moveSpeed = mover._currentSpeed            // placement moveSpeed 30 (+U·range); [I] set before ReStart
_moveState = Entering; mover.ClearToStart(); CreateToken()
_routeList = [InGameRouteManager.GetData(n) for n in _routeNames[_indexValue]]   // SplineRouteData: _length 0x18, RouteName 0x20
_routeData = _routeList.GetEnumerator()
_rotateTime = 0; _rotateAngle = 0
SetTargetPlayer(gm, immediate=true)                          // _rotateTime = _TargetTurnTime (1): first turn is a snap
SetChildTarget(_targetPlayer, immediate=true)
_bt = BulletManager.GetTemplate("mk01_fire1"); _fireTimer = 0
```

The clip index selects the route list: `ene_mk01a` uses idx 0 → A, and `ene_mk01b` uses idx 1 → B. An index ≥ 2 would throw.

## 4. `_move` (0x1DC9CF0) and helpers

```
switch _moveState:
 Entering(0): if !_routeData.MoveNext(): _moveState = Leaving; return
              _routeOffset = 0; TryGetRouteLut(Current.RouteName, out _routeLutAsset)
              _splineStartPosition = lut ? lut.EvaluatePosition(0) : 0
              _spawnPosition = transform.localPosition; _moveState = Forward; return      // no turn / fire this frame
 Forward(1):  _routeOffset = min(_routeOffset + _moveSpeed*dt, Current._length)
              u = InOutSine01(_routeOffset / Current._length)                 // 0.1° Cosf table
              p = lut ? lut.EvaluatePosition(u) : Vector3.zero                // no LUT -> stands at _spawnPosition
              transform.localPosition = p - _splineStartPosition + _spawnPosition   // route NOT rotated
              RotatePlayer(gm, dt)
              if _routeOffset >= Current._length:
                  if !_routeData.MoveNext(): _moveState = Leaving
                  else: (same set-up as Entering for the next route; _spawnPosition = current lp); _waitTime = 0; _moveState = Wait
              _fire(dt)
 Wait(2):     _waitTime += dt
              if _waitTime >= _MoveInterval (1): SetTargetPlayer(gm, false); SetChildTarget(_targetPlayer, false); _moveState = Forward
              RotatePlayer(gm, dt); _fire(dt)
 Leaving(3):  CallDisabled()     (vslot 0x308)  -> removed, not a kill
```

- **Leg timing.** A leg takes `length / _moveSpeed` (120 at 30 u/s = 4.0 s). The `_moveSpeed` value is fixed at ReStart: Speed events, which are absent anyway, would not change it.
- **Leg shape.** Each leg starts and ends at rest (InOutSine), followed by a 1 s stop. The leg start is the stopped position.

### RotatePlayer (0x1DC8920)

```
_rotateTime = clamp(_rotateTime + dt, 0, 1); k = InQuad01(clamp01(_rotateTime / 1)) = k²
d = GetPlayerSkyPosition(_targetPlayer) - GetSkyRootPosition(transform.position)
a = atan2(d.x, d.z)*57.29578 - _rotateAngle;  a = Repeat(a, 360) (clamped 0..360);  if a > 180: a -= 360
_rotateAngle += clamp01(k) * a
transform.localRotation = Euler(0, _rotateAngle, 0)            // absolute, replaces the placement yaw 180
```

- **Turn speed.** While `_rotateTime` reaches 1 (1 s after a retarget) it closes **all** of the remaining angle every frame: it locks onto the player. Before that, each frame closes a fraction k = (t/1 s)².
- **When the smoothed turn happens.** Re-targeting happens at the end of every Wait, with `immediate = false` (`_rotateTime = 0`). So the smoothed 1 s turn covers the first second of each leg from leg 2 on.
- **First frames.** At spawn, `immediate = true`. On the first Forward frame (frame 2) the nose snaps from yaw 180 to the player bearing. `_rotateAngle` starts from 0, not 180.

### SetTargetPlayer (0x1DC8DB0)

```
_targetPlayer = GetNearestPlayerIndex(GetScreenPosition(transform.position, IsGround()))
_rotateTime = immediate ? 1 : 0
```

### SetChildTarget (0x1DC8BA0)

```
i = 0; for c in _childObjects: if c is Ene_Si01: c.SetTargetAndParent(i++, player, this, immediate)
```

The Si01 behaviour itself is in `Ene_Si01` and is not covered here.

### `_childRepulsion` (0x1DC9940)

```
for every pair i < j of Si01 children: si[i].Repulsion(si[j])
```

### `_fire` (0x1DC9C00)

```
if !IsCancelToken: _fireTimer -= dt; if _fireTimer <= 0: _fireTimer += 2;
    BulletFireAsync(mover, CToken, _bt "mk01_fire1", true, true, _muzzle, 0, ...).Forget()
```

- `_fire` runs only in Forward and Wait.
- The first shot is on the first Forward frame (t = 1/60 s). After that it fires every 2.0 s, independent of legs.

### Other methods

- `GetLocalPosition(w)` = `transform.InverseTransformPoint(w)` (used by the Si01 [I]).
- `GetRouteNames` builds the preload list from `_routeNames`.
- `HitBlink` override: visual only.

## 5. End

1. **Normal end.** After leg 9 there is no next route, so the state becomes Leaving. On the next frame `CallDisabled` removes it. With route a/b at 30 u/s this happens at **31.78 s** after spawn, back at the spawn point.
   - Leg time: 4 + 1.77 + 2.43·2 + 2.33 + 2.43·2 + 1.77 + 4 = 23.6 s.
   - Stops: 8 × 1 s.
   - Entering frame: one frame.
2. **Killed** (HP 100). `_isChildrenSolidarity 1` links the Si01 children [I: the RookEnemy rules].
3. See §7 for the stack question.

## 6. BG05 spawns and the simulated path

Both definitions spawn at (0, 0, 150), placement yaw 180, speed 30, lookAt 1, attribute 16, duration 60, with 10 Si01 child placements at offsets (20…−20, 0, −30).

| Definition | Clip offset | Spawn | Clip time | Index | Routes |
|---|---|---|---|---|---|
| `ene_mk01a` | (−30, 0, 0) | (−30, 0, 150) | 252 s | 0 | A |
| `ene_mk01b` | (30, 0, 0) | (30, 0, 150) | 272 s | 1 | B |

`sims/mk01a_BG05.txt`, player at (0, −49):

| t (s) | x, z | yaw | |
|---|---|---|---|
| 0.000 | −30, 150 | 180 | Entering (route a_01, length 120, 4.00 s) |
| 0.017 | −30, 150 | 171.43 | snap to the player; Bullet #1 |
| 0.5 / 1.0 / 1.5 / 2.0 | −30, 145.75 / 133.01 / 113.73 / 90.84 | 171.2 / 170.6 / 169.6 / 167.9 | InOutSine descent; on screen from about 2.0 s (z < 91.7) |
| 2.017 | −30, 89.16 | 167.75 | Bullet #2 |
| 3.0 / 3.5 / 4.0 | −30, 48.10 / 34.85 / 30.00 | 162.8 / 160.3 / 159.2 | leg 1 done |
| 4.0–5.0 | −30, 30 | 159.2 | Wait (Bullet at 4.017); retarget at 5.017 |
| 5.5 / 6.0 / 6.8 | −35.65, 36.46 / −50.03, 52.89 / −65, 70 | 157.8 / 153.9 / 151.4 | leg 2 (a_02, 1.77 s) |
| … | (5, 50) → (−65, 30) → (5, 30) → (−65, 50) → (5, 70) → (−30, 30) | | legs 3–8, each followed by a 1 s stop |
| 27.77–31.77 | −30, 30 → −30, 150 | 159 → 171 | leg 9 (up, 4 s) |
| 31.78 | −30, 150 | | Leaving → CallDisabled |

The b route is the mirror image from (30, 150) (`sims/mk01b_BG05.txt`).

## 7. Open questions

- **[?] Stack end rule versus Mk01.** BG05 `ene_mk01a/b` have attribute 16 (EventStack) and **zero events**. Air-SPEC rule 2 removes an enemy when `idx ≥ count`, there are no EndCheck tasks and `!_isInGamePlayArea`. Mk01 at z = 150 is outside every area rect, including AreaW, whose limit at y = 0 is z < 141. So that rule would EndRoute it on its first LateUpdate, before `_move` runs.
  - Mk01's own logic (32 s of legs ending in Leaving → CallDisabled) shows the designer did not expect that.
  - Not found yet: an `IsPlaying` gate, a start delay, `_sizeType`, or the clip's world offset that keeps it alive.
  - **The port should not apply rule 2 to Mk01** until the pioneer confirms it. The same question applies to every pawn-driven enemy with an EventStack definition and an empty or exhausted program that spawns off screen.
- **[I] Speed timing.** `_moveSpeed` is read at ReStart. It assumes `UpdateObjectData` has already set `_currentSpeed` = 30. If ReStart ran first, a pooled pawn would carry the previous speed.
- **[I] LUT evaluation.** `RouteLutAsset.EvaluatePosition(u)` is assumed to be piecewise linear over `_t`, which is exact for these two-point legs. `SplineRouteData._length` is assumed to be the straight length.
- **[?] Si01 children.** How the Si01 use `SetTargetAndParent` and `Repulsion` (their formation, firing and when they detach) is not covered here.
