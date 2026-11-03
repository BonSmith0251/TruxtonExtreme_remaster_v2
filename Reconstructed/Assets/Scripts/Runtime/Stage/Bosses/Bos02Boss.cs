using System.Collections.Generic;
using UnityEngine;

// Ene_Bos02, the BG02 boss, from its native code (evidence/bosses/Bos02/SPEC.md; RVAs there and next to each step).
// Front mode PT1 -> PT2 -> PT3 (tracking the player's x) until both upper wings are broken (or boss time 90 s / HP 40 %
// force-breaks them), then BackWingOpen (under wings unfold, cores flip) and PT5 for the rest of the fight: a patrol of
// straight legs and orbits around ten points with the front laser, the under-wing laser table and the core sweeps.
// Positions are source sky-plane units (x right, z up the screen, y toward the camera) of the boss root. [I]/[?] as in
// the spec.
public class Bos02Boss : StageBoss
{
    enum S { EntryWait=0, PT1=1, PT2=2, PT3=3, PT5=4, BackWingOpen=50 } // Boss02State (Destruction 100 is the base Defeat)
    S state;int mode;float localTime,fightClock;

    // ---- Ene_Bos02..cctor (0x1D812B0) and literal fields
    const float EntryNoHitTime=3.5f,EntryClipLength=5f; // _EntryNoHitTime; anc_bs02_start m_StopTime
    static readonly Vector3[] PatrolPoints={new Vector3(-70,0,50),new Vector3(-35,0,50),new Vector3(0,0,50),new Vector3(35,0,50),new Vector3(70,0,50),
        new Vector3(-70,0,30),new Vector3(-35,0,30),new Vector3(0,0,30),new Vector3(35,0,30),new Vector3(70,0,30)};
    static readonly int[] PatrolOrder={2,6,2,8,4,7,0,7,5,2,9}; // field-RVA blob (metadata data offset 543544)
    static readonly float[] UnderLaserDir={135,90,45,0,0,-45,-90,-135}; // _underLaserMuzzleDir (metadata data offset 543616)
    static readonly float[] Pattern7Start={180,-90,0,-180,90,0},Pattern7Move={-25,-25,-25,25,25,25}; // _Pattern7Table
    // _Pattern6TimeTable (time, battery)
    static readonly float[] Pattern6Time={0,0,1.5f,1.5f,3,3,4.5f,4.5f,8,8,8,8,9.5f,9.5f,9.5f,9.5f,12,12,12,12,12,12,12,12,13.5f,13.5f,13.5f,13.5f,13.5f,13.5f,13.5f,13.5f,15,15,15,15,15,15,15,15};
    static readonly int[] Pattern6Battery={0,7,1,6,2,5,3,4,1,2,5,6,0,3,4,7,0,1,2,3,4,5,6,7,0,1,2,3,4,5,6,7,0,1,2,3,4,5,6,7};
    // Boss02BT (GetBossBT); index 2 bos02way8 is loaded but never fired.
    const string Laser01="bos02laser01",Laser10="bos02laser10",B04x3="bos02b04x3",Way16Aim="bos02way16_1",Way16Alt="bos02way16_2",Way5="bos02way5",Way6a="bos02way6_1",Way6b="bos02way6_2";
    const string P="pf_bs02/";
    static readonly string[] UnderCorePack={P+"wing_under06/wing02_battery/wing02_battery_core",P+"wing_under06/wing02_battery (1)/wing02_battery_core",P+"wing_under06/wing02_battery (2)/wing02_battery_core",
        P+"wing_under04/wing02_battery (3)/wing02_battery_core",P+"wing_under04/wing02_battery (4)/wing02_battery_core",P+"wing_under04/wing02_battery (5)/wing02_battery_core"};
    static readonly string[] UnderLaserPack={P+"wing_under06/muzzle_wingunder06_laser04",P+"wing_under06/muzzle_wingunder06_laser03",P+"wing_under06/muzzle_wingunder06_laser02",P+"wing_under06/muzzle_wingunder06_laser01",
        P+"wing_under04/muzzle_wingunder04_laser01",P+"wing_under04/muzzle_wingunder04_laser02",P+"wing_under04/muzzle_wingunder04_laser03",P+"wing_under04/muzzle_wingunder04_laser04"};
    static readonly string[] UpperPack={P+"wing_upper04/muzzle_wingupper04_01",P+"wing_upper04/muzzle_winguppre04_02",P+"wing_upper06/muzzle_wingupper06_01",P+"wing_upper06/muzzle_wingupper06_02"};
    static readonly string[] BackCorePaths={P+"wing_under06/wing02_battery (2)/wing02_battery_core",P+"wing_under04/wing02_battery (5)/wing02_battery_core",P+"wing_under06/wing02_battery (1)/wing02_battery_core",
        P+"wing_under04/wing02_battery (4)/wing02_battery_core",P+"wing_under06/wing02_battery/wing02_battery_core",P+"wing_under04/wing02_battery (3)/wing02_battery_core"};

