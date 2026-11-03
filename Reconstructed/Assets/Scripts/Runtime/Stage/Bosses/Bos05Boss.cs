using System.Collections.Generic;
using UnityEngine;

// Ene_Bos05, the BG05 boss, from the native code (evidence/bosses/Bos05/SPEC.md; RVAs there and below).
// Loop: EntryWait -> PT1Shot -> PT4Laser -> GrowArm -> PT1Shot ... The phase change (HalfInterruptEvent: HP state
// jumps to HalfHP, or 90 s alive in phase 1) breaks every leg, switches to the "...2" templates and requests the
// belly attack (PT6Belly) through _laserCancelFlag. Launched arms are Ene_Bos05_Arm summons (Pf_EneObj_Bos05_Arm).
// Positions are source sky-plane units (x right, z up the screen, y toward the camera), the boss localPosition.
// Marked [I] where the spec infers, [?] where it does not know.
public class Bos05Boss : StageBoss
{
    enum S { EntryWait, PT1Shot, PT4Laser, PT6Belly, GrowArm } // Boss05State (Destruction 100 is the base Defeat)

    // Ene_Bos05..cctor (0x1D9A300)
    const float EntryNoHitTime=2.5f;
    const float FloatHorizonTime=20,FloatHorizonDistance=60,FloatVerticalTime=5,FloatVerticalDistance=8,FloatAutoRecoverTime=3;
    const float ShotWait1Turret=1.5f,ShotWait2Leg=.5f,ShotWait3Body=1.5f;
    static readonly Vector3 Arm40Inner=new Vector3(60,0,0),Arm60Inner=new Vector3(-60,0,0),ArmMeshInner=new Vector3(0,0,-60);
    const float LaserPositionX=80,ArmFireInterval=2.5f,LaserStartPositionMoveTime=2.7f,LaserEndPositionMoveTime=1.5f;
    const float LaserTurretWaitTime=3,LaserTurretMoveTime=1.5f,TurretRestoreSpeed=80,LaserTurretChargeTime=1,LaserHomingTime=0,LaserEndTime=.5f;
    const float LaserStartAngle=90,LaserEndAngle=-30;
    const int ArmGenerateLimitCount=10,ArmLimitCount1=3,ArmLimitCount2=2;
    const float BellyTurnTime=1.5f,BellyTurnAngleX=75,BellyFireInterval=3;
    const float PhaseEventSecondElapsedTime=90; // UIBossGauge.defaultBossTimeMax 180 * 0.5 (also TimeSteps.Passed90)
    const float LegHP66=2f/3,LegHP33=1f/3,LegHP00=0;
    static readonly float[] LegAngle={30,45,60,-30,-45,-60}; // _LegAngle[LegId]: leg10 leg40 leg70 leg30 leg60 leg90
    const float LaserIrradiation=6.5f; // bos05laser01 nIrradiation (_callLaser 0x1D9A140 returns it)
    // Ene_Bos05_Arm..cctor (0x1D94770); _targetSpeed = mover speed = EnemyData bos05_arm moveSpeed 35 [I]
    const float ArmGrowTime=1.2f,ArmTwistSpeed=360,ArmAcceleTime=1,ArmStartMoveTime=1,ArmTurnBaseSpeed=50,ArmTurnInner=120,ArmTurnOuter=72;
    const float ArmMinGrowScale=.4f,ArmUpPosY=50,ArmUpTime=3,ArmSpeed=35,ArmHealth=50000; // EnemyDatabase row 57 Bos05_Arm
    const string ArmModel="Pf_EneObj_Bos05_Arm";
    static readonly string[] Minions={ArmModel};
    public override string[] MinionModels=>Minions;

    // _BulletTemplateNames[AttackPhase][AttackId] (FrontA FrontB Berry Eyes Legs Laser)
    static readonly string[][] Templates={
        new[]{"bos05front1A","bos05front1B","bos05berry1","bos05eyes1","bos05legs1","bos05laser01"},
        new[]{"bos05front2A","bos05front2B","bos05berry2","bos05eyes2","bos05legs2","bos05laser01"}};
    const int FrontA=0,Berry=2,Eyes=3,Legs=4,Laser=5;
    const string M="pf_bs05/RotX-65_Scal0.85/";
    static readonly string[] TurretPack={M+"me_bs05/laser_neck/laser_body/muzzle_turret70",M+"me_bs05/laser_neck/laser_body/muzzle_turret10",
        M+"me_bs05/laser_neck/laser_body/muzzle_turret90",M+"me_bs05/laser_neck/laser_body/muzzle_turret30"}; // EnemyMover _muzzlePacks "turret"
    static readonly string[] LegNames={"pf_bs05_leg10","pf_bs05_leg40","pf_bs05_leg70","pf_bs05_leg30","pf_bs05_leg60","pf_bs05_leg90"};
    static readonly string[] LegMuzzles={"muzzle_body10","muzzle_body40","muzzle_body70","muzzle_body30","muzzle_body60","muzzle_body90"};

