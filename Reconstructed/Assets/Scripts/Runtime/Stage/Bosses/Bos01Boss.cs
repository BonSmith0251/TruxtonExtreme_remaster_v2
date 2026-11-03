using System.Collections.Generic;
using UnityEngine;

// Ene_Bos01, the BG01 boss ("Gashim"), from the native code (evidence/bosses/Bos01/SPEC.md; RVAs there and below).
// No HP phases: the native class never reads _hpState. One fixed loop: EntryWait -> PT1 (dive to the rush point)
// -> PT2 (wing+body laser02 sweep, return home) -> PT6 (home hover: three wing patterns + core rings) -> PT1 ...
// Positions are source sky-plane units (x right, z up the screen, y toward the camera), the boss localPosition.
// Code side "L" (bits L*, BodyL, WL*) is the *40 transforms (database parts shoulder_r*); "R" is *60 (shoulder_l*).
// Marked [I] where the spec infers, [?] where it does not know.
public class Bos01Boss : StageBoss
{
    enum S { EntryWait, PT1, PT2, PT6 } // Boss01State (Destruction is the base Defeat)

    // Ene_Bos01..cctor (0x1d7bf30)
    static readonly Vector3 Home=new Vector3(0,0,40),Rush=new Vector3(0,0,-30);
    static readonly Vector3 SpawnPosition=new Vector3(0,0,200); // ene_boss01 EnemyData position (the builder clamps rest to z 50)
    const float MoveSpring=8,MoveDamping=5.6f,MaxStep=.05f,StopSq=.01f;           // UpdateVelocityMovement 0x1d7ba80
    const float HoverSpeed=2,HoverAmplitude=5,BlendIn=1.5f,Pt1Wait=5,Pt1Wait2=2;  // PT1_*
    const float FireWait1=1,FireWait2=.1f,HomeArrival=.5f,HomeSpring=.4f,Pt2Wait=1.5f; // PT2_*
    const float WingOpenSpeed=.5f,WingCloseSpeed=1;
    const float WaitBetweenPatterns=5,ResetToLaserWait=3,WaitAfterLast=10,AttackDelay=1; // Wing_*, ActiveAttack.WaitTimer
    const float CoreInitialWait=10,CoreShotInterval=.5f,CoreSequenceInterval=10;const int CoreShotCount=8; // Core_*
    // PT1 mode 0: _hoverTimeOffset = 3pi/2 - fmod(3, 2pi)
    static readonly float Pt1HoverOffset=1.5f*Mathf.PI-3f;

    // CannonBit
    const int Shoulders=0xFF,BodyL=0x100,BodyR=0x200,Core=0x400,WingAll=0x1FF800,WingBody=0x1FFB00;
    const string Laser01="bos01laser01",Laser02="bos01laser02",Bullet01="bos01bullet01",Bullet10="bos01bullet10",Bullet11="bos01bullet11";

    // _cannons / _cannonTargets (prefab order; bit i = 1<<i: L4 L3 L2 L1 R4 R3 R2 R1) and the part each one carries.
    static readonly string[] CannonPaths={"pf_bs01/body/wing40/cannon44","pf_bs01/body/wing40/cannon 43","pf_bs01/body/wing40/cannon 42","pf_bs01/body/wing40/cannon 41",
        "pf_bs01/body/wing60/cannon 64","pf_bs01/body/wing60/cannon 63","pf_bs01/body/wing60/cannon 62","pf_bs01/body/wing60/cannon 61"};
    static readonly string[] CannonTargets={"pf_bs01/body/wing40/cannon44t","pf_bs01/body/wing40/cannon43t","pf_bs01/body/wing40/cannon42t","pf_bs01/body/wing40/cannon41t",
        "pf_bs01/body/wing60/cannon64t","pf_bs01/body/wing60/cannon63t","pf_bs01/body/wing60/cannon62t","pf_bs01/body/wing60/cannon61t"};
    static readonly string[] CannonParts={"shoulder_r4","shoulder_r3","shoulder_r2","shoulder_r1","shoulder_l4","shoulder_l3","shoulder_l2","shoulder_l1"};
    // _wingMuzzles (bit 1<<(i+11): WL5..WL1, WR5..WR1); each has a child "target" 1 unit ahead.
    static readonly string[] WingMuzzles={"pf_bs01/body/wing40/psrts45/muzzle","pf_bs01/body/wing40/psrts 44/muzzle","pf_bs01/body/wing40/psrts 43/muzzle","pf_bs01/body/wing40/psrts 42/muzzle","pf_bs01/body/wing40/psrts 41/muzzle",
        "pf_bs01/body/wing60/psrts 65/muzzle","pf_bs01/body/wing60/psrts 64/muzzle","pf_bs01/body/wing60/psrts 63/muzzle","pf_bs01/body/wing60/psrts 62/muzzle","pf_bs01/body/wing60/psrts 61/muzzle"};

