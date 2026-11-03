namespace System.Threading.Tasks;

[Flags]
[Token(Token = "0x2000270")]
public enum TaskCreationOptions : int
{
	None = 0,
	PreferFairness = 1,
	LongRunning = 2,
	AttachedToParent = 4,
	DenyChildAttach = 8,
	HideScheduler = 16,
	RunContinuationsAsynchronously = 64,
}

