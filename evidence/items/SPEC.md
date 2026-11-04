# TATSUJIN EXTREME (original, IL2CPP) — items / power-ups spec

Source: native disassembly of `GameAssembly.dll` (RVAs below), type models in
`code/type-model-source/DiffableCs`, serialized data in `Reconstructed/Assets/OriginalGame`.
Read-only study, 2026-11-04. Tools: `evidence/movers/tools/mdis.py`, `mlist.py`; plus
`evidence/items/tools/callers.py <rva...>` (scans `.text`/`il2cpp` sections for E8/E9 rel32 calls to an RVA)
and `jt.py <addr> <n> <firstCase>` (decodes switch jump tables).
`[unconfirmed]` = not proven from code/data.

## 1. Item kinds (`InGame.Kernel.Item.ItemEffects/Kind`, cctor 0x1D70400)

| id | Kind | floating prefab (`_itemObjectNames`) | ground prefab (`_groundItemNames`) |
|---|---|---|---|
| 1 | PlayerUp | Pf_EneObj_Item02_1up | Pf_item_1up |
| 2 | PowerUp | Pf_EneObj_Item01_Power | Pf_item_power |
| 4 | SpeedUp | Pf_EneObj_Item05_SpeedUp | Pf_item_speedup |
| 5 | PipilUp | – | – |
| 7 | BombStock | Pf_EneObj_Item04_BomStock | Pf_item_bomstock |
| 8 | ScoreUp | – | Pf_item_bonus01 |
| 9 | PlayerUp2 | Pf_EneObj_Item02_2up | Pf_item_2up |
| 10 | PlayerUp3 | Pf_EneObj_Item02_3up | – |
| 100 | ArmNormal | Pf_EneObj_Arm_NShot | Pf_item_change_red |
| 101 | ArmBeam | Pf_EneObj_Arm_TBeam | Pf_item_change_green |
| 102 | ArmLaser | Pf_EneObj_Arm_TLaser | Pf_item_change_blue |
| 103 | ArmGlow | Pf_EneObj_Arm_GShot | Pf_item_change_purple |
| 104 | ArmHorming | Pf_EneObj_Arm_Horming | Pf_item_change_silver |
| 105 | ArmGold | Pf_EneObj_Arm_WShot | Pf_item_change_gold |
| 106 | ArmBlack | Pf_EneObj_Arm_Black | Pf_item_change_black |
| 1000 | ReferenceTable | – | "ItemOfIndex" (resolved by the item table, §5) |

Kind 0 maps to one more unnamed object string (static at bss 0x4677f00) [unconfirmed]; kinds 3/6 exist only in the unused
BG prefabs `Pf_item_bomber` (3, value 2) and `Pf_item_change` (6); ItemEffectResult has no case for them (no effect).

The Int32 argument (`value`) is the item's serialized `_itemValue` (ItemEnemy+0x1B4 / ItemCollision+0xA4), read from the prefab:
Item01_Power 1, Item02_1up 1, Item02_2up 2 (kind 9), Item02_3up 3 (kind 10), Item04_BomStock 1, Item05_SpeedUp 1,
Arm_* 1; ground: Pf_item_1up kind1 value1, Pf_item_2up kind1 value2 (!), Pf_item_power 1, Pf_item_speedup 1,
Pf_item_bomstock 2 (ignored, see bomb), Pf_item_bonus01 kind8 value 5000, Pf_item_change_* 1.
Ground prefabs also carry `_getSound` (1up/2up: 228 = 0xE4, others −1) and `_isGetEffect` (power/speed/bomb/1up/2up: 1).

`GetGroundItemCount` 0x1D6FBA0 (pool sizes): kind 8 → 12; kinds 1, 2, 4, 7 → 8; others → 4.

## 2. `ItemEffects.ItemEffectResult(player, pinfo, kind, value)` 0x1D6FF10 (real length runs to 0x1D703DF)

