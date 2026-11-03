namespace System;

[Token(Token = "0x2000133")]
public sealed class StackOverflowException : SystemException
{

	[Address(RVA = "0x204B7B0", Offset = "0x204ABB0", Length = "0x81")]
	[Token(Token = "0x6000A18")]
	public StackOverflowException() { }

	[Address(RVA = "0x204B840", Offset = "0x204AC40", Length = "0x61")]
	[Token(Token = "0x6000A19")]
	public StackOverflowException(string message) { }

	[Address(RVA = "0x203CBA0", Offset = "0x203BFA0", Length = "0x74")]
	[Token(Token = "0x6000A1A")]
	internal StackOverflowException(SerializationInfo info, StreamingContext context) { }

}

