namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x20004A5")]
public struct YieldAwaitable
{
	[IsReadOnly]
	[Token(Token = "0x20004A6")]
	internal struct YieldAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[Token(Token = "0x4001284")]
		private static readonly WaitCallback s_waitCallbackRunAction; //Field offset: 0x0
		[Token(Token = "0x4001285")]
		private static readonly SendOrPostCallback s_sendOrPostCallbackRunAction; //Field offset: 0x8

		[Token(Token = "0x17000410")]
		public bool IsCompleted
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6002159")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x1F44720", Offset = "0x1F43B20", Length = "0xE4")]
		[Token(Token = "0x600215F")]
		private static YieldAwaiter() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002159")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600215E")]
		public void GetResult() { }

		[Address(RVA = "0x1F44340", Offset = "0x1F43740", Length = "0x4C")]
		[Token(Token = "0x600215A")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x1F44390", Offset = "0x1F43790", Length = "0x2C4")]
		[Token(Token = "0x600215C")]
		private static void QueueContinuation(Action continuation, bool flowContext) { }

		[Address(RVA = "0x1F44660", Offset = "0x1F43A60", Length = "0x6A")]
		[Token(Token = "0x600215D")]
		private static void RunAction(object state) { }

		[Address(RVA = "0x1F446D0", Offset = "0x1F43AD0", Length = "0x4C")]
		[Token(Token = "0x600215B")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}


	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002158")]
	public YieldAwaiter GetAwaiter() { }

}

