using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

// Copies a stage prefab's InGameBGObject render settings (fog, skybox, ambient, reflection) into a StageRenderSettings
// component in its playable stage scene, and into the scene's own RenderSettings so the editor shows the same.
// Run: Unity.exe -batchmode -projectPath ... -executeMethod ReconstructionStageRenderSettings.Run
//   (STAGE_RENDER_ONLY=BG08 for one stage; default: every stage in Stages). ReconstructionStagePlay.Build calls Install too.
public static class ReconstructionStageRenderSettings
{
    // Stages whose playable scene uses the original per-stage settings. The others still keep the BG03 template's.
    public static readonly string[] Stages={"BG08"};

    // User-requested looks that depart from the original values (applied after the copy; the original stays in "source").
    // BG08 (2026-11-02, "make stage08 a little foggy"; the original has fog off): light space-blue haze. Camera depths
    // measured in play: battleship 8000-16000, mid structures ~4000, interior ~400 -> about 26-56% / 11% / 0% fog
    // ("a little more" than the first 2000-40000).
    static readonly Dictionary<string,Action<StageRenderSettings>> Looks=new Dictionary<string,Action<StageRenderSettings>>{
        ["BG08"]=s=>{s.useFog=true;s.fogColor=new Color(.11f,.40f,.58f,1);s.fogMode=FogMode.Linear;s.fogStart=1000;s.fogEnd=28000;s.adjustment="light fog (user request; original: fog off)";},
    };

    public static void Run()
    {
        string only=Environment.GetEnvironmentVariable("STAGE_RENDER_ONLY");
        foreach(string key in Stages.Where(k=>string.IsNullOrEmpty(only)||k==only))
        {
            string path="Assets/Scenes/StagePlay/StagePlay_"+key+".unity";
            if(!File.Exists(path))continue;
            var scene=EditorSceneManager.OpenScene(path,OpenSceneMode.Single);
            Install(scene,key);
            EditorSceneManager.SaveScene(scene);
        }
        if(Application.isBatchMode)ReconstructionExit.Quit(0);
    }

    public static void Install(Scene scene,string key)
    {
        if(!Stages.Contains(key))return;
        var director=StagePresentation.FindStageDirector(scene);
        // It sits on the BGxx child (beside the BGxx_bg director), not on the BGxxStage root.
        var bg=director?director.GetComponentsInChildren<Component>(true).FirstOrDefault(c=>c&&c.GetType().Name=="InGameBGObject"):null;
        if(!bg)throw new InvalidOperationException("No InGameBGObject under the stage root in "+scene.path);
        var so=new SerializedObject(bg);
        var holder=scene.GetRootGameObjects().Select(g=>g.GetComponentInChildren<StageRenderSettings>(true)).FirstOrDefault(c=>c);
        if(!holder){var go=new GameObject("StageRenderSettings");SceneManager.MoveGameObjectToScene(go,scene);holder=go.AddComponent<StageRenderSettings>();}
        holder.source=director.name+" InGameBGObject";
        holder.skyboxMaterial=so.FindProperty("_skyboxMaterial").objectReferenceValue as Material;
        holder.skyboxShadowColor=so.FindProperty("_skyboxShadowColor").colorValue;
        holder.useFog=so.FindProperty("_useFog").boolValue;
        holder.fogColor=so.FindProperty("_fogColor").colorValue;
        holder.fogMode=(FogMode)so.FindProperty("_fogMode").intValue;
        holder.fogStart=so.FindProperty("_fogStart").floatValue;
        holder.fogEnd=so.FindProperty("_fogEnd").floatValue;
        holder.reflectionIntensity=so.FindProperty("_reflectionIntensity").floatValue;
        holder.ambientIntensity=so.FindProperty("_ambientIntensity").floatValue;
        holder.reflectionBounces=so.FindProperty("_reflectionBounces").intValue;
        holder.reflectionResolution=so.FindProperty("_reflectionResolution").intValue;
        holder.reflectionMode=(DefaultReflectionMode)so.FindProperty("_reflectionMode").intValue;
        holder.ambientMode=(AmbientMode)so.FindProperty("_ambientMode").intValue;
        holder.adjustment="";holder.unfogParticles=null;holder.stageRoot=director.transform;
        if(Looks.TryGetValue(key,out var look))look(holder);
        if(holder.useFog&&!so.FindProperty("_useFog").boolValue)holder.unfogParticles=AssetDatabase.LoadAssetAtPath<Shader>("Assets/Shaders/ParticlesUnlitNoFog.shader");
        EditorUtility.SetDirty(holder);
        holder.Apply();   // the scene's own RenderSettings, saved with it
        EditorSceneManager.MarkSceneDirty(scene);
        Debug.Log("StageRenderSettings "+key+": fog "+holder.useFog+" "+holder.fogMode+" "+holder.fogStart+"-"+holder.fogEnd+", skybox "+(holder.skyboxMaterial?holder.skyboxMaterial.name:"none")+", ambient "+holder.ambientMode+" x"+holder.ambientIntensity+", reflection "+holder.reflectionMode+" "+holder.reflectionResolution+(holder.adjustment.Length>0?", adjusted: "+holder.adjustment:""));
    }
}
