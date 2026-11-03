using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Service mode (the cabinet's test switch, F2; user request 2026-11-02 "arcade game machine settings"): pages for game,
// coin, sound and display settings, an input test, screen test patterns and bookkeeping, laid out like a coin-op's
// test menu. Up/down select, left/right change, fire/start set or enter, back or F2 return; resets ask twice.
// Settings save when a page is left. Display changes apply to the built player (the editor keeps its Game view).
public sealed partial class ArcadeMachine
{
    public enum ServicePage { Menu, Game, Coin, Sound, Display, Input, Screen, Bookkeeping }
    public ServicePage Page=>servicePage;
    public string SelectedLabel{get{var rows=Rows();return operatorRow<rows.Count?rows[operatorRow].label:"";}}
    public string ValueOf(string label){foreach(var r in Rows())if(r.label==label)return r.value!=null?r.value():"";return null;}
    public string InputState(string button)=>Held(button)?"ON":"--";
    public bool ConfirmPending=>confirmRow>=0;
    public string MusicPlaying=>music && music.isPlaying && music.clip?music.clip.name:"";

    // Common coin-op coinage choices: coins -> credits.
    static readonly Vector2Int[] Coinage={new Vector2Int(1,1),new Vector2Int(1,2),new Vector2Int(1,3),new Vector2Int(1,4),new Vector2Int(1,5),new Vector2Int(1,6),
        new Vector2Int(2,1),new Vector2Int(2,3),new Vector2Int(3,1),new Vector2Int(3,2),new Vector2Int(4,1),new Vector2Int(5,1),new Vector2Int(6,1)};
    static readonly string[] SoundTests={"TITLE MUSIC","NAME ENTRY MUSIC","COIN","START","EXTEND","EXPLOSION","POWER UP"};
    static readonly string[] SoundClips={null,null,"se_cursor_001","se_ok_001","item_1up_01","exp_fighter","shot_powerup"};
    static readonly string[] Patterns={"COLOR BARS","CROSSHATCH","WHITE","RED","GREEN","BLUE","BLACK"};
    // Logical cabinet buttons and their keys (keyboard, XInput pad as Unity's joystick buttons).
    static readonly Dictionary<string,KeyCode[]> Buttons=new Dictionary<string,KeyCode[]>{
        ["COIN A"]=new[]{KeyCode.Alpha5,KeyCode.Keypad5,KeyCode.JoystickButton6},["COIN B"]=new[]{KeyCode.Alpha6,KeyCode.Keypad6},
        ["SERVICE"]=new[]{KeyCode.F9},["TEST"]=new[]{KeyCode.F2},
        ["START"]=new[]{KeyCode.Alpha1,KeyCode.Keypad1,KeyCode.Return,KeyCode.KeypadEnter,KeyCode.JoystickButton7},
        ["FIRE"]=new[]{KeyCode.Space,KeyCode.Z,KeyCode.JoystickButton0},["BOMB / BACK"]=new[]{KeyCode.X,KeyCode.Backspace,KeyCode.JoystickButton1},
        ["UP"]=new[]{KeyCode.UpArrow,KeyCode.W},["DOWN"]=new[]{KeyCode.DownArrow,KeyCode.S},["LEFT"]=new[]{KeyCode.LeftArrow,KeyCode.A},["RIGHT"]=new[]{KeyCode.RightArrow,KeyCode.D}};

    ServicePage servicePage;int confirmRow=-1,pattern,soundTest;float startHeld,patternShown;
    readonly Dictionary<string,float> pressedAt=new Dictionary<string,float>();

    sealed class Row { public string label;public Func<string> value;public Action<int> change;public Action act;public bool confirm; }
    static Row Link(string label,Action act)=>new Row{label=label,act=act};
    static Row Toggle(string label,Func<bool> get,Action<bool> set)=>new Row{label=label,value=()=>get()?"ON":"OFF",change=d=>set(!get())};
    static Row Number(string label,Func<int> get,Action<int> set,int min,int max,int step=1,Func<int,string> show=null)=>
        new Row{label=label,value=()=>show!=null?show(get()):get().ToString(),change=d=>set(Wrap(get()+d*step,min,max))};
    static Row Choice(string label,Func<int> get,Action<int> set,string[] names)=>Number(label,get,set,0,names.Length-1,1,i=>names[i]);
    static Row Coins(string label,Func<Vector2Int> get,Action<Vector2Int> set)=>new Row{label=label,
        value=()=>{var c=get();return c.x+" COIN"+(c.x>1?"S ":" ")+c.y+" CREDIT"+(c.y>1?"S":"");},
        change=d=>{int i=Array.IndexOf(Coinage,get());set(Coinage[Wrap((i<0?0:i)+d,0,Coinage.Length-1)]);}};
    static Row Act(string label,Action act,bool confirm=false)=>new Row{label=label,act=act,confirm=confirm};
    static string Bar(int v)=>new string('|',v).PadRight(11)+v;

    List<Row> Rows()
    {
        var s=settings;var r=new List<Row>();
        switch(servicePage)
        {
            case ServicePage.Menu:
                r.Add(Link("GAME SETTINGS",()=>Open(ServicePage.Game)));r.Add(Link("COIN SETTINGS",()=>Open(ServicePage.Coin)));
                r.Add(Link("SOUND SETTINGS",()=>Open(ServicePage.Sound)));r.Add(Link("DISPLAY SETTINGS",()=>Open(ServicePage.Display)));
                r.Add(Link("INPUT TEST",()=>Open(ServicePage.Input)));r.Add(Link("SCREEN TEST",()=>Open(ServicePage.Screen)));
                r.Add(Link("BOOKKEEPING",()=>Open(ServicePage.Bookkeeping)));
                r.Add(Act("CLEAR RANKINGS",()=>{rankings=ArcadeRankings.Defaults();storage.Save("rankings",rankings);Note("rankings cleared");},true));
                r.Add(Act("FACTORY SETTINGS",()=>{settings=new ArcadeSettings();ApplySettings();storage.Save("settings",settings);Note("factory settings");},true));
                r.Add(Act("EXIT",CloseOperator));
                r.Add(Act("EXIT TO WORKSPACE",()=>{storage.Save("settings",settings);Note("exit to workspace");UnityEngine.SceneManagement.SceneManager.LoadScene("Hub");Destroy(gameObject);}));
                break;
            case ServicePage.Game:
                r.Add(Choice("DIFFICULTY",()=>s.difficulty,v=>s.difficulty=v,ArcadeSettings.DifficultyNames));
                r.Add(Number("SHIPS",()=>s.startLives,v=>s.startLives=v,1,5));
                r.Add(Choice("EXTEND",()=>s.extendPreset,v=>s.extendPreset=v,ArcadeSettings.ExtendNames));
                r.Add(Toggle("CONTINUE",()=>s.continues,v=>s.continues=v));
                r.Add(Number("CONTINUE TIME",()=>s.continueSeconds,v=>s.continueSeconds=v,5,30,5,v=>v+" SEC"));
                r.Add(Toggle("ROUND LOOP",()=>s.roundLoop,v=>s.roundLoop=v));
                r.Add(Number("START STAGE",()=>s.startStage,v=>s.startStage=v,1,ArcadeRules.StageOrder.Length,1,v=>v+"  "+ArcadeRules.StageOrder[v-1]));
                r.Add(Number("DEMO TIME",()=>(int)s.demoSeconds,v=>s.demoSeconds=v,10,120,10,v=>v+" SEC"));
                r.Add(Link("RETURN",Back));break;
            case ServicePage.Coin:
                r.Add(Toggle("FREE PLAY",()=>s.freePlay,v=>s.freePlay=v));
                r.Add(Coins("COIN A",()=>new Vector2Int(s.coinsPerCredit,s.creditsPerCoinA),v=>{s.coinsPerCredit=v.x;s.creditsPerCoinA=v.y;}));
                r.Add(Coins("COIN B",()=>new Vector2Int(s.coinsPerCreditB,s.creditsPerCoinB),v=>{s.coinsPerCreditB=v.x;s.creditsPerCoinB=v.y;}));
                r.Add(Number("MAX CREDITS",()=>s.maxCredits,v=>s.maxCredits=v,1,99));
                r.Add(Act("CLEAR CREDITS",()=>{ledger.credits=ledger.coinRemainder=ledger.coinRemainderB=0;SaveLedger();Note("credits cleared");},true));
                r.Add(Link("RETURN",Back));break;
            case ServicePage.Sound:
                r.Add(Number("MASTER VOLUME",()=>s.masterVolume,v=>s.masterVolume=v,0,10,1,Bar));
                r.Add(Number("MUSIC VOLUME",()=>s.musicVolume,v=>s.musicVolume=v,0,10,1,Bar));
                r.Add(Number("EFFECTS VOLUME",()=>s.effectsVolume,v=>s.effectsVolume=v,0,10,1,Bar));
                r.Add(Toggle("DEMO SOUND",()=>s.attractSound,v=>s.attractSound=v));
                r.Add(Toggle("ATTRACT MUSIC",()=>s.attractMusic,v=>s.attractMusic=v));
                r.Add(new Row{label="SOUND TEST",value=()=>SoundTests[soundTest],change=d=>soundTest=Wrap(soundTest+d,0,SoundTests.Length-1),act=PlaySoundTest});
                r.Add(Link("RETURN",Back));break;
            case ServicePage.Display:
                r.Add(Choice("SCREEN MODE",()=>s.displayMode,v=>s.displayMode=v,ArcadeSettings.DisplayModeNames));
                r.Add(Number("RESOLUTION",()=>s.resolution,v=>s.resolution=v,0,ArcadeSettings.Resolutions.Length,1,v=>s.ResolutionName));
                r.Add(Toggle("VSYNC",()=>s.vSync,v=>s.vSync=v));
                r.Add(Number("FRAME LIMIT",()=>s.frameLimit,v=>s.frameLimit=v,0,ArcadeSettings.FrameLimits.Length-1,1,v=>ArcadeSettings.FrameLimits[v]==0?"NONE":ArcadeSettings.FrameLimits[v]+" FPS"));
                r.Add(Toggle("CREDIT DISPLAY",()=>s.showCredits,v=>s.showCredits=v));
                r.Add(Link("RETURN",Back));break;
            case ServicePage.Bookkeeping:
                r.Add(Act("RESET COUNTERS",()=>{ledger.ResetCounters();SaveLedger();Note("counters reset");},true));
                r.Add(Link("RETURN",Back));break;
        }
        return r;
    }

    void OpenOperator()
    {
        if(session!=null)Note("game ended by service mode");
        StopAllCoroutines();session=null;weapon=null;configurePending=false;Time.timeScale=1;Round1Sound.StopAll();
        if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name!=BootScene)UnityEngine.SceneManagement.SceneManager.LoadScene(BootScene);
        servicePage=ServicePage.Menu;operatorRow=0;confirmRow=-1;ApplyAudio(false);Enter(Mode.Operator);
    }
    void Open(ServicePage next){servicePage=next;operatorRow=0;confirmRow=-1;startHeld=0;patternShown=Time.unscaledTime;}
    void Back()
    {
        if(servicePage==ServicePage.Menu){CloseOperator();return;}
        settings.Clamp();storage.Save("settings",settings);if(servicePage==ServicePage.Sound)music.Stop();
        var from=servicePage.ToString().ToUpperInvariant();servicePage=ServicePage.Menu;confirmRow=-1;
        var rows=Rows();operatorRow=Mathf.Max(0,rows.FindIndex(r=>r.label.StartsWith(from)));
    }
    void CloseOperator(){settings.Clamp();storage.Save("settings",settings);ApplySettings();Note("service mode saved");Enter(Mode.Title);}

    void StepOperator()
    {
        if(servicePage==ServicePage.Input)
        {
            // Every button is under test here, so only TEST (F2) or START held for 2 s leaves.
            startHeld=Held("START")?startHeld+Time.unscaledDeltaTime:0;
            if(operatorDown || startHeld>2){Back();Build();}
            return;
        }
        if(servicePage==ServicePage.Screen)
        {
            if(fireDown || startDown || dirDown.x!=0){pattern=Wrap(pattern+(dirDown.x<0?-1:1),0,Patterns.Length-1);patternShown=Time.unscaledTime;Build();}
            if(backDown || operatorDown){Back();Build();}
            return;
        }
        var rows=Rows();bool changed=false;
        if(dirDown.y!=0){operatorRow=Wrap(operatorRow-dirDown.y,0,rows.Count-1);confirmRow=-1;Round1Sound.Play("se_cursor_001");changed=true;}
        var row=rows[Mathf.Clamp(operatorRow,0,rows.Count-1)];
        if(dirDown.x!=0 && row.change!=null){row.change(dirDown.x);changed=true;Round1Sound.Play("se_cursor_001");}
        if(fireDown || startDown)
        {
            if(row.confirm && confirmRow!=operatorRow){confirmRow=operatorRow;Round1Sound.Play("se_cursor_001");}
            else
            {
                confirmRow=-1;Round1Sound.Play("se_ok_001");
                if(row.act!=null)row.act();else if(row.change!=null)row.change(1);
                if(mode!=Mode.Operator || !this)return;   // EXIT / EXIT TO WORKSPACE
            }
            changed=true;
        }
        else if(backDown || operatorDown){if(servicePage==ServicePage.Menu)Note("service mode closed by "+(operatorDown?"test":"back"));Back();if(mode!=Mode.Operator)return;changed=true;}
        if(!changed)return;
        settings.Clamp();if(servicePage==ServicePage.Sound || servicePage==ServicePage.Display)ApplySettings();
        Build();
    }
    void PlaySoundTest()
    {
        if(soundTest<2){music.Stop();PlayMusic(soundTest==0?(art?art.titleMusic:null):(art?art.nameEntryMusic:null));}
        else Round1Sound.Play(SoundClips[soundTest]);
        Note("sound test "+SoundTests[soundTest]);
    }

    // ---------------- applying settings ----------------
    void ApplySettings(){ApplyAudio(mode==Mode.Demo);ApplyDisplay();}
    // Master volume on the listener (demo play silent without DEMO SOUND), music and effects on the game's sound player.
    void ApplyAudio(bool demo)
    {
        AudioListener.volume=settings.masterVolume/10f*(demo && !settings.attractSound?0:1);
        Round1Sound.BgmVolume=settings.musicVolume/10f;Round1Sound.SeVolume=settings.effectsVolume/10f;
        if(music)music.volume=.8f*settings.musicVolume/10f;
    }
    void ApplyDisplay()
    {
        int fps=ArcadeSettings.FrameLimits[settings.frameLimit];Application.targetFrameRate=fps==0?-1:fps;
        if(Application.isEditor)return;   // the editor's Game view and quality settings stay as they are
        QualitySettings.vSyncCount=settings.vSync?1:0;
        var fullScreen=settings.displayMode==1?FullScreenMode.ExclusiveFullScreen:settings.displayMode==2?FullScreenMode.Windowed:FullScreenMode.FullScreenWindow;
        Vector2Int size=settings.resolution>0?ArcadeSettings.Resolutions[settings.resolution-1]:
            fullScreen==FullScreenMode.Windowed?new Vector2Int(1280,720):new Vector2Int(Display.main.systemWidth,Display.main.systemHeight);
        if(Screen.width!=size.x || Screen.height!=size.y || Screen.fullScreenMode!=fullScreen)Screen.SetResolution(size.x,size.y,fullScreen);
    }

    // ---------------- input ----------------
    bool Pressed(string button)
    {
        foreach(var k in Buttons[button])if(Input.GetKeyDown(k)){pressedAt[button]=Time.unscaledTime;return true;}
        return false;
    }
    // Held now, or pressed in the last 0.3 s (so a tap or an injected press shows in the input test).
    bool Held(string button)
    {
        foreach(var k in Buttons[button])if(Input.GetKey(k))return true;
        if(button=="UP" && heldDir.y>0 || button=="DOWN" && heldDir.y<0 || button=="LEFT" && heldDir.x<0 || button=="RIGHT" && heldDir.x>0)return true;   // pad stick
        return pressedAt.TryGetValue(button,out float at) && Time.unscaledTime-at<.3f;
    }
    void Mark(string button){pressedAt[button]=Time.unscaledTime;}
    static int Wrap(int v,int min,int max)=>v<min?max:v>max?min:v;

    // ---------------- screens ----------------
    void BuildService()
    {
        Shade(page,1);
        if(servicePage==ServicePage.Screen){DrawPattern();return;}
        string title=servicePage==ServicePage.Menu?"SERVICE MODE":servicePage.ToString().ToUpperInvariant()+(servicePage==ServicePage.Input || servicePage==ServicePage.Bookkeeping?"":" SETTINGS");
        if(servicePage==ServicePage.Input)title="INPUT TEST";
        Text("head",title,new Vector2(.5f,1),new Vector2(0,-70),1.1f,Gold);
        float y=-170;
        if(servicePage==ServicePage.Input)
        {
            foreach(var b in Buttons.Keys){Text("in "+b,"",new Vector2(.5f,1),new Vector2(0,y),.8f,Color.white);y-=56;}
            var pads=Input.GetJoystickNames();string names=string.Join(", ",Array.FindAll(pads,p=>!string.IsNullOrEmpty(p)));
            Text("pads","PADS: "+(names.Length>0?names.ToUpperInvariant():"NONE"),new Vector2(.5f,1),new Vector2(0,y-20),.6f,Cyan);
            Text("help","F2  OR  HOLD START 2 SEC  TO RETURN",new Vector2(.5f,0),new Vector2(0,50),.6f,Dim);
            return;
        }
        if(servicePage==ServicePage.Bookkeeping)
        {
            int games=Mathf.Max(1,ledger.gamesStarted);double avg=ledger.playSeconds/games;
            string[] lines={"COIN A",ledger.CoinsA.ToString(),"COIN B",ledger.coinsB.ToString(),"SERVICE CREDITS",ledger.serviceCredits.ToString(),
                "CREDITS IN MACHINE",ledger.credits.ToString(),"GAMES",ledger.gamesStarted.ToString(),"CONTINUES",ledger.continuesUsed.ToString(),
                "EXTENDS",ledger.extendsGiven.ToString(),"ALL CLEARS",ledger.allClears.ToString(),"PLAY TIME",Clock(ledger.playSeconds),"AVERAGE GAME",Clock(avg)};
            for(int i=0;i<lines.Length;i+=2){Text("bk"+i,"  "+lines[i].PadRight(20)+lines[i+1].PadLeft(12),new Vector2(.5f,1),new Vector2(0,y),.75f,Cyan);y-=50;}
            y-=30;
        }
        var rows=Rows();
        for(int i=0;i<rows.Count;i++)
        {
            var r=rows[i];string value=i==confirmRow?"PRESS AGAIN":r.value!=null?r.value():"";
            Text("row"+i,(i==operatorRow?"> ":"  ")+r.label.PadRight(20)+value.PadRight(22),new Vector2(.5f,1),new Vector2(0,y),.8f,i==operatorRow?Gold:Color.white);y-=56;
        }
        Text("help","UP DOWN SELECT   LEFT RIGHT CHANGE   FIRE SET   BACK / F2 RETURN",new Vector2(.5f,0),new Vector2(0,50),.6f,Dim);
    }
    void RefreshService()
    {
        if(servicePage==ServicePage.Input)
            foreach(var b in Buttons.Keys)if(live.TryGetValue("in "+b,out var g)){bool on=Held(b);g.tint=on?Gold:Color.white;g.Set("  "+b.PadRight(16)+(on?"ON":"--").PadRight(6)+KeyNames(b).PadRight(18));}
        if(servicePage==ServicePage.Screen && live.TryGetValue("pattern",out var name))name.Set(Time.unscaledTime-patternShown<1.5f?Patterns[pattern]:"");
    }
    static string KeyNames(string button)
    {
        var names=new List<string>();
        foreach(var k in Buttons[button]){string n=k.ToString().Replace("Alpha","").Replace("Keypad","NUM").Replace("JoystickButton","PAD").Replace("Arrow","").ToUpperInvariant();if(n.Length<=6)names.Add(n);}
        return string.Join(" ",names.GetRange(0,Mathf.Min(3,names.Count)));
    }
    static string Clock(double seconds){var t=TimeSpan.FromSeconds(seconds);return ((int)t.TotalHours)+":"+t.Minutes.ToString("00")+":"+t.Seconds.ToString("00");}
    void DrawPattern()
    {
        Color[] solid={Color.white,Color.red,Color.green,Color.blue,Color.black};
        if(pattern==0)
        {
            Color[] bars={Color.white,Color.yellow,Color.cyan,Color.green,Color.magenta,Color.red,Color.blue,Color.black};
            for(int i=0;i<bars.Length;i++)Fill(new Vector2(i/8f,.25f),new Vector2((i+1)/8f,1),bars[i]);
            for(int i=0;i<16;i++){float v=i/15f;Fill(new Vector2(i/16f,0),new Vector2((i+1)/16f,.25f),new Color(v,v,v));}
        }
        else if(pattern==1)
        {
            Fill(Vector2.zero,Vector2.one,Color.black);
            for(int i=0;i<=16;i++){float x=i/16f;Fill(new Vector2(x-.0012f,0),new Vector2(x+.0012f,1),Color.white);}
            for(int i=0;i<=9;i++){float y=i/9f;Fill(new Vector2(0,y-.002f),new Vector2(1,y+.002f),Color.white);}
            var dot=Rect("Centre",page,new Vector2(.5f,.5f),new Vector2(.5f,.5f),Vector2.zero);dot.sizeDelta=new Vector2(14,14);dot.gameObject.AddComponent<Image>().color=Color.red;
        }
        else Fill(Vector2.zero,Vector2.one,solid[pattern-2]);
        Text("pattern","",new Vector2(.5f,1),new Vector2(0,-60),.9f,pattern==2?Color.black:Gold);
    }
    void Fill(Vector2 min,Vector2 max,Color c){var img=Rect("Fill",page,min,max,Vector2.zero).gameObject.AddComponent<Image>();img.color=c;img.raycastTarget=false;}
}
