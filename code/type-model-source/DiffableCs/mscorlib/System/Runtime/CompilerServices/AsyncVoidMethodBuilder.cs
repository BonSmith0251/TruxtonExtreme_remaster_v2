namespace System.Runtime.CompilerServices;

[Token(Token = "0x200049C")]
public struct AsyncVoidMethodBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400126C")]
	private SynchronizationContext m_synchronizationContext; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400126D")]
	private AsyncMethodBuilderCore m_coreState; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400126E")]
	private Task m_task; //Field offset: 0x18

	[Token(Token = "0x1700040D")]
	internal Task Task
	{
		[Address(RVA = "0x1F32DD0", Offset = "0x1F321D0", Length = "0x69")]
		[Token(Token = "0x6002130")]
		internal get { } //Length: 105
	}

	[Address(RVA = "0x7445C0", Offset = "0x7439C0", Length = "0x2AA")]
	[Token(Token = "0x600212C")]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[Address(RVA = "0x1F32AC0", Offset = "0x1F31EC0", Length = "0x67")]
	[Token(Token = "0x6002129")]
	public static AsyncVoidMethodBuilder Create() { }

	[Address(RVA = "0x1F32DD0", Offset = "0x1F321D0", Length = "0x69")]
	[Token(Token = "0x6002130")]
	internal Task get_Task() { }

	[Address(RVA = "0x1F32B30", Offset = "0x1F31F30", Length = "0x40")]
	[Token(Token = "0x600212F")]
	private void NotifySynchronizationContextOfCompletion() { }

	[Address(RVA = "0x1F32B80", Offset = "0x1F31F80", Length = "0x119")]
	[Token(Token = "0x600212E")]
	public void SetException(Exception exception) { }

	[Address(RVA = "0x1F32CA0", Offset = "0x1F320A0", Length = "0x5F")]
	[Token(Token = "0x600212D")]
	public void SetResult() { }

	[Address(RVA = "0x1F32D00", Offset = "0x1F32100", Length = "0xCA")]
	[Token(Token = "0x600212B")]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[Address(RVA = "0x692780", Offset = "0x691B80", Length = "0x1D6")]
	[DebuggerStepThrough]
	[Token(Token = "0x600212A")]
	public void Start(ref TStateMachine stateMachine) { }

}

