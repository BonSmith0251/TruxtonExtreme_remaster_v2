namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000334")]
public enum X509ContentType : int
{
	Unknown = 0,
	Cert = 1,
	SerializedCert = 2,
	Pfx = 3,
	Pkcs12 = 3,
	SerializedStore = 4,
	Pkcs7 = 5,
	Authenticode = 6,
}

