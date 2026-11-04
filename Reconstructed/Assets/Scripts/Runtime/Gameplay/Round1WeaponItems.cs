using UnityEngine;

// The original item rules (evidence/items/SPEC.md): ItemEffects.ItemEffectResult 0x1D6FF10 and the PlayerControll /
// PlayerInformation / PlayerCommonData state it changes. The remaster's Level (1..4) and SpeedLevel (1..6) are the
// original _armLevel (0..3) and _speedLevel (0..5) plus one.
public partial class Round1Weapon
{
    // GameSetting..ctor 0x26D4350: lifes 3, bombs 3, autoBomb 0. BomberCountMax 10, stock 99 (here Lives counts the ship
    // in play as well, so 100).
    public const int StartBombs=3,BombsMax=10,LivesMax=100,SpeedCapacityMax=5;
    // WeaponBaseShot.PowerLevel 0x1D578A0 = min(_powerLevel, 3): every fire path uses the original level 3 at most, so
    // the awakened levels shoot like level 4 here; they change only the awaken body (ship parts, bomb, bonus cap).
    public const int ShotLevelMax=4;
    public int ShotLevel=>Mathf.Clamp(Level,1,ShotLevelMax);
    // GetArmLevelMax 0x26DE660 = 3 + awakenLv (Round1Weapon.awakenUnlock).
    public int LevelMax=>ShotLevelMax+Mathf.Clamp(awakenUnlock,0,2);
    // PlayerControll.IsAutoBomb (GameSetting.autoBomb).
    public bool autoBomb;
    // _armSubLevel: power items toward the next level (0..2); 3 at the top level is "full".
    public int PowerItems { get; private set; }
    // _speedCapacity 0..5: the highest speed level the player may select; raised by speed items.
    public int SpeedCapacity { get; private set; }
    // PlayerCommonData._numBonusMul: the "5000" bonus multiplier, 1.._numBonusMax, 0 after a death.
    public int BonusMultiplier { get; private set; }
    // _numBonusMax = 10 + min(2, awaken body) (SetNumBonusMax 0x26DDB50).
    public int BonusMax => 10+AwakenBody;
    // PlayerCommonData._numExtends: score extends not yet paid out (TableItemDrop turns the next table drop into a 1UP).
    public int PendingExtends { get; private set; }
    bool speedReverse;

    public void ApplySpeed(){if(player)player.SpeedMultiplier=rules!=null?rules.speeds[Mathf.Clamp(SpeedLevel-1,0,rules.speeds.Length-1)]:1+(SpeedLevel-1)*.4f;}

