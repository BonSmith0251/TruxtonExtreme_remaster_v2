namespace System.Threading;

[Token(Token = "0x20001F5")]
public enum LazyThreadSafetyMode : int
{
	None = 0,
	PublicationOnly = 1,
	ExecutionAndPublication = 2,
}

