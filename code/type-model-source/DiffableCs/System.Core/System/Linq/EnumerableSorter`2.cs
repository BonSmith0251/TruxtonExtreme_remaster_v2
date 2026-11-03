namespace System.Linq;

[Token(Token = "0x200003F")]
internal class EnumerableSorter : EnumerableSorter<TElement>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BA")]
	internal Func<TElement, TKey> keySelector; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BB")]
	internal IComparer<TKey> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BC")]
	internal bool descending; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BD")]
	internal EnumerableSorter<TElement> next; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BE")]
	internal TKey[] keys; //Field offset: 0x0

	[Address(RVA = "0x1957610", Offset = "0x1956A10", Length = "0x72")]
	[Token(Token = "0x6000180")]
	internal EnumerableSorter`2(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next) { }

	[Address(RVA = "0x1956C80", Offset = "0x1956080", Length = "0xEA")]
	[Token(Token = "0x6000182")]
	internal virtual int CompareKeys(int index1, int index2) { }

	[Address(RVA = "0x19574E0", Offset = "0x19568E0", Length = "0x12B")]
	[Token(Token = "0x6000181")]
	internal virtual void ComputeKeys(TElement[] elements, int count) { }

}

