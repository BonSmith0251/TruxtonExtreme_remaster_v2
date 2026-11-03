namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x200022E")]
public static class NormalReconstruction
{
	[Token(Token = "0x4000DA4")]
	private static readonly int s_NormalReconstructionMatrixID; //Field offset: 0x0
	[Token(Token = "0x4000DA5")]
	private static Matrix4x4[] s_NormalReconstructionMatrix; //Field offset: 0x8

	[Address(RVA = "0x2E33540", Offset = "0x2E32940", Length = "0x97")]
	[Token(Token = "0x6000C09")]
	private static NormalReconstruction() { }

	[Address(RVA = "0x2E33460", Offset = "0x2E32860", Length = "0xD4")]
	[Token(Token = "0x6000C05")]
	public static void SetupProperties(CommandBuffer cmd, in CameraData cameraData) { }

	[Address(RVA = "0x2E32EF0", Offset = "0x2E322F0", Length = "0x75")]
	[Token(Token = "0x6000C06")]
	public static void SetupProperties(RasterCommandBuffer cmd, in CameraData cameraData) { }

	[Address(RVA = "0x2E333D0", Offset = "0x2E327D0", Length = "0x82")]
	[Token(Token = "0x6000C07")]
	public static void SetupProperties(CommandBuffer cmd, UniversalCameraData cameraData) { }

	[Address(RVA = "0x2E32F70", Offset = "0x2E32370", Length = "0x45A")]
	[Token(Token = "0x6000C08")]
	public static void SetupProperties(RasterCommandBuffer cmd, in UniversalCameraData cameraData) { }

}

