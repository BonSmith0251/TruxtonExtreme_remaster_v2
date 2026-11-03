namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Cinemachine Brain")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineBrain.html")]
[Token(Token = "0x2000008")]
public class CinemachineBrain : MonoBehaviour, ICameraOverrideStack, ICinemachineMixer, ICinemachineCamera
{
	[CompilerGenerated]
	[Token(Token = "0x200000C")]
	private sealed class <AfterPhysics>d__30 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000024")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000025")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000026")]
		public CinemachineBrain <>4__this; //Field offset: 0x20

		[Token(Token = "0x1700000D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600003A")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700000E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600003C")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000037")]
		public <AfterPhysics>d__30(int <>1__state) { }

		[Address(RVA = "0x2818320", Offset = "0x2817720", Length = "0x1AC")]
		[Token(Token = "0x6000039")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600003A")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600003C")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x28184D0", Offset = "0x28178D0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600003B")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000038")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x200000A")]
	internal enum BrainUpdateMethods : int
	{
		FixedUpdate = 0,
		LateUpdate = 1,
	}

	[Token(Token = "0x200000B")]
	internal struct LensModeOverrideSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000022")]
		[Tooltip("If set, enables CinemachineCameras to override the lens mode of the camera")]
		public bool Enabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000023")]
		[Tooltip("Lens mode to use when no mode override is active")]
		public OverrideModes DefaultMode; //Field offset: 0x4

	}

	[Token(Token = "0x2000009")]
	internal enum UpdateMethods : int
	{
		FixedUpdate = 0,
		LateUpdate = 1,
		SmartUpdate = 2,
		ManualUpdate = 3,
	}

	[Token(Token = "0x4000018")]
	private static readonly List<CinemachineBrain> s_ActiveBrains; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_ShowDebugText")]
	[Token(Token = "0x4000008")]
	[Tooltip("When enabled, the current camera and blend are indicated in the game window, for debugging")]
	public bool ShowDebugText; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[FormerlySerializedAs("m_ShowCameraFrustum")]
	[Token(Token = "0x4000009")]
	[Tooltip("When enabled, shows the camera's frustum at all times in the Scene view")]
	public bool ShowCameraFrustum; //Field offset: 0x21
	[FieldOffset(Offset = "0x22")]
	[FormerlySerializedAs("m_IgnoreTimeScale")]
	[Token(Token = "0x400000A")]
	[Tooltip("When enabled, the cameras always respond in real-time to user input and damping, even if the game is running in slow motion")]
	public bool IgnoreTimeScale; //Field offset: 0x22
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_WorldUpOverride")]
	[Token(Token = "0x400000B")]
	[Tooltip("If set, this GameObject's Y axis defines the world-space Up vector for all the CinemachineCameras.  This is useful for instance in top-down game environments.  If not set, Up is world-space Y.  Setting this appropriately is important, because CinemachineCameras don't like looking straight up or straight down.")]
	public Transform WorldUpOverride; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000C")]
	[Tooltip("The CinemachineBrain finds the highest-priority CinemachineCamera that outputs to any of the channels selected.  CinemachineCameras that do not output to one of these channels are ignored.  Use this in situations where multiple CinemachineBrains are needed (for example, Split-screen).")]
	public OutputChannels ChannelMask; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[FormerlySerializedAs("m_UpdateMethod")]
	[Token(Token = "0x400000D")]
	[Tooltip("The update time for the CinemachineCameras.  Use FixedUpdate if all your targets are animated during FixedUpdate (e.g. RigidBodies), LateUpdate if all your targets are animated during the normal Update loop, and SmartUpdate if you want Cinemachine to do the appropriate thing on a per-target basis.  SmartUpdate is the recommended setting")]
	public UpdateMethods UpdateMethod; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_BlendUpdateMethod")]
	[Token(Token = "0x400000E")]
	[Tooltip("The update time for the Brain, i.e. when the blends are evaluated and the brain's transform is updated")]
	public BrainUpdateMethods BlendUpdateMethod; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x400000F")]
	public LensModeOverrideSettings LensModeOverride; //Field offset: 0x3C
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("m_DefaultBlend")]
	[Token(Token = "0x4000010")]
	[Tooltip("The blend that is used in cases where you haven't explicitly defined a blend between two CinemachineCameras")]
	public CinemachineBlendDefinition DefaultBlend; //Field offset: 0x48
	[EmbeddedBlenderSettingsProperty]
	[FieldOffset(Offset = "0x58")]
	[FormerlySerializedAs("m_CustomBlends")]
	[Token(Token = "0x4000011")]
	[Tooltip("This is the asset that contains custom settings for blends between specific CinemachineCameras in your Scene")]
	public CinemachineBlenderSettings CustomBlends; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000012")]
	private Camera m_OutputCamera; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000013")]
	private GameObject m_TargetOverride; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000014")]
	private int m_LastFrameUpdated; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000015")]
	private Coroutine m_PhysicsCoroutine; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000016")]
	private readonly WaitForFixedUpdate m_WaitForFixedUpdate; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000017")]
	private readonly BlendManager m_BlendManager; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000019")]
	private CameraState m_CameraState; //Field offset: 0x90

	[Token(Token = "0x1700000C")]
	public CinemachineBlend ActiveBlend
	{
		[Address(RVA = "0x28017C0", Offset = "0x2800BC0", Length = "0x20")]
		[Token(Token = "0x6000027")]
		 get { } //Length: 32
		[Address(RVA = "0x2801DC0", Offset = "0x28011C0", Length = "0x21")]
		[Token(Token = "0x6000028")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000007")]
	public static int ActiveBrainCount
	{
		[Address(RVA = "0x28017F0", Offset = "0x2800BF0", Length = "0x67")]
		[Token(Token = "0x600001F")]
		 get { } //Length: 103
	}

	[Token(Token = "0x1700000A")]
	public ICinemachineCamera ActiveVirtualCamera
	{
		[Address(RVA = "0x2801860", Offset = "0x2800C60", Length = "0xA0")]
		[Token(Token = "0x6000024")]
		 get { } //Length: 160
	}

	[Token(Token = "0x17000008")]
	public GameObject ControlledObject
	{
		[Address(RVA = "0x2801910", Offset = "0x2800D10", Length = "0x76")]
		[Token(Token = "0x6000021")]
		 get { } //Length: 118
		[Address(RVA = "0x2801DF0", Offset = "0x28011F0", Length = "0x74")]
		[Token(Token = "0x6000022")]
		 set { } //Length: 116
	}

	[Token(Token = "0x17000001")]
	public override Vector3 DefaultWorldUp
	{
		[Address(RVA = "0x2801990", Offset = "0x2800D90", Length = "0xDA")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 218
	}

	[Token(Token = "0x17000003")]
	public override string Description
	{
		[Address(RVA = "0x2801A70", Offset = "0x2800E70", Length = "0x16F")]
		[Token(Token = "0x6000018")]
		 get { } //Length: 367
	}

	[Token(Token = "0x1700000B")]
	public bool IsBlending
	{
		[Address(RVA = "0x2801BE0", Offset = "0x2800FE0", Length = "0x20")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000005")]
	public override bool IsValid
	{
		[Address(RVA = "0x2801C10", Offset = "0x2801010", Length = "0x4C")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000002")]
	public override string Name
	{
		[Address(RVA = "0x2801C60", Offset = "0x2801060", Length = "0x7")]
		[Token(Token = "0x6000017")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000009")]
	public Camera OutputCamera
	{
		[Address(RVA = "0x2801C70", Offset = "0x2801070", Length = "0xC1")]
		[Token(Token = "0x6000023")]
		 get { } //Length: 193
	}

	[Token(Token = "0x17000006")]
	public override ICinemachineMixer ParentCamera
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600001B")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000004")]
	public override CameraState State
	{
		[Address(RVA = "0x2801D40", Offset = "0x2801140", Length = "0x76")]
		[Token(Token = "0x6000019")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x2801610", Offset = "0x2800A10", Length = "0x84")]
	[Token(Token = "0x6000036")]
	private static CinemachineBrain() { }

	[Address(RVA = "0x28016A0", Offset = "0x2800AA0", Length = "0x111")]
	[Token(Token = "0x6000035")]
	public CinemachineBrain() { }

	[Address(RVA = "0x27FF6A0", Offset = "0x27FEAA0", Length = "0x67")]
	[IteratorStateMachine(typeof(<AfterPhysics>d__30))]
	[Token(Token = "0x6000013")]
	private IEnumerator AfterPhysics() { }

	[Address(RVA = "0x27FF710", Offset = "0x27FEB10", Length = "0x51")]
	[Token(Token = "0x600000C")]
	private void Awake() { }

	[Address(RVA = "0x27FF770", Offset = "0x27FEB70", Length = "0x141")]
	[Token(Token = "0x600002E")]
	private void DoFixedUpdate() { }

	[Address(RVA = "0x27FF8C0", Offset = "0x27FECC0", Length = "0x2F2")]
	[Token(Token = "0x600002D")]
	private void DoNonFixedUpdate(int updateFrame) { }

	[Address(RVA = "0x28017C0", Offset = "0x2800BC0", Length = "0x20")]
	[Token(Token = "0x6000027")]
	public CinemachineBlend get_ActiveBlend() { }

	[Address(RVA = "0x28017F0", Offset = "0x2800BF0", Length = "0x67")]
	[Token(Token = "0x600001F")]
	public static int get_ActiveBrainCount() { }

	[Address(RVA = "0x2801860", Offset = "0x2800C60", Length = "0xA0")]
	[Token(Token = "0x6000024")]
	public ICinemachineCamera get_ActiveVirtualCamera() { }

	[Address(RVA = "0x2801910", Offset = "0x2800D10", Length = "0x76")]
	[Token(Token = "0x6000021")]
	public GameObject get_ControlledObject() { }

	[Address(RVA = "0x2801990", Offset = "0x2800D90", Length = "0xDA")]
	[Token(Token = "0x6000016")]
	public override Vector3 get_DefaultWorldUp() { }

	[Address(RVA = "0x2801A70", Offset = "0x2800E70", Length = "0x16F")]
	[Token(Token = "0x6000018")]
	public override string get_Description() { }

	[Address(RVA = "0x2801BE0", Offset = "0x2800FE0", Length = "0x20")]
	[Token(Token = "0x6000026")]
	public bool get_IsBlending() { }

	[Address(RVA = "0x2801C10", Offset = "0x2801010", Length = "0x4C")]
	[Token(Token = "0x600001A")]
	public override bool get_IsValid() { }

	[Address(RVA = "0x2801C60", Offset = "0x2801060", Length = "0x7")]
	[Token(Token = "0x6000017")]
	public override string get_Name() { }

	[Address(RVA = "0x2801C70", Offset = "0x2801070", Length = "0xC1")]
	[Token(Token = "0x6000023")]
	public Camera get_OutputCamera() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600001B")]
	public override ICinemachineMixer get_ParentCamera() { }

	[Address(RVA = "0x2801D40", Offset = "0x2801140", Length = "0x76")]
	[Token(Token = "0x6000019")]
	public override CameraState get_State() { }

	[Address(RVA = "0x27FFBC0", Offset = "0x27FEFC0", Length = "0x76")]
	[Token(Token = "0x6000020")]
	public static CinemachineBrain GetActiveBrain(int index) { }

	[Address(RVA = "0x27FFC40", Offset = "0x27FF040", Length = "0x173")]
	[Token(Token = "0x600002F")]
	private float GetEffectiveDeltaTime(bool fixedDelta) { }

	[Address(RVA = "0x27FFDC0", Offset = "0x27FF1C0", Length = "0x14F")]
	[Token(Token = "0x600001E")]
	public override bool IsLiveChild(ICinemachineCamera cam, bool dominantChildOnly = false) { }

	[Address(RVA = "0x27FFF10", Offset = "0x27FF310", Length = "0xDA")]
	[Token(Token = "0x600002A")]
	public bool IsLiveInBlend(ICinemachineCamera cam) { }

	[Address(RVA = "0x27FFFF0", Offset = "0x27FF3F0", Length = "0x7B")]
	[Token(Token = "0x6000029")]
	public bool IsValidChannel(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2800070", Offset = "0x27FF470", Length = "0x2E")]
	[Token(Token = "0x6000012")]
	private void LateUpdate() { }

	[Address(RVA = "0x28000A0", Offset = "0x27FF4A0", Length = "0x53")]
	[Token(Token = "0x6000032")]
	private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) { }

	[Address(RVA = "0x2800100", Offset = "0x27FF500", Length = "0x22")]
	[Token(Token = "0x600002C")]
	public void ManualUpdate() { }

	[Address(RVA = "0x2800130", Offset = "0x27FF530", Length = "0x9A")]
	[Token(Token = "0x600002B")]
	public void ManualUpdate(int currentFrame, float deltaTime) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600001D")]
	public override void OnCameraActivated(ActivationEventParams evt) { }

	[Address(RVA = "0x28001D0", Offset = "0x27FF5D0", Length = "0x1B6")]
	[Token(Token = "0x600000F")]
	private void OnDisable() { }

	[Address(RVA = "0x2800390", Offset = "0x27FF790", Length = "0x27C")]
	[Token(Token = "0x600000E")]
	private void OnEnable() { }

	[Address(RVA = "0x2800610", Offset = "0x27FFA10", Length = "0x56")]
	[Token(Token = "0x6000010")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	[Address(RVA = "0x2800610", Offset = "0x27FFA10", Length = "0x56")]
	[Token(Token = "0x6000011")]
	private void OnSceneUnloaded(Scene scene) { }

	[Address(RVA = "0x2800670", Offset = "0x27FFA70", Length = "0x10")]
	[Token(Token = "0x600000A")]
	private void OnValidate() { }

	[Address(RVA = "0x2800680", Offset = "0x27FFA80", Length = "0x43D")]
	[Token(Token = "0x6000033")]
	private void ProcessActiveCamera(float deltaTime) { }

	[Address(RVA = "0x2800AC0", Offset = "0x27FFEC0", Length = "0x5E9")]
	[Token(Token = "0x6000034")]
	private void PushStateToUnityCamera(ref CameraState state) { }

	[Address(RVA = "0x28010B0", Offset = "0x28004B0", Length = "0x21")]
	[Token(Token = "0x6000015")]
	public override void ReleaseCameraOverride(int overrideId) { }

	[Address(RVA = "0x2801110", Offset = "0x2800510", Length = "0xA4")]
	[Token(Token = "0x600000B")]
	private void Reset() { }

	[Address(RVA = "0x28010E0", Offset = "0x28004E0", Length = "0x20")]
	[Token(Token = "0x6000025")]
	public void ResetState() { }

	[Address(RVA = "0x2801DC0", Offset = "0x28011C0", Length = "0x21")]
	[Token(Token = "0x6000028")]
	public void set_ActiveBlend(CinemachineBlend value) { }

	[Address(RVA = "0x2801DF0", Offset = "0x28011F0", Length = "0x74")]
	[Token(Token = "0x6000022")]
	public void set_ControlledObject(GameObject value) { }

	[Address(RVA = "0x28011C0", Offset = "0x28005C0", Length = "0x2A")]
	[Token(Token = "0x6000014")]
	public override int SetCameraOverride(int overrideId, int priority, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime) { }

	[Address(RVA = "0x28011F0", Offset = "0x28005F0", Length = "0x1C")]
	[Token(Token = "0x600000D")]
	private void Start() { }

	[Address(RVA = "0x2801210", Offset = "0x2800610", Length = "0xF7")]
	[Token(Token = "0x6000031")]
	protected override ICinemachineCamera TopCameraFromPriorityQueue() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600001C")]
	public override void UpdateCameraState(Vector3 up, float deltaTime) { }

	[Address(RVA = "0x2801310", Offset = "0x2800710", Length = "0x2F9")]
	[Token(Token = "0x6000030")]
	private void UpdateVirtualCameras(UpdateFilter updateFilter, float deltaTime) { }

}

