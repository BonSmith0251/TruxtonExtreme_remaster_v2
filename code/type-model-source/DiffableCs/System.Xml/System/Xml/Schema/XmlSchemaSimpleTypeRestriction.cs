namespace System.Xml.Schema;

[Token(Token = "0x2000245")]
public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BE5")]
	private XmlQualifiedName baseTypeName; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BE6")]
	private XmlSchemaSimpleType baseType; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BE7")]
	private XmlSchemaObjectCollection facets; //Field offset: 0x60

	[Token(Token = "0x17000653")]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType BaseType
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60016A5")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x60016A6")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000652")]
	[XmlAttribute("base")]
	public XmlQualifiedName BaseTypeName
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60016A3")]
		 get { } //Length: 5
		[Address(RVA = "0x24A1D90", Offset = "0x24A1190", Length = "0xA0")]
		[Token(Token = "0x60016A4")]
		 set { } //Length: 160
	}

	[Token(Token = "0x17000654")]
	[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
	[XmlElement("length", typeof(XmlSchemaLengthFacet))]
	[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
	[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
	[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
	[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
	[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
	[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
	[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
	[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
	[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
	[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
	public XmlSchemaObjectCollection Facets
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60016A7")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x24A1CE0", Offset = "0x24A10E0", Length = "0xA9")]
	[Token(Token = "0x60016A9")]
	public XmlSchemaSimpleTypeRestriction() { }

	[Address(RVA = "0x24A1BB0", Offset = "0x24A0FB0", Length = "0x126")]
	[Token(Token = "0x60016A8")]
	internal virtual XmlSchemaObject Clone() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60016A5")]
	public XmlSchemaSimpleType get_BaseType() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60016A3")]
	public XmlQualifiedName get_BaseTypeName() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60016A7")]
	public XmlSchemaObjectCollection get_Facets() { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x60016A6")]
	public void set_BaseType(XmlSchemaSimpleType value) { }

	[Address(RVA = "0x24A1D90", Offset = "0x24A1190", Length = "0xA0")]
	[Token(Token = "0x60016A4")]
	public void set_BaseTypeName(XmlQualifiedName value) { }

}

