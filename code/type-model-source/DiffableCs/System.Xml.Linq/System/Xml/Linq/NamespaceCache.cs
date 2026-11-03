namespace System.Xml.Linq;

[Token(Token = "0x2000015")]
internal struct NamespaceCache
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002C")]
	private XNamespace _ns; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400002D")]
	private string _namespaceName; //Field offset: 0x8

	[Address(RVA = "0x2406270", Offset = "0x2405670", Length = "0xAB")]
	[Token(Token = "0x600008F")]
	public XNamespace Get(string namespaceName) { }

}