Returns false immediately if `player` or the InGameManager instance is null. Jump tables at 0x1D70398 (kinds 1–10)
and 0x1D703C0 (kinds 100–106). Return value = "item had an effect".

| kind | code | effect | returns |
|---|---|---|---|
| 1, 9, 10 | 0x1D70199 | `PlayerControll.StockCountUp(value)` → `PlayerInformation.StockCountUp` 0x26DED30: stock = clamp(stock+value, 0, 99). If changed: sound `UpSE(kind)` 0x1D703E0 = 0x16 (kind 9), 0x17 (kind 10), 0xE4 (kind 1). `AddTakens(PlayerUp, value)` | stock changed |
| 2 | 0x1D70034 | `PlayerControll.PowerUpWeapon()` (§3). If it returns 2: `InGameManager.AddDiPoint_Powerup` 0x1CE2250 + `UpdatePlayerBonusMul` 0x1CED8F0. `AddTakens(PowerUp,1)` | PowerUpWeapon ≠ 0 |
| 4 | 0x1D700B0 | `PlayerControll.AddSpeedCapacity(value)` (§4); if true sound 0x14. `AddTakens(SpeedUp,1)` | capacity changed |
| 5, 3, 6 | 0x1D70093 | nothing | false |
| 7 | 0x1D70102 | `BomberStockCountUp(1)` (value ignored) → bombs = clamp(bombs+1, 0, 10); if changed sound 0x15 + `AddDiPoint_BomberStock` 0x1CE20D0. `AddTakens(BombStock,1)` | bombs changed |
| 8 | 0x1D7016C | `InGameManager.AddScore(value, playerNo==0)` 0x1CE2500 (bool unused) | **false** always |
| 100 | 0x1D70241 | `ChangeWeapon(normalShot=0)`, AddTakens(ArmNormal=20) | weapon changed |
| 101 | 0x1D70270 | `ChangeWeapon(tatsujinBeam=1)`, takens 21 | 〃 |
| 102 | 0x1D702A2 | `ChangeWeapon(thunderLaser=2)`, takens 22 | 〃 |
| 103 | 0x1D702D4 | `ChangeWeapon(starmineShot=5)`, takens 23 | 〃 |
| 104 | 0x1D70306 | `ChangeWeapon(homingShot=4)`, takens 24 | 〃 |
| 105 | 0x1D70334 | `ChangeWeapon(goldLaser=3)`, takens 25 | 〃 |
| 106 | 0x1D7035E | `ChangeWeapon(blackLaser=6)`, takens 26 | 〃 |

Colour → weapon: red = normal shot, green = Tatsujin beam, blue = thunder laser, purple = starmine ("GShot"),
silver = homing, gold = gold laser ("WShot"), black = black laser.

**When an item has no effect (returns false) the pickup is converted into the "5000" bonus** (§7), except kind 8 on
floating items.

## 3. Power level (PlayerControll.PowerUpWeapon 0x1D4AAC0, PlayerInformation.ArmLevelUp 0x26DE420)

- State: `_armLevel` (0x34), `_armSubLevel` (0x38), `_armKind` (0x30), `_isArmLevelUp`.
- Max level `GetArmLevelMax` 0x26DE660 = `PlayerCommonData.ArmLvMax` = 3 + awakenLv (`PlayerCommonData.Initialize` 0x26DD6A0),
  awakenLv = 0 normally, 1 if `PlayedRecords.General.IsWokeUpUnlocked`, 2 if `IsMoreAwakeUnlocked`
  (`InGameManager._InitializeParameters` 0x1CEED10). So levels 0..3 (default), 0..4 or 0..5. `PowerLevels` enum 0..6.
- **3 power items per level**: `ArmLevelUp(+1)`: sub += 1; if sub ≤ 2 → stays; if sub > 2: if level < max → level+1, sub = 0,
  `_isArmLevelUp = true`; else (at max) sub = 3 ("full"). Returns "sub changed". With n = −1 and sub < 0 → level−1, sub = 2.
