namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000095")]
internal sealed class Create : IUniTaskAsyncEnumerable<T>
{
	[Token(Token = "0x2000096")]
	private sealed class _Create : MoveNextSource, IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000097")]
		private struct <RunWriterTask>d__12 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40007C5")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40007C6")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40007C7")]
			public UniTask task; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40007C8")]
			public _Create<T> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40007C9")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x19822E0", Offset = "0x19816E0", Length = "0x2E9")]
			[Token(Token = "0x6000423")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000424")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007C0")]
		private readonly Func<IAsyncWriter`1<T>, CancellationToken, UniTask> create; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007C1")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007C2")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007C3")]
		private AsyncWriter<T> writer; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007C4")]
		private T <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000017")]
		public private override T Current
		{
			[Address(RVA = "0x15EFE20", Offset = "0x15EF220", Length = "0xAC")]
			[CompilerGenerated]
			[Token(Token = "0x600041C")]
			 get { } //Length: 172
			[Address(RVA = "0x15EFED0", Offset = "0x15EF2D0", Length = "0xB9")]
			[CompilerGenerated]
			[Token(Token = "0x600041D")]
			private set { } //Length: 185
		}

		[Address(RVA = "0x15EFD10", Offset = "0x15EF110", Length = "0x10E")]
		[Token(Token = "0x600041B")]
		public _Create(Func<IAsyncWriter`1<T>, CancellationToken, UniTask> create, CancellationToken cancellationToken) { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[Token(Token = "0x600041E")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15EFE20", Offset = "0x15EF220", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x600041C")]
		public override T get_Current() { }

		[Address(RVA = "0x15EF7B0", Offset = "0x15EEBB0", Length = "0x394")]
		[Token(Token = "0x6000420")]
		private void MoveNext() { }

		[Address(RVA = "0x15EF6C0", Offset = "0x15EEAC0", Length = "0xE3")]
		[Token(Token = "0x600041F")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15EFB50", Offset = "0x15EEF50", Length = "0xA5")]
		[AsyncStateMachine(typeof(<RunWriterTask>d__12))]
		[Token(Token = "0x6000421")]
		private UniTaskVoid RunWriterTask(UniTask task) { }

		[Address(RVA = "0x15EFED0", Offset = "0x15EF2D0", Length = "0xB9")]
		[CompilerGenerated]
		[Token(Token = "0x600041D")]
		private void set_Current(T value) { }

		[Address(RVA = "0x15EFC00", Offset = "0x15EF000", Length = "0x102")]
		[Token(Token = "0x6000422")]
		public void SetResult(T value) { }

	}

	[Token(Token = "0x2000098")]
	private sealed class AsyncWriter : IUniTaskSource, IAsyncWriter<T>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007CA")]
		private readonly _Create<T> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007CB")]
		private UniTaskCompletionSourceCore<AsyncUnit> core; //Field offset: 0x0

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000425")]
		public AsyncWriter(_Create<T> enumerator) { }

		[Address(RVA = "0x1634060", Offset = "0x1633460", Length = "0x49")]
		[Token(Token = "0x6000426")]
		public override void GetResult(short token) { }

		[Address(RVA = "0x16340B0", Offset = "0x16334B0", Length = "0x14E")]
		[Token(Token = "0x6000427")]
		public override UniTaskStatus GetStatus(short token) { }

		[Address(RVA = "0x1634200", Offset = "0x1633600", Length = "0x1D0")]
		[Token(Token = "0x6000429")]
		public override void OnCompleted(Action<Object> continuation, object state, short token) { }

		[Address(RVA = "0x16343E0", Offset = "0x16337E0", Length = "0x6F")]
		[Token(Token = "0x600042B")]
		public void SignalWriter() { }

		[Address(RVA = "0x1634450", Offset = "0x1633850", Length = "0xAD")]
		[Token(Token = "0x6000428")]
		public override UniTaskStatus UnsafeGetStatus() { }

		[Address(RVA = "0x1634500", Offset = "0x1633900", Length = "0x15B")]
		[Token(Token = "0x600042A")]
		public override UniTask YieldAsync(T value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007BF")]
	private readonly Func<IAsyncWriter`1<T>, CancellationToken, UniTask> create; //Field offset: 0x0

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000419")]
	public Create`1(Func<IAsyncWriter`1<T>, CancellationToken, UniTask> create) { }

	[Address(RVA = "0xE12E80", Offset = "0xE12280", Length = "0x7F")]
	[Token(Token = "0x600041A")]
	public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

