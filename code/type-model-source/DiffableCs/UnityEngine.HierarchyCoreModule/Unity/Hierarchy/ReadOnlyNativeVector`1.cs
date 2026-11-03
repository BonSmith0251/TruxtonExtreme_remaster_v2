namespace Unity.Hierarchy;

[DefaultMember("Item")]
[IsReadOnly]
[Token(Token = "0x2000015")]
internal struct ReadOnlyNativeVector
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002D")]
	private readonly IntPtr m_Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002E")]
	private readonly int m_Count; //Field offset: 0x0

	[Token(Token = "0x17000008")]
	public int Count
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x600004F")]
		 get { } //Length: 4
	}

	[IsReadOnly]
	[Token(Token = "0x17000009")]
	public T Item
	{
		[Address(RVA = "0xF19970", Offset = "0xF18D70", Length = "0x72")]
		[Token(Token = "0x6000051")]
		 get { } //Length: 114
	}

	[Address(RVA = "0xAEE300", Offset = "0xAED700", Length = "0x8")]
	[Token(Token = "0x6000050")]
	public ReadOnlyNativeVector`1(IntPtr ptr, int size) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x600004F")]
	public int get_Count() { }

	[Address(RVA = "0xF19970", Offset = "0xF18D70", Length = "0x72")]
	[Token(Token = "0x6000051")]
	public T get_Item(int index) { }

}

