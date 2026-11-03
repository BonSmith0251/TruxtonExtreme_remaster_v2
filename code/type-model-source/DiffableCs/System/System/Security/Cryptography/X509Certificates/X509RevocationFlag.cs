namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000125")]
public enum X509RevocationFlag : int
{
	EndCertificateOnly = 0,
	EntireChain = 1,
	ExcludeRoot = 2,
}

