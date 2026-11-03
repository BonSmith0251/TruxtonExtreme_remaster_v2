namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[CameraPipeline(Stage::Body (0))]
[Obsolete("CinemachineOrbitalTransposer has been deprecated. Use CinemachineOrbitalFollow instead")]
[SaveDuringPlay]
[Token(Token = "0x2000124")]
public class CinemachineOrbitalTransposer : CinemachineTransposer, IRequiresInput
{
	[CompilerGenerated]
	[Token(Token = "0x2000128")]
	private sealed class <>c
	{
		[Token(Token = "0x40004D4")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40004D5")]
		public static UpdateHeadingDelegate <>9__31_0; //Field offset: 0x8

		[Address(RVA = "0x2880090", Offset = "0x287F490", Length = "0x67")]
		[Token(Token = "0x60005A4")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005A5")]
		public <>c() { }

		[Address(RVA = "0x287FED0", Offset = "0x287F2D0", Length = "0xC9")]
		[Token(Token = "0x60005A6")]
		internal float <.ctor>b__31_0(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) { }

	}

	[Token(Token = "0x2000125")]
	internal struct Heading
	{
		[Token(Token = "0x2000126")]
		internal enum HeadingDefinition : int
		{
			PositionDelta = 0,
			Velocity = 1,
			TargetForward = 2,
			WorldForward = 3,
		}

		[FieldOffset(Offset = "0x0")]
		[FormerlySerializedAs("m_HeadingDefinition")]
		[Token(Token = "0x40004CC")]
		[Tooltip("How 'forward' is defined.  The camera will be placed by default behind the target.  PositionDelta will consider 'forward' to be the direction in which the target is moving.")]
		public HeadingDefinition m_Definition; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Range(0, 10)]
		[Token(Token = "0x40004CD")]
		[Tooltip("Size of the velocity sampling window for target heading filter.  This filters out irregularities in the target's movement.  Used only if deriving heading from target's movement (PositionDelta or Velocity)")]
		public int m_VelocityFilterStrength; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[FormerlySerializedAs("m_HeadingBias")]
		[Range(-180, 180)]
		[Token(Token = "0x40004CE")]
		[Tooltip("Where the camera is placed when the X-axis value is zero.  This is a rotation in degrees around the Y axis.  When this value is 0, the camera will be placed behind the target.  Nonzero offsets will rotate the zero position around the target.")]
		public float m_Bias; //Field offset: 0x8

		[Address(RVA = "0x1311580", Offset = "0x1310980", Length = "0xC")]
		[Token(Token = "0x600059F")]
		public Heading(HeadingDefinition def, int filterStrength, float bias) { }

	}

	[Token(Token = "0x2000127")]
	public sealed class UpdateHeadingDelegate : MulticastDelegate
	{

		[Address(RVA = "0x28801F0", Offset = "0x287F5F0", Length = "0x125")]
		[Token(Token = "0x60005A0")]
		public UpdateHeadingDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x2880100", Offset = "0x287F500", Length = "0xA2")]
		[Token(Token = "0x60005A2")]
		public override IAsyncResult BeginInvoke(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up, AsyncCallback callback, object object) { }

		[Address(RVA = "0x64F590", Offset = "0x64E990", Length = "0x29")]
		[Token(Token = "0x60005A3")]
		public override float EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x28801B0", Offset = "0x287F5B0", Length = "0x35")]
		[Token(Token = "0x60005A1")]
		public override float Invoke(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) { }

	}

