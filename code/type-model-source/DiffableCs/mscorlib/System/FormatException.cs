namespace System;

[Token(Token = "0x20000D6")]
public class FormatException : SystemException
{

	[Address(RVA = "0x20211C0", Offset = "0x20205C0", Length = "0x44")]
	[Token(Token = "0x60006A8")]
	public FormatException() { }

	[Address(RVA = "0x2021180", Offset = "0x2020580", Length = "0x1E")]
	[Token(Token = "0x60006A9")]
	public FormatException(string message) { }

	[Address(RVA = "0x20211A0", Offset = "0x20205A0", Length = "0x1E")]
	[Token(Token = "0x60006AA")]
	public FormatException(string message, Exception innerException) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60006AB")]
	protected FormatException(SerializationInfo info, StreamingContext context) { }

}

