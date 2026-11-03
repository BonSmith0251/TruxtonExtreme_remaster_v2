namespace System;

[Token(Token = "0x20000D7")]
public abstract class FormattableString : IFormattable
{

	[Token(Token = "0x1700007F")]
	public abstract int ArgumentCount
	{
		[Token(Token = "0x60006AE")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700007E")]
	public abstract string Format
	{
		[Token(Token = "0x60006AC")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60006B3")]
	protected FormattableString() { }

	[Token(Token = "0x60006AE")]
	public abstract int get_ArgumentCount() { }

	[Token(Token = "0x60006AC")]
	public abstract string get_Format() { }

	[Token(Token = "0x60006AF")]
	public abstract object GetArgument(int index) { }

	[Token(Token = "0x60006AD")]
	public abstract Object[] GetArguments() { }

	[Address(RVA = "0x2021210", Offset = "0x2020610", Length = "0x17")]
	[Token(Token = "0x60006B1")]
	private override string System.IFormattable.ToString(string ignored, IFormatProvider formatProvider) { }

	[Token(Token = "0x60006B0")]
	public abstract string ToString(IFormatProvider formatProvider) { }

	[Address(RVA = "0x2021230", Offset = "0x2020630", Length = "0x60")]
	[Token(Token = "0x60006B2")]
	public virtual string ToString() { }

}

