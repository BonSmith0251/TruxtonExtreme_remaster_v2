namespace System;

[Token(Token = "0x20000FF")]
public sealed class InsufficientExecutionStackException : SystemException
{

	[Address(RVA = "0x2025F30", Offset = "0x2025330", Length = "0x44")]
	[Token(Token = "0x60007B9")]
	public InsufficientExecutionStackException() { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60007BA")]
	internal InsufficientExecutionStackException(SerializationInfo info, StreamingContext context) { }

}

