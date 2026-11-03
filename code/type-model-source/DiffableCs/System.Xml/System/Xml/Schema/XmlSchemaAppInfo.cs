namespace System.Xml.Schema;

[Token(Token = "0x20001FD")]
public class XmlSchemaAppInfo : XmlSchemaObject
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000AF5")]
	private string source; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000AF6")]
	private XmlNode[] markup; //Field offset: 0x40

	[Token(Token = "0x17000574")]
	[XmlAnyElement]
	[XmlText]
	public XmlNode[] Markup
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6001472")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x6001473")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000573")]
	[XmlAttribute("source", DataType = "anyURI")]
	public string Source
	{
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6001471")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001474")]
	public XmlSchemaAppInfo() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6001472")]
	public XmlNode[] get_Markup() { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x6001473")]
	public void set_Markup(XmlNode[] value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6001471")]
	public void set_Source(string value) { }

}

