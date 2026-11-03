namespace UnityEngine;

[Token(Token = "0x20001C3")]
public class MissingReferenceException : Exception
{

	[Address(RVA = "0x3065EE0", Offset = "0x30652E0", Length = "0x65")]
	[Token(Token = "0x600140E")]
	public MissingReferenceException() { }

	[Address(RVA = "0x3065E70", Offset = "0x3065270", Length = "0x61")]
	[Token(Token = "0x600140F")]
	public MissingReferenceException(string message) { }

	[Address(RVA = "0x3065DF0", Offset = "0x30651F0", Length = "0x74")]
	[Token(Token = "0x6001410")]
	protected MissingReferenceException(SerializationInfo info, StreamingContext context) { }

}

