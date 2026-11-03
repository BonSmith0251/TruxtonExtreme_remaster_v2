using UnityEngine;

// Ene_Bos06, the BG07 boss, from the native code (evidence/bosses/Bos06/SPEC.md; addresses there and below).
// Root `position`/`facing` are the Pf_Ene_Bos06 root in the sky plane. The children of pf_bs06 (_modelTop, yawed 180 after
// the entrance) are driven in their own local frame exactly as the native code writes them. Marked [I]/[?] where the spec does.
// Parts (enemy-hitshapes PartsList order): 0 MainBody, 1 TopBody (cover), 2 body40, 3 body60 (database rows, own HP),
// 4 CoreBody. The native PartsKind LeftBody (2) is body40 = _bodyR; _bodyL/_laserL are the 60 side.
public class Bos06Boss : StageBoss
{
    enum Phase { PT1, PT3Break, PT6Bind, PT7Change, PT8 }

    // Ene_Bos06..cctor (0x1D9EC90).
    static readonly Vector3 CoreHome=new Vector3(0,0,-5),CoreAttack=new Vector3(0,0,-30),CoreSafe=new Vector3(0,-50,-20);
    static readonly Quaternion LaserRotateBodyL=Quaternion.Euler(0,-45,90),LaserRotateBodyR=Quaternion.Euler(0,45,-90),PartsBreakRotation=Quaternion.Euler(-60,0,0);
    const float EntryNoHitTime=3.2f,P1Interval=7,P1FireStart=1,P1Width=20,P1Height=10,SlideStep=.02f,P2Interval=4,P2Width=30,P2Height=5;
    const int P1Count=2,P2Count=3;
    static readonly Vector3 LeftSlide=new Vector3(-60,0,0),RightSlide=new Vector3(60,0,0),BodyLeftBase=new Vector3(110,0,0),BodyRightBase=new Vector3(-110,0,0);
    static readonly float[] P2Angles={90,45,0};
    const float BaseDistance=110,PinchMove=40;
    // CoreMovement..cctor (0x1D8ADA0).
    const float EvacuateDelay=.5f,EvacuateTime=1,RotatePerSecond=180,FloatCycle=3,FloatDistance=20,CombatTime=1.5f,CircuitTime=5,CircuitRadius=10,CircuitFire=.8f;
    // BatteryMovement..cctor (0x1DA03C0).
    const float LaserInterval=3,FollowStart=0,FollowStop=1,LaserCall=.2f,FollowTime=1,BatteryFloatCycle=5,BatteryFloatDistance=10;
    // Prefab _easingCurve (Pf_Ene_Bos06 Ene_Bos06; weightedMode 0, so the weights are unused).
    static readonly AnimationCurve EasingCurve=new AnimationCurve(new Keyframe(0,0,0,0),new Keyframe(.2f,.15f,1.1118432f,1.1118432f),
        new Keyframe(.5f,.5f,1.1666667f,1.1666667f),new Keyframe(.8f,.85f,1.1105995f,1.1105995f),new Keyframe(1,1,0,0));
    // Boss06MZ order (_muzzles), paths under the prefab root.
    static readonly string[] MuzzlePaths={
        "pf_bs06/pf_bs06_core01/muzzle_core_core","pf_bs06/pf_bs06_core01/muzzle_core_battery","pf_bs06/bs06_body01_top01/muzzle_top_core",
        "pf_bs06/bs06_body01_40/muzzle_body_core_40","pf_bs06/bs06_body01_60/muzzle_body_core_60",
        "pf_bs06/bs06_body01_40/pf_bs06_body01_battery01_40/muzzle_battery","pf_bs06/bs06_body01_60/pf_bs06_body01_battery01_60/muzzle_battery",
        "pf_bs06/bs06_body01_40/pf_bs06_body01_battery01_40/muzzle_battery/target40","pf_bs06/bs06_body01_60/pf_bs06_body01_battery01_60/muzzle_battery/target60"};
    const int MzCoreCore=0,MzCoreBattery=1,MzTopCore=2,MzBody40=3,MzBody60=4,MzBatteryL=5,MzBatteryR=6,MzTargetL=7,MzTargetR=8;

    class Battery {public Transform cover,battery,muzzle,target;public bool enable;public float timer,startYaw,targetYaw,fl,axisYaw;}

