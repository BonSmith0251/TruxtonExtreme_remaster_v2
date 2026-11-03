namespace System.Security;

[Token(Token = "0x20002CB")]
public sealed class XmlSyntaxException : SystemException
{

	[Address(RVA = "0x1EB5540", Offset = "0x1EB4940", Length = "0x5D7")]
	[Token(Token = "0x600177C")]
	public XmlSyntaxException() { }

	[Address(RVA = "0x1EB5540", Offset = "0x1EB4940", Length = "0x5D7")]
	[Token(Token = "0x600177D")]
	public XmlSyntaxException(int lineNumber) { }

	[Address(RVA = "0x1EB5540", Offset = "0x1EB4940", Length = "0x5D7")]
	[Token(Token = "0x600177E")]
	public XmlSyntaxException(int lineNumber, string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x600177F")]
	private XmlSyntaxException(SerializationInfo info, StreamingContext context) { }

}

