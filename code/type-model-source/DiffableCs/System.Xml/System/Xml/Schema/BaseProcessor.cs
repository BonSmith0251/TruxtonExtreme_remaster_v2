namespace System.Xml.Schema;

[Token(Token = "0x2000150")]
internal class BaseProcessor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000710")]
	private XmlNameTable nameTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000711")]
	private SchemaNames schemaNames; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000712")]
	private ValidationEventHandler eventHandler; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000713")]
	private XmlSchemaCompilationSettings compilationSettings; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000714")]
	private int errorCount; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000715")]
	private string NsXml; //Field offset: 0x38

	[Token(Token = "0x170003C1")]
	protected XmlSchemaCompilationSettings CompilationSettings
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000E84")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003C0")]
	protected ValidationEventHandler EventHandler
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000E83")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003C2")]
	protected bool HasErrors
	{
		[Address(RVA = "0x1EB0750", Offset = "0x1EAFB50", Length = "0x8")]
		[Token(Token = "0x6000E85")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003BE")]
	protected XmlNameTable NameTable
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000E81")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003BF")]
	protected SchemaNames SchemaNames
	{
		[Address(RVA = "0x257D0E0", Offset = "0x257C4E0", Length = "0x7B")]
		[Token(Token = "0x6000E82")]
		 get { } //Length: 123
	}

	[Address(RVA = "0x257CEE0", Offset = "0x257C2E0", Length = "0x112")]
	[Token(Token = "0x6000E7F")]
	public BaseProcessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	[Address(RVA = "0x257D000", Offset = "0x257C400", Length = "0xD3")]
	[Token(Token = "0x6000E80")]
	public BaseProcessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	[Address(RVA = "0x257BB00", Offset = "0x257AF00", Length = "0x6BC")]
	[Token(Token = "0x6000E86")]
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000E84")]
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000E83")]
	protected ValidationEventHandler get_EventHandler() { }

	[Address(RVA = "0x1EB0750", Offset = "0x1EAFB50", Length = "0x8")]
	[Token(Token = "0x6000E85")]
	protected bool get_HasErrors() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000E81")]
	protected XmlNameTable get_NameTable() { }

	[Address(RVA = "0x257D0E0", Offset = "0x257C4E0", Length = "0x7B")]
	[Token(Token = "0x6000E82")]
	protected SchemaNames get_SchemaNames() { }

	[Address(RVA = "0x257C1C0", Offset = "0x257B5C0", Length = "0x126")]
	[Token(Token = "0x6000E87")]
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	[Address(RVA = "0x257C2F0", Offset = "0x257B6F0", Length = "0x122")]
	[Token(Token = "0x6000E88")]
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	[Address(RVA = "0x257C420", Offset = "0x257B820", Length = "0x127")]
	[Token(Token = "0x6000E89")]
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	[Address(RVA = "0x257CBD0", Offset = "0x257BFD0", Length = "0xEE")]
	[Token(Token = "0x6000E8A")]
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	[Address(RVA = "0x257C7E0", Offset = "0x257BBE0", Length = "0x106")]
	[Token(Token = "0x6000E8B")]
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	[Address(RVA = "0x257CCC0", Offset = "0x257C0C0", Length = "0x16B")]
	[Token(Token = "0x6000E8C")]
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	[Address(RVA = "0x257CA70", Offset = "0x257BE70", Length = "0x158")]
	[Token(Token = "0x6000E8D")]
	protected void SendValidationEvent(string code, String[] args, Exception innerException, XmlSchemaObject source) { }

	[Address(RVA = "0x257C8F0", Offset = "0x257BCF0", Length = "0x17E")]
	[Token(Token = "0x6000E8E")]
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	[Address(RVA = "0x257C6B0", Offset = "0x257BAB0", Length = "0x8D")]
	[Token(Token = "0x6000E8F")]
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	[Address(RVA = "0x257CE30", Offset = "0x257C230", Length = "0xA5")]
	[Token(Token = "0x6000E90")]
	protected void SendValidationEvent(XmlSchemaException e) { }

	[Address(RVA = "0x257C740", Offset = "0x257BB40", Length = "0x98")]
	[Token(Token = "0x6000E91")]
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	[Address(RVA = "0x257C5F0", Offset = "0x257B9F0", Length = "0xBC")]
	[Token(Token = "0x6000E92")]
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	[Address(RVA = "0x257C550", Offset = "0x257B950", Length = "0x94")]
	[Token(Token = "0x6000E93")]
	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }

}

