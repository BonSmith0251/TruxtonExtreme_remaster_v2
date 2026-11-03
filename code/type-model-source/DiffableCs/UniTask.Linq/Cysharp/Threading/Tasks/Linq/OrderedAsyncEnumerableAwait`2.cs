namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200015A")]
internal class OrderedAsyncEnumerableAwait : OrderedAsyncEnumerable<TElement>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E7C")]
	private readonly Func<TElement, UniTask`1<TKey>> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E7D")]
	private readonly IComparer<TKey> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E7E")]
	private readonly bool descending; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E7F")]
	private readonly OrderedAsyncEnumerable<TElement> parent; //Field offset: 0x0

	[Address(RVA = "0xE11F30", Offset = "0xE11330", Length = "0x7A")]
	[Token(Token = "0x6000697")]
	public OrderedAsyncEnumerableAwait`2(IUniTaskAsyncEnumerable<TElement> source, Func<TElement, UniTask`1<TKey>> keySelector, IComparer<TKey> comparer, bool descending, OrderedAsyncEnumerable<TElement> parent) { }

	[Address(RVA = "0xE11FB0", Offset = "0xE113B0", Length = "0xD2")]
	[Token(Token = "0x6000698")]
	internal virtual AsyncEnumerableSorter<TElement> GetAsyncEnumerableSorter(AsyncEnumerableSorter<TElement> next, CancellationToken cancellationToken) { }

}

