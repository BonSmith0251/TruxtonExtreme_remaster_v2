namespace System;

[Token(Token = "0x2000115")]
public sealed class MulticastNotSupportedException : SystemException
{

	[Address(RVA = "0x202CD90", Offset = "0x202C190", Length = "0x44")]
	[Token(Token = "0x60008CA")]
	public MulticastNotSupportedException() { }

	[Address(RVA = "0x202CDE0", Offset = "0x202C1E0", Length = "0x1E")]
	[Token(Token = "0x60008CB")]
	public MulticastNotSupportedException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60008CC")]
	internal MulticastNotSupportedException(SerializationInfo info, StreamingContext context) { }

}

