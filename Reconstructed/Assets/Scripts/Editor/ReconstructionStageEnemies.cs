using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering;

// Installs StageEnemies in the eight StageInspection scenes (schedule from Resources/StageEnemies, original prefabs for
// every model it names) and verifies them by running each stage's whole schedule in 0.1 s steps with StagePresentation.
// Batch: -executeMethod ReconstructionStageEnemies.Install / .Verify
public static class ReconstructionStageEnemies
{
    const string Evidence="D:/Games/TruxtonExRecon/verification/stage-enemies";
    // STAGE_ENEMIES_ONLY=BG03 limits Verify to one stage. Rendering several stages in one editor session left
    // post-processing history from earlier scenes that blacked out some captures, so the runner uses one process per stage.
    static IEnumerable<string> Keys()
    {
        string only=Environment.GetEnvironmentVariable("STAGE_ENEMIES_ONLY");
        return Enumerable.Range(1,8).Select(i=>"BG"+i.ToString("00")).Where(k=>string.IsNullOrEmpty(only)||k==only);
    }

    static GameObject FindPrefab(string name)
    {
        var paths=AssetDatabase.FindAssets(name+" t:Prefab").Select(AssetDatabase.GUIDToAssetPath).Where(p=>Path.GetFileNameWithoutExtension(p)==name).ToList();
        // Original exported prefabs first; Assets/Prefabs holds Round 1's converted copies.
        string best=paths.FirstOrDefault(p=>p.StartsWith("Assets/OriginalGame/"))??paths.FirstOrDefault();
        return best==null?null:AssetDatabase.LoadAssetAtPath<GameObject>(best);
    }

    public static void Install()
    {
        var missing=new List<string>();
        foreach(string key in Keys())
        {
            var scene=EditorSceneManager.OpenScene("Assets/Scenes/StageInspection/StageInspection_"+key+".unity",OpenSceneMode.Single);
            var presentation=UnityEngine.Object.FindFirstObjectByType<StagePresentation>();
            var schedule=AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Resources/StageEnemies/"+key+".json");
            var data=JsonUtility.FromJson<StageEnemies.StageData>(schedule.text);
            var enemies=presentation.GetComponent<StageEnemies>();
            if(!enemies)enemies=presentation.gameObject.AddComponent<StageEnemies>();
            enemies.schedule=schedule;enemies.presentation=presentation;
            enemies.visuals=data.models.Select(m=>new Round1EnemyWaves.Visual{name=m.name,prefab=FindPrefab(m.name)}).ToArray();
            missing.AddRange(enemies.visuals.Where(v=>!v.prefab).Select(v=>key+":"+v.name));
            EditorUtility.SetDirty(enemies);EditorSceneManager.MarkSceneDirty(scene);EditorSceneManager.SaveScene(scene);
        }
        Debug.Log("STAGE_ENEMIES_INSTALL missing="+missing.Count+" "+string.Join(",",missing));
        if(Application.isBatchMode)ReconstructionExit.Quit(missing.Count==0?0:1);
    }

    [Serializable] class Shot {public float time;public int live;public string image;}
    [Serializable] class StageResult
    {
        public string stage;public float duration;public int scheduled,spawned,maxLive,entered,unseen,skippedMode,skippedBonus,skippedUnsupported,exceptions,errors,strippedBehaviours;
        public List<string> missingModels=new List<string>(),messages=new List<string>(),unseenByModel=new List<string>();public List<Shot> shots=new List<Shot>();public bool passed;
    }
    [Serializable] class Report {public string utc,unity,scope;public bool passed;public List<StageResult> stages=new List<StageResult>();}

    public static void Verify()
    {
        Directory.CreateDirectory(Evidence);
        var report=new Report{utc=DateTime.UtcNow.ToString("O"),unity=Application.unityVersion,
            scope="Edit-mode run of each stage's full original enemy schedule (Story A) in 0.1 s steps through StagePresentation + StageEnemies; air enemies drawn by the native-geometry game camera stacked on the stage camera."};
        StageResult current=null;
        Application.LogCallback log=(m,st,k)=>{if(current==null||k==LogType.Log||k==LogType.Warning)return;if(k==LogType.Exception)current.exceptions++;else current.errors++;if(current.messages.Count<30)current.messages.Add(k+": "+m.Split('\n')[0]);};
        Application.logMessageReceived+=log;
        try{foreach(string key in Keys()){current=new StageResult{stage=key};report.stages.Add(current);Run(current);}}
        finally{Application.logMessageReceived-=log;current=null;}
        report.passed=report.stages.All(s=>s.passed);
        string only=Environment.GetEnvironmentVariable("STAGE_ENEMIES_ONLY");
        File.WriteAllText(Evidence+"/report"+(string.IsNullOrEmpty(only)?"":"-"+only)+".json",JsonUtility.ToJson(report,true));
        Debug.Log("STAGE_ENEMIES "+(report.passed?"PASS":"FAIL")+" "+string.Join(" ",report.stages.Select(s=>s.stage+"="+s.spawned+"/"+s.entered+"/"+s.unseen)));
        if(Application.isBatchMode)ReconstructionExit.Quit(report.passed?0:1);
    }

