namespace System;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20000E2")]
internal struct DTSubString
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000352")]
	internal ReadOnlySpan<Char> s; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000353")]
	internal int index; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000354")]
	internal int length; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000355")]
	internal DTSubStringType type; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000356")]
	internal int value; //Field offset: 0x1C

	[Token(Token = "0x17000082")]
	internal char Item
	{
		[Address(RVA = "0x20218B0", Offset = "0x2020CB0", Length = "0x25")]
		[Token(Token = "0x6000744")]
		internal get { } //Length: 37
	}

	[Address(RVA = "0x20218B0", Offset = "0x2020CB0", Length = "0x25")]
	[Token(Token = "0x6000744")]
	internal char get_Item(int relativeIndex) { }

}

