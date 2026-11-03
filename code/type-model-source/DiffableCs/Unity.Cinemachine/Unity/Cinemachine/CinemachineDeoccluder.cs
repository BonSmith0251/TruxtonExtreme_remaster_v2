namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine Deoccluder")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineDeoccluder.html")]
[RequiredTarget(RequiredTargets::Tracking (1))]
[SaveDuringPlay]
[Token(Token = "0x200001E")]
public class CinemachineDeoccluder : CinemachineExtension, IShotQualityEvaluator
{
	[Token(Token = "0x200001F")]
	internal struct ObstacleAvoidance
	{
		[Token(Token = "0x2000020")]
		internal struct FollowTargetSettings
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000089")]
			[Tooltip("Use the Follow target when resolving occlusions, instead of the LookAt target.")]
			public bool Enabled; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x400008A")]
			[Tooltip("Vertical offset from the Follow target's root, in target local space")]
			public float YOffset; //Field offset: 0x4

		}

		[Token(Token = "0x2000021")]
		internal enum ResolutionStrategy : int
		{
			PullCameraForward = 0,
			PreserveCameraHeight = 1,
			PreserveCameraDistance = 2,
		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400007F")]
		[Tooltip("When enabled, will attempt to resolve situations where the line of sight to the target is blocked by an obstacle")]
		public bool Enabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000080")]
		[Tooltip("The maximum raycast distance when checking if the line of sight to this camera's target is clear.  If the setting is 0 or less, the current actual distance to target will be used.")]
		public float DistanceLimit; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000081")]
		[Tooltip("Don't take action unless occlusion has lasted at least this long.")]
		public float MinimumOcclusionTime; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000082")]
		[Tooltip("Camera will try to maintain this distance from any obstacle.  Try to keep this value small.  Increase it if you are seeing inside obstacles due to a large FOV on the camera.")]
		public float CameraRadius; //Field offset: 0xC
		[EnabledProperty("Enabled", null)]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000083")]
		public FollowTargetSettings UseFollowTarget; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000084")]
		[Tooltip("The way in which the Deoccluder will attempt to preserve sight of the target.")]
		public ResolutionStrategy Strategy; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Range(1, 10)]
		[Token(Token = "0x4000085")]
		[Tooltip("Upper limit on how many obstacle hits to process.  Higher numbers may impact performance.  In most environments, 4 is enough.")]
		public int MaximumEffort; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Range(0, 2)]
		[Token(Token = "0x4000086")]
		[Tooltip("Smoothing to apply to obstruction resolution.  Nearest camera point is held for at least this long")]
		public float SmoothingTime; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Range(0, 10)]
		[Token(Token = "0x4000087")]
		[Tooltip("How gradually the camera returns to its normal position after having been corrected.  Higher numbers will move the camera more gradually back to normal.")]
		public float Damping; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Range(0, 10)]
		[Token(Token = "0x4000088")]
		[Tooltip("How gradually the camera moves to resolve an occlusion.  Higher numbers will move the camera more gradually.")]
		public float DampingWhenOccluded; //Field offset: 0x28

		[Token(Token = "0x17000015")]
		internal static ObstacleAvoidance Default
		{
			[Address(RVA = "0x2816B20", Offset = "0x2815F20", Length = "0x38")]
			[Token(Token = "0x60000A5")]
			internal get { } //Length: 56
		}

		[Address(RVA = "0x2816B20", Offset = "0x2815F20", Length = "0x38")]
		[Token(Token = "0x60000A5")]
		internal static ObstacleAvoidance get_Default() { }

	}

	[Token(Token = "0x2000022")]
	internal struct QualityEvaluation
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400008F")]
		[Tooltip("If enabled, will evaluate shot quality based on target distance and occlusion")]
		public bool Enabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000090")]
		[Tooltip("If greater than zero, maximum quality boost will occur when target is this far from the camera")]
		public float OptimalDistance; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000091")]
		[Tooltip("Shots with targets closer to the camera than this will not get a quality boost")]
		public float NearLimit; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000092")]
		[Tooltip("Shots with targets farther from the camera than this will not get a quality boost")]
		public float FarLimit; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000093")]
		[Tooltip("High quality shots will be boosted by this fraction of their normal quality")]
		public float MaxQualityBoost; //Field offset: 0x10

		[Token(Token = "0x17000016")]
		internal static QualityEvaluation Default
		{
			[Address(RVA = "0x28161F0", Offset = "0x28155F0", Length = "0x26")]
			[Token(Token = "0x60000A6")]
			internal get { } //Length: 38
		}

		[Address(RVA = "0x28161F0", Offset = "0x28155F0", Length = "0x26")]
		[Token(Token = "0x60000A6")]
		internal static QualityEvaluation get_Default() { }

	}

	[Token(Token = "0x2000023")]
	private class VcamExtraState : VcamExtraStateBase
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000094")]
		public Vector3 PreviousDisplacement; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000095")]
		public bool TargetObscured; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000096")]
		public float OcclusionStartTime; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000097")]
		public List<Vector3> DebugResolutionPath; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000098")]
		public List<Collider> OccludingObjects; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000099")]
		public Vector3 PreviousCameraOffset; //Field offset: 0x40
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x400009A")]
		public Vector3 PreviousCameraPosition; //Field offset: 0x4C
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400009B")]
		public float PreviousDampTime; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x400009C")]
		public bool StateIsValid; //Field offset: 0x5C
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400009D")]
		private float m_SmoothedDistance; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x400009E")]
		private float m_SmoothedTime; //Field offset: 0x64

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60000AB")]
		public VcamExtraState() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60000A7")]
		public void AddPointToDebugPath(Vector3 p, Collider c) { }

		[Address(RVA = "0x28187E0", Offset = "0x2817BE0", Length = "0x8B")]
		[Token(Token = "0x60000A8")]
		public float ApplyDistanceSmoothing(float distance, float smoothingTime) { }

		[Address(RVA = "0x2818870", Offset = "0x2817C70", Length = "0x64")]
		[Token(Token = "0x60000AA")]
		public void ResetDistanceSmoothing(float smoothingTime) { }

		[Address(RVA = "0x2818970", Offset = "0x2817D70", Length = "0x78")]
		[Token(Token = "0x60000A9")]
		public void UpdateDistanceSmoothing(float distance) { }

	}

	[Token(Token = "0x400007B")]
	private const float k_PrecisionSlush = 0.001; //Field offset: 0x0
	[Token(Token = "0x400007D")]
	private const float k_AngleThreshold = 0.1; //Field offset: 0x0
	[Token(Token = "0x400007E")]
	private static Collider[] s_ColliderBuffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000074")]
	[Tooltip("Objects on these layers will be detected")]
	public LayerMask CollideAgainst; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[TagField]
	[Token(Token = "0x4000075")]
	[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
	public string IgnoreTag; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000076")]
	[Tooltip("Objects on these layers will never obstruct view of the target")]
	public LayerMask TransparentLayers; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000077")]
	[Tooltip("Obstacles closer to the target than this will be ignored")]
	public float MinimumDistanceFromTarget; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x4000078")]
	public ObstacleAvoidance AvoidObstacles; //Field offset: 0x48
	[FieldOffset(Offset = "0x74")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x4000079")]
	public QualityEvaluation ShotQualityEvaluation; //Field offset: 0x74
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400007A")]
	private List<VcamExtraState> m_extraStateCache; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400007C")]
	private RaycastHit[] m_CornerBuffer; //Field offset: 0x90

	[Address(RVA = "0x280E860", Offset = "0x280DC60", Length = "0x68")]
	[Token(Token = "0x60000A4")]
	private static CinemachineDeoccluder() { }

	[Address(RVA = "0x280E8D0", Offset = "0x280DCD0", Length = "0xD4")]
	[Token(Token = "0x60000A3")]
	public CinemachineDeoccluder() { }

	[Address(RVA = "0x2808C90", Offset = "0x2808090", Length = "0x67")]
	[Token(Token = "0x600008F")]
	public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2808D00", Offset = "0x2808100", Length = "0xE5A")]
	[Token(Token = "0x60000A0")]
	private static float ClampRayToBounds(Ray ray, float distance, Bounds bounds) { }

	[Address(RVA = "0x2809B60", Offset = "0x2808F60", Length = "0x1F3")]
	[Token(Token = "0x6000095")]
	public void DebugCollisionPaths(List<List`1<Vector3>> paths, List<List`1<Collider>> obstacles) { }

	[Address(RVA = "0x2809D60", Offset = "0x2809160", Length = "0x6F")]
	[Token(Token = "0x6000098")]
	public virtual void ForceCameraPosition(CinemachineVirtualCameraBase vcam, Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x2809DD0", Offset = "0x28091D0", Length = "0x2BA")]
	[Token(Token = "0x600009A")]
	private bool GetAvoidanceResolutionTargetPoint(CinemachineVirtualCameraBase vcam, ref CameraState state, out Vector3 resolutuionTargetPoint) { }

	[Address(RVA = "0x280A090", Offset = "0x2809490", Length = "0x5D")]
	[Token(Token = "0x6000090")]
	public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x280A0F0", Offset = "0x28094F0", Length = "0x1E")]
	[Token(Token = "0x6000096")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x280A110", Offset = "0x2809510", Length = "0x25A")]
	[Token(Token = "0x600009F")]
	private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos) { }

	[Address(RVA = "0x280A370", Offset = "0x2809770", Length = "0x93A")]
	[Token(Token = "0x600009E")]
	private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir) { }

	[Address(RVA = "0x280ACB0", Offset = "0x280A0B0", Length = "0x40A")]
	[Token(Token = "0x60000A2")]
	private bool IsTargetObscured(CameraState state) { }

	[Address(RVA = "0x280B0C0", Offset = "0x280A4C0", Length = "0x57")]
	[Token(Token = "0x600008E")]
	public bool IsTargetObscured(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x280B120", Offset = "0x280A520", Length = "0x50")]
	[Token(Token = "0x6000093")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x280B170", Offset = "0x280A570", Length = "0xD5")]
	[Token(Token = "0x6000094")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x280B250", Offset = "0x280A650", Length = "0x94")]
	[Token(Token = "0x6000097")]
	public virtual void OnTargetObjectWarped(CinemachineVirtualCameraBase vcam, Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x280B2F0", Offset = "0x280A6F0", Length = "0x83")]
	[Token(Token = "0x6000091")]
	private void OnValidate() { }

	[Address(RVA = "0x280B380", Offset = "0x280A780", Length = "0x164A")]
	[Token(Token = "0x6000099")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x280C9D0", Offset = "0x280BDD0", Length = "0x4E6")]
	[Token(Token = "0x600009B")]
	private Vector3 PreserveLineOfSight(ref CameraState state, ref VcamExtraState extra, Vector3 lookAtPoint) { }

	[Address(RVA = "0x280CEC0", Offset = "0x280C2C0", Length = "0x393")]
	[Token(Token = "0x600009C")]
	private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo) { }

	[Address(RVA = "0x280D260", Offset = "0x280C660", Length = "0xA08")]
	[Token(Token = "0x600009D")]
	private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref VcamExtraState extra) { }

	[Address(RVA = "0x280DC70", Offset = "0x280D070", Length = "0xDC")]
	[Token(Token = "0x6000092")]
	private void Reset() { }

	[Address(RVA = "0x280DD50", Offset = "0x280D150", Length = "0xB00")]
	[Token(Token = "0x60000A1")]
	private Vector3 RespectCameraRadius(Vector3 cameraPos, Vector3 lookAtPos) { }

}

