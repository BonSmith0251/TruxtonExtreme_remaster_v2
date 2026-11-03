namespace UnityEngine.UIElements;

[Token(Token = "0x200026C")]
internal class ScreenOverlayPanelPicker
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60010E4")]
	public ScreenOverlayPanelPicker() { }

	[Address(RVA = "0x33F2F20", Offset = "0x33F2320", Length = "0x10C")]
	[Token(Token = "0x60010E3")]
	private bool GetCapturingPanel(int pointerId, out BaseVisualElementPanel capturingPanel) { }

	[Address(RVA = "0x33F3030", Offset = "0x33F2430", Length = "0x23E")]
	[Token(Token = "0x60010E2")]
	public bool TryPick(BaseRuntimePanel panel, int pointerId, Vector2 screenPosition, Vector2 delta, Nullable<Int32> targetDisplay, out bool captured) { }

}

