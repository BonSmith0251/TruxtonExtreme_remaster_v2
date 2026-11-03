namespace System.Threading;

[Token(Token = "0x200022B")]
public class SynchronizationContext
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A13")]
	private SynchronizationContextProperties _props; //Field offset: 0x10

	[Token(Token = "0x170001B2")]
	public static SynchronizationContext Current
	{
		[Address(RVA = "0x20A5DA0", Offset = "0x20A51A0", Length = "0x39")]
		[Token(Token = "0x600129F")]
		 get { } //Length: 57
	}

	[Token(Token = "0x170001B4")]
	internal static SynchronizationContext CurrentExplicit
	{
		[Address(RVA = "0x20A5DA0", Offset = "0x20A51A0", Length = "0x39")]
		[Token(Token = "0x60012A3")]
		internal get { } //Length: 57
	}

	[Token(Token = "0x170001B3")]
	internal static SynchronizationContext CurrentNoFlow
	{
		[Address(RVA = "0x20A5DE0", Offset = "0x20A51E0", Length = "0x39")]
		[FriendAccessAllowed]
		[Token(Token = "0x60012A0")]
		internal get { } //Length: 57
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001296")]
	public SynchronizationContext() { }

	[Address(RVA = "0x20A5910", Offset = "0x20A4D10", Length = "0x44")]
	[Token(Token = "0x60012A2")]
	public override SynchronizationContext CreateCopy() { }

	[Address(RVA = "0x20A5DA0", Offset = "0x20A51A0", Length = "0x39")]
	[Token(Token = "0x600129F")]
	public static SynchronizationContext get_Current() { }

	[Address(RVA = "0x20A5DA0", Offset = "0x20A51A0", Length = "0x39")]
	[Token(Token = "0x60012A3")]
	internal static SynchronizationContext get_CurrentExplicit() { }

	[Address(RVA = "0x20A5DE0", Offset = "0x20A51E0", Length = "0x39")]
	[FriendAccessAllowed]
	[Token(Token = "0x60012A0")]
	internal static SynchronizationContext get_CurrentNoFlow() { }

	[Address(RVA = "0x20A5960", Offset = "0x20A4D60", Length = "0x1BF")]
	[Token(Token = "0x60012A1")]
	private static SynchronizationContext GetThreadLocalContext() { }

	[Address(RVA = "0x1D63430", Offset = "0x1D62830", Length = "0x7")]
	[Token(Token = "0x6001297")]
	public bool IsWaitNotificationRequired() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600129B")]
	public override void OperationCompleted() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600129A")]
	public override void OperationStarted() { }

	[Address(RVA = "0x20A5B20", Offset = "0x20A4F20", Length = "0x7E")]
	[Token(Token = "0x6001299")]
	public override void Post(SendOrPostCallback d, object state) { }

	[Address(RVA = "0x16C5260", Offset = "0x16C4660", Length = "0x2A")]
	[Token(Token = "0x6001298")]
	public override void Send(SendOrPostCallback d, object state) { }

	[Address(RVA = "0x20A5BA0", Offset = "0x20A4FA0", Length = "0x5A")]
	[Token(Token = "0x600129E")]
	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	[Address(RVA = "0x20A5CB0", Offset = "0x20A50B0", Length = "0xE5")]
	[CLSCompliant(False)]
	[PrePrepareMethod]
	[Token(Token = "0x600129C")]
	public override int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

	[Address(RVA = "0x20A5C00", Offset = "0x20A5000", Length = "0xA3")]
	[CLSCompliant(False)]
	[PrePrepareMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x600129D")]
	protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

}

