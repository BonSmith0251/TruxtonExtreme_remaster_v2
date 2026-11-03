using System;
using System.Collections.Generic;
using UnityEngine;

// Boss encounter for the stages other than BG03 (whose Ene_Bos03 is Round1Boss). The encounter frame is the original
// data: the stage's AreaEntry windows (BGxx_BOSSST starts the warning, the boss EnemyData spawns at its schedule time,
// BGxx_BOSSLP is the background section looped while the boss lives), the boss EnemyData rest position, its original
// prefab, EnemyDatabase HP (body and part rows) and its PawnEnemy collision models per part. BG08 has two forms
// (Ene_Bos08A, then Ene_Bos08B) fought in order.
//
// This class is the shared Ene_BosBase layer: spawn, parts with live hit circles (they follow the animated part
// transforms), vulnerability windows, the boss clock, HP state (hpRateRanges), firing the boss's own bullet templates
// from its muzzle transforms, summons, and the shared destruction sequence (5.5 s: sink 150 away from the camera while
// turning, small bombs from 0.2 s shrinking x0.9, the boss dead effect at 3.5 s). Each boss's own state machine is a
// subclass written from its native spec (evidence/bosses/BosNN/SPEC.md; Assets/Scripts/Runtime/Stage/Bosses/BossNN.cs). With
// no subclass the fight is generic: hold the rest position with a slow sway and fire the boss's templates in turn.
public class StageBoss : RoundBoss
{
    [Serializable] public class Form
    {
        public string model,definition;public GameObject prefab;public float spawnTime,health=100000;public Vector3 rest;public Vector3 rotate;
    }
    // A collision part of the boss (PawnEnemy._collisions grouped by PartsList entry). Body parts (the root entry, or
    // entries flagged as part of the body, or without a database row) hit the body target; the others are their own
    // breakable targets with their database HP.
    public class Part
    {
        public string name;public int index;public bool body,broken,enabled=true;public Transform root;public Round1Combat.Target target;
        public StageCombatData.Row row;
        internal readonly List<LiveCircle> circles=new List<LiveCircle>();
        public float HealthRatio=>target==null?(broken?0:1):Mathf.Clamp01(target.health/Mathf.Max(1,target.maxHealth));
    }
    internal struct LiveCircle {public Transform transform;public Vector3 local;public float radius,scaleAtSpawn;}
    public class Minion {public Round1Combat.Target target;public Vector3 position,velocity;public float age;public Quaternion facing=Quaternion.identity;public Action<Minion,float> step;public bool Alive=>target!=null&&target.active;}

    public Round1Combat combat;
    public Form[] forms=new Form[0];
    public string caption="BOSS";
    public float warningTime=-1,loopStart=-1,loopEnd=-1;
    public float entryDuration=3,defeatDuration=5.5f,attackInterval=2.2f,swayAmplitude=25,swayPeriod=8;

    public override bool StageCleared=>State==EncounterState.Cleared;
    public override bool SuppressesWaves=>StageCleared||(warningTime>=0&&StageTime>=warningTime)||State!=EncounterState.Waiting;
    public override bool ShowGauge=>State==EncounterState.Warning||State==EncounterState.Entering||State==EncounterState.Fighting||State==EncounterState.Defeating;
    public override bool HoldsStage=>!StageCleared&&warningTime>=0&&StageTime>=warningTime;
    public override float HealthRatio=>Target==null?1:Mathf.Clamp01(Target.health/Mathf.Max(1,Target.maxHealth));
    public override string Caption=>caption;

