namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000F1")]
internal struct BuddyAllocator : IDisposable
{
	[Token(Token = "0x20000F2")]
	private struct Header
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000587")]
		public int branchingOrder; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000588")]
		public int levelCount; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000589")]
		public int allocationCount; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400058A")]
		public int freeAllocationIdsCount; //Field offset: 0xC

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000582")]
	private Void* m_Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000583")]
	private ValueTuple<Int32, Int32> m_ActiveFreeMaskCounts; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000584")]
	private ValueTuple<Int32, Int32> m_FreeMasksStorage; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000585")]
	private ValueTuple<Int32, Int32> m_FreeMaskIndicesStorage; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000586")]
	private Allocator m_Allocator; //Field offset: 0x20

	[Token(Token = "0x170001C1")]
	private NativeArray<Int32> freeMaskCounts
	{
		[Address(RVA = "0x2DA8BC0", Offset = "0x2DA7FC0", Length = "0x63")]
		[Token(Token = "0x600067B")]
		private get { } //Length: 99
	}

	[Token(Token = "0x170001C3")]
	private NativeArray<Int32> freeMaskIndicesStorage
	{
		[Address(RVA = "0x2DA8C30", Offset = "0x2DA8030", Length = "0x63")]
		[Token(Token = "0x600067E")]
		private get { } //Length: 99
	}

	[Token(Token = "0x170001C2")]
	private NativeArray<UInt64> freeMasksStorage
	{
		[Address(RVA = "0x2DA8CA0", Offset = "0x2DA80A0", Length = "0x63")]
		[Token(Token = "0x600067C")]
		private get { } //Length: 99
	}

	[Token(Token = "0x170001C0")]
	private Header header
	{
		[Address(RVA = "0x2DA8D10", Offset = "0x2DA8110", Length = "0x37")]
		[Token(Token = "0x600067A")]
		private get { } //Length: 55
	}

	[Token(Token = "0x170001C4")]
	public int levelCount
	{
		[Address(RVA = "0x2DA8D50", Offset = "0x2DA8150", Length = "0x3D")]
		[Token(Token = "0x6000680")]
		 get { } //Length: 61
	}

	[Address(RVA = "0x2DA89B0", Offset = "0x2DA7DB0", Length = "0x209")]
	[Token(Token = "0x6000681")]
	public BuddyAllocator(int levelCount, int branchingOrder, Allocator allocator = 4) { }

	[Address(RVA = "0x2DA7FF0", Offset = "0x2DA73F0", Length = "0x18")]
	[Token(Token = "0x600068B")]
	private static int AlignForward(int offset, int alignment) { }

	[Address(RVA = "0x79A960", Offset = "0x799D60", Length = "0x9C")]
	[Token(Token = "0x600068A")]
	private static ValueTuple<Int32, Int32> AllocateRange(int length, ref int dataSize) { }

	[Address(RVA = "0x2DA8010", Offset = "0x2DA7410", Length = "0x25")]
	[Token(Token = "0x6000684")]
	public override void Dispose() { }

	[Address(RVA = "0x2DA8360", Offset = "0x2DA7760", Length = "0x29A")]
	[Token(Token = "0x6000683")]
	public void Free(BuddyAllocation allocation) { }

	[Address(RVA = "0x2DA8040", Offset = "0x2DA7440", Length = "0x18C")]
	[Token(Token = "0x600067F")]
	private NativeArray<Int32> FreeMaskIndices(int level) { }

	[Address(RVA = "0x2DA81D0", Offset = "0x2DA75D0", Length = "0x18C")]
	[Token(Token = "0x600067D")]
	private NativeArray<UInt64> FreeMasks(int level) { }

	[Address(RVA = "0x2DA8BC0", Offset = "0x2DA7FC0", Length = "0x63")]
	[Token(Token = "0x600067B")]
	private NativeArray<Int32> get_freeMaskCounts() { }

	[Address(RVA = "0x2DA8C30", Offset = "0x2DA8030", Length = "0x63")]
	[Token(Token = "0x600067E")]
	private NativeArray<Int32> get_freeMaskIndicesStorage() { }

	[Address(RVA = "0x2DA8CA0", Offset = "0x2DA80A0", Length = "0x63")]
	[Token(Token = "0x600067C")]
	private NativeArray<UInt64> get_freeMasksStorage() { }

	[Address(RVA = "0x2DA8D10", Offset = "0x2DA8110", Length = "0x37")]
	[Token(Token = "0x600067A")]
	private Header get_header() { }

	[Address(RVA = "0x2DA8D50", Offset = "0x2DA8150", Length = "0x3D")]
	[Token(Token = "0x6000680")]
	public int get_levelCount() { }

	[Address(RVA = "0x79AB30", Offset = "0x799F30", Length = "0x8E")]
	[Token(Token = "0x6000685")]
	private NativeArray<T> GetNativeArray(int offset, int length) { }

	[Address(RVA = "0x2DA8630", Offset = "0x2DA7A30", Length = "0xD")]
	[Token(Token = "0x6000687")]
	private static int LevelLength(int level, int branchingOrder) { }

	[Address(RVA = "0x2DA8600", Offset = "0x2DA7A00", Length = "0x24")]
	[Token(Token = "0x6000689")]
	private static int LevelLength64(int level, int branchingOrder) { }

	[Address(RVA = "0x2DA86A0", Offset = "0x2DA7AA0", Length = "0x27")]
	[Token(Token = "0x6000686")]
	private static int LevelOffset(int level, int branchingOrder) { }

	[Address(RVA = "0x2DA8640", Offset = "0x2DA7A40", Length = "0x53")]
	[Token(Token = "0x6000688")]
	private static int LevelOffset64(int level, int branchingOrder) { }

	[Address(RVA = "0x2C61410", Offset = "0x2C60810", Length = "0x8")]
	[Token(Token = "0x600068D")]
	private static int Pow2(int n) { }

	[Address(RVA = "0x2DA86D0", Offset = "0x2DA7AD0", Length = "0xB")]
	[Token(Token = "0x600068E")]
	private static int Pow2N(int x, int n) { }

	[Address(RVA = "0x2DA86E0", Offset = "0x2DA7AE0", Length = "0x2B")]
	[Token(Token = "0x600068C")]
	private static Void* PtrAdd(Void* ptr, int bytes) { }

	[Address(RVA = "0x2DA8710", Offset = "0x2DA7B10", Length = "0x292")]
	[Token(Token = "0x6000682")]
	public bool TryAllocate(int requestedLevel, out BuddyAllocation allocation) { }

}

