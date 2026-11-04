using UnityEngine;

// The original's dynamic rank, InGameManager._DiPoint (evidence/items/RANK.md): every change is
// DiPoint = clamp(DiPoint + delta, _DiMin, _DiMax). Arcade amounts (Resident/PointTables/ArcadeAddPoints.asset): +0.0333/s of
// play, +0.1 per real power-level rise, +0.1 per bomb-stock item taken, -1 per bomb, +5 per boss destroyed, -2.5 per life
// lost (AddDiPoint_EnemyDestroy has no callers). SetupDiPointFactor 0x1CEBC60: the bounds are ClampBase[stage] + 100 x round.
// It is kept through deaths, continues and stages (re-clamped). Consumers (InGameScalability.asset): the enemy bullet speed
// scale (0.1, 3.5) and the repeat-event delay scale (1.2, 0.8), both Lerp(1, end, |d| / 1000).
public partial class Round1Weapon
{
    const float RankSecond=.033333335f,RankPowerUp=.1f,RankBombStock=.1f,RankBombUse=-1,RankBoss=5,RankDeath=-2.5f;
    static readonly Vector2[] RankClampBase={new Vector2(-10,30),new Vector2(0,40),new Vector2(10,50),new Vector2(20,60),
        new Vector2(30,70),new Vector2(40,80),new Vector2(50,90),new Vector2(60,100)};
    const float RankRoundUp=100;
    public float RankPoint { get; private set; }
    public float RankMin { get; private set; }=-10;
    public float RankMax { get; private set; }=30;
    RoundBoss rankedBoss;
    // stage = the arcade stage order index (0..7), round = the round loop (0 first time round).
    public void SetupRank(int stage,int round,float point)
    {
        var b=RankClampBase[Mathf.Clamp(stage,0,RankClampBase.Length-1)];
        RankMin=Mathf.Clamp(b.x+round*RankRoundUp,-1000,999);RankMax=Mathf.Clamp(b.y+round*RankRoundUp,-1000,999);
        RankPoint=Mathf.Clamp(point,RankMin,RankMax);
    }
    public static int RankStageIndex(string stage){int i=System.Array.IndexOf(ArcadeRules.StageOrder,stage);return i<0?0:i;}
    // StagePlay_BG05 -> BG05; the Round1 / Stage01 scenes are BG03.
    static string SceneStage(){var m=System.Text.RegularExpressions.Regex.Match(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name,"BG0[1-8]");return m.Success?m.Value:"BG03";}
    void AddRank(float delta){RankPoint=Mathf.Clamp(RankPoint+delta,RankMin,RankMax);}
    static float RankLerp(float d,float low,float high){float t=Mathf.Clamp01(Mathf.Abs(Mathf.Clamp(d,-1000,1000))/1000);return d>0?Mathf.Lerp(1,high,t):d<0?Mathf.Lerp(1,low,t):1;}
    // InGameScalability._bulletSpeedScale: written to the bullet manager every frame, applied when a bullet is fired.
    public float RankBulletSpeedScale=>RankLerp(RankPoint,.1f,3.5f);
    // _eventRepeatScale: repeat delay, first delay and random wait of RouteEvents with rpidf, read when the event starts.
    public float RankRepeatScale=>RankLerp(RankPoint,1.2f,.8f);
    void StepRank(float dt)
    {
        // Update 0x1CEE2AC: play time while the stage runs (the death phase runs at play rate 0).
        if(SimulationRunning && !Respawning)AddRank(RankSecond*dt);
        // StopBossTimer -> AddDiPoint_BossDestroy, once per boss.
        var boss=combat?combat.boss:null;
        if(boss && boss!=rankedBoss && boss.State==RoundBoss.EncounterState.Defeating){rankedBoss=boss;AddRank(RankBoss);}
        if(combat && combat.sourceAttacks)combat.sourceAttacks.bulletSpeedScale=RankBulletSpeedScale;
    }
}