    // anc_bs02_start (5 s, root path = pf_bs02 = _modelTop): the stored keys and tangents. The prefab's anm_bs02 controller
    // has only an empty Idle state, so the clip is evaluated here.
    static AnimationCurve C(params float[] k){var keys=new Keyframe[k.Length/4];for(int i=0;i<keys.Length;i++)keys[i]=new Keyframe(k[i*4],k[i*4+1],k[i*4+2],k[i*4+3]);return new AnimationCurve(keys);}
    const float K2=2,K3=4.1666665f,K4=5;
    static readonly AnimationCurve EntryPX=C(0,104.40245f,0,-57.201225f, K2,-10,-26.292892f,-26.29292f, K3,0,2.3076932f,2.3076925f, K4,0,-5.349149E-08f,0);
    static readonly AnimationCurve EntryPY=C(0,220,0,-35, K2,150,-57.884605f,-57.884617f, K3,-25,-25.384634f,-25.38462f, K4,0,-6.5045324E-06f,0);
    static readonly AnimationCurve EntryPZ=C(0,-190.91844f,0,70.45922f, K2,-50,46.768044f,46.768074f, K3,0,11.538467f,11.538463f, K4,0,4.2792973E-07f,0);
    static readonly AnimationCurve EntryRX=C(0,10,0,-2.5f, K2,5,-2.4038463f,-2.4038463f, K3,0,-1.1538465f,-1.1538463f, K4,0,2.6745745E-08f,0);
    static readonly AnimationCurve EntryRY=C(0,-50,0,30, K2,10,54.230774f,54.230774f, K3,180,39.230778f,39.230774f, K4,180,-1.2471161E-06f,0);
    static readonly AnimationCurve EntryRZ=C(0,0,0,-7.5f, K2,-15,-1.4423075f,-1.4423075f, K3,-5,5.307693f,5.307692f, K4,0,8.558878E-08f,0);

    Transform modelTop,bodyFront,backWingL,backWingR,bodyCore,frontCore,frontLaser;
    readonly Transform[] underCore=new Transform[6],underLaser=new Transform[8],upper=new Transform[4],backCores=new Transform[6];
    Part upper04,upper06,under04,under06,core;
    bool entrySound,fire1Aim;int turnCount,fire1Count;float attackDuration,cooldownTimer,fireTimer,moveSpeed;int moveDirHold;

    // BulletFireAsyncDelayed (0x1CD8D40): Fire1/Fire3 shots leave 0.5 s after the call; cancelled by ReleaseToken at death.
    struct Delayed {public float at;public string pattern;public Transform muzzle;}
    readonly List<Delayed> delayed=new List<Delayed>();

    // PatrolMovementController (Phase Straight 0 / Orbit 1 / Stop 2)
    int phase=2,seq,orbitDir=1;bool patrolInit,reachedContact,advanceRequested,cruise;
    Vector3 patrolPos,patrolVel,patrolTarget,contactPoint;float orbitAngle,orbitRadius=5,contactAngle,orbitTimer,speed,constantSpeed,speedStart,speedTarget=10,speedTimer,speedDuration;
    // Fire5/6/7Controller
    int f5Mode,f6Mode,f7Mode;bool f5Trigger;float f5Wait,f5Fire,f6Wait,f6Line,f7Wait,f7Roll,f7Fire;

