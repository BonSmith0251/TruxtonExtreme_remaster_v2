using UnityEngine;

// Ene_Bos07, the BG06 boss, from the native code (evidence/bosses/Bos07/SPEC.md; RVAs there and below). The BG06 timeline
// spawns ene_boss07 at 429 s at (0,0,32). Native moves the boss root (_transformCache) in the sky plane: that is
// `position` here. Children are driven as the native code drives them: the leg joints' yaw, the arms' local position,
// the turret pivot (body_upper_pivot) position/yaw and the face cover spin. [I]/[?] marks follow the spec.
// State flow: EntryWait -> (PT2 <-> PT3) -> PT7 -> PT4 (loops) -> PT5 -> PT6 (loops) -> destruction (base).
public class Bos07Boss : StageBoss
{
    public enum NativeState { EntryWait, PT2, PT3, PT4, PT5, PT6, PT7 }
    public NativeState Native {get;private set;}
    public int Mode=>mode;

    // ---- Ene_Bos07..cctor (0x1DA7580) ----
    // LegArcs (thigh, knee, toe) per LegPattern A..Reach2; leg40 end = Euler(0,+arc,0), leg60 end = Euler(0,-arc,0).
    const int LegA=0,LegB=1,LegC=2,LegCWindUp=3,LegCThrow1=4,LegCThrow2=5,LegNone=-1;
    static readonly float[,] LegArcs={{-45,135,45},{10,20,30},{10,20,30},{-10,20,30},{60,60,60},{-20,20,30},{45,45,0},{45,45,45}};
    static readonly Vector3 Arm40Start=new Vector3(-25,0,-16),Arm40End=new Vector3(-25,0,16),Arm60Start=new Vector3(25,0,-16),Arm60End=new Vector3(25,0,16);
    static readonly Vector3 MainBodyHome=new Vector3(0,-9,-8),MainBodyBack=new Vector3(0,0,-15),Mode6Position=new Vector3(0,0,-20);
    static readonly Vector3 LungeVector=new Vector3(0,0,-50);
    const float EntryNoHitTime=3.5f,EntranceClipLength=5,LungeWindUpRate=30f/-50f;
    const float P2LegChange=1,P2AttackInterval=.2f,P2AttackTime=6,P2MuzzleRadius=20,P2HomingSpeed=1f/6;const int P2FireCount=15;
    const float P3LegChange=1.5f,P3WindUp=1.8f,P3Wait=.2f,P3Swing=.8f,P3End=.2f;
    const float LegFire1Way=.5f,LegFire2Way=1,Battery1=.5f,Battery2=.75f,Battery3=1;
    const float P4ArmChange=1.2f,P4Circuit=8,P4FaceMin=.5f,P4FaceMax=2,P4HomingAttack=3,P4HomingInterval=2,P4BatteryAttack=2,P4CoverInterval=.1f,P4CoverCount=15;
    const float P6Circuit=4,P6Homing=.8f;

    // Boss07MZ order (Initialize 0x1DA1850: 12..17 are _batteries[i-12], the rest FindAlls(name) under _modelTop).
    const string Upper="pf_bs07/me_bs07/body_upper_pivot/body_upper/";
    static readonly string[] MuzzleNames={"muzzle_body_upper_01","muzzle_body_upper_02","muzzle_body_under_1","muzzle_body_under_3",
        "muzzle_body_leg40","muzzle_body_leg42_1","muzzle_body_leg60","muzzle_body_leg62_1","cover_muzzle_1","cover_muzzle_2","cover_muzzle_3",
        "muzzle_body_upper_02_target",
        Upper+"pos_body_battery01/pf_bs05_body_battery/bs05_body_battery_muzzle",Upper+"pos_body_battery03/pf_bs05_body_battery/bs05_body_battery_muzzle",
        Upper+"pos_body_battery04/pf_bs05_body_battery/bs05_body_battery_muzzle",Upper+"pos_body_battery06/pf_bs05_body_battery/bs05_body_battery_muzzle",
        Upper+"pos_body_battery07/pf_bs07_body_battery/bs07_body_battery_muzzle",Upper+"pos_body_battery09/pf_bs07_body_battery/bs05_body_battery_muzzle"};
    const int UpperMz02=1,Under1=2,Under3=3,Leg40Mz=4,Leg42Mz=5,Leg60Mz=6,Leg62Mz=7,Cover1=8,UpperTarget=11,Bat01=12,Bat03=13,Bat04=14,Bat06=15,Bat07=16,Bat09=17;
    // EnemyMover._muzzlePacks (prefab).
    static readonly string[] PackLeg40={"muzzle_body_leg42_2","muzzle_body_leg42_3","muzzle_body_leg42_4"},PackLeg60={"muzzle_body_leg62_2","muzzle_body_leg62_3","muzzle_body_leg62_4"};
    static readonly string[] PackLegSub={"muzzle_body_leg42_1","muzzle_body_leg62_1","muzzle_body_leg40","muzzle_body_leg60"};
    static readonly string[] PackBody4={"muzzle_body_under_71","muzzle_body_under_72","muzzle_body_under_91","muzzle_body_under_92"};
    // btNames (.cctor): BT index -> template name.
    const string BtLeg="bos07leg",BtLeg2="bos07leg2",BtLeg1Way="bos07leg1way",BtLeg2Way="bos07leg2way",BtBody3Way="bos07body3way",BtArmH="bos07armh",BtFace="bos07face",BtLaser="bos07laser";

