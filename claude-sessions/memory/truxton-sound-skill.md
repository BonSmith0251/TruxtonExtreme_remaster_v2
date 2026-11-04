---
name: truxton-sound-skill
description: "truxton-sound skill (2026-10-29): extracts all 560 original clips + recovered trigger rules, Round1Sound player in the remaster; where things live"
metadata:
  node_type: memory
  type: project
  originSessionId: b47f7657-efc3-4d82-b94b-d323ce4f0e07
  modified: 2026-10-29T17:38:29.808Z
---

On 2026-10-29 the user asked for a "sound skill" that extracts all original sounds (BGM, hits, shots, explosions, other SFX)
and installs them into the remaster. I built `truxton-sound` (staged in extractor/manager/skills, registered as an
extractor specialist in roles.json, installed via the manager's skills.py). Data: extractor/sound-source/ (ids, SoundDatabase,
wiring, native calls, BG03 BGM sections, truxton-sound.json rules, installs.jsonl); audio: extractor/sound-output/ (560 Ogg, 422 MB).
Remaster side: Assets/Truxton/Round1Sound.cs + hooks in Effects/Weapon/WeaponMotion/EnemyAttacks/Boss, clips in
Assets/Resources/TruxtonAudio, Editor/Round1SoundCheck.RunBatch.

Non-obvious: the original has no AudioSources — everything is an int id through TXEKernel.Sound.SoundUtility; the
SoundDatabase keys are XOR 0x3c; death sound = EffectPalette pick for the explosion + _overplayDeadSound.
Gotcha: heredocs through the Bash tool turned "\\r\\n" in Python source into real CR/LF — edit such code with Write/Edit.
Repo line endings are mixed (Round1Weapon.cs is CRLF, most others LF); the installer keeps each file's style.

Verified in staging (Round1SoundCheck passed: 560 clips, BG03 music sections, 240 s autopilot run with 38 distinct sounds),
then installed into the user's TruxtonRemaster the same day (backup extractor/Backups/before-sound-install-TruxtonRemaster-20261029-133820).

**Why:** the remaster was silent; the user wants it to sound like the original.
**How to apply:** for any audio request, start from the skill's SKILL.md and references/original-sound.md. Related:
[[truxton-remaster-manager]], [[truxton-scene-dedup]].
