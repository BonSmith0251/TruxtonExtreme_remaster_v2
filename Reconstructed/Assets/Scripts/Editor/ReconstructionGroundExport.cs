using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

// Export only: the Animator states (name, clip, speed, length, curves sampled at 60 Hz) and EnemyTurret settings of
// every ground-enemy model in every stage schedule, in the round1-ground-animations.json format that
// Round1GroundEnemies reads. Read through Unity serialization from the original prefabs (OriginalGame first), so no
// stub code runs. The BG03 models are compared with the old extractor's table by tools/stage_enemies/build_ground_enemies.py.
// Batch: -executeMethod ReconstructionGroundExport.Export
public static class ReconstructionGroundExport
{
    const string Output="Assets/Resources/StageEnemies/ground-animations.json";
    [Serializable] class Curve {public string path,property;public float[] times,values;}
    [Serializable] class State {public string name,clip;public float speed,length;public Curve[] curves;}
    [Serializable] class Turret {public string path;public float rollSpeed,delay,rollAngle,minAngle,maxAngle;public bool rotX,rotY,rotZ,ground,parent;}
    [Serializable] class Model {public string model,prefab;public State[] states;public Turret[] turrets;}
    [Serializable] class Data {public int version=1;public string note;public List<Model> models=new List<Model>();}

    public static void Export()
    {
        var names=new SortedSet<string>();
        foreach(var path in Directory.GetFiles("Assets/Resources/StageEnemies","BG0*.json"))
        {
            var d=JsonUtility.FromJson<StageEnemies.StageData>(File.ReadAllText(path));
            var defs=d.definitions.ToDictionary(x=>x.id);
            foreach(var e in d.events)if(e.ground&&defs.TryGetValue(e.enemy,out var def))names.Add(def.model);
        }
        var data=new Data{note="ground enemy Animator states and EnemyTurret settings (Editor/ReconstructionGroundExport.cs)"};
        foreach(var name in names)
        {
            var prefabPath=FindPrefab(name);if(prefabPath==null){Debug.LogWarning("Ground export: no prefab "+name);continue;}
            var prefab=AssetDatabase.LoadAssetAtPath<GameObject>(prefabPath);
            data.models.Add(new Model{model=name,prefab=prefabPath,states=States(prefab),turrets=Turrets(prefab)});
        }
        File.WriteAllText(Output,JsonUtility.ToJson(data,true));
        AssetDatabase.ImportAsset(Output);
        Debug.Log("Ground export: "+data.models.Count+" models, "+data.models.Sum(m=>m.states.Length)+" states, "+data.models.Sum(m=>m.turrets.Length)+" turrets");
    }
    static string FindPrefab(string name)
    {
        var paths=AssetDatabase.FindAssets(name+" t:Prefab").Select(AssetDatabase.GUIDToAssetPath).Where(p=>Path.GetFileNameWithoutExtension(p)==name).ToList();
        return paths.FirstOrDefault(p=>p.StartsWith("Assets/OriginalGame"))??paths.FirstOrDefault();
    }
    static string PathOf(Transform t,Transform root)
    {
        var parts=new List<string>();for(;t&&t!=root;t=t.parent)parts.Insert(0,t.name);return string.Join("/",parts);
    }
    static State[] States(GameObject prefab)
    {
        var list=new List<State>();
        foreach(var animator in prefab.GetComponentsInChildren<Animator>(true))
        {
            var controller=animator.runtimeAnimatorController as AnimatorController;if(!controller)continue;
            string prefix=PathOf(animator.transform,prefab.transform);
            foreach(var layer in controller.layers)foreach(var child in layer.stateMachine.states)
            {
                var s=child.state;var clip=s.motion as AnimationClip;
                var state=new State{name=s.name,clip=clip?clip.name:"",speed=s.speed,length=clip?clip.length:0,curves=new Curve[0]};
                if(clip)
                {
                    var curves=new List<Curve>();
                    foreach(var b in AnimationUtility.GetCurveBindings(clip))
                    {
                        if(b.type!=typeof(Transform))continue;
                        var curve=AnimationUtility.GetEditorCurve(clip,b);int n=Mathf.Max(1,Mathf.RoundToInt(clip.length*60));
                        var times=new float[n+1];var values=new float[n+1];
                        for(int i=0;i<=n;i++){times[i]=(float)Math.Round(clip.length*i/n,5);values[i]=(float)Math.Round(curve.Evaluate(times[i]),4);}
                        curves.Add(new Curve{path=string.IsNullOrEmpty(prefix)?b.path:string.IsNullOrEmpty(b.path)?prefix:prefix+"/"+b.path,property=b.propertyName,times=times,values=values});
                    }
                    state.curves=curves.ToArray();
                }
                list.Add(state);
            }
        }
        return list.ToArray();
    }
    static Turret[] Turrets(GameObject prefab)
    {
        var list=new List<Turret>();
        foreach(var mb in prefab.GetComponentsInChildren<MonoBehaviour>(true))
        {
            if(!mb)continue;var so=new SerializedObject(mb);var speed=so.FindProperty("_RollSpeed");if(speed==null)continue;
            float F(string p)=>so.FindProperty(p)?.floatValue??0;bool B(string p)=>so.FindProperty(p)?.boolValue??false;
            list.Add(new Turret{path=PathOf(mb.transform,prefab.transform),rollSpeed=speed.floatValue,delay=F("_delayWait"),rollAngle=F("_RollAngle"),minAngle=F("_MinAngle"),maxAngle=F("_MaxAngle"),
                rotX=B("_isRotX"),rotY=B("_isRotY"),rotZ=B("_isRotZ"),ground=B("_isGround"),parent=B("_isParent")});
        }
        return list.ToArray();
    }
}
