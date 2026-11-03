namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000168")]
internal class Repeat : IUniTaskAsyncEnumerable<TElement>
{
	[Token(Token = "0x2000169")]
	private class _Repeat : IUniTaskAsyncEnumerator<TElement>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EBF")]
		private readonly TElement element; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EC0")]
		private readonly int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EC1")]
		private int remaining; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EC2")]
		private CancellationToken cancellationToken; //Field offset: 0x0

		[Token(Token = "0x17000033")]
		public override TElement Current
		{
			[Address(RVA = "0x101BAF0", Offset = "0x101AEF0", Length = "0xA8")]
			[Token(Token = "0x60006D0")]
			 get { } //Length: 168
		}

		[Address(RVA = "0x16099D0", Offset = "0x1608DD0", Length = "0x19A")]
		[Token(Token = "0x60006CF")]
		public _Repeat(TElement element, int count, CancellationToken cancellationToken) { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[Token(Token = "0x60006D2")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x101BAF0", Offset = "0x101AEF0", Length = "0xA8")]
		[Token(Token = "0x60006D0")]
		public override TElement get_Current() { }

		[Address(RVA = "0x1609870", Offset = "0x1608C70", Length = "0x15B")]
		[Token(Token = "0x60006D1")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EBD")]
	private readonly TElement element; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EBE")]
	private readonly int count; //Field offset: 0x0

	[Address(RVA = "0xF52DC0", Offset = "0xF521C0", Length = "0x108")]
	[Token(Token = "0x60006CD")]
	public Repeat`1(TElement element, int count) { }

	[Address(RVA = "0xF52C60", Offset = "0xF52060", Length = "0x154")]
	[Token(Token = "0x60006CE")]
	public override IUniTaskAsyncEnumerator<TElement> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