    // ---------------------------------------------------------------- spawn (Initialize 0x1D7E760, ReStart 0x1D80710, GetStart 0x1D7E4B0)
    protected override void OnSpawned()
    {
        modelTop=Find("pf_bs02");bodyFront=Find(P+"body_front");backWingL=Find(P+"wing_under06");backWingR=Find(P+"wing_under04");
        frontLaser=Find(P+"body_front/muzzle_body_front_laser");frontCore=Find(P+"body_front/muzzle_body_front_core");bodyCore=Find(P+"body/muzzle_body_core"); // Boss02MZ
        for(int i=0;i<6;i++){underCore[i]=Find(UnderCorePack[i]);backCores[i]=Find(BackCorePaths[i]);}
        for(int i=0;i<8;i++)underLaser[i]=Find(UnderLaserPack[i]);
        for(int i=0;i<4;i++)upper[i]=Find(UpperPack[i]);
        core=GetPart("core");upper06=GetPart("upper06");upper04=GetPart("upper04");under04=GetPart("under04");under06=GetPart("under06");
        var animator=visual.GetComponentInChildren<Animator>(true);if(animator)animator.enabled=false; // empty controller; the clip is driven below
        foreach(var c in backCores)if(c)c.localRotation=Quaternion.Euler(180,0,0); // _coreRot
        // GetStart: OffCollision. Under wings are PartsFlag MasterBody|SleepStart: no collision until OpenBackWing wakes them.
        foreach(var p in Parts)p.enabled=false;
        state=S.EntryWait;mode=0;localTime=0;fightClock=0;entrySound=false;fire1Aim=true;turnCount=0;fire1Count=0;
        attackDuration=cooldownTimer=fireTimer=moveSpeed=0;moveDirHold=0;delayed.Clear();
        phase=2;seq=0;orbitDir=1;patrolInit=reachedContact=advanceRequested=cruise=false;orbitRadius=5;speed=constantSpeed=speedStart=speedTimer=speedDuration=0;speedTarget=10;
        f5Mode=f6Mode=f7Mode=0;f5Trigger=false;f5Wait=f5Fire=f6Wait=f6Line=f7Wait=f7Roll=f7Fire=0;
    }

    // ---------------------------------------------------------------- EntryWait (PatternEntry 0x1D7F1B0)
    protected override bool Entrance(float dt)
    {
        position=Current.rest; // ene_boss02 placement (0,0,50); the clip moves _modelTop under the root
        if(!entrySound){entrySound=true;Round1Sound.Play("bg2_boss_app_01");} // mode 0: PlayQue(61)
        float t=Mathf.Min(StateAge,EntryClipLength);
        if(modelTop)
        {
            modelTop.localPosition=new Vector3(EntryPX.Evaluate(t),EntryPY.Evaluate(t),EntryPZ.Evaluate(t));
            modelTop.localRotation=Quaternion.Euler(EntryRX.Evaluate(t),EntryRY.Evaluate(t),EntryRZ.Evaluate(t));
        }
        // mode 1: after 3.5 s collision on, still OffLockon|NoDamaged (the base keeps Target/parts invulnerable, no lock-on).
        Target.lockOn=false;
        if(StateAge>=EntryNoHitTime){if(core!=null)core.enabled=true;if(upper06!=null)upper06.enabled=true;if(upper04!=null)upper04.enabled=true;}
        // mode 2: mover._isFinishDelay = route FinishWait after TaskWait(AnimationTask), i.e. the 5 s clip has ended.
        if(StateAge<EntryNoHitTime||StateAge<EntryClipLength)return false;
        if(modelTop){modelTop.localPosition=Vector3.zero;modelTop.localRotation=Quaternion.Euler(0,180,0);} // _modelTopRotateStart
        return true; // base: SetVulnerable(true), BossTime=0 (ResetBossTimer(true)), OnFightStart
    }
    protected override void OnFightStart(){state=S.EntryWait;FrontNext();}

