namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[CameraPipeline(Stage::Body (0))]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/Cinemachine3rdPersonFollow.html")]
[Obsolete("Cinemachine3rdPersonFollow has been deprecated. Use CinemachineThirdPersonFollow instead")]
[RequiredTarget(RequiredTargets::Tracking (1))]
[SaveDuringPlay]
[Token(Token = "0x2000102")]
public class Cinemachine3rdPersonFollow : CinemachineComponentBase, IModifierValueSource, IModifiablePositionDamping, IModifiableDistance
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003C8")]
	[Tooltip("How responsively the camera tracks the target.  Each axis (camera-local) can have its own setting.  Value is the approximate time it takes the camera to catch up to the target's new position.  Smaller values give a more rigid effect, larger values give a squishier one")]
	public Vector3 Damping; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Header("Rig")]
	[Token(Token = "0x40003C9")]
	[Tooltip("Position of the shoulder pivot relative to the Follow target origin.  This offset is in target-local space")]
	public Vector3 ShoulderOffset; //Field offset: 0x34
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003CA")]
	[Tooltip("Vertical offset of the hand in relation to the shoulder.  Arm length will affect the follow target's screen position when the camera rotates vertically")]
	public float VerticalArmLength; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Range(0, 1)]
	[Token(Token = "0x40003CB")]
	[Tooltip("Specifies which shoulder (left, right, or in-between) the camera is on")]
	public float CameraSide; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003CC")]
	[Tooltip("How far behind the hand the camera will be placed")]
	public float CameraDistance; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Header("Obstacles")]
	[Token(Token = "0x40003CD")]
	[Tooltip("Camera will avoid obstacles on these layers")]
	public LayerMask CameraCollisionFilter; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[TagField]
	[Token(Token = "0x40003CE")]
	[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
	public string IgnoreTag; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Range(0, 1)]
	[Token(Token = "0x40003CF")]
	[Tooltip("Specifies how close the camera can get to obstacles")]
	public float CameraRadius; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Range(0, 10)]
	[Token(Token = "0x40003D0")]
	[Tooltip("How gradually the camera moves to correct for occlusions.  Higher numbers will move the camera more gradually.")]
	public float DampingIntoCollision; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Range(0, 10)]
	[Token(Token = "0x40003D1")]
	[Tooltip("How gradually the camera returns to its normal position after having been corrected by the built-in collision resolution system.  Higher numbers will move the camera more gradually back to normal.")]
	public float DampingFromCollision; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40003D2")]
	private Vector3 m_PreviousFollowTargetPosition; //Field offset: 0x64
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40003D3")]
	private Vector3 m_DampingCorrection; //Field offset: 0x70
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40003D4")]
	private float m_CamPosCollisionCorrection; //Field offset: 0x7C

	[Token(Token = "0x17000102")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x28513C0", Offset = "0x28507C0", Length = "0x6D")]
		[Token(Token = "0x60004C6")]
		 get { } //Length: 109
	}

	[Token(Token = "0x17000103")]
	public virtual Stage Stage
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60004C7")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000101")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.Distance
	{
		[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
		[Token(Token = "0x60004C4")]
		private get { } //Length: 6
		[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
		[Token(Token = "0x60004C5")]
		private set { } //Length: 6
	}

	[Token(Token = "0x17000100")]
	private override Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.PositionDamping
	{
		[Address(RVA = "0x1D509D0", Offset = "0x1D4FDD0", Length = "0x13")]
		[Token(Token = "0x60004C2")]
		private get { } //Length: 19
		[Address(RVA = "0x2831AC0", Offset = "0x2830EC0", Length = "0x10")]
		[Token(Token = "0x60004C3")]
		private set { } //Length: 16
	}

	[Token(Token = "0x170000FF")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.NormalizedModifierValue
	{
		[Address(RVA = "0x2831AD0", Offset = "0x2830ED0", Length = "0x2D0")]
		[Token(Token = "0x60004C1")]
		private get { } //Length: 720
	}

	[Address(RVA = "0x21FCB00", Offset = "0x21FBF00", Length = "0x36")]
	[Token(Token = "0x60004D1")]
	public Cinemachine3rdPersonFollow() { }

	[Address(RVA = "0x28513C0", Offset = "0x28507C0", Length = "0x6D")]
	[Token(Token = "0x60004C6")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60004C7")]
	public virtual Stage get_Stage() { }

	[Address(RVA = "0x2850040", Offset = "0x284F440", Length = "0x2F0")]
	[Token(Token = "0x60004CD")]
	internal static Quaternion GetHeading(Quaternion targetRot, Vector3 up) { }

	[Address(RVA = "0x2850330", Offset = "0x284F730", Length = "0x24")]
	[Token(Token = "0x60004C8")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x2850360", Offset = "0x284F760", Length = "0x194")]
	[Token(Token = "0x60004CE")]
	private void GetRawRigPositions(Vector3 root, Quaternion targetRot, Quaternion heading, out Vector3 shoulder, out Vector3 hand) { }

	[Address(RVA = "0x2850500", Offset = "0x284F900", Length = "0x209")]
	[Token(Token = "0x60004CC")]
	public void GetRigPositions(out Vector3 root, out Vector3 shoulder, out Vector3 hand) { }

	[Address(RVA = "0x2850710", Offset = "0x284FB10", Length = "0x87")]
	[Token(Token = "0x60004C9")]
	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x28507A0", Offset = "0x284FBA0", Length = "0xDA")]
	[Token(Token = "0x60004CA")]
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x2850880", Offset = "0x284FC80", Length = "0x7B")]
	[Token(Token = "0x60004BF")]
	private void OnValidate() { }

	[Address(RVA = "0x2850900", Offset = "0x284FD00", Length = "0x56F")]
	[Token(Token = "0x60004CB")]
	private void PositionCamera(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x2850E70", Offset = "0x2850270", Length = "0x7F")]
	[Token(Token = "0x60004C0")]
	private void Reset() { }

	[Address(RVA = "0x2850EF0", Offset = "0x28502F0", Length = "0x3ED")]
	[Token(Token = "0x60004CF")]
	private Vector3 ResolveCollisions(Vector3 root, Vector3 tip, float deltaTime, float cameraRadius, ref float collisionCorrection) { }

	[Address(RVA = "0x1E08940", Offset = "0x1E07D40", Length = "0x6")]
	[Token(Token = "0x60004C4")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.get_Distance() { }

	[Address(RVA = "0x1DD4B70", Offset = "0x1DD3F70", Length = "0x6")]
	[Token(Token = "0x60004C5")]
	private override void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiableDistance.set_Distance(float value) { }

	[Address(RVA = "0x1D509D0", Offset = "0x1D4FDD0", Length = "0x13")]
	[Token(Token = "0x60004C2")]
	private override Vector3 Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.get_PositionDamping() { }

	[Address(RVA = "0x2831AC0", Offset = "0x2830EC0", Length = "0x10")]
	[Token(Token = "0x60004C3")]
	private override void Unity.Cinemachine.CinemachineFreeLookModifier.IModifiablePositionDamping.set_PositionDamping(Vector3 value) { }

	[Address(RVA = "0x2831AD0", Offset = "0x2830ED0", Length = "0x2D0")]
	[Token(Token = "0x60004C1")]
	private override float Unity.Cinemachine.CinemachineFreeLookModifier.IModifierValueSource.get_NormalizedModifierValue() { }

	[Address(RVA = "0x28512E0", Offset = "0x28506E0", Length = "0xD0")]
	[Token(Token = "0x60004D0")]
	internal void UpgradeToCm3(CinemachineThirdPersonFollow c) { }

}

