namespace System.Xml.Schema;

[Token(Token = "0x2000211")]
public class XmlSchemaElement : XmlSchemaParticle
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000B49")]
	private bool isAbstract; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x4000B4A")]
	private bool hasAbstractAttribute; //Field offset: 0x79
	[FieldOffset(Offset = "0x7A")]
	[Token(Token = "0x4000B4B")]
	private bool isNillable; //Field offset: 0x7A
	[FieldOffset(Offset = "0x7B")]
	[Token(Token = "0x4000B4C")]
	private bool hasNillableAttribute; //Field offset: 0x7B
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000B4D")]
	private bool isLocalTypeDerivationChecked; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000B4E")]
	private XmlSchemaDerivationMethod block; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000B4F")]
	private XmlSchemaDerivationMethod final; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000B50")]
	private XmlSchemaForm form; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000B51")]
	private string defaultValue; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000B52")]
	private string fixedValue; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000B53")]
	private string name; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000B54")]
	private XmlQualifiedName refName; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000B55")]
	private XmlQualifiedName substitutionGroup; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000B56")]
	private XmlQualifiedName typeName; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000B57")]
	private XmlSchemaType type; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000B58")]
	private XmlQualifiedName qualifiedName; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000B59")]
	private XmlSchemaType elementType; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000B5A")]
	private XmlSchemaDerivationMethod blockResolved; //Field offset: 0xD8
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x4000B5B")]
	private XmlSchemaDerivationMethod finalResolved; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000B5C")]
	private XmlSchemaObjectCollection constraints; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000B5D")]
	private SchemaElementDecl elementDecl; //Field offset: 0xE8

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[Token(Token = "0x170005CA")]
	[XmlAttribute("block")]
	public XmlSchemaDerivationMethod Block
	{
		[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
		[Token(Token = "0x6001534")]
		 get { } //Length: 7
		[Address(RVA = "0xE26DE0", Offset = "0xE261E0", Length = "0x7")]
		[Token(Token = "0x6001535")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170005DA")]
	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved
	{
		[Address(RVA = "0x1D16D10", Offset = "0x1D16110", Length = "0x7")]
		[Token(Token = "0x600154F")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005D7")]
	[XmlElement("key", typeof(XmlSchemaKey))]
	[XmlElement("keyref", typeof(XmlSchemaKeyref))]
	[XmlElement("unique", typeof(XmlSchemaUnique))]
	public XmlSchemaObjectCollection Constraints
	{
		[Address(RVA = "0x248D9F0", Offset = "0x248CDF0", Length = "0x75")]
		[Token(Token = "0x600154C")]
		 get { } //Length: 117
	}

	[DefaultValue(null)]
	[Token(Token = "0x170005CB")]
	[XmlAttribute("default")]
	public string DefaultValue
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6001536")]
		 get { } //Length: 8
		[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
		[Token(Token = "0x6001537")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005DE")]
	internal SchemaElementDecl ElementDecl
	{
		[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
		[Token(Token = "0x6001558")]
		internal get { } //Length: 8
		[Address(RVA = "0x20D5300", Offset = "0x20D4700", Length = "0x13")]
		[Token(Token = "0x6001559")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170005D9")]
	[XmlIgnore]
	public XmlSchemaType ElementSchemaType
	{
		[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
		[Token(Token = "0x600154E")]
		 get { } //Length: 8
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[Token(Token = "0x170005CC")]
	[XmlAttribute("final")]
	public XmlSchemaDerivationMethod Final
	{
		[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
		[Token(Token = "0x6001538")]
		 get { } //Length: 7
		[Address(RVA = "0xD11B10", Offset = "0xD10F10", Length = "0x7")]
		[Token(Token = "0x6001539")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170005DB")]
	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved
	{
		[Address(RVA = "0x248DA70", Offset = "0x248CE70", Length = "0x7")]
		[Token(Token = "0x6001550")]
		 get { } //Length: 7
	}

	[DefaultValue(null)]
	[Token(Token = "0x170005CD")]
	[XmlAttribute("fixed")]
	public string FixedValue
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x600153A")]
		 get { } //Length: 8
		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[Token(Token = "0x600153B")]
		 set { } //Length: 19
	}

	[DefaultValue(XmlSchemaForm::None (0))]
	[Token(Token = "0x170005CE")]
	[XmlAttribute("form")]
	public XmlSchemaForm Form
	{
		[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
		[Token(Token = "0x600153C")]
		 get { } //Length: 7
		[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
		[Token(Token = "0x600153D")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170005D2")]
	[XmlIgnore]
	internal bool HasAbstractAttribute
	{
		[Address(RVA = "0x248DA80", Offset = "0x248CE80", Length = "0x5")]
		[Token(Token = "0x6001543")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005DC")]
	internal bool HasConstraints
	{
		[Address(RVA = "0x248DA90", Offset = "0x248CE90", Length = "0x2D")]
		[Token(Token = "0x6001555")]
		internal get { } //Length: 45
	}

	[Token(Token = "0x170005D1")]
	[XmlIgnore]
	internal bool HasNillableAttribute
	{
		[Address(RVA = "0x248DAC0", Offset = "0x248CEC0", Length = "0x5")]
		[Token(Token = "0x6001542")]
		internal get { } //Length: 5
	}

	[DefaultValue(False)]
	[Token(Token = "0x170005C9")]
	[XmlAttribute("abstract")]
	public bool IsAbstract
	{
		[Address(RVA = "0x1D14910", Offset = "0x1D13D10", Length = "0x5")]
		[Token(Token = "0x6001532")]
		 get { } //Length: 5
		[Address(RVA = "0x248DB00", Offset = "0x248CF00", Length = "0x8")]
		[Token(Token = "0x6001533")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170005DD")]
	internal bool IsLocalTypeDerivationChecked
	{
		[Address(RVA = "0x243EE10", Offset = "0x243E210", Length = "0x5")]
		[Token(Token = "0x6001556")]
		internal get { } //Length: 5
		[Address(RVA = "0x248DB10", Offset = "0x248CF10", Length = "0x4")]
		[Token(Token = "0x6001557")]
		internal set { } //Length: 4
	}

	[DefaultValue(False)]
	[Token(Token = "0x170005D0")]
	[XmlAttribute("nillable")]
	public bool IsNillable
	{
		[Address(RVA = "0x231DDD0", Offset = "0x231D1D0", Length = "0x5")]
		[Token(Token = "0x6001540")]
		 get { } //Length: 5
		[Address(RVA = "0x248DB20", Offset = "0x248CF20", Length = "0x8")]
		[Token(Token = "0x6001541")]
		 set { } //Length: 8
	}

	[DefaultValue(null)]
	[Token(Token = "0x170005CF")]
	[XmlAttribute("name")]
	public string Name
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x600153E")]
		 get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[Token(Token = "0x600153F")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005DF")]
	[XmlIgnore]
	internal virtual string NameAttribute
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x600155A")]
		internal get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[Token(Token = "0x600155B")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170005E0")]
	[XmlIgnore]
	internal virtual string NameString
	{
		[Address(RVA = "0x248DAD0", Offset = "0x248CED0", Length = "0x2D")]
		[Token(Token = "0x600155C")]
		internal get { } //Length: 45
	}

	[Token(Token = "0x170005D8")]
	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
		[Token(Token = "0x600154D")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170005D3")]
	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x6001544")]
		 get { } //Length: 8
		[Address(RVA = "0x248DB30", Offset = "0x248CF30", Length = "0xA6")]
		[Token(Token = "0x6001545")]
		 set { } //Length: 166
	}

	[Token(Token = "0x170005D6")]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaType SchemaType
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[Token(Token = "0x600154A")]
		 get { } //Length: 8
		[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
		[Token(Token = "0x600154B")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005D5")]
	[XmlAttribute("type")]
	public XmlQualifiedName SchemaTypeName
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[Token(Token = "0x6001548")]
		 get { } //Length: 8
		[Address(RVA = "0x248DBE0", Offset = "0x248CFE0", Length = "0xA6")]
		[Token(Token = "0x6001549")]
		 set { } //Length: 166
	}

	[Token(Token = "0x170005D4")]
	[XmlAttribute("substitutionGroup")]
	public XmlQualifiedName SubstitutionGroup
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[Token(Token = "0x6001546")]
		 get { } //Length: 8
		[Address(RVA = "0x248DC90", Offset = "0x248D090", Length = "0xA6")]
		[Token(Token = "0x6001547")]
		 set { } //Length: 166
	}

	[Address(RVA = "0x248D8D0", Offset = "0x248CCD0", Length = "0x115")]
	[Token(Token = "0x600155F")]
	public XmlSchemaElement() { }

	[Address(RVA = "0x248D8B0", Offset = "0x248CCB0", Length = "0xA")]
	[Token(Token = "0x600155D")]
	internal virtual XmlSchemaObject Clone() { }

	[Address(RVA = "0x248D620", Offset = "0x248CA20", Length = "0x28E")]
	[Token(Token = "0x600155E")]
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
	[Token(Token = "0x6001534")]
	public XmlSchemaDerivationMethod get_Block() { }

	[Address(RVA = "0x1D16D10", Offset = "0x1D16110", Length = "0x7")]
	[Token(Token = "0x600154F")]
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	[Address(RVA = "0x248D9F0", Offset = "0x248CDF0", Length = "0x75")]
	[Token(Token = "0x600154C")]
	public XmlSchemaObjectCollection get_Constraints() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x6001536")]
	public string get_DefaultValue() { }

	[Address(RVA = "0x1CF29E0", Offset = "0x1CF1DE0", Length = "0x8")]
	[Token(Token = "0x6001558")]
	internal SchemaElementDecl get_ElementDecl() { }

	[Address(RVA = "0x20E7700", Offset = "0x20E6B00", Length = "0x8")]
	[Token(Token = "0x600154E")]
	public XmlSchemaType get_ElementSchemaType() { }

	[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
	[Token(Token = "0x6001538")]
	public XmlSchemaDerivationMethod get_Final() { }

	[Address(RVA = "0x248DA70", Offset = "0x248CE70", Length = "0x7")]
	[Token(Token = "0x6001550")]
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x600153A")]
	public string get_FixedValue() { }

	[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
	[Token(Token = "0x600153C")]
	public XmlSchemaForm get_Form() { }

	[Address(RVA = "0x248DA80", Offset = "0x248CE80", Length = "0x5")]
	[Token(Token = "0x6001543")]
	internal bool get_HasAbstractAttribute() { }

	[Address(RVA = "0x248DA90", Offset = "0x248CE90", Length = "0x2D")]
	[Token(Token = "0x6001555")]
	internal bool get_HasConstraints() { }

	[Address(RVA = "0x248DAC0", Offset = "0x248CEC0", Length = "0x5")]
	[Token(Token = "0x6001542")]
	internal bool get_HasNillableAttribute() { }

	[Address(RVA = "0x1D14910", Offset = "0x1D13D10", Length = "0x5")]
	[Token(Token = "0x6001532")]
	public bool get_IsAbstract() { }

	[Address(RVA = "0x243EE10", Offset = "0x243E210", Length = "0x5")]
	[Token(Token = "0x6001556")]
	internal bool get_IsLocalTypeDerivationChecked() { }

	[Address(RVA = "0x231DDD0", Offset = "0x231D1D0", Length = "0x5")]
	[Token(Token = "0x6001540")]
	public bool get_IsNillable() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x600153E")]
	public string get_Name() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x600155A")]
	internal virtual string get_NameAttribute() { }

	[Address(RVA = "0x248DAD0", Offset = "0x248CED0", Length = "0x2D")]
	[Token(Token = "0x600155C")]
	internal virtual string get_NameString() { }

	[Address(RVA = "0x20E7690", Offset = "0x20E6A90", Length = "0x8")]
	[Token(Token = "0x600154D")]
	public XmlQualifiedName get_QualifiedName() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x6001544")]
	public XmlQualifiedName get_RefName() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[Token(Token = "0x600154A")]
	public XmlSchemaType get_SchemaType() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[Token(Token = "0x6001548")]
	public XmlQualifiedName get_SchemaTypeName() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[Token(Token = "0x6001546")]
	public XmlQualifiedName get_SubstitutionGroup() { }

	[Address(RVA = "0xE26DE0", Offset = "0xE261E0", Length = "0x7")]
	[Token(Token = "0x6001535")]
	public void set_Block(XmlSchemaDerivationMethod value) { }

	[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
	[Token(Token = "0x6001537")]
	public void set_DefaultValue(string value) { }

	[Address(RVA = "0x20D5300", Offset = "0x20D4700", Length = "0x13")]
	[Token(Token = "0x6001559")]
	internal void set_ElementDecl(SchemaElementDecl value) { }

	[Address(RVA = "0xD11B10", Offset = "0xD10F10", Length = "0x7")]
	[Token(Token = "0x6001539")]
	public void set_Final(XmlSchemaDerivationMethod value) { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[Token(Token = "0x600153B")]
	public void set_FixedValue(string value) { }

	[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
	[Token(Token = "0x600153D")]
	public void set_Form(XmlSchemaForm value) { }

	[Address(RVA = "0x248DB00", Offset = "0x248CF00", Length = "0x8")]
	[Token(Token = "0x6001533")]
	public void set_IsAbstract(bool value) { }

	[Address(RVA = "0x248DB10", Offset = "0x248CF10", Length = "0x4")]
	[Token(Token = "0x6001557")]
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	[Address(RVA = "0x248DB20", Offset = "0x248CF20", Length = "0x8")]
	[Token(Token = "0x6001541")]
	public void set_IsNillable(bool value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[Token(Token = "0x600153F")]
	public void set_Name(string value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[Token(Token = "0x600155B")]
	internal virtual void set_NameAttribute(string value) { }

	[Address(RVA = "0x248DB30", Offset = "0x248CF30", Length = "0xA6")]
	[Token(Token = "0x6001545")]
	public void set_RefName(XmlQualifiedName value) { }

	[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
	[Token(Token = "0x600154B")]
	public void set_SchemaType(XmlSchemaType value) { }

	[Address(RVA = "0x248DBE0", Offset = "0x248CFE0", Length = "0xA6")]
	[Token(Token = "0x6001549")]
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	[Address(RVA = "0x248DC90", Offset = "0x248D090", Length = "0xA6")]
	[Token(Token = "0x6001547")]
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	[Address(RVA = "0x1D16080", Offset = "0x1D15480", Length = "0x7")]
	[Token(Token = "0x6001553")]
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	[Address(RVA = "0x20E7790", Offset = "0x20E6B90", Length = "0x13")]
	[Token(Token = "0x6001552")]
	internal void SetElementType(XmlSchemaType value) { }

	[Address(RVA = "0x248D8C0", Offset = "0x248CCC0", Length = "0x7")]
	[Token(Token = "0x6001554")]
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	[Address(RVA = "0x1CEAE20", Offset = "0x1CEA220", Length = "0x13")]
	[Token(Token = "0x6001551")]
	internal void SetQualifiedName(XmlQualifiedName value) { }

}

