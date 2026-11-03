---
name: unity-reconstruction-code
description: Recover scripts, serialized types, and executable behavior from compiled Unity Mono assemblies or IL2CPP native code. Use for decompilation, missing MonoBehaviours, field layouts, dummy assemblies, native behavior analysis, and recovered assembly/package compilation. Expert stage of unity-project-reconstruction.
---

# Unity reconstruction code expert

Default worker: **GPT-6 Astra, high reasoning** (`gpt-6-astra`, `high`). Follow the shared [agent routing policy](../unity-project-reconstruction/references/agent-routing.md); reading a skill does not change the current model.

This suite depends on the sibling coordinator skill. Read [scripts and components](../unity-project-reconstruction/references/scripts-and-components.md) and [ledger definitions](../unity-project-reconstruction/references/validation-and-ledgers.md). Locate that dependency if missing.

## Inputs and ownership

Receive matching assemblies/native binaries/metadata, fingerprints, backend/architecture, source object/type inventory, target editor/packages, and a behavior scope. Own analysis artifacts, recovered source, type maps, method-status records and proposed compatibility patches. Keep scene integration separate until the coordinator grants exclusive project ownership.

## Work

1. Establish Mono versus IL2CPP evidence and actual tool support. Preserve all assembly/type identities; never use type names alone as keys.
2. Recover managed source or native type/behavior evidence with matching dependencies. Inspect actual method bodies to distinguish functional code from metadata stubs.
3. Restore serialized field layouts, attributes, inheritance, managed references and callbacks without discarding original data. Provide a MonoScript-to-project type mapping for the scene expert.
4. Restore assembly boundaries and compatible packages; prevent duplicate DLL/source or package/decompiled-type definitions. Trace native plugin and runtime initialization requirements.
5. Prioritize gameplay-critical methods using observed behavior and source evidence. Label each recovered, partial, reimplemented, approximate or stubbed method. Record native addresses and build fingerprints for uncertain findings.
6. Compile and test recovered logic where a suitable editor/runtime is available. Compilation alone is not runtime recovery. Return unresolved external/server dependencies explicitly.

Return recovered source/assembly paths, build/type maps, compiler logs, behavior evidence, method-status coverage, integration requirements and concrete remaining gaps. Do not remove components or empty methods merely to make compilation succeed. Do not spawn further workers.


## Version targets and skill improvements

Follow the coordinator's [version policy](../unity-project-reconstruction/references/version-migration.md): new full reconstructions default to 2022.3 LTS, explicit targets override it, and existing projects keep their recorded target until migration is requested. Disabling migration retains the established/source editor. This standalone expert stage does not by itself authorize changing an existing project's editor. Keep original decoding evidence independent of the target schema; route substantial version changes to the migration expert through the coordinator.

At a meaningful repair or validation milestone, submit reusable findings under [skill improvement](../unity-project-reconstruction/references/skill-improvement.md). Record evidence, applicability and checks in the project workspace. The designated maintainer updates shared skills; keep unverified hypotheses and game-specific patches out of universal instructions.
