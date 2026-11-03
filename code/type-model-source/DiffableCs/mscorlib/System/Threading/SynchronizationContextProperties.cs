namespace System.Threading;

[Flags]
[Token(Token = "0x200022A")]
internal enum SynchronizationContextProperties : int
{
	None = 0,
	RequireWaitNotification = 1,
}

