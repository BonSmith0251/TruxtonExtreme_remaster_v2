namespace System.Runtime.CompilerServices;

[Token(Token = "0x200049E")]
public struct AsyncTaskMethodBuilder
{
	[Token(Token = "0x4001271")]
	internal static readonly Task<TResult> s_defaultResultTask; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001272")]
	private AsyncMethodBuilderCore m_coreState; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001273")]
	private Task<TResult> m_task; //Field offset: 0x0

	[Token(Token = "0x1700040F")]
	public Task<TResult> Task
	{
		[Address(RVA = "0x1178860", Offset = "0x1177C60", Length = "0xA9")]
		[Token(Token = "0x600213D")]
		 get { } //Length: 169
	}

	[Address(RVA = "0x1178220", Offset = "0x1177620", Length = "0x10A")]
	[Token(Token = "0x6002142")]
	private static AsyncTaskMethodBuilder`1() { }

	[Address(RVA = "0x68D110", Offset = "0x68C510", Length = "0x1EA")]
	[Token(Token = "0x600213C")]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[Address(RVA = "0xA53C40", Offset = "0xA53040", Length = "0x10")]
	[Token(Token = "0x6002139")]
	public static AsyncTaskMethodBuilder<TResult> Create() { }

	[Address(RVA = "0x1178860", Offset = "0x1177C60", Length = "0xA9")]
	[Token(Token = "0x600213D")]
	public Task<TResult> get_Task() { }

	[Address(RVA = "0x11701B0", Offset = "0x116F5B0", Length = "0xCBE")]
	[Token(Token = "0x6002141")]
	internal static Task<TResult> GetTaskForResult(TResult result) { }

	[Address(RVA = "0x11753B0", Offset = "0x11747B0", Length = "0x1AF")]
	[Token(Token = "0x6002140")]
	public void SetException(Exception exception) { }

	[Address(RVA = "0x1175B70", Offset = "0x1174F70", Length = "0x1FF")]
	[Token(Token = "0x600213E")]
	public void SetResult(TResult result) { }

	[Address(RVA = "0x1177420", Offset = "0x1176820", Length = "0xC7")]
	[Token(Token = "0x600213F")]
	internal void SetResult(Task<TResult> completedTask) { }

	[Address(RVA = "0x11779C0", Offset = "0x1176DC0", Length = "0x8")]
	[Token(Token = "0x600213B")]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[Address(RVA = "0x68FE60", Offset = "0x68F260", Length = "0xBF")]
	[DebuggerStepThrough]
	[Token(Token = "0x600213A")]
	public void Start(ref TStateMachine stateMachine) { }

}

