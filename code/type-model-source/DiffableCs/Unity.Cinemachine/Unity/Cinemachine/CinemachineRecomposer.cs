namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine Recomposer")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineRecomposer.html")]
[SaveDuringPlay]
[Token(Token = "0x200003E")]
public class CinemachineRecomposer : CinemachineExtension
{
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_ApplyAfter")]
	[Token(Token = "0x40000E7")]
	[Tooltip("When to apply the adjustment")]
	public Stage ApplyAfter; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[FormerlySerializedAs("m_Tilt")]
	[Token(Token = "0x40000E8")]
	[Tooltip("Tilt the camera by this much")]
	public float Tilt; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_Pan")]
	[Token(Token = "0x40000E9")]
	[Tooltip("Pan the camera by this much")]
	public float Pan; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[FormerlySerializedAs("m_Dutch")]
	[Token(Token = "0x40000EA")]
	[Tooltip("Roll the camera by this much")]
	public float Dutch; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("m_ZoomScale")]
	[Token(Token = "0x40000EB")]
	[Tooltip("Scale the zoom by this amount (normal = 1)")]
	public float ZoomScale; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[FormerlySerializedAs("m_FollowAttachment")]
	[Range(0, 1)]
	[Token(Token = "0x40000EC")]
	[Tooltip("Lowering this value relaxes the camera's attention to the Follow target (normal = 1)")]
	public float FollowAttachment; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("m_LookAtAttachment")]
	[Range(0, 1)]
	[Token(Token = "0x40000ED")]
	[Tooltip("Lowering this value relaxes the camera's attention to the LookAt target (normal = 1)")]
	public float LookAtAttachment; //Field offset: 0x48

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x6000111")]
	public CinemachineRecomposer() { }

	[Address(RVA = "0x2813F40", Offset = "0x2813340", Length = "0x5C")]
	[Token(Token = "0x600010E")]
	private void OnValidate() { }

	[Address(RVA = "0x2813FA0", Offset = "0x28133A0", Length = "0x558")]
	[Token(Token = "0x6000110")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x2814500", Offset = "0x2813900", Length = "0x1F")]
	[Token(Token = "0x600010F")]
	public virtual void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) { }

	[Address(RVA = "0x2814520", Offset = "0x2813920", Length = "0x24")]
	[Token(Token = "0x600010D")]
	private void Reset() { }

}

