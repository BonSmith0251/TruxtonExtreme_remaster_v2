using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
// Test fixture for the unity-prefab-organizer skill: a flat Prefabs folder with the usual kinds of prefab.
public static class PrefabFixture
{
    static GameObject Save(GameObject go,string path){var p=PrefabUtility.SaveAsPrefabAsset(go,path);Object.DestroyImmediate(go);return p;}
    static GameObject Prim(PrimitiveType t,string name){var g=GameObject.CreatePrimitive(t);g.name=name;return g;}
    public static void Setup()
    {
        Directory.CreateDirectory("Assets/Prefabs");Directory.CreateDirectory("Assets/Resources");Directory.CreateDirectory("Assets/Scenes");
        var turret=Save(Prim(PrimitiveType.Cube,"Turret"),"Assets/Prefabs/Turret.prefab");
        var player=Prim(PrimitiveType.Capsule,"Player");player.AddComponent<Rigidbody>();player.AddComponent<Animator>();player.AddComponent<Player>();
        var t=(GameObject)PrefabUtility.InstantiatePrefab(turret);t.transform.SetParent(player.transform,false);
        var playerPrefab=Save(player,"Assets/Prefabs/Player.prefab");
        var grunt=Save(Prim(PrimitiveType.Cube,"EnemyGrunt"),"Assets/Prefabs/EnemyGrunt.prefab");
        var eliteInstance=(GameObject)PrefabUtility.InstantiatePrefab(grunt);eliteInstance.transform.localScale=Vector3.one*2;
        var elite=Save(eliteInstance,"Assets/Prefabs/EnemyGrunt_Elite.prefab");
        var bullet=Prim(PrimitiveType.Sphere,"Bullet");bullet.AddComponent<Rigidbody>();Save(bullet,"Assets/Prefabs/Bullet.prefab");
        var fx=new GameObject("Explosion");fx.AddComponent<ParticleSystem>();Save(fx,"Assets/Prefabs/Explosion.prefab");
        var hud=new GameObject("HUD",typeof(RectTransform),typeof(Canvas));var hudPrefab=Save(hud,"Assets/Prefabs/HUD.prefab");
        var coin=Save(Prim(PrimitiveType.Cylinder,"Coin"),"Assets/Prefabs/Coin.prefab");
        var rock=Save(Prim(PrimitiveType.Cube,"Rock"),"Assets/Prefabs/Rock.prefab");
        var light=new GameObject("SunLight");light.AddComponent<Light>();var lightPrefab=Save(light,"Assets/Prefabs/SunLight.prefab");
        var gm=new GameObject("GameManager");gm.AddComponent<GameManager>();gm.AddComponent<Spawner>();var gmPrefab=Save(gm,"Assets/Prefabs/GameManager.prefab");
        Save(Prim(PrimitiveType.Cube,"Old_Unused"),"Assets/Prefabs/Old_Unused.prefab");
        Save(Prim(PrimitiveType.Cube,"Spawnable"),"Assets/Resources/Spawnable.prefab");
        var scene=EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);
        foreach(var p in new[]{playerPrefab,elite,hudPrefab,rock,coin,lightPrefab,gmPrefab})PrefabUtility.InstantiatePrefab(p);
        EditorSceneManager.SaveScene(scene,"Assets/Scenes/Main.unity");
        EditorBuildSettings.scenes=new[]{new EditorBuildSettingsScene("Assets/Scenes/Main.unity",true)};
        AssetDatabase.SaveAssets();Debug.Log("[PrefabFixture] setup done");
    }
}
