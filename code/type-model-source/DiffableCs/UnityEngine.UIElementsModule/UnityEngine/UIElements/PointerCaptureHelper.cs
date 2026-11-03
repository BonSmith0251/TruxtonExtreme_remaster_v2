namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x20002C6")]
public static class PointerCaptureHelper
{

	[Address(RVA = "0x340A230", Offset = "0x3409630", Length = "0x7C")]
	[Extension]
	[Token(Token = "0x6001357")]
	internal static void ActivateCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[Address(RVA = "0x340A2B0", Offset = "0x34096B0", Length = "0xB1")]
	[Extension]
	[Token(Token = "0x6001353")]
	public static void CapturePointer(IEventHandler handler, int pointerId) { }

	[Address(RVA = "0x340A370", Offset = "0x3409770", Length = "0x89")]
	[Extension]
	[Token(Token = "0x6001355")]
	public static IEventHandler GetCapturingElement(IPanel panel, int pointerId) { }

	[Address(RVA = "0x340A400", Offset = "0x3409800", Length = "0x9B")]
	[Token(Token = "0x6001351")]
	private static PointerDispatchState GetStateFor(IEventHandler handler) { }

	[Address(RVA = "0x340A4A0", Offset = "0x34098A0", Length = "0xDC")]
	[Extension]
	[Token(Token = "0x6001352")]
	public static bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	[Address(RVA = "0x340A580", Offset = "0x3409980", Length = "0x7C")]
	[Extension]
	[Token(Token = "0x6001358")]
	internal static void PreventCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	[Address(RVA = "0x340A600", Offset = "0x3409A00", Length = "0x6C")]
	[Extension]
	[Token(Token = "0x600135A")]
	internal static void ProcessPointerCapture(IPanel panel, int pointerId) { }

	[Address(RVA = "0x340A670", Offset = "0x3409A70", Length = "0xD1")]
	[Extension]
	[Token(Token = "0x6001354")]
	public static void ReleasePointer(IEventHandler handler, int pointerId) { }

	[Address(RVA = "0x340A750", Offset = "0x3409B50", Length = "0x6C")]
	[Extension]
	[Token(Token = "0x6001356")]
	public static void ReleasePointer(IPanel panel, int pointerId) { }

	[Address(RVA = "0x340A7C0", Offset = "0x3409BC0", Length = "0x14B")]
	[Extension]
	[Token(Token = "0x6001359")]
	internal static bool ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt) { }

}

