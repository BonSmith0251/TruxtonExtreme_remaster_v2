---
name: truxton-multipart-enemies
description: "Study and rebuild TATSUJIN EXTREME (Truxton Extreme) enemies made of several parts in the Unity 2023 remaster: enemies whose parts break in a staged death (the Lb01 snake: head bursts, segments blow up one by one to the tail), chain enemies whose head summons body segments that follow it and break off (the Mj01 centipede: head plus 9 bodies), damage smoke that appears below half health, the boss's part breaks, per-part hit flash and destruction explosions, keeping a long enemy until its whole body has left the screen, and boss part breaks. Use whenever the user mentions multi-part, segmented, snake, centipede, chain or linked enemies, says an enemy's body/segments/parts are missing, all vanish at once, don't break separately or don't explode one by one, wants an enemy to fall apart like the original, says a long enemy disappears while part of it is still on screen, says the boss (or one of its parts) does not flash or blink when hit, or asks to study an enemy's destruction or summoned children — even if they only name Lb01, Mj01, Mj01b or paste a screenshot of a long enemy."
---

# Multi-part enemies

The original builds "multi-part" enemies in three different ways. Identify which one before changing anything; the remaster handles each in a different place. Workspace `D:/games/Truxton Extreme` (game read-only), staging `extractor/UnityProject`, the user's project `C:/Users/Administrator/Documents/TruxtonRemaster`.

| Kind | Original | Round 1 example | Remaster |
|---|---|---|---|
| Staged death | one PawnEnemy, one HP pool, many colliders; `_explosionOrder` + `_delayDeadTime` | `Pf_Ene_Lb01` (snake) | `Round1Effects` Orders / DamageObjects |
| Chain | a head (`Ene_*h`) that summons separate body enemies (`_summonNameStr`, `_summonEnemyCount`) | `Pf_Ene_Mj01h` + 9 `Pf_Ene_Mj01b` | `Round1EnemyWaves` SpawnChain / UpdateChains |
| Boss parts | `PartsList` with named parts (`armL`, `cover`, …) each with HP and `BreakEffect` | `Ene_Bos03` | `Round1Boss` (OnPartBroken, Destruction, Boom) |

## 1. Study the enemy

Run the bundled script on the prefab(s), then read the native code for anything the data doesn't say:

```bash
C:/Python311/python.exe extractor/manager/skills/truxton-multipart-enemies/scripts/study_multipart.py Pf_Ene_Lb01 Pf_Ene_Mj01h Pf_Ene_Mj01b
```

It prints each PawnEnemy component's script class, HP, lock-on/laser-block, `_deadExplosion`, `_delayDeadTime/_delayDeadVector`, `PartsList` (renderers, collisions, `_damageObject` path), the `_explosionOrder` resolved to paths, and summon fields. Gotchas it already handles:
- `_explosionOrder._target` ids are **components** (MeshRenderers), not GameObjects or Transforms; resolve against every component id in the prefab.
- `_ekind` is the native enum `Explosion`: None 0, E4Little 1, E1Small 2, E2Middle 3, E3Large 4, E5Huge 5, Meteo01..03 6..8. The E-number names the prefab: kind 3 is `pf_eff_explposion02`, kind 5 `pf_eff_explposion05`.
- Prefab `_HitPoint` is not the gameplay HP. Read `extractor/health-source/enemy-database-decoded.json` (key = family, e.g. `Mj01b` 2000 HP / 5000 points, `Mj01h` 10000 / 20000).

