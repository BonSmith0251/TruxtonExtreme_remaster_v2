namespace System.IO;

[Token(Token = "0x2000637")]
public class DirectoryNotFoundException : IOException
{

	[Address(RVA = "0x1FD4160", Offset = "0x1FD3560", Length = "0x44")]
	[Token(Token = "0x6002E27")]
	public DirectoryNotFoundException() { }

	[Address(RVA = "0x1FD41B0", Offset = "0x1FD35B0", Length = "0x1E")]
	[Token(Token = "0x6002E28")]
	public DirectoryNotFoundException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x6002E29")]
	protected DirectoryNotFoundException(SerializationInfo info, StreamingContext context) { }

}

