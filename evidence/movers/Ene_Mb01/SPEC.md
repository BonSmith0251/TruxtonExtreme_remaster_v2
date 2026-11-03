# Ene_Mb01 — one static program for both indices (BG06)

Read-only study of `GameAssembly.dll`. Shared machinery is in `../../air-route-events/SPEC.md`. `[I]` = inference, `[?]` = unknown.
Tools: `../tools/cctor_programs.py 1DBFB80 1452`, `../tools/lut_routes.py`, `../tools/m7_sim.py mb01`.

## 1. Identity

| Item | Value |
|---|---|
| Prefab | `Assets/OriginalRecovered/Samples/Prefabs/Reference/Enemy/Pf_Ene_Mb01.prefab` |
| Components | `EnemyMover`, with `_muzzlePacks` keys fire1A (2 muzzles), fire2A, fire3A, fire4A, fire1B (2), fire2B, fire3B, fire4B. `PositionShift` (`_baseY 0, _targetY 0`: inert, see §6). `Ene_Mb01` (`_HitPoint 100`, not lock-on, `pf_eff_explposion03`). `EnemySEPlayer`. 2× `EnemyCollisionModel`. `PhysicsEnemy` on `physics_mb` (node `pf_ene_mb01` → target; visual only [I]). |
| Class | `Ene_Mb01 : PawnEnemy`. `.cctor` 0x1DBFB80, `CreateRouteData` 0x1DBF1C0, `GetRouteNames` 0x1DBF870, `GetBulletTemplates` 0x1DBF4D0. **No per-frame code.** |
| Definition | BG06 `ene_mb01`: attribute 16, events [], routes [], duration 60, position (0,0,140); speed 50, rotate y 180, **easeType 0** (Linear), **lookAt 31** (DriftM) |
| Spawns (BG06, spawn = (0,0,140)+offset) | 7.0 (−50) i0, 12.0 (+50) i1, 22.0 (−90) i0, 24.5 (−30) i0, 27.0 (+30) i0, 29.5 (+90) i0, 92.0 (+80) i0, 97.0 (−80) i1, 132.0 (+90) i1, 134.5 (+30) i1, 137.0 (−30) i1, 139.5 (−90) i1 |

## 2. CreateRouteData 0x1DBF1C0

```
lists = _routeEventLists (static +0)
lists[1] = lists[0]                                   // set_Item(1, get_Item(0)) on EVERY call
foreach e in lists[1]:                                 // == lists[0]
    if e.eventType == 2 (Rotate) && e.flag0 (absolute): e.vectorValue.z = −e.vectorValue.z   // xorps with −0.0, @0x1DBF369
_enemyData (0x1B0) = sourceData.ShallowCopy();  _enemyData.eventDatas = lists[_indexValue].ToArray()
_enemyData.Coordinate();  PawnEnemy.CreateRouteData(this, _enemyData, startPosition)   // 0x1D0D170 -> mover
```

- The `.cctor` builds `lists[1]` as an **empty** list (@0x1DC0F46). CreateRouteData then overwrites it with list 0, so **index 0 and index 1 run the same program**.
- The z-flip only touches absolute Rotate events. The only one is event [0], with vector (0,180,0), so it toggles z between 0 and −0. That has **no effect**. It is also global: the shared static event is flipped again on every spawn. [I: the intent was probably a mirrored roll for index 1, but as compiled it does nothing.]

## 3. The program (`lists[0]`, 37 events)

```
[0]  Rotate(dotime 0, vec (0,180,0), abs=true)            instant: root localRotation = Euler(0,180,0)
[1]  SplineMove common_D50          [2] TaskWait 256
[3]  Speed(10, 1)                   [4] SplineMove common_D200        (ramp 50 -> 10 over 1 s while D200 starts)
[5]  Rotate(dotime 1, vec (0,0,-180), relative, easing 1 = InOutSine)  [6] TaskWait 1
[7]  Delay 0.1  [8] Bullet mb01_fire1 @fire1A  [9] Bullet mb01_fire2 @fire2A  [10] Bullet mb01_fire3 @fire3A
[11] Delay 0.5  [12] Bullet mb01_fire4 @fire4A  [13] Delay 0.5
[14]-[22] = [5]-[13]   [23]-[31] = [5]-[13]                (3 roll+volley cycles in all)
[32] Rotate(1, (0,0,-180), rel, InOutSine)   (no TaskWait after it)
[33] SetObjFlag 256 (NoBullet)   [34] Speed(50, 1)   [35] TaskWait 256   [36] FinishDestroy
```

