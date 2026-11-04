using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

// The enemy layer of a StagePresentation scene: plays the stage's ORIGINAL enemy schedule, exported from its mainTL
// (TLEntry wave timelines, EnemyEntry clips, EnemyWave bonus spawns) and BGxx_ge timelines by
// Editor/ReconstructionStageEnemyExport + tools/stage_enemies/build_stage_enemies.py into Resources/StageEnemies/BGxx.json.
// That exporter reproduces the validated Round 1 BG03 schedule event for event (301/301).
//
// Air enemies live in the native game frame: InGameManager.SetupCameraPosition puts the game MainCamera at (0,400,0),
// looking straight down with a 20 degree vertical FOV; source x is screen right, z is screen up, y is altitude. Here
// that frame is a "Game Layer" far below the stage (out of the background camera's range) seen by an overlay camera
// stacked on the stage's rail camera. Movement uses the Round 1 rules matched against recordings of the original:
// route LUTs walked by distance (age * speed), placements/repeats/loops, Md01 programs, multi-route programs, rotation
// and look-at events. Ground enemies are placed at their authored stage-world offsets for their clip window.
//
// Not reproduced here (still native-only): firing, damage and wipe-out bonus spawns (nothing is shot down), player
// pursuit (Sa01 steers toward a fixed virtual player), meteor physics, Mj01 chain bodies, ground movers, and bosses.
public sealed class StageEnemies : MonoBehaviour
{
    [Serializable] public class StageEvent : Round1EnemyWaves.Event { public bool ground,groundSky;public string ruin; }
    [Serializable] public class StageData
    {
        public int version,round,gameModeMask;public string stage;public float sourceHeight;public StageEvent[] events;
        public Round1EnemyWaves.Definition[] definitions;public Round1EnemyWaves.Route[] routes;public Round1EnemyWaves.Model[] models;
        public Round1EnemyWaves.Zone[] zones;
    }

    public TextAsset schedule;
    public StagePresentation presentation;
    public Round1EnemyWaves.Visual[] visuals;
    // TLGameModeFlag: Tutorial 1, StoryA 2, Arcade1 32, Arcade2 64 ... (0 = every mode).
    public int gameModeMask=2;
    public int maxActors=160;
    public Vector3 virtualPlayer=new Vector3(0,0,-45);
    public bool showGround=true;

    public static readonly Vector3 LayerOrigin=new Vector3(0,-50000,0);
    public const float CameraHeight=400,CameraFov=20;

    public StageData Data {get;private set;}
    public int Spawned {get;private set;}
    public int Live=>actors.Count;
    public int SkippedBonus {get;private set;}
    public int SkippedZone {get;private set;}
    int cleanZones;
    public int SkippedMode {get;private set;}
    public int SkippedUnsupported {get;private set;}
    public int MaxLive {get;private set;}
    // Air actors removed after being on screen / removed without ever being on screen (a frame or route problem).
    public int Entered {get;private set;}
    public int Unseen {get;private set;}
    public readonly Dictionary<string,int> UnseenByModel=new Dictionary<string,int>();
    public readonly HashSet<string> MissingModels=new HashSet<string>();
    public Camera GameCamera {get;private set;}
    public Transform LayerRoot=>layer;

    sealed class State {public StageEvent data;public int iteration,pending;public bool started,finished;public readonly List<Actor> actors=new List<Actor>();}
    sealed class Pending {public State state;public Round1EnemyWaves.Placement placement;public float time,speedDelta;public Vector3 extraOffset;public int seed;}
    sealed class Actor
    {
        public State state;public Round1EnemyWaves.Definition definition;public Round1EnemyWaves.Placement placement;public GameObject visual;
        public string model;public float born,speed;public Vector3 origin,direction;public string[] routes;public bool entered,ground,finished;
        public Round1EnemyAnimation animation;public Round1Md01Motion md01;public Round1Sa01Motion sa01;public Round1RouteProgram program;
    }
    readonly Dictionary<string,Round1EnemyWaves.Definition> definitions=new Dictionary<string,Round1EnemyWaves.Definition>();
    readonly Dictionary<string,Round1EnemyWaves.Route> routes=new Dictionary<string,Round1EnemyWaves.Route>();
    readonly Dictionary<string,GameObject> models=new Dictionary<string,GameObject>();
    readonly List<State> states=new List<State>();
    readonly List<Pending> pending=new List<Pending>();
    readonly List<Actor> actors=new List<Actor>();
    Transform layer,ground,spawnHolder;
    float lastTime=-1;
    bool ready;

