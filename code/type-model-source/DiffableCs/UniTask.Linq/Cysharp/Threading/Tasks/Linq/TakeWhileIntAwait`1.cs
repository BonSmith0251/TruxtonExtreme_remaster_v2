namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001E1")]
internal sealed class TakeWhileIntAwait : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20001E2")]
	private class _TakeWhileIntAwait : AsyncEnumeratorAwaitSelectorBase<TSource, TSource, Boolean>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001254")]
		private readonly Func<TSource, Int32, UniTask`1<Boolean>> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001255")]
		private int index; //Field offset: 0x0

		[Address(RVA = "0x1619CD0", Offset = "0x16190D0", Length = "0xD3")]
		[Token(Token = "0x6000868")]
		public _TakeWhileIntAwait(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, UniTask`1<Boolean>> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x161EE40", Offset = "0x161E240", Length = "0x1CD")]
		[Token(Token = "0x6000869")]
		protected virtual UniTask<Boolean> TransformAsync(TSource sourceCurrent) { }

		[Address(RVA = "0x161EB30", Offset = "0x161DF30", Length = "0x103")]
		[Token(Token = "0x600086A")]
		protected virtual bool TrySetCurrentCore(bool awaitResult, out bool terminateIteration) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001252")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001253")]
	private readonly Func<TSource, Int32, UniTask`1<Boolean>> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000866")]
	public TakeWhileIntAwait`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, UniTask`1<Boolean>> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x6000867")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

