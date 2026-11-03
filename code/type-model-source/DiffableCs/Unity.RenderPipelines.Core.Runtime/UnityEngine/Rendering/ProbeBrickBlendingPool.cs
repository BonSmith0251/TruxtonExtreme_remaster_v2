namespace UnityEngine.Rendering;

[Token(Token = "0x20000FB")]
internal class ProbeBrickBlendingPool
{
	[Token(Token = "0x4000382")]
	private static ComputeShader stateBlendShader; //Field offset: 0x0
	[Token(Token = "0x4000383")]
	private static int scenarioBlendingKernel; //Field offset: 0x8
	[Token(Token = "0x4000384")]
	private static readonly int _PoolDim_LerpFactor; //Field offset: 0xC
	[Token(Token = "0x4000385")]
	private static readonly int _ChunkList; //Field offset: 0x10
	[Token(Token = "0x4000386")]
	private static readonly int _State0_L0_L1Rx; //Field offset: 0x14
	[Token(Token = "0x4000387")]
	private static readonly int _State0_L1G_L1Ry; //Field offset: 0x18
	[Token(Token = "0x4000388")]
	private static readonly int _State0_L1B_L1Rz; //Field offset: 0x1C
	[Token(Token = "0x4000389")]
	private static readonly int _State0_L2_0; //Field offset: 0x20
	[Token(Token = "0x400038A")]
	private static readonly int _State0_L2_1; //Field offset: 0x24
	[Token(Token = "0x400038B")]
	private static readonly int _State0_L2_2; //Field offset: 0x28
	[Token(Token = "0x400038C")]
	private static readonly int _State0_L2_3; //Field offset: 0x2C
	[Token(Token = "0x400038D")]
	private static readonly int _State0_ProbeOcclusion; //Field offset: 0x30
	[Token(Token = "0x400038E")]
	private static readonly int _State1_L0_L1Rx; //Field offset: 0x34
	[Token(Token = "0x400038F")]
	private static readonly int _State1_L1G_L1Ry; //Field offset: 0x38
	[Token(Token = "0x4000390")]
	private static readonly int _State1_L1B_L1Rz; //Field offset: 0x3C
	[Token(Token = "0x4000391")]
	private static readonly int _State1_L2_0; //Field offset: 0x40
	[Token(Token = "0x4000392")]
	private static readonly int _State1_L2_1; //Field offset: 0x44
	[Token(Token = "0x4000393")]
	private static readonly int _State1_L2_2; //Field offset: 0x48
	[Token(Token = "0x4000394")]
	private static readonly int _State1_L2_3; //Field offset: 0x4C
	[Token(Token = "0x4000395")]
	private static readonly int _State1_ProbeOcclusion; //Field offset: 0x50
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000396")]
	private Vector4[] m_ChunkList; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000397")]
	private int m_MappedChunks; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000398")]
	private ProbeBrickPool m_State0; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000399")]
	private ProbeBrickPool m_State1; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400039A")]
	private ProbeVolumeTextureMemoryBudget m_MemoryBudget; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400039B")]
	private ProbeVolumeSHBands m_ShBands; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400039C")]
	private bool m_ProbeOcclusion; //Field offset: 0x38

	[Token(Token = "0x170000F4")]
	internal int estimatedVMemCost
	{
		[Address(RVA = "0x2C0FDB0", Offset = "0x2C0F1B0", Length = "0x226")]
		[Token(Token = "0x60008AA")]
		internal get { } //Length: 550
	}

	[Token(Token = "0x170000F3")]
	internal bool isAllocated
	{
		[Address(RVA = "0x227B4E0", Offset = "0x227A8E0", Length = "0x9")]
		[Token(Token = "0x60008A9")]
		internal get { } //Length: 9
	}

	[Address(RVA = "0x2C0FA10", Offset = "0x2C0EE10", Length = "0x344")]
	[Token(Token = "0x60008B9")]
	private static ProbeBrickBlendingPool() { }

