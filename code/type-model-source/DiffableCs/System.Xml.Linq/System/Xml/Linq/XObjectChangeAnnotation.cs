namespace System.Xml.Linq;

[Token(Token = "0x2000020")]
internal class XObjectChangeAnnotation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000052")]
	internal EventHandler<XObjectChangeEventArgs> changing; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000053")]
	internal EventHandler<XObjectChangeEventArgs> changed; //Field offset: 0x18

}

