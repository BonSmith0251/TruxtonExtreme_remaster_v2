using System.Collections.Generic;
using UnityEngine;

// Ene_Bos03, the BG03 boss, from the native code (extractor/story-stage01/bos03/SPEC.md; addresses there).
// The BG03 timeline enters tt_boss03 at 420 s. Positions are source sky-plane units (x right, z up the screen,
// y toward the camera), placed with the enemy layer's ToViewport mapping. Marked [I] where the spec infers.
[DefaultExecutionOrder(160)]
public class Round1Boss : MonoBehaviour
{
    public enum EncounterState { Waiting, Warning, Entering, Fighting, Defeating, Cleared }
    public enum NativeState { EntryWait, PT1, Summon, Destruction }
    public Round1Combat combat;
    public GameObject bossPrefab,explosionPrefab,summonPrefab;
    public AnimationClip entrance;
    public float warningTime=418,spawnTime=420,loopStart=480,loopEnd=540;
    public float maximumHealth=1000000,partHealth=100000,modelScale=.3f,hitRadius=.12f,partRadius=.05f;
    public Vector3 modelCenter;
    public EncounterState State { get; private set; }
    public NativeState Native { get; private set; }
    public Round1Combat.Target Target { get; private set; }
    public bool StageCleared => State==EncounterState.Cleared;
    public bool SuppressesWaves => StageCleared || StageTime>=warningTime || State!=EncounterState.Waiting;
    public bool ShowGauge => State==EncounterState.Warning || State==EncounterState.Entering || State==EncounterState.Fighting || State==EncounterState.Defeating;
    public bool HoldsStage => !StageCleared && StageTime>=warningTime;
    public float HealthRatio => Target==null?1:Mathf.Clamp01(Target.health/maximumHealth);
    // Ene_BosBase.hpRateRanges; _hpState is the first i with rate > ranges[i] (FullHP 0 ... LessHP 7).
    static readonly float[] HpRateRanges={.9f,.75f,.51f,.4f,.3f,.2f,.1f,0};
    public int HpState { get { float r=HealthRatio;for(int i=0;i<HpRateRanges.Length;i++)if(r>HpRateRanges[i])return i;return HpRateRanges.Length-1; } }
    public float EncounterAge { get; private set; }
    public float BossTime { get; private set; }
    public int AttackVolleys { get; private set; }
    public int SummonedDrones { get; private set; }
    public bool CoverOpen => coverOpen;
    public bool ArmLBroken => armLBreak;
    public bool ArmRBroken => armRBreak;
    public bool LaserFiring => laserFire;
    public GameObject Visual => visual;

    // Ene_Bos03..cctor (0x1d85560).
    static readonly Vector3 RestPosition=new Vector3(0,0,35),SummonPosition=new Vector3(0,-80,50),SummonOffset=new Vector3(0,100,0);
    static readonly Vector3 LeftMoveOffset=new Vector3(50,0,10),RightMoveOffset=new Vector3(-50,0,10);
    static readonly Quaternion BasicRotate=Quaternion.Euler(0,180,0),SummonRotate=Quaternion.Euler(45,180,0);
    const float EntryNoHitTime=2.5f,EntryEndWait=1,OneWayMoveDuration=3,OneWayMoveWait=1,SummonSeconds=5;
    const float SummonCallStory=5f/35,SummonCallArcade=5f/50,CoverClosedFireInterval=2.5f,CoverOpenFireInterval=2;
    // Boss03MZ order; GetSmallBombPosition and every _callBT index this list.
    static readonly string[] MuzzleNames={"muzzle_body70","muzzle_body80","muzzle_body90","muzzle_arm40","muzzle_arm60","muzzle_body20","muzzle_body40","muzzle_body60",
        "muzzle_battery40","muzzle_battery60","muzzle_shoulder40","muzzle_shoulder40e","muzzle_shoulder60","muzzle_shoulder60e"};
    const int Body70=0,Body80=1,Body90=2,Arm40=3,Arm60=4,Body20=5,Body40=6,Body60=7,Battery40=8,Battery60=9,Shoulder40=10,Shoulder40e=11,Shoulder60=12,Shoulder60e=13;
    const string BT="bos03_";

    GameObject visual,explosion;
    Renderer[] explosionRenderers,renderers;
    Color[] baseColors;
    MaterialPropertyBlock fade,tint;
    readonly Transform[] muzzles=new Transform[MuzzleNames.Length];
    Transform shoulder40,shoulder60,armLNode,armRNode,coverNode;
    Round1Combat.Target armL,armR,cover;
    readonly List<Round1Combat.Target> drones=new List<Round1Combat.Target>();
    readonly List<Drone> droneMotion=new List<Drone>();
    class Drone { public Round1Combat.Target target;public Vector3 position,heading;public float timer,homing,depth=-80;public int state,steps; }

