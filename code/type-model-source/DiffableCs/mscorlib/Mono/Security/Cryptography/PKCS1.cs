namespace Mono.Security.Cryptography;

[Token(Token = "0x2000065")]
internal sealed class PKCS1
{
	[Token(Token = "0x40001CF")]
	private static Byte[] emptySHA1; //Field offset: 0x0
	[Token(Token = "0x40001D0")]
	private static Byte[] emptySHA256; //Field offset: 0x8
	[Token(Token = "0x40001D1")]
	private static Byte[] emptySHA384; //Field offset: 0x10
	[Token(Token = "0x40001D2")]
	private static Byte[] emptySHA512; //Field offset: 0x18

	[Address(RVA = "0x1E76DC0", Offset = "0x1E761C0", Length = "0x1A6")]
	[Token(Token = "0x6000163")]
	private static PKCS1() { }

	[Address(RVA = "0x1E52480", Offset = "0x1E51880", Length = "0x8F")]
	[Token(Token = "0x600015A")]
	private static bool Compare(Byte[] array1, Byte[] array2) { }

	[Address(RVA = "0x1E75F30", Offset = "0x1E75330", Length = "0x4B4")]
	[Token(Token = "0x6000162")]
	internal static HashAlgorithm CreateFromName(string name) { }

	[Address(RVA = "0x1E763F0", Offset = "0x1E757F0", Length = "0x348")]
	[Token(Token = "0x6000161")]
	public static Byte[] Encode_v15(HashAlgorithm hash, Byte[] hashValue, int emLength) { }

	[Address(RVA = "0x1E76740", Offset = "0x1E75B40", Length = "0x7D")]
	[Token(Token = "0x600015B")]
	public static Byte[] I2OSP(Byte[] x, int size) { }

	[Address(RVA = "0x1E767C0", Offset = "0x1E75BC0", Length = "0xC2")]
	[Token(Token = "0x600015C")]
	public static Byte[] OS2IP(Byte[] x) { }

	[Address(RVA = "0x1E53340", Offset = "0x1E52740", Length = "0x26")]
	[Token(Token = "0x600015D")]
	public static Byte[] RSAVP1(RSA rsa, Byte[] s) { }

	[Address(RVA = "0x1E76D30", Offset = "0x1E76130", Length = "0x85")]
	[Token(Token = "0x600015E")]
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, Byte[] hashValue, Byte[] signature) { }

	[Address(RVA = "0x1E76C00", Offset = "0x1E76000", Length = "0x120")]
	[Token(Token = "0x600015F")]
	internal static bool Verify_v15(RSA rsa, string hashName, Byte[] hashValue, Byte[] signature) { }

	[Address(RVA = "0x1E76890", Offset = "0x1E75C90", Length = "0x36A")]
	[Token(Token = "0x6000160")]
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, Byte[] hashValue, Byte[] signature, bool tryNonStandardEncoding) { }

}

