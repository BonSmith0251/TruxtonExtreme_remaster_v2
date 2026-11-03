namespace System.Xml.Schema;

[Token(Token = "0x2000241")]
public class XmlSchemaSimpleContentRestriction : XmlSchemaContent
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BDC")]
	private XmlQualifiedName baseTypeName; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BDD")]
	private XmlSchemaSimpleType baseType; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BDE")]
	private XmlSchemaObjectCollection facets; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000BDF")]
	private XmlSchemaObjectCollection attributes; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000BE0")]
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x70

	[Token(Token = "0x1700064D")]
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6001692")]
		 get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x6001693")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700064C")]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6001691")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700064A")]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType BaseType
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x600168E")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x600168F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000649")]
	[XmlAttribute("base")]
	public XmlQualifiedName BaseTypeName
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x600168C")]
		 get { } //Length: 5
		[Address(RVA = "0x24A18B0", Offset = "0x24A0CB0", Length = "0xA0")]
		[Token(Token = "0x600168D")]
		 set { } //Length: 160
	}

	[Token(Token = "0x1700064B")]
	[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
	[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
	[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
	[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
	[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
	[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
	[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
	[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
	[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
	[XmlElement("length", typeof(XmlSchemaLengthFacet))]
	[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
	[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
	public XmlSchemaObjectCollection Facets
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6001690")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x24A17D0", Offset = "0x24A0BD0", Length = "0xD2")]
	[Token(Token = "0x6001695")]
	public XmlSchemaSimpleContentRestriction() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6001692")]
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6001691")]
	public XmlSchemaObjectCollection get_Attributes() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x600168E")]
	public XmlSchemaSimpleType get_BaseType() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x600168C")]
	public XmlQualifiedName get_BaseTypeName() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6001690")]
	public XmlSchemaObjectCollection get_Facets() { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x6001693")]
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x600168F")]
	public void set_BaseType(XmlSchemaSimpleType value) { }

	[Address(RVA = "0x24A18B0", Offset = "0x24A0CB0", Length = "0xA0")]
	[Token(Token = "0x600168D")]
	public void set_BaseTypeName(XmlQualifiedName value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x6001694")]
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

}

