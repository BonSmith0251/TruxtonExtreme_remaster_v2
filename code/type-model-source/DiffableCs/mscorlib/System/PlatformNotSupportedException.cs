namespace System;

[Token(Token = "0x2000126")]
public class PlatformNotSupportedException : NotSupportedException
{

	[Address(RVA = "0x2046710", Offset = "0x2045B10", Length = "0x44")]
	[Token(Token = "0x6000971")]
	public PlatformNotSupportedException() { }

	[Address(RVA = "0x20466F0", Offset = "0x2045AF0", Length = "0x1E")]
	[Token(Token = "0x6000972")]
	public PlatformNotSupportedException(string message) { }

	[Address(RVA = "0x1F33BC0", Offset = "0x1F32FC0", Length = "0x1F")]
	[Token(Token = "0x6000973")]
	protected PlatformNotSupportedException(SerializationInfo info, StreamingContext context) { }

}

