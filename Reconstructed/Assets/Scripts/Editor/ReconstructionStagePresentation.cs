using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering;

// Adds StagePresentation to the eight derived stage scenes and verifies that every original background timeline
// evaluates: the source camera must move along its rail, no exception may be logged, and frames across the whole
// timeline are captured. Run Install once, then Verify; both are batch-safe (-executeMethod).
public static class ReconstructionStagePresentation
{
    const string Evidence="D:/Games/TruxtonExRecon/verification/stage-presentation";
    static IEnumerable<string> Scenes()=>Enumerable.Range(1,8).Select(i=>"Assets/Scenes/StageInspection/StageInspection_BG"+i.ToString("00")+".unity");

    public static void Install()
    {
        foreach(string path in Scenes())
        {
            var scene=EditorSceneManager.OpenScene(path,OpenSceneMode.Single);
            if(UnityEngine.Object.FindFirstObjectByType<StagePresentation>())continue;
            var stage=StagePresentation.FindStageDirector(scene);
            if(!stage)throw new InvalidOperationException("No original stage director in "+path);
            var go=new GameObject("StagePresentation");go.AddComponent<StagePresentation>().stage=stage;
            EditorSceneManager.MarkSceneDirty(scene);EditorSceneManager.SaveScene(scene);
        }
        if(Application.isBatchMode)ReconstructionExit.Quit(0);
    }

    // In the original, stages load additively into BootTXE, so BootTXE's RenderSettings (the mt_skybox_space01a
    // 6-sided space skybox, ambient and fog) are the ones in effect. Copy them into the derived stage scenes.
    public static void ApplyBootRenderSettings()=>ApplyBoot(Scenes());
    // The playable stage scenes are built from Round 1's BG03 template and would keep its fog; give them BootTXE's too.
    public static void ApplyBootRenderSettingsToStagePlay()=>ApplyBoot(Enumerable.Range(1,8).Select(i=>"Assets/Scenes/StagePlay/StagePlay_BG"+i.ToString("00")+".unity").Where(File.Exists));
    static void ApplyBoot(IEnumerable<string> scenes)
    {
        EditorSceneManager.OpenScene("Assets/OriginalGame/Scenes/BootTXE.unity",OpenSceneMode.Single);
        var skybox=RenderSettings.skybox;var ambientMode=RenderSettings.ambientMode;var sky=RenderSettings.ambientSkyColor;var equator=RenderSettings.ambientEquatorColor;
        var ground=RenderSettings.ambientGroundColor;float ambientIntensity=RenderSettings.ambientIntensity;var ambientLight=RenderSettings.ambientLight;
        bool fog=RenderSettings.fog;var fogColor=RenderSettings.fogColor;var fogMode=RenderSettings.fogMode;float fogDensity=RenderSettings.fogDensity,fogStart=RenderSettings.fogStartDistance,fogEnd=RenderSettings.fogEndDistance;
        var reflectionMode=RenderSettings.defaultReflectionMode;float reflectionIntensity=RenderSettings.reflectionIntensity;var subtractive=RenderSettings.subtractiveShadowColor;
        foreach(string path in scenes.ToList())
        {
            var scene=EditorSceneManager.OpenScene(path,OpenSceneMode.Single);
            RenderSettings.skybox=skybox;RenderSettings.ambientMode=ambientMode;RenderSettings.ambientSkyColor=sky;RenderSettings.ambientEquatorColor=equator;
            RenderSettings.ambientGroundColor=ground;RenderSettings.ambientIntensity=ambientIntensity;RenderSettings.ambientLight=ambientLight;
            RenderSettings.fog=fog;RenderSettings.fogColor=fogColor;RenderSettings.fogMode=fogMode;RenderSettings.fogDensity=fogDensity;RenderSettings.fogStartDistance=fogStart;RenderSettings.fogEndDistance=fogEnd;
            RenderSettings.defaultReflectionMode=reflectionMode;RenderSettings.reflectionIntensity=reflectionIntensity;RenderSettings.subtractiveShadowColor=subtractive;
            DynamicGI.UpdateEnvironment();
            EditorSceneManager.MarkSceneDirty(scene);EditorSceneManager.SaveScene(scene);
        }
        if(Application.isBatchMode)ReconstructionExit.Quit(0);
    }

    [Serializable] class Frame {public double time;public string camera;public Vector3 position;public Quaternion rotation;public int activeRenderers;public string image;}
    [Serializable] class StageResult {public string scene,stage;public double duration;public int exceptions,errors,warnings;public float cameraTravel;public List<string> driven=new List<string>(),skipped=new List<string>(),rootTracksOmitted=new List<string>(),rendererFallbacks=new List<string>(),messages=new List<string>();public List<Frame> frames=new List<Frame>();public bool passed;}
    [Serializable] class Report {public string utc,unity,graphics,pipeline,scope;public bool passed;public List<StageResult> stages=new List<StageResult>();}

