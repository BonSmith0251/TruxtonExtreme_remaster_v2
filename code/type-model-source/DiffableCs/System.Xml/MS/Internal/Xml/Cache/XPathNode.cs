namespace MS.Internal.Xml.Cache;

[Token(Token = "0x2000284")]
internal struct XPathNode
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E5E")]
	private XPathNodeInfoAtom _info; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000E5F")]
	private ushort _idxSibling; //Field offset: 0x8
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x4000E60")]
	private ushort _idxParent; //Field offset: 0xA
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000E61")]
	private ushort _idxSimilar; //Field offset: 0xC
	[FieldOffset(Offset = "0xE")]
	[Token(Token = "0x4000E62")]
	private ushort _posOffset; //Field offset: 0xE
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E63")]
	private uint _props; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E64")]
	private string _value; //Field offset: 0x18

	[Token(Token = "0x170006C9")]
	public int CollapsedLinePosition
	{
		[Address(RVA = "0x24DA990", Offset = "0x24D9D90", Length = "0x23")]
		[Token(Token = "0x60019F4")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170006C6")]
	public XPathDocument Document
	{
		[Address(RVA = "0x24DA9C0", Offset = "0x24D9DC0", Length = "0x1A")]
		[Token(Token = "0x60019F1")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170006CD")]
	public bool HasCollapsedText
	{
		[Address(RVA = "0x24DA9E0", Offset = "0x24D9DE0", Length = "0xB")]
		[Token(Token = "0x60019FA")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170006CF")]
	public bool HasNamespaceDecls
	{
		[Address(RVA = "0x24DA9F0", Offset = "0x24D9DF0", Length = "0xB")]
		[Token(Token = "0x60019FC")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170006CC")]
	public bool HasSibling
	{
		[Address(RVA = "0x24DAA00", Offset = "0x24D9E00", Length = "0x9")]
		[Token(Token = "0x60019F9")]
		 get { } //Length: 9
	}

	[Token(Token = "0x170006CE")]
	public bool IsText
	{
		[Address(RVA = "0x24DAA10", Offset = "0x24D9E10", Length = "0x4E")]
		[Token(Token = "0x60019FB")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170006CB")]
	public bool IsXmlNamespaceNode
	{
		[Address(RVA = "0x24DAA60", Offset = "0x24D9E60", Length = "0x67")]
		[Token(Token = "0x60019F8")]
		 get { } //Length: 103
	}

	[Token(Token = "0x170006C7")]
	public int LineNumber
	{
		[Address(RVA = "0x24DAAD0", Offset = "0x24D9ED0", Length = "0x24")]
		[Token(Token = "0x60019F2")]
		 get { } //Length: 36
	}

	[Token(Token = "0x170006C8")]
	public int LinePosition
	{
		[Address(RVA = "0x24DAB00", Offset = "0x24D9F00", Length = "0x1D")]
		[Token(Token = "0x60019F3")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170006C4")]
	public string LocalName
	{
		[Address(RVA = "0x1E648C0", Offset = "0x1E63CC0", Length = "0x1A")]
		[Token(Token = "0x60019EF")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170006C5")]
	public string NamespaceUri
	{
		[Address(RVA = "0x24DAB20", Offset = "0x24D9F20", Length = "0x1A")]
		[Token(Token = "0x60019F0")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170006C2")]
	public XPathNodeType NodeType
	{
		[Address(RVA = "0x24DAB40", Offset = "0x24D9F40", Length = "0x7")]
		[Token(Token = "0x60019ED")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170006CA")]
	public XPathNodePageInfo PageInfo
	{
		[Address(RVA = "0x24DAB50", Offset = "0x24D9F50", Length = "0x1A")]
		[Token(Token = "0x60019F5")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170006C3")]
	public string Prefix
	{
		[Address(RVA = "0x24DAB70", Offset = "0x24D9F70", Length = "0x1A")]
		[Token(Token = "0x60019EE")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170006D0")]
	public string Value
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60019FD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x24DA990", Offset = "0x24D9D90", Length = "0x23")]
	[Token(Token = "0x60019F4")]
	public int get_CollapsedLinePosition() { }

	[Address(RVA = "0x24DA9C0", Offset = "0x24D9DC0", Length = "0x1A")]
	[Token(Token = "0x60019F1")]
	public XPathDocument get_Document() { }

	[Address(RVA = "0x24DA9E0", Offset = "0x24D9DE0", Length = "0xB")]
	[Token(Token = "0x60019FA")]
	public bool get_HasCollapsedText() { }

	[Address(RVA = "0x24DA9F0", Offset = "0x24D9DF0", Length = "0xB")]
	[Token(Token = "0x60019FC")]
	public bool get_HasNamespaceDecls() { }

	[Address(RVA = "0x24DAA00", Offset = "0x24D9E00", Length = "0x9")]
	[Token(Token = "0x60019F9")]
	public bool get_HasSibling() { }

	[Address(RVA = "0x24DAA10", Offset = "0x24D9E10", Length = "0x4E")]
	[Token(Token = "0x60019FB")]
	public bool get_IsText() { }

	[Address(RVA = "0x24DAA60", Offset = "0x24D9E60", Length = "0x67")]
	[Token(Token = "0x60019F8")]
	public bool get_IsXmlNamespaceNode() { }

	[Address(RVA = "0x24DAAD0", Offset = "0x24D9ED0", Length = "0x24")]
	[Token(Token = "0x60019F2")]
	public int get_LineNumber() { }

	[Address(RVA = "0x24DAB00", Offset = "0x24D9F00", Length = "0x1D")]
	[Token(Token = "0x60019F3")]
	public int get_LinePosition() { }

	[Address(RVA = "0x1E648C0", Offset = "0x1E63CC0", Length = "0x1A")]
	[Token(Token = "0x60019EF")]
	public string get_LocalName() { }

	[Address(RVA = "0x24DAB20", Offset = "0x24D9F20", Length = "0x1A")]
	[Token(Token = "0x60019F0")]
	public string get_NamespaceUri() { }

	[Address(RVA = "0x24DAB40", Offset = "0x24D9F40", Length = "0x7")]
	[Token(Token = "0x60019ED")]
	public XPathNodeType get_NodeType() { }

	[Address(RVA = "0x24DAB50", Offset = "0x24D9F50", Length = "0x1A")]
	[Token(Token = "0x60019F5")]
	public XPathNodePageInfo get_PageInfo() { }

	[Address(RVA = "0x24DAB70", Offset = "0x24D9F70", Length = "0x1A")]
	[Token(Token = "0x60019EE")]
	public string get_Prefix() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60019FD")]
	public string get_Value() { }

	[Address(RVA = "0x24DA910", Offset = "0x24D9D10", Length = "0x32")]
	[Token(Token = "0x60019F6")]
	public int GetParent(out XPathNode[] pageNode) { }

	[Address(RVA = "0x24DA950", Offset = "0x24D9D50", Length = "0x32")]
	[Token(Token = "0x60019F7")]
	public int GetSibling(out XPathNode[] pageNode) { }

}

