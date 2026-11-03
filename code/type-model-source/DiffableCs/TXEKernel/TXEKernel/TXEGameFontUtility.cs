namespace TXEKernel;

[Token(Token = "0x20000DD")]
public static class TXEGameFontUtility
{
	[Token(Token = "0x4000484")]
	public static readonly string tagBlue; //Field offset: 0x0

	[Address(RVA = "0x2715100", Offset = "0x2714500", Length = "0x62")]
	[Token(Token = "0x60006AE")]
	private static TXEGameFontUtility() { }

	[Address(RVA = "0x2714F20", Offset = "0x2714320", Length = "0x1D4")]
	[Token(Token = "0x60006AD")]
	public static string Convert2TXEFont(string sstrs, string withTag = null) { }

}

