using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

// Arcade cabinet rules (user request 2026-11-02, "update this game as an arcade game"): the original game's own ARCADE
// play mode (OutGame.Arcade.ArcadePlayModel / ArcadePlayPresenter.CarriedData) inside a coin-op cabinet loop. Plain data
// and rules only, no scene access, so ReconstructionArcadeCheck can exercise them directly.
//
// From the original data:
//  - stage order: the BGMEntry stageKind of each BGxxStage timeline (Resources/Truxton/truxton-sound.json "stageOrder"):
//    1 BG03, 2 BG05, 3 BG04, 4 BG06, 5 BG07, 6 BG02, 7 BG01, 8 BG08 (the presenter's StageDatas table has 8 entries);
//  - schedule mode: TLGameModeFlag Arcade1 (32), Arcade bullet selectors and bullet area (Round1EnemyAttacks);
//  - extends: InGame/InGameReference/Database/ExtendsArcade (_startExtend 5,000,000, _stepExtend 10,000,000,
//    _endExtend 1,000,000,000);
//  - carried between stages: CarriedData (_pinfo player state, _highScore, _clearCount, _startRound) and the round
//    loop (ArcadeStageInformation._isRoundLoop / ReachedRound).
// Authored cabinet defaults (not from the original, which is a console/PC game): 1 coin 1 credit, 3 ships, continue in
// place with a 10 s countdown, round 2 loop then ending, top-10 table with 3 initials.
public static class ArcadeRules
{
    public static readonly string[] StageOrder={"BG03","BG05","BG04","BG06","BG07","BG02","BG01","BG08"};
    public const int Arcade1Mask=32,ArcadeSelectorMode=0;
    public const long OriginalExtendStart=5000000,OriginalExtendStep=10000000,OriginalExtendEnd=1000000000;
    public static string SceneFor(int stageIndex)=>"StagePlay_"+StageOrder[Mathf.Clamp(stageIndex,0,StageOrder.Length-1)];

    // Extends earned by a score: the first at start, then one every step, none past end (ExtendsArcade). 0 start = off.
    public static int ExtendsFor(long score,long start,long step,long end)
    {
        if(start<=0 || score<start)return 0;
        long capped=Math.Min(score,end>0?end:long.MaxValue);
        return step<=0?1:1+(int)Math.Min(int.MaxValue-1,(capped-start)/step);
    }
}

