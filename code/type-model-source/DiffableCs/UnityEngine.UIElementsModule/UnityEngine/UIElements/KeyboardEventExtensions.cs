namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x20001E9")]
internal static class KeyboardEventExtensions
{

	[Address(RVA = "0x33D25C0", Offset = "0x33D19C0", Length = "0xBD")]
	[Extension]
	[Token(Token = "0x6000DBE")]
	internal static bool ShouldSendNavigationMoveEvent(KeyDownEvent e) { }

	[Address(RVA = "0x33D2570", Offset = "0x33D1970", Length = "0x43")]
	[Extension]
	[Token(Token = "0x6000DBF")]
	internal static bool ShouldSendNavigationMoveEventRuntime(Event e) { }

}

