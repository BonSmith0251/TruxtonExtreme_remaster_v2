---
name: unity-reconstruction-migration
description: Upgrade or downgrade a reconstructed Unity project to a chosen editor version, defaulting to 2022.3 LTS, with schema, API, package, rendering and player compatibility checks. Use when changing the target editor during build-to-project recovery or repairing reconstruction version mismatches. Optional expert stage of unity-project-reconstruction.
---

# Unity reconstruction version migration expert

Default worker: **GPT-6 Astra, high reasoning** (`gpt-6-astra`, `high`). Follow the sibling coordinator's [routing policy](../unity-project-reconstruction/references/agent-routing.md); a skill does not switch the running model.

Read [version migration](../unity-project-reconstruction/references/version-migration.md) and [validation and ledgers](../unity-project-reconstruction/references/validation-and-ledgers.md). This expert depends on the sibling coordinator; locate it if missing. Follow the coordinator's target precedence and optional-stage rules. For an unqualified migration request use **2022.3 LTS**. Do not start migration merely because the user is creating or polishing this skill.

## Inputs and ownership

Receive original build fingerprints, recovery baseline/project revision, source and actually used editor versions, selected target, platform/backend/pipeline/packages, compatibility evidence and output copy. Own a compatibility report and proposed repairs, or an explicitly assigned isolated migration project. Coordinate with the scene integrator before editor/package/project mutations; one owner/editor per project. Keep the original build and last verified baseline intact.

## Work

1. Establish enabled/disabled/no-op state and exact target availability. Record source, baseline, requested and tested versions separately. Missing target software leaves target validation unverified; do useful preparation without substituting another editor.
2. Inventory encountered serialization, packages, APIs, managed/native plugins, rendering and engine features against the target. Read official versioned documentation and inspect installed assemblies when signatures matter.
3. Choose an upgrade path with documented intermediate steps where needed, or a downgrade compatibility port into a target copy. Never treat a ProjectVersion.txt edit as a migration or assume newer serialization is backward-compatible.
4. Preserve asset identities and mappings; adapt only evidenced incompatibilities. Recover or translate unavailable systems and report unsupported/approximate behavior explicitly. Keep package migrations and game behavior recovery distinguishable.
5. Validate target import, scene/reference data, rendered behavior, startup/transition/teardown and intended player. Record losses/regressions independently from pre-existing baseline problems; hand a frozen target revision to the verifier.
6. Submit reusable validated findings through [skill improvement](../unity-project-reconstruction/references/skill-improvement.md). Keep game-specific fixes in project evidence; the designated maintainer installs suite changes.

Return migration copy and rollback paths, exact editors/packages, compatibility matrix, changes/mappings, tested configuration and verdicts, unsupported features and skill-improvement proposals. Do not claim lossless migration, complete fidelity or target support without evidence. Do not spawn further workers.
