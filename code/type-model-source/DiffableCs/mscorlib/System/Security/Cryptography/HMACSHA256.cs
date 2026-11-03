namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000301")]
public class HMACSHA256 : HMAC
{

	[Address(RVA = "0x1EB9090", Offset = "0x1EB8490", Length = "0xEB")]
	[Token(Token = "0x6001894")]
	public HMACSHA256() { }

	[Address(RVA = "0x1EB9180", Offset = "0x1EB8580", Length = "0xDF")]
	[Token(Token = "0x6001895")]
	public HMACSHA256(Byte[] key) { }

}

