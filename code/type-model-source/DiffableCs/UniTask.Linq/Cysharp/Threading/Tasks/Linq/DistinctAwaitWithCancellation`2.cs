namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000A2")]
internal sealed class DistinctAwaitWithCancellation : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20000A3")]
	private class _DistinctAwaitWithCancellation : AsyncEnumeratorAwaitSelectorBase<TSource, TSource, TKey>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007EA")]
		private readonly HashSet<TKey> set; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007EB")]
		private readonly Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0

		[Address(RVA = "0x15F0FA0", Offset = "0x15F03A0", Length = "0x159")]
		[Token(Token = "0x6000444")]
		public _DistinctAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F0C20", Offset = "0x15F0020", Length = "0x19E")]
		[Token(Token = "0x6000445")]
		protected virtual UniTask<TKey> TransformAsync(TSource sourceCurrent) { }

		[Address(RVA = "0x15F0DC0", Offset = "0x15F01C0", Length = "0x1D8")]
		[Token(Token = "0x6000446")]
		protected virtual bool TrySetCurrentCore(TKey awaitResult, out bool terminateIteration) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007E7")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007E8")]
	private readonly Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007E9")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x6000442")]
	public DistinctAwaitWithCancellation`2(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<TKey>> keySelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x1550FD0", Offset = "0x15503D0", Length = "0x9C")]
	[Token(Token = "0x6000443")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

