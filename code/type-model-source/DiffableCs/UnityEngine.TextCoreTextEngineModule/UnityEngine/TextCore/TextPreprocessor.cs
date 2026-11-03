namespace UnityEngine.TextCore;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000018")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal static class TextPreprocessor
{

	[Address(RVA = "0x318FD90", Offset = "0x318F190", Length = "0x88")]
	[Token(Token = "0x600004D")]
	private static TextStyle GetStyle(TextSettings textSettings, int hashCode) { }

	[Address(RVA = "0x318FCF0", Offset = "0x318F0F0", Length = "0x93")]
	[NullableContext(0)]
	[Token(Token = "0x600004C")]
	private static int GetStyleHashCode(ReadOnlySpan<Char> text) { }

	[Address(RVA = "0x318FE20", Offset = "0x318F220", Length = "0x504")]
	[Token(Token = "0x600004B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void PreProcessString(ref string text, PreProcessFlags flags, TextSettings textSettings) { }

	[Address(RVA = "0x31906B0", Offset = "0x318FAB0", Length = "0x6FE")]
	[Token(Token = "0x600004E")]
	internal static string ReplaceStyleTags(string text, TextSettings textSettings) { }

}

