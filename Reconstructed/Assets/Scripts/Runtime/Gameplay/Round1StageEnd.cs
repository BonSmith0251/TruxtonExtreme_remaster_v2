using UnityEngine;
using UnityEngine.UI;

// End of a stage (remaster; user request 2026-11-02). When the round is cleared the original result label SUCCEEDED opens
// under a "STAGE CLEAR" line; when the last ship is lost the in-game GAME OVER logo opens with FAILED under it (art in
// Resources/Truxton/StageEndArt, result_open_01 as it opens). A blinking "PRESS ANY BUTTON" follows. On a clear, any
// button sends the ship away: the entrance's engine flame and ignition with the speed-up sound, a short dip, then full
// speed off the top of the screen; the next button restarts the stage. After a game over any button restarts. (The
// original game goes on to its result screen and has no exit clip, so the departure is drawn here.)
[DefaultExecutionOrder(90)]
public class Round1StageEnd : MonoBehaviour
{
    public enum Phase { None, Banner, Flying, Gone }
    public static Round1StageEnd Current { get; private set; }
    public static bool Handles => Current && Current.isActiveAndEnabled;
    public Phase State { get; private set; }
    public bool Won { get; private set; }
    public float FlyAge { get; private set; }
    public bool WaitingForPress => (State==Phase.Banner || State==Phase.Gone) && age>=OpenTime+PromptDelay;
    public string Log { get; private set; }="";

    const float WinDelay=1.2f,FailDelay=1.8f,OpenTime=.3f,PromptDelay=.6f;
    const float DipTime=.3f,Dip=.035f,Climb=2.4f,CenterTime=.9f,ExitY=1.3f,ArcadeAutoDepart=6;
    Round1Weapon weapon;Round1StageEndArt art;
    RectTransform panel,band,content;Graphic[] fading;RectTransform prompt;
    float age,wait;Vector2 flyStart;bool pressed;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    static void Boot(){Attach();UnityEngine.SceneManagement.SceneManager.sceneLoaded+=(scene,mode)=>Attach();}
    static void Attach(){var w=FindFirstObjectByType<Round1Weapon>();if(w && !w.GetComponent<Round1StageEnd>())w.gameObject.AddComponent<Round1StageEnd>();}
    void Awake(){weapon=GetComponent<Round1Weapon>();Current=this;art=Resources.Load<Round1StageEndArt>("Truxton/StageEndArt");}
    void OnDestroy(){if(Current==this)Current=null;}

    // Any button, or a test pressing it (ReconstructionStagePlayCheck STAGE_PLAY_END).
    public void Press(){pressed=true;}

    void Update()
    {
        if(!weapon || !weapon.player)return;
        bool won=weapon.RoundCleared,lost=weapon.GameOver;
        // Arcade: a lost game goes to the cabinet's continue countdown instead of the retry banner.
        if((!won && !lost) || (lost && ArcadeMachine.InGame)){if(State!=Phase.None)Close();wait=0;return;}
        if(State==Phase.None)
        {
            wait+=Time.unscaledDeltaTime;if(wait<(won?WinDelay:FailDelay))return;
            Open(won);
        }
        age+=Time.unscaledDeltaTime;
        // Arcade: cabinet buttons only (a coin must not send the ship off), and the ship leaves by itself after a while.
        bool press=pressed || (ArcadeMachine.Running?ArcadeMachine.ActionPressed:Input.anyKeyDown);pressed=false;
        if(ArcadeMachine.InGame && State==Phase.Banner && Won && age>=ArcadeAutoDepart)press=true;
        if(press && WaitingForPress)
        {
            if(State==Phase.Banner && Won)Depart();
            else {Note("restart");weapon.Restart();return;}
        }
        if(State==Phase.Flying)Fly(Time.deltaTime);
        Animate();
    }

