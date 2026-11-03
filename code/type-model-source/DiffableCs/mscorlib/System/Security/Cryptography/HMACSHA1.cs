namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000300")]
public class HMACSHA1 : HMAC
{

	[Address(RVA = "0x1EB8FA0", Offset = "0x1EB83A0", Length = "0xEB")]
	[Token(Token = "0x6001891")]
	public HMACSHA1() { }

	[Address(RVA = "0x1EB8EC0", Offset = "0x1EB82C0", Length = "0xDF")]
	[Token(Token = "0x6001892")]
	public HMACSHA1(Byte[] key) { }

	[Address(RVA = "0x1EB8EC0", Offset = "0x1EB82C0", Length = "0xDF")]
	[Token(Token = "0x6001893")]
	public HMACSHA1(Byte[] key, bool useManagedSha1) { }

}

