using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The native EnemyMover event stack (EnemyData.attribute & 16, EventStack) for AIR enemies, frame-stepped at 60 Hz.
// Port of evidence/air-route-events/tools/air_sim.py (spec: evidence/air-route-events/SPEC.md); the editor check
// ReconstructionEventStackCheck replays the Python tracks in evidence/air-route-events/sims/*.json against this class.
// Keep the two in step: same frame order, same float32 counters, same XorShift32 draws in the same order.
// Sky plane (source units): x right, z up the screen, y toward the camera at (0,400,0), 20 deg FOV, 16:9.
// Yaw about +Y: 0 = +Z (up), 90 = +X (right), 180 = down. Model forward = local +Z.
// Frame order (Step): Speed ramps (EarlyUpdate) -> pawn hooks (Ene_Sg01, Ene_Sm01) -> move tasks and rotate tweens
// (LastUpdate) -> play-area flag (PawnEnemy.LocalLateUpdate 0x1D0E790) -> stack (EnemyMover._execStackEvent 0x1D6CED0).
// A task started by the stack runs synchronously to its first await, so moves take their first step in the start frame.
// Bullet events (8, 83) only advance the stack here; Round1EnemyAttacks fires them.
public sealed partial class Round1EventStack
{
    const float DT=1f/60;
    // InGameObjectWithEvent.TaskFlags (_taskFlag 0xC8)
    const int RotateTask=1,RotateTTask=2,TranslateTask=4,SpeedTask=32,MovingTask=256,HormingTask=512,DirectionTask=1024;
    const int EndCheck=0x214; // TranslateTask | AnimationTask | HormingTask
    static readonly float Tan10=Mathf.Tan(10*Mathf.Deg2Rad);
    const float Aspect=16f/9f;
    // InGameManager.gameScreenArea (static 0x28): viewport Rect(-.15,-.15,1.3,1.3); Small/Medium enemies.
    static readonly Rect GameArea=new Rect(-.15f,-.15f,1.3f,1.3f);
    // The event types Round1RouteProgram handles (keep pure spline programs there).
    static readonly HashSet<int> RouteProgramEvents=new HashSet<int>{1,2,8,10,11,14,15,80,83};
    static readonly HashSet<int> LookAtTypes=new HashSet<int>{0,1,2,3,4,5,6,7,20,30,31,32};

    // EventStack programs that Round1RouteProgram does not cover: an event it lacks, or a single SplineMove (Mh01, Ma01_3:
    // it plays chains of two or more). Definitions with their own spline routes (EnemyData.routes) also run
    // SplineMover.Progress beside the stack; that is not modelled, so they are left out.
    public static bool Applies(Round1EnemyWaves.Definition d)=>d!=null && (d.attribute&16)!=0 && d.events!=null
        && (d.routes==null || d.routes.Length==0)
        && (Array.Exists(d.events,e=>!RouteProgramEvents.Contains(e.eventType)) || !Round1RouteProgram.Applies(d));

    // Shared deterministic RNG (air_sim.py XorShift32): [0,1) in 2^-24 steps.
    sealed class XorShift32
    {
        uint x;
        public XorShift32(int seed){x=unchecked((uint)seed)^0x9E3779B9u;if(x==0)x=0x6D2B79F5u;}
        public float U(){x^=x<<13;x^=x>>17;x^=x<<5;return (x>>8)*(1f/16777216f);}
        public float Range(float a,float b)=>a+(b-a)*U();
    }
    // A coroutine whose nested IEnumerators run like Python's `yield from` (synchronously to their first yield).
    sealed class Job
    {
        readonly Stack<IEnumerator> stack=new Stack<IEnumerator>();
        public Job(IEnumerator e){stack.Push(e);}
        public bool Advance()
        {
            while(stack.Count>0)
            {
                var top=stack.Peek();
                if(top.MoveNext()){if(top.Current is IEnumerator sub){stack.Push(sub);continue;}return true;}
                stack.Pop();
            }
            return false;
        }
    }
    sealed class Sm01State { public Vector2 dir;public float st,life;public int state=1; }

    readonly Round1EnemyWaves.ActionData[] ev;
    readonly IReadOnlyDictionary<string,Round1EnemyWaves.Route> routes;
    readonly Dictionary<string,float> routeLength=new Dictionary<string,float>();
    readonly Dictionary<string,int> labels=new Dictionary<string,int>();
    readonly Dictionary<int,int> loops=new Dictionary<int,int>();
    readonly List<Job> jobs=new List<Job>(),speedJobs=new List<Job>();
    readonly Func<Vector3> player;
    readonly string model;
    readonly XorShift32 rng;
    readonly int seedValue;
    Vector3 pos;
    float yaw,firstYaw,speed,delay,nextLookYaw;
    int idx,flags,objFlags,lookAt,easeType,nextEase=-1,nextLook,moveType,frame;
    bool finishWait,inPlay,paused,sgDone;
    // _moveTypeUpdateAsync state (one shared set per mover, as natively)
    Vector2 moveValue;float localDuration,homingDuration,moveValue0,turnAcc,near2;string route;Vector3 splineRoot;
    Sm01State sm;
    // Pf_Ene_Sm01 and Pf_Ene_Sm02 both carry InGame.Kernel.Enemy.Ene_Sm01 (script fileID 872860683); BG04 spawns 4 of each.
    static bool SmClass(string m)=>m=="Pf_Ene_Sm01" || m=="Pf_Ene_Sm02";

    public Vector3 Position=>pos;
    public float Yaw=>Mod(yaw,360);
    public float Speed=>speed;
    public int ObjFlags=>objFlags;    // InGameObjectFlag from 10/11 (1 OffCollision, 256 NoBullet, 512 ForceFire, ...)
    public int TaskFlags=>flags;
    public bool Entered { get; private set; }
    public bool Ended { get; private set; }
    public string EndReason { get; private set; }="";
    public int Frame=>frame;
    public float Time=>frame*DT;

    public Round1EventStack(Round1EnemyWaves.Definition d,Vector3 spawn,float yaw,float speed,
        IReadOnlyDictionary<string,Round1EnemyWaves.Route> routes,string model,int seed,Func<Vector3> player,int indexValue=0)
    {
        stackMode=(d.attribute&16)!=0;
        var spline=EventSpline(d);rDuration=d.duration;
        var names=ClassRoutes(model,indexValue)??(d.routes!=null && d.routes.Length>0?d.routes:spline!=null?new[]{spline.stringValue??""}:null);
        routeNames=names!=null && names.Length>0 && Array.TrueForAll(names,n=>routes!=null && routes.ContainsKey(n))?names:null;
        rDurationFrame=routeNames!=null && spline!=null && ClassRoutes(model,indexValue)==null;
        ev=d.events??new Round1EnemyWaves.ActionData[0];this.routes=routes;this.model=model??"";this.player=player;this.indexValue=indexValue;
        rng=new XorShift32(seed);seedValue=seed;pos=spawn;this.yaw=firstYaw=yaw;this.speed=speed;
        if(this.model=="Pf_Ene_St01"){objFlags|=1;this.yaw=0;}      // Ene_St01.ReStart: OffCollision for _InvincibleTime, StartAngle
        if(this.model=="Pf_Ene_Mn01")pos.z=110;                     // Ene_Mn01h.ReStart: _localPosition.z = _STARTPOS
        if(this.model=="Pf_Ene_Mm01")Mm01Start(spawn,indexValue);   // Ene_Mm01.ReStart: offsets, laser length = spawn y, parked
        var pl=d.placements!=null && d.placements.Length>0?d.placements[0]:null;
        lookAt=pl!=null?pl.lookAt:0;easeType=pl!=null?pl.easeType:0;
        // EnemyData.Coordinate (0x1D321E0): label name -> first LabelEvent index; GetLabelIndex returns 0 when missing.
        for(int i=0;i<ev.Length;i++)if(ev[i].eventType==5){string k=ev[i].stringValue??"";if(!labels.ContainsKey(k))labels[k]=i;}
        if(routeNames!=null)
        {
            rStart=pos;
            // SplineMover.SetEventData 0x1D44240 (route mode only): Rotate/Scale/Translate with dotime 0 at awakeRate 0 run at
            // once; the rest are kept sorted by awakeRate (InsertEventSorted 0x1D43BE0, stable). The stack owns them otherwise.
            if(!stackMode)foreach(var e in ev)
            {
                if((e.eventType==2 || e.eventType==4 || e.eventType==13) && e.dotime==0 && e.awakeRate==0)pendingNow.Add(e);
                else rEvents.Add(e);
            }
            for(int i=1;i<rEvents.Count;i++)for(int j=i;j>0 && rEvents[j-1].awakeRate>rEvents[j].awakeRate;j--){var t=rEvents[j];rEvents[j]=rEvents[j-1];rEvents[j-1]=t;}
        }
    }

