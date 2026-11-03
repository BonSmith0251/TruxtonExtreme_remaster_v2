namespace System.Net;

[Token(Token = "0x2000255")]
internal enum WebExceptionInternalStatus : int
{
	RequestFatal = 0,
	ServicePointFatal = 1,
	Recoverable = 2,
	Isolated = 3,
}

