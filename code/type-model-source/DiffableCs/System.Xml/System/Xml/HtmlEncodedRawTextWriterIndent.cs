namespace System.Xml;

[Token(Token = "0x2000022")]
internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter
{
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40000F2")]
	private int indentLevel; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x40000F3")]
	private int endBlockPos; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40000F4")]
	private string indentChars; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40000F5")]
	private bool newLineOnAttributes; //Field offset: 0x100

	[Address(RVA = "0x23F4190", Offset = "0x23F3590", Length = "0x66")]
	[Token(Token = "0x600010A")]
	public HtmlEncodedRawTextWriterIndent(TextWriter writer, XmlWriterSettings settings) { }

	[Address(RVA = "0x23F4120", Offset = "0x23F3520", Length = "0x66")]
	[Token(Token = "0x600010B")]
	public HtmlEncodedRawTextWriterIndent(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x23F3AB0", Offset = "0x23F2EB0", Length = "0x1D")]
	[Token(Token = "0x6000111")]
	protected virtual void FlushBuffer() { }

	[Address(RVA = "0x23F3AD0", Offset = "0x23F2ED0", Length = "0x50")]
	[Token(Token = "0x6000112")]
	private void Init(XmlWriterSettings settings) { }

	[Address(RVA = "0x23F3B30", Offset = "0x23F2F30", Length = "0xC1")]
	[Token(Token = "0x600010E")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x23F3C00", Offset = "0x23F3000", Length = "0x30")]
	[Token(Token = "0x600010C")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x23F3C30", Offset = "0x23F3030", Length = "0x1D2")]
	[Token(Token = "0x600010F")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x23F3E10", Offset = "0x23F3210", Length = "0x53")]
	[Token(Token = "0x6000113")]
	private void WriteIndent() { }

	[Address(RVA = "0x23F3E70", Offset = "0x23F3270", Length = "0xB2")]
	[Token(Token = "0x6000110")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x23F3F30", Offset = "0x23F3330", Length = "0x1EC")]
	[Token(Token = "0x600010D")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

}

