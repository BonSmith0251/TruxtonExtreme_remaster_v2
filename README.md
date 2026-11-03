# TATSUJIN EXTREME (Truxton Extreme) remaster v2

Unity 2023.2.22f1 reconstruction of TATSUJIN EXTREME, rebuilt from the installed game and extended into a playable
arcade remaster (all eight stages, enemies, bosses, combat, sound, coin-op cabinet with service mode).

Private repository: the original game's assets under `Reconstructed/Assets/OriginalGame` and `StreamingAssets`
are extracted from a legitimately owned copy and must not be redistributed.

## Clone

Large files (textures, audio, movies, DLLs, data dumps) are stored with Git LFS:

```bash
git lfs install
git clone https://github.com/BonSmith0251/TruxtonExtreme_remaster_v2.git
```

Open `Reconstructed/` in Unity 2023.2.22f1. `Assets/Scenes/ArcadeBoot.unity` is build scene 0; `Assets/Scenes/Hub`
links the stage inspection and play scenes.

## Layout

| Path | Contents |
| --- | --- |
| `Reconstructed/` | The Unity project (standard layout: `Assets/{Scenes,Scripts,Prefabs,OriginalGame,...}`) |
| `RECONSTRUCTION_REPORT.md`, `ENGINE_SYSTEMS.md` | Reconstruction report and engine-system notes |
| `code/` | IL2CPP metadata, recovered methods and code-recovery tooling |
| `extraction/` | Serialized-object, type-tree and reference dumps, stage enemy exports |
| `evidence/` | Specs recovered from native code (bosses, movers, route events, death bullets, ...) |
| `tools/` | Python/shell build and repair tools used by the project |
| `verification/` | Check results, layout/prefab move maps and their undo data |
| `scene-work/` | Scene reconstruction work files |
| `skills/claude/`, `skills/codex/` | Snapshots of the Claude Code and Codex skills used to build and maintain this project |

Not in the repository: `backups/`, `temp/`, Unity's `Library/`, and `extraction/pristine-export/` (a raw untouched
export that duplicates `Reconstructed/Assets/OriginalGame`; regenerate it from the game if needed).

## Skills

Copy a skill folder into `~/.claude/skills/` (Claude Code) or `~/.codex/skills/` (Codex) to use it. Some skills still
mention the old `extractor/` staging project and pre-layout paths; the project now lives only in this repository.
