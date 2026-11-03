# Ene_Mn01c — Mn01 shield bit (Pf_Ene_Mn01c, Pf_Ene_Mn01c2)

This is a read-only study of `GameAssembly.dll`. It builds on `../../air-route-events/SPEC.md`: the event stack, the frame order and the end rules 1–6 are described there.

- **Disassembly:** `dis/all_methods.txt` and `dis/LocalLateUpdate_full.txt` (the metadata gives LocalLateUpdate a length of 0x38; the real body runs to 0x1CFA689). Both were made with `../tools/pdis.py`. Its `mv.` labels and any `S:` label on a load just after a `call` are noise: there `[rax]` is the call's result, not a static field.
- **Companion:** `../Ene_Mn01h/SPEC.md` describes the Mn01 core that spawns 13 of these bits as its shield.
- **Marks:** `[I]` = inference, `[?]` = unknown. Everything else is read from code.

## 1. Who uses the class

| Prefab | Script | Differences | Database row (`enemy-database.json`) |
|---|---|---|---|
| `Pf_Ene_Mn01c` | Ene_Mn01c | `_deadExplosion pf_eff_explposion01`, scale 1 | key Mn01c: HP 2500, Small, lock-on |
| `Pf_Ene_Mn01c2` | Ene_Mn01c (same script 878479225) | `_deadExplosion pf_eff_explposion04`, **root scale 0.5** | key Mn01c2: HP 1, Small, breakthrough, no lock-on |

The serialized fields are the same in both prefabs: `_model` = child transform 4587765826080250 (the mesh node that tumbles), and `_attachSE 186` (`bg1_ene_ss_01`, played when a bit docks on the core).

Uses in the stages (each definition has attribute 16, so the event stack runs):

| Definition | Stage | Model | Clip `idx` | Program |
|---|---|---|---|---|
| `ene_mn01_bit2` | BG01 wave clips t=115–129 | Mn01c2 | **0** | RotateT snap (intValue1 1), RotateR ±5°, ForwardMove 10 s, TaskWait 256, FinishDestroy; speed 240, lookAt 1 |
| `ene_mn01_bit2` | BG01 t=272–275 and entry clips t=275–351 | Mn01c2 | **2** | same |
| `ene_mn01_bit2` | BG06 t=3–23 and 123–132; BG08 t=340–375 | Mn01c2 | **2** | same |
| `ene_mn01_bit` | BG06 t=66–84 and 178–220 | Mn01c | **1** | RotateT snap, RotateR ±1°, ForwardMove 10 s (intValue1 360) [?: not read by ForwardMove in the ground spec], TaskWait 256 (dotime 30), FinishDestroy; speed 50, lookAt 1 |
| Summoned (no definition) | BG06, BG08 | Mn01c | pool object | `Ene_Mn01h._createChildren` drives it (§4) |

The clip `idx` becomes the pawn's `_indexValue` (InGameCollisionBase +0x94).

## 2. Fields and constants

Statics (`.cctor` 0x1CFAF70):

| Static | Value | Used for |
|---|---|---|
| `_DecelerationSpeed` | 20 | SHIELD step 1: `speed −= 20·mass·dt` |
| `_AccelerationSpeed` | 400 | SHIELD step 2: `speed += 400·mass·dt` |
| `_SeparateSpeed` | 120 | AWAY velocity `= dir·mass·120` |
| `_MassMin` / `_MassMax` | 0.9 / 1.3 | `_mass = Range(0.9, 1.3)` at ReStart |
| `_ParentGapSize` | 5 | dock overshoot cap |
| `_AppearTime` | 1.8 s | SHIELD step 1 length |
| `_RotateIn` | 2 | tumble factor in SHIELD and FALL |
| `_RotateOut` | 10 | tumble factor in AWAY |

Instance fields (offsets):

| Offset | Field | Offset | Field |
|---|---|---|---|
| 0x1B0 | `_model` | 0x1EC–0x1F0 | `_offsetFormation` (0x1E8) |
| 0x1BC | `_state` | 0x1F4 | `_localPosition` (root local position cache) |
| 0x1C0 | `_step` | 0x200 | `_vel` |
| 0x1C4 | `_stepWait` | 0x20C | `_speed` |
| 0x1C8 | `_spinRate` | 0x210 | `_spinSpeed` (60) |
| 0x1CC | `_sepaTimer` | 0x214 | `_spinAngle` |
| 0x1D0 | `_sepaDone` | 0x218 | `_mass` |
| 0x1D1 | `_isRanged` | 0x21C | `_localRotate` |
| 0x1D8 | `_toParentCallback` (never set) | 0x22C | `_spin` |
| 0x1E0 | `_parentTransform` | | |

