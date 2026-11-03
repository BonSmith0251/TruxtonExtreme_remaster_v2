using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// BG03_ge, the ground-enemy timeline (extract_ground_enemies.py): 137 PawnEnemyGround turrets and tanks placed at stage
// world coordinates. The remaster's camera rail runs in the same world frame (rail = _inGameRoot + (0,180,20)), so the
// authored offsets are used as world positions. Checked on recordings/ash-r1-stage01-nofire-20261027:
//   every clip spawns at its start time at its offset; tanks start their type-13 move at once, at the EnemyData speed,
//   after value0 seconds (R100W waits 5 s); the enemy ends once it has been on screen and drops past the native game
//   area (gameScreenArea ±0.15, M-size ±0.2) for about two frames.
// Item and colour boxes in the same timeline are ground enemies too: they break into one ground item
// (Round1Weapon.DropGroundItem); hit rules (HP, lock-on, laser block, score) come from the enemy database.
public sealed class Round1GroundEnemies : MonoBehaviour
{
    // Other stages (StagePlay scenes): the stage's own ground data (tools/stage_enemies/build_ground_enemies.py,
    // Resources/StageEnemies/Ground/BGxx.json), the Animator/turret table (Editor/ReconstructionGroundExport.cs) and the
    // prefabs, set by the scene builder. Without them BG03's GroundEnemyLibrary is used.
    public TextAsset source,animationSource;
    public Round1EnemyWaves.Visual[] visuals=new Round1EnemyWaves.Visual[0];
    [Serializable] public class Clip { public float start,duration,delay;public string enemy;public int index;public Vector3 offset,rotate; }
    [Serializable] public class Definition { public string name,model;public int attribute,score,drop,swapDrop;public float duration,speed,health;public bool item,lockOn=true,laserBlock=true;public Round1EnemyWaves.ActionData[] events; }
    [Serializable] public class Data { public int version;public string stage,timeline,frame;public Clip[] clips;public Definition[] definitions; }
    // round1-ground-animations.json (extract_ground_animations.py): the Animator states a mover plays by name and the
    // EnemyTurret batteries, both read from the original prefabs.
    [Serializable] public class Curve { public string path,property;public float[] times,values; }
    [Serializable] public class State { public string name,clip;public float speed,length;public Curve[] curves; }
    [Serializable] public class Turret { public string path;public float rollSpeed,delay,rollAngle,minAngle,maxAngle;public bool rotX,rotY,rotZ,ground,parent; }
    [Serializable] public class ModelAnimations { public string model;public State[] states;public Turret[] turrets; }
    [Serializable] public class AnimationData { public ModelAnimations[] models; }
    // EnemyTurret.Progress: lerps from the last target to the new one over |angle| / _RollSpeed, waits _delayWait, then
    // _updateTarget aims again.
    sealed class TurretState { public Turret data;public Transform battery;public Quaternion from,to;public float timer,duration; }
    sealed class Actor
    {
        public Clip clip;public Definition definition;public Round1Combat.Target target;public GameObject visual;
        public Vector3 position;public float born,timer,wait=-1;public int next,label=-1,loops;
        public Vector3 moveFrom,moveTo;public float moveTime,moveDuration,lastHealth,flash;public bool moving;public Renderer[] secret;public Vector3[] hitShape;
        public Transform rotPart;public Vector3 rotFrom,rotTo;public float rotTime,rotDuration;public bool rotating,rotEase,entered,offCollision;public int damageVolleys;
        public readonly Dictionary<string,int> labels=new Dictionary<string,int>();
        public readonly Dictionary<int,int> loopCounts=new Dictionary<int,int>();
        public ModelAnimations animations;public State state;public float stateStart;public TurretState[] turrets;
        public Vector3 lcStart;public int lcMove=-1;public float lcSpeed,lcRange;public bool lcDeadEnd;   // Ene_Lc01
        public readonly Dictionary<string,Transform> parts=new Dictionary<string,Transform>();
        public Transform Part(string path){if(!parts.TryGetValue(path??"",out var t))parts[path??""]=t=string.IsNullOrEmpty(path)?visual.transform:visual.transform.Find(path);return t;}
        public bool Animating=>state!=null && timer<stateStart+state.length/Mathf.Max(.001f,state.speed);
    }
    // Ene_ColorBox_UN (.cctor 0x1dbb8f0, AddDamageOwner 0x1dbb410): the camouflaged box is invisible and shows for 1.5 s after a hit.
    const float SecretFlashSeconds=1.5f;
    // The rail clip is _inGameRoot + (0,180,20), but its parent puts the rail transform 20.2 behind the clip: at the root.
    const float GroundExitDistance=333.8f,MxExitDistance=326f,RailAboveRoot=-.2f;
    public Data Source { get; private set; }
    public int Spawned { get; private set; }
    public int Entered { get; private set; } // ground enemies that came on screen
    public int Active=>actors.Count;
    readonly List<Actor> actors=new List<Actor>();
    readonly Dictionary<string,Definition> definitions=new Dictionary<string,Definition>();
    readonly Dictionary<string,GameObject> prefabs=new Dictionary<string,GameObject>();
    readonly Dictionary<string,ModelAnimations> animations=new Dictionary<string,ModelAnimations>();
    // ItemEffects.GetGroundItemName: the ground model of each item a box can drop (Pf_item_*, a pf_item0x model raised 2
    // and turned 180 degrees, lying on the ground).
    static readonly Dictionary<Round1PickupKind,string> GroundItems=new Dictionary<Round1PickupKind,string>{
        {Round1PickupKind.Power,"Pf_item_power"},{Round1PickupKind.SpeedUp,"Pf_item_speedup"},{Round1PickupKind.OneUp,"Pf_item_1up"},
        {Round1PickupKind.TwoUp,"Pf_item_2up"},{Round1PickupKind.Bonus,"Pf_item_bonus01"},{Round1PickupKind.BombStock,"Pf_item_bomstock"},
        {Round1PickupKind.Red,"Pf_item_change_red"},{Round1PickupKind.Green,"Pf_item_change_green"},{Round1PickupKind.Blue,"Pf_item_change_blue"},
        {Round1PickupKind.Purple,"Pf_item_change_purple"},{Round1PickupKind.Silver,"Pf_item_change_silver"},{Round1PickupKind.Gold,"Pf_item_change_gold"},
        {Round1PickupKind.Black,"Pf_item_change_black"}};
    // PawnEnemyGround._callDeadEffect → InGameRuinManager.EmitterFrom3D: a destroyed ground enemy leaves its wreck, the
    // EnemyRuin named by _ruinName or else Pf_EneObj_BurntGround0<_ruinBurnt>, at its place + _groundRuinOffset. The
    // burnt-ground particles live 60 s; the remaster also drops a wreck once the camera has passed it (like the enemies).
    static readonly Dictionary<string,(string ruin,float up)> Ruins=new Dictionary<string,(string,float)>{
        {"Pf_Ene_BSa01",("Pf_EneObj_BurntGround01",2)},{"Pf_Ene_BSc01",("Pf_EneObj_BurntGround01",2)},{"Pf_Ene_BMa01",("Pf_EneObj_BurntGround02",2)},
        {"Pf_Ene_BSb01",("Pf_EneObj_BurntGround03",2)},{"Pf_Ene_Mx01",("Pf_EneObj_BurntGround02",-3)}};
    const float RuinSeconds=60;
    sealed class Ruin { public GameObject go;public float born,z; }
    readonly List<Ruin> ruins=new List<Ruin>();
    public int RuinsLeft { get; private set; }
    public int RuinsActive=>ruins.Count;
    // Wrecks whose particles are not playing (would draw nothing in real time).
    public int RuinsNotPlaying=>ruins.Count(r=>r.go && r.go.GetComponentsInChildren<ParticleSystem>().Any(ps=>!ps.isPlaying));
    void LeaveRuin(Actor a,float now)
    {
        if(!Ruins.TryGetValue(a.definition.model,out var r))return;var prefab=combat.effects.Prefab(r.ruin);if(!prefab)return;
        var go=Instantiate(prefab,root);go.name=r.ruin;go.transform.SetPositionAndRotation(a.position+Vector3.up*r.up,Quaternion.identity);
        // The burnt-ground systems don't play on awake: EnemyRuin starts them in the original.
        foreach(var ps in go.GetComponentsInChildren<ParticleSystem>(true))ps.Play(true);
        ruins.Add(new Ruin{go=go,born=now,z=a.position.z});RuinsLeft++;
    }
    void StepRuins(float now)
    {
        for(int i=ruins.Count-1;i>=0;i--)
        {
            var r=ruins[i];if(r.go && now>=r.born && now-r.born<RuinSeconds && RootZ()-r.z<GroundExitDistance)continue;
            if(r.go){if(Application.isPlaying)Destroy(r.go);else DestroyImmediate(r.go);}ruins.RemoveAt(i);
        }
    }
    // For stepped previews: pose each wreck's particles at its age; returns where they are.
    public string SimulateRuins(float now)
    {
        var sb=new System.Text.StringBuilder();
        foreach(var r in ruins)if(r.go)
        {
            int n=0;foreach(var ps in r.go.GetComponentsInChildren<ParticleSystem>()){ps.Simulate(Mathf.Max(.02f,now-r.born),true,true);ps.Play(true);n+=ps.particleCount;}
            var v=combat.weapon.player.stageCamera.WorldToViewportPoint(r.go.transform.position);sb.Append(r.go.name+" at "+v.x.ToString("0.00")+","+v.y.ToString("0.00")+" particles "+n+"; ");
        }
        return sb.ToString();
    }
    public GameObject ItemPrefab(Round1PickupKind kind)=>GroundItems.TryGetValue(kind,out var name) && prefabs.TryGetValue(name,out var p)?p:null;
    public Transform Root=>root;
    readonly Dictionary<string,Round1EnemyWaves.Definition> attackDefinitions=new Dictionary<string,Round1EnemyWaves.Definition>();
    bool[] started;
    // BG03's exit rule is the recorded _inGameRoot distance along +Z; other stages' rails turn, so their ground enemies
    // end once they have been on screen and have left it (or with their clip).
    bool worldExit=true;
    Round1Combat combat;Transform root;float lastTime=-1;

