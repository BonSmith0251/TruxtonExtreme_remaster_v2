namespace System.Xml;

[Token(Token = "0x20000B4")]
internal class PositionInfo : IXmlLineInfo
{

	[Token(Token = "0x170002B9")]
	public override int LineNumber
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60009E6")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170002BA")]
	public override int LinePosition
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60009E7")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60009E9")]
	public PositionInfo() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60009E6")]
	public override int get_LineNumber() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60009E7")]
	public override int get_LinePosition() { }

	[Address(RVA = "0x2536AE0", Offset = "0x2535EE0", Length = "0xB6")]
	[Token(Token = "0x60009E8")]
	public static PositionInfo GetPositionInfo(object o) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60009E5")]
	public override bool HasLineInfo() { }

}

