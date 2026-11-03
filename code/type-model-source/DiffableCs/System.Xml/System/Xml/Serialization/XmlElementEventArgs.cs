namespace System.Xml.Serialization;

[Token(Token = "0x20000F4")]
public class XmlElementEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005D6")]
	private object o; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005D7")]
	private XmlElement elem; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005D8")]
	private string qnames; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005D9")]
	private int lineNumber; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40005DA")]
	private int linePosition; //Field offset: 0x2C

	[Address(RVA = "0x2559910", Offset = "0x2558D10", Length = "0xAA")]
	[Token(Token = "0x6000BEC")]
	internal XmlElementEventArgs(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }

}

