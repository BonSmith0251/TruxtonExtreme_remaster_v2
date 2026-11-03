namespace System.Xml;

[EditorBrowsable(EditorBrowsableState::Never (1))]
[Token(Token = "0x2000055")]
public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D5")]
	private XmlTextReaderImpl impl; //Field offset: 0x10

	[Token(Token = "0x170000C9")]
	public virtual int AttributeCount
	{
		[Address(RVA = "0x1FEF050", Offset = "0x1FEE450", Length = "0x2A")]
		[Token(Token = "0x60003C2")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000C3")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x2370070", Offset = "0x236F470", Length = "0x2A")]
		[Token(Token = "0x60003BC")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000CE")]
	public virtual bool CanReadValueChunk
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60003D5")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000CD")]
	public virtual bool CanResolveEntity
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60003D3")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000C2")]
	public virtual int Depth
	{
		[Address(RVA = "0x23700D0", Offset = "0x236F4D0", Length = "0x2A")]
		[Token(Token = "0x60003BB")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000D9")]
	internal virtual IDtdInfo DtdInfo
	{
		[Address(RVA = "0x24FD290", Offset = "0x24FC690", Length = "0x2A")]
		[Token(Token = "0x60003E6")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x170000D4")]
	public EntityHandling EntityHandling
	{
		[Address(RVA = "0x24FD330", Offset = "0x24FC730", Length = "0x1E")]
		[Token(Token = "0x60003E1")]
		 set { } //Length: 30
	}

	[Token(Token = "0x170000CA")]
	public virtual bool EOF
	{
		[Address(RVA = "0x2370100", Offset = "0x236F500", Length = "0x2A")]
		[Token(Token = "0x60003CD")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000D6")]
	internal XmlTextReaderImpl Impl
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60003E3")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000C5")]
	public virtual bool IsDefault
	{
		[Address(RVA = "0x1F29900", Offset = "0x1F28D00", Length = "0x2A")]
		[Token(Token = "0x60003BE")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000C4")]
	public virtual bool IsEmptyElement
	{
		[Address(RVA = "0x2370130", Offset = "0x236F530", Length = "0x2A")]
		[Token(Token = "0x60003BD")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000CF")]
	public override int LineNumber
	{
		[Address(RVA = "0x24FD2C0", Offset = "0x24FC6C0", Length = "0x1D")]
		[Token(Token = "0x60003D8")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170000D0")]
	public override int LinePosition
	{
		[Address(RVA = "0x24FD2E0", Offset = "0x24FC6E0", Length = "0x1D")]
		[Token(Token = "0x60003D9")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170000BE")]
	public virtual string LocalName
	{
		[Address(RVA = "0x1DFC7E0", Offset = "0x1DFBBE0", Length = "0x2A")]
		[Token(Token = "0x60003B7")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000BD")]
	public virtual string Name
	{
		[Address(RVA = "0x21A98A0", Offset = "0x21A8CA0", Length = "0x2A")]
		[Token(Token = "0x60003B6")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000D7")]
	internal virtual XmlNamespaceManager NamespaceManager
	{
		[Address(RVA = "0x24FD300", Offset = "0x24FC700", Length = "0x2A")]
		[Token(Token = "0x60003E4")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x170000D1")]
	public bool Namespaces
	{
		[Address(RVA = "0x24EA560", Offset = "0x24E9960", Length = "0x1E")]
		[Token(Token = "0x60003DD")]
		 get { } //Length: 30
	}

	[Token(Token = "0x170000BF")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
		[Token(Token = "0x60003B8")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000CC")]
	public virtual XmlNameTable NameTable
	{
		[Address(RVA = "0x21BB7E0", Offset = "0x21BABE0", Length = "0x2A")]
		[Token(Token = "0x60003D1")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000BC")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x2370160", Offset = "0x236F560", Length = "0x2A")]
		[Token(Token = "0x60003B5")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000D2")]
	public bool Normalization
	{
		[Address(RVA = "0x24EA580", Offset = "0x24E9980", Length = "0x1E")]
		[Token(Token = "0x60003DE")]
		 get { } //Length: 30
		[Address(RVA = "0x24FD350", Offset = "0x24FC750", Length = "0x1E")]
		[Token(Token = "0x60003DF")]
		 set { } //Length: 30
	}

	[Token(Token = "0x170000C0")]
	public virtual string Prefix
	{
		[Address(RVA = "0x1F29960", Offset = "0x1F28D60", Length = "0x2A")]
		[Token(Token = "0x60003B9")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000C6")]
	public virtual char QuoteChar
	{
		[Address(RVA = "0x1F29840", Offset = "0x1F28C40", Length = "0x2A")]
		[Token(Token = "0x60003BF")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000CB")]
	public virtual ReadState ReadState
	{
		[Address(RVA = "0x2370190", Offset = "0x236F590", Length = "0x2A")]
		[Token(Token = "0x60003CF")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000C1")]
	public virtual string Value
	{
		[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
		[Token(Token = "0x60003BA")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000D3")]
	public WhitespaceHandling WhitespaceHandling
	{
		[Address(RVA = "0x24FD370", Offset = "0x24FC770", Length = "0x1E")]
		[Token(Token = "0x60003E0")]
		 set { } //Length: 30
	}

	[Token(Token = "0x170000C8")]
	public virtual string XmlLang
	{
		[Address(RVA = "0x23701C0", Offset = "0x236F5C0", Length = "0x2A")]
		[Token(Token = "0x60003C1")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000D5")]
	public XmlResolver XmlResolver
	{
		[Address(RVA = "0x24FD390", Offset = "0x24FC790", Length = "0x1E")]
		[Token(Token = "0x60003E2")]
		 set { } //Length: 30
	}

	[Token(Token = "0x170000C7")]
	public virtual XmlSpace XmlSpace
	{
		[Address(RVA = "0x1F298D0", Offset = "0x1F28CD0", Length = "0x2A")]
		[Token(Token = "0x60003C0")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170000D8")]
	internal bool XmlValidatingReaderCompatibilityMode
	{
		[Address(RVA = "0x24FD3B0", Offset = "0x24FC7B0", Length = "0x44D")]
		[Token(Token = "0x60003E5")]
		internal set { } //Length: 1101
	}

	[Address(RVA = "0x24FCF50", Offset = "0x24FC350", Length = "0xBC")]
	[Token(Token = "0x60003B1")]
	public XmlTextReader(Stream input) { }

	[Address(RVA = "0x24FD1A0", Offset = "0x24FC5A0", Length = "0xE4")]
	[Token(Token = "0x60003B2")]
	public XmlTextReader(string url, Stream input, XmlNameTable nt) { }

	[Address(RVA = "0x24FD0E0", Offset = "0x24FC4E0", Length = "0xBC")]
	[Token(Token = "0x60003B3")]
	public XmlTextReader(TextReader input) { }

	[Address(RVA = "0x24FD010", Offset = "0x24FC410", Length = "0xCC")]
	[Token(Token = "0x60003B4")]
	public XmlTextReader(TextReader input, XmlNameTable nt) { }

	[Address(RVA = "0x21BB810", Offset = "0x21BAC10", Length = "0x2A")]
	[Token(Token = "0x60003CE")]
	public virtual void Close() { }

	[Address(RVA = "0x1FEF050", Offset = "0x1FEE450", Length = "0x2A")]
	[Token(Token = "0x60003C2")]
	public virtual int get_AttributeCount() { }

	[Address(RVA = "0x2370070", Offset = "0x236F470", Length = "0x2A")]
	[Token(Token = "0x60003BC")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60003D5")]
	public virtual bool get_CanReadValueChunk() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60003D3")]
	public virtual bool get_CanResolveEntity() { }

	[Address(RVA = "0x23700D0", Offset = "0x236F4D0", Length = "0x2A")]
	[Token(Token = "0x60003BB")]
	public virtual int get_Depth() { }

	[Address(RVA = "0x24FD290", Offset = "0x24FC690", Length = "0x2A")]
	[Token(Token = "0x60003E6")]
	internal virtual IDtdInfo get_DtdInfo() { }

	[Address(RVA = "0x2370100", Offset = "0x236F500", Length = "0x2A")]
	[Token(Token = "0x60003CD")]
	public virtual bool get_EOF() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60003E3")]
	internal XmlTextReaderImpl get_Impl() { }

	[Address(RVA = "0x1F29900", Offset = "0x1F28D00", Length = "0x2A")]
	[Token(Token = "0x60003BE")]
	public virtual bool get_IsDefault() { }

	[Address(RVA = "0x2370130", Offset = "0x236F530", Length = "0x2A")]
	[Token(Token = "0x60003BD")]
	public virtual bool get_IsEmptyElement() { }

	[Address(RVA = "0x24FD2C0", Offset = "0x24FC6C0", Length = "0x1D")]
	[Token(Token = "0x60003D8")]
	public override int get_LineNumber() { }

	[Address(RVA = "0x24FD2E0", Offset = "0x24FC6E0", Length = "0x1D")]
	[Token(Token = "0x60003D9")]
	public override int get_LinePosition() { }

	[Address(RVA = "0x1DFC7E0", Offset = "0x1DFBBE0", Length = "0x2A")]
	[Token(Token = "0x60003B7")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x21A98A0", Offset = "0x21A8CA0", Length = "0x2A")]
	[Token(Token = "0x60003B6")]
	public virtual string get_Name() { }

	[Address(RVA = "0x24FD300", Offset = "0x24FC700", Length = "0x2A")]
	[Token(Token = "0x60003E4")]
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	[Address(RVA = "0x24EA560", Offset = "0x24E9960", Length = "0x1E")]
	[Token(Token = "0x60003DD")]
	public bool get_Namespaces() { }

	[Address(RVA = "0x1F29870", Offset = "0x1F28C70", Length = "0x2A")]
	[Token(Token = "0x60003B8")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x21BB7E0", Offset = "0x21BABE0", Length = "0x2A")]
	[Token(Token = "0x60003D1")]
	public virtual XmlNameTable get_NameTable() { }

	[Address(RVA = "0x2370160", Offset = "0x236F560", Length = "0x2A")]
	[Token(Token = "0x60003B5")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x24EA580", Offset = "0x24E9980", Length = "0x1E")]
	[Token(Token = "0x60003DE")]
	public bool get_Normalization() { }

	[Address(RVA = "0x1F29960", Offset = "0x1F28D60", Length = "0x2A")]
	[Token(Token = "0x60003B9")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x1F29840", Offset = "0x1F28C40", Length = "0x2A")]
	[Token(Token = "0x60003BF")]
	public virtual char get_QuoteChar() { }

	[Address(RVA = "0x2370190", Offset = "0x236F590", Length = "0x2A")]
	[Token(Token = "0x60003CF")]
	public virtual ReadState get_ReadState() { }

	[Address(RVA = "0x1F29930", Offset = "0x1F28D30", Length = "0x2A")]
	[Token(Token = "0x60003BA")]
	public virtual string get_Value() { }

	[Address(RVA = "0x23701C0", Offset = "0x236F5C0", Length = "0x2A")]
	[Token(Token = "0x60003C1")]
	public virtual string get_XmlLang() { }

	[Address(RVA = "0x1F298D0", Offset = "0x1F28CD0", Length = "0x2A")]
	[Token(Token = "0x60003C0")]
	public virtual XmlSpace get_XmlSpace() { }

	[Address(RVA = "0x236FEE0", Offset = "0x236F2E0", Length = "0x2A")]
	[Token(Token = "0x60003C5")]
	public virtual string GetAttribute(int i) { }

	[Address(RVA = "0x236FEB0", Offset = "0x236F2B0", Length = "0x2A")]
	[Token(Token = "0x60003C4")]
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	[Address(RVA = "0x226EDE0", Offset = "0x226E1E0", Length = "0x2A")]
	[Token(Token = "0x60003C3")]
	public virtual string GetAttribute(string name) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60003D7")]
	public override bool HasLineInfo() { }

	[Address(RVA = "0x24FCEA0", Offset = "0x24FC2A0", Length = "0x38")]
	[Token(Token = "0x60003D2")]
	public virtual string LookupNamespace(string prefix) { }

	[Address(RVA = "0x236FF10", Offset = "0x236F310", Length = "0x2A")]
	[Token(Token = "0x60003C7")]
	public virtual void MoveToAttribute(int i) { }

	[Address(RVA = "0xA75530", Offset = "0xA74930", Length = "0x2A")]
	[Token(Token = "0x60003C6")]
	public virtual bool MoveToAttribute(string name) { }

	[Address(RVA = "0x1FC8EC0", Offset = "0x1FC82C0", Length = "0x2A")]
	[Token(Token = "0x60003CA")]
	public virtual bool MoveToElement() { }

	[Address(RVA = "0x236FF40", Offset = "0x236F340", Length = "0x2A")]
	[Token(Token = "0x60003C8")]
	public virtual bool MoveToFirstAttribute() { }

	[Address(RVA = "0x1E8F300", Offset = "0x1E8E700", Length = "0x2A")]
	[Token(Token = "0x60003C9")]
	public virtual bool MoveToNextAttribute() { }

	[Address(RVA = "0x236FFA0", Offset = "0x236F3A0", Length = "0x2A")]
	[Token(Token = "0x60003CC")]
	public virtual bool Read() { }

	[Address(RVA = "0x21BB7B0", Offset = "0x21BABB0", Length = "0x2A")]
	[Token(Token = "0x60003CB")]
	public virtual bool ReadAttributeValue() { }

	[Address(RVA = "0x24FCEE0", Offset = "0x24FC2E0", Length = "0x2D")]
	[Token(Token = "0x60003D6")]
	public virtual string ReadString() { }

	[Address(RVA = "0x236FFD0", Offset = "0x236F3D0", Length = "0x2A")]
	[Token(Token = "0x60003D4")]
	public virtual void ResolveEntity() { }

	[Address(RVA = "0x24FD330", Offset = "0x24FC730", Length = "0x1E")]
	[Token(Token = "0x60003E1")]
	public void set_EntityHandling(EntityHandling value) { }

	[Address(RVA = "0x24FD350", Offset = "0x24FC750", Length = "0x1E")]
	[Token(Token = "0x60003DF")]
	public void set_Normalization(bool value) { }

	[Address(RVA = "0x24FD370", Offset = "0x24FC770", Length = "0x1E")]
	[Token(Token = "0x60003E0")]
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	[Address(RVA = "0x24FD390", Offset = "0x24FC790", Length = "0x1E")]
	[Token(Token = "0x60003E2")]
	public void set_XmlResolver(XmlResolver value) { }

	[Address(RVA = "0x24FD3B0", Offset = "0x24FC7B0", Length = "0x44D")]
	[Token(Token = "0x60003E5")]
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	[Address(RVA = "0x1FC8A10", Offset = "0x1FC7E10", Length = "0x2A")]
	[Token(Token = "0x60003D0")]
	public virtual void Skip() { }

	[Address(RVA = "0x24FCF10", Offset = "0x24FC310", Length = "0x1E")]
	[Token(Token = "0x60003DA")]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[Address(RVA = "0x1FEF630", Offset = "0x1FEEA30", Length = "0x2A")]
	[Token(Token = "0x60003DB")]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[Address(RVA = "0x24FCF30", Offset = "0x24FC330", Length = "0x1E")]
	[Token(Token = "0x60003DC")]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

