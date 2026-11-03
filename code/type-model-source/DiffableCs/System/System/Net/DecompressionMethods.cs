namespace System.Net;

[Flags]
[Token(Token = "0x2000296")]
public enum DecompressionMethods : int
{
	None = 0,
	GZip = 1,
	Deflate = 2,
}

