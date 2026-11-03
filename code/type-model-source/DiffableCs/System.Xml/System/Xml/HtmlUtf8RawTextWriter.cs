namespace System.Xml;

[Token(Token = "0x2000024")]
internal class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter
{
	[Token(Token = "0x40000FF")]
	protected static TernaryTreeReadOnly elementPropertySearch; //Field offset: 0x0
	[Token(Token = "0x4000100")]
	protected static TernaryTreeReadOnly attributePropertySearch; //Field offset: 0x8
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000F8")]
	protected ByteStack elementScope; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000F9")]
	protected ElementProperties currentElementProperties; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40000FA")]
	private AttributeProperties currentAttributeProperties; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000FB")]
	private bool endsWithAmpersand; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000FC")]
	private Byte[] uriEscapingBuffer; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40000FD")]
	private string mediaType; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40000FE")]
	private bool doNotEscapeUriAttributes; //Field offset: 0xB8

	[Address(RVA = "0x23F7060", Offset = "0x23F6460", Length = "0x30")]
	[Token(Token = "0x6000115")]
	public HtmlUtf8RawTextWriter(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x23F5A10", Offset = "0x23F4E10", Length = "0x230")]
	[Token(Token = "0x6000125")]
	private void Init(XmlWriterSettings settings) { }

	[Address(RVA = "0x23F5C50", Offset = "0x23F5050", Length = "0x94")]
	[Token(Token = "0x600012B")]
	private void OutputRestAmps() { }

	[Address(RVA = "0x23F5CF0", Offset = "0x23F50F0", Length = "0x152")]
	[Token(Token = "0x600011A")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x23F5E50", Offset = "0x23F5250", Length = "0x5F")]
	[Token(Token = "0x6000122")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x23F5EB0", Offset = "0x23F52B0", Length = "0x47")]
	[Token(Token = "0x6000124")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x23F5F00", Offset = "0x23F5300", Length = "0x1EC")]
	[Token(Token = "0x6000118")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x23F60F0", Offset = "0x23F54F0", Length = "0x61")]
	[Token(Token = "0x600011E")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x23F6160", Offset = "0x23F5560", Length = "0x109")]
	[Token(Token = "0x600011B")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x23F6270", Offset = "0x23F5670", Length = "0x5F")]
	[Token(Token = "0x6000121")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x23F62D0", Offset = "0x23F56D0", Length = "0x109")]
	[Token(Token = "0x600011C")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x23F6430", Offset = "0x23F5830", Length = "0x2AF")]
	[Token(Token = "0x6000129")]
	private void WriteHtmlAttributeText(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x23F63E0", Offset = "0x23F57E0", Length = "0x46")]
	[Token(Token = "0x6000128")]
	protected void WriteHtmlAttributeTextBlock(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x23F66E0", Offset = "0x23F5AE0", Length = "0x17")]
	[Token(Token = "0x6000127")]
	protected void WriteHtmlElementTextBlock(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x23F6700", Offset = "0x23F5B00", Length = "0x10E")]
	[Token(Token = "0x6000126")]
	protected void WriteMetaElement() { }

	[Address(RVA = "0x23F6810", Offset = "0x23F5C10", Length = "0xF0")]
	[Token(Token = "0x600011F")]
	public virtual void WriteProcessingInstruction(string target, string text) { }

	[Address(RVA = "0x23F6910", Offset = "0x23F5D10", Length = "0x159")]
	[Token(Token = "0x600011D")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x23F6A70", Offset = "0x23F5E70", Length = "0x10B")]
	[Token(Token = "0x6000119")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x23F6B80", Offset = "0x23F5F80", Length = "0xD3")]
	[Token(Token = "0x6000120")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x23F6C60", Offset = "0x23F6060", Length = "0x5F")]
	[Token(Token = "0x6000123")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x23F6CC0", Offset = "0x23F60C0", Length = "0x397")]
	[Token(Token = "0x600012A")]
	private void WriteUriAttributeText(Char* pSrc, Char* pSrcEnd) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000117")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000116")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

}

