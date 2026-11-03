namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000A0")]
internal sealed class DistinctAwait : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20000A1")]
	private class _DistinctAwait : AsyncEnumeratorAwaitSelectorBase<TSource, TSource, TKey>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007E5")]
		private readonly HashSet<TKey> set; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007E6")]
		private readonly Func<TSource, UniTask`1<TKey>> keySelector; //Field offset: 0x0

		[Address(RVA = "0x15F0FA0", Offset = "0x15F03A0", Length = "0x159")]
		[Token(Token = "0x600043F")]
		public _DistinctAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F1100", Offset = "0x15F0500", Length = "0x15A")]
		[Token(Token = "0x6000440")]
		protected virtual UniTask<TKey> TransformAsync(TSource sourceCurrent) { }

		[Address(RVA = "0x15F1260", Offset = "0x15F0660", Length = "0x1D8")]
		[Token(Token = "0x6000441")]
		protected virtual bool TrySetCurrentCore(TKey awaitResult, out bool terminateIteration) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007E2")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007E3")]
	private readonly Func<TSource, UniTask`1<TKey>> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007E4")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x600043D")]
	public DistinctAwait`2(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<TKey>> keySelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x1550FD0", Offset = "0x15503D0", Length = "0x9C")]
	[Token(Token = "0x600043E")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

