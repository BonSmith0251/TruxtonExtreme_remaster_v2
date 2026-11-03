namespace System.Runtime;

[Token(Token = "0x2000342")]
public sealed class AmbiguousImplementationException : Exception
{

	[Address(RVA = "0x1ED6F80", Offset = "0x1ED6380", Length = "0x65")]
	[Token(Token = "0x6001A64")]
	public AmbiguousImplementationException() { }

	[Address(RVA = "0x1ED7070", Offset = "0x1ED6470", Length = "0x61")]
	[Token(Token = "0x6001A65")]
	public AmbiguousImplementationException(string message) { }

	[Address(RVA = "0x1ED6FF0", Offset = "0x1ED63F0", Length = "0x74")]
	[Token(Token = "0x6001A66")]
	private AmbiguousImplementationException(SerializationInfo info, StreamingContext context) { }

}

