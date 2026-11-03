# Skill templates

Every managed skill is a folder `extractor/manager/skills/<name>/` with `SKILL.md`, `agents/openai.yaml`, and optional `references/` and `scripts/`. Keep SKILL.md under ~200 lines; move long tables and evidence lists into `references/`.

## agents/openai.yaml

```yaml
interface:
  display_name: "Truxton <Thing>"
  short_description: "<under 60 chars>"
  default_prompt: "Use $<name> to <typical request>."
```

## Role skill (pioneer / checker)

```markdown
---
name: truxton-<role-name>
description: "<What it does for the remaster loop, which tools it drives, the output it produces.> Use whenever <phrases the user or manager would use>, even if <indirect phrasing>."
---

# <Title>

<One paragraph: the role's job and what it must never do (pioneer never edits the remaster; checker never fixes).>

## Tools and safe operation
<launch/stop, single-instance rules, permissions, build fingerprint check>

## Producing the handoff
<exact command(s); output path pattern; the truxton-track/1 fields it fills; how instance keys are made>

## Acceptance before handing back
<checklist that mirrors the manager's acceptance>

## Known limits
<what it cannot observe/replay, and how to report that as unknowns>
```

## Enemy / system specialist

Follow `truxton-md01-manoeuvres`:

```markdown
---
name: truxton-<family>-<topic>
description: "Recover, repair, and validate <family, in visual terms the user would use> <behavior> in the Unity 2023 Truxton remaster. Use for <variants, symptoms the user might describe>."
---

# <Title>

<Visual identification + EnemyData identity + source texture so a screenshot can be matched.>

## Recovered behavior
<native program, constants, timings; point to evidence files rather than inlining long tables>

## Adaptations
<what differs from the original and why>

## Evidence and working files
<paths, native RVAs with build fingerprint, remaster scripts>

## Verification
<the harness, the manager handoff folder for this subject, and the last comparison verdict>
```

## Writing guidance

- Lead with how to recognize the subject and what the original actually does; explain why rules matter (e.g. "losing indexValue made every Md01 fly straight").
- State addresses together with the build fingerprint they belong to.
- Replace wrong statements; don't stack corrections.
- Don't store run state (today's verdict, attempts) in a skill — that's the ledger. The one exception is a short "last verified" line pointing to the comparison file.
