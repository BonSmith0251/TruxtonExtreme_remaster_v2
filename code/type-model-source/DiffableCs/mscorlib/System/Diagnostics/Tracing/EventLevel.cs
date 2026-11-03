namespace System.Diagnostics.Tracing;

[Token(Token = "0x2000591")]
public enum EventLevel : int
{
	LogAlways = 0,
	Critical = 1,
	Error = 2,
	Warning = 3,
	Informational = 4,
	Verbose = 5,
}

