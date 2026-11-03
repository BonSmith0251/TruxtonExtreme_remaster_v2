# Ene_Mi01 — no motion code; an ordinary stack program (BG04)

Read-only study of `GameAssembly.dll`. Shared machinery is in `../../air-route-events/SPEC.md`. `[I]` = inference, `[?]` = unknown.
Sim: `../tools/m7_sim.py mi01` (air_sim stack plus drift column).

## 1. Identity

| Item | Value |
|---|---|
| Prefab | `Assets/OriginalRecovered/Samples/Prefabs/Reference/Enemy/Pf_Ene_Mi01.prefab`: `EnemyMover` (defaults), `Ene_Mi01` (`_HitPoint 100`, lock-on, `_deadExplosion pf_eff_explposion03`, **`_deadBullet mi01_fired`**, `_overplayDeadSound 164`, `_item 2`), `PositionShift` (`_baseY 0, _targetY 0`: inert, see `../Ene_Mb01/SPEC.md` §6), `EnemyCollisionModel`, `PhysicsEnemy` (visual) |
| Class | `Ene_Mi01 : PawnEnemy`. Its only own method is `_callDeadEffect` 0x1DC6B40 (item drop / death bullet, see `../../death-bullets/SPEC.md`). **No CreateRouteData, Progress or LocalLateUpdate: the class never moves the enemy.** |
| Definitions (BG04) | `ene_mi01_1a`, `_2a`, `_2b`, `_3a`, `_3b`, `_8`, `_8b`. All: attribute 16 (stack), routes [], duration 60, position (0,0,140); speed 60, rotate y 180, easeType 0, lookAt 0. |
| Spawns (spawn = (0,0,140)+offset, index 0) | 1a: 194, 334 (0,0,0). 2a: 192, 332 (−50). 2b: 192, 332 (+50). 3a: 268 (−90), 330 (−100). 3b: 268 (+90), 330 (+100). 8: 270 (−25,0,10). 8b: 270 (+25,0,10). |

## 2. Program (`ene_mi01_1a`; the others differ in route names and in where the first roll is left/right)

Program steps:
- `SplineMove move_mi01_1a_enter`, TaskWait 256. Route (0,0) → (0,−70), 70 long.
- `SplineMove common_D20` + `Speed(10, 0.5)`, TaskWait 256.
- Three times: `Bullet mi01_fire1 @muzzle01`, `Delay 0.5`, `Rotate(2 s, (0,0,±720))`, then TaskWait 1. The rolls go +720, −720, then +720 with InOutSine, and the third roll has **no** TaskWait.
- `SplineMove move_mi01_1a_move1` (5) + `Speed(30, 0.5)`, TaskWait 256.
- `SplineMove move_mi01_1a_move2` (2.5) + `Speed(10, 0.5)`, TaskWait 256.
- `TaskWait 1`; `Bullet`, `Delay 0.5`, `Rotate(2, (0,0,−720))`, TaskWait 1; `Bullet`, `Delay 0.5`.
- `SplineMove move_mi01_1a_leave` (0,+180) + `Speed(100, 2)`. Then the events run out.

The rolls are ±720° about local Z (two barrel rolls in 2 s). They are visual only. The third roll overlaps `move1`, whose per-frame `localRotation = _firstRotate` write competes with the tween (see `../Ene_Mb01/SPEC.md` §4 [?]).

## 3. End

- After the last event, MovingTask is not in 0x214 and the program is exhausted, so rule 2 applies (air spec §3.2).
- The enemy is removed on the first frame its pre-step position is outside `gameScreenArea` while flying up the `leave` spline.
- For 1a that is z ≥ 91.7 at 13.75 s. The 180-long route is not completed.

## 4. Simulated path (`m7_sim.py mi01`): BG04 t = 194 s

| t | x | z | speed | note |
|---|---|---|---|---|
| 0 | 0 | 140.00 | 60 | enter |
| 0.5 | 0 | 110.00 | 60 | |
| 1.0 | 0 | 80.00 | 60 | on screen |
| 1.15 | 0 | 70.00 | 60 | D20 + Speed → 10 |
| 1.5 | 0 | 55.39 | 25 | |
| 1.933 | 0 | 50.00 | 10 | shot 1, Delay 0.5 |
| 2.433 | 0 | 50 | 10 | roll +720 (2 s) |
| 4.45 / 6.97 | 0 | 50 | 10 | shots 2, 3; rolls |
| 7.467 | 0 | 50 | 10 | roll 3 + move1 (5) at 10 → 30 |
| 7.767 | 0 | 45.00 | 22.7 | move2 (2.5) at → 10 |
| 9.48 / 12.00 | 0 | 42.50 | 10 | shots 4, 5 |
| 12.50 | 0 | 42.50 | 10 | leave + Speed → 100 over 2 s |
| 13.0 | 0 | 53.30 | 32.5 | |
| 13.75 | 0 | 91.73 | 67 | rule 2: EndRoute |

## 5. Reconstruction notes

- No hook is needed. All event types are in `Round1RouteProgram`'s set {1,2,8,10,11,14,15,80,83}, so `Round1EventStack.Applies` is false and `Round1RouteProgram` plays it.
- That route program must still follow the native rules:
  - Speed ramps while a spline runs;
  - TaskWait masks 1 and 256;
  - the Delay timing;
  - removal by rule 2 at the screen edge during `leave` (not at the end of the route).
- The route LUTs are in the BG04 JSON.
