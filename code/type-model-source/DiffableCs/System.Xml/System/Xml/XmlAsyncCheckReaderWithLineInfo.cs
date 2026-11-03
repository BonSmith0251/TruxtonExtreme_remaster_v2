namespace System.Xml;

[Token(Token = "0x2000045")]
internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000150")]
	private readonly IXmlLineInfo readerAsIXmlLineInfo; //Field offset: 0x20

	[Token(Token = "0x1700006D")]
	public override int LineNumber
	{
		[Address(RVA = "0x24EDEE0", Offset = "0x24ED2E0", Length = "0x49")]
		[Token(Token = "0x600022C")]
		 get { } //Length: 73
	}

	[Token(Token = "0x1700006E")]
	public override int LinePosition
	{
		[Address(RVA = "0x24EDF30", Offset = "0x24ED330", Length = "0x49")]
		[Token(Token = "0x600022D")]
		 get { } //Length: 73
	}

	[Address(RVA = "0x24EDE30", Offset = "0x24ED230", Length = "0xAD")]
	[Token(Token = "0x600022A")]
	public XmlAsyncCheckReaderWithLineInfo(XmlReader reader) { }

	[Address(RVA = "0x24EDEE0", Offset = "0x24ED2E0", Length = "0x49")]
	[Token(Token = "0x600022C")]
	public override int get_LineNumber() { }

	[Address(RVA = "0x24EDF30", Offset = "0x24ED330", Length = "0x49")]
	[Token(Token = "0x600022D")]
	public override int get_LinePosition() { }

	[Address(RVA = "0x24EDDE0", Offset = "0x24ED1E0", Length = "0x46")]
	[Token(Token = "0x600022B")]
	public override bool HasLineInfo() { }

}

