# Ene_Mf01 — no motion code; circle-centre bullet choice on a stack program (BG07, BG08)

Read-only study of `GameAssembly.dll`. Shared machinery is in `../../air-route-events/SPEC.md` and `../../ground-route-events/SPEC.md` (Translate, Delay/PlayPause). `[I]` = inference, `[?]` = unknown.
Sim: `../tools/m7_sim.py mf01`.

## 1. Identity

| Item | Value |
|---|---|
| Prefab | `Assets/OriginalRecovered/Samples/Prefabs/Reference/Enemy/Pf_Ene_Mf01.prefab`: `Ene_Mf01` (`_Muzzle` serialized), `EnemyMover`, `PositionShift` (inert: `_baseY = _targetY = 0`), `EnemyTurret`, 3× `EnemyCollisionModel` |
| Class | `Ene_Mf01 : PawnEnemy`. `.cctor` 0x1DC5980, `Initialize` 0x1DC5660, `InitializeToPlay` 0x1DC54E0, `ReStart` 0x1DC5700, `_onBulletFire` 0x1DC5B00, `_callDeadEffect` 0x1DC5880, `GetBulletTemplates` 0x1DC5390, `Terminate` 0x1DC1920 |
| Statics (`.cctor`) | `_CircleRange` = 60.0 (0x42700000), `_CenterX` = 60.0, `_CenterZ` = 10.0 (0x41200000), `_BulletNameIn` = "mf01_fire2", `_BulletNameOut` = "mf01_fire1" |
| Definitions | BG07: 24 (`ene_mf01_5a1..5a5`, `5b1..5b5`, `7a1..7a7`, `7b1..7b7`). BG08: 3 (`ene_mf01_3a1..3a3`). All: attribute 16, routes [], position (0,0,15), speed 60, rotate 0, easeType 0, lookAt 0, placement offset z +100 … +356 (start height above the circle). |
| Spawns | BG07 `5a*`/`7a*` at 124 s, `5b*`/`7b*` at 151 s (offset 0); BG08 `3a*` at 280 s, offset (60,0,0) |

## 2. What the class code does (no motion)

```
Initialize 0x1DC5660:       _mover._bulletFire = _onBulletFire                     // every Bullet event comes here
InitializeToPlay 0x1DC54E0: _bulletTemplateIn  = GetTemplate("mf01_fire2")
                            _bulletTemplateOut = GetTemplate("mf01_fire1")
ReStart 0x1DC5700:          _circlePos = transform.localPosition (spawn point)
                            _circlePos.z = _CenterZ (10)
                            _circlePos.x += (EnemyData name contains "a") ? −_CenterX : +_CenterX     // −60 / +60
_onBulletFire 0x1DC5B00:    p = player sky position (nearest player, _targetPlayerIndex set)
                            d = |_circlePos − p|                                    // 3D magnitude
                            template = (d < 60) ? In ("mf01_fire2") : Out ("mf01_fire1")
                            BulletFireAsync(token, template, false, false, _Muzzle, ...).Forget()
```

- The Bullet event's own `stringValue` (`mf01_fire2`) is ignored. The circle's centre decides the shot: the inner pattern when the player is inside the 60-unit circle, the outer one otherwise.
- `_circlePos` matches the circle routes: for `5a1`, `common_circle60r_all` from (0,15) is centred near (−60, 15) and `_circlePos` = (−60, 10).
- Note that every name `ene_mf01_*` contains the letter a only in the `a` variants, so the test splits a/b correctly [I: the EnemyData asset name equals the definition name].

## 3. Motion (the stack program, `ene_mf01_5a1`)

```
Delay(dotime 6, value0 7.75, flag0)   -> value0 > 0: no stack wait; after 7.75 s the mover is PAUSED for 6 s (_delayPlayPause)
Rotate(60 s, (0,0,7200), abs flag0) on child pf_ene_mf01/ene_mf01   (120 deg/s spin; visual; holds RotateTask)
Translate((0,0,-100), relative)       -> 100/60 = 1.667 s straight down to the circle start (0,15)
TaskWait 4
Bullet (value1 1.2: first shot 1.2 s later, repeatCount 999, repeatDelay 2)
SplineMove common_circle60r_all, TaskWait 256;  SplineMove common_circle60r_half, TaskWait 256
Translate((0,0,200), relative), TaskWait 4      -> leaves upward; then events run out -> rule 2
```

The paused mover freezes position (and tasks) from 7.75 s to 13.75 s [I: bullets keep running in the sim; native pause scope not traced].

## 4. Simulated path (`m7_sim.py mf01`): BG07 t = 124 s, `ene_mf01_5a1`

| t | x | z | note |
|---|---|---|---|
| 0 | 0 | 115.00 | Translate −100 |
| 0.5 | 0 | 86.00 | |
| 1.0 | 0 | 56.00 | |
| 1.5 | 0 | 26.00 | |
| 1.683 | 0 | 15.00 | circle starts (radius 60, centre (−60,15)) |
| 2.0 | −3.20 | −3.72 | |
| 2.5 | −19.02 | −28.79 | |
| 2.9 | −39.31 | −41.30 | first shot |
| 3.25 | −59.88 | −45.00 | bottom of circle |
| 4.0 | −100.81 | −28.95 | |
| 5.0 | −119.01 | 25.61 | |
| 6.0 | −82.95 | 70.44 | |
| 7.0 | −25.76 | 64.21 | |
| 7.75–13.75 | −1.86 | 27.52 | paused |
| 13.95 | 0 | 15 | half circle |
| 17.08 | −120 | 15 | Translate +200 |
| 20.43 | −120 | 215 | Translate done → rule 2 EndRoute (it left the top at about 18.4 s, but the Translate holds 0x214) |

## 5. Reconstruction notes

- **Motion: no hook needed** (Delay/PlayPause, Translate, SplineMove and Rotate on a child are generic).
- **Bullets: a hook is needed** in the attack code. The fired template is In/Out by the player's distance from `_circlePos` (§2), not the event's name.

## 6. Open questions

- `[?]` Whether `_delayPlayPause` also pauses running Bullet repeat loops (IsPausing scope).
- `[?]` `EnemyTurret` on the prefab — its per-frame role (turret aiming of a child) was not traced; it does not move the root [I].
