namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x200062D")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StylePropertyCache
{
	[Token(Token = "0x40016BA")]
	internal static readonly Dictionary<String, String> s_PropertySyntaxCache; //Field offset: 0x0
	[Token(Token = "0x40016BB")]
	internal static readonly Dictionary<String, String> s_NonTerminalValues; //Field offset: 0x8

	[Address(RVA = "0x334F740", Offset = "0x334EB40", Length = "0x149C")]
	[Token(Token = "0x6002C05")]
	private static StylePropertyCache() { }

	[Address(RVA = "0x334F620", Offset = "0x334EA20", Length = "0x88")]
	[Token(Token = "0x6002C04")]
	public static bool TryGetNonTerminalValue(string name, out string syntax) { }

	[Address(RVA = "0x334F6B0", Offset = "0x334EAB0", Length = "0x87")]
	[Token(Token = "0x6002C03")]
	public static bool TryGetSyntax(string name, out string syntax) { }

}

