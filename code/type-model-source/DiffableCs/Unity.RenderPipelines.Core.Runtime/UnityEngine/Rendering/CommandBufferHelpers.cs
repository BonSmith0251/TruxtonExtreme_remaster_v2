namespace UnityEngine.Rendering;

[Token(Token = "0x2000020")]
public struct CommandBufferHelpers
{
	[Token(Token = "0x40000AA")]
	internal static RasterCommandBuffer rasterCmd; //Field offset: 0x0
	[Token(Token = "0x40000AB")]
	internal static ComputeCommandBuffer computeCmd; //Field offset: 0x8
	[Token(Token = "0x40000AC")]
	internal static UnsafeCommandBuffer unsafeCmd; //Field offset: 0x10

	[Address(RVA = "0x2BBB1F0", Offset = "0x2BBA5F0", Length = "0x17A")]
	[Token(Token = "0x60000E7")]
	private static CommandBufferHelpers() { }

	[Address(RVA = "0x2BBAFA0", Offset = "0x2BBA3A0", Length = "0x81")]
	[Token(Token = "0x60000E3")]
	public static ComputeCommandBuffer GetComputeCommandBuffer(CommandBuffer baseBuffer) { }

	[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
	[Token(Token = "0x60000E5")]
	public static CommandBuffer GetNativeCommandBuffer(UnsafeCommandBuffer baseBuffer) { }

	[Address(RVA = "0x2BBB030", Offset = "0x2BBA430", Length = "0x7F")]
	[Token(Token = "0x60000E2")]
	public static RasterCommandBuffer GetRasterCommandBuffer(CommandBuffer baseBuffer) { }

	[Address(RVA = "0x2BBB0B0", Offset = "0x2BBA4B0", Length = "0x81")]
	[Token(Token = "0x60000E4")]
	public static UnsafeCommandBuffer GetUnsafeCommandBuffer(CommandBuffer baseBuffer) { }

	[Address(RVA = "0x2BBB140", Offset = "0x2BBA540", Length = "0xAB")]
	[Token(Token = "0x60000E6")]
	public static void VFXManager_ProcessCameraCommand(Camera cam, UnsafeCommandBuffer cmd, VFXCameraXRSettings camXRSettings, CullingResults results) { }

}

