namespace UnityEngine.Timeline;

[Token(Token = "0x200003C")]
internal class IntervalTree
{
	[Token(Token = "0x200003D")]
	public struct Entry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011B")]
		public long intervalStart; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011C")]
		public long intervalEnd; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011D")]
		public T item; //Field offset: 0x0

	}

	[Token(Token = "0x4000115")]
	private const int kMinNodeSize = 10; //Field offset: 0x0
	[Token(Token = "0x4000116")]
	private const int kInvalidNode = -1; //Field offset: 0x0
	[Token(Token = "0x4000117")]
	private const long kCenterUnknown = 9223372036854775807; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000118")]
	private readonly List<Entry<T>> m_Entries; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000119")]
	private readonly List<IntervalTreeNode> m_Nodes; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400011A")]
	private bool <dirty>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x170000A2")]
	public internal bool dirty
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000246")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000247")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0xA9A570", Offset = "0xA99970", Length = "0xD9")]
	[Token(Token = "0x6000251")]
	public IntervalTree`1() { }

	[Address(RVA = "0xA96E80", Offset = "0xA96280", Length = "0x187")]
	[Token(Token = "0x6000248")]
	public void Add(T item) { }

	[Address(RVA = "0xA97470", Offset = "0xA96870", Length = "0x6D")]
	[Token(Token = "0x6000250")]
	public void Clear() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000246")]
	public bool get_dirty() { }

	[Address(RVA = "0xA97780", Offset = "0xA96B80", Length = "0xFE")]
	[Token(Token = "0x6000249")]
	public void IntersectsWith(long value, List<T> results) { }

	[Address(RVA = "0xA97650", Offset = "0xA96A50", Length = "0x126")]
	[Token(Token = "0x600024A")]
	public void IntersectsWithRange(long start, long end, List<T> results) { }

	[Address(RVA = "0xA980C0", Offset = "0xA974C0", Length = "0x252")]
	[Token(Token = "0x600024C")]
	private void Query(IntervalTreeNode intervalTreeNode, long value, List<T> results) { }

	[Address(RVA = "0xA979D0", Offset = "0xA96DD0", Length = "0x25C")]
	[Token(Token = "0x600024D")]
	private void QueryRange(IntervalTreeNode intervalTreeNode, long start, long end, List<T> results) { }

	[Address(RVA = "0xA98880", Offset = "0xA97C80", Length = "0xCA")]
	[Token(Token = "0x600024E")]
	private void Rebuild() { }

	[Address(RVA = "0xA98950", Offset = "0xA97D50", Length = "0x641")]
	[Token(Token = "0x600024F")]
	private int Rebuild(int start, int end) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000247")]
	internal void set_dirty(bool value) { }

	[Address(RVA = "0xA9A220", Offset = "0xA99620", Length = "0x26F")]
	[Token(Token = "0x600024B")]
	public void UpdateIntervals() { }

}