- `SetArmLevel` 0x26DEA30: clamp 0..max; `_awakenBody` = 0 if level < 4, 1 if level == 4, 2 if level ≥ 5.
- PowerUpWeapon: if ArmLevelUp false → return 0 (no effect → 5000 bonus). Else `weapon.SetPower(level)` (WeaponBaseShot.SetPower
  0x1D578B0 returns "power level changed"): if level unchanged → sound 0x1E, return 1 (sub-step); if changed →
  PlayerEffects.StartEffect(PowerUp=2), option display update, sound 0x0E, return 2.
- At max: the next 3 items step sub 0→1→2→3 (sounds 0x1E); once sub = 3 every further power item gives the 5000 bonus.
- `PowerDownWeapon` 0x1D4A9F0 (ArmLevelUp(−1)) has no callers.
- `SetArmSubLevel` 0x26DEAA0 (clamp 0..3) has no callers.

## 4. Weapon change (PlayerControll.ChangeWeapon 0x1D48D70 → ChangeWeaponByIndex 0x1D48A00)

- Finds the weapon in `_weaponLists` whose `Kind()` matches; none → false.
- **Same weapon as current → no change, returns false → 5000 bonus. No level-up.**
- Different weapon: old weapon NoFire, sound 0x21, effect `WeaponTop+kind` (6+kind), new weapon `SetPower(pinfo._armLevel)`
  (**power level and sub-level kept**), `pinfo._armKind = kind`, materials/options updated. Returns true.
- Weapon kind survives death (ClearByDead does not touch it; `ReStartPlayer` 0x1D4AC10 re-applies the current index).
- Drop masking (`ConvertDropKind` 0x1CE2FA0, also inline in `ItemDrop` and `TableItemDrop`): gold (105) becomes silver/homing (104)
  unless `_armDrop & 2`; black (106) becomes purple/starmine (103) unless `_armDrop & 1`. Mask from
  `SetArmDropMask(IsEnableBlack, IsEnableGold)` 0x1CEA5E0 called in ModelGamePlayBase.IntializeInGameMode (0x21C70C0);
  the unlock conditions of IsEnableBlack/IsEnableGold [unconfirmed].
- There is no separate "change" stock: weapon change happens only via coloured items.

## 5. Speed (PlayerInformation 0x26DE3B0/0x26DE4D0/0x26DECE0/0x26DED10, PlayerControll 0x1D48820/0x1D48910/0x1D4C760/0x1D4E390)

- `SpeedLevelMax` = 5, `GetSpeedMax` 0x9E1870 = 5. `_speedLevel` 0..`_speedCapacity`, capacity 0..5.
- Move speed = `PlayerDefinedSpeeds.SpeedList[speedLevel]` (`_updateSpeed` 0x1D4E390), asset
  `InGame/InGameReference/Resident/PlayerDefinedSpeeds.asset`: **[1.0, 1.4, 1.8, 2.2, 2.6, 3.0]** (6 levels). While rescue-waiting
  the external speed factor is 0.2 (`ExternalFactorSpeedRate` 0x1D491A0).
- Arcade start: `PlayerInformation.Initialize` 0x26DE690 zeroes level, sub-level, speed level, capacity, weapon (normal shot).
  Only Story/Arena presenters and the training settings popup call SetSpeedCapacity/SetSpeedLevel.
- **Speed item** (AddSpeedCapacity 0x1D48820): capacity = clamp(capacity+value, 0, 5) (value = 1); if capacity changed →
  speed level +1 (clamped to capacity), effect SpeedUp, sound 0x14 (from ItemEffectResult). At capacity 5 → no effect → 5000 bonus.
- **Player speed buttons** (`_playerControllSpeedChange` 0x1D4C760; inactive while capacity == 0 or flags 0x802):
  - speed-change (single button): steps +1 (or −1 when `_speedChangeReverse`); when it can't move it flips direction and steps
    the other way → ping-pong 0..capacity.
  - speed-up: +1, effect SpeedUp, sound 0x20; speed-down: −1, effect SpeedDown, sound 0x0D.
  - The player can only choose a level ≤ capacity; there is no speed-down item.
