namespace System.Xml.Schema;

[Token(Token = "0x200022D")]
public class XmlSchemaInclude : XmlSchemaExternal
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B92")]
	private XmlSchemaAnnotation annotation; //Field offset: 0x68

	[Address(RVA = "0x248EFD0", Offset = "0x248E3D0", Length = "0x1D")]
	[Token(Token = "0x60015CF")]
	public XmlSchemaInclude() { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x60015D0")]
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

}

