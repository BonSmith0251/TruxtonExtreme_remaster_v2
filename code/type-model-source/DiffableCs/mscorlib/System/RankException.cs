namespace System;

[Token(Token = "0x2000128")]
public class RankException : SystemException
{

	[Address(RVA = "0x2046F80", Offset = "0x2046380", Length = "0x81")]
	[Token(Token = "0x600097F")]
	public RankException() { }

	[Address(RVA = "0x2047010", Offset = "0x2046410", Length = "0x61")]
	[Token(Token = "0x6000980")]
	public RankException(string message) { }

	[Address(RVA = "0x203CBA0", Offset = "0x203BFA0", Length = "0x74")]
	[Token(Token = "0x6000981")]
	protected RankException(SerializationInfo info, StreamingContext context) { }

}