    void Depart()
    {
        State=Phase.Flying;FlyAge=0;flyStart=weapon.player.viewportPosition;
        weapon.player.InputEnabled=false;weapon.player.SetBoost(true);Round1Sound.Event("speedUp");
        if(prompt)prompt.gameObject.SetActive(false);Note("depart");
    }
    // A short dip as the engines light, then a constant push up (and back to the centre line) until off the screen.
    void Fly(float dt)
    {
        FlyAge+=dt;var p=weapon.player;
        float dip=Dip*Mathf.Sin(Mathf.Clamp01(FlyAge/DipTime)*Mathf.PI*.5f);
        float climb=FlyAge>DipTime?Climb*(FlyAge-DipTime)*(FlyAge-DipTime):0;
        float x=Mathf.Lerp(flyStart.x,.5f,Mathf.SmoothStep(0,1,FlyAge/CenterTime));
        p.viewportPosition=new Vector2(x,flyStart.y-dip+climb);
        if(p.viewportPosition.y<ExitY)return;
        p.SetBoost(false);if(p.bankingRoot)p.bankingRoot.gameObject.SetActive(false);
        State=Phase.Gone;age=OpenTime;Note("gone");
        if(ArcadeMachine.InGame){ArcadeMachine.StageDeparted();return;}   // the cabinet loads the next stage
        SetPrompt("PRESS ANY BUTTON TO PLAY AGAIN");
    }

    void Open(bool won)
    {
        Won=won;State=Phase.Banner;age=0;Log="";Note(won?"banner succeeded":"banner failed");
        Round1Sound.Play("result_open_01");
        var hud=FindFirstObjectByType<Round1Hud>();
        var canvas=hud && hud.canvas?hud.canvas:null;
        if(!canvas){var go=new GameObject("Stage end canvas");go.hideFlags=HideFlags.DontSave;canvas=go.AddComponent<Canvas>();canvas.renderMode=RenderMode.ScreenSpaceOverlay;canvas.sortingOrder=50;
            var scaler=go.AddComponent<CanvasScaler>();scaler.uiScaleMode=CanvasScaler.ScaleMode.ScaleWithScreenSize;scaler.referenceResolution=new Vector2(1920,1080);}
        panel=Rect("Stage end",canvas.transform,Vector2.zero,Vector2.one);panel.SetAsLastSibling();
        band=Rect("Band",panel,new Vector2(0,.33f),new Vector2(1,.67f));
        var shade=band.gameObject.AddComponent<Image>();shade.color=new Color(0,0,0,.62f);shade.raycastTarget=false;
        content=Rect("Banner",panel,new Vector2(.5f,.5f),new Vector2(.5f,.5f));
        float width=((RectTransform)canvas.transform).rect.width;if(width<=0)width=1920;
        var glyphs=hud && hud.stateLabel?hud.stateLabel:null;
        if(won)
        {
            Glyphs(content,"STAGE CLEAR",glyphs,new Vector2(0,110),1.6f,Color.white);
            Sprite(content,art?art.succeeded:null,"SUCCEEDED",new Vector2(0,10),width*.42f);
        }
        else
        {
            Sprite(content,art?art.gameOver:null,"GAME OVER",new Vector2(0,55),width*.62f);
            Sprite(content,art?art.failed:null,"FAILED",new Vector2(0,-60),width*.24f);
        }
        prompt=Rect("Prompt",panel,new Vector2(.5f,.37f),new Vector2(.5f,.37f));
        SetPrompt(won?"PRESS ANY BUTTON":"PRESS ANY BUTTON TO RETRY");
        fading=content.GetComponentsInChildren<Graphic>(true);
        Animate();
    }
    void Close()
    {
        if(panel)Destroy(panel.gameObject);panel=null;State=Phase.None;age=wait=0;pressed=false;
        if(weapon && weapon.player)weapon.player.SetBoost(false);
    }
    // The band opens from the centre line, the banner settles from 1.3x as it fades in, the prompt blinks.
    void Animate()
    {
        if(!panel)return;
        float open=Mathf.SmoothStep(0,1,Mathf.Clamp01(age/OpenTime));
        band.localScale=new Vector3(1,open,1);
        content.localScale=Vector3.one*Mathf.Lerp(1.3f,1,open);
        foreach(var g in fading){var c=g.color;c.a=open;g.color=c;}
        if(prompt && prompt.gameObject.activeSelf)prompt.localScale=Vector3.one*(WaitingForPress && Mathf.Repeat(age,1f)<.65f?1:0);
    }

