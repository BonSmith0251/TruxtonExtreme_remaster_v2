using System;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Verification only: plays StagePlay_BGxx scenes in a graphics editor with the Round 1 autopilot flying, at 3x game
// speed, and records stage time, kills, live enemies, enemy bullets, lives, score and errors, with Game view captures.
// Run: Unity.exe -projectPath ... -executeMethod ReconstructionStagePlayCheck.Run   (STAGE_PLAY_ONLY=BG01 for one stage)
// STAGE_PLAY_END=win|lose: play on past the end (lose: the ship is destroyed whenever it can be) through Round1StageEnd:
// capture the banner, press, capture the departure and the empty screen (win), press again, and log end.jsonl once the
// stage has restarted.
[InitializeOnLoad]
public static class ReconstructionStagePlayCheck
{
    const string Prefix="StagePlayCheck.";
    const string Output="D:/Games/TruxtonExRecon/verification/stage-play";
    static float RealSeconds=>float.TryParse(Environment.GetEnvironmentVariable("STAGE_PLAY_SECONDS"),out float s)&&s>0?s:45;
    static float Speed=>float.TryParse(Environment.GetEnvironmentVariable("STAGE_PLAY_SPEED"),out float s)&&s>0?s:1;

    static ReconstructionStagePlayCheck()
    {
        EditorApplication.update+=Update;
        EditorApplication.playModeStateChanged+=Changed;
        Application.logMessageReceived+=(m,st,k)=>{
            if(!SessionState.GetBool(Prefix+"running",false)||k==LogType.Log||k==LogType.Warning)return;
            SessionState.SetInt(Prefix+"errors",SessionState.GetInt(Prefix+"errors",0)+1);
            File.AppendAllText(Output+"/play-errors.txt",Stage()+" "+k+": "+m+"\n"+st+"\n");
        };
    }
    static string[] Stages(){string only=Environment.GetEnvironmentVariable("STAGE_PLAY_ONLY");return Enumerable.Range(1,8).Select(i=>"BG"+i.ToString("00")).Where(k=>string.IsNullOrEmpty(only)?File.Exists("Assets/Scenes/StagePlay/StagePlay_"+k+".unity"):k==only).ToArray();}
    static string Stage(){var s=SessionState.GetString(Prefix+"stages","").Split(',');int i=SessionState.GetInt(Prefix+"index",0);return i<s.Length?s[i]:"";}

