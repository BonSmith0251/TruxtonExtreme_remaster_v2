namespace System.Xml.Schema;

[Token(Token = "0x2000261")]
internal sealed class XsdBuilder : SchemaBuilder
{
	[Token(Token = "0x2000268")]
	private class BuilderNamespaceManager : XmlNamespaceManager
	{
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000D56")]
		private XmlNamespaceManager nsMgr; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000D57")]
		private XmlReader reader; //Field offset: 0x58

		[Address(RVA = "0x24D7390", Offset = "0x24D6790", Length = "0x4E")]
		[Token(Token = "0x600191B")]
		public BuilderNamespaceManager(XmlNamespaceManager nsMgr, XmlReader reader) { }

		[Address(RVA = "0x24D7320", Offset = "0x24D6720", Length = "0x60")]
		[Token(Token = "0x600191C")]
		public virtual string LookupNamespace(string prefix) { }

	}

	[Token(Token = "0x2000262")]
	private enum State : int
	{
		Root = 0,
		Schema = 1,
		Annotation = 2,
		Include = 3,
		Import = 4,
		Element = 5,
		Attribute = 6,
		AttributeGroup = 7,
		AttributeGroupRef = 8,
		AnyAttribute = 9,
		Group = 10,
		GroupRef = 11,
		All = 12,
		Choice = 13,
		Sequence = 14,
		Any = 15,
		Notation = 16,
		SimpleType = 17,
		ComplexType = 18,
		ComplexContent = 19,
		ComplexContentRestriction = 20,
		ComplexContentExtension = 21,
		SimpleContent = 22,
		SimpleContentExtension = 23,
		SimpleContentRestriction = 24,
		SimpleTypeUnion = 25,
		SimpleTypeList = 26,
		SimpleTypeRestriction = 27,
		Unique = 28,
		Key = 29,
		KeyRef = 30,
		Selector = 31,
		Field = 32,
		MinExclusive = 33,
		MinInclusive = 34,
		MaxExclusive = 35,
		MaxInclusive = 36,
		TotalDigits = 37,
		FractionDigits = 38,
		Length = 39,
		MinLength = 40,
		MaxLength = 41,
		Enumeration = 42,
		Pattern = 43,
		WhiteSpace = 44,
		AppInfo = 45,
		Documentation = 46,
		Redefine = 47,
	}

	[Token(Token = "0x2000266")]
	private sealed class XsdAttributeEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D4D")]
		public Token Attribute; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D4E")]
		public XsdBuildFunction BuildFunc; //Field offset: 0x18

