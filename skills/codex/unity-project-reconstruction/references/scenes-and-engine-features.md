# Scenes and engine systems

## Scene graph

Recover scene lists/build order from metadata, scene containers, catalogs and loading code. Include streamed/additive scenes. Distinguish serialized roots from runtime observations and persistent objects.

Preserve each GameObject's source identity, name, tag, layer, activeSelf, static flags, ordered components, parent, sibling index and local transform. Include hidden/inactive objects and duplicate names. Transform and RectTransform are not interchangeable; anchors, pivots, offsets, sizeDelta, Canvas scaling and layout components affect final UI placement.

Prefer valid exported scenes/prefabs. Repair gaps using phased editor reconstruction:

1. Create/map assets, ScriptableObjects, and scene object shells by source identity.
2. Restore parents/sibling order and local transforms. Do not reparent preserving world position and then assume source local values survived.
3. Create resolved component types in source order and restore value fields. Account for RequireComponent additions and disallow-multiple constraints; map auto-added components instead of duplicating them. Preserve enabled states.
4. Resolve references against the completed identity map, including component references and sub-assets. Handle cycles without recursive cloning. Distinguish source nulls from new broken links.
5. Apply scene settings, save, reload and compare structural dumps. Reruns should update mapped objects rather than append duplicates.

Keep the editor out of Play Mode during reconstruction. Edit-time scripts can execute during import/component creation; stage data before enabling them and record temporary suppression. Restore source activation after graph completion.

Prefab/variant provenance can be flattened or absent in builds. Preserve the flattened structure first. Label newly created reusable prefabs as reconstructed; compare flattened components, values, references and renders. Name equality does not establish shared prefab ancestry.

Unity's [scene YAML example](https://docs.unity.com/en-us/engine/6000.0/manual/working-with-scenes/text-scene-format/yamlscene-example) illustrates scene settings and object references. Use the target editor's schema; do not treat a sample as universal.

## Feature coverage

Apply the following to encountered types. Extend recovery for unlisted types using their serialized schemas, package APIs, loader code and observed behavior.

