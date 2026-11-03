# Whole-game extraction workflow

## Installation map and evidence

Source content is beneath `TATSUJIN EXTREME_Data`:

| Location | Treatment |
| --- | --- |
| `StreamingAssets/aa/StandaloneWindows64/*.bundle` | Standard UnityFS v8 bundles; serialized type trees and internal `.resS`/`.resource` streams |
| `StreamingAssets/StandaloneWindows64/Comic/` | Separate nonstandard bundles and catalog; unresolved format in the original audit |
| `StreamingAssets/movies/` | Native MP4 and WebM; preserve each file and hash, do not assume paired encodings are identical |
| Root `.assets`, `globalgamemanagers`, `level*`, `Resources/` | Loose serialized data and resource siblings; some types lack trees |
| `StreamingAssets/aa/catalog.bin`, `settings.json` | Preserve catalogs/settings; binary runtime keys need a compatible Addressables decoder |
| `il2cpp_data/Metadata/global-metadata.dat` plus root `GameAssembly.dll` | Behavior/schema evidence; optional native analysis, separate from media decoding |

The initial audit observed 45 readable bundles, 81 opaque Comic bundles, 9 loose/built-in serialized files, 49 MP4 + 49 WebM, and 270,371 serialized object records. Counts included 530 Mesh, 1,947 Texture2D, 3,524 Sprite, 560 AudioClip, 318 AnimationClip, 315 AnimatorController, and 564 Material records. These are historical diagnostics, not current completeness targets or deduplicated asset counts. Refresh the inventory after game updates.

The bundled `inventory_assets.py` is the original metadata scanner. Its loose-file enumeration explicitly includes `level0` and `level1`; extend discovery if a changed installation has other levels or source formats. Enumerate **all** files under the data directory as a separate source ledger, so files outside that scanner's patterns cannot disappear from the denominator. Hash source files for a full extraction/resume workflow; file size and mtime alone do not establish byte identity.

Example (run only when the existing inventory needs rebuilding):

```powershell
C:\Python311\python.exe '<skill-dir>\scripts\inventory_assets.py' --root 'D:\games\Truxton Extreme' --out 'D:\games\Truxton Extreme\analysis'
```

## Reuse the local tools accurately

The existing project tools live in the game workspace, not in this skill package. Inspect their current contents; later improvements may supersede these notes. If absent, use the bundled scanner and implement the payload/dependency passes below against UnityPy rather than pretending those scripts are installed.

- `analysis/audit_assets.py`: selective bundle metadata scan; skips bulk streams.
- `analysis/probe_exports.py`: small texture/mesh/audio codec probes, not a complete exporter.
- `extractor/export_selection.py`: prefab and animation dependency closures; requires `<root>/analysis/inventory.json`, `analysis.audit_assets`, and `extractor/unity2023-native-versions.json`. BG03 export also uses `extractor/round1_metadata.py`.
- `extractor/export_hud.py`, `audit_gameplay.py`: sprite output and serialized UI/gameplay values.
- `extractor/export_powerups.py`: 19 known pickup visuals.
- `extractor/export_player_spawn.py`, `export_player_motion.py`: two entrance clips and precise source motion data.
- `extractor/export_intro.py`: entrance effects and byte-for-byte original takeoff movie copy. It also writes staging Unity content; inspect before running for an extraction-only task.

Run from the game root, with the installed Python that has UnityPy:

```powershell
C:\Python311\python.exe extractor/export_selection.py --prefab player01.prefab --out extractor/player-output
C:\Python311\python.exe extractor/export_selection.py --prefab pf_bs03.prefab --out extractor/boss-output
```

`--prefab` and `--clip` are repeatable. Select a unique container filename or an exact container path. Both omitted means the default two ships plus entrance clips. An explicit prefab selection does not automatically add the entrance clips. This exporter expects prefab roots to be GameObjects; do not pass every texture/material container to `--prefab`. Its closure cap is 50,000 objects, and animation path resolution can reject ambiguous hashes. Use bounded roots and extend generic object handling for whole-game extraction.

Only selected prefab roots become manifest hierarchies; dependency-prefab roots may remain raw JSON. `Index` uses lowercased CAB names globally and IDs use SHA256 of `cab:pathId`, truncated to 24 hex characters. Audit duplicate CABs across sources before trusting this mapping; the whole-game ledger must retain source identity and expose collisions instead of overwriting them.

