namespace System.Xml;

[DefaultMember("Item")]
[Token(Token = "0x2000043")]
internal class XmlAsyncCheckReader : XmlReader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400014D")]
	private readonly XmlReader coreReader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400014E")]
	private Task lastTask; //Field offset: 0x18

	[Token(Token = "0x17000064")]
	public virtual int AttributeCount
	{
		[Address(RVA = "0x24EEBC0", Offset = "0x24EDFC0", Length = "0x37")]
		[Token(Token = "0x6000206")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700005C")]
	public virtual string BaseURI
	{
		[Address(RVA = "0x24EEC00", Offset = "0x24EE000", Length = "0x37")]
		[Token(Token = "0x60001FE")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000069")]
	public virtual bool CanReadValueChunk
	{
		[Address(RVA = "0x24EEC40", Offset = "0x24EE040", Length = "0x37")]
		[Token(Token = "0x6000219")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000068")]
	public virtual bool CanResolveEntity
	{
		[Address(RVA = "0x24EEC80", Offset = "0x24EE080", Length = "0x37")]
		[Token(Token = "0x6000217")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000053")]
	internal XmlReader CoreReader
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60001F2")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700005B")]
	public virtual int Depth
	{
		[Address(RVA = "0x24EECC0", Offset = "0x24EE0C0", Length = "0x37")]
		[Token(Token = "0x60001FD")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700006C")]
	internal virtual IDtdInfo DtdInfo
	{
		[Address(RVA = "0x24EED00", Offset = "0x24EE100", Length = "0x37")]
		[Token(Token = "0x6000225")]
		internal get { } //Length: 55
	}

	[Token(Token = "0x17000065")]
	public virtual bool EOF
	{
		[Address(RVA = "0x24EED40", Offset = "0x24EE140", Length = "0x37")]
		[Token(Token = "0x6000211")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700006A")]
	public virtual bool HasAttributes
	{
		[Address(RVA = "0x24EED80", Offset = "0x24EE180", Length = "0x37")]
		[Token(Token = "0x6000222")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700005E")]
	public virtual bool IsDefault
	{
		[Address(RVA = "0x24EEDC0", Offset = "0x24EE1C0", Length = "0x37")]
		[Token(Token = "0x6000200")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700005D")]
	public virtual bool IsEmptyElement
	{
		[Address(RVA = "0x24EEE00", Offset = "0x24EE200", Length = "0x37")]
		[Token(Token = "0x60001FF")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000057")]
	public virtual string LocalName
	{
		[Address(RVA = "0x24EEE40", Offset = "0x24EE240", Length = "0x37")]
		[Token(Token = "0x60001F9")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000056")]
	public virtual string Name
	{
		[Address(RVA = "0x24EEEC0", Offset = "0x24EE2C0", Length = "0x37")]
		[Token(Token = "0x60001F8")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700006B")]
	internal virtual XmlNamespaceManager NamespaceManager
	{
		[Address(RVA = "0x24EEF00", Offset = "0x24EE300", Length = "0x37")]
		[Token(Token = "0x6000224")]
		internal get { } //Length: 55
	}

	[Token(Token = "0x17000058")]
	public virtual string NamespaceURI
	{
		[Address(RVA = "0x24EEF40", Offset = "0x24EE340", Length = "0x37")]
		[Token(Token = "0x60001FA")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000067")]
	public virtual XmlNameTable NameTable
	{
		[Address(RVA = "0x24EEE80", Offset = "0x24EE280", Length = "0x37")]
		[Token(Token = "0x6000215")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000055")]
	public virtual XmlNodeType NodeType
	{
		[Address(RVA = "0x24EEF80", Offset = "0x24EE380", Length = "0x37")]
		[Token(Token = "0x60001F7")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000059")]
	public virtual string Prefix
	{
		[Address(RVA = "0x24EEFC0", Offset = "0x24EE3C0", Length = "0x37")]
		[Token(Token = "0x60001FB")]
		 get { } //Length: 55
	}

	[Token(Token = "0x1700005F")]
	public virtual char QuoteChar
	{
		[Address(RVA = "0x24EF000", Offset = "0x24EE400", Length = "0x37")]
		[Token(Token = "0x6000201")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000066")]
	public virtual ReadState ReadState
	{
		[Address(RVA = "0x24EF040", Offset = "0x24EE440", Length = "0x37")]
		[Token(Token = "0x6000213")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000062")]
	public virtual IXmlSchemaInfo SchemaInfo
	{
		[Address(RVA = "0x24EF080", Offset = "0x24EE480", Length = "0x37")]
		[Token(Token = "0x6000204")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000054")]
	public virtual XmlReaderSettings Settings
	{
		[Address(RVA = "0x24EF0C0", Offset = "0x24EE4C0", Length = "0xF9")]
		[Token(Token = "0x60001F6")]
		 get { } //Length: 249
	}

	[Token(Token = "0x1700005A")]
	public virtual string Value
	{
		[Address(RVA = "0x24EF200", Offset = "0x24EE600", Length = "0x37")]
		[Token(Token = "0x60001FC")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000063")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x24EF1C0", Offset = "0x24EE5C0", Length = "0x37")]
		[Token(Token = "0x6000205")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000061")]
	public virtual string XmlLang
	{
		[Address(RVA = "0x24EF240", Offset = "0x24EE640", Length = "0x37")]
		[Token(Token = "0x6000203")]
		 get { } //Length: 55
	}

	[Token(Token = "0x17000060")]
	public virtual XmlSpace XmlSpace
	{
		[Address(RVA = "0x24EF280", Offset = "0x24EE680", Length = "0x37")]
		[Token(Token = "0x6000202")]
		 get { } //Length: 55
	}

	[Address(RVA = "0x24EEB10", Offset = "0x24EDF10", Length = "0xA7")]
	[Token(Token = "0x60001F4")]
	public XmlAsyncCheckReader(XmlReader reader) { }

	[Address(RVA = "0x24EE150", Offset = "0x24ED550", Length = "0x8B")]
	[Token(Token = "0x60001F5")]
	private void CheckAsync() { }

	[Address(RVA = "0x24EE1E0", Offset = "0x24ED5E0", Length = "0x37")]
	[Token(Token = "0x6000212")]
	public virtual void Close() { }

	[Address(RVA = "0x24EE220", Offset = "0x24ED620", Length = "0x2AD")]
	[Token(Token = "0x60001F3")]
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	[Address(RVA = "0x24EE4D0", Offset = "0x24ED8D0", Length = "0x39")]
	[Token(Token = "0x6000223")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x24EEBC0", Offset = "0x24EDFC0", Length = "0x37")]
	[Token(Token = "0x6000206")]
	public virtual int get_AttributeCount() { }

	[Address(RVA = "0x24EEC00", Offset = "0x24EE000", Length = "0x37")]
	[Token(Token = "0x60001FE")]
	public virtual string get_BaseURI() { }

	[Address(RVA = "0x24EEC40", Offset = "0x24EE040", Length = "0x37")]
	[Token(Token = "0x6000219")]
	public virtual bool get_CanReadValueChunk() { }

	[Address(RVA = "0x24EEC80", Offset = "0x24EE080", Length = "0x37")]
	[Token(Token = "0x6000217")]
	public virtual bool get_CanResolveEntity() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60001F2")]
	internal XmlReader get_CoreReader() { }

	[Address(RVA = "0x24EECC0", Offset = "0x24EE0C0", Length = "0x37")]
	[Token(Token = "0x60001FD")]
	public virtual int get_Depth() { }

	[Address(RVA = "0x24EED00", Offset = "0x24EE100", Length = "0x37")]
	[Token(Token = "0x6000225")]
	internal virtual IDtdInfo get_DtdInfo() { }

	[Address(RVA = "0x24EED40", Offset = "0x24EE140", Length = "0x37")]
	[Token(Token = "0x6000211")]
	public virtual bool get_EOF() { }

	[Address(RVA = "0x24EED80", Offset = "0x24EE180", Length = "0x37")]
	[Token(Token = "0x6000222")]
	public virtual bool get_HasAttributes() { }

	[Address(RVA = "0x24EEDC0", Offset = "0x24EE1C0", Length = "0x37")]
	[Token(Token = "0x6000200")]
	public virtual bool get_IsDefault() { }

	[Address(RVA = "0x24EEE00", Offset = "0x24EE200", Length = "0x37")]
	[Token(Token = "0x60001FF")]
	public virtual bool get_IsEmptyElement() { }

	[Address(RVA = "0x24EEE40", Offset = "0x24EE240", Length = "0x37")]
	[Token(Token = "0x60001F9")]
	public virtual string get_LocalName() { }

	[Address(RVA = "0x24EEEC0", Offset = "0x24EE2C0", Length = "0x37")]
	[Token(Token = "0x60001F8")]
	public virtual string get_Name() { }

	[Address(RVA = "0x24EEF00", Offset = "0x24EE300", Length = "0x37")]
	[Token(Token = "0x6000224")]
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	[Address(RVA = "0x24EEF40", Offset = "0x24EE340", Length = "0x37")]
	[Token(Token = "0x60001FA")]
	public virtual string get_NamespaceURI() { }

	[Address(RVA = "0x24EEE80", Offset = "0x24EE280", Length = "0x37")]
	[Token(Token = "0x6000215")]
	public virtual XmlNameTable get_NameTable() { }

	[Address(RVA = "0x24EEF80", Offset = "0x24EE380", Length = "0x37")]
	[Token(Token = "0x60001F7")]
	public virtual XmlNodeType get_NodeType() { }

	[Address(RVA = "0x24EEFC0", Offset = "0x24EE3C0", Length = "0x37")]
	[Token(Token = "0x60001FB")]
	public virtual string get_Prefix() { }

	[Address(RVA = "0x24EF000", Offset = "0x24EE400", Length = "0x37")]
	[Token(Token = "0x6000201")]
	public virtual char get_QuoteChar() { }

	[Address(RVA = "0x24EF040", Offset = "0x24EE440", Length = "0x37")]
	[Token(Token = "0x6000213")]
	public virtual ReadState get_ReadState() { }

	[Address(RVA = "0x24EF080", Offset = "0x24EE480", Length = "0x37")]
	[Token(Token = "0x6000204")]
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	[Address(RVA = "0x24EF0C0", Offset = "0x24EE4C0", Length = "0xF9")]
	[Token(Token = "0x60001F6")]
	public virtual XmlReaderSettings get_Settings() { }

	[Address(RVA = "0x24EF200", Offset = "0x24EE600", Length = "0x37")]
	[Token(Token = "0x60001FC")]
	public virtual string get_Value() { }

	[Address(RVA = "0x24EF1C0", Offset = "0x24EE5C0", Length = "0x37")]
	[Token(Token = "0x6000205")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x24EF240", Offset = "0x24EE640", Length = "0x37")]
	[Token(Token = "0x6000203")]
	public virtual string get_XmlLang() { }

	[Address(RVA = "0x24EF280", Offset = "0x24EE680", Length = "0x37")]
	[Token(Token = "0x6000202")]
	public virtual XmlSpace get_XmlSpace() { }

	[Address(RVA = "0x24EE5B0", Offset = "0x24ED9B0", Length = "0x56")]
	[Token(Token = "0x6000208")]
	public virtual string GetAttribute(string name, string namespaceURI) { }

	[Address(RVA = "0x24EE510", Offset = "0x24ED910", Length = "0x44")]
	[Token(Token = "0x6000209")]
	public virtual string GetAttribute(int i) { }

	[Address(RVA = "0x24EE560", Offset = "0x24ED960", Length = "0x46")]
	[Token(Token = "0x6000207")]
	public virtual string GetAttribute(string name) { }

	[Address(RVA = "0x24EE610", Offset = "0x24EDA10", Length = "0x56")]
	[Token(Token = "0x6000220")]
	public virtual bool IsStartElement(string localname, string ns) { }

	[Address(RVA = "0x24EE670", Offset = "0x24EDA70", Length = "0x46")]
	[Token(Token = "0x6000216")]
	public virtual string LookupNamespace(string prefix) { }

	[Address(RVA = "0x24EE6C0", Offset = "0x24EDAC0", Length = "0x44")]
	[Token(Token = "0x600020B")]
	public virtual void MoveToAttribute(int i) { }

	[Address(RVA = "0x24EE710", Offset = "0x24EDB10", Length = "0x46")]
	[Token(Token = "0x600020A")]
	public virtual bool MoveToAttribute(string name) { }

	[Address(RVA = "0x24EE760", Offset = "0x24EDB60", Length = "0x37")]
	[Token(Token = "0x600021C")]
	public virtual XmlNodeType MoveToContent() { }

	[Address(RVA = "0x24EE7A0", Offset = "0x24EDBA0", Length = "0x37")]
	[Token(Token = "0x600020E")]
	public virtual bool MoveToElement() { }

	[Address(RVA = "0x24EE7E0", Offset = "0x24EDBE0", Length = "0x37")]
	[Token(Token = "0x600020C")]
	public virtual bool MoveToFirstAttribute() { }

	[Address(RVA = "0x24EE820", Offset = "0x24EDC20", Length = "0x37")]
	[Token(Token = "0x600020D")]
	public virtual bool MoveToNextAttribute() { }

	[Address(RVA = "0x24EEA50", Offset = "0x24EDE50", Length = "0x37")]
	[Token(Token = "0x6000210")]
	public virtual bool Read() { }

	[Address(RVA = "0x24EE860", Offset = "0x24EDC60", Length = "0x37")]
	[Token(Token = "0x600020F")]
	public virtual bool ReadAttributeValue() { }

	[Address(RVA = "0x24EE8A0", Offset = "0x24EDCA0", Length = "0x37")]
	[Token(Token = "0x600021E")]
	public virtual string ReadElementString() { }

	[Address(RVA = "0x24EE8E0", Offset = "0x24EDCE0", Length = "0x37")]
	[Token(Token = "0x600021F")]
	public virtual void ReadEndElement() { }

	[Address(RVA = "0x24EE920", Offset = "0x24EDD20", Length = "0x37")]
	[Token(Token = "0x6000221")]
	public virtual string ReadInnerXml() { }

	[Address(RVA = "0x24EE960", Offset = "0x24EDD60", Length = "0x37")]
	[Token(Token = "0x600021D")]
	public virtual void ReadStartElement() { }

	[Address(RVA = "0x24EE9A0", Offset = "0x24EDDA0", Length = "0x37")]
	[Token(Token = "0x600021B")]
	public virtual string ReadString() { }

	[Address(RVA = "0x24EE9E0", Offset = "0x24EDDE0", Length = "0x6B")]
	[Token(Token = "0x600021A")]
	public virtual int ReadValueChunk(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24EEA90", Offset = "0x24EDE90", Length = "0x37")]
	[Token(Token = "0x6000218")]
	public virtual void ResolveEntity() { }

	[Address(RVA = "0x24EEAD0", Offset = "0x24EDED0", Length = "0x37")]
	[Token(Token = "0x6000214")]
	public virtual void Skip() { }

}

