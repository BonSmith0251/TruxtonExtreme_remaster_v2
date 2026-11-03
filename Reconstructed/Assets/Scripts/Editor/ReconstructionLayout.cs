using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

// Reorganises the project into the usual Unity game layout (user request 2026-11-02): the remaster's own content by
// type (Scenes, Scripts/Runtime + Scripts/Editor, Prefabs, Materials, Textures, Models, Animations, Shaders, Settings,
// Data) and the extracted original game library as one folder, OriginalGame (its inner layout unchanged). Resources,
// StreamingAssets, Plugins and AddressableAssetsData stay where Unity needs them.
// Every move goes through AssetDatabase.MoveAsset, so GUIDs and references are kept and nothing reimports.
// Writes D:/Games/TruxtonExRecon/verification/layout/moves.json (each step, and every asset's old and new path with its
// GUID) for tools/layout/rewrite_paths.py and for undoing (ReconstructionLayout.Undo replays it backwards).
// Run: Unity.exe -batchmode -projectPath ... -executeMethod ReconstructionLayout.Run
public static class ReconstructionLayout
{
    const string Manifest="D:/Games/TruxtonExRecon/verification/layout/moves.json";
    public static readonly string[,] Steps={
        {"Assets/OriginalRecovered","Assets/OriginalGame"},
        // Scenes
        {"Assets/TruxtonImported/Scenes","Assets/Scenes/Round1"},
        {"Assets/Reconstruction/StagePlay","Assets/Scenes/StagePlay"},
        {"Assets/Reconstruction/StageInspection","Assets/Scenes/StageInspection"},
        {"Assets/Reconstruction/Hub.unity","Assets/Scenes/Hub.unity"},
        {"Assets/Reconstruction/Arcade/ArcadeBoot.unity","Assets/Scenes/ArcadeBoot.unity"},
        // Scripts
        {"Assets/Editor","Assets/Scripts/Editor"},
        {"Assets/Truxton","Assets/Scripts/Runtime/Gameplay"},
        {"Assets/Reconstruction/Arcade","Assets/Scripts/Runtime/Arcade"},
        {"Assets/Reconstruction/Bosses","Assets/Scripts/Runtime/Stage/Bosses"},
        {"Assets/Reconstruction/StageBoss.cs","Assets/Scripts/Runtime/Stage/StageBoss.cs"},
        {"Assets/Reconstruction/StageCombatData.cs","Assets/Scripts/Runtime/Stage/StageCombatData.cs"},
        {"Assets/Reconstruction/StageEnemies.cs","Assets/Scripts/Runtime/Stage/StageEnemies.cs"},
        {"Assets/Reconstruction/StagePresentation.cs","Assets/Scripts/Runtime/Stage/StagePresentation.cs"},
        {"Assets/Reconstruction/StageRenderSettings.cs","Assets/Scripts/Runtime/Stage/StageRenderSettings.cs"},
        {"Assets/ReconstructionHub.cs","Assets/Scripts/Runtime/ReconstructionHub.cs"},
        {"Assets/DebugUIHandlerRenderingLayerField.cs","Assets/Scripts/Runtime/Compatibility/DebugUIHandlerRenderingLayerField.cs"},
        // Shaders
        {"Assets/Reconstruction/Shaders","Assets/Shaders"},
        {"Assets/Scripts/Runtime/Gameplay/Round1Terrain.shader","Assets/Shaders/Round1Terrain.shader"},
        // Art
        {"Assets/TruxtonImported/Textures","Assets/Textures"},
        {"Assets/Reconstruction/ComicBlank.png","Assets/Textures/ComicBlank.png"},
        {"Assets/TruxtonGameplay/UI","Assets/Textures/UI"},
        {"Assets/TruxtonImported/Materials","Assets/Materials"},
        {"Assets/TruxtonGameplay/BombBurst.mat","Assets/Materials/Gameplay/BombBurst.mat"},
        {"Assets/TruxtonGameplay/BombShockwave.mat","Assets/Materials/Gameplay/BombShockwave.mat"},
        {"Assets/TruxtonGameplay/EnemyBullet.mat","Assets/Materials/Gameplay/EnemyBullet.mat"},
        {"Assets/TruxtonGameplay/PlayerBullet.mat","Assets/Materials/Gameplay/PlayerBullet.mat"},
        {"Assets/TruxtonImported/Prefabs","Assets/Prefabs"},
        {"Assets/TruxtonGameplay/BombBurst.prefab","Assets/Prefabs/Gameplay/BombBurst.prefab"},
        {"Assets/TruxtonGameplay/EnemyBullet.prefab","Assets/Prefabs/Gameplay/EnemyBullet.prefab"},
        {"Assets/TruxtonGameplay/PlayerBullet.prefab","Assets/Prefabs/Gameplay/PlayerBullet.prefab"},
        {"Assets/TruxtonImported/Meshes","Assets/Models"},
        {"Assets/TruxtonImported/Animations","Assets/Animations"},
        {"Assets/TruxtonGameplay/Animations","Assets/Animations/Gameplay"},
        // Settings and data
        {"Assets/TruxtonImported/Settings","Assets/Settings"},
        {"Assets/DefaultVolumeProfile.asset","Assets/Settings/DefaultVolumeProfile.asset"},
        {"Assets/UniversalRenderPipelineGlobalSettings.asset","Assets/Settings/UniversalRenderPipelineGlobalSettings.asset"},
        {"Assets/TruxtonGameplay/gameplay-parameters.json","Assets/Data/gameplay-parameters.json"},
        {"Assets/TruxtonGameplay/player-motion.json","Assets/Data/player-motion.json"},
        {"Assets/TruxtonGameplay/round1-enemy-waves.json","Assets/Data/round1-enemy-waves.json"},
    };
    // Emptied by the steps above; removed at the end when nothing but folders is left in them.
    static readonly string[] Emptied={"Assets/Reconstruction","Assets/TruxtonImported","Assets/TruxtonGameplay"};

