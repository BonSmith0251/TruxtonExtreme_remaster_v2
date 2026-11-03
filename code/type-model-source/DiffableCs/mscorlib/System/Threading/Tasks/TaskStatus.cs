namespace System.Threading.Tasks;

[Token(Token = "0x2000268")]
public enum TaskStatus : int
{
	Created = 0,
	WaitingForActivation = 1,
	WaitingToRun = 2,
	Running = 3,
	WaitingForChildrenToComplete = 4,
	RanToCompletion = 5,
	Canceled = 6,
	Faulted = 7,
}

