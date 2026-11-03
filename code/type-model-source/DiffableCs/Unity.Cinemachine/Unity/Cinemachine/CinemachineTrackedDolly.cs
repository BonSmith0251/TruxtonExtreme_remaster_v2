namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[CameraPipeline(Stage::Body (0))]
[Obsolete("CinemachineTrackedDolly has been deprecated. Use CinemachineSplineDolly instead.")]
[SaveDuringPlay]
[Token(Token = "0x2000135")]
public class CinemachineTrackedDolly : CinemachineComponentBase
{
	[Token(Token = "0x2000137")]
	internal struct AutoDolly
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000517")]
		[Tooltip("If checked, will enable automatic dolly, which chooses a path position that is as close as possible to the Follow target.  Note: this can have significant performance impact")]
		public bool m_Enabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000518")]
		[Tooltip("Offset, in current position units, from the closest point on the path to the follow target")]
		public float m_PositionOffset; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000519")]
		[Tooltip("Search up to this many waypoints on either side of the current position.  Use 0 for Entire path.")]
		public int m_SearchRadius; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[FormerlySerializedAs("m_StepsPerSegment")]
		[Token(Token = "0x400051A")]
		[Tooltip("We search between waypoints by dividing the segment into this many straight pieces.  he higher the number, the more accurate the result, but performance is proportionally slower for higher numbers")]
		public int m_SearchResolution; //Field offset: 0xC

		[Address(RVA = "0x2869B50", Offset = "0x2868F50", Length = "0x13")]
		[Token(Token = "0x6000602")]
		public AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment) { }

	}

	[Token(Token = "0x2000136")]
	internal enum CameraUpMode : int
	{
		Default = 0,
		Path = 1,
		PathNoRoll = 2,
		FollowTarget = 3,
		FollowTargetNoRoll = 4,
	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000502")]
	[Tooltip("The path to which the camera will be constrained.  This must be non-null.")]
	public CinemachinePathBase m_Path; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000503")]
	[Tooltip("The position along the path at which the camera will be placed.  This can be animated directly, or set automatically by the Auto-Dolly feature to get as close as possible to the Follow target.  The value is interpreted according to the Position Units setting.")]
	public float m_PathPosition; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000504")]
	[Tooltip("How to interpret Path Position.  If set to Path Units, values are as follows: 0 represents the first waypoint on the path, 1 is the second, and so on.  Values in-between are points on the path in between the waypoints.  If set to Distance, then Path Position represents distance along the path.")]
	public PositionUnits m_PositionUnits; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000505")]
	[Tooltip("Where to put the camera relative to the path position.  X is perpendicular to the path, Y is up, and Z is parallel to the path.  This allows the camera to be offset from the path itself (as if on a tripod, for example).")]
	public Vector3 m_PathOffset; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[Range(0, 20)]
	[Token(Token = "0x4000506")]
	[Tooltip("How aggressively the camera tries to maintain its position in a direction perpendicular to the path.  Small numbers are more responsive, rapidly translating the camera to keep the target's x-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_XDamping; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Range(0, 20)]
	[Token(Token = "0x4000507")]
	[Tooltip("How aggressively the camera tries to maintain its position in the path-local up direction.  Small numbers are more responsive, rapidly translating the camera to keep the target's y-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_YDamping; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Range(0, 20)]
	[Token(Token = "0x4000508")]
	[Tooltip("How aggressively the camera tries to maintain its position in a direction parallel to the path.  Small numbers are more responsive, rapidly translating the camera to keep the target's z-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_ZDamping; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000509")]
	[Tooltip("How to set the virtual camera's Up vector.  This will affect the screen composition, because the camera Aim behaviours will always try to respect the Up direction.")]
	public CameraUpMode m_CameraUp; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Range(0, 20)]
	[Token(Token = "0x400050A")]
	[Tooltip("How aggressively the camera tries to track the target rotation's X angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_PitchDamping; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Range(0, 20)]
	[Token(Token = "0x400050B")]
	[Tooltip("How aggressively the camera tries to track the target rotation's Y angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_YawDamping; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Range(0, 20)]
	[Token(Token = "0x400050C")]
	[Tooltip("How aggressively the camera tries to track the target rotation's Z angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_RollDamping; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400050D")]
	[Tooltip("Controls how automatic dollying occurs.  A Follow target is necessary to use this feature.")]
	public AutoDolly m_AutoDolly; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400050E")]
	private float m_PreviousPathPosition; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400050F")]
	private Quaternion m_PreviousOrientation; //Field offset: 0x74
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000510")]
	private Vector3 m_PreviousCameraPosition; //Field offset: 0x84

	[Token(Token = "0x17000134")]
	private Vector3 AngularDamping
	{
		[Address(RVA = "0x28798E0", Offset = "0x2878CE0", Length = "0xA0")]
		[Token(Token = "0x60005FF")]
		private get { } //Length: 160
	}

	[Token(Token = "0x17000132")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x2879980", Offset = "0x2878D80", Length = "0x64")]
		[Token(Token = "0x60005FA")]
		 get { } //Length: 100
	}

	[Token(Token = "0x17000133")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60005FB")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x28797E0", Offset = "0x2878BE0", Length = "0xF1")]
	[Token(Token = "0x6000601")]
	public CinemachineTrackedDolly() { }

	[Address(RVA = "0x28798E0", Offset = "0x2878CE0", Length = "0xA0")]
	[Token(Token = "0x60005FF")]
	private Vector3 get_AngularDamping() { }

	[Address(RVA = "0x2879980", Offset = "0x2878D80", Length = "0x64")]
	[Token(Token = "0x60005FA")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60005FB")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x2878460", Offset = "0x2877860", Length = "0x2D1")]
	[Token(Token = "0x60005FE")]
	private Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up) { }

	[Address(RVA = "0x2878740", Offset = "0x2877B40", Length = "0xA3")]
	[Token(Token = "0x60005FC")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x28787F0", Offset = "0x2877BF0", Length = "0xE51")]
	[Token(Token = "0x60005FD")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x2879650", Offset = "0x2878A50", Length = "0x18D")]
	[Token(Token = "0x6000600")]
	internal void UpgradeToCm3(CinemachineSplineDolly c) { }

}