    readonly Transform[] mz=new Transform[MuzzlePaths.Length];
    Transform modelTop,bodyL,bodyR,core,laserL,laserR,col40,col40c,col60,col60c;
    GameObject bindEffect;
    AnimationClip entranceClip,coverClip;
    Part pTop,p40,p60,pCore;
    readonly Battery left=new Battery(),right=new Battery();

    Phase phase;int mode;float localTime,dirTotal=1,dirPassed;
    bool coverOpen,brokenL,brokenR,touchSet;
    Vector3 startInGame,startVec,targetVec;Quaternion startRot,targetRot;
    // PT1 (_circuitCount, _repeatCount, _playerSlider, side attack, _batteryAngle).
    int circuit,repeat;float slider=.5f,sideTime,batteryAngle;bool sideEnable,sideLeft;
    bool pLeft,pBottom,pCenter;Vector3 player;
    // PT6Bind.
    int loopCount;float pinchHome,pinchTarget;
    // CoreMovement.
    int coreMode,fireCount,firePatterns=2;float coreTimer,coreRot,coreFloat,coreAccel,coverAnim=-1;
    // Destruction.
    float defeatWait,bombBase,bombLeft;bool defeatSetup,deadFx,finalSound;Vector3 coreFrom,coreTo;Quaternion coreRotFrom;

    protected override void OnSpawned()
    {
        for(int i=0;i<mz.Length;i++)mz[i]=Find(MuzzlePaths[i]);
        modelTop=Find("pf_bs06");bodyL=Find("pf_bs06/bs06_body01_60");bodyR=Find("pf_bs06/bs06_body01_40");core=Find("pf_bs06/pf_bs06_core01");
        laserL=Find("pf_bs06/bs06_body01_60/pf_bs06_body01_battery01_60");laserR=Find("pf_bs06/bs06_body01_40/pf_bs06_body01_battery01_40");
        col40=Find("pf_bs06/bs06_body01_40/body40");col40c=Find("pf_bs06/bs06_body01_40/body40c");col60=Find("pf_bs06/bs06_body01_60/body60");col60c=Find("pf_bs06/bs06_body01_60/body60c");
        var fx=Find("pf_bs06/bs06_body01_60/pf_eff_e_attack01");bindEffect=fx?fx.gameObject:null;
        // The native code runs the clips itself (StopAnime / DelayAnimationTask); idle states would overwrite our transforms.
        entranceClip=coverClip=null;
        if(visual)foreach(var a in visual.GetComponentsInChildren<Animator>(true))
        {
            if(a.runtimeAnimatorController)foreach(var c in a.runtimeAnimatorController.animationClips)
            {if(c.name=="anc_bs06_start")entranceClip=c;else if(c.name=="anc_bs06_core01_cover_op")coverClip=c;}
            a.enabled=false;
        }
        p40=GetPart("body40");p60=GetPart("body60");pTop=pCore=null;
        foreach(var p in parts){if(p.root&&p.root.name=="bs06_body01_top01")pTop=p;else if(p.root&&p.root.name=="pf_bs06_core01")pCore=p;}
        // PartsFlag SleepStart: body40, body60 and the core start asleep (no collision).
        foreach(var p in new[]{p40,p60,pCore})if(p!=null)p.enabled=false;
        // ReStart (0x1D9DAE0).
        phase=Phase.PT1;mode=0;coverOpen=brokenL=brokenR=false;slider=.5f;batteryAngle=0;circuit=repeat=0;firePatterns=2;fireCount=0;
        coreMode=0;coreTimer=coreRot=coreFloat=coreAccel=0;coverAnim=-1;touchSet=false;
        if(bodyL){bodyL.localPosition=Vector3.zero;bodyL.localRotation=Quaternion.identity;}
        if(bodyR){bodyR.localPosition=Vector3.zero;bodyR.localRotation=Quaternion.identity;}
        if(core){core.localPosition=CoreHome;core.localRotation=Quaternion.identity;}
        BatteryMove(0);
        Init(left,bodyL,laserL,mz[MzBatteryR],mz[MzTargetR]);Init(right,bodyR,laserR,mz[MzBatteryL],mz[MzTargetL]);
        SetCollision(col40,col40c,false);SetCollision(col60,col60c,false);
        Target.lockOn=false;Target.touchesWhileInvulnerable=false;
        defeatSetup=deadFx=finalSound=false;
    }

