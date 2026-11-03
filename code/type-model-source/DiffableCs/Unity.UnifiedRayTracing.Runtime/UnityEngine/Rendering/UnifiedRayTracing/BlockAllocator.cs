namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x200003F")]
internal struct BlockAllocator : IDisposable
{
	[Token(Token = "0x2000041")]
	internal struct Allocation
	{
		[Token(Token = "0x400018C")]
		public static readonly Allocation Invalid; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400018A")]
		public int handle; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400018B")]
		public Block block; //Field offset: 0x4

		[Token(Token = "0x1700001A")]
		public bool valid
		{
			[Address(RVA = "0x2F4F840", Offset = "0x2F4EC40", Length = "0x7")]
			[IsReadOnly]
			[Token(Token = "0x60000DE")]
			 get { } //Length: 7
		}

		[Address(RVA = "0x2F4F7E0", Offset = "0x2F4EBE0", Length = "0x55")]
		[Token(Token = "0x60000DF")]
		private static Allocation() { }

		[Address(RVA = "0x2F4F840", Offset = "0x2F4EC40", Length = "0x7")]
		[IsReadOnly]
		[Token(Token = "0x60000DE")]
		public bool get_valid() { }

	}

	[Token(Token = "0x2000040")]
	internal struct Block
	{
		[Token(Token = "0x4000189")]
		public static readonly Block Invalid; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000187")]
		public int offset; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000188")]
		public int count; //Field offset: 0x4

		[Address(RVA = "0x2F515F0", Offset = "0x2F509F0", Length = "0x42")]
		[Token(Token = "0x60000DD")]
		private static Block() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000182")]
	private int m_FreeElementCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000183")]
	private int m_MaxElementCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000184")]
	private NativeList<Block> m_freeBlocks; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000185")]
	private NativeList<Block> m_usedBlocks; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000186")]
	private NativeList<Int32> m_freeSlots; //Field offset: 0x18

	[Token(Token = "0x17000019")]
	public int allocatedSize
	{
		[Address(RVA = "0x2D7FF50", Offset = "0x2D7F350", Length = "0x6")]
		[Token(Token = "0x60000D1")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000018")]
	public int capacity
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x60000D0")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000017")]
	public int freeBlocks
	{
		[Address(RVA = "0x2F515A0", Offset = "0x2F509A0", Length = "0x4B")]
		[Token(Token = "0x60000CF")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000016")]
	public int freeElementsCount
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60000CE")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x2F50570", Offset = "0x2F4F970", Length = "0x3E0")]
	[Token(Token = "0x60000D9")]
	public Allocation Allocate(int elementCounts) { }

	[Address(RVA = "0x2F50950", Offset = "0x2F4FD50", Length = "0x34")]
	[Token(Token = "0x60000D3")]
	private int CalculateGeometricGrowthCapacity(int desiredNewCapacity, int maxAllowedNewCapacity) { }

	[Address(RVA = "0x2F50990", Offset = "0x2F4FD90", Length = "0x9D")]
	[Token(Token = "0x60000D8")]
	public override void Dispose() { }

	[Address(RVA = "0x2F50A30", Offset = "0x2F4FE30", Length = "0x144")]
	[Token(Token = "0x60000DB")]
	public void FreeAllocation(in Allocation allocation) { }

	[Address(RVA = "0x2D7FF50", Offset = "0x2D7F350", Length = "0x6")]
	[Token(Token = "0x60000D1")]
	public int get_allocatedSize() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x60000D0")]
	public int get_capacity() { }

	[Address(RVA = "0x2F515A0", Offset = "0x2F509A0", Length = "0x4B")]
	[Token(Token = "0x60000CF")]
	public int get_freeBlocks() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x60000CE")]
	public int get_freeElementsCount() { }

	[Address(RVA = "0x2F50B80", Offset = "0x2F4FF80", Length = "0x160")]
	[Token(Token = "0x60000D5")]
	public bool GetExpectedGrowthToFitAllocation(int elementCounts, int maxAllowedCapacity, out int newCapacity) { }

	[Address(RVA = "0x2F50ED0", Offset = "0x2F502D0", Length = "0xFC")]
	[Token(Token = "0x60000D4")]
	public int Grow(int newDesiredCapacity, int maxAllowedCapacity = 2147483647) { }

	[Address(RVA = "0x2F50CE0", Offset = "0x2F500E0", Length = "0x4B")]
	[Token(Token = "0x60000D6")]
	public Allocation GrowAndAllocate(int elementCounts, out int oldCapacity, out int newCapacity) { }

	[Address(RVA = "0x2F50D30", Offset = "0x2F50130", Length = "0x192")]
	[Token(Token = "0x60000D7")]
	public Allocation GrowAndAllocate(int elementCounts, int maxAllowedCapacity, out int oldCapacity, out int newCapacity) { }

	[Address(RVA = "0x2F50FD0", Offset = "0x2F503D0", Length = "0x190")]
	[Token(Token = "0x60000D2")]
	public void Initialize(int maxElementCounts) { }

	[Address(RVA = "0x2F51160", Offset = "0x2F50560", Length = "0x160")]
	[Token(Token = "0x60000DA")]
	private int MergeBlockFrontBack(int freeBlockId) { }

	[Address(RVA = "0x2F512C0", Offset = "0x2F506C0", Length = "0x2D3")]
	[Token(Token = "0x60000DC")]
	public Allocation[] SplitAllocation(in Allocation allocation, int count) { }

}

