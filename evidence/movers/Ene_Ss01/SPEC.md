# Ene_Ss01 — player-centred orbit (Pf_Ene_Ss01)

Read-only study of `GameAssembly.dll`. `[I]` = inference, `[?]` = unknown. Frame/units: `../../air-route-events/SPEC.md`.
Disassembly `dis/all_methods.txt`, `dis/RookEnemy.txt`, `dis/InGameEnemyManager_localCallEnemy.txt`;
model `../Ene_St01/tools/movers_sim.py ss01`.

## 0. Where it is used

BG06 `ene_ss01`: 4 spawn events (t = 365, 383, 398, 408 s), clip offset (0,0,0), indexValue 0. Definition: attribute 16
(stack), program `[1001 FinishWait]`, speed **200** (`_currentSpeed`, used by the class), lookAt 1, **repeats 8 @ 0.0 s,
offset step 0** (9 instances per event).

## 1. Fields

Class: `Ene_Ss01 : RookEnemy : PawnEnemyDD : PawnEnemy`.
Statics (`.cctor` 0x1D06570): `maxDistance` 300, `minDistance` 50, `rollSpeed` −90 (°/s), `rollSeconds` 8,
`stopSeconds` 0.2, `turnSeconds` 0.5, `turnRotate` = `FromEulerRad(π, 0, 0)` (180° pitch).
Instance: `_muzzle` 0x1F8, `_bulletName` 0x200, `_bt` 0x208, `_offsetAngle` 0x210, `_rotateAngle` 0x214,
`_length` 0x218, `_rollSeconds` 0x21C, `_targetPlayer` 0x220 (−1 in .ctor), `_isFired` 0x224, `_actstate` 0x228.
Prefab: `_muzzle` = `pf_ene_ss01/ene_ss01/muzzle` (0, 0, 8.47); `_bulletName` **shot06**; `_modelTop` = `pf_ene_ss01`;
`_HitPoint` 100; `_isLockonTarget` 0; `_deadExplosion` pf_eff_explposion01; RookEnemy `_children` **[]**.

## 2. Code

```
InitializeToPlay (0x1D05FF0): base; _bt = InGameBulletManager.GetTemplate(_bulletName)
ReStart (0x1D060F0):
    _token = mover.CreateLinkedToken(); RookEnemy.ReStart()            // spawns prefab _children (none here)
    if HasChildObject():                                               // leader of a ring
        _targetPlayer = GetNearestPlayerIndex(screen pos); step = 360/childCount; _offsetAngle = 0
        k-th child (if Ene_Ss01): child._targetPlayer = _targetPlayer; child._offsetAngle = k*step   (k = 1..)
    elif _targetPlayer == -1: _targetPlayer = 0; _offsetAngle = 0
    _length = 300; _modelTop.localRotation = identity; _rotateAngle = 0; _rollSeconds = 8; _actstate = 0; _isFired = false
LocalLateUpdate(dt) (0x1D060B0): ActionMove(dt); PawnEnemy.LocalLateUpdate(dt)        // class BEFORE the stack

ActionMove(dt) (0x1D05840, jump table 0x1D05F14):
  if _targetPlayer == -1: return
  pl = GetPlayerSkyPosition(_targetPlayer)
  switch _actstate:
  0 Starting : _actstate = 1
  1 Forward  : _length -= dt * mover._currentSpeed
               if _length <= 50: PlayQue(bg1_ene_ss_01 = 186); _actstate = 2; _length = 50
  2 Rolling  : _rotateAngle += -90*dt; _rollSeconds -= dt; if _rollSeconds <= 0: _rollSeconds = 0.2; _actstate = 3
  3 StopFire : _rollSeconds -= dt; if <= 0: _actstate = 4; _rollSeconds = 0
  4 Turn     : _rollSeconds += dt
               _modelTop.localRotation = Lerp(identity, turnRotate, clamp01(_rollSeconds/0.5))    // model flips nose-back
               if _rollSeconds >= 0.5: _rollSeconds = 0.2; _actstate = 5
               elif _rollSeconds >= 0.5/3 and !_isFired:
                   if _bt: mover.BulletFireAsync(token, _bt, false, false, _muzzle, null, offsetAngle=_rotateAngle, 0).Forget()
                   _isFired = true
  5 Back     : _length += dt * mover._currentSpeed; if _length >= 300: _actstate = 6
  6 Done     : _targetPlayer = -1; CallDisabled(); return                 // removed, no transform write
  // common tail 0x1D05970 (all states but Done)
  a = _rotateAngle + _offsetAngle                                         // degrees, math angle: 0 = +X, 90 = +Z
  SetLocalPositionAndRotation((pl.x + Cosf(a)*_length, pl.y, pl.z + Sinf(a)*_length), Euler(0, -90 - a, 0))
```

