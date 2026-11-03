namespace System.Xml;

[Token(Token = "0x2000035")]
internal class QueryOutputWriter : XmlRawWriter
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400010C")]
	private XmlRawWriter wrapped; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400010D")]
	private bool inCDataSection; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400010E")]
	private Dictionary<XmlQualifiedName, Int32> lookupCDataElems; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400010F")]
	private BitStack bitsCData; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000110")]
	private XmlQualifiedName qnameCData; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000111")]
	private bool outputDocType; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x4000112")]
	private bool checkWellFormedDoc; //Field offset: 0x51
	[FieldOffset(Offset = "0x52")]
	[Token(Token = "0x4000113")]
	private bool hasDocElem; //Field offset: 0x52
	[FieldOffset(Offset = "0x53")]
	[Token(Token = "0x4000114")]
	private bool inAttr; //Field offset: 0x53
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000115")]
	private string systemId; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000116")]
	private string publicId; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000117")]
	private int depth; //Field offset: 0x68

	[Token(Token = "0x17000045")]
	internal virtual IXmlNamespaceResolver NamespaceResolver
	{
		[Address(RVA = "0x24EC980", Offset = "0x24EBD80", Length = "0x4C")]
		[Token(Token = "0x6000180")]
		internal set { } //Length: 76
	}

	[Token(Token = "0x17000046")]
	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		[Address(RVA = "0x24EC950", Offset = "0x24EBD50", Length = "0x2A")]
		[Token(Token = "0x600018B")]
		internal get { } //Length: 42
	}

	[Address(RVA = "0x24EC680", Offset = "0x24EBA80", Length = "0x2CC")]
	[Token(Token = "0x600017F")]
	public QueryOutputWriter(XmlRawWriter writer, XmlWriterSettings settings) { }

	[Address(RVA = "0x24EBC20", Offset = "0x24EB020", Length = "0xA4")]
	[Token(Token = "0x6000199")]
	public virtual void Close() { }

	[Address(RVA = "0xD985E0", Offset = "0xD979E0", Length = "0x5")]
	[Token(Token = "0x600019C")]
	private void EndCDataSection() { }

	[Address(RVA = "0x24EBCD0", Offset = "0x24EB0D0", Length = "0x2A")]
	[Token(Token = "0x600019A")]
	public virtual void Flush() { }

	[Address(RVA = "0x24EC950", Offset = "0x24EBD50", Length = "0x2A")]
	[Token(Token = "0x600018B")]
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	[Address(RVA = "0x24EC980", Offset = "0x24EBD80", Length = "0x4C")]
	[Token(Token = "0x6000180")]
	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	[Address(RVA = "0x24EBD00", Offset = "0x24EB100", Length = "0x3D")]
	[Token(Token = "0x600019B")]
	private bool StartCDataSection() { }

	[Address(RVA = "0x24EBD40", Offset = "0x24EB140", Length = "0x2A")]
	[Token(Token = "0x6000187")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x24EBD70", Offset = "0x24EB170", Length = "0x2A")]
	[Token(Token = "0x600018E")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x24EBDA0", Offset = "0x24EB1A0", Length = "0x2E")]
	[Token(Token = "0x6000195")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x24EBDD0", Offset = "0x24EB1D0", Length = "0xD2")]
	[Token(Token = "0x6000193")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24EBEB0", Offset = "0x24EB2B0", Length = "0x2E")]
	[Token(Token = "0x600018F")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x24EBEE0", Offset = "0x24EB2E0", Length = "0x42")]
	[Token(Token = "0x6000183")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x24EBF30", Offset = "0x24EB330", Length = "0x2E")]
	[Token(Token = "0x6000189")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x24EBF60", Offset = "0x24EB360", Length = "0x5F")]
	[Token(Token = "0x6000185")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24EBFC0", Offset = "0x24EB3C0", Length = "0x2A")]
	[Token(Token = "0x600018D")]
	internal virtual void WriteEndNamespaceDeclaration() { }

	[Address(RVA = "0x24EBFF0", Offset = "0x24EB3F0", Length = "0x2E")]
	[Token(Token = "0x6000194")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x24EC020", Offset = "0x24EB420", Length = "0x5F")]
	[Token(Token = "0x6000186")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24EC080", Offset = "0x24EB480", Length = "0x2A")]
	[Token(Token = "0x600018A")]
	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	[Address(RVA = "0x24EC0B0", Offset = "0x24EB4B0", Length = "0x2E")]
	[Token(Token = "0x6000190")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x24EC0E0", Offset = "0x24EB4E0", Length = "0xD2")]
	[Token(Token = "0x6000197")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24EC1C0", Offset = "0x24EB5C0", Length = "0x94")]
	[Token(Token = "0x6000198")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x24EC260", Offset = "0x24EB660", Length = "0x33")]
	[Token(Token = "0x6000188")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24EC2A0", Offset = "0x24EB6A0", Length = "0x1D5")]
	[Token(Token = "0x6000184")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24EC480", Offset = "0x24EB880", Length = "0x2A")]
	[Token(Token = "0x600018C")]
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	[Address(RVA = "0x24EC4B0", Offset = "0x24EB8B0", Length = "0x94")]
	[Token(Token = "0x6000192")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x24EC550", Offset = "0x24EB950", Length = "0x2E")]
	[Token(Token = "0x6000196")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x24EC580", Offset = "0x24EB980", Length = "0x94")]
	[Token(Token = "0x6000191")]
	public virtual void WriteWhitespace(string ws) { }

	[Address(RVA = "0x24EC620", Offset = "0x24EBA20", Length = "0x2A")]
	[Token(Token = "0x6000181")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	[Address(RVA = "0x24EC650", Offset = "0x24EBA50", Length = "0x2A")]
	[Token(Token = "0x6000182")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

}

