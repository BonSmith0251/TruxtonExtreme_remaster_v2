# Ene_Bos04 (BG04 boss) — behaviour specification from the native code

Sources: `GameAssembly.dll` (IL2CPP x64). Every method of `Ene_Bos04`, its nested types and `Ene_Bos04Bit` is disassembled in
`disasm/` (file name = RVA_type_method, call targets, string literals and .rdata floats annotated); `Ene_BosBase` in
`disasm_base/`. Tools: `tools/nat.py` (disassembler + metadata v39 literal decoder), `tools/prefab_dump.py`. Constants in
`bos04-constants.json`, serialized prefab values in `prefab-values.json`. [I] = inference, [?] = unknown.
Offsets: `Ene_Bos04` fields 0x270–0x319 as in `code/type-model-source/.../Ene_Bos04.cs`; verified against their use.

## 1. Identity

| item | value |
|---|---|
| classes | `InGame.Kernel.Enemy.Ene_Bos04 : Ene_BosBase`, `Ene_Bos04Bit : PawnEnemy` (guardians) |
| prefabs | `OriginalRecovered/Samples/Prefabs/Reference/Enemy/Pf_Ene_Bos04.prefab`, `Pf_Ene_Bos04_bit.prefab` |
| EnemyData | `ene_boss04` (BG04.json): model Pf_Ene_Bos04, attribute 1072 = EventStack\|BossEvent\|SkipRestartCheck, position (0,0,25), events: Animation `anc_bs04_start` → TaskWait(16) → FinishWait |
| spawn | timeline `main/BOSS:20:422` — boss entry at **422.0 s**, clip end 540 s (areas BG04_BOSSST 420–480, BOSSLP 480–540) |
| child EnemyData (CallEnemyClip index) | 0 `bos04_bitL`, 1 `bos04_bitR`, 2 `bos04_sg00L`, 3 `bos04_sg00R`, 4 `bos04_sg00C` (`Samples/EnemyData/boss/`) |
| child pools (SubEnemys) | Pf_Ene_Sg01 ×100, Pf_Ene_Bos04_bit ×2 |
| HP (EnemyDatabase) | boss row 46: **750000**, lock-on, blocks laser, score 100000; wing20/40/60/80 rows 47–50: **25000** each (Independent); bit row 51: **500000**, lock-on, no damage score; Sg01 row 158: 500 |
| parts (PartsList index = PartsKind) | 0 mainBody (flags 1 MasterBody), 1 core (17 MasterBody\|SleepStart), 2 mainHead (17), 3–6 wing20/40/60/80 (18 Independent\|SleepStart, BreakEffect `pf_eff_explposion03` at their explosion roots) |
| collision shapes | `enemy-hitshapes.json` model 46: body & head capsule (35,39) under `pf_bs04/bs04_body_under` at local (0,0,−11); core circle r22 and wing capsules on the **root** (`collisionWing20` (0,−5,50), 40 (50,−5,0), 60 (−50,−5,0), 80 (0,−5,−50)); head & core have `OnlyHitPlayer` (only player bullets register), wings `subject OnlyBullet` |
| dead effect | `_deadExplosion pf_eff_explposion_boss`, `_overplayDeadSound 41` (exp_st3_boss_b02), `_explosionOffset` 0 |

Bullet templates (`Ene_BosBase.btemplates`, by `GetBT(i)`; full fields in `Resources/StageCombat/enemy-attacks.json`):
`0 bos04bit0` (bits; enemybullet006, aimed rapid 10), `1 bos04p1way3l` / `2 bos04p1way3r` (enemybullet005, aimed, rapid 4,
rapid rotation ∓22.5°), `3 bos04laser` (enemylaser003, isSelfDir, irradiation 1, speed 0.8), `4 bos04p6sl` (short laser,
enemybullet006, irradiation 1, rapid 3), `5 bos04p6rs` (**never fired**), `6 bos04p5way3` (enemybullet011, aimed, rapid 4,
rapid distance 0.5), `7 bos04p5way3s` (enemybullet011s, same shape). Native fire calls override the template rapid count
(`BulletFireAsync argLoopCount` / `BulletDirFireAsync overlapLoop`: `count = arg>0 ? arg : bt.nRapidCount`, d__51 MoveNext 0x1CF46CB).

