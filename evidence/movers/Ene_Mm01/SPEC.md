# Ene_Mm01 (Pf_Ene_Mm01): the split gate. Native movement spec

This is a read-only study of `GameAssembly.dll`. The disassembly is in `dis/all_methods.txt` (`../tools/pdis.py Ene_Mm01 ""`). The model is `mm01_sim.py`, and its output is in `sims/`.
Coordinates are on the sky plane: x right, z up the screen, y toward the camera, yaw about +Y. `[I]` marks an inference and `[?]` an unknown. Everything else is read from code.

## 0. Summary

Ene_Mm01 moves itself completely. The `EnemyMover` adds no motion, for two reasons:
- All Mm01 definitions have no events and no routes.
- `EnemyData.attribute` is 0, so bit 16 (`_isEventStackPlay`, set in `EnemyMover.CreateRouteData` 0x1D6C750) is clear and the event stack never runs.

The mover runs only `SplineMover.Progress` → `_ProgressSpline` (0x1D44AE0). With no spline, that only counts `_durationPassTime`. The mover's single effect is a backstop: an `EndRoute` after `EnemyData.duration` = 60 s.

Each frame, Ene_Mm01 does this:
- writes `root.localPosition` (the pawn transform `+0x50`, which is the mover root: the pawn and the mover are on the same GameObject);
- writes `_left` and `_right` (two child halves under `_modelTop`), including their localEuler spin;
- sets `_modelTop.localRotation` (identity or yaw 90).

The clip spawn index `_indexValue` (+0x94) selects one of six behaviours.

## 1. Fields

### Statics (`.cctor` 0x1DCF830)

| Static | Value |
|---|---|
| InTime | 1.0 |
| InWait | 1.0 |
| SafeTime | 0.6 |
| CloseSECall | 0.9 |
| CloseTime | 1.0 |
| WaitTime | 0.5 |
| OutTime | 1.5 |
| PostWaitTime | 0.5 |
| AwaySpeed | 60 u/s |
| InSpinCount | 2 |
| OutSpinCount | 2 |
| SoloAway | 1.0 |
| laserPointMax | 32 |
| rotateV | `Euler(0, 90°, 0)` |

`DefaultPosition`, indexed by BehaviorType:
- [0] Horizon (0, 0, 200)
- [1] Vertical (0, 0, 200)
- [2] Up (0, 0, 120)
- [3] Down (0, 0, −120)
- [4] Left (−180, 0, 0)
- [5] Right (180, 0, 0)

### Instance values (ctor 0x1DCFDD0 defaults, then Pf_Ene_Mm01 prefab)

| Field | Value | Note |
|---|---|---|
| `_inWidthH` | **160** | not serialized, ctor default |
| `_outWidthH` | **115** | prefab; ctor 90 |
| `_inWidthV` | **120** | not serialized, ctor default |
| `_outWidthV` | **65** | prefab; ctor 30 |
| `_offsetZ` | 0 | |
| `_curveIn` (Hermite, weightedMode 0) | (0, 1, slope −0.75605) → (1, 0, slope −1.79899) | 0.5 → 0.630 |
| `_curveOut` | (0, 0, slope 1.00520) → (1, 1, slope 0.43878) | 0.5 → 0.571 |
| `_left` | pf_ene_mm01_left, local (−10, 0, 0) | |
| `_right` | local (+10, 0, 0) | |
| `_modelTop` parent | Models | |
| `_HitPoint` | 100 | |
| PartsList | two parts, "left" and "right" (`_partsFlags` 18, BreakEffect pf_eff_explposion03) | |
| `_laserCollision1/2` | laser collision models | |
| `_burner` | 4 particle systems | |
| `_muzzles` | 4 particle systems | |

### ReStart (0x1DCD120)

```
_state = INIT(0); _passedTime = 0; _entryWait = 0; _seID = -1
_behaviorType = Enum.IsDefined(BehaviorType, _indexValue) ? _indexValue : 0
PawnEnemy.ReStart(withPlay)
lp = root.localPosition                      // [I] the spawn position, already placed by the entry code
_startOffset = (lp.x, 0, lp.z)
_laserLength = lp.y                          // the clip/definition y is the distance between the halves (combined types only)
_left.localRotation = _right.localRotation = identity
root.localPosition = DefaultPosition[clamp(_indexValue, 0, 5)]     // parked off screen until INIT runs
_leftRot = _rightRot = 0; _laserEnable = false; _laserSubject = true; _siblingDead = false; _dieEntry = _isClosed = false
laser collisions get attribute 0x40; UV animations Setup; SetLaserEffectEnable(false)
```

