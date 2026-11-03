namespace System.Xml;

[DefaultMember("Item")]
[Token(Token = "0x2000086")]
internal class XsdCachingReader : XmlReader, IXmlLineInfo
{
	[Token(Token = "0x2000087")]
	private enum CachingReaderState : int
	{
		None = 0,
		Init = 1,
		Record = 2,
		Replay = 3,
		ReaderClosed = 4,
		Error = 5,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003CE")]
	private XmlReader coreReader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003CF")]
	private XmlNameTable coreReaderNameTable; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003D0")]
	private ValidatingReaderNodeData[] contentEvents; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003D1")]
	private ValidatingReaderNodeData[] attributeEvents; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003D2")]
	private ValidatingReaderNodeData cachedNode; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003D3")]
	private CachingReaderState cacheState; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40003D4")]
	private int contentIndex; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003D5")]
	private int attributeCount; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40003D6")]
	private bool returnOriginalStringValues; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003D7")]
	private CachingEventHandler cacheHandler; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003D8")]
	private int currentAttrIndex; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40003D9")]
	private int currentContentIndex; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003DA")]
	private bool readAhead; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40003DB")]
	private IXmlLineInfo lineInfo; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40003DC")]
	private ValidatingReaderNodeData textNode; //Field offset: 0x68

