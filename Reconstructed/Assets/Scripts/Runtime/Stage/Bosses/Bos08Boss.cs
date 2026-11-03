using System.Collections.Generic;
using UnityEngine;

// Ene_Bos08A / Ene_Bos08B / Ene_Bos08C, the BG08 final boss, from the native code (evidence/bosses/Bos08/SPEC.md; RVAs
// there and below). Three successive forms in one class (FormIndex 0/1/2): A, the ground fortress (4 covers, 6 arms),
// whose core escapes and becomes B, the spinning top (figure-eight, dash, bow volleys), which sinks and spawns C, the
// core (sway, twin lasers, homing side shots, tracking bow rings). The reconstruction plays the Chria/Unknown actor
// path (A -> B -> C; Ene_Bos08B.ShouldCreateBossC 0x1db1420). None of the classes read _hpState.
// Positions are source sky-plane units (x right, z up the screen, y toward the camera). [I] = inferred, [?] = unknown.
public class Bos08Boss : StageBoss
{
    char form; // 'A' / 'B' / 'C' from Current.model
    float clock; // own clock for scheduled effects and bow launches
    const float Scale=1; // InGameManager.GetEventRepeatScale() [?]: its per-mode value is not in the spec

    // ================================================================ shared helpers
    static void S(string clip){Round1Sound.Play(clip);}
    const string Small="pf_eff_explposion01",Middle="pf_eff_explposion02",Large="pf_eff_explposion03"; // ShortCutEffect codes [I]
    void Fx(string name,string fallback,Vector3 world,float scale=1)
    {
        var rot=Weapon.player.stageCamera.transform.rotation*Quaternion.Euler(-90,0,0);
        if(!combat.effects.Play(name,world,rot,Unit*scale,StageTime)&&fallback!=null)combat.effects.Play(fallback,world,rot,Unit*scale,StageTime);
    }
    static Transform FindUnder(Transform root,string name)
    {
        if(!root)return null;
        foreach(var t in root.GetComponentsInChildren<Transform>(true))if(t.name==name)return t;
        return null;
    }
    void Wake(Part p){if(p==null||p.broken)return;p.enabled=true;SetPartVulnerable(p,true);}   // EnePartsGroup.Wakeup
    void Sleep(Part p){if(p==null)return;p.enabled=false;SetPartVulnerable(p,false);}            // EnePartsGroup.ToSleep
    static bool Broken(Part p)=>p==null||p.broken;                                                // IsPartBroken: missing = broken
    static void Cross(Animator a,string state,float fade)
    {if(a&&a.isActiveAndEnabled&&a.HasState(0,Animator.StringToHash(state)))a.CrossFadeInFixedTime(state,fade);}
    static void PlayAnim(Animator a,string state)
    {if(a&&a.isActiveAndEnabled&&a.HasState(0,Animator.StringToHash(state)))a.Play(state);}

    // Scheduled effects (OnPartsBreak explosion chains: StartEffectWithDelay) and hides.
    struct Pending {public float at;public Vector3 pos;public string fx;public float scale;public Transform hide;}
    readonly List<Pending> pending=new List<Pending>(64);
    void TickPending()
    {
        for(int i=pending.Count-1;i>=0;i--)
        {
            var p=pending[i];if(clock<p.at)continue;
            if(p.fx!=null)Fx(p.fx,Middle,p.pos,p.scale);
            if(p.hide)p.hide.gameObject.SetActive(false);
            pending.RemoveAt(i);
        }
    }
    // Ene_BosBase.SetSmallBombSecond / IsCallSmallBomb: next = base + rand*0.1, base *= 0.9 (as Round1Boss).
    float bombBase,bombTimer;
    void SetSmallBomb(float s){bombBase=s;bombTimer=s;}
    bool SmallBomb(float dt){bombTimer-=dt;if(bombTimer>0)return false;bombTimer=bombBase+Random.value*.1f;bombBase*=.9f;return true;}

    // Bullets fired from a free source position with an absolute direction (BulletFireToList / bow bullets): a pool of
    // muzzle transforms placed on the stage plane, reused round-robin (no per-frame allocation).
    readonly Transform[] freeMuzzles=new Transform[64];int freeCursor;
    Transform FreeMuzzle(Vector3 source)
    {
        var t=freeMuzzles[freeCursor];
        if(!t){var go=new GameObject("Bos08 free muzzle "+freeCursor);go.hideFlags=HideFlags.DontSave;t=go.transform;t.SetParent(transform,false);freeMuzzles[freeCursor]=t;}
        freeCursor=(freeCursor+1)%freeMuzzles.Length;
        t.position=Weapon.player.WorldPoint(ToViewport(source));return t;
    }
    // Absolute angle (degrees, 0 = right, 90 = up the screen; the native position/arc convention [I]). An aimed template
    // (isTarget) aims at the player first, so its offset is taken against that aim.
    void FireAt(string pattern,Vector3 source,float angle,bool aimedTemplate)
    {
        var d=PlayerSource-source;float baseAngle=aimedTemplate?Mathf.Atan2(d.z,d.x)*Mathf.Rad2Deg:270;
        Fire(pattern,FreeMuzzle(source),Mathf.DeltaAngle(baseAngle,angle));
    }

    protected override bool LockOnBody=>form!='A'; // A's core part is never woken: the body itself is never a target [I]
    protected override Vector3 EntryStart(Form f)
    {
        if(f.model.EndsWith("A"))return ARest+new Vector3(0,0,ApproachHeight);
        if(f.model.EndsWith("C"))return lastBPosition+BossCOffset;
        return f.rest;
    }

    protected override void OnSpawned()
    {
        form=Current.model[Current.model.Length-1];clock=0;pending.Clear();bows.Clear();cBows.Clear();
        Target.invulnerable=true;Target.lockOn=false;Target.touchesWhileInvulnerable=false;
        if(form=='A')ASpawn();else if(form=='B')BSpawn();else CSpawn();
    }
    protected override bool Entrance(float dt)
    {
        clock+=dt;TickPending();
        return form=='A'?AEntrance(dt):form=='B'?BEntrance(dt):CEntrance(dt);
    }
    protected override void OnFightStart()
    {
        if(form=='A')AFightStart();
    }
    protected override void Fight(float dt)
    {
        clock+=dt;TickPending();
        if(form=='A')AFight(dt);else if(form=='B')BFight(dt);else CFight(dt);
    }
    protected override void PartBroken(Part part)
    {
        if(form=='A'&&APartBroken(part))return;
        base.PartBroken(part);
    }
    public override void OnDefeated()
    {
        bool fresh=State!=EncounterState.Defeating&&!StageCleared;
        base.OnDefeated();
        if(!fresh||State!=EncounterState.Defeating)return;
        dmode=0;dtimer=0;dtime=0;dsound=false;
        if(form=='A')ADefeatStart();else if(form=='B')BDefeatStart();else CDefeatStart();
    }
    // Native destructions (none of them is the shared 150-unit sink): each form's PatternMoveDestruction below.
    int dmode;float dtimer,dtime;bool dsound;Quaternion dFrom,dTo;float dSinkFrom;
    protected override void Defeat(float dt)
    {
        if(!visual)return;
        clock+=dt;TickPending();
        if(form=='A')ADefeat(dt);else if(form=='B')BDefeat(dt);else CDefeat(dt);
    }