    // ---- EntryWait (0x1D9BC90) ----
    protected override bool Entrance(float dt)
    {
        position=Current.rest;
        if(StateAge-dt<=0){if(bindEffect)bindEffect.SetActive(false);Round1Sound.Play("bg7_boss_app_01");}
        float length=entranceClip?entranceClip.length:5;
        if(entranceClip&&modelTop)Round1AnimationSampling.Sample(entranceClip,modelTop.gameObject,Mathf.Min(StateAge,length));
        // Mode 1: after 3.2 s collision is on but OffLockon|NoDamaged: solid, not damageable.
        if(StateAge>=EntryNoHitTime&&!touchSet){touchSet=true;Target.touchesWhileInvulnerable=true;}
        // Mode 2 waits for mover._isFinishDelay (the stack events after the 5 s clip) [I: clip length].
        if(StateAge<length)return false;
        if(modelTop){modelTop.localPosition=Vector3.zero;modelTop.localRotation=Quaternion.Euler(0,180,0);}
        return true;
    }
    protected override void OnFightStart()
    {
        // ResetBossTimer(true): _startInGamePosition is the root position now.
        Target.touchesWhileInvulnerable=false;startInGame=position;phase=Phase.PT1;mode=0;
    }

    // ---- StateExec (0x1D9E370); Ene_BosBase.ProgressBossTimer advances the direction timer first ----
    protected override void Fight(float dt)
    {
        dirPassed+=dt;
        // Ene_BosBase.LocalLateUpdate (0x1DB9FF0): player side flags.
        player=PlayerSource;pLeft=player.x<0;pBottom=player.z<-20;pCenter=player.x>-100&&player.x<100;
        switch(phase)
        {
            case Phase.PT1:PT1(dt);break;
            case Phase.PT3Break:PT3Break(dt);break;
            case Phase.PT6Bind:PT6Bind(dt);break;
            case Phase.PT7Change:PT7Change(dt);break;
            case Phase.PT8:PT8(dt);break;
        }
        StepCoverAnimation(dt);
        sinkDepth=Mathf.Max(0,-position.y); // root y away from the camera (PT3Break -150) shrinks the boss by perspective
    }
    void SetState(Phase p){phase=p;mode=0;} // SetState/CheckNextState (0x1D9E070/0x1D9B050)
    void SetDir(float t){dirTotal=t;dirPassed=0;} // Ene_BosBase.SetDirectionTime (0x1DBA4D0)
    float Rate=>dirTotal>0?Mathf.Clamp01(dirPassed/dirTotal):0; // GetDirectionRate (0x1DB9A20)

