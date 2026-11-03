namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000310")]
public abstract class RIPEMD160 : HashAlgorithm
{

	[Address(RVA = "0x1EBE250", Offset = "0x1EBD650", Length = "0x1D")]
	[Token(Token = "0x60018E7")]
	protected RIPEMD160() { }

	[Address(RVA = "0x1EBE200", Offset = "0x1EBD600", Length = "0x44")]
	[Token(Token = "0x60018E8")]
	public static RIPEMD160 Create() { }

}