    // ================================================================ Ene_Bos08A
    enum AS { EntryWait, PT2, Turn } // BossState (Destruction is Defeat)
    // Ene_Bos08A..cctor (0x1dabc30)
    const string ArmBT="bos08arm0",CoverBT="bos08cover0",CoverBrokenBT="bos08cover1";
    const float ArmAttackDuration=12,ArmCooldown=4,FrontCoverInterval=1,BackCoverInterval=.5f,ArmFirstShotDelay=.01f,ArmShotInterval=.16f;
    const float ArmRotationAmplitude=40,ArmRotationFrequency=.125f,ArmAttackAnimationWait=2;
    static readonly string[] ArmParts={"arm01","arm03","arm04","arm06","arm07","arm09"};             // ArmPartOrder
    static readonly string[] ArmMuzzles={"muzzle_arm_pos01","muzzle_arm_pos03","muzzle_arm_pos04","muzzle_arm_pos06","muzzle_arm_pos07","muzzle_arm_pos09"};
    static readonly float[] ArmSign={1,-1,1,-1,1,-1};                                                // GetRotationSignForArm 0x1da8bc0
    static readonly string[] CoverParts={"cover01","cover03","cover07","cover09"};                   // CoverPartIds
    static readonly string[] CoverMuzzles={"muzzle_cover_01_1","muzzle_cover_01_2","muzzle_cover_03_1","muzzle_cover_03_2",
        "muzzle_cover_07_1","muzzle_cover_07_2","muzzle_cover_09_1","muzzle_cover_09_2"};              // BossMuzzleId 6..13
    static readonly int[][] FrontSeq={new[]{2},new[]{3},new[]{0},new[]{1},new[]{2,3},new[]{0,1},new[]{2,3,0,1}}; // FrontArmAttackSequence
    static readonly int[][] BackSeq={new[]{3},new[]{2},new[]{5},new[]{4},new[]{3,2},new[]{5,4},new[]{3,2,5,4}};   // BackArmAttackSequence
    static readonly int[][] BackCoverGroups={new[]{4,6},new[]{5,7}};                                 // BackCoverMuzzleOrder (07_1,09_1)/(07_2,09_2)
    // Placement [I]: the native A is a ground object at offset (0,-500,12300), i.e. 500 below the sky plane, brought on
    // screen by the ground scroll. Here it holds the plane at ARest with the perspective scale of that depth
    // (sinkDepth 500 -> x0.44), and scrolls in from above until the HallBoss stop.
    static readonly Vector3 ARest=new Vector3(0,0,20);
    const float GroundDepth=500,ApproachHeight=150,AreaStopTime=495; // HallBoss 470-495 (Stop|NoRestart): stop at its end [I]

    class Arm {public Part part;public Transform muzzle;public Animator anim;public float sign,timer,elapsed;public int stage;public bool active;}
    readonly Arm[] arm=new Arm[6];
    readonly Part[] cover=new Part[4];
    readonly Transform[] coverMuzzle=new Transform[8];
    readonly float[] coverLast=new float[4];
    Transform modelTop,coverCenter,bodyTop;Animator coreAnime;
    AS aState;int aMode,armIndex,backCoverIndex;bool armLooped,reversed;float aTimer,coverShotTimer,aEntryTime,turnTime;

    // Initialize (0x1da8f70) + ReStart (0x1dab040)
    void ASpawn()
    {
        sinkDepth=GroundDepth;
        modelTop=Find("pf_bs08_body");bodyTop=Find("me_bs08_body");coverCenter=Find("muzzle_cover_center");
        var core=Find("me_bs08_top");coreAnime=core?core.GetComponent<Animator>():null;
        for(int i=0;i<6;i++)
        {
            var p=GetPart(ArmParts[i]);
            arm[i]=new Arm{part=p,muzzle=Find(ArmMuzzles[i]),anim=p!=null&&p.root?p.root.GetComponentInChildren<Animator>(true):null,sign=ArmSign[i]};
            Sleep(p);
        }
        for(int i=0;i<4;i++){cover[i]=GetPart(CoverParts[i]);Sleep(cover[i]);}
        for(int i=0;i<8;i++)coverMuzzle[i]=Find(CoverMuzzles[i]);
        aState=AS.EntryWait;aMode=0;aTimer=0;armIndex=0;armLooped=false;backCoverIndex=0;reversed=false;coverShotTimer=0;
        aEntryTime=Mathf.Max(0,AreaStopTime-Current.spawnTime);
        if(modelTop)modelTop.localRotation=Quaternion.identity;
        defeatDuration=1+2.5f+2+5.7f; // PatternMoveDestruction modes 0..31
    }
    // EntryWait (StateExec 0x1dab280 inline = PatternMoveEntryWait 0x1daabd0): _isFinishDelay, then the area stop
    // (_isAreaDelayStop), then 1 s; ResetBossTimer, wake Cover01/Cover03, -> PT2.
    bool AEntrance(float dt)
    {
        float u=aEntryTime>0?Mathf.Clamp01(StateAge/aEntryTime):1;
        position=Vector3.Lerp(ARest+new Vector3(0,0,ApproachHeight),ARest,1-(1-u)*(1-u)); // the ground scroll [I]
        if(StateAge<aEntryTime+1)return false;
        position=ARest;Wake(cover[0]);Wake(cover[1]);
        return true;
    }
    void AFightStart()
    {
        // The body (core, PartsFlag Independent|SleepStart) is never woken: it takes its HP only through the MasterBody
        // covers (4 x 100000 = 400000), forwarded in AFight [I: base MasterBody rule].
        Target.invulnerable=true;Target.lockOn=false;
        for(int i=0;i<4;i++)coverLast[i]=cover[i]!=null&&cover[i].target!=null?cover[i].target.health:0;
        ASetState(AS.PT2);
    }
    void ASetState(AS s){aState=s;aMode=0;} // SetState 0x1dab240

    void AFight(float dt)
    {
        ForwardCoverDamage();
        if(State!=EncounterState.Fighting)return;
        for(int i=0;i<6;i++)ArmStep(arm[i],dt);
        switch(aState)
        {
            case AS.EntryWait:ASetState(AS.PT2);break;
            case AS.PT2:APT2(dt);break;
            case AS.Turn:ATurn(dt);break;
        }
    }
    // MasterBody covers: their damage is the body's damage. Base StageBoss treats rowed parts as separate targets, so the
    // drop in cover HP is applied to the body here (local workaround).
    void ForwardCoverDamage()
    {
        float total=0;
        for(int i=0;i<4;i++)
        {
            var c=cover[i];if(c==null||c.target==null)continue;
            float h=c.broken?0:Mathf.Max(0,c.target.health);
            if(coverLast[i]>h)total+=coverLast[i]-h;coverLast[i]=h;
        }
        if(total<=0||Target==null||!Target.active)return;
        Target.invulnerable=false;combat.Damage(Target,total);
        if(Target!=null&&Target.active)Target.invulnerable=true;
    }

