namespace System.Text;

[Token(Token = "0x20002C8")]
internal static class EncodingHelper
{
	[Token(Token = "0x4000C09")]
	private static Encoding utf8EncodingWithoutMarkers; //Field offset: 0x0
	[Token(Token = "0x4000C0A")]
	private static readonly object lockobj; //Field offset: 0x8
	[Token(Token = "0x4000C0B")]
	private static Assembly i18nAssembly; //Field offset: 0x10
	[Token(Token = "0x4000C0C")]
	private static bool i18nDisabled; //Field offset: 0x18

	[Token(Token = "0x1700024D")]
	internal static Encoding UTF8Unmarked
	{
		[Address(RVA = "0x1EA1910", Offset = "0x1EA0D10", Length = "0x1FC")]
		[Token(Token = "0x6001774")]
		internal get { } //Length: 508
	}

	[Address(RVA = "0x1EA1890", Offset = "0x1EA0C90", Length = "0x78")]
	[Token(Token = "0x6001778")]
	private static EncodingHelper() { }

	[Address(RVA = "0x1EA1910", Offset = "0x1EA0D10", Length = "0x1FC")]
	[Token(Token = "0x6001774")]
	internal static Encoding get_UTF8Unmarked() { }

	[Address(RVA = "0x1EA11F0", Offset = "0x1EA05F0", Length = "0x74")]
	[Token(Token = "0x6001776")]
	internal static Encoding GetDefaultEncoding() { }

	[Address(RVA = "0x1EA1300", Offset = "0x1EA0700", Length = "0x5")]
	[Token(Token = "0x6001775")]
	internal static string InternalCodePage(ref int code_page) { }

	[Address(RVA = "0x1EA1310", Offset = "0x1EA0710", Length = "0x573")]
	[Token(Token = "0x6001777")]
	internal static object InvokeI18N(string name, Object[] args) { }

}