    public void Prepare()
    {
        if(ready)return;
        if(!presentation)presentation=GetComponent<StagePresentation>();
        if(!presentation)presentation=FindFirstObjectByType<StagePresentation>();
        Data=JsonUtility.FromJson<StageData>(schedule.text);
        foreach(var d in Data.definitions)definitions[d.id]=d;
        foreach(var r in Data.routes)
        {
            r.length=0;for(int i=1;i<r.points.Length;i++)r.length+=Vector3.Distance(r.points[i-1],r.points[i]);
            routes[r.name]=r;
        }
        foreach(var v in visuals)if(v.prefab)models[v.name]=v.prefab;
        foreach(var e in Data.events)states.Add(new State{data=e});
        cleanZones=Round1EnemyWaves.CleanRouteZones(Data.zones);
        layer=new GameObject("Game Layer (native game frame)").transform;layer.position=LayerOrigin;
        layer.gameObject.hideFlags=HideFlags.DontSave;
        ground=new GameObject("Ground enemies (stage world)").transform;ground.gameObject.hideFlags=HideFlags.DontSave;
        var holder=new GameObject("Spawn holder (inactive)");holder.hideFlags=HideFlags.DontSave;holder.SetActive(false);spawnHolder=holder.transform;
        var cam=new GameObject("Game Camera (native: 0,400,0 / 20 deg)");cam.hideFlags=HideFlags.DontSave;cam.transform.SetParent(layer,false);
        cam.transform.localPosition=new Vector3(0,CameraHeight,0);cam.transform.localRotation=Quaternion.Euler(90,0,0);
        GameCamera=cam.AddComponent<Camera>();GameCamera.fieldOfView=CameraFov;GameCamera.nearClipPlane=10;GameCamera.farClipPlane=1200;
        GameCamera.GetUniversalAdditionalCameraData().renderType=CameraRenderType.Overlay;
        ready=true;
    }

    void LateUpdate(){if(presentation&&presentation.Ready)Step((float)presentation.time);}

    // Advance the enemy layer to stage time t. Going backwards restarts the schedule at t (no historical actors).
    public void Step(float t)
    {
        Prepare();
        Stack();
        if(t<lastTime-.001f||lastTime<0)Restart(t);
        foreach(var s in states)
        {
            var e=s.data;if(s.finished)continue;
            if(!s.started&&t+.00001f>=e.start)
            {
                s.started=true;
                if(t>=e.end){s.finished=true;continue;}
                if(e.gameModeMask!=0&&(e.gameModeMask&gameModeMask)==0){SkippedMode++;s.finished=true;continue;}
                if(e.wipeoutOnly){SkippedBonus++;s.finished=true;continue;}
                // Zone TLs (BG08 branches): the overlay shows the clean route (no bomb, no death).
                if(e.zone!=0 && (cleanZones&e.zone)==0){SkippedZone++;s.finished=true;continue;}
                if(e.ground){if(showGround)SpawnGround(s,t);s.finished=true;continue;}
                Queue(s,e.start+e.startDelay/e.timeScale);
            }
            else if(s.started&&e.loop&&t<e.end&&s.pending==0&&s.actors.Count>0&&s.actors.TrueForAll(a=>a.finished))
            {
                if(e.loopMax>0&&s.iteration+1>=e.loopMax){s.finished=true;continue;}
                s.iteration++;s.actors.Clear();Queue(s,t+Mathf.Max(.0001f,e.loopDelay/e.timeScale));
            }
            if(t>=e.end&&!e.loop)s.finished=true;
        }
        for(int i=0;i<pending.Count;)
        {
            var p=pending[i];if(p.time>t+.00001f){i++;continue;}
            pending.RemoveAt(i);p.state.pending--;
            if(t-p.time<Lifetime(definitions[p.state.data.enemy]))Spawn(p,t);
        }
        for(int i=actors.Count-1;i>=0;i--)if(UpdateActor(actors[i],t)){Remove(actors[i]);actors.RemoveAt(i);}
        MaxLive=Mathf.Max(MaxLive,actors.Count);
        lastTime=t;
    }

