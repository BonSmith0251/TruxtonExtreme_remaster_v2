namespace Cysharp.Threading.Tasks;

[IsReadOnly]
[Token(Token = "0x2000037")]
public struct UniTaskCancelableAsyncEnumerable
{
	[IsReadOnly]
	[Token(Token = "0x2000038")]
	internal struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000096")]
		private readonly IUniTaskAsyncEnumerator<T> enumerator; //Field offset: 0x0

		[Token(Token = "0x17000024")]
		public T Current
		{
			[Address(RVA = "0x19A8140", Offset = "0x19A7540", Length = "0x156")]
			[Token(Token = "0x600011C")]
			 get { } //Length: 342
		}

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x600011B")]
		internal Enumerator(IUniTaskAsyncEnumerator<T> enumerator) { }

		[Address(RVA = "0x199B990", Offset = "0x199AD90", Length = "0xC7")]
		[Token(Token = "0x600011E")]
		public UniTask DisposeAsync() { }

		[Address(RVA = "0x19A8140", Offset = "0x19A7540", Length = "0x156")]
		[Token(Token = "0x600011C")]
		public T get_Current() { }

		[Address(RVA = "0x199CED0", Offset = "0x199C2D0", Length = "0xDC")]
		[Token(Token = "0x600011D")]
		public UniTask<Boolean> MoveNextAsync() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000094")]
	private readonly IUniTaskAsyncEnumerable<T> enumerable; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000095")]
	private readonly CancellationToken cancellationToken; //Field offset: 0x0

	[Address(RVA = "0x11194D0", Offset = "0x11188D0", Length = "0x31")]
	[Token(Token = "0x6000119")]
	internal UniTaskCancelableAsyncEnumerable`1(IUniTaskAsyncEnumerable<T> enumerable, CancellationToken cancellationToken) { }

	[Address(RVA = "0x11193B0", Offset = "0x11187B0", Length = "0x115")]
	[Token(Token = "0x600011A")]
	public Enumerator<T> GetAsyncEnumerator() { }

}

