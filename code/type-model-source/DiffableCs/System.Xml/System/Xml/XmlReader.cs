namespace System.Xml;

[DebuggerDisplay("{debuggerDisplayProxy}")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
[Token(Token = "0x2000051")]
public abstract class XmlReader : IDisposable
{
	[Token(Token = "0x40001B3")]
	private static uint IsTextualNodeBitmap; //Field offset: 0x0
	[Token(Token = "0x40001B4")]
	private static uint CanReadContentAsBitmap; //Field offset: 0x4
	[Token(Token = "0x40001B5")]
	private static uint HasValueBitmap; //Field offset: 0x8

	[Token(Token = "0x1700009D")]
	public abstract int AttributeCount
	{
		[Token(Token = "0x600033F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000095")]
	public abstract string BaseURI
	{
		[Token(Token = "0x6000337")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000A2")]
	public override bool CanReadValueChunk
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000352")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000A1")]
	public override bool CanResolveEntity
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000350")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000094")]
	public abstract int Depth
	{
		[Token(Token = "0x6000336")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000A6")]
	internal override IDtdInfo DtdInfo
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000367")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700009E")]
	public abstract bool EOF
	{
		[Token(Token = "0x600034A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000A3")]
	public override bool HasAttributes
	{
		[Address(RVA = "0x24FB520", Offset = "0x24FA920", Length = "0x21")]
		[Token(Token = "0x600035F")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000097")]
	public override bool IsDefault
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000339")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000A5")]
	internal bool IsDefaultInternal
	{
		[Address(RVA = "0x24FB550", Offset = "0x24FA950", Length = "0x82")]
		[Token(Token = "0x6000366")]
		internal get { } //Length: 130
	}

	[Token(Token = "0x17000096")]
	public abstract bool IsEmptyElement
	{
		[Token(Token = "0x6000338")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000090")]
	public abstract string LocalName
	{
		[Token(Token = "0x6000332")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700008F")]
	public override string Name
	{
		[Address(RVA = "0x24FB5E0", Offset = "0x24FA9E0", Length = "0x105")]
		[Token(Token = "0x6000331")]
		 get { } //Length: 261
	}

	[Token(Token = "0x170000A4")]
	internal override XmlNamespaceManager NamespaceManager
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000362")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000091")]
	public abstract string NamespaceURI
	{
		[Token(Token = "0x6000333")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000A0")]
	public abstract XmlNameTable NameTable
	{
		[Token(Token = "0x600034E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700008E")]
	public abstract XmlNodeType NodeType
	{
		[Token(Token = "0x6000330")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000092")]
	public abstract string Prefix
	{
		[Token(Token = "0x6000334")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000098")]
	public override char QuoteChar
	{
		[Address(RVA = "0x24FB6F0", Offset = "0x24FAAF0", Length = "0x6")]
		[Token(Token = "0x600033A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700009F")]
	public abstract ReadState ReadState
	{
		[Token(Token = "0x600034C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700009B")]
	public override IXmlSchemaInfo SchemaInfo
	{
		[Address(RVA = "0x24FB700", Offset = "0x24FAB00", Length = "0x39")]
		[Token(Token = "0x600033D")]
		 get { } //Length: 57
	}

	[Token(Token = "0x1700008D")]
	public override XmlReaderSettings Settings
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600032F")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000093")]
	public abstract string Value
	{
		[Token(Token = "0x6000335")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700009C")]
	public override Type ValueType
	{
		[Address(RVA = "0x24FB740", Offset = "0x24FAB40", Length = "0x32")]
		[Token(Token = "0x600033E")]
		 get { } //Length: 50
	}

	[Token(Token = "0x1700009A")]
	public override string XmlLang
	{
		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x600033C")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000099")]
	public override XmlSpace XmlSpace
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x600033B")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x24FB4B0", Offset = "0x24FA8B0", Length = "0x63")]
	[Token(Token = "0x600036D")]
	private static XmlReader() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600036C")]
	protected XmlReader() { }

	[Address(RVA = "0x24F93E0", Offset = "0x24F87E0", Length = "0x96")]
	[Token(Token = "0x600036B")]
	internal static int CalcBufferSize(Stream input) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600034B")]
	public override void Close() { }

	[Address(RVA = "0x24F9AD0", Offset = "0x24F8ED0", Length = "0x157")]
	[Token(Token = "0x6000369")]
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	[Address(RVA = "0x24F9910", Offset = "0x24F8D10", Length = "0x1B4")]
	[Token(Token = "0x6000368")]
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	[Address(RVA = "0x24F9480", Offset = "0x24F8880", Length = "0x368")]
	[Token(Token = "0x600036A")]
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	[Address(RVA = "0x24F97F0", Offset = "0x24F8BF0", Length = "0x11D")]
	[Token(Token = "0x600035D")]
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	[Address(RVA = "0x24F9C30", Offset = "0x24F9030", Length = "0x16")]
	[Token(Token = "0x6000360")]
	public override void Dispose() { }

	[Address(RVA = "0x24F9C50", Offset = "0x24F9050", Length = "0x40")]
	[Token(Token = "0x6000361")]
	protected override void Dispose(bool disposing) { }

	[Token(Token = "0x600033F")]
	public abstract int get_AttributeCount() { }

	[Token(Token = "0x6000337")]
	public abstract string get_BaseURI() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000352")]
	public override bool get_CanReadValueChunk() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000350")]
	public override bool get_CanResolveEntity() { }

	[Token(Token = "0x6000336")]
	public abstract int get_Depth() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000367")]
	internal override IDtdInfo get_DtdInfo() { }

	[Token(Token = "0x600034A")]
	public abstract bool get_EOF() { }

	[Address(RVA = "0x24FB520", Offset = "0x24FA920", Length = "0x21")]
	[Token(Token = "0x600035F")]
	public override bool get_HasAttributes() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000339")]
	public override bool get_IsDefault() { }

	[Address(RVA = "0x24FB550", Offset = "0x24FA950", Length = "0x82")]
	[Token(Token = "0x6000366")]
	internal bool get_IsDefaultInternal() { }

	[Token(Token = "0x6000338")]
	public abstract bool get_IsEmptyElement() { }

	[Token(Token = "0x6000332")]
	public abstract string get_LocalName() { }

	[Address(RVA = "0x24FB5E0", Offset = "0x24FA9E0", Length = "0x105")]
	[Token(Token = "0x6000331")]
	public override string get_Name() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000362")]
	internal override XmlNamespaceManager get_NamespaceManager() { }

	[Token(Token = "0x6000333")]
	public abstract string get_NamespaceURI() { }

	[Token(Token = "0x600034E")]
	public abstract XmlNameTable get_NameTable() { }

	[Token(Token = "0x6000330")]
	public abstract XmlNodeType get_NodeType() { }

	[Token(Token = "0x6000334")]
	public abstract string get_Prefix() { }

	[Address(RVA = "0x24FB6F0", Offset = "0x24FAAF0", Length = "0x6")]
	[Token(Token = "0x600033A")]
	public override char get_QuoteChar() { }

	[Token(Token = "0x600034C")]
	public abstract ReadState get_ReadState() { }

	[Address(RVA = "0x24FB700", Offset = "0x24FAB00", Length = "0x39")]
	[Token(Token = "0x600033D")]
	public override IXmlSchemaInfo get_SchemaInfo() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600032F")]
	public override XmlReaderSettings get_Settings() { }

	[Token(Token = "0x6000335")]
	public abstract string get_Value() { }

	[Address(RVA = "0x24FB740", Offset = "0x24FAB40", Length = "0x32")]
	[Token(Token = "0x600033E")]
	public override Type get_ValueType() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x600033C")]
	public override string get_XmlLang() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600033B")]
	public override XmlSpace get_XmlSpace() { }

	[Token(Token = "0x6000342")]
	public abstract string GetAttribute(int i) { }

	[Token(Token = "0x6000341")]
	public abstract string GetAttribute(string name, string namespaceURI) { }

	[Token(Token = "0x6000340")]
	public abstract string GetAttribute(string name) { }

	[Address(RVA = "0x24F9C90", Offset = "0x24F9090", Length = "0x6A")]
	[Token(Token = "0x6000364")]
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	[Address(RVA = "0x24F9D00", Offset = "0x24F9100", Length = "0x9D")]
	[Token(Token = "0x6000359")]
	public override bool IsStartElement(string localname, string ns) { }

	[Address(RVA = "0x24F9DA0", Offset = "0x24F91A0", Length = "0x69")]
	[Token(Token = "0x6000363")]
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	[Token(Token = "0x600034F")]
	public abstract string LookupNamespace(string prefix) { }

	[Token(Token = "0x6000343")]
	public abstract bool MoveToAttribute(string name) { }

	[Address(RVA = "0x24F9E10", Offset = "0x24F9210", Length = "0xCF")]
	[Token(Token = "0x6000344")]
	public override void MoveToAttribute(int i) { }

	[Address(RVA = "0x24F9EE0", Offset = "0x24F92E0", Length = "0x97")]
	[Token(Token = "0x6000355")]
	public override XmlNodeType MoveToContent() { }

	[Token(Token = "0x6000347")]
	public abstract bool MoveToElement() { }

	[Token(Token = "0x6000345")]
	public abstract bool MoveToFirstAttribute() { }

	[Token(Token = "0x6000346")]
	public abstract bool MoveToNextAttribute() { }

	[Token(Token = "0x6000349")]
	public abstract bool Read() { }

	[Token(Token = "0x6000348")]
	public abstract bool ReadAttributeValue() { }

	[Address(RVA = "0x24F9F80", Offset = "0x24F9380", Length = "0x290")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x6000357")]
	public override string ReadElementString() { }

	[Address(RVA = "0x24FA220", Offset = "0x24F9620", Length = "0xFD")]
	[Token(Token = "0x6000358")]
	public override void ReadEndElement() { }

	[Address(RVA = "0x24FA320", Offset = "0x24F9720", Length = "0x47C")]
	[Token(Token = "0x600035A")]
	public override string ReadInnerXml() { }

	[Address(RVA = "0x24FA7A0", Offset = "0x24F9BA0", Length = "0xFD")]
	[Token(Token = "0x6000356")]
	public override void ReadStartElement() { }

	[Address(RVA = "0x24FA8A0", Offset = "0x24F9CA0", Length = "0x248")]
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x6000354")]
	public override string ReadString() { }

	[Address(RVA = "0x24FAAF0", Offset = "0x24F9EF0", Length = "0x5F")]
	[Token(Token = "0x6000353")]
	public override int ReadValueChunk(Char[] buffer, int index, int count) { }

	[Token(Token = "0x6000351")]
	public abstract void ResolveEntity() { }

	[Address(RVA = "0x24FAB50", Offset = "0x24F9F50", Length = "0xE7")]
	[Token(Token = "0x600035E")]
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	[Address(RVA = "0x24FAD30", Offset = "0x24FA130", Length = "0x108")]
	[Token(Token = "0x600034D")]
	public override void Skip() { }

	[Address(RVA = "0x24FAC40", Offset = "0x24FA040", Length = "0xEB")]
	[Token(Token = "0x6000365")]
	private bool SkipSubtree() { }

	[Address(RVA = "0x24FAE40", Offset = "0x24FA240", Length = "0x118")]
	[Token(Token = "0x600035C")]
	private void WriteAttributeValue(XmlWriter xtw) { }

	[Address(RVA = "0x24FAF60", Offset = "0x24FA360", Length = "0x50C")]
	[Token(Token = "0x600035B")]
	private void WriteNode(XmlWriter xtw, bool defattr) { }

}

