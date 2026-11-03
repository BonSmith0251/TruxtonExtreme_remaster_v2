namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000496")]
public struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001265")]
	private readonly Task<TResult> m_task; //Field offset: 0x0

	[Token(Token = "0x1700040A")]
	public bool IsCompleted
	{
		[Address(RVA = "0xFE3740", Offset = "0xFE2B40", Length = "0x1C")]
		[Token(Token = "0x6002116")]
		 get { } //Length: 28
	}

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x6002115")]
	internal TaskAwaiter`1(Task<TResult> task) { }

	[Address(RVA = "0xFE3740", Offset = "0xFE2B40", Length = "0x1C")]
	[Token(Token = "0x6002116")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0xFE3390", Offset = "0xFE2790", Length = "0x65")]
	[StackTraceHidden]
	[Token(Token = "0x6002119")]
	public TResult GetResult() { }

	[Address(RVA = "0xFE36E0", Offset = "0xFE2AE0", Length = "0x21")]
	[Token(Token = "0x6002117")]
	public override void OnCompleted(Action continuation) { }

	[Address(RVA = "0xFE3710", Offset = "0xFE2B10", Length = "0x20")]
	[Token(Token = "0x6002118")]
	public override void UnsafeOnCompleted(Action continuation) { }

}

