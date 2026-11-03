using System.Collections.Generic;
using UnityEngine;

// Uses the same movement, shots, bombs and pickup collisions as manual play.
public class Round1Autopilot : MonoBehaviour
{
    public Round1Weapon weapon;
    public bool automatic=true;
    public bool useBombs=true;
    public bool holdFire;   // verification: fly without shooting (STAGE_PLAY_PEACE)
    public Vector2 Direction { get; private set; }
    public bool WantsFire { get; private set; }
    public string Activity { get; private set; }="WAITING";
    public int BombsUsed { get; private set; }
    public struct Hazard
    {
        // Positions and velocities use aspect-correct screen-height units.
        public Vector2 from,to,velocity;
        public float radius,starts,ends;
        public bool beam;
    }
    readonly List<Hazard> hazards=new List<Hazard>(1400);
    readonly Dictionary<int,Vector2> previousEnemies=new Dictionary<int,Vector2>();
    readonly Dictionary<int,Vector2> currentEnemies=new Dictionary<int,Vector2>();
    float bombCooldown;
    Vector2 previousDirection;
    const float Horizon=.65f;
    void Update(){if(Input.GetKeyDown(KeyCode.F4) && !ArcadeMachine.Running)SetAutomatic(!automatic);}
    public void SetAutomatic(bool value){automatic=value;ResetPlanning();}
    public void ResetPlanning()
    {
        Direction=previousDirection=Vector2.zero;WantsFire=false;bombCooldown=0;
        previousEnemies.Clear();currentEnemies.Clear();hazards.Clear();BombsUsed=0;
        Activity=automatic?"WAITING":"MANUAL";
    }
    Vector2 Plane(Vector2 p){return new Vector2(p.x*weapon.player.stageCamera.aspect,p.y);}
    Vector2 Clamp(Vector2 p)
    {
        float m=weapon.player.screenMargin,a=weapon.player.stageCamera.aspect;
        return new Vector2(Mathf.Clamp(p.x,m*a,(1-m)*a),Mathf.Clamp(p.y,m,1-m));
    }
    public void Decide(float dt)
    {
        Direction=Vector2.zero;WantsFire=false;
        if(!automatic || !weapon || !weapon.CanAct || !weapon.player.InputEnabled || dt<=0)
        {Activity=automatic?"WAITING":"MANUAL";previousEnemies.Clear();previousDirection=Vector2.zero;return;}
        WantsFire=!holdFire;bombCooldown=Mathf.Max(0,bombCooldown-dt);
        var combat=weapon.combat;var player=weapon.player;
        if(!combat)return;
        hazards.Clear();combat.CopyPilotHazards(hazards);
        var origin=Plane(player.viewportPosition);float speed=player.movementSpeed*player.SpeedMultiplier;
        currentEnemies.Clear();
        Vector2 goal=Plane(new Vector2(.5f,.23f));float targetScore=float.NegativeInfinity;
        bool collecting=false;int visibleEnemies=0;bool bossVisible=false;
        foreach(var enemy in combat.Targets)
        {
            if(!enemy.active)continue;
            Vector2 position=Plane(enemy.position),velocity=Vector2.zero;
            if(previousEnemies.TryGetValue(enemy.id,out var last))velocity=Vector2.ClampMagnitude((position-last)/dt,1.5f);
            currentEnemies[enemy.id]=position;
            if(enemy.isBoss && enemy.noShipContact){} // ground boss (Bos08A): a target, never a collision hazard
            else if(enemy.isBoss && (!enemy.invulnerable||enemy.touchesWhileInvulnerable) && enemy.hitCircles!=null)
                foreach(var c in enemy.hitCircles)hazards.Add(new Hazard{from=position+new Vector2(c.x,c.y),velocity=velocity,radius=c.z+.012f,ends=Horizon});
            else if(!enemy.isBoss || !enemy.invulnerable)
                // Large air enemies (e.g. Mb01, 22-unit hit circles) reach well past the fixed .035; use their hit-circle reach.
                hazards.Add(new Hazard{from=position,velocity=velocity,radius=enemy.isBoss?enemy.radius+.012f:Mathf.Max(.035f,enemy.radius+.008f),ends=Horizon});
            if(enemy.invulnerable || enemy.position.x<0 || enemy.position.x>1 || enemy.position.y<origin.y+.08f || enemy.position.y>1.05f)continue;
            visibleEnemies++;bossVisible|=enemy.isBoss;
            float score=(enemy.isPickupDrone?2:0)-Mathf.Abs(position.x-origin.x)-.2f*Mathf.Abs(position.y-.6f);
            if(score>targetScore){targetScore=score;goal=Clamp(new Vector2(position.x,.23f));}
        }
        previousEnemies.Clear();foreach(var pair in currentEnemies)previousEnemies.Add(pair.Key,pair.Value);
        float bestPickup=0;
        foreach(var pickup in weapon.powerups??System.Array.Empty<Round1Powerup>())
        {
            if(!pickup || !pickup.Available)continue;
            Vector2 position=Plane(pickup.Position);float travel=Vector2.Distance(origin,position)/Mathf.Max(.1f,speed);
            position.y-=pickup.fallSpeed*travel;
            if(position.y<player.screenMargin-.035f || position.y>.8f || position.x<0 || position.x>player.stageCamera.aspect)continue;
            float value=PickupValue(pickup.kind)/(1+travel*2);
            if(value>bestPickup){bestPickup=value;goal=Clamp(position);collecting=true;}
        }
        Vector2 preferred=Vector2.ClampMagnitude((goal-origin)/Mathf.Max(.001f,speed*.22f),1);
        float best=float.PositiveInfinity,bestRisk=0;Vector2 chosen=Vector2.zero;
        for(int i=-2;i<32;i++)
        {
            Vector2 candidate=i==-2?preferred:i==-1?Vector2.zero:new Vector2(Mathf.Cos((i%16)*Mathf.PI/8),Mathf.Sin((i%16)*Mathf.PI/8))*(i<16?1:.45f);
            float risk=Risk(origin,candidate*speed,Horizon);
            Vector2 end=Clamp(origin+candidate*speed*.3f);
            float score=risk+Vector2.Distance(end,goal)*4+(candidate-previousDirection).sqrMagnitude*.035f;
            // Keep room to escape on both sides; pickups can still draw the ship to an edge.
            score+=.02f/(.04f+Mathf.Min(end.x-player.screenMargin*player.stageCamera.aspect,(1-player.screenMargin)*player.stageCamera.aspect-end.x));
            if(score<best){best=score;chosen=candidate;bestRisk=risk;}
        }
        bool imminent=Risk(origin,chosen*speed,Mathf.Max(.16f,dt))>=60;
        bool trapped=bestRisk>=100;
        bool offensive=weapon.Bombs>=3 && (visibleEnemies>=10 || bossVisible && combat.HostileCount>=30);
        if(useBombs && bombCooldown<=0 && !weapon.BombActive && ((!weapon.Invincible && (imminent || trapped)) || offensive))
        {
            if(weapon.UseBomb()){BombsUsed++;bombCooldown=4;Activity="BOMB";}
        }
        else Activity=bestRisk>1?"DODGING":collecting?"PICKUP":"ATTACKING";
        Direction=chosen;previousDirection=chosen;
    }
    float PickupValue(Round1PickupKind kind)
    {
        switch(kind)
        {
            case Round1PickupKind.Power:return weapon.Level<4?9:1;
            case Round1PickupKind.BombStock:return weapon.Bombs<5?8:2;
            case Round1PickupKind.OneUp:case Round1PickupKind.TwoUp:case Round1PickupKind.ThreeUp:return 10;
            case Round1PickupKind.SpeedDown:return weapon.SpeedLevel>3?5:0;
            case Round1PickupKind.SpeedUp:return weapon.SpeedLevel<3?6:0;
            case Round1PickupKind.Bomber:return weapon.BombLevel<3?7:1;
            default:return 3;
        }
    }
    float Risk(Vector2 origin,Vector2 velocity,float horizon)
    {
        float total=0;
        foreach(var h in hazards)
        {
            if(h.starts>horizon || h.ends<0)continue;
            float nearest=float.PositiveInfinity,nearestTime=0;
            // Piecewise swept tests catch fast bullets and account for movement clamping at edges.
            const int steps=4;
            for(int i=0;i<steps;i++)
            {
                float t0=Mathf.Max(h.starts,horizon*i/steps),t1=Mathf.Min(h.ends,horizon*(i+1)/steps);
                if(t1<t0)continue;
                Vector2 a=Clamp(origin+velocity*t0),b=Clamp(origin+velocity*t1);
                float distance;
                if(h.beam)distance=SegmentGap(a,b,h.from,h.to);
                else distance=PointSegment(Vector2.zero,a-h.from-h.velocity*t0,b-h.from-h.velocity*t1);
                if(distance<nearest){nearest=distance;nearestTime=t0;}
            }
            float clearance=nearest-h.radius;
            if(clearance<.012f)total+=120*(1-nearestTime*.6f)+Mathf.Max(0,-clearance)*1000;
            else if(clearance<.07f)total+=Mathf.Pow(1-clearance/.07f,2)*3;
        }
        return total;
    }
    public static float PointSegment(Vector2 p,Vector2 a,Vector2 b)
    {var d=b-a;return Vector2.Distance(p,a+d*(d.sqrMagnitude>0?Mathf.Clamp01(Vector2.Dot(p-a,d)/d.sqrMagnitude):0));}
    public static float SegmentGap(Vector2 a,Vector2 b,Vector2 c,Vector2 d)
    {
        Vector2 u=b-a,v=d-c,w=c-a;float cross=u.x*v.y-u.y*v.x;
        if(Mathf.Abs(cross)>.000001f){float t=(w.x*v.y-w.y*v.x)/cross,s=(w.x*u.y-w.y*u.x)/cross;if(t>=0 && t<=1 && s>=0 && s<=1)return 0;}
        return Mathf.Min(Mathf.Min(PointSegment(a,c,d),PointSegment(b,c,d)),Mathf.Min(PointSegment(c,a,b),PointSegment(d,a,b)));
    }
}
