namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200009A")]
internal static class CollectionUtils
{
	[NullableContext(0)]
	[Token(Token = "0x200009B")]
	private static class EmptyArrayContainer
	{
		[Nullable(1)]
		[Token(Token = "0x400039D")]
		public static readonly T[] Empty; //Field offset: 0x0

		[Address(RVA = "0x19510A0", Offset = "0x19504A0", Length = "0xCF")]
		[Token(Token = "0x6000517")]
		private static EmptyArrayContainer`1() { }

	}


	[Address(RVA = "0x7A1BA0", Offset = "0x7A0FA0", Length = "0x9A")]
	[Extension]
	[Token(Token = "0x600050B")]
	public static bool AddDistinct(IList<T> list, T value, IEqualityComparer<T> comparer) { }

	[Address(RVA = "0x7A1AE0", Offset = "0x7A0EE0", Length = "0xBE")]
	[Extension]
	[Token(Token = "0x600050A")]
	public static bool AddDistinct(IList<T> list, T value) { }

	[Address(RVA = "0x7A24F0", Offset = "0x7A18F0", Length = "0x29A")]
	[Extension]
	[Token(Token = "0x6000506")]
	public static void AddRange(IList<T> initial, IEnumerable<T> collection) { }

	[Address(RVA = "0x7A1F60", Offset = "0x7A1360", Length = "0x270")]
	[Extension]
	[Token(Token = "0x600050D")]
	public static bool AddRangeDistinct(IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer) { }

	[Address(RVA = "0x5D49B0", Offset = "0x5D3DB0", Length = "0x75")]
	[Token(Token = "0x6000516")]
	public static T[] ArrayEmpty() { }

	[Address(RVA = "0x7A2E70", Offset = "0x7A2270", Length = "0xB6")]
	[Extension]
	[Token(Token = "0x600050F")]
	public static bool Contains(List<T> list, T value, IEqualityComparer comparer) { }

	[Address(RVA = "0x7A2AD0", Offset = "0x7A1ED0", Length = "0x20F")]
	[Extension]
	[Token(Token = "0x600050C")]
	public static bool ContainsValue(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }

	[Address(RVA = "0x211A0E0", Offset = "0x21194E0", Length = "0x23E")]
	[Token(Token = "0x6000513")]
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, Int32[] indices) { }

	[Address(RVA = "0x7A31B0", Offset = "0x7A25B0", Length = "0x108")]
	[Extension]
	[Token(Token = "0x6000511")]
	public static void FastReverse(List<T> list) { }

	[Address(RVA = "0x211A320", Offset = "0x2119720", Length = "0x3A2")]
	[Token(Token = "0x6000512")]
	private static IList<Int32> GetDimensions(IList values, int dimensionsCount) { }

	[Address(RVA = "0x7A3740", Offset = "0x7A2B40", Length = "0x1A9")]
	[Extension]
	[Token(Token = "0x600050E")]
	public static int IndexOf(IEnumerable<T> collection, Func<T, Boolean> predicate) { }

	[Address(RVA = "0x7A3420", Offset = "0x7A2820", Length = "0x7A")]
	[Extension]
	[Token(Token = "0x6000510")]
	public static int IndexOfReference(List<T> list, T item) { }

	[Address(RVA = "0x211A6D0", Offset = "0x2119AD0", Length = "0x179")]
	[Token(Token = "0x6000507")]
	public static bool IsDictionaryType(Type type) { }

	[Address(RVA = "0x7A38F0", Offset = "0x7A2CF0", Length = "0x66")]
	[Token(Token = "0x6000505")]
	public static bool IsNullOrEmpty(ICollection<T> collection) { }

	[Address(RVA = "0x211A850", Offset = "0x2119C50", Length = "0xF8")]
	[Token(Token = "0x6000514")]
	private static object JaggedArrayGetValue(IList values, Int32[] indices) { }

	[Address(RVA = "0x211A950", Offset = "0x2119D50", Length = "0x111")]
	[Token(Token = "0x6000508")]
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	[Address(RVA = "0x211AA70", Offset = "0x2119E70", Length = "0x29D")]
	[Token(Token = "0x6000509")]
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	[Address(RVA = "0x211AD10", Offset = "0x211A110", Length = "0x23A")]
	[Token(Token = "0x6000515")]
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

}

