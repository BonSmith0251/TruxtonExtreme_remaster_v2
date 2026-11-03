namespace UnityEngine.Rendering;

[Token(Token = "0x20000F4")]
internal class ProbeBrickIndex
{
	[DebuggerDisplay("Brick [{position}, {subdivisionLevel}]")]
	[Token(Token = "0x20000F5")]
	internal struct Brick : IEquatable<Brick>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000341")]
		public Vector3Int position; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000342")]
		public int subdivisionLevel; //Field offset: 0xC

		[Address(RVA = "0xAEE530", Offset = "0xAED930", Length = "0x13")]
		[Token(Token = "0x6000880")]
		internal Brick(Vector3Int position, int subdivisionLevel) { }

		[Address(RVA = "0x2C0A840", Offset = "0x2C09C40", Length = "0x6A")]
		[Token(Token = "0x6000881")]
		public override bool Equals(Brick other) { }

		[Address(RVA = "0x2C0A8B0", Offset = "0x2C09CB0", Length = "0x242")]
		[Token(Token = "0x6000882")]
		public bool IntersectArea(Bounds boundInBricksToCheck) { }

	}

	[Token(Token = "0x20000F7")]
	internal struct CellIndexUpdateInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400034A")]
		public IndirectionEntryUpdateInfo[] entriesInfo; //Field offset: 0x0

		[Address(RVA = "0x2C0B610", Offset = "0x2C0AA10", Length = "0x51")]
		[Token(Token = "0x6000883")]
		public int GetNumberOfChunks() { }

	}

	[Token(Token = "0x20000F6")]
	internal struct IndirectionEntryUpdateInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000343")]
		public int firstChunkIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000344")]
		public int numberOfChunks; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000345")]
		public int minSubdivInCell; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000346")]
		public Vector3Int minValidBrickIndexForCellAtMaxRes; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000347")]
		public Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000348")]
		public Vector3Int entryPositionInBricksAtMaxRes; //Field offset: 0x24
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000349")]
		public bool hasOnlyBiggerBricks; //Field offset: 0x30

	}

	[Token(Token = "0x400032F")]
	internal const int kMaxSubdivisionLevels = 7; //Field offset: 0x0
	[Token(Token = "0x4000330")]
	internal const int kIndexChunkSize = 243; //Field offset: 0x0
	[Token(Token = "0x4000331")]
	internal const int kFailChunkIndex = -1; //Field offset: 0x0
	[Token(Token = "0x4000332")]
	internal const int kEmptyIndex = -2; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000333")]
	private BitArray m_IndexChunks; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000334")]
	private BitArray m_IndexChunksCopyForChecks; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000335")]
	private int m_ChunksCount; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000336")]
	private int m_AvailableChunkCount; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000337")]
	private ComputeBuffer m_PhysicalIndexBuffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000338")]
	private NativeArray<Int32> m_PhysicalIndexBufferData; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000339")]
	private ComputeBuffer m_DebugFragmentationBuffer; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400033A")]
	private Int32[] m_DebugFragmentationData; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400033B")]
	private bool m_NeedUpdateIndexComputeBuffer; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400033C")]
	private int m_UpdateMinIndex; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400033D")]
	private int m_UpdateMaxIndex; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400033E")]
	private int <estimatedVMemCost>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400033F")]
	private float <fragmentationRate>k__BackingField; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000340")]
	private Vector3Int m_CenterRS; //Field offset: 0x64

	[Token(Token = "0x170000F0")]
	internal int estimatedVMemCost
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000869")]
		internal get { } //Length: 4
		[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600086A")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170000F1")]
	internal float fragmentationRate
	{
		[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600086C")]
		internal get { } //Length: 6
		[Address(RVA = "0x1CC5D40", Offset = "0x1CC5140", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x600086D")]
		private set { } //Length: 6
	}

	[Address(RVA = "0x2C11560", Offset = "0x2C10960", Length = "0x27D")]
	[Token(Token = "0x600086F")]
	internal ProbeBrickIndex(ProbeVolumeTextureMemoryBudget memoryBudget) { }

	[Address(RVA = "0x2C0FFE0", Offset = "0x2C0F3E0", Length = "0x4BE")]
	[Token(Token = "0x600087E")]
	public void AddBricks(CellIndexInfo cellInfo, NativeArray<Brick> bricks, List<BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight) { }

	[Address(RVA = "0x2C104A0", Offset = "0x2C0F8A0", Length = "0x37")]
	[Token(Token = "0x600087B")]
	internal static bool BrickOverlapEntry(Vector3Int brickMin, Vector3Int brickMax, Vector3Int entryMin, Vector3Int entryMax) { }

	[Address(RVA = "0x2C104E0", Offset = "0x2C0F8E0", Length = "0x9D")]
	[Token(Token = "0x6000875")]
	internal void Cleanup() { }

	[Address(RVA = "0x2C10580", Offset = "0x2C0F980", Length = "0x8C")]
	[Token(Token = "0x6000873")]
	internal void Clear() { }

	[Address(RVA = "0x2C10610", Offset = "0x2C0FA10", Length = "0x75")]
	[Token(Token = "0x6000876")]
	internal void ComputeFragmentationRate() { }

	[Address(RVA = "0x2C10690", Offset = "0x2C0FA90", Length = "0x3B3")]
	[Token(Token = "0x6000879")]
	internal bool FindSlotsForEntries(ref IndirectionEntryUpdateInfo[] entriesInfo) { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000869")]
	internal int get_estimatedVMemCost() { }

	[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600086C")]
	internal float get_fragmentationRate() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600086B")]
	internal ComputeBuffer GetDebugFragmentationBuffer() { }

	[Address(RVA = "0x2C10A50", Offset = "0x2C0FE50", Length = "0x5F")]
	[Token(Token = "0x6000878")]
	internal int GetNumberOfChunks(int brickCount) { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000870")]
	public int GetRemainingChunkCount() { }

	[Address(RVA = "0x2C10AB0", Offset = "0x2C0FEB0", Length = "0x163")]
	[Token(Token = "0x6000874")]
	internal void GetRuntimeResources(ref RuntimeResources rr) { }

	[Address(RVA = "0x2C10C20", Offset = "0x2C10020", Length = "0x10")]
	[Token(Token = "0x600087C")]
	private static int LocationToIndex(int x, int y, int z, Vector3Int sizeOfValid) { }

	[Address(RVA = "0x2C10C30", Offset = "0x2C10030", Length = "0x495")]
	[Token(Token = "0x600087D")]
	private void MarkBrickInPhysicalBuffer(in IndirectionEntryUpdateInfo entry, Vector3Int brickMin, Vector3Int brickMax, int brickSubdivLevel, int entrySubdivLevel, int idx) { }

	[Address(RVA = "0x2C110D0", Offset = "0x2C104D0", Length = "0x12")]
	[Token(Token = "0x6000877")]
	private int MergeIndex(int index, int size) { }

	[Address(RVA = "0x2C110F0", Offset = "0x2C104F0", Length = "0xD9")]
	[Token(Token = "0x600087F")]
	public void RemoveBricks(CellIndexInfo cellInfo) { }

	[Address(RVA = "0x2C111D0", Offset = "0x2C105D0", Length = "0x13A")]
	[Token(Token = "0x600087A")]
	internal bool ReserveChunks(IndirectionEntryUpdateInfo[] entriesInfo, bool ignoreErrorLog) { }

	[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600086A")]
	private void set_estimatedVMemCost(int value) { }

	[Address(RVA = "0x1CC5D40", Offset = "0x1CC5140", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x600086D")]
	private void set_fragmentationRate(float value) { }

	[Address(RVA = "0x2C11310", Offset = "0x2C10710", Length = "0x30")]
	[Token(Token = "0x600086E")]
	private int SizeOfPhysicalIndexFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget) { }

	[Address(RVA = "0x2C11340", Offset = "0x2C10740", Length = "0x19B")]
	[Token(Token = "0x6000872")]
	private void UpdateDebugData() { }

	[Address(RVA = "0x2C114E0", Offset = "0x2C108E0", Length = "0x7D")]
	[Token(Token = "0x6000871")]
	internal void UploadIndexData() { }

}

