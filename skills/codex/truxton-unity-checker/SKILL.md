---
name: truxton-unity-checker
description: "Checker for the TATSUJIN EXTREME (Truxton Extreme) Unity 2023 remaster: play Round 1 of the remaster with its autopilot in a Unity batch run, capture every enemy's spawn, path, rotation, shots and kills in the original game's units, cut subjects into truxton-track/1, and compare them with the pioneer's recording of the original to give a pass/fail/inconclusive verdict. Use whenever the user or the remaster manager asks to check, verify, test, compare or measure the remaster against the original, run the remaster autoplayer or validation harnesses, capture remaster tracks, or decide whether an enemy, wave or stage now matches — even if they only say 'checker', 'does it match now' or 'run the comparison'."
---

# Truxton Unity checker

You measure the remaster and judge it against the original. You never fix remaster gameplay code: if something differs, you report how much and where, and the manager routes it to the extractor. The only code you maintain is the capture infrastructure listed below, and changes to it go through the manager like any skill change.

Staging project `D:/games/Truxton Extreme/extractor/UnityProject` (Unity **2023.2.22f1**). The user's project `C:/Users/Administrator/Documents/TruxtonRemaster` is theirs and is often open in the editor; never run batch jobs against it.

## Batch rules

- Check that no editor holds the staging project (`extractor/UnityProject/Temp/UnityLockfile` absent, no `Unity.exe -projectpath …\UnityProject` process). Batch runs against an open project fail.
- Run `-batchmode` without `-quit`; the harness leaves play mode and exits itself. Run it in the background and wait for it to exit before starting another or before anyone edits staging scripts.
- A full Round 1 capture takes about 30 s of simulation plus editor start-up.

## Capturing the remaster

```powershell
& 'C:\Program Files\Unity 2023.2.22f1\Editor\Unity.exe' -batchmode -projectPath 'D:\games\Truxton Extreme\extractor\UnityProject' `
  -executeMethod Round1TrackCaptureRun.RunBatch -truxtonCaptureOut '<out>.remaster-capture.json' -logFile '<out>.log' `
  -truxtonPlayMode story [-truxtonNoFire] [-truxtonPlayerPath '<handoff>\player-path.original.json'] [-truxtonCaptureSeconds 425] [-truxtonAllowGameOver]
```

It pins the camera to the original 1280×720 aspect (16:9). Batch mode otherwise gives a different aspect, which broke on-screen entry/exit tests and let left-side enemies fly to Z −540. It then plays from stage time 0 at a fixed 60 Hz with `Round1Autopilot`, refills lives so the whole schedule runs (unless `-truxtonAllowGameOver`), and writes one `truxton-remaster-capture/1` document with every source-spawned enemy, plus `round1-capture-result.json` in the project folder. Positions are the remaster's own source-space coordinates (frame `source-xz`), time is `Round1Playback.elapsed` (stage-seconds), and each instance carries its schedule key `cue<start>#<ordinal>`, EnemyData name and identity, model and cue index.

Make the run comparable with the original recording:
- **Play mode, always:** match the pioneer's mode. The staging remaster defaults to Story (StoryA mask 2, selector mode 1) since 2026-10-27; pass `-truxtonPlayMode arcade` for an Arcade recording, and `story` explicitly for clarity. The mode picks both the schedule (`gameModeMask`: Arcade-only cues such as `ene_sa01_1a` at 5–10 s) and the bullet selectors (Story `*_easy` single shots vs Arcade bursts).
- **Routes:** if the pioneer recorded with `--no-fire`, capture with `-truxtonNoFire`; otherwise most instances end as `killed` and only their common lifetime compares.
- **Player path, always:** replay the pioneer's player path (same pass) with `-truxtonPlayerPath`. Pursuit and aimed shots depend on it, and so does the whole enemy layer. Both games shift it by −0.5 × clamp(player X/123, −1, 1) × the BG slide range (−0.203 × player X on BG03; `Round1EnemyWaves.LayerOffset`), and the capture records the shifted position. Without the replay, a difference may come from the two pilots, not the remaster.
- **Death in the original pass:** the original freezes enemies after the player dies; the remaster's replayed player never dies. Judge route subjects only up to the death time and say so (cut both tracks, label the files `*.diagnostic.json`); later segments need a pass where the player survives.
- **Replayed ship can't die:** with `-truxtonPlayerPath` the capture keeps the remaster ship invulnerable, because the original's deaths are already in the path. A remaster death would clear hostile bullets and hold the layer shift through a respawn the original never had. Check `livesRefilled` is 0 in `round1-capture-result.json`.
- **Same pass:** the original rewinds to checkpoints on death; the observation names its pass, and the player path must come from that pass.
- **Roll is not evidence yet:** the original recorder does not see the model's bank (its roll stays ≤ 5°), while the remaster records full banking. Report roll deltas, but don't count them toward a verdict until the pioneer reads the bank child; pass `--tolerances` with a large `angle` and say so.

Then cut the subject and compare:

