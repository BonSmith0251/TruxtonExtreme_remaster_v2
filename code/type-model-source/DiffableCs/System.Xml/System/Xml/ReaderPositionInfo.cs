namespace System.Xml;

[Token(Token = "0x20000B5")]
internal class ReaderPositionInfo : PositionInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004B5")]
	private IXmlLineInfo lineInfo; //Field offset: 0x10

	[Token(Token = "0x170002BB")]
	public virtual int LineNumber
	{
		[Address(RVA = "0x2536BF0", Offset = "0x2535FF0", Length = "0x49")]
		[Token(Token = "0x60009EC")]
		 get { } //Length: 73
	}

	[Token(Token = "0x170002BC")]
	public virtual int LinePosition
	{
		[Address(RVA = "0x2536C40", Offset = "0x2536040", Length = "0x49")]
		[Token(Token = "0x60009ED")]
		 get { } //Length: 73
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60009EA")]
	public ReaderPositionInfo(IXmlLineInfo lineInfo) { }

	[Address(RVA = "0x2536BF0", Offset = "0x2535FF0", Length = "0x49")]
	[Token(Token = "0x60009EC")]
	public virtual int get_LineNumber() { }

	[Address(RVA = "0x2536C40", Offset = "0x2536040", Length = "0x49")]
	[Token(Token = "0x60009ED")]
	public virtual int get_LinePosition() { }

	[Address(RVA = "0x2536BA0", Offset = "0x2535FA0", Length = "0x46")]
	[Token(Token = "0x60009EB")]
	public virtual bool HasLineInfo() { }

}