    S state;int mode;float localTime;int phase;int lastHp;bool laserCancel; // _bos05state _patternMode _localTime _attackPhase _lastHPState mover._laserCancelFlag
    int loops,fireCount;                                                    // _attackLoopCount _fireCount
    Vector3 center,overridePos,startVector,targetVector;float overrideRate,floatTimerX,floatTimerZ,floatSpeed; // MoveAround state
    bool isLeftMove,isLaserMove,isFired,armPurged;float laserMoveRate,laserWait,laserTime,armInterval;int armCount; // PT4 state
    int arm40Destroyed,arm60Destroyed;float legHp40=1,legHp60=1;
    float turretRY,turretStart,turretTarget,turretWait,turretPassed;
    Quaternion baseFacing=Quaternion.identity;
    Transform turret,arm40Node,arm60Node,arm40Scale,arm60Scale,arm40Mesh,arm60Mesh,laserMuzzle,laserEdge,body20,body21;
    readonly Transform[] packMuzzles=new Transform[4],legNodes=new Transform[6],legMuzzles=new Transform[6],smallBombMuzzles=new Transform[4];
    readonly Renderer[] legUpper=new Renderer[6],legLower=new Renderer[6];
    Part arm40Part,arm60Part,leg40Part,leg60Part;
    bool deadSe,endSe;

    class Arm { public Minion m;public int mode;public float timer,speed,turn,twist,up;public Vector3 dir,born,launch,parentOffset;public Quaternion baseRot;public bool clockwise,inner,left,se;public Transform scaleNode; }
    readonly List<Arm> arms=new List<Arm>();

    // ---------------------------------------------------------------- spawn (Initialize 0x1D95BD0, GetStart 0x1D95910, ReStart 0x1D98A60)
    protected override void OnSpawned()
    {
        state=S.EntryWait;mode=0;localTime=0;phase=0;lastHp=0;laserCancel=false;loops=0;fireCount=0;
        overridePos=Vector3.zero;overrideRate=floatTimerX=floatTimerZ=floatSpeed=0;
        isLeftMove=isLaserMove=isFired=armPurged=false;laserMoveRate=laserWait=laserTime=armInterval=0;armCount=0;
        arm40Destroyed=arm60Destroyed=0;legHp40=legHp60=1;turretRY=turretStart=turretTarget=turretWait=turretPassed=0;
        deadSe=endSe=false;arms.Clear();baseFacing=facing;
        turret=Find(M+"me_bs05/laser_neck/laser_body");
        arm40Node=Find(M+"arm40");arm60Node=Find(M+"arm60");
        arm40Scale=Find(M+"arm40/arm40_scale");arm60Scale=Find(M+"arm60/arm60_scale");
        arm40Mesh=Find(M+"arm40/arm40_scale/arm40_mesh");arm60Mesh=Find(M+"arm60/arm60_scale/arm60_mesh");
        laserMuzzle=Find("muzzle_turret_laser");laserEdge=Find("turret_edge");body20=Find("muzzle_body20");body21=Find("muzzle_body21");
        for(int i=0;i<4;i++)packMuzzles[i]=Find(TurretPack[i]);
        smallBombMuzzles[0]=body20;smallBombMuzzles[1]=body21;smallBombMuzzles[2]=laserMuzzle;smallBombMuzzles[3]=laserEdge; // Boss05MZ order
        for(int i=0;i<6;i++)
        {
            legNodes[i]=Find(M+"me_bs05/"+LegNames[i]);legMuzzles[i]=Find(M+"me_bs05/body/"+LegMuzzles[i]);
            var upper=legNodes[i]?legNodes[i].Find("leg_upper"):null;var lower=upper?upper.Find("leg_under"):null;
            legUpper[i]=upper?upper.GetComponent<Renderer>():null;legLower[i]=lower?lower.GetComponent<Renderer>():null;
            if(legUpper[i])legUpper[i].enabled=true;if(legLower[i])legLower[i].enabled=true; // ResetBreakLegs
        }
        arm40Part=GetPart("arm40");arm60Part=GetPart("arm60");leg40Part=GetPart("leg40");leg60Part=GetPart("leg60");
        if(turret)turret.localRotation=Quaternion.identity;
        // EnemyData ene_boss05 event Animation(9) "anc_bs05_start" on _modelTop pf_bs05 (its controller defaults to Idle).
        var top=Find("pf_bs05");var anim=top?top.GetComponent<Animator>():null;if(anim)anim.Play("anc_bs05_start",0,0);
        Target.lockOn=false; // InGameObjectFlag OffCollision (GetStart), then OffLockon|NoDamaged
        Round1Sound.Play("bg5_boss_app_01");     // PlayQue 74
        Round1Sound.Play("bg5_boss_tentacle_01"); // Play 183 on a channel (_armSEId) [I] played once: no looping boss channel in Round1Sound
    }

