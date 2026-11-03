# Worked example: TATSUJIN EXTREME reconstruction prefabs (2026-11-02)

Project `D:/games/TruxtonExRecon/Reconstructed` (Unity 2023.2, already in the standard layout via unity-project-layout). 2,312 prefabs in the project; the organiser was scoped to the remaster's own `Assets/Prefabs` (142), not the 2,170 in the extracted original library `Assets/OriginalGame`, whose names and folders match the original game's data. Work files: `D:/games/TruxtonExRecon/verification/prefabs`.

Survey (4 s): variants 0, with nested prefabs 10, used only by other prefabs 38, unused 2, named as strings in code/data 78, Resources 0, missing scripts 0. Folders: 102 flat in `Prefabs/`, 37 in `Prefabs/Dedup/BG03` (output of a scene-dedup tool, tracked by its `dedup-manifest.json`), 3 in `Prefabs/Gameplay`.

Rules: the defaults plus one project rule near the top, `{"name": "Effects", "name_re": "^(pf|sp)_eff_"}`, because the default Projectiles rule (`laser`) caught `pf_eff_e_laser_energy01` / `pf_eff_e_laser_muzzle01`, which are charge and muzzle glows.

| Folder | Prefabs |
| --- | --- |
| Dedup/BG03 (kept: tool output) | 37 |
| Effects | 38 (`pf_eff_*`, `sp_eff_*`, BombBurst, a particle-only `pf_bs03`, `pf_Point Light_explosion`) |
| Pickups | 34 (`pf_item0*`, `Pf_item_*`, `Pf_Item_Box0*`) |
| Enemies | 20 (`Pf_Ene_*`, `Pf_EneObj_*` meteors and burnt ground) |
| Projectiles | 9 (`enemybullet00*`, `enemylaser000`, PlayerBullet, EnemyBullet) |
| Environment | 3 (`BG03`, `Pf_BGObj_ColorBox*`) |
| Player | 1 (`player01`) |

Run: PrefabCheck before (all 23 scenes, 2,341 prefabs incl. packages), LayoutMover 105 moves, `Prefabs/Gameplay` removed, 0 errors; rewrite found 1 path string (an editor check); one joined path (`os.path.join(ASSETS, 'Prefabs', name)`) in a tool fixed by hand; PrefabCheck after: 105 moved, 0 problems; the project's own checks (hit-flash 12/12, arcade play 37/37) unchanged; no crash.

Lessons:
- 78 of 142 names are looked up as strings (the enemy and model tables use the original prefab names), so renames were off the table; moves alone were safe.
- `BG03` is matched as a "name reference" because it is also the stage key in JSON tables: name matching over-reports, by design; confirm such cases rather than trusting them.
- The dedup tool's folder must stay (or move together with its manifest rewritten), otherwise the tool re-creates prefabs instead of reusing them on its next run.
- `Player` came out as `player`: the asset database remembered an old folder's case. LayoutMover now renames such folders through a temporary name; check the new tree's spelling anyway.
- A prefab only nested inside prefabs of different categories (`pf_Point Light_explosion` in the player and two dedup prefabs) is not a Part of any one of them in practice; the name rule put it in Effects, which is fine.
