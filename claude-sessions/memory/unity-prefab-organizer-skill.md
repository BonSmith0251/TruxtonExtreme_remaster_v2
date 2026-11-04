---
name: unity-prefab-organizer-skill
description: "Skill ~/.claude/skills/unity-prefab-organizer (2026-11-02): survey/plan/move/check prefabs into Prefabs/<Category>, built on unity-project-layout's mover; applied to TruxtonExRecon"
metadata:
  node_type: memory
  type: reference
  originSessionId: 578e15a9-8c87-41ce-b321-e0d917c6803a
  modified: 2026-11-02T22:15:10.547Z
---

`~/.claude/skills/unity-prefab-organizer` (user: "and then make the skill for prefab", chose "organise prefabs"). Depends on
[[unity-project-layout-skill]] (sibling folder: LayoutMover.cs, rewrite_paths.py). Scripts: prefab_survey.py,
default_rules.json + prefab_plan.py, PrefabCheck.cs + prefab_check_diff.py (before/after health by GUID).

Applied to TruxtonExRecon on 2026-11-02 (user: "Organise"): 105 of 142 prefabs moved into Assets/Prefabs/{Effects 38,
Pickups 34, Enemies 20, Projectiles 9, Environment 3, Player 1}, Dedup/BG03 kept, no renames (78 named in code/data).
Work files + undo manifest in D:/games/TruxtonExRecon/verification/prefabs; tools left in Assets/Scripts/Editor/PrefabTools.
See [[truxton-recon-project]].

Self-test caveat: TMP here is the 8.3 short path C:/Users/ADMINI~1/...; Unity opened on a short path compiles scripts
but cannot bind them to classes (prefabs save with m_Script fileID 0). Both skills' self-tests now convert the work dir
with `cygpath -m -l`; use long paths for any throwaway Unity project.
