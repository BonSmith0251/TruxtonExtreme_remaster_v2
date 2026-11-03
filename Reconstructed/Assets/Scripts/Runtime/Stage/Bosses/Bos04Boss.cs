using UnityEngine;

// Ene_Bos04, the BG04 boss, from the native code (evidence/bosses/Bos04/SPEC.md; RVAs are GameAssembly.dll).
// Closed form: EntryWait -> PT1 (guardian bits, swings) -> PT2 (flip, Sg01 stream) -> PT3 (Sg01 burst, rolling rush) -> PT1 ...
// HP <= 51% or 90 s of boss time interrupts into OpenWing (transformation), then PT5 (spinning figure-8, wings are the
// targets) until the 4 wings are broken, then PT6 (final pattern) until death. Positions are source sky-plane units
// (x right, z up the screen, y toward the camera; y is shown as depth through sinkDepth). Marked [I] where the spec infers.
public class Bos04Boss : StageBoss
{
    enum NS { EntryWait=0, PT1=1, PT2=2, PT3=3, PT5=4, PT6=5, OpenWing=10 } // Boss04State

    const string BitModel="Pf_Ene_Bos04_bit",SgModel="Pf_Ene_Sg01";
    public override string[] MinionModels=>new[]{BitModel,SgModel}; // Ene_Bos04._ChildData (.cctor 0x1D91090)

    // ---- Ene_Bos04..cctor (0x1D91090) statics
    static readonly Vector3 OpenWingPosition=new Vector3(0,-80,30),OpenAttackPosition=new Vector3(0,0,20);
    static readonly Quaternion ModelTopRotateStart=Quaternion.Euler(0,180,0),ModelTopRotate=Quaternion.Euler(90,0,0);
    static readonly Quaternion[] WingArcs={Quaternion.Euler(0,0,0),Quaternion.Euler(90,0,0),Quaternion.Euler(0,0,-90),Quaternion.Euler(0,-90,-90),
        Quaternion.Euler(0,0,90),Quaternion.Euler(0,90,90),Quaternion.Euler(0,0,180),Quaternion.Euler(-90,0,180)};
    const float EntryNoHitTime=2.7f,Pattern1OneLoopTime=5,Pattern1OneLoopEndWait=.5f;const int Pattern1RepeatCount=1;
    const float Pattern2FirstMove=3,Pattern2EnemyEmitTime=5,Pattern2EmitEasy=.3f,Pattern2EmitHard=.2f;
    const float Pattern3EmitTime=6,Pattern3EmitInterval=.3f,Pattern3EmitAfterWait=1,Pattern3RushTime=8,Pattern3RushDistance=150,Pattern3RushTwist=2880;
    const float SecondOneRoundFirst=16,SecondOneRoundNormal=16,SecondOneRoundLast=14,SecondOneRoundBodyRotate=36,SecondShortLaserCoreRotate=90,SecondFireLookRate=2;
    static readonly float[] SecondFireRepeat={4,3,3,2.5f,2}; // First, Normal, Normal, Hard, Expert by wings destroyed (Update 0x1D90BF3)
    const float SecondEndingTime=14;static readonly float[] WatchAngles={45,135,225,315};
    const float LastOneRound=12,LastOneRoundBodyRotate=36,LastOneRoundCoreRotate=60,LastLaserInterval=2.5f,LastShotInterval=99;const int LastLaserCount=3;
    const float PatternOpenWingY=-150;const int WingMax=4;

