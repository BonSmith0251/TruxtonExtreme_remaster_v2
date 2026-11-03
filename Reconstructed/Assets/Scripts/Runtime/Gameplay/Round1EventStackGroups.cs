using System;
using System.Collections.Generic;
using UnityEngine;

// Class movers that involve more than one enemy, and class programs (evidence/movers/Ene_<Class>/SPEC.md):
// Ene_Mk01's Ene_Si01 swarm, Ene_Mn01h's 13 Ene_Mn01c shield bits, Ene_Mm01's split gate, Ene_Ml01 eating the Ene_Sj01
// school (and the school's escape), Ene_Mc01's fire cycle, and the static event lists Ene_Sq01 / Ene_Mb01 put in place
// of their empty definitions. Checked by ReconstructionClassMoverCheck against the specs' Python models.
public sealed partial class Round1EventStack
{
    // ---- parents and children (RookEnemy._childObjects, KnightEnemy._childEnemies) --------------------------------
    // A child is stepped by its parent right after the parent's own update, so it reads the parent's new position (the
    // queen updates before her children [I]). The host only steps parents; a parent that has ended keeps stepping its
    // children until they end too (the Mn01c bits fly on after their core is gone).
    public Round1EventStack Owner { get; private set; }
    public readonly List<Round1EventStack> Children=new List<Round1EventStack>();
    public readonly List<Round1EventStack> Summoned=new List<Round1EventStack>();   // created by the class; the host gives them targets
    public bool Gone { get; private set; }
    public bool Killed { get; private set; }
    public bool HasLiveChildren=>Children.Exists(c=>!c.Gone && !c.Ended);
    public string Model=>model;
    void StepChildren(){if(Children.Count==0)return;foreach(var c in Children.ToArray())if(!c.Gone && !c.Ended)c.StepSelf();}
    // Steps a parent (and with it its children) to the given frame count.
    public void AdvanceTo(int frames){for(int i=0;frame<frames && i<600;i++){if(Ended && !HasLiveChildren)break;StepSelf();}}
    // The host removed this enemy's target: killed (by the player or a script kill) or culled.
    public void Remove(bool killed)
    {
        if(Gone)return;Gone=true;Killed=killed;End(killed?"killed":"removed");
        if(!killed)return;
        if(model=="Pf_Ene_Mn01")foreach(var c in Children)c.BitSeparate();                   // _callDeadEffect: SendChildEvent(0)
        if(model=="Pf_Ene_Ml01")foreach(var f in mlFood)if(f!=null && !f.Gone && !f.Ended)f.CommonEvent(2); // _callDeadEffect: CommonEvent(2)
    }
    // Ene_Mk01 (RookEnemy, _isChildrenSolidarity 1): the children still alive die with the queen (_SeparationChildren -> AddDead).
    public bool ChildrenDieWithParent=>model=="Pf_Ene_Mk01";
    static Vector3 Norm(Vector3 v){float l=v.magnitude;return l>1e-5f?v/l:Vector3.zero;}
    static bool InRect(Vector3 p,float margin){var v=Viewport(p);return -margin<=v.x && v.x<1+margin && -margin<=v.y && v.y<1+margin;}
    // InGameEnemyManager.EntryEnemy: a placement with attributeFlag 1 becomes the head's child (RookEnemy.SetChildObject).
    // Ene_Si01.ReStart takes its formation slot from where it stands in the queen's frame (the queen at its placement yaw).
    public void Adopt(Round1EventStack c)
    {
        c.Owner=this;Children.Add(c);
        if(c.model=="Pf_Ene_Si01")
        {
            c.siFirst=Norm(Quaternion.Inverse(Quaternion.Euler(0,yaw,0))*(c.pos-pos))*50;   // queen.InverseTransformPoint, * _ParentDistance
            c.siSwayX=c.rng.Range(0,2*Mathf.PI);                                             // UnityEngine.Random.Range(0, 2pi) [I: seeded]
        }
    }

