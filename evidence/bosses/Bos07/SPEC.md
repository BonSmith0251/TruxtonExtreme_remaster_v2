# Ene_Bos07 (BG06 boss) - behaviour specification from native code

Source: `D:\games\Truxton Extreme\GameAssembly.dll` (IL2CPP x64). Every method was disassembled with
`tools\bdis.py` (capstone; call targets named from `code\methods.jsonl`, .rdata floats and metadata-usage string
literals resolved). Full listings: `bos07_all.asm` (Ene_Bos07), `bos07_nested.asm` (nested types), `bosbase_all.asm`
(Ene_BosBase). Constants: `bos07-constants.json`. `[I]` = inference, `[?]` = unknown. Times are seconds.
Notes: Cpp2IL `Length` values are too short for several methods (switch tables lie past them). `bdis.py` takes each
method up to the next known method start. CRT helpers were identified by emulation (`tools\emu_math.py`):
0x578040 sinf, 0x576bf0 cosf, 0x578890 atan2f(y,x), 0x578460 acosf, 0x578740 floorf, 0x578cb0 fmodf [I], 0x5d2df0 Vector3.Magnitude.

## 1. Identity

| item | value |
|---|---|
| class | `InGame.Kernel.Enemy.Ene_Bos07 : Ene_BosBase : PawnEnemy` (nested: Boss07State, PartsKind, Boss07BT, Boss07MZ, LegArcs, LegPattern, DisplayClass125_0) |
| prefab | `Reconstructed\Assets\OriginalRecovered\Samples\Prefabs\Reference\Enemy\Pf_Ene_Bos07.prefab` (root Pf_Ene_Bos07, model top `pf_bs07`, Animator `anm_bs07.controller`) |
| EnemyData | BG06 definition `ene_boss07` (id 26c314fd...), model Pf_Ene_Bos07, position (0,0,32), attribute 1072, duration 100, placement moveSpeed 20, lookAt 1, no routes |
| definition events | Animation(9) `anc_bs07_start`; TaskWait(80) "Start" intValue1 16 awakeRate 1; FinishWait(1001) "Start" intValue1 1 |
| schedule | BG06 timeline clip `Boss06` starts at 427 s (duration 113); EnemyEntryClip `ene_boss07` starts at **429 s** (ends 540) |
| HP (enemy-database rows 61-65) | main body 1,000,000 (lock-on, rate target, score 100000); arm40, arm60, leg40, leg60 200,000 each (score 10000). facecover has no row |
| PartsList (index = PartsKind) | 0 MainBody (flags MasterBody, collision mainbody, damage object `body_upper/damage`); 1 leg40 (3 collisions, BreakEffect pf_eff_explposion05 at leg42); 2 leg60 (same, at leg62); 3 arm40 (pf_eff_explposion05); 4 arm60 (pf_eff_explposion05); 5 facecover (flags MasterBody, BreakEffect pf_eff_explposion02 at cover_rot_piv) |
| collisions | all `_attribute 0` (no NoLockOn, no LaserBlock); circles in `Resources\StageCombat\enemy-hitshapes.json` (model Pf_Ene_Bos07) |
| dead | `_deadExplosion pf_eff_explposion_boss`, `_overplayDeadSound 41` (exp_st3_boss_b02), `_explosionOffset 0` |
| lock-on | db isLockOn for body and all 4 parts; owner `_isLockonTarget 0`, `_isLaserBlock 0` |

Parts rules:
- ReStart (0x1DA5FC0) puts `EnemyCollisionAttribute.NoDamage` (16) on parts 3 and 4, so the **arms take no damage
  until PT7 ends**. PT7 clears it.
- AddDamageParts (0x1DA07E0): if the part is not broken, it calls base PawnEnemy.AddDamageParts. For legs it also
  adds `damage*0.01` (clamped to 0..1) to `_leg40DamagedPower` or `_leg60DamagedPower`. These values are never read,
  so they do nothing. It returns `damage` only if the part's `WithOwnerDamage` is set, else 0. A missing part returns
  `damage`.
- OnPartsBreak (0x1DA2A30): for parts 1 and 2 (legs) it calls `AddShake(0.5, 2, 10)`. The arms get no override.
  The break effect and sound come from `EnePartsGroup` (BreakEffect at `_explosionRoot`).

Invulnerable windows (InGameObjectFlag: OffCollision=1, OffLockon=2, NoDamaged=32; 0x22 = OffLockon|NoDamaged):

