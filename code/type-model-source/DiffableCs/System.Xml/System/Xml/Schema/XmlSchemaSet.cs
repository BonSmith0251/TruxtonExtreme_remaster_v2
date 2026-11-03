namespace System.Xml.Schema;

[Token(Token = "0x200023E")]
public class XmlSchemaSet
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BC4")]
	private XmlNameTable nameTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BC5")]
	private SchemaNames schemaNames; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BC6")]
	private SortedList schemas; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BC7")]
	private ValidationEventHandler internalEventHandler; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BC8")]
	private ValidationEventHandler eventHandler; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BC9")]
	private bool isCompiled; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BCA")]
	private Hashtable schemaLocations; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000BCB")]
	private Hashtable chameleonSchemas; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000BCC")]
	private Hashtable targetNamespaces; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000BCD")]
	private bool compileAll; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000BCE")]
	private SchemaInfo cachedCompiledInfo; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000BCF")]
	private XmlReaderSettings readerSettings; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000BD0")]
	private XmlSchema schemaForSchema; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000BD1")]
	private XmlSchemaCompilationSettings compilationSettings; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000BD2")]
	internal XmlSchemaObjectTable elements; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000BD3")]
	internal XmlSchemaObjectTable attributes; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000BD4")]
	internal XmlSchemaObjectTable schemaTypes; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000BD5")]
	internal XmlSchemaObjectTable substitutionGroups; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000BD6")]
	private XmlSchemaObjectTable typeExtensions; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000BD7")]
	private object internalSyncObject; //Field offset: 0xA8

	[Token(Token = "0x14000001")]
	public event ValidationEventHandler ValidationEventHandler
	{
		[Address(RVA = "0x24A1120", Offset = "0x24A0520", Length = "0x132")]
		[Token(Token = "0x6001652")]
		 add { } //Length: 306
		[Address(RVA = "0x24A1590", Offset = "0x24A0990", Length = "0xB8")]
		[Token(Token = "0x6001653")]
		 remove { } //Length: 184
	}

	[Token(Token = "0x1700063A")]
	public XmlSchemaCompilationSettings CompilationSettings
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x6001656")]
		 get { } //Length: 5
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[Token(Token = "0x6001657")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000642")]
	internal SchemaInfo CompiledInfo
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x6001673")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700063B")]
	public int Count
	{
		[Address(RVA = "0x24A1260", Offset = "0x24A0660", Length = "0x2A")]
		[Token(Token = "0x6001658")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700063D")]
	public XmlSchemaObjectTable GlobalAttributes
	{
		[Address(RVA = "0x24A1290", Offset = "0x24A0690", Length = "0x75")]
		[Token(Token = "0x600165A")]
		 get { } //Length: 117
	}

	[Token(Token = "0x1700063C")]
	public XmlSchemaObjectTable GlobalElements
	{
		[Address(RVA = "0x24A1310", Offset = "0x24A0710", Length = "0x75")]
		[Token(Token = "0x6001659")]
		 get { } //Length: 117
	}

	[Token(Token = "0x1700063E")]
	public XmlSchemaObjectTable GlobalTypes
	{
		[Address(RVA = "0x24A1390", Offset = "0x24A0790", Length = "0x75")]
		[Token(Token = "0x600165B")]
		 get { } //Length: 117
	}

	[Token(Token = "0x17000637")]
	internal object InternalSyncObject
	{
		[Address(RVA = "0x24A1410", Offset = "0x24A0810", Length = "0x71")]
		[Token(Token = "0x600164F")]
		internal get { } //Length: 113
	}

	[Token(Token = "0x17000638")]
	public bool IsCompiled
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[Token(Token = "0x6001654")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000643")]
	internal XmlReaderSettings ReaderSettings
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6001674")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000640")]
	internal Hashtable SchemaLocations
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600165D")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000644")]
	internal SortedList SortedSchemas
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600167B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700063F")]
	internal XmlSchemaObjectTable SubstitutionGroups
	{
		[Address(RVA = "0x24A1490", Offset = "0x24A0890", Length = "0x75")]
		[Token(Token = "0x600165C")]
		internal get { } //Length: 117
	}

	[Token(Token = "0x17000641")]
	internal XmlSchemaObjectTable TypeExtensions
	{
		[Address(RVA = "0x24A1510", Offset = "0x24A0910", Length = "0x75")]
		[Token(Token = "0x600165E")]
		internal get { } //Length: 117
	}

	[Token(Token = "0x17000639")]
	public XmlResolver XmlResolver
	{
		[Address(RVA = "0x24A1650", Offset = "0x24A0A50", Length = "0x1E")]
		[Token(Token = "0x6001655")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x24A0DC0", Offset = "0x24A01C0", Length = "0x5A")]
	[Token(Token = "0x6001650")]
	public XmlSchemaSet() { }

	[Address(RVA = "0x24A0E20", Offset = "0x24A0220", Length = "0x2F6")]
	[Token(Token = "0x6001651")]
	public XmlSchemaSet(XmlNameTable nameTable) { }

	[Address(RVA = "0x249A1F0", Offset = "0x24995F0", Length = "0x54")]
	[Token(Token = "0x6001668")]
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	[Address(RVA = "0x249AE20", Offset = "0x249A220", Length = "0x1BB")]
	[Token(Token = "0x6001660")]
	public XmlSchema Add(XmlSchema schema) { }

	[Address(RVA = "0x249A250", Offset = "0x2499650", Length = "0x72F")]
	[Token(Token = "0x600165F")]
	public void Add(XmlSchemaSet schemas) { }

	[Address(RVA = "0x249A980", Offset = "0x2499D80", Length = "0x496")]
	[Token(Token = "0x6001669")]
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	[Address(RVA = "0x24A1120", Offset = "0x24A0520", Length = "0x132")]
	[Token(Token = "0x6001652")]
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	[Address(RVA = "0x2499A40", Offset = "0x2498E40", Length = "0x3E3")]
	[Token(Token = "0x600166B")]
	private void AddSchemaToSet(XmlSchema schema) { }

	[Address(RVA = "0x2499E30", Offset = "0x2499230", Length = "0x3B8")]
	[Token(Token = "0x600167E")]
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	[Address(RVA = "0x249AFE0", Offset = "0x249A3E0", Length = "0xF6")]
	[Token(Token = "0x600166F")]
	private void ClearTables() { }

	[Address(RVA = "0x249B0E0", Offset = "0x249A4E0", Length = "0x61D")]
	[Token(Token = "0x6001663")]
	public void Compile() { }

	[Address(RVA = "0x249B700", Offset = "0x249AB00", Length = "0x46")]
	[Token(Token = "0x6001662")]
	public bool Contains(string targetNamespace) { }

	[Address(RVA = "0x249B750", Offset = "0x249AB50", Length = "0x13BF")]
	[Token(Token = "0x6001672")]
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	[Address(RVA = "0x249CB10", Offset = "0x249BF10", Length = "0x195")]
	[Token(Token = "0x6001665")]
	public void CopyTo(XmlSchema[] schemas, int index) { }

	[Address(RVA = "0x249CCB0", Offset = "0x249C0B0", Length = "0x2C4")]
	[Token(Token = "0x600166A")]
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x6001656")]
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6001673")]
	internal SchemaInfo get_CompiledInfo() { }

	[Address(RVA = "0x24A1260", Offset = "0x24A0660", Length = "0x2A")]
	[Token(Token = "0x6001658")]
	public int get_Count() { }

	[Address(RVA = "0x24A1290", Offset = "0x24A0690", Length = "0x75")]
	[Token(Token = "0x600165A")]
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	[Address(RVA = "0x24A1310", Offset = "0x24A0710", Length = "0x75")]
	[Token(Token = "0x6001659")]
	public XmlSchemaObjectTable get_GlobalElements() { }

	[Address(RVA = "0x24A1390", Offset = "0x24A0790", Length = "0x75")]
	[Token(Token = "0x600165B")]
	public XmlSchemaObjectTable get_GlobalTypes() { }

	[Address(RVA = "0x24A1410", Offset = "0x24A0810", Length = "0x71")]
	[Token(Token = "0x600164F")]
	internal object get_InternalSyncObject() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[Token(Token = "0x6001654")]
	public bool get_IsCompiled() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6001674")]
	internal XmlReaderSettings get_ReaderSettings() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600165D")]
	internal Hashtable get_SchemaLocations() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600167B")]
	internal SortedList get_SortedSchemas() { }

	[Address(RVA = "0x24A1490", Offset = "0x24A0890", Length = "0x75")]
	[Token(Token = "0x600165C")]
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	[Address(RVA = "0x24A1510", Offset = "0x24A0910", Length = "0x75")]
	[Token(Token = "0x600165E")]
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6001676")]
	internal ValidationEventHandler GetEventHandler() { }

	[Address(RVA = "0x249CF80", Offset = "0x249C380", Length = "0x1D")]
	[Token(Token = "0x6001675")]
	internal XmlResolver GetResolver() { }

	[Address(RVA = "0x249CFA0", Offset = "0x249C3A0", Length = "0x170")]
	[Token(Token = "0x6001679")]
	internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

	[Address(RVA = "0x249D120", Offset = "0x249C520", Length = "0xB3")]
	[Token(Token = "0x6001677")]
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	[Address(RVA = "0x249D1E0", Offset = "0x249C5E0", Length = "0x34")]
	[Token(Token = "0x600167A")]
	internal string GetTargetNamespace(XmlSchema schema) { }

	[Address(RVA = "0x249D220", Offset = "0x249C620", Length = "0x4D")]
	[Token(Token = "0x6001680")]
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	[Address(RVA = "0x249D270", Offset = "0x249C670", Length = "0xBB6")]
	[Token(Token = "0x6001678")]
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

	[Address(RVA = "0x249DE30", Offset = "0x249D230", Length = "0x120")]
	[Token(Token = "0x6001671")]
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	[Address(RVA = "0x249DF60", Offset = "0x249D360", Length = "0x151")]
	[Token(Token = "0x6001670")]
	internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

	[Address(RVA = "0x249E0C0", Offset = "0x249D4C0", Length = "0x36B")]
	[Token(Token = "0x600166C")]
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	[Address(RVA = "0x249FB90", Offset = "0x249EF90", Length = "0x2EB")]
	[Token(Token = "0x600166E")]
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	[Address(RVA = "0x24A1590", Offset = "0x24A0990", Length = "0xB8")]
	[Token(Token = "0x6001653")]
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	[Address(RVA = "0x249E430", Offset = "0x249D830", Length = "0x84E")]
	[Token(Token = "0x6001661")]
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	[Address(RVA = "0x249EC80", Offset = "0x249E080", Length = "0x49D")]
	[Token(Token = "0x600167C")]
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	[Address(RVA = "0x249F120", Offset = "0x249E520", Length = "0xA6D")]
	[Token(Token = "0x600167D")]
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	[Address(RVA = "0x249FE80", Offset = "0x249F280", Length = "0x798")]
	[Token(Token = "0x6001664")]
	public XmlSchema Reprocess(XmlSchema schema) { }

	[Address(RVA = "0x24A0620", Offset = "0x249FA20", Length = "0x3EE")]
	[Token(Token = "0x600166D")]
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	[Address(RVA = "0x24A0A10", Offset = "0x249FE10", Length = "0x195")]
	[Token(Token = "0x6001667")]
	public ICollection Schemas(string targetNamespace) { }

	[Address(RVA = "0x24A0BB0", Offset = "0x249FFB0", Length = "0x2A")]
	[Token(Token = "0x6001666")]
	public ICollection Schemas() { }

	[Address(RVA = "0x24A0BE0", Offset = "0x249FFE0", Length = "0xBB")]
	[Token(Token = "0x6001681")]
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[Token(Token = "0x6001657")]
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	[Address(RVA = "0x24A1650", Offset = "0x24A0A50", Length = "0x1E")]
	[Token(Token = "0x6001655")]
	public void set_XmlResolver(XmlResolver value) { }

	[Address(RVA = "0x24A0CA0", Offset = "0x24A00A0", Length = "0x119")]
	[Token(Token = "0x600167F")]
	private void VerifyTables() { }

}