    // EntryWait (StateExec 0x1D98EC0 inline): 2.5 s without collision, then collision without lock-on or damage until
    // the entrance route finishes (mover._isFinishDelay) [I]: taken as the end of the 5 s anc_bs05_start clip.
    protected override bool Entrance(float dt)
    {
        position=Current.rest;
        Target.touchesWhileInvulnerable=StateAge>=EntryNoHitTime;
        if(StateAge<5)return false;
        Target.touchesWhileInvulnerable=false;return true;
    }
    protected override void OnFightStart(){center=position;SetState(S.PT1Shot);} // _centerPosition, ResetBossTimer(true), CheckNextState

    // ---------------------------------------------------------------- StateExec (0x1D98EC0)
    protected override void Fight(float dt)
    {
        CheckLegs();CountArms();
        if(state==S.PT1Shot||state==S.PT4Laser||state==S.PT6Belly)
        {
            int hp=HpState;
            if(hp>lastHp){lastHp=hp;if(hp==3)HalfInterruptEvent();}                          // CheckHPEvent 0x1D954F0
            if(phase==0&&BossTime>=PhaseEventSecondElapsedTime)HalfInterruptEvent();          // CheckTimeEvent 0x1D955C0
        }
        switch(state)
        {
            case S.PT1Shot:PatternMove1(dt);break;
            case S.PT4Laser:PatternMove4(dt);break;
            case S.PT6Belly:PatternMove6(dt);break;
            case S.GrowArm:PatternMoveGrowArm(dt);break;
        }
    }
    void SetState(S s){state=s;mode=0;} // SetState 0x1D98E10
    // CheckNextState 0x1D95520
    void CheckNextState()
    {
        switch(state)
        {
            case S.EntryWait:SetState(S.PT1Shot);break;
            case S.PT1Shot:SetState(S.PT4Laser);break;
            case S.PT4Laser:SetState(S.GrowArm);break;
            case S.PT6Belly:SetState(armPurged?S.GrowArm:S.PT1Shot);break;
            default:SetState(S.PT1Shot);break; // GrowArm
        }
    }
    // HalfInterruptEvent 0x1D95990: the phase change.
    void HalfInterruptEvent()
    {
        Boom("pf_eff_explposion03",SmallBombPosition()); // SkyExplosionEffect(ExplosionCodeLarge, GetSmallBombPosition())
        if(state!=S.PT6Belly){laserCancel=true;CancelLasers();} // _laserCancelFlag; [I] the live beam dissolves
        legHp40=legHp60=0;BreakAllLegs();
        SilentBreak(leg40Part);SilentBreak(leg60Part); // BreakParts(false,false,true): no effect
        phase=1;
    }

    // ---------------------------------------------------------------- PT1Shot (PatternMove1 0x1D965F0)
    void PatternMove1(float dt)
    {
        MoveAround(dt,true,true);TurretLookAt(dt,2,false);
        if(laserCancel){SetState(S.PT6Belly);return;}
        switch(mode)
        {
            case 0:loops=Random.Range(1,4);mode=10;goto case 10; // SetLoopCount(3): Make()%3+1
            case 10:FireEyes();localTime=0;mode=11;goto case 11;
            case 11:localTime+=dt;if(localTime>=ShotWait1Turret)mode=20;break;
            case 20:if(BreakLegFire()){localTime=0;mode=21;goto case 21;}mode=30;goto case 30;
            case 21:localTime+=dt;if(localTime>=ShotWait2Leg)mode=30;break;
            case 30:fireCount++;FireFront();localTime=0;mode=31;goto case 31;
            case 31:
                localTime+=dt;
                if(localTime>=ShotWait3Body){loops=Mathf.Max(0,loops-1);if(loops!=0)mode=10;else CheckNextState();} // ConsumeAttackLoop(1)
                break;
        }
    }

