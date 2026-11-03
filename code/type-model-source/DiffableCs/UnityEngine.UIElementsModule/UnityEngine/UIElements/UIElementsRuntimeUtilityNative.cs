namespace UnityEngine.UIElements;

[NativeHeader("Modules/UIElements/Core/Native/UIElementsRuntimeUtilityNative.h")]
[Token(Token = "0x20002AD")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"Unity.UIElements"})]
internal static class UIElementsRuntimeUtilityNative
{
	[Token(Token = "0x4000AB3")]
	private static Action UpdatePanelsCallback; //Field offset: 0x0
	[Token(Token = "0x4000AB4")]
	private static Action<Boolean> RepaintPanelsCallback; //Field offset: 0x8
	[Token(Token = "0x4000AB5")]
	private static Action RenderOffscreenPanelsCallback; //Field offset: 0x10

	[Address(RVA = "0x340D020", Offset = "0x340C420", Length = "0x2A")]
	[Token(Token = "0x6001272")]
	private static void RegisterRenderingCallbacks() { }

	[Address(RVA = "0x340D050", Offset = "0x340C450", Length = "0x4F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600126E")]
	public static void RenderOffscreenPanels() { }

	[Address(RVA = "0x340D0A0", Offset = "0x340C4A0", Length = "0x59")]
	[RequiredByNativeCode]
	[Token(Token = "0x600126D")]
	public static void RepaintPanels(bool onlyOffscreen) { }

	[Address(RVA = "0x340D100", Offset = "0x340C500", Length = "0xB0")]
	[Token(Token = "0x6001270")]
	public static void SetRenderingCallbacks(Action<Boolean> repaintPanels, Action renderOffscreenPanels) { }

	[Address(RVA = "0x340D1B0", Offset = "0x340C5B0", Length = "0x51")]
	[Token(Token = "0x600126F")]
	public static void SetUpdateCallback(Action callback) { }

	[Address(RVA = "0x340D210", Offset = "0x340C610", Length = "0x2A")]
	[Token(Token = "0x6001273")]
	private static void UnregisterRenderingCallbacks() { }

	[Address(RVA = "0x340D240", Offset = "0x340C640", Length = "0xA4")]
	[Token(Token = "0x6001271")]
	public static void UnsetRenderingCallbacks() { }

	[Address(RVA = "0x340D2F0", Offset = "0x340C6F0", Length = "0x4E")]
	[RequiredByNativeCode]
	[Token(Token = "0x600126C")]
	public static void UpdatePanels() { }

	[Address(RVA = "0x340D340", Offset = "0x340C740", Length = "0x2A")]
	[Token(Token = "0x6001274")]
	public static void VisualElementCreation() { }

}

