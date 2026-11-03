using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Moves assets by a JSON plan with AssetDatabase.MoveAsset, so every asset keeps its .meta/GUID, every serialized
// reference survives and nothing reimports. Writes a manifest (each step, and every asset's old path, new path and GUID)
// that rewrite_paths.py reads and that Undo replays backwards. Fixes Build Settings scene paths by GUID and deletes
// the plan's "emptied" folders when only folders are left in them.
//
// Put this file in any Editor folder, close the project in every Unity editor, then:
//   Unity -batchmode -quit -projectPath <project> -executeMethod LayoutMover.Run
//         -layoutPlan <abs>/layout-plan.json -layoutManifest <abs>/moves.json -logFile <abs>/move.log
//   (or the environment variables LAYOUT_PLAN / LAYOUT_MANIFEST). LayoutMover.Undo takes the same manifest.
// Plan: {"steps":[{"from":"Assets/A","to":"Assets/B/A"},...],"emptied":["Assets/Old"]}
public static class LayoutMover
{
    [Serializable] public class Step { public string from,to; }
    [Serializable] public class Plan { public Step[] steps=new Step[0];public string[] emptied=new string[0]; }
    [Serializable] public class Entry { public string from,to,guid; }
    [Serializable] public class Manifest { public List<Entry> steps=new List<Entry>();public List<Entry> assets=new List<Entry>();public List<string> removed=new List<string>();public List<string> errors=new List<string>(); }

