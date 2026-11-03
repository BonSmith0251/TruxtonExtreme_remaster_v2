# Improve the reconstruction suite while using it

The user requests continuous improvement of this reconstruction suite. Apply it at useful milestones: a diagnosed failure, a verified repair, an expert handoff or final review. Keep reconstruction moving; do not turn every observation into a skill-editing detour. If the user disables maintenance, retain project findings without installing skill changes.

## Capture, validate, promote

1. Record a candidate lesson in the project evidence: trigger, source/editor/tool versions and hashes, reproducer, root-cause evidence, proposed rule, affected expert/reference, validation performed and boundaries. Keep experiments and unverified hypotheses here.
2. Check the installed skill and existing guidance. Prefer correcting or consolidating a rule over appending another checklist. Separate a reusable diagnostic method from a game-specific patch, ID, path, shader or workaround.
3. Promote an instruction only as strongly as the evidence permits. A successful fix in one game can justify a conditional diagnostic recipe, not a universal engine patch. Record narrower applicability and counterexamples. An unresolved failure can justify a diagnostic check, never a claimed working fix.
4. Update the owning specialist/shared reference; link it from the relevant skill. Keep the coordinator focused on routing, constraints and handoffs. Keep full logs, large disassemblies, generated evidence and game-specific repair scripts in the reconstruction workspace. Do not embed secrets, saves, absolute personal paths or copyrighted payloads in reusable skills.
5. Validate frontmatter and links with skill-creator tooling; run changed helpers on an isolated representative fixture. For consequential routing/ownership/version-policy changes, exercise realistic decisions including a conflicting target, disabled migration and an unavailable editor. Structural validation alone does not establish behavioral correctness.
6. Install the validated changes using existing authorization and host filesystem permissions. Back up touched installed files and preserve unrelated metadata/policy fields. If installation is blocked, retain a ready-to-install patch and report the exact reason; do not call a staged proposal installed. Do not publish or share the suite externally without authorization.

Only one maintainer edits the installed suite at a time. Experts submit bounded proposals and evidence to the coordinator; they do not concurrently rewrite shared instructions or spawn another maintenance team. A standalone expert can perform maintenance if assigned that role. Read skill-creator before a substantive skill edit.

Record what changed, why, where, how it was checked and whether installed in a project-local maintenance ledger (JSON or concise Markdown). Include before/after hashes or a diff and link to local evidence. Mention substantive improvements in the final reconstruction handoff; do not promise automatic background learning. The loop runs when an agent invokes these skills and performs work, not when the files sit idle.

## Demonstrated diagnostic lessons

These methods arose from a Mono Unity 6000.3.10f1 reconstruction tested in 6000.6.4f1. They are conditional checks, not validated fixes for every version or for 2023.2.22f1.

- **Exporter-induced faults:** compare original and exported managed assemblies before blaming the engine. Added virtual/interface bridges can recurse even when compilation succeeds. Verify affected getters/call paths, assembly identities and reference compatibility before restoring an original DLL. Do not strip an authentic feature restriction to conceal its diagnostic.
- **Missing data despite valid links:** reference audits cannot detect omitted non-reference fields. Compare serialized component leaves with decoded original bytes and managed layouts. Patch only the evidenced component block and preserve surrounding prefab data and metadata.
- **Rendering changes:** check actual texture origin and pipeline paths for flipped output; inspect original compiled shader behavior plus property type/HDR metadata for color errors. Do not apply whole-scene flips, color-space changes or universal replacement shaders without evidence.
- **Lifecycle failures:** exercise edit-mode cleanup, leaving play during a cutscene, saved-run startup, pool teardown and removed-object tween callbacks. Pair subscriptions to the actual publisher and release only owned/live resources. Verify guards do not suppress legitimate play-mode callbacks.
- **Misleading success:** scan full logs after the process exits, including cleanup. Separate behavior passing from runtime errors, licensing/service diagnostics and resource warnings. Use actual rendered captures and never attribute physical input to automation unless it was supplied and recorded.
- **Frozen verification:** identify the exact project file revision, source hashes and applied proposals. Give verification stable files. Hash preservation proves integrity, not game fidelity; non-null references do not prove original target identity.

Refine these checks when new evidence contradicts or narrows them. Store each game's detailed reproducer and repair beside that project's evidence instead of accumulating game-specific instructions here.


### Ordinary Play Mode failures after a passing harness

A later editor regression in the same Unity 6000.6 reconstruction reproduced a native static-batching crash when a gameplay scene was open, plus localization failures on repeated Play sessions. The Bootstrap-only harness had missed this entry path. Generalize the validation method, not the game's fix: compare normal editor entry against harness setup, test two Play/Stop cycles, inspect player-only packages for absent editor loading support, and verify UI visibility. For active but invisible UI, inspect Canvas callbacks, pending layout/graphics queues and generated geometry before changing materials or scene layouts. Keep catalog mappings, bootstrap paths and compatibility code in project evidence. See [normal editor entry validation](validation-and-ledgers.md#normal-editor-entry-regression).
