namespace Unity.Cinemachine;

[Token(Token = "0x20000AF")]
public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera
{
	[Token(Token = "0x20000B0")]
	internal enum StandbyUpdateMode : int
	{
		Never = 0,
		Always = 1,
		RoundRobin = 2,
	}

	[EnabledProperty("Enabled", "(using default)")]
	[FieldOffset(Offset = "0x20")]
	[NoSaveDuringPlay]
	[Token(Token = "0x4000297")]
	[Tooltip("Priority can be used to control which Cm Camera is live when multiple CM Cameras are active simultaneously.  The most-recently-activated CinemachineCamera will take control, unless there is another Cm Camera active with a higher priority.  In general, the most-recently-activated highest-priority CinemachineCamera will control the main camera. \n\nThe default priority is value 0.  Often it is sufficient to leave the default setting.  In special cases where you want a CinemachineCamera to have a higher or lower priority value than 0, you can set it here.")]
	public PrioritySettings Priority; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[NoSaveDuringPlay]
	[Token(Token = "0x4000298")]
	[Tooltip("The output channel functions like Unity layers.  Use it to filter the output of CinemachineCameras to different CinemachineBrains, for instance in a multi-screen environemnt.")]
	public OutputChannels OutputChannel; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000299")]
	internal int ActivationId; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400029A")]
	private int m_QueuePriority; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400029B")]
	public float FollowTargetAttachment; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400029C")]
	public float LookAtTargetAttachment; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[FormerlySerializedAs("m_StandbyUpdate")]
	[Token(Token = "0x400029D")]
	[Tooltip("When the virtual camera is not live, this is how often the virtual camera will be updated.  Set this to tune for performance. Most of the time Never is fine, unless the virtual camera is doing shot evaluation.")]
	public StandbyUpdateMode StandbyUpdate; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400029E")]
	private string m_CachedName; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400029F")]
	private bool m_WasStarted; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x40002A0")]
	private bool m_ChildStatusUpdated; //Field offset: 0x49
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002A1")]
	private CinemachineVirtualCameraBase m_ParentVcam; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002A2")]
	private Transform m_CachedFollowTarget; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002A3")]
	private CinemachineVirtualCameraBase m_CachedFollowTargetVcam; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002A4")]
	private ICinemachineTargetGroup m_CachedFollowTargetGroup; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002A5")]
	private Transform m_CachedLookAtTarget; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002A6")]
	private CinemachineVirtualCameraBase m_CachedLookAtTargetVcam; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40002A7")]
	private ICinemachineTargetGroup m_CachedLookAtTargetGroup; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x40002A8")]
	private int m_StreamingVersion; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[FormerlySerializedAs("m_Priority")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x40002A9")]
	private int m_LegacyPriority; //Field offset: 0x8C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40002AA")]
	private List<CinemachineExtension> <Extensions>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40002AB")]
	private bool <PreviousStateIsValid>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x40002AC")]
	private bool <FollowTargetChanged>k__BackingField; //Field offset: 0x99
	[CompilerGenerated]
	[FieldOffset(Offset = "0x9A")]
	[Token(Token = "0x40002AD")]
	private bool <LookAtTargetChanged>k__BackingField; //Field offset: 0x9A

	[Token(Token = "0x170000B7")]
	public override string Description
	{
		[Address(RVA = "0x28424E0", Offset = "0x28418E0", Length = "0x2C")]
		[Token(Token = "0x600034D")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170000B5")]
	internal List<CinemachineExtension> Extensions
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000347")]
		internal get { } //Length: 8
		[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000348")]
		private set { } //Length: 19
	}

	[Token(Token = "0x170000BC")]
	public abstract Transform Follow
	{
		[Token(Token = "0x6000353")]
		 get { } //Length: 0
		[Token(Token = "0x6000354")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170000C0")]
	public ICinemachineTargetGroup FollowTargetAsGroup
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6000373")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000C1")]
	public CinemachineVirtualCameraBase FollowTargetAsVcam
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000374")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000BE")]
	public private bool FollowTargetChanged
	{
		[Address(RVA = "0x1D633F0", Offset = "0x1D627F0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600036E")]
		 get { } //Length: 8
		[Address(RVA = "0x28426D0", Offset = "0x2841AD0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600036F")]
		private set { } //Length: 7
	}

	[Token(Token = "0x170000B4")]
	protected private override bool IsDprecated
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600033C")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170000C4")]
	public bool IsLive
	{
		[Address(RVA = "0x2842510", Offset = "0x2841910", Length = "0x49")]
		[Token(Token = "0x6000378")]
		 get { } //Length: 73
	}

	[Token(Token = "0x170000B8")]
	public override bool IsValid
	{
		[Address(RVA = "0x2842560", Offset = "0x2841960", Length = "0x4F")]
		[Token(Token = "0x600034E")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000BB")]
	public abstract Transform LookAt
	{
		[Token(Token = "0x6000351")]
		 get { } //Length: 0
		[Token(Token = "0x6000352")]
		 set { } //Length: 0
	}

	[Token(Token = "0x170000C2")]
	public ICinemachineTargetGroup LookAtTargetAsGroup
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6000375")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000C3")]
	public CinemachineVirtualCameraBase LookAtTargetAsVcam
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x6000376")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000BF")]
	public private bool LookAtTargetChanged
	{
		[Address(RVA = "0x1D62630", Offset = "0x1D61A30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000370")]
		 get { } //Length: 8
		[Address(RVA = "0x28426E0", Offset = "0x2841AE0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000371")]
		private set { } //Length: 7
	}

	[Token(Token = "0x170000B6")]
	public override string Name
	{
		[Address(RVA = "0x28425B0", Offset = "0x28419B0", Length = "0x9B")]
		[Token(Token = "0x600034C")]
		 get { } //Length: 155
	}

	[Token(Token = "0x170000BA")]
	public override ICinemachineMixer ParentCamera
	{
		[Address(RVA = "0x2842650", Offset = "0x2841A50", Length = "0x76")]
		[Token(Token = "0x6000350")]
		 get { } //Length: 118
	}

	[Token(Token = "0x170000BD")]
	public override bool PreviousStateIsValid
	{
		[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000355")]
		 get { } //Length: 8
		[Address(RVA = "0xD11C70", Offset = "0xD11070", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000356")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170000B9")]
	public abstract CameraState State
	{
		[Token(Token = "0x600034F")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x28424C0", Offset = "0x28418C0", Length = "0x1C")]
	[Token(Token = "0x600037B")]
	protected CinemachineVirtualCameraBase() { }

	[Address(RVA = "0x283FB10", Offset = "0x283EF10", Length = "0x12C")]
	[Token(Token = "0x6000345")]
	internal void AddExtension(CinemachineExtension extension) { }

	[Address(RVA = "0x283FC40", Offset = "0x283F040", Length = "0x1BF")]
	[Token(Token = "0x600037A")]
	public void CancelDamping(bool updateNow = false) { }

	[Address(RVA = "0x2840030", Offset = "0x283F430", Length = "0xDC")]
	[Token(Token = "0x600033F")]
	public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime) { }

	[Address(RVA = "0x283FE00", Offset = "0x283F200", Length = "0x17E")]
	[Token(Token = "0x6000340")]
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	[Address(RVA = "0x283FF80", Offset = "0x283F380", Length = "0xAF")]
	[Token(Token = "0x6000341")]
	public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	[Address(RVA = "0x2840110", Offset = "0x283F510", Length = "0xDC")]
	[Token(Token = "0x6000342")]
	public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime) { }

	[Address(RVA = "0x28402A0", Offset = "0x283F6A0", Length = "0x17E")]
	[Token(Token = "0x6000343")]
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	[Address(RVA = "0x28401F0", Offset = "0x283F5F0", Length = "0xAF")]
	[Token(Token = "0x6000344")]
	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	[Address(RVA = "0x2840420", Offset = "0x283F820", Length = "0xDC")]
	[Token(Token = "0x600035B")]
	internal void EnsureStarted() { }

	[Address(RVA = "0x2840540", Offset = "0x283F940", Length = "0x2B5")]
	[Token(Token = "0x600036B")]
	private void ForceCameraPosition(CinemachineVirtualCameraBase vcam, Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x2840500", Offset = "0x283F900", Length = "0x3E")]
	[Token(Token = "0x600036A")]
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x28424E0", Offset = "0x28418E0", Length = "0x2C")]
	[Token(Token = "0x600034D")]
	public override string get_Description() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000347")]
	internal List<CinemachineExtension> get_Extensions() { }

	[Token(Token = "0x6000353")]
	public abstract Transform get_Follow() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6000373")]
	public ICinemachineTargetGroup get_FollowTargetAsGroup() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000374")]
	public CinemachineVirtualCameraBase get_FollowTargetAsVcam() { }

	[Address(RVA = "0x1D633F0", Offset = "0x1D627F0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600036E")]
	public bool get_FollowTargetChanged() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600033C")]
	protected private override bool get_IsDprecated() { }

	[Address(RVA = "0x2842510", Offset = "0x2841910", Length = "0x49")]
	[Token(Token = "0x6000378")]
	public bool get_IsLive() { }

	[Address(RVA = "0x2842560", Offset = "0x2841960", Length = "0x4F")]
	[Token(Token = "0x600034E")]
	public override bool get_IsValid() { }

	[Token(Token = "0x6000351")]
	public abstract Transform get_LookAt() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6000375")]
	public ICinemachineTargetGroup get_LookAtTargetAsGroup() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x6000376")]
	public CinemachineVirtualCameraBase get_LookAtTargetAsVcam() { }

	[Address(RVA = "0x1D62630", Offset = "0x1D61A30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000370")]
	public bool get_LookAtTargetChanged() { }

	[Address(RVA = "0x28425B0", Offset = "0x28419B0", Length = "0x9B")]
	[Token(Token = "0x600034C")]
	public override string get_Name() { }

	[Address(RVA = "0x2842650", Offset = "0x2841A50", Length = "0x76")]
	[Token(Token = "0x6000350")]
	public override ICinemachineMixer get_ParentCamera() { }

	[Address(RVA = "0xD11AF0", Offset = "0xD10EF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000355")]
	public override bool get_PreviousStateIsValid() { }

	[Token(Token = "0x600034F")]
	public abstract CameraState get_State() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000377")]
	public override CinemachineComponentBase GetCinemachineComponent(Stage stage) { }

	[Address(RVA = "0x2840800", Offset = "0x283FC00", Length = "0xC0")]
	[Token(Token = "0x600033E")]
	public override float GetMaxDampTime() { }

	[Token(Token = "0x6000358")]
	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x28408D0", Offset = "0x283FCD0", Length = "0x79")]
	[Token(Token = "0x600036D")]
	private void InvalidateCachedTargets() { }

	[Address(RVA = "0x2840950", Offset = "0x283FD50", Length = "0x18A")]
	[Token(Token = "0x600034B")]
	protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x2840AE0", Offset = "0x283FEE0", Length = "0x208")]
	[Token(Token = "0x6000349")]
	protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState newState, float deltaTime) { }

	[Address(RVA = "0x2840CF0", Offset = "0x28400F0", Length = "0x205")]
	[Token(Token = "0x600034A")]
	protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime) { }

	[Address(RVA = "0x2840F00", Offset = "0x2840300", Length = "0x241")]
	[Token(Token = "0x6000379")]
	public bool IsParticipatingInBlend() { }

	[Address(RVA = "0x2841150", Offset = "0x2840550", Length = "0x7")]
	[Obsolete("Please use Prioritize()")]
	[Token(Token = "0x6000366")]
	public void MoveToTopOfPrioritySubqueue() { }

	[Address(RVA = "0x2841160", Offset = "0x2840560", Length = "0x72")]
	[Token(Token = "0x6000359")]
	public override void OnCameraActivated(ActivationEventParams evt) { }

	[Address(RVA = "0x28411E0", Offset = "0x28405E0", Length = "0x143")]
	[Token(Token = "0x600035D")]
	protected override void OnDestroy() { }

	[Address(RVA = "0x2841330", Offset = "0x2840730", Length = "0xA0")]
	[Token(Token = "0x6000360")]
	protected override void OnDisable() { }

	[Address(RVA = "0x28413E0", Offset = "0x28407E0", Length = "0x32E")]
	[Token(Token = "0x600035F")]
	protected override void OnEnable() { }

	[Address(RVA = "0x2841710", Offset = "0x2840B10", Length = "0x35")]
	[Token(Token = "0x6000368")]
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x2841750", Offset = "0x2840B50", Length = "0x221")]
	[Token(Token = "0x6000369")]
	private void OnTargetObjectWarped(CinemachineVirtualCameraBase vcam, Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x2841980", Offset = "0x2840D80", Length = "0xFF")]
	[Token(Token = "0x600035C")]
	protected override void OnTransformParentChanged() { }

	[Address(RVA = "0x2841A80", Offset = "0x2840E80", Length = "0x4C")]
	[Token(Token = "0x600035A")]
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x2841AD0", Offset = "0x2840ED0", Length = "0x29")]
	[Token(Token = "0x600033D")]
	protected private override void PerformLegacyUpgrade(int streamedVersion) { }

	[Address(RVA = "0x2841150", Offset = "0x2840550", Length = "0x7")]
	[Token(Token = "0x6000367")]
	public void Prioritize() { }

	[Address(RVA = "0x2841B00", Offset = "0x2840F00", Length = "0x257")]
	[Token(Token = "0x600036C")]
	protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens) { }

	[Address(RVA = "0x2841D60", Offset = "0x2841160", Length = "0x57")]
	[Token(Token = "0x6000346")]
	internal void RemoveExtension(CinemachineExtension extension) { }

	[Address(RVA = "0x2841DC0", Offset = "0x28411C0", Length = "0xC5")]
	[Token(Token = "0x6000364")]
	public Transform ResolveFollow(Transform localFollow) { }

	[Address(RVA = "0x2841E90", Offset = "0x2841290", Length = "0xC5")]
	[Token(Token = "0x6000363")]
	public Transform ResolveLookAt(Transform localLookAt) { }

	[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000348")]
	private void set_Extensions(List<CinemachineExtension> value) { }

	[Token(Token = "0x6000354")]
	public abstract void set_Follow(Transform value) { }

	[Address(RVA = "0x28426D0", Offset = "0x2841AD0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600036F")]
	private void set_FollowTargetChanged(bool value) { }

	[Token(Token = "0x6000352")]
	public abstract void set_LookAt(Transform value) { }

	[Address(RVA = "0x28426E0", Offset = "0x2841AE0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000371")]
	private void set_LookAtTargetChanged(bool value) { }

	[Address(RVA = "0xD11C70", Offset = "0xD11070", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000356")]
	public override void set_PreviousStateIsValid(bool value) { }

	[Address(RVA = "0x2841F60", Offset = "0x2841360", Length = "0x52")]
	[Token(Token = "0x600035E")]
	protected override void Start() { }

	[Address(RVA = "0x28424A0", Offset = "0x28418A0", Length = "0x1A")]
	[Token(Token = "0x6000361")]
	protected override void Update() { }

	[Address(RVA = "0x2841FC0", Offset = "0x28413C0", Length = "0x7D")]
	[Token(Token = "0x6000357")]
	public override void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x2842040", Offset = "0x2841440", Length = "0xB7")]
	[Token(Token = "0x6000362")]
	private void UpdateStatusAsChild() { }

	[Address(RVA = "0x2842100", Offset = "0x2841500", Length = "0x22B")]
	[Token(Token = "0x6000372")]
	public void UpdateTargetCache() { }

	[Address(RVA = "0x2842330", Offset = "0x2841730", Length = "0x167")]
	[Token(Token = "0x6000365")]
	private void UpdateVcamPoolStatus() { }

}

