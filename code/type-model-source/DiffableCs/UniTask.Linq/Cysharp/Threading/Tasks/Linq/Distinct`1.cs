namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200009C")]
internal sealed class Distinct : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x200009D")]
	private class _Distinct : AsyncEnumeratorBase<TSource, TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007DC")]
		private readonly HashSet<TSource> set; //Field offset: 0x0

		[Address(RVA = "0x15F6A10", Offset = "0x15F5E10", Length = "0x119")]
		[Token(Token = "0x6000437")]
		public _Distinct(IUniTaskAsyncEnumerable<TSource> source, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F6550", Offset = "0x15F5950", Length = "0x1FC")]
		[Token(Token = "0x6000438")]
		protected virtual bool TryMoveNextCore(bool sourceHasCurrent, out bool result) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007DA")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007DB")]
	private readonly IEqualityComparer<TSource> comparer; //Field offset: 0x0

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000435")]
	public Distinct`1(IUniTaskAsyncEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }

	[Address(RVA = "0xF59060", Offset = "0xF58460", Length = "0x97")]
	[Token(Token = "0x6000436")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