Muzzles (`Initialize` 0x1D8C5F0: `_muzzles[i] = FindAlls(_modelTop, Boss04MZ[i].ToString())`, modelTop = `pf_bs04`):
`0 under20 (0,27,16)`, `1 under40 (27,0,16)`, `2 under60 (−27,0,16)`, `3 under80 (0,−27,16)`, `4 under_ene_sg (0,0,16)` — under
`bs04_body_under`; `5 upper02 (0,23,−8)`, `6 upper04 (23,0,−8)`, `7 upper05 (0,0,−25.4)`, `8 upper06 (−23,0,−8)`, `9 upper08 (0,−23,−8)`
— under `bs04_body_upper` (= `_upperCore`). Mover muzzle packs: `upper` = [upper02, upper04, upper06, upper08], `target` =
[upper02t (0,50,0), upper04t (50,0,0), upper06t (−50,0,0), upper08t (0,−50,0)] (laser i fires from upper[i] toward target[i]).
`_wings` = `bs04_body_under/bs04_wing20/40/60/80`.

## 2. Frame and units
Source sky plane (x right, z up the screen, y toward the camera; camera at (0,400,0), 20° vFOV). The boss root moves by
`transform.localPosition` under `InGameManager._inGameEnemyRoot`; children spawned by `CallEnemyClip` go to the same root
(`EntryEnemyNoRate(data, _inGameEnemyRoot, offset, Division Sky, 0)` 0x1DB8F70), not to the boss. Angles in degrees;
`VectorUtility.Sinf/Cosf` are 0.1°-table lookups. Unity Euler order ZXY.

Helpers (exact):
- `InfinitySymbol(t,w,h)` 0x1DF7690: `a = clamp01(t)*360+90; return (w*cos a, 0, h*sin 2a)`.
- `FreeFall(t)` 0x1DF71B0: `|sin(180*frac(t))|`.
- `InOutQuad01`, `OutQuad01`, `OutSine01 = sin(90t)`, `InOutSine01 = (1−cos 180t)/2`, `InQuart01 = t⁴`; `Easing01` type 0 linear,
  1 EaseIn t², 2 EaseOut 1−(1−t)².
- `CurrentTargetVector(r,ease)` = lerp(_startVector,_targetVector, clamp01(Easing01(clamp01 r))); `CurrentTargetAngle(r)` =
  `Quaternion.Lerp(_startAngle,_targetAngle,clamp01 r)`.
- Base timers (`Ene_BosBase.ProgressBossTimer` 0x1DBA1D0, unchanged from Bos03): `GetDirectionRate = clamp01(passed/total)`;
  repeat timer laps every `_repeatTimer` (sets `_repeatLaped` for that frame, `_repeatTimes++`); `GetRepeatRate =
  clamp01(passed/timer)`; boss time → `_currentActStep` +1 every 10 s (Passed90 = 90 s, Passed150 = 150 s); `IsAttackLoop()`
  pre-decrements `_attackLoopCount`. hpState from hpRateRanges .9/.75/.51/.4/.3/.2/.1/0 (HalfHP ⇔ HP≤51%, LowerHP ⇔ ≤30%,
  LowestHP ⇔ ≤20%). `IsOverAorB(hp,step) = hpState≥hp || actStep≥step`. `StateExec` runs from `LocalLateUpdate` each frame.

## 3. State machine (`StateExec` 0x1D90270, `CheckNextState` 0x1D8BC40, `SetState` 0x1D901D0)

`SetState(s)`: if s changes → `_patternMode = 0`; always stops the PT5 roll loop sound (`StopCh(_rollSEId)`) and clears
`mover._laserCancelFlag`.

**Global interrupt** (top of StateExec, every frame, and at the start of CheckNextState): if state ∉ {OpenWing, Destruction},
`!_isOpenWing` and `IsOverAorB(HalfHP, Passed90)` → `SetState(OpenWing)` immediately, even mid-pattern.

CheckNextState otherwise: closed form (`!_isOpenWing`): EntryWait→PT1→PT2→PT3→PT1→…; any other state → EntryWait.
Open form: OpenWing→PT5, PT5→PT6; PT6 has no successor (loops until death). `ToDestroid` → Destruction from anywhere.

| state (enum) | handler | ends |
|---|---|---|
| EntryWait 0 | inline in StateExec (same as `PatternEntryWait` 0x1D8CDF0) | mode 3 timer → CheckNextState |
| PT1 1 | `PatternMove1` 0x1D8D040 | ≈15.5 s, or early on hpState change |
| PT2 2 | `PatternMove2` 0x1D8D6C0 | 3 + 5 + 2 = 10 s |
| PT3 3 | `PatternMove3` 0x1D8DE00 | 6 + 1 + 8 + 1 + 0.5 = 16.5 s |
| OpenWing 10 | `PatternOpenWing` 0x1D8F6F0 | 3 s → PT5 |
| PT5 4 | `PatternMove5` 0x1D8E920 | all 4 wings broken + ending → PT6 |
| PT6 5 | `PatternMove6` 0x1D8EDF0 | never |
| Destruction 100 | `PatternMoveDestruction` 0x1D8F1C0 | 5.5 s → base ToDestroid |

