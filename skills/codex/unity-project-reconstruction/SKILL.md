---
name: unity-project-reconstruction
description: Reconstruct an editable Unity project from a compiled Unity game, or rebuild a Cocos/Cocos Creator game in Unity when Unity is the requested destination. Coordinate asset extraction, code recovery or C# translation, scenes, optional Unity migration and verification with expert roles. Use for whole-game reconstruction and Android APK, split APK/APKS, XAPK/APKM, AAB or OBB recovery, including Cocos-to-Unity conversion. Covers desktop, mobile and WebGL inputs. Identify the source engine before choosing tools. Not needed for ordinary development in an intact source project.
---

# Unity project reconstruction

Produce an editable project with the fullest recoverable asset coverage, faithful scene graphs, attached components, and tested behavior. Treat reconstruction as an evidence-driven engineering task, not a one-click export. Continue from analysis through import, repair, and validation within the user's requested scope.

The source engine and destination engine are separate choices. For Cocos input with Unity explicitly requested, proceed with the [Cocos-to-Unity branch](references/cocos-to-unity.md): recover source evidence and create a new Unity implementation. This does not require another confirmation merely because the source is Cocos. Identify it as cross-engine reconstruction; do not claim an original Unity project existed inside the APK.

## Expert skills and agent settings

Read [agent-routing.md](references/agent-routing.md) before assigning work. This is the coordinator skill. For full reconstruction, delegate substantial independent work to the following expert skills when agent tools are available. A narrow fix can remain with one expert. These are workflow defaults, not benchmarked capability guarantees; a user-selected model/effort overrides them.

| Role | Skill | Requested model | Reasoning effort |
| --- | --- | --- | --- |
| Coordinator | This skill | `gpt-6-astra` recommended for the main session | `high` |
| Build and asset extraction | [unity-reconstruction-extraction](../unity-reconstruction-extraction/SKILL.md) | `gpt-6.1-sol` | `medium` |
| Scripts and native behavior | [unity-reconstruction-code](../unity-reconstruction-code/SKILL.md) | `gpt-6-astra` | `high` |
| Scenes and engine systems | [unity-reconstruction-scenes](../unity-reconstruction-scenes/SKILL.md) | `gpt-6.1-sol` | `high` |
| Unity version migration | [unity-reconstruction-migration](../unity-reconstruction-migration/SKILL.md) | `gpt-6-astra` | `high` |
| Independent verification | [unity-reconstruction-verification](../unity-reconstruction-verification/SKILL.md) | `gpt-6-astra` | `high` |

The skill supplies instructions; the host selects the model and reasoning effort. Merely reading a skill does not switch the running model. Request the listed model/effort explicitly through supported subagent controls, and report requested settings separately from confirmed settings. Do not add unsupported model fields to skill frontmatter or `agents/openai.yaml`. If delegation is unavailable, follow the expert workflows sequentially in the current session and disclose that the requested agent settings were not applied.

For Cocos input, retain these role/model assignments but use the Cocos branch as the source-recovery contract. Unity specialists apply to the generated target and verification; their Unity source-format assumptions do not apply to Cocos files. Pass each worker the branch reference and its stage-specific acceptance criteria.

## Establish the target

Inspect local instructions, the actual installation, existing exports, and available tools. Determine input, output project, desired Unity version, and whether the user wants asset recovery, scene reconstruction, or a playable game. For an unqualified request to reconstruct the project, pursue all three. Reuse prior verified work after comparing source fingerprints.

Keep the installed build unchanged. Use a separate reconstruction workspace for exports, evidence, tools, logs, and the Unity project. Respect an existing target project; back up touched assets and their `.meta` files before integration. Before package resolution or editor imports, check free space on both the project drive and the system drive that holds Unity's caches ([resource preflight](references/validation-and-ledgers.md#resource-preflight-and-watchdogs-for-batch-editor-runs)). A skill-only edit does not itself start a game reconstruction; an accompanying explicit request to reconstruct the supplied game authorizes that work.

