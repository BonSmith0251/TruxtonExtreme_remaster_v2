namespace System.Xml;

[Token(Token = "0x200006E")]
internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000304")]
	protected int indentLevel; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000305")]
	protected bool newLineOnAttributes; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000306")]
	protected string indentChars; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000307")]
	protected bool mixedContent; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000308")]
	private BitStack mixedContentStack; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000309")]
	protected ConformanceLevel conformanceLevel; //Field offset: 0xB0

	[Address(RVA = "0x2503FB0", Offset = "0x25033B0", Length = "0x124")]
	[Token(Token = "0x60005B7")]
	public XmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x25033C0", Offset = "0x25027C0", Length = "0x11C")]
	[Token(Token = "0x60005CB")]
	private void Init(XmlWriterSettings settings) { }

	[Address(RVA = "0x1D58B00", Offset = "0x1D57F00", Length = "0x7")]
	[Token(Token = "0x60005BB")]
	internal virtual void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	[Address(RVA = "0x25034E0", Offset = "0x25028E0", Length = "0x6C")]
	[Token(Token = "0x60005BA")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x2503550", Offset = "0x2502950", Length = "0x15")]
	[Token(Token = "0x60005CA")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x2503570", Offset = "0x2502970", Length = "0xF")]
	[Token(Token = "0x60005BF")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x2503580", Offset = "0x2502980", Length = "0xF")]
	[Token(Token = "0x60005C3")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x2503590", Offset = "0x2502990", Length = "0x4E")]
	[Token(Token = "0x60005C7")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x25035E0", Offset = "0x25029E0", Length = "0x40")]
	[Token(Token = "0x60005C0")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x2503620", Offset = "0x2502A20", Length = "0x66")]
	[Token(Token = "0x60005B8")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x2503690", Offset = "0x2502A90", Length = "0x8F")]
	[Token(Token = "0x60005BC")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2503720", Offset = "0x2502B20", Length = "0xB3")]
	[Token(Token = "0x60005C2")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x25037E0", Offset = "0x2502BE0", Length = "0x147")]
	[Token(Token = "0x60005BD")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2503930", Offset = "0x2502D30", Length = "0x97")]
	[Token(Token = "0x60005CC")]
	private void WriteIndent() { }

	[Address(RVA = "0x25039D0", Offset = "0x2502DD0", Length = "0x138")]
	[Token(Token = "0x60005C1")]
	public virtual void WriteProcessingInstruction(string target, string text) { }

	[Address(RVA = "0x2503B70", Offset = "0x2502F70", Length = "0x4C")]
	[Token(Token = "0x60005C8")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x2503B10", Offset = "0x2502F10", Length = "0x52")]
	[Token(Token = "0x60005C9")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x2503BC0", Offset = "0x2502FC0", Length = "0x11A")]
	[Token(Token = "0x60005BE")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2503CE0", Offset = "0x25030E0", Length = "0x108")]
	[Token(Token = "0x60005B9")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x2503DF0", Offset = "0x25031F0", Length = "0x60")]
	[Token(Token = "0x60005C6")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x2503E60", Offset = "0x2503260", Length = "0x147")]
	[Token(Token = "0x60005C4")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x2503DF0", Offset = "0x25031F0", Length = "0x60")]
	[Token(Token = "0x60005C5")]
	public virtual void WriteWhitespace(string ws) { }

}