    readonly Transform[] mz=new Transform[18],packLeg40=new Transform[3],packLeg60=new Transform[3],packLegSub=new Transform[4],packBody4=new Transform[4];
    readonly Transform[] legs40=new Transform[3],legs60=new Transform[3];
    Transform modelTop,arm40,arm60,turretPivot,faceCover,mainBody;
    Part pLeg40,pLeg60,pArm40,pArm60,pCover;
    Animator anim;
    AnimationCurve lungeBodyCurve,lungeArmCurve;

    // Ene_Bos07 instance fields (0x270..0x348) and the Ene_BosBase timers they use.
    int mode,entryMode;float localTime,attackCount,batteryFireTime,lungeRate,lungeRateLast,circuitTime,circuitEaseRate,faceCoverSpeed;
    float homingStart,homingTarget,homingTime,homingDuration;
    bool legBroken,armBroken,prevLeftLegBroken,prevRightLegBroken,isLeftAttack,isRightAttack,isLeftMove,isRightMove,armsLive;
    Vector3 start,lastLocal;
    readonly Quaternion[] leg40Start=new Quaternion[3],leg40End=new Quaternion[3],leg60Start=new Quaternion[3],leg60End=new Quaternion[3];
    float repeatTimer,repeatPassed,directionTotal,directionPassed;bool repeatLaped;
    int defeatSound;

    // ---------------------------------------------------------------- setup
    protected override void OnSpawned()
    {
        modelTop=Find("pf_bs07");
        string[] l40={"pf_bs07/me_bs07/leg40","pf_bs07/me_bs07/leg40/leg41","pf_bs07/me_bs07/leg40/leg41/leg42"};
        string[] l60={"pf_bs07/me_bs07/leg60","pf_bs07/me_bs07/leg60/leg61","pf_bs07/me_bs07/leg60/leg61/leg62"};
        for(int i=0;i<3;i++){legs40[i]=Find(l40[i]);legs60[i]=Find(l60[i]);}
        arm40=Find("pf_bs07/me_bs07/arm40");arm60=Find("pf_bs07/me_bs07/arm60");
        turretPivot=Find("pf_bs07/me_bs07/body_upper_pivot");faceCover=Find(Upper+"cover_rot_piv");mainBody=Find(Upper+"mainbody");
        for(int i=0;i<mz.Length;i++)mz[i]=Find(MuzzleNames[i]);
        for(int i=0;i<3;i++){packLeg40[i]=Find(PackLeg40[i]);packLeg60[i]=Find(PackLeg60[i]);}
        for(int i=0;i<4;i++){packLegSub[i]=Find(PackLegSub[i]);packBody4[i]=Find(PackBody4[i]);}
        pLeg40=GetPart("leg40");pLeg60=GetPart("leg60");pArm40=GetPart("arm40");pArm60=GetPart("arm60");pCover=GetPart("facecover");
        if(lungeBodyCurve==null)
        {
            // Pf_Ene_Bos07 Ene_Bos07._lungeBodyCurve / _lungeArmCurve (weightedMode 0: weights unused).
            lungeBodyCurve=new AnimationCurve(new Keyframe(0,0,4.2582517f,4.2582517f),new Keyframe(.38306576f,.81935406f,.7209234f,.7209234f),new Keyframe(1,1,0,0));
            lungeArmCurve=new AnimationCurve(new Keyframe(0,0,0,0),new Keyframe(.6162069f,.8867527f,.9219794f,.9219794f),new Keyframe(1,1,0,0));
        }
        // ReStart (0x1DA5FC0): state EntryWait, all counters zero, arms NoDamage.
        Native=NativeState.EntryWait;mode=0;entryMode=0;localTime=attackCount=batteryFireTime=lungeRate=lungeRateLast=circuitTime=circuitEaseRate=faceCoverSpeed=0;
        homingStart=homingTarget=homingTime=homingDuration=0;legBroken=armBroken=prevLeftLegBroken=prevRightLegBroken=isLeftAttack=isRightAttack=isLeftMove=isRightMove=armsLive=false;
        lastLocal=Vector3.zero;repeatTimer=repeatPassed=directionTotal=directionPassed=0;repeatLaped=false;defeatSound=0;
        // GetStart (0x1D7E4B0): OffCollision; no lock-on until the entrance ends.
        Target.lockOn=false;Target.touchesWhileInvulnerable=false;
        foreach(var p in parts)if(!p.body&&p.target!=null){SetPartVulnerable(p,false);p.target.touchesWhileInvulnerable=false;}
        // Definition event Animation(9) anc_bs07_start (anm_bs07 default state is idle).
        anim=visual.GetComponentInChildren<Animator>(true);
        if(anim){anim.enabled=true;anim.Play("anc_bs07_start",0,0);}
        position=Current.rest;
        Round1Sound.Play("bg7_boss_app_01"); // EntryWait mode 0: PlayQue(85)
    }

