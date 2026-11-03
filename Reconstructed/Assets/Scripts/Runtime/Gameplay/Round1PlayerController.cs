using UnityEngine;

// The ship moves on a plane in front of the scrolling stage camera.
// Viewport coordinates keep movement and bounds stable through camera turns.
[DefaultExecutionOrder(100)]
public class Round1PlayerController : MonoBehaviour
{
    public Camera stageCamera;
    public Round1Playback playback;
    public Transform bankingRoot;
    public Transform steeringRoot;
    public TextAsset motionProfile;
    public Vector2 spawnPosition=new Vector2(0.5f,0.22f);
    public Vector2 viewportPosition=new Vector2(0.5f,0.22f);
    public float cameraDistance=100;
    public float movementSpeed=0.65f;
    public float SpeedMultiplier { get; set; }=1;
    public bool InputEnabled { get; set; }=true;
    public float screenMargin=0.12f;
    public AnimationClip spawnAnimation,respawnAnimation;
    public bool cinematicEntrance=true;
    public GameObject entranceBurnerPrefab,entranceBoostPrefab;
    public bool SpawnAnimating { get; private set; }
    public float SpawnAge { get; private set; }
    AnimationClip activeSpawn;
    Vector3 neutralPosition;
    Quaternion neutralRotation;
    bool capturedPose;
    GameObject entranceBurner,entranceBoost;
    ParticleSystem[] entranceParticles=System.Array.Empty<ParticleSystem>();
    float effectAge;
    [System.Serializable] class MotionProfile { public float yawMilliseconds=500,yawLimit=45;public float[] speedFactors={1,.76f,.625f,.5f,.4f,.3f}; }
    MotionProfile profile;
    float bank,previousX,yawStart,yawTarget,yawDuration,yawAge;
    public float SteeringAngle => -bank;
    public bool LastMoveWasRight { get; private set; }
    readonly Vector3[] frustum=new Vector3[4];

