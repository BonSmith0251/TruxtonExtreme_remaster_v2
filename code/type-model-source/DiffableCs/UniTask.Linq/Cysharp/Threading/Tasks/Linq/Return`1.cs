namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200016A")]
internal class Return : IUniTaskAsyncEnumerable<TValue>
{
	[Token(Token = "0x200016B")]
	private class _Return : IUniTaskAsyncEnumerator<TValue>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EC4")]
		private readonly TValue value; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EC5")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000EC6")]
		private bool called; //Field offset: 0x0

		[Token(Token = "0x17000034")]
		public override TValue Current
		{
			[Address(RVA = "0x101BAF0", Offset = "0x101AEF0", Length = "0xA8")]
			[Token(Token = "0x60006D6")]
			 get { } //Length: 168
		}

		[Address(RVA = "0x1609CD0", Offset = "0x16090D0", Length = "0x14A")]
		[Token(Token = "0x60006D5")]
		public _Return(TValue value, CancellationToken cancellationToken) { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[Token(Token = "0x60006D8")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x101BAF0", Offset = "0x101AEF0", Length = "0xA8")]
		[Token(Token = "0x60006D6")]
		public override TValue get_Current() { }

		[Address(RVA = "0x1609B70", Offset = "0x1608F70", Length = "0x156")]
		[Token(Token = "0x60006D7")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EC3")]
	private readonly TValue value; //Field offset: 0x0

	[Address(RVA = "0xE9A4E0", Offset = "0xE998E0", Length = "0xC5")]
	[Token(Token = "0x60006D3")]
	public Return`1(TValue value) { }

	[Address(RVA = "0xF54340", Offset = "0xF53740", Length = "0x125")]
	[Token(Token = "0x60006D4")]
	public override IUniTaskAsyncEnumerator<TValue> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

