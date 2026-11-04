using UnityEngine;

// Arcade hooks (ArcadeMachine): the player state the original's ArcadePlayPresenter.CarriedData takes from one stage
// to the next, extends, and continuing in place after a game over.
public partial class Round1Weapon
{
    // PlayerInformation.ClearByStage keeps power (and its items), speed and capacity, weapon and bombs; the bonus
    // multiplier and pending extends live in PlayerCommonData, which carries over too.
    [System.Serializable] public class ArcadeCarry { public int score,lives,bombs,level,powerItems,speedLevel,speedCapacity,arms,bonusMultiplier,pendingExtends;public float rank; }

    public ArcadeCarry CaptureCarry()=>new ArcadeCarry{score=Score,lives=Lives,bombs=Bombs,level=Level,powerItems=PowerItems,speedLevel=SpeedLevel,
        speedCapacity=SpeedCapacity,arms=(int)Arms,bonusMultiplier=BonusMultiplier,pendingExtends=PendingExtends,rank=RankPoint};

    // A new credit's ship (carry null) or the previous stage's. The table's top score is the high score shown.
    // stage: the arcade stage order index, round: 1 = first time round (the rank carries over and is re-clamped).
    public void BeginArcadeStage(ArcadeCarry carry,int startLives,long tableTop,int stage=0,int round=1)
    {
        Initialize();persistHighScore=false;
        if(carry==null)Lives=startLives;
        else
        {
            Score=carry.score;Lives=Mathf.Clamp(carry.lives,1,LivesMax);Bombs=Mathf.Clamp(carry.bombs,0,BombsMax);Level=Mathf.Clamp(carry.level,1,LevelMax);
            PowerItems=Mathf.Clamp(carry.powerItems,0,Level>=LevelMax?3:2);SpeedCapacity=Mathf.Clamp(carry.speedCapacity,0,SpeedCapacityMax);
            SpeedLevel=Mathf.Clamp(carry.speedLevel,1,SpeedCapacity+1);Arms=(Round1Arms)Mathf.Clamp(carry.arms,0,6);
            BonusMultiplier=Mathf.Clamp(carry.bonusMultiplier,0,BonusMax);PendingExtends=Mathf.Clamp(carry.pendingExtends,0,99);
        }
        SetupRank(stage,Mathf.Max(0,round-1),carry!=null?carry.rank:0);
        HighScore=(int)System.Math.Min(int.MaxValue,System.Math.Max(tableTop,Score));
        ApplySpeed();ApplyShipUpgrades();
    }

    // Continue where the last ship was lost: fresh stock, the stage resumes with the respawn's flashing invincibility.
    public void ArcadeContinue(int lives)
    {
        if(!GameOver)return;
        GameOver=false;Lives=lives;Bombs=Mathf.Max(Bombs,StartBombs);Health=MaximumHealth;respawn=0;invincible=3;
        player.ResetPosition();player.InputEnabled=true;SetShipVisible(true);player.BeginSpawn(true);
        player.playback.playing=true;Tell("CONTINUE");
    }
}