For a **new full reconstruction**, the preferred final editor is **2022.3 LTS** (the user's default, not a claim of universal compatibility). An explicit target overrides it. For an existing reconstruction, preserve its recorded target until the user requests a change; updating this skill does not migrate the current project. Asset-only extraction does not require migration. When only the 2022.3 family is specified, use a suitable installed 2022.3 patch or obtain an official patch, and record its full version and revision in the project and validation logs. Do not write the family label as an exact ProjectVersion.txt value or silently substitute another editor family.

Unity version migration is an optional stage: the user can disable it or request the source version. If enabled by a new full reconstruction's target or by an explicit upgrade/downgrade request, use [unity-reconstruction-migration](../unity-reconstruction-migration/SKILL.md) and [version-migration.md](references/version-migration.md). An unqualified migration request targets 2022.3 LTS. If migration is disabled, retain the established editor, or the source version for a new reconstruction, and record the deviation from the preferred default.

Prefer the source editor and render pipeline for an initial recovery baseline when available, then migrate an isolated copy to the selected final editor. Record source, baseline, requested target and actually tested editor separately. Missing target installations do not authorize silently substituting a different version. Do not convert all materials to a standard shader merely to make import easier.

For Cocos-to-Unity work, record Cocos source-version evidence separately from the target Unity version. Create the Unity target directly in the selected editor (default 2022.3 LTS); this is an engine conversion, not a Unity version upgrade. A runnable Cocos baseline helps validation but is not a prerequisite for recovering available assets. Mark Unity migration not applicable unless an existing Unity target actually changes editor version.

## Workflow

For Android package inputs, first read [android-apk.md](references/android-apk.md). Establish the complete supplied package set and engine evidence before selecting exporters or delegating recovery. Carry the APK-specific evidence and validation requirements into each expert handoff. If Cocos is identified and Unity is the requested destination, use [cocos-to-unity.md](references/cocos-to-unity.md) instead of the Unity-source extraction/code steps below; retain target integration, validation and skill maintenance requirements.

1. **Inventory the whole build.** Read [discovery-and-extraction.md](references/discovery-and-extraction.md). Record platform, architecture, engine-version evidence, backend, scenes, containers, streams, assemblies, plugins, catalogs, and loose assets. The bundled `scripts/inventory_build.py` produces file inventories and detection hints, not serialized-object inventories or extractions.
2. **Export and retain evidence.** Use a project exporter where supported, supplemented by object readers and format-specific decoders. Preserve raw data and decoded fields. Cover unnamed objects, dependencies, streamed payloads, and installed optional content. Maintain the object and reference ledgers in [validation-and-ledgers.md](references/validation-and-ledgers.md).
3. **Recover code and types.** Read [scripts-and-components.md](references/scripts-and-components.md). Handle Mono decompilation and IL2CPP native recovery separately. Restore assembly identities, serialized layouts, package dependencies, and native integrations before resolving script attachments. Dummy assemblies expose types; they do not establish working behavior.
4. **Restore scenes and links.** Read [scenes-and-engine-features.md](references/scenes-and-engine-features.md). Preserve hierarchy, component order, transforms, sub-assets, settings, and serialized references. Prefer repairing a valid export over rebuilding it from names. Use phased, repeatable editor tooling for gaps.
5. **Repair engine systems.** Use the feature matrix in that reference to account for all encountered Unity classes and package types. Treat unknown types as explicit work items; do not discard them because no recipe exists.
6. **Migrate when selected.** Classify upgrade/downgrade/no-op from the actual baseline and target. Let the migration expert prepare compatibility changes; grant one integrator exclusive ownership of the target copy. Preserve the recovery baseline and source mappings.
7. **Validate and iterate.** Follow [validation-and-ledgers.md](references/validation-and-ledgers.md). Reconcile source objects with imported objects, compile, open every recovered scene, compare visuals/behavior with the original, and build/run a reconstructed player when the environment allows. Fix root causes and recheck affected systems.
8. **Improve the skills during the work.** Apply [skill-improvement.md](references/skill-improvement.md) at meaningful reconstruction milestones and before final handoff. Capture demonstrated failures, promote validated reusable guidance into this suite, and report installed improvements separately from pending proposals. This user has requested ongoing polishing; routine in-scope skill updates do not need repeated confirmation.

## Invariants

- For Unity sources, identify built objects by `(source container, serialized file, signed PathID)`. Store large IDs as decimal strings. For Cocos sources, use `(package/content revision, bundle, asset UUID or source key, packed-object index)` as described in the Cocos branch. Names, hierarchy paths, and numeric IDs alone are not globally unique.
- Resolve Unity pointers through the owning serialized file's external table; resolve Cocos references through the matching bundle/pack schema. Map source identities explicitly to generated Unity GUID/local-fileID pairs. Neither built-file external indices nor Cocos UUIDs are automatically editor GUIDs.
- Preserve exporter `.meta` files and sub-asset IDs. Do not casually regenerate metadata, deduplicate by name, or repair references with global text replacements.
- Separate asset presence, successful decoding, usable import, correct attachment, and runtime fidelity. None implies the others.
- Label recovered, evidence-based reconstructed, approximate, stubbed, missing, unsupported, and failed content. Keep provenance and implementation status separate. Compilation with empty methods is not gameplay recovery.
- Builds can omit editor tools, stripped code/assets, authoring graphs, original model sources, import settings, and prefab provenance. Investigate evidence and recreate necessary functionality where possible; never claim exact source recovery without it.
- Check installed tool help and official documentation for version-specific commands and capabilities. Record versions/configuration. Do not assume a remembered exporter CLI or IL2CPP recovery mode exists in the installed release.

## Completion

Deliver the project path/editor version, runnable entry scenes, reproducible extraction/repair scripts, source-to-project mappings, coverage by asset/component type, validation logs, and an actionable gap report. State separately whether extraction, editor import, playable behavior, and a standalone build were verified. Include migration mode, source/baseline/target/tested versions, compatibility gaps, and skill improvements actually installed (or the exact reason an update remains staged).

Do not stop at a texture folder or a successful exporter exit code when project reconstruction was requested. If a dependency prevents a stage, finish independent work and identify the exact remaining requirement. Report partial results honestly rather than promising to recover information absent from a build.
