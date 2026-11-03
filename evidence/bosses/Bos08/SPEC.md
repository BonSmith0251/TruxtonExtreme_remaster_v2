# Ene_Bos08A / Ene_Bos08B / Ene_Bos08C: BG08 final boss (TATSUJIN EXTREME)

Source: original native code, `D:\games\Truxton Extreme\GameAssembly.dll` (IL2CPP, metadata v39). I read every method of the three classes
and their nested types, plus the base helpers they call. Disassembly with metadata annotations (string literals, TypeInfo, MethodRef, field
names, vtable slots, .rdata floats) is in `disasm/`. The tools that produced it are in `tools/`: `bdis.py`, `il2.py` (PE plus metadata-usage
decoder, Il2CppMetadataRegistration at RVA 0x3DB4460) and `fields.py`. All constants are in `bos08_constants.json`, and the bullet
templates (copied from `enemy-attacks.json`) are in `bos08_bullet_templates.json`.

Tags: [I] marks an inference; [?] marks an open question. Times are seconds. Positions are source sky-plane units (x right, z up the
screen, y toward the camera; camera at (0,400,0), 20° vertical FOV, so the visible half-height is about 70.5) unless the text says otherwise.
Shake triples are `PawnEnemy.AddShake(sec, pow, speed)`. `scale` means `InGameManager.GetEventRepeatScale()` [I: the difficulty/rank
multiplier for repeat intervals].

---------------------------------------------------------------------------------------------------------------------------------------
## 0. Overview: three forms, one fight

| Form | Class / prefab | Kind | EnemyData | Spawned by | HP (DB row) | Ends with |
|---|---|---|---|---|---|---|
| A, the spider fortress | `Ene_Bos08A` / `Pf_Ene_Bos08A` | ground (boss layer) | `ene_boss08a` | BG08Main TLEntry **Boss08A** at **470 s** → `tl_boss08a` EnemyEntryClip at +2 → **472 s**, offset (0,-500,12300), `_isGround` | body 400 000 (row 66); covers 4×100 000; arms 6×20 000; core: no row | core escapes (anim) → **B** follows on the timeline, unless the actor is Ash |
| B, the spinning top | `Ene_Bos08B` / `Pf_Ene_Bos08B` | sky | `ene_boss08b` (start pos (0,0,30)) | BG08Main TLEntry **Boss08B** at **505 s** → `tl_boss08b` clip at +2 → **507 s** | 1 000 000 (row 77); parts core and wings with no rows | sinks and explodes → spawns **C** (`CallEnemyClip`) or clears the stage |
| C, the core | `Ene_Bos08C` / `Pf_Ene_Bos08C` | sky | `ene_boss08c` (start pos (0,0,30)) | **B's destruction** (`GetBossCD()` → `["ene_boss08c"]`, `CallEnemyClip(0, B.localPos + (0,0,-30))`) | 250 000 (row 78) | stage clear |

All three EnemyData have attribute 1072, duration 300, and a single `eventType 1001 "Start"` event with vector (0,0,-250) and intValue1 1. A's
`GetRouteNames()` appends `boss/boss08a_w00` (a RouteLUT). No native code references the EnemyData `boss/bos08a_ma01` (two Ma01 on that
route) [?].

**Which forms are fought** depends on `TXEResident._playActor` (TXEResident+0x48; values Unknown -1, Ash 0, Bergamot 1, Chria 2):

| Actor | After A dies | After B dies |
|---|---|---|
| Ash (0) | `InGameManager.Phase_StageClear()` → stage ends (trophy 11 if Story A) | n/a |
| Bergamot (1) | `SetAreaBreak(true)`, core escapes, B appears at 507 s | `Phase_StageClear()` (B dead explosion `pf_eff_explposion_boss`) |
| Chria (2) / Unknown (-1) [I: Unknown is the arcade or non-story value] | as Bergamot | C spawned; stage clears when C dies |

Sources: A `PatternMoveDestruction` 0x1DAA310 mode 30 and `_destroyedResult` 0x1DACC80; B `ShouldCreateBossC` 0x1DB1420 (returns true
for actor 2 or -1) and `PatternDestruction` 0x1DAF150; B `Initialize` 0x1DAE0C0 / `ApplyDeadExplosionEffect` 0x1DACE00 (uses
`InGameResident._playActor` == 1).

**BG08 timeline around the boss** (`raw-stage-timelines.json`, BG08Main):

| t (s) | Clip |
|---|---|
| 420-470 | area RouteBoss |
| 470-495 | area **HallBoss**, `_AreaAttribue` 20 = Stop or NoRestart; TLEntry Boss08A (A spawns at 472) |
| 486, 489.9 | playSound 149 (`bg8_boss01_app_01`), 150 (`app_cry1`) |
| 488 | BGM stage 8, section 3 |
| 492.5 | `tl_boss08a` displayGauge event (22.5 s into the wave, easeIn 2) |
| 495-503 | HallBossEnd (NoRestart) |
| 503-507 | TrueBossST; 503: BGM section 10 |
| 505 | TLEntry Boss08B (B spawns at 507; displayGauge at wave t=0) |
| 507-540 | BossLoopST (NoRestart) |
| 540-600 | **BossLoop**, attr 12 = Loop or NoRestart [I: the timeline loops here while B/C live] |
| 600 | BossED (Terminate) |

A's entry waits for `InGameAreaManager._isAreaDelayStop` (the HallBoss Stop). Its death calls `InGameManager.SetAreaBreak(true)`, which
lets the timeline run on to the Boss08B entry [I: the stop holds the timeline inside HallBoss until then].

Coordinate notes: A is a ground object placed in the scrolling ground layer, and its own code never moves its root; only `_modelTop` yaws
during the Turn. B and C write `transform.localPosition` in the sky-enemy root frame (B home (0,0,30), C home (0,0,50)). Explosions use
`LayerUtility.EnemyGroundLayer` for A and `EnemySkyLayer` for B and C.

---------------------------------------------------------------------------------------------------------------------------------------
## 1. Ene_Bos08A (ground fortress with 4 covers and 6 legs/arms)

### 1.1 Parts (prefab PartsList; DB rows 66-76; hit circles in `enemy-hitshapes.json`, model-local x/z)

