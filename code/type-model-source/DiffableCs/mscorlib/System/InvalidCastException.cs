namespace System;

[Token(Token = "0x2000103")]
public class InvalidCastException : SystemException
{

	[Address(RVA = "0x2028F40", Offset = "0x2028340", Length = "0x44")]
	[Token(Token = "0x600081B")]
	public InvalidCastException() { }

	[Address(RVA = "0x2028F90", Offset = "0x2028390", Length = "0x1E")]
	[Token(Token = "0x600081C")]
	public InvalidCastException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x600081D")]
	protected InvalidCastException(SerializationInfo info, StreamingContext context) { }

}

