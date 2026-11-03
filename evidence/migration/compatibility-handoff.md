# Unity 6000.3.7 to 2023.2.22f1 compatibility handoff

Prepared 2026-10-31. Migration state: enabled, compatibility port preparation complete; target import/runtime/player validation UNATTEMPTED by migration worker. No project mutation or Unity launch performed. This is not a claim of a playable or lossless migrated game.

## Version contract

- Original: `D:/games/Truxton Extreme`, kept read-only. UnityPlayer.dll ProductVersion `6000.3.7f1 (696ec25a53d1)`; BuildSettings `m_Version` independently matches. IL2CPP metadata header `af1bb1fa27000000` => version 39.
- Recovery baseline: no verified reconstructed editor baseline supplied. Do not describe the unrelated existing remaster as this baseline.
- Requested target: `2023.2.22f1`; target path `D:/Games/TruxtonExRecon/Reconstructed`.
- Installed exact executable: `C:/Program Files/Unity 2023.2.22f1/Editor/Unity.exe`, ProductVersion `2023.2.22f1_6b19bf4f8115`.
- Tested target: none in this worker. Integrator must record actual editor report and logs.
- Platform: source StandaloneWindows64 IL2CPP. Installed target Windows support contains Mono player variations; no IL2CPP variation found. Coordinator permits a clearly labeled Windows x64 Mono build. A Mono success does not establish IL2CPP support/fidelity.
- Proposed rendering package: URP 16.0.6 with matching Core/ShaderGraph 16.0.6. Existing independent `C:/Users/Administrator/Documents/TruxtonRemaster/Packages/manifest.json` records this, its Library/PackageCache has package source, and package.json specifies Unity 2023.2. This supplies package availability evidence, not validation of reconstructed rendering.
- Original Addressables: 2.8.0 directly from StreamingAssets/aa/settings.json. Exact original URP patch, InputSystem, Cinemachine, VFX and Timeline package releases remain unknown; do not infer exact versions from engine version or assembly names.

## Reproducible source evidence

`tools/migration/probe_compatibility.py` takes explicit --source and --out. It reads four small serialized sources using UnityPy 1.25.4, retains SHA256 and complete native setting trees that decode strictly, plus 3707 MonoScript and 703 MonoBehaviour headers. Report: `evidence/migration/source-compatibility-probe.json`.

MonoBehaviour records are explicitly HEADER ONLY because runtime typetrees are stripped. Using `check_read=False` recovers their name/script pointer but does not recover their fields. A strict decode also failed PlayerSettings: 844 expected bytes, 840 consumed. Recover its schema before making claims about complete project settings. Do not pad, silently truncate or globally rewrite versions to hide this failure.

Source GraphicsSettings points to globalgamemanagers.assets PathID 3829 (`TXE_PipelineAsset`) and global settings 3838. There are eight renderer-data assets 3830..3837 (Deferred, DeferredMakeBG, Deferred_SteamDeck, Deferred_Switch2, Forward, ForwardForBG, Forward_SteamDeck, UI), two pipeline assets (3828 SteamDeck and 3829 TXE), default volumes, SSAO, FullScreenPassRendererFeature, and three `TXERendererFeatureCopyColor` objects 3843..3845. These features are evidenced as objects, but their full parameter fields and active renderer assignments are not decoded by this probe. Source built scene list is `Assets/Scenes/Boot.unity`, `Assets/Scenes/BootTXE.unity`; further gameplay scenes may be Addressable.

## Compatibility matrix and actions

| Area | Concrete evidence | Target action and boundary |
| --- | --- | --- |
| Native serialization | Unity 6000 source, partial PlayerSettings decode failure | Start clean target project. Integrate decoded fields using actual 2023 native objects/templates. Preserve source identities and local-ID mapping. Do not copy source globalgamemanagers or rewrite serializedVersion globally. |
| IL2CPP gameplay | GameAssembly.dll + metadata39; custom TXE/KANAI/InGame assemblies | Metadata/dummy DLLs only establish types/layout; executable methods require native recovery/reimplementation with explicit provenance. Do not put Unity 6000 engine DLLs or dummy gameplay DLLs into target Assets as executable recovery. |
| URP | Pipeline and multiple renderer objects + custom copy-color features | Use URP16 package source; rebuild actual target pipeline/renderer assets, map decoded supported properties, preserve/defer unparsed feature fields. Custom pass port must preserve injection event, color/depth targets, camera filtering and compositing. Source RenderGraph use is not yet established. |
| URP API generation | Official URP17 guide says render graph changes custom passes | If native recovery reveals RecordRenderGraph, port to URP16 ScriptableRenderPass Execute/SetupRenderPasses/RTHandle APIs with observed behavior. Do not import URP17 package binaries. Do not assume compatibility mode means custom passes are automatically preserved. |
| Materials/shaders | Compiled Shader objects; known original TXE shaders in remaster reference | Compiled shaders are not original ShaderGraph source. Preserve raw shader evidence and map each property/blend/depth/cull/queue to supported source shader or a labeled replacement. Flat fallback URP materials are approximate. |
| Addressables | 2.8.0 binary catalog, source engine6000 bundles | Retain keys/labels/dependencies and source mapping; recover editable assets and rebuild target content/catalogs. Do not fill the project with original opaque bundles or load them as proof of target compatibility. Select exact target-compatible package only after package.json/API check; no version is prescribed by this report. |
| Cinemachine/Input/Timeline/VFX | Assembly names in ScriptingAssemblies.json; Unity.Cinemachine namespace in MonoScripts | Add packages only when recovered serialized types/references require them. Confirm target package minimum editor and type identities; Cinemachine3 namespaces must not be silently mapped to Cinemachine2. VFX compiled payload is not editable graph recovery. |
| Native DLLs | Galaxy64, steam_api64, GfxPluginNVIDIAReflex, lib_burst_generated | Inventory importer platform/CPU and real entrypoints. Third-party x64 plugins require runtime validation. Regenerate Burst with target packages; do not copy source lib_burst_generated as target jobs implementation. Preserve GOG/Steam distinctions. |
| Game graphics DLL set | Unity6 GPUDriven, ShaderRuntime, hierarchy etc in source assembly list | Presence of an engine assembly does not prove gameplay dependency. Use original references/call sites to decide required ports; do not recreate every listed engine assembly. |
| Windows player | Target only Mono player variations found | Build x64 Mono per coordinator authorization; retain import/build/start/teardown logs, real graphics capture. Record backend departure from original. |