	[FieldOffset(Offset = "0xA0")]
	[Space]
	[Token(Token = "0x40004BD")]
	[Tooltip("The definition of Forward.  Camera will follow behind.")]
	public Heading m_Heading; //Field offset: 0xA0
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x40004BE")]
	[Tooltip("Automatic heading recentering.  The settings here defines how the camera will reposition itself in the absence of player input.")]
	public Recentering m_RecenterToTargetHeading; //Field offset: 0xAC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40004BF")]
	[Tooltip("Heading Control.  The settings here control the behaviour of the camera in response to the player's input.")]
	public AxisState m_XAxis; //Field offset: 0xD0
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40004C0")]
	private Tracker m_TargetTracker; //Field offset: 0x140
	[FieldOffset(Offset = "0x180")]
	[FormerlySerializedAs("m_Radius")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004C1")]
	private float m_LegacyRadius; //Field offset: 0x180
	[FieldOffset(Offset = "0x184")]
	[FormerlySerializedAs("m_HeightOffset")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004C2")]
	private float m_LegacyHeightOffset; //Field offset: 0x184
	[FieldOffset(Offset = "0x188")]
	[FormerlySerializedAs("m_HeadingBias")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004C3")]
	private float m_LegacyHeadingBias; //Field offset: 0x188
	[FieldOffset(Offset = "0x18C")]
	[FormerlySerializedAs("m_HeadingIsSlave")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[Token(Token = "0x40004C4")]
	public bool m_HeadingIsDriven; //Field offset: 0x18C
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x40004C5")]
	internal UpdateHeadingDelegate HeadingUpdater; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40004C6")]
	private Vector3 m_LastTargetPosition; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40004C7")]
	private HeadingTracker mHeadingTracker; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40004C8")]
	private Rigidbody m_TargetRigidBody; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x40004C9")]
	private Transform m_PreviousTarget; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40004CA")]
	private Vector3 m_LastCameraPosition; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x40004CB")]
	private float m_LastHeading; //Field offset: 0x1CC

	[Address(RVA = "0x2872E20", Offset = "0x2872220", Length = "0x460")]
	[Token(Token = "0x600059E")]
	public CinemachineOrbitalTransposer() { }

	[Address(RVA = "0x2870420", Offset = "0x286F820", Length = "0x28B")]
	[Token(Token = "0x6000597")]
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x28706B0", Offset = "0x286FAB0", Length = "0x643")]
	[Token(Token = "0x6000599")]
	public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up) { }

	[Address(RVA = "0x2870D00", Offset = "0x2870100", Length = "0x3DD")]
	[Token(Token = "0x600059B")]
	internal virtual Vector3 GetTargetCameraPosition(Vector3 worldUp) { }

	[Address(RVA = "0x28710E0", Offset = "0x28704E0", Length = "0x7AD")]
	[Token(Token = "0x600059C")]
	private float GetTargetHeading(float currentHeading, Quaternion targetOrientation) { }

	[Address(RVA = "0x2871890", Offset = "0x2870C90", Length = "0x9CC")]
	[Token(Token = "0x600059A")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x2872260", Offset = "0x2871660", Length = "0x131")]
	[Token(Token = "0x6000593")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x28723A0", Offset = "0x28717A0", Length = "0x19C")]
	[Token(Token = "0x6000596")]
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x2872540", Offset = "0x2871940", Length = "0x26C")]
	[Token(Token = "0x6000598")]
	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x28727B0", Offset = "0x2871BB0", Length = "0x182")]
	[Token(Token = "0x6000590")]
	protected virtual void OnValidate() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000594")]
	private override bool Unity.Cinemachine.AxisState.IRequiresInput.RequiresInput() { }

	[Address(RVA = "0x2872940", Offset = "0x2871D40", Length = "0x40")]
	[Token(Token = "0x6000591")]
	public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis) { }

	[Address(RVA = "0x2872980", Offset = "0x2871D80", Length = "0x1FC")]
	[Token(Token = "0x6000592")]
	public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis, ref Recentering recentering, bool isLive) { }

	[Address(RVA = "0x2872B80", Offset = "0x2871F80", Length = "0xD2")]
	[Token(Token = "0x6000595")]
	internal void UpdateInputAxisProvider() { }

	[Address(RVA = "0x2872C60", Offset = "0x2872060", Length = "0x1B7")]
	[Token(Token = "0x600059D")]
	internal void UpgradeToCm3(CinemachineOrbitalFollow c) { }

}