`Cosf/Sinf` = VectorUtility 0.1° tables. The yaw `−90 − a` keeps the nose (+Z) on the player at all times.
`SetOffsetAngle` (0x1D06550) / `SetTargetPlayer` (0x1D06560) have no direct callers.

## 3. Interaction with the stack (for `Round1EventStack.cs`)

- The stack is `FinishWait` only (frame 1), so rule 2 and area-exit never apply. The class runs **before** the stack
  and **instead of** any stack motion: it writes the absolute position every frame, **relative to the live player
  position** (it follows the player).
- Speed comes from the mover: `_currentSpeed` = placement 200 (+range +speedStep, clamp [1e-4, 999]).
- Port hook: `PreStack(dt)`; ends by `Done → CallDisabled` (not a kill) after
  Forward 1.25 s + Rolling 8 s + StopFire 0.2 s + Turn 0.5 s + Back 1.25 s ≈ 11.25 s.
- **Repeats.** Ring offsets come only from RookEnemy children. `_localCallEnemy` (0x1CD6CD0) makes later
  *placements* children of placement 0 only when the placement `attributeFlag & 1` (here 0), and the definition has a
  single placement. So the 9 repeat instances all get `_offsetAngle = 0`, the same `_targetPlayer` (0) and identical
  timing: they overlap exactly [I: from code; verify against a recording of BG06 at 365 s].

## 4. Simulated path — BG06 t = 365 s, player (0,−49) fixed, speed 200

`sims/ss01_BG06_t365.txt` (t since spawn):

| t | state | pos (x, z) | radius | angle a | yaw | event |
|---|---|---|---|---|---|---|
| 0.017 | Forward | (300, −49) | 300 | 0 | 270 | placed 300 right of the player |
| 0.50 | Forward | (203.3, −49) | 203.3 | 0 | 270 | 200 u/s inward |
| 1.267 | →Rolling | (50, −49) | 50 | 0 | 270 | sound 186 |
| 1.50 | Rolling | (47.1, −65.7) | 50 | −19.5 | 289.5 | clockwise (below the player first) |
| 2.50 | Rolling | (−16.7, −96.1) | 50 | −109.5 | 19.5 | |
| 3.50 | Rolling | (−47.1, −32.3) | 50 | −199.5 | 109.5 | |
| 9.267 | →StopFire | (50, −47.7) | 50 | ≈ −720 | ≈ 270 | 2 full turns |
| 9.483 | →Turn | (50, −49) | 50 | −720 | 270 | |
| 9.650 | Turn | | | | | fire shot06 (offsetAngle −720) |
| 9.983 | →Back | (50, −49) | 50 | | 270 | model pitched 180° |
| 10.50 | Back | (150, −49) | 150 | | 270 | 200 u/s outward |
| 11.267 | Done | (300, −49) | 300 | | | CallDisabled |

## 5. Open points

- [?] The 9 coincident instances per spawn (see §3); the recording should show whether they really stack.
- [?] `BulletFireAsync` meaning of `offsetAngle = _rotateAngle` (−720 ≡ 0 here).
- [?] Sound/animation side of `Turn` beyond the `_modelTop` lerp.
