# Scripts and components

## Mono

Inventory all managed assemblies, including custom assembly-definition outputs and plugins, not only `Assembly-CSharp.dll`. Inspect metadata without executing game code in the host. Preserve assembly names, namespaces/types, inheritance, interfaces, fields, attributes, references, and serialization callbacks.

Decompile with matching reference assemblies available. Keep pristine output and repair a copy. Check iterator/async state machines, lambdas, generics, unsafe code, platform APIs, reflection and compiler-generated attributes on compilation failures. Compare uncertain logic repairs against IL. Decompiled C# need not match original comments, local variable names, or project layout.

Choose source or binary use per assembly. Prefer editable source for game logic; retaining compatible plugin DLLs can be appropriate. Never import both source and DLL definitions of the same types. Do not copy player UnityEngine, UnityEditor or framework DLLs into Assets as replacements for editor libraries. Recreate asmdefs/dependency ordering as needed and preserve assembly identities used by reflection/serialization.

## IL2CPP

Pair native code and metadata from the same build/architecture. Determine metadata version and tool support. Recover type models, serialized layouts, signatures, native addresses, strings, call sites and registration data before reconstructing behavior.

Inspect the output: tools can emit empty methods, `throw null`, wrappers, partial IL, or metadata-only assemblies. An output-mode name does not prove logic recovery. [Cpp2IL dummy-assembly documentation](https://github.com/SamboyCoding/Cpp2IL/blob/development/Cpp2IL.Core/README_CORE.md) distinguishes type models from method bodies; verify the installed version's actual output.

Classify critical methods as verified recovered logic, partial native recovery, evidence-based reimplementation, or stubs. Prioritize startup, scene/asset loading, spawning, input/movement, animation, interactions, UI and saving according to the game. Correlate native code with serialized data and runtime observations. Record addresses and source fingerprints.

Stubs can temporarily unblock serialization. Preserve type/field identities and list affected behavior. Do not let silent no-ops masquerade as recovered gameplay. Keep analysis dummy DLLs outside the runtime project when using recovered source.

## Restore attachment and data

1. Capture serialized component blobs and script identities before editing. Resolve MonoScript by assembly + namespace + type, not filename alone. Native Unity components are engine types, not scripts to decompile.

2. Restore compatible MonoBehaviour/ScriptableObject types, field names/types, inheritance, enums, arrays, nested classes and attributes. Preserve SerializeReference managed type identities and reference IDs. Fix types before resaving assets that would lose unknown fields.

3. Preserve valid exporter script `.meta` GUIDs. When moving from DLL classes to `.cs` scripts, map old script objects to actual new GUID/local IDs. A class inside a DLL does not necessarily use the local ID of a source script.

4. Compile types, create/load instances, apply serialized values, then restore references after targets exist. Restore UnityEvent persistent targets, methods, argument data/types, and call states. Verify reflection-based callbacks separately.

5. Check inactive objects, disabled components, prefabs/variants and ScriptableObjects for missing scripts. Retain unknown raw blobs. Do not delete missing components to clear warnings.

Use Unity serialization APIs and the target editor schema for repairs. Narrow verified YAML edits can help; generic YAML round-trips can corrupt Unity tags, IDs and ordering.

## Dependencies and startup

Infer compatible packages from metadata/assembly references and record uncertainty. Do not combine installed packages with decompiled copies of the same types. Restore native-plugin platform/CPU filters, input backend, defines, evidenced execution order and runtime initialization hooks.

Native DLLs are not portable C# source. Track ABI/platform constraints. Trace failures in stores, networking, authentication and middleware before replacing integrations. Offline substitutes are documented behavior changes; server code absent from the build is not locally recoverable.

Runtime-created objects require creation logic or observation. Recover procedural meshes/materials, pooling, DontDestroyOnLoad objects and dynamic scenes at their lifecycle points. Avoid baking a runtime snapshot into a scene while leaving its spawner active, creating duplicates.

## Validate generated managed type trees

When built MonoBehaviour objects omit custom type trees, generate layouts from the matching original managed assemblies, then validate both exact byte consumption and decoded pointer identities. A parser returning data is insufficient: a shifted engine header can consume the expected total length yet decode the wrong script pointer.

Conditional checks demonstrated with UnityPy 1.25.4, TypeTreeGeneratorAPI 0.0.10 and Unity 2018.2 Mono:

- An AssetsTools-generated MonoBehaviour header omitted `m_Enabled` alignment. Compare its four engine header nodes with the version-matched UnityPy TPK MonoBehaviour header; preserve the custom field nodes and replace only the demonstrated mismatched header. Resolve the resulting script and owner pointers.

- UnityScript module names can omit `.dll`. Resolve the loaded module name rather than assuming filename identity; an alternate supported generator backend can recover layouts when another backend cannot locate that module. Record which backend handled each exception.

- Generated field names can lose non-ASCII characters through a native raw API even when byte sizes and values decode correctly. Compare Unicode code points with managed metadata and the export; in the tested generator, its JSON API preserved a Cyrillic identifier that the raw API replaced with `?`. Use the preserving API before diagnosing a missing serialized field.

- A generated `string[]` wrapper was labeled `string` despite a string array child. Confirm the actual managed field type before rebuilding that wrapper as `vector`. Create fresh TypeTreeNodes: mutating a node's displayed type can leave cached native-parser behavior unchanged.

Retain the failed raw object, generated tree, managed type evidence and repaired tree. Count remaining failures explicitly. Successful source decoding closes an inventory gap; compare exported values and imported attachments separately before claiming reconstruction fidelity.

## Additional verified layout and output-mode checks

The generated MonoBehaviour header alignment issue above also reproduced with Unity 6000.3.7f1 IL2CPP metadata 39, Cpp2IL dummy assemblies, UnityPy 1.25.4 and TypeTreeGeneratorAPI 0.0.10 AssetsTools. Exact byte consumption alone passed while the script PathID was shifted. Restoring the independently verified m_Enabled alignment flag and comparing both script and owner pointers recovered 726 previously failed component bodies; two other managed schemas remained unresolved. Preserve the failing and corrected trees and recheck reference identities; do not universally patch headers based only on a tool version.

If an IL-recovery mode emits only placeholders, inspect the exact installed revision's output implementation and available processors before attributing the result to binary complexity or missing configuration. In Cpp2IL pre-release.21, the inspected dll_il_recovery writer unconditionally emitted ldnull followed by throw for managed method bodies. A census confirmed that behavior across 118 assemblies. This is a revision-specific finding, not a claim about every Cpp2IL release. Keep original method-token counts separate from added helper methods, and distinguish a manually reconstructed native method from automatically recovered IL.

## Assembly transplantation and dependency cycles

When transplanting recovered types or methods with Cecil or a similar metadata writer, inspect the resulting assembly-reference graph, including self-references. A verified Unity 2023.2.22f1 crash in ReverseAssemblyDependenciesGraph::ExpandReferencesToIncludeIndirectOnes requested 8 GB during domain analysis because transplanted field types were imported as external references to their own destination assembly. Localizing the two type references to that module and removing the now-unused self AssemblyRef preserved their serialized identities and allowed domain reload to complete. Use the native stack and a dependency graph to diagnose this case; do not treat every allocation failure as ordinary memory pressure, and do not remove real inter-assembly dependencies indiscriminately. Compare field/type identities and test the repaired domain separately from gameplay.

## Entities and Burst generated code in IL2CPP recovery

IL2CPP recovery of an Entities/Burst game emits the output of Unity's source generators and IL post-processors as ordinary source: `[assembly: BurstCompiler.StaticTypeReinit(typeof(...BurstDirectCall))]` attributes, `__JobReflectionRegistrationOutput__*` and `__UnmanagedPostProcessorOutput__*` files, a `$BurstDirectCallInitializer` type (its file name can be sanitized, for example `-BurstDirectCallInitializer.cs`), and generated members inside SystemBase/ISystem types. The installed target packages regenerate all of these during compilation.

In a Unity 2022.3 IL2CPP build compiled on 2023.2.22f1 with Entities 1.2.4, the StaticTypeReinit attributes made Roslyn overflow its stack while binding InternalsVisibleTo attributes. The log showed only `Stack overflow`, with no CS diagnostic naming a file. When compilation of a Burst/Entities-referencing assembly dies without a CS error, search the recovered sources for these generator artifacts before bisecting files. The remediation that worked there: remove the StaticTypeReinit attributes; move, not delete, the registration and initializer files out of Assets; strip generator-emitted members from system types; and declare each system `partial`, since the Entities generator otherwise reports EA0007. Apply it with a logged script. Verified on 10 systems in one project. It restores compilation only: the system bodies remained stubs and stay labeled as such. Other Entities versions can emit different artifact names.

## Remapping exported package DLL scripts to UPM packages

When an exporter writes shipped package code (render pipeline, Addressables, Entities and similar) as DLLs inside Assets, replacing them with real package installs breaks every script reference unless those references are remapped. A MonoBehaviour from a DLL is referenced as `{fileID: F, guid: <DLL .meta guid>, type: 3}`. F is the first four bytes of MD4 over the UTF-8 bytes of `"s\0\0\0" + namespace + className`, read as a little-endian int32, with no separator between namespace and class. A package source script is referenced as `{fileID: 11500000, guid: <script .meta guid>, type: 3}`. Python's hashlib may lack MD4; check any implementation against the RFC 1320 vector MD4("abc") = `a448017aaf21d8525fc10ae87aa6729d`.

Build the mapping ledger from evidence, not names alone. List each build MonoScript (assembly, namespace, class) and compute its DLL fileID. Match the class in the selected package version by asmdef name, file stem and declared namespace. Record unmatched or ambiguous classes instead of guessing; a class whose file stem differs from its name, or which the selected version renamed or removed, stays listed. Rewrite only the exact ledger tokens, with backups and a per-file log, and run a [GUID audit](validation-and-ledgers.md#audit-script-guids-around-reference-rewrites) before and after. Verified once: 3,445 references from 51 package DLLs were remapped with none left unmapped. The same identities apply when moving game classes from a DLL to recovered scripts (step 3 under Restore attachment and data).
