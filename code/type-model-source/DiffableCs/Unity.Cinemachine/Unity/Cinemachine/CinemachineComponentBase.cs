namespace Unity.Cinemachine;

[ExecuteAlways]
[Token(Token = "0x200008E")]
public abstract class CinemachineComponentBase : MonoBehaviour
{
	[Token(Token = "0x4000262")]
	protected const float Epsilon = 0.0001; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000263")]
	private CinemachineVirtualCameraBase m_VcamOwner; //Field offset: 0x20

	[Token(Token = "0x170000A9")]
	public override bool BodyAppliesAfterAim
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002EB")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000AA")]
	internal override bool CameraLooksAtTarget
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60002F1")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700009E")]
	public Transform FollowTarget
	{
		[Address(RVA = "0x283DDB0", Offset = "0x283D1B0", Length = "0x93")]
		[Token(Token = "0x60002DF")]
		 get { } //Length: 147
	}

	[Token(Token = "0x170000A0")]
	public ICinemachineTargetGroup FollowTargetAsGroup
	{
		[Address(RVA = "0x283D910", Offset = "0x283CD10", Length = "0x74")]
		[Token(Token = "0x60002E1")]
		 get { } //Length: 116
	}

	[Token(Token = "0x170000A1")]
	public Vector3 FollowTargetPosition
	{
		[Address(RVA = "0x283D990", Offset = "0x283CD90", Length = "0x256")]
		[Token(Token = "0x60002E2")]
		 get { } //Length: 598
	}

	[Token(Token = "0x170000A2")]
	public Quaternion FollowTargetRotation
	{
		[Address(RVA = "0x283DBF0", Offset = "0x283CFF0", Length = "0x1B5")]
		[Token(Token = "0x60002E3")]
		 get { } //Length: 437
	}

	[Token(Token = "0x170000A7")]
	public abstract bool IsValid
	{
		[Token(Token = "0x60002E8")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700009F")]
	public Transform LookAtTarget
	{
		[Address(RVA = "0x283E2A0", Offset = "0x283D6A0", Length = "0x93")]
		[Token(Token = "0x60002E0")]
		 get { } //Length: 147
	}

	[Token(Token = "0x170000A3")]
	public ICinemachineTargetGroup LookAtTargetAsGroup
	{
		[Address(RVA = "0x283DE50", Offset = "0x283D250", Length = "0x21")]
		[Token(Token = "0x60002E4")]
		 get { } //Length: 33
	}

	[Token(Token = "0x170000A4")]
	public Vector3 LookAtTargetPosition
	{
		[Address(RVA = "0x283DE80", Offset = "0x283D280", Length = "0x256")]
		[Token(Token = "0x60002E5")]
		 get { } //Length: 598
	}

	[Token(Token = "0x170000A5")]
	public Quaternion LookAtTargetRotation
	{
		[Address(RVA = "0x283E0E0", Offset = "0x283D4E0", Length = "0x1B5")]
		[Token(Token = "0x60002E6")]
		 get { } //Length: 437
	}

	[Token(Token = "0x170000A8")]
	public abstract Stage Stage
	{
		[Token(Token = "0x60002EA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000A6")]
	public CameraState VcamState
	{
		[Address(RVA = "0x283E340", Offset = "0x283D740", Length = "0x19D")]
		[Token(Token = "0x60002E7")]
		 get { } //Length: 413
	}

	[Token(Token = "0x1700009D")]
	public CinemachineVirtualCameraBase VirtualCamera
	{
		[Address(RVA = "0x283E4E0", Offset = "0x283D8E0", Length = "0x123")]
		[Token(Token = "0x60002DC")]
		 get { } //Length: 291
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60002F2")]
	protected CinemachineComponentBase() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002EF")]
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60002EB")]
	public override bool get_BodyAppliesAfterAim() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60002F1")]
	internal override bool get_CameraLooksAtTarget() { }

	[Address(RVA = "0x283DDB0", Offset = "0x283D1B0", Length = "0x93")]
	[Token(Token = "0x60002DF")]
	public Transform get_FollowTarget() { }

	[Address(RVA = "0x283D910", Offset = "0x283CD10", Length = "0x74")]
	[Token(Token = "0x60002E1")]
	public ICinemachineTargetGroup get_FollowTargetAsGroup() { }

	[Address(RVA = "0x283D990", Offset = "0x283CD90", Length = "0x256")]
	[Token(Token = "0x60002E2")]
	public Vector3 get_FollowTargetPosition() { }

	[Address(RVA = "0x283DBF0", Offset = "0x283CFF0", Length = "0x1B5")]
	[Token(Token = "0x60002E3")]
	public Quaternion get_FollowTargetRotation() { }

	[Token(Token = "0x60002E8")]
	public abstract bool get_IsValid() { }

	[Address(RVA = "0x283E2A0", Offset = "0x283D6A0", Length = "0x93")]
	[Token(Token = "0x60002E0")]
	public Transform get_LookAtTarget() { }

	[Address(RVA = "0x283DE50", Offset = "0x283D250", Length = "0x21")]
	[Token(Token = "0x60002E4")]
	public ICinemachineTargetGroup get_LookAtTargetAsGroup() { }

	[Address(RVA = "0x283DE80", Offset = "0x283D280", Length = "0x256")]
	[Token(Token = "0x60002E5")]
	public Vector3 get_LookAtTargetPosition() { }

	[Address(RVA = "0x283E0E0", Offset = "0x283D4E0", Length = "0x1B5")]
	[Token(Token = "0x60002E6")]
	public Quaternion get_LookAtTargetRotation() { }

	[Token(Token = "0x60002EA")]
	public abstract Stage get_Stage() { }

	[Address(RVA = "0x283E340", Offset = "0x283D740", Length = "0x19D")]
	[Token(Token = "0x60002E7")]
	public CameraState get_VcamState() { }

	[Address(RVA = "0x283E4E0", Offset = "0x283D8E0", Length = "0x123")]
	[Token(Token = "0x60002DC")]
	public CinemachineVirtualCameraBase get_VirtualCamera() { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x60002F0")]
	public override float GetMaxDampTime() { }

	[Token(Token = "0x60002EC")]
	public abstract void MutateCameraState(ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x283D7D0", Offset = "0x283CBD0", Length = "0x98")]
	[Token(Token = "0x60002DE")]
	protected override void OnDisable() { }

	[Address(RVA = "0x283D870", Offset = "0x283CC70", Length = "0x98")]
	[Token(Token = "0x60002DD")]
	protected override void OnEnable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002EE")]
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60002ED")]
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60002E9")]
	public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) { }

}

