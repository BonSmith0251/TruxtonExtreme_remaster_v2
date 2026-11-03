namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001D6")]
internal sealed class TakeUntil : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20001D7")]
	private sealed class _TakeUntil : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x20001D8")]
		private struct <RunOther>d__17 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001235")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001236")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001237")]
			public UniTask other; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001238")]
			public _TakeUntil<TSource> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001239")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x197E9E0", Offset = "0x197DDE0", Length = "0x2FE")]
			[Token(Token = "0x600084B")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x600084C")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x400122B")]
		private static readonly Action<Object> CancelDelegate1; //Field offset: 0x0
		[Token(Token = "0x400122C")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400122D")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400122E")]
		private CancellationToken cancellationToken1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400122F")]
		private CancellationTokenRegistration cancellationTokenRegistration1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001230")]
		private bool completed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001231")]
		private Exception exception; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001232")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001233")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001234")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000045")]
		public private override TSource Current
		{
			[Address(RVA = "0x161E620", Offset = "0x161DA20", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x6000842")]
			 get { } //Length: 176
			[Address(RVA = "0x161E6D0", Offset = "0x161DAD0", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x6000843")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x161E1E0", Offset = "0x161D5E0", Length = "0x1A6")]
		[Token(Token = "0x600084A")]
		private static _TakeUntil() { }

		[Address(RVA = "0x161E390", Offset = "0x161D790", Length = "0x282")]
		[Token(Token = "0x6000841")]
		public _TakeUntil(IUniTaskAsyncEnumerable<TSource> source, UniTask other, CancellationToken cancellationToken1) { }

		[Address(RVA = "0x161D4C0", Offset = "0x161C8C0", Length = "0x14C")]
		[Token(Token = "0x6000849")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x161E620", Offset = "0x161DA20", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x6000842")]
		public override TSource get_Current() { }

		[Address(RVA = "0x161D610", Offset = "0x161CA10", Length = "0x360")]
		[Token(Token = "0x6000844")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x161D980", Offset = "0x161CD80", Length = "0x401")]
		[Token(Token = "0x6000846")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x161DD90", Offset = "0x161D190", Length = "0xDB")]
		[Token(Token = "0x6000848")]
		private static void OnCanceled1(object state) { }

		[Address(RVA = "0x1618EB0", Offset = "0x16182B0", Length = "0xA5")]
		[AsyncStateMachine(typeof(<RunOther>d__17))]
		[Token(Token = "0x6000847")]
		private UniTaskVoid RunOther(UniTask other) { }

		[Address(RVA = "0x161E6D0", Offset = "0x161DAD0", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000843")]
		private void set_Current(TSource value) { }

		[Address(RVA = "0x161DE70", Offset = "0x161D270", Length = "0x362")]
		[Token(Token = "0x6000845")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001228")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001229")]
	private readonly UniTask other; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400122A")]
	private readonly Func<CancellationToken, UniTask> other2; //Field offset: 0x0

	[Address(RVA = "0xF640E0", Offset = "0xF634E0", Length = "0x6D")]
	[Token(Token = "0x600083F")]
	public TakeUntil`1(IUniTaskAsyncEnumerable<TSource> source, UniTask other, Func<CancellationToken, UniTask> other2) { }

	[Address(RVA = "0xF63FD0", Offset = "0xF633D0", Length = "0x108")]
	[Token(Token = "0x6000840")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

