namespace Unity.Burst.Intrinsics;

[Token(Token = "0x2000034")]
public static class Common
{

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A5B")]
	public static void Pause() { }

	[Address(RVA = "0x27F1C10", Offset = "0x27F1010", Length = "0x56")]
	[Token(Token = "0x6000A5C")]
	public static ulong umul128(ulong x, ulong y, out ulong high) { }

}

