namespace Cysharp.Threading.Tasks.CompilerServices;

[Token(Token = "0x2000246")]
internal sealed class AsyncUniTask : IStateMachineRunnerPromise<T>, IUniTaskSource<T>, IUniTaskSource, ITaskPoolNode<AsyncUniTask`2<TStateMachine, T>>
{
	[CompilerGenerated]
	[Token(Token = "0x2000247")]
	private sealed class <>c
	{
		[Token(Token = "0x400062F")]
		public static readonly <>c<TStateMachine, T> <>9; //Field offset: 0x0

		[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
		[Token(Token = "0x6000D0F")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000D10")]
		public <>c() { }

		[Address(RVA = "0xA35AD0", Offset = "0xA34ED0", Length = "0x98")]
		[Token(Token = "0x6000D11")]
		internal int <.cctor>b__12_0() { }

	}

	[Token(Token = "0x4000629")]
	private static TaskPool<AsyncUniTask`2<TStateMachine, T>> pool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400062A")]
	private readonly Action returnDelegate; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400062B")]
	private readonly Action <MoveNext>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400062C")]
	private TStateMachine stateMachine; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400062D")]
	private UniTaskCompletionSourceCore<T> core; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400062E")]
	private AsyncUniTask<TStateMachine, T> nextNode; //Field offset: 0x0

	[Token(Token = "0x17000088")]
	public override Action MoveNext
	{
		[Address(RVA = "0xF5D8B0", Offset = "0xF5CCB0", Length = "0x2A")]
		[CompilerGenerated]
		[Token(Token = "0x6000CFF")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000089")]
	public override AsyncUniTask<TStateMachine, T>& NextNode
	{
		[Address(RVA = "0x1399B40", Offset = "0x1398F40", Length = "0x21")]
		[Token(Token = "0x6000D02")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700008A")]
	public override UniTask<T> Task
	{
		[Address(RVA = "0x15EE350", Offset = "0x15ED750", Length = "0x1FF")]
		[DebuggerHidden]
		[Token(Token = "0x6000D07")]
		 get { } //Length: 511
	}

	[Address(RVA = "0x15E7D20", Offset = "0x15E7120", Length = "0x172")]
	[Token(Token = "0x6000D03")]
	private static AsyncUniTask`2() { }

	[Address(RVA = "0x15EBB90", Offset = "0x15EAF90", Length = "0x12E")]
	[Token(Token = "0x6000D00")]
	private AsyncUniTask`2() { }

	[Address(RVA = "0x15D8460", Offset = "0x15D7860", Length = "0xB8")]
	[DebuggerHidden]
	[Token(Token = "0x6000D0B")]
	private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

	[Address(RVA = "0xF5D8B0", Offset = "0xF5CCB0", Length = "0x2A")]
	[CompilerGenerated]
	[Token(Token = "0x6000CFF")]
	public override Action get_MoveNext() { }

	[Address(RVA = "0x1399B40", Offset = "0x1398F40", Length = "0x21")]
	[Token(Token = "0x6000D02")]
	public override AsyncUniTask<TStateMachine, T>& get_NextNode() { }

	[Address(RVA = "0x15EE350", Offset = "0x15ED750", Length = "0x1FF")]
	[DebuggerHidden]
	[Token(Token = "0x6000D07")]
	public override UniTask<T> get_Task() { }

	[Address(RVA = "0x15D9E40", Offset = "0x15D9240", Length = "0x1CF")]
	[DebuggerHidden]
	[Token(Token = "0x6000D0A")]
	public override T GetResult(short token) { }

	[Address(RVA = "0x15DBA70", Offset = "0x15DAE70", Length = "0x6A")]
	[DebuggerHidden]
	[Token(Token = "0x6000D0C")]
	public override UniTaskStatus GetStatus(short token) { }

	[Address(RVA = "0x15DC1A0", Offset = "0x15DB5A0", Length = "0x95")]
	[DebuggerHidden]
	[Token(Token = "0x6000D0E")]
	public override void OnCompleted(Action<Object> continuation, object state, short token) { }

	[Address(RVA = "0x15DE090", Offset = "0x15DD490", Length = "0x13F")]
	[Token(Token = "0x6000D04")]
	private void Return() { }

	[Address(RVA = "0x15DE9B0", Offset = "0x15DDDB0", Length = "0xED")]
	[DebuggerHidden]
	[Token(Token = "0x6000D06")]
	private void Run() { }

	[Address(RVA = "0x15DECE0", Offset = "0x15DE0E0", Length = "0x6A")]
	[DebuggerHidden]
	[Token(Token = "0x6000D09")]
	public override void SetException(Exception exception) { }

	[Address(RVA = "0x15DEF10", Offset = "0x15DE310", Length = "0x114")]
	[DebuggerHidden]
	[Token(Token = "0x6000D08")]
	public override void SetResult(T result) { }

	[Address(RVA = "0x15E37B0", Offset = "0x15E2BB0", Length = "0x252")]
	[Token(Token = "0x6000D01")]
	public static void SetStateMachine(ref TStateMachine stateMachine, ref IStateMachineRunnerPromise<T>& runnerPromiseFieldRef) { }

	[Address(RVA = "0x15DE090", Offset = "0x15DD490", Length = "0x13F")]
	[Token(Token = "0x6000D05")]
	private bool TryReturn() { }

	[Address(RVA = "0x15E7060", Offset = "0x15E6460", Length = "0x5A")]
	[DebuggerHidden]
	[Token(Token = "0x6000D0D")]
	public override UniTaskStatus UnsafeGetStatus() { }

}