    // ---- PT1 (0x1D9BEE0) ----
    void PT1(float dt)
    {
        // Inline CheckCoverBreak: IsOverAorB(HalfHP, Passed90) -> HP <= 51% or 90 s of boss time.
        if(!coverOpen&&(HpState>=3||BossTime>=90)&&pTop!=null&&!pTop.broken)
        {
            SetState(Phase.PT3Break);BreakPart(pTop);coverOpen=true;
            CancelLasers(); // [I] stands in for the _bulletToken cancel (pending core1short / laser01 tasks)
            return;
        }
        switch(mode)
        {
            case 0:circuit=0;sideEnable=false;sideTime=0;goto case 10;
            case 10:repeat=0;mode=11;goto case 11;
            case 11:SetDir(P1Interval);CheckSideAttack();localTime=0;mode=12;goto case 12;
            case 12:
            {
                float r=Rate;MoveCircle(LapEase(r),P1Width,P1Height,dt);SideAttack(dt,r<.8f);
                float old=localTime;localTime+=dt;
                if(old<P1FireStart&&localTime>P1FireStart)Fire("bos06_core1short",mz[MzTopCore]);
                if(r>=1){circuit++;repeat++;mode=repeat<P1Count?11:20;}
                break;
            }
            case 20:repeat=0;mode=21;goto case 21;
            case 21:SetDir(P2Interval);CheckSideAttack();CallLaserBT();localTime=0;mode=22;goto case 22;
            case 22:
            {
                float r=Rate;MoveCircle(LapEase(r),P2Width,P2Height,dt);SideAttack(dt,r<.8f);
                localTime+=dt;
                float s=Mathf.Clamp01(InSine01(Mathf.Clamp01(localTime)));
                BatteryMove(batteryAngle+(P2Angles[repeat%P2Angles.Length]-batteryAngle)*s);
                if(r>=1){circuit++;repeat++;mode=repeat<P2Count?21:10;}
                break;
            }
        }
    }
    // Even laps run the loop backwards (test byte _circuitCount,1 at 0x1D9C147).
    float LapEase(float r){float e=EasingCurve.Evaluate(r);return (circuit&1)==0?1-e:e;}
    // _moveCircle (0x1D9F4C0): slow slide toward the player's side plus the CircleSymbol loop.
    void MoveCircle(float rate,float w,float h,float slideDt)
    {
        if(!pCenter)slider=Mathf.Clamp01(slider+(pLeft?-SlideStep:SlideStep)*slideDt);
        position=startInGame+Vector3.Lerp(LeftSlide,RightSlide,slider)+CircleSymbol(rate,w,h);
    }
    // VectorUtility.CircleSymbol (0x1DF6AF0).
    static Vector3 CircleSymbol(float t,float w,float h){float a=(90+360*Mathf.Clamp01(t))*Mathf.Deg2Rad;return new Vector3(w*Mathf.Cos(a),0,h*(1-Mathf.Sin(a)));}
    void CheckSideAttack(){sideTime=0;sideEnable=!pBottom;sideLeft=pLeft;} // 0x1D9B100
    // SideAttack (0x1D9E0B0): side1 at 0.5 s and side2 at 1.0 s of every second, from the player's side.
    void SideAttack(float dt,bool attack)
    {
        if(!(sideEnable&&attack))return;
        float old=sideTime;sideTime+=dt;
        var m=sideLeft?mz[MzBody60]:mz[MzBody40];float angle=sideLeft?-90:90;
        if(old<.5f&&sideTime>=.5f)Fire("bos06_side1",m,angle);
        if(old<1&&sideTime>=1)Fire("bos06_side2",m,angle);
        sideTime=Mathf.Clamp01(sideTime-Mathf.Floor(sideTime));
    }
    // _callLaserBT (0x1D9EA80): both batteries, muzzle toward its target child.
    void CallLaserBT(){Fire("bos06laser01",mz[MzBatteryL],0,mz[MzTargetL]);Fire("bos06laser01",mz[MzBatteryR],0,mz[MzTargetR]);}
    // BatteryMove (0x1D9AD50).
    void BatteryMove(float a)
    {
        batteryAngle=a;
        if(laserL)laserL.localRotation=Quaternion.Euler(0,a,0);
        if(laserR)laserR.localRotation=Quaternion.Euler(0,-a,0);
    }

    // ---- PT3Break (0x1D9C690, table 0x1D9CF34) ----
    void PT3Break(float dt)
    {
        switch(mode)
        {
            case 0:
                CancelLasers(); // mover._laserCancelFlag = 1
                startVec=position;startRot=facing;targetRot=PartsBreakRotation;targetVec=startVec+new Vector3(0,-150,50);SetDir(1);
                foreach(var p in parts)if(!p.broken)p.enabled=false; // ToSleep every unbroken part
                SetVulnerable(false);localTime=0;mode=1;break;
            case 1:
            {
                float r=Rate;position=Vector3.Lerp(startVec,targetVec,OutQuad(r));facing=Quaternion.Slerp(startRot,targetRot,OutQuart(r));
                if(r>=1){localTime=0;mode=2;}
                break;
            }
            case 2:
                localTime+=dt;
                if(localTime>=.5f){Round1Sound.Play("bg7_boss_move_the_bow_01");startRot=facing;targetRot=Quaternion.identity;SetDir(1);mode=3;}
                break;
            case 3:
            {
                float r=Rate;facing=Quaternion.Slerp(startRot,targetRot,InOutQuad(r));
                if(r>=1){Round1Sound.Play("bg7_boss_rise_01");SetDir(1.5f);startVec=position;targetVec=startInGame;mode=10;}
                break;
            }
            case 10:
            {
                float r=Rate;position=Vector3.Lerp(startVec,targetVec,InOutQuad(r));
                if(r>=1){localTime=.5f;mode=11;}
                break;
            }
            case 11:
                localTime-=dt;
                if(localTime<=0)
                {
                    Round1Sound.Play("bg7_boss_separation_01");SetDir(2);CoverPartsHitType(false);
                    if(laserL)laserL.localRotation=Quaternion.identity;if(laserR)laserR.localRotation=Quaternion.identity;
                    slider=.5f;CoreEvacuate();mode=12;
                }
                break;
            case 12:
            {
                float e=OutQuad(Rate);
                if(bodyL)bodyL.localPosition=BodyLeftBase*Mathf.Clamp01(e);
                if(bodyR)bodyR.localPosition=BodyRightBase*Mathf.Clamp01(e);
                CoreProgress(dt);
                if(e>=1&&coreMode==3)SetState(Phase.PT6Bind);
                break;
            }
        }
    }
    // CoverPartsHitType (0x1D9B220): collision 0 (body40/body60) while closed, collision 1 (body40c/body60c) in laser
    // mode; _noDamageFlag = !laser. A shield is solid but undamageable: touchesWhileInvulnerable.
    void CoverPartsHitType(bool laser)
    {
        SetCollision(col40,col40c,laser);SetCollision(col60,col60c,laser);
        foreach(var p in new[]{p40,p60})
        {
            if(p==null||p.broken)continue;
            p.enabled=true;SetPartVulnerable(p,laser);
            if(p.target!=null)p.target.touchesWhileInvulnerable=!laser;
        }
    }
    // The live circles skip inactive collision transforms; these nodes carry no renderers.
    static void SetCollision(Transform closed,Transform open,bool laser){if(closed)closed.gameObject.SetActive(!laser);if(open)open.gameObject.SetActive(laser);}