    // ---------------------------------------------------------------- PT4Laser (PatternMove4 0x1D96A20, switch 0x1D977F4)
    void PatternMove4(float dt)
    {
        if(laserCancel){SetState(S.PT6Belly);return;}
        switch(mode)
        {
            case 0:loops=1;mode=10;goto case 10;
            case 10:
                isLeftMove=!isLeftMove;isLaserMove=true;overridePos=position;startVector=position;
                targetVector=new Vector3(isLeftMove?-LaserPositionX:LaserPositionX,startVector.y,startVector.z);
                laserMoveRate=0;localTime=0;mode=11;goto case 11;
            case 11:
                TurretToFront(dt*TurretRestoreSpeed);startVector=position;localTime+=dt;
                laserMoveRate=OutSine(Mathf.Clamp01(localTime/LaserStartPositionMoveTime));
                if(localTime>=LaserStartPositionMoveTime){isLaserMove=false;mode=20;localTime=0;}
                break;
            case 20:
                turretTarget=isLeftMove?-LaserStartAngle:LaserStartAngle;turretStart=turretRY;turretWait=LaserTurretMoveTime;turretPassed=0;
                laserWait=LaserTurretWaitTime+Random.Range(0f,3f);armInterval=0;armCount=phase==0?ArmLimitCount1:ArmLimitCount2;isFired=false;localTime=0;mode=21;
                FireEyes();goto case 21;
            case 21:
                localTime+=dt;
                if(localTime>=laserWait){Round1Sound.Play("bg5_boss_cannon_01");mode=22;localTime=0;BreakLegFire();} // PlayQue 79
                CallArmClips(dt);break;
            case 22:
                if(!TurretRotate(dt,3))
                {
                    // _callLaser (inlined): bos05laser01 from muzzle_turret_laser toward turret_edge; isLeftSide = target > 0
                    Fire(Templates[phase][Laser],laserMuzzle,0,laserEdge);laserTime=LaserIrradiation;
                    Round1Sound.Play(turretTarget>0?"bg5_boss_beam_01":"bg5_boss_beam_02"); // SetSoundId(80, 81/82) [I] beam id at fire
                    mode=23;localTime=0;
                }
                CallArmClips(dt);break;
            case 23:
                localTime+=dt;
                if(localTime>=LaserTurretChargeTime)
                {turretStart=turretTarget;turretWait=(laserTime-LaserHomingTime)*.5f;turretTarget=isLeftMove?-LaserEndAngle:LaserEndAngle;turretPassed=0;mode=24;}
                CallArmClips(dt);break;
            case 24:
                if(!TurretRotate(dt,6)){turretStart=turretTarget;turretTarget=isLeftMove?-LaserStartAngle:LaserStartAngle;turretPassed=0;mode=25;turretWait=(laserTime-LaserHomingTime)*.5f;}
                CallArmClips(dt);break;
            case 25:
                if(!TurretRotate(dt,6)){localTime=0;mode=27;}
                CallArmClips(dt);break;
            case 27:
                localTime+=dt;
                if(localTime>=LaserEndTime){Round1Sound.Play("bg5_boss_cannon_01");isLaserMove=true;localTime=0;mode=28;}
                if(loops>1)CallArmClips(dt);
                break;
            case 28:
            {
                if(isLaserMove)
                {
                    localTime+=dt;laserMoveRate=1-InOutCubic(Mathf.Clamp01(localTime/LaserEndPositionMoveTime));
                    if(localTime>=LaserEndPositionMoveTime)isLaserMove=false;
                }
                bool check;
                if(loops>1){CallArmClips(dt);check=true;}
                else
                {
                    check=TurretToFront(dt*TurretRestoreSpeed);
                    if(!isFired){fireCount++;FireFront();isFired=true;}
                }
                if(check&&!isLaserMove){loops=Mathf.Max(0,loops-1);if(loops!=0)mode=21;else CheckNextState();}
                break;
            }
        }
        // Every frame: the side move rides MoveAround's override (CurrentTargetVector linear from the current position).
        startVector=position;
        var v=Vector3.Lerp(startVector,targetVector,Mathf.Clamp01(laserMoveRate));
        overridePos.x=v.x;overrideRate=laserMoveRate;
        var r=MoveAround(dt,laserMoveRate<1,true);overridePos.z=r.z;
        if(laserMoveRate==1)floatTimerX=FloatHorizonTime*(isLeftMove?.75f:.25f);
    }

