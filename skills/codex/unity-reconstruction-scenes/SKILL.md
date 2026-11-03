---
name: unity-reconstruction-scenes
description: Rebuild Unity scenes, GameObject hierarchies, serialized components, and engine systems from exported build evidence. Use for object parenting, component attachment, broken references, rendering/animation/physics/audio/UI repairs, and integration into the reconstructed editor project. Expert stage of unity-project-reconstruction.
---

# Unity reconstruction scene and engine expert

Default worker: **GPT-6.1 Sol, high reasoning** (`gpt-6.1-sol`, `high`). Apply the shared [routing policy](../unity-project-reconstruction/references/agent-routing.md). Escalate a bounded unexplained system mismatch to Astra High; the skill itself does not switch models.

This suite depends on the sibling coordinator skill. Read [scenes and engine features](../unity-project-reconstruction/references/scenes-and-engine-features.md), [component attachment](../unity-project-reconstruction/references/scripts-and-components.md), and the relevant [validation stages](../unity-project-reconstruction/references/validation-and-ledgers.md).

## Inputs and ownership

Receive pristine exports, source objects/dependencies, stable type/script maps, target editor/pipeline/packages, source scene settings and observation evidence. Own a specifically assigned Unity project or isolated staging output. Only one worker/editor may mutate a particular project at a time.

## Work

1. Audit exported hierarchy and references before rebuilding anything. Preserve valid metadata, source identities, sub-assets and source local transforms.
2. Build object/asset shells, establish parenting and sibling order, attach resolved types, restore values, then resolve object references. Map automatically added required components and make repair scripts repeatable.
3. Preserve disabled/inactive/hidden content, duplicate names, component order and scene-level settings. Separate serialized objects from runtime spawners and persistent objects.
4. Use the shared engine-feature matrix to recover every encountered system. Diagnose payload/type/link problems before shader, geometry, audio or behavior substitution. Keep unknown classes as explicit work items.
5. Restore compatible project settings, packages, input, build order and streaming semantics. Label inferred settings, reconstructed prefabs, sampled animation, rebaked lighting/navigation and replacement shaders.
6. Import, compile, reload scenes and compare structural dumps; run relevant rendered/behavior checks. Resolve failures and hand an identified stable revision to verification.

Return project/editor details, entry scenes, repair scripts, source-to-project GUID/local-ID mappings, change list, structural/visual evidence and remaining gaps. Ask the coordinator for missing code or payload evidence; do not invent it. Do not spawn further workers.


## Version targets and skill improvements

Follow the coordinator's [version policy](../unity-project-reconstruction/references/version-migration.md): new full reconstructions default to 2022.3 LTS, explicit targets override it, and existing projects keep their recorded target until migration is requested. Disabling migration retains the established/source editor. This standalone expert stage does not by itself authorize changing an existing project's editor. Keep original decoding evidence independent of the target schema; route substantial version changes to the migration expert through the coordinator.

At a meaningful repair or validation milestone, submit reusable findings under [skill improvement](../unity-project-reconstruction/references/skill-improvement.md). Record evidence, applicability and checks in the project workspace. The designated maintainer updates shared skills; keep unverified hypotheses and game-specific patches out of universal instructions.
