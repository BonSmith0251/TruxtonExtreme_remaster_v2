namespace Cysharp.Threading.Tasks.Linq;

[Token(Token = "0x2000159")]
internal class OrderedAsyncEnumerable : OrderedAsyncEnumerable<TElement>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E78")]
	private readonly Func<TElement, TKey> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E79")]
	private readonly IComparer<TKey> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E7A")]
	private readonly bool descending; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000E7B")]
	private readonly OrderedAsyncEnumerable<TElement> parent; //Field offset: 0x0

	[Address(RVA = "0xE11F30", Offset = "0xE11330", Length = "0x7A")]
	[Token(Token = "0x6000695")]
	public OrderedAsyncEnumerable`2(IUniTaskAsyncEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, OrderedAsyncEnumerable<TElement> parent) { }

	[Address(RVA = "0xE11FB0", Offset = "0xE113B0", Length = "0xD2")]
	[Token(Token = "0x6000696")]
	internal virtual AsyncEnumerableSorter<TElement> GetAsyncEnumerableSorter(AsyncEnumerableSorter<TElement> next, CancellationToken cancellationToken) { }

}

