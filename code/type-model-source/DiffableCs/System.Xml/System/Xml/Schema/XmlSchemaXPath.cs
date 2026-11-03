namespace System.Xml.Schema;

[Token(Token = "0x2000228")]
public class XmlSchemaXPath : XmlSchemaAnnotated
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B8E")]
	private string xpath; //Field offset: 0x50

	[DefaultValue(null)]
	[Token(Token = "0x17000602")]
	[XmlAttribute("xpath")]
	public string XPath
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60015C3")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60015C4")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60015C5")]
	public XmlSchemaXPath() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60015C3")]
	public string get_XPath() { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60015C4")]
	public void set_XPath(string value) { }

}

