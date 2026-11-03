namespace Cysharp.Threading.Tasks;

[AsyncMethodBuilder(typeof(AsyncUniTaskMethodBuilder))]
[IsReadOnly]
[Token(Token = "0x2000075")]
public struct UniTask
{
	[CompilerGenerated]
	[Token(Token = "0x20000DC")]
	private sealed class <>c
	{
		[Token(Token = "0x400033C")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x273F580", Offset = "0x273E980", Length = "0x67")]
		[Token(Token = "0x60005D7")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005D8")]
		public <>c() { }

		[Address(RVA = "0x273EB10", Offset = "0x273DF10", Length = "0xAC")]
		[Token(Token = "0x60005D9")]
		internal UniTask <.cctor>b__176_0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DD")]
	private sealed class <>c__DisplayClass55_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400033D")]
		public Func<UniTaskVoid> asyncAction; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005DA")]
		public <>c__DisplayClass55_0() { }

		[Address(RVA = "0x273F2D0", Offset = "0x273E6D0", Length = "0x3A")]
		[Token(Token = "0x60005DB")]
		internal void <Action>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DE")]
	private sealed class <>c__DisplayClass56_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400033E")]
		public Func<CancellationToken, UniTaskVoid> asyncAction; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400033F")]
		public CancellationToken cancellationToken; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005DC")]
		public <>c__DisplayClass56_0() { }

		[Address(RVA = "0x273F310", Offset = "0x273E710", Length = "0x3E")]
		[Token(Token = "0x60005DD")]
		internal void <Action>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000DF")]
	private sealed class <>c__DisplayClass57_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000340")]
		public Func<UniTaskVoid> asyncAction; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005DE")]
		public <>c__DisplayClass57_0() { }

		[Address(RVA = "0x273F2D0", Offset = "0x273E6D0", Length = "0x3A")]
		[Token(Token = "0x60005DF")]
		internal void <UnityAction>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E0")]
	private sealed class <>c__DisplayClass58_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000341")]
		public Func<CancellationToken, UniTaskVoid> asyncAction; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000342")]
		public CancellationToken cancellationToken; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005E0")]
		public <>c__DisplayClass58_0() { }

		[Address(RVA = "0x273F310", Offset = "0x273E710", Length = "0x3E")]
		[Token(Token = "0x60005E1")]
		internal void <UnityAction>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E1")]
	private struct <RunOnThreadPool>d__78 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000343")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000344")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000345")]
		public CancellationToken cancellationToken; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000346")]
		public bool configureAwait; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000347")]
		public Action action; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000348")]
		private Awaiter <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000349")]
		private object <>7__wrap1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400034A")]
		private int <>7__wrap2; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x400034B")]
		private Awaiter <>u__2; //Field offset: 0x44

		[Address(RVA = "0x273B6A0", Offset = "0x273AAA0", Length = "0x4D0")]
		[Token(Token = "0x60005E2")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60005E3")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E2")]
	private struct <RunOnThreadPool>d__79 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400034C")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400034D")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400034E")]
		public CancellationToken cancellationToken; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400034F")]
		public bool configureAwait; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000350")]
		public Action<Object> action; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000351")]
		public object state; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000352")]
		private Awaiter <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000353")]
		private object <>7__wrap1; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000354")]
		private int <>7__wrap2; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000355")]
		private Awaiter <>u__2; //Field offset: 0x4C

