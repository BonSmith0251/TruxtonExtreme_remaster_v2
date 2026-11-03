namespace System.Net;

[Flags]
[Token(Token = "0x2000264")]
internal enum CloseExState : int
{
	Normal = 0,
	Abort = 1,
	Silent = 2,
}