    // ---- serialized curves of Pf_Ene_Bos04 (evidence/bosses/Bos04/prefab-values.json): time, value, in, out, weightedMode, inW, outW
    static AnimationCurve C(params float[] k)
    {
        var keys=new Keyframe[k.Length/7];
        for(int i=0;i<keys.Length;i++){var f=new Keyframe(k[i*7],k[i*7+1],k[i*7+2],k[i*7+3],k[i*7+5],k[i*7+6]);f.weightedMode=(WeightedMode)(int)k[i*7+4];keys[i]=f;}
        return new AnimationCurve(keys);
    }
    // Built on first spawn (not in a static initializer: AnimationCurve is a native object).
    static AnimationCurve Pattern1EaseIn,Pattern1EaseOut,Pattern2EaseInOut,Pattern3Position,Pattern3RotateX,Pattern5EaseIn,PatternOpenWing;
    static void BuildCurves()
    {
        if(PatternOpenWing!=null)return;
        Pattern1EaseIn=C(0,0,0,0,0,0,.29368833f, .30675024f,.20642278f,1.6365669f,1.6365669f,0,.23795408f,.25722754f, .5f,.5f,.99999374f,.99999374f,0,1/3f,1/3f, 1,1,1,1,0,1/3f,0);
        Pattern1EaseOut=C(0,0,1,1,0,0,1/3f, .5f,.5f,1,.9923f,0,1/3f,1, .7348f,.7873f,1.6026f,1.6026f,0,1/3f,.2646f, 1,1,0,0,0,.2906f,0);
        Pattern2EaseInOut=C(0,0,0,0,0,0,0, 1,1,0,0,0,0,0);
        Pattern3Position=C(0,0,0,0,0,0,0, .2468f,.3897f,2.6109f,2.6109f,0,1/3f,1/3f, .3604f,.9574f,2.1795f,2.1795f,0,.0926f,.3144f,
        .3947f,.9965f,-.2258f,-.2258f,0,1/3f,.1305f, .9079f,-.0762f,2.5616f,2.5616f,0,1/3f,.1191f, 1,0,0,0,0,0,0);
        Pattern3RotateX=C(0,0,0,0,0,0,0, .3f,0,0,0,0,.1473f,1/3f, .3647f,.0661f,2.042f,2.042f,0,1/3f,.8988f, .5004f,.4403f,2.2823f,2.2823f,0,1/3f,.5208f,
        .6f,.5f,0,0,0,1/3f,.1305f, .7f,.5f,0,0,0,1/3f,1/3f, .7819f,.5862f,2.6352f,2.6352f,0,1/3f,.616f, .9034f,.9419f,1.703f,1.703f,0,.6248f,.5379f, 1,1,0,0,0,0,0);
        Pattern5EaseIn=C(0,0,0,0,2,0,.4641f, .5008f,.4984f,.9662f,.9662f,0,1/3f,.2631f, .75f,.75f,1.0046f,1.0046f,0,1/3f,1/3f, 1,1,1,1,0,1/3f,0);
        PatternOpenWing=C(0,0,3.9788f,3.9788f,0,0,.5861f, .4528f,1,.0118f,.0118f,0,1,.1605f, .8674f,.1671f,-2.5738f,-2.5738f,0,.1658f,.2435f, 1,0,0,0,0,0,0);
    }

    // boss04sgL route (RouteLUT/boss04sgL.asset _positions, 568.2 long) resampled every 1/24 of its length, x/z offsets
    // from the spawn point [I: relative to the spawn]; boss04sgR is its mirror (within 1 unit).
    static readonly Vector2[] RouteL={new Vector2(-12.7f,14.6f),new Vector2(-13.7f,-9),new Vector2(-15.5f,-32.6f),new Vector2(-20.1f,-55.8f),new Vector2(-34.2f,-74),
        new Vector2(-56.8f,-80.6f),new Vector2(-80.4f,-81.8f),new Vector2(-103.8f,-78.3f),new Vector2(-124,-66.3f),new Vector2(-139.4f,-48.4f),new Vector2(-149.8f,-27.2f),
        new Vector2(-156.3f,-4.4f),new Vector2(-159.6f,19),new Vector2(-160.8f,42.6f),new Vector2(-158.5f,66.1f),new Vector2(-147.1f,86.3f),new Vector2(-126.3f,97.4f),
        new Vector2(-103.1f,100.6f),new Vector2(-84.5f,87),new Vector2(-73.6f,66.1f),new Vector2(-72.1f,42.8f),new Vector2(-75.8f,19.4f),new Vector2(-80.7f,-3.8f),
        new Vector2(-86,-26.8f),new Vector2(-90.8f,-50)};
    const float RouteLength=568.2f,RouteSpeed=100,ChaseSpeed=40,ChaseTurn=30,ChaseTime=5; // sg00L/R placement 100; Speed 40, Horming 30/5 s [I]

    NS ns;int mode;float localTime;
    float dirTotal=1,dirPassed,repTimer,repPassed;int repTimes;bool dirPause,laped;  // Ene_BosBase timers (ProgressBossTimer 0x1DBA1D0)
    Vector3 startInGame,startV,targetV;Quaternion startA=Quaternion.identity,targetA=Quaternion.identity,rootRot=Quaternion.identity,baseFacing=Quaternion.identity;
    bool reverse,pattern1First,openWing,turnSE,fireReady,pattern5First,openCollision,entryPosed,finalSE;
    int loopCount,attackLoop,hpOld,destroyWingCount,laserCount;
    float wingRotation,lookAngle,destroyedRate,destroyedRemain;
    Transform modelTop,upperCore,under20,under40,under60,upper05;
    readonly Transform[] wings=new Transform[4],upper=new Transform[4],upperTarget=new Transform[4];
    Part body,head,core;readonly Part[] wingParts=new Part[4];
    Minion bitL,bitR;Animator animator;

