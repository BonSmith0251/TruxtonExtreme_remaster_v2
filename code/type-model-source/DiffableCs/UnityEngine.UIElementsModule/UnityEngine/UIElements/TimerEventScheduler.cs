namespace UnityEngine.UIElements;

[Token(Token = "0x20002E9")]
internal class TimerEventScheduler
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BD8")]
	private readonly List<ScheduledItem> m_ScheduledItems; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BD9")]
	private bool m_TransactionMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BDA")]
	private readonly List<ScheduledItem> m_ScheduleTransactions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BDB")]
	private readonly HashSet<ScheduledItem> m_UnscheduleTransactions; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BDC")]
	internal bool disableThrottling; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000BDD")]
	private int m_LastUpdatedIndex; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000BDE")]
	private BaseVisualElementPanel panel; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000BDF")]
	private long frameCount; //Field offset: 0x40

	[Token(Token = "0x170003F7")]
	public long FrameCount
	{
		[Address(RVA = "0x2F944C0", Offset = "0x2F938C0", Length = "0x7")]
		[Token(Token = "0x6001458")]
		 get { } //Length: 7
		[Address(RVA = "0x1116970", Offset = "0x1115D70", Length = "0x5")]
		[Token(Token = "0x6001459")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x32465A0", Offset = "0x32459A0", Length = "0x113")]
	[Token(Token = "0x6001453")]
	public TimerEventScheduler(BaseVisualElementPanel p) { }

	[Address(RVA = "0x2F944C0", Offset = "0x2F938C0", Length = "0x7")]
	[Token(Token = "0x6001458")]
	public long get_FrameCount() { }

	[Address(RVA = "0x32459E0", Offset = "0x3244DE0", Length = "0xD3")]
	[Token(Token = "0x6001457")]
	private bool PrivateUnSchedule(ScheduledItem sItem) { }

	[Address(RVA = "0x3245AC0", Offset = "0x3244EC0", Length = "0x6D")]
	[Token(Token = "0x6001455")]
	private bool RemovedScheduledItemAt(int index) { }

	[Address(RVA = "0x3245B30", Offset = "0x3244F30", Length = "0x1D1")]
	[Token(Token = "0x6001454")]
	public void Schedule(ScheduledItem item) { }

	[Address(RVA = "0x1116970", Offset = "0x1115D70", Length = "0x5")]
	[Token(Token = "0x6001459")]
	public void set_FrameCount(long value) { }

	[Address(RVA = "0x3245D10", Offset = "0x3245110", Length = "0x26B")]
	[Token(Token = "0x6001456")]
	public void Unschedule(ScheduledItem item) { }

	[Address(RVA = "0x3245F80", Offset = "0x3245380", Length = "0x61C")]
	[Token(Token = "0x600145A")]
	public void UpdateScheduledEvents() { }

}