    // ---- Ene_Si01 (Ene_Si01/SPEC.md sec. 6): swirls round its queen toward a slot 50 from her, nose on the player ------
    Vector3 siFirst,siVel;Quaternion siFollow=Quaternion.identity;float siSwayX,siSwayY,siRotT,siRotA,siShot=1;
    const string SiMuzzle="pf_ene_si01/ene_si01/ene_body/ene_hip/muzzle";
    // Ene_Mk01.SetChildTarget(false) at the end of each queen Wait: the heading ramp starts again.
    void SiRetarget(){foreach(var c in Children)if(c.model=="Pf_Ene_Si01")c.siRotT=0;}
    void Si01()
    {
        var q=Owner;
        if(q==null || q.Ended || q.Gone){End("queen-gone");return;}                          // !_queenEnemy.IsAlive(): CallDisabled
        var P=PlayerSky();var Q=q.pos;float b=Mathf.Atan2(P.x-Q.x,P.z-Q.z);
        siSwayY+=DT/3*2*Mathf.PI;siSwayX+=DT/5*2*Mathf.PI;                                  // _SwayTimeY 3, _SwayTimeX 5
        var A=Quaternion.Euler(0,b*Mathf.Rad2Deg+15*Mathf.Cos(siSwayY),0);var B=Quaternion.Euler(30*Mathf.Cos(siSwayX),0,0);
        siFollow=Quaternion.Slerp(siFollow,A*B,Mathf.Min(DT*60*.1f,1));                    // _FollowRate 0.1 per 60 Hz frame
        var d=Q-siFollow*siFirst-pos;
        if(Vector3.Dot(siVel,d)<0)siVel-=Norm(siVel)*100*DT*.8f;                           // brake while moving away
        siVel+=Norm(d)*100*DT;                                                              // _AccelerateSpeed 100
        var e=pos-Q;float r=e.magnitude;
        if(40-r>0)siVel+=Norm(e)*(40-r)*.5f;                                                // _ParentBodySize 40, per-frame impulse
        if(r-60>0)siVel-=Norm(e)*(r-60)*.5f;                                                // _ParentApart 60
        var s=pos+siVel*DT;if((s-Q).magnitude>100)s=Q+Norm(s-Q)*100;                        // _DistanceLimit 100
        float a=Mathf.Atan2(P.x-s.x,P.z-s.z)*Mathf.Rad2Deg;
        siRotT=Mathf.Clamp(siRotT+DT,0,1);float k=Mathf.Clamp01(siRotT);k*=k;               // InQuad01(t / _TargetTurnTime 1)
        float diff=Mathf.Repeat(a-siRotA,360);if(diff>180)diff-=360;
        siRotA+=Mathf.Clamp01(k)*diff;pos=s;yaw=siRotA;
        siShot-=DT;if(siShot<=0){siShot+=1;Shots.Add(new Shot{pattern="si01_fire",muzzle=SiMuzzle});}  // _ShotInterval 1
    }
    // Ene_Mk01._childRepulsion 0x1DC9940 -> Ene_Si01.Repulsion 0x1CFFDD0: pairs closer than _BodySize 20 push apart.
    void SiRepulsion()
    {
        for(int i=0;i<Children.Count;i++)for(int j=i+1;j<Children.Count;j++)
        {
            var a=Children[i];var c=Children[j];
            if(a.Gone || a.Ended || c.Gone || c.Ended || a.model!="Pf_Ene_Si01" || c.model!="Pf_Ene_Si01")continue;
            var v=a.pos-c.pos;float k=20-v.magnitude;if(k<=0)continue;var n=Norm(v);a.siVel+=n*k*.8f;c.siVel-=n*k*.8f;
        }
    }

