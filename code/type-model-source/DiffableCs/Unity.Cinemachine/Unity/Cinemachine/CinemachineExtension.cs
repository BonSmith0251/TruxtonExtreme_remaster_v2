namespace Unity.Cinemachine;

[Token(Token = "0x200009B")]
public abstract class CinemachineExtension : MonoBehaviour
{
	[Token(Token = "0x200009C")]
	internal class VcamExtraStateBase
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000287")]
		public CinemachineVirtualCameraBase Vcam; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000326")]
		public VcamExtraStateBase() { }

	}

	[Token(Token = "0x4000286")]
	protected const float Epsilon = 0.0001; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000284")]
	private CinemachineVirtualCameraBase m_VcamOwner; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000285")]
	private Dictionary<CinemachineVirtualCameraBase, VcamExtraStateBase> m_ExtraState; //Field offset: 0x28

	[Token(Token = "0x170000B1")]
	public CinemachineVirtualCameraBase ComponentOwner
	{
		[Address(RVA = "0x283FA80", Offset = "0x283EE80", Length = "0x81")]
		[Token(Token = "0x6000315")]
		 get { } //Length: 129
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000325")]
	protected CinemachineExtension() { }

	[Address(RVA = "0x1FED4C0", Offset = "0x1FEC8C0", Length = "0x16")]
	[Token(Token = "0x6000316")]
	protected override void Awake() { }

	[Address(RVA = "0x283F840", Offset = "0x283EC40", Length = "0x1F4")]
	[Token(Token = "0x600031A")]
	protected override void ConnectToVcam(bool connect) { }

	[Address(RVA = "0x1FED4C0", Offset = "0x1FEC8C0", Length = "0x16")]
	[Token(Token = "0x6000319")]
	internal void EnsureStarted() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000320")]
	public override void ForceCameraPosition(CinemachineVirtualCameraBase vcam, Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600031F")]
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x283FA80", Offset = "0x283EE80", Length = "0x81")]
	[Token(Token = "0x6000315")]
	public CinemachineVirtualCameraBase get_ComponentOwner() { }

	[Address(RVA = "0x79CE50", Offset = "0x79C250", Length = "0x1BF")]
	[Token(Token = "0x6000324")]
	protected void GetAllExtraStates(List<T> list) { }

	[Address(RVA = "0x79D010", Offset = "0x79C410", Length = "0x152")]
	[Token(Token = "0x6000323")]
	protected T GetExtraState(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x661620", Offset = "0x660A20", Length = "0x4")]
	[Token(Token = "0x6000322")]
	public override float GetMaxDampTime() { }

	[Address(RVA = "0x283FA40", Offset = "0x283EE40", Length = "0x19")]
	[Token(Token = "0x600031C")]
	public void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x283FA60", Offset = "0x283EE60", Length = "0x16")]
	[Token(Token = "0x6000317")]
	protected override void OnDestroy() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000318")]
	protected override void OnEnable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600031E")]
	public override void OnTargetObjectWarped(CinemachineVirtualCameraBase vcam, Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000321")]
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600031D")]
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600031B")]
	public override void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) { }

}

