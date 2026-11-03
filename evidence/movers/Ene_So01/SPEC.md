# Ene_So01 — brake, charge, dash (Pf_Ene_So01)

Read-only study of `GameAssembly.dll`. `[I]` = inference, `[?]` = unknown. Frame/units: `../../air-route-events/SPEC.md`.
Disassembly `dis/all_methods.txt`, `dis/PawnEnemy_ProgressEvent.txt`, `dis/IsGamePlayArea_SetInArea.txt`;
model `../Ene_St01/tools/movers_sim.py so01`.

## 0. Where it is used

| Stage | Definition | Spawn events | Position / offsetRange | Placement |
|---|---|---|---|---|
| BG01 | `ene_so01_1` | 30 | (−35,0,100) + U·(70,0,20) | rot y 180 (down), speed 100, repeats 7 @ 0.3 s |
| BG01 | `ene_so01_2` | 8 | (−35,0,−120) + U·(70,0,10) | rot y 0 (up), repeats 3 @ 0.3 s |
| BG05 | `ene_so01_1/_2/_1c` | 10/5/5 | `_1c`: (−75,0,100) + U·(150,0,20) | as above |
| BG08 | `ene_so01_1/_1c` | 1/4 | | |

All: **attribute 0 (non-stack), no events, no routes**, lookAt 1, duration 60. Clip offsets e.g. (±80,0,0).
`_offsetRange` is `RandomUtility.Range(v)` = per-axis **U[0,1)·v** added to the position (`EnemyPlacementData.get_Offset`
0x1D35760). The placement speed (100) is **not used**: the class sets its own speed.

## 1. Fields

Statics (`.cctor` 0x1D03510): `InSlowStartTime` 0.35, `ChageTimeMax` 1.0, `_awayAccel` 480, `_awayMaxVel` 240.
Instance: `_chargeEffeect` 0x1B0, `_fireEffeect` 0x1B8, `_localPosition` 0x1C0, `_waitTime` 0x1CC, `_speed` 0x1D0,
`_state` 0x1D4, `_playerIndex` 0x1D8.
Prefab: `_chargeEffeect` / `_fireEffeect` = two ParticleSystems; `_modelTop` = `pf_ene_so01`; `_HitPoint` 100;
`_isLockonTarget` **0**; `_deadExplosion` pf_eff_explposion01.

## 2. Code

```
GetStart (0x1D03390):  base; _localPosition = localPosition; _playerIndex = GetNearestPlayerIndexInWorld(pos); _state = 0
CallDisabled (0x1D03350): _objectInfo.(vslot 0x1F8)() [I: StopParticles]; base
ProgressEvent(dt, n) (0x1D034D0): PawnEnemy.ProgressEvent(dt, n)   // mover first (does nothing, see §3)
                                  _moveState(dt)                    // AFTER the mover

_moveState(dt) (0x1D035E0):
  switch _state:
  0 (0x1D03A68): _objectInfo.(vslot 0x1F8)(); _speed = 60; _waitTime = 0; _state = 1          → MOVE
  1 (0x1D03A0E): if IsGamePlayArea(): _waitTime += dt; if _waitTime >= 0.35: _state = 2        → MOVE
  2 (0x1D03806): _speed -= 60*dt                                     // brake 60 u/s²
                 if _speed <= 0: _waitTime = 0; _speed = 0 (one 8-byte store); _chargeEffeect.Play(); _state = 3
                 → AIM → MOVE
  3 (0x1D03748): _waitTime += dt
                 if _waitTime >= 1.0: for every collision model: SetAttribute(NoHitBullet 32)
                                      _chargeEffeect.Stop(); _fireEffeect.Play(); _state = 4
                 → AIM → MOVE
  4 (0x1D036DB): _speed = min(_speed + 480*dt, 240)
                 if !mover._isInGamePlayArea: _state = 5                 → MOVE
  5+ (0x1D0368A): CallDisabled(); return                                // removed, no move
AIM (0x1D0384F):
  p  = GetSkyRootPosition(position); t = GetPlayerSkyPosition(_playerIndex) - p      // 3D
  localRotation = LookRotation(Vector3.RotateTowards(transform.forward, t, 2*dt rad, 0), up)   // ≤ 114.6°/s
MOVE (0x1D03AA3):
  if _speed >= 0: _localPosition += transform.forward * _speed * dt
  localPosition = _localPosition                                        // every frame, overrides anything else
```

