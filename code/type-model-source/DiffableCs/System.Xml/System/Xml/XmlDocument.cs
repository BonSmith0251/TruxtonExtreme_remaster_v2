namespace System.Xml;

[Token(Token = "0x2000095")]
public class XmlDocument : XmlNode
{
	[Token(Token = "0x4000454")]
	internal static EmptyEnumerator EmptyEnumerator; //Field offset: 0x0
	[Token(Token = "0x4000455")]
	internal static IXmlSchemaInfo NotKnownSchemaInfo; //Field offset: 0x8
	[Token(Token = "0x4000456")]
	internal static IXmlSchemaInfo ValidSchemaInfo; //Field offset: 0x10
	[Token(Token = "0x4000457")]
	internal static IXmlSchemaInfo InvalidSchemaInfo; //Field offset: 0x18
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400042C")]
	private XmlImplementation implementation; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400042D")]
	private DomNameTable domNameTable; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400042E")]
	private XmlLinkedNode lastChild; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400042F")]
	private XmlNamedNodeMap entities; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000430")]
	private Hashtable htElementIdMap; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000431")]
	private Hashtable htElementIDAttrDecl; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000432")]
	private SchemaInfo schemaInfo; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000433")]
	private XmlSchemaSet schemas; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000434")]
	private bool reportValidity; //Field offset: 0x58
	[FieldOffset(Offset = "0x59")]
	[Token(Token = "0x4000435")]
	private bool actualLoadingStatus; //Field offset: 0x59
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000436")]
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000437")]
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000438")]
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000439")]
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400043A")]
	private XmlNodeChangedEventHandler onNodeChangingDelegate; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400043B")]
	private XmlNodeChangedEventHandler onNodeChangedDelegate; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400043C")]
	internal bool fEntRefNodesPresent; //Field offset: 0x90
	[FieldOffset(Offset = "0x91")]
	[Token(Token = "0x400043D")]
	internal bool fCDataNodesPresent; //Field offset: 0x91
	[FieldOffset(Offset = "0x92")]
	[Token(Token = "0x400043E")]
	private bool preserveWhitespace; //Field offset: 0x92
	[FieldOffset(Offset = "0x93")]
	[Token(Token = "0x400043F")]
	private bool isLoading; //Field offset: 0x93
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000440")]
	internal string strDocumentName; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000441")]
	internal string strDocumentFragmentName; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000442")]
	internal string strCommentName; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000443")]
	internal string strTextName; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000444")]
	internal string strCDataSectionName; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000445")]
	internal string strEntityName; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000446")]
	internal string strID; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000447")]
	internal string strXmlns; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000448")]
	internal string strXml; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000449")]
	internal string strSpace; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400044A")]
	internal string strLang; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400044B")]
	internal string strEmpty; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400044C")]
	internal string strNonSignificantWhitespaceName; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400044D")]
	internal string strSignificantWhitespaceName; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400044E")]
	internal string strReservedXmlns; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x400044F")]
	internal string strReservedXml; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000450")]
	internal string baseURI; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000451")]
	private XmlResolver resolver; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000452")]
	internal bool bSetResolver; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000453")]
	internal object objLock; //Field offset: 0x130

