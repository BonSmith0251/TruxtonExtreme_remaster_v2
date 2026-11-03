namespace System.Reflection;

[Token(Token = "0x2000501")]
public class TargetException : ApplicationException
{

	[Address(RVA = "0x1F6DAE0", Offset = "0x1F6CEE0", Length = "0x23")]
	[Token(Token = "0x6002375")]
	public TargetException() { }

	[Address(RVA = "0x1F6DB10", Offset = "0x1F6CF10", Length = "0x21")]
	[Token(Token = "0x6002376")]
	public TargetException(string message) { }

	[Address(RVA = "0x1F6DAC0", Offset = "0x1F6CEC0", Length = "0x1E")]
	[Token(Token = "0x6002377")]
	public TargetException(string message, Exception inner) { }

	[Address(RVA = "0x1F5ED10", Offset = "0x1F5E110", Length = "0x1F")]
	[Token(Token = "0x6002378")]
	protected TargetException(SerializationInfo info, StreamingContext context) { }

}

