namespace Unity.Properties.Internal;

[Token(Token = "0x200009E")]
internal static class PropertyBagStore
{
	[Token(Token = "0x200009F")]
	public struct TypedStore
	{
		[Token(Token = "0x4000160")]
		public static IPropertyBag<TContainer> PropertyBag; //Field offset: 0x0

	}

	[Token(Token = "0x400015D")]
	private static readonly ConcurrentDictionary<Type, IPropertyBag> s_PropertyBags; //Field offset: 0x0
	[Token(Token = "0x400015E")]
	private static readonly List<Type> s_RegisteredTypes; //Field offset: 0x8
	[Token(Token = "0x400015F")]
	private static ReflectedPropertyBagProvider s_PropertyBagProvider; //Field offset: 0x10

	[Token(Token = "0x17000095")]
	private static ReflectedPropertyBagProvider ReflectedPropertyBagProvider
	{
		[Address(RVA = "0x315B240", Offset = "0x315A640", Length = "0xC7")]
		[Token(Token = "0x6000321")]
		private get { } //Length: 199
	}

	[Address(RVA = "0x315B120", Offset = "0x315A520", Length = "0x115")]
	[Token(Token = "0x6000327")]
	private static PropertyBagStore() { }

	[Address(RVA = "0x8B6060", Offset = "0x8B5460", Length = "0x619")]
	[Token(Token = "0x6000323")]
	internal static void AddPropertyBag(IPropertyBag<TContainer> propertyBag) { }

	[Address(RVA = "0x315ABC0", Offset = "0x3159FC0", Length = "0x8D")]
	[Token(Token = "0x6000322")]
	internal static void CreatePropertyBagProvider() { }

	[Address(RVA = "0x315B240", Offset = "0x315A640", Length = "0xC7")]
	[Token(Token = "0x6000321")]
	private static ReflectedPropertyBagProvider get_ReflectedPropertyBagProvider() { }

	[Address(RVA = "0x8B6BC0", Offset = "0x8B5FC0", Length = "0x147")]
	[Token(Token = "0x6000324")]
	internal static IPropertyBag<TContainer> GetPropertyBag() { }

	[Address(RVA = "0x315AC50", Offset = "0x315A050", Length = "0x4C0")]
	[Token(Token = "0x6000325")]
	internal static IPropertyBag GetPropertyBag(Type type) { }

	[Address(RVA = "0x8BDAE0", Offset = "0x8BCEE0", Length = "0x1FA")]
	[Token(Token = "0x6000326")]
	internal static bool TryGetPropertyBagForValue(ref TValue value, out IPropertyBag propertyBag) { }

}