    // CheckNextState (0x1da8200): EntryWait->PT2; PT2: front covers 01+03 broken (not reversed) -> Turn; Turn -> PT2.
    void ACheckNext()
    {
        if(aState==AS.PT2&&!reversed&&Broken(cover[0])&&Broken(cover[1]))ASetState(AS.Turn);else ASetState(AS.PT2);
    }
    int[][] Seq=>reversed?BackSeq:FrontSeq; // get_CurrentArmAttackSequence 0x1dacd70
    bool ArmAlive(int i)=>i>=0&&i<6&&arm[i]!=null&&!Broken(arm[i].part);
    bool AnyAttackableArm(){foreach(var e in Seq)foreach(var i in e)if(ArmAlive(i))return true;return false;} // 0x1da8df0
    bool ArmRunning(){foreach(var a in arm)if(a!=null&&a.active)return true;return false;}              // 0x1da95b0
    // AdvanceArmPatternIndex (0x1da8010): 0..6, then the last entry for good.
    void Advance()
    {
        var s=Seq;if(s.Length==0){armIndex=0;armLooped=true;return;}
        if(armLooped){armIndex=s.Length-1;return;}
        armIndex++;if(armIndex>=s.Length-1){armLooped=true;armIndex=s.Length-1;}
    }
    // TryStartArmPattern (0x1dab9c0): every unbroken arm of the current entry starts ExecuteRoutineAsync.
    bool TryStartArmPattern()
    {
        var s=Seq;if(s.Length==0)return false;
        bool started=false;
        foreach(var i in s[Mathf.Clamp(armIndex,0,s.Length-1)])if(ArmAlive(i)){ArmStart(arm[i]);started=true;}
        return started;
    }
    bool SideHasCover(){int a=reversed?2:0;return !Broken(cover[a])||!Broken(cover[a+1]);} // IsAnyCoverAvailable

    // PatternMove2 (0x1da9e70)
    void APT2(float dt)
    {
        if(aMode==0)
        {
            if(!SideHasCover()){ACheckNext();return;}
            bool started=false;
            if(AnyAttackableArm())
                for(int n=0;n<Seq.Length;n++)
                {
                    if(TryStartArmPattern()){started=true;break;}
                    int prev=armIndex;Advance();if(armLooped&&armIndex==prev)break;
                }
            if(started){aMode=10;return;}
            aTimer=Mathf.Max(0,ArmCooldown);aMode=20; // falls into mode 20 the same frame
        }
        else if(aMode==10)
        {
            if(ArmRunning())return;
            aTimer=Mathf.Max(0,ArmCooldown);coverShotTimer=0;aMode=20;return;
        }
        if(aMode==20)
        {
            aTimer-=dt;
            if(aTimer<=0){Advance();aMode=0;return;}
            coverShotTimer-=dt;
            if(coverShotTimer<=0){FireCoverShotBurst();coverShotTimer+=Mathf.Max(.1f,(reversed?BackCoverInterval:FrontCoverInterval)*Scale);} // GetCoverShotIntervalSeconds 0x1da8a30
        }
    }
    bool CoverMuzzleAvailable(int m)=>coverMuzzle[m]&&!Broken(cover[m/2]); // TryGetAvailableMuzzle 0x1dab810
    // FireCoverShotBurst (0x1da85a0): front = both muzzles of each live front cover; back = the next group with a live muzzle.
    void FireCoverShotBurst()
    {
        if(!reversed)
        {
            for(int c=0;c<2;c++)if(!Broken(cover[c]))for(int k=0;k<2;k++)if(CoverMuzzleAvailable(c*2+k))Fire(CoverBT,coverMuzzle[c*2+k]);
            return;
        }
        for(int n=0;n<BackCoverGroups.Length;n++)
        {
            int g=(backCoverIndex+n)%BackCoverGroups.Length;bool any=false;
            foreach(var m in BackCoverGroups[g])if(CoverMuzzleAvailable(m))any=true;
            if(!any)continue;
            foreach(var m in BackCoverGroups[g])if(CoverMuzzleAvailable(m))Fire(CoverBT,coverMuzzle[m]);
            backCoverIndex=(g+1)%BackCoverGroups.Length;return;
        }
        backCoverIndex=0;
    }

    // BossArm.ExecuteRoutineAsync MoveNext (0x1db7920): wind-up 2 s, 0.01 s, Wakeup, 12 s of bos08arm0 every 0.16 s with
    // a sweeping offset, ToSleep, standby crossfade, 1 s. Any await aborts when the arm is broken.
    void ArmStart(Arm a)
    {
        if(a==null||Broken(a.part))return;
        a.active=true;a.stage=0;a.timer=ArmAttackAnimationWait;
        Cross(a.anim,"bs08_arm_attack",ArmAttackAnimationWait);
    }
    void ArmStep(Arm a,float dt)
    {
        if(a==null||!a.active)return;
        if(Broken(a.part)){a.active=false;return;}
        a.timer-=dt;
        if(a.stage==0){if(a.timer<=0){a.stage=1;a.timer+=ArmFirstShotDelay;}}
        if(a.stage==1){if(a.timer<=0){Wake(a.part);a.stage=2;a.elapsed=Mathf.Min(ArmFirstShotDelay,ArmAttackDuration);a.timer=0;}else return;}
        if(a.stage==2)
        {
            while(a.timer<=0&&a.stage==2)
            {
                // angle = sign*amp*(1-cos(2pi*frac(elapsed*freq)))/2
                float ph=a.elapsed*ArmRotationFrequency;ph-=Mathf.Floor(ph);
                float angle=a.sign*ArmRotationAmplitude*(1-Mathf.Cos(2*Mathf.PI*ph))*.5f;
                if(a.muzzle)Fire(ArmBT,a.muzzle,angle);
                float w=Mathf.Min(ArmShotInterval,ArmAttackDuration-a.elapsed);
                if(w<=0){a.stage=3;a.timer=ArmAttackAnimationWait*.5f;Sleep(a.part);Cross(a.anim,"bs08_arm_standby",ArmAttackAnimationWait);break;}
                a.elapsed+=w;a.timer+=w;
            }
            return;
        }
        if(a.stage==3&&a.timer<=0)a.active=false;
    }
    void ResetArmStatus(){foreach(var a in arm)if(a!=null)a.active=false;armIndex=0;armLooped=false;backCoverIndex=0;} // 0x1dab1d0

    // PatternMoveTurn (0x1daad40): shake, 2 s, 4 s InOutSine yaw 180 of _modelTop, reversed, back covers wake.
    void ATurn(float dt)
    {
        if(aMode==0){aTimer=2;aMode=1;return;}
        if(aMode==1){aTimer-=dt;if(aTimer<=0){turnTime=0;S("bg8_boss01_turning1_01");aMode=10;}return;}
        if(aMode==10)
        {
            turnTime+=dt;float r=Mathf.Clamp01(turnTime/4);r=.5f-.5f*Mathf.Cos(Mathf.PI*r); // EasingUtility.InOutSine01
            if(modelTop)modelTop.localRotation=Quaternion.Euler(0,180*r,0);
            if(r>=1)aMode=11;
            return;
        }
        if(aMode==11)
        {
            S("bg8_boss01_app_cry2_01");reversed=true;Wake(cover[2]);Wake(cover[3]);ResetArmStatus();
            armIndex=Mathf.Max(0,BackSeq.Length-1);ACheckNext();
        }
    }

