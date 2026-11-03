namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x2000247")]
public sealed class ReaderWriterLock : CriticalFinalizerObject
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A5A")]
	private int seq_num; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A5B")]
	private int state; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A5C")]
	private int readers; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000A5D")]
	private int writer_lock_owner; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A5E")]
	private LockQueue writer_queue; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A5F")]
	private Hashtable reader_locks; //Field offset: 0x28

	[Address(RVA = "0x20B35A0", Offset = "0x20B29A0", Length = "0xDD")]
	[Token(Token = "0x600136B")]
	public ReaderWriterLock() { }

	[Address(RVA = "0x20B3390", Offset = "0x20B2790", Length = "0xE")]
	[Token(Token = "0x600136D")]
	public void AcquireWriterLock(int millisecondsTimeout) { }

	[Address(RVA = "0x20B3200", Offset = "0x20B2600", Length = "0x181")]
	[Token(Token = "0x600136E")]
	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	[Address(RVA = "0x20B33A0", Offset = "0x20B27A0", Length = "0x32")]
	[Token(Token = "0x600136C")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x20B33E0", Offset = "0x20B27E0", Length = "0x2A")]
	[Token(Token = "0x6001371")]
	private bool HasWriterLock() { }

	[Address(RVA = "0x20B3410", Offset = "0x20B2810", Length = "0x12D")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600136F")]
	public void ReleaseWriterLock() { }

	[Address(RVA = "0x20B3540", Offset = "0x20B2940", Length = "0x54")]
	[Token(Token = "0x6001370")]
	private void ReleaseWriterLock(int releaseCount) { }

}

