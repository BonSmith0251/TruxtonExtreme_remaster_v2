using UnityEngine;

// Resources/Truxton/ShotLook.asset (Round1ShotLookBuilder): the original laser strip textures by Round1Arms
// (Vfx_eff_p_shot30/70 strips: sp_eff_p_shot32/33 thunder, 42/43 gold, 72/73 black with the dark 74 underlay).
public sealed class Round1ShotLook : ScriptableObject
{
    public Texture2D[] laserMain,laserSub,laserDark;
    static Round1ShotLook current;
    public static Round1ShotLook Current=>current?current:(current=Resources.Load<Round1ShotLook>("Truxton/ShotLook"));
}