    // OnPartsBreak (0x1da9780)
    bool APartBroken(Part part)
    {
        int ai=-1;for(int i=0;i<6;i++)if(arm[i]!=null&&arm[i].part==part)ai=i;
        if(ai>=0)
        {
            if(State!=EncounterState.Defeating)
            {
                // Arm1 l, Arm3 r, Arm4 l (r reversed), Arm6 r (l reversed), Arm7 r, Arm9 l (jump table 0x1da9e58)
                bool left=ai==0||ai==5||(ai==2&&!reversed)||(ai==3&&reversed);
                S(left?"bg8_boss01_legbreaks_l_01":"bg8_boss01_legbreaks_r_01");
            }
            arm[ai].active=false;
            // 10 explosions walking up from the tip (GetExplosionTop = bs08_arm_08) at 0.1 s steps: Small x4, Middle x5,
            // Large; when the last starts the arm goes to NoneLayer (hidden) [<OnPartsBreak>b__0 0x1db8d30].
            var t=FindUnder(part.root,"bs08_arm_08")??part.root;
            for(int i=0;i<10&&t;i++)
            {
                pending.Add(new Pending{at=clock+.1f*i,pos=t.position,fx=i<4?Small:i<9?Middle:Large,scale=DepthScale,hide=i==9?part.root:null});
                if(t.parent&&t!=part.root)t=t.parent;
            }
            return true;
        }
        int ci=-1;for(int i=0;i<4;i++)if(cover[i]==part)ci=i;
        if(ci>=0)
        {
            // Counter shot unless the cover's last hit was a bomb [?: the hit kind is not tracked here; always fires].
            if(coverCenter)Fire(CoverBrokenBT,coverCenter,ci==0||ci==3?-45:45);
            S(ci==0||ci==3?"bg8_boss01_damage_cry_l_01":"bg8_boss01_damage_cry_r_01");
            // PartsList BreakEffect pf_eff_explposion05; the broken cover model is hidden [I].
            if(part.root){Fx("pf_eff_explposion05",Middle,part.root.position,DepthScale);if(part.root!=visual.transform)part.root.gameObject.SetActive(false);}
            return true;
        }
        return false;
    }
    Vector3 ASmallBombPosition() // GetSmallBombPosition 0x1da8c80: a random cover muzzle
    {
        var t=coverMuzzle[Random.Range(0,8)];return t?t.position:visual.transform.position;
    }

    // ToDestroid (0x1dab490) + PatternMoveDestruction (0x1daa310)
    void ADefeatStart()
    {
        S("bg8_boss01_dead_cry_01");
        foreach(var a in arm)if(a!=null)a.active=false;
        foreach(var c in cover)if(!Broken(c))BreakPart(c);
    }
    void ADefeat(float dt)
    {
        float s=DepthScale;
        switch(dmode)
        {
            case 0:
                Fx(Middle,null,ASmallBombPosition(),s);
                for(int i=0;i<6;i++)if(arm[i]!=null&&!Broken(arm[i].part))BreakPart(arm[i].part); // OnPartsBreak(4..9), no sound
                dtimer=1;dmode=1;break;
            case 1:
                dtimer-=dt;if(dtimer>0)break;
                dtimer=2.5f;for(int i=0;i<4;i++)Fx(Middle,null,ASmallBombPosition(),s);
                SetSmallBomb(.2f);dmode=10;break;
            case 10:
                if(SmallBomb(dt)){Fx(Small,null,ASmallBombPosition(),s);S("exp_st3_boss_a01");}
                dtimer-=dt;if(dtimer>0)break;
                DeadEffect("pf_eff_explposion_bos2","exp_st3_boss_b02",s);dtimer=2;dmode=11;break;
            case 11:
                if(SmallBomb(dt)){Fx(Middle,null,ASmallBombPosition(),s);S("exp_st3_boss_a01");}
                dtimer-=dt;if(dtimer<=0)dmode=30;break;
            case 30:
                // Actor != Ash: SetAreaBreak, the core escapes (anc_bs08_top_escape), the body is gone.
                S("exp_st3_boss_c03");PlayAnim(coreAnime,"anc_bs08_top_escape");
                if(bodyTop)bodyTop.gameObject.SetActive(false);
                dtime=0;dmode=31;break;
            case 31:
                float before=dtime;dtime+=dt;
                if(before<.5f&&dtime>=.5f)S("boss8a_escape_01");
                if(before<2.77f&&dtime>=2.77f)S("boss8a_camera_out_01");
                if(before<5&&dtime>=5&&modelTop)modelTop.gameObject.SetActive(false);
                if(before<5.7f&&dtime>=5.7f)S("boss8b_hovering_01");
                break;
        }
    }
    // _callDeadEffect: the prefab _deadExplosion (missing effects fall back to pf_eff_explposion_boss [I]).
    void DeadEffect(string fx,string sound,float scale)
    {
        Fx(fx,"pf_eff_explposion_boss",visual.transform.position,1.5f*scale);S(sound);
    }

    // ================================================================ Ene_Bos08B
    enum BS { Entry12, PT1, PT2, BowWave, BowCircle } // Boss08State (EntryWait is Entrance, Destruction is Defeat)
    // Ene_Bos08B..cctor (0x1db30e0)
    static readonly Vector3 Home=new Vector3(0,0,30),BossCPosition=new Vector3(0,-200,0),BossCOffset=new Vector3(0,0,-30);
    const float EntryNoHitTime=3.5f,InfinityWidth=60,InfinityHeight=10,OneRound=12;const int Pattern1Loops=1;
    const float DashMaxSpeed=150,DashAccel=.5f,DashDecel=.2f,DashBrake=15,DashArrival=.1f,ReturnDuration=2;
    static readonly Vector3[] Bezier={new Vector3(-5,0,0),new Vector3(-30,0,-30),new Vector3(-75,0,60),new Vector3(-100,0,30)};
    static readonly Vector3 LeftBow=new Vector3(-20,0,0),RightBow=new Vector3(20,0,0),CircleCenter=new Vector3(0,0,-4.5f);
    const float WaveSpawnInterval=.05f,WaveInner=-20,WaveOuter=30,WaveFireDelay=2,BowFadeIn=1; // InGameBulletBow._FadeInTimeDefault
    const float CircleArc=6,CircleRadius=30,CircleFireInterval=.5f;const int CircleFireCount=10;
    const float HoverAmplitude=5;
    static readonly float[] WingYaw={0,-60,-120,180,120,60}; // WingBaseRotations
    const string BowBT="bos08b_bow",Pat1A="bos08b_00";

    readonly Transform[] wing=new Transform[6];readonly Quaternion[] wingBase=new Quaternion[6];
    readonly List<Transform> wingMuzzles=new List<Transform>();
    Part wingsPart;GameObject hologram;ParticleSystem hologramPs;Animator topAnim;
    BS bState;int bMode,eMode,loopCount,dashStage;
    float stateTimer,modeTimer,loopTime,wingRatio,hoverTimer,hoverRate,dashElapsed,dashSpeed,dashDecelFrom,repeatTimer,returnElapsed,entryDir;
    bool legsOpened,magicCircle,legCloseSeq,legOpenSeq,hoverEnable,hoverAlign,nextBowIsWave,entryCollision,entrySe;
    Quaternion wingRotation=Quaternion.identity;
    Vector3 dashTarget,returnStart,entryStart,lastBPosition=Home;
    struct Bow {public Vector3 offset;public float angle,launchAt;public bool fired,circle;}
    readonly List<Bow> bows=new List<Bow>(128);readonly List<int> bowPick=new List<int>(64);