    // WingAttackCommand tables (_pattern1.._pattern3 = _allPatterns; _pattern4/_pattern5 are built but unused).
    struct Cmd {public float time;public int bits;public bool laser;public Cmd(float t,int b,bool l){time=t;bits=b;laser=l;}}
    const int L1=8,L2=4,L3=2,L4=1,R1=128,R2=64,R3=32,R4=16;
    static readonly Cmd[][] Patterns={
        new[]{new Cmd(0,L1,false),new Cmd(1,R1,false),new Cmd(2,L2,false),new Cmd(3,R2,false),new Cmd(4,L3,false),new Cmd(5,R3,false),
              new Cmd(6,L4,false),new Cmd(7,R4,false),new Cmd(8,BodyL,false),new Cmd(9,BodyR,false),new Cmd(10,0,false)},
        new[]{new Cmd(0,L1|R1,true),new Cmd(.5f,L2|R2,true),new Cmd(1,L3|R3,true),new Cmd(1.5f,L4|R4,true),new Cmd(2.5f,BodyL|BodyR,true),
              new Cmd(3,L1|L2|L3|L4,true),new Cmd(4,R1|R2|R3|R4,true),new Cmd(6,Shoulders|BodyL|BodyR,true),new Cmd(8,0,false)},
        new[]{new Cmd(0,L4,false),new Cmd(.1f,L3,false),new Cmd(.2f,L2,false),new Cmd(.3f,L1,false),new Cmd(.4f,BodyL,false),new Cmd(.5f,BodyR,false),
              new Cmd(.6f,R1,false),new Cmd(.7f,R2,false),new Cmd(.8f,R3,false),new Cmd(.9f,R4,false),new Cmd(1,0,false)}};
    struct Attack {public int bit;public bool laser,rolled;public float wait;}

    readonly Transform[] cannon=new Transform[8],cannonTarget=new Transform[8],bulletMuzzle=new Transform[8],laserMuzzle=new Transform[8];
    readonly Part[] cannonPart=new Part[8];
    readonly float[] openRate=new float[8];
    readonly Transform[] wingMuzzle=new Transform[10],wingTarget=new Transform[10];
    Transform bodyLaser1,bodyLaser2,bodyCore,leftWing,rightWing;

    S state;int mode,cannonBits,orderBits,wingLaserBits;
    float stateWait,localTime,pt1Start,pt1Wait,hoverOffset,springScale,wingArc;
    bool physics,entry,wingOpen,wingMoving,cannonRotating;
    Vector3 velocity,moveTarget;
    // WingAttackPatternLogic
    int wState,wIndex,wLast;float wTimeline,wWait;bool cycleDone;
    readonly List<Attack> active=new List<Attack>();
    // CoreAttackPatternLogic
    int coreMode,coreShots;float coreWait;
    // destruction extras
    float bombCur,bombBase;bool finalSound;

    protected override Vector3 EntryStart(Form f)=>SpawnPosition;
    protected override Vector3 DestructionEuler=>new Vector3(20,135,0); // Destruction_Rotation
    protected override float DeadEffectTime=>3.5f;                      // Destruction_FallStartTime

