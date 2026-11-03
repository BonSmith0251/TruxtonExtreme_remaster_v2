using System;
using System.Collections.Generic;
using UnityEngine;

// Source Rotate events are linear, multi-turn Euler tweens, not shortest-arc
// quaternion blends. The native task-driven movement/attack system is not ported;
// route-dependent waits below use the remaster's route lengths and speed.
public sealed class Round1EnemyAnimation : MonoBehaviour
{
    sealed class Cue
    {
        public float start,duration;public Vector3 from,to;
        public Vector3 At(float time)=>Vector3.LerpUnclamped(from,to,duration<=0?1:Mathf.Clamp01((time-start)/duration));
    }
    sealed class Track
    {
        public Transform target;public Quaternion rest;public readonly List<Cue> cues=new List<Cue>();
        public Vector3 At(float time)
        {
            Vector3 pose=target?rest.eulerAngles:Vector3.zero;
            foreach(var cue in cues){if(time<cue.start)break;pose=cue.At(time);}return pose;
        }
    }
    readonly Dictionary<Transform,Quaternion> rest=new Dictionary<Transform,Quaternion>();
    readonly Dictionary<string,Track> tracks=new Dictionary<string,Track>();
    Quaternion entry;
    public Quaternion RootRotation { get; private set; }=Quaternion.identity;
    public Quaternion Facing { get; private set; }=Quaternion.identity;
    public int BoundRotationEvents { get; private set; }
    public int MissingBindings { get; private set; }

    public void ResetPose()
    {
        foreach(var pair in rest)if(pair.Key)pair.Key.localRotation=pair.Value;
        RootRotation=Facing=Quaternion.identity;tracks.Clear();BoundRotationEvents=MissingBindings=0;
    }
    public void Begin(Round1EnemyWaves.Definition definition,Vector3 entryAngles,Func<string,float> routeLength,float speed)
    {
        if(rest.Count==0)foreach(var t in GetComponentsInChildren<Transform>(true))if(t!=transform)rest[t]=t.localRotation;
        ResetPose();entry=Quaternion.Euler(entryAngles);
        float cursor=0,rotationEnd=0,routeEnd=0,speedEnd=0;
        foreach(var e in definition.events)
        {
            if(e.eventType==1 || e.eventType==20){cursor+=Mathf.Max(0,e.dotime);continue;}
            if(e.eventType==80)
            {
                int mask=e.intValue1==0?int.MaxValue:e.intValue1;
                if((mask&1)!=0)cursor=Mathf.Max(cursor,rotationEnd);
                if((mask&(64|256))!=0)cursor=Mathf.Max(cursor,routeEnd);
                if((mask&32)!=0)cursor=Mathf.Max(cursor,speedEnd);
                continue;
            }
            if(e.eventType==14)
            {
                speedEnd=cursor+Mathf.Max(0,e.dotime);
                speed=Mathf.Max(1,e.value0);continue;
            }
            if(e.eventType==15)
            {routeEnd=cursor+Mathf.Max(0,e.value0)+routeLength(e.stringValue)/Mathf.Max(1,speed);continue;}
            if(e.eventType!=2)continue;
            string path=e.nameValue??"";
            if(!tracks.TryGetValue(path,out var track))
            {
                // Empty source names mean the actor root; never rotate an arbitrary mesh.
                Transform target=path.Length==0?null:transform.Find(path);
                if(path.Length>0 && !target){MissingBindings++;Debug.LogWarning("Enemy rotation target missing: "+path,this);continue;}
                track=new Track{target=target,rest=target?rest[target]:Quaternion.identity};tracks.Add(path,track);
            }
            float start=cursor+Mathf.Max(0,e.value0),duration=Mathf.Max(0,e.dotime);
            // Awake-rate gates refer to source route progress. Initial rotations all
            // start at zero; later gates use the current remaster route duration.
            start=Mathf.Max(start,cursor+Mathf.Max(0,routeEnd-cursor)*Mathf.Clamp01(e.awakeRate));
            for(int i=0;i<=Mathf.Clamp(e.repeatCount,0,100);i++)
            {
                float at=start+i*(duration+Mathf.Max(0,e.repeatDelay));
                Vector3 from=track.At(at);
                track.cues.Add(new Cue{start=at,duration=duration,from=from,to=e.flag0!=0?e.vectorValue:from+e.vectorValue});
                rotationEnd=Mathf.Max(rotationEnd,at+duration);
            }
            track.cues.Sort((a,b)=>a.start.CompareTo(b.start));BoundRotationEvents++;
        }
    }
    public void Sample(float age,int lookAt,Vector3 direction,Vector3 before,Vector3 after)
    {
        Facing=entry;
        if(lookAt>=1 && lookAt<=6 && direction.sqrMagnitude>1e-8f)
        {
            // The native Forward/Back/Left/Right modes follow the travel tangent.
            // Centered sampling avoids abrupt heading changes at LUT/route joins.
            if((after-before).sqrMagnitude>1e-8f)direction=after-before;
            float yaw=Mathf.Atan2(direction.x,direction.z)*Mathf.Rad2Deg;
            float offset=lookAt==2?180:lookAt==3?90:lookAt==4?-90:0;
            Facing=Quaternion.Euler(0,yaw+offset,0);
        }
        else if(lookAt>=30 && lookAt<=32)
        {
            // Drift modes keep the nose fixed and bank about local Z. The native
            // accumulator depends on its mover; this centered path sample gives a
            // smooth, frame-rate independent camera-plane adaptation.
            Vector3 velocity=(after-before)/.16f;
            float limit=lookAt==30?20:lookAt==31?35:50;
            float bank=-limit*Mathf.Clamp(velocity.x/80,-1,1);
            Facing=entry*Quaternion.Euler(0,0,bank);
        }
        RootRotation=Quaternion.identity;
        foreach(var track in tracks.Values)
        {
            Quaternion pose=Quaternion.Euler(track.At(age));
            if(track.target)track.target.localRotation=pose;else RootRotation=pose;
        }
    }
}
