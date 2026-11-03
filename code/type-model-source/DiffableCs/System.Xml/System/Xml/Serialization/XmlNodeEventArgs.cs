namespace System.Xml.Serialization;

[Token(Token = "0x20000F6")]
public class XmlNodeEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005DB")]
	private object o; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005DC")]
	private XmlNode xmlNode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005DD")]
	private int lineNumber; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40005DE")]
	private int linePosition; //Field offset: 0x24

	[Address(RVA = "0x255BFE0", Offset = "0x255B3E0", Length = "0x98")]
	[Token(Token = "0x6000BEF")]
	internal XmlNodeEventArgs(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }

}