    // Initialize (0x1d794c0) + ReStart (0x1d7ace0) + GetStart (0x1d79470: OffLockon|NoDamaged).
    protected override void OnSpawned()
    {
        for(int i=0;i<8;i++)
        {
            var parent=Find(CannonPaths[i]);cannon[i]=parent?parent.Find("cannon"):null;cannonTarget[i]=Find(CannonTargets[i]);
            bulletMuzzle[i]=cannon[i]?cannon[i].Find("cannon_muzzle"):null;laserMuzzle[i]=cannon[i]?cannon[i].Find("laser_cannon_muzzle"):null;
            cannonPart[i]=GetPart(CannonParts[i]);openRate[i]=1;
            if(cannon[i])cannon[i].localRotation=Quaternion.Euler(-90,0,0); // CannonData.ReStart: openRate 1 -> laser pose
        }
        for(int i=0;i<10;i++){wingMuzzle[i]=Find(WingMuzzles[i]);wingTarget[i]=wingMuzzle[i]?wingMuzzle[i].Find("target"):null;}
        bodyLaser1=Find("pf_bs01/body/body_laser_muzzle40");bodyLaser2=Find("pf_bs01/body/body_laser_muzzle60");bodyCore=Find("pf_bs01/body/body_muzzle50");
        leftWing=Find("pf_bs01/body/wing60");rightWing=Find("pf_bs01/body/wing40");
        SetWingAngle(90);wingArc=0;wingOpen=false;
        cannonBits=orderBits=Shoulders;wingLaserBits=WingAll;
        physics=false;velocity=Vector3.zero;moveTarget=position;pt1Start=0;pt1Wait=Pt1Wait;springScale=1;entry=true;
        state=S.EntryWait;mode=0;stateWait=0;localTime=0;hoverOffset=0;
        WingInitialize();coreMode=0;coreWait=CoreInitialWait;coreShots=0;
        // GetStart: OffLockon|NoDamaged until the first dive ends. Collision itself stays on (no OffCollision) [I].
        Target.invulnerable=true;Target.lockOn=false;Target.touchesWhileInvulnerable=true;
        foreach(var p in parts)if(!p.body&&p.target!=null){p.target.invulnerable=true;p.target.lockOn=false;}
    }

    // EntryWait + the first PT1; true when PT1 clears the entry flags (ResetObjectFlag + ResetBossTimer).
    protected override bool Entrance(float dt)
    {
        Step(dt);
        if(state==S.EntryWait)
        {
            // [I] _mover._isFinishDelay is true at once (delayTime 0); PlayQue(101), SetBossState(PT1), _orderBits = 0xFF.
            Round1Sound.Play("bg1_boss_mothership_02");SetState(S.PT1);orderBits=Shoulders;return false;
        }
        return PT1(dt);
    }

    // ReStart: wings parts 1/2 get NoDamage. [I] Shots pass through them here (invulnerable) instead of being absorbed,
    // and they are not lock-on targets (they could never break).
    protected override void OnFightStart()
    {
        foreach(var w in new[]{"wingR","wingL"}){var p=GetPart(w);if(p!=null)SetPartVulnerable(p,false);}
    }

    protected override void Fight(float dt)
    {
        Step(dt);
        switch(state)
        {
            case S.EntryWait:SetState(S.PT1);orderBits=Shoulders;break;
            case S.PT1:PT1(dt);break;
            case S.PT2:PT2(dt);break;
            case S.PT6:PT6(dt);break;
        }
    }

    // StateExec head (0x1d7b330): wings, spring, shoulder cannon rolls, _stateWaitTime. (_isHomeMove is never set, so the
    // infinity-loop home sway 0x1d7b8c0 never runs.)
    void Step(float dt)
    {
        if(wingOpen){wingMoving=wingArc<1;wingArc=Mathf.Clamp01(wingArc+dt*WingOpenSpeed);}
        else{wingMoving=wingArc>0;wingArc=Mathf.Clamp01(wingArc-dt*WingCloseSpeed);}
        if(wingMoving)SetWingAngle(EaseInOut(90,0,wingArc));
        Move(dt);
        cannonRotating=cannonBits!=orderBits;
        if(cannonRotating)for(int i=0;i<8;i++)
        {
            int b=1<<i;if((cannonBits&b)==(orderBits&b))continue;
            bool laser=(orderBits&b)!=0;
            if(!Roll(i,dt,laser))cannonBits=laser?cannonBits|b:cannonBits&~b;
        }
        if(stateWait>0)stateWait-=dt;
    }

