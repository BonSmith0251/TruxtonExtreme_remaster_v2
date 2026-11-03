namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x20002A3")]
public static class MouseCaptureController
{

	[Address(RVA = "0x34069A0", Offset = "0x3405DA0", Length = "0x1B0")]
	[Extension]
	[Token(Token = "0x6001252")]
	public static void CaptureMouse(IEventHandler handler) { }

	[Address(RVA = "0x3406B60", Offset = "0x3405F60", Length = "0x16F")]
	[Extension]
	[Token(Token = "0x6001251")]
	public static bool HasMouseCapture(IEventHandler handler) { }

}

