---
name: truxton-original-pioneer
description: "Pioneer for the TATSUJIN EXTREME (Truxton Extreme) remaster: play or watch the ORIGINAL game with the Frida autoplayer/telemetry and record what enemies really do — spawn times, positions every frame, rotation, stops, shots, lasers, kills — as truxton-track/1 evidence for the Unity remaster. Use whenever the user or the remaster manager asks to observe, record, measure or examine an original stage, enemy, wave, manoeuvre, formation, boss or player path in the installed game, to run the original autoplayer or telemetry with recording, to convert a recording into tracks, or to answer 'what does the original actually do here', even if they only say 'pioneer', 'record round 1' or 'watch the md01s'."
---

# Truxton original pioneer

You produce evidence about the original game. You never change the remaster, and you never patch the game: everything goes through the existing read-only Frida tunnel and the game's own input readers. What you hand back is a `truxton-track/1` file plus an `evidence.md`, in the handoff folder the manager names (`extractor/manager/handoffs/<stage>/<family>-<variant>/`). The formats are defined in the manager's `references/contracts.md`.

Workspace `D:/games/Truxton Extreme` (installed GOG build, read-only). Tools: `extractor/original-autoplayer/`. Its `README.md` is the authority on launching, hotkeys and limits; read it before the first run in a session.

## Safe operation

- Launching opens the game window and takes keyboard focus on the user's desktop. Ask before starting a run unless the user or the manager's brief already said to.
- One controller/observer at a time (port 8765). F8 toggles automation, F10 or `Stop Original Autoplayer.cmd` stops; the controller releases input on stale telemetry.
- `build.json` fingerprints the game; the controller refuses a changed build. Field names are resolved by name at runtime, but RVAs in specialist skills belong to this fingerprint — recheck them if it changes.
- Playing updates the game's save. Use a separate ledger (`--progress pioneer-progress.json`) so the bot's campaign record isn't mixed with pioneer runs; `--replay-cleared` replays episodes already complete.

## Recording

Add `--record <folder>` to either launcher. It loads `recorder.js` next to the agent; the controller behaves exactly as without it.

```bat
rem Bot plays and records (from the game folder)
"Start Original Autoplayer.cmd" --actors ash --replay-cleared --progress pioneer-progress.json --record extractor\original-autoplayer\recordings\ash-r1
rem Whole routes: dodge but never shoot or bomb (more deaths; enemies are not killed early)
"Start Original Autoplayer.cmd" --actors ash --replay-cleared --progress pioneer-progress.json --no-fire --record extractor\original-autoplayer\recordings\ash-r1-nofire
rem Shoot but never bomb (bombs freeze and slow the director; survival can limit coverage).
"Start Original Autoplayer.cmd" --actors ash --replay-cleared --progress pioneer-progress-r3.json --no-bomb --record extractor\original-autoplayer\recordings\ash-r1-nobomb
rem Allow bombs for survival outside the subject's director-time window (requires --record).
"Start Original Autoplayer.cmd" --actors ash --replay-cleared --progress pioneer-window-progress.json --bomb-hold 75:92 --record extractor\original-autoplayer\recordings\ash-r1-window
rem Preserve the subject's full route after fighting through the approach; leave time for old shots to clear.
"Start Original Autoplayer.cmd" --actors ash --replay-cleared --attempts 1 --progress pioneer-routes-progress.json --fire-hold 73:94 --bomb-hold 73:94 --record extractor\original-autoplayer\recordings\ash-r1-routes
rem The user plays; only observe and record
"Start Original Telemetry.cmd" --record extractor\original-autoplayer\recordings\manual-r1
```

