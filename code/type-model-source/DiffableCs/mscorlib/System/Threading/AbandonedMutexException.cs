namespace System.Threading;

[Token(Token = "0x20001EF")]
public class AbandonedMutexException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000982")]
	private int _mutexIndex; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000983")]
	private Mutex _mutex; //Field offset: 0x98

	[Address(RVA = "0x2093090", Offset = "0x2092490", Length = "0x4E")]
	[Token(Token = "0x6001174")]
	public AbandonedMutexException() { }

	[Address(RVA = "0x20930E0", Offset = "0x20924E0", Length = "0xC0")]
	[Token(Token = "0x6001175")]
	public AbandonedMutexException(int location, WaitHandle handle) { }

	[Address(RVA = "0x20931A0", Offset = "0x20925A0", Length = "0x29")]
	[Token(Token = "0x6001176")]
	protected AbandonedMutexException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x2093000", Offset = "0x2092400", Length = "0x81")]
	[Token(Token = "0x6001177")]
	private void SetupException(int location, WaitHandle handle) { }

}