    // A child is stepped by its parent (Round1EventStackGroups); the host steps parents and lone enemies.
    public void Step(){if(Owner==null)StepSelf();}
    public Vector3 PreviousPosition { get; private set; }
    // Bullet events the stack reached, for the host to cue (Round1EnemyAttacks.CueFromStack).
    public readonly List<Round1EnemyWaves.ActionData> Bullets=new List<Round1EnemyWaves.ActionData>();
    // The stack interpreter runs (attribute 16; So01 has none, Mk01/Si01 run empty ones): it times its own Bullets.
    public bool RunsStack=>stackMode && model!="Pf_Ene_So01" && model!="Pf_Ene_Mk01" && model!="Pf_Ene_Si01";         // position before the last step (the host's heading)
    // The mover reaches its own Bullet events: the stack's, or route mode's by awakeRate (SplineMover.UpdateEvent).
    public bool TimesBullets=>RunsStack || routeNames!=null && !stackMode;
    void StepSelf()
    {
        if(Ended){if(Children.Count>0){StepChildren();frame++;}return;}
        PreviousPosition=pos;
        StepDelayed();
        RunJobs(speedJobs,false);                                   // _changeSpeedAsync yields on EarlyUpdate
        Pawn();
        if(!SjFrozen)RunJobs(jobs,true);                            // _moveTypeUpdateAsync (LastUpdate), DOTween Manual [I]
        if(model=="Pf_Ene_St01")St01();                             // LocalLateUpdate: ActionMove before PawnEnemy.LocalLateUpdate
        else if(model=="Pf_Ene_Ss01")Ss01();
        else if(model=="Pf_Ene_Mn01")Mn01h();                       // class code before the base update
        else if(model=="Pf_Ene_Ml01")Ml01();                        // _moveState, then the base update
        else if(SjClass(model))Sj01();                              // _moveState before the stack / route
        else if(bitState!=0)Mn01cBit();                             // a summoned shield bit
        if(SmClass(model) && !Entered)Entered=InArea(pos);
        inPlay=InArea(pos);                                         // IsInGameAreaWorld(pos, gameScreenAreas[Small])
        // So01 has no stack; Mk01's (and its Si01's) is empty: end rule 2 would remove them on frame 1 above the screen.
        if(!Ended && !paused && !SjFrozen && stackMode && model!="Pf_Ene_So01" && model!="Pf_Ene_Mk01" && model!="Pf_Ene_Si01")ExecStack(); // EnemyMover.Progress requires IsPlaying
        if(!Ended && routeNames!=null && !SjFrozen)RouteStep();     // SplineMover._ProgressSpline, after the stack
        if(model=="Pf_Ene_So01" && !Ended)So01();                   // ProgressEvent: mover first, then _moveState
        else if(model=="Pf_Ene_Mg01" && indexValue!=0 && !Ended)Mg01(); // LocalLateUpdate: stack first, then CustomMove
        else if(model=="Pf_Ene_Mp01" && !Ended)Mp01();                   // LocalLateUpdate: stack first, then ActionMove
        else if(model=="Pf_Ene_Mk01" && !Ended){Mk01();SiRepulsion();}   // LocalLateUpdate: base first, then _move, _childRepulsion
        else if(model=="Pf_Ene_Si01" && !Ended)Si01();                   // base first, then _stateExec
        else if(model=="Pf_Ene_Mm01" && !Ended)Mm01();                   // base first, then _StateExec
        else if(model=="Pf_Ene_Mc01" && !Ended)Mc01();                   // base first, then the fire timer
        frame++;
        StepChildren();
    }
    void RunJobs(List<Job> list,bool stopOnEnd)
    {
        var snapshot=list.ToArray();
        foreach(var j in snapshot){if(stopOnEnd && Ended)break;if(!j.Advance())list.Remove(j);}
    }
    void Start(IEnumerator e,List<Job> list){var j=new Job(e);if(j.Advance())list.Add(j);}
    void End(string reason){if(Ended)return;Ended=true;EndReason=reason;}

    // ---- math helpers (KernelUtility / VectorUtility) ---------------------------------------------------------
    static float Mod(float a,float m){float r=a%m;return r<0?r+m:r;}
    static float ViewHeight(float y)=>2*(400-y)*Tan10;
    static Vector2 Viewport(Vector3 p){float h=ViewHeight(p.y);return new Vector2(.5f+p.x/(h*Aspect),.5f+p.z/h);}
    static bool InArea(Vector3 p){var v=Viewport(p);return GameArea.x<=v.x && v.x<GameArea.x+GameArea.width && GameArea.y<=v.y && v.y<GameArea.y+GameArea.height;}
    static float Norm180(float a)=>Mod(a+180,360)-180;                                   // KernelUtility.Normalized 0x1DD7700
    static float MultipleRound(float v,float m)=>v>=0?Mathf.Floor(v/m+.5f)*m:Mathf.Ceil(v/m-.5f)*m;   // 0x1DF86C0
    static float PlaneYaw(float dx,float dz)=>dx*dx+dz*dz>=.01f?Mod(Mathf.Atan2(dx,dz)*Mathf.Rad2Deg,360):0; // GetPlaneEuler 0x1DD70A0
    static float TableAngle(float deg){int n=(int)(deg*10)%3600;if(n<0)n+=3600;return n/10f*Mathf.Deg2Rad;}  // Sinf/Cosf 0.1 deg
    static float TSin(float deg)=>Mathf.Sin(TableAngle(deg));                           // VectorUtility.Sinf 0x1DF8A70
    static float TCos(float deg)=>Mathf.Cos(TableAngle(deg));                           // VectorUtility.Cosf 0x1DF6FA0
    static float Dot(Vector2 a,Vector2 b)=>a.x*b.x+a.y*b.y;
    // VectorUtility.HomingDirection(cur, aim, sin, cos) 0x1DF73B0
    static Vector2 HomingDirection(Vector2 cur,Vector2 aim,float s,float c)
    {
        float l=Mathf.Sqrt(aim.x*aim.x+aim.y*aim.y);var t=l>1e-5f?new Vector2(aim.x/l,aim.y/l):Vector2.zero;
        var a=new Vector2(c*cur.x-s*cur.y,s*cur.x+c*cur.y);var b=new Vector2(c*cur.x+s*cur.y,-s*cur.x+c*cur.y);
        if(Dot(t,cur)>=Dot(a,cur))return t;
        float da=Dot(a,aim),db=Dot(b,aim);                 // aim straight behind: a/b tie; native float noise decides,
        return da>=db || Mathf.Abs(da-db)<=1e-4f*l?a:b;    // here a near-tie (1e-4 relative) picks a, like air_sim.py
    }
    // EasingUtility.Easing01: 0 Linear, 3 EaseInOut [I: smoothstep], 7 EaseInOutSine; others linear here.
    static float Ease(int kind,float u)=>kind==3?3*u*u-2*u*u*u:kind==7?-(Mathf.Cos(Mathf.PI*u)-1)/2:u;
    Vector2 PlayerXZ(){var p=player!=null?player():Vector3.zero;return new Vector2(p.x,p.z);}
    float RouteLength(string name)
    {
        if(routeLength.TryGetValue(name,out float l))return l;
        var r=routes[name];l=0;if(r.points!=null)for(int i=1;i<r.points.Length;i++)l+=Vector3.Distance(r.points[i-1],r.points[i]);
        routeLength[name]=l;return l;
    }
    static Vector3 Sample(Round1EnemyWaves.Route r,float u)
    {
        var ts=r.times;var ps=r.points;
        if(u<=ts[0])return ps[0];if(u>=1)return ps[ps.Length-1];
        int i=0;for(int j=0;j<ts.Length;j++)if(ts[j]<=u)i=j;int k=Mathf.Min(i+1,ts.Length-1);
        float f=(u-ts[i])/Mathf.Max(1e-6f,ts[k]-ts[i]);return ps[i]+(ps[k]-ps[i])*f;
    }
    static Vector2 Tangent(Round1EnemyWaves.Route r,float u){var a=Sample(r,Mathf.Max(0,u-.01f));var b=Sample(r,Mathf.Min(1,u+.01f));return new Vector2(b.x-a.x,b.z-a.z);}

