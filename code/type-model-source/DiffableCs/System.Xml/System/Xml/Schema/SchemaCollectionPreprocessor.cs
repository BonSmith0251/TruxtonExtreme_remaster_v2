namespace System.Xml.Schema;

[Token(Token = "0x20001D6")]
internal sealed class SchemaCollectionPreprocessor : BaseProcessor
{
	[Token(Token = "0x20001D7")]
	private enum Compositor : int
	{
		Root = 0,
		Include = 1,
		Import = 2,
	}

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008CF")]
	private XmlSchema schema; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40008D0")]
	private string targetNamespace; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40008D1")]
	private bool buildinIncluded; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40008D2")]
	private XmlSchemaForm elementFormDefault; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40008D3")]
	private XmlSchemaForm attributeFormDefault; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40008D4")]
	private XmlSchemaDerivationMethod blockDefault; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40008D5")]
	private XmlSchemaDerivationMethod finalDefault; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40008D6")]
	private Hashtable schemaLocations; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008D7")]
	private Hashtable referenceNamespaces; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40008D8")]
	private string Xmlns; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40008D9")]
	private XmlResolver xmlResolver; //Field offset: 0x80

	[Token(Token = "0x170004EE")]
	internal XmlResolver XmlResolver
	{
		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[Token(Token = "0x600126E")]
		internal set { } //Length: 16
	}

	[Address(RVA = "0x245A000", Offset = "0x2459400", Length = "0xE")]
	[Token(Token = "0x600126B")]
	public SchemaCollectionPreprocessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	[Address(RVA = "0x24514C0", Offset = "0x24508C0", Length = "0x21E")]
	[Token(Token = "0x6001270")]
	private void BuildRefNamespaces(XmlSchema schema) { }

	[Address(RVA = "0x24516E0", Offset = "0x2450AE0", Length = "0x140")]
	[Token(Token = "0x6001275")]
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	[Address(RVA = "0x2451830", Offset = "0x2450C30", Length = "0x3EC")]
	[Token(Token = "0x6001277")]
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	[Address(RVA = "0x2451C20", Offset = "0x2451020", Length = "0x8B")]
	[Token(Token = "0x6001274")]
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	[Address(RVA = "0x2451CB0", Offset = "0x24510B0", Length = "0x13A")]
	[Token(Token = "0x6001276")]
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	[Address(RVA = "0x2451DF0", Offset = "0x24511F0", Length = "0x273")]
	[Token(Token = "0x600126D")]
	private void Cleanup(XmlSchema schema) { }

	[Address(RVA = "0x2452070", Offset = "0x2451470", Length = "0x2D9")]
	[Token(Token = "0x6001273")]
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	[Address(RVA = "0x2452350", Offset = "0x2451750", Length = "0x25C")]
	[Token(Token = "0x600126C")]
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	[Address(RVA = "0x24525B0", Offset = "0x24519B0", Length = "0xAD")]
	[Token(Token = "0x600128C")]
	private Stream GetSchemaEntity(Uri ruri) { }

	[Address(RVA = "0x2452660", Offset = "0x2451A60", Length = "0xBA8")]
	[Token(Token = "0x600126F")]
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	[Address(RVA = "0x2457C30", Offset = "0x2457030", Length = "0x1D33")]
	[Token(Token = "0x6001271")]
	private void Preprocess(XmlSchema schema, string targetNamespace, Compositor compositor) { }

	[Address(RVA = "0x2453210", Offset = "0x2452610", Length = "0x109")]
	[Token(Token = "0x600128A")]
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	[Address(RVA = "0x2453680", Offset = "0x2452A80", Length = "0x180")]
	[Token(Token = "0x6001278")]
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	[Address(RVA = "0x2453320", Offset = "0x2452720", Length = "0x22C")]
	[Token(Token = "0x600127A")]
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	[Address(RVA = "0x2453550", Offset = "0x2452950", Length = "0x122")]
	[Token(Token = "0x600127B")]
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	[Address(RVA = "0x2453810", Offset = "0x2452C10", Length = "0x2A9")]
	[Token(Token = "0x6001285")]
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	[Address(RVA = "0x2453AC0", Offset = "0x2452EC0", Length = "0xA24")]
	[Token(Token = "0x6001281")]
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	[Address(RVA = "0x24548F0", Offset = "0x2453CF0", Length = "0x266")]
	[Token(Token = "0x600127C")]
	private void PreprocessElement(XmlSchemaElement element) { }

	[Address(RVA = "0x24544F0", Offset = "0x24538F0", Length = "0x3F3")]
	[Token(Token = "0x600127E")]
	private void PreprocessElementContent(XmlSchemaElement element) { }

	[Address(RVA = "0x2454B60", Offset = "0x2453F60", Length = "0x1DF")]
	[Token(Token = "0x6001282")]
	private void PreprocessGroup(XmlSchemaGroup group) { }

	[Address(RVA = "0x2454D40", Offset = "0x2454140", Length = "0x3AA")]
	[Token(Token = "0x600127F")]
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	[Address(RVA = "0x24550F0", Offset = "0x24544F0", Length = "0x1C2")]
	[Token(Token = "0x6001279")]
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	[Address(RVA = "0x24552C0", Offset = "0x24546C0", Length = "0x3C4")]
	[Token(Token = "0x600127D")]
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	[Address(RVA = "0x2455690", Offset = "0x2454A90", Length = "0x1EE")]
	[Token(Token = "0x6001283")]
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	[Address(RVA = "0x2455880", Offset = "0x2454C80", Length = "0x9D0")]
	[Token(Token = "0x6001284")]
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	[Address(RVA = "0x2456260", Offset = "0x2455660", Length = "0x12B1")]
	[Token(Token = "0x6001272")]
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	[Address(RVA = "0x2457520", Offset = "0x2456920", Length = "0x704")]
	[Token(Token = "0x6001280")]
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	[Address(RVA = "0x2459970", Offset = "0x2458D70", Length = "0x44")]
	[Token(Token = "0x600128B")]
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
	[Token(Token = "0x600126E")]
	internal void set_XmlResolver(XmlResolver value) { }

	[Address(RVA = "0x2433420", Offset = "0x2432820", Length = "0x22")]
	[Token(Token = "0x6001289")]
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	[Address(RVA = "0x24599C0", Offset = "0x2458DC0", Length = "0x21A")]
	[Token(Token = "0x6001286")]
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	[Address(RVA = "0x2459BE0", Offset = "0x2458FE0", Length = "0x2FC")]
	[Token(Token = "0x6001287")]
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	[Address(RVA = "0x2459EE0", Offset = "0x24592E0", Length = "0x119")]
	[Token(Token = "0x6001288")]
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

}

