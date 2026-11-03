namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000319")]
public abstract class SHA384 : HashAlgorithm
{

	[Address(RVA = "0x1ED2B30", Offset = "0x1ED1F30", Length = "0x1D")]
	[Token(Token = "0x600192C")]
	protected SHA384() { }

	[Address(RVA = "0x1ED2AE0", Offset = "0x1ED1EE0", Length = "0x44")]
	[Token(Token = "0x600192D")]
	public static SHA384 Create() { }

}

