using UnityEngine;

// Resources/Truxton/ScorePopupArt.asset (ReconstructionScorePopupArt.Build): the original Score5000 popup's art
// (Samples/Prefabs/Reference/Effect/SignBoard/Prefabs/Score5000.prefab): the "5000" plate sp_eff_5000pts01, the "x"
// ui_font_result01_9 and the digits 0..9 ui_font_result01_15..24 (ResidentSpriteAtlas). evidence/items/POPUPS.md.
public sealed class Round1ScorePopupArt : ScriptableObject
{
    public Texture2D plate;
    public Sprite cross;
    public Sprite[] digits;
    static Round1ScorePopupArt current;
    public static Round1ScorePopupArt Current=>current?current:(current=Resources.Load<Round1ScorePopupArt>("Truxton/ScorePopupArt"));
}