    void Start() { ResetPosition(); }
    void LateUpdate()
    {
        if(!stageCamera)return;
        var pilot=playback && playback.weapon?playback.weapon.autopilot:null;
        if(pilot && pilot.enabled && pilot.automatic)
        {
            pilot.Decide(Time.deltaTime);
            Move(pilot.Direction,Time.deltaTime);
            return;
        }
        if(InputEnabled && Input.GetKeyDown(KeyCode.R))ResetPosition();
        var direction=new Vector2(
            (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow)?1:0)-(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow)?1:0),
            (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow)?1:0)-(Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow)?1:0));
        Move(direction,Time.deltaTime,Input.GetKey(KeyCode.LeftShift)||Input.GetKey(KeyCode.RightShift));
    }
    public void Move(Vector2 direction,float deltaTime,bool precision=false)
    {
        if(!stageCamera)return;
        bool paused=!InputEnabled || (playback && !playback.playing);
        if(paused){Place();return;}
        direction=Vector2.ClampMagnitude(direction,1);
        if(Mathf.Abs(direction.x)>.00001f)LastMoveWasRight=direction.x>0;
        float travel=movementSpeed*SpeedMultiplier*(precision?0.4f:1)*Mathf.Max(0,deltaTime);
        viewportPosition+=new Vector2(direction.x/Mathf.Max(stageCamera.aspect,0.1f),direction.y)*travel;
        viewportPosition.x=Mathf.Clamp(viewportPosition.x,screenMargin,1-screenMargin);
        viewportPosition.y=Mathf.Clamp(viewportPosition.y,screenMargin,1-screenMargin);
        StepSteering(direction.x,deltaTime);
        Place();
    }
    public void ResetPosition() { viewportPosition=spawnPosition;bank=previousX=yawStart=yawTarget=yawDuration=yawAge=0;Place(); }
    public void ResetRunMotion(){LastMoveWasRight=false;ResetPosition();}
    static float SourceSin(float degrees)
    {
        // VectorUtility.Sinf uses a 3600-entry table, truncating to tenths of a degree.
        int index=((int)(degrees*10)%3600+3600)%3600;return Mathf.Sin(index*.1f*Mathf.Deg2Rad);
    }
    void StepSteering(float inputX,float dt)
    {
        if(profile==null)profile=motionProfile?JsonUtility.FromJson<MotionProfile>(motionProfile.text):new MotionProfile();
        if(inputX!=previousX)
        {
            yawStart=bank;yawAge=0;yawTarget=inputX==0?0:SourceSin(inputX*Mathf.Rad2Deg)*profile.yawLimit;
            int speedIndex=playback && playback.weapon?playback.weapon.SpeedLevel-1:0;
            float factor=profile.speedFactors[Mathf.Clamp(speedIndex,0,profile.speedFactors.Length-1)];
            yawDuration=profile.yawMilliseconds*.001f*factor*Mathf.Abs(yawTarget-yawStart)/(2*profile.yawLimit);
            previousX=inputX;
        }
        yawAge=Mathf.Min(yawDuration,yawAge+Mathf.Max(0,dt));
        bank=yawDuration>0?Mathf.LerpUnclamped(yawStart,yawTarget,SourceSin(Mathf.Clamp01(yawAge/yawDuration)*90)):yawTarget;
    }
    public void BeginSpawn(bool respawn=false)
    {
        CancelSpawn();ResetPosition();
        // Native PlayerEntryAsync selects start1 when IsRightMove (0x200) is set,
        // otherwise start2. Death alone does not select the spin direction.
        activeSpawn=respawn && LastMoveWasRight?spawnAnimation:respawnAnimation;
        if(!activeSpawn)activeSpawn=spawnAnimation;
        if(!activeSpawn || !bankingRoot)return;
        neutralPosition=bankingRoot.localPosition;neutralRotation=bankingRoot.localRotation;capturedPose=true;
        SpawnAge=0;SpawnAnimating=true;InputEnabled=false;
        bankingRoot.gameObject.SetActive(true);Round1AnimationSampling.Sample(activeSpawn,bankingRoot.gameObject,0);
        EnsureEntranceEffects();effectAge=0;
        foreach(var ps in entranceParticles)ps.Stop(false,ParticleSystemStopBehavior.StopEmittingAndClear);
        Place();UpdateEntranceEffects();
    }
    public void StepSpawn(float deltaTime)
    {
        if(!SpawnAnimating || (playback && !playback.playing))return;
        SpawnAge=Mathf.Min(activeSpawn.length,SpawnAge+Mathf.Max(0,deltaTime));
        Round1AnimationSampling.Sample(activeSpawn,bankingRoot.gameObject,SpawnAge);
        if(SpawnAge>=activeSpawn.length)CancelSpawn();else {Place();UpdateEntranceEffects();}
    }
    public void CancelSpawn()
    {
        if(capturedPose && bankingRoot){bankingRoot.localPosition=neutralPosition;bankingRoot.localRotation=neutralRotation;}
        if(SpawnAnimating)InputEnabled=true;
        SpawnAnimating=false;capturedPose=false;activeSpawn=null;
        if(entranceBurner)entranceBurner.SetActive(false);if(entranceBoost)entranceBoost.SetActive(false);
        Place();
    }
    public void Place()
    {
        if(!stageCamera)return;
        transform.position=WorldPoint(viewportPosition);
        transform.rotation=stageCamera.transform.rotation*Quaternion.Euler(-90,0,0);
        if(SpawnAnimating && cinematicEntrance && activeSpawn)
        {
            // A fixed coordinate conversion, driven only by the original cubic translation.
            // No extra timeline/waypoints: source Y recedes in depth, source Z supplies the overshoot.
            Vector3 source=bankingRoot.localPosition-neutralPosition;
            float depth=cameraDistance*Mathf.Clamp(1-source.y/400f,.05f,2);
            var screen=spawnPosition+new Vector2(source.x/(35.2654f*stageCamera.aspect),source.z/35.2654f);
            Vector3 center=WorldPoint(screen,depth);
            transform.position+=center-bankingRoot.position;
        }
        if(bankingRoot && !SpawnAnimating)bankingRoot.localRotation=Quaternion.identity;
        if(!steeringRoot && bankingRoot)steeringRoot=bankingRoot.Find("pf_player01");
        if(steeringRoot)steeringRoot.localRotation=Quaternion.AngleAxis(-bank,Vector3.forward);
    }
    void EnsureEntranceEffects()
    {
        if(!cinematicEntrance)return;
        if(!entranceBurner && entranceBurnerPrefab)entranceBurner=CreateEffect(entranceBurnerPrefab,"Entrance engine flame");
        if(!entranceBoost && entranceBoostPrefab)entranceBoost=CreateEffect(entranceBoostPrefab,"Entrance ignition");
        var particles=new System.Collections.Generic.List<ParticleSystem>();
        if(entranceBurner)particles.AddRange(entranceBurner.GetComponentsInChildren<ParticleSystem>(true));
        if(entranceBoost)particles.AddRange(entranceBoost.GetComponentsInChildren<ParticleSystem>(true));
        entranceParticles=particles.ToArray();
    }
    GameObject CreateEffect(GameObject prefab,string label)
    {
        var effect=Instantiate(prefab,steeringRoot?steeringRoot:bankingRoot);effect.name=label;effect.hideFlags=HideFlags.DontSave;
        effect.transform.localPosition=new Vector3(0,0,-7.5f);effect.transform.localRotation=Quaternion.identity;
        foreach(var ps in effect.GetComponentsInChildren<ParticleSystem>(true))
        {
            ps.Stop(false,ParticleSystemStopBehavior.StopEmittingAndClear);ps.useAutoRandomSeed=false;ps.randomSeed=71;
            var main=ps.main;main.playOnAwake=false;main.cullingMode=ParticleSystemCullingMode.AlwaysSimulate;
        }
        return effect;
    }
    void UpdateEntranceEffects()
    {
        if(entranceBurner)entranceBurner.SetActive(SpawnAnimating);
        if(entranceBoost)entranceBoost.SetActive(SpawnAnimating);
        float next=SpawnAge+.05f,dt=Mathf.Max(0,next-effectAge);effectAge=next;
        // Advance once, without restarting their history or quantizing to the physics timestep.
        foreach(var ps in entranceParticles)ps.Simulate(dt,false,false,false);
    }
    // Stage-clear departure (Round1StageEnd): the entrance's engine flame and ignition, running in real time.
    public void SetBoost(bool on)
    {
        if(on)EnsureEntranceEffects();
        foreach(var effect in new[]{entranceBurner,entranceBoost})
        {
            if(!effect)continue;effect.SetActive(on);
            if(on)foreach(var ps in effect.GetComponentsInChildren<ParticleSystem>(true)){ps.Clear(true);ps.Play(true);}
        }
    }
    void OnDestroy(){if(entranceBurner)Destroy(entranceBurner);if(entranceBoost)Destroy(entranceBoost);}
    public Vector3 WorldPoint(Vector2 position,float planeDistance=-1)
    {
        // Build the plane in camera-local space. Inverting a world projection at
        // the route's ~9,000-unit coordinates introduces visible rounding drift.
        stageCamera.CalculateFrustumCorners(new Rect(0,0,1,1),planeDistance>0?planeDistance:cameraDistance,Camera.MonoOrStereoscopicEye.Mono,frustum);
        var bottom=Vector3.LerpUnclamped(frustum[0],frustum[3],position.x);
        var top=Vector3.LerpUnclamped(frustum[1],frustum[2],position.x);
        return stageCamera.transform.TransformPoint(Vector3.LerpUnclamped(bottom,top,position.y));
    }
}
