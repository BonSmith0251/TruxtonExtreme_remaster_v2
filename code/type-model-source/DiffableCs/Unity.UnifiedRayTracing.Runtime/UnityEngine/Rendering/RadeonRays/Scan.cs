namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x2000022")]
internal class Scan
{
	[Token(Token = "0x40000B3")]
	private const uint kKeysPerThread = 4; //Field offset: 0x0
	[Token(Token = "0x40000B4")]
	private const uint kGroupSize = 256; //Field offset: 0x0
	[Token(Token = "0x40000B5")]
	private const uint kKeysPerGroup = 1024; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000AF")]
	private readonly ComputeShader shaderScan; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B0")]
	private readonly int kernelScan; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000B1")]
	private readonly ComputeShader shaderReduce; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000B2")]
	private readonly int kernelReduce; //Field offset: 0x28

	[Address(RVA = "0x2F603F0", Offset = "0x2F5F7F0", Length = "0xAF")]
	[Token(Token = "0x6000050")]
	public Scan(RadeonRaysShaders shaders) { }

	[Address(RVA = "0x2F5FE80", Offset = "0x2F5F280", Length = "0x3E8")]
	[Token(Token = "0x6000051")]
	public void Execute(CommandBuffer cmd, GraphicsBuffer buffer, uint inputKeysOffset, uint outputKeysOffset, uint scratchDataOffset, uint size) { }

	[Address(RVA = "0x2F60270", Offset = "0x2F5F670", Length = "0x2B")]
	[Token(Token = "0x6000053")]
	public static ulong GetScratchDataSizeInDwords(uint size) { }

	[Address(RVA = "0x2F602A0", Offset = "0x2F5F6A0", Length = "0x145")]
	[Token(Token = "0x6000052")]
	private void SetState(CommandBuffer cmd, ComputeShader shader, int kernelIndex, uint size, GraphicsBuffer buffer, uint inputKeysOffset, uint scratchDataOffset, uint outputKeysOffset) { }

}