    // ---------------------------------------------------------------- state machine (StateExec 0x1D80D90)
    void SetState(S s){if(s!=state){state=s;mode=0;}} // SetState 0x1D80D50 (also clears _laserCancelFlag)
    protected override void Fight(float dt)
    {
        if(dt<=0)return; // Ene_BosBase.LocalLateUpdate runs StateExec only with dt > 0
        fightClock+=dt;
        for(int i=delayed.Count-1;i>=0;i--)if(fightClock>=delayed[i].at){var d=delayed[i];delayed.RemoveAt(i);Fire(d.pattern,d.muzzle);}
        switch(state)
        {
            case S.EntryWait:FrontNext();break;
            case S.PT1:Attack(dt,.2f,1);break;  // PatternMove1 0x1D7F410, Pattern1FireInterval
            case S.PT2:Attack(dt,.1f,2);break;  // PatternMove2 0x1D7F620
            case S.PT3:Attack(dt,.05f,3);break; // PatternMove3 0x1D7F830
            case S.BackWingOpen:OpenBackWing(dt);break;
            case S.PT5:PatternMove5(dt);break;
        }
        // Root roll Euler(0,0,_rotateZ): _rotateZ is only driven toward 0 (UpdateRollAngle in OpenBackWing), so facing stays as spawned.
    }

    // HandleFrontModeNextState (0x1D7E530) via CheckNextState (0x1D7D2D0)
    void FrontNext()
    {
        if(BossTime>=90||HpState>=4){BreakPart(upper04);BreakPart(upper06);} // IsOverStep(Passed90) || IsOverHP(LowHP)
        if((upper04==null||upper04.broken)&&(upper06==null||upper06.broken)){SetState(S.BackWingOpen);return;}
        switch(state)
        {
            case S.EntryWait:SetState(S.PT1);break;
            case S.PT1:SetState(S.PT2);break;
            case S.PT2:SetState(S.PT3);break;
            case S.PT3:if(turnCount<int.MaxValue)turnCount++;SetState(S.PT1);break;
            default:SetState(S.EntryWait);break;
        }
    }

    // PT1/PT2/PT3: max(5 - turnCount, 1) s of fire at the interval, 0.5 s cooldown, then the next state.
    void Attack(float dt,float interval,int which)
    {
        switch(mode)
        {
            case 0:attackDuration=Mathf.Max(5-turnCount,1);cooldownTimer=0;fireTimer=0;if(which==1)fire1Aim=true;mode=10;break;
            case 10:
                attackDuration-=dt;fireTimer+=dt;
                while(fireTimer>=interval){fireTimer-=interval;if(which==1)Fire1Toggle();else if(which==2)Fire2();else Fire3();}
                if(attackDuration<=0){cooldownTimer=.5f;mode=20;}
                break;
            case 20:cooldownTimer-=dt;if(cooldownTimer<=0){FrontNext();return;}break;
            default:FrontNext();return;
        }
        Track(dt);
    }

    // TrackPlayerHorizontally (0x1D80F80) with ExecuteHorizontalChaseStep (0x1D7D450): 1/60 s substeps, x only.
    void Track(float dt)
    {
        float px=Mathf.Clamp(PlayerSource.x,-80,80),rem=dt; // HorizontalLimitRange; GetPlayerSkyPosition(0)
        while(rem>0)
        {
            float step=Mathf.Min(rem,1f/60),f=step/dt;
            float d=px-position.x,ad=Mathf.Abs(d),target;
            if(ad>1.5f)target=(d>=0?1:-1)*(10+10*Mathf.Clamp01((ad-1.5f)/58.5f)); // PositionDeadZone, MoveSpeedMin/Max, PositionSpeedRange-1.5
            else
            {
                int dir=Mathf.Abs(moveSpeed)>.01f?(moveSpeed>=0?1:-1):moveDirHold!=0?moveDirHold:(d>=0?1:-1);
                target=Mathf.Max(10,Mathf.Abs(moveSpeed))*dir; // the dead zone keeps the boss sweeping
            }
            float accel=Mathf.Approximately(moveSpeed,0)||(moveSpeed>=0)==(target>=0)?6:4; // MoveAcceleration / MoveDeceleration
            moveSpeed=Mathf.Clamp(Mathf.MoveTowards(moveSpeed,target,accel*f*step),-20,20);
            if(Mathf.Abs(moveSpeed)>.01f)moveDirHold=moveSpeed>=0?1:-1;
            position.x+=step*moveSpeed;rem-=step;
        }
    }

