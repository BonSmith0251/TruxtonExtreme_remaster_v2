# Specifying a Truxton boss from its native code

Goal: a SPEC.md precise enough that another engineer can re-implement the boss in the Unity reconstruction without
reading assembly, with every value traceable to an address. Do not invent behaviour; mark inference as [I] and unknowns
as [?]. Read-only: never modify `D:\games\Truxton Extreme`, the Unity project, or other bosses' folders.

## Sources
- Native code: `D:\games\Truxton Extreme\GameAssembly.dll` (IL2CPP x64). Method list with RVAs:
  `D:\games\TruxtonExRecon\code\methods.jsonl` (one JSON per method: assembly, type, signature, attributes with
  Cpp2ILInjected.AddressAttribute RVA/Offset/Length). Types and fields: `code\types.jsonl`.
  `code\analyze_native.py` shows how to map RVAs to file offsets and disassemble with capstone (installed for
  C:\Python311) while annotating `call` targets with method names. Write your own scripts in your output folder.
- IL2CPP conventions: `this` in rcx, args rdx/r8/r9; instance field access is `[rcx+offset]` - field offsets follow
  declaration order and type sizes (Il2CppObject header 0x10); verify offsets against how fields are used, and against
  serialized prefab values. Static fields live in the class's static field data reached through the class pointer.
  String literals: `global-metadata.dat` (`D:\games\Truxton Extreme\TATSUJIN EXTREME_Data\il2cpp_data\Metadata`);
  `tools\stage_combat\enemy_attacks.py` already resolves literal usage (see its provenance file
  `evidence\stage-combat\enemy-attacks-provenance.json`, which lists each boss's bullet templates and the native
  literals that select them). Float/double constants are RIP-relative loads from .rdata.
- Serialized data: the boss prefab (`Reconstructed\Assets\OriginalGame\Pf_Ene_BosNN*.prefab` or under
  `Samples\Prefabs\Reference`), its EnemyData and wave timeline (`Reconstructed\Assets\Resources\StageEnemies\BGxx.json`
  holds the boss's EnemyData definition and spawn time; raw timelines in `extraction\stage-enemies\raw-stage-timelines.json`),
  its Animator controller/clips, `Resources\StageCombat\enemy-database.json` (HP, parts rows),
  `enemy-hitshapes.json` (parts circles), `enemy-attacks.json` (templates/selectors/packs).
- Worked example of a finished spec turned into code: `Reconstructed\Assets\Scripts\Runtime\Gameplay\Round1Boss.cs` (Ene_Bos03,
  BG03). Its comments cite addresses; its structure (entry, states, attacks per HP state, part breaks, summon, defeat)
  is the shape we want. Shared base logic (Ene_BosBase: hpRateRanges .9/.75/.51/.4/.3/.2/.1/0 -> _hpState, entry
  no-hit time, etc.) is described there; confirm it applies to your boss.

## SPEC.md must contain
1. Identity: class(es), prefab, EnemyData, stage, spawn time (from the schedule), parts and their HP (database rows),
   which parts are targets, lock-on, laser block, invulnerable windows.
2. Coordinate frame and units (source sky-plane: x right, z up the screen, y toward the camera; the game camera is at
   (0,400,0) looking down with 20 deg vertical FOV).
3. State machine: every state, entry/exit conditions, timers (seconds), transitions keyed by HP state, part breaks,
   time, or animation events. Include the entry sequence and the defeat sequence (explosions, delays, what ends it).
4. Movement: positions/paths/speeds/easing per state, as numbers.
5. Attacks: per state, which bullet template or selector (by name), from which muzzle (transform path), cadence,
   aiming, counts; lasers with charge/duration; summons (what enemy, where, how many).
6. Parts: break order and consequences (attack changes, model changes, animator triggers).
7. Animator usage: states/triggers set, and what the animation drives.
8. An address table: every method you read (name, RVA) and the constants you took from it.
9. Open questions.
Keep it concise and numeric. Prefer tables.
