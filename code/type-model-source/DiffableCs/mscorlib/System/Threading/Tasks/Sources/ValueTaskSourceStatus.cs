namespace System.Threading.Tasks.Sources;

[Token(Token = "0x2000292")]
public enum ValueTaskSourceStatus : int
{
	Pending = 0,
	Succeeded = 1,
	Faulted = 2,
	Canceled = 3,
}

