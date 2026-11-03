namespace System.Xml.Schema;

[Token(Token = "0x20001DD")]
internal class SchemaInfo : IDtdInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000916")]
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000917")]
	private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000918")]
	private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000919")]
	private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400091A")]
	private XmlQualifiedName docTypeName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400091B")]
	private string internalDtdSubset; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400091C")]
	private bool hasNonCDataAttributes; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x400091D")]
	private bool hasDefaultAttributes; //Field offset: 0x41
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400091E")]
	private Dictionary<String, Boolean> targetNamespaces; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400091F")]
	private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000920")]
	private int errorCount; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000921")]
	private SchemaType schemaType; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000922")]
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000923")]
	private Dictionary<String, SchemaNotation> notations; //Field offset: 0x68

	[Token(Token = "0x1700052B")]
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60012FE")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000522")]
	public XmlQualifiedName DocTypeName
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60012F3")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x60012F4")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000524")]
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60012F6")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700052A")]
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60012FD")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700052D")]
	internal int ErrorCount
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[Token(Token = "0x6001300")]
		internal get { } //Length: 4
		[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
		[Token(Token = "0x6001301")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000526")]
	internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities
	{
		[Address(RVA = "0x2471B60", Offset = "0x2470F60", Length = "0x7A")]
		[Token(Token = "0x60012F8")]
		internal get { } //Length: 122
	}

	[Token(Token = "0x17000523")]
	internal string InternalDtdSubset
	{
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x60012F5")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700052C")]
	internal Dictionary<String, SchemaNotation> Notations
	{
		[Address(RVA = "0x2471BE0", Offset = "0x2470FE0", Length = "0x7A")]
		[Token(Token = "0x60012FF")]
		internal get { } //Length: 122
	}

	[Token(Token = "0x17000527")]
	internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities
	{
		[Address(RVA = "0x2471C60", Offset = "0x2471060", Length = "0x7A")]
		[Token(Token = "0x60012F9")]
		internal get { } //Length: 122
	}

	[Token(Token = "0x17000528")]
	internal SchemaType SchemaType
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[Token(Token = "0x60012FA")]
		internal get { } //Length: 4
		[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
		[Token(Token = "0x60012FB")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700052E")]
	private override bool System.Xml.IDtdInfo.HasDefaultAttributes
	{
		[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
		[Token(Token = "0x600130C")]
		private get { } //Length: 5
	}

	[Token(Token = "0x1700052F")]
	private override bool System.Xml.IDtdInfo.HasNonCDataAttributes
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x600130D")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000531")]
	private override string System.Xml.IDtdInfo.InternalDtdSubset
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6001311")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000530")]
	private override XmlQualifiedName System.Xml.IDtdInfo.Name
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6001310")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000529")]
	internal Dictionary<String, Boolean> TargetNamespaces
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60012FC")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000525")]
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60012F7")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x2471990", Offset = "0x2470D90", Length = "0x1C8")]
	[Token(Token = "0x60012F2")]
	internal SchemaInfo() { }

	[Address(RVA = "0x2470530", Offset = "0x246F930", Length = "0x94A")]
	[Token(Token = "0x600130A")]
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	[Address(RVA = "0x2470E80", Offset = "0x2470280", Length = "0x53")]
	[Token(Token = "0x6001306")]
	internal bool Contains(string ns) { }

	[Address(RVA = "0x2470EE0", Offset = "0x24702E0", Length = "0x183")]
	[Token(Token = "0x600130B")]
	internal void Finish() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60012FE")]
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttributeDecls() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60012F3")]
	public XmlQualifiedName get_DocTypeName() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60012F6")]
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDecls() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60012FD")]
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDeclsByType() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[Token(Token = "0x6001300")]
	internal int get_ErrorCount() { }

	[Address(RVA = "0x2471B60", Offset = "0x2470F60", Length = "0x7A")]
	[Token(Token = "0x60012F8")]
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_GeneralEntities() { }

	[Address(RVA = "0x2471BE0", Offset = "0x2470FE0", Length = "0x7A")]
	[Token(Token = "0x60012FF")]
	internal Dictionary<String, SchemaNotation> get_Notations() { }

	[Address(RVA = "0x2471C60", Offset = "0x2471060", Length = "0x7A")]
	[Token(Token = "0x60012F9")]
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_ParameterEntities() { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[Token(Token = "0x60012FA")]
	internal SchemaType get_SchemaType() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60012FC")]
	internal Dictionary<String, Boolean> get_TargetNamespaces() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60012F7")]
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_UndeclaredElementDecls() { }

	[Address(RVA = "0x2471070", Offset = "0x2470470", Length = "0x1BB")]
	[Token(Token = "0x6001307")]
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	[Address(RVA = "0x2471230", Offset = "0x2470630", Length = "0x124")]
	[Token(Token = "0x6001309")]
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip) { }

	[Address(RVA = "0x2471380", Offset = "0x2470780", Length = "0x276")]
	[Token(Token = "0x6001308")]
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState) { }

	[Address(RVA = "0x2471680", Offset = "0x2470A80", Length = "0x84")]
	[Token(Token = "0x6001304")]
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	[Address(RVA = "0x2471600", Offset = "0x2470A00", Length = "0x78")]
	[Token(Token = "0x6001302")]
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	[Address(RVA = "0x2471710", Offset = "0x2470B10", Length = "0x78")]
	[Token(Token = "0x6001303")]
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	[Address(RVA = "0x2471790", Offset = "0x2470B90", Length = "0x53")]
	[Token(Token = "0x6001305")]
	internal bool HasSchema(string ns) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x60012F4")]
	public void set_DocTypeName(XmlQualifiedName value) { }

	[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
	[Token(Token = "0x6001301")]
	internal void set_ErrorCount(int value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x60012F5")]
	internal void set_InternalDtdSubset(string value) { }

	[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
	[Token(Token = "0x60012FB")]
	internal void set_SchemaType(SchemaType value) { }

	[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
	[Token(Token = "0x600130C")]
	private override bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x600130D")]
	private override bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6001311")]
	private override string System.Xml.IDtdInfo.get_InternalDtdSubset() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6001310")]
	private override XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	[Address(RVA = "0x24717F0", Offset = "0x2470BF0", Length = "0xCB")]
	[Token(Token = "0x600130E")]
	private override IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	[Address(RVA = "0x24718C0", Offset = "0x2470CC0", Length = "0xC3")]
	[Token(Token = "0x600130F")]
	private override IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

}

