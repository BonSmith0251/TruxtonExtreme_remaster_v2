namespace System;

[Token(Token = "0x20000E3")]
internal struct DateTimeToken
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000357")]
	internal DTT dtt; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000358")]
	internal TokenType suffix; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000359")]
	internal int num; //Field offset: 0x8

}

