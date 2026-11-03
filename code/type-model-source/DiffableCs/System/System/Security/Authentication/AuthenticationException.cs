namespace System.Security.Authentication;

[Token(Token = "0x2000112")]
public class AuthenticationException : SystemException
{

	[Address(RVA = "0x262C980", Offset = "0x262BD80", Length = "0x46")]
	[Token(Token = "0x600068B")]
	public AuthenticationException() { }

	[Address(RVA = "0x1EE9360", Offset = "0x1EE8760", Length = "0x8")]
	[Token(Token = "0x600068C")]
	public AuthenticationException(string message) { }

	[Address(RVA = "0x1EE9350", Offset = "0x1EE8750", Length = "0x8")]
	[Token(Token = "0x600068D")]
	public AuthenticationException(string message, Exception innerException) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x600068E")]
	protected AuthenticationException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