- Death: capacity −1 (min 0), speed level clamped to the new capacity (`ClearByDead` 0x26DE500).

## 6. Bombs, lives, extends

- Start values (arcade): stock = `GameSetting.lifes` − 1 (`ModelGamePlayBase.GetPlayerCount` 0x21C0570), bombs =
  `GameSetting.bombs` clamp 0..10 (`GetBomberCount` 0x21C0100); defaults lifes 3, bombs 3 (`GameSetting..ctor` 0x26D4350)
  → 2 reserve ships + 3 bombs. Applied by `SetupStageParameter` 0x1CEC2E0 → `ResetScore` → `PlayerCommonData.Reset` 0x26DD700
  (also records `_numFirstStockBomb` = start bombs). Continue data (`ArcadePlayModel._cdata`) can override.
- Caps: bombs 10 (`AddBomberStock` 0x26DE2F0, `BomberCountMax`), stock 99 (`StockCountUp`), extends counter 99, deaths 999.
- `UseBomber`/`UseRescueBomber` (same code 0x26DEDC0): if bombs > 0 → bombs−1, `_numBomber`++, `_numUseBomberInStage`++.
  Used by manual bomb (`_playerControll` 0x1D4D232), **auto-bomb** (`_playerDead` 0x1D4D3E0: if PFlag.AutoBomb (0x200000) and a
  bomb is left, the hit fires a bomb instead of killing the player), and `superFighterCollision.OnHitProgress` 0x1D60456
  (one-time per collision, sets `_isRescued`) [exact trigger unconfirmed]. Bomb use: DiPoint `AddDiPoint_BomberUse`.
- "BomberGauge"/`TXEBomberIconValue` is the bomb-stock HUD (`SetValue(long,int,bool)` 0x27263F0); no separate bomb level
  found [unconfirmed].
- **Score extends** (`PlayerCommonData.AddScore` 0x26DCE00, same formula as `ExtendScores.GetExtentCount` 0x26D2D10):
  n = [score < start ≤ score+add] + (step > 0 && score < end ? (score+add)/step − score/step : 0).
  Arcade asset `InGame/InGameReference/Database/ExtendsArcade.asset`: start 5,000,000, step 10,000,000, end 1,000,000,000
  (→ extends at 5M, 10M, 20M, 30M … below 1G). ctor defaults 500,000 / 1,000,000 / 100,000,000.
  The count is added to `_numExtends` (pending), **not** to the stock. It is paid out only by `InGameManager.TableItemDrop`
  0x1CEC6E0: while `_numExtends > 0` a table drop yields kind 1 (1UP item) and decrements `_numExtends` (table index not
  advanced). `get_NumExtends` has no other caller.

## 7. "5000" bonus and bonus multiplier

`InGameManager.Get5000(pos, playerNo, isGround)` 0x1CE3F10: `mul = PlayerCommonData.AddBonusMul()` 0x26DCD30
(mul = clamp(mul+1, 1, `_numBonusMax`), AddTakens(P5000)); popup effect `Score5000` index mul; `AddScore(5000 × mul)`.
`_numBonusMax` = 10 + min(2, max over players of `_awakenBody`) (`SetNumBonusMax` 0x26DDB50 via `UpdatePlayerBonusMul`
0x1CED8F0 on every real power-level change and in `_outPlayer`). So 5000, 10000, … 50000 (55000/60000 with awaken bodies).
`_numBonusMul` reset to 0 on death (`PlayerCommonData.ClearByDead` 0x26DD080).
Callers: useless floating item (ItemEnemy.OnHitProgress, kind ≠ 8), useless ground item (ItemCollision.OnHitProgress — including
Pf_item_bonus01, which therefore gives AddScore(5000) **and** a 5000×mul bonus), ScoreUp carriers (ItemEnemyBox.DropItem,
PawnEnemyGround.DropItem: kind 8 → bonus directly, no item spawned), `ItemEnemy._displayScoreUp` 0x1D71210 (caller not found
[unconfirmed]), several enemies (La01, Lc01, Mj01b/h, Mm01) and `InGameBonusManager._setCompleteBonus`.
`AddScore` is ignored in play phases 4, 5, 7, 9, 10 (0x1CE2500) [phase names unconfirmed].

