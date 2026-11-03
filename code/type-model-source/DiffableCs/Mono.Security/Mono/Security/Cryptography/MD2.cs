namespace Mono.Security.Cryptography;

[Token(Token = "0x2000049")]
public abstract class MD2 : HashAlgorithm
{

	[Address(RVA = "0x1E4F5F0", Offset = "0x1E4E9F0", Length = "0x1D")]
	[Token(Token = "0x6000182")]
	protected MD2() { }

	[Address(RVA = "0x1E4F4E0", Offset = "0x1E4E8E0", Length = "0x101")]
	[Token(Token = "0x6000183")]
	public static MD2 Create() { }

}

