namespace System;

[Token(Token = "0x2000105")]
public sealed class InvalidProgramException : SystemException
{

	[Address(RVA = "0x2029040", Offset = "0x2028440", Length = "0x44")]
	[Token(Token = "0x6000822")]
	public InvalidProgramException() { }

	[Address(RVA = "0x2029090", Offset = "0x2028490", Length = "0x1E")]
	[Token(Token = "0x6000823")]
	public InvalidProgramException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x6000824")]
	internal InvalidProgramException(SerializationInfo info, StreamingContext context) { }

}