    // Initialize (0x1dae0c0) + ReStart (0x1db0870) + GetStart (0x1dadf10: OffCollision, wings ToSleep)
    void BSpawn()
    {
        position=Home;facing=Quaternion.identity;wingRotation=Quaternion.identity;
        var sky=Find("pf_bs08_top_sky");topAnim=sky?sky.GetComponent<Animator>():null;
        // _wingTransforms: six pf_bs08_top_wing children, matched to WingBaseRotations by their rest rotation.
        var all=new List<Transform>();
        if(sky)foreach(Transform c in sky)if(c.name=="pf_bs08_top_wing")all.Add(c);
        for(int i=0;i<6;i++)
        {
            wingBase[i]=Quaternion.Euler(0,WingYaw[i],0);Transform best=null;float bestAngle=999;
            foreach(var c in all){float a=Quaternion.Angle(c.localRotation,wingBase[i]);if(a<bestAngle){bestAngle=a;best=c;}}
            wing[i]=best;if(best)all.Remove(best);
        }
        wingMuzzles.Clear();foreach(var m in muzzles)if(m.name=="muzzle_wing01")wingMuzzles.Add(m); // muzzle pack "wings"
        var holo=Find("pf_eff_hologram01");hologram=holo?holo.gameObject:null;hologramPs=holo?holo.GetComponent<ParticleSystem>():null;
        wingsPart=GetPart("wings");Sleep(wingsPart);
        wingRatio=0;ApplyWingOpening(0);legsOpened=magicCircle=legCloseSeq=legOpenSeq=false;MagicCircle(false,false);
        hoverEnable=hoverAlign=false;hoverTimer=hoverRate=0;nextBowIsWave=true;entryCollision=entrySe=false;
        eMode=0;stateTimer=modeTimer=0;
        defeatDuration=2+4; // PatternDestruction: 2 s, then the 4 s sink
    }
    // PatternEntryWait (0x1dafb70)
    bool BEntrance(float dt)
    {
        switch(eMode)
        {
            case 0:
                PlayAnim(topAnim,"anc_bs08_top_sky_start");stateTimer=5;modeTimer=0; // clip length (5 s) [I]
                S("bg8_boss02_app_01");eMode=1;return false;
            case 1:
                modeTimer+=dt;
                if(!entryCollision&&modeTimer>=EntryNoHitTime){entryCollision=true;Target.touchesWhileInvulnerable=true;} // collision on, still OffLockon|NoDamaged
                stateTimer-=dt;
                if(!entrySe&&stateTimer<=.5f){entrySe=true;S("bg8_boss02_app_stop_01");}
                if(stateTimer<=0&&entryCollision&&entrySe)eMode=10;
                return false;
            case 10:
                stateTimer-=dt;
                if(stateTimer<=-.5f){facing=wingRotation=Quaternion.identity;entryStart=position;entryDir=0;eMode=11;}
                return false;
            default:
                entryDir+=dt;float r=Mathf.Clamp01(entryDir/3);
                position=Vector3.Lerp(entryStart,Home,Mathf.Clamp01(3*r));
                Spin(r*dt);
                if(r>=.5f){if(!legsOpened){S("bg8_boss02_leg_spreading_01");legsOpened=true;}ApplyWingOpening((r-.5f)*2);}
                if(r<1)return false;
                wingRatio=1;Wake(wingsPart);MagicCircle(true,true);
                bState=BS.Entry12;stateTimer=.25f;
                return true; // ResetObjectFlag(OffLockon|NoDamaged) + ResetBossTimer
        }
    }

    void BFight(float dt)
    {
        switch(bState)
        {
            case BS.Entry12:Spin(dt);stateTimer-=dt;if(stateTimer<=0)BCheckNext();break;
            case BS.PT1:BPT1(dt);break;
            case BS.PT2:BPT2(dt);break;
            case BS.BowWave:BBowWave(dt);break;
            case BS.BowCircle:BBowCircle(dt);break;
        }
        LaunchBows();
    }
    // CheckNextState (0x1dad510): Entry->PT1->PT2->BowWave/BowCircle (alternating)->PT1
    void BCheckNext()
    {
        switch(bState)
        {
            case BS.PT1:bState=BS.PT2;break;
            case BS.PT2:bState=nextBowIsWave?BS.BowWave:BS.BowCircle;break;
            case BS.BowWave:nextBowIsWave=false;bState=BS.PT1;break;
            case BS.BowCircle:nextBowIsWave=true;bState=BS.PT1;break;
            default:bState=BS.PT1;break;
        }
        bMode=0;
    }

    // UpdateWingRotation (0x1db2f00): the whole top spins 180 deg/s about the camera axis.
    void Spin(float dt){wingRotation=wingRotation*Quaternion.Euler(0,180*dt,0);facing=wingRotation;}
    // ApplyWingOpening (0x1dad0b0): staggered by 0.12, each over 0.2 of the ratio, OutSine, -90 about x.
    void ApplyWingOpening(float ratio)
    {
        for(int i=0;i<6;i++)
        {
            float t=Mathf.Clamp01((ratio-.12f*i)/.2f);float e=Mathf.Sin(t*Mathf.PI*.5f); // OutSine01
            if(wing[i])wing[i].localRotation=wingBase[i]*Quaternion.Euler(e*-90,0,0);
        }
    }
    void MagicCircle(bool on,bool sound) // SetMagicCircleActive (0x1db1360)
    {
        if(on&&!magicCircle){if(hologram)hologram.SetActive(true);if(hologramPs)hologramPs.Play();magicCircle=true;}
        else if(!on&&magicCircle){if(hologramPs)hologramPs.Stop(true);magicCircle=false;}
        else if(!on&&hologram&&!magicCircle)hologram.SetActive(false);
        if(on&&sound)S("bg8_boss02_magic_circle_01");
    }
    // OpenWings (0x1dae7a0): true once open.
    bool OpenWings(float dt)
    {
        if(legsOpened)return true;
        if(wingRatio<=0){S("bg8_boss02_leg_spreading_02");Wake(wingsPart);legOpenSeq=true;}
        wingRatio=Mathf.Clamp01(wingRatio+dt);
        if(wingRatio>=.3f&&legOpenSeq){MagicCircle(true,true);legOpenSeq=false;}
        ApplyWingOpening(wingRatio);
        if(wingRatio<1)return false;
        legsOpened=true;return true;
    }
    // CloseWings (0x1dad710; inlined in PatternBowCircle): true once closed.
    bool CloseWings(float dt)
    {
        if(!legsOpened)return true;
        if(wingRatio>=1){Sleep(wingsPart);legCloseSeq=true;}
        wingRatio=Mathf.Clamp01(wingRatio-dt);
        if(wingRatio<=.7f&&legCloseSeq){MagicCircle(false,false);S("bg8_boss02_leg_closing_01");legCloseSeq=false;}
        ApplyWingOpening(wingRatio);
        if(wingRatio>0)return false;
        legsOpened=false;return true;
    }
    // ApplyHover (0x1dacf00): 5-unit sine on z at 0.5 Hz, faded in/out over 1 s; snaps to Home when it stops.
    void ApplyHover(float dt)
    {
        if(hoverEnable){hoverRate=Mathf.Clamp01(hoverRate+dt);hoverAlign=true;}else hoverRate=Mathf.Clamp01(hoverRate-dt);
        if(hoverRate<=0){if(hoverAlign){position=Home;hoverTimer=0;hoverAlign=false;}return;}
        position=new Vector3(Home.x,Home.y,Home.z+Mathf.Sin(hoverTimer*Mathf.PI)*HoverAmplitude*hoverRate);
        hoverTimer=Mathf.Repeat(hoverTimer+dt*hoverRate,2);
    }
    bool HoverStopped=>!hoverEnable&&!hoverAlign; // IsHoverStopped 0x1dae540
    // ResetHover (0x1db0f30): the hover phase whose sine matches the current z (no jump).
    void ResetHover()
    {
        float a=Mathf.Asin(Mathf.Clamp((position.z-Home.z)/HoverAmplitude,-1,1));
        float t1=Mathf.Repeat(a/Mathf.PI,2),t2=Mathf.Repeat((Mathf.PI-a)/Mathf.PI,2);
        float d1=Mathf.Abs(t1-hoverTimer);d1=Mathf.Min(d1,2-d1);float d2=Mathf.Abs(t2-hoverTimer);d2=Mathf.Min(d2,2-d2);
        float t=t1,d=d1;if(d1>d2){t=t2;d=d2;}
        if(d>=1f/120)hoverTimer=t;
    }
    // PT1/PT2 mode 0: wings open, hover off and settled.
    bool OpenAndSettle(float dt)
    {
        bool open=legsOpened||OpenWings(dt);hoverEnable=false;
        return open&&!hoverAlign;
    }