    // ---- spawn and entrance (Initialize 0x1D8C5F0, GetStart 0x1D7E4B0, StateExec EntryWait 0x1D902E7)
    protected override void OnSpawned()
    {
        BuildCurves();
        baseFacing=facing;rootRot=Quaternion.identity;ns=NS.EntryWait;mode=0;openWing=false;entryPosed=false;finalSE=false;wingRotation=0;bitL=bitR=null;
        modelTop=Find("pf_bs04");upperCore=Find("bs04_body_upper");
        under20=Find("muzzle_body_under20");under40=Find("muzzle_body_under40");under60=Find("muzzle_body_under60");upper05=Find("muzzle_body_upper05");
        string[] dirs={"02","04","06","08"},wn={"wing20","wing40","wing60","wing80"};
        for(int i=0;i<4;i++){wings[i]=Find("bs04_"+wn[i]);upper[i]=Find("muzzle_body_upper"+dirs[i]);upperTarget[i]=Find("upper"+dirs[i]+"t");wingParts[i]=GetPart(wn[i]);}
        body=GetPart("mainBody");head=GetPart("mainHead");core=GetPart("core");
        // PartsFlag SleepStart: core, mainHead and the wings start asleep.
        Enable(core,false);Enable(head,false);foreach(var w in wingParts)Enable(w,false);
        animator=visual?visual.GetComponentInChildren<Animator>(true):null;
        if(animator&&animator.runtimeAnimatorController)animator.Play("anc_bs04_start",0,0); // EnemyData Animation event
        Round1Sound.Play("bg4_boss_app_01"); // PlayQue(54) EntryWait mode 0
    }
    protected override bool Entrance(float dt)
    {
        position=Current.rest;facing=baseFacing;
        // GetStart: OffCollision; after _EntryNoHitTime collision on but OffLockon|NoDamaged [I: body contact only].
        Target.lockOn=false;Target.touchesWhileInvulnerable=StateAge>=EntryNoHitTime;
        // mode 2: when the 5 s entry clip's event stack finishes [I], StopAnime and pose modelTop; mode 3 waits 0.25 s.
        if(!entryPosed&&StateAge>=5)
        {
            entryPosed=true;if(animator)animator.enabled=false;
            if(modelTop)modelTop.SetLocalPositionAndRotation(Vector3.zero,ModelTopRotateStart);
        }
        if(StateAge<5.25f)return false;
        Target.touchesWhileInvulnerable=false;return true; // ResetBossTimer(true)
    }
    protected override void OnFightStart(){startInGame=position;CheckNextState();}

    // ---- state machine (StateExec 0x1D90270, CheckNextState 0x1D8BC40, SetState 0x1D901D0)
    bool OverOpen=>HpState>=3||BossTime>=90; // IsOverAorB(HalfHP, Passed90)
    void SetState(NS s){if(s!=ns){ns=s;mode=0;}}
    void CheckNextState()
    {
        if(ns!=NS.OpenWing&&!openWing&&OverOpen){SetState(NS.OpenWing);return;}
        if(!openWing)
        {
            switch(ns){case NS.EntryWait:case NS.PT3:SetState(NS.PT1);break;case NS.PT1:SetState(NS.PT2);break;case NS.PT2:SetState(NS.PT3);break;default:SetState(NS.EntryWait);break;}
        }
        else if(ns==NS.PT5)SetState(NS.PT6);
        else if(ns==NS.OpenWing)SetState(NS.PT5);
    }
    protected override void Fight(float dt)
    {
        Timers(dt);
        if(ns!=NS.OpenWing&&!openWing&&OverOpen)SetState(NS.OpenWing); // interrupts any closed-form pattern
        switch(ns)
        {
            case NS.EntryWait:CheckNextState();break;
            case NS.PT1:PT1(dt);break;
            case NS.PT2:PT2(dt);break;
            case NS.PT3:PT3(dt);break;
            case NS.OpenWing:OpenWingStep(dt);break;
            case NS.PT5:PT5(dt);break;
            case NS.PT6:PT6(dt);break;
        }
        facing=baseFacing*rootRot;
        sinkDepth=-position.y; // source y (toward the camera) as perspective depth
    }

