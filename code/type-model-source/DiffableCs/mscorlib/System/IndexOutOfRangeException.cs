namespace System;

[Token(Token = "0x20000FE")]
public sealed class IndexOutOfRangeException : SystemException
{

	[Address(RVA = "0x2025EC0", Offset = "0x20252C0", Length = "0x44")]
	[Token(Token = "0x60007B6")]
	public IndexOutOfRangeException() { }

	[Address(RVA = "0x2025F10", Offset = "0x2025310", Length = "0x1E")]
	[Token(Token = "0x60007B7")]
	public IndexOutOfRangeException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60007B8")]
	internal IndexOutOfRangeException(SerializationInfo info, StreamingContext context) { }

}