## Complete extraction passes

Maintain a source ledger and stream an object ledger rather than retaining every decoded object in memory. A useful object record is:

```json
{"source":"relative/source.bundle","cab":"cab-name","pathId":"-1234567890123456789","type":"AudioClip","aliases":[],"raw":{"status":"ok","files":[]},"decoded":{"status":"failed","reason":"missing stream"},"imported":{"status":"not_attempted"},"verified":{"status":"not_attempted"}}
```

Use actual output paths, sizes, hashes, and relevant format checks for successful records. Checkpoint by source fingerprint plus exporter version/options; skip only verified matching outputs on resume. Reconcile inventory totals and explicitly account for duplicates. Copying a bundle establishes source preservation, not decoded asset coverage.

1. **Serialized objects:** enumerate every serialized file's objects, including unnamed/non-container objects. Preserve raw serialized bytes and type information when possible, readable type-tree JSON when available, container aliases, and external tables. Keep NaN/infinity as tagged/string values, bytes as binary files or base64, and every nested `m_PathID` as a string. JSON dumping alone can lose stream-backed payloads.
2. **Resource streams:** load each source with UnityPy's full environment for decoding; the metadata-only loader cannot supply pixel, vertex, or audio buffers. Preserve or copy referenced bundle nodes and loose stream siblings and validate offsets/sizes. A complete raw archive needs all those bytes and mappings.
3. **Visual payloads:** decode textures and sprites independently. Save original dimensions, color space, wrap/filter/mipmap settings, normal-map intent, sprite rect/pivot/border/packing/rotation/atlas references. PNG may lose compression/mips/HDR; retain source representations. Export all mesh attributes, UV sets, submeshes/topology, skin weights, bind poses and blendshapes when present. OBJ is a static geometry probe, not a complete mesh archive. The existing mesh importer lacks full skinned/humanoid support.
4. **Audio:** this build's 560 inventoried audio records reported Vorbis. The installed UnityPy `obj.read().samples` returned filename-to-bytes WAV output in the validated music probe. Decode every returned sample, preserve source streams, and check channels/rate/frame count/duration. Empty samples or codec errors remain failures. Do not assume one record always means one sample.
5. **Animations and controllers:** preserve original clip records, events, bindings, controllers/state machines and Timeline data. Decode streamed, dense, constant and compressed formats with explicit support accounting. Resolve hash bindings against the correct hierarchy, report ambiguity, and validate samples and tangents. Read the motion reference for exact streamed cubic reconstruction.
6. **Materials, shaders and effects:** preserve shader names, keywords, queues, colors, floats, texture slots and transforms, particle component trees, VFX data, lights and cameras. Separate raw representation from shader compilation or rendering equivalence. Keep MonoBehaviour settings and their script identities without inventing original code.
7. **Remaining types:** include TextAsset binary content, fonts, atlases, video records, settings and other classes discovered by the inventory. Unsupported conversion must still have raw preservation or an explicit failure. Never silently skip unknown types.
8. **Native media and opaque sources:** copy original movies with matching SHA256 and inspect streams/duration. Inventory all Comic files, record headers and hashes, and investigate the actual comic loader/provider when full extraction requires it. The initial 81 files fail standard UnityFS signatures; neither renaming nor ignoring them solves extraction. Do not call them corrupted or invent a codec. Keep exact blocker evidence if the format remains unresolved.

## Validation and reporting

Reconcile source files first, objects second, decoded payloads third. Per-type counts must distinguish raw-only data, decoded files, importable objects and verified runtime assets. Count identities, not filenames; preserve aliases and distinguish shared dependencies from duplicated records.

Verify representative and unusual payloads for each supported codec, plus every failed or boundary case. Check mesh index bounds/attribute lengths, texture dimensions, audio headers/duration, animation bindings/times/curve samples, PPtr targets, stream ranges, and copied-media hashes. Record file paths and errors rather than only a success total.

`scripts/coverage.py` understands existing `dependency_graph.json` + `manifest.json` selections and parseable `raw/<id>.json`. It detects a listed object whose raw output is missing and avoids double-counting overlapping selections. It intentionally cannot certify independent HUD/movie outputs or binary raw archives. For new exporters extend the ledger/reconciliation explicitly; do not inflate this report's coverage with guessed identities. “All assets extracted” requires no unattempted installed source and no unresolved required payload; otherwise state exactly which supported subset succeeded.
