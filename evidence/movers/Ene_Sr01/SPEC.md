# Ene_Sr01 — see ../Ene_Sf01/SPEC.md

`Pf_Ene_Sr01` (BG06 `ene_sr01_1a`, `ene_sr01_1b`: attribute 16, one definition route each, lookAt 30 DriftS, speed 60, linear) has no class of its own (plain `PawnEnemy` + `EnemyMover`). It runs in **stack mode with routes**, which `../Ene_Sf01/SPEC.md` specifies for both models:

- `EnemyMover.Progress` 0x1D6CB50: `_execStackEvent` first, then `SplineMover.Progress` (route mode) in the same LateUpdate. Only the route writes the position.
- The 7 definition events are stack events: Idle 0.2, Speed→20 (0.5 s), TaskWait 32, Speed→100 (0.5 s), Idle 0.2, Bullet `sr01_fire1` (isSelfDir), TaskWait 256. The Speed ramps change the route rate.
- The route holds no task bit, so the final `TaskWait 256` passes at once: the program is exhausted at 0.933 s, and the enemy is removed the first frame its start-of-frame position is outside gameScreenArea (Small). `1b` from (−50,0,98): removed at 3.367 s at (163.1, −19.1); its route would only end at 4.283 s.
- Track: `../Ene_Sf01/sims/sr01_1b_BG06.json` (`[t,x,y,z,yaw,speed,bank]`), log `sr01_1b_BG06.txt`. Model: `../Ene_Sf01/sf01_sim.py sr01_1b`.
