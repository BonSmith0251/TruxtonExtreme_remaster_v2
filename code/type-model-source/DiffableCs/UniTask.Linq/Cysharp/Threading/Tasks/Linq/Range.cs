namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000166")]
internal class Range : IUniTaskAsyncEnumerable<Int32>
{
	[Token(Token = "0x2000167")]
	private class _Range : IUniTaskAsyncEnumerator<Int32>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000EB9")]
		private readonly int start; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000EBA")]
		private readonly int end; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000EBB")]
		private int current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000EBC")]
		private CancellationToken cancellationToken; //Field offset: 0x20

		[Token(Token = "0x17000032")]
		public override int Current
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[Token(Token = "0x60006CA")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x276C430", Offset = "0x276B830", Length = "0x56")]
		[Token(Token = "0x60006C9")]
		public _Range(int start, int end, CancellationToken cancellationToken) { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[Token(Token = "0x60006CC")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60006CA")]
		public override int get_Current() { }

		[Address(RVA = "0x276C350", Offset = "0x276B750", Length = "0xD4")]
		[Token(Token = "0x60006CB")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EB7")]
	private readonly int start; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000EB8")]
	private readonly int end; //Field offset: 0x14

	[Address(RVA = "0x27535D0", Offset = "0x27529D0", Length = "0x37")]
	[Token(Token = "0x60006C7")]
	public Range(int start, int count) { }

	[Address(RVA = "0x2753540", Offset = "0x2752940", Length = "0x88")]
	[Token(Token = "0x60006C8")]
	public override IUniTaskAsyncEnumerator<Int32> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