    void Restart(float t)
    {
        foreach(var a in actors)Remove(a);
        actors.Clear();pending.Clear();Spawned=SkippedBonus=SkippedZone=SkippedMode=SkippedUnsupported=MaxLive=Entered=Unseen=0;UnseenByModel.Clear();
        foreach(var s in states){s.started=s.finished=s.data.start<t-.0001f&&!(s.data.ground&&s.data.end>t);s.iteration=s.pending=0;s.actors.Clear();}
    }

    // The overlay game camera rides on whichever stage rail camera is currently active.
    Camera stackedOn;
    void Stack()
    {
        Camera base_=null;float depth=float.MinValue;
        foreach(var c in Camera.allCameras)if(c!=GameCamera&&c.depth>depth&&c.GetUniversalAdditionalCameraData().renderType==CameraRenderType.Base){base_=c;depth=c.depth;}
        if(base_==stackedOn||!base_)return;
        if(stackedOn)stackedOn.GetUniversalAdditionalCameraData().cameraStack.Remove(GameCamera);
        var stack=base_.GetUniversalAdditionalCameraData().cameraStack;if(!stack.Contains(GameCamera))stack.Add(GameCamera);
        stackedOn=base_;GameCamera.aspect=base_.aspect;
    }

    void Queue(State s,float time)
    {
        var d=definitions[s.data.enemy];
        Vector3 loopOffset=s.iteration>0&&s.data.offsets.Length>0?s.data.offsets[(s.iteration-1)%s.data.offsets.Length]:Vector3.zero;
        int seed=StableHash(s.data.id)^3101^(s.iteration*7919);
        foreach(var placement in d.placements)
        {
            Add(0,Vector3.zero,0);
            foreach(var r in d.repeats)for(int j=1;j<=r._repeatTimes;j++)Add(j*r._delayStep,j*r._offsetStep,j*r._speedStep);
            void Add(float delay,Vector3 offset,float speed)
            {
                pending.Add(new Pending{state=s,placement=placement,time=time+(placement.delayTime+delay)/s.data.timeScale,extraOffset=loopOffset+offset,speedDelta=speed,seed=++seed});
                s.pending++;
            }
        }
    }

    GameObject Instantiate(string model,Transform parent)
    {
        if(!models.TryGetValue(model??"",out var prefab)){MissingModels.Add(model);return null;}
        // Instantiate under an inactive holder so no Awake runs, then remove the original game's behaviours: their
        // recovered methods are throw-null stubs. Engine components (renderers, animators, particles) stay.
        var go=UnityEngine.Object.Instantiate(prefab,spawnHolder);
        StripStubBehaviours(go);
        go.transform.SetParent(parent,false);
        return go;
    }
    public static int StripStubBehaviours(GameObject go)
    {
        int removed=0;
        for(int pass=0;pass<4;pass++)
        {
            bool any=false;
            foreach(var b in go.GetComponentsInChildren<MonoBehaviour>(true))
            {
                if(!b||IsEngineType(b.GetType()))continue;
                any=true;
                if(Required(b))continue; // a sibling's [RequireComponent] (Ene_Bos01 <- EnemyGauge): remove the dependent first
                try{DestroyImmediate(b);removed++;}catch(Exception){}
            }
            if(!any)break;
        }
        return removed;
    }
    static bool Required(MonoBehaviour b)
    {
        foreach(var other in b.GetComponents<MonoBehaviour>())
        {
            if(!other||other==b)continue;
            foreach(RequireComponent r in other.GetType().GetCustomAttributes(typeof(RequireComponent),true))
                foreach(var t in new[]{r.m_Type0,r.m_Type1,r.m_Type2})if(t!=null&&t.IsAssignableFrom(b.GetType()))return true;
        }
        return false;
    }
    static bool IsEngineType(Type t)
    {
        string a=t.Assembly.GetName().Name;
        return a.StartsWith("Unity.")||a.StartsWith("UnityEngine")||a=="Assembly-CSharp"||a.StartsWith("Cinemachine");
    }