| idx | part | flags | HP | BreakEffect | notes |
|---|---|---|---|---|---|
| 0 | cover01 | MasterBody, SleepStart (17) | 100 000 | pf_eff_explposion05 | front-left, circle (-50.7,-22.1) r 74.3 |
| 1 | cover03 | 17 | 100 000 | explposion05 | front-right (50.7,-22.1) |
| 2 | cover07 | 17 | 100 000 | explposion05 | back side (its circle is at the same local spot; the model turns) |
| 3 | cover09 | 17 | 100 000 | explposion05 | back side |
| 4-9 | arm01, arm03, arm04, arm06, arm07, arm09 | Independent, BrokenStill, SleepStart (22) | 20 000 each | none | tip circles r 19 at (±156.7, ±156.7) and (221.6, 0); arm04 has no circle |
| 10 | core | Independent, SleepStart (18) | prefab value | explposion03 | `me_bs08_top`, circle r 40. **No native code wakes it** → never hittable [I] |

The number in the arm names follows a numpad layout seen from above: 7 8 9 back, 4 6 middle, 1 3 front, with front toward the player
(-z). Body HP 400 000 = 4 × cover HP. Covers are MasterBody, so damage to a cover also drains the body [I: base PawnEnemy rule]. A
therefore dies when the fourth cover breaks. Lock-on is on and the laser is blocked for all parts. Prefab: `_deadExplosion
pf_eff_explposion_bos2`, `_overplayDeadSound` 41, `_explosionOffset` (0,200,-100).

Hittability:
- Covers sleep until they are woken. The front pair (01, 03) wakes at the end of EntryWait. The back pair (07, 09) wakes when the Turn ends.
- Arms are awake **only while that arm is attacking** (`EnePartsGroup.Wakeup` after the wind-up, `ToSleep` when it finishes).

`IsBroken` = `EnePartsGroup._isPartsBroken` (+0x9A); a missing part counts as broken.

### 1.2 Arms (`BossArm`, 6 instances, `_arms[i]` = new BossArm(this, ArmPartOrder[i], ArmMuzzleOrder[i], `_armAnimes[i]`))

| arm idx | part | muzzle | name constant | rotation sign |
|---|---|---|---|---|
| 0 | Arm1 | muzzle_arm_pos01 | FrontLeft | +1 |
| 1 | Arm3 | muzzle_arm_pos03 | FrontRight | -1 |
| 2 | Arm4 | muzzle_arm_pos04 | MidLeft | +1 |
| 3 | Arm6 | muzzle_arm_pos06 | MidRight | -1 |
| 4 | Arm7 | muzzle_arm_pos07 | BackLeft | +1 |
| 5 | Arm9 | muzzle_arm_pos09 | BackRight | -1 |

Muzzles are found by name under `_modelTop` (`Extensions.FindAlls`, BossMuzzleId enum names). Each `_armAnimes[i]` uses controller
`anm_bs08_arm` with states `bs08_arm_standby` (3 s, loops) and `bs08_arm_attack` (2 s).

**Arm attack routine** `ExecuteRoutineAsync(startDelay 0, duration 12, firstShotDelay 0.01, amp 40, freq 0.125, sign)` (MoveNext
0x1DB7920). Every await is followed by an abort check: if the token is cancelled or the arm is broken, the arm goes inactive.

1. If the part is missing, broken or cancelled, return. Otherwise `_isActive = true`.
2. `animator.CrossFadeInFixedTime("bs08_arm_attack", 2.0)`, then wait 2.0 (`_armAttackAnimationWait`).
3. Wait 0.01. `parts.Wakeup()` (the arm is now hittable). Template = `GetBT(0)` = `Boss08/bos08arm0`.
4. `elapsed = 0.01`. While `elapsed <= 12`:
   - angle = `sign · 40 · (1 - cos(2π·frac(elapsed·0.125))) / 2` (sweeps 0 → ±40° → 0 over 8 s)
   - **await** `mover.BulletFireAsync(token, bos08arm0, isSelfDir=false, isNested=false, muzzle, null, angle)`
   - `wait = min(0.16, 12 - elapsed)`; stop if that is ≤ 0; await `DelaySecond(wait)`; `elapsed += wait`
   - This gives about 76 shots.
5. If the arm is still alive: `parts.ToSleep()`, `CrossFadeInFixedTime("bs08_arm_standby", 2.0)`, wait 1.0.
6. `_isActive = false`.

If the muzzle transform is missing, the routine only waits 12 s. Each arm takes about 15 s in all.

### 1.3 States (`BossState`: EntryWait 0, PT2 1, Turn 2, Destruction 100; `SetState` resets `_patternMode`=0 and
`mover._laserCancelFlag`=false)

`CheckNextState` (0x1DA8200):

| From | To |
|---|---|
| EntryWait | PT2 |
| PT2, not reversed, Cover01 **and** Cover03 broken | Turn |
| PT2, other cases | PT2 |
| Turn | PT2 |

**EntryWait** (inlined in `StateExec` 0x1DAB280; same code as `PatternMoveEntryWait` 0x1DAABD0):

| mode | behaviour |
|---|---|
| 0 | wait for `EnemyMover._isFinishDelay` |
| 1 | wait for `InGameManager._areaManager._isAreaDelayStop` (the timeline is stopped in HallBoss); then timer = 1, mode 10 |
| 10 | after 1 s: `ResetBossTimer(true)`; wake Cover01 and Cover03; `CheckNextState` → PT2 |

**PT2** (`PatternMove2` 0x1DA9E70). The side is Front (FrontCoverConfig, FrontArmAttackSequence) while not reversed, Back after the Turn.

- **mode 0**
  - If the side has no unbroken cover: `CheckNextState` (→ Turn on the front side).
  - Otherwise, if any arm listed in the current sequence is unbroken: try up to `seq.Length` times.
    - `TryStartArmPattern()`: entry = `seq[clamp(_armPatternIndex)]`; start the routine of every unbroken arm in the entry.
    - If at least one arm started, go to mode 10.
    - Otherwise `AdvanceArmPatternIndex()` and stop when the index stops changing.
  - If nothing started: `stateTimer = 4` (cooldown), mode 20 (runs in the same frame).
