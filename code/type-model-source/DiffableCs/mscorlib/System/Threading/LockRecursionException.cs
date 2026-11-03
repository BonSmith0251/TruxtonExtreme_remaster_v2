namespace System.Threading;

[Token(Token = "0x20001F6")]
public class LockRecursionException : Exception
{

	[Address(RVA = "0x209FD40", Offset = "0x209F140", Length = "0x49")]
	[Token(Token = "0x6001183")]
	public LockRecursionException() { }

	[Address(RVA = "0x209FD90", Offset = "0x209F190", Length = "0x59")]
	[Token(Token = "0x6001184")]
	public LockRecursionException(string message) { }

	[Address(RVA = "0x209FCC0", Offset = "0x209F0C0", Length = "0x74")]
	[Token(Token = "0x6001185")]
	protected LockRecursionException(SerializationInfo info, StreamingContext context) { }

}