    void Timers(float dt)
    {
        if(!dirPause)dirPassed=Mathf.Clamp(dirPassed+dt,0,86400);
        laped=false;
        if(repTimer>0)
        {
            repPassed+=dt;laped=repPassed>=repTimer;
            if(laped){repPassed=Mathf.Clamp(repPassed-Mathf.Floor(repPassed/repTimer)*repTimer,0,repTimer);repTimes++;}
        }
    }
    float DirRate=>dirTotal>0?Mathf.Clamp01(dirPassed/dirTotal):0;
    float RepeatRate=>repTimer>0?Mathf.Clamp01(repPassed/repTimer):0;
    void SetDirectionTime(float t){dirTotal=t;dirPassed=0;}
    void SetRepeatTime(float t){repTimer=t;repPassed=0;repTimes=0;laped=false;}
    bool IsAttackLoop(){if(--attackLoop>0)return true;attackLoop=0;return false;}

    // ---- PT1 (PatternMove1 0x1D8D040, Pattern1Move 0x1D8CC90)
    void PT1(float dt)
    {
        switch(mode)
        {
            case 0:
                CheckGuardians();hpOld=HpState;SetBodyHead(false);reverse=PlayerSource.x>=0; // IsPlayerSideRight [I: not left of x 0]loopCount=0;pattern1First=true;mode=10;
                goto case 10;
            case 10:
                attackLoop=2;SetDirectionTime(Pattern1OneLoopTime);SetRepeatTime(Pattern1OneLoopTime*.5f);mode=11;
                goto case 11;
            case 11:
            {
                float r=DirRate;if(pattern1First)r=Pattern1EaseIn.Evaluate(r);
                Pattern1Move(r);
                // Rapid 3 (6 after 90 s) natively; the template's own rapid count is used here (no override in FireBoss).
                if(laped)Fire(PlayerSource.x<0?"bos04p1way3r":"bos04p1way3l",r>.45f&&r<.55f?(reverse?under40:under60):under20);
                if(r>=1)
                {
                    pattern1First=false;
                    if(HpState!=hpOld){SetBodyHead(true);CheckNextState();return;}
                    reverse=!reverse;SetDirectionTime(Pattern1OneLoopTime);
                    if(!IsAttackLoop())mode=20;
                }
                break;
            }
            case 20:case 21:
            {
                float e=Pattern1EaseOut.Evaluate(DirRate);Pattern1Move(e);
                if(mode==20){if(e>=.5f){FireGuardians();mode=21;}}
                else if(e>=1){reverse=!reverse;if(++loopCount<Pattern1RepeatCount)mode=10;else{localTime=0;mode=22;}}
                break;
            }
            case 22:
                localTime+=dt;if(localTime>=Pattern1OneLoopEndWait){SetBodyHead(true);CheckNextState();}
                break;
        }
    }
    void Pattern1Move(float r)
    {
        float f=FreeFall(r)*(reverse?-1:1);
        position=startInGame+new Vector3(-40*f,0,InfZ(r,10));
        rootRot=Quaternion.Euler(0,0,80*f);
    }

    // ---- PT2 (PatternMove2 0x1D8D6C0)
    void PT2(float dt)
    {
        switch(mode)
        {
            case 0:
                startV=targetV=position;targetV.z+=50;startA=Quaternion.identity;targetA=Quaternion.Euler(0,0,180);
                SetDirectionTime(Pattern2FirstMove);localTime=0;mode=10;break;
            case 10:
            {
                float rate=DirRate,e=Pattern2EaseInOut.Evaluate(rate);
                position=Vector3.Lerp(startV,targetV,e);rootRot=Quaternion.Lerp(startA,targetA,e);
                if(rate>=1){SetRepeatTime(BossTime>=90?Pattern2EmitHard:Pattern2EmitEasy);mode=11;localTime=Pattern2EnemyEmitTime;}
                break;
            }
            case 11:
            {
                float e=InOutQuad(Mathf.Clamp01(localTime/Pattern2EnemyEmitTime));
                position=targetV+new Vector3(InfX(e,20),0,InfZ(e,2));
                localTime-=dt;
                // CallEnemyClip(2 + (_repeatTimes & 1)): odd laps bos04_sg00R, even bos04_sg00L.
                if(laped){SpawnRouteFighter(position,(repTimes&1)==1?1:-1);Round1Sound.Play("bg4_boss_ene_sg_injection_01");}
                if(localTime<=0){startV=position;targetV=startInGame;startA=rootRot;targetA=Quaternion.identity;SetDirectionTime(2);mode=20;}
                break;
            }
            case 20:
            {
                float e=Pattern2EaseInOut.Evaluate(DirRate);
                position=Vector3.Lerp(startV,targetV,e);rootRot=Quaternion.Lerp(startA,targetA,e);
                if(e>=1)CheckNextState();
                break;
            }
        }
    }