    // _callArmClips 0x1D99690: launch both arms every 2.5 s while _armCount lasts.
    void CallArmClips(float dt)
    {
        if(armCount<=0)return;
        armInterval-=dt;if(armInterval>0)return;
        armInterval=ArmFireInterval;
        bool inner=position.x<0;
        bool a=LaunchArm(true,inner),b=LaunchArm(false,!inner);
        if(a||b){armPurged=true;armCount--;}
    }
    bool LaunchArm(bool left,bool turnInner)
    {
        var part=left?arm40Part:arm60Part;int destroyed=left?arm40Destroyed:arm60Destroyed;
        bool broken=part==null||part.broken;
        if(!(destroyed<ArmGenerateLimitCount||!broken))return false;
        Purge(part); // BreakParts(false,false,false): the body arm leaves
        var mesh=left?arm40Mesh:arm60Mesh;if(!mesh||!visual)return true;
        var launch=SourceOf(mesh.position);
        var born=!broken&&!armPurged?launch:SourceOf(mesh.TransformPoint(ArmMeshInner));
        var rot=facing*Quaternion.Inverse(visual.transform.rotation)*mesh.rotation;
        var arm=new Arm{born=born,launch=launch,parentOffset=position,inner=turnInner,left=left,up=ArmUpPosY};
        var m=Summon(ArmModel,born,Vector3.zero,(mm,t)=>StepArm(arm,t),ArmHealth);
        if(m==null)return true;
        // Ene_Bos05_Arm.Setup 0x1D93920
        var d=rot*Vector3.forward;d.y=0;arm.dir=d.sqrMagnitude>1e-10f?d.normalized:Vector3.forward; // [I] zero heading guard
        arm.baseRot=Quaternion.Inverse(Quaternion.LookRotation(arm.dir,Vector3.up))*rot;
        arm.clockwise=arm.dir.x>0;arm.mode=(born-launch).sqrMagnitude<1e-10f?1:0;arm.m=m;
        m.facing=Quaternion.LookRotation(arm.dir,Vector3.up)*arm.baseRot;
        arm.scaleNode=m.target.visual?m.target.visual.transform.Find("scaleNode"):null;
        if(arm.scaleNode)arm.scaleNode.localScale=Vector3.one;
        arms.Add(arm);return true;
    }
    // Ene_Bos05_Arm.LocalLateUpdate 0x1D92FF0
    void StepArm(Arm a,float dt)
    {
        var m=a.m;if(m==null)return;
        switch(a.mode)
        {
            case 0: // Grow
            {
                a.timer+=dt;float t=Mathf.Clamp01(a.timer/ArmGrowTime);
                m.position=a.launch+(a.born-a.launch)*Mathf.Clamp01(Mathf.Pow(1-t,4))+(position-a.parentOffset);
                if(a.scaleNode)a.scaleNode.localScale=Vector3.one*Mathf.Lerp(ArmMinGrowScale,1,InOutQuad(t));
                if(!a.se&&a.timer>=ArmGrowTime*.5f){a.se=true;Round1Sound.Play("bg5_boss_parts_return_01");} // PlayQue 78
                if(a.timer>=ArmGrowTime){a.se=false;a.speed=0;a.mode=1;a.timer=0;} // collision NoHitSubject cleared
                break;
            }
            case 1: // Fire
                if(!a.se){a.se=true;Round1Sound.Play("bg5_boss_parts_firing_01");} // PlayQue 77
                a.speed+=ArmSpeed/ArmAcceleTime*dt;
                if(a.speed>=ArmSpeed){a.speed=ArmSpeed;if(!a.inner)a.mode=2;else{a.timer+=dt;if(a.timer>=ArmStartMoveTime)a.mode=2;}}
                UpdateArm(a,dt);break;
            case 2: // Turn (_UpdateTurn 0x1D94640)
                a.turn+=ArmSpeed/ArmTurnBaseSpeed*(a.inner?ArmTurnInner:ArmTurnOuter)*(a.clockwise?1:-1)*dt;
                if(a.turn>180){a.turn=180;a.mode=3;}else if(a.turn<-180){a.turn=-180;a.mode=3;}
                UpdateArm(a,dt);
                if(a.up>0){float d=dt*ArmUpPosY/ArmUpTime;m.position.y+=d;a.up-=d;} // rises 50 toward the camera over 3 s
                break;
            default: // Move: leaves the field (vslot 29 despawn, not a kill); [I] source x for the world x test
            {
                UpdateArm(a,dt);
                var h=Quaternion.AngleAxis(a.turn,Vector3.up)*a.dir;
                if(h.x>0&&m.position.x>200||h.x<0&&m.position.x<-200)combat.DespawnSourceTarget(m.target);
                break;
            }
        }
    }
    // _UpdateTransform 0x1D94180; [I] product order look * base * twist
    void UpdateArm(Arm a,float dt)
    {
        var h=Quaternion.AngleAxis(a.turn,Vector3.up)*a.dir;
        a.twist=Mathf.Repeat(a.twist+dt*ArmTwistSpeed,360);
        a.m.position+=h*a.speed*dt;
        a.m.facing=Quaternion.LookRotation(h,Vector3.up)*a.baseRot*Quaternion.AngleAxis(a.twist,Vector3.forward);
    }
    // Ene_Bos05_Arm.ToDestroid 0x1D94090: a killed arm counts for its side while the boss lives.
    void CountArms()
    {
        for(int i=arms.Count-1;i>=0;i--)
        {
            var a=arms[i];if(a.m!=null&&a.m.Alive)continue;
            if(a.m!=null&&a.m.target!=null&&a.m.target.health<=0){if(a.left)arm40Destroyed++;else arm60Destroyed++;}
            arms.RemoveAt(i);
        }
    }