    Vector3 root,entryOffset;Quaternion modelRotation=BasicRotate,rootRotation=Quaternion.identity,turn=Quaternion.identity;
    int mode;float localTime,deathTime,darkFrom,darkTo,darkTime,darkDuration=.1f;
    bool coverOpen,laserFire,armLBreak,armRBreak,shoulderTurn,leftRound,backMove,rightMove,noHit,woke;
    float moveTime,laserArcRate;int openedAttackCount,attackLoopCount;Vector3 moveStart;
    float repeatTimer=CoverClosedFireInterval,repeatPassed;int repeatTimes;bool repeatLaped;
    float directionTotal=1,directionPassed;bool timerStarted;
    Quaternion startAngle,targetAngle;Vector3 startVector,targetVector,startInGamePosition=RestPosition;
    Quaternion turnTarget=Quaternion.identity;float turnTime,turnDuration;
    float smallBombBase,smallBombNext;
    readonly List<GameObject> smoke=new List<GameObject>();

    float StageTime => combat && combat.weapon && combat.weapon.player?combat.weapon.player.playback.elapsed:0;
    Round1PlayerController Player => combat.weapon.player;
    bool Story => !combat.sourceAttacks || combat.sourceAttacks.selectorMode==Round1EnemyAttacks.StorySelectorMode;
    void LateUpdate()
    {
        if(Input.GetKeyDown(KeyCode.F3) && combat.weapon.CanAct)JumpToEncounter();
        Step(Time.deltaTime);
    }
    public void JumpToEncounter()
    {
        if(!combat.weapon.CanAct)return;
        Player.playback.Seek(warningTime);combat.ResetCombat(warningTime);Step(0);
    }
    public float PresentationTime(float timelineTime)
    {
        if(!HoldsStage || timelineTime<loopStart)return timelineTime;
        // Loop the camera/visibility presentation without rewinding gameplay state.
        float offset=Mathf.Max(timelineTime-loopStart,EncounterAge-(loopStart-spawnTime));
        return loopStart+Mathf.Repeat(offset,loopEnd-loopStart-.02f);
    }
    public void Step(float deltaTime)
    {
        if(!combat || !combat.weapon.SimulationRunning)return;
        float dt=Mathf.Max(0,deltaTime);
        if(State==EncounterState.Waiting && StageTime>=warningTime)
        {State=EncounterState.Warning;combat.ClearRegularEnemies();}
        if((State==EncounterState.Warning || State==EncounterState.Waiting) && StageTime>=spawnTime)Spawn();
        StepDamageSmoke();
        if(State==EncounterState.Entering || State==EncounterState.Fighting || State==EncounterState.Defeating)
        {
            EncounterAge+=dt;
            ProgressBossTimer(dt);
            switch(Native)
            {
                case NativeState.EntryWait:EntryWait(dt);break;
                case NativeState.PT1:if(turnTime<=0)CheckCoverBreak(false);PT1(dt);break;
                case NativeState.Summon:SummonStep(dt);break;
                case NativeState.Destruction:Destruction(dt);break;
            }
            StepTurn(dt);StepDark(dt);StepDrones(dt);
            if(State!=EncounterState.Cleared)PlaceVisual();
            if(Target!=null && Native!=NativeState.Destruction)Round1TrackCapture.Active?.Record(Target.id,StageTime,root+LayerOffset,modelRotation*turn);
        }
    }

    // ---- Ene_BosBase timers (ProgressBossTimer 0x1dba1d0) ----
    void ProgressBossTimer(float dt)
    {
        repeatLaped=false;repeatPassed+=dt;
        if(repeatPassed>=repeatTimer){repeatLaped=true;repeatPassed-=repeatTimer;repeatTimes++;}
        directionPassed+=dt;
        if(timerStarted && Native!=NativeState.Destruction)BossTime+=dt;
    }
    void SetRepeatTime(float seconds){repeatTimer=Mathf.Max(1f/60,seconds);repeatPassed=0;repeatTimes=0;}
    void SetDirectionTime(float seconds){directionTotal=Mathf.Max(.001f,seconds);directionPassed=0;}
    float DirectionRate=>Mathf.Clamp01(directionPassed/directionTotal);
    int ActStep=>Mathf.FloorToInt(BossTime/10);

    // ---- EntryWait (0x1d82fd0) ----
    void EntryWait(float dt)
    {
        float duration=entrance?entrance.length:5;
        if(mode<3)
        {
            // The entrance clip drives modelTop; its translation is carried by the root placement here.
            if(entrance){entrance.SampleAnimation(visual,Mathf.Min(EncounterAge,duration));entryOffset=visual.transform.localPosition;modelRotation=visual.transform.localRotation;}
        }
        localTime+=dt;
        if(mode==1 && localTime>=EntryNoHitTime)mode=2; // Collision on; still OffLockon|NoDamaged.
        if(mode==2 && EncounterAge>=duration)
        {
            entryOffset=Vector3.zero;modelRotation=BasicRotate;SetSmoke(false);localTime=0;mode=3;
        }
        if(mode==3 && localTime>=EntryEndWait)
        {
            SetVulnerable(true);timerStarted=true;BossTime=0;startInGamePosition=root;
            State=EncounterState.Fighting;SetNative(NativeState.PT1);
        }
    }