### EntryWait (0x1D902E7…0x1D90517)
- Spawn: `GetStart` sets ObjectFlag OffCollision. The EnemyData plays `anc_bs04_start` (5 s, on the Animator of `pf_bs04`):
  modelTop local pos (80,−100,145)→(0,−100,0)@2→(0,50,−10)@4→0@5, euler (0,220,360)→(−20,185,360)@2→(0,180,0)@4.
- mode 0: `PlayQue(54 bg4_boss_app_01)`; mode 1.
- mode 1: `_localTime += dt`; at ≥ **2.7 s** (`_EntryNoHitTime`): ResetObjectFlag(OffCollision), SetObjectFlag(OffLockon\|NoDamaged); mode 2.
- mode 2: when `mover._isFinishDelay` (set when the EnemyData event stack completes, ≈ end of the 5 s clip [I]): `StopAnime(true)`,
  modelTop.SetLocalPositionAndRotation(0, `_ModelTopRotateStart` (0,180,0)); `_localTime = 0.25`; mode 3.
- mode 3: `_localTime −= dt`; at ≤0: ResetObjectFlag(OffLockon\|NoDamaged), `ResetBossTimer(true)` (boss timer starts,
  `_startInGamePosition` = current localPosition = (0,0,25) [I], hpState 0, actStep 0), CheckNextState → PT1.

### PT1 — guardian swing (PatternMove1, Pattern1Move 0x1D8CC90)
- mode 0: `CheckGuardians()` (spawn bits, §6); `SetOldState()`; `setBodyHeadCollision(false)`; `_isReverseMove = IsPlayerSideRight`;
  loopCount 0; `_pattern1IsFirst = true`; → mode 10.
- mode 10: `_attackLoopCount = 2`; `SetDirectionTime(5)`; `SetRepeatTime(2.5)`; → mode 11.
- mode 11 (swing pass, 5 s): `r = dirRate`, eased by `_pattern1EaseIn` on the first pass only; `Pattern1Move(r)`.
  On every repeat lap (2.5 s and 5.0 s of each pass) fire `GetBT(_isPlayerSideLeft ? 2 : 1)` (p1way3r if player x<0 else
  p1way3l) from muzzle `0.45<r<0.55 ? (_isReverseMove ? under40 : under60) : under20`, rapid **3** (6 when boss time ≥ 90 s),
  `BulletFireAsync(isSelfDir false, nested false, muzzle, base null, 0°)`.
  At r ≥ 1: IsFirst = false; if `IsChangeHpState()` (hpState ≠ value saved at mode 0) → `setBodyHeadCollision(true)`,
  CheckNextState (early exit). Else toggle `_isReverseMove`, `SetDirectionTime(5)`; if `IsAttackLoop()` stay (second pass),
  else → mode 20. ⇒ two linear-rate passes (first eased-in), alternating side.
- mode 20 / 21 (third pass, 5 s, eased by `_pattern1EaseOut`): `Pattern1Move(e)`. Mode 20: when e ≥ 0.5 every live guardian in
  `_guardianList` fires its `bos04bit0` from its own transform (inline Bit.Fire, rapid from template = 10); → mode 21.
  Mode 21: at e ≥ 1 toggle reverse, `++loopCount`; loopCount < `_Pattern1RepeatCount` (1) ? mode 10 : (`_localTime=0`, mode 22).
- mode 22: wait **0.5 s** → `setBodyHeadCollision(true)`, CheckNextState → PT2.
- `Pattern1Move(r)`: `s = _isReverseMove ? −1 : 1; f = FreeFall(r)*s;`
  `localPosition = start + (−40 f, inf.y, inf.z)` with `inf = InfinitySymbol(r, 0, 10)` ⇒ `z = start.z − 10 sin(720 r)`;
  `localRotation = Euler(0, 0, 80 f)`. (start = `_startInGamePosition`.) Non-reverse swings to start.x−40 and back,
  reverse to +40; a figure-8 dip of ±10 in z; banks ±80°.

### PT2 — flip and Sg01 stream (PatternMove2)
- mode 0: `AddShake(1,1,10)`; start = target = localPosition, target.z += 50; startAngle = identity, targetAngle =
  Euler(0,0,180); `_sgCounter = 0`; `SetDirectionTime(3)`; → mode 10.
- mode 10 (3 s): `e = _pattern2EaseInOut(rate)` (flat 0→1 S-curve); position = lerp, rotation = Lerp → upside-down
  (180° about z) and 50 higher. At rate ≥ 1: `SetRepeatTime(boss time ≥ 90 s ? 0.2 : 0.3)`, `_localTime = 5`; → mode 11.
