namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200019A")]
internal sealed class SkipWhileIntAwait : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x200019B")]
	private class _SkipWhileIntAwait : AsyncEnumeratorAwaitSelectorBase<TSource, TSource, Boolean>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FE9")]
		private Func<TSource, Int32, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FEA")]
		private int index; //Field offset: 0x0

		[Address(RVA = "0x1619CD0", Offset = "0x16190D0", Length = "0xD3")]
		[Token(Token = "0x600078C")]
		public _SkipWhileIntAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x161A2F0", Offset = "0x16196F0", Length = "0x212")]
		[Token(Token = "0x600078D")]
		protected virtual UniTask<Boolean> TransformAsync(TSource sourceCurrent) { }

		[Address(RVA = "0x161A510", Offset = "0x1619910", Length = "0x13C")]
		[Token(Token = "0x600078E")]
		protected virtual bool TrySetCurrentCore(bool awaitResult, out bool terminateIteration) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FE7")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FE8")]
	private readonly Func<TSource, Int32, UniTask`1<Boolean>> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600078A")]
	public SkipWhileIntAwait`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, UniTask`1<Boolean>> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x600078B")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