    public static void Run()
    {
        string planPath=Argument("-layoutPlan","LAYOUT_PLAN"),manifestPath=Argument("-layoutManifest","LAYOUT_MANIFEST");
        var record=new Manifest();
        try
        {
            if(planPath==null || manifestPath==null)throw new ArgumentException("give -layoutPlan and -layoutManifest (or LAYOUT_PLAN / LAYOUT_MANIFEST)");
            var plan=JsonUtility.FromJson<Plan>(File.ReadAllText(planPath));
            // Not inside StartAssetEditing: a folder created for one step has to be visible to the next.
            foreach(var s in plan.steps)
            {
                string from=s.from.TrimEnd('/'),to=s.to.TrimEnd('/');
                bool folder=AssetDatabase.IsValidFolder(from);
                if(!folder && string.IsNullOrEmpty(AssetDatabase.AssetPathToGUID(from))){record.errors.Add("missing "+from);continue;}
                if(AssetDatabase.IsValidFolder(to) || File.Exists(to)){record.errors.Add("target exists "+to);continue;}
                var before=folder?AssetDatabase.FindAssets("",new[]{from}).Select(AssetDatabase.GUIDToAssetPath).Distinct().ToList():new List<string>{from};
                EnsureFolder(Parent(to));
                string error=AssetDatabase.MoveAsset(from,to);
                if(!string.IsNullOrEmpty(error)){record.errors.Add(from+" -> "+to+": "+error);continue;}
                record.steps.Add(new Entry{from=from,to=to,guid=AssetDatabase.AssetPathToGUID(to)});
                foreach(var p in before){string n=to+p.Substring(from.Length);record.assets.Add(new Entry{from=p,to=n,guid=AssetDatabase.AssetPathToGUID(n)});}
            }
            AssetDatabase.Refresh();
            foreach(var f in plan.emptied ?? new string[0])
            {
                string folder=f.TrimEnd('/');
                if(!AssetDatabase.IsValidFolder(folder))continue;
                bool onlyFolders=Directory.GetFiles(folder,"*",SearchOption.AllDirectories).All(x=>x.EndsWith(".meta"));
                if(onlyFolders && AssetDatabase.DeleteAsset(folder))record.removed.Add(folder);else record.errors.Add("not empty, kept: "+folder);
            }
            FixBuildScenes();
            AssetDatabase.SaveAssets();
        }
        catch(Exception e){record.errors.Add(e.ToString());Debug.LogException(e);}
        if(manifestPath!=null){Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(manifestPath)));File.WriteAllText(manifestPath,JsonUtility.ToJson(record,true));}
        Debug.Log($"[Layout] steps={record.steps.Count} assets={record.assets.Count} removed={record.removed.Count} errors={record.errors.Count}");
        foreach(var e in record.errors)Debug.LogError("[Layout] "+e);
        Exit(record.errors.Count==0?0:1);
    }

    // Puts every step back, last first, from the manifest Run wrote.
    public static void Undo()
    {
        string manifestPath=Argument("-layoutManifest","LAYOUT_MANIFEST");int failed=0;
        var record=JsonUtility.FromJson<Manifest>(File.ReadAllText(manifestPath));
        foreach(var folder in record.removed)EnsureFolder(folder);
        for(int i=record.steps.Count-1;i>=0;i--)
        {
            var s=record.steps[i];EnsureFolder(Parent(s.from));
            string error=AssetDatabase.MoveAsset(s.to,s.from);
            if(!string.IsNullOrEmpty(error)){failed++;Debug.LogError("[Layout] undo "+s.to+" -> "+s.from+": "+error);}
        }
        AssetDatabase.Refresh();FixBuildScenes();AssetDatabase.SaveAssets();
        Debug.Log($"[Layout] undo steps={record.steps.Count} failed={failed}");
        Exit(failed==0?0:1);
    }

    static void FixBuildScenes()
    {
        EditorBuildSettings.scenes=EditorBuildSettings.scenes.Select(s=>{
            string p=AssetDatabase.GUIDToAssetPath(s.guid.ToString());
            return new EditorBuildSettingsScene(string.IsNullOrEmpty(p)?s.path:p,s.enabled);}).ToArray();
    }
    static string Parent(string path)=>Path.GetDirectoryName(path).Replace('\\','/');
    static void EnsureFolder(string path)
    {
        if(string.IsNullOrEmpty(path) || AssetDatabase.IsValidFolder(path))return;
        EnsureFolder(Parent(path));AssetDatabase.CreateFolder(Parent(path),Path.GetFileName(path));
        FixFolderCase(path);
    }

    // CreateFolder can come back with another spelling: the asset database remembers a deleted folder's case
    // ("Player" was created as "player"). Rename through a temporary name, since a case-only move is refused.
    static string FixFolderCase(string path)
    {
        string name=Path.GetFileName(path),parent=Parent(path);
        string actual=Directory.Exists(parent)?Directory.GetDirectories(parent).Select(Path.GetFileName).FirstOrDefault(n=>string.Equals(n,name,StringComparison.OrdinalIgnoreCase)):null;
        if(actual==null || actual==name)return null;
        string from=parent+"/"+actual,tmp=path+"_casefix";
        string error=AssetDatabase.MoveAsset(from,tmp);
        if(string.IsNullOrEmpty(error))error=AssetDatabase.MoveAsset(tmp,path);
        Debug.Log($"[Layout] folder case {from} -> {path} {error}");
        return string.IsNullOrEmpty(error)?null:from+" -> "+path+": "+error;
    }

    // For a move made before FixFolderCase existed: corrects the case of every destination folder in the manifest.
    public static void FixCase()
    {
        var record=JsonUtility.FromJson<Manifest>(File.ReadAllText(Argument("-layoutManifest","LAYOUT_MANIFEST")));int failed=0;
        foreach(var folder in record.steps.Select(s=>Parent(s.to)).Distinct())
            for(string f=folder;f.Contains("/");f=Parent(f))
                if(FixFolderCase(f)!=null)failed++;
        AssetDatabase.Refresh();AssetDatabase.SaveAssets();
        Debug.Log($"[Layout] fixcase failed={failed}");
        Exit(failed==0?0:1);
    }
    static string Argument(string flag,string env)
    {
        var args=Environment.GetCommandLineArgs();int i=Array.IndexOf(args,flag);
        if(i>=0 && i+1<args.Length)return args[i+1];
        string v=Environment.GetEnvironmentVariable(env);return string.IsNullOrEmpty(v)?null:v;
    }
    // Leave an empty scene open before exiting a batch run: tearing down a heavy open scene during exit has crashed.
    static void Exit(int code)
    {
        if(!Application.isBatchMode)return;
        EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);
        EditorApplication.Exit(code);
    }
}