```powershell
$py='C:\Python311\python.exe'; $u='D:\games\Truxton Extreme\extractor\unity-checker\build_capture.py'
& $py $u summary <capture>
& $py $u build <capture> --subject BG03/Md01/index1 --model Pf_Ene_Md01 --index 1 --out <handoff>\capture.remaster.json
& $py 'D:\games\Truxton Extreme\extractor\manager\skills\truxton-remaster-manager\scripts\compare_tracks.py' `
      <handoff>\observation.original.json <handoff>\capture.remaster.json --out <handoff>\comparison.json
```

Filters `--model`, `--enemy-data`, `--index` are ANDed; choose the ones that match the pioneer's subject (EnemyData name for Sa01 variants, model + index for Md01 programs). Stops use the pioneer's own detector so both sides share one definition. Events use `muzzle: null` on both sides; the remaster's muzzle name is kept as `muzzleName`.

## Reporting

Return the verdict line, the three largest deltas (instance, quantity, value, time), the run options, and the capture/comparison paths. Don't edit `comparison.json`, and don't loosen tolerances yourself; say when you think a tolerance is wrong and why. If the verdict is `inconclusive`, fix the capture (frame, clock, filters, player path) rather than arguing the number.

## Regression after an extractor change

Before a comparison counts, the extractor's change must still pass the existing harnesses (`Round1WaveCheck`, `Round1Sa01Check` and `Round1HealthCheck` pin Arcade for their 5 s fixtures; `Round1WaveCheck` asserts the Story default): `-executeMethod Round1Md01Check.RunBatch` chains Sa01 and the other gameplay suites; `Round1AutopilotCheck.RunBatch` chains from the autopilot. Read their `round1-*-validation.json` files, not just the exit code.

Since 2026-10-28 these harnesses also cover what the extractor added. Each plays Round 1 at 60 Hz without player fire (ship invincible, no bombs) and needs graphics (it renders):

| Harness | Asserts | Renders |
|---|---|---|
| `Round1GroundItemCheck` | The 10 BG03_ge boxes break and drop the original items: ItemReferenceTable order, 1UP, two bonuses. Drops stay on their ground point. | `round1-ground-items-*.png` (textured boxes, the ground model of the drop) |
| `Round1MeteorCheck` | Meteor physics: contacts happen, overlap no worse than the original (365 frames, worst ratio 0.218), at least 90 % distinct tumbles. | `round1-meteors.png` |
| `Round1HitShapeCheck` | Every wave and ground enemy carries its original hit circles (`Round1HitShapes`); a shot through each circle hits, one outside the shape misses. | `round1-hitshapes-<t>.png`, with the circles drawn |
| `Round1OverlapCheck` | The remaster's no-overlap rule (meteor/meteor, meteor/enemy, enemy/enemy, 0.5-unit tolerance), and that no enemy bullet sits inside an enemy or meteor other than its shooter. | `round1-overlap-<t>.png` |

Run the overlap check in `extractor/user-clone` too after an install: the user's scene lets Sa01 swarm differently, and it caught squeezes that staging didn't.

## Capture infrastructure

- `Assets/Truxton/Round1TrackCapture.cs` — recorder; inert unless a capture sets `Round1TrackCapture.Active`.
- Hooks: `Round1EnemyWaves.Spawn` (birth), `UpdateActor` (sample: where the enemy is drawn, its path plus any separation nudge, in its own source frame; `sourceRotation * RootRotation`), `OnRemoved` (end), `Round1EnemyAttacks.Emit` (one `fire` per spawned bullet, at its due time) and `QueuePattern` (`laser`).
- `Assets/Editor/Round1TrackCaptureRun.cs` — batch runner. `extractor/unity-checker/build_capture.py` — subject cutter.
- The Round 1 boss is captured since 2026-10-27 (`Round1Boss` → `Round1TrackCapture.BirthUnscheduled`, key `ene_boss03@420`, cut with `--model Pf_Ene_Bos03`). A replayed player path doesn't reproduce the original's damage, so the cover-open phase (HP ≤ 51 %) won't line up; judge only the window before the original's cover opened, as `*.diagnostic.json`, or pass `-truxtonBossCoverOpenAt <s>` (fixture: opens the cover by the HP rule at that stage time; say so in the report). Laser events differ in definition (remaster: the call; original: the live collider about 1 s later, in world coordinates), so don't count them yet.
- Sd02 summon drones are captured (`ene_sd02@<spawn>`, `--model Pf_Ene_Sd02`). Their deploy yaw is random, so compare paths with `-truxtonSd02Yaws <deg,deg,...>` set from the original drones' first recorded yaw (signed), as `*.diagnostic.json`.
- Not captured yet: pickups and drops, and rounds other than BG03.
- Expected differences from the original, by the user's choice (see truxton-remaster-manager, *Deliberate departures*): nudged enemies drift from their paths (Sa01 RMS about 0.3 → 1.0, Md01 up to 2.6), and meteors bounce off enemies. Report these deltas, but name the rule rather than treating them as extractor errors.

These hooks live in the staging project. The installed user project receives them only when the extractor installs a staging change, which is fine: they do nothing outside a capture run.
