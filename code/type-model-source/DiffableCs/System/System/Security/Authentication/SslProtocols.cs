namespace System.Security.Authentication;

[Flags]
[Token(Token = "0x2000113")]
public enum SslProtocols : int
{
	None = 0,
	Ssl2 = 12,
	Ssl3 = 48,
	Tls = 192,
	Tls11 = 768,
	Tls12 = 3072,
	Tls13 = 12288,
	Default = 240,
}

