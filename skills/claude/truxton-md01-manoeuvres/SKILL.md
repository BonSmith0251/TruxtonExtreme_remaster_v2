---
name: truxton-md01-manoeuvres
description: "Recover, repair, and validate the gray twin-cannon Md01 drone and its seven native movement programs in the Unity 2023 Truxton remaster. Use for the pictured gray/red Md01, its lateral passes, stops, banking, timeline route selection, and movement-linked firing."
---

# Md01 drone manoeuvres

Identify `Pf_Ene_Md01`: the gray/silver round fighter with red bands, two forward cannons, curved side arms and pink exhaust. Several pictured instances are the same enemy type. EnemyData `ene_md01` has identity `f7e49704396d17d562aa6a63`; its original albedo is `extractor/enemy-output/textures/1cdea63c5d1e693e85118332.png`.

## Recover the native program, not a straight fallback

The serialized EnemyData has no route names or events. `Ene_Md01.CreateRouteData` clones it and supplies a program from the static route table, indexed by the timeline's `_indexValue`. Losing this field made every Md01 fly straight down. Keep the event's `indexValue` through extraction, scheduling and pooled respawns. Round 1 has eight Md01 cues: 50s index 0, 60s index 1, 60.5s index 2, 61s index 3, 77s index 4, 77.5s index 5, 78s index 6, and 93s index 0. The two index 0 cues retain their authored repeat conditions and offset tables.

There are seven programs, all starting with `common_D100` and ending with `common_D200`. Index0 is the short transit with a shot from both cannons between those routes. Indices 1/4 perform mirrored broad passes; indices 2/5 and 3/6 perform mirrored stepped passes. Their 0.1/0.5/1/1.5-second stops are authored delays. Read the complete ordered events from `md01-motion.json`; do not reconstruct paths from this short description or invent sinusoidal patrols.

The source speed is 90. Each spline's duration is its length divided by speed. TaskWait mask 256 waits for movement; Delay advances the program cursor. Native ease type 7 is cosine ease-in/out, using the source trig lookup truncated to 0.1 degree. Retain the original spline lookup tables, including the sampled D200 route, rather than replacing all routes with endpoint lerps.

## Complete the exit route

Md01 completes its authored final `common_D200` before removal. Do not apply the generic viewport-boundary removal to this family: it cuts the final route near source Z -106 instead of the original Z -180 or -210 and removes the drone roughly a second early. Full no-shoot/no-bomb window observations for programs 4/5/6 are in `extractor/manager/handoffs/BG03/Md01/continuation-20261027/routehold/`. Preserve program-duration removal and ordinary destruction by damage. Test a drone below the generic viewport boundary while its program is still running, then confirm removal at the authored program end.

Earlier recordings killed drones before the final turns, so their common-lifetime path comparisons could not establish exit parity. Compare complete lifetimes and endpoints when evaluating this behavior. The native attack-type enum uses `none = -1`; a nonzero death-cause check incorrectly labels untouched exits as kills. Keep raw end evidence and distinguish confirmed kills, exits and ambiguous cleanup.

## Banking, projection and firing

LookAt 31 keeps entry yaw 180 and banks around local Z. `_AddDriftAngle` uses drift gain 2, return speed 90 and maximum output arc 30 degrees; its internal accumulator clamps to plus/minus 100. `_getRotate` samples horizontal route displacement at eased progress and one raw-progress step ahead. Below a 0.2 threshold the accumulator returns toward 0; otherwise add one quarter of the displacement gain when continuing a bank and twice it when reversing. Compose this roll with the original entry rotation. Do not yaw the nose toward a sideways travel tangent.

Use the recovered gameplay camera projection for Md01: camera Y=400, vertical FOV 20, source-plane height `2*(400-sourceY)*tan(10 degrees)`. Convert both actor position and visual scale consistently. The shared projection helper is currently on `Round1Sa01Motion`; other enemy families may still use the older 200-unit adaptation.

Recovered BSelector events fire from `pf_ene_md01/muzzle01` and `muzzle02` after route completion. Programs 1-6 also use `md01_fire3_sel` before their final exit. Feed these events to the attack scheduler and suppress the legacy 1.8/3.6-second repeating fallback for generated definitions. Preserve original selector contents, HP, damage and drone-only pickup rewards.

## Evidence and working files

Workspace `D:/games/Truxton Extreme`; staging `extractor/UnityProject`; installed project `C:/Users/Administrator/Documents/TruxtonRemaster`; editor Unity 2023.2.22f1.

- `extractor/md01-manoeuvres/annotated-cctor.txt`: decoded native event order and string identities.
- `0x1dc1c10.txt`: CreateRouteData; `0xe26c10.txt`: SetIndexValue writes object+0x94.
- Native Md01 static constructor RVA 0x1dc2420; route-list boundaries 0x1dc26b8,0x1dc29e3,0x1dc34c9,0x1dc3af9,0x1dc4120,0x1dc46ad,0x1dc4cd4.
- `0x1de8100.txt`: Easing01; type 7 dispatch 0x1de8276. `0x1cdc830.asm.txt` and `0x1cdb930.asm.txt`: drift consumer and accumulator. `drift-constants.json` preserves the native arrays.
- `source-routes.json`, `source-cues.json`, `source-fingerprints.json`: original asset identities, timeline fields and build guard.
- `extractor/recover_md01_manoeuvres.py`: guarded recovery of the seven programs and 14 route LUTs; writes `Assets/Resources/Truxton/md01-motion.json` and restores Md01 cue indices in the staged schedule.
- `Assets/Scripts/Runtime/Gameplay/Round1Md01Motion.cs`: program sampling and banking; `Round1EnemyWaves.cs`: selection and lifecycle; `Round1EnemyAttacks.cs`: route-dependent fire timing.

Validate with `Round1Md01Check.RunBatch` in the isolated staging project. It checks all seven paths against independent cosine-path fixtures, authored stop durations, cue indices, bank limits, pause and pooled restart, then chains Sa01 and the existing gameplay suites. Inspect `round1-md01-validation.json` and `round1-md01-manoeuvres.png`. Launch the editor hidden and let it exit before modifying staging again. Install with destination hash checks, backups and original Unity GUIDs; do not replace the user's open scene.

Limits: fixed 60 Hz banking, continuous route timing and the remaster render plane are adaptations. Native coroutine frame-boundary overhead, global rank/random streams, per-vertex source perspective and exhaust rendering are not reproduced bit-for-bit. A screenshot validates identity and appearance, not exact original timing; use a gameplay capture or telemetry before claiming frame-for-frame parity.
