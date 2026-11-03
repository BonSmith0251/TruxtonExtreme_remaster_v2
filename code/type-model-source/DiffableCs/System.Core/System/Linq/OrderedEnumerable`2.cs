namespace System.Linq;

[Token(Token = "0x200003D")]
internal class OrderedEnumerable : OrderedEnumerable<TElement>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B6")]
	internal OrderedEnumerable<TElement> parent; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B7")]
	internal Func<TElement, TKey> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B8")]
	internal IComparer<TKey> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B9")]
	internal bool descending; //Field offset: 0x0

	[Address(RVA = "0xE12A70", Offset = "0xE11E70", Length = "0x101")]
	[Token(Token = "0x6000179")]
	internal OrderedEnumerable`2(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }

	[Address(RVA = "0xE126B0", Offset = "0xE11AB0", Length = "0xCF")]
	[Token(Token = "0x600017A")]
	internal virtual EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }

}

