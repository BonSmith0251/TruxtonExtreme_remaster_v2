namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200009E")]
internal sealed class Distinct : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x200009F")]
	private class _Distinct : AsyncEnumeratorBase<TSource, TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007E0")]
		private readonly HashSet<TKey> set; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007E1")]
		private readonly Func<TSource, TKey> keySelector; //Field offset: 0x0

		[Address(RVA = "0x15F0FA0", Offset = "0x15F03A0", Length = "0x159")]
		[Token(Token = "0x600043B")]
		public _Distinct(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F6750", Offset = "0x15F5B50", Length = "0x2B3")]
		[Token(Token = "0x600043C")]
		protected virtual bool TryMoveNextCore(bool sourceHasCurrent, out bool result) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007DD")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007DE")]
	private readonly Func<TSource, TKey> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007DF")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x6000439")]
	public Distinct`2(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x1550FD0", Offset = "0x15503D0", Length = "0x9C")]
	[Token(Token = "0x600043A")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

