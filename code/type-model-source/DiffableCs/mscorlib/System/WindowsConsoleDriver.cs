namespace System;

[Token(Token = "0x20001E6")]
internal class WindowsConsoleDriver : IConsoleDriver
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000950")]
	private IntPtr inputHandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000951")]
	private IntPtr outputHandle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000952")]
	private short defaultAttribute; //Field offset: 0x20

	[Address(RVA = "0x20AA2F0", Offset = "0x20A96F0", Length = "0xE8")]
	[Token(Token = "0x60010D6")]
	public WindowsConsoleDriver() { }

	[Address(RVA = "0x20A9E10", Offset = "0x20A9210", Length = "0x93")]
	[Token(Token = "0x60010DA")]
	private static bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

	[Address(RVA = "0x20A9EB0", Offset = "0x20A92B0", Length = "0x81")]
	[Token(Token = "0x60010D9")]
	private static IntPtr GetStdHandle(Handles handle) { }

	[Address(RVA = "0x20A9F40", Offset = "0x20A9340", Length = "0x23")]
	[Token(Token = "0x60010D8")]
	private static bool IsModifierKey(short virtualKeyCode) { }

	[Address(RVA = "0x20A9F70", Offset = "0x20A9370", Length = "0x129")]
	[Token(Token = "0x60010DB")]
	private static bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }

	[Address(RVA = "0x20AA0A0", Offset = "0x20A94A0", Length = "0x241")]
	[Token(Token = "0x60010D7")]
	public override ConsoleKeyInfo ReadKey(bool intercept) { }

}