    // ---------------------------------------------------------------- PT6Belly (PatternMove6 0x1D97840)
    void PatternMove6(float dt)
    {
        MoveAround(dt,true,true);TurretToFront(dt*TurretRestoreSpeed);
        switch(mode)
        {
            case 0:
                localTime=0;mode=10;loops=1; // SetLoopCount(1); NoHitSubject on the unbroken arm parts [?] not modelled
                Round1Sound.Play("bg5_boss_turning_01");laserCancel=false;goto case 10; // PlayQue 75
            case 10:
                localTime+=dt;facing=baseFacing*Quaternion.Euler(BellyTurnAngleX*InOutCubic(Mathf.Clamp01(localTime/BellyTurnTime)),0,0);
                if(localTime>=BellyTurnTime){localTime=0;mode=20;}
                break;
            case 20:
                if(!laserCancel)Fire(Templates[phase][Berry],body21);
                localTime=0;mode=21;break;
            case 21:
                localTime+=dt;
                if(localTime>=BellyFireInterval)
                {
                    if(IsAttackLoop()&&!laserCancel)mode=20;
                    else{localTime=0;mode=30;Round1Sound.Play("bg5_boss_turning_01");}
                }
                break;
            case 30:
                localTime+=dt;facing=baseFacing*Quaternion.Euler(BellyTurnAngleX*(1-InOutQuad(Mathf.Clamp01(localTime/BellyTurnTime))),0,0);
                if(localTime>=BellyTurnTime)CheckNextState();
                break;
        }
    }
    bool IsAttackLoop(){loops--;if(loops>0)return true;loops=0;return false;} // Ene_BosBase.IsAttackLoop 0x1DB9E60

    // ---------------------------------------------------------------- GrowArm (PatternMoveGrowArm 0x1D98450)
    void PatternMoveGrowArm(float dt)
    {
        MoveAround(dt,true,true);
        switch(mode)
        {
            case 0:
                if(arm40Destroyed<ArmGenerateLimitCount){Repair(arm40Part);if(arm40Node)arm40Node.localPosition=Arm40Inner;armPurged=true;}
                if(arm60Destroyed<ArmGenerateLimitCount){Repair(arm60Part);if(arm60Node)arm60Node.localPosition=Arm60Inner;armPurged=true;}
                localTime=0;mode=10;goto case 10;
            case 10:
            {
                localTime+=dt;
                if(localTime>=.5f&&armPurged){Round1Sound.Play("bg5_boss_parts_return_01");armPurged=false;} // PlayQue 78
                TurretLookAt(dt,3,false);
                float t=Mathf.Clamp01(localTime/ArmGrowTime),e=OutQuart(t),s=Mathf.Lerp(ArmMinGrowScale,1,InOutQuad(t));
                if(arm40Node)arm40Node.localPosition=Vector3.Lerp(Arm40Inner,Vector3.zero,e);
                if(arm60Node)arm60Node.localPosition=Vector3.Lerp(Arm60Inner,Vector3.zero,e);
                if(arm60Scale)arm60Scale.localScale=Vector3.one*s;if(arm40Scale)arm40Scale.localScale=Vector3.one*s;
                if(localTime>=ArmGrowTime)CheckNextState();
                break;
            }
        }
    }