    // ---------------------------------------------------------------- fire (Fire1..Fire7 0x1D7DA60..0x1D7DF10)
    void Later(float delay,string pattern,Transform muzzle){if(muzzle)delayed.Add(new Delayed{at=fightClock+delay,pattern=pattern,muzzle=muzzle});}
    void Fire1Toggle(){Later(.5f,fire1Aim?Way16Aim:Way16Alt,bodyCore);fire1Aim=!fire1Aim;} // <PatternMove1>b__110_0 0x1D81110
    void Fire2(){foreach(var m in upper)Fire(B04x3,m);} // BulletFireByMuzzlePack "upperl"; a broken wing's muzzles are hidden and skip
    void Fire3(){Later(.5f,Way5,frontCore);}
    void Fire5(){Fire(Laser01,frontLaser);}
    void Fire6(int battery){if(battery>=0&&battery<8)Fire(Laser10,underLaser[battery],UnderLaserDir[battery]);}
    void Fire7(float rate)
    {
        for(int i=0;i<6;i++){float a=Pattern7Start[i]+rate*Pattern7Move[i];Fire(Way6a,underCore[i],a);Fire(Way6b,underCore[i],a);}
        if(rate>=1&&((++fire1Count)&1)!=0)Fire1Toggle();
    }

    // ---------------------------------------------------------------- BackWingOpen (OpenBackWing 0x1D7EC30)
    void OpenBackWing(float dt)
    {
        switch(mode)
        {
            case 0:SetVulnerable(false);mode=1;goto case 1; // OffLockon|NoDamaged
            case 1:Round1Sound.Play("bg2_boss_mainwing_operating");localTime=2;mode=10;break; // PlayQue(70); roll is already 0
            case 10:
            {
                float e=EaseInOutQuad(Mathf.Clamp01(1-localTime*.5f));
                if(backWingL)backWingL.localRotation=Quaternion.Euler(0,0,90*e);
                if(backWingR)backWingR.localRotation=Quaternion.Euler(0,0,-90*e);
                if(bodyFront)bodyFront.localRotation=Quaternion.Euler(-60*e,0,0);
                if(localTime>0)localTime-=dt;else{mode=11;localTime=.5f;}
                break;
            }
            case 11:
                localTime-=dt;
                if(localTime<=0){if(under06!=null)under06.enabled=true;if(under04!=null)under04.enabled=true;mode=19;} // Wakeup PartsList[4]/[3]; _backWingMode
                break;
            case 19:Round1Sound.Play("bg2_boss_cannon_move_01");localTime=.5f;mode=20;break; // PlayQue(71)
            case 20:case 21:case 22:
            {
                localTime=Mathf.Max(localTime-dt,0);
                int pair=2*mode-40;Quaternion r=Quaternion.Euler(180*Mathf.Clamp01(2*localTime),0,0);
                if(backCores[pair])backCores[pair].localRotation=r;if(backCores[pair+1])backCores[pair+1].localRotation=r;
                if(localTime<=0)
                {
                    mode++;
                    if(mode<=22){Round1Sound.Play("bg2_boss_cannon_move_01");localTime=.5f;}
                    else{fire1Aim=true;fire1Count=0;SetVulnerable(true);SetState(S.PT5);}
                }
                break;
            }
        }
    }
    // KANAI EasingUtility.InOutQuad01 [I: the standard in-out quadratic]
    static float EaseInOutQuad(float t)=>t<.5f?2*t*t:1-2*(1-t)*(1-t);

