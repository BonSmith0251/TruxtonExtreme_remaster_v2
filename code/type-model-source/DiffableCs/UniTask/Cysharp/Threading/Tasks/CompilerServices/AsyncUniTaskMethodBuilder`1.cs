namespace Cysharp.Threading.Tasks.CompilerServices;

[Token(Token = "0x200023B")]
public struct AsyncUniTaskMethodBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000616")]
	private IStateMachineRunnerPromise<T> runnerPromise; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000617")]
	private Exception ex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000618")]
	private T result; //Field offset: 0x0

	[Token(Token = "0x1700007A")]
	public UniTask<T> Task
	{
		[Address(RVA = "0x137E570", Offset = "0x137D970", Length = "0x193")]
		[DebuggerHidden]
		[Token(Token = "0x6000CC0")]
		 get { } //Length: 403
	}

	[Address(RVA = "0x6921A0", Offset = "0x6915A0", Length = "0x200")]
	[DebuggerHidden]
	[Token(Token = "0x6000CC3")]
	public void AwaitOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[Address(RVA = "0x693680", Offset = "0x692A80", Length = "0xE4")]
	[DebuggerHidden]
	[Token(Token = "0x6000CC4")]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[Address(RVA = "0x137D0E0", Offset = "0x137C4E0", Length = "0x14")]
	[DebuggerHidden]
	[Token(Token = "0x6000CBF")]
	public static AsyncUniTaskMethodBuilder<T> Create() { }

	[Address(RVA = "0x137E570", Offset = "0x137D970", Length = "0x193")]
	[DebuggerHidden]
	[Token(Token = "0x6000CC0")]
	public UniTask<T> get_Task() { }

	[Address(RVA = "0x137D240", Offset = "0x137C640", Length = "0x77")]
	[DebuggerHidden]
	[Token(Token = "0x6000CC1")]
	public void SetException(Exception exception) { }

	[Address(RVA = "0x137D500", Offset = "0x137C900", Length = "0xF9")]
	[DebuggerHidden]
	[Token(Token = "0x6000CC2")]
	public void SetResult(T result) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[DebuggerHidden]
	[Token(Token = "0x6000CC6")]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[Address(RVA = "0x6985F0", Offset = "0x6979F0", Length = "0x39")]
	[DebuggerHidden]
	[Token(Token = "0x6000CC5")]
	public void Start(ref TStateMachine stateMachine) { }

}

