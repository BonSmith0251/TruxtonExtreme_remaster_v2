namespace System.Dynamic.Utils;

[Extension]
[Token(Token = "0x200027D")]
internal static class CollectionExtensions
{

	[Address(RVA = "0x79DB10", Offset = "0x79CF10", Length = "0xFC")]
	[Extension]
	[Token(Token = "0x6000C66")]
	public static TrueReadOnlyCollection<T> AddFirst(ReadOnlyCollection<T> list, T item) { }

	[Address(RVA = "0x79DD80", Offset = "0x79D180", Length = "0xB2")]
	[Extension]
	[Token(Token = "0x6000C67")]
	public static T[] AddLast(T[] array, T item) { }

	[Address(RVA = "0x79EBF0", Offset = "0x79DFF0", Length = "0x93")]
	[Extension]
	[Token(Token = "0x6000C68")]
	public static T[] RemoveFirst(T[] array) { }

	[Address(RVA = "0x79EFE0", Offset = "0x79E3E0", Length = "0x90")]
	[Extension]
	[Token(Token = "0x6000C69")]
	public static T[] RemoveLast(T[] array) { }

	[Address(RVA = "0x79F5F0", Offset = "0x79E9F0", Length = "0x1BD")]
	[Extension]
	[Token(Token = "0x6000C6A")]
	public static ReadOnlyCollection<T> ToReadOnly(IEnumerable<T> enumerable) { }

}

