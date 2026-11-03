using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Prefab health snapshot, keyed by GUID so a "before" and "after" taken around a move can be compared even though the
// paths changed (prefab_check_diff.py). For every prefab (or those under -prefabCheckScope): type (regular, variant,
// model), the variant's base, missing scripts, nested prefab instances and how many of them lost their asset, child
// count. For every scene in Build Settings (or -prefabCheckScenes all): prefab instances, instances whose asset is
// missing, missing scripts.
//   Unity -batchmode -projectPath <project> -executeMethod PrefabCheck.Run -prefabCheckOut <abs>/before.json
//         [-prefabCheckScope Assets/Prefabs] [-prefabCheckScenes build|all] -logFile <abs>/check.log
// Put it in any Editor folder; it changes nothing in the project.
public static class PrefabCheck
{
    [Serializable] public class PrefabRow { public string guid,path,type,baseGuid;public int missingScripts,nested,nestedMissing,children; }
    [Serializable] public class SceneRow { public string guid,path;public int instances,instancesMissing,missingScripts; }
    [Serializable] public class Report { public string unity;public List<PrefabRow> prefabs=new List<PrefabRow>();public List<SceneRow> scenes=new List<SceneRow>();public List<string> errors=new List<string>(); }

    public static void Run()
    {
        string output=Argument("-prefabCheckOut","PREFAB_CHECK_OUT"),scope=Argument("-prefabCheckScope","PREFAB_CHECK_SCOPE");
        string sceneMode=Argument("-prefabCheckScenes","PREFAB_CHECK_SCENES")??"build";
        var report=new Report{unity=Application.unityVersion};
        foreach(string guid in AssetDatabase.FindAssets("t:Prefab",scope!=null?new[]{scope}:null))
        {
            string path=AssetDatabase.GUIDToAssetPath(guid);
            try
            {
                var root=AssetDatabase.LoadAssetAtPath<GameObject>(path);if(!root){report.errors.Add("cannot load "+path);continue;}
                var type=PrefabUtility.GetPrefabAssetType(root);
                var row=new PrefabRow{guid=guid,path=path,type=type.ToString(),children=root.GetComponentsInChildren<Transform>(true).Length};
                if(type==PrefabAssetType.Variant){var source=PrefabUtility.GetCorrespondingObjectFromSource(root);row.baseGuid=source?AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(source)):"MISSING";}
                foreach(var t in root.GetComponentsInChildren<Transform>(true))
                {
                    row.missingScripts+=GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(t.gameObject);
                    if(t.gameObject!=root && PrefabUtility.IsAnyPrefabInstanceRoot(t.gameObject)){row.nested++;if(PrefabUtility.IsPrefabAssetMissing(t.gameObject))row.nestedMissing++;}
                }
                report.prefabs.Add(row);
            }
            catch(Exception e){report.errors.Add(path+": "+e.Message);}
        }
        var scenes=sceneMode=="all"?AssetDatabase.FindAssets("t:Scene",new[]{"Assets"}).Select(AssetDatabase.GUIDToAssetPath).ToArray()
            :EditorBuildSettings.scenes.Select(s=>s.path).Where(p=>File.Exists(p)).ToArray();
        foreach(string path in scenes)
        {
            try
            {
                var scene=EditorSceneManager.OpenScene(path,OpenSceneMode.Single);
                var row=new SceneRow{guid=AssetDatabase.AssetPathToGUID(path),path=path};
                foreach(var go in scene.GetRootGameObjects())foreach(var t in go.GetComponentsInChildren<Transform>(true))
                {
                    row.missingScripts+=GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(t.gameObject);
                    if(PrefabUtility.IsAnyPrefabInstanceRoot(t.gameObject)){row.instances++;if(PrefabUtility.IsPrefabAssetMissing(t.gameObject))row.instancesMissing++;}
                }
                report.scenes.Add(row);
            }
            catch(Exception e){report.errors.Add(path+": "+e.Message);}
        }
        EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);
        if(output!=null){Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(output)));File.WriteAllText(output,JsonUtility.ToJson(report,true));}
        Debug.Log($"[PrefabCheck] prefabs={report.prefabs.Count} missingScripts={report.prefabs.Sum(p=>p.missingScripts)} nestedMissing={report.prefabs.Sum(p=>p.nestedMissing)} scenes={report.scenes.Count} sceneInstances={report.scenes.Sum(s=>s.instances)} sceneMissing={report.scenes.Sum(s=>s.instancesMissing)} errors={report.errors.Count}");
        if(Application.isBatchMode)EditorApplication.Exit(report.errors.Count==0?0:1);
    }
    static string Argument(string flag,string env)
    {
        var args=Environment.GetCommandLineArgs();int i=Array.IndexOf(args,flag);
        if(i>=0 && i+1<args.Length)return args[i+1];
        string v=Environment.GetEnvironmentVariable(env);return string.IsNullOrEmpty(v)?null:v;
    }
}