    // ItemEnemy.OnHitProgress 0x1D70DF0 / ItemCollision.OnHitProgress 0x1D6F7C0: apply the item; an item that changes
    // nothing becomes the "5000" bonus. ground: a Pf_item_* lying on the ground (ItemCollision).
    public void ApplyPickup(Round1PickupKind kind,bool ground=false,Vector2? at=null)
    {
        bool effect;
        switch(kind)
        {
            case Round1PickupKind.Power:effect=PowerUpWeapon()!=0;break;
            case Round1PickupKind.SpeedUp:effect=AddSpeedCapacity(1);break;
            case Round1PickupKind.BombStock:
                effect=Bombs<BombsMax;   // BomberStockCountUp(1): the item's value is ignored
                if(effect){Bombs++;AddRank(RankBombStock);Round1Sound.Event("itemBomb");Tell("BOMB +1");}
                break;
            // StockCountUp(value). Ground 1UP/2UP are kind 1 (value 1/2) and sound 0xE4; floating 2UP/3UP are kinds 9/10.
            case Round1PickupKind.OneUp:effect=StockUp(1,"extend1");break;
            case Round1PickupKind.TwoUp:effect=StockUp(2,ground?"extend1":"extend2");break;
            case Round1PickupKind.ThreeUp:effect=StockUp(3,"extend3");break;
            // Kind 8 ScoreUp: AddScore(_itemValue 5000), and the item still counts as having no effect.
            case Round1PickupKind.Bonus:AddScore(5000);effect=!ground;break;
            case Round1PickupKind.Red:case Round1PickupKind.Green:case Round1PickupKind.Blue:case Round1PickupKind.Purple:
            case Round1PickupKind.Silver:case Round1PickupKind.Gold:case Round1PickupKind.Black:
                effect=System.Enum.TryParse(kind.ToString(),out Round1Arms arms) && SelectWeapon(arms);break;
            // Bomber / Change / SpeedDown / Points1 / Points2 are not original effects (kinds 3 and 6 exist only in unused
            // prefabs and do nothing); nothing drops them.
            default:effect=false;break;
        }
        if(!effect)Get5000(at);
        if(Round1Powerup.History.Count>0)Round1Powerup.History[Round1Powerup.History.Count-1]+=effect?" -> L"+Level+"."+PowerItems+" S"+SpeedCapacity+" B"+Bombs+" x"+Lives:" -> 5000x"+BonusMultiplier;
    }
    // PlayerControll.PowerUpWeapon 0x1D4AAC0 / PlayerInformation.ArmLevelUp 0x26DE420: three items per level; at the top
    // level three more fill it ("full"), after which an item has no effect. 0 = no effect, 1 = a step, 2 = a level up.
    public int PowerUpWeapon()
    {
        int before=PowerItems,items=PowerItems+1;
        if(items>2)
        {
            if(Level<LevelMax){Level++;PowerItems=0;Round1Sound.Event("powerUp");Tell(Level>ShotLevelMax?"EVOLUTION":"POWER UP");ApplyShipUpgrades();AddRank(RankPowerUp);return 2;}
            items=3;
        }
        PowerItems=items;if(PowerItems==before)return 0;
        Round1Sound.Event("powerFull");Tell(Level>=LevelMax && PowerItems>=3?"POWER FULL":"POWER "+Level+" - "+PowerItems+"/3");return 1;
    }
    // PlayerControll.AddSpeedCapacity 0x1D48820: capacity +1 (max 5); if it grew, the speed goes up one level too.
    bool AddSpeedCapacity(int value)
    {
        int capacity=Mathf.Clamp(SpeedCapacity+value,0,SpeedCapacityMax);if(capacity==SpeedCapacity)return false;
        SpeedCapacity=capacity;SpeedLevel=Mathf.Min(SpeedLevel+1,SpeedCapacity+1);ApplySpeed();
        Round1Sound.Event("itemSpeedUp");Tell("SPEED "+SpeedLevel);return true;
    }
    bool StockUp(int value,string sound)
    {
        int lives=Mathf.Clamp(Lives+value,0,LivesMax);if(lives==Lives)return false;
        Lives=lives;Round1Sound.Event(sound);Tell(value+"UP");return true;
    }
    // PlayerControll._playerControllSpeedChange 0x1D4C760, the single speed-change button: steps one level and turns back
    // at either end, between level 0 and the capacity. Inactive while the capacity is 0.
    public bool ChangeSpeed()
    {
        if(!CanAct || SpeedCapacity<=0)return false;
        int level=SpeedLevel-1,step=speedReverse?-1:1;
        if(level+step<0 || level+step>SpeedCapacity){speedReverse=!speedReverse;step=-step;}
        return SetSpeed(level+step);
    }
    // The separate speed-up / speed-down buttons of _playerControllSpeedChange: one level, no wrap, inactive while the
    // capacity is 0.
    public bool SpeedUp()=>CanAct && SpeedCapacity>0 && SetSpeed(SpeedLevel);
    public bool SpeedDown()=>CanAct && SpeedCapacity>0 && SetSpeed(SpeedLevel-2);
    // ChangeSpeed(delta): speed up sound 0x20, speed down 0x0D.
    public bool SetSpeed(int level)
    {
        level=Mathf.Clamp(level,0,SpeedCapacity);if(level==SpeedLevel-1)return false;
        Round1Sound.Event(level>SpeedLevel-1?"speedUp":"speedDown");SpeedLevel=level+1;ApplySpeed();Tell("SPEED "+SpeedLevel);return true;
    }
    // PlayerControll.ChangeWeaponByIndex 0x1D48A00: the current weapon's colour changes nothing; another keeps the power.
    public bool SelectWeapon(Round1Arms arms)
    {
        if(Arms==arms)return false;
        Arms=arms;Round1Sound.Event("weaponChange");cooldown=0;shotRemainder=0;HideBeams();Tell(PatternName);ApplyShipUpgrades();return true;
    }
    // InGameManager.Get5000 0x1CE3F10: 5000 x the multiplier, which rises by one each time up to BonusMax.
    // The popup (effect Score5000, index = multiplier) shows at the source's screen point; at = viewport position.
    public void Get5000(Vector2? at=null)
    {
        BonusMultiplier=Mathf.Clamp(BonusMultiplier+1,1,BonusMax);int value=5000*BonusMultiplier;
        AddScore(value);Round1Sound.Event("score5000");
        Bonus5000Count++;LastBonusAt=at??(player?player.viewportPosition:new Vector2(.5f,.5f));
        Round1ScorePopups.Show(this,LastBonusAt,BonusMultiplier);
    }
    public int Bonus5000Count { get; private set; }
    public Vector2 LastBonusAt { get; private set; }
    // PlayerCommonData.AddScore 0x26DCE00: a score extend is only counted here; the next item-table drop pays it.
    public void GrantExtend(){PendingExtends=Mathf.Min(99,PendingExtends+1);}
    // _outPlayer 0x1CF1940: PlayerInformation.ClearByDead 0x26DE500 then PlayerCommonData.ClearByDead 0x26DD080. Called
    // after Lives has dropped by one.
    void ClearByDead()
    {
        SpeedCapacity=Mathf.Max(0,SpeedCapacity-1);SpeedLevel=Mathf.Min(SpeedLevel,SpeedCapacity+1);ApplySpeed();
        if(PowerItems>=3)PowerItems=0;else Level=Mathf.Max(1,Level-1);   // a full top level only loses "full"
        if(Lives>0)Bombs=Mathf.Max(Bombs,StartBombs);                      // stock left: bombs topped up to the start count
        itemTableIndex=0;BonusMultiplier=0;
        ApplyShipUpgrades();
    }
}
