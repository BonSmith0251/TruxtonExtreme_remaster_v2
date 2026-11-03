namespace System.Xml.Schema;

[Token(Token = "0x2000200")]
public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B0A")]
	private XmlQualifiedName refName; //Field offset: 0x50

	[Token(Token = "0x1700058C")]
	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60014A3")]
		 get { } //Length: 5
		[Address(RVA = "0x2488700", Offset = "0x2487B00", Length = "0xA0")]
		[Token(Token = "0x60014A4")]
		 set { } //Length: 160
	}

	[Address(RVA = "0x2488690", Offset = "0x2487A90", Length = "0x6B")]
	[Token(Token = "0x60014A5")]
	public XmlSchemaAttributeGroupRef() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60014A3")]
	public XmlQualifiedName get_RefName() { }

	[Address(RVA = "0x2488700", Offset = "0x2487B00", Length = "0xA0")]
	[Token(Token = "0x60014A4")]
	public void set_RefName(XmlQualifiedName value) { }

}

