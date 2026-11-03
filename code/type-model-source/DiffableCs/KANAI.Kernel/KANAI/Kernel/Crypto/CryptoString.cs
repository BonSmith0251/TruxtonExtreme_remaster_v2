namespace KANAI.Kernel.Crypto;

[Token(Token = "0x2000047")]
public static class CryptoString
{
	[Token(Token = "0x400011F")]
	private const int IVLength = 16; //Field offset: 0x0
	[Token(Token = "0x4000120")]
	private const int PaddingSize = 16; //Field offset: 0x0
	[Token(Token = "0x4000121")]
	private static readonly Byte[] _enckey; //Field offset: 0x0
	[Token(Token = "0x4000122")]
	private static readonly BitArray _mask; //Field offset: 0x8

	[Address(RVA = "0x1DE7820", Offset = "0x1DE6C20", Length = "0x131")]
	[Token(Token = "0x600025A")]
	private static CryptoString() { }

	[Address(RVA = "0x1DE7150", Offset = "0x1DE6550", Length = "0x3B6")]
	[Token(Token = "0x6000258")]
	public static string DecryptString(string response, int mode = 2) { }

	[Address(RVA = "0x1DE7750", Offset = "0x1DE6B50", Length = "0xC0")]
	[Token(Token = "0x6000257")]
	public static string EncryptString(string jsonRaw, int mode = 2) { }

	[Address(RVA = "0x1DE7510", Offset = "0x1DE6910", Length = "0x238")]
	[Token(Token = "0x6000259")]
	private static Byte[] EncryptStringToBytes(string jsonRaw, int mode) { }

}

