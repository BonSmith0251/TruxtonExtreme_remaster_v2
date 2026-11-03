namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000126")]
public enum X509RevocationMode : int
{
	NoCheck = 0,
	Online = 1,
	Offline = 2,
}

