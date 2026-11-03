namespace System;

[Token(Token = "0x20001A9")]
internal static class ConsoleDriver
{
	[Token(Token = "0x40006E2")]
	internal static IConsoleDriver driver; //Field offset: 0x0
	[Token(Token = "0x40006E3")]
	private static bool is_console; //Field offset: 0x8
	[Token(Token = "0x40006E4")]
	private static bool called_isatty; //Field offset: 0x9

	[Token(Token = "0x1700015C")]
	public static bool IsConsole
	{
		[Address(RVA = "0x207B4B0", Offset = "0x207A8B0", Length = "0x15A")]
		[Token(Token = "0x6000F82")]
		 get { } //Length: 346
	}

	[Address(RVA = "0x207B3D0", Offset = "0x207A7D0", Length = "0xD7")]
	[Token(Token = "0x6000F7D")]
	private static ConsoleDriver() { }

	[Address(RVA = "0x207B1B0", Offset = "0x207A5B0", Length = "0x30")]
	[Token(Token = "0x6000F7E")]
	private static IConsoleDriver CreateNullConsoleDriver() { }

	[Address(RVA = "0x207B1E0", Offset = "0x207A5E0", Length = "0x54")]
	[Token(Token = "0x6000F80")]
	private static IConsoleDriver CreateTermInfoDriver(string term) { }

	[Address(RVA = "0x207B240", Offset = "0x207A640", Length = "0x44")]
	[Token(Token = "0x6000F7F")]
	private static IConsoleDriver CreateWindowsConsoleDriver() { }

	[Address(RVA = "0x207B4B0", Offset = "0x207A8B0", Length = "0x15A")]
	[Token(Token = "0x6000F82")]
	public static bool get_IsConsole() { }

	[Address(RVA = "0x206A120", Offset = "0x2069520", Length = "0x5")]
	[Token(Token = "0x6000F84")]
	internal static int InternalKeyAvailable(int ms_timeout) { }

	[Address(RVA = "0x207B290", Offset = "0x207A690", Length = "0x5")]
	[Token(Token = "0x6000F83")]
	private static bool Isatty(IntPtr handle) { }

	[Address(RVA = "0x207B2A0", Offset = "0x207A6A0", Length = "0x108")]
	[Token(Token = "0x6000F81")]
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	[Address(RVA = "0x207B3B0", Offset = "0x207A7B0", Length = "0x5")]
	[Token(Token = "0x6000F86")]
	internal static bool SetEcho(bool wantEcho) { }

	[Address(RVA = "0x207B3C0", Offset = "0x207A7C0", Length = "0x5")]
	[Token(Token = "0x6000F85")]
	internal static bool TtySetup(string keypadXmit, string teardown, out Byte[] control_characters, out Int32* address) { }

}