    // ---------------------------------------------------------------- PT5 (PatternMove5 0x1D7FA40)
    void PatternMove5(float dt)
    {
        bool wasStraight=phase==0;
        EnsureInitialized();
        if(phase==0)UpdateStraight(dt);else if(phase==1)UpdateOrbit(dt);
        bool enteredStraight=phase==0&&!wasStraight;
        switch(mode)
        {
            case 0:mode=10;break;
            case 10:if(reachedContact){localTime=5;mode=20;}break; // PatrolPostArrivalDelay
            case 20:if(!reachedContact)mode=10;else{localTime-=dt;if(localTime<=0)advanceRequested=true;}break;
        }
        // Fire5Controller (0x1D86C50): laser01 the frame after a straight leg starts, then 5 s lockout; triggers latch.
        f5Trigger|=enteredStraight;
        switch(f5Mode)
        {
            case 10:f5Wait+=dt;if(f5Wait>=0){f5Fire=0;Fire5();f5Mode=20;}break;
            case 20:f5Fire+=dt;if(f5Fire>=5){f5Mode=30;f5Wait=0;}break;
            case 30:f5Wait+=dt;if(f5Wait>=0)f5Mode=0;break;
            default:f5Mode=0;if(f5Trigger){f5Trigger=false;f5Mode=10;f5Wait=0;}break;
        }
        // Fire6Controller (0x1D86D30): 5 s, the 15 s battery table, 10 s rest.
        switch(f6Mode)
        {
            case 10:f6Wait+=dt;if(f6Wait>=5){f6Line=-1e-4f;f6Mode=20;}break;
            case 20:
            {
                float prev=f6Line;f6Line+=dt;bool done=true;
                for(int i=0;i<Pattern6Time.Length;i++){float t=Pattern6Time[i];if(t>f6Line)done=false;else if(t>prev)Fire6(Pattern6Battery[i]);}
                if(done){f6Mode=30;f6Wait=0;}
                break;
            }
            case 30:f6Wait+=dt;if(f6Wait>=10)f6Mode=0;break;
            default:f6Mode=10;f6Wait=0;break;
        }
        // Fire7Controller (0x1D86F10): 1 s after a straight leg starts, 5 s of way6 pairs every 0.1 s sweeping by rate.
        switch(f7Mode)
        {
            case 10:f7Wait+=dt;if(f7Wait>=1){f7Roll=0;f7Fire=0;f7Mode=20;}break;
            case 20:
                f7Roll+=dt;f7Fire+=dt;
                if(f7Roll>=5){f7Mode=0;f7Wait=0;break;}
                if(f7Fire>=.1f){f7Fire-=.1f;Fire7(f7Roll<2?0:f7Roll<4?(f7Roll-2)*.5f:1);}
                break;
            default:f7Mode=0;if(enteredStraight){f7Mode=10;f7Wait=0;}break;
        }
    }

