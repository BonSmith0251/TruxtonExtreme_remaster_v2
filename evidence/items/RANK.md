# RANK — dynamic rank "DiPoint" (TATSUJIN EXTREME, native study)

Read-only study of GameAssembly.dll (IL2CPP). RVAs are image-relative. Field offsets from
`code/type-model-source/DiffableCs`. Values from `Reconstructed/Assets/OriginalGame/InGame/InGameReference/Resident/PointTables/*.asset`.
"[unconfirmed]" = not proven by code/data read here.

## 0. State (InGame.Kernel.InGameManager)

| field | off | meaning |
|---|---|---|
| `_gameAddPoints` | 0x290 | GameAddPoints table in use |
| `_DiPoint` | 0x298 | the rank value (float) |
| `_perSeconds` 0x29C, `_perDestroy` 0x2A0, `_perBomber` 0x2A4, `_perBStock` 0x2A8, `_perPowup` 0x2AC, `_perBoss` 0x2B0, `_perDead` 0x2B4 | | per-event increments copied from the table |
| `_DiMin` / `_DiMax` | 0x2B8 / 0x2BC | current clamp |
| `_eventRepeatScale` | 0x64 | cached GetEventRepeatScale(DiPoint) |

All adds are `DiPoint = clamp(DiPoint + delta, _DiMin, _DiMax)` (min tested first).

GameAddPoints (ScriptableObject): `targetPlayMode` 0x18, `targetActor` 0x1C, `_ClampBase` Vector2[] 0x20, `StartPoint` 0x28,
`ASecondAdd` 0x2C, `APowerupAdd` 0x30, `ABomberedAdd` 0x34, `ABomberStockAdd` 0x38, `AEnemyDestroyAdd` 0x3C,
`ABossDestroyAdd` 0x40, `APlayerDeadAdd` 0x44, `RoundPerUpMin` 0x48, `RoundPerUpMax` 0x4C.

### Tables

| asset | mode/actor | StartPoint | /s | powerup | bomb use | bomb stock | enemy | boss | death | RoundPerUp min/max | _ClampBase |
|---|---|---|---|---|---|---|---|---|---|---|---|
| ArcadeAddPoints | 2 / -1 | 0 | 0.033333335 | 0.1 | -1 | 0.1 | 0.01 | 5 | -2.5 | 100 / 100 | (-10,30) (0,40) (10,50) (20,60) (30,70) (40,80) (50,90) (60,100) |
| StoryAPoints | 1 / 0 | -200 | 0.016666668 | 0.01 | -2 | 0.01 | 0 | 0 | -5 | 0/0 | x = -400,-390..-330 step 10, y = 0 |
| StoryBPoints | 1 / 1 | -150 | same | | | | | | | 0/0 | x = -300..-230, y = 0 |
| StoryCPoints | 1 / 2 | -100 | same | | | | | | | 0/0 | x = -200..-130, y = 0 |
| RushPoints | 11 / -1 | 50 | 0 all | | | | | | | 0/0 | (0,1000) |
| TutorialAddPoints | 100 / -1 | -500 | 0 all | | | | | | | 0/0 | (-1000,0) |

## 1. Setup / reset

`SetupDiPointFactor(table, nstage, nround=0, spoint=0)` 0x1CEBC60:
```
_gameAddPoints = table; if table == null: return
DiPoint = (spoint > 0) ? spoint : table.StartPoint        // note: spoint <= 0 falls back to StartPoint
copy ASecondAdd..APlayerDeadAdd into _per*
c = table.GetClamp(nstage)                                 // 0x2720B20: index clamped to [0, len-1], <0 -> 0
_DiMin = clamp(c.x + nround*RoundPerUpMin, -1000, 999)     // rdata 0x35F2BCC = -1000, 0x35F2BFC = 999
_DiMax = clamp(c.y + nround*RoundPerUpMax, -1000, 999)
DiPoint = clamp(DiPoint, _DiMin, _DiMax)
```
`UpdateDiPointStage(nstage, nround)` 0x1CED330: same min/max recompute + clamp of the CURRENT DiPoint (no reset).
`ClearDiPointFactor` 0x1CE2CD0: table = null, all `_per*` = 0. DiPoint, _DiMin, _DiMax are NOT touched.

