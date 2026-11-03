namespace System.Collections.Generic;

[Token(Token = "0x20005FC")]
public class KeyNotFoundException : SystemException
{

	[Address(RVA = "0x1FC8F40", Offset = "0x1FC8340", Length = "0x44")]
	[Token(Token = "0x6002CA0")]
	public KeyNotFoundException() { }

	[Address(RVA = "0x1FC8F90", Offset = "0x1FC8390", Length = "0x1E")]
	[Token(Token = "0x6002CA1")]
	public KeyNotFoundException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x6002CA2")]
	protected KeyNotFoundException(SerializationInfo info, StreamingContext context) { }

}

