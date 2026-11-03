namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000042")]
internal static class GraphicsHelpers
{

	[Token(Token = "0x1700001B")]
	public static long MaxGraphicsBufferSizeInBytes
	{
		[Address(RVA = "0x2F5B8F0", Offset = "0x2F5ACF0", Length = "0x7")]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700001C")]
	public static float MaxGraphicsBufferSizeInGigaBytes
	{
		[Address(RVA = "0x2F5B900", Offset = "0x2F5AD00", Length = "0x2C")]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x2F5B150", Offset = "0x2F5A550", Length = "0x1A2")]
	[Token(Token = "0x60000E0")]
	public static void CopyBuffer(ComputeShader copyShader, CommandBuffer cmd, GraphicsBuffer src, int srcOffsetInDWords, GraphicsBuffer dst, int dstOffsetInDwords, int sizeInDWords) { }

	[Address(RVA = "0x2F5B300", Offset = "0x2F5A700", Length = "0x202")]
	[Token(Token = "0x60000E1")]
	public static void CopyBuffer(ComputeShader copyShader, GraphicsBuffer src, int srcOffsetInDWords, GraphicsBuffer dst, int dstOffsetInDwords, int sizeInDwords) { }

	[Address(RVA = "0x2C12730", Offset = "0x2C11B30", Length = "0xD")]
	[Token(Token = "0x60000E5")]
	public static int DivUp(int x, int y) { }

	[Address(RVA = "0x2C12730", Offset = "0x2C11B30", Length = "0xD")]
	[Token(Token = "0x60000E6")]
	public static int DivUp(int x, uint y) { }

	[Address(RVA = "0x2F526E0", Offset = "0x2F51AE0", Length = "0xE")]
	[Token(Token = "0x60000E7")]
	public static uint DivUp(uint x, uint y) { }

	[Address(RVA = "0x2F5B510", Offset = "0x2F5A910", Length = "0xAD")]
	[Token(Token = "0x60000E8")]
	public static uint3 DivUp(uint3 x, uint3 y) { }

	[Address(RVA = "0x2F5B5C0", Offset = "0x2F5A9C0", Length = "0x64")]
	[Token(Token = "0x60000E9")]
	public static void Flush(CommandBuffer cmd) { }

	[Address(RVA = "0x2F5B8F0", Offset = "0x2F5ACF0", Length = "0x7")]
	[Token(Token = "0x60000E3")]
	public static long get_MaxGraphicsBufferSizeInBytes() { }

	[Address(RVA = "0x2F5B900", Offset = "0x2F5AD00", Length = "0x2C")]
	[Token(Token = "0x60000E4")]
	public static float get_MaxGraphicsBufferSizeInGigaBytes() { }

	[Address(RVA = "0x2F5B630", Offset = "0x2F5AA30", Length = "0x2B6")]
	[Token(Token = "0x60000E2")]
	public static bool ReallocateBuffer(ComputeShader copyShader, int oldCapacity, int newCapacity, int elementSizeInBytes, ref GraphicsBuffer buffer) { }

}

