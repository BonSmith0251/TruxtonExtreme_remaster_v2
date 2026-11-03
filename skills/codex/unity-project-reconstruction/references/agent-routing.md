# Expert routing and model selection

## Relationship between skills and agents

A skill is reusable instructions, references, and optional tools. An agent is a running worker using those instructions. The model is its underlying reasoning engine; reasoning effort is a separate supported setting. A label such as Astra-High means `model = gpt-6-astra` plus `reasoning_effort = high` in this session's spawn tool. It is not a new model or a property that makes a skill self-executing.

The coordinator's role table is the default policy for this suite. Its role assignments are engineering choices for reconstruction, not measured head-to-head model rankings. Prefer Sol for bounded extraction and implementation; use Astra High for ambiguous code recovery and independent assessment. Higher effort cannot restore data absent from the build or replace validation. Start bounded tasks at their listed setting rather than maximizing every setting.

Official references checked 2026-10-30:

- [Build skills](https://learn.chatgpt.com/docs/build-skills): skill structure, discovery, and UI/dependency metadata.
- [Subagents](https://learn.chatgpt.com/docs/agent-configuration/subagents): model/effort selection, inheritance, and custom-agent configuration. Custom-agent TOML uses `model_reasoning_effort`; the current spawn tool uses `reasoning_effort`. Do not interchange field names blindly.
- [GPT-6 Astra](https://developers.openai.com/api/docs/models/gpt-6-astra): model identity and supported API effort levels.
- [Model-family guidance](https://developers.openai.com/api/docs/guides/latest-model): general model roles. Live tool availability governs this host.

## Apply the policy

1. Inspect available agent tools and their current model/effort choices. Honor explicit user overrides and applicable instructions. Verify both the model identifier and supported effort value before spawning; docs do not prove account access.
2. For each substantial work item, choose the role from the coordinator table and state the assignment. Keep routine scans in the current worker or an extraction worker; do not spawn an expert just to run a deterministic inventory script.
3. When the current `collaboration.spawn_agent` tool supports overrides, pass `model` and `reasoning_effort` explicitly with `fork_turns = none`. Full-history forks in this environment inherit model/effort and cannot take overrides. Other hosts may use a different schema; inspect it.
4. Give a fresh worker the absolute specialist SKILL.md path, required input/evidence paths, source fingerprints, platform/backend/editor constraints, precise objective, allowed output ownership, prerequisites, and acceptance criteria. A fresh worker does not inherit conversation context. Include relevant user requirements explicitly.
5. Record requested model/effort and the returned agent identifier. Record actual settings only when the host exposes them; otherwise mark confirmation unavailable. If a spawn is rejected, do not label the worker as running that model.
6. The running main agent cannot switch itself by editing a skill. Keep coordinating in the selected session, or give a bounded difficult decision to an available Astra worker. Do not change global model defaults as a side effect of this workflow.

For example, a code-recovery assignment in the current tool schema uses these control fields (the message must contain the concrete handoff):

```json
{
  "task_name": "recover_game_code",
  "fork_turns": "none",
  "model": "gpt-6-astra",
  "reasoning_effort": "high"
}
```

This is a partial tool-argument example, not a runnable script or auto-loaded configuration. Merely copying it into an artifact does not start a worker.

## Coordination and handoffs

Extraction and code analysis can proceed in parallel after source discovery, with separate output directories. Scene assembly depends on stable object/type maps; parallelize only independently owned preparation until those maps exist. Start verification against an identified frozen revision/snapshot, not files changing beneath the checker.

Give each worker exclusive write ownership for its outputs. One integrator owns each Unity project at a time: package manifests, metadata, scenes, project settings and Library state must not be edited concurrently. Workers can propose repair scripts or patches in their own directories. Do not run multiple editors against one project. Respect available agent slots and avoid nested agent fan-out; experts return work to the coordinator rather than spawning recursively.

Version migration uses Astra High by default for schema/package/API decisions. The scene integrator may implement bounded migration proposals at its assigned setting; migration does not authorize a second editor against its project. Include source, baseline, requested target, migration mode and tested editor in the handoff. Experts submit skill-improvement proposals; only the designated maintainer edits installed shared skills.

Each handoff returns source fingerprints, produced paths, changed files, mappings/coverage, commands and checks, evidence-backed conclusions, unresolved issues and next dependencies. The verifier examines original evidence independently and separates failures from unverified claims; it should not be given an expected verdict.

## Escalation and unavailable settings

- Escalate a Sol worker's bounded investigation to Astra High when conflicting evidence, unknown serialization, native logic, shader behavior, or a reproduced unexplained mismatch requires deeper analysis. Pass the evidence and attempted approaches; do not just repeat the same prompt.
- If Astra High is already being used, consider `xhigh` only for a concrete difficult analysis and only if supported and consistent with user constraints. A higher setting is not a substitute for new evidence. Do not escalate indefinitely.
- If a default model is unavailable, disclose the deviation and use an available capable model/current session for independent work. Mark the original requested setting as unapplied. If the user explicitly requires a particular model, do not silently replace it; continue unaffected work and identify the required access or selection.
- `Opus5.5-normal` is a user example, not a verified identifier in this host. No Opus model is exposed by this session's collaboration tool. Do not assert that it does not exist elsewhere, invent a provider connection, or translate another provider's `normal` into OpenAI `medium`. Use an external model only when an available host/provider exposes its exact identifier and effort controls and the user authorizes that route.
- If no delegation is available or the user requests one agent, load the required expert instructions and execute sequentially. Report the actual execution arrangement; multiple skill files alone do not imply multiple agents.

## Model-policy checks

Before claiming model routing works, verify that the requested fields were accepted by the live host. Skill validation checks metadata, not model selection. A documentation-only update can validate references, skill structure and policy consistency without spawning paid workers; report it as such. Do not start game reconstruction merely to demonstrate the newly installed routing policy.
