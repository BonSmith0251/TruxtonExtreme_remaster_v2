using System;
using UnityEngine;

[Serializable] public class Round1WeaponTiming { public int kind,ammoVolleys;public float interval,textureSeconds,speed; }
[Serializable] public class Round1TargetRules { public string name;public bool lockOn,blocksLaser;public int priority; }
[Serializable] public class Round1WeaponBehavior
{
    public Round1WeaponTiming[] profiles;
    public string[] emitters;
    public Round1TargetRules[] enemies;
    public float homingStart,homingEnd,homingDegreesPerFrame,growDistance,growTime,growStay,growDecay,growScale,childAngle,childFirstDamage,childStayDamage;
    static Round1WeaponBehavior current;
    public static Round1WeaponBehavior Current
    {
        get
        {
            if(current!=null)return current;
            var asset=Resources.Load<TextAsset>("Truxton/player-weapon-behavior");
            if(!asset)throw new InvalidOperationException("Original player weapon behavior is missing.");
            current=JsonUtility.FromJson<Round1WeaponBehavior>(asset.text);return current;
        }
    }
    public void Configure(Round1Combat.Target target,string model)
    {
        foreach(var entry in enemies)if(entry.name==model)
        {target.lockOn=entry.lockOn;target.blocksLaser=entry.blocksLaser;target.homingPriority=entry.priority;return;}
    }
}
