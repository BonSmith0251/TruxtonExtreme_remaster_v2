namespace System.IO;

[Token(Token = "0x2000643")]
public class PathTooLongException : IOException
{

	[Address(RVA = "0x1FDDC90", Offset = "0x1FDD090", Length = "0x44")]
	[Token(Token = "0x6002E81")]
	public PathTooLongException() { }

	[Address(RVA = "0x1FDDCE0", Offset = "0x1FDD0E0", Length = "0x1E")]
	[Token(Token = "0x6002E82")]
	public PathTooLongException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x6002E83")]
	protected PathTooLongException(SerializationInfo info, StreamingContext context) { }

}