    [Serializable] class Entry { public string from,to,guid; }
    [Serializable] class Record { public List<Entry> steps=new List<Entry>();public List<Entry> assets=new List<Entry>();public List<string> removed=new List<string>();public List<string> errors=new List<string>(); }

    public static void Run()
    {
        var record=new Record();
        try
        {
            // No StartAssetEditing: folders created for one step must be visible to the next.
            {
                for(int i=0;i<Steps.GetLength(0);i++)
                {
                    string from=Steps[i,0],to=Steps[i,1];
                    if(!AssetDatabase.IsValidFolder(from) && !File.Exists(from)){record.errors.Add("missing "+from);continue;}
                    // Each asset's path before the move (a folder moves everything below it).
                    var below=AssetDatabase.IsValidFolder(from)?AssetDatabase.FindAssets("",new[]{from}).Select(AssetDatabase.GUIDToAssetPath).Distinct().ToList():new List<string>{from};
                    Folder(Path.GetDirectoryName(to).Replace('\\','/'));
                    string error=AssetDatabase.MoveAsset(from,to);
                    if(!string.IsNullOrEmpty(error)){record.errors.Add(from+" -> "+to+": "+error);continue;}
                    record.steps.Add(new Entry{from=from,to=to,guid=AssetDatabase.AssetPathToGUID(to)});
                    foreach(var p in below)record.assets.Add(new Entry{from=p,to=to+p.Substring(from.Length),guid=AssetDatabase.AssetPathToGUID(to+p.Substring(from.Length))});
                }
            }
            AssetDatabase.Refresh();
            foreach(var folder in Emptied)
            {
                if(!AssetDatabase.IsValidFolder(folder))continue;
                bool onlyFolders=Directory.GetFiles(folder,"*",SearchOption.AllDirectories).All(f=>f.EndsWith(".meta"));
                if(onlyFolders && AssetDatabase.DeleteAsset(folder))record.removed.Add(folder);else record.errors.Add("not empty: "+folder);
            }
            // Build settings keep their scenes by GUID; rewrite the paths so the list reads right.
            EditorBuildSettings.scenes=EditorBuildSettings.scenes.Select(s=>new EditorBuildSettingsScene(AssetDatabase.GUIDToAssetPath(s.guid.ToString()) is string p && p.Length>0?p:s.path,s.enabled)).ToArray();
            AssetDatabase.SaveAssets();
        }
        catch(Exception e){record.errors.Add(e.ToString());Debug.LogException(e);}
        Directory.CreateDirectory(Path.GetDirectoryName(Manifest));File.WriteAllText(Manifest,JsonUtility.ToJson(record,true));
        Debug.Log($"[Layout] steps={record.steps.Count} assets={record.assets.Count} removed={record.removed.Count} errors={record.errors.Count}");
        foreach(var e in record.errors)Debug.LogError("[Layout] "+e);
        if(Application.isBatchMode)ReconstructionExit.Quit(record.errors.Count==0?0:1);
    }

    // Puts every moved asset back where it was (from moves.json), in reverse order.
    public static void Undo()
    {
        var record=JsonUtility.FromJson<Record>(File.ReadAllText(Manifest));int failed=0;
        for(int i=record.steps.Count-1;i>=0;i--)
        {
            var s=record.steps[i];Folder(Path.GetDirectoryName(s.from).Replace('\\','/'));
            string error=AssetDatabase.MoveAsset(s.to,s.from);if(!string.IsNullOrEmpty(error)){failed++;Debug.LogError("[Layout] undo "+s.to+": "+error);}
        }
        AssetDatabase.Refresh();
        EditorBuildSettings.scenes=EditorBuildSettings.scenes.Select(s=>new EditorBuildSettingsScene(AssetDatabase.GUIDToAssetPath(s.guid.ToString()) is string p && p.Length>0?p:s.path,s.enabled)).ToArray();
        Debug.Log("[Layout] undo failed="+failed);
        if(Application.isBatchMode)ReconstructionExit.Quit(failed==0?0:1);
    }

    static void Folder(string path)
    {
        if(string.IsNullOrEmpty(path) || AssetDatabase.IsValidFolder(path))return;
        Folder(Path.GetDirectoryName(path).Replace('\\','/'));
        AssetDatabase.CreateFolder(Path.GetDirectoryName(path).Replace('\\','/'),Path.GetFileName(path));
    }
}
