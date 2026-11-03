namespace System.Net;

[Flags]
[Token(Token = "0x200023D")]
public enum SecurityProtocolType : int
{
	SystemDefault = 0,
	Ssl3 = 48,
	Tls = 192,
	Tls11 = 768,
	Tls12 = 3072,
	Tls13 = 12288,
}