    // ---- task bodies (InGameEnemyMoveBase._execEventWithRepeat MoveNext 0x1CF6410, jump table 0x1CF96E0) -------
    IEnumerator WaitFlag(int f){while((flags&f)!=0)yield return null;}       // <>c__DisplayClass31_0.WaitTaskFlag 0x1CF5650
    IEnumerator WaitSecs(float t){while(t>0){yield return null;t-=DT;}}
    // _delayRotate 0x1D2CAA0: relative DOTween yaw tween (Manual update), preWait / postWait, holds `flag`.
    IEnumerator TweenYaw(float amount,float dur,int kind,int flag,float pre,float post)
    {
        flags|=flag;
        yield return WaitSecs(pre);
        float start=yaw,el=0;
        while(true)
        {
            yield return null;el+=DT;bool done=el>=dur;yaw=start+amount*Ease(kind,done?1:el/dur);
            if(done)break;
        }
        yield return WaitSecs(post);
        flags&=~flag;
    }
    // 2 Rotate (case 0x1CF6DB6): local; dotime <= 0.001 sets the absolute angle; else relative unless flag0, InOutSine if intValue1.
    IEnumerator Rotate(Round1EnemyWaves.ActionData e)
    {
        float v=e.vectorValue.y;
        if(!string.IsNullOrEmpty(e.nameValue) && (StackRoute || HasChild!=null && HasChild(e.nameValue))){yield return TweenChild(e);yield break;}
        if(e.dotime<=.001f){yaw=v;yield break;}
        float amount=e.flag0!=0?v-yaw:v;
        yield return TweenYaw(amount,e.dotime,e.intValue1!=0?7:0,RotateTask,e.value0,e.value1);
    }
    // _getTransform(nameValue) (ground-route-events/SPEC.md sec. 2 Rotate): a Rotate whose nameValue names a child turns
    // that child, never the root, in every mover mode (Sf01's pf_ene_sf01, Se01's pf_ene_se01, ...). The root's heading,
    // which ForwardMove and SplineMove read, is unchanged. HasChild is the host's cache-key test (missing key -> root).
    public Func<string,bool> HasChild;
    readonly Dictionary<string,Vector3> childEuler=new Dictionary<string,Vector3>();
    readonly HashSet<string> childAbsolute=new HashSet<string>();
    // Per child path: its local Euler (absolute once an instant Rotate set it, else relative to the prefab's rotation).
    public IReadOnlyDictionary<string,Vector3> ChildEulers=>childEuler;
    public bool ChildAbsolute(string path)=>childAbsolute.Contains(path);
    IEnumerator TweenChild(Round1EnemyWaves.ActionData e)
    {
        string path=e.nameValue;var v=e.vectorValue;
        if(e.dotime<=.001f){childEuler[path]=v;childAbsolute.Add(path);yield break;}   // t.localRotation = Euler(v)
        flags|=RotateTask;
        yield return WaitSecs(e.value0);
        childEuler.TryGetValue(path,out var start);
        Vector3 amount=e.flag0!=0?v-start:v;float el=0;int kind=e.intValue1!=0?7:0;
        while(true)
        {
            yield return null;el+=DT;bool done=el>=e.dotime;childEuler[path]=start+amount*Ease(kind,done?1:el/e.dotime);
            if(done)break;
        }
        yield return WaitSecs(e.value1);
        flags&=~RotateTask;
    }
    // 3 RotateT (case 0x1CF7029 -> InGameObjectWithEvent.DelayRotate 0x1D1DC60, MoveNext 0x1D26710): face the player.
    IEnumerator RotateT(Round1EnemyWaves.ActionData e)
    {
        yield return WaitFlag(RotateTTask);
        var p=PlayerXZ();float yt=PlaneYaw(p.x-pos.x,p.y-pos.z);int q=e.intValue1;
        if(q>0)yt=MultipleRound(yt,q);
        float dot=e.dotime,rate=e.value1;
        if(dot<=.001f && rate<=0){yaw=yt;yield break;}                        // instant world rotation, vectorValue ignored
        float cur=Mod(yaw,360);if(q>0)cur=MultipleRound(cur,q);
        float delta=Norm180(yt-cur);
        if(Mathf.Abs(delta)<1e-3f)delta=0;                    // already facing: float noise must not pick the spin sign
        float rot=delta+e.vectorValue.y,dur=dot;
        if(rate>0)
        {
            float ang=Mathf.Sqrt(e.vectorValue.x*e.vectorValue.x+rot*rot+e.vectorValue.z*e.vectorValue.z);
            if(ang<180 && e.flag0!=0){rot=rot<=0?rot+360:rot-360;ang=360-ang;} // the long way round (FastBeyond360)
            dur=ang/rate;
        }
        if(dur<=0)yield break;
        yield return TweenYaw(rot,dur,0,RotateTTask,e.value0,0);              // DORotate world, relative, Linear
    }
    // InGameEnemyMoveBase._moveTypeUpdateAsync MoveNext 0x1CF9730 (switch 0x1CFA410): 2/4 straight, 3/5 homing, 6 spline.
    IEnumerator Move(int flag)
    {
        flags|=flag;
        while(true)
        {
            if(paused){yield return null;continue;}
            Vector3 gp=pos;float step=DT*speed;bool done=false;
            if(moveType==2 || moveType==4)
            {pos.x+=moveValue.x*step;pos.z+=moveValue.y*step;localDuration-=DT;done=localDuration<=0;}
            else if(moveType==3 || moveType==5)
            {
                turnAcc+=moveValue0;                                               // * _deltaTimeScale (1 at 60 Hz)
                var p=PlayerXZ();var aim=new Vector2(p.x-gp.x,p.y-gp.z);
                if(aim.x*aim.x+aim.y*aim.y>=near2)
                {
                    while(turnAcc>=moveValue0 && moveValue0>0)
                    {turnAcc-=moveValue0;moveValue=HomingDirection(moveValue,aim,TSin(moveValue0),TCos(moveValue0));Face();}
                }
                else turnAcc=0;
                pos.x+=moveValue.x*step;pos.z+=moveValue.y*step;localDuration-=DT;homingDuration-=DT;
                if(homingDuration<=0 || moveValue0<=0)
                {moveValue=HomingDirection(moveValue,aim,TSin(turnAcc),TCos(turnAcc));Face();done=localDuration<=0;moveType=4;}
            }
            else if(moveType==6)
            {
                if(step>0)
                {
                    var r=routes[route];float len=RouteLength(route),u0=Mathf.Min(1,localDuration/len);localDuration+=step;float u=Mathf.Min(1,localDuration/len);
                    float k=easeType==7?InOutSine01(u):Ease(easeType,u);pos=splineRoot+Sample(r,k)-r.points[0];   // relative to the route's first point (Mg01 starts at x -+100); 7 through the Cosf table
                    if(u>=1)done=true;
                    else if(lookAt==1){var t=Tangent(r,k);yaw=PlaneYaw(t.x,t.y);}
                    else if(lookAt>=30 && lookAt<=32)Drift(Sample(r,k+(u-u0)).x-Sample(r,k).x);   // _getRotate(spline, _spRate, r1-r0): yaw stays _firstRotate
                    else if(lookAt==20){var t=Tangent(r,k);yaw=PlaneYaw(t.x,t.y);RollForward(r,k,len);}
                }
            }
            bool inside=InArea(gp);                                                // IsGameArea (Small/Medium)
            if(Entered)
            {
                if(!inside && (moveType==2 || moveType==3 || moveType==4)){End("area-exit");yield break;}   // isAreaoutEnd 0x1CDD600
            }
            else Entered=inside;
            if(done)break;
            yield return null;
        }
        moveType=999;flags&=~flag;
    }
    // updateHormingDirection 0x1CDD620
    void Face(){if(lookAt==0)yaw=firstYaw;else if(lookAt==1)yaw=PlaneYaw(moveValue.x,moveValue.y);}
    // 12 ForwardMove (case 0x1CF803B): root forward (+Z, -Z for lookAt Back) at the start yaw.
    IEnumerator ForwardMove(Round1EnemyWaves.ActionData e)
    {
        yield return WaitFlag(MovingTask);
        moveType=2;float a=yaw*Mathf.Deg2Rad,sgn=lookAt==2?-1:1;
        moveValue=new Vector2(sgn*Mathf.Sin(a),sgn*Mathf.Cos(a));localDuration=e.dotime;
        yield return Move(MovingTask);
    }
    // 7 Direction (case 0x1CF7ADA): raw vectorValue, not normalised.
    IEnumerator Direction(Round1EnemyWaves.ActionData e)
    {
        yield return WaitFlag(DirectionTask);
        moveType=2;moveValue=new Vector2(e.vectorValue.x,e.vectorValue.z);localDuration=e.dotime;
        yield return Move(DirectionTask);
    }
    // 6 Horming (case 0x1CF7288; per frame 0x1CF9BBA).
    IEnumerator Horming(Round1EnemyWaves.ActionData e)
    {
        yield return WaitFlag(MovingTask|HormingTask);
        moveType=e.flag0!=0?5:3;   // 5 targets InGameManager.GetStrongestMostNear natively; the player here
        if(InArea(pos)){float a=yaw*Mathf.Deg2Rad;moveValue=new Vector2(Mathf.Sin(a),Mathf.Cos(a));}   // gameScreenAreas[0]
        else{var v=e.vectorValue;float l=v.magnitude;moveValue=l>1e-5f?new Vector2(v.x/l,v.z/l):Vector2.zero;}
        Face();
        moveValue0=e.value0+rng.U()*e.randomFire;homingDuration=e.value1;
        near2=e.intValue1*e.intValue1;localDuration=e.dotime;turnAcc=e.dotime<1?moveValue0:0;
        yield return Move(HormingTask);
    }
    // 15 SplineMove (case 0x1CF8947; per frame 0x1CF9F29): by distance at _currentSpeed, Easing01(_easingType).
    IEnumerator SplineMove(Round1EnemyWaves.ActionData e)
    {
        string name=e.stringValue??"";
        if(routes==null || !routes.ContainsKey(name))yield break;
        yield return WaitFlag(MovingTask);
        if(nextLook==0)firstYaw=yaw;                                               // SetRotate(localRotation, 0)
        else{if(nextLook==20 || nextLook>=30 && nextLook<=32){rollAcc=0;Roll=0;}lookAt=nextLook;yaw=firstYaw=nextLookYaw;nextLook=0;}
        if(nextEase!=-1){easeType=nextEase;nextEase=-1;}
        route=name;moveType=6;localDuration=0;splineRoot=pos;
        yield return Move(MovingTask);
    }
    // 13 Translate (case 0x1CF83CC, _delayTranslate 0x1D2DCB0): parent-local, relative when flag0, time = distance/speed.
    IEnumerator Translate(Round1EnemyWaves.ActionData e)
    {
        yield return WaitFlag(TranslateTask);
        var v=e.vectorValue;
        if(Mathf.Abs(speed)<1e-5f){pos=v;yield break;}
        float dist=e.flag0!=0?v.magnitude:Vector3.Distance(pos,v);float dur=dist/speed;flags|=TranslateTask;
        yield return WaitSecs(e.value0);
        Vector3 start=pos,target=e.flag0!=0?start+v:v;float el=0;
        while(dur>0)
        {
            yield return null;el+=DT;bool done=el>=dur;pos=start+(target-start)*(done?1:el/dur);
            if(done)break;
        }
        yield return WaitSecs(e.value1);
        flags&=~TranslateTask;
    }
    // 14 Speed (case 0x1CF87C4, _changeSpeedAsync MoveNext 0x1CF6090): linear ramp to value0 over dotime; intValue1 unused.
    IEnumerator SpeedRamp(Round1EnemyWaves.ActionData e)
    {
        yield return WaitFlag(SpeedTask);
        float tt=Mathf.Min(Mathf.Max(e.dotime,0),100),tp=0,b=speed,r=e.value0;flags|=SpeedTask;
        while(tt>tp){tp+=DT;speed=b+(r-b)*Mathf.Min(1,tp/tt);yield return null;}
        flags&=~SpeedTask;
    }
    IEnumerator SpeedNow(Round1EnemyWaves.ActionData e){yield return WaitFlag(SpeedTask);speed=e.value0;}
    // 10 SetObjFlag / 11 ResetObjFlag (case 0x1CF7ED1)
    IEnumerator ObjFlag(Round1EnemyWaves.ActionData e,bool on)
    {
        yield return WaitSecs(e.value0);
        objFlags=on?objFlags|e.intValue1:objFlags&~e.intValue1;
    }
    // 1 Delay with value0 > 0: InGameObjectWithEvent._delayPlayPause 0x1D2C7A0 (pause the mover after value0 for dotime).
    IEnumerator PlayPause(float start,float sec)
    {
        yield return WaitSecs(start);
        paused=true;
        yield return WaitSecs(sec);
        paused=false;
    }
    // 84 RotateR (case 0x1CF903E): instant random local offset, RandomUtility.Range(-v, v) per axis (x, y, z drawn in order).
    void RotateR(Round1EnemyWaves.ActionData e)
    {
        var v=e.vectorValue;rng.Range(-v.x,v.x);float dy=rng.Range(-v.y,v.y);rng.Range(-v.z,v.z);
        yaw+=dy;
    }

