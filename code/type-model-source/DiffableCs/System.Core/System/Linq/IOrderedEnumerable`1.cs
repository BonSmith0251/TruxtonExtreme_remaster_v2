namespace System.Linq;

[Token(Token = "0x2000031")]
public interface IOrderedEnumerable : IEnumerable<TElement>, IEnumerable
{

	[Token(Token = "0x600013E")]
	public IOrderedEnumerable<TElement> CreateOrderedEnumerable(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }

}

