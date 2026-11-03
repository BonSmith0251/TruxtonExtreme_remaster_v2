using System;
using System.Collections.Generic;
using UnityEngine;

// Ene_Md01's seven native-generated RouteEvent programs, including stopped fire points.
public sealed class Round1Md01Motion
{
    [Serializable] public class Program { public int index;public Round1EnemyWaves.ActionData[] events; }
    [Serializable] public class Library { public Program[] patterns;public Round1EnemyWaves.Route[] routes;public float driftArc,driftSpeed,driftReturnSpeed; }
    static Library library;
    public static Library Source
    {
        get
        {
            if(library!=null)return library;
            var asset=Resources.Load<TextAsset>("Truxton/md01-motion");
            if(!asset)throw new InvalidOperationException("Missing recovered Md01 programs");
            library=JsonUtility.FromJson<Library>(asset.text);
            foreach(var r in library.routes)for(int i=1;i<r.points.Length;i++)r.length+=Vector3.Distance(r.points[i-1],r.points[i]);
            return library;
        }
    }
    public static float RouteLength(string name)=>Array.Find(Source.routes,r=>r.name==name)?.length??0;
    public static Round1EnemyWaves.Definition Definition(Round1EnemyWaves.Definition original,int index)
    {
        var program=Array.Find(Source.patterns,p=>p.index==index);
        if(program==null)throw new InvalidOperationException("Unknown original Md01 index "+index);
        return new Round1EnemyWaves.Definition{id=original.id,name=original.name,model=original.model,attribute=original.attribute,
            duration=original.duration,position=original.position,placements=original.placements,repeats=original.repeats,
            routes=original.routes,events=program.events};
    }
    sealed class Segment { public float start,duration;public Vector3 origin;public Round1EnemyWaves.Route route; }
    readonly List<Segment> segments=new List<Segment>();
    readonly Quaternion entry;
    readonly Vector3 origin;
    Vector3 end;
    int ticks;
    float roll,lastRoll;
    public float Duration { get; private set; }
    public Vector3 Position { get; private set; }
    public Quaternion Facing { get; private set; }

    public Round1Md01Motion(Vector3 start,float speed,Vector3 rotation,Round1EnemyWaves.ActionData[] events)
    {
        origin=end=Position=start;entry=Facing=Quaternion.Euler(rotation);
        float cursor=0,routeEnd=0;
        foreach(var e in events)
        {
            if(e.eventType==1){cursor+=e.dotime;continue;}
            if(e.eventType==80){cursor=Mathf.Max(cursor,routeEnd);continue;}
            if(e.eventType!=15)continue;
            var route=Array.Find(Source.routes,r=>r.name==e.stringValue);
            if(route==null)throw new InvalidOperationException("Missing Md01 route "+e.stringValue);
            float duration=route.length/Mathf.Max(.0001f,speed);
            segments.Add(new Segment{start=cursor,duration=duration,origin=end,route=route});
            end+=route.points[route.points.Length-1];routeEnd=cursor+duration;
        }
        Duration=Mathf.Max(cursor,routeEnd);
    }
    // EasingUtility.Easing01(7): cosine ease-in/out with the original 0.1-degree lookup.
    public static float Ease(float t)
    {
        t=Mathf.Clamp01(t);
        float angle=(t<.5f?t:1-t)*180;
        float c=Mathf.Cos(((int)(angle*10))*.1f*Mathf.Deg2Rad);
        return t<.5f?(1-c)*.5f:(1+c)*.5f;
    }
    Segment Active(float age)
    {
        foreach(var s in segments)if(age>=s.start && age<s.start+s.duration)return s;
        return null;
    }
    public Vector3 Sample(float age)
    {
        Vector3 p=origin;
        foreach(var s in segments)
        {
            if(age<s.start)return p;
            if(age<s.start+s.duration)return s.origin+s.route.Sample(Ease((age-s.start)/s.duration));
            p=s.origin+s.route.points[s.route.points.Length-1];
        }
        return p;
    }
    public void Advance(float age)
    {
        const float tick=1f/60;
        int count=Mathf.FloorToInt(Mathf.Max(0,age)*60+.0001f);
        while(ticks<count)
        {
            lastRoll=roll;
            var s=Active((ticks+.5f)*tick);
            if(s!=null)
            {
                // _getRotate samples at the eased progress and one raw-progress step ahead.
                float progress=Ease(((ticks+1)*tick-s.start)/s.duration);
                float dx=s.route.Sample(progress+tick/s.duration).x-s.route.Sample(progress).x;
                float delta=dx*Source.driftSpeed;
                if(Mathf.Abs(delta)<.2f)roll=Mathf.MoveTowards(roll,0,Source.driftReturnSpeed*tick);
                else roll+=delta*(delta*roll<0?2:.25f);
                roll=Mathf.Clamp(roll,-100,100);
            }
            ticks++;
        }
        Position=Sample(age);
        float smoothRoll=Mathf.Lerp(lastRoll,roll,Mathf.Clamp01(age*60-ticks));
        Facing=entry*Quaternion.Euler(0,0,smoothRoll*Source.driftArc/100);
    }
}