    // ---- EnemyMover._execStackEvent 0x1D6CED0 ------------------------------------------------------------------
    int Label(string name)=>labels.TryGetValue(name??"",out int i)?i:0;
    void ExecStack()
    {
        delay-=DT;                                                                 // _isExecStackEvent 0x1D6D3D0
        if(delay>0){if(lookAt>=30 && lookAt<=32)Drift(0);return;}                // waiting with a drift type: _AddDriftAngle(0, 0.2, dt)
        if(finishWait)return;
        delay=0;
        for(int guard=0;guard<1001;guard++)
        {
            if(idx>=ev.Length)break;
            var e=ev[idx];int t=e.eventType;
            if(t==101)                                                             // Loop: jumps back intValue1 times
            {
                if(!loops.TryGetValue(idx,out int c))c=e.intValue1;
                c--;loops[idx]=c;
                if(c>=0){idx=Label(e.stringValue);continue;}
                loops.Remove(idx);
            }
            else if(t==100)                                                        // Goto (0x1D6D1B5)
            {
                if(!(e.intValue1>=100 || e.intValue1>(int)(rng.U()*100))){idx=Label(e.stringValue);continue;}
            }
            else if(t==1000)                                                       // FinishDestroy
            {
                if((flags&EndCheck)!=0){idx=ev.Length;break;}
                End("finish-destroy");return;
            }
            else if(t==1001){finishWait=true;return;}                             // FinishWait: the stack stops for good
            else if(t==81)flags=e.intValue1!=0?flags&~e.intValue1:0;              // TaskClear (0x1D6D194, ClearTaskFlag 0x1D1D970)
            else if(t==80)                                                         // TaskWait
            {
                int mask=e.intValue1!=0?e.intValue1:0x7fffffff;
                if((flags&mask)!=0)return;
            }
            else if(t==1 || t==20)                                                 // Delay / Idle
            {
                float d=e.dotime;
                if(e.flag0!=0 && e.value0<0)d+=e.value0;                           // _wakeAfterSecond = 0 [I]
                idx++;
                if(t==1 && d>0 && e.value0>0){Start(PlayPause(e.value0,d),jobs);d=0;}
                delay=d;
                if(d>0)return;
                continue;
            }
            else if(t==16){if(e.intValue1>=0 && e.intValue1<=12)nextEase=e.intValue1;}   // Easing -> next SplineMove (ExecEvent 0x1CD9E7B)
            else if(t==19){if(LookAtTypes.Contains(e.intValue1)){nextLook=e.intValue1;nextLookYaw=e.vectorValue.y;}}   // LookAt (0x1CD9EF7)
            else if(t==14)Run(e,()=>e.dotime>0?SpeedRamp(e):SpeedNow(e),speedJobs);
            else if(t==10 || t==11)Run(e,()=>ObjFlag(e,t==10),jobs);
            else if(t==2)Run(e,()=>Rotate(e),jobs);
            else if(t==3)Run(e,()=>RotateT(e),jobs);
            else if(t==6)Run(e,()=>Horming(e),jobs);
            else if(t==7)Run(e,()=>Direction(e),jobs);
            else if(t==12)Run(e,()=>ForwardMove(e),jobs);
            else if(t==13)Run(e,()=>Translate(e),jobs);
            else if(t==15)Run(e,()=>SplineMove(e),jobs);
            else if(t==84)RotateR(e);
            else if(t==8 || t==83)Bullets.Add(e);                                 // Bullet: Round1EnemyAttacks cues it now
            // 5 Label, 8/83 Bullet (fired by Round1EnemyAttacks), 4 Scale / 17 / 18 GravityForwardMove (wrapper tail: no body),
            // 9 Animation and 21 Parts (not modelled), 82 TaskCancel (not used by any stage program; not modelled): no motion.
            idx++;
        }
        if(idx>=ev.Length && (flags&EndCheck)==0 && !inPlay && !Ended)End("events-exhausted");
    }
    // _execEventWithRepeat (ground-route-events/SPEC.md sec. 2): repeatCount R runs the body R+1 times, repeatDelay apart with
    // the overshoot carried over, after one Yield. The body is started, not awaited: its own task flag serialises it (Sf01a's
    // ForwardMove 0.1 s x 101 flies on for ~10 s). Bullet repeats are Round1EnemyAttacks'.
    void Run(Round1EnemyWaves.ActionData e,Func<IEnumerator> body,List<Job> list){if(e.repeatCount>0)Start(Repeat(e,body,list),list);else Start(body(),list);}
    IEnumerator Repeat(Round1EnemyWaves.ActionData e,Func<IEnumerator> body,List<Job> list)
    {
        int left=e.repeatCount;float wait=e.repeatDelay;
        yield return null;
        while(true)
        {
            Start(body(),list);
            if(left<=0)yield break;
            while(wait>0){wait-=DT;yield return null;}
            wait+=e.repeatDelay;left--;
        }
    }

