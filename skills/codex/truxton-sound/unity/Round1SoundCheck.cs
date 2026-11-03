using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

// Round1Sound in Stage01: every clip in truxton-sound.json loads with its original length, the stage music follows the
// BG03 timeline sections, and an autopilot run of the stage plays the original shots, hits, deaths and enemy fire.
public static class Round1SoundCheck
{
    const string Flag="Truxton.SoundCheck";static double started;
    [Serializable] class Result { public bool passed;public string error;public string[] checks,missing,mismatched,music,played;public int clips,dropped;public float seconds;public int kills,lives; }
    [InitializeOnLoadMethod] static void Register(){EditorApplication.playModeStateChanged+=Changed;}
    public static void RunBatch(){EditorSceneManager.OpenScene("Assets/TruxtonImported/Scenes/Stage01.unity");SessionState.SetInt(Flag,1);EditorApplication.isPlaying=true;}
    static void Changed(PlayModeStateChange state)
    {
        if(SessionState.GetInt(Flag,0)==0)return;
        if(state==PlayModeStateChange.EnteredPlayMode){started=EditorApplication.timeSinceStartup;EditorApplication.update+=Check;}
        if(state==PlayModeStateChange.EnteredEditMode){int code=SessionState.GetInt(Flag,3);SessionState.EraseInt(Flag);EditorApplication.delayCall+=()=>EditorApplication.Exit(code==2?0:1);}
    }
    static void Require(bool ok,string message){if(!ok)throw new Exception(message);}
    static void Check()
    {
        if(EditorApplication.timeSinceStartup-started<2)return;EditorApplication.update-=Check;
        var result=new Result();var checks=new List<string>();
        try
        {
            var s=Round1Sound.Instance;Require(s,"Round1Sound did not start with the scene");
            var missing=new List<string>();var mismatched=new List<string>();
            foreach(var c in s.Data.clips)
            {
                var clip=Resources.Load<AudioClip>(c.path);
                if(!clip){missing.Add(c.name);continue;}
                if(Mathf.Abs(clip.length-c.length)>.05f)mismatched.Add($"{c.name} {clip.length:0.000}/{c.length:0.000}");
            }
            result.clips=s.Data.clips.Length;result.missing=missing.ToArray();result.mismatched=mismatched.ToArray();
            Require(result.clips==560 && missing.Count==0 && mismatched.Count==0,$"Clips: {result.clips}, missing {missing.Count}, length mismatches {mismatched.Count}");
            checks.Add("All 560 original clips load from Resources/TruxtonAudio with their original lengths");

            var w=UnityEngine.Object.FindFirstObjectByType<Round1Weapon>();var c2=w.combat;var p=w.player;var stage=p.playback;var pilot=w.autopilot;
            w.persistHighScore=false;
            Action reset=()=>{stage.playing=true;stage.elapsed=0;w.ResetRun();if(w.intro)w.intro.Cancel();p.CancelSpawn();p.InputEnabled=true;c2.automaticWaves=true;if(pilot){pilot.SetAutomatic(true);pilot.useBombs=true;}};
            // Music by section: BGMEntryClips at 0 / 195 / 418 s, OnTheWay1 / OnTheWay2 / Boss of DefaultBGMPlaylist stage 1.
            reset();
            foreach(var (t,clip) in new[]{(10f,"txe_bgm_f000"),(194f,null),(200f,"txe_bgm_f004"),(420f,"txe_bgm_b000"),(30f,"txe_bgm_f000")})
            {stage.Seek(t);s.Tick(1/60f);Require(s.Music==clip,$"At {t}s music is {s.Music??"silence"}, expected {clip??"silence"}");}
            stage.Seek(191.5f);s.Tick(1/60f);var bgm=s.GetComponentsInChildren<AudioSource>().First(a=>a.name=="BGM");
            Require(bgm.volume>.2f*.79f && bgm.volume<.8f*.79f,"Section ease-out fade missing: volume "+bgm.volume);
            checks.Add("Stage music follows the BG03 timeline: f000 at 0 s, f004 at 195 s, b000 (CRISIS) at 418 s, 3 s ease-out, seeks resync");

            reset();s.Played.Clear();
            for(int i=0;i<240*60 && !w.GameOver;i++)
            {
                float dt=1/60f;stage.Advance(dt);if(pilot){pilot.Decide(dt);p.Move(pilot.Direction,dt);}c2.Step(dt);c2.boss.Step(dt);w.Step(dt,!pilot || pilot.WantsFire);s.Tick(dt);
            }
            result.seconds=stage.elapsed;result.kills=c2.Kills;result.lives=w.Lives;result.dropped=s.Dropped;
            result.played=s.Played.OrderByDescending(x=>x.Value).Select(x=>x.Key+" "+x.Value).ToArray();result.music=s.MusicLog.ToArray();
            Require(s.Played.ContainsKey("powershot_lv1"),"Player shot sound not played");
            Require(s.Played.ContainsKey("enemy_hit_01"),"Hit sound not played");
            Require(s.Played.ContainsKey("exp_S5"),"Sa01 death (pf_eff_explposion01 -> exp_S5) not played");
            Require(s.Played.Keys.Any(k=>k.StartsWith("enemybullet")),"Enemy fire sound not played");
            Require(s.Played.Keys.Any(k=>k.StartsWith("meteor_exp")),"Meteor explosion sound not played");
            checks.Add($"Autopilot run ({result.seconds:0} s, {result.kills} kills): shots, hits, deaths, meteors and enemy fire sound");
            result.passed=true;
        }
        catch(Exception ex){result.error=ex.ToString();Debug.LogException(ex);}
        result.checks=checks.ToArray();File.WriteAllText("round1-sound-validation.json",JsonUtility.ToJson(result,true));SessionState.SetInt(Flag,result.passed?2:3);EditorApplication.isPlaying=false;
    }
}
