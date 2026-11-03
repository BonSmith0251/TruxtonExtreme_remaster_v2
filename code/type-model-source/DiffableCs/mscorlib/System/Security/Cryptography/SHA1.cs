namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000315")]
public abstract class SHA1 : HashAlgorithm
{

	[Address(RVA = "0x1ECFB70", Offset = "0x1ECEF70", Length = "0x1D")]
	[Token(Token = "0x600190E")]
	protected SHA1() { }

	[Address(RVA = "0x1ECFB20", Offset = "0x1ECEF20", Length = "0x44")]
	[Token(Token = "0x600190F")]
	public static SHA1 Create() { }

}

