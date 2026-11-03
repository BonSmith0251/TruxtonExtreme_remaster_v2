namespace Cysharp.Threading.Tasks.CompilerServices;

[Token(Token = "0x200023C")]
public struct AsyncUniTaskVoidMethodBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000619")]
	private IStateMachineRunner runner; //Field offset: 0x0

	[Token(Token = "0x1700007B")]
	public UniTaskVoid Task
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000CC8")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x740F30", Offset = "0x740330", Length = "0x147")]
	[DebuggerHidden]
	[Token(Token = "0x6000CCB")]
	public void AwaitOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[Address(RVA = "0x7392C0", Offset = "0x7386C0", Length = "0xC7")]
	[DebuggerHidden]
	[Token(Token = "0x6000CCC")]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[DebuggerHidden]
	[Token(Token = "0x6000CC7")]
	public static AsyncUniTaskVoidMethodBuilder Create() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[DebuggerHidden]
	[Token(Token = "0x6000CC8")]
	public UniTaskVoid get_Task() { }

	[Address(RVA = "0x2784980", Offset = "0x2783D80", Length = "0xCB")]
	[DebuggerHidden]
	[Token(Token = "0x6000CC9")]
	public void SetException(Exception exception) { }

	[Address(RVA = "0x2784A50", Offset = "0x2783E50", Length = "0x94")]
	[DebuggerHidden]
	[Token(Token = "0x6000CCA")]
	public void SetResult() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[DebuggerHidden]
	[Token(Token = "0x6000CCE")]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[Address(RVA = "0x742D10", Offset = "0x742110", Length = "0x39")]
	[DebuggerHidden]
	[Token(Token = "0x6000CCD")]
	public void Start(ref TStateMachine stateMachine) { }

}

