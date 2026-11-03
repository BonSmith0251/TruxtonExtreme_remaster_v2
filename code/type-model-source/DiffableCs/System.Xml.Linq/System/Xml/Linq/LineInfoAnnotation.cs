namespace System.Xml.Linq;

[Token(Token = "0x2000004")]
internal class LineInfoAnnotation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000002")]
	internal int lineNumber; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000003")]
	internal int linePosition; //Field offset: 0x14

	[Address(RVA = "0x21893E0", Offset = "0x21887E0", Length = "0x34")]
	[Token(Token = "0x6000004")]
	public LineInfoAnnotation(int lineNumber, int linePosition) { }

}

