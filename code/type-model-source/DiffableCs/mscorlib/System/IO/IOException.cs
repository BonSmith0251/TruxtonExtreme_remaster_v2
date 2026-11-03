namespace System.IO;

[Token(Token = "0x2000640")]
public class IOException : SystemException
{

	[Address(RVA = "0x1FD9DC0", Offset = "0x1FD91C0", Length = "0x44")]
	[Token(Token = "0x6002E44")]
	public IOException() { }

	[Address(RVA = "0x1FD9DA0", Offset = "0x1FD91A0", Length = "0x1E")]
	[Token(Token = "0x6002E45")]
	public IOException(string message) { }

	[Address(RVA = "0x1F34900", Offset = "0x1F33D00", Length = "0x26")]
	[Token(Token = "0x6002E46")]
	public IOException(string message, int hresult) { }

	[Address(RVA = "0x1FD9E10", Offset = "0x1FD9210", Length = "0x1E")]
	[Token(Token = "0x6002E47")]
	public IOException(string message, Exception innerException) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x6002E48")]
	protected IOException(SerializationInfo info, StreamingContext context) { }

}

