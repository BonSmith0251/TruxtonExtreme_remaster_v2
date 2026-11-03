namespace System;

[Token(Token = "0x20001A6")]
public static class Console
{
	[Token(Token = "0x20001A7")]
	private class WindowsConsole
	{
		[Token(Token = "0x20001A8")]
		private sealed class WindowsCancelHandler : MulticastDelegate
		{

			[Address(RVA = "0xE2C970", Offset = "0xE2BD70", Length = "0xA6")]
			[Token(Token = "0x6000F7B")]
			public WindowsCancelHandler(object object, IntPtr method) { }

			[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
			[Token(Token = "0x6000F7C")]
			public override bool Invoke(int keyCode) { }

		}

		[Token(Token = "0x40006E0")]
		public static bool ctrlHandlerAdded; //Field offset: 0x0
		[Token(Token = "0x40006E1")]
		private static WindowsCancelHandler cancelHandler; //Field offset: 0x8

		[Address(RVA = "0x2092A70", Offset = "0x2091E70", Length = "0x58B")]
		[Token(Token = "0x6000F7A")]
		private static WindowsConsole() { }

		[Address(RVA = "0x2092800", Offset = "0x2091C00", Length = "0x4E")]
		[Token(Token = "0x6000F77")]
		private static bool DoWindowsConsoleCancelEvent(int keyCode) { }

		[Address(RVA = "0x2092850", Offset = "0x2091C50", Length = "0x66")]
		[Token(Token = "0x6000F75")]
		private static int GetConsoleCP() { }

		[Address(RVA = "0x20928C0", Offset = "0x2091CC0", Length = "0x66")]
		[Token(Token = "0x6000F76")]
		private static int GetConsoleOutputCP() { }

		[Address(RVA = "0x2092930", Offset = "0x2091D30", Length = "0x97")]
		[Token(Token = "0x6000F78")]
		public static int GetInputCodePage() { }

		[Address(RVA = "0x20929D0", Offset = "0x2091DD0", Length = "0x97")]
		[Token(Token = "0x6000F79")]
		public static int GetOutputCodePage() { }

	}

	[Token(Token = "0x40006D9")]
	internal static TextWriter stdout; //Field offset: 0x0
	[Token(Token = "0x40006DA")]
	private static TextWriter stderr; //Field offset: 0x8
	[Token(Token = "0x40006DB")]
	private static TextReader stdin; //Field offset: 0x10
	[Token(Token = "0x40006DC")]
	internal static bool IsRunningOnAndroid; //Field offset: 0x18
	[Token(Token = "0x40006DD")]
	private static Encoding inputEncoding; //Field offset: 0x20
	[Token(Token = "0x40006DE")]
	private static Encoding outputEncoding; //Field offset: 0x28
	[Token(Token = "0x40006DF")]
	private static ConsoleCancelEventHandler cancel_event; //Field offset: 0x30

	[Token(Token = "0x17000158")]
	public static TextWriter Error
	{
		[Address(RVA = "0x207C6C0", Offset = "0x207BAC0", Length = "0x4F")]
		[Token(Token = "0x6000F66")]
		 get { } //Length: 79
	}

	[Token(Token = "0x1700015A")]
	public static Encoding InputEncoding
	{
		[Address(RVA = "0x207C710", Offset = "0x207BB10", Length = "0x4F")]
		[Token(Token = "0x6000F70")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000159")]
	public static TextWriter Out
	{
		[Address(RVA = "0x207C760", Offset = "0x207BB60", Length = "0x4E")]
		[Token(Token = "0x6000F67")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700015B")]
	public static Encoding OutputEncoding
	{
		[Address(RVA = "0x207C7B0", Offset = "0x207BBB0", Length = "0x4F")]
		[Token(Token = "0x6000F71")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x207C440", Offset = "0x207B840", Length = "0x280")]
	[Token(Token = "0x6000F64")]
	private static Console() { }

	[Address(RVA = "0x207B610", Offset = "0x207AA10", Length = "0x17C")]
	[Token(Token = "0x6000F74")]
	private static void DoConsoleCancelEvent() { }

	[Address(RVA = "0x207C6C0", Offset = "0x207BAC0", Length = "0x4F")]
	[Token(Token = "0x6000F66")]
	public static TextWriter get_Error() { }

	[Address(RVA = "0x207C710", Offset = "0x207BB10", Length = "0x4F")]
	[Token(Token = "0x6000F70")]
	public static Encoding get_InputEncoding() { }

	[Address(RVA = "0x207C760", Offset = "0x207BB60", Length = "0x4E")]
	[Token(Token = "0x6000F67")]
	public static TextWriter get_Out() { }

	[Address(RVA = "0x207C7B0", Offset = "0x207BBB0", Length = "0x4F")]
	[Token(Token = "0x6000F71")]
	public static Encoding get_OutputEncoding() { }

	[Address(RVA = "0x207B940", Offset = "0x207AD40", Length = "0xEA")]
	[Token(Token = "0x6000F68")]
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	[Address(RVA = "0x207B790", Offset = "0x207AB90", Length = "0x85")]
	[Token(Token = "0x6000F69")]
	public static Stream OpenStandardError(int bufferSize) { }

	[Address(RVA = "0x207B820", Offset = "0x207AC20", Length = "0x85")]
	[Token(Token = "0x6000F6A")]
	public static Stream OpenStandardInput(int bufferSize) { }

	[Address(RVA = "0x207B8B0", Offset = "0x207ACB0", Length = "0x85")]
	[Token(Token = "0x6000F6B")]
	public static Stream OpenStandardOutput(int bufferSize) { }

	[Address(RVA = "0x207BA30", Offset = "0x207AE30", Length = "0x138")]
	[Token(Token = "0x6000F73")]
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	[Address(RVA = "0x207BB70", Offset = "0x207AF70", Length = "0x162")]
	[Token(Token = "0x6000F72")]
	public static ConsoleKeyInfo ReadKey() { }

	[Address(RVA = "0x207BCE0", Offset = "0x207B0E0", Length = "0xE6")]
	[Token(Token = "0x6000F6C")]
	public static void SetError(TextWriter newError) { }

	[Address(RVA = "0x207BDD0", Offset = "0x207B1D0", Length = "0xE1")]
	[Token(Token = "0x6000F6D")]
	public static void SetOut(TextWriter newOut) { }

	[Address(RVA = "0x207BEC0", Offset = "0x207B2C0", Length = "0x43C")]
	[Token(Token = "0x6000F65")]
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	[Address(RVA = "0x207C3B0", Offset = "0x207B7B0", Length = "0x83")]
	[Token(Token = "0x6000F6E")]
	public static void WriteLine(string format, object arg0) { }

	[Address(RVA = "0x207C300", Offset = "0x207B700", Length = "0xAB")]
	[Token(Token = "0x6000F6F")]
	public static void WriteLine(string format, object arg0, object arg1, object arg2) { }

}

