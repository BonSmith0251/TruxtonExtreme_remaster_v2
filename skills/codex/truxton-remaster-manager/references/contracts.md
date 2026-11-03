# Handoff contracts

Every handoff is a file in `extractor/manager/handoffs/<stage>/<family>-<variant>/`:

| File | Written by | Purpose |
|---|---|---|
| `observation.original.json` | pioneer | `truxton-track/1` from the original game |
| `evidence.md` | pioneer | native-code anchors, video/screenshot refs, unknowns in prose |
| `player-path.original.json` | pioneer | original player positions `[{t,x,z}]`, replayed by the checker for player-dependent subjects |
| `change.json` | extractor | what changed in the remaster and how it was validated |
| `capture.remaster.json` | checker | `truxton-track/1` from the remaster, same frame/time base |
| `comparison.json` | checker, then manager | output of `compare_tracks.py`; the manager re-runs it |

Keep earlier rounds: when a file is replaced, rename the old one with a `.r<N>` suffix (`capture.remaster.r1.json`) so mismatches can be traced.

## truxton-track/1

Both sides use this one shape so they can be compared mechanically.

```json
{
  "schema": "truxton-track/1",
  "side": "original",
  "source": {
    "tool": "original-autoplayer observe-only",
    "build": {"GameAssembly.dll": "<sha256>", "global-metadata.dat": "<sha256>"},
    "recorded": "2026-10-26T14:03:00Z",
    "sampleRate": "telemetry ~60 Hz, median age 16 ms"
  },
  "stage": {"id": "BG03", "round": 1, "actor": "ash", "episode": 1, "difficulty": "normal"},
  "frame": "source-xz",
  "timeBase": "stage-seconds",
  "subject": {
    "id": "BG03/Md01/index1",
    "family": "Md01",
    "class": "Ene_Md01",
    "enemyData": "ene_md01",
    "identity": "f7e49704396d17d562aa6a63",
    "prefab": "Pf_Ene_Md01",
    "variant": "index1"
  },
  "instances": [
    {
      "key": "cue60.0#0",
      "cue": 60.0,
      "spawn": 60.017,
      "despawn": 71.402,
      "despawnReason": "exit",
      "hp": 40,
      "samples": [{"t": 60.017, "x": -70.0, "z": 80.0, "yaw": 180.0, "roll": 0.0}],
      "events": [
        {"t": 62.10, "type": "stop", "duration": 0.5},
        {"t": 63.00, "type": "fire", "muzzle": "muzzle01", "pattern": "md01_fire3_sel"},
        {"t": 70.00, "type": "drop", "item": "power"}
      ]
    }
  ],
  "unknowns": ["drop roll seed not observed"],
  "notes": []
}
```

Rules that make tracks comparable:

- **frame** `source-xz` means the original game's in-game root, X horizontal and Z vertical, in source units (the remaster's Sa01/Md01 projection maps these to its render plane; camera Y=400, vertical FOV 20). The remaster capture converts back to source units before writing. A different frame is allowed only if both files declare the same one.
- **timeBase** `stage-seconds` is the stage timeline clock (the one the cue times use), paused time excluded. Not wall clock, not frame count.
- **key** identifies an instance across both sides: `cue<time>#<ordinal>` from the stage schedule when known. If the side can't know the cue, leave `key` null and the comparer matches by nearest spawn time — say so in `notes`.
- Pooled enemies reuse native objects; a new instance starts when the enemy becomes active again, not when the pointer changes.
- `samples` must be time-ordered; optional fields (`yaw`, `roll`, `y`) are compared only if both sides have them.
- `events.type` vocabulary: `stop`, `fire` (one per bullet), `laser` (one per beam), `killed`, `drop`, `phase`, `damage`. Both recorders emit `stop`, `fire`, `laser` and `killed` today. `muzzle` stays null on both sides until the pioneer can observe muzzles; extra detail goes in other fields (`muzzleName`, `bulletKind`). Add new types by documenting them here.
- `instances` must cover every instance of the subject seen in the stage. Missing instances on purpose (player killed the enemy early) must have `despawnReason: "killed"` — the comparer then compares only the common lifetime.

## change.json

```json
{
  "schema": "truxton-change/1",
  "subject": "BG03/Md01/index1",
  "basedOn": ["handoffs/BG03/Md01-index1/observation.original.json", "extractor/md01-manoeuvres/annotated-cctor.txt"],
  "skill": "truxton-md01-manoeuvres",
  "files": [{"path": "Assets/Truxton/Round1Md01Motion.cs", "before": "<sha256|null>", "after": "<sha256>"}],
  "original": ["route LUTs", "speed 90", "stop delays"],
  "adaptations": ["fixed 60 Hz banking", "remaster render plane"],
  "validation": [{"command": "Round1Md01Check.RunBatch", "result": "round1-md01-validation.json", "passed": true}],
  "installed": {"project": "C:/Users/Administrator/Documents/TruxtonRemaster", "backup": "extractor/Backups/...", "hashVerified": true}
}
```

## comparison.json

Written by `scripts/compare_tracks.py --out`. Top level: `verdict` (`pass|fail|inconclusive`), `reasons`, `tolerances`, `summary` (matched/missing/extra counts), and `instances[]` with `spawnDelta`, `despawnDelta`, `rms`, `max`, `maxAt`, `endError`, `events` (matched pairs with `dt`, plus `missing`/`extra`). The manager decides routing from this file, so the checker must not edit it by hand.

## Briefs

Keep them short and complete; the worker may start with no context.

**Pioneer**

```
Use <pioneer skill>. Subject: BG03/Md01/index1 (Ene_Md01, EnemyData ene_md01 f7e497…, Round 1 cue index 1 at 60 s).
Record every instance of this subject in Round 1 from the original game as truxton-track/1 (frame source-xz, stage-seconds) to
extractor/manager/handoffs/BG03/Md01-index1/observation.original.json, with evidence.md (native anchors, capture refs, unknowns).
Observe only during the subject's window unless the autoplayer is needed to survive. Don't touch the remaster.
Done when: all scheduled instances present with spawn, samples, despawn reason and fire/stop events; unknowns listed.
```

**Extractor**

```
Use truxton-asset-extraction with truxton-md01-manoeuvres. Subject: BG03/Md01/index1.
Input: handoffs/BG03/Md01-index1/observation.original.json (+ evidence.md). Last comparison (if any): comparison.json — fix these deltas: <list>.
Change the staging project, run the skill's validation, install with backups and hash checks, write change.json in the same folder.
Don't change other subjects' behavior; list every adaptation.
```

**Checker**

```
Use <checker skill>. Subject: BG03/Md01/index1, remaster state per change.json.
Run Round 1 in the staging project with the autoplayer, record the subject as truxton-track/1 in source-xz / stage-seconds
to capture.remaster.json, then run compare_tracks.py against observation.original.json and save comparison.json.
Don't modify remaster code. Report the verdict and the three largest deltas.
```
