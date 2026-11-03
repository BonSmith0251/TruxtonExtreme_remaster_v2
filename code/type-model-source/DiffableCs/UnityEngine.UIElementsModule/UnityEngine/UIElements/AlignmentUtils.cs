namespace UnityEngine.UIElements;

[Extension]
[Token(Token = "0x2000005")]
public static class AlignmentUtils
{

	[Address(RVA = "0x31ED510", Offset = "0x31EC910", Length = "0x27")]
	[Token(Token = "0x6000005")]
	internal static float CeilToPixelGrid(float v, float pixelsPerPoint, float offset = -0.02) { }

	[Address(RVA = "0x31ED540", Offset = "0x31EC940", Length = "0x51")]
	[Extension]
	[Token(Token = "0x6000006")]
	public static float RoundToPanelPixelSize(VisualElement ve, float v) { }

	[Address(RVA = "0x31ED5A0", Offset = "0x31EC9A0", Length = "0x2F")]
	[Token(Token = "0x6000004")]
	internal static float RoundToPixelGrid(float v, float pixelsPerPoint, float offset = 0.02) { }

}

