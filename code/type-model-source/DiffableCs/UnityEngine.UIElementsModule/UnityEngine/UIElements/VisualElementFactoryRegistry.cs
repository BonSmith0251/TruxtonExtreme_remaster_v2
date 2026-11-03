namespace UnityEngine.UIElements;

[Token(Token = "0x2000520")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class VisualElementFactoryRegistry
{
	[Token(Token = "0x40010CE")]
	private static Dictionary<String, List`1<IUxmlFactory>> s_Factories; //Field offset: 0x0
	[Token(Token = "0x40010CF")]
	private static Dictionary<String, List`1<IUxmlFactory>> s_MovedTypesFactories; //Field offset: 0x8

	[Token(Token = "0x170009EB")]
	internal static Dictionary<String, List`1<IUxmlFactory>> factories
	{
		[Address(RVA = "0x32CBBD0", Offset = "0x32CAFD0", Length = "0x11E")]
		[Token(Token = "0x60025E9")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 286
	}

	[Address(RVA = "0x32CBBD0", Offset = "0x32CAFD0", Length = "0x11E")]
	[Token(Token = "0x60025E9")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static Dictionary<String, List`1<IUxmlFactory>> get_factories() { }

	[Address(RVA = "0x32C9820", Offset = "0x32C8C20", Length = "0x11E")]
	[Token(Token = "0x60025E8")]
	internal static string GetMovedUIControlTypeName(Type type, MovedFromAttribute attr) { }

	[Address(RVA = "0x32C9940", Offset = "0x32C8D40", Length = "0x194B")]
	[Token(Token = "0x60025EC")]
	private static void RegisterEngineFactories() { }

	[Address(RVA = "0x32CB290", Offset = "0x32CA690", Length = "0x597")]
	[Token(Token = "0x60025EA")]
	protected static void RegisterFactory(IUxmlFactory factory) { }

	[Address(RVA = "0x32CB830", Offset = "0x32CAC30", Length = "0x2FC")]
	[Token(Token = "0x60025ED")]
	internal static void RegisterUserFactories() { }

	[Address(RVA = "0x32CBB30", Offset = "0x32CAF30", Length = "0x96")]
	[Token(Token = "0x60025EB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static bool TryGetValue(string fullTypeName, out List<IUxmlFactory>& factoryList) { }

}

