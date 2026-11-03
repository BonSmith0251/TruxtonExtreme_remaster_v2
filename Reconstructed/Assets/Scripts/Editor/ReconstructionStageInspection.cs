using System;
using System.IO;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
public static class ReconstructionStageInspection
{
    [Serializable] class Entry {public string scene,prefab,prefabGuid,status="Derived editor inspection scene using unmodified recovered prefab instance. Original gameplay methods and custom render passes remain incomplete.";public int objects,structuralMismatches;}
    [Serializable] class Report {public List<Entry> entries=new List<Entry>();}
    public static void Create()
    {
        Directory.CreateDirectory("Assets/Scenes/StageInspection");var report=new Report();
        for(int i=1;i<=8;i++)
        {
            string key="BG"+i.ToString("00");string path="Assets/OriginalGame/Samples/Prefabs/Reference/Stage/"+key+"Stage.prefab";var asset=AssetDatabase.LoadAssetAtPath<GameObject>(path);if(!asset){Debug.LogWarning("Source stage inspection prefab absent "+path);continue;}
            var scene=EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);var instance=(GameObject)PrefabUtility.InstantiatePrefab(asset,scene);
            var original=asset.GetComponentsInChildren<Transform>(true);var clone=instance.GetComponentsInChildren<Transform>(true);int mismatch=original.Length==clone.Length?0:1;
            for(int n=0;n<Math.Min(original.Length,clone.Length);n++){var a=original[n];var b=clone[n];if(a.name!=b.name||a.localPosition!=b.localPosition||a.localRotation!=b.localRotation||a.localScale!=b.localScale||a.gameObject.activeSelf!=b.gameObject.activeSelf||a.gameObject.layer!=b.gameObject.layer)mismatch++;}
            string dest="Assets/Scenes/StageInspection/StageInspection_"+key+".unity";EditorSceneManager.SaveScene(scene,dest);report.entries.Add(new Entry{scene=dest,prefab=path,prefabGuid=AssetDatabase.AssetPathToGUID(path),objects=clone.Length,structuralMismatches=mismatch});
        }
        string evidence=Path.GetFullPath(Path.Combine(Application.dataPath,"../../evidence/scene-integration"));Directory.CreateDirectory(evidence);File.WriteAllText(Path.Combine(evidence,"stage-inspection-provenance.json"),JsonUtility.ToJson(report,true));
    }
}
