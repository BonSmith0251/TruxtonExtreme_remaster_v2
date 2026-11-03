namespace System.Security.Cryptography;

[Token(Token = "0x20002EC")]
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public abstract class Aes : SymmetricAlgorithm
{
	[Token(Token = "0x4000CB1")]
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	[Token(Token = "0x4000CB2")]
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8

	[Address(RVA = "0x1EB5D40", Offset = "0x1EB5140", Length = "0x162")]
	[Token(Token = "0x6001843")]
	private static Aes() { }

	[Address(RVA = "0x1EB5EB0", Offset = "0x1EB52B0", Length = "0xA6")]
	[Token(Token = "0x6001840")]
	protected Aes() { }

	[Address(RVA = "0x1EB5C10", Offset = "0x1EB5010", Length = "0x12A")]
	[Token(Token = "0x6001841")]
	public static Aes Create() { }

	[Address(RVA = "0x1EB5B20", Offset = "0x1EB4F20", Length = "0xE9")]
	[Token(Token = "0x6001842")]
	public static Aes Create(string algorithmName) { }

}

