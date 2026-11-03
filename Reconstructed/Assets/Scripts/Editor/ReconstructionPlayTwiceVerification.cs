using System;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Verification only: opens the ordinary Round1 scene and toggles editor Play twice.
// Does not call game bootstrap methods or pass runtime capture/startup flags.
[InitializeOnLoad]
public static class ReconstructionPlayTwiceVerification
{
    const string Prefix = "IndependentReconstructionPlayTwice.";
    const string ScenePath = "Assets/Scenes/Round1/Round1.unity";
    const string Output = "D:/Games/TruxtonExRecon/verification/editor-play-twice";
    static ReconstructionPlayTwiceVerification()
    {
        EditorApplication.update += Update;
        EditorApplication.playModeStateChanged += Changed;
        Application.logMessageReceived += Log;
    }
    public static void Run()
    {
        Directory.CreateDirectory(Output);
        foreach (var file in new[] { "play-1.png", "play-2.png", "completion.json" }) if (File.Exists(Output + "/" + file)) File.Delete(Output + "/" + file);
        File.WriteAllText(Output + "/events.jsonl", "");
        File.WriteAllText(Output + "/errors.txt", "");
        SessionState.SetInt(Prefix + "cycle", 1);
        SessionState.SetInt(Prefix + "errors", 0);
        SessionState.SetBool(Prefix + "running", true);
        SessionState.SetFloat(Prefix + "deadline", (float)EditorApplication.timeSinceStartup + 360f);
        SessionState.SetString(Prefix + "phase", "opening");
        Event("start", "Unity=" + Application.unityVersion + "; graphics=" + SystemInfo.graphicsDeviceType);
        EditorSceneManager.OpenScene(ScenePath, OpenSceneMode.Single);
        SessionState.SetString(Prefix + "phase", "wait-start");
        SessionState.SetFloat(Prefix + "at", (float)EditorApplication.timeSinceStartup + 2f);
    }
    static void Changed(PlayModeStateChange state)
    {
        if (!SessionState.GetBool(Prefix + "running", false)) return;
        Event("play-mode", state.ToString());
        if (state == PlayModeStateChange.EnteredPlayMode)
        {
            SessionState.SetString(Prefix + "phase", "playing");
            SessionState.SetFloat(Prefix + "at", (float)EditorApplication.timeSinceStartup + 25f);
        }
        if (state == PlayModeStateChange.EnteredEditMode)
        {
            int cycle = SessionState.GetInt(Prefix + "cycle", 0);
            if (cycle < 2)
            {
                SessionState.SetInt(Prefix + "cycle", cycle + 1);
                SessionState.SetString(Prefix + "phase", "wait-start");
                SessionState.SetFloat(Prefix + "at", (float)EditorApplication.timeSinceStartup + 2f);
            }
            else
            {
                SessionState.SetString(Prefix + "phase", "finishing");
                SessionState.SetFloat(Prefix + "at", (float)EditorApplication.timeSinceStartup + 2f);
            }
        }
    }
    static void Update()
    {
        if (!SessionState.GetBool(Prefix + "running", false)) return;
        float now = (float)EditorApplication.timeSinceStartup;
        if (now > SessionState.GetFloat(Prefix + "deadline", float.MaxValue)) { Finish(false, "Timeout"); return; }
        if (EditorApplication.isCompiling || EditorApplication.isUpdating || now < SessionState.GetFloat(Prefix + "at", 0)) return;
        string phase = SessionState.GetString(Prefix + "phase", "");
        if (phase == "wait-start")
        {
            SessionState.SetString(Prefix + "phase", "entering-play");
            var gameViewType = typeof(Editor).Assembly.GetType("UnityEditor.GameView");
            if (gameViewType != null) EditorWindow.GetWindow(gameViewType).Show();
            Event("request-play", ScenePath);
            EditorApplication.isPlaying = true;
        }
        else if (phase == "playing")
        {
            var playback = UnityEngine.Object.FindFirstObjectByType<Round1Playback>();
            var intro = UnityEngine.Object.FindFirstObjectByType<Round1Intro>();
            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().path != ScenePath) { Finish(false, "Unexpected active scene"); return; }
            if (!playback || playback.elapsed < 8f || (intro && intro.Active))
            {
                Event("waiting-for-gameplay", "elapsed=" + (playback ? playback.elapsed.ToString("R") : "missing") + "; introActive=" + (intro && intro.Active));
                SessionState.SetFloat(Prefix + "at", now + 2f);
                return;
            }
            int cycle = SessionState.GetInt(Prefix + "cycle", 0);
            var cameras = UnityEngine.Object.FindObjectsByType<Camera>(FindObjectsInactive.Include, FindObjectsSortMode.None);
            var roots = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();
            Event("runtime-state", "scene=" + UnityEngine.SceneManagement.SceneManager.GetActiveScene().path + "; cameras=" + cameras.Length + "; roots=" + roots.Length + "; frame=" + Time.frameCount + "; graphics=" + SystemInfo.graphicsDeviceType + "; stageElapsed=" + playback.elapsed.ToString("R") + "; introActive=" + (intro && intro.Active));
            ScreenCapture.CaptureScreenshot(Output + "/play-" + cycle + ".png");
            SessionState.SetString(Prefix + "phase", "capture-wait");
            SessionState.SetFloat(Prefix + "at", now + 3f);
        }
        else if (phase == "capture-wait")
        {
            Event("request-stop", "cycle=" + SessionState.GetInt(Prefix + "cycle", 0));
            SessionState.SetString(Prefix + "phase", "exiting-play");
            EditorApplication.isPlaying = false;
        }
        else if (phase == "finishing")
        {
            bool captures = File.Exists(Output + "/play-1.png") && File.Exists(Output + "/play-2.png");
            Finish(captures && SessionState.GetInt(Prefix + "errors", 0) == 0, captures ? "Two Play cycles completed; inspect frames for visual verdict" : "Missing screenshot");
        }
    }
    static void Log(string text, string stack, LogType type)
    {
        if (!SessionState.GetBool(Prefix + "running", false) || (type != LogType.Error && type != LogType.Exception && type != LogType.Assert)) return;
        SessionState.SetInt(Prefix + "errors", SessionState.GetInt(Prefix + "errors", 0) + 1);
        File.AppendAllText(Output + "/errors.txt", type + ": " + text + "\n" + stack + "\n");
    }
    [Serializable] class Row { public string utc; public string action; public string detail; public int cycle; }
    static void Event(string action, string detail)
    {
        File.AppendAllText(Output + "/events.jsonl", JsonUtility.ToJson(new Row {utc=DateTime.UtcNow.ToString("O"),action=action,detail=detail,cycle=SessionState.GetInt(Prefix + "cycle",0)}) + "\n");
    }
    static void Finish(bool pass, string reason)
    {
        Event("complete", "pass=" + pass + "; errors=" + SessionState.GetInt(Prefix + "errors",0) + "; " + reason);
        SessionState.SetBool(Prefix + "running", false);
        File.WriteAllText(Output + "/completion.json", "{\"completed\":true,\"passed\":" + (pass ? "true" : "false") + ",\"errors\":" + SessionState.GetInt(Prefix + "errors",0) + "}");
        ReconstructionExit.Quit(pass ? 0 : 1);
    }
}

