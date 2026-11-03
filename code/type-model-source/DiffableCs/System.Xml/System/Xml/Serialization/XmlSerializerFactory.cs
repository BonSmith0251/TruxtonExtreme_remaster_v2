namespace System.Xml.Serialization;

[Token(Token = "0x2000132")]
public class XmlSerializerFactory
{
	[Token(Token = "0x40006A8")]
	private static Hashtable serializersBySource; //Field offset: 0x0

	[Address(RVA = "0x2590A40", Offset = "0x258FE40", Length = "0x73")]
	[Token(Token = "0x6000DAC")]
	private static XmlSerializerFactory() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000DA8")]
	public XmlSerializerFactory() { }

	[Address(RVA = "0x25909E0", Offset = "0x258FDE0", Length = "0x25")]
	[Token(Token = "0x6000DA9")]
	public XmlSerializer CreateSerializer(Type type) { }

	[Address(RVA = "0x2590A10", Offset = "0x258FE10", Length = "0x25")]
	[Token(Token = "0x6000DAA")]
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	[Address(RVA = "0x2590730", Offset = "0x258FB30", Length = "0x2AB")]
	[Token(Token = "0x6000DAB")]
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

}