    // ---- PT1 (0x1d832c0) ----
    void PT1(float dt)
    {
        switch(mode)
        {
            case 0:mode=coverOpen?20:10;break;
            case 10:
                MoveReset();attackLoopCount=3;SetRepeatTime(CoverClosedFireInterval);FireTurretShortLaser();mode=11;break;
            case 11:
                if(!Move(dt))FireBasicSet();
                // IsAttackLoop pre-decrements: SetLoopCount(2,3) gives 3, so three swings (24 s) per closed cycle.
                else{MoveReset();if(!(--attackLoopCount>0 && !coverOpen))mode=100;}
                break;
            case 20:
                if(turnTime>0)break;
                MoveReset();FireShoulderLaser();SetRepeatTime(CoverOpenFireInterval);mode=(openedAttackCount&1)!=0?40:30;break;
            case 30:FireTurretShortLaser();localTime=2;mode=31;break;
            case 31:localTime-=dt;if(localTime<=0){FireRoundShortLaser();mode=32;}break;
            case 32:Move(dt);if(ArcClose(dt))mode=33;break;
            case 33:FireBasicSet();if(Move(dt))mode=100;break;
            case 40:FireSideArm();localTime=3;mode=41;break;
            case 41:Move(dt);localTime-=dt;if(localTime<=0)mode=42;break;
            case 42:{Move(dt);bool a=ArcClose(dt),b=FireBasicSet();if(a && b)mode=43;break;}
            case 43:FireBasicSet();if(Move(dt))mode=44;break;
            case 44:FireBasicSet();if(!ArcBack(dt))mode=100;break;
            case 100:
                if(!laserFire)localTime=0;
                else{if(coverOpen)openedAttackCount++;combat.sourceAttacks?.CancelBeams(Target);laserFire=false;localTime=ActStep>=12?1:1.5f;}
                mode=101;break;
            case 101:
                localTime-=dt;
                if(localTime<=0 && !ArcBack(dt)){if(!coverOpen)SetNative(NativeState.Summon);else mode=0;}
                break;
        }
    }
    // Bos03Move (0x1d84a90): InOutSine over 3 s, held until 4 s, back over 3 s (8 s with the clamped hold); true when done.
    bool Move(float dt)
    {
        moveTime+=backMove?-dt:dt;
        float e=-(Mathf.Cos(Mathf.PI*Mathf.Clamp01(moveTime/OneWayMoveDuration))-1)/2;
        root=moveStart+Vector3.Lerp(Vector3.zero,rightMove?RightMoveOffset:LeftMoveOffset,e);
        // Turning back keeps _moveTime, so the clamped ease holds the end for another second on the way down.
        if(!backMove && moveTime>=OneWayMoveDuration+OneWayMoveWait)backMove=true;
        if(backMove && moveTime<=0){backMove=false;moveTime=0;rightMove=!rightMove;return true;}
        return false;
    }
    void MoveReset(){moveStart=root;backMove=false;moveTime=0;}
    // FireBasicSet (0x1d84db0): one set per repeat lap, chosen by repeat count & 3.
    bool FireBasicSet()
    {
        if(!repeatLaped)return false;
        switch(repeatTimes&3)
        {
            case 1:if(coverOpen)FireRoundShortLaser();else FireTurretShortLaser();break;
            case 2:if(!laserFire){Fire("7way",Shoulder40);Fire("7way",Shoulder60);break;}goto case 3;
            case 3:Fire("rap3",Body70);Fire("rap3",Body90);break;
            default:Fire("7way",Body80);break;
        }
        return true;
    }
    void FireTurretShortLaser(){FireTracking("turret0",Battery60);FireTracking("turret0",Battery40);}
    // IsEasyMode (Story or Tutorial) fires one spiral of the three; the first call fires the R side.
    void FireRoundShortLaser()
    {
        string side=leftRound?"faceL":"faceR";
        if(Story)Fire(side+"3",Body20);else{Fire(side+"1",Body20);Fire(side+"2",Body20);Fire(side+"3",Body20);}
        leftRound=!leftRound;
    }
    void FireSideArm()
    {
        float x=PlayerSourceX(),angle=Mathf.Abs(x)<100?0:x<0?-40:40;
        if(!armLBreak)Fire("arm0",Arm60,angle);else Fire("sidewayL",Body60);
        if(!armRBreak)Fire("arm0",Arm40,angle);else Fire("sidewayR",Body40);
    }
    void FireShoulderLaser()
    {
        if(!coverOpen || laserFire)return;
        combat.sourceAttacks?.FireBoss(Target,BT+"las00",muzzles[Shoulder40],0,muzzles[Shoulder40e]);
        combat.sourceAttacks?.FireBoss(Target,BT+"las00",muzzles[Shoulder60],0,muzzles[Shoulder60e]);
        laserFire=true;AttackVolleys++;
    }
    bool ArcClose(float dt)
    {
        if(!(armLBreak && armRBreak) || shoulderTurn || openedAttackCount<1)return true;
        laserArcRate=Mathf.Clamp01(laserArcRate+dt);SetShoulders();
        if(laserArcRate>=1){shoulderTurn=true;return true;}
        return false;
    }
    bool ArcBack(float dt)
    {
        if(!shoulderTurn)return false;
        laserArcRate=Mathf.Clamp01(laserArcRate-dt);SetShoulders();
        if(laserArcRate<=0)shoulderTurn=false;
        return shoulderTurn;
    }
    void SetShoulders()
    {
        if(shoulder40)shoulder40.localRotation=Quaternion.Euler(0,25*laserArcRate,0);
        if(shoulder60)shoulder60.localRotation=Quaternion.Euler(0,-25*laserArcRate,0);
    }
    void Fire(string name,int muzzle,float angle=0)
    {
        if(!muzzles[muzzle] || combat.sourceAttacks==null)return;
        combat.sourceAttacks.FireBoss(Target,BT+name,muzzles[muzzle],angle);AttackVolleys++;
    }
    // [I] EnemyTurret batteries track the player; turret0 then fires along the battery. The 120 deg/s turn and the
    // per-battery yaw range are approximated by aiming at the player within 90 degrees of straight down.
    void FireTracking(string name,int muzzle)
    {
        if(!muzzles[muzzle] || combat.sourceAttacks==null)return;
        Vector2 from=Player.stageCamera.WorldToViewportPoint(muzzles[muzzle].position),aim=Player.viewportPosition-from;aim.x*=Player.stageCamera.aspect;
        float angle=Mathf.Clamp(Mathf.DeltaAngle(270,Mathf.Atan2(aim.y,aim.x)*Mathf.Rad2Deg),-90,90);
        combat.sourceAttacks.FireBoss(Target,BT+name,muzzles[muzzle],angle-SelfDirAngle(muzzles[muzzle]));AttackVolleys++;
    }
    // turret0 is isSelfDir: Round1EnemyAttacks adds the muzzle's on-screen heading; remove it so the aim above holds.
    float SelfDirAngle(Transform muzzle)
    {
        var cam=Player.stageCamera.transform;var f=muzzle.forward;
        return Mathf.Atan2(Vector3.Dot(f,cam.up),Vector3.Dot(f,cam.right))*Mathf.Rad2Deg+90;
    }
    float PlayerSourceX()=>(Player.viewportPosition.x-.5f)*200*Player.stageCamera.aspect;

