namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x2000242")]
public abstract class WaitHandle : MarshalByRefObject, IDisposable
{
	[Token(Token = "0x4000A4C")]
	public const int WaitTimeout = 258; //Field offset: 0x0
	[Token(Token = "0x4000A4D")]
	private const int MAX_WAITHANDLES = 64; //Field offset: 0x0
	[Token(Token = "0x4000A51")]
	private const int WAIT_OBJECT_0 = 0; //Field offset: 0x0
	[Token(Token = "0x4000A52")]
	private const int WAIT_ABANDONED = 128; //Field offset: 0x0
	[Token(Token = "0x4000A53")]
	private const int WAIT_FAILED = 2147483647; //Field offset: 0x0
	[Token(Token = "0x4000A54")]
	private const int ERROR_TOO_MANY_POSTS = 298; //Field offset: 0x0
	[Token(Token = "0x4000A55")]
	private const int ERROR_NOT_OWNED_BY_CALLER = 299; //Field offset: 0x0
	[Token(Token = "0x4000A56")]
	protected static readonly IntPtr InvalidHandle; //Field offset: 0x0
	[Token(Token = "0x4000A57")]
	internal const int MaxWaitHandles = 64; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A4E")]
	private IntPtr waitHandle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A4F")]
	internal SafeWaitHandle safeWaitHandle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A50")]
	internal bool hasThreadAffinity; //Field offset: 0x28

	[Obsolete("Use the SafeWaitHandle property instead.")]
	[Token(Token = "0x170001C4")]
	public override IntPtr Handle
	{
		[Address(RVA = "0x20C6610", Offset = "0x20C5A10", Length = "0xF1")]
		[Token(Token = "0x6001335")]
		 set { } //Length: 241
	}

	[Token(Token = "0x170001C5")]
	public SafeWaitHandle SafeWaitHandle
	{
		[Address(RVA = "0x20C6540", Offset = "0x20C5940", Length = "0xC1")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
		[Token(Token = "0x6001336")]
		 get { } //Length: 193
	}

	[Address(RVA = "0x20C6470", Offset = "0x20C5870", Length = "0x42")]
	[Token(Token = "0x6001347")]
	private static WaitHandle() { }

	[Address(RVA = "0x20C64C0", Offset = "0x20C58C0", Length = "0x7B")]
	[Token(Token = "0x6001333")]
	protected WaitHandle() { }

	[Address(RVA = "0x20C52C0", Offset = "0x20C46C0", Length = "0x61")]
	[Token(Token = "0x6001341")]
	public override void Close() { }

	[Address(RVA = "0x20C5330", Offset = "0x20C4730", Length = "0x61")]
	[Token(Token = "0x6001343")]
	public override void Dispose() { }

	[Address(RVA = "0x20C53A0", Offset = "0x20C47A0", Length = "0x43")]
	[Token(Token = "0x6001342")]
	protected override void Dispose(bool explicitDisposing) { }

	[Address(RVA = "0x20C6540", Offset = "0x20C5940", Length = "0xC1")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x6001336")]
	public SafeWaitHandle get_SafeWaitHandle() { }

	[Address(RVA = "0x20C53F0", Offset = "0x20C47F0", Length = "0x74")]
	[Token(Token = "0x6001334")]
	private void Init() { }

	[Address(RVA = "0x20C5470", Offset = "0x20C4870", Length = "0x111")]
	[Token(Token = "0x600133C")]
	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	[Address(RVA = "0x20C6610", Offset = "0x20C5A10", Length = "0xF1")]
	[Token(Token = "0x6001335")]
	public override void set_Handle(IntPtr value) { }

	[Address(RVA = "0x20C5590", Offset = "0x20C4990", Length = "0x42")]
	[Token(Token = "0x6001337")]
	internal void SetHandleInternal(SafeWaitHandle handle) { }

	[Address(RVA = "0x20C55E0", Offset = "0x20C49E0", Length = "0x52")]
	[Token(Token = "0x6001340")]
	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	[Address(RVA = "0x20C5640", Offset = "0x20C4A40", Length = "0x3E")]
	[Token(Token = "0x600133F")]
	private static void ThrowAbandonedMutexException() { }

	[Address(RVA = "0x20C6460", Offset = "0x20C5860", Length = "0x5")]
	[Token(Token = "0x6001346")]
	internal static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	[Address(RVA = "0x20C5680", Offset = "0x20C4A80", Length = "0x111")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x600133E")]
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	[Address(RVA = "0x20C57A0", Offset = "0x20C4BA0", Length = "0x3D8")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x600133D")]
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	[Address(RVA = "0x20C5B80", Offset = "0x20C4F80", Length = "0x38D")]
	[Token(Token = "0x6001345")]
	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	[Address(RVA = "0x20C6110", Offset = "0x20C5510", Length = "0x17")]
	[Token(Token = "0x600133A")]
	public override bool WaitOne(int millisecondsTimeout) { }

	[Address(RVA = "0x20C6130", Offset = "0x20C5530", Length = "0x1C")]
	[Token(Token = "0x6001339")]
	public override bool WaitOne() { }

	[Address(RVA = "0x20C6150", Offset = "0x20C5550", Length = "0x1BC")]
	[Token(Token = "0x6001338")]
	public override bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	[Address(RVA = "0x20C6310", Offset = "0x20C5710", Length = "0x14B")]
	[Token(Token = "0x600133B")]
	private bool WaitOne(long timeout, bool exitContext) { }

	[Address(RVA = "0x20C5F10", Offset = "0x20C5310", Length = "0x1FA")]
	[Token(Token = "0x6001344")]
	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

}

