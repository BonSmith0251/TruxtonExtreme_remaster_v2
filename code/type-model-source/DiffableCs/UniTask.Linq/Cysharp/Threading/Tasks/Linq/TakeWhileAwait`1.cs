namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001DF")]
internal sealed class TakeWhileAwait : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20001E0")]
	private class _TakeWhileAwait : AsyncEnumeratorAwaitSelectorBase<TSource, TSource, Boolean>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001251")]
		private Func<TSource, UniTask`1<Boolean>> predicate; //Field offset: 0x0

		[Address(RVA = "0x1619CD0", Offset = "0x16190D0", Length = "0xD3")]
		[Token(Token = "0x6000863")]
		public _TakeWhileAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x161EA10", Offset = "0x161DE10", Length = "0x11C")]
		[Token(Token = "0x6000864")]
		protected virtual UniTask<Boolean> TransformAsync(TSource sourceCurrent) { }

		[Address(RVA = "0x161EB30", Offset = "0x161DF30", Length = "0x103")]
		[Token(Token = "0x6000865")]
		protected virtual bool TrySetCurrentCore(bool awaitResult, out bool terminateIteration) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400124F")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001250")]
	private readonly Func<TSource, UniTask`1<Boolean>> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000861")]
	public TakeWhileAwait`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask`1<Boolean>> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x6000862")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

