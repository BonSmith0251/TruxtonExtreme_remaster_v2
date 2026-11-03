namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000E3")]
internal sealed class JoinAwaitWithCancellation : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x20000E4")]
	private sealed class _JoinAwaitWithCancellation : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x20000E5")]
		private struct <CreateInnerHashSet>d__24 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40009BC")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40009BD")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40009BE")]
			public _JoinAwaitWithCancellation<TOuter, TInner, TKey, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40009BF")]
			private Awaiter<ILookup<TKey, TInner>> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1152180", Offset = "0x1151580", Length = "0x611")]
			[Token(Token = "0x6000543")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000544")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x40009A9")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x40009AA")]
		private static readonly Action<Object> OuterSelectCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x40009AB")]
		private static readonly Action<Object> ResultSelectCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009B9")]
		private Awaiter<TKey> outerKeyAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009B8")]
		private Awaiter<TResult> resultAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009B7")]
		private IEnumerator<TInner> valueEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009B6")]
		private TOuter currentOuterValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009B5")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009B4")]
		private IUniTaskAsyncEnumerator<TOuter> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009B3")]
		private ILookup<TKey, TInner> lookup; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009B2")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009B1")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009B0")]
		private readonly Func<TOuter, TInner, CancellationToken, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009AF")]
		private readonly Func<TInner, CancellationToken, UniTask`1<TKey>> innerKeySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009AE")]
		private readonly Func<TOuter, CancellationToken, UniTask`1<TKey>> outerKeySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009AD")]
		private readonly IUniTaskAsyncEnumerable<TInner> inner; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009AC")]
		private readonly IUniTaskAsyncEnumerable<TOuter> outer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009BA")]
		private bool continueNext; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009BB")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700002A")]
		public private override TResult Current
		{
			[Address(RVA = "0x1603B10", Offset = "0x1602F10", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x6000539")]
			 get { } //Length: 176
			[Address(RVA = "0x1603BC0", Offset = "0x1602FC0", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x600053A")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x1603890", Offset = "0x1602C90", Length = "0x27D")]
		[Token(Token = "0x6000542")]
		private static _JoinAwaitWithCancellation() { }

		[Address(RVA = "0x15FE830", Offset = "0x15FDC30", Length = "0x263")]
		[Token(Token = "0x6000538")]
		public _JoinAwaitWithCancellation(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, CancellationToken, UniTask`1<TKey>> outerKeySelector, Func<TInner, CancellationToken, UniTask`1<TKey>> innerKeySelector, Func<TOuter, TInner, CancellationToken, UniTask`1<TResult>> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15FCB90", Offset = "0x15FBF90", Length = "0x7F")]
		[AsyncStateMachine(typeof(<CreateInnerHashSet>d__24))]
		[Token(Token = "0x600053C")]
		private UniTaskVoid CreateInnerHashSet() { }

		[Address(RVA = "0x1601A90", Offset = "0x1600E90", Length = "0x19B")]
		[Token(Token = "0x6000541")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1603B10", Offset = "0x1602F10", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x6000539")]
		public override TResult get_Current() { }

		[Address(RVA = "0x1601C30", Offset = "0x1601030", Length = "0x161")]
		[Token(Token = "0x600053B")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1601DA0", Offset = "0x16011A0", Length = "0x886")]
		[Token(Token = "0x600053E")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x1602630", Offset = "0x1601A30", Length = "0x45F")]
		[Token(Token = "0x600053F")]
		private static void OuterSelectCore(object state) { }

		[Address(RVA = "0x1602A90", Offset = "0x1601E90", Length = "0x2EB")]
		[Token(Token = "0x6000540")]
		private static void ResultSelectCore(object state) { }

		[Address(RVA = "0x1603BC0", Offset = "0x1602FC0", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x600053A")]
		private void set_Current(TResult value) { }

		[Address(RVA = "0x1602D80", Offset = "0x1602180", Length = "0xB0B")]
		[Token(Token = "0x600053D")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009A3")]
	private readonly IUniTaskAsyncEnumerable<TOuter> outer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009A4")]
	private readonly IUniTaskAsyncEnumerable<TInner> inner; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009A5")]
	private readonly Func<TOuter, CancellationToken, UniTask`1<TKey>> outerKeySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009A6")]
	private readonly Func<TInner, CancellationToken, UniTask`1<TKey>> innerKeySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009A7")]
	private readonly Func<TOuter, TInner, CancellationToken, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009A8")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0xAC8C60", Offset = "0xAC8060", Length = "0xA1")]
	[Token(Token = "0x6000536")]
	public JoinAwaitWithCancellation`4(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, CancellationToken, UniTask`1<TKey>> outerKeySelector, Func<TInner, CancellationToken, UniTask`1<TKey>> innerKeySelector, Func<TOuter, TInner, CancellationToken, UniTask`1<TResult>> resultSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0xAC8B90", Offset = "0xAC7F90", Length = "0xD0")]
	[Token(Token = "0x6000537")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

