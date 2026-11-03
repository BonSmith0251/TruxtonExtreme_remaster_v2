namespace System;

[Token(Token = "0x2000119")]
public class NullReferenceException : SystemException
{

	[Address(RVA = "0x202CF20", Offset = "0x202C320", Length = "0x44")]
	[Token(Token = "0x60008D5")]
	public NullReferenceException() { }

	[Address(RVA = "0x202CF00", Offset = "0x202C300", Length = "0x1E")]
	[Token(Token = "0x60008D6")]
	public NullReferenceException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60008D7")]
	protected NullReferenceException(SerializationInfo info, StreamingContext context) { }

}

