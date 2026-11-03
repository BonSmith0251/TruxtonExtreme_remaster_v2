namespace System.IO;

[Token(Token = "0x200065A")]
public class DriveNotFoundException : IOException
{

	[Address(RVA = "0x1FD4CD0", Offset = "0x1FD40D0", Length = "0x44")]
	[Token(Token = "0x6002F5B")]
	public DriveNotFoundException() { }

	[Address(RVA = "0x1FD41B0", Offset = "0x1FD35B0", Length = "0x1E")]
	[Token(Token = "0x6002F5C")]
	public DriveNotFoundException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x6002F5D")]
	protected DriveNotFoundException(SerializationInfo info, StreamingContext context) { }

}

