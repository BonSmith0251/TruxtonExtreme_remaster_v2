namespace System;

[Token(Token = "0x2000142")]
public static class Tuple
{

	[Address(RVA = "0xD0D290", Offset = "0xD0C690", Length = "0x6")]
	[Token(Token = "0x6000A7A")]
	internal static int CombineHashCodes(int h1, int h2) { }

	[Address(RVA = "0x204EBE0", Offset = "0x204DFE0", Length = "0xC")]
	[Token(Token = "0x6000A7B")]
	internal static int CombineHashCodes(int h1, int h2, int h3) { }

	[Address(RVA = "0x204EBC0", Offset = "0x204DFC0", Length = "0x12")]
	[Token(Token = "0x6000A7C")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4) { }

	[Address(RVA = "0x946B10", Offset = "0x945F10", Length = "0x7E")]
	[Token(Token = "0x6000A78")]
	public static Tuple<T1, T2> Create(T1 item1, T2 item2) { }

	[Address(RVA = "0x9469D0", Offset = "0x945DD0", Length = "0xA0")]
	[Token(Token = "0x6000A79")]
	public static Tuple<T1, T2, T3> Create(T1 item1, T2 item2, T3 item3) { }

}

