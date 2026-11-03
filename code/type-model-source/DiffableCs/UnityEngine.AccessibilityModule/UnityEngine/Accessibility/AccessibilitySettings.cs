namespace UnityEngine.Accessibility;

[NativeHeader("Modules/Accessibility/Native/AccessibilitySettings.h")]
[Token(Token = "0x200000D")]
public static class AccessibilitySettings
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000041")]
	private static Action<Single> fontScaleChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000042")]
	private static Action<Boolean> boldTextStatusChanged; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000043")]
	private static Action<Boolean> closedCaptioningStatusChanged; //Field offset: 0x10

	[Address(RVA = "0x2F86480", Offset = "0x2F85880", Length = "0x107")]
	[RequiredByNativeCode]
	[Token(Token = "0x600004D")]
	internal static void Internal_OnBoldTextStatusChanged(bool enabled) { }

	[Address(RVA = "0x2F86590", Offset = "0x2F85990", Length = "0x10F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600004E")]
	internal static void Internal_OnClosedCaptioningStatusChanged(bool enabled) { }

	[Address(RVA = "0x2F866A0", Offset = "0x2F85AA0", Length = "0xF2")]
	[RequiredByNativeCode]
	[Token(Token = "0x600004C")]
	internal static void Internal_OnFontScaleChanged(float newFontScale) { }

	[Address(RVA = "0x2F867A0", Offset = "0x2F85BA0", Length = "0x59")]
	[Token(Token = "0x6000050")]
	internal static void InvokeBoldTextStatusChanged(bool enabled) { }

	[Address(RVA = "0x2F86800", Offset = "0x2F85C00", Length = "0x59")]
	[Token(Token = "0x6000051")]
	internal static void InvokeClosedCaptionStatusChanged(bool enabled) { }

	[Address(RVA = "0x2F86860", Offset = "0x2F85C60", Length = "0x59")]
	[Token(Token = "0x600004F")]
	internal static void InvokeFontScaleChanged(float newFontScale) { }

}

