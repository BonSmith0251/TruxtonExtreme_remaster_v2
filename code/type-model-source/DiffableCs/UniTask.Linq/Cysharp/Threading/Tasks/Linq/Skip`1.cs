namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200018B")]
internal sealed class Skip : IUniTaskAsyncEnumerable<TSource>
{
	[Token(Token = "0x200018C")]
	private sealed class _Skip : AsyncEnumeratorBase<TSource, TSource>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FAE")]
		private readonly int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000FAF")]
		private int index; //Field offset: 0x0

		[Address(RVA = "0x161ACD0", Offset = "0x161A0D0", Length = "0xD2")]
		[Token(Token = "0x6000757")]
		public _Skip(IUniTaskAsyncEnumerable<TSource> source, int count, CancellationToken cancellationToken) { }

		[Address(RVA = "0x161AB30", Offset = "0x1619F30", Length = "0x197")]
		[Token(Token = "0x6000758")]
		protected virtual bool TryMoveNextCore(bool sourceHasCurrent, out bool result) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FAC")]
	private readonly IUniTaskAsyncEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000FAD")]
	private readonly int count; //Field offset: 0x0

	[Address(RVA = "0xF63E90", Offset = "0xF63290", Length = "0x42")]
	[Token(Token = "0x6000755")]
	public Skip`1(IUniTaskAsyncEnumerable<TSource> source, int count) { }

	[Address(RVA = "0xF63DF0", Offset = "0xF631F0", Length = "0x97")]
	[Token(Token = "0x6000756")]
	public override IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

