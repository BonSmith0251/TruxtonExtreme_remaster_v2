namespace Unity.Hierarchy;

[IsReadOnly]
[Token(Token = "0x200000C")]
public struct HierarchyNodeTypeHandlerBaseEnumerable
{
	[Token(Token = "0x200000D")]
	internal struct Enumerator : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001E")]
		private readonly IntPtr[] m_Handlers; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400001F")]
		private readonly int m_Count; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000020")]
		private int m_Index; //Field offset: 0xC

		[Token(Token = "0x17000006")]
		public HierarchyNodeTypeHandlerBase Current
		{
			[Address(RVA = "0x30D5360", Offset = "0x30D4760", Length = "0x6A")]
			[Token(Token = "0x6000038")]
			 get { } //Length: 106
		}

		[Address(RVA = "0x30D4EF0", Offset = "0x30D42F0", Length = "0x233")]
		[Token(Token = "0x6000036")]
		internal Enumerator(Hierarchy hierarchy) { }

		[Address(RVA = "0x30D4CB0", Offset = "0x30D40B0", Length = "0x7E")]
		[Token(Token = "0x6000037")]
		public override void Dispose() { }

		[Address(RVA = "0x30D5360", Offset = "0x30D4760", Length = "0x6A")]
		[Token(Token = "0x6000038")]
		public HierarchyNodeTypeHandlerBase get_Current() { }

		[Address(RVA = "0x195CA10", Offset = "0x195BE10", Length = "0xF")]
		[Token(Token = "0x6000039")]
		public bool MoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400001D")]
	private readonly Hierarchy m_Hierarchy; //Field offset: 0x0

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x6000034")]
	internal HierarchyNodeTypeHandlerBaseEnumerable(Hierarchy hierarchy) { }

	[Address(RVA = "0x30D6A90", Offset = "0x30D5E90", Length = "0x23")]
	[Token(Token = "0x6000035")]
	public Enumerator GetEnumerator() { }

}