| System | Preserve or reconstruct | Verify |
| --- | --- | --- |
| Models/meshes | Vertex streams, topology, submeshes/material slots, indices, bounds, UV sets, normals/tangents, colors, blend shapes, bone weights/bind poses, LOD groups. An extracted mesh is not the original FBX/Blender source. | Counts, winding, culling, normals, scale, silhouette and LOD transitions. Avoid unnecessary coordinate conversion inside Unity. |
| Skinning | Bone-array order, rootBone, bind poses, blend-shape weights, renderer bounds and rig hierarchy. | Multiple poses/clips; wrong bone indices may look correct at rest. |
| Textures/materials | Dimensions/formats, mip chains, cube/array/3D layers, color space, alpha, sampler settings, texture transforms, shader properties/keywords, queues/passes. | Decoding and slot bindings; diagnose pink, white, black, transparent and normal-map errors separately. |
| Shaders/rendering | Built-in/URP/HDRP configuration, pipeline assets, renderer features, variants, post-processing, compute dispatch and render targets. | GPU renders. Compiled programs do not restore Shader Graph/VFX Graph authoring graphs; document replacements and absent variants. |
| Sprites/2D | Rects, pivots, pixels-per-unit, borders, trim offsets, packing rotation, atlas links, geometry, physics shapes, sorting layers/groups, 2D lighting, tilemaps/tiles. | Frame alignment, slicing, nine-slice, batching, collisions and tile layout. An atlas PNG is not correctly imported sprites. |
| Animation | Clips, curves/bindings, tangents, compression, events, wrap/legacy flags, root motion, avatars, controllers, transitions, masks, layers, blend trees and overrides. | Binding paths, poses, timing, events, root trajectories, transitions and retargeting. Sampled transforms are a labeled fallback. |
| Cameras/Timeline | Projection/orthographic size, FOV, clipping, viewport, culling/depth, targets/stacks, physical settings, Cinemachine components, tracks, signals, exposed references and bindings. | Framing/aspect ratio, cuts, priorities, blends, timing and return to gameplay. |
| Lights/environment | Type, color/intensity, range, shadows/cookies, render settings, fog, skybox, lightmaps, renderer lightmap indices/scale-offsets, probes/reflection data. | Exposure, shadows, reflections and baked alignment before rebaking. Rebaking produces reconstructed data. |
| Audio/video | Clips/streams, rates/channels, loop cues, sources/listeners, spatial curves, mixers/snapshots/routing, middleware banks/events, video/subtitles. | Triggers, gain, pitch, loops, polyphony and synchronization. Preserve event semantics. |
| Physics | 2D/3D colliders/triggers, mesh/terrain shapes, rigidbodies, mass/inertia, constraints, joints, materials, collision matrix and time step. | Contacts, triggers, joint motion, grounding and timing; visible geometry alone does not establish collision. |
| UI/input | Canvas/layout, TMP fonts/materials/atlases/fallbacks, event systems, persistent callbacks, input actions/schemes, legacy input, localization, UI Toolkit trees/styles where present. | Resolutions, text, navigation, pointer/controller actions, languages and callbacks. |
| Particles/VFX | Modules/curves, renderer modes/materials, trails, sub-emitters, custom streams, simulation space/seeds and recoverable VFX runtime assets. | Emission/bursts, sorting, lifecycle, bounds, timing and camera dependence; absent authoring graphs may require recreation. |
| Terrain/navigation | Height/alpha/detail maps, layers, trees/prototypes, neighbors, NavMesh data, agents, areas, links and obstacles. | Scale/seams, sampling, reachability and obstacle response; rebakes are new derived assets. |
| Streaming/data | Resources paths, Addressables keys/labels/dependencies, bundle names, ScriptableObjects, TextAssets, JSON/custom binary data, localization and scene-loading semantics. | Original load keys/APIs and unload/release paths. Rebuild bundles/catalogs for the target; old bundles are not automatically portable. |
| Other systems | Cloth, constraints/IK, Animation Rigging, splines, networking, XR, DOTS/Entities/SubScenes, Burst/native jobs, custom packages and procedural generators when present. | Configuration and behavior per system. ECS baked data/native jobs require package-specific analysis and may have no GameObject equivalent. |
| Project settings | Tags/layers/sorting layers, quality, graphics, physics, time, input, audio, build scenes, defines, execution order and platform settings where recoverable. | Original ProjectSettings may not survive; label inferred/default values and test their effects. |

## Diagnosis

For missing objects, inspect scene membership, parent activation, decoding, dependencies, initialization and runtime spawning. For rendering errors, inspect payloads, references, sub-assets, material/pipeline settings and lighting before substituting assets. For motion errors, distinguish clips, bindings, state machines, root motion, physics and time-scale problems.

Retain raw data until imports are validated. If a system cannot yet be rebuilt, list its owning objects, affected scenes and required evidence rather than silently removing it.

## Compiled shader recovery checks

Detect exporter-generated shader placeholders explicitly (for example `DummyShaderTextExporter`) and classify their behavior as stubbed even when they compile. Prioritize actual material references and runtime `Shader.Find`/Resources loads; an unreferenced shader asset can still be used by an image effect.

When a UnityPy shader text export omits a render state, inspect the original serialized pass state before treating that state as default. In UnityPy 1.25.4 on a Unity 2018.2 build, exported text omitted blend operations while `m_State.rtBlend0` retained additive/alpha/multiply factors and color masks. Read depth, culling, tags, blend and stencil state independently of the generated shader text.

For D3D11 payloads on Windows, preserved shader subprogram bytes can contain a DXBC container after a Unity-specific prefix. Validate its magic and recorded container length before passing the bounded bytes to the installed D3D compiler disassembler. Disassembly plus serialized parameters can support a documented HLSL reconstruction; it is not recovered authoring source or proof of visual fidelity. Keep original variants, bytecode and property metadata, preserve shader GUIDs, and separately test target compilation and graphics output.

## Timelines ticked by unrecovered code

A PlayableDirector with `DirectorUpdateMode.Manual` and no play-on-awake only advances when game code sets its time and evaluates it. If that code is a stub, a recovered stage looks frozen even though its timelines are intact. Census each director tree by track type before writing gameplay code. Standard Animation, Activation and Control tracks can run on the target Timeline package. Custom tracks from stubbed assemblies cannot: their constructors or `clipCaps` may throw while the graph compiles.

