namespace System.Xml.Linq;

[Token(Token = "0x2000016")]
internal struct ElementWriter
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400002E")]
	private XmlWriter _writer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400002F")]
	private NamespaceResolver _resolver; //Field offset: 0x8

	[Address(RVA = "0x2406240", Offset = "0x2405640", Length = "0x24")]
	[Token(Token = "0x6000090")]
	public ElementWriter(XmlWriter writer) { }

	[Address(RVA = "0x2405810", Offset = "0x2404C10", Length = "0xDD")]
	[Token(Token = "0x6000092")]
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	[Address(RVA = "0x24058F0", Offset = "0x2404CF0", Length = "0x21C")]
	[Token(Token = "0x6000093")]
	private void PushAncestors(XElement e) { }

	[Address(RVA = "0x2405B10", Offset = "0x2404F10", Length = "0x19A")]
	[Token(Token = "0x6000094")]
	private void PushElement(XElement e) { }

	[Address(RVA = "0x2405CB0", Offset = "0x24050B0", Length = "0x1F4")]
	[Token(Token = "0x6000091")]
	public void WriteElement(XElement e) { }

	[Address(RVA = "0x2405EB0", Offset = "0x24052B0", Length = "0x39")]
	[Token(Token = "0x6000095")]
	private void WriteEndElement() { }

	[Address(RVA = "0x2405EF0", Offset = "0x24052F0", Length = "0x39")]
	[Token(Token = "0x6000096")]
	private void WriteFullEndElement() { }

	[Address(RVA = "0x2405F30", Offset = "0x2405330", Length = "0x30C")]
	[Token(Token = "0x6000097")]
	private void WriteStartElement(XElement e) { }

}

