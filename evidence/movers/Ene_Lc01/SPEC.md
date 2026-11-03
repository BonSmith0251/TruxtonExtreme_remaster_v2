# Ene_Lc01 — BG06 ground tank (multi-turret); its own forward-drive state machine replaces the event stack

Read-only study of `GameAssembly.dll`. Ground conventions are in `../../ground-route-events/SPEC.md`. Disassembly: `dis/`. `[I]` = inference, `[?]` = unknown.
"Lc01" in the old gap list is this tank. The other name in that list, Si01, is the BG05 queen's satellite: `../Ene_Si01/SPEC.md`.

## 1. Identity and spawn

| Item | Value |
|---|---|
| Prefab | `Assets/OriginalRecovered/Pf_Ene_Lc01.prefab` |
| Components | `EnemyMover`, `Ene_Lc01`, `EnemySwapMarker`, 12× `EnemyCollisionModel`. Hierarchy `pf_ene_lc01`, tracks `pf_Lc01_parts_track_fr/fl/b`, batteries `pf_lc01_parts_battery01_xx`, … |
| Class | `Ene_Lc01 : PawnEnemyGround` |
| Definition | BG06 `default_Lc01`: attribute **1552** = EventStack 16 + InAreaStart 512 + SkipRestartCheck 1024; events = [**FinishWait**] only; routes []; placement speed 0, rotate 0 |
| Spawn | one clip, **ground**, 260–330 s, offset (0, 250, 4850) on the BG06 ground, rotate (0,180,0), index 0 |
| `Ene_Lc01` serialized | `_HitPoint 100` (core), not lock-on. `PartsList`: core (`_partsFlags 1`) + 12 parts C1–C3, L1–L4, R1–R4 (`_partsFlags 2`, break effect `pf_eff_explposion01`). |
| `_partsData` | [0] core muzzle, bulletNo 2, first 1.5 s, loop 1.5 s. [1–3] covers C1–C3: bulletNo 1, first 0.8/1.3/1.8 s, loop 3, open 0.5. [4–11] L/R: bulletNo 0, first 0/0.2/0.4/0.6, loop 1.5, open 0.5. |
| `_expData` | (explposion03 at 0 s, explposion05 at 2.1 s, explposion05 at 2.0 s) |
| Bullet names (`.cctor` 0x1DBE510) | `btNames` = lc01_fire1, lc01_fire3, lc01_firec, lc01_firec2 |

## 2. Constants

| Name | Value |
|---|---|
| MoveZ | −5 |
| StopZ | 15 |
| AccSpeed | 0.002 |
| DecSpeed | 0.005 |
| MaxSpeed | 0.05 |
| MinSpeed | 0 |
| DeadTime | 2 |
| ScaleTime | 0.6 |
| CraterScale | 1.95 |
| MoveDistanceZ | 430 |
| `MoveRange` (static, `.cctor`) | (0, 0, 430) |

## 3. State machines (`LocalLateUpdate` 0x1DBDCA0 = `PawnEnemyGround.LocalLateUpdate` 0x1D17CD0, then `_moveState` 0x1DBE730)

`ReStart` 0x1DBE210 → `Init` 0x1DBD540 sets:
- `_state` = StartWait(0), `_move` = MoveWait(0);
- `_speed` = `_rangeRate` = `_deadTimer` = `_expTimer` = `_scale` = 0, `_isCoreDead` = `_isDeadEnd` = false;
- `_turrets` = `_partsData.Length − 1` = 11; it also resets the covers and the explosion flags.