## 8. Floating items (`ItemEnemy` : PawnEnemy)

- Spawned by `InGameManager.ItemDrop(kind, pos, b)` 0x1CE82E0: arm-mask conversion, prefab `GetItemName(kind)`, position
  `GetClampedPosition(pos)`, route `itemCarryDrop00` from there, LookAtType 0, speed `_dropItemSpeed` = 8.0, smooth, EaseOut (2),
  enemy layer Division 2.
- Route `InGame/RouteLUT/itemCarryDrop00.asset`: straight line (0,0,0) → (0,0,−200), i.e. it simply drifts down-screen.
  No bounce, no flee, not shootable (`AddDamageOwner` stub 0x7AA370, `OnStayProgress` empty, `IsDestroyRateTarget` false).
- `IsHitEnable` 0x1D70D30: not collectable during the first 0.1 s after (re)start (`_bornPassed`).
- `LocalLateUpdate` 0x1D70D50: `_outTime` reset while `EnemyMover._isInGamePlayArea`; after > 2.0 s continuously outside the play
  area → `EndRoute` (removed). Also removed at route end.
- `OnHitProgress` 0x1D70DF0: only player-layer `superFighterCollision`, and only if `PlayerControll.IsItemTaken` 0x1D4E4F0
  (not Deading 0x800, not AutoPilot 0x400, not DisableCtrl 0x4). Applies `ItemEffectResult`; true → `_callDeadEffect` (pickup
  effect) + EndRoute; false → `Get5000` (unless kind 8) + EndRoute.
- Carrier box `Pf_Item_Box01` (`ItemEnemyBox`, target kind at +0x1B0): spawned by timeline event (`EventEntryBehaviour._eventFire`
  0x1D3733B → `EntryItemCarry(kind, pos, dir)` 0x1CE3B40) with movement clip `item_box_air{T,B,L,R}`[dir&3]
  (e.g. airT: enters from z+100, speed 40 → 11.5 over 2 s, forward 30 s). A list of kinds in the event cycles per spawn;
  1000 is resolved by `TableItemDrop` at spawn. `DropItem` 0x1D70940 runs only when HP reached 0: kind 1000 → TableItemDrop;
  kind 8 → Get5000 at box (killer `_deathByPno`); else `ItemDrop(kind, localPos)`.
  `GetClampedPosition(wpos, bottomOffset)` 0x1CE4330: x clamped to [PlayerControllMin.x − h, PlayerControllMax.x + h] (statics
  0x148/0x154 by layout, h = 0.5·`_cinemachineBGCameraSlide.x` +0x2F0), z to [PlayerControllMin.z (+`_BottomClampOffset` 25), 100].
  So a box killed with its centre past the screen edge still drops, inside the player's range (remaster fix 2026-11-04:
  Round1Weapon.OnEnemyDestroyed used to discard such drops; e.g. BG03's Gold carrier at 310 s, x −135).

## 9. Ground items (`ItemCollision`) and table drops

- Ground enemies (`PawnEnemyGround.DropItem` 0x1D17690, also Ene_ColorBox_UN, Ene_EneBox01): kind 1000 → TableItemDrop, else
  ConvertDropKind; kind 8 → Get5000 at the enemy; else `GetGroundItemName(kind, startPos, fromTable)` 0x1CE4640 and
  `InGameRuinManager.EmitterFrom3D` → `ItemCollision.StartRuin` 0x1D6FA60 (stays on the ground layer).
