# Ene_Sj01 — "food" escape mover (Pf_Ene_Su01, Pf_Ene_Sv01, Pf_Ene_Sj01)

Read-only study of `GameAssembly.dll`. `[I]` = inference, `[?]` = unknown. Frame/units: `../../air-route-events/SPEC.md`.
Disassembly `dis/all_methods.txt`, `dis/SplineMover_PlayPasue.txt`; model `../Ene_St01/tools/movers_sim.py sj01`.

## 0. Where it is used

| Stage | Definition / model | Spawns | Mover | Program |
|---|---|---|---|---|
| BG02, BG08 | `ene_sv01` / Pf_Ene_Sv01 | 42 / 28 | stack (attr 16) | the Sv01 U-turn program (air spec §5) |
| BG04, BG08 | `ene_su01`, `ene_su01_1` / Pf_Ene_Su01 | 118 / 3 | stack (attr 16) | `15 SplineMove move_su01` (200 units straight down, ±1 x wiggle), `8 Bullet su01_fire` (value1 0.4), `80 TaskWait 256`, `1000 FinishDestroy`; speed 50 |
| BG04 | `ene_sj01_02` / Pf_Ene_Sj01 | 1 event × 200 (repeats 199 @ 0.01 s) | non-stack (attr 0), 11 routes `move_sj01_*` | `80` (route events); speed 50, lookAt 20, offsetRange (100,0,60) |

BG04 spawns `ene_sj01_02` at 109 s and `ene_ml01` at 111 s: Sj01/Su01 are the food of **Ene_Ml01**.

## 1. Fields (no serialized class fields; prefab values are only base PawnEnemy)

`_state` 0x1B0 (int), `_stateTime` 0x1B4, `_wave` 0x1B8 (deg), `_waveRate` 0x1BC, `_awaySpeed` 0x1C0,
`_waveMult` 0x1C4, `_timeLimit` 0x1C8, `_parentDie` 0x1CC.
Prefabs: Sj01/Su01/Sv01 `_HitPoint` 20, `_deadExplosion` pf_eff_explposion04, `_deadBulletSelecter` `sj01_fired_sel`
(Sj01, Su01), Sv01 `_overplayDeadSound` 217.

## 2. Code

```
ReStart (0x1D01500):   base; mover.SetPlayPause(false); _timeLimit = 999; _parentDie = false
                       // _state and _stateTime are NOT reset here [?: pooled re-use]
LocalLateUpdate (0x1D01490):
    if IsPlayingState() and dt > 0:
        _stateTime += dt
        _moveState(dt)                                     // BEFORE the stack
        PawnEnemy.LocalLateUpdate(dt)                      // play-area flag + stack/route
CommonEvent(n) (0x1D01430):
    0: if _causeOfDeath == -1: _causeOfDeath = 111, _deathByPno = -1, _isExboostDead = false;  AddDead()   // eaten
    1: _state = 1                                          // escape now
    2: _timeLimit = 2; _parentDie = true                   // parent gone: escape once _stateTime > 2

_moveState(dt) (0x1D015A0):
  switch _state:
  0: _wave = U·90; _waveRate = U·20; _waveMult = 1; _awaySpeed = 60 + U·10       // re-rolled every frame
  1: mover.SetPlayPause(true)                              // _moverState = 4: stack + route stop [I: tasks too]
     localEulerAngles = (0, lp.x > 0 ? +90 : -90, 0)       // face away from the screen centre, horizontally
     _state = 2
  2: f = localRotation * Vector3.forward                   // (±1, 0, 0)
     zf = sin(_wave°) * 0.5 * _waveMult                    // values BEFORE this frame's update
     _wave += _waveRate + 20                               // degrees per FRAME (not dt-scaled)
     _waveMult *= 0.93;  _waveRate *= 0.95                 // per frame
     _awaySpeed = max(90, _awaySpeed + 4*dt)               // → 90 on the first frame, then +4 u/s²
     lp += (_awaySpeed*f.x*dt, _awaySpeed*f.y*dt, _awaySpeed*zf*dt)   // z wobble only from the wave
     if !InGameManager.IsGameArea(lp): _state = 3          // gameScreenArea ±0.15
  3+: CallDisabled(); if !_parentDie and _dieCallback: _dieCallback(this)
  if _state == 0 and _stateTime > _timeLimit: _state = 1
  _stateTime += dt                                         // second increment: _stateTime runs at 2× real time
```

