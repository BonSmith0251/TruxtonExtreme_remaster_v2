using System;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
public sealed class ReconstructionHub : MonoBehaviour
{
    void OnGUI()
    {
        GUI.Box(new Rect(20,20,Mathf.Min(Screen.width-40,850),540), "Truxton Extreme — reconstruction workspace");
        GUILayout.BeginArea(new Rect(40,60,Mathf.Min(Screen.width-80,800),495));
        GUILayout.Label("Recovered original assets and scene graphs are available for editor inspection.");
        GUILayout.Label("Most original gameplay logic remains incomplete. Native method recovery and type shells are documented in the report.");
        GUILayout.Space(14);
        GUILayout.Label("Supplemental Round 1: prior independent remaster using recovered game assets and recorded movement evidence.");
        GUILayout.Label("Its gameplay, shaders and camera include approximations. This is a playable subset, not the original whole game.");
        if(GUILayout.Button("Arcade: the original ARCADE mode as a coin-op cabinet (5 coin, 1 start, F2 operator)",GUILayout.Height(40))) SceneManager.LoadScene("ArcadeBoot");
        if(GUILayout.Button("Play supplemental Round 1",GUILayout.Height(40))) SceneManager.LoadScene("Round1");
        GUILayout.Label("WASD / arrows: move; Space / Z: fire; X: bomb; C: weapon; Esc / P: pause; F4: autopilot.");
        GUILayout.Space(14);
        GUILayout.Label("Original stage timelines: the recovered BG01–BG08 background timelines played by the real Timeline package.");
        GUILayout.Label("Watch: enemies follow the original schedules and routes, without combat. Shaders are recovered from the originals.");
        GUILayout.BeginHorizontal();
        for(int i=1;i<=8;i++)if(GUILayout.Button("BG"+i.ToString("00"),GUILayout.Height(32)))SceneManager.LoadScene("StageInspection_BG"+i.ToString("00"));
        GUILayout.EndHorizontal();
        GUILayout.Space(10);
        GUILayout.Label("Play: the same stages with the Round 1 ship, weapons, combat and original enemy fire, HP, scores and hit shapes.");
        GUILayout.Label("Bosses other than BG03's are not reconstructed: those stages end at their boss time.");
        GUILayout.BeginHorizontal();
        for(int i=1;i<=8;i++)if(GUILayout.Button("Play "+i,GUILayout.Height(32)))SceneManager.LoadScene("StagePlay_BG"+i.ToString("00"));
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
public sealed class ReconstructionRunEvidence : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    static void StartEvidence()
    {
        if(Array.IndexOf(Environment.GetCommandLineArgs(),"-reconstruction-capture")<0)return;
        var o=new GameObject("Reconstruction validation capture");DontDestroyOnLoad(o);o.AddComponent<ReconstructionRunEvidence>();
    }
    IEnumerator Start()
    {
        SceneManager.LoadScene("Round1");
        yield return null;
        var playback=FindFirstObjectByType<Round1Playback>();var cameraStart=playback&&playback.player&&playback.player.stageCamera?playback.player.stageCamera.transform.position:Vector3.zero;float stageStart=playback?playback.elapsed:0;
        yield return new WaitForSecondsRealtime(12);
        string root=Path.GetFullPath(Path.Combine(Application.dataPath,"../../evidence/scene-integration"));Directory.CreateDirectory(root);
        ScreenCapture.CaptureScreenshot(Path.Combine(root,"supplement-player.png"));
        Debug.Log("RECONSTRUCTION_CAPTURE_REQUESTED "+root);
        yield return new WaitForSecondsRealtime(4);
        File.WriteAllText(Path.Combine(root,"player-runtime.json"),JsonUtility.ToJson(new RuntimeReport {unity=Application.unityVersion,scene=SceneManager.GetActiveScene().path,frames=Time.frameCount,graphics=SystemInfo.graphicsDeviceName,api=SystemInfo.graphicsDeviceType.ToString(),stageStart=stageStart,stageEnd=playback?playback.elapsed:0,cameraStart=cameraStart,cameraEnd=playback&&playback.player&&playback.player.stageCamera?playback.player.stageCamera.transform.position:Vector3.zero,cameraClipLegacy=playback&&playback.cameraMotion?playback.cameraMotion.legacy:false,cameraAnimatorPresent=playback&&playback.cameraRail&&playback.cameraRail.GetComponent<Animator>()},true));
        Application.Quit();
    }
    [Serializable] class RuntimeReport {public string unity,scene,graphics,api;public int frames;public float stageStart,stageEnd;public Vector3 cameraStart,cameraEnd;public bool cameraClipLegacy,cameraAnimatorPresent;}
}
