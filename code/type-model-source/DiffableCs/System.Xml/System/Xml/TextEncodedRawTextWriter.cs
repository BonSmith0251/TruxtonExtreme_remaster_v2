namespace System.Xml;

[Token(Token = "0x200003E")]
internal class TextEncodedRawTextWriter : XmlEncodedRawTextWriter
{

	[Token(Token = "0x17000047")]
	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60001B5")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x24ED3B0", Offset = "0x24EC7B0", Length = "0x8")]
	[Token(Token = "0x60001A9")]
	public TextEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings) { }

	[Address(RVA = "0x24ED3C0", Offset = "0x24EC7C0", Length = "0x8")]
	[Token(Token = "0x60001AA")]
	public TextEncodedRawTextWriter(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60001B5")]
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001B1")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x24ED220", Offset = "0x24EC620", Length = "0x67")]
	[Token(Token = "0x60001B6")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001BA")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x24ED290", Offset = "0x24EC690", Length = "0x89")]
	[Token(Token = "0x60001BE")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001B7")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001AD")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x24ED320", Offset = "0x24EC720", Length = "0x5")]
	[Token(Token = "0x60001B3")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001AF")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001B9")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001B0")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001B4")]
	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001B8")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x24ED290", Offset = "0x24EC690", Length = "0x89")]
	[Token(Token = "0x60001BF")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24ED330", Offset = "0x24EC730", Length = "0x6D")]
	[Token(Token = "0x60001C0")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x24ED3A0", Offset = "0x24EC7A0", Length = "0x5")]
	[Token(Token = "0x60001B2")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001AE")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24ED330", Offset = "0x24EC730", Length = "0x6D")]
	[Token(Token = "0x60001BD")]
	public virtual void WriteString(string textBlock) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001BB")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x24ED330", Offset = "0x24EC730", Length = "0x6D")]
	[Token(Token = "0x60001BC")]
	public virtual void WriteWhitespace(string ws) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001AC")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001AB")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

}