Constants: 90 (0x34EC9A8), 20 (0x34E0BDC), 10 (0x34E0BD8), 60 (0x35F2CE0), 0.5 (0x34E0BC8), 0.93 (0x35F2CCC),
0.95 (0x35F2CD0), 4 (0x34E0BD4), −90 (0x35F2CFC). `GetPlayerPosition(0)` is read but unused.

## 3. Who sends CommonEvent (vslot 0x638)

| Sender | Call site | n |
|---|---|---|
| Ene_Ml01._foodEatCheck | 0x1DCABBF | 0 (eaten) |
| Ene_Ml01._foodGoAway, Ene_Ml01._moveState | 0x1DCADFE, 0x1DCC4EE | 1 (flee) |
| Ene_Ml01._callDeadEffect, Ene_Ml01._foodFadeAway | 0x1DCA5EE, 0x1DCACEE | 2 (parent died / fade) |
| KnightEnemy.SendChildEvent (Ene_Mn01h) | 0x1D0C2BC | 2 at spin, 0 at death (its own children) |

## 4. Interaction with the stack (for `Round1EventStack.cs`)

- **State 0 (normal): the class is inert.** The stack (Sv01, Su01) or the route mover (Sj01) moves the enemy
  exactly as in the air spec. `_timeLimit` 999 with the 2× clock fires only after 499.5 s alive: never in practice.
- States 1–2: runs **before** the stack each frame and **instead of** it (mover paused with `_moverState = 4`, so
  `EnemyMover.Progress` stops; `IsPausing` also blocks `_ProgressSpline`).
- End: state 3 → `CallDisabled` one frame after leaving gameScreenArea; no kill, no score. `_parentDie` suppresses
  the callback to Ml01.
- CommonEvent(2) escape delay: `_stateTime` counts 2·dt per frame since spawn, so the enemy flees on the next frame
  if it has lived > 1.0 s, else at 1.0 s of age.
- Port hook: `PreStack(dt)` with `if state == 0 → nothing`. Needs a `CommonEvent(n)` entry point that the Ml01 port
  calls. Without Ml01 (BG02 Sv01) nothing to do.

## 5. Simulated escape (`sims/sj01_escape_commonevent1.txt`)

Food at (40, 0, 30), CommonEvent(1) at t = 0, seed 1 (wave 12.1°, rate 16.9, away 67.6 → 90):

| t | pos (x, z) | speed | note |
|---|---|---|---|
| 0.017 | (40.0, 30.0) | – | state 1: pause mover, yaw 90 (+X, because x > 0) |
| 0.033 | (41.5, 30.16) | 90.0 | |
| 0.10 | (47.5, 32.1) | 90.3 | z wobble ±~1.5, decays ×0.93/frame |
| 0.50 | (84.0, 31.3) | 91.9 | |
| 1.00 | (130.4, 31.2) | 93.9 | |
| 1.333 | (163.5, 31.2) | 95.3 | outside x ≥ 163.0 → state 3 |
| 1.350 | | | CallDisabled |

BG02 Sv01 path (class inert): `../../air-route-events/sims/sv01_BG02.txt`.

## 6. Open points

- [?] `_state`/`_stateTime` are never reset by ReStart: a pooled instance re-used after an escape would start in
  state 3 (removed at once) unless the pool re-creates it. Not traced.
- [?] Whether running stack tasks (Sv01 ForwardMove, Su01 SplineMove) freeze under `_moverState = 4`
  (`_moveTypeUpdateAsync` "running" gate assumed, air spec §1).
- [?] Ml01's conditions for sending 0/1/2 (see an Ml01 spec).
