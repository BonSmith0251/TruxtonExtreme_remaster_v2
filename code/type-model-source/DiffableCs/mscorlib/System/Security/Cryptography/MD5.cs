namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000308")]
public abstract class MD5 : HashAlgorithm
{

	[Address(RVA = "0x1EBB310", Offset = "0x1EBA710", Length = "0x1D")]
	[Token(Token = "0x60018B8")]
	protected MD5() { }

	[Address(RVA = "0x1EBB2C0", Offset = "0x1EBA6C0", Length = "0x44")]
	[Token(Token = "0x60018B9")]
	public static MD5 Create() { }

}

