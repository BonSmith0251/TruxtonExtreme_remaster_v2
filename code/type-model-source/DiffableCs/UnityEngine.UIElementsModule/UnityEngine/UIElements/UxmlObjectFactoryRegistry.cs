namespace UnityEngine.UIElements;

[Obsolete("UxmlObjectFactoryRegistry is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x2000519")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class UxmlObjectFactoryRegistry
{
	[Token(Token = "0x40010BD")]
	private static Dictionary<String, List`1<IBaseUxmlObjectFactory>> s_Factories; //Field offset: 0x0

	[Token(Token = "0x170009E1")]
	internal static Dictionary<String, List`1<IBaseUxmlObjectFactory>> factories
	{
		[Address(RVA = "0x32C5CB0", Offset = "0x32C50B0", Length = "0xBF")]
		[Token(Token = "0x60025CA")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 191
	}

	[Address(RVA = "0x32C5CB0", Offset = "0x32C50B0", Length = "0xBF")]
	[Token(Token = "0x60025CA")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static Dictionary<String, List`1<IBaseUxmlObjectFactory>> get_factories() { }

	[Address(RVA = "0x32C5400", Offset = "0x32C4800", Length = "0x237")]
	[Token(Token = "0x60025CC")]
	private static void RegisterEngineFactories() { }

	[Address(RVA = "0x32C5640", Offset = "0x32C4A40", Length = "0x364")]
	[Token(Token = "0x60025CB")]
	protected static void RegisterFactory(IBaseUxmlObjectFactory factory) { }

	[Address(RVA = "0x32C59B0", Offset = "0x32C4DB0", Length = "0x2FC")]
	[Token(Token = "0x60025CD")]
	private static void RegisterUserFactories() { }

}

