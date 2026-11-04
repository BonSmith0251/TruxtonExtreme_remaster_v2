# Original 3D physics: meteors, PhysicsEnemy nodes, PhysicsAttackAttr

Read-only study of GameAssembly.dll (IL2CPP x64) and the original prefabs. RVAs are image RVAs. `[I]` = inference, `[?]` = unknown.
Disassembly excerpts are in `dis/`. Gameplay hits (player shots, bombs, player body, enemy bullets) do not use this system: they use
KANAI.HybridCollision (2D shapes on `EnemyCollisionModel`, `HybridCollisionBridge.OnTrigger*2D`, Physics2D).

## 1. Settings

- `ProjectSettings/DynamicsManager.asset` matches the pristine export on every relevant field: gravity (0,-9.81,0) (unused, all bodies
  have `useGravity 0`), bounce threshold 2, default max depenetration velocity 10, sleep threshold 0.005, default contact offset 0.01,
  solver iterations 3, velocity iterations 1, max angular speed 7, `m_SimulationMode 2` (Script), `m_AutoSyncTransforms 0`, friction
  type 0 (patch), solver type 0 (PGS). Pristine also has world bounds ±250 with 8 subdivisions (not in the reconstructed file).
- Layer collision matrix: only layer 20 `physics3d` collides with itself. Nothing else collides with anything in 3D.
- Physic materials: `Meteo` (friction 0.6/0.6, bounce 0, friction combine 2 = Minimum, bounce combine 2 = Minimum) on every meteor sphere;
  `Enemies` (0.6/0.6, bounce 0, combine 0 = Average) on most enemy physics colliders; Mc01 and Mo01 colliders have no material
  (default 0.6/0.6/0). With combine Minimum on the meteor side (Minimum outranks Average), every meteor contact uses friction 0.6,
  bounciness 0. Restitution is 0 everywhere: contacts are inelastic (no bounce).
- Whole-game scan (`dis/physics_api_callers.txt`): the only game code that touches a Rigidbody is PhysicsMove (AddForce, AddTorque,
  ResetInertiaTensor, WakeUp, Sleep, setting velocity / angular velocity to zero). No game code sets maxDepenetrationVelocity,
  maxAngularVelocity, drag, sleepThreshold, solver iterations, constraints, IgnoreCollision or IgnoreLayerCollision. There are no speed
  caps. Only Unity defaults and prefab values apply.

## 2. Stepping: `PhysicsUpdater.ProgressLate(dt)` 0x1D3B310

Called from `InGameManager.LateUpdate` 0x1CE8580 with the play-time delta `_playTimeFactor+0x18` (scaled, 0 while paused). It runs after
`CollisionUpdateSolution` (gameplay hits), so gameplay hits see the previous frame's physics result.

```
_physicsStep += dt
if _physicsStep >= fixedStep (0.02, .cctor 0x1D3B7D0):
    Physics.SyncTransforms()
    while _physicsStep >= 0.02: Physics.Simulate(0.02); _physicsStep -= 0.02
    foreach IPhysicsUpdater in _physicsObjectList (HashSet): ApplyTransformFromPhysics()   // interface slot 1
if dt > 0: Physics2D.Simulate(dt)
```

- The step is fixed at 0.02 s (50 Hz) and the leftover time carries over. ApplyTransformFromPhysics runs only on frames that ran at least
  one step. At 60 fps that is 5 frames in 6.
