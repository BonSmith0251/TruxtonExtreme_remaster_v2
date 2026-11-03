namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x2000234")]
public class ThreadInterruptedException : SystemException
{

	[Address(RVA = "0x20C0560", Offset = "0x20BF960", Length = "0x69")]
	[Token(Token = "0x60012F4")]
	public ThreadInterruptedException() { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60012F5")]
	protected ThreadInterruptedException(SerializationInfo info, StreamingContext context) { }

}

