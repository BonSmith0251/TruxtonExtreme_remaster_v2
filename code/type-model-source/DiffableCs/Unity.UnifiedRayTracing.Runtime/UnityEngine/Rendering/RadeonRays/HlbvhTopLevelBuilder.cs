namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x200000E")]
internal class HlbvhTopLevelBuilder
{
	[Token(Token = "0x200000F")]
	private struct ScratchBufferLayout
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003C")]
		public uint Aabb; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400003D")]
		public uint MortonCodes; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400003E")]
		public uint PrimitiveRefs; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400003F")]
		public uint SortedMortonCodes; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000040")]
		public uint SortedPrimitiveRefs; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000041")]
		public uint SortMemory; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000042")]
		public uint InternalNodeRange; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000043")]
		public uint TotalSize; //Field offset: 0x1C

		[Address(RVA = "0x2F605A0", Offset = "0x2F5F9A0", Length = "0x97")]
		[Token(Token = "0x600002E")]
		public static ScratchBufferLayout Create(uint instanceCount) { }

		[Address(RVA = "0x2F60640", Offset = "0x2F5FA40", Length = "0x7")]
		[Token(Token = "0x600002F")]
		private uint Reserve(uint size) { }

	}

	[Token(Token = "0x4000039")]
	private const uint kTrianglesPerThread = 8; //Field offset: 0x0
	[Token(Token = "0x400003A")]
	private const uint kGroupSize = 256; //Field offset: 0x0
	[Token(Token = "0x400003B")]
	private const uint kTrianglesPerGroup = 2048; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000033")]
	private readonly ComputeShader shaderBuildHlbvh; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000034")]
	private readonly int kernelInit; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000035")]
	private readonly int kernelCalculateAabb; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000036")]
	private readonly int kernelCalculateMortonCodes; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000037")]
	private readonly int kernelBuildTreeBottomUp; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000038")]
	private readonly RadixSort radixSort; //Field offset: 0x28

	[Address(RVA = "0x2F5CE90", Offset = "0x2F5C290", Length = "0x13A")]
	[Token(Token = "0x6000027")]
	public HlbvhTopLevelBuilder(RadeonRaysShaders shaders) { }

	[Address(RVA = "0x2F5C330", Offset = "0x2F5B730", Length = "0x131")]
	[Token(Token = "0x600002A")]
	public void AllocateResultBuffers(uint instanceCount, ref TopLevelAccelStruct accelStruct) { }

	[Address(RVA = "0x2F5C470", Offset = "0x2F5B870", Length = "0x23A")]
	[Token(Token = "0x600002D")]
	private void BindKernelArguments(CommandBuffer cmd, int kernel, GraphicsBuffer scratch, ScratchBufferLayout scratchLayout, TopLevelAccelStruct accelStruct, bool setSortedCodes) { }

	[Address(RVA = "0x2F5C6B0", Offset = "0x2F5BAB0", Length = "0x1C9")]
	[Token(Token = "0x600002B")]
	public void CreateEmpty(ref TopLevelAccelStruct accelStruct) { }

	[Address(RVA = "0x2F5C880", Offset = "0x2F5BC80", Length = "0x59E")]
	[Token(Token = "0x600002C")]
	public void Execute(CommandBuffer cmd, GraphicsBuffer scratch, ref TopLevelAccelStruct accelStruct) { }

	[Address(RVA = "0x2F5C1B0", Offset = "0x2F5B5B0", Length = "0x4")]
	[Token(Token = "0x6000029")]
	public static uint GetBvhNodeCount(uint leafCount) { }

	[Address(RVA = "0x2F5CE20", Offset = "0x2F5C220", Length = "0x69")]
	[Token(Token = "0x6000028")]
	public ulong GetScratchDataSizeInDwords(uint instanceCount) { }

}

