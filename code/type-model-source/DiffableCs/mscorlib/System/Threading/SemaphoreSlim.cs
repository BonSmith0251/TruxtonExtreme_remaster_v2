namespace System.Threading;

[ComVisible(False)]
[DebuggerDisplay("Current Count = {m_currentCount}")]
[Token(Token = "0x2000216")]
public class SemaphoreSlim : IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000218")]
	private struct <WaitUntilCountOrTimeoutAsync>d__32 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009D9")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40009DA")]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40009DB")]
		public CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40009DC")]
		public TaskNode asyncWaiter; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40009DD")]
		public int millisecondsTimeout; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40009DE")]
		public SemaphoreSlim <>4__this; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40009DF")]
		private CancellationTokenSource <cts>5__2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40009E0")]
		private object <>7__wrap2; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40009E1")]
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40009E2")]
		private ConfiguredTaskAwaiter<Boolean> <>u__2; //Field offset: 0x60

		[Address(RVA = "0x20A8AD0", Offset = "0x20A7ED0", Length = "0x965")]
		[Token(Token = "0x6001225")]
		private override void MoveNext() { }

		[Address(RVA = "0x20A9440", Offset = "0x20A8840", Length = "0x6A")]
		[DebuggerHidden]
		[Token(Token = "0x6001226")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x2000217")]
	private sealed class TaskNode : Task<Boolean>, IThreadPoolWorkItem
	{
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40009D7")]
		internal TaskNode Prev; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40009D8")]
		internal TaskNode Next; //Field offset: 0x60

		[Address(RVA = "0x20A5ED0", Offset = "0x20A52D0", Length = "0x39")]
		[Token(Token = "0x6001222")]
		internal TaskNode() { }

		[Address(RVA = "0x20A5E90", Offset = "0x20A5290", Length = "0x3B")]
		[Token(Token = "0x6001223")]
		private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6001224")]
		private override void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	}

	[Token(Token = "0x40009D4")]
	private static readonly Task<Boolean> s_trueTask; //Field offset: 0x0
	[Token(Token = "0x40009D5")]
	private static readonly Task<Boolean> s_falseTask; //Field offset: 0x8
	[Token(Token = "0x40009D6")]
	private static Action<Object> s_cancellationTokenCanceledEventHandler; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009CD")]
	private int m_currentCount; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40009CE")]
	private readonly int m_maxCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009CF")]
	private int m_waitCount; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009D0")]
	private object m_lockObj; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009D1")]
	private ManualResetEvent m_waitHandle; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009D2")]
	private TaskNode m_asyncHead; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009D3")]
	private TaskNode m_asyncTail; //Field offset: 0x38

	[Address(RVA = "0x20A4500", Offset = "0x20A3900", Length = "0x16A")]
	[Token(Token = "0x6001221")]
	private static SemaphoreSlim() { }

	[Address(RVA = "0x20A4670", Offset = "0x20A3A70", Length = "0x1C4")]
	[Token(Token = "0x6001210")]
	public SemaphoreSlim(int initialCount, int maxCount) { }

	[Address(RVA = "0x20A2C40", Offset = "0x20A2040", Length = "0x202")]
	[Token(Token = "0x600121E")]
	private static void CancellationTokenCanceledEventHandler(object obj) { }

	[Address(RVA = "0x20A2E50", Offset = "0x20A2250", Length = "0x8F")]
	[Token(Token = "0x600121F")]
	private void CheckDispose() { }

	[Address(RVA = "0x20A2EE0", Offset = "0x20A22E0", Length = "0xC9")]
	[Token(Token = "0x6001216")]
	private TaskNode CreateAndAddAsyncWaiter() { }

	[Address(RVA = "0x20A2FB0", Offset = "0x20A23B0", Length = "0x61")]
	[Token(Token = "0x600121C")]
	public override void Dispose() { }

	[Address(RVA = "0x20A3020", Offset = "0x20A2420", Length = "0xA4")]
	[Token(Token = "0x600121D")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x20A30D0", Offset = "0x20A24D0", Length = "0x7")]
	[Token(Token = "0x6001220")]
	private static string GetResourceString(string str) { }

	[Address(RVA = "0x20A30E0", Offset = "0x20A24E0", Length = "0xA")]
	[Token(Token = "0x600121B")]
	private static void QueueWaiterTask(TaskNode waiterTask) { }

	[Address(RVA = "0x20A34D0", Offset = "0x20A28D0", Length = "0xD")]
	[Token(Token = "0x6001219")]
	public int Release() { }

	[Address(RVA = "0x20A30F0", Offset = "0x20A24F0", Length = "0x3D0")]
	[Token(Token = "0x600121A")]
	public int Release(int releaseCount) { }

	[Address(RVA = "0x20A34E0", Offset = "0x20A28E0", Length = "0xE3")]
	[Token(Token = "0x6001217")]
	private bool RemoveAsyncWaiter(TaskNode task) { }

	[Address(RVA = "0x20A3E00", Offset = "0x20A3200", Length = "0x6E0")]
	[Token(Token = "0x6001212")]
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20A44F0", Offset = "0x20A38F0", Length = "0x10")]
	[Token(Token = "0x6001211")]
	public void Wait() { }

	[Address(RVA = "0x20A35D0", Offset = "0x20A29D0", Length = "0x10")]
	[Token(Token = "0x6001214")]
	public Task WaitAsync() { }

	[Address(RVA = "0x20A35E0", Offset = "0x20A29E0", Length = "0x5AE")]
	[Token(Token = "0x6001215")]
	public Task<Boolean> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20A3CE0", Offset = "0x20A30E0", Length = "0x11D")]
	[Token(Token = "0x6001213")]
	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	[Address(RVA = "0x20A3B90", Offset = "0x20A2F90", Length = "0x149")]
	[AsyncStateMachine(typeof(<WaitUntilCountOrTimeoutAsync>d__32))]
	[Token(Token = "0x6001218")]
	private Task<Boolean> WaitUntilCountOrTimeoutAsync(TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

}

