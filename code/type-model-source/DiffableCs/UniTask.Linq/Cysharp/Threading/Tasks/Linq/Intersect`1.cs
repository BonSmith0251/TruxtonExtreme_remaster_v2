namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000DB")]
internal sealed class Intersect : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20000DC")]
	private class _Intersect : AsyncEnumeratorBase<TSource, TSource>
	{
		[Token(Token = "0x4000968")]
		private static Action<Object> HashSetAsyncCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000969")]
		private readonly IEqualityComparer<TSource> comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400096A")]
		private readonly IUniTaskAsyncEnumerable<TSource> second; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400096B")]
		private HashSet<TSource> set; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400096C")]
		private Awaiter<HashSet<TSource>> awaiter; //Field offset: 0x0

		[Address(RVA = "0x1601990", Offset = "0x1600D90", Length = "0xF3")]
		[Token(Token = "0x6000519")]
		private static _Intersect() { }

		[Address(RVA = "0x15F9ED0", Offset = "0x15F92D0", Length = "0x119")]
		[Token(Token = "0x6000515")]
		public _Intersect(IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken) { }

		[Address(RVA = "0x15F9620", Offset = "0x15F8A20", Length = "0x240")]
		[Token(Token = "0x6000517")]
		private static void HashSetAsyncCore(object state) { }

		[Address(RVA = "0x15F9870", Offset = "0x15F8C70", Length = "0x339")]
		[Token(Token = "0x6000516")]
		protected virtual bool OnFirstIteration() { }

		[Address(RVA = "0x15F9BB0", Offset = "0x15F8FB0", Length = "0x212")]
		[Token(Token = "0x6000518")]
		protected virtual bool TryMoveNextCore(bool sourceHasCurrent, out bool result) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000965")]
	private readonly IUniTaskAsyncEnumerable<TSource> first; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000966")]
	private readonly IUniTaskAsyncEnumerable<TSource> second; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000967")]
	private readonly IEqualityComparer<TSource> comparer; //Field offset: 0x0

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x6000513")]
	public Intersect`1(IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }

	[Address(RVA = "0xA96D70", Offset = "0xA96170", Length = "0x9C")]
	[Token(Token = "0x6000514")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

