namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[ExecuteAlways]
[Obsolete("CinemachineCollider has been deprecated. Use CinemachineDeoccluder instead")]
[SaveDuringPlay]
[Token(Token = "0x2000103")]
public class CinemachineCollider : CinemachineExtension, IShotQualityEvaluator
{
	[Token(Token = "0x2000104")]
	internal enum ResolutionStrategy : int
	{
		PullCameraForward = 0,
		PreserveCameraHeight = 1,
		PreserveCameraDistance = 2,
	}

	[Token(Token = "0x2000105")]
	private class VcamExtraState : VcamExtraStateBase
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40003EC")]
		public Vector3 previousDisplacement; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40003ED")]
		public Vector3 previousCameraOffset; //Field offset: 0x24
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40003EE")]
		public Vector3 previousCameraPosition; //Field offset: 0x30
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40003EF")]
		public float previousDampTime; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40003F0")]
		public bool targetObscured; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40003F1")]
		public float occlusionStartTime; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40003F2")]
		public List<Vector3> debugResolutionPath; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40003F3")]
		private float m_SmoothedDistance; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40003F4")]
		private float m_SmoothedTime; //Field offset: 0x54

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60004EA")]
		public VcamExtraState() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60004E6")]
		public void AddPointToDebugPath(Vector3 p) { }

		[Address(RVA = "0x2868C90", Offset = "0x2868090", Length = "0x8B")]
		[Token(Token = "0x60004E7")]
		public float ApplyDistanceSmoothing(float distance, float smoothingTime) { }

		[Address(RVA = "0x2868D20", Offset = "0x2868120", Length = "0x64")]
		[Token(Token = "0x60004E9")]
		public void ResetDistanceSmoothing(float smoothingTime) { }

