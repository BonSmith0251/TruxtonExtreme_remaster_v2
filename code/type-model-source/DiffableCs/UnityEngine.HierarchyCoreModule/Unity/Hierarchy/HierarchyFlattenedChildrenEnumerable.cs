namespace Unity.Hierarchy;

[IsReadOnly]
[Token(Token = "0x2000004")]
public struct HierarchyFlattenedChildrenEnumerable
{
	[Token(Token = "0x2000005")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000004")]
		private readonly HierarchyFlattenedChildrenEnumerable m_Enumerable; //Field offset: 0x0
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000005")]
		private readonly int m_End; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4000006")]
		private readonly int m_Depth; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000007")]
		private readonly int m_Version; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000008")]
		private int m_Current; //Field offset: 0x3C

		[IsReadOnly]
		[Token(Token = "0x17000001")]
		public HierarchyFlattenedNode Current
		{
			[Address(RVA = "0x30D53D0", Offset = "0x30D47D0", Length = "0x5C")]
			[Token(Token = "0x6000006")]
			 get { } //Length: 92
		}

		[Address(RVA = "0x30D5130", Offset = "0x30D4530", Length = "0x56")]
		[Token(Token = "0x6000005")]
		internal Enumerator(HierarchyFlattenedChildrenEnumerable enumerable) { }

		[Address(RVA = "0x30D53D0", Offset = "0x30D47D0", Length = "0x5C")]
		[Token(Token = "0x6000006")]
		public HierarchyFlattenedNode get_Current() { }

		[Address(RVA = "0x30D4D40", Offset = "0x30D4140", Length = "0x8C")]
		[Token(Token = "0x6000007")]
		public bool MoveNext() { }

		[Address(RVA = "0x30D4320", Offset = "0x30D3720", Length = "0x70")]
		[Token(Token = "0x6000008")]
		private void ThrowIfVersionChanged() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	private readonly HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000002")]
	private readonly HierarchyFlattenedNode m_ParentNode; //Field offset: 0x8
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000003")]
	private readonly int m_ParentIndex; //Field offset: 0x2C

	[Address(RVA = "0x30D58A0", Offset = "0x30D4CA0", Length = "0x27E")]
	[Token(Token = "0x6000003")]
	internal HierarchyFlattenedChildrenEnumerable(HierarchyFlattened hierarchyFlattened, in HierarchyNode node) { }

	[Address(RVA = "0x30D5830", Offset = "0x30D4C30", Length = "0x63")]
	[Token(Token = "0x6000004")]
	public Enumerator GetEnumerator() { }

}