- `Add`/`Remove` 0x1D3B280/0x1D3B770 work on a HashSet. `InGameManager.AddPhysicsObject` 0x1CE2460 adds the object and, if it was not
  already in the set, reparents the given transform under `_physicsRoot` (the PhysicsUpdater's own transform), with
  `SetParent(root, false)` so the local pose is kept. `Refresh`/`Terminate` 0x1D3B620 call ProgressTerminate (slot 0) on every object
  and clear the set.
- Physics space = `_inGameRoot` local space [I]. PhysicsMove writes `root.localPosition = node.position`. PhysicsEnemy places node 0 at
  `_inGameRoot.InverseTransformPoint(origin.position)`. Both assume `_physicsRoot` is at the world origin with identity rotation and
  scale. Where `_physicsRoot` sits in the scene: [?] (it is a serialized reference in the InGame scene, `InGameManager+0x148`).

## 3. Who is on physics3d at runtime

`LayerUtility.PhysicsLayer` (static +0x3C) = `LayerMask.NameToLayer("physics3d")` = 20 (.cctor 0x1DD85E0). `LayerUtility.SetLayerForce`
0x1DD7E30 sets the layer on the object and all its descendants. It is called with PhysicsLayer only by:
- `PhysicsMove.ProgressInitialize` 0x1D190D0 on the meteor's `physics_xx` node (prefab layer 14 neutralObject becomes 20);
- `PhysicsEnemy.ProgressInitialize` 0x1D18A00 on the PhysicsEnemy node (prefab layer 10/11 becomes 20).

So the prefab layers (14, 11, 10) are overwritten at initialization. Afterwards `LayerUtility.SetEnemyLayer` 0x1DD7AF0 only changes
objects whose layer is None/enemy/enemySky/enemyGround, so it leaves physics3d alone. One exception: `PawnEnemy.SetEnemyLayer`
0x1D0F830 with Division Ground (1) calls `SetLayerForce(enemyGround)` on the whole enemy root. A Ground-division PhysicsEnemy whose node
is still under its root at that moment would lose physics3d [?]. None of the PhysicsEnemy users below are known to be Ground; check
before porting.

Every object with a physics3d collider (110 enemy prefabs, Bos03 and the Reference enemy prefabs scanned for the PhysicsEnemy,
PhysicsLb01, PhysicsMove, PhysicsAttackAttr and MeteoEnemy scripts):

| Prefab | Physics node (component) | Colliders (local, before node scale) | Rigidbody |
|---|---|---|---|
| Meteo_Sa01 / Sa02 | `physics_sa0x` (PhysicsMove) | sphere r 7 / 8, material Meteo | dynamic, mass 7 |
| Meteo_Ma01 / Ma02 | `physics_ma0x` (PhysicsMove) | sphere r 13 | dynamic, mass 12 |
| Meteo_La01 / La02 | `physics_la0x` (PhysicsMove) | sphere r 24 | dynamic, mass 22 |
| Lb01 | `physicsLb` (PhysicsLb01, 9 nodes) | head: 2 trigger spheres r 25 at (±19,0,10), node scale 1.15; cbody1..7: box 30×70×23, centre z −14.5; ctail: box 30×70×40, centre z −18 | kinematic, mass 1, on head, cbody1..7, ctail |
| Bos03 | `physics_bos03` (PhysicsEnemy) | Bs03Body: 3 trigger capsules (r 40 h 110 Z axis; r 25 h 40 Z axis at (±42,10,−5)), has PhysicsAttackAttr | none |
| Sl01 | `physics_sl` | capsule r 10 h 25, Z axis | none |
| Ma01 | `physics_ma` | capsule r 22.5 h 70, Z axis | none |
| Mb01 | `physics_mb` | capsule r 25 h 70, Z axis | none |
| Mc01 | `physics_mc` | box 25×30×30 centre y 5, no material | none |
| Md01 | `physics_md` | capsule r 20 h 50, **Y** axis, centre (0,10,2) | none |
| Mi01 | `physics_mi` | capsule r 30 h 75, Z axis | none |
| Mj01b | `physics_mjb` | box 20×50×20 | none |
| Mj01h | `physics_mjh` | capsule r 15 h 45, **Y** axis | none |
| Mo01 | `physics_mo01` | 2 boxes 50×1×12 and 12×1×50, sphere r 15, no material | none |
| Mp01 / Mp02 | `physics_mp` / `physics_mp2` | capsule r 10, h 60 / 90, X axis | none |
| Mq01 | `physics_mq` | capsule r 16 h 150, X axis, centre z −4.5 | none |

All of these colliders are non-trigger except Lb01's head and Bos03's body. Colliders without a Rigidbody are static colliders that the
code teleports every frame. The Y-axis capsules of Md01 and Mj01h act as circles in the XZ plane. No player, bullet, bomb, item or
background object is ever put on physics3d.

## 4. PhysicsMove (meteors)

Fields: `_parent` 0x20 (meteor root), `_enemy` 0x28, `_mover` 0x30, `_rigidbody` 0x38, `_prate` 0x40, `_rotNow` 0x44, `_rotOld` 0x54,
`_transformCache` 0x68 (physics node), `_modelTop` 0x70, `_angularVelocity` 0x78, `_rotateVector` 0x84, `_isMovestepEnd` 0x90.
Statics: `_RotateScale` = 0.5, `MeteoTag` = "Meteo" (.cctor 0x1D199E0). IEnemyUpdater priority 200 (0x1CFEBB0).

- `ProgressInitialize` 0x1D190D0: SetLayerForce(physics3d); cache transform, parent, enemy, `mover = enemy+0xB8`,
  `modelTop = enemy+0x168`; TryGetComponent<Rigidbody>, then SleepRigidBody; if `enemy.IsPhysicsMove()` (vtable 0x548, true only for
  MeteoEnemy 0x60A0D0) set tag "Meteo"; `_isMovestepEnd = 0`.
- `ProgressStart` 0x1D19320 (on spawn):
  `yaw = (Make01()*20 − 10)°`;
  `_rotateVector = (mover._firstRotate(+0x170) * Euler(0, yaw, 0)) * Vector3.forward`;
  `_angularVelocity = (Range(−1,1), Range(−1,1), Range(−1,1)) * 0.5`.
- `Progress(dt)` 0x1D19790:
  if `!_isMovestepEnd && enemy.IsAlive()` (vtable 0x1B8) then call `_initializeRigid()` and set `_isMovestepEnd = 1`. So the body
  launches on the first Progress after spawn.
  Then, if dt > 0: `_prate += dt`; `t = clamp01(_prate / 0.02)`; `modelTop.localRotation = Lerp(_rotOld, _rotNow, t)`. `_prate` is never
  reset, so after the first 0.02 s, t stays 1 and the model simply shows the body's latest rotation [I, this looks like a bug, but it
  is what the code does].
