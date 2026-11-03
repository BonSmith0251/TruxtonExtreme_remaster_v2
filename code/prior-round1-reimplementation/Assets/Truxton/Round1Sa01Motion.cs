using UnityEngine;

// Sa01 RouteEvent 6: bounded player pursuit, followed by straight travel.
// Native steering uses nominal 60 Hz angle steps and a 0.1-degree trig table.
public sealed class Round1Sa01Motion
{
    // MainCamera: 20 degree vertical FOV; InGameManager.SetupCameraPosition
    // places it at (0,400,0), looking down +90 degrees. Keep source altitude.
    public static float ViewHeight(float altitude=0)=>2*(400-altitude)*Mathf.Tan(10*Mathf.Deg2Rad);
    public static Vector2 ToViewport(Vector3 source,float aspect)
    {
        float height=ViewHeight(source.y);
        return new Vector2(.5f+source.x/(height*aspect),.5f+source.z/height);
    }
    public static Vector3 PlayerFromViewport(Vector2 viewport,float aspect)
    {
        float height=ViewHeight();
        return new Vector3((viewport.x-.5f)*height*aspect,0,(viewport.y-.5f)*height);
    }
    const float Tick=1f/60;
    readonly float speed,homingTime,duration,nearRadiusSquared,sin,cos;
    Vector3 position,direction,lastPlayer;
    int ticks;
    float lastAge;
    public Vector3 Position { get; private set; }
    public Vector3 Direction=>direction;

    public Round1Sa01Motion(Vector3 origin,Vector3 player,float moveSpeed,Round1EnemyWaves.ActionData rule)
    {
        position=Position=origin;lastPlayer=player;speed=moveSpeed;
        direction=rule.vectorValue.normalized;direction.y=0;
        homingTime=Mathf.Max(0,rule.value1);duration=Mathf.Max(0,rule.dotime);
        nearRadiusSquared=rule.intValue1*rule.intValue1;
        float angle=(int)(rule.value0*10)*.1f*Mathf.Deg2Rad;
        sin=Mathf.Sin(angle);cos=Mathf.Cos(angle);
    }

    public void Advance(float age,Vector3 player)
    {
        age=Mathf.Max(lastAge,age);float end=Mathf.Min(age,duration);
        int next=Mathf.FloorToInt(end*60+.0001f);
        while(ticks<next)
        {
            float at=(ticks+1)*Tick;
            var target=Vector3.Lerp(lastPlayer,player,age>lastAge?(at-lastAge)/(age-lastAge):1);
            var aim=target-position;aim.y=0;
            if(ticks*Tick<homingTime && aim.sqrMagnitude>=nearRadiusSquared)
                direction=Turn(direction,aim,sin,cos);
            position+=direction*(speed*Tick);ticks++;
        }
        // Sub-tick presentation avoids 60 Hz position stair-steps at higher refresh rates.
        Position=position+direction*(speed*Mathf.Max(0,end-ticks*Tick));
        lastAge=age;lastPlayer=player;
    }

    public static Vector3 Turn(Vector3 current,Vector3 aim,float sin,float cos)
    {
        Vector3 target=aim.normalized;
        var a=new Vector3(cos*current.x-sin*current.z,0,sin*current.x+cos*current.z);
        if(Vector3.Dot(target,current)>=Vector3.Dot(a,current))return target;
        var b=new Vector3(cos*current.x+sin*current.z,0,-sin*current.x+cos*current.z);
        return Vector3.Dot(a,aim)>=Vector3.Dot(b,aim)?a:b;
    }
}
