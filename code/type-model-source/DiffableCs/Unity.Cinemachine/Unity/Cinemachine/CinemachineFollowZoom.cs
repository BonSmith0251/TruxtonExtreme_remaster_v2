namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine Follow Zoom")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineFollowZoom.html")]
[RequiredTarget(RequiredTargets::LookAt (2))]
[SaveDuringPlay]
[Token(Token = "0x2000025")]
public class CinemachineFollowZoom : CinemachineExtension
{
	[Token(Token = "0x2000026")]
	private class VcamExtraState : VcamExtraStateBase
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000A7")]
		public float m_PreviousFrameZoom; //Field offset: 0x18

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60000B8")]
		public VcamExtraState() { }

	}

	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_Width")]
	[Token(Token = "0x40000A4")]
	[Tooltip("The shot width to maintain, in world units, at target distance.")]
	public float Width; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[FormerlySerializedAs("m_Damping")]
	[Range(0, 20)]
	[Token(Token = "0x40000A5")]
	[Tooltip("Increase this value to soften the aggressiveness of the follow-zoom.  Small numbers are more responsive, larger numbers give a more heavy slowly responding camera.")]
	public float Damping; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[MinMaxRangeSlider(1, 179)]
	[Token(Token = "0x40000A6")]
	[Tooltip("Range for the FOV that this behaviour will generate.")]
	public Vector2 FovRange; //Field offset: 0x38

	[Address(RVA = "0x280F710", Offset = "0x280EB10", Length = "0x23")]
	[Token(Token = "0x60000B7")]
	public CinemachineFollowZoom() { }

	[Address(RVA = "0x1BBC130", Offset = "0x1BBB530", Length = "0x6")]
	[Token(Token = "0x60000B5")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x280F270", Offset = "0x280E670", Length = "0x5C")]
	[Token(Token = "0x60000B4")]
	private void OnValidate() { }

	[Address(RVA = "0x280F2D0", Offset = "0x280E6D0", Length = "0x412")]
	[Token(Token = "0x60000B6")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x280F6F0", Offset = "0x280EAF0", Length = "0x1D")]
	[Token(Token = "0x60000B3")]
	private void Reset() { }

}

