namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000499")]
public struct ConfiguredTaskAwaitable
{
	[IsReadOnly]
	[Token(Token = "0x200049A")]
	internal struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400126A")]
		private readonly Task<TResult> m_task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400126B")]
		private readonly bool m_continueOnCapturedContext; //Field offset: 0x0

		[Token(Token = "0x1700040C")]
		public bool IsCompleted
		{
			[Address(RVA = "0xFE3740", Offset = "0xFE2B40", Length = "0x1C")]
			[Token(Token = "0x6002124")]
			 get { } //Length: 28
		}

		[Address(RVA = "0xAEE570", Offset = "0xAED970", Length = "0x28")]
		[Token(Token = "0x6002123")]
		internal ConfiguredTaskAwaiter(Task<TResult> task, bool continueOnCapturedContext) { }

		[Address(RVA = "0xFE3740", Offset = "0xFE2B40", Length = "0x1C")]
		[Token(Token = "0x6002124")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0xFE3390", Offset = "0xFE2790", Length = "0x65")]
		[StackTraceHidden]
		[Token(Token = "0x6002127")]
		public TResult GetResult() { }

		[Address(RVA = "0x17BE910", Offset = "0x17BDD10", Length = "0x22")]
		[Token(Token = "0x6002125")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x17BE940", Offset = "0x17BDD40", Length = "0x22")]
		[Token(Token = "0x6002126")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001269")]
	private readonly ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter; //Field offset: 0x0

	[Address(RVA = "0x17BE8A0", Offset = "0x17BDCA0", Length = "0x6C")]
	[Token(Token = "0x6002121")]
	internal ConfiguredTaskAwaitable`1(Task<TResult> task, bool continueOnCapturedContext) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x6002122")]
	public ConfiguredTaskAwaiter<TResult> GetAwaiter() { }

}

