namespace System.Xml;

[Token(Token = "0x2000009")]
internal class XmlRawWriterBase64Encoder : Base64Encoder
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000A")]
	private XmlRawWriter rawWriter; //Field offset: 0x28

	[Address(RVA = "0x23F7770", Offset = "0x23F6B70", Length = "0x71")]
	[Token(Token = "0x600000B")]
	internal XmlRawWriterBase64Encoder(XmlRawWriter rawWriter) { }

	[Address(RVA = "0x23F7740", Offset = "0x23F6B40", Length = "0x2F")]
	[Token(Token = "0x600000C")]
	internal virtual void WriteChars(Char[] chars, int index, int count) { }

}

