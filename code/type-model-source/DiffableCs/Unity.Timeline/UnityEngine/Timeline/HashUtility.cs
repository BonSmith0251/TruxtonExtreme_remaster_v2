namespace UnityEngine.Timeline;

[Extension]
[Token(Token = "0x2000076")]
internal static class HashUtility
{

	[Address(RVA = "0x2F411C0", Offset = "0x2F405C0", Length = "0x1B")]
	[Extension]
	[Token(Token = "0x600034D")]
	public static int CombineHash(int h1, int h2) { }

	[Address(RVA = "0x2F41180", Offset = "0x2F40580", Length = "0x31")]
	[Token(Token = "0x600034E")]
	public static int CombineHash(int h1, int h2, int h3) { }

	[Address(RVA = "0x2F40FB0", Offset = "0x2F403B0", Length = "0x4D")]
	[Token(Token = "0x600034F")]
	public static int CombineHash(int h1, int h2, int h3, int h4) { }

	[Address(RVA = "0x2F41080", Offset = "0x2F40480", Length = "0x6B")]
	[Token(Token = "0x6000350")]
	public static int CombineHash(int h1, int h2, int h3, int h4, int h5) { }

	[Address(RVA = "0x2F410F0", Offset = "0x2F404F0", Length = "0x89")]
	[Token(Token = "0x6000351")]
	public static int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6) { }

	[Address(RVA = "0x2F40F00", Offset = "0x2F40300", Length = "0xA7")]
	[Token(Token = "0x6000352")]
	public static int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6, int h7) { }

	[Address(RVA = "0x2F41000", Offset = "0x2F40400", Length = "0x72")]
	[Token(Token = "0x6000353")]
	public static int CombineHash(Int32[] hashes) { }

}

