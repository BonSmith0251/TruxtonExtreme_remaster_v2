namespace System.Xml.Schema;

[Token(Token = "0x2000151")]
internal class BaseValidator
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000716")]
	private XmlSchemaCollection schemaCollection; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000717")]
	private IValidationEventHandling eventHandling; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000718")]
	private XmlNameTable nameTable; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000719")]
	private SchemaNames schemaNames; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400071A")]
	private PositionInfo positionInfo; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400071B")]
	private XmlResolver xmlResolver; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400071C")]
	private Uri baseUri; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400071D")]
	protected SchemaInfo schemaInfo; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400071E")]
	protected XmlValidatingReaderImpl reader; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400071F")]
	protected XmlQualifiedName elementName; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000720")]
	protected ValidationState context; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000721")]
	protected StringBuilder textValue; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000722")]
	protected string textString; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000723")]
	protected bool hasSibling; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x4000724")]
	protected bool checkDatatype; //Field offset: 0x79

	[Token(Token = "0x170003C9")]
	public Uri BaseUri
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000E9D")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x6000E9E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170003CC")]
	public IDtdInfo DtdInfo
	{
		[Address(RVA = "0x257E4A0", Offset = "0x257D8A0", Length = "0xD0")]
		[Token(Token = "0x6000EA1")]
		 set { } //Length: 208
	}

	[Token(Token = "0x170003CA")]
	public ValidationEventHandler EventHandler
	{
		[Address(RVA = "0x257E370", Offset = "0x257D770", Length = "0x78")]
		[Token(Token = "0x6000E9F")]
		 get { } //Length: 120
	}

	[Token(Token = "0x170003C5")]
	public XmlNameTable NameTable
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000E98")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003C7")]
	public PositionInfo PositionInfo
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6000E9A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003CD")]
	public override bool PreserveWhitespace
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000EA2")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170003C3")]
	public XmlValidatingReaderImpl Reader
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x6000E96")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003C4")]
	public XmlSchemaCollection SchemaCollection
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000E97")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003CB")]
	public SchemaInfo SchemaInfo
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x6000EA0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003C6")]
	public SchemaNames SchemaNames
	{
		[Address(RVA = "0x257E3F0", Offset = "0x257D7F0", Length = "0xAD")]
		[Token(Token = "0x6000E99")]
		 get { } //Length: 173
	}

	[Token(Token = "0x170003C8")]
	public XmlResolver XmlResolver
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000E9B")]
		 get { } //Length: 5
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x6000E9C")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x257E2A0", Offset = "0x257D6A0", Length = "0xC8")]
	[Token(Token = "0x6000E94")]
	public BaseValidator(BaseValidator other) { }

	[Address(RVA = "0x257E1A0", Offset = "0x257D5A0", Length = "0xFD")]
	[Token(Token = "0x6000E95")]
	public BaseValidator(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000EA4")]
	public override void CompleteValidation() { }

	[Address(RVA = "0x257D160", Offset = "0x257C560", Length = "0x1DD")]
	[Token(Token = "0x6000EB2")]
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000EA5")]
	public override object FindId(string name) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000E9D")]
	public Uri get_BaseUri() { }

	[Address(RVA = "0x257E370", Offset = "0x257D770", Length = "0x78")]
	[Token(Token = "0x6000E9F")]
	public ValidationEventHandler get_EventHandler() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000E98")]
	public XmlNameTable get_NameTable() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x6000E9A")]
	public PositionInfo get_PositionInfo() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000EA2")]
	public override bool get_PreserveWhitespace() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x6000E96")]
	public XmlValidatingReaderImpl get_Reader() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000E97")]
	public XmlSchemaCollection get_SchemaCollection() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x6000EA0")]
	public SchemaInfo get_SchemaInfo() { }

	[Address(RVA = "0x257E3F0", Offset = "0x257D7F0", Length = "0xAD")]
	[Token(Token = "0x6000E99")]
	public SchemaNames get_SchemaNames() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000E9B")]
	public XmlResolver get_XmlResolver() { }

	[Address(RVA = "0x257D510", Offset = "0x257C910", Length = "0x1A4")]
	[Token(Token = "0x6000EB1")]
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	[Address(RVA = "0x257D340", Offset = "0x257C740", Length = "0x1C9")]
	[Token(Token = "0x6000EB0")]
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	[Address(RVA = "0x257D6C0", Offset = "0x257CAC0", Length = "0x77")]
	[Token(Token = "0x6000EA8")]
	private void SaveTextValue(string value) { }

	[Address(RVA = "0x257D880", Offset = "0x257CC80", Length = "0x11D")]
	[Token(Token = "0x6000EAD")]
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	[Address(RVA = "0x257D9A0", Offset = "0x257CDA0", Length = "0x80")]
	[Token(Token = "0x6000EAC")]
	protected void SendValidationEvent(XmlSchemaException e) { }

	[Address(RVA = "0x257DA30", Offset = "0x257CE30", Length = "0x109")]
	[Token(Token = "0x6000EAB")]
	protected void SendValidationEvent(string code, string arg) { }

	[Address(RVA = "0x257DBD0", Offset = "0x257CFD0", Length = "0x109")]
	[Token(Token = "0x6000EAA")]
	protected void SendValidationEvent(string code, String[] args) { }

	[Address(RVA = "0x257DB40", Offset = "0x257CF40", Length = "0x8F")]
	[Token(Token = "0x6000EAF")]
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	[Address(RVA = "0x257D740", Offset = "0x257CB40", Length = "0x11D")]
	[Token(Token = "0x6000EAE")]
	protected void SendValidationEvent(string code, String[] args, XmlSeverityType severity) { }

	[Address(RVA = "0x257D860", Offset = "0x257CC60", Length = "0x19")]
	[Token(Token = "0x6000EA9")]
	protected void SendValidationEvent(string code) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x6000E9E")]
	public void set_BaseUri(Uri value) { }

	[Address(RVA = "0x257E4A0", Offset = "0x257D8A0", Length = "0xD0")]
	[Token(Token = "0x6000EA1")]
	public void set_DtdInfo(IDtdInfo value) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x6000E9C")]
	public void set_XmlResolver(XmlResolver value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000EA3")]
	public override void Validate() { }

	[Address(RVA = "0x257DCE0", Offset = "0x257D0E0", Length = "0x36D")]
	[Token(Token = "0x6000EA6")]
	public void ValidateText() { }

	[Address(RVA = "0x257E050", Offset = "0x257D450", Length = "0x144")]
	[Token(Token = "0x6000EA7")]
	public void ValidateWhitespace() { }

}