STATE: 0 INIT, 1 FREE, 2 SHIELD, 3 AWAY, 4 GATHER, 5 FALL.

## 3. Lifecycle and frame order

```
Initialize (0x1CFA540):  base; _state = INIT
ReStart(withPlay) (0x1CFA6B0), on every spawn from the pool:
    _state = FREE; _step = 0; _stepWait = 0; _sepaTimer = 0; _sepaDone = false; _spinRate = 1
    _spinSpeed = 60; _spinAngle = 0; _mass = Range(0.9, 1.3); _localRotate = identity
    _spin = Euler(sx·a, sy·b, sz·c)    a, b, c = RandomUtility.Range(int 90, int 180) (integer degrees 90..179 [I: max exclusive])
                                       sx, sy, sz = MakeSign() (±1)
    if _indexValue != 0:                                    // the spawn-clip index
        _state = FALL; _step = 999; _isRanged = false; _spinRate = 2·_indexValue
    PawnEnemy.ReStart(withPlay)                             // the mover / event stack starts as usual
LocalLateUpdate(dt) (0x1CFA560):
    if _state == INIT: return                               // nothing, not even the base update (the mover does not run)
    switch _state:
      FREE:   –
      SHIELD: _shieldModeState(dt)
      GATHER: _gatherModeState(dt)
      AWAY:   _awayModeState(dt); if !IsGamePlayArea(): CallDisabled()
      FALL:   _shieldModeState(dt)                          // step 999: tumble only (§5)
              if _isRanged: { if !IsGamePlayArea(): CallDisabled() }
              else if IsGamePlayArea(): _isRanged = true
    if _sepaTimer > 0: _sepaTimer −= dt; if _sepaTimer <= 0 and !_sepaDone: _sepaDone = true; ToSeparate()
    PawnEnemy.LocalLateUpdate(dt)                           // AFTER the class code: area flag, then the EnemyMover stack
```

- **Play-area test.** `IsGamePlayArea` (HybridCollisions vslot 0x228, 0x1DDF760) is true when any of the pawn's collision objects has its in-play-area byte (+0x40) set. That byte is written by the collision system [?: the exact rect and update point; a root-in-`gameScreenArea` test, Small, matches it to ±1 frame [I]].
- **`CallDisabled`** is vslot 0x308, an immediate removal.

**CommonEvent(num)** (0x1CFA510), sent by the parent through `KnightEnemy.SendChildEvent`:

| num | Effect |
|---|---|
| 0 | `ToSeparate()` now |
| 1 | nothing |
| 2 | `_sepaTimer = 1` → `ToSeparate()` 1 s later |

**ToDestroid** (killed): calls `_toParentCallback` if set (it is never set), then `PawnEnemy.ToDestroid`. The parent learns of the death through the DieCallback it registered (Ene_Mn01h.ChildDieCallback).

## 4. FREE and FALL: the stage-placed bits (definitions with the event stack)

### FREE (`idx` 0: BG01 wave clips, Mn01c2)

The class does nothing. Motion, facing and end come entirely from the EnemyMover stack. Sim: `../../air-route-events/sims/mn01c2_BG06.txt` (idx ignored there):
- RotateT instant snap to the player, rounded to 1°;
- RotateR ±5°;
- ForwardMove at 240 u/s;
- area exit (rule 1) after entering.

### FALL (`idx` ≠ 0: BG01 entry clips, BG06, BG08)

These are the "bits with a non-zero spawn index". The stack still moves the root exactly as in FREE. The class adds two things, and neither changes the path:

1. **Tumbling of `_model`.** Every frame, in the class code (before the stack step):
   ```
   _localRotate = _localRotate · SlerpUnclamped(identity, _spin, dt · _RotateIn(2) · _spinRate)
   _model.localRotation = _localRotate
   ```
   - The rotation is about the fixed random axis of `_spin` at `ω = θs · 2 · _spinRate` per second, where `θs` is the rotation angle of `_spin`.
   - Over the ±(90..179)° Euler draws, θs has median 84° (10%–90%: 52°–116°; full range 3°–177°).
   - Mn01c `idx 1` (spinRate 2): ω = 4·θs, median ≈ 340°/s.
   - Mn01c2 `idx 2` (spinRate 4): ω = 8·θs, median ≈ 675°/s.
   - The root yaw (RotateT/RotateR) is untouched; the tumble is local to `_model`.