    // ---------------------------------------------------------------- movement (MoveAround 0x1D96160)
    Vector3 MoveAround(float dt,bool horizontal,bool vertical)
    {
        floatSpeed=Mathf.Min(1,floatSpeed+dt);float s=floatSpeed*dt;
        var p=position;
        if(horizontal){floatTimerX=(floatTimerX+s)%FloatHorizonTime;p.x=center.x+FloatHorizonDistance*Mathf.Sin(floatTimerX/FloatHorizonTime*2*Mathf.PI);}
        if(vertical){floatTimerZ=(floatTimerZ+s)%FloatVerticalTime;p.z=center.z+FloatVerticalDistance*Mathf.Sin(floatTimerZ/FloatVerticalTime*2*Mathf.PI);}
        position=p+(overridePos-p)*Mathf.Clamp01(overrideRate);
        overrideRate=Mathf.Max(0,overrideRate-dt/FloatAutoRecoverTime);
        return p;
    }

    // ---------------------------------------------------------------- turret (laser_body yaw)
    // TurretRotate 0x1D99470: true while a rotation was running.
    bool TurretRotate(float dt,int ease)
    {
        bool moving=turretWait>0;turretPassed+=dt;
        if(moving){float e=Ease(Mathf.Clamp01(turretPassed/turretWait),ease);turretRY=turretStart+(turretTarget-turretStart)*e;if(e>=1)turretWait=0;}
        ApplyTurret();return moving;
    }
    // TurretLookAt 0x1D992A0: retarget at the player (40 deg/s average) whenever the last turn is done.
    void TurretLookAt(float dt,int ease,bool toFront)
    {
        if(TurretRotate(dt,ease))return;
        var v=position-PlayerSource;v.y=0;
        // GetPlaneEuler(boss - player).y: LookRotation yaw in [-180,180)
        turretTarget=toFront||v.sqrMagnitude<1e-6f?0:Mathf.Atan2(v.x,v.z)*Mathf.Rad2Deg;
        turretStart=turretRY;turretPassed=0;turretWait=Mathf.Abs(turretTarget-turretRY)*.025f;
    }
    // TurretToFront 0x1D99590
    bool TurretToFront(float step)
    {
        if(turretRY>0){turretRY-=step;if(turretRY<0)turretRY=0;}else{turretRY+=step;if(turretRY>0)turretRY=0;}
        turretWait=0;turretPassed=0;turretStart=turretRY;ApplyTurret();return turretRY==0;
    }
    void ApplyTurret(){if(turret)turret.localRotation=Quaternion.Euler(0,turretRY,0);}

    // ---------------------------------------------------------------- fire
    void FireEyes(){foreach(var mz in packMuzzles)Fire(Templates[phase][Eyes],mz);} // BulletFireByMuzzlePack("turret")
    void FireFront(){Fire(Templates[phase][FrontA+((~fireCount)&1)],body20);}   // FrontA on odd _fireCount, FrontB on even
    // BreakLegFire 0x1D94C60: every broken leg (upper renderer hidden) fires Legs with its _LegAngle offset.
    bool BreakLegFire()
    {
        bool fired=false;
        for(int i=0;i<6;i++)if(legUpper[i]&&!legUpper[i].enabled&&legMuzzles[i]){Fire(Templates[phase][Legs],legMuzzles[i],LegAngle[i]);fired=true;}
        return fired;
    }