    // ---- PT6Bind (0x1D9CF70) and coverMoveX (0x1D9E6C0) ----
    void PT6Bind(float dt)
    {
        CoreProgress(dt);
        switch(mode)
        {
            case 0:loopCount=2;Round1Sound.Play("bg7_boss_move_01");mode=10;goto case 10;
            case 10:
            {
                if(!bodyL)break;
                float bodyZ=SkyPoint(bodyL.position).z;pinchHome=bodyL.localPosition.z;
                // Model z is mirrored by the 180 yaw of pf_bs06: -40 moves the bodies up toward the player [I].
                pinchTarget=pinchHome+(player.z>bodyZ?-PinchMove:PinchMove);
                SetDir(.8f);mode=11;goto case 11;
            }
            case 11:
            {
                float e=InOutQuad(Rate);SetBodyZ(pinchHome+(pinchTarget-pinchHome)*Mathf.Clamp01(e),pinchHome+(pinchTarget-pinchHome)*Mathf.Clamp01(e));
                if(e>=1){SetDir(2);mode=20;}
                break;
            }
            case 20:
                if(CoverMoveX(false))
                {
                    Round1Sound.Play("bg7_boss_gattai_01");SetDir(1);
                    if(bindEffect){bindEffect.SetActive(true);var ps=bindEffect.GetComponent<ParticleSystem>();if(ps)ps.Play(true);}
                    mode=21;
                }
                break;
            case 21:if(Rate>=1){SetDir(2);mode=22;}break;
            case 22:
                if(CoverMoveX(true))
                {
                    // Ene_BosBase.IsAttackLoop (0x1DB9E60) pre-decrements: two pinches.
                    if(--loopCount>0){Round1Sound.Play("bg7_boss_separation_01");localTime=1;mode=10;}
                    else{loopCount=0;SetDir(1);mode=30;}
                }
                break;
            case 30:pinchTarget=bodyL?bodyL.localPosition.z:0;Round1Sound.Play("bg7_boss_rise_01");SetDir(1.5f);mode=31;break;
            case 31:
            {
                float r=Rate;
                if(r<1){float e=InOutCubic(1-r);SetBodyZ(e*pinchTarget,e*pinchTarget);}
                else{SetBodyZ(0,0);SetState(Phase.PT7Change);}
                break;
            }
        }
    }
    void SetBodyZ(float zl,float zr)
    {
        if(bodyL){var p=bodyL.localPosition;p.z=zl;bodyL.localPosition=p;}
        if(bodyR){var p=bodyR.localPosition;p.z=zr;bodyR.localPosition=p;}
    }
    // Closing: x = +-110*(1-InCubic r). Opening: x = +-110*InOutCubic r. True when done.
    bool CoverMoveX(bool reverse)
    {
        float r=Rate,x=reverse?InOutCubic(r)*BaseDistance:(1-r*r*r)*BaseDistance;
        if(bodyL){var p=bodyL.localPosition;p.x=x;bodyL.localPosition=p;}
        if(bodyR){var p=bodyR.localPosition;p.x=-x;bodyR.localPosition=p;}
        return r>=1;
    }