2. **Extra removal.**
   - `_isRanged` latches the first frame `IsGamePlayArea()` is true.
   - After that, the first LateUpdate with no collider in the play area calls `CallDisabled`. This runs before the stack's rule 1 in the same frame, so the bit ends on whichever fires first.
   - With colliders at the root it is the same frame as rule 1 ±1 [I]. A bit that never enters is not removed by this rule (rules 1–6 still apply).

`spinRate = 2·idx` is the only use of the index. idx 1 and idx 2 differ only in tumble speed.

Example: BG06 `ene_mn01_bit`, first clip (t=66, off (−50,0,0), idx 1), from `air_sim.py BG06.json ene_mn01_bit --clip -50,0,0`, player (0,−49), offsetRange draw 0:
- spawn (−110, 0, 120);
- RotateT snap 147°, RotateR → 147.8°;
- ForwardMove at 50 u/s:

| t (s) | 0.5 | 1.0 | 2.0 | 3.0 | 4.0 | 5.0 |
|---|---|---|---|---|---|---|
| (x, z) | (−96.7, 98.9) | (−83.3, 77.7) | (−56.7, 35.4) | (−30.0, −6.9) | (−3.4, −49.2) | (23.3, −91.5) |

It is removed at 5.02 s at (24.2, −92.9) by area exit. The `_isRanged` rule fires in the same frame ±1 [I]. Throughout, `_model` tumbles at ≈ 4·θs °/s.

## 5. SHIELD → GATHER → AWAY: the summoned shield (no event stack)

`Ene_Mn01h._createChildren` (0x1CFC850) writes these fields directly (it does not call `Setup`; `Setup` 0x1CFA8E0 does the same and is otherwise unused):

```
_parentTransform = core root
_offsetFormation = (cos a · R, 0, sin a · R)                 R = Range(15, 25)
_localPosition   = root.localPosition = (200 · cos a, 0, 120 · sin a)
    // under InGameManager._inGameEnemyRoot, the same frame as the core [I]
    // a = 20° + i·360°/13 + (Make01() − 0.5)·180°/13, i = 0..12   (x = cos, z = sin: counter-clockwise from +x)
_state = SHIELD; _step = 0; _stepWait = 0
```

So the 13 bits appear on an ellipse with semi-axes 200 (x) and 120 (z) around the sky origin. That is mostly off screen; the visible area is ±125 × ±70. Each bit then flies to its own slot on a ring of radius 15–25 around the core.

### `_shieldModeState(dt)` (0x1CFB470), per frame

Here `P = parent.localPosition` (read live each frame, so it follows the moving core) and `T = P + _offsetFormation`.

```
step 0: step = 1; _speed = 50; _stepWait = 0                       // falls through into step 1 the same frame
step 1: _stepWait += dt
        if _stepWait >= 1.8: step = 2; _stepWait = 0; → tumble
        _speed = max(0, _speed − 20·mass·dt)                        // 50 → 50 − 36·mass at 1.8 s (17.6 … 3.2)
        d = T − _localPosition
        if |d| > 0.001 and mass·_speed·dt > 0:
            _vel = normalize(d)·_speed
            if |d| > mass·_speed·dt: _localPosition += _vel·mass·dt; root.localPosition = it; → tumble
            else: _localPosition = T; root.localPosition = it            // snap, no tumble this frame
        else: root.localPosition = _localPosition                   // no tumble
step 2: _speed += 400·mass·dt                                        // accelerates; effective speed is mass·_speed
        d = T − _localPosition
        if mass·_speed·dt >= |d|:                                    // arrives (no position write this frame)
            _vel = normalize(_vel) · min(mass·_speed/60, 5)          // overshoot offset, ≤ 5 units
            _state = GATHER; _step = 0; _spinAngle = 0; PlayQue(_attachSE 186); return
        _vel = normalize(d)·_speed; _localPosition += _vel·mass·dt; root.localPosition = it; → tumble
tumble (0x1CFBD5B): _localRotate = _localRotate · SlerpUnclamped(id, _spin, dt·2·_spinRate); _model.localRotation = _localRotate
```

