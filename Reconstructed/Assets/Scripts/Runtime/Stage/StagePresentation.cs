using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

// Plays an original stage timeline (BGxxStage) with the real Timeline package. The original stage kernel ticks the
// stage director in Manual update mode; this component does the same, so the background timeline (camera rail,
// scrolling objects, activation windows, controlled particles) runs exactly as authored.
// Child timelines whose tracks belong to InGame.Kernel (enemy, wave, event, BGM, area entries) are disabled for the
// run: their recovered classes are throw-null stubs, including constructors and clipCaps, so building their
// playables would fail. A root timeline that itself holds such a track is replaced at runtime by a copy that keeps
// only its ControlTracks. Nothing here is saved to the scene or to the original assets.
public sealed class StagePresentation : MonoBehaviour
{
    public PlayableDirector stage;
    public double time;
    public bool playing=true;
    [Range(0.1f,8)] public float speed=1;
    public bool loop=true;
    public bool showControls=true;
    // Set when another clock (Round1Playback in the playable stage scenes) seeks this presentation: no own input or ticking.
    public bool externallyDriven;

    public double Duration {get;private set;}
    public bool Ready {get;private set;}
    public readonly List<string> driven=new List<string>(), skipped=new List<string>(), rootTracksOmitted=new List<string>();
    TimelineAsset presentationCopy;

    public static bool IsTimelineTrack(TrackAsset track)=>track && track.GetType().Assembly==typeof(TimelineAsset).Assembly;
    static string CustomTracks(TimelineAsset timeline)=>string.Join(", ",timeline.GetOutputTracks().Where(t=>!IsTimelineTrack(t)).Select(t=>t.GetType().Name).Distinct());

    public static PlayableDirector FindStageDirector(Scene scene)
    {
        foreach(var root in scene.GetRootGameObjects())
            foreach(var director in root.GetComponentsInChildren<PlayableDirector>(true))
                if(director.playableAsset is TimelineAsset && director.playableAsset.name==director.gameObject.name && director.playableAsset.name.EndsWith("Stage"))return director;
        return null;
    }

    public void Prepare()
    {
        if(Ready)return;
        if(!stage)stage=FindStageDirector(gameObject.scene);
        var root=stage?stage.playableAsset as TimelineAsset:null;
        if(!root)throw new InvalidOperationException("No original stage timeline found in "+gameObject.scene.path);
        double end=0;
        foreach(var track in root.GetOutputTracks())
        {
            if(!(track is ControlTrack))continue;
            foreach(var clip in track.GetClips())
            {
                var control=clip.asset as ControlPlayableAsset;var source=control?control.sourceGameObject.Resolve(stage):null;
                if(!source)continue;
                var directors=control.searchHierarchy?source.GetComponentsInChildren<PlayableDirector>(true):source.GetComponents<PlayableDirector>();
                foreach(var director in directors)
                {
                    var timeline=director.playableAsset as TimelineAsset;
                    if(!timeline||director==stage)continue;
                    string custom=CustomTracks(timeline);
                    if(custom.Length==0)
                    {
                        driven.Add(director.name+" ("+timeline.name+")");
                        if(timeline.GetOutputTracks().Any())end=Math.Max(end,clip.end);
                        continue;
                    }
                    director.enabled=false;
                    skipped.Add(director.name+" ("+timeline.name+"): "+custom);
                }
            }
        }
        string rootCustom=CustomTracks(root);
        if(rootCustom.Length>0)
        {
            rootTracksOmitted.Add(rootCustom);
            presentationCopy=ControlTracksOnly(root);
            stage.playableAsset=presentationCopy;
        }
        UseFallbackRenderer();
        SetGameShaderGlobals();
        stage.timeUpdateMode=DirectorUpdateMode.Manual;
        stage.extrapolationMode=DirectorWrapMode.Hold;
        // Stop where the last background clip that has content ends. Past it the source objects revert (BG01's rail
        // camera switches off at 541 s while an empty BG01_ge clip runs the root on to 600 s).
        Duration=end>0?Math.Min(end,stage.playableAsset.duration):stage.playableAsset.duration;
        Ready=true;
        Seek(time);
    }

    // The original cameras ask for renderer 1 of the recovered TXE_PipelineAsset. The project's default pipeline has no
    // such renderer, so URP logs a warning every frame and then uses its default renderer anyway. Select that same
    // default explicitly for this run; under a pipeline that has the index, the cameras are left alone.
    public readonly List<string> rendererFallbacks=new List<string>();
    static readonly System.Reflection.FieldInfo RendererIndex=typeof(UniversalAdditionalCameraData).GetField("m_RendererIndex",System.Reflection.BindingFlags.Instance|System.Reflection.BindingFlags.NonPublic);
    void UseFallbackRenderer()
    {
        if(!(GraphicsSettings.currentRenderPipeline is UniversalRenderPipelineAsset urp)||RendererIndex==null)return;
        foreach(var root in gameObject.scene.GetRootGameObjects())
            foreach(var data in root.GetComponentsInChildren<UniversalAdditionalCameraData>(true))
            {
                int index=(int)RendererIndex.GetValue(data);var renderers=urp.rendererDataList;
                if(index<0||(index<renderers.Length&&renderers[index]))continue;
                data.SetRenderer(-1);
                rendererFallbacks.Add(data.name+": renderer "+index+" -> default ("+urp.name+")");
            }
    }

