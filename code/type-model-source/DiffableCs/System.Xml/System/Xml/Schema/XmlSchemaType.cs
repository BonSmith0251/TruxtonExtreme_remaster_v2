namespace System.Xml.Schema;

[Token(Token = "0x2000249")]
public class XmlSchemaType : XmlSchemaAnnotated
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BEE")]
	private string name; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BEF")]
	private XmlSchemaDerivationMethod final; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000BF0")]
	private XmlSchemaDerivationMethod derivedBy; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BF1")]
	private XmlSchemaType baseSchemaType; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000BF2")]
	private XmlSchemaDatatype datatype; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000BF3")]
	private XmlSchemaDerivationMethod finalResolved; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000BF4")]
	private SchemaElementDecl elementDecl; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000BF5")]
	private XmlQualifiedName qname; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000BF6")]
	private XmlSchemaType redefined; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000BF7")]
	private XmlSchemaContentType contentType; //Field offset: 0x90

	[Token(Token = "0x1700065F")]
	[XmlIgnore]
	public XmlSchemaType BaseXmlSchemaType
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60016C0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000661")]
	[XmlIgnore]
	public XmlSchemaDatatype Datatype
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60016C2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000660")]
	[XmlIgnore]
	public XmlSchemaDerivationMethod DerivedBy
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[Token(Token = "0x60016C1")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000666")]
	internal SchemaElementDecl ElementDecl
	{
		[Address(RVA = "0x24A2A00", Offset = "0x24A1E00", Length = "0x18")]
		[Token(Token = "0x60016CD")]
		internal get { } //Length: 24
		[Address(RVA = "0x24A2B80", Offset = "0x24A1F80", Length = "0x2F")]
		[Token(Token = "0x60016CE")]
		internal set { } //Length: 47
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[Token(Token = "0x1700065C")]
	[XmlAttribute("final")]
	public XmlSchemaDerivationMethod Final
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[Token(Token = "0x60016BC")]
		 get { } //Length: 4
		[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
		[Token(Token = "0x60016BD")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700065E")]
	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[Token(Token = "0x60016BF")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000662")]
	[XmlIgnore]
	public override bool IsMixed
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60016C3")]
		 get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60016C4")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700065B")]
	[XmlAttribute("name")]
	public string Name
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60016BA")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60016BB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000668")]
	[XmlIgnore]
	internal virtual string NameAttribute
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60016D4")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60016D5")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700065D")]
	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		[Address(RVA = "0x24A2A20", Offset = "0x24A1E20", Length = "0x1B")]
		[Token(Token = "0x60016BE")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000667")]
	[XmlIgnore]
	internal XmlSchemaType Redefined
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x60016CF")]
		internal get { } //Length: 8
		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[Token(Token = "0x60016D0")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000665")]
	internal XmlSchemaContentType SchemaContentType
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[Token(Token = "0x60016C7")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x17000663")]
	[XmlIgnore]
	public XmlTypeCode TypeCode
	{
		[Address(RVA = "0x24A2A40", Offset = "0x24A1E40", Length = "0xB5")]
		[Token(Token = "0x60016C5")]
		 get { } //Length: 181
	}

	[Token(Token = "0x17000664")]
	[XmlIgnore]
	internal XmlValueConverter ValueConverter
	{
		[Address(RVA = "0x24A2B00", Offset = "0x24A1F00", Length = "0x78")]
		[Token(Token = "0x60016C6")]
		internal get { } //Length: 120
	}

	[Address(RVA = "0x24A21C0", Offset = "0x24A15C0", Length = "0x89")]
	[Token(Token = "0x60016D6")]
	public XmlSchemaType() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60016C0")]
	public XmlSchemaType get_BaseXmlSchemaType() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60016C2")]
	public XmlSchemaDatatype get_Datatype() { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[Token(Token = "0x60016C1")]
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	[Address(RVA = "0x24A2A00", Offset = "0x24A1E00", Length = "0x18")]
	[Token(Token = "0x60016CD")]
	internal SchemaElementDecl get_ElementDecl() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[Token(Token = "0x60016BC")]
	public XmlSchemaDerivationMethod get_Final() { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[Token(Token = "0x60016BF")]
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60016C3")]
	public override bool get_IsMixed() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60016BA")]
	public string get_Name() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60016D4")]
	internal virtual string get_NameAttribute() { }

	[Address(RVA = "0x24A2A20", Offset = "0x24A1E20", Length = "0x1B")]
	[Token(Token = "0x60016BE")]
	public XmlQualifiedName get_QualifiedName() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x60016CF")]
	internal XmlSchemaType get_Redefined() { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[Token(Token = "0x60016C7")]
	internal XmlSchemaContentType get_SchemaContentType() { }

	[Address(RVA = "0x24A2A40", Offset = "0x24A1E40", Length = "0xB5")]
	[Token(Token = "0x60016C5")]
	public XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x24A2B00", Offset = "0x24A1F00", Length = "0x78")]
	[Token(Token = "0x60016C6")]
	internal XmlValueConverter get_ValueConverter() { }

	[Address(RVA = "0x24A23F0", Offset = "0x24A17F0", Length = "0x25C")]
	[Token(Token = "0x60016B9")]
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	[Address(RVA = "0x24A2650", Offset = "0x24A1A50", Length = "0xC3")]
	[Token(Token = "0x60016B7")]
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	[Address(RVA = "0x24A2720", Offset = "0x24A1B20", Length = "0x47")]
	[Token(Token = "0x60016B8")]
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	[Address(RVA = "0x24A2840", Offset = "0x24A1C40", Length = "0x17E")]
	[Token(Token = "0x60016D2")]
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	[Address(RVA = "0x24A2770", Offset = "0x24A1B70", Length = "0xCA")]
	[Token(Token = "0x60016D3")]
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	[Address(RVA = "0x24A2B80", Offset = "0x24A1F80", Length = "0x2F")]
	[Token(Token = "0x60016CE")]
	internal void set_ElementDecl(SchemaElementDecl value) { }

	[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
	[Token(Token = "0x60016BD")]
	public void set_Final(XmlSchemaDerivationMethod value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60016C4")]
	public override void set_IsMixed(bool value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60016BB")]
	public void set_Name(string value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60016D5")]
	internal virtual void set_NameAttribute(string value) { }

	[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
	[Token(Token = "0x60016D0")]
	internal void set_Redefined(XmlSchemaType value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x60016CA")]
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
	[Token(Token = "0x60016D1")]
	internal void SetContentType(XmlSchemaContentType value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[Token(Token = "0x60016CC")]
	internal void SetDatatype(XmlSchemaDatatype value) { }

	[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
	[Token(Token = "0x60016CB")]
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	[Address(RVA = "0xAF0820", Offset = "0xAEFC20", Length = "0x4")]
	[Token(Token = "0x60016C9")]
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	[Address(RVA = "0x24A29C0", Offset = "0x24A1DC0", Length = "0x35")]
	[Token(Token = "0x60016C8")]
	internal void SetQualifiedName(XmlQualifiedName value) { }

}

