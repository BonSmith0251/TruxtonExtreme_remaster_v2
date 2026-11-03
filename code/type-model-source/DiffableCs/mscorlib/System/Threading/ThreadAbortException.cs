namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x2000233")]
public sealed class ThreadAbortException : SystemException
{

	[Address(RVA = "0x20C04F0", Offset = "0x20BF8F0", Length = "0x69")]
	[Token(Token = "0x60012F2")]
	private ThreadAbortException() { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x60012F3")]
	internal ThreadAbortException(SerializationInfo info, StreamingContext context) { }

}

