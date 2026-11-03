# Reconstruct a Cocos game in Unity

Use when Cocos/Cocos Creator is the source and the user requests a Unity project. Recover assets, serialized state and behavior evidence, then implement their Unity equivalents. Deliver editable scenes, prefabs and C# with reproducible import tooling. A Cocos editor project may be a useful intermediate, but is not the requested final result. A texture collection, Android wrapper or WebView running the original game does not satisfy Unity reconstruction.

## Discover the source and missing content

Follow [Android package inventory](android-apk.md) for APK sets and safe staging. Identify Cocos Creator 2.x/3.x, Cocos2d-x JS/Lua/native, or a customized fork using entrypoints, configuration schemas, engine strings and loader evidence. Do not infer an exact editor version from an app version or a single directory name. Use the decoder/runtime for the evidenced schema; don't force older Cocos2d-x or Creator 3.x through a Creator 2.4 decoder.

For Creator bundle layouts inspect startup scripts, `src/settings.js` or `.jsc`, each bundle's `config.json`, `import/`, `native/`, script entrypoints and any manifests. Built asset catalogs can carry paths, types, UUIDs, packed assets, scene entries and version information. Capture those tables before renaming files. See [Cocos 2.4 asset bundles](https://docs.cocos.com/creator/2.4/manual/en/asset-manager/bundle.html); select documentation matching the source before applying its schema.