    // ---- SplineMover route mode (evidence/movers/Ene_Mp02/SPEC.md sec. 3, Ene_Mx02 sec. 3, Ene_Mc01 sec. 3) ------------
    // Definitions with routes (attribute 0: the events are route events; or a stack that only fires, Mp02) play their
    // routes one after another, each a relative leg eased by its own rate (speed*t/length); events fire when
    // routeIndex + eased offset passes their awakeRate. Removed when the last route ends: no area exit, no duration.
    public static bool RouteMode(Round1EnemyWaves.Definition d,string model)=>d!=null && (ClassRoutes(model,0)!=null
        || d.routes!=null && d.routes.Length>0 || EventSpline(d)!=null);
    // No routes and no stack (Sk01, La01): the awake-0 SplineMove's SetSpline (vslot 0x2F8 -> SplineMover.SetSpline 0x1D44540)
    // gives the SplineMover its _splineLength, so _ProgressSpline advances by distance from the next frame, writes the
    // position (SplineMover.Progress 0x1D43DF0 overwrites the move task's), dispatches the other events by that rate and
    // ends the enemy (EndRoute) when the spline ends. Before that frame its rate is _durationPassTime / duration.
    static Round1EnemyWaves.ActionData EventSpline(Round1EnemyWaves.Definition d)=>d==null || (d.attribute&16)!=0
        || d.routes!=null && d.routes.Length>0 || d.events==null?null:Array.Find(d.events,e=>e.eventType==15 && e.awakeRate==0);
    public static bool HasClassRoutes(string model)=>ClassRoutes(model,0)!=null;
    // Stack + route (Ene_Sf01/SPEC.md: Sf01 BG05, Sr01 BG06): the stack runs its events first, then the route step moves
    // the enemy at the stack's current speed. The route holds no task bit; the enemy ends by the stack's rule 2 or at the
    // route's end, whichever comes first.
    public bool StackRoute=>stackMode && routeNames!=null && ClassRoutes(model,0)==null;
    // Ene_Mp02.CreateRouteData 0x1CFD8C0: the prefab's _routeNames[_indexValue] replace the definition's routes.
    static readonly string[][] Mp02Routes={new[]{"common_D150","common_L300"},new[]{"common_D150","common_R300"},new[]{"common_R150","common_U200"},new[]{"common_L150","common_U200"}};
    // Ene_Lb01.CreateRouteData 0x1DBCC90: the one route _routeNames[_indexValue] (Pf_Ene_Lb01: move_lb01_00..14).
    static string[] ClassRoutes(string model,int index)=>model=="Pf_Ene_Mp02"?Mp02Routes[Mathf.Clamp(index,0,3)]
        :model=="Pf_Ene_Lb01"?new[]{"move_lb01_"+Mathf.Clamp(index,0,14).ToString("00")}:null;
    readonly bool stackMode;
    readonly string[] routeNames;
    readonly List<Round1EnemyWaves.ActionData> rEvents=new List<Round1EnemyWaves.ActionData>(),pendingNow=new List<Round1EnemyWaves.ActionData>();
    int routeIdx,rEv;float rRate,rOffset,rLastRate,rPause,rDuration;Vector3 rStart;bool rDurationFrame;
    public bool RouteDrivenMover=>routeNames!=null;
    // The route the SplineMover is on and its eased offset (_currentOffset 0x208), for EnemyMoverSnake's bones.
    public Round1EnemyWaves.Route CurrentRoute=>routeNames!=null?routes[routeNames[routeIdx]]:null;
    public float RouteOffset=>rOffset;
    public float CurrentRouteLength=>routeNames!=null?RouteLength(routeNames[routeIdx]):0;
    void RouteStep()
    {
        if(pendingNow.Count>0){foreach(var e in pendingNow)RouteEvent(e);pendingNow.Clear();}
        if(rPause>0){rPause-=DT;return;}                                           // [I] Delay: _delayPlayPause, moverState 4
        string name=routeNames[routeIdx];var r=routes[name];float len=RouteLength(name);
        float prev=rOffset;
        if(rDurationFrame){rDurationFrame=false;rRate=rDuration>0?DT/rDuration:1;}  // no spline until its SplineMove fires this frame
        else if(len>0)rRate+=DT*speed/len;
        bool done=rRate>=1;float k=done?1:easeType==7?InOutSine01(rRate):Ease(easeType,rRate);
        rOffset=k;RouteEvents(prev,k-prev);if(Ended)return;
        // _getRotate 0x1CDC830 when off < 1 (lookAt 1 below): drift types bank on the step's x, RollForward on the turn ahead.
        if(!done && lookAt>=30 && lookAt<=32)Drift(Sample(r,k+(k-prev)).x-Sample(r,k).x);
        else if(!done && lookAt==20 && len>0)RollForward(r,k,len);
        if(done)
        {
            if(routeIdx+1>=routeNames.Length)                                      // EndRoute (_isEndRouteKeep false)
            {
                if(StackRoute)pos=rStart+Sample(r,1)-r.points[0];                  // stack + route: that frame writes the last point
                End("route-end");return;
            }
            if(nextEase!=-1){easeType=nextEase;nextEase=-1;}
            routeIdx++;rStart=pos;rRate=0;rOffset=0;                          // updateRouteData(0) (dt zeroed, 0x1D44BF7 / 0x1D44E22): holds this frame
            return;
        }
        pos=rStart+Sample(r,k)-r.points[0];                                        // _routeRotate identity [I]
        if(lookAt==1 || lookAt==20){var t=Tangent(r,k);if(t.x*t.x+t.y*t.y>1e-8f)yaw=PlaneYaw(t.x,t.y);}   // [I] nose along the eased path
    }
    // ---- banking (InGameEnemyMoveBase._rollAngle 0x16C) --------------------------------------------------------------
    // Bank about the model's local Z, degrees (applied after the yaw). Drift types 30-32 and RollForward 20 only.
    public float Roll { get; private set; }
    float rollAcc;
    // _AddDriftAngle(x, 0.2, dt) 0x1CDB930, tables from the .cctor 0x1CDBD00 (k = lookAt - 30; ../movers/Ene_Sq01/SPEC.md sec. 5).
    static readonly float[] DriftArcs={45,30,20},DriftSpeed={3,2,1},DriftBackSpeed={180,90,45};
    void Drift(float dx)
    {
        int k=lookAt-30;float g=dx*DriftSpeed[k];
        if(Mathf.Abs(g)<.2f){float back=DT*DriftBackSpeed[k];rollAcc=back>=Mathf.Abs(rollAcc)?0:rollAcc-Mathf.Sign(rollAcc)*back;}
        else rollAcc+=g*rollAcc<0?2*g:.25f*g;
        rollAcc=Mathf.Clamp(rollAcc,-100,100);Roll=rollAcc/100*DriftArcs[k];
    }
    // _rollForwardMove 0x1CDCE50: the heading 0.02-0.08 s ahead (four tangents averaged) against the current one
    // (VectorUtility.GetQuaternionDiff 0x1DF7240: yaw difference). The roll gains a quarter of the turn (twice it when
    // reversing), else returns by 6 a frame; clamped to +-100. The up vector leans to the turn side by |roll|/160, so the
    // model banks atan(t / (1 - t)): up to 59 degrees. Not scaled by dt (60 Hz).
    void RollForward(Round1EnemyWaves.Route r,float off,float len)
    {
        float step=speed*.02f/len;Vector2 ahead=Vector2.zero;
        for(int i=1;i<=4;i++){var t=Tangent(r,Mathf.Min(1,off+i*step));ahead+=t.normalized*.25f;}
        var now=Tangent(r,off);
        float diff=Norm180(PlaneYaw(ahead.x,ahead.y)-PlaneYaw(now.x,now.y));
        if(Mathf.Abs(diff)>=1)rollAcc+=diff*(rollAcc*diff<0?2:.25f);
        else rollAcc=Mathf.Abs(rollAcc)<=6?0:rollAcc-Mathf.Sign(rollAcc)*6;
        rollAcc=Mathf.Clamp(rollAcc,-100,100);
        float lean=Mathf.Min(1,Mathf.Abs(rollAcc)/160);
        Roll=-Mathf.Sign(rollAcc)*Mathf.Atan2(lean,1-lean)*Mathf.Rad2Deg;          // up toward Matrix4x4.Rotate(look)·right: a negative Z turn
    }
    // SplineMover.UpdateEvent 0x1D44720: an event whose rate was jumped over is lost; one at n.0 fires on route n's first frame.
    void RouteEvents(float prev,float delta)
    {
        if(rEvents.Count==0 || delta<=0)return;
        float r0=routeIdx+prev,r1=r0+delta;if(rLastRate>=r1)return;rLastRate=r1;
        while(rEv<rEvents.Count)
        {
            float a=rEvents[rEv].awakeRate;
            if(r0>a){rEv++;continue;}
            if(r1<=a)break;
            RouteEvent(rEvents[rEv++]);
        }
    }
    // ExecEvent (vslot 0x2C8) for route events: what moves or flags the enemy. Bullets (8, 83) are Round1EnemyAttacks'.
    void RouteEvent(Round1EnemyWaves.ActionData e)
    {
        int t=e.eventType;
        if(t==14)Start(e.dotime>0?SpeedRamp(e):SpeedNow(e),speedJobs);
        else if(t==1 && e.dotime>0)rPause=Mathf.Max(rPause,e.dotime);
        else if(t==10 || t==11)Start(ObjFlag(e,t==10),jobs);
        else if(t==16){if(e.intValue1>=0 && e.intValue1<=12)nextEase=e.intValue1;}
        else if(t==8 || t==83)Bullets.Add(e);                                     // Round1EnemyAttacks cues it at this rate (Sk01 at 46%)
        // 2/3 Rotate: SplineMover.Progress rewrites the root's localRotation (_firstRotate * _splineRotate) every frame, so a
        // root tween does not hold [I]; X01-X03's Rotates turn a child model. Not modelled.
    }

