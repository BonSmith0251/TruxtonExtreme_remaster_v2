namespace Microsoft.Win32;

[Token(Token = "0x200007C")]
internal static class Win32Native
{

	[Address(RVA = "0x1E8AE20", Offset = "0x1E8A220", Length = "0x47")]
	[Token(Token = "0x6000210")]
	public static string GetMessage(int hr) { }

	[Address(RVA = "0x1E8AE70", Offset = "0x1E8A270", Length = "0xAF")]
	[Token(Token = "0x6000211")]
	public static int MakeHRFromErrorCode(int errorCode) { }

}

