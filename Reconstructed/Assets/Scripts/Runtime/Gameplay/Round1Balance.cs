using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable] public class Round1DamageProfile { public string name;public float first,continuous; }
[Serializable] public class Round1EnemyHealth { public string name;public float health; }
[Serializable] public class Round1Balance
{
    public float playerHealth,hostileDamage,continuousHz,bossHealth,bombDuration;
    public float[] bombDamageScales;
    public Round1DamageProfile[] weapons,bombs;
    public Round1EnemyHealth[] enemies;
    static Round1Balance current;
    public static Round1Balance Current
    {
        get
        {
            if(current!=null)return current;
            var asset=Resources.Load<TextAsset>("Truxton/round1-combat-balance");
            if(!asset)throw new InvalidOperationException("Extracted combat balance is missing.");
            current=JsonUtility.FromJson<Round1Balance>(asset.text);
            if(current.weapons.Length!=7 || current.bombs.Length!=3 || current.enemies.Length!=11 || current.continuousHz<=0)
                throw new InvalidOperationException("Incomplete combat balance.");
            return current;
        }
    }
    public float EnemyHealth(string model)
    {
        foreach(var enemy in enemies)if(enemy.name==model)return enemy.health;
        var row=StageCombatData.Get(model);if(row!=null)return row.health;
        throw new InvalidOperationException("Missing original enemy HP: "+model);
    }
}

// Original first/stay collision amounts, sampled at a fixed remaster 60 Hz.
// One stream per projectile/beam/bomb; target IDs change when pooled enemies respawn.
public sealed class Round1DamageStream
{
    sealed class Contact { public double time;public long ticks;public bool touched; }
    readonly Dictionary<int,Contact> contacts=new Dictionary<int,Contact>();
    readonly List<int> expired=new List<int>();
    public void Clear(){contacts.Clear();}
    public void Begin(){foreach(var contact in contacts.Values)contact.touched=false;}
    public void Hit(Round1Combat combat,Round1Combat.Target target,Round1DamageProfile profile,float dt)
    {
        if(!target.active || target.invulnerable)return;
        bool fresh=!contacts.TryGetValue(target.id,out var contact);
        if(fresh){contact=new Contact();contacts.Add(target.id,contact);}
        contact.touched=true;contact.time+=Math.Max(0,dt);
        long ticks=Math.Max(0,(long)Math.Ceiling(contact.time*Round1Balance.Current.continuousHz-0.0001)-1);
        float damage=(fresh?profile.first:0)+(ticks-contact.ticks)*profile.continuous;
        contact.ticks=ticks;combat.Damage(target,damage);
    }
    public void End()
    {
        expired.Clear();foreach(var pair in contacts)if(!pair.Value.touched)expired.Add(pair.Key);
        foreach(int id in expired)contacts.Remove(id);
    }
    public bool Segment(Round1Combat combat,Vector2 from,Vector2 to,float radius,Round1DamageProfile profile,float dt)
    {
        Begin();bool hit=false;
        foreach(var target in combat.Targets)
            if(target.active && !target.invulnerable && combat.HitGap(target,from,to)<=radius)
            {Hit(combat,target,profile,dt);hit=true;}
        End();return hit;
    }
}
