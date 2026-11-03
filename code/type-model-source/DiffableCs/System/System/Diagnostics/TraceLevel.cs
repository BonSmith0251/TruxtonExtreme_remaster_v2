namespace System.Diagnostics;

[Token(Token = "0x2000101")]
public enum TraceLevel : int
{
	Off = 0,
	Error = 1,
	Warning = 2,
	Info = 3,
	Verbose = 4,
}

