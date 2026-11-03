namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000D8")]
internal sealed class GroupJoinAwaitWithCancellation : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x20000D9")]
	private sealed class _GroupJoinAwaitWithCancellation : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x20000DA")]
		private struct <CreateLookup>d__22 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000961")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000962")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000963")]
			public _GroupJoinAwaitWithCancellation<TOuter, TInner, TKey, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000964")]
			private Awaiter<ILookup<TKey, TInner>> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1152180", Offset = "0x1151580", Length = "0x611")]
			[Token(Token = "0x6000511")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000512")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000950")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4000951")]
		private static readonly Action<Object> ResultSelectCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4000952")]
		private static readonly Action<Object> OuterKeySelectCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400095E")]
		private Awaiter<TKey> outerKeyAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400095D")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400095C")]
		private TOuter outerValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400095B")]
		private IUniTaskAsyncEnumerator<TOuter> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400095A")]
		private ILookup<TKey, TInner> lookup; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000959")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000958")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000957")]
		private readonly Func<TOuter, IEnumerable`1<TInner>, CancellationToken, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000956")]
		private readonly Func<TInner, CancellationToken, UniTask`1<TKey>> innerKeySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000955")]
		private readonly Func<TOuter, CancellationToken, UniTask`1<TKey>> outerKeySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000954")]
		private readonly IUniTaskAsyncEnumerable<TInner> inner; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000953")]
		private readonly IUniTaskAsyncEnumerable<TOuter> outer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400095F")]
		private Awaiter<TResult> resultAwaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000960")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000027")]
		public private override TResult Current
		{
			[Address(RVA = "0x15FEAA0", Offset = "0x15FDEA0", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x6000507")]
			 get { } //Length: 176
			[Address(RVA = "0x15FEB50", Offset = "0x15FDF50", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x6000508")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x15FE5B0", Offset = "0x15FD9B0", Length = "0x27D")]
		[Token(Token = "0x6000510")]
		private static _GroupJoinAwaitWithCancellation() { }

		[Address(RVA = "0x15FE830", Offset = "0x15FDC30", Length = "0x263")]
		[Token(Token = "0x6000506")]
		public _GroupJoinAwaitWithCancellation(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, CancellationToken, UniTask`1<TKey>> outerKeySelector, Func<TInner, CancellationToken, UniTask`1<TKey>> innerKeySelector, Func<TOuter, IEnumerable`1<TInner>, CancellationToken, UniTask`1<TResult>> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15FCB90", Offset = "0x15FBF90", Length = "0x7F")]
		[AsyncStateMachine(typeof(<CreateLookup>d__22))]
		[Token(Token = "0x600050A")]
		private UniTaskVoid CreateLookup() { }

		[Address(RVA = "0x15FCC10", Offset = "0x15FC010", Length = "0x12B")]
		[Token(Token = "0x600050F")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15FEAA0", Offset = "0x15FDEA0", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x6000507")]
		public override TResult get_Current() { }

		[Address(RVA = "0x15FCD40", Offset = "0x15FC140", Length = "0x161")]
		[Token(Token = "0x6000509")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15FCEB0", Offset = "0x15FC2B0", Length = "0x7DA")]
		[Token(Token = "0x600050C")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x15FD690", Offset = "0x15FCA90", Length = "0x8BC")]
		[Token(Token = "0x600050D")]
		private static void OuterKeySelectCore(object state) { }

		[Address(RVA = "0x15FDF50", Offset = "0x15FD350", Length = "0x2EB")]
		[Token(Token = "0x600050E")]
		private static void ResultSelectCore(object state) { }

		[Address(RVA = "0x15FEB50", Offset = "0x15FDF50", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000508")]
		private void set_Current(TResult value) { }

		[Address(RVA = "0x15FE240", Offset = "0x15FD640", Length = "0x36D")]
		[Token(Token = "0x600050B")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400094A")]
	private readonly IUniTaskAsyncEnumerable<TOuter> outer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400094B")]
	private readonly IUniTaskAsyncEnumerable<TInner> inner; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400094C")]
	private readonly Func<TOuter, CancellationToken, UniTask`1<TKey>> outerKeySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400094D")]
	private readonly Func<TInner, CancellationToken, UniTask`1<TKey>> innerKeySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400094E")]
	private readonly Func<TOuter, IEnumerable`1<TInner>, CancellationToken, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400094F")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0xAC8C60", Offset = "0xAC8060", Length = "0xA1")]
	[Token(Token = "0x6000504")]
	public GroupJoinAwaitWithCancellation`4(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, CancellationToken, UniTask`1<TKey>> outerKeySelector, Func<TInner, CancellationToken, UniTask`1<TKey>> innerKeySelector, Func<TOuter, IEnumerable`1<TInner>, CancellationToken, UniTask`1<TResult>> resultSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0xAC8B90", Offset = "0xAC7F90", Length = "0xD0")]
	[Token(Token = "0x6000505")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

