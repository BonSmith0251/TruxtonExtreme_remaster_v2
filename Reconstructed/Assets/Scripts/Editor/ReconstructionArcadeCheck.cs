using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

// Verification only: plays the arcade cabinet (ArcadeBoot) in a graphics editor through its logical buttons:
// no start without credit -> coin -> start -> stage 1 (BG03, Arcade schedule mode) -> boss cleared by the autopilot ->
// ship departs -> stage 2 (BG05) with the ship carried -> game over -> continue refused without credit -> coin + start
// continues in place -> game over -> countdown runs out -> initials "CAT" -> best-10 table -> title -> attract demo ->
// service mode: coin, game, sound, display pages, input test, screen test, bookkeeping -> coin chutes with the new
// coinage -> EASY game from stage 2 -> test switch ends it -> factory settings (asked twice). Writes verification/arcade/arcade-check.json and screenshots.
// Run: tools/common/unity_gui_run.sh LOG ReconstructionArcadeCheck.Run TRUXTON_ARCADE_DATA=D:/Games/TruxtonExRecon/verification/arcade/data
[InitializeOnLoad]
public static class ReconstructionArcadeCheck
{
    const string Prefix="ArcadeCheck.";
    const string Output="D:/Games/TruxtonExRecon/verification/arcade";
    [Serializable] class Result { public string name,detail;public bool pass; }
    [Serializable] class Report { public List<Result> checks=new List<Result>();public int errors;public string events;public bool finished;public string failedWait=""; }
    static Report report;static readonly Stack<IEnumerator> script=new Stack<IEnumerator>();static double waitUntil;

    static ReconstructionArcadeCheck()
    {
        EditorApplication.update+=Update;EditorApplication.playModeStateChanged+=Changed;
        Application.logMessageReceived+=(m,st,k)=>{
            if(!SessionState.GetBool(Prefix+"running",false)||k==LogType.Log||k==LogType.Warning)return;
            if(report!=null)report.errors++;File.AppendAllText(Output+"/errors.txt",k+": "+m+"\n"+st+"\n");
        };
    }
    public static void Run()
    {
        Directory.CreateDirectory(Output);File.WriteAllText(Output+"/errors.txt","");
        string data=ArcadeStorage.DefaultRoot();if(data.Replace('\\','/').StartsWith(Output) && Directory.Exists(data))Directory.Delete(data,true);
        SessionState.SetBool(Prefix+"running",true);SessionState.SetFloat(Prefix+"deadline",(float)EditorApplication.timeSinceStartup+2400);
        EditorSceneManager.OpenScene("Assets/Scenes/ArcadeBoot.unity",OpenSceneMode.Single);
        SessionState.SetFloat(Prefix+"at",(float)EditorApplication.timeSinceStartup+2);
    }
    static void Changed(PlayModeStateChange s)
    {
        if(!SessionState.GetBool(Prefix+"running",false))return;
        if(s==PlayModeStateChange.EnteredPlayMode){report=new Report();script.Clear();script.Push(Script());started=true;}
        if(s==PlayModeStateChange.EnteredEditMode){SessionState.SetBool(Prefix+"running",false);ReconstructionExit.Quit(SessionState.GetInt(Prefix+"code",1));}
    }
    static void Update()
    {
        if(!SessionState.GetBool(Prefix+"running",false))return;
        double now=EditorApplication.timeSinceStartup;
        if(now>SessionState.GetFloat(Prefix+"deadline",float.MaxValue)){Finish("deadline");return;}
        if(EditorApplication.isCompiling||EditorApplication.isUpdating)return;
        if(!EditorApplication.isPlaying)
        {
            if(!started && now>SessionState.GetFloat(Prefix+"at",0) && !EditorApplication.isPlayingOrWillChangePlaymode)
            {var gv=typeof(Editor).Assembly.GetType("UnityEditor.GameView");if(gv!=null)EditorWindow.GetWindow(gv).Show();EditorApplication.isPlaying=true;}
            return;
        }
        if(script.Count==0 || now<waitUntil)return;
        // A small coroutine runner: a yielded IEnumerator runs to its end before its caller goes on.
        try
        {
            var top=script.Peek();
            if(!top.MoveNext()){script.Pop();if(script.Count==0)Finish(null);}
            else if(top.Current is IEnumerator inner)script.Push(inner);
        }
        catch(Exception e){Debug.LogException(e);Finish("exception "+e.Message);}
    }

