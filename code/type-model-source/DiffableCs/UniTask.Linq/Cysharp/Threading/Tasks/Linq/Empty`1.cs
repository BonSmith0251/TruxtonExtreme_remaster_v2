namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x20000B0")]
internal class Empty : IUniTaskAsyncEnumerable<T>
{
	[Token(Token = "0x20000B1")]
	private class _Empty : IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable
	{
		[Token(Token = "0x400083C")]
		public static readonly IUniTaskAsyncEnumerator<T> Instance; //Field offset: 0x0

		[Token(Token = "0x1700001E")]
		public override T Current
		{
			[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
			[Token(Token = "0x6000479")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x15F7D50", Offset = "0x15F7150", Length = "0xEA")]
		[Token(Token = "0x600047C")]
		private static _Empty() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000478")]
		private _Empty() { }

		[Address(RVA = "0xA53C30", Offset = "0xA53030", Length = "0xA")]
		[Token(Token = "0x600047B")]
		public override UniTask DisposeAsync() { }

		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000479")]
		public override T get_Current() { }

		[Address(RVA = "0x15F7BD0", Offset = "0x15F6FD0", Length = "0x5B")]
		[Token(Token = "0x600047A")]
		public override UniTask<Boolean> MoveNextAsync() { }

	}

	[Token(Token = "0x400083B")]
	public static readonly IUniTaskAsyncEnumerable<T> Instance; //Field offset: 0x0

	[Address(RVA = "0x19521B0", Offset = "0x19515B0", Length = "0xEA")]
	[Token(Token = "0x6000477")]
	private static Empty`1() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000475")]
	private Empty`1() { }

	[Address(RVA = "0x1952130", Offset = "0x1951530", Length = "0x77")]
	[Token(Token = "0x6000476")]
	public override IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = null) { }

}

