namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000C9")]
internal sealed class GroupByAwait : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x20000CA")]
	private sealed class _GroupByAwait : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x20000CB")]
		private struct <CreateLookup>d__15 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008F3")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008F4")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008F5")]
			public _GroupByAwait<TSource, TKey, TElement, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008F6")]
			private Awaiter<ILookup<TKey, TElement>> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1153190", Offset = "0x1152590", Length = "0x591")]
			[Token(Token = "0x60004CE")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60004CF")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x40008E9")]
		private static readonly Action<Object> ResultSelectCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008EA")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008EB")]
		private readonly Func<TSource, UniTask`1<TKey>> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008EC")]
		private readonly Func<TSource, UniTask`1<TElement>> elementSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008ED")]
		private readonly Func<TKey, IEnumerable`1<TElement>, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008EE")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008EF")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008F0")]
		private IEnumerator<IGrouping`2<TKey, TElement>> groupEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008F1")]
		private Awaiter<TResult> awaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008F2")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000022")]
		public private override TResult Current
		{
			[Address(RVA = "0x15FB160", Offset = "0x15FA560", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x60004C6")]
			 get { } //Length: 176
			[Address(RVA = "0x15FB210", Offset = "0x15FA610", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x60004C7")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x15FBF60", Offset = "0x15FB360", Length = "0xF3")]
		[Token(Token = "0x60004CD")]
		private static _GroupByAwait() { }

		[Address(RVA = "0x15FAF60", Offset = "0x15FA360", Length = "0x1FE")]
		[Token(Token = "0x60004C5")]
		public _GroupByAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TKey>> keySelector, Func<TSource, UniTask`1<TElement>> elementSelector, Func<TKey, IEnumerable`1<TElement>, UniTask`1<TResult>> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F9FF0", Offset = "0x15F93F0", Length = "0x7F")]
		[AsyncStateMachine(typeof(<CreateLookup>d__15))]
		[Token(Token = "0x60004C9")]
		private UniTaskVoid CreateLookup() { }

		[Address(RVA = "0x15FB330", Offset = "0x15FA730", Length = "0xBE")]
		[Token(Token = "0x60004CC")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15FB160", Offset = "0x15FA560", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x60004C6")]
		public override TResult get_Current() { }

		[Address(RVA = "0x15FB510", Offset = "0x15FA910", Length = "0x161")]
		[Token(Token = "0x60004C8")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15FB680", Offset = "0x15FAA80", Length = "0x2EB")]
		[Token(Token = "0x60004CB")]
		private static void ResultSelectCore(object state) { }

		[Address(RVA = "0x15FB210", Offset = "0x15FA610", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x60004C7")]
		private void set_Current(TResult value) { }

		[Address(RVA = "0x15FBAA0", Offset = "0x15FAEA0", Length = "0x4BA")]
		[Token(Token = "0x60004CA")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008E4")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008E5")]
	private readonly Func<TSource, UniTask`1<TKey>> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008E6")]
	private readonly Func<TSource, UniTask`1<TElement>> elementSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008E7")]
	private readonly Func<TKey, IEnumerable`1<TElement>, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008E8")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0x16D8D00", Offset = "0x16D8100", Length = "0x8F")]
	[Token(Token = "0x60004C3")]
	public GroupByAwait`4(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TKey>> keySelector, Func<TSource, UniTask`1<TElement>> elementSelector, Func<TKey, IEnumerable`1<TElement>, UniTask`1<TResult>> resultSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x16D8C40", Offset = "0x16D8040", Length = "0xB9")]
	[Token(Token = "0x60004C4")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

