namespace System.Threading;

[Token(Token = "0x20001FE")]
public class ThreadStateException : SystemException
{

	[Address(RVA = "0x20A6310", Offset = "0x20A5710", Length = "0x44")]
	[Token(Token = "0x6001192")]
	public ThreadStateException() { }

	[Address(RVA = "0x20A62F0", Offset = "0x20A56F0", Length = "0x1E")]
	[Token(Token = "0x6001193")]
	public ThreadStateException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x6001194")]
	protected ThreadStateException(SerializationInfo info, StreamingContext context) { }

}

