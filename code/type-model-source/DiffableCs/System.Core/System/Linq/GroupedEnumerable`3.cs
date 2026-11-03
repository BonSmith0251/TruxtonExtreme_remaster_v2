namespace System.Linq;

[Token(Token = "0x200003A")]
internal class GroupedEnumerable : IEnumerable<IGrouping`2<TKey, TElement>>, IEnumerable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000AB")]
	private IEnumerable<TSource> source; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000AC")]
	private Func<TSource, TKey> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000AD")]
	private Func<TSource, TElement> elementSelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000AE")]
	private IEqualityComparer<TKey> comparer; //Field offset: 0x0

	[Address(RVA = "0x1C40CF0", Offset = "0x1C400F0", Length = "0xFB")]
	[Token(Token = "0x600016B")]
	public GroupedEnumerable`3(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x1C40C00", Offset = "0x1C40000", Length = "0x58")]
	[Token(Token = "0x600016C")]
	public override IEnumerator<IGrouping`2<TKey, TElement>> GetEnumerator() { }

	[Address(RVA = "0x1C40C80", Offset = "0x1C40080", Length = "0x64")]
	[Token(Token = "0x600016D")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

