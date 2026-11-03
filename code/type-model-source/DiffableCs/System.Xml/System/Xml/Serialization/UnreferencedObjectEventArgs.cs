namespace System.Xml.Serialization;

[Token(Token = "0x20000F8")]
public class UnreferencedObjectEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005DF")]
	private object o; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005E0")]
	private string id; //Field offset: 0x18

	[Address(RVA = "0x254C470", Offset = "0x254B870", Length = "0x82")]
	[Token(Token = "0x6000BF2")]
	public UnreferencedObjectEventArgs(object o, string id) { }

}