    // Recovered effect shaders scale time by the game-global _Tx_SpeedRate, which the (stubbed) game kernel sets.
    // 1 is normal game speed; without it those effects stay frozen.
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void SetGameShaderGlobals(){Shader.SetGlobalFloat("_Tx_SpeedRate",1);}

    // Same ControlTrack clips and ControlPlayableAsset settings; the exposed-reference ids still resolve through the
    // stage director's own reference table.
    static TimelineAsset ControlTracksOnly(TimelineAsset source)
    {
        var copy=ScriptableObject.CreateInstance<TimelineAsset>();
        copy.name=source.name;copy.hideFlags=HideFlags.DontSave;
        foreach(var track in source.GetOutputTracks().OfType<ControlTrack>())
        {
            var target=copy.CreateTrack<ControlTrack>(null,track.name);target.muted=track.muted;
            foreach(var clip in track.GetClips())
            {
                var from=(ControlPlayableAsset)clip.asset;var made=target.CreateClip<ControlPlayableAsset>();var to=(ControlPlayableAsset)made.asset;
                to.sourceGameObject=from.sourceGameObject;to.prefabGameObject=from.prefabGameObject;to.updateParticle=from.updateParticle;to.particleRandomSeed=from.particleRandomSeed;
                to.updateDirector=from.updateDirector;to.updateITimeControl=from.updateITimeControl;to.searchHierarchy=from.searchHierarchy;to.active=from.active;
                to.postPlayback=from.postPlayback;to.directorOnClipEnd=from.directorOnClipEnd;to.hideFlags=HideFlags.DontSave;
                made.start=clip.start;made.duration=clip.duration;made.clipIn=clip.clipIn;made.timeScale=clip.timeScale;made.displayName=clip.displayName;
            }
        }
        return copy;
    }

    public void Seek(double seconds)
    {
        if(!Ready){time=seconds;return;}
        time=Math.Max(0,Math.Min(seconds,Duration));
        stage.time=time;
        stage.Evaluate();
    }

    public void Step(float dt)
    {
        if(!Ready)Prepare();
        if(!playing)return;
        double next=time+Math.Max(0,dt)*speed;
        if(next>=Duration){if(loop)next=0;else{next=Duration;playing=false;}}
        Seek(next);
    }

    void Start(){Prepare();}
    void Update()
    {
        if(externallyDriven)return;
        if(Input.GetKeyDown(KeyCode.P)||Input.GetKeyDown(KeyCode.Space))playing=!playing;
        if(Input.GetKeyDown(KeyCode.PageUp))Seek(time+10);
        if(Input.GetKeyDown(KeyCode.PageDown))Seek(time-10);
        if(Input.GetKeyDown(KeyCode.Home))Seek(0);
        if(Input.GetKeyDown(KeyCode.Equals)||Input.GetKeyDown(KeyCode.KeypadPlus))speed=Mathf.Min(8,speed*2);
        if(Input.GetKeyDown(KeyCode.Minus)||Input.GetKeyDown(KeyCode.KeypadMinus))speed=Mathf.Max(.125f,speed/2);
        if(Input.GetKeyDown(KeyCode.Escape)&&Application.CanStreamedLevelBeLoaded("Hub"))SceneManager.LoadScene("Hub");
        Step(Time.deltaTime);
    }
    void OnDestroy(){if(presentationCopy){if(Application.isPlaying)Destroy(presentationCopy);else DestroyImmediate(presentationCopy);}}

    void OnGUI()
    {
        if(!showControls||!Ready)return;
        GUILayout.BeginArea(new Rect(16,16,Mathf.Min(Screen.width-32,620),150+18*skipped.Count),GUI.skin.box);
        GUILayout.Label(stage.name+"  —  original background timeline"+(GetComponent<StageEnemies>()?" and enemy schedule":""));
        GUILayout.Label($"{time:000.0} / {Duration:000.0} s   x{speed:0.###}   {(playing?"playing":"paused")}");
        double value=GUILayout.HorizontalSlider((float)time,0,(float)Duration);
        if(Math.Abs(value-time)>.05)Seek(value);
        GUILayout.Label("P / Space: pause   PgUp / PgDn: seek 10 s   + / -: speed   Home: restart   Esc: hub");
        GUILayout.Label("Playing: "+string.Join(", ",driven));
        foreach(var s in skipped)GUILayout.Label("Not run (unrecovered code): "+s);
        GUILayout.EndArea();
    }
}
