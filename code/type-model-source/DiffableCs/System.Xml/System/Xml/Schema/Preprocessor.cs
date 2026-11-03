namespace System.Xml.Schema;

[Token(Token = "0x20001D1")]
internal sealed class Preprocessor : BaseProcessor
{
	[Token(Token = "0x40008BC")]
	private static XmlSchema builtInSchemaForXmlNS; //Field offset: 0x0
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008AB")]
	private string Xmlns; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008AC")]
	private string NsXsi; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008AD")]
	private string targetNamespace; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008AE")]
	private XmlSchema rootSchema; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008AF")]
	private XmlSchema currentSchema; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008B0")]
	private XmlSchemaForm elementFormDefault; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40008B1")]
	private XmlSchemaForm attributeFormDefault; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008B2")]
	private XmlSchemaDerivationMethod blockDefault; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40008B3")]
	private XmlSchemaDerivationMethod finalDefault; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008B4")]
	private Hashtable schemaLocations; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40008B5")]
	private Hashtable chameleonSchemas; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40008B6")]
	private Hashtable referenceNamespaces; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40008B7")]
	private Hashtable processedExternals; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40008B8")]
	private SortedList lockList; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40008B9")]
	private XmlReaderSettings readerSettings; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40008BA")]
	private XmlSchema rootSchemaForRedefine; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40008BB")]
	private ArrayList redefinedList; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40008BD")]
	private XmlResolver xmlResolver; //Field offset: 0xB8

	[Token(Token = "0x170004D8")]
	internal Hashtable ChameleonSchemas
	{
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[Token(Token = "0x60011D7")]
		internal set { } //Length: 16
	}

