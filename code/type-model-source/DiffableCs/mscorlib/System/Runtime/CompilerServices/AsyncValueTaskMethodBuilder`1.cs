namespace System.Runtime.CompilerServices;

[Token(Token = "0x2000470")]
public struct AsyncValueTaskMethodBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400124B")]
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400124C")]
	private TResult _result; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400124D")]
	private bool _haveResult; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400124E")]
	private bool _useBuilder; //Field offset: 0x0

	[Token(Token = "0x170003F7")]
	public ValueTask<TResult> Task
	{
		[Address(RVA = "0x1633F40", Offset = "0x1633340", Length = "0x11B")]
		[Token(Token = "0x60020BF")]
		 get { } //Length: 283
	}

	[Address(RVA = "0x699250", Offset = "0x698650", Length = "0x9F")]
	[Token(Token = "0x60020C0")]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[Address(RVA = "0x137CFF0", Offset = "0x137C3F0", Length = "0xE")]
	[Token(Token = "0x60020BA")]
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }

	[Address(RVA = "0x1633F40", Offset = "0x1633340", Length = "0x11B")]
	[Token(Token = "0x60020BF")]
	public ValueTask<TResult> get_Task() { }

	[Address(RVA = "0x1633650", Offset = "0x1632A50", Length = "0x94")]
	[Token(Token = "0x60020BE")]
	public void SetException(Exception exception) { }

	[Address(RVA = "0x16336F0", Offset = "0x1632AF0", Length = "0xAF")]
	[Token(Token = "0x60020BD")]
	public void SetResult(TResult result) { }

	[Address(RVA = "0x1633B60", Offset = "0x1632F60", Length = "0x94")]
	[Token(Token = "0x60020BC")]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[Address(RVA = "0x699630", Offset = "0x698A30", Length = "0x8B")]
	[Token(Token = "0x60020BB")]
	public void Start(ref TStateMachine stateMachine) { }

}

