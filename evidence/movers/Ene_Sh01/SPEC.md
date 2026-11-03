# Ene_Sh01 — model spin on top of a route mover (Pf_Ene_Sh01)

Read-only study of `GameAssembly.dll`. `[I]` = inference, `[?]` = unknown. Frame/units: `../../air-route-events/SPEC.md`.
Disassembly `dis/all_methods.txt`; model `../Ene_St01/tools/movers_sim.py sh01`.

## 0. Where it is used

BG04: `ene_sh01_1a/_1b/_2a/_2b/_3a/_3a2/_3b/_3b2/_4a/_4b` (20/20/10/10/5/5/5/5/5/5 spawn events), BG08: `_4a/_4b` (10/10).
All **attribute 0 (non-stack)** with one route each (`move_sh01_<x>`), speed 100–120, lookAt 1, repeats 9 @ 0.2 s
(10 in a column). Events (fired by the route mover at `awakeRate`): `83 sh01_fire1_sel` (rate 0), and in `_3*`/`_4*`
`14 Speed` ramps (value0 30/120/80/180 at awakeRate 0/0.1/0.2/0.45). Spawn indexValue 1–4 (e.g. `_1a` 2, `_1b` 1,
`_2a` 3, `_2b` 4).

## 1. Fields

Static `RotateSpeedTable` (Vector3[5], `.cctor` 0x1CFF370), degrees per second:

| index | value | spin |
|---|---|---|
| 0 | (0, 0, 0) | none |
| 1 | (0, 0, +360) | roll +1 turn/s (about local z = nose axis) |
| 2 | (0, 0, −360) | roll −1 turn/s |
| 3 | (+360, 0, 0) | pitch +1 turn/s (about local x) |
| 4 | (−360, 0, 0) | pitch −1 turn/s |

`const RotateTime = 10` (unused). Instance: `_rotateTarget` 0x1B0, `_rotateBaseLocalRotation` 0x1B8,
`_rotateEuler` 0x1C8, `_rotateTableIndex` 0x1D4.
Prefab: `_rotateTarget` = `pf_ene_sh01/ene_sh01` (the mesh node, identity local rotation); `_modelTop` = `pf_ene_sh01`;
`_HitPoint` 20; `_deadBulletSelecter` `sh01_fired_sel`; mover `_lookAtUpdateSec` 2.

## 2. Code

```
ReStart (0x1CFF1C0):
    base
    _rotateTableIndex = (0 <= _indexValue < 5) ? _indexValue : 0          // _indexValue = spawn event indexValue
    _rotateEuler = 0
    if _rotateTarget == null: _rotateTarget = _modelTop;  if still null: _rotateTarget = transform
    _rotateBaseLocalRotation = _rotateTarget.localRotation
ProgressEvent(dt, n) (0x1CFEEB0):
    PawnEnemy.ProgressEvent(dt, n)                                        // route mover first
    if _rotateTarget != null and dt > 0:
        _rotateEuler += RotateSpeedTable[_rotateTableIndex] * dt
        _rotateTarget.localRotation = _rotateBaseLocalRotation * Euler(_rotateEuler)
```

(`_setupRotateByIndexValue` 0x1CFF6A0 and `_resolveRotateTarget` 0x1CFF570 repeat the same pieces; no other callers
traced.)

## 3. Interaction with the mover (for `Round1EventStack.cs`)

- **No motion code.** Position and root rotation come entirely from the non-stack `SplineMover` (route, lookAt 1,
  route events incl. `14 Speed` ramps). The class runs **after** the mover step, and only rotates the child mesh
  `ene_sh01` (cosmetic; colliders/muzzles on other nodes are unaffected [I]).
- Port hook: `PostStack(dt)` → `meshLocalEuler += table[index]·dt`. The route following itself is the general
  non-stack SplineMover path (not this class).
- Ends as the route mover ends (route end / duration / area), never by class code.

## 4. Simulated spin — BG04 `ene_sh01_1a` (t = 8 s, indexValue 2)

`sims/sh01_index2_spin.txt`: mesh roll −360°/s → local z euler 270° at 0.25 s, 180° at 0.5 s, 90° at 0.75 s, 0° at 1 s.
Path: the route `move_sh01_1a` (440 units +x, y and z weaving ±20) at 120 u/s ≈ 3.7 s across [I: non-stack route
placement relative to the spawn not traced here]; the spin is independent of it.

## 5. Open points

- [?] Whether the 0..4 indexValue convention is also used by other stages' Sh01 events (all seen are 1–4).