		[Address(RVA = "0x2868D90", Offset = "0x2868190", Length = "0x72")]
		[Token(Token = "0x60004E8")]
		public void UpdateDistanceSmoothing(float distance) { }

	}

	[Token(Token = "0x40003E7")]
	private static Collider[] s_ColliderBuffer; //Field offset: 0x0
	[Token(Token = "0x40003E3")]
	private const float k_PrecisionSlush = 0.001; //Field offset: 0x0
	[Token(Token = "0x40003E6")]
	private const float k_AngleThreshold = 0.1; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[Header("Obstacle Detection")]
	[Token(Token = "0x40003D5")]
	[Tooltip("Objects on these layers will be detected")]
	public LayerMask m_CollideAgainst; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[TagField]
	[Token(Token = "0x40003D6")]
	[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
	public string m_IgnoreTag; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003D7")]
	[Tooltip("Objects on these layers will never obstruct view of the target")]
	public LayerMask m_TransparentLayers; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40003D8")]
	[Tooltip("Obstacles closer to the target than this will be ignored")]
	public float m_MinimumDistanceFromTarget; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("m_PreserveLineOfSight")]
	[Space]
	[Token(Token = "0x40003D9")]
	[Tooltip("When enabled, will attempt to resolve situations where the line of sight to the target is blocked by an obstacle")]
	public bool m_AvoidObstacles; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[FormerlySerializedAs("m_LineOfSightFeelerDistance")]
	[Token(Token = "0x40003DA")]
	[Tooltip("The maximum raycast distance when checking if the line of sight to this camera's target is clear.  If the setting is 0 or less, the current actual distance to target will be used.")]
	public float m_DistanceLimit; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003DB")]
	[Tooltip("Don't take action unless occlusion has lasted at least this long.")]
	public float m_MinimumOcclusionTime; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40003DC")]
	[Tooltip("Camera will try to maintain this distance from any obstacle.  Try to keep this value small.  Increase it if you are seeing inside obstacles due to a large FOV on the camera.")]
	public float m_CameraRadius; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003DD")]
	[Tooltip("The way in which the Collider will attempt to preserve sight of the target.")]
	public ResolutionStrategy m_Strategy; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Range(1, 10)]
	[Token(Token = "0x40003DE")]
	[Tooltip("Upper limit on how many obstacle hits to process.  Higher numbers may impact performance.  In most environments, 4 is enough.")]
	public int m_MaximumEffort; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Range(0, 2)]
	[Token(Token = "0x40003DF")]
	[Tooltip("Smoothing to apply to obstruction resolution.  Nearest camera point is held for at least this long")]
	public float m_SmoothingTime; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[FormerlySerializedAs("m_Smoothing")]
	[Range(0, 10)]
	[Token(Token = "0x40003E0")]
	[Tooltip("How gradually the camera returns to its normal position after having been corrected.  Higher numbers will move the camera more gradually back to normal.")]
	public float m_Damping; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Range(0, 10)]
	[Token(Token = "0x40003E1")]
	[Tooltip("How gradually the camera moves to resolve an occlusion.  Higher numbers will move the camera more gradually.")]
	public float m_DampingWhenOccluded; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Header("Shot Evaluation")]
	[Token(Token = "0x40003E2")]
	[Tooltip("If greater than zero, a higher score will be given to shots when the target is closer to this distance.  Set this to zero to disable this feature.")]
	public float m_OptimalTargetDistance; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40003E4")]
	private List<VcamExtraState> m_extraStateCache; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40003E5")]
	private RaycastHit[] m_CornerBuffer; //Field offset: 0x78

	[Token(Token = "0x17000104")]
	internal List<List`1<Vector3>> DebugPaths
	{
		[Address(RVA = "0x28560B0", Offset = "0x28554B0", Length = "0x217")]
		[Token(Token = "0x60004D7")]
		internal get { } //Length: 535
	}

	[Address(RVA = "0x2855F90", Offset = "0x2855390", Length = "0x68")]
	[Token(Token = "0x60004E5")]
	private static CinemachineCollider() { }

	[Address(RVA = "0x2856000", Offset = "0x2855400", Length = "0xAE")]
	[Token(Token = "0x60004E4")]
	public CinemachineCollider() { }

	[Address(RVA = "0x2851430", Offset = "0x2850830", Length = "0x67")]
	[Token(Token = "0x60004D3")]
	public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x28514A0", Offset = "0x28508A0", Length = "0x3FF")]
	[Token(Token = "0x60004E1")]
	private bool CheckForTargetObstructions(CameraState state) { }

	[Address(RVA = "0x2808D00", Offset = "0x2808100", Length = "0xE5A")]
	[Token(Token = "0x60004DF")]
	private static float ClampRayToBounds(Ray ray, float distance, Bounds bounds) { }

	[Address(RVA = "0x28560B0", Offset = "0x28554B0", Length = "0x217")]
	[Token(Token = "0x60004D7")]
	internal List<List`1<Vector3>> get_DebugPaths() { }

	[Address(RVA = "0x28518A0", Offset = "0x2850CA0", Length = "0x5D")]
	[Token(Token = "0x60004D4")]
	public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2851900", Offset = "0x2850D00", Length = "0x16")]
	[Token(Token = "0x60004D8")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x2851920", Offset = "0x2850D20", Length = "0x2A3")]
	[Token(Token = "0x60004DE")]
	private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos) { }

	[Address(RVA = "0x2851BD0", Offset = "0x2850FD0", Length = "0x936")]
	[Token(Token = "0x60004DD")]
	private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir) { }

	[Address(RVA = "0x2852510", Offset = "0x2851910", Length = "0x57")]
	[Token(Token = "0x60004D2")]
	public bool IsTargetObscured(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2852570", Offset = "0x2851970", Length = "0x6F2")]
	[Token(Token = "0x60004E2")]
	private static bool IsTargetOffscreen(CameraState state) { }

	[Address(RVA = "0x2852C70", Offset = "0x2852070", Length = "0x50")]
	[Token(Token = "0x60004D6")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x2852CC0", Offset = "0x28520C0", Length = "0x49")]
	[Token(Token = "0x60004D5")]
	private void OnValidate() { }

	[Address(RVA = "0x2852D10", Offset = "0x2852110", Length = "0x13DE")]
	[Token(Token = "0x60004D9")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x28540F0", Offset = "0x28534F0", Length = "0x590")]
	[Token(Token = "0x60004DA")]
	private Vector3 PreserveLineOfSight(ref CameraState state, ref VcamExtraState extra) { }

	[Address(RVA = "0x2854690", Offset = "0x2853A90", Length = "0x366")]
	[Token(Token = "0x60004DB")]
	private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo) { }

	[Address(RVA = "0x2854A00", Offset = "0x2853E00", Length = "0x993")]
	[Token(Token = "0x60004DC")]
	private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref VcamExtraState extra) { }

	[Address(RVA = "0x28553A0", Offset = "0x28547A0", Length = "0xAF6")]
	[Token(Token = "0x60004E0")]
	private Vector3 RespectCameraRadius(Vector3 cameraPos, Vector3 lookAtPos) { }

	[Address(RVA = "0x2855EA0", Offset = "0x28552A0", Length = "0xE8")]
	[Token(Token = "0x60004E3")]
	internal void UpgradeToCm3(CinemachineDeoccluder c) { }

}

