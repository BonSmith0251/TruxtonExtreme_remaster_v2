namespace System.Reflection;

[Token(Token = "0x20004DC")]
public class CustomAttributeFormatException : FormatException
{

	[Address(RVA = "0x1F33BE0", Offset = "0x1F32FE0", Length = "0x47")]
	[Token(Token = "0x600221F")]
	public CustomAttributeFormatException() { }

	[Address(RVA = "0x1F33C30", Offset = "0x1F33030", Length = "0x21")]
	[Token(Token = "0x6002220")]
	public CustomAttributeFormatException(string message) { }

	[Address(RVA = "0x1F33C60", Offset = "0x1F33060", Length = "0x1E")]
	[Token(Token = "0x6002221")]
	public CustomAttributeFormatException(string message, Exception inner) { }

	[Address(RVA = "0x1F33BC0", Offset = "0x1F32FC0", Length = "0x1F")]
	[Token(Token = "0x6002222")]
	protected CustomAttributeFormatException(SerializationInfo info, StreamingContext context) { }

}

