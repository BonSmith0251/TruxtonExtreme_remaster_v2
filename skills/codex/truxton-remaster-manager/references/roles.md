# Role details

Status as of 2026-10-26. Update this file when a role's tooling changes; the role skills hold the operating detail.

## Pioneer — original game (`truxton-original-pioneer`)

**Tools:** `extractor/original-autoplayer/` — Frida agent `agent.js`, opt-in `recorder.js`, `autoplayer.py` (`--record DIR`, `--no-fire`), `track_recorder.py`, `build_tracks.py` (`summary`, `build`, `player-path`). Launchers in the game folder. One controller on port 8765.

**Produces:** `observation.original.json` (truxton-track/1), `player-path.original.json`, `evidence.md`.

**Settled on live runs (2026-10-26):** the PlayableDirector time (`timeline:director`) is the schedule clock; EnemyData names come from the mover's `_baseEnemyData`; Round 1 is Ash episode 1. The original rewinds to checkpoints on death (seen at 0/30/316/347 s), so observations name a pass. The enemy layer is displaced live by −0.5 × clamp(player X/123, −1, 1) × the BG slide range (BG03: 50, so −0.20325 × player X, ±25). That's native-recovered (`extractor/enemy-layer-parallax/`), in the remaster since 2026-10-27, and checked (ledger `BG03/enemy-layer`). On death the original freezes enemies, so routes compare only up to the death. **Still open:** where the model bank lives (so roll isn't comparable yet). Bullets have no owner, so fire/laser events are attributed to the nearest enemy and muzzles are unknown.

## Extractor — remaster builder

**Skill:** `truxton-asset-extraction` (whole-game inventory, identity rules, coverage). **Specialists:** `truxton-md01-manoeuvres`, `truxton-sa01-left-entry`, `-left-flank`, `-right-entry`, `-right-flank`, `-top-entry`. Older staged copies live in `extractor/md01-manoeuvres/skills/`, `extractor/sa01-manoeuvres/skills/` and `extractor/sa01-review/skills/`; the installed Sa01 skills are assembled from the latter two (`skills.py roster` shows this). Adopt a skill into `extractor/manager/skills/` before changing it.

Works in `extractor/UnityProject` (staging) then installs into `C:/Users/Administrator/Documents/TruxtonRemaster`. Round 1 (BG03) scripts: `Assets/Truxton/Round1*.cs`; editor checks `Assets/Editor/Round1*Check.cs`. The checker's capture hooks (`Round1TrackCapture.Active?.…` in `Round1EnemyWaves.cs` and `Round1EnemyAttacks.cs`) must survive extractor edits to those files.

## Checker — remaster player (`truxton-unity-checker`)

**Tools:** `Round1TrackCapture.cs` + hooks, `Assets/Editor/Round1TrackCaptureRun.cs` (batch capture with `-truxtonNoFire`, `-truxtonPlayerPath`, …), `extractor/unity-checker/build_capture.py`, the existing `Round1*Check.RunBatch` regression harnesses, and this skill's `compare_tracks.py`.

**Produces:** `capture.remaster.json` (truxton-track/1, with cue keys) and `comparison.json`.

**Not covered yet:** the Round 1 boss (outside the wave system), pickups/drops, other rounds.

## Pairing rules for a fair comparison

- Same firing mode on both sides (`--no-fire` / `-truxtonNoFire`) for route subjects.
- Every subject: the checker replays the pioneer's `player-path.original.json`. Pursuit and aimed patterns depend on the player, and so does the parallax displacement of the whole enemy layer.
- Same clock and pass: `source.clock` is `timeline:director`, and the player path comes from the same checkpoint pass as the observation.
- Up to the player's death: the remaster has no death freeze or rewind, so later segments of that pass aren't comparable.
- Roll is excluded from verdicts until the pioneer can read the bank child.

## Manager state files

`extractor/manager/` holds `roles.json`, `ledger.json`, `skill-installs.jsonl`, `skills/` (staged managed skills) and `handoffs/`.
