namespace System.Threading;

[Token(Token = "0x2000231")]
public sealed class Thread : CriticalFinalizerObject
{
	[ThreadStatic]
	[Token(Token = "0x4000A1F")]
	private static LocalDataStoreHolder s_LocalDataStore; //Field offset: 0x80000000
	[ThreadStatic]
	[Token(Token = "0x4000A20")]
	internal static CultureInfo m_CurrentCulture; //Field offset: 0x80000008
	[ThreadStatic]
	[Token(Token = "0x4000A21")]
	internal static CultureInfo m_CurrentUICulture; //Field offset: 0x80000010
	[ThreadStatic]
	[Token(Token = "0x4000A27")]
	private static Thread current_thread; //Field offset: 0x80000018
	[Token(Token = "0x4000A1E")]
	private static LocalDataStoreMgr s_LocalDataStoreMgr; //Field offset: 0x0
	[Token(Token = "0x4000A22")]
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; //Field offset: 0x8
	[Token(Token = "0x4000A23")]
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A24")]
	private InternalThread internal_thread; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A25")]
	private object m_ThreadStartArg; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A26")]
	private object pending_exception; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A28")]
	private MulticastDelegate m_Delegate; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A29")]
	private ExecutionContext m_ExecutionContext; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A2A")]
	private bool m_ExecutionContextBelongsToOuterScope; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A2B")]
	private IPrincipal principal; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A2C")]
	private int principal_version; //Field offset: 0x48

