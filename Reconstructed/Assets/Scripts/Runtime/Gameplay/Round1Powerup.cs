using UnityEngine;

public enum Round1PickupKind
{
    Power, Bomber, Change, OneUp, TwoUp, ThreeUp, Bonus, BombStock,
    SpeedDown, SpeedUp, Black, Blue, Gold, Green, Purple, Red, Silver, Points1, Points2
}

public class Round1Powerup : MonoBehaviour
{
    public Round1PickupKind kind;
    public string label="POWER";
    public bool showcase;
    public Round1PlayerController player;
    public GameObject visual;
    public Vector2 spawnPosition=new Vector2(0.5f,0.85f);
    public float appearAt;
    public float fallSpeed=0.065f;   // unused: floating items follow DropDistance / DropSpeed below
    public float fallDelay;
    float respawnOffset;
    bool spawned;
    public bool Collected { get; private set; }
    public bool Available { get; private set; }
    public Vector2 Position { get; private set; }
    // Pickup history for the play checks: drops, pickups with their effect, and items that left uncollected.
    public static readonly System.Collections.Generic.List<string> History=new System.Collections.Generic.List<string>();
    bool wasAvailable;

    public void Evaluate(float stageTime)
    {
        float age=stageTime-appearAt-respawnOffset;
        Position=PositionAt(stageTime);
        Available=spawned && !Collected && age>=0 && !Expired(stageTime,age);
        if(wasAvailable && !Available && !Collected)History.Add("miss "+kind+(Grounded?"(g)":"")+"@"+stageTime.ToString("0.0")+" vp "+Position.ToString("0.00"));
        wasAvailable=Available;
        if(visual)visual.SetActive(Available && !groundVisual);
        if(groundVisual)groundVisual.SetActive(Available);
        if(player)
        {
            transform.position=player.WorldPoint(Position);
            transform.rotation=player.stageCamera.transform.rotation*Quaternion.Euler(-90,0,Mathf.Sin(age*2)*12);
        }
    }
    public bool Collect(Round1Weapon weapon)
    {
        if(!Available || Collected || !weapon || !weapon.CanAct)return false;
        // ItemEnemy.IsHitEnable 0x1D70D30: a floating item can't be taken during its first 0.1 s.
        if(!Grounded && lastAge<BornTime)return false;
        Collected=true;Available=false;if(visual)visual.SetActive(false);if(groundVisual)groundVisual.SetActive(false);
        History.Add("get "+kind+(Grounded?"(g)":"")+"@"+(player?player.playback.elapsed:0).ToString("0.0"));
        weapon.ApplyPickup(kind,Grounded,Position);return true;
    }
    // A ground item (InGameRuinManager.EmitterFrom3D) stays where its box broke and scrolls away with the ground.
    public bool Grounded { get; private set; }
    Vector3 groundPoint;
    // The original ground model (Pf_item_*), drawn on the ground in place of the floating pickup.
    GameObject groundVisual;
    // Pickup reach in viewport heights (200-unit frame, as the carriers): the item's own circle (layer enemyBullet, self
    // Item, subject OnlyBody) plus the ship's 0.8-unit body. Live original radii (recordings/ash-r1-colliders-20261029-shots):
    // 16.3 for a floating ItemEnemy, 10.3 for a Pf_item_* lying on the ground.
    public float Reach=>((groundVisual?10.3f:16.3f)+.8f)/200;
    // InGameManager.ItemDrop 0x1CE82E0: route itemCarryDrop00, a straight 200 units down-screen, at _dropItemSpeed 8 with
    // EaseOut (Easing01 type 2), in the 200-unit frame the carriers use.
    const float DropDistance=200,DropSpeed=8,DropDuration=DropDistance/DropSpeed,BornTime=.1f,OutsideLife=2,PlayMargin=.15f;
    public Vector2 PositionAt(float time)
    {
        if(Grounded && player)return player.stageCamera.WorldToViewportPoint(groundPoint);
        float u=Mathf.Clamp01(Mathf.Max(0,time-appearAt-respawnOffset-fallDelay)/DropDuration);
        return spawnPosition+Vector2.down*(1-(1-u)*(1-u))*DropDistance/200;
    }
    float outsideSince=-1,lastAge;
    // ItemEnemy.LocalLateUpdate 0x1D70D50: removed after more than 2 s outside the play area, or at the route's end.
    // ItemCollision.LocalLateUpdate 0x1D6F670: a ground item goes when it is behind the camera or below viewport y -3.
    // [I] play area = the viewport with the 0.15 margin used for enemies.
    bool Expired(float time,float age)
    {
        lastAge=age;
        if(Grounded)return player && player.stageCamera.WorldToViewportPoint(groundPoint).z<=0 || Position.y<-3;
        if(age>=DropDuration)return true;
        bool inside=Position.x>=-PlayMargin && Position.x<=1+PlayMargin && Position.y>=-PlayMargin && Position.y<=1+PlayMargin;
        if(inside || outsideSince>time){outsideSince=-1;return false;}
        if(outsideSince<0)outsideSince=time;
        return time-outsideSince>OutsideLife;
    }
    public bool HasSpawned(float time) => spawned && time>=appearAt+respawnOffset;
    public void SpawnAt(Vector2 position,float time)
    {
        ResetPickup();spawned=true;spawnPosition=position;appearAt=time;
        showcase=false;fallDelay=0;fallSpeed=.065f;Evaluate(time);
    }
    public void SpawnOnGround(Vector3 world,float time,GameObject groundPrefab=null,Transform groundRoot=null)
    {
        SpawnAt(spawnPosition,time);Grounded=true;groundPoint=world;
        if(groundPrefab){groundVisual=Instantiate(groundPrefab,groundRoot);groundVisual.transform.SetPositionAndRotation(world,Quaternion.identity);
            foreach(var c in groundVisual.GetComponentsInChildren<Collider>(true))c.enabled=false;}
        Evaluate(time);
    }
    public void Respawn(float time) { SpawnAt(spawnPosition,time); }
    public void ResetPickup()
    {
        spawned=false;Collected=false;Available=false;wasAvailable=false;Grounded=false;respawnOffset=0;outsideSince=-1;lastAge=0;if(visual)visual.SetActive(false);
        if(groundVisual){if(Application.isPlaying)Destroy(groundVisual);else DestroyImmediate(groundVisual);groundVisual=null;}
    }
    void Awake(){ResetPickup();}
    void OnGUI()
    {
        if(!Round1Hud.ShowPickupLabels)return;
        if(!Available || !player || !player.stageCamera)return;
        var screen=player.stageCamera.WorldToScreenPoint(transform.position);
        if(screen.z<=0)return;
        GUI.Box(new Rect(screen.x-46,Screen.height-screen.y+15,92,20),label);
    }
}
