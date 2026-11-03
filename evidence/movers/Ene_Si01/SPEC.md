# Ene_Si01 (Pf_Ene_Si01): the swarm that orbits the BG05 "queen" Ene_Mk01

This is a read-only study of `GameAssembly.dll` (IL2CPP x64). The frame and units are those of `../../air-route-events/SPEC.md` §0:
- sky plane: x right, z up the screen, y toward the camera (camera at y = 400, 20° FOV);
- yaw about +Y, 0 = +Z (up the screen), 90 = +X.

`[I]` marks inference and `[?]` marks an unknown. Everything else was read from code, with RVAs given.

Files:
- Disassembly in `dis/`:
  - `all_methods.txt`: every Ene_Si01 method;
  - `spawn_chain.txt`: `StartKickWithDelayTime`, `StartRouteWithDelay`, `StartRoute`, `InGameEnemyManager.EntryEnemy`;
  - `InGameEnemyManager_enemyEntry.txt`, `CreateRouteData.txt`, `SplineMover_StartRoute.txt`, `EnemyMover_StartRoute.txt`, `PawnEnemy_IsAlive.txt`, `PawnEnemyDD_CallDisabled.txt`, `PawnEnemy_EndRoute.txt`, `PawnEnemy_SetDelayTime.txt`.
- Mk01 code it depends on: `../Ene_Mk01/dis/child_fire.txt` (`SetChildTarget`) and `../Ene_Mk01/dis/repulsion.txt` (`_childRepulsion`, `GetLocalPosition`).
- Spawn code: `../Ene_Ss01/dis/InGameEnemyManager_localCallEnemy.txt`. RookEnemy code: `../Ene_Ss01/dis/RookEnemy.txt`.
- Model: `si01_sim.py` (queen + 10 Si01, 60 fps). Its outputs are in `sims/`.

## 1. Identity

`InGame.Kernel.Enemy.Ene_Si01 : PawnEnemy` (TypeDef token 0x2000205).

The prefab is `Assets/OriginalRecovered/Pf_Ene_Si01.prefab`. Its root components are listed below; the script names were matched from m_Script fileIDs with `ground-route-events/tools/script_fileid.py`.

| Component | fileID | Serialized values |
|---|---|---|
| EnemyMover | −567815233 | `_lookAtType 0`, `_moverState 0`, `_muzzlePacks []`, `_lookAtUpdateSec 0` |
| Ene_Si01 | 2145178995 | <ul><li>`_HitPoint 100`, `_isLockonTarget 1`, `_isLaserBlock 0`</li><li>`_deadExplosion pf_eff_explposion01`, `_deadBullet ""`, `_overplayDeadSound −1`</li><li>`_modelTop` = `pf_ene_si01`, `_isSimpleCalc 0`</li><li>one PartsList entry with 3 renderers</li><li>**`_Muzzle` = `…/ene_body/ene_hip/muzzle`**</li></ul> |
| EnemyCollisionModel (child `collisions`, local z −0.3) | 2066137973 | `_shapeType 5`, `_points [(4.5, 9)]`, `_attribute 0` |

**Model.**
- The mesh node `ene_si01` sits at local (0, 0, −2), Euler X −40°, scale 0.9.
- There are four animated leg sub-prefabs (`pf_ene_si01_leg10/30/70/90`) with Animators, and two `pf_eff_burner_e02`.
- **Muzzle position.** The muzzle is at (0, −8.12, 8.98) under `ene_hip` → `ene_body`, both identity in the prefab. That is about **(0, −0.40, 8.89) in root space**, so the muzzle is on the nose, local +Z. This is [I], because the Animators may move the hip.

## 2. Where and when it spawns (BG05)

Si01 has no spawn clip of its own. It exists only as placements[1..10] of the two Mk01 definitions:
- `ene_mk01a` / `ene_mk01b`;
- attribute 16 (EventStack), duration 60, position (0, 0, 150);
- **0 events, 0 routes**.

