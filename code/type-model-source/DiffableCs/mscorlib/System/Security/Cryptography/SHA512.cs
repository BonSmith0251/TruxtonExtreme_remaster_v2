namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200031B")]
public abstract class SHA512 : HashAlgorithm
{

	[Address(RVA = "0x1ED4420", Offset = "0x1ED3820", Length = "0x1D")]
	[Token(Token = "0x600193F")]
	protected SHA512() { }

	[Address(RVA = "0x1ED43D0", Offset = "0x1ED37D0", Length = "0x44")]
	[Token(Token = "0x6001940")]
	public static SHA512 Create() { }

}

