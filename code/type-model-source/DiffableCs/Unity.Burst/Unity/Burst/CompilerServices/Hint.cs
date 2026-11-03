namespace Unity.Burst.CompilerServices;

[Token(Token = "0x2000059")]
public static class Hint
{

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000E50")]
	public static void Assume(bool condition) { }

	[Address(RVA = "0x732D80", Offset = "0x732180", Length = "0x4")]
	[Token(Token = "0x6000E4E")]
	public static bool Likely(bool condition) { }

	[Address(RVA = "0x732D80", Offset = "0x732180", Length = "0x4")]
	[Token(Token = "0x6000E4F")]
	public static bool Unlikely(bool condition) { }

}

