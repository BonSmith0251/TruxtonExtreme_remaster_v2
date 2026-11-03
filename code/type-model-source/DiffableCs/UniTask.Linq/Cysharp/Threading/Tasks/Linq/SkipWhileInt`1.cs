namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000196")]
internal sealed class SkipWhileInt : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x2000197")]
	private class _SkipWhileInt : AsyncEnumeratorBase<TSource, TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FE2")]
		private Func<TSource, Int32, Boolean> predicate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FE3")]
		private int index; //Field offset: 0x0

		[Address(RVA = "0x1619CD0", Offset = "0x16190D0", Length = "0xD3")]
		[Token(Token = "0x6000783")]
		public _SkipWhileInt(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, Boolean> predicate, CancellationToken cancellationToken) { }

		[Address(RVA = "0x161A650", Offset = "0x1619A50", Length = "0x2A1")]
		[Token(Token = "0x6000784")]
		protected virtual bool TryMoveNextCore(bool sourceHasCurrent, out bool result) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FE0")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FE1")]
	private readonly Func<TSource, Int32, Boolean> predicate; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000781")]
	public SkipWhileInt`1(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, Int32, Boolean> predicate) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x6000782")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

