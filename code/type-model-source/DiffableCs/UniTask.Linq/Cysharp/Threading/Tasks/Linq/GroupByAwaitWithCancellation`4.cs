namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000CF")]
internal sealed class GroupByAwaitWithCancellation : IUniTaskAsyncEnumerable<TResult>
{
	[Token(Token = "0x20000D0")]
	private sealed class _GroupByAwaitWithCancellation : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		[CompilerGenerated]
		[Token(Token = "0x20000D1")]
		private struct <CreateLookup>d__15 : IAsyncStateMachine
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000915")]
			public int <>1__state; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000916")]
			public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000917")]
			public _GroupByAwaitWithCancellation<TSource, TKey, TElement, TResult> <>4__this; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000918")]
			private Awaiter<ILookup<TKey, TElement>> <>u__1; //Field offset: 0x0

			[Address(RVA = "0x1153190", Offset = "0x1152590", Length = "0x591")]
			[Token(Token = "0x60004E6")]
			private override void MoveNext() { }

			[Address(RVA = "0x113E390", Offset = "0x113D790", Length = "0xC")]
			[DebuggerHidden]
			[Token(Token = "0x60004E7")]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[Token(Token = "0x400090B")]
		private static readonly Action<Object> ResultSelectCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400090C")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400090D")]
		private readonly Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400090E")]
		private readonly Func<TSource, CancellationToken, UniTask`1<TElement>> elementSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400090F")]
		private readonly Func<TKey, IEnumerable`1<TElement>, CancellationToken, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000910")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000911")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000912")]
		private IEnumerator<IGrouping`2<TKey, TElement>> groupEnumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000913")]
		private Awaiter<TResult> awaiter; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000914")]
		private TResult <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000024")]
		public private override TResult Current
		{
			[Address(RVA = "0x15FB160", Offset = "0x15FA560", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x60004DE")]
			 get { } //Length: 176
			[Address(RVA = "0x15FB210", Offset = "0x15FA610", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x60004DF")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x15FADC0", Offset = "0x15FA1C0", Length = "0xF3")]
		[Token(Token = "0x60004E5")]
		private static _GroupByAwaitWithCancellation() { }

		[Address(RVA = "0x15FAF60", Offset = "0x15FA360", Length = "0x1FE")]
		[Token(Token = "0x60004DD")]
		public _GroupByAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector, Func<TSource, CancellationToken, UniTask`1<TElement>> elementSelector, Func<TKey, IEnumerable`1<TElement>, CancellationToken, UniTask`1<TResult>> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F9FF0", Offset = "0x15F93F0", Length = "0x7F")]
		[AsyncStateMachine(typeof(<CreateLookup>d__15))]
		[Token(Token = "0x60004E1")]
		private UniTaskVoid CreateLookup() { }

		[Address(RVA = "0x15FA0F0", Offset = "0x15F94F0", Length = "0xBE")]
		[Token(Token = "0x60004E4")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15FB160", Offset = "0x15FA560", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x60004DE")]
		public override TResult get_Current() { }

		[Address(RVA = "0x15FA210", Offset = "0x15F9610", Length = "0x161")]
		[Token(Token = "0x60004E0")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15FA4A0", Offset = "0x15F98A0", Length = "0x2EB")]
		[Token(Token = "0x60004E3")]
		private static void ResultSelectCore(object state) { }

		[Address(RVA = "0x15FB210", Offset = "0x15FA610", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x60004DF")]
		private void set_Current(TResult value) { }

		[Address(RVA = "0x15FA790", Offset = "0x15F9B90", Length = "0x4FC")]
		[Token(Token = "0x60004E2")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000906")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000907")]
	private readonly Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000908")]
	private readonly Func<TSource, CancellationToken, UniTask`1<TElement>> elementSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000909")]
	private readonly Func<TKey, IEnumerable`1<TElement>, CancellationToken, UniTask`1<TResult>> resultSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400090A")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0x16D8D00", Offset = "0x16D8100", Length = "0x8F")]
	[Token(Token = "0x60004DB")]
	public GroupByAwaitWithCancellation`4(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector, Func<TSource, CancellationToken, UniTask`1<TElement>> elementSelector, Func<TKey, IEnumerable`1<TElement>, CancellationToken, UniTask`1<TResult>> resultSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x16D8C40", Offset = "0x16D8040", Length = "0xB9")]
	[Token(Token = "0x60004DC")]
	public override IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