## 2. Frame hook (`LocalLateUpdate` 0x1DCCF10)

```
if _dieEntry: AddDead()                      // vslot 0x2F8, both halves broken
PawnEnemy.LocalLateUpdate(dt)                // sets in-area flag, runs the mover (SplineMover.Progress only: duration counter)
if mover.IsPlayStart() (moverState 2 or 4) and IsAlive(): _StateExec(dt)    // AFTER the mover
```

`_StateExec` (0x1DCDE30) does the following:
1. Steps both UV animations.
2. On the ending phase, it calls `_stopSE()`.
3. It dispatches on `_state` (jump table 0x1DCF5E4).
4. Most states fall into the common tail at 0x1DCEB00: `_setLaserCollision(); _passedTime += dt`.

States read `_passedTime` before this frame's increment. A transition writes `_passedTime = 0`, and the tail then adds dt, so the next state starts at dt.

## 3. State machine

`p = _passedTime` at frame start. "x" below is `_tpos.x`.
- `_right.localPosition = (x, 0, 0)` and `_left.localPosition = (−x, 0, 0)`, both under `_modelTop`.
- `_lerpPos(pt, max, st, ed)` (0x1DD0030): `x = (ed − st)·clamp01(pt/max) + st + 10`.
- `_calcPos(pt, max, rate, cv, flip)` (0x1DCF730): `x = cv.Evaluate(pt/max)·rate·(flip ? −1 : 1) + 10`.

