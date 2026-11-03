namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002F4")]
public class CryptographicUnexpectedOperationException : CryptographicException
{

	[Address(RVA = "0x1EB6370", Offset = "0x1EB5770", Length = "0x66")]
	[Token(Token = "0x600185D")]
	public CryptographicUnexpectedOperationException() { }

	[Address(RVA = "0x1EB63E0", Offset = "0x1EB57E0", Length = "0x36")]
	[Token(Token = "0x600185E")]
	public CryptographicUnexpectedOperationException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x600185F")]
	protected CryptographicUnexpectedOperationException(SerializationInfo info, StreamingContext context) { }

}