    // ---- Ene_Mn01h core (Ene_Mn01h/SPEC.md sec. 3): z only, before the base update; AreaL exit -----------------------
    static readonly Vector4[] MnInCurve={new Vector4(0,1,-1.0396208f,-1.0396208f),new Vector4(.50231755f,.5010671f,-1.1646425f,-1.1646425f),new Vector4(1,0,.04044206f,.04044206f)};
    static readonly Vector4[] MnSpinCurve={new Vector4(0,0,0,0),new Vector4(.5020712f,1,-.027776208f,-.027776208f),new Vector4(1,0,0,0)};
    // AnimationCurve.Evaluate, non-weighted Hermite: keys (time, value, inTangent, outTangent), clamped ends.
    static float Curve(Vector4[] k,float t)
    {
        if(t<=k[0].x)return k[0].y;if(t>=k[k.Length-1].x)return k[k.Length-1].y;
        int i=0;while(i<k.Length-2 && t>k[i+1].x)i++;
        float d=k[i+1].x-k[i].x,u=(t-k[i].x)/d,u2=u*u,u3=u2*u;
        return (2*u3-3*u2+1)*k[i].y+(u3-2*u2+u)*k[i].w*d+(-2*u3+3*u2)*k[i+1].y+(u3-u2)*k[i+1].z*d;
    }
    int mnState,mnSummon;float mnStateTime,mnVel,mnAcc,mnSummonTimer,mnSpinTimer,mnFire;bool mnSummonStart,mnSpinFlag,mnSummonEnd;
    Vector3 mnEuler;
    public Vector3 CoreEuler=>mnEuler;                                                        // _modelTop.localEulerAngles (visual)
    const string MnMuzzle="pf_ene_mn01/mn01_body/muzzle01";
    void Mn01h()
    {
        switch(mnState)
        {
            case 0:mnSpinFlag=mnSummonStart=false;mnSummon=0;mnState=1;mnStateTime=0;break;
            case 1:                                                                           // IN: 110 -> 45 along _inCurve in 3 s
                if(mnStateTime>=1 && !mnSummonStart)mnSummonStart=true;
                if(mnStateTime<3)pos.z=45+Curve(MnInCurve,mnStateTime/3)*(110-45);
                else{mnState=2;mnStateTime=0;pos.z=45;mnVel=0;mnSummonStart=true;}
                break;
            case 2:                                                                           // SLOW: drift down at up to 2 u/s
                if(mnStateTime<10 && !mnSummonEnd){mnAcc=-2;mnVel=Mathf.Max(mnVel-2*DT,-2);pos.z+=mnVel*DT;}
                else{mnAcc=-32;mnState=3;mnStateTime=0;}
                break;
            case 3:mnVel+=mnAcc*DT;pos.z+=mnVel*DT;break;                                     // OUT: falls at 32 u/s^2
        }
        if(mnSummonStart)
        {
            mnSummonTimer+=DT;
            if(mnSummon==0){MnCreateChildren();mnSummon=1;mnSummonTimer=0;}
            else if(mnSummon==1 && mnSummonTimer>=4.5f)
            {   // SendChildEvent(2): each bit separates 1 s later; _fire: DelaySecond(_shotWait 1), one mn01_fire1
                mnSpinFlag=true;mnSpinTimer=0;foreach(var c in Children)if(!c.Gone && !c.Ended)c.bitSepaTimer=1;
                mnFire=1;mnSummon=3;mnSummonTimer=0;
            }
            else if(mnSummon==3 && mnSummonTimer>=2){mnSummonEnd=true;mnSummon=4;mnSummonTimer=0;}
        }
        float s=32;                                                                           // _spinSpeed, + the spin burst
        if(mnSpinFlag){mnSpinTimer+=DT;if(mnSpinTimer>2){mnSpinTimer=0;mnSpinFlag=false;}s+=Curve(MnSpinCurve,mnSpinTimer*.5f)*960;}
        mnEuler.y+=s*DT;mnEuler.x+=.3f*s*DT;
        mnStateTime+=DT;
        if(mnFire>0){mnFire-=DT;if(mnFire<=0)Shots.Add(new Shot{pattern="mn01_fire1",muzzle=MnMuzzle});}
        if(!InRect(pos,.3f))End("mn01-left-area");                                           // after base: !_isInGamePlayArea (AreaL, Large)
    }
    static readonly Round1EnemyWaves.Definition BitDefinition=new Round1EnemyWaves.Definition{name="mn01_shield_bit",model="Pf_Ene_Mn01c",
        events=new Round1EnemyWaves.ActionData[0],placements=new Round1EnemyWaves.Placement[0],routes=new string[0],repeats=new Round1EnemyWaves.Repeat[0]};
    // _createChildren 0x1CFC850: 13 bits on a 200 x 120 ellipse round the sky origin, each with a slot 15..25 from the core.
    void MnCreateChildren()
    {
        const float step=180f/13;
        for(int i=0;i<13;i++)
        {
            var c=new Round1EventStack(BitDefinition,Vector3.zero,0,0,null,"Pf_Ene_Mn01c",(int)(rng.U()*1e6f)+i,player);
            c.bitMass=c.rng.Range(.9f,1.3f);                                                   // ReStart: _mass, _spin
            int Sign()=>c.rng.U()<.5f?-1:1;
            c.bitSpin=Quaternion.Euler(Sign()*(90+(int)(c.rng.U()*90)),Sign()*(90+(int)(c.rng.U()*90)),Sign()*(90+(int)(c.rng.U()*90)));
            float a=((rng.U()-.5f)*step+i/13f*360+20)*Mathf.Deg2Rad,R=rng.Range(15,25);
            c.bitOffset=new Vector3(R*Mathf.Cos(a),0,R*Mathf.Sin(a));c.pos=new Vector3(200*Mathf.Cos(a),0,120*Mathf.Sin(a));
            c.bitState=2;Adopt(c);Summoned.Add(c);
        }
    }

