namespace Mono.Btls;

[Token(Token = "0x2000075")]
internal static class MonoBtlsError
{

	[Address(RVA = "0x22C38D0", Offset = "0x22C2CD0", Length = "0x65")]
	[Token(Token = "0x60001C1")]
	public static void ClearError() { }

	[Address(RVA = "0x22C3BA0", Offset = "0x22C2FA0", Length = "0xFA")]
	[Token(Token = "0x60001C3")]
	public static int GetError(out string file, out int line) { }

	[Address(RVA = "0x22C3940", Offset = "0x22C2D40", Length = "0x76")]
	[Token(Token = "0x60001C4")]
	public static int GetErrorReason(int error) { }

	[Address(RVA = "0x22C39C0", Offset = "0x22C2DC0", Length = "0x1DE")]
	[Token(Token = "0x60001C2")]
	public static string GetErrorString(int error) { }

	[Address(RVA = "0x22C38D0", Offset = "0x22C2CD0", Length = "0x65")]
	[Token(Token = "0x60001BD")]
	private static void mono_btls_error_clear_error() { }

	[Address(RVA = "0x22C3CA0", Offset = "0x22C30A0", Length = "0x87")]
	[Token(Token = "0x60001BE")]
	private static int mono_btls_error_get_error_line(out IntPtr file, out int line) { }

	[Address(RVA = "0x22C3D30", Offset = "0x22C3130", Length = "0x91")]
	[Token(Token = "0x60001BF")]
	private static void mono_btls_error_get_error_string_n(int error, IntPtr buf, int len) { }

	[Address(RVA = "0x22C3940", Offset = "0x22C2D40", Length = "0x76")]
	[Token(Token = "0x60001C0")]
	private static int mono_btls_error_get_reason(int error) { }

}