A verified approach is a thin driver that ticks the original root director in Manual mode and disables, for that run only, the child directors whose timelines contain custom tracks. The Control playables skip disabled directors, while activation and particle control of the remaining clips still run. If the root itself holds a custom track, play a runtime copy that keeps only its ControlTracks. Never edit the original asset for this. End the presentation at the last driven clip that has content, because root duration can include empty or skipped clips. Report every skipped timeline and its custom track types. First confirm exposed references resolve (see version migration). Verify with camera travel across the timeline, captured frames and a log free of exceptions, in both edit-mode evaluation and Play.

## Reading Unity 6 D3D11 shader programs

Verified on a Unity 6000.3 IL2CPP player (shader blob parameter version 202012090), with UnityPy 1.25 reading the typetree:
- `compressedBlob` can be split into several LZ4 chunks (`offsets[0][k]`). The decompressed chunk 0 starts with int32 count, then count x (offset, length, chunk) triples. Read each entry from its own chunk; reading only chunk 0 silently loses programs in large shaders.
- Each pass's `m_PlayerSubPrograms` gives the program's blob index plus keyword indices into `m_KeywordNames`. `m_ParameterBlobIndices` gives the variant's parameter entry, aligned with it.
- The DXBC carries only ISGN/OSGN/SHDR (no RDEF). Names come from the parameter entry, which holds length-prefixed strings: texture records (name, 0, register, sampler, dim) and constant-buffer bindings (name, 1, slot, 0). `m_CommonParameters` gives material-buffer member byte offsets (`cbN[i].c` = byte 16i+4c). Annotating disassembly with these names makes translation tractable.
- Pass names and tags are in `m_State.m_Name` / `m_State.m_Tags`, not the pass-level `m_Tags`. Render state values that reference properties keep the property name.
- Hand-written built-in-style shaders may have no parameter names. Their `cb0` follows Properties order.

For URP Shader Graph sub-targets, recover only the graph's surface function from the Forward pixel program, and stop at the BRDF, SH, shadow and fog code. Wrap it in shared target-URP passes with the original per-pass render states. Write the result over the exporter's dummy stub, keeping its GUID and .meta, so every material keeps its binding without editing. Then compile every pass with each real material's keywords (`ShaderUtil.CompilePass(material, pass, true)`, then `GetShaderMessages`). Prove the check with a deliberate-error negative control. A default-keyword compile alone misses material variants. If the migration had swapped materials to a stand-in shader, restore their original shader reference and keyword lists from the pristine export once the original is recovered. Values were kept.

Scene-level rendering can live outside the stage asset. If stages load additively into a persistent boot scene, that scene's RenderSettings (skybox, ambient, fog) apply. A derived inspection scene with default RenderSettings shows the wrong sky even when every material is right.

## Scene-owned objects exported as standalone assets

An exporter can write an object that lived inside a scene, such as a ScriptableObject held by scene components, as a standalone `.asset` whose fields still point into the `.unity` file. Unity does not support references from an asset into a scene. In an AssetRipper 2.0.0 export of a Unity 2022.3 IL2CPP build imported by 2023.2.22f1, one such asset made the importer repeat `Do not use ReadObjectThreaded on scene objects!` until the log reached 1.75 GB and the editor crashed. No compile or import error named the file.

Before the first import, scan every non-scene YAML file (assets, prefabs, materials, controllers) for `{fileID: N, guid: <guid of a .unity file>, type: 2}`. Each hit is a candidate; a legitimate scene reference from an asset uses the SceneAsset form (`type: 3`), so match the exact token. Find which scenes reference the candidate back. When exactly one scene owns it, re-embed the object in that scene under a fresh unused local fileID: turn its scene-pointing references into local `{fileID: N}` and redirect the scene's references to the new ID. Move the standalone asset and its `.meta` to a removed-files area and log every rewrite. An object shared by several scenes needs an evidence-based decision, not duplication. Verified once: the re-import completed with a 2.4 MB log. Run such imports under the [batch-run watchdog](validation-and-ledgers.md#resource-preflight-and-watchdogs-for-batch-editor-runs).

## Running recovered content whose game code is stubbed

Spawning original prefabs at runtime: instantiate under an inactive parent, then destroy every MonoBehaviour from a recovered game assembly before activating the object. Awake runs even on disabled components, and throw-null stubs would fire on every lifecycle call. Keep engine and package components (renderers, animators, particles). Report the count stripped.