    // ---- Cover and parts (CheckCoverBreak 0x1d82000, OnPartsBreak 0x1d82800) ----
    void CheckCoverBreak(bool force)
    {
        if(coverOpen)return;
        if(!(force || HpState>=3 || ActStep>=9 || (armLBreak && armRBreak)))return;
        if(cover!=null && cover.active){cover.active=false;HideParts(coverNode);}
        openedAttackCount=0;coverOpen=true;
    }
    // Checker fixture: open the cover as the HP <= 51% rule does, for replays that cannot reproduce the damage.
    public void ForceCoverOpen(){if(Native==NativeState.PT1 && !coverOpen)CheckCoverBreak(true);}
    public void OnPartBroken(Round1Combat.Target part)
    {
        // PartsList BreakEffect: armL, armR and cover each break with pf_eff_explposion03 where they were.
        if(part==armL){armLBreak=true;Boom(PartBreak,armLNode);HideParts(armLNode);DamageTurn(Quaternion.Euler(-10,-5,0),2);}
        else if(part==armR){armRBreak=true;Boom(PartBreak,armRNode);HideParts(armRNode);DamageTurn(Quaternion.Euler(-10,5,0),2);}
        else if(part==cover){Round1Sound.Event("bossCoverBreak");Boom(PartBreak,coverNode);HideParts(coverNode);CheckCoverBreak(true);DamageTurn(Quaternion.Euler(-20,0,0),1);}
    }
    // Original destruction effects (Ene_Bos03 PartsList / _deadExplosion, PatternMoveDestruction 0x1d82910 through
    // Ene_BosBase.SkyExplosionEffect(tcode, worldPos, layer, seID) with ShortCutEffect.ExplosionCodeSmall/Middle).
    const string PartBreak="pf_eff_explposion03",DestructionOpen="pf_eff_explposion02",DestructionSmall="pf_eff_explposion01",DeadExplosion="pf_eff_explposion_boss";
    const string SmallBombSound="exp_st3_boss_a01"; // seID 40
    const float DeadExplosionUp=20; // _explosionOffset (0, 20, 0)
    float Unit=>Vector3.Distance(Player.WorldPoint(Vector2.zero),Player.WorldPoint(Vector2.up))/200;
    void Boom(string effect,Transform at){if(at)Boom(effect,at.position);}
    void Boom(string effect,Vector3 world){combat.effects.Play(effect,world,Player.stageCamera.transform.rotation*Quaternion.Euler(-90,0,0),Unit,Player.playback.elapsed);}
    // EnePartsGroup._damageObject (bs03_body/damage): its smoke runs once the body is below the 0.5 damage blink rate.
    Transform damageNode;bool damageShown;
    void StepDamageSmoke()
    {
        bool show=Target!=null && Target.active && maximumHealth>0 && Target.health<maximumHealth*.5f && State!=EncounterState.Defeating;
        if(show==damageShown || !damageNode)return;damageShown=show;
        damageNode.gameObject.SetActive(show); // the node itself is inactive in the prefab (SetDamageEffect activates it)
        foreach(var ps in damageNode.GetComponentsInChildren<ParticleSystem>(true)){ps.gameObject.SetActive(show);if(show)ps.Play(true);}
    }
    // [I] DamageTurn: the model tips to the given rotation and back over the duration.
    void DamageTurn(Quaternion to,float seconds){turnTarget=to;turnDuration=seconds;turnTime=seconds;}
    void StepTurn(float dt)
    {
        if(turnTime<=0){turn=Quaternion.identity;return;}
        turnTime=Mathf.Max(0,turnTime-dt);turn=Quaternion.Slerp(Quaternion.identity,turnTarget,Mathf.Sin(Mathf.PI*(1-turnTime/turnDuration)));
    }
    static void HideParts(Transform node){if(node)foreach(var r in node.GetComponentsInChildren<Renderer>(true))r.enabled=false;}
    void SetVulnerable(bool on)
    {
        if(Target!=null)Target.invulnerable=!on;
        foreach(var p in new[]{armL,armR,cover})if(p!=null)p.invulnerable=!on;
    }

