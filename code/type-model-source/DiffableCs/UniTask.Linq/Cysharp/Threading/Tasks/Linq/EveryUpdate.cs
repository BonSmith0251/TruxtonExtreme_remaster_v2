namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000210")]
internal class EveryUpdate : IUniTaskAsyncEnumerable<AsyncUnit>
{
	[Token(Token = "0x2000211")]
	private class _EveryUpdate : MoveNextSource, IUniTaskAsyncEnumerator<AsyncUnit>, IUniTaskAsyncDisposable, IPlayerLoopItem
	{
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400139C")]
		private readonly PlayerLoopTiming updateTiming; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400139D")]
		private CancellationToken cancellationToken; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400139E")]
		private bool disposed; //Field offset: 0x48

		[Token(Token = "0x17000050")]
		public override AsyncUnit Current
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60008F2")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x276DCB0", Offset = "0x276D0B0", Length = "0x80")]
		[Token(Token = "0x60008F1")]
		public _EveryUpdate(PlayerLoopTiming updateTiming, CancellationToken cancellationToken) { }

		[Address(RVA = "0x276DAF0", Offset = "0x276CEF0", Length = "0x14")]
		[Token(Token = "0x60008F4")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60008F2")]
		public override AsyncUnit get_Current() { }

		[Address(RVA = "0x276DC20", Offset = "0x276D020", Length = "0x8F")]
		[Token(Token = "0x60008F5")]
		public override bool MoveNext() { }

		[Address(RVA = "0x276DB10", Offset = "0x276CF10", Length = "0x10C")]
		[Token(Token = "0x60008F3")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400139B")]
	private readonly PlayerLoopTiming updateTiming; //Field offset: 0x10

	[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
	[Token(Token = "0x60008EF")]
	public EveryUpdate(PlayerLoopTiming updateTiming) { }

	[Address(RVA = "0x276C490", Offset = "0x276B890", Length = "0xB0")]
	[Token(Token = "0x60008F0")]
	public override IUniTaskAsyncEnumerator<AsyncUnit> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