| State | Code | Behaviour |
|---|---|---|
| 0 INIT | 0x1DCDF87 | If the nearest player's `PlayerControll.IsDisableControll()` (dead/respawning [I]): `_entryWait = SafeTime 0.6`, return (re-armed every such frame). Else if `_entryWait > 0`: `_entryWait −= dt`, return. Else branch on `_behaviorType` (table 0x1DCF634), then `EnePartsGroup.Wakeup()` for flagged parts and Stop on all burners. |
| → Horizon | 0x1DCE0CB | state 1; `_modelTop.localRotation = identity`; `ps` = sky position of the nearest player; `_orgPos = (0, 0, ps.z)`; `x = _inWidthH + 60 = 220`; `SetupHV` |
| → Vertical | 0x1DCE1C6 | state 8; `_modelTop.localRotation = rotateV` (yaw 90: local +x → world −z); `_orgPos = (ps.x, 0, _offsetZ = 0)`; `x = _inWidthV + 10 = 130`; `SetupHV` |
| → Up / Down / Left / Right | 0x1DCE2BE / 327 / 390 / 3E7 | `SetupCombinedBehavior(state 15/16/17/18, dir back(0,0,−1) / forward(0,0,1) / right(1,0,0) / left(−1,0,0), rot identity / identity / rotateV / rotateV)` |
| 1 H0 (slide in) | 0x1DCE521 | `_lerpPos(min(p, 1), 1, st = _inWidthH + 20 = 180, ed = _outWidthH 115)`: x 190 → 125 in 1 s, then holds. At `p ≥ InWait + InTime = 2` → state 2. |
| 2 H1 (close) | 0x1DCE5C6 | `pt = min(p, 1)`; `_calcPos(pt, 1, 115, _curveIn)`: x 125 → 10. Spin `s = clamp01(pt/1/0.92)`: `_left.localEuler.x = (2·360 + 90)·s = 810·s`, `_right.localEuler.x = −720·s`. `_checkJointSE(pt)` (SE, 0x1DCFD10). At `pt ≥ 1` → `_siblingDead ? 7 : 3`. |
| 3 H2 (joined) | 0x1DCE760 | At `min(p, 0.5) ≥ 0.5`: `PlayCh(seID, SE 0x93)`, state 4, `_laserEnable = true`, burners Play. Killing it in this state pays `Get5000` (OnPartsBreak). |
| 4 H3 (open with laser) | 0x1DCE831 | `pt = min(p, 1.5)`; `_calcPos(pt, 1.5, 115, _curveOut)`: x 10 → 125. Un-spin once `u = pt/1.5 ≥ 0.08`: `s = 1 − (u − 0.08)/0.92`, left.x = 810·s, right.x = −720·s. At `pt ≥ 1.5`: state 5; `_velZ = (nearest player (by screen) sky z ≥ _orgPos.z) ? +1 : −1`; burners Stop. |
| 5 H4 | 0x1DCEAB1 | At `min(p, 0.5) ≥ 0.5` → state 6 |
| 6 H5 / 13 V5 | 0x1DCF246 | → 19 AWAY (same frame, tail runs) |
| 7 H6 (solo away) | 0x1DCEB21 | `pt = min(p, SoloAway 1)`; `x = 10 − curveOut(pt)·(_inWidthH + 40 = 200)`; right → x, left → −x (the survivor crosses to the far side, 10 → −190). At `p ≥ 1`: `EndRoute()` (vslot 0x5F8) + `CallDisabled()` (0x308). |
| 8 V0 | 0x1DCEC72 | `_lerpPos(min(p, 1), 1, st = _inWidthV 120, ed = _outWidthV 65)`: x 130 → 75. At `p ≥ 2` → 9 |
| 9 V1 | 0x1DCED0F | as H1 with rate `_outWidthV 65` (x 75 → 10); end → `_siblingDead ? 14 : 10` |
| 10 V2 | 0x1DCEEA6 | as H2 → 11 (laser on, burners) |
| 11 V3 | 0x1DCEF74 | as H3 with rate 65 (x 10 → 75); end: `_velZ = (player sky x ≥ _orgPos.x) ? +1 : −1`, state 12 |
| 12 V4 | 0x1DCF1F6 | PostWait 0.5 → 13 |
| 14 V6 (solo away) | 0x1DCF255 | `_calcPos(min(p, 1), 1, _inWidthH 160, _curveOut, flip = true)`: x = 10 − 160·curveOut; at `p ≥ 1` EndRoute + CallDisabled |
| 15–18 UP/DOWN/LEFT/RIGHT | 0x1DCF2C5 | `root.localPosition += _moveDirection·dt`. Remove (EndRoute + CallDisabled) when `z > 120` or `z < −120` or `x < −180` or `x > 180` (the `DefaultPosition[2..5]` bounds), tested after the step. |
| 19 AWAY | 0x1DCF509 (= `_awayMove` 0x1DCF650 inlined) | `_orgPos.z` (Horizon) or `_orgPos.x` (others) `+= _velZ·60·dt`; `root.localPosition = _orgPos`; if `!IsGamePlayArea()` (vslot 0x228) → EndRoute + CallDisabled |

### `SetupHV` (0x1DCDAE0)

```
_left.localPosition = (x, 0, 0); x = −x; _right.localPosition = (x, 0, 0)   // swapped for this one frame; H0/V0 overwrites next frame
root.localPosition = _orgPos; _seID = Play(SE 0x91)
```

### `SetupCombinedBehavior` (0x1DCD830)

```
_state = s
root.localPosition = DefaultPosition[i] + _startOffset          // the spawn's x/z offsets shift the start; y = 0
_moveDirection = dir · mover._currentSpeed                     // placement moveSpeed (+U[0, range)), read now
_modelTop.localRotation = rot
_left.localPosition = right·_laserLength·(−0.5); _right.localPosition = right·_laserLength·0.5
_laserEnable = true; _seID = Play(SE 0x93)
```

Facing never follows travel. The only rotations are the `_modelTop` choice (identity or yaw 90) and the halves' pitch spin (local Euler x) during close/open.

## 4. Damage and parts (motion side)

`OnPartsBreak(parts)` (0x1DCCFA0):
```
_stopSE()
other = GetPartsInfo(parts == 0)
if other is broken (+0x9A):
    _dieEntry = true                                   // pawn removed next LocalLateUpdate (AddDead)
    if _state is 3 or 10 (joined): InGameManager.Get5000(position, _deathByPno)
else:
    _siblingDead = true
    other.SendDamage(clamp(other.LeftHp − 1, 0, max))  // the survivor drops to 1 HP
    other.SetDamageEffect(true)
```
- `_siblingDead` turns the end of close (state 2/9) into the solo-away state 7/14 instead of joining.
- It also stops the laser drawing: `_setLaserCollision` requires `_laserEnable && !_siblingDead`.
- If the sibling dies after the join, the H/V sequence continues as normal.

