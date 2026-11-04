---
name: unity-game-to-project-skill
description: "Where the Unity build->project skill and its test lab live, and how Truxton Extreme work has been scoped (Codex later did the extraction)"
metadata:
  node_type: memory
  type: project
  originSessionId: 4281d122-463f-4911-9241-274a902c894e
  modified: 2026-10-26T21:50:12.981Z
---

On 2026-10-20 I built the user-level skill `unity-game-to-project` at
`C:\Users\Administrator\.claude\skills\unity-game-to-project` (Python stages + Unity editor
rebuilder + self-test on a generated sample game "StarDrift"). Lab/venv/test outputs live in
`D:\UnityRebuildLab` (venv: `D:\UnityRebuildLab\.venv`). Only Unity 2023.2.22f1 is installed
here, with Mono Windows player support only (no IL2CPP module), so the IL2CPP stub path is
tested by forcing stub mode on a Mono build.

The original request was to run it on Truxton Extreme (`D:\games\Truxton Extreme`, Unity 6000.3.7f1
IL2CPP, GOG install files present). On 2026-10-20 the user chose "build the generic skill, don't
touch Truxton Extreme".

Update 2026-10-26: the user then had Codex do the work on that folder anyway, and asked me to
review it. Codex's output: `analysis/` (UnityPy inventory), `extractor/` (export/install scripts,
~20 timestamped `Backups/`, no git), a Round 1 remaster at
`C:\Users\Administrator\Documents\TruxtonRemaster` (mirrored in `extractor\UnityProject`), and a
Frida-based autoplayer for the original game in `extractor\original-autoplayer` (launchers in the
game root). Reviewing/working on it is now the user's call, not a standing restriction.

See [[unity-skill-design-notes]] for pipeline gotchas.
