namespace System;

[Token(Token = "0x200014D")]
public class UnauthorizedAccessException : SystemException
{

	[Address(RVA = "0x2056780", Offset = "0x2055B80", Length = "0x81")]
	[Token(Token = "0x6000BA4")]
	public UnauthorizedAccessException() { }

	[Address(RVA = "0x2056810", Offset = "0x2055C10", Length = "0x61")]
	[Token(Token = "0x6000BA5")]
	public UnauthorizedAccessException(string message) { }

	[Address(RVA = "0x203CBA0", Offset = "0x203BFA0", Length = "0x74")]
	[Token(Token = "0x6000BA6")]
	protected UnauthorizedAccessException(SerializationInfo info, StreamingContext context) { }

}

