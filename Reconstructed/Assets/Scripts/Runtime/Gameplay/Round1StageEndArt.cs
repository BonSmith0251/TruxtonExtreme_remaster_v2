using UnityEngine;

// Resources/Truxton/StageEndArt.asset: the original result art Round1StageEnd shows. succeeded / failed are the result
// screen's labels (OriginalGame/Sprite/sp_ui_result_succeeded, _failed, ResidentMenu atlas); gameOver is the in-game
// GameOverLogo sprite (TXE_GraphicData/UI/sp_ui_menu_title_gameover, drawn 992 x 144 by ViewGameover).
public sealed class Round1StageEndArt : ScriptableObject
{
    public Sprite succeeded,failed,gameOver;
}