- **Fixed 1UP/2UP ground drops appear once**: for kinds 1/9 not from the table, key = stageOrder | kind<<8 | (int)z&0xFF0000 |
  (int)x&0xFF000000 is stored in `_dropGroundItems`; if already present the drop becomes BombStock (7). Set cleared at game init
  (`_InitializeParameters`), carried by Import/ExportDropLists [unconfirmed when].
- `ItemCollision.LocalLateUpdate` 0x1D6F670: removed when viewport z ≤ 0 or viewport y < −3.0 (rdata 0x35F2C10). No timeout
  (`CheckTimeout` stub).
- `ItemCollision.OnHitProgress` 0x1D6F7C0: ItemEffectResult; true → `GetSomthing` pickup effect if `_isGetEffect`, play
  `_getSound` if ≠ −1; false → Get5000. Then disabled.
- `ItemReferenceTable` (`InGame/InGameReference/Resident/ItemReferenceTable.asset`), 16 entries:
  **P S P P S P P S P P S P P S P B** (P = PowerUp 2, S = SpeedUp 4, B = BombStock 7). `TableItemDrop`: if extends pending → 1UP;
  else kind = table[`_numItemIndex`], index = (index+1) % 16. `_numItemIndex` reset to 0 on death and on Reset, not per stage.

## 10. Death and respawn

- No item is emitted at the death position: ItemDrop/EntryItemCarry/TableItemDrop/GetGroundItemName have no callers on the
  death path (`_playerDead`, `Phase_PlayerDead`, `_playerDeadPhase`, `_outPlayer`).
- `_outPlayer` 0x1CF1940 (from RestartGame/_restartGameFast/_gameOver): for each dead player, `DeadCountUp`, then
  `PlayerInformation.ClearByDead` 0x26DE500 (training mode: `ResetToDefault`); then `PlayerCommonData.ClearByDead` and
  `SetNumBonusMax`.
- `PlayerInformation.ClearByDead`: speed capacity −1 (speed level clamped); **power: if sub ≥ 3 (max-full) → sub = 0, level kept;
  else level −1 (if > 0), sub kept**; weapon kind kept; `_awakenBody` not recomputed here.
- `PlayerCommonData.ClearByDead` 0x26DD080: if stock > 0: bombs refilled up to the start count (`_numFirstStockBomb`) if lower,
  stock −1; always: item-table index 0, total deaths +1, bonus multiplier 0, in-player time 0.
- Rescue (team play) uses `_playerRescueDelayAsync`, AutoRescueTime 2 s [details not studied].

## 11. Other fields

- **DiPoint** = dynamic rank value (`_DiPoint`, clamped to `_DiMin.._DiMax`). Arcade increments
  (`Resident/PointTables/ArcadeAddPoints.asset`): +0.0333/s, power-level-up +0.1, bomb-stock item +0.1, bomb use −1, enemy +0.01,
  boss +5, death −2.5; per-round clamps `_ClampBase` (−10..30 … 60..100). Used for bullet speed scaling
  (`GetBulletSpeedScale` 0x1CE40C0) [link unconfirmed].
- **PlayerBonusMul** = the 5000-bonus multiplier cap (§7).
- **Pipil** (`PipilCountUp` 0x26DE700): gauge 0..200 filled by damaging enemies (×`_numPipilScale`), spent by ex-shots
  (`DecPipilShot` −26.67); also accumulates `_totalPipil` (max 1e9). Kind 5 PipilUp has no item effect.
- `DamageMag`: player damage multiplier from the game mode (`SetupStageParameter` arg, `SetDamageMag` 0x26DEAE0); items don't touch it.
- `AwakenBody`/`SetAwaken` 0x26DEAC0 (clamp 0..2): derived from power level ≥ 4 (see §3); SetAwaken has no callers.
- `ClearByStage` 0x26DE550: only per-stage counters (deaths/revives in stage) reset; power/speed/weapon/bombs carry over.

## 12. Remaster port (2026-11-04)