Data-driven systems (spawn timelines, routes, formations) can often be rebuilt from serialized data without native code. Read custom clip and ScriptableObject fields through Unity serialization (`EditorJsonUtility`, `SerializedObject`) so no stub method runs, then convert offline. Look for nesting: timelines that instantiate timelines, and conditional clips. Also look for data referenced by name strings instead of object references, and export every asset of that type, not just the referenced ones. Watch for sentinel values: a duration of 0 can mean unlimited. If an earlier independent extraction or a recording exists, diff against it event by event before generalising. In one verified case, a match of 195/301 grew to 301/301 once nested waves, name-referenced bonus spawns and muted tracks were handled.

Numerical hazards surface in captures: `pow(0,0)` is NaN on D3D, and a camera with HDR post-processing and Stop NaN off spreads one NaN pixel over the frame. Guard pow bases in recovered fresnel and rim terms. Editor batch captures across several scenes in one process can also pick up state from earlier scenes, which showed up as whole-frame black frames. Confirm suspicious frames with a single-scene run, and prefer one editor process per scene for evidence.

## Generalising an existing per-level implementation from recovered data

When an earlier hand-built level, validated against recordings, sits beside the recovered data for all the others, extend it from that data instead of writing a parallel system:
- Rebuild each of its per-level tables (stats, hit shapes, attack patterns) for every model from the original assets.
- Require an exact match on the existing level before generalising, and keep the existing tables authoritative for that level.
- Add the new data as a fallback, so the validated level cannot regress, and rerun its own regression.

Verified example: obfuscated database rows (key XOR, float bits XOR, int XOR) were decoded from the native accessors and matched 173 of 173 reference fields.

Recovered Timeline data can hide behind stubs: `TimelineClip.easeInDuration` and similar getters consult the clip asset's `clipCaps` and read 0 when that property is a stub. Read `m_Clips[i].m_EaseInDuration` through `SerializedObject` on the track instead.

When building derived scenes from a template, find every serialized reference to an object you replace (a camera and its GameObject and Transform) with a `SerializedObject` walk, re-point them, and only then delete the old object. Measure anything that needs runtime preparation on a throwaway instance, so preparation side effects are not saved into the scene. If the editor crashes natively when reopening a template after an edit in the same process, build one scene per process.

A test autopilot's hazard model can make verification misleading. If it treats every enemy as a fixed small circle, large enemies cause deaths that look like a stage bug. Log the cause of each death (the model and time of each body contact) before changing game rules.

## Reconstructing complex native behaviours (bosses) at scale

For many large native state machines (one per boss), split the work in two passes with a contract between them:
- Spec pass: one read-only worker per behaviour writes a spec from disassembly. The spec covers states, timers, movement, attacks and parts, with every constant tied to an RVA and inferences marked.
- Base layer: the coordinator writes one shared class for what the native base class provides. Here that was spawn, parts, vulnerability windows, HP state, the boss clock, fire helpers, summons and the shared destruction. Write an implementation guide for it that lists every hook and helper, with file-ownership rules.
- Implementation pass: the same workers, who still hold their context, each write one subclass. They do not open the project in Unity, because one editor owns it at a time. They can pre-check with Unity's bundled Roslyn `csc` against `Library/ScriptAssemblies`. The coordinator compiles, builds and plays each class in turn.
- Selecting the class: the scene builder picks the subclass by naming convention and falls back to the generic behaviour.

Verified: 7 bosses, 4,280 lines, zero compile errors at first Unity compile; 5 of 7 defeated by the test autopilot on first play.

Collision for big multi-part enemies:
- Keep each part's original collision circles attached to their collision transforms: store the circles in the transform's local space at spawn, then reproject them every frame. Animated legs, sliding arms and spinning wings then collide where they are drawn.
- A single outer-reach radius for a large boss made the test ship die under the boss while visibly far away.
- Model the special cases explicitly: solid but undamageable parts, and ground bosses that never touch the ship.

Stripping stub behaviours: Unity refuses to destroy a component another component requires (`[RequireComponent]`). It logs an error instead of throwing, so try/catch misses it. Skip required components until their dependents are gone.