    // PatternPhaseOne (0x1db00b0): one 12 s figure-eight (InfinitySymbol 60 x 10), the 6 wing muzzles fire bos08b_00
    // every 3 s x scale (SetRepeatTime / _repeatLaped).
    void BPT1(float dt)
    {
        if(bMode==0)
        {
            if(OpenAndSettle(dt)){repeatTimer=3*Scale;S("bg8_boss02_flying_01");loopTime=0;loopCount=0;bMode=10;}
        }
        else
        {
            repeatTimer-=dt;
            if(repeatTimer<=0){repeatTimer+=3*Scale;foreach(var m in wingMuzzles)Fire(Pat1A,m);}
            loopTime+=dt;
            if(loopTime>=OneRound)
            {
                loopCount++;
                if(loopCount<Pattern1Loops){loopTime-=OneRound;S("bg8_boss02_flying_01");}
                else{loopTime=0;BCheckNext();}
            }
            if(bState==BS.PT1)
            {
                float t=Mathf.Clamp01(loopTime/OneRound);t=.5f-.5f*Mathf.Cos(Mathf.PI*t); // InOutSine01
                float a=(t*360+90)*Mathf.Deg2Rad;                                         // VectorUtility.InfinitySymbol 0x1df7690
                float x=Mathf.Cos(a)*InfinityWidth,z=Mathf.Sin(2*a)*InfinityHeight;
                if((loopCount&1)==0)x=-x;
                position=Home+new Vector3(x,0,z);
            }
        }
        ApplyHover(dt);Spin(dt);
    }
    // PatternPhaseTwo (0x1db0470): 1 s, dash at the nearest player (ExecutePhaseTwoMovement 0x1dad890), 1 s, return 2 s.
    void BPT2(float dt)
    {
        switch(bMode)
        {
            case 0:if(OpenAndSettle(dt)){stateTimer=1;bMode=10;}break;
            case 10:
                stateTimer-=dt;if(stateTimer>0)break;
                dashTarget=PlayerSource;dashTarget.y=0;dashStage=0;dashElapsed=0;dashSpeed=0;dashDecelFrom=DashMaxSpeed;bMode=11;break;
            case 11:if(Dash(dt)){stateTimer=1;bMode=12;}break;
            case 12:stateTimer-=dt;if(stateTimer<=0){returnElapsed=0;returnStart=position;bMode=13;}break;
            case 13:
                returnElapsed+=dt;float u=Mathf.Clamp01(returnElapsed/ReturnDuration);
                position=Vector3.Lerp(returnStart,Home,.5f-.5f*Mathf.Cos(Mathf.PI*u)); // ReturnToHomePosition 0x1db1150
                if(u>=1){position=Home;BCheckNext();}
                break;
        }
        ApplyHover(dt);Spin(dt);
    }
    bool Dash(float dt)
    {
        if(Vector3.Distance(position,dashTarget)<=DashArrival||dashStage>=3){dashStage=3;position=dashTarget;return true;}
        if(dashStage==0)
        {
            dashElapsed+=dt;float t=Mathf.Clamp01(dashElapsed/DashAccel);dashSpeed=DashMaxSpeed*t;
            position=Vector3.MoveTowards(position,dashTarget,dashSpeed*dt);
            if(t>=1){dashStage=1;dashElapsed=0;dashSpeed=DashMaxSpeed;}
        }
        else if(dashStage==1){dashSpeed=DashMaxSpeed;position=Vector3.MoveTowards(position,dashTarget,dashSpeed*dt);}
        else
        {
            dashElapsed+=dt;float t=Mathf.Clamp01(dashElapsed/DashDecel);dashSpeed=dashDecelFrom*(1-t);
            position=Vector3.MoveTowards(position,dashTarget,dashSpeed*dt);
            if(t>=1){dashStage=3;position=dashTarget;return true;}
        }
        float d=Vector3.Distance(position,dashTarget);
        if(dashStage<=1&&d<=DashBrake){dashStage=2;dashElapsed=0;dashDecelFrom=Mathf.Max(dashSpeed,0);}
        if(d<=DashArrival){dashStage=3;position=dashTarget;return true;}
        return false;
    }

    // SpawnBowBullets (0x1db14d0): a bos08b_bow at the boss + offset with its own direction; it rides with the boss
    // (UpdateBowFollowerPositions) and flies when fired. [I] The held bullet itself is not drawn or dangerous before it
    // flies here (the base fires bullets only from muzzles); the startArc is used as an absolute direction [?].
    void SpawnBow(Vector3 offset,float angle,bool circle,float launchAt)
    {bows.Add(new Bow{offset=offset,angle=angle,circle=circle,launchAt=launchAt});}
    void LaunchBows()
    {
        for(int i=0;i<bows.Count;i++)
        {
            var b=bows[i];if(b.fired||clock<b.launchAt)continue;
            b.fired=true;bows[i]=b;FireAt(BowBT,position+b.offset,b.angle,true);
        }
    }
    void ClearBows(){bows.Clear();}

