using System;
using System.Collections.Generic;
using UnityEngine;

public partial class Round1Weapon
{
    public int EnemyDropsSpawned { get; private set; }
    public int GroundDropsSpawned { get; private set; }
    public event Action<Round1Powerup,Vector3> GroundItemDropped;
    // ItemReferenceTable._tableList, drawn by InGameManager.TableItemDrop (RVA 0x1cec6e0) for item 1000. Carriers without
    // an explicit _drops list and ground item boxes (_ruinName "ItemOfIndex") advance the same index.
    static readonly Round1PickupKind[] ItemTable=
    {
        Round1PickupKind.Power,Round1PickupKind.SpeedUp,Round1PickupKind.Power,Round1PickupKind.Power,Round1PickupKind.SpeedUp,Round1PickupKind.Power,
        Round1PickupKind.Power,Round1PickupKind.SpeedUp,Round1PickupKind.Power,Round1PickupKind.Power,Round1PickupKind.SpeedUp,Round1PickupKind.Power,
        Round1PickupKind.Power,Round1PickupKind.SpeedUp,Round1PickupKind.Power,Round1PickupKind.BombStock
    };
    public const int TableItem=1000;
    int itemTableIndex;
    // InGameManager+0x200: ground 1UP/2UP drops already given, keyed by the box's start position (GetGroundItemName).
    readonly HashSet<Vector3Int> groundExtendsGiven=new HashSet<Vector3Int>();

    public void ResetEnemyDrops(float time)
    {
        EnemyDropsSpawned=GroundDropsSpawned=0;itemTableIndex=0;groundExtendsGiven.Clear();
        foreach(var pickup in powerups??Array.Empty<Round1Powerup>())if(pickup)pickup.ResetPickup();
    }
    // Player-dependent extend substitution (NumExtends -> OneUp) is not reconstructed.
    public Round1PickupKind NextTableItem(){var kind=ItemTable[itemTableIndex];itemTableIndex=(itemTableIndex+1)%ItemTable.Length;return kind;}

    public void OnEnemyDestroyed(Round1Combat.Target target)
    {
        if(target==null || target.active || target.health>0 || !target.isPickupDrone || !SimulationRunning)return;
        if(target.position.x<0 || target.position.x>1 || target.position.y<0 || target.position.y>1)return;
        if(SpawnDroppedPickup(target.pickupKind,target.position,player.playback.elapsed))EnemyDropsSpawned++;
    }

    // PawnEnemyGround.DropItem (0x1d17690) and the colour box overrides: one ground item at the box, per its source item id.
    public void DropGroundItem(int item,int swapItem,Vector3 start,Vector3 world,float time)
    {
        if(item==0 || !SimulationRunning)return;
        var key=Vector3Int.RoundToInt(start);bool given=groundExtendsGiven.Contains(key);
        if(item==1 && swapItem!=0 && given)item=swapItem;      // Ene_ColorBox.DropItem: IsAlreadyExist -> _SwapDrop
        else if((item==1 || item==9) && given)item=7;           // GetGroundItemName: a repeated extend becomes a bomb stock
        if(item==1 || item==9)groundExtendsGiven.Add(key);
        var kind=item==TableItem?NextTableItem():SourceItemKind(item);
        if(kind==null)return;
        var pickup=SpawnDroppedPickup(kind.Value,player.stageCamera.WorldToViewportPoint(world),time);
        var ground=combat.groundEnemies;
        if(pickup){pickup.SpawnOnGround(world,time,ground?ground.ItemPrefab(kind.Value):null,ground?ground.Root:null);GroundDropsSpawned++;GroundItemDropped?.Invoke(pickup,world);}
    }
    // ItemEffects..cctor (0x1d70400) item ids. ConvertDropKind's Gold/Black substitutions don't arise for BG03's ground items.
    public static Round1PickupKind? SourceItemKind(int item)=>item switch
    {
        1=>Round1PickupKind.OneUp,2=>Round1PickupKind.Power,4=>Round1PickupKind.SpeedUp,7=>Round1PickupKind.BombStock,8=>Round1PickupKind.Bonus,
        9=>Round1PickupKind.TwoUp,10=>Round1PickupKind.ThreeUp,100=>Round1PickupKind.Red,101=>Round1PickupKind.Green,102=>Round1PickupKind.Blue,
        103=>Round1PickupKind.Purple,104=>Round1PickupKind.Silver,105=>Round1PickupKind.Gold,106=>Round1PickupKind.Black,_=>null
    };

    public Round1Powerup SpawnDroppedPickup(Round1PickupKind kind,Vector2 position,float time)
    {
        Round1Powerup template=null,pickup=null;
        foreach(var candidate in powerups??Array.Empty<Round1Powerup>())
        {
            if(!candidate || candidate.kind!=kind)continue;
            template=candidate;candidate.Evaluate(time);
            if(!candidate.Available){pickup=candidate;break;}
        }
        if(!template)return null;
        if(!pickup)
        {
            pickup=Instantiate(template,template.transform.parent);
            Array.Resize(ref powerups,powerups.Length+1);powerups[powerups.Length-1]=pickup;
        }
        pickup.player=player;pickup.gameObject.SetActive(true);pickup.SpawnAt(position,time);return pickup;
    }
}