    // ---------------------------------------------------------------- Ene_BosBase timers (ProgressBossTimer 0x1DBA1D0)
    void Progress(float dt)
    {
        repeatLaped=false;
        if(repeatTimer>0)
        {
            repeatPassed+=dt;repeatLaped=repeatPassed>=repeatTimer;
            if(repeatLaped)repeatPassed=Mathf.Clamp(repeatPassed-Mathf.Floor(repeatPassed/repeatTimer)*repeatTimer,0,repeatTimer);
        }
        directionPassed=Mathf.Clamp(directionPassed+dt,0,86400);
    }
    void SetRepeatTime(float t){repeatTimer=t;repeatPassed=0;repeatLaped=false;}                      // 0x1DBA580
    void AddRepeatTime(float t)                                                                         // 0x1DB8EC0
    {
        if(repeatTimer<=0)return;
        repeatPassed+=t;repeatLaped=repeatPassed>=repeatTimer;
        if(repeatLaped)repeatPassed=Mathf.Clamp(repeatPassed-Mathf.Floor(repeatPassed/repeatTimer)*repeatTimer,0,repeatTimer);
    }
    void SetDirectionTime(float t){directionTotal=t;directionPassed=0;}                                // 0x1DBA4D0
    float Rate=>directionTotal>0?Mathf.Clamp01(directionPassed/directionTotal):0;                       // 0x1DB9A20

    // KANAI.Kernel.EasingUtility (0x1DE86F0 InOutSine01, 0x1DE8650 InOutQuad01, 0x1DE8840 InSine01, 0x1DE8B90 OutQuart01,
    // 0x1DE88F0 OutCubic01, 0x1DE85F0 InCubic01, 0x1DE8020 EaseOutBounce01).
    static float InOutSine(float t)=>t<.5f?(1-Mathf.Cos(2*t*90*Mathf.Deg2Rad))*.5f:1-(1-Mathf.Cos(2*(1-t)*90*Mathf.Deg2Rad))*.5f;
    static float InOutQuad(float t)=>t<.5f?2*t*t:1-(2*(1-t))*(2*(1-t))*.5f;
    static float InSine(float t)=>1-Mathf.Cos(t*90*Mathf.Deg2Rad);
    static float OutQuart(float t){float u=1-t;return 1-u*u*u*u;}
    static float OutCubic(float t){float u=1-t;return 1-u*u*u;}
    static float InCubic(float t)=>t*t*t;
    static float OutBounce(float t)
    {
        if(t<1/2.75f)return 7.5625f*t*t;
        if(t<2/2.75f){t-=1.5f/2.75f;return 7.5625f*t*t+.75f;}
        if(t<2.5f/2.75f){t-=2.25f/2.75f;return 7.5625f*t*t+.9375f;}
        t-=2.625f/2.75f;return 7.5625f*t*t+.984375f;
    }
    static float Wrap180(float a){a=Mathf.Repeat(a,360);return a>180?a-360:a;}

    // ---------------------------------------------------------------- vulnerability
    // InGameObjectFlag 0x22 (OffLockon|NoDamaged): collision stays, damage and lock-on off. Arms keep NoDamage until PT7.
    void Gate(bool live)
    {
        SetVulnerable(live);
        if(!armsLive){Vuln(pArm40,false);Vuln(pArm60,false);}
    }
    void Vuln(Part p,bool on){if(p!=null)SetPartVulnerable(p,on);}
    void SetTouch(bool on)
    {
        Target.touchesWhileInvulnerable=on;
        foreach(var p in parts)if(!p.body&&p.target!=null)p.target.touchesWhileInvulnerable=on&&!p.broken;
    }

    // ---------------------------------------------------------------- EntryWait (PatternMoveEntryWait 0x1DA59A0)
    protected override bool Entrance(float dt)
    {
        Progress(dt);position=Current.rest;
        switch(entryMode)
        {
            case 0:localTime=0;entryMode=1;break;
            case 1:
                localTime+=dt;
                // _EntryNoHitTime: ResetObjectFlag(OffCollision), SetObjectFlag(0x22).
                if(localTime>=EntryNoHitTime){SetTouch(true);entryMode=2;}
                break;
            case 2:
                // [I] mover._isFinishDelay: the definition's FinishWait "Start" ends with the 5 s entrance clip.
                if(StateAge>=EntranceClipLength)
                {
                    if(anim)anim.enabled=false; // mover.StopAnime(true)
                    if(modelTop){modelTop.localPosition=Vector3.zero;modelTop.localRotation=Quaternion.Euler(0,180,0);}
                    SetDirectionTime(.5f);localTime=1;entryMode=3;
                }
                break;
            case 3:
            {
                float px=PlayerSource.x;bool center=px>-100&&px<100,left=px<0; // Ene_BosBase.LocalLateUpdate player-side flags
                if(Rate<1&&!center)FaceCoverRotate(dt*(left?480:-480));
                localTime-=dt;
                if(localTime<=0)return true;
                break;
            }
        }
        return false;
    }
    protected override void OnFightStart()
    {
        // EntryWait mode 3 end: PlayQue(86), ResetObjectFlag(0x22), ResetBossTimer(true) (_startInGamePosition), CheckNextState.
        Round1Sound.Play("bg7_boss_open_arm_01");
        start=position;SetTouch(true);Gate(true);
        Native=NativeState.EntryWait;CheckNextState();
    }

