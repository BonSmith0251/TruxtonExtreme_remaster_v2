namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001D4")]
internal sealed class TakeLast : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20001D5")]
	private sealed class _TakeLast : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[Token(Token = "0x400121E")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400121F")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001220")]
		private readonly int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001221")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001222")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001223")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001224")]
		private Queue<TSource> queue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001225")]
		private bool iterateCompleted; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001226")]
		private bool continueNext; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001227")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000044")]
		public private override TSource Current
		{
			[Address(RVA = "0x119FAA0", Offset = "0x119EEA0", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x6000838")]
			 get { } //Length: 176
			[Address(RVA = "0x119FB60", Offset = "0x119EF60", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x6000839")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x161BE60", Offset = "0x161B260", Length = "0xEA")]
		[Token(Token = "0x600083E")]
		private static _TakeLast() { }

		[Address(RVA = "0x1616DB0", Offset = "0x16161B0", Length = "0x10E")]
		[Token(Token = "0x6000837")]
		public _TakeLast(IUniTaskAsyncEnumerable<TSource> source, int count, CancellationToken cancellationToken) { }

		[Address(RVA = "0x161ADB0", Offset = "0x161A1B0", Length = "0x11B")]
		[Token(Token = "0x600083D")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x119FAA0", Offset = "0x119EEA0", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x6000838")]
		public override TSource get_Current() { }

		[Address(RVA = "0x161AED0", Offset = "0x161A2D0", Length = "0x29D")]
		[Token(Token = "0x600083A")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x161B170", Offset = "0x161A570", Length = "0x702")]
		[Token(Token = "0x600083C")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x119FB60", Offset = "0x119EF60", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x6000839")]
		private void set_Current(TSource value) { }

		[Address(RVA = "0x161B880", Offset = "0x161AC80", Length = "0x5D1")]
		[Token(Token = "0x600083B")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400121C")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400121D")]
	private readonly int count; //Field offset: 0x0

	[Address(RVA = "0xF63E90", Offset = "0xF63290", Length = "0x42")]
	[Token(Token = "0x6000835")]
	public TakeLast`1(IUniTaskAsyncEnumerable<TSource> source, int count) { }

	[Address(RVA = "0xF63DF0", Offset = "0xF631F0", Length = "0x97")]
	[Token(Token = "0x6000836")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

