using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

// Plays the unmodified original takeoff movie, then hands off to the live ship.
[DefaultExecutionOrder(-200)]
public class Round1Intro : MonoBehaviour
{
    public Round1Weapon weapon;
    public VideoPlayer video;
    public Canvas movieCanvas;
    public RawImage picture;
    public Text hint;
    public Button skipButton;
    public CanvasGroup stageTitle;
    public string movieFile="Truxton/demo_takeoff_10.mp4";
    public bool Active { get; private set; }
    public bool Prepared => video && video.isPrepared;
    public bool HidesShowcase => Active || (TitleAge<4 && weapon.player.SpawnAnimating);
    public bool CompletedNaturally { get; private set; }
    public string LastError { get; private set; }
    public float TitleAge { get; private set; }=10;
    RenderTexture target;
    float preparing;
    bool hooked;

    void Hook()
    {
        if(hooked)return;
        video.prepareCompleted+=Ready;video.loopPointReached+=Ended;video.errorReceived+=Failed;
        if(skipButton)skipButton.onClick.AddListener(Skip);hooked=true;
    }
    public void Begin()
    {
        Cancel();Hook();Active=true;CompletedNaturally=false;LastError=null;preparing=0;
        weapon.player.CancelSpawn();weapon.player.InputEnabled=false;weapon.player.bankingRoot.gameObject.SetActive(false);
        movieCanvas.enabled=true;
        if(!target){target=new RenderTexture(1920,1080,0,RenderTextureFormat.ARGB32);target.name="Original takeoff video";target.Create();}
        var previous=RenderTexture.active;RenderTexture.active=target;GL.Clear(true,true,Color.black);RenderTexture.active=previous;
        picture.texture=target;video.targetTexture=target;
        string path=Path.Combine(Application.streamingAssetsPath,movieFile);
        if(!File.Exists(path)){Failed(video,"Launch movie is missing: "+path);return;}
        video.url=path;video.Prepare();
    }
    void Ready(VideoPlayer source){if(Active && weapon.player.playback.playing)source.Play();}
    void Ended(VideoPlayer source){if(Active){CompletedNaturally=true;Finish();}}
    void Failed(VideoPlayer source,string error){LastError=error;Debug.LogWarning("Round1 launch movie: "+error);if(Active)Finish();}
    public void Skip(){if(Active)Finish();}
    void Finish()
    {
        Cancel();weapon.player.BeginSpawn();TitleAge=0;
        if(stageTitle){stageTitle.alpha=0;stageTitle.gameObject.SetActive(true);}
    }
    public void Cancel()
    {
        bool wasActive=Active;Active=false;
        if(video)video.Stop();if(movieCanvas)movieCanvas.enabled=false;
        TitleAge=10;if(stageTitle){stageTitle.alpha=0;stageTitle.gameObject.SetActive(false);}
        if(wasActive && weapon && weapon.player){weapon.player.InputEnabled=true;weapon.player.bankingRoot.gameObject.SetActive(true);}
    }
    void Update()
    {
        Tick(Time.unscaledDeltaTime);
        if(Active && weapon.player.playback.playing && (Input.GetKeyDown(KeyCode.Return)||Input.GetKeyDown(KeyCode.Space)))Skip();
    }
    public void Tick(float dt)
    {
        bool playing=weapon.player.playback.playing;
        if(Active)
        {
            if(skipButton)skipButton.interactable=playing;
            hint.text=playing?"ENTER / SPACE  Skip     P / ESC  Pause":"PAUSED     P / ESC  Resume     HOME  Restart";
            if(!Prepared){preparing+=Mathf.Max(0,dt);if(preparing>10)Failed(video,"Video preparation timed out");}
            else if(playing && !video.isPlaying)video.Play();else if(!playing && video.isPlaying)video.Pause();
        }
        else if(stageTitle && TitleAge<4)
        {
            if(playing)TitleAge+=Mathf.Max(0,dt);
            stageTitle.alpha=Mathf.Min(Mathf.Clamp01(TitleAge/.35f),Mathf.Clamp01((3.5f-TitleAge)/.65f));
            if(TitleAge>=3.5f)stageTitle.gameObject.SetActive(false);
        }
    }
    void OnDisable(){Cancel();}
    void OnDestroy()
    {
        if(hooked && video){video.prepareCompleted-=Ready;video.loopPointReached-=Ended;video.errorReceived-=Failed;}
        if(target){target.Release();Destroy(target);}
    }
}
