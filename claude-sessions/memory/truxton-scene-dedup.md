---
name: truxton-scene-dedup
description: "Skill that turns duplicated scene/prefab objects into prefabs; applied to staging BG03 and installed into the user's TruxtonRemaster on 2026-10-27"
metadata:
  node_type: memory
  type: project
  originSessionId: f90bf13e-7993-4b8d-8e22-c78745980bd0
  modified: 2026-10-27T19:21:22.612Z
---

On 2026-10-27 the user asked for a skill that finds duplicated scene objects and makes a prefab for each one. I built
`truxton-scene-dedup` (staged in extractor/manager/skills, installed to ~/.claude and ~/.codex via skills.py). The tool is
the editor script SceneDedup.cs, with RunBatch report/apply and RenderBatch before/after compare. It was applied to **staging**
BG03.prefab: 37 prefabs replaced 756 copies, 6.6 MB → 1.3 MB, digest match, frames byte-identical. Backup:
extractor/Backups/before-scene-dedup-20261027T151518. Outputs: extractor/scene-dedup/.

**Why:** the user wants to save machine resources. Honest limit: runtime object/draw counts are unchanged, because builds
flatten instances. Asset size, load time and edit-once are the real wins.
**How to apply:** at the user's request the same day, I copied BG03 + Dedup/BG03 (+ .meta) + Editor/SceneDedup.cs into their
TruxtonRemaster. Its BG03 had been identical to the staging original. Backup: extractor/Backups/before-scene-dedup-user-20261027T152307.
Re-run after TruxtonRound1Importer regenerates BG03.
Related: [[truxton-remaster-manager]].
