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
        public int loopMax,gameModeMask,indexValue,zone;
    }
    // A zone TL (TLEntryClip with _clipFlag zone bits and/or a _conditionFlag; BG08 ZONE A-G, tools/stage_enemies/build_stage_enemies.py).
    [Serializable] public class Zone { public string name;public float start,end;public int zone,condition,failed,succeeded; }
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
        // The RouteLUT's _tangents at t (EvalCachedTangent), or the chord when the route has none.
        public Vector3 SampleTangent(float t)
        {
            if(tangents==null || points==null || tangents.Length!=points.Length || tangents.Length==0)return Sample(Mathf.Min(1,t+.001f))-Sample(Mathf.Max(0,t-.001f));
            if(t<=times[0])return tangents[0];if(t>=1)return tangents[tangents.Length-1];
            int lo=0,hi=times.Length-1;while(hi-lo>1){int mid=(lo+hi)/2;if(times[mid]<=t)lo=mid;else hi=mid;}
            return Vector3.LerpUnclamped(tangents[lo],tangents[hi],(t-times[lo])/Mathf.Max(.000001f,times[hi]-times[lo]));
        }
    }
    [Serializable] public class Model { public string name;public float health; }
    // BGSlideRangeClip windows (stage schedules from tools/stage_enemies carry them; BG03's are the constants below).
    [Serializable] public class Slide { public float start,end,range,easeIn,easeOut; }
    [Serializable] public class Data { public int version,round,gameModeMask;public string stage;public float sourceHeight;public Event[] events;public Definition[] definitions;public Route[] routes;public Model[] models;public Slide[] slides;public Zone[] zones; }
    [Serializable] public class Visual { public string name;public GameObject prefab; }
    class Group { public int scheduled,killed,escaped; }
    class State { public Event data;public int iteration,pending;public bool started,finished;public readonly List<Actor> actors=new List<Actor>(); }
    class Pending { public State state;public Placement placement;public float time,speedDelta;public Vector3 extraOffset;public int seed,placementIndex;public Call call; }
    // One EntryEnemy call: its first placement is the head the attributeFlag-1 placements become children of.
    class Call { public Actor head; }
    class Actor
    {
        public Round1Combat.Target target;public State state;public Definition definition;public Placement placement;
        public float born,speed,outsideSince=-1;public Vector3 origin,direction;public string[] routes;public bool finished,killed,entered;
        public Round1EnemyAnimation animation;
        public Round1Sa01Motion sa01;
        public Round1Md01Motion md01;
        public Round1RouteProgram program;
        // The native EnemyMover event stack (Round1EventStack; evidence/air-route-events/SPEC.md): homing, forward moves,
        // turns, speed ramps, loops; ends by its own native rules instead of the definition duration.
        public Round1EventStack stack;
        // Native parents and children (Round1EventStackGroups): the parent steps its children; part >= 0 is one half of a
        // two-target enemy (Ene_Mm01) sharing the stack with its partner; extraPart actors are not schedule entries.
        public string model;public Actor ownerActor,partner;public readonly List<Actor> children=new List<Actor>();public int part=-1;public bool extraPart;
        public Transform[] nodes;public Quaternion[] nodeBase;public Dictionary<string,(Transform,Quaternion)> childNodes;public LineRenderer[] lines;public Transform[] burners;
        public Round1MeteorField.Body meteor;public Transform meteorModel;public float lastUpdate=-1,meteorInArea,meteorOutside;
        // PhysicsEnemy._node origins (model transforms its physics3d colliders copy), from physics-colliders.json.
        public Transform[] physicsOrigins;
        public Vector3[] hitShape;public bool wholeBody;
        // EnemyMoverSnake (SnakeBones): head, bones, their last directions, and each hit circle's bone (-1 head) and offset.
        public Transform snakeHead;public Transform[] snakeBones;public Vector3[] snakeDirs,snakeOffsets;public int[] snakeCircleBone;
        // Cosmetic class motion of a model node (ClassNodes): Sh01's mesh spin, Mn01c's tumble, Mp01's turret.
        public Transform classNode;public Quaternion classBase=Quaternion.identity,tumble=Quaternion.identity,tumbleSpin=Quaternion.identity;public Vector3 spinRate;public float tumbleRate,tumbleFrames;
        public bool OriginalProjection=>sa01!=null || md01!=null || stack!=null;
    }
    public TextAsset schedule;
    public readonly Dictionary<string,int> SpawnedByModel=new Dictionary<string,int>(),UnseenByModel=new Dictionary<string,int>();
    public readonly List<string> UnseenLog=new List<string>(); // verification: the first unseen removals (model@spawn age viewport end)
    public Round1Combat combat;
    public Visual[] visuals;
    // TLGameModeFlag: Tutorial 1, StoryA/B/C 2/4/8, Arcade1 32, Arcade2 64, Team 128, Rush 256.
    public const int StoryAMask=2,Arcade1Mask=32;
    public int gameModeMask=StoryAMask,randomSeed=3101;
    // No new spawns at or after this stage time (BG03: the boss warning at 418 s).
    public float spawnCutoff=418;
    public Data Source { get; private set; }
    public int TotalSpawned { get; private set; }
    public int CapacityMisses { get; private set; }
    public int TriggeredEvents { get; private set; }
    public int ConditionalSkipped { get; private set; }
    // Events in a zone TL that did not start (BG08: the branch the player's performance did not pick).
    public int ZoneSkipped { get; private set; }
    // InGameManager TL flags (SetTLFlag / ResetTLFlag / IsTLFlag) and the zone TLs that read and write them.
    public int TLFlags { get; private set; }
    public readonly List<string> ZoneLog=new List<string>();
    public const int NoBomber=1,NoDead=2,Extinction=4,Pipil50=8;
    class ZoneState { public Zone data;public bool started,finished,playing;public int bombsAt,deathsAt; }
    readonly List<ZoneState> zones=new List<ZoneState>();
    public int PendingCount => pending.Count;
    public float LastTime { get; private set; }
    // InGameManager.LateUpdate moves _inGameEnemyRoot to -.5 * _bgSlideRate * CinemachineMan._BGCameraSlideRange
    // (X only). _bgSlideRate = clamp(player X / PlayerControllWidth 123, -1, 1), held while the entry autopilot
    // runs. Ground objects live outside this root. Actors move in the root's local frame; this is its offset.
    public const float PlayerControllWidth=123;
    public Vector3 LayerOffset { get; private set; }
    // The same call (UpdateSlideRate / LateUpdate) first runs CinemachineMan.SetBGCameraSlide (0x1CC5D50): the BG root,
    // InGameStage._stageCamera (the rail Camera, set by SetBGCameraTransform(camera, 50) in SetupStage), gets
    // SetLocalPositionAndRotation(rate * _BGCameraSlideRange + _shakeOffset, _groundCameraRotate * _shakeRotate).
    // The range is X only (SetBGCameraSlideRange writes x); shake is not reconstructed. So the background slides by the
    // full range with the ship while the enemy root takes -0.5 of it. Evidence: evidence/camera-slide.
    public Vector3 CameraSlide { get; private set; }
    Transform slidCamera;Vector3 cameraBase,cameraWritten;
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
    sealed class Chain { public Actor head;public int headId,id;public Body[] bodies;public bool broken,headGone,headStopped;public float lastTime;public int kills;public Vector2 headAt; }
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
        if(Source.version!=1 || string.IsNullOrEmpty(Source.stage))throw new InvalidOperationException("Wrong enemy timeline data");
        foreach(var d in Source.definitions)definitions.Add(d.id,d);
        foreach(var r in Source.routes)
        {
            for(int i=1;i<r.points.Length;i++)r.length+=Vector3.Distance(r.points[i-1],r.points[i]);
            routes.Add(r.name,r);
        }
        // Routes a native class picks itself (Ene_Mp02._routeNames, Ene_Sq01/Mb01 programs) are not in the stage timelines.
        var classRoutes=Resources.Load<TextAsset>("StageEnemies/class-routes");
        if(classRoutes)foreach(var r in JsonUtility.FromJson<Data>(classRoutes.text).routes)
            if(!routes.ContainsKey(r.name)){for(int i=1;i<r.points.Length;i++)r.length+=Vector3.Distance(r.points[i-1],r.points[i]);routes.Add(r.name,r);}
        foreach(var v in visuals)models.Add(v.name,v);
        foreach(var m in Source.models)health.Add(m.name,Round1Balance.Current.EnemyHealth(m.name));
        if(Source.zones!=null)foreach(var z in Source.zones)zones.Add(new ZoneState{data=z});
        foreach(var e in Source.events)
        {
            // Ground entries (BGxx_ge, group "ground/...") are played by Round1GroundEnemies, not as air enemies.
            if(e.group!=null && e.group.StartsWith("ground/"))continue;
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
        ResetZones(time);
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
        float range=SlideAt(now);
        SlideCamera(new Vector3(slideRate*range,0,0));
        LayerOffset=new Vector3(-.5f*slideRate*range,0,0);
        UpdateActors(now);
        StepZones(now,false);
        if(combat.boss && combat.boss.SuppressesWaves)
        {pending.Clear();LastTime=now;return;}
        foreach(var state in states)
        {
            var e=state.data;if(state.finished)continue;
            if(!state.started && now+.00001f>=e.start)
            {
                state.started=true;
                if(now>=e.end || (e.gameModeMask!=0 && (e.gameModeMask & gameModeMask)==0)) {state.finished=true;continue;}
                if(e.zone!=0 && !ZonePlaying(e.zone)){ZoneSkipped++;state.finished=true;continue;}
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
            if(now-p.time>=Lifetime(definitions[p.state.data.enemy]) || p.time>=spawnCutoff) {MarkMissed(p.state);continue;}
            Spawn(p,now);
        }
        LastTime=now;
    }
    // Zone TLs (native InGame.Kernel.Timeline.TLEntryBehaviour):
    // - OnBehaviourPlay 0x1D522C0: a TL with a _conditionFlag clears its _failedFlag|_successedFlag; a TL with zone bits in
    //   _clipFlag starts only if IsCheckStartTL 0x1D51BB0 finds InGameManager.IsTLFlag(_clipFlag & AllZone).
    // - OnBehaviourPause 0x1D51F50: a conditional TL that played checks the areas it covers (NoBomber: no bomb, NoDead: no
    //   death, Extinction: destruction rate 1, Pipil50: pipil rate .5) and sets _successedFlag or _failedFlag.
    // BG08: ZONE A -> B (failed) / C (succeeded) -> D / E -> F / G. Bombs and deaths are counted over the TL's time window.
    // Extinction and Pipil50 are used by no stage and count as met.
    public bool ZonePlaying(int zone)
    {
        if(zone==0)return true;
        foreach(var z in zones)if(z.data.zone==zone && z.started && z.playing)return true;
        return false;
    }
    // Seeking (restart, F3 boss jump): the zones before time are replayed on the clean route (every condition met).
    void ResetZones(float time)
    {
        TLFlags=0;ZoneSkipped=0;ZoneLog.Clear();
        foreach(var z in zones)z.started=z.finished=z.playing=false;
        StepZones(time-.0002f,true);
    }
    // Boundaries in time order; at one instant the ending TLs set their flags before the starting ones check them.
    void StepZones(float now,bool replay)
    {
        for(int guard=0;guard<4*zones.Count+4;guard++)
        {
            float t=float.MaxValue;
            foreach(var z in zones){if(!z.started)t=Mathf.Min(t,z.data.start);else if(!z.finished)t=Mathf.Min(t,z.data.end);}
            if(t>now+.00001f)return;
            foreach(var z in zones)if(z.started && !z.finished && z.data.end<=t+.00001f)EndZone(z,replay);
            foreach(var z in zones)if(!z.started && z.data.start<=t+.00001f)StartZone(z);
        }
    }
    void StartZone(ZoneState z)
    {
        var d=z.data;z.started=true;
        if(d.condition!=0)TLFlags&=~(d.failed|d.succeeded);
        z.playing=d.zone==0 || (TLFlags&d.zone)!=0;
        var w=combat?combat.weapon:null;z.bombsAt=w?w.BombsUsed:0;z.deathsAt=w?w.Deaths:0;
        ZoneLog.Add(d.name+(z.playing?" start ":" skip ")+d.start.ToString("0.##"));
    }
    void EndZone(ZoneState z,bool replay)
    {
        var d=z.data;z.finished=true;if(!z.playing || d.condition==0)return;
        bool ok=replay || ZoneConditionMet(z);
        TLFlags|=ok?d.succeeded:d.failed;
        ZoneLog.Add(d.name+(ok?" succeeded ":" failed ")+d.end.ToString("0.##"));
    }
    bool ZoneConditionMet(ZoneState z)
    {
        var w=combat?combat.weapon:null;if(!w)return true;
        if((z.data.condition&NoBomber)!=0 && w.BombsUsed>z.bombsAt)return false;
        if((z.data.condition&NoDead)!=0 && w.Deaths>z.deathsAt)return false;
        return true;
    }
    // Zone bits that play when every condition is met (the stage inspection overlay shows this route).
    public static int CleanRouteZones(Zone[] list)
    {
        if(list==null || list.Length==0)return 0;
        var marks=new List<(float t,int start,Zone z)>();
        foreach(var z in list){marks.Add((z.start,1,z));marks.Add((z.end,0,z));}
        marks.Sort((a,b)=>a.t!=b.t?a.t.CompareTo(b.t):a.start.CompareTo(b.start));
        int flags=0,played=0;var playing=new HashSet<Zone>();
        foreach(var m in marks)
        {
            var z=m.z;
            if(m.start==1){if(z.condition!=0)flags&=~(z.failed|z.succeeded);if(z.zone==0 || (flags&z.zone)!=0){playing.Add(z);played|=z.zone;}}
            else if(playing.Contains(z) && z.condition!=0)flags|=z.succeeded;
        }
        return played;
    }
    void Queue(State state,float time)
    {
        var definition=definitions[state.data.enemy];
        Vector3 loopOffset=Vector3.zero;
        if(state.iteration>0 && state.data.offsets.Length>0)loopOffset=state.data.offsets[(state.iteration-1)%state.data.offsets.Length];
        int seed=StableHash(state.data.id)^randomSeed^(state.iteration*7919);
        var call=new Call();int index=0;
        foreach(var placement in definition.placements)
        {
            int placementIndex=index++;
            Add(0,Vector3.zero,0);
            foreach(var repeat in definition.repeats)
                for(int j=1;j<=repeat._repeatTimes;j++)Add(j*repeat._delayStep,j*repeat._offsetStep,j*repeat._speedStep);
            void Add(float delay,Vector3 offset,float speed)
            {
                pending.Add(new Pending{state=state,placement=placement,time=time+(placement.delayTime+delay)/state.data.timeScale,
                    extraOffset=loopOffset+offset,speedDelta=speed,seed=++seed,placementIndex=placementIndex,call=call});state.pending++;
                if(!state.data.wipeoutOnly)groups[state.data.group].scheduled++;
            }
        }
    }
    // BG03 "BG Slide Range Track": BGSlideRangeClip _slideRange 50 at 0-185 s (2 s ease-out) and 201-540 s
    // (2 s ease-in), linear mix curves. BGSlideRangeMixer sums weight * range; with no clip the range is 0.
    // BGSlideRangeMixer: sum of weight * _slideRange over the active clips, linear ease in/out.
    public float SlideAt(float t)
    {
        if(Source==null || Source.slides==null || Source.slides.Length==0)return SlideRange(t);
        float sum=0;
        foreach(var s in Source.slides)
        {
            if(t<s.start || t>=s.end)continue;
            float w=1;
            if(s.easeIn>0)w=Mathf.Min(w,(t-s.start)/s.easeIn);
            if(s.easeOut>0)w=Mathf.Min(w,(s.end-t)/s.easeOut);
            sum+=Mathf.Clamp01(w)*s.range;
        }
        return sum;
    }
    // durationTime 0 means no time limit (other stages' Sc01/Sn01); BG03 has none.
    static float Lifetime(Definition d)=>d.duration>0?d.duration:float.MaxValue;
    public static float SlideRange(float t)
    {
        if(t<0 || t>=540)return 0;
        if(t<183)return 50;
        if(t<185)return 50*(185-t)/2;
        if(t<201)return 0;
        if(t<203)return 50*(t-201)/2;
        return 50;
    }
    // Air programs the event stack runs, with the class movers it hosts (Round1EventStack.HasClassMover). Bosses, and
    // classes whose own native code moves them and is not ported yet (specs in evidence/movers), keep their own movers.
    static readonly HashSet<string> OwnMovers=new HashSet<string>{"Pf_Ene_Lc01","Pf_Ene_Sa01","Pf_Ene_Md01"};
    // BG03 keeps the movers validated against recordings of the original (Round 1). Class routes (Lb01: it flew straight in
    // there before) run natively everywhere.
    bool NativeHere(string model)=>Source.stage!="BG03" || Round1EventStack.HasClassRoutes(model);
    bool StackDriven(string model,Definition d)=>NativeHere(model) && !model.StartsWith("Pf_Ene_Bos") && !OwnMovers.Contains(model)
        && (Round1EventStack.HasClassMover(model) || Round1EventStack.Applies(d) || RouteDriven(model,d));
    // SplineMover route mode (Round1EventStack.RouteMode). Mj01h keeps its chain mover, stage zone objects their own.
    static bool RouteDriven(string model,Definition d)=>Round1EventStack.RouteMode(d,model) && model!="Pf_Ene_Mj01h" && !model.StartsWith("Pf_EneObj");
    void MarkMissed(State state){if(!state.data.wipeoutOnly)groups[state.data.group].escaped++;}
    void Spawn(Pending p,float now)
    {
        var d=definitions[p.state.data.enemy];var placement=p.placement;
        if(d.model=="Pf_Ene_Md01")d=Round1Md01Motion.Definition(d,p.state.data.indexValue);
        string model=string.IsNullOrEmpty(placement.objectName)?d.model:placement.objectName;
        if(Source.stage!="BG03" && Round1EventStack.HasClassProgram(model))d=ClassProgram(d,model,p.state.data.indexValue);
        if(!models.TryGetValue(model,out var visual) || !visual.prefab)throw new InvalidOperationException("Missing extracted visual "+model);
        var rng=new System.Random(p.seed);
        var jitter=new Vector3((float)rng.NextDouble()*placement._offsetRange.x,(float)rng.NextDouble()*placement._offsetRange.y,(float)rng.NextDouble()*placement._offsetRange.z);
        Vector3 origin=d.position+p.state.data.offset+placement.offset+p.extraOffset+jitter;
        var actor=new Actor{state=p.state,definition=d,placement=placement,born=p.time,origin=origin,model=model,
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
            meteors.Add(actor.meteor);
        }
        bool classMover=NativeHere(model) && (Round1EventStack.HasClassMover(model) || RouteDriven(model,d)); // needs the stack's frame
        if(actor.md01==null && actor.sa01==null && !classMover && Round1RouteProgram.Applies(d))actor.program=new Round1RouteProgram(origin,actor.speed,d.events,routes,d.duration);
        if(actor.md01==null && actor.sa01==null && actor.program==null && actor.meteor==null && StackDriven(model,d))
            actor.stack=new Round1EventStack(d,origin,(placement.rotate+p.state.data.rotate).y,actor.speed,routes,model,p.seed,PlayerLayerPosition,p.state.data.indexValue);
        // A route-mode definition whose routes are missing would stand still: leave it to the generic mover.
        if(actor.stack!=null && !Round1EventStack.Applies(d) && !Round1EventStack.HasClassMover(model) && !actor.stack.RouteDrivenMover)actor.stack=null;
        if(actor.stack!=null)actor.stack.HasChild=ChildPaths(visual.prefab).Contains;
        // EntryEnemy: an attributeFlag-1 placement becomes the head's child (Ene_Mk01's Si01 swarm).
        if(p.placementIndex==0)p.call.head=actor;
        else if((placement.attributeFlag&1)!=0 && actor.stack!=null && p.call.head?.stack!=null && !p.call.head.finished && p.call.head.stack.Model=="Pf_Ene_Mk01")
        {p.call.head.stack.Adopt(actor.stack);actor.ownerActor=p.call.head;p.call.head.children.Add(actor);}
        // Ene_Ml01._foodListup: the Pf_Ene_Sj01 in the line-up when it starts, in spawn order.
        if(model=="Pf_Ene_Ml01" && actor.stack!=null)actor.stack.SetFood(actors.Where(x=>!x.finished && x.stack!=null && x.model=="Pf_Ene_Sj01").Select(x=>x.stack));
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
        ResetChildren(t.visual);
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
        if(combat.sourceAttacks)combat.sourceAttacks.Register(t,d,p.time,p.state.data.timeScale,actor.stack!=null && actor.stack.TimesBullets);
        // Ene_Mf01._onBulletFire: mf01_fire2 when the player is within 60 of its circle's centre (_circlePos), else mf01_fire1.
        if(model=="Pf_Ene_Mf01" && Source.stage!="BG03" && combat.sourceAttacks)
        {
            var circle=new Vector3(origin.x+(d.name.Contains("a")?-60:60),origin.y,10);
            combat.sourceAttacks.SetTemplatePicker(t,_=>Vector3.Distance(circle,PlayerLayerPosition())<60?"mf01_fire2":"mf01_fire1");
        }
        if(model=="Pf_Ene_Mm01" && actor.stack!=null)SpawnHalf(actor,visual,BeginAnimation,now);
        if(model==ChainHead)SpawnChain(actor,now);
        void BeginAnimation(Actor a)=>a.animation.Begin(d,placement.rotate+p.state.data.rotate,name=>routes.TryGetValue(name,out var route)?route.length:0,a.speed);
    }
    readonly Dictionary<(string,int),Definition> classPrograms=new Dictionary<(string,int),Definition>();
    Definition ClassProgram(Definition d,string model,int index)
    {
        if(!classPrograms.TryGetValue((d.id,index),out var c))classPrograms[(d.id,index)]=c=Round1EventStack.WithClassProgram(d,model,index);
        return c;
    }
    // Ene_Mm01's halves are separate parts (PartsList left/right, each its own collision): two targets on one stack, each
    // drawing its own half of the prefab. The laser between them is Round1EnemyAttacks.SetBridge.
    static readonly Vector3[] MmHalfShape={new Vector3(0,-1,17),new Vector3(0,1,17)};
    void SpawnHalf(Actor a,Visual visual,Action<Actor> begin,float now)
    {
        var t=combat.SpawnSourceTarget(visual.prefab,a.target.position,health[a.model]);if(t==null){CapacityMisses++;return;}
        t.sourceSpawn=true;t.sourceScale=a.target.sourceScale;t.radius=a.target.radius;t.fires=false;
        a.part=0;a.nodes=null;a.hitShape=MmHalfShape;   // its first update ran as a whole enemy: find the half nodes again
        var b=new Actor{state=a.state,definition=a.definition,placement=a.placement,born=a.born,origin=a.origin,speed=a.speed,routes=a.routes,model=a.model,
            stack=a.stack,part=1,partner=a,extraPart=true,hitShape=MmHalfShape,target=t};
        a.partner=b;b.animation=t.visual.GetComponent<Round1EnemyAnimation>();if(!b.animation)b.animation=t.visual.AddComponent<Round1EnemyAnimation>();
        t.animation=b.animation;begin(b);
        actors.Add(b);live.Add(t.id,b);Round1TrackCapture.Active?.Birth(t.id,a.state.data,a.definition,a.model,now,t.health);
        UpdateActor(b,now);combat.PlaceSourceTarget(t);
        // INIT puts the root on the player's row (or column): place the first target as its half before any contact test.
        UpdateActor(a,now);combat.PlaceSourceTarget(a.target);
    }
    // Ene_Mn01h._createChildren: the shield bits the core summoned this frame get their targets.
    static readonly Definition BitDefinition=new Definition{id="mn01_shield_bit",name="mn01_shield_bit",model="Pf_Ene_Mn01c",
        events=new ActionData[0],routes=new string[0],placements=new[]{new Placement()},repeats=new Repeat[0]};
    void SpawnSummoned(Actor owner,float now)
    {
        var s=owner.stack;if(s==null || s.Summoned.Count==0)return;
        var list=s.Summoned.ToArray();s.Summoned.Clear();
        foreach(var c in list)
        {
            if(!models.TryGetValue(c.Model,out var visual) || !visual.prefab){Debug.LogWarning("Missing extracted visual "+c.Model+" (summoned)",this);c.Remove(false);continue;}
            var t=combat.SpawnSourceTarget(visual.prefab,Round1Sa01Motion.ToViewport(c.Position+LayerOffset,combat.weapon.player.stageCamera.aspect),Round1Balance.Current.EnemyHealth(c.Model));
            if(t==null){CapacityMisses++;c.Remove(false);continue;}
            t.sourceSpawn=true;t.sourceScale=WorldScale*Source.sourceHeight/Round1Sa01Motion.ViewHeight(c.Position.y);t.radius=Radius(c.Model);t.fires=false;
            var b=new Actor{state=owner.state,definition=BitDefinition,placement=BitDefinition.placements[0],born=now,origin=c.Position,speed=1,routes=new string[0],
                model=c.Model,stack=c,ownerActor=owner,extraPart=true,hitShape=Round1HitShapes.Get(c.Model),target=t};
            b.animation=t.visual.GetComponent<Round1EnemyAnimation>();if(!b.animation)b.animation=t.visual.AddComponent<Round1EnemyAnimation>();
            t.animation=b.animation;b.animation.Begin(BitDefinition,Vector3.zero,_=>0,1);
            owner.children.Add(b);actors.Add(b);live.Add(t.id,b);TotalSpawned++;
            Round1TrackCapture.Active?.Birth(t.id,owner.state.data,BitDefinition,c.Model,now,t.health);
            if(combat.sourceAttacks)combat.sourceAttacks.Register(t,BitDefinition,now,1);
            UpdateActor(b,now);combat.PlaceSourceTarget(t);
        }
    }
    void SpawnChain(Actor head,float now)
    {
        var prefab=combat.effects.Prefab(ChainBody);if(!prefab){Debug.LogWarning("Missing "+ChainBody+"; Mj01 has no body.",this);return;}
        var chain=new Chain{head=head,headId=head.target.id,id=++chainSerial,bodies=new Body[ChainLength],lastTime=now,headAt=head.target.position};
        var shape=Round1HitShapes.Get(ChainBody);
        for(int i=0;i<ChainLength;i++)
        {
            var t=combat.SpawnSourceTarget(prefab,ToViewport(head.origin+LayerOffset),BodyHealth);
            if(t==null){CapacityMisses++;continue;}
            t.sourceSpawn=true;t.sourceScale=WorldScale;t.lockOn=false;t.blocksLaser=true;t.score=(int)BodyScore;t.invulnerable=true;
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
                if(h.killed)
                {
                    for(int i=0;i<ChainLength;i++)Detach(chain,i);
                    // Ene_Mj01h._callDeadEffect 0x1DC7D70: Get5000 if all 9 bodies died first, then always ItemDrop(BombStock).
                    ChainKill(chain,chain.headAt);
                    combat.weapon.SpawnDroppedPickup(Round1PickupKind.BombStock,chain.headAt,now);
                }
            }
            else if(!chain.headGone)chain.headAt=h.target.position;
            // moveEndCallback -> SendMessage: at the head's route end every released body stops and sinks (not BG03).
            if(!chain.headStopped && Source.stage!="BG03" && headAge>=ChainStopAge(h)){chain.headStopped=true;for(int i=0;i<ChainLength;i++)Detach(chain,i);}
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
                        ChainKill(chain,b.target.position);   // Ene_Mj01b.ToDestroid 0x1DC6F70
                    }
                    continue;
                }
                any=true;
                float lag=(i+1)*UnitDistance/Mathf.Max(1,h.speed);
                if(!b.started && !b.detached && !chain.broken && !chain.headStopped && (!chain.headGone || !h.killed) && headAge>=lag){b.started=true;b.target.invulnerable=false;}
                var previous=b.position;
                if(b.detached)b.position+=BodyGravity*dt;
                else if(b.started)b.position=PathAt(h,headAge-lag);
                var move=b.position-previous;
                if(move.sqrMagnitude>1e-6f && !b.detached)b.target.sourceRotation=Quaternion.Euler(0,Mathf.Atan2(move.x,move.z)*Mathf.Rad2Deg,0);
                b.target.position=ToViewport(b.position+LayerOffset);
                Round1Combat.SetHitCircles(b.target,Round1HitShapes.Get(ChainBody),b.target.sourceRotation,1/Source.sourceHeight,1/Source.sourceHeight);
                var v=b.target.position;
                bool visible=v.x>=0 && v.x<=1 && v.y>=0 && v.y<=1;b.entered|=visible && (b.started || b.detached);
                bool outOfArea=v.x<-GameScreenMargin || v.x>1+GameScreenMargin || v.y<-GameScreenMargin || v.y>1+GameScreenMargin;
                // Ene_Mj01b AWAY: a sinking body is removed once outside its play area, entered or not.
                bool counts=b.entered || b.detached && chain.headStopped;
                if(!counts || !outOfArea)b.outsideSince=-1;else if(b.outsideSince<0)b.outsideSince=now;
                bool leaving=counts && b.outsideSince>=0 && now-b.outsideSince>=NativeExitDelay-.0001f;
                // A body that was never released (the head died, the chain broke or the head stopped first) goes with its head.
                bool stranded=!b.started && !b.detached && (chain.broken || chain.headGone || chain.headStopped);
                if(leaving || stranded || headAge-lag>h.definition.duration){b.gone=true;combat.DespawnSourceTarget(b.target);continue;}
                combat.PlaceSourceTarget(b.target);
            }
            if(!any && chain.headGone)chains.RemoveAt(c);
        }
    }
    // Ene_Mj01h._killCount: the head and each body count one kill; the tenth (whichever dies last) pays the 5000 bonus.
    void ChainKill(Chain chain,Vector2 at){if(++chain.kills==ChainLength+1)combat.weapon.Get5000(at);}
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
        // Verification: which models leave without ever having been on screen.
        string model=a.definition!=null?a.definition.model:"?";SpawnedByModel.TryGetValue(model,out int n);SpawnedByModel[model]=n+1;
        if(!a.entered && !killed){UnseenByModel.TryGetValue(model,out int u);UnseenByModel[model]=u+1;
            if(UnseenLog.Count<60)UnseenLog.Add(model.Replace("Pf_Ene_","")+"@"+a.born.ToString("0.0")+" age "+(LastTime-a.born).ToString("0.00")+" vp "+target.position.ToString("0.00")+" "+(a.stack!=null?a.stack.EndReason:"-")+(target.active?"":" inactive"));}
        if(!a.state.data.wipeoutOnly && !a.extraPart){var g=groups[a.state.data.group];if(killed)g.killed++;else g.escaped++;}
        if(a.stack==null)return;
        if(a.part>=0)
        {   // Ene_Mm01.OnPartsBreak: the survivor drops to 1 HP and goes solo; both broken: AddDead (Get5000 when joined)
            var o=a.partner;bool partnerAlive=o!=null && !o.finished && o.target.active;
            if(killed)a.stack.HalfBroken(a.part);
            if(partnerAlive){if(killed)o.target.health=Mathf.Min(o.target.health,1);}
            else{if(killed && o!=null && o.killed && a.stack.Mm01Joined)combat.weapon.Get5000(a.target.position);a.stack.Remove(killed);}
            return;
        }
        a.stack.Remove(killed);
        if(killed && a.stack.ChildrenDieWithParent)foreach(var c in a.children.ToArray())if(!c.finished && c.target.active)combat.ScriptKill(c.target,true);
    }
    void UpdateActors(float now)
    {
        // Native frame order: movers, then PhysicsEnemy.UpdatePositions (priority 301), then PhysicsUpdater.ProgressLate,
        // whose ApplyTransformFromPhysics places the meteors.
        actors.RemoveAll(x=>x.finished);
        for(int i=actors.Count-1;i>=0;i--)if(actors[i].meteor==null)UpdateActor(actors[i],now);
        ObstaclesFromEnemies();meteors.Advance(now);
        for(int i=actors.Count-1;i>=0;i--)if(actors[i].meteor!=null && !actors[i].finished)UpdateActor(actors[i],now);
        UpdateChains(now);
    }
    // A native enemy runs its first movement update on the frame it activates, so on its spawn frame it is
    // already one 60 Hz tick along (recorded Sa01 at Z 98.67 for an authored 100, Md01 likewise).
    const float NativeFirstTick=1f/60;
    // Sa01's mover tests InGameManager.IsGameArea: viewport inside gameScreenArea (-.15,-.15,1.3,1.3).
    // The recorded enemy stops playing about two frames after its first frame outside.
    const float GameScreenMargin=.15f,NativeExitDelay=2f/60;
    // MeteoEnemy: _limitTtimer 15 s in its play area, _outScreenTime 5 s for one that never came in (evidence/physics/SPEC.md sec. 4).
    const float MeteorLife=15,MeteorOutside=5;
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
        else if(a.stack!=null)
        {
            // 60 Hz frames, as the native mover; age already includes the first native tick.
            // A child is stepped by its parent (the parent's own clock); summoned children get their targets here.
            var root=a;while(root.ownerActor!=null)root=root.ownerActor;
            root.stack.AdvanceTo(Mathf.FloorToInt(((Mathf.Max(0,now-root.born)+NativeFirstTick)*root.state.data.timeScale)*60+.0001f));
            SpawnSummoned(root,now);
            position=a.stack.Position;ahead=position-a.stack.PreviousPosition;if(ahead.sqrMagnitude<1e-8f)ahead=Quaternion.Euler(0,a.stack.Yaw,0)*Vector3.forward*.01f;
            if(a.part>=0)position+=a.stack.HalfOffset(a.part);
            before=position-ahead*5;after=position+ahead*5;
            if(a.stack.Bullets.Count>0)
            {   // cued once the target is registered (its spawn frame runs before Register)
                if(!combat.sourceAttacks)a.stack.Bullets.Clear();
                else if(combat.sourceAttacks.CueFromStack(a.target,a.stack.Bullets[0],now)){foreach(var b in a.stack.Bullets.Skip(1))combat.sourceAttacks.CueFromStack(a.target,b,now);a.stack.Bullets.Clear();}
            }
            if(a.stack.Shots.Count>0){if(combat.sourceAttacks)foreach(var s in a.stack.Shots)if(s.cancel)combat.sourceAttacks.CancelBeams(a.target);else combat.sourceAttacks.FireClass(a.target,s.pattern,s.muzzle,s.offset,s.selfDir,s.toward);a.stack.Shots.Clear();}
            if(Round1EventStack.HasClassMover(a.definition.model))
            {   // OffCollision (St01's first second): no hits at all; NoHitBullet (So01's dash): shots pass, the body still touches.
                a.target.invulnerable=(a.stack.ObjFlags&1)!=0 || a.stack.NoHitBullet;a.target.touchesWhileInvulnerable=a.stack.NoHitBullet;
            }
        }
        else if(a.program!=null)
        {position=a.program.Sample(age);ahead=a.program.Sample(age+.01f)-position;before=a.program.Sample(Mathf.Max(0,age-.08f));after=a.program.Sample(age+.08f);}
        else if(a.model==ChainHead && Source.stage!="BG03" && age>=ChainStopAge(a))
        {   // Ene_Mj01h: stopped on the route's last knot, it sinks at gravityVector (0, 0, -16) with its yaw frozen
            float stop=ChainStopAge(a);var end=Position(a,stop);position=end+BodyGravity*(age-stop);
            ahead=end-Position(a,stop-.01f);before=position-ahead*8;after=position+ahead*8;
        }
        else {position=Position(a,age);ahead=Position(a,age+.01f)-position;before=Position(a,Mathf.Max(0,age-.08f));after=Position(a,age+.08f);}
        var shown=position+LayerOffset;
        a.target.position=(a.OriginalProjection?Round1Sa01Motion.ToViewport(shown,combat.weapon.player.stageCamera.aspect):ToViewport(shown));
        a.animation.Sample(age,a.placement.lookAt,ahead,before,after);
        ClassNodes(a,age);
        if(a.stack!=null){GroupNodes(a);ChildRotations(a);}
        if(a.meteorModel)a.meteorModel.localRotation=a.meteor.rotation;
        a.target.sourceRotation=a.md01!=null?a.md01.Facing:a.stack!=null?Quaternion.Euler((a.placement.rotate+a.state.data.rotate).x,a.stack.Yaw,(a.placement.rotate+a.state.data.rotate).z)*Quaternion.Euler(a.stack.ModelPitch,0,a.stack.Roll):a.animation.Facing;
        if(a.stack!=null && a.model==SnakeModel)SnakeBones(a);
        // The original scales hit shapes by a fixed pixels-per-unit (HybridCollisions, _scaleFactorZ at the stage plane), so
        // radii don't grow with height; offsets follow the enemy's own projection. Radii use the frame the model is drawn in.
        Round1Combat.SetHitCircles(a.target,a.hitShape,a.target.sourceRotation,1/(a.OriginalProjection?Round1Sa01Motion.ViewHeight(position.y):Source.sourceHeight),
            1/(a.OriginalProjection?Round1Sa01Motion.ViewHeight():Source.sourceHeight));
        Round1TrackCapture.Active?.Record(a.target.id,now,shown,a.target.sourceRotation*a.animation.RootRotation);
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
        if(a.model==ChainHead && Source.stage!="BG03")
        {   // Ene_Mj01h.moveEndCallback: stopped on the last knot and sinking, it ends once outside its play area (no entry test)
            var v=a.target.position;bool outOfArea=v.x<-GameScreenMargin || v.x>1+GameScreenMargin || v.y<-GameScreenMargin || v.y>1+GameScreenMargin;
            if(age<ChainStopAge(a) || !outOfArea)a.outsideSince=-1;else if(a.outsideSince<0)a.outsideSince=now;
            if(age>=ChainStopAge(a)){outside=a.outsideSince>=0 && now-a.outsideSince>=NativeExitDelay-.0001f;a.entered=true;}
        }
        if(a.meteor!=null)
        {   // MeteoEnemy.ProgressEvent: 15 s in its play area and it blows up (no credit); once out of it, gone at once if it
            // had been in, else after 5 s. A PhysicsAttackAttr trigger (Lb01's head) kills it through SetSuside.
            var v=a.target.position;bool inArea=v.x>=-GameScreenMargin && v.x<1+GameScreenMargin && v.y>=-GameScreenMargin && v.y<1+GameScreenMargin;
            float dt=a.lastUpdate<0?0:Mathf.Max(0,now-a.lastUpdate);a.lastUpdate=now;
            if(inArea){a.meteorInArea+=dt;a.entered=true;}else a.meteorOutside+=dt;
            if(a.meteor.suside || a.meteorInArea>=MeteorLife){combat.ScriptKill(a.target,false);return;}
            if(!inArea && (a.entered || a.meteorOutside>=MeteorOutside)){combat.DespawnSourceTarget(a.target);return;}
            return;
        }
        bool finished=a.stack!=null ? a.stack.Ended || age>180 : // native: no time limit; 180 s is only a safety net
            a.md01!=null ? age>=a.md01.Duration :
            age>=Lifetime(a.definition) || (a.entered && outside) || (!a.entered && age>12 && outside);
        if(finished){if(a.stack!=null && a.stack.Eaten)combat.ScriptKill(a.target,false);else combat.DespawnSourceTarget(a.target);}
    }
    // Class nodes driven by Round1EventStackGroups: Mn01h's spinning _modelTop, a summoned Mn01c's tumbling Body, Ml01's
    // jaws, and Mm01's halves (each target shows its own half, opened, closed and spun by the stack) and their laser.
    void GroupNodes(Actor a)
    {
        var s=a.stack;string m=a.model;
        if(a.nodes==null)
        {
            string[] paths=m=="Pf_Ene_Mn01"?new[]{"pf_ene_mn01"}:s.SummonedBit?new[]{"Body"}:m=="Pf_Ene_Ml01"?new[]{"pf_ene_ml01/mouth_L","pf_ene_ml01/mouth_R"}
                :a.part>=0?new[]{"Models","Models/pf_ene_mm01_left","Models/pf_ene_mm01_right","Models/pf_ene_mm01_left/ene_mm01/muzzle01/Line","Models/pf_ene_mm01_left/ene_mm01/muzzle02/Line",
                    "Models/pf_ene_mm01_left/ene_mm01/muzzle01","Models/pf_ene_mm01_left/ene_mm01/muzzle02","Models/pf_ene_mm01_right/ene_mm01/muzzle01","Models/pf_ene_mm01_right/ene_mm01/muzzle02"}:new string[0];
            a.nodes=paths.Select(x=>a.target.visual.transform.Find(x)).ToArray();a.nodeBase=a.nodes.Select(x=>x?x.localRotation:Quaternion.identity).ToArray();
            if(a.part>=0)
            {   // each target draws one half at its own position; the left half's _laser1/_laser2 lines span to the partner's muzzles
                a.lines=new LineRenderer[2];
                for(int i=0;i<2;i++){var line=a.nodes[3+i]?a.nodes[3+i].GetComponent<LineRenderer>():null;if(line){line.enabled=false;line.useWorldSpace=true;line.positionCount=LaserPoints;}a.lines[i]=line;}
                for(int i=5;i<9;i++)MuzzleGlow(a.nodes[i],false);
                var own=a.nodes[a.part==0?1:2];a.burners=own?own.GetComponentsInChildren<Transform>(true).Where(x=>x.name=="pf_eff_burner_e04").ToArray():new Transform[0];
                foreach(var b in a.burners)Effect(b,false);
                var other=a.nodes[a.part==0?2:1];if(other)other.gameObject.SetActive(false);
            }
        }
        if(m=="Pf_Ene_Mn01" && a.nodes[0])a.nodes[0].localRotation=Quaternion.Euler(s.CoreEuler);
        else if(s.SummonedBit && a.nodes[0])a.nodes[0].localRotation=s.BitRotation;
        else if(m=="Pf_Ene_Ml01")
        {
            if(a.nodes[0])a.nodes[0].localRotation=a.nodeBase[0]*Quaternion.Euler(0,s.JawAngle,0);
            if(a.nodes[1])a.nodes[1].localRotation=a.nodeBase[1]*Quaternion.Euler(0,-s.JawAngle,0);
        }
        else if(a.part>=0)
        {
            if(a.nodes[0])a.nodes[0].localRotation=s.Mm01Rot90?Quaternion.Euler(0,90,0):Quaternion.identity;   // _modelTop: rotateV or identity
            var half=a.nodes[a.part==0?1:2];if(half){half.localPosition=Vector3.zero;half.localRotation=Quaternion.Euler(s.HalfPitch[a.part],0,0);}
            foreach(var b in a.burners)Effect(b,s.Mm01Burners && !s.Ended);     // _burner: Play when the joined gate opens, Stop at its end
            if(a.part==0 && combat.sourceAttacks)
            {
                var o=a.partner;bool on=s.Mm01Laser && !s.Ended && a.target.active && o!=null && !o.finished && o.target.active;
                var player=combat.weapon.player;float plane=Vector3.Distance(player.WorldPoint(Vector2.zero),player.WorldPoint(Vector2.up))/Round1Sa01Motion.ViewHeight();
                bool pair=!s.Ended && a.target.active && o!=null && !o.finished && o.target.active;
                combat.sourceAttacks.SetBridge(a.target,0,player.WorldPoint(a.target.position),pair?player.WorldPoint(o.target.position):Vector3.zero,
                    1/Round1Sa01Motion.ViewHeight(),4*plane,on,pair && s.Mm01Gate?17/Round1Sa01Motion.ViewHeight():0,false);   // collisions_atttack: 2 units wide; warn: a half's 17-unit body
                Mm01Laser(a,o,on);
            }
        }
    }
    // Ene_Mm01._setLaserCollision 0x1DD0110 / SetLaserEffectEnable 0x1DCD570: while the laser is on (_laserEnable && !_siblingDead),
    // _laser1/_laser2 (the left half's muzzle01/02 Line, world space, width 20) hold laserPointMax 32 points evenly from each left
    // muzzle to the right muzzle of the same number (_setArray 0x1DCDBF0), and the four pf_eff_e_laser_muzzle02 glows play.
    // ShaderFunction_UVAnime.Progress 0x1D50CC0 on each line: every _DisplaySecondMax 0.03 s, _AIndex = (i + 1) % 8 and the
    // _MainTex offset x -= _texOffset 0.05 (wrapped to 0..1; mt_eff_mm001 starts at 0.65, scale 0.25).
    const int LaserPoints=32;const float LaserWidth=20,LaserFrameSeconds=.03f;
    static readonly Vector3[] laserPoints=new Vector3[LaserPoints];
    MaterialPropertyBlock laserBlock;
    void Mm01Laser(Actor a,Actor o,bool on)
    {
        var right=o!=null && o.nodes!=null && o.nodes.Length>8?o.nodes:null;on&=right!=null;
        for(int i=0;i<2;i++)
        {
            var line=a.lines[i];MuzzleGlow(a.nodes[5+i],on);if(right!=null)MuzzleGlow(right[7+i],on);
            if(!line)continue;
            var from=a.nodes[5+i];var to=right?[7+i];bool draw=on && from && to;line.enabled=draw;if(!draw)continue;
            Vector3 p0=from.position,p1=to.position;
            for(int k=0;k<LaserPoints;k++)laserPoints[k]=p0+(p1-p0)*(k/(float)(LaserPoints-1));
            line.SetPositions(laserPoints);line.widthMultiplier=LaserWidth*a.target.visual.transform.lossyScale.x;
            int step=Mathf.FloorToInt(LastTime/LaserFrameSeconds);
            if(laserBlock==null)laserBlock=new MaterialPropertyBlock();
            line.GetPropertyBlock(laserBlock);laserBlock.SetFloat("_AIndex",step%8);laserBlock.SetVector("_MainTex_ST",new Vector4(.25f,1,Mathf.Repeat(.65f-.05f*step,1),0));
            line.SetPropertyBlock(laserBlock);
        }
    }
    static void MuzzleGlow(Transform muzzle,bool on)=>Effect(muzzle?muzzle.Find("pf_eff_e_laser_muzzle02"):null,on);
    static void Effect(Transform glow,bool on)
    {
        if(!glow)return;
        if(on && !glow.gameObject.activeSelf){glow.gameObject.SetActive(true);foreach(var ps in glow.GetComponentsInChildren<ParticleSystem>(true))ps.Play(true);}
        else if(!on && glow.gameObject.activeSelf){foreach(var ps in glow.GetComponentsInChildren<ParticleSystem>(true))ps.Stop(true,ParticleSystemStopBehavior.StopEmittingAndClear);glow.gameObject.SetActive(false);}
    }
    // Ene_Mj01h: the route ends on the frame its rate (+ speed/length per frame) reaches 1.
    float ChainStopAge(Actor h)
    {
        float length=0;foreach(string n in h.routes)if(routes.TryGetValue(n,out var r))length+=r.length;
        return Mathf.Ceil(length*60/Mathf.Max(1,h.speed)-1e-3f)/60f;
    }
    // Native class code that only turns a model node (evidence/movers): Ene_Sh01 spins pf_ene_sh01/ene_sh01 by
    // RotateSpeedTable[indexValue]; Ene_Mn01c (FALL, indexValue != 0) tumbles Body about a random axis,
    // _localRotate *= SlerpUnclamped(id, _spin, dt*2*_spinRate); Ene_Mp01's battery yaws to the player (Round1EventStack.TurretYaw).
    static readonly Vector3[] Sh01Spin={Vector3.zero,new Vector3(0,0,360),new Vector3(0,0,-360),new Vector3(360,0,0),new Vector3(-360,0,0)};
    // InGameObjectWithEvent._transformCaches (Initialize 0x1D1DD60): every child's path below the root (root name left
    // out); names containing "damage", "collision" or "burner" are skipped. A stack Rotate naming one turns that child.
    static readonly Dictionary<GameObject,HashSet<string>> childPathCache=new Dictionary<GameObject,HashSet<string>>();
    static HashSet<string> ChildPaths(GameObject prefab)
    {
        if(childPathCache.TryGetValue(prefab,out var set))return set;
        set=new HashSet<string>();
        void Walk(Transform t,string path)
        {
            foreach(Transform c in t)
            {
                string p=path==null?c.name:path+"/"+c.name,n=c.name.ToLowerInvariant();
                if(!n.Contains("damage") && !n.Contains("collision") && !n.Contains("burner"))set.Add(p);
                Walk(c,p);
            }
        }
        Walk(prefab.transform,null);childPathCache[prefab]=set;return set;
    }
    // Draws the stack's child Rotates (Sf01's pf_ene_sf01 turning under its root, ...) on the spawned model. The pooled
    // visual is reused, so a turned child is put back to its prefab rotation when the visual next spawns (ResetChildren).
    readonly Dictionary<GameObject,List<(Transform node,Quaternion rest)>> turnedChildren=new Dictionary<GameObject,List<(Transform,Quaternion)>>();
    void ChildRotations(Actor a)
    {
        var e=a.stack.ChildEulers;if(e.Count==0)return;
        if(a.childNodes==null)a.childNodes=new Dictionary<string,(Transform,Quaternion)>();
        foreach(var kv in e)
        {
            if(!a.childNodes.TryGetValue(kv.Key,out var n))
            {
                var t=a.target.visual.transform.Find(kv.Key);var src=a.target.template?a.target.template.transform.Find(kv.Key):null;
                a.childNodes[kv.Key]=n=(t,src?src.localRotation:t?t.localRotation:Quaternion.identity);
                if(t){if(!turnedChildren.TryGetValue(a.target.visual,out var list))turnedChildren[a.target.visual]=list=new List<(Transform,Quaternion)>();if(!list.Exists(x=>x.node==t))list.Add((t,n.Item2));}
            }
            if(n.Item1)n.Item1.localRotation=a.stack.ChildAbsolute(kv.Key)?Quaternion.Euler(kv.Value):n.Item2*Quaternion.Euler(kv.Value);
        }
    }
    void ResetChildren(GameObject visual){if(visual && turnedChildren.TryGetValue(visual,out var list))foreach(var x in list)if(x.node)x.node.localRotation=x.rest;}
    // EnemyMoverSnake (Pf_Ene_Lb01), after the route step every frame (_updateBones 0x1D6B460; SetSpline 0x1D6B230 makes
    // _headRate/_boneRate = distance / spline length): bone i sits on the route headDistance + i*boneDistance behind the
    // head's offset (_currentOffset), clamped to the route's start. Its position is the head's plus the route offset between
    // the two points, in sky units (so the bent snake is shorter than its 1.15/1.05-scaled rest pose), and it faces the
    // route tangent there with its parent's up; a vanishing tangent keeps its last direction (else the head's forward).
    // Nothing moves for lookAt 0. Each body hit circle rides on the bone ahead of it in the rest pose.
    const string SnakeModel="Pf_Ene_Lb01",SnakeHead="pf_ene_lb01/ene_lb01_body01";
    const float SnakeHeadDistance=14.5f,SnakeBoneDistance=26,SnakeBodyCircleZ=-25;   // prefab _headDistance, _boneDistance
    void SnakeBones(Actor a)
    {
        var root=a.target.visual.transform;
        if(a.snakeBones==null)
        {   // the pooled visual is in its rest pose here (ResetChildren at spawn); the rest bones are unrotated
            a.snakeHead=root.Find(SnakeHead);var bones=new List<Transform>();var t=a.snakeHead;
            for(int i=0;i<8 && t;i++){t=t.Find(i<7?"ene_lb01_body02"+(i+1):"ene_lb01_body03");if(t)bones.Add(t);}
            a.snakeBones=bones.Count==8?bones.ToArray():new Transform[0];a.snakeDirs=new Vector3[a.snakeBones.Length];
            if(a.hitShape!=null && a.snakeBones.Length>0)
            {
                var rest=a.snakeBones.Select(b=>(Vector3)RootLocal(b,root).GetColumn(3)).ToArray();
                a.snakeCircleBone=new int[a.hitShape.Length];a.snakeOffsets=new Vector3[a.hitShape.Length];
                for(int i=0;i<a.hitShape.Length;i++)
                {
                    var c=new Vector3(a.hitShape[i].x,0,a.hitShape[i].y);int j=-1;
                    if(c.z<SnakeBodyCircleZ)for(int k=0;k<rest.Length;k++)if(rest[k].z>=c.z)j=k;
                    a.snakeCircleBone[i]=j;a.snakeOffsets[i]=j<0?c:c-new Vector3(rest[j].x,0,rest[j].z);
                }
                a.hitShape=(Vector3[])a.hitShape.Clone();   // Round1HitShapes' table is shared
            }
        }
        var r=a.stack.CurrentRoute;float len=a.stack.CurrentRouteLength;
        if(a.snakeBones.Length==0 || r==null || len<=0 || a.placement.lookAt==0)return;
        var q=a.target.sourceRotation*a.animation.RootRotation;var toLocal=Quaternion.Inverse(q);   // sky -> visual root
        float off=a.stack.RouteOffset;var headPoint=r.Sample(Mathf.Clamp01(off));
        // Everything in the visual root's frame (its world placement comes later this frame).
        var parent=RootLocal(a.snakeHead,root);var headLocal=(Vector3)parent.GetColumn(3);var parentRot=parent.rotation;
        var headForward=q*(parentRot*Vector3.forward);
        var pos=new Vector3[a.snakeBones.Length];var rot=new Quaternion[a.snakeBones.Length];
        float u=off-SnakeHeadDistance/len;
        for(int i=0;i<a.snakeBones.Length;i++,u-=SnakeBoneDistance/len)
        {
            float at=Mathf.Clamp01(u);var dir=r.SampleTangent(at);
            if(dir.sqrMagnitude<Mathf.Epsilon)dir=a.snakeDirs[i].sqrMagnitude>Mathf.Epsilon?a.snakeDirs[i]:headForward;
            dir=dir.magnitude>1e-5f?dir.normalized:Vector3.zero;a.snakeDirs[i]=dir;
            rot[i]=dir==Vector3.zero?parentRot:toLocal*Quaternion.LookRotation(dir,q*(parentRot*Vector3.up));
            pos[i]=headLocal+toLocal*(r.Sample(at)-headPoint);
            var bone=a.snakeBones[i];
            bone.localPosition=parent.inverse.MultiplyPoint3x4(pos[i]);bone.localRotation=Quaternion.Inverse(parentRot)*rot[i];
            parent*=Matrix4x4.TRS(bone.localPosition,bone.localRotation,bone.localScale);parentRot=rot[i];
        }
        if(a.snakeCircleBone!=null)for(int i=0;i<a.hitShape.Length;i++)
        {
            int j=a.snakeCircleBone[i];var c=j<0?a.snakeOffsets[i]:pos[j]+rot[j]*a.snakeOffsets[i];
            a.hitShape[i]=new Vector3(c.x,c.z,a.hitShape[i].z);
        }
    }
    static Matrix4x4 RootLocal(Transform t,Transform root)
    {
        var m=Matrix4x4.identity;for(;t && t!=root;t=t.parent)m=Matrix4x4.TRS(t.localPosition,t.localRotation,t.localScale)*m;return m;
    }
    void ClassNodes(Actor a,float age)
    {
        string model=a.definition.model;int index=a.state.data.indexValue;
        if(a.classNode==null && a.tumbleRate==0 && a.spinRate==Vector3.zero)
        {
            string path=model=="Pf_Ene_Sh01"?"pf_ene_sh01/ene_sh01":model.StartsWith("Pf_Ene_Mn01c") && index!=0 && !a.extraPart?"Body":model=="Pf_Ene_Mp01"?"pf_ene_mp01/ene_mp01_battery":null;
            if(path==null){a.tumbleRate=-1;return;}
            a.classNode=a.target.visual.transform.Find(path);if(!a.classNode){a.tumbleRate=-1;return;}
            a.classBase=a.classNode.localRotation;
            if(model=="Pf_Ene_Sh01")a.spinRate=index>=0 && index<Sh01Spin.Length?Sh01Spin[index]:Vector3.zero;
            if(model.StartsWith("Pf_Ene_Mn01c"))
            {
                var rng=new System.Random(a.target.id*7919+17);int Sign()=>rng.Next(2)==0?-1:1;
                a.tumbleSpin=Quaternion.Euler(Sign()*rng.Next(90,180),Sign()*rng.Next(90,180),Sign()*rng.Next(90,180));a.tumbleRate=2*2*index;
            }
        }
        if(!a.classNode)return;
        if(model=="Pf_Ene_Sh01")a.classNode.localRotation=a.classBase*Quaternion.Euler(a.spinRate*age);
        else if(model=="Pf_Ene_Mp01" && a.stack!=null && !float.IsNaN(a.stack.TurretYaw))
            a.classNode.localRotation=Quaternion.Inverse(a.target.sourceRotation)*Quaternion.Euler(0,a.stack.TurretYaw,0)*a.classBase;
        else if(a.tumbleRate>0)
        {
            int frames=Mathf.FloorToInt(age*60+.0001f);var step=Quaternion.SlerpUnclamped(Quaternion.identity,a.tumbleSpin,a.tumbleRate/60f);
            for(int i=Mathf.RoundToInt(a.tumbleFrames);i<frames;i++)a.tumble*=step;a.tumbleFrames=frames;
            a.classNode.localRotation=a.tumble;
        }
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
    // The physics3d colliders of the PhysicsEnemy users (evidence/physics/SPEC.md sec. 3, 5; tools/stage_combat/
    // physics_colliders.py -> StageCombat/physics-colliders.json), in the meteors' source frame, as meteor obstacles.
    // PhysicsEnemy.UpdatePositions (0x1D18BA0): node 0 takes its origin's pose; node i its origin's pose relative to origin 0
    // with y set to 0 (Lb01's cbody1..7 and ctail follow the snake's bones). Every other enemy is not in 3D physics.
    // The pose comes from where the enemy is drawn (its own projection), scaled into the meteors' frame.
    [Serializable] class PhysicsShape { public string kind;public bool trigger;public float[] centre,rotation,size;public float radius,height;public int direction; }
    [Serializable] class PhysicsNode { public string origin,target;public PhysicsShape[] shapes; }
    [Serializable] class PhysicsModel { public string model;public bool attack;public PhysicsNode[] nodes; }
    [Serializable] class PhysicsData { public PhysicsModel[] models; }
    static Dictionary<string,PhysicsModel> physicsModels;
    readonly Dictionary<GameObject,Transform[]> physicsOrigins=new Dictionary<GameObject,Transform[]>();
    readonly List<Round1MeteorField.Obstacle> obstacles=new List<Round1MeteorField.Obstacle>();
    void ObstaclesFromEnemies()
    {
        if(physicsModels==null)
        {
            physicsModels=new Dictionary<string,PhysicsModel>();var asset=Resources.Load<TextAsset>("StageCombat/physics-colliders");
            if(asset)foreach(var m in JsonUtility.FromJson<PhysicsData>(asset.text).models)physicsModels[m.model]=m;
        }
        obstacles.Clear();
        float aspect=combat.weapon.player.stageCamera.aspect,h=Source.sourceHeight,world=WorldScale;
        foreach(var t in combat.Targets)
        {
            if(!t.active || t.physicsBody || !t.visual || !t.sourceSpawn)continue;
            string name=t.visual.name;if(name.EndsWith("(Clone)"))name=name.Substring(0,name.Length-7);
            if(!physicsModels.TryGetValue(name,out var pm))continue;
            var root=t.visual.transform;
            if(!physicsOrigins.TryGetValue(t.visual,out var origins))
                physicsOrigins[t.visual]=origins=Array.ConvertAll(pm.nodes,n=>string.IsNullOrEmpty(n.origin)?root:root.Find(n.origin)??root);
            var q=t.sourceRotation*(t.animation?t.animation.RootRotation:Quaternion.identity);float k=world>0?t.sourceScale/world:1;
            var at=new Vector3((t.position.x-.5f)*h*aspect,0,(t.position.y-.5f)*h)-LayerOffset;
            var m0=RootLocal(origins[0],root);var r0=m0.rotation;
            var p0=at+q*(Vector3)m0.GetColumn(3)*k;var q0=q*r0;
            for(int i=0;i<pm.nodes.Length;i++)
            {
                Vector3 pos=p0;Quaternion rot=q0;
                if(i>0)
                {
                    var mi=RootLocal(origins[i],root);var local=m0.inverse.MultiplyPoint3x4(mi.GetColumn(3));local.y=0;
                    pos=p0+q0*local*k;rot=q0*(Quaternion.Inverse(r0)*mi.rotation);
                }
                foreach(var s in pm.nodes[i].shapes)
                {
                    var sr=new Quaternion(s.rotation[0],s.rotation[1],s.rotation[2],s.rotation[3]);
                    var o=new Round1MeteorField.Obstacle{trigger=s.trigger,centre=pos+rot*new Vector3(s.centre[0],s.centre[1],s.centre[2])*k,rotation=rot*sr};
                    o.centre.y=0;   // [I] enemy altitude ignored: everything is drawn on the stage plane
                    if(s.kind=="sphere"){o.kind=0;o.radius=s.radius*k;}
                    else if(s.kind=="box"){o.kind=1;o.half=new Vector3(s.size[0],s.size[1],s.size[2])*(k*.5f);}
                    else{o.kind=2;o.axis=s.direction;o.radius=s.radius*k;o.segment=Mathf.Max(0,s.height*.5f-s.radius)*k;}
                    obstacles.Add(o);
                }
            }
        }
        meteors.SetObstacles(obstacles);
    }
    // The original writes the rail camera's local position outright (0 in every BGxxStage); the remaster adds the slide
    // to whatever local position the camera had, and takes a new base whenever something else moved it.
    void SlideCamera(Vector3 slide)
    {
        var cam=combat.weapon.player.stageCamera;if(!cam)return;var t=cam.transform;
        if(t!=slidCamera){slidCamera=t;cameraBase=t.localPosition;}
        else if(t.localPosition!=cameraWritten)cameraBase=t.localPosition;
        CameraSlide=slide;t.localPosition=cameraWritten=cameraBase+slide;
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
