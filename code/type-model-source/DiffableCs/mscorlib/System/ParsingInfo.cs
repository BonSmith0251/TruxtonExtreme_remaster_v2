namespace System;

[Token(Token = "0x20000E8")]
internal struct ParsingInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400038E")]
	internal Calendar calendar; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400038F")]
	internal int dayOfWeek; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000390")]
	internal TM timeMark; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000391")]
	internal bool fUseHour12; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000392")]
	internal bool fUseTwoDigitYear; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4000393")]
	internal bool fAllowInnerWhite; //Field offset: 0x12
	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x4000394")]
	internal bool fAllowTrailingWhite; //Field offset: 0x13
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000395")]
	internal bool fCustomNumberParser; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000396")]
	internal MatchNumberDelegate parseNumberDelegate; //Field offset: 0x18

	[Address(RVA = "0x203A8B0", Offset = "0x2039CB0", Length = "0x9")]
	[Token(Token = "0x6000750")]
	internal void Init() { }

}

