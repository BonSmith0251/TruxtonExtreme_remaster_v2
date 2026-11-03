namespace System.Xml.Schema;

[Token(Token = "0x2000208")]
public class XmlSchemaComplexContentRestriction : XmlSchemaContent
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000B20")]
	private XmlSchemaParticle particle; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000B21")]
	private XmlSchemaObjectCollection attributes; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000B22")]
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B23")]
	private XmlQualifiedName baseTypeName; //Field offset: 0x68

	[Token(Token = "0x170005A8")]
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60014DF")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x60014E0")]
		 set { } //Length: 995
	}

	[Token(Token = "0x170005A7")]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60014DE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005A5")]
	[XmlAttribute("base")]
	public XmlQualifiedName BaseTypeName
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60014DA")]
		 get { } //Length: 5
		[Address(RVA = "0x2489D60", Offset = "0x2489160", Length = "0xA0")]
		[Token(Token = "0x60014DB")]
		 set { } //Length: 160
	}

	[Token(Token = "0x170005A6")]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaParticle Particle
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60014DC")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60014DD")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2489CB0", Offset = "0x24890B0", Length = "0xA9")]
	[Token(Token = "0x60014E2")]
	public XmlSchemaComplexContentRestriction() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60014DF")]
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60014DE")]
	public XmlSchemaObjectCollection get_Attributes() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60014DA")]
	public XmlQualifiedName get_BaseTypeName() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60014DC")]
	public XmlSchemaParticle get_Particle() { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x60014E0")]
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	[Address(RVA = "0x2489D60", Offset = "0x2489160", Length = "0xA0")]
	[Token(Token = "0x60014DB")]
	public void set_BaseTypeName(XmlQualifiedName value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60014DD")]
	public void set_Particle(XmlSchemaParticle value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x60014E1")]
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

}

