namespace System;

[Token(Token = "0x2000140")]
public class TimeoutException : SystemException
{

	[Address(RVA = "0x204EAC0", Offset = "0x204DEC0", Length = "0x81")]
	[Token(Token = "0x6000A74")]
	public TimeoutException() { }

	[Address(RVA = "0x204EB50", Offset = "0x204DF50", Length = "0x61")]
	[Token(Token = "0x6000A75")]
	public TimeoutException(string message) { }

	[Address(RVA = "0x203CBA0", Offset = "0x203BFA0", Length = "0x74")]
	[Token(Token = "0x6000A76")]
	protected TimeoutException(SerializationInfo info, StreamingContext context) { }

}

