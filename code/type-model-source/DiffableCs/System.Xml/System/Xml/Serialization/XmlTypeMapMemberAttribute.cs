namespace System.Xml.Serialization;

[Token(Token = "0x2000139")]
internal class XmlTypeMapMemberAttribute : XmlTypeMapMember
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40006C4")]
	private string _attributeName; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40006C5")]
	private string _namespace; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40006C6")]
	private XmlSchemaForm _form; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40006C7")]
	private XmlTypeMapping _mappedType; //Field offset: 0x70

	[Token(Token = "0x17000383")]
	public string AttributeName
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6000DEF")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x6000DF0")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000385")]
	public XmlSchemaForm Form
	{
		[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
		[Token(Token = "0x6000DF3")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000386")]
	public XmlTypeMapping MappedType
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x6000DF4")]
		 get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[Token(Token = "0x6000DF5")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000384")]
	public string Namespace
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6000DF1")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x6000DF2")]
		 set { } //Length: 995
	}

	[Address(RVA = "0x2592630", Offset = "0x2591A30", Length = "0x4F")]
	[Token(Token = "0x6000DEE")]
	public XmlTypeMapMemberAttribute() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000DEF")]
	public string get_AttributeName() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x6000DF4")]
	public XmlTypeMapping get_MappedType() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000DF1")]
	public string get_Namespace() { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x6000DF0")]
	public void set_AttributeName(string value) { }

	[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
	[Token(Token = "0x6000DF3")]
	public void set_Form(XmlSchemaForm value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[Token(Token = "0x6000DF5")]
	public void set_MappedType(XmlTypeMapping value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x6000DF2")]
	public void set_Namespace(string value) { }

}

