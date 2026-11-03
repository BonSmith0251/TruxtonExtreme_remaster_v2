namespace UnityEngine.UIElements;

[Token(Token = "0x20002E7")]
internal abstract class ScheduledItem
{
	[CompilerGenerated]
	[Token(Token = "0x20002E8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000BD7")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x32469B0", Offset = "0x3245DB0", Length = "0x67")]
		[Token(Token = "0x600144F")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001450")]
		public <>c() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001451")]
		internal bool <.cctor>b__26_0() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6001452")]
		internal bool <.cctor>b__26_1() { }

	}

	[Token(Token = "0x4000BD1")]
	public static readonly Func<Boolean> OnceCondition; //Field offset: 0x0
	[Token(Token = "0x4000BD2")]
	public static readonly Func<Boolean> ForeverCondition; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BD0")]
	public Func<Boolean> timerUpdateStopCondition; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BD3")]
	private long <startMs>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BD4")]
	private long <delayMs>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000BD5")]
	private long <intervalMs>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000BD6")]
	private long <endTimeMs>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x170003F4")]
	public long delayMs
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001444")]
		 get { } //Length: 5
		[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001445")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170003F6")]
	public long endTimeMs
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001448")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003F5")]
	public long intervalMs
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001446")]
		 get { } //Length: 5
		[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001447")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170003F3")]
	public long startMs
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001442")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001443")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x3245540", Offset = "0x3244940", Length = "0x135")]
	[Token(Token = "0x600144E")]
	private static ScheduledItem() { }

	[Address(RVA = "0x3245680", Offset = "0x3244A80", Length = "0x7A")]
	[Token(Token = "0x6001449")]
	public ScheduledItem(long startMs) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001444")]
	public long get_delayMs() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001448")]
	public long get_endTimeMs() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001446")]
	public long get_intervalMs() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001442")]
	public long get_startMs() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600144C")]
	internal override void OnItemUnscheduled() { }

	[Token(Token = "0x600144B")]
	public abstract void PerformTimerUpdate(TimerState state) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[Token(Token = "0x600144A")]
	protected void ResetStartTime(long startMs) { }

	[Address(RVA = "0x215EF90", Offset = "0x215E390", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001445")]
	public void set_delayMs(long value) { }

	[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001447")]
	public void set_intervalMs(long value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001443")]
	public void set_startMs(long value) { }

	[Address(RVA = "0x3245510", Offset = "0x3244910", Length = "0x29")]
	[Token(Token = "0x600144D")]
	public override bool ShouldUnschedule() { }

}

