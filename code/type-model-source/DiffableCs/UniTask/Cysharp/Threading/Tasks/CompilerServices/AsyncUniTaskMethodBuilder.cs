namespace Cysharp.Threading.Tasks.CompilerServices;

[Token(Token = "0x200023A")]
public struct AsyncUniTaskMethodBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000614")]
	private IStateMachineRunnerPromise runnerPromise; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000615")]
	private Exception ex; //Field offset: 0x8

	[Token(Token = "0x17000079")]
	public UniTask Task
	{
		[Address(RVA = "0x2784830", Offset = "0x2783C30", Length = "0x14C")]
		[DebuggerHidden]
		[Token(Token = "0x6000CB8")]
		 get { } //Length: 332
	}

	[Address(RVA = "0x73BBF0", Offset = "0x73AFF0", Length = "0xC9")]
	[DebuggerHidden]
	[Token(Token = "0x6000CBB")]
	public void AwaitOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[Address(RVA = "0x73C150", Offset = "0x73B550", Length = "0xC7")]
	[DebuggerHidden]
	[Token(Token = "0x6000CBC")]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
	[DebuggerHidden]
	[Token(Token = "0x6000CB7")]
	public static AsyncUniTaskMethodBuilder Create() { }

	[Address(RVA = "0x2784830", Offset = "0x2783C30", Length = "0x14C")]
	[DebuggerHidden]
	[Token(Token = "0x6000CB8")]
	public UniTask get_Task() { }

	[Address(RVA = "0x2784770", Offset = "0x2783B70", Length = "0x6D")]
	[DebuggerHidden]
	[Token(Token = "0x6000CB9")]
	public void SetException(Exception exception) { }

	[Address(RVA = "0x27847E0", Offset = "0x2783BE0", Length = "0x4A")]
	[DebuggerHidden]
	[Token(Token = "0x6000CBA")]
	public void SetResult() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[DebuggerHidden]
	[Token(Token = "0x6000CBE")]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[Address(RVA = "0x740470", Offset = "0x73F870", Length = "0x39")]
	[DebuggerHidden]
	[Token(Token = "0x6000CBD")]
	public void Start(ref TStateMachine stateMachine) { }

}

