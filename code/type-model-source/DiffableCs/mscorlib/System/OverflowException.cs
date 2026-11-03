namespace System;

[Token(Token = "0x2000122")]
public class OverflowException : ArithmeticException
{

	[Address(RVA = "0x20448B0", Offset = "0x2043CB0", Length = "0x44")]
	[Token(Token = "0x6000956")]
	public OverflowException() { }

	[Address(RVA = "0x2044890", Offset = "0x2043C90", Length = "0x1E")]
	[Token(Token = "0x6000957")]
	public OverflowException(string message) { }

	[Address(RVA = "0x2044900", Offset = "0x2043D00", Length = "0x1E")]
	[Token(Token = "0x6000958")]
	public OverflowException(string message, Exception innerException) { }

	[Address(RVA = "0x1F33BC0", Offset = "0x1F32FC0", Length = "0x1F")]
	[Token(Token = "0x6000959")]
	protected OverflowException(SerializationInfo info, StreamingContext context) { }

}

