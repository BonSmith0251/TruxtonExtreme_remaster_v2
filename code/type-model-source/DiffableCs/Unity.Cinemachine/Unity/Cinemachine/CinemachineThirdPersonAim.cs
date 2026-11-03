namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Rotation Control/Cinemachine Third Person Aim")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineThirdPersonAim.html")]
[SaveDuringPlay]
[Token(Token = "0x2000058")]
public class CinemachineThirdPersonAim : CinemachineExtension
{
	[FieldOffset(Offset = "0x30")]
	[Header("Aim Target Detection")]
	[Token(Token = "0x400015D")]
	[Tooltip("Objects on these layers will be detected")]
	public LayerMask AimCollisionFilter; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[TagField]
	[Token(Token = "0x400015E")]
	[Tooltip("Objects with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
	public string IgnoreTag; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400015F")]
	[Tooltip("How far to project the object detection ray")]
	public float AimDistance; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000160")]
	[Tooltip("If set, camera noise will be adjusted to stabilize target on screen")]
	public bool NoiseCancellation; //Field offset: 0x44
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000161")]
	private Vector3 <AimTarget>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x17000037")]
	public private Vector3 AimTarget
	{
		[Address(RVA = "0x1DD9D00", Offset = "0x1DD9100", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600017F")]
		 get { } //Length: 19
		[Address(RVA = "0x2830630", Offset = "0x282FA30", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x6000180")]
		private set { } //Length: 16
	}

	[Address(RVA = "0x28305F0", Offset = "0x282F9F0", Length = "0x3A")]
	[Token(Token = "0x6000186")]
	public CinemachineThirdPersonAim() { }

	[Address(RVA = "0x282FAC0", Offset = "0x282EEC0", Length = "0x210")]
	[Token(Token = "0x6000185")]
	private Vector3 ComputeAimTarget(Vector3 cameraLookAt, Transform player) { }

	[Address(RVA = "0x282FCE0", Offset = "0x282F0E0", Length = "0x2EA")]
	[Token(Token = "0x6000184")]
	private Vector3 ComputeLookAtPoint(Vector3 camPos, Transform player, Vector3 fwd) { }

	[Address(RVA = "0x1DD9D00", Offset = "0x1DD9100", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600017F")]
	public Vector3 get_AimTarget() { }

	[Address(RVA = "0x282FFD0", Offset = "0x282F3D0", Length = "0x15")]
	[Token(Token = "0x6000181")]
	private void OnValidate() { }

	[Address(RVA = "0x282FFF0", Offset = "0x282F3F0", Length = "0x5A9")]
	[Token(Token = "0x6000183")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x28305A0", Offset = "0x282F9A0", Length = "0x47")]
	[Token(Token = "0x6000182")]
	private void Reset() { }

	[Address(RVA = "0x2830630", Offset = "0x282FA30", Length = "0x10")]
	[CompilerGenerated]
	[Token(Token = "0x6000180")]
	private void set_AimTarget(Vector3 value) { }

}