- **mode 10**: wait until every arm is inactive. Then `stateTimer = 4`, `_coverShotTimer = 0`, mode 20.
- **mode 20** (cooldown with cover fire; the only time covers shoot)
  - `stateTimer -= dt`. At ≤ 0: `AdvanceArmPatternIndex()`, mode 0.
  - Otherwise `_coverShotTimer -= dt`. At ≤ 0: `FireCoverShotBurst()`, then
    `_coverShotTimer += max(0.1, (reversed ? 0.5 : 1.0) · scale)`.

Arm sequences index `_arms`, and `AdvanceArmPatternIndex` (0x1DA8010) moves 0 → 6 and then stays on the last entry:

| idx | Front (FA) | Back (BA) |
|---|---|---|
| 0 | [2] MidLeft | [3] MidRight |
| 1 | [3] MidRight | [2] MidLeft |
| 2 | [0] FrontLeft | [5] BackRight |
| 3 | [1] FrontRight | [4] BackLeft |
| 4 | [2,3] | [3,2] |
| 5 | [0,1] | [5,4] |
| 6, repeating | [2,3,0,1] | [3,2,5,4] |

A cycle is about 15 s of arm attack plus 4 s of cooldown with cover fire. Arms 4 and 5 never fire on the front side, and arms 0 and 1
never fire on the back side.

**Cover fire** `FireCoverShotBurst` (0x1DA85A0), template `GetBT(1)` = `Boss08/bos08cover0`:
- Front: for each unbroken cover in [Cover01, Cover03], fire from both of its muzzles (`cover_01_1/_2`, `cover_03_1/_2`):
  `BulletFireAsync(token, bt, false, false, muzzle, null, 0)`.
- Back: groups `[[07_1, 09_1], [07_2, 09_2]]`. Starting at `_backCoverShotIndex`, fire the first group that still has an available muzzle
  (a muzzle counts while its cover is unbroken), then set index = (g+1) % 2. So each volley fires one muzzle per back cover,
  alternating _1 and _2.

**Turn** (`PatternMoveTurn` 0x1DAAD40):

| mode | behaviour |
|---|---|
| 0 | AddShake(2,1,5); timer 2; mode 1 |
| 1 | after 2 s: `SetDirectionTime(4,1)`; PlayQue 155 (`turning1`); mode 10 |
| 10 | r = InOutSine01(directionRate); `_modelTop.localRotation = Euler(0, 180·r, 0)`. When r ≥ 1: AddShake(0.5,1,5), mode 11 |
| 11 | PlayQue 151 (`app_cry2`); `_isReversed = true`; wake Cover07 and Cover09; `ResetArmStatus()`; `_armPatternIndex = BackSeq.Length-1` (6); `CheckNextState` → PT2 |

After the Turn the first Advance sets looped, so the back side always uses [3,2,5,4].

### 1.4 Part breaks (`OnPartsBreak(int part)` 0x1DA9780)

**Arm (part 4-9).** If the state is not Destruction, first play the sound and shake:

| part | sound |
|---|---|
| Arm1 | 157 `legbreaks_l` |
| Arm3 | 156 `legbreaks_r` |
| Arm4 | reversed ? 156 : 157 |
| Arm6 | reversed ? 157 : 156 |
| Arm7 | 156 |
| Arm9 | 157 |

followed by AddShake(0.8, 0.8, 8).

Then, in every state, an **explosion chain**. Start at `t = parts.GetExplosionTop()` and repeat for i = 0..9:
- effect `ShortCutEffect.ExplosionCodeSmall` for i < 4, `Middle` for i < 9, `Large` for i = 9 [I: Small, Middle and Large map to
  pf_eff_explposion01, 02 and 03, as in Round1Boss];
- `StartEffectWithDelay(t.position, delay = 0.1·i)`, on EnemyGroundLayer;
- `t = t.parent` (walks from the tip up the arm bone chain).

The last effect has a callback: `LayerUtility.SetLayerForce(armTop, NoneLayer)` (the broken arm disappears from the cameras about 0.9 s
after the break) and AddShake(0.8, 0.8, 8).

**Cover (part 0-3).**
- If `parts._lastHit != bomb (100)`: one counter-shot `GetBT(2)` = `Boss08/bos08cover1` from `muzzle_cover_center` with offsetAngle -45
  for Cover01 and Cover09, +45 for Cover03 and Cover07.
- Sound: Cover01 and Cover09 → 153 `damage_cry_l`; Cover03 and Cover07 → 152 `damage_cry_r`.
- AddShake(1, 1, 9).
- The PartsList BreakEffect (`pf_eff_explposion05`) is played by the base `BreakParts`.

### 1.5 Death and Destruction

`ToDestroid` (0x1DAB490), called on HP 0 [I: by the base death path]:
1. If trophy mode, `SetTrophy(10)`. PlayQue 154 (`dead_cry`).
2. For every cover not yet broken: `BreakParts(isGround, true, true, 0)` followed by `OnPartsBreak`.
3. `StopBossTimer`; `mover.DeleteRouteToken`; state = Destruction.

`PatternMoveDestruction` (0x1DAA310):

| mode | behaviour |
|---|---|
| 0 | start = target = localPos/rot; Middle blast at `GetSmallBombPosition()` (a random cover muzzle 6-13); `OnPartsBreak(4..9)` for every unbroken arm (explosion chains, no sound); timer 1; mode 1 |
| 1 | after 1 s: timer 2.5; 4 Middle blasts; AddShake(0.5,1,2); `SetSmallBombSecond(0.2)`; `SetDirectionTime(5.5)`; mode 10 |
| 10 | each `IsCallSmallBomb`: Small blast, se 40, AddShake(0.5,1,5). After 2.5 s: AddShake(0.5,1,5); `_callDeadEffect()` (pf_eff_explposion_bos2, se 41); timer 2; mode 11 |
| 11 | small bombs: Middle, se 40. After 2 s: mode 30 |
| 30 | if Story A, `SetTrophy(11)`. PlayQue 42. Actor ≠ Ash: `SetAreaBreak(true)`; `_coreAnime.Play("anc_bs08_top_escape")` (6 s clip, `anm_bs08_top`); `_callDeadEffect`; `ToDestroidVib`; `_bodyTop.SetActive(false)`; timer 0; mode 31. Actor = Ash: `Phase_StageClear()` + `Ene_BosBase.ToDestroid()` |
| 31 | timer += dt. At 0.5: PlayQue 233 `boss8a_escape`. At 2.77: 234 `camera_out`. At 5.0: `_modelTop.SetActive(false)`. At 5.7: 235 `boss8b_hovering` + `Ene_BosBase.ToDestroid()` |

