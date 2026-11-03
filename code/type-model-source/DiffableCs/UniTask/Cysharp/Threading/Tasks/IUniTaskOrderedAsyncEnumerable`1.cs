namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000034")]
public interface IUniTaskOrderedAsyncEnumerable : IUniTaskAsyncEnumerable<TElement>
{

	[Token(Token = "0x6000114")]
	public IUniTaskOrderedAsyncEnumerable<TElement> CreateOrderedEnumerable(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }

	[Token(Token = "0x6000115")]
	public IUniTaskOrderedAsyncEnumerable<TElement> CreateOrderedEnumerable(Func<TElement, UniTask`1<TKey>> keySelector, IComparer<TKey> comparer, bool descending) { }

	[Token(Token = "0x6000116")]
	public IUniTaskOrderedAsyncEnumerable<TElement> CreateOrderedEnumerable(Func<TElement, CancellationToken, UniTask`1<TKey>> keySelector, IComparer<TKey> comparer, bool descending) { }

}

