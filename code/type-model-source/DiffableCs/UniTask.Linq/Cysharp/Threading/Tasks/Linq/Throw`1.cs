namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20001E7")]
internal class Throw : IUniTaskAsyncEnumerable<TValue>
{
	[Token(Token = "0x20001E8")]
	private class _Throw : IUniTaskAsyncEnumerator<TValue>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400125E")]
		private readonly Exception exception; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400125F")]
		private CancellationToken cancellationToken; //Field offset: 0x0

		[Token(Token = "0x17000047")]
		public override TValue Current
		{
			[Address(RVA = "0x1606F70", Offset = "0x1606370", Length = "0xC2")]
			[Token(Token = "0x6000878")]
			 get { } //Length: 194
		}

		[Address(RVA = "0xF63F80", Offset = "0xF63380", Length = "0x4D")]
		[Token(Token = "0x6000877")]
		public _Throw(Exception exception, CancellationToken cancellationToken) { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[Token(Token = "0x600087A")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1606F70", Offset = "0x1606370", Length = "0xC2")]
		[Token(Token = "0x6000878")]
		public override TValue get_Current() { }

		[Address(RVA = "0x161FF30", Offset = "0x161F330", Length = "0xA7")]
		[Token(Token = "0x6000879")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400125D")]
	private readonly Exception exception; //Field offset: 0x0

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000875")]
	public Throw`1(Exception exception) { }

	[Address(RVA = "0xE10880", Offset = "0xE0FC80", Length = "0x7F")]
	[Token(Token = "0x6000876")]
	public override IUniTaskAsyncEnumerator<TValue> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

