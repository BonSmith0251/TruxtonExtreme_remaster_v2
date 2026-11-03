namespace System.Linq;

[Token(Token = "0x200003E")]
internal abstract class EnumerableSorter
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600017F")]
	protected EnumerableSorter`1() { }

	[Token(Token = "0x600017C")]
	internal abstract int CompareKeys(int index1, int index2) { }

	[Token(Token = "0x600017B")]
	internal abstract void ComputeKeys(TElement[] elements, int count) { }

	[Address(RVA = "0x1955E90", Offset = "0x1955290", Length = "0x255")]
	[Token(Token = "0x600017E")]
	private void QuickSort(Int32[] map, int left, int right) { }

	[Address(RVA = "0x19567B0", Offset = "0x1955BB0", Length = "0xDA")]
	[Token(Token = "0x600017D")]
	internal Int32[] Sort(TElement[] elements, int count) { }

}