    // PatternBowWave (0x1daef00) + SpawnWingBowSequence (0x1db1ff0)
    void BBowWave(float dt)
    {
        switch(bMode)
        {
            case 0:if(legsOpened||OpenWings(dt)){MagicCircle(true,true);stateTimer=.2f;bMode=10;}break;
            case 10:stateTimer-=dt;if(stateTimer<=0){ResetHover();hoverEnable=true;stateTimer=modeTimer=0;bMode=11;}break;
            case 11:if(SpawnWave(dt)){stateTimer+=BowFadeIn;bMode=12;}break;
            case 12:stateTimer+=WaveFireDelay;bMode=13;break;
            case 13:stateTimer-=dt;if(stateTimer<=0){ClearBows();BCheckNext();}break;
        }
        ApplyHover(dt);Spin(dt);
    }
    // One mirrored pair every 0.05 s along the cubic Bezier as modeTimer runs 0 -> 1; each bullet flies 1 s (fade) + 2 s
    // (Fire(2.0)) after it spawns. True when the last pair (t = 1) is out.
    bool SpawnWave(float dt)
    {
        stateTimer+=dt;float acc=stateTimer-modeTimer,lastT=0;
        while(acc>=WaveSpawnInterval&&lastT<1)
        {
            float t=Mathf.Clamp01(modeTimer);lastT=t;
            float u=1-t;var p=u*u*u*Bezier[0]+3*u*u*t*Bezier[1]+3*u*t*t*Bezier[2]+t*t*t*Bezier[3]; // VectorUtility.CubicBeizer
            float ang=WaveInner+t*(WaveOuter-WaveInner);
            float launch=clock+BowFadeIn+WaveFireDelay;
            SpawnBow(p+LeftBow,-90-ang,false,launch);
            SpawnBow(new Vector3(-p.x,p.y,p.z)+RightBow,ang-90,false,launch);
            modeTimer+=WaveSpawnInterval;acc-=WaveSpawnInterval;
        }
        return lastT>=1;
    }
    // PatternBowCircle (0x1dae930): close the wings, 60 bows on a 30-unit ring, after 2 s fire 10 at random every 0.5 s.
    void BBowCircle(float dt)
    {
        switch(bMode)
        {
            case 0:if(CloseWings(dt)){MagicCircle(true,true);stateTimer=.2f;bMode=10;}break;
            case 10:stateTimer-=dt;if(stateTimer<=0){ResetHover();hoverEnable=true;stateTimer=modeTimer=0;bMode=11;}break;
            case 11:
                for(float arc=0;arc>-360;arc-=CircleArc)
                {
                    float a=arc-90,r=a*Mathf.Deg2Rad;
                    SpawnBow(new Vector3(Mathf.Cos(r)*CircleRadius+CircleCenter.x,0,Mathf.Sin(r)*CircleRadius+CircleCenter.z),a,true,float.MaxValue);
                }
                stateTimer=2;bMode=12;break;
            case 12:
                stateTimer-=dt;if(stateTimer>0)break;
                if(TriggerBows(CircleFireCount)){ClearBows();BCheckNext();}else stateTimer+=CircleFireInterval;
                break;
        }
        ApplyHover(dt);Spin(dt);
    }
    // TriggerBowBullet (0x1db18b0): n random held ring bullets fire; true when none is left.
    bool TriggerBows(int n)
    {
        bowPick.Clear();for(int i=0;i<bows.Count;i++)if(bows[i].circle&&!bows[i].fired&&bows[i].launchAt>=float.MaxValue)bowPick.Add(i);
        for(int k=0;k<n&&bowPick.Count>0;k++)
        {
            int j=Random.Range(0,bowPick.Count);var b=bows[bowPick[j]];b.launchAt=clock;bows[bowPick[j]]=b;bowPick.RemoveAt(j);
        }
        return bowPick.Count==0;
    }

    // ToDestroid (0x1db1790: bow bullets and enemy bullets cleared) + PatternDestruction (0x1daf150)
    void BDefeatStart()
    {
        ClearBows();MagicCircle(false,false);
        dFrom=facing;dTo=facing*Quaternion.Euler(0,180,0);
        Fx(Middle,null,BSmallBombPosition());SetSmallBomb(.2f);dtimer=2;dmode=10;
    }
    Vector3 BSmallBombPosition(){return wingMuzzles.Count>0&&wingMuzzles[0]?wingMuzzles[Random.Range(0,wingMuzzles.Count)].position:visual.transform.position;} // 0x1dade40
    void BDefeat(float dt)
    {
        facing=Quaternion.Slerp(dFrom,dTo,Mathf.Clamp01(StateAge/5.5f)); // CurrentTargetAngle over SetDirectionTime(5.5)
        if(dmode==10)
        {
            if(SmallBomb(dt))Fx(Small,null,BSmallBombPosition());
            dtimer-=dt;if(dtimer<=0){dtime=0;dSinkFrom=sinkDepth;dmode=11;}
            return;
        }
        // Sink: target = pos + 2*Boss3CPosition = 400 away from the camera, EaseIn over 4 s; the dead effect when 200 down.
        dtime+=dt;float u=Mathf.Clamp01(dtime*.25f);sinkDepth=dSinkFrom+(-2*BossCPosition.y)*u*u;
        if(SmallBomb(dt)){Fx(Middle,null,BSmallBombPosition(),DepthScale);S("exp_st3_boss_a01");}
        if(dmode==11&&sinkDepth-dSinkFrom>-BossCPosition.y)
        {
            Fx("pf_eff_explposion06","pf_eff_explposion04",visual.transform.position,1.5f*DepthScale);S("ene_x3_exp_01"); // ShouldCreateBossC: explposion06 + se 173
            dmode=12;
        }
        if(dtime>=4&&!dsound){dsound=true;S("exp_st3_boss_c03");lastBPosition=new Vector3(position.x,0,position.z);} // CallEnemyClip(ene_boss08c) next
    }

    // ================================================================ Ene_Bos08C
    // Ene_Bos08C..cctor (0x1db7300)
    static readonly Vector3 CHome=new Vector3(0,0,50);
    static readonly Quaternion CStartRotate=Quaternion.Euler(90,0,180);
    static readonly float[] ArcAngles={-100,-80,100,80};
    static readonly string[] SideMuzzles={"muzzle_side30","muzzle_side90","muzzle_side10","muzzle_side70"}; // muzzle pack "side"
    const string LaserBT="bos08c_00",SideBT="bos08c_01",CBowBT="bos08c_03";
    const float CBattleTime=15,MoveAmplitude=60,MoveCycle=12,MoveEase=1.2f,MaxYawSpeed=90;
    const float LaserIdleNormal=3,LaserIdleHard=.5f,LaserOn=3.5f,HomingDelay=1,HomingHardInterval=1.5f;
    const float EightWayInterval=.5f,EightWayMin=.1f,EightWayBurst=3,BowOffset=20,BowFollow=2;const int BowDirections=8;

    Transform cFront,cFrontEdge,cBack,cBackEdge;readonly Transform[] side=new Transform[4];
    int cMode;float phase,easeTimer,yaw,homingTimer,laserTimer,eightTimer,eightInterval,burstRemain,cEntryTime;
    bool pendingHoming,nextHoming,burstActive,laserFiring,hard;Vector3 cStart;
    struct CBow {public float angle,launchAt;}
    readonly List<CBow> cBows=new List<CBow>(64);