- mode 11 (5 s): `pos = target + InfinitySymbol(InOutQuad01(_localTime/5), 20, 2)` (x = −20 sin 360e, z = −2 sin 720e; e runs 1→0);
  `_localTime −= dt`. Each repeat lap: `CallEnemyClip(2 + (_repeatTimes & 1), pos)` → `bos04_sg00R` on odd laps (first),
  `bos04_sg00L` on even; `_sgCounter += n`; `AddShake(0.2,1,10)`; `PlayQue(241 bg4_boss_ene_sg_injection_01)`.
  ⇒ 16 Sg01 (25 after 90 s). At `_localTime ≤ 0`: start = localPosition, target = `_startInGamePosition`, startAngle =
  localRotation, targetAngle = identity, `SetDirectionTime(2)`; → mode 20.
- mode 20 (2 s): ease2 lerp back and un-flip; at e ≥ 1 CheckNextState → PT3.

### PT3 — rise, Sg01 burst, rolling rush (PatternMove3)
- mode 0: start = target = pos, target.z += 50; `SetRepeatTime(0.3)`; `AddShake(12,1,10)`; → mode 10.
- mode 10 (6 s): `pos = lerp(start,target, ease2(clamp01(t/6)))`; each lap `CallEnemyClip(4 sg00C, (pos.x,pos.y,pos.z−20))`,
  `PlayQue(241)` ⇒ 20 Sg01. At t ≥ 6 → mode 11.
- mode 11: wait **1 s** → `PlayQue(93 bg4_boss_rushing_01)`, `setBodyHeadCollision(false)`, start = target (z+50 point),
  target.z −= **150**; → mode 20.
- mode 20 (8 s): `r = clamp01(t/8)`; `pos = start + (target−start)*_pattern3Position(r)` (unclamped; curve peaks 0.9965 @0.39,
  dips −0.076 @0.91, back to 0); `localRotation = Euler(360*_pattern3RotateX(r),0,0) * Euler(0,0, 2880*InOutQuad01(r))`
  (two half flips about x and 8 rolls about z). First frame r > 0.5: `PlayQue(95 bg4_boss_app_rising_01)`. At t ≥ 8 → mode 30.
- mode 30: start = pos, target = `_startInGamePosition`, localRotation = identity, `SetDirectionTime(1)`, `PlayQue(94 bg4_boss_app_above_01)`; mode 31.
- mode 31 (1 s): ease2 lerp home; then `_localTime = 0.5`, mode 32.
- mode 32: `_localTime += dt` until ≥ 1 (0.5 s): `SetDirectionTime(3)`, `setBodyHeadCollision(true)`, CheckNextState → PT1.
  (Mode 33 — a 3 s `InfinitySymbol(e,4,8)` hover — is unreachable.)

### OpenWing — transformation (PatternOpenWing)
- mode 0: if hpState ≥ HalfHP (entered by damage, not by time): `PlayQue(212 boss_parts_destruction_g_01)` and
  `SkyExplosionEffect(ExplosionCodeMiddle, boss world pos, EnemySkyLayer, no SE)`. Then `ChangeDarkMode(true,0.3,0)`,
  `StopShake()`, `DestroyGuardians()`, PartsList[0] mainBody `ToSleep()`, mainHead `ChangeCollisionsAttribute(NoHitSubject,set)`;
  startAngle = modelTop.localRotation, targetAngle = `_ModelTopRotate` (90,0,0); start = localPosition, target =
  `_OpenWingPosition` (0,−80,30); root localRotation = identity; `_wingRotation = 0`; `SetDirectionTime(3)`;
  `PlayQue(96 bg4_boss_transformation_01)`; mode 1.
- mode 1 (3 s, r = dirRate): modelTop.localRotation = Lerp(start,(90,0,0),r); `pos = CurrentTargetVector(r, EaseOut)` with
  `pos.y += _patternOpenWing(r) * −150` (sinks up to 150 away from the camera at r≈0.45 and comes back);
  `UpdateWingRotation(r*dt*36)`; wings[i].localRotation = `Slerp(_WingArcs[2i], _WingArcs[2i+1], OutSine01(r))`
  (wing20 0→(90,0,0), wing40 (0,0,−90)→(0,−90,−90), wing60 (0,0,90)→(0,90,90), wing80 (0,0,180)→(−90,0,180)).
  r > 0.85 once: mainBody `Wakeup()`, SetObjectFlag(OffLockon\|NoDamaged). r > 0.7 once: `ChangeDarkMode(false,0.3,0)`.
  r ≥ 1: `PlayQue(97 bg4_boss_transformation_02)`; mode 30.
- mode 30 (one frame): targetAngle = identity, targetVector = 0; ResetObjectFlag(OffLockon\|NoDamaged); mainBody `ToSleep()`;
  mainHead NoHitSubject set; wings (parts 3–6) and core (part 1) `Wakeup()`; `_isOpenWing = true`;
  `UpdateWingRotation(dt*36)`; CheckNextState → PT5.
