using System;
using System.Collections.Generic;
using UnityEngine;

// Per-model gameplay data for every enemy of every stage, rebuilt from the original EnemyDatabase.asset by
// tools/stage_combat/enemy_database.py (decoding validated 173/173 against the Round 1 BG03 tables). Round 1's own
// tables stay authoritative for BG03 models; this is the fallback for the other stages' models.
public static class StageCombatData
{
    [Serializable] public class Item {public int drop,swapDrop;public string ruinName;}
    [Serializable] public class Model {public string model,key,size;public bool resolved,lockOn,blocksLaser,ground,rangeFire;public float health;public int score,priority;public Item item;}
    // One EnemyDatabase row; boss parts are rows with the boss key and a partsName (Bos07 arm40, leg60, ...).
    [Serializable] public class Row {public string key,partsName;public bool isBreakthrough,isLockOn,isDamageScore,isRateTarget;public float hitpoint;public int score,priority;}
    [Serializable] class Database {public Model[] models;public Row[] rows;}
    static Dictionary<string,Model> models;
    static List<Row> rows;
    // Part row by database key (model without "Pf_Ene_", e.g. "Bos07") and parts name; null when the database has none.
    public static Row GetPart(string key,string part)
    {
        if(rows==null){var asset=Resources.Load<TextAsset>("StageCombat/enemy-database");rows=asset?new List<Row>(JsonUtility.FromJson<Database>(asset.text).rows):new List<Row>();}
        return rows.Find(r=>r.key==key&&r.partsName==part);
    }

    public static Model Get(string model)
    {
        if(models==null)
        {
            models=new Dictionary<string,Model>();
            var asset=Resources.Load<TextAsset>("StageCombat/enemy-database");
            if(asset)foreach(var m in JsonUtility.FromJson<Database>(asset.text).models)if(m.resolved)models[m.model]=m;
        }
        return model!=null&&models.TryGetValue(model,out var found)?found:null;
    }
}
