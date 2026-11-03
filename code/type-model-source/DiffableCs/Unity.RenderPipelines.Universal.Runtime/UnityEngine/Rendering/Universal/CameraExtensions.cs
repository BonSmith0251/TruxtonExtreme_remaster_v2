namespace UnityEngine.Rendering.Universal;

[Extension]
[Token(Token = "0x20001C5")]
public static class CameraExtensions
{

	[Address(RVA = "0x2DE76F0", Offset = "0x2DE6AF0", Length = "0xFE")]
	[Extension]
	[Token(Token = "0x60009A3")]
	public static void DestroyVolumeStack(Camera camera) { }

	[Address(RVA = "0x2DE7670", Offset = "0x2DE6A70", Length = "0x77")]
	[Extension]
	[Token(Token = "0x60009A4")]
	public static void DestroyVolumeStack(Camera camera, UniversalAdditionalCameraData cameraData) { }

	[Address(RVA = "0x2DE77F0", Offset = "0x2DE6BF0", Length = "0x8E")]
	[Extension]
	[Token(Token = "0x600099E")]
	public static UniversalAdditionalCameraData GetUniversalAdditionalCameraData(Camera camera) { }

	[Address(RVA = "0x2DE7880", Offset = "0x2DE6C80", Length = "0x9D")]
	[Extension]
	[Token(Token = "0x600099F")]
	public static VolumeFrameworkUpdateMode GetVolumeFrameworkUpdateMode(Camera camera) { }

	[Address(RVA = "0x2DE7920", Offset = "0x2DE6D20", Length = "0x206")]
	[Extension]
	[Token(Token = "0x60009A5")]
	internal static void GetVolumeLayerMaskAndTrigger(Camera camera, UniversalAdditionalCameraData cameraData, out LayerMask layerMask, out Transform trigger) { }

	[Address(RVA = "0x2DE7B30", Offset = "0x2DE6F30", Length = "0xE8")]
	[Extension]
	[Token(Token = "0x60009A0")]
	public static void SetVolumeFrameworkUpdateMode(Camera camera, VolumeFrameworkUpdateMode mode) { }

	[Address(RVA = "0x2DE7C20", Offset = "0x2DE7020", Length = "0xA7")]
	[Extension]
	[Token(Token = "0x60009A1")]
	public static void UpdateVolumeStack(Camera camera) { }

	[Address(RVA = "0x2DE7CD0", Offset = "0x2DE70D0", Length = "0x14B")]
	[Extension]
	[Token(Token = "0x60009A2")]
	public static void UpdateVolumeStack(Camera camera, UniversalAdditionalCameraData cameraData) { }

}

