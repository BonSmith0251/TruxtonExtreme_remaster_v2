using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// The cabinet (user request 2026-11-02): attract loop (title, best-10 table, autopilot demo), coins and credits, START,
// the original ARCADE mode run through the stages in order with the ship carried along (ArcadeRules), continue
// countdown, game over, initials entry and the saved table, and an operator menu. It lives in the ArcadeBoot scene and
// stays across the stage scene loads.
// Keys (keyboard / XInput pad): 5 or View = coin A, 6 = coin B, 1 or Enter or Menu = start, Space/Z or A = fire/confirm,
// X/Backspace or B = back, arrows/WASD or stick = move, F9 = service credit, F2 = test switch: the service mode
// (ArcadeService.cs; entering it ends a game in progress, as a cabinet's test switch does).
// While it runs the stage scenes' desktop keys (pause, restart, seek, autopilot, boss jump, help) are off.
[DefaultExecutionOrder(-50)]
public sealed partial class ArcadeMachine : MonoBehaviour
{
    public enum Mode { Title, Rankings, Demo, Loading, Playing, Continue, GameOver, Initials, Ending, Operator }
    public const string BootScene="ArcadeBoot";
    public static ArcadeMachine Instance { get; private set; }
    public static bool Running=>Instance;
    // A credit's game owns the stage end: no retry banner on a loss; the ship's departure leads to the next stage.
    public static bool InGame=>Instance && Instance.session!=null;
    // Fire or start this frame (cabinet buttons only, so a coin does not skip a banner).
    public static bool ActionPressed=>Instance && (Instance.fireDown || Instance.startDown);
    public static string HudLine=>Instance && Instance.mode==Mode.Demo?"DEMO PLAY":"";

    public Mode State=>mode;
    public ArcadeSettings settings;
    public ArcadeLedger ledger;
    public ArcadeRankings rankings;
    // Not serialized: Unity would otherwise make an empty session at load and the cabinet would think a game was on.
    [System.NonSerialized] public ArcadeSession session;
    public Round1Weapon Weapon=>weapon;
    public float ContinueCount=>countdown;
    public int LastRank { get; private set; }=-1;
    public readonly List<string> Events=new List<string>();

    const float TitleSeconds=12,RankingSeconds=10,GameOverSeconds=4,EndingSeconds=8,InitialsSeconds=30,TableSeconds=5,GameOverDelay=1.6f;
    const string Letters="ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.!?- ";
    static readonly Color Gold=new Color(1,.86f,.35f),Cyan=new Color(.45f,.9f,1),Dim=new Color(.7f,.7f,.75f);

    Mode mode=Mode.Title;float age,countdown,gameOverWait,repeatAt;bool coinDown,coinBDown,startDown,fireDown,backDown,serviceDown,operatorDown;
    Vector2Int dirDown,heldDir;readonly List<string> injected=new List<string>();
    ArcadeStorage storage;ArcadeArt art;Round1StageEndArt endArt;Round1Weapon weapon;AudioSource music;
    bool configurePending;int demoIndex;
    int slot,operatorRow;readonly int[] picks=new int[3];bool committed;

    // ---------------- lifecycle ----------------
    void Awake()
    {
        if(Instance && Instance!=this){Destroy(gameObject);return;}
        Instance=this;DontDestroyOnLoad(gameObject);
        storage=new ArcadeStorage(ArcadeStorage.DefaultRoot());
        settings=storage.Load("settings",()=>new ArcadeSettings());settings.Clamp();
        ledger=storage.Load("ledger",()=>new ArcadeLedger());
        rankings=storage.Load("rankings",ArcadeRankings.Defaults);if(rankings.entries==null || rankings.entries.Count==0)rankings=ArcadeRankings.Defaults();
        art=Resources.Load<ArcadeArt>("Truxton/ArcadeArt");endArt=Resources.Load<Round1StageEndArt>("Truxton/StageEndArt");
        music=gameObject.AddComponent<AudioSource>();music.playOnAwake=false;music.spatialBlend=0;music.ignoreListenerVolume=false;
        BuildCanvas();SceneManager.sceneLoaded+=OnSceneLoaded;Cursor.visible=false;ApplySettings();
        Note("boot data="+storage.root);Enter(Mode.Title);
    }
    void OnDestroy()
    {
        if(Instance!=this)return;
        Instance=null;SceneManager.sceneLoaded-=OnSceneLoaded;Cursor.visible=true;AudioListener.volume=1;
        if(canvas)Destroy(canvas.gameObject);
    }