    // ---- PT7Change (0x1D9D5F0) ----
    void PT7Change(float dt)
    {
        CoreProgress(dt);
        switch(mode)
        {
            case 0:CoreCombat();CoverPartsHitType(true);Round1Sound.Play("bg7_boss_open_arm_01");SetDir(2);mode=1;goto case 1;
            case 1:
            {
                float e=OutQuad(Rate);
                if(bodyL)bodyL.localRotation=Quaternion.Slerp(Quaternion.identity,LaserRotateBodyL,e);
                if(bodyR)bodyR.localRotation=Quaternion.Slerp(Quaternion.identity,LaserRotateBodyR,e);
                if(e>=1&&coreMode==5)SetState(Phase.PT8);
                break;
            }
        }
    }

    // ---- PT8 (0x1D9D9F0; the same code is inlined in StateExec) ----
    void PT8(float dt)
    {
        CoreProgress(dt);BatteryProgress(left,dt);BatteryProgress(right,dt);
        if(mode==0){Attack(left,0);Attack(right,1.5f);mode=1;}
    }

    // ---- CoreMovement (Progress 0x1D8A2E0, table 0x1D8AD08) ----
    // Evacuate (0x1D8A160): core asleep, ToEvacuate1.
    void CoreEvacuate(){if(pCore!=null)pCore.enabled=false;coreMode=1;coreTimer=0;}
    // Combat (0x1D89FE0): cover-open clip, core awake (MasterBody: damage goes to the body HP), ToCombat, rotation -180.
    void CoreCombat()
    {
        coverAnim=0;if(pCore!=null)pCore.enabled=true;
        Target.invulnerable=false;Target.lockOn=true;
        coreMode=4;coreTimer=0;coreRot-=180;
    }
    void StepCoverAnimation(float dt)
    {
        if(coverAnim<0||!coverClip||!core)return;
        coverAnim+=dt;Round1AnimationSampling.Sample(coverClip,core.gameObject,Mathf.Min(coverAnim,coverClip.length));
    }
    bool CoverAnimationDone=>coverAnim>=(coverClip?coverClip.length:0);
    float StepFloat(float dt){coreFloat=Mathf.Repeat(coreFloat+dt/FloatCycle,1);return Mathf.Sin(coreFloat*2*Mathf.PI)*FloatDistance;}
    void CoreProgress(float dt)
    {
        if(!core)return;
        switch(coreMode)
        {
            case 1: // ToEvacuate1. [I] the ChangeColorTask darkening (PawnEnemy.DarkColor over 1 s) is not drawn.
                coreTimer+=dt;
                if(coreTimer>EvacuateDelay){coreTimer=0;coreRot=0;coreFloat=0;coreMode=2;}
                break;
            case 2: // ToEvacuate2
            {
                coreTimer+=dt;float t=Mathf.Clamp01(coreTimer/EvacuateTime),f=StepFloat(dt);
                core.localPosition=Vector3.Lerp(CoreHome,CoreSafe+new Vector3(0,0,f),Mathf.Clamp01(OutQuad(t)));
                coreRot=Mathf.Repeat(coreRot+t*dt*RotatePerSecond,360);core.localRotation=Quaternion.Euler(0,0,coreRot);
                if(t>=1)coreMode=3;
                break;
            }
            case 3: // Evacuated
            {
                float f=StepFloat(dt);core.localPosition=CoreSafe+new Vector3(0,0,f);
                coreRot=Mathf.Repeat(coreRot+dt*RotatePerSecond,360);core.localRotation=Quaternion.Euler(0,0,coreRot);
                break;
            }
            case 4: // ToCombat
            {
                coreTimer+=dt;float t=Mathf.Clamp01(coreTimer/CombatTime),f=StepFloat(dt);
                core.localPosition=Vector3.Lerp(CoreSafe+new Vector3(0,0,f),CoreAttack,Mathf.Clamp01(OutQuad(t)));
                float d=Mathf.Clamp(Mathf.Repeat(360-coreRot,360),0,360);if(d>180)d-=360;
                core.localRotation=Quaternion.Euler(0,0,coreRot+Mathf.Clamp01(OutCubic(t))*d);
                if(t>=1&&CoverAnimationDone){coreTimer=0;coreRot=0;coreAccel=0;fireCount=0;coreMode=5;}
                break;
            }
            case 5: // Combat: one volley per 5 s circuit at 0.8 s
            {
                coreAccel=Mathf.Clamp01(coreAccel+dt);float old=coreTimer;
                coreTimer=Mathf.Repeat(coreTimer+coreAccel*dt,CircuitTime);
                core.localPosition=CoreAttack+CircleSymbol(Mathf.Clamp01(coreTimer/CircuitTime),CircuitRadius,CircuitRadius);
                if(CircuitFire>old&&coreTimer>=CircuitFire)
                {
                    switch(fireCount%firePatterns)
                    {
                        case 0:Fire("bos06_core1",mz[MzCoreBattery]);break;
                        case 1:Fire("bos06_core2",mz[MzCoreCore]);break;
                        case 2:Fire("bos06_core3",mz[MzCoreCore]);break;
                        default:Fire("bos06_core4",mz[MzCoreCore]);break;
                    }
                    fireCount=(fireCount+1)%firePatterns;
                }
                break;
            }
        }
    }

