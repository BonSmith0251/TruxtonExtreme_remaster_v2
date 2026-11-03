namespace System.Xml;

[Token(Token = "0x20000B7")]
internal struct LineInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004B6")]
	internal int lineNo; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40004B7")]
	internal int linePos; //Field offset: 0x4

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x60009F1")]
	public LineInfo(int lineNo, int linePos) { }

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x60009F2")]
	public void Set(int lineNo, int linePos) { }

}

