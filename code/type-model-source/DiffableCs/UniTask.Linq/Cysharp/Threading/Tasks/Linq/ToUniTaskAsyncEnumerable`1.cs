namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000206")]
internal class ToUniTaskAsyncEnumerable : IUniTaskAsyncEnumerable<T>
{
	[Token(Token = "0x2000207")]
	private class _ToUniTaskAsyncEnumerable : IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400137B")]
		private readonly IEnumerable<T> source; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400137C")]
		private CancellationToken cancellationToken; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400137D")]
		private IEnumerator<T> enumerator; //Field offset: 0x0

		[Token(Token = "0x1700004C")]
		public override T Current
		{
			[Address(RVA = "0x1621BD0", Offset = "0x1620FD0", Length = "0xB8")]
			[Token(Token = "0x60008D1")]
			 get { } //Length: 184
		}

		[Address(RVA = "0xF63F80", Offset = "0xF63380", Length = "0x4D")]
		[Token(Token = "0x60008D0")]
		public _ToUniTaskAsyncEnumerable(IEnumerable<T> source, CancellationToken cancellationToken) { }

		[Address(RVA = "0x1621A10", Offset = "0x1620E10", Length = "0x62")]
		[Token(Token = "0x60008D3")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1621BD0", Offset = "0x1620FD0", Length = "0xB8")]
		[Token(Token = "0x60008D1")]
		public override T get_Current() { }

		[Address(RVA = "0x1621A80", Offset = "0x1620E80", Length = "0x14B")]
		[Token(Token = "0x60008D2")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400137A")]
	private readonly IEnumerable<T> source; //Field offset: 0x0

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60008CE")]
	public ToUniTaskAsyncEnumerable`1(IEnumerable<T> source) { }

	[Address(RVA = "0xE12E80", Offset = "0xE12280", Length = "0x7F")]
	[Token(Token = "0x60008CF")]
	public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

