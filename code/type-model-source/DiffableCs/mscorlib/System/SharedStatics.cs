namespace System;

[Token(Token = "0x2000196")]
internal sealed class SharedStatics
{
	[Token(Token = "0x40005F0")]
	private static readonly SharedStatics _sharedStatics; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005F1")]
	private StringMaker _maker; //Field offset: 0x10

	[Address(RVA = "0x2089540", Offset = "0x2088940", Length = "0x57")]
	[Token(Token = "0x6000EF6")]
	private static SharedStatics() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000EF3")]
	private SharedStatics() { }

	[Address(RVA = "0x20892B0", Offset = "0x20886B0", Length = "0x170")]
	[Token(Token = "0x6000EF4")]
	public static StringMaker GetSharedStringMaker() { }

	[Address(RVA = "0x2089430", Offset = "0x2088830", Length = "0x10A")]
	[Token(Token = "0x6000EF5")]
	public static void ReleaseSharedStringMaker(ref StringMaker maker) { }

}

