namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200019E")]
internal sealed class SkipWhileIntAwaitWithCancellation : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x200019F")]
	private class _SkipWhileIntAwaitWithCancellation : AsyncEnumeratorAwaitSelectorBase<TSource, TSource, Boolean>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FF0")]
		private Func<TSource, Int32, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FF1")]
		private int index; //Field offset: 0x0

		[Address(RVA = "0x1619CD0", Offset = "0x16190D0", Length = "0xD3")]
		[Token(Token = "0x6000796")]
		public _SkipWhileIntAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, CancellationToken, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x161A0A0", Offset = "0x16194A0", Length = "0x248")]
		[Token(Token = "0x6000797")]
		protected virtual UniTask<Boolean> TransformAsync(TSource sourceCurrent) { }

		[Address(RVA = "0x1619B90", Offset = "0x1618F90", Length = "0x13C")]
		[Token(Token = "0x6000798")]
		protected virtual bool TrySetCurrentCore(bool awaitResult, out bool terminateIteration) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FEE")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FEF")]
	private readonly Func<TSource, Int32, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000794")]
	public SkipWhileIntAwaitWithCancellation`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, CancellationToken, UniTask`1<Boolean>> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x6000795")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

