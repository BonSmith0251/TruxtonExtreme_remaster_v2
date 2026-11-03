# Ene_Mn01h — Mn01 core with a 13-bit shield (Pf_Ene_Mn01)

This is a read-only study of `GameAssembly.dll`. It assumes `../../air-route-events/SPEC.md` (frame order, areas, end rules) and `../Ene_Mn01c/SPEC.md` (the bits).

- **Disassembly:** `dis/all_methods.txt` and `dis/fire_MoveNext.txt`, made with `../tools/pdis.py`. Its `mv.` labels are noise for pawn code, and so is a `S:` label right after a `call`.
- **Sim:** `mn01h_sim.py`, output in `sims/`.
- **Marks:** `[I]` = inference, `[?]` = unknown.

## 1. Where it appears

The definition `ene_mn0X` (model `Pf_Ene_Mn01`, objectName `Pf_Ene_Mn01`) has:
- **attribute 0**, so no event stack. Its only event, `17 CustomEvent`, is never executed.
- duration 60, position (0, 0, 15), moveSpeed 35 (unused), lookAt 0.

| Stage | Entry clips (t, x offset), idx 0 |
|---|---|
| BG06 | 103.5 (0), 107.5 (−50), 111.5 (+50), 115.5 (0), 263 (−40), 268 (+40) |
| BG08 | 303.5 (−80), 308.5 (+80), 313.5 (−40), 318.5 (+40), 323.5 (0) |

Database row Mn01 (`enemy-database.json`, applied by `PawnEnemy.SetRecords` 0x1D0F9C0): HP 40000, score 20000, **`_modelSize` Large**. That sets `_sizeType`, so the play area is **AreaL** (viewport −0.3..1.3, |z| < 112.85 at y = 0). The spawn line z = 110 is therefore inside the area. With Small (|z| < 91.7) the core would be removed on its first frame.

## 2. Fields

KnightEnemy → RookEnemy → PawnEnemyDD → PawnEnemy.

Static `_STARTPOS` = **110** (`.cctor` 0x1CFC810).

Prefab values:

| Field | Value | Use |
|---|---|---|
| `_summonNameStr` / `_summonEnemyCount` | `Pf_Ene_Mn01c` / **13** | the shield bits |
| `_slowLine` | **45** | z where the entry ends |
| `_slowWait` | **10 s** | maximum length of the slow drift |
| `_inCurve` | keys (0, 1, slope −1.040), (0.5023, 0.5011, slope −1.165), (1, 0, slope 0.040) | entry profile, non-weighted Hermite |
| `_spinCurve` | keys (0, 0, 0), (0.5021, 1, slope −0.028), (1, 0, 0) | extra spin bump |
| `_childRangeMin` / `_childRangeMax` | 15 / 25 | bit orbit radius |
| `_useBullet` | `mn01_fire1` | the one volley |
| `_shotWait` | 1 s | delay before the volley |
| `_muzzle` | transform 4313026266067498 | under `_modelTop` |
| `_modelTop` | transform 4256069497284392 | spinning model node |
| `_isChildrenSolidarity` | 1 | [?: RookEnemy use not traced] |
| `_HitPoint` | 100 | replaced by the database row [I] |

Runtime fields:

| Offset | Field | Offset | Field |
|---|---|---|---|
| 0x220 | `_localPosition` | 0x254 | `_velZ` |
| 0x22C | `_localEuler` | 0x258 | `_accZ` |
| 0x238 | `_spinSpeed` | 0x25C | `_summonStart` |
| 0x23C | `_spinTimer` | 0x260 | `_summonTimer` |
| 0x240 | `_spinFlag` | 0x264 | `_summonCount` |
| 0x244 | `_state` | 0x268 | `_summonState` |
| 0x248 | `_stateTime` | 0x26C | `_isSummonEnd` |

## 3. Code

