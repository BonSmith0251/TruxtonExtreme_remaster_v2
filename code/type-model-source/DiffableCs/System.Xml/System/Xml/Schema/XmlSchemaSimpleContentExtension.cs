namespace System.Xml.Schema;

[Token(Token = "0x2000240")]
public class XmlSchemaSimpleContentExtension : XmlSchemaContent
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BD9")]
	private XmlSchemaObjectCollection attributes; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BDA")]
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BDB")]
	private XmlQualifiedName baseTypeName; //Field offset: 0x60

	[Token(Token = "0x17000648")]
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6001688")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x6001689")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000647")]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6001687")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000646")]
	[XmlAttribute("base")]
	public XmlQualifiedName BaseTypeName
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6001685")]
		 get { } //Length: 5
		[Address(RVA = "0x24A1720", Offset = "0x24A0B20", Length = "0xA0")]
		[Token(Token = "0x6001686")]
		 set { } //Length: 160
	}

	[Address(RVA = "0x24A1670", Offset = "0x24A0A70", Length = "0xA9")]
	[Token(Token = "0x600168B")]
	public XmlSchemaSimpleContentExtension() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6001688")]
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6001687")]
	public XmlSchemaObjectCollection get_Attributes() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6001685")]
	public XmlQualifiedName get_BaseTypeName() { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x6001689")]
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	[Address(RVA = "0x24A1720", Offset = "0x24A0B20", Length = "0xA0")]
	[Token(Token = "0x6001686")]
	public void set_BaseTypeName(XmlQualifiedName value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x600168A")]
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

}

