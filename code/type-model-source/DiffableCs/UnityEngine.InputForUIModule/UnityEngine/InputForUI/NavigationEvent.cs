namespace UnityEngine.InputForUI;

[Token(Token = "0x2000015")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal struct NavigationEvent : IEventProperties
{
	[Token(Token = "0x2000017")]
	internal enum Direction : int
	{
		None = 0,
		Left = 1,
		Up = 2,
		Right = 3,
		Down = 4,
		Next = 5,
		Previous = 6,
	}

	[Token(Token = "0x2000016")]
	internal enum Type : int
	{
		Move = 1,
		Submit = 2,
		Cancel = 3,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000066")]
	public Type type; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000067")]
	public Direction direction; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000068")]
	public bool shouldBeUsed; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000069")]
	private DiscreteTime <timestamp>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400006A")]
	private EventSource <eventSource>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400006B")]
	private uint <playerId>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400006C")]
	private EventModifiers <eventModifiers>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000025")]
	public override EventModifiers eventModifiers
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000053")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000054")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000023")]
	public override EventSource eventSource
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000050")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000051")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000024")]
	public uint playerId
	{
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000052")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000022")]
	public DiscreteTime timestamp
	{
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600004F")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x310E970", Offset = "0x310DD70", Length = "0x6D")]
	[Token(Token = "0x6000056")]
	internal static Direction DetermineMoveDirection(Vector2 vec, float deadZone = 0.6) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000053")]
	public override EventModifiers get_eventModifiers() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6000050")]
	public override EventSource get_eventSource() { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000054")]
	public void set_eventModifiers(EventModifiers value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000051")]
	public void set_eventSource(EventSource value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000052")]
	public void set_playerId(uint value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600004F")]
	public void set_timestamp(DiscreteTime value) { }

	[Address(RVA = "0x310E9E0", Offset = "0x310DDE0", Length = "0x11D")]
	[Token(Token = "0x6000055")]
	public virtual string ToString() { }

}