		[Address(RVA = "0xF53D70", Offset = "0xF53170", Length = "0x40")]
		[Token(Token = "0x6001919")]
		public XsdAttributeEntry(Token a, XsdBuildFunction build) { }

	}

	[Token(Token = "0x2000263")]
	private sealed class XsdBuildFunction : MulticastDelegate
	{

		[Address(RVA = "0x639C90", Offset = "0x639090", Length = "0xB5")]
		[Token(Token = "0x6001913")]
		public XsdBuildFunction(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6001914")]
		public override void Invoke(XsdBuilder builder, string value) { }

	}

	[Token(Token = "0x2000265")]
	private sealed class XsdEndChildFunction : MulticastDelegate
	{

		[Address(RVA = "0x1FCA570", Offset = "0x1FC9970", Length = "0xB4")]
		[Token(Token = "0x6001917")]
		public XsdEndChildFunction(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6001918")]
		public override void Invoke(XsdBuilder builder) { }

	}

	[Token(Token = "0x2000267")]
	private sealed class XsdEntry
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D4F")]
		public Token Name; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000D50")]
		public State CurrentState; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D51")]
		public State[] NextStates; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000D52")]
		public XsdAttributeEntry[] Attributes; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000D53")]
		public XsdInitFunction InitFunc; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000D54")]
		public XsdEndChildFunction EndChildFunc; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000D55")]
		public bool ParseContent; //Field offset: 0x38

		[Address(RVA = "0x24E4220", Offset = "0x24E3620", Length = "0x8F")]
		[Token(Token = "0x600191A")]
		public XsdEntry(Token n, State state, State[] nextStates, XsdAttributeEntry[] attributes, XsdInitFunction init, XsdEndChildFunction end, bool parseContent) { }

	}

	[Token(Token = "0x2000264")]
	private sealed class XsdInitFunction : MulticastDelegate
	{

		[Address(RVA = "0x639C90", Offset = "0x639090", Length = "0xB5")]
		[Token(Token = "0x6001915")]
		public XsdInitFunction(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6001916")]
		public override void Invoke(XsdBuilder builder, string value) { }

	}

	[Token(Token = "0x4000CAD")]
	private static readonly State[] SchemaElement; //Field offset: 0x0
	[Token(Token = "0x4000CAE")]
	private static readonly State[] SchemaSubelements; //Field offset: 0x8
	[Token(Token = "0x4000CAF")]
	private static readonly State[] AttributeSubelements; //Field offset: 0x10
	[Token(Token = "0x4000CB0")]
	private static readonly State[] ElementSubelements; //Field offset: 0x18
	[Token(Token = "0x4000CB1")]
	private static readonly State[] ComplexTypeSubelements; //Field offset: 0x20
	[Token(Token = "0x4000CB2")]
	private static readonly State[] SimpleContentSubelements; //Field offset: 0x28
	[Token(Token = "0x4000CB3")]
	private static readonly State[] SimpleContentExtensionSubelements; //Field offset: 0x30
	[Token(Token = "0x4000CB4")]
	private static readonly State[] SimpleContentRestrictionSubelements; //Field offset: 0x38
	[Token(Token = "0x4000CB5")]
	private static readonly State[] ComplexContentSubelements; //Field offset: 0x40
	[Token(Token = "0x4000CB6")]
	private static readonly State[] ComplexContentExtensionSubelements; //Field offset: 0x48
	[Token(Token = "0x4000CB7")]
	private static readonly State[] ComplexContentRestrictionSubelements; //Field offset: 0x50
	[Token(Token = "0x4000CB8")]
	private static readonly State[] SimpleTypeSubelements; //Field offset: 0x58
	[Token(Token = "0x4000CB9")]
	private static readonly State[] SimpleTypeRestrictionSubelements; //Field offset: 0x60
	[Token(Token = "0x4000CBA")]
	private static readonly State[] SimpleTypeListSubelements; //Field offset: 0x68
	[Token(Token = "0x4000CBB")]
	private static readonly State[] SimpleTypeUnionSubelements; //Field offset: 0x70
	[Token(Token = "0x4000CBC")]
	private static readonly State[] RedefineSubelements; //Field offset: 0x78
	[Token(Token = "0x4000CBD")]
	private static readonly State[] AttributeGroupSubelements; //Field offset: 0x80
	[Token(Token = "0x4000CBE")]
	private static readonly State[] GroupSubelements; //Field offset: 0x88
	[Token(Token = "0x4000CBF")]
	private static readonly State[] AllSubelements; //Field offset: 0x90
	[Token(Token = "0x4000CC0")]
	private static readonly State[] ChoiceSequenceSubelements; //Field offset: 0x98
	[Token(Token = "0x4000CC1")]
	private static readonly State[] IdentityConstraintSubelements; //Field offset: 0xA0
	[Token(Token = "0x4000CC2")]
	private static readonly State[] AnnotationSubelements; //Field offset: 0xA8
	[Token(Token = "0x4000CC3")]
	private static readonly State[] AnnotatedSubelements; //Field offset: 0xB0
	[Token(Token = "0x4000CC4")]
	private static readonly XsdAttributeEntry[] SchemaAttributes; //Field offset: 0xB8
	[Token(Token = "0x4000CC5")]
	private static readonly XsdAttributeEntry[] AttributeAttributes; //Field offset: 0xC0
	[Token(Token = "0x4000CC6")]
	private static readonly XsdAttributeEntry[] ElementAttributes; //Field offset: 0xC8
	[Token(Token = "0x4000CC7")]
	private static readonly XsdAttributeEntry[] ComplexTypeAttributes; //Field offset: 0xD0
	[Token(Token = "0x4000CC8")]
	private static readonly XsdAttributeEntry[] SimpleContentAttributes; //Field offset: 0xD8
	[Token(Token = "0x4000CC9")]
	private static readonly XsdAttributeEntry[] SimpleContentExtensionAttributes; //Field offset: 0xE0
	[Token(Token = "0x4000CCA")]
	private static readonly XsdAttributeEntry[] SimpleContentRestrictionAttributes; //Field offset: 0xE8
	[Token(Token = "0x4000CCB")]
	private static readonly XsdAttributeEntry[] ComplexContentAttributes; //Field offset: 0xF0
	[Token(Token = "0x4000CCC")]
	private static readonly XsdAttributeEntry[] ComplexContentExtensionAttributes; //Field offset: 0xF8
	[Token(Token = "0x4000CCD")]
	private static readonly XsdAttributeEntry[] ComplexContentRestrictionAttributes; //Field offset: 0x100
	[Token(Token = "0x4000CCE")]
	private static readonly XsdAttributeEntry[] SimpleTypeAttributes; //Field offset: 0x108
	[Token(Token = "0x4000CCF")]
	private static readonly XsdAttributeEntry[] SimpleTypeRestrictionAttributes; //Field offset: 0x110
	[Token(Token = "0x4000CD0")]
	private static readonly XsdAttributeEntry[] SimpleTypeUnionAttributes; //Field offset: 0x118
	[Token(Token = "0x4000CD1")]
	private static readonly XsdAttributeEntry[] SimpleTypeListAttributes; //Field offset: 0x120
	[Token(Token = "0x4000CD2")]
	private static readonly XsdAttributeEntry[] AttributeGroupAttributes; //Field offset: 0x128
	[Token(Token = "0x4000CD3")]
	private static readonly XsdAttributeEntry[] AttributeGroupRefAttributes; //Field offset: 0x130
	[Token(Token = "0x4000CD4")]
	private static readonly XsdAttributeEntry[] GroupAttributes; //Field offset: 0x138
	[Token(Token = "0x4000CD5")]
	private static readonly XsdAttributeEntry[] GroupRefAttributes; //Field offset: 0x140
	[Token(Token = "0x4000CD6")]
	private static readonly XsdAttributeEntry[] ParticleAttributes; //Field offset: 0x148
	[Token(Token = "0x4000CD7")]
	private static readonly XsdAttributeEntry[] AnyAttributes; //Field offset: 0x150
	[Token(Token = "0x4000CD8")]
	private static readonly XsdAttributeEntry[] IdentityConstraintAttributes; //Field offset: 0x158
	[Token(Token = "0x4000CD9")]
	private static readonly XsdAttributeEntry[] SelectorAttributes; //Field offset: 0x160
	[Token(Token = "0x4000CDA")]
	private static readonly XsdAttributeEntry[] FieldAttributes; //Field offset: 0x168
	[Token(Token = "0x4000CDB")]
	private static readonly XsdAttributeEntry[] NotationAttributes; //Field offset: 0x170
	[Token(Token = "0x4000CDC")]
	private static readonly XsdAttributeEntry[] IncludeAttributes; //Field offset: 0x178
	[Token(Token = "0x4000CDD")]
	private static readonly XsdAttributeEntry[] ImportAttributes; //Field offset: 0x180
	[Token(Token = "0x4000CDE")]
	private static readonly XsdAttributeEntry[] FacetAttributes; //Field offset: 0x188
	[Token(Token = "0x4000CDF")]
	private static readonly XsdAttributeEntry[] AnyAttributeAttributes; //Field offset: 0x190
	[Token(Token = "0x4000CE0")]
	private static readonly XsdAttributeEntry[] DocumentationAttributes; //Field offset: 0x198
	[Token(Token = "0x4000CE1")]
	private static readonly XsdAttributeEntry[] AppinfoAttributes; //Field offset: 0x1A0
	[Token(Token = "0x4000CE2")]
	private static readonly XsdAttributeEntry[] RedefineAttributes; //Field offset: 0x1A8
	[Token(Token = "0x4000CE3")]
	private static readonly XsdAttributeEntry[] AnnotationAttributes; //Field offset: 0x1B0
	[Token(Token = "0x4000CE4")]
	private static readonly XsdEntry[] SchemaEntries; //Field offset: 0x1B8
	[Token(Token = "0x4000CE5")]
	private static readonly Int32[] DerivationMethodValues; //Field offset: 0x1C0
	[Token(Token = "0x4000CE6")]
	private static readonly String[] DerivationMethodStrings; //Field offset: 0x1C8
	[Token(Token = "0x4000CE7")]
	private static readonly String[] FormStringValues; //Field offset: 0x1D0
	[Token(Token = "0x4000CE8")]
	private static readonly String[] UseStringValues; //Field offset: 0x1D8
	[Token(Token = "0x4000CE9")]
	private static readonly String[] ProcessContentsStringValues; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CEA")]
	private XmlReader reader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CEB")]
	private PositionInfo positionInfo; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000CEC")]
	private XsdEntry currentEntry; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000CED")]
	private XsdEntry nextEntry; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000CEE")]
	private bool hasChild; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000CEF")]
	private HWStack stateHistory; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000CF0")]
	private Stack containerStack; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000CF1")]
	private XmlNameTable nameTable; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000CF2")]
	private SchemaNames schemaNames; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000CF3")]
	private XmlNamespaceManager namespaceManager; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000CF4")]
	private bool canIncludeImport; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000CF5")]
	private XmlSchema schema; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000CF6")]
	private XmlSchemaObject xso; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000CF7")]
	private XmlSchemaElement element; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000CF8")]
	private XmlSchemaAny anyElement; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000CF9")]
	private XmlSchemaAttribute attribute; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000CFA")]
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000CFB")]
	private XmlSchemaComplexType complexType; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000CFC")]
	private XmlSchemaSimpleType simpleType; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000CFD")]
	private XmlSchemaComplexContent complexContent; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000CFE")]
	private XmlSchemaComplexContentExtension complexContentExtension; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000CFF")]
	private XmlSchemaComplexContentRestriction complexContentRestriction; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000D00")]
	private XmlSchemaSimpleContent simpleContent; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000D01")]
	private XmlSchemaSimpleContentExtension simpleContentExtension; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000D02")]
	private XmlSchemaSimpleContentRestriction simpleContentRestriction; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000D03")]
	private XmlSchemaSimpleTypeUnion simpleTypeUnion; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000D04")]
	private XmlSchemaSimpleTypeList simpleTypeList; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000D05")]
	private XmlSchemaSimpleTypeRestriction simpleTypeRestriction; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000D06")]
	private XmlSchemaGroup group; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000D07")]
	private XmlSchemaGroupRef groupRef; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000D08")]
	private XmlSchemaAll all; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000D09")]
	private XmlSchemaChoice choice; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000D0A")]
	private XmlSchemaSequence sequence; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000D0B")]
	private XmlSchemaParticle particle; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000D0C")]
	private XmlSchemaAttributeGroup attributeGroup; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000D0D")]
	private XmlSchemaAttributeGroupRef attributeGroupRef; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000D0E")]
	private XmlSchemaNotation notation; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000D0F")]
	private XmlSchemaIdentityConstraint identityConstraint; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000D10")]
	private XmlSchemaXPath xpath; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000D11")]
	private XmlSchemaInclude include; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000D12")]
	private XmlSchemaImport import; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000D13")]
	private XmlSchemaAnnotation annotation; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000D14")]
	private XmlSchemaAppInfo appInfo; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000D15")]
	private XmlSchemaDocumentation documentation; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000D16")]
	private XmlSchemaFacet facet; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000D17")]
	private XmlNode[] markup; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000D18")]
	private XmlSchemaRedefine redefine; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000D19")]
	private ValidationEventHandler validationEventHandler; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000D1A")]
	private ArrayList unhandledAttributes; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000D1B")]
	private Hashtable namespaces; //Field offset: 0x198

	[Token(Token = "0x1700067A")]
	private Token CurrentElement
	{
		[Address(RVA = "0x20AFD20", Offset = "0x20AF120", Length = "0x1A")]
		[Token(Token = "0x6001893")]
		private get { } //Length: 26
	}

	[Token(Token = "0x1700067C")]
	private XmlSchemaObject ParentContainer
	{
		[Address(RVA = "0x24D70C0", Offset = "0x24D64C0", Length = "0x8B")]
		[Token(Token = "0x6001895")]
		private get { } //Length: 139
	}

	[Token(Token = "0x1700067B")]
	private Token ParentElement
	{
		[Address(RVA = "0x24D7150", Offset = "0x24D6550", Length = "0x7C")]
		[Token(Token = "0x6001894")]
		private get { } //Length: 124
	}

	[Address(RVA = "0x24D0EC0", Offset = "0x24D02C0", Length = "0x5F93")]
	[Token(Token = "0x6001912")]
	private static XsdBuilder() { }

	[Address(RVA = "0x24D6E60", Offset = "0x24D6260", Length = "0x256")]
	[Token(Token = "0x6001889")]
	internal XsdBuilder(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	[Address(RVA = "0x24C9140", Offset = "0x24C8540", Length = "0x263")]
	[Token(Token = "0x6001901")]
	private void AddAttribute(XmlSchemaObject value) { }

	[Address(RVA = "0x24C93B0", Offset = "0x24C87B0", Length = "0x382")]
	[Token(Token = "0x6001902")]
	private void AddParticle(XmlSchemaParticle particle) { }

	[Address(RVA = "0x24C9740", Offset = "0x24C8B40", Length = "0x2F")]
	[Token(Token = "0x6001898")]
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9850", Offset = "0x24C8C50", Length = "0x2B")]
	[Token(Token = "0x60018E9")]
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9880", Offset = "0x24C8C80", Length = "0xB2")]
	[Token(Token = "0x60018EA")]
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9770", Offset = "0x24C8B70", Length = "0x2B")]
	[Token(Token = "0x60018DD")]
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C97A0", Offset = "0x24C8BA0", Length = "0xAF")]
	[Token(Token = "0x60018DE")]
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9940", Offset = "0x24C8D40", Length = "0x71")]
	[Token(Token = "0x60018FB")]
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9A70", Offset = "0x24C8E70", Length = "0x2B")]
	[Token(Token = "0x60018A9")]
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9AA0", Offset = "0x24C8EA0", Length = "0x2B")]
	[Token(Token = "0x60018AA")]
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9AD0", Offset = "0x24C8ED0", Length = "0xAF")]
	[Token(Token = "0x60018AB")]
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9B80", Offset = "0x24C8F80", Length = "0x2B")]
	[Token(Token = "0x60018AE")]
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9BB0", Offset = "0x24C8FB0", Length = "0x79")]
	[Token(Token = "0x60018AD")]
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9C30", Offset = "0x24C9030", Length = "0x79")]
	[Token(Token = "0x60018AF")]
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9CB0", Offset = "0x24C90B0", Length = "0xAF")]
	[Token(Token = "0x60018AC")]
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9A40", Offset = "0x24C8E40", Length = "0x2B")]
	[Token(Token = "0x60018D9")]
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C99C0", Offset = "0x24C8DC0", Length = "0x79")]
	[Token(Token = "0x60018DB")]
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9E60", Offset = "0x24C9260", Length = "0x79")]
	[Token(Token = "0x60018CE")]
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9D60", Offset = "0x24C9160", Length = "0x79")]
	[Token(Token = "0x60018D0")]
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9DE0", Offset = "0x24C91E0", Length = "0x79")]
	[Token(Token = "0x60018D2")]
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9EE0", Offset = "0x24C92E0", Length = "0x79")]
	[Token(Token = "0x60018C8")]
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9F60", Offset = "0x24C9360", Length = "0x72")]
	[Token(Token = "0x60018C9")]
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24C9FE0", Offset = "0x24C93E0", Length = "0x6F")]
	[Token(Token = "0x60018CA")]
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA050", Offset = "0x24C9450", Length = "0x85")]
	[Token(Token = "0x60018CB")]
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA0E0", Offset = "0x24C94E0", Length = "0x2B")]
	[Token(Token = "0x60018CC")]
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA110", Offset = "0x24C9510", Length = "0x71")]
	[Token(Token = "0x60018FE")]
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA190", Offset = "0x24C9590", Length = "0xFA")]
	[Token(Token = "0x60018FF")]
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA290", Offset = "0x24C9690", Length = "0x76")]
	[Token(Token = "0x60018B1")]
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA310", Offset = "0x24C9710", Length = "0x6F")]
	[Token(Token = "0x60018B2")]
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA380", Offset = "0x24C9780", Length = "0x2E")]
	[Token(Token = "0x60018B3")]
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA3B0", Offset = "0x24C97B0", Length = "0x6F")]
	[Token(Token = "0x60018B6")]
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA420", Offset = "0x24C9820", Length = "0x2E")]
	[Token(Token = "0x60018B7")]
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA450", Offset = "0x24C9850", Length = "0xAF")]
	[Token(Token = "0x60018B4")]
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA500", Offset = "0x24C9900", Length = "0x21")]
	[Token(Token = "0x60018B8")]
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA530", Offset = "0x24C9930", Length = "0x21")]
	[Token(Token = "0x60018B9")]
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA560", Offset = "0x24C9960", Length = "0x2E")]
	[Token(Token = "0x60018BA")]
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA590", Offset = "0x24C9990", Length = "0x76")]
	[Token(Token = "0x60018BB")]
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA610", Offset = "0x24C9A10", Length = "0x76")]
	[Token(Token = "0x60018BC")]
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA690", Offset = "0x24C9A90", Length = "0x76")]
	[Token(Token = "0x60018B5")]
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA710", Offset = "0x24C9B10", Length = "0x76")]
	[Token(Token = "0x60018BD")]
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA790", Offset = "0x24C9B90", Length = "0x85")]
	[Token(Token = "0x60018F0")]
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA820", Offset = "0x24C9C20", Length = "0x2B")]
	[Token(Token = "0x60018F1")]
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA850", Offset = "0x24C9C50", Length = "0x2B")]
	[Token(Token = "0x60018F8")]
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA900", Offset = "0x24C9D00", Length = "0x2B")]
	[Token(Token = "0x60018E0")]
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA880", Offset = "0x24C9C80", Length = "0x79")]
	[Token(Token = "0x60018E4")]
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA930", Offset = "0x24C9D30", Length = "0x2B")]
	[Token(Token = "0x60018F3")]
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA960", Offset = "0x24C9D60", Length = "0x130")]
	[Token(Token = "0x60018F4")]
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAAA0", Offset = "0x24C9EA0", Length = "0x2B")]
	[Token(Token = "0x60018A3")]
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAAD0", Offset = "0x24C9ED0", Length = "0x2B")]
	[Token(Token = "0x60018A4")]
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAB00", Offset = "0x24C9F00", Length = "0x2B")]
	[Token(Token = "0x60018A1")]
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAB30", Offset = "0x24C9F30", Length = "0x2B")]
	[Token(Token = "0x60018EC")]
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAB60", Offset = "0x24C9F60", Length = "0x2B")]
	[Token(Token = "0x60018ED")]
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAB90", Offset = "0x24C9F90", Length = "0x2B")]
	[Token(Token = "0x60018EE")]
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CABC0", Offset = "0x24C9FC0", Length = "0x24")]
	[Token(Token = "0x60018E2")]
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CABF0", Offset = "0x24C9FF0", Length = "0x24")]
	[Token(Token = "0x60018E3")]
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAC20", Offset = "0x24CA020", Length = "0x2B")]
	[Token(Token = "0x60018A6")]
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAC50", Offset = "0x24CA050", Length = "0xAC")]
	[Token(Token = "0x6001899")]
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAD00", Offset = "0x24CA100", Length = "0x6C")]
	[Token(Token = "0x600189E")]
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAD70", Offset = "0x24CA170", Length = "0xAC")]
	[Token(Token = "0x600189A")]
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAE20", Offset = "0x24CA220", Length = "0x6C")]
	[Token(Token = "0x600189D")]
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAE90", Offset = "0x24CA290", Length = "0x28")]
	[Token(Token = "0x600189B")]
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAEC0", Offset = "0x24CA2C0", Length = "0x28")]
	[Token(Token = "0x600189C")]
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CA850", Offset = "0x24C9C50", Length = "0x2B")]
	[Token(Token = "0x60018F6")]
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAEF0", Offset = "0x24CA2F0", Length = "0x79")]
	[Token(Token = "0x60018D5")]
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAF70", Offset = "0x24CA370", Length = "0x79")]
	[Token(Token = "0x60018D7")]
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CB2B0", Offset = "0x24CA6B0", Length = "0x6F")]
	[Token(Token = "0x60018C0")]
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CB320", Offset = "0x24CA720", Length = "0x2B")]
	[Token(Token = "0x60018BF")]
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CAFF0", Offset = "0x24CA3F0", Length = "0x79")]
	[Token(Token = "0x60018C4")]
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CB070", Offset = "0x24CA470", Length = "0x79")]
	[Token(Token = "0x60018C6")]
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CB0F0", Offset = "0x24CA4F0", Length = "0x1B2")]
	[Token(Token = "0x60018C2")]
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CB350", Offset = "0x24CA750", Length = "0x32")]
	[Token(Token = "0x60018FC")]
	private static void EndAppinfo(XsdBuilder builder) { }

	[Address(RVA = "0x24CB390", Offset = "0x24CA790", Length = "0x10D")]
	[Token(Token = "0x6001890")]
	internal virtual void EndChildren() { }

	[Address(RVA = "0x24CB4A0", Offset = "0x24CA8A0", Length = "0x32")]
	[Token(Token = "0x6001900")]
	private static void EndDocumentation(XsdBuilder builder) { }

	[Address(RVA = "0x24CB4E0", Offset = "0x24CA8E0", Length = "0x17")]
	[Token(Token = "0x60018A7")]
	private static void EndRedefine(XsdBuilder builder) { }

	[Address(RVA = "0x20AFD20", Offset = "0x20AF120", Length = "0x1A")]
	[Token(Token = "0x6001893")]
	private Token get_CurrentElement() { }

	[Address(RVA = "0x24D70C0", Offset = "0x24D64C0", Length = "0x8B")]
	[Token(Token = "0x6001895")]
	private XmlSchemaObject get_ParentContainer() { }

	[Address(RVA = "0x24D7150", Offset = "0x24D6550", Length = "0x7C")]
	[Token(Token = "0x6001894")]
	private Token get_ParentElement() { }

	[Address(RVA = "0x24CB500", Offset = "0x24CA900", Length = "0x188")]
	[Token(Token = "0x6001896")]
	private XmlSchemaObject GetContainer(State state) { }

	[Address(RVA = "0x24CB750", Offset = "0x24CAB50", Length = "0x1C8")]
	[Token(Token = "0x6001903")]
	private bool GetNextState(XmlQualifiedName qname) { }

	[Address(RVA = "0x24CB920", Offset = "0x24CAD20", Length = "0xA4")]
	[Token(Token = "0x60018E5")]
	private static void InitAll(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CB9D0", Offset = "0x24CADD0", Length = "0xF3")]
	[Token(Token = "0x60018F9")]
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CBDE0", Offset = "0x24CB1E0", Length = "0xA4")]
	[Token(Token = "0x60018E8")]
	private static void InitAny(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CBAD0", Offset = "0x24CAED0", Length = "0x302")]
	[Token(Token = "0x60018DC")]
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CBE90", Offset = "0x24CB290", Length = "0xD0")]
	[Token(Token = "0x60018FA")]
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CC0E0", Offset = "0x24CB4E0", Length = "0xD6")]
	[Token(Token = "0x60018A8")]
	private static void InitAttribute(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CC000", Offset = "0x24CB400", Length = "0xD2")]
	[Token(Token = "0x60018D8")]
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CBF70", Offset = "0x24CB370", Length = "0x8E")]
	[Token(Token = "0x60018DA")]
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CC1C0", Offset = "0x24CB5C0", Length = "0xA4")]
	[Token(Token = "0x60018E6")]
	private static void InitChoice(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CC430", Offset = "0x24CB830", Length = "0x137")]
	[Token(Token = "0x60018CD")]
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CC270", Offset = "0x24CB670", Length = "0x101")]
	[Token(Token = "0x60018CF")]
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CC380", Offset = "0x24CB780", Length = "0xA3")]
	[Token(Token = "0x60018D1")]
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CC570", Offset = "0x24CB970", Length = "0x19D")]
	[Token(Token = "0x60018C7")]
	private static void InitComplexType(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CC710", Offset = "0x24CBB10", Length = "0xD0")]
	[Token(Token = "0x60018FD")]
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CC7F0", Offset = "0x24CBBF0", Length = "0x110")]
	[Token(Token = "0x60018B0")]
	private static void InitElement(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CC910", Offset = "0x24CBD10", Length = "0x310")]
	[Token(Token = "0x60018EF")]
	private static void InitFacet(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CCC80", Offset = "0x24CC080", Length = "0xD5")]
	[Token(Token = "0x60018F7")]
	private static void InitField(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CCE10", Offset = "0x24CC210", Length = "0xC8")]
	[Token(Token = "0x60018DF")]
	private static void InitGroup(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CCD60", Offset = "0x24CC160", Length = "0xA4")]
	[Token(Token = "0x60018E1")]
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CCEE0", Offset = "0x24CC2E0", Length = "0x15E")]
	[Token(Token = "0x60018F2")]
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CD040", Offset = "0x24CC440", Length = "0xC9")]
	[Token(Token = "0x60018A2")]
	private static void InitImport(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CD110", Offset = "0x24CC510", Length = "0xC9")]
	[Token(Token = "0x60018A0")]
	private static void InitInclude(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CD1E0", Offset = "0x24CC5E0", Length = "0xA1")]
	[Token(Token = "0x60018EB")]
	private static void InitNotation(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CD290", Offset = "0x24CC690", Length = "0xC9")]
	[Token(Token = "0x60018A5")]
	private static void InitRedefine(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CD360", Offset = "0x24CC760", Length = "0x27")]
	[Token(Token = "0x600189F")]
	private static void InitSchema(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CD390", Offset = "0x24CC790", Length = "0xD7")]
	[Token(Token = "0x60018F5")]
	private static void InitSelector(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CD470", Offset = "0x24CC870", Length = "0xA4")]
	[Token(Token = "0x60018E7")]
	private static void InitSequence(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CD740", Offset = "0x24CCB40", Length = "0x137")]
	[Token(Token = "0x60018D3")]
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CD520", Offset = "0x24CC920", Length = "0x101")]
	[Token(Token = "0x60018D4")]
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CD630", Offset = "0x24CCA30", Length = "0x101")]
	[Token(Token = "0x60018D6")]
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CDB50", Offset = "0x24CCF50", Length = "0x394")]
	[Token(Token = "0x60018BE")]
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CD880", Offset = "0x24CCC80", Length = "0xE2")]
	[Token(Token = "0x60018C3")]
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CD970", Offset = "0x24CCD70", Length = "0xE2")]
	[Token(Token = "0x60018C5")]
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CDA60", Offset = "0x24CCE60", Length = "0xE2")]
	[Token(Token = "0x60018C1")]
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	[Address(RVA = "0x24CDF00", Offset = "0x24CD300", Length = "0x1B")]
	[Token(Token = "0x600188C")]
	internal virtual bool IsContentParsed() { }

	[Address(RVA = "0x24CDF20", Offset = "0x24CD320", Length = "0x2B")]
	[Token(Token = "0x6001904")]
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	[Address(RVA = "0x24CDF50", Offset = "0x24CD350", Length = "0x294")]
	[Token(Token = "0x600190A")]
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	[Address(RVA = "0x24CE1F0", Offset = "0x24CD5F0", Length = "0x8C")]
	[Token(Token = "0x6001907")]
	private bool ParseBoolean(string value, string attributeName) { }

	[Address(RVA = "0x24CE280", Offset = "0x24CD680", Length = "0xED")]
	[Token(Token = "0x6001908")]
	private int ParseEnum(string value, string attributeName, String[] values) { }

	[Address(RVA = "0x24CE370", Offset = "0x24CD770", Length = "0xF1")]
	[Token(Token = "0x6001909")]
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x600190B")]
	private static string ParseUriReference(string s) { }

	[Address(RVA = "0x24CE470", Offset = "0x24CD870", Length = "0xE5")]
	[Token(Token = "0x6001892")]
	private void Pop() { }

	[Address(RVA = "0x24CE560", Offset = "0x24CD960", Length = "0x4E3")]
	[Token(Token = "0x600188B")]
	internal virtual void ProcessAttribute(string prefix, string name, string ns, string value) { }

	[Address(RVA = "0x24CEA50", Offset = "0x24CDE50", Length = "0x4B")]
	[Token(Token = "0x600188E")]
	internal virtual void ProcessCData(string value) { }

	[Address(RVA = "0x24CEAA0", Offset = "0x24CDEA0", Length = "0x1EC")]
	[Token(Token = "0x600188A")]
	internal virtual bool ProcessElement(string prefix, string name, string ns) { }

	[Address(RVA = "0x24CEC90", Offset = "0x24CE090", Length = "0x13")]
	[Token(Token = "0x600188D")]
	internal virtual void ProcessMarkup(XmlNode[] markup) { }

	[Address(RVA = "0x24CECB0", Offset = "0x24CE0B0", Length = "0x218")]
	[Token(Token = "0x6001891")]
	private void Push() { }

	[Address(RVA = "0x24CEF90", Offset = "0x24CE390", Length = "0xD7")]
	[Token(Token = "0x6001911")]
	private void RecordPosition() { }

	[Address(RVA = "0x24CF080", Offset = "0x24CE480", Length = "0x190")]
	[Token(Token = "0x600190C")]
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	[Address(RVA = "0x24CF220", Offset = "0x24CE620", Length = "0x10C")]
	[Token(Token = "0x600190D")]
	private void SendValidationEvent(string code, string msg) { }

	[Address(RVA = "0x24CF420", Offset = "0x24CE820", Length = "0x11D")]
	[Token(Token = "0x600190E")]
	private void SendValidationEvent(string code, String[] args, XmlSeverityType severity) { }

	[Address(RVA = "0x24CF330", Offset = "0x24CE730", Length = "0xE7")]
	[Token(Token = "0x600190F")]
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	[Address(RVA = "0x24CF070", Offset = "0x24CE470", Length = "0xB")]
	[Token(Token = "0x6001910")]
	private void SendValidationEvent(XmlSchemaException e) { }

	[Address(RVA = "0x24CF540", Offset = "0x24CE940", Length = "0x161C")]
	[Token(Token = "0x6001897")]
	private void SetContainer(State state, object container) { }

	[Address(RVA = "0x24D0C20", Offset = "0x24D0020", Length = "0x53")]
	[Token(Token = "0x6001906")]
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	[Address(RVA = "0x24D0C80", Offset = "0x24D0080", Length = "0x53")]
	[Token(Token = "0x6001905")]
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	[Address(RVA = "0x24D0CE0", Offset = "0x24D00E0", Length = "0x1D1")]
	[Token(Token = "0x600188F")]
	internal virtual void StartChildren() { }

}

