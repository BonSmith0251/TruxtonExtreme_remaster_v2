using UnityEngine;

// Arcade hooks (ArcadeMachine): the player state the original's ArcadePlayPresenter.CarriedData takes from one stage
// to the next, extends, and continuing in place after a game over.
public partial class Round1Weapon
{
    [System.Serializable] public class ArcadeCarry { public int score,lives,bombs,bombLevel,level,changeCharges,speedLevel,arms; }

    public ArcadeCarry CaptureCarry()=>new ArcadeCarry{score=Score,lives=Lives,bombs=Bombs,bombLevel=BombLevel,level=Level,changeCharges=ChangeCharges,speedLevel=SpeedLevel,arms=(int)Arms};

    // A new credit's ship (carry null) or the previous stage's. The table's top score is the high score shown.
    public void BeginArcadeStage(ArcadeCarry carry,int startLives,long tableTop)
    {
        Initialize();persistHighScore=false;
        if(carry==null)Lives=startLives;
        else
        {
            Score=carry.score;Lives=Mathf.Max(1,carry.lives);Bombs=carry.bombs;BombLevel=Mathf.Clamp(carry.bombLevel,1,3);Level=Mathf.Clamp(carry.level,1,4);
            ChangeCharges=carry.changeCharges;SpeedLevel=Mathf.Clamp(carry.speedLevel,1,6);Arms=(Round1Arms)Mathf.Clamp(carry.arms,0,6);
        }
        HighScore=(int)System.Math.Min(int.MaxValue,System.Math.Max(tableTop,Score));
        if(player)player.SpeedMultiplier=rules!=null?rules.speeds[SpeedLevel-1]:1+(SpeedLevel-1)*.4f;
        ApplyShipUpgrades();
    }
    public void GrantExtend(){Lives=Mathf.Min(99,Lives+1);Tell("EXTEND");}

    // Continue where the last ship was lost: fresh stock, the stage resumes with the respawn's flashing invincibility.
    public void ArcadeContinue(int lives)
    {
        if(!GameOver)return;
        GameOver=false;Lives=lives;Bombs=Mathf.Max(Bombs,3);Health=MaximumHealth;respawn=0;invincible=3;
        player.ResetPosition();player.InputEnabled=true;SetShipVisible(true);player.BeginSpawn(true);
        player.playback.playing=true;Tell("CONTINUE");
    }
}
