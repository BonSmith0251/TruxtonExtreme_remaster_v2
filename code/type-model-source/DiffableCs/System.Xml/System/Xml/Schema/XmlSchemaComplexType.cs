namespace System.Xml.Schema;

[Token(Token = "0x2000209")]
public class XmlSchemaComplexType : XmlSchemaType
{
	[Token(Token = "0x4000B2E")]
	private static XmlSchemaComplexType anyTypeLax; //Field offset: 0x0
	[Token(Token = "0x4000B2F")]
	private static XmlSchemaComplexType anyTypeSkip; //Field offset: 0x8
	[Token(Token = "0x4000B30")]
	private static XmlSchemaComplexType untypedAnyType; //Field offset: 0x10
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000B24")]
	private XmlSchemaDerivationMethod block; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000B25")]
	private XmlSchemaContentModel contentModel; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000B26")]
	private XmlSchemaParticle particle; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000B27")]
	private XmlSchemaObjectCollection attributes; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000B28")]
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000B29")]
	private XmlSchemaParticle contentTypeParticle; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000B2A")]
	private XmlSchemaDerivationMethod blockResolved; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000B2B")]
	private XmlSchemaObjectTable localElements; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000B2C")]
	private XmlSchemaObjectTable attributeUses; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000B2D")]
	private XmlSchemaAnyAttribute attributeWildcard; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000B31")]
	private byte pvFlags; //Field offset: 0xE8

