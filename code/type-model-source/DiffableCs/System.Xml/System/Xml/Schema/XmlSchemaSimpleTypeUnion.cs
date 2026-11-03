namespace System.Xml.Schema;

[Token(Token = "0x2000246")]
public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BE8")]
	private XmlSchemaObjectCollection baseTypes; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BE9")]
	private XmlQualifiedName[] memberTypes; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BEA")]
	private XmlSchemaSimpleType[] baseMemberTypes; //Field offset: 0x60

	[Token(Token = "0x17000657")]
	[XmlIgnore]
	public XmlSchemaSimpleType[] BaseMemberTypes
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60016AD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000655")]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaObjectCollection BaseTypes
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60016AA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000656")]
	[XmlAttribute("memberTypes")]
	public XmlQualifiedName[] MemberTypes
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60016AB")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x60016AC")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x24A2020", Offset = "0x24A1420", Length = "0x66")]
	[Token(Token = "0x60016B0")]
	public XmlSchemaSimpleTypeUnion() { }

	[Address(RVA = "0x24A1E40", Offset = "0x24A1240", Length = "0x1D6")]
	[Token(Token = "0x60016AF")]
	internal virtual XmlSchemaObject Clone() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60016AD")]
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60016AA")]
	public XmlSchemaObjectCollection get_BaseTypes() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60016AB")]
	public XmlQualifiedName[] get_MemberTypes() { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x60016AC")]
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x60016AE")]
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

}

