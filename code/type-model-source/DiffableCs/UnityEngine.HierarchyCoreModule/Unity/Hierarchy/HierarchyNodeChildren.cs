namespace Unity.Hierarchy;

[DefaultMember("Item")]
[IsReadOnly]
[Token(Token = "0x2000006")]
public struct HierarchyNodeChildren
{
	[Token(Token = "0x2000007")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400000D")]
		private readonly HierarchyNodeChildren m_Enumerable; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400000E")]
		private int m_Index; //Field offset: 0x18

		[IsReadOnly]
		[Token(Token = "0x17000002")]
		public HierarchyNode Current
		{
			[Address(RVA = "0x30D4490", Offset = "0x30D3890", Length = "0x1C6")]
			[Token(Token = "0x600000D")]
			 get { } //Length: 454
		}

		[Address(RVA = "0x30D5240", Offset = "0x30D4640", Length = "0x2D")]
		[Token(Token = "0x600000C")]
		internal Enumerator(in HierarchyNodeChildren enumerable) { }

		[Address(RVA = "0x30D4490", Offset = "0x30D3890", Length = "0x1C6")]
		[Token(Token = "0x600000D")]
		public HierarchyNode get_Current() { }

		[Address(RVA = "0x30D4D30", Offset = "0x30D4130", Length = "0xF")]
		[Token(Token = "0x600000E")]
		public bool MoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000009")]
	private readonly Hierarchy m_Hierarchy; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400000A")]
	private readonly HierarchyNode* m_Ptr; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000B")]
	private readonly int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400000C")]
	private readonly int m_Count; //Field offset: 0x14

	[Address(RVA = "0x30D6910", Offset = "0x30D5D10", Length = "0x175")]
	[Token(Token = "0x6000009")]
	internal HierarchyNodeChildren(Hierarchy hierarchy, IntPtr nodeChildrenPtr) { }

	[Address(RVA = "0x30D68D0", Offset = "0x30D5CD0", Length = "0x3A")]
	[Token(Token = "0x600000A")]
	public Enumerator GetEnumerator() { }

	[Address(RVA = "0x30D4660", Offset = "0x30D3A60", Length = "0x306")]
	[Token(Token = "0x600000B")]
	private void ThrowIfVersionChanged() { }

}

