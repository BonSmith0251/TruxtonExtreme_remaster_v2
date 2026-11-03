using System;
using System.Collections.Generic;
using UnityEngine;

// Original templates/selectors/muzzle paths; scheduling follows the remaster clock.
// Specialized native route-task gates and global rank/speed remain adaptations.
public sealed class Round1EnemyAttacks : MonoBehaviour
{
    [Serializable] public class Pattern
    {
        public string name,bulletName;
        public int bulletType,nRapidCount,nRapidWaySwitch,isTarget,isRapidTarget,isSelfDir,isReverse,nRandomArc,nLimitArc,isMuzzleEffect;
        public float nArc,nStartArc,nSpeed,nIrradiation,nRapidDistance,nRapidInflation,nRapidRotation,nRapidArcSwitch;
    }
    [Serializable] public class Choice { public int pmode;public string _btName;public float _rate; }
    [Serializable] public class Selector { public string name;public Choice[] choices; }
    [Serializable] public class Pack { public string name;public string[] paths; }
    [Serializable] public class Model { public string name;public Pack[] packs; }
    [Serializable] public class Speed { public string _bulletName;public float _aSecondPass; }
    [Serializable] public class Laser { public string bulletName;public float charge,width,collisionWidth,dissolve; }
    [Serializable] public class Data { public int version;public string stage;public Speed[] speeds;public float[] aimSteps;public Pattern[] patterns;public Selector[] selectors;public Model[] models;public Laser[] lasers;public float laserCharge,laserWidth,laserCollisionWidth,laserDissolve; }
    class Shooter { public Round1Combat.Target target;public int id,fired;public float born,scale;public bool rangeFire,force;public readonly List<Cue> cues=new List<Cue>(); }
    class Cue { public Round1EnemyWaves.ActionData data;public float next;public int iteration;public bool entered;public float firstDelay,interval;public Transform aimBase;public Transform[] muzzles; }
    class Burst { public Shooter shooter;public Pattern pattern;public Transform muzzle,aimBase;public bool selfDir;public Vector2 aim;public float next,offset;public int index; }
    class Beam { public Shooter shooter;public string bullet;public Transform muzzle,toward;public Vector2 direction;public float born,duration,charge,width,collisionWidth,dissolve;public LineRenderer line;public bool energized;public GameObject glow; }
    // InGameResident.SetPlayMode hands TXEResident's play mode to every BulletTemplateSelecter (Story 1, Arcade 2/3,
    // Team 10, Tutorial 100); a selector without that pmode uses pmode 0. 0 therefore reproduces Arcade, 1 Story.
    public const int StorySelectorMode=1,ArcadeSelectorMode=0;
    public int selectorMode=StorySelectorMode;
    // InGameManager.UpdateParamsByPlayMode: Story A sets gameBulletArea=BulletArea_Story and _bulletDistanceMax=200
    // (B 190, C 180); Arcade uses BulletArea_Arcade and 150. IsGameBulletAreaWorld tests the game camera's viewport
    // as x>=0.05, x<0.95, y>=0.05, y<0.05+h. IsFireDistance measures in the 1920x1080 virtual screen.
    public static readonly Rect StoryBulletArea=new Rect(.05f,.05f,.9f,.85f),ArcadeBulletArea=new Rect(.05f,.05f,.9f,.95f);
    public const float StoryABulletDistance=200,ArcadeBulletDistance=150,VirtualScreenWidth=1920,VirtualScreenHeight=1080;
    // EnemyData.isRangeFire (enemy database) enables EnemyMover._isRangeFireLimit, the only movers IsFireDistance gates.
    static readonly HashSet<string> RangeFire=new HashSet<string>{"Bg02_Ship01","BG08_battery01a","BG08_battery02a","BMa01","BSa01","BSb01","BSc01","BSd01","La01","Sa01","Sb01","Sc01","Sd01","Sd02","Se01","Sf01","Sg01","Sh01","Si01","Sj01","Sk01","Sm01","Sm02","Sn01","So01","Sp01","St01","Su01","TSa01","TSa01a"};
    public static bool IsRangeFire(string model)=>model!=null && RangeFire.Contains(model.StartsWith("Pf_Ene_")?model.Substring(7):model);
    bool Story=>selectorMode==StorySelectorMode;
    public Rect BulletArea=>Story?StoryBulletArea:ArcadeBulletArea;
    public float BulletDistanceMax=>Story?StoryABulletDistance:ArcadeBulletDistance;
    public float bulletSpeedScale=1; // Neutral original difficulty; never a shared absolute bullet speed.
    public Data Source { get; private set; }
    public int FiredProjectiles { get; private set; }
    public int FiredLasers { get; private set; }
    public int MissingMuzzles { get; private set; }
    public int MuzzleFlashes { get; private set; }
    public int LaserGlows { get {int n=0;foreach(var b in beams)if(b.glow && b.glow.activeSelf)n++;return n;} }
    // InGameBullet._colorType of each bullet: ShortCutEffect.GetMuzzleEffectCode gives pf_eff_e_muzzle01 (orange) for
    // colour 1 and pf_eff_e_muzzle02 (purple) for colour 2, played when a pattern has isMuzzleEffect.
    static readonly Dictionary<string,int> BulletColors=new Dictionary<string,int>{{"enemybullet001",1},{"enemybullet002",1},{"enemybullet003",1},{"enemybullet004",2},{"enemybullet005",2},{"enemybullet006",1}};
    // enemylaser000: pf_eff_e_laser_energy01 gathers at the muzzle as the laser charges, pf_eff_e_laser_muzzle01 (looping)
    // burns there while it fires; the beam itself is the sp_eff_e_laser01 strip in its own colours.
    const string LaserEnergy="pf_eff_e_laser_energy01",LaserMuzzle="pf_eff_e_laser_muzzle01";
    readonly Stack<GameObject> glowPool=new Stack<GameObject>();
    public int PendingBursts=>bursts.Count;
    public int ActiveLasers=>beams.Count;
    public bool Ready=>Source!=null;
    readonly Dictionary<string,float> speeds=new Dictionary<string,float>();
    readonly Dictionary<string,Pattern> patterns=new Dictionary<string,Pattern>();
    readonly Dictionary<string,Selector> selectors=new Dictionary<string,Selector>();
    readonly Dictionary<string,GameObject> bullets=new Dictionary<string,GameObject>();
    readonly List<Shooter> shooters=new List<Shooter>();
    readonly List<Burst> bursts=new List<Burst>();
    readonly List<Beam> beams=new List<Beam>();
    readonly Stack<LineRenderer> beamPool=new Stack<LineRenderer>();
    Round1Combat combat;Round1EnemyAttackLibrary library;Material beamMaterial;
    MaterialPropertyBlock beamTint;
    float clock;
    public void Initialize(Round1Combat owner)
    {
        if(Ready)return;combat=owner;beamTint=new MaterialPropertyBlock();
        library=Resources.Load<Round1EnemyAttackLibrary>("Truxton/EnemyAttackLibrary");
        if(!library || !library.source){Debug.LogError("Extracted enemy attack library is missing.",this);return;}
        Source=JsonUtility.FromJson<Data>(library.source.text);
        foreach(var speed in Source.speeds)speeds.Add(speed._bulletName,speed._aSecondPass);
        foreach(var p in Source.patterns)patterns.Add(p.name,p);
        foreach(var s in Source.selectors)selectors.Add(s.name,s);
        foreach(var b in library.bullets)bullets.Add(b.name,b.prefab);
        beamMaterial=new Material(Shader.Find("Universal Render Pipeline/Unlit"));
        beamMaterial.SetColor("_BaseColor",Color.white);
        beamMaterial.SetFloat("_Surface",1);beamMaterial.SetFloat("_SrcBlend",5);beamMaterial.SetFloat("_DstBlend",1);beamMaterial.SetFloat("_ZWrite",0);beamMaterial.EnableKeyword("_SURFACE_TYPE_TRANSPARENT");beamMaterial.renderQueue=3000;
        if(library.laserMaterial && library.laserMaterial.HasProperty("_BaseMap"))beamMaterial.SetTexture("_BaseMap",library.laserMaterial.GetTexture("_BaseMap"));
    }
    public Pattern Resolve(string name,float selection=0.5f)
    {
        if(string.IsNullOrEmpty(name))return null;
        if(selectors.TryGetValue(name,out var s))name=Select(s,selectorMode,selection);
        return patterns.TryGetValue(name??"",out var p)?p:null;
    }
    public static string Select(Selector s,int mode,float selection)
    {
        var choices=Array.FindAll(s.choices,x=>x.pmode==mode);
        if(choices.Length==0)choices=Array.FindAll(s.choices,x=>x.pmode==0);
        float remaining=Mathf.Clamp01(selection);
        foreach(var c in choices){remaining-=c._rate;if(remaining<=0)return c._btName;}
        return choices.Length==1?choices[0]._btName:"";
    }
    public float ProjectileSpeed(Pattern p,int rapidIndex=0)
    {
        float basis=speeds.TryGetValue(p.bulletName,out var value)?value:70; // Native fallback.
        return basis/200f*p.nSpeed*Mathf.Clamp(1+rapidIndex*p.nRapidInflation,.01f,10)*Mathf.Max(0,bulletSpeedScale);
    }
    public static float FirstDelay(Round1EnemyWaves.ActionData e,float random01=0)
    {
        float first=e.value1+Mathf.Clamp01(random01)*Mathf.Max(0,e.randomWait);
        return Mathf.Max(0,first>0?first:e.repeatCount<=0?0:e.value0);
    }
    public static float RepeatInterval(Round1EnemyWaves.ActionData e)=>Mathf.Max(1f/60,Mathf.Max(0,e.repeatDelay)+Mathf.Max(0,e.value0));
    public float AimAngle(Pattern p,Vector2 aim)
    {
        // GetTargetBulletArc measures the clockwise offset from down; GetLimitArc
        // rounds that offset to the authored step (45 degrees on Me01's twin guns).
        float offset=Mathf.DeltaAngle(270,Mathf.Atan2(aim.y,aim.x)*Mathf.Rad2Deg);
        if(p.nLimitArc>0 && p.nLimitArc<Source.aimSteps.Length)
        {float step=Source.aimSteps[p.nLimitArc];offset=Mathf.Round(offset/step)*step;}
        return p.nStartArc+offset;
    }
    public void Register(Round1Combat.Target target,Round1EnemyWaves.Definition d,float born,float scale)
    {
        if(!Ready)return;
        var s=new Shooter{target=target,id=target.id,born=born,scale=Mathf.Max(.001f,scale),rangeFire=IsRangeFire(d.model)};
        var model=Array.Find(Source.models,x=>x.name==d.model);
        float cursor=0,rotateEnd=0,routeEnd=0,speed=d.placements[0].moveSpeed;
        foreach(var e in d.events)
        {
            if(e.eventType==1 || e.eventType==20){cursor+=Mathf.Max(0,e.dotime);continue;}
            if(e.eventType==2){rotateEnd=Mathf.Max(rotateEnd,cursor+e.value0+e.dotime);continue;}
            if(e.eventType==14){speed=Mathf.Max(1,e.value0);continue;}
            if(e.eventType==15){routeEnd=cursor+e.value0+RouteDuration(e.stringValue,speed);continue;}
            if(e.eventType==80){if(e.intValue1==0 || (e.intValue1&1)!=0)cursor=Mathf.Max(cursor,rotateEnd);if(e.intValue1==0 || (e.intValue1&(64|256))!=0)cursor=Mathf.Max(cursor,routeEnd);continue;}
            if(e.eventType!=8 && e.eventType!=83)continue;
            float progressTime=d.routes.Length>0?RouteDuration(d.routes[0],speed):Mathf.Max(0,routeEnd-cursor);
            Add(e,cursor+Mathf.Clamp01(e.awakeRate)*progressTime);
        }
        if(d.model=="Pf_Ene_Md01" && d.events.Length==0)
        {
            // Its firing templates are native-generated; cadence is a remaster adaptation.
            Add(new Round1EnemyWaves.ActionData{eventType=83,stringValue="md01_fire1_sel",repeatCount=999,repeatDelay=1.8f},1.2f);
            Add(new Round1EnemyWaves.ActionData{eventType=83,stringValue="md01_fire3_sel",repeatCount=999,repeatDelay=3.6f},2.4f);
        }
        shooters.Add(s);
        void Add(Round1EnemyWaves.ActionData e,float start)
        {
            var list=new List<Transform>();var pack=model?.packs==null?null:Array.Find(model.packs,p=>p.name==e.nameValue);
            string[] paths=pack!=null?pack.paths:new[]{e.nameValue??""};
            foreach(string path in paths)
            {
                var t=path.Length==0?target.visual.transform:target.visual.transform.Find(path);
                if(t)list.Add(t);else{MissingMuzzles++;Debug.LogWarning("Missing source muzzle: "+d.name+" / "+path,this);}
            }
            Transform aimBase=string.IsNullOrEmpty(e.subnameValue)?null:target.visual.transform.Find(e.subnameValue);
            if(!string.IsNullOrEmpty(e.subnameValue) && !aimBase){MissingMuzzles++;Debug.LogWarning("Missing source aim reference: "+e.subnameValue,this);}
            s.cues.Add(new Cue{data=e,next=start,firstDelay=FirstDelay(e,Chance(s.id,0,e.stringValue+"/wait")/100),interval=RepeatInterval(e),aimBase=aimBase,muzzles=list.ToArray()});
        }
    }
    // One Bullet event (RouteEventType 8) fired now, for a mover whose own event program times its shots (a ground enemy
    // that opens and closes around them, Round1GroundEnemies). Same muzzle, on-screen and selector rules as a cue.
    public void Fire(Round1Combat.Target target,Round1EnemyWaves.ActionData e,float now)
    {
        if(!Ready || combat.weapon.BombActive)return;
        var s=shooters.Find(x=>x.target==target && Alive(x));if(s==null)return;
        int attempt=s.fired++;
        var p=Resolve(e.stringValue,Chance(s.id,attempt,e.stringValue+"/selector")/100);if(p==null)return;
        var muzzle=string.IsNullOrEmpty(e.nameValue)?target.visual.transform:target.visual.transform.Find(e.nameValue);
        if(!muzzle){MissingMuzzles++;Debug.LogWarning("Missing source muzzle: "+e.nameValue,this);return;}
        if(Onscreen(Position(muzzle)) && (!s.rangeFire || IsFireDistance(Position(muzzle))))QueuePattern(s,p,muzzle,now,null,e.flag0!=0);
    }
    float RouteDuration(string name,float speed)
    {
        var routes=combat.sourceWaves?.Source?.routes;if(routes==null)return 0;
        return (Array.Find(routes,r=>r.name==name)?.length??Round1Md01Motion.RouteLength(name))/Mathf.Max(1,speed);
    }
    static bool Alive(Shooter s)=>s.target.active && s.target.id==s.id;
    bool Onscreen(Vector2 p){var a=BulletArea;return p.x>=a.x && p.x<a.xMax && p.y>=a.y && p.y<a.yMax;}
    // EnemyMover.IsBulletFire: a range-limited mover holds fire while its muzzle is within _bulletDistanceMax.
    public bool IsFireDistance(Vector2 muzzle)
    {
        var d=combat.weapon.player.viewportPosition-muzzle;
        return new Vector2(d.x*VirtualScreenWidth,d.y*VirtualScreenHeight).magnitude>BulletDistanceMax;
    }
    public void Step(float now)
    {
        if(!Ready || !combat.weapon.SimulationRunning)return;
        clock=now;
        for(int i=shooters.Count-1;i>=0;i--)
        {
            var s=shooters[i];if(!Alive(s)){shooters.RemoveAt(i);continue;}
            float age=(now-s.born)*s.scale;
            foreach(var cue in s.cues)
            {
                if(!cue.entered)
                {
                    if(age+.00001f<cue.next)continue;
                    // Native IsEntryFireArea waits for the muzzle before starting the first delay.
                    bool visible=false;foreach(var muzzle in cue.muzzles)if(muzzle && Onscreen(Position(muzzle))){visible=true;break;}
                    if(!visible){cue.next=age;continue;}
                    cue.entered=true;cue.next=Mathf.Max(cue.next,age)+cue.firstDelay;
                }
                int catchup=0;
                while(age+.00001f>=cue.next && cue.iteration<=cue.data.repeatCount && catchup++<8)
                {
                    float due=cue.next;int attempt=cue.iteration++;
                    cue.next+=cue.interval;
                    if(age-due>.25f || combat.weapon.BombActive)continue;
                    if(cue.data.randomFire>Chance(s.id,attempt,cue.data.stringValue)*.999f && !(cue.data.repeatCount<=0 && cue.firstDelay<=0))continue;
                    var p=Resolve(cue.data.stringValue,Chance(s.id,attempt,cue.data.stringValue+"/selector")/100);if(p==null)continue;
                    foreach(var muzzle in cue.muzzles)if(muzzle && Onscreen(Position(muzzle)) && (!s.rangeFire || IsFireDistance(Position(muzzle))))QueuePattern(s,p,muzzle,s.born+due/s.scale,cue.aimBase,cue.data.flag0!=0);
                }
            }
        }
        for(int i=bursts.Count-1;i>=0;i--)
        {
            var b=bursts[i];if(!Alive(b.shooter) || combat.weapon.BombActive){bursts.RemoveAt(i);continue;}
            int count=0;
            while(now+.00001f>=b.next && b.index<Mathf.Max(1,b.pattern.nRapidCount) && count++<16)
            {
                if(b.muzzle && (b.shooter.force || Onscreen(Position(b.muzzle))))Emit(b);
                b.index++;b.next+=Mathf.Max(.01f,b.pattern.nRapidDistance)/b.shooter.scale;
            }
            if(b.index>=Mathf.Max(1,b.pattern.nRapidCount))bursts.RemoveAt(i);
        }
        UpdateBeams(now);
    }
    static float Chance(int id,int attempt,string name)
    {
        unchecked{uint h=(uint)(id*7919+attempt*104729+3101);foreach(char c in name)h=(h^c)*16777619;h^=h>>16;return (h%10000)/100f;}
    }
    Vector2 Position(Transform muzzle)=>combat.weapon.player.stageCamera.WorldToViewportPoint(muzzle.position);
    Vector2 Aim(Vector2 from){var v=combat.weapon.player.viewportPosition-from;v.x*=combat.weapon.player.stageCamera.aspect;return v.sqrMagnitude>.000001f?v.normalized:Vector2.down;}
    void QueuePattern(Shooter s,Pattern p,Transform muzzle,float now,Transform aimBase=null,bool selfDir=false,float offset=0,Transform toward=null)
    {
        if(!muzzle || p==null)return;
        var b=new Burst{shooter=s,pattern=p,muzzle=muzzle,aimBase=aimBase,selfDir=selfDir || p.isSelfDir!=0,next=now,offset=offset,aim=Aim(Position(aimBase?aimBase:muzzle))};
        if(p.nIrradiation>0)
        {
            var line=beamPool.Count>0?beamPool.Pop():CreateBeam();line.enabled=true;
            var spec=Source.lasers==null?null:Array.Find(Source.lasers,x=>x.bulletName==p.bulletName);
            beams.Add(new Beam{shooter=s,bullet=p.bulletName,muzzle=muzzle,toward=toward,direction=toward?BeamDirection(muzzle,toward):Direction(b),born=now,duration=p.nIrradiation,line=line,
                charge=spec?.charge??Source.laserCharge,width=spec?.width??Source.laserWidth,collisionWidth=spec?.collisionWidth??Source.laserCollisionWidth,dissolve=spec?.dissolve??Source.laserDissolve});FiredLasers++;
            Round1TrackCapture.Active?.Fire(s.target.id,now,"laser",muzzle.name);
        }
        else bursts.Add(b);
    }
    // Boss fire (Ene_BosBase _callBT / _callBTLaser): one shooter per boss target, _isForceFire so the bullet area and
    // range limit do not gate it, an offset angle on the template, and a beam aimed from one muzzle toward another.
    readonly Dictionary<int,Shooter> bossShooters=new Dictionary<int,Shooter>();
    public void FireBoss(Round1Combat.Target target,string name,Transform muzzle,float offset=0,Transform toward=null)
    {
        if(!Ready || target==null)return;
        if(!bossShooters.TryGetValue(target.id,out var s) || !Alive(s)){s=new Shooter{target=target,id=target.id,scale=1,force=true};bossShooters[target.id]=s;}
        var p=Resolve(name);if(p==null){Debug.LogWarning("Missing boss bullet template "+name,this);return;}
        QueuePattern(s,p,muzzle,clock,null,false,offset,toward);
    }
    // _laserCancelFlag: hot beams of this boss stop now and dissolve.
    public void CancelBeams(Round1Combat.Target target)
    {
        foreach(var beam in beams)if(beam.shooter.target==target){float age=(clock-beam.born)*beam.shooter.scale;beam.duration=Mathf.Min(beam.duration,Mathf.Max(0,age-beam.charge));}
    }
    public int BeamCount(Round1Combat.Target target){int n=0;foreach(var beam in beams)if(beam.shooter.target==target && beam.line.enabled)n++;return n;}
    Vector2 BeamDirection(Transform from,Transform to)
    {var d=Position(to)-Position(from);d.x*=combat.weapon.player.stageCamera.aspect;return d.sqrMagnitude>1e-10f?d.normalized:Vector2.down;}
    public void FirePatternForCheck(Round1Combat.Target target,string name,string path="",string aimPath="")
    {var s=new Shooter{target=target,id=target.id,scale=1};QueuePattern(s,Resolve(name),path.Length==0?target.visual.transform:target.visual.transform.Find(path),clock,aimPath.Length==0?null:target.visual.transform.Find(aimPath));}
    Vector2 Direction(Burst b)
    {
        var p=b.pattern;float angle=p.nStartArc;
        if((p.isTarget!=0 || b.index>0 && p.isRapidTarget!=0) && !b.selfDir)
        {
            var aim=b.index>0 && p.isRapidTarget!=0?Aim(Position(b.aimBase?b.aimBase:b.muzzle)):b.aim;
            angle=AimAngle(p,aim);
        }
        else if(b.selfDir)
        {
            var cam=combat.weapon.player.stageCamera.transform;var forward=b.muzzle.forward;
            angle+=Mathf.Atan2(Vector3.Dot(forward,cam.up),Vector3.Dot(forward,cam.right))*Mathf.Rad2Deg+90;
        }
        angle+=b.offset+b.index*p.nRapidRotation;
        // isReverse alternates curve handedness; it does not reverse straight shots.
        angle+=(Chance(b.shooter.id,b.index,p.name+"/arc")/100-.5f)*p.nRandomArc;
        return new Vector2(Mathf.Cos(angle*Mathf.Deg2Rad),Mathf.Sin(angle*Mathf.Deg2Rad));
    }
    public static float[] SpreadAngles(Pattern p,int burst=0)
    {
        int ways=Mathf.Max(1,burst%2==1 && p.nRapidWaySwitch>0?p.nRapidWaySwitch:p.bulletType);
        float arc=burst%2==1 && p.nRapidWaySwitch>0?p.nRapidArcSwitch:p.nArc;
        var result=new float[ways];for(int i=0;i<ways;i++)result[i]=ways==1?0:-arc*.5f+i*arc/(p.nArc>=360?ways:ways-1);return result;
    }
    void Emit(Burst b)
    {
        var p=b.pattern;Vector2 origin=Position(b.muzzle),axis=Direction(b);Round1Sound.EnemyFire(p.name,p.bulletName,b.index);
        if(p.isMuzzleEffect!=0 && BulletColors.TryGetValue(p.bulletName,out int color) && combat.effects.Play("pf_eff_e_muzzle0"+color,origin,EffectScale(b.shooter),combat.weapon.player.playback.elapsed))MuzzleFlashes++;
        if(!bullets.TryGetValue(p.bulletName,out var prefab))throw new InvalidOperationException("Unresolved enemy bullet "+p.bulletName);
        foreach(float offset in SpreadAngles(p,b.index))
        {
            float r=offset*Mathf.Deg2Rad;var v=new Vector2(axis.x*Mathf.Cos(r)-axis.y*Mathf.Sin(r),axis.x*Mathf.Sin(r)+axis.y*Mathf.Cos(r));
            if(combat.SpawnSourceHostile(origin,v*ProjectileSpeed(p,b.index),prefab,b.shooter.target.id)){FiredProjectiles++;Round1TrackCapture.Active?.Fire(b.shooter.target.id,b.next,"fire",b.muzzle.name);}
        }
    }
    LineRenderer CreateBeam()
    {
        var go=new GameObject("Enemy laser");go.transform.SetParent(transform);
        var line=go.AddComponent<LineRenderer>();line.sharedMaterial=beamMaterial;line.useWorldSpace=true;line.positionCount=2;line.numCapVertices=4;return line;
    }
    void UpdateBeams(float now)
    {
        foreach(var beam in beams)
        {
            float age=(now-beam.born)*beam.shooter.scale;
            bool live=Alive(beam.shooter) && !combat.weapon.BombActive && age<=beam.charge+beam.duration+beam.dissolve;
            Round1Sound.EnemyLaser(beam,beam.bullet,age,beam.charge,beam.duration,live);
            if(!live){beam.line.enabled=false;ReleaseGlow(beam);continue;}
            if(beam.toward)beam.direction=BeamDirection(beam.muzzle,beam.toward);
            Vector2 from=Position(beam.muzzle),to=from+new Vector2(beam.direction.x/combat.weapon.player.stageCamera.aspect,beam.direction.y)*2;
            bool hot=age>=beam.charge && age<beam.charge+beam.duration;
            if(!beam.energized){beam.energized=true;combat.effects.Play(LaserEnergy,from,EffectScale(beam.shooter),now);}
            float fade=age>beam.charge+beam.duration?Mathf.Clamp01(1-(age-beam.charge-beam.duration)/Mathf.Max(.001f,beam.dissolve)):1;
            var player=combat.weapon.player;var cam=player.stageCamera;
            Vector3 a=player.WorldPoint(from),b=player.WorldPoint(to);
            beam.line.SetPosition(0,cam.transform.position+(a-cam.transform.position)*.8f);beam.line.SetPosition(1,cam.transform.position+(b-cam.transform.position)*.8f);
            float worldHeight=Vector3.Distance(player.WorldPoint(Vector2.zero),player.WorldPoint(Vector2.up));
            beam.line.startWidth=beam.line.endWidth=beam.width/200f*worldHeight*.8f*(hot?1:.17f)*fade;
            beam.line.startColor=beam.line.endColor=Color.white;
            beamTint.SetColor("_BaseColor",new Color(1,1,1,(hot?1:.45f)*fade));beam.line.SetPropertyBlock(beamTint);
            if(hot)PlaceGlow(beam,beam.line.GetPosition(0));else ReleaseGlow(beam);
            // TakeHit clears hostile fire, including this list, during a respawn.
            if(hot && combat.SegmentDistance(player.viewportPosition,from,to)<beam.collisionWidth/200*.5f+.008f && combat.weapon.TakeHit())return;
        }
        for(int i=beams.Count-1;i>=0;i--)if(!beams[i].line.enabled){beamPool.Push(beams[i].line);beams.RemoveAt(i);}
    }
    public void CopyPilotHazards(List<Round1Autopilot.Hazard> output)
    {
        if(!Ready || !combat || combat.weapon.BombActive)return;
        float now=combat.weapon.player.playback.elapsed,aspect=combat.weapon.player.stageCamera.aspect;
        foreach(var beam in beams)
        {
            if(!Alive(beam.shooter))continue;
            float scale=Mathf.Max(.001f,beam.shooter.scale),age=(now-beam.born)*scale;
            float ends=(beam.charge+beam.duration-age)/scale;
            if(ends<0)continue;
            Vector2 from=Position(beam.muzzle);from.x*=aspect;
            output.Add(new Round1Autopilot.Hazard{beam=true,from=from,to=from+beam.direction*2,
                radius=beam.collisionWidth/200*.5f+.008f,starts=Mathf.Max(0,(beam.charge-age)/scale),ends=ends});
        }
    }
    public void Clear()
    {
        shooters.Clear();bossShooters.Clear();bursts.Clear();foreach(var b in beams){b.line.enabled=false;ReleaseGlow(b);beamPool.Push(b.line);}beams.Clear();
        FiredProjectiles=FiredLasers=MissingMuzzles=0;
    }
    public void ClearFire(){bursts.Clear();foreach(var b in beams){b.line.enabled=false;ReleaseGlow(b);beamPool.Push(b.line);}beams.Clear();}
    float EffectScale(Shooter s)=>s.target!=null && s.target.sourceScale>0?s.target.sourceScale:Vector3.Distance(combat.weapon.player.WorldPoint(Vector2.zero),combat.weapon.player.WorldPoint(Vector2.up))/200;
    void PlaceGlow(Beam beam,Vector3 at)
    {
        if(!beam.glow)
        {
            var prefab=combat.effects.Prefab(LaserMuzzle);if(!prefab)return;
            beam.glow=glowPool.Count>0?glowPool.Pop():Instantiate(prefab,transform);beam.glow.SetActive(true);
            beam.glow.transform.localScale=Vector3.one*EffectScale(beam.shooter);
            foreach(var ps in beam.glow.GetComponentsInChildren<ParticleSystem>(true)){ps.Clear(true);ps.Play(true);}
        }
        beam.glow.transform.SetPositionAndRotation(at,combat.weapon.player.stageCamera.transform.rotation*Quaternion.Euler(-90,0,0));
    }
    void ReleaseGlow(Beam beam){if(!beam.glow)return;beam.glow.SetActive(false);glowPool.Push(beam.glow);beam.glow=null;}
    void OnDestroy(){if(beamMaterial)Destroy(beamMaterial);}
}