The small-bomb cadence comes from `SetSmallBombSecond`/`IsCallSmallBomb` (base). Round1Boss describes it: next = t + base + rand·0.1,
then base ×= 0.9.

---------------------------------------------------------------------------------------------------------------------------------------
## 2. Ene_Bos08B (the "top": six wings, hover, dash, bow volleys)

Parts: `core` (MasterBody, no row) and `wings` (MasterBody, six capsule colliders of r 5 along each wing, wing0a…wing2b), body HP 1 000 000.
`GetStart` sets OffCollision, puts the wings to sleep, and calls `ClearBowBullets(false)`. Dead explosion: `pf_eff_explposion06` + se 173
(`ene_x3_exp`), or `pf_eff_explposion_boss` with no override sound when `InGameResident._playActor == 1`. Serialized fields:
`_wingTransforms[6]`, `_hologramEffect` (the magic-circle ParticleSystem); muzzle pack **"wings"** = `muzzle_wing01` on each wing (6).
`GetBonusTimeKind` = 1.

### 2.1 Shared motion helpers

| Helper | Address | Behaviour |
|---|---|---|
| Spin `UpdateWingRotation(dt)` | 0x1DB2F00 | `_wingRotation = _wingRotation · Euler(0, 180·dt, 0)`; root `localRotation = _wingRotation`. The whole body spins at 180°/s about the camera axis. Called every frame by every pattern; in Entry mode 11 it uses `rate·dt` |
| `ApplyWingOpening(ratio)` | 0x1DAD0B0 | for wing i in 0..5: `t = clamp01((ratio - 0.12·i)/0.2)`; `wing[i].localRotation = WingBaseRotation[i] · Euler(OutSine01(t)·(-90), 0, 0)`. WingBaseRotation yaw = 0, -60, -120, 180, 120, 60 |
| `OpenWings(dt)` | 0x1DAE7A0 | returns true once open. On the first step: PlayQue 161 `leg_spreading_02`, wings `Wakeup` (hittable). ratio += dt (1 s). At ratio ≥ 0.3: hologram `Play` + PlayQue 190 `magic_circle` |
| `CloseWings(dt)` | 0x1DAD710; inlined in BowCircle | at ratio 1: wings `ToSleep`. ratio -= dt. At ≤ 0.7: hologram Stop + `Play(162 leg_closing)` |
| Hover `ApplyHover(dt)` | 0x1DACF00 | rate → 1 over 1 s while enabled, → 0 while disabled. While rate > 0: `localPosition = (base.x, base.y, base.z + 5·rate·sin(π·timer))`, `timer = (timer + dt·rate) mod 2` (5-unit amplitude, 0.5 Hz). When rate reaches 0 after hovering: snap to base (= HomePosition (0,0,30)), timer 0 |
| `ResetHover()` | 0x1DB0F30 | picks the hover phase whose sine matches the current z, to avoid a jump |

### 2.2 States (`Boss08State`: EntryWait 0, PT1 1, PT2 2, PTBowWave 3, PTBowCircle 4, Destruction 100)

Cycle (`CheckNextState` 0x1DAD510): **Entry → PT1 → PT2 → BowWave → PT1 → PT2 → BowCircle → PT1 …** (`_nextBowIsWave` starts true and
toggles).

**EntryWait** (`PatternEntryWait` 0x1DAFB70):

| mode | behaviour |
|---|---|
| 0 | `mover.PlayAnimator("anc_bs08_top_sky_start")` (`anm_bs08_top_sky`, 5 s clip); `stateTimer = current state length` [I: 5 s]; loop SE 158 `boss02_app`; mode 1 |
| 1 | at modeTimer ≥ 3.5 (`_EntryNoHitTime`): clear OffCollision, set OffLockon and NoDamaged. When stateTimer ≤ 0.5: `Play(159 app_stop)`. When stateTimer ≤ 0 and both flags are set: mode 10 |
| 10 | when stateTimer ≤ -0.5: root rotation = identity; start = localPos, target = Home (0,0,30); `SetDirectionTime(3)`; `mover.StopAnime(true)`; mode 11 |
| 11 | r = directionRate; `pos = lerp(start, Home, clamp01(3r))` (reaches home in 1 s); spin by r·dt. From r ≥ 0.5: `Play(160 leg_spreading_01)` once, `ApplyWingOpening((r-0.5)·2)`. At r ≥ 1: ratio 1, wings Wakeup, clear OffLockon and NoDamaged, `ResetBossTimer(true)`, magic circle on (+190); timer 0.25; mode 12 |
| 12 | after 0.25 s → PT1 |

Total entry is about 8.75 s.

**PT1 figure-eight** (`PatternPhaseOne` 0x1DB00B0):
- **mode 0**: open the wings if needed; hover disabled; wait until the hover has fully decayed. Then `SetRepeatTime(3·scale)`, loop SE 163
  `boss02_flying`, loopTime 0, count 0, mode 10.
- **mode 10**
  - Every repeat lap (every 3·scale s): `mover.BulletFireByMuzzlePack(token, GetBT(0) = bos08b_00, false, false, "wings")`. All 6 wing
    muzzles fire bos08b_00, an aimed 8-shot rapid at 0.2 s spacing.
  - `loopTime += dt`. Path: `p = InfinitySymbol(InOutSine01(loopTime/12), 60, 10)`, i.e. `a = 360t + 90` (deg),
    `p = (cos a · 60, 0, sin 2a · 10)`; x is negated while the loop count is even.
  - `localPosition = Home + p`.
  - After 12 s (count reaches Pattern1LoopCount 1): stop SE 163; → PT2.

**PT2 dash** (`PatternPhaseTwo` 0x1DB0470):

| mode | behaviour |
|---|---|
| 0 | as PT1 mode 0 (wings open, hover stopped); timer 1; mode 10 |
| 10 | after 1 s: target = `GetPlayerSkyPosition(GetNearestPlayerIndexInWorld(pos))` (current local pos if there is no manager); reset move state (stage 0, speed 0, decelStart 150); mode 11 |
| 11 | `ExecutePhaseTwoMovement` (0x1DAD890). Stage 0: speed = 150·clamp01(t/0.5), then stage 1 at 150. Each frame `pos = MoveTowards(pos, target, speed·dt)`. When distance ≤ 15 in stages 0-1: stage 2, speed = decelStart·(1 - clamp01(t/0.2)). Done when distance ≤ 0.1 or the decel ends (snap to target). Then timer 1, mode 12 |
| 12 | after 1 s: returnStart = pos; mode 13 |
| 13 | `pos = lerp(returnStart, Home, InOutSine01(t/2))`; when done → BowWave or BowCircle |

