namespace System.Runtime.Serialization;

[Token(Token = "0x20003D6")]
public class SerializationException : SystemException
{
	[Token(Token = "0x4000F22")]
	private static string s_nullMessage; //Field offset: 0x0

	[Address(RVA = "0x1F139F0", Offset = "0x1F12DF0", Length = "0x62")]
	[Token(Token = "0x6001D8A")]
	private static SerializationException() { }

	[Address(RVA = "0x1F13A80", Offset = "0x1F12E80", Length = "0x66")]
	[Token(Token = "0x6001D86")]
	public SerializationException() { }

	[Address(RVA = "0x1F13A60", Offset = "0x1F12E60", Length = "0x1E")]
	[Token(Token = "0x6001D87")]
	public SerializationException(string message) { }

	[Address(RVA = "0x1F13AF0", Offset = "0x1F12EF0", Length = "0x1E")]
	[Token(Token = "0x6001D88")]
	public SerializationException(string message, Exception innerException) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x6001D89")]
	protected SerializationException(SerializationInfo info, StreamingContext context) { }

}