    // ---- Ene_Mn01c summoned bit (Ene_Mn01c/SPEC.md sec. 5): SHIELD -> GATHER -> AWAY ---------------------------------
    int bitState,bitStep;float bitStepWait,bitSpeed,bitMass=1,bitSpinAngle,bitSepaTimer;bool bitSepaDone,bitFree;
    Vector3 bitOffset,bitVel;Quaternion bitSpin=Quaternion.identity,bitRotate=Quaternion.identity;
    public bool SummonedBit=>bitState!=0;
    public Quaternion BitRotation{get;private set;}=Quaternion.identity;                     // _model.localRotation (visual)
    void Tumble(float rate){bitRotate*=Quaternion.SlerpUnclamped(Quaternion.identity,bitSpin,DT*rate);BitRotation=bitRotate;}
    void Mn01cBit()
    {
        var P=!bitFree && Owner!=null?Owner.pos:pos;                                          // parent.localPosition, read live
        if(bitState==2)                                                                       // SHIELD (_shieldModeState 0x1CFB470)
        {
            var T=P+bitOffset;
            if(bitStep==0){bitStep=1;bitSpeed=50;bitStepWait=0;}
            if(bitStep==1)
            {
                bitStepWait+=DT;
                if(bitStepWait>=1.8f){bitStep=2;bitStepWait=0;Tumble(2);}                     // _AppearTime 1.8
                else
                {
                    bitSpeed=Mathf.Max(0,bitSpeed-20*bitMass*DT);var d=T-pos;float dl=d.magnitude,st=bitMass*bitSpeed*DT;
                    if(dl>.001f && st>0){bitVel=Norm(d)*bitSpeed;if(dl>st){pos+=bitVel*bitMass*DT;Tumble(2);}else pos=T;}
                }
            }
            else
            {
                bitSpeed+=400*bitMass*DT;var d=T-pos;float dl=d.magnitude;
                if(bitMass*bitSpeed*DT>=dl){bitVel=Norm(bitVel)*Mathf.Min(bitMass*bitSpeed/60,5);bitState=4;bitStep=0;bitSpinAngle=0;} // docks (SE 186 not wired)
                else{bitVel=Norm(d)*bitSpeed;pos+=bitVel*bitMass*DT;Tumble(2);}
            }
        }
        else if(bitState==4)                                                                  // GATHER: orbit at 60 deg/s, overshoot decays
        {
            bitVel*=Mathf.Exp(-6*DT);bitSpinAngle+=DT*60;var rot=Quaternion.Euler(0,bitSpinAngle,0);
            pos=P+rot*(bitOffset+bitVel);BitRotation=rot*bitRotate;
        }
        else if(bitState==3)                                                                  // AWAY: straight out at 120 * mass^2
        {
            pos+=bitVel*bitMass*DT;Tumble(10);
            if(!InArea(pos)){End("bit-left-area");return;}
        }
        if(bitSepaTimer>0){bitSepaTimer-=DT;if(bitSepaTimer<=0 && !bitSepaDone){bitSepaDone=true;BitSeparate();}}
    }
    // ToSeparate 0x1CFA9C0: radial from the slot (GATHER) or along the approach (SHIELD).
    void BitSeparate()
    {
        if(bitFree || bitState==0 || Ended)return;
        var v=bitState==4?Quaternion.Euler(0,bitSpinAngle,0)*bitOffset:bitVel;
        bitVel=Norm(v)*bitMass*120;bitState=3;bitFree=true;
    }

