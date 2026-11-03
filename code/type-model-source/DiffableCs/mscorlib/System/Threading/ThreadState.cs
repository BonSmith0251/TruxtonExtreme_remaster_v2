namespace System.Threading;

[Flags]
[Token(Token = "0x20001FD")]
public enum ThreadState : int
{
	Running = 0,
	StopRequested = 1,
	SuspendRequested = 2,
	Background = 4,
	Unstarted = 8,
	Stopped = 16,
	WaitSleepJoin = 32,
	Suspended = 64,
	AbortRequested = 128,
	Aborted = 256,
}

