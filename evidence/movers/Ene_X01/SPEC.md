# Ene_X01 (Pf_Ene_X01 / X02 / X03) — no motion code; route mode with Speed events; class code is bullets only

Read-only study of `GameAssembly.dll`. Route mode and awakeRate dispatch: `../Ene_Mp02/SPEC.md` §3 and `../Ene_Mx02/SPEC.md` §3. `[I]` = inference, `[?]` = unknown.
Sim: `../tools/m7_sim.py x01`.

## 1. Identity

| Prefab (`Assets/OriginalRecovered/`) | Stage, time | `_eneXType` | `_firePosRadius` | `_item` | HP |
|---|---|---|---|---|---|
| `Pf_Ene_X01` | BG01 `ene_x01`, 260–276 s | 2 (Third) | 28 | 10 | 40 |
| `Pf_Ene_X02` | BG02 `ene_x02`, 160–176 s | 1 (Second) | 24 | 9 | 40 |
| `Pf_Ene_X03` | BG07 `ene_x03`, 244–260 s | 0 (First) | 20 | 1 | 40 |

- Components (all three): `EnemyMover`, `PositionShift` (`_baseY 0, _targetY 0`: inert), `EnemySEPlayer`, `Ene_X01`, `EnemyCollisionModel`. All share the class `Ene_X01 : PawnEnemy`.
- Definitions (identical except names): attribute **0** (route mode), duration 100, position (0,0,150). Placement speed 50, rotate 0, **easeType 7**, lookAt 0. Routes `move_ene_x01_enter1`, `move_ene_x01_move_l`, `move_ene_x01_leave`.
- One spawn each, clip offset (0,0,0), index 0.

Route mode sorts the events by awakeRate:

| awake | event |
|---|---|
| 0 | Rotate(dotime 50, vec (1234,4567,7890), relative, linear) on the child `pf_ene_x0N` (model spin 24.7/91.3/157.8 °/s; visual) |
| 1.0 | Speed(10, 0.5) |
| 1.0 | Bullet `ene_x0N_fire1` (repeatCount 999, repeatDelay 0.5) |
| 2.0 | Speed(50, 0.5) |
| 2.0 | SetObjFlag 256 (NoBullet) |

Routes (BG01/BG02/BG07 JSON):

| route | points | length | shape |
|---|---|---|---|
| enter1 | 2 | 120 | (0,0) → (0,−120) |
| move_l | 63 | 128.4 | a closed weave: (0,0) → (−14.7,5.5) → (7.8,12.1) → (14.3,15.9) → (−2,19.9) → (−15,15.1) → (−0.1,10) → (14.9,4.8) → (0,0) |
| leave | 2 | 100 | (0,0) → (0,+100) |

## 2. What the class code does (no root motion)

| Method | RVA | Effect |
|---|---|---|
| `Initialize` | 0x1D09750 | `_mover._bulletFire = _onBulletFire` (replaces the default Bullet handler) |
| `_onBulletFire` | 0x1D0AB30 | `stringValue` starts with `"fan"` → `_startFanSequence`/`_fireFanByIndex`; otherwise `FireByRouteEvent` with `_onBulletGenerated` as the callback |
| `_onBulletGenerated` / `_registerBowFollower` | 0x1D0AD90 / 0x1D0AEE0 | `InGameBulletBow` shots that `RequiresFollow` are stored with their offset from the enemy |
| `LocalLateUpdate` | 0x1D097F0 | `PawnEnemy.LocalLateUpdate`, then `_updateBowFollowers` 0x1D0B260 (moves the followed bows with the enemy: `InGameBulletBow.SetPosition(GetSkyRootPosition(root) + offset)` [I: offset add], BowFollowSeconds 0.2), then `_updateFanSequence` 0x1D0B770 (FanSequenceIntervalSeconds 0.5, sequence names from the `.cctor` 0x1D09BC0: fan180, fan170, fan180, fan200, fan220, fan200, fan190, fan170, fan150, fan170; `bow_fan130 … bow_fan230`). Fires only while `IsGameBulletAreaWorld`. |
| `CallDisabled` / `ToDestroid` | 0x1D094D0 / 0x1D09880 | stop the fan sequence, clear the bows; `CallDisabled` also calls `InGameEnemyClipsManager.ResetEneXCounter` |

**Nothing in `Ene_X01` writes the enemy's own position or rotation.** Motion is the route mode below.

## 3. Motion (route mode, `SplineMover._ProgressSpline` 0x1D44AE0)

- enter1: 120 at 50 u/s, InOutSine by rate: 2.40 s from (0,150) to (0,30).
- Junction at 2.40 s. On the first frame of move_l, the events at awake 1.0 fire: Speed 50 → 10 over 0.5 s, and the Bullet loop starts (every 0.5 s while the player is in the bullet area).
- move_l: 128.4 at ≈10 u/s. The rate rises slowly, so the weave takes **11.8 s** (2.40 → 14.20), eased in and out. The enemy weaves ±15 in x and 0–20 in z around (0,30) and returns exactly to (0,30).
- Junction at 14.20 s: Speed 10 → 50 over 0.5 s and NoBullet (awake 2.0).
- leave: 100 up, rate starts at 10 u/s and reaches 50 u/s in 0.5 s. It leaves the top edge (z 91.7) at 15.57 s; route end → EndRoute at **16.40 s** at (0,130).
- The yaw stays 0 throughout (lookAt 0, `_firstRotate` = rotate 0). `duration 100` is unused (splineLength > 0).

## 4. Simulated path (`m7_sim.py x01`): BG01 t = 260 s

| t | x | z | speed |
|---|---|---|---|
| 0 | 0 | 150.00 | 50 |
| 0.5 | 0 | 137.60 | 50 |
| 1.0 | 0 | 105.53 | 50 |
| 1.25 | 0 | 86.02 | 50 (on screen from 1.18 s) |
| 1.5 | 0 | 67.04 | 50 |
| 2.0 | 0 | 38.04 | 50 |
| 2.4 | 0 | 30.00 | junction; Speed → 10, Bullet loop |
| 3.0 | −4.91 | 31.25 | 10 |
| 4.0 | −12.40 | 33.43 | 10 |
| 6.0 | 4.78 | 41.33 | 10 |
| 8.0 | −3.34 | 49.65 | 10 |
| 10.0 | 0.93 | 39.74 | 10 |
| 12.0 | 8.83 | 32.30 | 10 |
| 14.2 | 0 | 30.00 | junction; Speed → 50, NoBullet |
| 16.4 | 0 | 130.00 | EndRoute |

## 5. Reconstruction notes

- No per-model mover hook is needed. Route mode must apply:
  - per-route InOutSine easing by rate;
  - awakeRate Speed events. The slow weave is entirely due to Speed 10 at awake 1.0.
- With the generic constant-speed chain, the weave would take 2.6 s instead of 11.8 s.
- The bullet logic (bow followers, fan sequences) belongs to `Round1EnemyAttacks`.

## 6. Open questions

- `[?]` What `_eneXType` and `_firePosRadius` change (bullet origin radius and item / counter by type) — bullet side, not traced here.
- `[?]` `ResetEneXCounter`: the X enemies may be gated by a counter in `InGameEnemyClipsManager` (e.g. only one alive) — spawn logic, not traced.
