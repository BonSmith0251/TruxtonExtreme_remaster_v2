namespace System.Xml;

[Token(Token = "0x2000052")]
public sealed class XmlReaderSettings
{
	[Token(Token = "0x40001CA")]
	private static Nullable<Boolean> s_enableLegacyXmlSettings; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001B6")]
	private bool useAsync; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001B7")]
	private XmlNameTable nameTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001B8")]
	private XmlResolver xmlResolver; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001B9")]
	private int lineNumberOffset; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40001BA")]
	private int linePositionOffset; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001BB")]
	private ConformanceLevel conformanceLevel; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40001BC")]
	private bool checkCharacters; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001BD")]
	private long maxCharactersInDocument; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001BE")]
	private long maxCharactersFromEntities; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001BF")]
	private bool ignoreWhitespace; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x40001C0")]
	private bool ignorePIs; //Field offset: 0x49
	[FieldOffset(Offset = "0x4A")]
	[Token(Token = "0x40001C1")]
	private bool ignoreComments; //Field offset: 0x4A
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40001C2")]
	private DtdProcessing dtdProcessing; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001C3")]
	private ValidationType validationType; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40001C4")]
	private XmlSchemaValidationFlags validationFlags; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001C5")]
	private XmlSchemaSet schemas; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001C6")]
	private ValidationEventHandler valEventHandler; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001C7")]
	private bool closeInput; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x40001C8")]
	private bool isReadOnly; //Field offset: 0x69
	[CompilerGenerated]
	[FieldOffset(Offset = "0x6A")]
	[Token(Token = "0x40001C9")]
	private bool <IsXmlResolverSet>k__BackingField; //Field offset: 0x6A

