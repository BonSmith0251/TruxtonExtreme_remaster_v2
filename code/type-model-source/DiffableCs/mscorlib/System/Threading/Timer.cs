namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x200024A")]
public sealed class Timer : MarshalByRefObject, IDisposable
{
	[Token(Token = "0x200024C")]
	private sealed class Scheduler
	{
		[Token(Token = "0x4000A99")]
		private static readonly Scheduler instance; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A9A")]
		private bool needReSort; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000A9B")]
		private List<Timer> list; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A9C")]
		private long current_next_run; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000A9D")]
		private ManualResetEvent changed; //Field offset: 0x28

		[Token(Token = "0x170001C8")]
		public static Scheduler Instance
		{
			[Address(RVA = "0x20B4D10", Offset = "0x20B4110", Length = "0x4E")]
			[Token(Token = "0x6001388")]
			 get { } //Length: 78
		}

		[Address(RVA = "0x20B4B80", Offset = "0x20B3F80", Length = "0xEC")]
		[Token(Token = "0x6001391")]
		private static Scheduler() { }

		[Address(RVA = "0x20B4C70", Offset = "0x20B4070", Length = "0x9D")]
		[Token(Token = "0x6001389")]
		private Scheduler() { }

		[Address(RVA = "0x20B3EA0", Offset = "0x20B32A0", Length = "0xE7")]
		[Token(Token = "0x600138C")]
		private void Add(Timer timer) { }

		[Address(RVA = "0x20B3F90", Offset = "0x20B3390", Length = "0x246")]
		[Token(Token = "0x600138B")]
		public void Change(Timer timer, long new_next_run) { }

		[Address(RVA = "0x20B41E0", Offset = "0x20B35E0", Length = "0xC4")]
		[Token(Token = "0x600138F")]
		private void FireTimer(Timer timer) { }

		[Address(RVA = "0x20B4D10", Offset = "0x20B4110", Length = "0x4E")]
		[Token(Token = "0x6001388")]
		public static Scheduler get_Instance() { }

		[Address(RVA = "0x20B42B0", Offset = "0x20B36B0", Length = "0x1C3")]
		[Token(Token = "0x6001385")]
		private void InitScheduler() { }

		[Address(RVA = "0x20B4480", Offset = "0x20B3880", Length = "0x26")]
		[Token(Token = "0x600138D")]
		private void InternalRemove(Timer timer) { }

		[Address(RVA = "0x20B44B0", Offset = "0x20B38B0", Length = "0x9D")]
		[Token(Token = "0x600138A")]
		public void Remove(Timer timer) { }

		[Address(RVA = "0x20B4550", Offset = "0x20B3950", Length = "0x3B0")]
		[Token(Token = "0x6001390")]
		private int RunSchedulerLoop() { }

		[Address(RVA = "0x20B4910", Offset = "0x20B3D10", Length = "0x1C6")]
		[Token(Token = "0x6001387")]
		private void SchedulerThread() { }

		[Address(RVA = "0x20B4AE0", Offset = "0x20B3EE0", Length = "0x71")]
		[Token(Token = "0x600138E")]
		private static void TimerCB(object o) { }

		[Address(RVA = "0x20B4B60", Offset = "0x20B3F60", Length = "0x1D")]
		[Token(Token = "0x6001386")]
		private void WakeupScheduler() { }

	}

	[Token(Token = "0x200024B")]
	private struct TimerComparer : IComparer, IComparer<Timer>
	{

		[Address(RVA = "0x20C36D0", Offset = "0x20C2AD0", Length = "0x6F")]
		[Token(Token = "0x6001384")]
		public override int Compare(Timer tx, Timer ty) { }

		[Address(RVA = "0x20C3740", Offset = "0x20C2B40", Length = "0xE6")]
		[Token(Token = "0x6001383")]
		private override int System.Collections.IComparer.Compare(object x, object y) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A91")]
	private TimerCallback callback; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A92")]
	private object state; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A93")]
	private long due_time_ms; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A94")]
	private long period_ms; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A95")]
	private long next_run; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A96")]
	private bool disposed; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000A97")]
	private bool is_dead; //Field offset: 0x41
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x4000A98")]
	private bool is_added; //Field offset: 0x42

	[Token(Token = "0x170001C7")]
	private static Scheduler scheduler
	{
		[Address(RVA = "0x20C3E60", Offset = "0x20C3260", Length = "0x89")]
		[Token(Token = "0x6001379")]
		private get { } //Length: 137
	}

	[Address(RVA = "0x20C3C60", Offset = "0x20C3060", Length = "0xCA")]
	[Token(Token = "0x600137A")]
	public Timer(TimerCallback callback, object state, int dueTime, int period) { }

	[Address(RVA = "0x20C3D30", Offset = "0x20C3130", Length = "0x12B")]
	[Token(Token = "0x600137B")]
	public Timer(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	[Address(RVA = "0x20C3AA0", Offset = "0x20C2EA0", Length = "0x20")]
	[Token(Token = "0x600137D")]
	public bool Change(int dueTime, int period) { }

	[Address(RVA = "0x20C3AC0", Offset = "0x20C2EC0", Length = "0x8C")]
	[Token(Token = "0x600137E")]
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	[Address(RVA = "0x20C3830", Offset = "0x20C2C30", Length = "0x268")]
	[Token(Token = "0x6001380")]
	private bool Change(long dueTime, long period, bool first) { }

	[Address(RVA = "0x20C3B50", Offset = "0x20C2F50", Length = "0x3D")]
	[Token(Token = "0x600137F")]
	public override void Dispose() { }

	[Address(RVA = "0x20C3E60", Offset = "0x20C3260", Length = "0x89")]
	[Token(Token = "0x6001379")]
	private static Scheduler get_scheduler() { }

	[Address(RVA = "0x20C3B90", Offset = "0x20C2F90", Length = "0x5")]
	[Token(Token = "0x6001382")]
	private static long GetTimeMonotonic() { }

	[Address(RVA = "0x20C3BA0", Offset = "0x20C2FA0", Length = "0xB3")]
	[Token(Token = "0x600137C")]
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001381")]
	internal void KeepRootedWhileScheduled() { }

}

