using System.Collections.Generic;
using UnityEngine;

// Remaster combat with the authored BG03 spawn director and extracted enemy visuals.
[DefaultExecutionOrder(150)]
public class Round1Combat : MonoBehaviour
{
    public Round1Weapon weapon;
    public RoundBoss boss;
    public Round1EnemyWaves sourceWaves;
    public Round1EnemyAttacks sourceAttacks;
    public Round1PickupDrones pickupDrones;
    public Round1GroundEnemies groundEnemies;
    // Original hit and blast effects, the damage blink and the hit flash.
    public readonly Round1Effects effects=new Round1Effects();
    public GameObject enemyPrefab,hostileBulletPrefab;
    public bool automaticWaves=true;
    // Stage scenes other than BG03: no BG03 pickup-drone or ground-enemy schedule (both are BG03 data), and the round
    // clears when the stage timeline reaches clearAt (their bosses are not reconstructed).
    public bool bg03Schedules=true;
    public float clearAt=-1;
    public int enemyCapacity=32,bulletCapacity=160;
    public class Target { public int id,homingPriority=1000;public bool lockOn=true,blocksLaser=true,isPickupDrone;public Round1PickupKind pickupKind; public GameObject visual,template; public Vector2 position; public float health,maxHealth,age,fire,radius=.024f,fireInterval=1.8f,sourceScale,sourceYaw; public Quaternion sourceRotation=Quaternion.identity; public Round1EnemyAnimation animation; public bool active,fires,stationary,isBoss,invulnerable,sourceSpawn,ground,touchesWhileInvulnerable,noShipContact;public int bossPart,score;
        // Original hit shape as circles (x, y offset from position in viewport-height units, already turned; z radius).
        // When null the target is the single circle `radius`.
        public Vector3[] hitCircles;
        // Meteors move by Round1MeteorField; other air enemies carry a screen nudge that keeps them off each other.
        public bool physicsBody;public Vector2 nudge;public float solidRadius;
        // Parts of one multi-part enemy (Mj01's head and body segments) share a chain id: they overlap by design and are
        // not pushed apart from each other.
        public int chain; }
    class Hostile { public GameObject visual,template; public Vector2 position,velocity; public bool active,source; public float age;public int shooter;public Renderer renderer;public string resident; }
    // Cause of the lethal hit (PawnEnemy cause of death): only player-weapon kills fire death bullets; bombs, the ship's
    // body and boss bookkeeping do not (evidence/death-bullets/SPEC.md).
    public const int CauseWeapon=0,CauseBomb=1,CauseContact=2,CauseScript=3;
    public int DamageCause=CauseWeapon;
    public int ShotBullets { get; private set; }
    readonly List<Target> enemies=new List<Target>();
    readonly List<Hostile> bullets=new List<Hostile>();
    Transform root;
    bool initialized;
    int serial;
    public int Kills { get; private set; }
    public int ActiveEnemies { get { int n=0;foreach(var e in enemies)if(e.active)n++;return n; } }
    public int HostileCount { get { int n=0;foreach(var b in bullets)if(b.active)n++;return n; } }
    public IReadOnlyList<Target> Targets => enemies;
    public void CopyPilotHazards(List<Round1Autopilot.Hazard> output)
    {
        foreach(var b in bullets)if(b.active)
            output.Add(new Round1Autopilot.Hazard{from=new Vector2(b.position.x*Aspect,b.position.y),velocity=b.velocity,radius=.016f,ends=Mathf.Max(0,7-b.age)});
        if(sourceAttacks)sourceAttacks.CopyPilotHazards(output);
    }
    public int BulletCapacityMisses { get; private set; }
    public Vector2[] HostileVelocities { get {var result=new List<Vector2>();foreach(var b in bullets)if(b.active)result.Add(b.velocity);return result.ToArray();} }
    public void Initialize()
    {
        if(initialized || !weapon || !enemyPrefab || !hostileBulletPrefab)return;
        root=new GameObject("Combat pools").transform;
        for(int i=0;i<enemyCapacity;i++)
        {
            var go=Instantiate(enemyPrefab,root);go.name="Enemy "+i;
            foreach(var ps in go.GetComponentsInChildren<ParticleSystem>(true))ps.gameObject.SetActive(false);
            foreach(var c in go.GetComponentsInChildren<Collider>(true))c.enabled=false;
            go.SetActive(false);enemies.Add(new Target{visual=go,template=enemyPrefab});
        }
        for(int i=0;i<Mathf.Max(1024,bulletCapacity);i++){var go=Instantiate(hostileBulletPrefab,root);go.SetActive(false);bullets.Add(new Hostile{visual=go,template=hostileBulletPrefab,renderer=go.GetComponentInChildren<MeshRenderer>(true)});}
        initialized=true;effects.Initialize(root,weapon.player);
        if(!sourceAttacks)sourceAttacks=GetComponent<Round1EnemyAttacks>();
        if(!sourceAttacks)
        {
            // A runtime-added attack component follows the scene's schedule mode, so an Arcade scene keeps Arcade bullets.
            sourceAttacks=gameObject.AddComponent<Round1EnemyAttacks>();
            if(sourceWaves && sourceWaves.gameModeMask==Round1EnemyWaves.Arcade1Mask)sourceAttacks.selectorMode=Round1EnemyAttacks.ArcadeSelectorMode;
        }
        sourceAttacks.Initialize(this);
        if(!pickupDrones)pickupDrones=GetComponent<Round1PickupDrones>();
        if(!pickupDrones&&bg03Schedules)pickupDrones=gameObject.AddComponent<Round1PickupDrones>();
        if(pickupDrones){pickupDrones.Initialize(this);pickupDrones.ResetSchedule(weapon.player.playback.elapsed);}
        if(!groundEnemies)groundEnemies=GetComponent<Round1GroundEnemies>();
        if(!groundEnemies&&bg03Schedules)groundEnemies=gameObject.AddComponent<Round1GroundEnemies>();
        if(groundEnemies){groundEnemies.Initialize(this);groundEnemies.ResetSchedule(weapon.player.playback.elapsed);}
    }
    // Original prefabs carry the game's own components, whose recovered methods are throw-null stubs. Instantiate under
    // an inactive holder (no Awake), strip them, then move under the combat root. Remaster prefabs have none.
    Transform cleanHolder;
    GameObject InstantiateClean(GameObject prefab)
    {
        if(!cleanHolder){var h=new GameObject("Spawn holder (inactive)");h.hideFlags=HideFlags.DontSave;h.SetActive(false);cleanHolder=h.transform;}
        var go=Instantiate(prefab,cleanHolder);StageEnemies.StripStubBehaviours(go);go.transform.SetParent(root,false);return go;
    }
    void Start(){Initialize();}
    void LateUpdate(){Step(Time.deltaTime);}
    public Target SpawnTarget(Vector2 position,float health=8,bool fires=false,bool stationary=true)
    {return SpawnTargetVisual(enemyPrefab,position,health,fires,stationary);}
    public Target SpawnSourceTarget(GameObject prefab,Vector2 position,float health)
    {var target=SpawnTargetVisual(prefab,position,health,false,true);if(target!=null)Round1WeaponBehavior.Current.Configure(target,prefab.name);return target;}
    Target SpawnTargetVisual(GameObject prefab,Vector2 position,float health,bool fires,bool stationary)
    {
        Initialize();var e=enemies.Find(x=>!x.active && !x.isBoss && !x.ground && x.template==prefab)??enemies.Find(x=>!x.active && !x.isBoss && !x.ground);if(e==null)return null;
        if(e.template!=prefab)
        {
            if(Application.isPlaying)Destroy(e.visual);else DestroyImmediate(e.visual);
            e.visual=InstantiateClean(prefab);e.template=prefab;
            foreach(var ps in e.visual.GetComponentsInChildren<ParticleSystem>(true))ps.gameObject.SetActive(false);
            foreach(var c in e.visual.GetComponentsInChildren<Collider>(true))c.enabled=false;
        }
        e.id=++serial;e.position=position;e.health=e.maxHealth=Mathf.Max(1,health);e.age=0;e.fire=1.2f;e.fires=fires;e.stationary=stationary;e.active=true;
        e.animation=e.visual.GetComponent<Round1EnemyAnimation>();if(e.animation)e.animation.ResetPose();e.sourceRotation=Quaternion.identity;
        e.lockOn=e.blocksLaser=true;e.homingPriority=1000;e.isPickupDrone=false;e.score=0;
        e.radius=.024f;e.hitCircles=null;e.physicsBody=false;e.nudge=Vector2.zero;e.solidRadius=0;e.invulnerable=false;e.sourceSpawn=false;e.fireInterval=1.8f;e.chain=0;
        e.visual.SetActive(true);Place(e);return e;
    }
    public Target RegisterBoss(GameObject visual,Vector2 position,float health,float radius,string model="Pf_Ene_Bos03")
    {
        Initialize();var target=new Target{id=++serial,visual=visual,position=position,health=health,maxHealth=health,radius=radius,active=true,stationary=true,isBoss=true,invulnerable=true};
        Round1WeaponBehavior.Current.Configure(target,model);enemies.Add(target);effects.bossVisual=visual;return target;
    }
    // A breakable boss part (PartsList entry) is its own hit target; it is listed before the body so a shot
    // landing where both overlap breaks the part first, as the part's own collision models do in the original.
    public Target RegisterBossPart(GameObject visual,Vector2 position,float health,float radius,int part,string model="Pf_Ene_Bos03")
    {
        var target=RegisterBoss(visual,position,health,radius,model);target.bossPart=part;target.lockOn=false;target.visual=null; // The boss hides broken parts itself.
        enemies.Remove(target);int body=enemies.FindIndex(e=>e.isBoss && e.bossPart==0);enemies.Insert(body<0?enemies.Count:body,target);return target;
    }
    // BG03_ge ground enemy: its visual stays at its stage world position; position is its viewport projection.
    public Target RegisterGround(GameObject visual,Vector2 position,float health,float radius)
    {
        Initialize();var target=new Target{id=++serial,visual=visual,position=position,health=health,maxHealth=health,radius=radius,active=true,stationary=true,sourceSpawn=true,ground=true};
        Round1WeaponBehavior.Current.Configure(target,visual.name);enemies.Add(target);return target;
    }
    public void RemoveGround(Target target){Deactivate(target);enemies.Remove(target);}
    public void ClearRegularEnemies(){foreach(var e in enemies)if(!e.isBoss)Deactivate(e);ClearHostiles();}
    public void SpawnHostile(Vector2 position,Vector2 velocity,int shooter=0)
    {SpawnHostileVisual(position,velocity,hostileBulletPrefab,false,shooter);}
    public bool SpawnSourceHostile(Vector2 position,Vector2 velocity,GameObject prefab,int shooter=0)
    {return SpawnHostileVisual(position,velocity,prefab,true,shooter);}
    bool SpawnHostileVisual(Vector2 position,Vector2 velocity,GameObject prefab,bool source,int shooter)
    {
        Initialize();var b=bullets.Find(x=>!x.active && x.template==prefab)??bullets.Find(x=>!x.active);
        if(b==null){BulletCapacityMisses++;return false;}
        if(b.template!=prefab)
        {
            if(Application.isPlaying)Destroy(b.visual);else DestroyImmediate(b.visual);
            b.visual=InstantiateClean(prefab);b.template=prefab;b.renderer=b.visual.GetComponentInChildren<MeshRenderer>(true);
            foreach(var c in b.visual.GetComponentsInChildren<Collider>(true))c.enabled=false;
        }
        b.position=position;b.velocity=velocity;b.active=true;b.source=source;b.shooter=shooter;b.age=0;b.visual.SetActive(true);
        b.resident=sourceAttacks?sourceAttacks.ResidentDeathBullet(prefab?prefab.name:null):null;Place(b);return true;
    }
    public void Step(float dt)
    {
        Initialize();if(!initialized || !weapon.SimulationRunning)return;
        dt=Mathf.Max(0,dt);
        if(automaticWaves && sourceWaves)sourceWaves.Step(weapon.player.playback.elapsed);
        if(automaticWaves && pickupDrones)pickupDrones.Step(weapon.player.playback.elapsed);
        if(automaticWaves && groundEnemies)groundEnemies.Step(weapon.player.playback.elapsed);
        if(automaticWaves)
        {
            // Enemies give way to meteors and meteors to enemies; alternate so a pinched group settles within the frame.
            SeparateAir(dt);
            for(int i=0;i<SettleRounds && sourceWaves;i++){sourceWaves.SettleMeteors(weapon.player.playback.elapsed);SeparateAir(0);}
        }
        foreach(var e in enemies)
        {
            if(!e.active)continue;
            if(e.isBoss)
            {
                // A boss with its original hit circles (StageBoss) touches the ship through them; e.radius is only their outer reach.
                if(!e.noShipContact && (!e.invulnerable||e.touchesWhileInvulnerable) && (e.hitCircles!=null?HitGap(e,weapon.player.viewportPosition,weapon.player.viewportPosition):Distance(e.position,weapon.player.viewportPosition)-e.radius)<.012f && weapon.TakeHit()){BodyContacts++;BodyContactLog.Add("boss@"+weapon.player.playback.elapsed.ToString("0.0")+"/b"+e.position.ToString("0.00")+"/p"+weapon.player.viewportPosition.ToString("0.00"));}
                continue;
            }
            if(e.ground)continue; // Round1GroundEnemies places it; ground enemies never touch the ship.
            e.age+=dt;
            if(!e.stationary && !e.sourceSpawn)e.position+=new Vector2(Mathf.Sin(e.age*1.5f+e.id)*.025f,-.045f)*dt;
            if(!e.sourceSpawn && e.position.y<-.12f){Deactivate(e);continue;}
            e.fire-=dt;
            if(!e.sourceSpawn && e.fires && e.fire<=0 && weapon.CanAct && e.position.y>0 && e.position.y<1 && e.position.x>0 && e.position.x<1)
            {
                Vector2 direction=weapon.player.viewportPosition-e.position;direction.x*=Aspect;
                SpawnHostile(e.position,direction.normalized*.32f,e.id);e.fire=e.fireInterval;
            }
            // An invulnerable enemy (e.g. a deploying Sd02 below the plane) has no collision with the ship either.
            if(!e.invulnerable && HitGap(e,weapon.player.viewportPosition,weapon.player.viewportPosition)<ShipRadius && weapon.TakeHit()){BodyContacts++;BodyContactLog.Add((e.template?e.template.name:"?")+"@"+weapon.player.playback.elapsed.ToString("0.0"));DamageCause=CauseContact;Damage(e,e.health);DamageCause=CauseWeapon;}
            Place(e);
        }
        if(sourceAttacks)sourceAttacks.Step(weapon.player.playback.elapsed);
        effects.Step(weapon.player.playback.elapsed);
        foreach(var e in enemies){if(effects.Blinks(e))effects.Blink(e,dt);effects.DamageSmoke(e);}
        foreach(var b in bullets)
        {
            if(!b.active)continue;
            Vector2 previous=b.position;b.position+=new Vector2(b.velocity.x/Aspect,b.velocity.y)*dt;b.age+=dt;
            if(weapon.BombActive || SegmentDistance(weapon.player.viewportPosition,previous,b.position)<.016f)
            {
                if(!weapon.BombActive)weapon.TakeHit();b.active=false;b.visual.SetActive(false);continue;
            }
            if(Blocked(b,previous)){b.active=false;b.visual.SetActive(false);BlockedHostiles++;continue;}
            if(b.age>7 || b.position.y<-.1f || b.position.y>1.2f || b.position.x<-.1f || b.position.x>1.1f){b.active=false;b.visual.SetActive(false);continue;}
            Place(b);
        }
    }
    float Aspect => Mathf.Max(.1f,weapon.player.stageCamera.aspect);
    public float Distance(Vector2 a,Vector2 b){var d=a-b;d.x*=Aspect;return d.magnitude;}
    public float SegmentDistance(Vector2 point,Vector2 a,Vector2 b)
    {
        point.x*=Aspect;a.x*=Aspect;b.x*=Aspect;var v=b-a;
        return Vector2.Distance(point,a+v*(v.sqrMagnitude>0?Mathf.Clamp01(Vector2.Dot(point-a,v)/v.sqrMagnitude):0));
    }
    // Distance from a segment to the target's hit shape (negative inside), in viewport-height units.
    public float HitGap(Target e,Vector2 a,Vector2 b)
    {
        if(e.hitCircles==null)return SegmentDistance(e.position,a,b)-e.radius;
        float gap=float.MaxValue;
        foreach(var c in e.hitCircles)gap=Mathf.Min(gap,SegmentDistance(CirclePosition(e,c),a,b)-c.z);
        return gap;
    }
    public Vector2 CirclePosition(Target e,Vector3 circle)=>e.position+new Vector2(circle.x/Aspect,circle.y);
    // Turns source-unit hit circles (x, z, r) by the enemy's facing and scales them into viewport-height units: offsets by
    // the enemy's own projection (offsetScale), radii by the collision space's scale (radiusScale).
    public static void SetHitCircles(Target e,Vector3[] shape,Quaternion facing,float offsetScale,float radiusScale)
    {
        if(shape==null){e.hitCircles=null;return;}
        if(e.hitCircles==null || e.hitCircles.Length!=shape.Length)e.hitCircles=new Vector3[shape.Length];
        float reach=0;
        for(int i=0;i<shape.Length;i++)
        {
            var o=facing*new Vector3(shape[i].x,0,shape[i].y);
            e.hitCircles[i]=new Vector3(o.x*offsetScale,o.z*offsetScale,shape[i].z*radiusScale);
            reach=Mathf.Max(reach,new Vector2(e.hitCircles[i].x,e.hitCircles[i].y).magnitude+e.hitCircles[i].z);
        }
        e.radius=reach;
    }
    // Remaster rule (the original lets enemies overlap): air enemies never overlap each other or a meteor on screen. Each
    // scripted enemy keeps a nudge that pushes it off anything it touches and eases back to its authored path
    // (NudgeReturn seconds) once clear; owners add the nudge when they set a target's path position each frame. Meteors
    // (solidRadius, moved by Round1MeteorField, which also keeps them off these enemies) don't move here; an enemy gives
    // way to a meteor by their size (circle area), so a pinched meteor is freed while a big enemy like Lb01 hardly moves.
    // Two enemies give way to each other by size as well. A nudge is held to MaxNudge (viewport height) off the path at
    // the start of each frame; an enemy at that limit stops giving way and the other enemy takes the whole push, but when
    // both are at it they still split the push, so the limit gives before the no-overlap rule does. Ground enemies and
    // the boss are left alone.
    const float NudgeReturn=.6f,MaxNudge=.15f;const int SeparationIterations=16,SettleRounds=3;
    readonly List<Target> air=new List<Target>(),solid=new List<Target>();
    void SeparateAir(float dt)
    {
        air.Clear();solid.Clear();
        foreach(var e in enemies)if(e.active && e.sourceSpawn && !e.ground && !e.isBoss && e.visual)(e.physicsBody?solid:air).Add(e);
        float keep=dt>0?Mathf.Exp(-dt/NudgeReturn):1;
        foreach(var e in air){var back=e.nudge*(1-keep);e.position-=back;e.nudge-=back;Clamp(e);}
        for(int k=0;k<SeparationIterations;k++)
        {
            bool moved=false;
            for(int i=0;i<air.Count;i++)
            {
                for(int j=i+1;j<air.Count;j++)if(air[i].chain==0 || air[i].chain!=air[j].chain)moved|=Push(air[i],air[j],Share(air[i],air[j]));
                foreach(var m in solid)moved|=Push(m,air[i],1-Area(m)/(Area(m)+Area(air[i])));
            }
            if(!moved)break;
        }
        foreach(var e in air)Place(e);
        float Area(Target e){float a=0;foreach(var c in Circles(e))a+=c.z*c.z;return a;}
        bool AtLimit(Target e)=>e.nudge.magnitude>=MaxNudge-1e-4f;
        void Clamp(Target e){if(e.nudge.magnitude>MaxNudge){var clamped=e.nudge.normalized*MaxNudge;e.position+=clamped-e.nudge;e.nudge=clamped;}}
        // a's part of a push between two enemies: the smaller one moves more; one at its nudge limit doesn't move.
        float Share(Target a,Target b)
        {
            bool la=AtLimit(a),lb=AtLimit(b);
            if(la!=lb)return la?0:1;
            float aa=Area(a),ab=Area(b);return aa+ab>0?ab/(aa+ab):.5f;
        }
        // Moves the deepest-overlapping circle pair of a and b apart (a takes share of it) in aspect-corrected viewport units.
        bool Push(Target a,Target b,float share)
        {
            float depth=0;Vector2 normal=Vector2.zero;
            foreach(var ca in Circles(a))foreach(var cb in Circles(b))
            {
                var d=new Vector2((cb.x-ca.x)*Aspect,cb.y-ca.y);float reach=ca.z+cb.z,distance=d.magnitude;
                if(reach-distance>depth){depth=reach-distance;normal=distance>1e-6f?d/distance:Vector2.right;}
            }
            if(depth<=1e-5f)return false;
            var move=normal*depth;move.x/=Aspect;
            a.position-=move*share;a.nudge-=move*share;b.position+=move*(1-share);b.nudge+=move*(1-share);return share<1;
        }
    }
    // Hit circles as (viewport x, viewport y, radius).
    IEnumerable<Vector3> Circles(Target e)
    {
        if(e.physicsBody && e.solidRadius>0){yield return new Vector3(e.position.x,e.position.y,e.solidRadius);yield break;}
        if(e.hitCircles==null){yield return new Vector3(e.position.x,e.position.y,e.radius);yield break;}
        foreach(var c in e.hitCircles){var p=CirclePosition(e,c);yield return new Vector3(p.x,p.y,c.z);}
    }
    // Enemy bullets end on any air enemy or meteor other than the one that fired them. In the original (Physics2D layer
    // matrix) enemyBullet collides with neutralObject, the meteors, but passes through other enemies; the remaster
    // blocks both. Ground enemies, the boss and invulnerable targets (e.g. Sd02 still below the plane) don't block.
    public const float HostileRadius=.006f;
    public int BlockedHostiles { get; private set; }
    // The ship's body (player01 "body", superFighterCollisionModel): a circle of 0.8 source units at the stage plane,
    // subject All, so air enemies and meteors (layers enemy, neutralObject) touch it at their hit shapes. Ground enemies
    // (enemyGround) never do.
    public static float ShipRadius=>.8f/Round1Sa01Motion.ViewHeight();
    public int BodyContacts { get; private set; }
    // Model and stage time of each ship-body contact (verification).
    public readonly List<string> BodyContactLog=new List<string>();
    bool Blocked(Hostile b,Vector2 previous)
    {
        foreach(var e in enemies)
            if(e.active && e.id!=b.shooter && !e.ground && !e.isBoss && !e.invulnerable && e.visual && HitGap(e,previous,b.position)<=HostileRadius)return true;
        return false;
    }
    public Target Nearest(Vector2 position,int skip=0)
    {
        Target best=null;float distance=100;
        foreach(var e in enemies)if(e.active && !e.invulnerable && e.id!=skip && e.position.y>=-.05f && e.position.y<=1.1f)
        {float d=Distance(position,e.position);if(d<distance){best=e;distance=d;}}
        return best;
    }
    public bool HitSegment(Vector2 from,Vector2 to,float radius,float damage,bool piercing,HashSet<int> alreadyHit=null)
    {
        bool hit=false;
        foreach(var e in enemies)
        {
            if(!e.active || e.invulnerable || (alreadyHit!=null && alreadyHit.Contains(e.id)) || HitGap(e,from,to)>radius)continue;
            alreadyHit?.Add(e.id);Damage(e,damage);hit=true;if(!piercing)break;
        }
        return hit;
    }
    // PawnEnemy.AddDead from class code (RookEnemy solidarity: Si01 dying with its queen; Ene_Sj01 eaten by Ml01): it
    // explodes as a kill but fires no death bullet; award false gives no score (cause of death 111, no player credit).
    public void ScriptKill(Target target,bool award)
    {
        if(target==null || !target.active)return;
        target.health=0;effects.Blast(target,weapon.player.playback.elapsed);Deactivate(target,true);
        if(award){Kills++;weapon.OnEnemyDestroyed(target);weapon.AddScore(target.score>0?target.score:1000);}
    }
    public void Damage(Target target,float damage)
    {
        if(target==null || !target.active || target.invulnerable || float.IsNaN(damage) || float.IsInfinity(damage) || damage<=0)return;
        target.health-=damage;
        if(target.health<=0){target.health=0;if(DamageCause==CauseWeapon && sourceAttacks)sourceAttacks.FireDeath(target);effects.Blast(target,weapon.player.playback.elapsed);Deactivate(target,true);Kills++;weapon.OnEnemyDestroyed(target);weapon.AddScore(target.isBoss?(target.bossPart==0?50000:1000):target.score>0?target.score:target.isPickupDrone?100:1000);if(target.isBoss && boss){if(target.bossPart==0)boss.OnDefeated();else boss.OnPartBroken(target);}}
    }
    void Deactivate(Target e,bool killed=false){if(e.active && e.sourceSpawn && sourceWaves)sourceWaves.OnRemoved(e,killed);e.active=false;if(e.visual)e.visual.SetActive(false);}
    public void DespawnSourceTarget(Target e){Deactivate(e);}
    public void PlaceSourceTarget(Target e){if(e.active)Place(e);}
    public void Bomb(float damage){DamageCause=CauseBomb;foreach(var e in enemies)if(e.active)Damage(e,damage);DamageCause=CauseWeapon;ClearHostiles();}
    // Destructible enemy bullets (InGameDestuctible, HP 1: enemybullet011/011s): a player shot along a..b downs the first
    // one it crosses, which fires its resident death bullet. Not lock-on targets; bombs just clear them.
    public bool ShootHostile(Vector2 a,Vector2 b,float radius)
    {
        foreach(var h in bullets)
        {
            if(!h.active || h.resident==null || h.age<.5f)continue; // [I] the 0.5 s no-hit window of 011s's split bullets, applied to all
            if(SegmentDistance(h.position,a,b)>radius+.01f)continue;
            h.active=false;h.visual.SetActive(false);ShotBullets++;
            if(sourceAttacks)sourceAttacks.FireResident(h.resident,h.position);
            return true;
        }
        return false;
    }
    public void ClearHostiles(){foreach(var b in bullets){b.active=false;if(b.visual)b.visual.SetActive(false);}if(sourceAttacks)sourceAttacks.ClearFire();}
    public void ResetCombat(float time=0)
    {
        if(weapon)weapon.ResetEnemyDrops(time);
        foreach(var e in enemies)Deactivate(e);enemies.RemoveAll(e=>e.isBoss || e.ground);ClearHostiles();Kills=0;effects.Clear();
        BulletCapacityMisses=0;if(sourceAttacks)sourceAttacks.Clear();
        if(sourceWaves)sourceWaves.ResetSchedule(time);
        if(pickupDrones)pickupDrones.ResetSchedule(time);
        if(groundEnemies)groundEnemies.ResetSchedule(time);
        if(boss)boss.ResetEncounter();
    }
    void Place(Target e)
    {
        e.visual.transform.position=weapon.player.WorldPoint(e.position);
        e.visual.transform.rotation=weapon.player.stageCamera.transform.rotation*(e.sourceSpawn?Quaternion.Euler(-90,0,0)*e.sourceRotation*(e.animation?e.animation.RootRotation:Quaternion.identity):Quaternion.Euler(-90,180,0));
        e.visual.transform.localScale=Vector3.one*(e.sourceSpawn?e.sourceScale:.45f);
    }
    void Place(Hostile b)
    {
        // Render along the same camera ray, in front of the boss's deep 3D hull.
        var camera=weapon.player.stageCamera;var point=weapon.player.WorldPoint(b.position);
        b.visual.transform.position=camera.transform.position+(point-camera.transform.position)*.8f;
        b.visual.transform.rotation=camera.transform.rotation;
        if(b.source && (b.template.name=="enemybullet004" || b.template.name=="enemybullet006"))
            b.visual.transform.rotation=camera.transform.rotation*Quaternion.Euler(0,0,Mathf.Atan2(b.velocity.y,b.velocity.x)*Mathf.Rad2Deg-90)*Quaternion.Euler(-90,0,0);
        // Source scale at the play plane: drawn 0.8 of the way along the camera ray, a bullet already looks 1/0.8 larger,
        // which matches the recording (enemybullet001/003/005 measured about 1.25x the plane-scale size).
        b.visual.transform.localScale=Vector3.one*(b.source?Mathf.Max(.15f,Vector3.Distance(weapon.player.WorldPoint(Vector2.zero),weapon.player.WorldPoint(Vector2.up))/200):1.6f);
        // The sp_eff_e_shot sheets hold two frames side by side (_DividedH 2); the original sprite shaders flip between them.
        if(b.source && b.renderer){bulletFrame??=new MaterialPropertyBlock();bulletFrame.SetVector("_BaseMap_ST",new Vector4(.5f,1,(int)(b.age/EnemyBulletFrameSeconds)%2*.5f,0));b.renderer.SetPropertyBlock(bulletFrame);}
    }
    const float EnemyBulletFrameSeconds=.1f;
    MaterialPropertyBlock bulletFrame;
    public void ReleasePool()
    {
        if(pickupDrones)pickupDrones.ResetSchedule(0);
        if(sourceAttacks)sourceAttacks.Clear();
        if(root){if(Application.isPlaying)Destroy(root.gameObject);else DestroyImmediate(root.gameObject);}
        root=null;enemies.Clear();bullets.Clear();initialized=false;
    }
    void OnDestroy(){ReleasePool();}
}
