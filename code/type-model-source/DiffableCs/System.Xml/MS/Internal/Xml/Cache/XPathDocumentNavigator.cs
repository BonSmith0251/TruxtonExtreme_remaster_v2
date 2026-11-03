namespace MS.Internal.Xml.Cache;

[Token(Token = "0x2000283")]
internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E5A")]
	private XPathNode[] _pageCurrent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E5B")]
	private XPathNode[] _pageParent; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E5C")]
	private int _idxCurrent; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000E5D")]
	private int _idxParent; //Field offset: 0x24

	[Token(Token = "0x170006C0")]
	public override int LineNumber
	{
		[Address(RVA = "0x24D9DD0", Offset = "0x24D91D0", Length = "0x78")]
		[Token(Token = "0x60019EA")]
		 get { } //Length: 120
	}

	[Token(Token = "0x170006C1")]
	public override int LinePosition
	{
		[Address(RVA = "0x24D9E50", Offset = "0x24D9250", Length = "0x9B")]
		[Token(Token = "0x60019EB")]
		 get { } //Length: 155
	}

	[Token(Token = "0x170006BB")]
	public virtual string LocalName
	{
		[Address(RVA = "0x24D9EF0", Offset = "0x24D92F0", Length = "0x3A")]
		[Token(Token = "0x60019E0")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170006BC")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x24D9F80", Offset = "0x24D9380", Length = "0x3A")]
		[Token(Token = "0x60019E1")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170006BE")]
	public virtual XmlNameTable NameTable
	{
		[Address(RVA = "0x24D9F30", Offset = "0x24D9330", Length = "0x43")]
		[Token(Token = "0x60019E3")]
		 get { } //Length: 67
	}

	[Token(Token = "0x170006BA")]
	public virtual XPathNodeType NodeType
	{
		[Address(RVA = "0x24D9FC0", Offset = "0x24D93C0", Length = "0x31")]
		[Token(Token = "0x60019DF")]
		 get { } //Length: 49
	}

	[Token(Token = "0x170006BD")]
	public virtual string Prefix
	{
		[Address(RVA = "0x24DA000", Offset = "0x24D9400", Length = "0x3A")]
		[Token(Token = "0x60019E2")]
		 get { } //Length: 58
	}

	[Token(Token = "0x170006BF")]
	public virtual object UnderlyingObject
	{
		[Address(RVA = "0x24DA040", Offset = "0x24D9440", Length = "0x14")]
		[Token(Token = "0x60019E8")]
		 get { } //Length: 20
	}

	[Token(Token = "0x170006B9")]
	public virtual string Value
	{
		[Address(RVA = "0x24DA060", Offset = "0x24D9460", Length = "0x2B1")]
		[Token(Token = "0x60019DD")]
		 get { } //Length: 689
	}

	[Address(RVA = "0x24D9D30", Offset = "0x24D9130", Length = "0x9A")]
	[Token(Token = "0x60019DC")]
	public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	[Address(RVA = "0x24D95F0", Offset = "0x24D89F0", Length = "0xD7")]
	[Token(Token = "0x60019DE")]
	public virtual XPathNavigator Clone() { }

	[Address(RVA = "0x24D9DD0", Offset = "0x24D91D0", Length = "0x78")]
	[Token(Token = "0x60019EA")]
	public override int get_LineNumber() { }

	[Address(RVA = "0x24D9E50", Offset = "0x24D9250", Length = "0x9B")]
	[Token(Token = "0x60019EB")]
	public override int get_LinePosition() { }

	[Address(RVA = "0x24D9EF0", Offset = "0x24D92F0", Length = "0x3A")]
	[Token(Token = "0x60019E0")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x24D9F80", Offset = "0x24D9380", Length = "0x3A")]
	[Token(Token = "0x60019E1")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x24D9F30", Offset = "0x24D9330", Length = "0x43")]
	[Token(Token = "0x60019E3")]
	public virtual XmlNameTable get_NameTable() { }

	[Address(RVA = "0x24D9FC0", Offset = "0x24D93C0", Length = "0x31")]
	[Token(Token = "0x60019DF")]
	public virtual XPathNodeType get_NodeType() { }

	[Address(RVA = "0x24DA000", Offset = "0x24D9400", Length = "0x3A")]
	[Token(Token = "0x60019E2")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x24DA040", Offset = "0x24D9440", Length = "0x14")]
	[Token(Token = "0x60019E8")]
	public virtual object get_UnderlyingObject() { }

	[Address(RVA = "0x24DA060", Offset = "0x24D9460", Length = "0x2B1")]
	[Token(Token = "0x60019DD")]
	public virtual string get_Value() { }

	[Address(RVA = "0x24D96D0", Offset = "0x24D8AD0", Length = "0x7")]
	[Token(Token = "0x60019EC")]
	public int GetPositionHashCode() { }

	[Address(RVA = "0x24D96E0", Offset = "0x24D8AE0", Length = "0x43")]
	[Token(Token = "0x60019E9")]
	public override bool HasLineInfo() { }

	[Address(RVA = "0x24D9730", Offset = "0x24D8B30", Length = "0x86")]
	[Token(Token = "0x60019E7")]
	public virtual bool IsSamePosition(XPathNavigator other) { }

	[Address(RVA = "0x24D97C0", Offset = "0x24D8BC0", Length = "0x2AE")]
	[Token(Token = "0x60019E4")]
	public virtual bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	[Address(RVA = "0x24D9A70", Offset = "0x24D8E70", Length = "0x1C4")]
	[Token(Token = "0x60019E5")]
	public virtual bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	[Address(RVA = "0x24D9C40", Offset = "0x24D9040", Length = "0xE9")]
	[Token(Token = "0x60019E6")]
	public virtual bool MoveToParent() { }

}

