namespace System.Numerics.Hashing;

[Token(Token = "0x200053C")]
internal static class HashHelpers
{
	[Token(Token = "0x40014ED")]
	public static readonly int RandomSeed; //Field offset: 0x0

	[Address(RVA = "0x1F5EA50", Offset = "0x1F5DE50", Length = "0x89")]
	[Token(Token = "0x60025EE")]
	private static HashHelpers() { }

	[Address(RVA = "0x1F5EA30", Offset = "0x1F5DE30", Length = "0x14")]
	[Token(Token = "0x60025ED")]
	public static int Combine(int h1, int h2) { }

}