- `UpdateWingRotation(a)` 0x1D90FD0: `_wingRotation = wrap360(_wingRotation + a)`; root `localRotation = Euler(0, _wingRotation, 0)`
  (whole boss spins in the screen plane, 36°/s in PT5/PT6). Root-parented wing/core colliders spin with it.
- The position is left at (0,−80,30); PT5 then writes (0,0,20)+… directly (an 80-unit depth snap) [?].

### PT5 — spinning figure-8, wings as targets (PatternMove5, Update 0x1D90830, infinityMoveLookPlayer 0x1D921D0)
- mode 0: `_rollSEId = Play(98 bg4_boss_unit_rotation_01)` (looping; stopped by the next SetState); `_pattern5First = true`;
  `SetDirectionTime(16)`; `SetRepeatTime(4.0)`; `_lookAngle = wrap360(atan2(upperCore.right.x, upperCore.right.z))`;
  `_targetPlayer = −1`; `_destroyWingCount = 0`; `_isFireReady = false`; `UpdateWingRotation(dt*36)`; mode 20.
- mode 20 each frame: `m = dirRate`, `a = repeatRate`; `n` = broken wings among parts 3–6; if `IsOverAorB(LowestHP, Passed150)`
  every unbroken wing is broken now (`BreakParts(false, effect, sound)`) and counted; `Update(m,a,n)`; `UpdateWingRotation(dt*36)`.
  When n == 4: `_destroyedPositionRate = m`, `_destroyedRemainTime = (1−m)*14`, `_localTime = 0`, `_isDirectionPause = true`; mode 30.
- mode 30 (ending): `t = min(_localTime/_destroyedRemainTime, 1)`; `Update(p + (1−p)*OutQuad01(t), a, 4)` with p =
  `_destroyedPositionRate`; at t == 1: CheckNextState → PT6 and `mover._laserCancelFlag = true` (cancels live short lasers).
- `Update(m, a, n)`: `odd = _repeatTimes & 1`, `spinSign = (_repeatTimes & 2) ? −1 : +1`; if `_pattern5First`
  `m = _pattern5EaseIn(m)`.
  - Movement: `localPosition = (0,0,20) + InfinitySymbol(1−m, 60, 50)` ⇒ `x = 60 sin 360m, z = 20 + 50 sin 720m`.
  - Core aim (`_upperCore.localRotation = Euler(0,0, _wingRotation − 180 − _lookAngle)`):
    even `_repeatTimes` (look at player): `rel = wrap180(atan2(P.x−B.x, P.z−B.z) − _lookAngle)` (P = nearest player sky pos,
    chosen once per PT5), `W` = the `_WatchAngles` entry (45/135/225/315) nearest rel, `δ = wrap180(W − rel)`,
    `_lookAngle −= δ * dt * 2.0 * InQuart01(min(2a,1))` (turns a diagonal, i.e. the gap between two lasers, onto the player);
    odd `_repeatTimes` (spin): `_lookAngle += spinSign * 90 * dt * (1 − InQuart01(a))`.
  - Fire: on a repeat lap, when `n < 4 || m < 0.9`, set `_isFireReady`; then
    even `_repeatTimes`: `mover.ResetTargetPlayer()`, fire `bos04p5way3` from `muzzle_body_upper05`, rapid `n<1 ? 3 : n<2 ? 4 : 5`;
    odd `_repeatTimes`: for i in 0..3 `BulletDirFireAsync(bos04p6sl, upper[i] → target[i], rapid boss time ≥ 90 s ? 7 : 4)`
    (4 short lasers in a cross that then sweep with the spin). First lap (`_repeatTimes` = 1) is the laser.
  - If n changed: `SetRepeatTime([4.0, 3.0, 3.0, 2.5, 2.0][clamp(n,0,4)])`.
  - At m ≥ 1 (one round): `SetDirectionTime(hpState ≥ LowerHP ? 14 : 16)`, `_pattern5First = false`.

### PT6 — final pattern (PatternMove6, infinityMove 0x1D92AA0, coreLongLaser 0x1D91DC0)
- mode 0: `mover._laserCancelFlag = false`, `_isDirectionPause = false`, `SetDirectionTime(12)`, `_isReverseMove = false`,
  `_localTime = 0`, `_laserCount = 3`; mode 10.
- mode 10 each frame: `r = dirRate`; `infinityMove(r, 60, 20, dt, _isReverseMove)`: `s = rev ? 1−r : r`, `e = InOutSine01(s)`,
  `localPosition = (0,0,20) + InfinitySymbol(1−e, 60, 20)` (x = 60 sin 360e, z = 20 + 20 sin 720e);
  `_lookAngle += (rev ? +1 : −1) * 60 * dt * (1 − r⁴)`; core rotation as in PT5. `UpdateWingRotation(dt*36)`.
  At r ≥ 1: `SetDirectionTime(12)`, toggle `_isReverseMove`, `_laserCount = 3`, `_localTime = 0` (new 12 s round).