    // ---- PT3 (PatternMove3 0x1D8DE00)
    void PT3(float dt)
    {
        switch(mode)
        {
            case 0:
                startV=targetV=position;targetV.z+=50;localTime=0;SetRepeatTime(Pattern3EmitInterval);mode=10;break;
            case 10:
            {
                localTime+=dt;
                position=Vector3.Lerp(startV,targetV,Pattern2EaseInOut.Evaluate(Mathf.Clamp01(localTime/Pattern3EmitTime)));
                if(laped){SpawnCenterFighter(position+new Vector3(0,0,-20));Round1Sound.Play("bg4_boss_ene_sg_injection_01");}
                if(localTime>=Pattern3EmitTime){mode=11;localTime=0;}
                break;
            }
            case 11:
                localTime+=dt;
                if(localTime>=Pattern3EmitAfterWait)
                {
                    Round1Sound.Play("bg4_boss_rushing_01");SetBodyHead(false);
                    startV=targetV;targetV.z-=Pattern3RushDistance;turnSE=false;localTime=0;mode=20;
                }
                break;
            case 20:
            {
                localTime+=dt;float r=Mathf.Clamp01(localTime/Pattern3RushTime);
                if(!turnSE&&r>.5f){turnSE=true;Round1Sound.Play("bg4_boss_app_rising_01");}
                position=startV+(targetV-startV)*Pattern3Position.Evaluate(r);
                rootRot=Quaternion.Euler(360*Pattern3RotateX.Evaluate(r),0,0)*Quaternion.Euler(0,0,Pattern3RushTwist*InOutQuad(r));
                if(localTime>=Pattern3RushTime){mode=30;localTime=0;}
                break;
            }
            case 30:
                localTime-=dt;
                if(localTime<=0){startV=position;targetV=startInGame;rootRot=Quaternion.identity;SetDirectionTime(1);Round1Sound.Play("bg4_boss_app_above_01");mode=31;localTime=0;}
                break;
            case 31:
                position=Vector3.Lerp(startV,targetV,Pattern2EaseInOut.Evaluate(DirRate));
                if(DirRate>=1){mode=32;localTime=.5f;}
                break;
            case 32: // (mode 33, a 3 s hover, is unreachable natively)
                localTime+=dt;if(localTime>=1){SetDirectionTime(3);SetBodyHead(true);CheckNextState();}
                break;
        }
    }

    // ---- OpenWing (PatternOpenWing 0x1D8F6F0)
    void OpenWingStep(float dt)
    {
        switch(mode)
        {
            case 0:
                if(HpState>=3){Round1Sound.Play("boss_parts_destruction_g_01");if(visual)Boom("pf_eff_explposion02",visual.transform.position);} // ExplosionCodeMiddle [I prefab]
                DestroyGuardians();
                Enable(body,false);Enable(head,false); // mainBody ToSleep; mainHead NoHitSubject [I: treated as off]
                startA=modelTop?modelTop.localRotation:Quaternion.identity;targetA=ModelTopRotate;
                startV=position;targetV=OpenWingPosition;rootRot=Quaternion.identity;wingRotation=0;openCollision=false;
                SetDirectionTime(3);Round1Sound.Play("bg4_boss_transformation_01");mode=1;localTime=0;
                break; // ChangeDarkMode(true,0.3) / (false at r>0.7) not reproduced
            case 1:
            {
                float r=DirRate;
                if(modelTop)modelTop.localRotation=Quaternion.Lerp(startA,targetA,r);
                var p=Vector3.Lerp(startV,targetV,1-(1-r)*(1-r));p.y+=PatternOpenWing.Evaluate(r)*PatternOpenWingY;position=p; // EaseOut + depth dip
                UpdateWingRotation(r*dt*SecondOneRoundBodyRotate);
                float w=OutSine(r);for(int i=0;i<4;i++)if(wings[i])wings[i].localRotation=Quaternion.Slerp(WingArcs[2*i],WingArcs[2*i+1],w);
                if(!openCollision&&r>.85f){openCollision=true;Enable(body,true);Target.invulnerable=true;Target.lockOn=false;} // Wakeup + OffLockon|NoDamaged
                if(r>=1){Round1Sound.Play("bg4_boss_transformation_02");mode=30;}
                break;
            }
            case 30:
                targetA=Quaternion.identity;targetV=Vector3.zero;
                Enable(body,false);Enable(head,false);Enable(core,true);foreach(var wp in wingParts)Enable(wp,true);
                SetVulnerable(true); // ResetObjectFlag(OffLockon|NoDamaged); woken wings become targets
                openWing=true;UpdateWingRotation(dt*SecondOneRoundBodyRotate);CheckNextState();
                break;
        }
    }
    // UpdateWingRotation 0x1D90FD0: the whole boss spins in the screen plane.
    void UpdateWingRotation(float add){wingRotation=Mathf.Repeat(wingRotation+add,360);rootRot=Quaternion.Euler(0,wingRotation,0);}