    public static void Verify()
    {
        Directory.CreateDirectory(Evidence);
        var report=new Report{utc=DateTime.UtcNow.ToString("O"),unity=Application.unityVersion,graphics=SystemInfo.graphicsDeviceName,pipeline=GraphicsSettings.currentRenderPipeline?GraphicsSettings.currentRenderPipeline.name:"Built-in",
            scope="Edit-mode evaluation of each original BGxxStage timeline through StagePresentation (same Seek/Evaluate path as Play). Background timelines only; InGame.Kernel enemy/event/BGM tracks are not run. Default project pipeline; custom TXE shaders remain approximated."};
        StageResult current=null;
        Application.LogCallback log=(message,stack,kind)=>{
            if(current==null||kind==LogType.Log)return;
            if(kind==LogType.Exception)current.exceptions++;else if(kind==LogType.Warning)current.warnings++;else current.errors++;
            if(current.messages.Count<40)current.messages.Add(kind+": "+message.Split('\n')[0]);
        };
        Application.logMessageReceived+=log;
        try{foreach(string path in Scenes()){current=new StageResult{scene=path};report.stages.Add(current);RunStage(current);}}
        finally{Application.logMessageReceived-=log;current=null;}
        report.passed=report.stages.Count==8&&report.stages.All(s=>s.passed);
        File.WriteAllText(Evidence+"/report.json",JsonUtility.ToJson(report,true));
        Debug.Log("STAGE_PRESENTATION "+(report.passed?"PASS":"FAIL")+" "+string.Join(" ",report.stages.Select(s=>Path.GetFileNameWithoutExtension(s.scene)+"="+(s.passed?"pass":"fail")+"/travel"+s.cameraTravel.ToString("0.0"))));
        if(Application.isBatchMode)ReconstructionExit.Quit(report.passed?0:1);
    }

    static void RunStage(StageResult result)
    {
        EditorSceneManager.OpenScene(result.scene,OpenSceneMode.Single);
        var driver=UnityEngine.Object.FindFirstObjectByType<StagePresentation>();
        if(!driver){result.messages.Add("StagePresentation missing; run Install first");return;}
        try{driver.Prepare();}
        catch(Exception e){result.exceptions++;result.messages.Add("Prepare: "+e.Message);return;}
        result.stage=driver.stage.name;result.duration=driver.Duration;
        result.driven.AddRange(driver.driven);result.skipped.AddRange(driver.skipped);result.rootTracksOmitted.AddRange(driver.rootTracksOmitted);result.rendererFallbacks.AddRange(driver.rendererFallbacks);
        double d=driver.Duration;
        var times=new[]{0,5,30,d*.25,d*.5,d*.75,Math.Max(0,d-2)};
        string key=Path.GetFileNameWithoutExtension(result.scene).Replace("StageInspection_","");
        const int w=640,h=360;
        var sheet=new Texture2D(w*4,h*2,TextureFormat.RGB24,false);
        sheet.SetPixels(Enumerable.Repeat(Color.black,w*4*h*2).ToArray());
        Vector3? first=null;
        for(int i=0;i<times.Length;i++)
        {
            try{driver.Seek(times[i]);}
            catch(Exception e){result.exceptions++;result.messages.Add("Seek "+times[i].ToString("0.0")+": "+e.Message);continue;}
            var camera=UnityEngine.Object.FindObjectsByType<Camera>(FindObjectsInactive.Exclude,FindObjectsSortMode.None).Where(c=>c.enabled).OrderByDescending(c=>c.depth).FirstOrDefault();
            var frame=new Frame{time=driver.time,activeRenderers=UnityEngine.Object.FindObjectsByType<Renderer>(FindObjectsInactive.Exclude,FindObjectsSortMode.None).Count(r=>r.enabled)};
            result.frames.Add(frame);
            if(!camera){result.messages.Add("No active camera at "+times[i].ToString("0.0"));continue;}
            frame.camera=PathOf(camera.transform);frame.position=camera.transform.position;frame.rotation=camera.transform.rotation;
            if(first==null)first=frame.position;else result.cameraTravel=Mathf.Max(result.cameraTravel,Vector3.Distance(first.Value,frame.position));
            var image=Render(camera,w,h);
            sheet.SetPixels((i%4)*w,(1-i/4)*h,w,h,image.GetPixels());
            UnityEngine.Object.DestroyImmediate(image);
            frame.image=key+".png#"+i;
        }
        sheet.Apply();
        File.WriteAllBytes(Evidence+"/"+key+".png",sheet.EncodeToPNG());
        UnityEngine.Object.DestroyImmediate(sheet);
        result.passed=result.exceptions==0&&result.driven.Count>0&&result.cameraTravel>1f&&result.frames.Count==times.Length&&result.frames.All(f=>f.camera!=null);
    }

    static Texture2D Render(Camera camera,int w,int h)
    {
        var target=new RenderTexture(w,h,24,RenderTextureFormat.ARGB32);target.Create();
        var previous=camera.targetTexture;var active=RenderTexture.active;
        var image=new Texture2D(w,h,TextureFormat.RGB24,false);
        try
        {
            if(GraphicsSettings.currentRenderPipeline)RenderPipeline.SubmitRenderRequest(camera,new RenderPipeline.StandardRequest{destination=target});
            else{camera.targetTexture=target;camera.Render();}
            RenderTexture.active=target;image.ReadPixels(new Rect(0,0,w,h),0,0);image.Apply();
        }
        finally{camera.targetTexture=previous;RenderTexture.active=active;target.Release();UnityEngine.Object.DestroyImmediate(target);}
        return image;
    }
    static string PathOf(Transform t)=>t.parent?PathOf(t.parent)+"/"+t.name:t.name;
}
