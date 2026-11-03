namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000C3")]
internal sealed class GroupBy : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x20000C4")]
	private sealed class _GroupBy : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x20000C5")]
		private struct <CreateLookup>d__13 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008D1")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008D2")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008D3")]
			public _GroupBy<TSource, TKey, TElement, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40008D4")]
			private Awaiter<ILookup<TKey, TElement>> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1152C00", Offset = "0x1152000", Length = "0x58A")]
			[Token(Token = "0x60004B6")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60004B7")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008C9")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008CA")]
		private readonly Func<TSource, TKey> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008CB")]
		private readonly Func<TSource, TElement> elementSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008CC")]
		private readonly Func<TKey, IEnumerable`1<TElement>, TResult> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008CD")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008CE")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008CF")]
		private IEnumerator<IGrouping`2<TKey, TElement>> groupEnumerator; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40008D0")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000020")]
		public private override TResult Current
		{
			[Address(RVA = "0x15FCA20", Offset = "0x15FBE20", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x60004B0")]
			 get { } //Length: 176
			[Address(RVA = "0x15FCAD0", Offset = "0x15FBED0", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x60004B1")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x15FC820", Offset = "0x15FBC20", Length = "0x1F3")]
		[Token(Token = "0x60004AF")]
		public _GroupBy(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable`1<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F9FF0", Offset = "0x15F93F0", Length = "0x7F")]
		[AsyncStateMachine(typeof(<CreateLookup>d__13))]
		[Token(Token = "0x60004B3")]
		private UniTaskVoid CreateLookup() { }

		[Address(RVA = "0x15FC0C0", Offset = "0x15FB4C0", Length = "0xBE")]
		[Token(Token = "0x60004B5")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15FCA20", Offset = "0x15FBE20", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x60004B0")]
		public override TResult get_Current() { }

		[Address(RVA = "0x15FC180", Offset = "0x15FB580", Length = "0x161")]
		[Token(Token = "0x60004B2")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15FCAD0", Offset = "0x15FBED0", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x60004B1")]
		private void set_Current(TResult value) { }

		[Address(RVA = "0x15FC540", Offset = "0x15FB940", Length = "0x2D7")]
		[Token(Token = "0x60004B4")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C4")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C5")]
	private readonly Func<TSource, TKey> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C6")]
	private readonly Func<TSource, TElement> elementSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C7")]
	private readonly Func<TKey, IEnumerable`1<TElement>, TResult> resultSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40008C8")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0x16D8D00", Offset = "0x16D8100", Length = "0x8F")]
	[Token(Token = "0x60004AD")]
	public GroupBy`4(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable`1<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x16D8C40", Offset = "0x16D8040", Length = "0xB9")]
	[Token(Token = "0x60004AE")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

