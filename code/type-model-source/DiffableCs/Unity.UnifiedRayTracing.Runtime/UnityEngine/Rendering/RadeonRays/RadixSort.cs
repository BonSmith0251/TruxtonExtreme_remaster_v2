namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x200001F")]
internal class RadixSort
{
	[Token(Token = "0x400009A")]
	private const uint kKeysPerThread = 4; //Field offset: 0x0
	[Token(Token = "0x400009B")]
	private const uint kGroupSize = 256; //Field offset: 0x0
	[Token(Token = "0x400009C")]
	private const uint kKeysPerGroup = 1024; //Field offset: 0x0
	[Token(Token = "0x400009D")]
	private const int kNumBitsPerPass = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000095")]
	private readonly ComputeShader shaderBitHistogram; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000096")]
	private readonly int kernelBitHistogram; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000097")]
	private readonly ComputeShader shaderScatter; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000098")]
	private readonly int kernelScatter; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000099")]
	private readonly Scan scan; //Field offset: 0x30

	[Address(RVA = "0x2F5EBA0", Offset = "0x2F5DFA0", Length = "0x179")]
	[Token(Token = "0x6000045")]
	public RadixSort(RadeonRaysShaders shaders) { }

	[Address(RVA = "0x2F5E640", Offset = "0x2F5DA40", Length = "0x4F0")]
	[Token(Token = "0x6000046")]
	public void Execute(CommandBuffer cmd, GraphicsBuffer buffer, uint inputKeysOffset, uint outputKeysOffset, uint inputValuesOffset, uint outputValuesOffset, uint scratchDataOffset, uint size) { }

	[Address(RVA = "0x2F5EB40", Offset = "0x2F5DF40", Length = "0x59")]
	[Token(Token = "0x6000047")]
	public static ulong GetScratchDataSizeInDwords(uint size) { }

}