    // ---- PT5 (PatternMove5 0x1D8E920, Update 0x1D90830, infinityMoveLookPlayer 0x1D921D0)
    void PT5(float dt)
    {
        switch(mode)
        {
            case 0:
            {
                Round1Sound.Play("bg4_boss_unit_rotation_01"); // looped natively until the next SetState [I: one shot]
                pattern5First=true;SetDirectionTime(SecondOneRoundFirst);SetRepeatTime(SecondFireRepeat[0]);
                // _lookAngle from _upperCore.right in the sky plane.
                var right=rootRot*(modelTop?modelTop.localRotation:Quaternion.identity)*(upperCore?upperCore.localRotation:Quaternion.identity)*Vector3.right;
                lookAngle=Mathf.Repeat(Mathf.Atan2(right.x,right.z)*Mathf.Rad2Deg+360,360);
                destroyWingCount=0;fireReady=false;UpdateWingRotation(dt*SecondOneRoundBodyRotate);mode=20;
                break;
            }
            case 20:
            {
                float m=DirRate,a=RepeatRate;
                bool force=HpState>=6||BossTime>=150; // IsOverAorB(LowestHP, Passed150): break the rest
                int n=0;foreach(var w in wingParts){if(w==null||w.broken)n++;else if(force){BreakPart(w);n++;}}
                P5Update(m,a,n,dt);UpdateWingRotation(dt*SecondOneRoundBodyRotate);
                if(n==WingMax){destroyedRate=m;localTime=0;dirPause=true;mode=30;destroyedRemain=(1-m)*SecondEndingTime;}
                break;
            }
            case 30:
            {
                localTime+=dt;float t=destroyedRemain>0?Mathf.Min(localTime/destroyedRemain,1):1;
                P5Update(destroyedRate+(1-destroyedRate)*OutQuad(t),RepeatRate,WingMax,dt);
                if(t>=1){localTime=0;dirPause=true;CheckNextState();CancelLasers();} // then _laserCancelFlag
                break;
            }
        }
    }
    void P5Update(float m,float a,int n,float dt)
    {
        bool odd=(repTimes&1)!=0,bit1=(repTimes&2)!=0;
        if(pattern5First)m=Pattern5EaseIn.Evaluate(m);
        position=OpenAttackPosition+new Vector3(InfX(1-m,60),0,InfZ(1-m,50));
        float rel=Wrap180(AngleToPlayer()-lookAngle),best=0,min=180;
        foreach(var w in WatchAngles){float d=Mathf.Abs(Wrap180(w-rel));if(min>d){min=d;best=w;}}
        if(odd)lookAngle+=(bit1?-1:1)*SecondShortLaserCoreRotate*dt*(1-InQuart(a));           // spin
        else lookAngle-=Wrap180(best-rel)*dt*SecondFireLookRate*InQuart(Mathf.Min(2*a,1));   // turn a diagonal onto the player
        CoreRotation();
        if((n<WingMax||m<.9f)&&laped)fireReady=true;
        if(fireReady)
        {
            // Native rapid overrides (p5way3 3/4/5 by wings, p6sl 4/7 after 90 s) are not available; template counts used.
            if(!odd)Fire("bos04p5way3",upper05);
            else for(int i=0;i<4;i++)FireAlong("bos04p6sl",upper[i],upperTarget[i]);
            fireReady=false;
        }
        if(n!=destroyWingCount){SetRepeatTime(SecondFireRepeat[Mathf.Clamp(n,0,4)]);destroyWingCount=n;}
        if(m>=1){SetDirectionTime(HpState>=5?SecondOneRoundLast:SecondOneRoundNormal);pattern5First=false;}
    }

