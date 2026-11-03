namespace System;

[Token(Token = "0x2000104")]
public class InvalidOperationException : SystemException
{

	[Address(RVA = "0x2028FB0", Offset = "0x20283B0", Length = "0x44")]
	[Token(Token = "0x600081E")]
	public InvalidOperationException() { }

	[Address(RVA = "0x2029020", Offset = "0x2028420", Length = "0x1E")]
	[Token(Token = "0x600081F")]
	public InvalidOperationException(string message) { }

	[Address(RVA = "0x2029000", Offset = "0x2028400", Length = "0x1E")]
	[Token(Token = "0x6000820")]
	public InvalidOperationException(string message, Exception innerException) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x6000821")]
	protected InvalidOperationException(SerializationInfo info, StreamingContext context) { }

}