- `_initializeRigid` 0x1D19B00: `AddPhysicsObject(this, node)` moves the node under the physics root. If that succeeds:
  `node.position = root.localPosition`; ResetInertiaTensor;
  `AddForce(mover._currentSpeed(+0x164) * _rotateVector, VelocityChange)`, which sets the launch velocity directly;
  `AddTorque(_angularVelocity, VelocityChange)`; WakeUp.
- `ApplyTransformFromPhysics` 0x1D18EE0 (after the steps):
  `root.localPosition = node.position`; `_rotOld = _rotNow`; `_rotNow = node.rotation`.
  From then on the root follows the body. Whether EnemyMover also keeps writing the root: [?]. If it does, physics overwrites it on every
  frame that ran a step.
- `MoveStepEnd` 0x1D18F70 (from ProgressEnd, ProgressDisable, OnDestroy and ProgressTerminate): if `_isMovestepEnd` and the enemy is not
  null: RemovePhysicsObject; `node.SetParent(root, false)`; `node.localPosition = 0`; SleepRigidBody; `_isMovestepEnd = 0`.
- `SleepRigidBody` 0x1D19900: `Sleep()`, then velocity and angular velocity set to zero.
- `SetSuside` 0x1D198E0: forwards to `PawnEnemy.SetSuside` (no in-game caller found).
- Rigidbody (prefab): drag 0, angular drag 0.05, useGravity 0, not kinematic, interpolation none, collision detection Discrete,
  constraints 4 (FreezePositionY). Rotation is free on all three axes. Node and root scale are 1.
- MeteoEnemy (0x1D0C4A0–0x1D0C5F0): `InitializeToPlay` stores a random rotation and `GetStart` applies it to `_modelTop`.
  `ProgressEvent`:
  - while `mover._isInGamePlayArea` (+0x291): set `_inScreen = 1`; `_limitTtimer += dt`; once it passes 15 s, set `_deathByPno = 0`,
    call `_callDeadEffect()`, then `CallDisabled()` (the meteor self-destructs with its explosion);
  - when outside the play area: if `_inScreen` was already set, `CallDisabled()` at once; otherwise `CallDisabled()` once
    `_outScreenTime` passes 5 s.

