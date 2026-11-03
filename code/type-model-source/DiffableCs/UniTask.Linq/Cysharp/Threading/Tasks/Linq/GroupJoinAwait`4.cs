namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000D5")]
internal sealed class GroupJoinAwait : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x20000D6")]
	private sealed class _GroupJoinAwait : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x20000D7")]
		private struct <CreateLookup>d__22 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000946")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000947")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000948")]
			public _GroupJoinAwait<TOuter, TInner, TKey, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000949")]
			private Awaiter<ILookup<TKey, TInner>> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1152180", Offset = "0x1151580", Length = "0x611")]
			[Token(Token = "0x6000502")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000503")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x4000935")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4000936")]
		private static readonly Action<Object> ResultSelectCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x4000937")]
		private static readonly Action<Object> OuterKeySelectCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000943")]
		private Awaiter<TKey> outerKeyAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000942")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000941")]
		private TOuter outerValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000940")]
		private IUniTaskAsyncEnumerator<TOuter> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400093F")]
		private ILookup<TKey, TInner> lookup; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400093E")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400093D")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400093C")]
		private readonly Func<TOuter, IEnumerable`1<TInner>, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400093B")]
		private readonly Func<TInner, UniTask`1<TKey>> innerKeySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400093A")]
		private readonly Func<TOuter, UniTask`1<TKey>> outerKeySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000939")]
		private readonly IUniTaskAsyncEnumerable<TInner> inner; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000938")]
		private readonly IUniTaskAsyncEnumerable<TOuter> outer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000944")]
		private Awaiter<TResult> resultAwaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000945")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000026")]
		public private override TResult Current
		{
			[Address(RVA = "0x15FEAA0", Offset = "0x15FDEA0", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x60004F8")]
			 get { } //Length: 176
			[Address(RVA = "0x15FEB50", Offset = "0x15FDF50", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x60004F9")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x1600520", Offset = "0x15FF920", Length = "0x27D")]
		[Token(Token = "0x6000501")]
		private static _GroupJoinAwait() { }

		[Address(RVA = "0x15FE830", Offset = "0x15FDC30", Length = "0x263")]
		[Token(Token = "0x60004F7")]
		public _GroupJoinAwait(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, UniTask`1<TKey>> outerKeySelector, Func<TInner, UniTask`1<TKey>> innerKeySelector, Func<TOuter, IEnumerable`1<TInner>, UniTask`1<TResult>> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15FCB90", Offset = "0x15FBF90", Length = "0x7F")]
		[AsyncStateMachine(typeof(<CreateLookup>d__22))]
		[Token(Token = "0x60004FB")]
		private UniTaskVoid CreateLookup() { }

		[Address(RVA = "0x15FEC10", Offset = "0x15FE010", Length = "0x12B")]
		[Token(Token = "0x6000500")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15FEAA0", Offset = "0x15FDEA0", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x60004F8")]
		public override TResult get_Current() { }

		[Address(RVA = "0x15FED40", Offset = "0x15FE140", Length = "0x161")]
		[Token(Token = "0x60004FA")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15FEEB0", Offset = "0x15FE2B0", Length = "0x788")]
		[Token(Token = "0x60004FD")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x15FF640", Offset = "0x15FEA40", Length = "0x871")]
		[Token(Token = "0x60004FE")]
		private static void OuterKeySelectCore(object state) { }

		[Address(RVA = "0x15FFEC0", Offset = "0x15FF2C0", Length = "0x2EB")]
		[Token(Token = "0x60004FF")]
		private static void ResultSelectCore(object state) { }

		[Address(RVA = "0x15FEB50", Offset = "0x15FDF50", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x60004F9")]
		private void set_Current(TResult value) { }

		[Address(RVA = "0x16001B0", Offset = "0x15FF5B0", Length = "0x36D")]
		[Token(Token = "0x60004FC")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400092F")]
	private readonly IUniTaskAsyncEnumerable<TOuter> outer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000930")]
	private readonly IUniTaskAsyncEnumerable<TInner> inner; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000931")]
	private readonly Func<TOuter, UniTask`1<TKey>> outerKeySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000932")]
	private readonly Func<TInner, UniTask`1<TKey>> innerKeySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000933")]
	private readonly Func<TOuter, IEnumerable`1<TInner>, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000934")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0xAC8C60", Offset = "0xAC8060", Length = "0xA1")]
	[Token(Token = "0x60004F5")]
	public GroupJoinAwait`4(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, UniTask`1<TKey>> outerKeySelector, Func<TInner, UniTask`1<TKey>> innerKeySelector, Func<TOuter, IEnumerable`1<TInner>, UniTask`1<TResult>> resultSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0xAC8B90", Offset = "0xAC7F90", Length = "0xD0")]
	[Token(Token = "0x60004F6")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

