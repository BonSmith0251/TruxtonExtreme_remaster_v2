namespace System.Xml;

[Token(Token = "0x2000089")]
internal class AttributePSVIInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003E4")]
	internal string localName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003E5")]
	internal string namespaceUri; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003E6")]
	internal object typedAttributeValue; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003E7")]
	internal XmlSchemaInfo attributeSchemaInfo; //Field offset: 0x28

	[Address(RVA = "0x250F440", Offset = "0x250E840", Length = "0x66")]
	[Token(Token = "0x6000701")]
	internal AttributePSVIInfo() { }

	[Address(RVA = "0x250F3C0", Offset = "0x250E7C0", Length = "0x72")]
	[Token(Token = "0x6000702")]
	internal void Reset() { }

}