Trace hot-update search paths and explicit split-resource lists. Record both the immutable packaged revision and the effective runtime revision if an original run loads newer content. A catalog listing a texture, model or sound is not evidence that its native payload is present. Compare exact references with APK members, supplied companion packs and accessible original caches; distinguish absent payloads, unknown lookup rules and decoding failures. Do not fabricate missing graphics from filenames or infer that abundant JSON means complete assets. Follow [Cocos hot-update behavior](https://docs.cocos.com/creator/2.4/manual/en/advanced-topics/hot-update.html) when relevant, and validate any project-specific overrides.

Before concluding that payloads missing from the APK are unavailable, inspect bundled download manifests and the shipped URL rewrite/loading code. If they identify same-revision public files, recover them with bounded, resumable requests, expected-size/hash checks and separate provenance. Validate archive paths and expanded sizes before unpacking. A current remote manifest or successful HTTP response alone does not establish build identity. Keep APK-only coverage separate from coverage augmented by verified downloads. Flags such as `hasNativeDep` may control eager loading; trace deferred native loading before interpreting them as evidence that pixels are unnecessary.

If native libraries are absent, inspect supplied splits before concluding that the engine is JavaScript-only. Track unavailable scripts, libraries, content packs and server requirements as separate dependencies. Continue JSON/asset/scene recovery where evidence permits; a missing native library need not block those stages.

## Extract into an intermediate representation

The extraction role handles Cocos formats here, not AssetRipper/UnityPy object decoding. Inventory all bundles and payloads; retain raw files and hashes. Decode compact UUIDs, indexed path/type tables, packed imports and dependency tables using version-correct source/loader behavior. Short pack identifiers are not necessarily UUIDs. Preserve original keys alongside normalized UUIDs. Treat minified class IDs as unresolved until script registration evidence links them to types.

Before declaring catalog imports missing, inspect the actual asset-reader overrides (for example native adapter `fsUtils.readJson`). A validated Creator 2.4.6 build resolved virtual `.json` names from a preload pack, then bucketed `.txt` packs, then individual files. Its texture records also used compact string wrappers expanded by the reader. Decode the evidenced delimiter/escaping and precedence rules, retain pack member plus virtual filename and payload hash as provenance, and compare representative outputs with the original reader semantics. These names and encodings are game-specific examples, not standard Cocos pack formats. Reconcile catalog coverage after virtual-file resolution; a `.json`-only filesystem scan is insufficient.

Serialized JSON may be a compact table-based encoding rather than a list of ordinary objects. Resolve class/property tables, object references, UUID dependencies, defaults and typed values before conversion. Do not use regex replacement or a guessed array position to rewrite scenes. Validate a decoder against representative scenes, prefabs, textures and nested references; when possible compare decoded values with a matching original runtime. A successful JSON parse establishes syntax only.

Validate constructor defaults and custom deserializers against the shipped engine where available. An official decoder with inert constructors can validate the compact wire format while missing fork-specific defaults or texture dimensions. When original and decoded texture dimensions differ, follow the shipped UV normalization behavior rather than assuming the physical image size is the atlas coordinate space. Preserve the raw fields alongside resolved values.

Create a neutral record for each source asset/object: package hash/content revision, bundle, raw and normalized asset key, pack/member/object index, class, serialized properties, dependencies, native payload status and Unity destination. Preserve raw fields not yet understood. Local object references and cross-asset UUID references are distinct. Never invent Unity PathIDs for these records; map them to stable generated GUID/local-fileIDs, preserving `.meta` files across reruns.

Separate coverage counts for catalog entries, packed objects, native payloads present, decoded objects, imported assets, attached components and behavior verified. Handle aliases and duplicate names without merging distinct source identities. Produce explicit unresolved-reference and unknown-component lists, including the source field that requires each dependency.

## Recover scripts and implement behavior

The code role investigates JavaScript/TypeScript output, Lua or native Cocos behavior as evidenced. For `.jsc`, determine the actual encoding from file headers and the matching loader: encrypted/compressed source and engine-specific bytecode need different recovery methods. Do not assume the suffix means readable JavaScript, IL2CPP or one fixed encryption scheme. Native Creator builds can encrypt scripts; see [native build options](https://docs.cocos.com/creator/2.4/manual/en/publish/publish-native.html).

Trace supplied loader configuration/native initialization for supported decoding parameters. Keep recovered script material and any application-specific decoding details in project evidence. Validate decoded output by parsing it, checking module/class registrations and linking serialized fields to source classes; readable fragments alone do not prove recovery. If required loader/library evidence is unavailable, identify the exact dependency and continue independent scene/data work. Do not execute extracted startup code blindly: it may delete caches, access services or mutate saves.

Recover component registrations, serialized defaults, lifecycle order, events, timers/tweens, scene transitions, resource loading, pooling, saves and game-state changes. Translate their observable semantics into C#; textual JavaScript-to-C# replacement is insufficient. Account for dynamic properties, numeric coercion, callback binding, asynchronous completion and frame/time units where used. Preserve original method/module locations in the mapping ledger. Distinguish directly recovered constants/data, behavior reconstructed from code, behavior inferred from observation, approximations and stubs.

Isolate service interfaces when original code depends on a backend. Reconstruct client behavior supported by evidence; an offline fixture or mocked response is a test aid, not recovered server logic. Keep a runnable local slice progressing without reporting absent multiplayer/economy/account systems as complete.

## Generate the editable Unity project

The scene role owns one Unity project and deterministic editor importers. Create the target in the selected Unity editor (default 2022.3 LTS). Record source Cocos version separately; Unity migration is not applicable until a Unity baseline exists. Preserve the original presentation and choose the target render pipeline from its needs, not from an assumed Cocos-to-Unity equivalence.

Use these as mapping candidates and validate semantics before committing:

| Source feature | Unity reconstruction and checks |
| --- | --- |
| Node, hierarchy, activation | GameObject with Transform/RectTransform; preserve parent/sibling order, local pose, active flags and component bindings. Measure axis, handedness, units and rotation conversion with known landmarks. |
| Canvas, Widget, Layout | Canvas/RectTransform and layout adapters; match design resolution, fit policy, anchors, pivots, sizes, clipping and draw order. Do not turn every 2D node into UI or assume identical anchor semantics. |
| SpriteFrame, atlas, Sprite | Texture/Sprite with SpriteRenderer or UI Image; restore trimmed rectangle, original size, offset, rotated packing, pivot, nine-slice borders and blend state. Retain atlas provenance. |
| Labels and fonts | Text component with supported font/glyph data; match wrapping, overflow, spacing, alignment, outlines and localization. Record font substitution as an approximation. |
| Prefabs, scene assets | Unity prefabs/scenes from decoded object graphs; reconnect nested references, custom component fields and event targets after identities are stable. |
| Mesh, material, camera | Recover vertex/index data, skinning and texture links; reconstruct shaders/projection from evidence. Check winding, UV orientation, transparency, depth and color space. |
| Animation, actions, particles | Clips/controllers or explicit C# timing/effect adapters; preserve curves, interpolation, tracks, loop modes and events. Validate relevant Spine/DragonBones data/runtime versions separately. |
| Input, collision, physics | Unity components/adapters with measured coordinate conversion, shape/offset, groups/masks and update order. Similar API names do not prove equal simulation. |
| Audio, resource loading, storage | Audio clips/mixer behavior and mapped asset loader/save interfaces; preserve timing, volume, lookup aliases and asynchronous behavior. |

Decode texture payloads by actual format, including encountered compressed textures or wrapped images; preserve source bytes and alpha. A `.pkm`/compressed texture without a working decoder remains present-but-undecoded. A missing image is missing, even if its SpriteFrame record is intact. Do not fill the final game with unlabeled placeholder art. Preserve unknown custom component data in sidecar records while its behavior is investigated.

## Milestones, validation and handoff

First recover a dependency-complete entry scene or small gameplay slice: asset graph, layout, input, one meaningful action and its state transition. This is an intermediate milestone; continue through all requested scenes/systems rather than declaring a loading screen or asset browser a finished reconstruction. If missing payloads prevent that slice, assemble the recoverable scene structure and exact dependency report without claiming playable fidelity.

The verifier compares the original APK or version-matched original recordings against a frozen Unity revision. Match viewport, state, timing and input; check scene structure, reference identity, visual layout, animation, input responses, lifecycle and save/load behavior. Test import reruns for stable identities and preserved manual changes. Record editor compilation, Play Mode, Android build and device behavior separately. If the original cannot run, static checks can pass while runtime fidelity remains inconclusive.

Check serialized structure and initialized presentation separately. Engine preload/lifecycle methods can change sprite sizes, camera fitting and inherited render state before the first frame. Use expectations derived from the shipped engine or original observations; a converter matching its own copied fields is not an independent fidelity test.

Deliver the editable Unity project and entry scenes, extraction/decoding/import scripts, source-to-Unity maps, component/behavior coverage, captured comparison evidence and an actionable gap report. Export a `.unitypackage` with dependencies only if requested; it supplements the full project and does not preserve all Packages/ProjectSettings on its own. Clearly distinguish recovered Cocos content from newly implemented Unity code and indicate which requested features are actually playable.
