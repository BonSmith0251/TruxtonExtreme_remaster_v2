namespace KANAI.Kernel;

[Token(Token = "0x2000036")]
public static class TextUtility
{

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x60001BD")]
	public static string GetColorText(string s, string color) { }

	[Address(RVA = "0x1DF18D0", Offset = "0x1DF0CD0", Length = "0x64")]
	[Token(Token = "0x60001C0")]
	public static string GetDec(string tstr) { }

	[Address(RVA = "0x1DF1940", Offset = "0x1DF0D40", Length = "0x59")]
	[Token(Token = "0x60001BC")]
	public static string GetNoBreakText(string s) { }

	[Address(RVA = "0x1DF19A0", Offset = "0x1DF0DA0", Length = "0x8F")]
	[Token(Token = "0x60001BB")]
	public static string GetSafeTagText(string s) { }

	[Address(RVA = "0x1DF1B50", Offset = "0x1DF0F50", Length = "0x36")]
	[Token(Token = "0x60001BE")]
	public static string GetTrimString(string tstr) { }

	[Address(RVA = "0x1DF1A30", Offset = "0x1DF0E30", Length = "0x11A")]
	[Token(Token = "0x60001BF")]
	public static string GetTrimStringEnc(string tstr) { }

}