		[Address(RVA = "0x273BB80", Offset = "0x273AF80", Length = "0x4D8")]
		[Token(Token = "0x60005E4")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60005E5")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E3")]
	private struct <RunOnThreadPool>d__80 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000356")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000357")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000358")]
		public CancellationToken cancellationToken; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000359")]
		public bool configureAwait; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400035A")]
		public Func<UniTask> action; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400035B")]
		private Awaiter <>u__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400035C")]
		private object <>7__wrap1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400035D")]
		private int <>7__wrap2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400035E")]
		private Awaiter <>u__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400035F")]
		private Awaiter <>u__3; //Field offset: 0x58

		[Address(RVA = "0x273C060", Offset = "0x273B460", Length = "0x765")]
		[Token(Token = "0x60005E6")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60005E7")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E4")]
	private struct <RunOnThreadPool>d__81 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000360")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000361")]
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000362")]
		public CancellationToken cancellationToken; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000363")]
		public bool configureAwait; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000364")]
		public Func<Object, UniTask> action; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000365")]
		public object state; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000366")]
		private Awaiter <>u__1; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000367")]
		private object <>7__wrap1; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000368")]
		private int <>7__wrap2; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000369")]
		private Awaiter <>u__2; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400036A")]
		private Awaiter <>u__3; //Field offset: 0x60

		[Address(RVA = "0x273C7D0", Offset = "0x273BBD0", Length = "0x76D")]
		[Token(Token = "0x60005E8")]
		private override void MoveNext() { }

		[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
		[DebuggerHidden]
		[Token(Token = "0x60005E9")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E5")]
	private struct <RunOnThreadPool>d__82 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400036B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400036C")]
		public AsyncUniTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400036D")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400036E")]
		public bool configureAwait; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400036F")]
		public Func<T> func; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000370")]
		private Awaiter <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000371")]
		private object <>7__wrap1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000372")]
		private int <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000373")]
		private T <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000374")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x197A110", Offset = "0x1979510", Length = "0xD8A")]
		[Token(Token = "0x60005EA")]
		private override void MoveNext() { }

		[Address(RVA = "0x197AEA0", Offset = "0x197A2A0", Length = "0xC1")]
		[DebuggerHidden]
		[Token(Token = "0x60005EB")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E6")]
	private struct <RunOnThreadPool>d__83 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000375")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000376")]
		public AsyncUniTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000377")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000378")]
		public bool configureAwait; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000379")]
		public Func<UniTask`1<T>> func; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400037A")]
		private Awaiter <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400037B")]
		private object <>7__wrap1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400037C")]
		private int <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400037D")]
		private T <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400037E")]
		private Awaiter<T> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400037F")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x197AF70", Offset = "0x197A370", Length = "0x15E2")]
		[Token(Token = "0x60005EC")]
		private override void MoveNext() { }

		[Address(RVA = "0xA5A210", Offset = "0xA59610", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x60005ED")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E7")]
	private struct <RunOnThreadPool>d__84 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000380")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000381")]
		public AsyncUniTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000382")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000383")]
		public bool configureAwait; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000384")]
		public Func<Object, T> func; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000385")]
		public object state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000386")]
		private Awaiter <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000387")]
		private object <>7__wrap1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000388")]
		private int <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000389")]
		private T <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400038A")]
		private Awaiter <>u__2; //Field offset: 0x0

		[Address(RVA = "0x197C560", Offset = "0x197B960", Length = "0xE05")]
		[Token(Token = "0x60005EE")]
		private override void MoveNext() { }

		[Address(RVA = "0x197AEA0", Offset = "0x197A2A0", Length = "0xC1")]
		[DebuggerHidden]
		[Token(Token = "0x60005EF")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E8")]
	private struct <RunOnThreadPool>d__85 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400038B")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400038C")]
		public AsyncUniTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400038D")]
		public CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400038E")]
		public bool configureAwait; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400038F")]
		public Func<Object, UniTask`1<T>> func; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000390")]
		public object state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000391")]
		private Awaiter <>u__1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000392")]
		private object <>7__wrap1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000393")]
		private int <>7__wrap2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000394")]
		private T <>7__wrap3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000395")]
		private Awaiter<T> <>u__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000396")]
		private Awaiter <>u__3; //Field offset: 0x0

		[Address(RVA = "0x197D370", Offset = "0x197C770", Length = "0x166D")]
		[Token(Token = "0x60005F0")]
		private override void MoveNext() { }

		[Address(RVA = "0xA5A210", Offset = "0xA59610", Length = "0xC7")]
		[DebuggerHidden]
		[Token(Token = "0x60005F1")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Token(Token = "0x2000076")]
	private sealed class AsyncUnitSource : IUniTaskSource<AsyncUnit>, IUniTaskSource
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000101")]
		private readonly IUniTaskSource source; //Field offset: 0x10

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000205")]
		public AsyncUnitSource(IUniTaskSource source) { }

		[Address(RVA = "0x272E2D0", Offset = "0x272D6D0", Length = "0x7B")]
		[Token(Token = "0x600020A")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x272E350", Offset = "0x272D750", Length = "0x8F")]
		[Token(Token = "0x6000206")]
		public override AsyncUnit GetResult(short token) { }

		[Address(RVA = "0x272E3E0", Offset = "0x272D7E0", Length = "0x56")]
		[Token(Token = "0x6000207")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x272E440", Offset = "0x272D840", Length = "0x7E")]
		[Token(Token = "0x6000208")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x272E4C0", Offset = "0x272D8C0", Length = "0x49")]
		[Token(Token = "0x6000209")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[IsReadOnly]
	[Token(Token = "0x2000079")]
	internal struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000106")]
		private readonly UniTask task; //Field offset: 0x0

		[Token(Token = "0x17000031")]
		public bool IsCompleted
		{
			[Address(RVA = "0x27303C0", Offset = "0x272F7C0", Length = "0x8D")]
			[DebuggerHidden]
			[Token(Token = "0x6000217")]
			 get { } //Length: 141
		}

		[Address(RVA = "0x120FC40", Offset = "0x120F040", Length = "0xD")]
		[DebuggerHidden]
		[Token(Token = "0x6000216")]
		public Awaiter(in UniTask task) { }

		[Address(RVA = "0x27303C0", Offset = "0x272F7C0", Length = "0x8D")]
		[DebuggerHidden]
		[Token(Token = "0x6000217")]
		public bool get_IsCompleted() { }

		[Address(RVA = "0x272F530", Offset = "0x272E930", Length = "0x4F")]
		[DebuggerHidden]
		[Token(Token = "0x6000218")]
		public void GetResult() { }

		[Address(RVA = "0x272F980", Offset = "0x272ED80", Length = "0xC5")]
		[DebuggerHidden]
		[Token(Token = "0x6000219")]
		public override void OnCompleted(Action continuation) { }

		[Address(RVA = "0x272FB50", Offset = "0x272EF50", Length = "0x9A")]
		[DebuggerHidden]
		[Token(Token = "0x600021B")]
		public void SourceOnCompleted(Action<Object> continuation, object state) { }

		[Address(RVA = "0x272FEB0", Offset = "0x272F2B0", Length = "0xC5")]
		[DebuggerHidden]
		[Token(Token = "0x600021A")]
		public override void UnsafeOnCompleted(Action continuation) { }

	}

	[Token(Token = "0x200008B")]
	private sealed class CanceledResultSource : IUniTaskSource
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400013D")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x10

		[Address(RVA = "0x1606F40", Offset = "0x1606340", Length = "0x30")]
		[Token(Token = "0x6000287")]
		public CanceledResultSource(CancellationToken cancellationToken) { }

		[Address(RVA = "0x2730650", Offset = "0x272FA50", Length = "0x4A")]
		[Token(Token = "0x6000288")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x6000289")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x16C5260", Offset = "0x16C4660", Length = "0x2A")]
		[Token(Token = "0x600028B")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x600028A")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x200008C")]
	private sealed class CanceledResultSource : IUniTaskSource<T>, IUniTaskSource
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400013E")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0

		[Address(RVA = "0x1606F40", Offset = "0x1606340", Length = "0x30")]
		[Token(Token = "0x600028C")]
		public CanceledResultSource`1(CancellationToken cancellationToken) { }

		[Address(RVA = "0x16C5170", Offset = "0x16C4570", Length = "0x46")]
		[Token(Token = "0x600028E")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x16C51C0", Offset = "0x16C45C0", Length = "0x46")]
		[Token(Token = "0x600028D")]
		public override T GetResult(short token) { }

		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x600028F")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x16C5260", Offset = "0x16C4660", Length = "0x2A")]
		[Token(Token = "0x6000291")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x6000290")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000088")]
	private static class CanceledUniTaskCache
	{
		[Token(Token = "0x4000138")]
		public static readonly UniTask<T> Task; //Field offset: 0x0

		[Address(RVA = "0x16C5770", Offset = "0x16C4B70", Length = "0x1CA")]
		[Token(Token = "0x6000279")]
		private static CanceledUniTaskCache`1() { }

	}

	[Token(Token = "0x200008D")]
	private sealed class DeferPromise : IUniTaskSource
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400013F")]
		private Func<UniTask> factory; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000140")]
		private UniTask task; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000141")]
		private Awaiter awaiter; //Field offset: 0x28

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000292")]
		public DeferPromise(Func<UniTask> factory) { }

		[Address(RVA = "0x2731C20", Offset = "0x2731020", Length = "0x51")]
		[Token(Token = "0x6000293")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x2731C80", Offset = "0x2731080", Length = "0xF8")]
		[Token(Token = "0x6000294")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x2731D80", Offset = "0x2731180", Length = "0x9C")]
		[Token(Token = "0x6000295")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x2731E20", Offset = "0x2731220", Length = "0x84")]
		[Token(Token = "0x6000296")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x200008E")]
	private sealed class DeferPromise : IUniTaskSource<T>, IUniTaskSource
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000142")]
		private Func<UniTask`1<T>> factory; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000143")]
		private UniTask<T> task; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000144")]
		private Awaiter<T> awaiter; //Field offset: 0x0

		[Address(RVA = "0xD0D210", Offset = "0xD0C610", Length = "0x6E")]
		[Token(Token = "0x6000297")]
		public DeferPromise`1(Func<UniTask`1<T>> factory) { }

		[Address(RVA = "0x17D4CD0", Offset = "0x17D40D0", Length = "0xB5")]
		[Token(Token = "0x6000299")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x17D4D90", Offset = "0x17D4190", Length = "0xC1")]
		[Token(Token = "0x6000298")]
		public override T GetResult(short token) { }

		[Address(RVA = "0x17D4E60", Offset = "0x17D4260", Length = "0x1ED")]
		[Token(Token = "0x600029A")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x17D5050", Offset = "0x17D4450", Length = "0x7A")]
		[Token(Token = "0x600029B")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x17D50D0", Offset = "0x17D44D0", Length = "0x55")]
		[Token(Token = "0x600029C")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000080")]
	private sealed class DelayFramePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayFramePromise>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000081")]
		private sealed class <>c
		{
			[Token(Token = "0x4000120")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x273F9E0", Offset = "0x273EDE0", Length = "0x67")]
			[Token(Token = "0x600024F")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000250")]
			public <>c() { }

			[Address(RVA = "0x273EE00", Offset = "0x273E200", Length = "0x5A")]
			[Token(Token = "0x6000251")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000119")]
		private static TaskPool<DelayFramePromise> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011A")]
		private DelayFramePromise nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400011B")]
		private int initialFrame; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400011C")]
		private int delayFrameCount; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400011D")]
		private CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400011E")]
		private int currentFrameCount; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400011F")]
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x30

		[Token(Token = "0x17000036")]
		public override DelayFramePromise NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x6000245")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x27323D0", Offset = "0x27317D0", Length = "0x100")]
		[Token(Token = "0x6000246")]
		private static DelayFramePromise() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000247")]
		private DelayFramePromise() { }

		[Address(RVA = "0x2731EB0", Offset = "0x27312B0", Length = "0x1EC")]
		[Token(Token = "0x6000248")]
		public static IUniTaskSource Create(int delayFrameCount, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x6000245")]
		public override DelayFramePromise get_NextNode() { }

		[Address(RVA = "0x27320A0", Offset = "0x27314A0", Length = "0x80")]
		[Token(Token = "0x6000249")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x2732130", Offset = "0x2731530", Length = "0x49")]
		[Token(Token = "0x600024A")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x2732180", Offset = "0x2731580", Length = "0x105")]
		[Token(Token = "0x600024D")]
		public override bool MoveNext() { }

		[Address(RVA = "0x2732290", Offset = "0x2731690", Length = "0x70")]
		[Token(Token = "0x600024C")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x2732300", Offset = "0x2731700", Length = "0x8F")]
		[Token(Token = "0x600024E")]
		private bool TryReturn() { }

		[Address(RVA = "0x2732390", Offset = "0x2731790", Length = "0x3A")]
		[Token(Token = "0x600024B")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000084")]
	private sealed class DelayIgnoreTimeScalePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayIgnoreTimeScalePromise>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000085")]
		private sealed class <>c
		{
			[Token(Token = "0x4000130")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x273F820", Offset = "0x273EC20", Length = "0x67")]
			[Token(Token = "0x6000269")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600026A")]
			public <>c() { }

			[Address(RVA = "0x273EE60", Offset = "0x273E260", Length = "0x5A")]
			[Token(Token = "0x600026B")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000129")]
		private static TaskPool<DelayIgnoreTimeScalePromise> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012A")]
		private DelayIgnoreTimeScalePromise nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400012B")]
		private float delayFrameTimeSpan; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400012C")]
		private float elapsed; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400012D")]
		private int initialFrame; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400012E")]
		private CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400012F")]
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x30

		[Token(Token = "0x17000038")]
		public override DelayIgnoreTimeScalePromise NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x600025F")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2732A20", Offset = "0x2731E20", Length = "0x100")]
		[Token(Token = "0x6000260")]
		private static DelayIgnoreTimeScalePromise() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000261")]
		private DelayIgnoreTimeScalePromise() { }

		[Address(RVA = "0x27324D0", Offset = "0x27318D0", Length = "0x23F")]
		[Token(Token = "0x6000262")]
		public static IUniTaskSource Create(TimeSpan delayFrameTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x600025F")]
		public override DelayIgnoreTimeScalePromise get_NextNode() { }

		[Address(RVA = "0x2732710", Offset = "0x2731B10", Length = "0x80")]
		[Token(Token = "0x6000263")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x27327A0", Offset = "0x2731BA0", Length = "0x49")]
		[Token(Token = "0x6000264")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x27327F0", Offset = "0x2731BF0", Length = "0xEB")]
		[Token(Token = "0x6000267")]
		public override bool MoveNext() { }

		[Address(RVA = "0x27328E0", Offset = "0x2731CE0", Length = "0x70")]
		[Token(Token = "0x6000266")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x2732950", Offset = "0x2731D50", Length = "0x8D")]
		[Token(Token = "0x6000268")]
		private bool TryReturn() { }

		[Address(RVA = "0x27329E0", Offset = "0x2731DE0", Length = "0x3A")]
		[Token(Token = "0x6000265")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000082")]
	private sealed class DelayPromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayPromise>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000083")]
		private sealed class <>c
		{
			[Token(Token = "0x4000128")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x273F740", Offset = "0x273EB40", Length = "0x67")]
			[Token(Token = "0x600025C")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600025D")]
			public <>c() { }

			[Address(RVA = "0x273EC80", Offset = "0x273E080", Length = "0x5A")]
			[Token(Token = "0x600025E")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000121")]
		private static TaskPool<DelayPromise> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000122")]
		private DelayPromise nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000123")]
		private int initialFrame; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000124")]
		private float delayTimeSpan; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000125")]
		private float elapsed; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000126")]
		private CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000127")]
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x30

		[Token(Token = "0x17000037")]
		public override DelayPromise NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x6000252")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2733070", Offset = "0x2732470", Length = "0x100")]
		[Token(Token = "0x6000253")]
		private static DelayPromise() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000254")]
		private DelayPromise() { }

		[Address(RVA = "0x2732B20", Offset = "0x2731F20", Length = "0x23F")]
		[Token(Token = "0x6000255")]
		public static IUniTaskSource Create(TimeSpan delayTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x6000252")]
		public override DelayPromise get_NextNode() { }

		[Address(RVA = "0x2732D60", Offset = "0x2732160", Length = "0x80")]
		[Token(Token = "0x6000256")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x2732DF0", Offset = "0x27321F0", Length = "0x49")]
		[Token(Token = "0x6000257")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x2732E40", Offset = "0x2732240", Length = "0xEB")]
		[Token(Token = "0x600025A")]
		public override bool MoveNext() { }

		[Address(RVA = "0x2732F30", Offset = "0x2732330", Length = "0x70")]
		[Token(Token = "0x6000259")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x2732FA0", Offset = "0x27323A0", Length = "0x8D")]
		[Token(Token = "0x600025B")]
		private bool TryReturn() { }

		[Address(RVA = "0x2733030", Offset = "0x2732430", Length = "0x3A")]
		[Token(Token = "0x6000258")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000086")]
	private sealed class DelayRealtimePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<DelayRealtimePromise>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000087")]
		private sealed class <>c
		{
			[Token(Token = "0x4000137")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x273F660", Offset = "0x273EA60", Length = "0x67")]
			[Token(Token = "0x6000276")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000277")]
			public <>c() { }

			[Address(RVA = "0x273EF20", Offset = "0x273E320", Length = "0x5A")]
			[Token(Token = "0x6000278")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000131")]
		private static TaskPool<DelayRealtimePromise> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000132")]
		private DelayRealtimePromise nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000133")]
		private long delayTimeSpanTicks; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000134")]
		private ValueStopwatch stopwatch; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000135")]
		private CancellationToken cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000136")]
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x30

		[Token(Token = "0x17000039")]
		public override DelayRealtimePromise NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x600026C")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x27336E0", Offset = "0x2732AE0", Length = "0x100")]
		[Token(Token = "0x600026D")]
		private static DelayRealtimePromise() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600026E")]
		private DelayRealtimePromise() { }

		[Address(RVA = "0x2733170", Offset = "0x2732570", Length = "0x21C")]
		[Token(Token = "0x600026F")]
		public static IUniTaskSource Create(TimeSpan delayTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x600026C")]
		public override DelayRealtimePromise get_NextNode() { }

		[Address(RVA = "0x2733390", Offset = "0x2732790", Length = "0x80")]
		[Token(Token = "0x6000270")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x2733420", Offset = "0x2732820", Length = "0x49")]
		[Token(Token = "0x6000271")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x2733470", Offset = "0x2732870", Length = "0x12C")]
		[Token(Token = "0x6000274")]
		public override bool MoveNext() { }

		[Address(RVA = "0x27335A0", Offset = "0x27329A0", Length = "0x70")]
		[Token(Token = "0x6000273")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x2733610", Offset = "0x2732A10", Length = "0x8D")]
		[Token(Token = "0x6000275")]
		private bool TryReturn() { }

		[Address(RVA = "0x27336A0", Offset = "0x2732AA0", Length = "0x3A")]
		[Token(Token = "0x6000272")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000089")]
	private sealed class ExceptionResultSource : IUniTaskSource
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000139")]
		private readonly ExceptionDispatchInfo exception; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400013A")]
		private bool calledGet; //Field offset: 0x18

		[Address(RVA = "0x1BAF040", Offset = "0x1BAE440", Length = "0x3B")]
		[Token(Token = "0x600027A")]
		public ExceptionResultSource(Exception exception) { }

		[Address(RVA = "0x27348A0", Offset = "0x2733CA0", Length = "0xA6")]
		[Token(Token = "0x600027F")]
		protected virtual void Finalize() { }

		[Address(RVA = "0x2734950", Offset = "0x2733D50", Length = "0x68")]
		[Token(Token = "0x600027B")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x600027C")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x16C5260", Offset = "0x16C4660", Length = "0x2A")]
		[Token(Token = "0x600027E")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x600027D")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x200008A")]
	private sealed class ExceptionResultSource : IUniTaskSource<T>, IUniTaskSource
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400013B")]
		private readonly ExceptionDispatchInfo exception; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400013C")]
		private bool calledGet; //Field offset: 0x0

		[Address(RVA = "0x1BAF040", Offset = "0x1BAE440", Length = "0x3B")]
		[Token(Token = "0x6000280")]
		public ExceptionResultSource`1(Exception exception) { }

		[Address(RVA = "0x1BAD2B0", Offset = "0x1BAC6B0", Length = "0x68")]
		[Token(Token = "0x6000282")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1BAE3C0", Offset = "0x1BAD7C0", Length = "0xBB")]
		[Token(Token = "0x6000286")]
		protected virtual void Finalize() { }

		[Address(RVA = "0x1BAEF40", Offset = "0x1BAE340", Length = "0x8E")]
		[Token(Token = "0x6000281")]
		public override T GetResult(short token) { }

		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000283")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x16C5260", Offset = "0x16C4660", Length = "0x2A")]
		[Token(Token = "0x6000285")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000284")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000077")]
	private sealed class IsCanceledSource : IUniTaskSource<Boolean>, IUniTaskSource
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000102")]
		private readonly IUniTaskSource source; //Field offset: 0x10

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x600020B")]
		public IsCanceledSource(IUniTaskSource source) { }

		[Address(RVA = "0x2734BF0", Offset = "0x2733FF0", Length = "0x7A")]
		[Token(Token = "0x600020D")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x2734C70", Offset = "0x2734070", Length = "0x89")]
		[Token(Token = "0x600020C")]
		public override bool GetResult(short token) { }

		[Address(RVA = "0x2734D00", Offset = "0x2734100", Length = "0x56")]
		[Token(Token = "0x600020E")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x2734D60", Offset = "0x2734160", Length = "0x7E")]
		[Token(Token = "0x6000210")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x2734DE0", Offset = "0x27341E0", Length = "0x49")]
		[Token(Token = "0x600020F")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000078")]
	private sealed class MemoizeSource : IUniTaskSource
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000103")]
		private IUniTaskSource source; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000104")]
		private ExceptionDispatchInfo exception; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000105")]
		private UniTaskStatus status; //Field offset: 0x20

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000211")]
		public MemoizeSource(IUniTaskSource source) { }

		[Address(RVA = "0x2734E30", Offset = "0x2734230", Length = "0x160")]
		[Token(Token = "0x6000212")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x2734FA0", Offset = "0x27343A0", Length = "0x61")]
		[Token(Token = "0x6000213")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x2735010", Offset = "0x2734410", Length = "0x98")]
		[Token(Token = "0x6000214")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x27350B0", Offset = "0x27344B0", Length = "0x4F")]
		[Token(Token = "0x6000215")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x200008F")]
	private sealed class NeverPromise : IUniTaskSource<T>, IUniTaskSource
	{
		[Token(Token = "0x4000145")]
		private static readonly Action<Object> cancellationCallback; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000146")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000147")]
		private UniTaskCompletionSourceCore<T> core; //Field offset: 0x0

		[Address(RVA = "0xD98070", Offset = "0xD97470", Length = "0xEA")]
		[Token(Token = "0x60002A4")]
		private static NeverPromise`1() { }

		[Address(RVA = "0xD98160", Offset = "0xD97560", Length = "0x121")]
		[Token(Token = "0x600029D")]
		public NeverPromise`1(CancellationToken cancellationToken) { }

		[Address(RVA = "0xD97680", Offset = "0xD96A80", Length = "0xA8")]
		[Token(Token = "0x600029E")]
		private static void CancellationCallback(object state) { }

		[Address(RVA = "0xD97960", Offset = "0xD96D60", Length = "0x18")]
		[Token(Token = "0x60002A3")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0xD97960", Offset = "0xD96D60", Length = "0x18")]
		[Token(Token = "0x600029F")]
		public override T GetResult(short token) { }

		[Address(RVA = "0xD97AE0", Offset = "0xD96EE0", Length = "0x13A")]
		[Token(Token = "0x60002A0")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0xD97CB0", Offset = "0xD970B0", Length = "0x1C4")]
		[Token(Token = "0x60002A2")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0xD97EE0", Offset = "0xD972E0", Length = "0x91")]
		[Token(Token = "0x60002A1")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x200007C")]
	private sealed class NextFramePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<NextFramePromise>
	{
		[CompilerGenerated]
		[Token(Token = "0x200007D")]
		private sealed class <>c
		{
			[Token(Token = "0x4000111")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x273F3C0", Offset = "0x273E7C0", Length = "0x67")]
			[Token(Token = "0x6000233")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000234")]
			public <>c() { }

			[Address(RVA = "0x273ECE0", Offset = "0x273E0E0", Length = "0x5A")]
			[Token(Token = "0x6000235")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x400010C")]
		private static TaskPool<NextFramePromise> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400010D")]
		private NextFramePromise nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400010E")]
		private int frameCount; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400010F")]
		private CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000110")]
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x28

		[Token(Token = "0x17000033")]
		public override NextFramePromise NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x6000229")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2735B00", Offset = "0x2734F00", Length = "0x100")]
		[Token(Token = "0x600022A")]
		private static NextFramePromise() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600022B")]
		private NextFramePromise() { }

		[Address(RVA = "0x2735600", Offset = "0x2734A00", Length = "0x1E1")]
		[Token(Token = "0x600022C")]
		public static IUniTaskSource Create(PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x6000229")]
		public override NextFramePromise get_NextNode() { }

		[Address(RVA = "0x27357F0", Offset = "0x2734BF0", Length = "0x80")]
		[Token(Token = "0x600022D")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x2735880", Offset = "0x2734C80", Length = "0x49")]
		[Token(Token = "0x600022E")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x27358D0", Offset = "0x2734CD0", Length = "0xEA")]
		[Token(Token = "0x6000231")]
		public override bool MoveNext() { }

		[Address(RVA = "0x27359C0", Offset = "0x2734DC0", Length = "0x70")]
		[Token(Token = "0x6000230")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x2735A30", Offset = "0x2734E30", Length = "0x89")]
		[Token(Token = "0x6000232")]
		private bool TryReturn() { }

		[Address(RVA = "0x2735AC0", Offset = "0x2734EC0", Length = "0x3A")]
		[Token(Token = "0x600022F")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x200007E")]
	private sealed class WaitForEndOfFramePromise : IUniTaskSource, ITaskPoolNode<WaitForEndOfFramePromise>, IEnumerator
	{
		[CompilerGenerated]
		[Token(Token = "0x200007F")]
		private sealed class <>c
		{
			[Token(Token = "0x4000118")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x273F4A0", Offset = "0x273E8A0", Length = "0x67")]
			[Token(Token = "0x6000242")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000243")]
			public <>c() { }

			[Address(RVA = "0x273EEC0", Offset = "0x273E2C0", Length = "0x5A")]
			[Token(Token = "0x6000244")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000112")]
		private static TaskPool<WaitForEndOfFramePromise> pool; //Field offset: 0x0
		[Token(Token = "0x4000116")]
		private static readonly WaitForEndOfFrame waitForEndOfFrameYieldInstruction; //Field offset: 0x10
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000113")]
		private WaitForEndOfFramePromise nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000114")]
		private CancellationToken cancellationToken; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000115")]
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x20
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000117")]
		private bool isFirst; //Field offset: 0x48

		[Token(Token = "0x17000034")]
		public override WaitForEndOfFramePromise NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x6000236")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000035")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x274C7D0", Offset = "0x274BBD0", Length = "0x4F")]
			[Token(Token = "0x600023F")]
			private get { } //Length: 79
		}

		[Address(RVA = "0x274C8F0", Offset = "0x274BCF0", Length = "0x15D")]
		[Token(Token = "0x6000237")]
		private static WaitForEndOfFramePromise() { }

		[Address(RVA = "0x274CA50", Offset = "0x274BE50", Length = "0xB")]
		[Token(Token = "0x6000238")]
		private WaitForEndOfFramePromise() { }

		[Address(RVA = "0x274C430", Offset = "0x274B830", Length = "0x189")]
		[Token(Token = "0x6000239")]
		public static IUniTaskSource Create(MonoBehaviour coroutineRunner, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x6000236")]
		public override WaitForEndOfFramePromise get_NextNode() { }

		[Address(RVA = "0x274C5C0", Offset = "0x274B9C0", Length = "0x80")]
		[Token(Token = "0x600023A")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x274C650", Offset = "0x274BA50", Length = "0x49")]
		[Token(Token = "0x600023B")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x274C6A0", Offset = "0x274BAA0", Length = "0x70")]
		[Token(Token = "0x600023D")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x21FC7B0", Offset = "0x21FBBB0", Length = "0x5")]
		[Token(Token = "0x6000241")]
		public override void Reset() { }

		[Address(RVA = "0x274C7D0", Offset = "0x274BBD0", Length = "0x4F")]
		[Token(Token = "0x600023F")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x274C710", Offset = "0x274BB10", Length = "0xB4")]
		[Token(Token = "0x6000240")]
		private override bool System.Collections.IEnumerator.MoveNext() { }

		[Address(RVA = "0x274C820", Offset = "0x274BC20", Length = "0x8D")]
		[Token(Token = "0x600023E")]
		private bool TryReturn() { }

		[Address(RVA = "0x274C8B0", Offset = "0x274BCB0", Length = "0x3A")]
		[Token(Token = "0x600023C")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000094")]
	private sealed class WaitUntilCanceledPromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitUntilCanceledPromise>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000095")]
		private sealed class <>c
		{
			[Token(Token = "0x4000158")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x273FA50", Offset = "0x273EE50", Length = "0x67")]
			[Token(Token = "0x60002C9")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60002CA")]
			public <>c() { }

			[Address(RVA = "0x273EFE0", Offset = "0x273E3E0", Length = "0x5A")]
			[Token(Token = "0x60002CB")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000154")]
		private static TaskPool<WaitUntilCanceledPromise> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000155")]
		private WaitUntilCanceledPromise nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000156")]
		private CancellationToken cancellationToken; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000157")]
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x20

		[Token(Token = "0x1700003C")]
		public override WaitUntilCanceledPromise NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x60002BF")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x274CEB0", Offset = "0x274C2B0", Length = "0x100")]
		[Token(Token = "0x60002C0")]
		private static WaitUntilCanceledPromise() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002C1")]
		private WaitUntilCanceledPromise() { }

		[Address(RVA = "0x274CA60", Offset = "0x274BE60", Length = "0x1A2")]
		[Token(Token = "0x60002C2")]
		public static IUniTaskSource Create(CancellationToken cancellationToken, PlayerLoopTiming timing, out short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x60002BF")]
		public override WaitUntilCanceledPromise get_NextNode() { }

		[Address(RVA = "0x274CC10", Offset = "0x274C010", Length = "0x80")]
		[Token(Token = "0x60002C3")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x274CCA0", Offset = "0x274C0A0", Length = "0x49")]
		[Token(Token = "0x60002C4")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x274CCF0", Offset = "0x274C0F0", Length = "0x77")]
		[Token(Token = "0x60002C7")]
		public override bool MoveNext() { }

		[Address(RVA = "0x274CD70", Offset = "0x274C170", Length = "0x70")]
		[Token(Token = "0x60002C6")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x274CDE0", Offset = "0x274C1E0", Length = "0x89")]
		[Token(Token = "0x60002C8")]
		private bool TryReturn() { }

		[Address(RVA = "0x274CE70", Offset = "0x274C270", Length = "0x3A")]
		[Token(Token = "0x60002C5")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000090")]
	private sealed class WaitUntilPromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitUntilPromise>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000091")]
		private sealed class <>c
		{
			[Token(Token = "0x400014D")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x273F6D0", Offset = "0x273EAD0", Length = "0x67")]
			[Token(Token = "0x60002AF")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60002B0")]
			public <>c() { }

			[Address(RVA = "0x273EF80", Offset = "0x273E380", Length = "0x5A")]
			[Token(Token = "0x60002B1")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000148")]
		private static TaskPool<WaitUntilPromise> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000149")]
		private WaitUntilPromise nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400014A")]
		private Func<Boolean> predicate; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400014B")]
		private CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400014C")]
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x28

		[Token(Token = "0x1700003A")]
		public override WaitUntilPromise NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x60002A5")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x274D490", Offset = "0x274C890", Length = "0x100")]
		[Token(Token = "0x60002A6")]
		private static WaitUntilPromise() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002A7")]
		private WaitUntilPromise() { }

		[Address(RVA = "0x274CFB0", Offset = "0x274C3B0", Length = "0x1BF")]
		[Token(Token = "0x60002A8")]
		public static IUniTaskSource Create(Func<Boolean> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x60002A5")]
		public override WaitUntilPromise get_NextNode() { }

		[Address(RVA = "0x274D170", Offset = "0x274C570", Length = "0x80")]
		[Token(Token = "0x60002A9")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x274D200", Offset = "0x274C600", Length = "0x49")]
		[Token(Token = "0x60002AA")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x274D250", Offset = "0x274C650", Length = "0xEA")]
		[Token(Token = "0x60002AD")]
		public override bool MoveNext() { }

		[Address(RVA = "0x274D340", Offset = "0x274C740", Length = "0x70")]
		[Token(Token = "0x60002AC")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x274D3B0", Offset = "0x274C7B0", Length = "0x9C")]
		[Token(Token = "0x60002AE")]
		private bool TryReturn() { }

		[Address(RVA = "0x274D450", Offset = "0x274C850", Length = "0x3A")]
		[Token(Token = "0x60002AB")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000098")]
	private sealed class WaitUntilValueChangedStandardObjectPromise : IUniTaskSource<U>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitUntilValueChangedStandardObjectPromise`2<T, U>>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000099")]
		private sealed class <>c
		{
			[Token(Token = "0x400016B")]
			public static readonly <>c<T, U> <>9; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x60002E5")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60002E6")]
			public <>c() { }

			[Address(RVA = "0xA35AD0", Offset = "0xA34ED0", Length = "0x98")]
			[Token(Token = "0x60002E7")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000163")]
		private static TaskPool<WaitUntilValueChangedStandardObjectPromise`2<T, U>> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000164")]
		private WaitUntilValueChangedStandardObjectPromise<T, U> nextNode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000165")]
		private WeakReference<T> target; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000166")]
		private U currentValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000167")]
		private Func<T, U> monitorFunction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000168")]
		private IEqualityComparer<U> equalityComparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000169")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016A")]
		private UniTaskCompletionSourceCore<U> core; //Field offset: 0x0

		[Token(Token = "0x1700003E")]
		public override WaitUntilValueChangedStandardObjectPromise<T, U>& NextNode
		{
			[Address(RVA = "0x11617C0", Offset = "0x1160BC0", Length = "0x1E")]
			[Token(Token = "0x60002DA")]
			 get { } //Length: 30
		}

		[Address(RVA = "0x1415400", Offset = "0x1414800", Length = "0x172")]
		[Token(Token = "0x60002DB")]
		private static WaitUntilValueChangedStandardObjectPromise`2() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002DC")]
		private WaitUntilValueChangedStandardObjectPromise`2() { }

		[Address(RVA = "0x1414220", Offset = "0x1413620", Length = "0x6DF")]
		[Token(Token = "0x60002DD")]
		public static IUniTaskSource<U> Create(T target, Func<T, U> monitorFunction, IEqualityComparer<U> equalityComparer, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0x1414900", Offset = "0x1413D00", Length = "0xB8")]
		[Token(Token = "0x60002DF")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x11617C0", Offset = "0x1160BC0", Length = "0x1E")]
		[Token(Token = "0x60002DA")]
		public override WaitUntilValueChangedStandardObjectPromise<T, U>& get_NextNode() { }

		[Address(RVA = "0x14149C0", Offset = "0x1413DC0", Length = "0x1EB")]
		[Token(Token = "0x60002DE")]
		public override U GetResult(short token) { }

		[Address(RVA = "0x1414BB0", Offset = "0x1413FB0", Length = "0x6D")]
		[Token(Token = "0x60002E0")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1414C20", Offset = "0x1414020", Length = "0x48C")]
		[Token(Token = "0x60002E3")]
		public override bool MoveNext() { }

		[Address(RVA = "0x14150B0", Offset = "0x14144B0", Length = "0x98")]
		[Token(Token = "0x60002E2")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1415150", Offset = "0x1414550", Length = "0x244")]
		[Token(Token = "0x60002E4")]
		private bool TryReturn() { }

		[Address(RVA = "0x14153A0", Offset = "0x14147A0", Length = "0x5D")]
		[Token(Token = "0x60002E1")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000096")]
	private sealed class WaitUntilValueChangedUnityObjectPromise : IUniTaskSource<U>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitUntilValueChangedUnityObjectPromise`2<T, U>>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000097")]
		private sealed class <>c
		{
			[Token(Token = "0x4000162")]
			public static readonly <>c<T, U> <>9; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x60002D7")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60002D8")]
			public <>c() { }

			[Address(RVA = "0xA35AD0", Offset = "0xA34ED0", Length = "0x98")]
			[Token(Token = "0x60002D9")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000159")]
		private static TaskPool<WaitUntilValueChangedUnityObjectPromise`2<T, U>> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400015A")]
		private WaitUntilValueChangedUnityObjectPromise<T, U> nextNode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400015B")]
		private T target; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400015C")]
		private object targetAsUnityObject; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400015D")]
		private U currentValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400015E")]
		private Func<T, U> monitorFunction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400015F")]
		private IEqualityComparer<U> equalityComparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000160")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000161")]
		private UniTaskCompletionSourceCore<U> core; //Field offset: 0x0

		[Token(Token = "0x1700003D")]
		public override WaitUntilValueChangedUnityObjectPromise<T, U>& NextNode
		{
			[Address(RVA = "0x11617C0", Offset = "0x1160BC0", Length = "0x1E")]
			[Token(Token = "0x60002CC")]
			 get { } //Length: 30
		}

		[Address(RVA = "0x14169E0", Offset = "0x1415DE0", Length = "0x172")]
		[Token(Token = "0x60002CD")]
		private static WaitUntilValueChangedUnityObjectPromise`2() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002CE")]
		private WaitUntilValueChangedUnityObjectPromise`2() { }

		[Address(RVA = "0x1415580", Offset = "0x1414980", Length = "0x8B8")]
		[Token(Token = "0x60002CF")]
		public static IUniTaskSource<U> Create(T target, Func<T, U> monitorFunction, IEqualityComparer<U> equalityComparer, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0x1415E40", Offset = "0x1415240", Length = "0xB8")]
		[Token(Token = "0x60002D1")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x11617C0", Offset = "0x1160BC0", Length = "0x1E")]
		[Token(Token = "0x60002CC")]
		public override WaitUntilValueChangedUnityObjectPromise<T, U>& get_NextNode() { }

		[Address(RVA = "0x1415F00", Offset = "0x1415300", Length = "0x1EB")]
		[Token(Token = "0x60002D0")]
		public override U GetResult(short token) { }

		[Address(RVA = "0x14160F0", Offset = "0x14154F0", Length = "0x6D")]
		[Token(Token = "0x60002D2")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1416160", Offset = "0x1415560", Length = "0x51F")]
		[Token(Token = "0x60002D5")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1416690", Offset = "0x1415A90", Length = "0x98")]
		[Token(Token = "0x60002D4")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1416730", Offset = "0x1415B30", Length = "0x245")]
		[Token(Token = "0x60002D6")]
		private bool TryReturn() { }

		[Address(RVA = "0x1416980", Offset = "0x1415D80", Length = "0x5D")]
		[Token(Token = "0x60002D3")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x2000092")]
	private sealed class WaitWhilePromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<WaitWhilePromise>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000093")]
		private sealed class <>c
		{
			[Token(Token = "0x4000153")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x273F890", Offset = "0x273EC90", Length = "0x67")]
			[Token(Token = "0x60002BC")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60002BD")]
			public <>c() { }

			[Address(RVA = "0x273ED40", Offset = "0x273E140", Length = "0x5A")]
			[Token(Token = "0x60002BE")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x400014E")]
		private static TaskPool<WaitWhilePromise> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400014F")]
		private WaitWhilePromise nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000150")]
		private Func<Boolean> predicate; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000151")]
		private CancellationToken cancellationToken; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000152")]
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x28

		[Token(Token = "0x1700003B")]
		public override WaitWhilePromise NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x60002B2")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x274DA70", Offset = "0x274CE70", Length = "0x100")]
		[Token(Token = "0x60002B3")]
		private static WaitWhilePromise() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002B4")]
		private WaitWhilePromise() { }

		[Address(RVA = "0x274D590", Offset = "0x274C990", Length = "0x1BF")]
		[Token(Token = "0x60002B5")]
		public static IUniTaskSource Create(Func<Boolean> predicate, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x60002B2")]
		public override WaitWhilePromise get_NextNode() { }

		[Address(RVA = "0x274D750", Offset = "0x274CB50", Length = "0x80")]
		[Token(Token = "0x60002B6")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x274D7E0", Offset = "0x274CBE0", Length = "0x49")]
		[Token(Token = "0x60002B7")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x274D830", Offset = "0x274CC30", Length = "0xEA")]
		[Token(Token = "0x60002BA")]
		public override bool MoveNext() { }

		[Address(RVA = "0x274D920", Offset = "0x274CD20", Length = "0x70")]
		[Token(Token = "0x60002B9")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x274D990", Offset = "0x274CD90", Length = "0x9C")]
		[Token(Token = "0x60002BB")]
		private bool TryReturn() { }

		[Address(RVA = "0x274DA30", Offset = "0x274CE30", Length = "0x3A")]
		[Token(Token = "0x60002B8")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x200009C")]
	private sealed class WhenAllPromise : IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x200009D")]
		private sealed class <>c
		{
			[Token(Token = "0x4000174")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000175")]
			public static Action<Object> <>9__3_0; //Field offset: 0x8

			[Address(RVA = "0x273F7B0", Offset = "0x273EBB0", Length = "0x67")]
			[Token(Token = "0x60002F8")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60002F9")]
			public <>c() { }

			[Address(RVA = "0x273F140", Offset = "0x273E540", Length = "0xF7")]
			[Token(Token = "0x60002FA")]
			internal void <.ctor>b__3_0(object state) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000171")]
		private int completeCount; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000172")]
		private int tasksLength; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000173")]
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x18

		[Address(RVA = "0x274DE00", Offset = "0x274D200", Length = "0x2C0")]
		[Token(Token = "0x60002F2")]
		public WhenAllPromise(UniTask[] tasks, int tasksLength) { }

		[Address(RVA = "0x274DB70", Offset = "0x274CF70", Length = "0x74")]
		[Token(Token = "0x60002F4")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x274DBF0", Offset = "0x274CFF0", Length = "0x49")]
		[Token(Token = "0x60002F5")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x274DC40", Offset = "0x274D040", Length = "0x70")]
		[Token(Token = "0x60002F7")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x274DCB0", Offset = "0x274D0B0", Length = "0x10C")]
		[Token(Token = "0x60002F3")]
		private static void TryInvokeContinuation(WhenAllPromise self, in Awaiter awaiter) { }

		[Address(RVA = "0x274DDC0", Offset = "0x274D1C0", Length = "0x3A")]
		[Token(Token = "0x60002F6")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x200009A")]
	private sealed class WhenAllPromise : IUniTaskSource<T[]>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x200009B")]
		private sealed class <>c
		{
			[Token(Token = "0x400016F")]
			public static readonly <>c<T> <>9; //Field offset: 0x0
			[Token(Token = "0x4000170")]
			public static Action<Object> <>9__3_0; //Field offset: 0x0

			[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
			[Token(Token = "0x60002EF")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60002F0")]
			public <>c() { }

			[Address(RVA = "0xA4D7D0", Offset = "0xA4CBD0", Length = "0x127")]
			[Token(Token = "0x60002F1")]
			internal void <.ctor>b__3_0(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016C")]
		private T[] result; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016D")]
		private int completeCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016E")]
		private UniTaskCompletionSourceCore<T[]> core; //Field offset: 0x0

		[Address(RVA = "0x1455050", Offset = "0x1454450", Length = "0x422")]
		[Token(Token = "0x60002E8")]
		public WhenAllPromise`1(UniTask<T>[] tasks, int tasksLength) { }

		[Address(RVA = "0x1454650", Offset = "0x1453A50", Length = "0x8F")]
		[Token(Token = "0x60002EB")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x14546E0", Offset = "0x1453AE0", Length = "0x80")]
		[Token(Token = "0x60002EA")]
		public override T[] GetResult(short token) { }

		[Address(RVA = "0x1454830", Offset = "0x1453C30", Length = "0x13D")]
		[Token(Token = "0x60002EC")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x14549A0", Offset = "0x1453DA0", Length = "0x1C7")]
		[Token(Token = "0x60002EE")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1454E00", Offset = "0x1454200", Length = "0x189")]
		[Token(Token = "0x60002E9")]
		private static void TryInvokeContinuation(WhenAllPromise<T> self, in Awaiter<T> awaiter, int i) { }

		[Address(RVA = "0x1454F90", Offset = "0x1454390", Length = "0x91")]
		[Token(Token = "0x60002ED")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000AE")]
	private sealed class WhenAllPromise0 : IUniTaskSource<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`3<T8, T9, T10>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000AF")]
		private sealed class <>c
		{
			[Token(Token = "0x40001F2")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> <>9; //Field offset: 0x0
			[Token(Token = "0x40001F3")]
			public static Action<Object> <>9__12_0; //Field offset: 0x0
			[Token(Token = "0x40001F4")]
			public static Action<Object> <>9__12_1; //Field offset: 0x0
			[Token(Token = "0x40001F5")]
			public static Action<Object> <>9__12_2; //Field offset: 0x0
			[Token(Token = "0x40001F6")]
			public static Action<Object> <>9__12_3; //Field offset: 0x0
			[Token(Token = "0x40001F7")]
			public static Action<Object> <>9__12_4; //Field offset: 0x0
			[Token(Token = "0x40001F8")]
			public static Action<Object> <>9__12_5; //Field offset: 0x0
			[Token(Token = "0x40001F9")]
			public static Action<Object> <>9__12_6; //Field offset: 0x0
			[Token(Token = "0x40001FA")]
			public static Action<Object> <>9__12_7; //Field offset: 0x0
			[Token(Token = "0x40001FB")]
			public static Action<Object> <>9__12_8; //Field offset: 0x0
			[Token(Token = "0x40001FC")]
			public static Action<Object> <>9__12_9; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x60003A3")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60003A4")]
			public <>c() { }

			[Address(RVA = "0xA3A2F0", Offset = "0xA396F0", Length = "0x174")]
			[Token(Token = "0x60003A5")]
			internal void <.ctor>b__12_0(object state) { }

			[Address(RVA = "0xA3A470", Offset = "0xA39870", Length = "0x174")]
			[Token(Token = "0x60003A6")]
			internal void <.ctor>b__12_1(object state) { }

			[Address(RVA = "0xA3A5F0", Offset = "0xA399F0", Length = "0x174")]
			[Token(Token = "0x60003A7")]
			internal void <.ctor>b__12_2(object state) { }

			[Address(RVA = "0xA3A770", Offset = "0xA39B70", Length = "0x183")]
			[Token(Token = "0x60003A8")]
			internal void <.ctor>b__12_3(object state) { }

			[Address(RVA = "0xA3A900", Offset = "0xA39D00", Length = "0x183")]
			[Token(Token = "0x60003A9")]
			internal void <.ctor>b__12_4(object state) { }

			[Address(RVA = "0xA3AA90", Offset = "0xA39E90", Length = "0x183")]
			[Token(Token = "0x60003AA")]
			internal void <.ctor>b__12_5(object state) { }

			[Address(RVA = "0xA3AC20", Offset = "0xA3A020", Length = "0x183")]
			[Token(Token = "0x60003AB")]
			internal void <.ctor>b__12_6(object state) { }

			[Address(RVA = "0xA3ADB0", Offset = "0xA3A1B0", Length = "0x183")]
			[Token(Token = "0x60003AC")]
			internal void <.ctor>b__12_7(object state) { }

			[Address(RVA = "0xA3AF40", Offset = "0xA3A340", Length = "0x183")]
			[Token(Token = "0x60003AD")]
			internal void <.ctor>b__12_8(object state) { }

			[Address(RVA = "0xA3B0D0", Offset = "0xA3A4D0", Length = "0x183")]
			[Token(Token = "0x60003AE")]
			internal void <.ctor>b__12_9(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E6")]
		private T1 t1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E7")]
		private T2 t2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E8")]
		private T3 t3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001E9")]
		private T4 t4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001EA")]
		private T5 t5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001EB")]
		private T6 t6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001EC")]
		private T7 t7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001ED")]
		private T8 t8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001EE")]
		private T9 t9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001EF")]
		private T10 t10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F0")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001F1")]
		private UniTaskCompletionSourceCore<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`3<T8, T9, T10>>> core; //Field offset: 0x0

		[Address(RVA = "0x1424A80", Offset = "0x1423E80", Length = "0x1E70")]
		[Token(Token = "0x6000393")]
		public WhenAllPromise`10(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10) { }

		[Address(RVA = "0x141B3C0", Offset = "0x141A7C0", Length = "0xB8")]
		[Token(Token = "0x600039F")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x141B480", Offset = "0x141A880", Length = "0x130")]
		[Token(Token = "0x600039E")]
		public override ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`3<T8, T9, T10>> GetResult(short token) { }

		[Address(RVA = "0x141B5B0", Offset = "0x141A9B0", Length = "0x6D")]
		[Token(Token = "0x60003A0")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x141B620", Offset = "0x141AA20", Length = "0x98")]
		[Token(Token = "0x60003A2")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x141C570", Offset = "0x141B970", Length = "0xEB3")]
		[Token(Token = "0x6000394")]
		private static void TryInvokeContinuationT1(WhenAllPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x141B6C0", Offset = "0x141AAC0", Length = "0xEAF")]
		[Token(Token = "0x600039D")]
		private static void TryInvokeContinuationT10(WhenAllPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T10> awaiter) { }

		[Address(RVA = "0x141D430", Offset = "0x141C830", Length = "0xEB7")]
		[Token(Token = "0x6000395")]
		private static void TryInvokeContinuationT2(WhenAllPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x141E2F0", Offset = "0x141D6F0", Length = "0xEB7")]
		[Token(Token = "0x6000396")]
		private static void TryInvokeContinuationT3(WhenAllPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x141F1B0", Offset = "0x141E5B0", Length = "0xEB7")]
		[Token(Token = "0x6000397")]
		private static void TryInvokeContinuationT4(WhenAllPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x1420070", Offset = "0x141F470", Length = "0xEB7")]
		[Token(Token = "0x6000398")]
		private static void TryInvokeContinuationT5(WhenAllPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x1420F30", Offset = "0x1420330", Length = "0xEB8")]
		[Token(Token = "0x6000399")]
		private static void TryInvokeContinuationT6(WhenAllPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x1421DF0", Offset = "0x14211F0", Length = "0xEB8")]
		[Token(Token = "0x600039A")]
		private static void TryInvokeContinuationT7(WhenAllPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x1422CB0", Offset = "0x14220B0", Length = "0xEAF")]
		[Token(Token = "0x600039B")]
		private static void TryInvokeContinuationT8(WhenAllPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x1423B60", Offset = "0x1422F60", Length = "0xEB1")]
		[Token(Token = "0x600039C")]
		private static void TryInvokeContinuationT9(WhenAllPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T9> awaiter) { }

		[Address(RVA = "0x1424A20", Offset = "0x1423E20", Length = "0x5D")]
		[Token(Token = "0x60003A1")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000B0")]
	private sealed class WhenAllPromise1 : IUniTaskSource<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`4<T8, T9, T10, T11>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000B1")]
		private sealed class <>c
		{
			[Token(Token = "0x400020A")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> <>9; //Field offset: 0x0
			[Token(Token = "0x400020B")]
			public static Action<Object> <>9__13_0; //Field offset: 0x0
			[Token(Token = "0x400020C")]
			public static Action<Object> <>9__13_1; //Field offset: 0x0
			[Token(Token = "0x400020D")]
			public static Action<Object> <>9__13_2; //Field offset: 0x0
			[Token(Token = "0x400020E")]
			public static Action<Object> <>9__13_3; //Field offset: 0x0
			[Token(Token = "0x400020F")]
			public static Action<Object> <>9__13_4; //Field offset: 0x0
			[Token(Token = "0x4000210")]
			public static Action<Object> <>9__13_5; //Field offset: 0x0
			[Token(Token = "0x4000211")]
			public static Action<Object> <>9__13_6; //Field offset: 0x0
			[Token(Token = "0x4000212")]
			public static Action<Object> <>9__13_7; //Field offset: 0x0
			[Token(Token = "0x4000213")]
			public static Action<Object> <>9__13_8; //Field offset: 0x0
			[Token(Token = "0x4000214")]
			public static Action<Object> <>9__13_9; //Field offset: 0x0
			[Token(Token = "0x4000215")]
			public static Action<Object> <>9__13_10; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x60003C0")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60003C1")]
			public <>c() { }

			[Address(RVA = "0xA3B260", Offset = "0xA3A660", Length = "0x174")]
			[Token(Token = "0x60003C2")]
			internal void <.ctor>b__13_0(object state) { }

			[Address(RVA = "0xA3B570", Offset = "0xA3A970", Length = "0x174")]
			[Token(Token = "0x60003C3")]
			internal void <.ctor>b__13_1(object state) { }

			[Address(RVA = "0xA3B3E0", Offset = "0xA3A7E0", Length = "0x183")]
			[Token(Token = "0x60003CC")]
			internal void <.ctor>b__13_10(object state) { }

			[Address(RVA = "0xA3B6F0", Offset = "0xA3AAF0", Length = "0x174")]
			[Token(Token = "0x60003C4")]
			internal void <.ctor>b__13_2(object state) { }

			[Address(RVA = "0xA3B870", Offset = "0xA3AC70", Length = "0x183")]
			[Token(Token = "0x60003C5")]
			internal void <.ctor>b__13_3(object state) { }

			[Address(RVA = "0xA3BA00", Offset = "0xA3AE00", Length = "0x183")]
			[Token(Token = "0x60003C6")]
			internal void <.ctor>b__13_4(object state) { }

			[Address(RVA = "0xA3BB90", Offset = "0xA3AF90", Length = "0x183")]
			[Token(Token = "0x60003C7")]
			internal void <.ctor>b__13_5(object state) { }

			[Address(RVA = "0xA3BD20", Offset = "0xA3B120", Length = "0x183")]
			[Token(Token = "0x60003C8")]
			internal void <.ctor>b__13_6(object state) { }

			[Address(RVA = "0xA3BEB0", Offset = "0xA3B2B0", Length = "0x183")]
			[Token(Token = "0x60003C9")]
			internal void <.ctor>b__13_7(object state) { }

			[Address(RVA = "0xA3C040", Offset = "0xA3B440", Length = "0x183")]
			[Token(Token = "0x60003CA")]
			internal void <.ctor>b__13_8(object state) { }

			[Address(RVA = "0xA3C1D0", Offset = "0xA3B5D0", Length = "0x183")]
			[Token(Token = "0x60003CB")]
			internal void <.ctor>b__13_9(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001FD")]
		private T1 t1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001FE")]
		private T2 t2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001FF")]
		private T3 t3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000200")]
		private T4 t4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000201")]
		private T5 t5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000202")]
		private T6 t6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000203")]
		private T7 t7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000204")]
		private T8 t8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000205")]
		private T9 t9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000206")]
		private T10 t10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000207")]
		private T11 t11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000208")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000209")]
		private UniTaskCompletionSourceCore<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`4<T8, T9, T10, T11>>> core; //Field offset: 0x0

		[Address(RVA = "0x1431AE0", Offset = "0x1430EE0", Length = "0x217B")]
		[Token(Token = "0x60003AF")]
		public WhenAllPromise`11(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11) { }

		[Address(RVA = "0x14268F0", Offset = "0x1425CF0", Length = "0xB8")]
		[Token(Token = "0x60003BC")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x14269B0", Offset = "0x1425DB0", Length = "0x130")]
		[Token(Token = "0x60003BB")]
		public override ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`4<T8, T9, T10, T11>> GetResult(short token) { }

		[Address(RVA = "0x1426AE0", Offset = "0x1425EE0", Length = "0x6D")]
		[Token(Token = "0x60003BD")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1426B50", Offset = "0x1425F50", Length = "0x98")]
		[Token(Token = "0x60003BF")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1428BB0", Offset = "0x1427FB0", Length = "0xFD2")]
		[Token(Token = "0x60003B0")]
		private static void TryInvokeContinuationT1(WhenAllPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x1426BF0", Offset = "0x1425FF0", Length = "0xFD2")]
		[Token(Token = "0x60003B9")]
		private static void TryInvokeContinuationT10(WhenAllPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T10> awaiter) { }

		[Address(RVA = "0x1427BD0", Offset = "0x1426FD0", Length = "0xFD0")]
		[Token(Token = "0x60003BA")]
		private static void TryInvokeContinuationT11(WhenAllPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T11> awaiter) { }

		[Address(RVA = "0x1429B90", Offset = "0x1428F90", Length = "0xFD6")]
		[Token(Token = "0x60003B1")]
		private static void TryInvokeContinuationT2(WhenAllPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x142AB70", Offset = "0x1429F70", Length = "0xFD6")]
		[Token(Token = "0x60003B2")]
		private static void TryInvokeContinuationT3(WhenAllPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x142BB50", Offset = "0x142AF50", Length = "0xFD6")]
		[Token(Token = "0x60003B3")]
		private static void TryInvokeContinuationT4(WhenAllPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x142CB30", Offset = "0x142BF30", Length = "0xFD6")]
		[Token(Token = "0x60003B4")]
		private static void TryInvokeContinuationT5(WhenAllPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x142DB10", Offset = "0x142CF10", Length = "0xFDA")]
		[Token(Token = "0x60003B5")]
		private static void TryInvokeContinuationT6(WhenAllPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x142EAF0", Offset = "0x142DEF0", Length = "0xFD7")]
		[Token(Token = "0x60003B6")]
		private static void TryInvokeContinuationT7(WhenAllPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x142FAD0", Offset = "0x142EED0", Length = "0xFD6")]
		[Token(Token = "0x60003B7")]
		private static void TryInvokeContinuationT8(WhenAllPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x1430AB0", Offset = "0x142FEB0", Length = "0xFCA")]
		[Token(Token = "0x60003B8")]
		private static void TryInvokeContinuationT9(WhenAllPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T9> awaiter) { }

		[Address(RVA = "0x1431A80", Offset = "0x1430E80", Length = "0x5D")]
		[Token(Token = "0x60003BE")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000B2")]
	private sealed class WhenAllPromise2 : IUniTaskSource<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`5<T8, T9, T10, T11, T12>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000B3")]
		private sealed class <>c
		{
			[Token(Token = "0x4000224")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> <>9; //Field offset: 0x0
			[Token(Token = "0x4000225")]
			public static Action<Object> <>9__14_0; //Field offset: 0x0
			[Token(Token = "0x4000226")]
			public static Action<Object> <>9__14_1; //Field offset: 0x0
			[Token(Token = "0x4000227")]
			public static Action<Object> <>9__14_2; //Field offset: 0x0
			[Token(Token = "0x4000228")]
			public static Action<Object> <>9__14_3; //Field offset: 0x0
			[Token(Token = "0x4000229")]
			public static Action<Object> <>9__14_4; //Field offset: 0x0
			[Token(Token = "0x400022A")]
			public static Action<Object> <>9__14_5; //Field offset: 0x0
			[Token(Token = "0x400022B")]
			public static Action<Object> <>9__14_6; //Field offset: 0x0
			[Token(Token = "0x400022C")]
			public static Action<Object> <>9__14_7; //Field offset: 0x0
			[Token(Token = "0x400022D")]
			public static Action<Object> <>9__14_8; //Field offset: 0x0
			[Token(Token = "0x400022E")]
			public static Action<Object> <>9__14_9; //Field offset: 0x0
			[Token(Token = "0x400022F")]
			public static Action<Object> <>9__14_10; //Field offset: 0x0
			[Token(Token = "0x4000230")]
			public static Action<Object> <>9__14_11; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x60003DF")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60003E0")]
			public <>c() { }

			[Address(RVA = "0xA3C360", Offset = "0xA3B760", Length = "0x174")]
			[Token(Token = "0x60003E1")]
			internal void <.ctor>b__14_0(object state) { }

			[Address(RVA = "0xA3C800", Offset = "0xA3BC00", Length = "0x174")]
			[Token(Token = "0x60003E2")]
			internal void <.ctor>b__14_1(object state) { }

			[Address(RVA = "0xA3C4E0", Offset = "0xA3B8E0", Length = "0x183")]
			[Token(Token = "0x60003EB")]
			internal void <.ctor>b__14_10(object state) { }

			[Address(RVA = "0xA3C670", Offset = "0xA3BA70", Length = "0x183")]
			[Token(Token = "0x60003EC")]
			internal void <.ctor>b__14_11(object state) { }

			[Address(RVA = "0xA3C980", Offset = "0xA3BD80", Length = "0x174")]
			[Token(Token = "0x60003E3")]
			internal void <.ctor>b__14_2(object state) { }

			[Address(RVA = "0xA3CB00", Offset = "0xA3BF00", Length = "0x183")]
			[Token(Token = "0x60003E4")]
			internal void <.ctor>b__14_3(object state) { }

			[Address(RVA = "0xA3CC90", Offset = "0xA3C090", Length = "0x183")]
			[Token(Token = "0x60003E5")]
			internal void <.ctor>b__14_4(object state) { }

			[Address(RVA = "0xA3CE20", Offset = "0xA3C220", Length = "0x183")]
			[Token(Token = "0x60003E6")]
			internal void <.ctor>b__14_5(object state) { }

			[Address(RVA = "0xA3CFB0", Offset = "0xA3C3B0", Length = "0x183")]
			[Token(Token = "0x60003E7")]
			internal void <.ctor>b__14_6(object state) { }

			[Address(RVA = "0xA3D140", Offset = "0xA3C540", Length = "0x183")]
			[Token(Token = "0x60003E8")]
			internal void <.ctor>b__14_7(object state) { }

			[Address(RVA = "0xA3D2D0", Offset = "0xA3C6D0", Length = "0x183")]
			[Token(Token = "0x60003E9")]
			internal void <.ctor>b__14_8(object state) { }

			[Address(RVA = "0xA3D460", Offset = "0xA3C860", Length = "0x183")]
			[Token(Token = "0x60003EA")]
			internal void <.ctor>b__14_9(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000216")]
		private T1 t1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000217")]
		private T2 t2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000218")]
		private T3 t3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000219")]
		private T4 t4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400021A")]
		private T5 t5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400021B")]
		private T6 t6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400021C")]
		private T7 t7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400021D")]
		private T8 t8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400021E")]
		private T9 t9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400021F")]
		private T10 t10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000220")]
		private T11 t11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000221")]
		private T12 t12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000222")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000223")]
		private UniTaskCompletionSourceCore<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`5<T8, T9, T10, T11, T12>>> core; //Field offset: 0x0

		[Address(RVA = "0x1440BC0", Offset = "0x143FFC0", Length = "0x2495")]
		[Token(Token = "0x60003CD")]
		public WhenAllPromise`12(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12) { }

		[Address(RVA = "0x1433C60", Offset = "0x1433060", Length = "0xB8")]
		[Token(Token = "0x60003DB")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1433D20", Offset = "0x1433120", Length = "0x130")]
		[Token(Token = "0x60003DA")]
		public override ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`5<T8, T9, T10, T11, T12>> GetResult(short token) { }

		[Address(RVA = "0x1433E50", Offset = "0x1433250", Length = "0x6D")]
		[Token(Token = "0x60003DC")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1433EC0", Offset = "0x14332C0", Length = "0x98")]
		[Token(Token = "0x60003DE")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1437260", Offset = "0x1436660", Length = "0x10F0")]
		[Token(Token = "0x60003CE")]
		private static void TryInvokeContinuationT1(WhenAllPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x1433F60", Offset = "0x1433360", Length = "0x10F0")]
		[Token(Token = "0x60003D7")]
		private static void TryInvokeContinuationT10(WhenAllPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T10> awaiter) { }

		[Address(RVA = "0x1435060", Offset = "0x1434460", Length = "0x10F5")]
		[Token(Token = "0x60003D8")]
		private static void TryInvokeContinuationT11(WhenAllPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T11> awaiter) { }

		[Address(RVA = "0x1436160", Offset = "0x1435560", Length = "0x10F4")]
		[Token(Token = "0x60003D9")]
		private static void TryInvokeContinuationT12(WhenAllPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T12> awaiter) { }

		[Address(RVA = "0x1438360", Offset = "0x1437760", Length = "0x10F4")]
		[Token(Token = "0x60003CF")]
		private static void TryInvokeContinuationT2(WhenAllPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1439460", Offset = "0x1438860", Length = "0x10F4")]
		[Token(Token = "0x60003D0")]
		private static void TryInvokeContinuationT3(WhenAllPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x143A560", Offset = "0x1439960", Length = "0x10F4")]
		[Token(Token = "0x60003D1")]
		private static void TryInvokeContinuationT4(WhenAllPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x143B660", Offset = "0x143AA60", Length = "0x10F4")]
		[Token(Token = "0x60003D2")]
		private static void TryInvokeContinuationT5(WhenAllPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x143C760", Offset = "0x143BB60", Length = "0x10F8")]
		[Token(Token = "0x60003D3")]
		private static void TryInvokeContinuationT6(WhenAllPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x143D860", Offset = "0x143CC60", Length = "0x10F8")]
		[Token(Token = "0x60003D4")]
		private static void TryInvokeContinuationT7(WhenAllPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x143E960", Offset = "0x143DD60", Length = "0x10F4")]
		[Token(Token = "0x60003D5")]
		private static void TryInvokeContinuationT8(WhenAllPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x143FA60", Offset = "0x143EE60", Length = "0x10F1")]
		[Token(Token = "0x60003D6")]
		private static void TryInvokeContinuationT9(WhenAllPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T9> awaiter) { }

		[Address(RVA = "0x1440B60", Offset = "0x143FF60", Length = "0x5D")]
		[Token(Token = "0x60003DD")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000B4")]
	private sealed class WhenAllPromise3 : IUniTaskSource<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`6<T8, T9, T10, T11, T12, T13>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000B5")]
		private sealed class <>c
		{
			[Token(Token = "0x4000240")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> <>9; //Field offset: 0x0
			[Token(Token = "0x4000241")]
			public static Action<Object> <>9__15_0; //Field offset: 0x0
			[Token(Token = "0x4000242")]
			public static Action<Object> <>9__15_1; //Field offset: 0x0
			[Token(Token = "0x4000243")]
			public static Action<Object> <>9__15_2; //Field offset: 0x0
			[Token(Token = "0x4000244")]
			public static Action<Object> <>9__15_3; //Field offset: 0x0
			[Token(Token = "0x4000245")]
			public static Action<Object> <>9__15_4; //Field offset: 0x0
			[Token(Token = "0x4000246")]
			public static Action<Object> <>9__15_5; //Field offset: 0x0
			[Token(Token = "0x4000247")]
			public static Action<Object> <>9__15_6; //Field offset: 0x0
			[Token(Token = "0x4000248")]
			public static Action<Object> <>9__15_7; //Field offset: 0x0
			[Token(Token = "0x4000249")]
			public static Action<Object> <>9__15_8; //Field offset: 0x0
			[Token(Token = "0x400024A")]
			public static Action<Object> <>9__15_9; //Field offset: 0x0
			[Token(Token = "0x400024B")]
			public static Action<Object> <>9__15_10; //Field offset: 0x0
			[Token(Token = "0x400024C")]
			public static Action<Object> <>9__15_11; //Field offset: 0x0
			[Token(Token = "0x400024D")]
			public static Action<Object> <>9__15_12; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x6000400")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000401")]
			public <>c() { }

			[Address(RVA = "0xA3D5F0", Offset = "0xA3C9F0", Length = "0x174")]
			[Token(Token = "0x6000402")]
			internal void <.ctor>b__15_0(object state) { }

			[Address(RVA = "0xA3DC20", Offset = "0xA3D020", Length = "0x174")]
			[Token(Token = "0x6000403")]
			internal void <.ctor>b__15_1(object state) { }

			[Address(RVA = "0xA3D770", Offset = "0xA3CB70", Length = "0x183")]
			[Token(Token = "0x600040C")]
			internal void <.ctor>b__15_10(object state) { }

			[Address(RVA = "0xA3D900", Offset = "0xA3CD00", Length = "0x183")]
			[Token(Token = "0x600040D")]
			internal void <.ctor>b__15_11(object state) { }

			[Address(RVA = "0xA3DA90", Offset = "0xA3CE90", Length = "0x183")]
			[Token(Token = "0x600040E")]
			internal void <.ctor>b__15_12(object state) { }

			[Address(RVA = "0xA3DDA0", Offset = "0xA3D1A0", Length = "0x174")]
			[Token(Token = "0x6000404")]
			internal void <.ctor>b__15_2(object state) { }

			[Address(RVA = "0xA3DF20", Offset = "0xA3D320", Length = "0x183")]
			[Token(Token = "0x6000405")]
			internal void <.ctor>b__15_3(object state) { }

			[Address(RVA = "0xA3E0B0", Offset = "0xA3D4B0", Length = "0x183")]
			[Token(Token = "0x6000406")]
			internal void <.ctor>b__15_4(object state) { }

			[Address(RVA = "0xA3E240", Offset = "0xA3D640", Length = "0x183")]
			[Token(Token = "0x6000407")]
			internal void <.ctor>b__15_5(object state) { }

			[Address(RVA = "0xA3E3D0", Offset = "0xA3D7D0", Length = "0x183")]
			[Token(Token = "0x6000408")]
			internal void <.ctor>b__15_6(object state) { }

			[Address(RVA = "0xA3E560", Offset = "0xA3D960", Length = "0x183")]
			[Token(Token = "0x6000409")]
			internal void <.ctor>b__15_7(object state) { }

			[Address(RVA = "0xA3E6F0", Offset = "0xA3DAF0", Length = "0x183")]
			[Token(Token = "0x600040A")]
			internal void <.ctor>b__15_8(object state) { }

			[Address(RVA = "0xA3E880", Offset = "0xA3DC80", Length = "0x183")]
			[Token(Token = "0x600040B")]
			internal void <.ctor>b__15_9(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000231")]
		private T1 t1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000232")]
		private T2 t2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000233")]
		private T3 t3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000234")]
		private T4 t4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000235")]
		private T5 t5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000236")]
		private T6 t6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000237")]
		private T7 t7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000238")]
		private T8 t8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000239")]
		private T9 t9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023A")]
		private T10 t10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023B")]
		private T11 t11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023C")]
		private T12 t12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023D")]
		private T13 t13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023E")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023F")]
		private UniTaskCompletionSourceCore<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`6<T8, T9, T10, T11, T12, T13>>> core; //Field offset: 0x0

		[Address(RVA = "0x1451E90", Offset = "0x1451290", Length = "0x279F")]
		[Token(Token = "0x60003ED")]
		public WhenAllPromise`13(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13) { }

		[Address(RVA = "0x1443060", Offset = "0x1442460", Length = "0xB8")]
		[Token(Token = "0x60003FC")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1443120", Offset = "0x1442520", Length = "0x130")]
		[Token(Token = "0x60003FB")]
		public override ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`6<T8, T9, T10, T11, T12, T13>> GetResult(short token) { }

		[Address(RVA = "0x1443250", Offset = "0x1442650", Length = "0x6D")]
		[Token(Token = "0x60003FD")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x14432C0", Offset = "0x14426C0", Length = "0x98")]
		[Token(Token = "0x60003FF")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1447BA0", Offset = "0x1446FA0", Length = "0x1203")]
		[Token(Token = "0x60003EE")]
		private static void TryInvokeContinuationT1(WhenAllPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x1443360", Offset = "0x1442760", Length = "0x1202")]
		[Token(Token = "0x60003F7")]
		private static void TryInvokeContinuationT10(WhenAllPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T10> awaiter) { }

		[Address(RVA = "0x1444570", Offset = "0x1443970", Length = "0x120D")]
		[Token(Token = "0x60003F8")]
		private static void TryInvokeContinuationT11(WhenAllPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T11> awaiter) { }

		[Address(RVA = "0x1445780", Offset = "0x1444B80", Length = "0x1200")]
		[Token(Token = "0x60003F9")]
		private static void TryInvokeContinuationT12(WhenAllPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T12> awaiter) { }

		[Address(RVA = "0x1446990", Offset = "0x1445D90", Length = "0x1200")]
		[Token(Token = "0x60003FA")]
		private static void TryInvokeContinuationT13(WhenAllPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T13> awaiter) { }

		[Address(RVA = "0x1448DB0", Offset = "0x14481B0", Length = "0x1207")]
		[Token(Token = "0x60003EF")]
		private static void TryInvokeContinuationT2(WhenAllPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1449FC0", Offset = "0x14493C0", Length = "0x1207")]
		[Token(Token = "0x60003F0")]
		private static void TryInvokeContinuationT3(WhenAllPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x144B1D0", Offset = "0x144A5D0", Length = "0x1207")]
		[Token(Token = "0x60003F1")]
		private static void TryInvokeContinuationT4(WhenAllPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x144C3E0", Offset = "0x144B7E0", Length = "0x1207")]
		[Token(Token = "0x60003F2")]
		private static void TryInvokeContinuationT5(WhenAllPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x144D5F0", Offset = "0x144C9F0", Length = "0x120F")]
		[Token(Token = "0x60003F3")]
		private static void TryInvokeContinuationT6(WhenAllPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x144E800", Offset = "0x144DC00", Length = "0x120F")]
		[Token(Token = "0x60003F4")]
		private static void TryInvokeContinuationT7(WhenAllPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x144FA10", Offset = "0x144EE10", Length = "0x120E")]
		[Token(Token = "0x60003F5")]
		private static void TryInvokeContinuationT8(WhenAllPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x1450C20", Offset = "0x1450020", Length = "0x120B")]
		[Token(Token = "0x60003F6")]
		private static void TryInvokeContinuationT9(WhenAllPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T9> awaiter) { }

		[Address(RVA = "0x1451E30", Offset = "0x1451230", Length = "0x5D")]
		[Token(Token = "0x60003FE")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000B6")]
	private sealed class WhenAllPromise4 : IUniTaskSource<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`7<T8, T9, T10, T11, T12, T13, T14>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000B7")]
		private sealed class <>c
		{
			[Token(Token = "0x400025E")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> <>9; //Field offset: 0x0
			[Token(Token = "0x400025F")]
			public static Action<Object> <>9__16_0; //Field offset: 0x0
			[Token(Token = "0x4000260")]
			public static Action<Object> <>9__16_1; //Field offset: 0x0
			[Token(Token = "0x4000261")]
			public static Action<Object> <>9__16_2; //Field offset: 0x0
			[Token(Token = "0x4000262")]
			public static Action<Object> <>9__16_3; //Field offset: 0x0
			[Token(Token = "0x4000263")]
			public static Action<Object> <>9__16_4; //Field offset: 0x0
			[Token(Token = "0x4000264")]
			public static Action<Object> <>9__16_5; //Field offset: 0x0
			[Token(Token = "0x4000265")]
			public static Action<Object> <>9__16_6; //Field offset: 0x0
			[Token(Token = "0x4000266")]
			public static Action<Object> <>9__16_7; //Field offset: 0x0
			[Token(Token = "0x4000267")]
			public static Action<Object> <>9__16_8; //Field offset: 0x0
			[Token(Token = "0x4000268")]
			public static Action<Object> <>9__16_9; //Field offset: 0x0
			[Token(Token = "0x4000269")]
			public static Action<Object> <>9__16_10; //Field offset: 0x0
			[Token(Token = "0x400026A")]
			public static Action<Object> <>9__16_11; //Field offset: 0x0
			[Token(Token = "0x400026B")]
			public static Action<Object> <>9__16_12; //Field offset: 0x0
			[Token(Token = "0x400026C")]
			public static Action<Object> <>9__16_13; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x6000423")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000424")]
			public <>c() { }

			[Address(RVA = "0xA3EA10", Offset = "0xA3DE10", Length = "0x174")]
			[Token(Token = "0x6000425")]
			internal void <.ctor>b__16_0(object state) { }

			[Address(RVA = "0xA3F1D0", Offset = "0xA3E5D0", Length = "0x174")]
			[Token(Token = "0x6000426")]
			internal void <.ctor>b__16_1(object state) { }

			[Address(RVA = "0xA3EB90", Offset = "0xA3DF90", Length = "0x183")]
			[Token(Token = "0x600042F")]
			internal void <.ctor>b__16_10(object state) { }

			[Address(RVA = "0xA3ED20", Offset = "0xA3E120", Length = "0x183")]
			[Token(Token = "0x6000430")]
			internal void <.ctor>b__16_11(object state) { }

			[Address(RVA = "0xA3EEB0", Offset = "0xA3E2B0", Length = "0x183")]
			[Token(Token = "0x6000431")]
			internal void <.ctor>b__16_12(object state) { }

			[Address(RVA = "0xA3F040", Offset = "0xA3E440", Length = "0x183")]
			[Token(Token = "0x6000432")]
			internal void <.ctor>b__16_13(object state) { }

			[Address(RVA = "0xA3F350", Offset = "0xA3E750", Length = "0x174")]
			[Token(Token = "0x6000427")]
			internal void <.ctor>b__16_2(object state) { }

			[Address(RVA = "0xA3F4D0", Offset = "0xA3E8D0", Length = "0x183")]
			[Token(Token = "0x6000428")]
			internal void <.ctor>b__16_3(object state) { }

			[Address(RVA = "0xA3F660", Offset = "0xA3EA60", Length = "0x183")]
			[Token(Token = "0x6000429")]
			internal void <.ctor>b__16_4(object state) { }

			[Address(RVA = "0xA3F7F0", Offset = "0xA3EBF0", Length = "0x183")]
			[Token(Token = "0x600042A")]
			internal void <.ctor>b__16_5(object state) { }

			[Address(RVA = "0xA3F980", Offset = "0xA3ED80", Length = "0x183")]
			[Token(Token = "0x600042B")]
			internal void <.ctor>b__16_6(object state) { }

			[Address(RVA = "0xA3FB10", Offset = "0xA3EF10", Length = "0x183")]
			[Token(Token = "0x600042C")]
			internal void <.ctor>b__16_7(object state) { }

			[Address(RVA = "0xA3FCA0", Offset = "0xA3F0A0", Length = "0x183")]
			[Token(Token = "0x600042D")]
			internal void <.ctor>b__16_8(object state) { }

			[Address(RVA = "0xA3FE30", Offset = "0xA3F230", Length = "0x183")]
			[Token(Token = "0x600042E")]
			internal void <.ctor>b__16_9(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400024E")]
		private T1 t1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400024F")]
		private T2 t2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000250")]
		private T3 t3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000251")]
		private T4 t4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000252")]
		private T5 t5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000253")]
		private T6 t6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000254")]
		private T7 t7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000255")]
		private T8 t8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000256")]
		private T9 t9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000257")]
		private T10 t10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000258")]
		private T11 t11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000259")]
		private T12 t12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400025A")]
		private T13 t13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400025B")]
		private T14 t14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400025C")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400025D")]
		private UniTaskCompletionSourceCore<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`7<T8, T9, T10, T11, T12, T13, T14>>> core; //Field offset: 0x0

		[Address(RVA = "0x1466B40", Offset = "0x1465F40", Length = "0x2AB9")]
		[Token(Token = "0x600040F")]
		public WhenAllPromise`14(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14) { }

		[Address(RVA = "0x1455A70", Offset = "0x1454E70", Length = "0xB8")]
		[Token(Token = "0x600041F")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1455B30", Offset = "0x1454F30", Length = "0x130")]
		[Token(Token = "0x600041E")]
		public override ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`7<T8, T9, T10, T11, T12, T13, T14>> GetResult(short token) { }

		[Address(RVA = "0x1455C60", Offset = "0x1455060", Length = "0x6D")]
		[Token(Token = "0x6000420")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1455CD0", Offset = "0x14550D0", Length = "0x98")]
		[Token(Token = "0x6000422")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x145BDA0", Offset = "0x145B1A0", Length = "0x1333")]
		[Token(Token = "0x6000410")]
		private static void TryInvokeContinuationT1(WhenAllPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x1455D70", Offset = "0x1455170", Length = "0x133B")]
		[Token(Token = "0x6000419")]
		private static void TryInvokeContinuationT10(WhenAllPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T10> awaiter) { }

		[Address(RVA = "0x14570B0", Offset = "0x14564B0", Length = "0x1337")]
		[Token(Token = "0x600041A")]
		private static void TryInvokeContinuationT11(WhenAllPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T11> awaiter) { }

		[Address(RVA = "0x14583F0", Offset = "0x14577F0", Length = "0x1329")]
		[Token(Token = "0x600041B")]
		private static void TryInvokeContinuationT12(WhenAllPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T12> awaiter) { }

		[Address(RVA = "0x1459720", Offset = "0x1458B20", Length = "0x1330")]
		[Token(Token = "0x600041C")]
		private static void TryInvokeContinuationT13(WhenAllPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T13> awaiter) { }

		[Address(RVA = "0x145AA60", Offset = "0x1459E60", Length = "0x1330")]
		[Token(Token = "0x600041D")]
		private static void TryInvokeContinuationT14(WhenAllPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T14> awaiter) { }

		[Address(RVA = "0x145D0E0", Offset = "0x145C4E0", Length = "0x1337")]
		[Token(Token = "0x6000411")]
		private static void TryInvokeContinuationT2(WhenAllPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x145E420", Offset = "0x145D820", Length = "0x1337")]
		[Token(Token = "0x6000412")]
		private static void TryInvokeContinuationT3(WhenAllPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x145F760", Offset = "0x145EB60", Length = "0x1337")]
		[Token(Token = "0x6000413")]
		private static void TryInvokeContinuationT4(WhenAllPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x1460AA0", Offset = "0x145FEA0", Length = "0x1337")]
		[Token(Token = "0x6000414")]
		private static void TryInvokeContinuationT5(WhenAllPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x1461DE0", Offset = "0x14611E0", Length = "0x133F")]
		[Token(Token = "0x6000415")]
		private static void TryInvokeContinuationT6(WhenAllPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x1463120", Offset = "0x1462520", Length = "0x133F")]
		[Token(Token = "0x6000416")]
		private static void TryInvokeContinuationT7(WhenAllPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x1464460", Offset = "0x1463860", Length = "0x133E")]
		[Token(Token = "0x6000417")]
		private static void TryInvokeContinuationT8(WhenAllPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x14657A0", Offset = "0x1464BA0", Length = "0x133E")]
		[Token(Token = "0x6000418")]
		private static void TryInvokeContinuationT9(WhenAllPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T9> awaiter) { }

		[Address(RVA = "0x1466AE0", Offset = "0x1465EE0", Length = "0x5D")]
		[Token(Token = "0x6000421")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000B8")]
	private sealed class WhenAllPromise5 : IUniTaskSource<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`8<T8, T9, T10, T11, T12, T13, T14, ValueTuple`1<T15>>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000B9")]
		private sealed class <>c
		{
			[Token(Token = "0x400027E")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> <>9; //Field offset: 0x0
			[Token(Token = "0x400027F")]
			public static Action<Object> <>9__17_0; //Field offset: 0x0
			[Token(Token = "0x4000280")]
			public static Action<Object> <>9__17_1; //Field offset: 0x0
			[Token(Token = "0x4000281")]
			public static Action<Object> <>9__17_2; //Field offset: 0x0
			[Token(Token = "0x4000282")]
			public static Action<Object> <>9__17_3; //Field offset: 0x0
			[Token(Token = "0x4000283")]
			public static Action<Object> <>9__17_4; //Field offset: 0x0
			[Token(Token = "0x4000284")]
			public static Action<Object> <>9__17_5; //Field offset: 0x0
			[Token(Token = "0x4000285")]
			public static Action<Object> <>9__17_6; //Field offset: 0x0
			[Token(Token = "0x4000286")]
			public static Action<Object> <>9__17_7; //Field offset: 0x0
			[Token(Token = "0x4000287")]
			public static Action<Object> <>9__17_8; //Field offset: 0x0
			[Token(Token = "0x4000288")]
			public static Action<Object> <>9__17_9; //Field offset: 0x0
			[Token(Token = "0x4000289")]
			public static Action<Object> <>9__17_10; //Field offset: 0x0
			[Token(Token = "0x400028A")]
			public static Action<Object> <>9__17_11; //Field offset: 0x0
			[Token(Token = "0x400028B")]
			public static Action<Object> <>9__17_12; //Field offset: 0x0
			[Token(Token = "0x400028C")]
			public static Action<Object> <>9__17_13; //Field offset: 0x0
			[Token(Token = "0x400028D")]
			public static Action<Object> <>9__17_14; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x6000448")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000449")]
			public <>c() { }

			[Address(RVA = "0xA3FFC0", Offset = "0xA3F3C0", Length = "0x174")]
			[Token(Token = "0x600044A")]
			internal void <.ctor>b__17_0(object state) { }

			[Address(RVA = "0xA40910", Offset = "0xA3FD10", Length = "0x174")]
			[Token(Token = "0x600044B")]
			internal void <.ctor>b__17_1(object state) { }

			[Address(RVA = "0xA40140", Offset = "0xA3F540", Length = "0x183")]
			[Token(Token = "0x6000454")]
			internal void <.ctor>b__17_10(object state) { }

			[Address(RVA = "0xA402D0", Offset = "0xA3F6D0", Length = "0x183")]
			[Token(Token = "0x6000455")]
			internal void <.ctor>b__17_11(object state) { }

			[Address(RVA = "0xA40460", Offset = "0xA3F860", Length = "0x183")]
			[Token(Token = "0x6000456")]
			internal void <.ctor>b__17_12(object state) { }

			[Address(RVA = "0xA405F0", Offset = "0xA3F9F0", Length = "0x183")]
			[Token(Token = "0x6000457")]
			internal void <.ctor>b__17_13(object state) { }

			[Address(RVA = "0xA40780", Offset = "0xA3FB80", Length = "0x183")]
			[Token(Token = "0x6000458")]
			internal void <.ctor>b__17_14(object state) { }

			[Address(RVA = "0xA40A90", Offset = "0xA3FE90", Length = "0x174")]
			[Token(Token = "0x600044C")]
			internal void <.ctor>b__17_2(object state) { }

			[Address(RVA = "0xA40C10", Offset = "0xA40010", Length = "0x183")]
			[Token(Token = "0x600044D")]
			internal void <.ctor>b__17_3(object state) { }

			[Address(RVA = "0xA40DA0", Offset = "0xA401A0", Length = "0x183")]
			[Token(Token = "0x600044E")]
			internal void <.ctor>b__17_4(object state) { }

			[Address(RVA = "0xA40F30", Offset = "0xA40330", Length = "0x183")]
			[Token(Token = "0x600044F")]
			internal void <.ctor>b__17_5(object state) { }

			[Address(RVA = "0xA410C0", Offset = "0xA404C0", Length = "0x183")]
			[Token(Token = "0x6000450")]
			internal void <.ctor>b__17_6(object state) { }

			[Address(RVA = "0xA41250", Offset = "0xA40650", Length = "0x183")]
			[Token(Token = "0x6000451")]
			internal void <.ctor>b__17_7(object state) { }

			[Address(RVA = "0xA413E0", Offset = "0xA407E0", Length = "0x183")]
			[Token(Token = "0x6000452")]
			internal void <.ctor>b__17_8(object state) { }

			[Address(RVA = "0xA41570", Offset = "0xA40970", Length = "0x183")]
			[Token(Token = "0x6000453")]
			internal void <.ctor>b__17_9(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026D")]
		private T1 t1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400027B")]
		private T15 t15; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400027A")]
		private T14 t14; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000279")]
		private T13 t13; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000278")]
		private T12 t12; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000277")]
		private T11 t11; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000276")]
		private T10 t10; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400027C")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000275")]
		private T9 t9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000273")]
		private T7 t7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000272")]
		private T6 t6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000271")]
		private T5 t5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000270")]
		private T4 t4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026F")]
		private T3 t3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400026E")]
		private T2 t2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000274")]
		private T8 t8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400027D")]
		private UniTaskCompletionSourceCore<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`8<T8, T9, T10, T11, T12, T13, T14, ValueTuple`1<T15>>>> core; //Field offset: 0x0

		[Address(RVA = "0x147D9A0", Offset = "0x147CDA0", Length = "0x2DC4")]
		[Token(Token = "0x6000433")]
		public WhenAllPromise`15(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14, UniTask<T15> task15) { }

		[Address(RVA = "0x1469600", Offset = "0x1468A00", Length = "0xB8")]
		[Token(Token = "0x6000444")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x14696C0", Offset = "0x1468AC0", Length = "0x130")]
		[Token(Token = "0x6000443")]
		public override ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`8<T8, T9, T10, T11, T12, T13, T14, ValueTuple`1<T15>>> GetResult(short token) { }

		[Address(RVA = "0x14697F0", Offset = "0x1468BF0", Length = "0x6D")]
		[Token(Token = "0x6000445")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1469860", Offset = "0x1468C60", Length = "0x98")]
		[Token(Token = "0x6000447")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1471940", Offset = "0x1470D40", Length = "0x1546")]
		[Token(Token = "0x6000434")]
		private static void TryInvokeContinuationT1(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x1469900", Offset = "0x1468D00", Length = "0x1551")]
		[Token(Token = "0x600043D")]
		private static void TryInvokeContinuationT10(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T10> awaiter) { }

		[Address(RVA = "0x146AE60", Offset = "0x146A260", Length = "0x1551")]
		[Token(Token = "0x600043E")]
		private static void TryInvokeContinuationT11(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T11> awaiter) { }

		[Address(RVA = "0x146C3C0", Offset = "0x146B7C0", Length = "0x154E")]
		[Token(Token = "0x600043F")]
		private static void TryInvokeContinuationT12(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T12> awaiter) { }

		[Address(RVA = "0x146D910", Offset = "0x146CD10", Length = "0x158D")]
		[Token(Token = "0x6000440")]
		private static void TryInvokeContinuationT13(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T13> awaiter) { }

		[Address(RVA = "0x146EEA0", Offset = "0x146E2A0", Length = "0x1545")]
		[Token(Token = "0x6000441")]
		private static void TryInvokeContinuationT14(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T14> awaiter) { }

		[Address(RVA = "0x14703F0", Offset = "0x146F7F0", Length = "0x1548")]
		[Token(Token = "0x6000442")]
		private static void TryInvokeContinuationT15(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T15> awaiter) { }

		[Address(RVA = "0x1472E90", Offset = "0x1472290", Length = "0x154A")]
		[Token(Token = "0x6000435")]
		private static void TryInvokeContinuationT2(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x14743E0", Offset = "0x14737E0", Length = "0x154A")]
		[Token(Token = "0x6000436")]
		private static void TryInvokeContinuationT3(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x1475930", Offset = "0x1474D30", Length = "0x154A")]
		[Token(Token = "0x6000437")]
		private static void TryInvokeContinuationT4(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x1476E80", Offset = "0x1476280", Length = "0x154A")]
		[Token(Token = "0x6000438")]
		private static void TryInvokeContinuationT5(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x14783D0", Offset = "0x14777D0", Length = "0x154E")]
		[Token(Token = "0x6000439")]
		private static void TryInvokeContinuationT6(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x1479920", Offset = "0x1478D20", Length = "0x1552")]
		[Token(Token = "0x600043A")]
		private static void TryInvokeContinuationT7(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x147AE80", Offset = "0x147A280", Length = "0x1551")]
		[Token(Token = "0x600043B")]
		private static void TryInvokeContinuationT8(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x147C3E0", Offset = "0x147B7E0", Length = "0x1551")]
		[Token(Token = "0x600043C")]
		private static void TryInvokeContinuationT9(WhenAllPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T9> awaiter) { }

		[Address(RVA = "0x147D940", Offset = "0x147CD40", Length = "0x5D")]
		[Token(Token = "0x6000446")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x200009E")]
	private sealed class WhenAllPromise : IUniTaskSource<ValueTuple`2<T1, T2>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x200009F")]
		private sealed class <>c
		{
			[Token(Token = "0x400017A")]
			public static readonly <>c<T1, T2> <>9; //Field offset: 0x0
			[Token(Token = "0x400017B")]
			public static Action<Object> <>9__4_0; //Field offset: 0x0
			[Token(Token = "0x400017C")]
			public static Action<Object> <>9__4_1; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x6000303")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000304")]
			public <>c() { }

			[Address(RVA = "0xA4D900", Offset = "0xA4CD00", Length = "0x174")]
			[Token(Token = "0x6000305")]
			internal void <.ctor>b__4_0(object state) { }

			[Address(RVA = "0xA4DA80", Offset = "0xA4CE80", Length = "0x174")]
			[Token(Token = "0x6000306")]
			internal void <.ctor>b__4_1(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000176")]
		private T1 t1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000177")]
		private T2 t2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000178")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000179")]
		private UniTaskCompletionSourceCore<ValueTuple`2<T1, T2>> core; //Field offset: 0x0

		[Address(RVA = "0x14814E0", Offset = "0x14808E0", Length = "0x5F4")]
		[Token(Token = "0x60002FB")]
		public WhenAllPromise`2(UniTask<T1> task1, UniTask<T2> task2) { }

		[Address(RVA = "0x1480770", Offset = "0x147FB70", Length = "0xB8")]
		[Token(Token = "0x60002FF")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1480830", Offset = "0x147FC30", Length = "0x12D")]
		[Token(Token = "0x60002FE")]
		public override ValueTuple<T1, T2> GetResult(short token) { }

		[Address(RVA = "0x1480960", Offset = "0x147FD60", Length = "0x6A")]
		[Token(Token = "0x6000300")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x14809D0", Offset = "0x147FDD0", Length = "0x95")]
		[Token(Token = "0x6000302")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1480A70", Offset = "0x147FE70", Length = "0x4FA")]
		[Token(Token = "0x60002FC")]
		private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x1480F70", Offset = "0x1480370", Length = "0x506")]
		[Token(Token = "0x60002FD")]
		private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1481480", Offset = "0x1480880", Length = "0x5A")]
		[Token(Token = "0x6000301")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000A0")]
	private sealed class WhenAllPromise : IUniTaskSource<ValueTuple`3<T1, T2, T3>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000A1")]
		private sealed class <>c
		{
			[Token(Token = "0x4000182")]
			public static readonly <>c<T1, T2, T3> <>9; //Field offset: 0x0
			[Token(Token = "0x4000183")]
			public static Action<Object> <>9__5_0; //Field offset: 0x0
			[Token(Token = "0x4000184")]
			public static Action<Object> <>9__5_1; //Field offset: 0x0
			[Token(Token = "0x4000185")]
			public static Action<Object> <>9__5_2; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x6000310")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000311")]
			public <>c() { }

			[Address(RVA = "0xA4DC00", Offset = "0xA4D000", Length = "0x174")]
			[Token(Token = "0x6000312")]
			internal void <.ctor>b__5_0(object state) { }

			[Address(RVA = "0xA4DD80", Offset = "0xA4D180", Length = "0x174")]
			[Token(Token = "0x6000313")]
			internal void <.ctor>b__5_1(object state) { }

			[Address(RVA = "0xA4DF00", Offset = "0xA4D300", Length = "0x174")]
			[Token(Token = "0x6000314")]
			internal void <.ctor>b__5_2(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400017D")]
		private T1 t1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400017E")]
		private T2 t2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400017F")]
		private T3 t3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000180")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000181")]
		private UniTaskCompletionSourceCore<ValueTuple`3<T1, T2, T3>> core; //Field offset: 0x0

		[Address(RVA = "0x1483070", Offset = "0x1482470", Length = "0x8C1")]
		[Token(Token = "0x6000307")]
		public WhenAllPromise`3(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3) { }

		[Address(RVA = "0x1481AE0", Offset = "0x1480EE0", Length = "0xB8")]
		[Token(Token = "0x600030C")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1481BA0", Offset = "0x1480FA0", Length = "0x12D")]
		[Token(Token = "0x600030B")]
		public override ValueTuple<T1, T2, T3> GetResult(short token) { }

		[Address(RVA = "0x1481CD0", Offset = "0x14810D0", Length = "0x6A")]
		[Token(Token = "0x600030D")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1481D40", Offset = "0x1481140", Length = "0x95")]
		[Token(Token = "0x600030F")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1481DE0", Offset = "0x14811E0", Length = "0x607")]
		[Token(Token = "0x6000308")]
		private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x14823F0", Offset = "0x14817F0", Length = "0x60B")]
		[Token(Token = "0x6000309")]
		private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1482A00", Offset = "0x1481E00", Length = "0x60D")]
		[Token(Token = "0x600030A")]
		private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x1483010", Offset = "0x1482410", Length = "0x5A")]
		[Token(Token = "0x600030E")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000A2")]
	private sealed class WhenAllPromise : IUniTaskSource<ValueTuple`4<T1, T2, T3, T4>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000A3")]
		private sealed class <>c
		{
			[Token(Token = "0x400018C")]
			public static readonly <>c<T1, T2, T3, T4> <>9; //Field offset: 0x0
			[Token(Token = "0x400018D")]
			public static Action<Object> <>9__6_0; //Field offset: 0x0
			[Token(Token = "0x400018E")]
			public static Action<Object> <>9__6_1; //Field offset: 0x0
			[Token(Token = "0x400018F")]
			public static Action<Object> <>9__6_2; //Field offset: 0x0
			[Token(Token = "0x4000190")]
			public static Action<Object> <>9__6_3; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x600031F")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000320")]
			public <>c() { }

			[Address(RVA = "0xA4E080", Offset = "0xA4D480", Length = "0x174")]
			[Token(Token = "0x6000321")]
			internal void <.ctor>b__6_0(object state) { }

			[Address(RVA = "0xA4E2A0", Offset = "0xA4D6A0", Length = "0x174")]
			[Token(Token = "0x6000322")]
			internal void <.ctor>b__6_1(object state) { }

			[Address(RVA = "0xA4E420", Offset = "0xA4D820", Length = "0x174")]
			[Token(Token = "0x6000323")]
			internal void <.ctor>b__6_2(object state) { }

			[Address(RVA = "0xA4E5A0", Offset = "0xA4D9A0", Length = "0x183")]
			[Token(Token = "0x6000324")]
			internal void <.ctor>b__6_3(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000186")]
		private T1 t1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000187")]
		private T2 t2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000188")]
		private T3 t3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000189")]
		private T4 t4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400018A")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400018B")]
		private UniTaskCompletionSourceCore<ValueTuple`4<T1, T2, T3, T4>> core; //Field offset: 0x0

		[Address(RVA = "0x1485940", Offset = "0x1484D40", Length = "0xC58")]
		[Token(Token = "0x6000315")]
		public WhenAllPromise`4(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4) { }

		[Address(RVA = "0x1483940", Offset = "0x1482D40", Length = "0xB8")]
		[Token(Token = "0x600031B")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1483A00", Offset = "0x1482E00", Length = "0x130")]
		[Token(Token = "0x600031A")]
		public override ValueTuple<T1, T2, T3, T4> GetResult(short token) { }

		[Address(RVA = "0x1483B30", Offset = "0x1482F30", Length = "0x6D")]
		[Token(Token = "0x600031C")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1483BA0", Offset = "0x1482FA0", Length = "0x98")]
		[Token(Token = "0x600031E")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1483C40", Offset = "0x1483040", Length = "0x71C")]
		[Token(Token = "0x6000316")]
		private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x1484360", Offset = "0x1483760", Length = "0x71B")]
		[Token(Token = "0x6000317")]
		private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1484A80", Offset = "0x1483E80", Length = "0x723")]
		[Token(Token = "0x6000318")]
		private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x14851B0", Offset = "0x14845B0", Length = "0x722")]
		[Token(Token = "0x6000319")]
		private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x14858E0", Offset = "0x1484CE0", Length = "0x5D")]
		[Token(Token = "0x600031D")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000A4")]
	private sealed class WhenAllPromise : IUniTaskSource<ValueTuple`5<T1, T2, T3, T4, T5>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000A5")]
		private sealed class <>c
		{
			[Token(Token = "0x4000198")]
			public static readonly <>c<T1, T2, T3, T4, T5> <>9; //Field offset: 0x0
			[Token(Token = "0x4000199")]
			public static Action<Object> <>9__7_0; //Field offset: 0x0
			[Token(Token = "0x400019A")]
			public static Action<Object> <>9__7_1; //Field offset: 0x0
			[Token(Token = "0x400019B")]
			public static Action<Object> <>9__7_2; //Field offset: 0x0
			[Token(Token = "0x400019C")]
			public static Action<Object> <>9__7_3; //Field offset: 0x0
			[Token(Token = "0x400019D")]
			public static Action<Object> <>9__7_4; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x6000330")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000331")]
			public <>c() { }

			[Address(RVA = "0xA4E730", Offset = "0xA4DB30", Length = "0x174")]
			[Token(Token = "0x6000332")]
			internal void <.ctor>b__7_0(object state) { }

			[Address(RVA = "0xA4E8B0", Offset = "0xA4DCB0", Length = "0x174")]
			[Token(Token = "0x6000333")]
			internal void <.ctor>b__7_1(object state) { }

			[Address(RVA = "0xA4EA30", Offset = "0xA4DE30", Length = "0x174")]
			[Token(Token = "0x6000334")]
			internal void <.ctor>b__7_2(object state) { }

			[Address(RVA = "0xA4EBB0", Offset = "0xA4DFB0", Length = "0x183")]
			[Token(Token = "0x6000335")]
			internal void <.ctor>b__7_3(object state) { }

			[Address(RVA = "0xA4ED40", Offset = "0xA4E140", Length = "0x183")]
			[Token(Token = "0x6000336")]
			internal void <.ctor>b__7_4(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000191")]
		private T1 t1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000192")]
		private T2 t2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000193")]
		private T3 t3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000194")]
		private T4 t4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000195")]
		private T5 t5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000196")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000197")]
		private UniTaskCompletionSourceCore<ValueTuple`5<T1, T2, T3, T4, T5>> core; //Field offset: 0x0

		[Address(RVA = "0x1489230", Offset = "0x1488630", Length = "0xF49")]
		[Token(Token = "0x6000325")]
		public WhenAllPromise`5(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5) { }

		[Address(RVA = "0x14865A0", Offset = "0x14859A0", Length = "0xB8")]
		[Token(Token = "0x600032C")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1486660", Offset = "0x1485A60", Length = "0x130")]
		[Token(Token = "0x600032B")]
		public override ValueTuple<T1, T2, T3, T4, T5> GetResult(short token) { }

		[Address(RVA = "0x1486790", Offset = "0x1485B90", Length = "0x6D")]
		[Token(Token = "0x600032D")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1486800", Offset = "0x1485C00", Length = "0x98")]
		[Token(Token = "0x600032F")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x14868A0", Offset = "0x1485CA0", Length = "0x836")]
		[Token(Token = "0x6000326")]
		private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x14870E0", Offset = "0x14864E0", Length = "0x838")]
		[Token(Token = "0x6000327")]
		private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1487920", Offset = "0x1486D20", Length = "0x838")]
		[Token(Token = "0x6000328")]
		private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x1488160", Offset = "0x1487560", Length = "0x82D")]
		[Token(Token = "0x6000329")]
		private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x1488990", Offset = "0x1487D90", Length = "0x833")]
		[Token(Token = "0x600032A")]
		private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x14891D0", Offset = "0x14885D0", Length = "0x5D")]
		[Token(Token = "0x600032E")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000A6")]
	private sealed class WhenAllPromise : IUniTaskSource<ValueTuple`6<T1, T2, T3, T4, T5, T6>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000A7")]
		private sealed class <>c
		{
			[Token(Token = "0x40001A6")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6> <>9; //Field offset: 0x0
			[Token(Token = "0x40001A7")]
			public static Action<Object> <>9__8_0; //Field offset: 0x0
			[Token(Token = "0x40001A8")]
			public static Action<Object> <>9__8_1; //Field offset: 0x0
			[Token(Token = "0x40001A9")]
			public static Action<Object> <>9__8_2; //Field offset: 0x0
			[Token(Token = "0x40001AA")]
			public static Action<Object> <>9__8_3; //Field offset: 0x0
			[Token(Token = "0x40001AB")]
			public static Action<Object> <>9__8_4; //Field offset: 0x0
			[Token(Token = "0x40001AC")]
			public static Action<Object> <>9__8_5; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x6000343")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000344")]
			public <>c() { }

			[Address(RVA = "0xA4EED0", Offset = "0xA4E2D0", Length = "0x174")]
			[Token(Token = "0x6000345")]
			internal void <.ctor>b__8_0(object state) { }

			[Address(RVA = "0xA4F050", Offset = "0xA4E450", Length = "0x174")]
			[Token(Token = "0x6000346")]
			internal void <.ctor>b__8_1(object state) { }

			[Address(RVA = "0xA4F1D0", Offset = "0xA4E5D0", Length = "0x174")]
			[Token(Token = "0x6000347")]
			internal void <.ctor>b__8_2(object state) { }

			[Address(RVA = "0xA4F350", Offset = "0xA4E750", Length = "0x183")]
			[Token(Token = "0x6000348")]
			internal void <.ctor>b__8_3(object state) { }

			[Address(RVA = "0xA4F4E0", Offset = "0xA4E8E0", Length = "0x183")]
			[Token(Token = "0x6000349")]
			internal void <.ctor>b__8_4(object state) { }

			[Address(RVA = "0xA4F670", Offset = "0xA4EA70", Length = "0x183")]
			[Token(Token = "0x600034A")]
			internal void <.ctor>b__8_5(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400019E")]
		private T1 t1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400019F")]
		private T2 t2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001A0")]
		private T3 t3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001A1")]
		private T4 t4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001A2")]
		private T5 t5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001A3")]
		private T6 t6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001A4")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001A5")]
		private UniTaskCompletionSourceCore<ValueTuple`6<T1, T2, T3, T4, T5, T6>> core; //Field offset: 0x0

		[Address(RVA = "0x148DCC0", Offset = "0x148D0C0", Length = "0x1251")]
		[Token(Token = "0x6000337")]
		public WhenAllPromise`6(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6) { }

		[Address(RVA = "0x148A180", Offset = "0x1489580", Length = "0xB8")]
		[Token(Token = "0x600033F")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x148A240", Offset = "0x1489640", Length = "0x130")]
		[Token(Token = "0x600033E")]
		public override ValueTuple<T1, T2, T3, T4, T5, T6> GetResult(short token) { }

		[Address(RVA = "0x148A370", Offset = "0x1489770", Length = "0x6D")]
		[Token(Token = "0x6000340")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x148A3E0", Offset = "0x14897E0", Length = "0x98")]
		[Token(Token = "0x6000342")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x148A480", Offset = "0x1489880", Length = "0x947")]
		[Token(Token = "0x6000338")]
		private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x148ADD0", Offset = "0x148A1D0", Length = "0x945")]
		[Token(Token = "0x6000339")]
		private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x148B720", Offset = "0x148AB20", Length = "0x94C")]
		[Token(Token = "0x600033A")]
		private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x148C070", Offset = "0x148B470", Length = "0x944")]
		[Token(Token = "0x600033B")]
		private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x148C9C0", Offset = "0x148BDC0", Length = "0x942")]
		[Token(Token = "0x600033C")]
		private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x148D310", Offset = "0x148C710", Length = "0x94F")]
		[Token(Token = "0x600033D")]
		private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x148DC60", Offset = "0x148D060", Length = "0x5D")]
		[Token(Token = "0x6000341")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000A8")]
	private sealed class WhenAllPromise : IUniTaskSource<ValueTuple`7<T1, T2, T3, T4, T5, T6, T7>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000A9")]
		private sealed class <>c
		{
			[Token(Token = "0x40001B6")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7> <>9; //Field offset: 0x0
			[Token(Token = "0x40001B7")]
			public static Action<Object> <>9__9_0; //Field offset: 0x0
			[Token(Token = "0x40001B8")]
			public static Action<Object> <>9__9_1; //Field offset: 0x0
			[Token(Token = "0x40001B9")]
			public static Action<Object> <>9__9_2; //Field offset: 0x0
			[Token(Token = "0x40001BA")]
			public static Action<Object> <>9__9_3; //Field offset: 0x0
			[Token(Token = "0x40001BB")]
			public static Action<Object> <>9__9_4; //Field offset: 0x0
			[Token(Token = "0x40001BC")]
			public static Action<Object> <>9__9_5; //Field offset: 0x0
			[Token(Token = "0x40001BD")]
			public static Action<Object> <>9__9_6; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x6000358")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000359")]
			public <>c() { }

			[Address(RVA = "0xA4F800", Offset = "0xA4EC00", Length = "0x174")]
			[Token(Token = "0x600035A")]
			internal void <.ctor>b__9_0(object state) { }

			[Address(RVA = "0xA4F980", Offset = "0xA4ED80", Length = "0x174")]
			[Token(Token = "0x600035B")]
			internal void <.ctor>b__9_1(object state) { }

			[Address(RVA = "0xA4FB00", Offset = "0xA4EF00", Length = "0x174")]
			[Token(Token = "0x600035C")]
			internal void <.ctor>b__9_2(object state) { }

			[Address(RVA = "0xA4FC80", Offset = "0xA4F080", Length = "0x183")]
			[Token(Token = "0x600035D")]
			internal void <.ctor>b__9_3(object state) { }

			[Address(RVA = "0xA4FE10", Offset = "0xA4F210", Length = "0x183")]
			[Token(Token = "0x600035E")]
			internal void <.ctor>b__9_4(object state) { }

			[Address(RVA = "0xA4FFA0", Offset = "0xA4F3A0", Length = "0x183")]
			[Token(Token = "0x600035F")]
			internal void <.ctor>b__9_5(object state) { }

			[Address(RVA = "0xA50130", Offset = "0xA4F530", Length = "0x183")]
			[Token(Token = "0x6000360")]
			internal void <.ctor>b__9_6(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001AD")]
		private T1 t1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001AE")]
		private T2 t2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001AF")]
		private T3 t3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B0")]
		private T4 t4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B1")]
		private T5 t5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B2")]
		private T6 t6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B3")]
		private T7 t7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B4")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001B5")]
		private UniTaskCompletionSourceCore<ValueTuple`7<T1, T2, T3, T4, T5, T6, T7>> core; //Field offset: 0x0

		[Address(RVA = "0x1493BE0", Offset = "0x1492FE0", Length = "0x155B")]
		[Token(Token = "0x600034B")]
		public WhenAllPromise`7(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7) { }

		[Address(RVA = "0x148EF20", Offset = "0x148E320", Length = "0xB8")]
		[Token(Token = "0x6000354")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x148EFE0", Offset = "0x148E3E0", Length = "0x130")]
		[Token(Token = "0x6000353")]
		public override ValueTuple<T1, T2, T3, T4, T5, T6, T7> GetResult(short token) { }

		[Address(RVA = "0x148F110", Offset = "0x148E510", Length = "0x6D")]
		[Token(Token = "0x6000355")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x148F180", Offset = "0x148E580", Length = "0x98")]
		[Token(Token = "0x6000357")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x148F220", Offset = "0x148E620", Length = "0xA77")]
		[Token(Token = "0x600034C")]
		private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x148FCA0", Offset = "0x148F0A0", Length = "0xA76")]
		[Token(Token = "0x600034D")]
		private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1490720", Offset = "0x148FB20", Length = "0xA7B")]
		[Token(Token = "0x600034E")]
		private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x14911A0", Offset = "0x14905A0", Length = "0xA6F")]
		[Token(Token = "0x600034F")]
		private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x1491C10", Offset = "0x1491010", Length = "0xA61")]
		[Token(Token = "0x6000350")]
		private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x1492680", Offset = "0x1491A80", Length = "0xA77")]
		[Token(Token = "0x6000351")]
		private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x1493100", Offset = "0x1492500", Length = "0xA75")]
		[Token(Token = "0x6000352")]
		private static void TryInvokeContinuationT7(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x1493B80", Offset = "0x1492F80", Length = "0x5D")]
		[Token(Token = "0x6000356")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000AA")]
	private sealed class WhenAllPromise : IUniTaskSource<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`1<T8>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000AB")]
		private sealed class <>c
		{
			[Token(Token = "0x40001C8")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8> <>9; //Field offset: 0x0
			[Token(Token = "0x40001C9")]
			public static Action<Object> <>9__10_0; //Field offset: 0x0
			[Token(Token = "0x40001CA")]
			public static Action<Object> <>9__10_1; //Field offset: 0x0
			[Token(Token = "0x40001CB")]
			public static Action<Object> <>9__10_2; //Field offset: 0x0
			[Token(Token = "0x40001CC")]
			public static Action<Object> <>9__10_3; //Field offset: 0x0
			[Token(Token = "0x40001CD")]
			public static Action<Object> <>9__10_4; //Field offset: 0x0
			[Token(Token = "0x40001CE")]
			public static Action<Object> <>9__10_5; //Field offset: 0x0
			[Token(Token = "0x40001CF")]
			public static Action<Object> <>9__10_6; //Field offset: 0x0
			[Token(Token = "0x40001D0")]
			public static Action<Object> <>9__10_7; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x600036F")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000370")]
			public <>c() { }

			[Address(RVA = "0xA388C0", Offset = "0xA37CC0", Length = "0x174")]
			[Token(Token = "0x6000371")]
			internal void <.ctor>b__10_0(object state) { }

			[Address(RVA = "0xA38A40", Offset = "0xA37E40", Length = "0x174")]
			[Token(Token = "0x6000372")]
			internal void <.ctor>b__10_1(object state) { }

			[Address(RVA = "0xA38BC0", Offset = "0xA37FC0", Length = "0x174")]
			[Token(Token = "0x6000373")]
			internal void <.ctor>b__10_2(object state) { }

			[Address(RVA = "0xA38D40", Offset = "0xA38140", Length = "0x183")]
			[Token(Token = "0x6000374")]
			internal void <.ctor>b__10_3(object state) { }

			[Address(RVA = "0xA38ED0", Offset = "0xA382D0", Length = "0x183")]
			[Token(Token = "0x6000375")]
			internal void <.ctor>b__10_4(object state) { }

			[Address(RVA = "0xA39060", Offset = "0xA38460", Length = "0x183")]
			[Token(Token = "0x6000376")]
			internal void <.ctor>b__10_5(object state) { }

			[Address(RVA = "0xA391F0", Offset = "0xA385F0", Length = "0x183")]
			[Token(Token = "0x6000377")]
			internal void <.ctor>b__10_6(object state) { }

			[Address(RVA = "0xA39380", Offset = "0xA38780", Length = "0x183")]
			[Token(Token = "0x6000378")]
			internal void <.ctor>b__10_7(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001BE")]
		private T1 t1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001BF")]
		private T2 t2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C0")]
		private T3 t3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C1")]
		private T4 t4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C2")]
		private T5 t5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C3")]
		private T6 t6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C4")]
		private T7 t7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C5")]
		private T8 t8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C6")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001C7")]
		private UniTaskCompletionSourceCore<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`1<T8>>> core; //Field offset: 0x0

		[Address(RVA = "0x149B850", Offset = "0x149AC50", Length = "0x1884")]
		[Token(Token = "0x6000361")]
		public WhenAllPromise`8(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8) { }

		[Address(RVA = "0x1495140", Offset = "0x1494540", Length = "0xB8")]
		[Token(Token = "0x600036B")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1495200", Offset = "0x1494600", Length = "0x130")]
		[Token(Token = "0x600036A")]
		public override ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`1<T8>> GetResult(short token) { }

		[Address(RVA = "0x1495330", Offset = "0x1494730", Length = "0x6D")]
		[Token(Token = "0x600036C")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x14953A0", Offset = "0x14947A0", Length = "0x98")]
		[Token(Token = "0x600036E")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1495440", Offset = "0x1494840", Length = "0xC6C")]
		[Token(Token = "0x6000362")]
		private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x14960B0", Offset = "0x14954B0", Length = "0xC70")]
		[Token(Token = "0x6000363")]
		private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1496D30", Offset = "0x1496130", Length = "0xC70")]
		[Token(Token = "0x6000364")]
		private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x14979B0", Offset = "0x1496DB0", Length = "0xC6D")]
		[Token(Token = "0x6000365")]
		private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x1498620", Offset = "0x1497A20", Length = "0xC71")]
		[Token(Token = "0x6000366")]
		private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x14992A0", Offset = "0x14986A0", Length = "0xC66")]
		[Token(Token = "0x6000367")]
		private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x1499F10", Offset = "0x1499310", Length = "0xC65")]
		[Token(Token = "0x6000368")]
		private static void TryInvokeContinuationT7(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x149AB80", Offset = "0x1499F80", Length = "0xC69")]
		[Token(Token = "0x6000369")]
		private static void TryInvokeContinuationT8(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x149B7F0", Offset = "0x149ABF0", Length = "0x5D")]
		[Token(Token = "0x600036D")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000AC")]
	private sealed class WhenAllPromise : IUniTaskSource<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`2<T8, T9>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000AD")]
		private sealed class <>c
		{
			[Token(Token = "0x40001DC")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8, T9> <>9; //Field offset: 0x0
			[Token(Token = "0x40001DD")]
			public static Action<Object> <>9__11_0; //Field offset: 0x0
			[Token(Token = "0x40001DE")]
			public static Action<Object> <>9__11_1; //Field offset: 0x0
			[Token(Token = "0x40001DF")]
			public static Action<Object> <>9__11_2; //Field offset: 0x0
			[Token(Token = "0x40001E0")]
			public static Action<Object> <>9__11_3; //Field offset: 0x0
			[Token(Token = "0x40001E1")]
			public static Action<Object> <>9__11_4; //Field offset: 0x0
			[Token(Token = "0x40001E2")]
			public static Action<Object> <>9__11_5; //Field offset: 0x0
			[Token(Token = "0x40001E3")]
			public static Action<Object> <>9__11_6; //Field offset: 0x0
			[Token(Token = "0x40001E4")]
			public static Action<Object> <>9__11_7; //Field offset: 0x0
			[Token(Token = "0x40001E5")]
			public static Action<Object> <>9__11_8; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x6000388")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000389")]
			public <>c() { }

			[Address(RVA = "0xA39510", Offset = "0xA38910", Length = "0x174")]
			[Token(Token = "0x600038A")]
			internal void <.ctor>b__11_0(object state) { }

			[Address(RVA = "0xA39690", Offset = "0xA38A90", Length = "0x174")]
			[Token(Token = "0x600038B")]
			internal void <.ctor>b__11_1(object state) { }

			[Address(RVA = "0xA39810", Offset = "0xA38C10", Length = "0x174")]
			[Token(Token = "0x600038C")]
			internal void <.ctor>b__11_2(object state) { }

			[Address(RVA = "0xA39990", Offset = "0xA38D90", Length = "0x183")]
			[Token(Token = "0x600038D")]
			internal void <.ctor>b__11_3(object state) { }

			[Address(RVA = "0xA39B20", Offset = "0xA38F20", Length = "0x183")]
			[Token(Token = "0x600038E")]
			internal void <.ctor>b__11_4(object state) { }

			[Address(RVA = "0xA39CB0", Offset = "0xA390B0", Length = "0x183")]
			[Token(Token = "0x600038F")]
			internal void <.ctor>b__11_5(object state) { }

			[Address(RVA = "0xA39E40", Offset = "0xA39240", Length = "0x183")]
			[Token(Token = "0x6000390")]
			internal void <.ctor>b__11_6(object state) { }

			[Address(RVA = "0xA39FD0", Offset = "0xA393D0", Length = "0x183")]
			[Token(Token = "0x6000391")]
			internal void <.ctor>b__11_7(object state) { }

			[Address(RVA = "0xA3A160", Offset = "0xA39560", Length = "0x183")]
			[Token(Token = "0x6000392")]
			internal void <.ctor>b__11_8(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D1")]
		private T1 t1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D2")]
		private T2 t2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D3")]
		private T3 t3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D4")]
		private T4 t4; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D5")]
		private T5 t5; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D6")]
		private T6 t6; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D7")]
		private T7 t7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D8")]
		private T8 t8; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001D9")]
		private T9 t9; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001DA")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001DB")]
		private UniTaskCompletionSourceCore<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`2<T8, T9>>> core; //Field offset: 0x0

		[Address(RVA = "0x14A4E50", Offset = "0x14A4250", Length = "0x1B56")]
		[Token(Token = "0x6000379")]
		public WhenAllPromise`9(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9) { }

		[Address(RVA = "0x149D0E0", Offset = "0x149C4E0", Length = "0xB8")]
		[Token(Token = "0x6000384")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x149D1A0", Offset = "0x149C5A0", Length = "0x130")]
		[Token(Token = "0x6000383")]
		public override ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple`2<T8, T9>> GetResult(short token) { }

		[Address(RVA = "0x149D2D0", Offset = "0x149C6D0", Length = "0x6D")]
		[Token(Token = "0x6000385")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x149D340", Offset = "0x149C740", Length = "0x98")]
		[Token(Token = "0x6000387")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x149D3E0", Offset = "0x149C7E0", Length = "0xD8A")]
		[Token(Token = "0x600037A")]
		private static void TryInvokeContinuationT1(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x149E170", Offset = "0x149D570", Length = "0xD8E")]
		[Token(Token = "0x600037B")]
		private static void TryInvokeContinuationT2(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x149EF00", Offset = "0x149E300", Length = "0xD8E")]
		[Token(Token = "0x600037C")]
		private static void TryInvokeContinuationT3(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x149FC90", Offset = "0x149F090", Length = "0xD8E")]
		[Token(Token = "0x600037D")]
		private static void TryInvokeContinuationT4(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x14A0A20", Offset = "0x149FE20", Length = "0xD8B")]
		[Token(Token = "0x600037E")]
		private static void TryInvokeContinuationT5(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x14A17B0", Offset = "0x14A0BB0", Length = "0xD8F")]
		[Token(Token = "0x600037F")]
		private static void TryInvokeContinuationT6(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x14A2540", Offset = "0x14A1940", Length = "0xD82")]
		[Token(Token = "0x6000380")]
		private static void TryInvokeContinuationT7(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x14A32D0", Offset = "0x14A26D0", Length = "0xD81")]
		[Token(Token = "0x6000381")]
		private static void TryInvokeContinuationT8(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x14A4060", Offset = "0x14A3460", Length = "0xD80")]
		[Token(Token = "0x6000382")]
		private static void TryInvokeContinuationT9(WhenAllPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T9> awaiter) { }

		[Address(RVA = "0x14A4DF0", Offset = "0x14A41F0", Length = "0x5D")]
		[Token(Token = "0x6000386")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000BA")]
	private sealed class WhenAnyLRPromise : IUniTaskSource<ValueTuple`2<Boolean, T>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000BB")]
		private sealed class <>c
		{
			[Token(Token = "0x4000290")]
			public static readonly <>c<T> <>9; //Field offset: 0x0
			[Token(Token = "0x4000291")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x4000292")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x6000461")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000462")]
			public <>c() { }

			[Address(RVA = "0xA42500", Offset = "0xA41900", Length = "0x174")]
			[Token(Token = "0x6000463")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA44CF0", Offset = "0xA440F0", Length = "0x127")]
			[Token(Token = "0x6000464")]
			internal void <.ctor>b__2_1(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028E")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400028F")]
		private UniTaskCompletionSourceCore<ValueTuple`2<Boolean, T>> core; //Field offset: 0x0

		[Address(RVA = "0x14A74B0", Offset = "0x14A68B0", Length = "0x771")]
		[Token(Token = "0x6000459")]
		public WhenAnyLRPromise`1(UniTask<T> leftTask, UniTask rightTask) { }

		[Address(RVA = "0x14A69B0", Offset = "0x14A5DB0", Length = "0xB8")]
		[Token(Token = "0x6000460")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x14A6A70", Offset = "0x14A5E70", Length = "0x12E")]
		[Token(Token = "0x600045C")]
		public override ValueTuple<Boolean, T> GetResult(short token) { }

		[Address(RVA = "0x14A6BA0", Offset = "0x14A5FA0", Length = "0x6B")]
		[Token(Token = "0x600045D")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x14A6C10", Offset = "0x14A6010", Length = "0x96")]
		[Token(Token = "0x600045E")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x14A6CB0", Offset = "0x14A60B0", Length = "0x3A8")]
		[Token(Token = "0x600045A")]
		private static void TryLeftInvokeContinuation(WhenAnyLRPromise<T> self, in Awaiter<T> awaiter) { }

		[Address(RVA = "0x14A7060", Offset = "0x14A6460", Length = "0x3E3")]
		[Token(Token = "0x600045B")]
		private static void TryRightInvokeContinuation(WhenAnyLRPromise<T> self, in Awaiter awaiter) { }

		[Address(RVA = "0x14A7450", Offset = "0x14A6850", Length = "0x5B")]
		[Token(Token = "0x600045F")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000BE")]
	private sealed class WhenAnyPromise : IUniTaskSource<Int32>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000BF")]
		private sealed class <>c
		{
			[Token(Token = "0x4000299")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x400029A")]
			public static Action<Object> <>9__2_0; //Field offset: 0x8

			[Address(RVA = "0x273F900", Offset = "0x273ED00", Length = "0x67")]
			[Token(Token = "0x6000476")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000477")]
			public <>c() { }

			[Address(RVA = "0x273F040", Offset = "0x273E440", Length = "0xFF")]
			[Token(Token = "0x6000478")]
			internal void <.ctor>b__2_0(object state) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000297")]
		private int completedCount; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000298")]
		private UniTaskCompletionSourceCore<Int32> core; //Field offset: 0x18

		[Address(RVA = "0x274E620", Offset = "0x274DA20", Length = "0x2B0")]
		[Token(Token = "0x600046F")]
		public WhenAnyPromise(UniTask[] tasks, int tasksLength) { }

		[Address(RVA = "0x274E0D0", Offset = "0x274D4D0", Length = "0x74")]
		[Token(Token = "0x6000475")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x274E0D0", Offset = "0x274D4D0", Length = "0x74")]
		[Token(Token = "0x6000471")]
		public override int GetResult(short token) { }

		[Address(RVA = "0x274E150", Offset = "0x274D550", Length = "0x14E")]
		[Token(Token = "0x6000472")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x274E2A0", Offset = "0x274D6A0", Length = "0x1D0")]
		[Token(Token = "0x6000473")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x274E480", Offset = "0x274D880", Length = "0xE7")]
		[Token(Token = "0x6000470")]
		private static void TryInvokeContinuation(WhenAnyPromise self, in Awaiter awaiter, int i) { }

		[Address(RVA = "0x274E570", Offset = "0x274D970", Length = "0xAD")]
		[Token(Token = "0x6000474")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000BC")]
	private sealed class WhenAnyPromise : IUniTaskSource<ValueTuple`2<Int32, T>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000BD")]
		private sealed class <>c
		{
			[Token(Token = "0x4000295")]
			public static readonly <>c<T> <>9; //Field offset: 0x0
			[Token(Token = "0x4000296")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x600046C")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600046D")]
			public <>c() { }

			[Address(RVA = "0xA421D0", Offset = "0xA415D0", Length = "0x1A8")]
			[Token(Token = "0x600046E")]
			internal void <.ctor>b__2_0(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000293")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000294")]
		private UniTaskCompletionSourceCore<ValueTuple`2<Int32, T>> core; //Field offset: 0x0

		[Address(RVA = "0x14E3430", Offset = "0x14E2830", Length = "0x495")]
		[Token(Token = "0x6000465")]
		public WhenAnyPromise`1(UniTask<T>[] tasks, int tasksLength) { }

		[Address(RVA = "0x14E2D20", Offset = "0x14E2120", Length = "0xB8")]
		[Token(Token = "0x600046B")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x14E2DE0", Offset = "0x14E21E0", Length = "0x12E")]
		[Token(Token = "0x6000467")]
		public override ValueTuple<Int32, T> GetResult(short token) { }

		[Address(RVA = "0x14E2F10", Offset = "0x14E2310", Length = "0x6B")]
		[Token(Token = "0x6000468")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x14E2F80", Offset = "0x14E2380", Length = "0x96")]
		[Token(Token = "0x6000469")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x14E3020", Offset = "0x14E2420", Length = "0x3AC")]
		[Token(Token = "0x6000466")]
		private static void TryInvokeContinuation(WhenAnyPromise<T> self, in Awaiter<T> awaiter, int i) { }

		[Address(RVA = "0x14E33D0", Offset = "0x14E27D0", Length = "0x5B")]
		[Token(Token = "0x600046A")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000D0")]
	private sealed class WhenAnyPromise0 : IUniTaskSource<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`4<T7, T8, T9, T10>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000D1")]
		private sealed class <>c
		{
			[Token(Token = "0x40002E1")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> <>9; //Field offset: 0x0
			[Token(Token = "0x40002E2")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x40002E3")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0
			[Token(Token = "0x40002E4")]
			public static Action<Object> <>9__2_2; //Field offset: 0x0
			[Token(Token = "0x40002E5")]
			public static Action<Object> <>9__2_3; //Field offset: 0x0
			[Token(Token = "0x40002E6")]
			public static Action<Object> <>9__2_4; //Field offset: 0x0
			[Token(Token = "0x40002E7")]
			public static Action<Object> <>9__2_5; //Field offset: 0x0
			[Token(Token = "0x40002E8")]
			public static Action<Object> <>9__2_6; //Field offset: 0x0
			[Token(Token = "0x40002E9")]
			public static Action<Object> <>9__2_7; //Field offset: 0x0
			[Token(Token = "0x40002EA")]
			public static Action<Object> <>9__2_8; //Field offset: 0x0
			[Token(Token = "0x40002EB")]
			public static Action<Object> <>9__2_9; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x6000521")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000522")]
			public <>c() { }

			[Address(RVA = "0xA41D50", Offset = "0xA41150", Length = "0x174")]
			[Token(Token = "0x6000523")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA450D0", Offset = "0xA444D0", Length = "0x174")]
			[Token(Token = "0x6000524")]
			internal void <.ctor>b__2_1(object state) { }

			[Address(RVA = "0xA46ED0", Offset = "0xA462D0", Length = "0x174")]
			[Token(Token = "0x6000525")]
			internal void <.ctor>b__2_2(object state) { }

			[Address(RVA = "0xA48480", Offset = "0xA47880", Length = "0x183")]
			[Token(Token = "0x6000526")]
			internal void <.ctor>b__2_3(object state) { }

			[Address(RVA = "0xA495B0", Offset = "0xA489B0", Length = "0x183")]
			[Token(Token = "0x6000527")]
			internal void <.ctor>b__2_4(object state) { }

			[Address(RVA = "0xA4A0A0", Offset = "0xA494A0", Length = "0x183")]
			[Token(Token = "0x6000528")]
			internal void <.ctor>b__2_5(object state) { }

			[Address(RVA = "0xA4B360", Offset = "0xA4A760", Length = "0x183")]
			[Token(Token = "0x6000529")]
			internal void <.ctor>b__2_6(object state) { }

			[Address(RVA = "0xA4B810", Offset = "0xA4AC10", Length = "0x183")]
			[Token(Token = "0x600052A")]
			internal void <.ctor>b__2_7(object state) { }

			[Address(RVA = "0xA4C170", Offset = "0xA4B570", Length = "0x183")]
			[Token(Token = "0x600052B")]
			internal void <.ctor>b__2_8(object state) { }

			[Address(RVA = "0xA4D2A0", Offset = "0xA4C6A0", Length = "0x183")]
			[Token(Token = "0x600052C")]
			internal void <.ctor>b__2_9(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002DF")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E0")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "result1", "result2", "result3", "result4", "result5", "result6", "result7", "result8", "result9", "result10", null, null, null, null})]
		private UniTaskCompletionSourceCore<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`4<T7, T8, T9, T10>>> core; //Field offset: 0x0

		[Address(RVA = "0x14B17A0", Offset = "0x14B0BA0", Length = "0x1E65")]
		[Token(Token = "0x6000511")]
		public WhenAnyPromise`10(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10) { }

		[Address(RVA = "0x14A7C30", Offset = "0x14A7030", Length = "0xB8")]
		[Token(Token = "0x6000520")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x14A7CF0", Offset = "0x14A70F0", Length = "0x12D")]
		[Token(Token = "0x600051C")]
		public override ValueTuple<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`4<T7, T8, T9, T10>> GetResult(short token) { }

		[Address(RVA = "0x14A7E20", Offset = "0x14A7220", Length = "0x6A")]
		[Token(Token = "0x600051D")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x14A7E90", Offset = "0x14A7290", Length = "0x95")]
		[Token(Token = "0x600051E")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x14A8E60", Offset = "0x14A8260", Length = "0xF33")]
		[Token(Token = "0x6000512")]
		private static void TryInvokeContinuationT1(WhenAnyPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x14A7F30", Offset = "0x14A7330", Length = "0xF26")]
		[Token(Token = "0x600051B")]
		private static void TryInvokeContinuationT10(WhenAnyPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T10> awaiter) { }

		[Address(RVA = "0x14A9DA0", Offset = "0x14A91A0", Length = "0xF32")]
		[Token(Token = "0x6000513")]
		private static void TryInvokeContinuationT2(WhenAnyPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x14AACE0", Offset = "0x14AA0E0", Length = "0xF2F")]
		[Token(Token = "0x6000514")]
		private static void TryInvokeContinuationT3(WhenAnyPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x14ABC10", Offset = "0x14AB010", Length = "0xF2F")]
		[Token(Token = "0x6000515")]
		private static void TryInvokeContinuationT4(WhenAnyPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x14ACB40", Offset = "0x14ABF40", Length = "0xF2F")]
		[Token(Token = "0x6000516")]
		private static void TryInvokeContinuationT5(WhenAnyPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x14ADA70", Offset = "0x14ACE70", Length = "0xF38")]
		[Token(Token = "0x6000517")]
		private static void TryInvokeContinuationT6(WhenAnyPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x14AE9B0", Offset = "0x14ADDB0", Length = "0xF2B")]
		[Token(Token = "0x6000518")]
		private static void TryInvokeContinuationT7(WhenAnyPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x14AF8E0", Offset = "0x14AECE0", Length = "0xF2B")]
		[Token(Token = "0x6000519")]
		private static void TryInvokeContinuationT8(WhenAnyPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x14B0810", Offset = "0x14AFC10", Length = "0xF26")]
		[Token(Token = "0x600051A")]
		private static void TryInvokeContinuationT9(WhenAnyPromise0<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, in Awaiter<T9> awaiter) { }

		[Address(RVA = "0x14B1740", Offset = "0x14B0B40", Length = "0x5A")]
		[Token(Token = "0x600051F")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000D2")]
	private sealed class WhenAnyPromise1 : IUniTaskSource<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`5<T7, T8, T9, T10, T11>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000D3")]
		private sealed class <>c
		{
			[Token(Token = "0x40002EE")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> <>9; //Field offset: 0x0
			[Token(Token = "0x40002EF")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x40002F0")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0
			[Token(Token = "0x40002F1")]
			public static Action<Object> <>9__2_2; //Field offset: 0x0
			[Token(Token = "0x40002F2")]
			public static Action<Object> <>9__2_3; //Field offset: 0x0
			[Token(Token = "0x40002F3")]
			public static Action<Object> <>9__2_4; //Field offset: 0x0
			[Token(Token = "0x40002F4")]
			public static Action<Object> <>9__2_5; //Field offset: 0x0
			[Token(Token = "0x40002F5")]
			public static Action<Object> <>9__2_6; //Field offset: 0x0
			[Token(Token = "0x40002F6")]
			public static Action<Object> <>9__2_7; //Field offset: 0x0
			[Token(Token = "0x40002F7")]
			public static Action<Object> <>9__2_8; //Field offset: 0x0
			[Token(Token = "0x40002F8")]
			public static Action<Object> <>9__2_9; //Field offset: 0x0
			[Token(Token = "0x40002F9")]
			public static Action<Object> <>9__2_10; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x600053E")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600053F")]
			public <>c() { }

			[Address(RVA = "0xA42B00", Offset = "0xA41F00", Length = "0x174")]
			[Token(Token = "0x6000540")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA44E20", Offset = "0xA44220", Length = "0x174")]
			[Token(Token = "0x6000541")]
			internal void <.ctor>b__2_1(object state) { }

			[Address(RVA = "0xA43100", Offset = "0xA42500", Length = "0x183")]
			[Token(Token = "0x600054A")]
			internal void <.ctor>b__2_10(object state) { }

			[Address(RVA = "0xA46450", Offset = "0xA45850", Length = "0x174")]
			[Token(Token = "0x6000542")]
			internal void <.ctor>b__2_2(object state) { }

			[Address(RVA = "0xA482F0", Offset = "0xA476F0", Length = "0x183")]
			[Token(Token = "0x6000543")]
			internal void <.ctor>b__2_3(object state) { }

			[Address(RVA = "0xA49290", Offset = "0xA48690", Length = "0x183")]
			[Token(Token = "0x6000544")]
			internal void <.ctor>b__2_4(object state) { }

			[Address(RVA = "0xA49740", Offset = "0xA48B40", Length = "0x183")]
			[Token(Token = "0x6000545")]
			internal void <.ctor>b__2_5(object state) { }

			[Address(RVA = "0xA4A870", Offset = "0xA49C70", Length = "0x183")]
			[Token(Token = "0x6000546")]
			internal void <.ctor>b__2_6(object state) { }

			[Address(RVA = "0xA4B9A0", Offset = "0xA4ADA0", Length = "0x183")]
			[Token(Token = "0x6000547")]
			internal void <.ctor>b__2_7(object state) { }

			[Address(RVA = "0xA4C300", Offset = "0xA4B700", Length = "0x183")]
			[Token(Token = "0x6000548")]
			internal void <.ctor>b__2_8(object state) { }

			[Address(RVA = "0xA4D430", Offset = "0xA4C830", Length = "0x183")]
			[Token(Token = "0x6000549")]
			internal void <.ctor>b__2_9(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002EC")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002ED")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "result1", "result2", "result3", "result4", "result5", "result6", "result7", "result8", "result9", "result10", "result11", null, null, null, null, null})]
		private UniTaskCompletionSourceCore<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`5<T7, T8, T9, T10, T11>>> core; //Field offset: 0x0

		[Address(RVA = "0x14BEE80", Offset = "0x14BE280", Length = "0x2170")]
		[Token(Token = "0x600052D")]
		public WhenAnyPromise`11(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11) { }

		[Address(RVA = "0x14B3610", Offset = "0x14B2A10", Length = "0xB8")]
		[Token(Token = "0x600053D")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x14B36D0", Offset = "0x14B2AD0", Length = "0x12D")]
		[Token(Token = "0x6000539")]
		public override ValueTuple<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`5<T7, T8, T9, T10, T11>> GetResult(short token) { }

		[Address(RVA = "0x14B3800", Offset = "0x14B2C00", Length = "0x6A")]
		[Token(Token = "0x600053A")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x14B3870", Offset = "0x14B2C70", Length = "0x95")]
		[Token(Token = "0x600053B")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x14B59F0", Offset = "0x14B4DF0", Length = "0x1070")]
		[Token(Token = "0x600052E")]
		private static void TryInvokeContinuationT1(WhenAnyPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x14B3910", Offset = "0x14B2D10", Length = "0x1068")]
		[Token(Token = "0x6000537")]
		private static void TryInvokeContinuationT10(WhenAnyPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T10> awaiter) { }

		[Address(RVA = "0x14B4980", Offset = "0x14B3D80", Length = "0x1063")]
		[Token(Token = "0x6000538")]
		private static void TryInvokeContinuationT11(WhenAnyPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T11> awaiter) { }

		[Address(RVA = "0x14B6A60", Offset = "0x14B5E60", Length = "0x106F")]
		[Token(Token = "0x600052F")]
		private static void TryInvokeContinuationT2(WhenAnyPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x14B7AD0", Offset = "0x14B6ED0", Length = "0x1071")]
		[Token(Token = "0x6000530")]
		private static void TryInvokeContinuationT3(WhenAnyPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x14B8B50", Offset = "0x14B7F50", Length = "0x1071")]
		[Token(Token = "0x6000531")]
		private static void TryInvokeContinuationT4(WhenAnyPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x14B9BD0", Offset = "0x14B8FD0", Length = "0x1071")]
		[Token(Token = "0x6000532")]
		private static void TryInvokeContinuationT5(WhenAnyPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x14BAC50", Offset = "0x14BA050", Length = "0x1072")]
		[Token(Token = "0x6000533")]
		private static void TryInvokeContinuationT6(WhenAnyPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x14BBCD0", Offset = "0x14BB0D0", Length = "0x106D")]
		[Token(Token = "0x6000534")]
		private static void TryInvokeContinuationT7(WhenAnyPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x14BCD40", Offset = "0x14BC140", Length = "0x106C")]
		[Token(Token = "0x6000535")]
		private static void TryInvokeContinuationT8(WhenAnyPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x14BDDB0", Offset = "0x14BD1B0", Length = "0x1067")]
		[Token(Token = "0x6000536")]
		private static void TryInvokeContinuationT9(WhenAnyPromise1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, in Awaiter<T9> awaiter) { }

		[Address(RVA = "0x14BEE20", Offset = "0x14BE220", Length = "0x5A")]
		[Token(Token = "0x600053C")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000D4")]
	private sealed class WhenAnyPromise2 : IUniTaskSource<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`6<T7, T8, T9, T10, T11, T12>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000D5")]
		private sealed class <>c
		{
			[Token(Token = "0x40002FC")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> <>9; //Field offset: 0x0
			[Token(Token = "0x40002FD")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x40002FE")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0
			[Token(Token = "0x40002FF")]
			public static Action<Object> <>9__2_2; //Field offset: 0x0
			[Token(Token = "0x4000300")]
			public static Action<Object> <>9__2_3; //Field offset: 0x0
			[Token(Token = "0x4000301")]
			public static Action<Object> <>9__2_4; //Field offset: 0x0
			[Token(Token = "0x4000302")]
			public static Action<Object> <>9__2_5; //Field offset: 0x0
			[Token(Token = "0x4000303")]
			public static Action<Object> <>9__2_6; //Field offset: 0x0
			[Token(Token = "0x4000304")]
			public static Action<Object> <>9__2_7; //Field offset: 0x0
			[Token(Token = "0x4000305")]
			public static Action<Object> <>9__2_8; //Field offset: 0x0
			[Token(Token = "0x4000306")]
			public static Action<Object> <>9__2_9; //Field offset: 0x0
			[Token(Token = "0x4000307")]
			public static Action<Object> <>9__2_10; //Field offset: 0x0
			[Token(Token = "0x4000308")]
			public static Action<Object> <>9__2_11; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x600055D")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600055E")]
			public <>c() { }

			[Address(RVA = "0xA42E00", Offset = "0xA42200", Length = "0x174")]
			[Token(Token = "0x600055F")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA45B50", Offset = "0xA44F50", Length = "0x174")]
			[Token(Token = "0x6000560")]
			internal void <.ctor>b__2_1(object state) { }

			[Address(RVA = "0xA435B0", Offset = "0xA429B0", Length = "0x183")]
			[Token(Token = "0x6000569")]
			internal void <.ctor>b__2_10(object state) { }

			[Address(RVA = "0xA43D80", Offset = "0xA43180", Length = "0x183")]
			[Token(Token = "0x600056A")]
			internal void <.ctor>b__2_11(object state) { }

			[Address(RVA = "0xA46BD0", Offset = "0xA45FD0", Length = "0x174")]
			[Token(Token = "0x6000561")]
			internal void <.ctor>b__2_2(object state) { }

			[Address(RVA = "0xA47CB0", Offset = "0xA470B0", Length = "0x183")]
			[Token(Token = "0x6000562")]
			internal void <.ctor>b__2_3(object state) { }

			[Address(RVA = "0xA48930", Offset = "0xA47D30", Length = "0x183")]
			[Token(Token = "0x6000563")]
			internal void <.ctor>b__2_4(object state) { }

			[Address(RVA = "0xA49A60", Offset = "0xA48E60", Length = "0x183")]
			[Token(Token = "0x6000564")]
			internal void <.ctor>b__2_5(object state) { }

			[Address(RVA = "0xA4AEB0", Offset = "0xA4A2B0", Length = "0x183")]
			[Token(Token = "0x6000565")]
			internal void <.ctor>b__2_6(object state) { }

			[Address(RVA = "0xA4BB30", Offset = "0xA4AF30", Length = "0x183")]
			[Token(Token = "0x6000566")]
			internal void <.ctor>b__2_7(object state) { }

			[Address(RVA = "0xA4C940", Offset = "0xA4BD40", Length = "0x183")]
			[Token(Token = "0x6000567")]
			internal void <.ctor>b__2_8(object state) { }

			[Address(RVA = "0xA4CC60", Offset = "0xA4C060", Length = "0x183")]
			[Token(Token = "0x6000568")]
			internal void <.ctor>b__2_9(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002FA")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002FB")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "result1", "result2", "result3", "result4", "result5", "result6", "result7", "result8", "result9", "result10", "result11", "result12", null, null, null, null, null, null})]
		private UniTaskCompletionSourceCore<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`6<T7, T8, T9, T10, T11, T12>>> core; //Field offset: 0x0

		[Address(RVA = "0x14CE710", Offset = "0x14CDB10", Length = "0x248A")]
		[Token(Token = "0x600054B")]
		public WhenAnyPromise`12(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12) { }

		[Address(RVA = "0x14C0FF0", Offset = "0x14C03F0", Length = "0xB8")]
		[Token(Token = "0x600055C")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x14C10B0", Offset = "0x14C04B0", Length = "0x12D")]
		[Token(Token = "0x6000558")]
		public override ValueTuple<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`6<T7, T8, T9, T10, T11, T12>> GetResult(short token) { }

		[Address(RVA = "0x14C11E0", Offset = "0x14C05E0", Length = "0x6A")]
		[Token(Token = "0x6000559")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x14C1250", Offset = "0x14C0650", Length = "0x95")]
		[Token(Token = "0x600055A")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x14C47F0", Offset = "0x14C3BF0", Length = "0x11A5")]
		[Token(Token = "0x600054C")]
		private static void TryInvokeContinuationT1(WhenAnyPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x14C12F0", Offset = "0x14C06F0", Length = "0x11A4")]
		[Token(Token = "0x6000555")]
		private static void TryInvokeContinuationT10(WhenAnyPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T10> awaiter) { }

		[Address(RVA = "0x14C24A0", Offset = "0x14C18A0", Length = "0x11AA")]
		[Token(Token = "0x6000556")]
		private static void TryInvokeContinuationT11(WhenAnyPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T11> awaiter) { }

		[Address(RVA = "0x14C3650", Offset = "0x14C2A50", Length = "0x11A0")]
		[Token(Token = "0x6000557")]
		private static void TryInvokeContinuationT12(WhenAnyPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T12> awaiter) { }

		[Address(RVA = "0x14C59A0", Offset = "0x14C4DA0", Length = "0x119D")]
		[Token(Token = "0x600054D")]
		private static void TryInvokeContinuationT2(WhenAnyPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x14C6B40", Offset = "0x14C5F40", Length = "0x119D")]
		[Token(Token = "0x600054E")]
		private static void TryInvokeContinuationT3(WhenAnyPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x14C7CE0", Offset = "0x14C70E0", Length = "0x119D")]
		[Token(Token = "0x600054F")]
		private static void TryInvokeContinuationT4(WhenAnyPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x14C8E80", Offset = "0x14C8280", Length = "0x119E")]
		[Token(Token = "0x6000550")]
		private static void TryInvokeContinuationT5(WhenAnyPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x14CA020", Offset = "0x14C9420", Length = "0x119E")]
		[Token(Token = "0x6000551")]
		private static void TryInvokeContinuationT6(WhenAnyPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x14CB1C0", Offset = "0x14CA5C0", Length = "0x119F")]
		[Token(Token = "0x6000552")]
		private static void TryInvokeContinuationT7(WhenAnyPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x14CC360", Offset = "0x14CB760", Length = "0x119F")]
		[Token(Token = "0x6000553")]
		private static void TryInvokeContinuationT8(WhenAnyPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x14CD500", Offset = "0x14CC900", Length = "0x11A8")]
		[Token(Token = "0x6000554")]
		private static void TryInvokeContinuationT9(WhenAnyPromise2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, in Awaiter<T9> awaiter) { }

		[Address(RVA = "0x14CE6B0", Offset = "0x14CDAB0", Length = "0x5A")]
		[Token(Token = "0x600055B")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000D6")]
	private sealed class WhenAnyPromise3 : IUniTaskSource<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`7<T7, T8, T9, T10, T11, T12, T13>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000D7")]
		private sealed class <>c
		{
			[Token(Token = "0x400030B")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> <>9; //Field offset: 0x0
			[Token(Token = "0x400030C")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x400030D")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0
			[Token(Token = "0x400030E")]
			public static Action<Object> <>9__2_2; //Field offset: 0x0
			[Token(Token = "0x400030F")]
			public static Action<Object> <>9__2_3; //Field offset: 0x0
			[Token(Token = "0x4000310")]
			public static Action<Object> <>9__2_4; //Field offset: 0x0
			[Token(Token = "0x4000311")]
			public static Action<Object> <>9__2_5; //Field offset: 0x0
			[Token(Token = "0x4000312")]
			public static Action<Object> <>9__2_6; //Field offset: 0x0
			[Token(Token = "0x4000313")]
			public static Action<Object> <>9__2_7; //Field offset: 0x0
			[Token(Token = "0x4000314")]
			public static Action<Object> <>9__2_8; //Field offset: 0x0
			[Token(Token = "0x4000315")]
			public static Action<Object> <>9__2_9; //Field offset: 0x0
			[Token(Token = "0x4000316")]
			public static Action<Object> <>9__2_10; //Field offset: 0x0
			[Token(Token = "0x4000317")]
			public static Action<Object> <>9__2_11; //Field offset: 0x0
			[Token(Token = "0x4000318")]
			public static Action<Object> <>9__2_12; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x600057E")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600057F")]
			public <>c() { }

			[Address(RVA = "0xA417A0", Offset = "0xA40BA0", Length = "0x174")]
			[Token(Token = "0x6000580")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA45CD0", Offset = "0xA450D0", Length = "0x174")]
			[Token(Token = "0x6000581")]
			internal void <.ctor>b__2_1(object state) { }

			[Address(RVA = "0xA43290", Offset = "0xA42690", Length = "0x183")]
			[Token(Token = "0x600058A")]
			internal void <.ctor>b__2_10(object state) { }

			[Address(RVA = "0xA43BF0", Offset = "0xA42FF0", Length = "0x183")]
			[Token(Token = "0x600058B")]
			internal void <.ctor>b__2_11(object state) { }

			[Address(RVA = "0xA440A0", Offset = "0xA434A0", Length = "0x183")]
			[Token(Token = "0x600058C")]
			internal void <.ctor>b__2_12(object state) { }

			[Address(RVA = "0xA471D0", Offset = "0xA465D0", Length = "0x174")]
			[Token(Token = "0x6000582")]
			internal void <.ctor>b__2_2(object state) { }

			[Address(RVA = "0xA47800", Offset = "0xA46C00", Length = "0x183")]
			[Token(Token = "0x6000583")]
			internal void <.ctor>b__2_3(object state) { }

			[Address(RVA = "0xA49100", Offset = "0xA48500", Length = "0x183")]
			[Token(Token = "0x6000584")]
			internal void <.ctor>b__2_4(object state) { }

			[Address(RVA = "0xA4A230", Offset = "0xA49630", Length = "0x183")]
			[Token(Token = "0x6000585")]
			internal void <.ctor>b__2_5(object state) { }

			[Address(RVA = "0xA4AD20", Offset = "0xA4A120", Length = "0x183")]
			[Token(Token = "0x6000586")]
			internal void <.ctor>b__2_6(object state) { }

			[Address(RVA = "0xA4BFE0", Offset = "0xA4B3E0", Length = "0x183")]
			[Token(Token = "0x6000587")]
			internal void <.ctor>b__2_7(object state) { }

			[Address(RVA = "0xA4C7B0", Offset = "0xA4BBB0", Length = "0x183")]
			[Token(Token = "0x6000588")]
			internal void <.ctor>b__2_8(object state) { }

			[Address(RVA = "0xA4CF80", Offset = "0xA4C380", Length = "0x183")]
			[Token(Token = "0x6000589")]
			internal void <.ctor>b__2_9(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000309")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400030A")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "result1", "result2", "result3", "result4", "result5", "result6", "result7", "result8", "result9", "result10", "result11", "result12", "result13", null, null, null, null, null, null, null})]
		private UniTaskCompletionSourceCore<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`7<T7, T8, T9, T10, T11, T12, T13>>> core; //Field offset: 0x0

		[Address(RVA = "0x14E0580", Offset = "0x14DF980", Length = "0x2794")]
		[Token(Token = "0x600056B")]
		public WhenAnyPromise`13(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13) { }

		[Address(RVA = "0x14D0BA0", Offset = "0x14CFFA0", Length = "0xB8")]
		[Token(Token = "0x600057D")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x14D0C60", Offset = "0x14D0060", Length = "0x12D")]
		[Token(Token = "0x6000579")]
		public override ValueTuple<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`7<T7, T8, T9, T10, T11, T12, T13>> GetResult(short token) { }

		[Address(RVA = "0x14D0D90", Offset = "0x14D0190", Length = "0x6A")]
		[Token(Token = "0x600057A")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x14D0E00", Offset = "0x14D0200", Length = "0x95")]
		[Token(Token = "0x600057B")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x14D5A70", Offset = "0x14D4E70", Length = "0x12F7")]
		[Token(Token = "0x600056C")]
		private static void TryInvokeContinuationT1(WhenAnyPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x14D0EA0", Offset = "0x14D02A0", Length = "0x12EC")]
		[Token(Token = "0x6000575")]
		private static void TryInvokeContinuationT10(WhenAnyPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T10> awaiter) { }

		[Address(RVA = "0x14D2190", Offset = "0x14D1590", Length = "0x12F6")]
		[Token(Token = "0x6000576")]
		private static void TryInvokeContinuationT11(WhenAnyPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T11> awaiter) { }

		[Address(RVA = "0x14D3490", Offset = "0x14D2890", Length = "0x12E5")]
		[Token(Token = "0x6000577")]
		private static void TryInvokeContinuationT12(WhenAnyPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T12> awaiter) { }

		[Address(RVA = "0x14D4780", Offset = "0x14D3B80", Length = "0x12E5")]
		[Token(Token = "0x6000578")]
		private static void TryInvokeContinuationT13(WhenAnyPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T13> awaiter) { }

		[Address(RVA = "0x14D6D70", Offset = "0x14D6170", Length = "0x12F7")]
		[Token(Token = "0x600056D")]
		private static void TryInvokeContinuationT2(WhenAnyPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x14D8070", Offset = "0x14D7470", Length = "0x12F6")]
		[Token(Token = "0x600056E")]
		private static void TryInvokeContinuationT3(WhenAnyPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x14D9370", Offset = "0x14D8770", Length = "0x12F5")]
		[Token(Token = "0x600056F")]
		private static void TryInvokeContinuationT4(WhenAnyPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x14DA670", Offset = "0x14D9A70", Length = "0x12EE")]
		[Token(Token = "0x6000570")]
		private static void TryInvokeContinuationT5(WhenAnyPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x14DB960", Offset = "0x14DAD60", Length = "0x12EE")]
		[Token(Token = "0x6000571")]
		private static void TryInvokeContinuationT6(WhenAnyPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x14DCC50", Offset = "0x14DC050", Length = "0x12EF")]
		[Token(Token = "0x6000572")]
		private static void TryInvokeContinuationT7(WhenAnyPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x14DDF40", Offset = "0x14DD340", Length = "0x12F0")]
		[Token(Token = "0x6000573")]
		private static void TryInvokeContinuationT8(WhenAnyPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x14DF230", Offset = "0x14DE630", Length = "0x12F0")]
		[Token(Token = "0x6000574")]
		private static void TryInvokeContinuationT9(WhenAnyPromise3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, in Awaiter<T9> awaiter) { }

		[Address(RVA = "0x14E0520", Offset = "0x14DF920", Length = "0x5A")]
		[Token(Token = "0x600057C")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000D8")]
	private sealed class WhenAnyPromise4 : IUniTaskSource<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`8<T7, T8, T9, T10, T11, T12, T13, ValueTuple`1<T14>>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000D9")]
		private sealed class <>c
		{
			[Token(Token = "0x400031B")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> <>9; //Field offset: 0x0
			[Token(Token = "0x400031C")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x400031D")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0
			[Token(Token = "0x400031E")]
			public static Action<Object> <>9__2_2; //Field offset: 0x0
			[Token(Token = "0x400031F")]
			public static Action<Object> <>9__2_3; //Field offset: 0x0
			[Token(Token = "0x4000320")]
			public static Action<Object> <>9__2_4; //Field offset: 0x0
			[Token(Token = "0x4000321")]
			public static Action<Object> <>9__2_5; //Field offset: 0x0
			[Token(Token = "0x4000322")]
			public static Action<Object> <>9__2_6; //Field offset: 0x0
			[Token(Token = "0x4000323")]
			public static Action<Object> <>9__2_7; //Field offset: 0x0
			[Token(Token = "0x4000324")]
			public static Action<Object> <>9__2_8; //Field offset: 0x0
			[Token(Token = "0x4000325")]
			public static Action<Object> <>9__2_9; //Field offset: 0x0
			[Token(Token = "0x4000326")]
			public static Action<Object> <>9__2_10; //Field offset: 0x0
			[Token(Token = "0x4000327")]
			public static Action<Object> <>9__2_11; //Field offset: 0x0
			[Token(Token = "0x4000328")]
			public static Action<Object> <>9__2_12; //Field offset: 0x0
			[Token(Token = "0x4000329")]
			public static Action<Object> <>9__2_13; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x60005A1")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60005A2")]
			public <>c() { }

			[Address(RVA = "0xA42C80", Offset = "0xA42080", Length = "0x174")]
			[Token(Token = "0x60005A3")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA456D0", Offset = "0xA44AD0", Length = "0x174")]
			[Token(Token = "0x60005A4")]
			internal void <.ctor>b__2_1(object state) { }

			[Address(RVA = "0xA43420", Offset = "0xA42820", Length = "0x183")]
			[Token(Token = "0x60005AD")]
			internal void <.ctor>b__2_10(object state) { }

			[Address(RVA = "0xA438D0", Offset = "0xA42CD0", Length = "0x183")]
			[Token(Token = "0x60005AE")]
			internal void <.ctor>b__2_11(object state) { }

			[Address(RVA = "0xA44230", Offset = "0xA43630", Length = "0x183")]
			[Token(Token = "0x60005AF")]
			internal void <.ctor>b__2_12(object state) { }

			[Address(RVA = "0xA44550", Offset = "0xA43950", Length = "0x183")]
			[Token(Token = "0x60005B0")]
			internal void <.ctor>b__2_13(object state) { }

			[Address(RVA = "0xA46750", Offset = "0xA45B50", Length = "0x174")]
			[Token(Token = "0x60005A5")]
			internal void <.ctor>b__2_2(object state) { }

			[Address(RVA = "0xA47B20", Offset = "0xA46F20", Length = "0x183")]
			[Token(Token = "0x60005A6")]
			internal void <.ctor>b__2_3(object state) { }

			[Address(RVA = "0xA49420", Offset = "0xA48820", Length = "0x183")]
			[Token(Token = "0x60005A7")]
			internal void <.ctor>b__2_4(object state) { }

			[Address(RVA = "0xA4A550", Offset = "0xA49950", Length = "0x183")]
			[Token(Token = "0x60005A8")]
			internal void <.ctor>b__2_5(object state) { }

			[Address(RVA = "0xA4B040", Offset = "0xA4A440", Length = "0x183")]
			[Token(Token = "0x60005A9")]
			internal void <.ctor>b__2_6(object state) { }

			[Address(RVA = "0xA4B4F0", Offset = "0xA4A8F0", Length = "0x183")]
			[Token(Token = "0x60005AA")]
			internal void <.ctor>b__2_7(object state) { }

			[Address(RVA = "0xA4C490", Offset = "0xA4B890", Length = "0x183")]
			[Token(Token = "0x60005AB")]
			internal void <.ctor>b__2_8(object state) { }

			[Address(RVA = "0xA4CDF0", Offset = "0xA4C1F0", Length = "0x183")]
			[Token(Token = "0x60005AC")]
			internal void <.ctor>b__2_9(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000319")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400031A")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "result1", "result2", "result3", "result4", "result5", "result6", "result7", "result8", "result9", "result10", "result11", "result12", "result13", "result14", null, null, null, null, null, null, null, null, null})]
		private UniTaskCompletionSourceCore<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`8<T7, T8, T9, T10, T11, T12, T13, ValueTuple`1<T14>>>> core; //Field offset: 0x0

		[Address(RVA = "0x14F63D0", Offset = "0x14F57D0", Length = "0x2AAE")]
		[Token(Token = "0x600058D")]
		public WhenAnyPromise`14(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14) { }

		[Address(RVA = "0x14E38D0", Offset = "0x14E2CD0", Length = "0xB8")]
		[Token(Token = "0x60005A0")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x14E3990", Offset = "0x14E2D90", Length = "0x12D")]
		[Token(Token = "0x600059C")]
		public override ValueTuple<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`8<T7, T8, T9, T10, T11, T12, T13, ValueTuple`1<T14>>> GetResult(short token) { }

		[Address(RVA = "0x14E3AC0", Offset = "0x14E2EC0", Length = "0x6A")]
		[Token(Token = "0x600059D")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x14E3B30", Offset = "0x14E2F30", Length = "0x95")]
		[Token(Token = "0x600059E")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x14EA560", Offset = "0x14E9960", Length = "0x1511")]
		[Token(Token = "0x600058E")]
		private static void TryInvokeContinuationT1(WhenAnyPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x14E3BD0", Offset = "0x14E2FD0", Length = "0x1513")]
		[Token(Token = "0x6000597")]
		private static void TryInvokeContinuationT10(WhenAnyPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T10> awaiter) { }

		[Address(RVA = "0x14E50F0", Offset = "0x14E44F0", Length = "0x1515")]
		[Token(Token = "0x6000598")]
		private static void TryInvokeContinuationT11(WhenAnyPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T11> awaiter) { }

		[Address(RVA = "0x14E6610", Offset = "0x14E5A10", Length = "0x1515")]
		[Token(Token = "0x6000599")]
		private static void TryInvokeContinuationT12(WhenAnyPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T12> awaiter) { }

		[Address(RVA = "0x14E7B30", Offset = "0x14E6F30", Length = "0x1515")]
		[Token(Token = "0x600059A")]
		private static void TryInvokeContinuationT13(WhenAnyPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T13> awaiter) { }

		[Address(RVA = "0x14E9050", Offset = "0x14E8450", Length = "0x1510")]
		[Token(Token = "0x600059B")]
		private static void TryInvokeContinuationT14(WhenAnyPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T14> awaiter) { }

		[Address(RVA = "0x14EBA80", Offset = "0x14EAE80", Length = "0x1512")]
		[Token(Token = "0x600058F")]
		private static void TryInvokeContinuationT2(WhenAnyPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x14ECFA0", Offset = "0x14EC3A0", Length = "0x1512")]
		[Token(Token = "0x6000590")]
		private static void TryInvokeContinuationT3(WhenAnyPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x14EE4C0", Offset = "0x14ED8C0", Length = "0x151A")]
		[Token(Token = "0x6000591")]
		private static void TryInvokeContinuationT4(WhenAnyPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x14EF9E0", Offset = "0x14EEDE0", Length = "0x1519")]
		[Token(Token = "0x6000592")]
		private static void TryInvokeContinuationT5(WhenAnyPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x14F0F00", Offset = "0x14F0300", Length = "0x1518")]
		[Token(Token = "0x6000593")]
		private static void TryInvokeContinuationT6(WhenAnyPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x14F2420", Offset = "0x14F1820", Length = "0x1510")]
		[Token(Token = "0x6000594")]
		private static void TryInvokeContinuationT7(WhenAnyPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x14F3930", Offset = "0x14F2D30", Length = "0x1512")]
		[Token(Token = "0x6000595")]
		private static void TryInvokeContinuationT8(WhenAnyPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x14F4E50", Offset = "0x14F4250", Length = "0x1513")]
		[Token(Token = "0x6000596")]
		private static void TryInvokeContinuationT9(WhenAnyPromise4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, in Awaiter<T9> awaiter) { }

		[Address(RVA = "0x14F6370", Offset = "0x14F5770", Length = "0x5A")]
		[Token(Token = "0x600059F")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000DA")]
	private sealed class WhenAnyPromise5 : IUniTaskSource<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`8<T7, T8, T9, T10, T11, T12, T13, ValueTuple`2<T14, T15>>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000DB")]
		private sealed class <>c
		{
			[Token(Token = "0x400032C")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> <>9; //Field offset: 0x0
			[Token(Token = "0x400032D")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x400032E")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0
			[Token(Token = "0x400032F")]
			public static Action<Object> <>9__2_2; //Field offset: 0x0
			[Token(Token = "0x4000330")]
			public static Action<Object> <>9__2_3; //Field offset: 0x0
			[Token(Token = "0x4000331")]
			public static Action<Object> <>9__2_4; //Field offset: 0x0
			[Token(Token = "0x4000332")]
			public static Action<Object> <>9__2_5; //Field offset: 0x0
			[Token(Token = "0x4000333")]
			public static Action<Object> <>9__2_6; //Field offset: 0x0
			[Token(Token = "0x4000334")]
			public static Action<Object> <>9__2_7; //Field offset: 0x0
			[Token(Token = "0x4000335")]
			public static Action<Object> <>9__2_8; //Field offset: 0x0
			[Token(Token = "0x4000336")]
			public static Action<Object> <>9__2_9; //Field offset: 0x0
			[Token(Token = "0x4000337")]
			public static Action<Object> <>9__2_10; //Field offset: 0x0
			[Token(Token = "0x4000338")]
			public static Action<Object> <>9__2_11; //Field offset: 0x0
			[Token(Token = "0x4000339")]
			public static Action<Object> <>9__2_12; //Field offset: 0x0
			[Token(Token = "0x400033A")]
			public static Action<Object> <>9__2_13; //Field offset: 0x0
			[Token(Token = "0x400033B")]
			public static Action<Object> <>9__2_14; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x60005C6")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60005C7")]
			public <>c() { }

			[Address(RVA = "0xA42050", Offset = "0xA41450", Length = "0x174")]
			[Token(Token = "0x60005C8")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA45250", Offset = "0xA44650", Length = "0x174")]
			[Token(Token = "0x60005C9")]
			internal void <.ctor>b__2_1(object state) { }

			[Address(RVA = "0xA43740", Offset = "0xA42B40", Length = "0x183")]
			[Token(Token = "0x60005D2")]
			internal void <.ctor>b__2_10(object state) { }

			[Address(RVA = "0xA43A60", Offset = "0xA42E60", Length = "0x183")]
			[Token(Token = "0x60005D3")]
			internal void <.ctor>b__2_11(object state) { }

			[Address(RVA = "0xA43F10", Offset = "0xA43310", Length = "0x183")]
			[Token(Token = "0x60005D4")]
			internal void <.ctor>b__2_12(object state) { }

			[Address(RVA = "0xA443C0", Offset = "0xA437C0", Length = "0x183")]
			[Token(Token = "0x60005D5")]
			internal void <.ctor>b__2_13(object state) { }

			[Address(RVA = "0xA446E0", Offset = "0xA43AE0", Length = "0x183")]
			[Token(Token = "0x60005D6")]
			internal void <.ctor>b__2_14(object state) { }

			[Address(RVA = "0xA45FD0", Offset = "0xA453D0", Length = "0x174")]
			[Token(Token = "0x60005CA")]
			internal void <.ctor>b__2_2(object state) { }

			[Address(RVA = "0xA47990", Offset = "0xA46D90", Length = "0x183")]
			[Token(Token = "0x60005CB")]
			internal void <.ctor>b__2_3(object state) { }

			[Address(RVA = "0xA48610", Offset = "0xA47A10", Length = "0x183")]
			[Token(Token = "0x60005CC")]
			internal void <.ctor>b__2_4(object state) { }

			[Address(RVA = "0xA49D80", Offset = "0xA49180", Length = "0x183")]
			[Token(Token = "0x60005CD")]
			internal void <.ctor>b__2_5(object state) { }

			[Address(RVA = "0xA4AB90", Offset = "0xA49F90", Length = "0x183")]
			[Token(Token = "0x60005CE")]
			internal void <.ctor>b__2_6(object state) { }

			[Address(RVA = "0xA4B680", Offset = "0xA4AA80", Length = "0x183")]
			[Token(Token = "0x60005CF")]
			internal void <.ctor>b__2_7(object state) { }

			[Address(RVA = "0xA4C620", Offset = "0xA4BA20", Length = "0x183")]
			[Token(Token = "0x60005D0")]
			internal void <.ctor>b__2_8(object state) { }

			[Address(RVA = "0xA4D110", Offset = "0xA4C510", Length = "0x183")]
			[Token(Token = "0x60005D1")]
			internal void <.ctor>b__2_9(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400032A")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400032B")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "result1", "result2", "result3", "result4", "result5", "result6", "result7", "result8", "result9", "result10", "result11", "result12", "result13", "result14", "result15", null, null, null, null, null, null, null, null, null, null, null})]
		private UniTaskCompletionSourceCore<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`8<T7, T8, T9, T10, T11, T12, T13, ValueTuple`2<T14, T15>>>> core; //Field offset: 0x0

		[Address(RVA = "0x150E0C0", Offset = "0x150D4C0", Length = "0x2DB9")]
		[Token(Token = "0x60005B1")]
		public WhenAnyPromise`15(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14, UniTask<T15> task15) { }

		[Address(RVA = "0x14F8E80", Offset = "0x14F8280", Length = "0xB8")]
		[Token(Token = "0x60005C5")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x14F8F40", Offset = "0x14F8340", Length = "0x12D")]
		[Token(Token = "0x60005C1")]
		public override ValueTuple<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`8<T7, T8, T9, T10, T11, T12, T13, ValueTuple`2<T14, T15>>> GetResult(short token) { }

		[Address(RVA = "0x14F9070", Offset = "0x14F8470", Length = "0x6A")]
		[Token(Token = "0x60005C2")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x14F90E0", Offset = "0x14F84E0", Length = "0x95")]
		[Token(Token = "0x60005C3")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1501770", Offset = "0x1500B70", Length = "0x164D")]
		[Token(Token = "0x60005B2")]
		private static void TryInvokeContinuationT1(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x14F9180", Offset = "0x14F8580", Length = "0x164F")]
		[Token(Token = "0x60005BB")]
		private static void TryInvokeContinuationT10(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T10> awaiter) { }

		[Address(RVA = "0x14FA7D0", Offset = "0x14F9BD0", Length = "0x164F")]
		[Token(Token = "0x60005BC")]
		private static void TryInvokeContinuationT11(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T11> awaiter) { }

		[Address(RVA = "0x14FBE20", Offset = "0x14FB220", Length = "0x1654")]
		[Token(Token = "0x60005BD")]
		private static void TryInvokeContinuationT12(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T12> awaiter) { }

		[Address(RVA = "0x14FD480", Offset = "0x14FC880", Length = "0x164C")]
		[Token(Token = "0x60005BE")]
		private static void TryInvokeContinuationT13(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T13> awaiter) { }

		[Address(RVA = "0x14FEAD0", Offset = "0x14FDED0", Length = "0x164A")]
		[Token(Token = "0x60005BF")]
		private static void TryInvokeContinuationT14(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T14> awaiter) { }

		[Address(RVA = "0x1500120", Offset = "0x14FF520", Length = "0x164B")]
		[Token(Token = "0x60005C0")]
		private static void TryInvokeContinuationT15(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T15> awaiter) { }

		[Address(RVA = "0x1502DC0", Offset = "0x15021C0", Length = "0x164E")]
		[Token(Token = "0x60005B3")]
		private static void TryInvokeContinuationT2(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1504410", Offset = "0x1503810", Length = "0x164E")]
		[Token(Token = "0x60005B4")]
		private static void TryInvokeContinuationT3(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x1505A60", Offset = "0x1504E60", Length = "0x164E")]
		[Token(Token = "0x60005B5")]
		private static void TryInvokeContinuationT4(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x15070B0", Offset = "0x15064B0", Length = "0x164E")]
		[Token(Token = "0x60005B6")]
		private static void TryInvokeContinuationT5(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x1508700", Offset = "0x1507B00", Length = "0x108C")]
		[Token(Token = "0x60005B7")]
		private static void TryInvokeContinuationT6(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x1509D60", Offset = "0x1509160", Length = "0x1654")]
		[Token(Token = "0x60005B8")]
		private static void TryInvokeContinuationT7(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x150B3C0", Offset = "0x150A7C0", Length = "0x164C")]
		[Token(Token = "0x60005B9")]
		private static void TryInvokeContinuationT8(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x150CA10", Offset = "0x150BE10", Length = "0x164E")]
		[Token(Token = "0x60005BA")]
		private static void TryInvokeContinuationT9(WhenAnyPromise5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, in Awaiter<T9> awaiter) { }

		[Address(RVA = "0x150E060", Offset = "0x150D460", Length = "0x5A")]
		[Token(Token = "0x60005C4")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000C0")]
	private sealed class WhenAnyPromise : IUniTaskSource<ValueTuple`3<Int32, T1, T2>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000C1")]
		private sealed class <>c
		{
			[Token(Token = "0x400029D")]
			public static readonly <>c<T1, T2> <>9; //Field offset: 0x0
			[Token(Token = "0x400029E")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x400029F")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0

			[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
			[Token(Token = "0x6000481")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000482")]
			public <>c() { }

			[Address(RVA = "0xA41C20", Offset = "0xA41020", Length = "0x123")]
			[Token(Token = "0x6000483")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA44FA0", Offset = "0xA443A0", Length = "0x123")]
			[Token(Token = "0x6000484")]
			internal void <.ctor>b__2_1(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400029B")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400029C")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "result1", "result2"})]
		private UniTaskCompletionSourceCore<ValueTuple`3<Int32, T1, T2>> core; //Field offset: 0x0

		[Address(RVA = "0x15128C0", Offset = "0x1511CC0", Length = "0x4A5")]
		[Token(Token = "0x6000479")]
		public WhenAnyPromise`2(UniTask<T1> task1, UniTask<T2> task2) { }

		[Address(RVA = "0x1510E80", Offset = "0x1510280", Length = "0x8F")]
		[Token(Token = "0x6000480")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1510FD0", Offset = "0x15103D0", Length = "0x80")]
		[Token(Token = "0x600047C")]
		public override ValueTuple<Int32, T1, T2> GetResult(short token) { }

		[Address(RVA = "0x1511180", Offset = "0x1510580", Length = "0x13D")]
		[Token(Token = "0x600047D")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x15113D0", Offset = "0x15107D0", Length = "0x1C7")]
		[Token(Token = "0x600047E")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x15115A0", Offset = "0x15109A0", Length = "0x12A")]
		[Token(Token = "0x600047A")]
		private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x1511BB0", Offset = "0x1510FB0", Length = "0x12D")]
		[Token(Token = "0x600047B")]
		private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1512220", Offset = "0x1511620", Length = "0x91")]
		[Token(Token = "0x600047F")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000C2")]
	private sealed class WhenAnyPromise : IUniTaskSource<ValueTuple`4<Int32, T1, T2, T3>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000C3")]
		private sealed class <>c
		{
			[Token(Token = "0x40002A2")]
			public static readonly <>c<T1, T2, T3> <>9; //Field offset: 0x0
			[Token(Token = "0x40002A3")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x40002A4")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0
			[Token(Token = "0x40002A5")]
			public static Action<Object> <>9__2_2; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x600048E")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600048F")]
			public <>c() { }

			[Address(RVA = "0xA42980", Offset = "0xA41D80", Length = "0x174")]
			[Token(Token = "0x6000490")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA44870", Offset = "0xA43C70", Length = "0x174")]
			[Token(Token = "0x6000491")]
			internal void <.ctor>b__2_1(object state) { }

			[Address(RVA = "0xA46D50", Offset = "0xA46150", Length = "0x174")]
			[Token(Token = "0x6000492")]
			internal void <.ctor>b__2_2(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A0")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A1")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "result1", "result2", "result3"})]
		private UniTaskCompletionSourceCore<ValueTuple`4<Int32, T1, T2, T3>> core; //Field offset: 0x0

		[Address(RVA = "0x15142D0", Offset = "0x15136D0", Length = "0x8BF")]
		[Token(Token = "0x6000485")]
		public WhenAnyPromise`3(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3) { }

		[Address(RVA = "0x1512D70", Offset = "0x1512170", Length = "0xB8")]
		[Token(Token = "0x600048D")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1512E30", Offset = "0x1512230", Length = "0x12D")]
		[Token(Token = "0x6000489")]
		public override ValueTuple<Int32, T1, T2, T3> GetResult(short token) { }

		[Address(RVA = "0x1512F60", Offset = "0x1512360", Length = "0x6A")]
		[Token(Token = "0x600048A")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1512FD0", Offset = "0x15123D0", Length = "0x95")]
		[Token(Token = "0x600048B")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1513070", Offset = "0x1512470", Length = "0x5FC")]
		[Token(Token = "0x6000486")]
		private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x1513670", Offset = "0x1512A70", Length = "0x5FC")]
		[Token(Token = "0x6000487")]
		private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1513C70", Offset = "0x1513070", Length = "0x5FC")]
		[Token(Token = "0x6000488")]
		private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x1514270", Offset = "0x1513670", Length = "0x5A")]
		[Token(Token = "0x600048C")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000C4")]
	private sealed class WhenAnyPromise : IUniTaskSource<ValueTuple`5<Int32, T1, T2, T3, T4>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000C5")]
		private sealed class <>c
		{
			[Token(Token = "0x40002A8")]
			public static readonly <>c<T1, T2, T3, T4> <>9; //Field offset: 0x0
			[Token(Token = "0x40002A9")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x40002AA")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0
			[Token(Token = "0x40002AB")]
			public static Action<Object> <>9__2_2; //Field offset: 0x0
			[Token(Token = "0x40002AC")]
			public static Action<Object> <>9__2_3; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x600049D")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600049E")]
			public <>c() { }

			[Address(RVA = "0xA42680", Offset = "0xA41A80", Length = "0x174")]
			[Token(Token = "0x600049F")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA453D0", Offset = "0xA447D0", Length = "0x174")]
			[Token(Token = "0x60004A0")]
			internal void <.ctor>b__2_1(object state) { }

			[Address(RVA = "0xA46150", Offset = "0xA45550", Length = "0x174")]
			[Token(Token = "0x60004A1")]
			internal void <.ctor>b__2_2(object state) { }

			[Address(RVA = "0xA47E40", Offset = "0xA47240", Length = "0x183")]
			[Token(Token = "0x60004A2")]
			internal void <.ctor>b__2_3(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A6")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002A7")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "result1", "result2", "result3", "result4"})]
		private UniTaskCompletionSourceCore<ValueTuple`5<Int32, T1, T2, T3, T4>> core; //Field offset: 0x0

		[Address(RVA = "0x1516BA0", Offset = "0x1515FA0", Length = "0xC4D")]
		[Token(Token = "0x6000493")]
		public WhenAnyPromise`4(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4) { }

		[Address(RVA = "0x1514B90", Offset = "0x1513F90", Length = "0xB8")]
		[Token(Token = "0x600049C")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1514C50", Offset = "0x1514050", Length = "0x12D")]
		[Token(Token = "0x6000498")]
		public override ValueTuple<Int32, T1, T2, T3, T4> GetResult(short token) { }

		[Address(RVA = "0x1514D80", Offset = "0x1514180", Length = "0x6A")]
		[Token(Token = "0x6000499")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1514DF0", Offset = "0x15141F0", Length = "0x95")]
		[Token(Token = "0x600049A")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1514E90", Offset = "0x1514290", Length = "0x72E")]
		[Token(Token = "0x6000494")]
		private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x15155C0", Offset = "0x15149C0", Length = "0x720")]
		[Token(Token = "0x6000495")]
		private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1515CE0", Offset = "0x15150E0", Length = "0x723")]
		[Token(Token = "0x6000496")]
		private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x1516410", Offset = "0x1515810", Length = "0x723")]
		[Token(Token = "0x6000497")]
		private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x1516B40", Offset = "0x1515F40", Length = "0x5A")]
		[Token(Token = "0x600049B")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000C6")]
	private sealed class WhenAnyPromise : IUniTaskSource<ValueTuple`6<Int32, T1, T2, T3, T4, T5>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000C7")]
		private sealed class <>c
		{
			[Token(Token = "0x40002AF")]
			public static readonly <>c<T1, T2, T3, T4, T5> <>9; //Field offset: 0x0
			[Token(Token = "0x40002B0")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x40002B1")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0
			[Token(Token = "0x40002B2")]
			public static Action<Object> <>9__2_2; //Field offset: 0x0
			[Token(Token = "0x40002B3")]
			public static Action<Object> <>9__2_3; //Field offset: 0x0
			[Token(Token = "0x40002B4")]
			public static Action<Object> <>9__2_4; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x60004AE")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60004AF")]
			public <>c() { }

			[Address(RVA = "0xA42800", Offset = "0xA41C00", Length = "0x174")]
			[Token(Token = "0x60004B0")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA44B70", Offset = "0xA43F70", Length = "0x174")]
			[Token(Token = "0x60004B1")]
			internal void <.ctor>b__2_1(object state) { }

			[Address(RVA = "0xA462D0", Offset = "0xA456D0", Length = "0x174")]
			[Token(Token = "0x60004B2")]
			internal void <.ctor>b__2_2(object state) { }

			[Address(RVA = "0xA47670", Offset = "0xA46A70", Length = "0x183")]
			[Token(Token = "0x60004B3")]
			internal void <.ctor>b__2_3(object state) { }

			[Address(RVA = "0xA487A0", Offset = "0xA47BA0", Length = "0x183")]
			[Token(Token = "0x60004B4")]
			internal void <.ctor>b__2_4(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002AD")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002AE")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "result1", "result2", "result3", "result4", "result5"})]
		private UniTaskCompletionSourceCore<ValueTuple`6<Int32, T1, T2, T3, T4, T5>> core; //Field offset: 0x0

		[Address(RVA = "0x151A4E0", Offset = "0x15198E0", Length = "0xF3E")]
		[Token(Token = "0x60004A3")]
		public WhenAnyPromise`5(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5) { }

		[Address(RVA = "0x15177F0", Offset = "0x1516BF0", Length = "0xB8")]
		[Token(Token = "0x60004AD")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x15178B0", Offset = "0x1516CB0", Length = "0x12D")]
		[Token(Token = "0x60004A9")]
		public override ValueTuple<Int32, T1, T2, T3, T4, T5> GetResult(short token) { }

		[Address(RVA = "0x15179E0", Offset = "0x1516DE0", Length = "0x6A")]
		[Token(Token = "0x60004AA")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1517A50", Offset = "0x1516E50", Length = "0x95")]
		[Token(Token = "0x60004AB")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1517AF0", Offset = "0x1516EF0", Length = "0x84F")]
		[Token(Token = "0x60004A4")]
		private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x1518340", Offset = "0x1517740", Length = "0x850")]
		[Token(Token = "0x60004A5")]
		private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1518B90", Offset = "0x1517F90", Length = "0x84F")]
		[Token(Token = "0x60004A6")]
		private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x15193E0", Offset = "0x15187E0", Length = "0x844")]
		[Token(Token = "0x60004A7")]
		private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x1519C30", Offset = "0x1519030", Length = "0x84F")]
		[Token(Token = "0x60004A8")]
		private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x151A480", Offset = "0x1519880", Length = "0x5A")]
		[Token(Token = "0x60004AC")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000C8")]
	private sealed class WhenAnyPromise : IUniTaskSource<ValueTuple`7<Int32, T1, T2, T3, T4, T5, T6>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000C9")]
		private sealed class <>c
		{
			[Token(Token = "0x40002B7")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6> <>9; //Field offset: 0x0
			[Token(Token = "0x40002B8")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x40002B9")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0
			[Token(Token = "0x40002BA")]
			public static Action<Object> <>9__2_2; //Field offset: 0x0
			[Token(Token = "0x40002BB")]
			public static Action<Object> <>9__2_3; //Field offset: 0x0
			[Token(Token = "0x40002BC")]
			public static Action<Object> <>9__2_4; //Field offset: 0x0
			[Token(Token = "0x40002BD")]
			public static Action<Object> <>9__2_5; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x60004C1")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60004C2")]
			public <>c() { }

			[Address(RVA = "0xA41ED0", Offset = "0xA412D0", Length = "0x174")]
			[Token(Token = "0x60004C3")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA45E50", Offset = "0xA45250", Length = "0x174")]
			[Token(Token = "0x60004C4")]
			internal void <.ctor>b__2_1(object state) { }

			[Address(RVA = "0xA46A50", Offset = "0xA45E50", Length = "0x174")]
			[Token(Token = "0x60004C5")]
			internal void <.ctor>b__2_2(object state) { }

			[Address(RVA = "0xA474E0", Offset = "0xA468E0", Length = "0x183")]
			[Token(Token = "0x60004C6")]
			internal void <.ctor>b__2_3(object state) { }

			[Address(RVA = "0xA48F70", Offset = "0xA48370", Length = "0x183")]
			[Token(Token = "0x60004C7")]
			internal void <.ctor>b__2_4(object state) { }

			[Address(RVA = "0xA4A3C0", Offset = "0xA497C0", Length = "0x183")]
			[Token(Token = "0x60004C8")]
			internal void <.ctor>b__2_5(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002B5")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002B6")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "result1", "result2", "result3", "result4", "result5", "result6"})]
		private UniTaskCompletionSourceCore<ValueTuple`7<Int32, T1, T2, T3, T4, T5, T6>> core; //Field offset: 0x0

		[Address(RVA = "0x151F0C0", Offset = "0x151E4C0", Length = "0x1247")]
		[Token(Token = "0x60004B5")]
		public WhenAnyPromise`6(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6) { }

		[Address(RVA = "0x151B420", Offset = "0x151A820", Length = "0xB8")]
		[Token(Token = "0x60004C0")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x151B4E0", Offset = "0x151A8E0", Length = "0x12D")]
		[Token(Token = "0x60004BC")]
		public override ValueTuple<Int32, T1, T2, T3, T4, T5, T6> GetResult(short token) { }

		[Address(RVA = "0x151B610", Offset = "0x151AA10", Length = "0x6A")]
		[Token(Token = "0x60004BD")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x151B680", Offset = "0x151AA80", Length = "0x95")]
		[Token(Token = "0x60004BE")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x151B720", Offset = "0x151AB20", Length = "0x992")]
		[Token(Token = "0x60004B6")]
		private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5, T6> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x151C0C0", Offset = "0x151B4C0", Length = "0x990")]
		[Token(Token = "0x60004B7")]
		private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5, T6> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x151CA50", Offset = "0x151BE50", Length = "0x981")]
		[Token(Token = "0x60004B8")]
		private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5, T6> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x151D3E0", Offset = "0x151C7E0", Length = "0x980")]
		[Token(Token = "0x60004B9")]
		private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5, T6> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x151DD60", Offset = "0x151D160", Length = "0x980")]
		[Token(Token = "0x60004BA")]
		private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5, T6> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x151E6E0", Offset = "0x151DAE0", Length = "0x97F")]
		[Token(Token = "0x60004BB")]
		private static void TryInvokeContinuationT6(WhenAnyPromise<T1, T2, T3, T4, T5, T6> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x151F060", Offset = "0x151E460", Length = "0x5A")]
		[Token(Token = "0x60004BF")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000CA")]
	private sealed class WhenAnyPromise : IUniTaskSource<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`1<T7>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000CB")]
		private sealed class <>c
		{
			[Token(Token = "0x40002C0")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7> <>9; //Field offset: 0x0
			[Token(Token = "0x40002C1")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x40002C2")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0
			[Token(Token = "0x40002C3")]
			public static Action<Object> <>9__2_2; //Field offset: 0x0
			[Token(Token = "0x40002C4")]
			public static Action<Object> <>9__2_3; //Field offset: 0x0
			[Token(Token = "0x40002C5")]
			public static Action<Object> <>9__2_4; //Field offset: 0x0
			[Token(Token = "0x40002C6")]
			public static Action<Object> <>9__2_5; //Field offset: 0x0
			[Token(Token = "0x40002C7")]
			public static Action<Object> <>9__2_6; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x60004D6")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60004D7")]
			public <>c() { }

			[Address(RVA = "0xA41920", Offset = "0xA40D20", Length = "0x174")]
			[Token(Token = "0x60004D8")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA45850", Offset = "0xA44C50", Length = "0x174")]
			[Token(Token = "0x60004D9")]
			internal void <.ctor>b__2_1(object state) { }

			[Address(RVA = "0xA47050", Offset = "0xA46450", Length = "0x174")]
			[Token(Token = "0x60004DA")]
			internal void <.ctor>b__2_2(object state) { }

			[Address(RVA = "0xA48160", Offset = "0xA47560", Length = "0x183")]
			[Token(Token = "0x60004DB")]
			internal void <.ctor>b__2_3(object state) { }

			[Address(RVA = "0xA48AC0", Offset = "0xA47EC0", Length = "0x183")]
			[Token(Token = "0x60004DC")]
			internal void <.ctor>b__2_4(object state) { }

			[Address(RVA = "0xA49BF0", Offset = "0xA48FF0", Length = "0x183")]
			[Token(Token = "0x60004DD")]
			internal void <.ctor>b__2_5(object state) { }

			[Address(RVA = "0xA4AA00", Offset = "0xA49E00", Length = "0x183")]
			[Token(Token = "0x60004DE")]
			internal void <.ctor>b__2_6(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002BE")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002BF")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "result1", "result2", "result3", "result4", "result5", "result6", "result7", null})]
		private UniTaskCompletionSourceCore<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`1<T7>>> core; //Field offset: 0x0

		[Address(RVA = "0x15257C0", Offset = "0x1524BC0", Length = "0x1550")]
		[Token(Token = "0x60004C9")]
		public WhenAnyPromise`7(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7) { }

		[Address(RVA = "0x1520310", Offset = "0x151F710", Length = "0xB8")]
		[Token(Token = "0x60004D5")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x15203D0", Offset = "0x151F7D0", Length = "0x12D")]
		[Token(Token = "0x60004D1")]
		public override ValueTuple<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`1<T7>> GetResult(short token) { }

		[Address(RVA = "0x1520500", Offset = "0x151F900", Length = "0x6A")]
		[Token(Token = "0x60004D2")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1520570", Offset = "0x151F970", Length = "0x95")]
		[Token(Token = "0x60004D3")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1520610", Offset = "0x151FA10", Length = "0xB9A")]
		[Token(Token = "0x60004CA")]
		private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x15211B0", Offset = "0x15205B0", Length = "0xB98")]
		[Token(Token = "0x60004CB")]
		private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1521D50", Offset = "0x1521150", Length = "0xBA1")]
		[Token(Token = "0x60004CC")]
		private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x1522900", Offset = "0x1521D00", Length = "0xB93")]
		[Token(Token = "0x60004CD")]
		private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x15234A0", Offset = "0x15228A0", Length = "0xB8A")]
		[Token(Token = "0x60004CE")]
		private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x1524030", Offset = "0x1523430", Length = "0xB8A")]
		[Token(Token = "0x60004CF")]
		private static void TryInvokeContinuationT6(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x1524BC0", Offset = "0x1523FC0", Length = "0xB97")]
		[Token(Token = "0x60004D0")]
		private static void TryInvokeContinuationT7(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x1525760", Offset = "0x1524B60", Length = "0x5A")]
		[Token(Token = "0x60004D4")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000CC")]
	private sealed class WhenAnyPromise : IUniTaskSource<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`2<T7, T8>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000CD")]
		private sealed class <>c
		{
			[Token(Token = "0x40002CA")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8> <>9; //Field offset: 0x0
			[Token(Token = "0x40002CB")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x40002CC")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0
			[Token(Token = "0x40002CD")]
			public static Action<Object> <>9__2_2; //Field offset: 0x0
			[Token(Token = "0x40002CE")]
			public static Action<Object> <>9__2_3; //Field offset: 0x0
			[Token(Token = "0x40002CF")]
			public static Action<Object> <>9__2_4; //Field offset: 0x0
			[Token(Token = "0x40002D0")]
			public static Action<Object> <>9__2_5; //Field offset: 0x0
			[Token(Token = "0x40002D1")]
			public static Action<Object> <>9__2_6; //Field offset: 0x0
			[Token(Token = "0x40002D2")]
			public static Action<Object> <>9__2_7; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x60004ED")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60004EE")]
			public <>c() { }

			[Address(RVA = "0xA41AA0", Offset = "0xA40EA0", Length = "0x174")]
			[Token(Token = "0x60004EF")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA459D0", Offset = "0xA44DD0", Length = "0x174")]
			[Token(Token = "0x60004F0")]
			internal void <.ctor>b__2_1(object state) { }

			[Address(RVA = "0xA468D0", Offset = "0xA45CD0", Length = "0x174")]
			[Token(Token = "0x60004F1")]
			internal void <.ctor>b__2_2(object state) { }

			[Address(RVA = "0xA47350", Offset = "0xA46750", Length = "0x183")]
			[Token(Token = "0x60004F2")]
			internal void <.ctor>b__2_3(object state) { }

			[Address(RVA = "0xA48DE0", Offset = "0xA481E0", Length = "0x183")]
			[Token(Token = "0x60004F3")]
			internal void <.ctor>b__2_4(object state) { }

			[Address(RVA = "0xA49F10", Offset = "0xA49310", Length = "0x183")]
			[Token(Token = "0x60004F4")]
			internal void <.ctor>b__2_5(object state) { }

			[Address(RVA = "0xA4B1D0", Offset = "0xA4A5D0", Length = "0x183")]
			[Token(Token = "0x60004F5")]
			internal void <.ctor>b__2_6(object state) { }

			[Address(RVA = "0xA4BE50", Offset = "0xA4B250", Length = "0x183")]
			[Token(Token = "0x60004F6")]
			internal void <.ctor>b__2_7(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C8")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002C9")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "result1", "result2", "result3", "result4", "result5", "result6", "result7", "result8", null, null})]
		private UniTaskCompletionSourceCore<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`2<T7, T8>>> core; //Field offset: 0x0

		[Address(RVA = "0x152D710", Offset = "0x152CB10", Length = "0x1879")]
		[Token(Token = "0x60004DF")]
		public WhenAnyPromise`8(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8) { }

		[Address(RVA = "0x1526D10", Offset = "0x1526110", Length = "0xB8")]
		[Token(Token = "0x60004EC")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x1526DD0", Offset = "0x15261D0", Length = "0x12D")]
		[Token(Token = "0x60004E8")]
		public override ValueTuple<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`2<T7, T8>> GetResult(short token) { }

		[Address(RVA = "0x1526F00", Offset = "0x1526300", Length = "0x6A")]
		[Token(Token = "0x60004E9")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1526F70", Offset = "0x1526370", Length = "0x95")]
		[Token(Token = "0x60004EA")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x1527010", Offset = "0x1526410", Length = "0xCCF")]
		[Token(Token = "0x60004E0")]
		private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x1527CE0", Offset = "0x15270E0", Length = "0xCD2")]
		[Token(Token = "0x60004E1")]
		private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x15289C0", Offset = "0x1527DC0", Length = "0xCD2")]
		[Token(Token = "0x60004E2")]
		private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x15296A0", Offset = "0x1528AA0", Length = "0xCD2")]
		[Token(Token = "0x60004E3")]
		private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x152A380", Offset = "0x1529780", Length = "0xCD2")]
		[Token(Token = "0x60004E4")]
		private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x152B060", Offset = "0x152A460", Length = "0xCC0")]
		[Token(Token = "0x60004E5")]
		private static void TryInvokeContinuationT6(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x152BD20", Offset = "0x152B120", Length = "0xCBC")]
		[Token(Token = "0x60004E6")]
		private static void TryInvokeContinuationT7(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x152C9E0", Offset = "0x152BDE0", Length = "0xCC1")]
		[Token(Token = "0x60004E7")]
		private static void TryInvokeContinuationT8(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x152D6B0", Offset = "0x152CAB0", Length = "0x5A")]
		[Token(Token = "0x60004EB")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x20000CE")]
	private sealed class WhenAnyPromise : IUniTaskSource<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`3<T7, T8, T9>>>, IUniTaskSource
	{
		[CompilerGenerated]
		[Token(Token = "0x20000CF")]
		private sealed class <>c
		{
			[Token(Token = "0x40002D5")]
			public static readonly <>c<T1, T2, T3, T4, T5, T6, T7, T8, T9> <>9; //Field offset: 0x0
			[Token(Token = "0x40002D6")]
			public static Action<Object> <>9__2_0; //Field offset: 0x0
			[Token(Token = "0x40002D7")]
			public static Action<Object> <>9__2_1; //Field offset: 0x0
			[Token(Token = "0x40002D8")]
			public static Action<Object> <>9__2_2; //Field offset: 0x0
			[Token(Token = "0x40002D9")]
			public static Action<Object> <>9__2_3; //Field offset: 0x0
			[Token(Token = "0x40002DA")]
			public static Action<Object> <>9__2_4; //Field offset: 0x0
			[Token(Token = "0x40002DB")]
			public static Action<Object> <>9__2_5; //Field offset: 0x0
			[Token(Token = "0x40002DC")]
			public static Action<Object> <>9__2_6; //Field offset: 0x0
			[Token(Token = "0x40002DD")]
			public static Action<Object> <>9__2_7; //Field offset: 0x0
			[Token(Token = "0x40002DE")]
			public static Action<Object> <>9__2_8; //Field offset: 0x0

			[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
			[Token(Token = "0x6000506")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000507")]
			public <>c() { }

			[Address(RVA = "0xA42380", Offset = "0xA41780", Length = "0x174")]
			[Token(Token = "0x6000508")]
			internal void <.ctor>b__2_0(object state) { }

			[Address(RVA = "0xA449F0", Offset = "0xA43DF0", Length = "0x174")]
			[Token(Token = "0x6000509")]
			internal void <.ctor>b__2_1(object state) { }

			[Address(RVA = "0xA465D0", Offset = "0xA459D0", Length = "0x174")]
			[Token(Token = "0x600050A")]
			internal void <.ctor>b__2_2(object state) { }

			[Address(RVA = "0xA47FD0", Offset = "0xA473D0", Length = "0x183")]
			[Token(Token = "0x600050B")]
			internal void <.ctor>b__2_3(object state) { }

			[Address(RVA = "0xA48C50", Offset = "0xA48050", Length = "0x183")]
			[Token(Token = "0x600050C")]
			internal void <.ctor>b__2_4(object state) { }

			[Address(RVA = "0xA498D0", Offset = "0xA48CD0", Length = "0x183")]
			[Token(Token = "0x600050D")]
			internal void <.ctor>b__2_5(object state) { }

			[Address(RVA = "0xA4A6E0", Offset = "0xA49AE0", Length = "0x183")]
			[Token(Token = "0x600050E")]
			internal void <.ctor>b__2_6(object state) { }

			[Address(RVA = "0xA4BCC0", Offset = "0xA4B0C0", Length = "0x183")]
			[Token(Token = "0x600050F")]
			internal void <.ctor>b__2_7(object state) { }

			[Address(RVA = "0xA4CAD0", Offset = "0xA4BED0", Length = "0x183")]
			[Token(Token = "0x6000510")]
			internal void <.ctor>b__2_8(object state) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D3")]
		private int completedCount; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D4")]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {null, "result1", "result2", "result3", "result4", "result5", "result6", "result7", "result8", "result9", null, null, null})]
		private UniTaskCompletionSourceCore<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`3<T7, T8, T9>>> core; //Field offset: 0x0

		[Address(RVA = "0x1537120", Offset = "0x1536520", Length = "0x1B4B")]
		[Token(Token = "0x60004F7")]
		public WhenAnyPromise`9(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9) { }

		[Address(RVA = "0x152EF90", Offset = "0x152E390", Length = "0xB8")]
		[Token(Token = "0x6000505")]
		private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

		[Address(RVA = "0x152F050", Offset = "0x152E450", Length = "0x12D")]
		[Token(Token = "0x6000501")]
		public override ValueTuple<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`3<T7, T8, T9>> GetResult(short token) { }

		[Address(RVA = "0x152F180", Offset = "0x152E580", Length = "0x6A")]
		[Token(Token = "0x6000502")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x152F1F0", Offset = "0x152E5F0", Length = "0x95")]
		[Token(Token = "0x6000503")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x152F290", Offset = "0x152E690", Length = "0xDFE")]
		[Token(Token = "0x60004F8")]
		private static void TryInvokeContinuationT1(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T1> awaiter) { }

		[Address(RVA = "0x1530090", Offset = "0x152F490", Length = "0xDFD")]
		[Token(Token = "0x60004F9")]
		private static void TryInvokeContinuationT2(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T2> awaiter) { }

		[Address(RVA = "0x1530E90", Offset = "0x1530290", Length = "0xE0B")]
		[Token(Token = "0x60004FA")]
		private static void TryInvokeContinuationT3(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T3> awaiter) { }

		[Address(RVA = "0x1531CA0", Offset = "0x15310A0", Length = "0xE08")]
		[Token(Token = "0x60004FB")]
		private static void TryInvokeContinuationT4(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T4> awaiter) { }

		[Address(RVA = "0x1532AB0", Offset = "0x1531EB0", Length = "0xE03")]
		[Token(Token = "0x60004FC")]
		private static void TryInvokeContinuationT5(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T5> awaiter) { }

		[Address(RVA = "0x15338C0", Offset = "0x1532CC0", Length = "0xDF5")]
		[Token(Token = "0x60004FD")]
		private static void TryInvokeContinuationT6(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T6> awaiter) { }

		[Address(RVA = "0x15346C0", Offset = "0x1533AC0", Length = "0xDF5")]
		[Token(Token = "0x60004FE")]
		private static void TryInvokeContinuationT7(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T7> awaiter) { }

		[Address(RVA = "0x15354C0", Offset = "0x15348C0", Length = "0xDFA")]
		[Token(Token = "0x60004FF")]
		private static void TryInvokeContinuationT8(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T8> awaiter) { }

		[Address(RVA = "0x15362C0", Offset = "0x15356C0", Length = "0xDF9")]
		[Token(Token = "0x6000500")]
		private static void TryInvokeContinuationT9(WhenAnyPromise<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, in Awaiter<T9> awaiter) { }

		[Address(RVA = "0x15370C0", Offset = "0x15364C0", Length = "0x5A")]
		[Token(Token = "0x6000504")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x200007A")]
	private sealed class YieldPromise : IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<YieldPromise>
	{
		[CompilerGenerated]
		[Token(Token = "0x200007B")]
		private sealed class <>c
		{
			[Token(Token = "0x400010B")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x273F430", Offset = "0x273E830", Length = "0x67")]
			[Token(Token = "0x6000226")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000227")]
			public <>c() { }

			[Address(RVA = "0x273EDA0", Offset = "0x273E1A0", Length = "0x5A")]
			[Token(Token = "0x6000228")]
			internal int <.cctor>b__4_0() { }

		}

		[Token(Token = "0x4000107")]
		private static TaskPool<YieldPromise> pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000108")]
		private YieldPromise nextNode; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000109")]
		private CancellationToken cancellationToken; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400010A")]
		private UniTaskCompletionSourceCore<Object> core; //Field offset: 0x20

		[Token(Token = "0x17000032")]
		public override YieldPromise NextNode
		{
			[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
			[Token(Token = "0x600021C")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x274EE70", Offset = "0x274E270", Length = "0x100")]
		[Token(Token = "0x600021D")]
		private static YieldPromise() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600021E")]
		private YieldPromise() { }

		[Address(RVA = "0x274E9F0", Offset = "0x274DDF0", Length = "0x1A2")]
		[Token(Token = "0x600021F")]
		public static IUniTaskSource Create(PlayerLoopTiming timing, CancellationToken cancellationToken, out short token) { }

		[Address(RVA = "0xE28B40", Offset = "0xE27F40", Length = "0x5")]
		[Token(Token = "0x600021C")]
		public override YieldPromise get_NextNode() { }

		[Address(RVA = "0x274EBA0", Offset = "0x274DFA0", Length = "0x80")]
		[Token(Token = "0x6000220")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x274EC30", Offset = "0x274E030", Length = "0x49")]
		[Token(Token = "0x6000221")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x274EC80", Offset = "0x274E080", Length = "0xA1")]
		[Token(Token = "0x6000224")]
		public override bool MoveNext() { }

		[Address(RVA = "0x274ED30", Offset = "0x274E130", Length = "0x70")]
		[Token(Token = "0x6000223")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x274EDA0", Offset = "0x274E1A0", Length = "0x89")]
		[Token(Token = "0x6000225")]
		private bool TryReturn() { }

		[Address(RVA = "0x274EE30", Offset = "0x274E230", Length = "0x3A")]
		[Token(Token = "0x6000222")]
		public override UniTaskStatus UnsafeGetStatus() { }

	}

	[Token(Token = "0x40000FF")]
	private static readonly UniTask CanceledUniTask; //Field offset: 0x0
	[Token(Token = "0x4000100")]
	public static readonly UniTask CompletedTask; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000FD")]
	private readonly IUniTaskSource source; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000FE")]
	private readonly short token; //Field offset: 0x8

	[Token(Token = "0x17000030")]
	public UniTaskStatus Status
	{
		[Address(RVA = "0x274C2F0", Offset = "0x274B6F0", Length = "0x51")]
		[DebuggerHidden]
		[Token(Token = "0x6000195")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x274C1C0", Offset = "0x274B5C0", Length = "0xFE")]
	[Token(Token = "0x6000204")]
	private static UniTask() { }

	[Address(RVA = "0x274C2C0", Offset = "0x274B6C0", Length = "0x28")]
	[DebuggerHidden]
	[Token(Token = "0x6000194")]
	public UniTask(IUniTaskSource source, short token) { }

	[Address(RVA = "0x27490C0", Offset = "0x27484C0", Length = "0xC2")]
	[Token(Token = "0x60001BA")]
	public static Action Action(Func<CancellationToken, UniTaskVoid> asyncAction, CancellationToken cancellationToken) { }

	[Address(RVA = "0x2749010", Offset = "0x2748410", Length = "0xA6")]
	[Token(Token = "0x60001B9")]
	public static Action Action(Func<UniTaskVoid> asyncAction) { }

	[Address(RVA = "0x2749190", Offset = "0x2748590", Length = "0x1A3")]
	[Token(Token = "0x600019A")]
	public UniTask<AsyncUnit> AsAsyncUnitUniTask() { }

	[Address(RVA = "0x9AE0A0", Offset = "0x9AD4A0", Length = "0xB4")]
	[Token(Token = "0x60001B3")]
	public static UniTask<T> Create(Func<UniTask`1<T>> factory) { }

	[Address(RVA = "0x2749340", Offset = "0x2748740", Length = "0x35")]
	[Token(Token = "0x60001B2")]
	public static UniTask Create(Func<UniTask> factory) { }

	[Address(RVA = "0x9AE160", Offset = "0x9AD560", Length = "0xEC")]
	[Token(Token = "0x60001BE")]
	public static UniTask<T> Defer(Func<UniTask`1<T>> factory) { }

	[Address(RVA = "0x2749380", Offset = "0x2748780", Length = "0x85")]
	[Token(Token = "0x60001BD")]
	public static UniTask Defer(Func<UniTask> factory) { }

	[Address(RVA = "0x2749530", Offset = "0x2748930", Length = "0x253")]
	[Token(Token = "0x60001AC")]
	public static UniTask Delay(TimeSpan delayTimeSpan, DelayType delayType, PlayerLoopTiming delayTiming = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2749890", Offset = "0x2748C90", Length = "0x96")]
	[Token(Token = "0x60001AA")]
	public static UniTask Delay(TimeSpan delayTimeSpan, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2749790", Offset = "0x2748B90", Length = "0xF9")]
	[Token(Token = "0x60001A9")]
	public static UniTask Delay(int millisecondsDelay, bool ignoreTimeScale = false, PlayerLoopTiming delayTiming = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2749930", Offset = "0x2748D30", Length = "0xC7")]
	[Token(Token = "0x60001AB")]
	public static UniTask Delay(int millisecondsDelay, DelayType delayType, PlayerLoopTiming delayTiming = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2749410", Offset = "0x2748810", Length = "0x112")]
	[Token(Token = "0x60001A8")]
	public static UniTask DelayFrame(int delayFrameCount, PlayerLoopTiming delayTiming = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x9AE900", Offset = "0x9ADD00", Length = "0x162")]
	[Token(Token = "0x60001B1")]
	public static UniTask<T> FromCanceled(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2749A00", Offset = "0x2748E00", Length = "0x104")]
	[Token(Token = "0x60001B0")]
	public static UniTask FromCanceled(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x2749B10", Offset = "0x2748F10", Length = "0x11C")]
	[Token(Token = "0x60001AD")]
	public static UniTask FromException(Exception ex) { }

	[Address(RVA = "0x9AF510", Offset = "0x9AE910", Length = "0x273")]
	[Token(Token = "0x60001AE")]
	public static UniTask<T> FromException(Exception ex) { }

	[Address(RVA = "0x9AFB00", Offset = "0x9AEF00", Length = "0x6B")]
	[Token(Token = "0x60001AF")]
	public static UniTask<T> FromResult(T value) { }

	[Address(RVA = "0x274C2F0", Offset = "0x274B6F0", Length = "0x51")]
	[DebuggerHidden]
	[Token(Token = "0x6000195")]
	public UniTaskStatus get_Status() { }

	[Address(RVA = "0x2749C30", Offset = "0x2749030", Length = "0x25")]
	[DebuggerHidden]
	[Token(Token = "0x6000196")]
	public Awaiter GetAwaiter() { }

	[Address(RVA = "0x9AFE00", Offset = "0x9AF200", Length = "0x6F")]
	[Token(Token = "0x60001B5")]
	public static AsyncLazy<T> Lazy(Func<UniTask`1<T>> factory) { }

	[Address(RVA = "0x2749C60", Offset = "0x2749060", Length = "0xDE")]
	[Token(Token = "0x60001B4")]
	public static AsyncLazy Lazy(Func<UniTask> factory) { }

	[Address(RVA = "0x9AFE70", Offset = "0x9AF270", Length = "0xEB")]
	[Token(Token = "0x60001C0")]
	public static UniTask<T> Never(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2749D40", Offset = "0x2749140", Length = "0xD6")]
	[Token(Token = "0x60001BF")]
	public static UniTask Never(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2749F50", Offset = "0x2749350", Length = "0xBF")]
	[Token(Token = "0x60001A0")]
	public static UniTask NextFrame(PlayerLoopTiming timing) { }

	[Address(RVA = "0x2749EC0", Offset = "0x27492C0", Length = "0x8F")]
	[Token(Token = "0x60001A1")]
	public static UniTask NextFrame(CancellationToken cancellationToken) { }

	[Address(RVA = "0x2749E20", Offset = "0x2749220", Length = "0x98")]
	[Token(Token = "0x60001A2")]
	public static UniTask NextFrame(PlayerLoopTiming timing, CancellationToken cancellationToken) { }

	[Address(RVA = "0x274A010", Offset = "0x2749410", Length = "0xB6")]
	[Token(Token = "0x600019F")]
	public static UniTask NextFrame() { }

	[Address(RVA = "0x274A0D0", Offset = "0x27494D0", Length = "0x57")]
	[Token(Token = "0x60001D5")]
	public static void Post(Action action, PlayerLoopTiming timing = 8) { }

	[Address(RVA = "0x274A130", Offset = "0x2749530", Length = "0xB7")]
	[Token(Token = "0x6000199")]
	public UniTask Preserve() { }

	[Address(RVA = "0x274A1F0", Offset = "0x27495F0", Length = "0x5D")]
	[Token(Token = "0x60001DA")]
	public static ReturnToSynchronizationContext ReturnToCurrentSynchronizationContext(bool dontPostWhenSameContext = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274A250", Offset = "0x2749650", Length = "0x28")]
	[Token(Token = "0x60001D3")]
	public static ReturnToMainThread ReturnToMainThread(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274A280", Offset = "0x2749680", Length = "0x2A")]
	[Token(Token = "0x60001D4")]
	public static ReturnToMainThread ReturnToMainThread(PlayerLoopTiming timing, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274A2B0", Offset = "0x27496B0", Length = "0x43")]
	[Token(Token = "0x60001D9")]
	public static ReturnToSynchronizationContext ReturnToSynchronizationContext(SynchronizationContext synchronizationContext, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274AB40", Offset = "0x2749F40", Length = "0x14C")]
	[Obsolete("UniTask.Run is similar as Task.Run, it uses ThreadPool. For equivalent behaviour, use UniTask.RunOnThreadPool instead. If you don't want to use ThreadPool, you can use UniTask.Void(async void) or UniTask.Create(async UniTask) too.")]
	[Token(Token = "0x60001C2")]
	public static UniTask Run(Action<Object> action, object state, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274AA00", Offset = "0x2749E00", Length = "0x131")]
	[Obsolete("UniTask.Run is similar as Task.Run, it uses ThreadPool. For equivalent behaviour, use UniTask.RunOnThreadPool instead. If you don't want to use ThreadPool, you can use UniTask.Void(async void) or UniTask.Create(async UniTask) too.")]
	[Token(Token = "0x60001C1")]
	public static UniTask Run(Action action, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x9B0610", Offset = "0x9AFA10", Length = "0x106")]
	[Obsolete("UniTask.Run is similar as Task.Run, it uses ThreadPool. For equivalent behaviour, use UniTask.RunOnThreadPool instead. If you don't want to use ThreadPool, you can use UniTask.Void(async void) or UniTask.Create(async UniTask) too.")]
	[Token(Token = "0x60001C5")]
	public static UniTask<T> Run(Func<T> func, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x9B0610", Offset = "0x9AFA10", Length = "0x106")]
	[Obsolete("UniTask.Run is similar as Task.Run, it uses ThreadPool. For equivalent behaviour, use UniTask.RunOnThreadPool instead. If you don't want to use ThreadPool, you can use UniTask.Void(async void) or UniTask.Create(async UniTask) too.")]
	[Token(Token = "0x60001C6")]
	public static UniTask<T> Run(Func<UniTask`1<T>> func, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274A760", Offset = "0x2749B60", Length = "0x132")]
	[Obsolete("UniTask.Run is similar as Task.Run, it uses ThreadPool. For equivalent behaviour, use UniTask.RunOnThreadPool instead. If you don't want to use ThreadPool, you can use UniTask.Void(async void) or UniTask.Create(async UniTask) too.")]
	[Token(Token = "0x60001C3")]
	public static UniTask Run(Func<UniTask> action, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x9B04F0", Offset = "0x9AF8F0", Length = "0x117")]
	[Obsolete("UniTask.Run is similar as Task.Run, it uses ThreadPool. For equivalent behaviour, use UniTask.RunOnThreadPool instead. If you don't want to use ThreadPool, you can use UniTask.Void(async void) or UniTask.Create(async UniTask) too.")]
	[Token(Token = "0x60001C8")]
	public static UniTask<T> Run(Func<Object, UniTask`1<T>> func, object state, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x9B04F0", Offset = "0x9AF8F0", Length = "0x117")]
	[Obsolete("UniTask.Run is similar as Task.Run, it uses ThreadPool. For equivalent behaviour, use UniTask.RunOnThreadPool instead. If you don't want to use ThreadPool, you can use UniTask.Void(async void) or UniTask.Create(async UniTask) too.")]
	[Token(Token = "0x60001C7")]
	public static UniTask<T> Run(Func<Object, T> func, object state, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274A8A0", Offset = "0x2749CA0", Length = "0x156")]
	[Obsolete("UniTask.Run is similar as Task.Run, it uses ThreadPool. For equivalent behaviour, use UniTask.RunOnThreadPool instead. If you don't want to use ThreadPool, you can use UniTask.Void(async void) or UniTask.Create(async UniTask) too.")]
	[Token(Token = "0x60001C4")]
	public static UniTask Run(Func<Object, UniTask> action, object state, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274A660", Offset = "0x2749A60", Length = "0x100")]
	[AsyncStateMachine(typeof(<RunOnThreadPool>d__78))]
	[Token(Token = "0x60001C9")]
	public static UniTask RunOnThreadPool(Action action, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274A300", Offset = "0x2749700", Length = "0x125")]
	[AsyncStateMachine(typeof(<RunOnThreadPool>d__81))]
	[Token(Token = "0x60001CC")]
	public static UniTask RunOnThreadPool(Func<Object, UniTask> action, object state, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x9B0250", Offset = "0x9AF650", Length = "0x298")]
	[AsyncStateMachine(typeof(<RunOnThreadPool>d__82`1))]
	[Token(Token = "0x60001CD")]
	public static UniTask<T> RunOnThreadPool(Func<T> func, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x9B0250", Offset = "0x9AF650", Length = "0x298")]
	[AsyncStateMachine(typeof(<RunOnThreadPool>d__83`1))]
	[Token(Token = "0x60001CE")]
	public static UniTask<T> RunOnThreadPool(Func<UniTask`1<T>> func, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x9AFF60", Offset = "0x9AF360", Length = "0x2E1")]
	[AsyncStateMachine(typeof(<RunOnThreadPool>d__84`1))]
	[Token(Token = "0x60001CF")]
	public static UniTask<T> RunOnThreadPool(Func<Object, T> func, object state, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274A430", Offset = "0x2749830", Length = "0x11B")]
	[AsyncStateMachine(typeof(<RunOnThreadPool>d__79))]
	[Token(Token = "0x60001CA")]
	public static UniTask RunOnThreadPool(Action<Object> action, object state, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x9AFF60", Offset = "0x9AF360", Length = "0x2E1")]
	[AsyncStateMachine(typeof(<RunOnThreadPool>d__85`1))]
	[Token(Token = "0x60001D0")]
	public static UniTask<T> RunOnThreadPool(Func<Object, UniTask`1<T>> func, object state, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274A550", Offset = "0x2749950", Length = "0x101")]
	[AsyncStateMachine(typeof(<RunOnThreadPool>d__80))]
	[Token(Token = "0x60001CB")]
	public static UniTask RunOnThreadPool(Func<UniTask> action, bool configureAwait = true, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274AC90", Offset = "0x274A090", Length = "0x19B")]
	[Token(Token = "0x6000197")]
	public UniTask<Boolean> SuppressCancellationThrow() { }

	[Address(RVA = "0x274A280", Offset = "0x2749680", Length = "0x2A")]
	[Token(Token = "0x60001D2")]
	public static SwitchToMainThreadAwaitable SwitchToMainThread(PlayerLoopTiming timing, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274A250", Offset = "0x2749650", Length = "0x28")]
	[Token(Token = "0x60001D1")]
	public static SwitchToMainThreadAwaitable SwitchToMainThread(CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274AE30", Offset = "0x274A230", Length = "0x8B")]
	[Token(Token = "0x60001D8")]
	public static SwitchToSynchronizationContextAwaitable SwitchToSynchronizationContext(SynchronizationContext synchronizationContext, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60001D7")]
	public static SwitchToTaskPoolAwaitable SwitchToTaskPool() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60001D6")]
	public static SwitchToThreadPoolAwaitable SwitchToThreadPool() { }

	[Address(RVA = "0x274AEC0", Offset = "0x274A2C0", Length = "0x9F")]
	[Token(Token = "0x6000193")]
	public static IEnumerator ToCoroutine(Func<UniTask> taskFactory) { }

	[Address(RVA = "0x274AF60", Offset = "0x274A360", Length = "0xCA")]
	[Token(Token = "0x6000198")]
	public virtual string ToString() { }

	[Address(RVA = "0x274B030", Offset = "0x274A430", Length = "0xC2")]
	[Token(Token = "0x60001BC")]
	public static UnityAction UnityAction(Func<CancellationToken, UniTaskVoid> asyncAction, CancellationToken cancellationToken) { }

	[Address(RVA = "0x274B100", Offset = "0x274A500", Length = "0xA6")]
	[Token(Token = "0x60001BB")]
	public static UnityAction UnityAction(Func<UniTaskVoid> asyncAction) { }

	[Address(RVA = "0x274B1B0", Offset = "0x274A5B0", Length = "0x36")]
	[Token(Token = "0x60001B7")]
	public static void Void(Func<CancellationToken, UniTaskVoid> asyncAction, CancellationToken cancellationToken) { }

	[Address(RVA = "0x274B1F0", Offset = "0x274A5F0", Length = "0x36")]
	[Token(Token = "0x60001B6")]
	public static void Void(Func<UniTaskVoid> asyncAction) { }

	[Address(RVA = "0x9B0720", Offset = "0x9AFB20", Length = "0xDF")]
	[Token(Token = "0x60001B8")]
	public static void Void(Func<T, UniTaskVoid> asyncAction, T state) { }

	[Address(RVA = "0x274B4D0", Offset = "0x274A8D0", Length = "0x3F")]
	[Obsolete("Use WaitForEndOfFrame(MonoBehaviour) instead or UniTask.Yield(PlayerLoopTiming.LastPostLateUpdate). Equivalent for coroutine's WaitForEndOfFrame requires MonoBehaviour(runner of Coroutine).")]
	[Token(Token = "0x60001A3")]
	public static YieldAwaitable WaitForEndOfFrame() { }

	[Address(RVA = "0x274B230", Offset = "0x274A630", Length = "0xCE")]
	[Obsolete("Use WaitForEndOfFrame(MonoBehaviour) instead or UniTask.Yield(PlayerLoopTiming.LastPostLateUpdate). Equivalent for coroutine's WaitForEndOfFrame requires MonoBehaviour(runner of Coroutine).")]
	[Token(Token = "0x60001A4")]
	public static UniTask WaitForEndOfFrame(CancellationToken cancellationToken) { }

	[Address(RVA = "0x274B300", Offset = "0x274A700", Length = "0x1C5")]
	[Token(Token = "0x60001A5")]
	public static UniTask WaitForEndOfFrame(MonoBehaviour coroutineRunner, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274B510", Offset = "0x274A910", Length = "0x3F")]
	[Token(Token = "0x60001A6")]
	public static YieldAwaitable WaitForFixedUpdate() { }

	[Address(RVA = "0x274B550", Offset = "0x274A950", Length = "0xCE")]
	[Token(Token = "0x60001A7")]
	public static UniTask WaitForFixedUpdate(CancellationToken cancellationToken) { }

	[Address(RVA = "0x274B800", Offset = "0x274AC00", Length = "0x203")]
	[Token(Token = "0x60001DB")]
	public static UniTask WaitUntil(Func<Boolean> predicate, PlayerLoopTiming timing = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274B620", Offset = "0x274AA20", Length = "0x1DE")]
	[Token(Token = "0x60001DD")]
	public static UniTask WaitUntilCanceled(CancellationToken cancellationToken, PlayerLoopTiming timing = 8) { }

	[Address(RVA = "0x9B0800", Offset = "0x9AFC00", Length = "0x224")]
	[Token(Token = "0x60001DE")]
	public static UniTask<U> WaitUntilValueChanged(T target, Func<T, U> monitorFunction, PlayerLoopTiming monitorTiming = 8, IEqualityComparer<U> equalityComparer = null, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x274BA10", Offset = "0x274AE10", Length = "0x203")]
	[Token(Token = "0x60001DC")]
	public static UniTask WaitWhile(Func<Boolean> predicate, PlayerLoopTiming timing = 8, CancellationToken cancellationToken = null) { }

	[Address(RVA = "0x9BEC80", Offset = "0x9BE080", Length = "0x10D1")]
	[Token(Token = "0x60001E8")]
	public static UniTask<ValueTuple`7<T1, T2, T3, T4, T5, T6, T7>> WhenAll(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7) { }

	[Address(RVA = "0x9BD890", Offset = "0x9BCC90", Length = "0x13E4")]
	[Token(Token = "0x60001E9")]
	public static UniTask<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`1<T8>>> WhenAll(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8) { }

	[Address(RVA = "0x9BA9D0", Offset = "0x9B9DD0", Length = "0x187D")]
	[Token(Token = "0x60001EB")]
	public static UniTask<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`3<T8, T9, T10>>> WhenAll(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10) { }

	[Address(RVA = "0x9B0A30", Offset = "0x9AFE30", Length = "0x2578")]
	[Token(Token = "0x60001F0")]
	public static UniTask<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`8<T8, T9, T10, T11, T12, T13, T14, ValueTuple`1<T15>>>> WhenAll(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14, UniTask<T15> task15) { }

	[Address(RVA = "0x9BFD60", Offset = "0x9BF160", Length = "0xE5F")]
	[Token(Token = "0x60001E7")]
	public static UniTask<ValueTuple`6<T1, T2, T3, T4, T5, T6>> WhenAll(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6) { }

	[Address(RVA = "0x9B7190", Offset = "0x9B6590", Length = "0x1D41")]
	[Token(Token = "0x60001ED")]
	public static UniTask<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`5<T8, T9, T10, T11, T12>>> WhenAll(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12) { }

	[Address(RVA = "0x9B51D0", Offset = "0x9B45D0", Length = "0x1FB6")]
	[Token(Token = "0x60001EE")]
	public static UniTask<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`6<T8, T9, T10, T11, T12, T13>>> WhenAll(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13) { }

	[Address(RVA = "0x9B2FB0", Offset = "0x9B23B0", Length = "0x221A")]
	[Token(Token = "0x60001EF")]
	public static UniTask<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`7<T8, T9, T10, T11, T12, T13, T14>>> WhenAll(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14) { }

	[Address(RVA = "0x9B8EE0", Offset = "0x9B82E0", Length = "0x1AE4")]
	[Token(Token = "0x60001EC")]
	public static UniTask<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`4<T8, T9, T10, T11>>> WhenAll(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11) { }

	[Address(RVA = "0x9BC250", Offset = "0x9BB650", Length = "0x163B")]
	[Token(Token = "0x60001EA")]
	public static UniTask<ValueTuple`8<T1, T2, T3, T4, T5, T6, T7, ValueTuple`2<T8, T9>>> WhenAll(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9) { }

	[Address(RVA = "0x9C1770", Offset = "0x9C0B70", Length = "0x974")]
	[Token(Token = "0x60001E5")]
	public static UniTask<ValueTuple`4<T1, T2, T3, T4>> WhenAll(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4) { }

	[Address(RVA = "0x9C20F0", Offset = "0x9C14F0", Length = "0x73A")]
	[Token(Token = "0x60001E4")]
	public static UniTask<ValueTuple`3<T1, T2, T3>> WhenAll(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3) { }

	[Address(RVA = "0x9C2830", Offset = "0x9C1C30", Length = "0x521")]
	[Token(Token = "0x60001E3")]
	public static UniTask<ValueTuple`2<T1, T2>> WhenAll(UniTask<T1> task1, UniTask<T2> task2) { }

	[Address(RVA = "0x274BC20", Offset = "0x274B020", Length = "0x166")]
	[Token(Token = "0x60001E2")]
	public static UniTask WhenAll(IEnumerable<UniTask> tasks) { }

	[Address(RVA = "0x274BD90", Offset = "0x274B190", Length = "0xD9")]
	[Token(Token = "0x60001E1")]
	public static UniTask WhenAll(UniTask[] tasks) { }

	[Address(RVA = "0x9C2EA0", Offset = "0x9C22A0", Length = "0x196")]
	[Token(Token = "0x60001E0")]
	public static UniTask<T[]> WhenAll(IEnumerable<UniTask`1<T>> tasks) { }

	[Address(RVA = "0x9C3040", Offset = "0x9C2440", Length = "0x19D")]
	[Token(Token = "0x60001DF")]
	public static UniTask<T[]> WhenAll(UniTask<T>[] tasks) { }

	[Address(RVA = "0x9C0BC0", Offset = "0x9BFFC0", Length = "0xBA6")]
	[Token(Token = "0x60001E6")]
	public static UniTask<ValueTuple`5<T1, T2, T3, T4, T5>> WhenAll(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5) { }

	[Address(RVA = "0x9C5880", Offset = "0x9C4C80", Length = "0x32D")]
	[Token(Token = "0x60001FB")]
	public static UniTask<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`1<T7>>> WhenAny(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7) { }

	[Address(RVA = "0x9C5500", Offset = "0x9C4900", Length = "0x37A")]
	[Token(Token = "0x60001FC")]
	public static UniTask<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`2<T7, T8>>> WhenAny(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8) { }

	[Address(RVA = "0x9C5120", Offset = "0x9C4520", Length = "0x3D2")]
	[Token(Token = "0x60001FD")]
	public static UniTask<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`3<T7, T8, T9>>> WhenAny(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9) { }

	[Address(RVA = "0x9C4390", Offset = "0x9C3790", Length = "0x4D2")]
	[Token(Token = "0x6000200")]
	public static UniTask<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`6<T7, T8, T9, T10, T11, T12>>> WhenAny(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12) { }

	[Address(RVA = "0x9C4870", Offset = "0x9C3C70", Length = "0x478")]
	[Token(Token = "0x60001FF")]
	public static UniTask<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`5<T7, T8, T9, T10, T11>>> WhenAny(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11) { }

	[Address(RVA = "0x9C5BB0", Offset = "0x9C4FB0", Length = "0x2D5")]
	[Token(Token = "0x60001FA")]
	public static UniTask<ValueTuple`7<Int32, T1, T2, T3, T4, T5, T6>> WhenAny(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6) { }

	[Address(RVA = "0x9C3E50", Offset = "0x9C3250", Length = "0x532")]
	[Token(Token = "0x6000201")]
	public static UniTask<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`7<T7, T8, T9, T10, T11, T12, T13>>> WhenAny(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13) { }

	[Address(RVA = "0x9C38B0", Offset = "0x9C2CB0", Length = "0x593")]
	[Token(Token = "0x6000202")]
	public static UniTask<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`8<T7, T8, T9, T10, T11, T12, T13, ValueTuple`1<T14>>>> WhenAny(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14) { }

	[Address(RVA = "0x9C4CF0", Offset = "0x9C40F0", Length = "0x42B")]
	[Token(Token = "0x60001FE")]
	public static UniTask<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`4<T7, T8, T9, T10>>> WhenAny(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10) { }

	[Address(RVA = "0x9C5E90", Offset = "0x9C5290", Length = "0x27F")]
	[Token(Token = "0x60001F9")]
	public static UniTask<ValueTuple`6<Int32, T1, T2, T3, T4, T5>> WhenAny(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5) { }

	[Address(RVA = "0x274BF10", Offset = "0x274B310", Length = "0x178")]
	[Token(Token = "0x60001F5")]
	public static UniTask<Int32> WhenAny(IEnumerable<UniTask> tasks) { }

	[Address(RVA = "0x9C6330", Offset = "0x9C5730", Length = "0x1D0")]
	[Token(Token = "0x60001F7")]
	public static UniTask<ValueTuple`4<Int32, T1, T2, T3>> WhenAny(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3) { }

	[Address(RVA = "0x9C31E0", Offset = "0x9C25E0", Length = "0xC5")]
	[Token(Token = "0x60001F6")]
	public static UniTask<ValueTuple`3<Int32, T1, T2>> WhenAny(UniTask<T1> task1, UniTask<T2> task2) { }

	[Address(RVA = "0x274BE70", Offset = "0x274B270", Length = "0x98")]
	[Token(Token = "0x60001F4")]
	public static UniTask<Int32> WhenAny(UniTask[] tasks) { }

	[Address(RVA = "0x9C6670", Offset = "0x9C5A70", Length = "0x218")]
	[Token(Token = "0x60001F3")]
	public static UniTask<ValueTuple`2<Int32, T>> WhenAny(IEnumerable<UniTask`1<T>> tasks) { }

	[Address(RVA = "0x9C6890", Offset = "0x9C5C90", Length = "0xFE")]
	[Token(Token = "0x60001F2")]
	public static UniTask<ValueTuple`2<Int32, T>> WhenAny(UniTask<T>[] tasks) { }

	[Address(RVA = "0x9C6990", Offset = "0x9C5D90", Length = "0x1D1")]
	[Token(Token = "0x60001F1")]
	public static UniTask<ValueTuple`2<Boolean, T>> WhenAny(UniTask<T> leftTask, UniTask rightTask) { }

	[Address(RVA = "0x9C32B0", Offset = "0x9C26B0", Length = "0x5F4")]
	[Token(Token = "0x6000203")]
	public static UniTask<ValueTuple`8<Int32, T1, T2, T3, T4, T5, T6, ValueTuple`8<T7, T8, T9, T10, T11, T12, T13, ValueTuple`2<T14, T15>>>> WhenAny(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4, UniTask<T5> task5, UniTask<T6> task6, UniTask<T7> task7, UniTask<T8> task8, UniTask<T9> task9, UniTask<T10> task10, UniTask<T11> task11, UniTask<T12> task12, UniTask<T13> task13, UniTask<T14> task14, UniTask<T15> task15) { }

	[Address(RVA = "0x9C6110", Offset = "0x9C5510", Length = "0x220")]
	[Token(Token = "0x60001F8")]
	public static UniTask<ValueTuple`5<Int32, T1, T2, T3, T4>> WhenAny(UniTask<T1> task1, UniTask<T2> task2, UniTask<T3> task3, UniTask<T4> task4) { }

	[Address(RVA = "0x274C090", Offset = "0x274B490", Length = "0x8F")]
	[Token(Token = "0x600019D")]
	public static UniTask Yield(CancellationToken cancellationToken) { }

	[Address(RVA = "0x604260", Offset = "0x603660", Length = "0x3")]
	[Token(Token = "0x600019C")]
	public static YieldAwaitable Yield(PlayerLoopTiming timing) { }

	[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
	[Token(Token = "0x600019B")]
	public static YieldAwaitable Yield() { }

	[Address(RVA = "0x274C120", Offset = "0x274B520", Length = "0x98")]
	[Token(Token = "0x600019E")]
	public static UniTask Yield(PlayerLoopTiming timing, CancellationToken cancellationToken) { }

}

