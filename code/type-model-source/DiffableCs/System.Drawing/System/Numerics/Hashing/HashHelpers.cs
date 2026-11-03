namespace System.Numerics.Hashing;

[Token(Token = "0x2000002")]
internal static class HashHelpers
{
	[Token(Token = "0x4000001")]
	public static readonly int RandomSeed; //Field offset: 0x0

	[Address(RVA = "0x23DABA0", Offset = "0x23D9FA0", Length = "0x5D")]
	[Token(Token = "0x6000002")]
	private static HashHelpers() { }

	[Address(RVA = "0x1F5EA30", Offset = "0x1F5DE30", Length = "0x14")]
	[Token(Token = "0x6000001")]
	public static int Combine(int h1, int h2) { }

}

