# Implementing a Truxton boss from its SPEC.md

Goal: `Reconstructed/Assets/Scripts/Runtime/Stage/Bosses/BosNNBoss.cs`, a subclass of `StageBoss`
(`Assets/Scripts/Runtime/Stage/StageBoss.cs`) that plays your boss's native state machine as written in
`evidence/bosses/BosNN/SPEC.md`. The stage builder (`Editor/ReconstructionStagePlay.cs`) picks the class by name:
`Pf_Ene_Bos07` -> `Bos07Boss`, `Pf_Ene_Bos08A`/`B` -> `Bos08Boss` (one class, `FormIndex` 0/1).

Rules
- Write only your own file `Assets/Scripts/Runtime/Stage/Bosses/BosNNBoss.cs` (and notes in `evidence/bosses/BosNN/`).
  Do not edit StageBoss.cs or any other project file; if the base lacks something, say so in your report and keep a
  local workaround in your class.
- Do NOT start Unity (one Unity process at a time owns the project; the coordinator compiles and plays every boss).
  Write C# that compiles against Unity 2023.2 / C# 9 and the API below; check names against the source files.
- Comment the native address (RVA) next to each state/constant, like `Assets/Scripts/Runtime/Gameplay/Round1Boss.cs`. Keep [I]/[?]
  markers from the spec where you had to choose.
- Match the surrounding style: compact, no new dependencies, no reflection, no allocations per frame beyond the base.

Units and frame
- `position` (Vector3, source sky-plane units): x right, z up the screen, y toward the camera (ignored for placement;
  use it only for depth tricks). The visible field is 200 high and ~355 wide (16:9). The base places the hull from
  `position` and the root rotation `facing` (Quaternion, the boss's own EnemyData rotate at spawn) every frame.
- Native code moves the boss root in this same frame, so copy the spec's numbers directly. Time is seconds
  (`Time.deltaTime` is already scaled by the playback speed).
- Child transforms (wings, turrets, legs, arms, covers): get them with `Find("path/or/name")` and set
  `localRotation`/`localPosition`/`localScale` directly - exactly as the native code does. Live hit circles follow them.
- The prefab Animator (entrance clip `anc_bsNN_start`, idle loops) keeps playing; if you need to drive it, use
  `visual.GetComponentInChildren<Animator>()` (standard Unity API; the original controllers/clips are imported).

What the base gives you (protected unless noted)
- State: `State` (EncounterState), `StateAge` (s in the current encounter state), `BossTime` (Ene_BosBase boss clock,
  from the end of the entrance), `HpState` (0..8 from hpRateRanges .9/.75/.51/.4/.3/.2/.1/0), `HealthRatio`,
  `Target` (body Round1Combat.Target: `health`, `maxHealth`, `invulnerable`, `lockOn`), `FormIndex`, `Current` (Form:
  `model`, `rest`, `spawnTime`, `health`).
- Hooks to override:
  - `OnSpawned()` - right after the hull and parts exist (still invulnerable). Set up your fields here.
  - `bool Entrance(float dt)` - return true when the boss becomes damageable (the base then calls
    `SetVulnerable(true)`, zeroes `BossTime`, enters Fighting and calls `OnFightStart()`). Default: animated prefabs
    hold `Current.rest` for max(entryDuration,5) s; others ease in from 120 above. Implement the spec's
    collision-off / no-lock windows with `Target.invulnerable` / `Target.lockOn` inside it.
  - `Fight(float dt)` - your state machine; called every frame while Fighting (after `BossTime+=dt`). Keep your own
    `enum` state and timers.
  - `PartBroken(Part part)` - a breakable part reached 0 HP (or `BreakPart` was called). Base: small explosion at the
    part root, hides the part root, sound. Call `base.PartBroken(part)` unless the spec does something else.
  - `DestructionEuler` (default (20,45,0)) and `DeadEffectTime` (default 3.5) - the shared destruction: 5.5 s sink of
    150 (eased t^2) while turning to that euler, 4 middle explosions at start, small bombs from 0.2 s shrinking x0.9,
    the boss dead effect at DeadEffectTime. Override `Defeat(float dt)` only for a different sequence (call base).
  - `MinionModels` - model names you `Summon` (e.g. `"Pf_Ene_Sg01"`, `"Pf_EneObj_Bos05_Arm"`); the builder resolves
    their prefabs.
- Parts: `Parts` / `GetPart("arm40")` -> `Part { name, body, broken, enabled, root, target, row, HealthRatio }`. Parts
  come from the prefab PartsList collision models (enemy-hitshapes.json `parts`). A part with a database row and HP is
  its own target (row HP, lock-on, laser block); the rest belong to the body. `part.enabled=false` removes its circles
  (asleep / no collision); `SetPartVulnerable(part,bool)` gates damage+lock-on; `BreakPart(part)` forces a break.
  `SetVulnerable(bool)` gates the body and all live parts.
- Fire: `Fire("bos07leg", "muzzle_leg40_0", angleOffsetDegrees, towardTransform)` or with a Transform muzzle. The
  pattern name is the BulletTemplate name (Resources/StageCombat/enemy-attacks.json `patterns`; lasers too - a
  pattern with nIrradiation>0 and a "laser" bullet fires a beam with its own charge/duration). Bullets aim/rapid/way
  exactly as the template says; `toward` overrides the aim base. `CancelLasers()` dissolves this boss's beams
  (`_laserCancelFlag`). `muzzles` lists every transform named `muzzle*`.
- Positions: `PlayerSource` (player ship in source units), `ToViewport(source)`.
- Effects/sound: `Boom("pf_eff_explposion01", transformOrWorld, scale)`; `Round1Sound.Event(name)` /
  `Round1Sound.Play(clipName)` (see Assets/Scripts/Runtime/Gameplay/Round1Sound.cs and Resources sound tables; unknown names are
  silently ignored, so prefer names that exist).
- Summons: `Minion m = Summon(model, sourcePos, velocity, step)`; `step(m, dt)` moves `m.position` / `m.facing`
  each frame (default: straight at `velocity`); the base places it, gives it hit circles and database HP, and despawns
  it off-screen. `m.Alive`, `ClearMinions()`.

Things to keep straight
- `Fight` runs only while Fighting; HP 0 calls `OnDefeated` (base) which clears bullets/lasers/minions and runs the
  destruction. Do not destroy the hull yourself.
- No time limit kills the boss in the reconstruction unless the spec's time-out handler does something.
- Randomness: use `UnityEngine.Random` (the native code uses Unity's Random too).
- When the spec says "turn toward the player", compute from `PlayerSource - position` in the x/z plane.
- When done, list in your report: states implemented, what you approximated and why, and every [I]/[?] choice.