    // SetBossState (0x1d7b200)
    void SetState(S s){if(state!=s){state=s;mode=0;springScale=1;}}

    // UpdateVelocityMovement (0x1d7ba80): damped spring toward _movementTarget in sub-steps of at most 0.05 s.
    void Move(float dt)
    {
        if(!physics)return;
        float k=MoveSpring*springScale,c=MoveDamping*springScale;
        for(float rest=dt;rest>0;rest-=MaxStep)
        {
            float h=Mathf.Min(rest,MaxStep);
            velocity+=((moveTarget-position)*k-velocity*c)*h;position+=velocity*h;
        }
    }

    // SetWingAngle (0x1d7b230): _leftWingModel (wing60) yaw +a, _rightWingModel (wing40) yaw -a; 90 = folded back.
    void SetWingAngle(float a)
    {
        if(leftWing)leftWing.localRotation=Quaternion.Euler(0,a,0);
        if(rightWing)rightWing.localRotation=Quaternion.Euler(0,-a,0);
    }
    // EasingUtility.EaseInOut (0x1de7fa0): quadratic in-out from start to end.
    static float EaseInOut(float start,float end,float v)
    {
        v*=2;if(v<1)return start+(end-start)*.5f*v*v;
        v-=1;return start-(end-start)*.5f*(v*(v-2)-1);
    }
    // CannonData.Roll (0x1d78760): 1 s between the bullet pose (0) and the laser pose (Euler -90 on x); false when done or dead.
    bool Roll(int i,float dt,bool laser)
    {
        if(!CannonAlive(i))return false;
        float r=openRate[i];bool moving=laser?r<1:r>0;
        openRate[i]=Mathf.Clamp01(r+(laser?dt:-dt));
        if(moving&&cannon[i])cannon[i].localRotation=Quaternion.Euler(EaseInOut(0,-90,openRate[i]),0,0);
        return moving;
    }
    bool CannonAlive(int i)=>cannonPart[i]==null||!cannonPart[i].broken;

    // ---------------------------------------------------------------- PT1 (PatternMove1 0x1d79c70)
    // Returns true on the frame the first dive clears the entry flags.
    bool PT1(float dt)
    {
        bool entryEnded=false;
        if(mode==0)
        {
            localTime=0;pt1Start=0;hoverOffset=Pt1HoverOffset;
            if(wingOpen)Round1Sound.Play("bg1_boss_wing_close_01"); // PlayQue(107)
            wingOpen=false;mode=1;
        }
        if(mode==1)
        {
            localTime+=dt;pt1Start+=dt;float blend=Mathf.Clamp01(localTime/BlendIn);
            moveTarget=Rush+new Vector3(0,0,Mathf.Sin(HoverSpeed*pt1Start+hoverOffset)*HoverAmplitude*blend);physics=true;
            if(localTime<pt1Wait)return false;
            if(entry){entry=false;entryEnded=true;}
        }
        SetState(S.PT2);
        return entryEnded;
    }

    // ---------------------------------------------------------------- PT2 (PatternMove2 0x1d79ef0)
    void PT2(float dt)
    {
        if(mode<11){pt1Start+=dt;moveTarget=Rush+new Vector3(0,0,Mathf.Sin(HoverSpeed*pt1Start+hoverOffset)*HoverAmplitude);}
        switch(mode)
        {
            case 0:wingOpen=false;orderBits=Shoulders;if(!wingMoving)mode=10;break;
            case 10:
                if(cannonRotating)break;
                int saved=wingLaserBits;wingLaserBits|=WingAll;FireCannons(WingBody,0,Laser02);wingLaserBits=saved;
                stateWait=FireWait1;mode++;break;
            case 11:
                if(stateWait>0)break;
                if(!wingOpen)Round1Sound.Play("bg1_boss_wing_open_01"); // PlayQue(105)
                stateWait=FireWait2;moveTarget=Home;springScale=HomeSpring;mode++;break;
            case 12:if(stateWait>0)break;wingOpen=true;mode++;break;
            case 13:if((position-Home).magnitude<HomeArrival){localTime=0;mode++;}break;
            case 14:localTime+=dt;if(localTime>=Pt2Wait)SetState(S.PT6);break;
        }
    }

