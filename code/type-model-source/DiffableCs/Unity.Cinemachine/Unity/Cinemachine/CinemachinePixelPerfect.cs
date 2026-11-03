namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine Pixel Perfect")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachinePixelPerfect.html")]
[Token(Token = "0x200003D")]
public class CinemachinePixelPerfect : CinemachineExtension
{

	[Address(RVA = "0xE31DA0", Offset = "0xE311A0", Length = "0x7")]
	[Token(Token = "0x600010C")]
	public CinemachinePixelPerfect() { }

	[Address(RVA = "0x2813D30", Offset = "0x2813130", Length = "0x202")]
	[Token(Token = "0x600010B")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

}

