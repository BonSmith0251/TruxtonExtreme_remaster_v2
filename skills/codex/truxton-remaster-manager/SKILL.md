---
name: truxton-remaster-manager
description: "Run and supervise the TATSUJIN EXTREME (Truxton Extreme) remaster loop: the pioneer (original-game autoplayer/telemetry) records how enemies really spawn, move and fire in each original stage; the extractor (truxton-asset-extraction plus enemy specialist skills like truxton-md01-manoeuvres and truxton-sa01-*) updates the Unity 2023 remaster from that evidence; the checker (Unity remaster autoplayer and validation harnesses) replays the remaster and compares it with the original. Use this skill whenever the user wants to advance, plan, audit or resume the remaster stage by stage, decide what to work on next, hand work between the pioneer, extractor and checker, judge whether an enemy or stage now matches the original, or update, fix, rename, install or create Truxton skills — even if they only say 'next stage', 'check round 2', 'what's left', 'manager', or name one of the three roles."
---

# Truxton remaster manager

You coordinate three worker roles until the Unity remaster plays the same as the original game. You do not do the workers' jobs yourself; you decide what each one does next, hand them precise briefs, check their results independently, keep the ledger honest, and keep the skills themselves correct and complete.

Workspace `D:/games/Truxton Extreme` (game, read-only). Manager state lives in `extractor/manager/`. Staging Unity project `extractor/UnityProject`; user project `C:/Users/Administrator/Documents/TruxtonRemaster`; editor Unity 2023.2.22f1 / URP 16.0.6. Discover replacements if these paths moved.

## The roles

| Role | Job | Resolve to |
|---|---|---|
| **Pioneer** | Plays or watches the original game and records *what actually happens*: enemy identity, spawn time, positions over time, rotation, stops, firing, HP, drops, stage events. Produces evidence, never changes the remaster. | `roles.json` → `pioneer` (tools: `extractor/original-autoplayer`) |
| **Extractor** | Turns pioneer evidence plus extracted assets and native code into remaster changes in the staging project, validates them, installs them with backups. | `roles.json` → `extractor` (`truxton-asset-extraction`) and its specialists (`truxton-md01-manoeuvres`, `truxton-sa01-*`, …) |
| **Checker** | Plays the updated remaster with the Unity autoplayer/harnesses, records the same kind of track from the remaster, and compares it with the pioneer's track. Produces a verdict, never fixes. | `roles.json` → `checker` (tools: `Round1Autopilot`, `Round1*Check.RunBatch`) |

Keeping the roles separate is the point: the checker is only meaningful because it did not write the code it judges, and the extractor is only trustworthy because it works from recorded evidence instead of guesses.

## Start of every session

1. Run `C:\Python311\python.exe <skill-dir>\scripts\skills.py roster` — it reads `extractor/manager/roles.json`, lists every installed Truxton skill (Codex `~/.codex/skills`, Claude `~/.claude/skills`), finds their staged copies under `extractor/`, and flags missing role skills and drift (installed copy edited without a staged source, or staged copy never installed).
2. Run `C:\Python311\python.exe <skill-dir>\scripts\ledger.py status` for where every stage/subject stands, then `ledger.py next` for the suggested next action per subject.
3. If a role in `roles.json` has no skill yet, creating it is the first job (see *Maintaining skills*). Read [roles.md](references/roles.md) for each role's current tools, known gaps and what its skill must contain.
4. Tell the user in a few lines: what's verified, what's in flight, what you propose next and which role does it.

If the user says their skills have other names, update `roles.json` rather than creating duplicates.

## The loop, per subject

A *subject* is the smallest thing that can be verified on its own: one enemy family/variant in one stage (`BG03/Md01/index1`), a stage's spawn schedule (`BG03/schedule`), a boss phase, a stage event. Name it `<stage>/<family>/<variant>`; the stage key is the background id (`BG03` is Round 1).

1. **Pioneer brief** → observation. Ask for a `truxton-track/1` file for the subject from the original game (and the player path when the subject reacts to the player), plus the native-code anchors that explain it. Choose the firing mode now: route subjects are recorded with `--no-fire` so enemies aren't killed early. Read [contracts.md](references/contracts.md) for the exact formats and the handoff folder layout. Accept it only if it identifies the subject unambiguously (EnemyData identity or cue, not just a class name), covers every scheduled instance, and lists its unknowns. Ledger: `observed`.
2. **Extractor brief** → change. Give the observation path and the specialist skill to use (or say none exists yet). Require a `change.json`: files touched, before/after hashes, what is original data vs adaptation, the validation the extractor ran, and the install result. Ledger: `extracted`.
3. **Checker brief** → comparison. Ask for a remaster capture in the *same frame, clock and firing mode* as the observation, replaying the pioneer's player path when one exists, then the comparison. The pairing rules are in [roles.md](references/roles.md#pairing-rules-for-a-fair-comparison). Ledger: `verified` or `mismatch`.
4. **Verify the verdict yourself** with `scripts/compare_tracks.py <observation> <capture>`. Do not just forward the checker's word: a pass you didn't reproduce goes in the ledger as `checked`, not `verified`.
5. **Route the result.**
   - Remaster differs and the observation is complete → back to the extractor with the specific deltas (which instances, when, how far).
   - Observation is ambiguous, too sparse, or disagrees with native code → back to the pioneer with what to re-record.
   - Tolerance itself is in doubt (e.g. telemetry sampling coarser than the difference) → decide explicitly, record why in the ledger note, and tighten the measuring tool rather than loosening the bar.
   - Three round trips without progress → `blocked`, with the reason, and tell the user.
6. **Fold lessons into skills** (next section), then move on.

