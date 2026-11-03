namespace System;

[Token(Token = "0x20000CC")]
public class DivideByZeroException : ArithmeticException
{

	[Address(RVA = "0x201FCA0", Offset = "0x201F0A0", Length = "0x44")]
	[Token(Token = "0x600066C")]
	public DivideByZeroException() { }

	[Address(RVA = "0x201FC80", Offset = "0x201F080", Length = "0x1E")]
	[Token(Token = "0x600066D")]
	public DivideByZeroException(string message) { }

	[Address(RVA = "0x1F33BC0", Offset = "0x1F32FC0", Length = "0x1F")]
	[Token(Token = "0x600066E")]
	protected DivideByZeroException(SerializationInfo info, StreamingContext context) { }

}

