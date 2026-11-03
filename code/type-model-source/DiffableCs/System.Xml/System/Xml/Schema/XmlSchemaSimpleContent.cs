namespace System.Xml.Schema;

[Token(Token = "0x200023F")]
public class XmlSchemaSimpleContent : XmlSchemaContentModel
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BD8")]
	private XmlSchemaContent content; //Field offset: 0x50

	[Token(Token = "0x17000645")]
	[XmlElement("restriction", typeof(XmlSchemaSimpleContentRestriction))]
	[XmlElement("extension", typeof(XmlSchemaSimpleContentExtension))]
	public virtual XmlSchemaContent Content
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6001682")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x6001683")]
		 set { } //Length: 13
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6001684")]
	public XmlSchemaSimpleContent() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6001682")]
	public virtual XmlSchemaContent get_Content() { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x6001683")]
	public virtual void set_Content(XmlSchemaContent value) { }

}

