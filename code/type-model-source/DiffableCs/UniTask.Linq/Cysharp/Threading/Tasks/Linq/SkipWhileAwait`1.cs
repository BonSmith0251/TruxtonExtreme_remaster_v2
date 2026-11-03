namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000198")]
internal sealed class SkipWhileAwait : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x2000199")]
	private class _SkipWhileAwait : AsyncEnumeratorAwaitSelectorBase<TSource, TSource, Boolean>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FE6")]
		private Func<TSource, UniTask`1<Boolean>> predicate; //Field offset: 0x0

		[Address(RVA = "0x1619CD0", Offset = "0x16190D0", Length = "0xD3")]
		[Token(Token = "0x6000787")]
		public _SkipWhileAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1619DB0", Offset = "0x16191B0", Length = "0x190")]
		[Token(Token = "0x6000788")]
		protected virtual UniTask<Boolean> TransformAsync(TSource sourceCurrent) { }

		[Address(RVA = "0x1619F50", Offset = "0x1619350", Length = "0x142")]
		[Token(Token = "0x6000789")]
		protected virtual bool TrySetCurrentCore(bool awaitResult, out bool terminateIteration) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FE4")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FE5")]
	private readonly Func<TSource, UniTask`1<Boolean>> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000785")]
	public SkipWhileAwait`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Boolean>> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x6000786")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