    // ---- PT6 (PatternMove6 0x1D8EDF0, pat6fire 0x1D90DF0, infinityMove 0x1D92AA0, coreLongLaser 0x1D91DC0)
    void PT6(float dt)
    {
        switch(mode)
        {
            case 0:
                dirPause=false;SetDirectionTime(LastOneRound);reverse=false;localTime=0;laserCount=LastLaserCount;mode=10;
                goto case 10;
            case 10:
            {
                float r=DirRate;
                float e=InOutSine(reverse?1-r:r);
                position=OpenAttackPosition+new Vector3(InfX(1-e,60),0,InfZ(1-e,20));
                lookAngle+=(reverse?1:-1)*LastOneRoundCoreRotate*dt*(1-InQuart(r));CoreRotation();
                UpdateWingRotation(dt*LastOneRoundBodyRotate);
                if(r>=1){SetDirectionTime(LastOneRound);reverse=!reverse;laserCount=LastLaserCount;localTime=0;}
                localTime-=dt;
                if(localTime<=0)
                {
                    if(laserCount>0){for(int i=0;i<4;i++)Fire("bos04laser",upper[i],0,upperTarget[i]);localTime=LastLaserInterval;laserCount--;}
                    else{Round1Sound.Play("bg4_boss_tornado_bullet_01");Fire("bos04p5way3s",upper05);localTime=LastShotInterval;}
                }
                break;
            }
        }
    }
    // upperCore.localRotation = Euler(0,0,-look) * Euler(0,0,-180) * Euler(0,0,wingRotation)
    void CoreRotation(){if(upperCore)upperCore.localRotation=Quaternion.Euler(0,0,wingRotation-180-lookAngle);}
    float AngleToPlayer(){var d=PlayerSource-position;return Mathf.Atan2(d.x,d.z)*Mathf.Rad2Deg;}

    // ---- parts (setBodyHeadCollision 0x1D92F20; EnePartsGroup ToSleep/Wakeup)
    // false: mainBody colliders off, mainHead on; true: the reverse (same capsule; the head only takes player bullets).
    void SetBodyHead(bool isHeadHit){if(openWing)return;Enable(body,isHeadHit);Enable(head,!isHeadHit);}
    static void Enable(Part p,bool on){if(p!=null)p.enabled=on;}
    // Wing BreakParts: BreakEffect pf_eff_explposion03 at the wing, wing model hidden.
    protected override void PartBroken(Part part)
    {
        if(part.root&&visual&&part.root!=visual.transform){Boom("pf_eff_explposion03",part.root.position);part.root.gameObject.SetActive(false);}
        Round1Sound.Event("enemyDead");
    }

    // ---- guardians (CheckGuardians 0x1D8B840, DestroyGuardians 0x1D8BE20, Ene_Bos04Bit)
    void CheckGuardians()
    {
        if(bitL==null||!bitL.Alive)bitL=SummonBit(-1); // bos04_bitL
        if(bitR==null||!bitR.Alive)bitR=SummonBit(1);  // bos04_bitR
    }
    // bos04_bitL/R: start (∓100,0,200), Translate to (∓100,0,50) in 2 s (easeType 8 [I: ease-out]), then spin 360°/2 s about y.
    Minion SummonBit(int side)
    {
        return Summon(BitModel,new Vector3(100*side,0,199),Vector3.zero,(m,dt)=>
        {
            float u=Mathf.Clamp01(m.age/2);m.position=new Vector3(100*side,0,Mathf.Lerp(199,50,1-(1-u)*(1-u)));
            if(m.age>2)m.facing=Quaternion.Euler(0,-side*180*(m.age-2),0);
        });
    }
    void FireGuardians()
    {
        if(bitL!=null&&bitL.Alive&&bitL.target.visual)Fire("bos04bit0",bitL.target.visual.transform); // Ene_Bos04Bit.Fire 0x1D8AEA0
        if(bitR!=null&&bitR.Alive&&bitR.target.visual)Fire("bos04bit0",bitR.target.visual.transform);
    }
    void DestroyGuardians()
    {
        foreach(var b in new[]{bitL,bitR})if(b!=null&&b.Alive){if(b.target.visual)Boom("pf_eff_explposion02",b.target.visual.transform.position);combat.DespawnSourceTarget(b.target);}
        bitL=bitR=null;
    }

