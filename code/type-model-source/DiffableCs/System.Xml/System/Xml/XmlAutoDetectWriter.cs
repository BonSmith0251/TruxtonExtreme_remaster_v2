namespace System.Xml;

[Token(Token = "0x2000049")]
internal class XmlAutoDetectWriter : XmlRawWriter
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000155")]
	private XmlRawWriter wrapped; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000156")]
	private OnRemoveWriter onRemove; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000157")]
	private XmlWriterSettings writerSettings; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000158")]
	private XmlEventCache eventCache; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000159")]
	private TextWriter textWriter; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400015A")]
	private Stream strm; //Field offset: 0x50

	[Token(Token = "0x17000077")]
	internal virtual IXmlNamespaceResolver NamespaceResolver
	{
		[Address(RVA = "0x24F0CE0", Offset = "0x24F00E0", Length = "0x57")]
		[Token(Token = "0x6000271")]
		internal set { } //Length: 87
	}

	[Token(Token = "0x17000078")]
	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		[Address(RVA = "0x24EC950", Offset = "0x24EBD50", Length = "0x2A")]
		[Token(Token = "0x6000278")]
		internal get { } //Length: 42
	}

	[Address(RVA = "0x24F0C00", Offset = "0x24F0000", Length = "0xD0")]
	[Token(Token = "0x600025A")]
	private XmlAutoDetectWriter(XmlWriterSettings writerSettings) { }

	[Address(RVA = "0x24F0BC0", Offset = "0x24EFFC0", Length = "0x38")]
	[Token(Token = "0x600025B")]
	public XmlAutoDetectWriter(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	[Address(RVA = "0x24F0B80", Offset = "0x24EFF80", Length = "0x38")]
	[Token(Token = "0x600025C")]
	public XmlAutoDetectWriter(Stream strm, XmlWriterSettings writerSettings) { }

	[Address(RVA = "0x24EFDC0", Offset = "0x24EF1C0", Length = "0x41")]
	[Token(Token = "0x600026E")]
	public virtual void Close() { }

	[Address(RVA = "0x24EFE10", Offset = "0x24EF210", Length = "0x1CE")]
	[Token(Token = "0x600027E")]
	private void CreateWrappedWriter(XmlOutputMethod outMethod) { }

	[Address(RVA = "0x24EFFE0", Offset = "0x24EF3E0", Length = "0x10")]
	[Token(Token = "0x600027C")]
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	[Address(RVA = "0x24EFFF0", Offset = "0x24EF3F0", Length = "0x41")]
	[Token(Token = "0x600026F")]
	public virtual void Flush() { }

	[Address(RVA = "0x24EC950", Offset = "0x24EBD50", Length = "0x2A")]
	[Token(Token = "0x6000278")]
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	[Address(RVA = "0x24F0040", Offset = "0x24EF440", Length = "0xDC")]
	[Token(Token = "0x600027B")]
	private static bool IsHtmlTag(string tagName) { }

	[Address(RVA = "0x24F0CE0", Offset = "0x24F00E0", Length = "0x57")]
	[Token(Token = "0x6000271")]
	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	[Address(RVA = "0x24EBD40", Offset = "0x24EB140", Length = "0x2A")]
	[Token(Token = "0x6000274")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x24F0120", Offset = "0x24EF520", Length = "0x67")]
	[Token(Token = "0x600027D")]
	private bool TextBlockCreatesWriter(string textBlock) { }

	[Address(RVA = "0x24F0190", Offset = "0x24EF590", Length = "0x75")]
	[Token(Token = "0x600026C")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x24F0210", Offset = "0x24EF610", Length = "0x75")]
	[Token(Token = "0x600026D")]
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x24F0290", Offset = "0x24EF690", Length = "0x82")]
	[Token(Token = "0x6000261")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x24F0320", Offset = "0x24EF720", Length = "0x50")]
	[Token(Token = "0x600026A")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x24F0380", Offset = "0x24EF780", Length = "0x38")]
	[Token(Token = "0x6000266")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24F03C0", Offset = "0x24EF7C0", Length = "0x35")]
	[Token(Token = "0x6000262")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x24F0400", Offset = "0x24EF800", Length = "0x75")]
	[Token(Token = "0x600025D")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x24F0480", Offset = "0x24EF880", Length = "0x2A")]
	[Token(Token = "0x6000260")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x24F04B0", Offset = "0x24EF8B0", Length = "0x2F")]
	[Token(Token = "0x6000275")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24EBFC0", Offset = "0x24EB3C0", Length = "0x2A")]
	[Token(Token = "0x600027A")]
	internal virtual void WriteEndNamespaceDeclaration() { }

	[Address(RVA = "0x24F04E0", Offset = "0x24EF8E0", Length = "0x50")]
	[Token(Token = "0x6000269")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x24F0540", Offset = "0x24EF940", Length = "0x2F")]
	[Token(Token = "0x6000276")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F0570", Offset = "0x24EF970", Length = "0x60")]
	[Token(Token = "0x6000277")]
	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	[Address(RVA = "0x24F05E0", Offset = "0x24EF9E0", Length = "0x35")]
	[Token(Token = "0x6000263")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x24F0620", Offset = "0x24EFA20", Length = "0x38")]
	[Token(Token = "0x6000267")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24F0660", Offset = "0x24EFA60", Length = "0x82")]
	[Token(Token = "0x6000268")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x24F06F0", Offset = "0x24EFAF0", Length = "0x75")]
	[Token(Token = "0x600025F")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F0770", Offset = "0x24EFB70", Length = "0x159")]
	[Token(Token = "0x600025E")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F08D0", Offset = "0x24EFCD0", Length = "0x50")]
	[Token(Token = "0x6000279")]
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	[Address(RVA = "0x24F0930", Offset = "0x24EFD30", Length = "0x82")]
	[Token(Token = "0x6000265")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x24F09C0", Offset = "0x24EFDC0", Length = "0x62")]
	[Token(Token = "0x600026B")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x24F0A30", Offset = "0x24EFE30", Length = "0x50")]
	[Token(Token = "0x6000270")]
	public virtual void WriteValue(string value) { }

	[Address(RVA = "0x24F0A90", Offset = "0x24EFE90", Length = "0x35")]
	[Token(Token = "0x6000264")]
	public virtual void WriteWhitespace(string ws) { }

	[Address(RVA = "0x24F0AD0", Offset = "0x24EFED0", Length = "0x4E")]
	[Token(Token = "0x6000272")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	[Address(RVA = "0x24F0B20", Offset = "0x24EFF20", Length = "0x50")]
	[Token(Token = "0x6000273")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

}

