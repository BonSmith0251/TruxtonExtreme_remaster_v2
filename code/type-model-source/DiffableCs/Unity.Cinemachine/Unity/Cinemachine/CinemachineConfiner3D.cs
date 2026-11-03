namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine Confiner 3D")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineConfiner3D.html")]
[SaveDuringPlay]
[Token(Token = "0x2000016")]
public class CinemachineConfiner3D : CinemachineExtension
{
	[Token(Token = "0x2000017")]
	private class VcamExtraState : VcamExtraStateBase
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000058")]
		public Vector3 PreviousDisplacement; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000059")]
		public Vector3 PreviousCameraPosition; //Field offset: 0x24

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600007C")]
		public VcamExtraState() { }

	}

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000056")]
	[Tooltip("The volume within which the camera is to be contained")]
	public Collider BoundingVolume; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000057")]
	[Tooltip("Size of the slow-down zone at the edge of the bounding volume.")]
	public float SlowingDistance; //Field offset: 0x38

	[Token(Token = "0x17000014")]
	public bool IsValid
	{
		[Address(RVA = "0x28068C0", Offset = "0x2805CC0", Length = "0xA2")]
		[Token(Token = "0x6000075")]
		 get { } //Length: 162
	}

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x600007B")]
	public CinemachineConfiner3D() { }

	[Address(RVA = "0x2805EA0", Offset = "0x28052A0", Length = "0x67")]
	[Token(Token = "0x6000071")]
	public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x2805F10", Offset = "0x2805310", Length = "0x125")]
	[Token(Token = "0x6000079")]
	private Vector3 ConfinePoint(Vector3 p) { }

	[Address(RVA = "0x28068C0", Offset = "0x2805CC0", Length = "0xA2")]
	[Token(Token = "0x6000075")]
	public bool get_IsValid() { }

	[Address(RVA = "0x2806040", Offset = "0x2805440", Length = "0x5D")]
	[Token(Token = "0x6000072")]
	public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x28060A0", Offset = "0x28054A0", Length = "0xF4")]
	[Token(Token = "0x600007A")]
	private float GetDistanceFromEdge(Vector3 p, Vector3 dirUnit, float max) { }

	[Address(RVA = "0x28061A0", Offset = "0x28055A0", Length = "0xE")]
	[Token(Token = "0x6000076")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x28061B0", Offset = "0x28055B0", Length = "0x100")]
	[Token(Token = "0x6000077")]
	public virtual void OnTargetObjectWarped(CinemachineVirtualCameraBase vcam, Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x28062C0", Offset = "0x28056C0", Length = "0x10")]
	[Token(Token = "0x6000074")]
	private void OnValidate() { }

	[Address(RVA = "0x28062D0", Offset = "0x28056D0", Length = "0x5B8")]
	[Token(Token = "0x6000078")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x2806890", Offset = "0x2805C90", Length = "0x29")]
	[Token(Token = "0x6000073")]
	private void Reset() { }

}

