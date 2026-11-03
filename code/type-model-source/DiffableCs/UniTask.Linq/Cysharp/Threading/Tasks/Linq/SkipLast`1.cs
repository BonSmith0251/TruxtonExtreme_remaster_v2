namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200018D")]
internal sealed class SkipLast : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x200018E")]
	private sealed class _SkipLast : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
	{
		[Token(Token = "0x4000FB2")]
		private static readonly Action<Object> MoveNextCoreDelegate; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FB3")]
		private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FB4")]
		private readonly int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FB5")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FB6")]
		private IUniTaskAsyncEnumerator<TSource> enumerator; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FB7")]
		private Awaiter<Boolean> awaiter; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FB8")]
		private Queue<TSource> queue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FB9")]
		private bool continueNext; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FBA")]
		private TSource <Current>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x1700003F")]
		public private override TSource Current
		{
			[Address(RVA = "0x1616EC0", Offset = "0x16162C0", Length = "0xB0")]
			[CompilerGenerated]
			[Token(Token = "0x600075C")]
			 get { } //Length: 176
			[Address(RVA = "0x1616F70", Offset = "0x1616370", Length = "0xBD")]
			[CompilerGenerated]
			[Token(Token = "0x600075D")]
			private set { } //Length: 189
		}

		[Address(RVA = "0x1616CC0", Offset = "0x16160C0", Length = "0xEA")]
		[Token(Token = "0x6000762")]
		private static _SkipLast() { }

		[Address(RVA = "0x1616DB0", Offset = "0x16161B0", Length = "0x10E")]
		[Token(Token = "0x600075B")]
		public _SkipLast(IUniTaskAsyncEnumerable<TSource> source, int count, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1615C20", Offset = "0x1615020", Length = "0x11B")]
		[Token(Token = "0x6000761")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1616EC0", Offset = "0x16162C0", Length = "0xB0")]
		[CompilerGenerated]
		[Token(Token = "0x600075C")]
		public override TSource get_Current() { }

		[Address(RVA = "0x1615D40", Offset = "0x1615140", Length = "0x29D")]
		[Token(Token = "0x600075E")]
		public override UniTask<Boolean> MoveNextAsync() { }

		[Address(RVA = "0x1615FE0", Offset = "0x16153E0", Length = "0x829")]
		[Token(Token = "0x6000760")]
		private static void MoveNextCore(object state) { }

		[Address(RVA = "0x1616F70", Offset = "0x1616370", Length = "0xBD")]
		[CompilerGenerated]
		[Token(Token = "0x600075D")]
		private void set_Current(TSource value) { }

		[Address(RVA = "0x1616810", Offset = "0x1615C10", Length = "0x4A1")]
		[Token(Token = "0x600075F")]
		private void SourceMoveNext() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FB0")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FB1")]
	private readonly int count; //Field offset: 0x0

	[Address(RVA = "0xF63E90", Offset = "0xF63290", Length = "0x42")]
	[Token(Token = "0x6000759")]
	public SkipLast`1(IUniTaskAsyncEnumerable<TSource> source, int count) { }

	[Address(RVA = "0xF63DF0", Offset = "0xF631F0", Length = "0x97")]
	[Token(Token = "0x600075A")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