    static bool started;
    static ArcadeMachine M=>ArcadeMachine.Instance;
    static string Scene=>SceneManager.GetActiveScene().name;
    static void Check(string name,bool pass,string detail=""){report.checks.Add(new Result{name=name,pass=pass,detail=detail});Debug.Log("[ArcadeCheck] "+(pass?"PASS ":"FAIL ")+name+" "+detail);}
    // The capture is taken at the end of a later game frame, so wait for it before the next press changes the screen.
    static IEnumerator Shot(string name)
    {
        ScreenCapture.CaptureScreenshot(Output+"/"+name+".png");
        int frame=Time.frameCount;double end=EditorApplication.timeSinceStartup+2;
        while((Time.frameCount<frame+3 || EditorApplication.timeSinceStartup<end-1.7) && EditorApplication.timeSinceStartup<end)yield return null;
    }
    static object Seconds(double s){waitUntil=EditorApplication.timeSinceStartup+s;return null;}
    // Yields until the condition holds; records a failed wait (and stops the script) after the timeout.
    static IEnumerator Until(Func<bool> condition,double timeout,string label)
    {
        double end=EditorApplication.timeSinceStartup+timeout;
        while(!condition())
        {
            if(EditorApplication.timeSinceStartup>end){report.failedWait=label;Check("wait "+label,false,"timeout "+timeout+"s state="+(M?M.State.ToString():"none")+" scene="+Scene);throw new TimeoutException(label);}
            yield return null;
        }
    }
    // One press per game frame: the editor update that drives this script can tick faster than the game (the cabinet's
    // frame limit), so wait until the cabinet has read the press and a further game frame has run.
    static IEnumerator Press(string button,int times=1)
    {
        for(int i=0;i<times;i++)
        {
            M.Inject(button);double end=EditorApplication.timeSinceStartup+3;
            while(M && M.PendingInputs>0 && EditorApplication.timeSinceStartup<end)yield return null;
            int frame=Time.frameCount;while(Time.frameCount<frame+2 && EditorApplication.timeSinceStartup<end)yield return null;
        }
    }
    // Service mode navigation through the same buttons: down until the row is selected, fire to open a page.
    static IEnumerator Select(string label)
    {
        for(int i=0;i<20 && M.SelectedLabel!=label;i++)yield return Press("down");
        if(M.SelectedLabel!=label)Check("select "+label,false,"at "+M.SelectedLabel);
    }
    static IEnumerator Enter(string label,ArcadeMachine.ServicePage page)
    {
        yield return Select(label);yield return Press("fire");
        Check("open "+label,M.Page==page,M.Page.ToString());
    }