    // ---------------------------------------------------------------- state machine (StateExec 0x1DA65A0)
    bool LegsDown=>pLeg40!=null&&pLeg40.broken&&pLeg60!=null&&pLeg60.broken;
    bool ArmsDown=>pArm40!=null&&pArm40.broken&&pArm60!=null&&pArm60.broken;
    bool Leg40Broken=>pLeg40==null||pLeg40.broken;
    bool Leg60Broken=>pLeg60==null||pLeg60.broken;
    // IsLegBrokenOrDifficultyUp 0x1DA1F10: both legs, HalfHP (rate <= .51) or Passed90.
    bool LegCond=>!legBroken&&(LegsDown||HpState>=3||BossTime>=90);
    // IsArmBrokenOrDifficultyUp 0x1DA1CF0: both arms, LowerHP (rate <= .30) or Passed150.
    bool ArmCond=>!armBroken&&(ArmsDown||HpState>=5||BossTime>=150);

    protected override void Fight(float dt)
    {
        Progress(dt);
        if(ArmCond)SetArmBroken();
        switch(Native)
        {
            case NativeState.PT2:PatternMove2(dt);break;
            case NativeState.PT3:PatternMove3(dt);break;
            case NativeState.PT4:PatternMove4(dt);break;
            case NativeState.PT5:PatternMove5(dt);break;
            case NativeState.PT6:PatternMove6(dt);break;
            case NativeState.PT7:PatternMove7(dt);break;
        }
    }
    void SetState(NativeState s)                                                                        // 0x1DA61B0
    {
        if(s==Native)return;
        Native=s;mode=0;
        if(s==NativeState.PT3){prevLeftLegBroken=Leg40Broken;prevRightLegBroken=Leg60Broken;}
    }
    void SetLegBroken(){SetState(NativeState.PT7);legBroken=true;isLeftAttack=isRightAttack=false;}       // 0x1DA6160
    void SetArmBroken(){SetState(NativeState.PT5);legBroken=armBroken=true;isLeftAttack=isRightAttack=false;} // 0x1DA6100
    void CheckNextState()                                                                               // 0x1DA0D30
    {
        if(ArmCond){SetArmBroken();return;}
        if(LegCond){SetLegBroken();return;}
        switch(Native)
        {
            case NativeState.EntryWait:SetState(NativeState.PT2);break;
            case NativeState.PT2:SetState(NativeState.PT3);break;
            case NativeState.PT3:SetState(NativeState.PT2);break;
            case NativeState.PT4:case NativeState.PT7:SetState(NativeState.PT4);break;
            case NativeState.PT5:SetState(NativeState.PT6);break;
            default:SetState(NativeState.EntryWait);break; // PT6: never reached (PatternMove6 does not call it)
        }
    }

    // ---- PT2 (PatternMove2 0x1DA2A70): legs B, then 6 s of homing toe shots on the BCMove loop ----
    void PatternMove2(float dt)
    {
        if(LegCond){SetLegBroken();return;}
        localTime-=dt;
        switch(mode)
        {
            case 0:SetupLegPattern(LegB,LegB);SetDirectionTime(P2LegChange);mode=1;attackCount=0;localTime=0;lastLocal=position;break;
            case 1:
            {
                float r=Rate;ProgressLegPattern(r);
                if(r>=1){SetRepeatTime(P2AttackInterval);localTime=P2AttackTime;lastLocal=start;mode=10;}
                position=Vector3.Lerp(lastLocal,start,InOutSine(r));
                break;
            }
            case 10:
                HomingLeg(dt);
                if(P2AttackTime-1>localTime&&attackCount<P2FireCount&&repeatLaped){BCFire(true,false);attackCount+=1;}
                if(localTime<=0)CheckNextState();
                BCMove(InOutQuad(Mathf.Clamp01(localTime/P2AttackTime)),Vector3.zero);
                break;
        }
    }

