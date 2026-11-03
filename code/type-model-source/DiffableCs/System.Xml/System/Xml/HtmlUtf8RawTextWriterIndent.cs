namespace System.Xml;

[Token(Token = "0x2000025")]
internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter
{
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000101")]
	private int indentLevel; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4000102")]
	private int endBlockPos; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000103")]
	private string indentChars; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000104")]
	private bool newLineOnAttributes; //Field offset: 0xD0

	[Address(RVA = "0x24EB080", Offset = "0x24EA480", Length = "0x58")]
	[Token(Token = "0x600012C")]
	public HtmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x24EAA00", Offset = "0x24E9E00", Length = "0x1D")]
	[Token(Token = "0x6000132")]
	protected virtual void FlushBuffer() { }

	[Address(RVA = "0x24EAA20", Offset = "0x24E9E20", Length = "0x50")]
	[Token(Token = "0x6000133")]
	private void Init(XmlWriterSettings settings) { }

	[Address(RVA = "0x24EAA80", Offset = "0x24E9E80", Length = "0xB1")]
	[Token(Token = "0x600012F")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x24EAB40", Offset = "0x24E9F40", Length = "0x30")]
	[Token(Token = "0x600012D")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x24EAB70", Offset = "0x24E9F70", Length = "0xD6")]
	[Token(Token = "0x6000130")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24EAC50", Offset = "0x24EA050", Length = "0x46")]
	[Token(Token = "0x6000134")]
	private void WriteIndent() { }

	[Address(RVA = "0x24EACA0", Offset = "0x24EA0A0", Length = "0xB2")]
	[Token(Token = "0x6000131")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24EAD60", Offset = "0x24EA160", Length = "0x315")]
	[Token(Token = "0x600012E")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

}