| window | flag |
|---|---|
| spawn → EntryWait 3.5 s | OffCollision (GetStart 0x1D7E4B0) |
| 3.5 s → end of EntryWait | OffLockon+NoDamaged |
| PT4 mode 0-1 (arm deploy, 1.2 s) | OffLockon+NoDamaged |
| PT5 whole (≈3.25 s) | OffLockon+NoDamaged |
| Destruction | StopBossTimer → `DisabledAllParts` |

## 2. Frames and units

Sky plane: x right, z up the screen, y toward the camera (camera at (0,400,0), 20° vertical FOV).
- The **root** (`_transformCache` at +0x50, the Pf_Ene_Bos07 transform) is what every pattern moves, through
  `localPosition`. `_startInGamePosition` is the root localPosition taken when the boss timer resets at the end of
  EntryWait. With the definition position this is (0,0,32) [I].
- `_modelTop` (pf_bs07) carries the entrance animation. At the end of the entrance it is set to local (0,0,0) with
  rotation Euler(0,180,0). Model-local coordinates are therefore mirrored in x and z relative to the sky: arms and
  legs at model x<0 sit at sky x>0, and model +z points down the screen toward the player.
- Arm, turret and leg vectors below are model-local, so they are applied to those child transforms as written.

## 3. State machine

`StateExec(dt)` (0x1DA65A0) runs every frame from Ene_BosBase.LocalLateUpdate, through vtable slot 0x688, after
`ProgressBossTimer`. At the start of each frame:
- If `IsArmBrokenOrDifficultyUp()`, the state becomes PT5 (mode 0, only if it is not PT5 already).
  `_isLegBroken` and `_isArmBroken` become true, and `_isLeftAttack` and `_isRightAttack` become false.
- Then the method dispatches on `_bos07state`.

Every SetState (0x1DA61B0) resets `_patternMode` to 0 and `mover._laserCancelFlag` to false. Entering PT3 also
stores the current leg-broken flags as `_prevLeft/RightLegBroken`.

Conditions (Ene_BosBase: `_hpState` is the first i with HP rate > {.9,.75,.51,.4,.3,.2,.1,0}[i]; `_currentActStep`
goes up by 1 every 10 s of boss time; IsOverHP(s) means `_hpState>=s`, IsOverStep(s) means `_currentActStep>=s`):

| predicate | true when |
|---|---|
| LegCond = IsLegBrokenOrDifficultyUp (0x1DA1F10) | `!_isLegBroken` and (both legs broken, or HP rate ≤ 0.51 (HalfHP 3), or boss time ≥ 90 s (Passed90 9)) |
| ArmCond = IsArmBrokenOrDifficultyUp (0x1DA1CF0) | `!_isArmBroken` and (both arms broken, or HP rate ≤ 0.30 (LowerHP 5), or boss time ≥ 150 s (Passed150 15)) |

CheckNextState (0x1DA0D30; PT2 and PT3 inline the same logic):
1. If the state is Destruction, do nothing.
2. If ArmCond: go to PT5 and set legBroken=armBroken=true.
3. Else, if `!_isLegBroken` and LegCond: go to PT7 and set legBroken=true.
4. Else follow the table:

| from | to |
|---|---|
| EntryWait | PT2 |
| PT2 | PT3 |
| PT3 | PT2 |
| PT4 | PT4 |
| PT5 | PT6 |
| PT6 | EntryWait (never used: PT6 does not call it) |
| PT7 | PT4 |

PT2 and PT3 also check LegCond at the start of every frame and jump to PT7 at once.

Resulting flow: **EntryWait → (PT2 ⇄ PT3) → PT7 → PT4 (loops) → PT5 → PT6 (loops) → Destruction**.
ArmCond can jump straight to PT5 from any state.

### EntryWait (0x1DA59A0)

