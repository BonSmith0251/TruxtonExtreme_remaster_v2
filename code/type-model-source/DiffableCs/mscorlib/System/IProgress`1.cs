namespace System;

[Token(Token = "0x20000FC")]
public interface IProgress
{

	[Token(Token = "0x60007B4")]
	public void Report(T value) { }

}

