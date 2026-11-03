using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[DefaultExecutionOrder(200)]
public partial class Round1Weapon : MonoBehaviour
{
    public Round1PlayerController player;
    public Round1Combat combat;
    public Round1Intro intro;
    [System.NonSerialized] public Round1Autopilot autopilot;
    public GameObject bulletPrefab,bombPrefab;
    public TextAsset parameters;
    public Texture2D[] shotTextures;
    public Round1Powerup[] powerups;
    public int poolSize=768;
    public float bulletSpeed=1.25f;
    public bool persistHighScore=true;
    public int Level { get; private set; }=1;
    public float MaximumHealth => Round1Balance.Current.playerHealth;
    public float Health { get; private set; }=100;
    public int Lives { get; private set; }=3;
    public int Bombs { get; private set; }=3;
    public int BombLevel { get; private set; }=1;
    public int ChangeCharges { get; private set; }=3;
    public int Score { get; private set; }
    public int HighScore { get; private set; }
    public int SpeedLevel { get; private set; }=1;
    public Round1Arms Arms { get; private set; }
    public string WeaponColor => Arms.ToString().ToUpperInvariant();
    public string PatternName => new[]{"NORMAL SHOT","TATSUJIN BEAM","THUNDER LASER","GOLD LASER","HOMING SHOT","GROW SHOT","BLACK LASER"}[(int)Arms];
    public string Notification => notification>0?notice:"";
    public bool GameOver { get; private set; }
    public bool RoundCleared => combat && (combat.boss ? combat.boss.StageCleared : combat.clearAt>0 && player && player.playback && player.playback.elapsed>=combat.clearAt);
    public bool Respawning => respawn>0;
    public bool verificationShield;   // verification: the ship takes no hits (STAGE_PLAY_PEACE)
    public bool Invincible => verificationShield || invincible>0 || BombActive || Respawning || (player && player.SpawnAnimating);
    public bool BombActive => bombTime>0;
    public bool SimulationRunning => player && player.playback && player.playback.playing && !GameOver && !RoundCleared && (!intro || !intro.Active);
    public bool CanAct => SimulationRunning && !Respawning && !player.SpawnAnimating;
    public float FireInterval => Round1WeaponBehavior.Current.profiles[(int)Arms].interval;
    public int VolleysFired { get; private set; }
    public int ActiveBeamCount { get; private set; }
    public int ActiveBulletCount { get { int n=0;foreach(var b in bullets)if(b.active)n++;return n; } }
    public int ShotsAtLevel => CountShots(Arms,Level);
    public float LargestBulletScale { get {float size=0;foreach(var b in bullets)if(b.active)size=Mathf.Max(size,b.size);return size;} }
    public static readonly Color[] Tints={new Color(1,.35f,.2f),new Color(.3f,1,.45f),new Color(.25f,.7f,1),new Color(1,.8f,.2f),new Color(.8f,.95f,1),new Color(.85f,.3f,1),new Color(.6f,.35f,.9f)};
    class Bullet
    {
        public GameObject visual;public Renderer renderer;public Vector2 position,velocity;
        public bool active,napalm;public float age,size,damage,travel,napalmAge;public Round1Combat.Target target;public int targetId;public Round1Arms kind;
        public HashSet<int> hits=new HashSet<int>();
        public Round1DamageStream damageStream=new Round1DamageStream();
    }
    readonly List<Bullet> bullets=new List<Bullet>();
    readonly List<LineRenderer> beams=new List<LineRenderer>();
    readonly List<Round1DamageStream> beamDamage=new List<Round1DamageStream>();
    readonly Round1DamageStream bombDamage=new Round1DamageStream();
    MaterialPropertyBlock tint;
    Material lineMaterial;
    Transform poolRoot;
    GameObject bombVisual;
    Renderer[] bombRenderers;
    Round1Rules rules;
    Round1DamageProfile activeBombProfile;
    float cooldown,lastStageTime,notification,bombTime,invincible,respawn;
    string notice="";
    Vector2 lastPlayerPosition;
    bool initialized;
    public void Initialize()
    {
        if(initialized || !player || !bulletPrefab)return;
        rules=Round1Rules.Read(parameters);tint=new MaterialPropertyBlock();
        poolRoot=new GameObject("Player weapon pool").transform;
        for(int i=0;i<poolSize;i++)
        {
            var go=Instantiate(bulletPrefab,poolRoot);go.SetActive(false);
            bullets.Add(new Bullet{visual=go,renderer=go.GetComponentInChildren<Renderer>()});
        }
        lineMaterial=new Material(Shader.Find("Universal Render Pipeline/Unlit"));lineMaterial.SetColor("_BaseColor",Color.white);
        for(int i=0;i<48;i++)
        {
            var go=new GameObject("Laser "+i);go.transform.SetParent(poolRoot);
            var line=go.AddComponent<LineRenderer>();line.sharedMaterial=lineMaterial;line.useWorldSpace=true;line.positionCount=5;
            line.numCapVertices=4;line.alignment=LineAlignment.View;line.enabled=false;beams.Add(line);beamDamage.Add(new Round1DamageStream());
            line.widthCurve=new AnimationCurve(new Keyframe(0,.22f),new Keyframe(.6f,.35f),new Keyframe(1,.12f));
        }
        if(bombPrefab){bombVisual=Instantiate(bombPrefab,poolRoot);bombRenderers=bombVisual.GetComponentsInChildren<Renderer>();bombVisual.SetActive(false);}
        if(Application.isPlaying)
        {
            autopilot=GetComponent<Round1Autopilot>();
            if(!autopilot)autopilot=gameObject.AddComponent<Round1Autopilot>();
            autopilot.weapon=this;
        }
        InitializeShotMotion();initialized=true;ResetRun();if(intro && Application.isPlaying)intro.Begin();else player.BeginSpawn();
    }
    void Start(){Initialize();}
    void LateUpdate()
    {
        if(CanAct)
        {
            if(Input.GetKeyDown(KeyCode.X)||Input.GetMouseButtonDown(1))UseBomb();
            if(Input.GetKeyDown(KeyCode.C))UseChange();
        }
        if((GameOver || RoundCleared) && !Round1StageEnd.Handles && !ArcadeMachine.Running && (Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.Home)))Restart();
        bool mouseFire=Input.GetMouseButton(0) && (!EventSystem.current || !EventSystem.current.IsPointerOverGameObject());
        bool autoFire=autopilot && autopilot.enabled && autopilot.automatic && autopilot.WantsFire;
        Step(Time.deltaTime,autoFire || Input.GetKey(KeyCode.Space)||Input.GetKey(KeyCode.Z)||mouseFire);
    }
    public void ResetRun()
    {
        if(autopilot)autopilot.ResetPlanning();
        if(intro)intro.Cancel();
        if(player){player.CancelSpawn();player.ResetRunMotion();}
        Health=MaximumHealth;bombDamage.Clear();Level=1;Lives=3;Bombs=3;BombLevel=1;ChangeCharges=3;Score=0;SpeedLevel=1;Arms=Round1Arms.Red;
        HighScore=Mathf.Max(HighScore,PlayerPrefs.GetInt("TruxtonRemaster.HighScore",0));
        shotRemainder=0;homingCursor=0;cooldown=notification=bombTime=invincible=respawn=0;VolleysFired=0;GameOver=false;notice="";
        ClearBullets();if(bombVisual)bombVisual.SetActive(false);
        foreach(var pickup in powerups??System.Array.Empty<Round1Powerup>())if(pickup)pickup.ResetPickup();
        if(player){player.SpeedMultiplier=1;player.InputEnabled=true;lastStageTime=player.playback.elapsed;lastPlayerPosition=player.viewportPosition;SetShipVisible(true);}
        if(combat)combat.ResetCombat(player?player.playback.elapsed:0);else ResetEnemyDrops(player?player.playback.elapsed:0);
        ApplyShipUpgrades();PreviewPickups();
    }
    public void Restart(){player.playback.Seek(0);ResetRun();player.ResetPosition();player.playback.playing=true;if(intro)intro.Begin();else player.BeginSpawn();}
    public void ClearBullets()
    {
        foreach(var b in bullets){b.active=false;if(b.visual)b.visual.SetActive(false);}
        shotRemainder=0;cooldown=0;HideBeams();
    }
    public void OnTimelineSeek(float from,float to)
    {
        if(autopilot)autopilot.ResetPlanning();
        if(intro)intro.Cancel();
        if(to<from-.001f)ResetRun();
        else if(to-from>.5f){player.CancelSpawn();ClearBullets();if(combat)combat.ResetCombat(to);}
        lastStageTime=to;if(player)lastPlayerPosition=player.viewportPosition;PreviewPickups();
    }
    public void PreviewPickups()
    {
        if(!player)return;
        foreach(var pickup in powerups??System.Array.Empty<Round1Powerup>())if(pickup)
        {
            pickup.Evaluate(player.playback.elapsed);
            if(pickup.visual && pickup.showcase && intro && intro.HidesShowcase)pickup.visual.SetActive(false);
        }
    }
    public void Step(float deltaTime,bool firing)
    {
        Initialize();if(!initialized)return;
        float now=player.playback.elapsed;PreviewPickups();
        if(!SimulationRunning){Round1Sound.WeaponLoop(Arms,Level,false);PlaceBullets();lastStageTime=now;lastPlayerPosition=player.viewportPosition;return;}
        float dt=Mathf.Max(0,deltaTime);player.StepSpawn(dt);notification=Mathf.Max(0,notification-dt);invincible=Mathf.Max(0,invincible-dt);
        float bombDelta=Mathf.Min(dt,bombTime);
        if(bombTime>0)ApplyBombDamage(bombDelta);
        bombTime=Mathf.Max(0,bombTime-dt);UpdateBombVisual();
        if(respawn>0)
        {
            respawn=Mathf.Max(0,respawn-dt);
            if(respawn==0){Health=MaximumHealth;player.ResetPosition();player.InputEnabled=true;invincible=3;SetShipVisible(true);player.BeginSpawn(true);}
        }
        SetShipVisible(!Respawning && (player.SpawnAnimating || invincible<=0 || ((int)(invincible*12))%2==0));
        if(CanAct)
        {
            foreach(var pickup in powerups??System.Array.Empty<Round1Powerup>())
            {
                if(!pickup || !pickup.Available)continue;
                Vector2 current=player.viewportPosition-pickup.Position,previous=lastPlayerPosition-pickup.PositionAt(lastStageTime);
                if(!pickup.HasSpawned(lastStageTime))previous=current;
                current.x*=player.stageCamera.aspect;previous.x*=player.stageCamera.aspect;
                var v=current-previous;float t=v.sqrMagnitude>0?Mathf.Clamp01(-Vector2.Dot(previous,v)/v.sqrMagnitude):0;
                if((previous+v*t).sqrMagnitude<=pickup.Reach*pickup.Reach)pickup.Collect(this);
            }
        }
        AdvanceShotSimulation(dt,firing && CanAct);
        PlaceBullets();lastStageTime=now;lastPlayerPosition=player.viewportPosition;
    }
    public static bool IsLaser(Round1Arms arms)=>arms==Round1Arms.Blue || arms==Round1Arms.Gold || arms==Round1Arms.Black;
    public int CountShots(Round1Arms arms,int level)
    {
        if(rules==null && parameters)rules=Round1Rules.Read(parameters);
        if(rules==null)return 0;int count=0;foreach(var s in rules.tables[(int)arms].shots)if((s.mask&(1<<(Mathf.Clamp(level,1,4)-1)))!=0)count++;return count;
    }
    void PlaceBullets()
    {
        foreach(var b in bullets)if(b.active)
        {
            b.visual.transform.position=player.WorldPoint(b.position);
            b.visual.transform.rotation=player.stageCamera.transform.rotation*Quaternion.Euler(0,0,-Mathf.Atan2(b.velocity.x,b.velocity.y)*Mathf.Rad2Deg);
            b.visual.transform.localScale=BulletScale(b);
            ApplyBulletMaterial(b);
        }
        PlaceShotEffects();
    }
    void ApplyBulletMaterial(Bullet b)
    {
        tint.Clear();bool hasTexture=shotTextures!=null && shotTextures.Length>(int)b.kind && shotTextures[(int)b.kind];
        tint.SetColor("_BaseColor",hasTexture?Color.white:Tints[(int)b.kind]);
        if(hasTexture)tint.SetTexture("_BaseMap",shotTextures[(int)b.kind]);
        tint.SetVector("_BaseMap_ST",BulletFrame(b));b.renderer.SetPropertyBlock(tint);
    }
    public bool UseBomb()
    {
        Initialize();if(!CanAct || Bombs<=0 || BombActive)return false;
        var bombProfile=Round1Balance.Current.bombs[BombLevel-1];float damageScale=Round1Balance.Current.bombDamageScales[BombLevel-1];
        activeBombProfile=new Round1DamageProfile{first=bombProfile.first*damageScale,continuous=bombProfile.continuous*damageScale};
        Bombs--;Round1Sound.Bomb(BombLevel);bombTime=Round1Balance.Current.bombDuration;invincible=Mathf.Max(invincible,bombTime+.5f);
        bombDamage.Clear();ApplyBombDamage(0);Tell("BOMB LEVEL "+BombLevel);UpdateBombVisual();return true;
    }
    void ApplyBombDamage(float dt)
    {
        if(!combat)return;combat.ClearHostiles();bombDamage.Begin();
        foreach(var target in combat.Targets)bombDamage.Hit(combat,target,activeBombProfile,dt);
        bombDamage.End();
    }
    void UpdateBombVisual()
    {
        if(!bombVisual)return;bombVisual.SetActive(BombActive);if(!BombActive)return;
        bombVisual.transform.position=player.WorldPoint(new Vector2(.5f,.55f));bombVisual.transform.rotation=player.stageCamera.transform.rotation;
        float progress=1-bombTime/Round1Balance.Current.bombDuration;bombVisual.transform.localScale=Vector3.one*(18+progress*45+BombLevel*8);
        tint.Clear();tint.SetColor("_BaseColor",new Color(.7f,.85f,1,1-progress*.85f));foreach(var renderer in bombRenderers)renderer.SetPropertyBlock(tint);
    }
    public bool UseChange()
    {
        if(!CanAct || ChangeCharges<=0)return false;
        ChangeCharges--;SelectWeapon((Round1Arms)(((int)Arms+1)%7));return true;
    }
    public bool TakeHit()=>TakeDamage(Round1Balance.Current.hostileDamage);
    public bool TakeDamage(float damage)
    {
        if(!CanAct || Invincible || float.IsNaN(damage) || float.IsInfinity(damage) || damage<=0)return false;
        Health=Mathf.Max(0,Health-damage);if(Health>0)return false;
        Lives--;Round1Sound.Event("playerDead");ClearBullets();if(combat)combat.ClearHostiles();player.InputEnabled=false;SetShipVisible(false);if(combat)combat.effects.PlayerDestroyed(player.viewportPosition,player.playback.elapsed);
        if(Lives<=0){Lives=0;GameOver=true;player.playback.playing=false;Tell("GAME OVER");SaveHighScore();}
        else {respawn=1.2f;Level=Mathf.Max(1,Level-1);Bombs=Mathf.Max(Bombs,3);Tell("SHIP LOST");ApplyShipUpgrades();}
        return true;
    }
    void SetShipVisible(bool visible){if(player && player.bankingRoot)player.bankingRoot.gameObject.SetActive(visible);}
    public void AddScore(int value){if(value<=0)return;Score=(int)System.Math.Min(999999999L,(long)Score+value);HighScore=Mathf.Max(HighScore,Score);}
    void Tell(string message){notice=message;notification=2.2f;}
    public void Upgrade(){if(Level<4){Level++;Round1Sound.Event("powerUp");Tell("POWER UP");}else{AddScore(1000);Round1Sound.Event("powerFull");Tell("POWER MAX +1000");}ApplyShipUpgrades();}
    public void SelectWeapon(Round1Arms arms){if(Arms==arms)return;Arms=arms;Round1Sound.Event("weaponChange");cooldown=0;shotRemainder=0;HideBeams();Tell(PatternName);ApplyShipUpgrades();}
    public void ApplyPickup(Round1PickupKind kind)
    {
        Round1Sound.Pickup(kind);
        switch(kind)
        {
            case Round1PickupKind.Power:Upgrade();break;
            case Round1PickupKind.Bomber:BombLevel=Mathf.Min(3,BombLevel+2);Tell("BOMB LEVEL "+BombLevel);break;
            case Round1PickupKind.BombStock:Bombs=Mathf.Min(9,Bombs+2);Tell("BOMB STOCK +2");break;
            case Round1PickupKind.Change:ChangeCharges=Mathf.Min(99,ChangeCharges+1);Tell("CHANGE STOCK +1");break;
            case Round1PickupKind.OneUp:Lives=Mathf.Min(99,Lives+1);Tell("1UP");break;
            case Round1PickupKind.TwoUp:Lives=Mathf.Min(99,Lives+2);Tell("2UP");break;
            case Round1PickupKind.ThreeUp:Lives=Mathf.Min(99,Lives+3);Tell("3UP");break;
            case Round1PickupKind.Bonus:AddScore(5000);Tell("BONUS +5000");break;
            case Round1PickupKind.Points1:AddScore(1000);Tell("+1000");break;
            case Round1PickupKind.Points2:AddScore(5000);Tell("+5000");break;
            case Round1PickupKind.SpeedUp:SpeedLevel=Mathf.Min(6,SpeedLevel+1);Tell("SPEED "+SpeedLevel);break;
            case Round1PickupKind.SpeedDown:SpeedLevel=Mathf.Max(1,SpeedLevel-1);Tell("SPEED "+SpeedLevel);break;
            default:if(System.Enum.TryParse(kind.ToString(),out Round1Arms arms))SelectWeapon(arms);break;
        }
        if(player)player.SpeedMultiplier=rules!=null?rules.speeds[SpeedLevel-1]:1+(SpeedLevel-1)*.4f;
    }
    // Original PlayerControll._playerOptionDisplay: power level 3 shows one option pod per side (option01L1/R1), level 4
    // both (L2/R2 too). The upgrade parts (_upgradeParts a, b) follow PlayerInformation.AwakenBody, not the power level.
    // The ship, its pods and upgrade parts take the weapon's colour (Variant_red/green/...).
    [Range(0,2)] public int awakenBody;
    public int OptionsPerSide=>Mathf.Clamp(Level-2,0,2);
    Renderer[] shipRenderers,optionRenderers,upgradeRenderers;
    public void ApplyShipUpgrades()
    {
        if(!player)return;var root=player.transform.Find("proot/modelTop/pf_player01");var opt=player.transform.Find("proot/opt");if(!root || !opt)return;
        var a=root.Find("pf_player01_upgrade_a");var b=root.Find("pf_player01_upgrade_b");
        if(a)a.gameObject.SetActive(awakenBody>=1);if(b)b.gameObject.SetActive(awakenBody>=2);
        opt.gameObject.SetActive(true);
        for(int i=0;i<2;i++)foreach(var side in new[]{"L","R"})
        {
            var pod=opt.Find("option01"+side+(i+1));if(!pod)continue;bool show=i<OptionsPerSide;
            if(pod.gameObject.activeSelf==show)continue;pod.gameObject.SetActive(show);
            if(show)foreach(var ps in pod.GetComponentsInChildren<ParticleSystem>(true)){ps.Clear(true);ps.Play(true);}
        }
        var skins=Round1ShipSkins.Current;if(!skins)return;int colour=(int)Arms;
        if(shipRenderers==null){shipRenderers=ShipMeshes(root,"Player01",true);optionRenderers=ShipMeshes(opt,"Player01_Op",true);upgradeRenderers=ShipMeshes(root,"player01_upgrade",false);}
        foreach(var r in shipRenderers)r.sharedMaterial=skins.ship[colour];
        foreach(var r in optionRenderers)r.sharedMaterial=skins.option[colour];
        foreach(var r in upgradeRenderers)r.sharedMaterial=skins.upgrade[colour];
    }
    static Renderer[] ShipMeshes(Transform root,string name,bool exact)
    {
        var list=new List<Renderer>();
        foreach(var r in root.GetComponentsInChildren<MeshRenderer>(true))if(exact?r.name==name:r.name.StartsWith(name))list.Add(r);
        return list.ToArray();
    }
    void SaveHighScore(){if(persistHighScore && Application.isPlaying){PlayerPrefs.SetInt("TruxtonRemaster.HighScore",HighScore);PlayerPrefs.Save();}}
    public void ReleasePool()
    {
        if(poolRoot){if(Application.isPlaying)Destroy(poolRoot.gameObject);else DestroyImmediate(poolRoot.gameObject);}
        if(lineMaterial){if(Application.isPlaying)Destroy(lineMaterial);else DestroyImmediate(lineMaterial);}
        ReleaseShotLook();
        poolRoot=null;bombVisual=null;bullets.Clear();beams.Clear();beamDamage.Clear();bombDamage.Clear();initialized=false;
    }
    void OnDestroy(){SaveHighScore();ReleasePool();}
}
