namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002FE")]
public class HMACMD5 : HMAC
{

	[Address(RVA = "0x1EB8C00", Offset = "0x1EB8000", Length = "0xEB")]
	[Token(Token = "0x600188D")]
	public HMACMD5() { }

	[Address(RVA = "0x1EB8B20", Offset = "0x1EB7F20", Length = "0xDF")]
	[Token(Token = "0x600188E")]
	public HMACMD5(Byte[] key) { }

}