```
dt = InGameManager.DeltaTime
switch _state:
  StartWait(0): if _mover._isFinishDelay (the FinishWait has run, i.e. the stack started — InAreaStart: when the tank
                entered the ground display/range):  _lcStartPosition = transform.position (WORLD);  _state = Main(1)
  DeadWait(2):  _deadTimer -= dt; if <= 0: _state = EndWait(3), _move = None(-1), _speed = 0, _scale = _scaleTimer = 0,
                SetTankModel(false), SetCraterScale(), stop tank SE
  EndWait(3):   if _isCoreDead: _scaleTimer += dt; _scale = clamp01(_scaleTimer / 0.6) * 1.95; SetCraterScale()   // crater grows
if _state != StartWait:
  if !_isCoreDead && _causeOfDeath != -1 (core killed): _isCoreDead = true; _state = DeadWait; _deadTimer = 2.0;
                                                       _coreModel inactive; DestroyParts()
  if _isCoreDead: _expTimer += dt; each _expData whose _expTime <= _expTimer fires once (CreateFX)
  switch _move:
    MoveWait(0): sky = GetSkyRootPosition(transform.position, true)
                 if sky.z < MoveZ(-5) && !_isDeadEnd && !_isCoreDead: _move = MoveAcc, _speed = 0, tank SE 0x8E (loop)
    MoveAcc(1):  _speed = Math.Max(_speed + 0.002, 0.05)          // 0x202AAD0 IS Max  -> 0.05 at once
                 if _speed >= 0.05: _move = Moving(2)              //  (so "acceleration" lasts one frame)
    Moving(2):   sky = GetSkyRootPosition(...); if sky.z > StopZ(15) && !_isCoreDead: _move = MoveDec(3)
    MoveDec(3):  _speed = Math.Min(_speed − 0.005, 0)             // 0x202ACB0 IS Min  -> 0 at once
                 if _speed <= 0: _move = MoveWait, stop SE, play SE 0x8F (stop)
  if _speed > 0:                                                    // MoveTank, inline
     _rangeRate = clamp01(_rangeRate + dt * _speed)                 // 0.05 /s -> full range in 20 s of driving
     tread UV: offset.x += (old − new rangeRate) * 15               // _tankMaterial, TankRollID
     transform.position = _lcStartPosition + Lerp(0, MoveRange, _rangeRate)    // WORLD +z, up to 430 units
     if !_isDeadEnd && transform.position.z >= _lcStartPosition.z + 430 && _move != MoveDec:
          _move = MoveDec; _isDeadEnd = true                        // never drives again
  if _causeOfDeath == -1: MoveMuzzles(gm, dt)                        // 0x1DBDCC0: covers open/close (CoverAction), turret fire
  if !_isCoreDead: each destroyed cover counts down _turrets; at 0 -> InGameManager.Get5000(pos) (5000 bonus)
```

- **Motion summary.** The tank stands on the ground. When it has scrolled below sky z −5 it drives forward along world +z at 0.05·430 = **21.5 world units/s** (speed snaps on, see the Max/Min note).
- It stops once it is above sky z +15. The hysteresis band keeps it hovering in the middle of the screen while the ground scrolls under it.
- This repeats until it has covered 430 units in total (20 s of driving). Then `_isDeadEnd` stops it for good and it scrolls away with the ground.
- Its yaw stays the clip's 180 for its whole life; nothing rotates the root.
- **Not on the event stack.** The stack holds only a FinishWait, which freezes the stack (air spec §3.4) and serves as the start trigger. Removal is the ground rules (`PawnEnemyGround`), or `CallDisabled` after death; not traced here.
- **Max/Min.** As compiled, `MoveAcc` uses `Math.Max` (0x202AAD0: returns the larger) and `MoveDec` uses `Math.Min` (0x202ACB0). So acceleration and deceleration are instantaneous, not ramps of 0.002 and 0.005 per frame. [I: probably a swapped Min/Max in the source; the binary is what runs.]

## 4. Simulated motion (formula; the BG06 ground scroll rate is not traced here)

Let s be the ground scroll rate in sky units/s (the tank's sky z falls at s while parked).

- While driving, its sky z changes at about 21.5·k − s, where k is the world → sky scale of `GetSkyRootPosition` [?].
- If 21.5·k > s, the tank creeps up from −5 to +15, stops, scrolls back down to −5, and repeats.
- Each driving burst lasts about 20/(21.5·k − s) s (the −5 → +15 band is 20 sky units). Bursts repeat until the 430-unit budget is spent. The budget is 20 s of total driving time, independent of s.

| time since the stack started | event |
|---|---|
| 0 | `_lcStartPosition` = world position; parked (MoveWait) |
| when sky z < −5 | drive 21.5 u/s world +z (SE 142) |
| when sky z > 15 | stop (SE 143) |
| … | repeats |
| after 20.0 s of cumulative driving | `_isDeadEnd`: parked for good, scrolls off |

## 5. Does it need its own mover?

Yes. In the reconstruction, Lc01 must be a ground-enemy class hook (not `Round1EventStack`), with:
- start on stack start (InAreaStart);
- the sky-z hysteresis drive (−5 / +15);
- 21.5 u/s world-forward;
- the 430-unit budget;
- instant speed changes;
- the death sequence: 2 s DeadWait with three timed explosions, then the crater growing to 1.95 over 0.6 s;
- the cover turrets (MoveMuzzles) and the 5000 bonus when all 11 covers are destroyed.

## 6. Open questions

- `[?]` The world→sky mapping of `GetSkyRootPosition(pos, true)` and the BG06 scroll rate at 260–330 s are needed for a numeric path; a pioneer recording of BG06 260–330 s would settle it.
- `[?]` `MoveMuzzles` 0x1DBDCC0 / `coverAction.CoverAction` 0x1DD16E0: cover open angle `_openRotate`, fire rules — turret side, only summarised.
- `[?]` Removal: `PawnEnemyGround` off-screen rules after `_isDeadEnd`; SkipRestartCheck (1024) meaning.