```
ReStart(withPlay) (0x1CFC680):
    RookEnemy.ReStart; _childEnemies.Clear(); _token = mover.CreateLinkedToken()
    _localPosition = root.localPosition; _localPosition.z = 110            // x, y = spawn (definition + clip); z forced
    _localEuler = 0; _state = 0; _stateTime = 0
    _summonStart = false; _summonCount = 0; _isSummonEnd = false; _spinTimer = 0
InitializeToPlay (0x1CFC160): _useBT = BulletManager.GetTemplate("mn01_fire1")
LocalLateUpdate(dt) (0x1CFC220):                                           // class code BEFORE the base update
    if dt <= 0: return
    switch _state:
      0: _spinFlag = false; _summonStart = false; _summonState = 0; _spinSpeed = 32; _state = 1; _stateTime = 0
      1 (IN):   if _stateTime >= 1 and !_summonStart: _summonStart = true
                if _stateTime < 3: z = 45 + inCurve(_stateTime/3)·(110 − 45)
                else: _state = 2; _stateTime = 0; z = 45; _velZ = 0; _summonStart = true
      2 (SLOW): if _stateTime < _slowWait(10) and !_isSummonEnd:
                    _accZ = −2; _velZ = max(_velZ − 2·dt, −2); z += _velZ·dt          // drifts down, at most 2 u/s
                else: _accZ = −32; _state = 3; _stateTime = 0
      3 (OUT):  _velZ += _accZ·dt; z += _velZ·dt                                      // falls at −32 u/s²
    if _summonStart:
      _summonTimer += dt
      switch _summonState:
        0: _createChildren(); _summonCount++; _summonState = 1; _summonTimer = 0      // same frame as _summonStart
        1: if _summonTimer >= 4.5:
               _spinFlag = true; _spinTimer = 0
               SendChildEvent(2)                     // every bit: CommonEvent(2) → separate in 1 s
               _fire().Forget()                      // await DelaySecond(_shotWait 1); BulletFireAsync(_useBT, _muzzle) once
               _summonState = 3; _summonTimer = 0
        3: if _summonTimer >= 2: _isSummonEnd = true; _summonState = 4; _summonTimer = 0   // releases SLOW → OUT
    s = _spinSpeed (32)
    if _spinFlag: _spinTimer += dt; if _spinTimer > 2: { _spinTimer = 0; _spinFlag = false }
                  s += spinCurve(_spinTimer·0.5)·960                // spin burst up to +960 °/s, peak 1 s in, lasts 2 s
    _localEuler.y += s·dt; _localEuler.x += 0.3·s·dt; _modelTop.localEulerAngles = _localEuler   // visual only
    root.localPosition = _localPosition
    _stateTime += dt
    PawnEnemy.LocalLateUpdate(dt)                    // area flag; mover = SplineMover with no route (attribute 0)
    if !mover._isInGamePlayArea: CallDisabled()      // AreaL (Large): removal as soon as the root leaves it
_callDeadEffect (0x1CFC7E0):  SendChildEvent(0) (every bit separates now); RookEnemy._callDeadEffect
ChildDieCallback(pe) (0x1CFBF90): remove its DieCallback from pe; _childEnemies.Remove(pe)
```

### `_createChildren` (0x1CFC850)

```
KnightEnemy.CreateAllChildren()
    // 13 × InGameEnemyManager.GetEnemy("Pf_Ene_Mn01c", InGameManager._inGameEnemyRoot)
    //      → SetEnemyLayer(division) → child.ReStart(true) → _childEnemies.Add
step = 180/13
for i in 0..12:  c = _childEnemies[i]
    c.SetDisableAction(c.EndRoute)
    if c is Ene_Mn01c:
        a = ((Make01() − 0.5)·step + i/13·360 + 20)°;  R = Range(15, 25)
        c._parentTransform = root
        c._offsetFormation = (R·cos a, 0, R·sin a)
        c._localPosition = c.root.localPosition = (200·cos a, 0, 120·sin a)
        c._state = SHIELD; c._step = 0; c._stepWait = 0
        c.AddDieCallback(this.ChildDieCallback)
```

The bits' own motion (drift 1.8 s, dash, dock with SE 186, orbit at 60°/s clockwise, separate at 120·mass² u/s, tumble) is in `../Ene_Mn01c/SPEC.md` §5.