Implemented in `Reconstructed/Assets/Scripts/Runtime/Gameplay/Round1WeaponItems.cs` (new), `Round1Weapon.cs`,
`Round1WeaponDrops.cs`, `Round1Powerup.cs`, `Round1WeaponArcade.cs`, `Round1Hud.cs`, `Round1Autopilot.cs`, `Round1EnemyWaves.cs`
(Mm01 joined kill → Get5000), `Arcade/ArcadeMachine.cs`, `ArcadeCore.cs`, `ArcadeService.cs` (AUTO BOMB, default off).
Backups of the previous scripts: `backups/powerup-rules-20261104/`.

- Remaster Level 1..4 = `_armLevel` 0..3, SpeedLevel 1..6 = `_speedLevel` 0..5. `PowerItems` = `_armSubLevel`.
- Item effects, the 5000 bonus with its multiplier, speed capacity, bomb cap 10, stock cap 99, death losses (§10), table extends
  (§6, §9), floating-item drift/lifetime (§8), ground-item removal, ScoreUp carriers/ground drops paying Get5000 directly.
- Speed button: keyboard `C` and the HUD button (formerly the remaster's weapon-change stock) = the single ping-pong button.
- BombLevel = awaken body + 1 (WeaponNormalBomb.Bomb(_awakenBody)); the remaster's "bomber" item, bomb levels from items,
  weapon-change stock, speed-down and 1000/5000 point items are retired (enum values kept for serialized scenes; nothing drops them).
- Follow-up port (same day; studies AWAKEN.md, POPUPS.md, RANK.md):
  - Awaken: `Round1Weapon.awakenUnlock` 0..2 (arcade operator GAME page "EVOLUTION", default LOCKED; the original unlocks it
    from save records at lifetime PlayerLevel 500 / 900, which the remaster does not keep). Top level = 4 + unlock; shots use
    `ShotLevel` = min(Level, 4) (WeaponBaseShot.PowerLevel); `AwakenBody` = Level - 4 drives the upgrade parts, bomb level
    and the bonus cap 10/11/12. The HUD power lamps now show the items toward the next level (InGameValueLevel).
  - Score popups: `Round1ScorePopups` (art `Resources/Truxton/ScorePopupArt.asset`, built by
    `ReconstructionScorePopupArt.Build` from sp_eff_5000pts01 and ui_font_result01_*): "5000" plate + "x n" from x2, at the
    source's screen point, 3 s, the original size/alpha curves. Every Get5000 caller passes its position.
  - Rank: `Round1WeaponRank.cs` (DiPoint): arcade amounts, bounds ClampBase[stage] + 100 x round, carried between arcade
    stages; drives the enemy bullet speed scale (fire time) and the rpidf repeat-event delay scale. EnemyDestroy has no
    callers in the original, so kills don't change it.
  - Speed buttons: cabinet SPEED (C / pad 2, ping-pong), SPEED UP (E / pad 5), SPEED DOWN (Q / pad 4).
  - Mj01: the head and each body count a kill; the tenth (whichever dies last) pays Get5000 at its position; the head's
    death always drops a floating bomb-stock item (Ene_Mj01h._callDeadEffect 0x1DC7D70). Database scores still paid.
- [I] Still not reproduced: AddTakens statistics, arm drop mask, rescue/team play, the jewel (Score1000) and Rush popups
  (no jewels / Rush mode), La01's body bonus and Lc01's all-covers bonus (their parts are not separate targets yet), the
  wave-complete bonus (_setCompleteBonus), ex-boost "Special" shot entries (mask bit 30). Floating-item play area =
  viewport +- 0.15; popup units use the sky-plane height (Round1Sa01Motion.ViewHeight).
- Checks: `ReconstructionItemRulesCheck.Run` (42/42 PASS after the follow-up; first port 27/27, verification/powerup-20261104/item-rules.txt); event-stack check PASS;
  BG03 stage play 90 s at 3x (stage time 267 s): 0 errors, no crash, 11 carrier + 8 ground drops.