	[Address(RVA = "0x2C0FD60", Offset = "0x2C0F160", Length = "0x46")]
	[Token(Token = "0x60008AE")]
	internal ProbeBrickBlendingPool(ProbeVolumeBlendingTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands, bool probeOcclusion) { }

	[Address(RVA = "0x2C0E390", Offset = "0x2C0D790", Length = "0x1D7")]
	[Token(Token = "0x60008B5")]
	internal bool Allocate(int numberOfBrickChunks, List<BrickChunkAlloc> outAllocations) { }

	[Address(RVA = "0x2C0E200", Offset = "0x2C0D600", Length = "0x182")]
	[Token(Token = "0x60008AF")]
	internal void AllocateResourcesIfNeeded() { }

	[Address(RVA = "0x2C0E570", Offset = "0x2C0D970", Length = "0x170")]
	[Token(Token = "0x60008B3")]
	internal void BlendChunks(Cell cell, ProbeBrickPool dstPool) { }

	[Address(RVA = "0x2C0E6F0", Offset = "0x2C0DAF0", Length = "0x43")]
	[Token(Token = "0x60008B8")]
	internal void Cleanup() { }

	[Address(RVA = "0x2C0E740", Offset = "0x2C0DB40", Length = "0x5D")]
	[Token(Token = "0x60008B4")]
	internal void Clear() { }

	[Address(RVA = "0x2C0E7A0", Offset = "0x2C0DBA0", Length = "0x5B")]
	[Token(Token = "0x60008B6")]
	internal void Deallocate(List<BrickChunkAlloc> allocations) { }

	[Address(RVA = "0x2C0E800", Offset = "0x2C0DC00", Length = "0x3B")]
	[Token(Token = "0x60008B7")]
	internal void EnsureTextureValidity() { }

	[Address(RVA = "0x2C0FDB0", Offset = "0x2C0F1B0", Length = "0x226")]
	[Token(Token = "0x60008AA")]
	internal int get_estimatedVMemCost() { }

	[Address(RVA = "0x227B4E0", Offset = "0x227A8E0", Length = "0x9")]
	[Token(Token = "0x60008A9")]
	internal bool get_isAllocated() { }

	[Address(RVA = "0x2C0E840", Offset = "0x2C0DC40", Length = "0x1A")]
	[Token(Token = "0x60008AD")]
	internal int GetPoolDepth() { }

	[Address(RVA = "0x2C0E860", Offset = "0x2C0DC60", Length = "0x1A")]
	[Token(Token = "0x60008AC")]
	internal int GetPoolHeight() { }

	[Address(RVA = "0x2C0E880", Offset = "0x2C0DC80", Length = "0x1A")]
	[Token(Token = "0x60008AB")]
	internal int GetPoolWidth() { }

	[Address(RVA = "0x2C0E8A0", Offset = "0x2C0DCA0", Length = "0x183")]
	[Token(Token = "0x60008A8")]
	internal static void Initialize() { }

	[Address(RVA = "0x2C0EA30", Offset = "0x2C0DE30", Length = "0xDF6")]
	[Token(Token = "0x60008B2")]
	internal void PerformBlending(CommandBuffer cmd, float factor, ProbeBrickPool dstPool) { }

	[Address(RVA = "0x2C0F8D0", Offset = "0x2C0ECD0", Length = "0x135")]
	[Token(Token = "0x60008B1")]
	internal void Update(CommandBuffer cmd, CellStreamingScratchBuffer dataBuffer, CellStreamingScratchBufferLayout layout, List<BrickChunkAlloc> dstLocations, ProbeVolumeSHBands bands, int state, Texture validityTexture, bool skyOcclusion, Texture skyOcclusionTexture, bool skyShadingDirections, Texture skyShadingDirectionsTexture, bool probeOcclusion) { }

	[Address(RVA = "0x2C0F830", Offset = "0x2C0EC30", Length = "0x9F")]
	[Token(Token = "0x60008B0")]
	internal void Update(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands, int state) { }

}