    // ---- PT5Summon (0x1d83940) ----
    void SummonStep(float dt)
    {
        switch(mode)
        {
            case 0:
                Dark(true,.1f);SetVulnerable(false);noHit=true;
                startAngle=modelRotation;targetAngle=SummonRotate;startVector=root;targetVector=SummonPosition;localTime=0;mode=1;break;
            case 1:
            {
                localTime+=dt;float r=Mathf.Clamp01(localTime/1.5f);
                root=Vector3.LerpUnclamped(startVector,targetVector,EaseOut(r));modelRotation=Quaternion.Lerp(startAngle,targetAngle,Mathf.Clamp01(2*r));
                if(r>=1){localTime=1;mode=10;}
                break;
            }
            case 10:
                localTime-=dt;
                if(localTime<0){SetDirectionTime(SummonSeconds);SetRepeatTime(Story?SummonCallStory:SummonCallArcade);mode=20;}
                break;
            case 20:
                if(DirectionRate<1){if(repeatLaped)SpawnDrone(SummonOffset+SummonPosition+new Vector3(0,-100,0));}
                else{localTime=1;mode=30;}
                break;
            case 30:
                localTime-=dt;
                if(localTime<=0){startAngle=modelRotation;targetAngle=BasicRotate;startVector=SummonPosition;targetVector=startInGamePosition;localTime=0;woke=false;mode=31;}
                break;
            case 31:
            {
                localTime+=dt;
                if(!woke && localTime>=.5f){woke=true;SetVulnerable(true);Dark(false,.25f);noHit=false;}
                float r=Mathf.Clamp01(localTime/1.5f);
                root=Vector3.LerpUnclamped(startVector,targetVector,EaseOut(r));modelRotation=Quaternion.Lerp(startAngle,targetAngle,r);
                if(r>=1)mode=32;
                break;
            }
            case 32:SetNative(NativeState.PT1);break;
        }
    }
    static float EaseOut(float t)=>1-(1-t)*(1-t);
    static float EaseIn(float t)=>t*t;
    // Ene_Sd02 (_moveState 0x1cfe0d0), checked against recordings/ash-r1-summon-world-20261027 (34 drones, transform
    // localPosition/forward and GetPlayerPosition recorded): spawned at ene_sd02.startPosition (0,-100,0) + the call
    // offset = the boss mouth (0,-80,50), parented to the enemy layer (localPosition is layer-local).
    // State 1 deploys 1.10 s at DeploySpeed 100 on a random heading within 45 degrees of straight up, 80 units below the
    // plane and not hittable. State 2 snaps onto the plane and turns at once (RotateTowards, 360 rad) to
    // GetPlayerPosition - localPosition; it waits 0.2 s. GetPlayerPosition is the player plus PlayerTargetOffset (0,0,1)
    // and ignores the layer shift. State 3 flies at AttackSpeed 300 and homes 2 degrees every other frame for 50 steps.
    // Its IsGameArea test reads localPosition as a world point, which is never on screen, so the drone is removed
    // 2.0 s into the attack (3.3 s after spawn).
    const float DroneDeploy=1.1f,DroneHold=.2f,DroneDeploySpeed=100,DroneAttackSpeed=300,DroneHomingStep=2,DroneAttackLife=2;
    const int DroneHomingSteps=50;
    // Checker fixture: the original's random deploy yaws (degrees, one per drone in spawn order) so paths can be compared.
    public static float[] DroneYawOverride;
    void SpawnDrone(Vector3 source)
    {
        var prefab=summonPrefab;if(!prefab)return;
        var start=new Vector3(source.x,0,source.z);
        var t=combat.SpawnSourceTarget(prefab,ToViewport(start+LayerOffset),Round1Balance.Current.EnemyHealth("Pf_Ene_Sd01"));if(t==null)return;
        t.sourceSpawn=true;t.stationary=true;t.fires=false;t.radius=.022f;t.invulnerable=true;t.lockOn=false;
        t.sourceScale=Vector3.Distance(Player.WorldPoint(Vector2.zero),Player.WorldPoint(Vector2.up))/200;
        float yaw=(DroneYawOverride!=null && SummonedDrones<DroneYawOverride.Length?DroneYawOverride[SummonedDrones]:(Random01(SummonedDrones)-.5f)*90)*Mathf.Deg2Rad;
        droneMotion.Add(new Drone{target=t,position=start,heading=new Vector3(Mathf.Sin(yaw),0,Mathf.Cos(yaw))});
        Round1TrackCapture.Active?.BirthUnscheduled(t.id,"ene_sd02","Pf_Ene_Sd02",StageTime,t.health);
        SummonedDrones++;
    }
    // Frame-stepped like _moveState: state 0 is the spawn frame (no move), each later state keeps its own float timer.
    void StepDrones(float dt)
    {
        for(int i=droneMotion.Count-1;i>=0;i--)
        {
            var d=droneMotion[i];var t=d.target;
            if(!t.active){Round1TrackCapture.Active?.End(t.id,true);droneMotion.RemoveAt(i);continue;}
            var player=Round1Sa01Motion.PlayerFromViewport(Player.viewportPosition,Player.stageCamera.aspect)+Vector3.forward;player.y=0;
            var want=player-d.position;want.y=0;want=want.sqrMagnitude>1e-6f?want.normalized:d.heading;
            float speed=0;
            switch(d.state)
            {
                case 0:d.state=1;break;
                case 1:
                    d.timer+=dt;speed=DroneDeploySpeed;
                    if(d.timer>=DroneDeploy){d.state=2;d.timer=0;d.depth=0;}
                    break;
                case 2:
                    if(d.timer==0){d.heading=want;t.invulnerable=false;t.lockOn=true;}
                    d.timer+=dt;
                    if(d.timer>=DroneHold){d.state=3;d.timer=0;d.homing=.01f;d.steps=DroneHomingSteps;}
                    break;
                default:
                    // _homing timers +0x1c4/+0x1c8: a step while positive, then 0.01 s again once below -0.01, i.e. every other frame.
                    // VectorUtility.HomingDirection: rotate by the full step to whichever side ends closer to the target.
                    if(d.homing>0 && d.steps>0)
                    {
                        var left=Quaternion.AngleAxis(-DroneHomingStep,Vector3.up)*d.heading;var right=Quaternion.AngleAxis(DroneHomingStep,Vector3.up)*d.heading;
                        d.heading=(Vector3.Dot(left,want)>=Vector3.Dot(right,want)?left:right).normalized;
                    }
                    d.homing-=dt;if(d.homing<=-.01f){d.steps--;d.homing=.01f;}
                    speed=DroneAttackSpeed;d.timer+=dt;
                    break;
            }
            d.position+=d.heading*speed*dt;
            var shown=d.position+LayerOffset;t.position=ToViewport(shown)+t.nudge;t.sourceRotation=Quaternion.LookRotation(d.heading,Vector3.up);
            Round1TrackCapture.Active?.Record(t.id,StageTime,new Vector3(shown.x,d.depth,shown.z),t.sourceRotation);
            if(d.state==3 && d.timer>DroneAttackLife){Round1TrackCapture.Active?.End(t.id,false);combat.DespawnSourceTarget(t);droneMotion.RemoveAt(i);}
        }
    }
    static float Random01(int n){unchecked{uint h=(uint)(n*2654435761u+3101);h^=h>>15;h*=2246822519u;h^=h>>13;return (h%10000)/10000f;}}

