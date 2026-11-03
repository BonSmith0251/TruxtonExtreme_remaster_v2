namespace System.Threading;

[ComVisible(False)]
[DebuggerDisplay("IsHeld = {IsHeld}")]
[DebuggerTypeProxy(typeof(SystemThreading_SpinLockDebugView))]
[Token(Token = "0x2000219")]
public struct SpinLock
{
	[Token(Token = "0x200021A")]
	public class SystemThreading_SpinLockDebugView
	{

	}

	[Token(Token = "0x40009E4")]
	private static int MAXIMUM_WAITERS; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009E3")]
	private int m_owner; //Field offset: 0x0

	[Token(Token = "0x170001A2")]
	public bool IsHeldByCurrentThread
	{
		[Address(RVA = "0x20A5450", Offset = "0x20A4850", Length = "0xD5")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x6001230")]
		 get { } //Length: 213
	}

	[Token(Token = "0x170001A3")]
	public bool IsThreadOwnerTrackingEnabled
	{
		[Address(RVA = "0x20A5530", Offset = "0x20A4930", Length = "0x1C")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x6001231")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x20A53D0", Offset = "0x20A47D0", Length = "0x39")]
	[Token(Token = "0x6001232")]
	private static SpinLock() { }

	[Address(RVA = "0x20A5410", Offset = "0x20A4810", Length = "0x3A")]
	[Token(Token = "0x6001227")]
	public SpinLock(bool enableThreadOwnerTracking) { }

	[Address(RVA = "0x20A4A70", Offset = "0x20A3E70", Length = "0x496")]
	[Token(Token = "0x600122A")]
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	[Address(RVA = "0x20A4840", Offset = "0x20A3C40", Length = "0x223")]
	[Token(Token = "0x600122C")]
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[Address(RVA = "0x20A4F10", Offset = "0x20A4310", Length = "0xD4")]
	[Token(Token = "0x600122B")]
	private void DecrementWaiters() { }

	[Address(RVA = "0x20A4FF0", Offset = "0x20A43F0", Length = "0xAF")]
	[Token(Token = "0x6001228")]
	public void Enter(ref bool lockTaken) { }

	[Address(RVA = "0x20A5270", Offset = "0x20A4670", Length = "0x87")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600122D")]
	public void Exit() { }

	[Address(RVA = "0x20A51E0", Offset = "0x20A45E0", Length = "0x8E")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600122E")]
	public void Exit(bool useMemoryBarrier) { }

	[Address(RVA = "0x20A50A0", Offset = "0x20A44A0", Length = "0x13B")]
	[Token(Token = "0x600122F")]
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[Address(RVA = "0x20A5450", Offset = "0x20A4850", Length = "0xD5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001230")]
	public bool get_IsHeldByCurrentThread() { }

	[Address(RVA = "0x20A5530", Offset = "0x20A4930", Length = "0x1C")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001231")]
	public bool get_IsThreadOwnerTrackingEnabled() { }

	[Address(RVA = "0x20A5300", Offset = "0x20A4700", Length = "0xC2")]
	[Token(Token = "0x6001229")]
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

}

