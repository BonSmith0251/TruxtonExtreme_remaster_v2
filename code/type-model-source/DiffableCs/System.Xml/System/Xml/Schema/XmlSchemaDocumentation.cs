namespace System.Xml.Schema;

[Token(Token = "0x2000210")]
public class XmlSchemaDocumentation : XmlSchemaObject
{
	[Token(Token = "0x4000B48")]
	private static XmlSchemaSimpleType languageType; //Field offset: 0x0
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B45")]
	private string source; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B46")]
	private string language; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B47")]
	private XmlNode[] markup; //Field offset: 0x48

	[Token(Token = "0x170005C7")]
	[XmlAttribute("xml:lang")]
	public string Language
	{
		[Address(RVA = "0x248D530", Offset = "0x248C930", Length = "0xEF")]
		[Token(Token = "0x600152E")]
		 set { } //Length: 239
	}

	[Token(Token = "0x170005C8")]
	[XmlAnyElement]
	[XmlText]
	public XmlNode[] Markup
	{
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x600152F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005C6")]
	[XmlAttribute("source", DataType = "anyURI")]
	public string Source
	{
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x600152D")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x248D460", Offset = "0x248C860", Length = "0xC5")]
	[Token(Token = "0x6001531")]
	private static XmlSchemaDocumentation() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001530")]
	public XmlSchemaDocumentation() { }

	[Address(RVA = "0x248D530", Offset = "0x248C930", Length = "0xEF")]
	[Token(Token = "0x600152E")]
	public void set_Language(string value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x600152F")]
	public void set_Markup(XmlNode[] value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x600152D")]
	public void set_Source(string value) { }

}

