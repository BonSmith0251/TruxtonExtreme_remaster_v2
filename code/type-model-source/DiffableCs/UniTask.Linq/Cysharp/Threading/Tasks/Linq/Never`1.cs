namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200014A")]
internal class Never : IUniTaskAsyncEnumerable<T>
{
	[Token(Token = "0x200014B")]
	private class _Never : IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E3A")]
		private CancellationToken cancellationToken; //Field offset: 0x0

		[Token(Token = "0x1700002B")]
		public override T Current
		{
			[Address(RVA = "0x1606F70", Offset = "0x1606370", Length = "0xC2")]
			[Token(Token = "0x6000669")]
			 get { } //Length: 194
		}

		[Address(RVA = "0x1606F40", Offset = "0x1606340", Length = "0x30")]
		[Token(Token = "0x6000668")]
		public _Never(CancellationToken cancellationToken) { }

		[Address(RVA = "0x1606EA0", Offset = "0x16062A0", Length = "0x93")]
		[CompilerGenerated]
		[Token(Token = "0x600066C")]
		private void <MoveNextAsync>b__4_0(object state) { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[Token(Token = "0x600066B")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x1606F70", Offset = "0x1606370", Length = "0xC2")]
		[Token(Token = "0x6000669")]
		public override T get_Current() { }

		[Address(RVA = "0x1606D70", Offset = "0x1606170", Length = "0x12F")]
		[Token(Token = "0x600066A")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[Token(Token = "0x4000E39")]
	public static readonly IUniTaskAsyncEnumerable<T> Instance; //Field offset: 0x0

	[Address(RVA = "0xD984A0", Offset = "0xD978A0", Length = "0x120")]
	[Token(Token = "0x6000667")]
	private static Never`1() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000665")]
	private Never`1() { }

	[Address(RVA = "0xD98430", Offset = "0xD97830", Length = "0x6D")]
	[Token(Token = "0x6000666")]
	public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

