namespace System.Net;

[Token(Token = "0x2000269")]
internal static class TimerThread
{
	[Token(Token = "0x200026C")]
	public sealed class Callback : MulticastDelegate
	{

		[Address(RVA = "0x26B3DA0", Offset = "0x26B31A0", Length = "0x125")]
		[Token(Token = "0x6001043")]
		public Callback(object object, IntPtr method) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x6001044")]
		public override void Invoke(Timer timer, int timeNoticed, object context) { }

	}

	[Token(Token = "0x2000271")]
	private class InfiniteTimer : Timer
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009E0")]
		private int cancelled; //Field offset: 0x18

		[Token(Token = "0x17000361")]
		internal virtual bool HasExpired
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6001054")]
			internal get { } //Length: 3
		}

		[Address(RVA = "0x26CBDD0", Offset = "0x26CB1D0", Length = "0x27")]
		[Token(Token = "0x6001053")]
		internal InfiniteTimer() { }

		[Address(RVA = "0x26CBDB0", Offset = "0x26CB1B0", Length = "0x1F")]
		[Token(Token = "0x6001055")]
		internal virtual bool Cancel() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001054")]
		internal virtual bool get_HasExpired() { }

	}

	[Token(Token = "0x200026E")]
	private class InfiniteTimerQueue : Queue
	{

		[Address(RVA = "0x26CBD90", Offset = "0x26CB190", Length = "0x1D")]
		[Token(Token = "0x6001048")]
		internal InfiniteTimerQueue() { }

		[Address(RVA = "0x26CBD30", Offset = "0x26CB130", Length = "0x55")]
		[Token(Token = "0x6001049")]
		internal virtual Timer CreateTimer(Callback callback, object context) { }

	}

	[Token(Token = "0x200026A")]
	public abstract class Queue
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009D0")]
		private readonly int m_DurationMilliseconds; //Field offset: 0x10

		[Token(Token = "0x1700035A")]
		internal int Duration
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x600103B")]
			internal get { } //Length: 85
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[Token(Token = "0x600103A")]
		internal Queue(int durationMilliseconds) { }

		[Token(Token = "0x600103C")]
		internal abstract Timer CreateTimer(Callback callback, object context) { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600103B")]
		internal int get_Duration() { }

	}

	[Token(Token = "0x200026B")]
	public abstract class Timer : IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009D1")]
		private readonly int m_StartTimeMilliseconds; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40009D2")]
		private readonly int m_DurationMilliseconds; //Field offset: 0x14

		[Token(Token = "0x1700035C")]
		internal int Expiration
		{
			[Address(RVA = "0x26CF910", Offset = "0x26CED10", Length = "0x7")]
			[Token(Token = "0x600103F")]
			internal get { } //Length: 7
		}

		[Token(Token = "0x1700035D")]
		internal abstract bool HasExpired
		{
			[Token(Token = "0x6001041")]
			internal get { } //Length: 0
		}

		[Token(Token = "0x1700035B")]
		internal int StartTime
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[Token(Token = "0x600103E")]
			internal get { } //Length: 85
		}

		[Address(RVA = "0x26CF8E0", Offset = "0x26CECE0", Length = "0x2E")]
		[Token(Token = "0x600103D")]
		internal Timer(int durationMilliseconds) { }

		[Token(Token = "0x6001040")]
		internal abstract bool Cancel() { }

		[Address(RVA = "0x1D214A0", Offset = "0x1D208A0", Length = "0x14")]
		[Token(Token = "0x6001042")]
		public override void Dispose() { }

		[Address(RVA = "0x26CF910", Offset = "0x26CED10", Length = "0x7")]
		[Token(Token = "0x600103F")]
		internal int get_Expiration() { }

		[Token(Token = "0x6001041")]
		internal abstract bool get_HasExpired() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x600103E")]
		internal int get_StartTime() { }

	}

	[Token(Token = "0x200026F")]
	private class TimerNode : Timer
	{
		[Token(Token = "0x2000270")]
		private enum TimerState : int
		{
			Ready = 0,
			Fired = 1,
			Cancelled = 2,
			Sentinel = 3,
		}

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009D5")]
		private TimerState m_TimerState; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40009D6")]
		private Callback m_Callback; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40009D7")]
		private object m_Context; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40009D8")]
		private object m_QueueLock; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40009D9")]
		private TimerNode next; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40009DA")]
		private TimerNode prev; //Field offset: 0x40

		[Token(Token = "0x1700035E")]
		internal virtual bool HasExpired
		{
			[Address(RVA = "0x26CDB10", Offset = "0x26CCF10", Length = "0x8")]
			[Token(Token = "0x600104C")]
			internal get { } //Length: 8
		}

		[Token(Token = "0x1700035F")]
		internal TimerNode Next
		{
			[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
			[Token(Token = "0x600104D")]
			internal get { } //Length: 5
			[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
			[Token(Token = "0x600104E")]
			internal set { } //Length: 13
		}

		[Token(Token = "0x17000360")]
		internal TimerNode Prev
		{
			[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
			[Token(Token = "0x600104F")]
			internal get { } //Length: 5
			[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
			[Token(Token = "0x6001050")]
			internal set { } //Length: 13
		}

		[Address(RVA = "0x26CDA80", Offset = "0x26CCE80", Length = "0x86")]
		[Token(Token = "0x600104A")]
		internal TimerNode(Callback callback, object context, int durationMilliseconds, object queueLock) { }

		[Address(RVA = "0x26CDA50", Offset = "0x26CCE50", Length = "0x2E")]
		[Token(Token = "0x600104B")]
		internal TimerNode() { }

		[Address(RVA = "0x26CD690", Offset = "0x26CCA90", Length = "0x143")]
		[Token(Token = "0x6001051")]
		internal virtual bool Cancel() { }

		[Address(RVA = "0x26CD7E0", Offset = "0x26CCBE0", Length = "0x265")]
		[Token(Token = "0x6001052")]
		internal bool Fire() { }

		[Address(RVA = "0x26CDB10", Offset = "0x26CCF10", Length = "0x8")]
		[Token(Token = "0x600104C")]
		internal virtual bool get_HasExpired() { }

		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600104D")]
		internal TimerNode get_Next() { }

		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600104F")]
		internal TimerNode get_Prev() { }

		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x600104E")]
		internal void set_Next(TimerNode value) { }

		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x6001050")]
		internal void set_Prev(TimerNode value) { }

	}

	[Token(Token = "0x200026D")]
	private class TimerQueue : Queue
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009D3")]
		private IntPtr m_ThisHandle; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40009D4")]
		private readonly TimerNode m_Timers; //Field offset: 0x20

		[Address(RVA = "0x26CE020", Offset = "0x26CD420", Length = "0xBA")]
		[Token(Token = "0x6001045")]
		internal TimerQueue(int durationMilliseconds) { }

		[Address(RVA = "0x26CDB20", Offset = "0x26CCF20", Length = "0x359")]
		[Token(Token = "0x6001046")]
		internal virtual Timer CreateTimer(Callback callback, object context) { }

		[Address(RVA = "0x26CDE80", Offset = "0x26CD280", Length = "0x197")]
		[Token(Token = "0x6001047")]
		internal bool Fire(out int nextExpiration) { }

	}

	[Token(Token = "0x40009C8")]
	private static LinkedList<WeakReference> s_Queues; //Field offset: 0x0
	[Token(Token = "0x40009C9")]
	private static LinkedList<WeakReference> s_NewQueues; //Field offset: 0x8
	[Token(Token = "0x40009CA")]
	private static int s_ThreadState; //Field offset: 0x10
	[Token(Token = "0x40009CB")]
	private static AutoResetEvent s_ThreadReadyEvent; //Field offset: 0x18
	[Token(Token = "0x40009CC")]
	private static ManualResetEvent s_ThreadShutdownEvent; //Field offset: 0x20
	[Token(Token = "0x40009CD")]
	private static WaitHandle[] s_ThreadEvents; //Field offset: 0x28
	[Token(Token = "0x40009CE")]
	private static int s_CacheScanIteration; //Field offset: 0x30
	[Token(Token = "0x40009CF")]
	private static Hashtable s_QueuesCache; //Field offset: 0x38

	[Address(RVA = "0x26CF590", Offset = "0x26CE990", Length = "0x34F")]
	[Token(Token = "0x6001032")]
	private static TimerThread() { }

	[Address(RVA = "0x26CE0E0", Offset = "0x26CD4E0", Length = "0x21E")]
	[Token(Token = "0x6001033")]
	internal static Queue CreateQueue(int durationMilliseconds) { }

	[Address(RVA = "0x26CE300", Offset = "0x26CD700", Length = "0x86F")]
	[Token(Token = "0x6001034")]
	internal static Queue GetOrCreateQueue(int durationMilliseconds) { }

	[Address(RVA = "0x26CEB70", Offset = "0x26CDF70", Length = "0x16")]
	[Token(Token = "0x6001038")]
	private static bool IsTickBetween(int start, int end, int comparand) { }

	[Address(RVA = "0x26CEB90", Offset = "0x26CDF90", Length = "0xB1")]
	[Token(Token = "0x6001039")]
	private static void OnDomainUnload(object sender, EventArgs e) { }

	[Address(RVA = "0x26CEC50", Offset = "0x26CE050", Length = "0x11A")]
	[Token(Token = "0x6001035")]
	private static void Prod() { }

	[Address(RVA = "0x26CED70", Offset = "0x26CE170", Length = "0x7B")]
	[Token(Token = "0x6001037")]
	private static void StopTimerThread() { }

	[Address(RVA = "0x26CEDF0", Offset = "0x26CE1F0", Length = "0x79F")]
	[Token(Token = "0x6001036")]
	private static void ThreadProc() { }

}

