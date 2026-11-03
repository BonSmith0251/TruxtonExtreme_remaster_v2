namespace UnityEngine.UIElements;

[Token(Token = "0x20002E6")]
public struct TimerState : IEquatable<TimerState>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BCE")]
	private long <start>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000BCF")]
	private long <now>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x170003F2")]
	public long deltaTime
	{
		[Address(RVA = "0x3246810", Offset = "0x3245C10", Length = "0xA")]
		[Token(Token = "0x600143E")]
		 get { } //Length: 10
	}

	[Token(Token = "0x170003F1")]
	public long now
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600143C")]
		 get { } //Length: 5
		[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600143D")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170003F0")]
	public long start
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600143A")]
		 get { } //Length: 4
		[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600143B")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x32466F0", Offset = "0x3245AF0", Length = "0x9C")]
	[Token(Token = "0x600143F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x32466C0", Offset = "0x3245AC0", Length = "0x29")]
	[Token(Token = "0x6001440")]
	public override bool Equals(TimerState other) { }

	[Address(RVA = "0x3246810", Offset = "0x3245C10", Length = "0xA")]
	[Token(Token = "0x600143E")]
	public long get_deltaTime() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600143C")]
	public long get_now() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x600143A")]
	public long get_start() { }

	[Address(RVA = "0x3246790", Offset = "0x3245B90", Length = "0x72")]
	[Token(Token = "0x6001441")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x20939F0", Offset = "0x2092DF0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600143D")]
	public void set_now(long value) { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600143B")]
	public void set_start(long value) { }

}

