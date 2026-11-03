namespace System.Threading;

[Token(Token = "0x20001F9")]
public class SemaphoreFullException : SystemException
{

	[Address(RVA = "0x20A2C00", Offset = "0x20A2000", Length = "0x3C")]
	[Token(Token = "0x6001189")]
	public SemaphoreFullException() { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x600118A")]
	protected SemaphoreFullException(SerializationInfo info, StreamingContext context) { }

}