    // Initialize (0x1db4970) + ReStart (0x1db5f40) + GetStart (0x1d7e4b0: OffCollision)
    void CSpawn()
    {
        cFront=Find("muzzle_front");cFrontEdge=Find("frontEdge");cBack=Find("muzzle_back");cBackEdge=Find("backEdge");
        for(int i=0;i<4;i++)side[i]=Find(SideMuzzles[i]);
        // Spawned by B at its sunken position + (0,0,-30): localPosition y about -400 [I], lerped to (0,0,50) by the entry.
        cStart=position;sinkDepth=-2*BossCPosition.y;facing=CStartRotate;
        cMode=0;cEntryTime=0;hard=false;
        defeatDuration=1+2; // PatternMoveDestruction modes 0..11
    }
    // PatternMoveEntryWait (0x1db54e0): 5 s EaseIn to home turning to identity, then the gauge fades in for 1 s.
    bool CEntrance(float dt)
    {
        if(cMode==0){S("bg8_boss03_app_01");cMode=1;}
        cEntryTime+=dt;
        if(cMode==1)
        {
            float r=Mathf.Clamp01(cEntryTime/5),e=r*r; // EaseIn [I: quadratic]
            position=Vector3.Lerp(cStart,CHome,e);sinkDepth=-2*BossCPosition.y*(1-e);
            facing=Quaternion.Slerp(CStartRotate,Quaternion.identity,r);
            if(r>=1){S("bg8_boss02_app_stop_01");Target.touchesWhileInvulnerable=true;cMode=2;cEntryTime=0;} // collision on, OffLockon|NoDamaged
            return false;
        }
        if(cEntryTime<1)return false;
        CInitPhaseOne();return true; // ResetObjectFlag + ResetBossTimer -> PT1
    }
    // PatternMovePhaseOne mode 0 (= InitializePhaseOnePattern 0x1db4830)
    void CInitPhaseOne()
    {
        pendingHoming=false;nextHoming=true;phase=easeTimer=yaw=homingTimer=laserTimer=eightTimer=0;
        burstActive=false;burstRemain=0;laserFiring=true;eightInterval=Mathf.Max(EightWayMin,Mathf.Max(.2f,Scale)*EightWayInterval);
        FireLasers();
    }
    // TimeupAction (0x1db6320) via ProgressBossTimer when the boss clock passes GetBattileTime (15 s): high difficulty.
    void CTimeup()
    {
        hard=true;homingTimer=0;eightTimer=0;burstActive=false;burstRemain=0;pendingHoming=false;nextHoming=true;eightInterval=EightWayInterval;
    }
    void CFight(float dt)
    {
        if(!hard&&BossTime>=CBattleTime)CTimeup();
        CMove(dt);
        // laser cycle
        float idle=hard?LaserIdleHard:LaserIdleNormal,old=laserTimer;laserTimer+=dt;
        if(!laserFiring)
        {
            if(!hard&&pendingHoming&&old<0&&laserTimer>=0){FireHoming();pendingHoming=false;} // 1 s after the laser (HomingDelay)
            if(laserTimer>=idle){laserFiring=true;laserTimer=0;FireLasers();}
        }
        else if(laserTimer>=LaserOn)
        {
            laserFiring=false;
            if(hard)laserTimer=0;
            else
            {
                if(!nextHoming){burstActive=true;burstRemain=EightWayBurst;eightTimer=0;eightInterval=Mathf.Max(EightWayMin,Scale)*EightWayInterval;laserTimer=0;}
                else{laserTimer=-HomingDelay;pendingHoming=true;}
                nextHoming=!nextHoming;
            }
        }
        if(hard)
        {
            homingTimer+=dt;float hi=Mathf.Max(EightWayMin,Scale)*HomingHardInterval;
            if(homingTimer>=hi){homingTimer-=hi;FireHoming();}
        }
        float interval2=Mathf.Max(EightWayMin,Scale)*EightWayInterval;
        if(hard)
        {
            eightTimer+=dt;if(eightTimer>=interval2){eightTimer-=interval2;FireBowRing();}
        }
        else if(burstActive)
        {
            burstRemain-=dt;eightTimer+=dt;
            while(eightTimer>=eightInterval){eightTimer-=eightInterval;FireBowRing();}
            if(burstRemain<=0){burstActive=false;eightTimer=0;}
        }
        UpdateBowRings();
    }
    // UpdatePhaseOneMovement (0x1db70c0): x = 60 sin(phi) eased in over 1.2 s, yaw rate 90 sin(phi) deg/s.
    void CMove(float dt)
    {
        float w=2*Mathf.PI/MoveCycle,old=phase;
        phase=Mathf.Repeat(phase+w*dt,2*Mathf.PI);easeTimer+=dt;
        float e=Mathf.Sin(Mathf.Clamp01(easeTimer/MoveEase)*Mathf.PI*.5f); // OutSine01
        position=CHome+new Vector3(Mathf.Sin(phase)*MoveAmplitude*e,0,0);
        yaw+=(Mathf.Cos(old)-Mathf.Cos(phase))*(MaxYawSpeed/w)*e;
        facing=Quaternion.Euler(0,yaw,0);
    }
    // FireFrontAndBackLasers (0x1db42c0): bos08c_00 along muzzle_front->frontEdge and muzzle_back->backEdge (they turn
    // with the yaw), beam loop SE.
    void FireLasers()
    {
        Fire(LaserBT,cFront,0,cFrontEdge);Fire(LaserBT,cBack,0,cBackEdge);S("boss8c_beam_loop_01");
    }
    // FireHomingBullets (0x1db44c0): bos08c_01 (selfDir) from the 4 side muzzles with -100/-80/100/80.
    void FireHoming(){for(int i=0;i<4;i++)if(side[i])Fire(SideBT,side[i],ArcAngles[i]);}
    // FireBowBullet (0x1db3a30) + UpdateBowFollowers (0x1db64b0): 8 bows at 45 deg spokes, 20 out, re-aimed at the player
    // for 2 s while they ride with the core, then they fly along their spoke. [I] Drawn and dangerous only from launch.
    void FireBowRing()
    {
        for(int i=0;i<BowDirections;i++)cBows.Add(new CBow{angle=i*360f/BowDirections,launchAt=clock+BowFollow});
    }
    void UpdateBowRings()
    {
        for(int i=cBows.Count-1;i>=0;i--)
        {
            var b=cBows[i];if(clock<b.launchAt)continue;
            var dir=PlayerSource-position;dir.y=0;dir=dir.sqrMagnitude>1e-10f?dir.normalized:Vector3.back; // [I] fallback: down the screen
            var d=Quaternion.AngleAxis(b.angle,Vector3.up)*dir;
            FireAt(CBowBT,position+d*BowOffset,Mathf.Atan2(d.z,d.x)*Mathf.Rad2Deg,false);
            cBows.RemoveAt(i);
        }
    }

    // ToDestroid (0x1db6370) + PatternMoveDestruction (0x1db4d10)
    void CDefeatStart()
    {
        cBows.Clear();CancelLasers(); // _laserCancelFlag
        dFrom=facing;dTo=facing*Quaternion.Euler(0,180,0);
        Fx(Middle,null,visual.transform.position);SetSmallBomb(.2f);dtimer=1;dmode=10;
    }
    void CDefeat(float dt)
    {
        facing=Quaternion.Slerp(dFrom,dTo,Mathf.Clamp01(StateAge/3)); // SetDirectionTime(3)
        if(dmode==10)
        {
            if(SmallBomb(dt))Fx(Small,null,visual.transform.position+Random.insideUnitSphere*10*Unit);
            dtimer-=dt;
            if(dtimer<=0){dSinkFrom=sinkDepth;DeadEffect("pf_eff_explposion_bos2","exp_st3_boss_b02",1);dtime=0;dmode=11;}
            return;
        }
        // 20 away from the camera, EaseOut over 2 s; small bombs Middle se 40.
        dtime+=dt;float u=Mathf.Clamp01(dtime*.5f);sinkDepth=dSinkFrom+20*(1-(1-u)*(1-u));
        if(SmallBomb(dt)){Fx(Middle,null,visual.transform.position+Random.insideUnitSphere*10*Unit,DepthScale);S("exp_st3_boss_a01");}
        if(dtime>=2&&!dsound){dsound=true;S("exp_st3_boss_c03");} // Phase_StageClear
    }
}
