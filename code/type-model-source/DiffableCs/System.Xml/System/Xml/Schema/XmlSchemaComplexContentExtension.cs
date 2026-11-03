namespace System.Xml.Schema;

[Token(Token = "0x2000207")]
public class XmlSchemaComplexContentExtension : XmlSchemaContent
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B1C")]
	private XmlSchemaParticle particle; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B1D")]
	private XmlSchemaObjectCollection attributes; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B1E")]
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B1F")]
	private XmlQualifiedName baseTypeName; //Field offset: 0x68

	[Token(Token = "0x170005A4")]
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60014D6")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x60014D7")]
		 set { } //Length: 995
	}

	[Token(Token = "0x170005A3")]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60014D5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005A1")]
	[XmlAttribute("base")]
	public XmlQualifiedName BaseTypeName
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60014D1")]
		 get { } //Length: 5
		[Address(RVA = "0x2489C00", Offset = "0x2489000", Length = "0xA0")]
		[Token(Token = "0x60014D2")]
		 set { } //Length: 160
	}

	[Token(Token = "0x170005A2")]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public XmlSchemaParticle Particle
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60014D3")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60014D4")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2489B50", Offset = "0x2488F50", Length = "0xA9")]
	[Token(Token = "0x60014D9")]
	public XmlSchemaComplexContentExtension() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60014D6")]
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60014D5")]
	public XmlSchemaObjectCollection get_Attributes() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60014D1")]
	public XmlQualifiedName get_BaseTypeName() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60014D3")]
	public XmlSchemaParticle get_Particle() { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x60014D7")]
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	[Address(RVA = "0x2489C00", Offset = "0x2489000", Length = "0xA0")]
	[Token(Token = "0x60014D2")]
	public void set_BaseTypeName(XmlQualifiedName value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60014D4")]
	public void set_Particle(XmlSchemaParticle value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x60014D8")]
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

}

