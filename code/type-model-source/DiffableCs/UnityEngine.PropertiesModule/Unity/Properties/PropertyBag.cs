namespace Unity.Properties;

[Token(Token = "0x2000040")]
public static class PropertyBag
{

	[Address(RVA = "0x8B5E10", Offset = "0x8B5210", Length = "0x24E")]
	[Token(Token = "0x60000EF")]
	public static void AcceptWithSpecializedVisitor(IPropertyBag<TContainer> properties, IPropertyBagVisitor visitor, ref TContainer container) { }

	[Address(RVA = "0x315B310", Offset = "0x315A710", Length = "0x49")]
	[Token(Token = "0x60000F3")]
	public static IPropertyBag GetPropertyBag(Type type) { }

	[Address(RVA = "0x8B6D10", Offset = "0x8B6110", Length = "0x184")]
	[Token(Token = "0x60000F4")]
	public static IPropertyBag<TContainer> GetPropertyBag() { }

	[Address(RVA = "0x8B71E0", Offset = "0x8B65E0", Length = "0x61")]
	[Token(Token = "0x60000F0")]
	public static void Register(PropertyBag<TContainer> propertyBag) { }

	[Address(RVA = "0x8B6F60", Offset = "0x8B6360", Length = "0xBA")]
	[Token(Token = "0x60000F1")]
	public static void RegisterList() { }

	[Address(RVA = "0x8B7110", Offset = "0x8B6510", Length = "0xCD")]
	[Token(Token = "0x60000F2")]
	public static void RegisterList() { }

	[Address(RVA = "0x8B7FC0", Offset = "0x8B73C0", Length = "0x71")]
	[Token(Token = "0x60000F5")]
	public static bool TryGetPropertyBagForValue(ref TValue value, out IPropertyBag propertyBag) { }

}

