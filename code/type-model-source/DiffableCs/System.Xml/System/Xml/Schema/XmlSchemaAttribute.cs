namespace System.Xml.Schema;

[Token(Token = "0x20001FE")]
public class XmlSchemaAttribute : XmlSchemaAnnotated
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000AF7")]
	private string defaultValue; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000AF8")]
	private string fixedValue; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000AF9")]
	private string name; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000AFA")]
	private XmlSchemaForm form; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000AFB")]
	private XmlSchemaUse use; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000AFC")]
	private XmlQualifiedName refName; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000AFD")]
	private XmlQualifiedName typeName; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000AFE")]
	private XmlQualifiedName qualifiedName; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000AFF")]
	private XmlSchemaSimpleType type; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000B00")]
	private XmlSchemaSimpleType attributeType; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000B01")]
	private SchemaAttDef attDef; //Field offset: 0x98

	[Token(Token = "0x17000580")]
	internal SchemaAttDef AttDef
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x600148A")]
		internal get { } //Length: 8
		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[Token(Token = "0x600148B")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700057E")]
	[XmlIgnore]
	public XmlSchemaSimpleType AttributeSchemaType
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6001486")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700057F")]
	[XmlIgnore]
	internal XmlSchemaDatatype Datatype
	{
		[Address(RVA = "0x2488BA0", Offset = "0x2487FA0", Length = "0x19")]
		[Token(Token = "0x6001487")]
		internal get { } //Length: 25
	}

	[DefaultValue(null)]
	[Token(Token = "0x17000575")]
	[XmlAttribute("default")]
	public string DefaultValue
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6001475")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x6001476")]
		 set { } //Length: 13
	}

	[DefaultValue(null)]
	[Token(Token = "0x17000576")]
	[XmlAttribute("fixed")]
	public string FixedValue
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6001477")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[Token(Token = "0x6001478")]
		 set { } //Length: 13
	}

	[DefaultValue(XmlSchemaForm::None (0))]
	[Token(Token = "0x17000577")]
	[XmlAttribute("form")]
	public XmlSchemaForm Form
	{
		[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
		[Token(Token = "0x6001479")]
		 get { } //Length: 4
		[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
		[Token(Token = "0x600147A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000578")]
	[XmlAttribute("name")]
	public string Name
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x600147B")]
		 get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x600147C")]
		 set { } //Length: 995
	}

	[Token(Token = "0x17000581")]
	[XmlIgnore]
	internal virtual string NameAttribute
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x600148C")]
		internal get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[Token(Token = "0x600148D")]
		internal set { } //Length: 995
	}

	[Token(Token = "0x1700057D")]
	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6001485")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000579")]
	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x600147D")]
		 get { } //Length: 5
		[Address(RVA = "0x2488BC0", Offset = "0x2487FC0", Length = "0xA0")]
		[Token(Token = "0x600147E")]
		 set { } //Length: 160
	}

	[Token(Token = "0x1700057B")]
	[XmlElement("simpleType")]
	public XmlSchemaSimpleType SchemaType
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[Token(Token = "0x6001481")]
		 get { } //Length: 8
		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[Token(Token = "0x6001482")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700057A")]
	[XmlAttribute("type")]
	public XmlQualifiedName SchemaTypeName
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x600147F")]
		 get { } //Length: 5
		[Address(RVA = "0x2488C70", Offset = "0x2488070", Length = "0xA0")]
		[Token(Token = "0x6001480")]
		 set { } //Length: 160
	}

	[DefaultValue(XmlSchemaUse::None (0))]
	[Token(Token = "0x1700057C")]
	[XmlAttribute("use")]
	public XmlSchemaUse Use
	{
		[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
		[Token(Token = "0x6001483")]
		 get { } //Length: 4
		[Address(RVA = "0xD97670", Offset = "0xD96A70", Length = "0x4")]
		[Token(Token = "0x6001484")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2488AF0", Offset = "0x2487EF0", Length = "0xAF")]
	[Token(Token = "0x600148F")]
	public XmlSchemaAttribute() { }

	[Address(RVA = "0x24889F0", Offset = "0x2487DF0", Length = "0xF4")]
	[Token(Token = "0x600148E")]
	internal virtual XmlSchemaObject Clone() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x600148A")]
	internal SchemaAttDef get_AttDef() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x6001486")]
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	[Address(RVA = "0x2488BA0", Offset = "0x2487FA0", Length = "0x19")]
	[Token(Token = "0x6001487")]
	internal XmlSchemaDatatype get_Datatype() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6001475")]
	public string get_DefaultValue() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6001477")]
	public string get_FixedValue() { }

	[Address(RVA = "0xAF07F0", Offset = "0xAEFBF0", Length = "0x4")]
	[Token(Token = "0x6001479")]
	public XmlSchemaForm get_Form() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x600147B")]
	public string get_Name() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x600148C")]
	internal virtual string get_NameAttribute() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6001485")]
	public XmlQualifiedName get_QualifiedName() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x600147D")]
	public XmlQualifiedName get_RefName() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[Token(Token = "0x6001481")]
	public XmlSchemaSimpleType get_SchemaType() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x600147F")]
	public XmlQualifiedName get_SchemaTypeName() { }

	[Address(RVA = "0xD97660", Offset = "0xD96A60", Length = "0x4")]
	[Token(Token = "0x6001483")]
	public XmlSchemaUse get_Use() { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[Token(Token = "0x600148B")]
	internal void set_AttDef(SchemaAttDef value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x6001476")]
	public void set_DefaultValue(string value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[Token(Token = "0x6001478")]
	public void set_FixedValue(string value) { }

	[Address(RVA = "0xAF0830", Offset = "0xAEFC30", Length = "0x4")]
	[Token(Token = "0x600147A")]
	public void set_Form(XmlSchemaForm value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x600147C")]
	public void set_Name(string value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[Token(Token = "0x600148D")]
	internal virtual void set_NameAttribute(string value) { }

	[Address(RVA = "0x2488BC0", Offset = "0x2487FC0", Length = "0xA0")]
	[Token(Token = "0x600147E")]
	public void set_RefName(XmlQualifiedName value) { }

	[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
	[Token(Token = "0x6001482")]
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	[Address(RVA = "0x2488C70", Offset = "0x2488070", Length = "0xA0")]
	[Token(Token = "0x6001480")]
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	[Address(RVA = "0xD97670", Offset = "0xD96A70", Length = "0x4")]
	[Token(Token = "0x6001484")]
	public void set_Use(XmlSchemaUse value) { }

	[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
	[Token(Token = "0x6001489")]
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[Token(Token = "0x6001488")]
	internal void SetQualifiedName(XmlQualifiedName value) { }

}