// Operator settings (service mode, F2). Game: difficulty 0 EASY = the original Story A schedule and bullet rules,
// 1 NORMAL = ARCADE (mask 32, Arcade selectors); extendPreset 0 original table, 1 scaled for the remaster's current
// scoring, 2 off (the remaster lacks the original's score multiplier system, so a stage scores about 100,000 and the
// original table's first extend at 5,000,000 is out of reach). Coins: two chutes, each "n coins give m credits"
// (coinsPerCredit is chute A's coin count, kept under its first name so older settings files still load).
// Sound volumes 0-10. Display: mode 0 full-screen window, 1 exclusive full screen, 2 window; resolution 0 = the
// monitor's own, else Resolutions[n-1]; frameLimit index into FrameLimits (0 = none).
[Serializable] public class ArcadeSettings
{
    public bool freePlay;
    public int coinsPerCredit=1,creditsPerCoinA=1,coinsPerCreditB=1,creditsPerCoinB=1;
    public int maxCredits=9;
    public int difficulty=1;
    public int startLives=3;
    // PlayedRecords "Evolution unlocked" (lifetime PlayerLevel 500) / "again" (900): top power level 3 + this (AWAKEN.md).
    public int evolution;
    public bool autoBomb;   // GameSetting._autoBomb, default 0: a lethal hit fires a bomb instead while one is left
    public int startStage=1;
    public bool continues=true;
    public int continueSeconds=10;
    public bool roundLoop=true;
    public int extendPreset=0;
    public float demoSeconds=40;
    public int masterVolume=10,musicVolume=8,effectsVolume=10;
    public bool attractSound=true,attractMusic=true;
    public int displayMode=0,resolution=0,frameLimit=1;
    public bool vSync=true,showCredits=true;
    public static readonly string[] ExtendNames={"ORIGINAL 5M/10M","500K/1M","OFF"};
    public static readonly string[] DifficultyNames={"EASY","NORMAL"};
    public static readonly string[] DisplayModeNames={"FULL SCREEN WINDOW","EXCLUSIVE FULL SCREEN","WINDOW"};
    public static readonly Vector2Int[] Resolutions={new Vector2Int(1280,720),new Vector2Int(1600,900),new Vector2Int(1920,1080),new Vector2Int(2560,1440),new Vector2Int(3840,2160)};
    public static readonly int[] FrameLimits={0,60,120,144};
    public int GameModeMask=>difficulty==0?2:ArcadeRules.Arcade1Mask;          // TLGameModeFlag StoryA 2 / Arcade1 32
    public int SelectorMode=>difficulty==0?1:ArcadeRules.ArcadeSelectorMode;    // Round1EnemyAttacks Story 1 / Arcade 0
    public string ResolutionName=>resolution==0?"MONITOR":Resolutions[resolution-1].x+"X"+Resolutions[resolution-1].y;
    public void Extends(out long start,out long step,out long end)
    {
        switch(extendPreset)
        {
            case 1:start=500000;step=1000000;end=ArcadeRules.OriginalExtendEnd;break;
            case 2:start=step=end=0;break;
            default:start=ArcadeRules.OriginalExtendStart;step=ArcadeRules.OriginalExtendStep;end=ArcadeRules.OriginalExtendEnd;break;
        }
    }
    public void Clamp()
    {
        coinsPerCredit=Mathf.Clamp(coinsPerCredit,1,9);coinsPerCreditB=Mathf.Clamp(coinsPerCreditB,1,9);
        creditsPerCoinA=Mathf.Clamp(creditsPerCoinA,1,9);creditsPerCoinB=Mathf.Clamp(creditsPerCoinB,1,9);maxCredits=Mathf.Clamp(maxCredits,1,99);
        difficulty=Mathf.Clamp(difficulty,0,DifficultyNames.Length-1);startLives=Mathf.Clamp(startLives,1,5);startStage=Mathf.Clamp(startStage,1,ArcadeRules.StageOrder.Length);
        continueSeconds=Mathf.Clamp(continueSeconds,5,30);extendPreset=Mathf.Clamp(extendPreset,0,ExtendNames.Length-1);demoSeconds=Mathf.Clamp(demoSeconds,10,120);
        masterVolume=Mathf.Clamp(masterVolume,0,10);musicVolume=Mathf.Clamp(musicVolume,0,10);effectsVolume=Mathf.Clamp(effectsVolume,0,10);
        displayMode=Mathf.Clamp(displayMode,0,DisplayModeNames.Length-1);resolution=Mathf.Clamp(resolution,0,Resolutions.Length);frameLimit=Mathf.Clamp(frameLimit,0,FrameLimits.Length-1);
    }
}

// Credits and bookkeeping. Every coin and every paid start/continue changes the ledger once and is saved at once.
[Serializable] public class ArcadeLedger
{
    public int credits,coinRemainder,coinRemainderB;
    public int totalCoins,coinsB,serviceCredits,gamesStarted,continuesUsed,extendsGiven,allClears;
    public double playSeconds;
    public int CoinsA=>totalCoins-coinsB;
    public bool CanPay(ArcadeSettings s)=>s.freePlay || credits>0;
    // A coin always counts; once a chute has its coin count in, it gives its credits, up to maxCredits (later coins
    // still count). Returns the credits added.
    public int InsertCoin(ArcadeSettings s,int chute=0)
    {
        totalCoins++;if(chute==1)coinsB++;
        int need=chute==1?s.coinsPerCreditB:s.coinsPerCredit,give=chute==1?s.creditsPerCoinB:s.creditsPerCoinA;
        if(chute==1){if(++coinRemainderB<need)return 0;coinRemainderB=0;}else{if(++coinRemainder<need)return 0;coinRemainder=0;}
        int before=credits;credits=Mathf.Min(s.maxCredits,credits+give);return credits-before;
    }
    public void ServiceCredit(ArcadeSettings s){serviceCredits++;if(credits<s.maxCredits)credits++;}
    public bool Pay(ArcadeSettings s,bool isContinue)
    {
        if(!s.freePlay){if(credits<=0)return false;credits--;}
        if(isContinue)continuesUsed++;else gamesStarted++;
        return true;
    }
    // Service mode "reset counters": the bookkeeping only; credits in the machine stay.
    public void ResetCounters(){totalCoins=coinsB=serviceCredits=gamesStarted=continuesUsed=extendsGiven=allClears=0;playSeconds=0;}
}

