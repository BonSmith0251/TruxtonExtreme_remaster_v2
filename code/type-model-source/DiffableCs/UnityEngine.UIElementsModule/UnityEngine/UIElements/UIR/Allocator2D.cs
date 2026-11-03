namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000574")]
internal class Allocator2D
{
	[Token(Token = "0x2000577")]
	internal struct Alloc2D
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001229")]
		public RectInt rect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400122A")]
		public Row row; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400122B")]
		public Alloc alloc; //Field offset: 0x18

		[Address(RVA = "0x32D4570", Offset = "0x32D3970", Length = "0xE0")]
		[Token(Token = "0x60027CA")]
		public Alloc2D(Row row, Alloc alloc, int width, int height) { }

	}

	[Token(Token = "0x2000575")]
	internal class Area
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001221")]
		public RectInt rect; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001222")]
		public BestFitAllocator allocator; //Field offset: 0x20

		[Address(RVA = "0x32D5680", Offset = "0x32D4A80", Length = "0x9F")]
		[Token(Token = "0x60027C5")]
		public Area(RectInt rect) { }

	}

	[Token(Token = "0x2000576")]
	internal class Row : LinkedPoolItem<Row>
	{
		[Token(Token = "0x4001228")]
		public static readonly LinkedPool<Row> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001223")]
		public RectInt rect; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001224")]
		public Area area; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001225")]
		public BestFitAllocator allocator; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001226")]
		public Alloc alloc; //Field offset: 0x38
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4001227")]
		public Row next; //Field offset: 0x50

		[Address(RVA = "0x32DDFB0", Offset = "0x32DD3B0", Length = "0x11E")]
		[Token(Token = "0x60027C9")]
		private static Row() { }

		[Address(RVA = "0x32DE0D0", Offset = "0x32DD4D0", Length = "0x39")]
		[Token(Token = "0x60027C8")]
		public Row() { }

		[Address(RVA = "0x32DDED0", Offset = "0x32DD2D0", Length = "0x65")]
		[Token(Token = "0x60027C6")]
		private static Row Create() { }

		[Address(RVA = "0x32DDF40", Offset = "0x32DD340", Length = "0x61")]
		[Token(Token = "0x60027C7")]
		private static void Reset(Row row) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400121B")]
	private readonly Vector2Int m_MinSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400121C")]
	private readonly Vector2Int m_MaxSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400121D")]
	private readonly Vector2Int m_MaxAllocSize; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400121E")]
	private readonly int m_RowHeightBias; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400121F")]
	private readonly Row[] m_Rows; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001220")]
	private readonly List<Area> m_Areas; //Field offset: 0x38

	[Address(RVA = "0x32D5350", Offset = "0x32D4750", Length = "0x32E")]
	[Token(Token = "0x60027BF")]
	public Allocator2D(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias) { }

	[Address(RVA = "0x32D4660", Offset = "0x32D3A60", Length = "0x251")]
	[Token(Token = "0x60027C2")]
	private static void BuildAreas(List<Area> areas, Vector2Int minSize, Vector2Int maxSize) { }

	[Address(RVA = "0x32D48C0", Offset = "0x32D3CC0", Length = "0x6F")]
	[Token(Token = "0x60027C4")]
	private static Row[] BuildRowArray(int maxRowHeight, int rowHeightBias) { }

	[Address(RVA = "0x32D4930", Offset = "0x32D3D30", Length = "0x114")]
	[Token(Token = "0x60027C3")]
	private static Vector2Int ComputeMaxAllocSize(List<Area> areas, int rowHeightBias) { }

	[Address(RVA = "0x32D4A50", Offset = "0x32D3E50", Length = "0x28C")]
	[Token(Token = "0x60027C1")]
	public void Free(Alloc2D alloc2D) { }

	[Address(RVA = "0x32D4CE0", Offset = "0x32D40E0", Length = "0x66B")]
	[Token(Token = "0x60027C0")]
	public bool TryAllocate(int width, int height, out Alloc2D alloc2D) { }

}

