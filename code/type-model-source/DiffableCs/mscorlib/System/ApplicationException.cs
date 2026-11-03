namespace System;

[Token(Token = "0x20000B0")]
public class ApplicationException : Exception
{

	[Address(RVA = "0x1F8BCF0", Offset = "0x1F8B0F0", Length = "0x65")]
	[Token(Token = "0x60003D9")]
	public ApplicationException() { }

	[Address(RVA = "0x1F8BDE0", Offset = "0x1F8B1E0", Length = "0x61")]
	[Token(Token = "0x60003DA")]
	public ApplicationException(string message) { }

	[Address(RVA = "0x1F8BD60", Offset = "0x1F8B160", Length = "0x71")]
	[Token(Token = "0x60003DB")]
	public ApplicationException(string message, Exception innerException) { }

	[Address(RVA = "0x1F8BE50", Offset = "0x1F8B250", Length = "0x74")]
	[Token(Token = "0x60003DC")]
	protected ApplicationException(SerializationInfo info, StreamingContext context) { }

}