	[Token(Token = "0x170000A7")]
	public bool Async
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x600036F")]
		 get { } //Length: 5
		[Address(RVA = "0x24F8C70", Offset = "0x24F8070", Length = "0x4D")]
		[Token(Token = "0x6000370")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000AE")]
	public bool CheckCharacters
	{
		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[Token(Token = "0x600037E")]
		 get { } //Length: 5
		[Address(RVA = "0x24F8CC0", Offset = "0x24F80C0", Length = "0x4D")]
		[Token(Token = "0x600037F")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B5")]
	public bool CloseInput
	{
		[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
		[Token(Token = "0x600038C")]
		 get { } //Length: 5
		[Address(RVA = "0x24F8D10", Offset = "0x24F8110", Length = "0x4D")]
		[Token(Token = "0x600038D")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000AD")]
	public ConformanceLevel ConformanceLevel
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x600037C")]
		 get { } //Length: 4
		[Address(RVA = "0x24F8D60", Offset = "0x24F8160", Length = "0x98")]
		[Token(Token = "0x600037D")]
		 set { } //Length: 152
	}

	[Token(Token = "0x170000B4")]
	public DtdProcessing DtdProcessing
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x600038A")]
		 get { } //Length: 4
		[Address(RVA = "0x24F8E00", Offset = "0x24F8200", Length = "0x98")]
		[Token(Token = "0x600038B")]
		 set { } //Length: 152
	}

	[Token(Token = "0x170000B3")]
	public bool IgnoreComments
	{
		[Address(RVA = "0x24F8BD0", Offset = "0x24F7FD0", Length = "0x5")]
		[Token(Token = "0x6000388")]
		 get { } //Length: 5
		[Address(RVA = "0x24F8EA0", Offset = "0x24F82A0", Length = "0x4D")]
		[Token(Token = "0x6000389")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B2")]
	public bool IgnoreProcessingInstructions
	{
		[Address(RVA = "0x24F8BE0", Offset = "0x24F7FE0", Length = "0x5")]
		[Token(Token = "0x6000386")]
		 get { } //Length: 5
		[Address(RVA = "0x24F8EF0", Offset = "0x24F82F0", Length = "0x4D")]
		[Token(Token = "0x6000387")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000B1")]
	public bool IgnoreWhitespace
	{
		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[Token(Token = "0x6000384")]
		 get { } //Length: 5
		[Address(RVA = "0x24F8F40", Offset = "0x24F8340", Length = "0x4D")]
		[Token(Token = "0x6000385")]
		 set { } //Length: 77
	}

	[Token(Token = "0x170000A9")]
	internal bool IsXmlResolverSet
	{
		[Address(RVA = "0x24F8BF0", Offset = "0x24F7FF0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000373")]
		internal get { } //Length: 5
		[Address(RVA = "0x24F8F90", Offset = "0x24F8390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000374")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170000AB")]
	public int LineNumberOffset
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000378")]
		 get { } //Length: 4
		[Address(RVA = "0x24F8FA0", Offset = "0x24F83A0", Length = "0x4B")]
		[Token(Token = "0x6000379")]
		 set { } //Length: 75
	}

	[Token(Token = "0x170000AC")]
	public int LinePositionOffset
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x600037A")]
		 get { } //Length: 4
		[Address(RVA = "0x24F8FF0", Offset = "0x24F83F0", Length = "0x4B")]
		[Token(Token = "0x600037B")]
		 set { } //Length: 75
	}

	[Token(Token = "0x170000B0")]
	public long MaxCharactersFromEntities
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x6000382")]
		 get { } //Length: 5
		[Address(RVA = "0x24F9040", Offset = "0x24F8440", Length = "0x9A")]
		[Token(Token = "0x6000383")]
		 set { } //Length: 154
	}

	[Token(Token = "0x170000AF")]
	public long MaxCharactersInDocument
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000380")]
		 get { } //Length: 5
		[Address(RVA = "0x24F90E0", Offset = "0x24F84E0", Length = "0x9A")]
		[Token(Token = "0x6000381")]
		 set { } //Length: 154
	}

	[Token(Token = "0x170000A8")]
	public XmlNameTable NameTable
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000371")]
		 get { } //Length: 5
		[Address(RVA = "0x24F9180", Offset = "0x24F8580", Length = "0x58")]
		[Token(Token = "0x6000372")]
		 set { } //Length: 88
	}

	[Token(Token = "0x170000B9")]
	internal bool ReadOnly
	{
		[Address(RVA = "0x16D0A60", Offset = "0x16CFE60", Length = "0x4")]
		[Token(Token = "0x6000398")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170000B8")]
	public XmlSchemaSet Schemas
	{
		[Address(RVA = "0x24F8C00", Offset = "0x24F8000", Length = "0x69")]
		[Token(Token = "0x6000392")]
		 get { } //Length: 105
		[Address(RVA = "0x24F91E0", Offset = "0x24F85E0", Length = "0x58")]
		[Token(Token = "0x6000393")]
		 set { } //Length: 88
	}

	[Token(Token = "0x170000B7")]
	public XmlSchemaValidationFlags ValidationFlags
	{
		[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
		[Token(Token = "0x6000390")]
		 get { } //Length: 4
		[Address(RVA = "0x24F9240", Offset = "0x24F8640", Length = "0x98")]
		[Token(Token = "0x6000391")]
		 set { } //Length: 152
	}

	[Token(Token = "0x170000B6")]
	public ValidationType ValidationType
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x600038E")]
		 get { } //Length: 4
		[Address(RVA = "0x24F92E0", Offset = "0x24F86E0", Length = "0x98")]
		[Token(Token = "0x600038F")]
		 set { } //Length: 152
	}

	[Token(Token = "0x170000AA")]
	public XmlResolver XmlResolver
	{
		[Address(RVA = "0x24F9380", Offset = "0x24F8780", Length = "0x5D")]
		[Token(Token = "0x6000375")]
		 set { } //Length: 93
	}

	[Address(RVA = "0x24F8AE0", Offset = "0x24F7EE0", Length = "0xEE")]
	[Token(Token = "0x600036E")]
	public XmlReaderSettings() { }

	[Address(RVA = "0x24F8210", Offset = "0x24F7610", Length = "0x131")]
	[Token(Token = "0x600039D")]
	internal XmlReader AddValidation(XmlReader reader) { }

	[Address(RVA = "0x24F8350", Offset = "0x24F7750", Length = "0xAC")]
	[Token(Token = "0x6000399")]
	private void CheckReadOnly(string propertyName) { }

	[Address(RVA = "0x24F8400", Offset = "0x24F7800", Length = "0x5B")]
	[Token(Token = "0x6000394")]
	public XmlReaderSettings Clone() { }

	[Address(RVA = "0x24F8460", Offset = "0x24F7860", Length = "0x44")]
	[Token(Token = "0x600039C")]
	private static XmlResolver CreateDefaultResolver() { }

	[Address(RVA = "0x24F84B0", Offset = "0x24F78B0", Length = "0x82")]
	[Token(Token = "0x600039E")]
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	[Address(RVA = "0x24F8540", Offset = "0x24F7940", Length = "0x11F")]
	[Token(Token = "0x6000397")]
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	[Address(RVA = "0x24F8660", Offset = "0x24F7A60", Length = "0x19B")]
	[Token(Token = "0x6000396")]
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	[Address(RVA = "0x24F8800", Offset = "0x24F7C00", Length = "0xCB")]
	[Token(Token = "0x600039F")]
	internal static bool EnableLegacyXmlSettings() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x600036F")]
	public bool get_Async() { }

	[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
	[Token(Token = "0x600037E")]
	public bool get_CheckCharacters() { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[Token(Token = "0x600038C")]
	public bool get_CloseInput() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x600037C")]
	public ConformanceLevel get_ConformanceLevel() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x600038A")]
	public DtdProcessing get_DtdProcessing() { }

	[Address(RVA = "0x24F8BD0", Offset = "0x24F7FD0", Length = "0x5")]
	[Token(Token = "0x6000388")]
	public bool get_IgnoreComments() { }

	[Address(RVA = "0x24F8BE0", Offset = "0x24F7FE0", Length = "0x5")]
	[Token(Token = "0x6000386")]
	public bool get_IgnoreProcessingInstructions() { }

	[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
	[Token(Token = "0x6000384")]
	public bool get_IgnoreWhitespace() { }

	[Address(RVA = "0x24F8BF0", Offset = "0x24F7FF0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000373")]
	internal bool get_IsXmlResolverSet() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000378")]
	public int get_LineNumberOffset() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x600037A")]
	public int get_LinePositionOffset() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x6000382")]
	public long get_MaxCharactersFromEntities() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000380")]
	public long get_MaxCharactersInDocument() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000371")]
	public XmlNameTable get_NameTable() { }

	[Address(RVA = "0x24F8C00", Offset = "0x24F8000", Length = "0x69")]
	[Token(Token = "0x6000392")]
	public XmlSchemaSet get_Schemas() { }

	[Address(RVA = "0xE22970", Offset = "0xE21D70", Length = "0x4")]
	[Token(Token = "0x6000390")]
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x600038E")]
	public ValidationType get_ValidationType() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x6000395")]
	internal ValidationEventHandler GetEventHandler() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000376")]
	internal XmlResolver GetXmlResolver() { }

	[Address(RVA = "0x24F88D0", Offset = "0x24F7CD0", Length = "0x2C")]
	[Token(Token = "0x6000377")]
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	[Address(RVA = "0x24F8900", Offset = "0x24F7D00", Length = "0xE6")]
	[Token(Token = "0x600039B")]
	private void Initialize(XmlResolver resolver) { }

	[Address(RVA = "0x24F89F0", Offset = "0x24F7DF0", Length = "0xE7")]
	[Token(Token = "0x600039A")]
	private void Initialize() { }

	[Address(RVA = "0x24F8C70", Offset = "0x24F8070", Length = "0x4D")]
	[Token(Token = "0x6000370")]
	public void set_Async(bool value) { }

	[Address(RVA = "0x24F8CC0", Offset = "0x24F80C0", Length = "0x4D")]
	[Token(Token = "0x600037F")]
	public void set_CheckCharacters(bool value) { }

	[Address(RVA = "0x24F8D10", Offset = "0x24F8110", Length = "0x4D")]
	[Token(Token = "0x600038D")]
	public void set_CloseInput(bool value) { }

	[Address(RVA = "0x24F8D60", Offset = "0x24F8160", Length = "0x98")]
	[Token(Token = "0x600037D")]
	public void set_ConformanceLevel(ConformanceLevel value) { }

	[Address(RVA = "0x24F8E00", Offset = "0x24F8200", Length = "0x98")]
	[Token(Token = "0x600038B")]
	public void set_DtdProcessing(DtdProcessing value) { }

	[Address(RVA = "0x24F8EA0", Offset = "0x24F82A0", Length = "0x4D")]
	[Token(Token = "0x6000389")]
	public void set_IgnoreComments(bool value) { }

	[Address(RVA = "0x24F8EF0", Offset = "0x24F82F0", Length = "0x4D")]
	[Token(Token = "0x6000387")]
	public void set_IgnoreProcessingInstructions(bool value) { }

	[Address(RVA = "0x24F8F40", Offset = "0x24F8340", Length = "0x4D")]
	[Token(Token = "0x6000385")]
	public void set_IgnoreWhitespace(bool value) { }

	[Address(RVA = "0x24F8F90", Offset = "0x24F8390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000374")]
	internal void set_IsXmlResolverSet(bool value) { }

	[Address(RVA = "0x24F8FA0", Offset = "0x24F83A0", Length = "0x4B")]
	[Token(Token = "0x6000379")]
	public void set_LineNumberOffset(int value) { }

	[Address(RVA = "0x24F8FF0", Offset = "0x24F83F0", Length = "0x4B")]
	[Token(Token = "0x600037B")]
	public void set_LinePositionOffset(int value) { }

	[Address(RVA = "0x24F9040", Offset = "0x24F8440", Length = "0x9A")]
	[Token(Token = "0x6000383")]
	public void set_MaxCharactersFromEntities(long value) { }

	[Address(RVA = "0x24F90E0", Offset = "0x24F84E0", Length = "0x9A")]
	[Token(Token = "0x6000381")]
	public void set_MaxCharactersInDocument(long value) { }

	[Address(RVA = "0x24F9180", Offset = "0x24F8580", Length = "0x58")]
	[Token(Token = "0x6000372")]
	public void set_NameTable(XmlNameTable value) { }

	[Address(RVA = "0x16D0A60", Offset = "0x16CFE60", Length = "0x4")]
	[Token(Token = "0x6000398")]
	internal void set_ReadOnly(bool value) { }

	[Address(RVA = "0x24F91E0", Offset = "0x24F85E0", Length = "0x58")]
	[Token(Token = "0x6000393")]
	public void set_Schemas(XmlSchemaSet value) { }

	[Address(RVA = "0x24F9240", Offset = "0x24F8640", Length = "0x98")]
	[Token(Token = "0x6000391")]
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	[Address(RVA = "0x24F92E0", Offset = "0x24F86E0", Length = "0x98")]
	[Token(Token = "0x600038F")]
	public void set_ValidationType(ValidationType value) { }

	[Address(RVA = "0x24F9380", Offset = "0x24F8780", Length = "0x5D")]
	[Token(Token = "0x6000375")]
	public void set_XmlResolver(XmlResolver value) { }

}

