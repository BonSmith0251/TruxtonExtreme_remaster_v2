namespace System.Xml;

[Token(Token = "0x200000A")]
internal class XmlTextWriterBase64Encoder : Base64Encoder
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000B")]
	private XmlTextEncoder xmlTextEncoder; //Field offset: 0x28

	[Address(RVA = "0x23F7770", Offset = "0x23F6B70", Length = "0x71")]
	[Token(Token = "0x600000D")]
	internal XmlTextWriterBase64Encoder(XmlTextEncoder xmlTextEncoder) { }

	[Address(RVA = "0x2403D80", Offset = "0x2403180", Length = "0x24")]
	[Token(Token = "0x600000E")]
	internal virtual void WriteChars(Char[] chars, int index, int count) { }

}