	[Token(Token = "0x170001F9")]
	internal bool ActualLoadingStatus
	{
		[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
		[Token(Token = "0x6000806")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000200")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
		[Token(Token = "0x600081A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001F2")]
	internal bool CanReportValidity
	{
		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[Token(Token = "0x60007DF")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001E9")]
	internal override XmlDeclaration Declaration
	{
		[Address(RVA = "0x2519B00", Offset = "0x2518F00", Length = "0xA9")]
		[Token(Token = "0x60007D5")]
		internal get { } //Length: 169
	}

	[Token(Token = "0x170001ED")]
	public XmlElement DocumentElement
	{
		[Address(RVA = "0x2519BB0", Offset = "0x2518FB0", Length = "0x82")]
		[Token(Token = "0x60007D9")]
		 get { } //Length: 130
	}

	[Token(Token = "0x170001E8")]
	public override XmlDocumentType DocumentType
	{
		[Address(RVA = "0x2519C40", Offset = "0x2519040", Length = "0x82")]
		[Token(Token = "0x60007D4")]
		 get { } //Length: 130
	}

	[Token(Token = "0x170001E5")]
	internal SchemaInfo DtdSchemaInfo
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60007C5")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x60007C6")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170001FD")]
	internal string Encoding
	{
		[Address(RVA = "0x2519CD0", Offset = "0x25190D0", Length = "0x2A")]
		[Token(Token = "0x6000816")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x170001F7")]
	internal XmlNamedNodeMap Entities
	{
		[Address(RVA = "0x2519D00", Offset = "0x2519100", Length = "0x6D")]
		[Token(Token = "0x6000802")]
		internal get { } //Length: 109
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x6000803")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170001F3")]
	internal bool HasSetResolver
	{
		[Address(RVA = "0x2202EB0", Offset = "0x22022B0", Length = "0x8")]
		[Token(Token = "0x60007E0")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170001EA")]
	public XmlImplementation Implementation
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60007D6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001FA")]
	public virtual string InnerText
	{
		[Address(RVA = "0x2519EF0", Offset = "0x25192F0", Length = "0x5F")]
		[Token(Token = "0x600080B")]
		 set { } //Length: 95
	}

	[Token(Token = "0x170001FB")]
	public virtual string InnerXml
	{
		[Address(RVA = "0x21082F0", Offset = "0x21076F0", Length = "0x14")]
		[Token(Token = "0x600080C")]
		 set { } //Length: 20
	}

	[Token(Token = "0x170001EE")]
	internal virtual bool IsContainer
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60007DA")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170001F8")]
	internal bool IsLoading
	{
		[Address(RVA = "0x22F0F80", Offset = "0x22F0380", Length = "0x8")]
		[Token(Token = "0x6000804")]
		internal get { } //Length: 8
		[Address(RVA = "0x250F2D0", Offset = "0x250E6D0", Length = "0x7")]
		[Token(Token = "0x6000805")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170001F6")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000801")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001EF")]
	internal virtual XmlLinkedNode LastNode
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60007DB")]
		internal get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60007DC")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170001EC")]
	public virtual string LocalName
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x60007D8")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001EB")]
	public virtual string Name
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x60007D7")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001F5")]
	public XmlNameTable NameTable
	{
		[Address(RVA = "0x21B18E0", Offset = "0x21B0CE0", Length = "0x1B")]
		[Token(Token = "0x60007FD")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170001E6")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x20270D0", Offset = "0x20264D0", Length = "0x6")]
		[Token(Token = "0x60007D2")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001F0")]
	public virtual XmlDocument OwnerDocument
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60007DD")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001E7")]
	public virtual XmlNode ParentNode
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60007D3")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001FF")]
	public virtual IXmlSchemaInfo SchemaInfo
	{
		[Address(RVA = "0x2519D70", Offset = "0x2519170", Length = "0x11E")]
		[Token(Token = "0x6000819")]
		 get { } //Length: 286
	}

	[Token(Token = "0x170001F1")]
	public XmlSchemaSet Schemas
	{
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60007DE")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170001FE")]
	internal string Standalone
	{
		[Address(RVA = "0x2519E90", Offset = "0x2519290", Length = "0x2A")]
		[Token(Token = "0x6000817")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x170001FC")]
	internal string Version
	{
		[Address(RVA = "0x2519EC0", Offset = "0x25192C0", Length = "0x2A")]
		[Token(Token = "0x6000815")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x170001F4")]
	public override XmlResolver XmlResolver
	{
		[Address(RVA = "0x2519F50", Offset = "0x2519350", Length = "0x14A")]
		[Token(Token = "0x60007E2")]
		 set { } //Length: 330
	}

	[Address(RVA = "0x25192E0", Offset = "0x25186E0", Length = "0x15D")]
	[Token(Token = "0x600081D")]
	private static XmlDocument() { }

	[Address(RVA = "0x2519570", Offset = "0x2518970", Length = "0x582")]
	[Token(Token = "0x60007C4")]
	protected private XmlDocument(XmlImplementation imp) { }

	[Address(RVA = "0x2519440", Offset = "0x2518840", Length = "0xA9")]
	[Token(Token = "0x60007C2")]
	public XmlDocument() { }

	[Address(RVA = "0x25194F0", Offset = "0x25188F0", Length = "0x77")]
	[Token(Token = "0x60007C3")]
	public XmlDocument(XmlNameTable nt) { }

	[Address(RVA = "0x25151C0", Offset = "0x25145C0", Length = "0x133")]
	[Token(Token = "0x60007CA")]
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x2515300", Offset = "0x2514700", Length = "0x322")]
	[Token(Token = "0x60007EF")]
	internal void AddDefaultAttributes(XmlElement elem) { }

	[Address(RVA = "0x2515630", Offset = "0x2514A30", Length = "0x20B")]
	[Token(Token = "0x60007CF")]
	internal void AddElementWithId(string id, XmlElement elem) { }

	[Address(RVA = "0x2515840", Offset = "0x2514C40", Length = "0xDF")]
	[Token(Token = "0x60007CB")]
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	[Address(RVA = "0x2515920", Offset = "0x2514D20", Length = "0x24")]
	[Token(Token = "0x60007C8")]
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x2515950", Offset = "0x2514D50", Length = "0x72")]
	[Token(Token = "0x6000813")]
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	[Address(RVA = "0x25159D0", Offset = "0x2514DD0", Length = "0x264")]
	[Token(Token = "0x600081C")]
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	[Address(RVA = "0x2515C40", Offset = "0x2515040", Length = "0x72")]
	[Token(Token = "0x6000812")]
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	[Address(RVA = "0x2515CC0", Offset = "0x25150C0", Length = "0xE4")]
	[Token(Token = "0x60007E7")]
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x2515E10", Offset = "0x2515210", Length = "0x1B6")]
	[Token(Token = "0x60007E6")]
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	[Address(RVA = "0x2515FD0", Offset = "0x25153D0", Length = "0xC1")]
	[Token(Token = "0x60007C7")]
	internal static void CheckName(string name) { }

	[Address(RVA = "0x25160A0", Offset = "0x25154A0", Length = "0xE2")]
	[Token(Token = "0x60007D1")]
	public virtual XmlNode CloneNode(bool deep) { }

	[Address(RVA = "0x2516350", Offset = "0x2515750", Length = "0x8D")]
	[Token(Token = "0x60007F8")]
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	[Address(RVA = "0x2516230", Offset = "0x2515630", Length = "0x114")]
	[Token(Token = "0x60007E8")]
	public XmlAttribute CreateAttribute(string name) { }

	[Address(RVA = "0x2516190", Offset = "0x2515590", Length = "0x94")]
	[Token(Token = "0x60007FE")]
	public override XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	[Address(RVA = "0x25163E0", Offset = "0x25157E0", Length = "0x8B")]
	[Token(Token = "0x60007EA")]
	public override XmlCDataSection CreateCDataSection(string data) { }

	[Address(RVA = "0x2516470", Offset = "0x2515870", Length = "0x84")]
	[Token(Token = "0x60007EB")]
	public override XmlComment CreateComment(string data) { }

	[Address(RVA = "0x2516500", Offset = "0x2515900", Length = "0x8E")]
	[Token(Token = "0x60007FF")]
	protected private override XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	[Address(RVA = "0x2516590", Offset = "0x2515990", Length = "0xBA")]
	[Token(Token = "0x60007ED")]
	public override XmlDocumentFragment CreateDocumentFragment() { }

	[Address(RVA = "0x2516650", Offset = "0x2515A50", Length = "0x187")]
	[Token(Token = "0x60007EC")]
	public override XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	[Address(RVA = "0x2516870", Offset = "0x2515C70", Length = "0x8F")]
	[Token(Token = "0x60007EE")]
	public XmlElement CreateElement(string name) { }

	[Address(RVA = "0x2516900", Offset = "0x2515D00", Length = "0xC5")]
	[Token(Token = "0x6000800")]
	public override XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	[Address(RVA = "0x25167E0", Offset = "0x2515BE0", Length = "0x8D")]
	[Token(Token = "0x60007F9")]
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	[Address(RVA = "0x25169D0", Offset = "0x2515DD0", Length = "0x64")]
	[Token(Token = "0x60007F2")]
	public override XmlEntityReference CreateEntityReference(string name) { }

	[Address(RVA = "0x2516A40", Offset = "0x2515E40", Length = "0x7A")]
	[Token(Token = "0x60007F3")]
	public override XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	[Address(RVA = "0x2516AC0", Offset = "0x2515EC0", Length = "0x64")]
	[Token(Token = "0x60007F6")]
	public override XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	[Address(RVA = "0x2516B30", Offset = "0x2515F30", Length = "0x64")]
	[Token(Token = "0x60007F5")]
	public override XmlText CreateTextNode(string text) { }

	[Address(RVA = "0x2516BA0", Offset = "0x2515FA0", Length = "0x64")]
	[Token(Token = "0x60007F7")]
	public override XmlWhitespace CreateWhitespace(string text) { }

	[Address(RVA = "0x2516C10", Offset = "0x2516010", Length = "0x8E")]
	[Token(Token = "0x60007F4")]
	public override XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[Address(RVA = "0x1CCAA30", Offset = "0x1CC9E30", Length = "0x5")]
	[Token(Token = "0x6000806")]
	internal bool get_ActualLoadingStatus() { }

	[Address(RVA = "0x1CF2EA0", Offset = "0x1CF22A0", Length = "0x8")]
	[Token(Token = "0x600081A")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
	[Token(Token = "0x60007DF")]
	internal bool get_CanReportValidity() { }

	[Address(RVA = "0x2519B00", Offset = "0x2518F00", Length = "0xA9")]
	[Token(Token = "0x60007D5")]
	internal override XmlDeclaration get_Declaration() { }

	[Address(RVA = "0x2519BB0", Offset = "0x2518FB0", Length = "0x82")]
	[Token(Token = "0x60007D9")]
	public XmlElement get_DocumentElement() { }

	[Address(RVA = "0x2519C40", Offset = "0x2519040", Length = "0x82")]
	[Token(Token = "0x60007D4")]
	public override XmlDocumentType get_DocumentType() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60007C5")]
	internal SchemaInfo get_DtdSchemaInfo() { }

	[Address(RVA = "0x2519CD0", Offset = "0x25190D0", Length = "0x2A")]
	[Token(Token = "0x6000816")]
	internal string get_Encoding() { }

	[Address(RVA = "0x2519D00", Offset = "0x2519100", Length = "0x6D")]
	[Token(Token = "0x6000802")]
	internal XmlNamedNodeMap get_Entities() { }

	[Address(RVA = "0x2202EB0", Offset = "0x22022B0", Length = "0x8")]
	[Token(Token = "0x60007E0")]
	internal bool get_HasSetResolver() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60007D6")]
	public XmlImplementation get_Implementation() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60007DA")]
	internal virtual bool get_IsContainer() { }

	[Address(RVA = "0x22F0F80", Offset = "0x22F0380", Length = "0x8")]
	[Token(Token = "0x6000804")]
	internal bool get_IsLoading() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000801")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60007DB")]
	internal virtual XmlLinkedNode get_LastNode() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x60007D8")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x60007D7")]
	public virtual string get_Name() { }

	[Address(RVA = "0x21B18E0", Offset = "0x21B0CE0", Length = "0x1B")]
	[Token(Token = "0x60007FD")]
	public XmlNameTable get_NameTable() { }

	[Address(RVA = "0x20270D0", Offset = "0x20264D0", Length = "0x6")]
	[Token(Token = "0x60007D2")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60007DD")]
	public virtual XmlDocument get_OwnerDocument() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60007D3")]
	public virtual XmlNode get_ParentNode() { }

	[Address(RVA = "0x2519D70", Offset = "0x2519170", Length = "0x11E")]
	[Token(Token = "0x6000819")]
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	[Address(RVA = "0x2519E90", Offset = "0x2519290", Length = "0x2A")]
	[Token(Token = "0x6000817")]
	internal string get_Standalone() { }

	[Address(RVA = "0x2519EC0", Offset = "0x25192C0", Length = "0x2A")]
	[Token(Token = "0x6000815")]
	internal string get_Version() { }

	[Address(RVA = "0x2516CA0", Offset = "0x25160A0", Length = "0x23D")]
	[Token(Token = "0x6000814")]
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	[Address(RVA = "0x2516EE0", Offset = "0x25162E0", Length = "0x464")]
	[Token(Token = "0x60007CE")]
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	[Address(RVA = "0x2517350", Offset = "0x2516750", Length = "0xDC")]
	[Token(Token = "0x6000818")]
	internal XmlEntity GetEntityNode(string name) { }

	[Address(RVA = "0x2517430", Offset = "0x2516830", Length = "0xF4")]
	[Token(Token = "0x6000810")]
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	[Address(RVA = "0x2517710", Offset = "0x2516B10", Length = "0x12")]
	[Token(Token = "0x60007CD")]
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	[Address(RVA = "0x2517530", Offset = "0x2516930", Length = "0x1D7")]
	[Token(Token = "0x60007CC")]
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	[Address(RVA = "0x2517730", Offset = "0x2516B30", Length = "0xC9")]
	[Token(Token = "0x6000811")]
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[Token(Token = "0x60007E1")]
	internal XmlResolver GetResolver() { }

	[Address(RVA = "0x2517800", Offset = "0x2516C00", Length = "0x11E")]
	[Token(Token = "0x60007F0")]
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	[Address(RVA = "0x2517920", Offset = "0x2516D20", Length = "0x147")]
	[Token(Token = "0x60007C9")]
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x2517A70", Offset = "0x2516E70", Length = "0x72")]
	[Token(Token = "0x60007E5")]
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	[Address(RVA = "0x2517AF0", Offset = "0x2516EF0", Length = "0xE7")]
	[Token(Token = "0x60007E4")]
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	[Address(RVA = "0x2517BE0", Offset = "0x2516FE0", Length = "0x164")]
	[Token(Token = "0x60007FB")]
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	[Address(RVA = "0x2517D50", Offset = "0x2517150", Length = "0xBE")]
	[Token(Token = "0x60007FC")]
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	[Address(RVA = "0x2517E10", Offset = "0x2517210", Length = "0x8C")]
	[Token(Token = "0x60007FA")]
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	[Address(RVA = "0x2518540", Offset = "0x2517940", Length = "0x38")]
	[Token(Token = "0x60007E3")]
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	[Address(RVA = "0x2518890", Offset = "0x2517C90", Length = "0x12D")]
	[Token(Token = "0x6000809")]
	public override void Load(XmlReader reader) { }

	[Address(RVA = "0x2518710", Offset = "0x2517B10", Length = "0x17B")]
	[Token(Token = "0x600080A")]
	public override void LoadXml(string xml) { }

	[Address(RVA = "0x25189C0", Offset = "0x2517DC0", Length = "0x150")]
	[Token(Token = "0x60007F1")]
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	[Address(RVA = "0x2518B20", Offset = "0x2517F20", Length = "0xCB")]
	[Token(Token = "0x6000807")]
	public override XmlNode ReadNode(XmlReader reader) { }

	[Address(RVA = "0x2518BF0", Offset = "0x2517FF0", Length = "0x155")]
	[Token(Token = "0x60007D0")]
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	[Address(RVA = "0x2518D50", Offset = "0x2518150", Length = "0x257")]
	[Token(Token = "0x600080D")]
	public override void Save(XmlWriter w) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x60007C6")]
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x6000803")]
	internal void set_Entities(XmlNamedNodeMap value) { }

	[Address(RVA = "0x2519EF0", Offset = "0x25192F0", Length = "0x5F")]
	[Token(Token = "0x600080B")]
	public virtual void set_InnerText(string value) { }

	[Address(RVA = "0x21082F0", Offset = "0x21076F0", Length = "0x14")]
	[Token(Token = "0x600080C")]
	public virtual void set_InnerXml(string value) { }

	[Address(RVA = "0x250F2D0", Offset = "0x250E6D0", Length = "0x7")]
	[Token(Token = "0x6000805")]
	internal void set_IsLoading(bool value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x60007DC")]
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60007DE")]
	public void set_Schemas(XmlSchemaSet value) { }

	[Address(RVA = "0x2519F50", Offset = "0x2519350", Length = "0x14A")]
	[Token(Token = "0x60007E2")]
	public override void set_XmlResolver(XmlResolver value) { }

	[Address(RVA = "0x2161F80", Offset = "0x2161380", Length = "0x13")]
	[Token(Token = "0x600081B")]
	internal void SetBaseURI(string inBaseURI) { }

	[Address(RVA = "0x2518FB0", Offset = "0x25183B0", Length = "0xA2")]
	[Token(Token = "0x60007E9")]
	internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	[Address(RVA = "0x2519060", Offset = "0x2518460", Length = "0x60")]
	[Token(Token = "0x6000808")]
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	[Address(RVA = "0x25190D0", Offset = "0x25184D0", Length = "0x20F")]
	[Token(Token = "0x600080F")]
	public virtual void WriteContentTo(XmlWriter xw) { }

	[Address(RVA = "0x2514CE0", Offset = "0x25140E0", Length = "0x14")]
	[Token(Token = "0x600080E")]
	public virtual void WriteTo(XmlWriter w) { }

}

