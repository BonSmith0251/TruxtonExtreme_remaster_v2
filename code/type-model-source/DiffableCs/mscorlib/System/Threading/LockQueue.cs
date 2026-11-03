namespace System.Threading;

[Token(Token = "0x2000244")]
internal class LockQueue
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A58")]
	private ReaderWriterLock rwlock; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A59")]
	private int lockCount; //Field offset: 0x18

	[Token(Token = "0x170001C6")]
	public bool IsEmpty
	{
		[Address(RVA = "0x20B2890", Offset = "0x20B1C90", Length = "0x91")]
		[Token(Token = "0x6001362")]
		 get { } //Length: 145
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6001360")]
	public LockQueue(ReaderWriterLock rwlock) { }

	[Address(RVA = "0x20B2890", Offset = "0x20B1C90", Length = "0x91")]
	[Token(Token = "0x6001362")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x20B26D0", Offset = "0x20B1AD0", Length = "0x84")]
	[Token(Token = "0x6001363")]
	public void Pulse() { }

	[Address(RVA = "0x20B2760", Offset = "0x20B1B60", Length = "0x125")]
	[Token(Token = "0x6001361")]
	public bool Wait(int timeout) { }

}