## 5. PhysicsEnemy / PhysicsLb01 (kinematic followers)

Fields: `_parent` 0x20, `_transformCache` 0x28, `_isDone` 0x30, `_isAttked` 0x31, `_node` 0x38 (NodeData[]: `_origins` +0,
`_targets` +8), `_attkAttr` 0x40, `_nodeCount` 0x48. PhysicsLb01 is an empty subclass (`.ctor` only). Priority 0x12D = 301, which is
after the movers (Late = 300), so the nodes copy the model pose after that frame's movement.

PawnEnemy drives the updaters through `_updateEvents` (+0xA8). Slots: 0 Initialize, 1 Reset, 2 Start, 3 Progress, 4 Terminate, 5 End,
6 Disable, 7 Priority. Callers: `GetStart` → ProgressStart, `ProgressEvent` / `LocalLateUpdate` → Progress,
`ToDestroid` / `ToProgressEnd` → ProgressEnd, `CallDisabled` / `ProgressDisable` → ProgressDisable.

- `ProgressInitialize` 0x1D18A00: SetLayerForce(physics3d); cache transform and parent; `_nodeCount = _node.Length`; `AttkAttr(false)`.
- `ProgressStart` 0x1D18AE0: NodeReset; `AddPhysicsObject(this, transform)` (the node leaves the enemy hierarchy and goes under the
  physics root); NodeReset again; `_isDone = _isAttked = 0`.
- `Progress` 0x1D18B90: `if (!_isDone) UpdatePositions()`.
- `UpdatePositions` 0x1D18BA0 (every enemy frame):
  ```
  R = InGameManager._inGameRoot (+0x88)
  node[0].target.SetPositionAndRotation(R.InverseTransformPoint(o0.position), R.InverseRotation(o0.rotation))
  for i = 1 .. n-1:
      p = o0.InverseTransformPoint(oi.position); p.y = 0
      node[i].target.SetLocalPositionAndRotation(p, o0.InverseRotation(oi.rotation))
  if !_isAttked: _attkAttr.gameObject.SetActive(true); _isAttked = 1
  ```
  `ApplyTransformFromPhysics` is empty (0x5BCDB0), so physics never moves these enemies.
- `ProgressEnd` / `ProgressDisable` 0x1D189E0 call DetachObject and set `_isDone = 1`.
- `DetachObject` 0x1D18780: RemovePhysicsObject; if the parent is still alive, `SetParent(_parent, false)`; NodeReset;
  `AttkAttr(false)` if it was active.
- `NodeReset` 0x1D188D0: each target gets its origin's localPosition and localRotation.
  `NodeData.Reset`/`SetLocal`/`SetWorld` (0x1D16DB0/E50/EA0) are plain setters and are not called by the game.
- `AttachObject` 0x1D18640 (AddPhysicsObject + NodeReset): no caller found.

### Lb01

The node mapping in the prefab:
- node 0: origin `Pf_Ene_Lb01` (the root) → target `physicsLb`;
- nodes 1..7: origins `ene_lb01_body021`..`027` → targets `cbody1`..`7`;
- node 8: origin `ene_lb01_body03` → target `ctail`;
- `head` is a child of `physicsLb` with local pose 0, so it rides on node 0.

Because EnemyMoverSnake bends those bones along the route (see `movers/Ene_Lb01/SPEC.md`), the boxes follow the bent snake each frame,
in the root's frame with y flattened to 0.

The boxes are kinematic Rigidbodies moved by setting the transform (teleported, not MovePosition). PhysX therefore gives them no
velocity, and meteors are pushed out only by depenetration, at up to 10 units/s [I, standard PhysX behaviour for teleported kinematic
bodies].

The bodies leave as soon as the Lb01 PawnEnemy is destroyed or disabled (ToDestroid → ProgressEnd). The staged segment explosions that
follow have no physics bodies [I, from the caller list; the segment-by-segment death timing is in the multipart spec].