    // ---------------------------------------------------------------- PT6 (PatternMove6 0x1d7a2c0)
    void PT6(float dt)
    {
        if(mode==0)
        {
            WingInitialize();coreMode=0;coreWait=CoreInitialWait;coreShots=0;
            pt1Start=0;hoverOffset=0;moveTarget=Home;velocity=Vector3.zero;physics=true;mode=1;
        }
        pt1Start+=dt;moveTarget=Home+new Vector3(0,0,Mathf.Sin(HoverSpeed*pt1Start)*HoverAmplitude);physics=true;
        WingUpdate(dt);
        if(cycleDone){cycleDone=false;pt1Wait=Pt1Wait2;SetState(S.PT1);return;}
        // CoreAttackPatternLogic.Update (inlined; 0x1d78850)
        if(coreWait>0)coreWait-=dt;
        switch(coreMode)
        {
            case 0:if(coreWait<=0)coreMode=1;break;
            case 1:coreMode=2;coreWait=0;coreShots=0;break;
            case 2:
                if(coreWait>0)break;
                if(coreShots>=CoreShotCount){coreWait+=CoreSequenceInterval;coreMode=3;}
                else{FireCannons(Core,coreShots%2,Laser01);coreWait+=CoreShotInterval;coreShots++;}
                break;
            case 3:if(coreWait<=0)coreMode=1;break;
        }
    }

    // ---------------------------------------------------------------- WingAttackPatternLogic
    // Initialize (0x1d89560)
    void WingInitialize(){wState=1;wIndex=0;wTimeline=0;wLast=-1;wWait=0;active.Clear();cycleDone=false;wingLaserBits|=WingAll;}
    // Update (0x1d89c80): Waiting 0, Executing 1, Resetting 2.
    void WingUpdate(float dt)
    {
        ProcessActiveAttacks(dt);
        switch(wState)
        {
            case 0:
                wWait-=dt;if(wWait>0)break;
                wIndex=(wIndex+1)%Patterns.Length;wState=1;wTimeline=0;wLast=-1;break;
            case 1:
            {
                wTimeline+=dt;var p=Patterns[wIndex];
                for(int i=wLast+1;i<p.Length;i++)if(wTimeline>=p[i].time){Schedule(p[i]);wLast=i;}
                if(wLast>=p.Length-1&&active.Count==0)
                {
                    if(wIndex<Patterns.Length-1){wWait=WaitBetweenPatterns;wState=0;}
                    else{wState=2;wWait=ResetToLaserWait;}
                }
                break;
            }
            case 2:
                wWait-=dt;if(wWait>0)break;
                orderBits=Shoulders;wingLaserBits|=WingAll;cycleDone=true;wState=0;wWait=WaitAfterLast;break;
        }
    }
    // ScheduleAttack (0x1d89970): one ActiveAttack per set bit, lowest bit first (EnumerateCannonBits 0x1d89110).
    // On a pattern's first command with _bossAliveTime < 60 the native code also calls CallAsteroids (0x1d89290:
    // ene_asteroid_bs_l/m/s, left set first, then alternating). Not reconstructed here (meteor spawning skipped).
    void Schedule(Cmd c)
    {
        for(int m=c.bits;m!=0;m&=m-1)active.Add(new Attack{bit=m&-m,laser=c.laser,wait=AttackDelay});
    }
    // ProcessActiveAttacks (0x1d895f0): request the pose once, fire after 1 s once a shoulder cannon has rolled.
    void ProcessActiveAttacks(float dt)
    {
        for(int i=active.Count-1;i>=0;i--)
        {
            var a=active[i];
            if(!a.rolled)
            {
                if((a.bit&Shoulders)==0){int wb=a.bit&WingAll;if(wb!=0)wingLaserBits=a.laser?wingLaserBits|wb:wingLaserBits&~wb;}
                else if(((cannonBits&a.bit)!=0)!=a.laser)orderBits=a.laser?orderBits|a.bit:orderBits&~a.bit;
                a.rolled=true;
            }
            a.wait-=dt;active[i]=a;
            if(a.wait>0)continue;
            if((a.bit&Shoulders)!=0&&((cannonBits&a.bit)!=0)!=a.laser)continue;
            if((a.bit&(BodyL|BodyR))==0)FireCannons(a.bit,0,Laser01);
            else Fire(a.laser?Laser01:Bullet01,a.bit==BodyL?bodyLaser1:bodyLaser2);
            active.RemoveAt(i);
        }
    }

