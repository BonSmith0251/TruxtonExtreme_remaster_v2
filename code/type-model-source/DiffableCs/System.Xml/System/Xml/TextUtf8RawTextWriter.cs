namespace System.Xml;

[Token(Token = "0x200003F")]
internal class TextUtf8RawTextWriter : XmlUtf8RawTextWriter
{

	[Token(Token = "0x17000048")]
	internal virtual bool SupportsNamespaceDeclarationInChunks
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60001CC")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x24ED410", Offset = "0x24EC810", Length = "0x8")]
	[Token(Token = "0x60001C1")]
	public TextUtf8RawTextWriter(Stream stream, XmlWriterSettings settings) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60001CC")]
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001C8")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x24ED3D0", Offset = "0x24EC7D0", Length = "0x8")]
	[Token(Token = "0x60001CD")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001D1")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x24ED3E0", Offset = "0x24EC7E0", Length = "0x15")]
	[Token(Token = "0x60001D5")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001CE")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001C4")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x24ED320", Offset = "0x24EC720", Length = "0x5")]
	[Token(Token = "0x60001CA")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001C6")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001D0")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001C7")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001CB")]
	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001CF")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x24ED400", Offset = "0x24EC800", Length = "0xF")]
	[Token(Token = "0x60001D7")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x24ED3E0", Offset = "0x24EC7E0", Length = "0x15")]
	[Token(Token = "0x60001D6")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x24ED3A0", Offset = "0x24EC7A0", Length = "0x5")]
	[Token(Token = "0x60001C9")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001C5")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24ED400", Offset = "0x24EC800", Length = "0xF")]
	[Token(Token = "0x60001D4")]
	public virtual void WriteString(string textBlock) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001D2")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x24ED400", Offset = "0x24EC800", Length = "0xF")]
	[Token(Token = "0x60001D3")]
	public virtual void WriteWhitespace(string ws) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001C2")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001C3")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

}

