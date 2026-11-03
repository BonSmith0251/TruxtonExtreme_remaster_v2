namespace MS.Internal.Xml.Cache;

[Token(Token = "0x2000288")]
internal sealed class XPathNodeInfoAtom
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E6A")]
	private string _localName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E6B")]
	private string _namespaceUri; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E6C")]
	private string _prefix; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E6D")]
	private XPathNode[] _pageParent; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E6E")]
	private XPathNode[] _pageSibling; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E6F")]
	private XPathDocument _doc; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E70")]
	private int _lineNumBase; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000E71")]
	private int _linePosBase; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E72")]
	private XPathNodePageInfo _pageInfo; //Field offset: 0x48

	[Token(Token = "0x170006DC")]
	public XPathDocument Document
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6001A11")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006DD")]
	public int LineNumberBase
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x6001A12")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170006DE")]
	public int LinePositionBase
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[Token(Token = "0x6001A13")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170006D7")]
	public string LocalName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6001A0C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006D8")]
	public string NamespaceUri
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001A0D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006D6")]
	public XPathNodePageInfo PageInfo
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6001A0B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006DB")]
	public XPathNode[] ParentPage
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6001A10")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006D9")]
	public string Prefix
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6001A0E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006DA")]
	public XPathNode[] SiblingPage
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6001A0F")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6001A11")]
	public XPathDocument get_Document() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x6001A12")]
	public int get_LineNumberBase() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[Token(Token = "0x6001A13")]
	public int get_LinePositionBase() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6001A0C")]
	public string get_LocalName() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001A0D")]
	public string get_NamespaceUri() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6001A0B")]
	public XPathNodePageInfo get_PageInfo() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6001A10")]
	public XPathNode[] get_ParentPage() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6001A0E")]
	public string get_Prefix() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6001A0F")]
	public XPathNode[] get_SiblingPage() { }

}