PT2 has **no bullets**. Templates pat2A and pat2B (`bos08b_10`, `bos08b_11`) are loaded but never fired by native code [?].

**Bow bullets** (`SpawnBowBullets(rootWorldPos, offset, angle)` 0x1DB14D0):
`InGameManager.BulletFireToList(GetBT(3) = bos08b_bow, GetSkyRootPosition(rootWorldPos) + offset, nlap 0, startArc = angle, rate 1, mover, …)`.
The returned bullets are registered as followers: their offset from the boss is stored, and `UpdateBowFollowerPositions` keeps them riding
with the boss until they are flying (`InGameBulletBow` state 4).

InGameBulletBow lifecycle (0x1CC9930):
spawn SE → fade-in (`_FadeInTimeDefault` 1 s) → wait for `Fire(delay)` → delay → fly (normal InGameBullet).

**BowWave** (`PatternBowWave` 0x1DAEF00; spawner 0x1DB1FF0):
- **mode 0**: open the wings, magic circle on (+190), timer 0.2, mode 10.
- **mode 10**: after 0.2 s: `ResetHover`, hover on, timers 0, mode 11.
- **mode 11**: spawn one pair every 0.05 s while `t = modeTimer` runs 0 → 1 (+0.05 per pair; 21 pairs [I: 20 or 21 depending on float
  rounding]).
  - `p = CubicBezier((-5,0,0), (-30,0,-30), (-75,0,60), (-100,0,30), t)`; `ang = -20 + 50t`.
  - Left: offset `p + (-20,0,0)`, angle `-90 - ang`. Right (mirrored): offset `(-p.x + 20, p.y, p.z)`, angle `ang - 90`.
  - Every bullet gets `Fire(2.0)` at once, so it flies 1 s (fade) + 2 s after it spawns.
  - When the spawner is done: `stateTimer += 1.0` (bow fade), mode 12.
- **mode 12**: `stateTimer += 2`, mode 13.
- **mode 13**: when the timer is ≤ 0: `ClearBowBullets(false)` (drops the lists only) → PT1.

**BowCircle** (`PatternBowCircle` 0x1DAE930):
- **mode 0**: close the wings (wings sleep, so only the core can be hit); then magic circle on (+190); timer 0.2; mode 10.
- **mode 10**: after 0.2 s: ResetHover, hover on, arc 0, mode 11.
- **mode 11**: spawn all 60 bullets at once: for `a = -90, -84, …, -444` (step +6 in position angle, bowArc -6 down to -360),
  offset = `(30·cos a, 0, 30·sin a - 4.5)` around the root, bullet angle `a` [I: angles in degrees, the same convention as positions, so
  each bullet points outward]. Bullets are kept in `_rightBowBullets` and not fired. `stateTimer += 2`; mode 12.
- **mode 12**: when the timer is ≤ 0: `TriggerBowBullet(10)` (0x1DB18B0) fires 10 random unfired bullets with `Fire(0)`.
  - If none remain: `ClearBowBullets(false)` → PT1.
  - Otherwise `timer += 0.5`.
  - This gives 6 volleys at 2.0, 2.5, … 4.5 s.

### 2.3 Destruction (`ToDestroid` 0x1DB1790, `PatternDestruction` 0x1DAF150)

`ToDestroid`:
- If Story B, `SetTrophy(12)`.
- Stop SE channels; `StopBossTimer`; `ReleaseToken`.
- `ClearBowBullets(true)`, which also calls `InGameBulletManager.ResetBullet(true)` (clears enemy bullets).
- Stop the hologram; state = Destruction.

`PatternDestruction`:

| mode | behaviour |
|---|---|
| 0 | start = localPos; targetAngle = rot · Euler(0,180,0); Middle blast (sky layer); AddShake(0.5,1,2); SmallBombSecond 0.2; `SetDirectionTime(5.5)`; timer 2; mode 10. Every mode: `localRotation = CurrentTargetAngle(directionRate)` (half a turn over 5.5 s) |
| 10 | small bombs: Small, se 40, AddShake(0.5,1,5). After 2 s: start = pos, target = pos + 2·(0,-200,0) = pos + (0,-400,0) (sinks away from the camera); AddShake(0.5,1,5); timer 0; mode 11 |
| 11 | t += dt; `pos = lerp(start, target, EaseIn(clamp01(t/4)))`; small bombs Middle se 40. When `pos.y < start.y - 200`: `_callDeadEffect()`, mode 12 |
| 12 | same motion. At t ≥ 4: ShouldCreateBossC ? `CallEnemyClip(0, localPos + (0,0,-30))` (spawns `ene_boss08c`) : `Phase_StageClear()`. Then PlayQue 42 and `Ene_BosBase.ToDestroid()` |

---------------------------------------------------------------------------------------------------------------------------------------
## 3. Ene_Bos08C (the core: sway, rotating twin lasers, homing side shots, tracking bow rings)

One part (no flags), HP 250 000. Prefab: `pf_eff_explposion_bos2`, se 41. Muzzles (`_muzzleNodeNames`):

| Muzzle | Local position |
|---|---|
| muzzle_top | (0, 8.11, 0) |
| muzzle_front | z -14 |
| frontEdge | z -1 |
| muzzle_back | z +14 |
| backEdge | z +1 |

Muzzle pack **"side"** = [side30 (10.3,0,-2.53), side90 (10.3,0,2.53), side10 (-10.3,0,-2.53), side70 (-10.3,0,2.53)].

`GetBattileTime` = **15 s**. After C has been alive for 15 s, the base `ProgressBossTimer` calls `TimeupAction` once, which sets
`_isHighDifficulty = true` and resets the attack timers. `GetBonusTimeKind` = 2. `GetStart` sets OffCollision.

### 3.1 States (EntryWait 0, PT1 1, Destruction 100)

**EntryWait** (0x1DB54E0):

