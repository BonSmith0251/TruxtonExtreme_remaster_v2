namespace System.Threading.Tasks.Sources;

[Flags]
[Token(Token = "0x2000291")]
public enum ValueTaskSourceOnCompletedFlags : int
{
	None = 0,
	UseSchedulingContext = 1,
	FlowExecutionContext = 2,
}

