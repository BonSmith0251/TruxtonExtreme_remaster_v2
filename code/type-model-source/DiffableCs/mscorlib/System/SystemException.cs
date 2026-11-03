namespace System;

[Token(Token = "0x200013B")]
public class SystemException : Exception
{

	[Address(RVA = "0x204BF80", Offset = "0x204B380", Length = "0x65")]
	[Token(Token = "0x6000A40")]
	public SystemException() { }

	[Address(RVA = "0x204BFF0", Offset = "0x204B3F0", Length = "0x61")]
	[Token(Token = "0x6000A41")]
	public SystemException(string message) { }

	[Address(RVA = "0x204BF00", Offset = "0x204B300", Length = "0x71")]
	[Token(Token = "0x6000A42")]
	public SystemException(string message, Exception innerException) { }

	[Address(RVA = "0x203CBA0", Offset = "0x203BFA0", Length = "0x74")]
	[Token(Token = "0x6000A43")]
	protected SystemException(SerializationInfo info, StreamingContext context) { }

}