Batch compile logs: after new scripts are added, the first compile in a batch editor log can fail with "type not found" because of a stale file list. A second compile follows once the import finishes. Judge the result by the last compile.

An elevated session (the built-in Administrator account) makes GUI editors show a blocking "running as administrator" dialog, and Unity has no switch to suppress it. `runas /trustlevel` gives a restricted process that cannot connect to the elevated licensing client. Batch mode never shows the dialog, so use batch for builds. For GUI Play verification, only if the user asks, a watcher can press the dialog's continue button. It is a Win32 #32770 dialog whose buttons are plain Button child windows that UI Automation does not expose: find the dialog with FindWindow by its title, find the button by its text, and send it BM_CLICK.

## Editor stability when scripting scene builds and Play checks

Crashes at exit are bugs, not noise. Check every editor run for "Crash!!!" in the log and exit code 139, and read the native stack.
- Remapping references after replacing an object: a `SerializedObject` walk over every component also visits ownership and prefab-link fields (`m_GameObject`, `m_PrefabInstance`, `m_CorrespondingSourceObject`, `m_Father`, `m_Children`). Re-pointing those moves components between GameObjects and corrupts the scene in memory. Unity logs "Component X has PrefabInstance different from its game object" and "GameObject does not reference component", then crashes natively when the scene is unloaded or the template is reopened. Skip those fields and the replaced object's own components.
- Calling `EditorApplication.Exit` from a `playModeStateChanged` callback can crash in `DestroyGfxDevice` with geometry jobs in flight. Exit from `EditorApplication.update` a few frames later, after unloading into an empty scene and destroying any scene-less `HideFlags.DontSave` helpers the tools created.

Generalising a hand-validated system to new levels, verified on ground enemies: first reproduce the validated level from the new pipeline (147/147 clips, 13/13 definitions, curves within 0.0035 degrees). Then have the native semantics of every program opcode the new levels use written up from disassembly, before trusting interim guesses: 4 of 6 provisional readings were wrong in detail.

Stage events can sit in nested timelines. A level's "Main" timeline may itself be exported as a nested wave, and shared waves (a level-start wave placed at 0 s in every level) carry events too. When an extracted event table is short against a validated reference, walk every nested timeline from the root clips before assuming the events come from elsewhere. Honour muted clips: in one verified case a start wave muted three of its five item carriers, which matched the recorded two. The rebuilt BG03 table then matched its validated reference 23/23.

Event-on-death behaviours (revenge bullets, drops, splits) usually depend on the cause of death: in Truxton only player-weapon kills fire death bullets, and bombs, stage-clear sweeps, ship contact and leaving the screen do not. A reconstructed damage function shared by weapons, bombs and contact must record the cause of the lethal hit before any such behaviour is ported. Selector-driven ones also depend on the game mode: three of five death selectors resolve to "none" or a percentage in Story mode. Read both rules from the native code first.

## Porting native per-enemy movers

Port each native mover as a frame-stepped class that runs at the original tick rate (60 Hz here) in the original's frame order, and check it in the editor against the spec writer's frame model before playing it in a level. Have the spec writer emit a machine-readable track, replay that track through the C# port in a batch editor method, and require position, facing and the end frame to agree. In Truxton, 11 class and route movers and 8 event-stack programs matched within 0.01-0.1 source units with identical end frames. The replay caught four real port bugs that a play test would have hidden: a constructor assignment overwriting a class's initial facing, an exact-180-degree turn tie, a route sampled without subtracting its first knot, and a root rotation that the native per-frame rotation write discards. Allow a looser tolerance only for a documented model-versus-native difference, such as a quantised lookup table indexed in double precision in the model and float32 in the port.

Before porting, read from the native code which mover mode a definition runs in. Here one attribute bit selects between an event stack and a route-mode spline mover. Route mode eases each route separately, fires events by route progress, and removes the enemy when its last route ends, with no area exit or duration limit. Also read whether the class code runs before or after the mover in the frame, and whether the class overrides the definition's routes from its prefab. Routes a class picks itself may exist only as separate route assets, not in the level timelines.

`JsonUtility` silently reads a JSON `true`/`false` as 0 when the C# field is an `int`. One boolean-valued field in an exported table read as 0 in every level until the exporter wrote 0/1. Write integers for integer fields, and compare a decoded row with the source after any exporter change.
