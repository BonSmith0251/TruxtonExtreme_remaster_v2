namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x200060B")]
internal struct LayoutDataStore : IDisposable
{
	[Token(Token = "0x200060C")]
	private struct Chunk
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4001617")]
		public Byte* Buffer; //Field offset: 0x0

	}

	[Token(Token = "0x200060D")]
	public struct ComponentDataStore : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001618")]
		public readonly MemoryLabel MemoryLabel; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001619")]
		public int Size; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400161A")]
		public int ComponentCountPerChunk; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400161B")]
		public int ChunkCount; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x400161C")]
		private Chunk* m_Chunks; //Field offset: 0x20

		[Address(RVA = "0x3317F60", Offset = "0x3317360", Length = "0x23")]
		[Token(Token = "0x6002B61")]
		public ComponentDataStore(int size, MemoryLabel allocLabel) { }

		[Address(RVA = "0x3317C30", Offset = "0x3317030", Length = "0xA1")]
		[Token(Token = "0x6002B62")]
		public override void Dispose() { }

		[Address(RVA = "0x3317CE0", Offset = "0x33170E0", Length = "0x2F")]
		[Token(Token = "0x6002B63")]
		public Byte* GetComponentDataPtr(int index) { }

		[Address(RVA = "0x3317D10", Offset = "0x3317110", Length = "0x24F")]
		[Token(Token = "0x6002B64")]
		public void ResizeCapacity(int capacity) { }

	}

	[Token(Token = "0x200060E")]
	private struct Data
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400161D")]
		public int Capacity; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400161E")]
		public int NextFreeIndex; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400161F")]
		public int ComponentCount; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4001620")]
		public Int32* Versions; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x4001621")]
		public ComponentDataStore* Components; //Field offset: 0x18

	}

	[Token(Token = "0x4001614")]
	private const int k_ChunkSize = 32768; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001615")]
	private readonly MemoryLabel m_MemoryLabel; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4001616")]
	private Data* m_Data; //Field offset: 0x10

	[Address(RVA = "0x331D820", Offset = "0x331CC20", Length = "0x325")]
	[Token(Token = "0x6002B54")]
	public LayoutDataStore(ComponentType[] components, ReadOnlySpan<MemoryLabel> labels, int initialCapacity, Allocator allocator) { }

	[Address(RVA = "0x331CF10", Offset = "0x331C310", Length = "0x23F")]
	[Token(Token = "0x6002B58")]
	private LayoutHandle Allocate(Byte** data, int count) { }

	[Address(RVA = "0x851840", Offset = "0x850C40", Length = "0x32")]
	[Token(Token = "0x6002B5F")]
	public LayoutHandle Allocate(in T0 component0) { }

	[Address(RVA = "0x8517F0", Offset = "0x850BF0", Length = "0x43")]
	[Token(Token = "0x6002B60")]
	public LayoutHandle Allocate(in T0 component0, in T1 component1, in T2 component2, in T3 component3) { }

	[Address(RVA = "0x331D150", Offset = "0x331C550", Length = "0x173")]
	[Token(Token = "0x6002B55")]
	public override void Dispose() { }

	[Address(RVA = "0x331D2D0", Offset = "0x331C6D0", Length = "0x3D")]
	[Token(Token = "0x6002B56")]
	public bool Exists(in LayoutHandle handle) { }

	[Address(RVA = "0x331D310", Offset = "0x331C710", Length = "0x12F")]
	[Token(Token = "0x6002B59")]
	public void Free(in LayoutHandle handle) { }

	[Address(RVA = "0x331D440", Offset = "0x331C840", Length = "0x4A")]
	[IsReadOnly]
	[Token(Token = "0x6002B57")]
	internal Void* GetComponentDataPtr(int index, int componentIndex) { }

	[Address(RVA = "0x331D490", Offset = "0x331C890", Length = "0x35")]
	[Token(Token = "0x6002B5B")]
	private static int GetNextFreeIndex(ComponentDataStore* ptr, int index) { }

	[Address(RVA = "0x331D4D0", Offset = "0x331C8D0", Length = "0x31")]
	[Token(Token = "0x6002B5C")]
	private void IncreaseCapacity() { }

	[Address(RVA = "0x331D510", Offset = "0x331C910", Length = "0xEE")]
	[Token(Token = "0x6002B5E")]
	private static Void* ResizeArray(Void* fromPtr, long fromCount, long toCount, long size, int align, MemoryLabel label) { }

	[Address(RVA = "0x331D600", Offset = "0x331CA00", Length = "0x1D7")]
	[Token(Token = "0x6002B5D")]
	private void ResizeCapacity(int capacity) { }

	[Address(RVA = "0x331D7E0", Offset = "0x331CBE0", Length = "0x35")]
	[Token(Token = "0x6002B5A")]
	private static void SetNextFreeIndex(ComponentDataStore* ptr, int index, int value) { }

}