    // ---- pawn hooks ----------------------------------------------------------------------------------------------
    void Pawn()
    {
        if(model=="Pf_Ene_Sg01")                                                   // Ene_Sg01.Progress 0x1CFEBD0
        {
            if(moveType==3 || moveType==5)
            {
                var p=PlayerXZ();float px=1080f/ViewHeight(0);                    // [I] _ScreenSize.y = 1080
                int dist=(int)(Mathf.Sqrt((pos.x-p.x)*(pos.x-p.x)+(pos.z-p.y)*(pos.z-p.y))*px);
                speed=Mathf.Min(Mathf.Max(dist,50),600)/600f*60+10;sgDone=true;  // minDistance 50, maxDistance 600, +minSpeed 10, *maxSpeed 60
            }
            else if(moveType==2 && sgDone && speed<20)speed=20;                   // outSpeed 20
        }
        if(SmClass(model) && !Ended)                                               // Ene_Sm01._progressMove 0x1D02B30
        {
            if(sm==null)
            {
                int sign=rng.U()<.5f?1:-1;
                float a=(sign*135+90+rng.Range(-15,15))*Mathf.Deg2Rad;             // _relectRandom 15
                sm=new Sm01State{dir=new Vector2(Mathf.Cos(a)*speed,Mathf.Sin(a)*speed)};
            }
            if(sm.state==1)
            {
                if(Entered)sm.state=2;
                else{sm.st+=DT;if(sm.st>=5){End("sm01-not-entered");return;}}
            }
            else if(sm.state==2)
            {
                var v=Viewport(pos);sm.life+=DT;
                if(sm.life<10)                                                     // _LifeTime 10
                {
                    if((v.y>=1 && sm.dir.y>0) || (v.y<=0 && sm.dir.y<0))sm.dir.y=-sm.dir.y;
                    if((v.x>=1 && sm.dir.x>0) || (v.x<=0 && sm.dir.x<0))sm.dir.x=-sm.dir.x;
                }
                if(!inPlay){End("sm01-left-play-area");return;}
            }
            pos.x+=sm.dir.x*DT;pos.z+=sm.dir.y*DT;
        }
    }

