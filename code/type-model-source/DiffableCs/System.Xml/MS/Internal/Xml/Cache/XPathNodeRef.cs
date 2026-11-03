namespace MS.Internal.Xml.Cache;

[Token(Token = "0x2000285")]
internal struct XPathNodeRef
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E65")]
	private XPathNode[] _page; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000E66")]
	private int _idx; //Field offset: 0x8

	[Token(Token = "0x170006D2")]
	public int Index
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6001A00")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170006D1")]
	public XPathNode[] Page
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60019FF")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xAEE5F0", Offset = "0xAED9F0", Length = "0x26")]
	[Token(Token = "0x60019FE")]
	public XPathNodeRef(XPathNode[] page, int idx) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6001A00")]
	public int get_Index() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60019FF")]
	public XPathNode[] get_Page() { }

	[Address(RVA = "0x24DA8D0", Offset = "0x24D9CD0", Length = "0x3F")]
	[Token(Token = "0x6001A01")]
	public virtual int GetHashCode() { }

}

