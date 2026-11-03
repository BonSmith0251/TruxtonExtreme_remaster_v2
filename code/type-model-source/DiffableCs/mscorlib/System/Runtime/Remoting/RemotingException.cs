namespace System.Runtime.Remoting;

[ComVisible(True)]
[Token(Token = "0x2000355")]
public class RemotingException : SystemException
{

	[Address(RVA = "0x1EB5540", Offset = "0x1EB4940", Length = "0x5D7")]
	[Token(Token = "0x6001AD8")]
	public RemotingException() { }

	[Address(RVA = "0x1EE9360", Offset = "0x1EE8760", Length = "0x8")]
	[Token(Token = "0x6001AD9")]
	public RemotingException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x6001ADA")]
	protected RemotingException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1EE9350", Offset = "0x1EE8750", Length = "0x8")]
	[Token(Token = "0x6001ADB")]
	public RemotingException(string message, Exception InnerException) { }

}

