using System;
using System.Collections.Generic;
using UnityEngine;

// The original's sound (TXEKernel.Sound.SoundUtility over KANAI.Sound.SoundManager), rebuilt from
// Resources/Truxton/truxton-sound.json, which the truxton-sound skill recovers from the game. Clips are Resources/TruxtonAudio.
//   SE: requests queue and play once per frame (SoundUtility.PlayQue). Each clip keeps its SoundDatabase row: volume,
//     polyphony (how many of that clip may sound at once; isOverwrite restarts the oldest, else the request is dropped) and
//     guarantee (seconds before the same clip may start again).
//   Deaths: the explosion effect's EffectPalette pick (weighted by callRate) or InGameEffect._callSoundID, plus the model's
//     _overplayDeadSound (PawnEnemy._callDeadEffect plays both).
//   Music: the stage timeline's BGMEntryClips (PlaySection) through DefaultBGMPlaylist, faded by the clip's ease-out; game over
//     and result use the playlist's own BGMs. It follows Round1Playback, so seeking moves the music too.
public sealed class Round1Sound : MonoBehaviour
{
    [Serializable] public class ClipInfo { public string name,path,group,title;public float length,volume,guarantee;public int priority,polyphony,kind;public bool loop,overwrite; }
    [Serializable] public class Named { public string name,clip,source; }
    [Serializable] public class Weighted { public string clip;public int rate; }
    [Serializable] public class Effect { public string effect;public Weighted[] sounds; }
    [Serializable] public class Pair { public string model,bullet,template,section,clip;public int lap; }
    [Serializable] public class Laser { public string bullet,first,loop; }
    [Serializable] public class Weapon { public int arms;public string[] clips;public bool laser; }
    [Serializable] public class Bombs { public string[] clips; }
    [Serializable] public class PlaylistStage { public int stage;public Pair[] sections; }
    [Serializable] public class Playlist { public string name,gameover,result;public PlaylistStage[] stages; }
    [Serializable] public class Entry { public float start,duration,easeIn,easeOut;public int stageKind;public string section; }
    [Serializable] public class Stage { public string name,playlist;public int stageOrder;public Entry[] entries; }
    [Serializable] public class Rules
    {
        public ClipInfo[] clips;public Named[] events;public Bombs bombs;public Effect[] effects;public Pair[] deadOverplay,bulletSounds,bulletSoundLap;
        public Laser[] enemyLasers;public Weapon[] weapons;public Playlist[] playlists;public Stage[] stages;
    }
    sealed class Channel { public AudioSource source;public string clip;public float started;public object owner; }

    public const int Channels=32;
    public static float SeVolume=1,BgmVolume=1;
    public static Round1Sound Instance { get; private set; }
    public string stage="bg03stage";
    public Rules Data { get; private set; }
    // Plays per clip, requests dropped by polyphony/guarantee, and music changes, for checks.
    public readonly Dictionary<string,int> Played=new Dictionary<string,int>();
    public readonly List<string> MusicLog=new List<string>();
    public int Dropped { get; private set; }
    public string Music { get; private set; }

    readonly Dictionary<string,ClipInfo> info=new Dictionary<string,ClipInfo>();
    readonly Dictionary<string,AudioClip> loaded=new Dictionary<string,AudioClip>();
    readonly Dictionary<string,string> events=new Dictionary<string,string>(),overplay=new Dictionary<string,string>(),bulletSe=new Dictionary<string,string>();
    readonly Dictionary<string,int> laps=new Dictionary<string,int>();
    readonly Dictionary<string,Weighted[]> effects=new Dictionary<string,Weighted[]>();
    readonly Dictionary<string,Laser> lasers=new Dictionary<string,Laser>();
    readonly Dictionary<string,float> lastStart=new Dictionary<string,float>();
    readonly List<(string clip,float volume)> queue=new List<(string,float)>();
    readonly List<Channel> channels=new List<Channel>();
    readonly Dictionary<object,(bool fired,float seen)> beamState=new Dictionary<object,(bool,float)>();
    readonly List<object> expired=new List<object>();
    Channel system;AudioSource bgm;Round1Playback playback;Stage stageData;Playlist playlist;
    float clock;bool pausedBySound;System.Random random=new System.Random(1);

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    static void Boot(){if(FindObjectOfType<Round1Playback>())Ensure();}
    public static Round1Sound Ensure()
    {
        if(Instance)return Instance;
        var go=new GameObject("Sound");if(Application.isPlaying)DontDestroyOnLoad(go);else go.hideFlags=HideFlags.DontSave;
        return go.AddComponent<Round1Sound>();
    }
    // Hooks no-op in edit mode unless a check created the instance.
    static Round1Sound Live=>Instance?Instance:Application.isPlaying?Ensure():null;