    // ---- PatrolMovementController
    void RefreshTarget(){patrolTarget=PatrolPoints[PatrolOrder[seq%PatrolOrder.Length]];} // 0x1D87D60
    void EnsureInitialized() // 0x1D874E0
    {
        if(patrolInit)return;
        patrolPos=position;seq=0;RefreshTarget();patrolVel=Vector3.zero;contactPoint=patrolPos;
        orbitAngle=0;orbitRadius=5;orbitDir=1;contactAngle=0;orbitTimer=0;speed=0;constantSpeed=10;cruise=false;
        speedStart=0;speedTarget=20;speedTimer=0;speedDuration=3;reachedContact=advanceRequested=false;
        var c=ContactPoint(patrolPos,patrolTarget,5,1,out float a);PrepareStraight(patrolPos,c,a,orbitDir);patrolInit=true;
    }
    // ComputeOrbitContactPoint (0x1D872F0): the tangent point on the radius-r circle, side by direction.
    static Vector3 ContactPoint(Vector3 from,Vector3 center,float r,int dir,out float angle)
    {
        float dx=from.x-center.x,dz=from.z-center.z,d=Mathf.Sqrt(dx*dx+dz*dz);
        angle=Mathf.Atan2(dz,dx);
        if(r+.001f<d)angle+=(dir<0?-1:1)*Mathf.Acos(Mathf.Clamp(r/d,-1,1));
        return new Vector3(center.x+Mathf.Cos(angle)*r,center.y,center.z+Mathf.Sin(angle)*r);
    }
    Vector3 OrbitPosition(float a)=>new Vector3(patrolTarget.x+Mathf.Cos(a)*orbitRadius,patrolTarget.y,patrolTarget.z+Mathf.Sin(a)*orbitRadius); // 0x1D878C0
    static Vector3 OrbitTangent(int dir,float a)=>dir>=0?new Vector3(-Mathf.Sin(a),0,Mathf.Cos(a)):new Vector3(Mathf.Sin(a),0,-Mathf.Cos(a)); // 0x1D87980
    static Vector3 Unit3(Vector3 v){float m=v.magnitude;return m>1e-5f?v/m:Vector3.zero;}
    void ClampSpeed(float max){float min=cruise?10:0;if(min>speed)speed=min;else if(speed>max)speed=max;constantSpeed=speed;} // the clamp order as coded (orbit: min 10 > max 8)
    void PrepareStraight(Vector3 from,Vector3 contact,float angle,int dir) // 0x1D87A70
    {
        patrolPos=from;phase=0;contact.y=patrolTarget.y;contactPoint=contact;contactAngle=angle;orbitDir=dir<0?-1:1;orbitTimer=0;reachedContact=advanceRequested=false;
        ClampSpeed(20);
        var d=new Vector3(contact.x-patrolPos.x,0,contact.z-patrolPos.z);
        patrolVel=d.sqrMagnitude>1e-6f?Unit3(d)*constantSpeed:Vector3.zero;
        position=patrolPos;
    }
    void BeginSpeedTransition(float target,float duration) // 0x1D87110
    {
        float max=phase==1?8:20;if(10>target)target=10;else if(target>max)target=max;
        duration=Mathf.Max(duration,1e-4f);
        if(Mathf.Approximately(speedTarget,target)&&Mathf.Approximately(speedDuration,duration))return;
        speedStart=speed;speedTarget=target;speedDuration=duration;speedTimer=0;
    }
    void AdvanceSpeed(float dt) // 0x1D87010 (PlayTimeFactor taken as 1)
    {
        float s;
        if(speedDuration>0){speedTimer=Mathf.Min(speedTimer+Mathf.Max(dt,0),speedDuration);s=speedStart+(speedTarget-speedStart)*Mathf.Clamp01(speedTimer/speedDuration);}
        else s=speedTarget;
        speed=s;if(s>=9.999f)cruise=true;
        ClampSpeed(phase==1?8:20);
    }
    void UpdateStraight(float dt) // 0x1D88870
    {
        RefreshTarget();
        var d=new Vector3(contactPoint.x-patrolPos.x,0,contactPoint.z-patrolPos.z);float dist=d.magnitude;
        float vt=dist<=40?10:20;if(!cruise&&speed<10)vt=20;
        BeginSpeedTransition(vt,vt>speed?3:2); // PatrolAccelerationDuration / PatrolDecelerationDuration
        AdvanceSpeed(dt);
        patrolVel=d.sqrMagnitude>1e-6f?Unit3(d)*constantSpeed:Vector3.zero;
        var next=patrolPos+patrolVel*dt;
        if((contactPoint.x-next.x)*d.x+(contactPoint.z-next.z)*d.z<0)next=contactPoint;
        patrolPos=next;position=patrolPos;
        float dx=contactPoint.x-patrolPos.x,dz=contactPoint.z-patrolPos.z;
        if(Mathf.Sqrt(dx*dx+dz*dz)<=.001f){reachedContact=true;StartOrbit();} // PatrolDistanceEpsilon
    }
    void StartOrbit() // 0x1D87FB0
    {
        phase=1;orbitTimer=0;orbitAngle=contactAngle;
        speed=speed<0?0:speed>8?8:speed;ClampSpeed(8);
        patrolPos=OrbitPosition(orbitAngle);position=patrolPos;
        patrolVel=Unit3(OrbitTangent(orbitDir,orbitAngle))*constantSpeed;
    }
    void UpdateOrbit(float dt) // 0x1D882C0
    {
        orbitTimer+=dt;
        BeginSpeedTransition(8,3); // PatrolOrbitSpeedMax (clamped to 10 by the as-coded order)
        AdvanceSpeed(dt);
        orbitAngle+=constantSpeed/Mathf.Max(orbitRadius,.001f)*orbitDir*dt;
        patrolPos=OrbitPosition(orbitAngle);position=patrolPos;
        var tangent=Unit3(OrbitTangent(orbitDir,orbitAngle));patrolVel=tangent*constantSpeed;
        if(!advanceRequested||orbitTimer<3)return; // PatrolOrbitMinDuration
        int n=(seq+1)%PatrolOrder.Length,dir=-orbitDir;
        var k=ContactPoint(patrolPos,PatrolPoints[PatrolOrder[n]],orbitRadius,dir,out float a);
        var dk=new Vector3(k.x-patrolPos.x,0,k.z-patrolPos.z);
        if(dk.sqrMagnitude<=1e-6f||Vector3.Dot(Unit3(dk),tangent)>=.95f){seq=n;RefreshTarget();PrepareStraight(patrolPos,k,a,dir);} // OrbitAlignmentThreshold
    }