| mode | behaviour |
|---|---|
| 0 | `SetDirectionTime(5)`; start = spawn localPos, target = Home **(0,0,50)**; startAngle = Euler(90,0,180), targetAngle = identity; PlayQue 193 `boss03_app`; mode 1 |
| 1 | r = directionRate; `SetLocalPositionAndRotation(lerp(start, target, EaseIn(r)), Lerp/Slerp(angle, r))`. At r ≥ 1: `SetBossGaugeStart(true)`; clear OffCollision; set OffLockon and NoDamaged; PlayQue 159; mode 2 |
| 2 | `UIBossGauge.SetAlpha(clamp01(t))`. After 1 s: clear OffLockon and NoDamaged; `ResetBossTimer(true)` → PT1 |

**PT1** (`PatternMovePhaseOne` 0x1DB5850; the helper methods UpdatePhaseOne*/StartPhaseOneEightWayBurst/RefreshEightWayInterval/
`FireEightWayBullets` have no callers; their logic is inlined).

mode 0 initialises:

| Field | Value |
|---|---|
| pendingHoming | false |
| nextHoming | true |
| movePhase, easeTimer, yaw, timers | 0 |
| eightWayInterval | `max(0.1, max(0.2, scale)·0.5)` |
| laser firing | true |

Then `FireFrontAndBackLasers()` and mode 10.

mode 10, every frame:
- **Movement** `UpdatePhaseOneMovement(dt, 60, 12, 1.2, 90)` (0x1DB70C0):
  - `φ = (φ + dt·2π/12) mod 2π`; `e = OutSine01(clamp01(easeTimer/1.2))`.
  - `localPosition = (0 + 60·sin φ·e, 0, 50)`.
  - `yaw += (cos φ_old - cos φ_new)·(90/ω)·e`, i.e. yaw rate = 90·sin φ·e °/s.
  - `localRotation = Euler(0, yaw, 0)`.
- **Laser cycle** (`laserTimer += dt`):
  - While firing: when laserTimer ≥ **3.5**, fade the laser SE (0.5 s) and stop firing.
    - Hard mode: laserTimer = 0.
    - Normal mode, if `nextHoming`: laserTimer = -1 and pendingHoming = true. Otherwise start the bow burst (active, remain 3 s,
      interval `max(0.1, scale)·0.5`) with laserTimer = 0. Then `nextHoming` toggles.
  - While idle: in normal mode, if pendingHoming and laserTimer crosses 0 (1 s after the laser), `FireHomingBullets()`.
    - When laserTimer ≥ idle (normal 3, hard 0.5): fire the lasers again and set laserTimer = 0.
  - Normal sequence: laser 3.5 s → idle 3 s (homing at +1 s) → laser 3.5 s → idle 3 s with a 3 s bow burst → …
- **Hard mode only**: homing on its own clock, every `max(0.1, scale)·1.5` s.
- **Bow rings**
  - Hard mode: `FireBowBullet()` every `max(0.1, scale)·0.5` s, all the time.
  - Normal mode: only during a burst, every eightWayInterval, until burstRemain ≤ 0.
- `UpdateBowFollowers(dt)`.

**Attacks**

| Attack | Method | Details |
|---|---|---|
| Lasers | `FireFrontAndBackLasers` 0x1DB42C0 | `BulletDirFireAsync(token, GetBT(0) = bos08c_00 (enemylaser000, nIrradiation 2), muzzle_front, frontEdge)` and the same with (muzzle_back, backEdge): two opposite beams along the body axis that sweep with C's yaw. Loop SE 236 `boss8c_beam_loop` (the old channel is stopped first) |
| Homing side shots | `FireHomingBullets` 0x1DB44C0 | for each "side" muzzle i: `BulletFireAsync(token, GetBT(1) = bos08c_01, isSelfDir=true, false, muzzle_i, null, offsetAngle = [-100,-80,100,80][i])`. bos08c_01 = enemybullet010, 8-shot rapid at 0.05, nIrradiation 10 [?: the homing behaviour lives in the template/bullet type] |
| Bow ring | `FireBowBullet` 0x1DB3A30 | center = `GetSkyRootPosition(muzzle_top.position)`; player = nearest player; `dir = normalize(playerSky - center)` (fallback: forward in the sky root). For i = 0..7: `d = AngleAxis(45·i, up)·dir`; bullet `GetBT(3) = bos08c_03` (enemybullet013) from muzzle_top. In the callback: `SetPositionAndDirection(center + 20·d, d)` and register a follower (time 2, angleOffset 45i, player) |
| Bow followers | `UpdateBowFollowers` 0x1DB64B0 | each frame, while the bullet `RequiresFollow`: recompute center and `dir` to the tracked player (y flattened); `pos = center + 20·(AngleAxis(offset, up)·dir)`; direction = that spoke. After 2 s: `Fire(0)`. The ring of 8 tracks C and re-aims at the player for 2 s, then launches outward |

`bos08c_02` (CoreWay, from muzzle_top) is only used by the uncalled `FireEightWayBullets`.

### 3.2 Destruction (`ToDestroid` 0x1DB6370, `PatternMoveDestruction` 0x1DB4D10)

`ToDestroid`:
- Trophies: 13 (Story C), 15 (Team), 17 (Arcade), only in trophy mode.
- `StopBossTimer`; `ReleaseToken`.
- `_clearBowFollowers(true)` (`CallDisabled` on the follower bullets).

`PatternMoveDestruction`:

| mode | behaviour |
|---|---|
| 0 | targetAngle = rot · Euler(0,180,0); Middle blast; stop the laser SE; `mover._laserCancelFlag = true` (kills the beams); AddShake(0.5,1,2); SmallBombSecond 0.2; `SetDirectionTime(3)`; timer 1; mode 10. Rotation follows the direction rate every frame |
| 10 | small bombs: Small, se 40, AddShake(0.5,1,5). After 1 s: start = pos, target = pos + (0,-20,0); AddShake(0.5,1,5); `_callDeadEffect()`; mode 11 |
| 11 | `pos = lerp(start, target, EaseOut(clamp01(t/2)))`; small bombs Middle se 40. At t ≥ 2: `Phase_StageClear()`, PlayQue 42, `Ene_BosBase.ToDestroid()` |

