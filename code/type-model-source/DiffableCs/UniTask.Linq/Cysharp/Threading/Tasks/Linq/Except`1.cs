namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000B2")]
internal sealed class Except : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20000B3")]
	private class _Except : AsyncEnumeratorBase<TSource, TSource>
	{
		[Token(Token = "0x4000840")]
		private static Action<Object> HashSetAsyncCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000841")]
		private readonly IEqualityComparer<TSource> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000842")]
		private readonly IUniTaskAsyncEnumerable<TSource> second; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000843")]
		private HashSet<TSource> set; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000844")]
		private Awaiter<HashSet<TSource>> awaiter; //Field offset: 0x0

		[Address(RVA = "0x15F9DD0", Offset = "0x15F91D0", Length = "0xF3")]
		[Token(Token = "0x6000483")]
		private static _Except() { }

		[Address(RVA = "0x15F9ED0", Offset = "0x15F92D0", Length = "0x119")]
		[Token(Token = "0x600047F")]
		public _Except(IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F9620", Offset = "0x15F8A20", Length = "0x240")]
		[Token(Token = "0x6000481")]
		private static void HashSetAsyncCore(object state) { }

		[Address(RVA = "0x15F9870", Offset = "0x15F8C70", Length = "0x339")]
		[Token(Token = "0x6000480")]
		protected virtual bool OnFirstIteration() { }

		[Address(RVA = "0x15F9BB0", Offset = "0x15F8FB0", Length = "0x212")]
		[Token(Token = "0x6000482")]
		protected virtual bool TryMoveNextCore(bool sourceHasCurrent, out bool result) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400083D")]
	private readonly IUniTaskAsyncEnumerable<TSource> first; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400083E")]
	private readonly IUniTaskAsyncEnumerable<TSource> second; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400083F")]
	private readonly IEqualityComparer<TSource> comparer; //Field offset: 0x0

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x600047D")]
	public Except`1(IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }

	[Address(RVA = "0xA96D70", Offset = "0xA96170", Length = "0x9C")]
	[Token(Token = "0x600047E")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

