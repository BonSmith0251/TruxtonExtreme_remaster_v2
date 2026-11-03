namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002F3")]
public class CryptographicException : SystemException
{

	[Address(RVA = "0x1EB6290", Offset = "0x1EB5690", Length = "0x56")]
	[Token(Token = "0x6001857")]
	public CryptographicException() { }

	[Address(RVA = "0x1EB62F0", Offset = "0x1EB56F0", Length = "0x26")]
	[Token(Token = "0x6001858")]
	public CryptographicException(string message) { }

	[Address(RVA = "0x1EB61D0", Offset = "0x1EB55D0", Length = "0x8E")]
	[Token(Token = "0x6001859")]
	public CryptographicException(string format, string insert) { }

	[Address(RVA = "0x1EB6260", Offset = "0x1EB5660", Length = "0x26")]
	[Token(Token = "0x600185A")]
	public CryptographicException(string message, Exception inner) { }

	[Address(RVA = "0x1EB6170", Offset = "0x1EB5570", Length = "0x5A")]
	[Token(Token = "0x600185B")]
	public CryptographicException(int hr) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x600185C")]
	protected CryptographicException(SerializationInfo info, StreamingContext context) { }

}

