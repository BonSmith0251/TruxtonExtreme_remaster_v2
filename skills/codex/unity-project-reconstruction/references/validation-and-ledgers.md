# Evidence and validation

## Persistent records

Maintain these logical records in JSON/JSONL or a small database; reuse equivalent existing formats. Keep evidence outside Assets. Do not confuse file counts with object coverage when exports contain sub-assets or combine source objects.

- **Run:** source roots/fingerprints, platform/backend/version evidence, tool/editor/package versions, commands/configuration, timestamps and output paths.
- **Source:** path/container membership, size/hash, read/parse status, streams, errors and expected catalog dependencies. Retain unrecognized files.
- **Object:** compound source identity, class/type/script identity, aliases, scene/owner, raw and decoded outputs, import result and destination GUID/local IDs. Represent signed PathIDs and large Unity local IDs as decimal strings.
- **Reference:** owning object, serialized property path, original pointer, resolved source target, destination reference and outcome. Distinguish original null, editor/built-in resolved, resolved, missing and ambiguous edges.
- **Issue:** owner/type/scene, stage, concrete failure, evidence, attempted remedy, runtime consequence and next action.

Track inventory/read, raw preservation, decode, export, import, attachment/reference resolution and verification separately. Each can pass, fail, be unattempted, blocked, or not applicable with a reason. Separately record provenance: recovered, evidence-based reconstruction, approximate or stub. An imported placeholder remains a stub.

Count unique source objects by type/scene at each stage, including unnamed objects. Report missing streams and unresolved references separately. Use all discovered source objects as the denominator, and additionally report unparsed/failed containers whose unknown objects cannot be counted. Never report 100% coverage over only the readable subset.

## Validation stages

1. **Coverage:** reconcile all inputs/objects; expose absent catalog content, failed containers, unsupported types and raw-only exports. Hash-check preserved payloads where appropriate.
2. **Import/compile:** open with recorded editor/packages and retain logs. Verify script assembly/type resolution and asset imports. A zero process exit alone is insufficient.
3. **Structure:** dump every recovered scene/prefab through editor APIs, including inactive objects. Compare source identities, parents, siblings, local transforms, active/enabled state, component types/order, serialized values and reference targets. Check duplicate GUIDs, missing scripts, unresolved links, invalid UnityEvents and sub-assets. Account for original nulls and built-in references.
4. **Visuals:** match camera, resolution/aspect, pipeline, quality, color space, time and exposure. Inspect textures, skinning, sprites, animation, particles, lighting and UI. Null-graphics/headless success cannot validate rendering; use a graphics-capable run.
5. **Behavior:** exercise startup, scene transitions/additive loads, spawning, input, physics, animation/events, cameras, audio, UI and core loops. Compare deterministic/time-aligned observations with the original. Use isolated save/config state where practicable to preserve user progress.
6. **Player:** build the target and launch it. Editor success does not prove plugin inclusion, platform shaders, streaming content or standalone startup. Retain logs and tested paths.

