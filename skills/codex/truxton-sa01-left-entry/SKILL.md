---
name: truxton-sa01-left-entry
description: "Recover, repair, and validate the pink Sa01 fighter left entry manoeuvre (ene_sa01_2a) in the Unity 2023 Truxton remaster. Use for this movement variant, its facing, spawn conditions, and original-code comparison."
---

# Sa01 left entry

Repair `ene_sa01_2a` on `Pf_Ene_Sa01`. Several pink/gold twin-engine fighters in a screenshot can be instances of this same model. This skill covers this variant, not pickup carriers or the other enemy families.

## Variant identity and spawn conditions

Left approach starting at source (-210, 0, 40), initial direction (+1, 0, 0). The first source cues are at 287 and 287.1 seconds, with independent vertical offsets. Do not reuse the conditional 4l origin or wipeout gate.

Source EnemyData identity: `85b297b642f319bdffc8dfdf`. BG03 is Round 1. The extracted schedule contains 16 cues for this variant; loop executions are additional. Preserve per-cue offsets, repeat delays, mode masks, and group conditions. Read the variant and its matching cue records from the files below instead of inventing another formation.

## Recovered steering

All five Sa01 variants share RouteEvent 6: speed 80 source units/second, `value0=0.3300000131`, `value1=3`, `intValue1=10`, `dotime=10`, and forward-facing mode 1. This is player pursuit, not a straight-vector event or a spline. Steer toward the current player for three seconds, then keep the final heading. Inside a ten-source-unit radius, skip turning for that update. Do not permanently lock the direction when merely entering that radius.

Native angle lookup truncates to 0.1 degrees: the 0.33-degree nominal increment becomes 0.3 degrees. `HomingDirection` snaps only when the target lies within that angle; otherwise it chooses the rotation with the larger dot product. Nominal 60 Hz ticks therefore cap a sustained turn at about 18 degrees/second. Preserve speed while turning and point the nose along the resulting heading.

Evidence anchors for this installed IL2CPP build: `_execEventWithRepeat` dispatch at `0x1cf7432?0x1cf79f7`; `_moveTypeUpdateAsync.MoveNext` at `0x1cf9730`, pursuit branch `0x1cf9bba?0x1cf9f24`; `VectorUtility.HomingDirection` at `0x1df73b0`; `Sinf`/`Cosf` at `0x1df8a70`/`0x1df6fa0`. Recheck binary/metadata hashes before reusing these addresses for a changed game build.

## Working files and verification

Workspace: `D:/games/Truxton Extreme`. Staging: `extractor/UnityProject`. User project: `C:/Users/Administrator/Documents/TruxtonRemaster`, Unity **2023.2.22f1**.

- `extractor/sa01-manoeuvres/source-variants.json`: recovered variant definitions and matching stage cues.
- `extractor/sa01-manoeuvres/steering-update.txt`, `0x1df73b0.txt`, and `source-fingerprints.json`: native evidence and build identity.
- `Assets/Truxton/Round1Sa01Motion.cs`: stateful pursuit integration.
- `Assets/Truxton/Round1EnemyWaves.cs`: variant selection, live player coordinates, spawn/despawn, facing integration.
- `Assets/Editor/Round1Sa01Check.cs` and `Assets/Editor/Fixtures/sa01-reference.json`: independent scalar-angle reference checks.

Compare fixed-player trajectories, moving-player trajectories at 30/60/144 FPS, the three-second cutoff, the close-range no-turn rule, actual wave facing, pause and pooled restart. `Round1Sa01Check.RunBatch` chains the existing regression suites; run it in the isolated staging project and inspect `round1-sa01-validation.json` and `round1-sa01-manoeuvres.png`. Launch the installed Unity editor hidden and wait for it to exit before modifying staging scripts.

Sa01 uses the original gameplay projection: MainCamera vertical FOV 20 degrees, position (0,400,0), rotation X=90 degrees. Source viewport height is `2*(400-sourceY)*tan(10 degrees)`, about 141.0616 at Y=0. The former 200-unit mapping was a guessed adaptation and made formations too narrow and screen travel too slow. Use the same projection for spawn/current positions and visual scale, and its inverse for the player. Native `UpdatePlayerPosition` adds `PlayerTargetOffset=(0,0,1)` before Sa01 steers. Keep other enemy families' existing mapping scoped separately.

Evidence is under `extractor/sa01-review/`: `original-camera.json` (level1/MainCamera), `manager-cctor.txt` (camera tall=400 at RVA 0x1cf078f; player target offset at 0x1cf0bc6), `0x1ceb990.txt` (SetupCameraPosition), and `0x1ceda50.txt` (UpdatePlayerPosition). The local capture `TATSUJIN EXTREME 2026-10-26 12-33-11.mp4` shows the original six-ship top approach. Inspect `round1-sa01-formation.png` alongside it. Check projection against an independent pinhole calculation and confirm all six scheduled fighters appear. Fixed 60 Hz integration, linear player interpolation and a shared remaster render plane remain adaptations; visual comparison does not establish frame-by-frame trajectory parity. Preserve drone-only power-up rewards. Do not alter attack cadence or other enemy types merely to fix this movement variant. Install tested files with destination hash checks, backups, and existing Unity GUIDs preserved; never replace the user's open scene to apply a script correction.
