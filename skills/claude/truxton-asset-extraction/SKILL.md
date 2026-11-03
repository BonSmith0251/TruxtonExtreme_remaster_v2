---
name: truxton-asset-extraction
description: Extract and audit TATSUJIN EXTREME (Truxton Extreme) assets from the installed Unity IL2CPP game, including whole-game coverage and reconstruction for its Unity 2023 remaster. Use for asset extraction, missing asset investigations, dependency resolution, original animation or serialized gameplay data recovery (hit shapes, drops, physics settings), importing new prefabs into the staging project, repairing assets that import wrong (a model rendering plain white, a missing texture), and installing a validated staging change into the user's TruxtonRemaster project with backups, even if the user only says 'install them' or 'the box is white'.
---

# Truxton asset extraction

Produce reusable assets with source identities, dependencies, and an honest coverage report. A successful selected-prefab export does not establish that the whole game has been extracted.

## Start with the actual installation

The established workspace is `D:\games\Truxton Extreme`; the remaster is `C:\Users\Administrator\Documents\TruxtonRemaster`. Discover replacements if these paths no longer exist. Read applicable workspace instructions and inspect current tools before modifying them.

This build uses Unity **6000.3.7f1**, IL2CPP metadata **39**, and Addressables **2.8.0**. The user selected **Unity 2023.2.22f1 / URP 16.0.6** for the remaster. Keep that destination choice unless the user changes it. Recheck versions if the installed game changes.

Read [extraction.md](references/extraction.md) for the inventory, complete extraction workflow, codecs, and failure cases. Read [unity-import.md](references/unity-import.md) when producing, repairing or installing Unity assets, or extracting enemy hit shapes. Read [original-motion.md](references/original-motion.md) for original animation or compiled behavior analysis.

## Work from an inventory

1. Locate `analysis/inventory.json`, `analysis/objects.jsonl`, `analysis/content_paths.csv`, and the existing `extractor/` tools. Parse large JSON and JSONL files in Python; print bounded summaries. Check inventory freshness against the installation before reusing it.
2. If an inventory is missing or stale, use the existing `analysis/audit_assets.py`, or this skill's bundled `scripts/inventory_assets.py`, with explicit `--root` and `--out`. This scanner reads metadata; it does **not** extract all payloads. It requires `UnityPy==1.25.4`, the locally tested decoder.
3. For “all assets,” cover every installed source and every serialized object, including objects without container names. Include loose resources, native movies, audio, UI, DLC, and the nonstandard Comic directory. Preserve unresolved sources in the report; do not silently narrow the task to readable Addressables.
4. Reuse the existing selection exporter for supported prefab closures, and implement missing payload handlers against the inventory as needed. It has no `--all` option. Complete extraction requires more than repeating its default player export.
5. Maintain per-object and per-source outcomes: inventoried, raw preserved, decoded, imported, verified, unsupported, or failed. These are separate dimensions; raw preservation is not equivalent to a usable imported asset. Include concrete failure reasons and next steps.

## Preserve identity and fidelity

- Identify objects by source file, serialized file/CAB, and signed PathID. Store PathIDs as decimal strings. Preserve all aliases; filenames and container paths are not unique object identities.
- Resolve `m_FileID == 0` within the current serialized file; positive IDs index its external-file table starting at one. `m_PathID == 0` is null. Include resource streams and report dangling references.
- Keep original game files unchanged. Write exports separately and preserve raw data alongside converted assets. Do not replace source binaries or strip streams to make a decoder appear successful.
- Label sampled animations, shader substitutions, recreated behavior, and camera adaptations. Compiled shaders are not original Shader Graph source; IL2CPP binaries are not original C# files.
- Process large bundles sequentially, release decoded payloads, checkpoint completed work, and avoid a single in-memory whole-game dependency closure.

## Establish coverage before claiming completion

The included helper compares existing selection exports against the scanned object inventory:

```powershell
C:\Python311\python.exe '<skill-dir>\scripts\coverage.py' --inventory 'D:\games\Truxton Extreme\analysis\inventory.json' --objects 'D:\games\Truxton Extreme\analysis\objects.jsonl' --exports-root 'D:\games\Truxton Extreme\extractor' --out 'D:\games\Truxton Extreme\analysis\selection-coverage.json'
```

It checks raw JSON presence and parseability, counts manifest representations separately, and identifies unrepresented objects and source errors. It does **not** certify decoded payloads, Unity imports, HUD-only exports, native movies, or opaque comics. Supplement it with the extraction ledger and payload checks described in the reference.

Do not call the whole game extracted while installed content is unattempted, failed, or preserved only as opaque source containers. Report counts by type and representation, remaining blockers, output locations, and validation actually performed. Creating or invoking this skill does not itself authorize unrelated scene/gameplay changes.
