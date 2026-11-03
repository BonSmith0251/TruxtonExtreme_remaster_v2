namespace System.Xml;

[Token(Token = "0x2000050")]
internal abstract class XmlRawWriter : XmlWriter
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001B1")]
	protected XmlRawWriterBase64Encoder base64Encoder; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001B2")]
	protected IXmlNamespaceResolver resolver; //Field offset: 0x20

	[Token(Token = "0x1700008B")]
	internal override IXmlNamespaceResolver NamespaceResolver
	{
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000321")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700008C")]
	internal override bool SupportsNamespaceDeclarationInChunks
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000329")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700008A")]
	public virtual WriteState WriteState
	{
		[Address(RVA = "0x24F81B0", Offset = "0x24F75B0", Length = "0x5F")]
		[Token(Token = "0x6000316")]
		 get { } //Length: 95
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600032E")]
	protected XmlRawWriter() { }

	[Address(RVA = "0x24F7BD0", Offset = "0x24F6FD0", Length = "0x14")]
	[Token(Token = "0x600032D")]
	internal override void Close(WriteState currentState) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000329")]
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	[Address(RVA = "0x24F81B0", Offset = "0x24F75B0", Length = "0x5F")]
	[Token(Token = "0x6000316")]
	public virtual WriteState get_WriteState() { }

	[Address(RVA = "0x24F7BF0", Offset = "0x24F6FF0", Length = "0x5F")]
	[Token(Token = "0x6000315")]
	public virtual string LookupPrefix(string ns) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000325")]
	internal override void OnRootElement(ConformanceLevel conformanceLevel) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000321")]
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	[Token(Token = "0x6000324")]
	internal abstract void StartElementContent() { }

	[Address(RVA = "0x24F7C50", Offset = "0x24F7050", Length = "0x5F")]
	[Token(Token = "0x600031F")]
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	[Address(RVA = "0x24F7CB0", Offset = "0x24F70B0", Length = "0xB5")]
	[Token(Token = "0x6000314")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x22F7FC0", Offset = "0x22F73C0", Length = "0x14")]
	[Token(Token = "0x6000317")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x24F7D70", Offset = "0x24F7170", Length = "0x88")]
	[Token(Token = "0x6000318")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x24F0380", Offset = "0x24EF780", Length = "0x38")]
	[Token(Token = "0x600031B")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000311")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x24F7E00", Offset = "0x24F7200", Length = "0x1D")]
	[Token(Token = "0x600032C")]
	internal override void WriteEndBase64() { }

	[Address(RVA = "0x24F7E20", Offset = "0x24F7220", Length = "0x5F")]
	[Token(Token = "0x6000310")]
	public virtual void WriteEndDocument() { }

	[Address(RVA = "0x24F7E80", Offset = "0x24F7280", Length = "0x5F")]
	[Token(Token = "0x6000312")]
	public virtual void WriteEndElement() { }

	[Token(Token = "0x6000326")]
	internal abstract void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x24F7EE0", Offset = "0x24F72E0", Length = "0x3E")]
	[Token(Token = "0x600032B")]
	internal override void WriteEndNamespaceDeclaration() { }

	[Address(RVA = "0x24F7F20", Offset = "0x24F7320", Length = "0x5F")]
	[Token(Token = "0x6000313")]
	public virtual void WriteFullEndElement() { }

	[Address(RVA = "0x24F7F80", Offset = "0x24F7380", Length = "0x19")]
	[Token(Token = "0x6000327")]
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Token(Token = "0x6000328")]
	internal abstract void WriteNamespaceDeclaration(string prefix, string ns) { }

	[Address(RVA = "0x24F7FA0", Offset = "0x24F73A0", Length = "0x5F")]
	[Token(Token = "0x6000320")]
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	[Address(RVA = "0x24F0380", Offset = "0x24EF780", Length = "0x38")]
	[Token(Token = "0x600031C")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x22F7FC0", Offset = "0x22F73C0", Length = "0x14")]
	[Token(Token = "0x600031D")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x24F8000", Offset = "0x24F7400", Length = "0x5F")]
	[Token(Token = "0x600030E")]
	public virtual void WriteStartDocument() { }

	[Address(RVA = "0x24F8060", Offset = "0x24F7460", Length = "0x5F")]
	[Token(Token = "0x600030F")]
	public virtual void WriteStartDocument(bool standalone) { }

	[Address(RVA = "0x24F80C0", Offset = "0x24F74C0", Length = "0x3E")]
	[Token(Token = "0x600032A")]
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	[Address(RVA = "0x24F8100", Offset = "0x24F7500", Length = "0xA0")]
	[Token(Token = "0x6000319")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x22F7FC0", Offset = "0x22F73C0", Length = "0x14")]
	[Token(Token = "0x600031E")]
	public virtual void WriteValue(string value) { }

	[Address(RVA = "0x22F7FC0", Offset = "0x22F73C0", Length = "0x14")]
	[Token(Token = "0x600031A")]
	public virtual void WriteWhitespace(string ws) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000322")]
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000323")]
	internal override void WriteXmlDeclaration(string xmldecl) { }

}

