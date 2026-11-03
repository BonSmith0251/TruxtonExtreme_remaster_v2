namespace System;

[Token(Token = "0x200016C")]
public class OutOfMemoryException : SystemException
{

	[Address(RVA = "0x2044790", Offset = "0x2043B90", Length = "0x81")]
	[Token(Token = "0x6000CA6")]
	public OutOfMemoryException() { }

	[Address(RVA = "0x2044820", Offset = "0x2043C20", Length = "0x61")]
	[Token(Token = "0x6000CA7")]
	public OutOfMemoryException(string message) { }

	[Address(RVA = "0x203CBA0", Offset = "0x203BFA0", Length = "0x74")]
	[Token(Token = "0x6000CA8")]
	protected OutOfMemoryException(SerializationInfo info, StreamingContext context) { }

}

