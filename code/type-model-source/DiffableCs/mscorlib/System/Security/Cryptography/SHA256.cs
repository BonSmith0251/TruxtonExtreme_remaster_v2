namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000317")]
public abstract class SHA256 : HashAlgorithm
{

	[Address(RVA = "0x1ED1200", Offset = "0x1ED0600", Length = "0x1D")]
	[Token(Token = "0x6001919")]
	protected SHA256() { }

	[Address(RVA = "0x1ED11B0", Offset = "0x1ED05B0", Length = "0x44")]
	[Token(Token = "0x600191A")]
	public static SHA256 Create() { }

}

