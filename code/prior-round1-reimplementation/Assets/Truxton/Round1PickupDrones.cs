using System;
using System.Collections.Generic;
using UnityEngine;

public class Round1PickupDrones : MonoBehaviour
{
    [Serializable] public class Entry { public float time;public int kind;public string source;public Vector3 offset;public bool table; }
    [Serializable] public class Data { public Entry[] events;public Vector3 start;public float initialSpeed,cruiseSpeed,slowSeconds,duration,health; }
    class Drone { public Round1Combat.Target target;public int id;public Entry entry; }
    readonly List<Drone> drones=new List<Drone>();
    Round1Combat combat;
    Round1PickupDroneLibrary library;
    Data data;
    int next;
    public int Spawned { get; private set; }
    public int CapacityMisses { get; private set; }
    public int ActiveCount { get {int n=0;foreach(var d in drones)if(d.target.active && d.target.id==d.id)n++;return n;} }
    public void Initialize(Round1Combat owner)
    {
        combat=owner;if(data!=null)return;
        library=Resources.Load<Round1PickupDroneLibrary>("Truxton/PickupDroneLibrary");
        if(!library || !library.prefab || !library.schedule)throw new InvalidOperationException("Original pickup drone assets are missing.");
        data=JsonUtility.FromJson<Data>(library.schedule.text);
    }
    public void ResetSchedule(float time)
    {
        foreach(var d in drones)if(d.target.active && d.target.id==d.id)combat.DespawnSourceTarget(d.target);
        drones.Clear();next=0;Spawned=CapacityMisses=0;
        // Skipped carriers still advance the shared ItemReferenceTable index (the ground boxes draw from it too).
        if(data!=null)while(next<data.events.Length && data.events[next].time<time){if(data.events[next].table)combat.weapon.NextTableItem();next++;}
    }
    public void Step(float time)
    {
        if(data==null || !combat.weapon.SimulationRunning)return;
        while(next<data.events.Length && data.events[next].time<=time)
        {
            var entry=data.events[next++];
            // EventEntryBehaviour._eventFire draws a table reward when the carrier enters, whether or not it is shot.
            var kind=entry.table?combat.weapon.NextTableItem():(Round1PickupKind)entry.kind;
            if(time-entry.time>=data.duration)continue;
            var target=combat.SpawnSourceTarget(library.prefab,Position(entry,time-entry.time),data.health);
            if(target==null){CapacityMisses++;continue;}
            target.sourceSpawn=true;target.isPickupDrone=true;target.pickupKind=kind;
            target.lockOn=false;target.blocksLaser=false;target.homingPriority=1000;
            // Pf_Item_Box01's EnemyCollisionModel circle, in the 200-unit frame the carrier is drawn in.
            var shape=Round1HitShapes.Get(library.prefab.name);target.radius=shape!=null?shape[0].z/200:.035f;
            target.sourceScale=Vector3.Distance(combat.weapon.player.WorldPoint(Vector2.zero),combat.weapon.player.WorldPoint(Vector2.up))/200;
            target.sourceRotation=Quaternion.Euler(0,180,180);
            drones.Add(new Drone{target=target,id=target.id,entry=entry});Spawned++;
        }
        for(int i=drones.Count-1;i>=0;i--)
        {
            var d=drones[i];var target=d.target;
            if(!target.active || target.id!=d.id){drones.RemoveAt(i);continue;}
            float age=Mathf.Max(0,time-d.entry.time);target.position=Position(d.entry,age)+target.nudge;
            if(age>=data.duration || target.position.y<-.12f){combat.DespawnSourceTarget(target);drones.RemoveAt(i);continue;}
            combat.PlaceSourceTarget(target);
        }
    }
    Vector2 Position(Entry entry,float age)
    {
        // Camera-plane adaptation: integrate the source 40 -> 11.5 speed transition,
        // then continue downward. Native MoveTo easing and carrier depth are not recreated.
        float duration=Mathf.Max(.001f,data.slowSeconds),t=Mathf.Min(age,duration);
        float distance=data.initialSpeed*t+(data.cruiseSpeed-data.initialSpeed)*t*t/(2*duration)+Mathf.Max(0,age-duration)*data.cruiseSpeed;
        var source=data.start+entry.offset;
        float aspect=Mathf.Max(.1f,combat.weapon.player.stageCamera.aspect);
        return new Vector2(.5f+source.x/(200*aspect),.5f+(source.z-distance)/200);
    }
}