    // ---- Destruction (ToDestroid 0x1d84980, PatternMoveDestruction 0x1d82910) ----
    public void OnDefeated()
    {
        if(State==EncounterState.Defeating || StageCleared)return;
        State=EncounterState.Defeating;deathTime=0;combat.ClearHostiles();Round1Sound.Event("bossDefeat");if(visual)visual.SetActive(true); // Combat hid it with the body target.
        StepDamageSmoke();
        foreach(var p in new[]{armL,armR,cover})if(p!=null)p.active=false;
        if(Target!=null)Round1TrackCapture.Active?.End(Target.id,true);
        SetNative(NativeState.Destruction);
    }
    void Destruction(float dt)
    {
        deathTime+=dt;combat.ClearHostiles();
        if(mode==0)
        {
            startVector=root;targetVector=root+new Vector3(0,-150,0);startAngle=rootRotation;targetAngle=Quaternion.Euler(45,45,0);
            // Four ExplosionCodeMiddle blasts on the body, without sound, as the destruction starts.
            for(int i=0;i<4;i++)Boom(DestructionOpen,RandomMuzzle(i));
            smallBombBase=.2f;smallBombNext=deathTime+smallBombBase;SetDirectionTime(5.5f);localTime=3.5f;mode=10;
        }
        // BreakParts on the shoulders: their BreakEffect at their explosion roots (bs03_shoulder40/60).
        if(mode==10 && localTime<=1){Boom(PartBreak,shoulder40);Boom(PartBreak,shoulder60);HideParts(shoulder40);HideParts(shoulder60);mode=11;}
        root=Vector3.LerpUnclamped(startVector,targetVector,EaseIn(DirectionRate));rootRotation=Quaternion.Lerp(startAngle,targetAngle,DirectionRate);
        if(deathTime>=smallBombNext){SmallBomb();smallBombNext=deathTime+smallBombBase+Random01(Mathf.RoundToInt(deathTime*997))*.1f;smallBombBase*=.9f;}
        localTime-=dt;
        if(mode<20 && localTime<=0)
        {
            // ToDestroid → _callDeadEffect: the model goes in pf_eff_explposion_boss (20 up) with its death sound; the
            // stage clears once the blast has had its 2 s.
            localTime=2;mode=20;
            Boom(DeadExplosion,transform.position+transform.rotation*Vector3.up*(DeadExplosionUp*Unit));
            Round1Sound.Dead("Pf_Ene_Bos03",DeadExplosion);
            if(visual)visual.SetActive(false);
        }
        else if(mode==20 && localTime<=0)
        {
            if(visual)visual.SetActive(false);if(explosion)explosion.SetActive(false);
            State=EncounterState.Cleared;combat.weapon.ClearBullets();Player.playback.playing=false;Player.InputEnabled=false;
        }
    }
    Transform RandomMuzzle(int salt)=>muzzles[Mathf.Min(MuzzleNames.Length-2,Mathf.FloorToInt(Random01(Mathf.RoundToInt(deathTime*1000)+7+salt*131)*13))];
    // SkyExplosionEffect(ExplosionCodeSmall, a point on the body, layer, seID 40): a small blast with the boss blast sound.
    void SmallBomb()
    {
        var m=RandomMuzzle(0);if(!m)return;
        Boom(DestructionSmall,m);Round1Sound.Play(SmallBombSound);
    }

