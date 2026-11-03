using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Authored BG03 spawn data. Coordinates and combat balance adapt to the remaster camera.
// Route LUTs are original; enemy-specific native AI and bullet scripts remain separate.
public class Round1EnemyWaves : MonoBehaviour
{
    [Serializable] public class Event
    {
        public string id,source,group,enemy;
        public float start,end,startDelay,loopDelay,timeScale=1;
        public Vector3 offset,rotate;
        public Vector3[] offsets;
        public bool loop,wipeoutOnly,outMeansDestroy;
        public int loopMax,gameModeMask,indexValue;
    }
    [Serializable] public class Placement
    {
        public string objectName;
        public float moveSpeed,delayTime,_moveSpeedRange;
        public Vector3 offset,rotate,_offsetRange;
        public int easeType,lookAt,attributeFlag;
    }
    [Serializable] public class Repeat { public int _repeatTimes,attributeFlag;public Vector3 _offsetStep;public float _delayStep,_speedStep; }
    [Serializable] public class ActionData
    {
        public int eventType,repeatCount,intValue1,intValue2,intValue3,flag0,rpidf;
        public float repeatDelay,awakeRate,value0,value1,dotime,randomFire,randomWait;
        public Vector3 vectorValue;public string stringValue,nameValue,subnameValue;
    }
    [Serializable] public class Definition
    {
        public string id,name,model;public int attribute;public float duration;public Vector3 position;
        public Placement[] placements;public Repeat[] repeats;public ActionData[] events;public string[] routes;
    }
    [Serializable] public class Route
    {
        public string name,source;public float[] times;public Vector3[] points,tangents;
        [NonSerialized] public float length;
        public Vector3 Sample(float t)
        {
            if(points==null || points.Length==0)return Vector3.zero;
            if(t<=times[0])return points[0];if(t>=1)return points[points.Length-1];
            int lo=0,hi=times.Length-1;while(hi-lo>1){int mid=(lo+hi)/2;if(times[mid]<=t)lo=mid;else hi=mid;}
            return Vector3.LerpUnclamped(points[lo],points[hi],(t-times[lo])/Mathf.Max(.000001f,times[hi]-times[lo]));
        }
    }
    [Serializable] public class Model { public string name;public float health; }
    [Serializable] public class Data { public int version,round,gameModeMask;public string stage;public float sourceHeight;public Event[] events;public Definition[] definitions;public Route[] routes;public Model[] models; }
    [Serializable] public class Visual { public string name;public GameObject prefab; }
    class Group { public int scheduled,killed,escaped; }
    class State { public Event data;public int iteration,pending;public bool started,finished;public readonly List<Actor> actors=new List<Actor>(); }
    class Pending { public State state;public Placement placement;public float time,speedDelta;public Vector3 extraOffset;public int seed; }
    class Actor
    {
        public Round1Combat.Target target;public State state;public Definition definition;public Placement placement;
        public float born,speed,outsideSince=-1;public Vector3 origin,direction;public string[] routes;public bool finished,killed,entered;
        public Round1EnemyAnimation animation;
        public Round1Sa01Motion sa01;
        public Round1Md01Motion md01;
        public Round1RouteProgram program;
        public Round1MeteorField.Body meteor;public Transform meteorModel;
        public Vector3[] hitShape;public bool wholeBody;
        public bool OriginalProjection=>sa01!=null || md01!=null;
    }
    public TextAsset schedule;
    public Round1Combat combat;
    public Visual[] visuals;
    // TLGameModeFlag: Tutorial 1, StoryA/B/C 2/4/8, Arcade1 32, Arcade2 64, Team 128, Rush 256.
    public const int StoryAMask=2,Arcade1Mask=32;
    public int gameModeMask=StoryAMask,randomSeed=3101;
    public Data Source { get; private set; }
    public int TotalSpawned { get; private set; }
    public int CapacityMisses { get; private set; }
    public int TriggeredEvents { get; private set; }
    public int ConditionalSkipped { get; private set; }
    public int PendingCount => pending.Count;
    public float LastTime { get; private set; }
    // InGameManager.LateUpdate moves _inGameEnemyRoot to -.5 * _bgSlideRate * CinemachineMan._BGCameraSlideRange
    // (X only). _bgSlideRate = clamp(player X / PlayerControllWidth 123, -1, 1), held while the entry autopilot
    // runs. Ground objects live outside this root. Actors move in the root's local frame; this is its offset.
    public const float PlayerControllWidth=123;
    public Vector3 LayerOffset { get; private set; }
    float slideRate;
    readonly Dictionary<string,Definition> definitions=new Dictionary<string,Definition>();
    readonly Dictionary<string,Route> routes=new Dictionary<string,Route>();
    readonly Dictionary<string,Visual> models=new Dictionary<string,Visual>();
    readonly Dictionary<string,float> health=new Dictionary<string,float>();
    readonly Dictionary<string,Group> groups=new Dictionary<string,Group>();
    readonly List<State> states=new List<State>();
    readonly List<Pending> pending=new List<Pending>();
    readonly List<Actor> actors=new List<Actor>();
    readonly Dictionary<int,Actor> live=new Dictionary<int,Actor>();
    // Ene_Mj01h (CallMJ01Body 0x1dc7090, ReceiveKill 0x1dc78b0; statics gravityVector (0,0,-16), _unitDistance 22.5):
    // the head summons _summonEnemyCount 9 Pf_Ene_Mj01b bodies at its spawn point and releases the next one each time it
    // has moved another _unitDistance, so body i runs the head's route (i+1)*22.5 units behind it. A destroyed body sets
    // _breakChildren (no more releases) and SetParentKilled on every body behind it; the head's death does it for all.
    // Ene_Mj01b state 2 then drifts by gravityVector per second until it leaves. Bodies: 2000 HP, 5000 points, not
    // lock-on targets, block lasers (Pf_Ene_Mj01b, enemy database row Mj01b).
    const string ChainHead="Pf_Ene_Mj01h",ChainBody="Pf_Ene_Mj01b";
    const int ChainLength=9;const float UnitDistance=22.5f,BodyScore=5000,BodyHealth=2000;
    static readonly Vector3 BodyGravity=new Vector3(0,0,-16);
    sealed class Body { public Round1Combat.Target target;public int id;public bool started,detached,entered,gone;public Vector3 position;public float outsideSince=-1; }
    sealed class Chain { public Actor head;public int headId,id;public Body[] bodies;public bool broken,headGone;public float lastTime; }
    readonly List<Chain> chains=new List<Chain>();int chainSerial;
    public int ChainBodiesSpawned { get; private set; }
    public int ChainBodiesKilled { get; private set; }
    public int ChainBodiesDetached { get; private set; }
    readonly Round1MeteorField meteors=new Round1MeteorField();
    public Round1MeteorField Meteors=>meteors;
    bool initialized;

