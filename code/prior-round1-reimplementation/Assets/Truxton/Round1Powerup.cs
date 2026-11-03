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
    public float fallSpeed=0.065f;
    public float fallDelay;
    float respawnOffset;
    bool spawned;
    public bool Collected { get; private set; }
    public bool Available { get; private set; }
    public Vector2 Position { get; private set; }

    public void Evaluate(float stageTime)
    {
        float age=stageTime-appearAt-respawnOffset;
        Position=PositionAt(stageTime);
        Available=spawned && !Collected && age>=0 && Position.y>=-0.1f;
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
        Collected=true;Available=false;if(visual)visual.SetActive(false);if(groundVisual)groundVisual.SetActive(false);
        weapon.ApplyPickup(kind);return true;
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
    public Vector2 PositionAt(float time) => Grounded && player?(Vector2)player.stageCamera.WorldToViewportPoint(groundPoint):spawnPosition+Vector2.down*Mathf.Max(0,time-appearAt-respawnOffset-fallDelay)*fallSpeed;
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
        spawned=false;Collected=false;Available=false;Grounded=false;respawnOffset=0;if(visual)visual.SetActive(false);
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
