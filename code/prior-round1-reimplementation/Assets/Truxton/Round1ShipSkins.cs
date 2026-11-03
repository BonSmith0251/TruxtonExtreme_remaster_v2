using UnityEngine;

// Resources/Truxton/ShipSkins.asset (Round1ShipSkinBuilder): the original's colour variants of the ship
// (mt_player01 Variant_*), its option pods (mt_player01_op Variant_*) and upgrade parts (mt_player01_upgrade Variant_*),
// indexed by Round1Arms. The ship takes the colour of the weapon it carries.
public sealed class Round1ShipSkins : ScriptableObject
{
    public Material[] ship,option,upgrade;
    static Round1ShipSkins current;
    public static Round1ShipSkins Current=>current?current:(current=Resources.Load<Round1ShipSkins>("Truxton/ShipSkins"));
}
