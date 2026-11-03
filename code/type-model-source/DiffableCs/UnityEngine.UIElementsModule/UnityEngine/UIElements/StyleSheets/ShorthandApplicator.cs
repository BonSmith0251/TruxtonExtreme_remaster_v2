namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x200062C")]
[VisibleToOtherModules]
internal static class ShorthandApplicator
{
	[Token(Token = "0x40016B6")]
	private static List<TimeValue> s_TransitionDelayList; //Field offset: 0x0
	[Token(Token = "0x40016B7")]
	private static List<TimeValue> s_TransitionDurationList; //Field offset: 0x8
	[Token(Token = "0x40016B8")]
	private static List<StylePropertyName> s_TransitionPropertyList; //Field offset: 0x10
	[Token(Token = "0x40016B9")]
	private static List<EasingFunction> s_TransitionTimingFunctionList; //Field offset: 0x18

	[Address(RVA = "0x33275A0", Offset = "0x33269A0", Length = "0x192")]
	[Token(Token = "0x6002C01")]
	private static ShorthandApplicator() { }

	[Address(RVA = "0x3327590", Offset = "0x3326990", Length = "0xB")]
	[CompilerGenerated]
	[Token(Token = "0x6002C02")]
	internal static void <CompileBackgroundPosition>g__SwapKeyword|16_0(ref BackgroundPositionKeyword a, ref BackgroundPositionKeyword b) { }

	[Address(RVA = "0x3324AC0", Offset = "0x3323EC0", Length = "0xC4")]
	[Token(Token = "0x6002BEE")]
	public static void ApplyBackgroundPosition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x3324B90", Offset = "0x3323F90", Length = "0x220")]
	[Token(Token = "0x6002BEF")]
	public static void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x3324DC0", Offset = "0x33241C0", Length = "0x1D8")]
	[Token(Token = "0x6002BF0")]
	public static void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x3324FA0", Offset = "0x33243A0", Length = "0x237")]
	[Token(Token = "0x6002BF1")]
	public static void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x33251E0", Offset = "0x33245E0", Length = "0xE0")]
	[Token(Token = "0x6002BF2")]
	public static void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x33252C0", Offset = "0x33246C0", Length = "0x1E2")]
	[Token(Token = "0x6002BF3")]
	public static void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x33254B0", Offset = "0x33248B0", Length = "0x1EE")]
	[Token(Token = "0x6002BF4")]
	public static void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x33256A0", Offset = "0x3324AA0", Length = "0x145")]
	[Token(Token = "0x6002BF5")]
	public static void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x33257F0", Offset = "0x3324BF0", Length = "0x16A")]
	[Token(Token = "0x6002BF6")]
	public static void ApplyUnityBackgroundScaleMode(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x3325960", Offset = "0x3324D60", Length = "0x11B")]
	[Token(Token = "0x6002BF7")]
	public static void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	[Address(RVA = "0x3325A80", Offset = "0x3324E80", Length = "0x6BD")]
	[Token(Token = "0x6002BFA")]
	private static void CompileBackgroundPosition(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY) { }

	[Address(RVA = "0x3326140", Offset = "0x3325540", Length = "0x13A")]
	[Token(Token = "0x6002BF9")]
	private static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	[Address(RVA = "0x3326610", Offset = "0x3325A10", Length = "0x168")]
	[Token(Token = "0x6002BFC")]
	private static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	[Address(RVA = "0x3326430", Offset = "0x3325830", Length = "0x1D6")]
	[Token(Token = "0x6002BFD")]
	private static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left) { }

	[Address(RVA = "0x3326280", Offset = "0x3325680", Length = "0x1A5")]
	[Token(Token = "0x6002BFE")]
	private static void CompileBoxArea(StylePropertyReader reader, out Color top, out Color right, out Color bottom, out Color left) { }

	[Address(RVA = "0x3326780", Offset = "0x3325B80", Length = "0x1F7")]
	[Token(Token = "0x6002BF8")]
	private static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis) { }

	[Address(RVA = "0x3326980", Offset = "0x3325D80", Length = "0xB0")]
	[Token(Token = "0x6002BFF")]
	private static void CompileTextOutline(StylePropertyReader reader, out Color outlineColor, out float outlineWidth) { }

	[Address(RVA = "0x3326A40", Offset = "0x3325E40", Length = "0xA87")]
	[Token(Token = "0x6002C00")]
	private static void CompileTransition(StylePropertyReader reader, out List<TimeValue>& outDelay, out List<TimeValue>& outDuration, out List<StylePropertyName>& outProperty, out List<EasingFunction>& outTimingFunction) { }

	[Address(RVA = "0x33274D0", Offset = "0x33268D0", Length = "0xBA")]
	[Token(Token = "0x6002BFB")]
	public static void CompileUnityBackgroundScaleMode(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY, out BackgroundRepeat backgroundRepeat, out BackgroundSize backgroundSize) { }

}