[Serializable] public class ArcadeRankEntry
{
    public string initials="TXE";
    public long score;
    public int stage=1,round=1,continues;
    public bool allClear;
    public string date="";
}

[Serializable] public class ArcadeRankings
{
    public const int Size=10;
    public List<ArcadeRankEntry> entries=new List<ArcadeRankEntry>();
    public static ArcadeRankings Defaults()
    {
        var r=new ArcadeRankings();string[] names={"TXE","TOA","TAT","SUJ","ASH","BOB","CRG","TPL","ARC","EXT"};
        for(int i=0;i<Size;i++)r.entries.Add(new ArcadeRankEntry{initials=names[i],score=500000-i*45000,stage=Mathf.Max(1,5-i/2)});
        return r;
    }
    public long Top=>entries.Count>0?entries[0].score:0;
    public bool Qualifies(long score)=>score>0 && (entries.Count<Size || score>entries[entries.Count-1].score);
    // Inserts below every equal score (earlier entries keep their place); returns the rank index or -1.
    public int Insert(ArcadeRankEntry entry)
    {
        if(!Qualifies(entry.score))return -1;
        int at=entries.FindIndex(e=>entry.score>e.score);if(at<0)at=entries.Count;
        entries.Insert(at,entry);while(entries.Count>Size)entries.RemoveAt(entries.Count-1);
        return at<Size?at:-1;
    }
}

// The run the original carries from stage to stage (CarriedData), plus the cabinet's own counts.
[Serializable] public class ArcadeSession
{
    public int stageIndex,round=1,continues,extendsGiven,clearCount;
    public bool allClear;
    public Round1Weapon.ArcadeCarry carry;
    public int StageNumber=>stageIndex+1;
}

// Settings, ledger and rankings as JSON files, each written to a temporary file and then swapped in, so a crash
// mid-write leaves the previous copy. (A pulse lost while the process is down is not covered: that needs hardware.)
public sealed class ArcadeStorage
{
    public readonly string root;
    public ArcadeStorage(string root){this.root=root;Directory.CreateDirectory(root);}
    public static string DefaultRoot()
    {
        string over=Environment.GetEnvironmentVariable("TRUXTON_ARCADE_DATA");
        return string.IsNullOrEmpty(over)?Path.Combine(Application.persistentDataPath,"arcade"):over;
    }
    public T Load<T>(string name,Func<T> fallback) where T:class
    {
        foreach(string path in new[]{Path.Combine(root,name+".json"),Path.Combine(root,name+".json.bak")})
        {
            try{if(File.Exists(path)){var v=JsonUtility.FromJson<T>(File.ReadAllText(path));if(v!=null)return v;}}
            catch(Exception e){Debug.LogWarning("[Arcade] unreadable "+path+": "+e.Message);}
        }
        return fallback();
    }
    public bool Save(string name,object value)
    {
        string path=Path.Combine(root,name+".json"),temp=path+".tmp";
        // A scanner or indexer can hold the just-written file for a moment (seen in the check: two saves in one frame),
        // so the swap is retried before giving up; the last resort overwrites in place.
        Exception last=null;
        for(int attempt=0;attempt<5;attempt++)
        {
            try
            {
                File.WriteAllText(temp,JsonUtility.ToJson(value,true));
                if(File.Exists(path))File.Replace(temp,path,path+".bak");else File.Move(temp,path);
                return true;
            }
            catch(IOException e){last=e;System.Threading.Thread.Sleep(15);}
            catch(UnauthorizedAccessException e){last=e;System.Threading.Thread.Sleep(15);}
        }
        try{File.Copy(temp,path,true);File.Delete(temp);Debug.LogWarning("[Arcade] saved "+path+" without a swap: "+last.Message);return true;}
        catch(Exception e){Debug.LogError("[Arcade] could not save "+path+": "+e.Message);return false;}
    }
}