	[Token(Token = "0x170001B9")]
	public static Context CurrentContext
	{
		[Address(RVA = "0x1EE04E0", Offset = "0x1EDF8E0", Length = "0x7")]
		[Token(Token = "0x60012D4")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001B7")]
	public CultureInfo CurrentCulture
	{
		[Address(RVA = "0x20C33A0", Offset = "0x20C27A0", Length = "0x34")]
		[Token(Token = "0x60012CF")]
		 get { } //Length: 52
	}

	[Token(Token = "0x170001BA")]
	public static Thread CurrentThread
	{
		[Address(RVA = "0x20C3450", Offset = "0x20C2850", Length = "0x4E")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
		[Token(Token = "0x60012D7")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170001BB")]
	internal static int CurrentThreadId
	{
		[Address(RVA = "0x20C33E0", Offset = "0x20C27E0", Length = "0x64")]
		[Token(Token = "0x60012D8")]
		internal get { } //Length: 100
	}

	[Token(Token = "0x170001B6")]
	public CultureInfo CurrentUICulture
	{
		[Address(RVA = "0x20C34A0", Offset = "0x20C28A0", Length = "0x34")]
		[Token(Token = "0x60012CD")]
		 get { } //Length: 52
	}

	[Token(Token = "0x170001B5")]
	internal bool ExecutionContextBelongsToCurrentScope
	{
		[Address(RVA = "0x20C34E0", Offset = "0x20C28E0", Length = "0x8")]
		[Token(Token = "0x60012C1")]
		internal get { } //Length: 8
		[Address(RVA = "0x20C3590", Offset = "0x20C2990", Length = "0x7")]
		[Token(Token = "0x60012C2")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x170001B8")]
	private InternalThread Internal
	{
		[Address(RVA = "0x20C34F0", Offset = "0x20C28F0", Length = "0x29")]
		[Token(Token = "0x60012D3")]
		private get { } //Length: 41
	}

	[Token(Token = "0x170001BE")]
	public bool IsAlive
	{
		[Address(RVA = "0x20C3520", Offset = "0x20C2920", Length = "0x2C")]
		[Token(Token = "0x60012DE")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170001BF")]
	public bool IsBackground
	{
		[Address(RVA = "0x20C35A0", Offset = "0x20C29A0", Length = "0xC4")]
		[Token(Token = "0x60012DF")]
		 set { } //Length: 196
	}

	[Token(Token = "0x170001BC")]
	public bool IsThreadPoolThread
	{
		[Address(RVA = "0x20C3550", Offset = "0x20C2950", Length = "0x30")]
		[Token(Token = "0x60012DC")]
		 get { } //Length: 48
	}

	[Token(Token = "0x170001BD")]
	internal bool IsThreadPoolThreadInternal
	{
		[Address(RVA = "0x20C3550", Offset = "0x20C2950", Length = "0x30")]
		[Token(Token = "0x60012DD")]
		internal get { } //Length: 48
	}

	[Token(Token = "0x170001C1")]
	public int ManagedThreadId
	{
		[Address(RVA = "0x20C28E0", Offset = "0x20C1CE0", Length = "0x2F")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x60012ED")]
		 get { } //Length: 47
	}

	[Token(Token = "0x170001C0")]
	public string Name
	{
		[Address(RVA = "0x20C3670", Offset = "0x20C2A70", Length = "0x60")]
		[Token(Token = "0x60012E2")]
		 set { } //Length: 96
	}

	[Address(RVA = "0x20C32A0", Offset = "0x20C26A0", Length = "0x7F")]
	[Token(Token = "0x60012BA")]
	public Thread(ThreadStart start) { }

	[Address(RVA = "0x20C3320", Offset = "0x20C2720", Length = "0x7F")]
	[Token(Token = "0x60012BB")]
	public Thread(ParameterizedThreadStart start) { }

	[Address(RVA = "0x20C31A0", Offset = "0x20C25A0", Length = "0xF5")]
	[Token(Token = "0x60012BC")]
	public Thread(ParameterizedThreadStart start, int maxStackSize) { }

	[Address(RVA = "0x20C25C0", Offset = "0x20C19C0", Length = "0x96")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x60012EE")]
	public static void BeginCriticalRegion() { }

	[Address(RVA = "0x20C2660", Offset = "0x20C1A60", Length = "0x5")]
	[Token(Token = "0x60012E7")]
	private static void ClrState(InternalThread thread, ThreadState clr) { }

	[Address(RVA = "0x20C2670", Offset = "0x20C1A70", Length = "0x5")]
	[Token(Token = "0x60012D2")]
	private void ConstructInternalThread() { }

	[Address(RVA = "0x20C2680", Offset = "0x20C1A80", Length = "0x96")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012EF")]
	public static void EndCriticalRegion() { }

	[Address(RVA = "0x20B33A0", Offset = "0x20B27A0", Length = "0x32")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012DB")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1EE04E0", Offset = "0x1EDF8E0", Length = "0x7")]
	[Token(Token = "0x60012D4")]
	public static Context get_CurrentContext() { }

	[Address(RVA = "0x20C33A0", Offset = "0x20C27A0", Length = "0x34")]
	[Token(Token = "0x60012CF")]
	public CultureInfo get_CurrentCulture() { }

	[Address(RVA = "0x20C3450", Offset = "0x20C2850", Length = "0x4E")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x60012D7")]
	public static Thread get_CurrentThread() { }

	[Address(RVA = "0x20C33E0", Offset = "0x20C27E0", Length = "0x64")]
	[Token(Token = "0x60012D8")]
	internal static int get_CurrentThreadId() { }

	[Address(RVA = "0x20C34A0", Offset = "0x20C28A0", Length = "0x34")]
	[Token(Token = "0x60012CD")]
	public CultureInfo get_CurrentUICulture() { }

	[Address(RVA = "0x20C34E0", Offset = "0x20C28E0", Length = "0x8")]
	[Token(Token = "0x60012C1")]
	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	[Address(RVA = "0x20C34F0", Offset = "0x20C28F0", Length = "0x29")]
	[Token(Token = "0x60012D3")]
	private InternalThread get_Internal() { }

	[Address(RVA = "0x20C3520", Offset = "0x20C2920", Length = "0x2C")]
	[Token(Token = "0x60012DE")]
	public bool get_IsAlive() { }

	[Address(RVA = "0x20C3550", Offset = "0x20C2950", Length = "0x30")]
	[Token(Token = "0x60012DC")]
	public bool get_IsThreadPoolThread() { }

	[Address(RVA = "0x20C3550", Offset = "0x20C2950", Length = "0x30")]
	[Token(Token = "0x60012DD")]
	internal bool get_IsThreadPoolThreadInternal() { }

	[Address(RVA = "0x20C28E0", Offset = "0x20C1CE0", Length = "0x2F")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012ED")]
	public int get_ManagedThreadId() { }

	[Address(RVA = "0x20C2720", Offset = "0x20C1B20", Length = "0x99")]
	[Token(Token = "0x60012D0")]
	private CultureInfo GetCurrentCultureNoAppX() { }

	[Address(RVA = "0x20C27D0", Offset = "0x20C1BD0", Length = "0x21")]
	[Token(Token = "0x60012D6")]
	private static Thread GetCurrentThread() { }

	[Address(RVA = "0x20C27C0", Offset = "0x20C1BC0", Length = "0x5")]
	[Token(Token = "0x60012D5")]
	private static void GetCurrentThread_icall(ref Thread thread) { }

	[Address(RVA = "0x20C2800", Offset = "0x20C1C00", Length = "0x99")]
	[Token(Token = "0x60012CE")]
	internal CultureInfo GetCurrentUICultureNoAppX() { }

	[Address(RVA = "0x20C28A0", Offset = "0x20C1CA0", Length = "0x5")]
	[Token(Token = "0x60012D9")]
	public static int GetDomainID() { }

	[Address(RVA = "0x20C28B0", Offset = "0x20C1CB0", Length = "0x21")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012C0")]
	internal Reader GetExecutionContextReader() { }

	[Address(RVA = "0x20C28E0", Offset = "0x20C1CE0", Length = "0x2F")]
	[ComVisible(False)]
	[Token(Token = "0x60012F0")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x20C2910", Offset = "0x20C1D10", Length = "0x9C")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x60012C3")]
	internal ExecutionContext GetMutableExecutionContext() { }

	[Address(RVA = "0x20C29B0", Offset = "0x20C1DB0", Length = "0x9D")]
	[Token(Token = "0x60012EB")]
	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	[Address(RVA = "0x20C2A50", Offset = "0x20C1E50", Length = "0x5")]
	[Token(Token = "0x60012E8")]
	private static ThreadState GetState(InternalThread thread) { }

	[Address(RVA = "0x20C2A70", Offset = "0x20C1E70", Length = "0xA")]
	[Token(Token = "0x60012C7")]
	public void Join() { }

	[Address(RVA = "0x20C2A60", Offset = "0x20C1E60", Length = "0x5")]
	[Token(Token = "0x60012C6")]
	private bool JoinInternal(int millisecondsTimeout) { }

	[Address(RVA = "0x20B2030", Offset = "0x20B1430", Length = "0x5")]
	[Token(Token = "0x60012D1")]
	public static void MemoryBarrier() { }

	[Address(RVA = "0x20C3590", Offset = "0x20C2990", Length = "0x7")]
	[Token(Token = "0x60012C2")]
	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[Address(RVA = "0x20C35A0", Offset = "0x20C29A0", Length = "0xC4")]
	[Token(Token = "0x60012DF")]
	public void set_IsBackground(bool value) { }

	[Address(RVA = "0x20C3670", Offset = "0x20C2A70", Length = "0x60")]
	[Token(Token = "0x60012E2")]
	public void set_Name(string value) { }

	[Address(RVA = "0x20C2A80", Offset = "0x20C1E80", Length = "0x31")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012C5")]
	internal void SetExecutionContext(Reader value, bool belongsToCurrentScope) { }

	[Address(RVA = "0x20C2A80", Offset = "0x20C1E80", Length = "0x31")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012C4")]
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[Address(RVA = "0x20C2AC0", Offset = "0x20C1EC0", Length = "0x5")]
	[Token(Token = "0x60012E0")]
	private static void SetName_icall(InternalThread thread, Char* name, int nameLength) { }

	[Address(RVA = "0x20C2AD0", Offset = "0x20C1ED0", Length = "0x4D")]
	[Token(Token = "0x60012E1")]
	private static void SetName_internal(InternalThread thread, string name) { }

	[Address(RVA = "0x20C2CE0", Offset = "0x20C20E0", Length = "0x4B")]
	[Token(Token = "0x60012EC")]
	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[Address(RVA = "0x20C2B20", Offset = "0x20C1F20", Length = "0x1B9")]
	[Token(Token = "0x60012CC")]
	private void SetStartHelper(Delegate start, int maxStackSize) { }

	[Address(RVA = "0x20C2D30", Offset = "0x20C2130", Length = "0x5")]
	[Token(Token = "0x60012E6")]
	private static void SetState(InternalThread thread, ThreadState set) { }

	[Address(RVA = "0x20C2D50", Offset = "0x20C2150", Length = "0x8A")]
	[Token(Token = "0x60012C9")]
	public static void Sleep(int millisecondsTimeout) { }

	[Address(RVA = "0x20C2D40", Offset = "0x20C2140", Length = "0x5")]
	[Token(Token = "0x60012C8")]
	private static void SleepInternal(int millisecondsTimeout) { }

	[Address(RVA = "0x20C2DE0", Offset = "0x20C21E0", Length = "0x26")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012E4")]
	public static void SpinWait(int iterations) { }

	[Address(RVA = "0x1F685D0", Offset = "0x1F679D0", Length = "0x5")]
	[Token(Token = "0x60012E3")]
	private static void SpinWait_nop() { }

	[Address(RVA = "0x20C2EB0", Offset = "0x20C22B0", Length = "0x14A")]
	[Token(Token = "0x60012BF")]
	private void Start(ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x20C3000", Offset = "0x20C2400", Length = "0xD8")]
	[Token(Token = "0x60012BE")]
	public void Start(object parameter) { }

	[Address(RVA = "0x20C2E90", Offset = "0x20C2290", Length = "0x1E")]
	[Token(Token = "0x60012BD")]
	public void Start() { }

	[Address(RVA = "0x20C2E10", Offset = "0x20C2210", Length = "0x76")]
	[Token(Token = "0x60012E5")]
	private void StartInternal(object principal, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x20C30E0", Offset = "0x20C24E0", Length = "0x5")]
	[Token(Token = "0x60012EA")]
	private static int SystemMaxStackStize() { }

	[Address(RVA = "0x20C30F0", Offset = "0x20C24F0", Length = "0x5")]
	[Token(Token = "0x60012DA")]
	private bool Thread_internal(MulticastDelegate start) { }

	[Address(RVA = "0x20C3100", Offset = "0x20C2500", Length = "0x70")]
	[Token(Token = "0x60012F1")]
	private ThreadState ValidateThreadState() { }

	[Address(RVA = "0x20C3180", Offset = "0x20C2580", Length = "0x5")]
	[Token(Token = "0x60012E9")]
	public static object VolatileRead(ref object address) { }

	[Address(RVA = "0x20C3190", Offset = "0x20C2590", Length = "0x5")]
	[Token(Token = "0x60012CB")]
	public static bool Yield() { }

	[Address(RVA = "0x20C3190", Offset = "0x20C2590", Length = "0x5")]
	[Token(Token = "0x60012CA")]
	private static bool YieldInternal() { }

}

