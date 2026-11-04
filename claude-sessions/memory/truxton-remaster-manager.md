---
name: truxton-remaster-manager
description: "User's 4-skill Truxton remaster loop (pioneer/extractor/checker + manager); where the manager skill and its ledger live"
metadata:
  node_type: memory
  type: project
  originSessionId: 6cc36164-60e4-4169-9e1e-383d208e3d8c
  modified: 2026-10-27T19:44:06.634Z
---

On 2026-10-26 I built `truxton-remaster-manager` at the user's request. Staged source is
`D:\games\Truxton Extreme\extractor\manager\skills\truxton-remaster-manager`; it's installed to both
`~/.codex/skills` and `~/.claude/skills` through its own `scripts/skills.py install`. State lives in
`extractor/manager/` (roles.json, ledger.json, skill-installs.jsonl, handoffs/).

The user's roles: **pioneer** = original-game autoplayer (`extractor/original-autoplayer`), **extractor** =
Codex skill `truxton-asset-extraction` + specialists (`truxton-md01-manoeuvres`, `truxton-sa01-*`),
**checker** = Unity remaster autoplayer (`Round1Autopilot` + `Round1*Check.RunBatch`). The user called all
three "skills", but at first only the extractor had a SKILL.md. Later on 2026-10-26 I created
`truxton-original-pioneer` (recorder.js + `--record`/`--no-fire` in autoplayer.py, build_tracks.py) and
`truxton-unity-checker` (Round1TrackCapture hooks + Round1TrackCaptureRun batch in the staging project,
extractor/unity-checker/build_capture.py). First live recordings ran the same night (recordings/ash-r1-nofire,
ash-r1-fire): the director clock is the schedule clock, the original rewinds to checkpoints on death, EnemyData
comes from mover._baseEnemyData, and the enemy layer has a live parallax of about −0.2032 × player X that the
remaster lacked. On 2026-10-27 the native rule was recovered (extractor/enemy-layer-parallax/README.md: -0.5*clamp(px/123)*
BG slide range 50) and added to staging Round1EnemyWaves.LayerOffset (staging only, NOT yet installed into the user's
TruxtonRemaster). Md01 1/2/3/6 and Sa01 then matched to ~0.3-1.9 RMS; the remaining issues are Md01 fire pairs, the final legs
of programs 4/5, Sa01 Z +1.3 and its exit edge, and the missing death freeze/rewind. Settled facts live in the pioneer skill;
open: bank child for roll.
Also 2026-10-27: the remaster's default play mode is Arcade1 (gameModeMask 32, bullet selector pmode 0), but pioneer
recordings are Story (mode 1: easy selectors, StoryA mask 2). That caused the Md01 3-pair bursts and the extra Sa01 cues at 5–10 s.
On the user's request, Story is now the staging default (scene, schedule json, extract_round1_waves.py, code).
Three checks pin Arcade for their 5 s fixtures. Not yet installed into the user's TruxtonRemaster.
Later on 2026-10-27, also in staging: NativeFirstTick (+1/60 s of age for every actor), the Sa01 native exit
(gameScreenArea ±0.15 plus 2 frames), and a double-accumulated Round1Playback clock (the float clock drifted 58 ms by 420 s).
Sa01 now has RMS 0.14–0.54 until the death; Md01 index 5's final legs got worse (2.42).
The fire run hitched (machine load); a steady --no-bomb run (ash-r1-nobomb) shows Md01 stops within one frame. That run
dies by ~70 s, so programs 4–6 (77–90 s) still need a run that bombs only outside the window. The checker capture now keeps
the replayed ship invulnerable.

Codex continued the loop the same afternoon: Md01 lifecycle fix and a full Story Stage01 autopilot clear in staging; it
installed Round1EnemyWaves.cs + Round1TrackCapture.cs into the user's open project (scene still Arcade there).
Late 2026-10-27 the user asked for "stage01, a clone of the original Story stage 1" (= Ash Ep1, BG03, StoryA). Staging now
has Stage01.unity (Stage01Builder) plus native Story fire rules in Round1EnemyAttacks (BulletArea_Story y<0.90, fire
distance 200 virtual px for isRangeFire enemies); notes in extractor/story-stage01/README.md. On the user's request it was installed into their open project
(built from THEIR Round1, which stays Arcade; backup Backups/before-stage01-install-20261027-150032). Then the native
Ene_Bos03 (spec extractor/story-stage01/bos03/SPEC.md) replaced the invented Round1Boss in staging, then was installed into the user's project too (backup
Backups/before-boss-install-20261027-154230). Boss and Sd02 summon later matched against --immortal world-frame recordings (boss summon passes; drones median RMS 1.49) and installed too.

**Why:** the user wants the three roles to iterate stage by stage until the Unity project matches the
original, with the manager updating or creating skills along the way.
**How to apply:** for Truxton remaster work, start from the manager's roster/ledger; change skills only
through the staged copy + install script. Related: [[unity-game-to-project-skill]].
