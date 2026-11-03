using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
// Test fixture for the unity-project-layout skill.
public static class LayoutTestBuilder
{
    public static void Setup()
    {
        var mat=new Material(Shader.Find("Custom/Tinted")){name="red"};AssetDatabase.CreateAsset(mat,"Assets/Game/Art/red.mat");
        var go=GameObject.CreatePrimitive(PrimitiveType.Cube);go.name="Ship";go.AddComponent<Player>();go.GetComponent<MeshRenderer>().sharedMaterial=mat;
        Directory.CreateDirectory("Assets/Game/Prefabs");
        var prefab=PrefabUtility.SaveAsPrefabAsset(go,"Assets/Game/Prefabs/Ship.prefab");Object.DestroyImmediate(go);
        if(!prefab.GetComponent<Player>())throw new System.Exception("Ship.prefab saved without its Player script (scripts not imported yet)");
        var scene=EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);
        PrefabUtility.InstantiatePrefab(prefab);Directory.CreateDirectory("Assets/Game/Scenes");
        EditorSceneManager.SaveScene(scene,"Assets/Game/Scenes/Main.unity");
        EditorBuildSettings.scenes=new[]{new EditorBuildSettingsScene("Assets/Game/Scenes/Main.unity",true)};
        var guids=new[]{"Assets/Game/Art/red.mat","Assets/Game/Prefabs/Ship.prefab","Assets/Game/Scenes/Main.unity","Assets/Game/Shaders/Tinted.shader","Assets/Game/Code/Player.cs"}.Select(p=>p+"="+AssetDatabase.AssetPathToGUID(p));
        File.WriteAllLines("../guids-before.txt",guids);AssetDatabase.SaveAssets();
        Debug.Log("[LayoutTest] setup done");
    }
    public static void Verify()
    {
        var lines=new System.Collections.Generic.List<string>();
        void Check(string name,bool ok,string detail=""){lines.Add((ok?"PASS ":"FAIL ")+name+" "+detail);}
        var before=File.ReadAllLines("../guids-before.txt").Select(l=>l.Split('=')).ToDictionary(p=>p[1],p=>p[0]);
        foreach(var kv in before){string now=AssetDatabase.GUIDToAssetPath(kv.Key);Check("guid kept "+Path.GetFileName(kv.Value),now.Length>0 && now!=kv.Value,kv.Value+" -> "+now);}
        var prefab=AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Ship.prefab");
        Check("prefab keeps material",prefab && prefab.GetComponent<MeshRenderer>().sharedMaterial && prefab.GetComponent<MeshRenderer>().sharedMaterial.name=="red");
        Check("prefab keeps script",prefab && prefab.GetComponent<Player>());
        var scene=EditorSceneManager.OpenScene("Assets/Scenes/Main.unity",OpenSceneMode.Single);
        var inst=scene.GetRootGameObjects().FirstOrDefault(g=>g.name=="Ship");
        Check("scene instance linked to prefab",inst && PrefabUtility.GetCorrespondingObjectFromSource(inst)==prefab);
        Check("build settings path",EditorBuildSettings.scenes.Length==1 && EditorBuildSettings.scenes[0].path=="Assets/Scenes/Main.unity",EditorBuildSettings.scenes.FirstOrDefault()?.path);
        var shader=AssetDatabase.LoadAssetAtPath<Shader>("Assets/Shaders/Tinted.shader");
        Check("shader include resolves",shader && !ShaderUtil.ShaderHasError(shader));
        Check("Resources.Load still works",Player.Level()!=null);
        Check("code path string rewritten",Player.ConfigPath=="Assets/Data/config.json" && File.Exists(Player.ConfigPath),Player.ConfigPath);
        Check("vendor kept whole",Vendor.Home=="Assets/ThirdParty/VendorLib" && File.Exists("Assets/ThirdParty/VendorLib/readme.txt"),Vendor.Home);
        Check("old folders gone",!AssetDatabase.IsValidFolder("Assets/Game") && !AssetDatabase.IsValidFolder("Assets/Imported"));
        File.WriteAllLines("../verify.txt",lines);foreach(var l in lines)Debug.Log("[LayoutTest] "+l);
        EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);
        EditorApplication.Exit(lines.All(l=>l.StartsWith("PASS"))?0:1);
    }
}