    public Round1Combat.Target Target {get;protected set;}
    public int FormIndex {get;protected set;}
    public float EncounterAge {get;protected set;}
    public float StateAge {get;protected set;}
    // Ene_BosBase boss clock: runs from the end of the entrance (when the boss becomes damageable).
    public float BossTime {get;protected set;}
    public int AttackVolleys {get;protected set;}
    public Form Current=>FormIndex<forms.Length?forms[FormIndex]:null;
    public IReadOnlyList<Part> Parts=>parts;
    protected GameObject visual;
    protected Vector3 position; // source sky-plane units (x right, z up the screen, y toward the camera)
    protected Quaternion facing=Quaternion.identity;
    protected float sinkDepth; // source units away from the camera (destruction); scales the boss by perspective
    protected readonly List<Transform> muzzles=new List<Transform>();
    protected readonly List<string> patterns=new List<string>();
    protected readonly List<Part> parts=new List<Part>();
    protected readonly List<Minion> minions=new List<Minion>();
    protected Round1Weapon Weapon=>combat?combat.weapon:null;
    protected float StageTime=>Weapon&&Weapon.player&&Weapon.player.playback?Weapon.player.playback.elapsed:0;
    protected float Unit=>Vector3.Distance(Weapon.player.WorldPoint(Vector2.zero),Weapon.player.WorldPoint(Vector2.up))/200;
    protected string Key=>Current!=null?Current.model.Replace("Pf_Ene_",""):"";
    float attackTimer,nextSpawnTime,defeatBomb,defeatBombInterval;int muzzleCursor,patternCursor,defeatStep;Transform holder;
    Quaternion defeatFrom;

    // Ene_BosBase hpRateRanges: _hpState 0..8 as HP falls through .9/.75/.51/.4/.3/.2/.1/0.
    static readonly float[] HpRateRanges={.9f,.75f,.51f,.4f,.3f,.2f,.1f,0};
    public int HpState{get{float r=HealthRatio;for(int i=0;i<HpRateRanges.Length;i++)if(r>HpRateRanges[i])return i;return HpRateRanges.Length;}}

    public override float PresentationTime(float t)
    {
        if(!HoldsStage||loopStart<0||loopEnd<=loopStart||t<loopStart)return t;
        float spawn=forms.Length>0?forms[0].spawnTime:loopStart;
        float offset=Mathf.Max(t-loopStart,EncounterAge-(loopStart-spawn));
        return loopStart+Mathf.Repeat(offset,loopEnd-loopStart-.02f);
    }