	[Token(Token = "0x170004D6")]
	internal XmlReaderSettings ReaderSettings
	{
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[Token(Token = "0x60011D5")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x170004D9")]
	internal XmlSchema RootSchema
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60011D8")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170004D7")]
	internal Hashtable SchemaLocations
	{
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[Token(Token = "0x60011D6")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170004D5")]
	internal XmlResolver XmlResolver
	{
		[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
		[Token(Token = "0x60011D4")]
		internal set { } //Length: 19
	}

	[Address(RVA = "0x2433CB0", Offset = "0x24330B0", Length = "0x10D")]
	[Token(Token = "0x60011D0")]
	public Preprocessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	[Address(RVA = "0x2429880", Offset = "0x2428C80", Length = "0x294")]
	[Token(Token = "0x60011DC")]
	private void BuildRefNamespaces(XmlSchema schema) { }

	[Address(RVA = "0x2429B20", Offset = "0x2428F20", Length = "0x199")]
	[Token(Token = "0x60011D9")]
	private void BuildSchemaList(XmlSchema schema) { }

	[Address(RVA = "0x2429CC0", Offset = "0x24290C0", Length = "0x146")]
	[Token(Token = "0x60011E6")]
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	[Address(RVA = "0x2429E10", Offset = "0x2429210", Length = "0x3EC")]
	[Token(Token = "0x60011E8")]
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	[Address(RVA = "0x242A200", Offset = "0x2429600", Length = "0xA1")]
	[Token(Token = "0x60011E5")]
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	[Address(RVA = "0x242A2B0", Offset = "0x24296B0", Length = "0x13A")]
	[Token(Token = "0x60011E7")]
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	[Address(RVA = "0x242A490", Offset = "0x2429890", Length = "0xFD")]
	[Token(Token = "0x60011D2")]
	private void Cleanup(XmlSchema schema) { }

	[Address(RVA = "0x242A3F0", Offset = "0x24297F0", Length = "0x92")]
	[Token(Token = "0x60011D3")]
	private void CleanupRedefine(XmlSchemaExternal include) { }

	[Address(RVA = "0x242A590", Offset = "0x2429990", Length = "0xEB1")]
	[Token(Token = "0x60011DF")]
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	[Address(RVA = "0x242B450", Offset = "0x242A850", Length = "0x308")]
	[Token(Token = "0x60011E4")]
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	[Address(RVA = "0x242B760", Offset = "0x242AB60", Length = "0x654")]
	[Token(Token = "0x60011D1")]
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60011D8")]
	internal XmlSchema get_RootSchema() { }

	[Address(RVA = "0x242BDC0", Offset = "0x242B1C0", Length = "0x675")]
	[Token(Token = "0x60011DB")]
	internal static XmlSchema GetBuildInSchema() { }

	[Address(RVA = "0x242C440", Offset = "0x242B840", Length = "0x167")]
	[Token(Token = "0x60011FC")]
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	[Address(RVA = "0x242C5B0", Offset = "0x242B9B0", Length = "0x159")]
	[Token(Token = "0x60011E1")]
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	[Address(RVA = "0x242C710", Offset = "0x242BB10", Length = "0x7E")]
	[Token(Token = "0x60011E2")]
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	[Address(RVA = "0x242C790", Offset = "0x242BB90", Length = "0x39")]
	[Token(Token = "0x60011FB")]
	private object GetSchemaEntity(Uri ruri) { }

	[Address(RVA = "0x242C7D0", Offset = "0x242BBD0", Length = "0xDB5")]
	[Token(Token = "0x60011DA")]
	private void LoadExternals(XmlSchema schema) { }

	[Address(RVA = "0x242D590", Offset = "0x242C990", Length = "0xCE")]
	[Token(Token = "0x60011DD")]
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	[Address(RVA = "0x2431E00", Offset = "0x2431200", Length = "0x15CB")]
	[Token(Token = "0x60011DE")]
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	[Address(RVA = "0x242D740", Offset = "0x242CB40", Length = "0x85")]
	[Token(Token = "0x60011FF")]
	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }

	[Address(RVA = "0x242D660", Offset = "0x242CA60", Length = "0xD6")]
	[Token(Token = "0x60011FE")]
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	[Address(RVA = "0x242DB20", Offset = "0x242CF20", Length = "0x180")]
	[Token(Token = "0x60011E9")]
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	[Address(RVA = "0x242D7D0", Offset = "0x242CBD0", Length = "0x21D")]
	[Token(Token = "0x60011EB")]
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	[Address(RVA = "0x242D9F0", Offset = "0x242CDF0", Length = "0x122")]
	[Token(Token = "0x60011EC")]
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	[Address(RVA = "0x242DCB0", Offset = "0x242D0B0", Length = "0x31A")]
	[Token(Token = "0x60011F6")]
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	[Address(RVA = "0x242DFD0", Offset = "0x242D3D0", Length = "0xA24")]
	[Token(Token = "0x60011F2")]
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	[Address(RVA = "0x242EDC0", Offset = "0x242E1C0", Length = "0x266")]
	[Token(Token = "0x60011ED")]
	private void PreprocessElement(XmlSchemaElement element) { }

	[Address(RVA = "0x242EA00", Offset = "0x242DE00", Length = "0x3B8")]
	[Token(Token = "0x60011EF")]
	private void PreprocessElementContent(XmlSchemaElement element) { }

	[Address(RVA = "0x242F030", Offset = "0x242E430", Length = "0x1DF")]
	[Token(Token = "0x60011F3")]
	private void PreprocessGroup(XmlSchemaGroup group) { }

	[Address(RVA = "0x242F210", Offset = "0x242E610", Length = "0x3AA")]
	[Token(Token = "0x60011F0")]
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	[Address(RVA = "0x242F5C0", Offset = "0x242E9C0", Length = "0x1C2")]
	[Token(Token = "0x60011EA")]
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	[Address(RVA = "0x242F790", Offset = "0x242EB90", Length = "0x3C4")]
	[Token(Token = "0x60011EE")]
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	[Address(RVA = "0x242FB60", Offset = "0x242EF60", Length = "0x215")]
	[Token(Token = "0x60011F4")]
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	[Address(RVA = "0x242FD80", Offset = "0x242F180", Length = "0xA75")]
	[Token(Token = "0x60011F5")]
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	[Address(RVA = "0x2430800", Offset = "0x242FC00", Length = "0xF22")]
	[Token(Token = "0x60011E0")]
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	[Address(RVA = "0x2431730", Offset = "0x2430B30", Length = "0x6CB")]
	[Token(Token = "0x60011F1")]
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	[Address(RVA = "0x24333D0", Offset = "0x24327D0", Length = "0x4C")]
	[Token(Token = "0x60011FA")]
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[Token(Token = "0x60011D7")]
	internal void set_ChameleonSchemas(Hashtable value) { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[Token(Token = "0x60011D5")]
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[Token(Token = "0x60011D6")]
	internal void set_SchemaLocations(Hashtable value) { }

	[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
	[Token(Token = "0x60011D4")]
	internal void set_XmlResolver(XmlResolver value) { }

	[Address(RVA = "0x2433420", Offset = "0x2432820", Length = "0x22")]
	[Token(Token = "0x60011FD")]
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	[Address(RVA = "0x2433450", Offset = "0x2432850", Length = "0x103")]
	[Token(Token = "0x60011E3")]
	private void SetSchemaDefaults(XmlSchema schema) { }

	[Address(RVA = "0x2433560", Offset = "0x2432960", Length = "0x27B")]
	[Token(Token = "0x60011F7")]
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	[Address(RVA = "0x24337E0", Offset = "0x2432BE0", Length = "0x2FC")]
	[Token(Token = "0x60011F8")]
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	[Address(RVA = "0x2433AE0", Offset = "0x2432EE0", Length = "0x1C2")]
	[Token(Token = "0x60011F9")]
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

}

