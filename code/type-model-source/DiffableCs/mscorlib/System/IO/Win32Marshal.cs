namespace System.IO;

[Token(Token = "0x2000659")]
internal static class Win32Marshal
{

	[Address(RVA = "0x1FECC00", Offset = "0x1FEC000", Length = "0x53")]
	[Token(Token = "0x6002F57")]
	internal static Exception GetExceptionForLastWin32Error(string path = "") { }

	[Address(RVA = "0x1FECC60", Offset = "0x1FEC060", Length = "0x4EE")]
	[Token(Token = "0x6002F58")]
	internal static Exception GetExceptionForWin32Error(int errorCode, string path = "") { }

	[Address(RVA = "0x1FED150", Offset = "0x1FEC550", Length = "0x7")]
	[Token(Token = "0x6002F5A")]
	internal static string GetMessage(int errorCode) { }

	[Address(RVA = "0x1FED160", Offset = "0x1FEC560", Length = "0x35F")]
	[Token(Token = "0x6002F59")]
	internal static int MakeHRFromErrorCode(int errorCode) { }

}

