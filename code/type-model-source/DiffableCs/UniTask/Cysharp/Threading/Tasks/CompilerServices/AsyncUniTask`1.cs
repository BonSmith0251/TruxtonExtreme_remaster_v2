namespace Cysharp.Threading.Tasks.CompilerServices;

[Token(Token = "0x2000244")]
internal sealed class AsyncUniTask : IStateMachineRunnerPromise, IUniTaskSource, ITaskPoolNode<AsyncUniTask`1<TStateMachine>>
{
	[CompilerGenerated]
	[Token(Token = "0x2000245")]
	private sealed class <>c
	{
		[Token(Token = "0x4000628")]
		public static readonly <>c<TStateMachine> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6000CFC")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000CFD")]
		public <>c() { }

		[Address(RVA = "0xA35A50", Offset = "0xA34E50", Length = "0x77")]
		[Token(Token = "0x6000CFE")]
		internal int <.cctor>b__12_0() { }

	}

	[Token(Token = "0x4000622")]
	private static TaskPool<AsyncUniTask`1<TStateMachine>> pool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000623")]
	private readonly Action returnDelegate; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000624")]
	private readonly Action <MoveNext>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000625")]
	private TStateMachine stateMachine; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000626")]
	private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000627")]
	private AsyncUniTask<TStateMachine> nextNode; //Field offset: 0x0

	[Token(Token = "0x17000085")]
	public override Action MoveNext
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000CED")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000086")]
	public override AsyncUniTask<TStateMachine>& NextNode
	{
		[Address(RVA = "0x1388FE0", Offset = "0x13883E0", Length = "0x8")]
		[Token(Token = "0x6000CF0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000087")]
	public override UniTask Task
	{
		[Address(RVA = "0x139A0E0", Offset = "0x13994E0", Length = "0x65")]
		[DebuggerHidden]
		[Token(Token = "0x6000CF5")]
		 get { } //Length: 101
	}

	[Address(RVA = "0x1397290", Offset = "0x1396690", Length = "0x172")]
	[Token(Token = "0x6000CF1")]
	private static AsyncUniTask`1() { }

	[Address(RVA = "0x1398B90", Offset = "0x1397F90", Length = "0xC2")]
	[Token(Token = "0x6000CEE")]
	private AsyncUniTask`1() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000CED")]
	public override Action get_MoveNext() { }

	[Address(RVA = "0x1388FE0", Offset = "0x13883E0", Length = "0x8")]
	[Token(Token = "0x6000CF0")]
	public override AsyncUniTask<TStateMachine>& get_NextNode() { }

	[Address(RVA = "0x139A0E0", Offset = "0x13994E0", Length = "0x65")]
	[DebuggerHidden]
	[Token(Token = "0x6000CF5")]
	public override UniTask get_Task() { }

	[Address(RVA = "0x138A3F0", Offset = "0x13897F0", Length = "0xB0")]
	[DebuggerHidden]
	[Token(Token = "0x6000CF8")]
	public override void GetResult(short token) { }

	[Address(RVA = "0x138A8B0", Offset = "0x1389CB0", Length = "0x49")]
	[DebuggerHidden]
	[Token(Token = "0x6000CF9")]
	public override UniTaskStatus GetStatus(short token) { }

	[Address(RVA = "0x138B940", Offset = "0x138AD40", Length = "0x70")]
	[DebuggerHidden]
	[Token(Token = "0x6000CFB")]
	public override void OnCompleted(Action<Object> continuation, object state, short token) { }

	[Address(RVA = "0x138C3E0", Offset = "0x138B7E0", Length = "0xCE")]
	[Token(Token = "0x6000CF2")]
	private void Return() { }

	[Address(RVA = "0x138DA50", Offset = "0x138CE50", Length = "0x1B")]
	[DebuggerHidden]
	[Token(Token = "0x6000CF4")]
	private void Run() { }

	[Address(RVA = "0x138DEF0", Offset = "0x138D2F0", Length = "0x49")]
	[DebuggerHidden]
	[Token(Token = "0x6000CF7")]
	public override void SetException(Exception exception) { }

	[Address(RVA = "0x138EFA0", Offset = "0x138E3A0", Length = "0x6F")]
	[DebuggerHidden]
	[Token(Token = "0x6000CF6")]
	public override void SetResult() { }

	[Address(RVA = "0x13910A0", Offset = "0x13904A0", Length = "0x250")]
	[Token(Token = "0x6000CEF")]
	public static void SetStateMachine(ref TStateMachine stateMachine, ref IStateMachineRunnerPromise runnerPromiseFieldRef) { }

	[Address(RVA = "0x1393B50", Offset = "0x1392F50", Length = "0xCE")]
	[Token(Token = "0x6000CF3")]
	private bool TryReturn() { }

	[Address(RVA = "0x1395310", Offset = "0x1394710", Length = "0x3A")]
	[DebuggerHidden]
	[Token(Token = "0x6000CFA")]
	public override UniTaskStatus UnsafeGetStatus() { }

}

