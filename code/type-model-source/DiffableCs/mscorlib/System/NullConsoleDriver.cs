namespace System;

[Token(Token = "0x20001C1")]
internal class NullConsoleDriver : IConsoleDriver
{
	[Token(Token = "0x4000717")]
	private static readonly ConsoleKeyInfo EmptyConsoleKeyInfo; //Field offset: 0x0

	[Address(RVA = "0x2086860", Offset = "0x2085C60", Length = "0x6E")]
	[Token(Token = "0x6000FF9")]
	private static NullConsoleDriver() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000FF8")]
	public NullConsoleDriver() { }

	[Address(RVA = "0x20867F0", Offset = "0x2085BF0", Length = "0x62")]
	[Token(Token = "0x6000FF7")]
	public override ConsoleKeyInfo ReadKey(bool intercept) { }

}

