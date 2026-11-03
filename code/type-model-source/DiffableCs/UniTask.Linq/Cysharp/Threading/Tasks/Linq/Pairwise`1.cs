namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200015C")]
internal sealed class Pairwise : IUniTaskAsyncEnumerable<ValueTuple`2<TSource, TSource>>
{
	[Token(Token = "0x200015D")]
	private sealed class _Pairwise : MoveNextSource, IUniTaskAsyncEnumerator<ValueTuple`2<TSource, TSource>>, IUniTaskAsyncDisposable
	{
		[Token(Token = "0x4000E85")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E86")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E87")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E88")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E89")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E8A")]
		private TSource prev; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E8B")]
		private bool isFirst; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E8C")]
		private ValueTuple<TSource, TSource> <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700002D")]
		public private override ValueTuple<TSource, TSource> Current
		{
			[Address(RVA = "0x100A1F0", Offset = "0x10095F0", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x600069E")]
			 get { } //Length: 176
			[Address(RVA = "0x1608750", Offset = "0x1607B50", Length = "0xA5")]
			[CompilerGenerated]
			[Token(Token = "0x600069F")]
			private set { } //Length: 165
		}

		[Address(RVA = "0x1608660", Offset = "0x1607A60", Length = "0xEA")]
		[Token(Token = "0x60006A4")]
		private static _Pairwise() { }

		[Address(RVA = "0x100B020", Offset = "0x100A420", Length = "0xCB")]
		[Token(Token = "0x600069D")]
		public _Pairwise(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken) { }

		[Address(RVA = "0x16078C0", Offset = "0x1606CC0", Length = "0x11B")]
		[Token(Token = "0x60006A3")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x100A1F0", Offset = "0x10095F0", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x600069E")]
		public override ValueTuple<TSource, TSource> get_Current() { }

		[Address(RVA = "0x16079E0", Offset = "0x1606DE0", Length = "0x251")]
		[Token(Token = "0x60006A0")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1607C40", Offset = "0x1607040", Length = "0x6C5")]
		[Token(Token = "0x60006A2")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x1608750", Offset = "0x1607B50", Length = "0xA5")]
		[CompilerGenerated]
		[Token(Token = "0x600069F")]
		private void set_Current(ValueTuple<TSource, TSource> value) { }

		[Address(RVA = "0x1608310", Offset = "0x1607710", Length = "0x34B")]
		[Token(Token = "0x60006A1")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E84")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x600069B")]
	public Pairwise`1(IUniTaskAsyncEnumerable<TSource> source) { }

	[Address(RVA = "0xE12E80", Offset = "0xE12280", Length = "0x7F")]
	[Token(Token = "0x600069C")]
	public override IUniTaskAsyncEnumerator<ValueTuple`2<TSource, TSource>> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