	[Token(Token = "0x17000191")]
	public virtual int AttributeCount
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x60006DD")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700018B")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x2370070", Offset = "0x236F470", Length = "0x2A")]
		[Token(Token = "0x60006D7")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700018A")]
	public virtual int Depth
	{
		[Address(RVA = "0x25253C0", Offset = "0x25247C0", Length = "0x1A")]
		[Token(Token = "0x60006D6")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000192")]
	public virtual bool EOF
	{
		[Address(RVA = "0x25253E0", Offset = "0x25247E0", Length = "0x37")]
		[Token(Token = "0x60006EA")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700018D")]
	public virtual bool IsDefault
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60006D9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700018C")]
	public virtual bool IsEmptyElement
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60006D8")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000186")]
	public virtual string LocalName
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x60006D2")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000185")]
	public virtual string Name
	{
		[Address(RVA = "0x2525440", Offset = "0x2524840", Length = "0x25")]
		[Token(Token = "0x60006D1")]
		 get { } //Length: 37
	}

	[Token(Token = "0x17000187")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x2525470", Offset = "0x2524870", Length = "0x1B")]
		[Token(Token = "0x60006D3")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000194")]
	public virtual XmlNameTable NameTable
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60006EE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000184")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x2525490", Offset = "0x2524890", Length = "0x1A")]
		[Token(Token = "0x60006D0")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000188")]
	public virtual string Prefix
	{
		[Address(RVA = "0x25254B0", Offset = "0x25248B0", Length = "0x1B")]
		[Token(Token = "0x60006D4")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700018E")]
	public virtual char QuoteChar
	{
		[Address(RVA = "0x1F29840", Offset = "0x1F28C40", Length = "0x2A")]
		[Token(Token = "0x60006DA")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000193")]
	public virtual ReadState ReadState
	{
		[Address(RVA = "0x2370190", Offset = "0x236F590", Length = "0x2A")]
		[Token(Token = "0x60006EC")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000183")]
	public virtual XmlReaderSettings Settings
	{
		[Address(RVA = "0x2171280", Offset = "0x2170680", Length = "0x2A")]
		[Token(Token = "0x60006CF")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000195")]
	private override int System.Xml.IXmlLineInfo.LineNumber
	{
		[Address(RVA = "0x2525280", Offset = "0x2524680", Length = "0x1A")]
		[Token(Token = "0x60006F3")]
		private get { } //Length: 26
	}

	[Token(Token = "0x17000196")]
	private override int System.Xml.IXmlLineInfo.LinePosition
	{
		[Address(RVA = "0x25252A0", Offset = "0x25246A0", Length = "0x1A")]
		[Token(Token = "0x60006F4")]
		private get { } //Length: 26
	}

	[Token(Token = "0x17000189")]
	public virtual string Value
	{
		[Address(RVA = "0x25254D0", Offset = "0x25248D0", Length = "0x2A")]
		[Token(Token = "0x60006D5")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000190")]
	public virtual string XmlLang
	{
		[Address(RVA = "0x23701C0", Offset = "0x236F5C0", Length = "0x2A")]
		[Token(Token = "0x60006DC")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700018F")]
	public virtual XmlSpace XmlSpace
	{
		[Address(RVA = "0x1F298D0", Offset = "0x1F28CD0", Length = "0x2A")]
		[Token(Token = "0x60006DB")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x25252C0", Offset = "0x25246C0", Length = "0xF7")]
	[Token(Token = "0x60006CC")]
	internal XsdCachingReader(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	[Address(RVA = "0x2523B20", Offset = "0x2522F20", Length = "0x18B")]
	[Token(Token = "0x60006F9")]
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	[Address(RVA = "0x2523CB0", Offset = "0x25230B0", Length = "0x18D")]
	[Token(Token = "0x60006FA")]
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	[Address(RVA = "0x2523E40", Offset = "0x2523240", Length = "0xF")]
	[Token(Token = "0x60006F8")]
	private void ClearAttributesInfo() { }

	[Address(RVA = "0x2523E50", Offset = "0x2523250", Length = "0x37")]
	[Token(Token = "0x60006EB")]
	public virtual void Close() { }

	[Address(RVA = "0x2523E90", Offset = "0x2523290", Length = "0xB2")]
	[Token(Token = "0x60006FE")]
	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x60006DD")]
	public virtual int get_AttributeCount() { }

	[Address(RVA = "0x2370070", Offset = "0x236F470", Length = "0x2A")]
	[Token(Token = "0x60006D7")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x25253C0", Offset = "0x25247C0", Length = "0x1A")]
	[Token(Token = "0x60006D6")]
	public virtual int get_Depth() { }

	[Address(RVA = "0x25253E0", Offset = "0x25247E0", Length = "0x37")]
	[Token(Token = "0x60006EA")]
	public virtual bool get_EOF() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60006D9")]
	public virtual bool get_IsDefault() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60006D8")]
	public virtual bool get_IsEmptyElement() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x60006D2")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x2525440", Offset = "0x2524840", Length = "0x25")]
	[Token(Token = "0x60006D1")]
	public virtual string get_Name() { }

	[Address(RVA = "0x2525470", Offset = "0x2524870", Length = "0x1B")]
	[Token(Token = "0x60006D3")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60006EE")]
	public virtual XmlNameTable get_NameTable() { }

	[Address(RVA = "0x2525490", Offset = "0x2524890", Length = "0x1A")]
	[Token(Token = "0x60006D0")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x25254B0", Offset = "0x25248B0", Length = "0x1B")]
	[Token(Token = "0x60006D4")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x1F29840", Offset = "0x1F28C40", Length = "0x2A")]
	[Token(Token = "0x60006DA")]
	public virtual char get_QuoteChar() { }

	[Address(RVA = "0x2370190", Offset = "0x236F590", Length = "0x2A")]
	[Token(Token = "0x60006EC")]
	public virtual ReadState get_ReadState() { }

	[Address(RVA = "0x2171280", Offset = "0x2170680", Length = "0x2A")]
	[Token(Token = "0x60006CF")]
	public virtual XmlReaderSettings get_Settings() { }

	[Address(RVA = "0x25254D0", Offset = "0x25248D0", Length = "0x2A")]
	[Token(Token = "0x60006D5")]
	public virtual string get_Value() { }

	[Address(RVA = "0x23701C0", Offset = "0x236F5C0", Length = "0x2A")]
	[Token(Token = "0x60006DC")]
	public virtual string get_XmlLang() { }

	[Address(RVA = "0x1F298D0", Offset = "0x1F28CD0", Length = "0x2A")]
	[Token(Token = "0x60006DB")]
	public virtual XmlSpace get_XmlSpace() { }

	[Address(RVA = "0x25240E0", Offset = "0x25234E0", Length = "0x8E")]
	[Token(Token = "0x60006E0")]
	public virtual string GetAttribute(int i) { }

	[Address(RVA = "0x2524170", Offset = "0x2523570", Length = "0x106")]
	[Token(Token = "0x60006DF")]
	public virtual string GetAttribute(string name, string namespaceURI) { }

	[Address(RVA = "0x2524280", Offset = "0x2523680", Length = "0x84")]
	[Token(Token = "0x60006DE")]
	public virtual string GetAttribute(string name) { }

	[Address(RVA = "0x2524010", Offset = "0x2523410", Length = "0xC4")]
	[Token(Token = "0x60006FC")]
	private int GetAttributeIndexWithoutPrefix(string name) { }

	[Address(RVA = "0x2523F50", Offset = "0x2523350", Length = "0xB9")]
	[Token(Token = "0x60006FD")]
	private int GetAttributeIndexWithPrefix(string name) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60006F6")]
	internal XmlReader GetCoreReader() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60006F7")]
	internal IXmlLineInfo GetLineInfo() { }

	[Address(RVA = "0x2524310", Offset = "0x2523710", Length = "0x1AD")]
	[Token(Token = "0x60006CD")]
	private void Init() { }

	[Address(RVA = "0x1FEF630", Offset = "0x1FEEA30", Length = "0x2A")]
	[Token(Token = "0x60006EF")]
	public virtual string LookupNamespace(string prefix) { }

	[Address(RVA = "0x25244C0", Offset = "0x25238C0", Length = "0x95")]
	[Token(Token = "0x60006E2")]
	public virtual void MoveToAttribute(int i) { }

	[Address(RVA = "0x2524560", Offset = "0x2523960", Length = "0x8D")]
	[Token(Token = "0x60006E1")]
	public virtual bool MoveToAttribute(string name) { }

	[Address(RVA = "0x25245F0", Offset = "0x25239F0", Length = "0x4D")]
	[Token(Token = "0x60006E5")]
	public virtual bool MoveToElement() { }

	[Address(RVA = "0x2524640", Offset = "0x2523A40", Length = "0x4A")]
	[Token(Token = "0x60006E3")]
	public virtual bool MoveToFirstAttribute() { }

	[Address(RVA = "0x2524690", Offset = "0x2523A90", Length = "0x56")]
	[Token(Token = "0x60006E4")]
	public virtual bool MoveToNextAttribute() { }

	[Address(RVA = "0x25247E0", Offset = "0x2523BE0", Length = "0x17C")]
	[Token(Token = "0x60006E6")]
	public virtual bool Read() { }

	[Address(RVA = "0x25246F0", Offset = "0x2523AF0", Length = "0xED")]
	[Token(Token = "0x60006F1")]
	public virtual bool ReadAttributeValue() { }

	[Address(RVA = "0x2524B60", Offset = "0x2523F60", Length = "0x1D7")]
	[Token(Token = "0x60006FB")]
	private void RecordAttributes() { }

	[Address(RVA = "0x2524D40", Offset = "0x2524140", Length = "0x15C")]
	[Token(Token = "0x60006E9")]
	internal void RecordEndElementNode() { }

	[Address(RVA = "0x2524EA0", Offset = "0x25242A0", Length = "0x77")]
	[Token(Token = "0x60006E7")]
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	[Address(RVA = "0x2524F20", Offset = "0x2524320", Length = "0x25")]
	[Token(Token = "0x60006CE")]
	internal void Reset(XmlReader reader) { }

	[Address(RVA = "0x2524F50", Offset = "0x2524350", Length = "0x3E")]
	[Token(Token = "0x60006F0")]
	public virtual void ResolveEntity() { }

	[Address(RVA = "0x2524F90", Offset = "0x2524390", Length = "0x29")]
	[Token(Token = "0x60006F5")]
	internal void SetToReplayMode() { }

	[Address(RVA = "0x2524FC0", Offset = "0x25243C0", Length = "0x13D")]
	[Token(Token = "0x60006ED")]
	public virtual void Skip() { }

	[Address(RVA = "0x2525100", Offset = "0x2524500", Length = "0x172")]
	[Token(Token = "0x60006E8")]
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	[Address(RVA = "0x2525280", Offset = "0x2524680", Length = "0x1A")]
	[Token(Token = "0x60006F3")]
	private override int System.Xml.IXmlLineInfo.get_LineNumber() { }

	[Address(RVA = "0x25252A0", Offset = "0x25246A0", Length = "0x1A")]
	[Token(Token = "0x60006F4")]
	private override int System.Xml.IXmlLineInfo.get_LinePosition() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60006F2")]
	private override bool System.Xml.IXmlLineInfo.HasLineInfo() { }

}