    // Test hooks (ReconstructionArcadeCheck): the same logical buttons as the cabinet, read on the next frame.
    public void Inject(string button){injected.Add(button);}
    public int PendingInputs=>injected.Count;

    void Update()
    {
        ReadInput();float dt=Time.unscaledDeltaTime;age+=dt;
        // The input test shows coins and service presses without counting them.
        if(!(mode==Mode.Operator && servicePage==ServicePage.Input))
        {
            if(coinDown)Coin(0);if(coinBDown)Coin(1);
            if(serviceDown){ledger.ServiceCredit(settings);SaveLedger();Note("service credit "+ledger.credits);}
        }
        if(operatorDown && mode!=Mode.Operator){OpenOperator();return;}
        switch(mode)
        {
            case Mode.Title:if(TryStart())return;if(age>TitleSeconds)Enter(Mode.Rankings);break;
            case Mode.Rankings:if(TryStart())return;if(age>RankingSeconds)StartDemo();break;
            case Mode.Demo:if(TryStart())return;if(age>settings.demoSeconds || !weapon)ReturnToTitle();break;
            case Mode.Playing:Monitor(dt);break;
            case Mode.Continue:StepContinue(dt);break;
            case Mode.GameOver:if(age>GameOverSeconds)AfterGame();break;
            case Mode.Ending:if(age>EndingSeconds)AfterGame();break;
            case Mode.Initials:StepInitials();break;
            case Mode.Operator:StepOperator();break;
        }
        Refresh();
    }