    static IEnumerator Script()
    {
        yield return Until(()=>M && M.State==ArcadeMachine.Mode.Title,30,"title");yield return Seconds(2);yield return Shot("01-title");
        yield return Press("start");yield return Seconds(.3);
        Check("no start without credit",M.State==ArcadeMachine.Mode.Title && M.session==null,"credits="+M.ledger.credits);
        yield return Press("coin");yield return Seconds(.2);
        Check("coin gives a credit",M.ledger.credits==1 && M.ledger.totalCoins==1,"credits="+M.ledger.credits);
        yield return Press("start");
        yield return Until(()=>M.State==ArcadeMachine.Mode.Playing,90,"stage 1");
        var w=M.Weapon;var combat=w.combat;var waves=combat?combat.GetComponent<Round1EnemyWaves>():null;
        yield return Seconds(1);
        Check("stage 1 is BG03",Scene=="StagePlay_BG03",Scene);
        Check("arcade schedule mode",waves && waves.gameModeMask==ArcadeRules.Arcade1Mask,waves?waves.gameModeMask.ToString():"no waves");
        Check("arcade bullet selectors",combat && combat.sourceAttacks && combat.sourceAttacks.selectorMode==ArcadeRules.ArcadeSelectorMode,combat&&combat.sourceAttacks?combat.sourceAttacks.selectorMode.ToString():"none");
        Check("credit spent, 3 ships, manual",M.ledger.credits==0 && M.ledger.gamesStarted==1 && w.Lives==3 && w.autopilot && !w.autopilot.automatic,$"credits={M.ledger.credits} games={M.ledger.gamesStarted} lives={w.Lives}");
        yield return Shot("02-stage1");
        // Clear stage 1 quickly: autopilot, no hits, 3x speed, straight to the boss.
        w.autopilot.SetAutomatic(true);w.verificationShield=true;if(w.intro)w.intro.Skip();
        yield return Until(()=>w.CanAct,40,"ship can act");
        Time.timeScale=3;combat.boss.JumpToEncounter();
        yield return Until(()=>w && w.RoundCleared,420,"stage 1 boss defeated");
        long clearedScore=w.Score;int clearedLevel=w.Level;
        yield return Seconds(2.5);yield return Shot("03-stage-clear");
        yield return Until(()=>Scene=="StagePlay_BG05" && M.State==ArcadeMachine.Mode.Playing,90,"stage 2 after departure");
        w=M.Weapon;yield return Seconds(1);
        Check("stage 2 is BG05 with the ship carried",w.Score==clearedScore && w.Level==clearedLevel && M.session.clearCount==1,$"score {w.Score}/{clearedScore} level {w.Level}/{clearedLevel}");
        Check("no takeoff movie on stage 2",!(w.intro && w.intro.Active));
        yield return Shot("04-stage2");
        // Game over -> continue.
        yield return Seconds(3);
        yield return Until(()=>{if(w.CanAct && !w.Invincible)w.TakeDamage(1e6f);return M.State==ArcadeMachine.Mode.Continue;},90,"continue screen");
        var end=UnityEngine.Object.FindFirstObjectByType<Round1StageEnd>();
        Check("no retry banner in arcade",!end || end.State==Round1StageEnd.Phase.None,end?end.State.ToString():"");
        yield return Seconds(1.2);yield return Shot("05-continue");
        yield return Press("start");yield return Seconds(.3);
        Check("continue refused without credit",M.State==ArcadeMachine.Mode.Continue && M.session.continues==0);
        yield return Press("coin");yield return Press("start");
        yield return Until(()=>M.State==ArcadeMachine.Mode.Playing,10,"continued");
        Check("continue in place",!w.GameOver && w.Lives==3 && M.session.continues==1 && M.ledger.credits==0 && Scene=="StagePlay_BG05",$"lives={w.Lives} continues={M.session.continues}");
        yield return Seconds(4);yield return Shot("06-continued");
        w.AddScore(400000);long finalScore=w.Score;   // enough for the default table
        yield return Until(()=>{if(w.CanAct && !w.Invincible)w.TakeDamage(1e6f);return M.State==ArcadeMachine.Mode.Continue;},90,"second continue screen");
        yield return Press("fire",12);
        yield return Until(()=>M.State==ArcadeMachine.Mode.GameOver,15,"game over");
        yield return Seconds(1);yield return Shot("07-game-over");
        yield return Until(()=>M.State==ArcadeMachine.Mode.Initials,10,"initials");
        yield return Seconds(1);yield return Shot("08-initials");
        yield return Press("right",2);yield return Press("fire");yield return Press("fire");yield return Press("right",19);yield return Seconds(.3);yield return Shot("09-initials-typed");
        yield return Press("fire");yield return Seconds(1);
        var top=M.rankings.entries.Find(e=>e.initials=="CAT");
        Check("initials saved in the table",top!=null && top.score==finalScore && M.LastRank>=0 && M.LastRank<ArcadeRankings.Size,top!=null?top.score+" rank "+(M.LastRank+1):"missing");
        yield return Shot("10-table");
        yield return Until(()=>M.State==ArcadeMachine.Mode.Title && Scene==ArcadeMachine.BootScene,15,"back to title");
        yield return Until(()=>M.State==ArcadeMachine.Mode.Rankings,20,"attract rankings");yield return Seconds(1);yield return Shot("11-rankings");
        yield return Until(()=>M.State==ArcadeMachine.Mode.Demo,40,"attract demo");
        yield return Seconds(6);
        Check("demo flies itself",Scene.StartsWith("StagePlay_") && M.Weapon && M.Weapon.autopilot && M.Weapon.autopilot.automatic && M.Weapon.verificationShield && M.session==null,
            $"{Scene} weapon={(bool)M.Weapon} auto={(M.Weapon&&M.Weapon.autopilot?M.Weapon.autopilot.automatic:false)} shield={(M.Weapon?M.Weapon.verificationShield:false)} session={(M.session!=null)} state={M.State}");
        yield return Shot("12-demo");
        // Service mode (F2): every page, settings applied and saved.
        yield return Press("operator");
        yield return Until(()=>M.State==ArcadeMachine.Mode.Operator && Scene==ArcadeMachine.BootScene,15,"service mode");
        Check("test switch opens the service menu",M.Page==ArcadeMachine.ServicePage.Menu && M.session==null);
        yield return Seconds(.5);yield return Shot("13-service-menu");
        yield return Enter("COIN SETTINGS",ArcadeMachine.ServicePage.Coin);
        yield return Select("COIN A");yield return Press("right");
        yield return Select("COIN B");yield return Press("right",6);
        Check("coinage set",M.ValueOf("COIN A")=="1 COIN 2 CREDITS" && M.ValueOf("COIN B")=="2 COINS 1 CREDIT",M.ValueOf("COIN A")+" / "+M.ValueOf("COIN B"));
        yield return Seconds(.3);yield return Shot("14-coin-settings");yield return Press("back");
        yield return Enter("GAME SETTINGS",ArcadeMachine.ServicePage.Game);
        yield return Select("DIFFICULTY");yield return Press("left");
        yield return Select("START STAGE");yield return Press("right");
        Check("game settings set",M.settings.difficulty==0 && M.settings.startStage==2,M.ValueOf("DIFFICULTY")+" / "+M.ValueOf("START STAGE"));
        yield return Seconds(.3);yield return Shot("15-game-settings");yield return Press("back");
        yield return Enter("SOUND SETTINGS",ArcadeMachine.ServicePage.Sound);
        yield return Select("MASTER VOLUME");yield return Press("left",5);
        Check("master volume applied",M.settings.masterVolume==5 && Mathf.Abs(AudioListener.volume-.5f)<.01f,"listener "+AudioListener.volume);
        yield return Select("SOUND TEST");yield return Press("fire");yield return Seconds(.5);
        Check("sound test plays the title music",M.MusicPlaying.Length>0,M.MusicPlaying);
        yield return Shot("16-sound-settings");yield return Press("back");
        yield return Enter("DISPLAY SETTINGS",ArcadeMachine.ServicePage.Display);
        yield return Select("FRAME LIMIT");yield return Press("right");
        Check("frame limit applied",Application.targetFrameRate==120,"target "+Application.targetFrameRate);
        yield return Seconds(.3);yield return Shot("17-display-settings");yield return Press("back");
        yield return Enter("INPUT TEST",ArcadeMachine.ServicePage.Input);
        int creditsBefore=M.ledger.credits;
        yield return Press("fire");
        Check("input test shows a press",M.InputState("FIRE")=="ON");
        yield return Shot("18-input-test");
        yield return Press("coin");
        Check("input test does not count coins",M.ledger.credits==creditsBefore && M.Page==ArcadeMachine.ServicePage.Input);
        yield return Press("operator");
        Check("test switch leaves the input test",M.Page==ArcadeMachine.ServicePage.Menu);
        yield return Enter("SCREEN TEST",ArcadeMachine.ServicePage.Screen);yield return Seconds(.3);yield return Shot("19-screen-bars");
        yield return Press("fire");yield return Seconds(2);yield return Shot("20-screen-crosshatch");yield return Press("back");
        yield return Enter("BOOKKEEPING",ArcadeMachine.ServicePage.Bookkeeping);yield return Seconds(.3);yield return Shot("21-bookkeeping");yield return Press("back");
        yield return Press("operator");yield return Seconds(.5);
        Check("service mode saved and closed",M.State==ArcadeMachine.Mode.Title && File.ReadAllText(Path.Combine(ArcadeStorage.DefaultRoot(),"settings.json")).Contains("\"difficulty\": 0"));
        // Coin chutes with the new coinage: A gives 2 credits per coin, B 1 credit per 2 coins.
        yield return Press("coin");yield return Press("coinB");
        Check("coin B needs two coins",M.ledger.credits==2,"credits "+M.ledger.credits);
        yield return Press("coinB");
        Check("coin chutes credit",M.ledger.credits==3,"credits "+M.ledger.credits);
        yield return Shot("22-title-credits");
        yield return Press("start");
        yield return Until(()=>M.State==ArcadeMachine.Mode.Playing,90,"easy game from stage 2");
        var easyWaves=UnityEngine.Object.FindFirstObjectByType<Round1EnemyWaves>();
        Check("start stage 2 at EASY (Story rules)",Scene=="StagePlay_BG05" && easyWaves && easyWaves.gameModeMask==2 && M.Weapon.combat.sourceAttacks.selectorMode==1 && M.ledger.credits==2,Scene+" mask "+(easyWaves?easyWaves.gameModeMask:-1));
        yield return Seconds(2);yield return Shot("23-easy-stage2");
        // The test switch during a game ends it; factory settings need a second press.
        yield return Press("operator");
        yield return Until(()=>M.State==ArcadeMachine.Mode.Operator && Scene==ArcadeMachine.BootScene,15,"service mode from a game");
        Check("test switch ends the game",M.session==null);
        yield return Select("FACTORY SETTINGS");yield return Press("fire");
        Check("factory settings ask first",M.settings.difficulty==0 && M.ConfirmPending);
        yield return Press("fire");
        Check("factory settings restored",M.settings.difficulty==1 && M.settings.startStage==1 && M.settings.coinsPerCreditB==1 && M.settings.masterVolume==10 && Mathf.Abs(AudioListener.volume-1)<.01f);
        yield return Press("operator");
        var ledger=JsonUtility.FromJson<ArcadeLedger>(File.ReadAllText(Path.Combine(ArcadeStorage.DefaultRoot(),"ledger.json")));
        Check("ledger on disk",ledger.totalCoins==5 && ledger.coinsB==2 && ledger.gamesStarted==2 && ledger.continuesUsed==1 && ledger.credits==2,JsonUtility.ToJson(ledger));
        report.finished=true;
    }
    static void Finish(string why)
    {
        if(report==null)report=new Report();
        if(why!=null)report.failedWait=report.failedWait.Length>0?report.failedWait:why;
        report.events=M?string.Join("\n",M.Events):"";
        bool ok=report.finished && report.errors==0 && report.checks.TrueForAll(c=>c.pass);
        File.WriteAllText(Output+"/arcade-check.json",JsonUtility.ToJson(report,true));
        Debug.Log("[ArcadeCheck] "+(ok?"ALL PASS":"FAILED")+" checks="+report.checks.Count+" errors="+report.errors);
        SessionState.SetInt(Prefix+"code",ok?0:1);script.Clear();Time.timeScale=1;
        if(EditorApplication.isPlaying)EditorApplication.isPlaying=false;
        else{SessionState.SetBool(Prefix+"running",false);ReconstructionExit.Quit(ok?0:1);}
    }
}
