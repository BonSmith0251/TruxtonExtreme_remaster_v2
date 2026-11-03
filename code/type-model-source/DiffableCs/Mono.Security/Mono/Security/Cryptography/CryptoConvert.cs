namespace Mono.Security.Cryptography;

[Token(Token = "0x2000048")]
public sealed class CryptoConvert
{

	[Address(RVA = "0x1E4BE10", Offset = "0x1E4B210", Length = "0x267")]
	[Token(Token = "0x6000181")]
	public static Byte[] FromHex(string hex) { }

	[Address(RVA = "0x1E4BD80", Offset = "0x1E4B180", Length = "0x89")]
	[Token(Token = "0x6000180")]
	private static byte FromHexChar(char c) { }

	[Address(RVA = "0x1E4C080", Offset = "0x1E4B480", Length = "0x126")]
	[Token(Token = "0x600017F")]
	public static string ToHex(Byte[] input) { }

}

