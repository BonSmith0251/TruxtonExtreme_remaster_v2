namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000089")]
internal sealed class Concat : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x200008A")]
	private sealed class _Concat : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x200008C")]
		private struct <RunSecondAfterDisposeAsync>d__16 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000784")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000785")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000786")]
			public _Concat<TSource> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000787")]
			private Awaiter <>u__1; //Field offset: 0x0

			[Address(RVA = "0x197F010", Offset = "0x197E410", Length = "0x464")]
			[Token(Token = "0x6000407")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000408")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x200008B")]
		private enum IteratingState : int
		{
			IteratingFirst = 0,
			IteratingSecond = 1,
			Complete = 2,
		}

		[Token(Token = "0x4000778")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000779")]
		private readonly IUniTaskAsyncEnumerable<TSource> first; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400077A")]
		private readonly IUniTaskAsyncEnumerable<TSource> second; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400077B")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400077C")]
		private IteratingState<TSource> iteratingState; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400077D")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400077E")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400077F")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000016")]
		public private override TSource Current
		{
			[Address(RVA = "0x15EF550", Offset = "0x15EE950", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x60003FF")]
			 get { } //Length: 176
			[Address(RVA = "0x15EF600", Offset = "0x15EEA00", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x6000400")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x15EF300", Offset = "0x15EE700", Length = "0xEA")]
		[Token(Token = "0x6000406")]
		private static _Concat() { }

		[Address(RVA = "0x15EF3F0", Offset = "0x15EE7F0", Length = "0x15C")]
		[Token(Token = "0x60003FE")]
		public _Concat(IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15EE700", Offset = "0x15EDB00", Length = "0x12B")]
		[Token(Token = "0x6000405")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15EF550", Offset = "0x15EE950", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x60003FF")]
		public override TSource get_Current() { }

		[Address(RVA = "0x15EE830", Offset = "0x15EDC30", Length = "0x169")]
		[Token(Token = "0x6000401")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15EE9A0", Offset = "0x15EDDA0", Length = "0x36A")]
		[Token(Token = "0x6000403")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x15EED10", Offset = "0x15EE110", Length = "0x7B")]
		[AsyncStateMachine(typeof(<RunSecondAfterDisposeAsync>d__16))]
		[Token(Token = "0x6000404")]
		private UniTaskVoid RunSecondAfterDisposeAsync() { }

		[Address(RVA = "0x15EF600", Offset = "0x15EEA00", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000400")]
		private void set_Current(TSource value) { }

		[Address(RVA = "0x15EED90", Offset = "0x15EE190", Length = "0x56A")]
		[Token(Token = "0x6000402")]
		private void StartIterate() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000776")]
	private readonly IUniTaskAsyncEnumerable<TSource> first; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000777")]
	private readonly IUniTaskAsyncEnumerable<TSource> second; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x60003FC")]
	public Concat`1(IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second) { }

	[Address(RVA = "0x17A60C0", Offset = "0x17A54C0", Length = "0x97")]
	[Token(Token = "0x60003FD")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

