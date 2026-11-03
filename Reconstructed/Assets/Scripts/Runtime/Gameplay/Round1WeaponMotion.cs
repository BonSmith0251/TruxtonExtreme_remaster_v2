using System.Collections.Generic;
using UnityEngine;

public partial class Round1Weapon
{
    const float SourceHeight=200,ShotTick=1f/120;
    double shotRemainder;
    int homingCursor;
    Transform[] emitters;
    sealed class LaserState
    {
        public float length;public bool active;public Round1Combat.Target target;public int targetId;
        public readonly Round1DamageStream damage=new Round1DamageStream();
        public void Reset(){length=0;active=false;target=null;targetId=0;damage.Clear();}
    }
    readonly LaserState[] lasers=new LaserState[48];
    readonly List<Round1Combat.Target> homingCandidates=new List<Round1Combat.Target>();
    readonly HashSet<int> laserHits=new HashSet<int>();
    public int ActiveNapalmCount { get {int n=0;foreach(var b in bullets)if(b.active && b.napalm)n++;return n;} }
    public Vector2[] BulletPositions { get {var p=new List<Vector2>();foreach(var b in bullets)if(b.active)p.Add(b.position);return p.ToArray();} }
    public Vector2[] BulletVelocities { get {var p=new List<Vector2>();foreach(var b in bullets)if(b.active)p.Add(b.velocity);return p.ToArray();} }
    public int[] HomingTargetIds { get {var ids=new List<int>();foreach(var b in bullets)if(b.active && b.kind==Round1Arms.Silver)ids.Add(b.targetId);return ids.ToArray();} }
    public int LockedBeamCount { get {int n=0;foreach(var l in lasers)if(l!=null && l.active && Valid(l.target,l.targetId))n++;return n;} }
    public Vector2 ShotOrigin(Round1ShotSpec spec)=>Muzzle(spec);
    void InitializeShotMotion()
    {
        var paths=Round1WeaponBehavior.Current.emitters;emitters=new Transform[paths.Length];
        for(int i=0;i<paths.Length;i++)
        {
            emitters[i]=player.transform.Find(paths[i]);
            if(!emitters[i])throw new System.InvalidOperationException("Missing original emitter: "+paths[i]);
        }
        for(int i=0;i<lasers.Length;i++)lasers[i]=new LaserState();
    }
    float ShotAspect=>Mathf.Max(.1f,player.stageCamera.aspect);
    Vector2 Muzzle(Round1ShotSpec spec)
    {
        // Actual ship/option emitters follow the banked model. Shot offsets are authored in stage X/Z.
        Vector2 origin=player.stageCamera.WorldToViewportPoint(emitters[spec.muzzle].position);
        return origin+new Vector2(spec.offset.x/ShotAspect,spec.offset.z)/SourceHeight;
    }
    static Vector2 ShotDirection(float degrees)=>new Vector2(Mathf.Sin(degrees*Mathf.Deg2Rad),Mathf.Cos(degrees*Mathf.Deg2Rad));
    static bool Valid(Round1Combat.Target target,int id)=>target!=null && target.id==id && target.active && !target.invulnerable;
    static bool Visible(Round1Combat.Target t)=>t.position.x>=0 && t.position.x<=1 && t.position.y>=0 && t.position.y<=1;
    Round1Combat.Target ChooseHomingTarget()
    {
        homingCandidates.Clear();int priority=int.MinValue;
        foreach(var target in combat.Targets)
        {
            // Priority zero marks non-homing scenery, including all three asteroid sizes.
            if(!target.active || target.invulnerable || !Visible(target) || target.homingPriority<=0 || target.homingPriority>=100000)continue;
            if(target.homingPriority>priority){homingCandidates.Clear();priority=target.homingPriority;}
            if(target.homingPriority==priority)homingCandidates.Add(target);
        }
        return homingCandidates.Count==0?null:homingCandidates[homingCursor++%homingCandidates.Count];
    }
    void AdvanceShotSimulation(float dt,bool firing)
    {
        Round1Sound.WeaponLoop(Arms,Level,firing && IsLaser(Arms));
        if(!firing)HideBeams();
        else if(IsLaser(Arms))FireLasers(0);
        else if(cooldown<=.000001f){FireVolley();cooldown=FireInterval;}
        shotRemainder+=dt;
        while(shotRemainder+1e-7>=1.0/120)
        {
            shotRemainder-=1.0/120;
            foreach(var b in bullets)if(b.active)AdvanceBullet(b,ShotTick);
            cooldown=Mathf.Max(0,cooldown-ShotTick);
            if(firing)
            {
                if(IsLaser(Arms))FireLasers(ShotTick);
                else if(cooldown<=.000001f){FireVolley();cooldown=FireInterval;}
            }
        }
    }
    void FireVolley()
    {
        var profile=Round1WeaponBehavior.Current.profiles[(int)Arms];int active=0,free=0;
        foreach(var b in bullets){if(b.active && b.kind==Arms)active++;if(!b.active)free++;}
        // Native IsFire requires room for an entire volley in this weapon's ammo bank.
        if(active+ShotsAtLevel>ShotsAtLevel*profile.ammoVolleys || free<ShotsAtLevel)return;
        foreach(var spec in rules.tables[(int)Arms].shots)
        {
            if((spec.mask&(1<<(Level-1)))==0)continue;
            var b=bullets.Find(x=>!x.active);
            b.position=Muzzle(spec);b.velocity=ShotDirection(spec.angle)*(profile.speed/SourceHeight);
            b.age=0;b.travel=0;b.napalmAge=0;b.napalm=false;b.size=1;b.kind=Arms;
            b.damage=Round1Balance.Current.weapons[(int)Arms].first;b.damageStream.Clear();b.hits.Clear();
            b.target=Arms==Round1Arms.Silver?ChooseHomingTarget():null;b.targetId=b.target==null?0:b.target.id;
            b.active=true;b.visual.SetActive(true);ApplyBulletMaterial(b);MuzzleFlash(spec.muzzle);
        }
        VolleysFired++;Round1Sound.Fire(Arms,Level);
    }
    void AdvanceBullet(Bullet b,float dt)
    {
        var behavior=Round1WeaponBehavior.Current;Vector2 previous=b.position;b.age+=dt;
        if(b.kind==Round1Arms.Silver && b.age>=behavior.homingStart && b.age<behavior.homingEnd && Valid(b.target,b.targetId))
        {
            Vector2 aim=b.target.position-b.position;aim.x*=ShotAspect;
            float current=Mathf.Atan2(b.velocity.x,b.velocity.y)*Mathf.Rad2Deg,desired=Mathf.Atan2(aim.x,aim.y)*Mathf.Rad2Deg;
            b.velocity=ShotDirection(Mathf.MoveTowardsAngle(current,desired,behavior.homingDegreesPerFrame*60*dt))*b.velocity.magnitude;
        }
        if(b.napalm)
        {
            b.napalmAge+=dt;float range=Mathf.Clamp01(b.travel*SourceHeight/behavior.growDistance);
            float peak=behavior.growTime*range,stay=behavior.growStay*range;
            float growth=b.napalmAge<=peak?b.napalmAge/behavior.growTime:range-Mathf.Max(0,b.napalmAge-peak-stay)*behavior.growDecay/behavior.growTime;
            b.size=Mathf.Lerp(1,behavior.growScale,Mathf.Clamp01(growth));
            if(growth<=0){RemoveBullet(b);return;}
            b.damageStream.Segment(combat,b.position,b.position,3*b.size/SourceHeight,Round1Balance.Current.weapons[5],dt);
        }
        else
        {
            float distance=b.velocity.magnitude*dt;
            if(b.kind==Round1Arms.Purple)distance=Mathf.Min(distance,behavior.growDistance/SourceHeight-b.travel);
            var direction=b.velocity.normalized;b.position+=new Vector2(direction.x/ShotAspect,direction.y)*distance;b.travel+=distance;
            var target=FirstHit(previous,b.position,.008f,b.hits,null,out float fraction);
            if(target==null && b.kind!=Round1Arms.Purple && combat.ShootHostile(previous,b.position,.008f)){RemoveBullet(b);return;}
            if(b.kind==Round1Arms.Purple)
            {
                if(target!=null){b.position=Vector2.Lerp(previous,b.position,fraction);b.travel-=distance*(1-fraction);HitEffect(target,b.kind,b.position,false);}
                b.damageStream.Segment(combat,previous,b.position,.008f,Round1Balance.Current.weapons[5],dt);
                if(target!=null || b.travel>=behavior.growDistance/SourceHeight-.00001f){b.napalm=true;b.napalmAge=0;}
            }
            else while(target!=null)
            {
                b.hits.Add(target.id);HitEffect(target,b.kind,Vector2.Lerp(previous,b.position,fraction),false);combat.Damage(target,b.damage);
                // Green passes only through a defeated enemy. Red and silver always end at first impact.
                if(b.kind!=Round1Arms.Green || target.active){RemoveBullet(b);return;}
                target=FirstHit(previous,b.position,.008f,b.hits,null,out fraction);
            }
        }
        if(b.position.y>1.2f || b.position.y<-.2f || b.position.x<-.2f || b.position.x>1.2f || b.age>4)RemoveBullet(b);
    }
    void RemoveBullet(Bullet b){b.active=false;b.visual.SetActive(false);}
    // The weapon's original hit effect where a shot or beam meets an enemy, plus the hit flash (Round1Effects).
    void HitEffect(Round1Combat.Target target,Round1Arms kind,Vector2 at,bool laser){if(target.active)combat.effects.Hit(target,kind,at,player.playback.elapsed,laser);}
    Round1Combat.Target FirstHit(Vector2 from,Vector2 to,float radius,HashSet<int> skip,Round1Combat.Target excluded,out float fraction)
    {
        float best=2;Round1Combat.Target result=null;Vector2 movement=to-from;movement.x*=ShotAspect;float length2=movement.sqrMagnitude;
        foreach(var target in combat.Targets)
        {
            if(!target.active || target.invulnerable || target==excluded || (skip!=null && skip.Contains(target.id)))continue;
            if(target.hitCircles==null){Sweep(target,target.position,target.radius);continue;}
            foreach(var c in target.hitCircles)Sweep(target,combat.CirclePosition(target,c),c.z);
        }
        fraction=best;return result;
        // Earliest contact of the moving shot with one circle of a target.
        void Sweep(Round1Combat.Target target,Vector2 centre,float circle)
        {
            Vector2 offset=from-centre;offset.x*=ShotAspect;float r=radius+circle;
            float f=0;
            if(offset.sqrMagnitude>r*r)
            {
                if(length2<1e-12f)return;
                float dot=Vector2.Dot(offset,movement),disc=dot*dot-length2*(offset.sqrMagnitude-r*r);
                if(disc<0)return;f=(-dot-Mathf.Sqrt(disc))/length2;
                if(f<0 || f>1)return;
            }
            if(f<best){best=f;result=target;}
        }
    }
    void HideBeams(bool clearDamage=true)
    {
        foreach(var line in beams)line.enabled=false;ActiveBeamCount=0;HideBeamLayers();
        if(clearDamage)foreach(var laser in lasers)if(laser!=null)laser.Reset();
    }
    void FireLasers(float dt)
    {
        HideBeams(false);int number=0;
        foreach(var spec in rules.tables[(int)Arms].shots)
        {
            if((spec.mask&(1<<(Level-1)))==0 || number>=16)continue;
            int index=number++;var start=Muzzle(spec);
            Vector2 end=AdvanceLaser(index,start,ShotDirection(spec.angle),Round1Balance.Current.weapons[(int)Arms],dt,null);
            if(Arms==Round1Arms.Gold && Valid(lasers[index].target,lasers[index].targetId) && lasers[index].target.lockOn)
            {
                var behavior=Round1WeaponBehavior.Current;var childProfile=new Round1DamageProfile{first=behavior.childFirstDamage,continuous=behavior.childStayDamage};
                Vector2 incoming=end-start;incoming.x*=ShotAspect;float angle=Mathf.Atan2(incoming.x,incoming.y)*Mathf.Rad2Deg;
                for(int side=0;side<2;side++)AdvanceLaser(16+index*2+side,end,ShotDirection(angle+(side==0?-1:1)*behavior.childAngle),childProfile,dt,lasers[index].target);
            }
            else {lasers[16+index*2].Reset();lasers[17+index*2].Reset();}
        }
        for(int i=number;i<16;i++){lasers[i].Reset();lasers[16+i*2].Reset();lasers[17+i*2].Reset();}
    }
    Vector2 AdvanceLaser(int index,Vector2 start,Vector2 direction,Round1DamageProfile profile,float dt,Round1Combat.Target excluded)
    {
        var state=lasers[index];state.active=true;state.length=Mathf.Min(2,state.length+720/SourceHeight*dt);
        if(!Valid(state.target,state.targetId) || state.target==excluded || (state.target!=null && !Visible(state.target)))
        {state.target=null;state.targetId=0;}
        Vector2 end=start+new Vector2(direction.x/ShotAspect,direction.y)*state.length;
        if(state.target!=null)
        {
            // Once acquired, keep the lock instead of selecting a different nearest enemy every frame.
            Vector2 diff=state.target.position-start;float distance=combat.Distance(start,state.target.position);
            end=start+diff*Mathf.Min(1,state.length/Mathf.Max(.00001f,distance));
        }
        state.damage.Begin();laserHits.Clear();
        if(state.length>0)
        {
            var target=FirstHit(start,end,.012f,laserHits,excluded,out float fraction);
            while(target!=null)
            {
                laserHits.Add(target.id);HitEffect(target,Arms,Vector2.Lerp(start,end,fraction),true);state.damage.Hit(combat,target,profile,dt);
                if(target.active && (target.lockOn || target.blocksLaser))
                {
                    end=Vector2.Lerp(start,end,fraction);
                    if(target.lockOn){state.target=target;state.targetId=target.id;}
                    break;
                }
                target=FirstHit(start,end,.012f,laserHits,excluded,out fraction);
            }
        }
        state.damage.End();var line=beams[index];line.enabled=true;ActiveBeamCount++;
        if(StyleBeam(index,line,start,end))return end;
        line.widthMultiplier=index>=16?.5f:Arms==Round1Arms.Black?2.3f:1;
        tint.Clear();tint.SetColor("_BaseColor",Tints[(int)Arms]*1.5f);line.SetPropertyBlock(tint);
        for(int i=0;i<5;i++)
        {
            var point=Vector2.Lerp(start,end,i/4f);
            if(i>0 && i<4 && Arms==Round1Arms.Blue)point.x+=Mathf.Sin(player.playback.elapsed*55+i*9+index)*.009f/ShotAspect;
            line.SetPosition(i,player.WorldPoint(point));
        }
        return end;
    }
}