- Fire (inline `pat6fire`): `_localTime −= dt`; at ≤ 0: if `_laserCount > 0` → `coreLongLaser()`, `_localTime = 2.5`,
  `_laserCount−−`; else `PlayQue(99 bg4_boss_tornado_bullet_01)`, fire `bos04p5way3s` from `muzzle_body_upper05` (template rapid 4),
  `_localTime = 99`. ⇒ per round: long lasers at 0, 2.5, 5.0 s, one p5way3s at 7.5 s, quiet to 12 s.
- `coreLongLaser`: for i in 0..3 `BulletDirFireAsync(bos04laser, upper[i] → target[i], 0)`; its callback mutes every laser
  except the first (`EnemyLaserCollision.SetSoundId(−1,−1)`), so one laser sound plays.

### Destruction (ToDestroid 0x1D90650 → PatternMoveDestruction)
- `ToDestroid` (HP 0): trophy 5 if trophy mode; `StopBossTimer`; `mover.DeleteRouteToken()`; `DestroyGuardians()`;
  `ReleaseToken()` (cancels pending fire tasks [I]); `SetState(Destruction)`. It does **not** call the base ToDestroid yet.
- mode 0: `_isDirectionPause = false`; `AddShake(0.5,1,2)`; start = target = pos, **target.y −= 150** (sinks away);
  startAngle = localRotation, targetAngle = Euler(20,45,0); `SetSmallBombSecond(0.2)`; `SetDirectionTime(5.5)`; `_localTime = 3.5`; mode 10.
- mode 10/11: `pos = CurrentTargetVector(rate, EaseIn)`, `rot = Lerp(rate)`; `_localTime −= dt`.
  Small bombs (`IsCallSmallBomb`): interval starts 0.2 s, each bomb next = base + rand·0.1, base ×= 0.9; each =
  `SkyExplosionEffect(ExplosionCodeSmall, random muzzle world pos (any of the 10), EnemySkyLayer, SE 40 exp_st3_boss_a01)`
  (+`AddShake(0.5,1,5)` in mode 10). At 3.5 s (mode 10 end): `AddShake(0.5,1,5)` and virtual slot 0x588 = `_callDeadEffect`
  [I: same slot PawnEnemy.ToDestroid calls first] → pf_eff_explposion_boss, camera shake (1,3,1), vibration; mode 11, 2.0 s.
- mode 30 (at 5.5 s): `PlayQue(42 exp_st3_boss_c03)`; `Ene_BosBase.ToDestroid()` (vibration 0.8/1/2, `_isBossDead`, PawnEnemy removal).

## 4. Movement summary (root localPosition, start = (0,0,25) [I])
| state | path |
|---|---|
| Entry | root fixed; modelTop animated 5 s (see EntryWait) |
| PT1 | x = 25-centred swing ±40 by `|sin 180r|`, z −10 sin 720r, bank ±80° z; 3 × 5 s |
| PT2 | 3 s to z+50 while rolling 180° (z axis); 5 s sway ±20 x / ±2 z; 2 s back |
| PT3 | 6 s to z+50; 1 s hold; 8 s rush to z−150 and back by `_pattern3Position`, flips/rolls; 1 s home; 0.5 s |
| OpenWing | 3 s EaseOut to (0,−80,30) with y dip to −150·curve; modelTop to (90,0,0); wings unfold |
| PT5 | (0,0,20) + (60 sin 360m, 0, 50 sin 720m); round 16 s (14 s at ≤30% HP); spin 36°/s |
| PT6 | (0,0,20) + (60 sin 360e, 0, 20 sin 720e), e = InOutSine; 12 s rounds alternating direction; spin 36°/s |
| Destruction | 5.5 s EaseIn sink 150 away from camera, rotate to (20,45,0) |