    // ---------------------------------------------------------------- parts
    // AddDamageParts 0x1D92FA0 / BreakParts 0x1D95070: legs break as their part HP passes 2/3, 1/3, 0 (driven from health here).
    void CheckLegs()
    {
        if(leg40Part!=null){float hp=leg40Part.HealthRatio;
            if(hp<=LegHP66&&legHp40>LegHP66){legHp40=LegHP66;BreakLeg(0);}
            if(hp<=LegHP33&&legHp40>LegHP33){legHp40=LegHP33;BreakLeg(1);}
            if(hp<=LegHP00&&legHp40>LegHP00){legHp40=LegHP00;BreakLeg(2);}}
        if(leg60Part!=null){float hp=leg60Part.HealthRatio;
            if(hp<=LegHP66&&legHp60>LegHP66){legHp60=LegHP66;BreakLeg(3);}
            if(hp<=LegHP33&&legHp60>LegHP33){legHp60=LegHP33;BreakLeg(4);}
            if(hp<=LegHP00&&legHp60>LegHP00){legHp60=LegHP00;BreakLeg(5);}}
    }
    // BreakLeg 0x1D94E80: hide the leg, middle explosion at its muzzle (always).
    void BreakLeg(int i)
    {
        if(legUpper[i]&&legUpper[i].enabled){legUpper[i].enabled=false;if(legLower[i])legLower[i].enabled=false;}
        if(legMuzzles[i])Boom("pf_eff_explposion02",legMuzzles[i]);
    }
    void BreakAllLegs(){for(int i=0;i<6;i++)BreakLeg(i);} // BreakAllLegs 0x1D94A30
    // OnPartsBreak 0x1D96440 (+ the PartsList BreakEffect): arms count toward the regrow limit, legs finish their breaks.
    protected override void PartBroken(Part part)
    {
        if(part==arm40Part||part==arm60Part)
        {
            if(part==arm40Part)arm40Destroyed++;else arm60Destroyed++;
            Boom("pf_eff_explposion03",part.root);if(part.root&&visual&&part.root!=visual.transform)part.root.gameObject.SetActive(false);
            Round1Sound.Event("enemyDead");
        }
        else if(part==leg40Part||part==leg60Part)
        {
            Boom("pf_eff_explposion02",legNodes[part==leg40Part?1:4]); // BreakEffect at _explosionRoot pf_bs05_leg40 / pf_bs05_leg60
            CheckLegs();Round1Sound.Event("enemyDead");
        }
        else base.PartBroken(part);
    }
    // EnePartsGroup.BreakParts(withEffect false): broken without effect or kill score.
    void SilentBreak(Part p)
    {
        if(p==null||p.broken||p.body)return;
        p.broken=true;if(p.target!=null){p.target.health=0;p.target.invulnerable=true;combat.DespawnSourceTarget(p.target);}
    }
    void Purge(Part p){if(p==null||p.broken)return;SilentBreak(p);if(p.root&&visual&&p.root!=visual.transform)p.root.gameObject.SetActive(false);}
    // EnePartsGroup.RepairParts(true). The base has no repair: revive the part target here (full HP, live again).
    void Repair(Part p)
    {
        if(p==null||p.body)return;
        p.broken=false;if(p.root)p.root.gameObject.SetActive(true);
        if(p.target!=null){p.target.health=p.target.maxHealth;p.target.active=true;}
        SetPartVulnerable(p,p.enabled);
    }

    // GetSmallBombPosition 0x1D957B0: between a random Boss05MZ muzzle and a random leg muzzle.
    Vector3 SmallBombPosition()
    {
        var a=smallBombMuzzles[Random.Range(0,4)];var b=legMuzzles[Random.Range(0,6)];
        if(!a||!b)return visual?visual.transform.position:transform.position;
        return Vector3.Lerp(a.position,b.position,Random.value);
    }
    // World point of a boss child -> source sky-plane units (the hull is placed from position and facing).
    Vector3 SourceOf(Vector3 world)=>position+facing*visual.transform.InverseTransformPoint(world);

    // ---------------------------------------------------------------- destruction (ToDestroid 0x1D991B0, PatternMoveDestruction 0x1D97E60)
    // The base sequence matches the native one (sink 150 in 5.5 s EaseIn, turn to (20,45,0), dead effect at 3.5 s); add
    // the native sounds it does not play: _overplayDeadSound 41 at the dead effect, PlayQue 42 at the end.
    protected override void Defeat(float dt)
    {
        base.Defeat(dt);
        if(!deadSe&&StateAge>=DeadEffectTime){deadSe=true;Round1Sound.Play("exp_st3_boss_b02");}
        if(!endSe&&StateAge>=defeatDuration-.001f){endSe=true;Round1Sound.Play("exp_st3_boss_c03");}
    }
    public override void OnDefeated(){base.OnDefeated();arms.Clear();laserCancel=false;}
    public override void ResetEncounter(){arms.Clear();base.ResetEncounter();}

    // ---------------------------------------------------------------- easing (KANAI.Kernel.EasingUtility)
    static float Ease(float t,int type) // Easing01 0x1DE8100: 2 EaseOut, 3 EaseInOut, 6 EaseOutSine
    {
        switch(type)
        {
            case 1:return t*t;
            case 2:return 1-(1-t)*(1-t);
            case 3:return InOutQuad(t);
            case 6:return OutSine(t);
            default:return t;
        }
    }
    // 0x1DE8BC0 VectorUtility.Sinf(t*90); [I] exactly 1 at t 1 so PT4's "laserMoveRate == 1" side hold triggers
    static float OutSine(float t)=>t>=1?1:Mathf.Sin(t*90*Mathf.Deg2Rad);
    static float InOutQuad(float t)=>t<.5f?2*t*t:1-2*(1-t)*(1-t);                                  // 0x1DE8650
    static float InOutCubic(float t)=>t<.5f?4*t*t*t:1-4*(1-t)*(1-t)*(1-t);                         // 0x1DE8600
    static float OutQuart(float t){float u=1-t;return 1-u*u*u*u;}                                   // 0x1DE8B90
}
