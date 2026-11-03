namespace System;

[Token(Token = "0x2000117")]
public class NotImplementedException : SystemException
{

	[Address(RVA = "0x202CE20", Offset = "0x202C220", Length = "0x44")]
	[Token(Token = "0x60008CE")]
	public NotImplementedException() { }

	[Address(RVA = "0x202CE00", Offset = "0x202C200", Length = "0x1E")]
	[Token(Token = "0x60008CF")]
	public NotImplementedException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60008D0")]
	protected NotImplementedException(SerializationInfo info, StreamingContext context) { }

}

