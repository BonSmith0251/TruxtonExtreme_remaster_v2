namespace Unity.XGamingRuntime;

[Token(Token = "0x2000283")]
public enum XTaskQueueDispatchMode : uint
{
	Manual = 0,
	ThreadPool = 1,
	SerializedThreadPool = 2,
	Immediate = 3,
}

