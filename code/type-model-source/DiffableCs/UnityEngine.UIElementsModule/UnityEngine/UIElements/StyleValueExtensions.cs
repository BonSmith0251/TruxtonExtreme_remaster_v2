namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x200042E")]
internal static class StyleValueExtensions
{

	[Address(RVA = "0x91C4B0", Offset = "0x91B8B0", Length = "0x5D")]
	[Extension]
	[Token(Token = "0x600201B")]
	internal static void CopyFrom(List<T> list, List<T> other) { }

	[Address(RVA = "0x91CBD0", Offset = "0x91BFD0", Length = "0x172")]
	[Extension]
	[Token(Token = "0x6002012")]
	internal static string DebugString(IStyleValue<T> styleValue) { }

	[Address(RVA = "0x327D8A0", Offset = "0x327CCA0", Length = "0x104")]
	[Extension]
	[Token(Token = "0x6002013")]
	internal static LayoutValue ToLayoutValue(Length length) { }

	[Address(RVA = "0x327D9B0", Offset = "0x327CDB0", Length = "0xE8")]
	[Extension]
	[Token(Token = "0x6002014")]
	internal static Length ToLength(StyleKeyword keyword) { }

	[Address(RVA = "0x327DAA0", Offset = "0x327CEA0", Length = "0x10D")]
	[Extension]
	[Token(Token = "0x6002019")]
	internal static Length ToLength(StyleLength styleLength) { }

	[Address(RVA = "0x327DBB0", Offset = "0x327CFB0", Length = "0x103")]
	[Extension]
	[Token(Token = "0x6002015")]
	internal static Rotate ToRotate(StyleKeyword keyword) { }

	[Address(RVA = "0x327DCC0", Offset = "0x327D0C0", Length = "0x13E")]
	[Extension]
	[Token(Token = "0x6002016")]
	internal static Scale ToScale(StyleKeyword keyword) { }

	[Address(RVA = "0x327DE00", Offset = "0x327D200", Length = "0xCC")]
	[Extension]
	[Token(Token = "0x600201A")]
	internal static StyleRatio ToStyleRatio(StyleKeyword keyword) { }

	[Address(RVA = "0x327DED0", Offset = "0x327D2D0", Length = "0xEA")]
	[Extension]
	[Token(Token = "0x6002018")]
	internal static TextAutoSize ToTextAutoSize(StyleKeyword keyword) { }

	[Address(RVA = "0x327DFC0", Offset = "0x327D3C0", Length = "0xF2")]
	[Extension]
	[Token(Token = "0x6002017")]
	internal static Translate ToTranslate(StyleKeyword keyword) { }

}

