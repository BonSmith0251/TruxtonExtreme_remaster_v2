namespace System.Threading;

[Token(Token = "0x20001FB")]
public class SynchronizationLockException : SystemException
{

	[Address(RVA = "0x20A5E40", Offset = "0x20A5240", Length = "0x44")]
	[Token(Token = "0x600118D")]
	public SynchronizationLockException() { }

	[Address(RVA = "0x20A5E20", Offset = "0x20A5220", Length = "0x1E")]
	[Token(Token = "0x600118E")]
	public SynchronizationLockException(string message) { }

	[Address(RVA = "0x1EB5520", Offset = "0x1EB4920", Length = "0x1F")]
	[Token(Token = "0x600118F")]
	protected SynchronizationLockException(SerializationInfo info, StreamingContext context) { }

}

