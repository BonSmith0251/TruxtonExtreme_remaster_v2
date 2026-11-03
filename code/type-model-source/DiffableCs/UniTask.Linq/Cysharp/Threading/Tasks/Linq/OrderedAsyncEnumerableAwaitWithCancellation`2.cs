namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x200015B")]
internal class OrderedAsyncEnumerableAwaitWithCancellation : OrderedAsyncEnumerable<TElement>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E80")]
	private readonly Func<TElement, CancellationToken, UniTask`1<TKey>> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E81")]
	private readonly IComparer<TKey> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E82")]
	private readonly bool descending; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E83")]
	private readonly OrderedAsyncEnumerable<TElement> parent; //Field offset: 0x0

	[Address(RVA = "0xE11F30", Offset = "0xE11330", Length = "0x7A")]
	[Token(Token = "0x6000699")]
	public OrderedAsyncEnumerableAwaitWithCancellation`2(IUniTaskAsyncEnumerable<TElement> source, Func<TElement, CancellationToken, UniTask`1<TKey>> keySelector, IComparer<TKey> comparer, bool descending, OrderedAsyncEnumerable<TElement> parent) { }

	[Address(RVA = "0xE11E50", Offset = "0xE11250", Length = "0xDA")]
	[Token(Token = "0x600069A")]
	internal virtual AsyncEnumerableSorter<TElement> GetAsyncEnumerableSorter(AsyncEnumerableSorter<TElement> next, CancellationToken cancellationToken) { }

}

