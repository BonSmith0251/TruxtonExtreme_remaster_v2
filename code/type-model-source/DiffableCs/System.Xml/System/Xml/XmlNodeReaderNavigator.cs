namespace System.Xml;

[Token(Token = "0x20000A8")]
internal class XmlNodeReaderNavigator
{
	[Token(Token = "0x20000A9")]
	public struct VirtualAttribute
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400049F")]
		internal string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004A0")]
		internal string value; //Field offset: 0x8

		[Address(RVA = "0x60E3C0", Offset = "0x60D7C0", Length = "0x32")]
		[Token(Token = "0x6000962")]
		internal VirtualAttribute(string name, string value) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400048E")]
	private XmlNode curNode; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400048F")]
	private XmlNode elemNode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000490")]
	private XmlNode logNode; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000491")]
	private int attrIndex; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000492")]
	private int logAttrIndex; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000493")]
	private XmlNameTable nameTable; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000494")]
	private XmlDocument doc; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000495")]
	private int nAttrInd; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000496")]
	private int nDeclarationAttrCount; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000497")]
	private int nDocTypeAttrCount; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000498")]
	private int nLogLevel; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000499")]
	private int nLogAttrInd; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x400049A")]
	private bool bLogOnAttrVal; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x400049B")]
	private bool bCreatedOnAttribute; //Field offset: 0x55
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400049C")]
	internal VirtualAttribute[] decNodeAttributes; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400049D")]
	internal VirtualAttribute[] docTypeNodeAttributes; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400049E")]
	private bool bOnAttrVal; //Field offset: 0x68

	[Token(Token = "0x1700027E")]
	public int AttributeCount
	{
		[Address(RVA = "0x253BC90", Offset = "0x253B090", Length = "0x145")]
		[Token(Token = "0x600093E")]
		 get { } //Length: 325
	}

