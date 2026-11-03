namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200005B")]
internal sealed class BufferSkip : IUniTaskAsyncEnumerable<IList`1<TSource>>
{
	[Token(Token = "0x200005C")]
	private sealed class _BufferSkip : MoveNextSource, IUniTaskAsyncEnumerator<IList`1<TSource>>, IUniTaskAsyncDisposable
	{
		[Token(Token = "0x4000317")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000318")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000319")]
		private readonly int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400031A")]
		private readonly int skip; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400031B")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400031C")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400031D")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400031E")]
		private bool continueNext; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400031F")]
		private bool completed; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000320")]
		private Queue<List`1<TSource>> buffers; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000321")]
		private int index; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000322")]
		private IList<TSource> <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000007")]
		public private override IList<TSource> Current
		{
			[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x60002EE")]
			 get { } //Length: 8
			[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
			[CompilerGenerated]
			[Token(Token = "0x60002EF")]
			private set { } //Length: 16
		}

		[Address(RVA = "0x1552D00", Offset = "0x1552100", Length = "0xEA")]
		[Token(Token = "0x60002F4")]
		private static _BufferSkip() { }

		[Address(RVA = "0x1552DF0", Offset = "0x15521F0", Length = "0x65")]
		[Token(Token = "0x60002ED")]
		public _BufferSkip(IUniTaskAsyncEnumerable<TSource> source, int count, int skip, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1551DC0", Offset = "0x15511C0", Length = "0xDB")]
		[Token(Token = "0x60002F3")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60002EE")]
		public override IList<TSource> get_Current() { }

		[Address(RVA = "0x1551EA0", Offset = "0x15512A0", Length = "0x19C")]
		[Token(Token = "0x60002F0")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1552040", Offset = "0x1551440", Length = "0x89F")]
		[Token(Token = "0x60002F2")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x60002EF")]
		private void set_Current(IList<TSource> value) { }

		[Address(RVA = "0x15528E0", Offset = "0x1551CE0", Length = "0x41D")]
		[Token(Token = "0x60002F1")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000314")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000315")]
	private readonly int count; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000316")]
	private readonly int skip; //Field offset: 0x0

	[Address(RVA = "0x16B7820", Offset = "0x16B6C20", Length = "0x52")]
	[Token(Token = "0x60002EB")]
	public BufferSkip`1(IUniTaskAsyncEnumerable<TSource> source, int count, int skip) { }

	[Address(RVA = "0x16B7780", Offset = "0x16B6B80", Length = "0x9C")]
	[Token(Token = "0x60002EC")]
	public override IUniTaskAsyncEnumerator<IList`1<TSource>> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