    // ---- PT3 (PatternMove3 0x1DA3140): four leg lunges, left/right alternating ----
    void PatternMove3(float dt)
    {
        if(LegCond){SetLegBroken();return;}
        bool l=Leg40Broken,rr=Leg60Broken;
        bool leftJust=l&&!prevLeftLegBroken,rightJust=rr&&!prevRightLegBroken;
        prevLeftLegBroken=l;prevRightLegBroken=rr;
        // The attacking leg broken while winding up/holding/early in the swing: retract (mode 30).
        bool cancelable=mode==14&&Rate<.6f||mode==12||mode==13;
        if((leftJust&&isLeftAttack||rightJust&&isRightAttack)&&cancelable&&mode!=30)
        {lungeRateLast=lungeRate;SetupLegPattern(LegC,LegC);SetDirectionTime(P3LegChange);mode=30;}
        switch(mode)
        {
            case 0:attackCount=0;mode=10;lungeRate=lungeRateLast=0;goto case 10;
            case 10:
            {
                float k=attackCount%2;isLeftAttack=k==0;isRightAttack=k==1;
                if(isLeftAttack&&Leg40Broken){isLeftAttack=false;isRightAttack=!Leg60Broken;}
                if(isRightAttack&&Leg60Broken){isRightAttack=false;isLeftAttack=!Leg40Broken;}
                SetupLegPattern(LegC,LegC);SetDirectionTime(P3LegChange);mode=11;
                break;
            }
            case 11:
            {
                float e=InOutQuad(Rate);lungeRate=lungeRateLast+InOutSine(e)*(0-lungeRateLast);ProgressLegPattern(e);
                if(e>=1){SetupLegPattern(LegCWindUp,LegCWindUp);SetDirectionTime(P3WindUp);mode=12;lungeRateLast=lungeRate;}
                break;
            }
            case 12:
            {
                float e=OutCubic(Rate);lungeRate=lungeRateLast+InOutSine(e)*(LungeWindUpRate-lungeRateLast);ProgressLegPattern(e);
                if(e>=1){SetDirectionTime(P3Wait);mode=13;lungeRateLast=lungeRate;}
                break;
            }
            case 13:
                if(Rate>=1)
                {
                    if(!isLeftAttack){SetupLegPattern(LegCThrow2,LegCThrow1);Round1Sound.Play("bg7_boss_close_arm_02");} // PlayQue(237)
                    else{SetupLegPattern(LegCThrow1,LegCThrow2);Round1Sound.Play("bg7_boss_close_arm_01");}         // PlayQue(87)
                    SetDirectionTime(P3Swing);mode=14;batteryFireTime=0;
                }
                break;
            case 14:
            {
                float r=Rate,a=lungeArmCurve.Evaluate(r);
                lungeRate=lungeRateLast+lungeBodyCurve.Evaluate(r)*(1-lungeRateLast);
                ProgressLegPatternSeparately(a,a,a);
                if(r>=1){SetDirectionTime(P3End);mode=15;lungeRateLast=lungeRate;}
                LegOrBatteryFire(dt);
                break;
            }
            case 15:if(Rate>=1)mode=20;LegOrBatteryFire(dt);break;
            case 20:attackCount+=1;if(attackCount<4)mode=10;else CheckNextState();break;
            case 30:
            {
                float r=Rate,e=InOutSine(r);lungeRate=lungeRateLast+Mathf.Clamp01(e)*(0-lungeRateLast);ProgressLegPattern(e);
                if(r>=1){lungeRate=lungeRateLast=0;mode=20;}
                break;
            }
        }
        // _startInGamePosition + LungeVector * _lungeRate: wind-up 30 up the screen, throw 50 toward the player.
        position=start+LungeVector*lungeRate;
    }

    // ---- PT7 (PatternMove7 0x1DA5100): remaining legs break, back home, arms become damageable ----
    void PatternMove7(float dt)
    {
        switch(mode)
        {
            case 0:
                if(!Leg40Broken)BreakPart(pLeg40);if(!Leg60Broken)BreakPart(pLeg60);
                lastLocal=position;SetDirectionTime(2);mode=1;
                break;
            case 1:
            {
                float r=Rate;
                if(r>=1)
                {
                    // ChangeCollisionsAttribute(NoDamage, false) on Arm40/Arm60.
                    armsLive=true;Vuln(pArm40,true);Vuln(pArm60,true);
                    CheckNextState();
                }
                position=Vector3.Lerp(lastLocal,start,InOutSine(r));
                break;
            }
        }
    }