    void Coin(int chute)
    {
        int added=ledger.InsertCoin(settings,chute);SaveLedger();Round1Sound.Play("se_cursor_001");
        Note("coin "+(chute==1?"B":"A")+(added>0?" -> credits "+ledger.credits:""));
    }
    void ReadInput()
    {
        coinDown=Edge("COIN A","coin");coinBDown=Edge("COIN B","coinB");startDown=Edge("START","start");fireDown=Edge("FIRE","fire");
        backDown=Edge("BOMB / BACK","back");serviceDown=Edge("SERVICE","service");operatorDown=Edge("TEST","operator");
        // Directions fire once on press, then repeat while held (menus only).
        var held=Vector2Int.zero;
        if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))held.x--;if(Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))held.x++;
        if(Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S))held.y--;if(Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.W))held.y++;
        if(held==Vector2Int.zero){float x=Axis("Horizontal"),y=Axis("Vertical");held=new Vector2Int(Mathf.Abs(x)>.5f?(int)Mathf.Sign(x):0,Mathf.Abs(y)>.5f?(int)Mathf.Sign(y):0);}
        dirDown=Vector2Int.zero;
        if(held!=heldDir){heldDir=held;dirDown=held;repeatAt=Time.unscaledTime+.35f;}
        else if(held!=Vector2Int.zero && Time.unscaledTime>=repeatAt){dirDown=held;repeatAt=Time.unscaledTime+.08f;}
        foreach(string d in new[]{"left","right","up","down"})if(Take(d)){dirDown=d=="left"?Vector2Int.left:d=="right"?Vector2Int.right:d=="up"?Vector2Int.up:Vector2Int.down;Mark(d.ToUpperInvariant());}
    }
    bool Edge(string button,string injectedName){if(Pressed(button))return true;if(!Take(injectedName))return false;Mark(button);return true;}
    static float Axis(string name){try{return Input.GetAxisRaw(name);}catch{return 0;}}
    bool Take(string button){int i=injected.IndexOf(button);if(i<0)return false;injected.RemoveAt(i);return true;}

    // ---------------- attract ----------------
    bool TryStart()
    {
        if(!startDown || !ledger.CanPay(settings))return false;
        ledger.Pay(settings,false);SaveLedger();Round1Sound.Play("se_ok_001");
        session=new ArcadeSession{stageIndex=settings.startStage-1};Note("start game credits="+ledger.credits);
        LoadStage(false);return true;
    }
    void StartDemo()
    {
        int stage=demoIndex++%3;Note("demo "+ArcadeRules.StageOrder[stage]);
        StartCoroutine(Load(ArcadeRules.SceneFor(stage),true,""));
    }
    void ReturnToTitle()
    {
        StopAllCoroutines();session=null;weapon=null;configurePending=false;
        Time.timeScale=1;ApplyAudio(false);Round1Sound.StopAll();
        if(SceneManager.GetActiveScene().name!=BootScene)SceneManager.LoadScene(BootScene);
        Enter(Mode.Title);
    }

    // ---------------- stages ----------------
    void LoadStage(bool skipCard)
    {
        string card=skipCard?"":"STAGE "+session.StageNumber+(session.round>1?"   ROUND "+session.round:"");
        StartCoroutine(Load(ArcadeRules.SceneFor(session.stageIndex),false,card));
    }
    IEnumerator Load(string scene,bool demo,string card)
    {
        loadingCard=card;Enter(Mode.Loading);Refresh();
        weapon=null;Time.timeScale=1;Round1Sound.StopAll();music.Stop();
        ApplyAudio(demo);
        float shown=Time.unscaledTime;
        var op=SceneManager.LoadSceneAsync(scene);
        if(op==null){Fail("cannot load "+scene,demo);yield break;}
        configurePending=true;op.allowSceneActivation=false;
        while(op.progress<.9f || Time.unscaledTime-shown<(card.Length>0?1.6f:.2f))yield return null;
        op.allowSceneActivation=true;
        while(!op.isDone)yield return null;
        yield return null;   // the stage scripts' Start (Round1Weapon.Initialize) runs before we set the run up
        weapon=FindFirstObjectByType<Round1Weapon>();
        if(!weapon || !weapon.player){Fail("no ship in "+scene,demo);yield break;}
        if(demo)
        {
            weapon.BeginArcadeStage(null,settings.startLives,rankings.Top);weapon.verificationShield=true;
            if(weapon.intro)weapon.intro.Skip();if(weapon.autopilot)weapon.autopilot.SetAutomatic(true);
        }
        else
        {
            weapon.awakenUnlock=Mathf.Clamp(settings.evolution,0,2);weapon.BeginArcadeStage(session.carry,settings.startLives,rankings.Top,session.stageIndex,session.round);weapon.autoBomb=settings.autoBomb;
            if(weapon.autopilot)weapon.autopilot.SetAutomatic(false);
            // The takeoff movie belongs to a credit's first stage; later stages start with the ship's arrival.
            if(session.carry!=null && weapon.intro)weapon.intro.Skip();
        }
        HideDesktopHud();gameOverWait=0;
        Note((demo?"demo in ":"stage in ")+scene+" lives="+weapon.Lives+" score="+weapon.Score+" level="+weapon.Level);
        Enter(demo?Mode.Demo:Mode.Playing);
    }
    // A failed load does not spend the credit: it is given back and the cabinet returns to the title.
    void Fail(string why,bool demo)
    {
        Debug.LogError("[Arcade] "+why);Note("fail "+why);
        if(!demo && session!=null && !settings.freePlay && session.clearCount==0 && session.continues==0){ledger.credits++;SaveLedger();}
        ReturnToTitle();
    }
    // Before the stage's Start: the original ARCADE schedule mode and bullet rules (Story A's at difficulty EASY), no
    // desktop controls box.
    void OnSceneLoaded(Scene scene,LoadSceneMode loadMode)
    {
        if(!configurePending)return;configurePending=false;
        foreach(var w in FindObjectsByType<Round1EnemyWaves>(FindObjectsInactive.Include,FindObjectsSortMode.None))w.gameModeMask=settings.GameModeMask;
        foreach(var a in FindObjectsByType<Round1EnemyAttacks>(FindObjectsInactive.Include,FindObjectsSortMode.None))a.selectorMode=settings.SelectorMode;
        foreach(var s in FindObjectsByType<StageEnemies>(FindObjectsInactive.Include,FindObjectsSortMode.None))s.gameModeMask=settings.GameModeMask;
        foreach(var p in FindObjectsByType<Round1Playback>(FindObjectsInactive.Include,FindObjectsSortMode.None))p.showControls=false;
    }
    void HideDesktopHud()
    {
        var hud=FindFirstObjectByType<Round1Hud>();if(!hud)return;
        foreach(var b in new Selectable[]{hud.pauseButton,hud.restartButton,hud.bombButton,hud.changeButton,hud.helpButton})if(b)b.gameObject.SetActive(false);
        if(hud.helpPanel)hud.helpPanel.SetActive(false);
    }
    void Monitor(float dt)
    {
        if(!weapon){Fail("stage scene lost",false);return;}
        ledger.playSeconds+=dt;
        settings.Extends(out long start,out long step,out long end);
        int due=ArcadeRules.ExtendsFor(weapon.Score,start,step,end);
        while(session.extendsGiven<due){session.extendsGiven++;ledger.extendsGiven++;weapon.GrantExtend();Note("extend at "+weapon.Score);}
        if(!weapon.GameOver){gameOverWait=0;return;}
        gameOverWait+=dt;if(gameOverWait<GameOverDelay)return;
        SaveLedger();
        if(settings.continues){countdown=settings.continueSeconds+.999f;Enter(Mode.Continue);}else Enter(Mode.GameOver);
    }
    // Round1StageEnd: the cleared stage's ship has left the screen.
    public static void StageDeparted(){if(Instance)Instance.NextStage();}
    void NextStage()
    {
        if(mode!=Mode.Playing || session==null || !weapon)return;
        session.carry=weapon.CaptureCarry();session.clearCount++;session.stageIndex++;
        Note("cleared "+(session.clearCount)+" score="+session.carry.score);
        if(session.stageIndex<ArcadeRules.StageOrder.Length){LoadStage(false);return;}
        if(settings.roundLoop && session.round<2){session.round++;session.stageIndex=0;Note("round loop "+session.round);LoadStage(false);return;}
        session.allClear=true;ledger.allClears++;SaveLedger();Enter(Mode.Ending);
    }

    // ---------------- continue / game over / initials ----------------
    void StepContinue(float dt)
    {
        if(!weapon){Fail("stage scene lost",false);return;}
        if(fireDown){countdown=Mathf.Floor(countdown)-.001f;Round1Sound.Play("se_cursor_001");}
        countdown-=dt;
        if(startDown && ledger.Pay(settings,true))
        {
            SaveLedger();session.continues++;weapon.ArcadeContinue(settings.startLives);Round1Sound.Play("se_ok_001");
            Note("continue "+session.continues+" credits="+ledger.credits);gameOverWait=0;Enter(Mode.Playing);return;
        }
        if(countdown<=0)Enter(Mode.GameOver);
    }
    long FinalScore=>session!=null && session.carry!=null && !weapon?session.carry.score:weapon?weapon.Score:0;
    void AfterGame()
    {
        if(session!=null && rankings.Qualifies(FinalScore)){slot=0;committed=false;for(int i=0;i<3;i++)picks[i]=0;finalScore=FinalScore;Enter(Mode.Initials);}
        else ReturnToTitle();
    }
    long finalScore;
    void StepInitials()
    {
        if(committed){if(age>TableSeconds)ReturnToTitle();return;}
        if(dirDown.x!=0 || dirDown.y!=0){int d=dirDown.x!=0?dirDown.x:dirDown.y;picks[slot]=(picks[slot]+d+Letters.Length)%Letters.Length;Round1Sound.Play("se_cursor_001");}
        if(backDown && slot>0){slot--;Round1Sound.Event("cancel");}
        if(fireDown || startDown){Round1Sound.Play("se_ok_001");if(++slot>=3){Commit();return;}}
        if(age>InitialsSeconds)Commit();
    }
    void Commit()
    {
        var entry=new ArcadeRankEntry{initials=Initials,score=finalScore,stage=session!=null?Mathf.Min(session.StageNumber,8):1,round=session!=null?session.round:1,
            continues=session!=null?session.continues:0,allClear=session!=null && session.allClear,date=System.DateTime.Now.ToString("yyyy-MM-dd")};
        LastRank=rankings.Insert(entry);storage.Save("rankings",rankings);committed=true;age=0;
        Note("initials "+entry.initials+" "+entry.score+" rank "+(LastRank+1));Build();
    }
    string Initials{get{var c=new char[3];for(int i=0;i<3;i++)c[i]=Letters[picks[i]];return new string(c);}}

    void SaveLedger(){storage.Save("ledger",ledger);}
    void Note(string what){string line=Time.unscaledTime.ToString("0.0")+" "+mode+": "+what;Events.Add(line);Debug.Log("[Arcade] "+line);}

    // ---------------- screens ----------------
    Canvas canvas;RectTransform page;string loadingCard="";
    readonly Dictionary<string,Glyphs> live=new Dictionary<string,Glyphs>();
    Glyphs credit;

    void Enter(Mode next)
    {
        mode=next;age=0;
        PlayMusic(!art?null:(next==Mode.Title || next==Mode.Rankings) && settings.attractMusic?art.titleMusic:next==Mode.Initials?art.nameEntryMusic:null);
        Build();
    }
    void PlayMusic(AudioClip clip)
    {
        if(!clip){music.Stop();return;}
        if(music.clip==clip && music.isPlaying)return;
        music.clip=clip;music.loop=clip!=(art?art.nameEntryMusic:null);music.volume=.8f*settings.musicVolume/10f;music.Play();
    }
    void BuildCanvas()
    {
        var go=new GameObject("Arcade screens");DontDestroyOnLoad(go);
        canvas=go.AddComponent<Canvas>();canvas.renderMode=RenderMode.ScreenSpaceOverlay;canvas.sortingOrder=500;
        var scaler=go.AddComponent<CanvasScaler>();scaler.uiScaleMode=CanvasScaler.ScaleMode.ScaleWithScreenSize;scaler.referenceResolution=new Vector2(1920,1080);scaler.matchWidthOrHeight=1;
        credit=new Glyphs(Rect("Credit",canvas.transform,new Vector2(.5f,0),new Vector2(.5f,0),new Vector2(0,34)),art,.7f);
    }
    void Build()
    {
        if(!canvas)return;
        if(page)Destroy(page.gameObject);live.Clear();
        page=Rect("Page "+mode,canvas.transform,Vector2.zero,Vector2.one,Vector2.zero);page.SetAsFirstSibling();
        switch(mode)
        {
            case Mode.Title:
                Picture(page,art?art.titleBack:null,true);
                Picture(page,art?art.titleLogo:null,false,new Vector2(0,90),780);
                Text("high","HIGH SCORE  "+rankings.Top,new Vector2(.5f,1),new Vector2(0,-70),.9f,Gold);
                Text("prompt","",new Vector2(.5f,.5f),new Vector2(0,-390),1.1f,Color.white);
                break;
            case Mode.Rankings:
                Shade(page,.85f);Table(new Vector2(0,330),-1);
                Text("prompt","",new Vector2(.5f,0),new Vector2(0,130),1,Color.white);
                break;
            case Mode.Demo:
                Text("demo","DEMO PLAY",new Vector2(.5f,1),new Vector2(0,-150),1.2f,Cyan);
                Text("prompt","",new Vector2(.5f,0),new Vector2(0,190),1.1f,Color.white);
                break;
            case Mode.Loading:
                Shade(page,1);
                if(loadingCard.Length>0)Text("card",loadingCard,new Vector2(.5f,.5f),Vector2.zero,1.6f,Gold);
                break;
            case Mode.Continue:
                Band(page,.3f,.72f,.7f);
                Text("title","CONTINUE?",new Vector2(.5f,.5f),new Vector2(0,150),1.8f,Gold);
                Text("count","",new Vector2(.5f,.5f),new Vector2(0,10),4f,Color.white);
                Text("prompt","",new Vector2(.5f,.5f),new Vector2(0,-130),1.1f,Color.white);
                break;
            case Mode.GameOver:
                Band(page,.3f,.7f,.75f);
                Picture(page,endArt?endArt.gameOver:null,"GAME OVER",new Vector2(0,40),1100);
                Text("score","SCORE  "+FinalScore,new Vector2(.5f,.5f),new Vector2(0,-110),1,Color.white);
                break;
            case Mode.Ending:
                Shade(page,.8f);
                Text("a","CONGRATULATIONS",new Vector2(.5f,.5f),new Vector2(0,170),1.8f,Gold);
                Text("b","ALL STAGES CLEAR",new Vector2(.5f,.5f),new Vector2(0,60),1.3f,Color.white);
                Text("c",session!=null && session.round>1?"ROUND "+session.round+" COMPLETE":"",new Vector2(.5f,.5f),new Vector2(0,-20),1,Cyan);
                Text("d","SCORE  "+FinalScore,new Vector2(.5f,.5f),new Vector2(0,-120),1.1f,Color.white);
                break;
            case Mode.Initials:
                Shade(page,.88f);
                if(!committed)
                {
                    Text("head","ENTER YOUR INITIALS",new Vector2(.5f,1),new Vector2(0,-110),1.3f,Gold);
                    Text("score","SCORE  "+finalScore,new Vector2(.5f,1),new Vector2(0,-190),1,Color.white);
                    for(int i=0;i<3;i++)Text("slot"+i,"",new Vector2(.5f,1),new Vector2((i-1)*110,-320),2.4f,Color.white);
                    Text("time","",new Vector2(.5f,1),new Vector2(0,-430),.9f,Dim);
                    Text("help","LEFT RIGHT  CHOOSE    FIRE  NEXT    BACK  ERASE",new Vector2(.5f,0),new Vector2(0,80),.7f,Dim);
                    Table(new Vector2(0,45),-1,.75f);
                }
                else {Text("head","BEST 10",new Vector2(.5f,1),new Vector2(0,-110),1.3f,Gold);Table(new Vector2(0,320),LastRank);}
                break;
            case Mode.Operator:BuildService();break;
        }
    }
    // Per frame: blinking prompts, countdown, initials slots, the credit line.
    void Refresh()
    {
        bool blink=Mathf.Repeat(Time.unscaledTime,1)<.65f;
        string prompt=settings.freePlay?"FREE PLAY  PRESS START":ledger.credits>0?"PRESS START":"INSERT COIN";
        if(live.TryGetValue("prompt",out var p))p.Set(blink?prompt:"");
        if(mode==Mode.Continue)
        {
            if(live.TryGetValue("count",out var c))c.Set(Mathf.Max(0,(int)countdown).ToString());
            if(live.TryGetValue("prompt",out var cp))cp.Set(blink?(ledger.CanPay(settings)?"PRESS START":"INSERT COIN"):"");
        }
        if(mode==Mode.Initials && !committed)
        {
            for(int i=0;i<3;i++)if(live.TryGetValue("slot"+i,out var s)){s.tint=i==slot?Gold:i<slot?Color.white:Dim;s.Set(i==slot && !blink?"_":Letters[picks[i]]==' '?"_":Letters[picks[i]].ToString());}
            if(live.TryGetValue("time",out var t))t.Set("TIME "+Mathf.Max(0,(int)(InitialsSeconds-age)));
        }
        if(mode==Mode.Operator)RefreshService();
        bool showCredit=settings.showCredits && mode!=Mode.Operator && mode!=Mode.Loading;
        credit.Set(showCredit?(settings.freePlay?"FREE PLAY":"CREDIT "+ledger.credits):"");
    }
    void Table(Vector2 at,int highlight,float scale=1)
    {
        for(int i=0;i<rankings.entries.Count;i++)
        {
            var e=rankings.entries[i];
            string rank=(i+1)+(i==0?"ST":i==1?"ND":i==2?"RD":"TH");
            string reach=e.allClear?"ALL":"ST"+e.stage+(e.round>1?"-"+e.round:"");
            string line=rank.PadRight(5)+e.initials.PadRight(5)+e.score.ToString().PadLeft(10)+"  "+reach.PadRight(6);
            Text("rank"+i,line,new Vector2(.5f,.5f),at+new Vector2(0,-i*62*scale),.95f*scale,i==highlight?Gold:i<3?Color.white:Dim);
        }
    }
    Glyphs Text(string key,string value,Vector2 anchor,Vector2 at,float scale,Color tint)
    {
        var g=new Glyphs(Rect(key,page,anchor,anchor,at),art,scale){tint=tint};g.Set(value);live[key]=g;return g;
    }
    static void Shade(RectTransform parent,float alpha){var img=Rect("Shade",parent,Vector2.zero,Vector2.one,Vector2.zero).gameObject.AddComponent<Image>();img.color=new Color(0,0,0,alpha);img.raycastTarget=false;}
    static void Band(RectTransform parent,float from,float to,float alpha){var img=Rect("Band",parent,new Vector2(0,from),new Vector2(1,to),Vector2.zero).gameObject.AddComponent<Image>();img.color=new Color(0,0,0,alpha);img.raycastTarget=false;}
    static void Picture(RectTransform parent,Texture2D texture,bool fill,Vector2 at=default,float width=0)
    {
        if(!texture){if(fill)Shade(parent,1);return;}
        var rt=Rect(texture.name,parent,fill?Vector2.zero:new Vector2(.5f,.5f),fill?Vector2.one:new Vector2(.5f,.5f),fill?Vector2.zero:at);
        var img=rt.gameObject.AddComponent<RawImage>();img.texture=texture;img.raycastTarget=false;
        if(fill){var fit=rt.gameObject.AddComponent<AspectRatioFitter>();fit.aspectMode=AspectRatioFitter.AspectMode.EnvelopeParent;fit.aspectRatio=(float)texture.width/Mathf.Max(1,texture.height);}
        else rt.sizeDelta=new Vector2(width,width*texture.height/Mathf.Max(1,texture.width));
    }
    void Picture(RectTransform parent,Sprite sprite,string fallback,Vector2 at,float width)
    {
        if(!sprite){Text("fallback",fallback,new Vector2(.5f,.5f),at,2,Color.white);return;}
        var rt=Rect(fallback,parent,new Vector2(.5f,.5f),new Vector2(.5f,.5f),at);var img=rt.gameObject.AddComponent<Image>();img.sprite=sprite;img.raycastTarget=false;
        rt.sizeDelta=new Vector2(width,width*sprite.rect.height/Mathf.Max(1,sprite.rect.width));
    }
    static RectTransform Rect(string name,Transform parent,Vector2 min,Vector2 max,Vector2 at)
    {
        var rt=new GameObject(name,typeof(RectTransform)).GetComponent<RectTransform>();rt.SetParent(parent,false);
        rt.anchorMin=min;rt.anchorMax=max;rt.anchoredPosition=at;if(min!=max)rt.offsetMin=rt.offsetMax=Vector2.zero;else rt.sizeDelta=Vector2.zero;return rt;
    }

    // A centred line in the original HUD glyph font (ui_font01, monospaced), or the built-in font without the art.
    sealed class Glyphs
    {
        readonly RectTransform row;readonly ArcadeArt art;readonly Vector2 cell;readonly List<RawImage> cells=new List<RawImage>();
        UnityEngine.UI.Text fallback;string value;Color shown;public Color tint=Color.white;
        public Glyphs(RectTransform row,ArcadeArt art,float scale){this.row=row;this.art=art;cell=new Vector2(34,46)*scale;}
        public void Set(string text)
        {
            if(text==value && shown==tint)return;value=text;shown=tint;
            if(art==null || art.glyphs==null || art.glyphs.Length==0)
            {
                if(!fallback){fallback=row.gameObject.AddComponent<UnityEngine.UI.Text>();fallback.font=Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");fallback.alignment=TextAnchor.MiddleCenter;
                    fallback.horizontalOverflow=HorizontalWrapMode.Overflow;fallback.fontSize=Mathf.RoundToInt(cell.y*.85f);fallback.raycastTarget=false;row.sizeDelta=new Vector2(1600,cell.y);}
                fallback.text=text;fallback.color=tint;return;
            }
            while(cells.Count<text.Length)
            {
                var rt=Rect("c",row,new Vector2(.5f,.5f),new Vector2(.5f,.5f),Vector2.zero);rt.sizeDelta=cell;
                var img=rt.gameObject.AddComponent<RawImage>();img.raycastTarget=false;cells.Add(img);
            }
            for(int i=0;i<cells.Count;i++)
            {
                int index=i<text.Length?char.ToUpperInvariant(text[i])-33:-1;
                bool on=index>=0 && index<art.glyphs.Length && art.glyphs[index];
                cells[i].enabled=on;if(!on)continue;
                cells[i].texture=art.glyphs[index];cells[i].color=tint;
                cells[i].rectTransform.anchoredPosition=new Vector2((i-(text.Length-1)*.5f)*cell.x,0);
            }
        }
    }
}
