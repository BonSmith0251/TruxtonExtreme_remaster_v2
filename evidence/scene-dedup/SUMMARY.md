# Stage prefab dedup (2026-11-02) — superseded by v2 below; v1 outputs in Backups/stage-dedup-v1

SceneDedup with -dedupRemap 1 on Assets/OriginalRecovered/Samples/Prefabs/Reference/Stage/BGxxStage.prefab;
new prefabs in Stage/Dedup/BGxxStage. Digest = every object/component identical after reload; frames = StagePlay_BGxx at
0/30/90/180 s pixel-identical. References from StagePlay/StageInspection scenes into each prefab: 0 missing.

| Stage | Prefabs | Copies | Instances | Size | Digest | Frames |
|---|---|---|---|---|---|---|
| BG01 | 20 | 251 | 139 | 3.14 -> 0.64 MB | True | True |
| BG02 | 30 | 3172 | 249 | 11.63 -> 0.83 MB | True | True |
| BG03 | 34 | 753 | 321 | 6.94 -> 1.13 MB | True | True |
| BG04 | 37 | 2378 | 133 | 10.09 -> 0.79 MB | True | True |
| BG05 | 39 | 1530 | 551 | 7.51 -> 1.77 MB | True | True |
| BG06 | 47 | 3047 | 729 | 10.32 -> 2.39 MB | True | True |
| BG07 | 39 | 1669 | 402 | 8.76 -> 1.28 MB | True | True |
| BG08 | 39 | 1025 | 430 | 6.73 -> 1.68 MB | True | True |
| total | | 13825 | | 65.1 -> 10.5 MB | | |

BG04/BG07/BG08 first crashed Unity (WriteCachedMetaData on a fresh prefab's second import, from the save-then-normalize
re-save); SceneDedup now saves each new prefab once. Partial outputs from those crashes: Backups/bgNN-partial-dedup-crash.
14 BG04 copies stay (referenced from inside pf_eff_bg04_electric1 copies).

# v2: shared with the game's own prefabs (2026-11-02)

Stages restored from backups and deduped again with -dedupLibrary Assets/OriginalRecovered/TXE_GraphicData (1,010 original
prefabs, flat rips): copies whose content or structure (names, component types, meshes/materials) matches an original become
instances of it, converted in place with PrefabUtility.ConvertToPrefabInstance and every value set back as overrides (layer 30,
Animators without controller, ...). Other repeats share one folder: Stage/Dedup/Shared (20 prefabs). 191 original prefabs used;
589 of 599 meteor objects are the game's meteor prefabs. The six enemy meteors (OriginalRecovered/Pf_EneObj_Meteo_*) nest
pf_ene_obj_meteo_* (layer 14 + added script as overrides), and StagePlay_BG03 now uses them instead of TruxtonImported copies.

| Stage | Top-level copies | Size | Digest | Frames | Missing refs |
|---|---|---|---|---|---|
| BG01 | 108 | 3.14 -> 0.42 MB | True | True | 0 |
| BG02 | 772 | 11.63 -> 1.27 MB | True | True | 0 |
| BG03 | 306 | 6.94 -> 0.89 MB | True | True | 0 |
| BG04 | 179 | 10.09 -> 0.71 MB | True | True | 0 |
| BG05 | 550 | 7.51 -> 1.99 MB | True | True | 0 |
| BG06 | 652 | 10.32 -> 2.51 MB | True | True | 0 |
| BG07 | 298 | 8.76 -> 1.29 MB | True | True | 0 |
| BG08 | 98 | 6.73 -> 0.55 MB | True | True | 0 |
| total | 2963 | 65.1 -> 9.6 MB | | | |
