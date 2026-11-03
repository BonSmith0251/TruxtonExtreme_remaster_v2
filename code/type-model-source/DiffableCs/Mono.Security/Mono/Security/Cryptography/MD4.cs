namespace Mono.Security.Cryptography;

[Token(Token = "0x200004B")]
public abstract class MD4 : HashAlgorithm
{

	[Address(RVA = "0x1E4F5F0", Offset = "0x1E4E9F0", Length = "0x1D")]
	[Token(Token = "0x600018B")]
	protected MD4() { }

	[Address(RVA = "0x1E509C0", Offset = "0x1E4FDC0", Length = "0x12E")]
	[Token(Token = "0x600018C")]
	public static MD4 Create() { }

}

