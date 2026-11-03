---
name: unity-reconstruction-extraction
description: Analyze compiled Unity builds and extract assets with complete source, object, stream, and dependency inventories. Use for build/backend discovery, whole-build asset export, decoder failures, missing payloads, and extraction coverage. Expert stage of unity-project-reconstruction; does not alone establish a playable project.
---

# Unity reconstruction extraction expert

Default worker: **GPT-6.1 Sol, medium reasoning** (`gpt-6.1-sol`, `medium`). This is a requested worker configuration, not a model switch caused by reading this file. Apply the shared [agent routing policy](../unity-project-reconstruction/references/agent-routing.md); user choices take precedence.

This suite depends on the sibling `unity-project-reconstruction` skill. Read its [discovery/extraction guide](../unity-project-reconstruction/references/discovery-and-extraction.md) and [ledger definitions](../unity-project-reconstruction/references/validation-and-ledgers.md). If those files are absent, locate the installed coordinator skill before proceeding; do not pretend missing instructions were loaded.

## Inputs and ownership

Receive source installation/content roots, extraction workspace, prior evidence, intended editor/platform, and whether scope is selected content or the entire game. Own inventories, pristine raw exports, decoded assets, dependency maps and extraction tools. Preserve the installed build and other workers' outputs.

## Work

1. Establish platform, architecture, engine/backend/pipeline evidence and all content roots. Run the coordinator's file-inventory helper when useful, then build a serialized-object inventory with an appropriate reader.
2. Export Unity-native project representations where possible and supplement unsupported formats. Include unnamed objects and resource streams, catalogs, installed DLC and loose content. Retain raw bytes and all failed sources.
3. Resolve dependency edges by container/serialized-file/PathID identity. Keep aliases and destination mappings, with ambiguous and dangling references explicit.
4. Separate decode/export status from importer or runtime status. Do not call metadata-only scans, raw archives, or thumbnails complete extraction.
5. Send unknown field layouts or native loader questions to the code expert through the coordinator. Escalate difficult decoder/serialization ambiguity to Astra High using evidence, not repeated blind retries.

Return source fingerprints, versions/configuration, per-type coverage, raw/decoded paths, object/reference mappings, missing streams, failed containers and unresolved decoder requirements. Do not edit the final Unity project unless assigned exclusive integration ownership. Do not spawn further workers.


## Version targets and skill improvements

Follow the coordinator's [version policy](../unity-project-reconstruction/references/version-migration.md): new full reconstructions default to 2022.3 LTS, explicit targets override it, and existing projects keep their recorded target until migration is requested. Disabling migration retains the established/source editor. This standalone expert stage does not by itself authorize changing an existing project's editor. Keep original decoding evidence independent of the target schema; route substantial version changes to the migration expert through the coordinator.

At a meaningful repair or validation milestone, submit reusable findings under [skill improvement](../unity-project-reconstruction/references/skill-improvement.md). Record evidence, applicability and checks in the project workspace. The designated maintainer updates shared skills; keep unverified hypotheses and game-specific patches out of universal instructions.
