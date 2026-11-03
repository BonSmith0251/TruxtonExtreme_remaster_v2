using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public static class ReconstructionAssetAudit
{
    [Serializable] class Row{public string path;public int gameObjects,components,missingScripts;}
    [Serializable] class Report{public int prefabs,gameObjects,components,missingScripts,unloadable;public List<Row> issues=new List<Row>();}
    public static void Run()
    {
        ReconstructionEditor.SetupAndAudit();
        var report=new Report();
        foreach(var id in AssetDatabase.FindAssets("t:Prefab",new[]{"Assets/OriginalGame"}))
        {
            string p=AssetDatabase.GUIDToAssetPath(id);report.prefabs++;
            var o=AssetDatabase.LoadAssetAtPath<GameObject>(p);if(!o){report.unloadable++;report.issues.Add(new Row{path=p});continue;}
            var row=new Row{path=p};foreach(var t in o.GetComponentsInChildren<Transform>(true)){var cs=t.GetComponents<Component>();row.gameObjects++;row.components+=cs.Length;row.missingScripts+=cs.Count(x=>x==null);}
            report.gameObjects+=row.gameObjects;report.components+=row.components;report.missingScripts+=row.missingScripts;if(row.missingScripts>0)report.issues.Add(row);
        }
        var root=Path.GetFullPath(Path.Combine(Application.dataPath,"../../evidence/scene-integration"));Directory.CreateDirectory(root);
        File.WriteAllText(Path.Combine(root,"original-prefab-audit.json"),JsonUtility.ToJson(report,true));Debug.Log("RECONSTRUCTION_PREFAB_AUDIT_COMPLETE prefabs="+report.prefabs+" missingScripts="+report.missingScripts);
    }
}
