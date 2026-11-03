using System;
using System.Collections.Generic;
using UnityEngine;

// Original enemy hit shapes (PawnEnemy._collisions / EnemyCollisionModel) as circles in the enemy's local X/Z, in source
// units, from extract_enemy_colliders.py. Capsules and boxes are covered by rows of circles; an air enemy's point is one
// source unit (HybridCollisions scales the 2D collider by _scaleFactorZ), a simple-calc enemy's (meteors, Se01) 1.61, measured on the live original's colliders.
public static class Round1HitShapes
{
    [Serializable] class Circle { public float x,z,r; }
    [Serializable] class Model { public string model;public bool simpleCalc;public Circle[] circles; }
    [Serializable] class Data { public int version;public Model[] models; }
    static Dictionary<string,Vector3[]> shapes;
    // (x, z, r) per circle, or null when the model has no extracted shape.
    public static Vector3[] Get(string model)
    {
        if(shapes==null)
        {
            shapes=new Dictionary<string,Vector3[]>();
            var asset=Resources.Load<TextAsset>("Truxton/round1-enemy-hitshapes");
            // Other stages' models: tools/stage_combat/enemy_hitshapes.py over every model (same rules; it also applies each
            // shape's own rotation, which only moves Lb01's arms relative to this BG03 table). BG03's table stays first.
            var all=Resources.Load<TextAsset>("StageCombat/enemy-hitshapes");
            if(all)foreach(var m in JsonUtility.FromJson<Data>(all.text).models)
                if(m.circles!=null&&m.circles.Length>0)shapes[m.model]=Array.ConvertAll(m.circles,c=>new Vector3(c.x,c.z,c.r));
            if(asset)foreach(var m in JsonUtility.FromJson<Data>(asset.text).models)
                shapes[m.model]=Array.ConvertAll(m.circles,c=>new Vector3(c.x,c.z,c.r));
        }
        if(string.IsNullOrEmpty(model))return null;
        if(model.EndsWith("(Clone)"))model=model.Substring(0,model.Length-7);
        return shapes.TryGetValue(model,out var s)?s:null;
    }
}