    // ---- Ene_Mm01: the split gate (Ene_Mm01/SPEC.md sec. 3), after the mover; its halves are two targets -----------------
    static readonly Vector3[] MmDefault={new Vector3(0,0,200),new Vector3(0,0,200),new Vector3(0,0,120),new Vector3(0,0,-120),new Vector3(-180,0,0),new Vector3(180,0,0)};
    static readonly Vector3[] MmDirection={Vector3.zero,Vector3.zero,Vector3.back,Vector3.forward,Vector3.right,Vector3.left};
    static float MmCurveIn(float t)=>Hermite(1,-.7560472f,0,-1.7989875f,t);
    static float MmCurveOut(float t)=>Hermite(0,1.0051994f,1,.4387774f,t);
    static float Hermite(float v0,float o0,float v1,float i1,float t){float s=Mathf.Clamp01(t),s2=s*s,s3=s2*s;return (2*s3-3*s2+1)*v0+(s3-2*s2+s)*o0+(-2*s3+3*s2)*v1+(s3-s2)*i1;}
    int mmState,mmBehavior;float mmPassed,mmTpos,mmVel,mmLaserLength;Vector3 mmOrg,mmStartOffset,mmMove;bool mmRot90,mmLaser,mmSibling;
    readonly bool[] mmBroken=new bool[2];
    public bool Mm01Laser=>mmLaser && !mmSibling;                                             // _setLaserCollision: _laserEnable && !_siblingDead
    public bool Mm01Burners=>mmState==4 || mmState==11;                                       // H2/V2 -> burners Play; H3/V3 end -> Stop
    public bool Mm01Rot90=>mmRot90;                                                           // _modelTop yaw 90 (Vertical, Left, Right)
    public bool Mm01Joined=>mmState==3 || mmState==10;                                       // a kill here pays Get5000
    public bool Mm01Gate=>mmState>=1 && mmState<=5 || mmState>=8 && mmState<=12;             // H/V: sliding in, closing, joined, opening
    public readonly float[] HalfPitch=new float[2];                                          // left, right local Euler x (close/open spin)
    // World offset of half i (0 left, 1 right) from the root: _right = (x, 0, 0), _left = (-x, 0, 0) under _modelTop.
    public Vector3 HalfOffset(int i)
    {
        float x=mmState>=15 && mmState<=18?mmLaserLength*.5f:mmTpos,r=i==1?x:-x;
        return mmRot90?new Vector3(0,0,-r):new Vector3(r,0,0);
    }
    // OnPartsBreak 0x1DCCFA0: the first broken half leaves its sibling on 1 HP and alone (solo away after the close).
    public void HalfBroken(int i){if(!mmBroken[1-i])mmSibling=true;mmBroken[i]=true;}
    void Mm01Start(Vector3 spawn,int index)
    {
        mmBehavior=index>=0 && index<=5?index:0;mmStartOffset=new Vector3(spawn.x,0,spawn.z);mmLaserLength=spawn.y;
        pos=MmDefault[mmBehavior];                                                            // parked off screen until INIT
    }
    void Mm01()
    {
        float p=mmPassed;int next=-1;bool end=false;
        switch(mmState)
        {
            case 0:                                                                           // INIT ([I] the player is never control-disabled here)
            {
                var ps=PlayerSky();
                if(mmBehavior==0){mmState=1;mmRot90=false;mmOrg=new Vector3(0,0,ps.z);mmTpos=160+60;}
                else if(mmBehavior==1){mmState=8;mmRot90=true;mmOrg=new Vector3(ps.x,0,0);mmTpos=120+10;}
                else{mmState=15+mmBehavior-2;mmRot90=mmBehavior>=4;pos=MmDefault[mmBehavior]+mmStartOffset;mmMove=MmDirection[mmBehavior]*speed;mmLaser=true;}
                if(mmBehavior<2){pos=mmOrg;mmTpos=-mmTpos;}                                   // SetupHV: the halves swapped for one frame
                break;
            }
            case 1:case 8:                                                                    // H0/V0: slide in, hold
            {
                float st=mmState==1?160+20:120,ed=mmState==1?115:65;mmTpos=(ed-st)*Mathf.Clamp01(Mathf.Min(p,1))+st+10;
                if(p>=2)next=mmState+1;break;
            }
            case 2:case 9:                                                                    // H1/V1: close, spinning
            {
                float pt=Mathf.Min(p,1);mmTpos=MmCurveIn(pt)*(mmState==2?115:65)+10;MmSpin(Mathf.Clamp01(pt/.92f));
                if(pt>=1)next=mmSibling?(mmState==2?7:14):mmState+1;break;
            }
            case 3:case 10:if(Mathf.Min(p,.5f)>=.5f){next=mmState+1;mmLaser=true;}break;       // joined: laser on
            case 4:case 11:                                                                   // H3/V3: open with the laser
            {
                float pt=Mathf.Min(p,1.5f),u=pt/1.5f;mmTpos=MmCurveOut(u)*(mmState==4?115:65)+10;if(u>=.08f)MmSpin(1-(u-.08f)/.92f);
                if(pt>=1.5f){var ps=PlayerSky();mmVel=mmState==4?(ps.z>=mmOrg.z?1:-1):(ps.x>=mmOrg.x?1:-1);next=mmState+1;}
                break;
            }
            case 5:case 12:if(Mathf.Min(p,.5f)>=.5f)next=mmState+1;break;
            case 6:case 13:mmState=19;break;                                                  // -> AWAY, same frame
            case 7:mmTpos=10-MmCurveOut(Mathf.Min(p,1))*(160+40);if(p>=1)end=true;break;     // solo away
            case 14:mmTpos=10-160*MmCurveOut(Mathf.Min(p,1));if(p>=1)end=true;break;
            case 15:case 16:case 17:case 18:
                pos+=mmMove*DT;if(pos.z>120 || pos.z<-120 || pos.x<-180 || pos.x>180)end=true;break;
            case 19:                                                                          // AWAY at 60 u/s until no half is in the play area
                if(mmBehavior==0)mmOrg.z+=mmVel*60*DT;else mmOrg.x+=mmVel*60*DT;pos=mmOrg;
                if((mmBroken[0] || !InArea(pos+HalfOffset(0))) && (mmBroken[1] || !InArea(pos+HalfOffset(1))))end=true;break;
        }
        if(next>=0){mmState=next;mmPassed=0;}
        if(end){End("mm01-away");return;}
        mmPassed+=DT;
        if(frame+1>=3600)End("duration");                                                     // SplineMover duration 60 s backstop
    }
    void MmSpin(float s){HalfPitch[0]=810*s;HalfPitch[1]=-720*s;}

