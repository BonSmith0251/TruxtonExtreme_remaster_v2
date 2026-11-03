namespace System.Xml;

[Token(Token = "0x200008A")]
internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver
{
	[Token(Token = "0x200008B")]
	private enum ValidatingReaderState : int
	{
		None = 0,
		Init = 1,
		Read = 2,
		OnDefaultAttribute = -1,
		OnReadAttributeValue = -2,
		OnAttribute = 3,
		ClearAttributes = 4,
		ParseInlineSchema = 5,
		ReadAhead = 6,
		OnReadBinaryContent = 7,
		ReaderClosed = 8,
		EOF = 9,
		Error = 10,
	}

	[Token(Token = "0x400040E")]
	private static Type TypeOfString; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003E8")]
	private XmlReader coreReader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003E9")]
	private IXmlNamespaceResolver coreReaderNSResolver; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003EA")]
	private IXmlNamespaceResolver thisNSResolver; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003EB")]
	private XmlSchemaValidator validator; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40003EC")]
	private XmlResolver xmlResolver; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40003ED")]
	private ValidationEventHandler validationEvent; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40003EE")]
	private ValidatingReaderState validationState; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40003EF")]
	private XmlValueGetter valueGetter; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40003F0")]
	private XmlNamespaceManager nsManager; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40003F1")]
	private bool manageNamespaces; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x40003F2")]
	private bool processInlineSchema; //Field offset: 0x59
	[FieldOffset(Offset = "0x5A")]
	[Token(Token = "0x40003F3")]
	private bool replayCache; //Field offset: 0x5A
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40003F4")]
	private ValidatingReaderNodeData cachedNode; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40003F5")]
	private AttributePSVIInfo attributePSVI; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40003F6")]
	private int attributeCount; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x40003F7")]
	private int coreReaderAttributeCount; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40003F8")]
	private int currentAttrIndex; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40003F9")]
	private AttributePSVIInfo[] attributePSVINodes; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40003FA")]
	private ArrayList defaultAttributes; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40003FB")]
	private Parser inlineSchemaParser; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40003FC")]
	private object atomicValue; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40003FD")]
	private XmlSchemaInfo xmlSchemaInfo; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40003FE")]
	private string originalAtomicValueString; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40003FF")]
	private XmlNameTable coreReaderNameTable; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000400")]
	private XsdCachingReader cachingReader; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000401")]
	private ValidatingReaderNodeData textNode; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000402")]
	private string NsXmlNs; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000403")]
	private string NsXs; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000404")]
	private string NsXsi; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000405")]
	private string XsiType; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000406")]
	private string XsiNil; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000407")]
	private string XsdSchema; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000408")]
	private string XsiSchemaLocation; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000409")]
	private string XsiNoNamespaceSchemaLocation; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400040A")]
	private XmlCharType xmlCharType; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400040B")]
	private IXmlLineInfo lineInfo; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x400040C")]
	private ReadContentAsBinaryHelper readBinaryHelper; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400040D")]
	private ValidatingReaderState savedState; //Field offset: 0x120

	[Token(Token = "0x170001A7")]
	public virtual int AttributeCount
	{
		[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
		[Token(Token = "0x6000717")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170001B4")]
	private XmlSchemaInfo AttributeSchemaInfo
	{
		[Address(RVA = "0x2529720", Offset = "0x2528B20", Length = "0x1B")]
		[Token(Token = "0x6000737")]
		private get { } //Length: 27
	}

	[Token(Token = "0x1700019F")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x2370070", Offset = "0x236F470", Length = "0x2A")]
		[Token(Token = "0x600070F")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700019E")]
	public virtual int Depth
	{
		[Address(RVA = "0x2529740", Offset = "0x2528B40", Length = "0x41")]
		[Token(Token = "0x600070E")]
		 get { } //Length: 65
	}

	[Token(Token = "0x170001A8")]
	public virtual bool EOF
	{
		[Address(RVA = "0x2370100", Offset = "0x236F500", Length = "0x2A")]
		[Token(Token = "0x6000721")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001A1")]
	public virtual bool IsDefault
	{
		[Address(RVA = "0x2529790", Offset = "0x2528B90", Length = "0x37")]
		[Token(Token = "0x6000711")]
		 get { } //Length: 55
	}

	[Token(Token = "0x170001A0")]
	public virtual bool IsEmptyElement
	{
		[Address(RVA = "0x2370130", Offset = "0x236F530", Length = "0x2A")]
		[Token(Token = "0x6000710")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001B2")]
	public override int LineNumber
	{
		[Address(RVA = "0x25297D0", Offset = "0x2528BD0", Length = "0x54")]
		[Token(Token = "0x6000731")]
		 get { } //Length: 84
	}

	[Token(Token = "0x170001B3")]
	public override int LinePosition
	{
		[Address(RVA = "0x2529830", Offset = "0x2528C30", Length = "0x54")]
		[Token(Token = "0x6000732")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700019A")]
	public virtual string LocalName
	{
		[Address(RVA = "0x2529890", Offset = "0x2528C90", Length = "0x42")]
		[Token(Token = "0x600070A")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000199")]
	public virtual string Name
	{
		[Address(RVA = "0x25298E0", Offset = "0x2528CE0", Length = "0x134")]
		[Token(Token = "0x6000709")]
		 get { } //Length: 308
	}

	[Token(Token = "0x1700019B")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x2529A20", Offset = "0x2528E20", Length = "0x42")]
		[Token(Token = "0x600070B")]
		 get { } //Length: 66
	}

	[Token(Token = "0x170001AA")]
	public virtual XmlNameTable NameTable
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[Token(Token = "0x6000725")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000198")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x2529A70", Offset = "0x2528E70", Length = "0x9E")]
		[Token(Token = "0x6000708")]
		 get { } //Length: 158
	}

	[Token(Token = "0x1700019C")]
	public virtual string Prefix
	{
		[Address(RVA = "0x2529B10", Offset = "0x2528F10", Length = "0x42")]
		[Token(Token = "0x600070C")]
		 get { } //Length: 66
	}

	[Token(Token = "0x170001A2")]
	public virtual char QuoteChar
	{
		[Address(RVA = "0x1F29840", Offset = "0x1F28C40", Length = "0x2A")]
		[Token(Token = "0x6000712")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001A9")]
	public virtual ReadState ReadState
	{
		[Address(RVA = "0x2529B60", Offset = "0x2528F60", Length = "0x37")]
		[Token(Token = "0x6000723")]
		 get { } //Length: 55
	}

	[Token(Token = "0x170001A5")]
	public virtual IXmlSchemaInfo SchemaInfo
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6000715")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000197")]
	public virtual XmlReaderSettings Settings
	{
		[Address(RVA = "0x2529BA0", Offset = "0x2528FA0", Length = "0xD5")]
		[Token(Token = "0x6000707")]
		 get { } //Length: 213
	}

	[Token(Token = "0x170001AB")]
	private override bool System.Xml.Schema.IXmlSchemaInfo.IsDefault
	{
		[Address(RVA = "0x2528E50", Offset = "0x2528250", Length = "0x89")]
		[Token(Token = "0x6000729")]
		private get { } //Length: 137
	}

	[Token(Token = "0x170001AC")]
	private override bool System.Xml.Schema.IXmlSchemaInfo.IsNil
	{
		[Address(RVA = "0x2528EE0", Offset = "0x25282E0", Length = "0x49")]
		[Token(Token = "0x600072A")]
		private get { } //Length: 73
	}

	[Token(Token = "0x170001AE")]
	private override XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType
	{
		[Address(RVA = "0x2528F30", Offset = "0x2528330", Length = "0x1B1")]
		[Token(Token = "0x600072C")]
		private get { } //Length: 433
	}

	[Token(Token = "0x170001B1")]
	private override XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute
	{
		[Address(RVA = "0x25290F0", Offset = "0x25284F0", Length = "0x4C")]
		[Token(Token = "0x600072F")]
		private get { } //Length: 76
	}

	[Token(Token = "0x170001B0")]
	private override XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement
	{
		[Address(RVA = "0x2529140", Offset = "0x2528540", Length = "0x5F")]
		[Token(Token = "0x600072E")]
		private get { } //Length: 95
	}

	[Token(Token = "0x170001AF")]
	private override XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType
	{
		[Address(RVA = "0x25291A0", Offset = "0x25285A0", Length = "0x5F")]
		[Token(Token = "0x600072D")]
		private get { } //Length: 95
	}

	[Token(Token = "0x170001AD")]
	private override XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity
	{
		[Address(RVA = "0x2529200", Offset = "0x2528600", Length = "0xA1")]
		[Token(Token = "0x600072B")]
		private get { } //Length: 161
	}

	[Token(Token = "0x1700019D")]
	public virtual string Value
	{
		[Address(RVA = "0x2529D60", Offset = "0x2529160", Length = "0x42")]
		[Token(Token = "0x600070D")]
		 get { } //Length: 66
	}

	[Token(Token = "0x170001A6")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x2529C80", Offset = "0x2529080", Length = "0xD0")]
		[Token(Token = "0x6000716")]
		 get { } //Length: 208
	}

	[Token(Token = "0x170001A4")]
	public virtual string XmlLang
	{
		[Address(RVA = "0x23701C0", Offset = "0x236F5C0", Length = "0x2A")]
		[Token(Token = "0x6000714")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001A3")]
	public virtual XmlSpace XmlSpace
	{
		[Address(RVA = "0x1F298D0", Offset = "0x1F28CD0", Length = "0x2A")]
		[Token(Token = "0x6000713")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x25294F0", Offset = "0x25288F0", Length = "0x209")]
	[Token(Token = "0x6000703")]
	internal XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	[Address(RVA = "0x2529700", Offset = "0x2528B00", Length = "0x1A")]
	[Token(Token = "0x6000704")]
	internal XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	[Address(RVA = "0x2525500", Offset = "0x2524900", Length = "0x239")]
	[Token(Token = "0x6000741")]
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	[Address(RVA = "0x2525740", Offset = "0x2524B40", Length = "0x51")]
	[Token(Token = "0x6000749")]
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	[Address(RVA = "0x25257A0", Offset = "0x2524BA0", Length = "0x54")]
	[Token(Token = "0x600073C")]
	private void ClearAttributesInfo() { }

	[Address(RVA = "0x2525800", Offset = "0x2524C00", Length = "0x37")]
	[Token(Token = "0x6000722")]
	public virtual void Close() { }

	[Address(RVA = "0x2525840", Offset = "0x2524C40", Length = "0xC4")]
	[Token(Token = "0x6000748")]
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	[Address(RVA = "0xAF07E0", Offset = "0xAEFBE0", Length = "0x4")]
	[Token(Token = "0x6000717")]
	public virtual int get_AttributeCount() { }

	[Address(RVA = "0x2529720", Offset = "0x2528B20", Length = "0x1B")]
	[Token(Token = "0x6000737")]
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	[Address(RVA = "0x2370070", Offset = "0x236F470", Length = "0x2A")]
	[Token(Token = "0x600070F")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x2529740", Offset = "0x2528B40", Length = "0x41")]
	[Token(Token = "0x600070E")]
	public virtual int get_Depth() { }

	[Address(RVA = "0x2370100", Offset = "0x236F500", Length = "0x2A")]
	[Token(Token = "0x6000721")]
	public virtual bool get_EOF() { }

	[Address(RVA = "0x2529790", Offset = "0x2528B90", Length = "0x37")]
	[Token(Token = "0x6000711")]
	public virtual bool get_IsDefault() { }

	[Address(RVA = "0x2370130", Offset = "0x236F530", Length = "0x2A")]
	[Token(Token = "0x6000710")]
	public virtual bool get_IsEmptyElement() { }

	[Address(RVA = "0x25297D0", Offset = "0x2528BD0", Length = "0x54")]
	[Token(Token = "0x6000731")]
	public override int get_LineNumber() { }

	[Address(RVA = "0x2529830", Offset = "0x2528C30", Length = "0x54")]
	[Token(Token = "0x6000732")]
	public override int get_LinePosition() { }

	[Address(RVA = "0x2529890", Offset = "0x2528C90", Length = "0x42")]
	[Token(Token = "0x600070A")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x25298E0", Offset = "0x2528CE0", Length = "0x134")]
	[Token(Token = "0x6000709")]
	public virtual string get_Name() { }

	[Address(RVA = "0x2529A20", Offset = "0x2528E20", Length = "0x42")]
	[Token(Token = "0x600070B")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[Token(Token = "0x6000725")]
	public virtual XmlNameTable get_NameTable() { }

	[Address(RVA = "0x2529A70", Offset = "0x2528E70", Length = "0x9E")]
	[Token(Token = "0x6000708")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2529B10", Offset = "0x2528F10", Length = "0x42")]
	[Token(Token = "0x600070C")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x1F29840", Offset = "0x1F28C40", Length = "0x2A")]
	[Token(Token = "0x6000712")]
	public virtual char get_QuoteChar() { }

	[Address(RVA = "0x2529B60", Offset = "0x2528F60", Length = "0x37")]
	[Token(Token = "0x6000723")]
	public virtual ReadState get_ReadState() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000715")]
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	[Address(RVA = "0x2529BA0", Offset = "0x2528FA0", Length = "0xD5")]
	[Token(Token = "0x6000707")]
	public virtual XmlReaderSettings get_Settings() { }

	[Address(RVA = "0x2529D60", Offset = "0x2529160", Length = "0x42")]
	[Token(Token = "0x600070D")]
	public virtual string get_Value() { }

	[Address(RVA = "0x2529C80", Offset = "0x2529080", Length = "0xD0")]
	[Token(Token = "0x6000716")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x23701C0", Offset = "0x236F5C0", Length = "0x2A")]
	[Token(Token = "0x6000714")]
	public virtual string get_XmlLang() { }

	[Address(RVA = "0x1F298D0", Offset = "0x1F28CD0", Length = "0x2A")]
	[Token(Token = "0x6000713")]
	public virtual XmlSpace get_XmlSpace() { }

	[Address(RVA = "0x2525BA0", Offset = "0x2524FA0", Length = "0xE9")]
	[Token(Token = "0x600071A")]
	public virtual string GetAttribute(int i) { }

	[Address(RVA = "0x2525D10", Offset = "0x2525110", Length = "0x106")]
	[Token(Token = "0x6000719")]
	public virtual string GetAttribute(string name, string namespaceURI) { }

	[Address(RVA = "0x2525C90", Offset = "0x2525090", Length = "0x70")]
	[Token(Token = "0x6000718")]
	public virtual string GetAttribute(string name) { }

	[Address(RVA = "0x2525910", Offset = "0x2524D10", Length = "0xA9")]
	[Token(Token = "0x600073E")]
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	[Address(RVA = "0x25259C0", Offset = "0x2524DC0", Length = "0x1D4")]
	[Token(Token = "0x600073D")]
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	[Address(RVA = "0x2525E20", Offset = "0x2525220", Length = "0x2A7")]
	[Token(Token = "0x6000747")]
	private XsdCachingReader GetCachingReader() { }

	[Address(RVA = "0x2526240", Offset = "0x2525640", Length = "0x14A")]
	[Token(Token = "0x600073F")]
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	[Address(RVA = "0x25260D0", Offset = "0x25254D0", Length = "0x164")]
	[Token(Token = "0x6000740")]
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	[Address(RVA = "0x2526390", Offset = "0x2525790", Length = "0x304")]
	[Token(Token = "0x6000745")]
	private void GetIsDefault() { }

	[Address(RVA = "0x25266D0", Offset = "0x2525AD0", Length = "0x110")]
	[Token(Token = "0x6000746")]
	private void GetMemberType() { }

	[Address(RVA = "0x25267F0", Offset = "0x2525BF0", Length = "0x75")]
	[Token(Token = "0x600074A")]
	private string GetOriginalAtomicValueStringOfElement() { }

	[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
	[Token(Token = "0x6000736")]
	private object GetStringValue() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000730")]
	public override bool HasLineInfo() { }

	[Address(RVA = "0x2526870", Offset = "0x2525C70", Length = "0x3ED")]
	[Token(Token = "0x6000705")]
	private void Init() { }

	[Address(RVA = "0x2526C60", Offset = "0x2526060", Length = "0x50")]
	[Token(Token = "0x6000742")]
	private bool IsXSDRoot(string localName, string ns) { }

	[Address(RVA = "0x2526CB0", Offset = "0x25260B0", Length = "0x58")]
	[Token(Token = "0x6000726")]
	public virtual string LookupNamespace(string prefix) { }

	[Address(RVA = "0x2526D10", Offset = "0x2526110", Length = "0xE4")]
	[Token(Token = "0x600071B")]
	public virtual bool MoveToAttribute(string name) { }

	[Address(RVA = "0x2526E00", Offset = "0x2526200", Length = "0x228")]
	[Token(Token = "0x600071C")]
	public virtual void MoveToAttribute(int i) { }

	[Address(RVA = "0x2527030", Offset = "0x2526430", Length = "0x50")]
	[Token(Token = "0x600071F")]
	public virtual bool MoveToElement() { }

	[Address(RVA = "0x2527090", Offset = "0x2526490", Length = "0x1E6")]
	[Token(Token = "0x600071D")]
	public virtual bool MoveToFirstAttribute() { }

	[Address(RVA = "0x2527280", Offset = "0x2526680", Length = "0x1ED")]
	[Token(Token = "0x600071E")]
	public virtual bool MoveToNextAttribute() { }

	[Address(RVA = "0x2527470", Offset = "0x2526870", Length = "0x650")]
	[Token(Token = "0x6000739")]
	private void ProcessElementEvent() { }

	[Address(RVA = "0x2527AD0", Offset = "0x2526ED0", Length = "0x325")]
	[Token(Token = "0x600073A")]
	private void ProcessEndElementEvent() { }

	[Address(RVA = "0x2527E00", Offset = "0x2527200", Length = "0x125")]
	[Token(Token = "0x6000743")]
	private void ProcessInlineSchema() { }

	[Address(RVA = "0x2527F30", Offset = "0x2527330", Length = "0x74")]
	[Token(Token = "0x6000738")]
	private void ProcessReaderEvent() { }

	[Address(RVA = "0x2528540", Offset = "0x2527940", Length = "0x28")]
	[Token(Token = "0x6000720")]
	public virtual bool Read() { }

	[Address(RVA = "0x2528140", Offset = "0x2527540", Length = "0x240")]
	[Token(Token = "0x6000744")]
	private void ReadAheadForMemberType() { }

	[Address(RVA = "0x25283C0", Offset = "0x25277C0", Length = "0x173")]
	[Token(Token = "0x6000728")]
	public virtual bool ReadAttributeValue() { }

	[Address(RVA = "0x2528820", Offset = "0x2527C20", Length = "0x3E")]
	[Token(Token = "0x6000727")]
	public virtual void ResolveEntity() { }

	[Address(RVA = "0x2528860", Offset = "0x2527C60", Length = "0x24D")]
	[Token(Token = "0x6000706")]
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	[Address(RVA = "0x2528AB0", Offset = "0x2527EB0", Length = "0x181")]
	[Token(Token = "0x6000724")]
	public virtual void Skip() { }

	[Address(RVA = "0x2528C40", Offset = "0x2528040", Length = "0xEA")]
	[Token(Token = "0x6000733")]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[Address(RVA = "0x2528D30", Offset = "0x2528130", Length = "0x89")]
	[Token(Token = "0x6000734")]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[Address(RVA = "0x2528DC0", Offset = "0x25281C0", Length = "0x89")]
	[Token(Token = "0x6000735")]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	[Address(RVA = "0x2528E50", Offset = "0x2528250", Length = "0x89")]
	[Token(Token = "0x6000729")]
	private override bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	[Address(RVA = "0x2528EE0", Offset = "0x25282E0", Length = "0x49")]
	[Token(Token = "0x600072A")]
	private override bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	[Address(RVA = "0x2528F30", Offset = "0x2528330", Length = "0x1B1")]
	[Token(Token = "0x600072C")]
	private override XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	[Address(RVA = "0x25290F0", Offset = "0x25284F0", Length = "0x4C")]
	[Token(Token = "0x600072F")]
	private override XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	[Address(RVA = "0x2529140", Offset = "0x2528540", Length = "0x5F")]
	[Token(Token = "0x600072E")]
	private override XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	[Address(RVA = "0x25291A0", Offset = "0x25285A0", Length = "0x5F")]
	[Token(Token = "0x600072D")]
	private override XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	[Address(RVA = "0x2529200", Offset = "0x2528600", Length = "0xA1")]
	[Token(Token = "0x600072B")]
	private override XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	[Address(RVA = "0x25292B0", Offset = "0x25286B0", Length = "0x23B")]
	[Token(Token = "0x600073B")]
	private void ValidateAttributes() { }

}

