namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200030C")]
public abstract class Rijndael : SymmetricAlgorithm
{
	[Token(Token = "0x4000CF8")]
	private static KeySizes[] s_legalBlockSizes; //Field offset: 0x0
	[Token(Token = "0x4000CF9")]
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x8

	[Address(RVA = "0x1EC3D40", Offset = "0x1EC3140", Length = "0x168")]
	[Token(Token = "0x60018CC")]
	private static Rijndael() { }

	[Address(RVA = "0x1EC3EB0", Offset = "0x1EC32B0", Length = "0x9E")]
	[Token(Token = "0x60018CB")]
	protected Rijndael() { }

}

