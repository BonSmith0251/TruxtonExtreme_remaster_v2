namespace System.Xml.Serialization;

[Token(Token = "0x2000142")]
internal class XmlSerializableMapping : XmlTypeMapping
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40006D7")]
	private XmlSchema _schema; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40006D8")]
	private XmlSchemaComplexType _schemaType; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40006D9")]
	private XmlQualifiedName _schemaTypeName; //Field offset: 0x88

	[Address(RVA = "0x258B980", Offset = "0x258AD80", Length = "0xA5F")]
	[Token(Token = "0x6000E21")]
	internal XmlSerializableMapping(XmlRootAttribute root, string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

}