Callers:
- Arcade `ArcadePlayPresenter/<_Initialize>d__2` call 0x2221C38. Default nstage = 0, nround = 0, spoint = 0. If a presenter
  Value is passed: nstage = Value._startStage (0x10), nround = Value._startRound (0x14). If Value._cdata (CarriedData) != null:
  nstage = 0, nround = cdata._startRound (0x28), spoint = cdata._startDiPoint (0x30).
- Other modes: Training 0x21CDA5B, HeartStarter 0x21E24F4, Team 0x21E2B83, Arena 0x222059E, Story 0x2220E14 (args not traced).
- Next stage: `ArcadePlayModel/<RequestNextStage>d__2` 0x221CC78 → `UpdateDiPointStage(_stageIndex, _stageRound)`, only when the
  stage was cleared and `IsNextByClear` returned true.
- `ClearDiPointFactor`: `ModelGamePlayBase/<FinishInGameStage>d__21` 0x21C6D3B when `withNext == false` (session end);
  Training `RequestNextStage` lambda 0x21CB95F.

Stage/round progression (`ModelGamePlayBase.IsNextByClear` 0x21C0920): `_stageIndex++`; if `>= _stageCounts`: `_stageIndex = 0`
and, only if round-loop/infinity (`+0x13`, from Value._isInfinityMode), `_stageRound = clamp(_stageRound+1, 0, RoundMax=99)`
(TXEPlayMode.cctor 0x2716EE5) and return true; otherwise return false (game ends).
Round-loop carry (`stageFinisher` MoveNext 0x221D650): when isNext and `_stageIndex == 0`: `_isRoundLoopStart = true`, new CarriedData
{pinfo copy, pdata copy, drops, `_startRound = _stageRound`, `_clearCount = _clearStageCount`, `_startDiPoint = DiPoint` (0x221D814)}.
`ArcadePlayPresenter.CheckQuit` 0x2212BE0 then pushes a new ArcadePlayPresenter Value(stage, clamp(round,0,99), infinity=1,
shutter=1, cdata) → re-init calls SetupDiPointFactor(table, 0, startRound, startDiPoint). [which arcade entries start with infinity on: unconfirmed]

Reset rules (all DiPoint writers found by a full scan for `[reg+0x298]` stores; only InGameManager methods above write it):
- Game start: StartPoint (arcade 0) clamped to stage clamp → 0 at stage 1; stage s start → max(0, ClampBase[s].x) (e.g. s=3 → 10).
- Stage change: NOT reset; only re-clamped to the new stage's [min,max].
- Death: no reset, just −2.5 (APlayerDeadAdd). Restart/continue code (`RestartGame` 0x1CEA500, `<RestartGame>d__414` 0x1D297D0,
  `_restartGameFast` 0x1D2FD20, `SetupStageParameter` 0x1CEC2E0) does not touch DiPoint → persists across continues.
- New round loop: carried DiPoint (if > 0) re-clamped to round r: [ClampBase[0].x+100r, ClampBase[0].y+100r] = [90,130] for r=1.

Arcade clamp (stage s = 0..7, round r = 0..99): `min = clamp(-10+10s+100r, -1000, 999)`, `max = clamp(30+10s+100r, -1000, 999)`.

## 2. Increments (callers, conditions)

| method | RVA | delta (arcade) | caller / condition |
|---|---|---|---|
| time (inlined copy of AddDiPoint_Timepass 0x1CE2290) | `InGameManager.Update` 0x1CEE2AC | +0.033333335 × dt | every Update while `!_isUpdateDisable`(0x300) && `!_isStopStage`(0x50); dt = `_playTimeFactor.DeltaTime` (TimeFactor+0x18, scaled game time; 0 while play rate 0, e.g. death phase sets SetPlayTimeRate(0)). No phase check. ≈ +2 per minute |
| AddDiPoint_Powerup | 0x1CE2250 | +0.1 | `ItemEffects.ItemEffectResult` 0x1D7005A, Kind 2 PowerUp only, when `PowerUpWeapon()` returns 2 = the power LEVEL actually rose (every 3rd P item; not for sub-steps/max/5000 bonus). Arm items (100-106) never |
| AddDiPoint_BomberStock | 0x1CE20D0 | +0.1 | ItemEffectResult 0x1D70151, Kind 7 BombStock, only if `BomberStockCountUp(1)` returned true (stock < max 10) |
| AddDiPoint_BomberUse | 0x1CE2110 | −1 | `PlayerControll/<_playerBombAsync>d__35` 0x1D55919, once per bomb at bomb start (skipped if token cancelled) |
| AddDiPoint_BossDestroy | 0x1CE2150 | +5 | `Ene_BosBase.StopBossTimer` 0x1DBA829, only if `_isBossTimeStart` (0x1B2); called from every `Ene_Bos01..08C.ToDestroid` (Bos08 A/B/C each) |
| AddDiPoint_PlayerDead | 0x1CE2210 | −2.5 | `InGameManager/<_playerDeadPhase>d__410` 0x1D2F59F, first state, every life lost (then playPhase = 4) |
| AddDiPoint_EnemyDestroy | 0x1CE2190 | +0.01 × `_enemyDestroyCounter` | NO call sites (direct/jmp scan; its body is the only reader of `_perDestroy` and the only caller of `ResetDestroyCounter`). Counter (InGameEnemyManager+0x58) is incremented in `<GetEnemy>b__0` 0x1CDF6A8 when `PawnEnemy.SetDestroyResult()` is true, reset by InitializeToPlay/ResetLists. → enemy kills do NOT change rank in the shipped build [delegate use not excluded: unconfirmed] |
| AddDiPoint(float) | 0x1CE22D0 | arg | no callers |