- `_spinRate = 1` for a summoned bit, so it tumbles at 2·θs (median ≈ 170°/s) while it approaches.
- A pooled object's stale `_indexValue` would leave `_spinRate = 2·idx` [?].
- Typical timing: 1.8 s drifting at ≤ 50·mass u/s, then a 0.1–0.6 s dash. The bit docks 2.0–2.5 s after creation at 120–410 u/s.
- There is no area test in SHIELD, so bits that start off screen are not removed.

### `_gatherModeState(dt)` (0x1CFB130), per frame

```
_vel *= expf(−6·dt)                       // overshoot decays, time constant 1/6 s   [I: 0x57AD70 is the CRT expf]
_spinAngle += dt·_spinSpeed (60)
rot = Euler(0, _spinAngle, 0)
_localPosition = P + rot·(_offsetFormation + _vel); root.localPosition = it
_model.localRotation = rot · _localRotate                  // the tumble is frozen; the mesh turns with the orbit
```

- **Orbit:** the bit circles the core at radius R (15–25) at 60°/s, i.e. 6 s per lap. Positive yaw turns +Z toward +X, so the orbit is clockwise on screen.
- **Overshoot:** on arrival the bit jumps up to 5 units past its slot, then settles back.

### ToSeparate (0x1CFA9C0) and `_awayModeState(dt)` (0x1CFAC50)

```
ToSeparate:
    if _parentTransform == null: return
    v = (_state == GATHER) ? Euler(0, _spinAngle, 0)·_offsetFormation : _vel     // radial; or the current approach direction
    _vel = normalize(v)·mass·120
    _localPosition = root.localPosition; _state = AWAY; _toParentCallback = null; _parentTransform = null
AWAY (per frame):
    _localPosition += _vel·mass·dt; root.localPosition = it          // effective speed 120·mass², 97 … 203 u/s, straight
    _localRotate = _localRotate · SlerpUnclamped(id, _spin, dt·10·_spinRate); _model.localRotation = it   // ≈ 10·θs °/s
    then in LocalLateUpdate: if !IsGamePlayArea(): CallDisabled()
```

- **Mid-approach:** a bit separated while still in SHIELD keeps flying along its approach direction, toward the core and beyond.
- **No entry check in AWAY:** a bit that is outside the play area at the moment of separation (only possible in SHIELD) is removed on the next frame.

### When bits separate

| Trigger | Separation |
|---|---|
| Core's summon timer, 4.5 s after creation: `SendChildEvent(2)` | all bits, 1 s later (5.5 s after creation) |
| Core killed: `Ene_Mn01h._callDeadEffect` → `SendChildEvent(0)` | all bits, immediately |
| `CommonEvent(1)` | none |

The core's own path and the numbers for one run are in `../Ene_Mn01h/SPEC.md` §5 (`sims/mn01h_BG06_x0.txt` there). The separated bits fan out radially at 100–190 u/s and are all gone 0.3–1.6 s after separation.

## 6. Interaction with the EnemyMover stack

| State | Class writes | Stack |
|---|---|---|
| INIT | – | not run (base skipped) |
| FREE | nothing | full control (definition program) |
| FALL | `_model` local rotation only, plus the `_isRanged` exit | full control of root position and yaw; runs after the class code each frame |
| SHIELD / GATHER / AWAY | root `localPosition` every frame, `_model` rotation | the summoned bit has no route data and no stack [I: `CreateAllChildren` only calls `GetEnemy`, `SetEnemyLayer` and `ReStart`]; nothing overrides the class |

For the C# port:
- FREE/FALL are hooks after the stack's motion: tumble the model and apply the `_isRanged` exit.
- SHIELD/GATHER/AWAY replace the stack. They are driven by the Mn01h hook, which owns the 13 bits.

## 7. Open questions

- [?] The exact update point and rect of the collision in-play-area byte read by `IsGamePlayArea`. It decides the FALL/AWAY removal frame (±1).
- [?] Whether a pooled bit can keep a non-zero `_indexValue` when summoned. That would only change its tumble rate.
- [I] `RandomUtility.Range(int, int)` excludes the maximum (90..179).
- [I] `0x57AD70` = expf and `0x576BF0`/`0x578040` = cosf/sinf, from the call pattern shared with Ene_Sm01.
- [?] The parent-relative frame: the bits and the core are assumed to share `_inGameEnemyRoot`, so `parent.localPosition` and the bit's `localPosition` are in the same sky frame.