    // ---------------------------------------------------------------- fire
    // FireCannons (0x1d78a40): shoulders fire bullet01 from cannon_muzzle in the bullet pose, or a beam from
    // laser_cannon_muzzle toward cannonNNt in the laser pose; wings via FireWingCannons; body lasers along the muzzle;
    // the core fires bullet10 (param 0) / bullet11 from body_muzzle50.
    void FireCannons(int bits,int param,string laser)
    {
        for(int i=0;i<8;i++)
        {
            if((bits&(1<<i))==0||!CannonAlive(i))continue;
            if(openRate[i]<1)Fire(Bullet01,bulletMuzzle[i]);else Fire(laser,laserMuzzle[i],0,cannonTarget[i]);
        }
        if((bits&WingAll)!=0)FireWingCannons(bits,laser);
        if((bits&BodyL)!=0)Fire(laser,bodyLaser1);
        if((bits&BodyR)!=0)Fire(laser,bodyLaser2);
        if((bits&Core)!=0)Fire(param!=0?Bullet11:Bullet10,bodyCore);
    }
    // FireWingCannons (0x1d78eb0): laser toward muzzle/target when _wingLaserBits has the bit, else bullet01.
    void FireWingCannons(int bits,string laser)
    {
        for(int i=0;i<10;i++)
        {
            int b=1<<(i+11);if((bits&b)==0||!wingMuzzle[i])continue;
            if((wingLaserBits&b)!=0)Fire(laser,wingMuzzle[i],0,wingTarget[i]);else Fire(Bullet01,wingMuzzle[i]);
        }
    }

    // ---------------------------------------------------------------- parts and destruction
    // OnPartsBreak (0x1d79b70): a shoulder cannon (parts 3..10) stops; AddShake(1,1,10) is not reconstructed [I].
    // PartsList BreakEffect pf_eff_explposion03; hiding the cannon follows the StageBoss convention [?].
    protected override void PartBroken(Part part)
    {
        if(part.root&&visual&&part.root!=visual.transform){Boom("pf_eff_explposion03",part.root.position);part.root.gameObject.SetActive(false);}
        Round1Sound.Event("enemyDead");
    }

    public override void OnDefeated()
    {
        bool started=State==EncounterState.Defeating||StageCleared;
        base.OnDefeated();
        if(!started&&State==EncounterState.Defeating){bombCur=0;bombBase=.2f;finalSound=false;}
    }
    // PatternMoveDestruction (0x1d7a5f0) on top of the shared sequence: small bombs (seID 40 exp_st3_boss_a01) run through
    // the whole 5.5 s with Ene_BosBase.IsCallSmallBomb timing (base + rand*0.1, base*0.9); the base draws them until the
    // dead effect, this class after it. At 5.5 s PlayQue(42 exp_st3_boss_c03) before Ene_BosBase.ToDestroid.
    protected override void Defeat(float dt)
    {
        base.Defeat(dt);
        bombCur-=dt;
        if(bombCur<=0)
        {
            bombCur=bombBase+Random.value*.1f;bombBase*=.9f;Round1Sound.Play("exp_st3_boss_a01");
            if(StateAge>=DeadEffectTime&&visual)
            {
                var at=cannon[Random.Range(0,8)]; // GetSmallBombPosition (0x1d793f0): a random shoulder cannon
                Boom("pf_eff_explposion01",at?at.position:visual.transform.position,.6f);
            }
        }
        if(!finalSound&&StateAge>=5.5f){finalSound=true;Round1Sound.Play("exp_st3_boss_c03");}
    }
}
