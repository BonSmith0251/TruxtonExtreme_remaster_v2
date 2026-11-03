namespace Internal.Cryptography;

[Extension]
[Token(Token = "0x200008C")]
internal static class Helpers
{

	[Address(RVA = "0x1E731F0", Offset = "0x1E725F0", Length = "0x78")]
	[Extension]
	[Token(Token = "0x6000241")]
	public static Byte[] CloneByteArray(Byte[] src) { }

	[Address(RVA = "0x1E73270", Offset = "0x1E72670", Length = "0x1A")]
	[Token(Token = "0x6000244")]
	private static char NibbleToHex(byte b) { }

	[Address(RVA = "0x1E73290", Offset = "0x1E72690", Length = "0xDA")]
	[Extension]
	[Token(Token = "0x6000242")]
	public static Char[] ToHexArrayUpper(Byte[] bytes) { }

	[Address(RVA = "0x1E73370", Offset = "0x1E72770", Length = "0x157")]
	[Extension]
	[Token(Token = "0x6000243")]
	public static string ToHexStringUpper(Byte[] bytes) { }

}