    // ---- class movers (evidence/movers/Ene_<Class>/SPEC.md) ---------------------------------------------------
    // Native classes whose own code moves the enemy instead of the stack: Ene_St01 and Ene_Ss01 (ActionMove before the
    // stack, whose only event is FinishWait) and Ene_So01 (attribute 0, no stack; _moveState after the empty mover step).
    // They own position and yaw, end by CallDisabled, and queue their class shots in Shots for Round1EnemyAttacks.
    public struct Shot { public string pattern,muzzle,toward;public float offset;public bool selfDir,cancel; }
    public readonly List<Shot> Shots=new List<Shot>();
    public static bool HasClassMover(string model)=>model=="Pf_Ene_St01" || model=="Pf_Ene_Ss01" || model=="Pf_Ene_So01" || model=="Pf_Ene_Mg01" || model=="Pf_Ene_Mk01"
        || model=="Pf_Ene_Si01" || model=="Pf_Ene_Mn01" || model=="Pf_Ene_Mm01" || model=="Pf_Ene_Ml01";
    public bool NoHitBullet { get; private set; }   // So01's dash: its colliders get NoHitBullet (player shots pass through)
    public float ModelPitch { get; private set; }    // Ss01's _modelTop flip (Turn state), degrees about local X
    readonly int indexValue;                          // spawn event indexValue (PawnEnemy._indexValue)
    int stState,ssState=0,soState;bool ssFired;
    float stNohit=1,stLife=8,stWait,stShot=1.5f,ssLength=300,ssAngle,ssTimer=8,soSpeed,soWait;
    Vector3 stMove=Vector3.forward,stWay;

    // [I] the player on the y = 0 sky plane (GetPlayerSkyPosition); every class spawn has y = 0.
    Vector3 PlayerSky(){var p=player!=null?player():Vector3.zero;p.y=0;return p;}
    static Vector3 Dir(Vector3 v){float l=v.magnitude;return l>1e-5f?v/l:Vector3.zero;}
    static float LookYaw(Vector3 v)=>PlaneYaw(v.x,v.z);                                     // LookRotation(v, up), y = 0
    // RotateTowards, pure yaw. [?] An exact 180 deg turn has no defined Slerp side; + as movers_sim.py.
    static float TurnYaw(float cur,float to,float max){float d=Norm180(to-cur);if(d==-180)d=180;return Mathf.Abs(d)<=max?to:cur+Mathf.Sign(d)*max;}
    // [I] HybridCollisions.IsGamePlayArea as "centre inside the viewport" (bounds not traced; specs' stand-in).
    static bool OnScreen(Vector3 p){var v=Viewport(p);return v.x>=0 && v.x<=1 && v.y>=0 && v.y<=1;}

    // Ene_St01.ActionMove 0x1D066C0: wait for FinishWait, cruise to beside the player, hover nose-on firing, leave after 8 s.
    void St01()
    {
        var pl=PlayerSky();
        if(stNohit>0){stNohit-=DT;if(stNohit<=0)objFlags&=~1;}
        switch(stState)
        {
            case 0:                                                                       // Start
                if(!finishWait)return;
                stMove=Dir(pos-pl)*150;yaw=LookYaw(stMove);stWay=Beside(pl,pos);stState=1;return;
            case 1:                                                                       // Blow (skipped when indexValue > 0)
            {
                float sp=indexValue>0?0:stMove.magnitude;stMove=Dir(stMove)*Mathf.Max(.01f,sp-300*DT);
                if(sp<=.02f){stNohit=0;objFlags&=~1;stState=2;}
                yaw=TurnYaw(yaw,LookYaw(pl-pos),720*DT);pos+=stMove*DT;return;
            }
            case 2:                                                                       // Move
            {
                var d=stWay-pos;float dist=d.magnitude;
                if(dist>=50){stMove+=Dir(d)*100*DT;if(stMove.magnitude>100)stMove=Dir(stMove)*100;}
                else{float s=stMove.magnitude*Mathf.Exp(-2*DT);stMove=Dir(stMove)*s;if(s<5){stWait=0;stState=3;}}
                yaw=TurnYaw(yaw,LookYaw(pl-pos),720*DT);pos+=stMove*DT;
                St01Shoot();stLife-=DT;if(stLife<=0)stState=4;return;
            }
            case 3:                                                                       // Wait (_WaitTime 0: one frame)
            {
                float s=stMove.magnitude*Mathf.Exp(-2*DT);stMove=Dir(stMove)*s;var p=pos+stMove*DT;
                yaw=TurnYaw(yaw,LookYaw(pl-p),720*DT);pos=p;St01Shoot();
                stWait-=DT;if(stWait<=0){stWay=Beside(pl,p);stState=2;}
                stLife-=DT;if(stLife<=0)stState=4;return;
            }
            case 4:                                                                       // Leave: away from the player, no cap
                stMove+=Dir(pos-pl)*100*DT;pos+=stMove*DT;yaw=TurnYaw(yaw,LookYaw(stMove),720*DT);
                if(!OnScreen(pos))stState=5;return;
            default: End("st01-exit");return;                                             // Exit: CallDisabled
        }
    }
    static Vector3 Beside(Vector3 pl,Vector3 p){var w=pl;w.x+=pl.x-p.x<0?50:-50;return w;}  // _KeepDistance on the enemy's side
    void St01Shoot(){stShot-=DT;if(stShot<=0){stShot+=1.5f;Shots.Add(new Shot{pattern="st01_fire1",muzzle="pf_ene_st01/ene_st01/muzzle"});}}

    // Ene_Ss01.ActionMove 0x1D05840: closes in on the live player from 300 to 50, circles it twice clockwise nose-on,
    // flips and fires shot06 once, backs out to 300 and is removed. Repeats are not RookEnemy children, so they overlap.
    void Ss01()
    {
        var pl=PlayerSky();
        switch(ssState)
        {
            case 0:ssState=1;break;                                                       // Starting
            case 1:ssLength-=DT*speed;if(ssLength<=50){ssState=2;ssLength=50;}break;      // Forward (sound 186 not wired)
            case 2:ssAngle+=-90*DT;ssTimer-=DT;if(ssTimer<=0){ssTimer=.2f;ssState=3;}break; // Rolling 8 s at -90 deg/s
            case 3:ssTimer-=DT;if(ssTimer<=0){ssState=4;ssTimer=0;}break;                 // StopFire
            case 4:                                                                       // Turn: Lerp(identity, 180 deg pitch)
            {
                ssTimer+=DT;float t=Mathf.Clamp01(ssTimer/.5f);ModelPitch=2*Mathf.Atan2(t,1-t)*Mathf.Rad2Deg;
                if(ssTimer>=.5f){ssTimer=.2f;ssState=5;}
                else if(ssTimer>=.5f/3 && !ssFired){Shots.Add(new Shot{pattern="shot06",muzzle="pf_ene_ss01/ene_ss01/muzzle",offset=ssAngle});ssFired=true;}
                break;
            }
            case 5:ssLength+=DT*speed;if(ssLength>=300)ssState=6;break;                   // Back
            default:End("ss01-done");return;                                              // Done: CallDisabled
        }
        pos=new Vector3(pl.x+TCos(ssAngle)*ssLength,pl.y,pl.z+TSin(ssAngle)*ssLength);yaw=-90-ssAngle;
    }

    // Ene_So01._moveState 0x1D035E0: 60 u/s along its heading, brake once on screen 0.35 s while turning to the player,
    // charge 1 s, then dash straight at 480 u/s^2 up to 240 u/s until it leaves the game screen area.
    void So01()
    {
        switch(soState)
        {
            case 0:soSpeed=60;soWait=0;soState=1;break;
            case 1:if(OnScreen(pos)){soWait+=DT;if(soWait>=.35f)soState=2;}break;
            case 2:soSpeed-=60*DT;if(soSpeed<=0){soWait=0;soSpeed=0;soState=3;}SoAim();break;
            case 3:soWait+=DT;if(soWait>=1){NoHitBullet=true;soState=4;}SoAim();break;
            case 4:soSpeed=Mathf.Min(soSpeed+480*DT,240);if(!inPlay)soState=5;break;
            default:End("so01-exit");return;
        }
        if(soSpeed>=0)pos+=Quaternion.Euler(0,yaw,0)*Vector3.forward*(soSpeed*DT);
    }
    void SoAim()=>yaw=TurnYaw(yaw,LookYaw(PlayerSky()-pos),2*DT*Mathf.Rad2Deg);           // RotateTowards 2 rad/s

