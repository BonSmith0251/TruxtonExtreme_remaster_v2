namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001E3")]
internal sealed class TakeWhileAwaitWithCancellation : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20001E4")]
	private class _TakeWhileAwaitWithCancellation : AsyncEnumeratorAwaitSelectorBase<TSource, TSource, Boolean>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001258")]
		private Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0

		[Address(RVA = "0x1619CD0", Offset = "0x16190D0", Length = "0xD3")]
		[Token(Token = "0x600086D")]
		public _TakeWhileAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x161E790", Offset = "0x161DB90", Length = "0x166")]
		[Token(Token = "0x600086E")]
		protected virtual UniTask<Boolean> TransformAsync(TSource sourceCurrent) { }

		[Address(RVA = "0x161E900", Offset = "0x161DD00", Length = "0x103")]
		[Token(Token = "0x600086F")]
		protected virtual bool TrySetCurrentCore(bool awaitResult, out bool terminateIteration) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001256")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001257")]
	private readonly Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600086B")]
	public TakeWhileAwaitWithCancellation`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask`1<Boolean>> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x600086C")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