    // ---- Ene_Ml01 (Ene_Ml01/SPEC.md sec. 4): hunts the Sj01 school, then the player ------------------------------
    readonly List<Round1EventStack> mlFood=new List<Round1EventStack>();
    int mlState,mlTarget=-1,mlJaw;float mlStateTime,mlTotal,mlSpeed,mlSpeedMax,mlTurn,mlTurnMax;bool mlEatEnd;Vector3 mlLast;
    public float JawAngle{get;private set;}                                                   // mouth_L local yaw; mouth_R takes -JawAngle
    public int FoodEaten{get;private set;}
    // _foodListup: the Pf_Ene_Sj01 in the enemy line-up on the Ml01's first frame (later ones are never added).
    public void SetFood(IEnumerable<Round1EventStack> food){mlFood.Clear();mlFood.AddRange(food);}
    bool FoodAlive(int i)=>i>=0 && i<mlFood.Count && mlFood[i]!=null && !mlFood[i].Gone && !mlFood[i].Ended;
    bool InLimits(Vector3 p)=>Mathf.Abs(p.x)<90 && Mathf.Abs(p.y)<70;                        // _searchLimitX/Y (y is altitude: always passes)
    int SetNearFood(){mlTarget=-1;for(int i=0;i<mlFood.Count;i++)if(FoodAlive(i) && InLimits(mlFood[i].pos))mlTarget=i;return mlTarget;} // the LAST one
    Vector3 Fwd()=>new Vector3(Mathf.Sin(yaw*Mathf.Deg2Rad),0,Mathf.Cos(yaw*Mathf.Deg2Rad));
    void MlStep()=>pos+=Fwd()*mlSpeed*DT;
    void MlTurn(Vector3 d,float delta){float want=Mathf.Atan2(d.x,d.z)*Mathf.Rad2Deg,diff=Norm180(want-yaw),m=delta*20;yaw+=Mathf.Clamp(diff,-m,m);} // _rotateTowards, _turnSpeed 20
    bool MlAimed(Vector3 d)=>Mathf.Abs(Mathf.Atan2(d.x,d.z)*Mathf.Rad2Deg-Wrap180(yaw))<2 && d.magnitude<80;   // not re-wrapped, as natively
    static float Wrap180(float e){e=Mod(e,360);return e>180?e-360:e;}
    bool MlCheckPosition(float r){var f=Fwd();return !(Mathf.Abs(pos.x+f.x*r)<90 && Mathf.Abs(pos.y+f.y*r)<70);}
    void Ml01()
    {
        switch(mlState)
        {
            case 0:mlState=2;mlSpeed=50;break;                                                // Init (food listed by the host)
            case 2:if(mlStateTime>=.1f)mlState=1;MlStep();break;                              // PreWait
            case 1:                                                                           // Find
                mlJaw=0;
                if(SetNearFood()!=-1){mlState=3;mlSpeed=20;mlSpeedMax=50;mlTurn=1;mlTurnMax=12;mlStateTime=0;mlLast=mlFood[mlTarget].pos;}
                else{mlState=6;mlSpeed=50;mlStateTime=0;}
                break;
            case 3:                                                                           // Search
            {
                mlSpeed=Mathf.Min(mlSpeedMax,mlSpeed+DT*16);mlTurn=Mathf.Min(mlTurnMax,mlTurn+DT*32);bool skip=false;
                if(mlStateTime>=1.8f-.2f)
                {
                    if(Vector3.Distance(mlLast,pos)>100){mlStateTime*=.5f;skip=true;}
                    else{mlSpeed=Mathf.Max(0,mlSpeed-DT*100);mlJaw=1;}
                }
                if(!skip && mlStateTime>=1.8f)
                {
                    if(!FoodAlive(mlTarget)){mlJaw=0;mlState=1;}
                    else{mlStateTime=0;mlSpeed=MlCheckPosition(60)?100:200;mlState=4;}
                    skip=true;
                }
                if(!skip && (mlTarget==-1 || !FoodAlive(mlTarget) || InLimits(mlFood[mlTarget].pos)) && SetNearFood()==-1)
                {mlStateTime=0;mlSpeed=50;mlTurn=4;mlState=6;skip=true;}
                if(!skip)
                {
                    var tg=FoodAlive(mlTarget)?mlFood[mlTarget].pos:mlLast;mlLast=tg;
                    var d=new Vector3(tg.x-pos.x,-pos.y,tg.z-pos.z);MlTurn(d,DT*mlTurn);MlStep();
                    if(MlAimed(d)){mlJaw=1;mlStateTime=0;mlSpeed=200;mlTurn=4;mlState=4;if(MlCheckPosition(60))mlSpeed=100;}
                }
                break;
            }
            case 4:case 7:                                                                    // Attack / PlayerAttack
                MlStep();
                if(mlStateTime>=.1f){mlJaw=2;mlSpeed-=DT*400;}                                // SE 0x94 not wired
                if(mlState==4 && mlSpeed<=20){mlStateTime=0;mlSpeed=20;mlState=5;}
                if(mlState==7 && mlSpeed<=0){mlSpeed=50;mlJaw=0;mlState=8;}
                break;
            case 5:MlStep();if(mlStateTime>=.4f)mlState=1;break;                              // PostWait
            case 6:                                                                           // PlayerSearch: player index 0
                if(!InRect(pos,.5f)){mlJaw=0;mlState=8;break;}                                 // !IsGameWideArea
                {
                    var pl=PlayerSky();var d=new Vector3(pl.x-pos.x,-pos.y,pl.z-pos.z);mlTurn+=DT*10;MlTurn(d,DT*mlTurn);
                    mlSpeed=Mathf.Max(100,mlSpeed+DT*10);if(MlAimed(d)){mlStateTime=0;mlSpeed=200;mlJaw=1;mlState=7;}
                    MlStep();
                }
                break;
            case 8:if(!InRect(pos,.5f))mlState=9;MlStep();mlSpeed+=DT*100;break;            // Release
            default:End("ml01-released");return;                                              // CallDisabled
        }
        // Jaw: Open -> 15 deg at 360 deg/s, Close -> -10 at 180, Normal -> 0 at 180 (mouth_L/_R local yaw).
        float jt=mlJaw==1?15:mlJaw==2?-10:0;JawAngle=Mathf.MoveTowards(JawAngle,jt,(mlJaw==1?360:180)*DT);
        if(mlJaw==1)for(int i=0;i<mlFood.Count;i++)                                          // _foodEatCheck(_biteRange 20), from the centre
            if(FoodAlive(i) && (mlFood[i].pos-pos).sqrMagnitude<=20*20){mlFood[i].CommonEvent(0);FoodEaten++;}
        if(mlTotal>=10 && !mlEatEnd){mlEatEnd=true;foreach(var f in mlFood)if(f!=null && !f.Gone && !f.Ended)f.CommonEvent(1);} // _getAway: flee
        mlStateTime+=DT;mlTotal+=DT;
        if(frame+1>=3600)End("duration");                                                     // SplineMover duration 60 s backstop [I]
    }

