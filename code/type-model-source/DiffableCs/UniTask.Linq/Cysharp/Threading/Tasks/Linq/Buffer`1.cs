namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000059")]
internal sealed class Buffer : IUniTaskAsyncEnumerable<IList`1<TSource>>
{
	[Token(Token = "0x200005A")]
	private sealed class _Buffer : MoveNextSource, IUniTaskAsyncEnumerator<IList`1<TSource>>, IUniTaskAsyncDisposable
	{
		[Token(Token = "0x400030A")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400030B")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400030C")]
		private readonly int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400030D")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400030E")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400030F")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000310")]
		private bool continueNext; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000311")]
		private bool completed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000312")]
		private List<TSource> buffer; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000313")]
		private IList<TSource> <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000006")]
		public private override IList<TSource> Current
		{
			[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60002E4")]
			 get { } //Length: 5
			[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60002E5")]
			private set { } //Length: 13
		}

		[Address(RVA = "0x15538C0", Offset = "0x1552CC0", Length = "0xEA")]
		[Token(Token = "0x60002EA")]
		private static _Buffer() { }

		[Address(RVA = "0x15539B0", Offset = "0x1552DB0", Length = "0x5D")]
		[Token(Token = "0x60002E3")]
		public _Buffer(IUniTaskAsyncEnumerable<TSource> source, int count, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1552E60", Offset = "0x1552260", Length = "0xDB")]
		[Token(Token = "0x60002E9")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60002E4")]
		public override IList<TSource> get_Current() { }

		[Address(RVA = "0x1552F40", Offset = "0x1552340", Length = "0x1A3")]
		[Token(Token = "0x60002E6")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x15530F0", Offset = "0x15524F0", Length = "0x3EA")]
		[Token(Token = "0x60002E8")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60002E5")]
		private void set_Current(IList<TSource> value) { }

		[Address(RVA = "0x15534E0", Offset = "0x15528E0", Length = "0x3D2")]
		[Token(Token = "0x60002E7")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000308")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000309")]
	private readonly int count; //Field offset: 0x0

	[Address(RVA = "0xF63E90", Offset = "0xF63290", Length = "0x42")]
	[Token(Token = "0x60002E1")]
	public Buffer`1(IUniTaskAsyncEnumerable<TSource> source, int count) { }

	[Address(RVA = "0xF63DF0", Offset = "0xF631F0", Length = "0x97")]
	[Token(Token = "0x60002E2")]
	public override IUniTaskAsyncEnumerator<IList`1<TSource>> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

