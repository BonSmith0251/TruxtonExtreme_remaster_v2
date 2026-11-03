using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering;

public static class ReconstructionStagePreviewVerification
{
    public static void Run()
    {
        RunStage("BG01");
        RunStage("BG03");
        EditorApplication.Exit(0);
    }
    public static void RunWithRecoveredPipeline()
    {
        const string pipelinePath = "Assets/OriginalRecovered/MonoBehaviour/TXE_PipelineAsset.asset";
        const string output = "D:/Games/TruxtonExRecon/verification/stage-preview-native-pipeline";
        Directory.CreateDirectory(output);
        File.WriteAllText(output + "/errors.txt", "");
        var oldGraphics = GraphicsSettings.renderPipelineAsset;
        var oldQuality = QualitySettings.renderPipeline;
        int errors = 0;
        string exception = "";
        Application.LogCallback callback = (message, stack, kind) => {
            if (kind == LogType.Error || kind == LogType.Exception || kind == LogType.Assert) {
                errors++; File.AppendAllText(output + "/errors.txt", kind + ": " + message + "\n" + stack + "\n");
            }
        };
        Application.logMessageReceived += callback;
        try
        {
            var pipeline = AssetDatabase.LoadAssetAtPath<RenderPipelineAsset>(pipelinePath);
            if (!pipeline) throw new InvalidOperationException("Recovered target pipeline failed to load: " + pipelinePath);
            GraphicsSettings.renderPipelineAsset = pipeline;
            QualitySettings.renderPipeline = pipeline;
            foreach (string stage in new[] { "BG01", "BG03" })
            {
                try { RunStage(stage, "native-pipeline"); }
                catch (Exception e) { errors++; exception += stage + ": " + e + "\n"; File.AppendAllText(output + "/errors.txt", stage + ": " + e + "\n"); }
            }
        }
        catch (Exception e) { errors++; exception += e.ToString(); File.AppendAllText(output + "/errors.txt", e.ToString()); }
        finally
        {
            QualitySettings.renderPipeline = oldQuality;
            GraphicsSettings.renderPipelineAsset = oldGraphics;
            Application.logMessageReceived -= callback;
        }
        File.WriteAllText(output + "/probe-result.json", JsonUtility.ToJson(new Probe { pipeline=pipelinePath, errors=errors, exception=exception, assignmentsRestored=GraphicsSettings.renderPipelineAsset==oldGraphics && QualitySettings.renderPipeline==oldQuality, scope="Diagnostic memory-only pipeline assignment; no scene/settings saved; original camera renderer indices retained" }, true));
        EditorApplication.Exit(errors == 0 ? 0 : 1);
    }
    [Serializable] class Probe { public string pipeline,exception,scope; public int errors; public bool assignmentsRestored; }
    static void RunStage(string stage, string variant = "default")
    {
        string output = "D:/Games/TruxtonExRecon/verification/stage-preview" + (variant == "default" ? "" : "-" + variant);
        Directory.CreateDirectory(output);
        string scene = AssetDatabase.FindAssets("StageInspection_" + stage + " t:Scene").Select(AssetDatabase.GUIDToAssetPath).FirstOrDefault();
        if (String.IsNullOrEmpty(scene)) throw new InvalidOperationException("StageInspection_" + stage + " scene not found");
        EditorSceneManager.OpenScene(scene, OpenSceneMode.Single);
        var cameras = UnityEngine.Object.FindObjectsByType<Camera>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        var camera = cameras.FirstOrDefault(c => c.gameObject.activeInHierarchy) ?? cameras.FirstOrDefault();
        if (!camera) throw new InvalidOperationException("No source camera in " + scene);
        var renderers = UnityEngine.Object.FindObjectsByType<Renderer>(FindObjectsInactive.Include, FindObjectsSortMode.None);
        var target = new RenderTexture(1280,720,24,RenderTextureFormat.ARGB32);
        var image = new Texture2D(1280,720,TextureFormat.RGB24,false);
        var previous = camera.targetTexture;
        var active = RenderTexture.active;
        target.Create();
        try
        {
            if (GraphicsSettings.currentRenderPipeline)
            {
                var request = new RenderPipeline.StandardRequest {destination=target,mipLevel=0,slice=0,face=CubemapFace.Unknown};
                RenderPipeline.SubmitRenderRequest(camera,request);
            }
            else { camera.targetTexture=target; camera.Render(); }
            RenderTexture.active=target;
            image.ReadPixels(new Rect(0,0,1280,720),0,0);
            image.Apply();
            File.WriteAllBytes(output+"/"+stage+"-source-camera.png",image.EncodeToPNG());
            File.WriteAllText(output+"/"+stage+"-capture.json",JsonUtility.ToJson(new Capture {utc=DateTime.UtcNow.ToString("O"),unity=Application.unityVersion,scene=scene,camera=PathOf(camera.transform),graphics=SystemInfo.graphicsDeviceName,api=SystemInfo.graphicsDeviceType.ToString(),pipeline=GraphicsSettings.currentRenderPipeline?GraphicsSettings.currentRenderPipeline.name:"Built-in",renderers=renderers.Length,activeRenderers=renderers.Count(x=>x.enabled&&x.gameObject.activeInHierarchy),position=camera.transform.position,rotation=camera.transform.rotation,fov=camera.fieldOfView,scope="Static source-camera editor render only; no Play, no source behavior or matched-original visual fidelity assertion; no scene saved"},true));
        }
        finally
        {
            camera.targetTexture=previous;RenderTexture.active=active;
            UnityEngine.Object.DestroyImmediate(image);target.Release();UnityEngine.Object.DestroyImmediate(target);
        }
    }
    static string PathOf(Transform t) {return t.parent?PathOf(t.parent)+"/"+t.name:t.name;}
    [Serializable] class Capture {public string utc,unity,scene,camera,graphics,api,pipeline,scope;public int renderers,activeRenderers;public Vector3 position;public Quaternion rotation;public float fov;}
}