    // ---- Spawn, placement, presentation ----
    void Spawn()
    {
        maximumHealth=Round1Balance.Current.bossHealth;
        if(!bossPrefab)return;
        // Pf_Ene_Sd02 shares Sd01's model and database HP (Sd02 aliases Sd01).
        if(!summonPrefab && combat.sourceWaves && combat.sourceWaves.visuals!=null)summonPrefab=System.Array.Find(combat.sourceWaves.visuals,v=>v.name=="Pf_Ene_Sd01")?.prefab;
        combat.ClearRegularEnemies();
        if(!visual)
        {
            visual=Instantiate(bossPrefab,transform);visual.name="Round 1 boss03 visual";
            foreach(var animator in visual.GetComponentsInChildren<Animator>(true))animator.enabled=false;
            foreach(var ps in visual.GetComponentsInChildren<ParticleSystem>(true)){ps.gameObject.SetActive(false);if(ps.name.ToLowerInvariant().Contains("smoke") || ps.name.ToLowerInvariant().Contains("steam"))smoke.Add(ps.gameObject);}
            foreach(var collider in visual.GetComponentsInChildren<Collider>(true))collider.enabled=false;
            for(int i=0;i<MuzzleNames.Length;i++)muzzles[i]=Find(visual.transform,MuzzleNames[i]);
            shoulder40=Find(visual.transform,"bs03_shoulder40");shoulder60=Find(visual.transform,"bs03_shoulder60");
            armLNode=Find(visual.transform,"bs03_arm60");armRNode=Find(visual.transform,"bs03_arm40");coverNode=Find(visual.transform,"bs03_cover");
            damageNode=Find(visual.transform,"damage");
            renderers=visual.GetComponentsInChildren<Renderer>(true);baseColors=new Color[renderers.Length];tint=new MaterialPropertyBlock();
            for(int i=0;i<renderers.Length;i++){var m=renderers[i].sharedMaterial;baseColors[i]=m && m.HasProperty("_BaseColor")?m.GetColor("_BaseColor"):Color.white;}
        }
        if(explosionPrefab && !explosion){explosion=Instantiate(explosionPrefab,transform);explosionRenderers=explosion.GetComponentsInChildren<Renderer>();fade=new MaterialPropertyBlock();}
        if(explosion)explosion.SetActive(false);
        ResetPose();
        visual.SetActive(true);visual.transform.localScale=Vector3.one*modelScale;
        Target=combat.RegisterBoss(visual,ToViewport(root),maximumHealth,hitRadius);
        armL=combat.RegisterBossPart(visual,Target.position,partHealth,partRadius,1);
        armR=combat.RegisterBossPart(visual,Target.position,partHealth,partRadius,2);
        cover=combat.RegisterBossPart(visual,Target.position,partHealth,partRadius,3);
        State=EncounterState.Entering;SetNative(NativeState.EntryWait);mode=1;SetSmoke(true);
        Round1TrackCapture.Active?.BirthUnscheduled(Target.id,"ene_boss03","Pf_Ene_Bos03",StageTime,maximumHealth);
        if(entrance){entrance.SampleAnimation(visual,0);entryOffset=visual.transform.localPosition;modelRotation=visual.transform.localRotation;}
        PlaceVisual();
    }
    void ResetPose()
    {
        EncounterAge=0;BossTime=0;AttackVolleys=0;SummonedDrones=0;deathTime=0;timerStarted=false;
        root=RestPosition;entryOffset=Vector3.zero;modelRotation=BasicRotate;rootRotation=Quaternion.identity;turn=Quaternion.identity;turnTime=0;
        coverOpen=laserFire=armLBreak=armRBreak=shoulderTurn=leftRound=backMove=rightMove=noHit=false;
        moveTime=laserArcRate=0;openedAttackCount=0;moveStart=root;startInGamePosition=RestPosition;
        SetRepeatTime(CoverClosedFireInterval);darkTime=0;darkFrom=darkTo=0;
        if(renderers!=null)foreach(var r in renderers)r.enabled=true;
        SetShoulders();ApplyDark(0);droneMotion.Clear();
        if(damageNode){damageNode.gameObject.SetActive(false);foreach(var ps in damageNode.GetComponentsInChildren<ParticleSystem>(true))ps.gameObject.SetActive(false);}damageShown=false;
    }
    void SetNative(NativeState s){if(s!=Native)mode=0;Native=s;if(s==NativeState.EntryWait)mode=0;}
    public void PlaceVisual()
    {
        if(!visual)return;
        // The boss lives on _inGameEnemyRoot, so it carries the enemy layer's player parallax like every wave enemy.
        var cam=Player.stageCamera;var place=root+entryOffset+LayerOffset;
        float unit=Vector3.Distance(Player.WorldPoint(Vector2.zero),Player.WorldPoint(Vector2.up))/200;
        transform.position=Player.WorldPoint(ToViewport(place))-cam.transform.forward*(place.y*unit);
        transform.rotation=cam.transform.rotation*Quaternion.Euler(-90,0,0)*rootRotation;
        visual.transform.localScale=Vector3.one*modelScale;
        visual.transform.localRotation=modelRotation*turn;
        // Keep the imported model centered; its source root translation is carried by the root placement.
        visual.transform.localPosition=-(visual.transform.localRotation*modelCenter)*modelScale;
        if(Target!=null)Target.position=cam.WorldToViewportPoint(transform.position);
        PlacePart(armL,armLNode);PlacePart(armR,armRNode);PlacePart(cover,coverNode);
    }
    void PlacePart(Round1Combat.Target part,Transform node){if(part!=null && node)part.position=Player.stageCamera.WorldToViewportPoint(node.position);}
    Vector3 LayerOffset=>combat.sourceWaves?combat.sourceWaves.LayerOffset:Vector3.zero;
    Vector2 ToViewport(Vector3 p)=>new Vector2(.5f+p.x/(200*Player.stageCamera.aspect),.5f+p.z/200);
    void SetSmoke(bool on){foreach(var s in smoke)if(s)s.SetActive(on);}
    // ChangeDarkMode: the model dims while it summons.
    void Dark(bool on,float seconds){darkFrom=darkTo==0&&darkTime<=0?0:darkTo;darkTo=on?1:0;darkDuration=seconds;darkTime=seconds;}
    void StepDark(float dt){if(darkTime>0){darkTime=Mathf.Max(0,darkTime-dt);ApplyDark(Mathf.Lerp(darkTo,darkFrom,darkTime/Mathf.Max(.001f,darkDuration)));}}
    void ApplyDark(float k)
    {
        if(renderers==null)return;
        for(int i=0;i<renderers.Length;i++){if(!renderers[i])continue;renderers[i].GetPropertyBlock(tint);tint.SetColor("_BaseColor",Color.Lerp(baseColors[i],baseColors[i]*.3f,k));renderers[i].SetPropertyBlock(tint);}
    }
    static Transform Find(Transform t,string name)
    {
        if(t.name==name)return t;
        foreach(Transform c in t){var f=Find(c,name);if(f)return f;}
        return null;
    }
    public void ResetEncounter()
    {
        State=EncounterState.Waiting;Target=armL=armR=cover=null;EncounterAge=0;deathTime=0;AttackVolleys=0;
        foreach(var d in droneMotion)if(d.target.active)combat.DespawnSourceTarget(d.target);droneMotion.Clear();
        if(visual){visual.SetActive(false);ResetPose();}if(explosion)explosion.SetActive(false);
    }
    public void ReleaseVisuals()
    {
        if(visual){if(Application.isPlaying)Destroy(visual);else DestroyImmediate(visual);}
        if(explosion){if(Application.isPlaying)Destroy(explosion);else DestroyImmediate(explosion);}
        visual=null;explosion=null;renderers=null;smoke.Clear();ResetEncounter();
    }
    void OnDestroy(){ReleaseVisuals();}
}