Other effects:
- `GetHormingTarget(i)` returns the position of collision model `i & 1` when there is more than one, so homing shots alternate between the halves.
- Once `_laserEnable` is set it is never cleared in `_StateExec`. The laser stays on through H4/AWAY until removal [I].

## 5. End conditions

1. H/V: AWAY leaves the play area. `IsGamePlayArea` (HybridCollisions 0x1DDF760) is "any collision model has its in-area flag +0x40 set". The rect used by HybridCollisionManager is `[?]`; the sims use gameScreenArea at y=0, collider centre = half position.
2. Solo away: 1 s after the close finishes with one half dead.
3. Combined: past the `DefaultPosition` bound in its direction.
4. Both parts broken: `AddDead`.
5. Backstop: `SplineMover._ProgressSpline` with no spline gives `rate = _durationPassTime/duration`. At 60 s, with no routes and `_isEndRouteKeep` false, it calls `EndRoute` (0x1D44E53).
6. The stack rules from `../../air-route-events/SPEC.md` §3 do **not** apply, because this is not a stack mover.

## 6. Simulated paths (`mm01_sim.py`, 60 fps, player fixed at (0, −49))

**BG05 `ene_mm01h`** (idx 0 Horizon, clip t = 55 s), `sims/mm01h_BG05_t55.txt`:
- INIT at frame 0: root (0, −49).
- H0: halves at ±174.8 (0.25 s), ±158.6 (0.5), ±142.3 (0.75), ±126.1 (1.0), then hold ±125 until 2.017 s.
- Close: ±107.2 (2.25), ±85.7 (2.5), ±57.6 (2.75), ±16.7 (3.0), joined ±10 at 3.017 s.
- Joined until 3.533 s.
- Open with the laser: ±26.4 (3.75), ±48.7 (4.0), ±71.2 (4.25), ±92.4 (4.5), ±110.3 (4.75), ±123.2 (5.0), ±125 at 5.05 s.
- PostWait until 5.567 s. AWAY from 5.583 s, with `velZ` +1 because player z = orgPos z: z −40 at 5.75, 5 at 6.5, 50 at 7.25, 91 at 7.93 s.
- Removed at 7.93 s (top edge).

**BG05 `ene_mm01v`** (idx 1 Vertical, t = 300), `sims/mm01v_BG05_t300.txt`:
- Root (0, 0); halves at z ±130 → ±75 by 1 s.
- Close at 3.017 s, open 3.53 → 5.05 s (±75).
- AWAY to +x at 60 u/s from 5.58 s; removed at about 8.3 s, x ≈ 163.

**BG05 `ene_mm0A`** (idx 2 Up, speed 20, clip off (0, 150, 0), loop offset x −40), `sims/mm0A_BG05_t33_up.txt`:
- Root (−40, 120) moving (0, −20)/s; halves at x = −40 ± 75 (laser 150 wide) for the whole flight.
- z 100.3 at 1 s, 0.3 at 6 s, −99.7 at 11 s.
- Removed at 12.02 s, z −120.

## 7. For the C# host (per-model hook)

1. Do not run the event stack for Mm01, and treat `duration` as a 60 s backstop only.
2. On the first LateUpdate in which the mover is playing, run INIT. Freeze the player-relative anchor at that moment: z for H, x for V.
3. Drive root plus two half offsets from the table above, after the mover step.
4. The halves are separate collision/part targets.
5. The `_indexValue` (clip spawn index) must reach the hook.
6. For combined types, the spawn's local y must also reach the hook, as the laser length.

## 8. Open questions

- `[?]` The rect behind `HybridCollisionModel` +0x40 (IsGamePlayArea), which sets the AWAY exit frame (±1–3 frames).
- `[I]` The entry code places the spawn position before `ReStart` reads it: `_startOffset` and `_laserLength` depend on this. The data agrees: `ene_mm0A` clips carry y = 150.
- `[?]` `mover._currentSpeed` `speedStep` (rank) term for the combined speed.
- `[?]` `PlayerControll.IsDisableControll` semantics. It is assumed to be true while the player is dead or respawning; then INIT waits 0.6 s after control returns.
- `[?]` The exact SE timing in `_checkJointSE` (CloseSECall 0.9) was not traced. It is sound only.
