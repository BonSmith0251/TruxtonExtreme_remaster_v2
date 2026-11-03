namespace System;

[Token(Token = "0x20000F5")]
public interface ICustomFormatter
{

	[Token(Token = "0x60007AB")]
	public string Format(string format, object arg, IFormatProvider formatProvider) { }

}

