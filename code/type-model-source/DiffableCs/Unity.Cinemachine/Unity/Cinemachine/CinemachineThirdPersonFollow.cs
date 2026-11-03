namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Position Control/Cinemachine Third Person Follow")]
[CameraPipeline(Stage::Body (0))]
[DisallowMultipleComponent]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineThirdPersonFollow.html")]
[SaveDuringPlay]
[Token(Token = "0x2000074")]
public class CinemachineThirdPersonFollow : CinemachineComponentBase, IModifierValueSource, IModifiablePositionDamping, IModifiableDistance
{
	[Token(Token = "0x2000075")]
	internal struct ObstacleSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F0")]
		[Tooltip("If enabled, camera will be pulled in front of occluding obstacles")]
		public bool Enabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40001F1")]
		[Tooltip("Camera will avoid obstacles on these layers")]
		public LayerMask CollisionFilter; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[TagField]
		[Token(Token = "0x40001F2")]
		[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
		public string IgnoreTag; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Range(0, 1)]
		[Token(Token = "0x40001F3")]
		[Tooltip("Specifies how close the camera can get to obstacles")]
		public float CameraRadius; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Range(0, 10)]
		[Token(Token = "0x40001F4")]
		[Tooltip("How gradually the camera moves to correct for occlusions.  Higher numbers will move the camera more gradually.")]
		public float DampingIntoCollision; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Range(0, 10)]
		[Token(Token = "0x40001F5")]
		[Tooltip("How gradually the camera returns to its normal position after having been corrected by the built-in collision resolution system.  Higher numbers will move the camera more gradually back to normal.")]
		public float DampingFromCollision; //Field offset: 0x18

		[Token(Token = "0x17000073")]
		internal static ObstacleSettings Default
		{
			[Address(RVA = "0x2832AE0", Offset = "0x2831EE0", Length = "0x58")]
			[Token(Token = "0x6000249")]
			internal get { } //Length: 88
		}

		[Address(RVA = "0x2832AE0", Offset = "0x2831EE0", Length = "0x58")]
		[Token(Token = "0x6000249")]
		internal static ObstacleSettings get_Default() { }

	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001E6")]
	[Tooltip("How responsively the camera tracks the target.  Each axis (camera-local) can have its own setting.  Value is the approximate time it takes the camera to catch up to the target's new position.  Smaller values give a more rigid effect, larger values give a squishier one")]
	public Vector3 Damping; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Header("Rig")]
	[Token(Token = "0x40001E7")]
	[Tooltip("Position of the shoulder pivot relative to the Follow target origin.  This offset is in target-local space")]
	public Vector3 ShoulderOffset; //Field offset: 0x34
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001E8")]
	[Tooltip("Vertical offset of the hand in relation to the shoulder.  Arm length will affect the follow target's screen position when the camera rotates vertically")]
	public float VerticalArmLength; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Range(0, 1)]
	[Token(Token = "0x40001E9")]
	[Tooltip("Specifies which shoulder (left, right, or in-between) the camera is on")]
	public float CameraSide; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001EA")]
	[Tooltip("How far behind the hand the camera will be placed")]
	public float CameraDistance; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x40001EB")]
	public ObstacleSettings AvoidObstacles; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001EC")]
	private Collider <CurrentObstacle>k__BackingField; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40001ED")]
	private Vector3 m_PreviousFollowTargetPosition; //Field offset: 0x78
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40001EE")]
	private Vector3 m_DampingCorrection; //Field offset: 0x84
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40001EF")]
	private float m_CamPosCollisionCorrection; //Field offset: 0x90

	[Token(Token = "0x1700006D")]
	public Collider CurrentObstacle
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000235")]
		 get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000236")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000071")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x2831E40", Offset = "0x2831240", Length = "0x6D")]
		[Token(Token = "0x600023E")]
		 get { } //Length: 109
	}

	[Token(Token = "0x17000072")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600023F")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000070")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.Distance
	{
		[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
		[Token(Token = "0x600023C")]
		private get { } //Length: 6
		[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
		[Token(Token = "0x600023D")]
		private set { } //Length: 6
	}

	[Token(Token = "0x1700006F")]
	private override Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.PositionDamping
	{
		[Address(RVA = "0x1D509D0", Offset = "0x1D4FDD0", Length = "0x13")]
		[Token(Token = "0x600023A")]
		private get { } //Length: 19
		[Address(RVA = "0x2831AC0", Offset = "0x2830EC0", Length = "0x10")]
		[Token(Token = "0x600023B")]
		private set { } //Length: 16
	}

	[Token(Token = "0x1700006E")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.NormalizedModifierValue
	{
		[Address(RVA = "0x2831AD0", Offset = "0x2830ED0", Length = "0x2D0")]
		[Token(Token = "0x6000239")]
		private get { } //Length: 720
	}

	[Address(RVA = "0x2831DB0", Offset = "0x28311B0", Length = "0x83")]
	[Token(Token = "0x6000248")]
	public CinemachineThirdPersonFollow() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000235")]
	public Collider get_CurrentObstacle() { }

	[Address(RVA = "0x2831E40", Offset = "0x2831240", Length = "0x6D")]
	[Token(Token = "0x600023E")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600023F")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x2830640", Offset = "0x282FA40", Length = "0x2A6")]
	[Token(Token = "0x6000245")]
	internal static Quaternion GetHeading(Quaternion targetRot, Vector3 up) { }

	[Address(RVA = "0x28308F0", Offset = "0x282FCF0", Length = "0x2D")]
	[Token(Token = "0x6000240")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x2830920", Offset = "0x282FD20", Length = "0x19A")]
	[Token(Token = "0x6000246")]
	private void GetRawRigPositions(Vector3 root, Quaternion targetRot, Quaternion heading, out Vector3 shoulder, out Vector3 hand) { }

	[Address(RVA = "0x2830AC0", Offset = "0x282FEC0", Length = "0x216")]
	[Token(Token = "0x6000244")]
	public void GetRigPositions(out Vector3 root, out Vector3 shoulder, out Vector3 hand) { }

	[Address(RVA = "0x2830CE0", Offset = "0x28300E0", Length = "0x87")]
	[Token(Token = "0x6000241")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x2830D70", Offset = "0x2830170", Length = "0xE0")]
	[Token(Token = "0x6000242")]
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x2830E50", Offset = "0x2830250", Length = "0x7B")]
	[Token(Token = "0x6000237")]
	private void OnValidate() { }

	[Address(RVA = "0x2830ED0", Offset = "0x28302D0", Length = "0x6CF")]
	[Token(Token = "0x6000243")]
	private void PositionCamera(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x28315A0", Offset = "0x28309A0", Length = "0xCE")]
	[Token(Token = "0x6000238")]
	private void Reset() { }

	[Address(RVA = "0x2831670", Offset = "0x2830A70", Length = "0x447")]
	[Token(Token = "0x6000247")]
	private Vector3 ResolveCollisions(Vector3 root, Vector3 tip, float deltaTime, float cameraRadius, ref float collisionCorrection) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000236")]
	public void set_CurrentObstacle(Collider value) { }

	[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
	[Token(Token = "0x600023C")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.get_Distance() { }

	[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
	[Token(Token = "0x600023D")]
	private override void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.set_Distance(float value) { }

	[Address(RVA = "0x1D509D0", Offset = "0x1D4FDD0", Length = "0x13")]
	[Token(Token = "0x600023A")]
	private override Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.get_PositionDamping() { }

	[Address(RVA = "0x2831AC0", Offset = "0x2830EC0", Length = "0x10")]
	[Token(Token = "0x600023B")]
	private override void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.set_PositionDamping(Vector3 value) { }

	[Address(RVA = "0x2831AD0", Offset = "0x2830ED0", Length = "0x2D0")]
	[Token(Token = "0x6000239")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue() { }

}