    public static void Run()
    {
        Directory.CreateDirectory(Output);File.WriteAllText(Output+"/play-errors.txt","");File.WriteAllText(Output+"/play.jsonl","");
        SessionState.SetString(Prefix+"stages",string.Join(",",Stages()));SessionState.SetInt(Prefix+"index",0);
        SessionState.SetBool(Prefix+"running",true);SessionState.SetFloat(Prefix+"deadline",(float)EditorApplication.timeSinceStartup+1800);
        Open();
    }
    static void Open()
    {
        SessionState.SetInt(Prefix+"errors",0);
        EditorSceneManager.OpenScene("Assets/Scenes/StagePlay/StagePlay_"+Stage()+".unity",OpenSceneMode.Single);
        SessionState.SetString(Prefix+"phase","wait-start");SessionState.SetFloat(Prefix+"at",(float)EditorApplication.timeSinceStartup+2);
    }
    static void Changed(PlayModeStateChange s)
    {
        if(!SessionState.GetBool(Prefix+"running",false))return;
        if(s==PlayModeStateChange.EnteredPlayMode){SessionState.SetString(Prefix+"phase","setup");SessionState.SetFloat(Prefix+"at",(float)EditorApplication.timeSinceStartup+1);}
        if(s==PlayModeStateChange.EnteredEditMode)
        {
            int i=SessionState.GetInt(Prefix+"index",0)+1;
            if(i<SessionState.GetString(Prefix+"stages","").Split(',').Length){SessionState.SetInt(Prefix+"index",i);Open();}
            else{SessionState.SetBool(Prefix+"running",false);ReconstructionExit.Quit(0);}
        }
    }
    static void Update()
    {
        if(!SessionState.GetBool(Prefix+"running",false))return;
        float now=(float)EditorApplication.timeSinceStartup;
        if(now>SessionState.GetFloat(Prefix+"deadline",float.MaxValue)){SessionState.SetBool(Prefix+"running",false);ReconstructionExit.Quit(1);return;}
        if(EditorApplication.isCompiling||EditorApplication.isUpdating||now<SessionState.GetFloat(Prefix+"at",0))return;
        string phase=SessionState.GetString(Prefix+"phase","");
        if(phase=="wait-start")
        {
            SessionState.SetString(Prefix+"phase","entering");
            var gv=typeof(Editor).Assembly.GetType("UnityEditor.GameView");if(gv!=null)EditorWindow.GetWindow(gv).Show();
            EditorApplication.isPlaying=true;return;
        }
        if(!EditorApplication.isPlaying)return;
        var weapon=UnityEngine.Object.FindFirstObjectByType<Round1Weapon>();
        var combat=UnityEngine.Object.FindFirstObjectByType<Round1Combat>();
        var waves=combat?combat.GetComponent<Round1EnemyWaves>():null;
        if(phase=="setup")
        {
            var intro=UnityEngine.Object.FindFirstObjectByType<Round1Intro>();if(intro)intro.Skip();
            if(weapon&&weapon.autopilot)weapon.autopilot.SetAutomatic(true);
            // STAGE_PLAY_PEACE=1: the ship holds fire and bombs and takes no hits, so enemies play out their whole programs.
            if(Environment.GetEnvironmentVariable("STAGE_PLAY_PEACE")=="1"&&weapon){weapon.verificationShield=true;if(weapon.autopilot){weapon.autopilot.holdFire=true;weapon.autopilot.useBombs=false;}}
            Time.timeScale=Speed;
            SessionState.SetBool(Prefix+"jumped",Environment.GetEnvironmentVariable("STAGE_PLAY_BOSS")!="1");
            SessionState.SetFloat(Prefix+"start",now);SessionState.SetInt(Prefix+"shot",0);SessionState.SetInt(Prefix+"atShot",0);SessionState.SetInt(Prefix+"maxHostiles",0);SessionState.SetInt(Prefix+"maxEnemies",0);
            SessionState.SetString(Prefix+"phase","run");
            if(CaptureTracks)Round1TrackCapture.Active=new Round1TrackCapture();   // STAGE_PLAY_CAPTURE=1: every enemy's path -> <stage>-capture.json
            return;
        }
        if(phase=="end"){StepEnd(now,weapon);return;}
        if(phase=="run")
        {
            float elapsed=now-SessionState.GetFloat(Prefix+"start",now);
            if(combat){SessionState.SetInt(Prefix+"maxHostiles",Mathf.Max(SessionState.GetInt(Prefix+"maxHostiles",0),combat.HostileCount));SessionState.SetInt(Prefix+"maxEnemies",Mathf.Max(SessionState.GetInt(Prefix+"maxEnemies",0),combat.ActiveEnemies));}
            if(weapon&&weapon.autopilot&&!weapon.autopilot.automatic)weapon.autopilot.SetAutomatic(true);
            // STAGE_PLAY_RESIDENT_TEST=1: every 2 s, park three shootable enemybullet011s bullets ahead of the ship (death-bullet check).
            if(Environment.GetEnvironmentVariable("STAGE_PLAY_RESIDENT_TEST")=="1"&&combat&&combat.sourceAttacks&&weapon&&weapon.CanAct&&Mathf.Repeat(elapsed,2f)<Time.unscaledDeltaTime*1.5f)
            {var prefab=combat.sourceAttacks.BulletPrefab("enemybullet011s");var at=weapon.player.viewportPosition;for(int i=-1;i<=1;i++)combat.SpawnSourceHostile(new Vector2(at.x+i*.03f,at.y+.35f),Vector2.zero,prefab,-1);}
            if(EndMode=="lose"&&weapon&&weapon.CanAct&&!weapon.Invincible)weapon.TakeDamage(1e6f);
            if(EndMode!=null&&weapon&&(weapon.GameOver||weapon.RoundCleared)){SessionState.SetString(Prefix+"phase","end");SessionState.SetFloat(Prefix+"endStart",now);SessionState.SetInt(Prefix+"endStep",0);return;}
            // STAGE_PLAY_BOSS=1: seek to the boss warning as soon as the player can act (F3 in play).
            if(!SessionState.GetBool(Prefix+"jumped",true)&&weapon&&weapon.CanAct&&combat&&combat.boss){combat.boss.JumpToEncounter();SessionState.SetBool(Prefix+"jumped",true);}
            // STAGE_PLAY_SHOTS=t1,t2,...: also capture the Game view when the stage clock passes each time (<stage>-at<t>.png).
            if(weapon && Environment.GetEnvironmentVariable("STAGE_PLAY_SHOTS") is string shotTimes && shotTimes.Length>0)
            {
                var times=shotTimes.Split(',').Select(x=>float.TryParse(x,System.Globalization.NumberStyles.Float,System.Globalization.CultureInfo.InvariantCulture,out float v)?v:-1).Where(v=>v>=0).ToArray();
                int next=SessionState.GetInt(Prefix+"atShot",0);
                if(next<times.Length && weapon.player.playback.elapsed>=times[next]){ScreenCapture.CaptureScreenshot(Output+"/"+Stage()+"-at"+times[next]+".png");SessionState.SetInt(Prefix+"atShot",next+1);}
            }
            int shot=SessionState.GetInt(Prefix+"shot",0);
            if(shot<4&&elapsed>=RealSeconds*(shot+1)/5){ScreenCapture.CaptureScreenshot(Output+"/"+Stage()+"-"+shot+".png");DumpRenderers(weapon,shot);SessionState.SetInt(Prefix+"shot",shot+1);}
            bool done=elapsed>=RealSeconds||EndMode==null&&weapon&&(weapon.GameOver||weapon.RoundCleared);
            if(!done)return;
            File.AppendAllText(Output+"/play.jsonl",JsonUtility.ToJson(new Row{stage=Stage(),realSeconds=elapsed,stageTime=weapon?weapon.player.playback.elapsed:-1,
                spawned=waves?waves.TotalSpawned:-1,capacityMisses=waves?waves.CapacityMisses:-1,conditionalSkipped=waves?waves.ConditionalSkipped:-1,triggeredEvents=waves?waves.TriggeredEvents:-1,spawnedModels=waves?string.Join(" ",waves.SpawnedByModel.OrderByDescending(p=>p.Value).Select(p=>p.Key.Replace("Pf_Ene_","").Replace("Pf_EneObj_","")+"="+p.Value)):"",kills=combat?combat.Kills:-1,hits=combat?combat.effects.Hits:-1,blasts=combat?combat.effects.Blasts:-1,flashes=combat?combat.effects.Flashes:-1,bossFlashes=combat?combat.effects.BossFlashes:-1,maxEnemies=SessionState.GetInt(Prefix+"maxEnemies",0),maxHostiles=SessionState.GetInt(Prefix+"maxHostiles",0),
                lives=weapon?weapon.Lives:-1,score=weapon?weapon.Score:-1,bodyContacts=combat?combat.BodyContacts:-1,projectiles=combat&&combat.sourceAttacks?combat.sourceAttacks.FiredProjectiles:-1,lasers=combat&&combat.sourceAttacks?combat.sourceAttacks.FiredLasers:-1,speed=Speed,contacts=combat?string.Join(" ",combat.BodyContactLog):"",groundSpawned=combat&&combat.groundEnemies?combat.groundEnemies.Spawned:-1,groundRuins=combat&&combat.groundEnemies?combat.groundEnemies.RuinsLeft:-1,groundEntered=combat&&combat.groundEnemies?combat.groundEnemies.Entered:-1,camera=weapon?weapon.player.stageCamera.transform.position.ToString("0"):"",carriers=combat&&combat.pickupDrones?combat.pickupDrones.Spawned:-1,musicLog=Round1Sound.Instance?string.Join("; ",Round1Sound.Instance.MusicLog):"",unseenLog=waves?string.Join("; ",waves.UnseenLog):"",unseen=waves?string.Join(" ",waves.UnseenByModel.OrderByDescending(p=>p.Value).Select(p=>p.Key.Replace("Pf_Ene_","").Replace("Pf_EneObj_","")+"="+p.Value+"/"+(waves.SpawnedByModel.TryGetValue(p.Key,out int sp)?sp:0))):"",deathVolleys=combat&&combat.sourceAttacks?combat.sourceAttacks.DeathVolleys:-1,shotBullets=combat?combat.ShotBullets:-1,itemDrops=weapon?weapon.EnemyDropsSpawned:-1,groundDrops=weapon?weapon.GroundDropsSpawned:-1,level=weapon?weapon.Level:-1,bossPos=combat?string.Join(" ",combat.Targets.Where(t=>t.active&&t.isBoss).Select(t=>t.position.ToString("0.00"))):"",playerPos=weapon?weapon.player.viewportPosition.ToString("0.00"):"",bossState=combat&&combat.boss?combat.boss.State.ToString():"",bossHealth=combat&&combat.boss?combat.boss.HealthRatio:-1,bossVolleys=combat&&combat.boss is StageBoss sb?sb.AttackVolleys:-1,gameOver=weapon&&weapon.GameOver,cleared=weapon&&weapon.RoundCleared,errors=SessionState.GetInt(Prefix+"errors",0)})+"\n");
            if(Round1TrackCapture.Active!=null){var c=Round1TrackCapture.Active;Round1TrackCapture.Active=null;c.CloseAll("end");File.WriteAllText(Output+"/"+Stage()+"-capture.json",c.ToJson("Reconstructed",elapsed,""));}
            Time.timeScale=1;SessionState.SetString(Prefix+"phase","exiting");EditorApplication.isPlaying=false;
        }
    }
    static bool CaptureTracks=>Environment.GetEnvironmentVariable("STAGE_PLAY_CAPTURE")=="1";
    static string EndMode=>Environment.GetEnvironmentVariable("STAGE_PLAY_END") is string m&&(m=="win"||m=="lose")?m:null;
    [Serializable] class EndRow {public string stage,mode,log;public bool won,banner,departed,gone,restarted;public float seconds;}
    // Banner -> press -> (win: flying -> gone -> press) -> restarted; captures <stage>-end-banner/-fly/-gone.png.
    static void StepEnd(float now,Round1Weapon weapon)
    {
        var end=Round1StageEnd.Current;int step=SessionState.GetInt(Prefix+"endStep",0);float t=now-SessionState.GetFloat(Prefix+"endStart",now);
        void Next(int n,float delay=0){SessionState.SetInt(Prefix+"endStep",n);SessionState.SetFloat(Prefix+"at",now+delay);}
        void Capture(string what){ScreenCapture.CaptureScreenshot(Output+"/"+Stage()+"-end-"+what+".png");}
        bool ended=weapon&&(weapon.GameOver||weapon.RoundCleared);
        if(step==0&&end&&end.State==Round1StageEnd.Phase.Banner&&end.WaitingForPress){Capture("banner");SessionState.SetBool(Prefix+"endBanner",true);Next(1,.5f);return;}
        if(step==1){end.Press();Next(2);return;}
        if(step==2&&end&&end.Won&&end.State==Round1StageEnd.Phase.Flying&&end.FlyAge>.45f){Capture("fly");SessionState.SetBool(Prefix+"endFly",true);Next(3);return;}
        if(step==2&&!ended){Next(5);return;}
        if(step==3&&end&&end.State==Round1StageEnd.Phase.Gone&&end.WaitingForPress){Capture("gone");SessionState.SetBool(Prefix+"endGone",true);Next(4,.5f);return;}
        if(step==4){SessionState.SetString(Prefix+"endLog",end.Log);end.Press();Next(5);return;}
        if(step==5||t>60)
        {
            if(step==5&&ended)return;
            var row=new EndRow{stage=Stage(),mode=EndMode,won=weapon&&!weapon.GameOver&&step==5&&SessionState.GetBool(Prefix+"endFly",false),banner=SessionState.GetBool(Prefix+"endBanner",false),
                departed=SessionState.GetBool(Prefix+"endFly",false),gone=SessionState.GetBool(Prefix+"endGone",false),restarted=step==5&&!ended,seconds=t,log=end?end.Log:SessionState.GetString(Prefix+"endLog","")};
            File.AppendAllText(Output+"/end.jsonl",JsonUtility.ToJson(row)+"\n");
            foreach(var k in new[]{"endBanner","endFly","endGone"})SessionState.EraseBool(Prefix+k);
            Time.timeScale=1;SessionState.SetString(Prefix+"phase","exiting");EditorApplication.isPlaying=false;
        }
    }
    // What is on screen at each capture: visible renderers with their viewport position, camera depth, object path and shader.
    static void DumpRenderers(Round1Weapon weapon,int shot)
    {
        if(!weapon)return;var cams=new[]{weapon.player.stageCamera}.Concat(UnityEngine.Object.FindObjectsByType<Camera>(FindObjectsSortMode.None)).Distinct().ToArray();
        var lines=new System.Collections.Generic.List<string>();
        foreach(var r in UnityEngine.Object.FindObjectsByType<Renderer>(FindObjectsSortMode.None))
        {
            if(!r.enabled||!r.gameObject.activeInHierarchy||!r.isVisible)continue;
            var cam=cams.FirstOrDefault(c=>c&&c.isActiveAndEnabled&&(c.cullingMask&(1<<r.gameObject.layer))!=0);if(!cam)continue;
            var v=cam.WorldToViewportPoint(r.bounds.center);if(v.z<=0||v.x<0||v.x>1||v.y<0||v.y>1)continue;
            string path=r.name;for(var t=r.transform.parent;t&&path.Length<160;t=t.parent)path=t.name+"/"+path;
            lines.Add(v.x.ToString("0.00")+","+v.y.ToString("0.00")+" z"+v.z.ToString("0")+" "+r.GetType().Name+" "+(r.sharedMaterial?r.sharedMaterial.name+" | "+r.sharedMaterial.shader.name:"<no material>")+" "+path);
        }
        File.WriteAllLines(Output+"/"+Stage()+"-"+shot+"-renderers.txt",lines);
    }
    [Serializable] class Row {public string stage;public float realSeconds,stageTime;public int capacityMisses,conditionalSkipped,triggeredEvents;public string spawnedModels;public int spawned,kills,hits,blasts,flashes,bossFlashes,maxEnemies,maxHostiles,lives,score,errors,bodyContacts,projectiles,lasers;public float speed;public string contacts,bossState,bossPos,playerPos,camera,musicLog,unseen,unseenLog;public float bossHealth;public int bossVolleys,groundSpawned,groundRuins,groundEntered,carriers,itemDrops,groundDrops,level,deathVolleys,shotBullets;public bool gameOver,cleared;}
}
