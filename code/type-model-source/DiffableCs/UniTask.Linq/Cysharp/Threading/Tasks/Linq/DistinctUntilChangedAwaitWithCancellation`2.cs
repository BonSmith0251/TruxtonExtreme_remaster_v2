namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000AA")]
internal sealed class DistinctUntilChangedAwaitWithCancellation : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20000AB")]
	private sealed class _DistinctUntilChangedAwaitWithCancellation : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000815")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000816")]
		private readonly Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000817")]
		private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000818")]
		private readonly CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000819")]
		private int state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400081A")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400081B")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400081C")]
		private Awaiter<TKey> awaiter2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400081D")]
		private Action moveNextAction; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400081E")]
		private TSource enumeratorCurrent; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400081F")]
		private TKey prev; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000820")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700001C")]
		public private override TSource Current
		{
			[Address(RVA = "0x15F29C0", Offset = "0x15F1DC0", Length = "0xAF")]
			[CompilerGenerated]
			[Token(Token = "0x6000462")]
			 get { } //Length: 175
			[Address(RVA = "0x15F2A70", Offset = "0x15F1E70", Length = "0xBC")]
			[CompilerGenerated]
			[Token(Token = "0x6000463")]
			private set { } //Length: 188
		}

		[Address(RVA = "0x15F2780", Offset = "0x15F1B80", Length = "0x231")]
		[Token(Token = "0x6000461")]
		public _DistinctUntilChangedAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F1440", Offset = "0x15F0840", Length = "0xF0")]
		[Token(Token = "0x6000466")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x15F29C0", Offset = "0x15F1DC0", Length = "0xAF")]
		[CompilerGenerated]
		[Token(Token = "0x6000462")]
		public override TSource get_Current() { }

		[Address(RVA = "0x15F1630", Offset = "0x15F0A30", Length = "0x298")]
		[Token(Token = "0x6000465")]
		private void MoveNext() { }

		[Address(RVA = "0x15F1540", Offset = "0x15F0940", Length = "0xE3")]
		[Token(Token = "0x6000464")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15F2A70", Offset = "0x15F1E70", Length = "0xBC")]
		[CompilerGenerated]
		[Token(Token = "0x6000463")]
		private void set_Current(TSource value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000812")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000813")]
	private readonly Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000814")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x600045F")]
	public DistinctUntilChangedAwaitWithCancellation`2(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x1550FD0", Offset = "0x15503D0", Length = "0x9C")]
	[Token(Token = "0x6000460")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

