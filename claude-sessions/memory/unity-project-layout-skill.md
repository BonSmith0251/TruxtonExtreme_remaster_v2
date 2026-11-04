---
name: unity-project-layout-skill
description: "Skill ~/.claude/skills/unity-project-layout (made 2026-11-02 from the TruxtonExRecon reorganisation): plan-driven AssetDatabase moves + manifest/undo, path rewriter, survey, self-test"
metadata:
  node_type: memory
  type: reference
  originSessionId: 578e15a9-8c87-41ce-b321-e0d917c6803a
  modified: 2026-11-02T21:42:13.009Z
---

`~/.claude/skills/unity-project-layout` (user asked "make a skill for unity project layout", 2026-11-02). Generalised from the
TruxtonExRecon layout change ([[truxton-recon-project]]): scripts/survey_layout.py (read-only survey incl. editor-open check and
hard-coded path counts), scripts/LayoutMover.cs (JSON plan -> AssetDatabase.MoveAsset, moves.json manifest, Undo),
scripts/rewrite_paths.py (manifest-driven rewrite of code/shaders/tools/docs/JSON, backups, leftover + bare-name report),
references/standard-layout.md + worked-example.md, tests/selftest.sh (throwaway Unity project, 14 checks + undo; passed).

The survey found ~180 stale `Assets/OriginalRecovered`/`TruxtonImported` paths still in TruxtonExRecon's Resources JSON and
dedup manifests (the first rewrite only scanned code/shaders); SceneDedup reuses manifest entries only if File.Exists(prefab).
Fixed on the user's yes (179 replacements in 5 JSON files, backups/before-layout-data; all 178 paths exist). Rewriter got
--exclude and a quieter leftover report (only quoted standalone folder names).
