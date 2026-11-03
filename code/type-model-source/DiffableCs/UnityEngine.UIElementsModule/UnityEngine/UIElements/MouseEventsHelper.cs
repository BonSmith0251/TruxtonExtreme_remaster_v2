namespace UnityEngine.UIElements;

[Token(Token = "0x2000209")]
internal static class MouseEventsHelper
{

	[Address(RVA = "0x88A1F0", Offset = "0x8895F0", Length = "0x650")]
	[Token(Token = "0x6000E6C")]
	internal static void SendEnterLeave(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) { }

	[Address(RVA = "0x33D52E0", Offset = "0x33D46E0", Length = "0x242")]
	[Token(Token = "0x6000E6D")]
	internal static void SendMouseOverMouseOut(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) { }

}