	[Token(Token = "0x170005B2")]
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[Token(Token = "0x60014F4")]
		 get { } //Length: 8
		[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
		[Token(Token = "0x60014F5")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005A9")]
	[XmlIgnore]
	internal static XmlSchemaComplexType AnyType
	{
		[Address(RVA = "0x248C1B0", Offset = "0x248B5B0", Length = "0x4E")]
		[Token(Token = "0x60014E6")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x170005AB")]
	internal static ContentValidator AnyTypeContentValidator
	{
		[Address(RVA = "0x248C140", Offset = "0x248B540", Length = "0x6B")]
		[Token(Token = "0x60014E8")]
		internal get { } //Length: 107
	}

	[Token(Token = "0x170005B1")]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes
	{
		[Address(RVA = "0x248C280", Offset = "0x248B680", Length = "0x75")]
		[Token(Token = "0x60014F3")]
		 get { } //Length: 117
	}

	[Token(Token = "0x170005B6")]
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeUses
	{
		[Address(RVA = "0x248C200", Offset = "0x248B600", Length = "0x75")]
		[Token(Token = "0x60014F9")]
		 get { } //Length: 117
	}

	[Token(Token = "0x170005B7")]
	[XmlIgnore]
	public XmlSchemaAnyAttribute AttributeWildcard
	{
		[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
		[Token(Token = "0x60014FA")]
		 get { } //Length: 8
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[Token(Token = "0x170005AD")]
	[XmlAttribute("block")]
	public XmlSchemaDerivationMethod Block
	{
		[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
		[Token(Token = "0x60014EB")]
		 get { } //Length: 7
		[Address(RVA = "0xE26E30", Offset = "0xE26230", Length = "0x7")]
		[Token(Token = "0x60014EC")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170005B5")]
	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved
	{
		[Address(RVA = "0x1D1EB80", Offset = "0x1D1DF80", Length = "0x7")]
		[Token(Token = "0x60014F8")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005AF")]
	[XmlElement("complexContent", typeof(XmlSchemaComplexContent))]
	[XmlElement("simpleContent", typeof(XmlSchemaSimpleContent))]
	public XmlSchemaContentModel ContentModel
	{
		[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
		[Token(Token = "0x60014EF")]
		 get { } //Length: 8
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[Token(Token = "0x60014F0")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005B3")]
	[XmlIgnore]
	public XmlSchemaContentType ContentType
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[Token(Token = "0x60014F6")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170005B4")]
	[XmlIgnore]
	public XmlSchemaParticle ContentTypeParticle
	{
		[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
		[Token(Token = "0x60014F7")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170005B9")]
	internal bool HasWildCard
	{
		[Address(RVA = "0x248C3F0", Offset = "0x248B7F0", Length = "0x27")]
		[Token(Token = "0x60014FF")]
		internal set { } //Length: 39
	}

	[DefaultValue(False)]
	[Token(Token = "0x170005AC")]
	[XmlAttribute("abstract")]
	public bool IsAbstract
	{
		[Address(RVA = "0x248C300", Offset = "0x248B700", Length = "0xB")]
		[Token(Token = "0x60014E9")]
		 get { } //Length: 11
		[Address(RVA = "0x248C420", Offset = "0x248B820", Length = "0x27")]
		[Token(Token = "0x60014EA")]
		 set { } //Length: 39
	}

	[DefaultValue(False)]
	[Token(Token = "0x170005AE")]
	[XmlAttribute("mixed")]
	public virtual bool IsMixed
	{
		[Address(RVA = "0x248C310", Offset = "0x248B710", Length = "0xB")]
		[Token(Token = "0x60014ED")]
		 get { } //Length: 11
		[Address(RVA = "0x248C450", Offset = "0x248B850", Length = "0x27")]
		[Token(Token = "0x60014EE")]
		 set { } //Length: 39
	}

	[Token(Token = "0x170005B8")]
	[XmlIgnore]
	internal XmlSchemaObjectTable LocalElements
	{
		[Address(RVA = "0x248C320", Offset = "0x248B720", Length = "0x75")]
		[Token(Token = "0x60014FB")]
		internal get { } //Length: 117
	}

	[Token(Token = "0x170005B0")]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	public XmlSchemaParticle Particle
	{
		[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
		[Token(Token = "0x60014F1")]
		 get { } //Length: 8
		[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
		[Token(Token = "0x60014F2")]
		 set { } //Length: 19
	}

	[Token(Token = "0x170005AA")]
	[XmlIgnore]
	internal static XmlSchemaComplexType UntypedAnyType
	{
		[Address(RVA = "0x248C3A0", Offset = "0x248B7A0", Length = "0x4F")]
		[Token(Token = "0x60014E7")]
		internal get { } //Length: 79
	}

	[Address(RVA = "0x248BD30", Offset = "0x248B130", Length = "0x387")]
	[Token(Token = "0x60014E3")]
	private static XmlSchemaComplexType() { }

	[Address(RVA = "0x248C0C0", Offset = "0x248B4C0", Length = "0x7A")]
	[Token(Token = "0x60014E5")]
	public XmlSchemaComplexType() { }

	[Address(RVA = "0x2489E20", Offset = "0x2489220", Length = "0xBC")]
	[Token(Token = "0x6001504")]
	private void ClearCompiledState() { }

	[Address(RVA = "0x248A750", Offset = "0x2489B50", Length = "0x9CA")]
	[Token(Token = "0x6001503")]
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	[Address(RVA = "0x248B120", Offset = "0x248A520", Length = "0xA")]
	[Token(Token = "0x6001502")]
	internal virtual XmlSchemaObject Clone() { }

	[Address(RVA = "0x2489EE0", Offset = "0x24892E0", Length = "0x273")]
	[Token(Token = "0x6001505")]
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	[Address(RVA = "0x248A160", Offset = "0x2489560", Length = "0x13A")]
	[Token(Token = "0x6001506")]
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	[Address(RVA = "0x248A2A0", Offset = "0x24896A0", Length = "0x4AE")]
	[Token(Token = "0x6001507")]
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	[Address(RVA = "0x248B130", Offset = "0x248A530", Length = "0x28C")]
	[Token(Token = "0x6001501")]
	internal bool ContainsIdAttribute(bool findAll) { }

	[Address(RVA = "0x248B3C0", Offset = "0x248A7C0", Length = "0x4CC")]
	[Token(Token = "0x60014E4")]
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[Token(Token = "0x60014F4")]
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	[Address(RVA = "0x248C1B0", Offset = "0x248B5B0", Length = "0x4E")]
	[Token(Token = "0x60014E6")]
	internal static XmlSchemaComplexType get_AnyType() { }

	[Address(RVA = "0x248C140", Offset = "0x248B540", Length = "0x6B")]
	[Token(Token = "0x60014E8")]
	internal static ContentValidator get_AnyTypeContentValidator() { }

	[Address(RVA = "0x248C280", Offset = "0x248B680", Length = "0x75")]
	[Token(Token = "0x60014F3")]
	public XmlSchemaObjectCollection get_Attributes() { }

	[Address(RVA = "0x248C200", Offset = "0x248B600", Length = "0x75")]
	[Token(Token = "0x60014F9")]
	public XmlSchemaObjectTable get_AttributeUses() { }

	[Address(RVA = "0x1CF2E60", Offset = "0x1CF2260", Length = "0x8")]
	[Token(Token = "0x60014FA")]
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
	[Token(Token = "0x60014EB")]
	public XmlSchemaDerivationMethod get_Block() { }

	[Address(RVA = "0x1D1EB80", Offset = "0x1D1DF80", Length = "0x7")]
	[Token(Token = "0x60014F8")]
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	[Address(RVA = "0x1D16DA0", Offset = "0x1D161A0", Length = "0x8")]
	[Token(Token = "0x60014EF")]
	public XmlSchemaContentModel get_ContentModel() { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[Token(Token = "0x60014F6")]
	public XmlSchemaContentType get_ContentType() { }

	[Address(RVA = "0xF5D8A0", Offset = "0xF5CCA0", Length = "0x8")]
	[Token(Token = "0x60014F7")]
	public XmlSchemaParticle get_ContentTypeParticle() { }

	[Address(RVA = "0x248C300", Offset = "0x248B700", Length = "0xB")]
	[Token(Token = "0x60014E9")]
	public bool get_IsAbstract() { }

	[Address(RVA = "0x248C310", Offset = "0x248B710", Length = "0xB")]
	[Token(Token = "0x60014ED")]
	public virtual bool get_IsMixed() { }

	[Address(RVA = "0x248C320", Offset = "0x248B720", Length = "0x75")]
	[Token(Token = "0x60014FB")]
	internal XmlSchemaObjectTable get_LocalElements() { }

	[Address(RVA = "0x1CF2A60", Offset = "0x1CF1E60", Length = "0x8")]
	[Token(Token = "0x60014F1")]
	public XmlSchemaParticle get_Particle() { }

	[Address(RVA = "0x248C3A0", Offset = "0x248B7A0", Length = "0x4F")]
	[Token(Token = "0x60014E7")]
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	[Address(RVA = "0x248B890", Offset = "0x248AC90", Length = "0x2F")]
	[Token(Token = "0x6001508")]
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	[Address(RVA = "0x248B8C0", Offset = "0x248ACC0", Length = "0x157")]
	[Token(Token = "0x600150A")]
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }

	[Address(RVA = "0x248BA20", Offset = "0x248AE20", Length = "0x2F6")]
	[Token(Token = "0x6001509")]
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
	[Token(Token = "0x60014F5")]
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	[Address(RVA = "0xE26E30", Offset = "0xE26230", Length = "0x7")]
	[Token(Token = "0x60014EC")]
	public void set_Block(XmlSchemaDerivationMethod value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[Token(Token = "0x60014F0")]
	public void set_ContentModel(XmlSchemaContentModel value) { }

	[Address(RVA = "0x248C3F0", Offset = "0x248B7F0", Length = "0x27")]
	[Token(Token = "0x60014FF")]
	internal void set_HasWildCard(bool value) { }

	[Address(RVA = "0x248C420", Offset = "0x248B820", Length = "0x27")]
	[Token(Token = "0x60014EA")]
	public void set_IsAbstract(bool value) { }

	[Address(RVA = "0x248C450", Offset = "0x248B850", Length = "0x27")]
	[Token(Token = "0x60014EE")]
	public virtual void set_IsMixed(bool value) { }

	[Address(RVA = "0x215EF60", Offset = "0x215E360", Length = "0x13")]
	[Token(Token = "0x60014F2")]
	public void set_Particle(XmlSchemaParticle value) { }

	[Address(RVA = "0xE7CFB0", Offset = "0xE7C3B0", Length = "0x13")]
	[Token(Token = "0x6001500")]
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	[Address(RVA = "0x20D5120", Offset = "0x20D4520", Length = "0x13")]
	[Token(Token = "0x60014FE")]
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	[Address(RVA = "0x248BD20", Offset = "0x248B120", Length = "0x7")]
	[Token(Token = "0x60014FD")]
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	[Address(RVA = "0xF5D8E0", Offset = "0xF5CCE0", Length = "0x13")]
	[Token(Token = "0x60014FC")]
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

}

