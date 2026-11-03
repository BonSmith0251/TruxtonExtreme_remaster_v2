namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001DB")]
internal sealed class TakeWhile : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20001DC")]
	private class _TakeWhile : AsyncEnumeratorBase<TSource, TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400124A")]
		private Func<TSource, Boolean> predicate; //Field offset: 0x0

		[Address(RVA = "0x1619CD0", Offset = "0x16190D0", Length = "0xD3")]
		[Token(Token = "0x600085B")]
		public _TakeWhile(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Boolean> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x161F240", Offset = "0x161E640", Length = "0x1AB")]
		[Token(Token = "0x600085C")]
		protected virtual bool TryMoveNextCore(bool sourceHasCurrent, out bool result) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001248")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001249")]
	private readonly Func<TSource, Boolean> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000859")]
	public TakeWhile`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x600085A")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

