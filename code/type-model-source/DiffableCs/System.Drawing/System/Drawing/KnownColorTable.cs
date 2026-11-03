namespace System.Drawing;

[Token(Token = "0x2000004")]
internal static class KnownColorTable
{
	[Token(Token = "0x40000B1")]
	private static Int32[] s_colorTable; //Field offset: 0x0
	[Token(Token = "0x40000B2")]
	private static String[] s_colorNameTable; //Field offset: 0x8

	[Address(RVA = "0x23DAC00", Offset = "0x23DA000", Length = "0x45")]
	[Token(Token = "0x6000005")]
	private static void EnsureColorNameTable() { }

	[Address(RVA = "0x23DAC50", Offset = "0x23DA050", Length = "0x44")]
	[Token(Token = "0x6000003")]
	private static void EnsureColorTable() { }

	[Address(RVA = "0x23DACA0", Offset = "0x23DA0A0", Length = "0x2174")]
	[Token(Token = "0x6000006")]
	private static void InitColorNameTable() { }

	[Address(RVA = "0x23DCE20", Offset = "0x23DC220", Length = "0xBF8")]
	[Token(Token = "0x6000004")]
	private static void InitColorTable() { }

	[Address(RVA = "0x23DDA20", Offset = "0x23DCE20", Length = "0x8C")]
	[Token(Token = "0x6000007")]
	public static int KnownColorToArgb(KnownColor color) { }

	[Address(RVA = "0x23DDAB0", Offset = "0x23DCEB0", Length = "0x8F")]
	[Token(Token = "0x6000008")]
	public static string KnownColorToName(KnownColor color) { }

	[Address(RVA = "0x23DDB40", Offset = "0x23DCF40", Length = "0x265")]
	[Token(Token = "0x6000009")]
	private static void UpdateSystemColors(Int32[] colorTable) { }

}

