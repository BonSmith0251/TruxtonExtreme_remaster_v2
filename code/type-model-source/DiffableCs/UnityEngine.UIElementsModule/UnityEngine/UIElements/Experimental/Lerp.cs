namespace UnityEngine.UIElements.Experimental;

[Token(Token = "0x2000660")]
internal static class Lerp
{

	[Address(RVA = "0x304AD60", Offset = "0x304A160", Length = "0x12")]
	[Token(Token = "0x6002D3F")]
	public static float Interpolate(float start, float end, float ratio) { }

	[Address(RVA = "0x3362570", Offset = "0x3361970", Length = "0x93")]
	[Token(Token = "0x6002D40")]
	public static Color Interpolate(Color start, Color end, float ratio) { }

	[Address(RVA = "0x3362610", Offset = "0x3361A10", Length = "0x220")]
	[Token(Token = "0x6002D41")]
	internal static StyleValues Interpolate(StyleValues start, StyleValues end, float ratio) { }

}

