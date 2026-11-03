namespace Mono.Security.Cryptography;

[Token(Token = "0x200004D")]
public sealed class PKCS1
{
	[Token(Token = "0x4000218")]
	private static Byte[] emptySHA1; //Field offset: 0x0
	[Token(Token = "0x4000219")]
	private static Byte[] emptySHA256; //Field offset: 0x8
	[Token(Token = "0x400021A")]
	private static Byte[] emptySHA384; //Field offset: 0x10
	[Token(Token = "0x400021B")]
	private static Byte[] emptySHA512; //Field offset: 0x18

	[Address(RVA = "0x1E536E0", Offset = "0x1E52AE0", Length = "0x1A6")]
	[Token(Token = "0x60001A5")]
	private static PKCS1() { }

	[Address(RVA = "0x1E52480", Offset = "0x1E51880", Length = "0x8F")]
	[Token(Token = "0x600019C")]
	private static bool Compare(Byte[] array1, Byte[] array2) { }

	[Address(RVA = "0x1E52510", Offset = "0x1E51910", Length = "0x555")]
	[Token(Token = "0x60001A4")]
	internal static HashAlgorithm CreateFromName(string name) { }

	[Address(RVA = "0x1E52A70", Offset = "0x1E51E70", Length = "0x56")]
	[Token(Token = "0x60001A3")]
	internal static HashAlgorithm CreateFromOid(string oid) { }

	[Address(RVA = "0x1E52AD0", Offset = "0x1E51ED0", Length = "0x348")]
	[Token(Token = "0x60001A1")]
	public static Byte[] Encode_v15(HashAlgorithm hash, Byte[] hashValue, int emLength) { }

	[Address(RVA = "0x1E52E20", Offset = "0x1E52220", Length = "0x3CC")]
	[Token(Token = "0x60001A2")]
	internal static string HashNameFromOid(string oid, bool throwOnError = true) { }

	[Address(RVA = "0x1E531F0", Offset = "0x1E525F0", Length = "0x7D")]
	[Token(Token = "0x600019D")]
	public static Byte[] I2OSP(Byte[] x, int size) { }

	[Address(RVA = "0x1E53270", Offset = "0x1E52670", Length = "0xC2")]
	[Token(Token = "0x600019E")]
	public static Byte[] OS2IP(Byte[] x) { }

	[Address(RVA = "0x1E53340", Offset = "0x1E52740", Length = "0x26")]
	[Token(Token = "0x600019F")]
	public static Byte[] RSAVP1(RSA rsa, Byte[] s) { }

	[Address(RVA = "0x1E53370", Offset = "0x1E52770", Length = "0x36A")]
	[Token(Token = "0x60001A0")]
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, Byte[] hashValue, Byte[] signature, bool tryNonStandardEncoding) { }

}