Write every brief so the worker can act on it cold: the subject id, the input file paths, the output paths in the handoff folder, the acceptance criteria, and what not to touch. Templates are in [contracts.md](references/contracts.md#briefs).

### Running a worker

- In **Codex**: invoke the role skill (`$truxton-asset-extraction …`).
- In **Claude Code**: Codex skills don't appear in the Skill tool. Spawn a subagent whose brief starts with "Read `<path>/SKILL.md` and follow it", or read and follow it yourself when the step is small.

Single-instance resources decide what can run in parallel: there is one game process and one telemetry port (8765), and only one Unity editor may hold the staging project at a time (batch runs fail against an open project). So the pioneer can work on one subject while the extractor or checker works on another, but extractor and checker never run concurrently, and never two pioneers.

## Verdicts

`compare_tracks.py` matches instances (by cue key, else by nearest spawn), resamples both tracks at 60 Hz over their common lifetime, and reports spawn/despawn deltas, RMS and max position error, end-point error, and event timing (fire, stop, drop). Defaults are in source units and seconds; override per subject with `--tolerances`, and record the reason. Its verdict is one of:

- `pass` — all instances matched within tolerance and no missing/extra instances or events.
- `fail` — at least one quantified difference over tolerance; the report says which.
- `inconclusive` — frames or time bases differ, nothing matched, or overlap too short. Fix the capture, don't argue the number.

A screenshot or video comparison establishes identity and appearance only. Record it as supporting evidence, never as a pass. Unlabelled adaptations (render plane, fixed 60 Hz integration, camera mapping) must be listed in `change.json` so a pass isn't mistaken for bit-exact parity.

### Deliberate departures

The user may choose remaster behavior that differs from the original. Record each one here and in the extractor's `change.json`, so that the checker reports it and nobody "fixes" it back. Current ones (2026-10-28):

- **No overlap on screen.** Meteors, meteors and air enemies, and air enemies with each other never overlap. In the original, meteors push only each other (Rigidbody on layer physics3d) and pass over enemies, and enemies overlap freely.
  - `Round1MeteorField` treats enemy hit circles as obstacles.
  - `Round1Combat.SeparateAir` nudges enemies off each other by size; the nudge eases back over 0.6 s and is held to 30 units each frame.
- **Enemy bullets stop at other enemies.** In the original they stop only at meteors (the Physics2D matrix: enemyBullet × neutralObject); the remaster also stops them at every air enemy except the shooter.
- Faithful to the original, not departures: the player's bullets end at their first hit (Green passes only a destroyed enemy). Meteors don't block the laser (`_isLaserBlock` 0).

## Ledger

`extractor/manager/ledger.json`, edited only through `scripts/ledger.py` so history is kept:

```powershell
C:\Python311\python.exe <skill-dir>\scripts\ledger.py add BG03/Md01/index1 --skill truxton-md01-manoeuvres
C:\Python311\python.exe <skill-dir>\scripts\ledger.py set BG03/Md01/index1 observed --role pioneer --artifact observation=handoffs/BG03/Md01-index1/observation.original.json --note "8 cues, 2 unknown drop rolls"
C:\Python311\python.exe <skill-dir>\scripts\ledger.py status --stage BG03
```

States: `todo → observed → extracted → checked → verified`, with `mismatch` and `blocked` as side exits. A stage is done when its schedule subject and every enemy subject in it are `verified`. The whole remaster is done when every stage is. Don't summarize progress from memory; read the ledger.

## Maintaining skills

You own the skills. Workers learn things; you decide where each lesson lives and keep the skills accurate.

**Where a lesson goes**
- About one enemy family or variant (routes, timings, native addresses, quirks) → that family's specialist skill.
- About how a role's tools work or fail (telemetry fields, Unity harness flags, install procedure) → that role's skill.
- About the process (routing, tolerances that proved right, ordering) → this skill.
- Run state (what's done, what failed today) → the ledger, never a skill.

**Update a skill** when a worker hit a wrong or missing instruction, when evidence contradicted a stated fact, or when the build fingerprint changed and addresses moved. Remove statements that turned out false rather than appending a correction beside them.

**Create a skill** when (a) a role has no skill, (b) an enemy family/boss/stage system has verified recovered behavior worth reusing — follow the shape of `truxton-md01-manoeuvres`: identity, recovered native program, adaptations, evidence files, validation — or (c) the same multi-step job has been briefed three times. Name it `truxton-<family>-<topic>`, add it to `roles.json` if it serves a role, and to the ledger subjects it covers. Templates: [skill-templates.md](references/skill-templates.md).

**How to change any skill** — the installed copies are what other sessions load, so changes are staged, backed up and verified:

1. Edit the staged copy in `extractor/manager/skills/<name>/`. If the skill was never managed here, first copy the installed version there (`skills.py adopt <name>`), which also records which older staged copy, if any, it matched.
2. Keep the description specific and slightly pushy about when to trigger; keep `agents/openai.yaml` in step with it.
3. `skills.py install <name> --target codex` (add `--target claude` for skills Claude Code should load directly). It refuses if the installed copy changed since the last managed install, backs up to `extractor/Backups/before-skill-<name>-<timestamp>/`, copies, re-hashes, and logs to `extractor/manager/skill-installs.jsonl`.
4. Tell the user which skills changed and why, in one line each.

This skill is managed the same way; update it when the loop itself needs to change.

## Boundaries

- Original game files and saves are read-only inputs; the pioneer may play (which updates the save) only through the game's own controls and handlers.
- Never replace the user's open scene or the installed project's GUIDs; installs go through backups and hash checks.
- Don't mark anything verified on the basis of a single worker's claim, a screenshot, or code review.
- Ask the user before large scope changes (a new stage, a new enemy family, deleting or renaming a skill), before overwriting a skill that drifted, and before anything the roles' own skills say needs permission.
