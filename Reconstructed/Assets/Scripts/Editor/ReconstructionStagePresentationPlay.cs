using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Verification only: enters editor Play in each StageInspection scene and lets StagePresentation run from Update for
// a few seconds. Passes when the stage clock advances, the source camera moves and nothing throws.
// Run in a graphics editor (not -batchmode): -executeMethod ReconstructionStagePresentationPlay.Run
[InitializeOnLoad]
public static class ReconstructionStagePresentationPlay
{
    const string Prefix="StagePresentationPlay.";
    const string Output="D:/Games/TruxtonExRecon/verification/stage-presentation";
    const float Seconds=6;
    static string ScenePath(int i)=>"Assets/Scenes/StageInspection/StageInspection_BG"+i.ToString("00")+".unity";

    static ReconstructionStagePresentationPlay()
    {
        EditorApplication.update+=Update;
        EditorApplication.playModeStateChanged+=Changed;
        Application.logMessageReceived+=(message,stack,kind)=>{
            if(!SessionState.GetBool(Prefix+"running",false)||kind==LogType.Log||kind==LogType.Warning)return;
            SessionState.SetInt(Prefix+"errors",SessionState.GetInt(Prefix+"errors",0)+1);
            File.AppendAllText(Output+"/play-errors.txt","stage "+SessionState.GetInt(Prefix+"stage",0)+" "+kind+": "+message+"\n"+stack+"\n");
        };
    }

    public static void Run()
    {
        Directory.CreateDirectory(Output);
        File.WriteAllText(Output+"/play-mode.jsonl","");File.WriteAllText(Output+"/play-errors.txt","");
        SessionState.SetBool(Prefix+"running",true);SessionState.SetInt(Prefix+"stage",1);SessionState.SetInt(Prefix+"passed",0);
        SessionState.SetFloat(Prefix+"deadline",(float)EditorApplication.timeSinceStartup+900);
        Open();
    }
    static void Open()
    {
        SessionState.SetInt(Prefix+"errors",0);
        EditorSceneManager.OpenScene(ScenePath(SessionState.GetInt(Prefix+"stage",1)),OpenSceneMode.Single);
        SessionState.SetString(Prefix+"phase","wait-start");SessionState.SetFloat(Prefix+"at",(float)EditorApplication.timeSinceStartup+2);
    }
    static void Changed(PlayModeStateChange state)
    {
        if(!SessionState.GetBool(Prefix+"running",false))return;
        if(state==PlayModeStateChange.EnteredPlayMode){SessionState.SetString(Prefix+"phase","start-sample");SessionState.SetFloat(Prefix+"at",(float)EditorApplication.timeSinceStartup+.5f);}
        if(state==PlayModeStateChange.EnteredEditMode)
        {
            int stage=SessionState.GetInt(Prefix+"stage",1);
            if(stage<8){SessionState.SetInt(Prefix+"stage",stage+1);Open();}
            else Finish();
        }
    }
    static void Update()
    {
        if(!SessionState.GetBool(Prefix+"running",false))return;
        float now=(float)EditorApplication.timeSinceStartup;
        if(now>SessionState.GetFloat(Prefix+"deadline",float.MaxValue)){Record("{\"timeout\":true}");Finish();return;}
        if(EditorApplication.isCompiling||EditorApplication.isUpdating||now<SessionState.GetFloat(Prefix+"at",0))return;
        string phase=SessionState.GetString(Prefix+"phase","");
        var driver=EditorApplication.isPlaying?UnityEngine.Object.FindFirstObjectByType<StagePresentation>():null;
        var camera=EditorApplication.isPlaying?Camera.allCameras.OrderByDescending(c=>c.depth).FirstOrDefault():null;
        if(phase=="wait-start")
        {
            SessionState.SetString(Prefix+"phase","entering");
            var gameView=typeof(Editor).Assembly.GetType("UnityEditor.GameView");if(gameView!=null)EditorWindow.GetWindow(gameView).Show();
            EditorApplication.isPlaying=true;
        }
        else if(phase=="start-sample")
        {
            SessionState.SetFloat(Prefix+"t0",driver?(float)driver.time:-1);
            SessionState.SetString(Prefix+"p0",camera?JsonUtility.ToJson(camera.transform.position):"");
            SessionState.SetString(Prefix+"phase","end-sample");SessionState.SetFloat(Prefix+"at",now+Seconds);
        }
        else if(phase=="end-sample")
        {
            float t0=SessionState.GetFloat(Prefix+"t0",-1),t1=driver?(float)driver.time:-1;
            string p0=SessionState.GetString(Prefix+"p0","");
            float moved=camera&&p0.Length>0?Vector3.Distance(JsonUtility.FromJson<Vector3>(p0),camera.transform.position):0;
            int errors=SessionState.GetInt(Prefix+"errors",0);
            bool ok=driver&&driver.Ready&&t1-t0>Seconds*.5f&&moved>1&&errors==0;
            if(ok)SessionState.SetInt(Prefix+"passed",SessionState.GetInt(Prefix+"passed",0)+1);
            Record("{\"scene\":\""+ScenePath(SessionState.GetInt(Prefix+"stage",1))+"\",\"ready\":"+(driver&&driver.Ready?"true":"false")+",\"t0\":"+t0.ToString("R")+",\"t1\":"+t1.ToString("R")+",\"cameraMoved\":"+moved.ToString("R")+",\"camera\":\""+(camera?camera.name:"")+"\",\"errors\":"+errors+",\"skipped\":"+(driver?driver.skipped.Count:-1)+",\"passed\":"+(ok?"true":"false")+"}");
            SessionState.SetString(Prefix+"phase","exiting");EditorApplication.isPlaying=false;
        }
    }
    static void Record(string line)=>File.AppendAllText(Output+"/play-mode.jsonl",line+"\n");
    static void Finish()
    {
        int passed=SessionState.GetInt(Prefix+"passed",0);
        SessionState.SetBool(Prefix+"running",false);
        File.WriteAllText(Output+"/play-mode-result.txt",(passed==8?"PASS":"FAIL")+" "+passed+"/8 stages advanced in editor Play with zero errors/exceptions\n");
        ReconstructionExit.Quit(passed==8?0:1);
    }
}