## 3. Consumers (complete for `[reg+0x298]` reads)

ScriptableObject `InGameScalability.asset` (GameScalability, InGameResident+0x98): `_bulletSpeedScale` = (0.1, 3.5),
`_eventRepeatScale` = (1.2, 0.8). Both getters 0x2720B90 / 0x2720C10:
```
c = clamp(d, -1000, 1000)                      // rdata 0x35F2BCC -1000, 0x34E0E6C 1000
t = clamp01(|c| / 1000)
d < 0 : Mathf.Lerp(1, V.x, t)     d > 0 : Mathf.Lerp(1, V.y, t)     d == 0 : 1
```
If InGameResident or its scaler table is missing the result is 1.0 (rdata 0x34E0BCC).

1. **Enemy bullet speed**: `LateUpdate` 0x1CE89E8 every frame (if `!_isQuitDone` and bulletManager exists) writes
   `InGameBulletManager._bulletSpeedScale` (0x6C) = GetBulletSpeedScale(DiPoint) = `1 + 2.5·t` (d>0) / `1 − 0.9·t` (d<0).
   Used by `InGameBulletManager.BulletFire` 0x1CCADA1 (`speed = _bulletSpeedsDictionary[kind] × scale`, at fire time) and
   `GetSpeed(kind)` 0x1CCB602. Examples: d=0 → 1.0, 30 → 1.075, 100 → 1.25, 130 → 1.325, 999 → 3.4975, −10 → 0.991.
   (`InGameManager.GetBulletSpeedScale()` 0x1CE40C0 wrapper itself has no callers.)
2. **Event repeat interval**: `_UpdateParameters` 0x1CF0359 (from LateUpdate) sets `_eventRepeatScale` (0x64) =
   GetEventRepeatScale(DiPoint) = `1 − 0.2·t` (d>0) / `1 + 0.2·t` (d<0). Read by `InGameEnemyMoveBase/<_execEventWithRepeat>d__31`
   0x1CF6BA7 only for RouteEvents with `rpidf` (0x69) = true, sampled once at event start: `repeatDelay ×= s`,
   first wait = `value1 × s` (+ `Random01 × randomWait × s`). Bos08A/B/C call `GetEventRepeatScale()` 0x1CE4460 directly
   (13 sites, see Bos08 SPEC). Examples: d=30 → 0.994, 100 → 0.98, 999 → 0.8002.
3. Nothing else reads DiPoint: no enemy HP, bullet count, spawn selection or BulletSelecter (RouteEventType 83) dependence found.
   Only other reader: the round-loop carry (§1). `get_GetDiPoint` 0x1CF29F0 has no callers.

## 4. Difficulty settings

GameSetting (TXEKernel) has no difficulty/rank field (languageArea, volumes, display, vsync, brightness, resolution,
onlineRanking, lifes, bombs, power, autoBomb, bgm, pads, DLC). `UpdateGameSetting` 0x1CED4E0 / `UpdateParamsByPlayMode`
0x1CED730 / `_InitializeParameters` 0x1CEED10 never touch DiPoint. Only the per-mode GameAddPoints table and stage/round set it.
`InGame.Kernel.InnerLevel` (levels 0..30, default 10, GetBulletSpeedRate/GetEnemySpeedRate) has no callers: dead code.
[Lives/bombs/power settings change starting resources only: not traced further.]
