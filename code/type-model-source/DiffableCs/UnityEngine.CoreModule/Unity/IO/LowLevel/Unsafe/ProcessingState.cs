namespace Unity.IO.LowLevel.Unsafe;

[NativeHeader("Runtime/File/AsyncReadManagerMetrics.h")]
[Token(Token = "0x2000044")]
public enum ProcessingState : int
{
	Unknown = 0,
	InQueue = 1,
	Reading = 2,
	Completed = 3,
	Failed = 4,
	Canceled = 5,
}