    // ---- Ene_Sj01 class (Pf_Ene_Sj01/Su01/Sv01; Ene_Sj01/SPEC.md sec. 2): inert until told to flee or eaten -------------
    int sjState;float sjStateTime,sjWave,sjWaveRate,sjWaveMult,sjAway,sjTimeLimit=999;bool sjParentDie;
    XorShift32 sjRng;
    public bool Eaten{get;private set;}
    bool SjFrozen=>sjState>=1;                                                                 // SetPlayPause(true): stack and route stop
    // CommonEvent 0x1D01430: 0 eaten (AddDead, no player credit), 1 escape now, 2 parent gone: escape once _stateTime > 2.
    public void CommonEvent(int n)
    {
        if(n==0){if(!Eaten){Eaten=true;End("eaten");}}
        else if(n==1){if(sjState==0)sjState=1;}
        else if(n==2){sjTimeLimit=2;sjParentDie=true;}
    }
    static bool SjClass(string m)=>m=="Pf_Ene_Sj01" || m=="Pf_Ene_Su01" || m=="Pf_Ene_Sv01";
    void Sj01()
    {
        sjStateTime+=DT;
        switch(sjState)
        {
            case 0:break;                                                                     // the rolls are re-drawn every frame; drawn once on leaving
            case 1:
                sjRng??=new XorShift32(seedValue^0x51F15E);sjWave=sjRng.U()*90;sjWaveRate=sjRng.U()*20;sjWaveMult=1;sjAway=60+sjRng.U()*10;
                yaw=pos.x>0?90:270;sjState=2;break;                                            // face away from the centre
            case 2:
            {
                float fx=Mathf.Sin(yaw*Mathf.Deg2Rad),zf=Mathf.Sin(sjWave*Mathf.Deg2Rad)*.5f*sjWaveMult;
                sjWave+=sjWaveRate+20;sjWaveMult*=.93f;sjWaveRate*=.95f;sjAway=Mathf.Max(90,sjAway+4*DT);   // per frame, as natively
                pos+=new Vector3(sjAway*fx*DT,0,sjAway*zf*DT);
                if(!InArea(pos))sjState=3;break;
            }
            default:End(sjParentDie?"sj01-parent-gone":"sj01-escaped");return;               // CallDisabled
        }
        if(sjState==0 && sjStateTime>sjTimeLimit)sjState=1;
        sjStateTime+=DT;                                                                       // the second increment: a 2x clock
    }

    // ---- Ene_Mc01 (Ene_Mc01/SPEC.md sec. 2), after the route mover: the 0.75 s open/fire/close cycle ------------------
    float mcTimer;
    readonly List<(float wait,Shot shot)> delayed=new List<(float,Shot)>();
    void Mc01()
    {
        float prev=mcTimer;mcTimer+=DT;
        if(prev<=.4f && .4f<mcTimer)                                                          // FireTime 0.4: every _bulletData (BulletFireAsyncDelayed)
        {Shots.Add(new Shot{pattern="mc01_fire1",muzzle="pf_ene_mc01/muzzle01"});delayed.Add((.04f,new Shot{pattern="mc01_fire2",muzzle="pf_ene_mc01/muzzle02"}));}
        if(prev<=.75f && .75f<mcTimer)mcTimer=Mathf.Clamp(mcTimer-Mathf.Floor(mcTimer/.75f)*.75f,0,.75f);   // close, Repeat, open
    }
    void StepDelayed()
    {
        for(int i=delayed.Count-1;i>=0;i--){var d=delayed[i];d.wait-=DT;if(d.wait<=1e-5f){Shots.Add(d.shot);delayed.RemoveAt(i);}else delayed[i]=d;}
    }