## 5. Attacks summary
| state | attack | muzzle | cadence |
|---|---|---|---|
| PT1 | p1way3l/r (by player side) rapid 3 (6 ≥90 s) | under20, mid-pass under40/60 | every 2.5 s during the 2 swing passes (4 volleys) |
| PT1 | bits bos04bit0 (rapid 10) | each bit | once, mid third pass |
| PT2 | Sg01 `bos04_sg00R/L` (spline routes boss04sgR/L) | boss position | 0.3 s (0.2 s ≥90 s) for 5 s |
| PT3 | Sg01 `bos04_sg00C` | boss pos −20 z | 0.3 s for 6 s; then body rush |
| PT5 | 4 short lasers bos04p6sl rapid 4 (7 ≥90 s), sweeping | upper02/04/06/08 → …t | odd laps |
| PT5 | bos04p5way3 rapid 3/4/5 (0/1/≥2 wings down) | upper05 | even laps; laps 4.0 s → 3.0/3.0/2.5/2.0 s by wings broken |
| PT6 | 4 long lasers bos04laser | upper → target | 0, 2.5, 5.0 s of each 12 s round |
| PT6 | bos04p5way3s | upper05 | 7.5 s of each round |
Dead code: `coreShortLaser`, `Pattern1Fire`, `CheckFireAngle`, `CrossedAngle`, `CalcTranslateRate`, PT3 mode 33; template p6rs unused.

## 6. Parts, guardians and summons
- **Body/head toggle** `setBodyHeadCollision(x)` 0x1D92F20: `x=false` → mainBody colliders get NoHitBullet\|NoHitSubject (off),
  mainHead colliders cleared (on); `x=true` → the reverse. Same capsule; the head is `OnlyHitPlayer` (only player bullets
  register, `EnemyCollisionModel.IsBulletHit` 0x1D63590) while the body also registers other objects; both are MasterBody, so
  the boss is shootable either way. False during PT1 and the PT3 rush, true otherwise. `OnHitProgress` 0x1D8C980: an
  **enemy-layer** object touching the boss is killed (`SetCauseOfDeath(−1, friendlyFire 111)` + virtual kill); enemy bullets ignored.
- Phase 1 targets: body/head. Wings and core sleep (SleepStart) until OpenWing mode 30. Phase 2 targets: core (r22, centre)
  and 4 wings (25000 each, `pf_eff_explposion03` on break); mainBody asleep; mainHead gets NoHitSubject (keeps whatever
  NoHitBullet state it had when OpenWing interrupted — still shootable if PT1/rush was interrupted [I]).
- Wing breaks drive PT5: fire interval and p5way3 width; all 4 broken → ending → PT6. Forced break at ≤20% HP or 150 s.
- **Guardians** (`CheckGuardians` 0x1D8B840, each PT1 start): if `!_isGuardianLeft` spawn `bos04_bitL`; if `!_isGuardianRight`
  spawn `bos04_bitR`; each spawned `Ene_Bos04Bit.Setup(this)` adds it to `_guardianList`; the pool callback clears the flag
  when the bit is gone, so destroyed bits respawn on the next PT1. Bit EnemyData: start (∓100,0,200), Translate to (∓100,0,50)
  in 2 s (easeType 8), then spin 360°/2 s about y forever (bitR −360). `Ene_Bos04Bit.ReStart` caches `bos04bit0`;
  `ToDestroid` removes it from the parent list. `DestroyGuardians` 0x1D8BE20 (OpenWing start, death) kills every live
  `Pf_Ene_Bos04_bit`.
- Sg01 EnemyData (`bos04_sg00L/R`: SplineMove route boss04sgL/R, then Speed 40/10, Horming 0.5/5 for 5 s, ForwardMove;
  `bos04_sg00C`: rotate 180 y, Translate (0,0,−50) 1 s, then the same chase) — behaviour is Sg01's own.

## 7. Animator
Controller `TXE_GraphicData/Boss/Bs04/Animation/anm_bs04.controller` on `pf_bs04`: states `idle`, `anc_bs04_start` (5 s, no
loop). Only the entry clip is used (started by the EnemyData Animation event); `StopAnime(true)` at entry end. All other
motion is code-driven transforms (root, modelTop, wings, upperCore). No animator triggers are set by Ene_Bos04.

