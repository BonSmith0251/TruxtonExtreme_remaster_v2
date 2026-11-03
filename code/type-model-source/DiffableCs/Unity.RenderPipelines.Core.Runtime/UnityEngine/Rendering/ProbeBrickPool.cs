namespace UnityEngine.Rendering;

[Token(Token = "0x20000F8")]
internal class ProbeBrickPool
{
	[DebuggerDisplay("Chunk ({x}, {y}, {z})")]
	[Token(Token = "0x20000F9")]
	internal struct BrickChunkAlloc
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000371")]
		public int x; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000372")]
		public int y; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000373")]
		public int z; //Field offset: 0x8

		[Address(RVA = "0x2C0A820", Offset = "0x2C09C20", Length = "0x14")]
		[Token(Token = "0x60008A6")]
		internal int flattenIndex(int sx, int sy) { }

	}

	[Token(Token = "0x20000FA")]
	internal struct DataLocation
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000374")]
		internal Texture TexL0_L1rx; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000375")]
		internal Texture TexL1_G_ry; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000376")]
		internal Texture TexL1_B_rz; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000377")]
		internal Texture TexL2_0; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000378")]
		internal Texture TexL2_1; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000379")]
		internal Texture TexL2_2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400037A")]
		internal Texture TexL2_3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400037B")]
		internal Texture TexProbeOcclusion; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400037C")]
		internal Texture TexValidity; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400037D")]
		internal Texture TexSkyOcclusion; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400037E")]
		internal Texture TexSkyShadingDirectionIndices; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400037F")]
		internal int width; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4000380")]
		internal int height; //Field offset: 0x5C
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000381")]
		internal int depth; //Field offset: 0x60

		[Address(RVA = "0x2C0CEC0", Offset = "0x2C0C2C0", Length = "0x168")]
		[Token(Token = "0x60008A7")]
		internal void Cleanup() { }

	}

	[Token(Token = "0x400034B")]
	internal static readonly int _Out_L0_L1Rx; //Field offset: 0x0
	[Token(Token = "0x400035A")]
	internal const int kBrickProbeCountPerDim = 4; //Field offset: 0x0
	[Token(Token = "0x4000359")]
	internal const int kBrickCellCount = 3; //Field offset: 0x0
	[Token(Token = "0x4000358")]
	private const int kChunkSizeInBricks = 128; //Field offset: 0x0
	[Token(Token = "0x400035E")]
	private const int kMaxPoolWidth = 2048; //Field offset: 0x0
	[Token(Token = "0x400035B")]
	internal const int kBrickProbeCountTotal = 64; //Field offset: 0x0
	[Token(Token = "0x400035C")]
	internal const int kChunkProbeCountPerDim = 512; //Field offset: 0x0
	[Token(Token = "0x400034C")]
	internal static readonly int _Out_L1G_L1Ry; //Field offset: 0x4
	[Token(Token = "0x400034D")]
	internal static readonly int _Out_L1B_L1Rz; //Field offset: 0x8
	[Token(Token = "0x400034E")]
	internal static readonly int _Out_Shared; //Field offset: 0xC
	[Token(Token = "0x400034F")]
	internal static readonly int _Out_ProbeOcclusion; //Field offset: 0x10
	[Token(Token = "0x4000350")]
	internal static readonly int _Out_SkyOcclusionL0L1; //Field offset: 0x14
	[Token(Token = "0x4000351")]
	internal static readonly int _Out_SkyShadingDirectionIndices; //Field offset: 0x18
	[Token(Token = "0x4000352")]
	internal static readonly int _Out_L2_0; //Field offset: 0x1C
	[Token(Token = "0x4000353")]
	internal static readonly int _Out_L2_1; //Field offset: 0x20
	[Token(Token = "0x4000354")]
	internal static readonly int _Out_L2_2; //Field offset: 0x24
	[Token(Token = "0x4000355")]
	internal static readonly int _Out_L2_3; //Field offset: 0x28
	[Token(Token = "0x4000356")]
	internal static readonly int _ProbeVolumeScratchBufferLayout; //Field offset: 0x2C
	[Token(Token = "0x4000357")]
	internal static readonly int _ProbeVolumeScratchBuffer; //Field offset: 0x30
	[Token(Token = "0x4000369")]
	private static ComputeShader s_DataUploadCS; //Field offset: 0x38
	[Token(Token = "0x400036A")]
	private static int s_DataUploadKernel; //Field offset: 0x40
	[Token(Token = "0x400036B")]
	private static ComputeShader s_DataUploadL2CS; //Field offset: 0x48
	[Token(Token = "0x400036C")]
	private static int s_DataUploadL2Kernel; //Field offset: 0x50
	[Token(Token = "0x400036D")]
	private static LocalKeyword s_DataUpload_Shared; //Field offset: 0x58
	[Token(Token = "0x400036E")]
	private static LocalKeyword s_DataUpload_ProbeOcclusion; //Field offset: 0x70
	[Token(Token = "0x400036F")]
	private static LocalKeyword s_DataUpload_SkyOcclusion; //Field offset: 0x88
	[Token(Token = "0x4000370")]
	private static LocalKeyword s_DataUpload_SkyShadingDirection; //Field offset: 0xA0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400035D")]
	private int <estimatedVMemCost>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400035F")]
	internal DataLocation m_Pool; //Field offset: 0x18
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000360")]
	private BrickChunkAlloc m_NextFreeChunk; //Field offset: 0x80
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000361")]
	private Stack<BrickChunkAlloc> m_FreeList; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000362")]
	private int m_AvailableChunkCount; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000363")]
	private ProbeVolumeSHBands m_SHBands; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000364")]
	private bool m_ContainsValidity; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA1")]
	[Token(Token = "0x4000365")]
	private bool m_ContainsProbeOcclusion; //Field offset: 0xA1
	[FieldOffset(Offset = "0xA2")]
	[Token(Token = "0x4000366")]
	private bool m_ContainsRenderingLayers; //Field offset: 0xA2
	[FieldOffset(Offset = "0xA3")]
	[Token(Token = "0x4000367")]
	private bool m_ContainsSkyOcclusion; //Field offset: 0xA3
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000368")]
	private bool m_ContainsSkyShadingDirection; //Field offset: 0xA4

	[Token(Token = "0x170000F2")]
	internal int estimatedVMemCost
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000885")]
		internal get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000886")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2C14990", Offset = "0x2C13D90", Length = "0x257")]
	[Token(Token = "0x60008A5")]
	private static ProbeBrickPool() { }

	[Address(RVA = "0x2C14BF0", Offset = "0x2C13FF0", Length = "0x162")]
	[Token(Token = "0x600088C")]
	internal ProbeBrickPool(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands, bool allocateValidityData = false, bool allocateRenderingLayerData = false, bool allocateSkyOcclusion = false, bool allocateSkyShadingData = false, bool allocateProbeOcclusionData = false) { }

	[Address(RVA = "0x2C11970", Offset = "0x2C10D70", Length = "0x280")]
	[Token(Token = "0x6000899")]
	internal bool Allocate(int numberOfBrickChunks, List<BrickChunkAlloc> outAllocations, bool ignoreErrorLog) { }

	[Address(RVA = "0x2C117E0", Offset = "0x2C10BE0", Length = "0x184")]
	[Token(Token = "0x600088D")]
	internal void AllocatePool(int width, int height, int depth) { }

	[Address(RVA = "0x2C11C00", Offset = "0x2C11000", Length = "0xB")]
	[Token(Token = "0x60008A4")]
	internal void Cleanup() { }

	[Address(RVA = "0x2C11C10", Offset = "0x2C11010", Length = "0x57")]
	[Token(Token = "0x6000897")]
	internal void Clear() { }

	[Address(RVA = "0x2C11C70", Offset = "0x2C11070", Length = "0x6B0")]
	[Token(Token = "0x60008A2")]
	public static DataLocation CreateDataLocation(int numProbes, bool compressed, ProbeVolumeSHBands bands, string name, bool allocateRendertexture, bool allocateValidityData, bool allocateRenderingLayers, bool allocateSkyOcclusionData, bool allocateSkyShadingDirectionData, bool allocateProbeOcclusionData, out int allocatedBytes) { }

	[Address(RVA = "0x2C12320", Offset = "0x2C11720", Length = "0x283")]
	[Token(Token = "0x60008A1")]
	public static Texture CreateDataTexture(int width, int height, int depth, GraphicsFormat format, string name, bool allocateRendertexture, ref int allocatedBytes) { }

	[Address(RVA = "0x2C125B0", Offset = "0x2C119B0", Length = "0x168")]
	[Token(Token = "0x600089A")]
	internal void Deallocate(List<BrickChunkAlloc> allocations) { }

	[Address(RVA = "0x2C12720", Offset = "0x2C11B20", Length = "0xD")]
	[Token(Token = "0x60008A3")]
	private static void DerivePoolSizeFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget, out int width, out int height, out int depth) { }

	[Address(RVA = "0x2C12730", Offset = "0x2C11B30", Length = "0xD")]
	[Token(Token = "0x6000884")]
	internal static int DivRoundUp(int x, int y) { }

	[Address(RVA = "0x2C12740", Offset = "0x2C11B40", Length = "0x85")]
	[Token(Token = "0x600088F")]
	internal void EnsureTextureValidity() { }

	[Address(RVA = "0x2C127D0", Offset = "0x2C11BD0", Length = "0xB5")]
	[Token(Token = "0x6000890")]
	internal bool EnsureTextureValidity(bool renderingLayers, bool skyOcclusion, bool skyDirection, bool probeOcclusion) { }

	[Address(RVA = "0x2C12A00", Offset = "0x2C11E00", Length = "0x34")]
	[Token(Token = "0x600089F")]
	private static int EstimateMemoryCost(int width, int height, int depth, GraphicsFormat format) { }

	[Address(RVA = "0x2C12890", Offset = "0x2C11C90", Length = "0x169")]
	[Token(Token = "0x60008A0")]
	internal static int EstimateMemoryCostForBlending(ProbeVolumeTextureMemoryBudget memoryBudget, bool compressed, ProbeVolumeSHBands bands) { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000885")]
	internal int get_estimatedVMemCost() { }

	[Address(RVA = "0x2C12A40", Offset = "0x2C11E40", Length = "0xD")]
	[Token(Token = "0x6000898")]
	internal static int GetChunkCount(int brickCount) { }

	[Address(RVA = "0x9DCD50", Offset = "0x9DC150", Length = "0x6")]
	[Token(Token = "0x6000891")]
	internal static int GetChunkSizeInBrickCount() { }

	[Address(RVA = "0x9E1970", Offset = "0x9E0D70", Length = "0x6")]
	[Token(Token = "0x6000892")]
	internal static int GetChunkSizeInProbeCount() { }

	[Address(RVA = "0x2C12A50", Offset = "0x2C11E50", Length = "0x15")]
	[Token(Token = "0x6000895")]
	internal Vector3Int GetPoolDimensions() { }

	[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
	[Token(Token = "0x6000894")]
	internal int GetPoolHeight() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[Token(Token = "0x6000893")]
	internal int GetPoolWidth() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x600088B")]
	internal Texture GetProbeOcclusionTexture() { }

	[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
	[Token(Token = "0x600088E")]
	public int GetRemainingChunkCount() { }

	[Address(RVA = "0x2C12A70", Offset = "0x2C11E70", Length = "0x672")]
	[Token(Token = "0x6000896")]
	internal void GetRuntimeResources(ref RuntimeResources rr) { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000889")]
	internal Texture GetSkyOcclusionTexture() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x600088A")]
	internal Texture GetSkyShadingDirectionIndicesTexture() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000888")]
	internal Texture GetValidityTexture() { }

	[Address(RVA = "0x2C130F0", Offset = "0x2C124F0", Length = "0x58A")]
	[Token(Token = "0x6000887")]
	internal static void Initialize() { }

	[Address(RVA = "0x2C13680", Offset = "0x2C12A80", Length = "0x71")]
	[Token(Token = "0x600089E")]
	internal static Vector3Int ProbeCountToDataLocSize(int numProbes) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000886")]
	private void set_estimatedVMemCost(int value) { }

	[Address(RVA = "0x2C143B0", Offset = "0x2C137B0", Length = "0x5D7")]
	[Token(Token = "0x600089B")]
	internal void Update(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands) { }

	[Address(RVA = "0x2C138E0", Offset = "0x2C12CE0", Length = "0xACF")]
	[Token(Token = "0x600089C")]
	internal void Update(CommandBuffer cmd, CellStreamingScratchBuffer dataBuffer, CellStreamingScratchBufferLayout layout, List<BrickChunkAlloc> dstLocations, bool updateSharedData, Texture validityTexture, ProbeVolumeSHBands bands, bool skyOcclusion, Texture skyOcclusionTexture, bool skyShadingDirections, Texture skyShadingDirectionsTexture, bool probeOcclusion) { }

	[Address(RVA = "0x2C13700", Offset = "0x2C12B00", Length = "0x1DE")]
	[Token(Token = "0x600089D")]
	internal void UpdateValidity(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex) { }

}

