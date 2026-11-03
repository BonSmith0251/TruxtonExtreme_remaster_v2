namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000597")]
internal class EntryPreProcessor
{
	[Token(Token = "0x2000598")]
	internal struct AllocSize
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001328")]
		public int vertexCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4001329")]
		public int indexCount; //Field offset: 0x4

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001320")]
	private int m_ChildrenIndex; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001321")]
	private List<AllocSize> m_Allocs; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001322")]
	private List<AllocSize> m_HeadAllocs; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001323")]
	private List<AllocSize> m_TailAllocs; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001324")]
	private List<Entry> m_FlattenedEntries; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001325")]
	private AllocSize m_Pending; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001326")]
	private Stack<AllocSize> m_Mask; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001327")]
	private bool m_IsPushingMask; //Field offset: 0x48

	[Token(Token = "0x17000A3F")]
	public int childrenIndex
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600286C")]
		 get { } //Length: 85
	}

	[Token(Token = "0x17000A42")]
	public List<Entry> flattenedEntries
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600286F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000A40")]
	public List<AllocSize> headAllocs
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600286D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000A41")]
	public List<AllocSize> tailAllocs
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600286E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x32F2DC0", Offset = "0x32F21C0", Length = "0x145")]
	[Token(Token = "0x6002875")]
	public EntryPreProcessor() { }

	[Address(RVA = "0x32F2490", Offset = "0x32F1890", Length = "0xD0")]
	[Token(Token = "0x6002873")]
	private void Add(int vertexCount, int indexCount) { }

	[Address(RVA = "0x32F2570", Offset = "0x32F1970", Length = "0x5F")]
	[Token(Token = "0x6002871")]
	public void ClearReferences() { }

	[Address(RVA = "0x32F25D0", Offset = "0x32F19D0", Length = "0x2E8")]
	[Token(Token = "0x6002872")]
	private void DoEvaluate(Entry entry) { }

	[Address(RVA = "0x32F28F0", Offset = "0x32F1CF0", Length = "0xA5")]
	[Token(Token = "0x6002874")]
	private void Flush() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x600286C")]
	public int get_childrenIndex() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600286F")]
	public List<Entry> get_flattenedEntries() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600286D")]
	public List<AllocSize> get_headAllocs() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600286E")]
	public List<AllocSize> get_tailAllocs() { }

	[Address(RVA = "0x32F29A0", Offset = "0x32F1DA0", Length = "0x3F0")]
	[Token(Token = "0x6002870")]
	public void PreProcess(Entry root) { }

}

