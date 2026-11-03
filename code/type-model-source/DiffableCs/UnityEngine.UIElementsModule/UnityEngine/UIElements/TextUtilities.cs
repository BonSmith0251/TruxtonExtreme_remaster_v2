namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x20004B2")]
internal static class TextUtilities
{

	[Address(RVA = "0x32AE840", Offset = "0x32ADC40", Length = "0x199")]
	[Token(Token = "0x60023C1")]
	internal static FontAsset GetFontAsset(VisualElement ve) { }

	[Address(RVA = "0x32AE9E0", Offset = "0x32ADDE0", Length = "0x4A5")]
	[Token(Token = "0x60023C6")]
	internal static TextCoreSettings GetTextCoreSettingsForElement(VisualElement ve, bool ignoreColors) { }

	[Address(RVA = "0x32AEE90", Offset = "0x32AE290", Length = "0xC0")]
	[Token(Token = "0x60023C3")]
	internal static TextSettings GetTextSettingsFrom(VisualElement ve) { }

	[Address(RVA = "0x32AEF60", Offset = "0x32AE360", Length = "0x64")]
	[Token(Token = "0x60023C5")]
	internal static bool IsAdvancedTextEnabledForElement(VisualElement ve) { }

	[Address(RVA = "0x32AEFD0", Offset = "0x32AE3D0", Length = "0xA7")]
	[Token(Token = "0x60023C4")]
	internal static bool IsAdvancedTextEnabledForPanel(IPanel panel) { }

	[Address(RVA = "0x32AF080", Offset = "0x32AE480", Length = "0xC0")]
	[Token(Token = "0x60023C2")]
	internal static bool IsFontAssigned(VisualElement ve) { }

	[Address(RVA = "0x32AF350", Offset = "0x32AE750", Length = "0x204")]
	[Token(Token = "0x60023BF")]
	internal static Vector2 MeasureVisualElementTextSize(TextElement te, string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode, Nullable<Single> fontsize = null) { }

	[Address(RVA = "0x32AF150", Offset = "0x32AE550", Length = "0x1FA")]
	[Token(Token = "0x60023C0")]
	internal static Vector2 MeasureVisualElementTextSize(TextElement te, in RenderedText textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode, Nullable<Single> fontsize = null) { }

	[Address(RVA = "0x32AF560", Offset = "0x32AE960", Length = "0x1EA")]
	[Token(Token = "0x60023BE")]
	private static Vector2 PostProcessMeasuredSize(TextElement te, Vector2 measuredSize, float width, MeasureMode widthMode, float height, MeasureMode heightMode, float pixelsPerPoint) { }

	[Address(RVA = "0x32AF750", Offset = "0x32AEB50", Length = "0x14")]
	[Extension]
	[Token(Token = "0x60023C8")]
	public static TextOverflow toTextCore(TextOverflow textOverflow, OverflowInternal overflow, TextOverflowPosition position) { }

	[Address(RVA = "0x32AF770", Offset = "0x32AEB70", Length = "0x42")]
	[Extension]
	[Token(Token = "0x60023C7")]
	public static TextWrappingMode toTextWrappingMode(WhiteSpace whiteSpace, bool isSingleLineInputField) { }

}

