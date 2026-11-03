namespace Mono.Xml;

[Token(Token = "0x200004B")]
internal class SmallXmlParserException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400014A")]
	private int line; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x400014B")]
	private int column; //Field offset: 0x94

	[Address(RVA = "0x1E6AFE0", Offset = "0x1E6A3E0", Length = "0xB2")]
	[Token(Token = "0x60000AB")]
	public SmallXmlParserException(string msg, int line, int column) { }

}

