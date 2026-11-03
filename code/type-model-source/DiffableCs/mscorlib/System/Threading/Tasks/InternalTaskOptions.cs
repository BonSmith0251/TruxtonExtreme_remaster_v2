namespace System.Threading.Tasks;

[Flags]
[Token(Token = "0x2000271")]
internal enum InternalTaskOptions : int
{
	None = 0,
	InternalOptionsMask = 65280,
	ContinuationTask = 512,
	PromiseTask = 1024,
	LazyCancellation = 4096,
	QueuedByRuntime = 8192,
	DoNotDispose = 16384,
}

