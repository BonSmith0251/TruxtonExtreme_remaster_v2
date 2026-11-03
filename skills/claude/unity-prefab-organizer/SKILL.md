---
name: unity-prefab-organizer
description: "Organise a Unity project's prefabs: survey every prefab (components, variants, nesting, which scenes and prefabs use it, whether code or data look it up by name), sort them into feature folders under Assets/Prefabs (Player, Enemies, Bosses, Projectiles, Effects, Pickups, Environment, UI, Lighting, Cameras, Audio, Systems, with Parts/ for pieces only used inside other prefabs and variants beside their base), apply safe renames, move them inside Unity so GUIDs, variants, nested prefabs and scene instances stay linked, and prove it with a before/after prefab health check. Use whenever the user wants to organise, sort, tidy, categorise, group or clean up prefabs, asks where prefabs should go, wants a Prefabs folder structure or prefab naming convention, has a flat or messy Prefabs folder, or wants to find unused, broken or misplaced prefabs before reorganising - even if they only say 'sort the prefabs' or 'make the skill for prefab'."
---

# Unity prefab organiser

A flat `Prefabs` folder with hundreds of files is hard to work in, but moving prefabs carelessly breaks more than it seems: variants point at their base, prefabs nest other prefabs, scenes hold instances, and code or data often find prefabs **by name** (`FindAssets(name)`, a model name in a JSON table, `Resources.Load`). Moving keeps all GUID links; renaming breaks every name lookup. This skill sorts prefabs by what they are, keeps names unless a rename is proven safe, and checks the result against a snapshot taken before the move.

It builds on the **unity-project-layout** skill (sibling folder `../unity-project-layout`): its `LayoutMover.cs` does the moves and its `rewrite_paths.py` fixes path strings. Read that skill's step 5 to 7 if you have not used it; the editor-closed rule, the stale first-compile errors and the undo all apply here.

| File (scripts/) | Job |
| --- | --- |
| `prefab_survey.py` | Read-only: every prefab's components, scripts, UI root, variant base, nested prefabs, users (scenes / prefabs / other assets by GUID), name references in code and data, Resources/Addressables, missing scripts |
| `default_rules.json` | Category rules, first match wins (name patterns, components); copy and adapt per project |
| `prefab_plan.py` | Survey + rules -> `layout-plan.json` for LayoutMover and a review table (`prefab-plan.md`); variants follow their base, parts go to `<parent category>/Parts`, kept folders stay, name clashes get a sub-folder, unsafe renames are refused |
| `PrefabCheck.cs` | In-Unity snapshot keyed by GUID: prefab type, variant base, missing scripts, nested instances and missing ones; scene instances and missing ones |
| `prefab_check_diff.py` | Compares two snapshots; anything other than a path change is a problem |

`references/conventions.md` has the folder and naming conventions and the reasoning (read it when adapting rules or when the user asks how prefabs *should* be organised). `references/worked-example.md` is the TATSUJIN EXTREME survey (142 prefabs). `tests/selftest.sh` runs everything on a throwaway project.

## Workflow

### 1. Survey

```bash
python -I scripts/prefab_survey.py <ProjectRoot> --scope Assets/Prefabs [--scope Assets/Other] --extra <tools dir> --out <work>/prefabs.json
```

`--scope` picks which prefabs to organise (default: all; usually the project's own Prefabs folder, not third-party or extracted libraries). Usage and name references are searched project-wide; `--exclude <text>` leaves a file out of the name search (a one-off generator that will never run again — but a builder the project re-runs *is* a real name reference). It needs Force Text serialization (it warns otherwise). Read the summary: variants, nesting, parts, unused, named-in-code, missing scripts. Prefabs with missing scripts or unused prefabs are worth telling the user about whether or not they move.

### 2. Plan and review with the user

```bash
python -I scripts/prefab_plan.py <work>/prefabs.json [--rules my_rules.json] [--renames renames.json] --plan <work>/layout-plan.json --review <work>/prefab-plan.md
```

Look at the per-category counts and skim the review table, especially `Misc` (no rule matched) and anything that landed somewhere odd. Most projects have their own naming (`pf_eff_*`, `Pf_Ene*`, `enemybullet*`); add rules for those at the top of a copy of `default_rules.json` rather than accepting a poor default. Then show the user the proposed tree with counts, the kept folders and why (Resources, Editor, tool-generated folders like a dedup tool's output with its manifest), parts, unused and broken prefabs, and any refused renames. Let them adjust categories before anything moves.

Renames: only from an explicit `{"Old": "New"}` map the user agrees to. The planner refuses renames of prefabs named as strings in code or data, in Resources, or addressable (`--allow-named-renames` overrides, and then you must update each name reference by hand). If the user wants a naming convention applied wholesale, check the named-in-code count first: in the worked example 78 of 142 prefabs were looked up by name, which makes a mass rename a code change, not a tidy-up.

### 3. Baseline (editor closed)

Ask the user to close the project in Unity if it is open (see unity-project-layout step 5). Copy `scripts/PrefabCheck.cs` and `../unity-project-layout/scripts/LayoutMover.cs` into an `Editor` folder of the project, then snapshot:

```bash
Unity -batchmode -projectPath <project> -executeMethod PrefabCheck.Run -prefabCheckOut <work>/before.json [-prefabCheckScenes all] -logFile <work>/before.log
```

Also run whatever checks the project has, so differences afterwards can be attributed.

### 4. Move, rewrite, check

```bash
Unity -batchmode -quit -projectPath <project> -executeMethod LayoutMover.Run -layoutPlan <work>/layout-plan.json -layoutManifest <work>/moves.json -logFile <work>/move.log
python -I ../unity-project-layout/scripts/rewrite_paths.py --project <project> --manifest <work>/moves.json --extra <tools> --backup <work>/backup --dry-run
python -I ../unity-project-layout/scripts/rewrite_paths.py --project <project> --manifest <work>/moves.json --extra <tools> --backup <work>/backup
Unity -batchmode -projectPath <project> -executeMethod PrefabCheck.Run -prefabCheckOut <work>/after.json -logFile <work>/after.log
python -I scripts/prefab_check_diff.py <work>/before.json <work>/after.json
```

The diff should report only moved paths. The rewrite matters for prefab moves too: editor scripts and data files (spawn tables, a dedup manifest) often store prefab paths. Read its leftover list. Check every Unity log for crashes and judge compile errors after the last assembly copy (unity-project-layout step 7). Re-run the project's own checks.

### 5. Report

Give the new tree with counts, what stayed and why, refused renames, unused and broken prefabs found, the diff result, and the undo (restore rewritten files from the backup, then `LayoutMover.Undo -layoutManifest <work>/moves.json`). Remove the copied `PrefabCheck.cs`/`LayoutMover.cs` from the project afterwards if the user does not want them there.

## When the user only asks how to organise

Answer from `references/conventions.md`, run the read-only survey and plan if they want a concrete proposal, and stop before moving anything.
