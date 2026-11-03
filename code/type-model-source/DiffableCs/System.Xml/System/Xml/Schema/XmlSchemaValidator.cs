namespace System.Xml.Schema;

[Token(Token = "0x2000250")]
public sealed class XmlSchemaValidator
{
	[Token(Token = "0x4000C3B")]
	private static readonly XmlSchemaDatatype dtQName; //Field offset: 0x0
	[Token(Token = "0x4000C3C")]
	private static readonly XmlSchemaDatatype dtCDATA; //Field offset: 0x8
	[Token(Token = "0x4000C3D")]
	private static readonly XmlSchemaDatatype dtStringArray; //Field offset: 0x10
	[Token(Token = "0x4000C3E")]
	private static XmlSchemaParticle[] EmptyParticleArray; //Field offset: 0x18
	[Token(Token = "0x4000C3F")]
	private static XmlSchemaAttribute[] EmptyAttributeArray; //Field offset: 0x20
	[Token(Token = "0x4000C41")]
	internal static Boolean[2] ValidStates; //Field offset: 0x28
	[Token(Token = "0x4000C42")]
	private static String[] MethodNames; //Field offset: 0x30
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C15")]
	private XmlSchemaSet schemaSet; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C16")]
	private XmlSchemaValidationFlags validationFlags; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000C17")]
	private int startIDConstraint; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C18")]
	private bool isRoot; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x4000C19")]
	private bool rootHasSchema; //Field offset: 0x21
	[FieldOffset(Offset = "0x22")]
	[Token(Token = "0x4000C1A")]
	private bool attrValid; //Field offset: 0x22
	[FieldOffset(Offset = "0x23")]
	[Token(Token = "0x4000C1B")]
	private bool checkEntity; //Field offset: 0x23
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C1C")]
	private SchemaInfo compiledSchemaInfo; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C1D")]
	private IDtdInfo dtdSchemaInfo; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C1E")]
	private Hashtable validatedNamespaces; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C1F")]
	private HWStack validationStack; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C20")]
	private ValidationState context; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000C21")]
	private ValidatorState currentState; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000C22")]
	private Hashtable attPresence; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000C23")]
	private SchemaAttDef wildID; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000C24")]
	private Hashtable IDs; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000C25")]
	private IdRefNode idRefListHead; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000C26")]
	private XmlQualifiedName contextQName; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000C27")]
	private string NsXs; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000C28")]
	private string NsXsi; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000C29")]
	private string NsXmlNs; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000C2A")]
	private string NsXml; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000C2B")]
	private XmlSchemaObject partialValidationType; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000C2C")]
	private StringBuilder textValue; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000C2D")]
	private ValidationEventHandler eventHandler; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000C2E")]
	private object validationEventSender; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000C2F")]
	private XmlNameTable nameTable; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000C30")]
	private IXmlLineInfo positionInfo; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000C31")]
	private IXmlLineInfo dummyPositionInfo; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000C32")]
	private XmlResolver xmlResolver; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000C33")]
	private Uri sourceUri; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000C34")]
	private string sourceUriString; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000C35")]
	private IXmlNamespaceResolver nsResolver; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000C36")]
	private XmlSchemaContentProcessing processContents; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000C37")]
	private string xsiTypeString; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000C38")]
	private string xsiNilString; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000C39")]
	private string xsiSchemaLocationString; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000C3A")]
	private string xsiNoNamespaceSchemaLocationString; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000C40")]
	private XmlCharType xmlCharType; //Field offset: 0x120

	[Token(Token = "0x14000002")]
	public event ValidationEventHandler ValidationEventHandler
	{
		[Address(RVA = "0x24AF4E0", Offset = "0x24AE8E0", Length = "0xAB")]
		[Token(Token = "0x60016E7")]
		 add { } //Length: 171
		[Address(RVA = "0x24AF6C0", Offset = "0x24AEAC0", Length = "0xAB")]
		[Token(Token = "0x60016E8")]
		 remove { } //Length: 171
	}

	[Token(Token = "0x1700066F")]
	internal XmlSchemaContentType CurrentContentType
	{
		[Address(RVA = "0x24AF590", Offset = "0x24AE990", Length = "0x3B")]
		[Token(Token = "0x60016FA")]
		internal get { } //Length: 59
	}

	[Token(Token = "0x17000672")]
	private bool HasIdentityConstraints
	{
		[Address(RVA = "0x24AF5D0", Offset = "0x24AE9D0", Length = "0x11")]
		[Token(Token = "0x6001719")]
		private get { } //Length: 17
	}