For behaviour (follow, break, gravity), list the class members and disassemble with `extractor/analyze_player_native.py` (metadata v39 + capstone; see truxton-asset-extraction's original-motion reference). Statics live in the class `.cctor` (Mj01h: `gravityVector` (0,0,-16), `_unitDistance` 22.5). Confirm timings on a pioneer recording before trusting a reading: `extractor/original-autoplayer/build_tracks.py summary <recording>` then `build ... --family Mj01b`.

Check the live recording for which enemies really report more than one part: `recordings/ash-r1-colliders-20261029-shots/samples.jsonl` (`enemies[].parts`). In Round 1 only the boss does; Lb01 and Mj01 are multi-part by construction, not by `PartsList`.

## 2. Staged death (Lb01-style)

Original (`PawnEnemy._callDeadEffect` with `_explosionOrder`): at death the enemy stops being hittable, shakes by `_delayDeadVector` for `_delayDeadTime`, and each order step at its `_WaitTime` hides its MeshRenderer and plays its Explosion kind at `_effectTransform` (else the renderer). Lb01: head + map/burners/gears at 0 s (E5Huge), `ene_lb01_body021..027_rot` every 0.15 s (E2Middle), tail `body03_rot` at 1.2 s (E3Large), gone at 1.35 s. `_damageObject` (Lb01 `body01/damage`, five `pf_eff_damage01`) shows once HP < `_damageBlinkRate` 0.5 (`EnePartsGroup.SetDamageEffect`).

Remaster: add the model to `Round1Effects.Orders` (steps with time, kind, target path, effect path) and, if it has one, `DamageObjects`. `Blast` → `StartDying` plays the sequence on a **copy** of the visual posed as it died (the target itself is removed normally), and each explosion calls `Round1Sound.Dead(null, effect)`. The remaster disables every enemy particle system at spawn, so damage smoke must re-enable the node's systems and `Play()` them.

## 3. Chain enemies (Mj01-style)

Original: the head spawns all bodies at its spawn point and releases body *i* after it has moved `(i+1)*_unitDistance` (`CallMJ01Body`), so each body runs the head's route that far behind. A destroyed body: `ReceiveKill` sets `_breakChildren` (no more releases) and `SetParentKilled` on every body behind it; the head's death does it for all. A detached body (Ene_Mj01b state 2) drifts by `gravityVector` per second until it leaves the screen. Recording ash-r1-fire released the first bodies 0.248/0.509 s after the head (speed 88).

Remaster (`Round1EnemyWaves`): `Spawn` → `SpawnChain` for the head model; `UpdateChains` (end of `UpdateActors`) samples the head's own route at `headAge - lag` (`PathAt`, so bodies continue after the head leaves), handles kills/detach/stranded bodies and despawns. Parts share `Target.chain`; `Round1Combat.SeparateAir` and `Round1OverlapCheck` skip same-chain pairs (neighbouring bodies overlap by design: 22.5 spacing, 17.7 hit radius). Bodies are not lock-on targets, block lasers, and get blasts/blink/flash through `Round1Effects` (add the body model to `DeadExplosions` and `Blinking`).

New body models: export + import the prefab (truxton-asset-extraction import routine with snapshot/restore), add it to `Round1MeteorEffectCheck.Effects` (the effect library loads prefabs by name; the waves' serialized `visuals` list is not used for bodies), add it to `extract_enemy_colliders.py`'s default list and regenerate `round1-enemy-hitshapes.json`, and use the database HP (`Round1Balance.EnemyHealth` throws for models it doesn't know).

## 4. Boss parts and destruction (Bos03)

`study_multipart.py Pf_Ene_Bos03`: `_deadExplosion` `pf_eff_explposion_boss` (offset y 20, death SE 41); parts armL/armR/cover `BreakEffect` `pf_eff_explposion03`; shoulder40/60 break with it at their `_explosionRoot`; body `_damageObject` `bs03_body/damage` (12 `pf_eff_damage01`). The destruction (`Ene_Bos03.PatternMoveDestruction`) calls `Ene_BosBase.SkyExplosionEffect(tcode, worldPos, mylayer, seID)`: `tcode` comes from the static class `ShortCutEffect` (ExplosionCodeLittle/Small/Middle/Large/Huge at +0/+4/+8/+12/+16) — 4 × Middle (`explposion02`, no sound) when it starts, then Small (`explposion01`, SE 40 `exp_st3_boss_a01`) at an accelerating rate; `BreakParts` on the shoulders; `ToDestroid` → the boss explosion as the model goes.

Resolving such static-class pointers: the code loads `[rip+X]`; the slot's raw value in GameAssembly.dll is an encoded token `(usage<<29)|(index<<1)|1` (usage 1 = type); match `index` against the type definitions' byval/byref type indices (LayerUtility resolves this way, a good sanity check). Read method parameter names from metadata section 10 (stride 12) — `tcode`/`hcode` told the effect was a hash code, not a kind.

Remaster: `Round1Boss.Boom(effect, transform|world)` plays through `combat.effects` at the boss's source scale; `OnPartBroken`, `Destruction` (open / `SmallBomb` / shoulders / final), `StepDamageSmoke` (the `damage` node is **inactive in the prefab**: activate the node itself, not only its particle systems). The old stand-in (the player bomb prefab scaled up) is gone.

Hits flash and wounds blink per part, as `EnePartsGroup.SetHit` / `SetDamageBlinkRate` do on each `PartsList` group: `Round1Effects.BossPartNodes` maps the remaster's boss targets to the renderer groups (part 0 body = `bs03_body` + both shoulders + both batteries, 1 armL = `bs03_arm60`, 2 armR = `bs03_arm40`, 3 cover = `bs03_cover`; the original's face and shoulder parts are not separate targets). `Round1Combat.RegisterBoss` hands `effects.bossVisual` the model. Read a new boss's groups from its `PartsList[*]._renderers` before adding it there. Verify with `Round1BossFlashCheck.RunBatch` (a body hit lights only the body group, an arm hit only the arm, the body blinks below half health).

Verify the destruction with `Round1BossEffectCheck.RunBatch` (effect counts per stage of the destruction, smoke only below half, model hidden at the final blast, renders) and `Round1BossCheck`.

## 5. Leaving the screen: the whole body, not the root

A multi-part enemy must stay until **all of it** is off screen. The generic wave exit tests only the root (`target.position` against the viewport ±0.15/±0.25, or "never entered and older than 12 s"), so a long enemy whose root is off screen while its body still shows would vanish mid-screen. The original keeps it: every recorded Lb01 exit (recordings/ash-r1-stage01-nofire-20261027, 8 of 8) ends with the head 165-320 source units beyond the edge, about the snake's length.

Remaster: put the model in `Round1EnemyWaves.WholeBodyExit`. `UpdateActor` then uses `BodyOnScreen(visual)` (any enabled mesh's bounds projected inside the viewport) both for leaving and for having entered, since the root may never come on screen at all (several Lb01 only show their body). Chain enemies already leave part by part: each Mj01 body has its own off-screen test, and bodies keep following the route after the head has gone. Verify with `Round1WholeBodyExitCheck.RunBatch` (no fire, to 420 s): no Lb01 may be removed while a mesh was more than 2% inside the screen the frame before. Without `WholeBodyExit` all 8 Lb01 exits fail it.

When adding another long enemy, add it to `WholeBodyExit` and to the check.

## 6. Verify

- `Round1EnemyEffectCheck.RunBatch`: staged deaths = kills of the model, all steps run, damage smoke while wounded; renders `round1-lb01-death.png` mid-sequence.
- `Round1ChainCheck.RunBatch`: 9 bodies per head, release timing per body (±2.5 frames), bodies on the head's earlier path, bodies destroyed and cut loose; renders `round1-mj01-chain.png`.
- `Round1WholeBodyExitCheck.RunBatch`: long enemies leave only when their whole body is off screen.
- `Round1BossEffectCheck.RunBatch`: boss part breaks, destruction blasts, damage smoke and the final explosion.
- `Round1BossFlashCheck.RunBatch`: per-part hit flash and damage blink.
- Then `Round1OverlapCheck`, `Round1ShipContactCheck`, `Round1HitShapeCheck`, `Round1SoundCheck`, `Round1AutopilotCheck`, `Round1FeatureCheck`, `Round1AttackCheck`.
- Look at renders, and judge what a still frame really shows: a stepped batch run doesn't advance particles unless the check simulates them, which can hide a system that never plays in real time. Assert `isPlaying` before simulating.

Install only when the user asks: back up, copy staging files, mirror them into `extractor/user-clone` (check the clone also has other sessions' installs, e.g. `Round1Sound`, or it won't compile), and rerun the checks there.

## Still open (Round 1)

- Lb01's live `_explosionOrder` timing has not been compared against a recording (all evidence is the prefab and native code).
- Lb01's route is not original: its EnemyData has no routes (natively `Ene_Lb01.CreateRouteData` supplies `_routeNames`, like Md01), so the remaster flies it straight from its edge with a generic body (no `EnemyMoverSnake` bending). Recover the route table and snake bones before judging its path.
- Mj01b's `physics_mjb` (PhysicsEnemy box) is not reconstructed; bodies do not push meteors.
- Other stages' multi-part enemies (later bosses, `Ene_St01`, …) are unstudied: run the script on them first.
