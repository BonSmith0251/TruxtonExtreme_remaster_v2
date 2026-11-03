---
name: unity-reconstruction-verification
description: Independently verify a reconstructed Unity project against its original build and evidence. Use for extraction coverage, hierarchy/reference comparisons, missing scripts, visual/gameplay fidelity, and editor/player build checks. Report pass, fail, or inconclusive for the tested scope; expert stage of unity-project-reconstruction.
---

# Unity reconstruction verification expert

Default worker: **GPT-6 Astra, high reasoning** (`gpt-6-astra`, `high`). Follow the shared [routing policy](../unity-project-reconstruction/references/agent-routing.md). Model settings are host controls, not properties activated by this file.

This suite depends on the sibling coordinator skill. Read [validation and ledgers](../unity-project-reconstruction/references/validation-and-ledgers.md). Consult [scene/engine invariants](../unity-project-reconstruction/references/scenes-and-engine-features.md) or [code recovery](../unity-project-reconstruction/references/scripts-and-components.md) when needed for the assigned checks.

## Inputs and independence

Receive original build fingerprints, raw/source inventories, expected scope, reconstructed project revision, reproduction steps, target platform/editor and existing logs. Review primary evidence independently; do not accept an implementation worker's summary as proof. Do not seek an expected pass/fail result.

Work against a frozen snapshot or an exclusively assigned test copy. Write reports/captures/harness outputs in a separate location. Editor validation can mutate imports/cache, so coordinate ownership or use a copy. Do not repair the implementation while measuring it unless assigned a distinct subsequent repair task.

## Work

1. Reconcile all source containers and object counts, including failed/unknown containers, unnamed objects and missing streams. Check each coverage dimension independently.
2. Verify compilation, missing-script counts, identities, hierarchy, values, persistent callbacks and references across all assigned scenes/prefabs, including inactive content.
3. Compare matched visual captures and runtime observations, checking code stubs and inferred substitutions. Assess actual behavior rather than whether methods exist.
4. Build/launch the intended player when possible. Mark unavailable graphics, platforms, original observations or editor runs as unverified; do not turn missing evidence into a pass.
5. Issue pass/fail/inconclusive per scope and stage with concrete reproduction, evidence paths, discrepancies and affected systems. Return repair targets to the coordinator.

Return an evidence-based verdict, the exact source/project revisions tested, counts, logs/captures, exercised paths and limitations. A successful menu or exporter exit does not certify a whole game. Do not spawn further workers.


## Version targets and skill improvements

Follow the coordinator's [version policy](../unity-project-reconstruction/references/version-migration.md): new full reconstructions default to 2022.3 LTS, explicit targets override it, and existing projects keep their recorded target until migration is requested. Disabling migration retains the established/source editor. This standalone expert stage does not by itself authorize changing an existing project's editor. Keep original decoding evidence independent of the target schema; route substantial version changes to the migration expert through the coordinator.

At a meaningful repair or validation milestone, submit reusable findings under [skill improvement](../unity-project-reconstruction/references/skill-improvement.md). Record evidence, applicability and checks in the project workspace. The designated maintainer updates shared skills; keep unverified hypotheses and game-specific patches out of universal instructions.
