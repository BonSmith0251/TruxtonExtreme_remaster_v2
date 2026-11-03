# Unity version migration

Read when selecting a final editor, preparing an upgrade/downgrade, or diagnosing a version-dependent failure. Default requested target: **2022.3 LTS**. Explicit user choices and an existing project's recorded target take precedence as described in the coordinator.

## Establish the migration contract

Record in the reconstruction workspace (not in this installed skill): original build engine version and evidence; baseline editor actually used; requested target; executable path and reported version; target platform/backend/graphics API; render pipeline/package versions; migration enabled/disabled and reason; project copy/rollback path. Determine direction from the baseline project version, not just the installed build. Unknown source versions remain unknown. A same-version request is a checked no-op, not an upgrade.

Keep the raw exports and last verified project. Snapshot Assets, Packages, ProjectSettings, metadata and dependency locks before opening in another editor. Use a separate target copy without transferring Library/Temp caches across versions. One owner/editor may mutate each copy. Check local packages, symlinks and external dependencies so a copy does not accidentally share writable state with the baseline. Preserve saves/preferences during runtime checks.

Confirm the exact editor and required platform modules are available. If unavailable, continue source recovery, compatibility analysis and preparation; report target import/build as unverified. Use authorized installation procedures if available; do not relabel the project as tested or substitute a convenient installed editor. Changing ProjectVersion.txt alone does not migrate assets, APIs or packages.

## Upgrade path

Consult official upgrade guides for the source-to-target interval and package-specific migration notes. Use intermediate editors when a documented migration or demonstrated failure requires them. Keep each irreversible serialization step in its own recoverable copy; a major-version hop is not proof every intermediate editor is needed. Review API Updater and reserialization diffs, GUID/local-ID mappings, changed defaults and removed features. Re-import against target-compatible packages rather than retaining copied engine internals without review.

## Downgrade path

Treat downgrade as an evidence-driven compatibility port with possible unsupported features; do not assume the upgrader has an inverse. Prefer a clean target-editor project and selectively integrate assets with preserved identities. Where newer YAML/schema cannot be read safely, decode from pristine evidence and explicitly translate fields/components into target-supported forms. Record dropped or transformed fields and runtime consequences. Never rewrite version strings or serializedVersion fields globally to hide incompatibility.

A downgrade can require rebuilding shaders/render passes, replacing unavailable APIs, translating package data and rebaking derived assets. Preserve original payloads for unsupported systems. Distinguish faithful alternatives from approximations; do not silently remove gameplay-critical components or claim completion after stubbing them. Keep the requested target when blocked, document the exact missing capability and finish independent work.

## Compatibility matrix

For each encountered system record source representation, target support evidence, action, affected assets/types, validation and remaining loss. Inspect only systems present in this build; unknown encountered classes become work items.

| Area | Migration checks |
| --- | --- |
| Serialization | Engine class schemas, managed references, renamed types, GUID/local-fileID and subasset identities, prefab overrides, UnityEvents, omitted exporter fields |
| C# and managed plugins | Compiler/runtime profile, assemblies/modules, available signatures, callbacks, stripping/reflection, duplicate source/DLL/package definitions |
| Native plugins/platform | Architecture, platform modules, ABI/runtime dependencies, backend support and player initialization |
| Packages | manifest/lock resolution, compatible package releases and transitive dependencies, editor code omitted from player DLLs, licensing constraints |
| Rendering | Built-in/URP/HDRP versions, renderer features, RenderGraph API availability, render target origin, shader variants, material properties, color/HDR metadata, volumes and post effects |
| Scene systems | Animator/controllers/events/rigs, Timeline, physics/layers, navigation, terrain, particles/VFX, lighting/lightmaps/probes, audio and cameras |
| UI/input/data | Canvas/UI Toolkit, input packages, fonts/atlases, localization, Addressables/catalogs, StreamingAssets, save serialization |

Prefer supported target package source or narrowly scoped adapters. For binary compatibility edits verify the exact type/member exists in both editor and intended player modules, preserve serialized type identities and compare changed methods/fields. Never patch a missing API to a similarly named type by guesswork. A recovered player assembly may lack essential editor behavior. The original DLL may be more faithful than a broken decompiler/exporter re-emission; verify before replacing it. Preserve authentic third-party restrictions and report their effect.

### Probe package versions before changing the target

A package version that resolves is not necessarily one that compiles on the target editor, and transitive requirements can change other packages. Choose versions in a disposable probe project on the exact target editor: resolve the candidate set, compile, then record the resolved lock including transitive packages and the first compile errors. Only then write the reconstruction's manifest. Observations on 2023.2.22f1, each from one project and not a compatibility table:

- Entities 1.3.x failed to compile because `Object.Instantiate(GameObject, Scene)` is absent; Entities, Physics and Entities Graphics 1.2.4 compiled.
- Memory Profiler 1.1.9 failed on a missing VisionOS enum value; the editor-bundled 1.1.0 compiled. Memory Profiler 1.2.x pulled Burst 1.8.29 transitively.

