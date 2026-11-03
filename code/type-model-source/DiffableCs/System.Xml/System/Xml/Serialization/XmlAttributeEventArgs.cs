namespace System.Xml.Serialization;

[Token(Token = "0x20000F2")]
public class XmlAttributeEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005D1")]
	private object o; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005D2")]
	private XmlAttribute attr; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005D3")]
	private string qnames; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005D4")]
	private int lineNumber; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40005D5")]
	private int linePosition; //Field offset: 0x2C

	[Address(RVA = "0x254FF20", Offset = "0x254F320", Length = "0xAA")]
	[Token(Token = "0x6000BE9")]
	internal XmlAttributeEventArgs(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }

}

