namespace Mono.Security.Cryptography;

[Token(Token = "0x2000063")]
internal abstract class MD4 : HashAlgorithm
{

	[Address(RVA = "0x1E4F5F0", Offset = "0x1E4E9F0", Length = "0x1D")]
	[Token(Token = "0x6000149")]
	protected MD4() { }

	[Address(RVA = "0x1E60DB0", Offset = "0x1E601B0", Length = "0x12E")]
	[Token(Token = "0x600014A")]
	public static MD4 Create() { }

}