## 4. Movement summary

- **Player:** nothing in the class reads the player. The core moves only along z: x and y stay at the spawn.
- **Path:** entry from z = 110 to 45 over 3 s along `_inCurve`: fast at first (≈ −22 u/s), easing to almost 0.
- **Drift:** a slow fall at up to 2 u/s until the shield cycle ends.
- **Exit:** a −32 u/s² fall off the bottom.
- **Timing:** the shield cycle runs on `_summonTimer`, starting when `_stateTime` reaches 1 s. SLOW ends when `_isSummonEnd` is set:
  - creation + 4.5 s: separation order and spin burst;
  - + 1 s: volley and actual separation;
  - + 2 s after the order: summon end → OUT.

  So OUT starts ≈ 7.55 s after spawn. The 10 s `_slowWait` would only matter if the summon cycle stalled, and it cannot.
- **Kill:** if the core is killed, its bits separate at once. If all bits are killed first, the core still runs the same timeline: the timers do not look at `_childEnemies`.
- **End:** `CallDisabled` when the root leaves AreaL (z < −112.85 at y = 0, altitude-scaled). Death ends it too. The SplineMover duration (60 s) never comes into play [I: ≈ 10.5 s life].

## 5. Simulated run — BG06 `ene_mn0X`, first clip (t = 103.5, x = 0)

From `sims/mn01h_BG06_x0.txt`: 60 fps, bits with a seeded Python RNG, so the per-bit radius, mass and jitter are examples.

| t (s) | Core z | Event |
|---|---|---|
| 0.000 | 110.00 | spawn; frame 0 is state 0 |
| 0.5 | 99.77 | IN, inCurve |
| 1.0 | 89.55 | |
| 1.017 | 89.2 | `_createChildren`: 13 bits on the 200×120 ellipse, e.g. bit 0 at (188, 41) |
| 2.0 | 64.07 | bits drifting in, slowing |
| 3.017 | 45.00 | IN done → SLOW |
| 3.0–3.53 | 45 → 44.6 | bits dock one by one (SE 186), approach speeds 120–410 u/s |
| 5.517 | 41.0 | spin burst (`_modelTop` +960 °/s peak); `SendChildEvent(2)` |
| 6.517 | 39.0 | `mn01_fire1` volley from `_muzzle`; all 13 bits separate radially at 100–191 u/s |
| 6.80–8.10 | | the bits leave the play area, `CallDisabled` each |
| 7.55 | 36.95 | OUT |
| 8.5 / 9.0 / 9.5 / 10.0 | 20.9 / 0.8 / −27.2 / −63.3 | falling |
| 10.55 | −113.85 | `CallDisabled` (left AreaL) |

`--kill T` in the sim shows the death branch: every bit separates on the kill frame.

## 6. Mn01h vs the reconstruction

- `Assets\Truxton\*.cs` has no Mn01 handling. With attribute 0 and no routes, the generic fallback flies the model straight at its placement speed (35) along yaw 0, i.e. up, off the top.
- The C# hook should:
  1. replace the mover entirely: the state machine in §3, z only, AreaL exit;
  2. own the 13 Mn01c bits: §5 of the Mn01c spec, updated after the core each frame, reading the core's current position [I: pool order decides ±1 frame];
  3. fire `mn01_fire1` once at summon + 5.5 s;
  4. drive the cosmetic `_modelTop` spin.

## 7. Open questions

- [?] The order of the core's and the bits' LocalLateUpdate within a frame. A bit reads `parent.localPosition` live: this frame's or last frame's, ±1 frame, at most 0.4 u of core motion.
- [?] What `_isChildrenSolidarity = 1` does in RookEnemy (not traced). It may tie bit deaths or score to the core.
- [?] The content of bullet `mn01_fire1` and the muzzle direction. `_modelTop` spins, so the muzzle direction at the fire frame depends on `_localEuler`.
- [I] The spawn position is already set when `ReStart` reads `root.localPosition` (same assumption as the Mm01 study).
- [I] `RandomUtility.Make01` / `Range(float, float)` are uniform [0,1) / [min, max).
