namespace System;

[Token(Token = "0x2000160")]
public sealed class ConsoleCancelEventArgs : EventArgs
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004A5")]
	private readonly ConsoleSpecialKey _type; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40004A6")]
	private bool <Cancel>k__BackingField; //Field offset: 0x14

	[Token(Token = "0x17000102")]
	public bool Cancel
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000C57")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x20423D0", Offset = "0x20417D0", Length = "0x58")]
	[Token(Token = "0x6000C56")]
	internal ConsoleCancelEventArgs(ConsoleSpecialKey type) { }

	[Address(RVA = "0x2042430", Offset = "0x2041830", Length = "0x2C")]
	[Token(Token = "0x6000C58")]
	internal ConsoleCancelEventArgs() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000C57")]
	public bool get_Cancel() { }

}

