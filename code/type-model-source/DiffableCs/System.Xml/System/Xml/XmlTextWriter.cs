namespace System.Xml;

[EditorBrowsable(EditorBrowsableState::Never (1))]
[Token(Token = "0x2000066")]
public class XmlTextWriter : XmlWriter
{
	[Token(Token = "0x2000069")]
	private struct Namespace
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002CA")]
		internal string prefix; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002CB")]
		internal string ns; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002CC")]
		internal bool declared; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40002CD")]
		internal int prevNsIndex; //Field offset: 0x14

		[Address(RVA = "0x24FDD10", Offset = "0x24FD110", Length = "0x4C")]
		[Token(Token = "0x600057F")]
		internal void Set(string prefix, string ns, bool declared) { }

	}

	[Token(Token = "0x2000067")]
	private enum NamespaceState : int
	{
		Uninitialized = 0,
		NotDeclaredButInScope = 1,
		DeclaredButNotWrittenOut = 2,
		DeclaredAndWrittenOut = 3,
	}

	[Token(Token = "0x200006A")]
	private enum SpecialAttr : int
	{
		None = 0,
		XmlSpace = 1,
		XmlLang = 2,
		XmlNs = 3,
	}

	[Token(Token = "0x200006B")]
	private enum State : int
	{
		Start = 0,
		Prolog = 1,
		PostDTD = 2,
		Element = 3,
		Attribute = 4,
		Content = 5,
		AttrOnly = 6,
		Epilog = 7,
		Error = 8,
		Closed = 9,
	}

	[Token(Token = "0x2000068")]
	private struct TagInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C1")]
		internal string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002C2")]
		internal string prefix; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40002C3")]
		internal string defaultNs; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002C4")]
		internal NamespaceState defaultNsState; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40002C5")]
		internal XmlSpace xmlSpace; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002C6")]
		internal string xmlLang; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40002C7")]
		internal int prevNsTop; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40002C8")]
		internal int prefixCount; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40002C9")]
		internal bool mixed; //Field offset: 0x30

		[Address(RVA = "0x24FDE90", Offset = "0x24FD290", Length = "0x6B")]
		[Token(Token = "0x600057E")]
		internal void Init(int nsTop) { }

	}

	[Token(Token = "0x200006C")]
	private enum Token : int
	{
		PI = 0,
		Doctype = 1,
		Comment = 2,
		CData = 3,
		StartElement = 4,
		EndElement = 5,
		LongEndElement = 6,
		StartAttribute = 7,
		EndAttribute = 8,
		Content = 9,
		Base64 = 10,
		RawData = 11,
		Whitespace = 12,
		Empty = 13,
	}

	[Token(Token = "0x40002B8")]
	private static String[] stateName; //Field offset: 0x0
	[Token(Token = "0x40002B9")]
	private static String[] tokenName; //Field offset: 0x8
	[Token(Token = "0x40002BA")]
	private static readonly State[] stateTableDefault; //Field offset: 0x10
	[Token(Token = "0x40002BB")]
	private static readonly State[] stateTableDocument; //Field offset: 0x18
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002A0")]
	private TextWriter textWriter; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002A1")]
	private XmlTextEncoder xmlEncoder; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002A2")]
	private Encoding encoding; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002A3")]
	private Formatting formatting; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40002A4")]
	private bool indented; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002A5")]
	private int indentation; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40002A6")]
	private char indentChar; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002A7")]
	private TagInfo[] stack; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002A8")]
	private int top; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002A9")]
	private State[] stateTable; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002AA")]
	private State currentState; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40002AB")]
	private Token lastToken; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002AC")]
	private XmlTextWriterBase64Encoder base64Encoder; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002AD")]
	private char quoteChar; //Field offset: 0x68
	[FieldOffset(Offset = "0x6A")]
	[Token(Token = "0x40002AE")]
	private char curQuoteChar; //Field offset: 0x6A
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40002AF")]
	private bool namespaces; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002B0")]
	private SpecialAttr specialAttr; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40002B1")]
	private string prefixForXmlNs; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40002B2")]
	private bool flush; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40002B3")]
	private Namespace[] nsStack; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40002B4")]
	private int nsTop; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40002B5")]
	private Dictionary<String, Int32> nsHashtable; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40002B6")]
	private bool useNsHashtable; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40002B7")]
	private XmlCharType xmlCharType; //Field offset: 0xA8

	[Token(Token = "0x17000131")]
	public Stream BaseStream
	{
		[Address(RVA = "0x25031A0", Offset = "0x25025A0", Length = "0x78")]
		[Token(Token = "0x600054A")]
		 get { } //Length: 120
	}

	[Token(Token = "0x17000133")]
	public Formatting Formatting
	{
		[Address(RVA = "0x2503290", Offset = "0x2502690", Length = "0xD")]
		[Token(Token = "0x600054C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000132")]
	public bool Namespaces
	{
		[Address(RVA = "0x25032A0", Offset = "0x25026A0", Length = "0x7B")]
		[Token(Token = "0x600054B")]
		 set { } //Length: 123
	}

	[Token(Token = "0x17000134")]
	public char QuoteChar
	{
		[Address(RVA = "0x2503320", Offset = "0x2502720", Length = "0x95")]
		[Token(Token = "0x600054D")]
		 set { } //Length: 149
	}

	[Token(Token = "0x17000135")]
	public virtual WriteState WriteState
	{
		[Address(RVA = "0x2503220", Offset = "0x2502620", Length = "0x44")]
		[Token(Token = "0x6000564")]
		 get { } //Length: 68
	}

	[Address(RVA = "0x2502750", Offset = "0x2501B50", Length = "0x587")]
	[Token(Token = "0x600057D")]
	private static XmlTextWriter() { }

	[Address(RVA = "0x2502E80", Offset = "0x2502280", Length = "0xC9")]
	[Token(Token = "0x6000549")]
	public XmlTextWriter(TextWriter w) { }

	[Address(RVA = "0x2502CE0", Offset = "0x25020E0", Length = "0x19C")]
	[Token(Token = "0x6000546")]
	internal XmlTextWriter() { }

	[Address(RVA = "0x25030A0", Offset = "0x25024A0", Length = "0xFD")]
	[Token(Token = "0x6000547")]
	public XmlTextWriter(Stream w, Encoding encoding) { }

	[Address(RVA = "0x2502F50", Offset = "0x2502350", Length = "0x14D")]
	[Token(Token = "0x6000548")]
	public XmlTextWriter(string filename, Encoding encoding) { }

	[Address(RVA = "0x24FE0C0", Offset = "0x24FD4C0", Length = "0x1CE")]
	[Token(Token = "0x6000570")]
	private void AddNamespace(string prefix, string ns, bool declared) { }

	[Address(RVA = "0x24FE290", Offset = "0x24FD690", Length = "0xE6")]
	[Token(Token = "0x6000571")]
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	[Address(RVA = "0x24FE3E0", Offset = "0x24FD7E0", Length = "0x5DC")]
	[Token(Token = "0x6000569")]
	private void AutoComplete(Token token) { }

	[Address(RVA = "0x24FE380", Offset = "0x24FD780", Length = "0x53")]
	[Token(Token = "0x600056A")]
	private void AutoCompleteAll() { }

	[Address(RVA = "0x24FE9F0", Offset = "0x24FDDF0", Length = "0xCE")]
	[Token(Token = "0x6000565")]
	public virtual void Close() { }

	[Address(RVA = "0x24FEAC0", Offset = "0x24FDEC0", Length = "0xE5")]
	[Token(Token = "0x6000577")]
	private string FindPrefix(string ns) { }

	[Address(RVA = "0x1FE3D30", Offset = "0x1FE3130", Length = "0x2A")]
	[Token(Token = "0x6000566")]
	public virtual void Flush() { }

	[Address(RVA = "0x24FEBB0", Offset = "0x24FDFB0", Length = "0x35")]
	[Token(Token = "0x600057C")]
	private void FlushEncoders() { }

	[Address(RVA = "0x24FEBF0", Offset = "0x24FDFF0", Length = "0xFE")]
	[Token(Token = "0x6000573")]
	private string GeneratePrefix() { }

	[Address(RVA = "0x25031A0", Offset = "0x25025A0", Length = "0x78")]
	[Token(Token = "0x600054A")]
	public Stream get_BaseStream() { }

	[Address(RVA = "0x2503220", Offset = "0x2502620", Length = "0x44")]
	[Token(Token = "0x6000564")]
	public virtual WriteState get_WriteState() { }

	[Address(RVA = "0x24FECF0", Offset = "0x24FE0F0", Length = "0x23B")]
	[Token(Token = "0x6000579")]
	private void HandleSpecialAttribute() { }

	[Address(RVA = "0x24FEF30", Offset = "0x24FE330", Length = "0xED")]
	[Token(Token = "0x600056E")]
	private void Indent(bool beforeEndElement) { }

	[Address(RVA = "0x24FF020", Offset = "0x24FE420", Length = "0x3F9")]
	[Token(Token = "0x600056B")]
	private void InternalWriteEndElement(bool longFormat) { }

	[Address(RVA = "0x24FF420", Offset = "0x24FE820", Length = "0x10D")]
	[Token(Token = "0x6000574")]
	private void InternalWriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x24FF670", Offset = "0x24FEA70", Length = "0xED")]
	[Token(Token = "0x6000575")]
	private int LookupNamespace(string prefix) { }

	[Address(RVA = "0x24FF530", Offset = "0x24FE930", Length = "0x136")]
	[Token(Token = "0x6000576")]
	private int LookupNamespaceInCurrentScope(string prefix) { }

	[Address(RVA = "0x24FF760", Offset = "0x24FEB60", Length = "0xE7")]
	[Token(Token = "0x6000567")]
	public virtual string LookupPrefix(string ns) { }

	[Address(RVA = "0x24FF850", Offset = "0x24FEC50", Length = "0xF1")]
	[Token(Token = "0x6000572")]
	private void PopNamespaces(int indexFrom, int indexTo) { }

	[Address(RVA = "0x24FF950", Offset = "0x24FED50", Length = "0x2E7")]
	[Token(Token = "0x600056F")]
	private void PushNamespace(string prefix, string ns, bool declared) { }

	[Address(RVA = "0x24FFC40", Offset = "0x24FF040", Length = "0x120")]
	[Token(Token = "0x600057B")]
	private void PushStack() { }

	[Address(RVA = "0x2503290", Offset = "0x2502690", Length = "0xD")]
	[Token(Token = "0x600054C")]
	public void set_Formatting(Formatting value) { }

	[Address(RVA = "0x25032A0", Offset = "0x25026A0", Length = "0x7B")]
	[Token(Token = "0x600054B")]
	public void set_Namespaces(bool value) { }

	[Address(RVA = "0x2503320", Offset = "0x2502720", Length = "0x95")]
	[Token(Token = "0x600054D")]
	public void set_QuoteChar(char value) { }

	[Address(RVA = "0x24FFD70", Offset = "0x24FF170", Length = "0x2E8")]
	[Token(Token = "0x6000568")]
	private void StartDocument(int standalone) { }

	[Address(RVA = "0x2500060", Offset = "0x24FF460", Length = "0x219")]
	[Token(Token = "0x6000578")]
	private void ValidateName(string name, bool isNCName) { }

	[Address(RVA = "0x2500280", Offset = "0x24FF680", Length = "0x133")]
	[Token(Token = "0x600057A")]
	private void VerifyPrefixXml(string prefix, string ns) { }

	[Address(RVA = "0x25003C0", Offset = "0x24FF7C0", Length = "0x106")]
	[Token(Token = "0x6000562")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x25004D0", Offset = "0x24FF8D0", Length = "0x89")]
	[Token(Token = "0x6000563")]
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x2500560", Offset = "0x24FF960", Length = "0x16C")]
	[Token(Token = "0x6000557")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x25006D0", Offset = "0x24FFAD0", Length = "0x6E")]
	[Token(Token = "0x600055B")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x2500740", Offset = "0x24FFB40", Length = "0x96")]
	[Token(Token = "0x600055F")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x25007E0", Offset = "0x24FFBE0", Length = "0x19C")]
	[Token(Token = "0x6000558")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x2500980", Offset = "0x24FFD80", Length = "0x3D4")]
	[Token(Token = "0x6000551")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x2500DC0", Offset = "0x25001C0", Length = "0x42")]
	[Token(Token = "0x6000556")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x2500D60", Offset = "0x2500160", Length = "0x51")]
	[Token(Token = "0x600056D")]
	private void WriteEndAttributeQuote() { }

	[Address(RVA = "0x2500E10", Offset = "0x2500210", Length = "0x198")]
	[Token(Token = "0x6000550")]
	public virtual void WriteEndDocument() { }

	[Address(RVA = "0x2500FB0", Offset = "0x25003B0", Length = "0xA")]
	[Token(Token = "0x6000553")]
	public virtual void WriteEndElement() { }

	[Address(RVA = "0x2500FC0", Offset = "0x25003C0", Length = "0x3E7")]
	[Token(Token = "0x600056C")]
	private void WriteEndStartTag(bool empty) { }

	[Address(RVA = "0x25013B0", Offset = "0x25007B0", Length = "0x7C")]
	[Token(Token = "0x600055A")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x2501430", Offset = "0x2500830", Length = "0xA")]
	[Token(Token = "0x6000554")]
	public virtual void WriteFullEndElement() { }

	[Address(RVA = "0x2501440", Offset = "0x2500840", Length = "0x1D2")]
	[Token(Token = "0x6000559")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x25016C0", Offset = "0x2500AC0", Length = "0x6E")]
	[Token(Token = "0x6000561")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x2501620", Offset = "0x2500A20", Length = "0x96")]
	[Token(Token = "0x6000560")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x2501730", Offset = "0x2500B30", Length = "0x802")]
	[Token(Token = "0x6000555")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2501F40", Offset = "0x2501340", Length = "0x1D")]
	[Token(Token = "0x600054F")]
	public virtual void WriteStartDocument(bool standalone) { }

	[Address(RVA = "0x2501F60", Offset = "0x2501360", Length = "0xD")]
	[Token(Token = "0x600054E")]
	public virtual void WriteStartDocument() { }

	[Address(RVA = "0x2501F70", Offset = "0x2501370", Length = "0x5C0")]
	[Token(Token = "0x6000552")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2502540", Offset = "0x2501940", Length = "0x7A")]
	[Token(Token = "0x600055D")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x25025C0", Offset = "0x25019C0", Length = "0x80")]
	[Token(Token = "0x600055E")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x2502650", Offset = "0x2501A50", Length = "0xF3")]
	[Token(Token = "0x600055C")]
	public virtual void WriteWhitespace(string ws) { }

}

