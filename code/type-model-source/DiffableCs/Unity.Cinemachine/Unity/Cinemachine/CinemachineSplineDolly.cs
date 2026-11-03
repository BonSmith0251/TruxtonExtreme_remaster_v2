namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Position Control/Cinemachine Spline Dolly")]
[CameraPipeline(Stage::Body (0))]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineSplineDolly.html")]
[SaveDuringPlay]
[Token(Token = "0x200006E")]
public class CinemachineSplineDolly : CinemachineComponentBase, ISplineReferencer
{
	[Token(Token = "0x2000070")]
	internal struct DampingSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001DF")]
		[Tooltip("Enables damping, which causes the camera to move gradually towards the desired spline position")]
		public bool Enabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40001E0")]
		[Tooltip("How aggressively the camera tries to maintain the offset along the x, y, or z directions in spline local space. \n- x represents the axis that is perpendicular to the spline. Use this to smooth out imperfections in the path. This may move the camera off the spline.\n- y represents the axis that is defined by the spline-local up direction. Use this to smooth out imperfections in the path. This may move the camera off the spline.\n- z represents the axis that is parallel to the spline. This won't move the camera off the spline.\n\nSmaller numbers are more responsive, larger numbers give a heavier more slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
		public Vector3 Position; //Field offset: 0x4
		[FieldOffset(Offset = "0x10")]
		[Range(0, 20)]
		[Token(Token = "0x40001E1")]
		[Tooltip("How aggressively the camera tries to maintain the desired rotation.  This is only used if Camera Rotation is not Default.")]
		public float Angular; //Field offset: 0x10

	}

	[Token(Token = "0x200006F")]
	internal enum RotationMode : int
	{
		Default = 0,
		Spline = 1,
		SplineNoRoll = 2,
		FollowTarget = 3,
		FollowTargetNoRoll = 4,
	}

	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("SplineSettings")]
	[SerializeField]
	[Token(Token = "0x40001CD")]
	private SplineSettings m_SplineSettings; //Field offset: 0x28
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001CE")]
	[Tooltip("Where to put the camera relative to the spline position.  X is perpendicular to the spline, Y is up, and Z is parallel to the spline.")]
	public Vector3 SplineOffset; //Field offset: 0x48
	[FieldOffset(Offset = "0x54")]
	[FormerlySerializedAs("CameraUp")]
	[Token(Token = "0x40001CF")]
	[Tooltip("How to set the camera's rotation and Up.  This will affect the screen composition, because the camera Aim behaviours will always try to respect the Up direction.")]
	public RotationMode CameraRotation; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x40001D0")]
	[Tooltip("Settings for controlling damping, which causes the camera to move gradually towards the desired spline position")]
	public DampingSettings Damping; //Field offset: 0x58
	[FieldOffset(Offset = "0x70")]
	[FoldoutWithEnabledButton("Enabled")]
	[NoSaveDuringPlay]
	[Token(Token = "0x40001D1")]
	[Tooltip("Controls how automatic dolly occurs.  A tracking target may be necessary to use this feature.")]
	public SplineAutoDolly AutomaticDolly; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001D2")]
	private float m_PreviousSplinePosition; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40001D3")]
	private Quaternion m_PreviousRotation; //Field offset: 0x84
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40001D4")]
	private Vector3 m_PreviousPosition; //Field offset: 0x94
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40001D5")]
	private RollCache m_RollCache; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[FormerlySerializedAs("CameraPosition")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x40001D6")]
	private float m_LegacyPosition; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[FormerlySerializedAs("PositionUnits")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x40001D7")]
	private PathIndexUnit m_LegacyUnits; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[FormerlySerializedAs("Spline")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x40001D8")]
	private SplineContainer m_LegacySpline; //Field offset: 0xB0

	[Token(Token = "0x17000066")]
	public float CameraPosition
	{
		[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
		[Token(Token = "0x600021E")]
		 get { } //Length: 6
		[Address(RVA = "0x2828CF0", Offset = "0x28280F0", Length = "0x6")]
		[Token(Token = "0x600021F")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000068")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x2828C70", Offset = "0x2828070", Length = "0x64")]
		[Token(Token = "0x6000226")]
		 get { } //Length: 100
	}

	[Token(Token = "0x17000067")]
	public PathIndexUnit PositionUnits
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x6000220")]
		 get { } //Length: 4
		[Address(RVA = "0x2828D00", Offset = "0x2828100", Length = "0xC")]
		[Token(Token = "0x6000221")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000065")]
	public SplineContainer Spline
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600021C")]
		 get { } //Length: 5
		[Address(RVA = "0x2828D10", Offset = "0x2828110", Length = "0xC")]
		[Token(Token = "0x600021D")]
		 set { } //Length: 12
	}

	[Token(Token = "0x17000064")]
	public override SplineSettings SplineSettings
	{
		[Address(RVA = "0x2828CE0", Offset = "0x28280E0", Length = "0x5")]
		[Token(Token = "0x600021B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000069")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000227")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2828BE0", Offset = "0x2827FE0", Length = "0x83")]
	[Token(Token = "0x600022B")]
	public CinemachineSplineDolly() { }

	[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
	[Token(Token = "0x600021E")]
	public float get_CameraPosition() { }

	[Address(RVA = "0x2828C70", Offset = "0x2828070", Length = "0x64")]
	[Token(Token = "0x6000226")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x6000220")]
	public PathIndexUnit get_PositionUnits() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600021C")]
	public SplineContainer get_Spline() { }

	[Address(RVA = "0x2828CE0", Offset = "0x28280E0", Length = "0x5")]
	[Token(Token = "0x600021B")]
	public override SplineSettings get_SplineSettings() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000227")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x2827C70", Offset = "0x2827070", Length = "0x2D6")]
	[Token(Token = "0x600022A")]
	private Quaternion GetCameraRotationAtSplinePoint(Quaternion splineOrientation, Vector3 up, out bool isDefault) { }

	[Address(RVA = "0x2827F50", Offset = "0x2827350", Length = "0x23")]
	[Token(Token = "0x6000228")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x2827F80", Offset = "0x2827380", Length = "0x8D6")]
	[Token(Token = "0x6000229")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x2828860", Offset = "0x2827C60", Length = "0x23")]
	[Token(Token = "0x6000225")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x2828890", Offset = "0x2827C90", Length = "0x66")]
	[Token(Token = "0x6000224")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2828900", Offset = "0x2827D00", Length = "0x174")]
	[Token(Token = "0x6000222")]
	private void OnValidate() { }

	[Address(RVA = "0x2828A80", Offset = "0x2827E80", Length = "0xC6")]
	[Token(Token = "0x600021A")]
	private void PerformLegacyUpgrade() { }

	[Address(RVA = "0x2828B50", Offset = "0x2827F50", Length = "0x8F")]
	[Token(Token = "0x6000223")]
	private void Reset() { }

	[Address(RVA = "0x2828CF0", Offset = "0x28280F0", Length = "0x6")]
	[Token(Token = "0x600021F")]
	public void set_CameraPosition(float value) { }

	[Address(RVA = "0x2828D00", Offset = "0x2828100", Length = "0xC")]
	[Token(Token = "0x6000221")]
	public void set_PositionUnits(PathIndexUnit value) { }

	[Address(RVA = "0x2828D10", Offset = "0x2828110", Length = "0xC")]
	[Token(Token = "0x600021D")]
	public void set_Spline(SplineContainer value) { }

}

