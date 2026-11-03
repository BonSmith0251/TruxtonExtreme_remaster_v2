namespace Unity.Burst.CompilerServices;

[Token(Token = "0x2000056")]
public static class Aliasing
{

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E42")]
	public static void ExpectAliased(Void* a, Void* b) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E43")]
	public static void ExpectAliased(in A a, in B b) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E44")]
	public static void ExpectAliased(Void* a, in B b) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E45")]
	public static void ExpectAliased(in A a, Void* b) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E46")]
	public static void ExpectNotAliased(Void* a, Void* b) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E47")]
	public static void ExpectNotAliased(in A a, in B b) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E48")]
	public static void ExpectNotAliased(Void* a, in B b) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E49")]
	public static void ExpectNotAliased(in A a, Void* b) { }

}

