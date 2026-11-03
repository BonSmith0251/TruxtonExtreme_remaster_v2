namespace System.Xml;

[Token(Token = "0x20000AA")]
public class XmlNodeReader : XmlReader, IXmlNamespaceResolver
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004A1")]
	private XmlNodeReaderNavigator readerNav; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004A2")]
	private XmlNodeType nodeType; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40004A3")]
	private int curDepth; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004A4")]
	private ReadState readState; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004A5")]
	private bool fEOF; //Field offset: 0x24
	[FieldOffset(Offset = "0x25")]
	[Token(Token = "0x40004A6")]
	private bool bResolveEntity; //Field offset: 0x25
	[FieldOffset(Offset = "0x26")]
	[Token(Token = "0x40004A7")]
	private bool bStartFromDocument; //Field offset: 0x26
	[FieldOffset(Offset = "0x27")]
	[Token(Token = "0x40004A8")]
	private bool bInReadBinary; //Field offset: 0x27
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004A9")]
	private ReadContentAsBinaryHelper readBinaryHelper; //Field offset: 0x28

	[Token(Token = "0x1700028F")]
	public virtual int AttributeCount
	{
		[Address(RVA = "0x253D9C0", Offset = "0x253CDC0", Length = "0x30")]
		[Token(Token = "0x6000973")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000288")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x253DA00", Offset = "0x253CE00", Length = "0x33")]
		[Token(Token = "0x600096C")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000289")]
	public virtual bool CanResolveEntity
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600096D")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000287")]
	public virtual int Depth
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x600096B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000294")]
	internal virtual IDtdInfo DtdInfo
	{
		[Address(RVA = "0x253DA40", Offset = "0x253CE40", Length = "0x24")]
		[Token(Token = "0x6000991")]
		internal get { } //Length: 36
	}

	[Token(Token = "0x17000290")]
	public virtual bool EOF
	{
		[Address(RVA = "0x253DA70", Offset = "0x253CE70", Length = "0xE")]
		[Token(Token = "0x6000983")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000292")]
	public virtual bool HasAttributes
	{
		[Address(RVA = "0x24FB520", Offset = "0x24FA920", Length = "0x21")]
		[Token(Token = "0x6000988")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700028B")]
	public virtual bool IsDefault
	{
		[Address(RVA = "0x253DA80", Offset = "0x253CE80", Length = "0xD6")]
		[Token(Token = "0x600096F")]
		 get { } //Length: 214
	}

	[Token(Token = "0x1700028A")]
	public virtual bool IsEmptyElement
	{
		[Address(RVA = "0x253DB60", Offset = "0x253CF60", Length = "0x2A")]
		[Token(Token = "0x600096E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000283")]
	public virtual string LocalName
	{
		[Address(RVA = "0x253DB90", Offset = "0x253CF90", Length = "0x5C")]
		[Token(Token = "0x6000967")]
		 get { } //Length: 92
	}

	[Token(Token = "0x17000282")]
	public virtual string Name
	{
		[Address(RVA = "0x253DC90", Offset = "0x253D090", Length = "0x39")]
		[Token(Token = "0x6000966")]
		 get { } //Length: 57
	}

	[Token(Token = "0x17000284")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x253DCD0", Offset = "0x253D0D0", Length = "0x4F")]
		[Token(Token = "0x6000968")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000293")]
	public virtual XmlNameTable NameTable
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000989")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000281")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x253DD20", Offset = "0x253D120", Length = "0xD")]
		[Token(Token = "0x6000965")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000285")]
	public virtual string Prefix
	{
		[Address(RVA = "0x253DD30", Offset = "0x253D130", Length = "0x4F")]
		[Token(Token = "0x6000969")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000291")]
	public virtual ReadState ReadState
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000985")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700028E")]
	public virtual IXmlSchemaInfo SchemaInfo
	{
		[Address(RVA = "0x253DD80", Offset = "0x253D180", Length = "0x40")]
		[Token(Token = "0x6000972")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000286")]
	public virtual string Value
	{
		[Address(RVA = "0x253DDD0", Offset = "0x253D1D0", Length = "0x39")]
		[Token(Token = "0x600096A")]
		 get { } //Length: 57
	}

	[Token(Token = "0x1700028D")]
	public virtual string XmlLang
	{
		[Address(RVA = "0x253DE10", Offset = "0x253D210", Length = "0x4F")]
		[Token(Token = "0x6000971")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700028C")]
	public virtual XmlSpace XmlSpace
	{
		[Address(RVA = "0x253DE60", Offset = "0x253D260", Length = "0x40")]
		[Token(Token = "0x6000970")]
		 get { } //Length: 64
	}

	[Address(RVA = "0x253D8C0", Offset = "0x253CCC0", Length = "0xF6")]
	[Token(Token = "0x6000963")]
	public XmlNodeReader(XmlNode node) { }

	[Address(RVA = "0x253C490", Offset = "0x253B890", Length = "0x8")]
	[Token(Token = "0x6000984")]
	public virtual void Close() { }

	[Address(RVA = "0x253C4A0", Offset = "0x253B8A0", Length = "0x21")]
	[Token(Token = "0x600098D")]
	private void FinishReadBinary() { }

	[Address(RVA = "0x253D9C0", Offset = "0x253CDC0", Length = "0x30")]
	[Token(Token = "0x6000973")]
	public virtual int get_AttributeCount() { }

	[Address(RVA = "0x253DA00", Offset = "0x253CE00", Length = "0x33")]
	[Token(Token = "0x600096C")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600096D")]
	public virtual bool get_CanResolveEntity() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x600096B")]
	public virtual int get_Depth() { }

	[Address(RVA = "0x253DA40", Offset = "0x253CE40", Length = "0x24")]
	[Token(Token = "0x6000991")]
	internal virtual IDtdInfo get_DtdInfo() { }

	[Address(RVA = "0x253DA70", Offset = "0x253CE70", Length = "0xE")]
	[Token(Token = "0x6000983")]
	public virtual bool get_EOF() { }

	[Address(RVA = "0x24FB520", Offset = "0x24FA920", Length = "0x21")]
	[Token(Token = "0x6000988")]
	public virtual bool get_HasAttributes() { }

	[Address(RVA = "0x253DA80", Offset = "0x253CE80", Length = "0xD6")]
	[Token(Token = "0x600096F")]
	public virtual bool get_IsDefault() { }

	[Address(RVA = "0x253DB60", Offset = "0x253CF60", Length = "0x2A")]
	[Token(Token = "0x600096E")]
	public virtual bool get_IsEmptyElement() { }

	[Address(RVA = "0x253DB90", Offset = "0x253CF90", Length = "0x5C")]
	[Token(Token = "0x6000967")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x253DC90", Offset = "0x253D090", Length = "0x39")]
	[Token(Token = "0x6000966")]
	public virtual string get_Name() { }

	[Address(RVA = "0x253DCD0", Offset = "0x253D0D0", Length = "0x4F")]
	[Token(Token = "0x6000968")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000989")]
	public virtual XmlNameTable get_NameTable() { }

	[Address(RVA = "0x253DD20", Offset = "0x253D120", Length = "0xD")]
	[Token(Token = "0x6000965")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x253DD30", Offset = "0x253D130", Length = "0x4F")]
	[Token(Token = "0x6000969")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000985")]
	public virtual ReadState get_ReadState() { }

	[Address(RVA = "0x253DD80", Offset = "0x253D180", Length = "0x40")]
	[Token(Token = "0x6000972")]
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	[Address(RVA = "0x253DDD0", Offset = "0x253D1D0", Length = "0x39")]
	[Token(Token = "0x600096A")]
	public virtual string get_Value() { }

	[Address(RVA = "0x253DE10", Offset = "0x253D210", Length = "0x4F")]
	[Token(Token = "0x6000971")]
	public virtual string get_XmlLang() { }

	[Address(RVA = "0x253DE60", Offset = "0x253D260", Length = "0x40")]
	[Token(Token = "0x6000970")]
	public virtual XmlSpace get_XmlSpace() { }

	[Address(RVA = "0x253C580", Offset = "0x253B980", Length = "0x41")]
	[Token(Token = "0x6000975")]
	public virtual string GetAttribute(string name, string namespaceURI) { }

	[Address(RVA = "0x253C550", Offset = "0x253B950", Length = "0x2B")]
	[Token(Token = "0x6000974")]
	public virtual string GetAttribute(string name) { }

	[Address(RVA = "0x253C4D0", Offset = "0x253B8D0", Length = "0x76")]
	[Token(Token = "0x6000976")]
	public virtual string GetAttribute(int attributeIndex) { }

	[Address(RVA = "0x253C5D0", Offset = "0x253B9D0", Length = "0x8")]
	[Token(Token = "0x6000964")]
	internal bool IsInReadingStates() { }

	[Address(RVA = "0x253C5E0", Offset = "0x253B9E0", Length = "0x37")]
	[Token(Token = "0x600098A")]
	public virtual string LookupNamespace(string prefix) { }

	[Address(RVA = "0x253C7E0", Offset = "0x253BBE0", Length = "0x10C")]
	[Token(Token = "0x6000977")]
	public virtual bool MoveToAttribute(string name) { }

	[Address(RVA = "0x253C620", Offset = "0x253BA20", Length = "0x1BB")]
	[Token(Token = "0x6000978")]
	public virtual void MoveToAttribute(int attributeIndex) { }

	[Address(RVA = "0x253C8F0", Offset = "0x253BCF0", Length = "0x1A7")]
	[Token(Token = "0x600097B")]
	public virtual bool MoveToElement() { }

	[Address(RVA = "0x253CAA0", Offset = "0x253BEA0", Length = "0x115")]
	[Token(Token = "0x6000979")]
	public virtual bool MoveToFirstAttribute() { }

	[Address(RVA = "0x253CBC0", Offset = "0x253BFC0", Length = "0x14B")]
	[Token(Token = "0x600097A")]
	public virtual bool MoveToNextAttribute() { }

	[Address(RVA = "0x253D400", Offset = "0x253C800", Length = "0x1CB")]
	[Token(Token = "0x600097D")]
	private bool Read(bool fSkipChildren) { }

	[Address(RVA = "0x253D3F0", Offset = "0x253C7F0", Length = "0xA")]
	[Token(Token = "0x600097C")]
	public virtual bool Read() { }

	[Address(RVA = "0x253CDE0", Offset = "0x253C1E0", Length = "0x4F")]
	[Token(Token = "0x600098C")]
	public virtual bool ReadAttributeValue() { }

	[Address(RVA = "0x253CD40", Offset = "0x253C140", Length = "0x93")]
	[Token(Token = "0x6000980")]
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	[Address(RVA = "0x253CE30", Offset = "0x253C230", Length = "0x215")]
	[Token(Token = "0x6000981")]
	private bool ReadForward(bool fSkipChildren) { }

	[Address(RVA = "0x253D050", Offset = "0x253C450", Length = "0x2ED")]
	[Token(Token = "0x600097E")]
	private bool ReadNextNode(bool fSkipChildren) { }

	[Address(RVA = "0x253D340", Offset = "0x253C740", Length = "0xAF")]
	[Token(Token = "0x6000987")]
	public virtual string ReadString() { }

	[Address(RVA = "0x253CD10", Offset = "0x253C110", Length = "0x29")]
	[Token(Token = "0x6000982")]
	private void ReSetReadingMarks() { }

	[Address(RVA = "0x253D5D0", Offset = "0x253C9D0", Length = "0x82")]
	[Token(Token = "0x600098B")]
	public virtual void ResolveEntity() { }

	[Address(RVA = "0x253D660", Offset = "0x253CA60", Length = "0x13")]
	[Token(Token = "0x600097F")]
	private void SetEndOfFile() { }

	[Address(RVA = "0x253D680", Offset = "0x253CA80", Length = "0xA")]
	[Token(Token = "0x6000986")]
	public virtual void Skip() { }

	[Address(RVA = "0x253D690", Offset = "0x253CA90", Length = "0x1E")]
	[Token(Token = "0x600098E")]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[Address(RVA = "0x253D6B0", Offset = "0x253CAB0", Length = "0x1E3")]
	[Token(Token = "0x6000990")]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[Address(RVA = "0x253D8A0", Offset = "0x253CCA0", Length = "0x1E")]
	[Token(Token = "0x600098F")]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