## 6. PhysicsAttackAttr.OnTriggerEnter(Collider) 0x1D18570

```
go = other.gameObject
if go.CompareTag("Meteo") && go.TryGetComponent<PhysicsMove>(out pm) && pm._enemy != null:
    pm._enemy.SetSuside()        // PawnEnemy.SetSuside 0x1D0FE00
```

`SetSuside`: if `_causeOfDeath == −1`, set `_causeOfDeath = 0x6F` (111), `_deathByPno = −1` (no player credit) and
`_isExboostDead = 0`; then call `AddDead()` (vtable 0x2F8), so the meteor dies through the normal death path.

The trigger does no damage to the player, to the owning enemy or to any non-meteor object. It is the only 3D collision callback in the
game code. Users: Lb01's head (2 spheres) and Bos03's body (3 capsules). The trigger object is disabled until the first UpdatePositions
and disabled again on detach.

## 7. Resulting rules

- **Enemy vs enemy:** no physical interaction. Only meteors are dynamic. PhysicsEnemy colliders are static or kinematic and never feed
  back into the enemy (empty ApplyTransformFromPhysics), and static vs kinematic pairs do not collide.
- **Meteor vs enemy:** a meteor collides with the physics3d colliders of Lb01, Sl01, Ma01, Mb01, Mc01, Md01, Mi01, Mj01b, Mj01h, Mo01,
  Mp01, Mp02 and Mq01, using the collider shapes above (not the HybridCollision hit circles). Those enemies teleport their colliders
  every frame. The meteor is pushed out by PhysX contact and depenetration (max 10 units/s, inelastic, friction 0.6), and the enemy is
  never moved. Touching Lb01's head or Bos03's body kills the meteor instead (SetSuside). Every other enemy is not in 3D physics, and
  meteors pass through it.
- **Meteor vs meteor:** ordinary PhysX rigid-body contact between spheres, with masses 7 / 12 / 22, restitution 0, friction 0.6,
  angular drag 0.05, no linear drag, Y frozen, 3 position and 1 velocity solver iterations, 0.02 s steps, sleep threshold 0.005.
- **Meteor vs player, bullets or bombs:** no physical effect. Damage and hits go through HybridCollision (meteor circle r 12,
  attribute 4, HP 100, `_isLaserBlock 1`).

## 8. Remaster port (2026-11-04)

- Removed the remaster-only rules: `Round1Combat.SeparateAir` (enemies pushed each other and were pushed by meteors, up to
  0.15 viewport height off their paths), enemy bullets stopped by any enemy (now only meteors stop them), and the meteor
  solver's "every enemy hit circle is an obstacle" with full projection out of overlaps.
- `tools/stage_combat/physics_colliders.py` writes `Resources/StageCombat/physics-colliders.json` (the 13 users + Bos03).
  `Round1EnemyWaves.ObstaclesFromEnemies` places them each frame per sec. 5 (node 0 from its origin, node i relative with y 0),
  after the movers and before the physics step; `Round1MeteorField` collides meteors with them and each other (inelastic,
  friction 0.6, depenetration ≤ 10 units/s, enemy colliders immovable, triggers → SetSuside). Meteors follow the MeteoEnemy
  lifetime (15 s in the play area, 5 s if never in). Meteor sizes fixed for the 01 variants (Sa01 r 7; Ma01/La01 were small).
- Adaptations [I]: shapes are placed where the enemy is drawn (its projection scaled into the meteors' 200-unit frame);
  enemy altitude is ignored (all on the stage plane); the meteor play area uses the Small margin (±0.15).
- Stage play BG03 (no fire, to 279 s): Lb01 9 nodes, Md01 and Ma01 colliders built; 88 meteors killed by Lb01's head,
  14 by the 15 s limit; no errors, no crash (`verification/collision-20261104/`).

## 9. Open points

- `[?]` The scene pose of `_physicsRoot`, and whether EnemyMover keeps writing the meteor root after launch. Check with a telemetry run.
- `[?]` The Division of each PhysicsEnemy user, relevant to the SetLayerForce(enemyGround) exception in section 3.
