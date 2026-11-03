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