| Clip | Time | Clip offset | indexValue | Queen spawn | Si01 spawns (placement offset + queen) |
|---|---|---|---|---|---|
| `ene_mk01a` | 252 s | (−30, 0, 0) | 0 | (−30, 0, 150) | (−10, 120), (−20, 120), (−30, 120), (−40, 120), **(−50, 120) × 6** |
| `ene_mk01b` | 272 s | (30, 0, 0) | 1 | (30, 0, 150) | (50, 120), (40, 120), (30, 120), (20, 120), **(10, 120) × 6** |

- **Placement values.** Every Si01 placement has: objectName `Pf_Ene_Si01`, moveSpeed 10, rotate (0, 0, 0), lookAt 1, easeType 0, attributeFlag 1, delayTime 0.
- **Offsets.** The offsets are (20, −30), (10, −30), (0, −30), (−10, −30), then (−20, −30) six times. Placements 5–10 therefore spawn on exactly the same point. All Si01 spawn at y = 0.
- **10 Si01 per queen, 20 in all.** gameModeMask is 0.

### How the children are created and attached

`InGameEnemyManager.EntryEnemy` (0x1CD3990) runs in two passes.

**Pass 1: `_localCallEnemy` (0x1CD6CD0), for each placement i in order.**
1. Get the pawn: `GetEnemy(objectName or model, root)`.
2. Set up the pawn:
   - `SetEnemyLayer`;
   - `_indexValue (+0x94) = clip indexValue`;
   - if `attributeFlag & 1` and the first pawn of the call (the head, Mk01) is a RookEnemy: `head.SetChildObject(pawn, i−1)` (vslot 0x688, 0x1CD6F7D).
3. **`SetChildObject` (0x1D19F10).** This calls `_childObjects.Add(pawn)` and `pawn.PoolEvent += …`, which removes the pawn from the list when it is pooled [I].
4. **`_enemyEntry` (0x1CD86C0)** does four things:
   - `CreateRouteData(data, pos)`. `SplineMover.CreateRouteData` (0x1D43970) does **`transform.localPosition = pos`** here (air), with pos = clip position + placement offset.
   - `UpdateObjectData(placement)`, which sets `_firstRotate` and `_currentSpeed`.
   - `SetDisableAction`.
   - `SetDelayTime(startDelay + delayTime, …)`, which is 0 here.

