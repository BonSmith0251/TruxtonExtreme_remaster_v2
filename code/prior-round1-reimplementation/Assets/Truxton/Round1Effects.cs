using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// One-shot original effects placed on the stage plane in the enemies' source frame (the same rotation and scale
// Round1Combat gives a source model), pooled per prefab.
//   Hit: a player shot's _hitEffectCode (EffectCode Hit10..Hit70 = pf_eff_p_hit10_ingame..70) follows the weapon:
//     sp_eff_pshot_10 normal 0, pshot_20 tatsujin beam 1, plaser_10 thunder laser 2, plaser_40 gold laser 3,
//     pshot_30 homing 4, pshot_50 grow 5, plaser_70 black laser 6, i.e. Round1Arms order.
//   Blast: PawnEnemy._deadExplosion and _explosionOffset (model-local, Y up) of the model, read by
//     study_enemy_effects.py (extractor/enemy-effects/effects.json). Lb01 has none. Ground enemies explode in the
//     ground's world frame at their own position, air enemies in the source frame.
public sealed class Round1Effects
{
    sealed class Live { public GameObject go;public float start,until;public string name; }
    static readonly Dictionary<string,(string effect,float up)> DeadExplosions=new Dictionary<string,(string,float)>{
        {"Pf_EneObj_Meteo_Sa02",("pf_eff_explosion_meteor01",0)},{"Pf_EneObj_Meteo_Ma02",("pf_eff_explosion_meteor02",0)},{"Pf_EneObj_Meteo_La02",("pf_eff_explosion_meteor03",0)},
        {"Pf_Ene_Sa01",("pf_eff_explposion01",0)},{"Pf_Ene_Se01",("pf_eff_explposion01",0)},{"Pf_Ene_Sd01",("pf_eff_explposion01",0)},
        {"Pf_Ene_Md01",("pf_eff_explposion02",0)},{"Pf_Ene_Mj01b",("pf_eff_explposion01",0)},{"Pf_Ene_Mj01h",("pf_eff_explposion02",0)},{"Pf_Ene_Ma01",("pf_eff_explposion03",0)},{"Pf_Ene_Me01",("pf_eff_explposion03",0)},
        {"Pf_Ene_BSa01",("pf_eff_explposion01",10)},{"Pf_Ene_BSc01",("pf_eff_explposion01",10)},{"Pf_Ene_BSb01",("pf_eff_explposion04",10)},
        {"Pf_Ene_BMa01",("pf_eff_explposion02",20)},{"Pf_Ene_Mx01",("pf_eff_explposion02",5)},
        {"Pf_Item_Box01",("pf_eff_explposion01",-3)},{"Pf_Item_Box02",("pf_eff_explposion01",5)},
        {"Pf_BGObj_ColorBox01",("pf_eff_explposion01",20)},{"Pf_BGObj_ColorBox00_UN",("pf_eff_explposion01",20)}};
    // Models drawn with TATSUJIN/TXE_Lit (which has _FadeColor): the ones that blink when damaged. The item and colour
    // boxes use other shaders and never blink.
    static readonly HashSet<string> Blinking=new HashSet<string>{"Pf_EneObj_Meteo_Sa02","Pf_EneObj_Meteo_Ma02","Pf_EneObj_Meteo_La02",
        "Pf_Ene_Sa01","Pf_Ene_Se01","Pf_Ene_Sd01","Pf_Ene_Md01","Pf_Ene_Mj01h","Pf_Ene_Mj01b","Pf_Ene_Ma01","Pf_Ene_Me01","Pf_Ene_Lb01",
        "Pf_Ene_BSa01","Pf_Ene_BSb01","Pf_Ene_BSc01","Pf_Ene_BMa01","Pf_Ene_Mx01"};
    public static string Model(Round1Combat.Target t)=>t.template?t.template.name:t.visual?t.visual.name.Replace("(Clone)",""):null;
    public static bool Blinks(Round1Combat.Target t)=>t.isBoss?t.bossPart>=0 && t.bossPart<BossPartNodes.Length:Blinking.Contains(Model(t)??"");
    // Ene_Bos03 PartsList: each part flashes and blinks its own renderers (EnePartsGroup.SetHit / SetDamageBlinkRate).
    // Body (part 0): bs03_body, both shoulders and batteries; armL bs03_arm60; armR bs03_arm40; cover bs03_cover.
    static readonly string[][] BossPartNodes={new[]{"bs03_body","bs03_shoulder40","bs03_shoulder60","bs03_battery60","bs03_battery40"},new[]{"bs03_arm60"},new[]{"bs03_arm40"},new[]{"bs03_cover"}};
    public GameObject bossVisual;
    // Laser hits repeat while the beam stays on a target; one effect per target per this interval.
    const float LaserHitInterval=1f/15;
    readonly Dictionary<string,GameObject> prefabs=new Dictionary<string,GameObject>();
    readonly Dictionary<string,Stack<GameObject>> pool=new Dictionary<string,Stack<GameObject>>();
    readonly List<Live> live=new List<Live>();
    readonly Dictionary<int,float> laserHits=new Dictionary<int,float>();
    Transform root;Round1PlayerController player;bool ready;
    public int Hits { get; private set; }
    public int Blasts { get; private set; }
    public Round1Combat.Target LastBlast { get; private set; }
    public readonly Dictionary<string,int> Counts=new Dictionary<string,int>(),BlastsByModel=new Dictionary<string,int>(),HitsByModel=new Dictionary<string,int>();
    public GameObject Prefab(string name)=>name!=null && prefabs.TryGetValue(name,out var p)?p:null;
    public static string HitEffect(Round1Arms arms)=>"pf_eff_p_hit"+((int)arms+1)*10+"_ingame";
    public static string DeadExplosion(string model)=>model!=null && DeadExplosions.TryGetValue(model,out var e)?e.effect:null;
    // Source units to world units on the stage plane (what Round1EnemyWaves gives a source model at the plane).
    float PlaneScale=>Vector3.Distance(player.WorldPoint(Vector2.zero),player.WorldPoint(Vector2.up))/200;
    public void Initialize(Transform parent,Round1PlayerController owner)
    {
        if(ready)return;player=owner;ready=true;
        var library=Resources.Load<Round1EffectLibrary>("Truxton/EffectLibrary");
        if(!library){Debug.LogWarning("Effect library is missing; hits and blasts are not drawn.");return;}
        foreach(var e in library.prefabs)if(e.prefab)prefabs[e.name]=e.prefab;
        root=new GameObject("Effects").transform;root.SetParent(parent,false);
    }
    public bool Hit(Round1Combat.Target t,Round1Arms arms,Vector2 at,float now,bool laser)
    {
        if(Blinks(t))Flash(t);
        if(laser){if(laserHits.TryGetValue(t.id,out float last) && now-last<LaserHitInterval && now>=last)return false;laserHits[t.id]=now;}
        if(!Play(HitEffect(arms),at,t.sourceScale>0 && !t.ground?t.sourceScale:PlaneScale,now))return false;Hits++;Round1Sound.Hit();
        string model=Model(t)??"?";HitsByModel.TryGetValue(model,out int n);HitsByModel[model]=n+1;return true;
    }
    // A multi-part enemy's staged death (PawnEnemy._explosionOrder, _delayDeadTime, _delayDeadVector): its parts go one
    // by one. Each step hides a MeshRenderer and plays an Explosion kind (enum Explosion: 1 E4Little, 2 E1Small,
    // 3 E2Middle, 4 E3Large, 5 E5Huge = pf_eff_explposion04/01/02/03/05) at its effect transform (else the renderer);
    // the enemy shakes by the delay vector until the delay ends. Pf_Ene_Lb01 (the snake): head, its map, burners and
    // gears at once with a huge blast, then body segments 1-7 every 0.15 s (middle), the tail at 1.2 s (large), gone at
    // 1.35 s. The remaster plays it on a copy of the model, posed as it died, while the target itself is removed.
    sealed class OrderStep { public float time;public int kind;public string target,effect; }
    sealed class Order { public float delay,shake;public OrderStep[] steps; }
    static readonly string[] ExplosionKinds={null,"pf_eff_explposion04","pf_eff_explposion01","pf_eff_explposion02","pf_eff_explposion03","pf_eff_explposion05"};
    const string Lb01Body="pf_ene_lb01/ene_lb01_body01";
    static string Lb01Segment(int n)
    {
        var path=Lb01Body;for(int i=1;i<=n && i<=7;i++)path+="/ene_lb01_body02"+i;
        return n<8?path+"/ene_lb01_body02"+n+"_rot":path+"/ene_lb01_body03/ene_lb01_body03_rot";
    }
    static readonly Dictionary<string,Order> Orders=new Dictionary<string,Order>{
        {"Pf_Ene_Lb01",new Order{delay=1.35f,shake=.35f,steps=new OrderStep[]{
            new OrderStep{time=0,kind=5,target=Lb01Body,effect=Lb01Body},
            new OrderStep{target=Lb01Body+"/ene_lb01_body01_map2"},new OrderStep{target=Lb01Body+"/ene_lb01_burner_l"},new OrderStep{target=Lb01Body+"/ene_lb01_burner_r"},
            new OrderStep{target=Lb01Body+"/ene_lb01_gearR1"},new OrderStep{target=Lb01Body+"/ene_lb01_gearR2"},new OrderStep{target=Lb01Body+"/ene_lb01_gearL1"},new OrderStep{target=Lb01Body+"/ene_lb01_gearL2"},
            new OrderStep{time=.15f,kind=3,target=Lb01Segment(1)},new OrderStep{time=.3f,kind=3,target=Lb01Segment(2)},new OrderStep{time=.45f,kind=3,target=Lb01Segment(3)},
            new OrderStep{time=.6f,kind=3,target=Lb01Segment(4)},new OrderStep{time=.75f,kind=3,target=Lb01Segment(5)},new OrderStep{time=.9f,kind=3,target=Lb01Segment(6)},
            new OrderStep{time=1.05f,kind=3,target=Lb01Segment(7)},new OrderStep{time=1.2f,kind=4,target=Lb01Segment(8)}}}}};
    // EnePartsGroup._damageObject: shown once the part is below its damage blink rate (SetDamageEffect), e.g. Lb01's smoke.
    static readonly Dictionary<string,string> DamageObjects=new Dictionary<string,string>{{"Pf_Ene_Lb01",Lb01Body+"/damage"}};
    sealed class Dying { public GameObject copy;public Order order;public float born,scale;public int next;public Vector3 basePosition;public Transform root; }
    readonly List<Dying> dying=new List<Dying>();
    public int StagedDeaths { get; private set; }
    public int StagedSteps { get; private set; }
    public int DyingCount=>dying.Count;
    public string DescribeDying(float now)=>string.Join("; ",dying.Select(d=>"age "+(now-d.born).ToString("0.00")+" steps "+d.next+" renderers on "+d.copy.GetComponentsInChildren<Renderer>().Count(r=>r.enabled && !(r is ParticleSystemRenderer))+" missing "+d.order.steps.Count(s=>!d.root.Find(s.target))));
    bool StartDying(Round1Combat.Target t,string model,float now)
    {
        if(!Orders.TryGetValue(model,out var order) || !t.visual || t.ground)return false;
        var copy=Object.Instantiate(t.visual,root);copy.name=model+" (dying)";
        copy.transform.SetPositionAndRotation(t.visual.transform.position,t.visual.transform.rotation);copy.transform.localScale=t.visual.transform.lossyScale;
        foreach(var c in copy.GetComponentsInChildren<Collider>(true))c.enabled=false;
        dying.Add(new Dying{copy=copy,order=order,born=now,scale=t.sourceScale>0?t.sourceScale:PlaneScale,basePosition=copy.transform.position,root=copy.transform});
        StagedDeaths++;StepDying(now);return true;
    }
    void StepDying(float now)
    {
        for(int i=dying.Count-1;i>=0;i--)
        {
            var d=dying[i];float age=now-d.born;
            if(!d.copy || age<0 || age>=d.order.delay){if(d.copy)Object.Destroy(d.copy);dying.RemoveAt(i);continue;}
            while(d.next<d.order.steps.Length && d.order.steps[d.next].time<=age)
            {
                var s=d.order.steps[d.next++];var target=d.root.Find(s.target);
                if(target){var r=target.GetComponent<Renderer>();if(r)r.enabled=false;}
                var at=d.root.Find(s.effect??s.target)??target;
                if(s.kind>0 && at){var fx=ExplosionKinds[s.kind];if(Play(fx,at.position,SourceRotation,d.scale,now))Round1Sound.Dead(null,fx);}
                StagedSteps++;
            }
            // Shake sideways on screen by up to _delayDeadVector.x source units.
            var right=player.stageCamera.transform.right;
            d.copy.transform.position=d.basePosition+right*(Random.Range(-1f,1f)*d.order.shake*d.scale);
        }
    }
    public void DamageSmoke(Round1Combat.Target t)
    {
        if(!t.visual || !DamageObjects.TryGetValue(Model(t)??"",out var path))return;
        var node=t.visual.transform.Find(path);if(!node)return;
        bool show=t.active && t.maxHealth>0 && t.health/t.maxHealth<DamageBlinkRate;
        foreach(var ps in node.GetComponentsInChildren<ParticleSystem>(true))
        {
            if(ps.gameObject.activeSelf==show)continue;
            ps.gameObject.SetActive(show);if(show)ps.Play(true);
        }
    }
    public bool Blast(Round1Combat.Target t,float now)
    {
        string model=Model(t);if(t.isBoss || model==null)return false;
        if(StartDying(t,model,now)){Blasts++;BlastsByModel.TryGetValue(model,out int k);BlastsByModel[model]=k+1;LastBlast=t;return true;}
        if(!DeadExplosions.TryGetValue(model,out var e))return false;
        bool played;
        if(t.ground && t.visual)
        {
            float s=t.visual.transform.lossyScale.y;
            played=Play(e.effect,t.visual.transform.position+Vector3.up*e.up*s,Quaternion.identity,s,now);
        }
        else
        {
            float s=t.sourceScale>0?t.sourceScale:PlaneScale;var rotation=SourceRotation;
            played=Play(e.effect,player.WorldPoint(t.position)+rotation*Vector3.up*e.up*s,rotation,s,now);
        }
        if(played){Blasts++;BlastsByModel.TryGetValue(model,out int n);BlastsByModel[model]=n+1;LastBlast=t;Round1Sound.Dead(model,e.effect);}return played;
    }
    Quaternion SourceRotation=>player.stageCamera.transform.rotation*Quaternion.Euler(-90,0,0);
    // PlayerControll._playerDead -> StartDeadEffect: InGameEffectManager.ExplosionQue(PlayerControll.DeadEffectCode) at the
    // ship, the in-game player explosion pf_eff_explposion_p.
    public const string PlayerDeadEffect="pf_eff_explposion_p";
    public bool PlayerDestroyed(Vector2 viewport,float now)=>Play(PlayerDeadEffect,viewport,PlaneScale,now);
    public bool Play(string name,Vector2 viewport,float scale,float now)=>Play(name,player.WorldPoint(viewport),SourceRotation,scale,now);
    public bool Play(string name,Vector3 position,Quaternion rotation,float scale,float now)
    {
        if(name==null || !prefabs.TryGetValue(name,out var prefab) || scale<=0)return false;
        if(!pool.TryGetValue(name,out var free))pool[name]=free=new Stack<GameObject>();
        var go=free.Count>0?free.Pop():Object.Instantiate(prefab,root);
        go.transform.SetPositionAndRotation(position,rotation);
        go.transform.localScale=Vector3.one*scale;
        go.SetActive(true);float length=0;
        foreach(var ps in go.GetComponentsInChildren<ParticleSystem>(true))
        {
            var main=ps.main;length=Mathf.Max(length,main.duration+main.startDelay.constantMax+main.startLifetime.constantMax);
            ps.Clear(true);ps.Play(true);
        }
        live.Add(new Live{go=go,start=now,until=now+Mathf.Max(.1f,length),name=name});
        Counts.TryGetValue(name,out int n);Counts[name]=n+1;return true;
    }
    // Returns finished effects to the pool; a backward seek (restart) clears them all.
    public void Step(float now)
    {
        StepDying(now);
        for(int i=live.Count-1;i>=0;i--)
        {
            var l=live[i];if(now<l.until && now>=l.until-30)continue;
            if(l.go){l.go.SetActive(false);pool[l.name].Push(l.go);}live.RemoveAt(i);
        }
    }
    // EnePartsGroup.OnUpdate (0x1d626d0) damage blink: once the part's remaining HP rate falls below _damageBlinkRate
    // (0.5 by default, .ctor), _blinkTimer advances by dt / (clamp(rate, 0.1, 1) / 0.5) and the renderers' _FadeColor is
    // lerped to PawnEnemy.DamagedColor (1, 0.392, 0, 0.314) by the triangle 1 - |(timer mod 2) - 1|: an orange pulse
    // every 2 s at half HP, every 0.4 s at a tenth. TXE_Lit then mixes _FadeColor.rgb in by its alpha. The remaster's
    // URP Lit materials have no _FadeColor, so the same mix is drawn by scaling base and emission by (1 - w) and adding
    // the orange as emission. (The 0.2 s per-hit flash, GetHitFlashColor on _MaterialColor, has no effect on TXE_Lit
    // meteors.)
    // Remaster departure (user request 2026-10-29): every hit also flashes a blinking enemy white, fading over the native hit
    // flash time (_hitFlushTime 0.2 s, OnUpdate's divisor) from HitFlashStrength. White is _hitFlashColors[0]; the
    // original's alpha 0.1 on _MaterialColor would not read on these materials, so the strength is a remaster choice.
    const float DamageBlinkRate=.5f,HitFlashTime=.2f,HitFlashStrength=.55f;
    static readonly Color DamagedColor=new Color(1,.392f,0,.314f);
    sealed class BlinkState { public int id;public float timer,flash;public Material[] materials;public Color[] bases,emissions; }
    readonly Dictionary<Round1Combat.Target,BlinkState> blinks=new Dictionary<Round1Combat.Target,BlinkState>();
    readonly HashSet<Renderer> prepared=new HashSet<Renderer>();
    static readonly int BaseColorId=Shader.PropertyToID("_BaseColor"),EmissionColorId=Shader.PropertyToID("_EmissionColor"),EmissionMapId=Shader.PropertyToID("_EmissionMap");
    public float BlinkWeight(Round1Combat.Target t)=>blinks.TryGetValue(t,out var s) && s.id==t.id?Weight(s.timer,t):0;
    static float Weight(float timer,Round1Combat.Target t)
    {
        float rate=t.maxHealth>0?t.health/t.maxHealth:1;if(!(rate>0 && rate<DamageBlinkRate))return 0;
        float x=Mathf.Repeat(timer,2);return (1-Mathf.Abs(x-1))*DamagedColor.a;
    }
    public float FlashWeight(Round1Combat.Target t)=>blinks.TryGetValue(t,out var s) && s.id==t.id && t.active?s.flash/HitFlashTime*HitFlashStrength:0;
    // A new flash starts only once the last has faded, so steady fire (a laser, the grow shot) pulses instead of holding white.
    public void Flash(Round1Combat.Target t){var s=State(t);if(s!=null && s.flash<=0)s.flash=HitFlashTime;}
    public void Blink(Round1Combat.Target t,float dt)
    {
        var s=State(t);if(s==null)return;
        float rate=t.maxHealth>0?t.health/t.maxHealth:1;
        if(t.active && rate>0 && rate<DamageBlinkRate)s.timer+=dt/(Mathf.Clamp(rate,.1f,1)/DamageBlinkRate);
        float flash=t.active?s.flash/HitFlashTime*HitFlashStrength:0;s.flash=Mathf.Max(0,s.flash-dt);
        Paint(s,t.active?Weight(s.timer,t):0,flash);
    }
    BlinkState State(Round1Combat.Target t)
    {
        if(t.isBoss?!bossVisual:!t.visual)return null;
        if(!blinks.TryGetValue(t,out var s) || s.id!=t.id)
        {
            if(s!=null)Paint(s,0,0);
            var renderers=(t.isBoss?BossPartRenderers(t.bossPart):t.visual.GetComponentsInChildren<Renderer>(true)).Where(r=>!(r is ParticleSystemRenderer)).ToArray();
            // The imported meteor material has emission off (TXE_Lit's _EMISSION was not carried over), and a property
            // block can't switch a keyword: give each renderer, once, an instance with emission on at black (and without the
            // crack mask as emission map, so the orange covers the whole rock), which draws
            // the same until the blink adds the orange.
            foreach(var r in renderers)if(prepared.Add(r))
                foreach(var m in r.materials)if(!m.IsKeywordEnabled("_EMISSION")){m.EnableKeyword("_EMISSION");m.SetColor(EmissionColorId,Color.black);m.SetTexture(EmissionMapId,null);m.globalIlluminationFlags=MaterialGlobalIlluminationFlags.EmissiveIsBlack;}
            var materials=renderers.SelectMany(r=>r.sharedMaterials).Where(m=>m).ToArray();
            blinks[t]=s=new BlinkState{id=t.id,materials=materials,
                bases=materials.Select(m=>m.HasColor(BaseColorId)?m.GetColor(BaseColorId):Color.white).ToArray(),
                emissions=materials.Select(m=>m.HasColor(EmissionColorId)?m.GetColor(EmissionColorId):Color.black).ToArray()};
        }
        return s;
    }
    // Writes the mix onto the renderers' own material instances (made in Blink): a MaterialPropertyBlock on these
    // URP Lit materials left the rendered meteor unchanged.
    // w: the damage blink's orange mix; flash: the hit flash's white mix (on top, sharing what is left).
    void Paint(BlinkState s,float w,float flash)
    {
        var orange=new Color(DamagedColor.r,DamagedColor.g,DamagedColor.b);float keep=(1-w)*(1-flash);
        var glow=orange*w*(1-flash)+Color.white*flash;
        for(int i=0;i<s.materials.Length;i++)
        {
            var m=s.materials[i];if(!m)continue;var b=s.bases[i];
            m.SetColor(BaseColorId,new Color(b.r*keep,b.g*keep,b.b*keep,b.a));m.SetColor(EmissionColorId,s.emissions[i]*keep+glow);
        }
    }
    IEnumerable<Renderer> BossPartRenderers(int part)
    {
        var names=new HashSet<string>(BossPartNodes[part]);
        return bossVisual.GetComponentsInChildren<Transform>(true).Where(n=>names.Contains(n.name)).SelectMany(n=>n.GetComponentsInChildren<Renderer>(true)).Distinct();
    }
    // Preview comparisons: draw one target without its blink until the next Blink call.
    public void Unpaint(Round1Combat.Target t){if(blinks.TryGetValue(t,out var s))Paint(s,0,0);}
    public string Describe(Round1Combat.Target t)
    {
        if(!blinks.TryGetValue(t,out var s))return "no state";var sb=new System.Text.StringBuilder();
        foreach(var m in s.materials)if(m)sb.Append(m.name+" kw="+m.IsKeywordEnabled("_EMISSION")+" em="+m.GetColor(EmissionColorId)+" base="+m.GetColor(BaseColorId)+"; ");
        return sb.ToString();
    }
    // For stepped previews (checks advance many stage frames per editor frame): pose every live effect at its age.
    public void SimulateTo(float now){foreach(var l in live)if(l.go)foreach(var ps in l.go.GetComponentsInChildren<ParticleSystem>())ps.Simulate(Mathf.Max(0,now-l.start),true,true);}
    public void Clear(){foreach(var l in live)if(l.go){l.go.SetActive(false);pool[l.name].Push(l.go);}live.Clear();laserHits.Clear();foreach(var s in blinks.Values)Paint(s,0,0);blinks.Clear();foreach(var d in dying)if(d.copy)Object.Destroy(d.copy);dying.Clear();}
}