    // ---- PT4 (PatternMove4 0x1DA3D30): arms out, 8 s circuit, armh / leg-battery bursts / face cover shots ----
    void PatternMove4(float dt)
    {
        if(ArmCond){SetArmBroken();return;}
        FaceCoverRotate(dt*360*faceCoverSpeed);
        switch(mode)
        {
            case 0:
                Gate(false);Round1Sound.Play("bg7_boss_unit_rotation_01"); // SetObjectFlag(0x22), PlayQue(88)
                SetDirectionTime(P4ArmChange);lastLocal=position;mode=1;faceCoverSpeed=0;
                break;
            case 1:
            {
                float r=Rate,e=Mathf.Clamp01(InCubic(r));
                if(arm40)arm40.localPosition=Vector3.Lerp(Arm40Start,Arm40End,e);
                if(arm60)arm60.localPosition=Vector3.Lerp(Arm60Start,Arm60End,e);
                faceCoverSpeed=r;
                if(r>=1){Gate(true);SetRepeatTime(P4HomingInterval);SetDirectionTime(P4HomingAttack);mode=10;circuitTime=circuitEaseRate=0;}
                position=Vector3.Lerp(lastLocal,start,InOutSine(r));
                break;
            }
            case 10:
                UpdateMoveTime(dt,P4Circuit);
                if(repeatLaped)BCFire(false,true);
                if(Rate>=1){SetDirectionTime(P4BatteryAttack);batteryFireTime=0;mode=11;}
                faceCoverSpeed+=(P4FaceMin-faceCoverSpeed)*.1f;
                break;
            case 11:
                UpdateMoveTime(dt,P4Circuit);LegOrBatteryFire(dt);
                if(Rate>=1){SetRepeatTime(P4CoverInterval);attackCount=0;mode=12;}
                faceCoverSpeed+=(P4FaceMin-faceCoverSpeed)*.1f;
                break;
            case 12:
                UpdateMoveTime(dt,P4Circuit);
                if(repeatLaped){int k=(int)(attackCount%3);Fire(BtFace,mz[Cover1+k]);attackCount+=1;}
                if(attackCount>=P4CoverCount){SetRepeatTime(P4HomingInterval);SetDirectionTime(P4HomingAttack);mode=10;}
                faceCoverSpeed+=(P4FaceMax-faceCoverSpeed)*.5f;
                break;
        }
    }
    // <PatternMove4>g__UpdateMoveTime 0x1DA6F60: eased-in circuit of period P on the BCMove loop.
    void UpdateMoveTime(float dt,float period)
    {
        circuitEaseRate=Mathf.Clamp01(circuitEaseRate+dt);
        circuitTime=Mathf.Repeat(circuitTime+circuitEaseRate*dt,period);
        BCMove(circuitTime/period,Vector3.zero);
    }

    // ---- PT5 (PatternMove5 0x1DA4650): every part breaks, move 20 down, turret drops back ----
    void PatternMove5(float dt)
    {
        switch(mode)
        {
            case 0:
                Gate(false);
                BreakPart(pLeg40);BreakPart(pLeg60);BreakPart(pArm40);BreakPart(pArm60);BreakPart(pCover);
                Round1Sound.Play("bg7_boss_unit_exp_01");Round1Sound.Play("boss_parts_destruction_g_01"); // PlayQue(89), PlayQue(212)
                lastLocal=position;SetDirectionTime(1.25f);mode=10;
                break;
            case 10:
            {
                float r=Rate;position=Vector3.Lerp(lastLocal,start+Mode6Position,InOutSine(r));
                if(r>=1){Round1Sound.Play("bg7_boss_main_gun_cocking_01");SetDirectionTime(2);mode=20;} // PlayQue(90)
                break;
            }
            case 20:
            {
                float r=Rate;
                if(r<1){if(turretPivot)turretPivot.localPosition=Vector3.Lerp(MainBodyHome,MainBodyBack,Mathf.Clamp01(OutBounce(2*r)));}
                else{if(turretPivot)turretPivot.localPosition=MainBodyBack;Gate(true);CheckNextState();}
                break;
            }
        }
    }

    // ---- PT6 (PatternMove6 0x1DA4BE0): main gun lasers, body4 shots, armh + batteries on the 4 s circuit ----
    void PatternMove6(float dt)
    {
        switch(mode)
        {
            case 0:mode=10;goto case 10;
            case 10:SetDirectionTime(10);SetRepeatTime(2);AddRepeatTime(2);attackCount=0;localTime=0;mode=11;goto case 11;
            case 11:
                if(Rate>=1){SetDirectionTime(1);SetRepeatTime(.2f);circuitTime=0;SetHomingAngle(false,P6Homing);mode=12;}
                if(repeatLaped&&attackCount<5)
                {
                    attackCount+=1;
                    Fire(BtLaser,mz[UpperMz02],0,mz[UpperTarget]); // BulletDirFireAsync(muzzle_body_upper_02 -> _target)
                    Round1Sound.Play("bg7_boss_main_gun_cocking_02");SetHomingAngle(true,P6Homing); // PlayQue(192)
                }
                break;
            case 12:
                if(Rate>=1){SetDirectionTime(2);SetRepeatTime(1);mode=13;batteryFireTime=0;}
                if(repeatLaped){foreach(var m in packBody4)Fire(BtLeg,m);Round1Sound.Play("bg7_boss_main_gun_cocking_02");}
                UpdateCircuitMove(dt);
                break;
            case 13:
                if(Rate>=1){SetDirectionTime(6);SetRepeatTime(1);mode=14;}
                if(repeatLaped)BCFire(false,true);
                LegOrBatteryFire(dt);UpdateCircuitMove(dt);
                break;
            case 14:if(UpdateCircuitMove(dt))mode=10;break;
        }
        // <PatternMove6>g__HomingBody 0x1DA7060 (inlined tail).
        if(homingDuration>0&&turretPivot)
        {
            homingTime=Mathf.Clamp(homingTime+dt,0,homingDuration);
            turretPivot.localRotation=Quaternion.Euler(0,Mathf.LerpAngle(homingStart,homingTarget,InOutQuad(homingTime/homingDuration)),0);
        }
    }
    // <PatternMove6>g__UpdateCircuitMove 0x1DA7490.
    bool UpdateCircuitMove(float dt)
    {
        circuitTime+=dt;float t=Mathf.Clamp01(circuitTime/P6Circuit);
        BCMove(InOutSine(t),Mode6Position);return t>=1;
    }
    // <PatternMove6>g__SetHomingAngle 0x1DA7130. Native: GetTargetBulletArc of (main body - player) in the turret
    // parent's frame. [I] The sign is taken so the turret's muzzle line (local +z) points at the player.
    void SetHomingAngle(bool isTarget,float duration)
    {
        if(!turretPivot)return;
        float target=0;
        if(isTarget&&mainBody&&visual)
        {
            var v=PlayerSource-Sky(mainBody);v.y=0;
            var world=visual.transform.TransformDirection(Quaternion.Inverse(facing)*v);
            var parent=turretPivot.parent?turretPivot.parent:turretPivot;
            var local=parent.InverseTransformDirection(world);
            target=Mathf.Atan2(local.x,local.z)*Mathf.Rad2Deg;
        }
        homingTarget=target;homingStart=turretPivot.localEulerAngles.y;homingDuration=duration;homingTime=0;
    }