    public void Initialize()
    {
        if(initialized || !schedule)return;
        Source=JsonUtility.FromJson<Data>(schedule.text);
        if(Source.version!=1 || Source.stage!="BG03")throw new InvalidOperationException("Wrong enemy timeline data");
        foreach(var d in Source.definitions)definitions.Add(d.id,d);
        foreach(var r in Source.routes)
        {
            for(int i=1;i<r.points.Length;i++)r.length+=Vector3.Distance(r.points[i-1],r.points[i]);
            routes.Add(r.name,r);
        }
        foreach(var v in visuals)models.Add(v.name,v);
        foreach(var m in Source.models)health.Add(m.name,Round1Balance.Current.EnemyHealth(m.name));
        foreach(var e in Source.events)
        {
            if(!definitions.ContainsKey(e.enemy))throw new InvalidOperationException("Unresolved enemy "+e.enemy);
            states.Add(new State{data=e});if(!groups.ContainsKey(e.group))groups.Add(e.group,new Group());
        }
        initialized=true;ResetSchedule(0);
    }
    public void ResetSchedule(float time)
    {
        Initialize();if(!initialized)return;
        pending.Clear();actors.Clear();live.Clear();meteors.Reset(time);chains.Clear();ChainBodiesSpawned=ChainBodiesKilled=ChainBodiesDetached=0;
        foreach(var s in states){s.started=s.finished=s.data.start<time-.0001f;s.iteration=s.pending=0;s.actors.Clear();}
        foreach(var g in groups.Values)g.scheduled=g.killed=g.escaped=0;
        TotalSpawned=CapacityMisses=TriggeredEvents=ConditionalSkipped=0;LastTime=time;slideRate=0;LayerOffset=Vector3.zero;
        // Seeking intentionally clears historical actors. Only upcoming authored cues run.
    }
    public bool IsWipeout(string group)
    {
        return groups.TryGetValue(group,out var g) && g.scheduled>0 && g.killed==g.scheduled && g.escaped==0;
    }
    public void Step(float now)
    {
        Initialize();if(!initialized || !combat || !combat.weapon.SimulationRunning)return;
        if(now<LastTime-.001f)ResetSchedule(now);
        if(!combat.weapon.player.SpawnAnimating)slideRate=Mathf.Clamp(PlayerSourcePosition().x/PlayerControllWidth,-1,1);
        LayerOffset=new Vector3(-.5f*slideRate*SlideRange(now),0,0);
        UpdateActors(now);
        if(combat.boss && combat.boss.SuppressesWaves)
        {pending.Clear();LastTime=now;return;}
        foreach(var state in states)
        {
            var e=state.data;if(state.finished)continue;
            if(!state.started && now+.00001f>=e.start)
            {
                state.started=true;
                if(now>=e.end || (e.gameModeMask!=0 && (e.gameModeMask & gameModeMask)==0)) {state.finished=true;continue;}
                if(e.wipeoutOnly && !IsWipeout(e.group)){ConditionalSkipped++;state.finished=true;continue;}
                TriggeredEvents++;Queue(state,e.start+e.startDelay/e.timeScale);
            }
            else if(state.started && e.loop && now<e.end && state.pending==0 && state.actors.Count>0 && state.actors.TrueForAll(a=>a.finished))
            {
                if(e.loopMax>0 && state.iteration+1>=e.loopMax){state.finished=true;continue;}
                state.iteration++;state.actors.Clear();Queue(state,now+Mathf.Max(.0001f,e.loopDelay/e.timeScale));
            }
            if(now>=e.end)state.finished=true;
        }
        // Evaluate the gate once per timestamp before any queued bonus actors spawn.
        for(int i=0;i<pending.Count;)
        {
            var p=pending[i];if(p.time>now+.00001f){i++;continue;}
            pending.RemoveAt(i);p.state.pending--;
            if(now-p.time>=definitions[p.state.data.enemy].duration || p.time>=418) {MarkMissed(p.state);continue;}
            Spawn(p,now);
        }
        // A meteor spawned this frame can push meteors that were already placed; redraw them where their bodies are.
        SyncMeteors();
        LastTime=now;
    }
    void Queue(State state,float time)
    {
        var definition=definitions[state.data.enemy];
        Vector3 loopOffset=Vector3.zero;
        if(state.iteration>0 && state.data.offsets.Length>0)loopOffset=state.data.offsets[(state.iteration-1)%state.data.offsets.Length];
        int seed=StableHash(state.data.id)^randomSeed^(state.iteration*7919);
        foreach(var placement in definition.placements)
        {
            Add(0,Vector3.zero,0);
            foreach(var repeat in definition.repeats)
                for(int j=1;j<=repeat._repeatTimes;j++)Add(j*repeat._delayStep,j*repeat._offsetStep,j*repeat._speedStep);
            void Add(float delay,Vector3 offset,float speed)
            {
                pending.Add(new Pending{state=state,placement=placement,time=time+(placement.delayTime+delay)/state.data.timeScale,
                    extraOffset=loopOffset+offset,speedDelta=speed,seed=++seed});state.pending++;
                if(!state.data.wipeoutOnly)groups[state.data.group].scheduled++;
            }
        }
    }
    // BG03 "BG Slide Range Track": BGSlideRangeClip _slideRange 50 at 0-185 s (2 s ease-out) and 201-540 s
    // (2 s ease-in), linear mix curves. BGSlideRangeMixer sums weight * range; with no clip the range is 0.
    public static float SlideRange(float t)
    {
        if(t<0 || t>=540)return 0;
        if(t<183)return 50;
        if(t<185)return 50*(185-t)/2;
        if(t<201)return 0;
        if(t<203)return 50*(t-201)/2;
        return 50;
    }
    void MarkMissed(State state){if(!state.data.wipeoutOnly)groups[state.data.group].escaped++;}
    void Spawn(Pending p,float now)
    {
        var d=definitions[p.state.data.enemy];var placement=p.placement;
        if(d.model=="Pf_Ene_Md01")d=Round1Md01Motion.Definition(d,p.state.data.indexValue);
        string model=string.IsNullOrEmpty(placement.objectName)?d.model:placement.objectName;
        if(!models.TryGetValue(model,out var visual) || !visual.prefab)throw new InvalidOperationException("Missing extracted visual "+model);
        var rng=new System.Random(p.seed);
        var jitter=new Vector3((float)rng.NextDouble()*placement._offsetRange.x,(float)rng.NextDouble()*placement._offsetRange.y,(float)rng.NextDouble()*placement._offsetRange.z);
        Vector3 origin=d.position+p.state.data.offset+placement.offset+p.extraOffset+jitter;
        var actor=new Actor{state=p.state,definition=d,placement=placement,born=p.time,origin=origin,
            speed=Mathf.Max(1,placement.moveSpeed+p.speedDelta+(float)rng.NextDouble()*placement._moveSpeedRange),routes=d.routes};
        if(actor.routes.Length==0)
        {
            var routeEvent=Array.Find(d.events,a=>a.eventType==15 && routes.ContainsKey(a.stringValue??""));
            if(routeEvent!=null)actor.routes=new[]{routeEvent.stringValue};
        }
        var heading=Array.Find(d.events,a=>a.eventType==6 && a.vectorValue.sqrMagnitude>0);
        if(model=="Pf_Ene_Md01")actor.md01=new Round1Md01Motion(origin,actor.speed,placement.rotate+p.state.data.rotate,d.events);
        if(model=="Pf_Ene_Sa01" && heading!=null)actor.sa01=new Round1Sa01Motion(origin,PlayerLayerPosition(),actor.speed,heading);
        if(model.Contains("Meteo") && actor.routes.Length==0)
        {
            actor.meteor=Round1MeteorField.Create(model,origin,Quaternion.Euler(placement.rotate+p.state.data.rotate),actor.speed*p.state.data.timeScale,rng);
            ObstaclesFromEnemies(now);meteors.Add(actor.meteor);
        }
        if(actor.md01==null && actor.sa01==null && Round1RouteProgram.Applies(d))actor.program=new Round1RouteProgram(origin,actor.speed,d.events,routes,d.duration);
        actor.direction=heading!=null?heading.vectorValue.normalized:Quaternion.Euler(placement.rotate+p.state.data.rotate)*Vector3.forward;
        if(heading==null && actor.routes.Length==0 && !model.Contains("Meteo"))
        {
            // Native specialized movers are not reconstructed. Enter from the authored edge.
            actor.direction=Mathf.Abs(origin.z)>100?new Vector3(0,0,-Mathf.Sign(origin.z)):new Vector3(-Mathf.Sign(origin.x),0,0);
            if(actor.direction.sqrMagnitude<.1f)actor.direction=Vector3.back;
        }
        var shown=origin+LayerOffset;
        var spawnViewport=actor.OriginalProjection?Round1Sa01Motion.ToViewport(shown,combat.weapon.player.stageCamera.aspect):ToViewport(shown);
        var t=combat.SpawnSourceTarget(visual.prefab,spawnViewport,health[model]);
        if(t==null){CapacityMisses++;MarkMissed(p.state);return;}
        t.sourceSpawn=true;t.sourceScale=WorldScale*(actor.OriginalProjection?Source.sourceHeight/Round1Sa01Motion.ViewHeight(origin.y):1);t.radius=Radius(model);actor.hitShape=Round1HitShapes.Get(model);t.fires=Array.Exists(d.events,a=>a.eventType==8 || a.eventType==83);
        actor.animation=t.visual.GetComponent<Round1EnemyAnimation>();
        if(!actor.animation)actor.animation=t.visual.AddComponent<Round1EnemyAnimation>();
        t.animation=actor.animation;
        // MeteoEnemy._modelTop takes the body's rotation; the authored Rotate event stays on the root.
        t.physicsBody=actor.meteor!=null;
        if(actor.meteor!=null)foreach(Transform child in t.visual.transform)if(child.name.StartsWith("pf_ene_obj_meteo"))actor.meteorModel=child;
        actor.animation.Begin(d,placement.rotate+p.state.data.rotate,name=>routes.TryGetValue(name,out var route)?route.length:(actor.md01!=null?Round1Md01Motion.RouteLength(name):0),actor.speed);
        var fire=Array.Find(d.events,a=>a.eventType==83);t.fireInterval=fire!=null?Mathf.Max(.25f,fire.repeatDelay):1.8f;t.fire=t.fireInterval;
        actor.wholeBody=WholeBodyExit.Contains(model);
        actor.target=t;p.state.actors.Add(actor);actors.Add(actor);live.Add(t.id,actor);TotalSpawned++;
        Round1TrackCapture.Active?.Birth(t.id,p.state.data,d,model,now,t.health);
        UpdateActor(actor,now);combat.PlaceSourceTarget(t);
        if(combat.sourceAttacks)combat.sourceAttacks.Register(t,d,p.time,p.state.data.timeScale);
        if(model==ChainHead)SpawnChain(actor,now);
    }
    void SpawnChain(Actor head,float now)
    {
        var prefab=combat.effects.Prefab(ChainBody);if(!prefab){Debug.LogWarning("Missing "+ChainBody+"; Mj01 has no body.",this);return;}
        var chain=new Chain{head=head,headId=head.target.id,id=++chainSerial,bodies=new Body[ChainLength],lastTime=now};
        head.target.chain=chain.id;var shape=Round1HitShapes.Get(ChainBody);
        for(int i=0;i<ChainLength;i++)
        {
            var t=combat.SpawnSourceTarget(prefab,ToViewport(head.origin+LayerOffset),BodyHealth);
            if(t==null){CapacityMisses++;continue;}
            t.sourceSpawn=true;t.sourceScale=WorldScale;t.lockOn=false;t.blocksLaser=true;t.score=(int)BodyScore;t.chain=chain.id;t.invulnerable=true;
            Round1Combat.SetHitCircles(t,shape,Quaternion.identity,1/Source.sourceHeight,1/Source.sourceHeight);
            chain.bodies[i]=new Body{target=t,id=t.id,position=head.origin};ChainBodiesSpawned++;
        }
        chains.Add(chain);
    }
    // Models whose parts trail far from their root (Lb01's 190-unit snake body): exit by the whole body, not the root.
    static readonly HashSet<string> WholeBodyExit=new HashSet<string>{"Pf_Ene_Lb01"};
    // True while any enabled mesh of the model projects inside the viewport (shrunk by inset on each side).
    public bool BodyOnScreen(GameObject visual,float inset=0)
    {
        if(!visual)return false;var cam=combat.weapon.player.stageCamera;
        foreach(var r in visual.GetComponentsInChildren<Renderer>())
        {
            if(!r.enabled || r is ParticleSystemRenderer)continue;
            var b=r.bounds;float minX=float.MaxValue,minY=float.MaxValue,maxX=float.MinValue,maxY=float.MinValue;bool front=false;
            for(int i=0;i<8;i++)
            {
                var corner=b.center+Vector3.Scale(b.extents,new Vector3((i&1)==0?-1:1,(i&2)==0?-1:1,(i&4)==0?-1:1));
                var v=cam.WorldToViewportPoint(corner);if(v.z<=0)continue;front=true;
                minX=Mathf.Min(minX,v.x);maxX=Mathf.Max(maxX,v.x);minY=Mathf.Min(minY,v.y);maxY=Mathf.Max(maxY,v.y);
            }
            if(front && maxX>=inset && minX<=1-inset && maxY>=inset && minY<=1-inset)return true;
        }
        return false;
    }
    Vector3 PathAt(Actor a,float age)=>a.program!=null?a.program.Sample(Mathf.Max(0,age)):Position(a,Mathf.Max(0,age));
    void UpdateChains(float now)
    {
        for(int c=chains.Count-1;c>=0;c--)
        {
            var chain=chains[c];var h=chain.head;float dt=Mathf.Max(0,now-chain.lastTime);chain.lastTime=now;
            float headAge=(Mathf.Max(0,now-h.born)+NativeFirstTick)*h.state.data.timeScale;
            if(!chain.headGone && (h.finished || !h.target.active || h.target.id!=chain.headId))
            {
                chain.headGone=true;
                // Ene_Mj01h death: every body gets SetParentKilled; bodies not yet released never come out.
                if(h.killed)for(int i=0;i<ChainLength;i++)Detach(chain,i);
            }
            bool any=false;
            for(int i=0;i<ChainLength;i++)
            {
                var b=chain.bodies[i];if(b==null || b.gone)continue;
                if(!b.target.active || b.target.id!=b.id)
                {
                    b.gone=true;
                    if(b.target.id==b.id && b.target.health<=0)
                    {
                        // ReceiveKill: the bodies behind this one are cut loose and no more are released.
                        ChainBodiesKilled++;chain.broken=true;for(int j=i+1;j<ChainLength;j++)Detach(chain,j);
                    }
                    continue;
                }
                any=true;
                float lag=(i+1)*UnitDistance/Mathf.Max(1,h.speed);
                if(!b.started && !b.detached && !chain.broken && (!chain.headGone || !h.killed) && headAge>=lag){b.started=true;b.target.invulnerable=false;}
                var previous=b.position;
                if(b.detached)b.position+=BodyGravity*dt;
                else if(b.started)b.position=PathAt(h,headAge-lag);
                var move=b.position-previous;
                if(move.sqrMagnitude>1e-6f && !b.detached)b.target.sourceRotation=Quaternion.Euler(0,Mathf.Atan2(move.x,move.z)*Mathf.Rad2Deg,0);
                b.target.position=ToViewport(b.position+LayerOffset)+b.target.nudge;
                Round1Combat.SetHitCircles(b.target,Round1HitShapes.Get(ChainBody),b.target.sourceRotation,1/Source.sourceHeight,1/Source.sourceHeight);
                var v=b.target.position;
                bool visible=v.x>=0 && v.x<=1 && v.y>=0 && v.y<=1;b.entered|=visible && (b.started || b.detached);
                bool outOfArea=v.x<-GameScreenMargin || v.x>1+GameScreenMargin || v.y<-GameScreenMargin || v.y>1+GameScreenMargin;
                if(!b.entered || !outOfArea)b.outsideSince=-1;else if(b.outsideSince<0)b.outsideSince=now;
                bool leaving=b.entered && b.outsideSince>=0 && now-b.outsideSince>=NativeExitDelay-.0001f;
                // A body that was never released (the head died or the chain broke first) goes with its head.
                bool stranded=!b.started && !b.detached && (chain.broken || chain.headGone);
                if(leaving || stranded || headAge-lag>h.definition.duration){b.gone=true;combat.DespawnSourceTarget(b.target);continue;}
                combat.PlaceSourceTarget(b.target);
            }
            if(!any && chain.headGone)chains.RemoveAt(c);
        }
    }
    void Detach(Chain chain,int i)
    {
        var b=chain.bodies[i];if(b==null || b.gone || b.detached)return;
        if(!b.started)return; // not released yet: stranded, removed in UpdateChains
        b.detached=true;ChainBodiesDetached++;
    }
    public int LiveChainBodies=>chains.Sum(c=>c.bodies.Count(b=>b!=null && !b.gone && b.target.active));
    public void OnRemoved(Round1Combat.Target target,bool killed)
    {
        if(!live.TryGetValue(target.id,out var a))return;
        Round1TrackCapture.Active?.End(target.id,killed);
        a.finished=true;a.killed=killed;live.Remove(target.id);meteors.Remove(a.meteor);
        if(!a.state.data.wipeoutOnly){var g=groups[a.state.data.group];if(killed)g.killed++;else g.escaped++;}
    }
    void UpdateActors(float now)
    {
        ObstaclesFromEnemies(now);meteors.Advance(now);
        for(int i=actors.Count-1;i>=0;i--)
        {
            var actor=actors[i];if(actor.finished){actors.RemoveAt(i);continue;}
            UpdateActor(actor,now);
        }
        UpdateChains(now);
    }
    // A native enemy runs its first movement update on the frame it activates, so on its spawn frame it is
    // already one 60 Hz tick along (recorded Sa01 at Z 98.67 for an authored 100, Md01 likewise).
    const float NativeFirstTick=1f/60;
    // Sa01's mover tests InGameManager.IsGameArea: viewport inside gameScreenArea (-.15,-.15,1.3,1.3).
    // The recorded enemy stops playing about two frames after its first frame outside.
    const float GameScreenMargin=.15f,NativeExitDelay=2f/60;
    void UpdateActor(Actor a,float now)
    {
        float age=(Mathf.Max(0,now-a.born)+NativeFirstTick)*a.state.data.timeScale;
        Vector3 position,ahead,before,after;
        if(a.md01!=null)
        {
            a.md01.Advance(age);position=a.md01.Position;before=a.md01.Sample(Mathf.Max(0,age-.08f));after=a.md01.Sample(age+.08f);ahead=after-before;
        }
        else if(a.sa01!=null)
        {
            a.sa01.Advance(age,PlayerLayerPosition());position=a.sa01.Position;ahead=a.sa01.Direction;
            before=position-ahead*.08f;after=position+ahead*.08f;
        }
        else if(a.meteor!=null)
        {
            var v=a.meteor.velocity;position=a.meteor.position;ahead=v*.01f;before=position-v*.08f;after=position+v*.08f;
        }
        else if(a.program!=null)
        {position=a.program.Sample(age);ahead=a.program.Sample(age+.01f)-position;before=a.program.Sample(Mathf.Max(0,age-.08f));after=a.program.Sample(age+.08f);}
        else {position=Position(a,age);ahead=Position(a,age+.01f)-position;before=Position(a,Mathf.Max(0,age-.08f));after=Position(a,age+.08f);}
        var shown=position+LayerOffset;
        a.target.position=(a.OriginalProjection?Round1Sa01Motion.ToViewport(shown,combat.weapon.player.stageCamera.aspect):ToViewport(shown))+a.target.nudge;
        a.animation.Sample(age,a.placement.lookAt,ahead,before,after);
        if(a.meteorModel)a.meteorModel.localRotation=a.meteor.rotation;
        if(a.meteor!=null)a.target.solidRadius=a.meteor.radius/Source.sourceHeight;
        a.target.sourceRotation=a.md01!=null?a.md01.Facing:a.animation.Facing;
        // The original scales hit shapes by a fixed pixels-per-unit (HybridCollisions, _scaleFactorZ at the stage plane), so
        // radii don't grow with height; offsets follow the enemy's own projection. Radii use the frame the model is drawn in.
        Round1Combat.SetHitCircles(a.target,a.hitShape,a.target.sourceRotation,1/(a.OriginalProjection?Round1Sa01Motion.ViewHeight(position.y):Source.sourceHeight),
            1/(a.OriginalProjection?Round1Sa01Motion.ViewHeight():Source.sourceHeight));
        // Record where it is drawn: its path plus any separation nudge, back in its own source frame.
        float frame=a.OriginalProjection?Round1Sa01Motion.ViewHeight(position.y):Source.sourceHeight;
        var drawn=shown+new Vector3(a.target.nudge.x*frame*combat.weapon.player.stageCamera.aspect,0,a.target.nudge.y*frame);
        Round1TrackCapture.Active?.Record(a.target.id,now,drawn,a.target.sourceRotation*a.animation.RootRotation);
        bool visible=a.target.position.x>=0 && a.target.position.x<=1 && a.target.position.y>=0 && a.target.position.y<=1;
        a.entered|=visible;
        bool outside=a.target.position.x<-.25f || a.target.position.x>1.25f || a.target.position.y<-.25f || a.target.position.y>1.25f;
        // Sa01 and the route-program movers test IsGameArea: gameScreenArea plus about two frames.
        if(a.sa01!=null || a.program!=null)
        {
            var v=a.target.position;
            bool outOfArea=v.x<-GameScreenMargin || v.x>1+GameScreenMargin || v.y<-GameScreenMargin || v.y>1+GameScreenMargin;
            if(!a.entered || !outOfArea)a.outsideSince=-1;else if(a.outsideSince<0)a.outsideSince=now;
            if(a.entered)outside=a.outsideSince>=0 && now-a.outsideSince>=NativeExitDelay-.0001f;
        }
        // A long multi-part enemy leaves only once all of it is off screen: the original Lb01 ends with its head 165-320
        // source units beyond the edge (recordings/ash-r1-stage01-nofire-20261027, all 8 exits), about its own length.
        // Its root can stay off screen the whole time (the body shows), so entering also counts the body.
        if(a.wholeBody){bool body=BodyOnScreen(a.target.visual);a.entered|=body;outside=!body;}
        // Md01's native event program waits for its final common_D200 spline to finish. Its
        // exit endpoint is well below the viewport; a generic screen cull truncates that route.
        bool finished=a.md01!=null ? age>=a.md01.Duration :
            age>=a.definition.duration || (a.entered && outside) || (!a.entered && age>12 && outside);
        if(finished)combat.DespawnSourceTarget(a.target);
    }
    Vector3 Position(Actor a,float age)
    {
        if(a.routes.Length==0)return a.origin+a.direction*a.speed*age;
        float distance=age*a.speed;Vector3 displacement=Vector3.zero;
        foreach(string name in a.routes)
        {
            var r=routes[name];if(distance<=r.length)return a.origin+displacement+r.Sample(distance/Mathf.Max(.0001f,r.length));
            displacement+=r.points[r.points.Length-1];distance-=r.length;
        }
        // Continue out of the playfield when a finite entry route has ended.
        var last=routes[a.routes[a.routes.Length-1]];
        var tangent=last.tangents.Length>0?last.tangents[last.tangents.Length-1]:Vector3.back;
        return a.origin+displacement+tangent.normalized*distance;
    }
    void SyncMeteors(){foreach(var a in actors)if(a.meteor!=null && !a.finished && a.target.active)a.target.position=ToViewport(a.meteor.position+LayerOffset);}
    // After Round1Combat.SeparateAir has moved enemies: push meteors out of them again and redraw the meteors.
    public void SettleMeteors(float now){if(!initialized)return;ObstaclesFromEnemies(now);meteors.Project();SyncMeteors();}
    // Every other air enemy's hit circles, in the meteors' source frame, as obstacles for the meteor physics.
    readonly List<(Vector3 position,Vector3 velocity,float radius,int group,Vector3 centre)> obstacleCircles=new List<(Vector3,Vector3,float,int,Vector3)>();
    readonly Dictionary<long,Vector3> obstacleLast=new Dictionary<long,Vector3>(),obstacleNow=new Dictionary<long,Vector3>();
    float obstacleTime=-1;
    void ObstaclesFromEnemies(float now)
    {
        obstacleCircles.Clear();obstacleNow.Clear();
        float aspect=combat.weapon.player.stageCamera.aspect,h=Source.sourceHeight,dt=now-obstacleTime;
        foreach(var t in combat.Targets)
        {
            if(!t.active || t.ground || t.isBoss || t.physicsBody || !t.visual)continue;
            int n=t.hitCircles?.Length??1;
            for(int i=0;i<n;i++)
            {
                Vector2 vp=t.hitCircles!=null?combat.CirclePosition(t,t.hitCircles[i]):t.position;float r=t.hitCircles!=null?t.hitCircles[i].z:t.radius;
                var source=new Vector3((vp.x-.5f)*h*aspect,0,(vp.y-.5f)*h)-LayerOffset;long key=(long)t.id*256+i;
                var velocity=dt>1e-4f && obstacleLast.TryGetValue(key,out var last)?(source-last)/dt:Vector3.zero;
                var centre=new Vector3((t.position.x-.5f)*h*aspect,0,(t.position.y-.5f)*h)-LayerOffset;
                obstacleNow[key]=source;obstacleCircles.Add((source,velocity,r*h,t.id,centre));
            }
        }
        obstacleLast.Clear();foreach(var kv in obstacleNow)obstacleLast[kv.Key]=kv.Value;obstacleTime=now;
        meteors.SetObstacles(obstacleCircles);
    }
    public Vector2 ToViewport(Vector3 p)=>new Vector2(.5f+p.x/(Source.sourceHeight*combat.weapon.player.stageCamera.aspect),.5f+p.z/Source.sourceHeight);
    Vector3 PlayerSourcePosition()
    {
        var p=combat.weapon.player.viewportPosition;
        // UpdatePlayerPosition stores player localPosition + PlayerTargetOffset (0,0,1).
        return Round1Sa01Motion.PlayerFromViewport(p,combat.weapon.player.stageCamera.aspect)+Vector3.forward;
    }
    // Pursuit compares the enemy's _inGameRoot position with _playerGamePosition; in layer-local terms the
    // player sits at its source position minus the layer offset.
    Vector3 PlayerLayerPosition()=>PlayerSourcePosition()-LayerOffset;
    public float WorldScale=>Vector3.Distance(combat.weapon.player.WorldPoint(Vector2.zero),combat.weapon.player.WorldPoint(Vector2.up))/Source.sourceHeight;
    static float Radius(string name)=>name.Contains("_Lb") ? .055f : name.Contains("_M")&&!name.Contains("Meteo") ? .035f : .022f;
    static int StableHash(string value){unchecked{int n=17;foreach(char c in value)n=n*31+c;return n;}}
}
