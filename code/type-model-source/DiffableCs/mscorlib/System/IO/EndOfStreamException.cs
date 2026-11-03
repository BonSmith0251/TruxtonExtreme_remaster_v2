namespace System.IO;

[Token(Token = "0x2000638")]
public class EndOfStreamException : IOException
{

	[Address(RVA = "0x1FD4D20", Offset = "0x1FD4120", Length = "0x44")]
	[Token(Token = "0x6002E2A")]
	public EndOfStreamException() { }

	[Address(RVA = "0x1FD4D70", Offset = "0x1FD4170", Length = "0x1E")]
	[Token(Token = "0x6002E2B")]
	public EndOfStreamException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x6002E2C")]
	protected EndOfStreamException(SerializationInfo info, StreamingContext context) { }

}

