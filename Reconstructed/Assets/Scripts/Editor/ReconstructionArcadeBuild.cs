using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Builds the arcade cabinet: Resources/Truxton/ArcadeArt (the HUD glyph font as the StagePlay HUD uses it, the original
// title logo and backdrop, title and name-entry music) and Assets/Scenes/ArcadeBoot.unity (a black camera
// and the ArcadeMachine), made the first scene of the build.
// Run: Unity.exe -batchmode -projectPath ... -executeMethod ReconstructionArcadeBuild.Run
public static class ReconstructionArcadeBuild
{
    const string ScenePath="Assets/Scenes/ArcadeBoot.unity",ArtPath="Assets/Resources/Truxton/ArcadeArt.asset";
    const string TitleDir="Assets/OriginalGame/TXE_GraphicData/Title/";

    public static void Run()
    {
        int code=0;
        try{BuildArt();BuildScene();AddToBuild();Debug.Log("[ArcadeBuild] done");}
        catch(System.Exception e){Debug.LogException(e);code=1;}
        if(Application.isBatchMode)ReconstructionExit.Quit(code);
    }

    static void BuildArt()
    {
        var art=AssetDatabase.LoadAssetAtPath<ArcadeArt>(ArtPath);
        if(!art){art=ScriptableObject.CreateInstance<ArcadeArt>();AssetDatabase.CreateAsset(art,ArtPath);}
        // The glyph list of the stage HUD's first Round1HudText (characters from '!').
        string scene=File.ReadAllText("Assets/Scenes/StagePlay/StagePlay_BG03.unity");
        int at=scene.IndexOf("  glyphs:\n");if(at<0)throw new System.Exception("no HUD glyphs in StagePlay_BG03");
        var block=scene.Substring(at+10);int end=block.IndexOf("\n  cells:");if(end>0)block=block.Substring(0,end);
        art.glyphs=Regex.Matches(block,@"guid: ([0-9a-f]{32})").Cast<Match>().Select(m=>AssetDatabase.LoadAssetAtPath<Texture2D>(AssetDatabase.GUIDToAssetPath(m.Groups[1].Value))).ToArray();
        if(art.glyphs.Length<90 || art.glyphs.Any(g=>!g))throw new System.Exception("glyph font incomplete: "+art.glyphs.Length);
        art.titleLogo=AssetDatabase.LoadAssetAtPath<Texture2D>(TitleDir+"ui_title_logo_truxton.png");
        art.titleBack=AssetDatabase.LoadAssetAtPath<Texture2D>(TitleDir+"ui_back_ground01.png");
        art.titleMusic=Clip("txe_bgm_o000");art.nameEntryMusic=Clip("tatsujin_bgm_name_entry");
        EditorUtility.SetDirty(art);AssetDatabase.SaveAssets();
        Debug.Log($"[ArcadeBuild] art glyphs={art.glyphs.Length} logo={(bool)art.titleLogo} back={(bool)art.titleBack} title={(bool)art.titleMusic} entry={(bool)art.nameEntryMusic}");
    }
    static AudioClip Clip(string name)
    {
        string guid=AssetDatabase.FindAssets(name+" t:AudioClip",new[]{"Assets/Resources/TruxtonAudio"}).FirstOrDefault(g=>Path.GetFileNameWithoutExtension(AssetDatabase.GUIDToAssetPath(g))==name);
        return guid==null?null:AssetDatabase.LoadAssetAtPath<AudioClip>(AssetDatabase.GUIDToAssetPath(guid));
    }

    static void BuildScene()
    {
        var scene=EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);
        var cam=new GameObject("Main Camera",typeof(Camera),typeof(AudioListener));cam.tag="MainCamera";
        var c=cam.GetComponent<Camera>();c.clearFlags=CameraClearFlags.SolidColor;c.backgroundColor=Color.black;c.cullingMask=0;
        new GameObject("Arcade machine",typeof(ArcadeMachine));
        EditorSceneManager.SaveScene(scene,ScenePath);
    }
    static void AddToBuild()
    {
        var scenes=EditorBuildSettings.scenes.Where(s=>s.path!=ScenePath).ToList();
        scenes.Insert(0,new EditorBuildSettingsScene(ScenePath,true));
        EditorBuildSettings.scenes=scenes.ToArray();
    }
}