For editor automation, use supported flags, a purpose-built static entry method, an explicit project path and log file. Write a completion report only after checks finish and exit nonzero on failure. Starting Unity with `-executeMethod` does not prove execution completed. Coordinate domain reloads and asynchronous imports; never race multiple editors against one project. Run long batch imports under the [resource watchdog](#resource-preflight-and-watchdogs-for-batch-editor-runs).

Repair in dependency order: parser/schema issues, missing payloads, package/assembly conflicts, script types, reference mappings, then visual/behavior differences. Recheck affected dependents. Preserve pristine exports and auditable repair history rather than repeatedly replacing everything.

## Handoff

Report assets recovered/imported by type with discovered totals and unknown containers; scenes/hierarchies structurally checked; script/type coverage versus executable behavior; visual/runtime/player checks actually performed; and missing source, approximations and blockers.

An editable reconstruction can be useful without exact source recovery. A runnable menu does not prove whole-game fidelity. If the editor/original/target platform cannot run, mark validation unverified and still deliver recoverable content/evidence. Do not call an import-only or stubbed project a fully reconstructed playable game.

## Normal editor entry regression

Test the user's ordinary workflow as well as specialized harness entry points: open a recovered gameplay scene in a fresh editor session, press Play, stop, and press Play again. A test that opens only Bootstrap or explicitly loads settings can hide missing editor package initialization. Inspect an actual frame for visible, usable UI; active objects and a camera do not prove that menus render. Record process completion and scan teardown errors.

If a BeforeSceneLoad hook replaces the active scene while the editor processes it, investigate an editor playModeStartScene pointing to the evidenced bootstrap scene; preserve the user's edited scene and verify the native crash is gone. For recovered player-only packages, inspect missing editor discovery/loading hooks and state across domain reloads. Restore editor asset loading with original identities, keys and labels where needed; keep player loading separate. In a coroutine, yielding a Task is not proof that Unity awaited it: verify the actual yieldable operation and completion before dependent scene loading.

## Distinguish reference GUIDs from internal identifiers

A text search for every guid token overcounts asset references. In a verified export audit, AudioMixer exposed-parameter GUIDs were internal identities, and missing-prefab GUID text occurred inside object names; neither was a broken PPtr. Identify actual fileID-plus-guid reference records and resolve their local subassets. Handle other declared reference schemes, such as Addressable asset keys, through their own semantics rather than discarding them or treating every GUID-shaped string as a PPtr. Preserve the original owner/property path and distinguish unknown semantics from a proven missing target.

## Lossless JSON evidence for non-finite floats

Unity serialized values can contain positive or negative infinity and NaN. Python's default JSON writer can emit these as bare non-standard tokens, causing strict JSON consumers to reject otherwise valid object ledgers. Validate ledger syntax with a strict reader and use an explicit tagged representation such as {"$float":"Infinity"}; preserve the original raw bytes and record the tag convention. Do not silently replace these values with null, zero or an unmarked string, and do not change the Unity asset just to make the evidence serializable. A verified 269,642-row ledger contained 139 original Infinity values; a normalized ledger retained all rows and values while passing strict JSON parsing.
## Test explicit animation sampling in the player

AnimationClip.SampleAnimation can appear correct in the editor but fail for a non-Legacy clip in a standalone player when the sampling root has no Animator. This was observed as repeated runtime errors and a static camera despite a rendered gameplay frame. Check the actual clip kind, root and binding paths; provide the required Animator without silently replacing the clip, timing or existing controller. Validate sampled poses at distinct times in the player and inspect the log. A screenshot or editor-only animation test cannot establish that the recovered camera/model animation executes in the standalone build.
## Verify diagnostic settings restoration on disk

A temporary render-pipeline probe can persist changes even when its finally block restores both live GraphicsSettings and QualitySettings asset assignments and their equality checks pass. A verified Unity 2023.2 probe cleared the serialized pipeline GUIDs and changed antiAliasing while its in-memory restoration check returned true. Before a diagnostic, retain exact settings bytes and hashes. After the owned editor exits, compare the frozen file manifest; preserve any changed copies/diffs, restore only matching original bytes, and verify their hashes. Reference equality is not proof that serialized project state was preserved. An external runner can guarantee post-exit restoration; keep its process and filesystem operations scoped to the reconstruction project.

## Resource preflight and watchdogs for batch editor runs

Before package resolution, a first import or a large reimport, check free space on the project drive and on the drive holding Unity's caches, and record both in the run record. On Windows the UPM cache (`%LOCALAPPDATA%\Unity\cache\upm`) is on the system drive, so a project on another drive can still fill it. In one run the system drive reached 0 MB free during package resolution, and interrupted downloads had left large partial files in the cache's `db\tmp` directory. Set a minimum free space below which a run does not start. Remove download partials only when no editor or package process is using them, and log what was removed.

Run batch editor processes under a watchdog that stops only the process it started when the log exceeds a size limit or free space falls below the minimum, and records why. A repeating import error can grow a log by gigabytes without the process exiting (see [scene-owned objects](scenes-and-engine-features.md#scene-owned-objects-exported-as-standalone-assets)). Diagnose from the first distinct repeated message near the log head. A watchdog stop is a failed run.

## Audit script GUIDs around reference rewrites

Before and after any bulk remap of script or asset references (for example [package DLL to UPM script remapping](scripts-and-components.md#remapping-exported-package-dll-scripts-to-upm-packages)), resolve every actual `{fileID, guid, type}` reference record to an existing asset GUID in the project or its resolved packages, then compare the two audits. The remap should reduce unresolved references to its documented residue and introduce none. An existing GUID does not prove the fileID names the intended class; check a sample of remapped components in the editor for missing scripts and field values.