    void SetPrompt(string text)
    {
        if(!prompt)return;prompt.gameObject.SetActive(true);
        for(int i=prompt.childCount-1;i>=0;i--)Destroy(prompt.GetChild(i).gameObject);
        var hud=FindFirstObjectByType<Round1Hud>();
        Glyphs(prompt,text,hud?hud.stateLabel:null,Vector2.zero,1,new Color(1,.86f,.35f));
    }
    void Note(string what){Log+=(Log.Length>0?"; ":"")+what+" @"+(weapon && weapon.player?weapon.player.playback.elapsed.ToString("0.0"):"?");Debug.Log("[StageEnd] "+what);}

    static RectTransform Rect(string name,Transform parent,Vector2 min,Vector2 max)
    {
        var rt=new GameObject(name,typeof(RectTransform)).GetComponent<RectTransform>();rt.SetParent(parent,false);
        rt.anchorMin=min;rt.anchorMax=max;rt.offsetMin=rt.offsetMax=Vector2.zero;rt.gameObject.hideFlags=HideFlags.DontSave;return rt;
    }
    static void Sprite(RectTransform parent,Sprite sprite,string fallback,Vector2 at,float width)
    {
        var rt=Rect(fallback,parent,new Vector2(.5f,.5f),new Vector2(.5f,.5f));rt.anchoredPosition=at;
        if(sprite)
        {
            var image=rt.gameObject.AddComponent<Image>();image.sprite=sprite;image.raycastTarget=false;
            rt.sizeDelta=new Vector2(width,width*sprite.rect.height/Mathf.Max(1,sprite.rect.width));
        }
        else {rt.sizeDelta=new Vector2(width,width*.15f);var t=rt.gameObject.AddComponent<Text>();t.text=fallback;t.font=Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            t.fontSize=72;t.alignment=TextAnchor.MiddleCenter;t.raycastTarget=false;}
    }
    // A line in the HUD's own glyph font (the original game's), monospaced at the HUD label's cell size.
    static void Glyphs(RectTransform parent,string text,Round1HudText font,Vector2 at,float scale,Color tint)
    {
        var row=Rect(text,parent,new Vector2(.5f,.5f),new Vector2(.5f,.5f));row.anchoredPosition=at;
        if(!font || font.glyphs==null || font.cells==null || font.cells.Length==0)
        {
            row.sizeDelta=new Vector2(1200,60);var t=row.gameObject.AddComponent<Text>();t.text=text;t.font=Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            t.fontSize=Mathf.RoundToInt(40*scale);t.color=tint;t.alignment=TextAnchor.MiddleCenter;t.raycastTarget=false;return;
        }
        var cell=font.cells[0].rectTransform.rect.size*scale;if(cell.x<=0||cell.y<=0)cell=new Vector2(24,32)*scale;
        row.sizeDelta=new Vector2(cell.x*text.Length,cell.y);
        for(int i=0;i<text.Length;i++)
        {
            int index=char.ToUpperInvariant(text[i])-33;if(index<0 || index>=font.glyphs.Length || !font.glyphs[index])continue;
            var g=Rect(text[i].ToString(),row,new Vector2(0,.5f),new Vector2(0,.5f));g.sizeDelta=cell;g.anchoredPosition=new Vector2(cell.x*(i+.5f),0);
            var image=g.gameObject.AddComponent<RawImage>();image.texture=font.glyphs[index];image.color=tint;image.raycastTarget=false;
        }
    }
}