	[Token(Token = "0x17000671")]
	private bool HasSchema
	{
		[Address(RVA = "0x24AF5F0", Offset = "0x24AE9F0", Length = "0x47")]
		[Token(Token = "0x60016FD")]
		private get { } //Length: 71
	}

	[Token(Token = "0x1700066A")]
	public IXmlLineInfo LineInfoProvider
	{
		[Address(RVA = "0x24AF770", Offset = "0x24AEB70", Length = "0x22")]
		[Token(Token = "0x60016E4")]
		 set { } //Length: 34
	}

	[Token(Token = "0x17000673")]
	internal bool ProcessIdentityConstraints
	{
		[Address(RVA = "0x24AF640", Offset = "0x24AEA40", Length = "0x8")]
		[Token(Token = "0x600171A")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000675")]
	internal bool ProcessSchemaHints
	{
		[Address(RVA = "0x24AF650", Offset = "0x24AEA50", Length = "0x11")]
		[Token(Token = "0x600171C")]
		internal get { } //Length: 17
	}

	[Token(Token = "0x17000674")]
	internal bool ReportValidationWarnings
	{
		[Address(RVA = "0x24AF670", Offset = "0x24AEA70", Length = "0x8")]
		[Token(Token = "0x600171B")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700066D")]
	internal XmlSchemaSet SchemaSet
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60016F8")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700066B")]
	public Uri SourceUri
	{
		[Address(RVA = "0x24AF7A0", Offset = "0x24AEBA0", Length = "0x5B")]
		[Token(Token = "0x60016E5")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000670")]
	private bool StrictlyAssessed
	{
		[Address(RVA = "0x24AF680", Offset = "0x24AEA80", Length = "0x3E")]
		[Token(Token = "0x60016FC")]
		private get { } //Length: 62
	}

	[Token(Token = "0x1700066C")]
	public object ValidationEventSender
	{
		[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
		[Token(Token = "0x60016E6")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700066E")]
	internal XmlSchemaValidationFlags ValidationFlags
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60016F9")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000669")]
	public XmlResolver XmlResolver
	{
		[Address(RVA = "0x20D5140", Offset = "0x20D4540", Length = "0x13")]
		[Token(Token = "0x60016E3")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x24AECB0", Offset = "0x24AE0B0", Length = "0x44B")]
	[Token(Token = "0x600173B")]
	private static XmlSchemaValidator() { }

	[Address(RVA = "0x24AF100", Offset = "0x24AE500", Length = "0x3D8")]
	[Token(Token = "0x60016E0")]
	public XmlSchemaValidator(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	[Address(RVA = "0x24AF4E0", Offset = "0x24AE8E0", Length = "0xAB")]
	[Token(Token = "0x60016E7")]
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	[Address(RVA = "0x24A2CC0", Offset = "0x24A20C0", Length = "0x57A")]
	[Token(Token = "0x6001722")]
	private void AddIdentityConstraints() { }

	[Address(RVA = "0x24A3240", Offset = "0x24A2640", Length = "0x428")]
	[Token(Token = "0x60016E9")]
	public void AddSchema(XmlSchema schema) { }

	[Address(RVA = "0x24A3670", Offset = "0x24A2A70", Length = "0xD6")]
	[Token(Token = "0x600170F")]
	private void AddXmlNamespaceSchema() { }

	[Address(RVA = "0x24A3750", Offset = "0x24A2B50", Length = "0x341")]
	[Token(Token = "0x6001724")]
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x24A3AA0", Offset = "0x24A2EA0", Length = "0x189")]
	[Token(Token = "0x600172E")]
	internal static string BuildElementName(string localName, string ns) { }

	[Address(RVA = "0x24A3C30", Offset = "0x24A3030", Length = "0x69")]
	[Token(Token = "0x600172D")]
	internal static string BuildElementName(XmlQualifiedName qname) { }

	[Address(RVA = "0x24A3CA0", Offset = "0x24A30A0", Length = "0x2AF")]
	[Token(Token = "0x6001714")]
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	[Address(RVA = "0x24A3F50", Offset = "0x24A3350", Length = "0xE1")]
	[Token(Token = "0x600170C")]
	private void CheckElementProperties() { }

	[Address(RVA = "0x24A4040", Offset = "0x24A3440", Length = "0x317")]
	[Token(Token = "0x6001715")]
	private object CheckElementValue(string stringValue) { }

	[Address(RVA = "0x24A4360", Offset = "0x24A3760", Length = "0x12D")]
	[Token(Token = "0x6001718")]
	private void CheckForwardRefs() { }

	[Address(RVA = "0x24A4490", Offset = "0x24A3890", Length = "0x185")]
	[Token(Token = "0x600170E")]
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	[Address(RVA = "0x24A4620", Offset = "0x24A3A20", Length = "0x107")]
	[Token(Token = "0x6001710")]
	internal object CheckMixedValueConstraint(string elementValue) { }

	[Address(RVA = "0x24A4730", Offset = "0x24A3B30", Length = "0x1CA")]
	[Token(Token = "0x600171F")]
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	[Address(RVA = "0x24A4900", Offset = "0x24A3D00", Length = "0x28D")]
	[Token(Token = "0x600171D")]
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	[Address(RVA = "0x24A4B90", Offset = "0x24A3F90", Length = "0x185")]
	[Token(Token = "0x6001716")]
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	[Address(RVA = "0x24A4D20", Offset = "0x24A4120", Length = "0x730")]
	[Token(Token = "0x600170A")]
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

	[Address(RVA = "0x24A5460", Offset = "0x24A4860", Length = "0x5D")]
	[Token(Token = "0x600171E")]
	private void ClearPSVI() { }

	[Address(RVA = "0x24A54C0", Offset = "0x24A48C0", Length = "0x657")]
	[Token(Token = "0x6001727")]
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x24A5B20", Offset = "0x24A4F20", Length = "0x39A")]
	[Token(Token = "0x6001723")]
	private void ElementIdentityConstraints() { }

	[Address(RVA = "0x24A5EC0", Offset = "0x24A52C0", Length = "0xA19")]
	[Token(Token = "0x6001726")]
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	[Address(RVA = "0x24A68E0", Offset = "0x24A5CE0", Length = "0xC08")]
	[Token(Token = "0x6001725")]
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x24A74F0", Offset = "0x24A68F0", Length = "0x224")]
	[Token(Token = "0x60016F6")]
	public void EndValidation() { }

	[Address(RVA = "0x24A7720", Offset = "0x24A6B20", Length = "0x230")]
	[Token(Token = "0x600172B")]
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	[Address(RVA = "0x24A7960", Offset = "0x24A6D60", Length = "0x323")]
	[Token(Token = "0x6001709")]
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	[Address(RVA = "0x24A7C90", Offset = "0x24A7090", Length = "0x22")]
	[Token(Token = "0x6001717")]
	private object FindId(string name) { }

	[Address(RVA = "0x24AF590", Offset = "0x24AE990", Length = "0x3B")]
	[Token(Token = "0x60016FA")]
	internal XmlSchemaContentType get_CurrentContentType() { }

	[Address(RVA = "0x24AF5D0", Offset = "0x24AE9D0", Length = "0x11")]
	[Token(Token = "0x6001719")]
	private bool get_HasIdentityConstraints() { }

	[Address(RVA = "0x24AF5F0", Offset = "0x24AE9F0", Length = "0x47")]
	[Token(Token = "0x60016FD")]
	private bool get_HasSchema() { }

	[Address(RVA = "0x24AF640", Offset = "0x24AEA40", Length = "0x8")]
	[Token(Token = "0x600171A")]
	internal bool get_ProcessIdentityConstraints() { }

	[Address(RVA = "0x24AF650", Offset = "0x24AEA50", Length = "0x11")]
	[Token(Token = "0x600171C")]
	internal bool get_ProcessSchemaHints() { }

	[Address(RVA = "0x24AF670", Offset = "0x24AEA70", Length = "0x8")]
	[Token(Token = "0x600171B")]
	internal bool get_ReportValidationWarnings() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60016F8")]
	internal XmlSchemaSet get_SchemaSet() { }

	[Address(RVA = "0x24AF680", Offset = "0x24AEA80", Length = "0x3E")]
	[Token(Token = "0x60016FC")]
	private bool get_StrictlyAssessed() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60016F9")]
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	[Address(RVA = "0x24A7CC0", Offset = "0x24A70C0", Length = "0x2D")]
	[Token(Token = "0x60016FE")]
	internal string GetConcatenatedValue() { }

	[Address(RVA = "0x24A7CF0", Offset = "0x24A70F0", Length = "0x2AC")]
	[Token(Token = "0x6001721")]
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	[Address(RVA = "0x24A7FA0", Offset = "0x24A73A0", Length = "0x168")]
	[Token(Token = "0x6001720")]
	private XmlSchemaElement GetSchemaElement() { }

	[Address(RVA = "0x24A8110", Offset = "0x24A7510", Length = "0x23F")]
	[Token(Token = "0x6001702")]
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	[Address(RVA = "0x24A8350", Offset = "0x24A7750", Length = "0x6D")]
	[Token(Token = "0x6001705")]
	private string GetTypeName(SchemaDeclBase decl) { }

	[Address(RVA = "0x24A83C0", Offset = "0x24A77C0", Length = "0x738")]
	[Token(Token = "0x60016F7")]
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	[Address(RVA = "0x24A8B00", Offset = "0x24A7F00", Length = "0x446")]
	[Token(Token = "0x60016E1")]
	private void Init() { }

	[Address(RVA = "0x24A8F50", Offset = "0x24A8350", Length = "0x154")]
	[Token(Token = "0x60016EA")]
	public void Initialize() { }

	[Address(RVA = "0x24A90B0", Offset = "0x24A84B0", Length = "0x2D1")]
	[Token(Token = "0x60016EB")]
	public void Initialize(XmlSchemaObject partialValidationType) { }

	[Address(RVA = "0x24A9390", Offset = "0x24A8790", Length = "0x655")]
	[Token(Token = "0x60016FF")]
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	[Address(RVA = "0x24A99F0", Offset = "0x24A8DF0", Length = "0x45A")]
	[Token(Token = "0x6001711")]
	private void LoadSchema(string uri, string url) { }

	[Address(RVA = "0x24A9E50", Offset = "0x24A9250", Length = "0x16B")]
	[Token(Token = "0x6001708")]
	private void Pop() { }

	[Address(RVA = "0x24A9FC0", Offset = "0x24A93C0", Length = "0x576")]
	[Token(Token = "0x6001728")]
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	[Address(RVA = "0x24AAB50", Offset = "0x24A9F50", Length = "0x18E")]
	[Token(Token = "0x6001729")]
	private static string PrintNames(ArrayList expected) { }

	[Address(RVA = "0x24AA540", Offset = "0x24A9940", Length = "0x603")]
	[Token(Token = "0x600172A")]
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	[Address(RVA = "0x24AACE0", Offset = "0x24AA0E0", Length = "0x12F")]
	[Token(Token = "0x600172F")]
	private void ProcessEntity(string name) { }

	[Address(RVA = "0x24AAE10", Offset = "0x24AA210", Length = "0x2EB")]
	[Token(Token = "0x6001700")]
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	[Address(RVA = "0x24AB100", Offset = "0x24AA500", Length = "0x32A")]
	[Token(Token = "0x6001713")]
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	[Address(RVA = "0x24AB430", Offset = "0x24AA830", Length = "0x200")]
	[Token(Token = "0x6001707")]
	private void Push(XmlQualifiedName elementName) { }

	[Address(RVA = "0x24AB640", Offset = "0x24AAA40", Length = "0x69")]
	[Token(Token = "0x600172C")]
	internal static string QNameString(string localName, string ns) { }

	[Address(RVA = "0x24AB6B0", Offset = "0x24AAAB0", Length = "0x6F")]
	[Token(Token = "0x6001712")]
	internal void RecompileSchemaSet() { }

	[Address(RVA = "0x24AF6C0", Offset = "0x24AEAC0", Length = "0xAB")]
	[Token(Token = "0x60016E8")]
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	[Address(RVA = "0x24AB720", Offset = "0x24AAB20", Length = "0xBC")]
	[Token(Token = "0x60016E2")]
	private void Reset() { }

	[Address(RVA = "0x24AB7E0", Offset = "0x24AABE0", Length = "0x48")]
	[Token(Token = "0x6001706")]
	private void SaveTextValue(object value) { }

	[Address(RVA = "0x24AC000", Offset = "0x24AB400", Length = "0x141")]
	[Token(Token = "0x6001734")]
	private void SendValidationEvent(string code, String[] args, Exception innerException, XmlSeverityType severity) { }

	[Address(RVA = "0x24ABCD0", Offset = "0x24AB0D0", Length = "0x19")]
	[Token(Token = "0x6001730")]
	private void SendValidationEvent(string code) { }

	[Address(RVA = "0x24ABC10", Offset = "0x24AB010", Length = "0xB4")]
	[Token(Token = "0x600173A")]
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	[Address(RVA = "0x24AB960", Offset = "0x24AAD60", Length = "0x16B")]
	[Token(Token = "0x6001733")]
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	[Address(RVA = "0x24ABDF0", Offset = "0x24AB1F0", Length = "0x112")]
	[Token(Token = "0x6001731")]
	private void SendValidationEvent(string code, String[] args) { }

	[Address(RVA = "0x24AB840", Offset = "0x24AAC40", Length = "0x11B")]
	[Token(Token = "0x6001735")]
	private void SendValidationEvent(string code, String[] args, Exception innerException) { }

	[Address(RVA = "0x24AB830", Offset = "0x24AAC30", Length = "0xB")]
	[Token(Token = "0x6001736")]
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	[Address(RVA = "0x24ABCF0", Offset = "0x24AB0F0", Length = "0xFD")]
	[Token(Token = "0x6001732")]
	private void SendValidationEvent(string code, string arg) { }

	[Address(RVA = "0x24AC150", Offset = "0x24AB550", Length = "0x11D")]
	[Token(Token = "0x6001738")]
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	[Address(RVA = "0x24ABAD0", Offset = "0x24AAED0", Length = "0x13C")]
	[Token(Token = "0x6001739")]
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	[Address(RVA = "0x24ABF10", Offset = "0x24AB310", Length = "0xE8")]
	[Token(Token = "0x6001737")]
	private void SendValidationEvent(XmlSchemaException e) { }

	[Address(RVA = "0x24AF770", Offset = "0x24AEB70", Length = "0x22")]
	[Token(Token = "0x60016E4")]
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	[Address(RVA = "0x24AF7A0", Offset = "0x24AEBA0", Length = "0x5B")]
	[Token(Token = "0x60016E5")]
	public void set_SourceUri(Uri value) { }

	[Address(RVA = "0x9F1CB0", Offset = "0x9F10B0", Length = "0x13")]
	[Token(Token = "0x60016E6")]
	public void set_ValidationEventSender(object value) { }

	[Address(RVA = "0x20D5140", Offset = "0x20D4540", Length = "0x13")]
	[Token(Token = "0x60016E3")]
	public void set_XmlResolver(XmlResolver value) { }

	[Address(RVA = "0x24AC270", Offset = "0x24AB670", Length = "0x20")]
	[Token(Token = "0x60016FB")]
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	[Address(RVA = "0x24AC290", Offset = "0x24AB690", Length = "0x233")]
	[Token(Token = "0x60016F5")]
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x24AC4D0", Offset = "0x24AB8D0", Length = "0x23A")]
	[Token(Token = "0x600170B")]
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	[Address(RVA = "0x24ACB30", Offset = "0x24ABF30", Length = "0x30D")]
	[Token(Token = "0x6001703")]
	private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

	[Address(RVA = "0x24AC710", Offset = "0x24ABB10", Length = "0x41E")]
	[Token(Token = "0x6001704")]
	private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

	[Address(RVA = "0x24ACE40", Offset = "0x24AC240", Length = "0xA60")]
	[Token(Token = "0x60016EE")]
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x24AD8D0", Offset = "0x24ACCD0", Length = "0x7C")]
	[Token(Token = "0x60016ED")]
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x24ADEC0", Offset = "0x24AD2C0", Length = "0x512")]
	[Token(Token = "0x60016EC")]
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	[Address(RVA = "0x24AD950", Offset = "0x24ACD50", Length = "0x56B")]
	[Token(Token = "0x6001701")]
	private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

	[Address(RVA = "0x24AE3E0", Offset = "0x24AD7E0", Length = "0xB")]
	[Token(Token = "0x60016F4")]
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x24AE3F0", Offset = "0x24AD7F0", Length = "0xCB")]
	[Token(Token = "0x60016EF")]
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x24AE4C0", Offset = "0x24AD8C0", Length = "0x5B")]
	[Token(Token = "0x600170D")]
	private void ValidateStartElementIdentityConstraints() { }

	[Address(RVA = "0x24AE520", Offset = "0x24AD920", Length = "0x6C")]
	[Token(Token = "0x60016F0")]
	public void ValidateText(XmlValueGetter elementValue) { }

	[Address(RVA = "0x24AE590", Offset = "0x24AD990", Length = "0x448")]
	[Token(Token = "0x60016F1")]
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	[Address(RVA = "0x24AEC40", Offset = "0x24AE040", Length = "0x6C")]
	[Token(Token = "0x60016F2")]
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	[Address(RVA = "0x24AE9E0", Offset = "0x24ADDE0", Length = "0x25F")]
	[Token(Token = "0x60016F3")]
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

}

