namespace System.Diagnostics;

[Flags]
[Token(Token = "0x2000104")]
public enum TraceOptions : int
{
	None = 0,
	LogicalOperationStack = 1,
	DateTime = 2,
	Timestamp = 4,
	ProcessId = 8,
	ThreadId = 16,
	Callstack = 32,
}

