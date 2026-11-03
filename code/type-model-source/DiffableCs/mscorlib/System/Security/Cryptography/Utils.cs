namespace System.Security.Cryptography;

[Token(Token = "0x2000327")]
internal static class Utils
{
	[Token(Token = "0x4000D4B")]
	private static RNGCryptoServiceProvider _rng; //Field offset: 0x0

	[Token(Token = "0x17000295")]
	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator
	{
		[Address(RVA = "0x1ED6880", Offset = "0x1ED5C80", Length = "0x435")]
		[Token(Token = "0x6001984")]
		internal get { } //Length: 1077
	}

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6001992")]
	internal static bool _ProduceLegacyHmacValues() { }

	[Address(RVA = "0x1ED5E60", Offset = "0x1ED5260", Length = "0x4C")]
	[Token(Token = "0x6001989")]
	internal static int ConvertByteArrayToInt(Byte[] input) { }

	[Address(RVA = "0x1ED5EB0", Offset = "0x1ED52B0", Length = "0x114")]
	[Token(Token = "0x600198A")]
	internal static Byte[] ConvertIntToByteArray(int dwInput) { }

	[Address(RVA = "0x1ED6230", Offset = "0x1ED5630", Length = "0x16D")]
	[Token(Token = "0x6001987")]
	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	[Address(RVA = "0x1ED63A0", Offset = "0x1ED57A0", Length = "0x198")]
	[Token(Token = "0x6001988")]
	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	[Address(RVA = "0x1ED5FD0", Offset = "0x1ED53D0", Length = "0x41")]
	[Token(Token = "0x600198E")]
	internal static void DWORDFromBigEndian(UInt32* x, int digits, Byte* block) { }

	[Address(RVA = "0x1ED6020", Offset = "0x1ED5420", Length = "0x4F")]
	[Token(Token = "0x600198C")]
	internal static void DWORDFromLittleEndian(UInt32* x, int digits, Byte* block) { }

	[Address(RVA = "0x1ED6070", Offset = "0x1ED5470", Length = "0xD7")]
	[Token(Token = "0x600198F")]
	internal static void DWORDToBigEndian(Byte[] block, UInt32[] x, int digits) { }

	[Address(RVA = "0x1ED6150", Offset = "0x1ED5550", Length = "0xD7")]
	[Token(Token = "0x600198D")]
	internal static void DWORDToLittleEndian(Byte[] block, UInt32[] x, int digits) { }

	[Address(RVA = "0x1ED6540", Offset = "0x1ED5940", Length = "0xCB")]
	[Token(Token = "0x600198B")]
	internal static Byte[] FixupKeyParity(Byte[] key) { }

	[Address(RVA = "0x1ED6610", Offset = "0x1ED5A10", Length = "0x69")]
	[Token(Token = "0x6001985")]
	internal static Byte[] GenerateRandom(int keySize) { }

	[Address(RVA = "0x1ED6880", Offset = "0x1ED5C80", Length = "0x435")]
	[Token(Token = "0x6001984")]
	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6001986")]
	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	[Address(RVA = "0x1ED6680", Offset = "0x1ED5A80", Length = "0x82")]
	[Token(Token = "0x6001990")]
	internal static void QuadWordFromBigEndian(UInt64* x, int digits, Byte* block) { }

	[Address(RVA = "0x1ED6710", Offset = "0x1ED5B10", Length = "0x164")]
	[Token(Token = "0x6001991")]
	internal static void QuadWordToBigEndian(Byte[] block, UInt64[] x, int digits) { }

}

