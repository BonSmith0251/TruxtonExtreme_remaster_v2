namespace Mono.Security.Cryptography;

[Token(Token = "0x200005F")]
internal sealed class KeyBuilder
{
	[Token(Token = "0x40001BA")]
	private static RandomNumberGenerator rng; //Field offset: 0x0

	[Token(Token = "0x17000019")]
	private static RandomNumberGenerator Rng
	{
		[Address(RVA = "0x1E5E390", Offset = "0x1E5D790", Length = "0x78")]
		[Token(Token = "0x6000121")]
		private get { } //Length: 120
	}

	[Address(RVA = "0x1E5E390", Offset = "0x1E5D790", Length = "0x78")]
	[Token(Token = "0x6000121")]
	private static RandomNumberGenerator get_Rng() { }

	[Address(RVA = "0x1E5E2B0", Offset = "0x1E5D6B0", Length = "0x69")]
	[Token(Token = "0x6000123")]
	public static Byte[] IV(int size) { }

	[Address(RVA = "0x1E5E320", Offset = "0x1E5D720", Length = "0x69")]
	[Token(Token = "0x6000122")]
	public static Byte[] Key(int size) { }

}

