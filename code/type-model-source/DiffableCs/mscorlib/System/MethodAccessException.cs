namespace System;

[Token(Token = "0x2000112")]
public class MethodAccessException : MemberAccessException
{

	[Address(RVA = "0x202CB40", Offset = "0x202BF40", Length = "0x44")]
	[Token(Token = "0x60008C2")]
	public MethodAccessException() { }

	[Address(RVA = "0x202CB90", Offset = "0x202BF90", Length = "0x1E")]
	[Token(Token = "0x60008C3")]
	public MethodAccessException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60008C4")]
	protected MethodAccessException(SerializationInfo info, StreamingContext context) { }

}