| mode | action |
|---|---|
| 0 | PlayQue(85 bg7_boss_app_01); `_localTime=0`; go to mode 1 |
| 1 | `_localTime+=dt`. When `_localTime ≥ 3.5` (`_EntryNoHitTime`): ResetObjectFlag(OffCollision), SetObjectFlag(0x22); go to mode 2 |
| 2 | Wait until `mover._isFinishDelay` (EnemyMover +0x2B8; set when the definition's FinishWait "Start" completes [I]). Then `mover.StopAnime(true)`; modelTop.SetLocalPositionAndRotation((0,0,0), Euler(0,180,0)); SetDirectionTime(0.5); `_localTime=1`; go to mode 3 |
| 3 | While the direction rate is < 1 and the player is **not** in the centre band (`|player.x|<100` is "centre"): FaceCoverRotate(dt × (player left of x=0 ? +480 : −480) °/s). `_localTime-=dt`; when ≤ 0: PlayQue(86 bg7_boss_open_arm_01), ResetObjectFlag(0x22), ResetBossTimer(true) (starts the boss clock and stores `_startInGamePosition`), then CheckNextState → PT2 |

Entrance clip `anc_bs07_start` (5 s, drives pf_bs07; FaceCoverRotate turns `cover_rot_piv` about its local z):

| key | localPosition | localEuler |
|---|---|---|
| 0 s | (−90, 300, 0) | (0, 90, 90) |
| 2.667 s | (0, −60, 0) | (0, 160, 0) |
| 4.167 s | (0, 20, 0) | (0, 180, 0) |
| 5 s | (0, 0, 0) | (0, 180, 0) |

The fight starts about 1 s after the clip ends, so the boss clock starts near 435 s [I].

### PT2: leg homing shots (0x1DA2A70)

| mode | action |
|---|---|
| (every frame) | if LegCond → PT7. `_localTime-=dt` |
| 0 | SetupLegPattern(B,B); SetDirectionTime(1.0); `_attackCount=0`; `_localTime=0`; `_lastLocalPosition`=root.localPosition; go to mode 1 |
| 1 | r=rate; ProgressLegPattern(r); root.localPosition = Lerp(_last, _start, InOutSine01(r)). When r ≥ 1: SetRepeatTime(0.2); `_localTime=6`; `_last=_start`; go to mode 10 |
| 10 | HomingLeg(dt). If `_localTime<5` and `_attackCount<15` and the repeat timer lapped: BCFire(legs=true, sub=false) and `_attackCount++`. When `_localTime≤0`: CheckNextState (→PT3). Every frame: BCMove(InOutQuad01(clamp01(_localTime/6)), (0,0,0)) |

Window: 6 s. Shots start 1 s in, 15 volleys every 0.2 s, ending about 4 s in. During the window the root runs one
full BCMove loop in reverse (rate 1→0).

### PT3: leg lunge × 4 (0x1DA3140)

Per frame:
- `leftJust = Leg40 broken && !_prevLeft`; `rightJust` likewise; then update `_prev*`.
- `cancelable = (mode==14 && rate<0.6) || mode==12 || mode==13`.
- If ((leftJust && `_isLeftAttack`) or (rightJust && `_isRightAttack`)) and cancelable and mode≠30:
  `_lungeRateLast=_lungeRate`; SetupLegPattern(C,C); SetDirectionTime(1.5); go to mode 30.

| mode | duration | action |
|---|---|---|
| 0 | - | `_attackCount=0`; `_lungeRate=_lungeRateLast=0`; continues into mode 10 |
| 10 | 0 | `_isLeftAttack = fmod(count,2)==0`, `_isRightAttack = fmod(count,2)==1`. If the chosen leg is broken, use the other leg (if the other leg is not broken). SetupLegPattern(C,C); SetDirectionTime(1.5); go to mode 11 |
| 11 | 1.5 | e=InOutQuad01(rate); `_lungeRate = Lerp(last, 0, InOutSine01(e))`; ProgressLegPattern(e). When e ≥ 1: SetupLegPattern(C_WindUp,C_WindUp); SetDirectionTime(1.8); `last=_lungeRate`; go to mode 12 |
| 12 | 1.8 | e=OutCubic01(rate); `_lungeRate = Lerp(last, −0.6, InOutSine01(e))`; ProgressLegPattern(e). When e ≥ 1: SetDirectionTime(0.2); `last=_lungeRate`; go to mode 13 |
| 13 | 0.2 | When rate ≥ 1: left attack → SetupLegPattern(C_Throw1, C_Throw2) and PlayQue(87 bg7_boss_close_arm_01); right attack → SetupLegPattern(C_Throw2, C_Throw1) and PlayQue(237 bg7_boss_close_arm_02). SetDirectionTime(0.8); `_batteryFireTime=0`; go to mode 14 |
| 14 | 0.8 | a=_lungeArmCurve(r); `_lungeRate = Lerp(last, 1, _lungeBodyCurve(r))`; ProgressLegPatternSeparately(a,a,a). When r ≥ 1: SetDirectionTime(0.2); `last=_lungeRate`; go to mode 15. LegOrBatteryFire(dt) every frame |
| 15 | 0.2 | LegOrBatteryFire(dt); when rate ≥ 1 go to mode 20 |
| 20 | - | `_attackCount++`; if < 4 go to mode 10, else CheckNextState (→PT2) |
| 30 | 1.5 | e=InOutSine01(rate); `_lungeRate = Lerp(last, 0, clamp01(e))`; ProgressLegPattern(e). When rate ≥ 1: `_lungeRate=_lungeRateLast=0`; go to mode 20 |

End of every frame: root.localPosition = `_start + (0,0,−50) × _lungeRate`. The wind-up rate −0.6 puts the boss
30 up the screen; the throw at rate 1 puts it 50 down.

One attack lasts 4.5 s, so a full PT3 cycle is 18 s. Order: left, right, left, right (skipping a broken leg).

Curves from the prefab (Hermite keys, time:value/slope):
- `_lungeBodyCurve`: 0:0 (s 4.258, outW 0.097), 0.3831:0.8194 (s 0.721), 1:1 (s 0).
- `_lungeArmCurve`: 0:0 (s 0), 0.6162:0.8868 (s 0.922), 1:1 (s 0).

### PT7: leg break transition (0x1DA5100)

- Mode 0: every leg part that is not yet broken gets `BreakParts(isGround=false, withEffect=true, withSound=true, dv=0)`.
  `_last`=root.localPosition; SetDirectionTime(2); go to mode 1.
- Mode 1: root = Lerp(_last, _start, InOutSine01(rate)). When rate ≥ 1: remove NoDamage from parts 3 and 4 (the arms
  become damageable); CheckNextState → PT4.

### PT4: arms out, circuit (0x1DA3D30)

Every frame: if ArmCond → PT5. FaceCoverRotate(dt × 360 × `_faceCoverSpeed`), in degrees about the cover's local z;
the speed is in turns per second.

| mode | duration | action |
|---|---|---|
| 0 | - | SetObjectFlag(0x22); PlayQue(88 bg7_boss_unit_rotation_01); SetDirectionTime(1.2); `_last`=root pos; `_faceCoverSpeed=0`; go to mode 1 |
| 1 | 1.2 | e=clamp01(InCubic01(r)); arm40.localPosition = Lerp((−25,0,−16), (−25,0,16), e); arm60.localPosition = Lerp((25,0,−16), (25,0,16), e); `_faceCoverSpeed=r`; root = Lerp(_last, _start, InOutSine01(r)). When r ≥ 1: ResetObjectFlag(0x22); SetRepeatTime(2); SetDirectionTime(3); `_circuitTime=_circuitEaseRate=0`; go to mode 10 |
| 10 | 3 | UpdateMoveTime(dt, 8). On repeat lap (at 2 s): BCFire(false, true). When rate ≥ 1: SetDirectionTime(2); `_batteryFireTime=0`; go to mode 11. `speed += (0.5−speed)×0.1` per frame |
| 11 | 2 | UpdateMoveTime(dt, 8); LegOrBatteryFire(dt). When rate ≥ 1: SetRepeatTime(0.1); `_attackCount=0`; go to mode 12. `speed += (0.5−speed)×0.1` |
| 12 | 1.5 | UpdateMoveTime(dt, 8). On each 0.1 s lap: fire `bos07face` from cover_muzzle_{1,2,3}[count mod 3] and `count++`. After 15 shots: SetRepeatTime(2); SetDirectionTime(3); go to mode 10. `speed += (2−speed)×0.5` per frame |

UpdateMoveTime(dt, P) (0x1DA6F60): `_circuitEaseRate = clamp01(+dt)`;
`_circuitTime = Repeat(_circuitTime + _circuitEaseRate×dt, P)`; BCMove(_circuitTime/P, 0). The result is one loop
every 8 s, eased in over 1 s.

The PT4 cycle is 6.5 s: one armh volley, the leg or battery bursts, then 15 face shots. `_isLegBroken` is always true
here, so BCFire's sub attack is armh.

### PT5: everything breaks (0x1DA4650)

| mode | duration | action |
|---|---|---|
| 0 | - | SetObjectFlag(0x22); BreakParts(false, true, true, 0) on parts 1-5 (both legs, both arms, face cover); PlayQue(89 bg7_boss_unit_exp_01); PlayQue(212 boss_parts_destruction_g_01); `_last`=root pos; SetDirectionTime(1.25); go to mode 10 |
| 10 | 1.25 | root = Lerp(_last, _start+(0,0,−20), InOutSine01(r)). When r ≥ 1: PlayQue(90 bg7_boss_main_gun_cocking_01); SetDirectionTime(2); go to mode 20 |
| 20 | 2 | While r < 1: turretPivot (`body_upper_pivot`).localPosition = Lerp((0,−9,−8), (0,0,−15), clamp01(EaseOutBounce01(2r))). At r ≥ 1: snap to (0,0,−15); ResetObjectFlag(0x22); CheckNextState → PT6 |

### PT6: main gun (0x1DA4BE0)

A tail runs after every mode each frame (HomingBody):
`_homingTime = clamp(+dt, 0, _homingDuration)`;
turretPivot.localRotation = Euler(0, LerpAngle(_homingStart, _homingTarget, InOutQuad01(_homingTime/_homingDuration)), 0).

| mode | duration | action |
|---|---|---|
| 0 | - | go to mode 10 |
| 10 | - | SetDirectionTime(10); SetRepeatTime(2); AddRepeatTime(2), which forces an immediate lap; `_attackCount=0`; `_localTime=0`; go to mode 11 |
| 11 | 10 | On each lap while `_attackCount<5`: `count++`; BulletDirFireAsync(bos07laser, from muzzle_body_upper_02 toward muzzle_body_upper_02_target); PlayQue(192 bg7_boss_main_gun_cocking_02); SetHomingAngle(true, 0.8). This gives 5 lasers at t=0,2,4,6,8. When rate ≥ 1: SetDirectionTime(1); SetRepeatTime(0.2); `_circuitTime=0`; SetHomingAngle(false, 0.8) (turret back to yaw 0); go to mode 12 |
| 12 | 1 | On each 0.2 s lap: BulletFireByMuzzlePack(bos07leg, isSelfDir=true, isNest=true, pack `body4`); PlayQue(192). UpdateCircuitMove. When rate ≥ 1: SetDirectionTime(2); SetRepeatTime(1); `_batteryFireTime=0`; go to mode 13 |
| 13 | 2 | On each 1 s lap: BCFire(false, true) (armh ±60). LegOrBatteryFire(dt): both legs are broken, so this is the battery 3-ways. UpdateCircuitMove. When rate ≥ 1: SetDirectionTime(6); SetRepeatTime(1); go to mode 14 |
| 14 | ≈1 | When UpdateCircuitMove returns true, go to mode 10 |

UpdateCircuitMove (0x1DA7490): `_circuitTime+=dt`; t=clamp01(_circuitTime/4); BCMove(InOutSine01(t), (0,0,−20)).
It returns t ≥ 1, so modes 12-14 together take 4 s. The PT6 cycle is 14 s and PT6 never exits by itself.

SetHomingAngle(isTarget, dur) (0x1DA7130):
- Target: 0 if `!isTarget`. Otherwise, using the turret's parent P:
  `GetTargetBulletArc(P.InverseTransformPoint(gm.GetSkyRootPosition(_mainBody.position)), P.InverseTransformPoint(_baseTargetPlayer))`,
  which is `atan2(d.x, d.z)` in degrees for d = body − player. This uses the same arc convention as
  BulletDirFireAsync, which takes the arc of muzzle − target, so the laser line is aimed at the player [I].
- Start = the turret's current localEuler.y (made positive). Sets `_homingDuration=dur` and `_homingTime=0`.
- If the InGameManager is null, nothing changes.

### Destruction (state 100)

Entry, through Ene_Bos07.ToDestroid (0x1DA6710):
- If trophy mode is on: SetTrophy(6).
- StopBossTimer: DisabledAllParts, AddDiPoint_BossDestroy, SetBossTime, PlayQue(177 boss_defeat01_01).
- mover.DeleteRouteToken; ReleaseToken; state=Destruction with mode 0.

PatternMoveDestruction (0x1DA53C0):

| mode | action |
|---|---|
| 0 | `_startVector=_targetVector`=root.localPosition, then `_targetVector.y −= 150`; `_startAngle`=root.localRotation; `_targetAngle`=Euler(20,45,0). SkyExplosionEffect(ExplosionCodeMiddle, GetSmallBombPosition(), layer, no SE). AddShake(0.5,1,2). SetSmallBombSecond(0.2). SetDirectionTime(5.5). `mover._laserCancelFlag=true`. `_localTime=3.5`. Go to mode 10 |
| 10 | root.localPosition = Lerp(start, target, EaseIn(rate)=rate²); root.localRotation = Quaternion.Lerp(startAngle, targetAngle, rate). `_localTime-=dt`; when ≤ 0: AddShake(0.5,1,5), `_callDeadEffect()` (vtable 0x588 [I]: ShakeCamera(1,3,1), VibrationPlayer(0.5,0.8,2), dead explosion `pf_eff_explposion_boss` + SE 41), `_localTime=2`, go to mode 11. Small bombs: IsCallSmallBomb(dt) → SkyExplosionEffect(ExplosionCodeSmall, GetSmallBombPosition(), layer, SE 40) and AddShake(0.5,1,5) |
| 11 | Same motion and small bombs, without the shake. When `_localTime ≤ 0`: go to mode 30 |
| 30 | PlayQue(42 exp_st3_boss_c03); Ene_BosBase.ToDestroid() (VibrationPlayer(0.8,1,2), `_isBossDead`, PawnEnemy.ToDestroid) |

Small-bomb cadence (Ene_BosBase.IsCallSmallBomb 0x1DB9E90): the countdown drops by dt; at 0 it is reset to
`base + Random01×0.1`, then `base ×= 0.9` (base starts at 0.2), and the player vibrates (0.4, 0.1, base).

GetSmallBombPosition (0x1DA1200): muzzles[{0,1,2,3,8,12,13,14,15,16,17}[Range(1,11)−1]].position. Range is inclusive.

## 4. Movement primitives

- **BCMove(rate, off)** (0x1DA0BF0): root.localPosition = `_start + off + (30·sin(2π·rate)·(rev?−1:1), 0, 5·cos(2π·rate) − 5)`.
  `_isReverseMove` is never written, so it is false. The path is an ellipse 60 wide and 10 deep below the start
  (z from 0 to −10), passing through the start point.
- **SetupLegPattern(L,R)** (0x1DA6240): `_isLeftMove = L≠None`, `_isRightMove = R≠None`. For each joint i of 0..2
  (leg40/leg41/leg42 and leg60/leg61/leg62): start[i] = current localRotation. Leg40 end[i] = Euler(0, +arc[L][i], 0);
  leg60 end[i] = Euler(0, −arc[R][i], 0).
- **LegArcs** (thigh, knee, toe in degrees):

  | pattern | arcs |
  |---|---|
  | A | −45, 135, 45 (unused) |
  | B | 10, 20, 30 |
  | C | 10, 20, 30 |
  | C_WindUp | −10, 20, 30 |
  | C_Throw1 | 60, 60, 60 |
  | C_Throw2 | −20, 20, 30 |
  | Reach | 45, 45, 0 (unused) |
  | Reach2 | 45, 45, 45 (unused) |

  Prefab rest yaws: leg40 45/135/−45, leg60 −45/−135/45.
- **ProgressLegPattern(r)**: per-joint rates (InSine01(r), r, OutQuart01(r)).
  **ProgressLegPatternSeparately(r0,r1,r2)**: joint i = Slerp(start[i], end[i], r_i) for each moving leg. When
  r0 ≥ 1 the leg damaged powers reset to 0.
- **HomingLeg(dt)** (0x1DA1560, calc 0x1DA6850, GetTangentPoints 0x1DA12E0):
  - Player = GetPlayerSkyPosition(nearest player to the boss's screen position), with y=0.
  - For each leg that is not broken: A = legs[2] (toe), B = legs[1] (knee). a = sky-root position of A (y=0).
    - Tangent points on a circle of radius 20 around a: d=|p−a|; if d ≤ 20 do nothing for this leg.
      Otherwise θ=acos(20/d), u=(p−a)/d, c1 = a + 20·Rot(u,+θ), c2 = a + 20·Rot(u,−θ), where
      Rot(v,θ) = (cosθ·v.x − sinθ·v.z, 0, sinθ·v.x + cosθ·v.z).
    - Choose c1. Let α = wrap180(atan2(u)−atan2(c1−a)). If (α>0) ≠ flag, use c2 instead. flag is true for leg40
      and false for leg60.
    - Yaw = wrap180(atan2(cDir) − atan2(normalize(a − skyRoot(B)))), clamped to [0,60] for leg40 or [−60,0] for leg60.
    - A.localRotation = Slerp(A.localRotation, Euler(0, yaw, 0), clamp01(dt / (1/6))).
  - [I] The toe turns so that a muzzle 20 units out lies on the tangent line to the player.

## 5. Attacks

Templates: `Resources\StageCombat\enemy-attacks.json`, from the `btNames` order. Muzzle packs are `EnemyMover._muzzlePacks`.

| call | template (bullet prefab) | muzzles | notes |
|---|---|---|---|
| BCFire legs (PT2) | bos07leg (enemybullet004, selfDir) | packs leg40 = leg42/muzzle_body_leg42_2..4, leg60 = leg62/muzzle_body_leg62_2..4; isSelfDir=true, isNest=true | 15 volleys every 0.2 s |
| BCFire sub, legs intact | bos07leg2 (enemybullet001, 2-rapid, targeted) | pack legsub = leg42_1, leg62_1, muzzle_body_leg40, muzzle_body_leg60; selfDir=false | never reached in practice: PT4/PT6 always have `_isLegBroken` [I] |
| BCFire sub, legs broken | bos07armh (enemybullet010, 10 rapid, random ±60) | muzzle_body_under_1 with offsetAngle +60 and muzzle_body_under_3 with −60 (BulletFireAsync) | PT4 mode 10, PT6 mode 13 |
| LegOrBatteryFire, side not attacking, leg intact | t=0.5: bos07leg1way (enemybullet005, 8 rapid, targeted); t=1.0: bos07leg2way (8 rapid, targeted) | left: muzzle_body_leg40 / muzzle_body_leg42_1; right: muzzle_body_leg60 / muzzle_body_leg62_1 | t counted from `_batteryFireTime=0`; fires when t crosses each threshold |
| LegOrBatteryFire, leg broken | bos07body3way (enemybullet002, targeted) at t=0.5, 0.75, 1.0 | left: battery07, 04, 01; right: battery09, 06, 03 | |
| PT4 face | bos07face (enemybullet006) | cover_muzzle_1,2,3 in turn | 15 shots at 0.1 s |
| PT6 laser | bos07laser (enemylaser003: charge 1.0, width 30, collision width 4, dissolve 0.5, nIrradiation 0.5) | BulletDirFireAsync(muzzle_body_upper_02 → muzzle_body_upper_02_target) | 5 lasers, 2 s apart, turret homes 0.8 s |
| PT6 body4 | bos07leg | pack body4 = body_under/muzzle_body_under_71, 72, 91, 92; selfDir, nest | 5 volleys at 0.2 s |

Muzzle paths are under `Pf_Ene_Bos07/pf_bs07/me_bs07/`: legs under `leg40|leg60`; upper muzzles and cover under
`body_upper_pivot/body_upper`; batteries at `body_upper/pos_body_batteryNN/pf_bs0x_body_battery/bs0x_body_battery_muzzle`.

Unused in the code: Boss07BT bodyShotCenter (bos07body), bodyShotSide (bos07bodyS), pack body6, IsFireOK, and the
statics `_arm*SlidePos`, `_arm*FallPos`, `_armFallRot`, `_LtoR`, `_RtoL`. There are no summons.

## 6. Part-break consequences

| event | effect |
|---|---|
| one leg broken during PT3 | If it was the attacking leg in the wind-up, hold or early swing, the attack is cancelled (mode 30). Later attacks use the other leg. That side's LegOrBatteryFire switches to the battery 3-ways |
| both legs broken / HP ≤ 0.51 / 90 s | PT7 breaks any remaining leg and the arms become damageable, then PT4 |
| both arms broken / HP ≤ 0.30 / 150 s | PT5 breaks every remaining part (legs, arms, face cover), the turret drops back, then PT6 |
| leg break | AddShake(0.5, 2, 10) |

## 7. Animator

- `anm_bs07` has two states: `idle` (no motion) and `anc_bs07_start`. The entrance clip is played by the definition
  Animation event and stopped by `mover.StopAnime(true)` in EntryWait mode 2.
- No triggers are set by Ene_Bos07. Everything else is procedural: root position, joint yaws, arm local positions,
  turret pivot position and yaw, and the face-cover spin.
- `anm_bs07_move_null.controller` also exists [?].

## 8. Address table

| method | RVA | constants used |
|---|---|---|
| .cctor | 0x1DA7580 | all statics, LegArcs, btNames (see JSON) |
| .ctor | 0x1DA7F10 | MuzzleCount = |Boss07MZ| = 18; `_lastLocalPosition` = 0 |
| Initialize | 0x1DA1850 | mover._isForceFire=true; muzzle table; `_legCount = _legs40.Length` (3) |
| ReStart | 0x1DA5FC0 | state 0; arms NoDamage (16) set |
| GetStart | 0x1D7E4B0 | OffCollision |
| StateExec | 0x1DA65A0 | dispatch, ArmCond override |
| CheckNextState | 0x1DA0D30 | HalfHP 3, Passed90 9 |
| SetState / SetLegBroken / SetArmBroken | 0x1DA61B0 / 0x1DA6160 / 0x1DA6100 | |
| Is* helpers | 0x1DA1F10 Leg, 0x1DA1CF0 Arm (LowerHP 5, Passed150 15), 0x1DA1EE0, 0x1DA1FA0, 0x1DA1E40, 0x1DA1DE0, 0x1DA1D80, 0x1DA1EA0 | |
| PatternMoveEntryWait | 0x1DA59A0 | 3.5, 0.5, 1, ±480, SE 85/86 |
| PatternMove2 | 0x1DA2A70 | 1, 0.2, 6, 15 |
| HomingLeg / calc / GetTangentPoints / Rotate | 0x1DA1560 / 0x1DA6850 / 0x1DA12E0 / 0x1DA67D0 | radius 20, homing 1/6, clamp ±60 |
| PatternMove3 | 0x1DA3140 | 1.5, 1.8, 0.2, 0.8, 0.2, −0.6, 0.6, 4 attacks, LungeVector |
| LegOrBatteryFire | 0x1DA1FD0 | 0.5, 1.0, 0.5, 0.75, 1.0 |
| PatternMove4 / UpdateMoveTime | 0x1DA3D30 / 0x1DA6F60 | 1.2, 8, 3, 2, 2, 0.1, 15, 0.5, 2, 0.1, 0.5 |
| PatternMove5 | 0x1DA4650 | 1.25, 2, mode6Position, mainBodyHome/Back |
| PatternMove6 / UpdateCircuitMove / SetHomingAngle / HomingBody | 0x1DA4BE0 / 0x1DA7490 / 0x1DA7130 / 0x1DA7060 | 10, 2, 5, 1, 0.2, 2, 1, 6, 4, 0.8 |
| PatternMove7 | 0x1DA5100 | 2 |
| PatternMoveDestruction | 0x1DA53C0 | −150, Euler(20,45,0), 5.5, 3.5, 2, 0.2, SE 40/42 |
| ToDestroid | 0x1DA6710 | trophy 6 |
| BCFire / BCMove | 0x1DA0910 / 0x1DA0BF0 | ±60; 30, 5 |
| FaceCoverRotate | 0x1DA0FA0 | localRot × Euler(0,0,deg) |
| SetupLegPattern / ProgressLegPattern / Separately | 0x1DA6240 / 0x1DA5F60 / 0x1DA5C80 | |
| AddDamageParts / OnPartsBreak | 0x1DA07E0 / 0x1DA2A30 | 0.01; shake 0.5, 2, 10 |
| GetSmallBombPosition / GetMuzzle / GetBossBT | 0x1DA1200 / 0x1DA11D0 / 0x1DA1180 | |
| LegArcs .ctor / Get | 0x1DB7900 / 0x1DB78E0 | |
| Ene_BosBase: LocalLateUpdate, ProgressBossTimer, ResetBossTimer, IsOverHP, IsOverStep, SetDirectionTime, GetDirectionRate, SetRepeatTime, AddRepeatTime, UpdateHPState, CurrentTargetVector, CurrentTargetAngle, IsCallSmallBomb, SetSmallBombSecond, SkyExplosionEffect, ToDestroid, StopBossTimer, _callDeadEffect, GetBT | 0x1DB9FF0, 0x1DBA1D0, 0x1DBA430, 0x1DB9FD0, 0x1DB9FE0, 0x1DBA4D0, 0x1DB9A20, 0x1DBA580, 0x1DB8EC0, 0x1DBAD20, 0x1DB9630, 0x1DB95C0, 0x1DB9E90, 0x1DBA5A0, 0x1DBA5C0, 0x1DBAC60, 0x1DBA790, 0x1DBAEB0, 0x1DB9840 | player sides: left x<0, centre −100<x<100, down z<0, bottom z<−20 |
| InGameBulletManager.GetTargetBulletArc | 0x1CCB620 | atan2(a−b) |
| RandomUtility.Range(int,int) | 0x1DF1780 | inclusive |

## 9. Open questions

1. EnemyMover +0x2B8 `_isFinishDelay`: exactly when it turns true, and so when EntryWait mode 2 ends (assumed: when
   the 5 s entrance clip and FinishWait "Start" complete) [?]. The pioneer should record the first PT2 frame.
2. `_startInGamePosition` is assumed to be the definition position (0,0,32) in sky units. The root's parent and
   rotation (placement lookAt 1) are not verified [?]. This also fixes the sign of the PT6 turret yaw, which is only
   inferred to aim at the player.
3. The small-bomb array is the only matching 44-byte blob in InGame.Kernel. The FieldRef #14 → field mapping was not
   decoded [I].
4. vtable slot 0x588 is taken to be `_callDeadEffect`, by counting slots and from PawnEnemy.ToDestroid [I].
5. The battle time limit (GetBattileTime: a static in TypeInfo #47822) and its time-up behaviour: TimeupAction is a
   no-op for this boss [?].
6. The 0x578cb0 fmodf identification is by context (emulation needs TLS) [I].
7. The EnePartsGroup.BreakParts internals (effects, sound, hide) and the base PawnEnemy.AddDamageParts break trigger
   were not re-read here.
8. LegOrBatteryFire's 1.0 s threshold in PT3 is reached exactly at the end of mode 15 (0.8 + 0.2 s), so whether the
   last shot fires depends on frame timing [I].