    // ---- class programs (Ene_Sq01/SPEC.md sec. 3, Ene_Mb01/SPEC.md sec. 3) -------------------------------------------
    // Ene_Sq01 / Ene_Mb01.CreateRouteData: the definition's (empty) events are replaced by the class's static
    // _routeEventLists[_indexValue] (Mb01: list 1 is list 0). The stack then runs them as any program.
    static Round1EnemyWaves.ActionData Ev(int t)=>new Round1EnemyWaves.ActionData{eventType=t,stringValue="",nameValue="",subnameValue=""};
    static Round1EnemyWaves.ActionData Spl(string r){var e=Ev(15);e.stringValue=r;return e;}
    static Round1EnemyWaves.ActionData Tw(int m){var e=Ev(80);e.intValue1=m;return e;}
    static Round1EnemyWaves.ActionData Spd(float v,float t){var e=Ev(14);e.value0=v;e.dotime=t;return e;}
    static Round1EnemyWaves.ActionData Idle(float t){var e=Ev(20);e.dotime=t;return e;}
    static Round1EnemyWaves.ActionData Delay(float t){var e=Ev(1);e.dotime=t;return e;}
    static Round1EnemyWaves.ActionData Bul(int t,string n,string muzzle,bool self){var e=Ev(t);e.stringValue=n;e.nameValue=muzzle;e.flag0=self?1:0;return e;}
    static Round1EnemyWaves.ActionData Rot(float dt,Vector3 v,bool abs,int ease){var e=Ev(2);e.dotime=dt;e.vectorValue=v;e.flag0=abs?1:0;e.intValue1=ease;return e;}
    static Round1EnemyWaves.ActionData[] Sq01Program(int i)
    {
        Round1EnemyWaves.ActionData Laser(string n)=>Bul(83,n,"pf_ene_sq01/ene_sq/muzzle",true);    // BSelector(..., isSelfDir)
        if(i==0 || i==1)
        {
            string a=i==0?"move_sq01_r":"move_sq01_l",b=i==0?"move_sq01_l":"move_sq01_r";var label=Ev(5);label.stringValue="LP1";var loop=Ev(101);loop.stringValue="LP1";loop.intValue1=2;
            return new[]{Spl("common_D50"),Tw(256),label,Idle(.1f),Laser("sq01_fire1_sel"),Spl(a),Tw(256),Idle(.1f),Laser("sq01_fire1_sel"),Spl(b),Tw(256),loop,Spd(60,0),Idle(.1f),Spl("common_D150"),Tw(256)};
        }
        return new[]{Spl(i==2?"move_sq01_dl":"move_sq01_dr"),Spd(20,3),Tw(32),Laser("sq01_fire2_sel"),Idle(2),Spd(60,.5f),Tw(256)};
    }
    static Round1EnemyWaves.ActionData[] Mb01Program()
    {
        var p=new List<Round1EnemyWaves.ActionData>{Rot(0,new Vector3(0,180,0),true,0),Spl("common_D50"),Tw(256),Spd(10,1),Spl("common_D200")};
        for(int k=0;k<4;k++)
        {
            p.Add(Rot(1,new Vector3(0,0,-180),false,1));
            if(k<3)p.AddRange(new[]{Tw(1),Delay(.1f),Bul(8,"mb01_fire1","fire1A",false),Bul(8,"mb01_fire2","fire2A",false),Bul(8,"mb01_fire3","fire3A",false),Delay(.5f),Bul(8,"mb01_fire4","fire4A",false),Delay(.5f)});
        }
        var flag=Ev(10);flag.intValue1=256;
        p.AddRange(new[]{flag,Spd(50,1),Tw(256),Ev(1000)});
        return p.ToArray();
    }
    public static bool HasClassProgram(string model)=>model=="Pf_Ene_Sq01" || model=="Pf_Ene_Mb01";
    public static Round1EnemyWaves.Definition WithClassProgram(Round1EnemyWaves.Definition d,string model,int index)
    {
        if(!HasClassProgram(model))return d;
        var c=(Round1EnemyWaves.Definition)d.GetType().GetMethod("MemberwiseClone",System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.NonPublic).Invoke(d,null);
        c.events=model=="Pf_Ene_Sq01"?Sq01Program(Mathf.Clamp(index,0,3)):Mb01Program();      // List.get_Item throws past 3 natively
        return c;
    }
}
