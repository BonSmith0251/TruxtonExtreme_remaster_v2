namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005FB")]
internal static class LayoutProcessor
{
	[Token(Token = "0x40015E6")]
	private static ILayoutProcessor s_Processor; //Field offset: 0x0

	[Address(RVA = "0x3323B20", Offset = "0x3322F20", Length = "0xF5")]
	[Token(Token = "0x6002B31")]
	private static LayoutProcessor() { }

	[Address(RVA = "0x33239D0", Offset = "0x3322DD0", Length = "0x145")]
	[Token(Token = "0x6002B30")]
	public static void CalculateLayout(LayoutNode node, float parentWidth, float parentHeight, LayoutDirection parentDirection) { }

}

