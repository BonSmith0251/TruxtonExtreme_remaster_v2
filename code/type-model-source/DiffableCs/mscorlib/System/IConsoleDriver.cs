namespace System;

[Token(Token = "0x20001B7")]
internal interface IConsoleDriver
{

	[Token(Token = "0x6000FB1")]
	public ConsoleKeyInfo ReadKey(bool intercept) { }

}

