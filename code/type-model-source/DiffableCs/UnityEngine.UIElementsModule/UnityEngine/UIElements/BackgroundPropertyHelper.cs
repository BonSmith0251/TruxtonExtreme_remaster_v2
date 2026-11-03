namespace UnityEngine.UIElements;

[Token(Token = "0x2000012")]
public static class BackgroundPropertyHelper
{

	[Address(RVA = "0x31EDB90", Offset = "0x31ECF90", Length = "0x4E")]
	[Token(Token = "0x6000055")]
	public static BackgroundPosition ConvertScaleModeToBackgroundPosition(ScaleMode scaleMode = 0) { }

	[Address(RVA = "0xE3A280", Offset = "0xE39680", Length = "0x8")]
	[Token(Token = "0x6000056")]
	public static BackgroundRepeat ConvertScaleModeToBackgroundRepeat(ScaleMode scaleMode = 0) { }

	[Address(RVA = "0x31EDDA0", Offset = "0x31ED1A0", Length = "0xB1")]
	[Token(Token = "0x6000057")]
	public static BackgroundSize ConvertScaleModeToBackgroundSize(ScaleMode scaleMode = 0) { }

	[Address(RVA = "0x31EDE60", Offset = "0x31ED260", Length = "0x3B9")]
	[Token(Token = "0x6000058")]
	public static ScaleMode ResolveUnityBackgroundScaleMode(BackgroundPosition backgroundPositionX, BackgroundPosition backgroundPositionY, BackgroundRepeat backgroundRepeat, BackgroundSize backgroundSize, out bool valid) { }

}

