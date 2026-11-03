using System;
using System.Collections.Generic;
using UnityEngine;

// The native EnemyMover event program for spline movers (Me01, Sd01_8, ...), frame-stepped at 60 Hz.
// Checked on recordings/ash-r1-stage01-nofire-20261027: Me01 follows its eight routes within about 2 units for 24 s.
//   15 starts a route from the current position and follows it by distance at the current speed;
//   14 ramps the speed linearly to value0 over dotime;
//    2 starts a rotation lasting dotime (its pose is Round1EnemyAnimation's);
//    1 waits dotime;
//   80 waits until the current route has ended and every started rotation has finished.
// These programs don't read the player, so the whole path is computed once at spawn.
public sealed class Round1RouteProgram
{
    const float Tick=1f/60;
    readonly List<Vector3> path=new List<Vector3>();
    public float Duration { get; }

    // Only programs made of these events: route chains with speed ramps, rotations, waits, flags and fire cues.
    // Loops and player-relative events (5, 6, 12, 20, 101, ...) stay with their specialised or generic movers.
    static readonly HashSet<int> Supported=new HashSet<int>{1,2,8,10,11,14,15,80,83};
    public static bool Applies(Round1EnemyWaves.Definition d)=>Array.FindAll(d.events,e=>e.eventType==15).Length>1 && Array.TrueForAll(d.events,e=>Supported.Contains(e.eventType));

    public Round1RouteProgram(Vector3 origin,float speed,Round1EnemyWaves.ActionData[] events,IReadOnlyDictionary<string,Round1EnemyWaves.Route> routes,float seconds)
    {
        Round1EnemyWaves.Route route=null;Vector3 basePosition=origin,position=origin;
        float distance=0,rotationEnd=0,wait=-1,rampStart=0,rampFrom=0,rampTo=0,rampTime=0;bool ramping=false;int next=0;
        int frames=Mathf.CeilToInt(seconds*60)+1;
        for(int f=0;f<frames;f++)
        {
            float t=f*Tick;
            while(next<events.Length)
            {
                var e=events[next];
                if(e.eventType==15)
                {
                    if(!routes.TryGetValue(e.stringValue??"",out var r)){next++;continue;}
                    route=r;distance=0;basePosition=position;next++;continue;
                }
                if(e.eventType==14){ramping=true;rampStart=t;rampFrom=speed;rampTo=e.value0;rampTime=Mathf.Max(1e-6f,e.dotime);next++;continue;}
                if(e.eventType==2){rotationEnd=Mathf.Max(rotationEnd,t+e.dotime);next++;continue;}
                if(e.eventType==1)
                {
                    if(wait<0)wait=t+e.dotime;
                    if(t<wait)break;
                    wait=-1;next++;continue;
                }
                if(e.eventType==80)
                {
                    bool routeDone=route==null || distance>=route.length;
                    if(!routeDone || t<rotationEnd)break;
                    next++;continue;
                }
                next++;
            }
            if(ramping)
            {
                float u=Mathf.Clamp01((t-rampStart)/rampTime);speed=Mathf.Lerp(rampFrom,rampTo,u);
                if(u>=1)ramping=false;
            }
            if(route!=null)
            {
                distance+=speed*Tick;
                position=basePosition+(distance>=route.length?route.points[route.points.Length-1]:route.Sample(distance/Mathf.Max(.0001f,route.length)));
            }
            path.Add(position);
        }
        Duration=seconds;
    }
    // Frame 0 is the spawn frame, already one movement tick along (Round1EnemyWaves passes age including that tick).
    public Vector3 Sample(float age)
    {
        float f=Mathf.Clamp(age*60-1,0,path.Count-1);int i=Mathf.FloorToInt(f);
        return i>=path.Count-1?path[path.Count-1]:Vector3.Lerp(path[i],path[i+1],f-i);
    }
}