    // ---- Sg01 fighters (bos04_sg00L/R/C EnemyData; Sg01's own movement is approximated [I])
    void SpawnRouteFighter(Vector3 at,int side)
    {
        float chase=-1;
        Summon(SgModel,at+RoutePoint(0,side),Vector3.zero,(m,dt)=>
        {
            float s=m.age*RouteSpeed;
            if(s<RouteLength)
            {
                var p=at+RoutePoint(s,side);var d=p-m.position;
                if(d.sqrMagnitude>1e-6f){m.facing=Quaternion.LookRotation(new Vector3(d.x,0,d.z));m.velocity=d.normalized*ChaseSpeed;}
                m.position=p;return;
            }
            if(chase<0)chase=m.age;
            Chase(m,dt,m.age-chase);
        });
    }
    // bos04_sg00C: placement offset x+2, turn to face down, Translate (0,0,-50) in 1 s, then the same chase.
    void SpawnCenterFighter(Vector3 at)
    {
        at.x+=2;
        Summon(SgModel,at,new Vector3(0,0,-ChaseSpeed),(m,dt)=>
        {
            m.facing=m.age<1?Quaternion.Euler(0,180,0):m.facing;
            if(m.age<1){m.position=at+new Vector3(0,0,-50*m.age);return;}
            Chase(m,dt,m.age-1);
        });
    }
    // Horming 30°/s for 5 s at speed 40, then ForwardMove [I].
    void Chase(Minion m,float dt,float t)
    {
        if(t<ChaseTime)
        {
            var to=PlayerSource-m.position;to.y=0;
            if(to.sqrMagnitude>1e-4f)m.velocity=Vector3.RotateTowards(m.velocity,to.normalized*ChaseSpeed,ChaseTurn*Mathf.Deg2Rad*dt,0);
        }
        m.position+=m.velocity*dt;
        if(m.velocity.sqrMagnitude>1e-6f)m.facing=Quaternion.LookRotation(new Vector3(m.velocity.x,0,m.velocity.z));
    }
    static Vector3 RoutePoint(float s,int side)
    {
        float f=Mathf.Clamp(s/RouteLength,0,1)*(RouteL.Length-1);int i=Mathf.Min((int)f,RouteL.Length-2);
        var p=Vector2.Lerp(RouteL[i],RouteL[i+1],f-i);
        return new Vector3(-side*p.x,0,p.y); // side -1 = L as stored, +1 = R mirrored
    }

    // ---- fire helpers
    // BulletDirFireAsync(mzt -> dirt) for a non-beam template (bos04p6sl: nStartArc 270, not aimed): offset its arc onto the line.
    void FireAlong(string pattern,Transform from,Transform to)
    {
        if(!from||!to)return;
        var cam=Weapon.player.stageCamera;Vector3 a=cam.WorldToViewportPoint(from.position),b=cam.WorldToViewportPoint(to.position);
        float dx=(b.x-a.x)*cam.aspect,dy=b.y-a.y;
        Fire(pattern,from,Mathf.Atan2(dy,dx)*Mathf.Rad2Deg-270);
    }

    // ---- destruction: shared Ene_BosBase sequence (PatternMoveDestruction 0x1D8F1C0: sink 150, turn to (20,45,0), dead effect
    // at 3.5 s), then PlayQue(42 exp_st3_boss_c03) at 5.5 s.
    protected override void Defeat(float dt)
    {
        base.Defeat(dt);
        if(!finalSE&&StateAge>=5.5f-1e-4f){finalSE=true;Round1Sound.Play("exp_st3_boss_c03");}
    }
    public override void OnDefeated(){bitL=bitR=null;base.OnDefeated();}

    // ---- helpers (VectorUtility.InfinitySymbol 0x1DF7690 / FreeFall 0x1DF71B0, EasingUtility)
    static float InfX(float t,float w)=>w*Mathf.Cos((Mathf.Clamp01(t)*360+90)*Mathf.Deg2Rad);
    static float InfZ(float t,float h)=>h*Mathf.Sin(2*(Mathf.Clamp01(t)*360+90)*Mathf.Deg2Rad);
    static float FreeFall(float t)=>Mathf.Abs(Mathf.Sin(Mathf.Clamp01(t-Mathf.Floor(t))*180*Mathf.Deg2Rad));
    static float InOutQuad(float t)=>t<.5f?2*t*t:1-2*(1-t)*(1-t);
    static float OutQuad(float t)=>1-(1-t)*(1-t);
    static float OutSine(float t)=>Mathf.Sin(t*90*Mathf.Deg2Rad);
    static float InOutSine(float t)=>(1-Mathf.Cos(t*180*Mathf.Deg2Rad))*.5f;
    static float InQuart(float t)=>t*t*t*t;
    static float Wrap180(float v){v=Mathf.Clamp(v-Mathf.Floor(v/360)*360,0,360);return v>180?v-360:v;}
}