`IsGamePlayArea()` (`HybridCollisions` 0x1DDF760) = any hit collider has `_isInBetweenArea` (set by
`HybridCollisions.UpdateCollisions` from collider bounds vs the collision manager's screen bounds) [I: ≈ "collider
on screen"]. `mover._isInGamePlayArea` = `IsInGameAreaWorld(pos, gameScreenAreas[size])` set in
`PawnEnemy.LocalLateUpdate` just before `ProgressEvent` (Small: viewport −0.15..1.15).

## 3. Interaction with the mover (for `Round1EventStack.cs`)

- attribute 0 → `EnemyMover.Progress` runs `SplineMover.Progress` (no stack). With no spline `IsSplineMove()` is
  false: no transform write, no events (none exist). `_ProgressSpline` still counts `_durationPassTime` against
  `duration` 60 and would `EndRoute` at 60 s [I]; the enemy is gone after ~4 s.
- So the class runs **after** the (empty) mover step and **instead of** it: it owns position and rotation.
- Port hook: `PostStack(dt)` (or `Instead`), with `inPlay` sampled before the hook; no stack interpretation, and
  **no end-of-program rule 2** for this non-stack enemy.
- Speed path: 60 (cruise) → brake 60 u/s² over 1.0 s (30 units) → 0 for 1.0 s (charge) → 480 u/s² to 240 (0.5 s,
  60 units) → straight dash. Turning only during brake + charge (≤ 114.6°/s, toward the player's current position);
  the dash direction is the facing at dash start (no tracking afterwards). During the dash the colliders get
  `NoHitBullet` (player shots pass through [I]).

## 4. Simulated path — BG01 `ene_so01_1` first spawn (t = 35 s, clip (80,0,0)), seed 1 offset → spawn (54.41, 0, 116.95), player (0,−49)

`sims/so01_1_BG01_t35_clip80.txt` (IsGamePlayArea approximated by "centre inside viewport 0..1").

| t | state | pos (x, z) | yaw | speed | event |
|---|---|---|---|---|---|
| 0.017 | 1 | (54.4, 115.95) | 180 | 60 | |
| 0.50 | 1 | (54.4, 86.95) | 180 | 60 | |
| 1.117 | 1→2 | (54.4, 49.95) | 180 | 60 | on screen 0.35 s → brake |
| 1.333 | 2 | (52.2, 38.6) | 202.9 | 48 | turning to the player |
| 1.50 | 2 | (48.7, 32.4) | 210.9 | 38 | facing the player |
| 2.117 | 2→3 | (42.7, 22.3) | 210.9 | 0 | charge effect |
| 3.133 | 3→4 | (42.7, 22.3) | 210.9 | 0 | NoHitBullet, fire effect |
| 3.333 | 4 | (38.2, 14.8) | 210.9 | 88 | |
| 3.667 | 4 | (8.8, −34.3) | 210.9 | 240 | |
| 3.950 | 4→5 | (−26.1, −92.6) | 210.9 | 240 | left gameScreenArea |
| 3.967 | 5 | | | | CallDisabled |

## 5. Open points

- [?] Exact `_isInBetweenArea` bounds and update order (state 1 start, ±a few frames).
- [?] What `_objectInfo` vslot 0x1F8 is (assumed StopParticles; called in state 0 and in CallDisabled).
- [?] So01 has no bullet code of its own: its "attack" is the body dash (and whatever the particle systems imply).