The Bullet events use muzzle-pack keys (`fire1A` etc.), not hierarchy paths. The `…B` packs are never used.

Routes (RouteLUT, copied to `routes.json`): common_D50 (2 points, 50 long) and common_D200 (17 points, 200 long, straight down).

## 4. Per-frame behaviour

- Pure stack mover (air spec §1), so the class adds nothing per frame.
- The path is a straight drop: z −50 at 50 u/s, then 200 more while the speed ramps 50→10 over 1 s. It holds 10 u/s through the three volleys and returns to 50 at about 7.4 s. FinishDestroy fires when D200 ends (x constant).
- Ease 0 is linear by distance.
- The rolls: four relative −180° rolls about local Z, each 1 s InOutSine (DOTween `DOLocalRotate`, Manual update in `InGameManager.LateUpdate` 0x1CE8580, after the LastUpdate spline step).
  - The SplineMove step writes `localRotation = _firstRotate · drift` **every frame** (moveType 6, `set_localRotation` @0x1CFA187).
  - The tween writes after it in the same frame, so the tween value is what renders while it runs [I: from the PlayerLoop order].
  - When a tween ends, the next frame's spline write restores `_firstRotate · drift`. `_firstRotate` was captured as Euler(0,180,0) when D200 started. So each roll goes 0 → −180° and then snaps back to 0, four times in all [I].
  - DriftM itself adds nothing on a straight route: xsub = 0, so the roll accumulator stays 0.
- Bullets: three volleys at t ≈ 2.13/4.27/6.40 (fire1–3) and 2.63/4.77/6.90 (fire4). NoBullet is set from 7.40.
- End: FinishDestroy runs when no 0x214 task remains. The TaskWait 256 just before it guarantees the spline is done, so it ends at spawn + (0,0,−250), z = −110 (below the bottom edge −91.7).

## 5. Simulated path (`m7_sim.py mb01`): BG06 t = 7 s, clip (−50,0,0), index 0

| t | x | z | speed | event |
|---|---|---|---|---|
| 0 | −50 | 140.00 | 50 | Rotate abs 180, D50 |
| 0.5 | −50 | 115.00 | 50 | |
| 1.0 | −50 | 90.00 | 49.33 | D50 done, Speed 50→10 and D200 start; roll 1 starts |
| 1.5 | −50 | 70.24 | 30 | |
| 2.0 | −50 | 60.40 | 10 | roll 1 ends 2.017 |
| 2.133 | −50 | 58.89 | 10 | Bullets fire1–3 |
| 2.633 | −50 | 53.85 | 10 | fire4 |
| 3.133 | −50 | 48.86 | 10 | roll 2 |
| 5.267 | −50 | 27.55 | 10 | roll 3 |
| 7.400 | −50 | 6.19 | 10 | roll 4, NoBullet, Speed →50 over 1 s |
| 8.0 | −50 | −7.05 | 34 | |
| 9.0 | −50 | −54.04 | 50 | |
| 10.117 | −50 | −110.00 | 50 | D200 done → FinishDestroy |

## 6. Reconstruction notes

- Hook: when `model == Pf_Ene_Mb01`, replace the (empty) events with §3 and add the two LUT routes.
- `Round1EventStack.Rotate` only handles yaw (`vectorValue.y`), so the z-rolls hold RotateTask for 1 s with no visible effect. That gives the right timing, and only the visual roll is missing.
- `PositionShift` is inert for this spawn. `ProgressReset` 0x1D3E0A0 sets `_planeY` = the pawn's `_targetY` (+0x170), and `Progress` 0x1D3E180 returns while `_baseY == _planeY`. All placements have `PlaneOffsetY 0` [I: pawn `_targetY` = 0].

## 7. Open questions

- `[?]` Whether the roll tween really wins over the spline's per-frame rotation write (DOTween Manual update point vs LastUpdate). If the spline wins, the rolls are invisible.
- `[?]` Whether the original designers intended index 1 to be mirrored; the shipped code makes both identical.