    static void Run(StageResult r)
    {
        EditorSceneManager.OpenScene("Assets/Scenes/StageInspection/StageInspection_"+r.stage+".unity",OpenSceneMode.Single);
        var presentation=UnityEngine.Object.FindFirstObjectByType<StagePresentation>();
        var enemies=UnityEngine.Object.FindFirstObjectByType<StageEnemies>();
        presentation.Prepare();enemies.Prepare();
        r.duration=(float)presentation.Duration;r.scheduled=enemies.Data.events.Length;
        r.strippedBehaviours=enemies.visuals.Where(v=>v.prefab).Sum(v=>CountStubs(v.prefab));
        const int W=640,H=360;var sheet=new Texture2D(W*4,H*2,TextureFormat.RGB24,false);
        sheet.SetPixels(Enumerable.Repeat(Color.black,W*4*H*2).ToArray());
        var targets=Enumerable.Range(0,8).Select(i=>r.duration*(i+.5f)/8).ToList();int shot=0;
        for(float t=0;t<=r.duration;t+=.1f)
        {
            presentation.Seek(t);enemies.Step(t);
            if(shot<8&&t>=targets[shot]&&(enemies.Live>0||t>=targets[shot]+15))
            {
                var cam=Camera.allCameras.Where(c=>c!=enemies.GameCamera).OrderByDescending(c=>c.depth).FirstOrDefault();
                if(cam)
                {
                    var img=Render(cam,W,H);sheet.SetPixels((shot%4)*W,(1-shot/4)*H,W,H,img.GetPixels());UnityEngine.Object.DestroyImmediate(img);
                    r.shots.Add(new Shot{time=t,live=enemies.Live,image=r.stage+".png#"+shot});
                }
                shot++;
            }
        }
        sheet.Apply();File.WriteAllBytes(Evidence+"/"+r.stage+".png",sheet.EncodeToPNG());UnityEngine.Object.DestroyImmediate(sheet);
        r.spawned=enemies.Spawned;r.maxLive=enemies.MaxLive;r.entered=enemies.Entered;r.unseen=enemies.Unseen;
        r.skippedMode=enemies.SkippedMode;r.skippedBonus=enemies.SkippedBonus;r.skippedUnsupported=enemies.SkippedUnsupported;
        r.missingModels.AddRange(enemies.MissingModels);
        r.unseenByModel.AddRange(enemies.UnseenByModel.OrderByDescending(x=>x.Value).Select(x=>x.Key+"="+x.Value));
        UnityEngine.Object.DestroyImmediate(enemies.gameObject.GetComponent<StageEnemies>());
        r.passed=r.exceptions==0&&r.errors==0&&r.spawned>0&&r.missingModels.Count==0;
    }

    static int CountStubs(GameObject prefab)=>prefab.GetComponentsInChildren<MonoBehaviour>(true).Count(b=>b&&!b.GetType().Assembly.GetName().Name.StartsWith("Unity")&&b.GetType().Assembly.GetName().Name!="Assembly-CSharp");

    static Texture2D Render(Camera camera,int w,int h)
    {
        var target=new RenderTexture(w,h,24,RenderTextureFormat.ARGB32);target.Create();var active=RenderTexture.active;
        var image=new Texture2D(w,h,TextureFormat.RGB24,false);
        try{RenderPipeline.SubmitRenderRequest(camera,new RenderPipeline.StandardRequest{destination=target});RenderTexture.active=target;image.ReadPixels(new Rect(0,0,w,h),0,0);image.Apply();}
        finally{RenderTexture.active=active;target.Release();UnityEngine.Object.DestroyImmediate(target);}
        return image;
    }
}
