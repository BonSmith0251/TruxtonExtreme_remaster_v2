namespace System.Net;

[Token(Token = "0x2000272")]
internal enum CookieVariant : int
{
	Unknown = 0,
	Plain = 1,
	Rfc2109 = 2,
	Rfc2965 = 3,
	Default = 2,
}

