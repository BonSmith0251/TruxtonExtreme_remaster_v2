namespace System;

[Token(Token = "0x2000118")]
public class NotSupportedException : SystemException
{

	[Address(RVA = "0x202CE70", Offset = "0x202C270", Length = "0x44")]
	[Token(Token = "0x60008D1")]
	public NotSupportedException() { }

	[Address(RVA = "0x202CEE0", Offset = "0x202C2E0", Length = "0x1E")]
	[Token(Token = "0x60008D2")]
	public NotSupportedException(string message) { }

	[Address(RVA = "0x202CEC0", Offset = "0x202C2C0", Length = "0x1E")]
	[Token(Token = "0x60008D3")]
	public NotSupportedException(string message, Exception innerException) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60008D4")]
	protected NotSupportedException(SerializationInfo info, StreamingContext context) { }

}

