namespace System;

[Token(Token = "0x200010E")]
public class MemberAccessException : SystemException
{

	[Address(RVA = "0x202B4F0", Offset = "0x202A8F0", Length = "0x44")]
	[Token(Token = "0x6000892")]
	public MemberAccessException() { }

	[Address(RVA = "0x202B540", Offset = "0x202A940", Length = "0x1E")]
	[Token(Token = "0x6000893")]
	public MemberAccessException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x6000894")]
	protected MemberAccessException(SerializationInfo info, StreamingContext context) { }

}