    // ---------------------------------------------------------------- parts (OnPartsBreak 0x1D7EBE0)
    protected override void PartBroken(Part part)
    {
        CancelLasers(); // _laserCancelFlag = true (AddShake(1,3,4) has no counterpart here)
        // PartsList BreakEffect pf_eff_explposion03 at the part root, which is hidden [I]; the BreakParts sound is not resolved [?].
        if(part.root&&visual&&part.root!=visual.transform){Boom("pf_eff_explposion03",part.root.position);part.root.gameObject.SetActive(false);}
    }

    // ---------------------------------------------------------------- destruction (ToDestroid 0x1D80EC0, PatternMoveDestruction 0x1D80030)
    protected override Vector3 DestructionEuler=>new Vector3(120,0,45);
    Quaternion deathFrom;float smallBombNext,smallBombBase;int deathStep;
    public override void OnDefeated()
    {
        if(State==EncounterState.Defeating||StageCleared)return;
        base.OnDefeated();delayed.Clear(); // ReleaseToken cancels the delayed shots
        Round1Sound.Event("bossDefeat"); // StopBossTimer PlayQue(177)
        deathFrom=facing;smallBombNext=0;smallBombBase=.2f;deathStep=0; // SetSmallBombSecond(0.2)
    }
    // Own sequence instead of base.Defeat: bomb points are GetSmallBombPosition, small bombs (with their SE) run the whole
    // 5.5 s, the under wings break at 3.5 s and the final SE plays at 5.5 s.
    protected override void Defeat(float dt)
    {
        if(!visual)return;
        float u=Mathf.Clamp01(StateAge/5.5f); // SetDirectionTime(5.5, 1)
        sinkDepth=150*u*u; // _targetVector.y -= 150, EaseIn
        facing=Quaternion.Lerp(deathFrom,Quaternion.Euler(DestructionEuler),u); // CurrentTargetAngle (Quaternion.Lerp)
        if(deathStep==0){deathStep=1;for(int i=0;i<4;i++)Boom("pf_eff_explposion02",SmallBombPosition());} // 4x ExplosionCodeMiddle, no sound
        smallBombNext-=dt; // IsCallSmallBomb 0x1DB9E90
        if(smallBombNext<=0&&StateAge<5.5f)
        {
            smallBombNext=smallBombBase+.1f*Random.value;smallBombBase*=.9f;
            Boom("pf_eff_explposion01",SmallBombPosition(),.6f);Round1Sound.Play("exp_st3_boss_a01"); // ExplosionCodeSmall, PlayQue(40)
        }
        if(deathStep==1&&StateAge>=DeadEffectTime)
        {
            deathStep=2;BreakPart(under04);BreakPart(under06); // BreakParts PartsList[4]/[3]
            // _callDeadEffect: pf_eff_explposion_boss at _explosionOffset (0,20,0) with the overplay dead sound [I].
            Boom("pf_eff_explposion_boss",visual.transform.position+visual.transform.rotation*Vector3.up*(20*Unit*DepthScale),1.5f);
            Round1Sound.Play("exp_st3_boss_b02");
        }
        if(deathStep==2&&StateAge>=5.5f){deathStep=3;Round1Sound.Play("exp_st3_boss_c03");} // mode 30: PlayQue(42), then removal
    }
    // GetSmallBombPosition (0x1D7E3C0)
    Vector3 SmallBombPosition()
    {
        float r=Random.value;Transform t;
        if(r<.5f){int i=Random.Range(0,3);t=i==0?frontLaser:i==1?frontCore:bodyCore;}
        else if(r<.75f)t=backCores[Random.Range(0,6)];
        else if(r<.9f)t=backWingL;else t=backWingR;
        return t?t.position:visual.transform.position;
    }
}