    void Spawn(Pending p,float now)
    {
        if(actors.Count>=maxActors)return;
        var d=definitions[p.state.data.enemy];var placement=p.placement;
        if(d.model=="Pf_Ene_Md01")d=Round1Md01Motion.Definition(d,p.state.data.indexValue);
        string model=string.IsNullOrEmpty(placement.objectName)?d.model:placement.objectName;
        if(model.StartsWith("Pf_Ene_Bos")){SkippedUnsupported++;return;}
        var rng=new System.Random(p.seed);
        var jitter=new Vector3((float)rng.NextDouble()*placement._offsetRange.x,(float)rng.NextDouble()*placement._offsetRange.y,(float)rng.NextDouble()*placement._offsetRange.z);
        var a=new Actor{model=model,state=p.state,definition=d,placement=placement,born=p.time,origin=d.position+p.state.data.offset+placement.offset+p.extraOffset+jitter,
            speed=Mathf.Max(1,placement.moveSpeed+p.speedDelta+(float)rng.NextDouble()*placement._moveSpeedRange),routes=d.routes};
        if(a.routes.Length==0)
        {
            var routeEvent=Array.Find(d.events,x=>x.eventType==15&&routes.ContainsKey(x.stringValue??""));
            if(routeEvent!=null)a.routes=new[]{routeEvent.stringValue};
        }
        var heading=Array.Find(d.events,x=>x.eventType==6&&x.vectorValue.sqrMagnitude>0);
        var entry=placement.rotate+p.state.data.rotate;
        if(model=="Pf_Ene_Md01")a.md01=new Round1Md01Motion(a.origin,a.speed,entry,d.events);
        if(model=="Pf_Ene_Sa01"&&heading!=null)a.sa01=new Round1Sa01Motion(a.origin,virtualPlayer,a.speed,heading);
        if(a.md01==null&&a.sa01==null&&Round1RouteProgram.Applies(d))a.program=new Round1RouteProgram(a.origin,a.speed,d.events,routes,d.duration);
        a.direction=heading!=null?heading.vectorValue.normalized:Quaternion.Euler(entry)*Vector3.forward;
        if(heading==null&&a.routes.Length==0&&!model.Contains("Meteo"))
        {
            // Specialised native movers are not reconstructed: enter from the authored edge (Round 1 convention).
            a.direction=Mathf.Abs(a.origin.z)>100?new Vector3(0,0,-Mathf.Sign(a.origin.z)):new Vector3(-Mathf.Sign(a.origin.x),0,0);
            if(a.direction.sqrMagnitude<.1f)a.direction=Vector3.back;
        }
        a.visual=Instantiate(model,layer);
        if(!a.visual)return;
        a.animation=a.visual.AddComponent<Round1EnemyAnimation>();
        a.animation.Begin(d,entry,n=>routes.TryGetValue(n,out var r)?r.length:(a.md01!=null?Round1Md01Motion.RouteLength(n):0),a.speed);
        p.state.actors.Add(a);actors.Add(a);Spawned++;
        UpdateActor(a,now);
    }