    // ---------------------------------------------------------------- shared helpers
    // BCMove 0x1DA0BF0: start + off + (30 sin 2pi r, 0, 5 cos 2pi r - 5); _isReverseMove is never set.
    void BCMove(float rate,Vector3 off)
    {
        float a=2*Mathf.PI*rate;
        position=start+off+new Vector3(30*Mathf.Sin(a),0,5*Mathf.Cos(a)-5);
    }
    // BCFire 0x1DA0910: legs = legSLaser3 from packs leg40/leg60; sub = legBullet from legsub, or (legs broken) armBulletH
    // from muzzle_body_under_1/3 offset +60/-60.
    void BCFire(bool legs,bool sub)
    {
        if(legs){foreach(var m in packLeg40)Fire(BtLeg,m);foreach(var m in packLeg60)Fire(BtLeg,m);}
        if(sub)
        {
            if(!legBroken)foreach(var m in packLegSub)Fire(BtLeg2,m);
            else{Fire(BtArmH,mz[Under1],60);Fire(BtArmH,mz[Under3],-60);} // [I] native offset sign used as is
        }
    }
    // LegOrBatteryFire 0x1DA1FD0: the side that is not attacking fires as _batteryFireTime crosses each threshold.
    void LegOrBatteryFire(float dt)
    {
        float prev=batteryFireTime;batteryFireTime+=dt;float now=batteryFireTime;
        if(!isLeftAttack)
        {
            if(!Leg40Broken){if(Cross(LegFire1Way,prev,now))Fire(BtLeg1Way,mz[Leg40Mz]);if(Cross(LegFire2Way,prev,now))Fire(BtLeg2Way,mz[Leg42Mz]);}
            else{if(Cross(Battery1,prev,now))Fire(BtBody3Way,mz[Bat07]);if(Cross(Battery2,prev,now))Fire(BtBody3Way,mz[Bat04]);if(Cross(Battery3,prev,now))Fire(BtBody3Way,mz[Bat01]);}
        }
        if(!isRightAttack)
        {
            if(!Leg60Broken){if(Cross(LegFire1Way,prev,now))Fire(BtLeg1Way,mz[Leg60Mz]);if(Cross(LegFire2Way,prev,now))Fire(BtLeg2Way,mz[Leg62Mz]);}
            else{if(Cross(Battery1,prev,now))Fire(BtBody3Way,mz[Bat09]);if(Cross(Battery2,prev,now))Fire(BtBody3Way,mz[Bat06]);if(Cross(Battery3,prev,now))Fire(BtBody3Way,mz[Bat03]);}
        }
    }
    static bool Cross(float t,float prev,float now)=>t>prev&&now>=t;
    // FaceCoverRotate 0x1DA0FA0: cover_rot_piv.localRotation *= Euler(0,0,deg).
    void FaceCoverRotate(float deg){if(faceCover)faceCover.localRotation=faceCover.localRotation*Quaternion.Euler(0,0,deg);}

