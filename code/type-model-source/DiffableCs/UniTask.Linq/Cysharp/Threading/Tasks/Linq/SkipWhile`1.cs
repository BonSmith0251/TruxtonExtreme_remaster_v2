namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000194")]
internal sealed class SkipWhile : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x2000195")]
	private class _SkipWhile : AsyncEnumeratorBase<TSource, TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FDF")]
		private Func<TSource, Boolean> predicate; //Field offset: 0x0

		[Address(RVA = "0x1619CD0", Offset = "0x16190D0", Length = "0xD3")]
		[Token(Token = "0x600077F")]
		public _SkipWhile(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Boolean> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x161A900", Offset = "0x1619D00", Length = "0x22C")]
		[Token(Token = "0x6000780")]
		protected virtual bool TryMoveNextCore(bool sourceHasCurrent, out bool result) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FDD")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FDE")]
	private readonly Func<TSource, Boolean> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x600077D")]
	public SkipWhile`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Boolean> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x600077E")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

