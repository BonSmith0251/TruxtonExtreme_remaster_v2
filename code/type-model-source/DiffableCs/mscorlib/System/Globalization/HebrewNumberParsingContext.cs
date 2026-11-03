namespace System.Globalization;

[Token(Token = "0x200054C")]
internal struct HebrewNumberParsingContext
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40015AB")]
	internal HS state; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40015AC")]
	internal int result; //Field offset: 0x4

	[Address(RVA = "0x1F77320", Offset = "0x1F76720", Length = "0x7")]
	[Token(Token = "0x60026C0")]
	public HebrewNumberParsingContext(int result) { }

}