Prefer the newest version that compiles in the probe and fits the build's evidence. Record evidenced versions separately from inferred ones. A missing engine API usually means the release targets another editor line; do not patch cached package source to force it. Check free disk space first, because package downloads land on the system drive ([resource preflight](validation-and-ledgers.md#resource-preflight-and-watchdogs-for-batch-editor-runs)).

## Validation and delivery

Compare target against both original evidence and the retained baseline: the baseline can already contain reconstruction defects. Run target import/compile; complete scene/prefab/asset reference audits; real graphics captures; startup, transitions, spawn/animation and teardown checks; intended player build and launch. Verify reference target identity where possible, not merely non-null pointers. Include inactive and scriptable assets. Preserve whole completed logs, actual child exit codes and warnings after harness completion. Use the shared validation ledger for separate structural, visual, behavior and player verdicts.

Record configuration limits. A DX11 development build with justified shader filtering is not proof of release, DX12, XR or another platform. Diagnostic variant pruning needs source coverage evidence and remains separate from normal build settings. Report unsupported features, approximations and newly introduced regressions explicitly; do not mask a runtime error because a limited behavior check passed. Use a source/target matrix when more than one editor is validated.

Deliver the target copy, actual editor/package versions, reproducible migration changes and hashes, updated source-to-target mappings, feature matrix, checks/logs, gaps and rollback path. For an existing project, make the migrated copy reviewable before replacing the baseline; this workflow does not require an extra approval when replacement was already authorized.

## Official references

- [Unity 2023.2.22f1 release and installers](https://unity.com/releases/editor/whats-new/2023.2.22f1): historical release reference; no longer the default target.

- [Upgrade to Unity 2023.2](https://docs.unity3d.com/2023.2/Documentation/Manual/UpgradeGuide20232.html): target-specific changes; read the applicable source/target guides at execution time.

- [Unity upgrade guides](https://docs.unity.com/en-us/engine/7000.0/manual/upgrade-guides): entry point for versioned documentation, not a recommendation to change the requested target.

## Preserve native reference types during replacement

A compatibility MonoBehaviour cannot substitute for a removed native component when another engine object expects a native base type. In a verified legacy-particle migration, retaining a ParticleRenderer local ID on a data-only MonoBehaviour caused Unity to reject Renderer-typed pointers during scene loading (`PPtr cast failed`). A later non-null-reference audit can miss the loss because deserialization has already cleared the pointer.

Inventory incoming typed references before replacement. Where the target supports an equivalent native type, obtain a serialized template from the actual target editor, place the native replacement at the preserved/remapped identity, and keep raw legacy data in a separate component. Ensure a native ParticleSystemRenderer has its matching ParticleSystem and that runtime adapters configure the existing system rather than add duplicates. Compare source identities and changed component order explicitly, then load affected scenes and inspect complete logs. A successful player build without cast errors validates compatibility, not equivalence of old and new particle simulation.

## Plugin importer schemas during downgrade

When a recovered assembly exists but its types remain unavailable to the target compiler, inspect the PluginImporter representation as well as its flags and dependency closure. In a Unity 6000 to 2023.2.22f1 reconstruction, exported version 3 dictionary platformData did not expose the recovered DLLs correctly; rebuilding the metadata from an actual target-editor version 2 list template restored assembly visibility while preserving GUIDs. Editing platform flags alone had not fixed the schema mismatch. Translate only the demonstrated importer structure, retain CPU/platform/editor choices explicitly, and verify compilation plus domain loading. This does not justify a global serializedVersion rewrite.

## Input backend configuration and editor restart ownership

When an extracted project uses Input System components alongside a supplemental legacy Input implementation, select the required target backends explicitly using the actual target PlayerSettings schema. Do this before graphics validation. In a verified Unity 2023.2/Input System 1.7 migration, the legacy-only seed setting caused a modal offering to enable the new backend and restart the editor. The restarted editor had a different PID, retained the same project lock, and omitted the automation executeMethod. An original process exiting therefore did not release editor ownership. Check the exact project path, live process command line and EditorInstance record before handing ownership to another worker; never remove a live editor's lock or close unrelated editors. Both backends was appropriate for this mixed implementation, not a universal project setting.

## Player-format PropertyName in exposed references

Player builds can serialize `PropertyName` as an integer (`exposedName: {id: N}`), while the target editor YAML stores it as a string. In a verified Unity 6000.3 player to 2023.2.22f1 Timeline migration, every ControlPlayableAsset `sourceGameObject.exposedName` then loaded as id 0. Nothing failed at import, the reference audit stayed clean, and no ControlTrack clip resolved its GameObject, so manually ticked stage directors played nothing. The directors' `m_ExposedReferences` keys had been exported as `- N: {fileID: ...}`, which the editor reads as the string "N". Rewriting only the timeline side as `exposedName: N` made both sides the same PropertyName, and resolution was confirmed through `ExposedReference.Resolve(director)`.

Probe one asset in the target editor before rewriting: log `exposedName` and `Resolve()` for each clip, repair that file, re-probe, then apply the change with backups and a per-file log. Treat other PropertyName-bearing data (Timeline bindings, Animator/Playable exposed tables, package types) as separate checks. Do not assume this exact block shape for every version or exporter. A resolved reference shows the binding is restored, not that the bound behavior works; custom track or clip code can still be stubbed.
