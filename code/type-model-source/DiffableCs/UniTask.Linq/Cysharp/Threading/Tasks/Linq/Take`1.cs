namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001D2")]
internal sealed class Take : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x20001D3")]
	private sealed class _Take : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[Token(Token = "0x4001214")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001215")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001216")]
		private readonly int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001217")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001218")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001219")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400121A")]
		private int index; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400121B")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x17000043")]
		public private override TSource Current
		{
			[Address(RVA = "0x100A1F0", Offset = "0x10095F0", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x600082E")]
			 get { } //Length: 176
			[Address(RVA = "0x100A360", Offset = "0x1009760", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x600082F")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x161FE40", Offset = "0x161F240", Length = "0xEA")]
		[Token(Token = "0x6000834")]
		private static _Take() { }

		[Address(RVA = "0x1616DB0", Offset = "0x16161B0", Length = "0x10E")]
		[Token(Token = "0x600082D")]
		public _Take(IUniTaskAsyncEnumerable<TSource> source, int count, CancellationToken cancellationToken) { }

		[Address(RVA = "0x161F3F0", Offset = "0x161E7F0", Length = "0x11B")]
		[Token(Token = "0x6000833")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x100A1F0", Offset = "0x10095F0", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x600082E")]
		public override TSource get_Current() { }

		[Address(RVA = "0x161F510", Offset = "0x161E910", Length = "0x298")]
		[Token(Token = "0x6000830")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x161F7B0", Offset = "0x161EBB0", Length = "0x329")]
		[Token(Token = "0x6000832")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x100A360", Offset = "0x1009760", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x600082F")]
		private void set_Current(TSource value) { }

		[Address(RVA = "0x161FAE0", Offset = "0x161EEE0", Length = "0x351")]
		[Token(Token = "0x6000831")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001212")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001213")]
	private readonly int count; //Field offset: 0x0

	[Address(RVA = "0xF63E90", Offset = "0xF63290", Length = "0x42")]
	[Token(Token = "0x600082B")]
	public Take`1(IUniTaskAsyncEnumerable<TSource> source, int count) { }

	[Address(RVA = "0xF63DF0", Offset = "0xF631F0", Length = "0x97")]
	[Token(Token = "0x600082C")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