    void SpawnGround(State s,float now)
    {
        var d=definitions[s.data.enemy];
        string model=d.placements.Length>0&&!string.IsNullOrEmpty(d.placements[0].objectName)?d.placements[0].objectName:d.model;
        var a=new Actor{state=s,definition=d,ground=true,born=s.data.start,origin=s.data.offset};
        a.visual=Instantiate(model,ground);
        if(!a.visual)return;
        a.visual.transform.SetPositionAndRotation(s.data.offset,Quaternion.Euler(s.data.rotate));
        s.actors.Add(a);actors.Add(a);Spawned++;
    }

    // durationTime 0 means no time limit (BG07 Sc01/Sn01): the enemy ends when it leaves the screen.
    static float Lifetime(Round1EnemyWaves.Definition d)=>d.duration>0?d.duration:float.MaxValue;
    const float NativeFirstTick=1f/60;
    // Returns true when the actor should be removed.
    bool UpdateActor(Actor a,float now)
    {
        if(a.ground)return now>=a.state.data.end;
        float age=(Mathf.Max(0,now-a.born)+NativeFirstTick)*a.state.data.timeScale;
        Vector3 position,ahead,before,after;Quaternion? facing=null;
        if(a.md01!=null){a.md01.Advance(age);position=a.md01.Position;before=a.md01.Sample(Mathf.Max(0,age-.08f));after=a.md01.Sample(age+.08f);ahead=after-before;facing=a.md01.Facing;}
        else if(a.sa01!=null){a.sa01.Advance(age,virtualPlayer);position=a.sa01.Position;ahead=a.sa01.Direction;before=position-ahead*.08f;after=position+ahead*.08f;}
        else if(a.program!=null){position=a.program.Sample(age);ahead=a.program.Sample(age+.01f)-position;before=a.program.Sample(Mathf.Max(0,age-.08f));after=a.program.Sample(age+.08f);}
        else{position=Position(a,age);ahead=Position(a,age+.01f)-position;before=Position(a,Mathf.Max(0,age-.08f));after=Position(a,age+.08f);}
        a.animation.Sample(age,a.placement.lookAt,ahead,before,after);
        a.visual.transform.localPosition=position;
        a.visual.transform.localRotation=(facing??a.animation.Facing)*a.animation.RootRotation;
        var v=GameCamera.WorldToViewportPoint(a.visual.transform.position);
        bool visible=v.x>=0&&v.x<=1&&v.y>=0&&v.y<=1;a.entered|=visible;
        bool outside=v.x<-.25f||v.x>1.25f||v.y<-.25f||v.y>1.25f;
        a.finished=a.md01!=null?age>=a.md01.Duration:age>=Lifetime(a.definition)||(a.entered&&outside)||(!a.entered&&age>12&&outside);
        return a.finished;
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
        var last=routes[a.routes[a.routes.Length-1]];
        var tangent=last.tangents.Length>0?last.tangents[last.tangents.Length-1]:Vector3.back;
        return a.origin+displacement+tangent.normalized*distance;
    }

    void Remove(Actor a)
    {
        if(!a.ground){if(a.entered)Entered++;else{Unseen++;UnseenByModel.TryGetValue(a.model??"?",out int n);UnseenByModel[a.model??"?"]=n+1;}}
        a.finished=true;if(a.visual)DestroyImmediate(a.visual);
    }
    void OnDestroy()
    {
        foreach(var a in actors)Remove(a);
        if(GameCamera&&stackedOn)stackedOn.GetUniversalAdditionalCameraData().cameraStack.Remove(GameCamera);
        foreach(var t in new[]{layer,ground,spawnHolder})if(t)DestroyImmediate(t.gameObject);
    }
    void OnGUI()
    {
        if(!ready||!presentation||!presentation.showControls)return;
        GUI.Label(new Rect(16,Screen.height-28,Screen.width-32,24),$"Enemies: {Live} live, {Spawned} spawned. Original schedule; no firing or damage. Bonus waves skipped: {SkippedBonus}. Bosses not run.");
    }
    static int StableHash(string value){unchecked{int n=17;foreach(char c in value)n=n*31+c;return n;}}
}
