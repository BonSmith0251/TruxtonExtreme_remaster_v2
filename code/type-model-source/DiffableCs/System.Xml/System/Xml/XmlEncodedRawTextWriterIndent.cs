namespace System.Xml;

[Token(Token = "0x200004B")]
internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter
{
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400017B")]
	protected int indentLevel; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x400017C")]
	protected bool newLineOnAttributes; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400017D")]
	protected string indentChars; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400017E")]
	protected bool mixedContent; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400017F")]
	private BitStack mixedContentStack; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000180")]
	protected ConformanceLevel conformanceLevel; //Field offset: 0xE0

	[Address(RVA = "0x24F1A50", Offset = "0x24F0E50", Length = "0x30")]
	[Token(Token = "0x60002B7")]
	public XmlEncodedRawTextWriterIndent(TextWriter writer, XmlWriterSettings settings) { }

	[Address(RVA = "0x24F1A80", Offset = "0x24F0E80", Length = "0x30")]
	[Token(Token = "0x60002B8")]
	public XmlEncodedRawTextWriterIndent(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x24F0E20", Offset = "0x24F0220", Length = "0x122")]
	[Token(Token = "0x60002CC")]
	private void Init(XmlWriterSettings settings) { }

	[Address(RVA = "0x1D433A0", Offset = "0x1D427A0", Length = "0x7")]
	[Token(Token = "0x60002BC")]
	internal virtual void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	[Address(RVA = "0x24F0F50", Offset = "0x24F0350", Length = "0x6E")]
	[Token(Token = "0x60002BB")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x24F0FC0", Offset = "0x24F03C0", Length = "0xBC")]
	[Token(Token = "0x60002CB")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x24F1080", Offset = "0x24F0480", Length = "0xF")]
	[Token(Token = "0x60002C0")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x24F1090", Offset = "0x24F0490", Length = "0xF")]
	[Token(Token = "0x60002C4")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x24F10A0", Offset = "0x24F04A0", Length = "0x91")]
	[Token(Token = "0x60002C8")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24F1140", Offset = "0x24F0540", Length = "0x40")]
	[Token(Token = "0x60002C1")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x24F1180", Offset = "0x24F0580", Length = "0x66")]
	[Token(Token = "0x60002B9")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x24F11F0", Offset = "0x24F05F0", Length = "0x8F")]
	[Token(Token = "0x60002BD")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F1280", Offset = "0x24F0680", Length = "0xD8")]
	[Token(Token = "0x60002C3")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x24F1360", Offset = "0x24F0760", Length = "0x16E")]
	[Token(Token = "0x60002BE")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F14D0", Offset = "0x24F08D0", Length = "0x97")]
	[Token(Token = "0x60002CD")]
	private void WriteIndent() { }

	[Address(RVA = "0x24F1570", Offset = "0x24F0970", Length = "0x50")]
	[Token(Token = "0x60002C2")]
	public virtual void WriteProcessingInstruction(string target, string text) { }

	[Address(RVA = "0x24F15C0", Offset = "0x24F09C0", Length = "0x8A")]
	[Token(Token = "0x60002C9")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24F1650", Offset = "0x24F0A50", Length = "0x6E")]
	[Token(Token = "0x60002CA")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x24F16C0", Offset = "0x24F0AC0", Length = "0x149")]
	[Token(Token = "0x60002BF")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F1810", Offset = "0x24F0C10", Length = "0x12B")]
	[Token(Token = "0x60002BA")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F1940", Offset = "0x24F0D40", Length = "0x7C")]
	[Token(Token = "0x60002C7")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x24F19C0", Offset = "0x24F0DC0", Length = "0xF")]
	[Token(Token = "0x60002C5")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x24F19D0", Offset = "0x24F0DD0", Length = "0x7C")]
	[Token(Token = "0x60002C6")]
	public virtual void WriteWhitespace(string ws) { }

}