---------------------------------------------------------------------------------------------------------------------------------------
## 4. Bullet templates (`Boss08/…`, from `enemy-attacks.json`; full rows in `bos08_bullet_templates.json`)

| template | used by | bullet | type | speed | rapid × spacing | aim | notes |
|---|---|---|---|---|---|---|---|
| bos08arm0 | A arms | enemybullet004 | 6 | 0.5 | 1 | none (offset angle from code) | 360 arc |
| bos08cover0 | A cover volleys | enemybullet007 | 1 | 1 | 1 × 0.1 | target, rapid target | |
| bos08cover1 | A cover-broken shot | enemybullet008 | 16 | 1 | 1 | arc 90 | firePosRadius 40, ±45° |
| bos08b_00 | B PT1 (wings pack) | enemybullet007 | 6 | 1 | 8 × 0.2 | target, rapid target | |
| bos08b_10 / _11 | none [?] | 004 / 006 | 16 / 12 | 1 | 8 × 0.5 | selfDir | |
| bos08b_bow | B bows | enemybullet013 | 1 | 1 | 1 | target | spawned via BulletFireToList |
| bos08c_00 | C lasers | enemylaser000 | 1 | 1 | 1 | selfDir | irradiation 2 |
| bos08c_01 | C side shots | enemybullet010 | 1 | 1 | 8 × 0.05 | selfDir | irradiation 10 |
| bos08c_02 | none | enemybullet007 | 8 | 1 | 1 | — | 360 arc |
| bos08c_03 | C bow ring | enemybullet013 | 1 | 1 | 1 | none (position and direction set by code) | |

---------------------------------------------------------------------------------------------------------------------------------------
## 5. Animator usage

| Animator | Controller | Use |
|---|---|---|
| A `_armAnimes[0..5]` | anm_bs08_arm | `CrossFadeInFixedTime(bs08_arm_attack, 2.0)` at attack start; `(bs08_arm_standby, 2.0)` at the end |
| A `_coreAnime` | anm_bs08_top | `Play(anc_bs08_top_escape)` at death (6 s); `_bodyTop` hidden, `_modelTop` hidden at +5 s |
| B mover animator | anm_bs08_top_sky | `PlayAnimator(anc_bs08_top_sky_start)` at entry (5 s), `StopAnime(true)` before the move home |
| C | none | — |

---------------------------------------------------------------------------------------------------------------------------------------
## 6. Address table (RVA; full list `tools/method_rvas.txt`, disassembly `disasm/*.asm.txt`)