    // ---- BatteryMovement (Initialize 0x1D9FB20, Attack 0x1D9F990, Progress 0x1D9FCE0) ----
    void Init(Battery b,Transform cover,Transform battery,Transform muzzle,Transform target)
    {
        b.cover=cover;b.battery=battery;b.muzzle=muzzle;b.target=target;b.enable=false;b.timer=b.fl=0;
        // Yaw of the muzzle->target axis in the battery's own frame, so that the aim below points that axis at the player.
        b.axisYaw=battery&&muzzle&&target?AxisYaw(battery.InverseTransformDirection(target.position-muzzle.position)):0;
        b.startYaw=b.targetYaw=0;
    }
    static void Attack(Battery b,float delay){b.timer=-delay;b.fl=0;b.enable=true;}
    void BatteryProgress(Battery b,float dt)
    {
        if(!b.enable||!b.battery)return;
        float old=b.timer;b.timer+=dt;
        if((old<=FollowStart&&b.timer>FollowStart)||(old<=FollowStart+LaserInterval&&b.timer>FollowStart+LaserInterval))
        {
            b.startYaw=SkyYaw(b.battery);
            // [I] GetTargetBulletArc(SkyRoot(battery), player) as the battery's sky yaw: aim the muzzle->target axis at the player.
            var to=player-SkyPoint(b.battery.position);
            b.targetYaw=Mathf.Atan2(to.x,to.z)*Mathf.Rad2Deg-b.axisYaw;
        }
        if(b.timer>=FollowStart&&FollowStop>b.timer)
            SetSkyYaw(b.battery,Mathf.LerpAngle(b.startYaw,b.targetYaw,InOutQuad(Mathf.Clamp(b.timer-FollowStart,0,FollowTime)/FollowTime)));
        if((old<=LaserCall&&b.timer>LaserCall)||(old<=LaserCall+LaserInterval&&b.timer>LaserCall+LaserInterval))
            Fire("bos06laser01",b.muzzle,0,b.target); // CallLaser (0x1D9AE80)
        // Mathf.Repeat: the right battery's -1.5 s start wraps to 1.5, so its first aim comes 1.5 s after the left's.
        b.timer=Mathf.Repeat(b.timer,LaserInterval);
        b.fl=Mathf.Clamp01(Mathf.Repeat(b.fl+dt/BatteryFloatCycle,1));
        if(b.cover){var p=b.cover.localPosition;p.z=Mathf.Sin(b.fl*2*Mathf.PI)*BatteryFloatDistance;b.cover.localPosition=p;}
    }
    // The sky frame in world space (StageBoss places the root at camera * Euler(-90,0,0) * facing).
    Quaternion SkyRotation=>Weapon.player.stageCamera.transform.rotation*Quaternion.Euler(-90,0,0);
    float SkyYaw(Transform t)=>(Quaternion.Inverse(SkyRotation)*t.rotation).eulerAngles.y;
    void SetSkyYaw(Transform t,float yaw)=>t.rotation=SkyRotation*Quaternion.Euler(0,yaw,0); // native sets the world rotation
    static float AxisYaw(Vector3 d)=>Mathf.Atan2(d.x,d.z)*Mathf.Rad2Deg;
    // Source sky position of a world point on the hull (the same mapping StageBoss uses for live hit circles).
    Vector3 SkyPoint(Vector3 world){if(!visual)return position;var o=facing*visual.transform.InverseTransformPoint(world);return position+new Vector3(o.x,0,o.z);}