## Integrator sequence

1. Keep pristine extraction and ledgers outside Assets. Save source-to-target GUID/local-ID mappings. Use one project owner/editor. With limited D disk, avoid copying source bundles or Library caches.
2. Create target 2023.2.22f1 project; set standalone x64 Mono and URP16.0.6. Existing package source cache may be read/copy-seeded only into the reconstruction's own package cache or embedded package copy; never symlink shared writable package state. Unity package resolution can use existing global cache if available. Copy package source closure only if necessary, preserving package.json/asmdefs; do not copy the existing remaster Library wholesale.
3. Prefer exporting decoded portable representations and creating Mesh/Texture/Material/Animation/Audio/Particle native assets with target APIs, retaining unsupported raw payloads as evidence. Obtain target serialized templates from the integrator's actual editor for any YAML generation (especially ParticleSystem nested versions). Existing source runtimes omit serializedVersion, so missing versions are not evidence for default version1.
4. Import native assets/reference mapping before executable game classes. Coordinate with code worker on type identities/assembly placement. Keep stub diagnostics explicit. Integrate only proven native behavior; an importable stub scene remains incomplete reconstruction.
5. Rebuild source boot scenes and scene transitions from actual references. Do not replace the whole game with the independent remaster's Round1 gameplay. It contains known remaster AI/combat/camera adaptations.
6. Reconstruct supported pipeline/renderer/volume assets from decoded data. Render to a real camera target; use original frame comparison before calling rendering faithful. Current header-only pipeline data cannot justify exact restoration.
7. Validate import/compile, all scene hierarchy/fields/references including inactive objects, fresh normal Play/Stop twice, startup/transitions/teardown, and actual x64 Mono player launch. Save complete logs and rendered evidence; distinguish coverage/structure/visual/behavior/player verdicts.

## Read-only reusable material from independent remaster

- Package source cache: `C:/Users/Administrator/Documents/TruxtonRemaster/Library/PackageCache/com.unity.render-pipelines.universal@16.0.6` and matching core/shadergraph directories. Other cache packages include mathematics1.2.6, burst1.8.13, collections1.4.0, ugui2.0.0; these are cache observations, not a mandated full-game dependency set.
- Importer reference: `Assets/Editor/TruxtonImporter.cs`, `TruxtonRound1Importer.cs`; inspect contracts before reuse. Existing native templates: `Assets/TruxtonImported/Settings/Renderer.asset`, `Round1Renderer.asset`, `Assets/UniversalRenderPipelineGlobalSettings.asset`. They are remaster settings, not original recovered values.
- Shader-map helper `Assets/Editor/TruxtonFlickerMaterial.cs` may demonstrate mapping `_Tx_Albedo`, `_Tx_Normal`, `_Tx_Metsllic`, `_Tx_Emission` into URP Lit. Such mapping is an approximation pending source shader analysis and frame checks.
- Installed truxton-asset-extraction skill's unity-import reference documents previous native particle-version issues and warns source export lacks serializedVersion. The old staging location referenced by that skill is absent from the clean installation; do not assume its tooling exists here.

## Proposed reusable skill improvement (not installed)

Trigger: source MonoBehaviour read_typetree succeeds with check_read=False while strict read reports unread bytes. Verified reproducer here: pipeline settings object3829 and 703 managed objects in this probe. Rule: record partial decoded byte coverage/field coverage; header-only MonoBehaviour output may identify assets but cannot establish recovered settings. Exact-size consumption should be a separate decoder check, and strict native failures must not be hidden by the partial-header mode. This strengthens extraction/validation guidance; it is a diagnostic rule, not a schema fix. Tested with UnityPy1.25.4 on this Unity6000.3.7f1 metadata39 build; no universal parser claim. Shared suite untouched.

## Official documentation consulted

- URP16 requirement table explicitly covers Unity2023.2: https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@16.0/manual/requirements.html
- URP17 custom-pass/render-graph changes: https://docs.unity3d.com/6000.0/Documentation/Manual/urp/upgrade-guide-unity-6.html
- Addressables introduction (context only; page resolves to2.8.1, whereas source settings explicitly record2.8.0): https://docs.unity3d.com/Packages/com.unity.addressables@2.8/manual/index.html

No rollback of project mutations is needed because none were made by this worker. Preserve this report and probe output; target-validation state must be updated by the actual integrator/verifier rather than inferred from analysis completion.
