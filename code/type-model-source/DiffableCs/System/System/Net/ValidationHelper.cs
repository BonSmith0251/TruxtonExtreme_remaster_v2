namespace System.Net;

[Token(Token = "0x200024B")]
internal static class ValidationHelper
{
	[Token(Token = "0x400092E")]
	public static String[] EmptyArray; //Field offset: 0x0
	[Token(Token = "0x400092F")]
	internal static readonly Char[] InvalidMethodChars; //Field offset: 0x8
	[Token(Token = "0x4000930")]
	internal static readonly Char[] InvalidParamChars; //Field offset: 0x10

	[Address(RVA = "0x26ADB40", Offset = "0x26ACF40", Length = "0x130")]
	[Token(Token = "0x6000F78")]
	private static ValidationHelper() { }

	[Address(RVA = "0x26ADB20", Offset = "0x26ACF20", Length = "0x10")]
	[Token(Token = "0x6000F76")]
	public static bool IsBlankString(string stringValue) { }

	[Address(RVA = "0x26ADB30", Offset = "0x26ACF30", Length = "0xF")]
	[Token(Token = "0x6000F75")]
	public static string MakeStringNull(string stringValue) { }

	[Address(RVA = "0x26ACF90", Offset = "0x26AC390", Length = "0x11")]
	[Token(Token = "0x6000F77")]
	public static bool ValidateTcpPort(int port) { }

}

