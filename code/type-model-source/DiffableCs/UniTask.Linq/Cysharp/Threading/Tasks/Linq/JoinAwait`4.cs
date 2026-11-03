namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000E0")]
internal sealed class JoinAwait : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x20000E1")]
	private sealed class _JoinAwait : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x20000E2")]
		private struct <CreateInnerHashSet>d__24 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400099F")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40009A0")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40009A1")]
			public _JoinAwait<TOuter, TInner, TKey, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40009A2")]
			private Awaiter<ILookup<TKey, TInner>> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1152180", Offset = "0x1151580", Length = "0x611")]
			[Token(Token = "0x6000534")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x6000535")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x400098C")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x400098D")]
		private static readonly Action<Object> OuterSelectCoreDelegate; //Field offset: 0x0
		[Token(Token = "0x400098E")]
		private static readonly Action<Object> ResultSelectCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400099C")]
		private Awaiter<TKey> outerKeyAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400099B")]
		private Awaiter<TResult> resultAwaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400099A")]
		private IEnumerator<TInner> valueEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000999")]
		private TOuter currentOuterValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000998")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000997")]
		private IUniTaskAsyncEnumerator<TOuter> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000996")]
		private ILookup<TKey, TInner> lookup; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000995")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000994")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000993")]
		private readonly Func<TOuter, TInner, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000992")]
		private readonly Func<TInner, UniTask`1<TKey>> innerKeySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000991")]
		private readonly Func<TOuter, UniTask`1<TKey>> outerKeySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000990")]
		private readonly IUniTaskAsyncEnumerable<TInner> inner; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400098F")]
		private readonly IUniTaskAsyncEnumerable<TOuter> outer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400099D")]
		private bool continueNext; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400099E")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000029")]
		public private override TResult Current
		{
			[Address(RVA = "0x1603B10", Offset = "0x1602F10", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x600052A")]
			 get { } //Length: 176
			[Address(RVA = "0x1603BC0", Offset = "0x1602FC0", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x600052B")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x1605580", Offset = "0x1604980", Length = "0x27D")]
		[Token(Token = "0x6000533")]
		private static _JoinAwait() { }

		[Address(RVA = "0x15FE830", Offset = "0x15FDC30", Length = "0x263")]
		[Token(Token = "0x6000529")]
		public _JoinAwait(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, UniTask`1<TKey>> outerKeySelector, Func<TInner, UniTask`1<TKey>> innerKeySelector, Func<TOuter, TInner, UniTask`1<TResult>> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15FCB90", Offset = "0x15FBF90", Length = "0x7F")]
		[AsyncStateMachine(typeof(<CreateInnerHashSet>d__24))]
		[Token(Token = "0x600052D")]
		private UniTaskVoid CreateInnerHashSet() { }

		[Address(RVA = "0x1603C80", Offset = "0x1603080", Length = "0x19B")]
		[Token(Token = "0x6000532")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1603B10", Offset = "0x1602F10", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x600052A")]
		public override TResult get_Current() { }

		[Address(RVA = "0x1603E20", Offset = "0x1603220", Length = "0x161")]
		[Token(Token = "0x600052C")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1603F90", Offset = "0x1603390", Length = "0x823")]
		[Token(Token = "0x600052F")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x1602630", Offset = "0x1601A30", Length = "0x45F")]
		[Token(Token = "0x6000530")]
		private static void OuterSelectCore(object state) { }

		[Address(RVA = "0x16047C0", Offset = "0x1603BC0", Length = "0x2EB")]
		[Token(Token = "0x6000531")]
		private static void ResultSelectCore(object state) { }

		[Address(RVA = "0x1603BC0", Offset = "0x1602FC0", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x600052B")]
		private void set_Current(TResult value) { }

		[Address(RVA = "0x1604AB0", Offset = "0x1603EB0", Length = "0xAC3")]
		[Token(Token = "0x600052E")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000986")]
	private readonly IUniTaskAsyncEnumerable<TOuter> outer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000987")]
	private readonly IUniTaskAsyncEnumerable<TInner> inner; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000988")]
	private readonly Func<TOuter, UniTask`1<TKey>> outerKeySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000989")]
	private readonly Func<TInner, UniTask`1<TKey>> innerKeySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400098A")]
	private readonly Func<TOuter, TInner, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400098B")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0xAC8C60", Offset = "0xAC8060", Length = "0xA1")]
	[Token(Token = "0x6000527")]
	public JoinAwait`4(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, UniTask`1<TKey>> outerKeySelector, Func<TInner, UniTask`1<TKey>> innerKeySelector, Func<TOuter, TInner, UniTask`1<TResult>> resultSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0xAC8B90", Offset = "0xAC7F90", Length = "0xD0")]
	[Token(Token = "0x6000528")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