    public void Initialize(Round1Combat owner)
    {
        if(Source!=null)return;combat=owner;
        if(source)
        {
            Source=JsonUtility.FromJson<Data>(source.text);
            foreach(var v in visuals)if(v!=null && v.prefab)prefabs[v.name]=v.prefab;
            worldExit=false;
        }
        else
        {
            var library=Resources.Load<Round1GroundEnemyLibrary>("Truxton/GroundEnemyLibrary");
            if(!library || !library.source){Debug.LogWarning("Ground enemy library is missing; BG03_ge is disabled.",this);return;}
            Source=JsonUtility.FromJson<Data>(library.source.text);
            foreach(var p in library.prefabs)if(p.prefab)prefabs[p.name]=p.prefab;
            animationSource=Resources.Load<TextAsset>("Truxton/round1-ground-animations");
        }
        foreach(var d in Source.definitions)definitions[d.name]=d;
        if(animationSource)foreach(var m in JsonUtility.FromJson<AnimationData>(animationSource.text).models)animations[m.model]=m;
        else Debug.LogWarning("Ground enemy animations are missing; turrets and hatches stay still.",this);
        started=new bool[Source.clips.Length];
        root=new GameObject(Source.stage+" ground enemies").transform;root.SetParent(transform,false);
    }
    public void ResetSchedule(float time)
    {
        foreach(var a in actors)Remove(a,false);actors.Clear();
        foreach(var r in ruins)if(r.go){if(Application.isPlaying)Destroy(r.go);else DestroyImmediate(r.go);}ruins.Clear();
        if(started==null)return;
        // A clip whose start is behind the seek point is only replayed when the camera hasn't passed it yet.
        for(int i=0;i<started.Length;i++)started[i]=false;
        lastTime=time;
    }
    public void Step(float now)
    {
        if(Source==null || !combat.weapon.SimulationRunning)return;
        if(now<lastTime-.001f)ResetSchedule(now);
        lastTime=now;
        if(combat.boss && combat.boss.SuppressesWaves){foreach(var a in actors)Remove(a,false);actors.Clear();StepRuins(now);return;}
        for(int i=0;i<Source.clips.Length;i++)
        {
            var c=Source.clips[i];
            if(started[i] || now+.00001f<c.start)continue;
            started[i]=true;
            if(!definitions.TryGetValue(c.enemy,out var d) || now>c.start+c.duration)continue;
            Spawn(c,d,now);
        }
        for(int i=actors.Count-1;i>=0;i--)if(UpdateActor(actors[i],now)){Remove(actors[i],false);actors.RemoveAt(i);}
        StepRuins(now);
    }
    void Spawn(Clip c,Definition d,float now)
    {
        if(!prefabs.TryGetValue(d.model,out var prefab))return;
        var visual=Instantiate(prefab,root);visual.name=d.model; // Weapon tolerances are keyed by model.
        foreach(var ps in visual.GetComponentsInChildren<ParticleSystem>(true))ps.gameObject.SetActive(false);
        foreach(var col in visual.GetComponentsInChildren<Collider>(true))col.enabled=false;
        foreach(var an in visual.GetComponentsInChildren<Animator>(true))an.enabled=false;
        visual.transform.SetPositionAndRotation(c.offset,Quaternion.Euler(c.rotate));
        var t=combat.RegisterGround(visual,Viewport(c.offset),d.health>0?d.health:500,Size(d)>0?.035f:.024f);
        t.blocksLaser=d.laserBlock;t.score=d.score;
        var a=new Actor{clip=c,definition=d,target=t,visual=visual,position=c.offset,born=now,lastHealth=t.health,hitShape=Round1HitShapes.Get(d.model)};
        if(d.model.EndsWith("_UN")){a.secret=visual.GetComponentsInChildren<Renderer>(true);foreach(var r in a.secret)r.enabled=false;}
        if(animations.TryGetValue(d.model,out var anim))
        {
            a.animations=anim;var list=new List<TurretState>();
            foreach(var tu in anim.turrets??Array.Empty<Turret>())
            {
                var battery=a.Part(tu.path);if(!battery){Debug.LogWarning("Missing turret "+d.model+"/"+tu.path,this);continue;}
                list.Add(new TurretState{data=tu,battery=battery,from=battery.rotation,to=battery.rotation});
            }
            a.turrets=list.ToArray();
        }
        actors.Add(a);Spawned++;
        if(combat.sourceAttacks && !d.item)combat.sourceAttacks.Register(t,AttackDefinition(d),now,1);
        Round1TrackCapture.Active?.BirthUnscheduled(t.id,d.name,d.model,now,t.health);
        UpdateActor(a,now);
    }
    Round1EnemyWaves.Definition AttackDefinition(Definition d)
    {
        if(!attackDefinitions.TryGetValue(d.name,out var w))
        {
            // A program that plays Animation events times its own Bullet events (UpdateActor fires them in order, e.g. BSb01
            // opens, fires, closes and loops), so the attack scheduler gets the program without them.
            var events=SelfTimed(d)?Array.FindAll(d.events,e=>e.eventType!=8 && e.eventType!=83):d.events;
            w=new Round1EnemyWaves.Definition{id=d.name,name=d.name,model=d.model,attribute=d.attribute,duration=d.duration,position=Vector3.zero,
                placements=new[]{new Round1EnemyWaves.Placement{moveSpeed=d.speed}},events=events,routes=new string[0]};
            attackDefinitions[d.name]=w;
        }
        return w;
    }
    static bool SelfTimed(Definition d)=>Array.Exists(d.events,e=>e.eventType==9);
    static int Size(Definition d)=>d.model=="Pf_Ene_BMa01" || d.model=="Pf_Ene_Mx01"?1:0;
    // The native EnemyMover program (RouteEventType), frame-stepped: 13 Translate moves by vectorValue at the EnemyData
    // speed after value0 s, 5 marks a loop label, 1 waits dotime, 2 Rotate sets the nameValue part's local angles,
    // 9 Animation plays the Animator state stringValue, 8/83 Bullet fires (only for a program with animations; the
    // attack scheduler times the others), 80 TaskWait waits for the move and, with flag 16, the animation, 101 jumps back
    // to the label intValue1 times.
    bool UpdateActor(Actor a,float now)
    {
        float dt=Mathf.Max(0,now-(a.born+a.timer));a.timer=now-a.born;
        var events=a.definition.events;int guard=0;bool finished=false;
        // InAreaStart (attribute 512): the program starts only once the enemy is on display.
        if((a.definition.attribute&512)!=0 && !a.entered){a.born=now;a.timer=0;guard=64;}
        while(a.next<events.Length && guard++<64)
        {
            var e=events[a.next];
            if(e.eventType==13)
            {
                if(a.wait<0)a.wait=a.timer+Mathf.Max(0,e.value0);
                if(a.timer<a.wait)break;
                a.wait=-1;a.moveFrom=a.position;a.moveTo=a.position+e.vectorValue;a.moveTime=0;
                a.moveDuration=e.vectorValue.magnitude/Mathf.Max(.001f,a.definition.speed);a.moving=a.moveDuration>0;a.next++;continue;
            }
            if(e.eventType==5){a.label=a.next;if(!string.IsNullOrEmpty(e.stringValue))a.labels[e.stringValue]=a.next;a.next++;continue;}
            if(e.eventType==12)
            {
                // ForwardMove (0x1CF803B, mover 0x1CF9730): waits for a running move, then moves along the root's +Z (taken
                // once) at the placement speed for dotime; value0 and intValue1 are not read.
                if(a.moving)break;
                var forward=a.visual.transform.rotation*Vector3.forward;
                a.moveFrom=a.position;a.moveDuration=Mathf.Max(0,e.dotime);a.moveTo=a.position+forward*a.definition.speed*a.moveDuration;a.moveTime=0;a.moving=a.moveDuration>0;a.next++;continue;
            }
            if(e.eventType==20)
            {
                // Idle: the stack waits dotime.
                if(a.wait<0)a.wait=a.timer+e.dotime;
                if(a.timer<a.wait)break;
                a.wait=-1;a.next++;continue;
            }
            if(e.eventType==1000)
            {
                // FinishDestroy: the enemy ends (not a kill) once its translate and animation tasks are done.
                if(a.moving || a.Animating)break;
                a.next++;finished=true;break;
            }
            if(e.eventType==1)
            {
                if(a.wait<0)a.wait=a.timer+e.dotime;
                if(a.timer<a.wait)break;
                a.wait=-1;a.next++;continue;
            }
            if(e.eventType==2)
            {
                // BSb01 starts with its battery turned over (180 about X): the closed pose its "open" clip starts from.
                if(a.wait<0)a.wait=a.timer+Mathf.Max(0,e.value0);
                if(a.timer<a.wait)break;
                a.wait=-1;var part=a.Part(e.nameValue);
                // Rotate (0x1CF6DB6, tween 0x1D2CAA0; evidence/ground-route-events): over dotime a local tween, relative
                // unless flag0, InOutSine when intValue1 != 0; dotime <= 0.001 sets the local angles at once.
                if(part && e.dotime>.001f)
                {
                    a.rotPart=part;a.rotFrom=part.localEulerAngles;a.rotTo=e.flag0!=0?e.vectorValue:a.rotFrom+e.vectorValue;
                    a.rotTime=0;a.rotDuration=e.dotime;a.rotEase=e.intValue1!=0;a.rotating=true;
                }
                else if(part)part.localEulerAngles=e.vectorValue;
                a.next++;continue;
            }
            if(e.eventType==9)
            {
                a.state=a.animations?.states==null?null:Array.Find(a.animations.states,s=>s.name==e.stringValue);a.stateStart=a.timer;
                if(a.state==null)Debug.LogWarning("Missing animation state "+a.definition.model+"/"+e.stringValue,this);
                a.next++;continue;
            }
            if((e.eventType==8 || e.eventType==83) && SelfTimed(a.definition))
            {
                if(combat.sourceAttacks)combat.sourceAttacks.Fire(a.target,e,now);
                a.next++;continue;
            }
            if(e.eventType==1001)break; // FinishWait: the stack stops for good (bullets and running moves go on).
            if(e.eventType==10 || e.eventType==11)
            {
                // Set/ResetObjFlag: flag 1 is OffCollision (no hits); value0 is an async delay, applied here at once [I].
                if((e.intValue1&1)!=0)a.offCollision=e.eventType==10;
                a.next++;continue;
            }
            if(e.eventType==80){if(a.moving || ((e.intValue1&16)!=0 && a.Animating) || ((e.intValue1&1)!=0 && a.rotating))break;a.next++;continue;}
            if(e.eventType==101)
            {
                a.loopCounts.TryGetValue(a.next,out int done);
                int target=!string.IsNullOrEmpty(e.stringValue) && a.labels.TryGetValue(e.stringValue,out int named)?named:a.label;
                if(target>=0 && done<e.intValue1){a.loopCounts[a.next]=done+1;a.next=target+1;continue;}
                a.loopCounts[a.next]=0;a.next++;continue;
            }
            a.next++;
        }
        if(a.moving)
        {
            a.moveTime+=dt;float u=Mathf.Clamp01(a.moveTime/a.moveDuration);
            a.position=Vector3.Lerp(a.moveFrom,a.moveTo,u);if(u>=1)a.moving=false;
        }
        if(a.rotating && a.rotPart)
        {
            a.rotTime+=dt;float u=Mathf.Clamp01(a.rotTime/a.rotDuration);float k=a.rotEase?.5f-.5f*Mathf.Cos(u*Mathf.PI):u;
            a.rotPart.localEulerAngles=Vector3.LerpUnclamped(a.rotFrom,a.rotTo,k);if(u>=1)a.rotating=false;
        }
        // EventStack enemies (attribute 16) end when their events run out and their tasks are done.
        if((a.definition.attribute&16)!=0 && a.next>=events.Length && events.Length>0 && !a.moving && !a.rotating && !a.Animating)finished=true;
        if(a.definition.model=="Pf_Ene_Lc01")Lc01(a,dt);
        a.visual.transform.position=a.position;
        if(a.state!=null)Pose(a);
        if(a.turrets!=null)foreach(var tu in a.turrets)Aim(tu,dt);
        var view=combat.weapon.player.stageCamera.WorldToViewportPoint(a.position);a.target.position=view;
        // HybridCollisions sizes a ground enemy's hit shape in pixels per world Z unit at its own position.
        Vector2 ahead=combat.weapon.player.stageCamera.WorldToViewportPoint(a.position+Vector3.forward);
        Round1Combat.SetHitCircles(a.target,a.hitShape,Quaternion.identity,0,Mathf.Abs(ahead.y-view.y));
        // Not hittable or lockable until it is on screen in front of the camera.
        bool onScreen=view.z>0 && view.x>=0 && view.x<=1 && view.y>=0 && view.y<=1;a.target.invulnerable=!onScreen || a.offCollision;a.target.lockOn=onScreen && !a.offCollision && a.definition.lockOn;
        if(onScreen && !a.entered)Entered++;a.entered|=onScreen;
        Round1TrackCapture.Active?.Record(a.target.id,now,a.position,a.visual.transform.rotation);
        if(a.secret!=null)
        {
            if(a.target.active && a.target.health<a.lastHealth)a.flash=SecretFlashSeconds;
            a.flash=Mathf.Max(0,a.flash-dt);foreach(var r in a.secret)r.enabled=a.flash>0;
        }
        // Ene_bg05tree.AddDamageOwner (0x1D85D20): a volley each time the damage taken passes HP*k/count (k = 1..count-1),
        // at most one per hit and never on the killing hit; any damage counts.
        var damageBullet=combat.sourceAttacks?combat.sourceAttacks.DamageBullet(a.definition.model):null;
        if(damageBullet!=null && a.target.active && a.target.health<a.lastHealth && a.damageVolleys<damageBullet.count-1
            && 1-a.target.health/Mathf.Max(1,a.target.maxHealth)>=(a.damageVolleys+1f)/Mathf.Max(1,damageBullet.count))
        {a.damageVolleys++;combat.sourceAttacks.FireDamageVolley(damageBullet,a.Part(damageBullet.muzzle),a.target);}
        a.lastHealth=a.target.health;
        if(!a.target.active)
        {
            Round1TrackCapture.Active?.End(a.target.id,true);
            if(a.target.health<=0){combat.weapon.DropGroundItem(a.definition.drop,a.definition.swapDrop,a.clip.offset,a.position,now);LeaveRuin(a,now);}
            return true;
        }
        // The original ground camera ends a ground enemy once _inGameRoot has passed it by 333.8 units (median over
        // all 137 in the recording, at both heights and sizes). The remaster camera differs, so use the world rule.
        // Mx01 ends at 326.0 in all 22 recorded cases. A ground enemy also ends with its EnemyEntryClip
        // (the 250-400 s batch ends at 399.99 s with the camera still short of it).
        float exit=a.definition.model=="Pf_Ene_Mx01"?MxExitDistance:GroundExitDistance;
        bool gone=worldExit?RootZ()-a.position.z>=exit:a.entered && (view.z<=0 || view.y<-.2f || view.x<-.3f || view.x>1.3f);
        if(finished || gone || now>=a.clip.start+a.clip.duration-.5f/60){Round1TrackCapture.Active?.End(a.target.id,false);return true;}
        return false;
    }
    // Samples the playing Animator state's curves (holding the last key once it ends, like a non-looping state).
    readonly Dictionary<Transform,Vector3> poseAngles=new Dictionary<Transform,Vector3>();
    void Pose(Actor a)
    {
        float t=Mathf.Clamp((a.timer-a.stateStart)*a.state.speed,0,a.state.length);poseAngles.Clear();
        foreach(var c in a.state.curves)
        {
            var part=a.Part(c.path);if(!part)continue;
            int axis=c.property.EndsWith(".x")?0:c.property.EndsWith(".y")?1:2;float v=Sample(c,t);
            if(c.property.StartsWith("localEulerAngles"))
            {
                if(!poseAngles.TryGetValue(part,out var e))e=part.localEulerAngles;
                e[axis]=v;poseAngles[part]=e;
            }
            else if(c.property.StartsWith("m_LocalPosition")){var p=part.localPosition;p[axis]=v;part.localPosition=p;}
        }
        foreach(var pair in poseAngles)pair.Key.localEulerAngles=pair.Value;
    }
    static float Sample(Curve c,float t)
    {
        int n=c.times.Length;if(n==0)return 0;if(t<=c.times[0])return c.values[0];if(t>=c.times[n-1])return c.values[n-1];
        int i=Array.BinarySearch(c.times,t);if(i>=0)return c.values[i];i=~i;
        return Mathf.Lerp(c.values[i-1],c.values[i],(t-c.times[i-1])/(c.times[i]-c.times[i-1]));
    }
    // Ene_Lc01._moveState 0x1DBE730 (evidence/movers/Ene_Lc01/SPEC.md sec. 3): once its stack has started (InAreaStart:
    // on display) the tank drives along world +Z whenever it has scrolled below sky z -5 and stops above +15, until it has
    // covered MoveRange 430 (20 s of driving at _rangeRate 0.05/s). MoveAcc uses Math.Max and MoveDec Math.Min, so the
    // speed snaps on and off in one frame. Its death sequence, crater and cover turrets (MoveMuzzles) are not ported.
    void Lc01(Actor a,float dt)
    {
        if(a.lcMove<0){if(!a.entered)return;a.lcStart=a.position;a.lcMove=0;}   // StartWait -> Main: _lcStartPosition
        var view=combat.weapon.player.stageCamera.WorldToViewportPoint(a.position);
        float skyZ=(view.y-.5f)*Round1Sa01Motion.ViewHeight();                    // GetSkyRootPosition(position, true).z
        switch(a.lcMove)
        {
            case 0:if(skyZ<-5 && !a.lcDeadEnd){a.lcMove=1;a.lcSpeed=0;}break;    // MoveWait (tank SE 0x8E not wired)
            case 1:a.lcSpeed=Mathf.Max(a.lcSpeed+.002f,.05f);if(a.lcSpeed>=.05f)a.lcMove=2;break;   // MoveAcc
            case 2:if(skyZ>15)a.lcMove=3;break;                                    // Moving
            case 3:a.lcSpeed=Mathf.Min(a.lcSpeed-.005f,0);if(a.lcSpeed<=0)a.lcMove=0;break;          // MoveDec (SE 0x8F)
        }
        if(a.lcSpeed<=0)return;
        a.lcRange=Mathf.Clamp01(a.lcRange+dt*a.lcSpeed);a.position=a.lcStart+new Vector3(0,0,430)*a.lcRange;   // MoveTank
        if(!a.lcDeadEnd && a.position.z>=a.lcStart.z+430 && a.lcMove!=3){a.lcMove=3;a.lcDeadEnd=true;}
    }
    // EnemyTurret.Progress / _updateTarget: aims from the battery's place on the player plane (GetSkyRootPosition) at
    // the player (GetPlayerSkyPosition); the yaw is clamped to _MinAngle.._MaxAngle and rounded to _RollAngle steps,
    // and the new world rotation is reached by Quaternion.Lerp over |turn| / _RollSpeed seconds, then _delayWait passes.
    void Aim(TurretState s,float dt)
    {
        s.timer+=dt;
        if(s.timer>=s.duration+s.data.delay && Retarget(s))s.timer=0;
        s.battery.rotation=s.duration>0 && s.timer<s.duration?Quaternion.Lerp(s.from,s.to,s.timer/s.duration):s.to;
    }
    bool Retarget(TurretState s)
    {
        var camera=combat.weapon.player.stageCamera;
        // Viewport to source units of the player plane (screen up is world +Z, right +X).
        Vector2 d=combat.weapon.player.viewportPosition-(Vector2)camera.WorldToViewportPoint(s.battery.position);
        d=new Vector2(d.x*camera.aspect,d.y)*Round1Sa01Motion.ViewHeight();
        if(d.sqrMagnitude<.1f)return false;
        float yaw=Mathf.Clamp(Mathf.Atan2(d.x,d.y)*Mathf.Rad2Deg,s.data.minAngle,s.data.maxAngle);
        if(s.data.rollAngle>0)yaw=Mathf.Round(yaw/s.data.rollAngle)*s.data.rollAngle;
        s.from=s.to;s.to=Quaternion.Euler(0,s.data.rotY?yaw:0,0);
        s.duration=Quaternion.Angle(s.from,s.to)/Mathf.Max(.001f,s.data.rollSpeed);
        return true;
    }
    // The remaster camera rail is _inGameRoot + (0,180,20) in the same world frame.
    float RootZ(){var rail=combat.weapon.player.playback.cameraRail;return (rail?rail.transform.position.z:combat.weapon.player.stageCamera.transform.position.z)-RailAboveRoot;}
    Vector2 Viewport(Vector3 world)=>combat.weapon.player.stageCamera.WorldToViewportPoint(world);
    void Remove(Actor a,bool killed){if(a.target!=null)combat.RemoveGround(a.target);if(a.visual){if(Application.isPlaying)Destroy(a.visual);else DestroyImmediate(a.visual);}}
}
