using System.IO;
using UnityEditor;
using UnityEngine;

// Builds Resources/Truxton/ScorePopupArt.asset from the original Score5000 popup's art (evidence/items/POPUPS.md).
// Batch: -executeMethod ReconstructionScorePopupArt.Build
public static class ReconstructionScorePopupArt
{
    const string Asset="Assets/Resources/Truxton/ScorePopupArt.asset";
    const string Plate="Assets/OriginalGame/TXE_GraphicData/Effect/Sprite/sp_eff_5000pts01.png";
    const string Font="Assets/OriginalGame/TXE_GraphicData/UI/ui_font_result01_";
    [MenuItem("Truxton/Build score popup art")]
    public static void Build(){BuildAsset();}
    public static Round1ScorePopupArt BuildAsset()
    {
        var art=AssetDatabase.LoadAssetAtPath<Round1ScorePopupArt>(Asset);
        bool create=!art;if(create)art=ScriptableObject.CreateInstance<Round1ScorePopupArt>();
        art.plate=AssetDatabase.LoadAssetAtPath<Texture2D>(Plate);
        art.cross=AssetDatabase.LoadAssetAtPath<Sprite>(Font+"9.asset");
        art.digits=new Sprite[10];for(int i=0;i<10;i++)art.digits[i]=AssetDatabase.LoadAssetAtPath<Sprite>(Font+(15+i)+".asset");   // _nums 0..9
        if(!art.plate || !art.cross || System.Array.IndexOf(art.digits,null)>=0)throw new FileNotFoundException("Score popup art is missing under Assets/OriginalGame.");
        if(create)AssetDatabase.CreateAsset(art,Asset);else EditorUtility.SetDirty(art);
        AssetDatabase.SaveAssets();return art;
    }
}