    // ---- Parts (OnPartsBreak 0x1D9B5E0, TopBody break in PT1) ----
    protected override void PartBroken(Part part)
    {
        if(part==pTop)
        {
            // BreakParts(effect, no sound) with pf_eff_explposion02 at its explosion root, then bg7_boss_parts_destruction_01.
            Boom("pf_eff_explposion02",mz[MzTopCore]?mz[MzTopCore].position:part.root.position);
            if(part.root&&visual&&part.root!=visual.transform)part.root.gameObject.SetActive(false);
            Round1Sound.Play("bg7_boss_parts_destruction_01");return;
        }
        if(part==p40||part==p60)
        {
            if(part.target!=null)part.target.touchesWhileInvulnerable=false;
            // Each side body broken adds a core pattern (core3, then core4), at most 4.
            bool first=part==p40?!brokenL:!brokenR;if(part==p40)brokenL=true;else brokenR=true;
            if(first&&firePatterns<4)firePatterns++;
            var at=part==p40?mz[MzBody40]:mz[MzBody60];
            Boom("pf_eff_explposion05",at?at.position:part.root.position);
            // [?] whether the broken side's battery keeps firing; hiding the part root here also hides its battery.
            if(part.root&&visual&&part.root!=visual.transform)part.root.gameObject.SetActive(false);
            if(State!=EncounterState.Defeating)Round1Sound.Event("enemyDead");
            return;
        }
        base.PartBroken(part);
    }

    // ---- Destruction (ToDestroid 0x1D9E530, PatternMoveDestruction 0x1D9B650) ----
    public override void OnDefeated()
    {
        if(State==EncounterState.Defeating||StageCleared)return;
        foreach(var p in new[]{p40,p60})if(p!=null&&p.target!=null)p.target.touchesWhileInvulnerable=false;
        Target.touchesWhileInvulnerable=false;
        base.OnDefeated();
        // Mode 0: break the remaining side bodies (effect, no sound); 0.5 s wait if any broke.
        bool any=false;
        foreach(var p in new[]{p40,p60})if(p!=null&&!p.broken){BreakPart(p);any=true;}
        defeatWait=any?.5f:0;defeatDuration=defeatWait+5;defeatSetup=deadFx=finalSound=false;coverAnim=-1;
    }
    // Only the core sinks (150 away from the camera, model-local y) and turns to (-80,60,0) over 5 s EaseIn. Small bombs
    // from the core muzzles from 0.2 s shrinking x0.9, the boss dead effect at 3 s, the final explosion sound at 5 s.
    protected override void Defeat(float dt)
    {
        if(!visual||!core)return;
        float t=StateAge-defeatWait;if(t<0)return;
        if(!defeatSetup)
        {
            defeatSetup=true;coreFrom=core.localPosition;coreTo=coreFrom+new Vector3(0,-150,0);coreRotFrom=core.localRotation;
            bombBase=.2f;bombLeft=0; // SetSmallBombSecond(0.2)
        }
        float r=Mathf.Clamp01(t/5);
        core.localPosition=Vector3.Lerp(coreFrom,coreTo,r*r);
        core.localRotation=Quaternion.Lerp(coreRotFrom,Quaternion.Euler(-80,60,0),r);
        // Ene_BosBase.IsCallSmallBomb (0x1DB9E90).
        bombLeft-=dt;
        if(bombLeft<=0)
        {
            bombLeft=bombBase+Random.value*.1f;bombBase*=.9f;
            var at=mz[Random.Range(1,3)-1]; // GetSmallBombPosition (0x1D9B4B0): Range(1,2) inclusive
            Boom("pf_eff_explposion01",at?at.position:core.position,.6f);Round1Sound.Play("exp_st3_boss_a01");
        }
        if(!deadFx&&t>=3){deadFx=true;Boom("pf_eff_explposion_boss",core.position,1.5f);Round1Sound.Event("bossDefeat");} // _callDeadEffect [I]
        if(!finalSound&&StateAge>=defeatDuration){finalSound=true;Round1Sound.Play("exp_st3_boss_c03");}
    }

    // EasingUtility (0x1DE8B70 OutQuad, 0x1DE8B90 OutQuart, 0x1DE88F0 OutCubic, 0x1DE8650 InOutQuad, 0x1DE8600 InOutCubic, 0x1DE8840 InSine).
    static float OutQuad(float t){float u=1-t;return 1-u*u;}
    static float OutQuart(float t){float u=1-t;return 1-u*u*u*u;}
    static float OutCubic(float t){float u=1-t;return 1-u*u*u;}
    static float InOutQuad(float t){if(t<.5f)return 2*t*t;float u=2*(1-t);return 1-u*u*.5f;}
    static float InOutCubic(float t){if(t<.5f){float v=2*t;return v*v*v*.5f;}float u=2*(1-t);return 1-u*u*u*.5f;}
    static float InSine01(float t)=>1-Mathf.Cos(t*90*Mathf.Deg2Rad);
}