## 8. Address table
| method | RVA | constants taken |
|---|---|---|
| Ene_Bos04..cctor | 0x1D91090 | all statics (bos04-constants.json) |
| .ctor / Initialize / ReStart / GetStart | 0x1D91CE0 / 0x1D8C5F0 / 0x1D8FF90 / 0x1D7E4B0 | muzzle lookup, `_isForceFire`, field resets, OffCollision |
| StateExec / SetState / CheckNextState / CheckChangeToOpenWing | 0x1D90270 / 0x1D901D0 / 0x1D8BC40 / 0x1D8B590 | jump table 0x1D905D0, HalfHP/Passed90, 0.25 s |
| PatternEntryWait (dead copy) | 0x1D8CDF0 | — |
| PatternMove1 / Pattern1Move | 0x1D8D040 / 0x1D8CC90 | 0.45/0.55, −40, 80, InfinitySymbol(r,0,10), rapid 3/6 |
| PatternMove2 | 0x1D8D6C0 | +50 z, Euler(0,0,180), InfinitySymbol(·,20,2), 2 s, SE 241 |
| PatternMove3 | 0x1D8DE00 | −20 z offset, SE 93/94/95, 1 s, 0.5 s |
| PatternOpenWing | 0x1D8F6F0 | 0.3, 0.7, 0.85, 3 s, SE 96/97/212 |
| PatternMove5 / Update / FireMuzzle | 0x1D8E920 / 0x1D90830 / 0x1D90720 | 60/50, 0.9, rapid tables, SE 98 |
| infinityMoveLookPlayer / infinityMove | 0x1D921D0 / 0x1D92AA0 | −180 core offset |
| PatternMove6 / pat6fire / coreLongLaser / laser callback | 0x1D8EDF0 / 0x1D90DF0 / 0x1D91DC0 / 0x1D9F7A0 | 60/20, SE 99 |
| PatternMoveDestruction / ToDestroid | 0x1D8F1C0 / 0x1D90650 | −150 y, (20,45,0), 5.5/3.5/2.0, 0.2, SE 40/42 |
| UpdateWingRotation / GetWingRotate / GetDestroyWingCount | 0x1D90FD0 / 0x1D8C500 / 0x1D8C170 | — |
| setBodyHeadCollision / OnHitProgress | 0x1D92F20 / 0x1D8C980 | attr 0x60, friendlyFire |
| CheckGuardians / DestroyGuardians / Add/RemoveGuardian | 0x1D8B840 / 0x1D8BE20 / 0x1D8B3F0 / 0x1D90170 | — |
| GetSmallBombPosition / GetRouteNames / GetBossBT / GetBossCD / SubEnemys | 0x1D8C480 / 0x1D8C3F0 / 0x1D8C0D0 / 0x1D8C120 / 0x1D90600 | — |
| CallDisabled | 0x1D8B4D0 | stops roll SE |
| Ene_Bos04Bit ReStart / Setup / Fire / ToDestroid / .cctor | 0x1D8AFA0 / 0x1D8B0C0 / 0x1D8AEA0 / 0x1D8B190 / 0x1D8B290 | bos04bit0 |
| unused: coreShortLaser, Pattern1Fire, CheckFireAngle, CrossedAngle, GetRelativeAngle (init only), CalcTranslateRate | 0x1D91FF0, 0x1D8CB30, 0x1D8B5E0, 0x1D8BD40, 0x1D8C260, 0x1D8B4A0 | — |
| Ene_BosBase: ProgressBossTimer, LocalLateUpdate, IsOverAorB, UpdateHPState, ResetBossTimer, CallEnemyClip, CurrentTargetVector/Angle, IsCallSmallBomb, ToDestroid, _callDeadEffect | 0x1DBA1D0, 0x1DB9FF0, 0x1DB9FB0, 0x1DBAD20, 0x1DBA430, 0x1DB8F70, 0x1DB9630/0x1DB95C0, 0x1DB9E90, 0x1DBAC60, 0x1DBAEB0 | 10 s steps, 0.9/0.1 bombs |
| helpers: VectorUtility.InfinitySymbol / FreeFall / Sinf, EasingUtility.*, EnePartsGroup.ToSleep/Wakeup/ChangeCollisionsAttribute, EnemyCollisionModel.IsBulletHit, RandomUtility.Range | 0x1DF7690 / 0x1DF71B0 / 0x1DF8A70, 0x1DE8100.., 0x1D631E0/0x1D63240/0x1D61C30, 0x1D63590, 0x1DF1780 | — |
Static-class resolution: TypeInfo#48704 = UnityEngine.Vector3 (zeroVector), #43865 = Quaternion (identity), #45545 =
ShortCutEffect (+4 Small, +8 Middle), #41050 = LayerUtility (+0x20 EnemySkyLayer), #37303 = Ene_Bos04 statics.

## 9. Open questions
1. `mover._isFinishDelay` timing: set in `EnemyMover._execStackEvent` (0x1D6D319) when the stack finishes — assumed right after
   the 5 s entry clip; not measured.
2. `_startInGamePosition` assumed (0,0,25) (EnemyData position; entry moves only the modelTop child). Confirm with a recording.
3. Snap from (0,−80,30) at the end of OpenWing to (0,0,20)+… on the first PT5 frame (80 units in depth) — looks like a pop;
   check on the original whether it is hidden by the dark fade.
4. Exact meaning of virtual slots 0x2F8/0x318 (kill/return of touched enemies and guardians) and 0x588 (taken as
   `_callDeadEffect`); AddShake argument semantics.
5. Body vs head collision difference rests on `OnlyHitPlayer`; whether other enemies (Sg01 spawned at the boss) are actually
   killed by the body in PT2 depends on HybridCollision layer pairs not read here.
6. Sg01/bit internal behaviour (homing, routes LUT boss04sgL/R) is their own classes; not specified here.
