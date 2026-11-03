namespace System.Xml;

[Token(Token = "0x2000021")]
internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter
{
	[Token(Token = "0x40000F0")]
	protected static TernaryTreeReadOnly elementPropertySearch; //Field offset: 0x0
	[Token(Token = "0x40000F1")]
	protected static TernaryTreeReadOnly attributePropertySearch; //Field offset: 0x8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40000E9")]
	protected ByteStack elementScope; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40000EA")]
	protected ElementProperties currentElementProperties; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[Token(Token = "0x40000EB")]
	private AttributeProperties currentAttributeProperties; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000EC")]
	private bool endsWithAmpersand; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40000ED")]
	private Byte[] uriEscapingBuffer; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40000EE")]
	private string mediaType; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40000EF")]
	private bool doNotEscapeUriAttributes; //Field offset: 0xE8

	[Address(RVA = "0x23F58C0", Offset = "0x23F4CC0", Length = "0x30")]
	[Token(Token = "0x60000F2")]
	public HtmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings) { }

	[Address(RVA = "0x23F58F0", Offset = "0x23F4CF0", Length = "0x30")]
	[Token(Token = "0x60000F3")]
	public HtmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x23F4200", Offset = "0x23F3600", Length = "0x230")]
	[Token(Token = "0x6000103")]
	private void Init(XmlWriterSettings settings) { }

	[Address(RVA = "0x23F4440", Offset = "0x23F3840", Length = "0x9C")]
	[Token(Token = "0x6000109")]
	private void OutputRestAmps() { }

	[Address(RVA = "0x23F44E0", Offset = "0x23F38E0", Length = "0x50")]
	[Token(Token = "0x60000F8")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x23F4540", Offset = "0x23F3940", Length = "0x5F")]
	[Token(Token = "0x6000100")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x23F45A0", Offset = "0x23F39A0", Length = "0x8A")]
	[Token(Token = "0x6000102")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x23F4630", Offset = "0x23F3A30", Length = "0x215")]
	[Token(Token = "0x60000F6")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x23F4850", Offset = "0x23F3C50", Length = "0x82")]
	[Token(Token = "0x60000FC")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x23F48E0", Offset = "0x23F3CE0", Length = "0x12A")]
	[Token(Token = "0x60000F9")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x23F4A10", Offset = "0x23F3E10", Length = "0x5F")]
	[Token(Token = "0x60000FF")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x23F4A70", Offset = "0x23F3E70", Length = "0x12A")]
	[Token(Token = "0x60000FA")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x23F4BF0", Offset = "0x23F3FF0", Length = "0x2C6")]
	[Token(Token = "0x6000107")]
	private void WriteHtmlAttributeText(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x23F4BA0", Offset = "0x23F3FA0", Length = "0x46")]
	[Token(Token = "0x6000106")]
	protected void WriteHtmlAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x23F4EC0", Offset = "0x23F42C0", Length = "0x17")]
	[Token(Token = "0x6000105")]
	protected void WriteHtmlElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x23F4EE0", Offset = "0x23F42E0", Length = "0x10E")]
	[Token(Token = "0x6000104")]
	protected void WriteMetaElement() { }

	[Address(RVA = "0x23F4FF0", Offset = "0x23F43F0", Length = "0x125")]
	[Token(Token = "0x60000FD")]
	public virtual void WriteProcessingInstruction(string target, string text) { }

	[Address(RVA = "0x23F5120", Offset = "0x23F4520", Length = "0x17E")]
	[Token(Token = "0x60000FB")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x23F52A0", Offset = "0x23F46A0", Length = "0x12F")]
	[Token(Token = "0x60000F7")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x23F53D0", Offset = "0x23F47D0", Length = "0xEF")]
	[Token(Token = "0x60000FE")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x23F54C0", Offset = "0x23F48C0", Length = "0x5F")]
	[Token(Token = "0x6000101")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x23F5520", Offset = "0x23F4920", Length = "0x396")]
	[Token(Token = "0x6000108")]
	private void WriteUriAttributeText(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000F5")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000F4")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

}