    void Awake()
    {
        if(Instance && Instance!=this){Destroy(gameObject);return;}
        Instance=this;Load();
        for(int i=0;i<Channels;i++)channels.Add(new Channel{source=NewSource("SE "+i)});
        system=new Channel{source=NewSource("System")};system.source.ignoreListenerPause=true;
        bgm=NewSource("BGM");bgm.priority=0;
        if(Application.isPlaying){UnityEngine.SceneManagement.SceneManager.sceneLoaded+=OnSceneLoaded;UpdateListener();}
    }
    void OnDestroy(){UnityEngine.SceneManagement.SceneManager.sceneLoaded-=OnSceneLoaded;if(Instance==this){Instance=null;AudioListener.pause=false;}}
    // The built StagePlay_BGxx scenes have no AudioListener (the template's sat on the replaced camera), so nothing was
    // heard. Every source here is 2D: this object's own listener is enabled whenever the scene brings none of its own.
    void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene,UnityEngine.SceneManagement.LoadSceneMode mode){UpdateListener();playback=null;SelectStage();}
    void UpdateListener()
    {
        var own=GetComponent<AudioListener>();
        bool other=Array.Exists(FindObjectsOfType<AudioListener>(true),l=>l!=own && l.isActiveAndEnabled);
        if(!other && !own)own=gameObject.AddComponent<AudioListener>();
        if(own)own.enabled=!other;
    }
    AudioSource NewSource(string name)
    {
        var go=new GameObject(name);go.transform.SetParent(transform,false);
        var s=go.AddComponent<AudioSource>();s.playOnAwake=false;s.spatialBlend=0;return s;
    }
    void Load()
    {
        var text=Resources.Load<TextAsset>("Truxton/truxton-sound");
        if(!text){Debug.LogWarning("Truxton sound rules are missing; the game is silent.");Data=new Rules();return;}
        Data=JsonUtility.FromJson<Rules>(text.text);
        foreach(var c in Data.clips)info[c.name]=c;
        foreach(var e in Data.events)events[e.name]=e.clip;
        foreach(var p in Data.deadOverplay)overplay[p.model]=p.clip;
        foreach(var p in Data.bulletSounds)bulletSe[p.bullet]=p.clip;
        foreach(var p in Data.bulletSoundLap)laps[p.template]=p.lap;
        foreach(var e in Data.effects)effects[e.effect]=e.sounds;
        foreach(var l in Data.enemyLasers)lasers[l.bullet]=l;
        SelectStage();
    }
    // StagePlay scenes: the stage the playback presents (BG05Stage -> bg05stage; windows from tools/stage_enemies/build_music.py).
    // Also on every scene load: the player outlives the scene (DontDestroyOnLoad), so a later stage needs its own section list.
    void SelectStage()
    {
        if(Data==null || Data.stages==null)return;
        var pb=FindObjectOfType<Round1Playback>();
        if(pb)
        {
            string n=pb.presentation && pb.presentation.stage?pb.presentation.stage.name.ToLowerInvariant():"bg03stage";   // Round1/Stage01: BG03
            if(Array.Exists(Data.stages,s=>s.name==n))stage=n;
        }
        stageData=Array.Find(Data.stages,s=>s.name==stage);
        playlist=stageData==null?null:Array.Find(Data.playlists,p=>p.name==stageData.playlist);
    }
    public ClipInfo Info(string clip)=>clip!=null && info.TryGetValue(clip,out var i)?i:null;
    public AudioClip Clip(string name)
    {
        if(name==null)return null;if(loaded.TryGetValue(name,out var c))return c;
        var i=Info(name);c=i==null?null:Resources.Load<AudioClip>(i.path);
        if(!c)Debug.LogWarning("Missing original sound "+name);loaded[name]=c;return c;
    }

    // ---- hooks called by the game scripts ----
    public static void Event(string name){var s=Live;if(s && s.events.TryGetValue(name,out var clip))s.Request(clip);}
    public static void Play(string clip,float volume=1){var s=Live;if(s)s.Request(clip,volume);}
    public static void Hit()=>Event("hit");
    // A non-laser volley (WeaponNormalShot.PlayFireSound: _requestSounds[level-1]).
    public static void Fire(Round1Arms arms,int level){var s=Live;var w=s?s.WeaponFor(arms):null;if(w!=null && !w.laser)s.Request(w.clips[Mathf.Clamp(level,1,4)-1]);}
    // A laser sounds for as long as it is held (WeaponLaserShot.Fire Play on a channel, NoFire StopCh).
    public static void WeaponLoop(Round1Arms arms,int level,bool on)
    {
        var s=Live;if(!s)return;var w=s.WeaponFor(arms);
        string clip=on && w!=null && w.laser?w.clips[Mathf.Clamp(level,1,4)-1]:null;s.SetLoop("player-laser",clip);
    }
    public static void Bomb(int level){var s=Live;if(s && s.Data.bombs!=null)s.Request(s.Data.bombs.clips[Mathf.Clamp(level,1,3)-1]);}
    public static void Dead(string model,string effect)
    {
        var s=Live;if(!s)return;
        if(effect!=null && s.effects.TryGetValue(effect,out var table))s.Request(s.Pick(table));
        if(model!=null && s.overplay.TryGetValue(model,out var extra))s.Request(extra);
    }
    // InGameBulletManager.BulletFire: the template's BulletSounds SE. nSoundLap 0 sounds on the first rapid shot only.
    public static void EnemyFire(string template,string bullet,int rapidIndex)
    {
        var s=Live;if(!s || bullet==null || !s.bulletSe.TryGetValue(bullet,out var clip))return;
        if(rapidIndex>0 && (template==null || !s.laps.TryGetValue(template,out int lap) || lap==0))return;
        s.Request(clip);
    }
    // EnemyLaserCollision: _firstSound when the beam starts charging, _loopSound while it fires.
    public static void EnemyLaser(object beam,string bullet,float age,float charge,float duration,bool alive)
    {
        var s=Live;if(!s || beam==null || bullet==null || !s.lasers.TryGetValue(bullet,out var l))return;
        s.beamState.TryGetValue(beam,out var state);state.seen=s.clock;
        if(!state.fired && alive){if(!string.IsNullOrEmpty(l.first))s.Request(l.first);state.fired=true;}
        bool firing=alive && age>=charge && age<charge+duration;
        s.SetLoop(beam,firing && !string.IsNullOrEmpty(l.loop)?l.loop:null);
        if(alive)s.beamState[beam]=state;else s.beamState.Remove(beam);
    }
    // Item sounds are played by Round1Weapon's item rules (ItemEffectResult), each on the effect it had.
    public static void StopAll(){var s=Live;if(!s)return;s.queue.Clear();foreach(var c in s.channels){c.source.Stop();c.owner=null;}s.beamState.Clear();}

    Weapon WeaponFor(Round1Arms arms)=>Data.weapons==null?null:Array.Find(Data.weapons,w=>w.arms==(int)arms);
    string Pick(Weighted[] table)
    {
        int roll=random.Next(100);foreach(var w in table){roll-=w.rate;if(roll<0)return w.clip;}
        return table.Length>0?table[table.Length-1].clip:null;
    }
    void Request(string clip,float volume=1){if(clip!=null && info.ContainsKey(clip) && !queue.Exists(q=>q.clip==clip))queue.Add((clip,volume));}

    void Update(){Tick(Time.unscaledDeltaTime);}
    // Plays this frame's queue and follows the stage music. Checks call it directly in edit mode.
    public void Tick(float dt)
    {
        clock+=Mathf.Max(0,dt);
        foreach(var q in queue)Begin(q.clip,q.volume);
        queue.Clear();UpdateMusic();
        // A beam that is no longer updated (cleared by a bomb or a respawn) stops its loop.
        expired.Clear();foreach(var b in beamState)if(clock-b.Value.seen>.1f)expired.Add(b.Key);
        foreach(var b in expired){SetLoop(b,null);beamState.Remove(b);}
    }
    void Begin(string name,float volume)
    {
        var i=info[name];var clip=Clip(name);if(!clip)return;
        if(i.guarantee>0 && lastStart.TryGetValue(name,out float last) && clock-last<i.guarantee){Dropped++;return;}
        Channel channel=null;
        if(i.polyphony>0)
        {
            int playing=0;Channel oldest=null;
            foreach(var c in channels)if(c.owner==null && c.clip==name && c.source.isPlaying){playing++;if(oldest==null || c.started<oldest.started)oldest=c;}
            if(playing>=i.polyphony){if(!i.overwrite){Dropped++;return;}channel=oldest;}
        }
        if(channel==null)channel=Free();
        channel.source.Stop();channel.source.clip=clip;channel.source.loop=false;channel.source.volume=i.volume*volume*SeVolume;channel.source.Play();
        channel.clip=name;channel.started=clock;lastStart[name]=clock;
        Played.TryGetValue(name,out int n);Played[name]=n+1;
    }
    Channel Free()
    {
        Channel best=null;
        foreach(var c in channels){if(c.owner!=null)continue;if(!c.source.isPlaying)return c;if(best==null || c.started<best.started)best=c;}
        return best??channels[0];
    }
    void SetLoop(object owner,string name)
    {
        var channel=channels.Find(c=>Equals(c.owner,owner));
        if(name==null){if(channel!=null){channel.source.Stop();channel.owner=null;channel.clip=null;}return;}
        if(channel!=null && channel.clip==name)return;
        var clip=Clip(name);if(!clip)return;
        if(channel==null){channel=channels.Find(c=>c.owner==null && !c.source.isPlaying)??Free();channel.owner=owner;}
        var i=info[name];channel.source.clip=clip;channel.source.loop=true;channel.source.volume=i.volume*SeVolume;channel.source.Play();
        channel.clip=name;channel.started=clock;Played.TryGetValue(name,out int n);Played[name]=n+1;
    }

    // ---- music ----
    void UpdateMusic()
    {
        if(!playback)playback=FindObjectOfType<Round1Playback>();
        if(!playback || stageData==null || playlist==null){SetMusic(null,0,0,false);return;}
        var weapon=playback.weapon;
        bool paused=!playback.playing && weapon && !weapon.GameOver && !weapon.RoundCleared && !(weapon.combat && weapon.combat.boss && weapon.combat.boss.StageCleared);
        if(paused!=pausedBySound)
        {
            pausedBySound=paused;if(Application.isPlaying)AudioListener.pause=paused;
            var cue=Clip(events.TryGetValue("pause",out var p)?p:null);if(cue){system.source.PlayOneShot(cue,info[p].volume*SeVolume);Played.TryGetValue(p,out int n);Played[p]=n+1;}
        }
        if(paused)return;
        if(weapon && weapon.GameOver){SetMusic(playlist.gameover,0,1,false);return;}
        var boss=weapon && weapon.combat?weapon.combat.boss:null;
        if((weapon && weapon.RoundCleared) || (boss && boss.StageCleared)){SetMusic(playlist.result,0,1,false);return;}
        float t=playback.elapsed;Entry entry=null;
        foreach(var e in stageData.entries)if(t>=e.start && t<e.start+e.duration){entry=e;break;}
        // The boss holds the stage past its timeline clip: keep its music until the fight ends.
        if(entry==null && boss && boss.HoldsStage)entry=Array.Find(stageData.entries,e=>e.section=="Boss");
        if(entry==null){SetMusic(null,0,0,false);return;}
        var sections=Array.Find(playlist.stages,s=>s.stage==entry.stageKind);
        string clip=sections==null?null:Array.Find(sections.sections,s=>s.section==entry.section)?.clip;
        float end=entry.start+entry.duration,fade=entry.easeOut>0 && t>end-entry.easeOut?Mathf.Clamp01((end-t)/entry.easeOut):1;
        if(entry.easeIn>0 && t<entry.start+entry.easeIn)fade*=Mathf.Clamp01((t-entry.start)/entry.easeIn);
        SetMusic(clip,t-entry.start,fade,!(weapon && weapon.intro && weapon.intro.Active));
    }
    void SetMusic(string name,float position,float fade,bool follow)
    {
        if(name!=Music)
        {
            bgm.Stop();Music=name;MusicLog.Add($"{(playback?playback.elapsed:0):0.00}s {name??"(silence)"}");
            var clip=Clip(name);if(!clip)return;
            bgm.clip=clip;bgm.loop=info[name].loop;bgm.time=Wrap(position,clip);bgm.Play();
            Played.TryGetValue(name,out int n);Played[name]=n+1;
        }
        if(name==null || !bgm.clip)return;
        bgm.volume=info[name].volume*fade*BgmVolume;
        // Follow seeks on the stage clock; the intro holds the clock at 0 while the music runs.
        if(follow && bgm.isPlaying && Mathf.Abs(bgm.time-Wrap(position,bgm.clip))>1f && bgm.clip.length-Mathf.Abs(bgm.time-Wrap(position,bgm.clip))>1f)bgm.time=Wrap(position,bgm.clip);
    }
    static float Wrap(float t,AudioClip clip)=>clip.length>0?Mathf.Repeat(Mathf.Max(0,t),clip.length-.01f):0;
}
