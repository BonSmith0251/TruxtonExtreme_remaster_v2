namespace System.Runtime.CompilerServices;

[IsReadOnly]
[Token(Token = "0x2000493")]
public struct ValueTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001261")]
	private readonly ValueTask<TResult> _value; //Field offset: 0x0

	[Token(Token = "0x17000408")]
	public bool IsCompleted
	{
		[Address(RVA = "0x120FD00", Offset = "0x120F100", Length = "0x36")]
		[Token(Token = "0x6002105")]
		 get { } //Length: 54
	}

	[Address(RVA = "0x120FC40", Offset = "0x120F040", Length = "0xD")]
	[Token(Token = "0x6002104")]
	internal ValueTaskAwaiter`1(ValueTask<TResult> value) { }

	[Address(RVA = "0x120FD00", Offset = "0x120F100", Length = "0x36")]
	[Token(Token = "0x6002105")]
	public bool get_IsCompleted() { }

	[Address(RVA = "0x11FEC50", Offset = "0x11FE050", Length = "0x36")]
	[StackTraceHidden]
	[Token(Token = "0x6002106")]
	public TResult GetResult() { }

	[Address(RVA = "0x120F130", Offset = "0x120E530", Length = "0x1FD")]
	[Token(Token = "0x6002107")]
	public override void OnCompleted(Action continuation) { }

	[Address(RVA = "0x120F650", Offset = "0x120EA50", Length = "0x1F9")]
	[Token(Token = "0x6002108")]
	public override void UnsafeOnCompleted(Action continuation) { }

}

