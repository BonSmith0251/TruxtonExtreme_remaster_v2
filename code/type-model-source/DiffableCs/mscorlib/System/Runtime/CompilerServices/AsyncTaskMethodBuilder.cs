namespace System.Runtime.CompilerServices;

[Token(Token = "0x200049D")]
public struct AsyncTaskMethodBuilder
{
	[Token(Token = "0x400126F")]
	private static readonly Task<VoidTaskResult> s_cachedCompleted; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001270")]
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; //Field offset: 0x0

	[Token(Token = "0x1700040E")]
	public Task Task
	{
		[Address(RVA = "0x1F32A60", Offset = "0x1F31E60", Length = "0x5A")]
		[Token(Token = "0x6002135")]
		 get { } //Length: 90
	}

	[Address(RVA = "0x1F329E0", Offset = "0x1F31DE0", Length = "0x7D")]
	[Token(Token = "0x6002138")]
	private static AsyncTaskMethodBuilder() { }

	[Address(RVA = "0x736760", Offset = "0x735B60", Length = "0x81")]
	[Token(Token = "0x6002134")]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[Address(RVA = "0xA53C40", Offset = "0xA53040", Length = "0x10")]
	[Token(Token = "0x6002131")]
	public static AsyncTaskMethodBuilder Create() { }

	[Address(RVA = "0x1F32A60", Offset = "0x1F31E60", Length = "0x5A")]
	[Token(Token = "0x6002135")]
	public Task get_Task() { }

	[Address(RVA = "0x1F32860", Offset = "0x1F31C60", Length = "0x69")]
	[Token(Token = "0x6002137")]
	public void SetException(Exception exception) { }

	[Address(RVA = "0x1F328D0", Offset = "0x1F31CD0", Length = "0x9B")]
	[Token(Token = "0x6002136")]
	public void SetResult() { }

	[Address(RVA = "0x1F32970", Offset = "0x1F31D70", Length = "0x69")]
	[Token(Token = "0x6002133")]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[Address(RVA = "0x692780", Offset = "0x691B80", Length = "0x1D6")]
	[DebuggerStepThrough]
	[Token(Token = "0x6002132")]
	public void Start(ref TStateMachine stateMachine) { }

}