**Pass 2, after all placements exist.** For each pawn in list order (Mk01 first, then Si01 #1…#10), `PawnEnemy.StartKickWithDelayTime` (0x1D10230) calls:
1. **`ReStart(false)`** (vslot 0x198);
2. `StartRoute` (vslot 0x5D8). This leads to `EnemyMover.StartRoute` (0x1D6CD90), then `SplineMover.StartRoute` (0x1D44600), which does `transform.localRotation = _firstRotate`.

**Consequences:**
1. **Order of set-up.** `Mk01.ReStart` → `SetChildTarget(target, immediate = true)` calls every Si01's `SetTargetAndParent` **before** that Si01's own `ReStart`.
2. **Queen yaw at child ReStart.** `Mk01.StartRoute` has already set the queen's rotation to its placement yaw **180** when each Si01 ReStarts.
3. **Positions are in place.** Every Si01 is already at its spawn position.

## 3. Static constants (.cctor 0x1D000E0)

| Field (static offset) | Raw | Value | Use |
|---|---|---|---|
| `_ParentDistance` (0x0) | 0x42480000 | **50** | radius of the formation slot |
| `_ParentApart` (0x4) | 0x42700000 | **60** | outer band: pulled back beyond this |
| `_ParentBodySize` (0x8) | 0x42200000 | **40** | inner band: pushed out inside this |
| `_SwayTimeX` (0xC) | 0x40A00000 | **5 s** | pitch-sway period |
| `_SwayTimeY` (0x10) | 0x40400000 | **3 s** | yaw-sway period |
| `_SwayAngleX` (0x14) | 0x41F00000 | **30°** | pitch-sway amplitude |
| `_SwayAngleY` (0x18) | 0x41700000 | **15°** | yaw-sway amplitude |
| `_FollowRate` (0x1C) | 0x3DCCCCCD | **0.1** | slerp per 60-fps frame |
| `_BodySize` (0x20) | 0x41A00000 | **20** | sibling repulsion radius |
| `_AccelerateSpeed` (0x24) | 0x42C80000 | **100** | u/s² toward the slot (brake = 0.8 × that) |
| `_ShotInterval` (0x28) | 0x3F800000 | **1.0 s** | |
| `_BulletName` (0x30) | — | **`"si01_fire"`** | |
| `_TargetTurnTime` (0x38) | 0x3F800000 | **1.0 s** | |
| `_DistanceLimit` (0x3C) | 0x42C80000 | **100** | hard clamp of the distance to the queen |

rdata constants used: 0.8 (35F2CC8), 0.5 (34E0BC8), 60 (35F2CE0), π (34E0BD0), deg→rad 0.01745329 (34E0BC0), 57.29578 (34E0BE0), 360 / 180, and 1e−5 (the normalise threshold).

Math helpers (as identified in `bosses/Bos07/SPEC.md`):
- 0x576BF0 = **cosf** (the CRT function, not the 0.1° table);
- 0x578890 = atan2f(y, x);
- 0x578740 = floorf;
- 0x5D2DF0 = Vector3.Magnitude;
- 0x1DE8820 = InQuad01 (t²).

## 4. Instance fields

| Offset | Field | Meaning |
|---|---|---|
| 0x1B0 | `_Muzzle` | prefab muzzle |
| 0x1B8 | `_targetPlayer` | player index from the queen. The .ctor sets −1 |
| 0x1C0 | `_queenEnemy` | Ene_Mk01 |
| 0x1C8 | `_firstPosition` | formation slot in the queen's frame, length 50 |
| 0x1D4 / 0x1D8 | `_swayX` / `_swayY` | sway phases (rad) |
| 0x1DC | `_follow` | smoothed formation rotation (Quaternion) |
| 0x1EC | `_accelerate` | **velocity** (u/s, 3D) |
| 0x1F8 | `_shotTime` | |
| 0x200 | `_bulletTemplates` | |
| 0x208 / 0x20C | `_rotateTime` / `_rotateAngle` | heading smoothing (deg, absolute yaw) |

Base fields used:
- 0x50: transform cache;
- 0xB8: `_mover`;
- 0x178: `_token`.

## 5. Methods (pseudo-code)

### SetTargetAndParent(pindex, targetPlayer, tqueen, immediate) 0x1D00040

```
_targetPlayer = targetPlayer
_rotateTime   = immediate ? _TargetTurnTime (1) : 0
_queenEnemy   = tqueen                    // pindex is NOT used
```

Callers: `Ene_Mk01.SetChildTarget` (0x1DC8BA0) does `i = 0; for c in _childObjects: if c is Ene_Si01: c.SetTargetAndParent(i++, mk._targetPlayer, mk, immediate)`. It is called from:
- `Mk01.ReStart`, with `immediate = true`;
- the end of every Mk01 Wait, with `false` (t = 5.017, 7.817, 11.267 … s for `mk01a`; see `../Ene_Mk01/SPEC.md` §4).

The queen's `_targetPlayer` is `GetNearestPlayerIndex(queen screen position)`.

### ReStart(withPlay) 0x1CFF860

```
PawnEnemy.ReStart(withPlay)                                           // 0x1CFF915
if _queenEnemy == null: return                                        // 0x1CFF945: a queen-less Si01 gets NO set-up
_firstPosition = _queenEnemy.GetLocalPosition(transform.position)     // 0x1CFF9D5 = queen.InverseTransformPoint
_firstPosition = normalized(_firstPosition) * _ParentDistance (50)    // 0x1CFFA14..0x1CFFABF (|v| <= 1e-5 -> zero)
_swayX = Random.Range(0, 6.283185)                                    // 0x1CFFAD5, one UnityEngine.Random draw per Si01
_swayY = 0; _follow = Quaternion.identity; _accelerate = Vector3.zero
_shotTime = _ShotInterval (1.0)                                       // 0x1CFFB6E
_rotateTime = 0; _rotateAngle = 0                                     // 0x1CFFB74 (qword): overrides immediate=true
mover.ClearToStart()                       (vslot 0x328)
_token = mover.CreateLinkedToken()         (vslot 0x268 -> +0x178)
_bulletTemplates = [InGameBulletManager.GetTemplate(n) for n in GetBulletTemplates()]   // base list + "si01_fire" (0x1CFF740)
```

**Slot values for BG05.** At ReStart the queen sits at yaw 180, so the local slot is −(world offset), normalised to 50:

| Placement | World offset | `_firstPosition` (queen frame) |
|---|---|---|
| 1 | (20, −30) | (−27.735, 0, 41.603) |
| 2 | (10, −30) | (−15.811, 0, 47.434) |
| 3 | (0, −30) | (0, 0, 50) |
| 4 | (−10, −30) | (15.811, 0, 47.434) |
| 5–10 | (−20, −30) | (27.735, 0, 41.603) |

The initial `_rotateTime = 1` from `SetTargetAndParent(immediate)` is wiped by ReStart. The first turn is therefore the smooth one (§6.7).

### LocalLateUpdate(dt) 0x1CFF820

```
PawnEnemy.LocalLateUpdate(dt)    // 0x1D0E790: in-play-area flag, then the mover (EnemyMover.Progress -> empty stack)
_stateExec(dt)                   // tail jump
```

The Si01 code runs **after** the mover step and replaces it. The mover never moves this transform:
- the stack has no events;
- the definition has no routes;
- the mover's only transform write is at spawn: `StartRoute` sets the rotation to `_firstRotate` (yaw 0).

`_stateExec` writes `localPosition` and `localRotation` every frame with `SetLocalPositionAndRotation`. The placement `moveSpeed 10`, `lookAt 1` and `easeType 0` are never read.

## 6. `_stateExec(dt)` 0x1D00370 (len 0x10BC): the whole per-frame law

There is no state variable. It is one straight path plus an exit.

```
gm = InGameManager.instance
if _queenEnemy == null || !_queenEnemy.IsAlive():                     // 0x1D004C6 / vslot 0x1B8 at 0x1D004ED
    _queenEnemy = null; CallDisabled()                                // 0x1D01393..0x1D013BE (vslot 0x308): removed, not a kill
    return
P  = gm.GetPlayerSkyPosition(_targetPlayer)                           // 0x1D00512 (3D)
Q  = gm.GetSkyRootPosition(queen.transform.position, false)           // 0x1D00589
b  = atan2f(P.x - Q.x, P.z - Q.z)                                     // 0x1D005C2: bearing queen -> player (rad)
lq = queen.transform.localPosition                                    // 0x1D005F9
S  = transform.localPosition                                          // 0x1D00623
// 1. sway + formation rotation
_swayY += dt / _SwayTimeY(3) * 2π                                     // 0x1D00666
_swayX += dt / _SwayTimeX(5) * 2π                                     // 0x1D006B4
A = Euler(0, deg(b) + 15·cosf(_swayY), 0)                             // 0x1D0072B
B = Euler(30·cosf(_swayX), 0, 0)                                      // 0x1D00771 (pitch about local X)
_follow = Slerp(_follow, A * B, min(dt·60·_FollowRate(0.1), 1))       // 0x1D00776..0x1D00902
T = lq - _follow * _firstPosition                                     // slot (0x1D00948)
d = T - S                                                             // 0x1D0094D..0x1D009B1
// 2. velocity (_accelerate) update
if dot(_accelerate, d) < 0:                                           // 0x1D009EA: moving away from the slot -> brake
    _accelerate -= normalized(_accelerate) * 100 * dt * 0.8           // 0x1D00A55..0x1D00AC5 (80 u/s²)
_accelerate += normalized(d) * 100 * dt                               // 0x1D00B76..0x1D00BC6 (100 u/s²)
e = S - Q;  r = |e|                                                   // 0x1D00BCE..0x1D00C2D
if 40 - r > 0: _accelerate += normalized(e) * (40 - r) * 0.5          // 0x1D00C32..0x1D00D1F  per-FRAME impulse (no dt)
if r - 60 > 0: _accelerate -= normalized(e) * (r - 60) * 0.5          // 0x1D00D65..0x1D00E4D  per-FRAME impulse (no dt)
// 3. integrate, clamp to the queen
S' = S + _accelerate * dt                                             // 0x1D00E55..0x1D00EB7
if |S' - Q| > _DistanceLimit(100): S' = Q + normalized(S' - Q) * 100  // 0x1D00EBC..0x1D0101A (velocity kept)
// 4. heading toward the player (same law as Mk01.RotatePlayer)
a  = deg(atan2f(P.x - S'.x, P.z - S'.z))                              // 0x1D0103F (from the NEW position)
_rotateTime = clamp(_rotateTime + dt, 0, _TargetTurnTime(1)); k = InQuad01(clamp01(_rotateTime / 1))   // 0x1D01047..0x1D010BF
diff = Repeat(a - _rotateAngle, 360); if diff > 180: diff -= 360      // 0x1D010C7..0x1D0111A
_rotateAngle += clamp01(k) * diff                                     // 0x1D0113D
transform.SetLocalPositionAndRotation(S', Euler(0, _rotateAngle, 0))  // 0x1D011BC
// 5. shots
if _token != null && !_token.IsCancellationRequested:                 // 0x1D011C1 / 0x1D011D7
    _shotTime -= dt
    if _shotTime <= 0:                                                // 0x1D011F9
        _shotTime += _ShotInterval(1.0)
        for bt in _bulletTemplates:                                   // only si01_fire
            mover.BulletFireAsync(_token.Token, bt, false, false, _Muzzle, null, 0f, 0, null).Forget()   // 0x1D01329
```

### 6.1 Repulsion(target) 0x1CFFDD0

It is called only by `Ene_Mk01._childRepulsion` (0x1DC9940). That function runs once per queen frame, after `Mk01._move`, for every pair i < j of Si01 children.

```
v = transform.localPosition - target.transform.localPosition
k = _BodySize(20) - |v|
if k > 0:
    n = normalized(v)                     // zero vector when |v| <= 1e-5
    _accelerate        += n * k * 0.8     // per-FRAME impulse, no dt
    target._accelerate -= n * k * 0.8
```

### 6.2 What the law does

1. **Slot.**
   - Each Si01 is pulled toward a point 50 from the queen: `Q − R·first`, where R is the bearing yaw toward the player plus sway.
   - Because `_firstPosition` was taken with the queen at yaw 180 and is applied with `Q − R·…`, at bearing ≈ 180 the slot equals `Q + (first.x, ·, first.z)`. That is the **point reflection** of the spawn offset.
   - So the row that spawns 30 below the queen swings **round to the far side of the queen from the player**: placement 1 goes upper-left, placement 5 upper-right. This takes about 0.5 s, as `_follow` slerps from identity to yaw ≈ 186° along the short way through ≈ −90°, which is to the right.
   - The arc then turns with the queen→player bearing.
2. **Sway.**
   - Yaw sway: ±15° with a 3 s period. It starts at +15°, because `_swayY` = 0 and cos 0 = 1.
   - Pitch sway: ±30° with a 5 s period about the queen-frame X axis, with a random start phase.
   - The pitch tilts the slot out of the plane: `y = −first.z·sin(pitch)`, up to ±20.8 for placement 1. **Si01 moves in 3D**, including altitude y.
3. **Dynamics.**
   - The pull is a constant 100 u/s² toward the slot, plus a 80 u/s² brake on the velocity while it is moving away.
   - On top of that, a stiff band spring toward 40–60 from the queen: 0.5·excess u/s per frame, which is 30·excess u/s² at 60 fps and depends on the frame rate.
   - The hard clamp is at 100.
   - The result is an under-damped swirl around the queen. The sim gives speeds of 30–220 u/s and r ≈ 35–80. The Si01 does **not** settle on the slot.
4. **Stacked placements 5–10.**
   - They start on the same point with the same slot. Their repulsion is zero on frame 1, because `normalized(0)` = 0.
   - Only their random pitch phases differ, so their positions split by a few hundredths of a unit on frame 1.
   - From frame 2 every close pair gets about 16 u/s per frame, and the six **burst apart, mostly along y and z**. At t = 0.5 s they are at y ≈ −88…+87.
   - **The direction of the burst depends on the RNG.**
5. **Heading.**
   - The nose turns from yaw 0 toward the player with the k = (t / 1 s)² ramp from spawn.
   - After 1 s it is locked onto the player every frame.
   - Each queen retarget (`immediate = false`) restarts the ramp.
6. **Shots.**
   - The first shot comes 1.0 s after the first `_stateExec`: frame 61 in the float32 sim, at t = 1.017.
   - After that there is one shot every 1.0 s for the Si01's whole life.
   - **The 10 Si01 of a queen fire on the same frames**, because they share the same start and interval.
   - Nothing in the code gates firing on visibility. The template is `si01_fire`, see §7.

## 7. Bullet `si01_fire` (BulletTemplate asset)

The template values are:
- `bulletName enemybullet001`, `bulletType 1`;
- `nArc 20`, `nStartArc 270`, `nLimitArc 3`;
- `nRapidCount 2`, `nRapidDistance 0.1`;
- `isTarget 1`, `isMuzzleEffect 1`, `nSpeed 1`.

[I: aimed at the player, a 3-way 20° fan in 2 bursts 0.1 apart; Round1EnemyAttacks owns the interpretation.]

It is fired from `_Muzzle`. Si01 passes (false, false) as the two BulletFireAsync bools, where Mk01 passes (true, true) [?: meaning].

## 8. End and removal

1. **The queen is gone or dead.**
   - The rule: `_queenEnemy == null || !IsAlive()` → `_queenEnemy = null; CallDisabled()`. The pawn is removed, which is not a kill and gives no explosion [I].
   - `IsAlive` (0x1D0E480) = `(mover && mover.IsCallWait) || (_isPlaying && _HitPoint > _Damage)` (HybridCollisions.IsAlive 0x1DDF640).
   - **Normal end.** Mk01 reaches Leaving after leg 9 (31.78 s, back at its spawn point) → `CallDisabled`, after which the queen is no longer `_isPlaying` [I]. All Si01 are removed that frame, or the next, depending on the update order.
2. **The queen is killed.**
   - `RookEnemy._callDeadEffect` (0x1D1A560) → `_SeparationChildren` (0x1D1A2F0). This copies and clears `_childObjects`.
   - Mk01 has `_isChildrenSolidarity = 1`, so **every child that is still alive gets `AddDead()`** (vslot 0x2F8). [I: the children die with the queen, with explosion and scoring as for a kill.]
   - The `_separationParent` re-route branch is used only when solidarity is 0.
3. **Si01 is shot down.** It has HP 100. The PoolEvent lambda drops it from the queen's list [I]. `_childRepulsion` checks the Si01 type and null.
4. **There is no time limit and no area exit in Si01 code.**
   - `duration 60` is not read by stack movers (air SPEC §3.5).
   - The 100-unit clamp keeps the Si01 near the queen.
5. **[?] Stack rule 2 at spawn.**
   - The rule: idx ≥ count (0 ≥ 0), no EndCheck tasks, and `!_isInGamePlayArea` → `EndRoute`.
   - z = 120 at y = 0 is viewport 1.35. That is outside the Small, Medium and Large rects and inside AreaW (< 1.5).
   - If the Si01 counted as Small, the native mover would EndRoute it on its first LateUpdate.
   - This is the same open question as for Mk01 (`../Ene_Mk01/SPEC.md` §7). The design (32 s of formation, 1 s first shot) clearly expects it to live.
6. **A queen-less Si01.** A Si01 spawned without a RookEnemy head skips all of ReStart and is removed on its first `_stateExec`.

## 9. Frame order (one 60-fps frame) [I: the enemies' LateUpdates run in spawn-list order, queen first]

```
Mk01.LocalLateUpdate:  PawnEnemy.LocalLateUpdate (area flag, empty stack) -> _move (may call SetChildTarget(false))
                       -> _childRepulsion (Si01 pair impulses into _accelerate)
Si01[k].LocalLateUpdate (k = 1..10): PawnEnemy.LocalLateUpdate -> _stateExec (reads the queen's new position)
```

On frame 1 the queen is in Entering and does not move; it stays at its spawn point. Each Si01 already steps on frame 1.

## 10. Simulated path

`sims/si01_mk01a_child1_3s.txt`:
- `python -I si01_sim.py --def a --secs 3 --every 15 --sway0 0`;
- `ene_mk01a`, Si01 #1 (placement 1, spawn (−10, 0, 120)), player at sky (0, −49);
- `_swayX` start 0; siblings use a seeded RNG.

The queen path comes from `Ene_Mk01` (InOutSine leg 1 down 120 in 4 s, as in `../Ene_Mk01/mk01_sim.py`).

| t (s) | x | y | z | yaw | speed u/s | r to queen | queen (x, z) |
|---|---|---|---|---|---|---|---|
| 0.000 | −10.00 | 0.00 | 120.00 | 0.0 | 0 | 36.06 | (−30, 150.00) |
| 0.250 | 6.17 | 0.90 | 121.13 | 53.5 | 100.1 | 45.66 | (−30, 149.00) |
| 0.500 | 30.72 | 3.34 | 130.30 | 177.5 | 96.1 | 62.75 | (−30, 145.75) |
| 0.750 | 40.53 | 5.80 | 142.23 | 192.0 | 52.0 | 70.79 | (−30, 140.32) |
| 1.000 | 26.58 | 7.22 | 154.84 | 187.4 | 99.0 | 61.08 | (−30, 133.01) |
| 1.250 | 1.55 | 8.27 | 167.08 | 180.4 | 121.8 | 54.05 | (−30, 123.98) |
| 1.500 | −30.37 | 0.87 | 176.57 | 172.3 | 157.0 | 62.85 | (−30, 113.73) |
| 1.750 | −67.16 | −10.47 | 171.38 | 163.1 | 160.6 | 78.98 | (−30, 102.47) |
| 2.000 | −88.65 | −17.19 | 132.22 | 153.9 | 216.1 | 73.81 | (−30, 90.84) |
| 2.250 | −87.58 | −17.99 | 75.60 | 144.9 | 219.0 | 60.43 | (−30, 79.07) |
| 2.500 | −79.43 | −17.57 | 27.22 | 133.8 | 173.7 | 66.27 | (−30, 67.72) |
| 2.750 | −61.73 | −17.64 | −2.69 | 126.9 | 115.1 | 70.14 | (−30, 57.32) |
| 3.000 | −39.46 | −15.32 | −10.22 | 134.5 | 84.1 | 61.03 | (−30, 48.10) |

Shots at t = 1.017 and 2.017.

Reading the run:
1. **0–0.75 s.** The Si01 swings right and then up, round the queen's right side, toward the far-side slot.
2. **0.75–1.5 s.** It overshoots above the queen and comes across to the left.
3. **From about 1.5 s.** It whips down the left side as the queen dives, and on past it, ahead and below.

**Sensitivity to the pitch phase.** The x/z path barely depends on the pitch phase: `--sway0` 0 / 1.57 / 3.14 / 4.71 give x(3 s) = −39.5 / −45.6 / −52.3 / −52.0 with z ≈ −10. The y component does depend on it.

Other runs:
- `sims/si01_mk01a_all_3s.txt`: all 10 children (the burst of 5–10);
- `si01_mk01a_child3_3s.txt`: placement 3;
- `si01_mk01b_child1_3s.txt`: `ene_mk01b`;
- `si01_mk01a_child1_32s.txt`: the whole 32 s life. It is removed when the queen leaves at about 31.8 s; there are 31 shots.

## 11. Reconstruction notes (C# event-stack port `Assets/Truxton/Round1EventStack.cs`)

**Si01 needs its own class mover.**
- With an empty program, the stack contributes nothing except the open rule-2 question.
- Pf_Ene_Si01 must be handled like St01/Ss01/So01 (`HasClassMover`): the class owns position and yaw and ends by CallDisabled.
- **It cannot be a per-instance `Pawn()` hook like Sg01/Sm01.** Each Si01 needs:
  - the queen's current position, after the queen's own step that frame;
  - the queen's retarget events (`_rotateTime = 0`) and alive state;
  - the positions of all 10 siblings (the pair impulses run in the queen's frame, before the children step);
  - the player position.
- So it belongs in a queen-plus-children group hook, alongside an Mk01 class mover.

Per-child state:
- `first` (from the spawn offset, with the queen at yaw 180);
- `follow` (Quaternion), `vel` (3D) and the `swayX` RNG draw;
- `swayY = 0`, `rotT = 0`, `rotA = 0`, `shot = 1`.

Rules the port must follow:
1. **Use 3D positions.** The y swing changes the perspective size and position.
2. **Do not apply rule 2** to the Mk01 group until the pioneer confirms it.
3. **End.** Remove all children when the queen leaves, and kill them when the queen is killed (solidarity).
4. **Shots.** Queue `si01_fire` from each Si01 every 1 s.

## 12. Open questions

- **[?] Stack rule 2 at spawn.** z = 120 is outside every rect except AreaW. The same issue applies to Mk01 at z = 150. Possible explanations not yet found: an `_sizeType`, a start delay or IsPlaying gate, or the `_eventStackDelay` start value.
- **[I] Update order.** The queen is assumed to update before its children each frame. If the children ran first, they would use last frame's queen position: a one-frame lag.
- **[I] `queen.localPosition == GetSkyRootPosition(queen)`.** This assumes the queen and the Si01 share the clip root. The player's sky y is assumed to be 0.
- **[I] `AddDead()` on children** (solidarity kill). Not traced: whether it scores, explodes or drops items.
- **[?] BulletFireAsync bools.** The meaning of (false, false) here versus Mk01's (true, true). Also whether firing off screen is suppressed inside BulletFireAsync.
- **[?] Muzzle position.** Whether the leg/body Animators move `ene_hip`.
- **[I] Random phases.** `UnityEngine.Random` draws `_swayX` for each Si01, so the burst of the six stacked Si01 cannot be reproduced exactly. Pioneer telemetry of BG05 252–284 s would confirm the swirl amplitude (r 35–80, speeds up to about 220 u/s) and the altitude spread.
- **[I] Slerp.** Unity `Quaternion.Slerp` is modelled as a standard clamped shortest-path slerp.
