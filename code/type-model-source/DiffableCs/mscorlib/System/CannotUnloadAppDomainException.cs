namespace System;

[Token(Token = "0x2000168")]
public class CannotUnloadAppDomainException : SystemException
{

	[Address(RVA = "0x2042340", Offset = "0x2041740", Length = "0x81")]
	[Token(Token = "0x6000C91")]
	public CannotUnloadAppDomainException() { }

	[Address(RVA = "0x20422D0", Offset = "0x20416D0", Length = "0x61")]
	[Token(Token = "0x6000C92")]
	public CannotUnloadAppDomainException(string message) { }

	[Address(RVA = "0x203CBA0", Offset = "0x203BFA0", Length = "0x74")]
	[Token(Token = "0x6000C93")]
	protected CannotUnloadAppDomainException(SerializationInfo info, StreamingContext context) { }

}

