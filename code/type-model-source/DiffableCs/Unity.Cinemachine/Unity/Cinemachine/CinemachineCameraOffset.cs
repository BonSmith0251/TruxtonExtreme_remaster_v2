namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine Camera Offset")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineCameraOffset.html")]
[SaveDuringPlay]
[Token(Token = "0x200000E")]
public class CinemachineCameraOffset : CinemachineExtension
{
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_Offset")]
	[Token(Token = "0x400002C")]
	[Tooltip("Offset the camera's position by this much (camera space)")]
	public Vector3 Offset; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[FormerlySerializedAs("m_ApplyAfter")]
	[Token(Token = "0x400002D")]
	[Tooltip("When to apply the offset")]
	public Stage ApplyAfter; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("m_PreserveComposition")]
	[Token(Token = "0x400002E")]
	[Tooltip("If applying offset after aim, re-adjust the aim to preserve the screen position of the LookAt target as much as possible")]
	public bool PreserveComposition; //Field offset: 0x40

	[Address(RVA = "0x2802330", Offset = "0x2801730", Length = "0x58")]
	[Token(Token = "0x6000052")]
	public CinemachineCameraOffset() { }

	[Address(RVA = "0x2801E70", Offset = "0x2801270", Length = "0x45E")]
	[Token(Token = "0x6000051")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x28022D0", Offset = "0x28016D0", Length = "0x53")]
	[Token(Token = "0x6000050")]
	private void Reset() { }

}