    // Ene_Mg01.CustomMove 0x1DC5D70 (indexValue != 0), after the stack's SplineMove: every 3.5 s it brakes to a stop, swings
    // its nose to the live player, fires one mg01sp1_1way volley, swings back and speeds up again. It writes the speed
    // the spline reads next frame, and the rotation only while stopped (lookAt 1 otherwise).
    int mgMode=1;float mgTimer,mgFire,mgBase=-1,mgFrom,mgTo;bool mgAim;
    void Mg(int mode){mgMode=mode;mgTimer=0;}

    // Ene_Mp01.ActionMove 0x1CFCEF0, after the stack (which moves and spins it): 3 s of in-area time after it enters, a
    // mp01_fire1 laser from muzzle01 toward mzzle01t, then one every ~2 s (aim 0.5, fire 0.5, wait 1.0) until it leaves.
    // The EnemyTurret battery yaws to the player at 90 deg/s, 30 while a laser plays.
    // [I] The turret's retarget-and-lerp (_targetSec = |angle|/speed) is taken as RotateTowards at the roll speed.
    int mpSeq;float mpTime=3,mpRoll;bool mpStarted;
    public float TurretYaw { get; private set; }=float.NaN;
    void Mp01()
    {
        if(float.IsNaN(TurretYaw))TurretYaw=yaw;
        if(mpRoll>0)TurretYaw=TurnYaw(TurretYaw,LookYaw(PlayerSky()-pos),mpRoll*DT);
        if(mpSeq>=4)return;                                                               // NONE
        if(inPlay)mpTime-=DT;
        switch(mpSeq)
        {
            case 0:if(inPlay){mpStarted=true;mpRoll=90;mpSeq=1;}return;                   // START
            case 1:if(mpTime<=0){Shots.Add(new Shot{pattern="mp01_fire1",muzzle=MpMuzzle,toward=MpMuzzle+"/mzzle01t"});mpTime=.5f;mpSeq=2;}break; // AIM
            case 2:if(mpTime<=0){mpRoll=30;mpTime=1;mpSeq=3;}break;                     // FIRE
            case 3:if(mpTime<=0){mpTime=.5f;mpSeq=0;}break;                              // WAIT
        }
        if(!inPlay && mpStarted){Shots.Add(new Shot{cancel=true});mpStarted=false;mpSeq=4;}
    }
    const string MpMuzzle="pf_ene_mp01/ene_mp01_battery/muzzle01";

    // Ene_Mk01._move 0x1DC9CF0: nine straight RouteLUT legs (move_mk01a_01..09, b mirrored in x by indexValue 1) at
    // its ReStart speed, InOutSine along each, a 1 s stop after each; the legs sum to zero. RotatePlayer locks the nose on
    // the player, closing (t/1 s)^2 of the angle each frame after a retarget; mk01_fire1 along the muzzle every 2 s.
    // Its Si01 children (RookEnemy) are Round1EventStackGroups'.
    static readonly Vector2[] Mk01Legs={new Vector2(0,-120),new Vector2(-35,40),new Vector2(70,-20),new Vector2(-70,-20),
        new Vector2(70,0),new Vector2(-70,20),new Vector2(70,20),new Vector2(-35,-40),new Vector2(0,120)};
    int mkState,mkLeg=-1;float mkOffset,mkWait,mkRotT=1,mkRot,mkFire;Vector3 mkStart;
    void Mk01()
    {
        switch(mkState)
        {
            case 0:mkState=MkNext()?1:3;return;                                           // Entering: no turn or fire
            case 1:                                                                       // Forward
            {
                float len=MkLeg().magnitude;mkOffset=Mathf.Min(mkOffset+speed*DT,len);
                float u=InOutSine01(mkOffset/len);var leg=MkLeg();pos=mkStart+new Vector3(leg.x,0,leg.y)*u;
                MkRotate();
                if(mkOffset>=len){if(!MkNext())mkState=3;else{mkWait=0;mkState=2;}}
                MkFire();return;
            }
            case 2:mkWait+=DT;if(mkWait>=1){mkRotT=0;mkState=1;SiRetarget();}MkRotate();MkFire();return; // Wait, then retarget (SetChildTarget)
            default:End("mk01-done");return;                                              // Leaving: CallDisabled
        }
    }
    // EasingUtility.InOutSine01 0x1DE86F0, two mirrored halves through the 0.1 deg Cosf table.
    static float InOutSine01(float t)=>t<.5f?(1-TCos(2*t*90))*.5f:1-(1-TCos(2*(1-t)*90))*.5f;
    Vector2 MkLeg(){var l=Mk01Legs[mkLeg];return indexValue==1?new Vector2(-l.x,l.y):l;}
    bool MkNext(){if(++mkLeg>=Mk01Legs.Length)return false;mkOffset=0;mkStart=pos;return true;}
    void MkRotate()
    {
        mkRotT=Mathf.Clamp(mkRotT+DT,0,1);float k=mkRotT*mkRotT;var d=PlayerSky()-pos;
        float a=Mathf.Repeat(Mathf.Atan2(d.x,d.z)*Mathf.Rad2Deg-mkRot,360);if(a>180)a-=360;
        mkRot+=Mathf.Clamp01(k)*a;yaw=mkRot;
    }
    void MkFire(){mkFire-=DT;if(mkFire<=0){mkFire+=2;Shots.Add(new Shot{pattern="mk01_fire1",muzzle="pf_ene_mk01/ani_mk01_body/mk01_body/ani_mk01_hip/muzzle",selfDir=true});}}
    static float EaseInOut(float t){float t2=2*t;return t2<1?.5f*t2*t2:-.5f*((t2-1)*(t2-3)-1);}   // EasingUtility.EaseInOut(0,1,t)
    static float SlerpYaw(float a,float b,float t)=>a+Norm180(b-a)*t;
    void Mg01()
    {
        if(mgBase<0)mgBase=speed;                                                         // ReStart: _baseSpeed = placement speed
        mgTimer+=DT;
        switch(mgMode)
        {
            case 1:if(mgTimer>=3.5f)Mg(2);break;                                          // Move
            case 2:{float r=Mathf.Clamp01(mgTimer/.5f);speed=mgBase*(1-r*r);if(mgTimer>=.5f){Mg(3);mgAim=false;}break;} // Brake
            case 3:                                                                       // Homing (tracks the player live)
                if(!mgAim){mgAim=true;mgFrom=yaw;}
                mgTo=LookYaw(PlayerSky()-pos);yaw=SlerpYaw(mgFrom,mgTo,EaseInOut(Mathf.Clamp01(mgTimer/.5f)));
                if(mgTimer>=.5f){Mg(4);mgFire=0;}break;
            case 4:                                                                       // Shot: one volley, one frame
                yaw=mgTo;mgFire-=DT;if(mgFire<=0){mgFire+=1;Shots.Add(new Shot{pattern="mg01sp1_1way",muzzle="pf_ene_mg01/muzzle01"});}
                if(mgTimer>=0)Mg(5);break;
            case 5:yaw=SlerpYaw(mgTo,mgFrom,EaseInOut(Mathf.Clamp01(mgTimer/.5f)));if(mgTimer>=.5f)Mg(6);break; // Turn back
            case 6:{float r=Mathf.Clamp01(mgTimer/.5f);speed=mgBase*r*r;if(mgTimer>=.5f)Mg(1);break;}        // Return
        }
    }
}
