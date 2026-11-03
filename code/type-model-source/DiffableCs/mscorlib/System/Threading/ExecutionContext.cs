namespace System.Threading;

[Token(Token = "0x2000225")]
public sealed class ExecutionContext : IDisposable, ISerializable
{
	[Flags]
	[Token(Token = "0x2000228")]
	public enum CaptureOptions : int
	{
		None = 0,
		IgnoreSyncCtx = 1,
		OptimizeDefaultCase = 2,
	}

	[Token(Token = "0x2000226")]
	private enum Flags : int
	{
		None = 0,
		IsNewCapture = 1,
		IsFlowSuppressed = 2,
		IsPreAllocatedDefault = 4,
	}

	[Token(Token = "0x2000227")]
	public struct Reader
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A0B")]
		private ExecutionContext m_ec; //Field offset: 0x0

		[Token(Token = "0x170001AE")]
		public bool IsFlowSuppressed
		{
			[Address(RVA = "0x20A2B60", Offset = "0x20A1F60", Length = "0x14")]
			[Token(Token = "0x600127E")]
			 get { } //Length: 20
		}

		[Token(Token = "0x170001AD")]
		public bool IsNull
		{
			[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
			[Token(Token = "0x600127C")]
			 get { } //Length: 8
		}

		[Token(Token = "0x170001B1")]
		public Reader LogicalCallContext
		{
			[Address(RVA = "0x20A2B80", Offset = "0x20A1F80", Length = "0x34")]
			[Token(Token = "0x6001281")]
			 get { } //Length: 52
		}

		[Token(Token = "0x170001AF")]
		public SynchronizationContext SynchronizationContext
		{
			[Address(RVA = "0x20A2BE0", Offset = "0x20A1FE0", Length = "0x11")]
			[Token(Token = "0x600127F")]
			 get { } //Length: 17
		}

		[Token(Token = "0x170001B0")]
		public SynchronizationContext SynchronizationContextNoFlow
		{
			[Address(RVA = "0x20A2BC0", Offset = "0x20A1FC0", Length = "0x11")]
			[Token(Token = "0x6001280")]
			 get { } //Length: 17
		}

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x600127A")]
		public Reader(ExecutionContext ec) { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x600127B")]
		public ExecutionContext DangerousGetRawExecutionContext() { }

		[Address(RVA = "0x20A2B60", Offset = "0x20A1F60", Length = "0x14")]
		[Token(Token = "0x600127E")]
		public bool get_IsFlowSuppressed() { }

		[Address(RVA = "0x1F12030", Offset = "0x1F11430", Length = "0x8")]
		[Token(Token = "0x600127C")]
		public bool get_IsNull() { }

		[Address(RVA = "0x20A2B80", Offset = "0x20A1F80", Length = "0x34")]
		[Token(Token = "0x6001281")]
		public Reader get_LogicalCallContext() { }

		[Address(RVA = "0x20A2BE0", Offset = "0x20A1FE0", Length = "0x11")]
		[Token(Token = "0x600127F")]
		public SynchronizationContext get_SynchronizationContext() { }

		[Address(RVA = "0x20A2BC0", Offset = "0x20A1FC0", Length = "0x11")]
		[Token(Token = "0x6001280")]
		public SynchronizationContext get_SynchronizationContextNoFlow() { }

		[Address(RVA = "0x20A2AD0", Offset = "0x20A1ED0", Length = "0x24")]
		[Token(Token = "0x6001282")]
		public bool HasSameLocalValues(ExecutionContext other) { }

		[Address(RVA = "0x20A2B00", Offset = "0x20A1F00", Length = "0x5A")]
		[Token(Token = "0x600127D")]
		public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	}

	[Token(Token = "0x4000A04")]
	private static readonly ExecutionContext s_dummyDefaultEC; //Field offset: 0x0
	[Token(Token = "0x4000A05")]
	internal static readonly ExecutionContext Default; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009FD")]
	private SynchronizationContext _syncContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009FE")]
	private SynchronizationContext _syncContextNoFlow; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009FF")]
	private LogicalCallContext _logicalCallContext; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A00")]
	private IllogicalCallContext _illogicalCallContext; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A01")]
	private Flags _flags; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A02")]
	private Dictionary<IAsyncLocal, Object> _localValues; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A03")]
	private List<IAsyncLocal> _localChangeNotifications; //Field offset: 0x40

	[Token(Token = "0x170001AA")]
	internal IllogicalCallContext IllogicalCallContext
	{
		[Address(RVA = "0x209F340", Offset = "0x209E740", Length = "0x69")]
		[Token(Token = "0x6001260")]
		internal get { } //Length: 105
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x6001261")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170001A7")]
	internal bool isFlowSuppressed
	{
		[Address(RVA = "0x209F430", Offset = "0x209E830", Length = "0x8")]
		[Token(Token = "0x6001258")]
		internal get { } //Length: 8
		[Address(RVA = "0x209F450", Offset = "0x209E850", Length = "0x19")]
		[Token(Token = "0x6001259")]
		internal set { } //Length: 25
	}