    public override void JumpToEncounter()
    {
        if(!Weapon||!Weapon.CanAct||warningTime<0)return;
        Weapon.player.playback.Seek(warningTime);combat.ResetCombat(warningTime);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F3)&&Weapon&&Weapon.CanAct&&!ArcadeMachine.Running)JumpToEncounter();
        if(!combat||!Weapon||!Weapon.SimulationRunning&&State!=EncounterState.Defeating)return;
        float dt=Time.deltaTime;
        if(State!=EncounterState.Waiting&&State!=EncounterState.Cleared)EncounterAge+=dt;
        StateAge+=dt;
        switch(State)
        {
            case EncounterState.Waiting:
                if(forms.Length>0&&warningTime>=0&&StageTime>=warningTime){combat.ClearRegularEnemies();Enter(EncounterState.Warning);nextSpawnTime=forms[0].spawnTime;}
                break;
            case EncounterState.Warning:
                if(StageTime>=nextSpawnTime)Spawn(Current);
                break;
            case EncounterState.Entering:
                if(Entrance(dt)){SetVulnerable(true);BossTime=0;Enter(EncounterState.Fighting);OnFightStart();}
                break;
            case EncounterState.Fighting:
                BossTime+=dt;Fight(dt);
                break;
            case EncounterState.Defeating:
                Defeat(dt);
                if(StateAge>=defeatDuration)NextForm();
                break;
        }
        StepMinions(dt);
        Place();
    }

    protected void Enter(EncounterState s){State=s;StateAge=0;}

    // ---------------------------------------------------------------- spawn and parts
    // The boss prefab carries its entrance clip (anc_bsNN_start) on an Animator; then the root holds its rest position.
    protected bool Animated {get;private set;}
    protected virtual Vector3 EntryStart(Form f)=>Animated?f.rest:f.rest+new Vector3(0,0,120);

    protected virtual void Spawn(Form f)
    {
        if(f==null||!f.prefab){Enter(EncounterState.Cleared);return;}
        if(!holder){var h=new GameObject("Boss holder (inactive)");h.hideFlags=HideFlags.DontSave;h.SetActive(false);holder=h.transform;}
        visual=Instantiate(f.prefab,holder);StageEnemies.StripStubBehaviours(visual);
        foreach(var ps in visual.GetComponentsInChildren<ParticleSystem>(true))ps.gameObject.SetActive(false);
        foreach(var c in visual.GetComponentsInChildren<Collider>(true))c.enabled=false;
        Animated=visual.GetComponentInChildren<Animator>(true);
        facing=Quaternion.Euler(f.rotate);position=EntryStart(f);sinkDepth=0;BossTime=0;
        Target=combat.RegisterBoss(visual,Vector2.one*.5f,f.health,.12f,f.model);
        Target.sourceSpawn=true;Target.sourceScale=Unit;Target.sourceRotation=facing;Target.invulnerable=true;
        BuildParts(f); // at the prefab's rest pose, before it is placed or animated
        // A ground boss (EnemyDatabase isGround: Ene_Bos08A, the fortress below the sky plane) never touches the ship.
        var dbRow=StageCombatData.Get(f.model);bool ground=dbRow!=null&&dbRow.ground;
        foreach(var p in parts)if(p.target!=null)p.target.noShipContact=ground;
        combat.effects.bossRenderers=PartRenderers;
        visual.transform.SetParent(transform,false);
        muzzles.Clear();foreach(var t in visual.GetComponentsInChildren<Transform>(true))if(t.name.StartsWith("muzzle"))muzzles.Add(t);
        patterns.Clear();
        string prefix=PatternPrefix(f.model);
        if(combat.sourceAttacks&&combat.sourceAttacks.Ready)foreach(var p in combat.sourceAttacks.Source.patterns)if(p.name.StartsWith(prefix))patterns.Add(p.name);
        attackTimer=attackInterval;Enter(EncounterState.Entering);
        OnSpawned();
    }
    // Hit flash and damage blink per part (EnePartsGroup.SetHit / SetDamageBlinkRate on its renderers): a breakable part
    // owns the renderers under its root, less those of breakable parts nested inside it; the body takes all the rest.
    IEnumerable<Renderer> PartRenderers(Round1Combat.Target t)
    {
        if(!visual)yield break;
        var part=parts.Find(p=>!p.body&&p.target==t);
        var root=part!=null&&part.root?part.root:visual.transform;
        var nested=new List<Transform>();
        foreach(var p in parts)if(!p.body&&p!=part&&p.root&&p.root!=root&&p.root.IsChildOf(root))nested.Add(p.root);
        foreach(var r in root.GetComponentsInChildren<Renderer>(true))
        {
            if(r is ParticleSystemRenderer)continue;
            bool other=false;foreach(var n in nested)if(r.transform.IsChildOf(n)){other=true;break;}
            if(!other)yield return r;
        }
    }
    // Pf_Ene_Bos01 -> "bos01", Pf_Ene_Bos08B -> "bos08".
    static string PatternPrefix(string model){string key=model.Replace("Pf_Ene_","").ToLowerInvariant();return key.Length>=5?key.Substring(0,5):key;}

    void BuildParts(Form f)
    {
        parts.Clear();
        var shape=BossShapes.Get(f.model);
        var root=visual.transform;
        if(shape==null||shape.parts==null||shape.parts.Length==0)
        {
            Round1Combat.SetHitCircles(Target,Round1HitShapes.Get(f.model),facing,1f/200,1f/200);
            parts.Add(new Part{name="",index=0,body=true,root=root,target=Target});return;
        }
        for(int i=0;i<shape.parts.Length;i++)
        {
            var def=shape.parts[i];
            var row=string.IsNullOrEmpty(def.name)?null:StageCombatData.GetPart(Key,def.name);
            var part=new Part{name=def.name,index=i,row=row,root=FindPath(def.root)??root,body=string.IsNullOrEmpty(def.name)||def.flags==1||row==null||row.hitpoint<=0};
            if(def.collisions!=null)foreach(var path in def.collisions)
            {
                var col=FindPath(path)??part.root;
                if(shape.sources!=null)foreach(var s in shape.sources)if(s.path==path)
                    for(int c=s.first;c<s.first+s.count&&c<shape.circles.Length;c++)
                    {
                        var circle=shape.circles[c];
                        part.circles.Add(new LiveCircle{transform=col,local=col.InverseTransformPoint(root.TransformPoint(new Vector3(circle.x,0,circle.z))),radius=circle.r,scaleAtSpawn=col.lossyScale.x/Mathf.Max(1e-6f,root.lossyScale.x)});
                    }
            }
            if(part.body)part.target=Target;
            else
            {
                part.target=combat.RegisterBossPart(visual,Target.position,row.hitpoint,.05f,100+i,f.model);
                part.target.sourceSpawn=true;part.target.lockOn=row.isLockOn;part.target.blocksLaser=!row.isBreakthrough;part.target.homingPriority=row.priority;part.target.invulnerable=true;
            }
            parts.Add(part);
        }
        UpdateCircles();
    }
    // Prefab paths in the shapes table start with the prefab's own name.
    protected Transform FindPath(string path)
    {
        if(!visual||string.IsNullOrEmpty(path))return null;
        int slash=path.IndexOf('/');if(slash<0)return path==visual.name.Replace("(Clone)","")?visual.transform:Find(path);
        return visual.transform.Find(path.Substring(slash+1));
    }
    // By relative path, or by name anywhere under the boss.
    protected Transform Find(string pathOrName)
    {
        if(!visual)return null;var t=visual.transform.Find(pathOrName);if(t)return t;
        foreach(var c in visual.GetComponentsInChildren<Transform>(true))if(c.name==pathOrName)return c;
        return null;
    }
    public Part GetPart(string name)=>parts.Find(p=>p.name==name);

    // Live hit circles: each circle rides its collision transform (animated legs, sliding arms, spinning wings).
    void UpdateCircles()
    {
        if(!visual||Target==null)return;
        var root=visual.transform;float depth=DepthScale;
        var body=new List<Vector3>();bool bodyCircles=false;
        foreach(var part in parts)
        {
            if(part.body&&part.circles.Count>0)bodyCircles=true;
            var list=part.body?body:new List<Vector3>();
            if(part.enabled&&!part.broken)foreach(var c in part.circles)
            {
                if(!c.transform||!c.transform.gameObject.activeInHierarchy)continue;
                var local=root.InverseTransformPoint(c.transform.TransformPoint(c.local));
                var o=facing*local;float scale=c.transform.lossyScale.x/Mathf.Max(1e-6f,root.lossyScale.x)/Mathf.Max(1e-6f,c.scaleAtSpawn);
                list.Add(new Vector3(o.x/200*depth,o.z/200*depth,c.radius*scale/200*depth));
            }
            if(!part.body&&part.target!=null){part.target.hitCircles=list.Count>0?list.ToArray():null;part.target.position=Target.position;if(list.Count==0)part.target.invulnerable=true;}
        }
        if(bodyCircles)Target.hitCircles=body.Count>0?body.ToArray():new[]{new Vector3(0,0,0)};
    }

    // ---------------------------------------------------------------- vulnerability
    // Ene_BosBase entrance: no collision, then collision without lock-on/damage, then fully live.
    protected void SetVulnerable(bool on)
    {
        if(Target==null)return;
        Target.invulnerable=!on;Target.lockOn=on&&LockOnBody;
        foreach(var p in parts)if(!p.body&&p.target!=null&&!p.broken)SetPartVulnerable(p,on&&p.enabled);
    }
    protected virtual bool LockOnBody=>true;
    protected void SetPartVulnerable(Part p,bool on){if(p.target==null||p.body)return;p.target.invulnerable=!on||p.broken;p.target.lockOn=on&&p.row!=null&&p.row.isLockOn;}

    // ---------------------------------------------------------------- hooks for native-spec subclasses
    protected virtual void OnSpawned(){}
    protected virtual void OnFightStart(){}
    // Entrance; true when the boss becomes damageable and the boss clock starts.
    protected virtual bool Entrance(float dt)
    {
        if(Animated){position=Current.rest;return StateAge>=Mathf.Max(entryDuration,5);}
        float u=Mathf.Clamp01(StateAge/Mathf.Max(.01f,entryDuration));
        position=Vector3.Lerp(EntryStart(Current),Current.rest,1-(1-u)*(1-u));
        return u>=1;
    }
    // Generic fight: hold the rest position with a slow sway, fire the boss's own templates in turn.
    protected virtual void Fight(float dt)
    {
        var f=Current;
        position=f.rest+new Vector3(swayAmplitude*Mathf.Sin(StateAge*2*Mathf.PI/swayPeriod),0,0);
        attackTimer-=dt;
        if(attackTimer<=0&&patterns.Count>0&&muzzles.Count>0)
        {
            attackTimer=attackInterval;
            string pattern=patterns[patternCursor++%patterns.Count];
            Fire(pattern,muzzles[muzzleCursor++%muzzles.Count]);
        }
    }
    protected virtual void PartBroken(Part part)
    {
        if(part.root&&visual&&part.root!=visual.transform)
        {
            Boom("pf_eff_explposion01",part.root.position);
            part.root.gameObject.SetActive(false);
        }
        Round1Sound.Event("enemyDead");
    }

    // ---------------------------------------------------------------- fire, effects, summons
    protected void Fire(string pattern,Transform muzzle,float angle=0,Transform toward=null)
    {
        if(!combat.sourceAttacks||!muzzle||Target==null||!muzzle.gameObject.activeInHierarchy)return;
        combat.sourceAttacks.FireBoss(Target,pattern,muzzle,angle,toward);AttackVolleys++;
    }
    protected void Fire(string pattern,string muzzle,float angle=0,Transform toward=null)=>Fire(pattern,Find(muzzle),angle,toward);
    protected void CancelLasers(){if(Target!=null&&combat.sourceAttacks)combat.sourceAttacks.CancelBeams(Target);}
    protected void Boom(string effect,Vector3 world,float scale=1){combat.effects.Play(effect,world,Weapon.player.stageCamera.transform.rotation*Quaternion.Euler(-90,0,0),Unit*scale,StageTime);}
    protected void Boom(string effect,Transform at,float scale=1){if(at)Boom(effect,at.position,scale);}

    // Source sky-plane position of the player ship (y 0), for aiming and following.
    protected Vector3 PlayerSource
    {
        get
        {
            var vp=Weapon.player.viewportPosition;float h=SourceHeight,aspect=Weapon.player.stageCamera.aspect;
            var offset=combat.sourceWaves?combat.sourceWaves.LayerOffset:Vector3.zero;
            return new Vector3((vp.x-.5f)*h*aspect,0,(vp.y-.5f)*h)-offset;
        }
    }
    protected float SourceHeight=>combat.sourceWaves&&combat.sourceWaves.Source!=null?combat.sourceWaves.Source.sourceHeight:200;
    protected Vector2 ToViewport(Vector3 source)
    {
        var waves=combat.sourceWaves;
        return waves?waves.ToViewport(source+waves.LayerOffset):new Vector2(.5f+source.x/(200*Weapon.player.stageCamera.aspect),.5f+source.z/200);
    }

    // A summoned enemy (boss bits, launched arms, fighters): its original prefab and database HP, moved by the boss.
    protected Minion Summon(string model,Vector3 source,Vector3 velocity,Action<Minion,float> step=null,float health=-1)
    {
        var prefab=MinionPrefab(model);if(!prefab){Debug.LogWarning("Boss summon without prefab: "+model,this);return null;}
        // Database HP: the stage model table, else the raw row by key (Pf_Ene_Bos04_bit -> Bos04_bit, Pf_EneObj_Bos05_Arm -> Bos05_Arm).
        var row=StageCombatData.Get(model);var raw=StageCombatData.GetPart(model.Replace("Pf_EneObj_","").Replace("Pf_Ene_",""),"");
        if(health<=0)health=row!=null&&row.health>0?row.health:raw!=null&&raw.hitpoint>0?raw.hitpoint:500;
        var t=combat.SpawnSourceTarget(prefab,ToViewport(source),health);
        if(t==null)return null;
        t.sourceSpawn=true;t.sourceScale=Unit;t.stationary=true;
        Round1Combat.SetHitCircles(t,Round1HitShapes.Get(model),Quaternion.identity,1f/200,1f/200);
        var m=new Minion{target=t,position=source,velocity=velocity,step=step};minions.Add(m);return m;
    }
    // Prefabs for summons: the stage's own visuals first, else the builder-provided list.
    public GameObject[] minionPrefabs=new GameObject[0];
    // Models this boss summons; the stage builder resolves their prefabs into minionPrefabs.
    public virtual string[] MinionModels=>new string[0];
    protected virtual GameObject MinionPrefab(string model)
    {
        foreach(var p in minionPrefabs)if(p&&p.name==model)return p;
        var w=combat.sourceWaves;if(w&&w.visuals!=null)foreach(var v in w.visuals)if(v.name==model)return v.prefab;
        return null;
    }
    void StepMinions(float dt)
    {
        for(int i=minions.Count-1;i>=0;i--)
        {
            var m=minions[i];if(!m.Alive){minions.RemoveAt(i);continue;}
            m.age+=dt;if(m.step!=null)m.step(m,dt);else m.position+=m.velocity*dt;
            m.target.position=ToViewport(m.position);m.target.sourceRotation=m.facing;m.target.sourceScale=Unit;
            Round1Combat.SetHitCircles(m.target,Round1HitShapes.Get(Round1Effects.Model(m.target)),m.facing,1f/200,1f/200);
            if(Mathf.Abs(m.position.x)>260||Mathf.Abs(m.position.z)>200){combat.DespawnSourceTarget(m.target);minions.RemoveAt(i);continue;}
            combat.PlaceSourceTarget(m.target);
        }
    }
    protected void ClearMinions(){foreach(var m in minions)if(m.Alive)combat.DespawnSourceTarget(m.target);minions.Clear();}

    // ---------------------------------------------------------------- destruction (Ene_BosBase)
    // Root rotation the boss turns to while sinking (each boss's Destruction: Bos01 (20,135,0), Bos04/05/07 (20,45,0), ...).
    protected virtual Vector3 DestructionEuler=>new Vector3(20,45,0);
    protected virtual float DeadEffectTime=>3.5f;
    protected virtual void Defeat(float dt)
    {
        if(!visual)return;
        float u=Mathf.Clamp01(StateAge/5.5f);
        sinkDepth=150*u*u;
        facing=Quaternion.Slerp(defeatFrom,Quaternion.Euler(DestructionEuler),u);
        if(defeatStep==0){defeatStep=1;for(int i=0;i<4;i++)Boom("pf_eff_explposion01",visual.transform.position+UnityEngine.Random.insideUnitSphere*25*Unit);}
        defeatBomb-=dt;
        if(defeatBomb<=0&&StateAge<DeadEffectTime)
        {
            defeatBomb=defeatBombInterval+UnityEngine.Random.value*.1f;defeatBombInterval*=.9f; // base + rand 0..0.1 (Bos01 spec)
            var at=muzzles.Count>0&&muzzles[0]?muzzles[UnityEngine.Random.Range(0,muzzles.Count)].position:visual.transform.position+UnityEngine.Random.insideUnitSphere*20*Unit;
            Boom("pf_eff_explposion01",at,.6f);
        }
        if(defeatStep==1&&StateAge>=DeadEffectTime){defeatStep=2;Boom("pf_eff_explposion_boss",visual.transform.position,1.5f);Round1Sound.Event("bossDefeat");}
    }

    void NextForm()
    {
        if(visual)Destroy(visual);visual=null;Target=null;parts.Clear();ClearMinions();
        FormIndex++;
        if(FormIndex<forms.Length){Enter(EncounterState.Warning);nextSpawnTime=Mathf.Max(StageTime+1,forms[FormIndex].spawnTime);}
        else Enter(EncounterState.Cleared);
    }

    protected float DepthScale=>400f/(400f+sinkDepth); // native camera 400 above the sky plane
    protected virtual void Place()
    {
        if(Target==null||!visual)return;
        Target.position=ToViewport(position);
        Target.sourceRotation=facing;Target.sourceScale=Unit*DepthScale;
        UpdateCircles();
        if(Target.active)combat.PlaceSourceTarget(Target);
        else
        {
            // Killed (sinking) or not yet active: place the hull the same way a live source target is placed.
            visual.SetActive(true);var cam=Weapon.player.stageCamera.transform;
            visual.transform.position=Weapon.player.WorldPoint(Target.position);
            visual.transform.rotation=cam.rotation*Quaternion.Euler(-90,0,0)*facing;visual.transform.localScale=Vector3.one*Target.sourceScale;
        }
    }

    public override void OnDefeated()
    {
        if(State==EncounterState.Defeating||StageCleared)return;
        combat.ClearHostiles();CancelLasers();ClearMinions();
        foreach(var p in parts)if(!p.body&&p.target!=null)p.target.invulnerable=true;
        defeatFrom=facing;defeatBomb=.2f;defeatBombInterval=.2f;defeatStep=0;
        Enter(EncounterState.Defeating);
    }
    public override void OnPartBroken(Round1Combat.Target target)
    {
        var part=parts.Find(p=>p.target==target&&!p.body);if(part==null||part.broken)return;
        part.broken=true;part.target.invulnerable=true;PartBroken(part);
    }
    // Break a part from boss logic (time/HP forced breaks).
    protected void BreakPart(Part part)
    {
        if(part==null||part.broken)return;
        if(part.target!=null&&!part.body){part.target.health=0;combat.DespawnSourceTarget(part.target);}
        part.broken=true;PartBroken(part);
    }
    public override void ResetEncounter()
    {
        if(visual)Destroy(visual);visual=null;Target=null;parts.Clear();ClearMinions();FormIndex=0;EncounterAge=0;BossTime=0;AttackVolleys=0;sinkDepth=0;Enter(EncounterState.Waiting);
    }
}

// The per-part collision table from tools/stage_combat/enemy_hitshapes.py (Resources/StageCombat/enemy-hitshapes.json).
public static class BossShapes
{
    [Serializable] public class Circle {public float x,z,r;}
    [Serializable] public class Source {public string path;public int first,count;}
    [Serializable] public class PartDef {public string name,root;public int flags;public string[] collisions;}
    [Serializable] public class Model {public string model;public Circle[] circles;public PartDef[] parts;public Source[] sources;}
    [Serializable] class Data {public Model[] models;}
    static Dictionary<string,Model> models;
    public static Model Get(string model)
    {
        if(models==null)
        {
            models=new Dictionary<string,Model>();
            var asset=Resources.Load<TextAsset>("StageCombat/enemy-hitshapes");
            if(asset)foreach(var m in JsonUtility.FromJson<Data>(asset.text).models)models[m.model]=m;
        }
        return model!=null&&models.TryGetValue(model,out var found)?found:null;
    }
}