Each LateUpdate frame records: clocks (`stage` = `PlayerCommonData._inStageTime`, `stageReal`, `effected`, and `timeline.director` = the stage `PlayableDirector` time), pause, `_stageOrder`, actor/stage index, player `_targetPosition`, every playing enemy (position, HP, root and model euler angles), and each new bullet and laser. Each enemy activation records its identity: `class`, the record key, `_indexValue`, the EnemyData asset name (`data`, from the mover's `_baseEnemyData`), the GameObject name (`object`), the spline route, and pool/born/delay values. Each deactivation records the death fields (`_causeOfDeath`, `_deathByPno`, `_DamageScored`, `_isResultDone`). Pooled objects are split into instances on reactivation. `schema.json` keeps the live layouts of the enemy, record, mover and timeline classes; `errors.jsonl` holds recorder errors, which never stop the controller. One "Null _activeEnemys" error during stage load is normal.

`--bomb-hold A:B` uses the measured timeline director, including checkpoint rewinds, rather than cumulative stage time. It stops new bomb requests 0.35 seconds before A to allow for recorder batching and pending input, and resumes only after a fresh reading exceeds B. Missing, paused, non-play or stale clock readings suppress bombs; wall time must never extrapolate through a frozen director. `--no-fire` and `--no-bomb` still take precedence. A suppressed request must not spend the planner's bomb cooldown. Bomb request logs include the measured director; check actual clock/stock changes when deciding whether the subject window stayed clean.

Use a new recording folder and a separate progress file for each attempt series. Bound retries and stop after the required subject window is captured. If survival fails before the window, document the coverage gap; more attempts are not evidence that the subject matches. A recording with firing enabled supports common pre-kill route diagnostics against a no-fire remaster capture, not full combat parity.

The recorder also writes `frame.world` (`_inGameRoot` and `_inGameEnemyRoot` world position and rotation, and `GetPlayerPosition(0)`, which is root-local) and `frame.locals` (`[generation, localPosition, forward]` for Ene_Sd02), for movers that read transform values directly.

`--immortal` keeps the player invincible through the game's own `PlayerControll.SetPlayerInvincible(true)` (reasserted every state sample, since respawns reset it). Nothing on disk changes, and the flag is in the recording's `meta.json` argv. Use it to reach late subjects (the boss summon) without checkpoint rewinds. But deaths, respawn bullet-clears and rewinds then never happen, and the bot's hits on enemies continue where a death would have stopped them, so state it in `evidence.md` and don't use it for death/rewind subjects.

`--fire-hold A:B` suppresses shooting only around a subject window, using the same measured-clock and 0.35-second entry guards; it also requires `--record`. Combine it with `--bomb-hold` for route recordings. Begin the window sufficiently before the enemy spawn for existing shots and bomb effects to clear. Confirm the enemies survive through the part under investigation: recording every birth is insufficient if they die before their final turns. This does not reproduce earlier combat in a no-fire remaster capture; label the comparison's supported time range.

Before blaming the movement planner for deaths with unused bombs, inspect the saved pre-death telemetry. Laser `_startPosition` / `_endPosition` are world coordinates, including stage translation and height. The autoplayer projects them through the gameplay camera onto the player's source plane, projects their collision width, and retains `rawFrom` / `rawTo` / `rawWidth` for diagnosis. Native `_collisionWidth` is a half-width: `EnemyLaserCollision.Initialize` builds vertices at plus/minus that value. The planner needs full projected width. Inverse-root translation alone misses height perspective. Compare the projected geometry with the physical collider when available; the beam tip can also advance rapidly between snapshots.

Death labels must respect the native attack-type enum: `none = -1`, normal weapon types start at 0, bomb is 100 and stage-clear is 110. A nonzero check falsely labels untouched exits as kills and misses blue type 0. Preserve native end evidence (cause, player, damage, result flag), and keep unclear cleanup explicit rather than using a label to hide a lifetime mismatch.

## Converting

```powershell
$py='C:\Python311\python.exe'; $t='D:\games\Truxton Extreme\extractor\original-autoplayer\build_tracks.py'
& $py $t summary <recording>                        # per pass: family, EnemyData, cue index, counts, spawn range
& $py $t build <recording> --pass 1 --subject BG03/Md01/index1 --data ene_md01 --index 1 --stage-order 1 --stage BG03 --round 1 `
      --out 'D:\games\Truxton Extreme\extractor\manager\handoffs\BG03\Md01\index1\observation.original.json'
& $py $t player-path <recording> --pass 1 --stage-order 1 --out <handoff>\player-path.original.json
```

Filters `--data` (EnemyData, e.g. `ene_sa01_2a`; the variant), `--family` (decoded record key, e.g. `Sa01`), `--index`, `--class`, `--stage-order` and `--pass` are ANDed. The clock defaults to `auto` (the director when recorded). Always pass `--pass` and use the same pass for the player path. Paused frames are dropped. Stops are derived where speed stays below 1 unit/s for 80 ms. Shots and lasers are attributed to the nearest live enemy within 16 units, because bullets carry no owner in this build. Export the player path with every subject the checker will compare: the enemy layer's parallax depends on it (below), not only pursuit.

## What the original does (settled on live runs, 2026-10-26)

- **Round 1 entry:** Ash episode 1 (Story) loads `_stageOrder` 1 = BG03.
- **Play mode matters:** Story (TXEResident mode 1) and Arcade (2/3) differ in both schedule (`TLGameModeFlag`: StoryA/B/C 2/4/8, Arcade1/2 32/64) and bullet selectors (Story picks `*_easy` patterns, e.g. one Md01 pair per stop instead of three). State the mode in `evidence.md` so the checker captures the same one.
- **Bombs suppress evidence:** a firing run also bombs. For shot-for-shot fire subjects, prefer a run where the bot doesn't bomb, and list the bomb times (controller `run.jsonl`, `_inStageTime`) in `evidence.md`.
- **Clock:** `timeline.director` is the schedule clock. The Md01 cues 50/60/60.5/61/77/77.5/78 s were observed at 50.01/60.01/60.51/61.00/77.02/77.51/78.01. `_inStageTime` is cumulative play time and matches only until the first death.
- **Death rewind:** when the player dies, the stage timeline rewinds to a checkpoint (seen at 0, 30, 316 and 347 s) and replays its cues and ground objects. The converter numbers these as passes; instances alive at a rewind end with `rewind`. With `--no-fire` the bot dies within about 16 s, so it rarely gets past the first checkpoint. Firing runs cover the stage (the second run reached about 350 s) but kill most flyers early.
- **Identity:** the class is generic (`PawnEnemy`, `PawnEnemyGround`, `PawnEnemyDD`, …). `_recordData._targetKey` is the family stored XOR 0x3C (`o]\x0c\r` → `Sa01`), and `_originalName`/`_partsName` are empty. The mover's `_baseEnemyData` name is the variant and equals the remaster's EnemyData names (`ene_sa01_1a`, `ene_md01`, `ene_fireball_ss`, …).
- **Coordinates:** positions are root-local X/Z in the same units as the remaster's source space, with one exception: the enemy layer (`_inGameEnemyRoot`) is displaced live. `InGameManager.LateUpdate` sets its X to −0.5 × clamp(player X / 123, −1, 1) × the timeline's BG slide range. On BG03 the range is 50 over 0–185 s and 201–540 s (2 s fades) and 0 in between, so −0.20325 × player X capped at ±25. The rate holds while the game's entry/respawn autopilot runs. Native evidence: `extractor/enemy-layer-parallax/README.md`; the remaster implements it. Ground objects are not on that layer (no shift); they sit at Y=100 with large scrolling Z values.
- **Spawn frame and exits:** an enemy's first recorded sample is already one 60 Hz movement tick along (the native update runs on the activation frame). A flyer leaves 1–2 frames after its projected position leaves its screen rect: `gameScreenArea` ±0.15 of the viewport for Sa01 (Z ≈ −94.6 at the bottom), `gameScreenAreaM` ±0.2 and `gameScreenAreaL` ±0.3 for some fireballs (≈ −100, −113). Exit positions within a frame of these edges are expected, not route errors.
- **HP:** `_HitPoint` on the collision object is constant (15,000 on Md01) and does not indicate damage. Kills come from the death fields; for recordings made before them, the converter infers a kill when an enemy vanishes inside |x| ≤ 140, |z| ≤ 85 and marks `native.killInferred`.
- **Rotation:** root euler yaw is the heading in source X/Z (Unity convention; Md01 holds 180, Sa01 follows its travel direction). The root and `_modelTop` report the same angles, and Md01 rolls no more than about 5°, so the authored bank of up to 30° is on a deeper child the recorder does not read. Roll is not comparable yet.
- **Player position:** `PlayerControll._targetPosition` is root-local (the stage starts at (0, −50), and a respawn appears at z −150). Replaying it in the remaster reproduced the Sa01 pursuit headings exactly for the first two seconds, so it is the right frame for pursuit.

On death the original freezes the live enemies while the player re-enters from (0, −150), and the parallax rate stays put. Compare routes only up to the death in the chosen pass.

- **Round 1 boss (Bos03):** born at director 420 s and on the enemy layer (its x includes the −0.203 × player X shift). Its turrets and shoulders sit about 48 units from the root, so convert boss subjects with `--fire-radius 60`; the default 16 drops those shots. An episode clear ends through a `transition` mode screen, not `result`, so a watcher must stop the controller on the boss's kill (`ends` cause 1) or the bot moves on to the next episode. Evidence: `manager/handoffs/BG03/Bos03/evidence.md`. The boss summon (Story: 34 Sd02 per summon, boss at z 50 from about 450.4 to 459 s) is in `recordings/ash-r1-summon-20261027` passes 1, 3 and 4, recorded with `--fire-hold 425:462 --bomb-hold 425:462`. Recordings before 2026-10-27 17:00 miss pooled bullets reused within the 300 ms liveness window (several per boss volley); `recorder.js` now detects reuse from `_bornPassed`. For older recordings, cross-check fire counts across passes.

Still open: where the bank rotation lives. The extra `ene_sa01_1a` cues at 5–10 s were resolved as Arcade-only cues; match Story/Arcade mode before comparing schedules.

## Acceptance before handing back

- The subject is identified by more than a class name (record key and cue index at least), and the clock used is stated in `source.clock`.
- Every scheduled instance in the chosen pass is present; instances the player destroyed have `despawnReason: killed` (note whether inferred). If the bot killed most of them and the subject is before the first checkpoint, re-record with `--no-fire`.
- `evidence.md` lists the recording folder, build fingerprint, run options, unknowns (from `track.unknowns` plus anything seen live), and any native anchors you used.
- Run `build_tracks.py summary` and paste its rows for the subject into `evidence.md`.

## Tests

From `extractor/original-autoplayer`: `node --test test_recorder.js test_agent.js` (fake Frida runtime), `C:\Python311\python.exe -m unittest test_tracks test_autoplayer` (conversion, controller).

## Limits

Frame timing matters for fast flyers: native event programs advance in whole frames, so hitches (the 2026-10-26 fire run took a 25–32 ms frame about every 0.2 s) and bomb slow-motion (director frozen, then ramped over ~0.9 s) shift later legs by several frames. Report the frame-time spread for the subject's window in `evidence.md`, and avoid bombs for timing subjects. Survival is heuristic; deaths and bombs change what the enemies do afterwards (a respawn clears bullets). Muzzles aren't observed. Telemetry timing has frame-boundary jitter of about one frame, so tolerances below ~1/60 s or one frame of travel can't be met by this tool.
