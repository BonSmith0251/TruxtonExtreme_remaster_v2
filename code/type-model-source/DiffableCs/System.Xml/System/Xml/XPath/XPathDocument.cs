namespace System.Xml.XPath;

[Token(Token = "0x20000E7")]
public class XPathDocument
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005AC")]
	private XPathNode[] pageXmlNmsp; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005AD")]
	private int idxXmlNmsp; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005AE")]
	private XmlNameTable nameTable; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005AF")]
	private bool hasLineInfo; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005B0")]
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; //Field offset: 0x30

	[Token(Token = "0x170002E4")]
	internal bool HasLineInfo
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[Token(Token = "0x6000B9F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170002E3")]
	internal XmlNameTable NameTable
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000B9E")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[Token(Token = "0x6000B9F")]
	internal bool get_HasLineInfo() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000B9E")]
	internal XmlNameTable get_NameTable() { }

	[Address(RVA = "0x254D250", Offset = "0x254C650", Length = "0x24")]
	[Token(Token = "0x6000BA0")]
	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	[Address(RVA = "0x254D280", Offset = "0x254C680", Length = "0x106")]
	[Token(Token = "0x6000BA1")]
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

}

