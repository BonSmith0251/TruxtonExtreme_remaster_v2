namespace Mono.Security.Cryptography;

[Token(Token = "0x2000061")]
internal abstract class MD2 : HashAlgorithm
{

	[Address(RVA = "0x1E4F5F0", Offset = "0x1E4E9F0", Length = "0x1D")]
	[Token(Token = "0x6000140")]
	protected MD2() { }

	[Address(RVA = "0x1E60870", Offset = "0x1E5FC70", Length = "0x101")]
	[Token(Token = "0x6000141")]
	public static MD2 Create() { }

}