| method | RVA | constants taken |
|---|---|---|
| Ene_Bos08A..cctor | 0x1DABC30 | template names; ArmPartOrder/CoverPartIds/ArmMuzzleOrder (field data via InitializeArray FieldRefs 10/21/24); sequences FA/BA; cover configs; 12, 4, 1, 0.5, 0.01, 0.16, 40, 0.125, 2 (immediates); animator hashes |
| A Initialize / ReStart / ToDestroid | 0x1DA8F70 / 0x1DAB040 / 0x1DAB490 | mover._isForceFire = 1; core `_damageBlinkRate` = 0; sound 154, trophy 10 |
| A StateExec (EntryWait inline) / PatternMoveEntryWait | 0x1DAB280 / 0x1DAABD0 | 1.0 s wait |
| A CheckNextState / SetState | 0x1DA8200 / 0x1DAB240 | |
| A PatternMove2 | 0x1DA9E70 | cooldown; min interval 0.1 (rdata 0x34E0C24) |
| A TryStartArmPattern / AdvanceArmPatternIndex / TryBeginArmAttack / HasAnyAttackableArm / IsArmAttackRunning / ResetArmStatus | 0x1DAB9C0 / 0x1DA8010 / 0x1DAB6C0 / 0x1DA8DF0 / 0x1DA95B0 / 0x1DAB1D0 | ±1 (rdata 0x34E0BF4/0x34E0BCC) |
| A FireCoverShotBurst / ForSide / BackSequential / MuzzleGroup / TryGetAvailableMuzzle (jump table 0x1DAB918) / GetCoverShotIntervalSeconds | 0x1DA85A0 / 0x1DA8880 / 0x1DA82F0 / 0x1DA8480 / 0x1DAB810 / 0x1DA8A30 | |
| A PatternMoveTurn | 0x1DAAD40 | 2, 4, 180 (0x34E0BE8), 0.5/1/5, 2/1/5; sounds 155, 151 |
| A OnPartsBreak (+ jump table 0x1DA9E58) / <>c__DisplayClass49_0.b__0 | 0x1DA9780 / 0x1DB8D30 | 0.8/0.8/8 (0x35F2CC8, 0x34ECA20); 0.1 step; ±45 (0x35F2CDC, 0x35F2E7C); 1/1/9; sounds 152, 153, 156, 157 |
| A PatternMoveDestruction / _destroyedResult / GetSmallBombPosition | 0x1DAA310 / 0x1DACC80 / 0x1DA8C80 | 1, 2.5, 5.5 (0x35F2DC4), 0.2 (0x35F2BA0), 0.5, 2.77 (0x35F2E44), 5.7 (0x35F2E4C), 5; sounds 42, 233-235 |
| BossArm .ctor / get_IsBroken / ExecuteRoutineAsync / MoveNext | 0x1DA0730 / 0x1DA07A0 / 0x1DA04F0 / 0x1DB7920 | 2π (0x34ECA18), 0.5 |
| Ene_Bos08B..cctor | 0x1DB30E0 | Home (0,0,30), Boss3CPosition (0,-200,0), Boss3COffset (0,0,-30), Bezier points, bow offsets, circle offset, wing base rotations, 3.5 |
| B Initialize / ReStart / GetStart / ToDestroid / CallDisabled / StopLoopingSeChannels / ClearBowBullets | 0x1DAE0C0 / 0x1DB0870 / 0x1DADF10 / 0x1DB1790 / 0x1DAD4B0 / 0x1DB16E0 / 0x1DAD5C0 | dead explosion selection; trophy 12 |
| B CheckNextState / ChangeState / StateExec / GetBossCD / ShouldCreateBossC / ApplyDeadExplosionEffect | 0x1DAD510 / 0x1DAD4D0 / 0x1DB1680 / 0x1DADDC0 / 0x1DB1420 / 0x1DACE00 | |
| B ApplyWingOpening / UpdateWingRotation / OpenWings / CloseWings | 0x1DAD0B0 / 0x1DB2F00 / 0x1DAE7A0 / 0x1DAD710 | 0.2, 0.12 (0x35F2E64), -90 (0x35F2CFC), 180, 0.3 (0x34EC9D8), 0.7 (0x34ECAC0); sounds 161, 162, 190 |
| B ResetHover / ApplyHover / IsHoverStopped | 0x1DB0F30 / 0x1DACF00 / 0x1DAE540 | 5 (0x34E0E68), π, 2, 1/120 (0x35F2E40) |
| B PatternEntryWait | 0x1DAFB70 | 0.5, -0.5 (0x34ECA24), 3 (0x34EC914), 0.25; sounds 158, 159, 160 |
| B PatternPhaseOne / FireWingSpreadShot (no callers) | 0x1DB00B0 / 0x1DB28D0 | 12 (0x35F2E54), 60, 10; sound 163 |
| B PatternPhaseTwo / Execute / MoveTowards / Return / Reset / Begin / Finalize / PreparePhaseTwoTarget | 0x1DB0470 / 0x1DAD890 / 0x1DAE560 / 0x1DB1150 / 0x1DB1130 / 0x1DAD480 / 0x1DADD10 / 0x1DB0730 | 150 (0x35F2DD8), 0.5, 0.2, 15 (0x35F2BB0), 0.1, 2 |
| B PatternBowWave / SpawnWingBowSequence / SpawnBowBullets | 0x1DAEF00 / 0x1DB1FF0 / 0x1DB14D0 | 0.05, 50 (0x35F2BBC), 20, -90, 2 |
| B PatternBowCircle / TriggerBowBullet / SpawnCircularBowSequence (no callers) | 0x1DAE930 / 0x1DB18B0 / 0x1DB1CF0 | 30, 6, -360 (0x35F2D00), 0.5, 2, 10 |
| B Register/Unregister/UpdateBowFollower(s) | 0x1DB09D0 / 0x1DB0B90 / 0x1DB2970 / 0x1DB2A00 | |
| B PatternDestruction / HandleDestroyedResult / GetSmallBombPosition | 0x1DAF150 / 0x1DADF70 / 0x1DADE40 | 2, 4 (×0.25 at 0x34EC9D4), 5.5; random "wings" muzzle |
| Ene_Bos08C..cctor | 0x1DB7300 | home (0,0,50), Euler(90,0,180), arcAngles (FieldRef data F3D9024B…), names |
| C Initialize / ReStart / GetStart / CallDisabled / TimeupAction / ToDestroid / GetBattileTime | 0x1DB4970 / 0x1DB5F40 / 0x1D7E4B0 / 0x1DB3950 / 0x1DB6320 / 0x1DB6370 / 0x1DB4750 | 15 (0x35F2BB0); trophies 13/15/17 |
| C CheckNextState / StateExec / PatternMoveEntryWait | 0x1DB39E0 / 0x1DB6230 / 0x1DB54E0 | 5, 1; sounds 193, 159 |
| C PatternMovePhaseOne / UpdatePhaseOneMovement | 0x1DB5850 / 0x1DB70C0 | 60, 12, 1.2 (0x35F2D88), 90 (0x34EC9A8); 3/0.5 idle; 3.5 (0x35F2E48); 1.5 (0x34EC998); -1; 3 |
| C FireFrontAndBackLasers / StopLaserSe / FireHomingBullets / FireBowBullet (+b__0 0x1DD1470) / UpdateBowFollowers / _clearBowFollowers | 0x1DB42C0 / 0x1DB6260 / 0x1DB44C0 / 0x1DB3A30 / 0x1DB64B0 / 0x1DB7690 | 45 (0x35F2CDC), 20 (0x34E0BDC), 2.0; sound 236 |
| C PatternMoveDestruction / HandleDestroyedResult | 0x1DB4D10 / 0x1DB47B0 | 1, 20, 2, 3 |
| base: Ene_BosBase ProgressBossTimer / CountupBossTimer / CurrentTargetVector / GetBattileTime | 0x1DBA1D0 / 0x1DB9460 / 0x1DB9630 / 0x1DB9870 | ActStep 18 = time-up → TimeupAction; 10 s act steps |
| VectorUtility.InfinitySymbol | 0x1DF7690 | a = 360t + 90; (cos a·X, 0, sin 2a·Z) |
| InGameBulletBow .cctor / Fire / ProgressBullet / get_RequiresFollow | 0x1CC9D30 / 0x1CC9880 / 0x1CC9930 / 0x1CC9E60 | fade-in 1.0; follow while state ≠ 4 |

Enum and field sources: `code/type-model-source/DiffableCs/InGame.Kernel/InGame/Kernel/Enemy/Ene_Bos08{A,B,C}.cs` (field offsets), and
`types_dump.txt` / `fields_offsets.txt` / `vtables.txt` here.

---------------------------------------------------------------------------------------------------------------------------------------
## 7. Open questions

1. Parent-frame details. Is A's ground root moved by anything besides the scrolling ground layer (`mover._isFinishDelay` and the "Start"
   event vector (0,0,-250) are base behaviour)? What is C's world spawn point, given B's sunken local position (y ≈ start-400) plus
   (0,0,-30) through `CallEnemyClip`? C then lerps to (0,0,50) in its own local frame.
2. Where exactly the HallBoss Stop holds the timeline (its start or its end), and therefore how long after A's death B appears (507 s on
   the timeline).
3. `GetEventRepeatScale()` value per difficulty/mode (it scales A's cover cadence, B's PT1 volley period and C's homing/bow cadence).
4. Bullet-type behaviour (types 6, 8, 12, 16; nIrradiation on bos08c_00/01: laser life and homing) is in the shared bullet system, not in
   these classes.
5. `bos08b_10`/`bos08b_11` (pat2A/pat2B), `bos08c_02` and the EnemyData `bos08a_ma01` are loaded but never fired or spawned by this
   code.
6. Whether ExplosionCodeSmall, Middle and Large map to pf_eff_explposion01, 02 and 03 (taken from Round1Boss, not re-verified here).
7. Whether the base `GetCurrentAnimatorStateInfo(0).length`, read in the same frame as `PlayAnimator`, returns the 5 s entry clip or the
   previous Idle state. This sets B's entry timer.