	[Token(Token = "0x17000277")]
	public string BaseURI
	{
		[Address(RVA = "0x236FF70", Offset = "0x236F370", Length = "0x2A")]
		[Token(Token = "0x6000937")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000274")]
	internal bool CreatedOnAttribute
	{
		[Address(RVA = "0x1CF2BF0", Offset = "0x1CF1FF0", Length = "0x5")]
		[Token(Token = "0x6000933")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000280")]
	public XmlDocument Document
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000961")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700027B")]
	public bool IsDefault
	{
		[Address(RVA = "0x253BDE0", Offset = "0x253B1E0", Length = "0xAC")]
		[Token(Token = "0x600093B")]
		 get { } //Length: 172
	}

	[Token(Token = "0x1700027A")]
	public bool IsEmptyElement
	{
		[Address(RVA = "0x253BE90", Offset = "0x253B290", Length = "0x9F")]
		[Token(Token = "0x600093A")]
		 get { } //Length: 159
	}

	[Token(Token = "0x1700027F")]
	private bool IsOnDeclOrDocType
	{
		[Address(RVA = "0x253BF30", Offset = "0x253B330", Length = "0x3C")]
		[Token(Token = "0x600094F")]
		private get { } //Length: 60
	}

	[Token(Token = "0x17000273")]
	public string LocalName
	{
		[Address(RVA = "0x253BF70", Offset = "0x253B370", Length = "0x44")]
		[Token(Token = "0x6000932")]
		 get { } //Length: 68
	}

	[Token(Token = "0x17000272")]
	public string Name
	{
		[Address(RVA = "0x253C030", Offset = "0x253B430", Length = "0x4C")]
		[Token(Token = "0x6000931")]
		 get { } //Length: 76
	}

	[Token(Token = "0x17000271")]
	public string NamespaceURI
	{
		[Address(RVA = "0x21BB810", Offset = "0x21BAC10", Length = "0x2A")]
		[Token(Token = "0x6000930")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700027D")]
	public XmlNameTable NameTable
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600093D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000270")]
	public XmlNodeType NodeType
	{
		[Address(RVA = "0x253C150", Offset = "0x253B550", Length = "0x41")]
		[Token(Token = "0x600092F")]
		 get { } //Length: 65
	}

	[Token(Token = "0x17000275")]
	public string Prefix
	{
		[Address(RVA = "0x2370190", Offset = "0x236F590", Length = "0x2A")]
		[Token(Token = "0x6000935")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700027C")]
	public IXmlSchemaInfo SchemaInfo
	{
		[Address(RVA = "0x24898A0", Offset = "0x2488CA0", Length = "0x2A")]
		[Token(Token = "0x600093C")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000276")]
	public string Value
	{
		[Address(RVA = "0x253C1A0", Offset = "0x253B5A0", Length = "0x283")]
		[Token(Token = "0x6000936")]
		 get { } //Length: 643
	}

	[Token(Token = "0x17000279")]
	public string XmlLang
	{
		[Address(RVA = "0x253C430", Offset = "0x253B830", Length = "0x2A")]
		[Token(Token = "0x6000939")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000278")]
	public XmlSpace XmlSpace
	{
		[Address(RVA = "0x253C460", Offset = "0x253B860", Length = "0x2A")]
		[Token(Token = "0x6000938")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x253B900", Offset = "0x253AD00", Length = "0x386")]
	[Token(Token = "0x600092E")]
	public XmlNodeReaderNavigator(XmlNode node) { }

	[Address(RVA = "0x2538A70", Offset = "0x2537E70", Length = "0x65")]
	[Token(Token = "0x600093F")]
	private void CheckIndexCondition(int attributeIndex) { }

	[Address(RVA = "0x2538AE0", Offset = "0x2537EE0", Length = "0x158")]
	[Token(Token = "0x600095D")]
	internal string DefaultLookupNamespace(string prefix) { }

	[Address(RVA = "0x253BC90", Offset = "0x253B090", Length = "0x145")]
	[Token(Token = "0x600093E")]
	public int get_AttributeCount() { }

	[Address(RVA = "0x236FF70", Offset = "0x236F370", Length = "0x2A")]
	[Token(Token = "0x6000937")]
	public string get_BaseURI() { }

	[Address(RVA = "0x1CF2BF0", Offset = "0x1CF1FF0", Length = "0x5")]
	[Token(Token = "0x6000933")]
	internal bool get_CreatedOnAttribute() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000961")]
	public XmlDocument get_Document() { }

	[Address(RVA = "0x253BDE0", Offset = "0x253B1E0", Length = "0xAC")]
	[Token(Token = "0x600093B")]
	public bool get_IsDefault() { }

	[Address(RVA = "0x253BE90", Offset = "0x253B290", Length = "0x9F")]
	[Token(Token = "0x600093A")]
	public bool get_IsEmptyElement() { }

	[Address(RVA = "0x253BF30", Offset = "0x253B330", Length = "0x3C")]
	[Token(Token = "0x600094F")]
	private bool get_IsOnDeclOrDocType() { }

	[Address(RVA = "0x253BF70", Offset = "0x253B370", Length = "0x44")]
	[Token(Token = "0x6000932")]
	public string get_LocalName() { }

	[Address(RVA = "0x253C030", Offset = "0x253B430", Length = "0x4C")]
	[Token(Token = "0x6000931")]
	public string get_Name() { }

	[Address(RVA = "0x21BB810", Offset = "0x21BAC10", Length = "0x2A")]
	[Token(Token = "0x6000930")]
	public string get_NamespaceURI() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600093D")]
	public XmlNameTable get_NameTable() { }

	[Address(RVA = "0x253C150", Offset = "0x253B550", Length = "0x41")]
	[Token(Token = "0x600092F")]
	public XmlNodeType get_NodeType() { }

	[Address(RVA = "0x2370190", Offset = "0x236F590", Length = "0x2A")]
	[Token(Token = "0x6000935")]
	public string get_Prefix() { }

	[Address(RVA = "0x24898A0", Offset = "0x2488CA0", Length = "0x2A")]
	[Token(Token = "0x600093C")]
	public IXmlSchemaInfo get_SchemaInfo() { }

	[Address(RVA = "0x253C1A0", Offset = "0x253B5A0", Length = "0x283")]
	[Token(Token = "0x6000936")]
	public string get_Value() { }

	[Address(RVA = "0x253C430", Offset = "0x253B830", Length = "0x2A")]
	[Token(Token = "0x6000939")]
	public string get_XmlLang() { }

	[Address(RVA = "0x253C460", Offset = "0x253B860", Length = "0x2A")]
	[Token(Token = "0x6000938")]
	public XmlSpace get_XmlSpace() { }

	[Address(RVA = "0x25392F0", Offset = "0x25386F0", Length = "0x255")]
	[Token(Token = "0x600094C")]
	public string GetAttribute(int attributeIndex) { }

	[Address(RVA = "0x2538D00", Offset = "0x2538100", Length = "0x2D5")]
	[Token(Token = "0x6000949")]
	public string GetAttribute(string name) { }

	[Address(RVA = "0x2538FE0", Offset = "0x25383E0", Length = "0x301")]
	[Token(Token = "0x600094B")]
	public string GetAttribute(string name, string ns) { }

	[Address(RVA = "0x2538CA0", Offset = "0x25380A0", Length = "0x52")]
	[Token(Token = "0x6000948")]
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	[Address(RVA = "0x2538C40", Offset = "0x2538040", Length = "0x5C")]
	[Token(Token = "0x600094A")]
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	[Address(RVA = "0x2539550", Offset = "0x2538950", Length = "0x88")]
	[Token(Token = "0x6000943")]
	public int GetDecAttrInd(string name) { }

	[Address(RVA = "0x2539630", Offset = "0x2538A30", Length = "0xD4")]
	[Token(Token = "0x6000941")]
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	[Address(RVA = "0x25395E0", Offset = "0x25389E0", Length = "0x4C")]
	[Token(Token = "0x6000942")]
	public string GetDeclarationAttr(int i) { }

	[Address(RVA = "0x2539710", Offset = "0x2538B10", Length = "0x88")]
	[Token(Token = "0x6000947")]
	public int GetDocTypeAttrInd(string name) { }

	[Address(RVA = "0x25397F0", Offset = "0x2538BF0", Length = "0x9E")]
	[Token(Token = "0x6000945")]
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	[Address(RVA = "0x25397A0", Offset = "0x2538BA0", Length = "0x4C")]
	[Token(Token = "0x6000946")]
	public string GetDocumentTypeAttr(int i) { }

	[Address(RVA = "0x2539890", Offset = "0x2538C90", Length = "0x536")]
	[Token(Token = "0x600095F")]
	internal IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	[Address(RVA = "0x2539DD0", Offset = "0x25391D0", Length = "0x23B")]
	[Token(Token = "0x6000940")]
	private void InitDecAttr() { }

	[Address(RVA = "0x253A010", Offset = "0x2539410", Length = "0x178")]
	[Token(Token = "0x6000944")]
	private void InitDocTypeAttr() { }

	[Address(RVA = "0x253A190", Offset = "0x2539590", Length = "0x2C")]
	[Token(Token = "0x6000934")]
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	[Address(RVA = "0x253A1E0", Offset = "0x25395E0", Length = "0x41")]
	[Token(Token = "0x600094D")]
	public void LogMove(int level) { }

	[Address(RVA = "0x253A230", Offset = "0x2539630", Length = "0x30B")]
	[Token(Token = "0x600095C")]
	public string LookupNamespace(string prefix) { }

	[Address(RVA = "0x253A540", Offset = "0x2539940", Length = "0x42A")]
	[Token(Token = "0x600095E")]
	internal string LookupPrefix(string namespaceName) { }

	[Address(RVA = "0x253AE90", Offset = "0x253A290", Length = "0x19")]
	[Token(Token = "0x6000952")]
	public bool MoveToAttribute(string name) { }

	[Address(RVA = "0x253AC50", Offset = "0x253A050", Length = "0x23B")]
	[Token(Token = "0x6000954")]
	public bool MoveToAttribute(string name, string namespaceURI) { }

	[Address(RVA = "0x253AA60", Offset = "0x2539E60", Length = "0x1E4")]
	[Token(Token = "0x6000955")]
	public void MoveToAttribute(int attributeIndex) { }

	[Address(RVA = "0x253A970", Offset = "0x2539D70", Length = "0xEB")]
	[Token(Token = "0x6000953")]
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	[Address(RVA = "0x253AEB0", Offset = "0x253A2B0", Length = "0x83")]
	[Token(Token = "0x600095B")]
	public bool MoveToElement() { }

	[Address(RVA = "0x253AF40", Offset = "0x253A340", Length = "0x5A")]
	[Token(Token = "0x6000958")]
	public bool MoveToFirstChild() { }

	[Address(RVA = "0x253B200", Offset = "0x253A600", Length = "0x81")]
	[Token(Token = "0x600095A")]
	public bool MoveToNext() { }

	[Address(RVA = "0x253AFA0", Offset = "0x253A3A0", Length = "0x1FE")]
	[Token(Token = "0x6000956")]
	public bool MoveToNextAttribute(ref int level) { }

	[Address(RVA = "0x253B1A0", Offset = "0x253A5A0", Length = "0x5C")]
	[Token(Token = "0x6000959")]
	private bool MoveToNextSibling(XmlNode node) { }

	[Address(RVA = "0x253B290", Offset = "0x253A690", Length = "0x5A")]
	[Token(Token = "0x6000957")]
	public bool MoveToParent() { }

	[Address(RVA = "0x253B2F0", Offset = "0x253A6F0", Length = "0x23B")]
	[Token(Token = "0x6000960")]
	public bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt) { }

	[Address(RVA = "0x253B530", Offset = "0x253A930", Length = "0x293")]
	[Token(Token = "0x6000951")]
	public void ResetMove(ref int level, ref XmlNodeType nt) { }

	[Address(RVA = "0x253B7D0", Offset = "0x253ABD0", Length = "0xDB")]
	[Token(Token = "0x6000950")]
	public void ResetToAttribute(ref int level) { }

	[Address(RVA = "0x253B8B0", Offset = "0x253ACB0", Length = "0x44")]
	[Token(Token = "0x600094E")]
	public void RollBackMove(ref int level) { }

}

