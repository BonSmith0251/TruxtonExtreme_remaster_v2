namespace System;

[Token(Token = "0x20000B4")]
public class ArithmeticException : SystemException
{

	[Address(RVA = "0x1F8C7E0", Offset = "0x1F8BBE0", Length = "0x44")]
	[Token(Token = "0x60003F0")]
	public ArithmeticException() { }

	[Address(RVA = "0x1F8C830", Offset = "0x1F8BC30", Length = "0x1E")]
	[Token(Token = "0x60003F1")]
	public ArithmeticException(string message) { }

	[Address(RVA = "0x1F8C850", Offset = "0x1F8BC50", Length = "0x1E")]
	[Token(Token = "0x60003F2")]
	public ArithmeticException(string message, Exception innerException) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60003F3")]
	protected ArithmeticException(SerializationInfo info, StreamingContext context) { }

}

