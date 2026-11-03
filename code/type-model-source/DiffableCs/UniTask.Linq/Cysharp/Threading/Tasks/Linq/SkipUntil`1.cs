namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200018F")]
internal sealed class SkipUntil : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x2000190")]
	private sealed class _SkipUntil : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x2000191")]
		private struct <RunOther>d__18 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000FC9")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000FCA")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000FCB")]
			public UniTask other; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000FCC")]
			public _SkipUntil<TSource> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000FCD")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x197ECE0", Offset = "0x197E0E0", Length = "0x328")]
			[Token(Token = "0x600076F")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000770")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000FBE")]
		private static readonly Action<Object> CancelDelegate1; //Field offset: 0x0
		[Token(Token = "0x4000FBF")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FC0")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FC1")]
		private CancellationToken cancellationToken1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FC2")]
		private bool completed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FC3")]
		private CancellationTokenRegistration cancellationTokenRegistration1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FC4")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FC5")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FC6")]
		private bool continueNext; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FC7")]
		private Exception exception; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FC8")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000040")]
		public private override TSource Current
		{
			[Address(RVA = "0x1619850", Offset = "0x1618C50", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x6000766")]
			 get { } //Length: 176
			[Address(RVA = "0x1619900", Offset = "0x1618D00", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x6000767")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x1619410", Offset = "0x1618810", Length = "0x1A6")]
		[Token(Token = "0x600076E")]
		private static _SkipUntil() { }

		[Address(RVA = "0x16195C0", Offset = "0x16189C0", Length = "0x282")]
		[Token(Token = "0x6000765")]
		public _SkipUntil(IUniTaskAsyncEnumerable<TSource> source, UniTask other, CancellationToken cancellationToken1) { }

		[Address(RVA = "0x1618640", Offset = "0x1617A40", Length = "0x14F")]
		[Token(Token = "0x600076D")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1619850", Offset = "0x1618C50", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x6000766")]
		public override TSource get_Current() { }

		[Address(RVA = "0x1618790", Offset = "0x1617B90", Length = "0x30D")]
		[Token(Token = "0x6000768")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1618AA0", Offset = "0x1617EA0", Length = "0x32E")]
		[Token(Token = "0x600076A")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x1618DD0", Offset = "0x16181D0", Length = "0xDB")]
		[Token(Token = "0x600076C")]
		private static void OnCanceled1(object state) { }

		[Address(RVA = "0x1618EB0", Offset = "0x16182B0", Length = "0xA5")]
		[AsyncStateMachine(typeof(<RunOther>d__18))]
		[Token(Token = "0x600076B")]
		private UniTaskVoid RunOther(UniTask other) { }

		[Address(RVA = "0x1619900", Offset = "0x1618D00", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000767")]
		private void set_Current(TSource value) { }

		[Address(RVA = "0x1618F60", Offset = "0x1618360", Length = "0x4A2")]
		[Token(Token = "0x6000769")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FBB")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FBC")]
	private readonly UniTask other; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FBD")]
	private readonly Func<CancellationToken, UniTask> other2; //Field offset: 0x0

	[Address(RVA = "0xF640E0", Offset = "0xF634E0", Length = "0x6D")]
	[Token(Token = "0x6000763")]
	public SkipUntil`1(IUniTaskAsyncEnumerable<TSource> source, UniTask other, Func<CancellationToken, UniTask> other2) { }

	[Address(RVA = "0xF63FD0", Offset = "0xF633D0", Length = "0x108")]
	[Token(Token = "0x6000764")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