    // SetupLegPattern 0x1DA6240 / ProgressLegPattern 0x1DA5F60 / ProgressLegPatternSeparately 0x1DA5C80.
    void SetupLegPattern(int left,int right)
    {
        isLeftMove=left!=LegNone;isRightMove=right!=LegNone;
        for(int i=0;i<3;i++)
        {
            if(isLeftMove&&legs40[i]){leg40Start[i]=legs40[i].localRotation;leg40End[i]=Quaternion.Euler(0,LegArcs[left,i],0);}
            if(isRightMove&&legs60[i]){leg60Start[i]=legs60[i].localRotation;leg60End[i]=Quaternion.Euler(0,-LegArcs[right,i],0);}
        }
    }
    void ProgressLegPattern(float rate)=>ProgressLegPatternSeparately(InSine(rate),rate,OutQuart(rate));
    void ProgressLegPatternSeparately(float r0,float r1,float r2)
    {
        for(int i=0;i<3;i++)
        {
            float r=i==0?r0:i==1?r1:r2;
            if(isLeftMove&&legs40[i])legs40[i].localRotation=Quaternion.Slerp(leg40Start[i],leg40End[i],r);
            if(isRightMove&&legs60[i])legs60[i].localRotation=Quaternion.Slerp(leg60Start[i],leg60End[i],r);
        }
    }

    // HomingLeg 0x1DA1560 with <HomingLeg>g__calc 0x1DA6850 and GetTangentPoints 0x1DA12E0: each intact toe (legs[2])
    // yaws (clamped) so a point 20 out from its pivot sits on a tangent from the player. [I] toe muzzle aiming intent.
    void HomingLeg(float dt)
    {
        var p=PlayerSource;p.y=0;
        if(!Leg40Broken)HomingCalc(dt,legs40[2],legs40[1],0,true,0,60,p);
        if(!Leg60Broken)HomingCalc(dt,legs60[2],legs60[1],0,false,-60,0,p);
    }
    void HomingCalc(float dt,Transform a,Transform b,float offset,bool flag,float min,float max,Vector3 player)
    {
        if(!a||!b)return;
        var pa=Sky(a);pa.y=0;
        var d=player-pa;float dist=d.magnitude;if(P2MuzzleRadius>=dist)return;
        var u=d/dist;float th=Mathf.Acos(P2MuzzleRadius/dist);
        var c1=pa+P2MuzzleRadius*Rotate(u,th);var c2=pa+P2MuzzleRadius*Rotate(u,-th);
        var d0=Norm(player-pa);var d1=Norm(c1-pa);
        float ang=Wrap180(Atan(d0)-Atan(d1));
        if(ang>0!=flag)d1=Norm(c2-pa);
        var pb=Sky(b);var v=Norm(new Vector3(pa.x-pb.x,0,pa.z-pb.z));
        float yaw=Mathf.Clamp(Wrap180(Atan(d1)-Atan(v)),min,max);
        float t=Mathf.Clamp01(dt/P2HomingSpeed);
        a.localRotation=Quaternion.Slerp(a.localRotation,Quaternion.Euler(0,yaw+offset,0),t);
    }
    static Vector3 Rotate(Vector3 v,float th){float c=Mathf.Cos(th),s=Mathf.Sin(th);return new Vector3(c*v.x-s*v.z,0,s*v.x+c*v.z);}
    static Vector3 Norm(Vector3 v){float m=v.magnitude;return m>1e-5f?v/m:Vector3.zero;}
    static float Atan(Vector3 v)=>Mathf.Atan2(v.x,v.z)*Mathf.Rad2Deg;
    // InGameManager.GetSkyRootPosition: a child transform in source sky-plane units (the hull's root frame, see UpdateCircles).
    Vector3 Sky(Transform t)=>position+facing*visual.transform.InverseTransformPoint(t.position);

    // ---------------------------------------------------------------- parts and destruction
    // EnePartsGroup.BreakParts: BreakEffect at _explosionRoot (legs: leg42/leg62, facecover: cover_rot_piv), parts hidden.
    protected override void PartBroken(Part part)
    {
        string effect=part==pCover?"pf_eff_explposion02":"pf_eff_explposion05";
        Transform at=part==pLeg40?legs40[2]:part==pLeg60?legs60[2]:part==pCover?faceCover:part.root;
        if(at)Boom(effect,at.position);
        Round1Sound.Dead(null,effect);
        if(part.root&&visual&&part.root!=visual.transform)part.root.gameObject.SetActive(false);
        if(part.target!=null&&!part.body)part.target.touchesWhileInvulnerable=false;
        // OnPartsBreak 0x1DA2A30: AddShake(0.5,2,10) for the legs - [I] hull shake not reproduced.
    }
    public override void OnDefeated(){base.OnDefeated();defeatSound=0;SetTouch(false);}
    // Ene_Bos07.ToDestroid 0x1DA6710 (StopBossTimer PlayQue(177)) and PatternMoveDestruction mode 30 (PlayQue(42)); the
    // sink to Euler(20,45,0), small bombs and the dead effect at 3.5 s are the shared Ene_BosBase sequence.
    protected override void Defeat(float dt)
    {
        if(defeatSound==0){defeatSound=1;Round1Sound.Play("boss_defeat01_01");}
        base.Defeat(dt);
        if(defeatSound==1&&StateAge>=defeatDuration){defeatSound=2;Round1Sound.Play("exp_st3_boss_c03");}
    }
}
