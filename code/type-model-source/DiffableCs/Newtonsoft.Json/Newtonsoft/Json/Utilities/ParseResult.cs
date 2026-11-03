namespace Newtonsoft.Json.Utilities;

[Token(Token = "0x20000A0")]
internal enum ParseResult : int
{
	None = 0,
	Success = 1,
	Overflow = 2,
	Invalid = 3,
}

