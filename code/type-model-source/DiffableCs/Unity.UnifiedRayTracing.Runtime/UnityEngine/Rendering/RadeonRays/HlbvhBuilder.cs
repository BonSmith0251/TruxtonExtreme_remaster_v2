namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x200000B")]
internal class HlbvhBuilder
{
	[Token(Token = "0x200000C")]
	private struct ScratchBufferLayout
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000024")]
		public uint PrimitiveRefs; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000025")]
		public uint MortonCodes; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000026")]
		public uint SortedPrimitiveRefs; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000027")]
		public uint SortedMortonCodes; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000028")]
		public uint SortMemory; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000029")]
		public uint Aabb; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400002A")]
		public uint LeafParents; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400002B")]
		public uint InternalNodeRange; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400002C")]
		public uint TotalSize; //Field offset: 0x20

		[Address(RVA = "0x2F604E0", Offset = "0x2F5F8E0", Length = "0xBC")]
		[Token(Token = "0x6000024")]
		public static ScratchBufferLayout Create(uint triangleCount) { }

		[Address(RVA = "0x2F60660", Offset = "0x2F5FA60", Length = "0x7")]
		[Token(Token = "0x6000025")]
		private uint Reserve(uint size) { }

	}

	[Token(Token = "0x4000021")]
	private const uint kTrianglesPerThread = 8; //Field offset: 0x0
	[Token(Token = "0x4000022")]
	private const uint kGroupSize = 256; //Field offset: 0x0
	[Token(Token = "0x4000023")]
	private const uint kTrianglesPerGroup = 2048; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001B")]
	private readonly ComputeShader shaderBuildHlbvh; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400001C")]
	private readonly int kernelInit; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400001D")]
	private readonly int kernelCalculateAabb; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400001E")]
	private readonly int kernelCalculateMortonCodes; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400001F")]
	private readonly int kernelBuildTreeBottomUp; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000020")]
	private readonly RadixSort radixSort; //Field offset: 0x28

	[Address(RVA = "0x2F5C1F0", Offset = "0x2F5B5F0", Length = "0x13A")]
	[Token(Token = "0x600001E")]
	public HlbvhBuilder(RadeonRaysShaders shaders) { }

	[Address(RVA = "0x2F5B930", Offset = "0x2F5AD30", Length = "0x24D")]
	[Token(Token = "0x6000023")]
	private void BindKernelArguments(CommandBuffer cmd, int kernel, GraphicsBuffer vertices, GraphicsBuffer indices, GraphicsBuffer scratch, ScratchBufferLayout scratchLayout, BottomLevelLevelAccelStruct result, bool setSortedCodes) { }

	[Address(RVA = "0x2F5BB80", Offset = "0x2F5AF80", Length = "0x621")]
	[Token(Token = "0x6000022")]
	public void Execute(CommandBuffer cmd, GraphicsBuffer vertices, int verticesOffset, uint vertexStride, GraphicsBuffer indices, int indicesOffset, int baseIndex, IndexFormat indexFormat, uint triangleCount, GraphicsBuffer scratch, in BottomLevelLevelAccelStruct result) { }

	[Address(RVA = "0x2F5C1B0", Offset = "0x2F5B5B0", Length = "0x4")]
	[Token(Token = "0x6000020")]
	public static uint GetBvhNodeCount(uint leafCount) { }

	[Address(RVA = "0x2F5C1C0", Offset = "0x2F5B5C0", Length = "0x6")]
	[Token(Token = "0x6000021")]
	public uint GetResultDataSizeInDwords(uint triangleCount) { }

	[Address(RVA = "0x2F5C1D0", Offset = "0x2F5B5D0", Length = "0x19")]
	[Token(Token = "0x600001F")]
	public uint GetScratchDataSizeInDwords(uint triangleCount) { }

}