	[Token(Token = "0x170001A6")]
	internal bool isNewCapture
	{
		[Address(RVA = "0x209F440", Offset = "0x209E840", Length = "0x8")]
		[Token(Token = "0x6001256")]
		internal get { } //Length: 8
		[Address(RVA = "0x209F470", Offset = "0x209E870", Length = "0x19")]
		[Token(Token = "0x6001257")]
		internal set { } //Length: 25
	}

	[Token(Token = "0x170001A8")]
	internal bool IsPreAllocatedDefault
	{
		[Address(RVA = "0x209F3B0", Offset = "0x209E7B0", Length = "0x9")]
		[Token(Token = "0x600125A")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x170001A9")]
	internal LogicalCallContext LogicalCallContext
	{
		[Address(RVA = "0x209F3C0", Offset = "0x209E7C0", Length = "0x69")]
		[Token(Token = "0x600125E")]
		internal get { } //Length: 105
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x600125F")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170001AB")]
	internal SynchronizationContext SynchronizationContext
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x6001262")]
		internal get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x6001263")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170001AC")]
	internal SynchronizationContext SynchronizationContextNoFlow
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x6001264")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x6001265")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x209F110", Offset = "0x209E510", Length = "0xB3")]
	[Token(Token = "0x6001279")]
	private static ExecutionContext() { }

	[Address(RVA = "0x209F200", Offset = "0x209E600", Length = "0x134")]
	[Token(Token = "0x6001277")]
	private ExecutionContext(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600125B")]
	internal ExecutionContext() { }

	[Address(RVA = "0x209F1D0", Offset = "0x209E5D0", Length = "0x2D")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x600125C")]
	internal ExecutionContext(bool isPreAllocatedDefault) { }

	[Address(RVA = "0x209DCD0", Offset = "0x209D0D0", Length = "0x1F9")]
	[Token(Token = "0x6001275")]
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, CaptureOptions options) { }

	[Address(RVA = "0x209DED0", Offset = "0x209D2D0", Length = "0x48")]
	[Token(Token = "0x6001273")]
	public static ExecutionContext Capture() { }

	[Address(RVA = "0x209DF20", Offset = "0x209D320", Length = "0x182")]
	[Token(Token = "0x600126E")]
	public ExecutionContext CreateCopy() { }

	[Address(RVA = "0x209E0B0", Offset = "0x209D4B0", Length = "0x1A0")]
	[Token(Token = "0x600126F")]
	internal ExecutionContext CreateMutableCopy() { }

	[Address(RVA = "0x945130", Offset = "0x944530", Length = "0x3")]
	[Token(Token = "0x6001266")]
	public override void Dispose() { }

	[Address(RVA = "0x209E300", Offset = "0x209D700", Length = "0x62")]
	[Token(Token = "0x600126C")]
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[Address(RVA = "0x209E260", Offset = "0x209D660", Length = "0x9D")]
	[Token(Token = "0x600126B")]
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	[Address(RVA = "0x209E370", Offset = "0x209D770", Length = "0x4B")]
	[FriendAccessAllowed]
	[Token(Token = "0x6001274")]
	internal static ExecutionContext FastCapture() { }

	[Address(RVA = "0x209F340", Offset = "0x209E740", Length = "0x69")]
	[Token(Token = "0x6001260")]
	internal IllogicalCallContext get_IllogicalCallContext() { }

	[Address(RVA = "0x209F430", Offset = "0x209E830", Length = "0x8")]
	[Token(Token = "0x6001258")]
	internal bool get_isFlowSuppressed() { }

	[Address(RVA = "0x209F440", Offset = "0x209E840", Length = "0x8")]
	[Token(Token = "0x6001256")]
	internal bool get_isNewCapture() { }

	[Address(RVA = "0x209F3B0", Offset = "0x209E7B0", Length = "0x9")]
	[Token(Token = "0x600125A")]
	internal bool get_IsPreAllocatedDefault() { }

	[Address(RVA = "0x209F3C0", Offset = "0x209E7C0", Length = "0x69")]
	[Token(Token = "0x600125E")]
	internal LogicalCallContext get_LogicalCallContext() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001262")]
	internal SynchronizationContext get_SynchronizationContext() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001264")]
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[Address(RVA = "0x209E3C0", Offset = "0x209D7C0", Length = "0xE9")]
	[Token(Token = "0x6001276")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x209E4B0", Offset = "0x209D8B0", Length = "0x50")]
	[Token(Token = "0x6001278")]
	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	[Address(RVA = "0x209E500", Offset = "0x209D900", Length = "0x35")]
	[Token(Token = "0x6001272")]
	public static bool IsFlowSuppressed() { }

	[Address(RVA = "0x209E540", Offset = "0x209D940", Length = "0x3B4")]
	[HandleProcessCorruptedStateExceptions]
	[Token(Token = "0x600125D")]
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	[Address(RVA = "0x209E900", Offset = "0x209DD00", Length = "0x9D")]
	[Token(Token = "0x6001271")]
	public static void RestoreFlow() { }

	[Address(RVA = "0x209ED10", Offset = "0x209E110", Length = "0x15E")]
	[Token(Token = "0x6001267")]
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[Address(RVA = "0x209EC80", Offset = "0x209E080", Length = "0x81")]
	[FriendAccessAllowed]
	[Token(Token = "0x6001268")]
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	[Address(RVA = "0x209E9A0", Offset = "0x209DDA0", Length = "0x25F")]
	[HandleProcessCorruptedStateExceptions]
	[Token(Token = "0x600126A")]
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	[Address(RVA = "0x209EC00", Offset = "0x209E000", Length = "0x73")]
	[Token(Token = "0x6001269")]
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x6001261")]
	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[Address(RVA = "0x209F450", Offset = "0x209E850", Length = "0x19")]
	[Token(Token = "0x6001259")]
	internal void set_isFlowSuppressed(bool value) { }

	[Address(RVA = "0x209F470", Offset = "0x209E870", Length = "0x19")]
	[Token(Token = "0x6001257")]
	internal void set_isNewCapture(bool value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x600125F")]
	internal void set_LogicalCallContext(LogicalCallContext value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001263")]
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001265")]
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	[Address(RVA = "0x209EE70", Offset = "0x209E270", Length = "0x163")]
	[HandleProcessCorruptedStateExceptions]
	[Token(Token = "0x600126D")]
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

	[Address(RVA = "0x209EFE0", Offset = "0x209E3E0", Length = "0x129")]
	[Token(Token = "0x6001270")]
	public static AsyncFlowControl SuppressFlow() { }

}

