namespace System.Threading;

[Token(Token = "0x2000200")]
public class WaitHandleCannotBeOpenedException : ApplicationException
{

	[Address(RVA = "0x20A9970", Offset = "0x20A8D70", Length = "0x44")]
	[Token(Token = "0x6001196")]
	public WaitHandleCannotBeOpenedException() { }

	[Address(RVA = "0x20A99C0", Offset = "0x20A8DC0", Length = "0x1E")]
	[Token(Token = "0x6001197")]
	public WaitHandleCannotBeOpenedException(string message) { }

	[Address(RVA = "0x1F5ED10", Offset = "0x1F5E110", Length = "0x1F")]
	[Token(Token = "0x6001198")]
	protected WaitHandleCannotBeOpenedException(SerializationInfo info, StreamingContext context) { }

}

