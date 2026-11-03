namespace UnityEngine.Splines;

[Token(Token = "0x2000004")]
internal static class ArrayUtility
{

	[Address(RVA = "0x7276E0", Offset = "0x726AE0", Length = "0x8A")]
	[Token(Token = "0x6000007")]
	public static void Add(ref T[] array, T element) { }

	[Address(RVA = "0x727B50", Offset = "0x726F50", Length = "0xF6")]
	[Token(Token = "0x6000006")]
	public static void Remove(ref T[] array, T element) { }

	[Address(RVA = "0x727980", Offset = "0x726D80", Length = "0xC2")]
	[Token(Token = "0x6000003")]
	public static void RemoveAt(ref T[] array, int index) { }

	[Address(RVA = "0x7278C0", Offset = "0x726CC0", Length = "0xB9")]
	[Token(Token = "0x6000004")]
	public static void RemoveAt(ref T[] array, IEnumerable<Int32> indices) { }

	[Address(RVA = "0x727F80", Offset = "0x727380", Length = "0x19A")]
	[Token(Token = "0x6000005")]
	public static void SortedRemoveAt(ref T[] array, IList<Int32> sorted) { }

}

