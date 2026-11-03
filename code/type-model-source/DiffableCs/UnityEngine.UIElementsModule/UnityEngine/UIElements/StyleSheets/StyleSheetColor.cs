namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x200063D")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal static class StyleSheetColor
{
	[Token(Token = "0x400176D")]
	private static Dictionary<String, Color32> s_NameToColor; //Field offset: 0x0

	[Address(RVA = "0x336D080", Offset = "0x336C480", Length = "0x1ADF")]
	[Token(Token = "0x6002C6E")]
	private static StyleSheetColor() { }

	[Address(RVA = "0x336CF50", Offset = "0x336C350", Length = "0x20")]
	[Token(Token = "0x6002C6D")]
	private static Color32 HexToColor32(uint color) { }

	[Address(RVA = "0x336CF70", Offset = "0x336C370", Length = "0x103")]
	[Token(Token = "0x6002C6C")]
	public static bool TryGetColor(string name, out Color color) { }

}

