namespace UnityEngine;

[NativeHeader("Runtime/Math/ColorUtility.h")]
[Token(Token = "0x200014E")]
public class ColorUtility
{

	[Token(Token = "0x17000284")]
	private static ReadOnlySpan<String> HtmlColorNames
	{
		[Address(RVA = "0x3047290", Offset = "0x3046690", Length = "0x48B")]
		[Token(Token = "0x600100A")]
		private get { } //Length: 1163
	}

	[Token(Token = "0x17000283")]
	private static ReadOnlySpan<Color32> HtmlColorValues
	{
		[Address(RVA = "0x3047720", Offset = "0x3046B20", Length = "0x2AA")]
		[Token(Token = "0x6001009")]
		private get { } //Length: 682
	}

	[Address(RVA = "0x3047290", Offset = "0x3046690", Length = "0x48B")]
	[Token(Token = "0x600100A")]
	private static ReadOnlySpan<String> get_HtmlColorNames() { }

	[Address(RVA = "0x3047720", Offset = "0x3046B20", Length = "0x2AA")]
	[Token(Token = "0x6001009")]
	private static ReadOnlySpan<Color32> get_HtmlColorValues() { }

	[Address(RVA = "0x3046970", Offset = "0x3045D70", Length = "0x3F")]
	[Token(Token = "0x600100F")]
	private static int HexDigitValue(char c) { }

	[Address(RVA = "0x30469B0", Offset = "0x3045DB0", Length = "0xB4")]
	[Token(Token = "0x600100C")]
	private static bool IsHexString(ReadOnlySpan<Char> span) { }

	[Address(RVA = "0x3046A70", Offset = "0x3045E70", Length = "0xEC")]
	[Token(Token = "0x600100E")]
	private static bool TryHexToByte(ReadOnlySpan<Char> span, out byte result) { }

	[Address(RVA = "0x3046B60", Offset = "0x3045F60", Length = "0x2C5")]
	[Token(Token = "0x600100D")]
	private static bool TryParseHexColor(ReadOnlySpan<Char> hex, out Color color) { }

	[Address(RVA = "0x3046E30", Offset = "0x3046230", Length = "0x45D")]
	[Token(Token = "0x600100B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static bool TryParseHtmlString(ReadOnlySpan<Char> input, out Color color) { }

}

