using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
public static class ReconstructionEditor
{
    static string Evidence {get {var p=Path.GetFullPath(Path.Combine(Application.dataPath,"../../evidence/scene-integration"));Directory.CreateDirectory(p);return p;}}
    [Serializable] public class SceneReport {public string path;public int roots,objects,components,missingScripts,missingReferences;public List<Node> hierarchy=new List<Node>();}
    [Serializable] public class Node {public string name,path,parent,transformType,globalId;public int sibling,layer;public bool active;public Vector3 localPosition,localScale;public Quaternion localRotation;public string[] components;}
    [Serializable] public class Report {public string unity,time;public int assetPaths;public List<SceneReport> scenes=new List<SceneReport>();}
    public static void SetupAndAudit()
    {
        var nativeSettings=new SerializedObject(Resources.FindObjectsOfTypeAll<PlayerSettings>().First());var input=nativeSettings.FindProperty("activeInputHandler");if(input==null)throw new Exception("Target input backend property missing");if(input.intValue!=2){input.intValue=2;nativeSettings.ApplyModifiedPropertiesWithoutUndo();}
        PlayerSettings.companyName="Reconstruction";PlayerSettings.productName="Truxton Extreme Reconstruction";
        PlayerSettings.SetScriptingBackend(BuildTargetGroup.Standalone,ScriptingImplementation.Mono2x);
        PlayerSettings.runInBackground=true;PlayerSettings.defaultScreenWidth=1280;PlayerSettings.defaultScreenHeight=720;
        Directory.CreateDirectory("Assets/Scenes");
        var hub=EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);
        var c=new GameObject("Hub camera").AddComponent<Camera>();c.backgroundColor=new Color(.025f,.04f,.06f);c.clearFlags=CameraClearFlags.SolidColor;
        new GameObject("Reconstruction hub — supplemental gameplay and provenance").AddComponent<ReconstructionHub>();
        EditorSceneManager.SaveScene(hub,"Assets/Scenes/Hub.unity");
        var paths=new List<string>{"Assets/Scenes/Hub.unity"};
        paths.AddRange(AssetDatabase.FindAssets("t:Scene",new[]{"Assets"}).Select(AssetDatabase.GUIDToAssetPath).Where(p=>p!="Assets/Scenes/Hub.unity"));
        EditorBuildSettings.scenes=paths.Select(p=>new EditorBuildSettingsScene(p,p.EndsWith("Round1.unity")||p.Contains("OriginalGame")||p.EndsWith("Hub.unity"))).ToArray();
        var report=new Report{unity=Application.unityVersion,time=DateTime.UtcNow.ToString("o"),assetPaths=AssetDatabase.GetAllAssetPaths().Length};
        foreach(string path in paths)
        {
            var scene=EditorSceneManager.OpenScene(path,OpenSceneMode.Single);var sr=new SceneReport{path=path,roots=scene.rootCount};
            foreach(var root in scene.GetRootGameObjects())foreach(var t in root.GetComponentsInChildren<Transform>(true))
            {
                var go=t.gameObject;var cs=go.GetComponents<Component>();sr.objects++;sr.components+=cs.Length;sr.missingScripts+=cs.Count(x=>x==null);
                sr.hierarchy.Add(new Node{globalId=GlobalObjectId.GetGlobalObjectIdSlow(go).ToString(),name=go.name,path=GetPath(t),parent=t.parent?GetPath(t.parent):null,sibling=t.GetSiblingIndex(),layer=go.layer,active=go.activeSelf,transformType=t.GetType().FullName,localPosition=t.localPosition,localRotation=t.localRotation,localScale=t.localScale,components=cs.Select(x=>x?x.GetType().AssemblyQualifiedName:"MISSING_SCRIPT").ToArray()});
                foreach(var co in cs)if(co)try{var so=new SerializedObject(co);var it=so.GetIterator();while(it.Next(true))if(it.propertyType==SerializedPropertyType.ObjectReference&&it.objectReferenceValue==null&&it.objectReferenceInstanceIDValue!=0)sr.missingReferences++;}catch(Exception e){Debug.LogWarning("Audit "+co+": "+e.Message);}
            }
            report.scenes.Add(sr);
        }
        EditorSceneManager.OpenScene("Assets/Scenes/Hub.unity",OpenSceneMode.Single);AssetDatabase.SaveAssets();
        File.WriteAllText(Path.Combine(Evidence,"editor-scene-audit.json"),JsonUtility.ToJson(report,true));Debug.Log("RECONSTRUCTION_AUDIT_COMPLETE scenes="+report.scenes.Count);
    }
    static string GetPath(Transform t){return t.parent?GetPath(t.parent)+"/"+t.name:t.name;}
    public static void Build()
    {
        Directory.CreateDirectory("../Build");
        var result=BuildPipeline.BuildPlayer(EditorBuildSettings.scenes.Where(s=>s.enabled).Select(s=>s.path).ToArray(),"../Build/TruxtonExRecon.exe",BuildTarget.StandaloneWindows64,BuildOptions.Development);
        File.WriteAllText(Path.Combine(Evidence,"build-result.json"),"{\"result\":\""+result.summary.result+"\",\"errors\":"+result.summary.totalErrors+",\"warnings\":"+result.summary.totalWarnings+",\"bytes\":"+result.summary.totalSize+"}");
        if(result.summary.result!=UnityEditor.Build.Reporting.BuildResult.Succeeded)ReconstructionExit.Quit(1);
    }
    // Release player build outside the project (D: is nearly full; a short disk made Bee copy StreamingAssets movies as 0 bytes).
    // TRUXTON_BUILD_DIR overrides the folder; refuses to start with less than 6 GB free there.
    public static void BuildRelease()
    {
        var dir=Environment.GetEnvironmentVariable("TRUXTON_BUILD_DIR");if(string.IsNullOrEmpty(dir))dir="C:/Builds/TruxtonExRecon";
        Directory.CreateDirectory(dir);
        long free=new DriveInfo(Path.GetPathRoot(Path.GetFullPath(dir))).AvailableFreeSpace;
        if(free<6L<<30){Debug.LogError("BUILD_RELEASE_NO_SPACE free="+(free>>20)+"MB at "+dir);ReconstructionExit.Quit(1);return;}
        var result=BuildPipeline.BuildPlayer(EditorBuildSettings.scenes.Where(s=>s.enabled).Select(s=>s.path).ToArray(),Path.Combine(dir,"Truxton Extreme Reconstruction.exe"),BuildTarget.StandaloneWindows64,BuildOptions.None);
        File.WriteAllText(Path.Combine(Evidence,"build-release-result.json"),"{\"result\":\""+result.summary.result+"\",\"dir\":\""+dir+"\",\"errors\":"+result.summary.totalErrors+",\"warnings\":"+result.summary.totalWarnings+",\"bytes\":"+result.summary.totalSize+"}");
        Debug.Log("BUILD_RELEASE_RESULT "+result.summary.result+" "+dir);
        if(result.summary.result!=UnityEditor.Build.Reporting.BuildResult.Succeeded)ReconstructionExit.Quit(1);
    }
}
