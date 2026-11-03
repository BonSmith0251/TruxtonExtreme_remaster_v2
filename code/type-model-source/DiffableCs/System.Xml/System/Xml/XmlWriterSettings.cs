namespace System.Xml;

[Token(Token = "0x2000085")]
public sealed class XmlWriterSettings
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003B7")]
	private bool useAsync; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003B8")]
	private Encoding encoding; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003B9")]
	private bool omitXmlDecl; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40003BA")]
	private NewLineHandling newLineHandling; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003BB")]
	private string newLineChars; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003BC")]
	private TriState indent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003BD")]
	private string indentChars; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003BE")]
	private bool newLineOnAttributes; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x40003BF")]
	private bool closeOutput; //Field offset: 0x41
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40003C0")]
	private NamespaceHandling namespaceHandling; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003C1")]
	private ConformanceLevel conformanceLevel; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40003C2")]
	private bool checkCharacters; //Field offset: 0x4C
	[FieldOffset(Offset = "0x4D")]
	[Token(Token = "0x40003C3")]
	private bool writeEndDocumentOnClose; //Field offset: 0x4D
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003C4")]
	private XmlOutputMethod outputMethod; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003C5")]
	private List<XmlQualifiedName> cdataSections; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40003C6")]
	private bool doNotEscapeUriAttributes; //Field offset: 0x60
	[FieldOffset(Offset = "0x61")]
	[Token(Token = "0x40003C7")]
	private bool mergeCDataSections; //Field offset: 0x61
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40003C8")]
	private string mediaType; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40003C9")]
	private string docTypeSystem; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40003CA")]
	private string docTypePublic; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40003CB")]
	private XmlStandalone standalone; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40003CC")]
	private bool autoXmlDecl; //Field offset: 0x84
	[FieldOffset(Offset = "0x85")]
	[Token(Token = "0x40003CD")]
	private bool isReadOnly; //Field offset: 0x85

	[Token(Token = "0x1700016A")]
	public bool Async
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x60006A4")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700017F")]
	internal bool AutoXmlDeclaration
	{
		[Address(RVA = "0x2522A10", Offset = "0x2521E10", Length = "0x8")]
		[Token(Token = "0x60006C3")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000178")]
	internal List<XmlQualifiedName> CDataSectionElements
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60006BC")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000174")]
	public bool CheckCharacters
	{
		[Address(RVA = "0x1CF2CC0", Offset = "0x1CF20C0", Length = "0x5")]
		[Token(Token = "0x60006B5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000172")]
	public bool CloseOutput
	{
		[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
		[Token(Token = "0x60006B1")]
		 get { } //Length: 5
		[Address(RVA = "0x2522AA0", Offset = "0x2521EA0", Length = "0x4D")]
		[Token(Token = "0x60006B2")]
		 set { } //Length: 77
	}

	[Token(Token = "0x17000173")]
	public ConformanceLevel ConformanceLevel
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x60006B3")]
		 get { } //Length: 4
		[Address(RVA = "0x2522AF0", Offset = "0x2521EF0", Length = "0x98")]
		[Token(Token = "0x60006B4")]
		 set { } //Length: 152
	}

	[Token(Token = "0x1700017D")]
	internal string DocTypePublic
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x60006C1")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700017C")]
	internal string DocTypeSystem
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x60006C0")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000179")]
	public bool DoNotEscapeUriAttributes
	{
		[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
		[Token(Token = "0x60006BD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700016B")]
	public Encoding Encoding
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60006A5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700016F")]
	public bool Indent
	{
		[Address(RVA = "0x2522A20", Offset = "0x2521E20", Length = "0x8")]
		[Token(Token = "0x60006AB")]
		 get { } //Length: 8
		[Address(RVA = "0x2522C40", Offset = "0x2522040", Length = "0x56")]
		[Token(Token = "0x60006AC")]
		 set { } //Length: 86
	}

	[Token(Token = "0x17000170")]
	public string IndentChars
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60006AD")]
		 get { } //Length: 5
		[Address(RVA = "0x2522B90", Offset = "0x2521F90", Length = "0xA5")]
		[Token(Token = "0x60006AE")]
		 set { } //Length: 165
	}

	[Token(Token = "0x17000180")]
	internal TriState IndentInternal
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x60006C4")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000181")]
	internal bool IsQuerySpecific
	{
		[Address(RVA = "0x2522A30", Offset = "0x2521E30", Length = "0x5F")]
		[Token(Token = "0x60006C5")]
		internal get { } //Length: 95
	}

	[Token(Token = "0x1700017B")]
	internal string MediaType
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x60006BF")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700017A")]
	internal bool MergeCDataSections
	{
		[Address(RVA = "0x1D3B270", Offset = "0x1D3A670", Length = "0x5")]
		[Token(Token = "0x60006BE")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000175")]
	public NamespaceHandling NamespaceHandling
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[Token(Token = "0x60006B6")]
		 get { } //Length: 4
		[Address(RVA = "0x2522CA0", Offset = "0x25220A0", Length = "0x98")]
		[Token(Token = "0x60006B7")]
		 set { } //Length: 152
	}

	[Token(Token = "0x1700016E")]
	public string NewLineChars
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60006A9")]
		 get { } //Length: 5
		[Address(RVA = "0x2522D40", Offset = "0x2522140", Length = "0xA5")]
		[Token(Token = "0x60006AA")]
		 set { } //Length: 165
	}

	[Token(Token = "0x1700016D")]
	public NewLineHandling NewLineHandling
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x60006A8")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000171")]
	public bool NewLineOnAttributes
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x60006AF")]
		 get { } //Length: 5
		[Address(RVA = "0x2522DF0", Offset = "0x25221F0", Length = "0x4D")]
		[Token(Token = "0x60006B0")]
		 set { } //Length: 77
	}

	[Token(Token = "0x1700016C")]
	public bool OmitXmlDeclaration
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x60006A6")]
		 get { } //Length: 5
		[Address(RVA = "0x2522E40", Offset = "0x2522240", Length = "0x4D")]
		[Token(Token = "0x60006A7")]
		 set { } //Length: 77
	}

	[Token(Token = "0x17000177")]
	public internal XmlOutputMethod OutputMethod
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x60006B9")]
		 get { } //Length: 4
		[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
		[Token(Token = "0x60006BA")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000182")]
	internal bool ReadOnly
	{
		[Address(RVA = "0x5ABF30", Offset = "0x5AB330", Length = "0x7")]
		[Token(Token = "0x60006C9")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700017E")]
	internal XmlStandalone Standalone
	{
		[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
		[Token(Token = "0x60006C2")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x17000176")]
	public bool WriteEndDocumentOnClose
	{
		[Address(RVA = "0x2522A90", Offset = "0x2521E90", Length = "0x5")]
		[Token(Token = "0x60006B8")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2522890", Offset = "0x2521C90", Length = "0x17D")]
	[Token(Token = "0x60006A3")]
	public XmlWriterSettings() { }

	[Address(RVA = "0x2521C50", Offset = "0x2521050", Length = "0xAF")]
	[Token(Token = "0x60006CA")]
	private void CheckReadOnly(string propertyName) { }

	[Address(RVA = "0x2521D00", Offset = "0x2521100", Length = "0xE0")]
	[Token(Token = "0x60006BB")]
	public XmlWriterSettings Clone() { }

	[Address(RVA = "0x2522490", Offset = "0x2521890", Length = "0x2C7")]
	[Token(Token = "0x60006C8")]
	internal XmlWriter CreateWriter(TextWriter output) { }

	[Address(RVA = "0x2522050", Offset = "0x2521450", Length = "0x437")]
	[Token(Token = "0x60006C7")]
	internal XmlWriter CreateWriter(Stream output) { }

	[Address(RVA = "0x2521DF0", Offset = "0x25211F0", Length = "0x25B")]
	[Token(Token = "0x60006C6")]
	internal XmlWriter CreateWriter(string outputFileName) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x60006A4")]
	public bool get_Async() { }

	[Address(RVA = "0x2522A10", Offset = "0x2521E10", Length = "0x8")]
	[Token(Token = "0x60006C3")]
	internal bool get_AutoXmlDeclaration() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60006BC")]
	internal List<XmlQualifiedName> get_CDataSectionElements() { }

	[Address(RVA = "0x1CF2CC0", Offset = "0x1CF20C0", Length = "0x5")]
	[Token(Token = "0x60006B5")]
	public bool get_CheckCharacters() { }

	[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
	[Token(Token = "0x60006B1")]
	public bool get_CloseOutput() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x60006B3")]
	public ConformanceLevel get_ConformanceLevel() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x60006C1")]
	internal string get_DocTypePublic() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[Token(Token = "0x60006C0")]
	internal string get_DocTypeSystem() { }

	[Address(RVA = "0x1E9FB00", Offset = "0x1E9EF00", Length = "0x5")]
	[Token(Token = "0x60006BD")]
	public bool get_DoNotEscapeUriAttributes() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60006A5")]
	public Encoding get_Encoding() { }

	[Address(RVA = "0x2522A20", Offset = "0x2521E20", Length = "0x8")]
	[Token(Token = "0x60006AB")]
	public bool get_Indent() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60006AD")]
	public string get_IndentChars() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x60006C4")]
	internal TriState get_IndentInternal() { }

	[Address(RVA = "0x2522A30", Offset = "0x2521E30", Length = "0x5F")]
	[Token(Token = "0x60006C5")]
	internal bool get_IsQuerySpecific() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x60006BF")]
	internal string get_MediaType() { }

	[Address(RVA = "0x1D3B270", Offset = "0x1D3A670", Length = "0x5")]
	[Token(Token = "0x60006BE")]
	internal bool get_MergeCDataSections() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[Token(Token = "0x60006B6")]
	public NamespaceHandling get_NamespaceHandling() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60006A9")]
	public string get_NewLineChars() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x60006A8")]
	public NewLineHandling get_NewLineHandling() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x60006AF")]
	public bool get_NewLineOnAttributes() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x60006A6")]
	public bool get_OmitXmlDeclaration() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x60006B9")]
	public XmlOutputMethod get_OutputMethod() { }

	[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
	[Token(Token = "0x60006C2")]
	internal XmlStandalone get_Standalone() { }

	[Address(RVA = "0x2522A90", Offset = "0x2521E90", Length = "0x5")]
	[Token(Token = "0x60006B8")]
	public bool get_WriteEndDocumentOnClose() { }

	[Address(RVA = "0x2522760", Offset = "0x2521B60", Length = "0x121")]
	[Token(Token = "0x60006CB")]
	private void Initialize() { }

	[Address(RVA = "0x2522AA0", Offset = "0x2521EA0", Length = "0x4D")]
	[Token(Token = "0x60006B2")]
	public void set_CloseOutput(bool value) { }

	[Address(RVA = "0x2522AF0", Offset = "0x2521EF0", Length = "0x98")]
	[Token(Token = "0x60006B4")]
	public void set_ConformanceLevel(ConformanceLevel value) { }

	[Address(RVA = "0x2522C40", Offset = "0x2522040", Length = "0x56")]
	[Token(Token = "0x60006AC")]
	public void set_Indent(bool value) { }

	[Address(RVA = "0x2522B90", Offset = "0x2521F90", Length = "0xA5")]
	[Token(Token = "0x60006AE")]
	public void set_IndentChars(string value) { }

	[Address(RVA = "0x2522CA0", Offset = "0x25220A0", Length = "0x98")]
	[Token(Token = "0x60006B7")]
	public void set_NamespaceHandling(NamespaceHandling value) { }

	[Address(RVA = "0x2522D40", Offset = "0x2522140", Length = "0xA5")]
	[Token(Token = "0x60006AA")]
	public void set_NewLineChars(string value) { }

	[Address(RVA = "0x2522DF0", Offset = "0x25221F0", Length = "0x4D")]
	[Token(Token = "0x60006B0")]
	public void set_NewLineOnAttributes(bool value) { }

	[Address(RVA = "0x2522E40", Offset = "0x2522240", Length = "0x4D")]
	[Token(Token = "0x60006A7")]
	public void set_OmitXmlDeclaration(bool value) { }

	[Address(RVA = "0x1E07600", Offset = "0x1E06A00", Length = "0x4")]
	[Token(Token = "0x60006BA")]
	internal void set_OutputMethod(XmlOutputMethod value) { }

	[Address(RVA = "0x5ABF30", Offset = "0x5AB330", Length = "0x7")]
	[Token(Token = "0x60006C9")]
	internal void set_ReadOnly(bool value) { }

}

