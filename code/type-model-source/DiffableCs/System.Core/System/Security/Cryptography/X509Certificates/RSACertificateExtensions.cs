namespace System.Security.Cryptography.X509Certificates;

[Extension]
[Token(Token = "0x2000016")]
public static class RSACertificateExtensions
{

	[Address(RVA = "0x224EB30", Offset = "0x224DF30", Length = "0xE1")]
	[Extension]
	[Token(Token = "0x6000052")]
	public static RSA GetRSAPublicKey(X509Certificate2 certificate) { }

}

